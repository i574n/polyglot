pub mod Runtime {
    use super::*;
    type Async<T> = T;
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
    pub fn method1(v0: string) -> string {
        let _v3: MutCell<Option<string>> = MutCell::new(None::<string>);
        let v35: Result<std::string::String, std::env::VarError> = std::env::var(&*v0);
        let v37: bool = true;
        let _result = v35.map(|x| {
            //;
            let v39: std::string::String = x;
            let v41: string = fable_library_rust::String_::fromString(v39);
            let v43: bool = true;
            v41
        });
        let v45: Result<string, std::env::VarError> = _result;
        let v46: string = Runtime::method2();
        {
            let x: string = v45.unwrap_or(v46);
            _v3.set(Some(x))
        }
        match &_v3.get().clone() {
            None => panic!("{}", string("base.run_target / _v3=None"),),
            Some(_v3_0_0) => _v3_0_0.clone(),
        }
    }
    pub fn method3() -> string {
        string("AUTOMATION")
    }
    pub fn closure1(unitVar: (), v0: string) {
        ();
    }
    pub fn closure0(
        unitVar: (),
        v0: Runtime::US0,
    ) -> (
        LrcPtr<Runtime::Mut0>,
        LrcPtr<Runtime::Mut1>,
        LrcPtr<Runtime::Mut2>,
        LrcPtr<Runtime::Mut3>,
        Option<i64>,
    ) {
        let _v3: MutCell<Option<(Runtime::US1, Runtime::US2)>> =
            MutCell::new(None::<(Runtime::US1, Runtime::US2)>);
        _v3.set(Some((Runtime::US1::US1_1, Runtime::US2::US2_1)));
        {
            let patternInput: (Runtime::US1, Runtime::US2) = match &_v3.get().clone() {
                None => panic!("{}", string("base.run_target / _v3=None"),),
                Some(_v3_0_0) => _v3_0_0.clone(),
            };
            let v325: Runtime::US2 = patternInput.1.clone();
            let v324: Runtime::US1 = patternInput.0.clone();
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
                    l0: MutCell::new(match &v324 {
                        Runtime::US1::US1_0(v324_0_0) => match &v324 {
                            Runtime::US1::US1_0(x) => x.clone(),
                            _ => unreachable!(),
                        },
                        _ => v0,
                    }),
                }),
                match &v325 {
                    Runtime::US2::US2_0(v325_0_0) => Some(match &v325 {
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
    pub fn method9(v0: LrcPtr<Runtime::Mut4>) {
        ();
    }
    pub fn closure6(v0: Runtime::US0, v1: Func0<string>, v2_1: Func0<()>, unitVar: ()) -> string {
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
            let _v35: MutCell<Option<string>> = MutCell::new(None::<string>);
            {
                let x: string = Runtime::method6();
                _v35.set(Some(x))
            }
            {
                let v772: string = match &_v35.get().clone() {
                    None => panic!("{}", string("base.run_target / _v35=None"),),
                    Some(_v35_0_0) => _v35_0_0.clone(),
                };
                let v931: Runtime::US3 = if if let Runtime::US0::US0_0 = &v0 {
                    true
                } else {
                    false
                } {
                    Runtime::US3::US3_0(string("Verbose"))
                } else {
                    Runtime::US3::US3_1
                };
                let v980: Runtime::US3 = match &v931 {
                    Runtime::US3::US3_0(v931_0_0) => Runtime::US3::US3_0(match &v931 {
                        Runtime::US3::US3_0(x) => x.clone(),
                        _ => unreachable!(),
                    }),
                    _ => {
                        let v940: Runtime::US3 = if if let Runtime::US0::US0_1 = &v0 {
                            true
                        } else {
                            false
                        } {
                            Runtime::US3::US3_0(string("Debug"))
                        } else {
                            Runtime::US3::US3_1
                        };
                        match &v940 {
                            Runtime::US3::US3_0(v940_0_0) => Runtime::US3::US3_0(match &v940 {
                                Runtime::US3::US3_0(x) => x.clone(),
                                _ => unreachable!(),
                            }),
                            _ => {
                                let v949: Runtime::US3 = if if let Runtime::US0::US0_2 = &v0 {
                                    true
                                } else {
                                    false
                                } {
                                    Runtime::US3::US3_0(string("Info"))
                                } else {
                                    Runtime::US3::US3_1
                                };
                                match &v949 {
                                    Runtime::US3::US3_0(v949_0_0) => {
                                        Runtime::US3::US3_0(match &v949 {
                                            Runtime::US3::US3_0(x) => x.clone(),
                                            _ => unreachable!(),
                                        })
                                    }
                                    _ => {
                                        let v958: Runtime::US3 = if if let Runtime::US0::US0_3 = &v0
                                        {
                                            true
                                        } else {
                                            false
                                        } {
                                            Runtime::US3::US3_0(string("Warning"))
                                        } else {
                                            Runtime::US3::US3_1
                                        };
                                        match &v958 {
                                            Runtime::US3::US3_0(v958_0_0) => {
                                                Runtime::US3::US3_0(match &v958 {
                                                    Runtime::US3::US3_0(x) => x.clone(),
                                                    _ => unreachable!(),
                                                })
                                            }
                                            _ => {
                                                let v967: Runtime::US3 =
                                                    if if let Runtime::US0::US0_4 = &v0 {
                                                        true
                                                    } else {
                                                        false
                                                    } {
                                                        Runtime::US3::US3_0(string("Critical"))
                                                    } else {
                                                        Runtime::US3::US3_1
                                                    };
                                                match &v967 {
                                                    Runtime::US3::US3_0(v967_0_0) => {
                                                        Runtime::US3::US3_0(match &v967 {
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
                let v997: string = padLeft(
                    toLower(match &v980 {
                        Runtime::US3::US3_0(v980_0_0) => match &v980 {
                            Runtime::US3::US3_0(x) => x.clone(),
                            _ => unreachable!(),
                        },
                        _ => panic!("{}", string("Option does not have a value."),),
                    }),
                    7_i32,
                    ' ',
                );
                let _v1029: MutCell<Option<string>> = MutCell::new(None::<string>);
                let v1092: &str = match &v0 {
                    Runtime::US0::US0_1 => inline_colorization::color_bright_blue,
                    Runtime::US0::US0_2 => inline_colorization::color_bright_green,
                    Runtime::US0::US0_0 => inline_colorization::color_bright_black,
                    Runtime::US0::US0_3 => inline_colorization::color_yellow,
                    _ => inline_colorization::color_bright_red,
                };
                let v1094: &str = &*v997;
                let v1096: &str = inline_colorization::color_reset;
                let v1098: string = string("format!(\"{v1092}{v1094}{v1096}\")");
                let v1099: std::string::String = format!("{v1092}{v1094}{v1096}");
                {
                    let x_2: string = fable_library_rust::String_::fromString(v1099);
                    _v1029.set(Some(x_2))
                }
                {
                    let v1141: string = match &_v1029.get().clone() {
                        None => panic!("{}", string("base.run_target / _v1029=None"),),
                        Some(_v1029_0_0) => _v1029_0_0.clone(),
                    };
                    let v1160: i64 = (patternInput.0.clone()).l0.get().clone();
                    v2_1();
                    {
                        let v1162: LrcPtr<Runtime::Mut4> = LrcPtr::new(Runtime::Mut4 {
                            l0: MutCell::new(string("")),
                        });
                        Runtime::method9(v1162.clone());
                        {
                            let v1163: string = v1162.l0.get().clone();
                            trimEndChars(
                                trimStartChars(
                                    sprintf!("{} {} #{} {} / {}", v772, v1141, v1160, v1(), v1163),
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
    pub fn method10(v0: Runtime::US0, v1: Func0<string>) {
        fn v4(
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
            Runtime::State::trace_state().set(Some(v4(Runtime::US0::US0_0)));
        }
        {
            let patternInput: (
                LrcPtr<Runtime::Mut0>,
                LrcPtr<Runtime::Mut1>,
                LrcPtr<Runtime::Mut2>,
                LrcPtr<Runtime::Mut3>,
                Option<i64>,
            ) = getValue(Runtime::State::trace_state().get().clone());
            let v13_1: LrcPtr<Runtime::Mut0> = patternInput.0.clone();
            if Runtime::State::trace_state().get().clone().is_none() {
                Runtime::State::trace_state().set(Some(v4(Runtime::US0::US0_0)));
            }
            {
                let patternInput_1: (
                    LrcPtr<Runtime::Mut0>,
                    LrcPtr<Runtime::Mut1>,
                    LrcPtr<Runtime::Mut2>,
                    LrcPtr<Runtime::Mut3>,
                    Option<i64>,
                ) = getValue(Runtime::State::trace_state().get().clone());
                let v61: Runtime::US0 = (patternInput_1.3.clone()).l0.get().clone();
                if if (patternInput_1.2.clone()).l0.get().clone() == false {
                    false
                } else {
                    find(
                        v0,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Runtime::US0::US0_0, 0_i32)),
                            LrcPtr::new((Runtime::US0::US0_1, 1_i32)),
                            LrcPtr::new((Runtime::US0::US0_2, 2_i32)),
                            LrcPtr::new((Runtime::US0::US0_3, 3_i32)),
                            LrcPtr::new((Runtime::US0::US0_4, 4_i32)),
                        ])))),
                    ) >= find(
                        v61,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Runtime::US0::US0_0, 0_i32)),
                            LrcPtr::new((Runtime::US0::US0_1, 1_i32)),
                            LrcPtr::new((Runtime::US0::US0_2, 2_i32)),
                            LrcPtr::new((Runtime::US0::US0_3, 3_i32)),
                            LrcPtr::new((Runtime::US0::US0_4, 4_i32)),
                        ])))),
                    )
                } {
                    let v69: i64 = v13_1.l0.get().clone() + 1_i64;
                    v13_1.l0.set(v69);
                    {
                        let v72: string = sprintf!("{}", v1());
                        let _v81: MutCell<Option<()>> = MutCell::new(None::<()>);
                        println!("{}", v72.clone());
                        _v81.set(Some(()));
                        match &_v81.get().clone() {
                            None => panic!("{}", string("base.run_target / _v81=None"),),
                            Some(_v81_0_0) => _v81_0_0.clone(),
                        }
                        ((patternInput.1.clone()).l0.get().clone())(v72)
                    }
                }
            }
        }
    }
    pub fn method4(v0: Runtime::US0, v1: Func0<string>, v2_1: Func0<()>) {
        Runtime::method10(
            v0.clone(),
            Func0::new({
                let v0 = v0.clone();
                let v1 = v1.clone();
                let v2_1 = v2_1.clone();
                move || Runtime::closure6(v0.clone(), v1.clone(), v2_1.clone(), ())
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
        let _v2: MutCell<Option<()>> = MutCell::new(None::<()>);
        defaultOf::<()>();
        _v2.set(Some(()));
        match &_v2.get().clone() {
            None => panic!("{}", string("base.run_target / _v2=None"),),
            Some(_v2_0_0) => _v2_0_0.clone(),
        }
        ()
    }
    pub fn closure2(unitVar: (), unitVar_1: ()) {
        let _v2: MutCell<Option<()>> = MutCell::new(None::<()>);
        defaultOf::<()>();
        _v2.set(Some(()));
        match &_v2.get().clone() {
            None => panic!("{}", string("base.run_target / _v2=None"),),
            Some(_v2_0_0) => _v2_0_0.clone(),
        }
        ()
    }
    pub fn method13(v0: i32, v1: LrcPtr<Runtime::Mut5>) -> bool {
        v1.l0.get().clone() < v0
    }
    pub fn closure12(v0: char, v1: LrcPtr<Runtime::UH0>) -> LrcPtr<Runtime::UH0> {
        LrcPtr::new(Runtime::UH0::UH0_1(v0, v1))
    }
    pub fn closure11(unitVar: (), v0: char) -> Func1<LrcPtr<Runtime::UH0>, LrcPtr<Runtime::UH0>> {
        Func1::new({
            let v0 = v0.clone();
            move |v: LrcPtr<Runtime::UH0>| Runtime::closure12(v0, v)
        })
    }
    pub fn method14() -> Func1<char, Func1<LrcPtr<Runtime::UH0>, LrcPtr<Runtime::UH0>>> {
        Func1::new(move |v: char| Runtime::closure11((), v))
    }
    pub fn method15(
        v0: LrcPtr<Runtime::UH0>,
        v1: LrcPtr<StringBuilder>,
        v2_1: i32,
        v3_1: i32,
    ) -> (LrcPtr<StringBuilder>, i32, i32) {
        let v0: MutCell<LrcPtr<Runtime::UH0>> = MutCell::new(v0.clone());
        let v1: MutCell<LrcPtr<StringBuilder>> = MutCell::new(v1.clone());
        let v2_1: MutCell<i32> = MutCell::new(v2_1);
        let v3_1: MutCell<i32> = MutCell::new(v3_1);
        '_method15: loop {
            break '_method15 (match v0.get().clone().as_ref() {
                Runtime::UH0::UH0_0 => (v1.get().clone(), v2_1.get().clone(), v3_1.get().clone()),
                Runtime::UH0::UH0_1(v0_1_0, v0_1_1) => {
                    let v4: char = match v0.get().clone().as_ref() {
                        Runtime::UH0::UH0_1(x, _) => x.clone(),
                        _ => unreachable!(),
                    };
                    let v6: bool = '\n' == v4;
                    let patternInput: (i32, i32) = if v6 {
                        (v2_1.get().clone() + 1_i32, 1_i32)
                    } else {
                        (v2_1.get().clone(), v3_1.get().clone() + 1_i32)
                    };
                    {
                        let v0_temp: LrcPtr<Runtime::UH0> = match v0.get().clone().as_ref() {
                            Runtime::UH0::UH0_1(_, x) => x.clone(),
                            _ => unreachable!(),
                        };
                        let v1_temp: LrcPtr<StringBuilder> = if v6 {
                            let v12_1: LrcPtr<StringBuilder> = v1.get().clone().Clear();
                            v1.get().clone()
                        } else {
                            let v24: LrcPtr<StringBuilder> = {
                                let value: string = ofChar(v4);
                                v1.get().clone().Append_Z721C83C5(value)
                            };
                            v1.get().clone()
                        };
                        let v2_1_temp: i32 = patternInput.0.clone();
                        let v3_1_temp: i32 = patternInput.1.clone();
                        v0.set(v0_temp);
                        v1.set(v1_temp);
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
        let v1: LrcPtr<StringBuilder> = _arg.1.clone();
        let v0: string = _arg.0.clone();
        if string("") == v0.clone() {
            Runtime::US5::US5_1(sprintf!(
                "parsing.p_char / unexpected end of input / s: {:?}",
                (v1.clone(), v2_1, v3_1)
            ))
        } else {
            let v7: char = getCharAt(v0.clone(), 0_i32);
            if v7 == '\"' {
                let v15: string = getSlice(v0.clone(), Some(1_i32), Some(length(v0.clone())));
                let v19: string = ofChar(v7);
                let v26: i32 = length(v19.clone());
                let v27: Array<char> = new_init(&'\u{0000}', v26);
                let v28: LrcPtr<Runtime::Mut5> = LrcPtr::new(Runtime::Mut5 {
                    l0: MutCell::new(0_i32),
                });
                while Runtime::method13(v26, v28.clone()) {
                    let v30: i32 = v28.l0.get().clone();
                    let v31: char = getCharAt(v19.clone(), v30);
                    v27.get_mut()[v30 as usize] = v31;
                    {
                        let v32: i32 = v30 + 1_i32;
                        v28.l0.set(v32);
                        ()
                    }
                }
                {
                    let v33: List<char> = ofArray(v27.clone());
                    let patternInput: (LrcPtr<StringBuilder>, i32, i32) = Runtime::method15(
                        foldBack(
                            Func2::new(move |b0: char, b1: LrcPtr<Runtime::UH0>| {
                                (Runtime::method14())(b0)(b1)
                            }),
                            v33,
                            LrcPtr::new(Runtime::UH0::UH0_0),
                        ),
                        v1.clone(),
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
                let v55: i32 = length(v0.clone());
                let v58: i32 = indexOf(v0.clone(), string("\n")) - 1_i32;
                Runtime::US5::US5_1(sprintf!(
                    "{}\n{}\n",
                    sprintf!(
                        "parsing.p_char / expected: \'{}\' / line: {} / col: {}\n{}{}",
                        '\"',
                        v2_1,
                        v3_1,
                        v1,
                        getSlice(v0, Some(0_i32), Some(if -2_i32 == v58 { v55 } else { v58 }))
                    ),
                    append(replicate(v3_1 - 1_i32, string(" ")), string("^"))
                ))
            }
        }
    }
    pub fn closure13(unitVar: (), _arg: (string, LrcPtr<StringBuilder>, i32, i32)) -> Runtime::US5 {
        let v3_1: i32 = _arg.3.clone();
        let v2_1: i32 = _arg.2.clone();
        let v1: LrcPtr<StringBuilder> = _arg.1.clone();
        let v0: string = _arg.0.clone();
        if string("") == v0.clone() {
            Runtime::US5::US5_1(sprintf!(
                "parsing.p_char / unexpected end of input / s: {:?}",
                (v1.clone(), v2_1, v3_1)
            ))
        } else {
            let v7: char = getCharAt(v0.clone(), 0_i32);
            if v7 == '\'' {
                let v15: string = getSlice(v0.clone(), Some(1_i32), Some(length(v0.clone())));
                let v19: string = ofChar(v7);
                let v26: i32 = length(v19.clone());
                let v27: Array<char> = new_init(&'\u{0000}', v26);
                let v28: LrcPtr<Runtime::Mut5> = LrcPtr::new(Runtime::Mut5 {
                    l0: MutCell::new(0_i32),
                });
                while Runtime::method13(v26, v28.clone()) {
                    let v30: i32 = v28.l0.get().clone();
                    let v31: char = getCharAt(v19.clone(), v30);
                    v27.get_mut()[v30 as usize] = v31;
                    {
                        let v32: i32 = v30 + 1_i32;
                        v28.l0.set(v32);
                        ()
                    }
                }
                {
                    let v33: List<char> = ofArray(v27.clone());
                    let patternInput: (LrcPtr<StringBuilder>, i32, i32) = Runtime::method15(
                        foldBack(
                            Func2::new(move |b0: char, b1: LrcPtr<Runtime::UH0>| {
                                (Runtime::method14())(b0)(b1)
                            }),
                            v33,
                            LrcPtr::new(Runtime::UH0::UH0_0),
                        ),
                        v1.clone(),
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
                let v55: i32 = length(v0.clone());
                let v58: i32 = indexOf(v0.clone(), string("\n")) - 1_i32;
                Runtime::US5::US5_1(sprintf!(
                    "{}\n{}\n",
                    sprintf!(
                        "parsing.p_char / expected: \'{}\' / line: {} / col: {}\n{}{}",
                        '\'',
                        v2_1,
                        v3_1,
                        v1,
                        getSlice(v0, Some(0_i32), Some(if -2_i32 == v58 { v55 } else { v58 }))
                    ),
                    append(replicate(v3_1 - 1_i32, string(" ")), string("^"))
                ))
            }
        }
    }
    pub fn method16(
        v0: string,
        v1: LrcPtr<StringBuilder>,
        v2_1: LrcPtr<Runtime::UH1>,
    ) -> Runtime::US5 {
        let v0: MutCell<string> = MutCell::new(v0.clone());
        let v1: MutCell<LrcPtr<StringBuilder>> = MutCell::new(v1.clone());
        let v2_1: MutCell<LrcPtr<Runtime::UH1>> = MutCell::new(v2_1.clone());
        '_method16: loop {
            break '_method16 (match v2_1.get().clone().as_ref() {
                Runtime::UH1::UH1_0 => Runtime::US5::US5_1(string("choice / no parsers succeeded")),
                Runtime::UH1::UH1_1(v2_1_1_0, v2_1_1_1) => {
                    let v7: Runtime::US5 = (match v2_1.get().clone().as_ref() {
                        Runtime::UH1::UH1_1(x, _) => x.clone(),
                        _ => unreachable!(),
                    })((
                        v0.get().clone(),
                        v1.get().clone(),
                        1_i32,
                        1_i32,
                    ));
                    match &v7 {
                        Runtime::US5::US5_0(v7_0_0, v7_0_1, v7_0_2, v7_0_3, v7_0_4) => v7.clone(),
                        _ => {
                            let v0_temp: string = v0.get().clone();
                            let v1_temp: LrcPtr<StringBuilder> = v1.get().clone();
                            let v2_1_temp: LrcPtr<Runtime::UH1> = match v2_1.get().clone().as_ref()
                            {
                                Runtime::UH1::UH1_1(_, x) => x.clone(),
                                _ => unreachable!(),
                            };
                            v0.set(v0_temp);
                            v1.set(v1_temp);
                            v2_1.set(v2_1_temp);
                            continue '_method16;
                        }
                    }
                }
            });
        }
    }
    pub fn method17(v0: char, v1: i64) -> bool {
        let v0: MutCell<char> = MutCell::new(v0);
        let v1: MutCell<i64> = MutCell::new(v1);
        '_method17: loop {
            break '_method17 (if v1.get().clone() >= 2_i64 {
                false
            } else {
                let v11_1: Runtime::US7 = if v1.get().clone() == 0_i64 {
                    Runtime::US7::US7_0('\"')
                } else {
                    let v5: i64 = v1.get().clone() - 1_i64;
                    if v5 == 0_i64 {
                        Runtime::US7::US7_0('\'')
                    } else {
                        let v8: i64 = v5 - 1_i64;
                        Runtime::US7::US7_1
                    }
                };
                if v0.get().clone()
                    == match &v11_1 {
                        Runtime::US7::US7_0(v11_1_0_0) => match &v11_1 {
                            Runtime::US7::US7_0(x) => x.clone(),
                            _ => unreachable!(),
                        },
                        _ => panic!("{}", string("Option does not have a value."),),
                    }
                {
                    true
                } else {
                    let v0_temp: char = v0.get().clone();
                    let v1_temp: i64 = v1.get().clone() + 1_i64;
                    v0.set(v0_temp);
                    v1.set(v1_temp);
                    continue '_method17;
                }
            });
        }
    }
    pub fn method18(
        v0: string,
        v1: string,
        v2_1: LrcPtr<StringBuilder>,
        v3_1: i32,
        v4: i32,
    ) -> Runtime::US6 {
        let v0: MutCell<string> = MutCell::new(v0.clone());
        let v1: MutCell<string> = MutCell::new(v1.clone());
        let v2_1: MutCell<LrcPtr<StringBuilder>> = MutCell::new(v2_1.clone());
        let v3_1: MutCell<i32> = MutCell::new(v3_1);
        let v4: MutCell<i32> = MutCell::new(v4);
        '_method18: loop {
            break '_method18 ({
                let v118: Runtime::US5 = if string("") == v1.get().clone() {
                    Runtime::US5::US5_1(sprintf!(
                        "parsing.none_of / unexpected end of input / chars: {:?} / s: {:?}",
                        toArray(ofArray(new_array(&['\"', '\'']))),
                        (v2_1.get().clone(), v3_1.get().clone(), v4.get().clone())
                    ))
                } else {
                    let v37: char = getCharAt(v1.get().clone(), 0_i32);
                    let v44: string = getSlice(
                        v1.get().clone(),
                        Some(1_i32),
                        Some(length(v1.get().clone())),
                    );
                    if Runtime::method17(v37, 0_i64) == false {
                        let v51: string = ofChar(v37);
                        let v58: i32 = length(v51.clone());
                        let v59: Array<char> = new_init(&'\u{0000}', v58);
                        let v60: LrcPtr<Runtime::Mut5> = LrcPtr::new(Runtime::Mut5 {
                            l0: MutCell::new(0_i32),
                        });
                        while Runtime::method13(v58, v60.clone()) {
                            let v62: i32 = v60.l0.get().clone();
                            let v63: char = getCharAt(v51.clone(), v62);
                            v59.get_mut()[v62 as usize] = v63;
                            {
                                let v64: i32 = v62 + 1_i32;
                                v60.l0.set(v64);
                                ()
                            }
                        }
                        {
                            let v65: List<char> = ofArray(v59.clone());
                            let patternInput: (LrcPtr<StringBuilder>, i32, i32) = Runtime::method15(
                                foldBack(
                                    Func2::new(move |b0: char, b1: LrcPtr<Runtime::UH0>| {
                                        (Runtime::method14())(b0)(b1)
                                    }),
                                    v65,
                                    LrcPtr::new(Runtime::UH0::UH0_0),
                                ),
                                v2_1.get().clone(),
                                v3_1.get().clone(),
                                v4.get().clone(),
                            );
                            Runtime::US5::US5_0(
                                v37,
                                v44,
                                patternInput.0.clone(),
                                patternInput.1.clone(),
                                patternInput.2.clone(),
                            )
                        }
                    } else {
                        Runtime::US5::US5_1(sprintf!(
                            "parsing.none_of / unexpected char: \'{}\' / chars: {:?} / s: {:?}",
                            v37,
                            toArray(ofArray(new_array(&['\"', '\'']))),
                            (v2_1.get().clone(), v3_1.get().clone(), v4.get().clone())
                        ))
                    }
                };
                let v130: Runtime::US5 = match &v118 {
                    Runtime::US5::US5_0(v118_0_0, v118_0_1, v118_0_2, v118_0_3, v118_0_4) => {
                        let v119: char = v118_0_0.clone();
                        Runtime::US5::US5_0(
                            if '\\' == v119 { '/' } else { v119 },
                            v118_0_1.clone(),
                            v118_0_2.clone(),
                            v118_0_3.clone(),
                            v118_0_4.clone(),
                        )
                    }
                    Runtime::US5::US5_1(v118_1_0) => Runtime::US5::US5_1(v118_1_0.clone()),
                };
                match &v130 {
                    Runtime::US5::US5_0(v130_0_0, v130_0_1, v130_0_2, v130_0_3, v130_0_4) => {
                        let v0_temp: string = append(v0.get().clone(), ofChar(v130_0_0.clone()));
                        let v1_temp: string = v130_0_1.clone();
                        let v2_1_temp: LrcPtr<StringBuilder> = v130_0_2.clone();
                        let v3_1_temp: i32 = v130_0_3.clone();
                        let v4_temp: i32 = v130_0_4.clone();
                        v0.set(v0_temp);
                        v1.set(v1_temp);
                        v2_1.set(v2_1_temp);
                        v3_1.set(v3_1_temp);
                        v4.set(v4_temp);
                        continue '_method18;
                    }
                    _ => Runtime::US6::US6_0(
                        v0.get().clone(),
                        v1.get().clone(),
                        v2_1.get().clone(),
                        v3_1.get().clone(),
                        v4.get().clone(),
                    ),
                }
            });
        }
    }
    pub fn method19(
        v0: string,
        v1: LrcPtr<StringBuilder>,
        v2_1: i32,
        v3_1: i32,
        v4: LrcPtr<Runtime::UH1>,
    ) -> Runtime::US5 {
        let v0: MutCell<string> = MutCell::new(v0.clone());
        let v1: MutCell<LrcPtr<StringBuilder>> = MutCell::new(v1.clone());
        let v2_1: MutCell<i32> = MutCell::new(v2_1);
        let v3_1: MutCell<i32> = MutCell::new(v3_1);
        let v4: MutCell<LrcPtr<Runtime::UH1>> = MutCell::new(v4.clone());
        '_method19: loop {
            break '_method19 (match v4.get().clone().as_ref() {
                Runtime::UH1::UH1_0 => Runtime::US5::US5_1(string("choice / no parsers succeeded")),
                Runtime::UH1::UH1_1(v4_1_0, v4_1_1) => {
                    let v9_1: Runtime::US5 = (match v4.get().clone().as_ref() {
                        Runtime::UH1::UH1_1(x, _) => x.clone(),
                        _ => unreachable!(),
                    })((
                        v0.get().clone(),
                        v1.get().clone(),
                        v2_1.get().clone(),
                        v3_1.get().clone(),
                    ));
                    match &v9_1 {
                        Runtime::US5::US5_0(v9_1_0_0, v9_1_0_1, v9_1_0_2, v9_1_0_3, v9_1_0_4) => {
                            v9_1.clone()
                        }
                        _ => {
                            let v0_temp: string = v0.get().clone();
                            let v1_temp: LrcPtr<StringBuilder> = v1.get().clone();
                            let v2_1_temp: i32 = v2_1.get().clone();
                            let v3_1_temp: i32 = v3_1.get().clone();
                            let v4_temp: LrcPtr<Runtime::UH1> = match v4.get().clone().as_ref() {
                                Runtime::UH1::UH1_1(_, x) => x.clone(),
                                _ => unreachable!(),
                            };
                            v0.set(v0_temp);
                            v1.set(v1_temp);
                            v2_1.set(v2_1_temp);
                            v3_1.set(v3_1_temp);
                            v4.set(v4_temp);
                            continue '_method19;
                        }
                    }
                }
            });
        }
    }
    pub fn method20(v0: char, v1: i64) -> bool {
        let v0: MutCell<char> = MutCell::new(v0);
        let v1: MutCell<i64> = MutCell::new(v1);
        '_method20: loop {
            break '_method20 (if v1.get().clone() >= 3_i64 {
                false
            } else {
                let v15: Runtime::US7 = if v1.get().clone() == 0_i64 {
                    Runtime::US7::US7_0('\"')
                } else {
                    let v5: i64 = v1.get().clone() - 1_i64;
                    if v5 == 0_i64 {
                        Runtime::US7::US7_0('\'')
                    } else {
                        let v8: i64 = v5 - 1_i64;
                        if v8 == 0_i64 {
                            Runtime::US7::US7_0(' ')
                        } else {
                            let v11_1: i64 = v8 - 1_i64;
                            Runtime::US7::US7_1
                        }
                    }
                };
                if v0.get().clone()
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
                    let v0_temp: char = v0.get().clone();
                    let v1_temp: i64 = v1.get().clone() + 1_i64;
                    v0.set(v0_temp);
                    v1.set(v1_temp);
                    continue '_method20;
                }
            });
        }
    }
    pub fn method21(
        v0: string,
        v1: string,
        v2_1: LrcPtr<StringBuilder>,
        v3_1: i32,
        v4: i32,
    ) -> Runtime::US6 {
        let v0: MutCell<string> = MutCell::new(v0.clone());
        let v1: MutCell<string> = MutCell::new(v1.clone());
        let v2_1: MutCell<LrcPtr<StringBuilder>> = MutCell::new(v2_1.clone());
        let v3_1: MutCell<i32> = MutCell::new(v3_1);
        let v4: MutCell<i32> = MutCell::new(v4);
        '_method21: loop {
            break '_method21 ({
                let v136: Runtime::US5 = if string("") == v1.get().clone() {
                    Runtime::US5::US5_1(sprintf!(
                        "parsing.none_of / unexpected end of input / chars: {:?} / s: {:?}",
                        toArray(ofArray(new_array(&['\"', '\'', ' ']))),
                        (v2_1.get().clone(), v3_1.get().clone(), v4.get().clone())
                    ))
                } else {
                    let v46: char = getCharAt(v1.get().clone(), 0_i32);
                    let v53: string = getSlice(
                        v1.get().clone(),
                        Some(1_i32),
                        Some(length(v1.get().clone())),
                    );
                    if Runtime::method20(v46, 0_i64) == false {
                        let v60: string = ofChar(v46);
                        let v67: i32 = length(v60.clone());
                        let v68: Array<char> = new_init(&'\u{0000}', v67);
                        let v69: LrcPtr<Runtime::Mut5> = LrcPtr::new(Runtime::Mut5 {
                            l0: MutCell::new(0_i32),
                        });
                        while Runtime::method13(v67, v69.clone()) {
                            let v71: i32 = v69.l0.get().clone();
                            let v72: char = getCharAt(v60.clone(), v71);
                            v68.get_mut()[v71 as usize] = v72;
                            {
                                let v73: i32 = v71 + 1_i32;
                                v69.l0.set(v73);
                                ()
                            }
                        }
                        {
                            let v74: List<char> = ofArray(v68.clone());
                            let patternInput: (LrcPtr<StringBuilder>, i32, i32) = Runtime::method15(
                                foldBack(
                                    Func2::new(move |b0: char, b1: LrcPtr<Runtime::UH0>| {
                                        (Runtime::method14())(b0)(b1)
                                    }),
                                    v74,
                                    LrcPtr::new(Runtime::UH0::UH0_0),
                                ),
                                v2_1.get().clone(),
                                v3_1.get().clone(),
                                v4.get().clone(),
                            );
                            Runtime::US5::US5_0(
                                v46,
                                v53,
                                patternInput.0.clone(),
                                patternInput.1.clone(),
                                patternInput.2.clone(),
                            )
                        }
                    } else {
                        Runtime::US5::US5_1(sprintf!(
                            "parsing.none_of / unexpected char: \'{}\' / chars: {:?} / s: {:?}",
                            v46,
                            toArray(ofArray(new_array(&['\"', '\'', ' ']))),
                            (v2_1.get().clone(), v3_1.get().clone(), v4.get().clone())
                        ))
                    }
                };
                let v148: Runtime::US5 = match &v136 {
                    Runtime::US5::US5_0(v136_0_0, v136_0_1, v136_0_2, v136_0_3, v136_0_4) => {
                        let v137: char = v136_0_0.clone();
                        Runtime::US5::US5_0(
                            if '\\' == v137 { '/' } else { v137 },
                            v136_0_1.clone(),
                            v136_0_2.clone(),
                            v136_0_3.clone(),
                            v136_0_4.clone(),
                        )
                    }
                    Runtime::US5::US5_1(v136_1_0) => Runtime::US5::US5_1(v136_1_0.clone()),
                };
                match &v148 {
                    Runtime::US5::US5_0(v148_0_0, v148_0_1, v148_0_2, v148_0_3, v148_0_4) => {
                        let v0_temp: string = append(v0.get().clone(), ofChar(v148_0_0.clone()));
                        let v1_temp: string = v148_0_1.clone();
                        let v2_1_temp: LrcPtr<StringBuilder> = v148_0_2.clone();
                        let v3_1_temp: i32 = v148_0_3.clone();
                        let v4_temp: i32 = v148_0_4.clone();
                        v0.set(v0_temp);
                        v1.set(v1_temp);
                        v2_1.set(v2_1_temp);
                        v3_1.set(v3_1_temp);
                        v4.set(v4_temp);
                        continue '_method21;
                    }
                    _ => Runtime::US6::US6_0(
                        v0.get().clone(),
                        v1.get().clone(),
                        v2_1.get().clone(),
                        v3_1.get().clone(),
                        v4.get().clone(),
                    ),
                }
            });
        }
    }
    pub fn method22(v0: string, v1: i32) -> i32 {
        let v0: MutCell<string> = MutCell::new(v0.clone());
        let v1: MutCell<i32> = MutCell::new(v1);
        '_method22: loop {
            break '_method22 (if v1.get().clone() >= length(v0.get().clone()) {
                v1.get().clone()
            } else {
                if getCharAt(v0.get().clone(), v1.get().clone()) == ' ' {
                    let v0_temp: string = v0.get().clone();
                    let v1_temp: i32 = v1.get().clone() + 1_i32;
                    v0.set(v0_temp);
                    v1.set(v1_temp);
                    continue '_method22;
                } else {
                    v1.get().clone()
                }
            });
        }
    }
    pub fn method23(
        v0: string,
        v1: string,
        v2_1: LrcPtr<StringBuilder>,
        v3_1: i32,
        v4: i32,
    ) -> Runtime::US6 {
        let v0: MutCell<string> = MutCell::new(v0.clone());
        let v1: MutCell<string> = MutCell::new(v1.clone());
        let v2_1: MutCell<LrcPtr<StringBuilder>> = MutCell::new(v2_1.clone());
        let v3_1: MutCell<i32> = MutCell::new(v3_1);
        let v4: MutCell<i32> = MutCell::new(v4);
        '_method23: loop {
            break '_method23 ({
                let v54: Runtime::US5 = if string("") == v1.get().clone() {
                    Runtime::US5::US5_1(sprintf!(
                        "parsing.any_char / unexpected end of input / s: {:?}",
                        (v2_1.get().clone(), v3_1.get().clone(), v4.get().clone())
                    ))
                } else {
                    let v8: char = getCharAt(v1.get().clone(), 0_i32);
                    let v15: string = getSlice(
                        v1.get().clone(),
                        Some(1_i32),
                        Some(length(v1.get().clone())),
                    );
                    let v19: string = ofChar(v8);
                    let v26: i32 = length(v19.clone());
                    let v27: Array<char> = new_init(&'\u{0000}', v26);
                    let v28: LrcPtr<Runtime::Mut5> = LrcPtr::new(Runtime::Mut5 {
                        l0: MutCell::new(0_i32),
                    });
                    while Runtime::method13(v26, v28.clone()) {
                        let v30: i32 = v28.l0.get().clone();
                        let v31: char = getCharAt(v19.clone(), v30);
                        v27.get_mut()[v30 as usize] = v31;
                        {
                            let v32: i32 = v30 + 1_i32;
                            v28.l0.set(v32);
                            ()
                        }
                    }
                    {
                        let v33: List<char> = ofArray(v27.clone());
                        let patternInput: (LrcPtr<StringBuilder>, i32, i32) = Runtime::method15(
                            foldBack(
                                Func2::new(move |b0: char, b1: LrcPtr<Runtime::UH0>| {
                                    (Runtime::method14())(b0)(b1)
                                }),
                                v33,
                                LrcPtr::new(Runtime::UH0::UH0_0),
                            ),
                            v2_1.get().clone(),
                            v3_1.get().clone(),
                            v4.get().clone(),
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
                match &v54 {
                    Runtime::US5::US5_0(v54_0_0, v54_0_1, v54_0_2, v54_0_3, v54_0_4) => {
                        let v0_temp: string = append(v0.get().clone(), ofChar(v54_0_0.clone()));
                        let v1_temp: string = v54_0_1.clone();
                        let v2_1_temp: LrcPtr<StringBuilder> = v54_0_2.clone();
                        let v3_1_temp: i32 = v54_0_3.clone();
                        let v4_temp: i32 = v54_0_4.clone();
                        v0.set(v0_temp);
                        v1.set(v1_temp);
                        v2_1.set(v2_1_temp);
                        v3_1.set(v3_1_temp);
                        v4.set(v4_temp);
                        continue '_method23;
                    }
                    _ => Runtime::US6::US6_0(
                        v0.get().clone(),
                        v1.get().clone(),
                        v2_1.get().clone(),
                        v3_1.get().clone(),
                        v4.get().clone(),
                    ),
                }
            });
        }
    }
    pub fn method12(v0: string) -> Runtime::US4 {
        let _v0: MutCell<Option<Option<string>>> = MutCell::new(None::<Option<string>>);
        _v0.set(Some(Some(v0)));
        {
            let v15: string = defaultValue(
                string(""),
                match &_v0.get().clone() {
                    None => panic!("{}", string("optionm\'.of_obj / _v0=None"),),
                    Some(_v0_0_0) => _v0_0_0.clone(),
                },
            );
            let v23: LrcPtr<StringBuilder> = StringBuilder::_ctor__Z721C83C5(string(""));
            fn v24(arg10_0040: (string, LrcPtr<StringBuilder>, i32, i32)) -> Runtime::US5 {
                Runtime::closure10((), arg10_0040)
            }
            fn v25(arg10_0040_1: (string, LrcPtr<StringBuilder>, i32, i32)) -> Runtime::US5 {
                Runtime::closure13((), arg10_0040_1)
            }
            let v29: Runtime::US5 = Runtime::method16(
                v15.clone(),
                v23.clone(),
                LrcPtr::new(Runtime::UH1::UH1_1(
                    Func1::from(v24),
                    LrcPtr::new(Runtime::UH1::UH1_1(
                        Func1::from(v25),
                        LrcPtr::new(Runtime::UH1::UH1_0),
                    )),
                )),
            );
            let v219: Runtime::US6 = match &v29 {
                Runtime::US5::US5_0(v29_0_0, v29_0_1, v29_0_2, v29_0_3, v29_0_4) => {
                    let v34: i32 = v29_0_4.clone();
                    let v33: i32 = v29_0_3.clone();
                    let v32: LrcPtr<StringBuilder> = v29_0_2.clone();
                    let v31: string = v29_0_1.clone();
                    let v148: Runtime::US5 = if string("") == v31.clone() {
                        Runtime::US5::US5_1(sprintf!(
                            "parsing.none_of / unexpected end of input / chars: {:?} / s: {:?}",
                            toArray(ofArray(new_array(&['\"', '\'']))),
                            (v32.clone(), v33, v34)
                        ))
                    } else {
                        let v67: char = getCharAt(v31.clone(), 0_i32);
                        let v74: string =
                            getSlice(v31.clone(), Some(1_i32), Some(length(v31.clone())));
                        if Runtime::method17(v67, 0_i64) == false {
                            let v81: string = ofChar(v67);
                            let v88: i32 = length(v81.clone());
                            let v89: Array<char> = new_init(&'\u{0000}', v88);
                            let v90: LrcPtr<Runtime::Mut5> = LrcPtr::new(Runtime::Mut5 {
                                l0: MutCell::new(0_i32),
                            });
                            while Runtime::method13(v88, v90.clone()) {
                                let v92: i32 = v90.l0.get().clone();
                                let v93: char = getCharAt(v81.clone(), v92);
                                v89.get_mut()[v92 as usize] = v93;
                                {
                                    let v94: i32 = v92 + 1_i32;
                                    v90.l0.set(v94);
                                    ()
                                }
                            }
                            {
                                let v95: List<char> = ofArray(v89.clone());
                                let patternInput: (LrcPtr<StringBuilder>, i32, i32) =
                                    Runtime::method15(
                                        foldBack(
                                            Func2::new(
                                                move |b0: char, b1: LrcPtr<Runtime::UH0>| {
                                                    (Runtime::method14())(b0)(b1)
                                                },
                                            ),
                                            v95,
                                            LrcPtr::new(Runtime::UH0::UH0_0),
                                        ),
                                        v32.clone(),
                                        v33,
                                        v34,
                                    );
                                Runtime::US5::US5_0(
                                    v67,
                                    v74,
                                    patternInput.0.clone(),
                                    patternInput.1.clone(),
                                    patternInput.2.clone(),
                                )
                            }
                        } else {
                            Runtime::US5::US5_1(sprintf!(
                                "parsing.none_of / unexpected char: \'{}\' / chars: {:?} / s: {:?}",
                                v67,
                                toArray(ofArray(new_array(&['\"', '\'']))),
                                (v32.clone(), v33, v34)
                            ))
                        }
                    };
                    let v160: Runtime::US5 = match &v148 {
                        Runtime::US5::US5_0(v148_0_0, v148_0_1, v148_0_2, v148_0_3, v148_0_4) => {
                            let v149: char = v148_0_0.clone();
                            Runtime::US5::US5_0(
                                if '\\' == v149 { '/' } else { v149 },
                                v148_0_1.clone(),
                                v148_0_2.clone(),
                                v148_0_3.clone(),
                                v148_0_4.clone(),
                            )
                        }
                        Runtime::US5::US5_1(v148_1_0) => Runtime::US5::US5_1(v148_1_0.clone()),
                    };
                    let v180: Runtime::US6 = match &v160 {
                        Runtime::US5::US5_0(v160_0_0, v160_0_1, v160_0_2, v160_0_3, v160_0_4) => {
                            Runtime::method18(
                                ofChar(v160_0_0.clone()),
                                v160_0_1.clone(),
                                v160_0_2.clone(),
                                v160_0_3.clone(),
                                v160_0_4.clone(),
                            )
                        }
                        Runtime::US5::US5_1(v160_1_0) => Runtime::US6::US6_1(v160_1_0.clone()),
                    };
                    let v190: Runtime::US6 = match &v180 {
                        Runtime::US6::US6_0(v180_0_0, v180_0_1, v180_0_2, v180_0_3, v180_0_4) => {
                            Runtime::US6::US6_0(
                                v180_0_0.clone(),
                                v180_0_1.clone(),
                                v180_0_2.clone(),
                                v180_0_3.clone(),
                                v180_0_4.clone(),
                            )
                        }
                        _ => Runtime::US6::US6_0(string(""), v31.clone(), v32.clone(), v33, v34),
                    };
                    match &v190 {
                        Runtime::US6::US6_0(v190_0_0, v190_0_1, v190_0_2, v190_0_3, v190_0_4) => {
                            let v195: i32 = v190_0_4.clone();
                            let v194: i32 = v190_0_3.clone();
                            let v193: LrcPtr<StringBuilder> = v190_0_2.clone();
                            let v192: string = v190_0_1.clone();
                            let v199: Runtime::US5 = Runtime::method19(
                                v192.clone(),
                                v193.clone(),
                                v194,
                                v195,
                                LrcPtr::new(Runtime::UH1::UH1_1(
                                    Func1::from(v24),
                                    LrcPtr::new(Runtime::UH1::UH1_1(
                                        Func1::from(v25),
                                        LrcPtr::new(Runtime::UH1::UH1_0),
                                    )),
                                )),
                            );
                            match &v199 {
                                    Runtime::US5::US5_0(v199_0_0, v199_0_1,
                                                        v199_0_2, v199_0_3,
                                                        v199_0_4) =>
                                    Runtime::US6::US6_0(v190_0_0.clone(),
                                                        v199_0_1.clone(),
                                                        v199_0_2.clone(),
                                                        v199_0_3.clone(),
                                                        v199_0_4.clone()),
                                    Runtime::US5::US5_1(v199_1_0) =>
                                    Runtime::US6::US6_1(sprintf!("between / expected closing delimiter / e: {:?} / input: {:?} / rest1: {:?} / rest2: {:?}",
                                                                 v199_1_0.clone(),
                                                                 (v15.clone(),
                                                                  v23.clone(),
                                                                  1_i32,
                                                                  1_i32),
                                                                 (v31, v32,
                                                                  v33, v34),
                                                                 (v192, v193,
                                                                  v194,
                                                                  v195))),
                                }
                        }
                        _ => Runtime::US6::US6_1(string("between / expected content")),
                    }
                }
                Runtime::US5::US5_1(v29_1_0) => Runtime::US6::US6_1(v29_1_0.clone()),
            };
            let v435: Runtime::US6 = match &v219 {
                Runtime::US6::US6_0(v219_0_0, v219_0_1, v219_0_2, v219_0_3, v219_0_4) => {
                    v219.clone()
                }
                _ => {
                    let v359: Runtime::US5 = if string("") == v15.clone() {
                        Runtime::US5::US5_1(sprintf!(
                            "parsing.none_of / unexpected end of input / chars: {:?} / s: {:?}",
                            toArray(ofArray(new_array(&['\"', '\'', ' ']))),
                            (v23.clone(), 1_i32, 1_i32)
                        ))
                    } else {
                        let v267: char = getCharAt(v15.clone(), 0_i32);
                        let v274: string =
                            getSlice(v15.clone(), Some(1_i32), Some(length(v15.clone())));
                        if Runtime::method20(v267, 0_i64) == false {
                            let v281: string = ofChar(v267);
                            let v288: i32 = length(v281.clone());
                            let v289: Array<char> = new_init(&'\u{0000}', v288);
                            let v290: LrcPtr<Runtime::Mut5> = LrcPtr::new(Runtime::Mut5 {
                                l0: MutCell::new(0_i32),
                            });
                            while Runtime::method13(v288, v290.clone()) {
                                let v292: i32 = v290.l0.get().clone();
                                let v293: char = getCharAt(v281.clone(), v292);
                                v289.get_mut()[v292 as usize] = v293;
                                {
                                    let v294: i32 = v292 + 1_i32;
                                    v290.l0.set(v294);
                                    ()
                                }
                            }
                            {
                                let v295: List<char> = ofArray(v289.clone());
                                let patternInput_1: (LrcPtr<StringBuilder>, i32, i32) =
                                    Runtime::method15(
                                        foldBack(
                                            Func2::new(
                                                move |b0: char, b1: LrcPtr<Runtime::UH0>| {
                                                    (Runtime::method14())(b0)(b1)
                                                },
                                            ),
                                            v295,
                                            LrcPtr::new(Runtime::UH0::UH0_0),
                                        ),
                                        v23.clone(),
                                        1_i32,
                                        1_i32,
                                    );
                                Runtime::US5::US5_0(
                                    v267,
                                    v274,
                                    patternInput_1.0.clone(),
                                    patternInput_1.1.clone(),
                                    patternInput_1.2.clone(),
                                )
                            }
                        } else {
                            Runtime::US5::US5_1(sprintf!(
                                "parsing.none_of / unexpected char: \'{}\' / chars: {:?} / s: {:?}",
                                v267,
                                toArray(ofArray(new_array(&['\"', '\'', ' ']))),
                                (v23.clone(), 1_i32, 1_i32)
                            ))
                        }
                    };
                    let v371: Runtime::US5 = match &v359 {
                        Runtime::US5::US5_0(v359_0_0, v359_0_1, v359_0_2, v359_0_3, v359_0_4) => {
                            let v360: char = v359_0_0.clone();
                            Runtime::US5::US5_0(
                                if '\\' == v360 { '/' } else { v360 },
                                v359_0_1.clone(),
                                v359_0_2.clone(),
                                v359_0_3.clone(),
                                v359_0_4.clone(),
                            )
                        }
                        Runtime::US5::US5_1(v359_1_0) => Runtime::US5::US5_1(v359_1_0.clone()),
                    };
                    let v391: Runtime::US6 = match &v371 {
                        Runtime::US5::US5_0(v371_0_0, v371_0_1, v371_0_2, v371_0_3, v371_0_4) => {
                            Runtime::method21(
                                ofChar(v371_0_0.clone()),
                                v371_0_1.clone(),
                                v371_0_2.clone(),
                                v371_0_3.clone(),
                                v371_0_4.clone(),
                            )
                        }
                        Runtime::US5::US5_1(v371_1_0) => Runtime::US6::US6_1(v371_1_0.clone()),
                    };
                    match &v391 {
                        Runtime::US6::US6_0(v391_0_0, v391_0_1, v391_0_2, v391_0_3, v391_0_4) => {
                            v391.clone()
                        }
                        _ => {
                            let v403: Runtime::US8 = if length(v15.clone()) == 0_i32 {
                                Runtime::US8::US8_0(v15.clone(), v23.clone(), 1_i32, 1_i32)
                            } else {
                                Runtime::US8::US8_1(sprintf!(
                                    "parsing.eof / expected end of input / input: {:?}",
                                    v15.clone()
                                ))
                            };
                            let v412: Runtime::US6 = match &v403 {
                                Runtime::US8::US8_0(v403_0_0, v403_0_1, v403_0_2, v403_0_3) => {
                                    Runtime::US6::US6_0(
                                        string(""),
                                        v403_0_0.clone(),
                                        v403_0_1.clone(),
                                        v403_0_2.clone(),
                                        v403_0_3.clone(),
                                    )
                                }
                                Runtime::US8::US8_1(v403_1_0) => {
                                    Runtime::US6::US6_1(v403_1_0.clone())
                                }
                            };
                            match &v412 {
                                Runtime::US6::US6_0(
                                    v412_0_0,
                                    v412_0_1,
                                    v412_0_2,
                                    v412_0_3,
                                    v412_0_4,
                                ) => {
                                    let v414: string = v412_0_1.clone();
                                    Runtime::US6::US6_0(
                                        v412_0_0.clone(),
                                        getSlice(
                                            v414.clone(),
                                            Some(Runtime::method22(v414.clone(), 0_i32)),
                                            Some(length(v414)),
                                        ),
                                        v412_0_2.clone(),
                                        v412_0_3.clone(),
                                        v412_0_4.clone(),
                                    )
                                }
                                Runtime::US6::US6_1(v412_1_0) => {
                                    Runtime::US6::US6_1(v412_1_0.clone())
                                }
                            }
                        }
                    }
                }
            };
            let v639: Runtime::US9 = match &v435 {
                Runtime::US6::US6_0(v435_0_0, v435_0_1, v435_0_2, v435_0_3, v435_0_4) => {
                    let v440: i32 = v435_0_4.clone();
                    let v439: i32 = v435_0_3.clone();
                    let v438: LrcPtr<StringBuilder> = v435_0_2.clone();
                    let v437: string = v435_0_1.clone();
                    let v522: Runtime::US5 = if string("") == v437.clone() {
                        Runtime::US5::US5_1(sprintf!(
                            "parsing.p_char / unexpected end of input / s: {:?}",
                            (v438.clone(), v439, v440)
                        ))
                    } else {
                        let v444: char = getCharAt(v437.clone(), 0_i32);
                        if v444 == ' ' {
                            let v452: string =
                                getSlice(v437.clone(), Some(1_i32), Some(length(v437.clone())));
                            let v456: string = ofChar(v444);
                            let v463: i32 = length(v456.clone());
                            let v464: Array<char> = new_init(&'\u{0000}', v463);
                            let v465: LrcPtr<Runtime::Mut5> = LrcPtr::new(Runtime::Mut5 {
                                l0: MutCell::new(0_i32),
                            });
                            while Runtime::method13(v463, v465.clone()) {
                                let v467: i32 = v465.l0.get().clone();
                                let v468: char = getCharAt(v456.clone(), v467);
                                v464.get_mut()[v467 as usize] = v468;
                                {
                                    let v469: i32 = v467 + 1_i32;
                                    v465.l0.set(v469);
                                    ()
                                }
                            }
                            {
                                let v470: List<char> = ofArray(v464.clone());
                                let patternInput_2: (LrcPtr<StringBuilder>, i32, i32) =
                                    Runtime::method15(
                                        foldBack(
                                            Func2::new(
                                                move |b0: char, b1: LrcPtr<Runtime::UH0>| {
                                                    (Runtime::method14())(b0)(b1)
                                                },
                                            ),
                                            v470,
                                            LrcPtr::new(Runtime::UH0::UH0_0),
                                        ),
                                        v438.clone(),
                                        v439,
                                        v440,
                                    );
                                Runtime::US5::US5_0(
                                    v444,
                                    v452,
                                    patternInput_2.0.clone(),
                                    patternInput_2.1.clone(),
                                    patternInput_2.2.clone(),
                                )
                            }
                        } else {
                            let v492: i32 = length(v437.clone());
                            let v495: i32 = indexOf(v437.clone(), string("\n")) - 1_i32;
                            Runtime::US5::US5_1(sprintf!(
                                "{}\n{}\n",
                                sprintf!(
                                    "parsing.p_char / expected: \'{}\' / line: {} / col: {}\n{}{}",
                                    ' ',
                                    v439,
                                    v440,
                                    v438.clone(),
                                    getSlice(
                                        v437.clone(),
                                        Some(0_i32),
                                        Some(if -2_i32 == v495 { v492 } else { v495 })
                                    )
                                ),
                                append(replicate(v440 - 1_i32, string(" ")), string("^"))
                            ))
                        }
                    };
                    let v534: Runtime::US10 = match &v522 {
                        Runtime::US5::US5_0(v522_0_0, v522_0_1, v522_0_2, v522_0_3, v522_0_4) => {
                            Runtime::US10::US10_0(
                                Runtime::US7::US7_0(v522_0_0.clone()),
                                v522_0_1.clone(),
                                v522_0_2.clone(),
                                v522_0_3.clone(),
                                v522_0_4.clone(),
                            )
                        }
                        _ => Runtime::US10::US10_0(
                            Runtime::US7::US7_1,
                            v437.clone(),
                            v438.clone(),
                            v439,
                            v440,
                        ),
                    };
                    let v613: Runtime::US6 = match &v534 {
                        Runtime::US10::US10_0(v534_0_0, v534_0_1, v534_0_2, v534_0_3, v534_0_4) => {
                            let v539: i32 = v534_0_4.clone();
                            let v538: i32 = v534_0_3.clone();
                            let v537: LrcPtr<StringBuilder> = v534_0_2.clone();
                            let v536: string = v534_0_1.clone();
                            let v589: Runtime::US5 = if string("") == v536.clone() {
                                Runtime::US5::US5_1(sprintf!(
                                    "parsing.any_char / unexpected end of input / s: {:?}",
                                    (v537.clone(), v538, v539)
                                ))
                            } else {
                                let v543: char = getCharAt(v536.clone(), 0_i32);
                                let v550: string =
                                    getSlice(v536.clone(), Some(1_i32), Some(length(v536)));
                                let v554: string = ofChar(v543);
                                let v561: i32 = length(v554.clone());
                                let v562: Array<char> = new_init(&'\u{0000}', v561);
                                let v563: LrcPtr<Runtime::Mut5> = LrcPtr::new(Runtime::Mut5 {
                                    l0: MutCell::new(0_i32),
                                });
                                while Runtime::method13(v561, v563.clone()) {
                                    let v565: i32 = v563.l0.get().clone();
                                    let v566: char = getCharAt(v554.clone(), v565);
                                    v562.get_mut()[v565 as usize] = v566;
                                    {
                                        let v567: i32 = v565 + 1_i32;
                                        v563.l0.set(v567);
                                        ()
                                    }
                                }
                                {
                                    let v568: List<char> = ofArray(v562.clone());
                                    let patternInput_3: (LrcPtr<StringBuilder>, i32, i32) =
                                        Runtime::method15(
                                            foldBack(
                                                Func2::new(
                                                    move |b0: char, b1: LrcPtr<Runtime::UH0>| {
                                                        (Runtime::method14())(b0)(b1)
                                                    },
                                                ),
                                                v568,
                                                LrcPtr::new(Runtime::UH0::UH0_0),
                                            ),
                                            v537,
                                            v538,
                                            v539,
                                        );
                                    Runtime::US5::US5_0(
                                        v543,
                                        v550,
                                        patternInput_3.0.clone(),
                                        patternInput_3.1.clone(),
                                        patternInput_3.2.clone(),
                                    )
                                }
                            };
                            match &v589 {
                                Runtime::US5::US5_0(
                                    v589_0_0,
                                    v589_0_1,
                                    v589_0_2,
                                    v589_0_3,
                                    v589_0_4,
                                ) => Runtime::method23(
                                    ofChar(v589_0_0.clone()),
                                    v589_0_1.clone(),
                                    v589_0_2.clone(),
                                    v589_0_3.clone(),
                                    v589_0_4.clone(),
                                ),
                                Runtime::US5::US5_1(v589_1_0) => {
                                    Runtime::US6::US6_1(v589_1_0.clone())
                                }
                            }
                        }
                        Runtime::US10::US10_1(v534_1_0) => Runtime::US6::US6_1(v534_1_0.clone()),
                    };
                    let v625: Runtime::US11 = match &v613 {
                        Runtime::US6::US6_0(v613_0_0, v613_0_1, v613_0_2, v613_0_3, v613_0_4) => {
                            Runtime::US11::US11_0(
                                Runtime::US3::US3_0(v613_0_0.clone()),
                                v613_0_1.clone(),
                                v613_0_2.clone(),
                                v613_0_3.clone(),
                                v613_0_4.clone(),
                            )
                        }
                        _ => Runtime::US11::US11_0(Runtime::US3::US3_1, v437, v438, v439, v440),
                    };
                    match &v625 {
                        Runtime::US11::US11_0(v625_0_0, v625_0_1, v625_0_2, v625_0_3, v625_0_4) => {
                            Runtime::US9::US9_0(
                                v435_0_0.clone(),
                                v625_0_0.clone(),
                                v625_0_1.clone(),
                                v625_0_2.clone(),
                                v625_0_3.clone(),
                                v625_0_4.clone(),
                            )
                        }
                        Runtime::US11::US11_1(v625_1_0) => Runtime::US9::US9_1(v625_1_0.clone()),
                    }
                }
                Runtime::US6::US6_1(v435_1_0) => Runtime::US9::US9_1(v435_1_0.clone()),
            };
            match &v639 {
                Runtime::US9::US9_0(v639_0_0, v639_0_1, v639_0_2, v639_0_3, v639_0_4, v639_0_5) => {
                    Runtime::US4::US4_0(v639_0_0.clone(), v639_0_1.clone())
                }
                Runtime::US9::US9_1(v639_1_0) => Runtime::US4::US4_1(v639_1_0.clone()),
            }
        }
    }
    pub fn closure14(unitVar: (), unitVar_1: ()) -> string {
        string("runtime.execute_with_options_async")
    }
    pub fn closure15(
        v0: string,
        v1: Option<CancellationToken>,
        v2_1: Array<(string, string)>,
        v3_1: Option<Func1<(i32, string, bool), Arc<Async<()>>>>,
        v4: Option<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
        v5: bool,
        v6: Option<string>,
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
        (v0, v1, v2_1, v3_1, v4, v5, v6)
    }
    pub fn method26(v0: LrcPtr<Runtime::Mut4>, v1: string) {
        let v4: string = sprintf!("{}", v1);
        let v12_1: string = append(v0.l0.get().clone(), v4);
        v0.l0.set(v12_1);
        ()
    }
    pub fn method28(v0: LrcPtr<Runtime::Mut4>, v1: Option<CancellationToken>) {
        Runtime::method26(v0, sprintf!("{:?}", v1));
    }
    pub fn method29(v0: LrcPtr<Runtime::Mut4>, v1: Array<(string, string)>) {
        Runtime::method26(v0, sprintf!("{:?}", v1));
    }
    pub fn method30(
        v0: LrcPtr<Runtime::Mut4>,
        v1: Option<Func1<(i32, string, bool), Arc<Async<()>>>>,
    ) {
        Runtime::method26(v0, sprintf!("{:?}", v1));
    }
    pub fn method31(
        v0: LrcPtr<Runtime::Mut4>,
        v1: Option<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
    ) {
        Runtime::method26(v0, sprintf!("{:?}", v1));
    }
    pub fn method32(v0: LrcPtr<Runtime::Mut4>, v1: bool) {
        let v7: string = sprintf!("{}", if v1 { string("true") } else { string("false") });
        let v15: string = append(v0.l0.get().clone(), v7);
        v0.l0.set(v15);
        ()
    }
    pub fn method33(v0: LrcPtr<Runtime::Mut4>, v1: Option<string>) {
        Runtime::method26(v0, sprintf!("{:?}", v1));
    }
    pub fn method27(
        v0: LrcPtr<Runtime::Mut4>,
        v1: string,
        v2_1: Option<CancellationToken>,
        v3_1: Array<(string, string)>,
        v4: Option<Func1<(i32, string, bool), Arc<Async<()>>>>,
        v5: Option<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
        v6: bool,
        v7: Option<string>,
    ) {
        Runtime::method26(v0.clone(), string("{ "));
        Runtime::method9(v0.clone());
        Runtime::method26(v0.clone(), string("command"));
        Runtime::method26(v0.clone(), string(" = "));
        Runtime::method26(v0.clone(), v1);
        Runtime::method26(v0.clone(), string("; "));
        Runtime::method26(v0.clone(), string("cancellation_token"));
        Runtime::method26(v0.clone(), string(" = "));
        Runtime::method28(v0.clone(), v2_1);
        Runtime::method26(v0.clone(), string("; "));
        Runtime::method26(v0.clone(), string("environment_variables"));
        Runtime::method26(v0.clone(), string(" = "));
        Runtime::method29(v0.clone(), v3_1);
        Runtime::method26(v0.clone(), string("; "));
        Runtime::method26(v0.clone(), string("on_line"));
        Runtime::method26(v0.clone(), string(" = "));
        Runtime::method30(v0.clone(), v4);
        Runtime::method26(v0.clone(), string("; "));
        Runtime::method26(v0.clone(), string("stdin"));
        Runtime::method26(v0.clone(), string(" = "));
        Runtime::method31(v0.clone(), v5);
        Runtime::method26(v0.clone(), string("; "));
        Runtime::method26(v0.clone(), string("trace"));
        Runtime::method26(v0.clone(), string(" = "));
        Runtime::method32(v0.clone(), v6);
        Runtime::method26(v0.clone(), string("; "));
        Runtime::method26(v0.clone(), string("working_directory"));
        Runtime::method26(v0.clone(), string(" = "));
        Runtime::method33(v0.clone(), v7);
        Runtime::method26(v0, string(" }"))
    }
    pub fn method25(
        v0: LrcPtr<Runtime::Mut4>,
        v1: string,
        v2_1: Option<CancellationToken>,
        v3_1: Array<(string, string)>,
        v4: Option<Func1<(i32, string, bool), Arc<Async<()>>>>,
        v5: Option<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
        v6: bool,
        v7: Option<string>,
    ) {
        Runtime::method26(v0.clone(), string("{ "));
        Runtime::method9(v0.clone());
        Runtime::method26(v0.clone(), string("options"));
        Runtime::method26(v0.clone(), string(" = "));
        Runtime::method27(v0.clone(), v1, v2_1, v3_1, v4, v5, v6, v7);
        Runtime::method26(v0, string(" }"))
    }
    pub fn closure16(
        v0: Runtime::US0,
        v1: Func0<string>,
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
            let _v35: MutCell<Option<string>> = MutCell::new(None::<string>);
            {
                let x: string = Runtime::method6();
                _v35.set(Some(x))
            }
            {
                let v772: string = match &_v35.get().clone() {
                    None => panic!("{}", string("base.run_target / _v35=None"),),
                    Some(_v35_0_0) => _v35_0_0.clone(),
                };
                let v931: Runtime::US3 = if if let Runtime::US0::US0_0 = &v0 {
                    true
                } else {
                    false
                } {
                    Runtime::US3::US3_0(string("Verbose"))
                } else {
                    Runtime::US3::US3_1
                };
                let v980: Runtime::US3 = match &v931 {
                    Runtime::US3::US3_0(v931_0_0) => Runtime::US3::US3_0(match &v931 {
                        Runtime::US3::US3_0(x) => x.clone(),
                        _ => unreachable!(),
                    }),
                    _ => {
                        let v940: Runtime::US3 = if if let Runtime::US0::US0_1 = &v0 {
                            true
                        } else {
                            false
                        } {
                            Runtime::US3::US3_0(string("Debug"))
                        } else {
                            Runtime::US3::US3_1
                        };
                        match &v940 {
                            Runtime::US3::US3_0(v940_0_0) => Runtime::US3::US3_0(match &v940 {
                                Runtime::US3::US3_0(x) => x.clone(),
                                _ => unreachable!(),
                            }),
                            _ => {
                                let v949: Runtime::US3 = if if let Runtime::US0::US0_2 = &v0 {
                                    true
                                } else {
                                    false
                                } {
                                    Runtime::US3::US3_0(string("Info"))
                                } else {
                                    Runtime::US3::US3_1
                                };
                                match &v949 {
                                    Runtime::US3::US3_0(v949_0_0) => {
                                        Runtime::US3::US3_0(match &v949 {
                                            Runtime::US3::US3_0(x) => x.clone(),
                                            _ => unreachable!(),
                                        })
                                    }
                                    _ => {
                                        let v958: Runtime::US3 = if if let Runtime::US0::US0_3 = &v0
                                        {
                                            true
                                        } else {
                                            false
                                        } {
                                            Runtime::US3::US3_0(string("Warning"))
                                        } else {
                                            Runtime::US3::US3_1
                                        };
                                        match &v958 {
                                            Runtime::US3::US3_0(v958_0_0) => {
                                                Runtime::US3::US3_0(match &v958 {
                                                    Runtime::US3::US3_0(x) => x.clone(),
                                                    _ => unreachable!(),
                                                })
                                            }
                                            _ => {
                                                let v967: Runtime::US3 =
                                                    if if let Runtime::US0::US0_4 = &v0 {
                                                        true
                                                    } else {
                                                        false
                                                    } {
                                                        Runtime::US3::US3_0(string("Critical"))
                                                    } else {
                                                        Runtime::US3::US3_1
                                                    };
                                                match &v967 {
                                                    Runtime::US3::US3_0(v967_0_0) => {
                                                        Runtime::US3::US3_0(match &v967 {
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
                let v997: string = padLeft(
                    toLower(match &v980 {
                        Runtime::US3::US3_0(v980_0_0) => match &v980 {
                            Runtime::US3::US3_0(x) => x.clone(),
                            _ => unreachable!(),
                        },
                        _ => panic!("{}", string("Option does not have a value."),),
                    }),
                    7_i32,
                    ' ',
                );
                let _v1029: MutCell<Option<string>> = MutCell::new(None::<string>);
                let v1092: &str = match &v0 {
                    Runtime::US0::US0_1 => inline_colorization::color_bright_blue,
                    Runtime::US0::US0_2 => inline_colorization::color_bright_green,
                    Runtime::US0::US0_0 => inline_colorization::color_bright_black,
                    Runtime::US0::US0_3 => inline_colorization::color_yellow,
                    _ => inline_colorization::color_bright_red,
                };
                let v1094: &str = &*v997;
                let v1096: &str = inline_colorization::color_reset;
                let v1098: string = string("format!(\"{v1092}{v1094}{v1096}\")");
                let v1099: std::string::String = format!("{v1092}{v1094}{v1096}");
                {
                    let x_2: string = fable_library_rust::String_::fromString(v1099);
                    _v1029.set(Some(x_2))
                }
                {
                    let v1141: string = match &_v1029.get().clone() {
                        None => panic!("{}", string("base.run_target / _v1029=None"),),
                        Some(_v1029_0_0) => _v1029_0_0.clone(),
                    };
                    let v1160: i64 = (patternInput.0.clone()).l0.get().clone();
                    let patternInput_1 = v2_1();
                    let v1169: LrcPtr<Runtime::Mut4> = LrcPtr::new(Runtime::Mut4 {
                        l0: MutCell::new(string("")),
                    });
                    Runtime::method25(
                        v1169.clone(),
                        patternInput_1.0.clone(),
                        patternInput_1.1.clone(),
                        patternInput_1.2.clone(),
                        patternInput_1.3.clone(),
                        patternInput_1.4.clone(),
                        patternInput_1.5.clone(),
                        patternInput_1.6.clone(),
                    );
                    {
                        let v1170: string = v1169.l0.get().clone();
                        trimEndChars(
                            trimStartChars(
                                sprintf!("{} {} #{} {} / {}", v772, v1141, v1160, v1(), v1170),
                                toArray(empty::<char>()),
                            ),
                            toArray(ofArray(new_array(&[' ', '/']))),
                        )
                    }
                }
            }
        }
    }
    pub fn method24(
        v0: Runtime::US0,
        v1: Func0<string>,
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
            v0.clone(),
            Func0::new({
                let v0 = v0.clone();
                let v1 = v1.clone();
                let v2_1 = v2_1.clone();
                move || Runtime::closure16(v0.clone(), v1.clone(), v2_1.clone(), ())
            }),
        );
    }
    pub fn closure18(v0: string, unitVar: ()) -> string {
        v0
    }
    pub fn closure17(
        v0: string,
        v1: Option<CancellationToken>,
        v2_1: Array<(string, string)>,
        v3_1: Option<Func1<(i32, string, bool), Arc<Async<()>>>>,
        v4: Option<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
        v5: bool,
        v6: Option<string>,
        v7: (),
        v8: LrcPtr<ConcurrentStack_1<string>>,
        v9_1: (),
    ) {
        let _v12: MutCell<Option<Arc<Async<()>>>> = MutCell::new(None::<Arc<Async<()>>>);
        {
            let x: Arc<Async<()>> = defaultOf();
            _v12.set(Some(x))
        }
        {
            let v126: Arc<Async<()>> = match &_v12.get().clone() {
                None => panic!("{}", string("base.run_target / _v12=None"),),
                Some(_v12_0_0) => _v12_0_0.clone(),
            };
            let _v143: MutCell<Option<()>> = MutCell::new(None::<()>);
            defaultOf::<()>();
            _v143.set(Some(()));
            match &_v143.get().clone() {
                None => panic!("{}", string("base.run_target / _v143=None"),),
                Some(_v143_0_0) => _v143_0_0.clone(),
            }
            ()
        }
    }
    pub fn closure19(
        v0: string,
        v1: Option<CancellationToken>,
        v2_1: Array<(string, string)>,
        v3_1: Option<Func1<(i32, string, bool), Arc<Async<()>>>>,
        v4: Option<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
        v5: bool,
        v6: Option<string>,
        v7: (),
        v8: LrcPtr<ConcurrentStack_1<string>>,
        v9_1: (),
    ) {
        let _v12: MutCell<Option<Arc<Async<()>>>> = MutCell::new(None::<Arc<Async<()>>>);
        {
            let x: Arc<Async<()>> = defaultOf();
            _v12.set(Some(x))
        }
        {
            let v127: Arc<Async<()>> = match &_v12.get().clone() {
                None => panic!("{}", string("base.run_target / _v12=None"),),
                Some(_v12_0_0) => _v12_0_0.clone(),
            };
            let _v144: MutCell<Option<()>> = MutCell::new(None::<()>);
            defaultOf::<()>();
            _v144.set(Some(()));
            match &_v144.get().clone() {
                None => panic!("{}", string("base.run_target / _v144=None"),),
                Some(_v144_0_0) => _v144_0_0.clone(),
            }
            ()
        }
    }
    pub fn closure20(v0: (), unitVar: ()) {
        let _v3: MutCell<Option<bool>> = MutCell::new(None::<bool>);
        {
            let x: bool = unbox::<bool>(&defaultOf());
            _v3.set(Some(x))
        }
        if match &_v3.get().clone() {
            None => panic!("{}", string("base.run_target / _v3=None"),),
            Some(_v3_0_0) => _v3_0_0.clone(),
        } == false
        {
            let _v68: MutCell<Option<()>> = MutCell::new(None::<()>);
            defaultOf::<()>();
            _v68.set(Some(()));
            match &_v68.get().clone() {
                None => panic!("{}", string("base.run_target / _v68=None"),),
                Some(_v68_0_0) => _v68_0_0.clone(),
            }
            ()
        }
    }
    pub fn closure21(unitVar: (), unitVar_1: ()) -> string {
        string("runtime.execute_with_options_async / WaitForExitAsync")
    }
    pub fn closure22(
        v0: LrcPtr<TaskCanceledException>,
        unitVar: (),
    ) -> LrcPtr<TaskCanceledException> {
        v0
    }
    pub fn method36(v0: LrcPtr<Runtime::Mut4>, v1: LrcPtr<TaskCanceledException>) {
        Runtime::method26(v0, sprintf!("{:?}", v1));
    }
    pub fn method35(v0: LrcPtr<Runtime::Mut4>, v1: LrcPtr<TaskCanceledException>) {
        Runtime::method26(v0.clone(), string("{ "));
        Runtime::method9(v0.clone());
        Runtime::method26(v0.clone(), string("ex"));
        Runtime::method26(v0.clone(), string(" = "));
        Runtime::method36(v0.clone(), v1);
        Runtime::method26(v0, string(" }"))
    }
    pub fn closure23(
        v0: Runtime::US0,
        v1: Func0<string>,
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
            let _v35: MutCell<Option<string>> = MutCell::new(None::<string>);
            {
                let x: string = Runtime::method6();
                _v35.set(Some(x))
            }
            {
                let v772: string = match &_v35.get().clone() {
                    None => panic!("{}", string("base.run_target / _v35=None"),),
                    Some(_v35_0_0) => _v35_0_0.clone(),
                };
                let v931: Runtime::US3 = if if let Runtime::US0::US0_0 = &v0 {
                    true
                } else {
                    false
                } {
                    Runtime::US3::US3_0(string("Verbose"))
                } else {
                    Runtime::US3::US3_1
                };
                let v980: Runtime::US3 = match &v931 {
                    Runtime::US3::US3_0(v931_0_0) => Runtime::US3::US3_0(match &v931 {
                        Runtime::US3::US3_0(x) => x.clone(),
                        _ => unreachable!(),
                    }),
                    _ => {
                        let v940: Runtime::US3 = if if let Runtime::US0::US0_1 = &v0 {
                            true
                        } else {
                            false
                        } {
                            Runtime::US3::US3_0(string("Debug"))
                        } else {
                            Runtime::US3::US3_1
                        };
                        match &v940 {
                            Runtime::US3::US3_0(v940_0_0) => Runtime::US3::US3_0(match &v940 {
                                Runtime::US3::US3_0(x) => x.clone(),
                                _ => unreachable!(),
                            }),
                            _ => {
                                let v949: Runtime::US3 = if if let Runtime::US0::US0_2 = &v0 {
                                    true
                                } else {
                                    false
                                } {
                                    Runtime::US3::US3_0(string("Info"))
                                } else {
                                    Runtime::US3::US3_1
                                };
                                match &v949 {
                                    Runtime::US3::US3_0(v949_0_0) => {
                                        Runtime::US3::US3_0(match &v949 {
                                            Runtime::US3::US3_0(x) => x.clone(),
                                            _ => unreachable!(),
                                        })
                                    }
                                    _ => {
                                        let v958: Runtime::US3 = if if let Runtime::US0::US0_3 = &v0
                                        {
                                            true
                                        } else {
                                            false
                                        } {
                                            Runtime::US3::US3_0(string("Warning"))
                                        } else {
                                            Runtime::US3::US3_1
                                        };
                                        match &v958 {
                                            Runtime::US3::US3_0(v958_0_0) => {
                                                Runtime::US3::US3_0(match &v958 {
                                                    Runtime::US3::US3_0(x) => x.clone(),
                                                    _ => unreachable!(),
                                                })
                                            }
                                            _ => {
                                                let v967: Runtime::US3 =
                                                    if if let Runtime::US0::US0_4 = &v0 {
                                                        true
                                                    } else {
                                                        false
                                                    } {
                                                        Runtime::US3::US3_0(string("Critical"))
                                                    } else {
                                                        Runtime::US3::US3_1
                                                    };
                                                match &v967 {
                                                    Runtime::US3::US3_0(v967_0_0) => {
                                                        Runtime::US3::US3_0(match &v967 {
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
                let v997: string = padLeft(
                    toLower(match &v980 {
                        Runtime::US3::US3_0(v980_0_0) => match &v980 {
                            Runtime::US3::US3_0(x) => x.clone(),
                            _ => unreachable!(),
                        },
                        _ => panic!("{}", string("Option does not have a value."),),
                    }),
                    7_i32,
                    ' ',
                );
                let _v1029: MutCell<Option<string>> = MutCell::new(None::<string>);
                let v1092: &str = match &v0 {
                    Runtime::US0::US0_1 => inline_colorization::color_bright_blue,
                    Runtime::US0::US0_2 => inline_colorization::color_bright_green,
                    Runtime::US0::US0_0 => inline_colorization::color_bright_black,
                    Runtime::US0::US0_3 => inline_colorization::color_yellow,
                    _ => inline_colorization::color_bright_red,
                };
                let v1094: &str = &*v997;
                let v1096: &str = inline_colorization::color_reset;
                let v1098: string = string("format!(\"{v1092}{v1094}{v1096}\")");
                let v1099: std::string::String = format!("{v1092}{v1094}{v1096}");
                {
                    let x_2: string = fable_library_rust::String_::fromString(v1099);
                    _v1029.set(Some(x_2))
                }
                {
                    let v1141: string = match &_v1029.get().clone() {
                        None => panic!("{}", string("base.run_target / _v1029=None"),),
                        Some(_v1029_0_0) => _v1029_0_0.clone(),
                    };
                    let v1160: i64 = (patternInput.0.clone()).l0.get().clone();
                    let v1163: LrcPtr<Runtime::Mut4> = LrcPtr::new(Runtime::Mut4 {
                        l0: MutCell::new(string("")),
                    });
                    Runtime::method35(v1163.clone(), v2_1());
                    {
                        let v1164: string = v1163.l0.get().clone();
                        trimEndChars(
                            trimStartChars(
                                sprintf!("{} {} #{} {} / {}", v772, v1141, v1160, v1(), v1164),
                                toArray(empty::<char>()),
                            ),
                            toArray(ofArray(new_array(&[' ', '/']))),
                        )
                    }
                }
            }
        }
    }
    pub fn method34(
        v0: Runtime::US0,
        v1: Func0<string>,
        v2_1: Func0<LrcPtr<TaskCanceledException>>,
    ) {
        Runtime::method10(
            v0.clone(),
            Func0::new({
                let v0 = v0.clone();
                let v1 = v1.clone();
                let v2_1 = v2_1.clone();
                move || Runtime::closure23(v0.clone(), v1.clone(), v2_1.clone(), ())
            }),
        );
    }
    pub fn closure24(unitVar: (), unitVar_1: ()) -> string {
        string("runtime.execute_with_options_async")
    }
    pub fn closure25(v0: i32, v1: string, unitVar: ()) -> (i32, i32) {
        (v0, length(v1))
    }
    pub fn method39(v0: LrcPtr<Runtime::Mut4>, v1: i32) {
        let v4: string = sprintf!("{}", v1);
        let v12_1: string = append(v0.l0.get().clone(), v4);
        v0.l0.set(v12_1);
        ()
    }
    pub fn method38(v0: LrcPtr<Runtime::Mut4>, v1: i32, v2_1: i32) {
        Runtime::method26(v0.clone(), string("{ "));
        Runtime::method9(v0.clone());
        Runtime::method26(v0.clone(), string("exit_code"));
        Runtime::method26(v0.clone(), string(" = "));
        Runtime::method39(v0.clone(), v1);
        Runtime::method26(v0.clone(), string("; "));
        Runtime::method26(v0.clone(), string("output_length"));
        Runtime::method26(v0.clone(), string(" = "));
        Runtime::method39(v0.clone(), v2_1);
        Runtime::method26(v0, string(" }"))
    }
    pub fn closure26(
        v0: Runtime::US0,
        v1: Func0<string>,
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
            let _v35: MutCell<Option<string>> = MutCell::new(None::<string>);
            {
                let x: string = Runtime::method6();
                _v35.set(Some(x))
            }
            {
                let v772: string = match &_v35.get().clone() {
                    None => panic!("{}", string("base.run_target / _v35=None"),),
                    Some(_v35_0_0) => _v35_0_0.clone(),
                };
                let v931: Runtime::US3 = if if let Runtime::US0::US0_0 = &v0 {
                    true
                } else {
                    false
                } {
                    Runtime::US3::US3_0(string("Verbose"))
                } else {
                    Runtime::US3::US3_1
                };
                let v980: Runtime::US3 = match &v931 {
                    Runtime::US3::US3_0(v931_0_0) => Runtime::US3::US3_0(match &v931 {
                        Runtime::US3::US3_0(x) => x.clone(),
                        _ => unreachable!(),
                    }),
                    _ => {
                        let v940: Runtime::US3 = if if let Runtime::US0::US0_1 = &v0 {
                            true
                        } else {
                            false
                        } {
                            Runtime::US3::US3_0(string("Debug"))
                        } else {
                            Runtime::US3::US3_1
                        };
                        match &v940 {
                            Runtime::US3::US3_0(v940_0_0) => Runtime::US3::US3_0(match &v940 {
                                Runtime::US3::US3_0(x) => x.clone(),
                                _ => unreachable!(),
                            }),
                            _ => {
                                let v949: Runtime::US3 = if if let Runtime::US0::US0_2 = &v0 {
                                    true
                                } else {
                                    false
                                } {
                                    Runtime::US3::US3_0(string("Info"))
                                } else {
                                    Runtime::US3::US3_1
                                };
                                match &v949 {
                                    Runtime::US3::US3_0(v949_0_0) => {
                                        Runtime::US3::US3_0(match &v949 {
                                            Runtime::US3::US3_0(x) => x.clone(),
                                            _ => unreachable!(),
                                        })
                                    }
                                    _ => {
                                        let v958: Runtime::US3 = if if let Runtime::US0::US0_3 = &v0
                                        {
                                            true
                                        } else {
                                            false
                                        } {
                                            Runtime::US3::US3_0(string("Warning"))
                                        } else {
                                            Runtime::US3::US3_1
                                        };
                                        match &v958 {
                                            Runtime::US3::US3_0(v958_0_0) => {
                                                Runtime::US3::US3_0(match &v958 {
                                                    Runtime::US3::US3_0(x) => x.clone(),
                                                    _ => unreachable!(),
                                                })
                                            }
                                            _ => {
                                                let v967: Runtime::US3 =
                                                    if if let Runtime::US0::US0_4 = &v0 {
                                                        true
                                                    } else {
                                                        false
                                                    } {
                                                        Runtime::US3::US3_0(string("Critical"))
                                                    } else {
                                                        Runtime::US3::US3_1
                                                    };
                                                match &v967 {
                                                    Runtime::US3::US3_0(v967_0_0) => {
                                                        Runtime::US3::US3_0(match &v967 {
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
                let v997: string = padLeft(
                    toLower(match &v980 {
                        Runtime::US3::US3_0(v980_0_0) => match &v980 {
                            Runtime::US3::US3_0(x) => x.clone(),
                            _ => unreachable!(),
                        },
                        _ => panic!("{}", string("Option does not have a value."),),
                    }),
                    7_i32,
                    ' ',
                );
                let _v1029: MutCell<Option<string>> = MutCell::new(None::<string>);
                let v1092: &str = match &v0 {
                    Runtime::US0::US0_1 => inline_colorization::color_bright_blue,
                    Runtime::US0::US0_2 => inline_colorization::color_bright_green,
                    Runtime::US0::US0_0 => inline_colorization::color_bright_black,
                    Runtime::US0::US0_3 => inline_colorization::color_yellow,
                    _ => inline_colorization::color_bright_red,
                };
                let v1094: &str = &*v997;
                let v1096: &str = inline_colorization::color_reset;
                let v1098: string = string("format!(\"{v1092}{v1094}{v1096}\")");
                let v1099: std::string::String = format!("{v1092}{v1094}{v1096}");
                {
                    let x_2: string = fable_library_rust::String_::fromString(v1099);
                    _v1029.set(Some(x_2))
                }
                {
                    let v1141: string = match &_v1029.get().clone() {
                        None => panic!("{}", string("base.run_target / _v1029=None"),),
                        Some(_v1029_0_0) => _v1029_0_0.clone(),
                    };
                    let v1160: i64 = (patternInput.0.clone()).l0.get().clone();
                    let patternInput_1: (i32, i32) = v2_1();
                    let v1164: LrcPtr<Runtime::Mut4> = LrcPtr::new(Runtime::Mut4 {
                        l0: MutCell::new(string("")),
                    });
                    Runtime::method38(
                        v1164.clone(),
                        patternInput_1.0.clone(),
                        patternInput_1.1.clone(),
                    );
                    {
                        let v1165: string = v1164.l0.get().clone();
                        trimEndChars(
                            trimStartChars(
                                sprintf!("{} {} #{} {} / {}", v772, v1141, v1160, v1(), v1165),
                                toArray(empty::<char>()),
                            ),
                            toArray(ofArray(new_array(&[' ', '/']))),
                        )
                    }
                }
            }
        }
    }
    pub fn method37(v0: Runtime::US0, v1: Func0<string>, v2_1: Func0<(i32, i32)>) {
        Runtime::method10(
            v0.clone(),
            Func0::new({
                let v0 = v0.clone();
                let v1 = v1.clone();
                let v2_1 = v2_1.clone();
                move || Runtime::closure26(v0.clone(), v1.clone(), v2_1.clone(), ())
            }),
        );
    }
    pub fn method11(
        v0: string,
        v1: Option<CancellationToken>,
        v2_1: Array<(string, string)>,
        v3_1: Option<Func1<(i32, string, bool), Arc<Async<()>>>>,
        v4: Option<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
        v5: bool,
        v6: Option<string>,
    ) -> Arc<Async<(i32, string)>> {
        let _v9: MutCell<Option<Arc<Async<(i32, string)>>>> =
            MutCell::new(None::<Arc<Async<(i32, string)>>>);
        {
            let x: Arc<Async<(i32, string)>> = defaultOf();
            _v9.set(Some(x))
        }
        match &_v9.get().clone() {
            None => panic!("{}", string("base.run_target / _v9=None"),),
            Some(_v9_0_0) => _v9_0_0.clone(),
        }
    }
    pub fn closure9(unitVar: (), v0: string) -> Arc<Async<(i32, string)>> {
        Runtime::method11(
            v0,
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
        v0: Func1<LrcPtr<Runtime::Heap0>, LrcPtr<Runtime::Heap0>>,
    ) -> (
        string,
        Option<CancellationToken>,
        Array<(string, string)>,
        Option<Func1<(i32, string, bool), Arc<Async<()>>>>,
        Option<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
        bool,
        Option<string>,
    ) {
        let v8: LrcPtr<Runtime::Heap0> = v0(LrcPtr::new(Runtime::Heap0 {
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
    pub fn method42(v0: char, v1: i64) -> bool {
        let v0: MutCell<char> = MutCell::new(v0);
        let v1: MutCell<i64> = MutCell::new(v1);
        '_method42: loop {
            break '_method42 (if v1.get().clone() >= 4_i64 {
                false
            } else {
                let v19: Runtime::US7 = if v1.get().clone() == 0_i64 {
                    Runtime::US7::US7_0('\\')
                } else {
                    let v5: i64 = v1.get().clone() - 1_i64;
                    if v5 == 0_i64 {
                        Runtime::US7::US7_0('`')
                    } else {
                        let v8: i64 = v5 - 1_i64;
                        if v8 == 0_i64 {
                            Runtime::US7::US7_0('\"')
                        } else {
                            let v11_1: i64 = v8 - 1_i64;
                            if v11_1 == 0_i64 {
                                Runtime::US7::US7_0(' ')
                            } else {
                                let v14: i64 = v11_1 - 1_i64;
                                Runtime::US7::US7_1
                            }
                        }
                    }
                };
                if v0.get().clone()
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
                    let v0_temp: char = v0.get().clone();
                    let v1_temp: i64 = v1.get().clone() + 1_i64;
                    v0.set(v0_temp);
                    v1.set(v1_temp);
                    continue '_method42;
                }
            });
        }
    }
    pub fn method43(
        v0: string,
        v1: string,
        v2_1: LrcPtr<StringBuilder>,
        v3_1: i32,
        v4: i32,
    ) -> Runtime::US6 {
        let v0: MutCell<string> = MutCell::new(v0.clone());
        let v1: MutCell<string> = MutCell::new(v1.clone());
        let v2_1: MutCell<LrcPtr<StringBuilder>> = MutCell::new(v2_1.clone());
        let v3_1: MutCell<i32> = MutCell::new(v3_1);
        let v4: MutCell<i32> = MutCell::new(v4);
        '_method43: loop {
            break '_method43 ({
                let v154: Runtime::US5 = if string("") == v1.get().clone() {
                    Runtime::US5::US5_1(sprintf!(
                        "parsing.none_of / unexpected end of input / chars: {:?} / s: {:?}",
                        toArray(ofArray(new_array(&['\\', '`', '\"', ' ']))),
                        (v2_1.get().clone(), v3_1.get().clone(), v4.get().clone())
                    ))
                } else {
                    let v55: char = getCharAt(v1.get().clone(), 0_i32);
                    let v62: string = getSlice(
                        v1.get().clone(),
                        Some(1_i32),
                        Some(length(v1.get().clone())),
                    );
                    if Runtime::method42(v55, 0_i64) == false {
                        let v69: string = ofChar(v55);
                        let v76: i32 = length(v69.clone());
                        let v77: Array<char> = new_init(&'\u{0000}', v76);
                        let v78: LrcPtr<Runtime::Mut5> = LrcPtr::new(Runtime::Mut5 {
                            l0: MutCell::new(0_i32),
                        });
                        while Runtime::method13(v76, v78.clone()) {
                            let v80: i32 = v78.l0.get().clone();
                            let v81: char = getCharAt(v69.clone(), v80);
                            v77.get_mut()[v80 as usize] = v81;
                            {
                                let v82: i32 = v80 + 1_i32;
                                v78.l0.set(v82);
                                ()
                            }
                        }
                        {
                            let v83: List<char> = ofArray(v77.clone());
                            let patternInput: (LrcPtr<StringBuilder>, i32, i32) = Runtime::method15(
                                foldBack(
                                    Func2::new(move |b0: char, b1: LrcPtr<Runtime::UH0>| {
                                        (Runtime::method14())(b0)(b1)
                                    }),
                                    v83,
                                    LrcPtr::new(Runtime::UH0::UH0_0),
                                ),
                                v2_1.get().clone(),
                                v3_1.get().clone(),
                                v4.get().clone(),
                            );
                            Runtime::US5::US5_0(
                                v55,
                                v62,
                                patternInput.0.clone(),
                                patternInput.1.clone(),
                                patternInput.2.clone(),
                            )
                        }
                    } else {
                        Runtime::US5::US5_1(sprintf!(
                            "parsing.none_of / unexpected char: \'{}\' / chars: {:?} / s: {:?}",
                            v55,
                            toArray(ofArray(new_array(&['\\', '`', '\"', ' ']))),
                            (v2_1.get().clone(), v3_1.get().clone(), v4.get().clone())
                        ))
                    }
                };
                match &v154 {
                    Runtime::US5::US5_0(v154_0_0, v154_0_1, v154_0_2, v154_0_3, v154_0_4) => {
                        let v0_temp: string = append(v0.get().clone(), ofChar(v154_0_0.clone()));
                        let v1_temp: string = v154_0_1.clone();
                        let v2_1_temp: LrcPtr<StringBuilder> = v154_0_2.clone();
                        let v3_1_temp: i32 = v154_0_3.clone();
                        let v4_temp: i32 = v154_0_4.clone();
                        v0.set(v0_temp);
                        v1.set(v1_temp);
                        v2_1.set(v2_1_temp);
                        v3_1.set(v3_1_temp);
                        v4.set(v4_temp);
                        continue '_method43;
                    }
                    _ => Runtime::US6::US6_0(
                        v0.get().clone(),
                        v1.get().clone(),
                        v2_1.get().clone(),
                        v3_1.get().clone(),
                        v4.get().clone(),
                    ),
                }
            });
        }
    }
    pub fn method45(v0: char, v1: i64) -> bool {
        let v0: MutCell<char> = MutCell::new(v0);
        let v1: MutCell<i64> = MutCell::new(v1);
        '_method45: loop {
            break '_method45 (if v1.get().clone() >= 3_i64 {
                false
            } else {
                let v15: Runtime::US7 = if v1.get().clone() == 0_i64 {
                    Runtime::US7::US7_0('\\')
                } else {
                    let v5: i64 = v1.get().clone() - 1_i64;
                    if v5 == 0_i64 {
                        Runtime::US7::US7_0('`')
                    } else {
                        let v8: i64 = v5 - 1_i64;
                        if v8 == 0_i64 {
                            Runtime::US7::US7_0('\"')
                        } else {
                            let v11_1: i64 = v8 - 1_i64;
                            Runtime::US7::US7_1
                        }
                    }
                };
                if v0.get().clone()
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
                    let v0_temp: char = v0.get().clone();
                    let v1_temp: i64 = v1.get().clone() + 1_i64;
                    v0.set(v0_temp);
                    v1.set(v1_temp);
                    continue '_method45;
                }
            });
        }
    }
    pub fn closure30(unitVar: (), _arg: (string, LrcPtr<StringBuilder>, i32, i32)) -> Runtime::US6 {
        let v3_1: i32 = _arg.3.clone();
        let v2_1: i32 = _arg.2.clone();
        let v1: LrcPtr<StringBuilder> = _arg.1.clone();
        let v0: string = _arg.0.clone();
        let v85: Runtime::US5 = if string("") == v0.clone() {
            Runtime::US5::US5_1(sprintf!(
                "parsing.p_char / unexpected end of input / s: {:?}",
                (v1.clone(), v2_1, v3_1)
            ))
        } else {
            let v7: char = getCharAt(v0.clone(), 0_i32);
            if v7 == '\\' {
                let v15: string = getSlice(v0.clone(), Some(1_i32), Some(length(v0.clone())));
                let v19: string = ofChar(v7);
                let v26: i32 = length(v19.clone());
                let v27: Array<char> = new_init(&'\u{0000}', v26);
                let v28: LrcPtr<Runtime::Mut5> = LrcPtr::new(Runtime::Mut5 {
                    l0: MutCell::new(0_i32),
                });
                while Runtime::method13(v26, v28.clone()) {
                    let v30: i32 = v28.l0.get().clone();
                    let v31: char = getCharAt(v19.clone(), v30);
                    v27.get_mut()[v30 as usize] = v31;
                    {
                        let v32: i32 = v30 + 1_i32;
                        v28.l0.set(v32);
                        ()
                    }
                }
                {
                    let v33: List<char> = ofArray(v27.clone());
                    let patternInput: (LrcPtr<StringBuilder>, i32, i32) = Runtime::method15(
                        foldBack(
                            Func2::new(move |b0: char, b1: LrcPtr<Runtime::UH0>| {
                                (Runtime::method14())(b0)(b1)
                            }),
                            v33,
                            LrcPtr::new(Runtime::UH0::UH0_0),
                        ),
                        v1.clone(),
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
                let v55: i32 = length(v0.clone());
                let v58: i32 = indexOf(v0.clone(), string("\n")) - 1_i32;
                Runtime::US5::US5_1(sprintf!(
                    "{}\n{}\n",
                    sprintf!(
                        "parsing.p_char / expected: \'{}\' / line: {} / col: {}\n{}{}",
                        '\\',
                        v2_1,
                        v3_1,
                        v1,
                        getSlice(v0, Some(0_i32), Some(if -2_i32 == v58 { v55 } else { v58 }))
                    ),
                    append(replicate(v3_1 - 1_i32, string(" ")), string("^"))
                ))
            }
        };
        let v144: Runtime::US5 = match &v85 {
            Runtime::US5::US5_0(v85_0_0, v85_0_1, v85_0_2, v85_0_3, v85_0_4) => {
                let v90: i32 = v85_0_4.clone();
                let v89: i32 = v85_0_3.clone();
                let v88: LrcPtr<StringBuilder> = v85_0_2.clone();
                let v87: string = v85_0_1.clone();
                if string("") == v87.clone() {
                    Runtime::US5::US5_1(sprintf!(
                        "parsing.any_char / unexpected end of input / s: {:?}",
                        (v88.clone(), v89, v90)
                    ))
                } else {
                    let v94: char = getCharAt(v87.clone(), 0_i32);
                    let v101: string = getSlice(v87.clone(), Some(1_i32), Some(length(v87)));
                    let v105: string = ofChar(v94);
                    let v112: i32 = length(v105.clone());
                    let v113: Array<char> = new_init(&'\u{0000}', v112);
                    let v114: LrcPtr<Runtime::Mut5> = LrcPtr::new(Runtime::Mut5 {
                        l0: MutCell::new(0_i32),
                    });
                    while Runtime::method13(v112, v114.clone()) {
                        let v116: i32 = v114.l0.get().clone();
                        let v117: char = getCharAt(v105.clone(), v116);
                        v113.get_mut()[v116 as usize] = v117;
                        {
                            let v118: i32 = v116 + 1_i32;
                            v114.l0.set(v118);
                            ()
                        }
                    }
                    {
                        let v119: List<char> = ofArray(v113.clone());
                        let patternInput_1: (LrcPtr<StringBuilder>, i32, i32) = Runtime::method15(
                            foldBack(
                                Func2::new(move |b0: char, b1: LrcPtr<Runtime::UH0>| {
                                    (Runtime::method14())(b0)(b1)
                                }),
                                v119,
                                LrcPtr::new(Runtime::UH0::UH0_0),
                            ),
                            v88,
                            v89,
                            v90,
                        );
                        Runtime::US5::US5_0(
                            v94,
                            v101,
                            patternInput_1.0.clone(),
                            patternInput_1.1.clone(),
                            patternInput_1.2.clone(),
                        )
                    }
                }
            }
            Runtime::US5::US5_1(v85_1_0) => Runtime::US5::US5_1(v85_1_0.clone()),
        };
        match &v144 {
            Runtime::US5::US5_0(v144_0_0, v144_0_1, v144_0_2, v144_0_3, v144_0_4) => {
                Runtime::US6::US6_0(
                    sprintf!("{}{}", '\\', v144_0_0.clone()),
                    v144_0_1.clone(),
                    v144_0_2.clone(),
                    v144_0_3.clone(),
                    v144_0_4.clone(),
                )
            }
            Runtime::US5::US5_1(v144_1_0) => Runtime::US6::US6_1(v144_1_0.clone()),
        }
    }
    pub fn closure31(unitVar: (), _arg: (string, LrcPtr<StringBuilder>, i32, i32)) -> Runtime::US6 {
        let v3_1: i32 = _arg.3.clone();
        let v2_1: i32 = _arg.2.clone();
        let v1: LrcPtr<StringBuilder> = _arg.1.clone();
        let v0: string = _arg.0.clone();
        let v85: Runtime::US5 = if string("") == v0.clone() {
            Runtime::US5::US5_1(sprintf!(
                "parsing.p_char / unexpected end of input / s: {:?}",
                (v1.clone(), v2_1, v3_1)
            ))
        } else {
            let v7: char = getCharAt(v0.clone(), 0_i32);
            if v7 == '`' {
                let v15: string = getSlice(v0.clone(), Some(1_i32), Some(length(v0.clone())));
                let v19: string = ofChar(v7);
                let v26: i32 = length(v19.clone());
                let v27: Array<char> = new_init(&'\u{0000}', v26);
                let v28: LrcPtr<Runtime::Mut5> = LrcPtr::new(Runtime::Mut5 {
                    l0: MutCell::new(0_i32),
                });
                while Runtime::method13(v26, v28.clone()) {
                    let v30: i32 = v28.l0.get().clone();
                    let v31: char = getCharAt(v19.clone(), v30);
                    v27.get_mut()[v30 as usize] = v31;
                    {
                        let v32: i32 = v30 + 1_i32;
                        v28.l0.set(v32);
                        ()
                    }
                }
                {
                    let v33: List<char> = ofArray(v27.clone());
                    let patternInput: (LrcPtr<StringBuilder>, i32, i32) = Runtime::method15(
                        foldBack(
                            Func2::new(move |b0: char, b1: LrcPtr<Runtime::UH0>| {
                                (Runtime::method14())(b0)(b1)
                            }),
                            v33,
                            LrcPtr::new(Runtime::UH0::UH0_0),
                        ),
                        v1.clone(),
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
                let v55: i32 = length(v0.clone());
                let v58: i32 = indexOf(v0.clone(), string("\n")) - 1_i32;
                Runtime::US5::US5_1(sprintf!(
                    "{}\n{}\n",
                    sprintf!(
                        "parsing.p_char / expected: \'{}\' / line: {} / col: {}\n{}{}",
                        '`',
                        v2_1,
                        v3_1,
                        v1,
                        getSlice(v0, Some(0_i32), Some(if -2_i32 == v58 { v55 } else { v58 }))
                    ),
                    append(replicate(v3_1 - 1_i32, string(" ")), string("^"))
                ))
            }
        };
        let v144: Runtime::US5 = match &v85 {
            Runtime::US5::US5_0(v85_0_0, v85_0_1, v85_0_2, v85_0_3, v85_0_4) => {
                let v90: i32 = v85_0_4.clone();
                let v89: i32 = v85_0_3.clone();
                let v88: LrcPtr<StringBuilder> = v85_0_2.clone();
                let v87: string = v85_0_1.clone();
                if string("") == v87.clone() {
                    Runtime::US5::US5_1(sprintf!(
                        "parsing.any_char / unexpected end of input / s: {:?}",
                        (v88.clone(), v89, v90)
                    ))
                } else {
                    let v94: char = getCharAt(v87.clone(), 0_i32);
                    let v101: string = getSlice(v87.clone(), Some(1_i32), Some(length(v87)));
                    let v105: string = ofChar(v94);
                    let v112: i32 = length(v105.clone());
                    let v113: Array<char> = new_init(&'\u{0000}', v112);
                    let v114: LrcPtr<Runtime::Mut5> = LrcPtr::new(Runtime::Mut5 {
                        l0: MutCell::new(0_i32),
                    });
                    while Runtime::method13(v112, v114.clone()) {
                        let v116: i32 = v114.l0.get().clone();
                        let v117: char = getCharAt(v105.clone(), v116);
                        v113.get_mut()[v116 as usize] = v117;
                        {
                            let v118: i32 = v116 + 1_i32;
                            v114.l0.set(v118);
                            ()
                        }
                    }
                    {
                        let v119: List<char> = ofArray(v113.clone());
                        let patternInput_1: (LrcPtr<StringBuilder>, i32, i32) = Runtime::method15(
                            foldBack(
                                Func2::new(move |b0: char, b1: LrcPtr<Runtime::UH0>| {
                                    (Runtime::method14())(b0)(b1)
                                }),
                                v119,
                                LrcPtr::new(Runtime::UH0::UH0_0),
                            ),
                            v88,
                            v89,
                            v90,
                        );
                        Runtime::US5::US5_0(
                            v94,
                            v101,
                            patternInput_1.0.clone(),
                            patternInput_1.1.clone(),
                            patternInput_1.2.clone(),
                        )
                    }
                }
            }
            Runtime::US5::US5_1(v85_1_0) => Runtime::US5::US5_1(v85_1_0.clone()),
        };
        match &v144 {
            Runtime::US5::US5_0(v144_0_0, v144_0_1, v144_0_2, v144_0_3, v144_0_4) => {
                Runtime::US6::US6_0(
                    sprintf!("{}{}", '`', v144_0_0.clone()),
                    v144_0_1.clone(),
                    v144_0_2.clone(),
                    v144_0_3.clone(),
                    v144_0_4.clone(),
                )
            }
            Runtime::US5::US5_1(v144_1_0) => Runtime::US6::US6_1(v144_1_0.clone()),
        }
    }
    pub fn method46(
        v0: string,
        v1: LrcPtr<StringBuilder>,
        v2_1: i32,
        v3_1: i32,
        v4: LrcPtr<Runtime::UH3>,
    ) -> Runtime::US6 {
        let v0: MutCell<string> = MutCell::new(v0.clone());
        let v1: MutCell<LrcPtr<StringBuilder>> = MutCell::new(v1.clone());
        let v2_1: MutCell<i32> = MutCell::new(v2_1);
        let v3_1: MutCell<i32> = MutCell::new(v3_1);
        let v4: MutCell<LrcPtr<Runtime::UH3>> = MutCell::new(v4.clone());
        '_method46: loop {
            break '_method46 (match v4.get().clone().as_ref() {
                Runtime::UH3::UH3_0 => Runtime::US6::US6_1(string("choice / no parsers succeeded")),
                Runtime::UH3::UH3_1(v4_1_0, v4_1_1) => {
                    let v9_1: Runtime::US6 = (match v4.get().clone().as_ref() {
                        Runtime::UH3::UH3_1(x, _) => x.clone(),
                        _ => unreachable!(),
                    })((
                        v0.get().clone(),
                        v1.get().clone(),
                        v2_1.get().clone(),
                        v3_1.get().clone(),
                    ));
                    match &v9_1 {
                        Runtime::US6::US6_0(v9_1_0_0, v9_1_0_1, v9_1_0_2, v9_1_0_3, v9_1_0_4) => {
                            v9_1.clone()
                        }
                        _ => {
                            let v0_temp: string = v0.get().clone();
                            let v1_temp: LrcPtr<StringBuilder> = v1.get().clone();
                            let v2_1_temp: i32 = v2_1.get().clone();
                            let v3_1_temp: i32 = v3_1.get().clone();
                            let v4_temp: LrcPtr<Runtime::UH3> = match v4.get().clone().as_ref() {
                                Runtime::UH3::UH3_1(_, x) => x.clone(),
                                _ => unreachable!(),
                            };
                            v0.set(v0_temp);
                            v1.set(v1_temp);
                            v2_1.set(v2_1_temp);
                            v3_1.set(v3_1_temp);
                            v4.set(v4_temp);
                            continue '_method46;
                        }
                    }
                }
            });
        }
    }
    pub fn method47(v0: LrcPtr<Runtime::UH2>, v1: LrcPtr<Runtime::UH2>) -> LrcPtr<Runtime::UH2> {
        let v0: MutCell<LrcPtr<Runtime::UH2>> = MutCell::new(v0.clone());
        let v1: MutCell<LrcPtr<Runtime::UH2>> = MutCell::new(v1.clone());
        '_method47: loop {
            break '_method47 (match v0.get().clone().as_ref() {
                Runtime::UH2::UH2_0 => v1.get().clone(),
                Runtime::UH2::UH2_1(v0_1_0, v0_1_1) => {
                    let v0_temp: LrcPtr<Runtime::UH2> = match v0.get().clone().as_ref() {
                        Runtime::UH2::UH2_1(_, x) => x.clone(),
                        _ => unreachable!(),
                    };
                    let v1_temp: LrcPtr<Runtime::UH2> = LrcPtr::new(Runtime::UH2::UH2_1(
                        match v0.get().clone().as_ref() {
                            Runtime::UH2::UH2_1(x, _) => x.clone(),
                            _ => unreachable!(),
                        },
                        v1.get().clone(),
                    ));
                    v0.set(v0_temp);
                    v1.set(v1_temp);
                    continue '_method47;
                }
            });
        }
    }
    pub fn method44(
        v0: LrcPtr<Runtime::UH2>,
        v1: string,
        v2_1: LrcPtr<StringBuilder>,
        v3_1: i32,
        v4: i32,
    ) -> Runtime::US15 {
        let v0: MutCell<LrcPtr<Runtime::UH2>> = MutCell::new(v0.clone());
        let v1: MutCell<string> = MutCell::new(v1.clone());
        let v2_1: MutCell<LrcPtr<StringBuilder>> = MutCell::new(v2_1.clone());
        let v3_1: MutCell<i32> = MutCell::new(v3_1);
        let v4: MutCell<i32> = MutCell::new(v4);
        '_method44: loop {
            break '_method44 ({
                let v136: Runtime::US5 = if string("") == v1.get().clone() {
                    Runtime::US5::US5_1(sprintf!(
                        "parsing.none_of / unexpected end of input / chars: {:?} / s: {:?}",
                        toArray(ofArray(new_array(&['\\', '`', '\"']))),
                        (v2_1.get().clone(), v3_1.get().clone(), v4.get().clone())
                    ))
                } else {
                    let v46: char = getCharAt(v1.get().clone(), 0_i32);
                    let v53: string = getSlice(
                        v1.get().clone(),
                        Some(1_i32),
                        Some(length(v1.get().clone())),
                    );
                    if Runtime::method45(v46, 0_i64) == false {
                        let v60: string = ofChar(v46);
                        let v67: i32 = length(v60.clone());
                        let v68: Array<char> = new_init(&'\u{0000}', v67);
                        let v69: LrcPtr<Runtime::Mut5> = LrcPtr::new(Runtime::Mut5 {
                            l0: MutCell::new(0_i32),
                        });
                        while Runtime::method13(v67, v69.clone()) {
                            let v71: i32 = v69.l0.get().clone();
                            let v72: char = getCharAt(v60.clone(), v71);
                            v68.get_mut()[v71 as usize] = v72;
                            {
                                let v73: i32 = v71 + 1_i32;
                                v69.l0.set(v73);
                                ()
                            }
                        }
                        {
                            let v74: List<char> = ofArray(v68.clone());
                            let patternInput: (LrcPtr<StringBuilder>, i32, i32) = Runtime::method15(
                                foldBack(
                                    Func2::new(move |b0: char, b1: LrcPtr<Runtime::UH0>| {
                                        (Runtime::method14())(b0)(b1)
                                    }),
                                    v74,
                                    LrcPtr::new(Runtime::UH0::UH0_0),
                                ),
                                v2_1.get().clone(),
                                v3_1.get().clone(),
                                v4.get().clone(),
                            );
                            Runtime::US5::US5_0(
                                v46,
                                v53,
                                patternInput.0.clone(),
                                patternInput.1.clone(),
                                patternInput.2.clone(),
                            )
                        }
                    } else {
                        Runtime::US5::US5_1(sprintf!(
                            "parsing.none_of / unexpected char: \'{}\' / chars: {:?} / s: {:?}",
                            v46,
                            toArray(ofArray(new_array(&['\\', '`', '\"']))),
                            (v2_1.get().clone(), v3_1.get().clone(), v4.get().clone())
                        ))
                    }
                };
                let v156: Runtime::US6 = match &v136 {
                    Runtime::US5::US5_0(v136_0_0, v136_0_1, v136_0_2, v136_0_3, v136_0_4) => {
                        Runtime::US6::US6_0(
                            ofChar(v136_0_0.clone()),
                            v136_0_1.clone(),
                            v136_0_2.clone(),
                            v136_0_3.clone(),
                            v136_0_4.clone(),
                        )
                    }
                    Runtime::US5::US5_1(v136_1_0) => Runtime::US6::US6_1(v136_1_0.clone()),
                };
                let v170: Runtime::US6 = match &v156 {
                    Runtime::US6::US6_0(v156_0_0, v156_0_1, v156_0_2, v156_0_3, v156_0_4) => {
                        v156.clone()
                    }
                    _ => Runtime::method46(
                        v1.get().clone(),
                        v2_1.get().clone(),
                        v3_1.get().clone(),
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
                match &v170 {
                    Runtime::US6::US6_0(v170_0_0, v170_0_1, v170_0_2, v170_0_3, v170_0_4) => {
                        let v0_temp: LrcPtr<Runtime::UH2> =
                            LrcPtr::new(Runtime::UH2::UH2_1(v170_0_0.clone(), v0.get().clone()));
                        let v1_temp: string = v170_0_1.clone();
                        let v2_1_temp: LrcPtr<StringBuilder> = v170_0_2.clone();
                        let v3_1_temp: i32 = v170_0_3.clone();
                        let v4_temp: i32 = v170_0_4.clone();
                        v0.set(v0_temp);
                        v1.set(v1_temp);
                        v2_1.set(v2_1_temp);
                        v3_1.set(v3_1_temp);
                        v4.set(v4_temp);
                        continue '_method44;
                    }
                    _ => Runtime::US15::US15_0(
                        Runtime::method47(v0.get().clone(), LrcPtr::new(Runtime::UH2::UH2_0)),
                        v1.get().clone(),
                        v2_1.get().clone(),
                        v3_1.get().clone(),
                        v4.get().clone(),
                    ),
                }
            });
        }
    }
    pub fn method48(v0: LrcPtr<Runtime::UH2>, v1: List<string>) -> List<string> {
        match v0.as_ref() {
            Runtime::UH2::UH2_0 => v1.clone(),
            Runtime::UH2::UH2_1(v0_1_0, v0_1_1) => cons(
                match v0.as_ref() {
                    Runtime::UH2::UH2_1(x, _) => x.clone(),
                    _ => unreachable!(),
                },
                Runtime::method48(
                    match v0.as_ref() {
                        Runtime::UH2::UH2_1(_, x) => x.clone(),
                        _ => unreachable!(),
                    },
                    v1.clone(),
                ),
            ),
        }
    }
    pub fn method49(
        v0: LrcPtr<Runtime::UH2>,
        v1: string,
        v2_1: LrcPtr<StringBuilder>,
        v3_1: i32,
        v4: i32,
    ) -> Runtime::US15 {
        let v0: MutCell<LrcPtr<Runtime::UH2>> = MutCell::new(v0.clone());
        let v1: MutCell<string> = MutCell::new(v1.clone());
        let v2_1: MutCell<LrcPtr<StringBuilder>> = MutCell::new(v2_1.clone());
        let v3_1: MutCell<i32> = MutCell::new(v3_1);
        let v4: MutCell<i32> = MutCell::new(v4);
        '_method49: loop {
            break '_method49 ({
                let v136: Runtime::US5 = if string("") == v1.get().clone() {
                    Runtime::US5::US5_1(sprintf!(
                        "parsing.none_of / unexpected end of input / chars: {:?} / s: {:?}",
                        toArray(ofArray(new_array(&['\\', '`', '\"']))),
                        (v2_1.get().clone(), v3_1.get().clone(), v4.get().clone())
                    ))
                } else {
                    let v46: char = getCharAt(v1.get().clone(), 0_i32);
                    let v53: string = getSlice(
                        v1.get().clone(),
                        Some(1_i32),
                        Some(length(v1.get().clone())),
                    );
                    if Runtime::method45(v46, 0_i64) == false {
                        let v60: string = ofChar(v46);
                        let v67: i32 = length(v60.clone());
                        let v68: Array<char> = new_init(&'\u{0000}', v67);
                        let v69: LrcPtr<Runtime::Mut5> = LrcPtr::new(Runtime::Mut5 {
                            l0: MutCell::new(0_i32),
                        });
                        while Runtime::method13(v67, v69.clone()) {
                            let v71: i32 = v69.l0.get().clone();
                            let v72: char = getCharAt(v60.clone(), v71);
                            v68.get_mut()[v71 as usize] = v72;
                            {
                                let v73: i32 = v71 + 1_i32;
                                v69.l0.set(v73);
                                ()
                            }
                        }
                        {
                            let v74: List<char> = ofArray(v68.clone());
                            let patternInput: (LrcPtr<StringBuilder>, i32, i32) = Runtime::method15(
                                foldBack(
                                    Func2::new(move |b0: char, b1: LrcPtr<Runtime::UH0>| {
                                        (Runtime::method14())(b0)(b1)
                                    }),
                                    v74,
                                    LrcPtr::new(Runtime::UH0::UH0_0),
                                ),
                                v2_1.get().clone(),
                                v3_1.get().clone(),
                                v4.get().clone(),
                            );
                            Runtime::US5::US5_0(
                                v46,
                                v53,
                                patternInput.0.clone(),
                                patternInput.1.clone(),
                                patternInput.2.clone(),
                            )
                        }
                    } else {
                        Runtime::US5::US5_1(sprintf!(
                            "parsing.none_of / unexpected char: \'{}\' / chars: {:?} / s: {:?}",
                            v46,
                            toArray(ofArray(new_array(&['\\', '`', '\"']))),
                            (v2_1.get().clone(), v3_1.get().clone(), v4.get().clone())
                        ))
                    }
                };
                let v156: Runtime::US6 = match &v136 {
                    Runtime::US5::US5_0(v136_0_0, v136_0_1, v136_0_2, v136_0_3, v136_0_4) => {
                        Runtime::US6::US6_0(
                            ofChar(v136_0_0.clone()),
                            v136_0_1.clone(),
                            v136_0_2.clone(),
                            v136_0_3.clone(),
                            v136_0_4.clone(),
                        )
                    }
                    Runtime::US5::US5_1(v136_1_0) => Runtime::US6::US6_1(v136_1_0.clone()),
                };
                match &v156 {
                    Runtime::US6::US6_0(v156_0_0, v156_0_1, v156_0_2, v156_0_3, v156_0_4) => {
                        let v0_temp: LrcPtr<Runtime::UH2> =
                            LrcPtr::new(Runtime::UH2::UH2_1(v156_0_0.clone(), v0.get().clone()));
                        let v1_temp: string = v156_0_1.clone();
                        let v2_1_temp: LrcPtr<StringBuilder> = v156_0_2.clone();
                        let v3_1_temp: i32 = v156_0_3.clone();
                        let v4_temp: i32 = v156_0_4.clone();
                        v0.set(v0_temp);
                        v1.set(v1_temp);
                        v2_1.set(v2_1_temp);
                        v3_1.set(v3_1_temp);
                        v4.set(v4_temp);
                        continue '_method49;
                    }
                    _ => Runtime::US15::US15_0(
                        Runtime::method47(v0.get().clone(), LrcPtr::new(Runtime::UH2::UH2_0)),
                        v1.get().clone(),
                        v2_1.get().clone(),
                        v3_1.get().clone(),
                        v4.get().clone(),
                    ),
                }
            });
        }
    }
    pub fn method50(v0: string, v1: i32) -> i32 {
        let v0: MutCell<string> = MutCell::new(v0.clone());
        let v1: MutCell<i32> = MutCell::new(v1);
        '_method50: loop {
            break '_method50 (if v1.get().clone() >= length(v0.get().clone()) {
                v1.get().clone()
            } else {
                if getCharAt(v0.get().clone(), v1.get().clone()) == ' ' {
                    let v0_temp: string = v0.get().clone();
                    let v1_temp: i32 = v1.get().clone() + 1_i32;
                    v0.set(v0_temp);
                    v1.set(v1_temp);
                    continue '_method50;
                } else {
                    v1.get().clone()
                }
            });
        }
    }
    pub fn method41(
        v0: LrcPtr<Runtime::UH2>,
        v1: string,
        v2_1: LrcPtr<StringBuilder>,
        v3_1: i32,
        v4: i32,
    ) -> Runtime::US15 {
        let v0: MutCell<LrcPtr<Runtime::UH2>> = MutCell::new(v0.clone());
        let v1: MutCell<string> = MutCell::new(v1.clone());
        let v2_1: MutCell<LrcPtr<StringBuilder>> = MutCell::new(v2_1.clone());
        let v3_1: MutCell<i32> = MutCell::new(v3_1);
        let v4: MutCell<i32> = MutCell::new(v4);
        '_method41: loop {
            break '_method41 ({
                let v5: bool = string("") == v1.get().clone();
                let v154: Runtime::US5 = if v5 {
                    Runtime::US5::US5_1(sprintf!(
                        "parsing.none_of / unexpected end of input / chars: {:?} / s: {:?}",
                        toArray(ofArray(new_array(&['\\', '`', '\"', ' ']))),
                        (v2_1.get().clone(), v3_1.get().clone(), v4.get().clone())
                    ))
                } else {
                    let v55: char = getCharAt(v1.get().clone(), 0_i32);
                    let v62: string = getSlice(
                        v1.get().clone(),
                        Some(1_i32),
                        Some(length(v1.get().clone())),
                    );
                    if Runtime::method42(v55, 0_i64) == false {
                        let v69: string = ofChar(v55);
                        let v76: i32 = length(v69.clone());
                        let v77: Array<char> = new_init(&'\u{0000}', v76);
                        let v78: LrcPtr<Runtime::Mut5> = LrcPtr::new(Runtime::Mut5 {
                            l0: MutCell::new(0_i32),
                        });
                        while Runtime::method13(v76, v78.clone()) {
                            let v80: i32 = v78.l0.get().clone();
                            let v81: char = getCharAt(v69.clone(), v80);
                            v77.get_mut()[v80 as usize] = v81;
                            {
                                let v82: i32 = v80 + 1_i32;
                                v78.l0.set(v82);
                                ()
                            }
                        }
                        {
                            let v83: List<char> = ofArray(v77.clone());
                            let patternInput: (LrcPtr<StringBuilder>, i32, i32) = Runtime::method15(
                                foldBack(
                                    Func2::new(move |b0: char, b1: LrcPtr<Runtime::UH0>| {
                                        (Runtime::method14())(b0)(b1)
                                    }),
                                    v83,
                                    LrcPtr::new(Runtime::UH0::UH0_0),
                                ),
                                v2_1.get().clone(),
                                v3_1.get().clone(),
                                v4.get().clone(),
                            );
                            Runtime::US5::US5_0(
                                v55,
                                v62,
                                patternInput.0.clone(),
                                patternInput.1.clone(),
                                patternInput.2.clone(),
                            )
                        }
                    } else {
                        Runtime::US5::US5_1(sprintf!(
                            "parsing.none_of / unexpected char: \'{}\' / chars: {:?} / s: {:?}",
                            v55,
                            toArray(ofArray(new_array(&['\\', '`', '\"', ' ']))),
                            (v2_1.get().clone(), v3_1.get().clone(), v4.get().clone())
                        ))
                    }
                };
                let v174: Runtime::US6 = match &v154 {
                    Runtime::US5::US5_0(v154_0_0, v154_0_1, v154_0_2, v154_0_3, v154_0_4) => {
                        Runtime::method43(
                            ofChar(v154_0_0.clone()),
                            v154_0_1.clone(),
                            v154_0_2.clone(),
                            v154_0_3.clone(),
                            v154_0_4.clone(),
                        )
                    }
                    Runtime::US5::US5_1(v154_1_0) => Runtime::US6::US6_1(v154_1_0.clone()),
                };
                let v479: Runtime::US6 = match &v174 {
                    Runtime::US6::US6_0(v174_0_0, v174_0_1, v174_0_2, v174_0_3, v174_0_4) => {
                        v174.clone()
                    }
                    _ => {
                        let v261: Runtime::US5 = if v5 {
                            Runtime::US5::US5_1(sprintf!(
                                "parsing.p_char / unexpected end of input / s: {:?}",
                                (v2_1.get().clone(), v3_1.get().clone(), v4.get().clone())
                            ))
                        } else {
                            let v183: char = getCharAt(v1.get().clone(), 0_i32);
                            if v183 == '\"' {
                                let v191: string = getSlice(
                                    v1.get().clone(),
                                    Some(1_i32),
                                    Some(length(v1.get().clone())),
                                );
                                let v195: string = ofChar(v183);
                                let v202: i32 = length(v195.clone());
                                let v203: Array<char> = new_init(&'\u{0000}', v202);
                                let v204: LrcPtr<Runtime::Mut5> = LrcPtr::new(Runtime::Mut5 {
                                    l0: MutCell::new(0_i32),
                                });
                                while Runtime::method13(v202, v204.clone()) {
                                    let v206: i32 = v204.l0.get().clone();
                                    let v207: char = getCharAt(v195.clone(), v206);
                                    v203.get_mut()[v206 as usize] = v207;
                                    {
                                        let v208: i32 = v206 + 1_i32;
                                        v204.l0.set(v208);
                                        ()
                                    }
                                }
                                {
                                    let v209: List<char> = ofArray(v203.clone());
                                    let patternInput_1: (LrcPtr<StringBuilder>, i32, i32) =
                                        Runtime::method15(
                                            foldBack(
                                                Func2::new(
                                                    move |b0: char, b1: LrcPtr<Runtime::UH0>| {
                                                        (Runtime::method14())(b0)(b1)
                                                    },
                                                ),
                                                v209,
                                                LrcPtr::new(Runtime::UH0::UH0_0),
                                            ),
                                            v2_1.get().clone(),
                                            v3_1.get().clone(),
                                            v4.get().clone(),
                                        );
                                    Runtime::US5::US5_0(
                                        v183,
                                        v191,
                                        patternInput_1.0.clone(),
                                        patternInput_1.1.clone(),
                                        patternInput_1.2.clone(),
                                    )
                                }
                            } else {
                                let v231: i32 = length(v1.get().clone());
                                let v234: i32 = indexOf(v1.get().clone(), string("\n")) - 1_i32;
                                Runtime::US5::US5_1(sprintf!("{}\n{}\n",
                                                                              sprintf!("parsing.p_char / expected: \'{}\' / line: {} / col: {}\n{}{}",
                                                                                       '\"',
                                                                                       v3_1.get().clone(),
                                                                                       v4.get().clone(),
                                                                                       v2_1.get().clone(),
                                                                                       getSlice(v1.get().clone(),
                                                                                                Some(0_i32),
                                                                                                Some(if -2_i32
                                                                                                            ==
                                                                                                            v234
                                                                                                        {
                                                                                                         v231
                                                                                                     } else {
                                                                                                         v234
                                                                                                     }))),
                                                                              append(replicate(v4.get().clone()
                                                                                                   -
                                                                                                   1_i32,
                                                                                               string(" ")),
                                                                                     string("^"))))
                            }
                        };
                        let v408: Runtime::US6 = match &v261 {
                            Runtime::US5::US5_0(
                                v261_0_0,
                                v261_0_1,
                                v261_0_2,
                                v261_0_3,
                                v261_0_4,
                            ) => {
                                let v266: i32 = v261_0_4.clone();
                                let v265: i32 = v261_0_3.clone();
                                let v264: LrcPtr<StringBuilder> = v261_0_2.clone();
                                let v263: string = v261_0_1.clone();
                                let v268: Runtime::US15 = Runtime::method44(
                                    LrcPtr::new(Runtime::UH2::UH2_0),
                                    v263.clone(),
                                    v264.clone(),
                                    v265,
                                    v266,
                                );
                                let v301: Runtime::US6 = match &v268 {
                                    Runtime::US15::US15_0(
                                        v268_0_0,
                                        v268_0_1,
                                        v268_0_2,
                                        v268_0_3,
                                        v268_0_4,
                                    ) => {
                                        let v275: List<string> =
                                            Runtime::method48(v268_0_0.clone(), empty::<string>());
                                        Runtime::US6::US6_0(
                                            join(
                                                string(""),
                                                toArray_1(delay(Func0::new({
                                                    let v275 = v275.clone();
                                                    move || {
                                                        map(
                                                            Func1::new({
                                                                let v275 = v275.clone();
                                                                move |i: i32| item(i, v275.clone())
                                                            }),
                                                            rangeNumeric(
                                                                0_i32,
                                                                1_i32,
                                                                length_1(v275.clone()) - 1_i32,
                                                            ),
                                                        )
                                                    }
                                                }))),
                                            ),
                                            v268_0_1.clone(),
                                            v268_0_2.clone(),
                                            v268_0_3.clone(),
                                            v268_0_4.clone(),
                                        )
                                    }
                                    Runtime::US15::US15_1(v268_1_0) => {
                                        Runtime::US6::US6_1(v268_1_0.clone())
                                    }
                                };
                                match &v301 {
                                    Runtime::US6::US6_0(
                                        v301_0_0,
                                        v301_0_1,
                                        v301_0_2,
                                        v301_0_3,
                                        v301_0_4,
                                    ) => {
                                        let v306: i32 = v301_0_4.clone();
                                        let v305: i32 = v301_0_3.clone();
                                        let v304: LrcPtr<StringBuilder> = v301_0_2.clone();
                                        let v303: string = v301_0_1.clone();
                                        let v388: Runtime::US5 = if string("") == v303.clone() {
                                            Runtime::US5::US5_1(sprintf!("parsing.p_char / unexpected end of input / s: {:?}",
                                                                                              (v304.clone(),
                                                                                               v305,
                                                                                               v306)))
                                        } else {
                                            let v310: char = getCharAt(v303.clone(), 0_i32);
                                            if v310 == '\"' {
                                                let v318: string = getSlice(
                                                    v303.clone(),
                                                    Some(1_i32),
                                                    Some(length(v303.clone())),
                                                );
                                                let v322: string = ofChar(v310);
                                                let v329: i32 = length(v322.clone());
                                                let v330: Array<char> = new_init(&'\u{0000}', v329);
                                                let v331: LrcPtr<Runtime::Mut5> =
                                                    LrcPtr::new(Runtime::Mut5 {
                                                        l0: MutCell::new(0_i32),
                                                    });
                                                while Runtime::method13(v329, v331.clone()) {
                                                    let v333: i32 = v331.l0.get().clone();
                                                    let v334: char = getCharAt(v322.clone(), v333);
                                                    v330.get_mut()[v333 as usize] = v334;
                                                    {
                                                        let v335: i32 = v333 + 1_i32;
                                                        v331.l0.set(v335);
                                                        ()
                                                    }
                                                }
                                                {
                                                    let v336: List<char> = ofArray(v330.clone());
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
                                                                                                        v336,
                                                                                                        LrcPtr::new(Runtime::UH0::UH0_0)),
                                                                                               v304.clone(),
                                                                                               v305,
                                                                                               v306);
                                                    Runtime::US5::US5_0(
                                                        v310,
                                                        v318,
                                                        patternInput_2.0.clone(),
                                                        patternInput_2.1.clone(),
                                                        patternInput_2.2.clone(),
                                                    )
                                                }
                                            } else {
                                                let v358: i32 = length(v303.clone());
                                                let v361: i32 =
                                                    indexOf(v303.clone(), string("\n")) - 1_i32;
                                                Runtime::US5::US5_1(sprintf!("{}\n{}\n",
                                                                                                  sprintf!("parsing.p_char / expected: \'{}\' / line: {} / col: {}\n{}{}",
                                                                                                           '\"',
                                                                                                           v305,
                                                                                                           v306,
                                                                                                           v304.clone(),
                                                                                                           getSlice(v303.clone(),
                                                                                                                    Some(0_i32),
                                                                                                                    Some(if -2_i32
                                                                                                                                ==
                                                                                                                                v361
                                                                                                                            {
                                                                                                                             v358
                                                                                                                         } else {
                                                                                                                             v361
                                                                                                                         }))),
                                                                                                  append(replicate(v306
                                                                                                                       -
                                                                                                                       1_i32,
                                                                                                                   string(" ")),
                                                                                                         string("^"))))
                                            }
                                        };
                                        match &v388 {
                                                             Runtime::US5::US5_0(v388_0_0,
                                                                                 v388_0_1,
                                                                                 v388_0_2,
                                                                                 v388_0_3,
                                                                                 v388_0_4)
                                                             =>
                                                             Runtime::US6::US6_0(v301_0_0.clone(),
                                                                                 v388_0_1.clone(),
                                                                                 v388_0_2.clone(),
                                                                                 v388_0_3.clone(),
                                                                                 v388_0_4.clone()),
                                                             Runtime::US5::US5_1(v388_1_0)
                                                             =>
                                                             Runtime::US6::US6_1(sprintf!("between / expected closing delimiter / e: {:?} / input: {:?} / rest1: {:?} / rest2: {:?}",
                                                                                          v388_1_0.clone(),
                                                                                          (v1.get().clone(),
                                                                                           v2_1.get().clone(),
                                                                                           v3_1.get().clone(),
                                                                                           v4.get().clone()),
                                                                                          (v263,
                                                                                           v264,
                                                                                           v265,
                                                                                           v266),
                                                                                          (v303,
                                                                                           v304,
                                                                                           v305,
                                                                                           v306))),
                                                         }
                                    }
                                    _ => Runtime::US6::US6_1(string("between / expected content")),
                                }
                            }
                            Runtime::US5::US5_1(v261_1_0) => Runtime::US6::US6_1(v261_1_0.clone()),
                        };
                        match &v408 {
                            Runtime::US6::US6_0(
                                v408_0_0,
                                v408_0_1,
                                v408_0_2,
                                v408_0_3,
                                v408_0_4,
                            ) => v408.clone(),
                            _ => {
                                let v420: Runtime::US6 = Runtime::method46(
                                    v1.get().clone(),
                                    v2_1.get().clone(),
                                    v3_1.get().clone(),
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
                                let v431: Runtime::US6 = match &v420 {
                                    Runtime::US6::US6_0(
                                        v420_0_0,
                                        v420_0_1,
                                        v420_0_2,
                                        v420_0_3,
                                        v420_0_4,
                                    ) => Runtime::US6::US6_0(
                                        string(""),
                                        v420_0_1.clone(),
                                        v420_0_2.clone(),
                                        v420_0_3.clone(),
                                        v420_0_4.clone(),
                                    ),
                                    Runtime::US6::US6_1(v420_1_0) => {
                                        Runtime::US6::US6_1(v420_1_0.clone())
                                    }
                                };
                                let v442: Runtime::US15 = match &v431 {
                                    Runtime::US6::US6_0(
                                        v431_0_0,
                                        v431_0_1,
                                        v431_0_2,
                                        v431_0_3,
                                        v431_0_4,
                                    ) => Runtime::method49(
                                        LrcPtr::new(Runtime::UH2::UH2_0),
                                        v431_0_1.clone(),
                                        v431_0_2.clone(),
                                        v431_0_3.clone(),
                                        v431_0_4.clone(),
                                    ),
                                    Runtime::US6::US6_1(v431_1_0) => {
                                        Runtime::US15::US15_1(v431_1_0.clone())
                                    }
                                };
                                match &v442 {
                                    Runtime::US15::US15_0(
                                        v442_0_0,
                                        v442_0_1,
                                        v442_0_2,
                                        v442_0_3,
                                        v442_0_4,
                                    ) => {
                                        let v449: List<string> =
                                            Runtime::method48(v442_0_0.clone(), empty::<string>());
                                        Runtime::US6::US6_0(
                                            join(
                                                string(""),
                                                toArray_1(delay(Func0::new({
                                                    let v449 = v449.clone();
                                                    move || {
                                                        map(
                                                            Func1::new({
                                                                let v449 = v449.clone();
                                                                move |i_1: i32| {
                                                                    item(i_1, v449.clone())
                                                                }
                                                            }),
                                                            rangeNumeric(
                                                                0_i32,
                                                                1_i32,
                                                                length_1(v449.clone()) - 1_i32,
                                                            ),
                                                        )
                                                    }
                                                }))),
                                            ),
                                            v442_0_1.clone(),
                                            v442_0_2.clone(),
                                            v442_0_3.clone(),
                                            v442_0_4.clone(),
                                        )
                                    }
                                    Runtime::US15::US15_1(v442_1_0) => {
                                        Runtime::US6::US6_1(v442_1_0.clone())
                                    }
                                }
                            }
                        }
                    }
                };
                match &v479 {
                    Runtime::US6::US6_0(v479_0_0, v479_0_1, v479_0_2, v479_0_3, v479_0_4) => {
                        let v488: i32 = v479_0_4.clone();
                        let v487: i32 = v479_0_3.clone();
                        let v486: LrcPtr<StringBuilder> = v479_0_2.clone();
                        let v485: string = v479_0_1.clone();
                        let v484: string = v479_0_0.clone();
                        let v490: i32 = Runtime::method50(v485.clone(), 0_i32);
                        let v502: Runtime::US8 = if 0_i32 == v490 {
                            Runtime::US8::US8_1(string("spaces1 / expected at least one space"))
                        } else {
                            Runtime::US8::US8_0(
                                getSlice(v485.clone(), Some(v490), Some(length(v485.clone()))),
                                v486.clone(),
                                v487,
                                v488,
                            )
                        };
                        match &v502 {
                            Runtime::US8::US8_0(v502_0_0, v502_0_1, v502_0_2, v502_0_3) => {
                                let v0_temp: LrcPtr<Runtime::UH2> = LrcPtr::new(
                                    Runtime::UH2::UH2_1(v484.clone(), v0.get().clone()),
                                );
                                let v1_temp: string = v502_0_0.clone();
                                let v2_1_temp: LrcPtr<StringBuilder> = v502_0_1.clone();
                                let v3_1_temp: i32 = v502_0_2.clone();
                                let v4_temp: i32 = v502_0_3.clone();
                                v0.set(v0_temp);
                                v1.set(v1_temp);
                                v2_1.set(v2_1_temp);
                                v3_1.set(v3_1_temp);
                                v4.set(v4_temp);
                                continue '_method41;
                            }
                            _ => Runtime::US15::US15_0(
                                Runtime::method47(
                                    v0.get().clone(),
                                    LrcPtr::new(Runtime::UH2::UH2_1(
                                        v484.clone(),
                                        LrcPtr::new(Runtime::UH2::UH2_0),
                                    )),
                                ),
                                v485,
                                v486,
                                v487,
                                v488,
                            ),
                        }
                    }
                    _ => Runtime::US15::US15_0(
                        Runtime::method47(v0.get().clone(), LrcPtr::new(Runtime::UH2::UH2_0)),
                        v1.get().clone(),
                        v2_1.get().clone(),
                        v3_1.get().clone(),
                        v4.get().clone(),
                    ),
                }
            });
        }
    }
    pub fn method40(v0: string) -> Runtime::US14 {
        let _v0: MutCell<Option<Option<string>>> = MutCell::new(None::<Option<string>>);
        _v0.set(Some(Some(v0)));
        {
            let v27: Runtime::US15 = Runtime::method41(
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
            match &v27 {
                Runtime::US15::US15_0(v27_0_0, v27_0_1, v27_0_2, v27_0_3, v27_0_4) => {
                    Runtime::US14::US14_0(toArray(Runtime::method48(
                        v27_0_0.clone(),
                        empty::<string>(),
                    )))
                }
                Runtime::US15::US15_1(v27_1_0) => Runtime::US14::US14_1(v27_1_0.clone()),
            }
        }
    }
    pub fn closure29(unitVar: (), v0: string) -> Result<Array<string>, string> {
        let v1: Runtime::US14 = Runtime::method40(v0);
        match &v1 {
            Runtime::US14::US14_0(v1_0_0) => Ok::<Array<string>, string>(v1_0_0.clone()),
            Runtime::US14::US14_1(v1_1_0) => Err::<Array<string>, string>(v1_1_0.clone()),
        }
    }
    pub fn v2() -> Func1<
        Runtime::US0,
        (
            LrcPtr<Runtime::Mut0>,
            LrcPtr<Runtime::Mut1>,
            LrcPtr<Runtime::Mut2>,
            LrcPtr<Runtime::Mut3>,
            Option<i64>,
        ),
    > {
        static v2: OnceInit<
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
        v2.get_or_init(|| Func1::new(move |v: Runtime::US0| Runtime::closure0((), v)))
            .clone()
    }
    pub fn v3() -> Runtime::US0 {
        static v3: OnceInit<Runtime::US0> = OnceInit::new();
        v3.get_or_init(|| Runtime::US0::US0_0).clone()
    }
    on_startup!(if Runtime::State::trace_state().get().clone().is_none() {
        Runtime::State::trace_state().set(Some((Runtime::v2())(Runtime::v3())));
    });
    pub fn v9() -> Func0<()> {
        static v9: OnceInit<Func0<()>> = OnceInit::new();
        v9.get_or_init(|| Func0::new(move || Runtime::closure2((), ())))
            .clone()
    }
    pub fn current_process_kill() {
        (Runtime::v9())();
    }
    pub fn v10() -> Func1<string, Arc<Async<(i32, string)>>> {
        static v10: OnceInit<Func1<string, Arc<Async<(i32, string)>>>> = OnceInit::new();
        v10.get_or_init(|| Func1::new(move |v: string| Runtime::closure9((), v)))
            .clone()
    }
    pub fn execute_async(x: string) -> Arc<Async<(i32, string)>> {
        (Runtime::v10())(x)
    }
    pub fn v11() -> Func1<
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
        static v11: OnceInit<
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
        v11.get_or_init(|| {
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
        (Runtime::v11())(x)
    }
    pub fn v12() -> Func1<
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
        static v12: OnceInit<
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
        v12.get_or_init(|| {
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
        (Runtime::v12())(x)
    }
    pub fn v13() -> Func1<string, Result<Array<string>, string>> {
        static v13: OnceInit<Func1<string, Result<Array<string>, string>>> = OnceInit::new();
        v13.get_or_init(|| Func1::new(move |v: string| Runtime::closure29((), v)))
            .clone()
    }
    pub fn split_args(x: string) -> Result<Array<string>, string> {
        (Runtime::v13())(x)
    }
    on_startup!(());
}
