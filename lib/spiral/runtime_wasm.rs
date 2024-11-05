pub mod Runtime {
    use super::*;
    type Async<T> = T;
    use fable_library_rust::DateTime_::DateTime;
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
    use fable_library_rust::TimeSpan_::TimeSpan;
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
    #[derive(Clone, Debug, PartialEq, PartialOrd, Hash, Eq)]
    pub enum US1 {
        US1_0(string),
        US1_1,
    }
    impl core::fmt::Display for Runtime::US1 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Copy, Debug, PartialEq, PartialOrd, Hash, Eq)]
    pub enum US2 {
        US2_0,
        US2_1,
        US2_2,
    }
    impl core::fmt::Display for Runtime::US2 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Copy, Debug, PartialEq, PartialOrd, Hash, Eq)]
    pub enum US3 {
        US3_0(Runtime::US2),
        US3_1(Runtime::US2),
        US3_2(Runtime::US2),
        US3_3(Runtime::US2),
        US3_4(Runtime::US2),
    }
    impl core::fmt::Display for Runtime::US3 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Copy, Debug, PartialEq, PartialOrd, Hash, Eq)]
    pub enum US4 {
        US4_0(Runtime::US0),
        US4_1,
    }
    impl core::fmt::Display for Runtime::US4 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Copy, Debug, PartialEq, PartialOrd, Hash, Eq)]
    pub enum US5 {
        US5_0(i64),
        US5_1,
    }
    impl core::fmt::Display for Runtime::US5 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Debug, PartialEq, PartialOrd, Hash, Eq)]
    pub enum US6 {
        US6_0(string, Runtime::US1),
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
            Runtime::US1,
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
        US13_0(Runtime::US1, string, LrcPtr<StringBuilder>, i32, i32),
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
    pub fn method1() -> string {
        string("TRACE_LEVEL")
    }
    pub fn method3() -> string {
        string("")
    }
    pub fn closure1(unitVar: (), v0_1: string) -> Runtime::US1 {
        Runtime::US1::US1_0(v0_1)
    }
    pub fn method4() -> Func1<string, Runtime::US1> {
        Func1::new(move |v: string| Runtime::closure1((), v))
    }
    pub fn method2(v0_1: string) -> string {
        let v18_1: Result<std::string::String, std::env::VarError> = std::env::var(&*v0_1);
        let v20_1: bool = true;
        let _result_map_ = v18_1.map(|x| {
            //;
            let v22: std::string::String = x;
            let v24: string = fable_library_rust::String_::fromString(v22);
            let v26: bool = true;
            v24
        });
        let v28: Result<string, std::env::VarError> = _result_map_;
        let v29: string = Runtime::method3();
        v28.unwrap_or(v29)
    }
    pub fn method5() -> string {
        string("AUTOMATION")
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
        let _v1: (Runtime::US4, Runtime::US5) = (Runtime::US4::US4_1, Runtime::US5::US5_1);
        let v425: Runtime::US5 = _v1.1.clone();
        let v424: Runtime::US4 = _v1.0.clone();
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
                l0: MutCell::new(match &v424 {
                    Runtime::US4::US4_0(v424_0_0) => match &v424 {
                        Runtime::US4::US4_0(x) => x.clone(),
                        _ => unreachable!(),
                    },
                    _ => v0_1,
                }),
            }),
            match &v425 {
                Runtime::US5::US5_0(v425_0_0) => Some(match &v425 {
                    Runtime::US5::US5_0(x) => x.clone(),
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
    pub fn method6(v0_1: Runtime::US0) -> bool {
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
    pub fn closure6(unitVar: (), v0_1: i64) -> Runtime::US5 {
        Runtime::US5::US5_0(v0_1)
    }
    pub fn method8() -> Func1<i64, Runtime::US5> {
        Func1::new(move |v: i64| Runtime::closure6((), v))
    }
    pub fn method9() -> string {
        string("hh:mm:ss")
    }
    pub fn method10() -> string {
        string("HH:mm:ss")
    }
    pub fn method7(
        v0_1: LrcPtr<Runtime::Mut0>,
        v1_1: LrcPtr<Runtime::Mut1>,
        v2_1: LrcPtr<Runtime::Mut2>,
        v3: LrcPtr<Runtime::Mut3>,
        v4: LrcPtr<Runtime::Mut4>,
        v5: Option<i64>,
    ) -> string {
        let v81: Runtime::US5 = defaultValue(Runtime::US5::US5_1, map(Runtime::method8(), v5));
        let v121: DateTime = match &v81 {
            Runtime::US5::US5_0(v81_0_0) => {
                let v95: TimeSpan = TimeSpan::new_ticks(
                    {
                        let _arg: DateTime = DateTime::now();
                        _arg.ticks()
                    } - match &v81 {
                        Runtime::US5::US5_0(x) => x.clone(),
                        _ => unreachable!(),
                    },
                );
                DateTime::new_ymdhms_milli(
                    1_i32,
                    1_i32,
                    1_i32,
                    v95.hours(),
                    v95.minutes(),
                    v95.seconds(),
                    v95.milliseconds(),
                )
            }
            _ => DateTime::now(),
        };
        let provider: string = Runtime::method9();
        v121.toString(provider)
    }
    pub fn method13() -> string {
        string("")
    }
    pub fn closure7(v0_1: LrcPtr<Runtime::Mut3>, v1_1: string, unitVar: ()) {
        let v3: string = append(v0_1.l0.get().clone(), v1_1);
        v0_1.l0.set(v3);
        ()
    }
    pub fn method12(v0_1: char) -> string {
        let v2_1: LrcPtr<Runtime::Mut3> = LrcPtr::new(Runtime::Mut3 {
            l0: MutCell::new(Runtime::method13()),
        });
        let v8: () = {
            Runtime::closure7(v2_1.clone(), sprintf!("{}", v0_1), ());
            ()
        };
        v2_1.l0.get().clone()
    }
    pub fn method14() -> string {
        string("\u{001b}[0m")
    }
    pub fn method11() -> string {
        let v6: string = Runtime::method12(getCharAt(toLower(string("Warning")), 0_i32));
        let v41: &str = inline_colorization::color_yellow;
        let v46: &str = &*v6;
        let v67: &str = inline_colorization::color_reset;
        let v69: std::string::String = format!("{}{}{}", v41, v46, v67);
        fable_library_rust::String_::fromString(v69)
    }
    pub fn method16() -> string {
        let v1_1: LrcPtr<Runtime::Mut3> = LrcPtr::new(Runtime::Mut3 {
            l0: MutCell::new(Runtime::method13()),
        });
        v1_1.l0.get().clone()
    }
    pub fn method17(v0_1: string) -> string {
        trimEndChars(
            trimStartChars(v0_1, toArray(empty::<char>())),
            toArray(ofArray(new_array(&[' ', '/']))),
        )
    }
    pub fn method15(
        v0_1: LrcPtr<Runtime::Mut0>,
        v1_1: LrcPtr<Runtime::Mut1>,
        v2_1: LrcPtr<Runtime::Mut2>,
        v3: LrcPtr<Runtime::Mut3>,
        v4: LrcPtr<Runtime::Mut4>,
        v5: Option<i64>,
        v6: string,
        v7: string,
    ) -> string {
        let v8: string = Runtime::method16();
        Runtime::method17(sprintf!(
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
    pub fn method18(v0_1: string) {
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
        let v37: () = {
            Runtime::closure8(patternInput.0.clone(), ());
            ()
        };
        println!("{}", v0_1.clone());
        ();
        ((patternInput.1.clone()).l0.get().clone())(v0_1)
    }
    pub fn closure5(unitVar: (), unitVar_1: ()) {
        if Runtime::method6(Runtime::US0::US0_3) {
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
            Runtime::method18(Runtime::method15(
                v18_1.clone(),
                v19_1.clone(),
                v20_1.clone(),
                v21.clone(),
                v22.clone(),
                v23.clone(),
                Runtime::method7(v18_1, v19_1, v20_1, v21, v22, v23),
                Runtime::method11(),
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
        let v8: string = Runtime::method16();
        Runtime::method17(sprintf!(
            "{} {} #{} {} / {}",
            v6,
            v7,
            v0_1.l0.get().clone(),
            string("runtime.current_process_kill / exiting... 2"),
            v8
        ))
    }
    pub fn closure11(unitVar: (), unitVar_1: ()) {
        if Runtime::method6(Runtime::US0::US0_3) {
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
            Runtime::method18(Runtime::method19(
                v18_1.clone(),
                v19_1.clone(),
                v20_1.clone(),
                v21.clone(),
                v22.clone(),
                v23.clone(),
                Runtime::method7(v18_1, v19_1, v20_1, v21, v22, v23),
                Runtime::method11(),
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
        let v8: string = Runtime::method16();
        Runtime::method17(sprintf!(
            "{} {} #{} {} / {}",
            v6,
            v7,
            v0_1.l0.get().clone(),
            string("runtime.current_process_kill / exiting... 1"),
            v8
        ))
    }
    pub fn closure12(unitVar: (), unitVar_1: ()) {
        if Runtime::method6(Runtime::US0::US0_3) {
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
            Runtime::method18(Runtime::method20(
                v18_1.clone(),
                v19_1.clone(),
                v20_1.clone(),
                v21.clone(),
                v22.clone(),
                v23.clone(),
                Runtime::method7(v18_1, v19_1, v20_1, v21, v22, v23),
                Runtime::method11(),
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
    pub fn method23() -> string {
        string("")
    }
    pub fn method24(v0_1: i32, v1_1: LrcPtr<Runtime::Mut5>) -> bool {
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
    pub fn method25() -> Func1<char, Func1<LrcPtr<Runtime::UH0>, LrcPtr<Runtime::UH0>>> {
        Func1::new(move |v: char| Runtime::closure15((), v))
    }
    pub fn method26(
        v0_1: LrcPtr<Runtime::UH0>,
        v1_1: LrcPtr<StringBuilder>,
        v2_1: i32,
        v3: i32,
    ) -> (LrcPtr<StringBuilder>, i32, i32) {
        let v0_1: MutCell<LrcPtr<Runtime::UH0>> = MutCell::new(v0_1.clone());
        let v1_1: MutCell<LrcPtr<StringBuilder>> = MutCell::new(v1_1.clone());
        let v2_1: MutCell<i32> = MutCell::new(v2_1);
        let v3: MutCell<i32> = MutCell::new(v3);
        '_method26: loop {
            break '_method26 (match v0_1.get().clone().as_ref() {
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
                            let v18_1: LrcPtr<StringBuilder> = {
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
                        continue '_method26;
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
                "parsing.p_char / unexpected end of input / s: {:?}",
                (v1_1.clone(), v2_1, v3)
            ))
        } else {
            let v7: char = getCharAt(v0_1.clone(), 0_i32);
            if v7 == '\"' {
                let v15: string = getSlice(v0_1.clone(), Some(1_i32), Some(length(v0_1.clone())));
                let v17_1: string = ofChar(v7);
                let v20_1: i32 = length(v17_1.clone());
                let v21: Array<char> = new_init(&'\u{0000}', v20_1);
                let v22: LrcPtr<Runtime::Mut5> = LrcPtr::new(Runtime::Mut5 {
                    l0: MutCell::new(0_i32),
                });
                while Runtime::method24(v20_1, v22.clone()) {
                    let v24: i32 = v22.l0.get().clone();
                    let v25: char = getCharAt(v17_1.clone(), v24);
                    v21.get_mut()[v24 as usize] = v25;
                    {
                        let v26: i32 = v24 + 1_i32;
                        v22.l0.set(v26);
                        ()
                    }
                }
                {
                    let v27: List<char> = ofArray(v21.clone());
                    let patternInput: (LrcPtr<StringBuilder>, i32, i32) = Runtime::method26(
                        foldBack(
                            Func2::new(move |b0: char, b1: LrcPtr<Runtime::UH0>| {
                                (Runtime::method25())(b0)(b1)
                            }),
                            v27,
                            LrcPtr::new(Runtime::UH0::UH0_0),
                        ),
                        v1_1.clone(),
                        v2_1,
                        v3,
                    );
                    Runtime::US7::US7_0(
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
                Runtime::US7::US7_1(sprintf!(
                    "{}\n{}\n",
                    sprintf!(
                        "parsing.p_char / expected: \'{}\' / line: {} / col: {}\n{}{}",
                        '\"',
                        v2_1,
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
    pub fn closure17(unitVar: (), _arg: (string, LrcPtr<StringBuilder>, i32, i32)) -> Runtime::US7 {
        let v3: i32 = _arg.3.clone();
        let v2_1: i32 = _arg.2.clone();
        let v1_1: LrcPtr<StringBuilder> = _arg.1.clone();
        let v0_1: string = _arg.0.clone();
        if string("") == v0_1.clone() {
            Runtime::US7::US7_1(sprintf!(
                "parsing.p_char / unexpected end of input / s: {:?}",
                (v1_1.clone(), v2_1, v3)
            ))
        } else {
            let v7: char = getCharAt(v0_1.clone(), 0_i32);
            if v7 == '\'' {
                let v15: string = getSlice(v0_1.clone(), Some(1_i32), Some(length(v0_1.clone())));
                let v17_1: string = ofChar(v7);
                let v20_1: i32 = length(v17_1.clone());
                let v21: Array<char> = new_init(&'\u{0000}', v20_1);
                let v22: LrcPtr<Runtime::Mut5> = LrcPtr::new(Runtime::Mut5 {
                    l0: MutCell::new(0_i32),
                });
                while Runtime::method24(v20_1, v22.clone()) {
                    let v24: i32 = v22.l0.get().clone();
                    let v25: char = getCharAt(v17_1.clone(), v24);
                    v21.get_mut()[v24 as usize] = v25;
                    {
                        let v26: i32 = v24 + 1_i32;
                        v22.l0.set(v26);
                        ()
                    }
                }
                {
                    let v27: List<char> = ofArray(v21.clone());
                    let patternInput: (LrcPtr<StringBuilder>, i32, i32) = Runtime::method26(
                        foldBack(
                            Func2::new(move |b0: char, b1: LrcPtr<Runtime::UH0>| {
                                (Runtime::method25())(b0)(b1)
                            }),
                            v27,
                            LrcPtr::new(Runtime::UH0::UH0_0),
                        ),
                        v1_1.clone(),
                        v2_1,
                        v3,
                    );
                    Runtime::US7::US7_0(
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
                Runtime::US7::US7_1(sprintf!(
                    "{}\n{}\n",
                    sprintf!(
                        "parsing.p_char / expected: \'{}\' / line: {} / col: {}\n{}{}",
                        '\'',
                        v2_1,
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
    pub fn method27(
        v0_1: string,
        v1_1: LrcPtr<StringBuilder>,
        v2_1: LrcPtr<Runtime::UH1>,
    ) -> Runtime::US7 {
        let v0_1: MutCell<string> = MutCell::new(v0_1.clone());
        let v1_1: MutCell<LrcPtr<StringBuilder>> = MutCell::new(v1_1.clone());
        let v2_1: MutCell<LrcPtr<Runtime::UH1>> = MutCell::new(v2_1.clone());
        '_method27: loop {
            break '_method27 (match v2_1.get().clone().as_ref() {
                Runtime::UH1::UH1_0 => Runtime::US7::US7_1(string("choice / no parsers succeeded")),
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
                            continue '_method27;
                        }
                    }
                }
            });
        }
    }
    pub fn method28(v0_1: char, v1_1: i64) -> bool {
        let v0_1: MutCell<char> = MutCell::new(v0_1);
        let v1_1: MutCell<i64> = MutCell::new(v1_1);
        '_method28: loop {
            break '_method28 (if v1_1.get().clone() >= 2_i64 {
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
                    continue '_method28;
                }
            });
        }
    }
    pub fn method29(
        v0_1: string,
        v1_1: string,
        v2_1: LrcPtr<StringBuilder>,
        v3: i32,
        v4: i32,
    ) -> Runtime::US8 {
        let v0_1: MutCell<string> = MutCell::new(v0_1.clone());
        let v1_1: MutCell<string> = MutCell::new(v1_1.clone());
        let v2_1: MutCell<LrcPtr<StringBuilder>> = MutCell::new(v2_1.clone());
        let v3: MutCell<i32> = MutCell::new(v3);
        let v4: MutCell<i32> = MutCell::new(v4);
        '_method29: loop {
            break '_method29 ({
                let v70: Runtime::US7 = if string("") == v1_1.get().clone() {
                    Runtime::US7::US7_1(sprintf!(
                        "parsing.none_of / unexpected end of input / chars: {:?} / s: {:?}",
                        toArray(ofArray(new_array(&['\"', '\'']))),
                        (v2_1.get().clone(), v3.get().clone(), v4.get().clone())
                    ))
                } else {
                    let v19_1: char = getCharAt(v1_1.get().clone(), 0_i32);
                    let v26: string = getSlice(
                        v1_1.get().clone(),
                        Some(1_i32),
                        Some(length(v1_1.get().clone())),
                    );
                    if Runtime::method28(v19_1, 0_i64) == false {
                        let v31: string = ofChar(v19_1);
                        let v34: i32 = length(v31.clone());
                        let v35: Array<char> = new_init(&'\u{0000}', v34);
                        let v36: LrcPtr<Runtime::Mut5> = LrcPtr::new(Runtime::Mut5 {
                            l0: MutCell::new(0_i32),
                        });
                        while Runtime::method24(v34, v36.clone()) {
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
                            let patternInput: (LrcPtr<StringBuilder>, i32, i32) = Runtime::method26(
                                foldBack(
                                    Func2::new(move |b0: char, b1: LrcPtr<Runtime::UH0>| {
                                        (Runtime::method25())(b0)(b1)
                                    }),
                                    v41,
                                    LrcPtr::new(Runtime::UH0::UH0_0),
                                ),
                                v2_1.get().clone(),
                                v3.get().clone(),
                                v4.get().clone(),
                            );
                            Runtime::US7::US7_0(
                                v19_1,
                                v26,
                                patternInput.0.clone(),
                                patternInput.1.clone(),
                                patternInput.2.clone(),
                            )
                        }
                    } else {
                        Runtime::US7::US7_1(sprintf!(
                            "parsing.none_of / unexpected char: \'{}\' / chars: {:?} / s: {:?}",
                            v19_1,
                            toArray(ofArray(new_array(&['\"', '\'']))),
                            (v2_1.get().clone(), v3.get().clone(), v4.get().clone())
                        ))
                    }
                };
                let v82: Runtime::US7 = match &v70 {
                    Runtime::US7::US7_0(v70_0_0, v70_0_1, v70_0_2, v70_0_3, v70_0_4) => {
                        let v71: char = v70_0_0.clone();
                        Runtime::US7::US7_0(
                            if '\\' == v71 { '/' } else { v71 },
                            v70_0_1.clone(),
                            v70_0_2.clone(),
                            v70_0_3.clone(),
                            v70_0_4.clone(),
                        )
                    }
                    Runtime::US7::US7_1(v70_1_0) => Runtime::US7::US7_1(v70_1_0.clone()),
                };
                match &v82 {
                    Runtime::US7::US7_0(v82_0_0, v82_0_1, v82_0_2, v82_0_3, v82_0_4) => {
                        let v0_1_temp: string = append(v0_1.get().clone(), ofChar(v82_0_0.clone()));
                        let v1_1_temp: string = v82_0_1.clone();
                        let v2_1_temp: LrcPtr<StringBuilder> = v82_0_2.clone();
                        let v3_temp: i32 = v82_0_3.clone();
                        let v4_temp: i32 = v82_0_4.clone();
                        v0_1.set(v0_1_temp);
                        v1_1.set(v1_1_temp);
                        v2_1.set(v2_1_temp);
                        v3.set(v3_temp);
                        v4.set(v4_temp);
                        continue '_method29;
                    }
                    _ => Runtime::US8::US8_0(
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
    pub fn method30(
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
        '_method30: loop {
            break '_method30 (match v4.get().clone().as_ref() {
                Runtime::UH1::UH1_0 => Runtime::US7::US7_1(string("choice / no parsers succeeded")),
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
                            continue '_method30;
                        }
                    }
                }
            });
        }
    }
    pub fn method31(v0_1: char, v1_1: i64) -> bool {
        let v0_1: MutCell<char> = MutCell::new(v0_1);
        let v1_1: MutCell<i64> = MutCell::new(v1_1);
        '_method31: loop {
            break '_method31 (if v1_1.get().clone() >= 3_i64 {
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
                    continue '_method31;
                }
            });
        }
    }
    pub fn method32(
        v0_1: string,
        v1_1: string,
        v2_1: LrcPtr<StringBuilder>,
        v3: i32,
        v4: i32,
    ) -> Runtime::US8 {
        let v0_1: MutCell<string> = MutCell::new(v0_1.clone());
        let v1_1: MutCell<string> = MutCell::new(v1_1.clone());
        let v2_1: MutCell<LrcPtr<StringBuilder>> = MutCell::new(v2_1.clone());
        let v3: MutCell<i32> = MutCell::new(v3);
        let v4: MutCell<i32> = MutCell::new(v4);
        '_method32: loop {
            break '_method32 ({
                let v76: Runtime::US7 = if string("") == v1_1.get().clone() {
                    Runtime::US7::US7_1(sprintf!(
                        "parsing.none_of / unexpected end of input / chars: {:?} / s: {:?}",
                        toArray(ofArray(new_array(&['\"', '\'', ' ']))),
                        (v2_1.get().clone(), v3.get().clone(), v4.get().clone())
                    ))
                } else {
                    let v22: char = getCharAt(v1_1.get().clone(), 0_i32);
                    let v29: string = getSlice(
                        v1_1.get().clone(),
                        Some(1_i32),
                        Some(length(v1_1.get().clone())),
                    );
                    if Runtime::method31(v22, 0_i64) == false {
                        let v34: string = ofChar(v22);
                        let v37: i32 = length(v34.clone());
                        let v38: Array<char> = new_init(&'\u{0000}', v37);
                        let v39: LrcPtr<Runtime::Mut5> = LrcPtr::new(Runtime::Mut5 {
                            l0: MutCell::new(0_i32),
                        });
                        while Runtime::method24(v37, v39.clone()) {
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
                            let patternInput: (LrcPtr<StringBuilder>, i32, i32) = Runtime::method26(
                                foldBack(
                                    Func2::new(move |b0: char, b1: LrcPtr<Runtime::UH0>| {
                                        (Runtime::method25())(b0)(b1)
                                    }),
                                    v44,
                                    LrcPtr::new(Runtime::UH0::UH0_0),
                                ),
                                v2_1.get().clone(),
                                v3.get().clone(),
                                v4.get().clone(),
                            );
                            Runtime::US7::US7_0(
                                v22,
                                v29,
                                patternInput.0.clone(),
                                patternInput.1.clone(),
                                patternInput.2.clone(),
                            )
                        }
                    } else {
                        Runtime::US7::US7_1(sprintf!(
                            "parsing.none_of / unexpected char: \'{}\' / chars: {:?} / s: {:?}",
                            v22,
                            toArray(ofArray(new_array(&['\"', '\'', ' ']))),
                            (v2_1.get().clone(), v3.get().clone(), v4.get().clone())
                        ))
                    }
                };
                let v88: Runtime::US7 = match &v76 {
                    Runtime::US7::US7_0(v76_0_0, v76_0_1, v76_0_2, v76_0_3, v76_0_4) => {
                        let v77: char = v76_0_0.clone();
                        Runtime::US7::US7_0(
                            if '\\' == v77 { '/' } else { v77 },
                            v76_0_1.clone(),
                            v76_0_2.clone(),
                            v76_0_3.clone(),
                            v76_0_4.clone(),
                        )
                    }
                    Runtime::US7::US7_1(v76_1_0) => Runtime::US7::US7_1(v76_1_0.clone()),
                };
                match &v88 {
                    Runtime::US7::US7_0(v88_0_0, v88_0_1, v88_0_2, v88_0_3, v88_0_4) => {
                        let v0_1_temp: string = append(v0_1.get().clone(), ofChar(v88_0_0.clone()));
                        let v1_1_temp: string = v88_0_1.clone();
                        let v2_1_temp: LrcPtr<StringBuilder> = v88_0_2.clone();
                        let v3_temp: i32 = v88_0_3.clone();
                        let v4_temp: i32 = v88_0_4.clone();
                        v0_1.set(v0_1_temp);
                        v1_1.set(v1_1_temp);
                        v2_1.set(v2_1_temp);
                        v3.set(v3_temp);
                        v4.set(v4_temp);
                        continue '_method32;
                    }
                    _ => Runtime::US8::US8_0(
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
    pub fn method33(v0_1: string, v1_1: i32) -> i32 {
        let v0_1: MutCell<string> = MutCell::new(v0_1.clone());
        let v1_1: MutCell<i32> = MutCell::new(v1_1);
        '_method33: loop {
            break '_method33 (if v1_1.get().clone() >= length(v0_1.get().clone()) {
                v1_1.get().clone()
            } else {
                if getCharAt(v0_1.get().clone(), v1_1.get().clone()) == ' ' {
                    let v0_1_temp: string = v0_1.get().clone();
                    let v1_1_temp: i32 = v1_1.get().clone() + 1_i32;
                    v0_1.set(v0_1_temp);
                    v1_1.set(v1_1_temp);
                    continue '_method33;
                } else {
                    v1_1.get().clone()
                }
            });
        }
    }
    pub fn method34(
        v0_1: string,
        v1_1: string,
        v2_1: LrcPtr<StringBuilder>,
        v3: i32,
        v4: i32,
    ) -> Runtime::US8 {
        let v0_1: MutCell<string> = MutCell::new(v0_1.clone());
        let v1_1: MutCell<string> = MutCell::new(v1_1.clone());
        let v2_1: MutCell<LrcPtr<StringBuilder>> = MutCell::new(v2_1.clone());
        let v3: MutCell<i32> = MutCell::new(v3);
        let v4: MutCell<i32> = MutCell::new(v4);
        '_method34: loop {
            break '_method34 ({
                let v42: Runtime::US7 = if string("") == v1_1.get().clone() {
                    Runtime::US7::US7_1(sprintf!(
                        "parsing.any_char / unexpected end of input / s: {:?}",
                        (v2_1.get().clone(), v3.get().clone(), v4.get().clone())
                    ))
                } else {
                    let v8: char = getCharAt(v1_1.get().clone(), 0_i32);
                    let v15: string = getSlice(
                        v1_1.get().clone(),
                        Some(1_i32),
                        Some(length(v1_1.get().clone())),
                    );
                    let v17_1: string = ofChar(v8);
                    let v20_1: i32 = length(v17_1.clone());
                    let v21: Array<char> = new_init(&'\u{0000}', v20_1);
                    let v22: LrcPtr<Runtime::Mut5> = LrcPtr::new(Runtime::Mut5 {
                        l0: MutCell::new(0_i32),
                    });
                    while Runtime::method24(v20_1, v22.clone()) {
                        let v24: i32 = v22.l0.get().clone();
                        let v25: char = getCharAt(v17_1.clone(), v24);
                        v21.get_mut()[v24 as usize] = v25;
                        {
                            let v26: i32 = v24 + 1_i32;
                            v22.l0.set(v26);
                            ()
                        }
                    }
                    {
                        let v27: List<char> = ofArray(v21.clone());
                        let patternInput: (LrcPtr<StringBuilder>, i32, i32) = Runtime::method26(
                            foldBack(
                                Func2::new(move |b0: char, b1: LrcPtr<Runtime::UH0>| {
                                    (Runtime::method25())(b0)(b1)
                                }),
                                v27,
                                LrcPtr::new(Runtime::UH0::UH0_0),
                            ),
                            v2_1.get().clone(),
                            v3.get().clone(),
                            v4.get().clone(),
                        );
                        Runtime::US7::US7_0(
                            v8,
                            v15,
                            patternInput.0.clone(),
                            patternInput.1.clone(),
                            patternInput.2.clone(),
                        )
                    }
                };
                match &v42 {
                    Runtime::US7::US7_0(v42_0_0, v42_0_1, v42_0_2, v42_0_3, v42_0_4) => {
                        let v0_1_temp: string = append(v0_1.get().clone(), ofChar(v42_0_0.clone()));
                        let v1_1_temp: string = v42_0_1.clone();
                        let v2_1_temp: LrcPtr<StringBuilder> = v42_0_2.clone();
                        let v3_temp: i32 = v42_0_3.clone();
                        let v4_temp: i32 = v42_0_4.clone();
                        v0_1.set(v0_1_temp);
                        v1_1.set(v1_1_temp);
                        v2_1.set(v2_1_temp);
                        v3.set(v3_temp);
                        v4.set(v4_temp);
                        continue '_method34;
                    }
                    _ => Runtime::US8::US8_0(
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
    pub fn method22(v0_1: string) -> Runtime::US6 {
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
            let v12: LrcPtr<StringBuilder> = StringBuilder::_ctor__Z721C83C5(Runtime::method23());
            fn v13(arg10_0040: (string, LrcPtr<StringBuilder>, i32, i32)) -> Runtime::US7 {
                Runtime::closure14((), arg10_0040)
            }
            fn v14(arg10_0040_1: (string, LrcPtr<StringBuilder>, i32, i32)) -> Runtime::US7 {
                Runtime::closure17((), arg10_0040_1)
            }
            let v18_1: Runtime::US7 = Runtime::method27(
                v7.clone(),
                v12.clone(),
                LrcPtr::new(Runtime::UH1::UH1_1(
                    Func1::from(v13),
                    LrcPtr::new(Runtime::UH1::UH1_1(
                        Func1::from(v14),
                        LrcPtr::new(Runtime::UH1::UH1_0),
                    )),
                )),
            );
            let v154: Runtime::US8 = match &v18_1 {
                Runtime::US7::US7_0(v18_1_0_0, v18_1_0_1, v18_1_0_2, v18_1_0_3, v18_1_0_4) => {
                    let v23: i32 = v18_1_0_4.clone();
                    let v22: i32 = v18_1_0_3.clone();
                    let v21: LrcPtr<StringBuilder> = v18_1_0_2.clone();
                    let v20_1: string = v18_1_0_1.clone();
                    let v89: Runtime::US7 = if string("") == v20_1.clone() {
                        Runtime::US7::US7_1(sprintf!(
                            "parsing.none_of / unexpected end of input / chars: {:?} / s: {:?}",
                            toArray(ofArray(new_array(&['\"', '\'']))),
                            (v21.clone(), v22, v23)
                        ))
                    } else {
                        let v38: char = getCharAt(v20_1.clone(), 0_i32);
                        let v45: string =
                            getSlice(v20_1.clone(), Some(1_i32), Some(length(v20_1.clone())));
                        if Runtime::method28(v38, 0_i64) == false {
                            let v50: string = ofChar(v38);
                            let v53: i32 = length(v50.clone());
                            let v54: Array<char> = new_init(&'\u{0000}', v53);
                            let v55: LrcPtr<Runtime::Mut5> = LrcPtr::new(Runtime::Mut5 {
                                l0: MutCell::new(0_i32),
                            });
                            while Runtime::method24(v53, v55.clone()) {
                                let v57: i32 = v55.l0.get().clone();
                                let v58: char = getCharAt(v50.clone(), v57);
                                v54.get_mut()[v57 as usize] = v58;
                                {
                                    let v59: i32 = v57 + 1_i32;
                                    v55.l0.set(v59);
                                    ()
                                }
                            }
                            {
                                let v60: List<char> = ofArray(v54.clone());
                                let patternInput: (LrcPtr<StringBuilder>, i32, i32) =
                                    Runtime::method26(
                                        foldBack(
                                            Func2::new(
                                                move |b0: char, b1: LrcPtr<Runtime::UH0>| {
                                                    (Runtime::method25())(b0)(b1)
                                                },
                                            ),
                                            v60,
                                            LrcPtr::new(Runtime::UH0::UH0_0),
                                        ),
                                        v21.clone(),
                                        v22,
                                        v23,
                                    );
                                Runtime::US7::US7_0(
                                    v38,
                                    v45,
                                    patternInput.0.clone(),
                                    patternInput.1.clone(),
                                    patternInput.2.clone(),
                                )
                            }
                        } else {
                            Runtime::US7::US7_1(sprintf!(
                                "parsing.none_of / unexpected char: \'{}\' / chars: {:?} / s: {:?}",
                                v38,
                                toArray(ofArray(new_array(&['\"', '\'']))),
                                (v21.clone(), v22, v23)
                            ))
                        }
                    };
                    let v101: Runtime::US7 = match &v89 {
                        Runtime::US7::US7_0(v89_0_0, v89_0_1, v89_0_2, v89_0_3, v89_0_4) => {
                            let v90: char = v89_0_0.clone();
                            Runtime::US7::US7_0(
                                if '\\' == v90 { '/' } else { v90 },
                                v89_0_1.clone(),
                                v89_0_2.clone(),
                                v89_0_3.clone(),
                                v89_0_4.clone(),
                            )
                        }
                        Runtime::US7::US7_1(v89_1_0) => Runtime::US7::US7_1(v89_1_0.clone()),
                    };
                    let v115: Runtime::US8 = match &v101 {
                        Runtime::US7::US7_0(v101_0_0, v101_0_1, v101_0_2, v101_0_3, v101_0_4) => {
                            Runtime::method29(
                                ofChar(v101_0_0.clone()),
                                v101_0_1.clone(),
                                v101_0_2.clone(),
                                v101_0_3.clone(),
                                v101_0_4.clone(),
                            )
                        }
                        Runtime::US7::US7_1(v101_1_0) => Runtime::US8::US8_1(v101_1_0.clone()),
                    };
                    let v125: Runtime::US8 = match &v115 {
                        Runtime::US8::US8_0(v115_0_0, v115_0_1, v115_0_2, v115_0_3, v115_0_4) => {
                            Runtime::US8::US8_0(
                                v115_0_0.clone(),
                                v115_0_1.clone(),
                                v115_0_2.clone(),
                                v115_0_3.clone(),
                                v115_0_4.clone(),
                            )
                        }
                        _ => Runtime::US8::US8_0(string(""), v20_1.clone(), v21.clone(), v22, v23),
                    };
                    match &v125 {
                        Runtime::US8::US8_0(v125_0_0, v125_0_1, v125_0_2, v125_0_3, v125_0_4) => {
                            let v130: i32 = v125_0_4.clone();
                            let v129: i32 = v125_0_3.clone();
                            let v128: LrcPtr<StringBuilder> = v125_0_2.clone();
                            let v127: string = v125_0_1.clone();
                            let v134: Runtime::US7 = Runtime::method30(
                                v127.clone(),
                                v128.clone(),
                                v129,
                                v130,
                                LrcPtr::new(Runtime::UH1::UH1_1(
                                    Func1::from(v13),
                                    LrcPtr::new(Runtime::UH1::UH1_1(
                                        Func1::from(v14),
                                        LrcPtr::new(Runtime::UH1::UH1_0),
                                    )),
                                )),
                            );
                            match &v134 {
                                    Runtime::US7::US7_0(v134_0_0, v134_0_1,
                                                        v134_0_2, v134_0_3,
                                                        v134_0_4) =>
                                    Runtime::US8::US8_0(v125_0_0.clone(),
                                                        v134_0_1.clone(),
                                                        v134_0_2.clone(),
                                                        v134_0_3.clone(),
                                                        v134_0_4.clone()),
                                    Runtime::US7::US7_1(v134_1_0) =>
                                    Runtime::US8::US8_1(sprintf!("between / expected closing delimiter / e: {:?} / input: {:?} / rest1: {:?} / rest2: {:?}",
                                                                 v134_1_0.clone(),
                                                                 (v7.clone(),
                                                                  v12.clone(),
                                                                  1_i32,
                                                                  1_i32),
                                                                 (v20_1, v21,
                                                                  v22, v23),
                                                                 (v127, v128,
                                                                  v129,
                                                                  v130))),
                                }
                        }
                        _ => Runtime::US8::US8_1(string("between / expected content")),
                    }
                }
                Runtime::US7::US7_1(v18_1_1_0) => Runtime::US8::US8_1(v18_1_1_0.clone()),
            };
            let v304: Runtime::US8 = match &v154 {
                Runtime::US8::US8_0(v154_0_0, v154_0_1, v154_0_2, v154_0_3, v154_0_4) => {
                    v154.clone()
                }
                _ => {
                    let v234: Runtime::US7 = if string("") == v7.clone() {
                        Runtime::US7::US7_1(sprintf!(
                            "parsing.none_of / unexpected end of input / chars: {:?} / s: {:?}",
                            toArray(ofArray(new_array(&['\"', '\'', ' ']))),
                            (v12.clone(), 1_i32, 1_i32)
                        ))
                    } else {
                        let v178: char = getCharAt(v7.clone(), 0_i32);
                        let v185: string =
                            getSlice(v7.clone(), Some(1_i32), Some(length(v7.clone())));
                        if Runtime::method31(v178, 0_i64) == false {
                            let v190: string = ofChar(v178);
                            let v193: i32 = length(v190.clone());
                            let v194: Array<char> = new_init(&'\u{0000}', v193);
                            let v195: LrcPtr<Runtime::Mut5> = LrcPtr::new(Runtime::Mut5 {
                                l0: MutCell::new(0_i32),
                            });
                            while Runtime::method24(v193, v195.clone()) {
                                let v197: i32 = v195.l0.get().clone();
                                let v198: char = getCharAt(v190.clone(), v197);
                                v194.get_mut()[v197 as usize] = v198;
                                {
                                    let v199: i32 = v197 + 1_i32;
                                    v195.l0.set(v199);
                                    ()
                                }
                            }
                            {
                                let v200: List<char> = ofArray(v194.clone());
                                let patternInput_1: (LrcPtr<StringBuilder>, i32, i32) =
                                    Runtime::method26(
                                        foldBack(
                                            Func2::new(
                                                move |b0: char, b1: LrcPtr<Runtime::UH0>| {
                                                    (Runtime::method25())(b0)(b1)
                                                },
                                            ),
                                            v200,
                                            LrcPtr::new(Runtime::UH0::UH0_0),
                                        ),
                                        v12.clone(),
                                        1_i32,
                                        1_i32,
                                    );
                                Runtime::US7::US7_0(
                                    v178,
                                    v185,
                                    patternInput_1.0.clone(),
                                    patternInput_1.1.clone(),
                                    patternInput_1.2.clone(),
                                )
                            }
                        } else {
                            Runtime::US7::US7_1(sprintf!(
                                "parsing.none_of / unexpected char: \'{}\' / chars: {:?} / s: {:?}",
                                v178,
                                toArray(ofArray(new_array(&['\"', '\'', ' ']))),
                                (v12.clone(), 1_i32, 1_i32)
                            ))
                        }
                    };
                    let v246: Runtime::US7 = match &v234 {
                        Runtime::US7::US7_0(v234_0_0, v234_0_1, v234_0_2, v234_0_3, v234_0_4) => {
                            let v235: char = v234_0_0.clone();
                            Runtime::US7::US7_0(
                                if '\\' == v235 { '/' } else { v235 },
                                v234_0_1.clone(),
                                v234_0_2.clone(),
                                v234_0_3.clone(),
                                v234_0_4.clone(),
                            )
                        }
                        Runtime::US7::US7_1(v234_1_0) => Runtime::US7::US7_1(v234_1_0.clone()),
                    };
                    let v260: Runtime::US8 = match &v246 {
                        Runtime::US7::US7_0(v246_0_0, v246_0_1, v246_0_2, v246_0_3, v246_0_4) => {
                            Runtime::method32(
                                ofChar(v246_0_0.clone()),
                                v246_0_1.clone(),
                                v246_0_2.clone(),
                                v246_0_3.clone(),
                                v246_0_4.clone(),
                            )
                        }
                        Runtime::US7::US7_1(v246_1_0) => Runtime::US8::US8_1(v246_1_0.clone()),
                    };
                    match &v260 {
                        Runtime::US8::US8_0(v260_0_0, v260_0_1, v260_0_2, v260_0_3, v260_0_4) => {
                            v260.clone()
                        }
                        _ => {
                            let v272: Runtime::US10 = if length(v7.clone()) == 0_i32 {
                                Runtime::US10::US10_0(v7.clone(), v12.clone(), 1_i32, 1_i32)
                            } else {
                                Runtime::US10::US10_1(sprintf!(
                                    "parsing.eof / expected end of input / input: {:?}",
                                    v7.clone()
                                ))
                            };
                            let v281: Runtime::US8 = match &v272 {
                                Runtime::US10::US10_0(v272_0_0, v272_0_1, v272_0_2, v272_0_3) => {
                                    Runtime::US8::US8_0(
                                        string(""),
                                        v272_0_0.clone(),
                                        v272_0_1.clone(),
                                        v272_0_2.clone(),
                                        v272_0_3.clone(),
                                    )
                                }
                                Runtime::US10::US10_1(v272_1_0) => {
                                    Runtime::US8::US8_1(v272_1_0.clone())
                                }
                            };
                            match &v281 {
                                Runtime::US8::US8_0(
                                    v281_0_0,
                                    v281_0_1,
                                    v281_0_2,
                                    v281_0_3,
                                    v281_0_4,
                                ) => {
                                    let v283: string = v281_0_1.clone();
                                    Runtime::US8::US8_0(
                                        v281_0_0.clone(),
                                        getSlice(
                                            v283.clone(),
                                            Some(Runtime::method33(v283.clone(), 0_i32)),
                                            Some(length(v283)),
                                        ),
                                        v281_0_2.clone(),
                                        v281_0_3.clone(),
                                        v281_0_4.clone(),
                                    )
                                }
                                Runtime::US8::US8_1(v281_1_0) => {
                                    Runtime::US8::US8_1(v281_1_0.clone())
                                }
                            }
                        }
                    }
                }
            };
            let v472: Runtime::US11 = match &v304 {
                Runtime::US8::US8_0(v304_0_0, v304_0_1, v304_0_2, v304_0_3, v304_0_4) => {
                    let v309: i32 = v304_0_4.clone();
                    let v308: i32 = v304_0_3.clone();
                    let v307: LrcPtr<StringBuilder> = v304_0_2.clone();
                    let v306: string = v304_0_1.clone();
                    let v373: Runtime::US7 = if string("") == v306.clone() {
                        Runtime::US7::US7_1(sprintf!(
                            "parsing.p_char / unexpected end of input / s: {:?}",
                            (v307.clone(), v308, v309)
                        ))
                    } else {
                        let v313: char = getCharAt(v306.clone(), 0_i32);
                        if v313 == ' ' {
                            let v321: string =
                                getSlice(v306.clone(), Some(1_i32), Some(length(v306.clone())));
                            let v323: string = ofChar(v313);
                            let v326: i32 = length(v323.clone());
                            let v327: Array<char> = new_init(&'\u{0000}', v326);
                            let v328: LrcPtr<Runtime::Mut5> = LrcPtr::new(Runtime::Mut5 {
                                l0: MutCell::new(0_i32),
                            });
                            while Runtime::method24(v326, v328.clone()) {
                                let v330: i32 = v328.l0.get().clone();
                                let v331: char = getCharAt(v323.clone(), v330);
                                v327.get_mut()[v330 as usize] = v331;
                                {
                                    let v332: i32 = v330 + 1_i32;
                                    v328.l0.set(v332);
                                    ()
                                }
                            }
                            {
                                let v333: List<char> = ofArray(v327.clone());
                                let patternInput_2: (LrcPtr<StringBuilder>, i32, i32) =
                                    Runtime::method26(
                                        foldBack(
                                            Func2::new(
                                                move |b0: char, b1: LrcPtr<Runtime::UH0>| {
                                                    (Runtime::method25())(b0)(b1)
                                                },
                                            ),
                                            v333,
                                            LrcPtr::new(Runtime::UH0::UH0_0),
                                        ),
                                        v307.clone(),
                                        v308,
                                        v309,
                                    );
                                Runtime::US7::US7_0(
                                    v313,
                                    v321,
                                    patternInput_2.0.clone(),
                                    patternInput_2.1.clone(),
                                    patternInput_2.2.clone(),
                                )
                            }
                        } else {
                            let v349: i32 = length(v306.clone());
                            let v352: i32 = indexOf(v306.clone(), string("\n")) - 1_i32;
                            Runtime::US7::US7_1(sprintf!(
                                "{}\n{}\n",
                                sprintf!(
                                    "parsing.p_char / expected: \'{}\' / line: {} / col: {}\n{}{}",
                                    ' ',
                                    v308,
                                    v309,
                                    v307.clone(),
                                    getSlice(
                                        v306.clone(),
                                        Some(0_i32),
                                        Some(if -2_i32 == v352 { v349 } else { v352 })
                                    )
                                ),
                                append(replicate(v309 - 1_i32, string(" ")), string("^"))
                            ))
                        }
                    };
                    let v385: Runtime::US12 = match &v373 {
                        Runtime::US7::US7_0(v373_0_0, v373_0_1, v373_0_2, v373_0_3, v373_0_4) => {
                            Runtime::US12::US12_0(
                                Runtime::US9::US9_0(v373_0_0.clone()),
                                v373_0_1.clone(),
                                v373_0_2.clone(),
                                v373_0_3.clone(),
                                v373_0_4.clone(),
                            )
                        }
                        _ => Runtime::US12::US12_0(
                            Runtime::US9::US9_1,
                            v306.clone(),
                            v307.clone(),
                            v308,
                            v309,
                        ),
                    };
                    let v446: Runtime::US8 = match &v385 {
                        Runtime::US12::US12_0(v385_0_0, v385_0_1, v385_0_2, v385_0_3, v385_0_4) => {
                            let v390: i32 = v385_0_4.clone();
                            let v389: i32 = v385_0_3.clone();
                            let v388: LrcPtr<StringBuilder> = v385_0_2.clone();
                            let v387: string = v385_0_1.clone();
                            let v428: Runtime::US7 = if string("") == v387.clone() {
                                Runtime::US7::US7_1(sprintf!(
                                    "parsing.any_char / unexpected end of input / s: {:?}",
                                    (v388.clone(), v389, v390)
                                ))
                            } else {
                                let v394: char = getCharAt(v387.clone(), 0_i32);
                                let v401: string =
                                    getSlice(v387.clone(), Some(1_i32), Some(length(v387)));
                                let v403: string = ofChar(v394);
                                let v406: i32 = length(v403.clone());
                                let v407: Array<char> = new_init(&'\u{0000}', v406);
                                let v408: LrcPtr<Runtime::Mut5> = LrcPtr::new(Runtime::Mut5 {
                                    l0: MutCell::new(0_i32),
                                });
                                while Runtime::method24(v406, v408.clone()) {
                                    let v410: i32 = v408.l0.get().clone();
                                    let v411: char = getCharAt(v403.clone(), v410);
                                    v407.get_mut()[v410 as usize] = v411;
                                    {
                                        let v412: i32 = v410 + 1_i32;
                                        v408.l0.set(v412);
                                        ()
                                    }
                                }
                                {
                                    let v413: List<char> = ofArray(v407.clone());
                                    let patternInput_3: (LrcPtr<StringBuilder>, i32, i32) =
                                        Runtime::method26(
                                            foldBack(
                                                Func2::new(
                                                    move |b0: char, b1: LrcPtr<Runtime::UH0>| {
                                                        (Runtime::method25())(b0)(b1)
                                                    },
                                                ),
                                                v413,
                                                LrcPtr::new(Runtime::UH0::UH0_0),
                                            ),
                                            v388,
                                            v389,
                                            v390,
                                        );
                                    Runtime::US7::US7_0(
                                        v394,
                                        v401,
                                        patternInput_3.0.clone(),
                                        patternInput_3.1.clone(),
                                        patternInput_3.2.clone(),
                                    )
                                }
                            };
                            match &v428 {
                                Runtime::US7::US7_0(
                                    v428_0_0,
                                    v428_0_1,
                                    v428_0_2,
                                    v428_0_3,
                                    v428_0_4,
                                ) => Runtime::method34(
                                    ofChar(v428_0_0.clone()),
                                    v428_0_1.clone(),
                                    v428_0_2.clone(),
                                    v428_0_3.clone(),
                                    v428_0_4.clone(),
                                ),
                                Runtime::US7::US7_1(v428_1_0) => {
                                    Runtime::US8::US8_1(v428_1_0.clone())
                                }
                            }
                        }
                        Runtime::US12::US12_1(v385_1_0) => Runtime::US8::US8_1(v385_1_0.clone()),
                    };
                    let v458: Runtime::US13 = match &v446 {
                        Runtime::US8::US8_0(v446_0_0, v446_0_1, v446_0_2, v446_0_3, v446_0_4) => {
                            Runtime::US13::US13_0(
                                Runtime::US1::US1_0(v446_0_0.clone()),
                                v446_0_1.clone(),
                                v446_0_2.clone(),
                                v446_0_3.clone(),
                                v446_0_4.clone(),
                            )
                        }
                        _ => Runtime::US13::US13_0(Runtime::US1::US1_1, v306, v307, v308, v309),
                    };
                    match &v458 {
                        Runtime::US13::US13_0(v458_0_0, v458_0_1, v458_0_2, v458_0_3, v458_0_4) => {
                            Runtime::US11::US11_0(
                                v304_0_0.clone(),
                                v458_0_0.clone(),
                                v458_0_1.clone(),
                                v458_0_2.clone(),
                                v458_0_3.clone(),
                                v458_0_4.clone(),
                            )
                        }
                        Runtime::US13::US13_1(v458_1_0) => Runtime::US11::US11_1(v458_1_0.clone()),
                    }
                }
                Runtime::US8::US8_1(v304_1_0) => Runtime::US11::US11_1(v304_1_0.clone()),
            };
            match &v472 {
                Runtime::US11::US11_0(
                    v472_0_0,
                    v472_0_1,
                    v472_0_2,
                    v472_0_3,
                    v472_0_4,
                    v472_0_5,
                ) => Runtime::US6::US6_0(v472_0_0.clone(), v472_0_1.clone()),
                Runtime::US11::US11_1(v472_1_0) => Runtime::US6::US6_1(v472_1_0.clone()),
            }
        }
    }
    pub fn method35() -> string {
        let v6: string = Runtime::method12(getCharAt(toLower(string("Debug")), 0_i32));
        let v41: &str = inline_colorization::color_bright_blue;
        let v46: &str = &*v6;
        let v67: &str = inline_colorization::color_reset;
        let v69: std::string::String = format!("{}{}{}", v41, v46, v67);
        fable_library_rust::String_::fromString(v69)
    }
    pub fn method37(
        v0_1: string,
        v1_1: Runtime::US1,
        v2_1: string,
        v3: Option<CancellationToken>,
        v4: Array<(string, string)>,
        v5: Option<Func1<(i32, string, bool), Arc<Async<()>>>>,
        v6: Option<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
        v7: bool,
        v8: Option<string>,
    ) -> string {
        let v10: LrcPtr<Runtime::Mut3> = LrcPtr::new(Runtime::Mut3 {
            l0: MutCell::new(Runtime::method13()),
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
        let v172: std::string::String = format!("{:#?}", v3);
        let v201: () = {
            Runtime::closure7(
                v10.clone(),
                sprintf!("{}", fable_library_rust::String_::fromString(v172)),
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
        let v271: std::string::String = format!("{:#?}", v5);
        let v300: () = {
            Runtime::closure7(
                v10.clone(),
                sprintf!("{}", fable_library_rust::String_::fromString(v271)),
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
        let v334: std::string::String = format!("{:#?}", v6);
        let v363: () = {
            Runtime::closure7(
                v10.clone(),
                sprintf!("{}", fable_library_rust::String_::fromString(v334)),
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
        let v433: std::string::String = format!("{:#?}", v8);
        let v462: () = {
            Runtime::closure7(
                v10.clone(),
                sprintf!("{}", fable_library_rust::String_::fromString(v433)),
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
    pub fn method36(
        v0_1: LrcPtr<Runtime::Mut0>,
        v1_1: LrcPtr<Runtime::Mut1>,
        v2_1: LrcPtr<Runtime::Mut2>,
        v3: LrcPtr<Runtime::Mut3>,
        v4: LrcPtr<Runtime::Mut4>,
        v5: Option<i64>,
        v6: string,
        v7: string,
        v8: string,
        v9: Runtime::US1,
        v10: string,
        v11: Option<CancellationToken>,
        v12: Array<(string, string)>,
        v13: Option<Func1<(i32, string, bool), Arc<Async<()>>>>,
        v14: Option<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
        v15: bool,
        v16_1: Option<string>,
    ) -> string {
        let v17_1: string = Runtime::method37(v8, v9, v10, v11, v12, v13, v14, v15, v16_1);
        Runtime::method17(sprintf!(
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
        v7: Runtime::US1,
        v8: string,
        unitVar: (),
    ) {
        if Runtime::method6(Runtime::US0::US0_1) {
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
            Runtime::method18(Runtime::method36(
                v27.clone(),
                v28.clone(),
                v29.clone(),
                v30.clone(),
                v31.clone(),
                v32.clone(),
                Runtime::method7(v27, v28, v29, v30, v31, v32),
                Runtime::method35(),
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
    pub fn method38(
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
    pub fn method39() -> Func1<Func1<(i32, string, bool), Arc<Async<()>>>, Runtime::US14> {
        Func1::new(move |v: Func1<(i32, string, bool), Arc<Async<()>>>| Runtime::closure20((), v))
    }
    pub fn method40() -> string {
        let v6: string = Runtime::method12(getCharAt(toLower(string("Verbose")), 0_i32));
        let v41: &str = inline_colorization::color_bright_black;
        let v46: &str = &*v6;
        let v67: &str = inline_colorization::color_reset;
        let v69: std::string::String = format!("{}{}{}", v41, v46, v67);
        fable_library_rust::String_::fromString(v69)
    }
    pub fn method41(
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
        let v9: string = Runtime::method16();
        Runtime::method17(sprintf!(
            "{} {} #{} {} / {}",
            v6,
            v7,
            v0_1.l0.get().clone(),
            v8,
            v9
        ))
    }
    pub fn closure21(v0_1: string, unitVar: ()) {
        if Runtime::method6(Runtime::US0::US0_0) {
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
            Runtime::method18(if v0_1.clone() == string("") {
                string("")
            } else {
                Runtime::method41(
                    v19_1.clone(),
                    v20_1.clone(),
                    v21.clone(),
                    v22.clone(),
                    v23.clone(),
                    v24.clone(),
                    Runtime::method7(v19_1, v20_1, v21, v22, v23, v24),
                    Runtime::method40(),
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
        let v14: Arc<Async<()>> = defaultOf();
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
        let v14: Arc<Async<()>> = defaultOf();
        defaultOf::<()>();
        ();
        ()
    }
    pub fn closure23(unitVar: (), v0_1: CancellationToken) -> Runtime::US15 {
        Runtime::US15::US15_0(v0_1)
    }
    pub fn method42() -> Func1<CancellationToken, Runtime::US15> {
        Func1::new(move |v: CancellationToken| Runtime::closure23((), v))
    }
    pub fn closure24(v0_1: (), unitVar: ()) {
        if unbox::<bool>(&defaultOf()) == false {
            ();
            ()
        };
    }
    pub fn method44(v0_1: LrcPtr<TaskCanceledException>) -> string {
        let v2_1: LrcPtr<Runtime::Mut3> = LrcPtr::new(Runtime::Mut3 {
            l0: MutCell::new(Runtime::method13()),
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
        let v36: std::string::String = format!("{:#?}", v0_1);
        let v65: () = {
            Runtime::closure7(
                v2_1.clone(),
                sprintf!("{}", fable_library_rust::String_::fromString(v36)),
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
    pub fn method43(
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
        let v9: string = Runtime::method44(v8);
        Runtime::method17(sprintf!(
            "{} {} #{} {} / {}",
            v6,
            v7,
            v0_1.l0.get().clone(),
            string("runtime.execute_with_options_async / WaitForExitAsync"),
            v9
        ))
    }
    pub fn closure25(v0_1: LrcPtr<TaskCanceledException>, unitVar: ()) {
        if Runtime::method6(Runtime::US0::US0_3) {
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
            Runtime::method18(Runtime::method43(
                v19_1.clone(),
                v20_1.clone(),
                v21.clone(),
                v22.clone(),
                v23.clone(),
                v24.clone(),
                Runtime::method7(v19_1, v20_1, v21, v22, v23, v24),
                Runtime::method11(),
                v0_1,
            ))
        };
    }
    pub fn method45() -> string {
        string("\n")
    }
    pub fn method47(v0_1: i32, v1_1: i32) -> string {
        let v3: LrcPtr<Runtime::Mut3> = LrcPtr::new(Runtime::Mut3 {
            l0: MutCell::new(Runtime::method13()),
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
    pub fn method46(
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
        let v10: string = Runtime::method47(v8, v9);
        Runtime::method17(sprintf!(
            "{} {} #{} {} / {}",
            v6,
            v7,
            v0_1.l0.get().clone(),
            string("runtime.execute_with_options_async"),
            v10
        ))
    }
    pub fn closure26(v0_1: i32, v1_1: string, unitVar: ()) {
        if Runtime::method6(Runtime::US0::US0_1) {
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
            Runtime::method18(Runtime::method46(
                v20_1.clone(),
                v21.clone(),
                v22.clone(),
                v23.clone(),
                v24.clone(),
                v25.clone(),
                Runtime::method7(v20_1, v21, v22, v23, v24, v25),
                Runtime::method35(),
                v0_1,
                length(v1_1),
            ))
        };
    }
    pub fn method21(
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
        Runtime::method21(
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
        Runtime::method21(
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
    pub fn method50(v0_1: char, v1_1: i64) -> bool {
        let v0_1: MutCell<char> = MutCell::new(v0_1);
        let v1_1: MutCell<i64> = MutCell::new(v1_1);
        '_method50: loop {
            break '_method50 (if v1_1.get().clone() >= 4_i64 {
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
                    continue '_method50;
                }
            });
        }
    }
    pub fn method51(
        v0_1: string,
        v1_1: string,
        v2_1: LrcPtr<StringBuilder>,
        v3: i32,
        v4: i32,
    ) -> Runtime::US8 {
        let v0_1: MutCell<string> = MutCell::new(v0_1.clone());
        let v1_1: MutCell<string> = MutCell::new(v1_1.clone());
        let v2_1: MutCell<LrcPtr<StringBuilder>> = MutCell::new(v2_1.clone());
        let v3: MutCell<i32> = MutCell::new(v3);
        let v4: MutCell<i32> = MutCell::new(v4);
        '_method51: loop {
            break '_method51 ({
                let v82: Runtime::US7 = if string("") == v1_1.get().clone() {
                    Runtime::US7::US7_1(sprintf!(
                        "parsing.none_of / unexpected end of input / chars: {:?} / s: {:?}",
                        toArray(ofArray(new_array(&['\\', '`', '\"', ' ']))),
                        (v2_1.get().clone(), v3.get().clone(), v4.get().clone())
                    ))
                } else {
                    let v25: char = getCharAt(v1_1.get().clone(), 0_i32);
                    let v32: string = getSlice(
                        v1_1.get().clone(),
                        Some(1_i32),
                        Some(length(v1_1.get().clone())),
                    );
                    if Runtime::method50(v25, 0_i64) == false {
                        let v37: string = ofChar(v25);
                        let v40: i32 = length(v37.clone());
                        let v41: Array<char> = new_init(&'\u{0000}', v40);
                        let v42: LrcPtr<Runtime::Mut5> = LrcPtr::new(Runtime::Mut5 {
                            l0: MutCell::new(0_i32),
                        });
                        while Runtime::method24(v40, v42.clone()) {
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
                            let patternInput: (LrcPtr<StringBuilder>, i32, i32) = Runtime::method26(
                                foldBack(
                                    Func2::new(move |b0: char, b1: LrcPtr<Runtime::UH0>| {
                                        (Runtime::method25())(b0)(b1)
                                    }),
                                    v47,
                                    LrcPtr::new(Runtime::UH0::UH0_0),
                                ),
                                v2_1.get().clone(),
                                v3.get().clone(),
                                v4.get().clone(),
                            );
                            Runtime::US7::US7_0(
                                v25,
                                v32,
                                patternInput.0.clone(),
                                patternInput.1.clone(),
                                patternInput.2.clone(),
                            )
                        }
                    } else {
                        Runtime::US7::US7_1(sprintf!(
                            "parsing.none_of / unexpected char: \'{}\' / chars: {:?} / s: {:?}",
                            v25,
                            toArray(ofArray(new_array(&['\\', '`', '\"', ' ']))),
                            (v2_1.get().clone(), v3.get().clone(), v4.get().clone())
                        ))
                    }
                };
                match &v82 {
                    Runtime::US7::US7_0(v82_0_0, v82_0_1, v82_0_2, v82_0_3, v82_0_4) => {
                        let v0_1_temp: string = append(v0_1.get().clone(), ofChar(v82_0_0.clone()));
                        let v1_1_temp: string = v82_0_1.clone();
                        let v2_1_temp: LrcPtr<StringBuilder> = v82_0_2.clone();
                        let v3_temp: i32 = v82_0_3.clone();
                        let v4_temp: i32 = v82_0_4.clone();
                        v0_1.set(v0_1_temp);
                        v1_1.set(v1_1_temp);
                        v2_1.set(v2_1_temp);
                        v3.set(v3_temp);
                        v4.set(v4_temp);
                        continue '_method51;
                    }
                    _ => Runtime::US8::US8_0(
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
    pub fn method53(v0_1: char, v1_1: i64) -> bool {
        let v0_1: MutCell<char> = MutCell::new(v0_1);
        let v1_1: MutCell<i64> = MutCell::new(v1_1);
        '_method53: loop {
            break '_method53 (if v1_1.get().clone() >= 3_i64 {
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
                    continue '_method53;
                }
            });
        }
    }
    pub fn closure30(unitVar: (), _arg: (string, LrcPtr<StringBuilder>, i32, i32)) -> Runtime::US8 {
        let v3: i32 = _arg.3.clone();
        let v2_1: i32 = _arg.2.clone();
        let v1_1: LrcPtr<StringBuilder> = _arg.1.clone();
        let v0_1: string = _arg.0.clone();
        let v67: Runtime::US7 = if string("") == v0_1.clone() {
            Runtime::US7::US7_1(sprintf!(
                "parsing.p_char / unexpected end of input / s: {:?}",
                (v1_1.clone(), v2_1, v3)
            ))
        } else {
            let v7: char = getCharAt(v0_1.clone(), 0_i32);
            if v7 == '\\' {
                let v15: string = getSlice(v0_1.clone(), Some(1_i32), Some(length(v0_1.clone())));
                let v17_1: string = ofChar(v7);
                let v20_1: i32 = length(v17_1.clone());
                let v21: Array<char> = new_init(&'\u{0000}', v20_1);
                let v22: LrcPtr<Runtime::Mut5> = LrcPtr::new(Runtime::Mut5 {
                    l0: MutCell::new(0_i32),
                });
                while Runtime::method24(v20_1, v22.clone()) {
                    let v24: i32 = v22.l0.get().clone();
                    let v25: char = getCharAt(v17_1.clone(), v24);
                    v21.get_mut()[v24 as usize] = v25;
                    {
                        let v26: i32 = v24 + 1_i32;
                        v22.l0.set(v26);
                        ()
                    }
                }
                {
                    let v27: List<char> = ofArray(v21.clone());
                    let patternInput: (LrcPtr<StringBuilder>, i32, i32) = Runtime::method26(
                        foldBack(
                            Func2::new(move |b0: char, b1: LrcPtr<Runtime::UH0>| {
                                (Runtime::method25())(b0)(b1)
                            }),
                            v27,
                            LrcPtr::new(Runtime::UH0::UH0_0),
                        ),
                        v1_1.clone(),
                        v2_1,
                        v3,
                    );
                    Runtime::US7::US7_0(
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
                Runtime::US7::US7_1(sprintf!(
                    "{}\n{}\n",
                    sprintf!(
                        "parsing.p_char / expected: \'{}\' / line: {} / col: {}\n{}{}",
                        '\\',
                        v2_1,
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
        let v114: Runtime::US7 = match &v67 {
            Runtime::US7::US7_0(v67_0_0, v67_0_1, v67_0_2, v67_0_3, v67_0_4) => {
                let v72: i32 = v67_0_4.clone();
                let v71: i32 = v67_0_3.clone();
                let v70: LrcPtr<StringBuilder> = v67_0_2.clone();
                let v69: string = v67_0_1.clone();
                if string("") == v69.clone() {
                    Runtime::US7::US7_1(sprintf!(
                        "parsing.any_char / unexpected end of input / s: {:?}",
                        (v70.clone(), v71, v72)
                    ))
                } else {
                    let v76: char = getCharAt(v69.clone(), 0_i32);
                    let v83: string = getSlice(v69.clone(), Some(1_i32), Some(length(v69)));
                    let v85: string = ofChar(v76);
                    let v88: i32 = length(v85.clone());
                    let v89: Array<char> = new_init(&'\u{0000}', v88);
                    let v90: LrcPtr<Runtime::Mut5> = LrcPtr::new(Runtime::Mut5 {
                        l0: MutCell::new(0_i32),
                    });
                    while Runtime::method24(v88, v90.clone()) {
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
                        let patternInput_1: (LrcPtr<StringBuilder>, i32, i32) = Runtime::method26(
                            foldBack(
                                Func2::new(move |b0: char, b1: LrcPtr<Runtime::UH0>| {
                                    (Runtime::method25())(b0)(b1)
                                }),
                                v95,
                                LrcPtr::new(Runtime::UH0::UH0_0),
                            ),
                            v70,
                            v71,
                            v72,
                        );
                        Runtime::US7::US7_0(
                            v76,
                            v83,
                            patternInput_1.0.clone(),
                            patternInput_1.1.clone(),
                            patternInput_1.2.clone(),
                        )
                    }
                }
            }
            Runtime::US7::US7_1(v67_1_0) => Runtime::US7::US7_1(v67_1_0.clone()),
        };
        match &v114 {
            Runtime::US7::US7_0(v114_0_0, v114_0_1, v114_0_2, v114_0_3, v114_0_4) => {
                Runtime::US8::US8_0(
                    sprintf!("{}{}", '\\', v114_0_0.clone()),
                    v114_0_1.clone(),
                    v114_0_2.clone(),
                    v114_0_3.clone(),
                    v114_0_4.clone(),
                )
            }
            Runtime::US7::US7_1(v114_1_0) => Runtime::US8::US8_1(v114_1_0.clone()),
        }
    }
    pub fn closure31(unitVar: (), _arg: (string, LrcPtr<StringBuilder>, i32, i32)) -> Runtime::US8 {
        let v3: i32 = _arg.3.clone();
        let v2_1: i32 = _arg.2.clone();
        let v1_1: LrcPtr<StringBuilder> = _arg.1.clone();
        let v0_1: string = _arg.0.clone();
        let v67: Runtime::US7 = if string("") == v0_1.clone() {
            Runtime::US7::US7_1(sprintf!(
                "parsing.p_char / unexpected end of input / s: {:?}",
                (v1_1.clone(), v2_1, v3)
            ))
        } else {
            let v7: char = getCharAt(v0_1.clone(), 0_i32);
            if v7 == '`' {
                let v15: string = getSlice(v0_1.clone(), Some(1_i32), Some(length(v0_1.clone())));
                let v17_1: string = ofChar(v7);
                let v20_1: i32 = length(v17_1.clone());
                let v21: Array<char> = new_init(&'\u{0000}', v20_1);
                let v22: LrcPtr<Runtime::Mut5> = LrcPtr::new(Runtime::Mut5 {
                    l0: MutCell::new(0_i32),
                });
                while Runtime::method24(v20_1, v22.clone()) {
                    let v24: i32 = v22.l0.get().clone();
                    let v25: char = getCharAt(v17_1.clone(), v24);
                    v21.get_mut()[v24 as usize] = v25;
                    {
                        let v26: i32 = v24 + 1_i32;
                        v22.l0.set(v26);
                        ()
                    }
                }
                {
                    let v27: List<char> = ofArray(v21.clone());
                    let patternInput: (LrcPtr<StringBuilder>, i32, i32) = Runtime::method26(
                        foldBack(
                            Func2::new(move |b0: char, b1: LrcPtr<Runtime::UH0>| {
                                (Runtime::method25())(b0)(b1)
                            }),
                            v27,
                            LrcPtr::new(Runtime::UH0::UH0_0),
                        ),
                        v1_1.clone(),
                        v2_1,
                        v3,
                    );
                    Runtime::US7::US7_0(
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
                Runtime::US7::US7_1(sprintf!(
                    "{}\n{}\n",
                    sprintf!(
                        "parsing.p_char / expected: \'{}\' / line: {} / col: {}\n{}{}",
                        '`',
                        v2_1,
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
        let v114: Runtime::US7 = match &v67 {
            Runtime::US7::US7_0(v67_0_0, v67_0_1, v67_0_2, v67_0_3, v67_0_4) => {
                let v72: i32 = v67_0_4.clone();
                let v71: i32 = v67_0_3.clone();
                let v70: LrcPtr<StringBuilder> = v67_0_2.clone();
                let v69: string = v67_0_1.clone();
                if string("") == v69.clone() {
                    Runtime::US7::US7_1(sprintf!(
                        "parsing.any_char / unexpected end of input / s: {:?}",
                        (v70.clone(), v71, v72)
                    ))
                } else {
                    let v76: char = getCharAt(v69.clone(), 0_i32);
                    let v83: string = getSlice(v69.clone(), Some(1_i32), Some(length(v69)));
                    let v85: string = ofChar(v76);
                    let v88: i32 = length(v85.clone());
                    let v89: Array<char> = new_init(&'\u{0000}', v88);
                    let v90: LrcPtr<Runtime::Mut5> = LrcPtr::new(Runtime::Mut5 {
                        l0: MutCell::new(0_i32),
                    });
                    while Runtime::method24(v88, v90.clone()) {
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
                        let patternInput_1: (LrcPtr<StringBuilder>, i32, i32) = Runtime::method26(
                            foldBack(
                                Func2::new(move |b0: char, b1: LrcPtr<Runtime::UH0>| {
                                    (Runtime::method25())(b0)(b1)
                                }),
                                v95,
                                LrcPtr::new(Runtime::UH0::UH0_0),
                            ),
                            v70,
                            v71,
                            v72,
                        );
                        Runtime::US7::US7_0(
                            v76,
                            v83,
                            patternInput_1.0.clone(),
                            patternInput_1.1.clone(),
                            patternInput_1.2.clone(),
                        )
                    }
                }
            }
            Runtime::US7::US7_1(v67_1_0) => Runtime::US7::US7_1(v67_1_0.clone()),
        };
        match &v114 {
            Runtime::US7::US7_0(v114_0_0, v114_0_1, v114_0_2, v114_0_3, v114_0_4) => {
                Runtime::US8::US8_0(
                    sprintf!("{}{}", '`', v114_0_0.clone()),
                    v114_0_1.clone(),
                    v114_0_2.clone(),
                    v114_0_3.clone(),
                    v114_0_4.clone(),
                )
            }
            Runtime::US7::US7_1(v114_1_0) => Runtime::US8::US8_1(v114_1_0.clone()),
        }
    }
    pub fn method54(
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
        '_method54: loop {
            break '_method54 (match v4.get().clone().as_ref() {
                Runtime::UH3::UH3_0 => Runtime::US8::US8_1(string("choice / no parsers succeeded")),
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
                            continue '_method54;
                        }
                    }
                }
            });
        }
    }
    pub fn method55(
        v0_1: LrcPtr<Runtime::UH2>,
        v1_1: LrcPtr<Runtime::UH2>,
    ) -> LrcPtr<Runtime::UH2> {
        let v0_1: MutCell<LrcPtr<Runtime::UH2>> = MutCell::new(v0_1.clone());
        let v1_1: MutCell<LrcPtr<Runtime::UH2>> = MutCell::new(v1_1.clone());
        '_method55: loop {
            break '_method55 (match v0_1.get().clone().as_ref() {
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
                    continue '_method55;
                }
            });
        }
    }
    pub fn method52(
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
        '_method52: loop {
            break '_method52 ({
                let v76: Runtime::US7 = if string("") == v1_1.get().clone() {
                    Runtime::US7::US7_1(sprintf!(
                        "parsing.none_of / unexpected end of input / chars: {:?} / s: {:?}",
                        toArray(ofArray(new_array(&['\\', '`', '\"']))),
                        (v2_1.get().clone(), v3.get().clone(), v4.get().clone())
                    ))
                } else {
                    let v22: char = getCharAt(v1_1.get().clone(), 0_i32);
                    let v29: string = getSlice(
                        v1_1.get().clone(),
                        Some(1_i32),
                        Some(length(v1_1.get().clone())),
                    );
                    if Runtime::method53(v22, 0_i64) == false {
                        let v34: string = ofChar(v22);
                        let v37: i32 = length(v34.clone());
                        let v38: Array<char> = new_init(&'\u{0000}', v37);
                        let v39: LrcPtr<Runtime::Mut5> = LrcPtr::new(Runtime::Mut5 {
                            l0: MutCell::new(0_i32),
                        });
                        while Runtime::method24(v37, v39.clone()) {
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
                            let patternInput: (LrcPtr<StringBuilder>, i32, i32) = Runtime::method26(
                                foldBack(
                                    Func2::new(move |b0: char, b1: LrcPtr<Runtime::UH0>| {
                                        (Runtime::method25())(b0)(b1)
                                    }),
                                    v44,
                                    LrcPtr::new(Runtime::UH0::UH0_0),
                                ),
                                v2_1.get().clone(),
                                v3.get().clone(),
                                v4.get().clone(),
                            );
                            Runtime::US7::US7_0(
                                v22,
                                v29,
                                patternInput.0.clone(),
                                patternInput.1.clone(),
                                patternInput.2.clone(),
                            )
                        }
                    } else {
                        Runtime::US7::US7_1(sprintf!(
                            "parsing.none_of / unexpected char: \'{}\' / chars: {:?} / s: {:?}",
                            v22,
                            toArray(ofArray(new_array(&['\\', '`', '\"']))),
                            (v2_1.get().clone(), v3.get().clone(), v4.get().clone())
                        ))
                    }
                };
                let v90: Runtime::US8 = match &v76 {
                    Runtime::US7::US7_0(v76_0_0, v76_0_1, v76_0_2, v76_0_3, v76_0_4) => {
                        Runtime::US8::US8_0(
                            ofChar(v76_0_0.clone()),
                            v76_0_1.clone(),
                            v76_0_2.clone(),
                            v76_0_3.clone(),
                            v76_0_4.clone(),
                        )
                    }
                    Runtime::US7::US7_1(v76_1_0) => Runtime::US8::US8_1(v76_1_0.clone()),
                };
                let v104: Runtime::US8 = match &v90 {
                    Runtime::US8::US8_0(v90_0_0, v90_0_1, v90_0_2, v90_0_3, v90_0_4) => v90.clone(),
                    _ => Runtime::method54(
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
                match &v104 {
                    Runtime::US8::US8_0(v104_0_0, v104_0_1, v104_0_2, v104_0_3, v104_0_4) => {
                        let v0_1_temp: LrcPtr<Runtime::UH2> =
                            LrcPtr::new(Runtime::UH2::UH2_1(v104_0_0.clone(), v0_1.get().clone()));
                        let v1_1_temp: string = v104_0_1.clone();
                        let v2_1_temp: LrcPtr<StringBuilder> = v104_0_2.clone();
                        let v3_temp: i32 = v104_0_3.clone();
                        let v4_temp: i32 = v104_0_4.clone();
                        v0_1.set(v0_1_temp);
                        v1_1.set(v1_1_temp);
                        v2_1.set(v2_1_temp);
                        v3.set(v3_temp);
                        v4.set(v4_temp);
                        continue '_method52;
                    }
                    _ => Runtime::US17::US17_0(
                        Runtime::method55(v0_1.get().clone(), LrcPtr::new(Runtime::UH2::UH2_0)),
                        v1_1.get().clone(),
                        v2_1.get().clone(),
                        v3.get().clone(),
                        v4.get().clone(),
                    ),
                }
            });
        }
    }
    pub fn method56(v0_1: LrcPtr<Runtime::UH2>, v1_1: List<string>) -> List<string> {
        match v0_1.as_ref() {
            Runtime::UH2::UH2_0 => v1_1.clone(),
            Runtime::UH2::UH2_1(v0_1_1_0, v0_1_1_1) => cons(
                match v0_1.as_ref() {
                    Runtime::UH2::UH2_1(x, _) => x.clone(),
                    _ => unreachable!(),
                },
                Runtime::method56(
                    match v0_1.as_ref() {
                        Runtime::UH2::UH2_1(_, x) => x.clone(),
                        _ => unreachable!(),
                    },
                    v1_1.clone(),
                ),
            ),
        }
    }
    pub fn method57(
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
        '_method57: loop {
            break '_method57 ({
                let v76: Runtime::US7 = if string("") == v1_1.get().clone() {
                    Runtime::US7::US7_1(sprintf!(
                        "parsing.none_of / unexpected end of input / chars: {:?} / s: {:?}",
                        toArray(ofArray(new_array(&['\\', '`', '\"']))),
                        (v2_1.get().clone(), v3.get().clone(), v4.get().clone())
                    ))
                } else {
                    let v22: char = getCharAt(v1_1.get().clone(), 0_i32);
                    let v29: string = getSlice(
                        v1_1.get().clone(),
                        Some(1_i32),
                        Some(length(v1_1.get().clone())),
                    );
                    if Runtime::method53(v22, 0_i64) == false {
                        let v34: string = ofChar(v22);
                        let v37: i32 = length(v34.clone());
                        let v38: Array<char> = new_init(&'\u{0000}', v37);
                        let v39: LrcPtr<Runtime::Mut5> = LrcPtr::new(Runtime::Mut5 {
                            l0: MutCell::new(0_i32),
                        });
                        while Runtime::method24(v37, v39.clone()) {
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
                            let patternInput: (LrcPtr<StringBuilder>, i32, i32) = Runtime::method26(
                                foldBack(
                                    Func2::new(move |b0: char, b1: LrcPtr<Runtime::UH0>| {
                                        (Runtime::method25())(b0)(b1)
                                    }),
                                    v44,
                                    LrcPtr::new(Runtime::UH0::UH0_0),
                                ),
                                v2_1.get().clone(),
                                v3.get().clone(),
                                v4.get().clone(),
                            );
                            Runtime::US7::US7_0(
                                v22,
                                v29,
                                patternInput.0.clone(),
                                patternInput.1.clone(),
                                patternInput.2.clone(),
                            )
                        }
                    } else {
                        Runtime::US7::US7_1(sprintf!(
                            "parsing.none_of / unexpected char: \'{}\' / chars: {:?} / s: {:?}",
                            v22,
                            toArray(ofArray(new_array(&['\\', '`', '\"']))),
                            (v2_1.get().clone(), v3.get().clone(), v4.get().clone())
                        ))
                    }
                };
                let v90: Runtime::US8 = match &v76 {
                    Runtime::US7::US7_0(v76_0_0, v76_0_1, v76_0_2, v76_0_3, v76_0_4) => {
                        Runtime::US8::US8_0(
                            ofChar(v76_0_0.clone()),
                            v76_0_1.clone(),
                            v76_0_2.clone(),
                            v76_0_3.clone(),
                            v76_0_4.clone(),
                        )
                    }
                    Runtime::US7::US7_1(v76_1_0) => Runtime::US8::US8_1(v76_1_0.clone()),
                };
                match &v90 {
                    Runtime::US8::US8_0(v90_0_0, v90_0_1, v90_0_2, v90_0_3, v90_0_4) => {
                        let v0_1_temp: LrcPtr<Runtime::UH2> =
                            LrcPtr::new(Runtime::UH2::UH2_1(v90_0_0.clone(), v0_1.get().clone()));
                        let v1_1_temp: string = v90_0_1.clone();
                        let v2_1_temp: LrcPtr<StringBuilder> = v90_0_2.clone();
                        let v3_temp: i32 = v90_0_3.clone();
                        let v4_temp: i32 = v90_0_4.clone();
                        v0_1.set(v0_1_temp);
                        v1_1.set(v1_1_temp);
                        v2_1.set(v2_1_temp);
                        v3.set(v3_temp);
                        v4.set(v4_temp);
                        continue '_method57;
                    }
                    _ => Runtime::US17::US17_0(
                        Runtime::method55(v0_1.get().clone(), LrcPtr::new(Runtime::UH2::UH2_0)),
                        v1_1.get().clone(),
                        v2_1.get().clone(),
                        v3.get().clone(),
                        v4.get().clone(),
                    ),
                }
            });
        }
    }
    pub fn method58(v0_1: string, v1_1: i32) -> i32 {
        let v0_1: MutCell<string> = MutCell::new(v0_1.clone());
        let v1_1: MutCell<i32> = MutCell::new(v1_1);
        '_method58: loop {
            break '_method58 (if v1_1.get().clone() >= length(v0_1.get().clone()) {
                v1_1.get().clone()
            } else {
                if getCharAt(v0_1.get().clone(), v1_1.get().clone()) == ' ' {
                    let v0_1_temp: string = v0_1.get().clone();
                    let v1_1_temp: i32 = v1_1.get().clone() + 1_i32;
                    v0_1.set(v0_1_temp);
                    v1_1.set(v1_1_temp);
                    continue '_method58;
                } else {
                    v1_1.get().clone()
                }
            });
        }
    }
    pub fn method49(
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
        '_method49: loop {
            break '_method49 ({
                let v5: bool = string("") == v1_1.get().clone();
                let v82: Runtime::US7 = if v5 {
                    Runtime::US7::US7_1(sprintf!(
                        "parsing.none_of / unexpected end of input / chars: {:?} / s: {:?}",
                        toArray(ofArray(new_array(&['\\', '`', '\"', ' ']))),
                        (v2_1.get().clone(), v3.get().clone(), v4.get().clone())
                    ))
                } else {
                    let v25: char = getCharAt(v1_1.get().clone(), 0_i32);
                    let v32: string = getSlice(
                        v1_1.get().clone(),
                        Some(1_i32),
                        Some(length(v1_1.get().clone())),
                    );
                    if Runtime::method50(v25, 0_i64) == false {
                        let v37: string = ofChar(v25);
                        let v40: i32 = length(v37.clone());
                        let v41: Array<char> = new_init(&'\u{0000}', v40);
                        let v42: LrcPtr<Runtime::Mut5> = LrcPtr::new(Runtime::Mut5 {
                            l0: MutCell::new(0_i32),
                        });
                        while Runtime::method24(v40, v42.clone()) {
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
                            let patternInput: (LrcPtr<StringBuilder>, i32, i32) = Runtime::method26(
                                foldBack(
                                    Func2::new(move |b0: char, b1: LrcPtr<Runtime::UH0>| {
                                        (Runtime::method25())(b0)(b1)
                                    }),
                                    v47,
                                    LrcPtr::new(Runtime::UH0::UH0_0),
                                ),
                                v2_1.get().clone(),
                                v3.get().clone(),
                                v4.get().clone(),
                            );
                            Runtime::US7::US7_0(
                                v25,
                                v32,
                                patternInput.0.clone(),
                                patternInput.1.clone(),
                                patternInput.2.clone(),
                            )
                        }
                    } else {
                        Runtime::US7::US7_1(sprintf!(
                            "parsing.none_of / unexpected char: \'{}\' / chars: {:?} / s: {:?}",
                            v25,
                            toArray(ofArray(new_array(&['\\', '`', '\"', ' ']))),
                            (v2_1.get().clone(), v3.get().clone(), v4.get().clone())
                        ))
                    }
                };
                let v96: Runtime::US8 = match &v82 {
                    Runtime::US7::US7_0(v82_0_0, v82_0_1, v82_0_2, v82_0_3, v82_0_4) => {
                        Runtime::method51(
                            ofChar(v82_0_0.clone()),
                            v82_0_1.clone(),
                            v82_0_2.clone(),
                            v82_0_3.clone(),
                            v82_0_4.clone(),
                        )
                    }
                    Runtime::US7::US7_1(v82_1_0) => Runtime::US8::US8_1(v82_1_0.clone()),
                };
                let v341: Runtime::US8 = match &v96 {
                    Runtime::US8::US8_0(v96_0_0, v96_0_1, v96_0_2, v96_0_3, v96_0_4) => v96.clone(),
                    _ => {
                        let v165: Runtime::US7 = if v5 {
                            Runtime::US7::US7_1(sprintf!(
                                "parsing.p_char / unexpected end of input / s: {:?}",
                                (v2_1.get().clone(), v3.get().clone(), v4.get().clone())
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
                                let v120: LrcPtr<Runtime::Mut5> = LrcPtr::new(Runtime::Mut5 {
                                    l0: MutCell::new(0_i32),
                                });
                                while Runtime::method24(v118, v120.clone()) {
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
                                    let patternInput_1: (LrcPtr<StringBuilder>, i32, i32) =
                                        Runtime::method26(
                                            foldBack(
                                                Func2::new(
                                                    move |b0: char, b1: LrcPtr<Runtime::UH0>| {
                                                        (Runtime::method25())(b0)(b1)
                                                    },
                                                ),
                                                v125,
                                                LrcPtr::new(Runtime::UH0::UH0_0),
                                            ),
                                            v2_1.get().clone(),
                                            v3.get().clone(),
                                            v4.get().clone(),
                                        );
                                    Runtime::US7::US7_0(
                                        v105,
                                        v113,
                                        patternInput_1.0.clone(),
                                        patternInput_1.1.clone(),
                                        patternInput_1.2.clone(),
                                    )
                                }
                            } else {
                                let v141: i32 = length(v1_1.get().clone());
                                let v144: i32 = indexOf(v1_1.get().clone(), string("\n")) - 1_i32;
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
                        let v282: Runtime::US8 = match &v165 {
                            Runtime::US7::US7_0(
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
                                let v172: Runtime::US17 = Runtime::method52(
                                    LrcPtr::new(Runtime::UH2::UH2_0),
                                    v167.clone(),
                                    v168.clone(),
                                    v169,
                                    v170,
                                );
                                let v193: Runtime::US8 = match &v172 {
                                    Runtime::US17::US17_0(
                                        v172_0_0,
                                        v172_0_1,
                                        v172_0_2,
                                        v172_0_3,
                                        v172_0_4,
                                    ) => {
                                        let v179: List<string> =
                                            Runtime::method56(v172_0_0.clone(), empty::<string>());
                                        Runtime::US8::US8_0(
                                            join(
                                                string(""),
                                                toArray_1(delay(Func0::new({
                                                    let v179 = v179.clone();
                                                    move || {
                                                        map_1(
                                                            Func1::new({
                                                                let v179 = v179.clone();
                                                                move |i: i32| item(i, v179.clone())
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
                                    Runtime::US17::US17_1(v172_1_0) => {
                                        Runtime::US8::US8_1(v172_1_0.clone())
                                    }
                                };
                                match &v193 {
                                    Runtime::US8::US8_0(
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
                                        let v262: Runtime::US7 = if string("") == v195.clone() {
                                            Runtime::US7::US7_1(sprintf!("parsing.p_char / unexpected end of input / s: {:?}",
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
                                                let v216: Array<char> = new_init(&'\u{0000}', v215);
                                                let v217: LrcPtr<Runtime::Mut5> =
                                                    LrcPtr::new(Runtime::Mut5 {
                                                        l0: MutCell::new(0_i32),
                                                    });
                                                while Runtime::method24(v215, v217.clone()) {
                                                    let v219: i32 = v217.l0.get().clone();
                                                    let v220: char = getCharAt(v212.clone(), v219);
                                                    v216.get_mut()[v219 as usize] = v220;
                                                    {
                                                        let v221: i32 = v219 + 1_i32;
                                                        v217.l0.set(v221);
                                                        ()
                                                    }
                                                }
                                                {
                                                    let v222: List<char> = ofArray(v216.clone());
                                                    let patternInput_2:
                                                                                 (LrcPtr<StringBuilder>,
                                                                                  i32,
                                                                                  i32) =
                                                                             Runtime::method26(foldBack(Func2::new(move
                                                                                                                       |b0:
                                                                                                                            char,
                                                                                                                        b1:
                                                                                                                            LrcPtr<Runtime::UH0>|
                                                                                                                       (Runtime::method25())(b0)(b1)),
                                                                                                        v222,
                                                                                                        LrcPtr::new(Runtime::UH0::UH0_0)),
                                                                                               v196.clone(),
                                                                                               v197,
                                                                                               v198);
                                                    Runtime::US7::US7_0(
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
                                                Runtime::US7::US7_1(sprintf!("{}\n{}\n",
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
                                                             Runtime::US7::US7_0(v262_0_0,
                                                                                 v262_0_1,
                                                                                 v262_0_2,
                                                                                 v262_0_3,
                                                                                 v262_0_4)
                                                             =>
                                                             Runtime::US8::US8_0(v193_0_0.clone(),
                                                                                 v262_0_1.clone(),
                                                                                 v262_0_2.clone(),
                                                                                 v262_0_3.clone(),
                                                                                 v262_0_4.clone()),
                                                             Runtime::US7::US7_1(v262_1_0)
                                                             =>
                                                             Runtime::US8::US8_1(sprintf!("between / expected closing delimiter / e: {:?} / input: {:?} / rest1: {:?} / rest2: {:?}",
                                                                                          v262_1_0.clone(),
                                                                                          (v1_1.get().clone(),
                                                                                           v2_1.get().clone(),
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
                                    _ => Runtime::US8::US8_1(string("between / expected content")),
                                }
                            }
                            Runtime::US7::US7_1(v165_1_0) => Runtime::US8::US8_1(v165_1_0.clone()),
                        };
                        match &v282 {
                            Runtime::US8::US8_0(
                                v282_0_0,
                                v282_0_1,
                                v282_0_2,
                                v282_0_3,
                                v282_0_4,
                            ) => v282.clone(),
                            _ => {
                                let v294: Runtime::US8 = Runtime::method54(
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
                                let v305: Runtime::US8 = match &v294 {
                                    Runtime::US8::US8_0(
                                        v294_0_0,
                                        v294_0_1,
                                        v294_0_2,
                                        v294_0_3,
                                        v294_0_4,
                                    ) => Runtime::US8::US8_0(
                                        string(""),
                                        v294_0_1.clone(),
                                        v294_0_2.clone(),
                                        v294_0_3.clone(),
                                        v294_0_4.clone(),
                                    ),
                                    Runtime::US8::US8_1(v294_1_0) => {
                                        Runtime::US8::US8_1(v294_1_0.clone())
                                    }
                                };
                                let v316: Runtime::US17 = match &v305 {
                                    Runtime::US8::US8_0(
                                        v305_0_0,
                                        v305_0_1,
                                        v305_0_2,
                                        v305_0_3,
                                        v305_0_4,
                                    ) => Runtime::method57(
                                        LrcPtr::new(Runtime::UH2::UH2_0),
                                        v305_0_1.clone(),
                                        v305_0_2.clone(),
                                        v305_0_3.clone(),
                                        v305_0_4.clone(),
                                    ),
                                    Runtime::US8::US8_1(v305_1_0) => {
                                        Runtime::US17::US17_1(v305_1_0.clone())
                                    }
                                };
                                match &v316 {
                                    Runtime::US17::US17_0(
                                        v316_0_0,
                                        v316_0_1,
                                        v316_0_2,
                                        v316_0_3,
                                        v316_0_4,
                                    ) => {
                                        let v323: List<string> =
                                            Runtime::method56(v316_0_0.clone(), empty::<string>());
                                        Runtime::US8::US8_0(
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
                                    Runtime::US17::US17_1(v316_1_0) => {
                                        Runtime::US8::US8_1(v316_1_0.clone())
                                    }
                                }
                            }
                        }
                    }
                };
                match &v341 {
                    Runtime::US8::US8_0(v341_0_0, v341_0_1, v341_0_2, v341_0_3, v341_0_4) => {
                        let v350: i32 = v341_0_4.clone();
                        let v349: i32 = v341_0_3.clone();
                        let v348: LrcPtr<StringBuilder> = v341_0_2.clone();
                        let v347: string = v341_0_1.clone();
                        let v346: string = v341_0_0.clone();
                        let v352: i32 = Runtime::method58(v347.clone(), 0_i32);
                        let v364: Runtime::US10 = if 0_i32 == v352 {
                            Runtime::US10::US10_1(string("spaces1 / expected at least one space"))
                        } else {
                            Runtime::US10::US10_0(
                                getSlice(v347.clone(), Some(v352), Some(length(v347.clone()))),
                                v348.clone(),
                                v349,
                                v350,
                            )
                        };
                        match &v364 {
                            Runtime::US10::US10_0(v364_0_0, v364_0_1, v364_0_2, v364_0_3) => {
                                let v0_1_temp: LrcPtr<Runtime::UH2> = LrcPtr::new(
                                    Runtime::UH2::UH2_1(v346.clone(), v0_1.get().clone()),
                                );
                                let v1_1_temp: string = v364_0_0.clone();
                                let v2_1_temp: LrcPtr<StringBuilder> = v364_0_1.clone();
                                let v3_temp: i32 = v364_0_2.clone();
                                let v4_temp: i32 = v364_0_3.clone();
                                v0_1.set(v0_1_temp);
                                v1_1.set(v1_1_temp);
                                v2_1.set(v2_1_temp);
                                v3.set(v3_temp);
                                v4.set(v4_temp);
                                continue '_method49;
                            }
                            _ => Runtime::US17::US17_0(
                                Runtime::method55(
                                    v0_1.get().clone(),
                                    LrcPtr::new(Runtime::UH2::UH2_1(
                                        v346.clone(),
                                        LrcPtr::new(Runtime::UH2::UH2_0),
                                    )),
                                ),
                                v347,
                                v348,
                                v349,
                                v350,
                            ),
                        }
                    }
                    _ => Runtime::US17::US17_0(
                        Runtime::method55(v0_1.get().clone(), LrcPtr::new(Runtime::UH2::UH2_0)),
                        v1_1.get().clone(),
                        v2_1.get().clone(),
                        v3.get().clone(),
                        v4.get().clone(),
                    ),
                }
            });
        }
    }
    pub fn method48(v0_1: string) -> Runtime::US16 {
        let _v0: MutCell<Option<Option<string>>> = MutCell::new(None::<Option<string>>);
        _v0.set(Some(Some(v0_1)));
        {
            let v16_1: Runtime::US17 = Runtime::method49(
                LrcPtr::new(Runtime::UH2::UH2_0),
                defaultValue(
                    string(""),
                    match &_v0.get().clone() {
                        None => panic!("{}", string("optionm\'.of_obj / _v0=None"),),
                        Some(_v0_0_0) => _v0_0_0.clone(),
                    },
                ),
                StringBuilder::_ctor__Z721C83C5(Runtime::method23()),
                1_i32,
                1_i32,
            );
            match &v16_1 {
                Runtime::US17::US17_0(v16_1_0_0, v16_1_0_1, v16_1_0_2, v16_1_0_3, v16_1_0_4) => {
                    Runtime::US16::US16_0(toArray(Runtime::method56(
                        v16_1_0_0.clone(),
                        empty::<string>(),
                    )))
                }
                Runtime::US17::US17_1(v16_1_1_0) => Runtime::US16::US16_1(v16_1_1_0.clone()),
            }
        }
    }
    pub fn closure29(unitVar: (), v0_1: string) -> Result<Array<string>, string> {
        let v1_1: Runtime::US16 = Runtime::method48(v0_1);
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
