pub mod Runtime {
    use super::*;
    type Async<T> = T;
    use fable_library_rust::DateTime_::DateTime;
    use fable_library_rust::Interfaces_::System::Collections::Generic::IEnumerable_1;
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
    use fable_library_rust::NativeArray_::new_array;
    use fable_library_rust::NativeArray_::new_empty;
    use fable_library_rust::NativeArray_::new_init;
    use fable_library_rust::NativeArray_::Array;
    use fable_library_rust::Native_::defaultOf;
    use fable_library_rust::Native_::on_startup;
    use fable_library_rust::Native_::refCell;
    use fable_library_rust::Native_::unbox;
    use fable_library_rust::Native_::Any;
    use fable_library_rust::Native_::Arc;
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
    use fable_library_rust::String_::append;
    use fable_library_rust::String_::getCharAt;
    use fable_library_rust::String_::getSlice;
    use fable_library_rust::String_::indexOf;
    use fable_library_rust::String_::join;
    use fable_library_rust::String_::length;
    use fable_library_rust::String_::ofChar;
    use fable_library_rust::String_::padLeft;
    use fable_library_rust::String_::replace;
    use fable_library_rust::String_::replicate;
    use fable_library_rust::String_::sprintf;
    use fable_library_rust::String_::string;
    use fable_library_rust::String_::toLower;
    use fable_library_rust::String_::trimEndChars;
    use fable_library_rust::String_::trimStartChars;
    use fable_library_rust::TimeSpan_::TimeSpan;
    type ConcurrentStack_1<T> = T;
    use fable_library_rust::System::Text::StringBuilder;
    type CancellationToken = ();
    type TaskCanceledException = ();
    pub mod State {
        use super::*;
        pub fn trace_state() -> LrcPtr<
            MutCell<
                Option<(
                    LrcPtr<Runtime::Mut0>,
                    LrcPtr<Runtime::Mut1>,
                    LrcPtr<Runtime::Mut2>,
                    Option<i64>,
                    LrcPtr<Runtime::Mut3>,
                )>,
            >,
        > {
            static trace_state: OnceInit<
                LrcPtr<
                    MutCell<
                        Option<(
                            LrcPtr<Runtime::Mut0>,
                            LrcPtr<Runtime::Mut1>,
                            LrcPtr<Runtime::Mut2>,
                            Option<i64>,
                            LrcPtr<Runtime::Mut3>,
                        )>,
                    >,
                >,
            > = OnceInit::new();
            trace_state
                .get_or_init(|| {
                    LrcPtr::new(MutCell::new(
                        None::<(
                            LrcPtr<Runtime::Mut0>,
                            LrcPtr<Runtime::Mut1>,
                            LrcPtr<Runtime::Mut2>,
                            Option<i64>,
                            LrcPtr<Runtime::Mut3>,
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
    #[derive(Clone, Copy, Debug, PartialEq, PartialOrd, Hash, Eq)]
    pub enum US0 {
        US0_0,
        US0_1,
        US0_2,
        US0_3,
        US0_4,
    }
    impl Runtime::US0 {
        pub fn get_IsUS0_0(this_: &MutCell<Runtime::US0>, unitArg: ()) -> bool {
            if unreachable!() {
                true
            } else {
                false
            }
        }
        pub fn get_IsUS0_1(this_: &MutCell<Runtime::US0>, unitArg: ()) -> bool {
            if unreachable!() {
                true
            } else {
                false
            }
        }
        pub fn get_IsUS0_2(this_: &MutCell<Runtime::US0>, unitArg: ()) -> bool {
            if unreachable!() {
                true
            } else {
                false
            }
        }
        pub fn get_IsUS0_3(this_: &MutCell<Runtime::US0>, unitArg: ()) -> bool {
            if unreachable!() {
                true
            } else {
                false
            }
        }
        pub fn get_IsUS0_4(this_: &MutCell<Runtime::US0>, unitArg: ()) -> bool {
            if unreachable!() {
                true
            } else {
                false
            }
        }
    }
    impl core::fmt::Display for Runtime::US0 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Debug, Default, PartialEq, PartialOrd, Hash, Eq)]
    pub struct Mut0 {
        pub l0: MutCell<i64>,
    }
    impl core::fmt::Display for Runtime::Mut0 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Debug, Default, PartialEq, PartialOrd, Hash, Eq)]
    pub struct Mut1 {
        pub l0: MutCell<bool>,
    }
    impl core::fmt::Display for Runtime::Mut1 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Debug, PartialEq, PartialOrd, Hash, Eq)]
    pub struct Mut2 {
        pub l0: MutCell<Runtime::US0>,
    }
    impl core::fmt::Display for Runtime::Mut2 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Debug)]
    pub struct Mut3 {
        pub l0: MutCell<Func1<string, ()>>,
    }
    impl core::fmt::Display for Runtime::Mut3 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Copy, Debug, PartialEq, PartialOrd, Hash, Eq)]
    pub enum US1 {
        US1_0(i64),
        US1_1,
    }
    impl Runtime::US1 {
        pub fn get_IsUS1_0(this_: &MutCell<Runtime::US1>, unitArg: ()) -> bool {
            if unreachable!() {
                true
            } else {
                false
            }
        }
        pub fn get_IsUS1_1(this_: &MutCell<Runtime::US1>, unitArg: ()) -> bool {
            if unreachable!() {
                true
            } else {
                false
            }
        }
    }
    impl core::fmt::Display for Runtime::US1 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Copy, Debug, PartialEq, PartialOrd, Hash, Eq)]
    pub enum US2 {
        US2_0(Runtime::US0),
        US2_1,
    }
    impl Runtime::US2 {
        pub fn get_IsUS2_0(this_: &MutCell<Runtime::US2>, unitArg: ()) -> bool {
            if unreachable!() {
                true
            } else {
                false
            }
        }
        pub fn get_IsUS2_1(this_: &MutCell<Runtime::US2>, unitArg: ()) -> bool {
            if unreachable!() {
                true
            } else {
                false
            }
        }
    }
    impl core::fmt::Display for Runtime::US2 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Debug, PartialEq, PartialOrd, Hash, Eq)]
    pub enum US3 {
        US3_0(string),
        US3_1,
    }
    impl Runtime::US3 {
        pub fn get_IsUS3_0(this_: &MutCell<Runtime::US3>, unitArg: ()) -> bool {
            if unreachable!() {
                true
            } else {
                false
            }
        }
        pub fn get_IsUS3_1(this_: &MutCell<Runtime::US3>, unitArg: ()) -> bool {
            if unreachable!() {
                true
            } else {
                false
            }
        }
    }
    impl core::fmt::Display for Runtime::US3 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Copy, Debug, PartialEq, PartialOrd, Hash, Eq)]
    pub enum US4 {
        US4_0,
        US4_1,
        US4_2,
    }
    impl Runtime::US4 {
        pub fn get_IsUS4_0(this_: &MutCell<Runtime::US4>, unitArg: ()) -> bool {
            if unreachable!() {
                true
            } else {
                false
            }
        }
        pub fn get_IsUS4_1(this_: &MutCell<Runtime::US4>, unitArg: ()) -> bool {
            if unreachable!() {
                true
            } else {
                false
            }
        }
        pub fn get_IsUS4_2(this_: &MutCell<Runtime::US4>, unitArg: ()) -> bool {
            if unreachable!() {
                true
            } else {
                false
            }
        }
    }
    impl core::fmt::Display for Runtime::US4 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Copy, Debug, PartialEq, PartialOrd, Hash, Eq)]
    pub enum US5 {
        US5_0(Runtime::US4),
        US5_1(Runtime::US4),
        US5_2(Runtime::US4),
        US5_3(Runtime::US4),
    }
    impl Runtime::US5 {
        pub fn get_IsUS5_0(this_: &MutCell<Runtime::US5>, unitArg: ()) -> bool {
            if unreachable!() {
                true
            } else {
                false
            }
        }
        pub fn get_IsUS5_1(this_: &MutCell<Runtime::US5>, unitArg: ()) -> bool {
            if unreachable!() {
                true
            } else {
                false
            }
        }
        pub fn get_IsUS5_2(this_: &MutCell<Runtime::US5>, unitArg: ()) -> bool {
            if unreachable!() {
                true
            } else {
                false
            }
        }
        pub fn get_IsUS5_3(this_: &MutCell<Runtime::US5>, unitArg: ()) -> bool {
            if unreachable!() {
                true
            } else {
                false
            }
        }
    }
    impl core::fmt::Display for Runtime::US5 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Debug, Default, PartialEq, PartialOrd, Hash, Eq)]
    pub struct Mut4 {
        pub l0: MutCell<i32>,
    }
    impl core::fmt::Display for Runtime::Mut4 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Debug, PartialEq, PartialOrd, Hash, Eq)]
    pub enum UH0 {
        UH0_0,
        UH0_1(char, LrcPtr<Runtime::UH0>),
    }
    impl Runtime::UH0 {
        pub fn get_IsUH0_0(this_: LrcPtr<Runtime::UH0>, unitArg: ()) -> bool {
            if let Runtime::UH0::UH0_0 = this_.as_ref() {
                true
            } else {
                false
            }
        }
        pub fn get_IsUH0_1(this_: LrcPtr<Runtime::UH0>, unitArg: ()) -> bool {
            if let Runtime::UH0::UH0_1(this__1_0, this__1_1) = this_.as_ref() {
                true
            } else {
                false
            }
        }
    }
    impl core::fmt::Display for Runtime::UH0 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Copy, Debug, PartialEq, PartialOrd, Hash, Eq)]
    pub enum US7 {
        US7_0,
        US7_1,
    }
    impl Runtime::US7 {
        pub fn get_IsUS7_0(this_: &MutCell<Runtime::US7>, unitArg: ()) -> bool {
            if unreachable!() {
                true
            } else {
                false
            }
        }
        pub fn get_IsUS7_1(this_: &MutCell<Runtime::US7>, unitArg: ()) -> bool {
            if unreachable!() {
                true
            } else {
                false
            }
        }
    }
    impl core::fmt::Display for Runtime::US7 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Copy, Debug, PartialEq, PartialOrd, Hash, Eq)]
    pub enum US6 {
        US6_0,
        US6_1(Runtime::US7),
        US6_2,
    }
    impl Runtime::US6 {
        pub fn get_IsUS6_0(this_: &MutCell<Runtime::US6>, unitArg: ()) -> bool {
            if unreachable!() {
                true
            } else {
                false
            }
        }
        pub fn get_IsUS6_1(this_: &MutCell<Runtime::US6>, unitArg: ()) -> bool {
            if unreachable!() {
                true
            } else {
                false
            }
        }
        pub fn get_IsUS6_2(this_: &MutCell<Runtime::US6>, unitArg: ()) -> bool {
            if unreachable!() {
                true
            } else {
                false
            }
        }
    }
    impl core::fmt::Display for Runtime::US6 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Debug)]
    pub enum US8 {
        US8_0(Func1<(bool, string, i32), Arc<Async<()>>>),
        US8_1,
    }
    impl Runtime::US8 {
        pub fn get_IsUS8_0(this_: &MutCell<Runtime::US8>, unitArg: ()) -> bool {
            if unreachable!() {
                true
            } else {
                false
            }
        }
        pub fn get_IsUS8_1(this_: &MutCell<Runtime::US8>, unitArg: ()) -> bool {
            if unreachable!() {
                true
            } else {
                false
            }
        }
    }
    impl core::fmt::Display for Runtime::US8 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Copy, Debug, PartialEq, PartialOrd, Hash, Eq)]
    pub enum US9 {
        US9_0(CancellationToken),
        US9_1,
    }
    impl Runtime::US9 {
        pub fn get_IsUS9_0(this_: &MutCell<Runtime::US9>, unitArg: ()) -> bool {
            if unreachable!() {
                true
            } else {
                false
            }
        }
        pub fn get_IsUS9_1(this_: &MutCell<Runtime::US9>, unitArg: ()) -> bool {
            if unreachable!() {
                true
            } else {
                false
            }
        }
    }
    impl core::fmt::Display for Runtime::US9 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Debug)]
    pub struct Heap0 {
        pub l0: Option<CancellationToken>,
        pub l1: string,
        pub l2: Array<(string, string)>,
        pub l3: Option<Func1<(bool, string, i32), Arc<Async<()>>>>,
        pub l4: Option<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
        pub l5: bool,
        pub l6: Option<string>,
    }
    impl core::fmt::Display for Runtime::Heap0 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Debug, PartialEq, PartialOrd, Hash, Eq)]
    pub enum US10 {
        US10_0(Array<string>),
        US10_1(string),
    }
    impl Runtime::US10 {
        pub fn get_IsUS10_0(this_: &MutCell<Runtime::US10>, unitArg: ()) -> bool {
            if unreachable!() {
                true
            } else {
                false
            }
        }
        pub fn get_IsUS10_1(this_: &MutCell<Runtime::US10>, unitArg: ()) -> bool {
            if unreachable!() {
                true
            } else {
                false
            }
        }
    }
    impl core::fmt::Display for Runtime::US10 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Debug, PartialEq, PartialOrd, Hash, Eq)]
    pub enum UH1 {
        UH1_0,
        UH1_1(string, LrcPtr<Runtime::UH1>),
    }
    impl Runtime::UH1 {
        pub fn get_IsUH1_0(this_: LrcPtr<Runtime::UH1>, unitArg: ()) -> bool {
            if let Runtime::UH1::UH1_0 = this_.as_ref() {
                true
            } else {
                false
            }
        }
        pub fn get_IsUH1_1(this_: LrcPtr<Runtime::UH1>, unitArg: ()) -> bool {
            if let Runtime::UH1::UH1_1(this__1_0, this__1_1) = this_.as_ref() {
                true
            } else {
                false
            }
        }
    }
    impl core::fmt::Display for Runtime::UH1 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Debug)]
    pub enum US11 {
        US11_0(
            LrcPtr<Runtime::UH1>,
            string,
            LrcPtr<StringBuilder>,
            i32,
            i32,
        ),
        US11_1(string),
    }
    impl Runtime::US11 {
        pub fn get_IsUS11_0(this_: &MutCell<Runtime::US11>, unitArg: ()) -> bool {
            if unreachable!() {
                true
            } else {
                false
            }
        }
        pub fn get_IsUS11_1(this_: &MutCell<Runtime::US11>, unitArg: ()) -> bool {
            if unreachable!() {
                true
            } else {
                false
            }
        }
    }
    impl core::fmt::Display for Runtime::US11 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Debug)]
    pub enum US12 {
        US12_0(char, string, LrcPtr<StringBuilder>, i32, i32),
        US12_1(string),
    }
    impl Runtime::US12 {
        pub fn get_IsUS12_0(this_: &MutCell<Runtime::US12>, unitArg: ()) -> bool {
            if unreachable!() {
                true
            } else {
                false
            }
        }
        pub fn get_IsUS12_1(this_: &MutCell<Runtime::US12>, unitArg: ()) -> bool {
            if unreachable!() {
                true
            } else {
                false
            }
        }
    }
    impl core::fmt::Display for Runtime::US12 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Copy, Debug, PartialEq, PartialOrd, Hash, Eq)]
    pub enum US13 {
        US13_0(char),
        US13_1,
    }
    impl Runtime::US13 {
        pub fn get_IsUS13_0(this_: &MutCell<Runtime::US13>, unitArg: ()) -> bool {
            if unreachable!() {
                true
            } else {
                false
            }
        }
        pub fn get_IsUS13_1(this_: &MutCell<Runtime::US13>, unitArg: ()) -> bool {
            if unreachable!() {
                true
            } else {
                false
            }
        }
    }
    impl core::fmt::Display for Runtime::US13 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Debug)]
    pub enum US14 {
        US14_0(string, string, LrcPtr<StringBuilder>, i32, i32),
        US14_1(string),
    }
    impl Runtime::US14 {
        pub fn get_IsUS14_0(this_: &MutCell<Runtime::US14>, unitArg: ()) -> bool {
            if unreachable!() {
                true
            } else {
                false
            }
        }
        pub fn get_IsUS14_1(this_: &MutCell<Runtime::US14>, unitArg: ()) -> bool {
            if unreachable!() {
                true
            } else {
                false
            }
        }
    }
    impl core::fmt::Display for Runtime::US14 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Debug)]
    pub enum UH2 {
        UH2_0,
        UH2_1(
            Func1<(string, LrcPtr<StringBuilder>, i32, i32), Runtime::US14>,
            LrcPtr<Runtime::UH2>,
        ),
    }
    impl Runtime::UH2 {
        pub fn get_IsUH2_0(this_: LrcPtr<Runtime::UH2>, unitArg: ()) -> bool {
            if let Runtime::UH2::UH2_0 = this_.as_ref() {
                true
            } else {
                false
            }
        }
        pub fn get_IsUH2_1(this_: LrcPtr<Runtime::UH2>, unitArg: ()) -> bool {
            if let Runtime::UH2::UH2_1(this__1_0, this__1_1) = this_.as_ref() {
                true
            } else {
                false
            }
        }
    }
    impl core::fmt::Display for Runtime::UH2 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Debug)]
    pub enum US15 {
        US15_0(string, LrcPtr<StringBuilder>, i32, i32),
        US15_1(string),
    }
    impl Runtime::US15 {
        pub fn get_IsUS15_0(this_: &MutCell<Runtime::US15>, unitArg: ()) -> bool {
            if unreachable!() {
                true
            } else {
                false
            }
        }
        pub fn get_IsUS15_1(this_: &MutCell<Runtime::US15>, unitArg: ()) -> bool {
            if unreachable!() {
                true
            } else {
                false
            }
        }
    }
    impl core::fmt::Display for Runtime::US15 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Debug, PartialEq, PartialOrd, Hash, Eq)]
    pub enum US16 {
        US16_0(Array<string>),
        US16_1(string),
    }
    impl Runtime::US16 {
        pub fn get_IsUS16_0(this_: &MutCell<Runtime::US16>, unitArg: ()) -> bool {
            if unreachable!() {
                true
            } else {
                false
            }
        }
        pub fn get_IsUS16_1(this_: &MutCell<Runtime::US16>, unitArg: ()) -> bool {
            if unreachable!() {
                true
            } else {
                false
            }
        }
    }
    impl core::fmt::Display for Runtime::US16 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    pub fn method0() -> string {
        string("TRACE_LEVEL")
    }
    pub fn method2() -> string {
        string("")
    }
    pub fn method1(v0_1: string) -> string {
        let _v1: MutCell<Option<string>> = MutCell::new(None::<string>);
        let v18: Result<std::string::String, std::env::VarError> = std::env::var(&*v0_1);
        let v20: bool = true;
        let _result = v18.map(|x| {
            //;
            let v22: std::string::String = x;
            let v24: string = fable_library_rust::String_::fromString(v22);
            let v26: bool = true;
            v24
        });
        let v28: Result<string, std::env::VarError> = _result;
        let v29: string = Runtime::method2();
        {
            let x: string = v28.unwrap_or(v29);
            _v1.set(Some(x))
        }
        match &_v1.get().clone() {
            None => panic!("{}", string("base.run_target / _v1=None"),),
            Some(_v1_0_0) => _v1_0_0.clone(),
        }
    }
    pub fn method3() -> string {
        string("AUTOMATION")
    }
    pub fn closure1(unitVar: (), v0_1: string) {
        ();
    }
    pub fn closure0(
        unitVar: (),
        v0_1: Runtime::US0,
    ) -> (
        LrcPtr<Runtime::Mut0>,
        LrcPtr<Runtime::Mut1>,
        LrcPtr<Runtime::Mut2>,
        Option<i64>,
        LrcPtr<Runtime::Mut3>,
    ) {
        let _v1: MutCell<Option<(Runtime::US1, Runtime::US2)>> =
            MutCell::new(None::<(Runtime::US1, Runtime::US2)>);
        _v1.set(Some((Runtime::US1::US1_1, Runtime::US2::US2_1)));
        {
            let patternInput: (Runtime::US1, Runtime::US2) = match &_v1.get().clone() {
                None => panic!("{}", string("base.run_target / _v1=None"),),
                Some(_v1_0_0) => _v1_0_0.clone(),
            };
            let v139: Runtime::US2 = patternInput.1.clone();
            let v138: Runtime::US1 = patternInput.0.clone();
            let v147: LrcPtr<Runtime::Mut3> = LrcPtr::new(Runtime::Mut3 {
                l0: MutCell::new(Func1::new(move |v: string| Runtime::closure1((), v))),
            });
            (
                LrcPtr::new(Runtime::Mut0 {
                    l0: MutCell::new(0_i64),
                }),
                LrcPtr::new(Runtime::Mut1 {
                    l0: MutCell::new(true),
                }),
                LrcPtr::new(Runtime::Mut2 {
                    l0: MutCell::new(match &v139 {
                        Runtime::US2::US2_0(v139_0_0) => match &v139 {
                            Runtime::US2::US2_0(x) => x.clone(),
                            _ => unreachable!(),
                        },
                        _ => v0_1,
                    }),
                }),
                match &v138 {
                    Runtime::US1::US1_0(v138_0_0) => Some(match &v138 {
                        Runtime::US1::US1_0(x) => x.clone(),
                        _ => unreachable!(),
                    }),
                    _ => None::<i64>,
                },
                v147,
            )
        }
    }
    pub fn closure2(unitVar: (), unitVar_1: ()) -> bool {
        let _v0: MutCell<Option<bool>> = MutCell::new(None::<bool>);
        {
            let x: bool = cfg!(windows);
            _v0.set(Some(x))
        }
        match &_v0.get().clone() {
            None => panic!("{}", string("base.run_target / _v0=None"),),
            Some(_v0_0_0) => _v0_0_0.clone(),
        }
    }
    pub fn closure5(unitVar: (), unitVar_1: ()) -> string {
        string("runtime.current_process_kill")
    }
    pub fn closure6(unitVar: (), unitVar_1: ()) -> string {
        string("")
    }
    pub fn method5() -> string {
        string("hh:mm:ss")
    }
    pub fn method6() -> string {
        string("")
    }
    pub fn method7() -> string {
        string("HH:mm:ss")
    }
    pub fn closure7(
        v0_1: Runtime::US0,
        v1_1: Func0<string>,
        v2_1: Func0<string>,
        unitVar: (),
    ) -> string {
        if Runtime::State::trace_state().get().clone().is_none() {
            Runtime::State::trace_state().set(Some(Runtime::closure0((), Runtime::US0::US0_0)));
        }
        {
            let patternInput: (
                LrcPtr<Runtime::Mut0>,
                LrcPtr<Runtime::Mut1>,
                LrcPtr<Runtime::Mut2>,
                Option<i64>,
                LrcPtr<Runtime::Mut3>,
            ) = getValue(Runtime::State::trace_state().get().clone());
            let v8_1: Option<i64> = patternInput.3.clone();
            let _v10: MutCell<Option<string>> = MutCell::new(None::<string>);
            let _v38: LrcPtr<MutCell<Option<Runtime::US1>>> = refCell(None::<Runtime::US1>);
            {
                let x_2: Option<Runtime::US1> = match &v8_1 {
                    None => None::<Runtime::US1>,
                    Some(v8_1_0_0) => {
                        let x: i64 = v8_1_0_0.clone();
                        Some((Func0::new({
                            let x = x.clone();
                            move || Runtime::US1::US1_0(x)
                        }))())
                    }
                };
                _v38.set(x_2)
            }
            {
                let v43: Runtime::US1 = defaultValue(Runtime::US1::US1_1, _v38.get().clone());
                let v62: DateTime = match &v43 {
                    Runtime::US1::US1_0(v43_0_0) => {
                        let v50: TimeSpan = TimeSpan::new_ticks(
                            {
                                let _arg: DateTime = DateTime::now();
                                _arg.ticks()
                            } - match &v43 {
                                Runtime::US1::US1_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                        );
                        DateTime::new_ymdhms_milli(
                            1_i32,
                            1_i32,
                            1_i32,
                            v50.hours(),
                            v50.minutes(),
                            v50.seconds(),
                            v50.milliseconds(),
                        )
                    }
                    _ => DateTime::now(),
                };
                let v63: string = Runtime::method5();
                {
                    let x_3: string = v62.toString(v63);
                    _v10.set(Some(x_3))
                }
                {
                    let v147: string = match &_v10.get().clone() {
                        None => panic!("{}", string("base.run_target / _v10=None"),),
                        Some(_v10_0_0) => _v10_0_0.clone(),
                    };
                    let v160: string = padLeft(
                        toLower(match &v0_1 {
                            Runtime::US0::US0_1 => string("Debug"),
                            Runtime::US0::US0_2 => string("Info"),
                            Runtime::US0::US0_0 => string("Verbose"),
                            Runtime::US0::US0_3 => string("Warning"),
                            _ => string("Critical"),
                        }),
                        7_i32,
                        ' ',
                    );
                    let _v161: MutCell<Option<string>> = MutCell::new(None::<string>);
                    let v200: &str = match &v0_1 {
                        Runtime::US0::US0_1 => inline_colorization::color_bright_blue,
                        Runtime::US0::US0_2 => inline_colorization::color_bright_green,
                        Runtime::US0::US0_0 => inline_colorization::color_bright_black,
                        Runtime::US0::US0_3 => inline_colorization::color_yellow,
                        _ => inline_colorization::color_bright_red,
                    };
                    let v202: &str = &*v160;
                    let v204: &str = inline_colorization::color_reset;
                    let v206: string = string("format!(\"{v200}{v202}{v204}\")");
                    let v207: std::string::String = format!("{v200}{v202}{v204}");
                    {
                        let x_5: string = fable_library_rust::String_::fromString(v207);
                        _v161.set(Some(x_5))
                    }
                    trimEndChars(
                        trimStartChars(
                            sprintf!(
                                "{} {} #{} {} / {}",
                                v147,
                                match &_v161.get().clone() {
                                    None => panic!("{}", string("base.run_target / _v161=None"),),
                                    Some(_v161_0_0) => _v161_0_0.clone(),
                                },
                                (patternInput.0.clone()).l0.get().clone(),
                                v1_1(),
                                v2_1()
                            ),
                            new_empty::<char>(),
                        ),
                        new_array(&[' ', '/']),
                    )
                }
            }
        }
    }
    pub fn method8(v0_1: Runtime::US0, v1_1: Func0<string>) {
        fn v2_1(
            v: Runtime::US0,
        ) -> (
            LrcPtr<Runtime::Mut0>,
            LrcPtr<Runtime::Mut1>,
            LrcPtr<Runtime::Mut2>,
            Option<i64>,
            LrcPtr<Runtime::Mut3>,
        ) {
            Runtime::closure0((), v)
        }
        if Runtime::State::trace_state().get().clone().is_none() {
            Runtime::State::trace_state().set(Some(v2_1(Runtime::US0::US0_0)));
        }
        {
            let patternInput: (
                LrcPtr<Runtime::Mut0>,
                LrcPtr<Runtime::Mut1>,
                LrcPtr<Runtime::Mut2>,
                Option<i64>,
                LrcPtr<Runtime::Mut3>,
            ) = getValue(Runtime::State::trace_state().get().clone());
            let v4_1: LrcPtr<Runtime::Mut0> = patternInput.0.clone();
            if Runtime::State::trace_state().get().clone().is_none() {
                Runtime::State::trace_state().set(Some(v2_1(Runtime::US0::US0_0)));
            }
            {
                let patternInput_1: (
                    LrcPtr<Runtime::Mut0>,
                    LrcPtr<Runtime::Mut1>,
                    LrcPtr<Runtime::Mut2>,
                    Option<i64>,
                    LrcPtr<Runtime::Mut3>,
                ) = getValue(Runtime::State::trace_state().get().clone());
                let v15: Runtime::US0 = (patternInput_1.2.clone()).l0.get().clone();
                if if (patternInput_1.1.clone()).l0.get().clone() == false {
                    false
                } else {
                    find(
                        v0_1,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Runtime::US0::US0_0, 0_i32)),
                            LrcPtr::new((Runtime::US0::US0_1, 1_i32)),
                            LrcPtr::new((Runtime::US0::US0_2, 2_i32)),
                            LrcPtr::new((Runtime::US0::US0_3, 3_i32)),
                            LrcPtr::new((Runtime::US0::US0_4, 4_i32)),
                        ])))),
                    ) >= find(
                        v15,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Runtime::US0::US0_0, 0_i32)),
                            LrcPtr::new((Runtime::US0::US0_1, 1_i32)),
                            LrcPtr::new((Runtime::US0::US0_2, 2_i32)),
                            LrcPtr::new((Runtime::US0::US0_3, 3_i32)),
                            LrcPtr::new((Runtime::US0::US0_4, 4_i32)),
                        ])))),
                    )
                } {
                    let v23: i64 = v4_1.l0.get().clone() + 1_i64;
                    v4_1.l0.set(v23);
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
    pub fn method4(v0_1: Runtime::US0, v1_1: Func0<string>, v2_1: Func0<string>) {
        Runtime::method8(
            v0_1.clone(),
            Func0::new({
                let v0_1 = v0_1.clone();
                let v1_1 = v1_1.clone();
                let v2_1 = v2_1.clone();
                move || Runtime::closure7(v0_1.clone(), v1_1.clone(), v2_1.clone(), ())
            }),
        );
    }
    pub fn closure4(unitVar: (), unitVar_1: ()) {
        let _v0: MutCell<Option<()>> = MutCell::new(None::<()>);
        defaultOf::<()>();
        _v0.set(Some(()));
        match &_v0.get().clone() {
            None => panic!("{}", string("base.run_target / _v0=None"),),
            Some(_v0_0_0) => _v0_0_0.clone(),
        }
        ()
    }
    pub fn closure3(unitVar: (), unitVar_1: ()) {
        let _v0: MutCell<Option<()>> = MutCell::new(None::<()>);
        defaultOf::<()>();
        _v0.set(Some(()));
        match &_v0.get().clone() {
            None => panic!("{}", string("base.run_target / _v0=None"),),
            Some(_v0_0_0) => _v0_0_0.clone(),
        }
        ()
    }
    pub fn closure8(unitVar: (), unitVar_1: ()) -> string {
        let _v0: MutCell<Option<bool>> = MutCell::new(None::<bool>);
        {
            let x: bool = cfg!(windows);
            _v0.set(Some(x))
        }
        if match &_v0.get().clone() {
            None => panic!("{}", string("base.run_target / _v0=None"),),
            Some(_v0_0_0) => _v0_0_0.clone(),
        } {
            string(".exe")
        } else {
            string("")
        }
    }
    pub fn method11() -> (string, string) {
        (string(""), string(""))
    }
    pub fn method12(v0_1: i32, v1_1: LrcPtr<Runtime::Mut4>) -> bool {
        v1_1.l0.get().clone() < v0_1
    }
    pub fn closure11(v0_1: char, v1_1: LrcPtr<Runtime::UH0>) -> LrcPtr<Runtime::UH0> {
        LrcPtr::new(Runtime::UH0::UH0_1(v0_1, v1_1))
    }
    pub fn closure10(unitVar: (), v0_1: char) -> Func1<LrcPtr<Runtime::UH0>, LrcPtr<Runtime::UH0>> {
        Func1::new({
            let v0_1 = v0_1.clone();
            move |v: LrcPtr<Runtime::UH0>| Runtime::closure11(v0_1, v)
        })
    }
    pub fn method13() -> Func1<char, Func1<LrcPtr<Runtime::UH0>, LrcPtr<Runtime::UH0>>> {
        Func1::new(move |v: char| Runtime::closure10((), v))
    }
    pub fn method14(
        v0_1: string,
        v1_1: string,
        v2_1: LrcPtr<Runtime::UH0>,
        v3_1: Runtime::US6,
    ) -> (string, string) {
        let v0_1: MutCell<string> = MutCell::new(v0_1.clone());
        let v1_1: MutCell<string> = MutCell::new(v1_1.clone());
        let v2_1: MutCell<LrcPtr<Runtime::UH0>> = MutCell::new(v2_1.clone());
        let v3_1: MutCell<Runtime::US6> = MutCell::new(v3_1.clone());
        '_method14: loop {
            break '_method14 (if let Runtime::UH0::UH0_1(v2_1_1_0, v2_1_1_1) =
                v2_1.get().clone().as_ref()
            {
                let v5_1: LrcPtr<Runtime::UH0> = match v2_1.get().clone().as_ref() {
                    Runtime::UH0::UH0_1(_, x) => x.clone(),
                    _ => unreachable!(),
                };
                let v4_1: char = match v2_1.get().clone().as_ref() {
                    Runtime::UH0::UH0_1(x, _) => x.clone(),
                    _ => unreachable!(),
                };
                if '\"' == v4_1 {
                    if v1_1.get().clone() == string("") {
                        let v0_1_temp: string = v0_1.get().clone();
                        let v1_1_temp: string = v1_1.get().clone();
                        let v2_1_temp: LrcPtr<Runtime::UH0> = v5_1.clone();
                        let v3_1_temp: Runtime::US6 = Runtime::US6::US6_1(Runtime::US7::US7_0);
                        v0_1.set(v0_1_temp);
                        v1_1.set(v1_1_temp);
                        v2_1.set(v2_1_temp);
                        v3_1.set(v3_1_temp);
                        continue '_method14;
                    } else {
                        match &v3_1.get().clone() {
                            Runtime::US6::US6_1(v3_1_1_0) => {
                                if let Runtime::US7::US7_0 = v3_1_1_0 {
                                    let v0_1_temp: string = v0_1.get().clone();
                                    let v1_1_temp: string = v1_1.get().clone();
                                    let v2_1_temp: LrcPtr<Runtime::UH0> = v5_1.clone();
                                    let v3_1_temp: Runtime::US6 =
                                        Runtime::US6::US6_1(Runtime::US7::US7_1);
                                    v0_1.set(v0_1_temp);
                                    v1_1.set(v1_1_temp);
                                    v2_1.set(v2_1_temp);
                                    v3_1.set(v3_1_temp);
                                    continue '_method14;
                                } else {
                                    if ' ' == v4_1 {
                                        let v0_1_temp: string = v0_1.get().clone();
                                        let v1_1_temp: string = v1_1.get().clone();
                                        let v2_1_temp: LrcPtr<Runtime::UH0> = v5_1.clone();
                                        let v3_1_temp: Runtime::US6 = Runtime::US6::US6_2;
                                        v0_1.set(v0_1_temp);
                                        v1_1.set(v1_1_temp);
                                        v2_1.set(v2_1_temp);
                                        v3_1.set(v3_1_temp);
                                        continue '_method14;
                                    } else {
                                        let v0_1_temp: string = v0_1.get().clone();
                                        let v1_1_temp: string =
                                            sprintf!("{}{}", v1_1.get().clone(), v4_1);
                                        let v2_1_temp: LrcPtr<Runtime::UH0> = v5_1.clone();
                                        let v3_1_temp: Runtime::US6 = v3_1.get().clone();
                                        v0_1.set(v0_1_temp);
                                        v1_1.set(v1_1_temp);
                                        v2_1.set(v2_1_temp);
                                        v3_1.set(v3_1_temp);
                                        continue '_method14;
                                    }
                                }
                            }
                            Runtime::US6::US6_0 => {
                                if ' ' == v4_1 {
                                    let v0_1_temp: string = v0_1.get().clone();
                                    let v1_1_temp: string = v1_1.get().clone();
                                    let v2_1_temp: LrcPtr<Runtime::UH0> = v5_1.clone();
                                    let v3_1_temp: Runtime::US6 = Runtime::US6::US6_2;
                                    v0_1.set(v0_1_temp);
                                    v1_1.set(v1_1_temp);
                                    v2_1.set(v2_1_temp);
                                    v3_1.set(v3_1_temp);
                                    continue '_method14;
                                } else {
                                    let v0_1_temp: string = v0_1.get().clone();
                                    let v1_1_temp: string =
                                        sprintf!("{}{}", v1_1.get().clone(), v4_1);
                                    let v2_1_temp: LrcPtr<Runtime::UH0> = v5_1.clone();
                                    let v3_1_temp: Runtime::US6 = v3_1.get().clone();
                                    v0_1.set(v0_1_temp);
                                    v1_1.set(v1_1_temp);
                                    v2_1.set(v2_1_temp);
                                    v3_1.set(v3_1_temp);
                                    continue '_method14;
                                }
                            }
                            _ => {
                                let v0_1_temp: string = sprintf!("{}{}", v0_1.get().clone(), v4_1);
                                let v1_1_temp: string = v1_1.get().clone();
                                let v2_1_temp: LrcPtr<Runtime::UH0> = v5_1.clone();
                                let v3_1_temp: Runtime::US6 = Runtime::US6::US6_2;
                                v0_1.set(v0_1_temp);
                                v1_1.set(v1_1_temp);
                                v2_1.set(v2_1_temp);
                                v3_1.set(v3_1_temp);
                                continue '_method14;
                            }
                        }
                    }
                } else {
                    if '\'' == v4_1 {
                        if v1_1.get().clone() == string("") {
                            let v0_1_temp: string = v0_1.get().clone();
                            let v1_1_temp: string = v1_1.get().clone();
                            let v2_1_temp: LrcPtr<Runtime::UH0> = v5_1.clone();
                            let v3_1_temp: Runtime::US6 = Runtime::US6::US6_1(Runtime::US7::US7_0);
                            v0_1.set(v0_1_temp);
                            v1_1.set(v1_1_temp);
                            v2_1.set(v2_1_temp);
                            v3_1.set(v3_1_temp);
                            continue '_method14;
                        } else {
                            match &v3_1.get().clone() {
                                Runtime::US6::US6_1(v3_1_1_0) => {
                                    if let Runtime::US7::US7_0 = v3_1_1_0 {
                                        let v0_1_temp: string = v0_1.get().clone();
                                        let v1_1_temp: string = v1_1.get().clone();
                                        let v2_1_temp: LrcPtr<Runtime::UH0> = v5_1.clone();
                                        let v3_1_temp: Runtime::US6 =
                                            Runtime::US6::US6_1(Runtime::US7::US7_1);
                                        v0_1.set(v0_1_temp);
                                        v1_1.set(v1_1_temp);
                                        v2_1.set(v2_1_temp);
                                        v3_1.set(v3_1_temp);
                                        continue '_method14;
                                    } else {
                                        if ' ' == v4_1 {
                                            let v0_1_temp: string = v0_1.get().clone();
                                            let v1_1_temp: string = v1_1.get().clone();
                                            let v2_1_temp: LrcPtr<Runtime::UH0> = v5_1.clone();
                                            let v3_1_temp: Runtime::US6 = Runtime::US6::US6_2;
                                            v0_1.set(v0_1_temp);
                                            v1_1.set(v1_1_temp);
                                            v2_1.set(v2_1_temp);
                                            v3_1.set(v3_1_temp);
                                            continue '_method14;
                                        } else {
                                            let v0_1_temp: string = v0_1.get().clone();
                                            let v1_1_temp: string =
                                                sprintf!("{}{}", v1_1.get().clone(), v4_1);
                                            let v2_1_temp: LrcPtr<Runtime::UH0> = v5_1.clone();
                                            let v3_1_temp: Runtime::US6 = v3_1.get().clone();
                                            v0_1.set(v0_1_temp);
                                            v1_1.set(v1_1_temp);
                                            v2_1.set(v2_1_temp);
                                            v3_1.set(v3_1_temp);
                                            continue '_method14;
                                        }
                                    }
                                }
                                Runtime::US6::US6_0 => {
                                    if ' ' == v4_1 {
                                        let v0_1_temp: string = v0_1.get().clone();
                                        let v1_1_temp: string = v1_1.get().clone();
                                        let v2_1_temp: LrcPtr<Runtime::UH0> = v5_1.clone();
                                        let v3_1_temp: Runtime::US6 = Runtime::US6::US6_2;
                                        v0_1.set(v0_1_temp);
                                        v1_1.set(v1_1_temp);
                                        v2_1.set(v2_1_temp);
                                        v3_1.set(v3_1_temp);
                                        continue '_method14;
                                    } else {
                                        let v0_1_temp: string = v0_1.get().clone();
                                        let v1_1_temp: string =
                                            sprintf!("{}{}", v1_1.get().clone(), v4_1);
                                        let v2_1_temp: LrcPtr<Runtime::UH0> = v5_1.clone();
                                        let v3_1_temp: Runtime::US6 = v3_1.get().clone();
                                        v0_1.set(v0_1_temp);
                                        v1_1.set(v1_1_temp);
                                        v2_1.set(v2_1_temp);
                                        v3_1.set(v3_1_temp);
                                        continue '_method14;
                                    }
                                }
                                _ => {
                                    let v0_1_temp: string =
                                        sprintf!("{}{}", v0_1.get().clone(), v4_1);
                                    let v1_1_temp: string = v1_1.get().clone();
                                    let v2_1_temp: LrcPtr<Runtime::UH0> = v5_1.clone();
                                    let v3_1_temp: Runtime::US6 = Runtime::US6::US6_2;
                                    v0_1.set(v0_1_temp);
                                    v1_1.set(v1_1_temp);
                                    v2_1.set(v2_1_temp);
                                    v3_1.set(v3_1_temp);
                                    continue '_method14;
                                }
                            }
                        }
                    } else {
                        match &v3_1.get().clone() {
                            Runtime::US6::US6_1(v3_1_1_0) => {
                                if let Runtime::US7::US7_0 = v3_1_1_0 {
                                    if ' ' == v4_1 {
                                        let v0_1_temp: string = v0_1.get().clone();
                                        let v1_1_temp: string = sprintf!("{} ", v1_1.get().clone());
                                        let v2_1_temp: LrcPtr<Runtime::UH0> = v5_1.clone();
                                        let v3_1_temp: Runtime::US6 =
                                            Runtime::US6::US6_1(Runtime::US7::US7_0);
                                        v0_1.set(v0_1_temp);
                                        v1_1.set(v1_1_temp);
                                        v2_1.set(v2_1_temp);
                                        v3_1.set(v3_1_temp);
                                        continue '_method14;
                                    } else {
                                        let v0_1_temp: string = v0_1.get().clone();
                                        let v1_1_temp: string =
                                            sprintf!("{}{}", v1_1.get().clone(), v4_1);
                                        let v2_1_temp: LrcPtr<Runtime::UH0> = v5_1.clone();
                                        let v3_1_temp: Runtime::US6 = v3_1.get().clone();
                                        v0_1.set(v0_1_temp);
                                        v1_1.set(v1_1_temp);
                                        v2_1.set(v2_1_temp);
                                        v3_1.set(v3_1_temp);
                                        continue '_method14;
                                    }
                                } else {
                                    if ' ' == v4_1 {
                                        let v0_1_temp: string = v0_1.get().clone();
                                        let v1_1_temp: string = v1_1.get().clone();
                                        let v2_1_temp: LrcPtr<Runtime::UH0> = v5_1.clone();
                                        let v3_1_temp: Runtime::US6 = Runtime::US6::US6_2;
                                        v0_1.set(v0_1_temp);
                                        v1_1.set(v1_1_temp);
                                        v2_1.set(v2_1_temp);
                                        v3_1.set(v3_1_temp);
                                        continue '_method14;
                                    } else {
                                        let v0_1_temp: string = v0_1.get().clone();
                                        let v1_1_temp: string =
                                            sprintf!("{}{}", v1_1.get().clone(), v4_1);
                                        let v2_1_temp: LrcPtr<Runtime::UH0> = v5_1.clone();
                                        let v3_1_temp: Runtime::US6 = v3_1.get().clone();
                                        v0_1.set(v0_1_temp);
                                        v1_1.set(v1_1_temp);
                                        v2_1.set(v2_1_temp);
                                        v3_1.set(v3_1_temp);
                                        continue '_method14;
                                    }
                                }
                            }
                            Runtime::US6::US6_0 => {
                                if ' ' == v4_1 {
                                    let v0_1_temp: string = v0_1.get().clone();
                                    let v1_1_temp: string = v1_1.get().clone();
                                    let v2_1_temp: LrcPtr<Runtime::UH0> = v5_1.clone();
                                    let v3_1_temp: Runtime::US6 = Runtime::US6::US6_2;
                                    v0_1.set(v0_1_temp);
                                    v1_1.set(v1_1_temp);
                                    v2_1.set(v2_1_temp);
                                    v3_1.set(v3_1_temp);
                                    continue '_method14;
                                } else {
                                    let v0_1_temp: string = v0_1.get().clone();
                                    let v1_1_temp: string =
                                        sprintf!("{}{}", v1_1.get().clone(), v4_1);
                                    let v2_1_temp: LrcPtr<Runtime::UH0> = v5_1;
                                    let v3_1_temp: Runtime::US6 = v3_1.get().clone();
                                    v0_1.set(v0_1_temp);
                                    v1_1.set(v1_1_temp);
                                    v2_1.set(v2_1_temp);
                                    v3_1.set(v3_1_temp);
                                    continue '_method14;
                                }
                            }
                            _ => {
                                let v0_1_temp: string = sprintf!("{}{}", v0_1.get().clone(), v4_1);
                                let v1_1_temp: string = v1_1.get().clone();
                                let v2_1_temp: LrcPtr<Runtime::UH0> = v5_1.clone();
                                let v3_1_temp: Runtime::US6 = Runtime::US6::US6_2;
                                v0_1.set(v0_1_temp);
                                v1_1.set(v1_1_temp);
                                v2_1.set(v2_1_temp);
                                v3_1.set(v3_1_temp);
                                continue '_method14;
                            }
                        }
                    }
                }
            } else {
                match &v3_1.get().clone() {
                    Runtime::US6::US6_1(v3_1_1_0) => {
                        if let Runtime::US7::US7_0 = v3_1_1_0 {
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
                    Runtime::US6::US6_0 => (
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
    pub fn method10(v0_1: string) -> (string, string) {
        let patternInput: (string, string) = Runtime::method11();
        let v3_1: i32 = length(v0_1.clone());
        let v4_1: Array<char> = new_init(&'\u{0000}', v3_1);
        let v5_1: LrcPtr<Runtime::Mut4> = LrcPtr::new(Runtime::Mut4 {
            l0: MutCell::new(0_i32),
        });
        while Runtime::method12(v3_1, v5_1.clone()) {
            let v7_1: i32 = v5_1.l0.get().clone();
            let v8_1: char = getCharAt(v0_1.clone(), v7_1);
            v4_1.get_mut()[v7_1 as usize] = v8_1;
            {
                let v9: i32 = v7_1 + 1_i32;
                v5_1.l0.set(v9);
                ()
            }
        }
        {
            let v11: List<char> = ofArray(v4_1.clone());
            Runtime::method14(
                patternInput.1.clone(),
                patternInput.0.clone(),
                foldBack(
                    Func2::new(move |b0: char, b1: LrcPtr<Runtime::UH0>| {
                        (Runtime::method13())(b0)(b1)
                    }),
                    v11,
                    LrcPtr::new(Runtime::UH0::UH0_0),
                ),
                Runtime::US6::US6_0,
            )
        }
    }
    pub fn closure12(
        v0_1: Option<CancellationToken>,
        v1_1: string,
        v2_1: Array<(string, string)>,
        v3_1: Option<Func1<(bool, string, i32), Arc<Async<()>>>>,
        v4_1: Option<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
        v5_1: bool,
        v6_1: Option<string>,
        unitVar: (),
    ) -> string {
        sprintf!(
            "execute_with_options_async / options: {:?}",
            (v0_1, v1_1, v2_1, v3_1, v4_1, v5_1, v6_1)
        )
    }
    pub fn method15() -> Func0<string> {
        Func0::new(move || Runtime::closure6((), ()))
    }
    pub fn closure14(v0_1: string, unitVar: ()) -> string {
        v0_1
    }
    pub fn closure13(
        v0_1: Option<CancellationToken>,
        v1_1: string,
        v2_1: Array<(string, string)>,
        v3_1: Option<Func1<(bool, string, i32), Arc<Async<()>>>>,
        v4_1: Option<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
        v5_1: bool,
        v6_1: Option<string>,
        v7_1: (),
        v8_1: LrcPtr<ConcurrentStack_1<string>>,
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
    pub fn closure15(
        v0_1: Option<CancellationToken>,
        v1_1: string,
        v2_1: Array<(string, string)>,
        v3_1: Option<Func1<(bool, string, i32), Arc<Async<()>>>>,
        v4_1: Option<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
        v5_1: bool,
        v6_1: Option<string>,
        v7_1: (),
        v8_1: LrcPtr<ConcurrentStack_1<string>>,
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
    pub fn closure16(v0_1: (), unitVar: ()) {
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
    pub fn closure17(v0_1: LrcPtr<TaskCanceledException>, unitVar: ()) -> string {
        sprintf!(
            "execute_with_options_async / WaitForExitAsync / ex: {:?}",
            v0_1
        )
    }
    pub fn closure18(v0_1: i32, v1_1: string, unitVar: ()) -> string {
        sprintf!(
            "execute_with_options_async / exit_code: {} / output.Length: {}",
            v0_1,
            length(v1_1)
        )
    }
    pub fn method9(
        v0_1: Option<CancellationToken>,
        v1_1: string,
        v2_1: Array<(string, string)>,
        v3_1: Option<Func1<(bool, string, i32), Arc<Async<()>>>>,
        v4_1: Option<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
        v5_1: bool,
        v6_1: Option<string>,
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
    pub fn closure9(unitVar: (), v0_1: string) -> Arc<Async<(i32, string)>> {
        Runtime::method9(
            None::<CancellationToken>,
            v0_1,
            new_empty::<(string, string)>(),
            None::<Func1<(bool, string, i32), Arc<Async<()>>>>,
            None::<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
            true,
            None::<string>,
        )
    }
    pub fn closure19(
        unitVar: (),
        _arg: (
            Option<CancellationToken>,
            string,
            Array<(string, string)>,
            Option<Func1<(bool, string, i32), Arc<Async<()>>>>,
            Option<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
            bool,
            Option<string>,
        ),
    ) -> Arc<Async<(i32, string)>> {
        Runtime::method9(
            _arg.0.clone(),
            _arg.1.clone(),
            _arg.2.clone(),
            _arg.3.clone(),
            _arg.4.clone(),
            _arg.5.clone(),
            _arg.6.clone(),
        )
    }
    pub fn closure20(
        unitVar: (),
        v0_1: Func1<LrcPtr<Runtime::Heap0>, LrcPtr<Runtime::Heap0>>,
    ) -> (
        Option<CancellationToken>,
        string,
        Array<(string, string)>,
        Option<Func1<(bool, string, i32), Arc<Async<()>>>>,
        Option<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
        bool,
        Option<string>,
    ) {
        let v8_1: LrcPtr<Runtime::Heap0> = v0_1(LrcPtr::new(Runtime::Heap0 {
            l0: None::<CancellationToken>,
            l1: string(""),
            l2: new_empty::<(string, string)>(),
            l3: None::<Func1<(bool, string, i32), Arc<Async<()>>>>,
            l4: None::<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
            l5: true,
            l6: None::<string>,
        }));
        (
            v8_1.l0.clone(),
            v8_1.l1.clone(),
            v8_1.l2.clone(),
            v8_1.l3.clone(),
            v8_1.l4.clone(),
            v8_1.l5,
            v8_1.l6.clone(),
        )
    }
    pub fn method18(v0_1: char, v1_1: i64) -> bool {
        let v0_1: MutCell<char> = MutCell::new(v0_1);
        let v1_1: MutCell<i64> = MutCell::new(v1_1);
        '_method18: loop {
            break '_method18 (if v1_1.get().clone() >= 4_i64 {
                false
            } else {
                let v19: Runtime::US13 = if v1_1.get().clone() == 0_i64 {
                    Runtime::US13::US13_0('\\')
                } else {
                    let v5_1: i64 = v1_1.get().clone() - 1_i64;
                    if v5_1 == 0_i64 {
                        Runtime::US13::US13_0('`')
                    } else {
                        let v8_1: i64 = v5_1 - 1_i64;
                        if v8_1 == 0_i64 {
                            Runtime::US13::US13_0('\"')
                        } else {
                            let v11: i64 = v8_1 - 1_i64;
                            if v11 == 0_i64 {
                                Runtime::US13::US13_0(' ')
                            } else {
                                let v14: i64 = v11 - 1_i64;
                                Runtime::US13::US13_1
                            }
                        }
                    }
                };
                if v0_1.get().clone()
                    == match &v19 {
                        Runtime::US13::US13_0(v19_0_0) => match &v19 {
                            Runtime::US13::US13_0(x) => x.clone(),
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
                    continue '_method18;
                }
            });
        }
    }
    pub fn method19(
        v0_1: LrcPtr<Runtime::UH0>,
        v1_1: LrcPtr<StringBuilder>,
        v2_1: i32,
        v3_1: i32,
    ) -> (LrcPtr<StringBuilder>, i32, i32) {
        let v0_1: MutCell<LrcPtr<Runtime::UH0>> = MutCell::new(v0_1.clone());
        let v1_1: MutCell<LrcPtr<StringBuilder>> = MutCell::new(v1_1.clone());
        let v2_1: MutCell<i32> = MutCell::new(v2_1);
        let v3_1: MutCell<i32> = MutCell::new(v3_1);
        '_method19: loop {
            break '_method19 (match v0_1.get().clone().as_ref() {
                Runtime::UH0::UH0_0 => (v1_1.get().clone(), v2_1.get().clone(), v3_1.get().clone()),
                Runtime::UH0::UH0_1(v0_1_1_0, v0_1_1_1) => {
                    let v4_1: char = match v0_1.get().clone().as_ref() {
                        Runtime::UH0::UH0_1(x, _) => x.clone(),
                        _ => unreachable!(),
                    };
                    let v6_1: bool = '\n' == v4_1;
                    let patternInput: (i32, i32) = if v6_1 {
                        (1_i32, v3_1.get().clone() + 1_i32)
                    } else {
                        (v2_1.get().clone() + 1_i32, v3_1.get().clone())
                    };
                    {
                        let v0_1_temp: LrcPtr<Runtime::UH0> = match v0_1.get().clone().as_ref() {
                            Runtime::UH0::UH0_1(_, x) => x.clone(),
                            _ => unreachable!(),
                        };
                        let v1_1_temp: LrcPtr<StringBuilder> = if v6_1 {
                            let v12: LrcPtr<StringBuilder> = v1_1.get().clone().Clear();
                            v1_1.get().clone()
                        } else {
                            let v16: LrcPtr<StringBuilder> = {
                                let value: string = ofChar(v4_1);
                                v1_1.get().clone().Append_Z721C83C5(value)
                            };
                            v1_1.get().clone()
                        };
                        let v2_1_temp: i32 = patternInput.0.clone();
                        let v3_1_temp: i32 = patternInput.1.clone();
                        v0_1.set(v0_1_temp);
                        v1_1.set(v1_1_temp);
                        v2_1.set(v2_1_temp);
                        v3_1.set(v3_1_temp);
                        continue '_method19;
                    }
                }
            });
        }
    }
    pub fn method20(
        v0_1: string,
        v1_1: string,
        v2_1: LrcPtr<StringBuilder>,
        v3_1: i32,
        v4_1: i32,
    ) -> Runtime::US14 {
        let v0_1: MutCell<string> = MutCell::new(v0_1.clone());
        let v1_1: MutCell<string> = MutCell::new(v1_1.clone());
        let v2_1: MutCell<LrcPtr<StringBuilder>> = MutCell::new(v2_1.clone());
        let v3_1: MutCell<i32> = MutCell::new(v3_1);
        let v4_1: MutCell<i32> = MutCell::new(v4_1);
        '_method20: loop {
            break '_method20 ({
                let v57: Runtime::US12 = if string("") == v1_1.get().clone() {
                    Runtime::US12::US12_1(sprintf!(
                        "parsing.none_of / unexpected end of input / chars: {:?} / s: {:?}",
                        toArray(ofArray(new_array(&['\\', '`', '\"', ' ']))),
                        (v2_1.get().clone(), v3_1.get().clone(), v4_1.get().clone())
                    ))
                } else {
                    let v15: char = getCharAt(v1_1.get().clone(), 0_i32);
                    let v22: string = getSlice(
                        v1_1.get().clone(),
                        Some(1_i32),
                        Some(length(v1_1.get().clone())),
                    );
                    if Runtime::method18(v15, 0_i64) == false {
                        let v27: string = ofChar(v15);
                        let v28: i32 = length(v27.clone());
                        let v29: Array<char> = new_init(&'\u{0000}', v28);
                        let v30: LrcPtr<Runtime::Mut4> = LrcPtr::new(Runtime::Mut4 {
                            l0: MutCell::new(0_i32),
                        });
                        while Runtime::method12(v28, v30.clone()) {
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
                            let patternInput: (LrcPtr<StringBuilder>, i32, i32) = Runtime::method19(
                                foldBack(
                                    Func2::new(move |b0: char, b1: LrcPtr<Runtime::UH0>| {
                                        (Runtime::method13())(b0)(b1)
                                    }),
                                    v36,
                                    LrcPtr::new(Runtime::UH0::UH0_0),
                                ),
                                v2_1.get().clone(),
                                v3_1.get().clone(),
                                v4_1.get().clone(),
                            );
                            Runtime::US12::US12_0(
                                v15,
                                v22,
                                patternInput.0.clone(),
                                patternInput.1.clone(),
                                patternInput.2.clone(),
                            )
                        }
                    } else {
                        Runtime::US12::US12_1(sprintf!(
                            "parsing.none_of / unexpected char: \'{}\' / chars: {:?} / s: {:?}",
                            v15,
                            toArray(ofArray(new_array(&['\\', '`', '\"', ' ']))),
                            (v2_1.get().clone(), v3_1.get().clone(), v4_1.get().clone())
                        ))
                    }
                };
                match &v57 {
                    Runtime::US12::US12_0(v57_0_0, v57_0_1, v57_0_2, v57_0_3, v57_0_4) => {
                        let v0_1_temp: string = append(v0_1.get().clone(), ofChar(v57_0_0.clone()));
                        let v1_1_temp: string = v57_0_1.clone();
                        let v2_1_temp: LrcPtr<StringBuilder> = v57_0_2.clone();
                        let v3_1_temp: i32 = v57_0_3.clone();
                        let v4_1_temp: i32 = v57_0_4.clone();
                        v0_1.set(v0_1_temp);
                        v1_1.set(v1_1_temp);
                        v2_1.set(v2_1_temp);
                        v3_1.set(v3_1_temp);
                        v4_1.set(v4_1_temp);
                        continue '_method20;
                    }
                    _ => Runtime::US14::US14_0(
                        v0_1.get().clone(),
                        v1_1.get().clone(),
                        v2_1.get().clone(),
                        v3_1.get().clone(),
                        v4_1.get().clone(),
                    ),
                }
            });
        }
    }
    pub fn method22(v0_1: char, v1_1: i64) -> bool {
        let v0_1: MutCell<char> = MutCell::new(v0_1);
        let v1_1: MutCell<i64> = MutCell::new(v1_1);
        '_method22: loop {
            break '_method22 (if v1_1.get().clone() >= 3_i64 {
                false
            } else {
                let v15: Runtime::US13 = if v1_1.get().clone() == 0_i64 {
                    Runtime::US13::US13_0('\\')
                } else {
                    let v5_1: i64 = v1_1.get().clone() - 1_i64;
                    if v5_1 == 0_i64 {
                        Runtime::US13::US13_0('`')
                    } else {
                        let v8_1: i64 = v5_1 - 1_i64;
                        if v8_1 == 0_i64 {
                            Runtime::US13::US13_0('\"')
                        } else {
                            let v11: i64 = v8_1 - 1_i64;
                            Runtime::US13::US13_1
                        }
                    }
                };
                if v0_1.get().clone()
                    == match &v15 {
                        Runtime::US13::US13_0(v15_0_0) => match &v15 {
                            Runtime::US13::US13_0(x) => x.clone(),
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
                    continue '_method22;
                }
            });
        }
    }
    pub fn closure22(
        unitVar: (),
        _arg: (string, LrcPtr<StringBuilder>, i32, i32),
    ) -> Runtime::US14 {
        let v3_1: i32 = _arg.3.clone();
        let v2_1: i32 = _arg.2.clone();
        let v1_1: LrcPtr<StringBuilder> = _arg.1.clone();
        let v0_1: string = _arg.0.clone();
        let v60: Runtime::US12 = if string("") == v0_1.clone() {
            Runtime::US12::US12_1(sprintf!(
                "parsing.p_char / unexpected end of input / s: {:?}",
                (v1_1.clone(), v2_1, v3_1)
            ))
        } else {
            let v7_1: char = getCharAt(v0_1.clone(), 0_i32);
            if v7_1 == '\\' {
                let v15: string = getSlice(v0_1.clone(), Some(1_i32), Some(length(v0_1.clone())));
                let v17: string = ofChar(v7_1);
                let v18: i32 = length(v17.clone());
                let v19: Array<char> = new_init(&'\u{0000}', v18);
                let v20: LrcPtr<Runtime::Mut4> = LrcPtr::new(Runtime::Mut4 {
                    l0: MutCell::new(0_i32),
                });
                while Runtime::method12(v18, v20.clone()) {
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
                    let patternInput: (LrcPtr<StringBuilder>, i32, i32) = Runtime::method19(
                        foldBack(
                            Func2::new(move |b0: char, b1: LrcPtr<Runtime::UH0>| {
                                (Runtime::method13())(b0)(b1)
                            }),
                            v26,
                            LrcPtr::new(Runtime::UH0::UH0_0),
                        ),
                        v1_1.clone(),
                        v2_1,
                        v3_1,
                    );
                    Runtime::US12::US12_0(
                        v7_1,
                        v15,
                        patternInput.0.clone(),
                        patternInput.1.clone(),
                        patternInput.2.clone(),
                    )
                }
            } else {
                let v38: i32 = length(v0_1.clone());
                let v41: i32 = indexOf(v0_1.clone(), string("\n")) - 1_i32;
                Runtime::US12::US12_1(sprintf!(
                    "{}\n{}\n",
                    sprintf!(
                        "parsing.p_char / expected: \'{}\' / line: {} / col: {}\n{}{}",
                        '\\',
                        v3_1,
                        v2_1,
                        v1_1,
                        getSlice(
                            v0_1,
                            Some(0_i32),
                            Some(if -2_i32 == v41 { v38 } else { v41 })
                        )
                    ),
                    append(replicate(v2_1 - 1_i32, string(" ")), string("^"))
                ))
            }
        };
        let v102: Runtime::US12 = match &v60 {
            Runtime::US12::US12_0(v60_0_0, v60_0_1, v60_0_2, v60_0_3, v60_0_4) => {
                let v65: i32 = v60_0_4.clone();
                let v64: i32 = v60_0_3.clone();
                let v63: LrcPtr<StringBuilder> = v60_0_2.clone();
                let v62: string = v60_0_1.clone();
                if string("") == v62.clone() {
                    Runtime::US12::US12_1(sprintf!(
                        "parsing.any_char / unexpected end of input / s: {:?}",
                        (v63.clone(), v64, v65)
                    ))
                } else {
                    let v69: char = getCharAt(v62.clone(), 0_i32);
                    let v76: string = getSlice(v62.clone(), Some(1_i32), Some(length(v62)));
                    let v78: string = ofChar(v69);
                    let v79: i32 = length(v78.clone());
                    let v80: Array<char> = new_init(&'\u{0000}', v79);
                    let v81: LrcPtr<Runtime::Mut4> = LrcPtr::new(Runtime::Mut4 {
                        l0: MutCell::new(0_i32),
                    });
                    while Runtime::method12(v79, v81.clone()) {
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
                        let patternInput_1: (LrcPtr<StringBuilder>, i32, i32) = Runtime::method19(
                            foldBack(
                                Func2::new(move |b0: char, b1: LrcPtr<Runtime::UH0>| {
                                    (Runtime::method13())(b0)(b1)
                                }),
                                v87,
                                LrcPtr::new(Runtime::UH0::UH0_0),
                            ),
                            v63,
                            v64,
                            v65,
                        );
                        Runtime::US12::US12_0(
                            v69,
                            v76,
                            patternInput_1.0.clone(),
                            patternInput_1.1.clone(),
                            patternInput_1.2.clone(),
                        )
                    }
                }
            }
            Runtime::US12::US12_1(v60_1_0) => Runtime::US12::US12_1(v60_1_0.clone()),
        };
        match &v102 {
            Runtime::US12::US12_0(v102_0_0, v102_0_1, v102_0_2, v102_0_3, v102_0_4) => {
                Runtime::US14::US14_0(
                    sprintf!("{}{}", '\\', v102_0_0.clone()),
                    v102_0_1.clone(),
                    v102_0_2.clone(),
                    v102_0_3.clone(),
                    v102_0_4.clone(),
                )
            }
            Runtime::US12::US12_1(v102_1_0) => Runtime::US14::US14_1(v102_1_0.clone()),
        }
    }
    pub fn closure23(
        unitVar: (),
        _arg: (string, LrcPtr<StringBuilder>, i32, i32),
    ) -> Runtime::US14 {
        let v3_1: i32 = _arg.3.clone();
        let v2_1: i32 = _arg.2.clone();
        let v1_1: LrcPtr<StringBuilder> = _arg.1.clone();
        let v0_1: string = _arg.0.clone();
        let v60: Runtime::US12 = if string("") == v0_1.clone() {
            Runtime::US12::US12_1(sprintf!(
                "parsing.p_char / unexpected end of input / s: {:?}",
                (v1_1.clone(), v2_1, v3_1)
            ))
        } else {
            let v7_1: char = getCharAt(v0_1.clone(), 0_i32);
            if v7_1 == '`' {
                let v15: string = getSlice(v0_1.clone(), Some(1_i32), Some(length(v0_1.clone())));
                let v17: string = ofChar(v7_1);
                let v18: i32 = length(v17.clone());
                let v19: Array<char> = new_init(&'\u{0000}', v18);
                let v20: LrcPtr<Runtime::Mut4> = LrcPtr::new(Runtime::Mut4 {
                    l0: MutCell::new(0_i32),
                });
                while Runtime::method12(v18, v20.clone()) {
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
                    let patternInput: (LrcPtr<StringBuilder>, i32, i32) = Runtime::method19(
                        foldBack(
                            Func2::new(move |b0: char, b1: LrcPtr<Runtime::UH0>| {
                                (Runtime::method13())(b0)(b1)
                            }),
                            v26,
                            LrcPtr::new(Runtime::UH0::UH0_0),
                        ),
                        v1_1.clone(),
                        v2_1,
                        v3_1,
                    );
                    Runtime::US12::US12_0(
                        v7_1,
                        v15,
                        patternInput.0.clone(),
                        patternInput.1.clone(),
                        patternInput.2.clone(),
                    )
                }
            } else {
                let v38: i32 = length(v0_1.clone());
                let v41: i32 = indexOf(v0_1.clone(), string("\n")) - 1_i32;
                Runtime::US12::US12_1(sprintf!(
                    "{}\n{}\n",
                    sprintf!(
                        "parsing.p_char / expected: \'{}\' / line: {} / col: {}\n{}{}",
                        '`',
                        v3_1,
                        v2_1,
                        v1_1,
                        getSlice(
                            v0_1,
                            Some(0_i32),
                            Some(if -2_i32 == v41 { v38 } else { v41 })
                        )
                    ),
                    append(replicate(v2_1 - 1_i32, string(" ")), string("^"))
                ))
            }
        };
        let v102: Runtime::US12 = match &v60 {
            Runtime::US12::US12_0(v60_0_0, v60_0_1, v60_0_2, v60_0_3, v60_0_4) => {
                let v65: i32 = v60_0_4.clone();
                let v64: i32 = v60_0_3.clone();
                let v63: LrcPtr<StringBuilder> = v60_0_2.clone();
                let v62: string = v60_0_1.clone();
                if string("") == v62.clone() {
                    Runtime::US12::US12_1(sprintf!(
                        "parsing.any_char / unexpected end of input / s: {:?}",
                        (v63.clone(), v64, v65)
                    ))
                } else {
                    let v69: char = getCharAt(v62.clone(), 0_i32);
                    let v76: string = getSlice(v62.clone(), Some(1_i32), Some(length(v62)));
                    let v78: string = ofChar(v69);
                    let v79: i32 = length(v78.clone());
                    let v80: Array<char> = new_init(&'\u{0000}', v79);
                    let v81: LrcPtr<Runtime::Mut4> = LrcPtr::new(Runtime::Mut4 {
                        l0: MutCell::new(0_i32),
                    });
                    while Runtime::method12(v79, v81.clone()) {
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
                        let patternInput_1: (LrcPtr<StringBuilder>, i32, i32) = Runtime::method19(
                            foldBack(
                                Func2::new(move |b0: char, b1: LrcPtr<Runtime::UH0>| {
                                    (Runtime::method13())(b0)(b1)
                                }),
                                v87,
                                LrcPtr::new(Runtime::UH0::UH0_0),
                            ),
                            v63,
                            v64,
                            v65,
                        );
                        Runtime::US12::US12_0(
                            v69,
                            v76,
                            patternInput_1.0.clone(),
                            patternInput_1.1.clone(),
                            patternInput_1.2.clone(),
                        )
                    }
                }
            }
            Runtime::US12::US12_1(v60_1_0) => Runtime::US12::US12_1(v60_1_0.clone()),
        };
        match &v102 {
            Runtime::US12::US12_0(v102_0_0, v102_0_1, v102_0_2, v102_0_3, v102_0_4) => {
                Runtime::US14::US14_0(
                    sprintf!("{}{}", '`', v102_0_0.clone()),
                    v102_0_1.clone(),
                    v102_0_2.clone(),
                    v102_0_3.clone(),
                    v102_0_4.clone(),
                )
            }
            Runtime::US12::US12_1(v102_1_0) => Runtime::US14::US14_1(v102_1_0.clone()),
        }
    }
    pub fn method23(
        v0_1: string,
        v1_1: LrcPtr<StringBuilder>,
        v2_1: i32,
        v3_1: i32,
        v4_1: LrcPtr<Runtime::UH2>,
    ) -> Runtime::US14 {
        let v0_1: MutCell<string> = MutCell::new(v0_1.clone());
        let v1_1: MutCell<LrcPtr<StringBuilder>> = MutCell::new(v1_1.clone());
        let v2_1: MutCell<i32> = MutCell::new(v2_1);
        let v3_1: MutCell<i32> = MutCell::new(v3_1);
        let v4_1: MutCell<LrcPtr<Runtime::UH2>> = MutCell::new(v4_1.clone());
        '_method23: loop {
            break '_method23 (match v4_1.get().clone().as_ref() {
                Runtime::UH2::UH2_0 => {
                    Runtime::US14::US14_1(string("choice / no parsers succeeded"))
                }
                Runtime::UH2::UH2_1(v4_1_1_0, v4_1_1_1) => {
                    let v9: Runtime::US14 = (match v4_1.get().clone().as_ref() {
                        Runtime::UH2::UH2_1(x, _) => x.clone(),
                        _ => unreachable!(),
                    })((
                        v0_1.get().clone(),
                        v1_1.get().clone(),
                        v2_1.get().clone(),
                        v3_1.get().clone(),
                    ));
                    match &v9 {
                        Runtime::US14::US14_0(v9_0_0, v9_0_1, v9_0_2, v9_0_3, v9_0_4) => v9.clone(),
                        _ => {
                            let v0_1_temp: string = v0_1.get().clone();
                            let v1_1_temp: LrcPtr<StringBuilder> = v1_1.get().clone();
                            let v2_1_temp: i32 = v2_1.get().clone();
                            let v3_1_temp: i32 = v3_1.get().clone();
                            let v4_1_temp: LrcPtr<Runtime::UH2> = match v4_1.get().clone().as_ref()
                            {
                                Runtime::UH2::UH2_1(_, x) => x.clone(),
                                _ => unreachable!(),
                            };
                            v0_1.set(v0_1_temp);
                            v1_1.set(v1_1_temp);
                            v2_1.set(v2_1_temp);
                            v3_1.set(v3_1_temp);
                            v4_1.set(v4_1_temp);
                            continue '_method23;
                        }
                    }
                }
            });
        }
    }
    pub fn method24(
        v0_1: LrcPtr<Runtime::UH1>,
        v1_1: LrcPtr<Runtime::UH1>,
    ) -> LrcPtr<Runtime::UH1> {
        let v0_1: MutCell<LrcPtr<Runtime::UH1>> = MutCell::new(v0_1.clone());
        let v1_1: MutCell<LrcPtr<Runtime::UH1>> = MutCell::new(v1_1.clone());
        '_method24: loop {
            break '_method24 (match v0_1.get().clone().as_ref() {
                Runtime::UH1::UH1_0 => v1_1.get().clone(),
                Runtime::UH1::UH1_1(v0_1_1_0, v0_1_1_1) => {
                    let v0_1_temp: LrcPtr<Runtime::UH1> = match v0_1.get().clone().as_ref() {
                        Runtime::UH1::UH1_1(_, x) => x.clone(),
                        _ => unreachable!(),
                    };
                    let v1_1_temp: LrcPtr<Runtime::UH1> = LrcPtr::new(Runtime::UH1::UH1_1(
                        match v0_1.get().clone().as_ref() {
                            Runtime::UH1::UH1_1(x, _) => x.clone(),
                            _ => unreachable!(),
                        },
                        v1_1.get().clone(),
                    ));
                    v0_1.set(v0_1_temp);
                    v1_1.set(v1_1_temp);
                    continue '_method24;
                }
            });
        }
    }
    pub fn method21(
        v0_1: LrcPtr<Runtime::UH1>,
        v1_1: string,
        v2_1: LrcPtr<StringBuilder>,
        v3_1: i32,
        v4_1: i32,
    ) -> Runtime::US11 {
        let v0_1: MutCell<LrcPtr<Runtime::UH1>> = MutCell::new(v0_1.clone());
        let v1_1: MutCell<string> = MutCell::new(v1_1.clone());
        let v2_1: MutCell<LrcPtr<StringBuilder>> = MutCell::new(v2_1.clone());
        let v3_1: MutCell<i32> = MutCell::new(v3_1);
        let v4_1: MutCell<i32> = MutCell::new(v4_1);
        '_method21: loop {
            break '_method21 ({
                let v55: Runtime::US12 = if string("") == v1_1.get().clone() {
                    Runtime::US12::US12_1(sprintf!(
                        "parsing.none_of / unexpected end of input / chars: {:?} / s: {:?}",
                        toArray(ofArray(new_array(&['\\', '`', '\"']))),
                        (v2_1.get().clone(), v3_1.get().clone(), v4_1.get().clone())
                    ))
                } else {
                    let v14: char = getCharAt(v1_1.get().clone(), 0_i32);
                    let v21: string = getSlice(
                        v1_1.get().clone(),
                        Some(1_i32),
                        Some(length(v1_1.get().clone())),
                    );
                    if Runtime::method22(v14, 0_i64) == false {
                        let v26: string = ofChar(v14);
                        let v27: i32 = length(v26.clone());
                        let v28: Array<char> = new_init(&'\u{0000}', v27);
                        let v29: LrcPtr<Runtime::Mut4> = LrcPtr::new(Runtime::Mut4 {
                            l0: MutCell::new(0_i32),
                        });
                        while Runtime::method12(v27, v29.clone()) {
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
                            let patternInput: (LrcPtr<StringBuilder>, i32, i32) = Runtime::method19(
                                foldBack(
                                    Func2::new(move |b0: char, b1: LrcPtr<Runtime::UH0>| {
                                        (Runtime::method13())(b0)(b1)
                                    }),
                                    v35,
                                    LrcPtr::new(Runtime::UH0::UH0_0),
                                ),
                                v2_1.get().clone(),
                                v3_1.get().clone(),
                                v4_1.get().clone(),
                            );
                            Runtime::US12::US12_0(
                                v14,
                                v21,
                                patternInput.0.clone(),
                                patternInput.1.clone(),
                                patternInput.2.clone(),
                            )
                        }
                    } else {
                        Runtime::US12::US12_1(sprintf!(
                            "parsing.none_of / unexpected char: \'{}\' / chars: {:?} / s: {:?}",
                            v14,
                            toArray(ofArray(new_array(&['\\', '`', '\"']))),
                            (v2_1.get().clone(), v3_1.get().clone(), v4_1.get().clone())
                        ))
                    }
                };
                let v67: Runtime::US14 = match &v55 {
                    Runtime::US12::US12_0(v55_0_0, v55_0_1, v55_0_2, v55_0_3, v55_0_4) => {
                        Runtime::US14::US14_0(
                            ofChar(v55_0_0.clone()),
                            v55_0_1.clone(),
                            v55_0_2.clone(),
                            v55_0_3.clone(),
                            v55_0_4.clone(),
                        )
                    }
                    Runtime::US12::US12_1(v55_1_0) => Runtime::US14::US14_1(v55_1_0.clone()),
                };
                let v81: Runtime::US14 = match &v67 {
                    Runtime::US14::US14_0(v67_0_0, v67_0_1, v67_0_2, v67_0_3, v67_0_4) => {
                        v67.clone()
                    }
                    _ => Runtime::method23(
                        v1_1.get().clone(),
                        v2_1.get().clone(),
                        v3_1.get().clone(),
                        v4_1.get().clone(),
                        LrcPtr::new(Runtime::UH2::UH2_1(
                            Func1::new(
                                move |arg10_0040: (string, LrcPtr<StringBuilder>, i32, i32)| {
                                    Runtime::closure22((), arg10_0040)
                                },
                            ),
                            LrcPtr::new(Runtime::UH2::UH2_1(
                                Func1::new(
                                    move |arg10_0040_1: (
                                        string,
                                        LrcPtr<StringBuilder>,
                                        i32,
                                        i32,
                                    )| {
                                        Runtime::closure23((), arg10_0040_1)
                                    },
                                ),
                                LrcPtr::new(Runtime::UH2::UH2_0),
                            )),
                        )),
                    ),
                };
                match &v81 {
                    Runtime::US14::US14_0(v81_0_0, v81_0_1, v81_0_2, v81_0_3, v81_0_4) => {
                        let v0_1_temp: LrcPtr<Runtime::UH1> =
                            LrcPtr::new(Runtime::UH1::UH1_1(v81_0_0.clone(), v0_1.get().clone()));
                        let v1_1_temp: string = v81_0_1.clone();
                        let v2_1_temp: LrcPtr<StringBuilder> = v81_0_2.clone();
                        let v3_1_temp: i32 = v81_0_3.clone();
                        let v4_1_temp: i32 = v81_0_4.clone();
                        v0_1.set(v0_1_temp);
                        v1_1.set(v1_1_temp);
                        v2_1.set(v2_1_temp);
                        v3_1.set(v3_1_temp);
                        v4_1.set(v4_1_temp);
                        continue '_method21;
                    }
                    _ => Runtime::US11::US11_0(
                        Runtime::method24(v0_1.get().clone(), LrcPtr::new(Runtime::UH1::UH1_0)),
                        v1_1.get().clone(),
                        v2_1.get().clone(),
                        v3_1.get().clone(),
                        v4_1.get().clone(),
                    ),
                }
            });
        }
    }
    pub fn method25(v0_1: LrcPtr<Runtime::UH1>, v1_1: List<string>) -> List<string> {
        match v0_1.as_ref() {
            Runtime::UH1::UH1_0 => v1_1.clone(),
            Runtime::UH1::UH1_1(v0_1_1_0, v0_1_1_1) => cons(
                match v0_1.as_ref() {
                    Runtime::UH1::UH1_1(x, _) => x.clone(),
                    _ => unreachable!(),
                },
                Runtime::method25(
                    match v0_1.as_ref() {
                        Runtime::UH1::UH1_1(_, x) => x.clone(),
                        _ => unreachable!(),
                    },
                    v1_1.clone(),
                ),
            ),
        }
    }
    pub fn method26(
        v0_1: LrcPtr<Runtime::UH1>,
        v1_1: string,
        v2_1: LrcPtr<StringBuilder>,
        v3_1: i32,
        v4_1: i32,
    ) -> Runtime::US11 {
        let v0_1: MutCell<LrcPtr<Runtime::UH1>> = MutCell::new(v0_1.clone());
        let v1_1: MutCell<string> = MutCell::new(v1_1.clone());
        let v2_1: MutCell<LrcPtr<StringBuilder>> = MutCell::new(v2_1.clone());
        let v3_1: MutCell<i32> = MutCell::new(v3_1);
        let v4_1: MutCell<i32> = MutCell::new(v4_1);
        '_method26: loop {
            break '_method26 ({
                let v55: Runtime::US12 = if string("") == v1_1.get().clone() {
                    Runtime::US12::US12_1(sprintf!(
                        "parsing.none_of / unexpected end of input / chars: {:?} / s: {:?}",
                        toArray(ofArray(new_array(&['\\', '`', '\"']))),
                        (v2_1.get().clone(), v3_1.get().clone(), v4_1.get().clone())
                    ))
                } else {
                    let v14: char = getCharAt(v1_1.get().clone(), 0_i32);
                    let v21: string = getSlice(
                        v1_1.get().clone(),
                        Some(1_i32),
                        Some(length(v1_1.get().clone())),
                    );
                    if Runtime::method22(v14, 0_i64) == false {
                        let v26: string = ofChar(v14);
                        let v27: i32 = length(v26.clone());
                        let v28: Array<char> = new_init(&'\u{0000}', v27);
                        let v29: LrcPtr<Runtime::Mut4> = LrcPtr::new(Runtime::Mut4 {
                            l0: MutCell::new(0_i32),
                        });
                        while Runtime::method12(v27, v29.clone()) {
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
                            let patternInput: (LrcPtr<StringBuilder>, i32, i32) = Runtime::method19(
                                foldBack(
                                    Func2::new(move |b0: char, b1: LrcPtr<Runtime::UH0>| {
                                        (Runtime::method13())(b0)(b1)
                                    }),
                                    v35,
                                    LrcPtr::new(Runtime::UH0::UH0_0),
                                ),
                                v2_1.get().clone(),
                                v3_1.get().clone(),
                                v4_1.get().clone(),
                            );
                            Runtime::US12::US12_0(
                                v14,
                                v21,
                                patternInput.0.clone(),
                                patternInput.1.clone(),
                                patternInput.2.clone(),
                            )
                        }
                    } else {
                        Runtime::US12::US12_1(sprintf!(
                            "parsing.none_of / unexpected char: \'{}\' / chars: {:?} / s: {:?}",
                            v14,
                            toArray(ofArray(new_array(&['\\', '`', '\"']))),
                            (v2_1.get().clone(), v3_1.get().clone(), v4_1.get().clone())
                        ))
                    }
                };
                let v67: Runtime::US14 = match &v55 {
                    Runtime::US12::US12_0(v55_0_0, v55_0_1, v55_0_2, v55_0_3, v55_0_4) => {
                        Runtime::US14::US14_0(
                            ofChar(v55_0_0.clone()),
                            v55_0_1.clone(),
                            v55_0_2.clone(),
                            v55_0_3.clone(),
                            v55_0_4.clone(),
                        )
                    }
                    Runtime::US12::US12_1(v55_1_0) => Runtime::US14::US14_1(v55_1_0.clone()),
                };
                match &v67 {
                    Runtime::US14::US14_0(v67_0_0, v67_0_1, v67_0_2, v67_0_3, v67_0_4) => {
                        let v0_1_temp: LrcPtr<Runtime::UH1> =
                            LrcPtr::new(Runtime::UH1::UH1_1(v67_0_0.clone(), v0_1.get().clone()));
                        let v1_1_temp: string = v67_0_1.clone();
                        let v2_1_temp: LrcPtr<StringBuilder> = v67_0_2.clone();
                        let v3_1_temp: i32 = v67_0_3.clone();
                        let v4_1_temp: i32 = v67_0_4.clone();
                        v0_1.set(v0_1_temp);
                        v1_1.set(v1_1_temp);
                        v2_1.set(v2_1_temp);
                        v3_1.set(v3_1_temp);
                        v4_1.set(v4_1_temp);
                        continue '_method26;
                    }
                    _ => Runtime::US11::US11_0(
                        Runtime::method24(v0_1.get().clone(), LrcPtr::new(Runtime::UH1::UH1_0)),
                        v1_1.get().clone(),
                        v2_1.get().clone(),
                        v3_1.get().clone(),
                        v4_1.get().clone(),
                    ),
                }
            });
        }
    }
    pub fn method27(v0_1: string, v1_1: i32) -> i32 {
        let v0_1: MutCell<string> = MutCell::new(v0_1.clone());
        let v1_1: MutCell<i32> = MutCell::new(v1_1);
        '_method27: loop {
            break '_method27 (if v1_1.get().clone() >= length(v0_1.get().clone()) {
                v1_1.get().clone()
            } else {
                if getCharAt(v0_1.get().clone(), v1_1.get().clone()) == ' ' {
                    let v0_1_temp: string = v0_1.get().clone();
                    let v1_1_temp: i32 = v1_1.get().clone() + 1_i32;
                    v0_1.set(v0_1_temp);
                    v1_1.set(v1_1_temp);
                    continue '_method27;
                } else {
                    v1_1.get().clone()
                }
            });
        }
    }
    pub fn method17(
        v0_1: LrcPtr<Runtime::UH1>,
        v1_1: string,
        v2_1: LrcPtr<StringBuilder>,
        v3_1: i32,
        v4_1: i32,
    ) -> Runtime::US11 {
        let v0_1: MutCell<LrcPtr<Runtime::UH1>> = MutCell::new(v0_1.clone());
        let v1_1: MutCell<string> = MutCell::new(v1_1.clone());
        let v2_1: MutCell<LrcPtr<StringBuilder>> = MutCell::new(v2_1.clone());
        let v3_1: MutCell<i32> = MutCell::new(v3_1);
        let v4_1: MutCell<i32> = MutCell::new(v4_1);
        '_method17: loop {
            break '_method17 ({
                let v5_1: bool = string("") == v1_1.get().clone();
                let v57: Runtime::US12 = if v5_1 {
                    Runtime::US12::US12_1(sprintf!(
                        "parsing.none_of / unexpected end of input / chars: {:?} / s: {:?}",
                        toArray(ofArray(new_array(&['\\', '`', '\"', ' ']))),
                        (v2_1.get().clone(), v3_1.get().clone(), v4_1.get().clone())
                    ))
                } else {
                    let v15: char = getCharAt(v1_1.get().clone(), 0_i32);
                    let v22: string = getSlice(
                        v1_1.get().clone(),
                        Some(1_i32),
                        Some(length(v1_1.get().clone())),
                    );
                    if Runtime::method18(v15, 0_i64) == false {
                        let v27: string = ofChar(v15);
                        let v28: i32 = length(v27.clone());
                        let v29: Array<char> = new_init(&'\u{0000}', v28);
                        let v30: LrcPtr<Runtime::Mut4> = LrcPtr::new(Runtime::Mut4 {
                            l0: MutCell::new(0_i32),
                        });
                        while Runtime::method12(v28, v30.clone()) {
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
                            let patternInput: (LrcPtr<StringBuilder>, i32, i32) = Runtime::method19(
                                foldBack(
                                    Func2::new(move |b0: char, b1: LrcPtr<Runtime::UH0>| {
                                        (Runtime::method13())(b0)(b1)
                                    }),
                                    v36,
                                    LrcPtr::new(Runtime::UH0::UH0_0),
                                ),
                                v2_1.get().clone(),
                                v3_1.get().clone(),
                                v4_1.get().clone(),
                            );
                            Runtime::US12::US12_0(
                                v15,
                                v22,
                                patternInput.0.clone(),
                                patternInput.1.clone(),
                                patternInput.2.clone(),
                            )
                        }
                    } else {
                        Runtime::US12::US12_1(sprintf!(
                            "parsing.none_of / unexpected char: \'{}\' / chars: {:?} / s: {:?}",
                            v15,
                            toArray(ofArray(new_array(&['\\', '`', '\"', ' ']))),
                            (v2_1.get().clone(), v3_1.get().clone(), v4_1.get().clone())
                        ))
                    }
                };
                let v69: Runtime::US14 = match &v57 {
                    Runtime::US12::US12_0(v57_0_0, v57_0_1, v57_0_2, v57_0_3, v57_0_4) => {
                        Runtime::method20(
                            ofChar(v57_0_0.clone()),
                            v57_0_1.clone(),
                            v57_0_2.clone(),
                            v57_0_3.clone(),
                            v57_0_4.clone(),
                        )
                    }
                    Runtime::US12::US12_1(v57_1_0) => Runtime::US14::US14_1(v57_1_0.clone()),
                };
                let v292: Runtime::US14 = match &v69 {
                    Runtime::US14::US14_0(v69_0_0, v69_0_1, v69_0_2, v69_0_3, v69_0_4) => {
                        v69.clone()
                    }
                    _ => {
                        let v131: Runtime::US12 = if v5_1 {
                            Runtime::US12::US12_1(sprintf!(
                                "parsing.p_char / unexpected end of input / s: {:?}",
                                (v2_1.get().clone(), v3_1.get().clone(), v4_1.get().clone())
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
                                let v91: LrcPtr<Runtime::Mut4> = LrcPtr::new(Runtime::Mut4 {
                                    l0: MutCell::new(0_i32),
                                });
                                while Runtime::method12(v89, v91.clone()) {
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
                                    let patternInput_1: (LrcPtr<StringBuilder>, i32, i32) =
                                        Runtime::method19(
                                            foldBack(
                                                Func2::new(
                                                    move |b0: char, b1: LrcPtr<Runtime::UH0>| {
                                                        (Runtime::method13())(b0)(b1)
                                                    },
                                                ),
                                                v97,
                                                LrcPtr::new(Runtime::UH0::UH0_0),
                                            ),
                                            v2_1.get().clone(),
                                            v3_1.get().clone(),
                                            v4_1.get().clone(),
                                        );
                                    Runtime::US12::US12_0(
                                        v78,
                                        v86,
                                        patternInput_1.0.clone(),
                                        patternInput_1.1.clone(),
                                        patternInput_1.2.clone(),
                                    )
                                }
                            } else {
                                let v109: i32 = length(v1_1.get().clone());
                                let v112: i32 = indexOf(v1_1.get().clone(), string("\n")) - 1_i32;
                                Runtime::US12::US12_1(sprintf!("{}\n{}\n",
                                                                                sprintf!("parsing.p_char / expected: \'{}\' / line: {} / col: {}\n{}{}",
                                                                                         '\"',
                                                                                         v4_1.get().clone(),
                                                                                         v3_1.get().clone(),
                                                                                         v2_1.get().clone(),
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
                                                                                append(replicate(v3_1.get().clone()
                                                                                                     -
                                                                                                     1_i32,
                                                                                                 string(" ")),
                                                                                       string("^"))))
                            }
                        };
                        let v237: Runtime::US14 = match &v131 {
                            Runtime::US12::US12_0(
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
                                let v138: Runtime::US11 = Runtime::method21(
                                    LrcPtr::new(Runtime::UH1::UH1_0),
                                    v133.clone(),
                                    v134.clone(),
                                    v135,
                                    v136,
                                );
                                let v155: Runtime::US14 = match &v138 {
                                    Runtime::US11::US11_0(
                                        v138_0_0,
                                        v138_0_1,
                                        v138_0_2,
                                        v138_0_3,
                                        v138_0_4,
                                    ) => {
                                        let v145: List<string> =
                                            Runtime::method25(v138_0_0.clone(), empty::<string>());
                                        Runtime::US14::US14_0(
                                            join(
                                                string(""),
                                                toArray_1(delay(Func0::new({
                                                    let v145 = v145.clone();
                                                    move || {
                                                        map(
                                                            Func1::new({
                                                                let v145 = v145.clone();
                                                                move |i: i32| item(i, v145.clone())
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
                                    Runtime::US11::US11_1(v138_1_0) => {
                                        Runtime::US14::US14_1(v138_1_0.clone())
                                    }
                                };
                                match &v155 {
                                    Runtime::US14::US14_0(
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
                                        let v217: Runtime::US12 = if string("") == v157.clone() {
                                            Runtime::US12::US12_1(sprintf!("parsing.p_char / unexpected end of input / s: {:?}",
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
                                                let v176: Array<char> = new_init(&'\u{0000}', v175);
                                                let v177: LrcPtr<Runtime::Mut4> =
                                                    LrcPtr::new(Runtime::Mut4 {
                                                        l0: MutCell::new(0_i32),
                                                    });
                                                while Runtime::method12(v175, v177.clone()) {
                                                    let v179: i32 = v177.l0.get().clone();
                                                    let v180: char = getCharAt(v174.clone(), v179);
                                                    v176.get_mut()[v179 as usize] = v180;
                                                    {
                                                        let v181: i32 = v179 + 1_i32;
                                                        v177.l0.set(v181);
                                                        ()
                                                    }
                                                }
                                                {
                                                    let v183: List<char> = ofArray(v176.clone());
                                                    let patternInput_2:
                                                                                 (LrcPtr<StringBuilder>,
                                                                                  i32,
                                                                                  i32) =
                                                                             Runtime::method19(foldBack(Func2::new(move
                                                                                                                       |b0:
                                                                                                                            char,
                                                                                                                        b1:
                                                                                                                            LrcPtr<Runtime::UH0>|
                                                                                                                       (Runtime::method13())(b0)(b1)),
                                                                                                        v183,
                                                                                                        LrcPtr::new(Runtime::UH0::UH0_0)),
                                                                                               v158.clone(),
                                                                                               v159,
                                                                                               v160);
                                                    Runtime::US12::US12_0(
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
                                                Runtime::US12::US12_1(sprintf!("{}\n{}\n",
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
                                                             Runtime::US12::US12_0(v217_0_0,
                                                                                   v217_0_1,
                                                                                   v217_0_2,
                                                                                   v217_0_3,
                                                                                   v217_0_4)
                                                             =>
                                                             Runtime::US14::US14_0(v155_0_0.clone(),
                                                                                   v217_0_1.clone(),
                                                                                   v217_0_2.clone(),
                                                                                   v217_0_3.clone(),
                                                                                   v217_0_4.clone()),
                                                             Runtime::US12::US12_1(v217_1_0)
                                                             =>
                                                             Runtime::US14::US14_1(sprintf!("between / expected closing delimiter / e: {:?} / input: {:?} / rest1: {:?} / rest2: {:?}",
                                                                                            v217_1_0.clone(),
                                                                                            (v1_1.get().clone(),
                                                                                             v2_1.get().clone(),
                                                                                             v3_1.get().clone(),
                                                                                             v4_1.get().clone()),
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
                                    _ => {
                                        Runtime::US14::US14_1(string("between / expected content"))
                                    }
                                }
                            }
                            Runtime::US12::US12_1(v131_1_0) => {
                                Runtime::US14::US14_1(v131_1_0.clone())
                            }
                        };
                        match &v237 {
                            Runtime::US14::US14_0(
                                v237_0_0,
                                v237_0_1,
                                v237_0_2,
                                v237_0_3,
                                v237_0_4,
                            ) => v237.clone(),
                            _ => {
                                let v249: Runtime::US14 = Runtime::method23(
                                    v1_1.get().clone(),
                                    v2_1.get().clone(),
                                    v3_1.get().clone(),
                                    v4_1.get().clone(),
                                    LrcPtr::new(Runtime::UH2::UH2_1(
                                        Func1::new(
                                            move |arg10_0040: (
                                                string,
                                                LrcPtr<StringBuilder>,
                                                i32,
                                                i32,
                                            )| {
                                                Runtime::closure22((), arg10_0040)
                                            },
                                        ),
                                        LrcPtr::new(Runtime::UH2::UH2_1(
                                            Func1::new(
                                                move |arg10_0040_1: (
                                                    string,
                                                    LrcPtr<StringBuilder>,
                                                    i32,
                                                    i32,
                                                )| {
                                                    Runtime::closure23((), arg10_0040_1)
                                                },
                                            ),
                                            LrcPtr::new(Runtime::UH2::UH2_0),
                                        )),
                                    )),
                                );
                                let v260: Runtime::US14 = match &v249 {
                                    Runtime::US14::US14_0(
                                        v249_0_0,
                                        v249_0_1,
                                        v249_0_2,
                                        v249_0_3,
                                        v249_0_4,
                                    ) => Runtime::US14::US14_0(
                                        string(""),
                                        v249_0_1.clone(),
                                        v249_0_2.clone(),
                                        v249_0_3.clone(),
                                        v249_0_4.clone(),
                                    ),
                                    Runtime::US14::US14_1(v249_1_0) => {
                                        Runtime::US14::US14_1(v249_1_0.clone())
                                    }
                                };
                                let v271: Runtime::US11 = match &v260 {
                                    Runtime::US14::US14_0(
                                        v260_0_0,
                                        v260_0_1,
                                        v260_0_2,
                                        v260_0_3,
                                        v260_0_4,
                                    ) => Runtime::method26(
                                        LrcPtr::new(Runtime::UH1::UH1_0),
                                        v260_0_1.clone(),
                                        v260_0_2.clone(),
                                        v260_0_3.clone(),
                                        v260_0_4.clone(),
                                    ),
                                    Runtime::US14::US14_1(v260_1_0) => {
                                        Runtime::US11::US11_1(v260_1_0.clone())
                                    }
                                };
                                match &v271 {
                                    Runtime::US11::US11_0(
                                        v271_0_0,
                                        v271_0_1,
                                        v271_0_2,
                                        v271_0_3,
                                        v271_0_4,
                                    ) => {
                                        let v278: List<string> =
                                            Runtime::method25(v271_0_0.clone(), empty::<string>());
                                        Runtime::US14::US14_0(
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
                                    Runtime::US11::US11_1(v271_1_0) => {
                                        Runtime::US14::US14_1(v271_1_0.clone())
                                    }
                                }
                            }
                        }
                    }
                };
                match &v292 {
                    Runtime::US14::US14_0(v292_0_0, v292_0_1, v292_0_2, v292_0_3, v292_0_4) => {
                        let v301: i32 = v292_0_4.clone();
                        let v300: i32 = v292_0_3.clone();
                        let v299: LrcPtr<StringBuilder> = v292_0_2.clone();
                        let v298: string = v292_0_1.clone();
                        let v297: string = v292_0_0.clone();
                        let v303: i32 = Runtime::method27(v298.clone(), 0_i32);
                        let v315: Runtime::US15 = if 0_i32 == v303 {
                            Runtime::US15::US15_1(string("spaces1 / expected at least one space"))
                        } else {
                            Runtime::US15::US15_0(
                                getSlice(v298.clone(), Some(v303), Some(length(v298.clone()))),
                                v299.clone(),
                                v300,
                                v301,
                            )
                        };
                        match &v315 {
                            Runtime::US15::US15_0(v315_0_0, v315_0_1, v315_0_2, v315_0_3) => {
                                let v0_1_temp: LrcPtr<Runtime::UH1> = LrcPtr::new(
                                    Runtime::UH1::UH1_1(v297.clone(), v0_1.get().clone()),
                                );
                                let v1_1_temp: string = v315_0_0.clone();
                                let v2_1_temp: LrcPtr<StringBuilder> = v315_0_1.clone();
                                let v3_1_temp: i32 = v315_0_2.clone();
                                let v4_1_temp: i32 = v315_0_3.clone();
                                v0_1.set(v0_1_temp);
                                v1_1.set(v1_1_temp);
                                v2_1.set(v2_1_temp);
                                v3_1.set(v3_1_temp);
                                v4_1.set(v4_1_temp);
                                continue '_method17;
                            }
                            _ => Runtime::US11::US11_0(
                                Runtime::method24(
                                    v0_1.get().clone(),
                                    LrcPtr::new(Runtime::UH1::UH1_1(
                                        v297.clone(),
                                        LrcPtr::new(Runtime::UH1::UH1_0),
                                    )),
                                ),
                                v298,
                                v299,
                                v300,
                                v301,
                            ),
                        }
                    }
                    _ => Runtime::US11::US11_0(
                        Runtime::method24(v0_1.get().clone(), LrcPtr::new(Runtime::UH1::UH1_0)),
                        v1_1.get().clone(),
                        v2_1.get().clone(),
                        v3_1.get().clone(),
                        v4_1.get().clone(),
                    ),
                }
            });
        }
    }
    pub fn method16(v0_1: string) -> Runtime::US10 {
        let _v0: MutCell<Option<Option<string>>> = MutCell::new(None::<Option<string>>);
        _v0.set(Some(Some(v0_1)));
        {
            let v11: Runtime::US11 = Runtime::method17(
                LrcPtr::new(Runtime::UH1::UH1_0),
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
            let v25: Runtime::US16 = match &v11 {
                Runtime::US11::US11_0(v11_0_0, v11_0_1, v11_0_2, v11_0_3, v11_0_4) => {
                    Runtime::US16::US16_0(toArray(Runtime::method25(
                        v11_0_0.clone(),
                        empty::<string>(),
                    )))
                }
                Runtime::US11::US11_1(v11_1_0) => Runtime::US16::US16_1(v11_1_0.clone()),
            };
            match &v25 {
                Runtime::US16::US16_0(v25_0_0) => Runtime::US10::US10_0(v25_0_0.clone()),
                Runtime::US16::US16_1(v25_1_0) => Runtime::US10::US10_1(v25_1_0.clone()),
            }
        }
    }
    pub fn closure21(unitVar: (), v0_1: string) -> Result<Array<string>, string> {
        let v1_1: Runtime::US10 = Runtime::method16(v0_1);
        match &v1_1 {
            Runtime::US10::US10_0(v1_1_0_0) => Ok::<Array<string>, string>(v1_1_0_0.clone()),
            Runtime::US10::US10_1(v1_1_1_0) => Err::<Array<string>, string>(v1_1_1_0.clone()),
        }
    }
    pub fn v0() -> Func1<
        Runtime::US0,
        (
            LrcPtr<Runtime::Mut0>,
            LrcPtr<Runtime::Mut1>,
            LrcPtr<Runtime::Mut2>,
            Option<i64>,
            LrcPtr<Runtime::Mut3>,
        ),
    > {
        static v0: OnceInit<
            Func1<
                Runtime::US0,
                (
                    LrcPtr<Runtime::Mut0>,
                    LrcPtr<Runtime::Mut1>,
                    LrcPtr<Runtime::Mut2>,
                    Option<i64>,
                    LrcPtr<Runtime::Mut3>,
                ),
            >,
        > = OnceInit::new();
        v0.get_or_init(|| Func1::new(move |v: Runtime::US0| Runtime::closure0((), v)))
            .clone()
    }
    pub fn v1() -> Runtime::US0 {
        static v1: OnceInit<Runtime::US0> = OnceInit::new();
        v1.get_or_init(|| Runtime::US0::US0_0).clone()
    }
    on_startup!(if Runtime::State::trace_state().get().clone().is_none() {
        Runtime::State::trace_state().set(Some((Runtime::v0())(Runtime::v1())));
    });
    pub fn v2() -> Func0<bool> {
        static v2: OnceInit<Func0<bool>> = OnceInit::new();
        v2.get_or_init(|| Func0::new(move || Runtime::closure2((), ())))
            .clone()
    }
    pub fn is_windows() -> bool {
        (Runtime::v2())()
    }
    pub fn v3() -> Func0<()> {
        static v3: OnceInit<Func0<()>> = OnceInit::new();
        v3.get_or_init(|| Func0::new(move || Runtime::closure3((), ())))
            .clone()
    }
    pub fn current_process_kill() {
        (Runtime::v3())();
    }
    pub fn v4() -> Func0<string> {
        static v4: OnceInit<Func0<string>> = OnceInit::new();
        v4.get_or_init(|| Func0::new(move || Runtime::closure8((), ())))
            .clone()
    }
    pub fn get_executable_suffix() -> string {
        (Runtime::v4())()
    }
    pub fn v5() -> Func1<string, Arc<Async<(i32, string)>>> {
        static v5: OnceInit<Func1<string, Arc<Async<(i32, string)>>>> = OnceInit::new();
        v5.get_or_init(|| Func1::new(move |v: string| Runtime::closure9((), v)))
            .clone()
    }
    pub fn execute_async(x: string) -> Arc<Async<(i32, string)>> {
        (Runtime::v5())(x)
    }
    pub fn v6() -> Func1<
        (
            Option<CancellationToken>,
            string,
            Array<(string, string)>,
            Option<Func1<(bool, string, i32), Arc<Async<()>>>>,
            Option<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
            bool,
            Option<string>,
        ),
        Arc<Async<(i32, string)>>,
    > {
        static v6: OnceInit<
            Func1<
                (
                    Option<CancellationToken>,
                    string,
                    Array<(string, string)>,
                    Option<Func1<(bool, string, i32), Arc<Async<()>>>>,
                    Option<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
                    bool,
                    Option<string>,
                ),
                Arc<Async<(i32, string)>>,
            >,
        > = OnceInit::new();
        v6.get_or_init(|| {
            Func1::new(
                move |arg10_0040: (
                    Option<CancellationToken>,
                    string,
                    Array<(string, string)>,
                    Option<Func1<(bool, string, i32), Arc<Async<()>>>>,
                    Option<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
                    bool,
                    Option<string>,
                )| Runtime::closure19((), arg10_0040),
            )
        })
        .clone()
    }
    pub fn execute_with_options_async(
        x: (
            Option<CancellationToken>,
            string,
            Array<(string, string)>,
            Option<Func1<(bool, string, i32), Arc<Async<()>>>>,
            Option<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
            bool,
            Option<string>,
        ),
    ) -> Arc<Async<(i32, string)>> {
        (Runtime::v6())(x)
    }
    pub fn v7() -> Func1<
        Func1<LrcPtr<Runtime::Heap0>, LrcPtr<Runtime::Heap0>>,
        (
            Option<CancellationToken>,
            string,
            Array<(string, string)>,
            Option<Func1<(bool, string, i32), Arc<Async<()>>>>,
            Option<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
            bool,
            Option<string>,
        ),
    > {
        static v7: OnceInit<
            Func1<
                Func1<LrcPtr<Runtime::Heap0>, LrcPtr<Runtime::Heap0>>,
                (
                    Option<CancellationToken>,
                    string,
                    Array<(string, string)>,
                    Option<Func1<(bool, string, i32), Arc<Async<()>>>>,
                    Option<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
                    bool,
                    Option<string>,
                ),
            >,
        > = OnceInit::new();
        v7.get_or_init(|| {
            Func1::new(
                move |v: Func1<LrcPtr<Runtime::Heap0>, LrcPtr<Runtime::Heap0>>| {
                    Runtime::closure20((), v)
                },
            )
        })
        .clone()
    }
    pub fn execution_options(
        x: Func1<LrcPtr<Runtime::Heap0>, LrcPtr<Runtime::Heap0>>,
    ) -> (
        Option<CancellationToken>,
        string,
        Array<(string, string)>,
        Option<Func1<(bool, string, i32), Arc<Async<()>>>>,
        Option<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
        bool,
        Option<string>,
    ) {
        (Runtime::v7())(x)
    }
    pub fn v8() -> Func1<string, Result<Array<string>, string>> {
        static v8: OnceInit<Func1<string, Result<Array<string>, string>>> = OnceInit::new();
        v8.get_or_init(|| Func1::new(move |v: string| Runtime::closure21((), v)))
            .clone()
    }
    pub fn split_args(x: string) -> Result<Array<string>, string> {
        (Runtime::v8())(x)
    }
    on_startup!(());
}
