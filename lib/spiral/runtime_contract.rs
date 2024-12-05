pub mod Runtime {
    use super::*;
    type Async<T> = T;
    type DateTime = ();
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
    use fable_library_rust::Option_::map;
    use fable_library_rust::Range_::rangeNumeric;
    use fable_library_rust::Seq_::delay;
    use fable_library_rust::Seq_::map as map_1;
    use fable_library_rust::Seq_::ofList;
    use fable_library_rust::Seq_::toArray as toArray_1;
    use fable_library_rust::String_::append;
    use fable_library_rust::String_::getCharAt;
    use fable_library_rust::String_::getSlice;
    use fable_library_rust::String_::indexOf;
    use fable_library_rust::String_::join;
    use fable_library_rust::String_::length;
    use fable_library_rust::String_::ofChar;
    use fable_library_rust::String_::printfn;
    use fable_library_rust::String_::replicate;
    use fable_library_rust::String_::sprintf;
    use fable_library_rust::String_::string;
    use fable_library_rust::String_::toLower;
    use fable_library_rust::String_::trimEndChars;
    use fable_library_rust::String_::trimStartChars;
    type ConcurrentStack_1<T> = T;
    use fable_library_rust::Interfaces_::System::Collections::Generic::IEnumerable_1;
    use fable_library_rust::System::Text::StringBuilder;
    type CancellationToken = ();
    type TaskCanceledException = ();
    pub mod TraceState {
        use super::*;
        pub fn trace_state() -> LrcPtr<
            MutCell<
                Option<(
                    LrcPtr<Runtime::Mut0>,
                    LrcPtr<Runtime::Mut1>,
                    LrcPtr<Runtime::Mut2>,
                    LrcPtr<Runtime::Mut3>,
                    LrcPtr<Runtime::Mut4>,
                    Option<i64>,
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
                            LrcPtr<Runtime::Mut3>,
                            LrcPtr<Runtime::Mut4>,
                            Option<i64>,
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
                            LrcPtr<Runtime::Mut3>,
                            LrcPtr<Runtime::Mut4>,
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
    #[derive(Clone, Copy, Debug, PartialEq, PartialOrd, Hash, Eq)]
    pub enum US0 {
        US0_0,
        US0_1,
        US0_2,
        US0_3,
        US0_4,
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
    #[derive(Clone, Debug)]
    pub struct Mut1 {
        pub l0: MutCell<Func1<string, ()>>,
    }
    impl core::fmt::Display for Runtime::Mut1 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Debug, Default, PartialEq, PartialOrd, Hash, Eq)]
    pub struct Mut2 {
        pub l0: MutCell<bool>,
    }
    impl core::fmt::Display for Runtime::Mut2 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Debug, Default, PartialEq, PartialOrd, Hash, Eq)]
    pub struct Mut3 {
        pub l0: MutCell<string>,
    }
    impl core::fmt::Display for Runtime::Mut3 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Debug, PartialEq, PartialOrd, Hash, Eq)]
    pub struct Mut4 {
        pub l0: MutCell<Runtime::US0>,
    }
    impl core::fmt::Display for Runtime::Mut4 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Copy, Debug, PartialEq, PartialOrd, Hash, Eq)]
    pub enum US1 {
        US1_0(Runtime::US0),
        US1_1,
    }
    impl core::fmt::Display for Runtime::US1 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Copy, Debug, PartialEq, PartialOrd, Hash, Eq)]
    pub enum US2 {
        US2_0(i64),
        US2_1,
    }
    impl core::fmt::Display for Runtime::US2 {
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
    impl core::fmt::Display for Runtime::US3 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Copy, Debug, PartialEq, PartialOrd, Hash, Eq)]
    pub enum US4 {
        US4_0(Runtime::US3),
        US4_1(Runtime::US3),
        US4_2(Runtime::US3),
        US4_3(Runtime::US3),
        US4_4(Runtime::US3),
    }
    impl core::fmt::Display for Runtime::US4 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Debug, PartialEq, PartialOrd, Hash, Eq)]
    pub enum US5 {
        US5_0(string),
        US5_1,
    }
    impl core::fmt::Display for Runtime::US5 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Debug, PartialEq, PartialOrd, Hash, Eq)]
    pub enum US6 {
        US6_0(string, Runtime::US5),
        US6_1(string),
    }
    impl core::fmt::Display for Runtime::US6 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Debug)]
    pub enum US7 {
        US7_0(char, string, LrcPtr<StringBuilder>, i32, i32),
        US7_1(string),
    }
    impl core::fmt::Display for Runtime::US7 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Debug, Default, PartialEq, PartialOrd, Hash, Eq)]
    pub struct Mut5 {
        pub l0: MutCell<i32>,
    }
    impl core::fmt::Display for Runtime::Mut5 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Debug, PartialEq, PartialOrd, Hash, Eq)]
    pub enum UH0 {
        UH0_0,
        UH0_1(char, LrcPtr<Runtime::UH0>),
    }
    impl core::fmt::Display for Runtime::UH0 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Debug)]
    pub enum UH1 {
        UH1_0,
        UH1_1(
            Func1<(string, LrcPtr<StringBuilder>, i32, i32), Runtime::US7>,
            LrcPtr<Runtime::UH1>,
        ),
    }
    impl core::fmt::Display for Runtime::UH1 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Debug)]
    pub enum US8 {
        US8_0(string, string, LrcPtr<StringBuilder>, i32, i32),
        US8_1(string),
    }
    impl core::fmt::Display for Runtime::US8 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Copy, Debug, PartialEq, PartialOrd, Hash, Eq)]
    pub enum US9 {
        US9_0(char),
        US9_1,
    }
    impl core::fmt::Display for Runtime::US9 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Debug)]
    pub enum US10 {
        US10_0(string, LrcPtr<StringBuilder>, i32, i32),
        US10_1(string),
    }
    impl core::fmt::Display for Runtime::US10 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Debug)]
    pub enum US11 {
        US11_0(
            string,
            Runtime::US5,
            string,
            LrcPtr<StringBuilder>,
            i32,
            i32,
        ),
        US11_1(string),
    }
    impl core::fmt::Display for Runtime::US11 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Debug)]
    pub enum US12 {
        US12_0(Runtime::US9, string, LrcPtr<StringBuilder>, i32, i32),
        US12_1(string),
    }
    impl core::fmt::Display for Runtime::US12 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Debug)]
    pub enum US13 {
        US13_0(Runtime::US5, string, LrcPtr<StringBuilder>, i32, i32),
        US13_1(string),
    }
    impl core::fmt::Display for Runtime::US13 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Debug)]
    pub enum US14 {
        US14_0(Func1<(i32, string, bool), Arc<Async<()>>>),
        US14_1,
    }
    impl core::fmt::Display for Runtime::US14 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Copy, Debug, PartialEq, PartialOrd, Hash, Eq)]
    pub enum US15 {
        US15_0(CancellationToken),
        US15_1,
    }
    impl core::fmt::Display for Runtime::US15 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Debug)]
    pub struct Heap0 {
        pub l0: string,
        pub l1: Option<CancellationToken>,
        pub l2: Array<(string, string)>,
        pub l3: Option<Func1<(i32, string, bool), Arc<Async<()>>>>,
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
    pub enum US16 {
        US16_0(Array<string>),
        US16_1(string),
    }
    impl core::fmt::Display for Runtime::US16 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Debug, PartialEq, PartialOrd, Hash, Eq)]
    pub enum UH2 {
        UH2_0,
        UH2_1(string, LrcPtr<Runtime::UH2>),
    }
    impl core::fmt::Display for Runtime::UH2 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Debug)]
    pub enum US17 {
        US17_0(
            LrcPtr<Runtime::UH2>,
            string,
            LrcPtr<StringBuilder>,
            i32,
            i32,
        ),
        US17_1(string),
    }
    impl core::fmt::Display for Runtime::US17 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Debug)]
    pub enum UH3 {
        UH3_0,
        UH3_1(
            Func1<(string, LrcPtr<StringBuilder>, i32, i32), Runtime::US8>,
            LrcPtr<Runtime::UH3>,
        ),
    }
    impl core::fmt::Display for Runtime::UH3 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    pub fn method3() -> string {
        string("")
    }
    pub fn closure1(unitVar: (), v0_1: string) -> Runtime::US5 {
        Runtime::US5::US5_0(v0_1)
    }
    pub fn method4() -> Func1<string, Runtime::US5> {
        Func1::new(move |v: string| Runtime::closure1((), v))
    }
    pub fn method2(v0_1: string) -> string {
        panic!(
            "{}",
            sprintf!(
                "env.get_environment_variable / target: {} / var: {}",
                Runtime::US4::US4_2(Runtime::US3::US3_2),
                v0_1
            ),
        )
    }
    pub fn method1() -> (Runtime::US1, Runtime::US2) {
        let v1_1: string = Runtime::method2(string("TRACE_LEVEL"));
        let v6: Runtime::US1 = if string("Verbose") == v1_1.clone() {
            Runtime::US1::US1_0(Runtime::US0::US0_0)
        } else {
            Runtime::US1::US1_1
        };
        (
            match &v6 {
                Runtime::US1::US1_0(v6_0_0) => Runtime::US1::US1_0(match &v6 {
                    Runtime::US1::US1_0(x) => x.clone(),
                    _ => unreachable!(),
                }),
                _ => {
                    let v13: Runtime::US1 = if string("Debug") == v1_1.clone() {
                        Runtime::US1::US1_0(Runtime::US0::US0_1)
                    } else {
                        Runtime::US1::US1_1
                    };
                    match &v13 {
                        Runtime::US1::US1_0(v13_0_0) => Runtime::US1::US1_0(match &v13 {
                            Runtime::US1::US1_0(x) => x.clone(),
                            _ => unreachable!(),
                        }),
                        _ => {
                            let v20_1: Runtime::US1 = if string("Info") == v1_1.clone() {
                                Runtime::US1::US1_0(Runtime::US0::US0_2)
                            } else {
                                Runtime::US1::US1_1
                            };
                            match &v20_1 {
                                Runtime::US1::US1_0(v20_1_0_0) => {
                                    Runtime::US1::US1_0(match &v20_1 {
                                        Runtime::US1::US1_0(x) => x.clone(),
                                        _ => unreachable!(),
                                    })
                                }
                                _ => {
                                    let v27: Runtime::US1 = if string("Warning") == v1_1.clone() {
                                        Runtime::US1::US1_0(Runtime::US0::US0_3)
                                    } else {
                                        Runtime::US1::US1_1
                                    };
                                    match &v27 {
                                        Runtime::US1::US1_0(v27_0_0) => {
                                            Runtime::US1::US1_0(match &v27 {
                                                Runtime::US1::US1_0(x) => x.clone(),
                                                _ => unreachable!(),
                                            })
                                        }
                                        _ => {
                                            let v34: Runtime::US1 =
                                                if string("Critical") == v1_1.clone() {
                                                    Runtime::US1::US1_0(Runtime::US0::US0_4)
                                                } else {
                                                    Runtime::US1::US1_1
                                                };
                                            match &v34 {
                                                Runtime::US1::US1_0(v34_0_0) => {
                                                    Runtime::US1::US1_0(match &v34 {
                                                        Runtime::US1::US1_0(x) => x.clone(),
                                                        _ => unreachable!(),
                                                    })
                                                }
                                                _ => Runtime::US1::US1_1,
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            },
            if Runtime::method2(string("AUTOMATION")) != string("True") {
                Runtime::US2::US2_1
            } else {
                let v58: DateTime = unbox::<DateTime>(&defaultOf());
                Runtime::US2::US2_0(unbox::<i64>(&defaultOf()))
            },
        )
    }
    pub fn closure2(unitVar: (), v0_1: string) {
        ();
    }
    pub fn method0(
        v0_1: Runtime::US0,
    ) -> (
        LrcPtr<Runtime::Mut0>,
        LrcPtr<Runtime::Mut1>,
        LrcPtr<Runtime::Mut2>,
        LrcPtr<Runtime::Mut3>,
        LrcPtr<Runtime::Mut4>,
        Option<i64>,
    ) {
        let v64: string = string("option_env!(\"AUTOMATION\").unwrap_or(\"\")");
        let v65: &str = option_env!("AUTOMATION").unwrap_or("");
        let v72: std::string::String = String::from(v65);
        let _v1: (Runtime::US1, Runtime::US2) = (
            Runtime::US1::US1_1,
            if fable_library_rust::String_::fromString(v72) != string("True") {
                Runtime::US2::US2_1
            } else {
                Runtime::US2::US2_0(near_sdk::env::block_timestamp() as i64)
            },
        );
        let v132: Runtime::US2 = _v1.1.clone();
        let v131: Runtime::US1 = _v1.0.clone();
        (
            LrcPtr::new(Runtime::Mut0 {
                l0: MutCell::new(1_i64),
            }),
            LrcPtr::new(Runtime::Mut1 {
                l0: MutCell::new(Func1::new(move |v: string| Runtime::closure2((), v))),
            }),
            LrcPtr::new(Runtime::Mut2 {
                l0: MutCell::new(true),
            }),
            LrcPtr::new(Runtime::Mut3 {
                l0: MutCell::new(string("")),
            }),
            LrcPtr::new(Runtime::Mut4 {
                l0: MutCell::new(match &v131 {
                    Runtime::US1::US1_0(v131_0_0) => match &v131 {
                        Runtime::US1::US1_0(x) => x.clone(),
                        _ => unreachable!(),
                    },
                    _ => v0_1,
                }),
            }),
            match &v132 {
                Runtime::US2::US2_0(v132_0_0) => Some(match &v132 {
                    Runtime::US2::US2_0(x) => x.clone(),
                    _ => unreachable!(),
                }),
                _ => None::<i64>,
            },
        )
    }
    pub fn closure0(unitVar: (), unitVar_1: ()) {
        if Runtime::TraceState::trace_state().get().clone().is_none() {
            let patternInput: (
                LrcPtr<Runtime::Mut0>,
                LrcPtr<Runtime::Mut1>,
                LrcPtr<Runtime::Mut2>,
                LrcPtr<Runtime::Mut3>,
                LrcPtr<Runtime::Mut4>,
                Option<i64>,
            ) = Runtime::method0(Runtime::US0::US0_0);
            Runtime::TraceState::trace_state().set(Some((
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
    pub fn method5(v0_1: Runtime::US0) -> bool {
        let v3: () = {
            Runtime::closure0((), ());
            ()
        };
        let patternInput: (
            LrcPtr<Runtime::Mut0>,
            LrcPtr<Runtime::Mut1>,
            LrcPtr<Runtime::Mut2>,
            LrcPtr<Runtime::Mut3>,
            LrcPtr<Runtime::Mut4>,
            Option<i64>,
        ) = getValue(Runtime::TraceState::trace_state().get().clone());
        let v35: Runtime::US0 = (patternInput.4.clone()).l0.get().clone();
        if (patternInput.2.clone()).l0.get().clone() == false {
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
                v35,
                ofSeq(ofList(ofArray(new_array(&[
                    LrcPtr::new((Runtime::US0::US0_0, 0_i32)),
                    LrcPtr::new((Runtime::US0::US0_1, 1_i32)),
                    LrcPtr::new((Runtime::US0::US0_2, 2_i32)),
                    LrcPtr::new((Runtime::US0::US0_3, 3_i32)),
                    LrcPtr::new((Runtime::US0::US0_4, 4_i32)),
                ])))),
            )
        }
    }
    pub fn closure6(unitVar: (), v0_1: i64) -> Runtime::US2 {
        Runtime::US2::US2_0(v0_1)
    }
    pub fn method7() -> Func1<i64, Runtime::US2> {
        Func1::new(move |v: i64| Runtime::closure6((), v))
    }
    pub fn method8() -> string {
        string("hh:mm:ss")
    }
    pub fn method9() -> string {
        string("HH:mm:ss")
    }
    pub fn method6(
        v0_1: LrcPtr<Runtime::Mut0>,
        v1_1: LrcPtr<Runtime::Mut1>,
        v2_1: LrcPtr<Runtime::Mut2>,
        v3: LrcPtr<Runtime::Mut3>,
        v4: LrcPtr<Runtime::Mut4>,
        v5: Option<i64>,
    ) -> string {
        let v272: u64 = near_sdk::env::block_timestamp();
        let v286: Runtime::US2 = defaultValue(Runtime::US2::US2_1, map(Runtime::method7(), v5));
        let v298: u64 = match &v286 {
            Runtime::US2::US2_0(v286_0_0) => {
                v272 - match &v286 {
                    Runtime::US2::US2_0(x) => x.clone(),
                    _ => unreachable!(),
                } as u64
            }
            _ => v272,
        } / 1000000000_u64;
        let v299: u64 = v298 % 60_u64;
        let v301: u64 = v298 / 60_u64 % 60_u64;
        let v303: u64 = v298 / 3600_u64 % 24_u64;
        let v305: std::string::String = format!("{:02}:{:02}:{:02}", v303, v301, v299);
        fable_library_rust::String_::fromString(v305)
    }
    pub fn method12() -> string {
        string("")
    }
    pub fn closure7(v0_1: LrcPtr<Runtime::Mut3>, v1_1: string, unitVar: ()) {
        let v3: string = append(v0_1.l0.get().clone(), v1_1);
        v0_1.l0.set(v3);
        ()
    }
    pub fn method11(v0_1: char) -> string {
        let v2_1: LrcPtr<Runtime::Mut3> = LrcPtr::new(Runtime::Mut3 {
            l0: MutCell::new(Runtime::method12()),
        });
        let v8: () = {
            Runtime::closure7(v2_1.clone(), sprintf!("{}", v0_1), ());
            ()
        };
        v2_1.l0.get().clone()
    }
    pub fn method13() -> string {
        string("\u{001b}[0m")
    }
    pub fn method10() -> string {
        let v6: string = Runtime::method11(getCharAt(toLower(string("Warning")), 0_i32));
        let v73: &str = inline_colorization::color_yellow;
        let v80: &str = &*v6;
        let v99: &str = inline_colorization::color_reset;
        let v101: std::string::String = format!("{}{}{}", v73, v80, v99);
        fable_library_rust::String_::fromString(v101)
    }
    pub fn method15() -> string {
        let v1_1: LrcPtr<Runtime::Mut3> = LrcPtr::new(Runtime::Mut3 {
            l0: MutCell::new(Runtime::method12()),
        });
        v1_1.l0.get().clone()
    }
    pub fn method16(v0_1: string) -> string {
        trimEndChars(
            trimStartChars(v0_1, toArray(empty::<char>())),
            toArray(ofArray(new_array(&[' ', '/']))),
        )
    }
    pub fn method14(
        v0_1: LrcPtr<Runtime::Mut0>,
        v1_1: LrcPtr<Runtime::Mut1>,
        v2_1: LrcPtr<Runtime::Mut2>,
        v3: LrcPtr<Runtime::Mut3>,
        v4: LrcPtr<Runtime::Mut4>,
        v5: Option<i64>,
        v6: string,
        v7: string,
    ) -> string {
        let v8: string = Runtime::method15();
        Runtime::method16(sprintf!(
            "{} {} #{} {} / {}",
            v6,
            v7,
            v0_1.l0.get().clone(),
            string("runtime.current_process_kill / exiting... 3"),
            v8
        ))
    }
    pub fn closure8(v0_1: LrcPtr<Runtime::Mut0>, unitVar: ()) {
        let v2_1: i64 = v0_1.l0.get().clone() + 1_i64;
        v0_1.l0.set(v2_1);
        ()
    }
    pub fn closure10(v0_1: string, unitVar: ()) {
        printfn!("{0}", v0_1);
    }
    pub fn closure9(unitVar: (), v0_1: string) {
        let v3: () = {
            Runtime::closure10(v0_1, ());
            ()
        };
        ()
    }
    pub fn method17(v0_1: string) {
        let v3: () = {
            Runtime::closure0((), ());
            ()
        };
        let patternInput: (
            LrcPtr<Runtime::Mut0>,
            LrcPtr<Runtime::Mut1>,
            LrcPtr<Runtime::Mut2>,
            LrcPtr<Runtime::Mut3>,
            LrcPtr<Runtime::Mut4>,
            Option<i64>,
        ) = getValue(Runtime::TraceState::trace_state().get().clone());
        let v20_1: LrcPtr<Runtime::Mut3> = patternInput.3.clone();
        let v37: () = {
            Runtime::closure8(patternInput.0.clone(), ());
            ()
        };
        let v53: string = if v20_1.l0.get().clone() == string("") {
            v0_1.clone()
        } else {
            if v0_1.clone() == string("") {
                v20_1.l0.get().clone()
            } else {
                append(append(v20_1.l0.get().clone(), string("\n")), v0_1.clone())
            }
        };
        let v60: &str = &*v53.clone();
        let v79 = v60.chars();
        let v81 = v79;
        let v83: Vec<char> = v81.collect::<Vec<_>>();
        let v85: Vec<Vec<char>> = v83
            .chunks(15000)
            .map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>())
            .collect::<Vec<_>>();
        let v87: bool = true;
        let _vec_map: Vec<_> = v85
            .into_iter()
            .map(|x| {
                //;
                let v89: Vec<char> = x;
                let v91: std::string::String = String::from_iter(v89);
                let v93: bool = true;
                v91
            })
            .collect::<Vec<_>>();
        let v95: Vec<std::string::String> = _vec_map;
        if if v0_1.clone() != string("") {
            v95.clone().len() as i32 <= 1_i32
        } else {
            false
        } {
            v20_1.l0.set(v53);
            ()
        } else {
            v20_1.l0.set(string(""));
            {
                let v112: bool = true;
                v95.into_iter().for_each(|x| {
                    //;
                    let v114: std::string::String = x;
                    let v116: bool = true;
                    near_sdk::log!("{}", v114);
                    let v118: bool = true;
                    let v120: bool = true;
                }); //;
                ()
            }
        }
        ();
        ((patternInput.1.clone()).l0.get().clone())(v0_1)
    }
    pub fn closure5(unitVar: (), unitVar_1: ()) {
        if Runtime::method5(Runtime::US0::US0_3) {
            let v4: () = {
                Runtime::closure0((), ());
                ()
            };
            let patternInput: (
                LrcPtr<Runtime::Mut0>,
                LrcPtr<Runtime::Mut1>,
                LrcPtr<Runtime::Mut2>,
                LrcPtr<Runtime::Mut3>,
                LrcPtr<Runtime::Mut4>,
                Option<i64>,
            ) = getValue(Runtime::TraceState::trace_state().get().clone());
            let v23: Option<i64> = patternInput.5.clone();
            let v22: LrcPtr<Runtime::Mut4> = patternInput.4.clone();
            let v21: LrcPtr<Runtime::Mut3> = patternInput.3.clone();
            let v20_1: LrcPtr<Runtime::Mut2> = patternInput.2.clone();
            let v19_1: LrcPtr<Runtime::Mut1> = patternInput.1.clone();
            let v18_1: LrcPtr<Runtime::Mut0> = patternInput.0.clone();
            Runtime::method17(Runtime::method14(
                v18_1.clone(),
                v19_1.clone(),
                v20_1.clone(),
                v21.clone(),
                v22.clone(),
                v23.clone(),
                Runtime::method6(v18_1, v19_1, v20_1, v21, v22, v23),
                Runtime::method10(),
            ))
        };
    }
    pub fn method18(
        v0_1: LrcPtr<Runtime::Mut0>,
        v1_1: LrcPtr<Runtime::Mut1>,
        v2_1: LrcPtr<Runtime::Mut2>,
        v3: LrcPtr<Runtime::Mut3>,
        v4: LrcPtr<Runtime::Mut4>,
        v5: Option<i64>,
        v6: string,
        v7: string,
    ) -> string {
        let v8: string = Runtime::method15();
        Runtime::method16(sprintf!(
            "{} {} #{} {} / {}",
            v6,
            v7,
            v0_1.l0.get().clone(),
            string("runtime.current_process_kill / exiting... 2"),
            v8
        ))
    }
    pub fn closure11(unitVar: (), unitVar_1: ()) {
        if Runtime::method5(Runtime::US0::US0_3) {
            let v4: () = {
                Runtime::closure0((), ());
                ()
            };
            let patternInput: (
                LrcPtr<Runtime::Mut0>,
                LrcPtr<Runtime::Mut1>,
                LrcPtr<Runtime::Mut2>,
                LrcPtr<Runtime::Mut3>,
                LrcPtr<Runtime::Mut4>,
                Option<i64>,
            ) = getValue(Runtime::TraceState::trace_state().get().clone());
            let v23: Option<i64> = patternInput.5.clone();
            let v22: LrcPtr<Runtime::Mut4> = patternInput.4.clone();
            let v21: LrcPtr<Runtime::Mut3> = patternInput.3.clone();
            let v20_1: LrcPtr<Runtime::Mut2> = patternInput.2.clone();
            let v19_1: LrcPtr<Runtime::Mut1> = patternInput.1.clone();
            let v18_1: LrcPtr<Runtime::Mut0> = patternInput.0.clone();
            Runtime::method17(Runtime::method18(
                v18_1.clone(),
                v19_1.clone(),
                v20_1.clone(),
                v21.clone(),
                v22.clone(),
                v23.clone(),
                Runtime::method6(v18_1, v19_1, v20_1, v21, v22, v23),
                Runtime::method10(),
            ))
        };
    }
    pub fn method19(
        v0_1: LrcPtr<Runtime::Mut0>,
        v1_1: LrcPtr<Runtime::Mut1>,
        v2_1: LrcPtr<Runtime::Mut2>,
        v3: LrcPtr<Runtime::Mut3>,
        v4: LrcPtr<Runtime::Mut4>,
        v5: Option<i64>,
        v6: string,
        v7: string,
    ) -> string {
        let v8: string = Runtime::method15();
        Runtime::method16(sprintf!(
            "{} {} #{} {} / {}",
            v6,
            v7,
            v0_1.l0.get().clone(),
            string("runtime.current_process_kill / exiting... 1"),
            v8
        ))
    }
    pub fn closure12(unitVar: (), unitVar_1: ()) {
        if Runtime::method5(Runtime::US0::US0_3) {
            let v4: () = {
                Runtime::closure0((), ());
                ()
            };
            let patternInput: (
                LrcPtr<Runtime::Mut0>,
                LrcPtr<Runtime::Mut1>,
                LrcPtr<Runtime::Mut2>,
                LrcPtr<Runtime::Mut3>,
                LrcPtr<Runtime::Mut4>,
                Option<i64>,
            ) = getValue(Runtime::TraceState::trace_state().get().clone());
            let v23: Option<i64> = patternInput.5.clone();
            let v22: LrcPtr<Runtime::Mut4> = patternInput.4.clone();
            let v21: LrcPtr<Runtime::Mut3> = patternInput.3.clone();
            let v20_1: LrcPtr<Runtime::Mut2> = patternInput.2.clone();
            let v19_1: LrcPtr<Runtime::Mut1> = patternInput.1.clone();
            let v18_1: LrcPtr<Runtime::Mut0> = patternInput.0.clone();
            Runtime::method17(Runtime::method19(
                v18_1.clone(),
                v19_1.clone(),
                v20_1.clone(),
                v21.clone(),
                v22.clone(),
                v23.clone(),
                Runtime::method6(v18_1, v19_1, v20_1, v21, v22, v23),
                Runtime::method10(),
            ))
        };
    }
    pub fn closure4(unitVar: (), unitVar_1: ()) {
        ();
        ()
    }
    pub fn closure3(unitVar: (), unitVar_1: ()) {
        ();
        ()
    }
    pub fn method22() -> string {
        string("")
    }
    pub fn method23(v0_1: i32, v1_1: LrcPtr<Runtime::Mut5>) -> bool {
        v1_1.l0.get().clone() < v0_1
    }
    pub fn closure16(v0_1: char, v1_1: LrcPtr<Runtime::UH0>) -> LrcPtr<Runtime::UH0> {
        LrcPtr::new(Runtime::UH0::UH0_1(v0_1, v1_1))
    }
    pub fn closure15(unitVar: (), v0_1: char) -> Func1<LrcPtr<Runtime::UH0>, LrcPtr<Runtime::UH0>> {
        Func1::new({
            let v0_1 = v0_1.clone();
            move |v: LrcPtr<Runtime::UH0>| Runtime::closure16(v0_1, v)
        })
    }
    pub fn method24() -> Func1<char, Func1<LrcPtr<Runtime::UH0>, LrcPtr<Runtime::UH0>>> {
        Func1::new(move |v: char| Runtime::closure15((), v))
    }
    pub fn method25(
        v0_1: LrcPtr<Runtime::UH0>,
        v1_1: LrcPtr<StringBuilder>,
        v2_1: i32,
        v3: i32,
    ) -> (LrcPtr<StringBuilder>, i32, i32) {
        let v0_1: MutCell<LrcPtr<Runtime::UH0>> = MutCell::new(v0_1.clone());
        let v1_1: MutCell<LrcPtr<StringBuilder>> = MutCell::new(v1_1.clone());
        let v2_1: MutCell<i32> = MutCell::new(v2_1);
        let v3: MutCell<i32> = MutCell::new(v3);
        '_method25: loop {
            break '_method25 (match v0_1.get().clone().as_ref() {
                Runtime::UH0::UH0_0 => (v1_1.get().clone(), v2_1.get().clone(), v3.get().clone()),
                Runtime::UH0::UH0_1(v0_1_1_0, v0_1_1_1) => {
                    let v4: char = match v0_1.get().clone().as_ref() {
                        Runtime::UH0::UH0_1(x, _) => x.clone(),
                        _ => unreachable!(),
                    };
                    let v6: bool = '\n' == v4;
                    let patternInput: (i32, i32) = if v6 {
                        (v2_1.get().clone() + 1_i32, 1_i32)
                    } else {
                        (v2_1.get().clone(), v3.get().clone() + 1_i32)
                    };
                    {
                        let v0_1_temp: LrcPtr<Runtime::UH0> = match v0_1.get().clone().as_ref() {
                            Runtime::UH0::UH0_1(_, x) => x.clone(),
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
                        let v2_1_temp: i32 = patternInput.0.clone();
                        let v3_temp: i32 = patternInput.1.clone();
                        v0_1.set(v0_1_temp);
                        v1_1.set(v1_1_temp);
                        v2_1.set(v2_1_temp);
                        v3.set(v3_temp);
                        continue '_method25;
                    }
                }
            });
        }
    }
    pub fn closure14(unitVar: (), _arg: (string, LrcPtr<StringBuilder>, i32, i32)) -> Runtime::US7 {
        let v3: i32 = _arg.3.clone();
        let v2_1: i32 = _arg.2.clone();
        let v1_1: LrcPtr<StringBuilder> = _arg.1.clone();
        let v0_1: string = _arg.0.clone();
        if string("") == v0_1.clone() {
            Runtime::US7::US7_1(sprintf!(
                "parsing.p_char / unexpected end of input / c: \'{}\' / s: {:?}",
                '\"',
                (v1_1.clone(), v2_1, v3)
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
                let v40: LrcPtr<Runtime::Mut5> = LrcPtr::new(Runtime::Mut5 {
                    l0: MutCell::new(0_i32),
                });
                while Runtime::method23(v38, v40.clone()) {
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
                    let patternInput: (LrcPtr<StringBuilder>, i32, i32) = Runtime::method25(
                        foldBack(
                            Func2::new(move |b0: char, b1: LrcPtr<Runtime::UH0>| {
                                (Runtime::method24())(b0)(b1)
                            }),
                            v45,
                            LrcPtr::new(Runtime::UH0::UH0_0),
                        ),
                        v1_1.clone(),
                        v2_1,
                        v3,
                    );
                    Runtime::US7::US7_0(
                        v9,
                        v30,
                        patternInput.0.clone(),
                        patternInput.1.clone(),
                        patternInput.2.clone(),
                    )
                }
            } else {
                let v83: i32 = indexOf(v0_1.clone(), string("\n")) - 1_i32;
                Runtime::US7::US7_1(sprintf!(
                    "{}\n{}\n",
                    sprintf!(
                        "parsing.p_char / expected: \'{}\' / line: {} / col: {}\n{}{}",
                        '\"',
                        v2_1,
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
    pub fn closure17(unitVar: (), _arg: (string, LrcPtr<StringBuilder>, i32, i32)) -> Runtime::US7 {
        let v3: i32 = _arg.3.clone();
        let v2_1: i32 = _arg.2.clone();
        let v1_1: LrcPtr<StringBuilder> = _arg.1.clone();
        let v0_1: string = _arg.0.clone();
        if string("") == v0_1.clone() {
            Runtime::US7::US7_1(sprintf!(
                "parsing.p_char / unexpected end of input / c: \'{}\' / s: {:?}",
                '\'',
                (v1_1.clone(), v2_1, v3)
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
                let v40: LrcPtr<Runtime::Mut5> = LrcPtr::new(Runtime::Mut5 {
                    l0: MutCell::new(0_i32),
                });
                while Runtime::method23(v38, v40.clone()) {
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
                    let patternInput: (LrcPtr<StringBuilder>, i32, i32) = Runtime::method25(
                        foldBack(
                            Func2::new(move |b0: char, b1: LrcPtr<Runtime::UH0>| {
                                (Runtime::method24())(b0)(b1)
                            }),
                            v45,
                            LrcPtr::new(Runtime::UH0::UH0_0),
                        ),
                        v1_1.clone(),
                        v2_1,
                        v3,
                    );
                    Runtime::US7::US7_0(
                        v9,
                        v30,
                        patternInput.0.clone(),
                        patternInput.1.clone(),
                        patternInput.2.clone(),
                    )
                }
            } else {
                let v83: i32 = indexOf(v0_1.clone(), string("\n")) - 1_i32;
                Runtime::US7::US7_1(sprintf!(
                    "{}\n{}\n",
                    sprintf!(
                        "parsing.p_char / expected: \'{}\' / line: {} / col: {}\n{}{}",
                        '\'',
                        v2_1,
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
    pub fn method26(
        v0_1: string,
        v1_1: LrcPtr<StringBuilder>,
        v2_1: LrcPtr<Runtime::UH1>,
    ) -> Runtime::US7 {
        let v0_1: MutCell<string> = MutCell::new(v0_1.clone());
        let v1_1: MutCell<LrcPtr<StringBuilder>> = MutCell::new(v1_1.clone());
        let v2_1: MutCell<LrcPtr<Runtime::UH1>> = MutCell::new(v2_1.clone());
        '_method26: loop {
            break '_method26 (match v2_1.get().clone().as_ref() {
                Runtime::UH1::UH1_0 => {
                    Runtime::US7::US7_1(string("parsing.choice / no parsers succeeded"))
                }
                Runtime::UH1::UH1_1(v2_1_1_0, v2_1_1_1) => {
                    let v7: Runtime::US7 = (match v2_1.get().clone().as_ref() {
                        Runtime::UH1::UH1_1(x, _) => x.clone(),
                        _ => unreachable!(),
                    })((
                        v0_1.get().clone(),
                        v1_1.get().clone(),
                        1_i32,
                        1_i32,
                    ));
                    match &v7 {
                        Runtime::US7::US7_0(v7_0_0, v7_0_1, v7_0_2, v7_0_3, v7_0_4) => v7.clone(),
                        _ => {
                            let v0_1_temp: string = v0_1.get().clone();
                            let v1_1_temp: LrcPtr<StringBuilder> = v1_1.get().clone();
                            let v2_1_temp: LrcPtr<Runtime::UH1> = match v2_1.get().clone().as_ref()
                            {
                                Runtime::UH1::UH1_1(_, x) => x.clone(),
                                _ => unreachable!(),
                            };
                            v0_1.set(v0_1_temp);
                            v1_1.set(v1_1_temp);
                            v2_1.set(v2_1_temp);
                            continue '_method26;
                        }
                    }
                }
            });
        }
    }
    pub fn method27(v0_1: char, v1_1: i64) -> bool {
        let v0_1: MutCell<char> = MutCell::new(v0_1);
        let v1_1: MutCell<i64> = MutCell::new(v1_1);
        '_method27: loop {
            break '_method27 (if v1_1.get().clone() >= 2_i64 {
                false
            } else {
                let v11: Runtime::US9 = if v1_1.get().clone() == 0_i64 {
                    Runtime::US9::US9_0('\"')
                } else {
                    let v5: i64 = v1_1.get().clone() - 1_i64;
                    if v5 == 0_i64 {
                        Runtime::US9::US9_0('\'')
                    } else {
                        let v8: i64 = v5 - 1_i64;
                        Runtime::US9::US9_1
                    }
                };
                if v0_1.get().clone()
                    == match &v11 {
                        Runtime::US9::US9_0(v11_0_0) => match &v11 {
                            Runtime::US9::US9_0(x) => x.clone(),
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
                    continue '_method27;
                }
            });
        }
    }
    pub fn method28(
        v0_1: string,
        v1_1: string,
        v2_1: LrcPtr<StringBuilder>,
        v3: i32,
        v4: i32,
    ) -> (string, string, LrcPtr<StringBuilder>, i32, i32) {
        let v0_1: MutCell<string> = MutCell::new(v0_1.clone());
        let v1_1: MutCell<string> = MutCell::new(v1_1.clone());
        let v2_1: MutCell<LrcPtr<StringBuilder>> = MutCell::new(v2_1.clone());
        let v3: MutCell<i32> = MutCell::new(v3);
        let v4: MutCell<i32> = MutCell::new(v4);
        '_method28: loop {
            break '_method28 ({
                let v109: Runtime::US7 = if string("") == v1_1.get().clone() {
                    Runtime::US7::US7_1(sprintf!(
                        "parsing.none_of / unexpected end of input / chars: {:?} / s: {:?}",
                        toArray(ofArray(new_array(&['\"', '\'']))),
                        (v2_1.get().clone(), v3.get().clone(), v4.get().clone())
                    ))
                } else {
                    let v21: char = getCharAt(v1_1.get().clone(), 0_i32);
                    if Runtime::method27(v21, 0_i64) == false {
                        let v44: string = getSlice(
                            v1_1.get().clone(),
                            Some(1_i32),
                            Some(length(v1_1.get().clone()) - 1_i32),
                        );
                        let v49: string = ofChar(v21);
                        let v52: i32 = length(v49.clone());
                        let v53: Array<char> = new_init(&'\u{0000}', v52);
                        let v54: LrcPtr<Runtime::Mut5> = LrcPtr::new(Runtime::Mut5 {
                            l0: MutCell::new(0_i32),
                        });
                        while Runtime::method23(v52, v54.clone()) {
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
                            let patternInput: (LrcPtr<StringBuilder>, i32, i32) = Runtime::method25(
                                foldBack(
                                    Func2::new(move |b0: char, b1: LrcPtr<Runtime::UH0>| {
                                        (Runtime::method24())(b0)(b1)
                                    }),
                                    v59,
                                    LrcPtr::new(Runtime::UH0::UH0_0),
                                ),
                                v2_1.get().clone(),
                                v3.get().clone(),
                                v4.get().clone(),
                            );
                            Runtime::US7::US7_0(
                                v21,
                                v44,
                                patternInput.0.clone(),
                                patternInput.1.clone(),
                                patternInput.2.clone(),
                            )
                        }
                    } else {
                        Runtime::US7::US7_1(sprintf!(
                            "parsing.none_of / unexpected char: \'{}\' / chars: {:?} / s: {:?}",
                            v21,
                            toArray(ofArray(new_array(&['\"', '\'']))),
                            (v2_1.get().clone(), v3.get().clone(), v4.get().clone())
                        ))
                    }
                };
                let v121: Runtime::US7 = match &v109 {
                    Runtime::US7::US7_0(v109_0_0, v109_0_1, v109_0_2, v109_0_3, v109_0_4) => {
                        let v110: char = v109_0_0.clone();
                        Runtime::US7::US7_0(
                            if '\\' == v110 { '/' } else { v110 },
                            v109_0_1.clone(),
                            v109_0_2.clone(),
                            v109_0_3.clone(),
                            v109_0_4.clone(),
                        )
                    }
                    Runtime::US7::US7_1(v109_1_0) => Runtime::US7::US7_1(v109_1_0.clone()),
                };
                match &v121 {
                    Runtime::US7::US7_0(v121_0_0, v121_0_1, v121_0_2, v121_0_3, v121_0_4) => {
                        let v0_1_temp: string =
                            append(v0_1.get().clone(), ofChar(v121_0_0.clone()));
                        let v1_1_temp: string = v121_0_1.clone();
                        let v2_1_temp: LrcPtr<StringBuilder> = v121_0_2.clone();
                        let v3_temp: i32 = v121_0_3.clone();
                        let v4_temp: i32 = v121_0_4.clone();
                        v0_1.set(v0_1_temp);
                        v1_1.set(v1_1_temp);
                        v2_1.set(v2_1_temp);
                        v3.set(v3_temp);
                        v4.set(v4_temp);
                        continue '_method28;
                    }
                    _ => (
                        v0_1.get().clone(),
                        v1_1.get().clone(),
                        v2_1.get().clone(),
                        v3.get().clone(),
                        v4.get().clone(),
                    ),
                }
            });
        }
    }
    pub fn method29(
        v0_1: string,
        v1_1: LrcPtr<StringBuilder>,
        v2_1: i32,
        v3: i32,
        v4: LrcPtr<Runtime::UH1>,
    ) -> Runtime::US7 {
        let v0_1: MutCell<string> = MutCell::new(v0_1.clone());
        let v1_1: MutCell<LrcPtr<StringBuilder>> = MutCell::new(v1_1.clone());
        let v2_1: MutCell<i32> = MutCell::new(v2_1);
        let v3: MutCell<i32> = MutCell::new(v3);
        let v4: MutCell<LrcPtr<Runtime::UH1>> = MutCell::new(v4.clone());
        '_method29: loop {
            break '_method29 (match v4.get().clone().as_ref() {
                Runtime::UH1::UH1_0 => {
                    Runtime::US7::US7_1(string("parsing.choice / no parsers succeeded"))
                }
                Runtime::UH1::UH1_1(v4_1_0, v4_1_1) => {
                    let v9: Runtime::US7 = (match v4.get().clone().as_ref() {
                        Runtime::UH1::UH1_1(x, _) => x.clone(),
                        _ => unreachable!(),
                    })((
                        v0_1.get().clone(),
                        v1_1.get().clone(),
                        v2_1.get().clone(),
                        v3.get().clone(),
                    ));
                    match &v9 {
                        Runtime::US7::US7_0(v9_0_0, v9_0_1, v9_0_2, v9_0_3, v9_0_4) => v9.clone(),
                        _ => {
                            let v0_1_temp: string = v0_1.get().clone();
                            let v1_1_temp: LrcPtr<StringBuilder> = v1_1.get().clone();
                            let v2_1_temp: i32 = v2_1.get().clone();
                            let v3_temp: i32 = v3.get().clone();
                            let v4_temp: LrcPtr<Runtime::UH1> = match v4.get().clone().as_ref() {
                                Runtime::UH1::UH1_1(_, x) => x.clone(),
                                _ => unreachable!(),
                            };
                            v0_1.set(v0_1_temp);
                            v1_1.set(v1_1_temp);
                            v2_1.set(v2_1_temp);
                            v3.set(v3_temp);
                            v4.set(v4_temp);
                            continue '_method29;
                        }
                    }
                }
            });
        }
    }
    pub fn method30(v0_1: char, v1_1: i64) -> bool {
        let v0_1: MutCell<char> = MutCell::new(v0_1);
        let v1_1: MutCell<i64> = MutCell::new(v1_1);
        '_method30: loop {
            break '_method30 (if v1_1.get().clone() >= 3_i64 {
                false
            } else {
                let v15: Runtime::US9 = if v1_1.get().clone() == 0_i64 {
                    Runtime::US9::US9_0('\"')
                } else {
                    let v5: i64 = v1_1.get().clone() - 1_i64;
                    if v5 == 0_i64 {
                        Runtime::US9::US9_0('\'')
                    } else {
                        let v8: i64 = v5 - 1_i64;
                        if v8 == 0_i64 {
                            Runtime::US9::US9_0(' ')
                        } else {
                            let v11: i64 = v8 - 1_i64;
                            Runtime::US9::US9_1
                        }
                    }
                };
                if v0_1.get().clone()
                    == match &v15 {
                        Runtime::US9::US9_0(v15_0_0) => match &v15 {
                            Runtime::US9::US9_0(x) => x.clone(),
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
                    continue '_method30;
                }
            });
        }
    }
    pub fn method31(
        v0_1: string,
        v1_1: string,
        v2_1: LrcPtr<StringBuilder>,
        v3: i32,
        v4: i32,
    ) -> (string, string, LrcPtr<StringBuilder>, i32, i32) {
        let v0_1: MutCell<string> = MutCell::new(v0_1.clone());
        let v1_1: MutCell<string> = MutCell::new(v1_1.clone());
        let v2_1: MutCell<LrcPtr<StringBuilder>> = MutCell::new(v2_1.clone());
        let v3: MutCell<i32> = MutCell::new(v3);
        let v4: MutCell<i32> = MutCell::new(v4);
        '_method31: loop {
            break '_method31 ({
                let v115: Runtime::US7 = if string("") == v1_1.get().clone() {
                    Runtime::US7::US7_1(sprintf!(
                        "parsing.none_of / unexpected end of input / chars: {:?} / s: {:?}",
                        toArray(ofArray(new_array(&['\"', '\'', ' ']))),
                        (v2_1.get().clone(), v3.get().clone(), v4.get().clone())
                    ))
                } else {
                    let v24: char = getCharAt(v1_1.get().clone(), 0_i32);
                    if Runtime::method30(v24, 0_i64) == false {
                        let v47: string = getSlice(
                            v1_1.get().clone(),
                            Some(1_i32),
                            Some(length(v1_1.get().clone()) - 1_i32),
                        );
                        let v52: string = ofChar(v24);
                        let v55: i32 = length(v52.clone());
                        let v56: Array<char> = new_init(&'\u{0000}', v55);
                        let v57: LrcPtr<Runtime::Mut5> = LrcPtr::new(Runtime::Mut5 {
                            l0: MutCell::new(0_i32),
                        });
                        while Runtime::method23(v55, v57.clone()) {
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
                            let patternInput: (LrcPtr<StringBuilder>, i32, i32) = Runtime::method25(
                                foldBack(
                                    Func2::new(move |b0: char, b1: LrcPtr<Runtime::UH0>| {
                                        (Runtime::method24())(b0)(b1)
                                    }),
                                    v62,
                                    LrcPtr::new(Runtime::UH0::UH0_0),
                                ),
                                v2_1.get().clone(),
                                v3.get().clone(),
                                v4.get().clone(),
                            );
                            Runtime::US7::US7_0(
                                v24,
                                v47,
                                patternInput.0.clone(),
                                patternInput.1.clone(),
                                patternInput.2.clone(),
                            )
                        }
                    } else {
                        Runtime::US7::US7_1(sprintf!(
                            "parsing.none_of / unexpected char: \'{}\' / chars: {:?} / s: {:?}",
                            v24,
                            toArray(ofArray(new_array(&['\"', '\'', ' ']))),
                            (v2_1.get().clone(), v3.get().clone(), v4.get().clone())
                        ))
                    }
                };
                let v127: Runtime::US7 = match &v115 {
                    Runtime::US7::US7_0(v115_0_0, v115_0_1, v115_0_2, v115_0_3, v115_0_4) => {
                        let v116: char = v115_0_0.clone();
                        Runtime::US7::US7_0(
                            if '\\' == v116 { '/' } else { v116 },
                            v115_0_1.clone(),
                            v115_0_2.clone(),
                            v115_0_3.clone(),
                            v115_0_4.clone(),
                        )
                    }
                    Runtime::US7::US7_1(v115_1_0) => Runtime::US7::US7_1(v115_1_0.clone()),
                };
                match &v127 {
                    Runtime::US7::US7_0(v127_0_0, v127_0_1, v127_0_2, v127_0_3, v127_0_4) => {
                        let v0_1_temp: string =
                            append(v0_1.get().clone(), ofChar(v127_0_0.clone()));
                        let v1_1_temp: string = v127_0_1.clone();
                        let v2_1_temp: LrcPtr<StringBuilder> = v127_0_2.clone();
                        let v3_temp: i32 = v127_0_3.clone();
                        let v4_temp: i32 = v127_0_4.clone();
                        v0_1.set(v0_1_temp);
                        v1_1.set(v1_1_temp);
                        v2_1.set(v2_1_temp);
                        v3.set(v3_temp);
                        v4.set(v4_temp);
                        continue '_method31;
                    }
                    _ => (
                        v0_1.get().clone(),
                        v1_1.get().clone(),
                        v2_1.get().clone(),
                        v3.get().clone(),
                        v4.get().clone(),
                    ),
                }
            });
        }
    }
    pub fn method32(v0_1: string, v1_1: i32) -> i32 {
        let v0_1: MutCell<string> = MutCell::new(v0_1.clone());
        let v1_1: MutCell<i32> = MutCell::new(v1_1);
        '_method32: loop {
            break '_method32 (if v1_1.get().clone() >= length(v0_1.get().clone()) {
                v1_1.get().clone()
            } else {
                if ' ' == getCharAt(v0_1.get().clone(), v1_1.get().clone()) {
                    let v0_1_temp: string = v0_1.get().clone();
                    let v1_1_temp: i32 = v1_1.get().clone() + 1_i32;
                    v0_1.set(v0_1_temp);
                    v1_1.set(v1_1_temp);
                    continue '_method32;
                } else {
                    v1_1.get().clone()
                }
            });
        }
    }
    pub fn method33(
        v0_1: string,
        v1_1: string,
        v2_1: LrcPtr<StringBuilder>,
        v3: i32,
        v4: i32,
    ) -> (string, string, LrcPtr<StringBuilder>, i32, i32) {
        let v0_1: MutCell<string> = MutCell::new(v0_1.clone());
        let v1_1: MutCell<string> = MutCell::new(v1_1.clone());
        let v2_1: MutCell<LrcPtr<StringBuilder>> = MutCell::new(v2_1.clone());
        let v3: MutCell<i32> = MutCell::new(v3);
        let v4: MutCell<i32> = MutCell::new(v4);
        '_method33: loop {
            break '_method33 ({
                let v79: Runtime::US7 = if string("") == v1_1.get().clone() {
                    Runtime::US7::US7_1(sprintf!(
                        "parsing.any_char / unexpected end of input / s: {:?}",
                        (v2_1.get().clone(), v3.get().clone(), v4.get().clone())
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
                    let v40: LrcPtr<Runtime::Mut5> = LrcPtr::new(Runtime::Mut5 {
                        l0: MutCell::new(0_i32),
                    });
                    while Runtime::method23(v38, v40.clone()) {
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
                        let patternInput: (LrcPtr<StringBuilder>, i32, i32) = Runtime::method25(
                            foldBack(
                                Func2::new(move |b0: char, b1: LrcPtr<Runtime::UH0>| {
                                    (Runtime::method24())(b0)(b1)
                                }),
                                v45,
                                LrcPtr::new(Runtime::UH0::UH0_0),
                            ),
                            v2_1.get().clone(),
                            v3.get().clone(),
                            v4.get().clone(),
                        );
                        Runtime::US7::US7_0(
                            v10,
                            v30,
                            patternInput.0.clone(),
                            patternInput.1.clone(),
                            patternInput.2.clone(),
                        )
                    }
                };
                match &v79 {
                    Runtime::US7::US7_0(v79_0_0, v79_0_1, v79_0_2, v79_0_3, v79_0_4) => {
                        let v0_1_temp: string = append(v0_1.get().clone(), ofChar(v79_0_0.clone()));
                        let v1_1_temp: string = v79_0_1.clone();
                        let v2_1_temp: LrcPtr<StringBuilder> = v79_0_2.clone();
                        let v3_temp: i32 = v79_0_3.clone();
                        let v4_temp: i32 = v79_0_4.clone();
                        v0_1.set(v0_1_temp);
                        v1_1.set(v1_1_temp);
                        v2_1.set(v2_1_temp);
                        v3.set(v3_temp);
                        v4.set(v4_temp);
                        continue '_method33;
                    }
                    _ => (
                        v0_1.get().clone(),
                        v1_1.get().clone(),
                        v2_1.get().clone(),
                        v3.get().clone(),
                        v4.get().clone(),
                    ),
                }
            });
        }
    }
    pub fn method21(v0_1: string) -> Runtime::US6 {
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
            let v12: LrcPtr<StringBuilder> = StringBuilder::_ctor__Z721C83C5(Runtime::method22());
            fn v15(arg10_0040: (string, LrcPtr<StringBuilder>, i32, i32)) -> Runtime::US7 {
                Runtime::closure14((), arg10_0040)
            }
            fn v16_1(arg10_0040_1: (string, LrcPtr<StringBuilder>, i32, i32)) -> Runtime::US7 {
                Runtime::closure17((), arg10_0040_1)
            }
            let v20_1: Runtime::US7 = Runtime::method26(
                v7.clone(),
                v12.clone(),
                LrcPtr::new(Runtime::UH1::UH1_1(
                    Func1::from(v15),
                    LrcPtr::new(Runtime::UH1::UH1_1(
                        Func1::from(v16_1),
                        LrcPtr::new(Runtime::UH1::UH1_0),
                    )),
                )),
            );
            let v202: Runtime::US8 = match &v20_1 {
                Runtime::US7::US7_0(v20_1_0_0, v20_1_0_1, v20_1_0_2, v20_1_0_3, v20_1_0_4) => {
                    let v25: i32 = v20_1_0_4.clone();
                    let v24: i32 = v20_1_0_3.clone();
                    let v23: LrcPtr<StringBuilder> = v20_1_0_2.clone();
                    let v22: string = v20_1_0_1.clone();
                    let v130: Runtime::US7 = if string("") == v22.clone() {
                        Runtime::US7::US7_1(sprintf!(
                            "parsing.none_of / unexpected end of input / chars: {:?} / s: {:?}",
                            toArray(ofArray(new_array(&['\"', '\'']))),
                            (v23.clone(), v24, v25)
                        ))
                    } else {
                        let v42: char = getCharAt(v22.clone(), 0_i32);
                        if Runtime::method27(v42, 0_i64) == false {
                            let v65: string = getSlice(
                                v22.clone(),
                                Some(1_i32),
                                Some(length(v22.clone()) - 1_i32),
                            );
                            let v70: string = ofChar(v42);
                            let v73: i32 = length(v70.clone());
                            let v74: Array<char> = new_init(&'\u{0000}', v73);
                            let v75: LrcPtr<Runtime::Mut5> = LrcPtr::new(Runtime::Mut5 {
                                l0: MutCell::new(0_i32),
                            });
                            while Runtime::method23(v73, v75.clone()) {
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
                                let patternInput: (LrcPtr<StringBuilder>, i32, i32) =
                                    Runtime::method25(
                                        foldBack(
                                            Func2::new(
                                                move |b0: char, b1: LrcPtr<Runtime::UH0>| {
                                                    (Runtime::method24())(b0)(b1)
                                                },
                                            ),
                                            v80,
                                            LrcPtr::new(Runtime::UH0::UH0_0),
                                        ),
                                        v23.clone(),
                                        v24,
                                        v25,
                                    );
                                Runtime::US7::US7_0(
                                    v42,
                                    v65,
                                    patternInput.0.clone(),
                                    patternInput.1.clone(),
                                    patternInput.2.clone(),
                                )
                            }
                        } else {
                            Runtime::US7::US7_1(sprintf!(
                                "parsing.none_of / unexpected char: \'{}\' / chars: {:?} / s: {:?}",
                                v42,
                                toArray(ofArray(new_array(&['\"', '\'']))),
                                (v23.clone(), v24, v25)
                            ))
                        }
                    };
                    let v142: Runtime::US7 = match &v130 {
                        Runtime::US7::US7_0(v130_0_0, v130_0_1, v130_0_2, v130_0_3, v130_0_4) => {
                            let v131: char = v130_0_0.clone();
                            Runtime::US7::US7_0(
                                if '\\' == v131 { '/' } else { v131 },
                                v130_0_1.clone(),
                                v130_0_2.clone(),
                                v130_0_3.clone(),
                                v130_0_4.clone(),
                            )
                        }
                        Runtime::US7::US7_1(v130_1_0) => Runtime::US7::US7_1(v130_1_0.clone()),
                    };
                    let v161: Runtime::US8 = match &v142 {
                        Runtime::US7::US7_0(v142_0_0, v142_0_1, v142_0_2, v142_0_3, v142_0_4) => {
                            let patternInput_1: (string, string, LrcPtr<StringBuilder>, i32, i32) =
                                Runtime::method28(
                                    ofChar(v142_0_0.clone()),
                                    v142_0_1.clone(),
                                    v142_0_2.clone(),
                                    v142_0_3.clone(),
                                    v142_0_4.clone(),
                                );
                            Runtime::US8::US8_0(
                                patternInput_1.0.clone(),
                                patternInput_1.1.clone(),
                                patternInput_1.2.clone(),
                                patternInput_1.3.clone(),
                                patternInput_1.4.clone(),
                            )
                        }
                        Runtime::US7::US7_1(v142_1_0) => Runtime::US8::US8_1(v142_1_0.clone()),
                    };
                    let v171: Runtime::US8 = match &v161 {
                        Runtime::US8::US8_0(v161_0_0, v161_0_1, v161_0_2, v161_0_3, v161_0_4) => {
                            Runtime::US8::US8_0(
                                v161_0_0.clone(),
                                v161_0_1.clone(),
                                v161_0_2.clone(),
                                v161_0_3.clone(),
                                v161_0_4.clone(),
                            )
                        }
                        _ => Runtime::US8::US8_0(string(""), v22.clone(), v23.clone(), v24, v25),
                    };
                    match &v171 {
                        Runtime::US8::US8_0(v171_0_0, v171_0_1, v171_0_2, v171_0_3, v171_0_4) => {
                            let v176: i32 = v171_0_4.clone();
                            let v175: i32 = v171_0_3.clone();
                            let v174: LrcPtr<StringBuilder> = v171_0_2.clone();
                            let v173: string = v171_0_1.clone();
                            let v180: Runtime::US7 = Runtime::method29(
                                v173.clone(),
                                v174.clone(),
                                v175,
                                v176,
                                LrcPtr::new(Runtime::UH1::UH1_1(
                                    Func1::from(v15),
                                    LrcPtr::new(Runtime::UH1::UH1_1(
                                        Func1::from(v16_1),
                                        LrcPtr::new(Runtime::UH1::UH1_0),
                                    )),
                                )),
                            );
                            match &v180 {
                                    Runtime::US7::US7_0(v180_0_0, v180_0_1,
                                                        v180_0_2, v180_0_3,
                                                        v180_0_4) =>
                                    Runtime::US8::US8_0(v171_0_0.clone(),
                                                        v180_0_1.clone(),
                                                        v180_0_2.clone(),
                                                        v180_0_3.clone(),
                                                        v180_0_4.clone()),
                                    Runtime::US7::US7_1(v180_1_0) =>
                                    Runtime::US8::US8_1(sprintf!("parsing.between / expected closing delimiter / e: {:?} / input: {:?} / rest1: {:?} / rest2: {:?}",
                                                                 v180_1_0.clone(),
                                                                 (v7.clone(),
                                                                  v12.clone(),
                                                                  1_i32,
                                                                  1_i32),
                                                                 (v22, v23,
                                                                  v24, v25),
                                                                 (v173, v174,
                                                                  v175,
                                                                  v176))),
                                }
                        }
                        _ => Runtime::US8::US8_1(string("parsing.between / expected content")),
                    }
                }
                Runtime::US7::US7_1(v20_1_1_0) => Runtime::US8::US8_1(v20_1_1_0.clone()),
            };
            let v414: Runtime::US8 = match &v202 {
                Runtime::US8::US8_0(v202_0_0, v202_0_1, v202_0_2, v202_0_3, v202_0_4) => {
                    v202.clone()
                }
                _ => {
                    let v321: Runtime::US7 = if string("") == v7.clone() {
                        Runtime::US7::US7_1(sprintf!(
                            "parsing.none_of / unexpected end of input / chars: {:?} / s: {:?}",
                            toArray(ofArray(new_array(&['\"', '\'', ' ']))),
                            (v12.clone(), 1_i32, 1_i32)
                        ))
                    } else {
                        let v228: char = getCharAt(v7.clone(), 0_i32);
                        if Runtime::method30(v228, 0_i64) == false {
                            let v251: string =
                                getSlice(v7.clone(), Some(1_i32), Some(length(v7.clone()) - 1_i32));
                            let v256: string = ofChar(v228);
                            let v259: i32 = length(v256.clone());
                            let v260: Array<char> = new_init(&'\u{0000}', v259);
                            let v261: LrcPtr<Runtime::Mut5> = LrcPtr::new(Runtime::Mut5 {
                                l0: MutCell::new(0_i32),
                            });
                            while Runtime::method23(v259, v261.clone()) {
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
                                let patternInput_2: (LrcPtr<StringBuilder>, i32, i32) =
                                    Runtime::method25(
                                        foldBack(
                                            Func2::new(
                                                move |b0: char, b1: LrcPtr<Runtime::UH0>| {
                                                    (Runtime::method24())(b0)(b1)
                                                },
                                            ),
                                            v266,
                                            LrcPtr::new(Runtime::UH0::UH0_0),
                                        ),
                                        v12.clone(),
                                        1_i32,
                                        1_i32,
                                    );
                                Runtime::US7::US7_0(
                                    v228,
                                    v251,
                                    patternInput_2.0.clone(),
                                    patternInput_2.1.clone(),
                                    patternInput_2.2.clone(),
                                )
                            }
                        } else {
                            Runtime::US7::US7_1(sprintf!(
                                "parsing.none_of / unexpected char: \'{}\' / chars: {:?} / s: {:?}",
                                v228,
                                toArray(ofArray(new_array(&['\"', '\'', ' ']))),
                                (v12.clone(), 1_i32, 1_i32)
                            ))
                        }
                    };
                    let v333: Runtime::US7 = match &v321 {
                        Runtime::US7::US7_0(v321_0_0, v321_0_1, v321_0_2, v321_0_3, v321_0_4) => {
                            let v322: char = v321_0_0.clone();
                            Runtime::US7::US7_0(
                                if '\\' == v322 { '/' } else { v322 },
                                v321_0_1.clone(),
                                v321_0_2.clone(),
                                v321_0_3.clone(),
                                v321_0_4.clone(),
                            )
                        }
                        Runtime::US7::US7_1(v321_1_0) => Runtime::US7::US7_1(v321_1_0.clone()),
                    };
                    let v352: Runtime::US8 = match &v333 {
                        Runtime::US7::US7_0(v333_0_0, v333_0_1, v333_0_2, v333_0_3, v333_0_4) => {
                            let patternInput_3: (string, string, LrcPtr<StringBuilder>, i32, i32) =
                                Runtime::method31(
                                    ofChar(v333_0_0.clone()),
                                    v333_0_1.clone(),
                                    v333_0_2.clone(),
                                    v333_0_3.clone(),
                                    v333_0_4.clone(),
                                );
                            Runtime::US8::US8_0(
                                patternInput_3.0.clone(),
                                patternInput_3.1.clone(),
                                patternInput_3.2.clone(),
                                patternInput_3.3.clone(),
                                patternInput_3.4.clone(),
                            )
                        }
                        Runtime::US7::US7_1(v333_1_0) => Runtime::US8::US8_1(v333_1_0.clone()),
                    };
                    match &v352 {
                        Runtime::US8::US8_0(v352_0_0, v352_0_1, v352_0_2, v352_0_3, v352_0_4) => {
                            v352.clone()
                        }
                        _ => {
                            let v366: Runtime::US10 = if length(v7.clone()) == 0_i32 {
                                Runtime::US10::US10_0(v7.clone(), v12.clone(), 1_i32, 1_i32)
                            } else {
                                Runtime::US10::US10_1(sprintf!(
                                    "parsing.eof / expected end of input / input: {:?}",
                                    v7.clone()
                                ))
                            };
                            let v375: Runtime::US8 = match &v366 {
                                Runtime::US10::US10_0(v366_0_0, v366_0_1, v366_0_2, v366_0_3) => {
                                    Runtime::US8::US8_0(
                                        string(""),
                                        v366_0_0.clone(),
                                        v366_0_1.clone(),
                                        v366_0_2.clone(),
                                        v366_0_3.clone(),
                                    )
                                }
                                Runtime::US10::US10_1(v366_1_0) => {
                                    Runtime::US8::US8_1(v366_1_0.clone())
                                }
                            };
                            match &v375 {
                                Runtime::US8::US8_0(
                                    v375_0_0,
                                    v375_0_1,
                                    v375_0_2,
                                    v375_0_3,
                                    v375_0_4,
                                ) => {
                                    let v377: string = v375_0_1.clone();
                                    Runtime::US8::US8_0(
                                        v375_0_0.clone(),
                                        getSlice(
                                            v377.clone(),
                                            Some(Runtime::method32(v377.clone(), 0_i32)),
                                            Some(length(v377) - 1_i32),
                                        ),
                                        v375_0_2.clone(),
                                        v375_0_3.clone(),
                                        v375_0_4.clone(),
                                    )
                                }
                                Runtime::US8::US8_1(v375_1_0) => {
                                    Runtime::US8::US8_1(v375_1_0.clone())
                                }
                            }
                        }
                    }
                }
            };
            let v685: Runtime::US11 = match &v414 {
                Runtime::US8::US8_0(v414_0_0, v414_0_1, v414_0_2, v414_0_3, v414_0_4) => {
                    let v419: i32 = v414_0_4.clone();
                    let v418: i32 = v414_0_3.clone();
                    let v417: LrcPtr<StringBuilder> = v414_0_2.clone();
                    let v416: string = v414_0_1.clone();
                    let v544: Runtime::US7 = if string("") == v416.clone() {
                        Runtime::US7::US7_1(sprintf!(
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
                            let v456: LrcPtr<Runtime::Mut5> = LrcPtr::new(Runtime::Mut5 {
                                l0: MutCell::new(0_i32),
                            });
                            while Runtime::method23(v454, v456.clone()) {
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
                                let patternInput_4: (LrcPtr<StringBuilder>, i32, i32) =
                                    Runtime::method25(
                                        foldBack(
                                            Func2::new(
                                                move |b0: char, b1: LrcPtr<Runtime::UH0>| {
                                                    (Runtime::method24())(b0)(b1)
                                                },
                                            ),
                                            v461,
                                            LrcPtr::new(Runtime::UH0::UH0_0),
                                        ),
                                        v417.clone(),
                                        v418,
                                        v419,
                                    );
                                Runtime::US7::US7_0(
                                    v425,
                                    v446,
                                    patternInput_4.0.clone(),
                                    patternInput_4.1.clone(),
                                    patternInput_4.2.clone(),
                                )
                            }
                        } else {
                            let v499: i32 = indexOf(v416.clone(), string("\n")) - 1_i32;
                            Runtime::US7::US7_1(sprintf!(
                                "{}\n{}\n",
                                sprintf!(
                                    "parsing.p_char / expected: \'{}\' / line: {} / col: {}\n{}{}",
                                    ' ',
                                    v418,
                                    v419,
                                    v417.clone(),
                                    getSlice(
                                        v416.clone(),
                                        Some(0_i32),
                                        Some(
                                            if -2_i32 == v499 {
                                                length(v416.clone()) + 1_i32
                                            } else {
                                                v499 + 1_i32
                                            } - 1_i32
                                        )
                                    )
                                ),
                                append(replicate(v419 - 1_i32, string(" ")), string("^"))
                            ))
                        }
                    };
                    let v556: Runtime::US12 = match &v544 {
                        Runtime::US7::US7_0(v544_0_0, v544_0_1, v544_0_2, v544_0_3, v544_0_4) => {
                            Runtime::US12::US12_0(
                                Runtime::US9::US9_0(v544_0_0.clone()),
                                v544_0_1.clone(),
                                v544_0_2.clone(),
                                v544_0_3.clone(),
                                v544_0_4.clone(),
                            )
                        }
                        _ => Runtime::US12::US12_0(
                            Runtime::US9::US9_1,
                            v416.clone(),
                            v417.clone(),
                            v418,
                            v419,
                        ),
                    };
                    let v659: Runtime::US8 = match &v556 {
                        Runtime::US12::US12_0(v556_0_0, v556_0_1, v556_0_2, v556_0_3, v556_0_4) => {
                            let v561: i32 = v556_0_4.clone();
                            let v560: i32 = v556_0_3.clone();
                            let v559: LrcPtr<StringBuilder> = v556_0_2.clone();
                            let v558: string = v556_0_1.clone();
                            let v636: Runtime::US7 = if string("") == v558.clone() {
                                Runtime::US7::US7_1(sprintf!(
                                    "parsing.any_char / unexpected end of input / s: {:?}",
                                    (v559.clone(), v560, v561)
                                ))
                            } else {
                                let v567: char = getCharAt(v558.clone(), 0_i32);
                                let v587: string =
                                    getSlice(v558.clone(), Some(1_i32), Some(length(v558) - 1_i32));
                                let v592: string = ofChar(v567);
                                let v595: i32 = length(v592.clone());
                                let v596: Array<char> = new_init(&'\u{0000}', v595);
                                let v597: LrcPtr<Runtime::Mut5> = LrcPtr::new(Runtime::Mut5 {
                                    l0: MutCell::new(0_i32),
                                });
                                while Runtime::method23(v595, v597.clone()) {
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
                                    let patternInput_5: (LrcPtr<StringBuilder>, i32, i32) =
                                        Runtime::method25(
                                            foldBack(
                                                Func2::new(
                                                    move |b0: char, b1: LrcPtr<Runtime::UH0>| {
                                                        (Runtime::method24())(b0)(b1)
                                                    },
                                                ),
                                                v602,
                                                LrcPtr::new(Runtime::UH0::UH0_0),
                                            ),
                                            v559,
                                            v560,
                                            v561,
                                        );
                                    Runtime::US7::US7_0(
                                        v567,
                                        v587,
                                        patternInput_5.0.clone(),
                                        patternInput_5.1.clone(),
                                        patternInput_5.2.clone(),
                                    )
                                }
                            };
                            match &v636 {
                                Runtime::US7::US7_0(
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
                                    ) = Runtime::method33(
                                        ofChar(v636_0_0.clone()),
                                        v636_0_1.clone(),
                                        v636_0_2.clone(),
                                        v636_0_3.clone(),
                                        v636_0_4.clone(),
                                    );
                                    Runtime::US8::US8_0(
                                        patternInput_6.0.clone(),
                                        patternInput_6.1.clone(),
                                        patternInput_6.2.clone(),
                                        patternInput_6.3.clone(),
                                        patternInput_6.4.clone(),
                                    )
                                }
                                Runtime::US7::US7_1(v636_1_0) => {
                                    Runtime::US8::US8_1(v636_1_0.clone())
                                }
                            }
                        }
                        Runtime::US12::US12_1(v556_1_0) => Runtime::US8::US8_1(v556_1_0.clone()),
                    };
                    let v671: Runtime::US13 = match &v659 {
                        Runtime::US8::US8_0(v659_0_0, v659_0_1, v659_0_2, v659_0_3, v659_0_4) => {
                            Runtime::US13::US13_0(
                                Runtime::US5::US5_0(v659_0_0.clone()),
                                v659_0_1.clone(),
                                v659_0_2.clone(),
                                v659_0_3.clone(),
                                v659_0_4.clone(),
                            )
                        }
                        _ => Runtime::US13::US13_0(Runtime::US5::US5_1, v416, v417, v418, v419),
                    };
                    match &v671 {
                        Runtime::US13::US13_0(v671_0_0, v671_0_1, v671_0_2, v671_0_3, v671_0_4) => {
                            Runtime::US11::US11_0(
                                v414_0_0.clone(),
                                v671_0_0.clone(),
                                v671_0_1.clone(),
                                v671_0_2.clone(),
                                v671_0_3.clone(),
                                v671_0_4.clone(),
                            )
                        }
                        Runtime::US13::US13_1(v671_1_0) => Runtime::US11::US11_1(v671_1_0.clone()),
                    }
                }
                Runtime::US8::US8_1(v414_1_0) => Runtime::US11::US11_1(v414_1_0.clone()),
            };
            match &v685 {
                Runtime::US11::US11_0(
                    v685_0_0,
                    v685_0_1,
                    v685_0_2,
                    v685_0_3,
                    v685_0_4,
                    v685_0_5,
                ) => Runtime::US6::US6_0(v685_0_0.clone(), v685_0_1.clone()),
                Runtime::US11::US11_1(v685_1_0) => Runtime::US6::US6_1(v685_1_0.clone()),
            }
        }
    }
    pub fn method34() -> string {
        let v6: string = Runtime::method11(getCharAt(toLower(string("Debug")), 0_i32));
        let v73: &str = inline_colorization::color_bright_blue;
        let v80: &str = &*v6;
        let v99: &str = inline_colorization::color_reset;
        let v101: std::string::String = format!("{}{}{}", v73, v80, v99);
        fable_library_rust::String_::fromString(v101)
    }
    pub fn method36(
        v0_1: string,
        v1_1: Runtime::US5,
        v2_1: string,
        v3: Option<CancellationToken>,
        v4: Array<(string, string)>,
        v5: Option<Func1<(i32, string, bool), Arc<Async<()>>>>,
        v6: Option<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
        v7: bool,
        v8: Option<string>,
    ) -> string {
        let v10: LrcPtr<Runtime::Mut3> = LrcPtr::new(Runtime::Mut3 {
            l0: MutCell::new(Runtime::method12()),
        });
        let v17_1: () = {
            Runtime::closure7(v10.clone(), sprintf!("{}", string("{ ")), ());
            ()
        };
        let v26: () = {
            Runtime::closure7(v10.clone(), sprintf!("{}", string("file_name")), ());
            ()
        };
        let v35: () = {
            Runtime::closure7(v10.clone(), sprintf!("{}", string(" = ")), ());
            ()
        };
        let v43: () = {
            Runtime::closure7(v10.clone(), sprintf!("{}", v0_1), ());
            ()
        };
        let v52: () = {
            Runtime::closure7(v10.clone(), sprintf!("{}", string("; ")), ());
            ()
        };
        let v61: () = {
            Runtime::closure7(v10.clone(), sprintf!("{}", string("arguments")), ());
            ()
        };
        let v69: () = {
            Runtime::closure7(v10.clone(), sprintf!("{}", string(" = ")), ());
            ()
        };
        let v80: () = {
            Runtime::closure7(v10.clone(), sprintf!("{}", sprintf!("{:?}", v1_1)), ());
            ()
        };
        let v88: () = {
            Runtime::closure7(v10.clone(), sprintf!("{}", string("; ")), ());
            ()
        };
        let v97: () = {
            Runtime::closure7(v10.clone(), sprintf!("{}", string("options")), ());
            ()
        };
        let v105: () = {
            Runtime::closure7(v10.clone(), sprintf!("{}", string(" = ")), ());
            ()
        };
        let v113: () = {
            Runtime::closure7(v10.clone(), sprintf!("{}", string("{ ")), ());
            ()
        };
        let v122: () = {
            Runtime::closure7(v10.clone(), sprintf!("{}", string("command")), ());
            ()
        };
        let v130: () = {
            Runtime::closure7(v10.clone(), sprintf!("{}", string(" = ")), ());
            ()
        };
        let v138: () = {
            Runtime::closure7(v10.clone(), sprintf!("{}", v2_1), ());
            ()
        };
        let v146: () = {
            Runtime::closure7(v10.clone(), sprintf!("{}", string("; ")), ());
            ()
        };
        let v155: () = {
            Runtime::closure7(
                v10.clone(),
                sprintf!("{}", string("cancellation_token")),
                (),
            );
            ()
        };
        let v163: () = {
            Runtime::closure7(v10.clone(), sprintf!("{}", string(" = ")), ());
            ()
        };
        let v176: std::string::String = format!("{:#?}", v3);
        let v201: () = {
            Runtime::closure7(
                v10.clone(),
                sprintf!("{}", fable_library_rust::String_::fromString(v176)),
                (),
            );
            ()
        };
        let v209: () = {
            Runtime::closure7(v10.clone(), sprintf!("{}", string("; ")), ());
            ()
        };
        let v218: () = {
            Runtime::closure7(
                v10.clone(),
                sprintf!("{}", string("environment_variables")),
                (),
            );
            ()
        };
        let v226: () = {
            Runtime::closure7(v10.clone(), sprintf!("{}", string(" = ")), ());
            ()
        };
        let v237: () = {
            Runtime::closure7(v10.clone(), sprintf!("{}", sprintf!("{:?}", v4)), ());
            ()
        };
        let v245: () = {
            Runtime::closure7(v10.clone(), sprintf!("{}", string("; ")), ());
            ()
        };
        let v254: () = {
            Runtime::closure7(v10.clone(), sprintf!("{}", string("on_line")), ());
            ()
        };
        let v262: () = {
            Runtime::closure7(v10.clone(), sprintf!("{}", string(" = ")), ());
            ()
        };
        let v275: std::string::String = format!("{:#?}", v5);
        let v300: () = {
            Runtime::closure7(
                v10.clone(),
                sprintf!("{}", fable_library_rust::String_::fromString(v275)),
                (),
            );
            ()
        };
        let v308: () = {
            Runtime::closure7(v10.clone(), sprintf!("{}", string("; ")), ());
            ()
        };
        let v317: () = {
            Runtime::closure7(v10.clone(), sprintf!("{}", string("stdin")), ());
            ()
        };
        let v325: () = {
            Runtime::closure7(v10.clone(), sprintf!("{}", string(" = ")), ());
            ()
        };
        let v338: std::string::String = format!("{:#?}", v6);
        let v363: () = {
            Runtime::closure7(
                v10.clone(),
                sprintf!("{}", fable_library_rust::String_::fromString(v338)),
                (),
            );
            ()
        };
        let v371: () = {
            Runtime::closure7(v10.clone(), sprintf!("{}", string("; ")), ());
            ()
        };
        let v380: () = {
            Runtime::closure7(v10.clone(), sprintf!("{}", string("trace")), ());
            ()
        };
        let v388: () = {
            Runtime::closure7(v10.clone(), sprintf!("{}", string(" = ")), ());
            ()
        };
        let v399: () = {
            Runtime::closure7(
                v10.clone(),
                sprintf!("{}", if v7 { string("true") } else { string("false") }),
                (),
            );
            ()
        };
        let v407: () = {
            Runtime::closure7(v10.clone(), sprintf!("{}", string("; ")), ());
            ()
        };
        let v416: () = {
            Runtime::closure7(v10.clone(), sprintf!("{}", string("working_directory")), ());
            ()
        };
        let v424: () = {
            Runtime::closure7(v10.clone(), sprintf!("{}", string(" = ")), ());
            ()
        };
        let v437: std::string::String = format!("{:#?}", v8);
        let v462: () = {
            Runtime::closure7(
                v10.clone(),
                sprintf!("{}", fable_library_rust::String_::fromString(v437)),
                (),
            );
            ()
        };
        let v471: () = {
            Runtime::closure7(v10.clone(), sprintf!("{}", string(" }")), ());
            ()
        };
        let v479: () = {
            Runtime::closure7(v10.clone(), sprintf!("{}", string(" }")), ());
            ()
        };
        v10.l0.get().clone()
    }
    pub fn method35(
        v0_1: LrcPtr<Runtime::Mut0>,
        v1_1: LrcPtr<Runtime::Mut1>,
        v2_1: LrcPtr<Runtime::Mut2>,
        v3: LrcPtr<Runtime::Mut3>,
        v4: LrcPtr<Runtime::Mut4>,
        v5: Option<i64>,
        v6: string,
        v7: string,
        v8: string,
        v9: Runtime::US5,
        v10: string,
        v11: Option<CancellationToken>,
        v12: Array<(string, string)>,
        v13: Option<Func1<(i32, string, bool), Arc<Async<()>>>>,
        v14: Option<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
        v15: bool,
        v16_1: Option<string>,
    ) -> string {
        let v17_1: string = Runtime::method36(v8, v9, v10, v11, v12, v13, v14, v15, v16_1);
        Runtime::method16(sprintf!(
            "{} {} #{} {} / {}",
            v6,
            v7,
            v0_1.l0.get().clone(),
            string("runtime.execute_with_options_async"),
            v17_1
        ))
    }
    pub fn closure18(
        v0_1: string,
        v1_1: Option<CancellationToken>,
        v2_1: Array<(string, string)>,
        v3: Option<Func1<(i32, string, bool), Arc<Async<()>>>>,
        v4: Option<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
        v5: bool,
        v6: Option<string>,
        v7: Runtime::US5,
        v8: string,
        unitVar: (),
    ) {
        if Runtime::method5(Runtime::US0::US0_1) {
            let v13: () = {
                Runtime::closure0((), ());
                ()
            };
            let patternInput: (
                LrcPtr<Runtime::Mut0>,
                LrcPtr<Runtime::Mut1>,
                LrcPtr<Runtime::Mut2>,
                LrcPtr<Runtime::Mut3>,
                LrcPtr<Runtime::Mut4>,
                Option<i64>,
            ) = getValue(Runtime::TraceState::trace_state().get().clone());
            let v32: Option<i64> = patternInput.5.clone();
            let v31: LrcPtr<Runtime::Mut4> = patternInput.4.clone();
            let v30: LrcPtr<Runtime::Mut3> = patternInput.3.clone();
            let v29: LrcPtr<Runtime::Mut2> = patternInput.2.clone();
            let v28: LrcPtr<Runtime::Mut1> = patternInput.1.clone();
            let v27: LrcPtr<Runtime::Mut0> = patternInput.0.clone();
            Runtime::method17(Runtime::method35(
                v27.clone(),
                v28.clone(),
                v29.clone(),
                v30.clone(),
                v31.clone(),
                v32.clone(),
                Runtime::method6(v27, v28, v29, v30, v31, v32),
                Runtime::method34(),
                v8,
                v7,
                v0_1,
                v1_1,
                v2_1,
                v3,
                v4,
                v5,
                v6,
            ))
        };
    }
    pub fn method37(
        v0_1: string,
        v1_1: Option<CancellationToken>,
        v2_1: Array<(string, string)>,
        v3: Option<Func1<(i32, string, bool), Arc<Async<()>>>>,
        v4: Option<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
        v5: bool,
        v6: Option<string>,
    ) -> Array<(string, string)> {
        v2_1
    }
    pub fn closure20(
        unitVar: (),
        v0_1: Func1<(i32, string, bool), Arc<Async<()>>>,
    ) -> Runtime::US14 {
        Runtime::US14::US14_0(v0_1)
    }
    pub fn method38() -> Func1<Func1<(i32, string, bool), Arc<Async<()>>>, Runtime::US14> {
        Func1::new(move |v: Func1<(i32, string, bool), Arc<Async<()>>>| Runtime::closure20((), v))
    }
    pub fn method39() -> string {
        let v6: string = Runtime::method11(getCharAt(toLower(string("Verbose")), 0_i32));
        let v73: &str = inline_colorization::color_bright_black;
        let v80: &str = &*v6;
        let v99: &str = inline_colorization::color_reset;
        let v101: std::string::String = format!("{}{}{}", v73, v80, v99);
        fable_library_rust::String_::fromString(v101)
    }
    pub fn method40(
        v0_1: LrcPtr<Runtime::Mut0>,
        v1_1: LrcPtr<Runtime::Mut1>,
        v2_1: LrcPtr<Runtime::Mut2>,
        v3: LrcPtr<Runtime::Mut3>,
        v4: LrcPtr<Runtime::Mut4>,
        v5: Option<i64>,
        v6: string,
        v7: string,
        v8: string,
    ) -> string {
        let v9: string = Runtime::method15();
        Runtime::method16(sprintf!(
            "{} {} #{} {} / {}",
            v6,
            v7,
            v0_1.l0.get().clone(),
            v8,
            v9
        ))
    }
    pub fn closure21(v0_1: string, unitVar: ()) {
        if Runtime::method5(Runtime::US0::US0_0) {
            let v5: () = {
                Runtime::closure0((), ());
                ()
            };
            let patternInput: (
                LrcPtr<Runtime::Mut0>,
                LrcPtr<Runtime::Mut1>,
                LrcPtr<Runtime::Mut2>,
                LrcPtr<Runtime::Mut3>,
                LrcPtr<Runtime::Mut4>,
                Option<i64>,
            ) = getValue(Runtime::TraceState::trace_state().get().clone());
            let v24: Option<i64> = patternInput.5.clone();
            let v23: LrcPtr<Runtime::Mut4> = patternInput.4.clone();
            let v22: LrcPtr<Runtime::Mut3> = patternInput.3.clone();
            let v21: LrcPtr<Runtime::Mut2> = patternInput.2.clone();
            let v20_1: LrcPtr<Runtime::Mut1> = patternInput.1.clone();
            let v19_1: LrcPtr<Runtime::Mut0> = patternInput.0.clone();
            Runtime::method17(if v0_1.clone() == string("") {
                string("")
            } else {
                Runtime::method40(
                    v19_1.clone(),
                    v20_1.clone(),
                    v21.clone(),
                    v22.clone(),
                    v23.clone(),
                    v24.clone(),
                    Runtime::method6(v19_1, v20_1, v21, v22, v23, v24),
                    Runtime::method39(),
                    v0_1,
                )
            })
        };
    }
    pub fn closure19(
        v0_1: string,
        v1_1: Option<CancellationToken>,
        v2_1: Array<(string, string)>,
        v3: Option<Func1<(i32, string, bool), Arc<Async<()>>>>,
        v4: Option<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
        v5: bool,
        v6: Option<string>,
        v7: (),
        v8: LrcPtr<ConcurrentStack_1<string>>,
        v9: (),
    ) {
        let v17_1: Arc<Async<()>> = defaultOf();
        defaultOf::<()>();
        ();
        ()
    }
    pub fn closure22(
        v0_1: string,
        v1_1: Option<CancellationToken>,
        v2_1: Array<(string, string)>,
        v3: Option<Func1<(i32, string, bool), Arc<Async<()>>>>,
        v4: Option<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
        v5: bool,
        v6: Option<string>,
        v7: (),
        v8: LrcPtr<ConcurrentStack_1<string>>,
        v9: (),
    ) {
        let v17_1: Arc<Async<()>> = defaultOf();
        defaultOf::<()>();
        ();
        ()
    }
    pub fn closure23(unitVar: (), v0_1: CancellationToken) -> Runtime::US15 {
        Runtime::US15::US15_0(v0_1)
    }
    pub fn method41() -> Func1<CancellationToken, Runtime::US15> {
        Func1::new(move |v: CancellationToken| Runtime::closure23((), v))
    }
    pub fn closure24(v0_1: (), unitVar: ()) {
        if unbox::<bool>(&defaultOf()) == false {
            ();
            ()
        };
    }
    pub fn method43(v0_1: LrcPtr<TaskCanceledException>) -> string {
        let v2_1: LrcPtr<Runtime::Mut3> = LrcPtr::new(Runtime::Mut3 {
            l0: MutCell::new(Runtime::method12()),
        });
        let v9: () = {
            Runtime::closure7(v2_1.clone(), sprintf!("{}", string("{ ")), ());
            ()
        };
        let v18_1: () = {
            Runtime::closure7(v2_1.clone(), sprintf!("{}", string("ex")), ());
            ()
        };
        let v27: () = {
            Runtime::closure7(v2_1.clone(), sprintf!("{}", string(" = ")), ());
            ()
        };
        let v40: std::string::String = format!("{:#?}", v0_1);
        let v65: () = {
            Runtime::closure7(
                v2_1.clone(),
                sprintf!("{}", fable_library_rust::String_::fromString(v40)),
                (),
            );
            ()
        };
        let v74: () = {
            Runtime::closure7(v2_1.clone(), sprintf!("{}", string(" }")), ());
            ()
        };
        v2_1.l0.get().clone()
    }
    pub fn method42(
        v0_1: LrcPtr<Runtime::Mut0>,
        v1_1: LrcPtr<Runtime::Mut1>,
        v2_1: LrcPtr<Runtime::Mut2>,
        v3: LrcPtr<Runtime::Mut3>,
        v4: LrcPtr<Runtime::Mut4>,
        v5: Option<i64>,
        v6: string,
        v7: string,
        v8: LrcPtr<TaskCanceledException>,
    ) -> string {
        let v9: string = Runtime::method43(v8);
        Runtime::method16(sprintf!(
            "{} {} #{} {} / {}",
            v6,
            v7,
            v0_1.l0.get().clone(),
            string("runtime.execute_with_options_async / WaitForExitAsync"),
            v9
        ))
    }
    pub fn closure25(v0_1: LrcPtr<TaskCanceledException>, unitVar: ()) {
        if Runtime::method5(Runtime::US0::US0_3) {
            let v5: () = {
                Runtime::closure0((), ());
                ()
            };
            let patternInput: (
                LrcPtr<Runtime::Mut0>,
                LrcPtr<Runtime::Mut1>,
                LrcPtr<Runtime::Mut2>,
                LrcPtr<Runtime::Mut3>,
                LrcPtr<Runtime::Mut4>,
                Option<i64>,
            ) = getValue(Runtime::TraceState::trace_state().get().clone());
            let v24: Option<i64> = patternInput.5.clone();
            let v23: LrcPtr<Runtime::Mut4> = patternInput.4.clone();
            let v22: LrcPtr<Runtime::Mut3> = patternInput.3.clone();
            let v21: LrcPtr<Runtime::Mut2> = patternInput.2.clone();
            let v20_1: LrcPtr<Runtime::Mut1> = patternInput.1.clone();
            let v19_1: LrcPtr<Runtime::Mut0> = patternInput.0.clone();
            Runtime::method17(Runtime::method42(
                v19_1.clone(),
                v20_1.clone(),
                v21.clone(),
                v22.clone(),
                v23.clone(),
                v24.clone(),
                Runtime::method6(v19_1, v20_1, v21, v22, v23, v24),
                Runtime::method10(),
                v0_1,
            ))
        };
    }
    pub fn method44() -> string {
        string("\n")
    }
    pub fn method46(v0_1: i32, v1_1: i32) -> string {
        let v3: LrcPtr<Runtime::Mut3> = LrcPtr::new(Runtime::Mut3 {
            l0: MutCell::new(Runtime::method12()),
        });
        let v10: () = {
            Runtime::closure7(v3.clone(), sprintf!("{}", string("{ ")), ());
            ()
        };
        let v19_1: () = {
            Runtime::closure7(v3.clone(), sprintf!("{}", string("exit_code")), ());
            ()
        };
        let v28: () = {
            Runtime::closure7(v3.clone(), sprintf!("{}", string(" = ")), ());
            ()
        };
        let v36: () = {
            Runtime::closure7(v3.clone(), sprintf!("{}", v0_1), ());
            ()
        };
        let v45: () = {
            Runtime::closure7(v3.clone(), sprintf!("{}", string("; ")), ());
            ()
        };
        let v54: () = {
            Runtime::closure7(v3.clone(), sprintf!("{}", string("output_length")), ());
            ()
        };
        let v62: () = {
            Runtime::closure7(v3.clone(), sprintf!("{}", string(" = ")), ());
            ()
        };
        let v70: () = {
            Runtime::closure7(v3.clone(), sprintf!("{}", v1_1), ());
            ()
        };
        let v79: () = {
            Runtime::closure7(v3.clone(), sprintf!("{}", string(" }")), ());
            ()
        };
        v3.l0.get().clone()
    }
    pub fn method45(
        v0_1: LrcPtr<Runtime::Mut0>,
        v1_1: LrcPtr<Runtime::Mut1>,
        v2_1: LrcPtr<Runtime::Mut2>,
        v3: LrcPtr<Runtime::Mut3>,
        v4: LrcPtr<Runtime::Mut4>,
        v5: Option<i64>,
        v6: string,
        v7: string,
        v8: i32,
        v9: i32,
    ) -> string {
        let v10: string = Runtime::method46(v8, v9);
        Runtime::method16(sprintf!(
            "{} {} #{} {} / {}",
            v6,
            v7,
            v0_1.l0.get().clone(),
            string("runtime.execute_with_options_async"),
            v10
        ))
    }
    pub fn closure26(v0_1: i32, v1_1: string, unitVar: ()) {
        if Runtime::method5(Runtime::US0::US0_1) {
            let v6: () = {
                Runtime::closure0((), ());
                ()
            };
            let patternInput: (
                LrcPtr<Runtime::Mut0>,
                LrcPtr<Runtime::Mut1>,
                LrcPtr<Runtime::Mut2>,
                LrcPtr<Runtime::Mut3>,
                LrcPtr<Runtime::Mut4>,
                Option<i64>,
            ) = getValue(Runtime::TraceState::trace_state().get().clone());
            let v25: Option<i64> = patternInput.5.clone();
            let v24: LrcPtr<Runtime::Mut4> = patternInput.4.clone();
            let v23: LrcPtr<Runtime::Mut3> = patternInput.3.clone();
            let v22: LrcPtr<Runtime::Mut2> = patternInput.2.clone();
            let v21: LrcPtr<Runtime::Mut1> = patternInput.1.clone();
            let v20_1: LrcPtr<Runtime::Mut0> = patternInput.0.clone();
            Runtime::method17(Runtime::method45(
                v20_1.clone(),
                v21.clone(),
                v22.clone(),
                v23.clone(),
                v24.clone(),
                v25.clone(),
                Runtime::method6(v20_1, v21, v22, v23, v24, v25),
                Runtime::method34(),
                v0_1,
                length(v1_1),
            ))
        };
    }
    pub fn method20(
        v0_1: string,
        v1_1: Option<CancellationToken>,
        v2_1: Array<(string, string)>,
        v3: Option<Func1<(i32, string, bool), Arc<Async<()>>>>,
        v4: Option<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
        v5: bool,
        v6: Option<string>,
    ) -> Arc<Async<(i32, string)>> {
        defaultOf()
    }
    pub fn closure13(unitVar: (), v0_1: string) -> Arc<Async<(i32, string)>> {
        Runtime::method20(
            v0_1,
            None::<CancellationToken>,
            new_empty::<(string, string)>(),
            None::<Func1<(i32, string, bool), Arc<Async<()>>>>,
            None::<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
            true,
            None::<string>,
        )
    }
    pub fn closure27(
        unitVar: (),
        _arg: (
            string,
            Option<CancellationToken>,
            Array<(string, string)>,
            Option<Func1<(i32, string, bool), Arc<Async<()>>>>,
            Option<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
            bool,
            Option<string>,
        ),
    ) -> Arc<Async<(i32, string)>> {
        Runtime::method20(
            _arg.0.clone(),
            _arg.1.clone(),
            _arg.2.clone(),
            _arg.3.clone(),
            _arg.4.clone(),
            _arg.5.clone(),
            _arg.6.clone(),
        )
    }
    pub fn closure28(
        unitVar: (),
        v0_1: Func1<LrcPtr<Runtime::Heap0>, LrcPtr<Runtime::Heap0>>,
    ) -> (
        string,
        Option<CancellationToken>,
        Array<(string, string)>,
        Option<Func1<(i32, string, bool), Arc<Async<()>>>>,
        Option<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
        bool,
        Option<string>,
    ) {
        let v8: LrcPtr<Runtime::Heap0> = v0_1(LrcPtr::new(Runtime::Heap0 {
            l0: string(""),
            l1: None::<CancellationToken>,
            l2: new_empty::<(string, string)>(),
            l3: None::<Func1<(i32, string, bool), Arc<Async<()>>>>,
            l4: None::<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
            l5: true,
            l6: None::<string>,
        }));
        (
            v8.l0.clone(),
            v8.l1.clone(),
            v8.l2.clone(),
            v8.l3.clone(),
            v8.l4.clone(),
            v8.l5,
            v8.l6.clone(),
        )
    }
    pub fn method49(v0_1: char, v1_1: i64) -> bool {
        let v0_1: MutCell<char> = MutCell::new(v0_1);
        let v1_1: MutCell<i64> = MutCell::new(v1_1);
        '_method49: loop {
            break '_method49 (if v1_1.get().clone() >= 4_i64 {
                false
            } else {
                let v19_1: Runtime::US9 = if v1_1.get().clone() == 0_i64 {
                    Runtime::US9::US9_0('\\')
                } else {
                    let v5: i64 = v1_1.get().clone() - 1_i64;
                    if v5 == 0_i64 {
                        Runtime::US9::US9_0('`')
                    } else {
                        let v8: i64 = v5 - 1_i64;
                        if v8 == 0_i64 {
                            Runtime::US9::US9_0('\"')
                        } else {
                            let v11: i64 = v8 - 1_i64;
                            if v11 == 0_i64 {
                                Runtime::US9::US9_0(' ')
                            } else {
                                let v14: i64 = v11 - 1_i64;
                                Runtime::US9::US9_1
                            }
                        }
                    }
                };
                if v0_1.get().clone()
                    == match &v19_1 {
                        Runtime::US9::US9_0(v19_1_0_0) => match &v19_1 {
                            Runtime::US9::US9_0(x) => x.clone(),
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
                    continue '_method49;
                }
            });
        }
    }
    pub fn method50(
        v0_1: string,
        v1_1: string,
        v2_1: LrcPtr<StringBuilder>,
        v3: i32,
        v4: i32,
    ) -> (string, string, LrcPtr<StringBuilder>, i32, i32) {
        let v0_1: MutCell<string> = MutCell::new(v0_1.clone());
        let v1_1: MutCell<string> = MutCell::new(v1_1.clone());
        let v2_1: MutCell<LrcPtr<StringBuilder>> = MutCell::new(v2_1.clone());
        let v3: MutCell<i32> = MutCell::new(v3);
        let v4: MutCell<i32> = MutCell::new(v4);
        '_method50: loop {
            break '_method50 ({
                let v121: Runtime::US7 = if string("") == v1_1.get().clone() {
                    Runtime::US7::US7_1(sprintf!(
                        "parsing.none_of / unexpected end of input / chars: {:?} / s: {:?}",
                        toArray(ofArray(new_array(&['\\', '`', '\"', ' ']))),
                        (v2_1.get().clone(), v3.get().clone(), v4.get().clone())
                    ))
                } else {
                    let v27: char = getCharAt(v1_1.get().clone(), 0_i32);
                    if Runtime::method49(v27, 0_i64) == false {
                        let v50: string = getSlice(
                            v1_1.get().clone(),
                            Some(1_i32),
                            Some(length(v1_1.get().clone()) - 1_i32),
                        );
                        let v55: string = ofChar(v27);
                        let v58: i32 = length(v55.clone());
                        let v59: Array<char> = new_init(&'\u{0000}', v58);
                        let v60: LrcPtr<Runtime::Mut5> = LrcPtr::new(Runtime::Mut5 {
                            l0: MutCell::new(0_i32),
                        });
                        while Runtime::method23(v58, v60.clone()) {
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
                            let patternInput: (LrcPtr<StringBuilder>, i32, i32) = Runtime::method25(
                                foldBack(
                                    Func2::new(move |b0: char, b1: LrcPtr<Runtime::UH0>| {
                                        (Runtime::method24())(b0)(b1)
                                    }),
                                    v65,
                                    LrcPtr::new(Runtime::UH0::UH0_0),
                                ),
                                v2_1.get().clone(),
                                v3.get().clone(),
                                v4.get().clone(),
                            );
                            Runtime::US7::US7_0(
                                v27,
                                v50,
                                patternInput.0.clone(),
                                patternInput.1.clone(),
                                patternInput.2.clone(),
                            )
                        }
                    } else {
                        Runtime::US7::US7_1(sprintf!(
                            "parsing.none_of / unexpected char: \'{}\' / chars: {:?} / s: {:?}",
                            v27,
                            toArray(ofArray(new_array(&['\\', '`', '\"', ' ']))),
                            (v2_1.get().clone(), v3.get().clone(), v4.get().clone())
                        ))
                    }
                };
                match &v121 {
                    Runtime::US7::US7_0(v121_0_0, v121_0_1, v121_0_2, v121_0_3, v121_0_4) => {
                        let v0_1_temp: string =
                            append(v0_1.get().clone(), ofChar(v121_0_0.clone()));
                        let v1_1_temp: string = v121_0_1.clone();
                        let v2_1_temp: LrcPtr<StringBuilder> = v121_0_2.clone();
                        let v3_temp: i32 = v121_0_3.clone();
                        let v4_temp: i32 = v121_0_4.clone();
                        v0_1.set(v0_1_temp);
                        v1_1.set(v1_1_temp);
                        v2_1.set(v2_1_temp);
                        v3.set(v3_temp);
                        v4.set(v4_temp);
                        continue '_method50;
                    }
                    _ => (
                        v0_1.get().clone(),
                        v1_1.get().clone(),
                        v2_1.get().clone(),
                        v3.get().clone(),
                        v4.get().clone(),
                    ),
                }
            });
        }
    }
    pub fn method52(v0_1: char, v1_1: i64) -> bool {
        let v0_1: MutCell<char> = MutCell::new(v0_1);
        let v1_1: MutCell<i64> = MutCell::new(v1_1);
        '_method52: loop {
            break '_method52 (if v1_1.get().clone() >= 3_i64 {
                false
            } else {
                let v15: Runtime::US9 = if v1_1.get().clone() == 0_i64 {
                    Runtime::US9::US9_0('\\')
                } else {
                    let v5: i64 = v1_1.get().clone() - 1_i64;
                    if v5 == 0_i64 {
                        Runtime::US9::US9_0('`')
                    } else {
                        let v8: i64 = v5 - 1_i64;
                        if v8 == 0_i64 {
                            Runtime::US9::US9_0('\"')
                        } else {
                            let v11: i64 = v8 - 1_i64;
                            Runtime::US9::US9_1
                        }
                    }
                };
                if v0_1.get().clone()
                    == match &v15 {
                        Runtime::US9::US9_0(v15_0_0) => match &v15 {
                            Runtime::US9::US9_0(x) => x.clone(),
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
                    continue '_method52;
                }
            });
        }
    }
    pub fn closure30(unitVar: (), _arg: (string, LrcPtr<StringBuilder>, i32, i32)) -> Runtime::US8 {
        let v3: i32 = _arg.3.clone();
        let v2_1: i32 = _arg.2.clone();
        let v1_1: LrcPtr<StringBuilder> = _arg.1.clone();
        let v0_1: string = _arg.0.clone();
        let v128: Runtime::US7 = if string("") == v0_1.clone() {
            Runtime::US7::US7_1(sprintf!(
                "parsing.p_char / unexpected end of input / c: \'{}\' / s: {:?}",
                '\\',
                (v1_1.clone(), v2_1, v3)
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
                let v40: LrcPtr<Runtime::Mut5> = LrcPtr::new(Runtime::Mut5 {
                    l0: MutCell::new(0_i32),
                });
                while Runtime::method23(v38, v40.clone()) {
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
                    let patternInput: (LrcPtr<StringBuilder>, i32, i32) = Runtime::method25(
                        foldBack(
                            Func2::new(move |b0: char, b1: LrcPtr<Runtime::UH0>| {
                                (Runtime::method24())(b0)(b1)
                            }),
                            v45,
                            LrcPtr::new(Runtime::UH0::UH0_0),
                        ),
                        v1_1.clone(),
                        v2_1,
                        v3,
                    );
                    Runtime::US7::US7_0(
                        v9,
                        v30,
                        patternInput.0.clone(),
                        patternInput.1.clone(),
                        patternInput.2.clone(),
                    )
                }
            } else {
                let v83: i32 = indexOf(v0_1.clone(), string("\n")) - 1_i32;
                Runtime::US7::US7_1(sprintf!(
                    "{}\n{}\n",
                    sprintf!(
                        "parsing.p_char / expected: \'{}\' / line: {} / col: {}\n{}{}",
                        '\\',
                        v2_1,
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
        let v212: Runtime::US7 = match &v128 {
            Runtime::US7::US7_0(v128_0_0, v128_0_1, v128_0_2, v128_0_3, v128_0_4) => {
                let v133: i32 = v128_0_4.clone();
                let v132: i32 = v128_0_3.clone();
                let v131: LrcPtr<StringBuilder> = v128_0_2.clone();
                let v130: string = v128_0_1.clone();
                if string("") == v130.clone() {
                    Runtime::US7::US7_1(sprintf!(
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
                    let v169: LrcPtr<Runtime::Mut5> = LrcPtr::new(Runtime::Mut5 {
                        l0: MutCell::new(0_i32),
                    });
                    while Runtime::method23(v167, v169.clone()) {
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
                        let patternInput_1: (LrcPtr<StringBuilder>, i32, i32) = Runtime::method25(
                            foldBack(
                                Func2::new(move |b0: char, b1: LrcPtr<Runtime::UH0>| {
                                    (Runtime::method24())(b0)(b1)
                                }),
                                v174,
                                LrcPtr::new(Runtime::UH0::UH0_0),
                            ),
                            v131,
                            v132,
                            v133,
                        );
                        Runtime::US7::US7_0(
                            v139,
                            v159,
                            patternInput_1.0.clone(),
                            patternInput_1.1.clone(),
                            patternInput_1.2.clone(),
                        )
                    }
                }
            }
            Runtime::US7::US7_1(v128_1_0) => Runtime::US7::US7_1(v128_1_0.clone()),
        };
        match &v212 {
            Runtime::US7::US7_0(v212_0_0, v212_0_1, v212_0_2, v212_0_3, v212_0_4) => {
                Runtime::US8::US8_0(
                    append(ofChar('\\'), ofChar(v212_0_0.clone())),
                    v212_0_1.clone(),
                    v212_0_2.clone(),
                    v212_0_3.clone(),
                    v212_0_4.clone(),
                )
            }
            Runtime::US7::US7_1(v212_1_0) => Runtime::US8::US8_1(v212_1_0.clone()),
        }
    }
    pub fn closure31(unitVar: (), _arg: (string, LrcPtr<StringBuilder>, i32, i32)) -> Runtime::US8 {
        let v3: i32 = _arg.3.clone();
        let v2_1: i32 = _arg.2.clone();
        let v1_1: LrcPtr<StringBuilder> = _arg.1.clone();
        let v0_1: string = _arg.0.clone();
        let v128: Runtime::US7 = if string("") == v0_1.clone() {
            Runtime::US7::US7_1(sprintf!(
                "parsing.p_char / unexpected end of input / c: \'{}\' / s: {:?}",
                '`',
                (v1_1.clone(), v2_1, v3)
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
                let v40: LrcPtr<Runtime::Mut5> = LrcPtr::new(Runtime::Mut5 {
                    l0: MutCell::new(0_i32),
                });
                while Runtime::method23(v38, v40.clone()) {
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
                    let patternInput: (LrcPtr<StringBuilder>, i32, i32) = Runtime::method25(
                        foldBack(
                            Func2::new(move |b0: char, b1: LrcPtr<Runtime::UH0>| {
                                (Runtime::method24())(b0)(b1)
                            }),
                            v45,
                            LrcPtr::new(Runtime::UH0::UH0_0),
                        ),
                        v1_1.clone(),
                        v2_1,
                        v3,
                    );
                    Runtime::US7::US7_0(
                        v9,
                        v30,
                        patternInput.0.clone(),
                        patternInput.1.clone(),
                        patternInput.2.clone(),
                    )
                }
            } else {
                let v83: i32 = indexOf(v0_1.clone(), string("\n")) - 1_i32;
                Runtime::US7::US7_1(sprintf!(
                    "{}\n{}\n",
                    sprintf!(
                        "parsing.p_char / expected: \'{}\' / line: {} / col: {}\n{}{}",
                        '`',
                        v2_1,
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
        let v212: Runtime::US7 = match &v128 {
            Runtime::US7::US7_0(v128_0_0, v128_0_1, v128_0_2, v128_0_3, v128_0_4) => {
                let v133: i32 = v128_0_4.clone();
                let v132: i32 = v128_0_3.clone();
                let v131: LrcPtr<StringBuilder> = v128_0_2.clone();
                let v130: string = v128_0_1.clone();
                if string("") == v130.clone() {
                    Runtime::US7::US7_1(sprintf!(
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
                    let v169: LrcPtr<Runtime::Mut5> = LrcPtr::new(Runtime::Mut5 {
                        l0: MutCell::new(0_i32),
                    });
                    while Runtime::method23(v167, v169.clone()) {
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
                        let patternInput_1: (LrcPtr<StringBuilder>, i32, i32) = Runtime::method25(
                            foldBack(
                                Func2::new(move |b0: char, b1: LrcPtr<Runtime::UH0>| {
                                    (Runtime::method24())(b0)(b1)
                                }),
                                v174,
                                LrcPtr::new(Runtime::UH0::UH0_0),
                            ),
                            v131,
                            v132,
                            v133,
                        );
                        Runtime::US7::US7_0(
                            v139,
                            v159,
                            patternInput_1.0.clone(),
                            patternInput_1.1.clone(),
                            patternInput_1.2.clone(),
                        )
                    }
                }
            }
            Runtime::US7::US7_1(v128_1_0) => Runtime::US7::US7_1(v128_1_0.clone()),
        };
        match &v212 {
            Runtime::US7::US7_0(v212_0_0, v212_0_1, v212_0_2, v212_0_3, v212_0_4) => {
                Runtime::US8::US8_0(
                    append(ofChar('`'), ofChar(v212_0_0.clone())),
                    v212_0_1.clone(),
                    v212_0_2.clone(),
                    v212_0_3.clone(),
                    v212_0_4.clone(),
                )
            }
            Runtime::US7::US7_1(v212_1_0) => Runtime::US8::US8_1(v212_1_0.clone()),
        }
    }
    pub fn method53(
        v0_1: string,
        v1_1: LrcPtr<StringBuilder>,
        v2_1: i32,
        v3: i32,
        v4: LrcPtr<Runtime::UH3>,
    ) -> Runtime::US8 {
        let v0_1: MutCell<string> = MutCell::new(v0_1.clone());
        let v1_1: MutCell<LrcPtr<StringBuilder>> = MutCell::new(v1_1.clone());
        let v2_1: MutCell<i32> = MutCell::new(v2_1);
        let v3: MutCell<i32> = MutCell::new(v3);
        let v4: MutCell<LrcPtr<Runtime::UH3>> = MutCell::new(v4.clone());
        '_method53: loop {
            break '_method53 (match v4.get().clone().as_ref() {
                Runtime::UH3::UH3_0 => {
                    Runtime::US8::US8_1(string("parsing.choice / no parsers succeeded"))
                }
                Runtime::UH3::UH3_1(v4_1_0, v4_1_1) => {
                    let v9: Runtime::US8 = (match v4.get().clone().as_ref() {
                        Runtime::UH3::UH3_1(x, _) => x.clone(),
                        _ => unreachable!(),
                    })((
                        v0_1.get().clone(),
                        v1_1.get().clone(),
                        v2_1.get().clone(),
                        v3.get().clone(),
                    ));
                    match &v9 {
                        Runtime::US8::US8_0(v9_0_0, v9_0_1, v9_0_2, v9_0_3, v9_0_4) => v9.clone(),
                        _ => {
                            let v0_1_temp: string = v0_1.get().clone();
                            let v1_1_temp: LrcPtr<StringBuilder> = v1_1.get().clone();
                            let v2_1_temp: i32 = v2_1.get().clone();
                            let v3_temp: i32 = v3.get().clone();
                            let v4_temp: LrcPtr<Runtime::UH3> = match v4.get().clone().as_ref() {
                                Runtime::UH3::UH3_1(_, x) => x.clone(),
                                _ => unreachable!(),
                            };
                            v0_1.set(v0_1_temp);
                            v1_1.set(v1_1_temp);
                            v2_1.set(v2_1_temp);
                            v3.set(v3_temp);
                            v4.set(v4_temp);
                            continue '_method53;
                        }
                    }
                }
            });
        }
    }
    pub fn method54(
        v0_1: LrcPtr<Runtime::UH2>,
        v1_1: LrcPtr<Runtime::UH2>,
    ) -> LrcPtr<Runtime::UH2> {
        let v0_1: MutCell<LrcPtr<Runtime::UH2>> = MutCell::new(v0_1.clone());
        let v1_1: MutCell<LrcPtr<Runtime::UH2>> = MutCell::new(v1_1.clone());
        '_method54: loop {
            break '_method54 (match v0_1.get().clone().as_ref() {
                Runtime::UH2::UH2_0 => v1_1.get().clone(),
                Runtime::UH2::UH2_1(v0_1_1_0, v0_1_1_1) => {
                    let v0_1_temp: LrcPtr<Runtime::UH2> = match v0_1.get().clone().as_ref() {
                        Runtime::UH2::UH2_1(_, x) => x.clone(),
                        _ => unreachable!(),
                    };
                    let v1_1_temp: LrcPtr<Runtime::UH2> = LrcPtr::new(Runtime::UH2::UH2_1(
                        match v0_1.get().clone().as_ref() {
                            Runtime::UH2::UH2_1(x, _) => x.clone(),
                            _ => unreachable!(),
                        },
                        v1_1.get().clone(),
                    ));
                    v0_1.set(v0_1_temp);
                    v1_1.set(v1_1_temp);
                    continue '_method54;
                }
            });
        }
    }
    pub fn method51(
        v0_1: LrcPtr<Runtime::UH2>,
        v1_1: string,
        v2_1: LrcPtr<StringBuilder>,
        v3: i32,
        v4: i32,
    ) -> Runtime::US17 {
        let v0_1: MutCell<LrcPtr<Runtime::UH2>> = MutCell::new(v0_1.clone());
        let v1_1: MutCell<string> = MutCell::new(v1_1.clone());
        let v2_1: MutCell<LrcPtr<StringBuilder>> = MutCell::new(v2_1.clone());
        let v3: MutCell<i32> = MutCell::new(v3);
        let v4: MutCell<i32> = MutCell::new(v4);
        '_method51: loop {
            break '_method51 ({
                let v115: Runtime::US7 = if string("") == v1_1.get().clone() {
                    Runtime::US7::US7_1(sprintf!(
                        "parsing.none_of / unexpected end of input / chars: {:?} / s: {:?}",
                        toArray(ofArray(new_array(&['\\', '`', '\"']))),
                        (v2_1.get().clone(), v3.get().clone(), v4.get().clone())
                    ))
                } else {
                    let v24: char = getCharAt(v1_1.get().clone(), 0_i32);
                    if Runtime::method52(v24, 0_i64) == false {
                        let v47: string = getSlice(
                            v1_1.get().clone(),
                            Some(1_i32),
                            Some(length(v1_1.get().clone()) - 1_i32),
                        );
                        let v52: string = ofChar(v24);
                        let v55: i32 = length(v52.clone());
                        let v56: Array<char> = new_init(&'\u{0000}', v55);
                        let v57: LrcPtr<Runtime::Mut5> = LrcPtr::new(Runtime::Mut5 {
                            l0: MutCell::new(0_i32),
                        });
                        while Runtime::method23(v55, v57.clone()) {
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
                            let patternInput: (LrcPtr<StringBuilder>, i32, i32) = Runtime::method25(
                                foldBack(
                                    Func2::new(move |b0: char, b1: LrcPtr<Runtime::UH0>| {
                                        (Runtime::method24())(b0)(b1)
                                    }),
                                    v62,
                                    LrcPtr::new(Runtime::UH0::UH0_0),
                                ),
                                v2_1.get().clone(),
                                v3.get().clone(),
                                v4.get().clone(),
                            );
                            Runtime::US7::US7_0(
                                v24,
                                v47,
                                patternInput.0.clone(),
                                patternInput.1.clone(),
                                patternInput.2.clone(),
                            )
                        }
                    } else {
                        Runtime::US7::US7_1(sprintf!(
                            "parsing.none_of / unexpected char: \'{}\' / chars: {:?} / s: {:?}",
                            v24,
                            toArray(ofArray(new_array(&['\\', '`', '\"']))),
                            (v2_1.get().clone(), v3.get().clone(), v4.get().clone())
                        ))
                    }
                };
                let v129: Runtime::US8 = match &v115 {
                    Runtime::US7::US7_0(v115_0_0, v115_0_1, v115_0_2, v115_0_3, v115_0_4) => {
                        Runtime::US8::US8_0(
                            ofChar(v115_0_0.clone()),
                            v115_0_1.clone(),
                            v115_0_2.clone(),
                            v115_0_3.clone(),
                            v115_0_4.clone(),
                        )
                    }
                    Runtime::US7::US7_1(v115_1_0) => Runtime::US8::US8_1(v115_1_0.clone()),
                };
                let v143: Runtime::US8 = match &v129 {
                    Runtime::US8::US8_0(v129_0_0, v129_0_1, v129_0_2, v129_0_3, v129_0_4) => {
                        v129.clone()
                    }
                    _ => Runtime::method53(
                        v1_1.get().clone(),
                        v2_1.get().clone(),
                        v3.get().clone(),
                        v4.get().clone(),
                        LrcPtr::new(Runtime::UH3::UH3_1(
                            Func1::new(
                                move |arg10_0040: (string, LrcPtr<StringBuilder>, i32, i32)| {
                                    Runtime::closure30((), arg10_0040)
                                },
                            ),
                            LrcPtr::new(Runtime::UH3::UH3_1(
                                Func1::new(
                                    move |arg10_0040_1: (
                                        string,
                                        LrcPtr<StringBuilder>,
                                        i32,
                                        i32,
                                    )| {
                                        Runtime::closure31((), arg10_0040_1)
                                    },
                                ),
                                LrcPtr::new(Runtime::UH3::UH3_0),
                            )),
                        )),
                    ),
                };
                match &v143 {
                    Runtime::US8::US8_0(v143_0_0, v143_0_1, v143_0_2, v143_0_3, v143_0_4) => {
                        let v0_1_temp: LrcPtr<Runtime::UH2> =
                            LrcPtr::new(Runtime::UH2::UH2_1(v143_0_0.clone(), v0_1.get().clone()));
                        let v1_1_temp: string = v143_0_1.clone();
                        let v2_1_temp: LrcPtr<StringBuilder> = v143_0_2.clone();
                        let v3_temp: i32 = v143_0_3.clone();
                        let v4_temp: i32 = v143_0_4.clone();
                        v0_1.set(v0_1_temp);
                        v1_1.set(v1_1_temp);
                        v2_1.set(v2_1_temp);
                        v3.set(v3_temp);
                        v4.set(v4_temp);
                        continue '_method51;
                    }
                    _ => Runtime::US17::US17_0(
                        Runtime::method54(v0_1.get().clone(), LrcPtr::new(Runtime::UH2::UH2_0)),
                        v1_1.get().clone(),
                        v2_1.get().clone(),
                        v3.get().clone(),
                        v4.get().clone(),
                    ),
                }
            });
        }
    }
    pub fn method55(v0_1: LrcPtr<Runtime::UH2>, v1_1: List<string>) -> List<string> {
        match v0_1.as_ref() {
            Runtime::UH2::UH2_0 => v1_1.clone(),
            Runtime::UH2::UH2_1(v0_1_1_0, v0_1_1_1) => cons(
                match v0_1.as_ref() {
                    Runtime::UH2::UH2_1(x, _) => x.clone(),
                    _ => unreachable!(),
                },
                Runtime::method55(
                    match v0_1.as_ref() {
                        Runtime::UH2::UH2_1(_, x) => x.clone(),
                        _ => unreachable!(),
                    },
                    v1_1.clone(),
                ),
            ),
        }
    }
    pub fn method56(
        v0_1: LrcPtr<Runtime::UH2>,
        v1_1: string,
        v2_1: LrcPtr<StringBuilder>,
        v3: i32,
        v4: i32,
    ) -> Runtime::US17 {
        let v0_1: MutCell<LrcPtr<Runtime::UH2>> = MutCell::new(v0_1.clone());
        let v1_1: MutCell<string> = MutCell::new(v1_1.clone());
        let v2_1: MutCell<LrcPtr<StringBuilder>> = MutCell::new(v2_1.clone());
        let v3: MutCell<i32> = MutCell::new(v3);
        let v4: MutCell<i32> = MutCell::new(v4);
        '_method56: loop {
            break '_method56 ({
                let v115: Runtime::US7 = if string("") == v1_1.get().clone() {
                    Runtime::US7::US7_1(sprintf!(
                        "parsing.none_of / unexpected end of input / chars: {:?} / s: {:?}",
                        toArray(ofArray(new_array(&['\\', '`', '\"']))),
                        (v2_1.get().clone(), v3.get().clone(), v4.get().clone())
                    ))
                } else {
                    let v24: char = getCharAt(v1_1.get().clone(), 0_i32);
                    if Runtime::method52(v24, 0_i64) == false {
                        let v47: string = getSlice(
                            v1_1.get().clone(),
                            Some(1_i32),
                            Some(length(v1_1.get().clone()) - 1_i32),
                        );
                        let v52: string = ofChar(v24);
                        let v55: i32 = length(v52.clone());
                        let v56: Array<char> = new_init(&'\u{0000}', v55);
                        let v57: LrcPtr<Runtime::Mut5> = LrcPtr::new(Runtime::Mut5 {
                            l0: MutCell::new(0_i32),
                        });
                        while Runtime::method23(v55, v57.clone()) {
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
                            let patternInput: (LrcPtr<StringBuilder>, i32, i32) = Runtime::method25(
                                foldBack(
                                    Func2::new(move |b0: char, b1: LrcPtr<Runtime::UH0>| {
                                        (Runtime::method24())(b0)(b1)
                                    }),
                                    v62,
                                    LrcPtr::new(Runtime::UH0::UH0_0),
                                ),
                                v2_1.get().clone(),
                                v3.get().clone(),
                                v4.get().clone(),
                            );
                            Runtime::US7::US7_0(
                                v24,
                                v47,
                                patternInput.0.clone(),
                                patternInput.1.clone(),
                                patternInput.2.clone(),
                            )
                        }
                    } else {
                        Runtime::US7::US7_1(sprintf!(
                            "parsing.none_of / unexpected char: \'{}\' / chars: {:?} / s: {:?}",
                            v24,
                            toArray(ofArray(new_array(&['\\', '`', '\"']))),
                            (v2_1.get().clone(), v3.get().clone(), v4.get().clone())
                        ))
                    }
                };
                let v129: Runtime::US8 = match &v115 {
                    Runtime::US7::US7_0(v115_0_0, v115_0_1, v115_0_2, v115_0_3, v115_0_4) => {
                        Runtime::US8::US8_0(
                            ofChar(v115_0_0.clone()),
                            v115_0_1.clone(),
                            v115_0_2.clone(),
                            v115_0_3.clone(),
                            v115_0_4.clone(),
                        )
                    }
                    Runtime::US7::US7_1(v115_1_0) => Runtime::US8::US8_1(v115_1_0.clone()),
                };
                match &v129 {
                    Runtime::US8::US8_0(v129_0_0, v129_0_1, v129_0_2, v129_0_3, v129_0_4) => {
                        let v0_1_temp: LrcPtr<Runtime::UH2> =
                            LrcPtr::new(Runtime::UH2::UH2_1(v129_0_0.clone(), v0_1.get().clone()));
                        let v1_1_temp: string = v129_0_1.clone();
                        let v2_1_temp: LrcPtr<StringBuilder> = v129_0_2.clone();
                        let v3_temp: i32 = v129_0_3.clone();
                        let v4_temp: i32 = v129_0_4.clone();
                        v0_1.set(v0_1_temp);
                        v1_1.set(v1_1_temp);
                        v2_1.set(v2_1_temp);
                        v3.set(v3_temp);
                        v4.set(v4_temp);
                        continue '_method56;
                    }
                    _ => Runtime::US17::US17_0(
                        Runtime::method54(v0_1.get().clone(), LrcPtr::new(Runtime::UH2::UH2_0)),
                        v1_1.get().clone(),
                        v2_1.get().clone(),
                        v3.get().clone(),
                        v4.get().clone(),
                    ),
                }
            });
        }
    }
    pub fn method48(
        v0_1: LrcPtr<Runtime::UH2>,
        v1_1: string,
        v2_1: LrcPtr<StringBuilder>,
        v3: i32,
        v4: i32,
    ) -> Runtime::US17 {
        let v0_1: MutCell<LrcPtr<Runtime::UH2>> = MutCell::new(v0_1.clone());
        let v1_1: MutCell<string> = MutCell::new(v1_1.clone());
        let v2_1: MutCell<LrcPtr<StringBuilder>> = MutCell::new(v2_1.clone());
        let v3: MutCell<i32> = MutCell::new(v3);
        let v4: MutCell<i32> = MutCell::new(v4);
        '_method48: loop {
            break '_method48 ({
                let v5: bool = string("") == v1_1.get().clone();
                let v121: Runtime::US7 = if v5 {
                    Runtime::US7::US7_1(sprintf!(
                        "parsing.none_of / unexpected end of input / chars: {:?} / s: {:?}",
                        toArray(ofArray(new_array(&['\\', '`', '\"', ' ']))),
                        (v2_1.get().clone(), v3.get().clone(), v4.get().clone())
                    ))
                } else {
                    let v27: char = getCharAt(v1_1.get().clone(), 0_i32);
                    if Runtime::method49(v27, 0_i64) == false {
                        let v50: string = getSlice(
                            v1_1.get().clone(),
                            Some(1_i32),
                            Some(length(v1_1.get().clone()) - 1_i32),
                        );
                        let v55: string = ofChar(v27);
                        let v58: i32 = length(v55.clone());
                        let v59: Array<char> = new_init(&'\u{0000}', v58);
                        let v60: LrcPtr<Runtime::Mut5> = LrcPtr::new(Runtime::Mut5 {
                            l0: MutCell::new(0_i32),
                        });
                        while Runtime::method23(v58, v60.clone()) {
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
                            let patternInput: (LrcPtr<StringBuilder>, i32, i32) = Runtime::method25(
                                foldBack(
                                    Func2::new(move |b0: char, b1: LrcPtr<Runtime::UH0>| {
                                        (Runtime::method24())(b0)(b1)
                                    }),
                                    v65,
                                    LrcPtr::new(Runtime::UH0::UH0_0),
                                ),
                                v2_1.get().clone(),
                                v3.get().clone(),
                                v4.get().clone(),
                            );
                            Runtime::US7::US7_0(
                                v27,
                                v50,
                                patternInput.0.clone(),
                                patternInput.1.clone(),
                                patternInput.2.clone(),
                            )
                        }
                    } else {
                        Runtime::US7::US7_1(sprintf!(
                            "parsing.none_of / unexpected char: \'{}\' / chars: {:?} / s: {:?}",
                            v27,
                            toArray(ofArray(new_array(&['\\', '`', '\"', ' ']))),
                            (v2_1.get().clone(), v3.get().clone(), v4.get().clone())
                        ))
                    }
                };
                let v140: Runtime::US8 = match &v121 {
                    Runtime::US7::US7_0(v121_0_0, v121_0_1, v121_0_2, v121_0_3, v121_0_4) => {
                        let patternInput_1: (string, string, LrcPtr<StringBuilder>, i32, i32) =
                            Runtime::method50(
                                ofChar(v121_0_0.clone()),
                                v121_0_1.clone(),
                                v121_0_2.clone(),
                                v121_0_3.clone(),
                                v121_0_4.clone(),
                            );
                        Runtime::US8::US8_0(
                            patternInput_1.0.clone(),
                            patternInput_1.1.clone(),
                            patternInput_1.2.clone(),
                            patternInput_1.3.clone(),
                            patternInput_1.4.clone(),
                        )
                    }
                    Runtime::US7::US7_1(v121_1_0) => Runtime::US8::US8_1(v121_1_0.clone()),
                };
                let v517: Runtime::US8 = match &v140 {
                    Runtime::US8::US8_0(v140_0_0, v140_0_1, v140_0_2, v140_0_3, v140_0_4) => {
                        v140.clone()
                    }
                    _ => {
                        let v270: Runtime::US7 = if v5 {
                            Runtime::US7::US7_1(sprintf!(
                                "parsing.p_char / unexpected end of input / c: \'{}\' / s: {:?}",
                                '\"',
                                (v2_1.get().clone(), v3.get().clone(), v4.get().clone())
                            ))
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
                                let v182: LrcPtr<Runtime::Mut5> = LrcPtr::new(Runtime::Mut5 {
                                    l0: MutCell::new(0_i32),
                                });
                                while Runtime::method23(v180, v182.clone()) {
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
                                    let patternInput_2: (LrcPtr<StringBuilder>, i32, i32) =
                                        Runtime::method25(
                                            foldBack(
                                                Func2::new(
                                                    move |b0: char, b1: LrcPtr<Runtime::UH0>| {
                                                        (Runtime::method24())(b0)(b1)
                                                    },
                                                ),
                                                v187,
                                                LrcPtr::new(Runtime::UH0::UH0_0),
                                            ),
                                            v2_1.get().clone(),
                                            v3.get().clone(),
                                            v4.get().clone(),
                                        );
                                    Runtime::US7::US7_0(
                                        v151,
                                        v172,
                                        patternInput_2.0.clone(),
                                        patternInput_2.1.clone(),
                                        patternInput_2.2.clone(),
                                    )
                                }
                            } else {
                                let v225: i32 = indexOf(v1_1.get().clone(), string("\n")) - 1_i32;
                                Runtime::US7::US7_1(sprintf!("{}\n{}\n",
                                                                              sprintf!("parsing.p_char / expected: \'{}\' / line: {} / col: {}\n{}{}",
                                                                                       '\"',
                                                                                       v3.get().clone(),
                                                                                       v4.get().clone(),
                                                                                       v2_1.get().clone(),
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
                        let v454: Runtime::US8 = match &v270 {
                            Runtime::US7::US7_0(
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
                                let v277: Runtime::US17 = Runtime::method51(
                                    LrcPtr::new(Runtime::UH2::UH2_0),
                                    v272.clone(),
                                    v273.clone(),
                                    v274,
                                    v275,
                                );
                                let v302: Runtime::US8 = match &v277 {
                                    Runtime::US17::US17_0(
                                        v277_0_0,
                                        v277_0_1,
                                        v277_0_2,
                                        v277_0_3,
                                        v277_0_4,
                                    ) => {
                                        let v284: List<string> =
                                            Runtime::method55(v277_0_0.clone(), empty::<string>());
                                        Runtime::US8::US8_0(
                                            join(
                                                string(""),
                                                toArray_1(delay(Func0::new({
                                                    let v284 = v284.clone();
                                                    move || {
                                                        map_1(
                                                            Func1::new({
                                                                let v284 = v284.clone();
                                                                move |i: i32| item(i, v284.clone())
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
                                    Runtime::US17::US17_1(v277_1_0) => {
                                        Runtime::US8::US8_1(v277_1_0.clone())
                                    }
                                };
                                match &v302 {
                                    Runtime::US8::US8_0(
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
                                        let v432: Runtime::US7 = if string("") == v304.clone() {
                                            Runtime::US7::US7_1(sprintf!("parsing.p_char / unexpected end of input / c: \'{}\' / s: {:?}",
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
                                                let v343: Array<char> = new_init(&'\u{0000}', v342);
                                                let v344: LrcPtr<Runtime::Mut5> =
                                                    LrcPtr::new(Runtime::Mut5 {
                                                        l0: MutCell::new(0_i32),
                                                    });
                                                while Runtime::method23(v342, v344.clone()) {
                                                    let v346: i32 = v344.l0.get().clone();
                                                    let v347: char = getCharAt(v339.clone(), v346);
                                                    v343.get_mut()[v346 as usize] = v347;
                                                    {
                                                        let v348: i32 = v346 + 1_i32;
                                                        v344.l0.set(v348);
                                                        ()
                                                    }
                                                }
                                                {
                                                    let v349: List<char> = ofArray(v343.clone());
                                                    let patternInput_3:
                                                                                 (LrcPtr<StringBuilder>,
                                                                                  i32,
                                                                                  i32) =
                                                                             Runtime::method25(foldBack(Func2::new(move
                                                                                                                       |b0:
                                                                                                                            char,
                                                                                                                        b1:
                                                                                                                            LrcPtr<Runtime::UH0>|
                                                                                                                       (Runtime::method24())(b0)(b1)),
                                                                                                        v349,
                                                                                                        LrcPtr::new(Runtime::UH0::UH0_0)),
                                                                                               v305.clone(),
                                                                                               v306,
                                                                                               v307);
                                                    Runtime::US7::US7_0(
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
                                                Runtime::US7::US7_1(sprintf!("{}\n{}\n",
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
                                                             Runtime::US7::US7_0(v432_0_0,
                                                                                 v432_0_1,
                                                                                 v432_0_2,
                                                                                 v432_0_3,
                                                                                 v432_0_4)
                                                             =>
                                                             Runtime::US8::US8_0(v302_0_0.clone(),
                                                                                 v432_0_1.clone(),
                                                                                 v432_0_2.clone(),
                                                                                 v432_0_3.clone(),
                                                                                 v432_0_4.clone()),
                                                             Runtime::US7::US7_1(v432_1_0)
                                                             =>
                                                             Runtime::US8::US8_1(sprintf!("parsing.between / expected closing delimiter / e: {:?} / input: {:?} / rest1: {:?} / rest2: {:?}",
                                                                                          v432_1_0.clone(),
                                                                                          (v1_1.get().clone(),
                                                                                           v2_1.get().clone(),
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
                                    _ => Runtime::US8::US8_1(string(
                                        "parsing.between / expected content",
                                    )),
                                }
                            }
                            Runtime::US7::US7_1(v270_1_0) => Runtime::US8::US8_1(v270_1_0.clone()),
                        };
                        match &v454 {
                            Runtime::US8::US8_0(
                                v454_0_0,
                                v454_0_1,
                                v454_0_2,
                                v454_0_3,
                                v454_0_4,
                            ) => v454.clone(),
                            _ => {
                                let v466: Runtime::US8 = Runtime::method53(
                                    v1_1.get().clone(),
                                    v2_1.get().clone(),
                                    v3.get().clone(),
                                    v4.get().clone(),
                                    LrcPtr::new(Runtime::UH3::UH3_1(
                                        Func1::new(
                                            move |arg10_0040: (
                                                string,
                                                LrcPtr<StringBuilder>,
                                                i32,
                                                i32,
                                            )| {
                                                Runtime::closure30((), arg10_0040)
                                            },
                                        ),
                                        LrcPtr::new(Runtime::UH3::UH3_1(
                                            Func1::new(
                                                move |arg10_0040_1: (
                                                    string,
                                                    LrcPtr<StringBuilder>,
                                                    i32,
                                                    i32,
                                                )| {
                                                    Runtime::closure31((), arg10_0040_1)
                                                },
                                            ),
                                            LrcPtr::new(Runtime::UH3::UH3_0),
                                        )),
                                    )),
                                );
                                let v477: Runtime::US8 = match &v466 {
                                    Runtime::US8::US8_0(
                                        v466_0_0,
                                        v466_0_1,
                                        v466_0_2,
                                        v466_0_3,
                                        v466_0_4,
                                    ) => Runtime::US8::US8_0(
                                        string(""),
                                        v466_0_1.clone(),
                                        v466_0_2.clone(),
                                        v466_0_3.clone(),
                                        v466_0_4.clone(),
                                    ),
                                    Runtime::US8::US8_1(v466_1_0) => {
                                        Runtime::US8::US8_1(v466_1_0.clone())
                                    }
                                };
                                let v488: Runtime::US17 = match &v477 {
                                    Runtime::US8::US8_0(
                                        v477_0_0,
                                        v477_0_1,
                                        v477_0_2,
                                        v477_0_3,
                                        v477_0_4,
                                    ) => Runtime::method56(
                                        LrcPtr::new(Runtime::UH2::UH2_0),
                                        v477_0_1.clone(),
                                        v477_0_2.clone(),
                                        v477_0_3.clone(),
                                        v477_0_4.clone(),
                                    ),
                                    Runtime::US8::US8_1(v477_1_0) => {
                                        Runtime::US17::US17_1(v477_1_0.clone())
                                    }
                                };
                                match &v488 {
                                    Runtime::US17::US17_0(
                                        v488_0_0,
                                        v488_0_1,
                                        v488_0_2,
                                        v488_0_3,
                                        v488_0_4,
                                    ) => {
                                        let v495: List<string> =
                                            Runtime::method55(v488_0_0.clone(), empty::<string>());
                                        Runtime::US8::US8_0(
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
                                    Runtime::US17::US17_1(v488_1_0) => {
                                        Runtime::US8::US8_1(v488_1_0.clone())
                                    }
                                }
                            }
                        }
                    }
                };
                match &v517 {
                    Runtime::US8::US8_0(v517_0_0, v517_0_1, v517_0_2, v517_0_3, v517_0_4) => {
                        let v522: i32 = v517_0_4.clone();
                        let v521: i32 = v517_0_3.clone();
                        let v520: LrcPtr<StringBuilder> = v517_0_2.clone();
                        let v519: string = v517_0_1.clone();
                        let v518: string = v517_0_0.clone();
                        let v524: i32 = Runtime::method32(v519.clone(), 0_i32);
                        let v552: Runtime::US10 = if 0_i32 == v524 {
                            Runtime::US10::US10_1(string(
                                "parsing.spaces1 / expected at least one space",
                            ))
                        } else {
                            Runtime::US10::US10_0(
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
                            Runtime::US10::US10_0(v552_0_0, v552_0_1, v552_0_2, v552_0_3) => {
                                let v0_1_temp: LrcPtr<Runtime::UH2> = LrcPtr::new(
                                    Runtime::UH2::UH2_1(v518.clone(), v0_1.get().clone()),
                                );
                                let v1_1_temp: string = v552_0_0.clone();
                                let v2_1_temp: LrcPtr<StringBuilder> = v552_0_1.clone();
                                let v3_temp: i32 = v552_0_2.clone();
                                let v4_temp: i32 = v552_0_3.clone();
                                v0_1.set(v0_1_temp);
                                v1_1.set(v1_1_temp);
                                v2_1.set(v2_1_temp);
                                v3.set(v3_temp);
                                v4.set(v4_temp);
                                continue '_method48;
                            }
                            _ => Runtime::US17::US17_0(
                                Runtime::method54(
                                    v0_1.get().clone(),
                                    LrcPtr::new(Runtime::UH2::UH2_1(
                                        v518.clone(),
                                        LrcPtr::new(Runtime::UH2::UH2_0),
                                    )),
                                ),
                                v519,
                                v520,
                                v521,
                                v522,
                            ),
                        }
                    }
                    _ => Runtime::US17::US17_0(
                        Runtime::method54(v0_1.get().clone(), LrcPtr::new(Runtime::UH2::UH2_0)),
                        v1_1.get().clone(),
                        v2_1.get().clone(),
                        v3.get().clone(),
                        v4.get().clone(),
                    ),
                }
            });
        }
    }
    pub fn method47(v0_1: string) -> Runtime::US16 {
        let _v0: MutCell<Option<Option<string>>> = MutCell::new(None::<Option<string>>);
        _v0.set(Some(Some(v0_1)));
        {
            let v18_1: Runtime::US17 = Runtime::method48(
                LrcPtr::new(Runtime::UH2::UH2_0),
                defaultValue(
                    string(""),
                    match &_v0.get().clone() {
                        None => panic!("{}", string("optionm\'.of_obj / _v0=None"),),
                        Some(_v0_0_0) => _v0_0_0.clone(),
                    },
                ),
                StringBuilder::_ctor__Z721C83C5(Runtime::method22()),
                1_i32,
                1_i32,
            );
            match &v18_1 {
                Runtime::US17::US17_0(v18_1_0_0, v18_1_0_1, v18_1_0_2, v18_1_0_3, v18_1_0_4) => {
                    Runtime::US16::US16_0(toArray(Runtime::method55(
                        v18_1_0_0.clone(),
                        empty::<string>(),
                    )))
                }
                Runtime::US17::US17_1(v18_1_1_0) => Runtime::US16::US16_1(v18_1_1_0.clone()),
            }
        }
    }
    pub fn closure29(unitVar: (), v0_1: string) -> Result<Array<string>, string> {
        let v1_1: Runtime::US16 = Runtime::method47(v0_1);
        match &v1_1 {
            Runtime::US16::US16_0(v1_1_0_0) => Ok::<Array<string>, string>(v1_1_0_0.clone()),
            Runtime::US16::US16_1(v1_1_1_0) => Err::<Array<string>, string>(v1_1_1_0.clone()),
        }
    }
    pub fn v0() -> () {
        static v0: OnceInit<()> = OnceInit::new();
        v0.get_or_init(|| ()).clone()
    }
    pub fn v1() -> Func0<()> {
        static v1: OnceInit<Func0<()>> = OnceInit::new();
        v1.get_or_init(|| Func0::new(move || Runtime::closure0((), ())))
            .clone()
    }
    pub fn v2() -> () {
        static v2: OnceInit<()> = OnceInit::new();
        v2.get_or_init(|| {
            (Runtime::v1())();
            Runtime::v0()
        })
        .clone()
    }
    pub fn v16() -> Func0<()> {
        static v16: OnceInit<Func0<()>> = OnceInit::new();
        v16.get_or_init(|| Func0::new(move || Runtime::closure3((), ())))
            .clone()
    }
    pub fn current_process_kill() {
        (Runtime::v16())();
    }
    pub fn v17() -> Func1<string, Arc<Async<(i32, string)>>> {
        static v17: OnceInit<Func1<string, Arc<Async<(i32, string)>>>> = OnceInit::new();
        v17.get_or_init(|| Func1::new(move |v: string| Runtime::closure13((), v)))
            .clone()
    }
    pub fn execute_async(x: string) -> Arc<Async<(i32, string)>> {
        (Runtime::v17())(x)
    }
    pub fn v18() -> Func1<
        (
            string,
            Option<CancellationToken>,
            Array<(string, string)>,
            Option<Func1<(i32, string, bool), Arc<Async<()>>>>,
            Option<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
            bool,
            Option<string>,
        ),
        Arc<Async<(i32, string)>>,
    > {
        static v18: OnceInit<
            Func1<
                (
                    string,
                    Option<CancellationToken>,
                    Array<(string, string)>,
                    Option<Func1<(i32, string, bool), Arc<Async<()>>>>,
                    Option<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
                    bool,
                    Option<string>,
                ),
                Arc<Async<(i32, string)>>,
            >,
        > = OnceInit::new();
        v18.get_or_init(|| {
            Func1::new(
                move |arg10_0040: (
                    string,
                    Option<CancellationToken>,
                    Array<(string, string)>,
                    Option<Func1<(i32, string, bool), Arc<Async<()>>>>,
                    Option<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
                    bool,
                    Option<string>,
                )| Runtime::closure27((), arg10_0040),
            )
        })
        .clone()
    }
    pub fn execute_with_options_async(
        x: (
            string,
            Option<CancellationToken>,
            Array<(string, string)>,
            Option<Func1<(i32, string, bool), Arc<Async<()>>>>,
            Option<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
            bool,
            Option<string>,
        ),
    ) -> Arc<Async<(i32, string)>> {
        (Runtime::v18())(x)
    }
    pub fn v19() -> Func1<
        Func1<LrcPtr<Runtime::Heap0>, LrcPtr<Runtime::Heap0>>,
        (
            string,
            Option<CancellationToken>,
            Array<(string, string)>,
            Option<Func1<(i32, string, bool), Arc<Async<()>>>>,
            Option<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
            bool,
            Option<string>,
        ),
    > {
        static v19: OnceInit<
            Func1<
                Func1<LrcPtr<Runtime::Heap0>, LrcPtr<Runtime::Heap0>>,
                (
                    string,
                    Option<CancellationToken>,
                    Array<(string, string)>,
                    Option<Func1<(i32, string, bool), Arc<Async<()>>>>,
                    Option<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
                    bool,
                    Option<string>,
                ),
            >,
        > = OnceInit::new();
        v19.get_or_init(|| {
            Func1::new(
                move |v: Func1<LrcPtr<Runtime::Heap0>, LrcPtr<Runtime::Heap0>>| {
                    Runtime::closure28((), v)
                },
            )
        })
        .clone()
    }
    pub fn execution_options(
        x: Func1<LrcPtr<Runtime::Heap0>, LrcPtr<Runtime::Heap0>>,
    ) -> (
        string,
        Option<CancellationToken>,
        Array<(string, string)>,
        Option<Func1<(i32, string, bool), Arc<Async<()>>>>,
        Option<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
        bool,
        Option<string>,
    ) {
        (Runtime::v19())(x)
    }
    pub fn v20() -> Func1<string, Result<Array<string>, string>> {
        static v20: OnceInit<Func1<string, Result<Array<string>, string>>> = OnceInit::new();
        v20.get_or_init(|| Func1::new(move |v: string| Runtime::closure29((), v)))
            .clone()
    }
    pub fn split_args(x: string) -> Result<Array<string>, string> {
        (Runtime::v20())(x)
    }
    on_startup!(());
}
