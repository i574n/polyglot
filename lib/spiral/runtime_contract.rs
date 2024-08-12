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
    use fable_library_rust::String_::printfn;
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
        US2_0(Runtime::US0),
        US2_1,
    }
    impl core::fmt::Display for Runtime::US2 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Copy, Debug, PartialEq, PartialOrd, Hash, Eq)]
    pub enum US3 {
        US3_0(i64),
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
        US4_0(string, Runtime::US1),
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
            Runtime::US1,
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
        US11_0(Runtime::US1, string, LrcPtr<StringBuilder>, i32, i32),
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
    pub fn method1() -> string {
        string("TRACE_LEVEL")
    }
    pub fn method3() -> string {
        string("")
    }
    pub fn closure1(
        v0_1: LrcPtr<MutCell<Option<Runtime::US1>>>,
        v1_1: Option<Runtime::US1>,
    ) -> LrcPtr<MutCell<Option<Runtime::US1>>> {
        v0_1.set(v1_1);
        v0_1
    }
    pub fn closure2(
        v0_1: Option<string>,
        v1_1: Func1<Option<Runtime::US1>, LrcPtr<MutCell<Option<Runtime::US1>>>>,
        unitVar: (),
    ) {
        {
            let value: LrcPtr<MutCell<Option<Runtime::US1>>> = v1_1(match &v0_1 {
                None => None::<Runtime::US1>,
                Some(v0_1_0_0) => {
                    let x: string = v0_1_0_0.clone();
                    Some((Func0::new({
                        let x = x.clone();
                        move || Runtime::US1::US1_0(x.clone())
                    }))())
                }
            });
            ()
        }
        ()
    }
    pub fn method2(v0_1: string) -> string {
        let v33: Result<std::string::String, std::env::VarError> = std::env::var(&*v0_1);
        let v35: bool = true;
        let _result = v33.map(|x| {
            //;
            let v37: std::string::String = x;
            let v39: string = fable_library_rust::String_::fromString(v37);
            let v41: bool = true;
            v39
        });
        let v43: Result<string, std::env::VarError> = _result;
        let v44: string = Runtime::method3();
        v43.unwrap_or(v44)
    }
    pub fn method4() -> string {
        string("AUTOMATION")
    }
    pub fn closure3(unitVar: (), v0_1: string) {
        ();
    }
    pub fn method0(
        v0_1: Runtime::US0,
    ) -> (
        LrcPtr<Runtime::Mut0>,
        LrcPtr<Runtime::Mut1>,
        LrcPtr<Runtime::Mut2>,
        LrcPtr<Runtime::Mut3>,
        Option<i64>,
    ) {
        let v79: string = string("env!(\"AUTOMATION\")");
        let v80: &str = env!("AUTOMATION");
        let v82: std::string::String = String::from(v80);
        let _v1: (Runtime::US2, Runtime::US3) = (
            Runtime::US2::US2_1,
            if fable_library_rust::String_::fromString(v82) != string("True") {
                Runtime::US3::US3_1
            } else {
                Runtime::US3::US3_0(near_sdk::env::block_timestamp() as i64)
            },
        );
        let v295: Runtime::US3 = _v1.1.clone();
        let v294: Runtime::US2 = _v1.0.clone();
        (
            LrcPtr::new(Runtime::Mut0 {
                l0: MutCell::new(0_i64),
            }),
            LrcPtr::new(Runtime::Mut1 {
                l0: MutCell::new(Func1::new(move |v: string| Runtime::closure3((), v))),
            }),
            LrcPtr::new(Runtime::Mut2 {
                l0: MutCell::new(true),
            }),
            LrcPtr::new(Runtime::Mut3 {
                l0: MutCell::new(match &v294 {
                    Runtime::US2::US2_0(v294_0_0) => match &v294 {
                        Runtime::US2::US2_0(x) => x.clone(),
                        _ => unreachable!(),
                    },
                    _ => v0_1,
                }),
            }),
            match &v295 {
                Runtime::US3::US3_0(v295_0_0) => Some(match &v295 {
                    Runtime::US3::US3_0(x) => x.clone(),
                    _ => unreachable!(),
                }),
                _ => None::<i64>,
            },
        )
    }
    pub fn closure0(unitVar: (), unitVar_1: ()) {
        if Runtime::State::trace_state().get().clone().is_none() {
            let patternInput: (
                LrcPtr<Runtime::Mut0>,
                LrcPtr<Runtime::Mut1>,
                LrcPtr<Runtime::Mut2>,
                LrcPtr<Runtime::Mut3>,
                Option<i64>,
            ) = Runtime::method0(Runtime::US0::US0_0);
            Runtime::State::trace_state().set(Some((
                patternInput.0.clone(),
                patternInput.1.clone(),
                patternInput.2.clone(),
                patternInput.3.clone(),
                patternInput.4.clone(),
            )));
            ()
        };
    }
    pub fn closure7(v0_1: LrcPtr<Runtime::Mut0>, unitVar: ()) {
        let v2_1: i64 = v0_1.l0.get().clone() + 1_i64;
        v0_1.l0.set(v2_1);
        ()
    }
    pub fn closure8(
        v0_1: LrcPtr<MutCell<Option<Runtime::US3>>>,
        v1_1: Option<Runtime::US3>,
    ) -> LrcPtr<MutCell<Option<Runtime::US3>>> {
        v0_1.set(v1_1);
        v0_1
    }
    pub fn closure9(
        v0_1: Option<i64>,
        v1_1: Func1<Option<Runtime::US3>, LrcPtr<MutCell<Option<Runtime::US3>>>>,
        unitVar: (),
    ) {
        {
            let value: LrcPtr<MutCell<Option<Runtime::US3>>> = v1_1(match &v0_1 {
                None => None::<Runtime::US3>,
                Some(v0_1_0_0) => {
                    let x: i64 = v0_1_0_0.clone();
                    Some((Func0::new({
                        let x = x.clone();
                        move || Runtime::US3::US3_0(x)
                    }))())
                }
            });
            ()
        }
        ()
    }
    pub fn method5() -> string {
        string("hh:mm:ss")
    }
    pub fn method6() -> string {
        string("HH:mm:ss")
    }
    pub fn method7() -> string {
        string("\u{001b}[0m")
    }
    pub fn method8() -> string {
        string("")
    }
    pub fn closure10(unitVar: (), unitVar_1: ()) -> string {
        string("runtime.current_process_kill / exiting... 3")
    }
    pub fn closure6(unitVar: (), unitVar_1: ()) {
        fn v1_1() {
            Runtime::closure0((), ());
        }
        let v2_1: () = {
            v1_1();
            ()
        };
        let patternInput: (
            LrcPtr<Runtime::Mut0>,
            LrcPtr<Runtime::Mut1>,
            LrcPtr<Runtime::Mut2>,
            LrcPtr<Runtime::Mut3>,
            Option<i64>,
        ) = getValue(Runtime::State::trace_state().get().clone());
        let v21: () = {
            v1_1();
            ()
        };
        let patternInput_1: (
            LrcPtr<Runtime::Mut0>,
            LrcPtr<Runtime::Mut1>,
            LrcPtr<Runtime::Mut2>,
            LrcPtr<Runtime::Mut3>,
            Option<i64>,
        ) = getValue(Runtime::State::trace_state().get().clone());
        let v39: Runtime::US0 = (patternInput_1.3.clone()).l0.get().clone();
        if if (patternInput_1.2.clone()).l0.get().clone() == false {
            false
        } else {
            3_i32
                >= find(
                    v39,
                    ofSeq(ofList(ofArray(new_array(&[
                        LrcPtr::new((Runtime::US0::US0_0, 0_i32)),
                        LrcPtr::new((Runtime::US0::US0_1, 1_i32)),
                        LrcPtr::new((Runtime::US0::US0_2, 2_i32)),
                        LrcPtr::new((Runtime::US0::US0_3, 3_i32)),
                        LrcPtr::new((Runtime::US0::US0_4, 4_i32)),
                    ])))),
                )
        } {
            let v47: () = {
                Runtime::closure7(patternInput.0.clone(), ());
                ()
            };
            let v49: () = {
                v1_1();
                ()
            };
            let patternInput_2: (
                LrcPtr<Runtime::Mut0>,
                LrcPtr<Runtime::Mut1>,
                LrcPtr<Runtime::Mut2>,
                LrcPtr<Runtime::Mut3>,
                Option<i64>,
            ) = getValue(Runtime::State::trace_state().get().clone());
            let v201: u64 = near_sdk::env::block_timestamp();
            let _v202: LrcPtr<MutCell<Option<Runtime::US3>>> = refCell(None::<Runtime::US3>);
            let v207: () = {
                Runtime::closure9(
                    patternInput_2.4.clone(),
                    Func1::new({
                        let _v202 = _v202.clone();
                        move |v: Option<Runtime::US3>| Runtime::closure8(_v202.clone(), v)
                    }),
                    (),
                );
                ()
            };
            let v220: Runtime::US3 = defaultValue(Runtime::US3::US3_1, _v202.get().clone());
            let v230: u64 = match &v220 {
                Runtime::US3::US3_0(v220_0_0) => {
                    v201 - match &v220 {
                        Runtime::US3::US3_0(x) => x.clone(),
                        _ => unreachable!(),
                    } as u64
                }
                _ => v201,
            } / 1000000000_u64;
            let v231: u64 = v230 % 60_u64;
            let v233: u64 = v230 / 60_u64 % 60_u64;
            let v235: u64 = v230 / 3600_u64 % 24_u64;
            let v237: std::string::String = format!("{:02}:{:02}:{:02}", v235, v233, v231);
            let v239: string = fable_library_rust::String_::fromString(v237);
            let v511: string = padLeft(toLower(string("Warning")), 7_i32, ' ');
            let v549: &str = inline_colorization::color_yellow;
            let v551: &str = &*v511;
            let v553: &str = inline_colorization::color_reset;
            let v555: string = string("format!(\"{v549}{v551}{v553}\")");
            let v556: std::string::String = format!("{v549}{v551}{v553}");
            let v558: string = fable_library_rust::String_::fromString(v556);
            let v577: i64 = (patternInput_2.0.clone()).l0.get().clone();
            let v579: LrcPtr<Runtime::Mut4> = LrcPtr::new(Runtime::Mut4 {
                l0: MutCell::new(Runtime::method8()),
            });
            let v580: string = v579.l0.get().clone();
            let v619: string = trimEndChars(
                trimStartChars(
                    sprintf!(
                        "{} {} #{} {} / {}",
                        v239,
                        v558,
                        v577,
                        Runtime::closure10((), ()),
                        v580
                    ),
                    toArray(empty::<char>()),
                ),
                toArray(ofArray(new_array(&[' ', '/']))),
            );
            near_sdk::log!("{}", v619.clone());
            ();
            ((patternInput.1.clone()).l0.get().clone())(v619)
        }
    }
    pub fn closure12(unitVar: (), unitVar_1: ()) -> string {
        string("runtime.current_process_kill / exiting... 2")
    }
    pub fn closure11(unitVar: (), unitVar_1: ()) {
        fn v1_1() {
            Runtime::closure0((), ());
        }
        let v2_1: () = {
            v1_1();
            ()
        };
        let patternInput: (
            LrcPtr<Runtime::Mut0>,
            LrcPtr<Runtime::Mut1>,
            LrcPtr<Runtime::Mut2>,
            LrcPtr<Runtime::Mut3>,
            Option<i64>,
        ) = getValue(Runtime::State::trace_state().get().clone());
        let v21: () = {
            v1_1();
            ()
        };
        let patternInput_1: (
            LrcPtr<Runtime::Mut0>,
            LrcPtr<Runtime::Mut1>,
            LrcPtr<Runtime::Mut2>,
            LrcPtr<Runtime::Mut3>,
            Option<i64>,
        ) = getValue(Runtime::State::trace_state().get().clone());
        let v39: Runtime::US0 = (patternInput_1.3.clone()).l0.get().clone();
        if if (patternInput_1.2.clone()).l0.get().clone() == false {
            false
        } else {
            3_i32
                >= find(
                    v39,
                    ofSeq(ofList(ofArray(new_array(&[
                        LrcPtr::new((Runtime::US0::US0_0, 0_i32)),
                        LrcPtr::new((Runtime::US0::US0_1, 1_i32)),
                        LrcPtr::new((Runtime::US0::US0_2, 2_i32)),
                        LrcPtr::new((Runtime::US0::US0_3, 3_i32)),
                        LrcPtr::new((Runtime::US0::US0_4, 4_i32)),
                    ])))),
                )
        } {
            let v47: () = {
                Runtime::closure7(patternInput.0.clone(), ());
                ()
            };
            let v49: () = {
                v1_1();
                ()
            };
            let patternInput_2: (
                LrcPtr<Runtime::Mut0>,
                LrcPtr<Runtime::Mut1>,
                LrcPtr<Runtime::Mut2>,
                LrcPtr<Runtime::Mut3>,
                Option<i64>,
            ) = getValue(Runtime::State::trace_state().get().clone());
            let v201: u64 = near_sdk::env::block_timestamp();
            let _v202: LrcPtr<MutCell<Option<Runtime::US3>>> = refCell(None::<Runtime::US3>);
            let v207: () = {
                Runtime::closure9(
                    patternInput_2.4.clone(),
                    Func1::new({
                        let _v202 = _v202.clone();
                        move |v: Option<Runtime::US3>| Runtime::closure8(_v202.clone(), v)
                    }),
                    (),
                );
                ()
            };
            let v220: Runtime::US3 = defaultValue(Runtime::US3::US3_1, _v202.get().clone());
            let v230: u64 = match &v220 {
                Runtime::US3::US3_0(v220_0_0) => {
                    v201 - match &v220 {
                        Runtime::US3::US3_0(x) => x.clone(),
                        _ => unreachable!(),
                    } as u64
                }
                _ => v201,
            } / 1000000000_u64;
            let v231: u64 = v230 % 60_u64;
            let v233: u64 = v230 / 60_u64 % 60_u64;
            let v235: u64 = v230 / 3600_u64 % 24_u64;
            let v237: std::string::String = format!("{:02}:{:02}:{:02}", v235, v233, v231);
            let v239: string = fable_library_rust::String_::fromString(v237);
            let v511: string = padLeft(toLower(string("Warning")), 7_i32, ' ');
            let v549: &str = inline_colorization::color_yellow;
            let v551: &str = &*v511;
            let v553: &str = inline_colorization::color_reset;
            let v555: string = string("format!(\"{v549}{v551}{v553}\")");
            let v556: std::string::String = format!("{v549}{v551}{v553}");
            let v558: string = fable_library_rust::String_::fromString(v556);
            let v577: i64 = (patternInput_2.0.clone()).l0.get().clone();
            let v579: LrcPtr<Runtime::Mut4> = LrcPtr::new(Runtime::Mut4 {
                l0: MutCell::new(Runtime::method8()),
            });
            let v580: string = v579.l0.get().clone();
            let v619: string = trimEndChars(
                trimStartChars(
                    sprintf!(
                        "{} {} #{} {} / {}",
                        v239,
                        v558,
                        v577,
                        Runtime::closure12((), ()),
                        v580
                    ),
                    toArray(empty::<char>()),
                ),
                toArray(ofArray(new_array(&[' ', '/']))),
            );
            near_sdk::log!("{}", v619.clone());
            ();
            ((patternInput.1.clone()).l0.get().clone())(v619)
        }
    }
    pub fn closure14(unitVar: (), unitVar_1: ()) -> string {
        string("runtime.current_process_kill / exiting... 1")
    }
    pub fn closure13(unitVar: (), unitVar_1: ()) {
        fn v1_1() {
            Runtime::closure0((), ());
        }
        let v2_1: () = {
            v1_1();
            ()
        };
        let patternInput: (
            LrcPtr<Runtime::Mut0>,
            LrcPtr<Runtime::Mut1>,
            LrcPtr<Runtime::Mut2>,
            LrcPtr<Runtime::Mut3>,
            Option<i64>,
        ) = getValue(Runtime::State::trace_state().get().clone());
        let v21: () = {
            v1_1();
            ()
        };
        let patternInput_1: (
            LrcPtr<Runtime::Mut0>,
            LrcPtr<Runtime::Mut1>,
            LrcPtr<Runtime::Mut2>,
            LrcPtr<Runtime::Mut3>,
            Option<i64>,
        ) = getValue(Runtime::State::trace_state().get().clone());
        let v39: Runtime::US0 = (patternInput_1.3.clone()).l0.get().clone();
        if if (patternInput_1.2.clone()).l0.get().clone() == false {
            false
        } else {
            3_i32
                >= find(
                    v39,
                    ofSeq(ofList(ofArray(new_array(&[
                        LrcPtr::new((Runtime::US0::US0_0, 0_i32)),
                        LrcPtr::new((Runtime::US0::US0_1, 1_i32)),
                        LrcPtr::new((Runtime::US0::US0_2, 2_i32)),
                        LrcPtr::new((Runtime::US0::US0_3, 3_i32)),
                        LrcPtr::new((Runtime::US0::US0_4, 4_i32)),
                    ])))),
                )
        } {
            let v47: () = {
                Runtime::closure7(patternInput.0.clone(), ());
                ()
            };
            let v49: () = {
                v1_1();
                ()
            };
            let patternInput_2: (
                LrcPtr<Runtime::Mut0>,
                LrcPtr<Runtime::Mut1>,
                LrcPtr<Runtime::Mut2>,
                LrcPtr<Runtime::Mut3>,
                Option<i64>,
            ) = getValue(Runtime::State::trace_state().get().clone());
            let v201: u64 = near_sdk::env::block_timestamp();
            let _v202: LrcPtr<MutCell<Option<Runtime::US3>>> = refCell(None::<Runtime::US3>);
            let v207: () = {
                Runtime::closure9(
                    patternInput_2.4.clone(),
                    Func1::new({
                        let _v202 = _v202.clone();
                        move |v: Option<Runtime::US3>| Runtime::closure8(_v202.clone(), v)
                    }),
                    (),
                );
                ()
            };
            let v220: Runtime::US3 = defaultValue(Runtime::US3::US3_1, _v202.get().clone());
            let v230: u64 = match &v220 {
                Runtime::US3::US3_0(v220_0_0) => {
                    v201 - match &v220 {
                        Runtime::US3::US3_0(x) => x.clone(),
                        _ => unreachable!(),
                    } as u64
                }
                _ => v201,
            } / 1000000000_u64;
            let v231: u64 = v230 % 60_u64;
            let v233: u64 = v230 / 60_u64 % 60_u64;
            let v235: u64 = v230 / 3600_u64 % 24_u64;
            let v237: std::string::String = format!("{:02}:{:02}:{:02}", v235, v233, v231);
            let v239: string = fable_library_rust::String_::fromString(v237);
            let v511: string = padLeft(toLower(string("Warning")), 7_i32, ' ');
            let v549: &str = inline_colorization::color_yellow;
            let v551: &str = &*v511;
            let v553: &str = inline_colorization::color_reset;
            let v555: string = string("format!(\"{v549}{v551}{v553}\")");
            let v556: std::string::String = format!("{v549}{v551}{v553}");
            let v558: string = fable_library_rust::String_::fromString(v556);
            let v577: i64 = (patternInput_2.0.clone()).l0.get().clone();
            let v579: LrcPtr<Runtime::Mut4> = LrcPtr::new(Runtime::Mut4 {
                l0: MutCell::new(Runtime::method8()),
            });
            let v580: string = v579.l0.get().clone();
            let v619: string = trimEndChars(
                trimStartChars(
                    sprintf!(
                        "{} {} #{} {} / {}",
                        v239,
                        v558,
                        v577,
                        Runtime::closure14((), ()),
                        v580
                    ),
                    toArray(empty::<char>()),
                ),
                toArray(ofArray(new_array(&[' ', '/']))),
            );
            near_sdk::log!("{}", v619.clone());
            ();
            ((patternInput.1.clone()).l0.get().clone())(v619)
        }
    }
    pub fn closure5(unitVar: (), unitVar_1: ()) {
        ();
        ()
    }
    pub fn closure4(unitVar: (), unitVar_1: ()) {
        ();
        ()
    }
    pub fn method11(v0_1: i32, v1_1: LrcPtr<Runtime::Mut5>) -> bool {
        v1_1.l0.get().clone() < v0_1
    }
    pub fn closure18(v0_1: char, v1_1: LrcPtr<Runtime::UH0>) -> LrcPtr<Runtime::UH0> {
        LrcPtr::new(Runtime::UH0::UH0_1(v0_1, v1_1))
    }
    pub fn closure17(unitVar: (), v0_1: char) -> Func1<LrcPtr<Runtime::UH0>, LrcPtr<Runtime::UH0>> {
        Func1::new({
            let v0_1 = v0_1.clone();
            move |v: LrcPtr<Runtime::UH0>| Runtime::closure18(v0_1, v)
        })
    }
    pub fn method12() -> Func1<char, Func1<LrcPtr<Runtime::UH0>, LrcPtr<Runtime::UH0>>> {
        Func1::new(move |v: char| Runtime::closure17((), v))
    }
    pub fn method13(
        v0_1: LrcPtr<Runtime::UH0>,
        v1_1: LrcPtr<StringBuilder>,
        v2_1: i32,
        v3: i32,
    ) -> (LrcPtr<StringBuilder>, i32, i32) {
        let v0_1: MutCell<LrcPtr<Runtime::UH0>> = MutCell::new(v0_1.clone());
        let v1_1: MutCell<LrcPtr<StringBuilder>> = MutCell::new(v1_1.clone());
        let v2_1: MutCell<i32> = MutCell::new(v2_1);
        let v3: MutCell<i32> = MutCell::new(v3);
        '_method13: loop {
            break '_method13 (match v0_1.get().clone().as_ref() {
                Runtime::UH0::UH0_0 => (v1_1.get().clone(), v2_1.get().clone(), v3.get().clone()),
                Runtime::UH0::UH0_1(v0_1_1_0, v0_1_1_1) => {
                    let v4: char = match v0_1.get().clone().as_ref() {
                        Runtime::UH0::UH0_1(x, _) => x.clone(),
                        _ => unreachable!(),
                    };
                    let v6_1: bool = '\n' == v4;
                    let patternInput: (i32, i32) = if v6_1 {
                        (v2_1.get().clone() + 1_i32, 1_i32)
                    } else {
                        (v2_1.get().clone(), v3.get().clone() + 1_i32)
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
                            let v18: LrcPtr<StringBuilder> = {
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
                        continue '_method13;
                    }
                }
            });
        }
    }
    pub fn closure16(unitVar: (), _arg: (string, LrcPtr<StringBuilder>, i32, i32)) -> Runtime::US5 {
        let v3: i32 = _arg.3.clone();
        let v2_1: i32 = _arg.2.clone();
        let v1_1: LrcPtr<StringBuilder> = _arg.1.clone();
        let v0_1: string = _arg.0.clone();
        if string("") == v0_1.clone() {
            Runtime::US5::US5_1(sprintf!(
                "parsing.p_char / unexpected end of input / s: {:?}",
                (v1_1.clone(), v2_1, v3)
            ))
        } else {
            let v7_1: char = getCharAt(v0_1.clone(), 0_i32);
            if v7_1 == '\"' {
                let v15: string = getSlice(v0_1.clone(), Some(1_i32), Some(length(v0_1.clone())));
                let v17: string = ofChar(v7_1);
                let v20: i32 = length(v17.clone());
                let v21: Array<char> = new_init(&'\u{0000}', v20);
                let v22: LrcPtr<Runtime::Mut5> = LrcPtr::new(Runtime::Mut5 {
                    l0: MutCell::new(0_i32),
                });
                while Runtime::method11(v20, v22.clone()) {
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
                    let patternInput: (LrcPtr<StringBuilder>, i32, i32) = Runtime::method13(
                        foldBack(
                            Func2::new(move |b0: char, b1: LrcPtr<Runtime::UH0>| {
                                (Runtime::method12())(b0)(b1)
                            }),
                            v27,
                            LrcPtr::new(Runtime::UH0::UH0_0),
                        ),
                        v1_1.clone(),
                        v2_1,
                        v3,
                    );
                    Runtime::US5::US5_0(
                        v7_1,
                        v15,
                        patternInput.0.clone(),
                        patternInput.1.clone(),
                        patternInput.2.clone(),
                    )
                }
            } else {
                let v43: i32 = length(v0_1.clone());
                let v46: i32 = indexOf(v0_1.clone(), string("\n")) - 1_i32;
                Runtime::US5::US5_1(sprintf!(
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
    pub fn closure19(unitVar: (), _arg: (string, LrcPtr<StringBuilder>, i32, i32)) -> Runtime::US5 {
        let v3: i32 = _arg.3.clone();
        let v2_1: i32 = _arg.2.clone();
        let v1_1: LrcPtr<StringBuilder> = _arg.1.clone();
        let v0_1: string = _arg.0.clone();
        if string("") == v0_1.clone() {
            Runtime::US5::US5_1(sprintf!(
                "parsing.p_char / unexpected end of input / s: {:?}",
                (v1_1.clone(), v2_1, v3)
            ))
        } else {
            let v7_1: char = getCharAt(v0_1.clone(), 0_i32);
            if v7_1 == '\'' {
                let v15: string = getSlice(v0_1.clone(), Some(1_i32), Some(length(v0_1.clone())));
                let v17: string = ofChar(v7_1);
                let v20: i32 = length(v17.clone());
                let v21: Array<char> = new_init(&'\u{0000}', v20);
                let v22: LrcPtr<Runtime::Mut5> = LrcPtr::new(Runtime::Mut5 {
                    l0: MutCell::new(0_i32),
                });
                while Runtime::method11(v20, v22.clone()) {
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
                    let patternInput: (LrcPtr<StringBuilder>, i32, i32) = Runtime::method13(
                        foldBack(
                            Func2::new(move |b0: char, b1: LrcPtr<Runtime::UH0>| {
                                (Runtime::method12())(b0)(b1)
                            }),
                            v27,
                            LrcPtr::new(Runtime::UH0::UH0_0),
                        ),
                        v1_1.clone(),
                        v2_1,
                        v3,
                    );
                    Runtime::US5::US5_0(
                        v7_1,
                        v15,
                        patternInput.0.clone(),
                        patternInput.1.clone(),
                        patternInput.2.clone(),
                    )
                }
            } else {
                let v43: i32 = length(v0_1.clone());
                let v46: i32 = indexOf(v0_1.clone(), string("\n")) - 1_i32;
                Runtime::US5::US5_1(sprintf!(
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
    pub fn method14(
        v0_1: string,
        v1_1: LrcPtr<StringBuilder>,
        v2_1: LrcPtr<Runtime::UH1>,
    ) -> Runtime::US5 {
        let v0_1: MutCell<string> = MutCell::new(v0_1.clone());
        let v1_1: MutCell<LrcPtr<StringBuilder>> = MutCell::new(v1_1.clone());
        let v2_1: MutCell<LrcPtr<Runtime::UH1>> = MutCell::new(v2_1.clone());
        '_method14: loop {
            break '_method14 (match v2_1.get().clone().as_ref() {
                Runtime::UH1::UH1_0 => Runtime::US5::US5_1(string("choice / no parsers succeeded")),
                Runtime::UH1::UH1_1(v2_1_1_0, v2_1_1_1) => {
                    let v7_1: Runtime::US5 = (match v2_1.get().clone().as_ref() {
                        Runtime::UH1::UH1_1(x, _) => x.clone(),
                        _ => unreachable!(),
                    })((
                        v0_1.get().clone(),
                        v1_1.get().clone(),
                        1_i32,
                        1_i32,
                    ));
                    match &v7_1 {
                        Runtime::US5::US5_0(v7_1_0_0, v7_1_0_1, v7_1_0_2, v7_1_0_3, v7_1_0_4) => {
                            v7_1.clone()
                        }
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
                            continue '_method14;
                        }
                    }
                }
            });
        }
    }
    pub fn method15(v0_1: char, v1_1: i64) -> bool {
        let v0_1: MutCell<char> = MutCell::new(v0_1);
        let v1_1: MutCell<i64> = MutCell::new(v1_1);
        '_method15: loop {
            break '_method15 (if v1_1.get().clone() >= 2_i64 {
                false
            } else {
                let v11: Runtime::US7 = if v1_1.get().clone() == 0_i64 {
                    Runtime::US7::US7_0('\"')
                } else {
                    let v5_1: i64 = v1_1.get().clone() - 1_i64;
                    if v5_1 == 0_i64 {
                        Runtime::US7::US7_0('\'')
                    } else {
                        let v8_1: i64 = v5_1 - 1_i64;
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
                    continue '_method15;
                }
            });
        }
    }
    pub fn method16(
        v0_1: string,
        v1_1: string,
        v2_1: LrcPtr<StringBuilder>,
        v3: i32,
        v4: i32,
    ) -> Runtime::US6 {
        let v0_1: MutCell<string> = MutCell::new(v0_1.clone());
        let v1_1: MutCell<string> = MutCell::new(v1_1.clone());
        let v2_1: MutCell<LrcPtr<StringBuilder>> = MutCell::new(v2_1.clone());
        let v3: MutCell<i32> = MutCell::new(v3);
        let v4: MutCell<i32> = MutCell::new(v4);
        '_method16: loop {
            break '_method16 ({
                let v70: Runtime::US5 = if string("") == v1_1.get().clone() {
                    Runtime::US5::US5_1(sprintf!(
                        "parsing.none_of / unexpected end of input / chars: {:?} / s: {:?}",
                        toArray(ofArray(new_array(&['\"', '\'']))),
                        (v2_1.get().clone(), v3.get().clone(), v4.get().clone())
                    ))
                } else {
                    let v19: char = getCharAt(v1_1.get().clone(), 0_i32);
                    let v26: string = getSlice(
                        v1_1.get().clone(),
                        Some(1_i32),
                        Some(length(v1_1.get().clone())),
                    );
                    if Runtime::method15(v19, 0_i64) == false {
                        let v31: string = ofChar(v19);
                        let v34: i32 = length(v31.clone());
                        let v35: Array<char> = new_init(&'\u{0000}', v34);
                        let v36: LrcPtr<Runtime::Mut5> = LrcPtr::new(Runtime::Mut5 {
                            l0: MutCell::new(0_i32),
                        });
                        while Runtime::method11(v34, v36.clone()) {
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
                            let patternInput: (LrcPtr<StringBuilder>, i32, i32) = Runtime::method13(
                                foldBack(
                                    Func2::new(move |b0: char, b1: LrcPtr<Runtime::UH0>| {
                                        (Runtime::method12())(b0)(b1)
                                    }),
                                    v41,
                                    LrcPtr::new(Runtime::UH0::UH0_0),
                                ),
                                v2_1.get().clone(),
                                v3.get().clone(),
                                v4.get().clone(),
                            );
                            Runtime::US5::US5_0(
                                v19,
                                v26,
                                patternInput.0.clone(),
                                patternInput.1.clone(),
                                patternInput.2.clone(),
                            )
                        }
                    } else {
                        Runtime::US5::US5_1(sprintf!(
                            "parsing.none_of / unexpected char: \'{}\' / chars: {:?} / s: {:?}",
                            v19,
                            toArray(ofArray(new_array(&['\"', '\'']))),
                            (v2_1.get().clone(), v3.get().clone(), v4.get().clone())
                        ))
                    }
                };
                let v82: Runtime::US5 = match &v70 {
                    Runtime::US5::US5_0(v70_0_0, v70_0_1, v70_0_2, v70_0_3, v70_0_4) => {
                        let v71: char = v70_0_0.clone();
                        Runtime::US5::US5_0(
                            if '\\' == v71 { '/' } else { v71 },
                            v70_0_1.clone(),
                            v70_0_2.clone(),
                            v70_0_3.clone(),
                            v70_0_4.clone(),
                        )
                    }
                    Runtime::US5::US5_1(v70_1_0) => Runtime::US5::US5_1(v70_1_0.clone()),
                };
                match &v82 {
                    Runtime::US5::US5_0(v82_0_0, v82_0_1, v82_0_2, v82_0_3, v82_0_4) => {
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
                        continue '_method16;
                    }
                    _ => Runtime::US6::US6_0(
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
    pub fn method17(
        v0_1: string,
        v1_1: LrcPtr<StringBuilder>,
        v2_1: i32,
        v3: i32,
        v4: LrcPtr<Runtime::UH1>,
    ) -> Runtime::US5 {
        let v0_1: MutCell<string> = MutCell::new(v0_1.clone());
        let v1_1: MutCell<LrcPtr<StringBuilder>> = MutCell::new(v1_1.clone());
        let v2_1: MutCell<i32> = MutCell::new(v2_1);
        let v3: MutCell<i32> = MutCell::new(v3);
        let v4: MutCell<LrcPtr<Runtime::UH1>> = MutCell::new(v4.clone());
        '_method17: loop {
            break '_method17 (match v4.get().clone().as_ref() {
                Runtime::UH1::UH1_0 => Runtime::US5::US5_1(string("choice / no parsers succeeded")),
                Runtime::UH1::UH1_1(v4_1_0, v4_1_1) => {
                    let v9_1: Runtime::US5 = (match v4.get().clone().as_ref() {
                        Runtime::UH1::UH1_1(x, _) => x.clone(),
                        _ => unreachable!(),
                    })((
                        v0_1.get().clone(),
                        v1_1.get().clone(),
                        v2_1.get().clone(),
                        v3.get().clone(),
                    ));
                    match &v9_1 {
                        Runtime::US5::US5_0(v9_1_0_0, v9_1_0_1, v9_1_0_2, v9_1_0_3, v9_1_0_4) => {
                            v9_1.clone()
                        }
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
                            continue '_method17;
                        }
                    }
                }
            });
        }
    }
    pub fn method18(v0_1: char, v1_1: i64) -> bool {
        let v0_1: MutCell<char> = MutCell::new(v0_1);
        let v1_1: MutCell<i64> = MutCell::new(v1_1);
        '_method18: loop {
            break '_method18 (if v1_1.get().clone() >= 3_i64 {
                false
            } else {
                let v15: Runtime::US7 = if v1_1.get().clone() == 0_i64 {
                    Runtime::US7::US7_0('\"')
                } else {
                    let v5_1: i64 = v1_1.get().clone() - 1_i64;
                    if v5_1 == 0_i64 {
                        Runtime::US7::US7_0('\'')
                    } else {
                        let v8_1: i64 = v5_1 - 1_i64;
                        if v8_1 == 0_i64 {
                            Runtime::US7::US7_0(' ')
                        } else {
                            let v11: i64 = v8_1 - 1_i64;
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
                    continue '_method18;
                }
            });
        }
    }
    pub fn method19(
        v0_1: string,
        v1_1: string,
        v2_1: LrcPtr<StringBuilder>,
        v3: i32,
        v4: i32,
    ) -> Runtime::US6 {
        let v0_1: MutCell<string> = MutCell::new(v0_1.clone());
        let v1_1: MutCell<string> = MutCell::new(v1_1.clone());
        let v2_1: MutCell<LrcPtr<StringBuilder>> = MutCell::new(v2_1.clone());
        let v3: MutCell<i32> = MutCell::new(v3);
        let v4: MutCell<i32> = MutCell::new(v4);
        '_method19: loop {
            break '_method19 ({
                let v76: Runtime::US5 = if string("") == v1_1.get().clone() {
                    Runtime::US5::US5_1(sprintf!(
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
                    if Runtime::method18(v22, 0_i64) == false {
                        let v34: string = ofChar(v22);
                        let v37: i32 = length(v34.clone());
                        let v38: Array<char> = new_init(&'\u{0000}', v37);
                        let v39: LrcPtr<Runtime::Mut5> = LrcPtr::new(Runtime::Mut5 {
                            l0: MutCell::new(0_i32),
                        });
                        while Runtime::method11(v37, v39.clone()) {
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
                            let patternInput: (LrcPtr<StringBuilder>, i32, i32) = Runtime::method13(
                                foldBack(
                                    Func2::new(move |b0: char, b1: LrcPtr<Runtime::UH0>| {
                                        (Runtime::method12())(b0)(b1)
                                    }),
                                    v44,
                                    LrcPtr::new(Runtime::UH0::UH0_0),
                                ),
                                v2_1.get().clone(),
                                v3.get().clone(),
                                v4.get().clone(),
                            );
                            Runtime::US5::US5_0(
                                v22,
                                v29,
                                patternInput.0.clone(),
                                patternInput.1.clone(),
                                patternInput.2.clone(),
                            )
                        }
                    } else {
                        Runtime::US5::US5_1(sprintf!(
                            "parsing.none_of / unexpected char: \'{}\' / chars: {:?} / s: {:?}",
                            v22,
                            toArray(ofArray(new_array(&['\"', '\'', ' ']))),
                            (v2_1.get().clone(), v3.get().clone(), v4.get().clone())
                        ))
                    }
                };
                let v88: Runtime::US5 = match &v76 {
                    Runtime::US5::US5_0(v76_0_0, v76_0_1, v76_0_2, v76_0_3, v76_0_4) => {
                        let v77: char = v76_0_0.clone();
                        Runtime::US5::US5_0(
                            if '\\' == v77 { '/' } else { v77 },
                            v76_0_1.clone(),
                            v76_0_2.clone(),
                            v76_0_3.clone(),
                            v76_0_4.clone(),
                        )
                    }
                    Runtime::US5::US5_1(v76_1_0) => Runtime::US5::US5_1(v76_1_0.clone()),
                };
                match &v88 {
                    Runtime::US5::US5_0(v88_0_0, v88_0_1, v88_0_2, v88_0_3, v88_0_4) => {
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
                        continue '_method19;
                    }
                    _ => Runtime::US6::US6_0(
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
    pub fn method20(v0_1: string, v1_1: i32) -> i32 {
        let v0_1: MutCell<string> = MutCell::new(v0_1.clone());
        let v1_1: MutCell<i32> = MutCell::new(v1_1);
        '_method20: loop {
            break '_method20 (if v1_1.get().clone() >= length(v0_1.get().clone()) {
                v1_1.get().clone()
            } else {
                if getCharAt(v0_1.get().clone(), v1_1.get().clone()) == ' ' {
                    let v0_1_temp: string = v0_1.get().clone();
                    let v1_1_temp: i32 = v1_1.get().clone() + 1_i32;
                    v0_1.set(v0_1_temp);
                    v1_1.set(v1_1_temp);
                    continue '_method20;
                } else {
                    v1_1.get().clone()
                }
            });
        }
    }
    pub fn method21(
        v0_1: string,
        v1_1: string,
        v2_1: LrcPtr<StringBuilder>,
        v3: i32,
        v4: i32,
    ) -> Runtime::US6 {
        let v0_1: MutCell<string> = MutCell::new(v0_1.clone());
        let v1_1: MutCell<string> = MutCell::new(v1_1.clone());
        let v2_1: MutCell<LrcPtr<StringBuilder>> = MutCell::new(v2_1.clone());
        let v3: MutCell<i32> = MutCell::new(v3);
        let v4: MutCell<i32> = MutCell::new(v4);
        '_method21: loop {
            break '_method21 ({
                let v42: Runtime::US5 = if string("") == v1_1.get().clone() {
                    Runtime::US5::US5_1(sprintf!(
                        "parsing.any_char / unexpected end of input / s: {:?}",
                        (v2_1.get().clone(), v3.get().clone(), v4.get().clone())
                    ))
                } else {
                    let v8_1: char = getCharAt(v1_1.get().clone(), 0_i32);
                    let v15: string = getSlice(
                        v1_1.get().clone(),
                        Some(1_i32),
                        Some(length(v1_1.get().clone())),
                    );
                    let v17: string = ofChar(v8_1);
                    let v20: i32 = length(v17.clone());
                    let v21: Array<char> = new_init(&'\u{0000}', v20);
                    let v22: LrcPtr<Runtime::Mut5> = LrcPtr::new(Runtime::Mut5 {
                        l0: MutCell::new(0_i32),
                    });
                    while Runtime::method11(v20, v22.clone()) {
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
                        let patternInput: (LrcPtr<StringBuilder>, i32, i32) = Runtime::method13(
                            foldBack(
                                Func2::new(move |b0: char, b1: LrcPtr<Runtime::UH0>| {
                                    (Runtime::method12())(b0)(b1)
                                }),
                                v27,
                                LrcPtr::new(Runtime::UH0::UH0_0),
                            ),
                            v2_1.get().clone(),
                            v3.get().clone(),
                            v4.get().clone(),
                        );
                        Runtime::US5::US5_0(
                            v8_1,
                            v15,
                            patternInput.0.clone(),
                            patternInput.1.clone(),
                            patternInput.2.clone(),
                        )
                    }
                };
                match &v42 {
                    Runtime::US5::US5_0(v42_0_0, v42_0_1, v42_0_2, v42_0_3, v42_0_4) => {
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
                        continue '_method21;
                    }
                    _ => Runtime::US6::US6_0(
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
    pub fn method10(v0_1: string) -> Runtime::US4 {
        let _v0: MutCell<Option<Option<string>>> = MutCell::new(None::<Option<string>>);
        _v0.set(Some(Some(v0_1)));
        {
            let v7_1: string = defaultValue(
                string(""),
                match &_v0.get().clone() {
                    None => panic!("{}", string("optionm\'.of_obj / _v0=None"),),
                    Some(_v0_0_0) => _v0_0_0.clone(),
                },
            );
            let v11: LrcPtr<StringBuilder> = StringBuilder::_ctor__Z721C83C5(string(""));
            fn v12(arg10_0040: (string, LrcPtr<StringBuilder>, i32, i32)) -> Runtime::US5 {
                Runtime::closure16((), arg10_0040)
            }
            fn v13(arg10_0040_1: (string, LrcPtr<StringBuilder>, i32, i32)) -> Runtime::US5 {
                Runtime::closure19((), arg10_0040_1)
            }
            let v17: Runtime::US5 = Runtime::method14(
                v7_1.clone(),
                v11.clone(),
                LrcPtr::new(Runtime::UH1::UH1_1(
                    Func1::from(v12),
                    LrcPtr::new(Runtime::UH1::UH1_1(
                        Func1::from(v13),
                        LrcPtr::new(Runtime::UH1::UH1_0),
                    )),
                )),
            );
            let v153: Runtime::US6 = match &v17 {
                Runtime::US5::US5_0(v17_0_0, v17_0_1, v17_0_2, v17_0_3, v17_0_4) => {
                    let v22: i32 = v17_0_4.clone();
                    let v21: i32 = v17_0_3.clone();
                    let v20: LrcPtr<StringBuilder> = v17_0_2.clone();
                    let v19: string = v17_0_1.clone();
                    let v88: Runtime::US5 = if string("") == v19.clone() {
                        Runtime::US5::US5_1(sprintf!(
                            "parsing.none_of / unexpected end of input / chars: {:?} / s: {:?}",
                            toArray(ofArray(new_array(&['\"', '\'']))),
                            (v20.clone(), v21, v22)
                        ))
                    } else {
                        let v37: char = getCharAt(v19.clone(), 0_i32);
                        let v44: string =
                            getSlice(v19.clone(), Some(1_i32), Some(length(v19.clone())));
                        if Runtime::method15(v37, 0_i64) == false {
                            let v49: string = ofChar(v37);
                            let v52: i32 = length(v49.clone());
                            let v53: Array<char> = new_init(&'\u{0000}', v52);
                            let v54: LrcPtr<Runtime::Mut5> = LrcPtr::new(Runtime::Mut5 {
                                l0: MutCell::new(0_i32),
                            });
                            while Runtime::method11(v52, v54.clone()) {
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
                                let patternInput: (LrcPtr<StringBuilder>, i32, i32) =
                                    Runtime::method13(
                                        foldBack(
                                            Func2::new(
                                                move |b0: char, b1: LrcPtr<Runtime::UH0>| {
                                                    (Runtime::method12())(b0)(b1)
                                                },
                                            ),
                                            v59,
                                            LrcPtr::new(Runtime::UH0::UH0_0),
                                        ),
                                        v20.clone(),
                                        v21,
                                        v22,
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
                                (v20.clone(), v21, v22)
                            ))
                        }
                    };
                    let v100: Runtime::US5 = match &v88 {
                        Runtime::US5::US5_0(v88_0_0, v88_0_1, v88_0_2, v88_0_3, v88_0_4) => {
                            let v89: char = v88_0_0.clone();
                            Runtime::US5::US5_0(
                                if '\\' == v89 { '/' } else { v89 },
                                v88_0_1.clone(),
                                v88_0_2.clone(),
                                v88_0_3.clone(),
                                v88_0_4.clone(),
                            )
                        }
                        Runtime::US5::US5_1(v88_1_0) => Runtime::US5::US5_1(v88_1_0.clone()),
                    };
                    let v114: Runtime::US6 = match &v100 {
                        Runtime::US5::US5_0(v100_0_0, v100_0_1, v100_0_2, v100_0_3, v100_0_4) => {
                            Runtime::method16(
                                ofChar(v100_0_0.clone()),
                                v100_0_1.clone(),
                                v100_0_2.clone(),
                                v100_0_3.clone(),
                                v100_0_4.clone(),
                            )
                        }
                        Runtime::US5::US5_1(v100_1_0) => Runtime::US6::US6_1(v100_1_0.clone()),
                    };
                    let v124: Runtime::US6 = match &v114 {
                        Runtime::US6::US6_0(v114_0_0, v114_0_1, v114_0_2, v114_0_3, v114_0_4) => {
                            Runtime::US6::US6_0(
                                v114_0_0.clone(),
                                v114_0_1.clone(),
                                v114_0_2.clone(),
                                v114_0_3.clone(),
                                v114_0_4.clone(),
                            )
                        }
                        _ => Runtime::US6::US6_0(string(""), v19.clone(), v20.clone(), v21, v22),
                    };
                    match &v124 {
                        Runtime::US6::US6_0(v124_0_0, v124_0_1, v124_0_2, v124_0_3, v124_0_4) => {
                            let v129: i32 = v124_0_4.clone();
                            let v128: i32 = v124_0_3.clone();
                            let v127: LrcPtr<StringBuilder> = v124_0_2.clone();
                            let v126: string = v124_0_1.clone();
                            let v133: Runtime::US5 = Runtime::method17(
                                v126.clone(),
                                v127.clone(),
                                v128,
                                v129,
                                LrcPtr::new(Runtime::UH1::UH1_1(
                                    Func1::from(v12),
                                    LrcPtr::new(Runtime::UH1::UH1_1(
                                        Func1::from(v13),
                                        LrcPtr::new(Runtime::UH1::UH1_0),
                                    )),
                                )),
                            );
                            match &v133 {
                                    Runtime::US5::US5_0(v133_0_0, v133_0_1,
                                                        v133_0_2, v133_0_3,
                                                        v133_0_4) =>
                                    Runtime::US6::US6_0(v124_0_0.clone(),
                                                        v133_0_1.clone(),
                                                        v133_0_2.clone(),
                                                        v133_0_3.clone(),
                                                        v133_0_4.clone()),
                                    Runtime::US5::US5_1(v133_1_0) =>
                                    Runtime::US6::US6_1(sprintf!("between / expected closing delimiter / e: {:?} / input: {:?} / rest1: {:?} / rest2: {:?}",
                                                                 v133_1_0.clone(),
                                                                 (v7_1.clone(),
                                                                  v11.clone(),
                                                                  1_i32,
                                                                  1_i32),
                                                                 (v19, v20,
                                                                  v21, v22),
                                                                 (v126, v127,
                                                                  v128,
                                                                  v129))),
                                }
                        }
                        _ => Runtime::US6::US6_1(string("between / expected content")),
                    }
                }
                Runtime::US5::US5_1(v17_1_0) => Runtime::US6::US6_1(v17_1_0.clone()),
            };
            let v303: Runtime::US6 = match &v153 {
                Runtime::US6::US6_0(v153_0_0, v153_0_1, v153_0_2, v153_0_3, v153_0_4) => {
                    v153.clone()
                }
                _ => {
                    let v233: Runtime::US5 = if string("") == v7_1.clone() {
                        Runtime::US5::US5_1(sprintf!(
                            "parsing.none_of / unexpected end of input / chars: {:?} / s: {:?}",
                            toArray(ofArray(new_array(&['\"', '\'', ' ']))),
                            (v11.clone(), 1_i32, 1_i32)
                        ))
                    } else {
                        let v177: char = getCharAt(v7_1.clone(), 0_i32);
                        let v184: string =
                            getSlice(v7_1.clone(), Some(1_i32), Some(length(v7_1.clone())));
                        if Runtime::method18(v177, 0_i64) == false {
                            let v189: string = ofChar(v177);
                            let v192: i32 = length(v189.clone());
                            let v193: Array<char> = new_init(&'\u{0000}', v192);
                            let v194: LrcPtr<Runtime::Mut5> = LrcPtr::new(Runtime::Mut5 {
                                l0: MutCell::new(0_i32),
                            });
                            while Runtime::method11(v192, v194.clone()) {
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
                                let patternInput_1: (LrcPtr<StringBuilder>, i32, i32) =
                                    Runtime::method13(
                                        foldBack(
                                            Func2::new(
                                                move |b0: char, b1: LrcPtr<Runtime::UH0>| {
                                                    (Runtime::method12())(b0)(b1)
                                                },
                                            ),
                                            v199,
                                            LrcPtr::new(Runtime::UH0::UH0_0),
                                        ),
                                        v11.clone(),
                                        1_i32,
                                        1_i32,
                                    );
                                Runtime::US5::US5_0(
                                    v177,
                                    v184,
                                    patternInput_1.0.clone(),
                                    patternInput_1.1.clone(),
                                    patternInput_1.2.clone(),
                                )
                            }
                        } else {
                            Runtime::US5::US5_1(sprintf!(
                                "parsing.none_of / unexpected char: \'{}\' / chars: {:?} / s: {:?}",
                                v177,
                                toArray(ofArray(new_array(&['\"', '\'', ' ']))),
                                (v11.clone(), 1_i32, 1_i32)
                            ))
                        }
                    };
                    let v245: Runtime::US5 = match &v233 {
                        Runtime::US5::US5_0(v233_0_0, v233_0_1, v233_0_2, v233_0_3, v233_0_4) => {
                            let v234: char = v233_0_0.clone();
                            Runtime::US5::US5_0(
                                if '\\' == v234 { '/' } else { v234 },
                                v233_0_1.clone(),
                                v233_0_2.clone(),
                                v233_0_3.clone(),
                                v233_0_4.clone(),
                            )
                        }
                        Runtime::US5::US5_1(v233_1_0) => Runtime::US5::US5_1(v233_1_0.clone()),
                    };
                    let v259: Runtime::US6 = match &v245 {
                        Runtime::US5::US5_0(v245_0_0, v245_0_1, v245_0_2, v245_0_3, v245_0_4) => {
                            Runtime::method19(
                                ofChar(v245_0_0.clone()),
                                v245_0_1.clone(),
                                v245_0_2.clone(),
                                v245_0_3.clone(),
                                v245_0_4.clone(),
                            )
                        }
                        Runtime::US5::US5_1(v245_1_0) => Runtime::US6::US6_1(v245_1_0.clone()),
                    };
                    match &v259 {
                        Runtime::US6::US6_0(v259_0_0, v259_0_1, v259_0_2, v259_0_3, v259_0_4) => {
                            v259.clone()
                        }
                        _ => {
                            let v271: Runtime::US8 = if length(v7_1.clone()) == 0_i32 {
                                Runtime::US8::US8_0(v7_1.clone(), v11.clone(), 1_i32, 1_i32)
                            } else {
                                Runtime::US8::US8_1(sprintf!(
                                    "parsing.eof / expected end of input / input: {:?}",
                                    v7_1.clone()
                                ))
                            };
                            let v280: Runtime::US6 = match &v271 {
                                Runtime::US8::US8_0(v271_0_0, v271_0_1, v271_0_2, v271_0_3) => {
                                    Runtime::US6::US6_0(
                                        string(""),
                                        v271_0_0.clone(),
                                        v271_0_1.clone(),
                                        v271_0_2.clone(),
                                        v271_0_3.clone(),
                                    )
                                }
                                Runtime::US8::US8_1(v271_1_0) => {
                                    Runtime::US6::US6_1(v271_1_0.clone())
                                }
                            };
                            match &v280 {
                                Runtime::US6::US6_0(
                                    v280_0_0,
                                    v280_0_1,
                                    v280_0_2,
                                    v280_0_3,
                                    v280_0_4,
                                ) => {
                                    let v282: string = v280_0_1.clone();
                                    Runtime::US6::US6_0(
                                        v280_0_0.clone(),
                                        getSlice(
                                            v282.clone(),
                                            Some(Runtime::method20(v282.clone(), 0_i32)),
                                            Some(length(v282)),
                                        ),
                                        v280_0_2.clone(),
                                        v280_0_3.clone(),
                                        v280_0_4.clone(),
                                    )
                                }
                                Runtime::US6::US6_1(v280_1_0) => {
                                    Runtime::US6::US6_1(v280_1_0.clone())
                                }
                            }
                        }
                    }
                }
            };
            let v471: Runtime::US9 = match &v303 {
                Runtime::US6::US6_0(v303_0_0, v303_0_1, v303_0_2, v303_0_3, v303_0_4) => {
                    let v308: i32 = v303_0_4.clone();
                    let v307: i32 = v303_0_3.clone();
                    let v306: LrcPtr<StringBuilder> = v303_0_2.clone();
                    let v305: string = v303_0_1.clone();
                    let v372: Runtime::US5 = if string("") == v305.clone() {
                        Runtime::US5::US5_1(sprintf!(
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
                            let v327: LrcPtr<Runtime::Mut5> = LrcPtr::new(Runtime::Mut5 {
                                l0: MutCell::new(0_i32),
                            });
                            while Runtime::method11(v325, v327.clone()) {
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
                                let patternInput_2: (LrcPtr<StringBuilder>, i32, i32) =
                                    Runtime::method13(
                                        foldBack(
                                            Func2::new(
                                                move |b0: char, b1: LrcPtr<Runtime::UH0>| {
                                                    (Runtime::method12())(b0)(b1)
                                                },
                                            ),
                                            v332,
                                            LrcPtr::new(Runtime::UH0::UH0_0),
                                        ),
                                        v306.clone(),
                                        v307,
                                        v308,
                                    );
                                Runtime::US5::US5_0(
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
                            Runtime::US5::US5_1(sprintf!(
                                "{}\n{}\n",
                                sprintf!(
                                    "parsing.p_char / expected: \'{}\' / line: {} / col: {}\n{}{}",
                                    ' ',
                                    v307,
                                    v308,
                                    v306.clone(),
                                    getSlice(
                                        v305.clone(),
                                        Some(0_i32),
                                        Some(if -2_i32 == v351 { v348 } else { v351 })
                                    )
                                ),
                                append(replicate(v308 - 1_i32, string(" ")), string("^"))
                            ))
                        }
                    };
                    let v384: Runtime::US10 = match &v372 {
                        Runtime::US5::US5_0(v372_0_0, v372_0_1, v372_0_2, v372_0_3, v372_0_4) => {
                            Runtime::US10::US10_0(
                                Runtime::US7::US7_0(v372_0_0.clone()),
                                v372_0_1.clone(),
                                v372_0_2.clone(),
                                v372_0_3.clone(),
                                v372_0_4.clone(),
                            )
                        }
                        _ => Runtime::US10::US10_0(
                            Runtime::US7::US7_1,
                            v305.clone(),
                            v306.clone(),
                            v307,
                            v308,
                        ),
                    };
                    let v445: Runtime::US6 = match &v384 {
                        Runtime::US10::US10_0(v384_0_0, v384_0_1, v384_0_2, v384_0_3, v384_0_4) => {
                            let v389: i32 = v384_0_4.clone();
                            let v388: i32 = v384_0_3.clone();
                            let v387: LrcPtr<StringBuilder> = v384_0_2.clone();
                            let v386: string = v384_0_1.clone();
                            let v427: Runtime::US5 = if string("") == v386.clone() {
                                Runtime::US5::US5_1(sprintf!(
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
                                let v407: LrcPtr<Runtime::Mut5> = LrcPtr::new(Runtime::Mut5 {
                                    l0: MutCell::new(0_i32),
                                });
                                while Runtime::method11(v405, v407.clone()) {
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
                                    let patternInput_3: (LrcPtr<StringBuilder>, i32, i32) =
                                        Runtime::method13(
                                            foldBack(
                                                Func2::new(
                                                    move |b0: char, b1: LrcPtr<Runtime::UH0>| {
                                                        (Runtime::method12())(b0)(b1)
                                                    },
                                                ),
                                                v412,
                                                LrcPtr::new(Runtime::UH0::UH0_0),
                                            ),
                                            v387,
                                            v388,
                                            v389,
                                        );
                                    Runtime::US5::US5_0(
                                        v393,
                                        v400,
                                        patternInput_3.0.clone(),
                                        patternInput_3.1.clone(),
                                        patternInput_3.2.clone(),
                                    )
                                }
                            };
                            match &v427 {
                                Runtime::US5::US5_0(
                                    v427_0_0,
                                    v427_0_1,
                                    v427_0_2,
                                    v427_0_3,
                                    v427_0_4,
                                ) => Runtime::method21(
                                    ofChar(v427_0_0.clone()),
                                    v427_0_1.clone(),
                                    v427_0_2.clone(),
                                    v427_0_3.clone(),
                                    v427_0_4.clone(),
                                ),
                                Runtime::US5::US5_1(v427_1_0) => {
                                    Runtime::US6::US6_1(v427_1_0.clone())
                                }
                            }
                        }
                        Runtime::US10::US10_1(v384_1_0) => Runtime::US6::US6_1(v384_1_0.clone()),
                    };
                    let v457: Runtime::US11 = match &v445 {
                        Runtime::US6::US6_0(v445_0_0, v445_0_1, v445_0_2, v445_0_3, v445_0_4) => {
                            Runtime::US11::US11_0(
                                Runtime::US1::US1_0(v445_0_0.clone()),
                                v445_0_1.clone(),
                                v445_0_2.clone(),
                                v445_0_3.clone(),
                                v445_0_4.clone(),
                            )
                        }
                        _ => Runtime::US11::US11_0(Runtime::US1::US1_1, v305, v306, v307, v308),
                    };
                    match &v457 {
                        Runtime::US11::US11_0(v457_0_0, v457_0_1, v457_0_2, v457_0_3, v457_0_4) => {
                            Runtime::US9::US9_0(
                                v303_0_0.clone(),
                                v457_0_0.clone(),
                                v457_0_1.clone(),
                                v457_0_2.clone(),
                                v457_0_3.clone(),
                                v457_0_4.clone(),
                            )
                        }
                        Runtime::US11::US11_1(v457_1_0) => Runtime::US9::US9_1(v457_1_0.clone()),
                    }
                }
                Runtime::US6::US6_1(v303_1_0) => Runtime::US9::US9_1(v303_1_0.clone()),
            };
            match &v471 {
                Runtime::US9::US9_0(v471_0_0, v471_0_1, v471_0_2, v471_0_3, v471_0_4, v471_0_5) => {
                    Runtime::US4::US4_0(v471_0_0.clone(), v471_0_1.clone())
                }
                Runtime::US9::US9_1(v471_1_0) => Runtime::US4::US4_1(v471_1_0.clone()),
            }
        }
    }
    pub fn closure21(v0_1: LrcPtr<Runtime::Mut4>, v1_1: string, unitVar: ()) {
        let v3: string = append(v0_1.l0.get().clone(), v1_1);
        v0_1.l0.set(v3);
        ()
    }
    pub fn closure22(unitVar: (), unitVar_1: ()) -> string {
        string("runtime.execute_with_options_async")
    }
    pub fn closure20(
        v0_1: string,
        v1_1: Option<CancellationToken>,
        v2_1: Array<(string, string)>,
        v3: Option<Func1<(i32, string, bool), Arc<Async<()>>>>,
        v4: Option<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
        v5_1: bool,
        v6_1: Option<string>,
        unitVar: (),
    ) {
        fn v8_1() {
            Runtime::closure0((), ());
        }
        let v9_1: () = {
            v8_1();
            ()
        };
        let patternInput: (
            LrcPtr<Runtime::Mut0>,
            LrcPtr<Runtime::Mut1>,
            LrcPtr<Runtime::Mut2>,
            LrcPtr<Runtime::Mut3>,
            Option<i64>,
        ) = getValue(Runtime::State::trace_state().get().clone());
        let v28: () = {
            v8_1();
            ()
        };
        let patternInput_1: (
            LrcPtr<Runtime::Mut0>,
            LrcPtr<Runtime::Mut1>,
            LrcPtr<Runtime::Mut2>,
            LrcPtr<Runtime::Mut3>,
            Option<i64>,
        ) = getValue(Runtime::State::trace_state().get().clone());
        let v46: Runtime::US0 = (patternInput_1.3.clone()).l0.get().clone();
        if if (patternInput_1.2.clone()).l0.get().clone() == false {
            false
        } else {
            1_i32
                >= find(
                    v46,
                    ofSeq(ofList(ofArray(new_array(&[
                        LrcPtr::new((Runtime::US0::US0_0, 0_i32)),
                        LrcPtr::new((Runtime::US0::US0_1, 1_i32)),
                        LrcPtr::new((Runtime::US0::US0_2, 2_i32)),
                        LrcPtr::new((Runtime::US0::US0_3, 3_i32)),
                        LrcPtr::new((Runtime::US0::US0_4, 4_i32)),
                    ])))),
                )
        } {
            let v54: () = {
                Runtime::closure7(patternInput.0.clone(), ());
                ()
            };
            let v56: () = {
                v8_1();
                ()
            };
            let patternInput_2: (
                LrcPtr<Runtime::Mut0>,
                LrcPtr<Runtime::Mut1>,
                LrcPtr<Runtime::Mut2>,
                LrcPtr<Runtime::Mut3>,
                Option<i64>,
            ) = getValue(Runtime::State::trace_state().get().clone());
            let v208: u64 = near_sdk::env::block_timestamp();
            let _v209: LrcPtr<MutCell<Option<Runtime::US3>>> = refCell(None::<Runtime::US3>);
            let v214: () = {
                Runtime::closure9(
                    patternInput_2.4.clone(),
                    Func1::new({
                        let _v209 = _v209.clone();
                        move |v: Option<Runtime::US3>| Runtime::closure8(_v209.clone(), v)
                    }),
                    (),
                );
                ()
            };
            let v227: Runtime::US3 = defaultValue(Runtime::US3::US3_1, _v209.get().clone());
            let v237: u64 = match &v227 {
                Runtime::US3::US3_0(v227_0_0) => {
                    v208 - match &v227 {
                        Runtime::US3::US3_0(x) => x.clone(),
                        _ => unreachable!(),
                    } as u64
                }
                _ => v208,
            } / 1000000000_u64;
            let v238: u64 = v237 % 60_u64;
            let v240: u64 = v237 / 60_u64 % 60_u64;
            let v242: u64 = v237 / 3600_u64 % 24_u64;
            let v244: std::string::String = format!("{:02}:{:02}:{:02}", v242, v240, v238);
            let v246: string = fable_library_rust::String_::fromString(v244);
            let v518: string = padLeft(toLower(string("Debug")), 7_i32, ' ');
            let v556: &str = inline_colorization::color_bright_blue;
            let v558: &str = &*v518;
            let v560: &str = inline_colorization::color_reset;
            let v562: string = string("format!(\"{v556}{v558}{v560}\")");
            let v563: std::string::String = format!("{v556}{v558}{v560}");
            let v565: string = fable_library_rust::String_::fromString(v563);
            let v584: i64 = (patternInput_2.0.clone()).l0.get().clone();
            let v586: LrcPtr<Runtime::Mut4> = LrcPtr::new(Runtime::Mut4 {
                l0: MutCell::new(Runtime::method8()),
            });
            let v593: () = {
                Runtime::closure21(v586.clone(), sprintf!("{}", string("{ ")), ());
                ()
            };
            let v600: () = {
                Runtime::closure21(v586.clone(), sprintf!("{}", string("options")), ());
                ()
            };
            let v607: () = {
                Runtime::closure21(v586.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v613: () = {
                Runtime::closure21(v586.clone(), sprintf!("{}", string("{ ")), ());
                ()
            };
            let v620: () = {
                Runtime::closure21(v586.clone(), sprintf!("{}", string("command")), ());
                ()
            };
            let v626: () = {
                Runtime::closure21(v586.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v632: () = {
                Runtime::closure21(v586.clone(), sprintf!("{}", v0_1), ());
                ()
            };
            let v639: () = {
                Runtime::closure21(v586.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v646: () = {
                Runtime::closure21(
                    v586.clone(),
                    sprintf!("{}", string("cancellation_token")),
                    (),
                );
                ()
            };
            let v652: () = {
                Runtime::closure21(v586.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v663: std::string::String = format!("{:#?}", v1_1);
            let v685: () = {
                Runtime::closure21(
                    v586.clone(),
                    sprintf!("{}", fable_library_rust::String_::fromString(v663)),
                    (),
                );
                ()
            };
            let v691: () = {
                Runtime::closure21(v586.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v698: () = {
                Runtime::closure21(
                    v586.clone(),
                    sprintf!("{}", string("environment_variables")),
                    (),
                );
                ()
            };
            let v704: () = {
                Runtime::closure21(v586.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v713: () = {
                Runtime::closure21(v586.clone(), sprintf!("{}", sprintf!("{:?}", v2_1)), ());
                ()
            };
            let v719: () = {
                Runtime::closure21(v586.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v726: () = {
                Runtime::closure21(v586.clone(), sprintf!("{}", string("on_line")), ());
                ()
            };
            let v732: () = {
                Runtime::closure21(v586.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v743: std::string::String = format!("{:#?}", v3);
            let v765: () = {
                Runtime::closure21(
                    v586.clone(),
                    sprintf!("{}", fable_library_rust::String_::fromString(v743)),
                    (),
                );
                ()
            };
            let v771: () = {
                Runtime::closure21(v586.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v778: () = {
                Runtime::closure21(v586.clone(), sprintf!("{}", string("stdin")), ());
                ()
            };
            let v784: () = {
                Runtime::closure21(v586.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v795: std::string::String = format!("{:#?}", v4);
            let v817: () = {
                Runtime::closure21(
                    v586.clone(),
                    sprintf!("{}", fable_library_rust::String_::fromString(v795)),
                    (),
                );
                ()
            };
            let v823: () = {
                Runtime::closure21(v586.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v830: () = {
                Runtime::closure21(v586.clone(), sprintf!("{}", string("trace")), ());
                ()
            };
            let v836: () = {
                Runtime::closure21(v586.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v845: () = {
                Runtime::closure21(
                    v586.clone(),
                    sprintf!(
                        "{}",
                        if v5_1 {
                            string("true")
                        } else {
                            string("false")
                        }
                    ),
                    (),
                );
                ()
            };
            let v851: () = {
                Runtime::closure21(v586.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v858: () = {
                Runtime::closure21(
                    v586.clone(),
                    sprintf!("{}", string("working_directory")),
                    (),
                );
                ()
            };
            let v864: () = {
                Runtime::closure21(v586.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v875: std::string::String = format!("{:#?}", v6_1);
            let v897: () = {
                Runtime::closure21(
                    v586.clone(),
                    sprintf!("{}", fable_library_rust::String_::fromString(v875)),
                    (),
                );
                ()
            };
            let v904: () = {
                Runtime::closure21(v586.clone(), sprintf!("{}", string(" }")), ());
                ()
            };
            let v910: () = {
                Runtime::closure21(v586.clone(), sprintf!("{}", string(" }")), ());
                ()
            };
            let v911: string = v586.l0.get().clone();
            let v950: string = trimEndChars(
                trimStartChars(
                    sprintf!(
                        "{} {} #{} {} / {}",
                        v246,
                        v565,
                        v584,
                        Runtime::closure22((), ()),
                        v911
                    ),
                    toArray(empty::<char>()),
                ),
                toArray(ofArray(new_array(&[' ', '/']))),
            );
            near_sdk::log!("{}", v950.clone());
            ();
            ((patternInput.1.clone()).l0.get().clone())(v950)
        }
    }
    pub fn closure24(
        v0_1: LrcPtr<MutCell<Option<Runtime::US12>>>,
        v1_1: Option<Runtime::US12>,
    ) -> LrcPtr<MutCell<Option<Runtime::US12>>> {
        v0_1.set(v1_1);
        v0_1
    }
    pub fn closure25(
        v0_1: Option<Func1<(i32, string, bool), Arc<Async<()>>>>,
        v1_1: Func1<Option<Runtime::US12>, LrcPtr<MutCell<Option<Runtime::US12>>>>,
        unitVar: (),
    ) {
        {
            let value: LrcPtr<MutCell<Option<Runtime::US12>>> = v1_1(match &v0_1 {
                None => None::<Runtime::US12>,
                Some(v0_1_0_0) => {
                    let x = v0_1_0_0.clone();
                    Some((Func0::new({
                        let x = x.clone();
                        move || Runtime::US12::US12_0(x.clone())
                    }))())
                }
            });
            ()
        }
        ()
    }
    pub fn closure27(v0_1: string, unitVar: ()) -> string {
        v0_1
    }
    pub fn closure26(v0_1: string, unitVar: ()) {
        fn v2_1() {
            Runtime::closure0((), ());
        }
        let v3: () = {
            v2_1();
            ()
        };
        let patternInput: (
            LrcPtr<Runtime::Mut0>,
            LrcPtr<Runtime::Mut1>,
            LrcPtr<Runtime::Mut2>,
            LrcPtr<Runtime::Mut3>,
            Option<i64>,
        ) = getValue(Runtime::State::trace_state().get().clone());
        let v22: () = {
            v2_1();
            ()
        };
        let patternInput_1: (
            LrcPtr<Runtime::Mut0>,
            LrcPtr<Runtime::Mut1>,
            LrcPtr<Runtime::Mut2>,
            LrcPtr<Runtime::Mut3>,
            Option<i64>,
        ) = getValue(Runtime::State::trace_state().get().clone());
        let v40: Runtime::US0 = (patternInput_1.3.clone()).l0.get().clone();
        if if (patternInput_1.2.clone()).l0.get().clone() == false {
            false
        } else {
            0_i32
                >= find(
                    v40,
                    ofSeq(ofList(ofArray(new_array(&[
                        LrcPtr::new((Runtime::US0::US0_0, 0_i32)),
                        LrcPtr::new((Runtime::US0::US0_1, 1_i32)),
                        LrcPtr::new((Runtime::US0::US0_2, 2_i32)),
                        LrcPtr::new((Runtime::US0::US0_3, 3_i32)),
                        LrcPtr::new((Runtime::US0::US0_4, 4_i32)),
                    ])))),
                )
        } {
            let v48: () = {
                Runtime::closure7(patternInput.0.clone(), ());
                ()
            };
            let v50: () = {
                v2_1();
                ()
            };
            let patternInput_2: (
                LrcPtr<Runtime::Mut0>,
                LrcPtr<Runtime::Mut1>,
                LrcPtr<Runtime::Mut2>,
                LrcPtr<Runtime::Mut3>,
                Option<i64>,
            ) = getValue(Runtime::State::trace_state().get().clone());
            let v202: u64 = near_sdk::env::block_timestamp();
            let _v203: LrcPtr<MutCell<Option<Runtime::US3>>> = refCell(None::<Runtime::US3>);
            let v208: () = {
                Runtime::closure9(
                    patternInput_2.4.clone(),
                    Func1::new({
                        let _v203 = _v203.clone();
                        move |v: Option<Runtime::US3>| Runtime::closure8(_v203.clone(), v)
                    }),
                    (),
                );
                ()
            };
            let v221: Runtime::US3 = defaultValue(Runtime::US3::US3_1, _v203.get().clone());
            let v231: u64 = match &v221 {
                Runtime::US3::US3_0(v221_0_0) => {
                    v202 - match &v221 {
                        Runtime::US3::US3_0(x) => x.clone(),
                        _ => unreachable!(),
                    } as u64
                }
                _ => v202,
            } / 1000000000_u64;
            let v232: u64 = v231 % 60_u64;
            let v234: u64 = v231 / 60_u64 % 60_u64;
            let v236: u64 = v231 / 3600_u64 % 24_u64;
            let v238: std::string::String = format!("{:02}:{:02}:{:02}", v236, v234, v232);
            let v240: string = fable_library_rust::String_::fromString(v238);
            let v512: string = padLeft(toLower(string("Verbose")), 7_i32, ' ');
            let v550: &str = inline_colorization::color_bright_black;
            let v552: &str = &*v512;
            let v554: &str = inline_colorization::color_reset;
            let v556: string = string("format!(\"{v550}{v552}{v554}\")");
            let v557: std::string::String = format!("{v550}{v552}{v554}");
            let v559: string = fable_library_rust::String_::fromString(v557);
            let v578: i64 = (patternInput_2.0.clone()).l0.get().clone();
            let v580: LrcPtr<Runtime::Mut4> = LrcPtr::new(Runtime::Mut4 {
                l0: MutCell::new(Runtime::method8()),
            });
            let v581: string = v580.l0.get().clone();
            let v620: string = trimEndChars(
                trimStartChars(
                    sprintf!(
                        "{} {} #{} {} / {}",
                        v240,
                        v559,
                        v578,
                        Runtime::closure27(v0_1, ()),
                        v581
                    ),
                    toArray(empty::<char>()),
                ),
                toArray(ofArray(new_array(&[' ', '/']))),
            );
            near_sdk::log!("{}", v620.clone());
            ();
            ((patternInput.1.clone()).l0.get().clone())(v620)
        }
    }
    pub fn closure28(v0_1: string, unitVar: ()) {
        printfn!("{0}", v0_1);
    }
    pub fn closure23(
        v0_1: string,
        v1_1: Option<CancellationToken>,
        v2_1: Array<(string, string)>,
        v3: Option<Func1<(i32, string, bool), Arc<Async<()>>>>,
        v4: Option<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
        v5_1: bool,
        v6_1: Option<string>,
        v7_1: (),
        v8_1: LrcPtr<ConcurrentStack_1<string>>,
        v9_1: (),
    ) {
        let v17: Arc<Async<()>> = defaultOf();
        defaultOf::<()>();
        ();
        ()
    }
    pub fn closure29(
        v0_1: string,
        v1_1: Option<CancellationToken>,
        v2_1: Array<(string, string)>,
        v3: Option<Func1<(i32, string, bool), Arc<Async<()>>>>,
        v4: Option<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
        v5_1: bool,
        v6_1: Option<string>,
        v7_1: (),
        v8_1: LrcPtr<ConcurrentStack_1<string>>,
        v9_1: (),
    ) {
        let v17: Arc<Async<()>> = defaultOf();
        defaultOf::<()>();
        ();
        ()
    }
    pub fn closure30(
        v0_1: LrcPtr<MutCell<Option<Runtime::US13>>>,
        v1_1: Option<Runtime::US13>,
    ) -> LrcPtr<MutCell<Option<Runtime::US13>>> {
        v0_1.set(v1_1);
        v0_1
    }
    pub fn closure31(
        v0_1: Option<CancellationToken>,
        v1_1: Func1<Option<Runtime::US13>, LrcPtr<MutCell<Option<Runtime::US13>>>>,
        unitVar: (),
    ) {
        {
            let value: LrcPtr<MutCell<Option<Runtime::US13>>> = v1_1(match &v0_1 {
                None => None::<Runtime::US13>,
                Some(v0_1_0_0) => {
                    let x: CancellationToken = v0_1_0_0.clone();
                    Some((Func0::new({
                        let x = x.clone();
                        move || Runtime::US13::US13_0(x.clone())
                    }))())
                }
            });
            ()
        }
        ()
    }
    pub fn closure32(v0_1: (), unitVar: ()) {
        if unbox::<bool>(&defaultOf()) == false {
            ();
            ()
        };
    }
    pub fn closure34(unitVar: (), unitVar_1: ()) -> string {
        string("runtime.execute_with_options_async / WaitForExitAsync")
    }
    pub fn closure33(v0_1: LrcPtr<TaskCanceledException>, unitVar: ()) {
        fn v2_1() {
            Runtime::closure0((), ());
        }
        let v3: () = {
            v2_1();
            ()
        };
        let patternInput: (
            LrcPtr<Runtime::Mut0>,
            LrcPtr<Runtime::Mut1>,
            LrcPtr<Runtime::Mut2>,
            LrcPtr<Runtime::Mut3>,
            Option<i64>,
        ) = getValue(Runtime::State::trace_state().get().clone());
        let v22: () = {
            v2_1();
            ()
        };
        let patternInput_1: (
            LrcPtr<Runtime::Mut0>,
            LrcPtr<Runtime::Mut1>,
            LrcPtr<Runtime::Mut2>,
            LrcPtr<Runtime::Mut3>,
            Option<i64>,
        ) = getValue(Runtime::State::trace_state().get().clone());
        let v40: Runtime::US0 = (patternInput_1.3.clone()).l0.get().clone();
        if if (patternInput_1.2.clone()).l0.get().clone() == false {
            false
        } else {
            3_i32
                >= find(
                    v40,
                    ofSeq(ofList(ofArray(new_array(&[
                        LrcPtr::new((Runtime::US0::US0_0, 0_i32)),
                        LrcPtr::new((Runtime::US0::US0_1, 1_i32)),
                        LrcPtr::new((Runtime::US0::US0_2, 2_i32)),
                        LrcPtr::new((Runtime::US0::US0_3, 3_i32)),
                        LrcPtr::new((Runtime::US0::US0_4, 4_i32)),
                    ])))),
                )
        } {
            let v48: () = {
                Runtime::closure7(patternInput.0.clone(), ());
                ()
            };
            let v50: () = {
                v2_1();
                ()
            };
            let patternInput_2: (
                LrcPtr<Runtime::Mut0>,
                LrcPtr<Runtime::Mut1>,
                LrcPtr<Runtime::Mut2>,
                LrcPtr<Runtime::Mut3>,
                Option<i64>,
            ) = getValue(Runtime::State::trace_state().get().clone());
            let v202: u64 = near_sdk::env::block_timestamp();
            let _v203: LrcPtr<MutCell<Option<Runtime::US3>>> = refCell(None::<Runtime::US3>);
            let v208: () = {
                Runtime::closure9(
                    patternInput_2.4.clone(),
                    Func1::new({
                        let _v203 = _v203.clone();
                        move |v: Option<Runtime::US3>| Runtime::closure8(_v203.clone(), v)
                    }),
                    (),
                );
                ()
            };
            let v221: Runtime::US3 = defaultValue(Runtime::US3::US3_1, _v203.get().clone());
            let v231: u64 = match &v221 {
                Runtime::US3::US3_0(v221_0_0) => {
                    v202 - match &v221 {
                        Runtime::US3::US3_0(x) => x.clone(),
                        _ => unreachable!(),
                    } as u64
                }
                _ => v202,
            } / 1000000000_u64;
            let v232: u64 = v231 % 60_u64;
            let v234: u64 = v231 / 60_u64 % 60_u64;
            let v236: u64 = v231 / 3600_u64 % 24_u64;
            let v238: std::string::String = format!("{:02}:{:02}:{:02}", v236, v234, v232);
            let v240: string = fable_library_rust::String_::fromString(v238);
            let v512: string = padLeft(toLower(string("Warning")), 7_i32, ' ');
            let v550: &str = inline_colorization::color_yellow;
            let v552: &str = &*v512;
            let v554: &str = inline_colorization::color_reset;
            let v556: string = string("format!(\"{v550}{v552}{v554}\")");
            let v557: std::string::String = format!("{v550}{v552}{v554}");
            let v559: string = fable_library_rust::String_::fromString(v557);
            let v578: i64 = (patternInput_2.0.clone()).l0.get().clone();
            let v580: LrcPtr<Runtime::Mut4> = LrcPtr::new(Runtime::Mut4 {
                l0: MutCell::new(Runtime::method8()),
            });
            let v587: () = {
                Runtime::closure21(v580.clone(), sprintf!("{}", string("{ ")), ());
                ()
            };
            let v594: () = {
                Runtime::closure21(v580.clone(), sprintf!("{}", string("ex")), ());
                ()
            };
            let v601: () = {
                Runtime::closure21(v580.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v612: std::string::String = format!("{:#?}", v0_1);
            let v634: () = {
                Runtime::closure21(
                    v580.clone(),
                    sprintf!("{}", fable_library_rust::String_::fromString(v612)),
                    (),
                );
                ()
            };
            let v641: () = {
                Runtime::closure21(v580.clone(), sprintf!("{}", string(" }")), ());
                ()
            };
            let v642: string = v580.l0.get().clone();
            let v681: string = trimEndChars(
                trimStartChars(
                    sprintf!(
                        "{} {} #{} {} / {}",
                        v240,
                        v559,
                        v578,
                        Runtime::closure34((), ()),
                        v642
                    ),
                    toArray(empty::<char>()),
                ),
                toArray(ofArray(new_array(&[' ', '/']))),
            );
            near_sdk::log!("{}", v681.clone());
            ();
            ((patternInput.1.clone()).l0.get().clone())(v681)
        }
    }
    pub fn closure36(unitVar: (), unitVar_1: ()) -> string {
        string("runtime.execute_with_options_async")
    }
    pub fn closure35(v0_1: i32, v1_1: string, unitVar: ()) {
        fn v3() {
            Runtime::closure0((), ());
        }
        let v4: () = {
            v3();
            ()
        };
        let patternInput: (
            LrcPtr<Runtime::Mut0>,
            LrcPtr<Runtime::Mut1>,
            LrcPtr<Runtime::Mut2>,
            LrcPtr<Runtime::Mut3>,
            Option<i64>,
        ) = getValue(Runtime::State::trace_state().get().clone());
        let v23: () = {
            v3();
            ()
        };
        let patternInput_1: (
            LrcPtr<Runtime::Mut0>,
            LrcPtr<Runtime::Mut1>,
            LrcPtr<Runtime::Mut2>,
            LrcPtr<Runtime::Mut3>,
            Option<i64>,
        ) = getValue(Runtime::State::trace_state().get().clone());
        let v41: Runtime::US0 = (patternInput_1.3.clone()).l0.get().clone();
        if if (patternInput_1.2.clone()).l0.get().clone() == false {
            false
        } else {
            1_i32
                >= find(
                    v41,
                    ofSeq(ofList(ofArray(new_array(&[
                        LrcPtr::new((Runtime::US0::US0_0, 0_i32)),
                        LrcPtr::new((Runtime::US0::US0_1, 1_i32)),
                        LrcPtr::new((Runtime::US0::US0_2, 2_i32)),
                        LrcPtr::new((Runtime::US0::US0_3, 3_i32)),
                        LrcPtr::new((Runtime::US0::US0_4, 4_i32)),
                    ])))),
                )
        } {
            let v49: () = {
                Runtime::closure7(patternInput.0.clone(), ());
                ()
            };
            let v51: () = {
                v3();
                ()
            };
            let patternInput_2: (
                LrcPtr<Runtime::Mut0>,
                LrcPtr<Runtime::Mut1>,
                LrcPtr<Runtime::Mut2>,
                LrcPtr<Runtime::Mut3>,
                Option<i64>,
            ) = getValue(Runtime::State::trace_state().get().clone());
            let v203: u64 = near_sdk::env::block_timestamp();
            let _v204: LrcPtr<MutCell<Option<Runtime::US3>>> = refCell(None::<Runtime::US3>);
            let v209: () = {
                Runtime::closure9(
                    patternInput_2.4.clone(),
                    Func1::new({
                        let _v204 = _v204.clone();
                        move |v: Option<Runtime::US3>| Runtime::closure8(_v204.clone(), v)
                    }),
                    (),
                );
                ()
            };
            let v222: Runtime::US3 = defaultValue(Runtime::US3::US3_1, _v204.get().clone());
            let v232: u64 = match &v222 {
                Runtime::US3::US3_0(v222_0_0) => {
                    v203 - match &v222 {
                        Runtime::US3::US3_0(x) => x.clone(),
                        _ => unreachable!(),
                    } as u64
                }
                _ => v203,
            } / 1000000000_u64;
            let v233: u64 = v232 % 60_u64;
            let v235: u64 = v232 / 60_u64 % 60_u64;
            let v237: u64 = v232 / 3600_u64 % 24_u64;
            let v239: std::string::String = format!("{:02}:{:02}:{:02}", v237, v235, v233);
            let v241: string = fable_library_rust::String_::fromString(v239);
            let v513: string = padLeft(toLower(string("Debug")), 7_i32, ' ');
            let v551: &str = inline_colorization::color_bright_blue;
            let v553: &str = &*v513;
            let v555: &str = inline_colorization::color_reset;
            let v557: string = string("format!(\"{v551}{v553}{v555}\")");
            let v558: std::string::String = format!("{v551}{v553}{v555}");
            let v560: string = fable_library_rust::String_::fromString(v558);
            let v579: i64 = (patternInput_2.0.clone()).l0.get().clone();
            let v580: i32 = length(v1_1);
            let v582: LrcPtr<Runtime::Mut4> = LrcPtr::new(Runtime::Mut4 {
                l0: MutCell::new(Runtime::method8()),
            });
            let v589: () = {
                Runtime::closure21(v582.clone(), sprintf!("{}", string("{ ")), ());
                ()
            };
            let v596: () = {
                Runtime::closure21(v582.clone(), sprintf!("{}", string("exit_code")), ());
                ()
            };
            let v603: () = {
                Runtime::closure21(v582.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v609: () = {
                Runtime::closure21(v582.clone(), sprintf!("{}", v0_1), ());
                ()
            };
            let v616: () = {
                Runtime::closure21(v582.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v623: () = {
                Runtime::closure21(v582.clone(), sprintf!("{}", string("output_length")), ());
                ()
            };
            let v629: () = {
                Runtime::closure21(v582.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v635: () = {
                Runtime::closure21(v582.clone(), sprintf!("{}", v580), ());
                ()
            };
            let v642: () = {
                Runtime::closure21(v582.clone(), sprintf!("{}", string(" }")), ());
                ()
            };
            let v643: string = v582.l0.get().clone();
            let v682: string = trimEndChars(
                trimStartChars(
                    sprintf!(
                        "{} {} #{} {} / {}",
                        v241,
                        v560,
                        v579,
                        Runtime::closure36((), ()),
                        v643
                    ),
                    toArray(empty::<char>()),
                ),
                toArray(ofArray(new_array(&[' ', '/']))),
            );
            near_sdk::log!("{}", v682.clone());
            ();
            ((patternInput.1.clone()).l0.get().clone())(v682)
        }
    }
    pub fn method9(
        v0_1: string,
        v1_1: Option<CancellationToken>,
        v2_1: Array<(string, string)>,
        v3: Option<Func1<(i32, string, bool), Arc<Async<()>>>>,
        v4: Option<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
        v5_1: bool,
        v6_1: Option<string>,
    ) -> Arc<Async<(i32, string)>> {
        defaultOf()
    }
    pub fn closure15(unitVar: (), v0_1: string) -> Arc<Async<(i32, string)>> {
        Runtime::method9(
            v0_1,
            None::<CancellationToken>,
            new_empty::<(string, string)>(),
            None::<Func1<(i32, string, bool), Arc<Async<()>>>>,
            None::<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
            true,
            None::<string>,
        )
    }
    pub fn closure37(
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
    pub fn closure38(
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
        let v8_1: LrcPtr<Runtime::Heap0> = v0_1(LrcPtr::new(Runtime::Heap0 {
            l0: string(""),
            l1: None::<CancellationToken>,
            l2: new_empty::<(string, string)>(),
            l3: None::<Func1<(i32, string, bool), Arc<Async<()>>>>,
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
    pub fn method24(v0_1: char, v1_1: i64) -> bool {
        let v0_1: MutCell<char> = MutCell::new(v0_1);
        let v1_1: MutCell<i64> = MutCell::new(v1_1);
        '_method24: loop {
            break '_method24 (if v1_1.get().clone() >= 4_i64 {
                false
            } else {
                let v19: Runtime::US7 = if v1_1.get().clone() == 0_i64 {
                    Runtime::US7::US7_0('\\')
                } else {
                    let v5_1: i64 = v1_1.get().clone() - 1_i64;
                    if v5_1 == 0_i64 {
                        Runtime::US7::US7_0('`')
                    } else {
                        let v8_1: i64 = v5_1 - 1_i64;
                        if v8_1 == 0_i64 {
                            Runtime::US7::US7_0('\"')
                        } else {
                            let v11: i64 = v8_1 - 1_i64;
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
                    continue '_method24;
                }
            });
        }
    }
    pub fn method25(
        v0_1: string,
        v1_1: string,
        v2_1: LrcPtr<StringBuilder>,
        v3: i32,
        v4: i32,
    ) -> Runtime::US6 {
        let v0_1: MutCell<string> = MutCell::new(v0_1.clone());
        let v1_1: MutCell<string> = MutCell::new(v1_1.clone());
        let v2_1: MutCell<LrcPtr<StringBuilder>> = MutCell::new(v2_1.clone());
        let v3: MutCell<i32> = MutCell::new(v3);
        let v4: MutCell<i32> = MutCell::new(v4);
        '_method25: loop {
            break '_method25 ({
                let v82: Runtime::US5 = if string("") == v1_1.get().clone() {
                    Runtime::US5::US5_1(sprintf!(
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
                    if Runtime::method24(v25, 0_i64) == false {
                        let v37: string = ofChar(v25);
                        let v40: i32 = length(v37.clone());
                        let v41: Array<char> = new_init(&'\u{0000}', v40);
                        let v42: LrcPtr<Runtime::Mut5> = LrcPtr::new(Runtime::Mut5 {
                            l0: MutCell::new(0_i32),
                        });
                        while Runtime::method11(v40, v42.clone()) {
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
                            let patternInput: (LrcPtr<StringBuilder>, i32, i32) = Runtime::method13(
                                foldBack(
                                    Func2::new(move |b0: char, b1: LrcPtr<Runtime::UH0>| {
                                        (Runtime::method12())(b0)(b1)
                                    }),
                                    v47,
                                    LrcPtr::new(Runtime::UH0::UH0_0),
                                ),
                                v2_1.get().clone(),
                                v3.get().clone(),
                                v4.get().clone(),
                            );
                            Runtime::US5::US5_0(
                                v25,
                                v32,
                                patternInput.0.clone(),
                                patternInput.1.clone(),
                                patternInput.2.clone(),
                            )
                        }
                    } else {
                        Runtime::US5::US5_1(sprintf!(
                            "parsing.none_of / unexpected char: \'{}\' / chars: {:?} / s: {:?}",
                            v25,
                            toArray(ofArray(new_array(&['\\', '`', '\"', ' ']))),
                            (v2_1.get().clone(), v3.get().clone(), v4.get().clone())
                        ))
                    }
                };
                match &v82 {
                    Runtime::US5::US5_0(v82_0_0, v82_0_1, v82_0_2, v82_0_3, v82_0_4) => {
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
                        continue '_method25;
                    }
                    _ => Runtime::US6::US6_0(
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
    pub fn method27(v0_1: char, v1_1: i64) -> bool {
        let v0_1: MutCell<char> = MutCell::new(v0_1);
        let v1_1: MutCell<i64> = MutCell::new(v1_1);
        '_method27: loop {
            break '_method27 (if v1_1.get().clone() >= 3_i64 {
                false
            } else {
                let v15: Runtime::US7 = if v1_1.get().clone() == 0_i64 {
                    Runtime::US7::US7_0('\\')
                } else {
                    let v5_1: i64 = v1_1.get().clone() - 1_i64;
                    if v5_1 == 0_i64 {
                        Runtime::US7::US7_0('`')
                    } else {
                        let v8_1: i64 = v5_1 - 1_i64;
                        if v8_1 == 0_i64 {
                            Runtime::US7::US7_0('\"')
                        } else {
                            let v11: i64 = v8_1 - 1_i64;
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
                    continue '_method27;
                }
            });
        }
    }
    pub fn closure40(unitVar: (), _arg: (string, LrcPtr<StringBuilder>, i32, i32)) -> Runtime::US6 {
        let v3: i32 = _arg.3.clone();
        let v2_1: i32 = _arg.2.clone();
        let v1_1: LrcPtr<StringBuilder> = _arg.1.clone();
        let v0_1: string = _arg.0.clone();
        let v67: Runtime::US5 = if string("") == v0_1.clone() {
            Runtime::US5::US5_1(sprintf!(
                "parsing.p_char / unexpected end of input / s: {:?}",
                (v1_1.clone(), v2_1, v3)
            ))
        } else {
            let v7_1: char = getCharAt(v0_1.clone(), 0_i32);
            if v7_1 == '\\' {
                let v15: string = getSlice(v0_1.clone(), Some(1_i32), Some(length(v0_1.clone())));
                let v17: string = ofChar(v7_1);
                let v20: i32 = length(v17.clone());
                let v21: Array<char> = new_init(&'\u{0000}', v20);
                let v22: LrcPtr<Runtime::Mut5> = LrcPtr::new(Runtime::Mut5 {
                    l0: MutCell::new(0_i32),
                });
                while Runtime::method11(v20, v22.clone()) {
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
                    let patternInput: (LrcPtr<StringBuilder>, i32, i32) = Runtime::method13(
                        foldBack(
                            Func2::new(move |b0: char, b1: LrcPtr<Runtime::UH0>| {
                                (Runtime::method12())(b0)(b1)
                            }),
                            v27,
                            LrcPtr::new(Runtime::UH0::UH0_0),
                        ),
                        v1_1.clone(),
                        v2_1,
                        v3,
                    );
                    Runtime::US5::US5_0(
                        v7_1,
                        v15,
                        patternInput.0.clone(),
                        patternInput.1.clone(),
                        patternInput.2.clone(),
                    )
                }
            } else {
                let v43: i32 = length(v0_1.clone());
                let v46: i32 = indexOf(v0_1.clone(), string("\n")) - 1_i32;
                Runtime::US5::US5_1(sprintf!(
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
        let v114: Runtime::US5 = match &v67 {
            Runtime::US5::US5_0(v67_0_0, v67_0_1, v67_0_2, v67_0_3, v67_0_4) => {
                let v72: i32 = v67_0_4.clone();
                let v71: i32 = v67_0_3.clone();
                let v70: LrcPtr<StringBuilder> = v67_0_2.clone();
                let v69: string = v67_0_1.clone();
                if string("") == v69.clone() {
                    Runtime::US5::US5_1(sprintf!(
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
                    while Runtime::method11(v88, v90.clone()) {
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
                        let patternInput_1: (LrcPtr<StringBuilder>, i32, i32) = Runtime::method13(
                            foldBack(
                                Func2::new(move |b0: char, b1: LrcPtr<Runtime::UH0>| {
                                    (Runtime::method12())(b0)(b1)
                                }),
                                v95,
                                LrcPtr::new(Runtime::UH0::UH0_0),
                            ),
                            v70,
                            v71,
                            v72,
                        );
                        Runtime::US5::US5_0(
                            v76,
                            v83,
                            patternInput_1.0.clone(),
                            patternInput_1.1.clone(),
                            patternInput_1.2.clone(),
                        )
                    }
                }
            }
            Runtime::US5::US5_1(v67_1_0) => Runtime::US5::US5_1(v67_1_0.clone()),
        };
        match &v114 {
            Runtime::US5::US5_0(v114_0_0, v114_0_1, v114_0_2, v114_0_3, v114_0_4) => {
                Runtime::US6::US6_0(
                    sprintf!("{}{}", '\\', v114_0_0.clone()),
                    v114_0_1.clone(),
                    v114_0_2.clone(),
                    v114_0_3.clone(),
                    v114_0_4.clone(),
                )
            }
            Runtime::US5::US5_1(v114_1_0) => Runtime::US6::US6_1(v114_1_0.clone()),
        }
    }
    pub fn closure41(unitVar: (), _arg: (string, LrcPtr<StringBuilder>, i32, i32)) -> Runtime::US6 {
        let v3: i32 = _arg.3.clone();
        let v2_1: i32 = _arg.2.clone();
        let v1_1: LrcPtr<StringBuilder> = _arg.1.clone();
        let v0_1: string = _arg.0.clone();
        let v67: Runtime::US5 = if string("") == v0_1.clone() {
            Runtime::US5::US5_1(sprintf!(
                "parsing.p_char / unexpected end of input / s: {:?}",
                (v1_1.clone(), v2_1, v3)
            ))
        } else {
            let v7_1: char = getCharAt(v0_1.clone(), 0_i32);
            if v7_1 == '`' {
                let v15: string = getSlice(v0_1.clone(), Some(1_i32), Some(length(v0_1.clone())));
                let v17: string = ofChar(v7_1);
                let v20: i32 = length(v17.clone());
                let v21: Array<char> = new_init(&'\u{0000}', v20);
                let v22: LrcPtr<Runtime::Mut5> = LrcPtr::new(Runtime::Mut5 {
                    l0: MutCell::new(0_i32),
                });
                while Runtime::method11(v20, v22.clone()) {
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
                    let patternInput: (LrcPtr<StringBuilder>, i32, i32) = Runtime::method13(
                        foldBack(
                            Func2::new(move |b0: char, b1: LrcPtr<Runtime::UH0>| {
                                (Runtime::method12())(b0)(b1)
                            }),
                            v27,
                            LrcPtr::new(Runtime::UH0::UH0_0),
                        ),
                        v1_1.clone(),
                        v2_1,
                        v3,
                    );
                    Runtime::US5::US5_0(
                        v7_1,
                        v15,
                        patternInput.0.clone(),
                        patternInput.1.clone(),
                        patternInput.2.clone(),
                    )
                }
            } else {
                let v43: i32 = length(v0_1.clone());
                let v46: i32 = indexOf(v0_1.clone(), string("\n")) - 1_i32;
                Runtime::US5::US5_1(sprintf!(
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
        let v114: Runtime::US5 = match &v67 {
            Runtime::US5::US5_0(v67_0_0, v67_0_1, v67_0_2, v67_0_3, v67_0_4) => {
                let v72: i32 = v67_0_4.clone();
                let v71: i32 = v67_0_3.clone();
                let v70: LrcPtr<StringBuilder> = v67_0_2.clone();
                let v69: string = v67_0_1.clone();
                if string("") == v69.clone() {
                    Runtime::US5::US5_1(sprintf!(
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
                    while Runtime::method11(v88, v90.clone()) {
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
                        let patternInput_1: (LrcPtr<StringBuilder>, i32, i32) = Runtime::method13(
                            foldBack(
                                Func2::new(move |b0: char, b1: LrcPtr<Runtime::UH0>| {
                                    (Runtime::method12())(b0)(b1)
                                }),
                                v95,
                                LrcPtr::new(Runtime::UH0::UH0_0),
                            ),
                            v70,
                            v71,
                            v72,
                        );
                        Runtime::US5::US5_0(
                            v76,
                            v83,
                            patternInput_1.0.clone(),
                            patternInput_1.1.clone(),
                            patternInput_1.2.clone(),
                        )
                    }
                }
            }
            Runtime::US5::US5_1(v67_1_0) => Runtime::US5::US5_1(v67_1_0.clone()),
        };
        match &v114 {
            Runtime::US5::US5_0(v114_0_0, v114_0_1, v114_0_2, v114_0_3, v114_0_4) => {
                Runtime::US6::US6_0(
                    sprintf!("{}{}", '`', v114_0_0.clone()),
                    v114_0_1.clone(),
                    v114_0_2.clone(),
                    v114_0_3.clone(),
                    v114_0_4.clone(),
                )
            }
            Runtime::US5::US5_1(v114_1_0) => Runtime::US6::US6_1(v114_1_0.clone()),
        }
    }
    pub fn method28(
        v0_1: string,
        v1_1: LrcPtr<StringBuilder>,
        v2_1: i32,
        v3: i32,
        v4: LrcPtr<Runtime::UH3>,
    ) -> Runtime::US6 {
        let v0_1: MutCell<string> = MutCell::new(v0_1.clone());
        let v1_1: MutCell<LrcPtr<StringBuilder>> = MutCell::new(v1_1.clone());
        let v2_1: MutCell<i32> = MutCell::new(v2_1);
        let v3: MutCell<i32> = MutCell::new(v3);
        let v4: MutCell<LrcPtr<Runtime::UH3>> = MutCell::new(v4.clone());
        '_method28: loop {
            break '_method28 (match v4.get().clone().as_ref() {
                Runtime::UH3::UH3_0 => Runtime::US6::US6_1(string("choice / no parsers succeeded")),
                Runtime::UH3::UH3_1(v4_1_0, v4_1_1) => {
                    let v9_1: Runtime::US6 = (match v4.get().clone().as_ref() {
                        Runtime::UH3::UH3_1(x, _) => x.clone(),
                        _ => unreachable!(),
                    })((
                        v0_1.get().clone(),
                        v1_1.get().clone(),
                        v2_1.get().clone(),
                        v3.get().clone(),
                    ));
                    match &v9_1 {
                        Runtime::US6::US6_0(v9_1_0_0, v9_1_0_1, v9_1_0_2, v9_1_0_3, v9_1_0_4) => {
                            v9_1.clone()
                        }
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
                            continue '_method28;
                        }
                    }
                }
            });
        }
    }
    pub fn method29(
        v0_1: LrcPtr<Runtime::UH2>,
        v1_1: LrcPtr<Runtime::UH2>,
    ) -> LrcPtr<Runtime::UH2> {
        let v0_1: MutCell<LrcPtr<Runtime::UH2>> = MutCell::new(v0_1.clone());
        let v1_1: MutCell<LrcPtr<Runtime::UH2>> = MutCell::new(v1_1.clone());
        '_method29: loop {
            break '_method29 (match v0_1.get().clone().as_ref() {
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
                    continue '_method29;
                }
            });
        }
    }
    pub fn method26(
        v0_1: LrcPtr<Runtime::UH2>,
        v1_1: string,
        v2_1: LrcPtr<StringBuilder>,
        v3: i32,
        v4: i32,
    ) -> Runtime::US15 {
        let v0_1: MutCell<LrcPtr<Runtime::UH2>> = MutCell::new(v0_1.clone());
        let v1_1: MutCell<string> = MutCell::new(v1_1.clone());
        let v2_1: MutCell<LrcPtr<StringBuilder>> = MutCell::new(v2_1.clone());
        let v3: MutCell<i32> = MutCell::new(v3);
        let v4: MutCell<i32> = MutCell::new(v4);
        '_method26: loop {
            break '_method26 ({
                let v76: Runtime::US5 = if string("") == v1_1.get().clone() {
                    Runtime::US5::US5_1(sprintf!(
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
                    if Runtime::method27(v22, 0_i64) == false {
                        let v34: string = ofChar(v22);
                        let v37: i32 = length(v34.clone());
                        let v38: Array<char> = new_init(&'\u{0000}', v37);
                        let v39: LrcPtr<Runtime::Mut5> = LrcPtr::new(Runtime::Mut5 {
                            l0: MutCell::new(0_i32),
                        });
                        while Runtime::method11(v37, v39.clone()) {
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
                            let patternInput: (LrcPtr<StringBuilder>, i32, i32) = Runtime::method13(
                                foldBack(
                                    Func2::new(move |b0: char, b1: LrcPtr<Runtime::UH0>| {
                                        (Runtime::method12())(b0)(b1)
                                    }),
                                    v44,
                                    LrcPtr::new(Runtime::UH0::UH0_0),
                                ),
                                v2_1.get().clone(),
                                v3.get().clone(),
                                v4.get().clone(),
                            );
                            Runtime::US5::US5_0(
                                v22,
                                v29,
                                patternInput.0.clone(),
                                patternInput.1.clone(),
                                patternInput.2.clone(),
                            )
                        }
                    } else {
                        Runtime::US5::US5_1(sprintf!(
                            "parsing.none_of / unexpected char: \'{}\' / chars: {:?} / s: {:?}",
                            v22,
                            toArray(ofArray(new_array(&['\\', '`', '\"']))),
                            (v2_1.get().clone(), v3.get().clone(), v4.get().clone())
                        ))
                    }
                };
                let v90: Runtime::US6 = match &v76 {
                    Runtime::US5::US5_0(v76_0_0, v76_0_1, v76_0_2, v76_0_3, v76_0_4) => {
                        Runtime::US6::US6_0(
                            ofChar(v76_0_0.clone()),
                            v76_0_1.clone(),
                            v76_0_2.clone(),
                            v76_0_3.clone(),
                            v76_0_4.clone(),
                        )
                    }
                    Runtime::US5::US5_1(v76_1_0) => Runtime::US6::US6_1(v76_1_0.clone()),
                };
                let v104: Runtime::US6 = match &v90 {
                    Runtime::US6::US6_0(v90_0_0, v90_0_1, v90_0_2, v90_0_3, v90_0_4) => v90.clone(),
                    _ => Runtime::method28(
                        v1_1.get().clone(),
                        v2_1.get().clone(),
                        v3.get().clone(),
                        v4.get().clone(),
                        LrcPtr::new(Runtime::UH3::UH3_1(
                            Func1::new(
                                move |arg10_0040: (string, LrcPtr<StringBuilder>, i32, i32)| {
                                    Runtime::closure40((), arg10_0040)
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
                                        Runtime::closure41((), arg10_0040_1)
                                    },
                                ),
                                LrcPtr::new(Runtime::UH3::UH3_0),
                            )),
                        )),
                    ),
                };
                match &v104 {
                    Runtime::US6::US6_0(v104_0_0, v104_0_1, v104_0_2, v104_0_3, v104_0_4) => {
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
                        continue '_method26;
                    }
                    _ => Runtime::US15::US15_0(
                        Runtime::method29(v0_1.get().clone(), LrcPtr::new(Runtime::UH2::UH2_0)),
                        v1_1.get().clone(),
                        v2_1.get().clone(),
                        v3.get().clone(),
                        v4.get().clone(),
                    ),
                }
            });
        }
    }
    pub fn method30(v0_1: LrcPtr<Runtime::UH2>, v1_1: List<string>) -> List<string> {
        match v0_1.as_ref() {
            Runtime::UH2::UH2_0 => v1_1.clone(),
            Runtime::UH2::UH2_1(v0_1_1_0, v0_1_1_1) => cons(
                match v0_1.as_ref() {
                    Runtime::UH2::UH2_1(x, _) => x.clone(),
                    _ => unreachable!(),
                },
                Runtime::method30(
                    match v0_1.as_ref() {
                        Runtime::UH2::UH2_1(_, x) => x.clone(),
                        _ => unreachable!(),
                    },
                    v1_1.clone(),
                ),
            ),
        }
    }
    pub fn method31(
        v0_1: LrcPtr<Runtime::UH2>,
        v1_1: string,
        v2_1: LrcPtr<StringBuilder>,
        v3: i32,
        v4: i32,
    ) -> Runtime::US15 {
        let v0_1: MutCell<LrcPtr<Runtime::UH2>> = MutCell::new(v0_1.clone());
        let v1_1: MutCell<string> = MutCell::new(v1_1.clone());
        let v2_1: MutCell<LrcPtr<StringBuilder>> = MutCell::new(v2_1.clone());
        let v3: MutCell<i32> = MutCell::new(v3);
        let v4: MutCell<i32> = MutCell::new(v4);
        '_method31: loop {
            break '_method31 ({
                let v76: Runtime::US5 = if string("") == v1_1.get().clone() {
                    Runtime::US5::US5_1(sprintf!(
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
                    if Runtime::method27(v22, 0_i64) == false {
                        let v34: string = ofChar(v22);
                        let v37: i32 = length(v34.clone());
                        let v38: Array<char> = new_init(&'\u{0000}', v37);
                        let v39: LrcPtr<Runtime::Mut5> = LrcPtr::new(Runtime::Mut5 {
                            l0: MutCell::new(0_i32),
                        });
                        while Runtime::method11(v37, v39.clone()) {
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
                            let patternInput: (LrcPtr<StringBuilder>, i32, i32) = Runtime::method13(
                                foldBack(
                                    Func2::new(move |b0: char, b1: LrcPtr<Runtime::UH0>| {
                                        (Runtime::method12())(b0)(b1)
                                    }),
                                    v44,
                                    LrcPtr::new(Runtime::UH0::UH0_0),
                                ),
                                v2_1.get().clone(),
                                v3.get().clone(),
                                v4.get().clone(),
                            );
                            Runtime::US5::US5_0(
                                v22,
                                v29,
                                patternInput.0.clone(),
                                patternInput.1.clone(),
                                patternInput.2.clone(),
                            )
                        }
                    } else {
                        Runtime::US5::US5_1(sprintf!(
                            "parsing.none_of / unexpected char: \'{}\' / chars: {:?} / s: {:?}",
                            v22,
                            toArray(ofArray(new_array(&['\\', '`', '\"']))),
                            (v2_1.get().clone(), v3.get().clone(), v4.get().clone())
                        ))
                    }
                };
                let v90: Runtime::US6 = match &v76 {
                    Runtime::US5::US5_0(v76_0_0, v76_0_1, v76_0_2, v76_0_3, v76_0_4) => {
                        Runtime::US6::US6_0(
                            ofChar(v76_0_0.clone()),
                            v76_0_1.clone(),
                            v76_0_2.clone(),
                            v76_0_3.clone(),
                            v76_0_4.clone(),
                        )
                    }
                    Runtime::US5::US5_1(v76_1_0) => Runtime::US6::US6_1(v76_1_0.clone()),
                };
                match &v90 {
                    Runtime::US6::US6_0(v90_0_0, v90_0_1, v90_0_2, v90_0_3, v90_0_4) => {
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
                        continue '_method31;
                    }
                    _ => Runtime::US15::US15_0(
                        Runtime::method29(v0_1.get().clone(), LrcPtr::new(Runtime::UH2::UH2_0)),
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
                if getCharAt(v0_1.get().clone(), v1_1.get().clone()) == ' ' {
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
    pub fn method23(
        v0_1: LrcPtr<Runtime::UH2>,
        v1_1: string,
        v2_1: LrcPtr<StringBuilder>,
        v3: i32,
        v4: i32,
    ) -> Runtime::US15 {
        let v0_1: MutCell<LrcPtr<Runtime::UH2>> = MutCell::new(v0_1.clone());
        let v1_1: MutCell<string> = MutCell::new(v1_1.clone());
        let v2_1: MutCell<LrcPtr<StringBuilder>> = MutCell::new(v2_1.clone());
        let v3: MutCell<i32> = MutCell::new(v3);
        let v4: MutCell<i32> = MutCell::new(v4);
        '_method23: loop {
            break '_method23 ({
                let v5_1: bool = string("") == v1_1.get().clone();
                let v82: Runtime::US5 = if v5_1 {
                    Runtime::US5::US5_1(sprintf!(
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
                    if Runtime::method24(v25, 0_i64) == false {
                        let v37: string = ofChar(v25);
                        let v40: i32 = length(v37.clone());
                        let v41: Array<char> = new_init(&'\u{0000}', v40);
                        let v42: LrcPtr<Runtime::Mut5> = LrcPtr::new(Runtime::Mut5 {
                            l0: MutCell::new(0_i32),
                        });
                        while Runtime::method11(v40, v42.clone()) {
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
                            let patternInput: (LrcPtr<StringBuilder>, i32, i32) = Runtime::method13(
                                foldBack(
                                    Func2::new(move |b0: char, b1: LrcPtr<Runtime::UH0>| {
                                        (Runtime::method12())(b0)(b1)
                                    }),
                                    v47,
                                    LrcPtr::new(Runtime::UH0::UH0_0),
                                ),
                                v2_1.get().clone(),
                                v3.get().clone(),
                                v4.get().clone(),
                            );
                            Runtime::US5::US5_0(
                                v25,
                                v32,
                                patternInput.0.clone(),
                                patternInput.1.clone(),
                                patternInput.2.clone(),
                            )
                        }
                    } else {
                        Runtime::US5::US5_1(sprintf!(
                            "parsing.none_of / unexpected char: \'{}\' / chars: {:?} / s: {:?}",
                            v25,
                            toArray(ofArray(new_array(&['\\', '`', '\"', ' ']))),
                            (v2_1.get().clone(), v3.get().clone(), v4.get().clone())
                        ))
                    }
                };
                let v96: Runtime::US6 = match &v82 {
                    Runtime::US5::US5_0(v82_0_0, v82_0_1, v82_0_2, v82_0_3, v82_0_4) => {
                        Runtime::method25(
                            ofChar(v82_0_0.clone()),
                            v82_0_1.clone(),
                            v82_0_2.clone(),
                            v82_0_3.clone(),
                            v82_0_4.clone(),
                        )
                    }
                    Runtime::US5::US5_1(v82_1_0) => Runtime::US6::US6_1(v82_1_0.clone()),
                };
                let v341: Runtime::US6 = match &v96 {
                    Runtime::US6::US6_0(v96_0_0, v96_0_1, v96_0_2, v96_0_3, v96_0_4) => v96.clone(),
                    _ => {
                        let v165: Runtime::US5 = if v5_1 {
                            Runtime::US5::US5_1(sprintf!(
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
                                while Runtime::method11(v118, v120.clone()) {
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
                                        Runtime::method13(
                                            foldBack(
                                                Func2::new(
                                                    move |b0: char, b1: LrcPtr<Runtime::UH0>| {
                                                        (Runtime::method12())(b0)(b1)
                                                    },
                                                ),
                                                v125,
                                                LrcPtr::new(Runtime::UH0::UH0_0),
                                            ),
                                            v2_1.get().clone(),
                                            v3.get().clone(),
                                            v4.get().clone(),
                                        );
                                    Runtime::US5::US5_0(
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
                                Runtime::US5::US5_1(sprintf!("{}\n{}\n",
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
                        let v282: Runtime::US6 = match &v165 {
                            Runtime::US5::US5_0(
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
                                let v172: Runtime::US15 = Runtime::method26(
                                    LrcPtr::new(Runtime::UH2::UH2_0),
                                    v167.clone(),
                                    v168.clone(),
                                    v169,
                                    v170,
                                );
                                let v193: Runtime::US6 = match &v172 {
                                    Runtime::US15::US15_0(
                                        v172_0_0,
                                        v172_0_1,
                                        v172_0_2,
                                        v172_0_3,
                                        v172_0_4,
                                    ) => {
                                        let v179: List<string> =
                                            Runtime::method30(v172_0_0.clone(), empty::<string>());
                                        Runtime::US6::US6_0(
                                            join(
                                                string(""),
                                                toArray_1(delay(Func0::new({
                                                    let v179 = v179.clone();
                                                    move || {
                                                        map(
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
                                    Runtime::US15::US15_1(v172_1_0) => {
                                        Runtime::US6::US6_1(v172_1_0.clone())
                                    }
                                };
                                match &v193 {
                                    Runtime::US6::US6_0(
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
                                        let v262: Runtime::US5 = if string("") == v195.clone() {
                                            Runtime::US5::US5_1(sprintf!("parsing.p_char / unexpected end of input / s: {:?}",
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
                                                while Runtime::method11(v215, v217.clone()) {
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
                                                                             Runtime::method13(foldBack(Func2::new(move
                                                                                                                       |b0:
                                                                                                                            char,
                                                                                                                        b1:
                                                                                                                            LrcPtr<Runtime::UH0>|
                                                                                                                       (Runtime::method12())(b0)(b1)),
                                                                                                        v222,
                                                                                                        LrcPtr::new(Runtime::UH0::UH0_0)),
                                                                                               v196.clone(),
                                                                                               v197,
                                                                                               v198);
                                                    Runtime::US5::US5_0(
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
                                                Runtime::US5::US5_1(sprintf!("{}\n{}\n",
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
                                                             Runtime::US5::US5_0(v262_0_0,
                                                                                 v262_0_1,
                                                                                 v262_0_2,
                                                                                 v262_0_3,
                                                                                 v262_0_4)
                                                             =>
                                                             Runtime::US6::US6_0(v193_0_0.clone(),
                                                                                 v262_0_1.clone(),
                                                                                 v262_0_2.clone(),
                                                                                 v262_0_3.clone(),
                                                                                 v262_0_4.clone()),
                                                             Runtime::US5::US5_1(v262_1_0)
                                                             =>
                                                             Runtime::US6::US6_1(sprintf!("between / expected closing delimiter / e: {:?} / input: {:?} / rest1: {:?} / rest2: {:?}",
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
                                    _ => Runtime::US6::US6_1(string("between / expected content")),
                                }
                            }
                            Runtime::US5::US5_1(v165_1_0) => Runtime::US6::US6_1(v165_1_0.clone()),
                        };
                        match &v282 {
                            Runtime::US6::US6_0(
                                v282_0_0,
                                v282_0_1,
                                v282_0_2,
                                v282_0_3,
                                v282_0_4,
                            ) => v282.clone(),
                            _ => {
                                let v294: Runtime::US6 = Runtime::method28(
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
                                                Runtime::closure40((), arg10_0040)
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
                                                    Runtime::closure41((), arg10_0040_1)
                                                },
                                            ),
                                            LrcPtr::new(Runtime::UH3::UH3_0),
                                        )),
                                    )),
                                );
                                let v305: Runtime::US6 = match &v294 {
                                    Runtime::US6::US6_0(
                                        v294_0_0,
                                        v294_0_1,
                                        v294_0_2,
                                        v294_0_3,
                                        v294_0_4,
                                    ) => Runtime::US6::US6_0(
                                        string(""),
                                        v294_0_1.clone(),
                                        v294_0_2.clone(),
                                        v294_0_3.clone(),
                                        v294_0_4.clone(),
                                    ),
                                    Runtime::US6::US6_1(v294_1_0) => {
                                        Runtime::US6::US6_1(v294_1_0.clone())
                                    }
                                };
                                let v316: Runtime::US15 = match &v305 {
                                    Runtime::US6::US6_0(
                                        v305_0_0,
                                        v305_0_1,
                                        v305_0_2,
                                        v305_0_3,
                                        v305_0_4,
                                    ) => Runtime::method31(
                                        LrcPtr::new(Runtime::UH2::UH2_0),
                                        v305_0_1.clone(),
                                        v305_0_2.clone(),
                                        v305_0_3.clone(),
                                        v305_0_4.clone(),
                                    ),
                                    Runtime::US6::US6_1(v305_1_0) => {
                                        Runtime::US15::US15_1(v305_1_0.clone())
                                    }
                                };
                                match &v316 {
                                    Runtime::US15::US15_0(
                                        v316_0_0,
                                        v316_0_1,
                                        v316_0_2,
                                        v316_0_3,
                                        v316_0_4,
                                    ) => {
                                        let v323: List<string> =
                                            Runtime::method30(v316_0_0.clone(), empty::<string>());
                                        Runtime::US6::US6_0(
                                            join(
                                                string(""),
                                                toArray_1(delay(Func0::new({
                                                    let v323 = v323.clone();
                                                    move || {
                                                        map(
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
                                    Runtime::US15::US15_1(v316_1_0) => {
                                        Runtime::US6::US6_1(v316_1_0.clone())
                                    }
                                }
                            }
                        }
                    }
                };
                match &v341 {
                    Runtime::US6::US6_0(v341_0_0, v341_0_1, v341_0_2, v341_0_3, v341_0_4) => {
                        let v350: i32 = v341_0_4.clone();
                        let v349: i32 = v341_0_3.clone();
                        let v348: LrcPtr<StringBuilder> = v341_0_2.clone();
                        let v347: string = v341_0_1.clone();
                        let v346: string = v341_0_0.clone();
                        let v352: i32 = Runtime::method32(v347.clone(), 0_i32);
                        let v364: Runtime::US8 = if 0_i32 == v352 {
                            Runtime::US8::US8_1(string("spaces1 / expected at least one space"))
                        } else {
                            Runtime::US8::US8_0(
                                getSlice(v347.clone(), Some(v352), Some(length(v347.clone()))),
                                v348.clone(),
                                v349,
                                v350,
                            )
                        };
                        match &v364 {
                            Runtime::US8::US8_0(v364_0_0, v364_0_1, v364_0_2, v364_0_3) => {
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
                                continue '_method23;
                            }
                            _ => Runtime::US15::US15_0(
                                Runtime::method29(
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
                    _ => Runtime::US15::US15_0(
                        Runtime::method29(v0_1.get().clone(), LrcPtr::new(Runtime::UH2::UH2_0)),
                        v1_1.get().clone(),
                        v2_1.get().clone(),
                        v3.get().clone(),
                        v4.get().clone(),
                    ),
                }
            });
        }
    }
    pub fn method22(v0_1: string) -> Runtime::US14 {
        let _v0: MutCell<Option<Option<string>>> = MutCell::new(None::<Option<string>>);
        _v0.set(Some(Some(v0_1)));
        {
            let v15: Runtime::US15 = Runtime::method23(
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
            match &v15 {
                Runtime::US15::US15_0(v15_0_0, v15_0_1, v15_0_2, v15_0_3, v15_0_4) => {
                    Runtime::US14::US14_0(toArray(Runtime::method30(
                        v15_0_0.clone(),
                        empty::<string>(),
                    )))
                }
                Runtime::US15::US15_1(v15_1_0) => Runtime::US14::US14_1(v15_1_0.clone()),
            }
        }
    }
    pub fn closure39(unitVar: (), v0_1: string) -> Result<Array<string>, string> {
        let v1_1: Runtime::US14 = Runtime::method22(v0_1);
        match &v1_1 {
            Runtime::US14::US14_0(v1_1_0_0) => Ok::<Array<string>, string>(v1_1_0_0.clone()),
            Runtime::US14::US14_1(v1_1_1_0) => Err::<Array<string>, string>(v1_1_1_0.clone()),
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
    pub fn v5() -> Func0<()> {
        static v5: OnceInit<Func0<()>> = OnceInit::new();
        v5.get_or_init(|| Func0::new(move || Runtime::closure4((), ())))
            .clone()
    }
    pub fn current_process_kill() {
        (Runtime::v5())();
    }
    pub fn v6() -> Func1<string, Arc<Async<(i32, string)>>> {
        static v6: OnceInit<Func1<string, Arc<Async<(i32, string)>>>> = OnceInit::new();
        v6.get_or_init(|| Func1::new(move |v: string| Runtime::closure15((), v)))
            .clone()
    }
    pub fn execute_async(x: string) -> Arc<Async<(i32, string)>> {
        (Runtime::v6())(x)
    }
    pub fn v7() -> Func1<
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
        static v7: OnceInit<
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
        v7.get_or_init(|| {
            Func1::new(
                move |arg10_0040: (
                    string,
                    Option<CancellationToken>,
                    Array<(string, string)>,
                    Option<Func1<(i32, string, bool), Arc<Async<()>>>>,
                    Option<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
                    bool,
                    Option<string>,
                )| Runtime::closure37((), arg10_0040),
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
        (Runtime::v7())(x)
    }
    pub fn v8() -> Func1<
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
        static v8: OnceInit<
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
        v8.get_or_init(|| {
            Func1::new(
                move |v: Func1<LrcPtr<Runtime::Heap0>, LrcPtr<Runtime::Heap0>>| {
                    Runtime::closure38((), v)
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
        (Runtime::v8())(x)
    }
    pub fn v9() -> Func1<string, Result<Array<string>, string>> {
        static v9: OnceInit<Func1<string, Result<Array<string>, string>>> = OnceInit::new();
        v9.get_or_init(|| Func1::new(move |v: string| Runtime::closure39((), v)))
            .clone()
    }
    pub fn split_args(x: string) -> Result<Array<string>, string> {
        (Runtime::v9())(x)
    }
    on_startup!(());
}
