pub mod Common {
    use super::*;
    use fable_library_rust::DateTime_::DateTime;
    use fable_library_rust::Exception_::try_catch;
    use fable_library_rust::FSharp::Control::LazyExtensions;
    use fable_library_rust::Interfaces_::System::Collections::Generic::IEnumerable_1;
    use fable_library_rust::Interfaces_::System::IDisposable;
    use fable_library_rust::List_::ofArray;
    use fable_library_rust::Map_::find;
    use fable_library_rust::Map_::ofSeq;
    use fable_library_rust::NativeArray_::new_array;
    use fable_library_rust::NativeArray_::new_empty;
    use fable_library_rust::Native_::interface_cast;
    use fable_library_rust::Native_::on_startup;
    use fable_library_rust::Native_::refCell;
    use fable_library_rust::Native_::Func0;
    use fable_library_rust::Native_::Func1;
    use fable_library_rust::Native_::Lrc;
    use fable_library_rust::Native_::LrcPtr;
    use fable_library_rust::Native_::MutCell;
    use fable_library_rust::Native_::OnceInit;
    use fable_library_rust::Option_::defaultValue;
    use fable_library_rust::Option_::getValue;
    use fable_library_rust::Seq_::ofList;
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
                    Option<i64>,
                    LrcPtr<Common::Mut3>,
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
                            Option<i64>,
                            LrcPtr<Common::Mut3>,
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
                            Option<i64>,
                            LrcPtr<Common::Mut3>,
                        )>,
                    ))
                })
                .clone()
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
    #[derive(Clone, Debug, Default, PartialEq, PartialOrd, Hash, Eq)]
    pub struct Mut0 {
        pub l0: MutCell<i64>,
    }
    impl core::fmt::Display for Common::Mut0 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Debug, Default, PartialEq, PartialOrd, Hash, Eq)]
    pub struct Mut1 {
        pub l0: MutCell<bool>,
    }
    impl core::fmt::Display for Common::Mut1 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
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
    #[derive(Clone, Debug, PartialEq, PartialOrd, Hash, Eq)]
    pub struct Mut2 {
        pub l0: MutCell<Common::US0>,
    }
    impl core::fmt::Display for Common::Mut2 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Debug)]
    pub struct Mut3 {
        pub l0: MutCell<Func1<string, ()>>,
    }
    impl core::fmt::Display for Common::Mut3 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Copy, Debug, PartialEq, PartialOrd, Hash, Eq)]
    pub enum US1 {
        US1_0(i64),
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
        US2_0,
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
    #[derive(Clone, Copy, Debug, PartialEq, PartialOrd, Hash, Eq)]
    pub enum US3 {
        US3_0(Common::US2),
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
    pub fn closure1(unitVar: (), v0_1: string) {
        ();
    }
    pub fn closure0(
        unitVar: (),
        unitVar_1: (),
    ) -> (
        LrcPtr<Common::Mut0>,
        LrcPtr<Common::Mut1>,
        LrcPtr<Common::Mut2>,
        Option<i64>,
        LrcPtr<Common::Mut3>,
    ) {
        let v0_1: LrcPtr<Common::Mut1> = LrcPtr::new(Common::Mut1 {
            l0: MutCell::new(true),
        });
        let v1_1: LrcPtr<Common::Mut0> = LrcPtr::new(Common::Mut0 {
            l0: MutCell::new(0_i64),
        });
        let v3_1: LrcPtr<Common::Mut2> = LrcPtr::new(Common::Mut2 {
            l0: MutCell::new(Common::US0::US0_0),
        });
        let v5: LrcPtr<Common::Mut3> = LrcPtr::new(Common::Mut3 {
            l0: MutCell::new(Func1::new(move |v: string| Common::closure1((), v))),
        });
        let _v6: MutCell<Option<Option<i64>>> = MutCell::new(None::<Option<i64>>);
        let _v7: MutCell<Option<string>> = MutCell::new(None::<string>);
        let v10: Result<std::string::String, std::env::VarError> =
            std::env::var(&*string("AUTOMATION"));
        let v12: bool = true;
        let _result = v10.map(|x| {
            //;
            let v14: std::string::String = x;
            let v16: string = fable_library_rust::String_::fromString(v14);
            let v18: bool = true;
            v16
        });
        let v20: Result<string, std::env::VarError> = _result;
        {
            let x: string = v20.unwrap_or(string(""));
            _v7.set(Some(x))
        }
        {
            let v38: Common::US1 = if getValue(_v7.get().clone()) == string("True") {
                Common::US1::US1_0({
                    let _arg: DateTime = DateTime::now();
                    _arg.ticks()
                })
            } else {
                Common::US1::US1_1
            };
            {
                let x_1: Option<i64> = match &v38 {
                    Common::US1::US1_0(v38_0_0) => Some(match &v38 {
                        Common::US1::US1_0(x) => x.clone(),
                        _ => unreachable!(),
                    }),
                    _ => None::<i64>,
                };
                _v6.set(Some(x_1))
            }
            (v1_1, v0_1, v3_1, getValue(_v6.get().clone()), v5)
        }
    }
    pub fn method0(v0_1: Func0<()>) -> Func0<()> {
        v0_1
    }
    pub fn closure2(unitVar: (), v0_1: Func0<()>) -> LrcPtr<dyn IDisposable> {
        let _v1: MutCell<Option<LrcPtr<dyn IDisposable>>> =
            MutCell::new(None::<LrcPtr<dyn IDisposable>>);
        {
            let x: LrcPtr<dyn IDisposable> = interface_cast!(
                Common::Disposable::_ctor__3A5B6456(Func0::new({
                    let v0_1 = v0_1.clone();
                    move || v0_1.clone()()
                })),
                Lrc<dyn IDisposable>,
            );
            _v1.set(Some(x))
        }
        getValue(_v1.get().clone())
    }
    pub fn closure5(v0_1: i32, v1_1: Func0<()>, v2_1: i32, unitVar: ()) -> Common::US2 {
        if v2_1 < v0_1 {
            v1_1();
            Common::US2::US2_0
        } else {
            Common::US2::US2_1
        }
    }
    pub fn closure6(unitVar: (), v0_1: Common::US2) -> Common::US3 {
        Common::US3::US3_0(v0_1)
    }
    pub fn closure8(unitVar: (), unitVar_1: ()) -> string {
        string("retry_fn")
    }
    pub fn closure10(unitVar: (), unitVar_1: ()) -> string {
        string("")
    }
    pub fn closure9(v0_1: i32, v1_1: LrcPtr<Exception>, unitVar: ()) -> string {
        sprintf!(
            "retry: {} / ex: {:?} / {}",
            v0_1,
            v1_1,
            Common::closure10((), ())
        )
    }
    pub fn method3() -> string {
        string("")
    }
    pub fn closure11(
        v0_1: Common::US0,
        v1_1: Func0<string>,
        v2_1: Func0<string>,
        unitVar: (),
    ) -> string {
        if Common::State::trace_state().get().clone().is_none() {
            Common::State::trace_state().set(Some(Common::closure0((), ())));
        }
        {
            let patternInput: (
                LrcPtr<Common::Mut0>,
                LrcPtr<Common::Mut1>,
                LrcPtr<Common::Mut2>,
                Option<i64>,
                LrcPtr<Common::Mut3>,
            ) = getValue(Common::State::trace_state().get().clone());
            let v7: Option<i64> = patternInput.3.clone();
            let _v9: MutCell<Option<string>> = MutCell::new(None::<string>);
            let _v10: LrcPtr<MutCell<Option<Common::US1>>> = refCell(None::<Common::US1>);
            {
                let x_2: Option<Common::US1> = match &v7 {
                    None => None::<Common::US1>,
                    Some(v7_0_0) => {
                        let x: i64 = v7_0_0.clone();
                        Some((Func0::new({
                            let x = x.clone();
                            move || Common::US1::US1_0(x)
                        }))())
                    }
                };
                _v10.set(x_2)
            }
            {
                let v15: Common::US1 = defaultValue(Common::US1::US1_1, _v10.get().clone());
                let v33: DateTime = match &v15 {
                    Common::US1::US1_0(v15_0_0) => {
                        let v21: TimeSpan = TimeSpan::new_ticks(
                            {
                                let _arg: DateTime = DateTime::now();
                                _arg.ticks()
                            } - match &v15 {
                                Common::US1::US1_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                        );
                        DateTime::new_ymdhms_milli(
                            1_i32,
                            1_i32,
                            1_i32,
                            v21.hours(),
                            v21.minutes(),
                            v21.seconds(),
                            v21.milliseconds(),
                        )
                    }
                    _ => DateTime::now(),
                };
                {
                    let x_3: string = v33.toString(string("hh:mm:ss"));
                    _v9.set(Some(x_3))
                }
                {
                    let v66: string = getValue(_v9.get().clone());
                    let v67: i64 = (patternInput.0.clone()).l0.get().clone();
                    let v79: string = padLeft(
                        toLower(match &v0_1 {
                            Common::US0::US0_1 => string("Debug"),
                            Common::US0::US0_2 => string("Info"),
                            Common::US0::US0_0 => string("Verbose"),
                            Common::US0::US0_3 => string("Warning"),
                            _ => string("Critical"),
                        }),
                        7_i32,
                        ' ',
                    );
                    let _v80: MutCell<Option<string>> = MutCell::new(None::<string>);
                    let v95: &str = match &v0_1 {
                        Common::US0::US0_1 => inline_colorization::color_bright_blue,
                        Common::US0::US0_2 => inline_colorization::color_bright_green,
                        Common::US0::US0_0 => inline_colorization::color_bright_black,
                        Common::US0::US0_3 => inline_colorization::color_yellow,
                        _ => inline_colorization::color_bright_red,
                    };
                    let v97: &str = &*v79;
                    let v99: &str = inline_colorization::color_reset;
                    let v101: string = string("format!(\"{v95}{v97}{v99}\")");
                    let v102: std::string::String = format!("{v95}{v97}{v99}");
                    {
                        let x_4: string = fable_library_rust::String_::fromString(v102);
                        _v80.set(Some(x_4))
                    }
                    trimEndChars(
                        trimStartChars(
                            sprintf!(
                                "{} {} #{} {} / {}",
                                v66,
                                getValue(_v80.get().clone()),
                                v67,
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
    pub fn method4(v0_1: Common::US0, v1_1: Func0<string>) {
        fn v2_1() -> (
            LrcPtr<Common::Mut0>,
            LrcPtr<Common::Mut1>,
            LrcPtr<Common::Mut2>,
            Option<i64>,
            LrcPtr<Common::Mut3>,
        ) {
            Common::closure0((), ())
        }
        if Common::State::trace_state().get().clone().is_none() {
            Common::State::trace_state().set(Some(v2_1()));
        }
        {
            let patternInput: (
                LrcPtr<Common::Mut0>,
                LrcPtr<Common::Mut1>,
                LrcPtr<Common::Mut2>,
                Option<i64>,
                LrcPtr<Common::Mut3>,
            ) = getValue(Common::State::trace_state().get().clone());
            let v3_1: LrcPtr<Common::Mut0> = patternInput.0.clone();
            if Common::State::trace_state().get().clone().is_none() {
                Common::State::trace_state().set(Some(v2_1()));
            }
            {
                let patternInput_1: (
                    LrcPtr<Common::Mut0>,
                    LrcPtr<Common::Mut1>,
                    LrcPtr<Common::Mut2>,
                    Option<i64>,
                    LrcPtr<Common::Mut3>,
                ) = getValue(Common::State::trace_state().get().clone());
                let v13: Common::US0 = (patternInput_1.2.clone()).l0.get().clone();
                if if (patternInput_1.1.clone()).l0.get().clone() == false {
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
                        v13,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Common::US0::US0_0, 0_i32)),
                            LrcPtr::new((Common::US0::US0_1, 1_i32)),
                            LrcPtr::new((Common::US0::US0_2, 2_i32)),
                            LrcPtr::new((Common::US0::US0_3, 3_i32)),
                            LrcPtr::new((Common::US0::US0_4, 4_i32)),
                        ])))),
                    )
                } {
                    let v21: i64 = v3_1.l0.get().clone() + 1_i64;
                    v3_1.l0.set(v21);
                    {
                        let v22: string = sprintf!("{}", v1_1());
                        let _v23: MutCell<Option<()>> = MutCell::new(None::<()>);
                        println!("{}", v22.clone());
                        _v23.set(Some(()));
                        getValue(_v23.get().clone());
                        ((patternInput.4.clone()).l0.get().clone())(v22)
                    }
                }
            }
        }
    }
    pub fn method2(v0_1: Common::US0, v1_1: Func0<string>, v2_1: Func0<string>) {
        Common::method4(
            v0_1.clone(),
            Func0::new({
                let v0_1 = v0_1.clone();
                let v1_1 = v1_1.clone();
                let v2_1 = v2_1.clone();
                move || Common::closure11(v0_1.clone(), v1_1.clone(), v2_1.clone(), ())
            }),
        );
    }
    pub fn closure7(v0_1: i32, v1_1: LrcPtr<Exception>) -> Common::US3 {
        Common::method2(
            Common::US0::US0_3,
            Func0::new(move || Common::closure8((), ())),
            Func0::new({
                let v0_1 = v0_1.clone();
                let v1_1 = v1_1.clone();
                move || Common::closure9(v0_1, v1_1.clone(), ())
            }),
        );
        {
            let _v5: MutCell<Option<()>> = MutCell::new(None::<()>);
            _v5.set(Some(()));
            getValue(_v5.get().clone());
            Common::US3::US3_1
        }
    }
    pub fn method1(v0_1: i32, v1_1: Func0<()>, v2_1: i32) -> Common::US2 {
        let v0_1: MutCell<i32> = MutCell::new(v0_1);
        let v1_1 = MutCell::new(v1_1.clone());
        let v2_1: MutCell<i32> = MutCell::new(v2_1);
        '_method1: loop {
            break '_method1 ({
                let v6: Common::US3 = try_catch(
                    || {
                        Common::closure6(
                            (),
                            Common::closure5(
                                v0_1.get().clone(),
                                v1_1.get().clone(),
                                v2_1.get().clone(),
                                (),
                            ),
                        )
                    },
                    |ex: LrcPtr<Exception>| Common::closure7(v2_1.get().clone(), ex.clone()),
                );
                match &v6 {
                    Common::US3::US3_0(v6_0_0) => match &v6 {
                        Common::US3::US3_0(x) => x.clone(),
                        _ => unreachable!(),
                    },
                    _ => {
                        let v0_1_temp: i32 = v0_1.get().clone();
                        let v1_1_temp = v1_1.get().clone();
                        let v2_1_temp: i32 = v2_1.get().clone() + 1_i32;
                        v0_1.set(v0_1_temp);
                        v1_1.set(v1_1_temp);
                        v2_1.set(v2_1_temp);
                        continue '_method1;
                    }
                }
            });
        }
    }
    pub fn closure4(v0_1: i32, v1_1: Func0<()>) -> Option<()> {
        let v3_1: Common::US2 = Common::method1(v0_1, v1_1, 0_i32);
        match &v3_1 {
            Common::US2::US2_0 => Some(()),
            _ => None::<()>,
        }
    }
    pub fn closure3(unitVar: (), v0_1: i32) -> Func1<Func0<()>, Option<()>> {
        Func1::new({
            let v0_1 = v0_1.clone();
            move |v: Func0<()>| Common::closure4(v0_1, v)
        })
    }
    pub fn method5(v0_1: Func0<()>) -> Func0<()> {
        v0_1
    }
    pub fn closure13(v0_1: LrcPtr<Lazy_1<()>>, unitVar: ()) {
        v0_1.get_Value();
        ()
    }
    pub fn closure12(unitVar: (), v0_1: Func0<()>) -> Func0<()> {
        let v1_1 = Common::method5(v0_1);
        let v2_1: LrcPtr<Lazy_1<()>> = LazyExtensions::Create(Func0::new({
            let v1_1 = v1_1.clone();
            move || v1_1()
        }));
        Func0::new({
            let v2_1 = v2_1.clone();
            move || Common::closure13(v2_1.clone(), ())
        })
    }
    pub fn v0() -> Func0<(
        LrcPtr<Common::Mut0>,
        LrcPtr<Common::Mut1>,
        LrcPtr<Common::Mut2>,
        Option<i64>,
        LrcPtr<Common::Mut3>,
    )> {
        static v0: OnceInit<
            Func0<(
                LrcPtr<Common::Mut0>,
                LrcPtr<Common::Mut1>,
                LrcPtr<Common::Mut2>,
                Option<i64>,
                LrcPtr<Common::Mut3>,
            )>,
        > = OnceInit::new();
        v0.get_or_init(|| Func0::new(move || Common::closure0((), ())))
            .clone()
    }
    on_startup!(if Common::State::trace_state().get().clone().is_none() {
        Common::State::trace_state().set(Some((Common::v0())()));
    });
    pub fn v1() -> Func1<Func0<()>, LrcPtr<dyn IDisposable>> {
        static v1: OnceInit<Func1<Func0<()>, LrcPtr<dyn IDisposable>>> = OnceInit::new();
        v1.get_or_init(|| Func1::new(move |v: Func0<()>| Common::closure2((), v)))
            .clone()
    }
    pub fn new_disposable(x: Func0<()>) -> LrcPtr<dyn IDisposable> {
        (Common::v1())(x)
    }
    pub fn v2() -> Func1<i32, Func1<Func0<()>, Option<()>>> {
        static v2: OnceInit<Func1<i32, Func1<Func0<()>, Option<()>>>> = OnceInit::new();
        v2.get_or_init(|| Func1::new(move |v: i32| Common::closure3((), v)))
            .clone()
    }
    pub fn retry_fn(x: i32) -> Func1<Func0<()>, Option<()>> {
        (Common::v2())(x)
    }
    pub fn v3() -> Func1<Func0<()>, Func0<()>> {
        static v3: OnceInit<Func1<Func0<()>, Func0<()>>> = OnceInit::new();
        v3.get_or_init(|| Func1::new(move |v: Func0<()>| Common::closure12((), v)))
            .clone()
    }
    pub fn memoize(x: Func0<()>) -> Func0<()> {
        (Common::v3())(x)
    }
    on_startup!(());
}
