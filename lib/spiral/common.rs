pub mod Common {
    use super::*;
    use fable_library_rust::DateTime_::DateTime;
    use fable_library_rust::Exception_::try_catch;
    use fable_library_rust::FSharp::Control::LazyExtensions;
    use fable_library_rust::Interfaces_::System::Collections::Generic::IEnumerable_1;
    use fable_library_rust::Interfaces_::System::IDisposable;
    use fable_library_rust::List_::empty;
    use fable_library_rust::List_::ofArray;
    use fable_library_rust::List_::toArray;
    use fable_library_rust::Map_::find;
    use fable_library_rust::Map_::ofSeq;
    use fable_library_rust::NativeArray_::new_array;
    use fable_library_rust::Native_::interface_cast;
    use fable_library_rust::Native_::on_startup;
    use fable_library_rust::Native_::refCell;
    use fable_library_rust::Native_::Any;
    use fable_library_rust::Native_::Func0;
    use fable_library_rust::Native_::Func1;
    use fable_library_rust::Native_::Lrc;
    use fable_library_rust::Native_::LrcPtr;
    use fable_library_rust::Native_::MutCell;
    use fable_library_rust::Native_::OnceInit;
    use fable_library_rust::Option_::defaultValue;
    use fable_library_rust::Option_::getValue;
    use fable_library_rust::Seq_::ofList;
    use fable_library_rust::String_::append;
    use fable_library_rust::String_::padLeft;
    use fable_library_rust::String_::sprintf;
    use fable_library_rust::String_::string;
    use fable_library_rust::String_::toLower;
    use fable_library_rust::String_::trimEndChars;
    use fable_library_rust::String_::trimStartChars;
    use fable_library_rust::System::Exception;
    use fable_library_rust::System::Lazy_1;
    use fable_library_rust::TimeSpan_::TimeSpan;
    pub mod State {
        use super::*;
        pub fn trace_state() -> LrcPtr<
            MutCell<
                Option<(
                    LrcPtr<Common::Mut0>,
                    LrcPtr<Common::Mut1>,
                    LrcPtr<Common::Mut2>,
                    LrcPtr<Common::Mut3>,
                    Option<i64>,
                )>,
            >,
        > {
            static trace_state: OnceInit<
                LrcPtr<
                    MutCell<
                        Option<(
                            LrcPtr<Common::Mut0>,
                            LrcPtr<Common::Mut1>,
                            LrcPtr<Common::Mut2>,
                            LrcPtr<Common::Mut3>,
                            Option<i64>,
                        )>,
                    >,
                >,
            > = OnceInit::new();
            trace_state
                .get_or_init(|| {
                    LrcPtr::new(MutCell::new(
                        None::<(
                            LrcPtr<Common::Mut0>,
                            LrcPtr<Common::Mut1>,
                            LrcPtr<Common::Mut2>,
                            LrcPtr<Common::Mut3>,
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
    #[derive(Clone, Debug)]
    pub struct Disposable {
        f: Func0<()>,
    }
    impl Common::Disposable {
        pub fn _ctor__3A5B6456(f: Func0<()>) -> LrcPtr<Common::Disposable> {
            let f_1;
            ();
            f_1 = f;
            ();
            LrcPtr::new(Common::Disposable { f: f_1 })
        }
    }
    impl core::fmt::Display for Common::Disposable {
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
    impl Common::US0 {
        pub fn get_IsUS0_0(this_: &MutCell<Common::US0>, unitArg: ()) -> bool {
            if unreachable!() {
                true
            } else {
                false
            }
        }
        pub fn get_IsUS0_1(this_: &MutCell<Common::US0>, unitArg: ()) -> bool {
            if unreachable!() {
                true
            } else {
                false
            }
        }
        pub fn get_IsUS0_2(this_: &MutCell<Common::US0>, unitArg: ()) -> bool {
            if unreachable!() {
                true
            } else {
                false
            }
        }
        pub fn get_IsUS0_3(this_: &MutCell<Common::US0>, unitArg: ()) -> bool {
            if unreachable!() {
                true
            } else {
                false
            }
        }
        pub fn get_IsUS0_4(this_: &MutCell<Common::US0>, unitArg: ()) -> bool {
            if unreachable!() {
                true
            } else {
                false
            }
        }
    }
    impl core::fmt::Display for Common::US0 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Debug, Default, PartialEq, PartialOrd, Hash, Eq)]
    pub struct Mut0 {
        pub l0: MutCell<i64>,
    }
    impl core::fmt::Display for Common::Mut0 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Debug)]
    pub struct Mut1 {
        pub l0: MutCell<Func1<string, ()>>,
    }
    impl core::fmt::Display for Common::Mut1 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Debug, Default, PartialEq, PartialOrd, Hash, Eq)]
    pub struct Mut2 {
        pub l0: MutCell<bool>,
    }
    impl core::fmt::Display for Common::Mut2 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Debug, PartialEq, PartialOrd, Hash, Eq)]
    pub struct Mut3 {
        pub l0: MutCell<Common::US0>,
    }
    impl core::fmt::Display for Common::Mut3 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Copy, Debug, PartialEq, PartialOrd, Hash, Eq)]
    pub enum US1 {
        US1_0(Common::US0),
        US1_1,
    }
    impl Common::US1 {
        pub fn get_IsUS1_0(this_: &MutCell<Common::US1>, unitArg: ()) -> bool {
            if unreachable!() {
                true
            } else {
                false
            }
        }
        pub fn get_IsUS1_1(this_: &MutCell<Common::US1>, unitArg: ()) -> bool {
            if unreachable!() {
                true
            } else {
                false
            }
        }
    }
    impl core::fmt::Display for Common::US1 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Copy, Debug, PartialEq, PartialOrd, Hash, Eq)]
    pub enum US2 {
        US2_0(i64),
        US2_1,
    }
    impl Common::US2 {
        pub fn get_IsUS2_0(this_: &MutCell<Common::US2>, unitArg: ()) -> bool {
            if unreachable!() {
                true
            } else {
                false
            }
        }
        pub fn get_IsUS2_1(this_: &MutCell<Common::US2>, unitArg: ()) -> bool {
            if unreachable!() {
                true
            } else {
                false
            }
        }
    }
    impl core::fmt::Display for Common::US2 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Debug, PartialEq, PartialOrd, Hash, Eq)]
    pub enum US3 {
        US3_0(string),
        US3_1,
    }
    impl Common::US3 {
        pub fn get_IsUS3_0(this_: &MutCell<Common::US3>, unitArg: ()) -> bool {
            if unreachable!() {
                true
            } else {
                false
            }
        }
        pub fn get_IsUS3_1(this_: &MutCell<Common::US3>, unitArg: ()) -> bool {
            if unreachable!() {
                true
            } else {
                false
            }
        }
    }
    impl core::fmt::Display for Common::US3 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Copy, Debug, PartialEq, PartialOrd, Hash, Eq)]
    pub enum US4 {
        US4_0,
        US4_1,
    }
    impl Common::US4 {
        pub fn get_IsUS4_0(this_: &MutCell<Common::US4>, unitArg: ()) -> bool {
            if unreachable!() {
                true
            } else {
                false
            }
        }
        pub fn get_IsUS4_1(this_: &MutCell<Common::US4>, unitArg: ()) -> bool {
            if unreachable!() {
                true
            } else {
                false
            }
        }
    }
    impl core::fmt::Display for Common::US4 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Copy, Debug, PartialEq, PartialOrd, Hash, Eq)]
    pub enum US5 {
        US5_0(Common::US4),
        US5_1,
    }
    impl Common::US5 {
        pub fn get_IsUS5_0(this_: &MutCell<Common::US5>, unitArg: ()) -> bool {
            if unreachable!() {
                true
            } else {
                false
            }
        }
        pub fn get_IsUS5_1(this_: &MutCell<Common::US5>, unitArg: ()) -> bool {
            if unreachable!() {
                true
            } else {
                false
            }
        }
    }
    impl core::fmt::Display for Common::US5 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Debug, Default, PartialEq, PartialOrd, Hash, Eq)]
    pub struct Mut4 {
        pub l0: MutCell<string>,
    }
    impl core::fmt::Display for Common::Mut4 {
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
        let v3_1: Result<std::string::String, std::env::VarError> = std::env::var(&*v0_1);
        let v5: bool = true;
        let _result = v3_1.map(|x| {
            //;
            let v7: std::string::String = x;
            let v9: string = fable_library_rust::String_::fromString(v7);
            let v11: bool = true;
            v9
        });
        let v13: Result<string, std::env::VarError> = _result;
        let v14: string = Common::method2();
        {
            let x: string = v13.unwrap_or(v14);
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
        v0_1: Common::US0,
    ) -> (
        LrcPtr<Common::Mut0>,
        LrcPtr<Common::Mut1>,
        LrcPtr<Common::Mut2>,
        LrcPtr<Common::Mut3>,
        Option<i64>,
    ) {
        let _v1: MutCell<Option<(Common::US1, Common::US2)>> =
            MutCell::new(None::<(Common::US1, Common::US2)>);
        let v3_1: string = Common::method1(Common::method0());
        let v9: Common::US1 = if string("Verbose") == v3_1.clone() {
            Common::US1::US1_0(Common::US0::US0_0)
        } else {
            Common::US1::US1_1
        };
        {
            let x: (Common::US1, Common::US2) = (
                match &v9 {
                    Common::US1::US1_0(v9_0_0) => Common::US1::US1_0(match &v9 {
                        Common::US1::US1_0(x) => x.clone(),
                        _ => unreachable!(),
                    }),
                    _ => {
                        let v17: Common::US1 = if string("Debug") == v3_1.clone() {
                            Common::US1::US1_0(Common::US0::US0_1)
                        } else {
                            Common::US1::US1_1
                        };
                        match &v17 {
                            Common::US1::US1_0(v17_0_0) => Common::US1::US1_0(match &v17 {
                                Common::US1::US1_0(x) => x.clone(),
                                _ => unreachable!(),
                            }),
                            _ => {
                                let v25: Common::US1 = if string("Info") == v3_1.clone() {
                                    Common::US1::US1_0(Common::US0::US0_2)
                                } else {
                                    Common::US1::US1_1
                                };
                                match &v25 {
                                    Common::US1::US1_0(v25_0_0) => Common::US1::US1_0(match &v25 {
                                        Common::US1::US1_0(x) => x.clone(),
                                        _ => unreachable!(),
                                    }),
                                    _ => {
                                        let v33: Common::US1 = if string("Warning") == v3_1.clone()
                                        {
                                            Common::US1::US1_0(Common::US0::US0_3)
                                        } else {
                                            Common::US1::US1_1
                                        };
                                        match &v33 {
                                            Common::US1::US1_0(v33_0_0) => {
                                                Common::US1::US1_0(match &v33 {
                                                    Common::US1::US1_0(x) => x.clone(),
                                                    _ => unreachable!(),
                                                })
                                            }
                                            _ => {
                                                let v41: Common::US1 =
                                                    if string("Critical") == v3_1.clone() {
                                                        Common::US1::US1_0(Common::US0::US0_4)
                                                    } else {
                                                        Common::US1::US1_1
                                                    };
                                                match &v41 {
                                                    Common::US1::US1_0(v41_0_0) => {
                                                        Common::US1::US1_0(match &v41 {
                                                            Common::US1::US1_0(x) => x.clone(),
                                                            _ => unreachable!(),
                                                        })
                                                    }
                                                    _ => Common::US1::US1_1,
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                },
                if Common::method1(Common::method3()) == string("True") {
                    Common::US2::US2_0({
                        let _arg: DateTime = DateTime::now();
                        _arg.ticks()
                    })
                } else {
                    Common::US2::US2_1
                },
            );
            _v1.set(Some(x))
        }
        {
            let patternInput: (Common::US1, Common::US2) = match &_v1.get().clone() {
                None => panic!("{}", string("base.run_target / _v1=None"),),
                Some(_v1_0_0) => _v1_0_0.clone(),
            };
            let v259: Common::US2 = patternInput.1.clone();
            let v258: Common::US1 = patternInput.0.clone();
            (
                LrcPtr::new(Common::Mut0 {
                    l0: MutCell::new(0_i64),
                }),
                LrcPtr::new(Common::Mut1 {
                    l0: MutCell::new(Func1::new(move |v: string| Common::closure1((), v))),
                }),
                LrcPtr::new(Common::Mut2 {
                    l0: MutCell::new(true),
                }),
                LrcPtr::new(Common::Mut3 {
                    l0: MutCell::new(match &v258 {
                        Common::US1::US1_0(v258_0_0) => match &v258 {
                            Common::US1::US1_0(x) => x.clone(),
                            _ => unreachable!(),
                        },
                        _ => v0_1,
                    }),
                }),
                match &v259 {
                    Common::US2::US2_0(v259_0_0) => Some(match &v259 {
                        Common::US2::US2_0(x) => x.clone(),
                        _ => unreachable!(),
                    }),
                    _ => None::<i64>,
                },
            )
        }
    }
    pub fn method4(v0_1: Func0<()>) -> Func0<()> {
        v0_1
    }
    pub fn method5(v0_1: Func0<()>) -> Func0<()> {
        v0_1
    }
    pub fn closure2(unitVar: (), v0_1: Func0<()>) -> LrcPtr<dyn IDisposable> {
        let _v1: MutCell<Option<LrcPtr<dyn IDisposable>>> =
            MutCell::new(None::<LrcPtr<dyn IDisposable>>);
        let v2_1 = Common::method4(v0_1);
        {
            let x: LrcPtr<dyn IDisposable> = interface_cast!(
                Common::Disposable::_ctor__3A5B6456(Func0::new({
                    let v2_1 = v2_1.clone();
                    move || v2_1.clone()()
                })),
                Lrc<dyn IDisposable>,
            );
            _v1.set(Some(x))
        }
        match &_v1.get().clone() {
            None => panic!("{}", string("base.run_target / _v1=None"),),
            Some(_v1_0_0) => _v1_0_0.clone(),
        }
    }
    pub fn closure5(unitVar: (), v0_1: Common::US4) -> Common::US5 {
        Common::US5::US5_0(v0_1)
    }
    pub fn closure6(v0_1: i32, v1_1: Func0<()>, v2_1: i32, unitVar: ()) -> Common::US4 {
        if v2_1 < v0_1 {
            v1_1();
            Common::US4::US4_0
        } else {
            Common::US4::US4_1
        }
    }
    pub fn closure8(unitVar: (), unitVar_1: ()) -> string {
        string("common.retry_fn")
    }
    pub fn closure9(v0_1: i32, v1_1: LrcPtr<Exception>, unitVar: ()) -> (i32, LrcPtr<Exception>) {
        (v0_1, v1_1)
    }
    pub fn method8() -> string {
        string("hh:mm:ss")
    }
    pub fn method9() -> string {
        string("")
    }
    pub fn method10() -> string {
        string("HH:mm:ss")
    }
    pub fn method11() -> string {
        string("\u{001b}[0m")
    }
    pub fn method13(v0_1: LrcPtr<Common::Mut4>, v1_1: string) {
        let v2_1: string = sprintf!("{}", v1_1);
        let v4_1: string = append(v0_1.l0.get().clone(), v2_1);
        v0_1.l0.set(v4_1);
        ()
    }
    pub fn method14(v0_1: LrcPtr<Common::Mut4>) {
        ();
    }
    pub fn method15(v0_1: LrcPtr<Common::Mut4>, v1_1: i32) {
        let v2_1: string = sprintf!("{}", v1_1);
        let v4_1: string = append(v0_1.l0.get().clone(), v2_1);
        v0_1.l0.set(v4_1);
        ()
    }
    pub fn method16(v0_1: LrcPtr<Common::Mut4>, v1_1: LrcPtr<Exception>) {
        Common::method13(v0_1, sprintf!("{:?}", v1_1));
    }
    pub fn method12(v0_1: LrcPtr<Common::Mut4>, v1_1: i32, v2_1: LrcPtr<Exception>) {
        Common::method13(v0_1.clone(), string("{ "));
        Common::method14(v0_1.clone());
        Common::method13(v0_1.clone(), string("retry"));
        Common::method13(v0_1.clone(), string(" = "));
        Common::method15(v0_1.clone(), v1_1);
        Common::method13(v0_1.clone(), string("; "));
        Common::method13(v0_1.clone(), string("ex"));
        Common::method13(v0_1.clone(), string(" = "));
        Common::method16(v0_1.clone(), v2_1);
        Common::method13(v0_1, string(" }"))
    }
    pub fn closure10(
        v0_1: Common::US0,
        v1_1: Func0<string>,
        v2_1: Func0<(i32, LrcPtr<Exception>)>,
        unitVar: (),
    ) -> string {
        if Common::State::trace_state().get().clone().is_none() {
            Common::State::trace_state().set(Some(Common::closure0((), Common::US0::US0_0)));
        }
        {
            let patternInput: (
                LrcPtr<Common::Mut0>,
                LrcPtr<Common::Mut1>,
                LrcPtr<Common::Mut2>,
                LrcPtr<Common::Mut3>,
                Option<i64>,
            ) = getValue(Common::State::trace_state().get().clone());
            let v9: Option<i64> = patternInput.4.clone();
            let _v10: MutCell<Option<string>> = MutCell::new(None::<string>);
            let _v11: LrcPtr<MutCell<Option<Common::US2>>> = refCell(None::<Common::US2>);
            {
                let x_2: Option<Common::US2> = match &v9 {
                    None => None::<Common::US2>,
                    Some(v9_0_0) => {
                        let x: i64 = v9_0_0.clone();
                        Some((Func0::new({
                            let x = x.clone();
                            move || Common::US2::US2_0(x)
                        }))())
                    }
                };
                _v11.set(x_2)
            }
            {
                let v16: Common::US2 = defaultValue(Common::US2::US2_1, _v11.get().clone());
                let v35: DateTime = match &v16 {
                    Common::US2::US2_0(v16_0_0) => {
                        let v23: TimeSpan = TimeSpan::new_ticks(
                            {
                                let _arg: DateTime = DateTime::now();
                                _arg.ticks()
                            } - match &v16 {
                                Common::US2::US2_0(x) => x.clone(),
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
                {
                    let x_3: string = {
                        let provider: string = Common::method8();
                        v35.toString(provider)
                    };
                    _v10.set(Some(x_3))
                }
                {
                    let v152: string = match &_v10.get().clone() {
                        None => panic!("{}", string("base.run_target / _v10=None"),),
                        Some(_v10_0_0) => _v10_0_0.clone(),
                    };
                    let v159: Common::US3 = if if let Common::US0::US0_0 = &v0_1 {
                        true
                    } else {
                        false
                    } {
                        Common::US3::US3_0(string("Verbose"))
                    } else {
                        Common::US3::US3_1
                    };
                    let v208: Common::US3 = match &v159 {
                        Common::US3::US3_0(v159_0_0) => Common::US3::US3_0(match &v159 {
                            Common::US3::US3_0(x) => x.clone(),
                            _ => unreachable!(),
                        }),
                        _ => {
                            let v168: Common::US3 = if if let Common::US0::US0_1 = &v0_1 {
                                true
                            } else {
                                false
                            } {
                                Common::US3::US3_0(string("Debug"))
                            } else {
                                Common::US3::US3_1
                            };
                            match &v168 {
                                Common::US3::US3_0(v168_0_0) => Common::US3::US3_0(match &v168 {
                                    Common::US3::US3_0(x) => x.clone(),
                                    _ => unreachable!(),
                                }),
                                _ => {
                                    let v177: Common::US3 = if if let Common::US0::US0_2 = &v0_1 {
                                        true
                                    } else {
                                        false
                                    } {
                                        Common::US3::US3_0(string("Info"))
                                    } else {
                                        Common::US3::US3_1
                                    };
                                    match &v177 {
                                        Common::US3::US3_0(v177_0_0) => {
                                            Common::US3::US3_0(match &v177 {
                                                Common::US3::US3_0(x) => x.clone(),
                                                _ => unreachable!(),
                                            })
                                        }
                                        _ => {
                                            let v186: Common::US3 =
                                                if if let Common::US0::US0_3 = &v0_1 {
                                                    true
                                                } else {
                                                    false
                                                } {
                                                    Common::US3::US3_0(string("Warning"))
                                                } else {
                                                    Common::US3::US3_1
                                                };
                                            match &v186 {
                                                Common::US3::US3_0(v186_0_0) => {
                                                    Common::US3::US3_0(match &v186 {
                                                        Common::US3::US3_0(x) => x.clone(),
                                                        _ => unreachable!(),
                                                    })
                                                }
                                                _ => {
                                                    let v195: Common::US3 =
                                                        if if let Common::US0::US0_4 = &v0_1 {
                                                            true
                                                        } else {
                                                            false
                                                        } {
                                                            Common::US3::US3_0(string("Critical"))
                                                        } else {
                                                            Common::US3::US3_1
                                                        };
                                                    match &v195 {
                                                        Common::US3::US3_0(v195_0_0) => {
                                                            Common::US3::US3_0(match &v195 {
                                                                Common::US3::US3_0(x) => x.clone(),
                                                                _ => unreachable!(),
                                                            })
                                                        }
                                                        _ => Common::US3::US3_1,
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
                            Common::US3::US3_0(v208_0_0) => match &v208 {
                                Common::US3::US3_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                            _ => panic!("{}", string("Option does not have a value."),),
                        }),
                        7_i32,
                        ' ',
                    );
                    let _v216: MutCell<Option<string>> = MutCell::new(None::<string>);
                    let v231: &str = match &v0_1 {
                        Common::US0::US0_1 => inline_colorization::color_bright_blue,
                        Common::US0::US0_2 => inline_colorization::color_bright_green,
                        Common::US0::US0_0 => inline_colorization::color_bright_black,
                        Common::US0::US0_3 => inline_colorization::color_yellow,
                        _ => inline_colorization::color_bright_red,
                    };
                    let v233: &str = &*v215;
                    let v235: &str = inline_colorization::color_reset;
                    let v237: string = string("format!(\"{v231}{v233}{v235}\")");
                    let v238: std::string::String = format!("{v231}{v233}{v235}");
                    {
                        let x_5: string = fable_library_rust::String_::fromString(v238);
                        _v216.set(Some(x_5))
                    }
                    {
                        let v328: string = match &_v216.get().clone() {
                            None => panic!("{}", string("base.run_target / _v216=None"),),
                            Some(_v216_0_0) => _v216_0_0.clone(),
                        };
                        let v329: i64 = (patternInput.0.clone()).l0.get().clone();
                        let patternInput_1: (i32, LrcPtr<Exception>) = v2_1();
                        let v333: LrcPtr<Common::Mut4> = LrcPtr::new(Common::Mut4 {
                            l0: MutCell::new(string("")),
                        });
                        Common::method12(
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
    pub fn method17(v0_1: Common::US0, v1_1: Func0<string>) {
        fn v2_1(
            v: Common::US0,
        ) -> (
            LrcPtr<Common::Mut0>,
            LrcPtr<Common::Mut1>,
            LrcPtr<Common::Mut2>,
            LrcPtr<Common::Mut3>,
            Option<i64>,
        ) {
            Common::closure0((), v)
        }
        if Common::State::trace_state().get().clone().is_none() {
            Common::State::trace_state().set(Some(v2_1(Common::US0::US0_0)));
        }
        {
            let patternInput: (
                LrcPtr<Common::Mut0>,
                LrcPtr<Common::Mut1>,
                LrcPtr<Common::Mut2>,
                LrcPtr<Common::Mut3>,
                Option<i64>,
            ) = getValue(Common::State::trace_state().get().clone());
            let v4_1: LrcPtr<Common::Mut0> = patternInput.0.clone();
            if Common::State::trace_state().get().clone().is_none() {
                Common::State::trace_state().set(Some(v2_1(Common::US0::US0_0)));
            }
            {
                let patternInput_1: (
                    LrcPtr<Common::Mut0>,
                    LrcPtr<Common::Mut1>,
                    LrcPtr<Common::Mut2>,
                    LrcPtr<Common::Mut3>,
                    Option<i64>,
                ) = getValue(Common::State::trace_state().get().clone());
                let v15: Common::US0 = (patternInput_1.3.clone()).l0.get().clone();
                if if (patternInput_1.2.clone()).l0.get().clone() == false {
                    false
                } else {
                    find(
                        v0_1,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Common::US0::US0_0, 0_i32)),
                            LrcPtr::new((Common::US0::US0_1, 1_i32)),
                            LrcPtr::new((Common::US0::US0_2, 2_i32)),
                            LrcPtr::new((Common::US0::US0_3, 3_i32)),
                            LrcPtr::new((Common::US0::US0_4, 4_i32)),
                        ])))),
                    ) >= find(
                        v15,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Common::US0::US0_0, 0_i32)),
                            LrcPtr::new((Common::US0::US0_1, 1_i32)),
                            LrcPtr::new((Common::US0::US0_2, 2_i32)),
                            LrcPtr::new((Common::US0::US0_3, 3_i32)),
                            LrcPtr::new((Common::US0::US0_4, 4_i32)),
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
    pub fn method7(v0_1: Common::US0, v1_1: Func0<string>, v2_1: Func0<(i32, LrcPtr<Exception>)>) {
        Common::method17(
            v0_1.clone(),
            Func0::new({
                let v0_1 = v0_1.clone();
                let v1_1 = v1_1.clone();
                let v2_1 = v2_1.clone();
                move || Common::closure10(v0_1.clone(), v1_1.clone(), v2_1.clone(), ())
            }),
        );
    }
    pub fn closure7(v0_1: i32, v1_1: LrcPtr<Exception>) -> Common::US5 {
        Common::method7(
            Common::US0::US0_3,
            Func0::new(move || Common::closure8((), ())),
            Func0::new({
                let v0_1 = v0_1.clone();
                let v1_1 = v1_1.clone();
                move || Common::closure9(v0_1, v1_1.clone(), ())
            }),
        );
        Common::US5::US5_1
    }
    pub fn method6(v0_1: i32, v1_1: Func0<()>, v2_1: i32) -> Common::US4 {
        let v0_1: MutCell<i32> = MutCell::new(v0_1);
        let v1_1 = MutCell::new(v1_1.clone());
        let v2_1: MutCell<i32> = MutCell::new(v2_1);
        '_method6: loop {
            break '_method6 ({
                let result: LrcPtr<MutCell<Common::US5>> = refCell(Common::US5::US5_1);
                try_catch(
                    || {
                        result.set(Common::closure5(
                            (),
                            Common::closure6(
                                v0_1.get().clone(),
                                v1_1.get().clone(),
                                v2_1.get().clone(),
                                (),
                            ),
                        ))
                    },
                    |ex: LrcPtr<Exception>| {
                        result.set(Common::closure7(v2_1.get().clone(), ex.clone()))
                    },
                );
                {
                    let v7: Common::US5 = result.get().clone();
                    match &v7 {
                        Common::US5::US5_0(v7_0_0) => match &v7 {
                            Common::US5::US5_0(x) => x.clone(),
                            _ => unreachable!(),
                        },
                        _ => {
                            let v0_1_temp: i32 = v0_1.get().clone();
                            let v1_1_temp = v1_1.get().clone();
                            let v2_1_temp: i32 = v2_1.get().clone() + 1_i32;
                            v0_1.set(v0_1_temp);
                            v1_1.set(v1_1_temp);
                            v2_1.set(v2_1_temp);
                            continue '_method6;
                        }
                    }
                }
            });
        }
    }
    pub fn closure4(v0_1: i32, v1_1: Func0<()>) -> Option<()> {
        let v3_1: Common::US4 = Common::method6(v0_1, v1_1, 0_i32);
        match &v3_1 {
            Common::US4::US4_0 => Some(()),
            _ => None::<()>,
        }
    }
    pub fn closure3(unitVar: (), v0_1: i32) -> Func1<Func0<()>, Option<()>> {
        Func1::new({
            let v0_1 = v0_1.clone();
            move |v: Func0<()>| Common::closure4(v0_1, v)
        })
    }
    pub fn method18(v0_1: Func0<()>) -> Func0<()> {
        v0_1
    }
    pub fn closure12(v0_1: LrcPtr<Lazy_1<()>>, unitVar: ()) {
        v0_1.get_Value();
        ()
    }
    pub fn closure11(unitVar: (), v0_1: Func0<()>) -> Func0<()> {
        let v1_1 = Common::method18(v0_1);
        let v2_1: LrcPtr<Lazy_1<()>> = LazyExtensions::Create(Func0::new({
            let v1_1 = v1_1.clone();
            move || v1_1()
        }));
        Func0::new({
            let v2_1 = v2_1.clone();
            move || Common::closure12(v2_1.clone(), ())
        })
    }
    pub fn v0() -> Func1<
        Common::US0,
        (
            LrcPtr<Common::Mut0>,
            LrcPtr<Common::Mut1>,
            LrcPtr<Common::Mut2>,
            LrcPtr<Common::Mut3>,
            Option<i64>,
        ),
    > {
        static v0: OnceInit<
            Func1<
                Common::US0,
                (
                    LrcPtr<Common::Mut0>,
                    LrcPtr<Common::Mut1>,
                    LrcPtr<Common::Mut2>,
                    LrcPtr<Common::Mut3>,
                    Option<i64>,
                ),
            >,
        > = OnceInit::new();
        v0.get_or_init(|| Func1::new(move |v: Common::US0| Common::closure0((), v)))
            .clone()
    }
    pub fn v1() -> Common::US0 {
        static v1: OnceInit<Common::US0> = OnceInit::new();
        v1.get_or_init(|| Common::US0::US0_0).clone()
    }
    on_startup!(if Common::State::trace_state().get().clone().is_none() {
        Common::State::trace_state().set(Some((Common::v0())(Common::v1())));
    });
    pub fn v2() -> Func1<Func0<()>, LrcPtr<dyn IDisposable>> {
        static v2: OnceInit<Func1<Func0<()>, LrcPtr<dyn IDisposable>>> = OnceInit::new();
        v2.get_or_init(|| Func1::new(move |v: Func0<()>| Common::closure2((), v)))
            .clone()
    }
    pub fn new_disposable(x: Func0<()>) -> LrcPtr<dyn IDisposable> {
        (Common::v2())(x)
    }
    pub fn v3() -> Func1<i32, Func1<Func0<()>, Option<()>>> {
        static v3: OnceInit<Func1<i32, Func1<Func0<()>, Option<()>>>> = OnceInit::new();
        v3.get_or_init(|| Func1::new(move |v: i32| Common::closure3((), v)))
            .clone()
    }
    pub fn retry_fn(x: i32) -> Func1<Func0<()>, Option<()>> {
        (Common::v3())(x)
    }
    pub fn v4() -> Func1<Func0<()>, Func0<()>> {
        static v4: OnceInit<Func1<Func0<()>, Func0<()>>> = OnceInit::new();
        v4.get_or_init(|| Func1::new(move |v: Func0<()>| Common::closure11((), v)))
            .clone()
    }
    pub fn memoize(x: Func0<()>) -> Func0<()> {
        (Common::v4())(x)
    }
    on_startup!(());
}
