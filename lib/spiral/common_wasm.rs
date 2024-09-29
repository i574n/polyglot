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
    use fable_library_rust::Option_::map;
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
    pub fn closure1(unitVar: (), v0_1: string) -> Common::US1 {
        Common::US1::US1_0(v0_1)
    }
    pub fn method4() -> Func1<string, Common::US1> {
        Func1::new(move |v: string| Common::closure1((), v))
    }
    pub fn method2(v0_1: string) -> string {
        let v18_1: Result<std::string::String, std::env::VarError> = std::env::var(&*v0_1);
        let v20: bool = true;
        let _result_map_ = v18_1.map(|x| {
            //;
            let v22: std::string::String = x;
            let v24: string = fable_library_rust::String_::fromString(v22);
            let v26: bool = true;
            v24
        });
        let v28: Result<string, std::env::VarError> = _result_map_;
        let v29: string = Common::method3();
        v28.unwrap_or(v29)
    }
    pub fn method5() -> string {
        string("AUTOMATION")
    }
    pub fn closure2(unitVar: (), v0_1: string) {
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
        let _v1: (Common::US2, Common::US3) = (Common::US2::US2_1, Common::US3::US3_1);
        let v352: Common::US3 = _v1.1.clone();
        let v351: Common::US2 = _v1.0.clone();
        (
            LrcPtr::new(Common::Mut0 {
                l0: MutCell::new(1_i64),
            }),
            LrcPtr::new(Common::Mut1 {
                l0: MutCell::new(Func1::new(move |v: string| Common::closure2((), v))),
            }),
            LrcPtr::new(Common::Mut2 {
                l0: MutCell::new(true),
            }),
            LrcPtr::new(Common::Mut3 {
                l0: MutCell::new(string("")),
            }),
            LrcPtr::new(Common::Mut4 {
                l0: MutCell::new(match &v351 {
                    Common::US2::US2_0(v351_0_0) => match &v351 {
                        Common::US2::US2_0(x) => x.clone(),
                        _ => unreachable!(),
                    },
                    _ => v0_1,
                }),
            }),
            match &v352 {
                Common::US3::US3_0(v352_0_0) => Some(match &v352 {
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
    pub fn method6(v0_1: Func0<()>) -> Func0<()> {
        v0_1
    }
    pub fn method7(v0_1: Func0<()>) -> Func0<()> {
        v0_1
    }
    pub fn closure3(unitVar: (), v0_1: Func0<()>) -> LrcPtr<dyn IDisposable> {
        let v4 = Common::method6(v0_1);
        interface_cast!(
            Common::Disposable::_ctor__3A5B6456(Func0::new({
                let v4 = v4.clone();
                move || v4.clone()()
            })),
            Lrc<dyn IDisposable>,
        )
    }
    pub fn closure6(unitVar: (), v0_1: Common::US4) -> Common::US5 {
        Common::US5::US5_0(v0_1)
    }
    pub fn closure7(v0_1: i32, v1_1: Func0<()>, v2_1: i32, unitVar: ()) -> Common::US4 {
        if v2_1 < v0_1 {
            v1_1();
            Common::US4::US4_0
        } else {
            Common::US4::US4_1
        }
    }
    pub fn closure10(unitVar: (), v0_1: i64) -> Common::US3 {
        Common::US3::US3_0(v0_1)
    }
    pub fn method10() -> Func1<i64, Common::US3> {
        Func1::new(move |v: i64| Common::closure10((), v))
    }
    pub fn method11() -> string {
        string("hh:mm:ss")
    }
    pub fn method12() -> string {
        string("HH:mm:ss")
    }
    pub fn method9(
        v0_1: LrcPtr<Common::Mut0>,
        v1_1: LrcPtr<Common::Mut1>,
        v2_1: LrcPtr<Common::Mut2>,
        v3: LrcPtr<Common::Mut3>,
        v4: LrcPtr<Common::Mut4>,
        v5: Option<i64>,
    ) -> string {
        let v81: Common::US3 = defaultValue(Common::US3::US3_1, map(Common::method10(), v5));
        let v121: DateTime = match &v81 {
            Common::US3::US3_0(v81_0_0) => {
                let v95: TimeSpan = TimeSpan::new_ticks(
                    {
                        let _arg: DateTime = DateTime::now();
                        _arg.ticks()
                    } - match &v81 {
                        Common::US3::US3_0(x) => x.clone(),
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
        let provider: string = Common::method11();
        v121.toString(provider)
    }
    pub fn method14() -> string {
        string("\u{001b}[0m")
    }
    pub fn method13() -> string {
        let v5: string = padLeft(toLower(string("Warning")), 7_i32, ' ');
        let v50: &str = inline_colorization::color_yellow;
        let v55: &str = &*v5;
        let v73: &str = inline_colorization::color_reset;
        let v75: std::string::String = format!("{}{}{}", v50, v55, v73);
        fable_library_rust::String_::fromString(v75)
    }
    pub fn method16() -> string {
        string("")
    }
    pub fn closure11(v0_1: LrcPtr<Common::Mut3>, v1_1: string, unitVar: ()) {
        let v3: string = append(v0_1.l0.get().clone(), v1_1);
        v0_1.l0.set(v3);
        ()
    }
    pub fn method15(v0_1: i32, v1_1: LrcPtr<Exception>) -> string {
        let v3: LrcPtr<Common::Mut3> = LrcPtr::new(Common::Mut3 {
            l0: MutCell::new(Common::method16()),
        });
        let v10: () = {
            Common::closure11(v3.clone(), sprintf!("{}", string("{ ")), ());
            ()
        };
        let v19: () = {
            Common::closure11(v3.clone(), sprintf!("{}", string("retry")), ());
            ()
        };
        let v28: () = {
            Common::closure11(v3.clone(), sprintf!("{}", string(" = ")), ());
            ()
        };
        let v36: () = {
            Common::closure11(v3.clone(), sprintf!("{}", v0_1), ());
            ()
        };
        let v45: () = {
            Common::closure11(v3.clone(), sprintf!("{}", string("; ")), ());
            ()
        };
        let v54: () = {
            Common::closure11(v3.clone(), sprintf!("{}", string("ex")), ());
            ()
        };
        let v62: () = {
            Common::closure11(v3.clone(), sprintf!("{}", string(" = ")), ());
            ()
        };
        let v71: std::string::String = format!("{:#?}", v1_1);
        let v97: () = {
            Common::closure11(
                v3.clone(),
                sprintf!("{}", fable_library_rust::String_::fromString(v71)),
                (),
            );
            ()
        };
        let v106: () = {
            Common::closure11(v3.clone(), sprintf!("{}", string(" }")), ());
            ()
        };
        v3.l0.get().clone()
    }
    pub fn method17(v0_1: string, v1_1: string, v2_1: i64, v3: string) -> string {
        trimEndChars(
            trimStartChars(
                sprintf!(
                    "{} {} #{} {} / {}",
                    v0_1,
                    v1_1,
                    v2_1,
                    string("common.retry_fn"),
                    v3
                ),
                toArray(empty::<char>()),
            ),
            toArray(ofArray(new_array(&[' ', '/']))),
        )
    }
    pub fn closure12(v0_1: LrcPtr<Common::Mut0>, unitVar: ()) {
        let v2_1: i64 = v0_1.l0.get().clone() + 1_i64;
        v0_1.l0.set(v2_1);
        ()
    }
    pub fn closure14(v0_1: string, unitVar: ()) {
        printfn!("{0}", v0_1);
    }
    pub fn closure13(unitVar: (), v0_1: string) {
        let v3: () = {
            Common::closure14(v0_1, ());
            ()
        };
        ()
    }
    pub fn method18(
        v0_1: string,
        v1_1: LrcPtr<Common::Mut0>,
        v2_1: LrcPtr<Common::Mut1>,
        v3: LrcPtr<Common::Mut2>,
        v4: LrcPtr<Common::Mut3>,
        v5: LrcPtr<Common::Mut4>,
        v6: Option<i64>,
    ) {
        let v9: () = {
            Common::closure12(v1_1, ());
            ()
        };
        println!("{}", v0_1.clone());
        ();
        (v2_1.l0.get().clone())(v0_1)
    }
    pub fn closure9(v0_1: i32, v1_1: LrcPtr<Exception>, unitVar: ()) {
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
        let v36: Common::US0 = (patternInput.4.clone()).l0.get().clone();
        if if (patternInput.2.clone()).l0.get().clone() == false {
            false
        } else {
            3_i32
                >= find(
                    v36,
                    ofSeq(ofList(ofArray(new_array(&[
                        LrcPtr::new((Common::US0::US0_0, 0_i32)),
                        LrcPtr::new((Common::US0::US0_1, 1_i32)),
                        LrcPtr::new((Common::US0::US0_2, 2_i32)),
                        LrcPtr::new((Common::US0::US0_3, 3_i32)),
                        LrcPtr::new((Common::US0::US0_4, 4_i32)),
                    ])))),
                )
        } {
            let v43: () = {
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
            let v57: LrcPtr<Common::Mut0> = patternInput_1.0.clone();
            let v79: string = Common::method17(
                Common::method9(
                    v57.clone(),
                    patternInput_1.1.clone(),
                    patternInput_1.2.clone(),
                    patternInput_1.3.clone(),
                    patternInput_1.4.clone(),
                    patternInput_1.5.clone(),
                ),
                Common::method13(),
                v57.l0.get().clone(),
                Common::method15(v0_1, v1_1),
            );
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
            Common::method18(
                v79,
                patternInput_2.0.clone(),
                patternInput_2.1.clone(),
                patternInput_2.2.clone(),
                patternInput_2.3.clone(),
                patternInput_2.4.clone(),
                patternInput_2.5.clone(),
            )
        }
    }
    pub fn closure8(v0_1: i32, v1_1: LrcPtr<Exception>) -> Common::US5 {
        let v4: () = {
            Common::closure9(v0_1, v1_1, ());
            ()
        };
        Common::US5::US5_1
    }
    pub fn method8(v0_1: i32, v1_1: Func0<()>, v2_1: i32) -> Common::US4 {
        let v0_1: MutCell<i32> = MutCell::new(v0_1);
        let v1_1 = MutCell::new(v1_1.clone());
        let v2_1: MutCell<i32> = MutCell::new(v2_1);
        '_method8: loop {
            break '_method8 ({
                let result: LrcPtr<MutCell<Common::US5>> = refCell(Common::US5::US5_1);
                try_catch(
                    || {
                        result.set(Common::closure6(
                            (),
                            Common::closure7(
                                v0_1.get().clone(),
                                v1_1.get().clone(),
                                v2_1.get().clone(),
                                (),
                            ),
                        ))
                    },
                    |ex: LrcPtr<Exception>| {
                        result.set(Common::closure8(v2_1.get().clone(), ex.clone()))
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
                            continue '_method8;
                        }
                    }
                }
            });
        }
    }
    pub fn closure5(v0_1: i32, v1_1: Func0<()>) -> Option<()> {
        let v3: Common::US4 = Common::method8(v0_1, v1_1, 0_i32);
        match &v3 {
            Common::US4::US4_0 => Some(()),
            _ => None::<()>,
        }
    }
    pub fn closure4(unitVar: (), v0_1: i32) -> Func1<Func0<()>, Option<()>> {
        Func1::new({
            let v0_1 = v0_1.clone();
            move |v: Func0<()>| Common::closure5(v0_1, v)
        })
    }
    pub fn method19(v0_1: Func0<()>) -> Func0<()> {
        v0_1
    }
    pub fn closure16(v0_1: LrcPtr<Lazy_1<()>>, unitVar: ()) {
        v0_1.get_Value();
        ()
    }
    pub fn closure15(unitVar: (), v0_1: Func0<()>) -> Func0<()> {
        let v1_1 = Common::method19(v0_1);
        let v2_1: LrcPtr<Lazy_1<()>> = LazyExtensions::Create(Func0::new({
            let v1_1 = v1_1.clone();
            move || v1_1()
        }));
        Func0::new({
            let v2_1 = v2_1.clone();
            move || Common::closure16(v2_1.clone(), ())
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
        v16.get_or_init(|| Func1::new(move |v: Func0<()>| Common::closure3((), v)))
            .clone()
    }
    pub fn new_disposable(x: Func0<()>) -> LrcPtr<dyn IDisposable> {
        (Common::v16())(x)
    }
    pub fn v17() -> Func1<i32, Func1<Func0<()>, Option<()>>> {
        static v17: OnceInit<Func1<i32, Func1<Func0<()>, Option<()>>>> = OnceInit::new();
        v17.get_or_init(|| Func1::new(move |v: i32| Common::closure4((), v)))
            .clone()
    }
    pub fn retry_fn(x: i32) -> Func1<Func0<()>, Option<()>> {
        (Common::v17())(x)
    }
    pub fn v18() -> Func1<Func0<()>, Func0<()>> {
        static v18: OnceInit<Func1<Func0<()>, Func0<()>>> = OnceInit::new();
        v18.get_or_init(|| Func1::new(move |v: Func0<()>| Common::closure15((), v)))
            .clone()
    }
    pub fn memoize(x: Func0<()>) -> Func0<()> {
        (Common::v18())(x)
    }
    on_startup!(());
}
