pub mod Runtime {
    use super::*;
    use fable_library_rust::Async_::Async;
    use fable_library_rust::DateTime_::DateTime;
    use fable_library_rust::List_::cons;
    use fable_library_rust::List_::empty;
    use fable_library_rust::List_::foldBack;
    use fable_library_rust::List_::ofArray;
    use fable_library_rust::List_::toArray;
    use fable_library_rust::List_::List;
    use fable_library_rust::Map_::find;
    use fable_library_rust::Map_::ofSeq;
    use fable_library_rust::NativeArray_::new_array;
    use fable_library_rust::NativeArray_::new_empty;
    use fable_library_rust::NativeArray_::new_init;
    use fable_library_rust::NativeArray_::Array;
    use fable_library_rust::Native_::getZero;
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
    use fable_library_rust::Option_::map;
    use fable_library_rust::Seq_::delay;
    use fable_library_rust::Seq_::ofList;
    use fable_library_rust::Seq_::toArray as toArray_1;
    use fable_library_rust::String_::append;
    use fable_library_rust::String_::concat;
    use fable_library_rust::String_::getCharAt;
    use fable_library_rust::String_::getSlice;
    use fable_library_rust::String_::indexOf;
    use fable_library_rust::String_::join;
    use fable_library_rust::String_::length;
    use fable_library_rust::String_::ofChar;
    use fable_library_rust::String_::printfn;
    use fable_library_rust::String_::sprintf;
    use fable_library_rust::String_::string;
    use fable_library_rust::String_::toLower;
    use fable_library_rust::String_::trimEndChars;
    use fable_library_rust::String_::trimStartChars;
    use fable_library_rust::TimeSpan_::TimeSpan;
    type ConcurrentStack_1<T> = T;
    use fable_library_rust::System::Collections::Generic::IEnumerable_1;
    use fable_library_rust::System::Text::StringBuilder;
    use fable_library_rust::System::Threading::CancellationToken;
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
    pub trait IOsEnviron: core::fmt::Debug + core::fmt::Display {
        fn environ(&self) -> LrcPtr<dyn Any>;
    }
    impl<V: IOsEnviron + core::fmt::Debug + core::fmt::Display> IOsEnviron for LrcPtr<V> {
        #[inline]
        fn environ(&self) -> LrcPtr<dyn Any> {
            (**self).environ()
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
        pub l0: MutCell<Runtime::US0>,
    }
    impl core::fmt::Display for Mut4 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
    pub enum US1 {
        US1_0(Runtime::US0),
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
        US4_0(Runtime::US3),
        US4_1(Runtime::US3),
        US4_2(Runtime::US3),
        US4_3(Runtime::US3),
        US4_4(Runtime::US3),
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
    #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
    pub enum US6 {
        US6_0(string, Runtime::US5),
        US6_1(string),
    }
    impl core::fmt::Display for US6 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Debug)]
    pub enum US7 {
        US7_0(char, string, LrcPtr<StringBuilder>, i32, i32),
        US7_1(string),
    }
    impl core::fmt::Display for US7 {
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
        UH0_1(char, LrcPtr<Runtime::UH0>),
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
            Func1<(string, LrcPtr<StringBuilder>, i32, i32), Runtime::US7>,
            LrcPtr<Runtime::UH1>,
        ),
    }
    impl core::fmt::Display for UH1 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Debug)]
    pub enum US8 {
        US8_0(string, string, LrcPtr<StringBuilder>, i32, i32),
        US8_1(string),
    }
    impl core::fmt::Display for US8 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
    pub enum US9 {
        US9_0(char),
        US9_1,
    }
    impl core::fmt::Display for US9 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Debug)]
    pub enum US10 {
        US10_0(string, LrcPtr<StringBuilder>, i32, i32),
        US10_1(string),
    }
    impl core::fmt::Display for US10 {
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
    impl core::fmt::Display for US11 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Debug)]
    pub enum US12 {
        US12_0(Runtime::US9, string, LrcPtr<StringBuilder>, i32, i32),
        US12_1(string),
    }
    impl core::fmt::Display for US12 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Debug)]
    pub enum US13 {
        US13_0(Runtime::US5, string, LrcPtr<StringBuilder>, i32, i32),
        US13_1(string),
    }
    impl core::fmt::Display for US13 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Debug)]
    pub enum US14 {
        US14_0(Func1<(i32, string, bool), Arc<Async<()>>>),
        US14_1,
    }
    impl core::fmt::Display for US14 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
    pub enum US15 {
        US15_0(CancellationToken),
        US15_1,
    }
    impl core::fmt::Display for US15 {
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
    impl core::fmt::Display for Heap0 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
    pub enum US16 {
        US16_0(Array<string>),
        US16_1(string),
    }
    impl core::fmt::Display for US16 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
    pub enum UH2 {
        UH2_0,
        UH2_1(string, LrcPtr<Runtime::UH2>),
    }
    impl core::fmt::Display for UH2 {
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
    impl core::fmt::Display for US17 {
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
    impl core::fmt::Display for UH3 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    pub fn method3(v0_1: string) -> string {
        v0_1
    }
    pub fn method4() -> string {
        string("")
    }
    pub fn closure1(unitVar: (), v0_1: string) -> Runtime::US5 {
        Runtime::US5::US5_0(v0_1)
    }
    pub fn method5() -> Func1<string, Runtime::US5> {
        Func1::new(move |v: string| Runtime::closure1((), v))
    }
    pub fn method2(v0_1: string) -> string {
        panic!(
            "{}",
            sprintf!(
                "env.get_environment_variable / target: {} / var: {}",
                Runtime::US4::US4_2(Runtime::US3::US3_1),
                v0_1
            ),
        )
    }
    pub fn method1() -> (Runtime::US1, Runtime::US2) {
        let v1_1: string = Runtime::method2(string("TRACE_LEVEL"));
        let v6: Runtime::US1 = if string("Verbose") == (v1_1.clone()) {
            Runtime::US1::US1_0(Runtime::US0::US0_0)
        } else {
            Runtime::US1::US1_1
        };
        (
            match &v6 {
                Runtime::US1::US1_0(v6_0_0) => Runtime::US1::US1_0(
                    match &v6 {
                        Runtime::US1::US1_0(x) => x.clone(),
                        _ => unreachable!(),
                    }
                    .clone(),
                ),
                _ => {
                    let v13: Runtime::US1 = if string("Debug") == (v1_1.clone()) {
                        Runtime::US1::US1_0(Runtime::US0::US0_1)
                    } else {
                        Runtime::US1::US1_1
                    };
                    match &v13 {
                        Runtime::US1::US1_0(v13_0_0) => Runtime::US1::US1_0(
                            match &v13 {
                                Runtime::US1::US1_0(x) => x.clone(),
                                _ => unreachable!(),
                            }
                            .clone(),
                        ),
                        _ => {
                            let v20_1: Runtime::US1 = if string("Info") == (v1_1.clone()) {
                                Runtime::US1::US1_0(Runtime::US0::US0_2)
                            } else {
                                Runtime::US1::US1_1
                            };
                            match &v20_1 {
                                Runtime::US1::US1_0(v20_1_0_0) => Runtime::US1::US1_0(
                                    match &v20_1 {
                                        Runtime::US1::US1_0(x) => x.clone(),
                                        _ => unreachable!(),
                                    }
                                    .clone(),
                                ),
                                _ => {
                                    let v27: Runtime::US1 = if string("Warning") == (v1_1.clone()) {
                                        Runtime::US1::US1_0(Runtime::US0::US0_3)
                                    } else {
                                        Runtime::US1::US1_1
                                    };
                                    match &v27 {
                                        Runtime::US1::US1_0(v27_0_0) => Runtime::US1::US1_0(
                                            match &v27 {
                                                Runtime::US1::US1_0(x) => x.clone(),
                                                _ => unreachable!(),
                                            }
                                            .clone(),
                                        ),
                                        _ => {
                                            let v34: Runtime::US1 =
                                                if string("Critical") == (v1_1.clone()) {
                                                    Runtime::US1::US1_0(Runtime::US0::US0_4)
                                                } else {
                                                    Runtime::US1::US1_1
                                                };
                                            match &v34 {
                                                Runtime::US1::US1_0(v34_0_0) => {
                                                    Runtime::US1::US1_0(
                                                        match &v34 {
                                                            Runtime::US1::US1_0(x) => x.clone(),
                                                            _ => unreachable!(),
                                                        }
                                                        .clone(),
                                                    )
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
            if (Runtime::method2(string("AUTOMATION"))) != string("True") {
                Runtime::US2::US2_1
            } else {
                Runtime::US2::US2_0({
                    let _arg: DateTime = DateTime::now();
                    _arg.ticks()
                })
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
        let _run_target_args__v1: (Runtime::US1, Runtime::US2) =
            (Runtime::US1::US1_1, Runtime::US2::US2_1);
        let v132: Runtime::US2 = _run_target_args__v1.1.clone();
        let v131: Runtime::US1 = _run_target_args__v1.0.clone();
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
                    }
                    .clone(),
                    _ => v0_1.clone(),
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
    pub fn method7(v0_1: Runtime::US0) -> bool {
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
        ) = Runtime::TraceState::trace_state().get().clone().unwrap();
        let v35: Runtime::US0 = (patternInput.4.clone()).l0.get().clone();
        if ((patternInput.2.clone()).l0.get().clone()) == false {
            false
        } else {
            (find(
                v0_1,
                ofSeq(ofList(ofArray(new_array(&[
                    LrcPtr::new((Runtime::US0::US0_0, 0_i32)),
                    LrcPtr::new((Runtime::US0::US0_1, 1_i32)),
                    LrcPtr::new((Runtime::US0::US0_2, 2_i32)),
                    LrcPtr::new((Runtime::US0::US0_3, 3_i32)),
                    LrcPtr::new((Runtime::US0::US0_4, 4_i32)),
                ])))),
            )) >= (find(
                v35,
                ofSeq(ofList(ofArray(new_array(&[
                    LrcPtr::new((Runtime::US0::US0_0, 0_i32)),
                    LrcPtr::new((Runtime::US0::US0_1, 1_i32)),
                    LrcPtr::new((Runtime::US0::US0_2, 2_i32)),
                    LrcPtr::new((Runtime::US0::US0_3, 3_i32)),
                    LrcPtr::new((Runtime::US0::US0_4, 4_i32)),
                ])))),
            ))
        }
    }
    pub fn closure6(unitVar: (), v0_1: i64) -> Runtime::US2 {
        Runtime::US2::US2_0(v0_1)
    }
    pub fn method9() -> Func1<i64, Runtime::US2> {
        Func1::new(move |v: i64| Runtime::closure6((), v))
    }
    pub fn method10() -> string {
        string("hh:mm:ss")
    }
    pub fn method11() -> string {
        string("HH:mm:ss")
    }
    pub fn method8(
        v0_1: LrcPtr<Runtime::Mut0>,
        v1_1: LrcPtr<Runtime::Mut1>,
        v2_1: LrcPtr<Runtime::Mut2>,
        v3: LrcPtr<Runtime::Mut3>,
        v4: LrcPtr<Runtime::Mut4>,
        v5: Option<i64>,
    ) -> string {
        let v152: Runtime::US2 = defaultValue(Runtime::US2::US2_1, map(Runtime::method9(), v5));
        let v249: DateTime = match &v152 {
            Runtime::US2::US2_0(v152_0_0) => {
                let v209: TimeSpan = TimeSpan::new_ticks(
                    ({
                        let _arg: DateTime = DateTime::now();
                        _arg.ticks()
                    }) - (match &v152 {
                        Runtime::US2::US2_0(x) => x.clone(),
                        _ => unreachable!(),
                    }),
                );
                DateTime::new_ymdhms_milli(
                    1_i32,
                    1_i32,
                    1_i32,
                    v209.hours(),
                    v209.minutes(),
                    v209.seconds(),
                    v209.milliseconds(),
                )
            }
            _ => DateTime::now(),
        };
        let v250: string = Runtime::method10();
        let provider: string = if (v250.clone()) == string("") {
            string("M-d-y hh:mm:ss tt")
        } else {
            v250
        };
        v249.toString(provider)
    }
    pub fn method14() -> string {
        string("")
    }
    pub fn closure7(v0_1: LrcPtr<Runtime::Mut3>, v1_1: string, unitVar: ()) {
        let v3: string = append((v0_1.l0.get().clone()), (v1_1));
        v0_1.l0.set(v3);
        ()
    }
    pub fn method13(v0_1: char) -> string {
        let v2_1: LrcPtr<Runtime::Mut3> = LrcPtr::new(Runtime::Mut3 {
            l0: MutCell::new(Runtime::method14()),
        });
        let v8: () = {
            Runtime::closure7(v2_1.clone(), sprintf!("{}", v0_1), ());
            ()
        };
        v2_1.l0.get().clone()
    }
    pub fn method15() -> string {
        string("\u{001b}[0m")
    }
    pub fn method12() -> string {
        let v6: string = Runtime::method13(getCharAt(toLower(string("Warning")), 0_i32));
        let v41: &str = inline_colorization::color_yellow;
        let v46: &str = &*v6;
        let v67: &str = inline_colorization::color_reset;
        let v69: std::string::String = format!("{}{}{}", v41, v46, v67);
        fable_library_rust::String_::fromString(v69)
    }
    pub fn method17() -> string {
        let v1_1: LrcPtr<Runtime::Mut3> = LrcPtr::new(Runtime::Mut3 {
            l0: MutCell::new(Runtime::method14()),
        });
        v1_1.l0.get().clone()
    }
    pub fn method18(v0_1: string) -> string {
        trimEndChars(
            trimStartChars(v0_1, toArray(empty::<char>())),
            toArray(ofArray(new_array(&[' ', '/']))),
        )
    }
    pub fn method16(
        v0_1: LrcPtr<Runtime::Mut0>,
        v1_1: LrcPtr<Runtime::Mut1>,
        v2_1: LrcPtr<Runtime::Mut2>,
        v3: LrcPtr<Runtime::Mut3>,
        v4: LrcPtr<Runtime::Mut4>,
        v5: Option<i64>,
        v6: string,
        v7: string,
    ) -> string {
        let v8: string = Runtime::method17();
        Runtime::method18(sprintf!(
            "{} {} #{} {} / {}",
            v6,
            v7,
            v0_1.l0.get().clone(),
            string("runtime.current_process_kill / exiting... 3"),
            v8
        ))
    }
    pub fn closure8(v0_1: LrcPtr<Runtime::Mut0>, unitVar: ()) {
        let v2_1: i64 = (v0_1.l0.get().clone()) + 1_i64;
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
    pub fn method19(v0_1: string) {
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
        ) = Runtime::TraceState::trace_state().get().clone().unwrap();
        let v37: () = {
            Runtime::closure8(patternInput.0.clone(), ());
            ()
        };
        println!("{}", v0_1.clone());
        ((patternInput.1.clone()).l0.get().clone())(v0_1)
    }
    pub fn closure5(unitVar: (), unitVar_1: ()) {
        if Runtime::method7(Runtime::US0::US0_3) {
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
            ) = Runtime::TraceState::trace_state().get().clone().unwrap();
            let v23: Option<i64> = patternInput.5.clone();
            let v22: LrcPtr<Runtime::Mut4> = patternInput.4.clone();
            let v21: LrcPtr<Runtime::Mut3> = patternInput.3.clone();
            let v20_1: LrcPtr<Runtime::Mut2> = patternInput.2.clone();
            let v19_1: LrcPtr<Runtime::Mut1> = patternInput.1.clone();
            let v18_1: LrcPtr<Runtime::Mut0> = patternInput.0.clone();
            Runtime::method19(Runtime::method16(
                v18_1.clone(),
                v19_1.clone(),
                v20_1.clone(),
                v21.clone(),
                v22.clone(),
                v23.clone(),
                Runtime::method8(v18_1, v19_1, v20_1, v21, v22, v23),
                Runtime::method12(),
            ))
        };
    }
    pub fn method20(
        v0_1: LrcPtr<Runtime::Mut0>,
        v1_1: LrcPtr<Runtime::Mut1>,
        v2_1: LrcPtr<Runtime::Mut2>,
        v3: LrcPtr<Runtime::Mut3>,
        v4: LrcPtr<Runtime::Mut4>,
        v5: Option<i64>,
        v6: string,
        v7: string,
    ) -> string {
        let v8: string = Runtime::method17();
        Runtime::method18(sprintf!(
            "{} {} #{} {} / {}",
            v6,
            v7,
            v0_1.l0.get().clone(),
            string("runtime.current_process_kill / exiting... 2"),
            v8
        ))
    }
    pub fn closure11(unitVar: (), unitVar_1: ()) {
        if Runtime::method7(Runtime::US0::US0_3) {
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
            ) = Runtime::TraceState::trace_state().get().clone().unwrap();
            let v23: Option<i64> = patternInput.5.clone();
            let v22: LrcPtr<Runtime::Mut4> = patternInput.4.clone();
            let v21: LrcPtr<Runtime::Mut3> = patternInput.3.clone();
            let v20_1: LrcPtr<Runtime::Mut2> = patternInput.2.clone();
            let v19_1: LrcPtr<Runtime::Mut1> = patternInput.1.clone();
            let v18_1: LrcPtr<Runtime::Mut0> = patternInput.0.clone();
            Runtime::method19(Runtime::method20(
                v18_1.clone(),
                v19_1.clone(),
                v20_1.clone(),
                v21.clone(),
                v22.clone(),
                v23.clone(),
                Runtime::method8(v18_1, v19_1, v20_1, v21, v22, v23),
                Runtime::method12(),
            ))
        };
    }
    pub fn method21(
        v0_1: LrcPtr<Runtime::Mut0>,
        v1_1: LrcPtr<Runtime::Mut1>,
        v2_1: LrcPtr<Runtime::Mut2>,
        v3: LrcPtr<Runtime::Mut3>,
        v4: LrcPtr<Runtime::Mut4>,
        v5: Option<i64>,
        v6: string,
        v7: string,
    ) -> string {
        let v8: string = Runtime::method17();
        Runtime::method18(sprintf!(
            "{} {} #{} {} / {}",
            v6,
            v7,
            v0_1.l0.get().clone(),
            string("runtime.current_process_kill / exiting... 1"),
            v8
        ))
    }
    pub fn closure12(unitVar: (), unitVar_1: ()) {
        if Runtime::method7(Runtime::US0::US0_3) {
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
            ) = Runtime::TraceState::trace_state().get().clone().unwrap();
            let v23: Option<i64> = patternInput.5.clone();
            let v22: LrcPtr<Runtime::Mut4> = patternInput.4.clone();
            let v21: LrcPtr<Runtime::Mut3> = patternInput.3.clone();
            let v20_1: LrcPtr<Runtime::Mut2> = patternInput.2.clone();
            let v19_1: LrcPtr<Runtime::Mut1> = patternInput.1.clone();
            let v18_1: LrcPtr<Runtime::Mut0> = patternInput.0.clone();
            Runtime::method19(Runtime::method21(
                v18_1.clone(),
                v19_1.clone(),
                v20_1.clone(),
                v21.clone(),
                v22.clone(),
                v23.clone(),
                Runtime::method8(v18_1, v19_1, v20_1, v21, v22, v23),
                Runtime::method12(),
            ))
        };
    }
    pub fn closure4(unitVar: (), unitVar_1: ()) {
        ();
    }
    pub fn method6() {
        ();
    }
    pub fn closure3(unitVar: (), unitVar_1: ()) {
        Runtime::method6();
    }
    pub fn method26() -> string {
        string("")
    }
    pub fn method27(v0_1: i32, v1_1: LrcPtr<Runtime::Mut5>) -> bool {
        (v1_1.l0.get().clone()) < (v0_1)
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
    pub fn method28() -> Func1<char, Func1<LrcPtr<Runtime::UH0>, LrcPtr<Runtime::UH0>>> {
        Func1::new(move |v: char| Runtime::closure15((), v))
    }
    pub fn method29(
        v0_1: LrcPtr<Runtime::UH0>,
        v1_1: LrcPtr<StringBuilder>,
        v2_1: i32,
        v3: i32,
    ) -> (LrcPtr<StringBuilder>, i32, i32) {
        let v0_1: MutCell<LrcPtr<Runtime::UH0>> = MutCell::new(v0_1.clone());
        let v1_1: MutCell<LrcPtr<StringBuilder>> = MutCell::new(v1_1.clone());
        let v2_1: MutCell<i32> = MutCell::new(v2_1);
        let v3: MutCell<i32> = MutCell::new(v3);
        '_method29: loop {
            break '_method29 (match v0_1.get().clone().as_ref() {
                Runtime::UH0::UH0_0 => (v1_1.get().clone(), v2_1.get().clone(), v3.get().clone()),
                Runtime::UH0::UH0_1(v0_1_1_0, v0_1_1_1) => {
                    let v4: char = match v0_1.get().clone().as_ref() {
                        Runtime::UH0::UH0_1(x, _) => x.clone(),
                        _ => unreachable!(),
                    };
                    let v6: bool = '\n' == (v4);
                    let patternInput: (i32, i32) = if v6 {
                        ((v2_1.get().clone()) + 1_i32, 1_i32)
                    } else {
                        (v2_1.get().clone(), (v3.get().clone()) + 1_i32)
                    };
                    {
                        let v0_1_temp: LrcPtr<Runtime::UH0> = match v0_1.get().clone().as_ref() {
                            Runtime::UH0::UH0_1(_, x) => x.clone(),
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
                        let v2_1_temp: i32 = patternInput.0.clone();
                        let v3_temp: i32 = patternInput.1.clone();
                        v0_1.set(v0_1_temp);
                        v1_1.set(v1_1_temp);
                        v2_1.set(v2_1_temp);
                        v3.set(v3_temp);
                        continue '_method29;
                    }
                }
            });
        }
    }
    pub fn closure17(v0_1: i32, v1_1: i32, v2_1: string) -> string {
        if (v1_1) >= (v0_1) {
            v2_1.clone()
        } else {
            (Runtime::method30(v0_1, (v1_1) + 1_i32))(append((v2_1), string(" ")))
        }
    }
    pub fn method30(v0_1: i32, v1_1: i32) -> Func1<string, string> {
        Func1::new({
            let v0_1 = v0_1.clone();
            let v1_1 = v1_1.clone();
            move |v: string| Runtime::closure17(v0_1, v1_1, v)
        })
    }
    pub fn closure14(unitVar: (), _arg: (string, LrcPtr<StringBuilder>, i32, i32)) -> Runtime::US7 {
        let v3: i32 = _arg.3.clone();
        let v2_1: i32 = _arg.2.clone();
        let v1_1: LrcPtr<StringBuilder> = _arg.1.clone();
        let v0_1: string = _arg.0.clone();
        if string("") == (v0_1.clone()) {
            Runtime::US7::US7_1(sprintf!(
                "parsing.p_char / unexpected end of input / c: \'{}\' / s: {:?}",
                '\"',
                (v1_1.clone(), v2_1, v3)
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
                let v40: LrcPtr<Runtime::Mut5> = LrcPtr::new(Runtime::Mut5 {
                    l0: MutCell::new(0_i32),
                });
                while Runtime::method27(v38, v40.clone()) {
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
                    let patternInput: (LrcPtr<StringBuilder>, i32, i32) = Runtime::method29(
                        foldBack(
                            Func2::new(move |b0: char, b1: LrcPtr<Runtime::UH0>| {
                                (Runtime::method28())(b0)(b1)
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
                let v83: i32 = (indexOf(v0_1.clone(), string("\n"))) - 1_i32;
                Runtime::US7::US7_1(concat(new_array(&[
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
                                (if -2_i32 == (v83) {
                                    (length(v0_1)) + 1_i32
                                } else {
                                    (v83) + 1_i32
                                }) - 1_i32
                            )
                        )
                    ),
                    string("\n"),
                    append(
                        ((Runtime::method30((v3) - 1_i32, 0_i32))(string(""))),
                        string("^"),
                    ),
                    string("\n"),
                ])))
            }
        }
    }
    pub fn closure18(unitVar: (), _arg: (string, LrcPtr<StringBuilder>, i32, i32)) -> Runtime::US7 {
        let v3: i32 = _arg.3.clone();
        let v2_1: i32 = _arg.2.clone();
        let v1_1: LrcPtr<StringBuilder> = _arg.1.clone();
        let v0_1: string = _arg.0.clone();
        if string("") == (v0_1.clone()) {
            Runtime::US7::US7_1(sprintf!(
                "parsing.p_char / unexpected end of input / c: \'{}\' / s: {:?}",
                '\'',
                (v1_1.clone(), v2_1, v3)
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
                let v40: LrcPtr<Runtime::Mut5> = LrcPtr::new(Runtime::Mut5 {
                    l0: MutCell::new(0_i32),
                });
                while Runtime::method27(v38, v40.clone()) {
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
                    let patternInput: (LrcPtr<StringBuilder>, i32, i32) = Runtime::method29(
                        foldBack(
                            Func2::new(move |b0: char, b1: LrcPtr<Runtime::UH0>| {
                                (Runtime::method28())(b0)(b1)
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
                let v83: i32 = (indexOf(v0_1.clone(), string("\n"))) - 1_i32;
                Runtime::US7::US7_1(concat(new_array(&[
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
                                (if -2_i32 == (v83) {
                                    (length(v0_1)) + 1_i32
                                } else {
                                    (v83) + 1_i32
                                }) - 1_i32
                            )
                        )
                    ),
                    string("\n"),
                    append(
                        ((Runtime::method30((v3) - 1_i32, 0_i32))(string(""))),
                        string("^"),
                    ),
                    string("\n"),
                ])))
            }
        }
    }
    pub fn method31(
        v0_1: string,
        v1_1: LrcPtr<StringBuilder>,
        v2_1: LrcPtr<Runtime::UH1>,
    ) -> Runtime::US7 {
        let v0_1: MutCell<string> = MutCell::new(v0_1.clone());
        let v1_1: MutCell<LrcPtr<StringBuilder>> = MutCell::new(v1_1.clone());
        let v2_1: MutCell<LrcPtr<Runtime::UH1>> = MutCell::new(v2_1.clone());
        '_method31: loop {
            break '_method31 (match v2_1.get().clone().as_ref() {
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
                            }
                            .clone();
                            v0_1.set(v0_1_temp);
                            v1_1.set(v1_1_temp);
                            v2_1.set(v2_1_temp);
                            continue '_method31;
                        }
                    }
                }
            });
        }
    }
    pub fn method32(v0_1: char, v1_1: i64) -> bool {
        let v0_1: MutCell<char> = MutCell::new(v0_1);
        let v1_1: MutCell<i64> = MutCell::new(v1_1);
        '_method32: loop {
            break '_method32 (if (v1_1.get().clone()) >= 2_i64 {
                false
            } else {
                let v11: Runtime::US9 = if (v1_1.get().clone()) == 0_i64 {
                    Runtime::US9::US9_0('\"')
                } else {
                    let v5: i64 = (v1_1.get().clone()) - 1_i64;
                    if (v5) == 0_i64 {
                        Runtime::US9::US9_0('\'')
                    } else {
                        let v8: i64 = (v5) - 1_i64;
                        Runtime::US9::US9_1
                    }
                };
                if (v0_1.get().clone())
                    == (match &v11 {
                        Runtime::US9::US9_0(v11_0_0) => match &v11 {
                            Runtime::US9::US9_0(x) => x.clone(),
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
                    continue '_method32;
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
                let v109: Runtime::US7 = if string("") == (v1_1.get().clone()) {
                    Runtime::US7::US7_1(sprintf!(
                        "parsing.none_of / unexpected end of input / chars: {:?} / s: {:?}",
                        toArray(ofArray(new_array(&['\"', '\'']))),
                        (v2_1.get().clone(), v3.get().clone(), v4.get().clone())
                    ))
                } else {
                    let v21: char = getCharAt(v1_1.get().clone(), 0_i32);
                    if (Runtime::method32(v21, 0_i64)) == false {
                        let v44: string = getSlice(
                            v1_1.get().clone(),
                            Some(1_i32),
                            Some((length(v1_1.get().clone())) - 1_i32),
                        );
                        let v49: string = ofChar(v21);
                        let v52: i32 = length(v49.clone());
                        let v53: Array<char> = new_init(&'\u{0000}', v52);
                        let v54: LrcPtr<Runtime::Mut5> = LrcPtr::new(Runtime::Mut5 {
                            l0: MutCell::new(0_i32),
                        });
                        while Runtime::method27(v52, v54.clone()) {
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
                            let patternInput: (LrcPtr<StringBuilder>, i32, i32) = Runtime::method29(
                                foldBack(
                                    Func2::new(move |b0: char, b1: LrcPtr<Runtime::UH0>| {
                                        (Runtime::method28())(b0)(b1)
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
                            if '\\' == (v110) { '/' } else { v110 },
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
                            append((v0_1.get().clone()), (ofChar(v121_0_0.clone())));
                        let v1_1_temp: string = v121_0_1.clone();
                        let v2_1_temp: LrcPtr<StringBuilder> = v121_0_2.clone();
                        let v3_temp: i32 = v121_0_3.clone();
                        let v4_temp: i32 = v121_0_4.clone();
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
    pub fn method34(
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
        '_method34: loop {
            break '_method34 (match v4.get().clone().as_ref() {
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
                            }
                            .clone();
                            v0_1.set(v0_1_temp);
                            v1_1.set(v1_1_temp);
                            v2_1.set(v2_1_temp);
                            v3.set(v3_temp);
                            v4.set(v4_temp);
                            continue '_method34;
                        }
                    }
                }
            });
        }
    }
    pub fn method35(v0_1: char, v1_1: i64) -> bool {
        let v0_1: MutCell<char> = MutCell::new(v0_1);
        let v1_1: MutCell<i64> = MutCell::new(v1_1);
        '_method35: loop {
            break '_method35 (if (v1_1.get().clone()) >= 3_i64 {
                false
            } else {
                let v15: Runtime::US9 = if (v1_1.get().clone()) == 0_i64 {
                    Runtime::US9::US9_0('\"')
                } else {
                    let v5: i64 = (v1_1.get().clone()) - 1_i64;
                    if (v5) == 0_i64 {
                        Runtime::US9::US9_0('\'')
                    } else {
                        let v8: i64 = (v5) - 1_i64;
                        if (v8) == 0_i64 {
                            Runtime::US9::US9_0(' ')
                        } else {
                            let v11: i64 = (v8) - 1_i64;
                            Runtime::US9::US9_1
                        }
                    }
                };
                if (v0_1.get().clone())
                    == (match &v15 {
                        Runtime::US9::US9_0(v15_0_0) => match &v15 {
                            Runtime::US9::US9_0(x) => x.clone(),
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
                    continue '_method35;
                }
            });
        }
    }
    pub fn method36(
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
        '_method36: loop {
            break '_method36 ({
                let v115: Runtime::US7 = if string("") == (v1_1.get().clone()) {
                    Runtime::US7::US7_1(sprintf!(
                        "parsing.none_of / unexpected end of input / chars: {:?} / s: {:?}",
                        toArray(ofArray(new_array(&['\"', '\'', ' ']))),
                        (v2_1.get().clone(), v3.get().clone(), v4.get().clone())
                    ))
                } else {
                    let v24: char = getCharAt(v1_1.get().clone(), 0_i32);
                    if (Runtime::method35(v24, 0_i64)) == false {
                        let v47: string = getSlice(
                            v1_1.get().clone(),
                            Some(1_i32),
                            Some((length(v1_1.get().clone())) - 1_i32),
                        );
                        let v52: string = ofChar(v24);
                        let v55: i32 = length(v52.clone());
                        let v56: Array<char> = new_init(&'\u{0000}', v55);
                        let v57: LrcPtr<Runtime::Mut5> = LrcPtr::new(Runtime::Mut5 {
                            l0: MutCell::new(0_i32),
                        });
                        while Runtime::method27(v55, v57.clone()) {
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
                            let patternInput: (LrcPtr<StringBuilder>, i32, i32) = Runtime::method29(
                                foldBack(
                                    Func2::new(move |b0: char, b1: LrcPtr<Runtime::UH0>| {
                                        (Runtime::method28())(b0)(b1)
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
                            if '\\' == (v116) { '/' } else { v116 },
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
                            append((v0_1.get().clone()), (ofChar(v127_0_0.clone())));
                        let v1_1_temp: string = v127_0_1.clone();
                        let v2_1_temp: LrcPtr<StringBuilder> = v127_0_2.clone();
                        let v3_temp: i32 = v127_0_3.clone();
                        let v4_temp: i32 = v127_0_4.clone();
                        v0_1.set(v0_1_temp);
                        v1_1.set(v1_1_temp);
                        v2_1.set(v2_1_temp);
                        v3.set(v3_temp);
                        v4.set(v4_temp);
                        continue '_method36;
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
    pub fn method37(v0_1: string, v1_1: i32) -> i32 {
        let v0_1: MutCell<string> = MutCell::new(v0_1.clone());
        let v1_1: MutCell<i32> = MutCell::new(v1_1);
        '_method37: loop {
            break '_method37 (if (v1_1.get().clone()) >= (length(v0_1.get().clone())) {
                v1_1.get().clone()
            } else {
                if ' ' == (getCharAt(v0_1.get().clone(), v1_1.get().clone())) {
                    let v0_1_temp: string = v0_1.get().clone();
                    let v1_1_temp: i32 = (v1_1.get().clone()) + 1_i32;
                    v0_1.set(v0_1_temp);
                    v1_1.set(v1_1_temp);
                    continue '_method37;
                } else {
                    v1_1.get().clone()
                }
            });
        }
    }
    pub fn method38(
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
        '_method38: loop {
            break '_method38 ({
                let v79: Runtime::US7 = if string("") == (v1_1.get().clone()) {
                    Runtime::US7::US7_1(sprintf!(
                        "parsing.any_char / unexpected end of input / s: {:?}",
                        (v2_1.get().clone(), v3.get().clone(), v4.get().clone())
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
                    let v40: LrcPtr<Runtime::Mut5> = LrcPtr::new(Runtime::Mut5 {
                        l0: MutCell::new(0_i32),
                    });
                    while Runtime::method27(v38, v40.clone()) {
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
                        let patternInput: (LrcPtr<StringBuilder>, i32, i32) = Runtime::method29(
                            foldBack(
                                Func2::new(move |b0: char, b1: LrcPtr<Runtime::UH0>| {
                                    (Runtime::method28())(b0)(b1)
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
                        let v0_1_temp: string =
                            append((v0_1.get().clone()), (ofChar(v79_0_0.clone())));
                        let v1_1_temp: string = v79_0_1.clone();
                        let v2_1_temp: LrcPtr<StringBuilder> = v79_0_2.clone();
                        let v3_temp: i32 = v79_0_3.clone();
                        let v4_temp: i32 = v79_0_4.clone();
                        v0_1.set(v0_1_temp);
                        v1_1.set(v1_1_temp);
                        v2_1.set(v2_1_temp);
                        v3.set(v3_temp);
                        v4.set(v4_temp);
                        continue '_method38;
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
    pub fn method25(v0_1: string) -> Runtime::US6 {
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
            let v12: LrcPtr<StringBuilder> = StringBuilder::_ctor__Z721C83C5(Runtime::method26());
            fn v15(arg10_0040: (string, LrcPtr<StringBuilder>, i32, i32)) -> Runtime::US7 {
                Runtime::closure14((), arg10_0040)
            }
            fn v16_1(arg10_0040_1: (string, LrcPtr<StringBuilder>, i32, i32)) -> Runtime::US7 {
                Runtime::closure18((), arg10_0040_1)
            }
            let v20_1: Runtime::US7 = Runtime::method31(
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
                    let v130: Runtime::US7 = if string("") == (v22.clone()) {
                        Runtime::US7::US7_1(sprintf!(
                            "parsing.none_of / unexpected end of input / chars: {:?} / s: {:?}",
                            toArray(ofArray(new_array(&['\"', '\'']))),
                            (v23.clone(), v24, v25)
                        ))
                    } else {
                        let v42: char = getCharAt(v22.clone(), 0_i32);
                        if (Runtime::method32(v42, 0_i64)) == false {
                            let v65: string = getSlice(
                                v22.clone(),
                                Some(1_i32),
                                Some((length(v22.clone())) - 1_i32),
                            );
                            let v70: string = ofChar(v42);
                            let v73: i32 = length(v70.clone());
                            let v74: Array<char> = new_init(&'\u{0000}', v73);
                            let v75: LrcPtr<Runtime::Mut5> = LrcPtr::new(Runtime::Mut5 {
                                l0: MutCell::new(0_i32),
                            });
                            while Runtime::method27(v73, v75.clone()) {
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
                                let patternInput: (LrcPtr<StringBuilder>, i32, i32) =
                                    Runtime::method29(
                                        foldBack(
                                            Func2::new(
                                                move |b0: char, b1: LrcPtr<Runtime::UH0>| {
                                                    (Runtime::method28())(b0)(b1)
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
                                if '\\' == (v131) { '/' } else { v131 },
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
                                Runtime::method33(
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
                            let v180: Runtime::US7 = Runtime::method34(
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
                                                                 (v22.clone(),
                                                                  v23.clone(),
                                                                  v24, v25),
                                                                 (v173.clone(),
                                                                  v174.clone(),
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
                    let v321: Runtime::US7 = if string("") == (v7.clone()) {
                        Runtime::US7::US7_1(sprintf!(
                            "parsing.none_of / unexpected end of input / chars: {:?} / s: {:?}",
                            toArray(ofArray(new_array(&['\"', '\'', ' ']))),
                            (v12.clone(), 1_i32, 1_i32)
                        ))
                    } else {
                        let v228: char = getCharAt(v7.clone(), 0_i32);
                        if (Runtime::method35(v228, 0_i64)) == false {
                            let v251: string = getSlice(
                                v7.clone(),
                                Some(1_i32),
                                Some((length(v7.clone())) - 1_i32),
                            );
                            let v256: string = ofChar(v228);
                            let v259: i32 = length(v256.clone());
                            let v260: Array<char> = new_init(&'\u{0000}', v259);
                            let v261: LrcPtr<Runtime::Mut5> = LrcPtr::new(Runtime::Mut5 {
                                l0: MutCell::new(0_i32),
                            });
                            while Runtime::method27(v259, v261.clone()) {
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
                                let patternInput_2: (LrcPtr<StringBuilder>, i32, i32) =
                                    Runtime::method29(
                                        foldBack(
                                            Func2::new(
                                                move |b0: char, b1: LrcPtr<Runtime::UH0>| {
                                                    (Runtime::method28())(b0)(b1)
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
                                if '\\' == (v322) { '/' } else { v322 },
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
                                Runtime::method36(
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
                            let v366: Runtime::US10 = if (length(v7.clone())) == 0_i32 {
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
                                            Some(Runtime::method37(v377.clone(), 0_i32)),
                                            Some((length(v377)) - 1_i32),
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
            let v682: Runtime::US11 = match &v414 {
                Runtime::US8::US8_0(v414_0_0, v414_0_1, v414_0_2, v414_0_3, v414_0_4) => {
                    let v419: i32 = v414_0_4.clone();
                    let v418: i32 = v414_0_3.clone();
                    let v417: LrcPtr<StringBuilder> = v414_0_2.clone();
                    let v416: string = v414_0_1.clone();
                    let v541: Runtime::US7 = if string("") == (v416.clone()) {
                        Runtime::US7::US7_1(sprintf!(
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
                            let v456: LrcPtr<Runtime::Mut5> = LrcPtr::new(Runtime::Mut5 {
                                l0: MutCell::new(0_i32),
                            });
                            while Runtime::method27(v454, v456.clone()) {
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
                                let patternInput_4: (LrcPtr<StringBuilder>, i32, i32) =
                                    Runtime::method29(
                                        foldBack(
                                            Func2::new(
                                                move |b0: char, b1: LrcPtr<Runtime::UH0>| {
                                                    (Runtime::method28())(b0)(b1)
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
                            let v499: i32 = (indexOf(v416.clone(), string("\n"))) - 1_i32;
                            Runtime::US7::US7_1(concat(new_array(&[
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
                                            (if -2_i32 == (v499) {
                                                (length(v416.clone())) + 1_i32
                                            } else {
                                                (v499) + 1_i32
                                            }) - 1_i32
                                        )
                                    )
                                ),
                                string("\n"),
                                append(
                                    ((Runtime::method30((v419) - 1_i32, 0_i32))(string(""))),
                                    string("^"),
                                ),
                                string("\n"),
                            ])))
                        }
                    };
                    let v553: Runtime::US12 = match &v541 {
                        Runtime::US7::US7_0(v541_0_0, v541_0_1, v541_0_2, v541_0_3, v541_0_4) => {
                            Runtime::US12::US12_0(
                                Runtime::US9::US9_0(v541_0_0.clone()),
                                v541_0_1.clone(),
                                v541_0_2.clone(),
                                v541_0_3.clone(),
                                v541_0_4.clone(),
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
                    let v656: Runtime::US8 = match &v553 {
                        Runtime::US12::US12_0(v553_0_0, v553_0_1, v553_0_2, v553_0_3, v553_0_4) => {
                            let v558: i32 = v553_0_4.clone();
                            let v557: i32 = v553_0_3.clone();
                            let v556: LrcPtr<StringBuilder> = v553_0_2.clone();
                            let v555: string = v553_0_1.clone();
                            let v633: Runtime::US7 = if string("") == (v555.clone()) {
                                Runtime::US7::US7_1(sprintf!(
                                    "parsing.any_char / unexpected end of input / s: {:?}",
                                    (v556.clone(), v557, v558)
                                ))
                            } else {
                                let v564: char = getCharAt(v555.clone(), 0_i32);
                                let v584: string = getSlice(
                                    v555.clone(),
                                    Some(1_i32),
                                    Some((length(v555)) - 1_i32),
                                );
                                let v589: string = ofChar(v564);
                                let v592: i32 = length(v589.clone());
                                let v593: Array<char> = new_init(&'\u{0000}', v592);
                                let v594: LrcPtr<Runtime::Mut5> = LrcPtr::new(Runtime::Mut5 {
                                    l0: MutCell::new(0_i32),
                                });
                                while Runtime::method27(v592, v594.clone()) {
                                    let v596: i32 = v594.l0.get().clone();
                                    let v597: char = getCharAt(v589.clone(), v596);
                                    v593.get_mut()[v596 as usize] = v597;
                                    {
                                        let v598: i32 = (v596) + 1_i32;
                                        v594.l0.set(v598);
                                        ()
                                    }
                                }
                                {
                                    let v599: List<char> = ofArray(v593.clone());
                                    let patternInput_5: (LrcPtr<StringBuilder>, i32, i32) =
                                        Runtime::method29(
                                            foldBack(
                                                Func2::new(
                                                    move |b0: char, b1: LrcPtr<Runtime::UH0>| {
                                                        (Runtime::method28())(b0)(b1)
                                                    },
                                                ),
                                                v599,
                                                LrcPtr::new(Runtime::UH0::UH0_0),
                                            ),
                                            v556,
                                            v557,
                                            v558,
                                        );
                                    Runtime::US7::US7_0(
                                        v564,
                                        v584,
                                        patternInput_5.0.clone(),
                                        patternInput_5.1.clone(),
                                        patternInput_5.2.clone(),
                                    )
                                }
                            };
                            match &v633 {
                                Runtime::US7::US7_0(
                                    v633_0_0,
                                    v633_0_1,
                                    v633_0_2,
                                    v633_0_3,
                                    v633_0_4,
                                ) => {
                                    let patternInput_6: (
                                        string,
                                        string,
                                        LrcPtr<StringBuilder>,
                                        i32,
                                        i32,
                                    ) = Runtime::method38(
                                        ofChar(v633_0_0.clone()),
                                        v633_0_1.clone(),
                                        v633_0_2.clone(),
                                        v633_0_3.clone(),
                                        v633_0_4.clone(),
                                    );
                                    Runtime::US8::US8_0(
                                        patternInput_6.0.clone(),
                                        patternInput_6.1.clone(),
                                        patternInput_6.2.clone(),
                                        patternInput_6.3.clone(),
                                        patternInput_6.4.clone(),
                                    )
                                }
                                Runtime::US7::US7_1(v633_1_0) => {
                                    Runtime::US8::US8_1(v633_1_0.clone())
                                }
                            }
                        }
                        Runtime::US12::US12_1(v553_1_0) => Runtime::US8::US8_1(v553_1_0.clone()),
                    };
                    let v668: Runtime::US13 = match &v656 {
                        Runtime::US8::US8_0(v656_0_0, v656_0_1, v656_0_2, v656_0_3, v656_0_4) => {
                            Runtime::US13::US13_0(
                                Runtime::US5::US5_0(v656_0_0.clone()),
                                v656_0_1.clone(),
                                v656_0_2.clone(),
                                v656_0_3.clone(),
                                v656_0_4.clone(),
                            )
                        }
                        _ => Runtime::US13::US13_0(
                            Runtime::US5::US5_1,
                            v416.clone(),
                            v417.clone(),
                            v418,
                            v419,
                        ),
                    };
                    match &v668 {
                        Runtime::US13::US13_0(v668_0_0, v668_0_1, v668_0_2, v668_0_3, v668_0_4) => {
                            Runtime::US11::US11_0(
                                v414_0_0.clone(),
                                v668_0_0.clone(),
                                v668_0_1.clone(),
                                v668_0_2.clone(),
                                v668_0_3.clone(),
                                v668_0_4.clone(),
                            )
                        }
                        Runtime::US13::US13_1(v668_1_0) => Runtime::US11::US11_1(v668_1_0.clone()),
                    }
                }
                Runtime::US8::US8_1(v414_1_0) => Runtime::US11::US11_1(v414_1_0.clone()),
            };
            match &v682 {
                Runtime::US11::US11_0(
                    v682_0_0,
                    v682_0_1,
                    v682_0_2,
                    v682_0_3,
                    v682_0_4,
                    v682_0_5,
                ) => Runtime::US6::US6_0(v682_0_0.clone(), v682_0_1.clone()),
                Runtime::US11::US11_1(v682_1_0) => Runtime::US6::US6_1(v682_1_0.clone()),
            }
        }
    }
    pub fn method39() -> string {
        let v6: string = Runtime::method13(getCharAt(toLower(string("Debug")), 0_i32));
        let v41: &str = inline_colorization::color_bright_blue;
        let v46: &str = &*v6;
        let v67: &str = inline_colorization::color_reset;
        let v69: std::string::String = format!("{}{}{}", v41, v46, v67);
        fable_library_rust::String_::fromString(v69)
    }
    pub fn method41(
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
            l0: MutCell::new(Runtime::method14()),
        });
        let v17_1: () = {
            Runtime::closure7(v10.clone(), string("{ "), ());
            ()
        };
        let v26: () = {
            Runtime::closure7(v10.clone(), string("file_name"), ());
            ()
        };
        let v35: () = {
            Runtime::closure7(v10.clone(), string(" = "), ());
            ()
        };
        let v43: () = {
            Runtime::closure7(v10.clone(), v0_1, ());
            ()
        };
        let v52: () = {
            Runtime::closure7(v10.clone(), string("; "), ());
            ()
        };
        let v61: () = {
            Runtime::closure7(v10.clone(), string("arguments"), ());
            ()
        };
        let v69: () = {
            Runtime::closure7(v10.clone(), string(" = "), ());
            ()
        };
        let v80: () = {
            Runtime::closure7(v10.clone(), sprintf!("{:?}", v1_1), ());
            ()
        };
        let v88: () = {
            Runtime::closure7(v10.clone(), string("; "), ());
            ()
        };
        let v97: () = {
            Runtime::closure7(v10.clone(), string("options"), ());
            ()
        };
        let v105: () = {
            Runtime::closure7(v10.clone(), string(" = "), ());
            ()
        };
        let v113: () = {
            Runtime::closure7(v10.clone(), string("{ "), ());
            ()
        };
        let v122: () = {
            Runtime::closure7(v10.clone(), string("command"), ());
            ()
        };
        let v130: () = {
            Runtime::closure7(v10.clone(), string(" = "), ());
            ()
        };
        let v138: () = {
            Runtime::closure7(v10.clone(), v2_1, ());
            ()
        };
        let v146: () = {
            Runtime::closure7(v10.clone(), string("; "), ());
            ()
        };
        let v155: () = {
            Runtime::closure7(v10.clone(), string("cancellation_token"), ());
            ()
        };
        let v163: () = {
            Runtime::closure7(v10.clone(), string(" = "), ());
            ()
        };
        let v172: std::string::String = format!("{:#?}", v3);
        let v201: () = {
            Runtime::closure7(
                v10.clone(),
                fable_library_rust::String_::fromString(v172),
                (),
            );
            ()
        };
        let v209: () = {
            Runtime::closure7(v10.clone(), string("; "), ());
            ()
        };
        let v218: () = {
            Runtime::closure7(v10.clone(), string("environment_variables"), ());
            ()
        };
        let v226: () = {
            Runtime::closure7(v10.clone(), string(" = "), ());
            ()
        };
        let v237: () = {
            Runtime::closure7(v10.clone(), sprintf!("{:?}", v4), ());
            ()
        };
        let v245: () = {
            Runtime::closure7(v10.clone(), string("; "), ());
            ()
        };
        let v254: () = {
            Runtime::closure7(v10.clone(), string("on_line"), ());
            ()
        };
        let v262: () = {
            Runtime::closure7(v10.clone(), string(" = "), ());
            ()
        };
        let v271: std::string::String = format!("{:#?}", v5);
        let v300: () = {
            Runtime::closure7(
                v10.clone(),
                fable_library_rust::String_::fromString(v271),
                (),
            );
            ()
        };
        let v308: () = {
            Runtime::closure7(v10.clone(), string("; "), ());
            ()
        };
        let v317: () = {
            Runtime::closure7(v10.clone(), string("stdin"), ());
            ()
        };
        let v325: () = {
            Runtime::closure7(v10.clone(), string(" = "), ());
            ()
        };
        let v334: std::string::String = format!("{:#?}", v6);
        let v363: () = {
            Runtime::closure7(
                v10.clone(),
                fable_library_rust::String_::fromString(v334),
                (),
            );
            ()
        };
        let v371: () = {
            Runtime::closure7(v10.clone(), string("; "), ());
            ()
        };
        let v380: () = {
            Runtime::closure7(v10.clone(), string("trace"), ());
            ()
        };
        let v388: () = {
            Runtime::closure7(v10.clone(), string(" = "), ());
            ()
        };
        let v399: () = {
            Runtime::closure7(
                v10.clone(),
                if v7 { string("true") } else { string("false") },
                (),
            );
            ()
        };
        let v407: () = {
            Runtime::closure7(v10.clone(), string("; "), ());
            ()
        };
        let v416: () = {
            Runtime::closure7(v10.clone(), string("working_directory"), ());
            ()
        };
        let v424: () = {
            Runtime::closure7(v10.clone(), string(" = "), ());
            ()
        };
        let v433: std::string::String = format!("{:#?}", v8);
        let v462: () = {
            Runtime::closure7(
                v10.clone(),
                fable_library_rust::String_::fromString(v433),
                (),
            );
            ()
        };
        let v471: () = {
            Runtime::closure7(v10.clone(), string(" }"), ());
            ()
        };
        let v479: () = {
            Runtime::closure7(v10.clone(), string(" }"), ());
            ()
        };
        v10.l0.get().clone()
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
        v9: Runtime::US5,
        v10: string,
        v11: Option<CancellationToken>,
        v12: Array<(string, string)>,
        v13: Option<Func1<(i32, string, bool), Arc<Async<()>>>>,
        v14: Option<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
        v15: bool,
        v16_1: Option<string>,
    ) -> string {
        let v17_1: string = Runtime::method41(v8, v9, v10, v11, v12, v13, v14, v15, v16_1);
        Runtime::method18(sprintf!(
            "{} {} #{} {} / {}",
            v6,
            v7,
            v0_1.l0.get().clone(),
            string("runtime.execute_with_options_async"),
            v17_1
        ))
    }
    pub fn closure19(
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
        if Runtime::method7(Runtime::US0::US0_1) {
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
            ) = Runtime::TraceState::trace_state().get().clone().unwrap();
            let v32: Option<i64> = patternInput.5.clone();
            let v31: LrcPtr<Runtime::Mut4> = patternInput.4.clone();
            let v30: LrcPtr<Runtime::Mut3> = patternInput.3.clone();
            let v29: LrcPtr<Runtime::Mut2> = patternInput.2.clone();
            let v28: LrcPtr<Runtime::Mut1> = patternInput.1.clone();
            let v27: LrcPtr<Runtime::Mut0> = patternInput.0.clone();
            Runtime::method19(Runtime::method40(
                v27.clone(),
                v28.clone(),
                v29.clone(),
                v30.clone(),
                v31.clone(),
                v32.clone(),
                Runtime::method8(v27, v28, v29, v30, v31, v32),
                Runtime::method39(),
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
    pub fn method42(
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
    pub fn method45(v0_1: bool) -> string {
        unbox::<string>(&getZero())
    }
    pub fn closure21(
        unitVar: (),
        v0_1: Func1<(i32, string, bool), Arc<Async<()>>>,
    ) -> Runtime::US14 {
        Runtime::US14::US14_0(v0_1)
    }
    pub fn method46() -> Func1<Func1<(i32, string, bool), Arc<Async<()>>>, Runtime::US14> {
        Func1::new(move |v: Func1<(i32, string, bool), Arc<Async<()>>>| Runtime::closure21((), v))
    }
    pub fn method47(v0_1: bool) -> i32 {
        unbox::<i32>(&getZero())
    }
    pub fn method48() -> string {
        let v6: string = Runtime::method13(getCharAt(toLower(string("Verbose")), 0_i32));
        let v41: &str = inline_colorization::color_bright_black;
        let v46: &str = &*v6;
        let v67: &str = inline_colorization::color_reset;
        let v69: std::string::String = format!("{}{}{}", v41, v46, v67);
        fable_library_rust::String_::fromString(v69)
    }
    pub fn method49(
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
        let v9: string = Runtime::method17();
        Runtime::method18(sprintf!(
            "{} {} #{} {} / {}",
            v6,
            v7,
            v0_1.l0.get().clone(),
            v8,
            v9
        ))
    }
    pub fn closure22(v0_1: string, unitVar: ()) {
        if Runtime::method7(Runtime::US0::US0_0) {
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
            ) = Runtime::TraceState::trace_state().get().clone().unwrap();
            let v24: Option<i64> = patternInput.5.clone();
            let v23: LrcPtr<Runtime::Mut4> = patternInput.4.clone();
            let v22: LrcPtr<Runtime::Mut3> = patternInput.3.clone();
            let v21: LrcPtr<Runtime::Mut2> = patternInput.2.clone();
            let v20_1: LrcPtr<Runtime::Mut1> = patternInput.1.clone();
            let v19_1: LrcPtr<Runtime::Mut0> = patternInput.0.clone();
            Runtime::method19(if (v0_1.clone()) == string("") {
                string("")
            } else {
                Runtime::method49(
                    v19_1.clone(),
                    v20_1.clone(),
                    v21.clone(),
                    v22.clone(),
                    v23.clone(),
                    v24.clone(),
                    Runtime::method8(v19_1, v20_1, v21, v22, v23, v24),
                    Runtime::method48(),
                    v0_1,
                )
            })
        };
    }
    pub fn method44(
        v0_1: string,
        v1_1: Option<CancellationToken>,
        v2_1: Array<(string, string)>,
        v3: Option<Func1<(i32, string, bool), Arc<Async<()>>>>,
        v4: Option<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
        v5: bool,
        v6: Option<string>,
        v7: bool,
        v8: LrcPtr<ConcurrentStack_1<string>>,
        v9: bool,
        v10: bool,
    ) -> Arc<Async<()>> {
        getZero()
    }
    pub fn method43(
        v0_1: string,
        v1_1: Option<CancellationToken>,
        v2_1: Array<(string, string)>,
        v3: Option<Func1<(i32, string, bool), Arc<Async<()>>>>,
        v4: Option<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
        v5: bool,
        v6: Option<string>,
        v7: bool,
        v8: LrcPtr<ConcurrentStack_1<string>>,
        v9: bool,
        v10: bool,
    ) -> Arc<Async<()>> {
        Runtime::method44(v0_1, v1_1, v2_1, v3, v4, v5, v6, v7, v8, v9, v10)
    }
    pub fn closure20(
        v0_1: string,
        v1_1: Option<CancellationToken>,
        v2_1: Array<(string, string)>,
        v3: Option<Func1<(i32, string, bool), Arc<Async<()>>>>,
        v4: Option<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
        v5: bool,
        v6: Option<string>,
        v7: bool,
        v8: LrcPtr<ConcurrentStack_1<string>>,
        v9: bool,
        v10: bool,
    ) {
        let v11: Arc<Async<()>> =
            Runtime::method43(v0_1, v1_1, v2_1, v3, v4, v5, v6, v7, v8, v9, v10);
        getZero::<()>();
        ()
    }
    pub fn closure23(unitVar: (), v0_1: CancellationToken) -> Runtime::US15 {
        Runtime::US15::US15_0(v0_1)
    }
    pub fn method50() -> Func1<CancellationToken, Runtime::US15> {
        Func1::new(move |v: CancellationToken| Runtime::closure23((), v))
    }
    pub fn method51(v0_1: CancellationToken) -> Arc<Async<CancellationToken>> {
        getZero()
    }
    pub fn method52(v0_1: bool) -> bool {
        unbox::<bool>(&getZero())
    }
    pub fn method53(v0_1: bool) {
        ();
    }
    pub fn closure24(v0_1: bool, unitVar: ()) {
        if (Runtime::method52(v0_1)) == false {
            Runtime::method53(v0_1);
        };
    }
    pub fn method56(v0_1: LrcPtr<TaskCanceledException>) -> string {
        let v2_1: LrcPtr<Runtime::Mut3> = LrcPtr::new(Runtime::Mut3 {
            l0: MutCell::new(Runtime::method14()),
        });
        let v9: () = {
            Runtime::closure7(v2_1.clone(), string("{ "), ());
            ()
        };
        let v18_1: () = {
            Runtime::closure7(v2_1.clone(), string("ex"), ());
            ()
        };
        let v27: () = {
            Runtime::closure7(v2_1.clone(), string(" = "), ());
            ()
        };
        let v36: std::string::String = format!("{:#?}", v0_1);
        let v65: () = {
            Runtime::closure7(
                v2_1.clone(),
                fable_library_rust::String_::fromString(v36),
                (),
            );
            ()
        };
        let v74: () = {
            Runtime::closure7(v2_1.clone(), string(" }"), ());
            ()
        };
        v2_1.l0.get().clone()
    }
    pub fn method55(
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
        let v9: string = Runtime::method56(v8);
        Runtime::method18(sprintf!(
            "{} {} #{} {} / {}",
            v6,
            v7,
            v0_1.l0.get().clone(),
            string("runtime.execute_with_options_async / WaitForExitAsync"),
            v9
        ))
    }
    pub fn closure25(v0_1: LrcPtr<TaskCanceledException>, unitVar: ()) {
        if Runtime::method7(Runtime::US0::US0_3) {
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
            ) = Runtime::TraceState::trace_state().get().clone().unwrap();
            let v24: Option<i64> = patternInput.5.clone();
            let v23: LrcPtr<Runtime::Mut4> = patternInput.4.clone();
            let v22: LrcPtr<Runtime::Mut3> = patternInput.3.clone();
            let v21: LrcPtr<Runtime::Mut2> = patternInput.2.clone();
            let v20_1: LrcPtr<Runtime::Mut1> = patternInput.1.clone();
            let v19_1: LrcPtr<Runtime::Mut0> = patternInput.0.clone();
            Runtime::method19(Runtime::method55(
                v19_1.clone(),
                v20_1.clone(),
                v21.clone(),
                v22.clone(),
                v23.clone(),
                v24.clone(),
                Runtime::method8(v19_1, v20_1, v21, v22, v23, v24),
                Runtime::method12(),
                v0_1,
            ))
        };
    }
    pub fn method54(
        v0_1: bool,
        v1_1: LrcPtr<ConcurrentStack_1<string>>,
        v2_1: CancellationToken,
    ) -> Arc<Async<i32>> {
        getZero()
    }
    pub fn method57() -> string {
        string("\n")
    }
    pub fn method59(v0_1: i32, v1_1: i32) -> string {
        let v3: LrcPtr<Runtime::Mut3> = LrcPtr::new(Runtime::Mut3 {
            l0: MutCell::new(Runtime::method14()),
        });
        let v10: () = {
            Runtime::closure7(v3.clone(), string("{ "), ());
            ()
        };
        let v19_1: () = {
            Runtime::closure7(v3.clone(), string("exit_code"), ());
            ()
        };
        let v28: () = {
            Runtime::closure7(v3.clone(), string(" = "), ());
            ()
        };
        let v36: () = {
            Runtime::closure7(v3.clone(), sprintf!("{}", v0_1), ());
            ()
        };
        let v45: () = {
            Runtime::closure7(v3.clone(), string("; "), ());
            ()
        };
        let v54: () = {
            Runtime::closure7(v3.clone(), string("output_length"), ());
            ()
        };
        let v62: () = {
            Runtime::closure7(v3.clone(), string(" = "), ());
            ()
        };
        let v70: () = {
            Runtime::closure7(v3.clone(), sprintf!("{}", v1_1), ());
            ()
        };
        let v79: () = {
            Runtime::closure7(v3.clone(), string(" }"), ());
            ()
        };
        v3.l0.get().clone()
    }
    pub fn method58(
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
        let v10: string = Runtime::method59(v8, v9);
        Runtime::method18(sprintf!(
            "{} {} #{} {} / {}",
            v6,
            v7,
            v0_1.l0.get().clone(),
            string("runtime.execute_with_options_async"),
            v10
        ))
    }
    pub fn closure26(v0_1: i32, v1_1: string, unitVar: ()) {
        if Runtime::method7(Runtime::US0::US0_1) {
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
            ) = Runtime::TraceState::trace_state().get().clone().unwrap();
            let v25: Option<i64> = patternInput.5.clone();
            let v24: LrcPtr<Runtime::Mut4> = patternInput.4.clone();
            let v23: LrcPtr<Runtime::Mut3> = patternInput.3.clone();
            let v22: LrcPtr<Runtime::Mut2> = patternInput.2.clone();
            let v21: LrcPtr<Runtime::Mut1> = patternInput.1.clone();
            let v20_1: LrcPtr<Runtime::Mut0> = patternInput.0.clone();
            Runtime::method19(Runtime::method58(
                v20_1.clone(),
                v21.clone(),
                v22.clone(),
                v23.clone(),
                v24.clone(),
                v25.clone(),
                Runtime::method8(v20_1, v21, v22, v23, v24, v25),
                Runtime::method39(),
                v0_1,
                length(v1_1),
            ))
        };
    }
    pub fn method24(
        v0_1: string,
        v1_1: Option<CancellationToken>,
        v2_1: Array<(string, string)>,
        v3: Option<Func1<(i32, string, bool), Arc<Async<()>>>>,
        v4: Option<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
        v5: bool,
        v6: Option<string>,
    ) -> Arc<Async<(i32, string)>> {
        getZero()
    }
    pub fn method23(
        v0_1: string,
        v1_1: Option<CancellationToken>,
        v2_1: Array<(string, string)>,
        v3: Option<Func1<(i32, string, bool), Arc<Async<()>>>>,
        v4: Option<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
        v5: bool,
        v6: Option<string>,
    ) -> Arc<Async<(i32, string)>> {
        Runtime::method24(v0_1, v1_1, v2_1, v3, v4, v5, v6)
    }
    pub fn method22(v0_1: string) -> Arc<Async<(i32, string)>> {
        Runtime::method23(
            v0_1,
            None::<CancellationToken>,
            new_empty::<(string, string)>(),
            None::<Func1<(i32, string, bool), Arc<Async<()>>>>,
            None::<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
            true,
            None::<string>,
        )
    }
    pub fn closure13(unitVar: (), v0_1: string) -> Arc<Async<(i32, string)>> {
        Runtime::method22(v0_1)
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
        Runtime::method23(
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
    pub fn method62(v0_1: char, v1_1: i64) -> bool {
        let v0_1: MutCell<char> = MutCell::new(v0_1);
        let v1_1: MutCell<i64> = MutCell::new(v1_1);
        '_method62: loop {
            break '_method62 (if (v1_1.get().clone()) >= 4_i64 {
                false
            } else {
                let v19_1: Runtime::US9 = if (v1_1.get().clone()) == 0_i64 {
                    Runtime::US9::US9_0('\\')
                } else {
                    let v5: i64 = (v1_1.get().clone()) - 1_i64;
                    if (v5) == 0_i64 {
                        Runtime::US9::US9_0('`')
                    } else {
                        let v8: i64 = (v5) - 1_i64;
                        if (v8) == 0_i64 {
                            Runtime::US9::US9_0('\"')
                        } else {
                            let v11: i64 = (v8) - 1_i64;
                            if (v11) == 0_i64 {
                                Runtime::US9::US9_0(' ')
                            } else {
                                let v14: i64 = (v11) - 1_i64;
                                Runtime::US9::US9_1
                            }
                        }
                    }
                };
                if (v0_1.get().clone())
                    == (match &v19_1 {
                        Runtime::US9::US9_0(v19_1_0_0) => match &v19_1 {
                            Runtime::US9::US9_0(x) => x.clone(),
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
                    continue '_method62;
                }
            });
        }
    }
    pub fn method63(
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
        '_method63: loop {
            break '_method63 ({
                let v121: Runtime::US7 = if string("") == (v1_1.get().clone()) {
                    Runtime::US7::US7_1(sprintf!(
                        "parsing.none_of / unexpected end of input / chars: {:?} / s: {:?}",
                        toArray(ofArray(new_array(&['\\', '`', '\"', ' ']))),
                        (v2_1.get().clone(), v3.get().clone(), v4.get().clone())
                    ))
                } else {
                    let v27: char = getCharAt(v1_1.get().clone(), 0_i32);
                    if (Runtime::method62(v27, 0_i64)) == false {
                        let v50: string = getSlice(
                            v1_1.get().clone(),
                            Some(1_i32),
                            Some((length(v1_1.get().clone())) - 1_i32),
                        );
                        let v55: string = ofChar(v27);
                        let v58: i32 = length(v55.clone());
                        let v59: Array<char> = new_init(&'\u{0000}', v58);
                        let v60: LrcPtr<Runtime::Mut5> = LrcPtr::new(Runtime::Mut5 {
                            l0: MutCell::new(0_i32),
                        });
                        while Runtime::method27(v58, v60.clone()) {
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
                            let patternInput: (LrcPtr<StringBuilder>, i32, i32) = Runtime::method29(
                                foldBack(
                                    Func2::new(move |b0: char, b1: LrcPtr<Runtime::UH0>| {
                                        (Runtime::method28())(b0)(b1)
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
                            append((v0_1.get().clone()), (ofChar(v121_0_0.clone())));
                        let v1_1_temp: string = v121_0_1.clone();
                        let v2_1_temp: LrcPtr<StringBuilder> = v121_0_2.clone();
                        let v3_temp: i32 = v121_0_3.clone();
                        let v4_temp: i32 = v121_0_4.clone();
                        v0_1.set(v0_1_temp);
                        v1_1.set(v1_1_temp);
                        v2_1.set(v2_1_temp);
                        v3.set(v3_temp);
                        v4.set(v4_temp);
                        continue '_method63;
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
    pub fn method65(v0_1: char, v1_1: i64) -> bool {
        let v0_1: MutCell<char> = MutCell::new(v0_1);
        let v1_1: MutCell<i64> = MutCell::new(v1_1);
        '_method65: loop {
            break '_method65 (if (v1_1.get().clone()) >= 3_i64 {
                false
            } else {
                let v15: Runtime::US9 = if (v1_1.get().clone()) == 0_i64 {
                    Runtime::US9::US9_0('\\')
                } else {
                    let v5: i64 = (v1_1.get().clone()) - 1_i64;
                    if (v5) == 0_i64 {
                        Runtime::US9::US9_0('`')
                    } else {
                        let v8: i64 = (v5) - 1_i64;
                        if (v8) == 0_i64 {
                            Runtime::US9::US9_0('\"')
                        } else {
                            let v11: i64 = (v8) - 1_i64;
                            Runtime::US9::US9_1
                        }
                    }
                };
                if (v0_1.get().clone())
                    == (match &v15 {
                        Runtime::US9::US9_0(v15_0_0) => match &v15 {
                            Runtime::US9::US9_0(x) => x.clone(),
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
                    continue '_method65;
                }
            });
        }
    }
    pub fn closure30(unitVar: (), _arg: (string, LrcPtr<StringBuilder>, i32, i32)) -> Runtime::US8 {
        let v3: i32 = _arg.3.clone();
        let v2_1: i32 = _arg.2.clone();
        let v1_1: LrcPtr<StringBuilder> = _arg.1.clone();
        let v0_1: string = _arg.0.clone();
        let v126: Runtime::US7 = if string("") == (v0_1.clone()) {
            Runtime::US7::US7_1(sprintf!(
                "parsing.p_char / unexpected end of input / c: \'{}\' / s: {:?}",
                '\\',
                (v1_1.clone(), v2_1, v3)
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
                let v40: LrcPtr<Runtime::Mut5> = LrcPtr::new(Runtime::Mut5 {
                    l0: MutCell::new(0_i32),
                });
                while Runtime::method27(v38, v40.clone()) {
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
                    let patternInput: (LrcPtr<StringBuilder>, i32, i32) = Runtime::method29(
                        foldBack(
                            Func2::new(move |b0: char, b1: LrcPtr<Runtime::UH0>| {
                                (Runtime::method28())(b0)(b1)
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
                let v83: i32 = (indexOf(v0_1.clone(), string("\n"))) - 1_i32;
                Runtime::US7::US7_1(concat(new_array(&[
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
                                (if -2_i32 == (v83) {
                                    (length(v0_1)) + 1_i32
                                } else {
                                    (v83) + 1_i32
                                }) - 1_i32
                            )
                        )
                    ),
                    string("\n"),
                    append(
                        ((Runtime::method30((v3) - 1_i32, 0_i32))(string(""))),
                        string("^"),
                    ),
                    string("\n"),
                ])))
            }
        };
        let v210: Runtime::US7 = match &v126 {
            Runtime::US7::US7_0(v126_0_0, v126_0_1, v126_0_2, v126_0_3, v126_0_4) => {
                let v131: i32 = v126_0_4.clone();
                let v130: i32 = v126_0_3.clone();
                let v129: LrcPtr<StringBuilder> = v126_0_2.clone();
                let v128: string = v126_0_1.clone();
                if string("") == (v128.clone()) {
                    Runtime::US7::US7_1(sprintf!(
                        "parsing.any_char / unexpected end of input / s: {:?}",
                        (v129.clone(), v130, v131)
                    ))
                } else {
                    let v137: char = getCharAt(v128.clone(), 0_i32);
                    let v157: string =
                        getSlice(v128.clone(), Some(1_i32), Some((length(v128)) - 1_i32));
                    let v162: string = ofChar(v137);
                    let v165: i32 = length(v162.clone());
                    let v166: Array<char> = new_init(&'\u{0000}', v165);
                    let v167: LrcPtr<Runtime::Mut5> = LrcPtr::new(Runtime::Mut5 {
                        l0: MutCell::new(0_i32),
                    });
                    while Runtime::method27(v165, v167.clone()) {
                        let v169: i32 = v167.l0.get().clone();
                        let v170: char = getCharAt(v162.clone(), v169);
                        v166.get_mut()[v169 as usize] = v170;
                        {
                            let v171: i32 = (v169) + 1_i32;
                            v167.l0.set(v171);
                            ()
                        }
                    }
                    {
                        let v172: List<char> = ofArray(v166.clone());
                        let patternInput_1: (LrcPtr<StringBuilder>, i32, i32) = Runtime::method29(
                            foldBack(
                                Func2::new(move |b0: char, b1: LrcPtr<Runtime::UH0>| {
                                    (Runtime::method28())(b0)(b1)
                                }),
                                v172,
                                LrcPtr::new(Runtime::UH0::UH0_0),
                            ),
                            v129,
                            v130,
                            v131,
                        );
                        Runtime::US7::US7_0(
                            v137,
                            v157,
                            patternInput_1.0.clone(),
                            patternInput_1.1.clone(),
                            patternInput_1.2.clone(),
                        )
                    }
                }
            }
            Runtime::US7::US7_1(v126_1_0) => Runtime::US7::US7_1(v126_1_0.clone()),
        };
        match &v210 {
            Runtime::US7::US7_0(v210_0_0, v210_0_1, v210_0_2, v210_0_3, v210_0_4) => {
                Runtime::US8::US8_0(
                    append((ofChar('\\')), (ofChar(v210_0_0.clone()))),
                    v210_0_1.clone(),
                    v210_0_2.clone(),
                    v210_0_3.clone(),
                    v210_0_4.clone(),
                )
            }
            Runtime::US7::US7_1(v210_1_0) => Runtime::US8::US8_1(v210_1_0.clone()),
        }
    }
    pub fn closure31(unitVar: (), _arg: (string, LrcPtr<StringBuilder>, i32, i32)) -> Runtime::US8 {
        let v3: i32 = _arg.3.clone();
        let v2_1: i32 = _arg.2.clone();
        let v1_1: LrcPtr<StringBuilder> = _arg.1.clone();
        let v0_1: string = _arg.0.clone();
        let v126: Runtime::US7 = if string("") == (v0_1.clone()) {
            Runtime::US7::US7_1(sprintf!(
                "parsing.p_char / unexpected end of input / c: \'{}\' / s: {:?}",
                '`',
                (v1_1.clone(), v2_1, v3)
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
                let v40: LrcPtr<Runtime::Mut5> = LrcPtr::new(Runtime::Mut5 {
                    l0: MutCell::new(0_i32),
                });
                while Runtime::method27(v38, v40.clone()) {
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
                    let patternInput: (LrcPtr<StringBuilder>, i32, i32) = Runtime::method29(
                        foldBack(
                            Func2::new(move |b0: char, b1: LrcPtr<Runtime::UH0>| {
                                (Runtime::method28())(b0)(b1)
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
                let v83: i32 = (indexOf(v0_1.clone(), string("\n"))) - 1_i32;
                Runtime::US7::US7_1(concat(new_array(&[
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
                                (if -2_i32 == (v83) {
                                    (length(v0_1)) + 1_i32
                                } else {
                                    (v83) + 1_i32
                                }) - 1_i32
                            )
                        )
                    ),
                    string("\n"),
                    append(
                        ((Runtime::method30((v3) - 1_i32, 0_i32))(string(""))),
                        string("^"),
                    ),
                    string("\n"),
                ])))
            }
        };
        let v210: Runtime::US7 = match &v126 {
            Runtime::US7::US7_0(v126_0_0, v126_0_1, v126_0_2, v126_0_3, v126_0_4) => {
                let v131: i32 = v126_0_4.clone();
                let v130: i32 = v126_0_3.clone();
                let v129: LrcPtr<StringBuilder> = v126_0_2.clone();
                let v128: string = v126_0_1.clone();
                if string("") == (v128.clone()) {
                    Runtime::US7::US7_1(sprintf!(
                        "parsing.any_char / unexpected end of input / s: {:?}",
                        (v129.clone(), v130, v131)
                    ))
                } else {
                    let v137: char = getCharAt(v128.clone(), 0_i32);
                    let v157: string =
                        getSlice(v128.clone(), Some(1_i32), Some((length(v128)) - 1_i32));
                    let v162: string = ofChar(v137);
                    let v165: i32 = length(v162.clone());
                    let v166: Array<char> = new_init(&'\u{0000}', v165);
                    let v167: LrcPtr<Runtime::Mut5> = LrcPtr::new(Runtime::Mut5 {
                        l0: MutCell::new(0_i32),
                    });
                    while Runtime::method27(v165, v167.clone()) {
                        let v169: i32 = v167.l0.get().clone();
                        let v170: char = getCharAt(v162.clone(), v169);
                        v166.get_mut()[v169 as usize] = v170;
                        {
                            let v171: i32 = (v169) + 1_i32;
                            v167.l0.set(v171);
                            ()
                        }
                    }
                    {
                        let v172: List<char> = ofArray(v166.clone());
                        let patternInput_1: (LrcPtr<StringBuilder>, i32, i32) = Runtime::method29(
                            foldBack(
                                Func2::new(move |b0: char, b1: LrcPtr<Runtime::UH0>| {
                                    (Runtime::method28())(b0)(b1)
                                }),
                                v172,
                                LrcPtr::new(Runtime::UH0::UH0_0),
                            ),
                            v129,
                            v130,
                            v131,
                        );
                        Runtime::US7::US7_0(
                            v137,
                            v157,
                            patternInput_1.0.clone(),
                            patternInput_1.1.clone(),
                            patternInput_1.2.clone(),
                        )
                    }
                }
            }
            Runtime::US7::US7_1(v126_1_0) => Runtime::US7::US7_1(v126_1_0.clone()),
        };
        match &v210 {
            Runtime::US7::US7_0(v210_0_0, v210_0_1, v210_0_2, v210_0_3, v210_0_4) => {
                Runtime::US8::US8_0(
                    append((ofChar('`')), (ofChar(v210_0_0.clone()))),
                    v210_0_1.clone(),
                    v210_0_2.clone(),
                    v210_0_3.clone(),
                    v210_0_4.clone(),
                )
            }
            Runtime::US7::US7_1(v210_1_0) => Runtime::US8::US8_1(v210_1_0.clone()),
        }
    }
    pub fn method66(
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
        '_method66: loop {
            break '_method66 (match v4.get().clone().as_ref() {
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
                            }
                            .clone();
                            v0_1.set(v0_1_temp);
                            v1_1.set(v1_1_temp);
                            v2_1.set(v2_1_temp);
                            v3.set(v3_temp);
                            v4.set(v4_temp);
                            continue '_method66;
                        }
                    }
                }
            });
        }
    }
    pub fn method67(
        v0_1: LrcPtr<Runtime::UH2>,
        v1_1: LrcPtr<Runtime::UH2>,
    ) -> LrcPtr<Runtime::UH2> {
        let v0_1: MutCell<LrcPtr<Runtime::UH2>> = MutCell::new(v0_1.clone());
        let v1_1: MutCell<LrcPtr<Runtime::UH2>> = MutCell::new(v1_1.clone());
        '_method67: loop {
            break '_method67 (match v0_1.get().clone().as_ref() {
                Runtime::UH2::UH2_0 => v1_1.get().clone(),
                Runtime::UH2::UH2_1(v0_1_1_0, v0_1_1_1) => {
                    let v0_1_temp: LrcPtr<Runtime::UH2> = match v0_1.get().clone().as_ref() {
                        Runtime::UH2::UH2_1(_, x) => x.clone(),
                        _ => unreachable!(),
                    }
                    .clone();
                    let v1_1_temp: LrcPtr<Runtime::UH2> = LrcPtr::new(Runtime::UH2::UH2_1(
                        match v0_1.get().clone().as_ref() {
                            Runtime::UH2::UH2_1(x, _) => x.clone(),
                            _ => unreachable!(),
                        }
                        .clone(),
                        v1_1.get().clone(),
                    ));
                    v0_1.set(v0_1_temp);
                    v1_1.set(v1_1_temp);
                    continue '_method67;
                }
            });
        }
    }
    pub fn method64(
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
        '_method64: loop {
            break '_method64 ({
                let v115: Runtime::US7 = if string("") == (v1_1.get().clone()) {
                    Runtime::US7::US7_1(sprintf!(
                        "parsing.none_of / unexpected end of input / chars: {:?} / s: {:?}",
                        toArray(ofArray(new_array(&['\\', '`', '\"']))),
                        (v2_1.get().clone(), v3.get().clone(), v4.get().clone())
                    ))
                } else {
                    let v24: char = getCharAt(v1_1.get().clone(), 0_i32);
                    if (Runtime::method65(v24, 0_i64)) == false {
                        let v47: string = getSlice(
                            v1_1.get().clone(),
                            Some(1_i32),
                            Some((length(v1_1.get().clone())) - 1_i32),
                        );
                        let v52: string = ofChar(v24);
                        let v55: i32 = length(v52.clone());
                        let v56: Array<char> = new_init(&'\u{0000}', v55);
                        let v57: LrcPtr<Runtime::Mut5> = LrcPtr::new(Runtime::Mut5 {
                            l0: MutCell::new(0_i32),
                        });
                        while Runtime::method27(v55, v57.clone()) {
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
                            let patternInput: (LrcPtr<StringBuilder>, i32, i32) = Runtime::method29(
                                foldBack(
                                    Func2::new(move |b0: char, b1: LrcPtr<Runtime::UH0>| {
                                        (Runtime::method28())(b0)(b1)
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
                    _ => Runtime::method66(
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
                        continue '_method64;
                    }
                    _ => Runtime::US17::US17_0(
                        Runtime::method67(v0_1.get().clone(), LrcPtr::new(Runtime::UH2::UH2_0)),
                        v1_1.get().clone(),
                        v2_1.get().clone(),
                        v3.get().clone(),
                        v4.get().clone(),
                    ),
                }
            });
        }
    }
    pub fn method68(v0_1: LrcPtr<Runtime::UH2>, v1_1: List<string>) -> List<string> {
        match v0_1.as_ref() {
            Runtime::UH2::UH2_0 => v1_1.clone(),
            Runtime::UH2::UH2_1(v0_1_1_0, v0_1_1_1) => cons(
                match v0_1.as_ref() {
                    Runtime::UH2::UH2_1(x, _) => x.clone(),
                    _ => unreachable!(),
                }
                .clone(),
                Runtime::method68(
                    match v0_1.as_ref() {
                        Runtime::UH2::UH2_1(_, x) => x.clone(),
                        _ => unreachable!(),
                    }
                    .clone(),
                    v1_1.clone(),
                ),
            ),
        }
    }
    pub fn method69(
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
        '_method69: loop {
            break '_method69 ({
                let v115: Runtime::US7 = if string("") == (v1_1.get().clone()) {
                    Runtime::US7::US7_1(sprintf!(
                        "parsing.none_of / unexpected end of input / chars: {:?} / s: {:?}",
                        toArray(ofArray(new_array(&['\\', '`', '\"']))),
                        (v2_1.get().clone(), v3.get().clone(), v4.get().clone())
                    ))
                } else {
                    let v24: char = getCharAt(v1_1.get().clone(), 0_i32);
                    if (Runtime::method65(v24, 0_i64)) == false {
                        let v47: string = getSlice(
                            v1_1.get().clone(),
                            Some(1_i32),
                            Some((length(v1_1.get().clone())) - 1_i32),
                        );
                        let v52: string = ofChar(v24);
                        let v55: i32 = length(v52.clone());
                        let v56: Array<char> = new_init(&'\u{0000}', v55);
                        let v57: LrcPtr<Runtime::Mut5> = LrcPtr::new(Runtime::Mut5 {
                            l0: MutCell::new(0_i32),
                        });
                        while Runtime::method27(v55, v57.clone()) {
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
                            let patternInput: (LrcPtr<StringBuilder>, i32, i32) = Runtime::method29(
                                foldBack(
                                    Func2::new(move |b0: char, b1: LrcPtr<Runtime::UH0>| {
                                        (Runtime::method28())(b0)(b1)
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
                        continue '_method69;
                    }
                    _ => Runtime::US17::US17_0(
                        Runtime::method67(v0_1.get().clone(), LrcPtr::new(Runtime::UH2::UH2_0)),
                        v1_1.get().clone(),
                        v2_1.get().clone(),
                        v3.get().clone(),
                        v4.get().clone(),
                    ),
                }
            });
        }
    }
    pub fn method61(
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
        '_method61: loop {
            break '_method61 ({
                let v5: bool = string("") == (v1_1.get().clone());
                let v121: Runtime::US7 = if v5 {
                    Runtime::US7::US7_1(sprintf!(
                        "parsing.none_of / unexpected end of input / chars: {:?} / s: {:?}",
                        toArray(ofArray(new_array(&['\\', '`', '\"', ' ']))),
                        (v2_1.get().clone(), v3.get().clone(), v4.get().clone())
                    ))
                } else {
                    let v27: char = getCharAt(v1_1.get().clone(), 0_i32);
                    if (Runtime::method62(v27, 0_i64)) == false {
                        let v50: string = getSlice(
                            v1_1.get().clone(),
                            Some(1_i32),
                            Some((length(v1_1.get().clone())) - 1_i32),
                        );
                        let v55: string = ofChar(v27);
                        let v58: i32 = length(v55.clone());
                        let v59: Array<char> = new_init(&'\u{0000}', v58);
                        let v60: LrcPtr<Runtime::Mut5> = LrcPtr::new(Runtime::Mut5 {
                            l0: MutCell::new(0_i32),
                        });
                        while Runtime::method27(v58, v60.clone()) {
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
                            let patternInput: (LrcPtr<StringBuilder>, i32, i32) = Runtime::method29(
                                foldBack(
                                    Func2::new(move |b0: char, b1: LrcPtr<Runtime::UH0>| {
                                        (Runtime::method28())(b0)(b1)
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
                            Runtime::method63(
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
                        let v268: Runtime::US7 = if v5 {
                            Runtime::US7::US7_1(sprintf!(
                                "parsing.p_char / unexpected end of input / c: \'{}\' / s: {:?}",
                                '\"',
                                (v2_1.get().clone(), v3.get().clone(), v4.get().clone())
                            ))
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
                                let v182: LrcPtr<Runtime::Mut5> = LrcPtr::new(Runtime::Mut5 {
                                    l0: MutCell::new(0_i32),
                                });
                                while Runtime::method27(v180, v182.clone()) {
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
                                    let patternInput_2: (LrcPtr<StringBuilder>, i32, i32) =
                                        Runtime::method29(
                                            foldBack(
                                                Func2::new(
                                                    move |b0: char, b1: LrcPtr<Runtime::UH0>| {
                                                        (Runtime::method28())(b0)(b1)
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
                                let v225: i32 = (indexOf(v1_1.get().clone(), string("\n"))) - 1_i32;
                                Runtime::US7::US7_1(concat(new_array(&[sprintf!("parsing.p_char / expected: \'{}\' / line: {} / col: {}\n{}{}",
                                                                                                 '\"',
                                                                                                 v3.get().clone(),
                                                                                                 v4.get().clone(),
                                                                                                 v2_1.get().clone(),
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
                                                                                        append(((Runtime::method30((v4.get().clone())
                                                                                                                       -
                                                                                                                       1_i32,
                                                                                                                   0_i32))(string(""))),
                                                                                               string("^")),
                                                                                        string("\n")])))
                            }
                        };
                        let v452: Runtime::US8 = match &v268 {
                            Runtime::US7::US7_0(
                                v268_0_0,
                                v268_0_1,
                                v268_0_2,
                                v268_0_3,
                                v268_0_4,
                            ) => {
                                let v273: i32 = v268_0_4.clone();
                                let v272: i32 = v268_0_3.clone();
                                let v271: LrcPtr<StringBuilder> = v268_0_2.clone();
                                let v270: string = v268_0_1.clone();
                                let v275: Runtime::US17 = Runtime::method64(
                                    LrcPtr::new(Runtime::UH2::UH2_0),
                                    v270.clone(),
                                    v271.clone(),
                                    v272,
                                    v273,
                                );
                                let v302: Runtime::US8 = match &v275 {
                                    Runtime::US17::US17_0(
                                        v275_0_0,
                                        v275_0_1,
                                        v275_0_2,
                                        v275_0_3,
                                        v275_0_4,
                                    ) => {
                                        let v282: List<string> =
                                            Runtime::method68(v275_0_0.clone(), empty::<string>());
                                        Runtime::US8::US8_0(
                                            join(
                                                string(""),
                                                toArray_1(delay(Func0::new({
                                                    let v282 = v282.clone();
                                                    move || ofList(v282.clone()).clone()
                                                }))),
                                            ),
                                            v275_0_1.clone(),
                                            v275_0_2.clone(),
                                            v275_0_3.clone(),
                                            v275_0_4.clone(),
                                        )
                                    }
                                    Runtime::US17::US17_1(v275_1_0) => {
                                        Runtime::US8::US8_1(v275_1_0.clone())
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
                                        let v430: Runtime::US7 = if string("") == (v304.clone()) {
                                            Runtime::US7::US7_1(sprintf!("parsing.p_char / unexpected end of input / c: \'{}\' / s: {:?}",
                                                                                              '\"',
                                                                                              (v305.clone(),
                                                                                               v306,
                                                                                               v307)))
                                        } else {
                                            let v313: char = getCharAt(v304.clone(), 0_i32);
                                            if (v313) == '\"' {
                                                let v334: string = getSlice(
                                                    v304.clone(),
                                                    Some(1_i32),
                                                    Some((length(v304.clone())) - 1_i32),
                                                );
                                                let v339: string = ofChar(v313);
                                                let v342: i32 = length(v339.clone());
                                                let v343: Array<char> = new_init(&'\u{0000}', v342);
                                                let v344: LrcPtr<Runtime::Mut5> =
                                                    LrcPtr::new(Runtime::Mut5 {
                                                        l0: MutCell::new(0_i32),
                                                    });
                                                while Runtime::method27(v342, v344.clone()) {
                                                    let v346: i32 = v344.l0.get().clone();
                                                    let v347: char = getCharAt(v339.clone(), v346);
                                                    v343.get_mut()[v346 as usize] = v347;
                                                    {
                                                        let v348: i32 = (v346) + 1_i32;
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
                                                                             Runtime::method29(foldBack(Func2::new(move
                                                                                                                       |b0:
                                                                                                                            char,
                                                                                                                        b1:
                                                                                                                            LrcPtr<Runtime::UH0>|
                                                                                                                       (Runtime::method28())(b0)(b1)),
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
                                                    (indexOf(v304.clone(), string("\n"))) - 1_i32;
                                                Runtime::US7::US7_1(concat(new_array(&[sprintf!("parsing.p_char / expected: \'{}\' / line: {} / col: {}\n{}{}",
                                                                                                                     '\"',
                                                                                                                     v306,
                                                                                                                     v307,
                                                                                                                     v305.clone(),
                                                                                                                     getSlice(v304.clone(),
                                                                                                                              Some(0_i32),
                                                                                                                              Some((if -2_i32
                                                                                                                                           ==
                                                                                                                                           (v387)
                                                                                                                                       {
                                                                                                                                        (length(v304.clone()))
                                                                                                                                            +
                                                                                                                                            1_i32
                                                                                                                                    } else {
                                                                                                                                        (v387)
                                                                                                                                            +
                                                                                                                                            1_i32
                                                                                                                                    })
                                                                                                                                       -
                                                                                                                                       1_i32))),
                                                                                                            string("\n"),
                                                                                                            append(((Runtime::method30((v307)
                                                                                                                                           -
                                                                                                                                           1_i32,
                                                                                                                                       0_i32))(string(""))),
                                                                                                                   string("^")),
                                                                                                            string("\n")])))
                                            }
                                        };
                                        match &v430 {
                                                             Runtime::US7::US7_0(v430_0_0,
                                                                                 v430_0_1,
                                                                                 v430_0_2,
                                                                                 v430_0_3,
                                                                                 v430_0_4)
                                                             =>
                                                             Runtime::US8::US8_0(v302_0_0.clone(),
                                                                                 v430_0_1.clone(),
                                                                                 v430_0_2.clone(),
                                                                                 v430_0_3.clone(),
                                                                                 v430_0_4.clone()),
                                                             Runtime::US7::US7_1(v430_1_0)
                                                             =>
                                                             Runtime::US8::US8_1(sprintf!("parsing.between / expected closing delimiter / e: {:?} / input: {:?} / rest1: {:?} / rest2: {:?}",
                                                                                          v430_1_0.clone(),
                                                                                          (v1_1.get().clone(),
                                                                                           v2_1.get().clone(),
                                                                                           v3.get().clone(),
                                                                                           v4.get().clone()),
                                                                                          (v270.clone(),
                                                                                           v271.clone(),
                                                                                           v272,
                                                                                           v273),
                                                                                          (v304.clone(),
                                                                                           v305.clone(),
                                                                                           v306,
                                                                                           v307))),
                                                         }
                                    }
                                    _ => Runtime::US8::US8_1(string(
                                        "parsing.between / expected content",
                                    )),
                                }
                            }
                            Runtime::US7::US7_1(v268_1_0) => Runtime::US8::US8_1(v268_1_0.clone()),
                        };
                        match &v452 {
                            Runtime::US8::US8_0(
                                v452_0_0,
                                v452_0_1,
                                v452_0_2,
                                v452_0_3,
                                v452_0_4,
                            ) => v452.clone(),
                            _ => {
                                let v464: Runtime::US8 = Runtime::method66(
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
                                let v475: Runtime::US8 = match &v464 {
                                    Runtime::US8::US8_0(
                                        v464_0_0,
                                        v464_0_1,
                                        v464_0_2,
                                        v464_0_3,
                                        v464_0_4,
                                    ) => Runtime::US8::US8_0(
                                        string(""),
                                        v464_0_1.clone(),
                                        v464_0_2.clone(),
                                        v464_0_3.clone(),
                                        v464_0_4.clone(),
                                    ),
                                    Runtime::US8::US8_1(v464_1_0) => {
                                        Runtime::US8::US8_1(v464_1_0.clone())
                                    }
                                };
                                let v486: Runtime::US17 = match &v475 {
                                    Runtime::US8::US8_0(
                                        v475_0_0,
                                        v475_0_1,
                                        v475_0_2,
                                        v475_0_3,
                                        v475_0_4,
                                    ) => Runtime::method69(
                                        LrcPtr::new(Runtime::UH2::UH2_0),
                                        v475_0_1.clone(),
                                        v475_0_2.clone(),
                                        v475_0_3.clone(),
                                        v475_0_4.clone(),
                                    ),
                                    Runtime::US8::US8_1(v475_1_0) => {
                                        Runtime::US17::US17_1(v475_1_0.clone())
                                    }
                                };
                                match &v486 {
                                    Runtime::US17::US17_0(
                                        v486_0_0,
                                        v486_0_1,
                                        v486_0_2,
                                        v486_0_3,
                                        v486_0_4,
                                    ) => {
                                        let v493: List<string> =
                                            Runtime::method68(v486_0_0.clone(), empty::<string>());
                                        Runtime::US8::US8_0(
                                            join(
                                                string(""),
                                                toArray_1(delay(Func0::new({
                                                    let v493 = v493.clone();
                                                    move || ofList(v493.clone()).clone()
                                                }))),
                                            ),
                                            v486_0_1.clone(),
                                            v486_0_2.clone(),
                                            v486_0_3.clone(),
                                            v486_0_4.clone(),
                                        )
                                    }
                                    Runtime::US17::US17_1(v486_1_0) => {
                                        Runtime::US8::US8_1(v486_1_0.clone())
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
                        let v524: i32 = Runtime::method37(v519.clone(), 0_i32);
                        let v552: Runtime::US10 = if 0_i32 == (v524) {
                            Runtime::US10::US10_1(string(
                                "parsing.spaces1 / expected at least one space",
                            ))
                        } else {
                            Runtime::US10::US10_0(
                                getSlice(
                                    v519.clone(),
                                    Some(v524),
                                    Some((length(v519.clone())) - 1_i32),
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
                                continue '_method61;
                            }
                            _ => Runtime::US17::US17_0(
                                Runtime::method67(
                                    v0_1.get().clone(),
                                    LrcPtr::new(Runtime::UH2::UH2_1(
                                        v518.clone(),
                                        LrcPtr::new(Runtime::UH2::UH2_0),
                                    )),
                                ),
                                v519.clone(),
                                v520.clone(),
                                v521,
                                v522,
                            ),
                        }
                    }
                    _ => Runtime::US17::US17_0(
                        Runtime::method67(v0_1.get().clone(), LrcPtr::new(Runtime::UH2::UH2_0)),
                        v1_1.get().clone(),
                        v2_1.get().clone(),
                        v3.get().clone(),
                        v4.get().clone(),
                    ),
                }
            });
        }
    }
    pub fn method60(v0_1: string) -> Runtime::US16 {
        let _v0: MutCell<Option<Option<string>>> = MutCell::new(None::<Option<string>>);
        _v0.set(Some(Some(v0_1)));
        {
            let v18_1: Runtime::US17 = Runtime::method61(
                LrcPtr::new(Runtime::UH2::UH2_0),
                defaultValue(
                    string(""),
                    match &_v0.get().clone() {
                        None => panic!("{}", string("optionm\'.of_obj / _v0=None"),),
                        Some(_v0_0_0) => _v0_0_0.clone(),
                    },
                ),
                StringBuilder::_ctor__Z721C83C5(Runtime::method26()),
                1_i32,
                1_i32,
            );
            match &v18_1 {
                Runtime::US17::US17_0(v18_1_0_0, v18_1_0_1, v18_1_0_2, v18_1_0_3, v18_1_0_4) => {
                    Runtime::US16::US16_0(toArray(Runtime::method68(
                        v18_1_0_0.clone(),
                        empty::<string>(),
                    )))
                }
                Runtime::US17::US17_1(v18_1_1_0) => Runtime::US16::US16_1(v18_1_1_0.clone()),
            }
        }
    }
    pub fn closure29(unitVar: (), v0_1: string) -> Result<Array<string>, string> {
        let v1_1: Runtime::US16 = Runtime::method60(v0_1);
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
