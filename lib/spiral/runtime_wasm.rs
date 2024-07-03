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
                    LrcPtr<Runtime::Mut3>,
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
    #[derive(Clone, Debug, PartialEq, PartialOrd, Hash, Eq)]
    pub struct Mut3 {
        pub l0: MutCell<Runtime::US0>,
    }
    impl core::fmt::Display for Runtime::Mut3 {
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
    #[derive(Clone, Debug, PartialEq, PartialOrd, Hash, Eq)]
    pub enum US3 {
        US3_0(string),
        US3_1,
    }
    impl core::fmt::Display for Runtime::US3 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Debug, Default, PartialEq, PartialOrd, Hash, Eq)]
    pub struct Mut4 {
        pub l0: MutCell<string>,
    }
    impl core::fmt::Display for Runtime::Mut4 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Debug, PartialEq, PartialOrd, Hash, Eq)]
    pub enum US4 {
        US4_0(string, Runtime::US3),
        US4_1(string),
    }
    impl core::fmt::Display for Runtime::US4 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Debug)]
    pub enum US5 {
        US5_0(char, string, LrcPtr<StringBuilder>, i32, i32),
        US5_1(string),
    }
    impl core::fmt::Display for Runtime::US5 {
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
            Func1<(string, LrcPtr<StringBuilder>, i32, i32), Runtime::US5>,
            LrcPtr<Runtime::UH1>,
        ),
    }
    impl core::fmt::Display for Runtime::UH1 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Debug)]
    pub enum US6 {
        US6_0(string, string, LrcPtr<StringBuilder>, i32, i32),
        US6_1(string),
    }
    impl core::fmt::Display for Runtime::US6 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Copy, Debug, PartialEq, PartialOrd, Hash, Eq)]
    pub enum US7 {
        US7_0(char),
        US7_1,
    }
    impl core::fmt::Display for Runtime::US7 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Debug)]
    pub enum US8 {
        US8_0(string, LrcPtr<StringBuilder>, i32, i32),
        US8_1(string),
    }
    impl core::fmt::Display for Runtime::US8 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Debug)]
    pub enum US9 {
        US9_0(
            string,
            Runtime::US3,
            string,
            LrcPtr<StringBuilder>,
            i32,
            i32,
        ),
        US9_1(string),
    }
    impl core::fmt::Display for Runtime::US9 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Debug)]
    pub enum US10 {
        US10_0(Runtime::US7, string, LrcPtr<StringBuilder>, i32, i32),
        US10_1(string),
    }
    impl core::fmt::Display for Runtime::US10 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Debug)]
    pub enum US11 {
        US11_0(Runtime::US3, string, LrcPtr<StringBuilder>, i32, i32),
        US11_1(string),
    }
    impl core::fmt::Display for Runtime::US11 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Debug)]
    pub enum US12 {
        US12_0(Func1<(i32, string, bool), Arc<Async<()>>>),
        US12_1,
    }
    impl core::fmt::Display for Runtime::US12 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Copy, Debug, PartialEq, PartialOrd, Hash, Eq)]
    pub enum US13 {
        US13_0(CancellationToken),
        US13_1,
    }
    impl core::fmt::Display for Runtime::US13 {
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
    pub enum US14 {
        US14_0(Array<string>),
        US14_1(string),
    }
    impl core::fmt::Display for Runtime::US14 {
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
    pub enum US15 {
        US15_0(
            LrcPtr<Runtime::UH2>,
            string,
            LrcPtr<StringBuilder>,
            i32,
            i32,
        ),
        US15_1(string),
    }
    impl core::fmt::Display for Runtime::US15 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Debug)]
    pub enum UH3 {
        UH3_0,
        UH3_1(
            Func1<(string, LrcPtr<StringBuilder>, i32, i32), Runtime::US6>,
            LrcPtr<Runtime::UH3>,
        ),
    }
    impl core::fmt::Display for Runtime::UH3 {
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
        LrcPtr<Runtime::Mut3>,
        Option<i64>,
    ) {
        let _v1: MutCell<Option<(Runtime::US1, Runtime::US2)>> =
            MutCell::new(None::<(Runtime::US1, Runtime::US2)>);
        _v1.set(Some((Runtime::US1::US1_1, Runtime::US2::US2_1)));
        {
            let patternInput: (Runtime::US1, Runtime::US2) = match &_v1.get().clone() {
                None => panic!("{}", string("base.run_target / _v1=None"),),
                Some(_v1_0_0) => _v1_0_0.clone(),
            };
            let v259: Runtime::US2 = patternInput.1.clone();
            let v258: Runtime::US1 = patternInput.0.clone();
            (
                LrcPtr::new(Runtime::Mut0 {
                    l0: MutCell::new(0_i64),
                }),
                LrcPtr::new(Runtime::Mut1 {
                    l0: MutCell::new(Func1::new(move |v: string| Runtime::closure1((), v))),
                }),
                LrcPtr::new(Runtime::Mut2 {
                    l0: MutCell::new(true),
                }),
                LrcPtr::new(Runtime::Mut3 {
                    l0: MutCell::new(match &v258 {
                        Runtime::US1::US1_0(v258_0_0) => match &v258 {
                            Runtime::US1::US1_0(x) => x.clone(),
                            _ => unreachable!(),
                        },
                        _ => v0_1,
                    }),
                }),
                match &v259 {
                    Runtime::US2::US2_0(v259_0_0) => Some(match &v259 {
                        Runtime::US2::US2_0(x) => x.clone(),
                        _ => unreachable!(),
                    }),
                    _ => None::<i64>,
                },
            )
        }
    }
    pub fn closure4(unitVar: (), unitVar_1: ()) -> string {
        string("runtime.current_process_kill / exiting... 3")
    }
    pub fn closure5(unitVar: (), unitVar_1: ()) {
        ();
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
    pub fn method8() -> string {
        string("\u{001b}[0m")
    }
    pub fn method9(v0_1: LrcPtr<Runtime::Mut4>) {
        ();
    }
    pub fn closure6(
        v0_1: Runtime::US0,
        v1_1: Func0<string>,
        v2_1: Func0<()>,
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
                LrcPtr<Runtime::Mut3>,
                Option<i64>,
            ) = getValue(Runtime::State::trace_state().get().clone());
            let v9: Option<i64> = patternInput.4.clone();
            let _v10: MutCell<Option<string>> = MutCell::new(None::<string>);
            let _v39: LrcPtr<MutCell<Option<Runtime::US2>>> = refCell(None::<Runtime::US2>);
            {
                let x_2: Option<Runtime::US2> = match &v9 {
                    None => None::<Runtime::US2>,
                    Some(v9_0_0) => {
                        let x: i64 = v9_0_0.clone();
                        Some((Func0::new({
                            let x = x.clone();
                            move || Runtime::US2::US2_0(x)
                        }))())
                    }
                };
                _v39.set(x_2)
            }
            {
                let v44: Runtime::US2 = defaultValue(Runtime::US2::US2_1, _v39.get().clone());
                let v63: DateTime = match &v44 {
                    Runtime::US2::US2_0(v44_0_0) => {
                        let v51: TimeSpan = TimeSpan::new_ticks(
                            {
                                let _arg: DateTime = DateTime::now();
                                _arg.ticks()
                            } - match &v44 {
                                Runtime::US2::US2_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                        );
                        DateTime::new_ymdhms_milli(
                            1_i32,
                            1_i32,
                            1_i32,
                            v51.hours(),
                            v51.minutes(),
                            v51.seconds(),
                            v51.milliseconds(),
                        )
                    }
                    _ => DateTime::now(),
                };
                {
                    let x_3: string = {
                        let provider: string = Runtime::method5();
                        v63.toString(provider)
                    };
                    _v10.set(Some(x_3))
                }
                {
                    let v152: string = match &_v10.get().clone() {
                        None => panic!("{}", string("base.run_target / _v10=None"),),
                        Some(_v10_0_0) => _v10_0_0.clone(),
                    };
                    let v159: Runtime::US3 = if if let Runtime::US0::US0_0 = &v0_1 {
                        true
                    } else {
                        false
                    } {
                        Runtime::US3::US3_0(string("Verbose"))
                    } else {
                        Runtime::US3::US3_1
                    };
                    let v208: Runtime::US3 = match &v159 {
                        Runtime::US3::US3_0(v159_0_0) => Runtime::US3::US3_0(match &v159 {
                            Runtime::US3::US3_0(x) => x.clone(),
                            _ => unreachable!(),
                        }),
                        _ => {
                            let v168: Runtime::US3 = if if let Runtime::US0::US0_1 = &v0_1 {
                                true
                            } else {
                                false
                            } {
                                Runtime::US3::US3_0(string("Debug"))
                            } else {
                                Runtime::US3::US3_1
                            };
                            match &v168 {
                                Runtime::US3::US3_0(v168_0_0) => Runtime::US3::US3_0(match &v168 {
                                    Runtime::US3::US3_0(x) => x.clone(),
                                    _ => unreachable!(),
                                }),
                                _ => {
                                    let v177: Runtime::US3 = if if let Runtime::US0::US0_2 = &v0_1 {
                                        true
                                    } else {
                                        false
                                    } {
                                        Runtime::US3::US3_0(string("Info"))
                                    } else {
                                        Runtime::US3::US3_1
                                    };
                                    match &v177 {
                                        Runtime::US3::US3_0(v177_0_0) => {
                                            Runtime::US3::US3_0(match &v177 {
                                                Runtime::US3::US3_0(x) => x.clone(),
                                                _ => unreachable!(),
                                            })
                                        }
                                        _ => {
                                            let v186: Runtime::US3 =
                                                if if let Runtime::US0::US0_3 = &v0_1 {
                                                    true
                                                } else {
                                                    false
                                                } {
                                                    Runtime::US3::US3_0(string("Warning"))
                                                } else {
                                                    Runtime::US3::US3_1
                                                };
                                            match &v186 {
                                                Runtime::US3::US3_0(v186_0_0) => {
                                                    Runtime::US3::US3_0(match &v186 {
                                                        Runtime::US3::US3_0(x) => x.clone(),
                                                        _ => unreachable!(),
                                                    })
                                                }
                                                _ => {
                                                    let v195: Runtime::US3 =
                                                        if if let Runtime::US0::US0_4 = &v0_1 {
                                                            true
                                                        } else {
                                                            false
                                                        } {
                                                            Runtime::US3::US3_0(string("Critical"))
                                                        } else {
                                                            Runtime::US3::US3_1
                                                        };
                                                    match &v195 {
                                                        Runtime::US3::US3_0(v195_0_0) => {
                                                            Runtime::US3::US3_0(match &v195 {
                                                                Runtime::US3::US3_0(x) => x.clone(),
                                                                _ => unreachable!(),
                                                            })
                                                        }
                                                        _ => Runtime::US3::US3_1,
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    };
                    let v215: string = padLeft(
                        toLower(match &v208 {
                            Runtime::US3::US3_0(v208_0_0) => match &v208 {
                                Runtime::US3::US3_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                            _ => panic!("{}", string("Option does not have a value."),),
                        }),
                        7_i32,
                        ' ',
                    );
                    let _v216: MutCell<Option<string>> = MutCell::new(None::<string>);
                    let v255: &str = match &v0_1 {
                        Runtime::US0::US0_1 => inline_colorization::color_bright_blue,
                        Runtime::US0::US0_2 => inline_colorization::color_bright_green,
                        Runtime::US0::US0_0 => inline_colorization::color_bright_black,
                        Runtime::US0::US0_3 => inline_colorization::color_yellow,
                        _ => inline_colorization::color_bright_red,
                    };
                    let v257: &str = &*v215;
                    let v259: &str = inline_colorization::color_reset;
                    let v261: string = string("format!(\"{v255}{v257}{v259}\")");
                    let v262: std::string::String = format!("{v255}{v257}{v259}");
                    {
                        let x_5: string = fable_library_rust::String_::fromString(v262);
                        _v216.set(Some(x_5))
                    }
                    {
                        let v328: string = match &_v216.get().clone() {
                            None => panic!("{}", string("base.run_target / _v216=None"),),
                            Some(_v216_0_0) => _v216_0_0.clone(),
                        };
                        let v329: i64 = (patternInput.0.clone()).l0.get().clone();
                        v2_1();
                        {
                            let v331: LrcPtr<Runtime::Mut4> = LrcPtr::new(Runtime::Mut4 {
                                l0: MutCell::new(string("")),
                            });
                            Runtime::method9(v331.clone());
                            {
                                let v332: string = v331.l0.get().clone();
                                trimEndChars(
                                    trimStartChars(
                                        sprintf!(
                                            "{} {} #{} {} / {}",
                                            v152,
                                            v328,
                                            v329,
                                            v1_1(),
                                            v332
                                        ),
                                        toArray(empty::<char>()),
                                    ),
                                    toArray(ofArray(new_array(&[' ', '/']))),
                                )
                            }
                        }
                    }
                }
            }
        }
    }
    pub fn method10(v0_1: Runtime::US0, v1_1: Func0<string>) {
        fn v2_1(
            v: Runtime::US0,
        ) -> (
            LrcPtr<Runtime::Mut0>,
            LrcPtr<Runtime::Mut1>,
            LrcPtr<Runtime::Mut2>,
            LrcPtr<Runtime::Mut3>,
            Option<i64>,
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
                LrcPtr<Runtime::Mut3>,
                Option<i64>,
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
                    LrcPtr<Runtime::Mut3>,
                    Option<i64>,
                ) = getValue(Runtime::State::trace_state().get().clone());
                let v15: Runtime::US0 = (patternInput_1.3.clone()).l0.get().clone();
                if if (patternInput_1.2.clone()).l0.get().clone() == false {
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
                        ((patternInput.1.clone()).l0.get().clone())(v24)
                    }
                }
            }
        }
    }
    pub fn method4(v0_1: Runtime::US0, v1_1: Func0<string>, v2_1: Func0<()>) {
        Runtime::method10(
            v0_1.clone(),
            Func0::new({
                let v0_1 = v0_1.clone();
                let v1_1 = v1_1.clone();
                let v2_1 = v2_1.clone();
                move || Runtime::closure6(v0_1.clone(), v1_1.clone(), v2_1.clone(), ())
            }),
        );
    }
    pub fn closure7(unitVar: (), unitVar_1: ()) -> string {
        string("runtime.current_process_kill / exiting... 2")
    }
    pub fn closure8(unitVar: (), unitVar_1: ()) -> string {
        string("runtime.current_process_kill / exiting... 1")
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
    pub fn closure2(unitVar: (), unitVar_1: ()) {
        let _v0: MutCell<Option<()>> = MutCell::new(None::<()>);
        defaultOf::<()>();
        _v0.set(Some(()));
        match &_v0.get().clone() {
            None => panic!("{}", string("base.run_target / _v0=None"),),
            Some(_v0_0_0) => _v0_0_0.clone(),
        }
        ()
    }
    pub fn method13(v0_1: i32, v1_1: LrcPtr<Runtime::Mut5>) -> bool {
        v1_1.l0.get().clone() < v0_1
    }
    pub fn closure12(v0_1: char, v1_1: LrcPtr<Runtime::UH0>) -> LrcPtr<Runtime::UH0> {
        LrcPtr::new(Runtime::UH0::UH0_1(v0_1, v1_1))
    }
    pub fn closure11(unitVar: (), v0_1: char) -> Func1<LrcPtr<Runtime::UH0>, LrcPtr<Runtime::UH0>> {
        Func1::new({
            let v0_1 = v0_1.clone();
            move |v: LrcPtr<Runtime::UH0>| Runtime::closure12(v0_1, v)
        })
    }
    pub fn method14() -> Func1<char, Func1<LrcPtr<Runtime::UH0>, LrcPtr<Runtime::UH0>>> {
        Func1::new(move |v: char| Runtime::closure11((), v))
    }
    pub fn method15(
        v0_1: LrcPtr<Runtime::UH0>,
        v1_1: LrcPtr<StringBuilder>,
        v2_1: i32,
        v3_1: i32,
    ) -> (LrcPtr<StringBuilder>, i32, i32) {
        let v0_1: MutCell<LrcPtr<Runtime::UH0>> = MutCell::new(v0_1.clone());
        let v1_1: MutCell<LrcPtr<StringBuilder>> = MutCell::new(v1_1.clone());
        let v2_1: MutCell<i32> = MutCell::new(v2_1);
        let v3_1: MutCell<i32> = MutCell::new(v3_1);
        '_method15: loop {
            break '_method15 (match v0_1.get().clone().as_ref() {
                Runtime::UH0::UH0_0 => (v1_1.get().clone(), v2_1.get().clone(), v3_1.get().clone()),
                Runtime::UH0::UH0_1(v0_1_1_0, v0_1_1_1) => {
                    let v4_1: char = match v0_1.get().clone().as_ref() {
                        Runtime::UH0::UH0_1(x, _) => x.clone(),
                        _ => unreachable!(),
                    };
                    let v6_1: bool = '\n' == v4_1;
                    let patternInput: (i32, i32) = if v6_1 {
                        (v2_1.get().clone() + 1_i32, 1_i32)
                    } else {
                        (v2_1.get().clone(), v3_1.get().clone() + 1_i32)
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
                        continue '_method15;
                    }
                }
            });
        }
    }
    pub fn closure10(unitVar: (), _arg: (string, LrcPtr<StringBuilder>, i32, i32)) -> Runtime::US5 {
        let v3_1: i32 = _arg.3.clone();
        let v2_1: i32 = _arg.2.clone();
        let v1_1: LrcPtr<StringBuilder> = _arg.1.clone();
        let v0_1: string = _arg.0.clone();
        if string("") == v0_1.clone() {
            Runtime::US5::US5_1(sprintf!(
                "parsing.p_char / unexpected end of input / s: {:?}",
                (v1_1.clone(), v2_1, v3_1)
            ))
        } else {
            let v7: char = getCharAt(v0_1.clone(), 0_i32);
            if v7 == '\"' {
                let v15: string = getSlice(v0_1.clone(), Some(1_i32), Some(length(v0_1.clone())));
                let v17: string = ofChar(v7);
                let v18: i32 = length(v17.clone());
                let v19: Array<char> = new_init(&'\u{0000}', v18);
                let v20: LrcPtr<Runtime::Mut5> = LrcPtr::new(Runtime::Mut5 {
                    l0: MutCell::new(0_i32),
                });
                while Runtime::method13(v18, v20.clone()) {
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
                    let patternInput: (LrcPtr<StringBuilder>, i32, i32) = Runtime::method15(
                        foldBack(
                            Func2::new(move |b0: char, b1: LrcPtr<Runtime::UH0>| {
                                (Runtime::method14())(b0)(b1)
                            }),
                            v26,
                            LrcPtr::new(Runtime::UH0::UH0_0),
                        ),
                        v1_1.clone(),
                        v2_1,
                        v3_1,
                    );
                    Runtime::US5::US5_0(
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
                Runtime::US5::US5_1(sprintf!(
                    "{}\n{}\n",
                    sprintf!(
                        "parsing.p_char / expected: \'{}\' / line: {} / col: {}\n{}{}",
                        '\"',
                        v2_1,
                        v3_1,
                        v1_1,
                        getSlice(
                            v0_1,
                            Some(0_i32),
                            Some(if -2_i32 == v41 { v38 } else { v41 })
                        )
                    ),
                    append(replicate(v3_1 - 1_i32, string(" ")), string("^"))
                ))
            }
        }
    }
    pub fn closure13(unitVar: (), _arg: (string, LrcPtr<StringBuilder>, i32, i32)) -> Runtime::US5 {
        let v3_1: i32 = _arg.3.clone();
        let v2_1: i32 = _arg.2.clone();
        let v1_1: LrcPtr<StringBuilder> = _arg.1.clone();
        let v0_1: string = _arg.0.clone();
        if string("") == v0_1.clone() {
            Runtime::US5::US5_1(sprintf!(
                "parsing.p_char / unexpected end of input / s: {:?}",
                (v1_1.clone(), v2_1, v3_1)
            ))
        } else {
            let v7: char = getCharAt(v0_1.clone(), 0_i32);
            if v7 == '\'' {
                let v15: string = getSlice(v0_1.clone(), Some(1_i32), Some(length(v0_1.clone())));
                let v17: string = ofChar(v7);
                let v18: i32 = length(v17.clone());
                let v19: Array<char> = new_init(&'\u{0000}', v18);
                let v20: LrcPtr<Runtime::Mut5> = LrcPtr::new(Runtime::Mut5 {
                    l0: MutCell::new(0_i32),
                });
                while Runtime::method13(v18, v20.clone()) {
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
                    let patternInput: (LrcPtr<StringBuilder>, i32, i32) = Runtime::method15(
                        foldBack(
                            Func2::new(move |b0: char, b1: LrcPtr<Runtime::UH0>| {
                                (Runtime::method14())(b0)(b1)
                            }),
                            v26,
                            LrcPtr::new(Runtime::UH0::UH0_0),
                        ),
                        v1_1.clone(),
                        v2_1,
                        v3_1,
                    );
                    Runtime::US5::US5_0(
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
                Runtime::US5::US5_1(sprintf!(
                    "{}\n{}\n",
                    sprintf!(
                        "parsing.p_char / expected: \'{}\' / line: {} / col: {}\n{}{}",
                        '\'',
                        v2_1,
                        v3_1,
                        v1_1,
                        getSlice(
                            v0_1,
                            Some(0_i32),
                            Some(if -2_i32 == v41 { v38 } else { v41 })
                        )
                    ),
                    append(replicate(v3_1 - 1_i32, string(" ")), string("^"))
                ))
            }
        }
    }
    pub fn method16(
        v0_1: string,
        v1_1: LrcPtr<StringBuilder>,
        v2_1: LrcPtr<Runtime::UH1>,
    ) -> Runtime::US5 {
        let v0_1: MutCell<string> = MutCell::new(v0_1.clone());
        let v1_1: MutCell<LrcPtr<StringBuilder>> = MutCell::new(v1_1.clone());
        let v2_1: MutCell<LrcPtr<Runtime::UH1>> = MutCell::new(v2_1.clone());
        '_method16: loop {
            break '_method16 (match v2_1.get().clone().as_ref() {
                Runtime::UH1::UH1_0 => Runtime::US5::US5_1(string("choice / no parsers succeeded")),
                Runtime::UH1::UH1_1(v2_1_1_0, v2_1_1_1) => {
                    let v7: Runtime::US5 = (match v2_1.get().clone().as_ref() {
                        Runtime::UH1::UH1_1(x, _) => x.clone(),
                        _ => unreachable!(),
                    })((
                        v0_1.get().clone(),
                        v1_1.get().clone(),
                        1_i32,
                        1_i32,
                    ));
                    match &v7 {
                        Runtime::US5::US5_0(v7_0_0, v7_0_1, v7_0_2, v7_0_3, v7_0_4) => v7.clone(),
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
                            continue '_method16;
                        }
                    }
                }
            });
        }
    }
    pub fn method17(v0_1: char, v1_1: i64) -> bool {
        let v0_1: MutCell<char> = MutCell::new(v0_1);
        let v1_1: MutCell<i64> = MutCell::new(v1_1);
        '_method17: loop {
            break '_method17 (if v1_1.get().clone() >= 2_i64 {
                false
            } else {
                let v11: Runtime::US7 = if v1_1.get().clone() == 0_i64 {
                    Runtime::US7::US7_0('\"')
                } else {
                    let v5_1: i64 = v1_1.get().clone() - 1_i64;
                    if v5_1 == 0_i64 {
                        Runtime::US7::US7_0('\'')
                    } else {
                        let v8: i64 = v5_1 - 1_i64;
                        Runtime::US7::US7_1
                    }
                };
                if v0_1.get().clone()
                    == match &v11 {
                        Runtime::US7::US7_0(v11_0_0) => match &v11 {
                            Runtime::US7::US7_0(x) => x.clone(),
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
                    continue '_method17;
                }
            });
        }
    }
    pub fn method18(
        v0_1: string,
        v1_1: string,
        v2_1: LrcPtr<StringBuilder>,
        v3_1: i32,
        v4_1: i32,
    ) -> Runtime::US6 {
        let v0_1: MutCell<string> = MutCell::new(v0_1.clone());
        let v1_1: MutCell<string> = MutCell::new(v1_1.clone());
        let v2_1: MutCell<LrcPtr<StringBuilder>> = MutCell::new(v2_1.clone());
        let v3_1: MutCell<i32> = MutCell::new(v3_1);
        let v4_1: MutCell<i32> = MutCell::new(v4_1);
        '_method18: loop {
            break '_method18 ({
                let v53: Runtime::US5 = if string("") == v1_1.get().clone() {
                    Runtime::US5::US5_1(sprintf!(
                        "parsing.none_of / unexpected end of input / chars: {:?} / s: {:?}",
                        toArray(ofArray(new_array(&['\"', '\'']))),
                        (v2_1.get().clone(), v3_1.get().clone(), v4_1.get().clone())
                    ))
                } else {
                    let v13: char = getCharAt(v1_1.get().clone(), 0_i32);
                    let v20: string = getSlice(
                        v1_1.get().clone(),
                        Some(1_i32),
                        Some(length(v1_1.get().clone())),
                    );
                    if Runtime::method17(v13, 0_i64) == false {
                        let v25: string = ofChar(v13);
                        let v26: i32 = length(v25.clone());
                        let v27: Array<char> = new_init(&'\u{0000}', v26);
                        let v28: LrcPtr<Runtime::Mut5> = LrcPtr::new(Runtime::Mut5 {
                            l0: MutCell::new(0_i32),
                        });
                        while Runtime::method13(v26, v28.clone()) {
                            let v30: i32 = v28.l0.get().clone();
                            let v31: char = getCharAt(v25.clone(), v30);
                            v27.get_mut()[v30 as usize] = v31;
                            {
                                let v32: i32 = v30 + 1_i32;
                                v28.l0.set(v32);
                                ()
                            }
                        }
                        {
                            let v34: List<char> = ofArray(v27.clone());
                            let patternInput: (LrcPtr<StringBuilder>, i32, i32) = Runtime::method15(
                                foldBack(
                                    Func2::new(move |b0: char, b1: LrcPtr<Runtime::UH0>| {
                                        (Runtime::method14())(b0)(b1)
                                    }),
                                    v34,
                                    LrcPtr::new(Runtime::UH0::UH0_0),
                                ),
                                v2_1.get().clone(),
                                v3_1.get().clone(),
                                v4_1.get().clone(),
                            );
                            Runtime::US5::US5_0(
                                v13,
                                v20,
                                patternInput.0.clone(),
                                patternInput.1.clone(),
                                patternInput.2.clone(),
                            )
                        }
                    } else {
                        Runtime::US5::US5_1(sprintf!(
                            "parsing.none_of / unexpected char: \'{}\' / chars: {:?} / s: {:?}",
                            v13,
                            toArray(ofArray(new_array(&['\"', '\'']))),
                            (v2_1.get().clone(), v3_1.get().clone(), v4_1.get().clone())
                        ))
                    }
                };
                let v65: Runtime::US5 = match &v53 {
                    Runtime::US5::US5_0(v53_0_0, v53_0_1, v53_0_2, v53_0_3, v53_0_4) => {
                        let v54: char = v53_0_0.clone();
                        Runtime::US5::US5_0(
                            if '\\' == v54 { '/' } else { v54 },
                            v53_0_1.clone(),
                            v53_0_2.clone(),
                            v53_0_3.clone(),
                            v53_0_4.clone(),
                        )
                    }
                    Runtime::US5::US5_1(v53_1_0) => Runtime::US5::US5_1(v53_1_0.clone()),
                };
                match &v65 {
                    Runtime::US5::US5_0(v65_0_0, v65_0_1, v65_0_2, v65_0_3, v65_0_4) => {
                        let v0_1_temp: string = append(v0_1.get().clone(), ofChar(v65_0_0.clone()));
                        let v1_1_temp: string = v65_0_1.clone();
                        let v2_1_temp: LrcPtr<StringBuilder> = v65_0_2.clone();
                        let v3_1_temp: i32 = v65_0_3.clone();
                        let v4_1_temp: i32 = v65_0_4.clone();
                        v0_1.set(v0_1_temp);
                        v1_1.set(v1_1_temp);
                        v2_1.set(v2_1_temp);
                        v3_1.set(v3_1_temp);
                        v4_1.set(v4_1_temp);
                        continue '_method18;
                    }
                    _ => Runtime::US6::US6_0(
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
    pub fn method19(
        v0_1: string,
        v1_1: LrcPtr<StringBuilder>,
        v2_1: i32,
        v3_1: i32,
        v4_1: LrcPtr<Runtime::UH1>,
    ) -> Runtime::US5 {
        let v0_1: MutCell<string> = MutCell::new(v0_1.clone());
        let v1_1: MutCell<LrcPtr<StringBuilder>> = MutCell::new(v1_1.clone());
        let v2_1: MutCell<i32> = MutCell::new(v2_1);
        let v3_1: MutCell<i32> = MutCell::new(v3_1);
        let v4_1: MutCell<LrcPtr<Runtime::UH1>> = MutCell::new(v4_1.clone());
        '_method19: loop {
            break '_method19 (match v4_1.get().clone().as_ref() {
                Runtime::UH1::UH1_0 => Runtime::US5::US5_1(string("choice / no parsers succeeded")),
                Runtime::UH1::UH1_1(v4_1_1_0, v4_1_1_1) => {
                    let v9: Runtime::US5 = (match v4_1.get().clone().as_ref() {
                        Runtime::UH1::UH1_1(x, _) => x.clone(),
                        _ => unreachable!(),
                    })((
                        v0_1.get().clone(),
                        v1_1.get().clone(),
                        v2_1.get().clone(),
                        v3_1.get().clone(),
                    ));
                    match &v9 {
                        Runtime::US5::US5_0(v9_0_0, v9_0_1, v9_0_2, v9_0_3, v9_0_4) => v9.clone(),
                        _ => {
                            let v0_1_temp: string = v0_1.get().clone();
                            let v1_1_temp: LrcPtr<StringBuilder> = v1_1.get().clone();
                            let v2_1_temp: i32 = v2_1.get().clone();
                            let v3_1_temp: i32 = v3_1.get().clone();
                            let v4_1_temp: LrcPtr<Runtime::UH1> = match v4_1.get().clone().as_ref()
                            {
                                Runtime::UH1::UH1_1(_, x) => x.clone(),
                                _ => unreachable!(),
                            };
                            v0_1.set(v0_1_temp);
                            v1_1.set(v1_1_temp);
                            v2_1.set(v2_1_temp);
                            v3_1.set(v3_1_temp);
                            v4_1.set(v4_1_temp);
                            continue '_method19;
                        }
                    }
                }
            });
        }
    }
    pub fn method20(v0_1: char, v1_1: i64) -> bool {
        let v0_1: MutCell<char> = MutCell::new(v0_1);
        let v1_1: MutCell<i64> = MutCell::new(v1_1);
        '_method20: loop {
            break '_method20 (if v1_1.get().clone() >= 3_i64 {
                false
            } else {
                let v15: Runtime::US7 = if v1_1.get().clone() == 0_i64 {
                    Runtime::US7::US7_0('\"')
                } else {
                    let v5_1: i64 = v1_1.get().clone() - 1_i64;
                    if v5_1 == 0_i64 {
                        Runtime::US7::US7_0('\'')
                    } else {
                        let v8: i64 = v5_1 - 1_i64;
                        if v8 == 0_i64 {
                            Runtime::US7::US7_0(' ')
                        } else {
                            let v11: i64 = v8 - 1_i64;
                            Runtime::US7::US7_1
                        }
                    }
                };
                if v0_1.get().clone()
                    == match &v15 {
                        Runtime::US7::US7_0(v15_0_0) => match &v15 {
                            Runtime::US7::US7_0(x) => x.clone(),
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
                    continue '_method20;
                }
            });
        }
    }
    pub fn method21(
        v0_1: string,
        v1_1: string,
        v2_1: LrcPtr<StringBuilder>,
        v3_1: i32,
        v4_1: i32,
    ) -> Runtime::US6 {
        let v0_1: MutCell<string> = MutCell::new(v0_1.clone());
        let v1_1: MutCell<string> = MutCell::new(v1_1.clone());
        let v2_1: MutCell<LrcPtr<StringBuilder>> = MutCell::new(v2_1.clone());
        let v3_1: MutCell<i32> = MutCell::new(v3_1);
        let v4_1: MutCell<i32> = MutCell::new(v4_1);
        '_method21: loop {
            break '_method21 ({
                let v55: Runtime::US5 = if string("") == v1_1.get().clone() {
                    Runtime::US5::US5_1(sprintf!(
                        "parsing.none_of / unexpected end of input / chars: {:?} / s: {:?}",
                        toArray(ofArray(new_array(&['\"', '\'', ' ']))),
                        (v2_1.get().clone(), v3_1.get().clone(), v4_1.get().clone())
                    ))
                } else {
                    let v14: char = getCharAt(v1_1.get().clone(), 0_i32);
                    let v21: string = getSlice(
                        v1_1.get().clone(),
                        Some(1_i32),
                        Some(length(v1_1.get().clone())),
                    );
                    if Runtime::method20(v14, 0_i64) == false {
                        let v26: string = ofChar(v14);
                        let v27: i32 = length(v26.clone());
                        let v28: Array<char> = new_init(&'\u{0000}', v27);
                        let v29: LrcPtr<Runtime::Mut5> = LrcPtr::new(Runtime::Mut5 {
                            l0: MutCell::new(0_i32),
                        });
                        while Runtime::method13(v27, v29.clone()) {
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
                            let patternInput: (LrcPtr<StringBuilder>, i32, i32) = Runtime::method15(
                                foldBack(
                                    Func2::new(move |b0: char, b1: LrcPtr<Runtime::UH0>| {
                                        (Runtime::method14())(b0)(b1)
                                    }),
                                    v35,
                                    LrcPtr::new(Runtime::UH0::UH0_0),
                                ),
                                v2_1.get().clone(),
                                v3_1.get().clone(),
                                v4_1.get().clone(),
                            );
                            Runtime::US5::US5_0(
                                v14,
                                v21,
                                patternInput.0.clone(),
                                patternInput.1.clone(),
                                patternInput.2.clone(),
                            )
                        }
                    } else {
                        Runtime::US5::US5_1(sprintf!(
                            "parsing.none_of / unexpected char: \'{}\' / chars: {:?} / s: {:?}",
                            v14,
                            toArray(ofArray(new_array(&['\"', '\'', ' ']))),
                            (v2_1.get().clone(), v3_1.get().clone(), v4_1.get().clone())
                        ))
                    }
                };
                let v67: Runtime::US5 = match &v55 {
                    Runtime::US5::US5_0(v55_0_0, v55_0_1, v55_0_2, v55_0_3, v55_0_4) => {
                        let v56: char = v55_0_0.clone();
                        Runtime::US5::US5_0(
                            if '\\' == v56 { '/' } else { v56 },
                            v55_0_1.clone(),
                            v55_0_2.clone(),
                            v55_0_3.clone(),
                            v55_0_4.clone(),
                        )
                    }
                    Runtime::US5::US5_1(v55_1_0) => Runtime::US5::US5_1(v55_1_0.clone()),
                };
                match &v67 {
                    Runtime::US5::US5_0(v67_0_0, v67_0_1, v67_0_2, v67_0_3, v67_0_4) => {
                        let v0_1_temp: string = append(v0_1.get().clone(), ofChar(v67_0_0.clone()));
                        let v1_1_temp: string = v67_0_1.clone();
                        let v2_1_temp: LrcPtr<StringBuilder> = v67_0_2.clone();
                        let v3_1_temp: i32 = v67_0_3.clone();
                        let v4_1_temp: i32 = v67_0_4.clone();
                        v0_1.set(v0_1_temp);
                        v1_1.set(v1_1_temp);
                        v2_1.set(v2_1_temp);
                        v3_1.set(v3_1_temp);
                        v4_1.set(v4_1_temp);
                        continue '_method21;
                    }
                    _ => Runtime::US6::US6_0(
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
    pub fn method22(v0_1: string, v1_1: i32) -> i32 {
        let v0_1: MutCell<string> = MutCell::new(v0_1.clone());
        let v1_1: MutCell<i32> = MutCell::new(v1_1);
        '_method22: loop {
            break '_method22 (if v1_1.get().clone() >= length(v0_1.get().clone()) {
                v1_1.get().clone()
            } else {
                if getCharAt(v0_1.get().clone(), v1_1.get().clone()) == ' ' {
                    let v0_1_temp: string = v0_1.get().clone();
                    let v1_1_temp: i32 = v1_1.get().clone() + 1_i32;
                    v0_1.set(v0_1_temp);
                    v1_1.set(v1_1_temp);
                    continue '_method22;
                } else {
                    v1_1.get().clone()
                }
            });
        }
    }
    pub fn method23(
        v0_1: string,
        v1_1: string,
        v2_1: LrcPtr<StringBuilder>,
        v3_1: i32,
        v4_1: i32,
    ) -> Runtime::US6 {
        let v0_1: MutCell<string> = MutCell::new(v0_1.clone());
        let v1_1: MutCell<string> = MutCell::new(v1_1.clone());
        let v2_1: MutCell<LrcPtr<StringBuilder>> = MutCell::new(v2_1.clone());
        let v3_1: MutCell<i32> = MutCell::new(v3_1);
        let v4_1: MutCell<i32> = MutCell::new(v4_1);
        '_method23: loop {
            break '_method23 ({
                let v37: Runtime::US5 = if string("") == v1_1.get().clone() {
                    Runtime::US5::US5_1(sprintf!(
                        "parsing.any_char / unexpected end of input / s: {:?}",
                        (v2_1.get().clone(), v3_1.get().clone(), v4_1.get().clone())
                    ))
                } else {
                    let v8: char = getCharAt(v1_1.get().clone(), 0_i32);
                    let v15: string = getSlice(
                        v1_1.get().clone(),
                        Some(1_i32),
                        Some(length(v1_1.get().clone())),
                    );
                    let v17: string = ofChar(v8);
                    let v18: i32 = length(v17.clone());
                    let v19: Array<char> = new_init(&'\u{0000}', v18);
                    let v20: LrcPtr<Runtime::Mut5> = LrcPtr::new(Runtime::Mut5 {
                        l0: MutCell::new(0_i32),
                    });
                    while Runtime::method13(v18, v20.clone()) {
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
                        let patternInput: (LrcPtr<StringBuilder>, i32, i32) = Runtime::method15(
                            foldBack(
                                Func2::new(move |b0: char, b1: LrcPtr<Runtime::UH0>| {
                                    (Runtime::method14())(b0)(b1)
                                }),
                                v26,
                                LrcPtr::new(Runtime::UH0::UH0_0),
                            ),
                            v2_1.get().clone(),
                            v3_1.get().clone(),
                            v4_1.get().clone(),
                        );
                        Runtime::US5::US5_0(
                            v8,
                            v15,
                            patternInput.0.clone(),
                            patternInput.1.clone(),
                            patternInput.2.clone(),
                        )
                    }
                };
                match &v37 {
                    Runtime::US5::US5_0(v37_0_0, v37_0_1, v37_0_2, v37_0_3, v37_0_4) => {
                        let v0_1_temp: string = append(v0_1.get().clone(), ofChar(v37_0_0.clone()));
                        let v1_1_temp: string = v37_0_1.clone();
                        let v2_1_temp: LrcPtr<StringBuilder> = v37_0_2.clone();
                        let v3_1_temp: i32 = v37_0_3.clone();
                        let v4_1_temp: i32 = v37_0_4.clone();
                        v0_1.set(v0_1_temp);
                        v1_1.set(v1_1_temp);
                        v2_1.set(v2_1_temp);
                        v3_1.set(v3_1_temp);
                        v4_1.set(v4_1_temp);
                        continue '_method23;
                    }
                    _ => Runtime::US6::US6_0(
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
    pub fn method12(v0_1: string) -> Runtime::US4 {
        let _v0: MutCell<Option<Option<string>>> = MutCell::new(None::<Option<string>>);
        _v0.set(Some(Some(v0_1)));
        {
            let v5_1: string = defaultValue(
                string(""),
                match &_v0.get().clone() {
                    None => panic!("{}", string("optionm\'.of_obj / _v0=None"),),
                    Some(_v0_0_0) => _v0_0_0.clone(),
                },
            );
            let v7: LrcPtr<StringBuilder> = StringBuilder::_ctor__Z721C83C5(string(""));
            fn v8(arg10_0040: (string, LrcPtr<StringBuilder>, i32, i32)) -> Runtime::US5 {
                Runtime::closure10((), arg10_0040)
            }
            fn v9(arg10_0040_1: (string, LrcPtr<StringBuilder>, i32, i32)) -> Runtime::US5 {
                Runtime::closure13((), arg10_0040_1)
            }
            let v13: Runtime::US5 = Runtime::method16(
                v5_1.clone(),
                v7.clone(),
                LrcPtr::new(Runtime::UH1::UH1_1(
                    Func1::from(v8),
                    LrcPtr::new(Runtime::UH1::UH1_1(
                        Func1::from(v9),
                        LrcPtr::new(Runtime::UH1::UH1_0),
                    )),
                )),
            );
            let v130: Runtime::US6 = match &v13 {
                Runtime::US5::US5_0(v13_0_0, v13_0_1, v13_0_2, v13_0_3, v13_0_4) => {
                    let v18: i32 = v13_0_4.clone();
                    let v17: i32 = v13_0_3.clone();
                    let v16: LrcPtr<StringBuilder> = v13_0_2.clone();
                    let v15: string = v13_0_1.clone();
                    let v67: Runtime::US5 = if string("") == v15.clone() {
                        Runtime::US5::US5_1(sprintf!(
                            "parsing.none_of / unexpected end of input / chars: {:?} / s: {:?}",
                            toArray(ofArray(new_array(&['\"', '\'']))),
                            (v16.clone(), v17, v18)
                        ))
                    } else {
                        let v27: char = getCharAt(v15.clone(), 0_i32);
                        let v34: string =
                            getSlice(v15.clone(), Some(1_i32), Some(length(v15.clone())));
                        if Runtime::method17(v27, 0_i64) == false {
                            let v39: string = ofChar(v27);
                            let v40: i32 = length(v39.clone());
                            let v41: Array<char> = new_init(&'\u{0000}', v40);
                            let v42: LrcPtr<Runtime::Mut5> = LrcPtr::new(Runtime::Mut5 {
                                l0: MutCell::new(0_i32),
                            });
                            while Runtime::method13(v40, v42.clone()) {
                                let v44: i32 = v42.l0.get().clone();
                                let v45: char = getCharAt(v39.clone(), v44);
                                v41.get_mut()[v44 as usize] = v45;
                                {
                                    let v46: i32 = v44 + 1_i32;
                                    v42.l0.set(v46);
                                    ()
                                }
                            }
                            {
                                let v48: List<char> = ofArray(v41.clone());
                                let patternInput: (LrcPtr<StringBuilder>, i32, i32) =
                                    Runtime::method15(
                                        foldBack(
                                            Func2::new(
                                                move |b0: char, b1: LrcPtr<Runtime::UH0>| {
                                                    (Runtime::method14())(b0)(b1)
                                                },
                                            ),
                                            v48,
                                            LrcPtr::new(Runtime::UH0::UH0_0),
                                        ),
                                        v16.clone(),
                                        v17,
                                        v18,
                                    );
                                Runtime::US5::US5_0(
                                    v27,
                                    v34,
                                    patternInput.0.clone(),
                                    patternInput.1.clone(),
                                    patternInput.2.clone(),
                                )
                            }
                        } else {
                            Runtime::US5::US5_1(sprintf!(
                                "parsing.none_of / unexpected char: \'{}\' / chars: {:?} / s: {:?}",
                                v27,
                                toArray(ofArray(new_array(&['\"', '\'']))),
                                (v16.clone(), v17, v18)
                            ))
                        }
                    };
                    let v79: Runtime::US5 = match &v67 {
                        Runtime::US5::US5_0(v67_0_0, v67_0_1, v67_0_2, v67_0_3, v67_0_4) => {
                            let v68: char = v67_0_0.clone();
                            Runtime::US5::US5_0(
                                if '\\' == v68 { '/' } else { v68 },
                                v67_0_1.clone(),
                                v67_0_2.clone(),
                                v67_0_3.clone(),
                                v67_0_4.clone(),
                            )
                        }
                        Runtime::US5::US5_1(v67_1_0) => Runtime::US5::US5_1(v67_1_0.clone()),
                    };
                    let v91: Runtime::US6 = match &v79 {
                        Runtime::US5::US5_0(v79_0_0, v79_0_1, v79_0_2, v79_0_3, v79_0_4) => {
                            Runtime::method18(
                                ofChar(v79_0_0.clone()),
                                v79_0_1.clone(),
                                v79_0_2.clone(),
                                v79_0_3.clone(),
                                v79_0_4.clone(),
                            )
                        }
                        Runtime::US5::US5_1(v79_1_0) => Runtime::US6::US6_1(v79_1_0.clone()),
                    };
                    let v101: Runtime::US6 = match &v91 {
                        Runtime::US6::US6_0(v91_0_0, v91_0_1, v91_0_2, v91_0_3, v91_0_4) => {
                            Runtime::US6::US6_0(
                                v91_0_0.clone(),
                                v91_0_1.clone(),
                                v91_0_2.clone(),
                                v91_0_3.clone(),
                                v91_0_4.clone(),
                            )
                        }
                        _ => Runtime::US6::US6_0(string(""), v15.clone(), v16.clone(), v17, v18),
                    };
                    match &v101 {
                        Runtime::US6::US6_0(v101_0_0, v101_0_1, v101_0_2, v101_0_3, v101_0_4) => {
                            let v106: i32 = v101_0_4.clone();
                            let v105: i32 = v101_0_3.clone();
                            let v104: LrcPtr<StringBuilder> = v101_0_2.clone();
                            let v103: string = v101_0_1.clone();
                            let v110: Runtime::US5 = Runtime::method19(
                                v103.clone(),
                                v104.clone(),
                                v105,
                                v106,
                                LrcPtr::new(Runtime::UH1::UH1_1(
                                    Func1::from(v8),
                                    LrcPtr::new(Runtime::UH1::UH1_1(
                                        Func1::from(v9),
                                        LrcPtr::new(Runtime::UH1::UH1_0),
                                    )),
                                )),
                            );
                            match &v110 {
                                    Runtime::US5::US5_0(v110_0_0, v110_0_1,
                                                        v110_0_2, v110_0_3,
                                                        v110_0_4) =>
                                    Runtime::US6::US6_0(v101_0_0.clone(),
                                                        v110_0_1.clone(),
                                                        v110_0_2.clone(),
                                                        v110_0_3.clone(),
                                                        v110_0_4.clone()),
                                    Runtime::US5::US5_1(v110_1_0) =>
                                    Runtime::US6::US6_1(sprintf!("between / expected closing delimiter / e: {:?} / input: {:?} / rest1: {:?} / rest2: {:?}",
                                                                 v110_1_0.clone(),
                                                                 (v5_1.clone(),
                                                                  v7.clone(),
                                                                  1_i32,
                                                                  1_i32),
                                                                 (v15, v16,
                                                                  v17, v18),
                                                                 (v103, v104,
                                                                  v105,
                                                                  v106))),
                                }
                        }
                        _ => Runtime::US6::US6_1(string("between / expected content")),
                    }
                }
                Runtime::US5::US5_1(v13_1_0) => Runtime::US6::US6_1(v13_1_0.clone()),
            };
            let v257: Runtime::US6 = match &v130 {
                Runtime::US6::US6_0(v130_0_0, v130_0_1, v130_0_2, v130_0_3, v130_0_4) => {
                    v130.clone()
                }
                _ => {
                    let v189: Runtime::US5 = if string("") == v5_1.clone() {
                        Runtime::US5::US5_1(sprintf!(
                            "parsing.none_of / unexpected end of input / chars: {:?} / s: {:?}",
                            toArray(ofArray(new_array(&['\"', '\'', ' ']))),
                            (v7.clone(), 1_i32, 1_i32)
                        ))
                    } else {
                        let v146: char = getCharAt(v5_1.clone(), 0_i32);
                        let v153: string =
                            getSlice(v5_1.clone(), Some(1_i32), Some(length(v5_1.clone())));
                        if Runtime::method20(v146, 0_i64) == false {
                            let v158: string = ofChar(v146);
                            let v159: i32 = length(v158.clone());
                            let v160: Array<char> = new_init(&'\u{0000}', v159);
                            let v161: LrcPtr<Runtime::Mut5> = LrcPtr::new(Runtime::Mut5 {
                                l0: MutCell::new(0_i32),
                            });
                            while Runtime::method13(v159, v161.clone()) {
                                let v163: i32 = v161.l0.get().clone();
                                let v164: char = getCharAt(v158.clone(), v163);
                                v160.get_mut()[v163 as usize] = v164;
                                {
                                    let v165: i32 = v163 + 1_i32;
                                    v161.l0.set(v165);
                                    ()
                                }
                            }
                            {
                                let v167: List<char> = ofArray(v160.clone());
                                let patternInput_1: (LrcPtr<StringBuilder>, i32, i32) =
                                    Runtime::method15(
                                        foldBack(
                                            Func2::new(
                                                move |b0: char, b1: LrcPtr<Runtime::UH0>| {
                                                    (Runtime::method14())(b0)(b1)
                                                },
                                            ),
                                            v167,
                                            LrcPtr::new(Runtime::UH0::UH0_0),
                                        ),
                                        v7.clone(),
                                        1_i32,
                                        1_i32,
                                    );
                                Runtime::US5::US5_0(
                                    v146,
                                    v153,
                                    patternInput_1.0.clone(),
                                    patternInput_1.1.clone(),
                                    patternInput_1.2.clone(),
                                )
                            }
                        } else {
                            Runtime::US5::US5_1(sprintf!(
                                "parsing.none_of / unexpected char: \'{}\' / chars: {:?} / s: {:?}",
                                v146,
                                toArray(ofArray(new_array(&['\"', '\'', ' ']))),
                                (v7.clone(), 1_i32, 1_i32)
                            ))
                        }
                    };
                    let v201: Runtime::US5 = match &v189 {
                        Runtime::US5::US5_0(v189_0_0, v189_0_1, v189_0_2, v189_0_3, v189_0_4) => {
                            let v190: char = v189_0_0.clone();
                            Runtime::US5::US5_0(
                                if '\\' == v190 { '/' } else { v190 },
                                v189_0_1.clone(),
                                v189_0_2.clone(),
                                v189_0_3.clone(),
                                v189_0_4.clone(),
                            )
                        }
                        Runtime::US5::US5_1(v189_1_0) => Runtime::US5::US5_1(v189_1_0.clone()),
                    };
                    let v213: Runtime::US6 = match &v201 {
                        Runtime::US5::US5_0(v201_0_0, v201_0_1, v201_0_2, v201_0_3, v201_0_4) => {
                            Runtime::method21(
                                ofChar(v201_0_0.clone()),
                                v201_0_1.clone(),
                                v201_0_2.clone(),
                                v201_0_3.clone(),
                                v201_0_4.clone(),
                            )
                        }
                        Runtime::US5::US5_1(v201_1_0) => Runtime::US6::US6_1(v201_1_0.clone()),
                    };
                    match &v213 {
                        Runtime::US6::US6_0(v213_0_0, v213_0_1, v213_0_2, v213_0_3, v213_0_4) => {
                            v213.clone()
                        }
                        _ => {
                            let v225: Runtime::US8 = if length(v5_1.clone()) == 0_i32 {
                                Runtime::US8::US8_0(v5_1.clone(), v7.clone(), 1_i32, 1_i32)
                            } else {
                                Runtime::US8::US8_1(sprintf!(
                                    "parsing.eof / expected end of input / input: {:?}",
                                    v5_1.clone()
                                ))
                            };
                            let v234: Runtime::US6 = match &v225 {
                                Runtime::US8::US8_0(v225_0_0, v225_0_1, v225_0_2, v225_0_3) => {
                                    Runtime::US6::US6_0(
                                        string(""),
                                        v225_0_0.clone(),
                                        v225_0_1.clone(),
                                        v225_0_2.clone(),
                                        v225_0_3.clone(),
                                    )
                                }
                                Runtime::US8::US8_1(v225_1_0) => {
                                    Runtime::US6::US6_1(v225_1_0.clone())
                                }
                            };
                            match &v234 {
                                Runtime::US6::US6_0(
                                    v234_0_0,
                                    v234_0_1,
                                    v234_0_2,
                                    v234_0_3,
                                    v234_0_4,
                                ) => {
                                    let v236: string = v234_0_1.clone();
                                    Runtime::US6::US6_0(
                                        v234_0_0.clone(),
                                        getSlice(
                                            v236.clone(),
                                            Some(Runtime::method22(v236.clone(), 0_i32)),
                                            Some(length(v236)),
                                        ),
                                        v234_0_2.clone(),
                                        v234_0_3.clone(),
                                        v234_0_4.clone(),
                                    )
                                }
                                Runtime::US6::US6_1(v234_1_0) => {
                                    Runtime::US6::US6_1(v234_1_0.clone())
                                }
                            }
                        }
                    }
                }
            };
            let v411: Runtime::US9 = match &v257 {
                Runtime::US6::US6_0(v257_0_0, v257_0_1, v257_0_2, v257_0_3, v257_0_4) => {
                    let v262: i32 = v257_0_4.clone();
                    let v261: i32 = v257_0_3.clone();
                    let v260: LrcPtr<StringBuilder> = v257_0_2.clone();
                    let v259: string = v257_0_1.clone();
                    let v319: Runtime::US5 = if string("") == v259.clone() {
                        Runtime::US5::US5_1(sprintf!(
                            "parsing.p_char / unexpected end of input / s: {:?}",
                            (v260.clone(), v261, v262)
                        ))
                    } else {
                        let v266: char = getCharAt(v259.clone(), 0_i32);
                        if v266 == ' ' {
                            let v274: string =
                                getSlice(v259.clone(), Some(1_i32), Some(length(v259.clone())));
                            let v276: string = ofChar(v266);
                            let v277: i32 = length(v276.clone());
                            let v278: Array<char> = new_init(&'\u{0000}', v277);
                            let v279: LrcPtr<Runtime::Mut5> = LrcPtr::new(Runtime::Mut5 {
                                l0: MutCell::new(0_i32),
                            });
                            while Runtime::method13(v277, v279.clone()) {
                                let v281: i32 = v279.l0.get().clone();
                                let v282: char = getCharAt(v276.clone(), v281);
                                v278.get_mut()[v281 as usize] = v282;
                                {
                                    let v283: i32 = v281 + 1_i32;
                                    v279.l0.set(v283);
                                    ()
                                }
                            }
                            {
                                let v285: List<char> = ofArray(v278.clone());
                                let patternInput_2: (LrcPtr<StringBuilder>, i32, i32) =
                                    Runtime::method15(
                                        foldBack(
                                            Func2::new(
                                                move |b0: char, b1: LrcPtr<Runtime::UH0>| {
                                                    (Runtime::method14())(b0)(b1)
                                                },
                                            ),
                                            v285,
                                            LrcPtr::new(Runtime::UH0::UH0_0),
                                        ),
                                        v260.clone(),
                                        v261,
                                        v262,
                                    );
                                Runtime::US5::US5_0(
                                    v266,
                                    v274,
                                    patternInput_2.0.clone(),
                                    patternInput_2.1.clone(),
                                    patternInput_2.2.clone(),
                                )
                            }
                        } else {
                            let v297: i32 = length(v259.clone());
                            let v300: i32 = indexOf(v259.clone(), string("\n")) - 1_i32;
                            Runtime::US5::US5_1(sprintf!(
                                "{}\n{}\n",
                                sprintf!(
                                    "parsing.p_char / expected: \'{}\' / line: {} / col: {}\n{}{}",
                                    ' ',
                                    v261,
                                    v262,
                                    v260.clone(),
                                    getSlice(
                                        v259.clone(),
                                        Some(0_i32),
                                        Some(if -2_i32 == v300 { v297 } else { v300 })
                                    )
                                ),
                                append(replicate(v262 - 1_i32, string(" ")), string("^"))
                            ))
                        }
                    };
                    let v331: Runtime::US10 = match &v319 {
                        Runtime::US5::US5_0(v319_0_0, v319_0_1, v319_0_2, v319_0_3, v319_0_4) => {
                            Runtime::US10::US10_0(
                                Runtime::US7::US7_0(v319_0_0.clone()),
                                v319_0_1.clone(),
                                v319_0_2.clone(),
                                v319_0_3.clone(),
                                v319_0_4.clone(),
                            )
                        }
                        _ => Runtime::US10::US10_0(
                            Runtime::US7::US7_1,
                            v259.clone(),
                            v260.clone(),
                            v261,
                            v262,
                        ),
                    };
                    let v385: Runtime::US6 = match &v331 {
                        Runtime::US10::US10_0(v331_0_0, v331_0_1, v331_0_2, v331_0_3, v331_0_4) => {
                            let v336: i32 = v331_0_4.clone();
                            let v335: i32 = v331_0_3.clone();
                            let v334: LrcPtr<StringBuilder> = v331_0_2.clone();
                            let v333: string = v331_0_1.clone();
                            let v369: Runtime::US5 = if string("") == v333.clone() {
                                Runtime::US5::US5_1(sprintf!(
                                    "parsing.any_char / unexpected end of input / s: {:?}",
                                    (v334.clone(), v335, v336)
                                ))
                            } else {
                                let v340: char = getCharAt(v333.clone(), 0_i32);
                                let v347: string =
                                    getSlice(v333.clone(), Some(1_i32), Some(length(v333)));
                                let v349: string = ofChar(v340);
                                let v350: i32 = length(v349.clone());
                                let v351: Array<char> = new_init(&'\u{0000}', v350);
                                let v352: LrcPtr<Runtime::Mut5> = LrcPtr::new(Runtime::Mut5 {
                                    l0: MutCell::new(0_i32),
                                });
                                while Runtime::method13(v350, v352.clone()) {
                                    let v354: i32 = v352.l0.get().clone();
                                    let v355: char = getCharAt(v349.clone(), v354);
                                    v351.get_mut()[v354 as usize] = v355;
                                    {
                                        let v356: i32 = v354 + 1_i32;
                                        v352.l0.set(v356);
                                        ()
                                    }
                                }
                                {
                                    let v358: List<char> = ofArray(v351.clone());
                                    let patternInput_3: (LrcPtr<StringBuilder>, i32, i32) =
                                        Runtime::method15(
                                            foldBack(
                                                Func2::new(
                                                    move |b0: char, b1: LrcPtr<Runtime::UH0>| {
                                                        (Runtime::method14())(b0)(b1)
                                                    },
                                                ),
                                                v358,
                                                LrcPtr::new(Runtime::UH0::UH0_0),
                                            ),
                                            v334,
                                            v335,
                                            v336,
                                        );
                                    Runtime::US5::US5_0(
                                        v340,
                                        v347,
                                        patternInput_3.0.clone(),
                                        patternInput_3.1.clone(),
                                        patternInput_3.2.clone(),
                                    )
                                }
                            };
                            match &v369 {
                                Runtime::US5::US5_0(
                                    v369_0_0,
                                    v369_0_1,
                                    v369_0_2,
                                    v369_0_3,
                                    v369_0_4,
                                ) => Runtime::method23(
                                    ofChar(v369_0_0.clone()),
                                    v369_0_1.clone(),
                                    v369_0_2.clone(),
                                    v369_0_3.clone(),
                                    v369_0_4.clone(),
                                ),
                                Runtime::US5::US5_1(v369_1_0) => {
                                    Runtime::US6::US6_1(v369_1_0.clone())
                                }
                            }
                        }
                        Runtime::US10::US10_1(v331_1_0) => Runtime::US6::US6_1(v331_1_0.clone()),
                    };
                    let v397: Runtime::US11 = match &v385 {
                        Runtime::US6::US6_0(v385_0_0, v385_0_1, v385_0_2, v385_0_3, v385_0_4) => {
                            Runtime::US11::US11_0(
                                Runtime::US3::US3_0(v385_0_0.clone()),
                                v385_0_1.clone(),
                                v385_0_2.clone(),
                                v385_0_3.clone(),
                                v385_0_4.clone(),
                            )
                        }
                        _ => Runtime::US11::US11_0(Runtime::US3::US3_1, v259, v260, v261, v262),
                    };
                    match &v397 {
                        Runtime::US11::US11_0(v397_0_0, v397_0_1, v397_0_2, v397_0_3, v397_0_4) => {
                            Runtime::US9::US9_0(
                                v257_0_0.clone(),
                                v397_0_0.clone(),
                                v397_0_1.clone(),
                                v397_0_2.clone(),
                                v397_0_3.clone(),
                                v397_0_4.clone(),
                            )
                        }
                        Runtime::US11::US11_1(v397_1_0) => Runtime::US9::US9_1(v397_1_0.clone()),
                    }
                }
                Runtime::US6::US6_1(v257_1_0) => Runtime::US9::US9_1(v257_1_0.clone()),
            };
            match &v411 {
                Runtime::US9::US9_0(v411_0_0, v411_0_1, v411_0_2, v411_0_3, v411_0_4, v411_0_5) => {
                    Runtime::US4::US4_0(v411_0_0.clone(), v411_0_1.clone())
                }
                Runtime::US9::US9_1(v411_1_0) => Runtime::US4::US4_1(v411_1_0.clone()),
            }
        }
    }
    pub fn closure14(unitVar: (), unitVar_1: ()) -> string {
        string("runtime.execute_with_options_async")
    }
    pub fn closure15(
        v0_1: string,
        v1_1: Option<CancellationToken>,
        v2_1: Array<(string, string)>,
        v3_1: Option<Func1<(i32, string, bool), Arc<Async<()>>>>,
        v4_1: Option<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
        v5_1: bool,
        v6_1: Option<string>,
        unitVar: (),
    ) -> (
        string,
        Option<CancellationToken>,
        Array<(string, string)>,
        Option<Func1<(i32, string, bool), Arc<Async<()>>>>,
        Option<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
        bool,
        Option<string>,
    ) {
        (v0_1, v1_1, v2_1, v3_1, v4_1, v5_1, v6_1)
    }
    pub fn method26(v0_1: LrcPtr<Runtime::Mut4>, v1_1: string) {
        let v2_1: string = sprintf!("{}", v1_1);
        let v4_1: string = append(v0_1.l0.get().clone(), v2_1);
        v0_1.l0.set(v4_1);
        ()
    }
    pub fn method28(v0_1: LrcPtr<Runtime::Mut4>, v1_1: Option<CancellationToken>) {
        Runtime::method26(v0_1, sprintf!("{:?}", v1_1));
    }
    pub fn method29(v0_1: LrcPtr<Runtime::Mut4>, v1_1: Array<(string, string)>) {
        Runtime::method26(v0_1, sprintf!("{:?}", v1_1));
    }
    pub fn method30(
        v0_1: LrcPtr<Runtime::Mut4>,
        v1_1: Option<Func1<(i32, string, bool), Arc<Async<()>>>>,
    ) {
        Runtime::method26(v0_1, sprintf!("{:?}", v1_1));
    }
    pub fn method31(
        v0_1: LrcPtr<Runtime::Mut4>,
        v1_1: Option<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
    ) {
        Runtime::method26(v0_1, sprintf!("{:?}", v1_1));
    }
    pub fn method32(v0_1: LrcPtr<Runtime::Mut4>, v1_1: bool) {
        let v5_1: string = sprintf!(
            "{}",
            if v1_1 {
                string("true")
            } else {
                string("false")
            }
        );
        let v7: string = append(v0_1.l0.get().clone(), v5_1);
        v0_1.l0.set(v7);
        ()
    }
    pub fn method33(v0_1: LrcPtr<Runtime::Mut4>, v1_1: Option<string>) {
        Runtime::method26(v0_1, sprintf!("{:?}", v1_1));
    }
    pub fn method27(
        v0_1: LrcPtr<Runtime::Mut4>,
        v1_1: string,
        v2_1: Option<CancellationToken>,
        v3_1: Array<(string, string)>,
        v4_1: Option<Func1<(i32, string, bool), Arc<Async<()>>>>,
        v5_1: Option<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
        v6_1: bool,
        v7: Option<string>,
    ) {
        Runtime::method26(v0_1.clone(), string("{ "));
        Runtime::method9(v0_1.clone());
        Runtime::method26(v0_1.clone(), string("command"));
        Runtime::method26(v0_1.clone(), string(" = "));
        Runtime::method26(v0_1.clone(), v1_1);
        Runtime::method26(v0_1.clone(), string("; "));
        Runtime::method26(v0_1.clone(), string("cancellation_token"));
        Runtime::method26(v0_1.clone(), string(" = "));
        Runtime::method28(v0_1.clone(), v2_1);
        Runtime::method26(v0_1.clone(), string("; "));
        Runtime::method26(v0_1.clone(), string("environment_variables"));
        Runtime::method26(v0_1.clone(), string(" = "));
        Runtime::method29(v0_1.clone(), v3_1);
        Runtime::method26(v0_1.clone(), string("; "));
        Runtime::method26(v0_1.clone(), string("on_line"));
        Runtime::method26(v0_1.clone(), string(" = "));
        Runtime::method30(v0_1.clone(), v4_1);
        Runtime::method26(v0_1.clone(), string("; "));
        Runtime::method26(v0_1.clone(), string("stdin"));
        Runtime::method26(v0_1.clone(), string(" = "));
        Runtime::method31(v0_1.clone(), v5_1);
        Runtime::method26(v0_1.clone(), string("; "));
        Runtime::method26(v0_1.clone(), string("trace"));
        Runtime::method26(v0_1.clone(), string(" = "));
        Runtime::method32(v0_1.clone(), v6_1);
        Runtime::method26(v0_1.clone(), string("; "));
        Runtime::method26(v0_1.clone(), string("working_directory"));
        Runtime::method26(v0_1.clone(), string(" = "));
        Runtime::method33(v0_1.clone(), v7);
        Runtime::method26(v0_1, string(" }"))
    }
    pub fn method25(
        v0_1: LrcPtr<Runtime::Mut4>,
        v1_1: string,
        v2_1: Option<CancellationToken>,
        v3_1: Array<(string, string)>,
        v4_1: Option<Func1<(i32, string, bool), Arc<Async<()>>>>,
        v5_1: Option<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
        v6_1: bool,
        v7: Option<string>,
    ) {
        Runtime::method26(v0_1.clone(), string("{ "));
        Runtime::method9(v0_1.clone());
        Runtime::method26(v0_1.clone(), string("options"));
        Runtime::method26(v0_1.clone(), string(" = "));
        Runtime::method27(v0_1.clone(), v1_1, v2_1, v3_1, v4_1, v5_1, v6_1, v7);
        Runtime::method26(v0_1, string(" }"))
    }
    pub fn closure16(
        v0_1: Runtime::US0,
        v1_1: Func0<string>,
        v2_1: Func0<(
            string,
            Option<CancellationToken>,
            Array<(string, string)>,
            Option<Func1<(i32, string, bool), Arc<Async<()>>>>,
            Option<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
            bool,
            Option<string>,
        )>,
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
                LrcPtr<Runtime::Mut3>,
                Option<i64>,
            ) = getValue(Runtime::State::trace_state().get().clone());
            let v9: Option<i64> = patternInput.4.clone();
            let _v10: MutCell<Option<string>> = MutCell::new(None::<string>);
            let _v39: LrcPtr<MutCell<Option<Runtime::US2>>> = refCell(None::<Runtime::US2>);
            {
                let x_2: Option<Runtime::US2> = match &v9 {
                    None => None::<Runtime::US2>,
                    Some(v9_0_0) => {
                        let x: i64 = v9_0_0.clone();
                        Some((Func0::new({
                            let x = x.clone();
                            move || Runtime::US2::US2_0(x)
                        }))())
                    }
                };
                _v39.set(x_2)
            }
            {
                let v44: Runtime::US2 = defaultValue(Runtime::US2::US2_1, _v39.get().clone());
                let v63: DateTime = match &v44 {
                    Runtime::US2::US2_0(v44_0_0) => {
                        let v51: TimeSpan = TimeSpan::new_ticks(
                            {
                                let _arg: DateTime = DateTime::now();
                                _arg.ticks()
                            } - match &v44 {
                                Runtime::US2::US2_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                        );
                        DateTime::new_ymdhms_milli(
                            1_i32,
                            1_i32,
                            1_i32,
                            v51.hours(),
                            v51.minutes(),
                            v51.seconds(),
                            v51.milliseconds(),
                        )
                    }
                    _ => DateTime::now(),
                };
                {
                    let x_3: string = {
                        let provider: string = Runtime::method5();
                        v63.toString(provider)
                    };
                    _v10.set(Some(x_3))
                }
                {
                    let v152: string = match &_v10.get().clone() {
                        None => panic!("{}", string("base.run_target / _v10=None"),),
                        Some(_v10_0_0) => _v10_0_0.clone(),
                    };
                    let v159: Runtime::US3 = if if let Runtime::US0::US0_0 = &v0_1 {
                        true
                    } else {
                        false
                    } {
                        Runtime::US3::US3_0(string("Verbose"))
                    } else {
                        Runtime::US3::US3_1
                    };
                    let v208: Runtime::US3 = match &v159 {
                        Runtime::US3::US3_0(v159_0_0) => Runtime::US3::US3_0(match &v159 {
                            Runtime::US3::US3_0(x) => x.clone(),
                            _ => unreachable!(),
                        }),
                        _ => {
                            let v168: Runtime::US3 = if if let Runtime::US0::US0_1 = &v0_1 {
                                true
                            } else {
                                false
                            } {
                                Runtime::US3::US3_0(string("Debug"))
                            } else {
                                Runtime::US3::US3_1
                            };
                            match &v168 {
                                Runtime::US3::US3_0(v168_0_0) => Runtime::US3::US3_0(match &v168 {
                                    Runtime::US3::US3_0(x) => x.clone(),
                                    _ => unreachable!(),
                                }),
                                _ => {
                                    let v177: Runtime::US3 = if if let Runtime::US0::US0_2 = &v0_1 {
                                        true
                                    } else {
                                        false
                                    } {
                                        Runtime::US3::US3_0(string("Info"))
                                    } else {
                                        Runtime::US3::US3_1
                                    };
                                    match &v177 {
                                        Runtime::US3::US3_0(v177_0_0) => {
                                            Runtime::US3::US3_0(match &v177 {
                                                Runtime::US3::US3_0(x) => x.clone(),
                                                _ => unreachable!(),
                                            })
                                        }
                                        _ => {
                                            let v186: Runtime::US3 =
                                                if if let Runtime::US0::US0_3 = &v0_1 {
                                                    true
                                                } else {
                                                    false
                                                } {
                                                    Runtime::US3::US3_0(string("Warning"))
                                                } else {
                                                    Runtime::US3::US3_1
                                                };
                                            match &v186 {
                                                Runtime::US3::US3_0(v186_0_0) => {
                                                    Runtime::US3::US3_0(match &v186 {
                                                        Runtime::US3::US3_0(x) => x.clone(),
                                                        _ => unreachable!(),
                                                    })
                                                }
                                                _ => {
                                                    let v195: Runtime::US3 =
                                                        if if let Runtime::US0::US0_4 = &v0_1 {
                                                            true
                                                        } else {
                                                            false
                                                        } {
                                                            Runtime::US3::US3_0(string("Critical"))
                                                        } else {
                                                            Runtime::US3::US3_1
                                                        };
                                                    match &v195 {
                                                        Runtime::US3::US3_0(v195_0_0) => {
                                                            Runtime::US3::US3_0(match &v195 {
                                                                Runtime::US3::US3_0(x) => x.clone(),
                                                                _ => unreachable!(),
                                                            })
                                                        }
                                                        _ => Runtime::US3::US3_1,
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    };
                    let v215: string = padLeft(
                        toLower(match &v208 {
                            Runtime::US3::US3_0(v208_0_0) => match &v208 {
                                Runtime::US3::US3_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                            _ => panic!("{}", string("Option does not have a value."),),
                        }),
                        7_i32,
                        ' ',
                    );
                    let _v216: MutCell<Option<string>> = MutCell::new(None::<string>);
                    let v255: &str = match &v0_1 {
                        Runtime::US0::US0_1 => inline_colorization::color_bright_blue,
                        Runtime::US0::US0_2 => inline_colorization::color_bright_green,
                        Runtime::US0::US0_0 => inline_colorization::color_bright_black,
                        Runtime::US0::US0_3 => inline_colorization::color_yellow,
                        _ => inline_colorization::color_bright_red,
                    };
                    let v257: &str = &*v215;
                    let v259: &str = inline_colorization::color_reset;
                    let v261: string = string("format!(\"{v255}{v257}{v259}\")");
                    let v262: std::string::String = format!("{v255}{v257}{v259}");
                    {
                        let x_5: string = fable_library_rust::String_::fromString(v262);
                        _v216.set(Some(x_5))
                    }
                    {
                        let v328: string = match &_v216.get().clone() {
                            None => panic!("{}", string("base.run_target / _v216=None"),),
                            Some(_v216_0_0) => _v216_0_0.clone(),
                        };
                        let v329: i64 = (patternInput.0.clone()).l0.get().clone();
                        let patternInput_1 = v2_1();
                        let v338: LrcPtr<Runtime::Mut4> = LrcPtr::new(Runtime::Mut4 {
                            l0: MutCell::new(string("")),
                        });
                        Runtime::method25(
                            v338.clone(),
                            patternInput_1.0.clone(),
                            patternInput_1.1.clone(),
                            patternInput_1.2.clone(),
                            patternInput_1.3.clone(),
                            patternInput_1.4.clone(),
                            patternInput_1.5.clone(),
                            patternInput_1.6.clone(),
                        );
                        {
                            let v339: string = v338.l0.get().clone();
                            trimEndChars(
                                trimStartChars(
                                    sprintf!("{} {} #{} {} / {}", v152, v328, v329, v1_1(), v339),
                                    toArray(empty::<char>()),
                                ),
                                toArray(ofArray(new_array(&[' ', '/']))),
                            )
                        }
                    }
                }
            }
        }
    }
    pub fn method24(
        v0_1: Runtime::US0,
        v1_1: Func0<string>,
        v2_1: Func0<(
            string,
            Option<CancellationToken>,
            Array<(string, string)>,
            Option<Func1<(i32, string, bool), Arc<Async<()>>>>,
            Option<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
            bool,
            Option<string>,
        )>,
    ) {
        Runtime::method10(
            v0_1.clone(),
            Func0::new({
                let v0_1 = v0_1.clone();
                let v1_1 = v1_1.clone();
                let v2_1 = v2_1.clone();
                move || Runtime::closure16(v0_1.clone(), v1_1.clone(), v2_1.clone(), ())
            }),
        );
    }
    pub fn closure18(v0_1: string, unitVar: ()) -> string {
        v0_1
    }
    pub fn closure17(
        v0_1: string,
        v1_1: Option<CancellationToken>,
        v2_1: Array<(string, string)>,
        v3_1: Option<Func1<(i32, string, bool), Arc<Async<()>>>>,
        v4_1: Option<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
        v5_1: bool,
        v6_1: Option<string>,
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
    pub fn closure19(
        v0_1: string,
        v1_1: Option<CancellationToken>,
        v2_1: Array<(string, string)>,
        v3_1: Option<Func1<(i32, string, bool), Arc<Async<()>>>>,
        v4_1: Option<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
        v5_1: bool,
        v6_1: Option<string>,
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
    pub fn closure20(v0_1: (), unitVar: ()) {
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
    pub fn closure21(unitVar: (), unitVar_1: ()) -> string {
        string("runtime.execute_with_options_async / WaitForExitAsync")
    }
    pub fn closure22(
        v0_1: LrcPtr<TaskCanceledException>,
        unitVar: (),
    ) -> LrcPtr<TaskCanceledException> {
        v0_1
    }
    pub fn method36(v0_1: LrcPtr<Runtime::Mut4>, v1_1: LrcPtr<TaskCanceledException>) {
        Runtime::method26(v0_1, sprintf!("{:?}", v1_1));
    }
    pub fn method35(v0_1: LrcPtr<Runtime::Mut4>, v1_1: LrcPtr<TaskCanceledException>) {
        Runtime::method26(v0_1.clone(), string("{ "));
        Runtime::method9(v0_1.clone());
        Runtime::method26(v0_1.clone(), string("ex"));
        Runtime::method26(v0_1.clone(), string(" = "));
        Runtime::method36(v0_1.clone(), v1_1);
        Runtime::method26(v0_1, string(" }"))
    }
    pub fn closure23(
        v0_1: Runtime::US0,
        v1_1: Func0<string>,
        v2_1: Func0<LrcPtr<TaskCanceledException>>,
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
                LrcPtr<Runtime::Mut3>,
                Option<i64>,
            ) = getValue(Runtime::State::trace_state().get().clone());
            let v9: Option<i64> = patternInput.4.clone();
            let _v10: MutCell<Option<string>> = MutCell::new(None::<string>);
            let _v39: LrcPtr<MutCell<Option<Runtime::US2>>> = refCell(None::<Runtime::US2>);
            {
                let x_2: Option<Runtime::US2> = match &v9 {
                    None => None::<Runtime::US2>,
                    Some(v9_0_0) => {
                        let x: i64 = v9_0_0.clone();
                        Some((Func0::new({
                            let x = x.clone();
                            move || Runtime::US2::US2_0(x)
                        }))())
                    }
                };
                _v39.set(x_2)
            }
            {
                let v44: Runtime::US2 = defaultValue(Runtime::US2::US2_1, _v39.get().clone());
                let v63: DateTime = match &v44 {
                    Runtime::US2::US2_0(v44_0_0) => {
                        let v51: TimeSpan = TimeSpan::new_ticks(
                            {
                                let _arg: DateTime = DateTime::now();
                                _arg.ticks()
                            } - match &v44 {
                                Runtime::US2::US2_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                        );
                        DateTime::new_ymdhms_milli(
                            1_i32,
                            1_i32,
                            1_i32,
                            v51.hours(),
                            v51.minutes(),
                            v51.seconds(),
                            v51.milliseconds(),
                        )
                    }
                    _ => DateTime::now(),
                };
                {
                    let x_3: string = {
                        let provider: string = Runtime::method5();
                        v63.toString(provider)
                    };
                    _v10.set(Some(x_3))
                }
                {
                    let v152: string = match &_v10.get().clone() {
                        None => panic!("{}", string("base.run_target / _v10=None"),),
                        Some(_v10_0_0) => _v10_0_0.clone(),
                    };
                    let v159: Runtime::US3 = if if let Runtime::US0::US0_0 = &v0_1 {
                        true
                    } else {
                        false
                    } {
                        Runtime::US3::US3_0(string("Verbose"))
                    } else {
                        Runtime::US3::US3_1
                    };
                    let v208: Runtime::US3 = match &v159 {
                        Runtime::US3::US3_0(v159_0_0) => Runtime::US3::US3_0(match &v159 {
                            Runtime::US3::US3_0(x) => x.clone(),
                            _ => unreachable!(),
                        }),
                        _ => {
                            let v168: Runtime::US3 = if if let Runtime::US0::US0_1 = &v0_1 {
                                true
                            } else {
                                false
                            } {
                                Runtime::US3::US3_0(string("Debug"))
                            } else {
                                Runtime::US3::US3_1
                            };
                            match &v168 {
                                Runtime::US3::US3_0(v168_0_0) => Runtime::US3::US3_0(match &v168 {
                                    Runtime::US3::US3_0(x) => x.clone(),
                                    _ => unreachable!(),
                                }),
                                _ => {
                                    let v177: Runtime::US3 = if if let Runtime::US0::US0_2 = &v0_1 {
                                        true
                                    } else {
                                        false
                                    } {
                                        Runtime::US3::US3_0(string("Info"))
                                    } else {
                                        Runtime::US3::US3_1
                                    };
                                    match &v177 {
                                        Runtime::US3::US3_0(v177_0_0) => {
                                            Runtime::US3::US3_0(match &v177 {
                                                Runtime::US3::US3_0(x) => x.clone(),
                                                _ => unreachable!(),
                                            })
                                        }
                                        _ => {
                                            let v186: Runtime::US3 =
                                                if if let Runtime::US0::US0_3 = &v0_1 {
                                                    true
                                                } else {
                                                    false
                                                } {
                                                    Runtime::US3::US3_0(string("Warning"))
                                                } else {
                                                    Runtime::US3::US3_1
                                                };
                                            match &v186 {
                                                Runtime::US3::US3_0(v186_0_0) => {
                                                    Runtime::US3::US3_0(match &v186 {
                                                        Runtime::US3::US3_0(x) => x.clone(),
                                                        _ => unreachable!(),
                                                    })
                                                }
                                                _ => {
                                                    let v195: Runtime::US3 =
                                                        if if let Runtime::US0::US0_4 = &v0_1 {
                                                            true
                                                        } else {
                                                            false
                                                        } {
                                                            Runtime::US3::US3_0(string("Critical"))
                                                        } else {
                                                            Runtime::US3::US3_1
                                                        };
                                                    match &v195 {
                                                        Runtime::US3::US3_0(v195_0_0) => {
                                                            Runtime::US3::US3_0(match &v195 {
                                                                Runtime::US3::US3_0(x) => x.clone(),
                                                                _ => unreachable!(),
                                                            })
                                                        }
                                                        _ => Runtime::US3::US3_1,
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    };
                    let v215: string = padLeft(
                        toLower(match &v208 {
                            Runtime::US3::US3_0(v208_0_0) => match &v208 {
                                Runtime::US3::US3_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                            _ => panic!("{}", string("Option does not have a value."),),
                        }),
                        7_i32,
                        ' ',
                    );
                    let _v216: MutCell<Option<string>> = MutCell::new(None::<string>);
                    let v255: &str = match &v0_1 {
                        Runtime::US0::US0_1 => inline_colorization::color_bright_blue,
                        Runtime::US0::US0_2 => inline_colorization::color_bright_green,
                        Runtime::US0::US0_0 => inline_colorization::color_bright_black,
                        Runtime::US0::US0_3 => inline_colorization::color_yellow,
                        _ => inline_colorization::color_bright_red,
                    };
                    let v257: &str = &*v215;
                    let v259: &str = inline_colorization::color_reset;
                    let v261: string = string("format!(\"{v255}{v257}{v259}\")");
                    let v262: std::string::String = format!("{v255}{v257}{v259}");
                    {
                        let x_5: string = fable_library_rust::String_::fromString(v262);
                        _v216.set(Some(x_5))
                    }
                    {
                        let v328: string = match &_v216.get().clone() {
                            None => panic!("{}", string("base.run_target / _v216=None"),),
                            Some(_v216_0_0) => _v216_0_0.clone(),
                        };
                        let v329: i64 = (patternInput.0.clone()).l0.get().clone();
                        let v332: LrcPtr<Runtime::Mut4> = LrcPtr::new(Runtime::Mut4 {
                            l0: MutCell::new(string("")),
                        });
                        Runtime::method35(v332.clone(), v2_1());
                        {
                            let v333: string = v332.l0.get().clone();
                            trimEndChars(
                                trimStartChars(
                                    sprintf!("{} {} #{} {} / {}", v152, v328, v329, v1_1(), v333),
                                    toArray(empty::<char>()),
                                ),
                                toArray(ofArray(new_array(&[' ', '/']))),
                            )
                        }
                    }
                }
            }
        }
    }
    pub fn method34(
        v0_1: Runtime::US0,
        v1_1: Func0<string>,
        v2_1: Func0<LrcPtr<TaskCanceledException>>,
    ) {
        Runtime::method10(
            v0_1.clone(),
            Func0::new({
                let v0_1 = v0_1.clone();
                let v1_1 = v1_1.clone();
                let v2_1 = v2_1.clone();
                move || Runtime::closure23(v0_1.clone(), v1_1.clone(), v2_1.clone(), ())
            }),
        );
    }
    pub fn closure24(unitVar: (), unitVar_1: ()) -> string {
        string("runtime.execute_with_options_async")
    }
    pub fn closure25(v0_1: i32, v1_1: string, unitVar: ()) -> (i32, i32) {
        (v0_1, length(v1_1))
    }
    pub fn method39(v0_1: LrcPtr<Runtime::Mut4>, v1_1: i32) {
        let v2_1: string = sprintf!("{}", v1_1);
        let v4_1: string = append(v0_1.l0.get().clone(), v2_1);
        v0_1.l0.set(v4_1);
        ()
    }
    pub fn method38(v0_1: LrcPtr<Runtime::Mut4>, v1_1: i32, v2_1: i32) {
        Runtime::method26(v0_1.clone(), string("{ "));
        Runtime::method9(v0_1.clone());
        Runtime::method26(v0_1.clone(), string("exit_code"));
        Runtime::method26(v0_1.clone(), string(" = "));
        Runtime::method39(v0_1.clone(), v1_1);
        Runtime::method26(v0_1.clone(), string("; "));
        Runtime::method26(v0_1.clone(), string("output_length"));
        Runtime::method26(v0_1.clone(), string(" = "));
        Runtime::method39(v0_1.clone(), v2_1);
        Runtime::method26(v0_1, string(" }"))
    }
    pub fn closure26(
        v0_1: Runtime::US0,
        v1_1: Func0<string>,
        v2_1: Func0<(i32, i32)>,
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
                LrcPtr<Runtime::Mut3>,
                Option<i64>,
            ) = getValue(Runtime::State::trace_state().get().clone());
            let v9: Option<i64> = patternInput.4.clone();
            let _v10: MutCell<Option<string>> = MutCell::new(None::<string>);
            let _v39: LrcPtr<MutCell<Option<Runtime::US2>>> = refCell(None::<Runtime::US2>);
            {
                let x_2: Option<Runtime::US2> = match &v9 {
                    None => None::<Runtime::US2>,
                    Some(v9_0_0) => {
                        let x: i64 = v9_0_0.clone();
                        Some((Func0::new({
                            let x = x.clone();
                            move || Runtime::US2::US2_0(x)
                        }))())
                    }
                };
                _v39.set(x_2)
            }
            {
                let v44: Runtime::US2 = defaultValue(Runtime::US2::US2_1, _v39.get().clone());
                let v63: DateTime = match &v44 {
                    Runtime::US2::US2_0(v44_0_0) => {
                        let v51: TimeSpan = TimeSpan::new_ticks(
                            {
                                let _arg: DateTime = DateTime::now();
                                _arg.ticks()
                            } - match &v44 {
                                Runtime::US2::US2_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                        );
                        DateTime::new_ymdhms_milli(
                            1_i32,
                            1_i32,
                            1_i32,
                            v51.hours(),
                            v51.minutes(),
                            v51.seconds(),
                            v51.milliseconds(),
                        )
                    }
                    _ => DateTime::now(),
                };
                {
                    let x_3: string = {
                        let provider: string = Runtime::method5();
                        v63.toString(provider)
                    };
                    _v10.set(Some(x_3))
                }
                {
                    let v152: string = match &_v10.get().clone() {
                        None => panic!("{}", string("base.run_target / _v10=None"),),
                        Some(_v10_0_0) => _v10_0_0.clone(),
                    };
                    let v159: Runtime::US3 = if if let Runtime::US0::US0_0 = &v0_1 {
                        true
                    } else {
                        false
                    } {
                        Runtime::US3::US3_0(string("Verbose"))
                    } else {
                        Runtime::US3::US3_1
                    };
                    let v208: Runtime::US3 = match &v159 {
                        Runtime::US3::US3_0(v159_0_0) => Runtime::US3::US3_0(match &v159 {
                            Runtime::US3::US3_0(x) => x.clone(),
                            _ => unreachable!(),
                        }),
                        _ => {
                            let v168: Runtime::US3 = if if let Runtime::US0::US0_1 = &v0_1 {
                                true
                            } else {
                                false
                            } {
                                Runtime::US3::US3_0(string("Debug"))
                            } else {
                                Runtime::US3::US3_1
                            };
                            match &v168 {
                                Runtime::US3::US3_0(v168_0_0) => Runtime::US3::US3_0(match &v168 {
                                    Runtime::US3::US3_0(x) => x.clone(),
                                    _ => unreachable!(),
                                }),
                                _ => {
                                    let v177: Runtime::US3 = if if let Runtime::US0::US0_2 = &v0_1 {
                                        true
                                    } else {
                                        false
                                    } {
                                        Runtime::US3::US3_0(string("Info"))
                                    } else {
                                        Runtime::US3::US3_1
                                    };
                                    match &v177 {
                                        Runtime::US3::US3_0(v177_0_0) => {
                                            Runtime::US3::US3_0(match &v177 {
                                                Runtime::US3::US3_0(x) => x.clone(),
                                                _ => unreachable!(),
                                            })
                                        }
                                        _ => {
                                            let v186: Runtime::US3 =
                                                if if let Runtime::US0::US0_3 = &v0_1 {
                                                    true
                                                } else {
                                                    false
                                                } {
                                                    Runtime::US3::US3_0(string("Warning"))
                                                } else {
                                                    Runtime::US3::US3_1
                                                };
                                            match &v186 {
                                                Runtime::US3::US3_0(v186_0_0) => {
                                                    Runtime::US3::US3_0(match &v186 {
                                                        Runtime::US3::US3_0(x) => x.clone(),
                                                        _ => unreachable!(),
                                                    })
                                                }
                                                _ => {
                                                    let v195: Runtime::US3 =
                                                        if if let Runtime::US0::US0_4 = &v0_1 {
                                                            true
                                                        } else {
                                                            false
                                                        } {
                                                            Runtime::US3::US3_0(string("Critical"))
                                                        } else {
                                                            Runtime::US3::US3_1
                                                        };
                                                    match &v195 {
                                                        Runtime::US3::US3_0(v195_0_0) => {
                                                            Runtime::US3::US3_0(match &v195 {
                                                                Runtime::US3::US3_0(x) => x.clone(),
                                                                _ => unreachable!(),
                                                            })
                                                        }
                                                        _ => Runtime::US3::US3_1,
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    };
                    let v215: string = padLeft(
                        toLower(match &v208 {
                            Runtime::US3::US3_0(v208_0_0) => match &v208 {
                                Runtime::US3::US3_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                            _ => panic!("{}", string("Option does not have a value."),),
                        }),
                        7_i32,
                        ' ',
                    );
                    let _v216: MutCell<Option<string>> = MutCell::new(None::<string>);
                    let v255: &str = match &v0_1 {
                        Runtime::US0::US0_1 => inline_colorization::color_bright_blue,
                        Runtime::US0::US0_2 => inline_colorization::color_bright_green,
                        Runtime::US0::US0_0 => inline_colorization::color_bright_black,
                        Runtime::US0::US0_3 => inline_colorization::color_yellow,
                        _ => inline_colorization::color_bright_red,
                    };
                    let v257: &str = &*v215;
                    let v259: &str = inline_colorization::color_reset;
                    let v261: string = string("format!(\"{v255}{v257}{v259}\")");
                    let v262: std::string::String = format!("{v255}{v257}{v259}");
                    {
                        let x_5: string = fable_library_rust::String_::fromString(v262);
                        _v216.set(Some(x_5))
                    }
                    {
                        let v328: string = match &_v216.get().clone() {
                            None => panic!("{}", string("base.run_target / _v216=None"),),
                            Some(_v216_0_0) => _v216_0_0.clone(),
                        };
                        let v329: i64 = (patternInput.0.clone()).l0.get().clone();
                        let patternInput_1: (i32, i32) = v2_1();
                        let v333: LrcPtr<Runtime::Mut4> = LrcPtr::new(Runtime::Mut4 {
                            l0: MutCell::new(string("")),
                        });
                        Runtime::method38(
                            v333.clone(),
                            patternInput_1.0.clone(),
                            patternInput_1.1.clone(),
                        );
                        {
                            let v334: string = v333.l0.get().clone();
                            trimEndChars(
                                trimStartChars(
                                    sprintf!("{} {} #{} {} / {}", v152, v328, v329, v1_1(), v334),
                                    toArray(empty::<char>()),
                                ),
                                toArray(ofArray(new_array(&[' ', '/']))),
                            )
                        }
                    }
                }
            }
        }
    }
    pub fn method37(v0_1: Runtime::US0, v1_1: Func0<string>, v2_1: Func0<(i32, i32)>) {
        Runtime::method10(
            v0_1.clone(),
            Func0::new({
                let v0_1 = v0_1.clone();
                let v1_1 = v1_1.clone();
                let v2_1 = v2_1.clone();
                move || Runtime::closure26(v0_1.clone(), v1_1.clone(), v2_1.clone(), ())
            }),
        );
    }
    pub fn method11(
        v0_1: string,
        v1_1: Option<CancellationToken>,
        v2_1: Array<(string, string)>,
        v3_1: Option<Func1<(i32, string, bool), Arc<Async<()>>>>,
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
        Runtime::method11(
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
        Runtime::method11(
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
    pub fn method42(v0_1: char, v1_1: i64) -> bool {
        let v0_1: MutCell<char> = MutCell::new(v0_1);
        let v1_1: MutCell<i64> = MutCell::new(v1_1);
        '_method42: loop {
            break '_method42 (if v1_1.get().clone() >= 4_i64 {
                false
            } else {
                let v19: Runtime::US7 = if v1_1.get().clone() == 0_i64 {
                    Runtime::US7::US7_0('\\')
                } else {
                    let v5_1: i64 = v1_1.get().clone() - 1_i64;
                    if v5_1 == 0_i64 {
                        Runtime::US7::US7_0('`')
                    } else {
                        let v8: i64 = v5_1 - 1_i64;
                        if v8 == 0_i64 {
                            Runtime::US7::US7_0('\"')
                        } else {
                            let v11: i64 = v8 - 1_i64;
                            if v11 == 0_i64 {
                                Runtime::US7::US7_0(' ')
                            } else {
                                let v14: i64 = v11 - 1_i64;
                                Runtime::US7::US7_1
                            }
                        }
                    }
                };
                if v0_1.get().clone()
                    == match &v19 {
                        Runtime::US7::US7_0(v19_0_0) => match &v19 {
                            Runtime::US7::US7_0(x) => x.clone(),
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
                    continue '_method42;
                }
            });
        }
    }
    pub fn method43(
        v0_1: string,
        v1_1: string,
        v2_1: LrcPtr<StringBuilder>,
        v3_1: i32,
        v4_1: i32,
    ) -> Runtime::US6 {
        let v0_1: MutCell<string> = MutCell::new(v0_1.clone());
        let v1_1: MutCell<string> = MutCell::new(v1_1.clone());
        let v2_1: MutCell<LrcPtr<StringBuilder>> = MutCell::new(v2_1.clone());
        let v3_1: MutCell<i32> = MutCell::new(v3_1);
        let v4_1: MutCell<i32> = MutCell::new(v4_1);
        '_method43: loop {
            break '_method43 ({
                let v57: Runtime::US5 = if string("") == v1_1.get().clone() {
                    Runtime::US5::US5_1(sprintf!(
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
                    if Runtime::method42(v15, 0_i64) == false {
                        let v27: string = ofChar(v15);
                        let v28: i32 = length(v27.clone());
                        let v29: Array<char> = new_init(&'\u{0000}', v28);
                        let v30: LrcPtr<Runtime::Mut5> = LrcPtr::new(Runtime::Mut5 {
                            l0: MutCell::new(0_i32),
                        });
                        while Runtime::method13(v28, v30.clone()) {
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
                            let patternInput: (LrcPtr<StringBuilder>, i32, i32) = Runtime::method15(
                                foldBack(
                                    Func2::new(move |b0: char, b1: LrcPtr<Runtime::UH0>| {
                                        (Runtime::method14())(b0)(b1)
                                    }),
                                    v36,
                                    LrcPtr::new(Runtime::UH0::UH0_0),
                                ),
                                v2_1.get().clone(),
                                v3_1.get().clone(),
                                v4_1.get().clone(),
                            );
                            Runtime::US5::US5_0(
                                v15,
                                v22,
                                patternInput.0.clone(),
                                patternInput.1.clone(),
                                patternInput.2.clone(),
                            )
                        }
                    } else {
                        Runtime::US5::US5_1(sprintf!(
                            "parsing.none_of / unexpected char: \'{}\' / chars: {:?} / s: {:?}",
                            v15,
                            toArray(ofArray(new_array(&['\\', '`', '\"', ' ']))),
                            (v2_1.get().clone(), v3_1.get().clone(), v4_1.get().clone())
                        ))
                    }
                };
                match &v57 {
                    Runtime::US5::US5_0(v57_0_0, v57_0_1, v57_0_2, v57_0_3, v57_0_4) => {
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
                        continue '_method43;
                    }
                    _ => Runtime::US6::US6_0(
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
    pub fn method45(v0_1: char, v1_1: i64) -> bool {
        let v0_1: MutCell<char> = MutCell::new(v0_1);
        let v1_1: MutCell<i64> = MutCell::new(v1_1);
        '_method45: loop {
            break '_method45 (if v1_1.get().clone() >= 3_i64 {
                false
            } else {
                let v15: Runtime::US7 = if v1_1.get().clone() == 0_i64 {
                    Runtime::US7::US7_0('\\')
                } else {
                    let v5_1: i64 = v1_1.get().clone() - 1_i64;
                    if v5_1 == 0_i64 {
                        Runtime::US7::US7_0('`')
                    } else {
                        let v8: i64 = v5_1 - 1_i64;
                        if v8 == 0_i64 {
                            Runtime::US7::US7_0('\"')
                        } else {
                            let v11: i64 = v8 - 1_i64;
                            Runtime::US7::US7_1
                        }
                    }
                };
                if v0_1.get().clone()
                    == match &v15 {
                        Runtime::US7::US7_0(v15_0_0) => match &v15 {
                            Runtime::US7::US7_0(x) => x.clone(),
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
                    continue '_method45;
                }
            });
        }
    }
    pub fn closure30(unitVar: (), _arg: (string, LrcPtr<StringBuilder>, i32, i32)) -> Runtime::US6 {
        let v3_1: i32 = _arg.3.clone();
        let v2_1: i32 = _arg.2.clone();
        let v1_1: LrcPtr<StringBuilder> = _arg.1.clone();
        let v0_1: string = _arg.0.clone();
        let v60: Runtime::US5 = if string("") == v0_1.clone() {
            Runtime::US5::US5_1(sprintf!(
                "parsing.p_char / unexpected end of input / s: {:?}",
                (v1_1.clone(), v2_1, v3_1)
            ))
        } else {
            let v7: char = getCharAt(v0_1.clone(), 0_i32);
            if v7 == '\\' {
                let v15: string = getSlice(v0_1.clone(), Some(1_i32), Some(length(v0_1.clone())));
                let v17: string = ofChar(v7);
                let v18: i32 = length(v17.clone());
                let v19: Array<char> = new_init(&'\u{0000}', v18);
                let v20: LrcPtr<Runtime::Mut5> = LrcPtr::new(Runtime::Mut5 {
                    l0: MutCell::new(0_i32),
                });
                while Runtime::method13(v18, v20.clone()) {
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
                    let patternInput: (LrcPtr<StringBuilder>, i32, i32) = Runtime::method15(
                        foldBack(
                            Func2::new(move |b0: char, b1: LrcPtr<Runtime::UH0>| {
                                (Runtime::method14())(b0)(b1)
                            }),
                            v26,
                            LrcPtr::new(Runtime::UH0::UH0_0),
                        ),
                        v1_1.clone(),
                        v2_1,
                        v3_1,
                    );
                    Runtime::US5::US5_0(
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
                Runtime::US5::US5_1(sprintf!(
                    "{}\n{}\n",
                    sprintf!(
                        "parsing.p_char / expected: \'{}\' / line: {} / col: {}\n{}{}",
                        '\\',
                        v2_1,
                        v3_1,
                        v1_1,
                        getSlice(
                            v0_1,
                            Some(0_i32),
                            Some(if -2_i32 == v41 { v38 } else { v41 })
                        )
                    ),
                    append(replicate(v3_1 - 1_i32, string(" ")), string("^"))
                ))
            }
        };
        let v102: Runtime::US5 = match &v60 {
            Runtime::US5::US5_0(v60_0_0, v60_0_1, v60_0_2, v60_0_3, v60_0_4) => {
                let v65: i32 = v60_0_4.clone();
                let v64: i32 = v60_0_3.clone();
                let v63: LrcPtr<StringBuilder> = v60_0_2.clone();
                let v62: string = v60_0_1.clone();
                if string("") == v62.clone() {
                    Runtime::US5::US5_1(sprintf!(
                        "parsing.any_char / unexpected end of input / s: {:?}",
                        (v63.clone(), v64, v65)
                    ))
                } else {
                    let v69: char = getCharAt(v62.clone(), 0_i32);
                    let v76: string = getSlice(v62.clone(), Some(1_i32), Some(length(v62)));
                    let v78: string = ofChar(v69);
                    let v79: i32 = length(v78.clone());
                    let v80: Array<char> = new_init(&'\u{0000}', v79);
                    let v81: LrcPtr<Runtime::Mut5> = LrcPtr::new(Runtime::Mut5 {
                        l0: MutCell::new(0_i32),
                    });
                    while Runtime::method13(v79, v81.clone()) {
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
                        let patternInput_1: (LrcPtr<StringBuilder>, i32, i32) = Runtime::method15(
                            foldBack(
                                Func2::new(move |b0: char, b1: LrcPtr<Runtime::UH0>| {
                                    (Runtime::method14())(b0)(b1)
                                }),
                                v87,
                                LrcPtr::new(Runtime::UH0::UH0_0),
                            ),
                            v63,
                            v64,
                            v65,
                        );
                        Runtime::US5::US5_0(
                            v69,
                            v76,
                            patternInput_1.0.clone(),
                            patternInput_1.1.clone(),
                            patternInput_1.2.clone(),
                        )
                    }
                }
            }
            Runtime::US5::US5_1(v60_1_0) => Runtime::US5::US5_1(v60_1_0.clone()),
        };
        match &v102 {
            Runtime::US5::US5_0(v102_0_0, v102_0_1, v102_0_2, v102_0_3, v102_0_4) => {
                Runtime::US6::US6_0(
                    sprintf!("{}{}", '\\', v102_0_0.clone()),
                    v102_0_1.clone(),
                    v102_0_2.clone(),
                    v102_0_3.clone(),
                    v102_0_4.clone(),
                )
            }
            Runtime::US5::US5_1(v102_1_0) => Runtime::US6::US6_1(v102_1_0.clone()),
        }
    }
    pub fn closure31(unitVar: (), _arg: (string, LrcPtr<StringBuilder>, i32, i32)) -> Runtime::US6 {
        let v3_1: i32 = _arg.3.clone();
        let v2_1: i32 = _arg.2.clone();
        let v1_1: LrcPtr<StringBuilder> = _arg.1.clone();
        let v0_1: string = _arg.0.clone();
        let v60: Runtime::US5 = if string("") == v0_1.clone() {
            Runtime::US5::US5_1(sprintf!(
                "parsing.p_char / unexpected end of input / s: {:?}",
                (v1_1.clone(), v2_1, v3_1)
            ))
        } else {
            let v7: char = getCharAt(v0_1.clone(), 0_i32);
            if v7 == '`' {
                let v15: string = getSlice(v0_1.clone(), Some(1_i32), Some(length(v0_1.clone())));
                let v17: string = ofChar(v7);
                let v18: i32 = length(v17.clone());
                let v19: Array<char> = new_init(&'\u{0000}', v18);
                let v20: LrcPtr<Runtime::Mut5> = LrcPtr::new(Runtime::Mut5 {
                    l0: MutCell::new(0_i32),
                });
                while Runtime::method13(v18, v20.clone()) {
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
                    let patternInput: (LrcPtr<StringBuilder>, i32, i32) = Runtime::method15(
                        foldBack(
                            Func2::new(move |b0: char, b1: LrcPtr<Runtime::UH0>| {
                                (Runtime::method14())(b0)(b1)
                            }),
                            v26,
                            LrcPtr::new(Runtime::UH0::UH0_0),
                        ),
                        v1_1.clone(),
                        v2_1,
                        v3_1,
                    );
                    Runtime::US5::US5_0(
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
                Runtime::US5::US5_1(sprintf!(
                    "{}\n{}\n",
                    sprintf!(
                        "parsing.p_char / expected: \'{}\' / line: {} / col: {}\n{}{}",
                        '`',
                        v2_1,
                        v3_1,
                        v1_1,
                        getSlice(
                            v0_1,
                            Some(0_i32),
                            Some(if -2_i32 == v41 { v38 } else { v41 })
                        )
                    ),
                    append(replicate(v3_1 - 1_i32, string(" ")), string("^"))
                ))
            }
        };
        let v102: Runtime::US5 = match &v60 {
            Runtime::US5::US5_0(v60_0_0, v60_0_1, v60_0_2, v60_0_3, v60_0_4) => {
                let v65: i32 = v60_0_4.clone();
                let v64: i32 = v60_0_3.clone();
                let v63: LrcPtr<StringBuilder> = v60_0_2.clone();
                let v62: string = v60_0_1.clone();
                if string("") == v62.clone() {
                    Runtime::US5::US5_1(sprintf!(
                        "parsing.any_char / unexpected end of input / s: {:?}",
                        (v63.clone(), v64, v65)
                    ))
                } else {
                    let v69: char = getCharAt(v62.clone(), 0_i32);
                    let v76: string = getSlice(v62.clone(), Some(1_i32), Some(length(v62)));
                    let v78: string = ofChar(v69);
                    let v79: i32 = length(v78.clone());
                    let v80: Array<char> = new_init(&'\u{0000}', v79);
                    let v81: LrcPtr<Runtime::Mut5> = LrcPtr::new(Runtime::Mut5 {
                        l0: MutCell::new(0_i32),
                    });
                    while Runtime::method13(v79, v81.clone()) {
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
                        let patternInput_1: (LrcPtr<StringBuilder>, i32, i32) = Runtime::method15(
                            foldBack(
                                Func2::new(move |b0: char, b1: LrcPtr<Runtime::UH0>| {
                                    (Runtime::method14())(b0)(b1)
                                }),
                                v87,
                                LrcPtr::new(Runtime::UH0::UH0_0),
                            ),
                            v63,
                            v64,
                            v65,
                        );
                        Runtime::US5::US5_0(
                            v69,
                            v76,
                            patternInput_1.0.clone(),
                            patternInput_1.1.clone(),
                            patternInput_1.2.clone(),
                        )
                    }
                }
            }
            Runtime::US5::US5_1(v60_1_0) => Runtime::US5::US5_1(v60_1_0.clone()),
        };
        match &v102 {
            Runtime::US5::US5_0(v102_0_0, v102_0_1, v102_0_2, v102_0_3, v102_0_4) => {
                Runtime::US6::US6_0(
                    sprintf!("{}{}", '`', v102_0_0.clone()),
                    v102_0_1.clone(),
                    v102_0_2.clone(),
                    v102_0_3.clone(),
                    v102_0_4.clone(),
                )
            }
            Runtime::US5::US5_1(v102_1_0) => Runtime::US6::US6_1(v102_1_0.clone()),
        }
    }
    pub fn method46(
        v0_1: string,
        v1_1: LrcPtr<StringBuilder>,
        v2_1: i32,
        v3_1: i32,
        v4_1: LrcPtr<Runtime::UH3>,
    ) -> Runtime::US6 {
        let v0_1: MutCell<string> = MutCell::new(v0_1.clone());
        let v1_1: MutCell<LrcPtr<StringBuilder>> = MutCell::new(v1_1.clone());
        let v2_1: MutCell<i32> = MutCell::new(v2_1);
        let v3_1: MutCell<i32> = MutCell::new(v3_1);
        let v4_1: MutCell<LrcPtr<Runtime::UH3>> = MutCell::new(v4_1.clone());
        '_method46: loop {
            break '_method46 (match v4_1.get().clone().as_ref() {
                Runtime::UH3::UH3_0 => Runtime::US6::US6_1(string("choice / no parsers succeeded")),
                Runtime::UH3::UH3_1(v4_1_1_0, v4_1_1_1) => {
                    let v9: Runtime::US6 = (match v4_1.get().clone().as_ref() {
                        Runtime::UH3::UH3_1(x, _) => x.clone(),
                        _ => unreachable!(),
                    })((
                        v0_1.get().clone(),
                        v1_1.get().clone(),
                        v2_1.get().clone(),
                        v3_1.get().clone(),
                    ));
                    match &v9 {
                        Runtime::US6::US6_0(v9_0_0, v9_0_1, v9_0_2, v9_0_3, v9_0_4) => v9.clone(),
                        _ => {
                            let v0_1_temp: string = v0_1.get().clone();
                            let v1_1_temp: LrcPtr<StringBuilder> = v1_1.get().clone();
                            let v2_1_temp: i32 = v2_1.get().clone();
                            let v3_1_temp: i32 = v3_1.get().clone();
                            let v4_1_temp: LrcPtr<Runtime::UH3> = match v4_1.get().clone().as_ref()
                            {
                                Runtime::UH3::UH3_1(_, x) => x.clone(),
                                _ => unreachable!(),
                            };
                            v0_1.set(v0_1_temp);
                            v1_1.set(v1_1_temp);
                            v2_1.set(v2_1_temp);
                            v3_1.set(v3_1_temp);
                            v4_1.set(v4_1_temp);
                            continue '_method46;
                        }
                    }
                }
            });
        }
    }
    pub fn method47(
        v0_1: LrcPtr<Runtime::UH2>,
        v1_1: LrcPtr<Runtime::UH2>,
    ) -> LrcPtr<Runtime::UH2> {
        let v0_1: MutCell<LrcPtr<Runtime::UH2>> = MutCell::new(v0_1.clone());
        let v1_1: MutCell<LrcPtr<Runtime::UH2>> = MutCell::new(v1_1.clone());
        '_method47: loop {
            break '_method47 (match v0_1.get().clone().as_ref() {
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
                    continue '_method47;
                }
            });
        }
    }
    pub fn method44(
        v0_1: LrcPtr<Runtime::UH2>,
        v1_1: string,
        v2_1: LrcPtr<StringBuilder>,
        v3_1: i32,
        v4_1: i32,
    ) -> Runtime::US15 {
        let v0_1: MutCell<LrcPtr<Runtime::UH2>> = MutCell::new(v0_1.clone());
        let v1_1: MutCell<string> = MutCell::new(v1_1.clone());
        let v2_1: MutCell<LrcPtr<StringBuilder>> = MutCell::new(v2_1.clone());
        let v3_1: MutCell<i32> = MutCell::new(v3_1);
        let v4_1: MutCell<i32> = MutCell::new(v4_1);
        '_method44: loop {
            break '_method44 ({
                let v55: Runtime::US5 = if string("") == v1_1.get().clone() {
                    Runtime::US5::US5_1(sprintf!(
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
                    if Runtime::method45(v14, 0_i64) == false {
                        let v26: string = ofChar(v14);
                        let v27: i32 = length(v26.clone());
                        let v28: Array<char> = new_init(&'\u{0000}', v27);
                        let v29: LrcPtr<Runtime::Mut5> = LrcPtr::new(Runtime::Mut5 {
                            l0: MutCell::new(0_i32),
                        });
                        while Runtime::method13(v27, v29.clone()) {
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
                            let patternInput: (LrcPtr<StringBuilder>, i32, i32) = Runtime::method15(
                                foldBack(
                                    Func2::new(move |b0: char, b1: LrcPtr<Runtime::UH0>| {
                                        (Runtime::method14())(b0)(b1)
                                    }),
                                    v35,
                                    LrcPtr::new(Runtime::UH0::UH0_0),
                                ),
                                v2_1.get().clone(),
                                v3_1.get().clone(),
                                v4_1.get().clone(),
                            );
                            Runtime::US5::US5_0(
                                v14,
                                v21,
                                patternInput.0.clone(),
                                patternInput.1.clone(),
                                patternInput.2.clone(),
                            )
                        }
                    } else {
                        Runtime::US5::US5_1(sprintf!(
                            "parsing.none_of / unexpected char: \'{}\' / chars: {:?} / s: {:?}",
                            v14,
                            toArray(ofArray(new_array(&['\\', '`', '\"']))),
                            (v2_1.get().clone(), v3_1.get().clone(), v4_1.get().clone())
                        ))
                    }
                };
                let v67: Runtime::US6 = match &v55 {
                    Runtime::US5::US5_0(v55_0_0, v55_0_1, v55_0_2, v55_0_3, v55_0_4) => {
                        Runtime::US6::US6_0(
                            ofChar(v55_0_0.clone()),
                            v55_0_1.clone(),
                            v55_0_2.clone(),
                            v55_0_3.clone(),
                            v55_0_4.clone(),
                        )
                    }
                    Runtime::US5::US5_1(v55_1_0) => Runtime::US6::US6_1(v55_1_0.clone()),
                };
                let v81: Runtime::US6 = match &v67 {
                    Runtime::US6::US6_0(v67_0_0, v67_0_1, v67_0_2, v67_0_3, v67_0_4) => v67.clone(),
                    _ => Runtime::method46(
                        v1_1.get().clone(),
                        v2_1.get().clone(),
                        v3_1.get().clone(),
                        v4_1.get().clone(),
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
                match &v81 {
                    Runtime::US6::US6_0(v81_0_0, v81_0_1, v81_0_2, v81_0_3, v81_0_4) => {
                        let v0_1_temp: LrcPtr<Runtime::UH2> =
                            LrcPtr::new(Runtime::UH2::UH2_1(v81_0_0.clone(), v0_1.get().clone()));
                        let v1_1_temp: string = v81_0_1.clone();
                        let v2_1_temp: LrcPtr<StringBuilder> = v81_0_2.clone();
                        let v3_1_temp: i32 = v81_0_3.clone();
                        let v4_1_temp: i32 = v81_0_4.clone();
                        v0_1.set(v0_1_temp);
                        v1_1.set(v1_1_temp);
                        v2_1.set(v2_1_temp);
                        v3_1.set(v3_1_temp);
                        v4_1.set(v4_1_temp);
                        continue '_method44;
                    }
                    _ => Runtime::US15::US15_0(
                        Runtime::method47(v0_1.get().clone(), LrcPtr::new(Runtime::UH2::UH2_0)),
                        v1_1.get().clone(),
                        v2_1.get().clone(),
                        v3_1.get().clone(),
                        v4_1.get().clone(),
                    ),
                }
            });
        }
    }
    pub fn method48(v0_1: LrcPtr<Runtime::UH2>, v1_1: List<string>) -> List<string> {
        match v0_1.as_ref() {
            Runtime::UH2::UH2_0 => v1_1.clone(),
            Runtime::UH2::UH2_1(v0_1_1_0, v0_1_1_1) => cons(
                match v0_1.as_ref() {
                    Runtime::UH2::UH2_1(x, _) => x.clone(),
                    _ => unreachable!(),
                },
                Runtime::method48(
                    match v0_1.as_ref() {
                        Runtime::UH2::UH2_1(_, x) => x.clone(),
                        _ => unreachable!(),
                    },
                    v1_1.clone(),
                ),
            ),
        }
    }
    pub fn method49(
        v0_1: LrcPtr<Runtime::UH2>,
        v1_1: string,
        v2_1: LrcPtr<StringBuilder>,
        v3_1: i32,
        v4_1: i32,
    ) -> Runtime::US15 {
        let v0_1: MutCell<LrcPtr<Runtime::UH2>> = MutCell::new(v0_1.clone());
        let v1_1: MutCell<string> = MutCell::new(v1_1.clone());
        let v2_1: MutCell<LrcPtr<StringBuilder>> = MutCell::new(v2_1.clone());
        let v3_1: MutCell<i32> = MutCell::new(v3_1);
        let v4_1: MutCell<i32> = MutCell::new(v4_1);
        '_method49: loop {
            break '_method49 ({
                let v55: Runtime::US5 = if string("") == v1_1.get().clone() {
                    Runtime::US5::US5_1(sprintf!(
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
                    if Runtime::method45(v14, 0_i64) == false {
                        let v26: string = ofChar(v14);
                        let v27: i32 = length(v26.clone());
                        let v28: Array<char> = new_init(&'\u{0000}', v27);
                        let v29: LrcPtr<Runtime::Mut5> = LrcPtr::new(Runtime::Mut5 {
                            l0: MutCell::new(0_i32),
                        });
                        while Runtime::method13(v27, v29.clone()) {
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
                            let patternInput: (LrcPtr<StringBuilder>, i32, i32) = Runtime::method15(
                                foldBack(
                                    Func2::new(move |b0: char, b1: LrcPtr<Runtime::UH0>| {
                                        (Runtime::method14())(b0)(b1)
                                    }),
                                    v35,
                                    LrcPtr::new(Runtime::UH0::UH0_0),
                                ),
                                v2_1.get().clone(),
                                v3_1.get().clone(),
                                v4_1.get().clone(),
                            );
                            Runtime::US5::US5_0(
                                v14,
                                v21,
                                patternInput.0.clone(),
                                patternInput.1.clone(),
                                patternInput.2.clone(),
                            )
                        }
                    } else {
                        Runtime::US5::US5_1(sprintf!(
                            "parsing.none_of / unexpected char: \'{}\' / chars: {:?} / s: {:?}",
                            v14,
                            toArray(ofArray(new_array(&['\\', '`', '\"']))),
                            (v2_1.get().clone(), v3_1.get().clone(), v4_1.get().clone())
                        ))
                    }
                };
                let v67: Runtime::US6 = match &v55 {
                    Runtime::US5::US5_0(v55_0_0, v55_0_1, v55_0_2, v55_0_3, v55_0_4) => {
                        Runtime::US6::US6_0(
                            ofChar(v55_0_0.clone()),
                            v55_0_1.clone(),
                            v55_0_2.clone(),
                            v55_0_3.clone(),
                            v55_0_4.clone(),
                        )
                    }
                    Runtime::US5::US5_1(v55_1_0) => Runtime::US6::US6_1(v55_1_0.clone()),
                };
                match &v67 {
                    Runtime::US6::US6_0(v67_0_0, v67_0_1, v67_0_2, v67_0_3, v67_0_4) => {
                        let v0_1_temp: LrcPtr<Runtime::UH2> =
                            LrcPtr::new(Runtime::UH2::UH2_1(v67_0_0.clone(), v0_1.get().clone()));
                        let v1_1_temp: string = v67_0_1.clone();
                        let v2_1_temp: LrcPtr<StringBuilder> = v67_0_2.clone();
                        let v3_1_temp: i32 = v67_0_3.clone();
                        let v4_1_temp: i32 = v67_0_4.clone();
                        v0_1.set(v0_1_temp);
                        v1_1.set(v1_1_temp);
                        v2_1.set(v2_1_temp);
                        v3_1.set(v3_1_temp);
                        v4_1.set(v4_1_temp);
                        continue '_method49;
                    }
                    _ => Runtime::US15::US15_0(
                        Runtime::method47(v0_1.get().clone(), LrcPtr::new(Runtime::UH2::UH2_0)),
                        v1_1.get().clone(),
                        v2_1.get().clone(),
                        v3_1.get().clone(),
                        v4_1.get().clone(),
                    ),
                }
            });
        }
    }
    pub fn method50(v0_1: string, v1_1: i32) -> i32 {
        let v0_1: MutCell<string> = MutCell::new(v0_1.clone());
        let v1_1: MutCell<i32> = MutCell::new(v1_1);
        '_method50: loop {
            break '_method50 (if v1_1.get().clone() >= length(v0_1.get().clone()) {
                v1_1.get().clone()
            } else {
                if getCharAt(v0_1.get().clone(), v1_1.get().clone()) == ' ' {
                    let v0_1_temp: string = v0_1.get().clone();
                    let v1_1_temp: i32 = v1_1.get().clone() + 1_i32;
                    v0_1.set(v0_1_temp);
                    v1_1.set(v1_1_temp);
                    continue '_method50;
                } else {
                    v1_1.get().clone()
                }
            });
        }
    }
    pub fn method41(
        v0_1: LrcPtr<Runtime::UH2>,
        v1_1: string,
        v2_1: LrcPtr<StringBuilder>,
        v3_1: i32,
        v4_1: i32,
    ) -> Runtime::US15 {
        let v0_1: MutCell<LrcPtr<Runtime::UH2>> = MutCell::new(v0_1.clone());
        let v1_1: MutCell<string> = MutCell::new(v1_1.clone());
        let v2_1: MutCell<LrcPtr<StringBuilder>> = MutCell::new(v2_1.clone());
        let v3_1: MutCell<i32> = MutCell::new(v3_1);
        let v4_1: MutCell<i32> = MutCell::new(v4_1);
        '_method41: loop {
            break '_method41 ({
                let v5_1: bool = string("") == v1_1.get().clone();
                let v57: Runtime::US5 = if v5_1 {
                    Runtime::US5::US5_1(sprintf!(
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
                    if Runtime::method42(v15, 0_i64) == false {
                        let v27: string = ofChar(v15);
                        let v28: i32 = length(v27.clone());
                        let v29: Array<char> = new_init(&'\u{0000}', v28);
                        let v30: LrcPtr<Runtime::Mut5> = LrcPtr::new(Runtime::Mut5 {
                            l0: MutCell::new(0_i32),
                        });
                        while Runtime::method13(v28, v30.clone()) {
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
                            let patternInput: (LrcPtr<StringBuilder>, i32, i32) = Runtime::method15(
                                foldBack(
                                    Func2::new(move |b0: char, b1: LrcPtr<Runtime::UH0>| {
                                        (Runtime::method14())(b0)(b1)
                                    }),
                                    v36,
                                    LrcPtr::new(Runtime::UH0::UH0_0),
                                ),
                                v2_1.get().clone(),
                                v3_1.get().clone(),
                                v4_1.get().clone(),
                            );
                            Runtime::US5::US5_0(
                                v15,
                                v22,
                                patternInput.0.clone(),
                                patternInput.1.clone(),
                                patternInput.2.clone(),
                            )
                        }
                    } else {
                        Runtime::US5::US5_1(sprintf!(
                            "parsing.none_of / unexpected char: \'{}\' / chars: {:?} / s: {:?}",
                            v15,
                            toArray(ofArray(new_array(&['\\', '`', '\"', ' ']))),
                            (v2_1.get().clone(), v3_1.get().clone(), v4_1.get().clone())
                        ))
                    }
                };
                let v69: Runtime::US6 = match &v57 {
                    Runtime::US5::US5_0(v57_0_0, v57_0_1, v57_0_2, v57_0_3, v57_0_4) => {
                        Runtime::method43(
                            ofChar(v57_0_0.clone()),
                            v57_0_1.clone(),
                            v57_0_2.clone(),
                            v57_0_3.clone(),
                            v57_0_4.clone(),
                        )
                    }
                    Runtime::US5::US5_1(v57_1_0) => Runtime::US6::US6_1(v57_1_0.clone()),
                };
                let v292: Runtime::US6 = match &v69 {
                    Runtime::US6::US6_0(v69_0_0, v69_0_1, v69_0_2, v69_0_3, v69_0_4) => v69.clone(),
                    _ => {
                        let v131: Runtime::US5 = if v5_1 {
                            Runtime::US5::US5_1(sprintf!(
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
                                let v91: LrcPtr<Runtime::Mut5> = LrcPtr::new(Runtime::Mut5 {
                                    l0: MutCell::new(0_i32),
                                });
                                while Runtime::method13(v89, v91.clone()) {
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
                                        Runtime::method15(
                                            foldBack(
                                                Func2::new(
                                                    move |b0: char, b1: LrcPtr<Runtime::UH0>| {
                                                        (Runtime::method14())(b0)(b1)
                                                    },
                                                ),
                                                v97,
                                                LrcPtr::new(Runtime::UH0::UH0_0),
                                            ),
                                            v2_1.get().clone(),
                                            v3_1.get().clone(),
                                            v4_1.get().clone(),
                                        );
                                    Runtime::US5::US5_0(
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
                                Runtime::US5::US5_1(sprintf!("{}\n{}\n",
                                                                              sprintf!("parsing.p_char / expected: \'{}\' / line: {} / col: {}\n{}{}",
                                                                                       '\"',
                                                                                       v3_1.get().clone(),
                                                                                       v4_1.get().clone(),
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
                                                                              append(replicate(v4_1.get().clone()
                                                                                                   -
                                                                                                   1_i32,
                                                                                               string(" ")),
                                                                                     string("^"))))
                            }
                        };
                        let v237: Runtime::US6 = match &v131 {
                            Runtime::US5::US5_0(
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
                                let v138: Runtime::US15 = Runtime::method44(
                                    LrcPtr::new(Runtime::UH2::UH2_0),
                                    v133.clone(),
                                    v134.clone(),
                                    v135,
                                    v136,
                                );
                                let v155: Runtime::US6 = match &v138 {
                                    Runtime::US15::US15_0(
                                        v138_0_0,
                                        v138_0_1,
                                        v138_0_2,
                                        v138_0_3,
                                        v138_0_4,
                                    ) => {
                                        let v145: List<string> =
                                            Runtime::method48(v138_0_0.clone(), empty::<string>());
                                        Runtime::US6::US6_0(
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
                                    Runtime::US15::US15_1(v138_1_0) => {
                                        Runtime::US6::US6_1(v138_1_0.clone())
                                    }
                                };
                                match &v155 {
                                    Runtime::US6::US6_0(
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
                                        let v217: Runtime::US5 = if string("") == v157.clone() {
                                            Runtime::US5::US5_1(sprintf!("parsing.p_char / unexpected end of input / s: {:?}",
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
                                                let v177: LrcPtr<Runtime::Mut5> =
                                                    LrcPtr::new(Runtime::Mut5 {
                                                        l0: MutCell::new(0_i32),
                                                    });
                                                while Runtime::method13(v175, v177.clone()) {
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
                                                                             Runtime::method15(foldBack(Func2::new(move
                                                                                                                       |b0:
                                                                                                                            char,
                                                                                                                        b1:
                                                                                                                            LrcPtr<Runtime::UH0>|
                                                                                                                       (Runtime::method14())(b0)(b1)),
                                                                                                        v183,
                                                                                                        LrcPtr::new(Runtime::UH0::UH0_0)),
                                                                                               v158.clone(),
                                                                                               v159,
                                                                                               v160);
                                                    Runtime::US5::US5_0(
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
                                                Runtime::US5::US5_1(sprintf!("{}\n{}\n",
                                                                                                  sprintf!("parsing.p_char / expected: \'{}\' / line: {} / col: {}\n{}{}",
                                                                                                           '\"',
                                                                                                           v159,
                                                                                                           v160,
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
                                                                                                  append(replicate(v160
                                                                                                                       -
                                                                                                                       1_i32,
                                                                                                                   string(" ")),
                                                                                                         string("^"))))
                                            }
                                        };
                                        match &v217 {
                                                             Runtime::US5::US5_0(v217_0_0,
                                                                                 v217_0_1,
                                                                                 v217_0_2,
                                                                                 v217_0_3,
                                                                                 v217_0_4)
                                                             =>
                                                             Runtime::US6::US6_0(v155_0_0.clone(),
                                                                                 v217_0_1.clone(),
                                                                                 v217_0_2.clone(),
                                                                                 v217_0_3.clone(),
                                                                                 v217_0_4.clone()),
                                                             Runtime::US5::US5_1(v217_1_0)
                                                             =>
                                                             Runtime::US6::US6_1(sprintf!("between / expected closing delimiter / e: {:?} / input: {:?} / rest1: {:?} / rest2: {:?}",
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
                                    _ => Runtime::US6::US6_1(string("between / expected content")),
                                }
                            }
                            Runtime::US5::US5_1(v131_1_0) => Runtime::US6::US6_1(v131_1_0.clone()),
                        };
                        match &v237 {
                            Runtime::US6::US6_0(
                                v237_0_0,
                                v237_0_1,
                                v237_0_2,
                                v237_0_3,
                                v237_0_4,
                            ) => v237.clone(),
                            _ => {
                                let v249: Runtime::US6 = Runtime::method46(
                                    v1_1.get().clone(),
                                    v2_1.get().clone(),
                                    v3_1.get().clone(),
                                    v4_1.get().clone(),
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
                                let v260: Runtime::US6 = match &v249 {
                                    Runtime::US6::US6_0(
                                        v249_0_0,
                                        v249_0_1,
                                        v249_0_2,
                                        v249_0_3,
                                        v249_0_4,
                                    ) => Runtime::US6::US6_0(
                                        string(""),
                                        v249_0_1.clone(),
                                        v249_0_2.clone(),
                                        v249_0_3.clone(),
                                        v249_0_4.clone(),
                                    ),
                                    Runtime::US6::US6_1(v249_1_0) => {
                                        Runtime::US6::US6_1(v249_1_0.clone())
                                    }
                                };
                                let v271: Runtime::US15 = match &v260 {
                                    Runtime::US6::US6_0(
                                        v260_0_0,
                                        v260_0_1,
                                        v260_0_2,
                                        v260_0_3,
                                        v260_0_4,
                                    ) => Runtime::method49(
                                        LrcPtr::new(Runtime::UH2::UH2_0),
                                        v260_0_1.clone(),
                                        v260_0_2.clone(),
                                        v260_0_3.clone(),
                                        v260_0_4.clone(),
                                    ),
                                    Runtime::US6::US6_1(v260_1_0) => {
                                        Runtime::US15::US15_1(v260_1_0.clone())
                                    }
                                };
                                match &v271 {
                                    Runtime::US15::US15_0(
                                        v271_0_0,
                                        v271_0_1,
                                        v271_0_2,
                                        v271_0_3,
                                        v271_0_4,
                                    ) => {
                                        let v278: List<string> =
                                            Runtime::method48(v271_0_0.clone(), empty::<string>());
                                        Runtime::US6::US6_0(
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
                                    Runtime::US15::US15_1(v271_1_0) => {
                                        Runtime::US6::US6_1(v271_1_0.clone())
                                    }
                                }
                            }
                        }
                    }
                };
                match &v292 {
                    Runtime::US6::US6_0(v292_0_0, v292_0_1, v292_0_2, v292_0_3, v292_0_4) => {
                        let v301: i32 = v292_0_4.clone();
                        let v300: i32 = v292_0_3.clone();
                        let v299: LrcPtr<StringBuilder> = v292_0_2.clone();
                        let v298: string = v292_0_1.clone();
                        let v297: string = v292_0_0.clone();
                        let v303: i32 = Runtime::method50(v298.clone(), 0_i32);
                        let v315: Runtime::US8 = if 0_i32 == v303 {
                            Runtime::US8::US8_1(string("spaces1 / expected at least one space"))
                        } else {
                            Runtime::US8::US8_0(
                                getSlice(v298.clone(), Some(v303), Some(length(v298.clone()))),
                                v299.clone(),
                                v300,
                                v301,
                            )
                        };
                        match &v315 {
                            Runtime::US8::US8_0(v315_0_0, v315_0_1, v315_0_2, v315_0_3) => {
                                let v0_1_temp: LrcPtr<Runtime::UH2> = LrcPtr::new(
                                    Runtime::UH2::UH2_1(v297.clone(), v0_1.get().clone()),
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
                                continue '_method41;
                            }
                            _ => Runtime::US15::US15_0(
                                Runtime::method47(
                                    v0_1.get().clone(),
                                    LrcPtr::new(Runtime::UH2::UH2_1(
                                        v297.clone(),
                                        LrcPtr::new(Runtime::UH2::UH2_0),
                                    )),
                                ),
                                v298,
                                v299,
                                v300,
                                v301,
                            ),
                        }
                    }
                    _ => Runtime::US15::US15_0(
                        Runtime::method47(v0_1.get().clone(), LrcPtr::new(Runtime::UH2::UH2_0)),
                        v1_1.get().clone(),
                        v2_1.get().clone(),
                        v3_1.get().clone(),
                        v4_1.get().clone(),
                    ),
                }
            });
        }
    }
    pub fn method40(v0_1: string) -> Runtime::US14 {
        let _v0: MutCell<Option<Option<string>>> = MutCell::new(None::<Option<string>>);
        _v0.set(Some(Some(v0_1)));
        {
            let v11: Runtime::US15 = Runtime::method41(
                LrcPtr::new(Runtime::UH2::UH2_0),
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
            match &v11 {
                Runtime::US15::US15_0(v11_0_0, v11_0_1, v11_0_2, v11_0_3, v11_0_4) => {
                    Runtime::US14::US14_0(toArray(Runtime::method48(
                        v11_0_0.clone(),
                        empty::<string>(),
                    )))
                }
                Runtime::US15::US15_1(v11_1_0) => Runtime::US14::US14_1(v11_1_0.clone()),
            }
        }
    }
    pub fn closure29(unitVar: (), v0_1: string) -> Result<Array<string>, string> {
        let v1_1: Runtime::US14 = Runtime::method40(v0_1);
        match &v1_1 {
            Runtime::US14::US14_0(v1_1_0_0) => Ok::<Array<string>, string>(v1_1_0_0.clone()),
            Runtime::US14::US14_1(v1_1_1_0) => Err::<Array<string>, string>(v1_1_1_0.clone()),
        }
    }
    pub fn v0() -> Func1<
        Runtime::US0,
        (
            LrcPtr<Runtime::Mut0>,
            LrcPtr<Runtime::Mut1>,
            LrcPtr<Runtime::Mut2>,
            LrcPtr<Runtime::Mut3>,
            Option<i64>,
        ),
    > {
        static v0: OnceInit<
            Func1<
                Runtime::US0,
                (
                    LrcPtr<Runtime::Mut0>,
                    LrcPtr<Runtime::Mut1>,
                    LrcPtr<Runtime::Mut2>,
                    LrcPtr<Runtime::Mut3>,
                    Option<i64>,
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
    pub fn v2() -> Func0<()> {
        static v2: OnceInit<Func0<()>> = OnceInit::new();
        v2.get_or_init(|| Func0::new(move || Runtime::closure2((), ())))
            .clone()
    }
    pub fn current_process_kill() {
        (Runtime::v2())();
    }
    pub fn v3() -> Func1<string, Arc<Async<(i32, string)>>> {
        static v3: OnceInit<Func1<string, Arc<Async<(i32, string)>>>> = OnceInit::new();
        v3.get_or_init(|| Func1::new(move |v: string| Runtime::closure9((), v)))
            .clone()
    }
    pub fn execute_async(x: string) -> Arc<Async<(i32, string)>> {
        (Runtime::v3())(x)
    }
    pub fn v4() -> Func1<
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
        static v4: OnceInit<
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
        v4.get_or_init(|| {
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
        (Runtime::v4())(x)
    }
    pub fn v5() -> Func1<
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
        static v5: OnceInit<
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
        v5.get_or_init(|| {
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
        (Runtime::v5())(x)
    }
    pub fn v6() -> Func1<string, Result<Array<string>, string>> {
        static v6: OnceInit<Func1<string, Result<Array<string>, string>>> = OnceInit::new();
        v6.get_or_init(|| Func1::new(move |v: string| Runtime::closure29((), v)))
            .clone()
    }
    pub fn split_args(x: string) -> Result<Array<string>, string> {
        (Runtime::v6())(x)
    }
    on_startup!(());
}
