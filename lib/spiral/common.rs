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
    use fable_library_rust::String_::printfn;
    use fable_library_rust::String_::sprintf;
    use fable_library_rust::String_::string;
    use fable_library_rust::String_::toLower;
    use fable_library_rust::String_::trimEndChars;
    use fable_library_rust::String_::trimStartChars;
    use fable_library_rust::System::Exception;
    use fable_library_rust::System::Lazy_1;
    use fable_library_rust::TimeSpan_::TimeSpan;
    pub mod TraceState {
        use super::*;
        pub fn trace_state() -> LrcPtr<
            MutCell<
                Option<(
                    LrcPtr<Common::Mut0>,
                    LrcPtr<Common::Mut1>,
                    LrcPtr<Common::Mut2>,
                    LrcPtr<Common::Mut3>,
                    LrcPtr<Common::Mut4>,
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
                            LrcPtr<Common::Mut4>,
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
                            LrcPtr<Common::Mut4>,
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
    #[derive(Clone, Debug, Default, PartialEq, PartialOrd, Hash, Eq)]
    pub struct Mut3 {
        pub l0: MutCell<string>,
    }
    impl core::fmt::Display for Common::Mut3 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Debug, PartialEq, PartialOrd, Hash, Eq)]
    pub struct Mut4 {
        pub l0: MutCell<Common::US0>,
    }
    impl core::fmt::Display for Common::Mut4 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Debug, PartialEq, PartialOrd, Hash, Eq)]
    pub enum US1 {
        US1_0(string),
        US1_1,
    }
    impl core::fmt::Display for Common::US1 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Copy, Debug, PartialEq, PartialOrd, Hash, Eq)]
    pub enum US2 {
        US2_0(Common::US0),
        US2_1,
    }
    impl core::fmt::Display for Common::US2 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Copy, Debug, PartialEq, PartialOrd, Hash, Eq)]
    pub enum US3 {
        US3_0(i64),
        US3_1,
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
    impl core::fmt::Display for Common::US5 {
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
        v0_1: LrcPtr<MutCell<Option<Common::US1>>>,
        v1_1: Option<Common::US1>,
    ) -> LrcPtr<MutCell<Option<Common::US1>>> {
        v0_1.set(v1_1);
        v0_1
    }
    pub fn closure2(
        v0_1: Option<string>,
        v1_1: Func1<Option<Common::US1>, LrcPtr<MutCell<Option<Common::US1>>>>,
        unitVar: (),
    ) {
        {
            let value: LrcPtr<MutCell<Option<Common::US1>>> = v1_1(match &v0_1 {
                None => None::<Common::US1>,
                Some(v0_1_0_0) => {
                    let x: string = v0_1_0_0.clone();
                    Some((Func0::new({
                        let x = x.clone();
                        move || Common::US1::US1_0(x.clone())
                    }))())
                }
            });
            ()
        }
        ()
    }
    pub fn method2(v0_1: string) -> string {
        let v3: Result<std::string::String, std::env::VarError> = std::env::var(&*v0_1);
        let v5: bool = true;
        let _result_map_ = v3.map(|x| {
            //;
            let v7: std::string::String = x;
            let v9: string = fable_library_rust::String_::fromString(v7);
            let v11: bool = true;
            v9
        });
        let v13: Result<string, std::env::VarError> = _result_map_;
        let v14: string = Common::method3();
        v13.unwrap_or(v14)
    }
    pub fn method4() -> string {
        string("AUTOMATION")
    }
    pub fn closure3(unitVar: (), v0_1: string) {
        ();
    }
    pub fn method0(
        v0_1: Common::US0,
    ) -> (
        LrcPtr<Common::Mut0>,
        LrcPtr<Common::Mut1>,
        LrcPtr<Common::Mut2>,
        LrcPtr<Common::Mut3>,
        LrcPtr<Common::Mut4>,
        Option<i64>,
    ) {
        let v3: string = Common::method2(Common::method1());
        let v8: Common::US2 = if string("Verbose") == v3.clone() {
            Common::US2::US2_0(Common::US0::US0_0)
        } else {
            Common::US2::US2_1
        };
        let _v1: (Common::US2, Common::US3) = (
            match &v8 {
                Common::US2::US2_0(v8_0_0) => Common::US2::US2_0(match &v8 {
                    Common::US2::US2_0(x) => x.clone(),
                    _ => unreachable!(),
                }),
                _ => {
                    let v15: Common::US2 = if string("Debug") == v3.clone() {
                        Common::US2::US2_0(Common::US0::US0_1)
                    } else {
                        Common::US2::US2_1
                    };
                    match &v15 {
                        Common::US2::US2_0(v15_0_0) => Common::US2::US2_0(match &v15 {
                            Common::US2::US2_0(x) => x.clone(),
                            _ => unreachable!(),
                        }),
                        _ => {
                            let v22: Common::US2 = if string("Info") == v3.clone() {
                                Common::US2::US2_0(Common::US0::US0_2)
                            } else {
                                Common::US2::US2_1
                            };
                            match &v22 {
                                Common::US2::US2_0(v22_0_0) => Common::US2::US2_0(match &v22 {
                                    Common::US2::US2_0(x) => x.clone(),
                                    _ => unreachable!(),
                                }),
                                _ => {
                                    let v29: Common::US2 = if string("Warning") == v3.clone() {
                                        Common::US2::US2_0(Common::US0::US0_3)
                                    } else {
                                        Common::US2::US2_1
                                    };
                                    match &v29 {
                                        Common::US2::US2_0(v29_0_0) => {
                                            Common::US2::US2_0(match &v29 {
                                                Common::US2::US2_0(x) => x.clone(),
                                                _ => unreachable!(),
                                            })
                                        }
                                        _ => {
                                            let v36: Common::US2 =
                                                if string("Critical") == v3.clone() {
                                                    Common::US2::US2_0(Common::US0::US0_4)
                                                } else {
                                                    Common::US2::US2_1
                                                };
                                            match &v36 {
                                                Common::US2::US2_0(v36_0_0) => {
                                                    Common::US2::US2_0(match &v36 {
                                                        Common::US2::US2_0(x) => x.clone(),
                                                        _ => unreachable!(),
                                                    })
                                                }
                                                _ => Common::US2::US2_1,
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            },
            if Common::method2(Common::method4()) == string("True") {
                Common::US3::US3_0({
                    let _arg: DateTime = DateTime::now();
                    _arg.ticks()
                })
            } else {
                Common::US3::US3_1
            },
        );
        let v295: Common::US3 = _v1.1.clone();
        let v294: Common::US2 = _v1.0.clone();
        (
            LrcPtr::new(Common::Mut0 {
                l0: MutCell::new(0_i64),
            }),
            LrcPtr::new(Common::Mut1 {
                l0: MutCell::new(Func1::new(move |v: string| Common::closure3((), v))),
            }),
            LrcPtr::new(Common::Mut2 {
                l0: MutCell::new(true),
            }),
            LrcPtr::new(Common::Mut3 {
                l0: MutCell::new(string("")),
            }),
            LrcPtr::new(Common::Mut4 {
                l0: MutCell::new(match &v294 {
                    Common::US2::US2_0(v294_0_0) => match &v294 {
                        Common::US2::US2_0(x) => x.clone(),
                        _ => unreachable!(),
                    },
                    _ => v0_1,
                }),
            }),
            match &v295 {
                Common::US3::US3_0(v295_0_0) => Some(match &v295 {
                    Common::US3::US3_0(x) => x.clone(),
                    _ => unreachable!(),
                }),
                _ => None::<i64>,
            },
        )
    }
    pub fn closure0(unitVar: (), unitVar_1: ()) {
        if Common::TraceState::trace_state().get().clone().is_none() {
            let patternInput: (
                LrcPtr<Common::Mut0>,
                LrcPtr<Common::Mut1>,
                LrcPtr<Common::Mut2>,
                LrcPtr<Common::Mut3>,
                LrcPtr<Common::Mut4>,
                Option<i64>,
            ) = Common::method0(Common::US0::US0_0);
            Common::TraceState::trace_state().set(Some((
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
    pub fn method5(v0_1: Func0<()>) -> Func0<()> {
        v0_1
    }
    pub fn method6(v0_1: Func0<()>) -> Func0<()> {
        v0_1
    }
    pub fn closure4(unitVar: (), v0_1: Func0<()>) -> LrcPtr<dyn IDisposable> {
        let v2_1 = Common::method5(v0_1);
        interface_cast!(
            Common::Disposable::_ctor__3A5B6456(Func0::new({
                let v2_1 = v2_1.clone();
                move || v2_1.clone()()
            })),
            Lrc<dyn IDisposable>,
        )
    }
    pub fn closure7(unitVar: (), v0_1: Common::US4) -> Common::US5 {
        Common::US5::US5_0(v0_1)
    }
    pub fn closure8(v0_1: i32, v1_1: Func0<()>, v2_1: i32, unitVar: ()) -> Common::US4 {
        if v2_1 < v0_1 {
            v1_1();
            Common::US4::US4_0
        } else {
            Common::US4::US4_1
        }
    }
    pub fn closure11(v0_1: LrcPtr<Common::Mut0>, unitVar: ()) {
        let v2_1: i64 = v0_1.l0.get().clone() + 1_i64;
        v0_1.l0.set(v2_1);
        ()
    }
    pub fn closure12(
        v0_1: LrcPtr<MutCell<Option<Common::US3>>>,
        v1_1: Option<Common::US3>,
    ) -> LrcPtr<MutCell<Option<Common::US3>>> {
        v0_1.set(v1_1);
        v0_1
    }
    pub fn closure13(
        v0_1: Option<i64>,
        v1_1: Func1<Option<Common::US3>, LrcPtr<MutCell<Option<Common::US3>>>>,
        unitVar: (),
    ) {
        {
            let value: LrcPtr<MutCell<Option<Common::US3>>> = v1_1(match &v0_1 {
                None => None::<Common::US3>,
                Some(v0_1_0_0) => {
                    let x: i64 = v0_1_0_0.clone();
                    Some((Func0::new({
                        let x = x.clone();
                        move || Common::US3::US3_0(x)
                    }))())
                }
            });
            ()
        }
        ()
    }
    pub fn method8() -> string {
        string("hh:mm:ss")
    }
    pub fn method9() -> string {
        string("HH:mm:ss")
    }
    pub fn method10() -> string {
        string("\u{001b}[0m")
    }
    pub fn method11() -> string {
        string("")
    }
    pub fn closure14(v0_1: LrcPtr<Common::Mut3>, v1_1: string, unitVar: ()) {
        let v3: string = append(v0_1.l0.get().clone(), v1_1);
        v0_1.l0.set(v3);
        ()
    }
    pub fn closure16(v0_1: string, unitVar: ()) {
        printfn!("{0}", v0_1);
    }
    pub fn closure15(unitVar: (), v0_1: string) {
        let v3: () = {
            Common::closure16(v0_1, ());
            ()
        };
        ()
    }
    pub fn closure10(v0_1: i32, v1_1: LrcPtr<Exception>, unitVar: ()) {
        fn v3() {
            Common::closure0((), ());
        }
        let v4: () = {
            v3();
            ()
        };
        let patternInput: (
            LrcPtr<Common::Mut0>,
            LrcPtr<Common::Mut1>,
            LrcPtr<Common::Mut2>,
            LrcPtr<Common::Mut3>,
            LrcPtr<Common::Mut4>,
            Option<i64>,
        ) = getValue(Common::TraceState::trace_state().get().clone());
        let v37: () = {
            v3();
            ()
        };
        let patternInput_1: (
            LrcPtr<Common::Mut0>,
            LrcPtr<Common::Mut1>,
            LrcPtr<Common::Mut2>,
            LrcPtr<Common::Mut3>,
            LrcPtr<Common::Mut4>,
            Option<i64>,
        ) = getValue(Common::TraceState::trace_state().get().clone());
        let v69: Common::US0 = (patternInput_1.4.clone()).l0.get().clone();
        if if (patternInput_1.2.clone()).l0.get().clone() == false {
            false
        } else {
            3_i32
                >= find(
                    v69,
                    ofSeq(ofList(ofArray(new_array(&[
                        LrcPtr::new((Common::US0::US0_0, 0_i32)),
                        LrcPtr::new((Common::US0::US0_1, 1_i32)),
                        LrcPtr::new((Common::US0::US0_2, 2_i32)),
                        LrcPtr::new((Common::US0::US0_3, 3_i32)),
                        LrcPtr::new((Common::US0::US0_4, 4_i32)),
                    ])))),
                )
        } {
            let v77: () = {
                Common::closure11(patternInput.0.clone(), ());
                ()
            };
            let v81: () = {
                v3();
                ()
            };
            let patternInput_2: (
                LrcPtr<Common::Mut0>,
                LrcPtr<Common::Mut1>,
                LrcPtr<Common::Mut2>,
                LrcPtr<Common::Mut3>,
                LrcPtr<Common::Mut4>,
                Option<i64>,
            ) = getValue(Common::TraceState::trace_state().get().clone());
            let _v114: LrcPtr<MutCell<Option<Common::US3>>> = refCell(None::<Common::US3>);
            let v119: () = {
                Common::closure13(
                    patternInput_2.5.clone(),
                    Func1::new({
                        let _v114 = _v114.clone();
                        move |v: Option<Common::US3>| Common::closure12(_v114.clone(), v)
                    }),
                    (),
                );
                ()
            };
            let v134: Common::US3 = defaultValue(Common::US3::US3_1, _v114.get().clone());
            let v174: DateTime = match &v134 {
                Common::US3::US3_0(v134_0_0) => {
                    let v148: TimeSpan = TimeSpan::new_ticks(
                        {
                            let _arg: DateTime = DateTime::now();
                            _arg.ticks()
                        } - match &v134 {
                            Common::US3::US3_0(x) => x.clone(),
                            _ => unreachable!(),
                        },
                    );
                    DateTime::new_ymdhms_milli(
                        1_i32,
                        1_i32,
                        1_i32,
                        v148.hours(),
                        v148.minutes(),
                        v148.seconds(),
                        v148.milliseconds(),
                    )
                }
                _ => DateTime::now(),
            };
            let v179: string = {
                let provider: string = Common::method8();
                v174.toString(provider)
            };
            let v571: string = padLeft(toLower(string("Warning")), 7_i32, ' ');
            let v587: &str = inline_colorization::color_yellow;
            let v589: &str = &*v571;
            let v591: &str = inline_colorization::color_reset;
            let v593: string = string("format!(\"{v587}{v589}{v591}\")");
            let v594: std::string::String = format!("{v587}{v589}{v591}");
            let v596: string = fable_library_rust::String_::fromString(v594);
            let v637: i64 = (patternInput_2.0.clone()).l0.get().clone();
            let v639: LrcPtr<Common::Mut3> = LrcPtr::new(Common::Mut3 {
                l0: MutCell::new(Common::method11()),
            });
            let v646: () = {
                Common::closure14(v639.clone(), sprintf!("{}", string("{ ")), ());
                ()
            };
            let v655: () = {
                Common::closure14(v639.clone(), sprintf!("{}", string("retry")), ());
                ()
            };
            let v664: () = {
                Common::closure14(v639.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v672: () = {
                Common::closure14(v639.clone(), sprintf!("{}", v0_1), ());
                ()
            };
            let v681: () = {
                Common::closure14(v639.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v690: () = {
                Common::closure14(v639.clone(), sprintf!("{}", string("ex")), ());
                ()
            };
            let v698: () = {
                Common::closure14(v639.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v703: std::string::String = format!("{:#?}", v1_1);
            let v733: () = {
                Common::closure14(
                    v639.clone(),
                    sprintf!("{}", fable_library_rust::String_::fromString(v703)),
                    (),
                );
                ()
            };
            let v742: () = {
                Common::closure14(v639.clone(), sprintf!("{}", string(" }")), ());
                ()
            };
            let v784: string = trimEndChars(
                trimStartChars(
                    sprintf!(
                        "{} {} #{} {} / {}",
                        v179,
                        v596,
                        v637,
                        string("common.retry_fn"),
                        v639.l0.get().clone()
                    ),
                    toArray(empty::<char>()),
                ),
                toArray(ofArray(new_array(&[' ', '/']))),
            );
            println!("{}", v784.clone());
            ();
            ((patternInput.1.clone()).l0.get().clone())(v784)
        }
    }
    pub fn closure9(v0_1: i32, v1_1: LrcPtr<Exception>) -> Common::US5 {
        let v4: () = {
            Common::closure10(v0_1, v1_1, ());
            ()
        };
        Common::US5::US5_1
    }
    pub fn method7(v0_1: i32, v1_1: Func0<()>, v2_1: i32) -> Common::US4 {
        let v0_1: MutCell<i32> = MutCell::new(v0_1);
        let v1_1 = MutCell::new(v1_1.clone());
        let v2_1: MutCell<i32> = MutCell::new(v2_1);
        '_method7: loop {
            break '_method7 ({
                let result: LrcPtr<MutCell<Common::US5>> = refCell(Common::US5::US5_1);
                try_catch(
                    || {
                        result.set(Common::closure7(
                            (),
                            Common::closure8(
                                v0_1.get().clone(),
                                v1_1.get().clone(),
                                v2_1.get().clone(),
                                (),
                            ),
                        ))
                    },
                    |ex: LrcPtr<Exception>| {
                        result.set(Common::closure9(v2_1.get().clone(), ex.clone()))
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
                            continue '_method7;
                        }
                    }
                }
            });
        }
    }
    pub fn closure6(v0_1: i32, v1_1: Func0<()>) -> Option<()> {
        let v3: Common::US4 = Common::method7(v0_1, v1_1, 0_i32);
        match &v3 {
            Common::US4::US4_0 => Some(()),
            _ => None::<()>,
        }
    }
    pub fn closure5(unitVar: (), v0_1: i32) -> Func1<Func0<()>, Option<()>> {
        Func1::new({
            let v0_1 = v0_1.clone();
            move |v: Func0<()>| Common::closure6(v0_1, v)
        })
    }
    pub fn method12(v0_1: Func0<()>) -> Func0<()> {
        v0_1
    }
    pub fn closure18(v0_1: LrcPtr<Lazy_1<()>>, unitVar: ()) {
        v0_1.get_Value();
        ()
    }
    pub fn closure17(unitVar: (), v0_1: Func0<()>) -> Func0<()> {
        let v1_1 = Common::method12(v0_1);
        let v2_1: LrcPtr<Lazy_1<()>> = LazyExtensions::Create(Func0::new({
            let v1_1 = v1_1.clone();
            move || v1_1()
        }));
        Func0::new({
            let v2_1 = v2_1.clone();
            move || Common::closure18(v2_1.clone(), ())
        })
    }
    pub fn v0() -> () {
        static v0: OnceInit<()> = OnceInit::new();
        v0.get_or_init(|| ()).clone()
    }
    pub fn v1() -> Func0<()> {
        static v1: OnceInit<Func0<()>> = OnceInit::new();
        v1.get_or_init(|| Func0::new(move || Common::closure0((), ())))
            .clone()
    }
    pub fn v2() -> () {
        static v2: OnceInit<()> = OnceInit::new();
        v2.get_or_init(|| {
            (Common::v1())();
            Common::v0()
        })
        .clone()
    }
    pub fn v16() -> Func1<Func0<()>, LrcPtr<dyn IDisposable>> {
        static v16: OnceInit<Func1<Func0<()>, LrcPtr<dyn IDisposable>>> = OnceInit::new();
        v16.get_or_init(|| Func1::new(move |v: Func0<()>| Common::closure4((), v)))
            .clone()
    }
    pub fn new_disposable(x: Func0<()>) -> LrcPtr<dyn IDisposable> {
        (Common::v16())(x)
    }
    pub fn v17() -> Func1<i32, Func1<Func0<()>, Option<()>>> {
        static v17: OnceInit<Func1<i32, Func1<Func0<()>, Option<()>>>> = OnceInit::new();
        v17.get_or_init(|| Func1::new(move |v: i32| Common::closure5((), v)))
            .clone()
    }
    pub fn retry_fn(x: i32) -> Func1<Func0<()>, Option<()>> {
        (Common::v17())(x)
    }
    pub fn v18() -> Func1<Func0<()>, Func0<()>> {
        static v18: OnceInit<Func1<Func0<()>, Func0<()>>> = OnceInit::new();
        v18.get_or_init(|| Func1::new(move |v: Func0<()>| Common::closure17((), v)))
            .clone()
    }
    pub fn memoize(x: Func0<()>) -> Func0<()> {
        (Common::v18())(x)
    }
    on_startup!(());
}
