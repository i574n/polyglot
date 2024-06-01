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
    #[derive(Clone, Debug, Default, PartialEq, PartialOrd, Hash, Eq)]
    pub struct Mut1 {
        pub l0: MutCell<bool>,
    }
    impl core::fmt::Display for Common::Mut1 {
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
        US2_0(Common::US0),
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
        let v29: string = Common::method2();
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
        v0_1: Common::US0,
    ) -> (
        LrcPtr<Common::Mut0>,
        LrcPtr<Common::Mut1>,
        LrcPtr<Common::Mut2>,
        Option<i64>,
        LrcPtr<Common::Mut3>,
    ) {
        let _v1: MutCell<Option<(Common::US1, Common::US2)>> =
            MutCell::new(None::<(Common::US1, Common::US2)>);
        _v1.set(Some((Common::US1::US1_1, Common::US2::US2_1)));
        {
            let patternInput: (Common::US1, Common::US2) = match &_v1.get().clone() {
                None => panic!("{}", string("base.run_target / _v1=None"),),
                Some(_v1_0_0) => _v1_0_0.clone(),
            };
            let v139: Common::US2 = patternInput.1.clone();
            let v138: Common::US1 = patternInput.0.clone();
            let v147: LrcPtr<Common::Mut3> = LrcPtr::new(Common::Mut3 {
                l0: MutCell::new(Func1::new(move |v: string| Common::closure1((), v))),
            });
            (
                LrcPtr::new(Common::Mut0 {
                    l0: MutCell::new(0_i64),
                }),
                LrcPtr::new(Common::Mut1 {
                    l0: MutCell::new(true),
                }),
                LrcPtr::new(Common::Mut2 {
                    l0: MutCell::new(match &v139 {
                        Common::US2::US2_0(v139_0_0) => match &v139 {
                            Common::US2::US2_0(x) => x.clone(),
                            _ => unreachable!(),
                        },
                        _ => v0_1,
                    }),
                }),
                match &v138 {
                    Common::US1::US1_0(v138_0_0) => Some(match &v138 {
                        Common::US1::US1_0(x) => x.clone(),
                        _ => unreachable!(),
                    }),
                    _ => None::<i64>,
                },
                v147,
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
        let v4_1 = Common::method4(v0_1);
        {
            let x: LrcPtr<dyn IDisposable> = interface_cast!(
                Common::Disposable::_ctor__3A5B6456(Func0::new({
                    let v4_1 = v4_1.clone();
                    move || v4_1.clone()()
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
    pub fn closure5(v0_1: i32, v1_1: Func0<()>, v2_1: i32, unitVar: ()) -> Common::US4 {
        if v2_1 < v0_1 {
            v1_1();
            Common::US4::US4_0
        } else {
            Common::US4::US4_1
        }
    }
    pub fn closure6(unitVar: (), v0_1: Common::US4) -> Common::US5 {
        Common::US5::US5_0(v0_1)
    }
    pub fn closure8(unitVar: (), unitVar_1: ()) -> string {
        string("common.retry_fn")
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
    pub fn method8() -> string {
        string("hh:mm:ss")
    }
    pub fn method9() -> string {
        string("")
    }
    pub fn method10() -> string {
        string("HH:mm:ss")
    }
    pub fn closure11(
        v0_1: Common::US0,
        v1_1: Func0<string>,
        v2_1: Func0<string>,
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
                Option<i64>,
                LrcPtr<Common::Mut3>,
            ) = getValue(Common::State::trace_state().get().clone());
            let v8: Option<i64> = patternInput.3.clone();
            let _v10: MutCell<Option<string>> = MutCell::new(None::<string>);
            let _v38: LrcPtr<MutCell<Option<Common::US1>>> = refCell(None::<Common::US1>);
            {
                let x_2: Option<Common::US1> = match &v8 {
                    None => None::<Common::US1>,
                    Some(v8_0_0) => {
                        let x: i64 = v8_0_0.clone();
                        Some((Func0::new({
                            let x = x.clone();
                            move || Common::US1::US1_0(x)
                        }))())
                    }
                };
                _v38.set(x_2)
            }
            {
                let v43: Common::US1 = defaultValue(Common::US1::US1_1, _v38.get().clone());
                let v62: DateTime = match &v43 {
                    Common::US1::US1_0(v43_0_0) => {
                        let v50: TimeSpan = TimeSpan::new_ticks(
                            {
                                let _arg: DateTime = DateTime::now();
                                _arg.ticks()
                            } - match &v43 {
                                Common::US1::US1_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                        );
                        DateTime::new_ymdhms_milli(
                            1_i32,
                            1_i32,
                            1_i32,
                            v50.hours(),
                            v50.minutes(),
                            v50.seconds(),
                            v50.milliseconds(),
                        )
                    }
                    _ => DateTime::now(),
                };
                let v63: string = Common::method8();
                {
                    let x_3: string = v62.toString(v63);
                    _v10.set(Some(x_3))
                }
                {
                    let v147: string = match &_v10.get().clone() {
                        None => panic!("{}", string("base.run_target / _v10=None"),),
                        Some(_v10_0_0) => _v10_0_0.clone(),
                    };
                    let v160: string = padLeft(
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
                    let _v161: MutCell<Option<string>> = MutCell::new(None::<string>);
                    let v200: &str = match &v0_1 {
                        Common::US0::US0_1 => inline_colorization::color_bright_blue,
                        Common::US0::US0_2 => inline_colorization::color_bright_green,
                        Common::US0::US0_0 => inline_colorization::color_bright_black,
                        Common::US0::US0_3 => inline_colorization::color_yellow,
                        _ => inline_colorization::color_bright_red,
                    };
                    let v202: &str = &*v160;
                    let v204: &str = inline_colorization::color_reset;
                    let v206: string = string("format!(\"{v200}{v202}{v204}\")");
                    let v207: std::string::String = format!("{v200}{v202}{v204}");
                    {
                        let x_5: string = fable_library_rust::String_::fromString(v207);
                        _v161.set(Some(x_5))
                    }
                    trimEndChars(
                        trimStartChars(
                            sprintf!(
                                "{} {} #{} {} / {}",
                                v147,
                                match &_v161.get().clone() {
                                    None => panic!("{}", string("base.run_target / _v161=None"),),
                                    Some(_v161_0_0) => _v161_0_0.clone(),
                                },
                                (patternInput.0.clone()).l0.get().clone(),
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
    pub fn method11(v0_1: Common::US0, v1_1: Func0<string>) {
        fn v2_1(
            v: Common::US0,
        ) -> (
            LrcPtr<Common::Mut0>,
            LrcPtr<Common::Mut1>,
            LrcPtr<Common::Mut2>,
            Option<i64>,
            LrcPtr<Common::Mut3>,
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
                Option<i64>,
                LrcPtr<Common::Mut3>,
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
                    Option<i64>,
                    LrcPtr<Common::Mut3>,
                ) = getValue(Common::State::trace_state().get().clone());
                let v15: Common::US0 = (patternInput_1.2.clone()).l0.get().clone();
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
                        ((patternInput.4.clone()).l0.get().clone())(v24)
                    }
                }
            }
        }
    }
    pub fn method7(v0_1: Common::US0, v1_1: Func0<string>, v2_1: Func0<string>) {
        Common::method11(
            v0_1.clone(),
            Func0::new({
                let v0_1 = v0_1.clone();
                let v1_1 = v1_1.clone();
                let v2_1 = v2_1.clone();
                move || Common::closure11(v0_1.clone(), v1_1.clone(), v2_1.clone(), ())
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
        {
            let _v5: MutCell<Option<()>> = MutCell::new(None::<()>);
            _v5.set(Some(()));
            match &_v5.get().clone() {
                None => panic!("{}", string("base.run_target / _v5=None"),),
                Some(_v5_0_0) => _v5_0_0.clone(),
            }
            Common::US5::US5_1
        }
    }
    pub fn method6(v0_1: i32, v1_1: Func0<()>, v2_1: i32) -> Common::US4 {
        let v0_1: MutCell<i32> = MutCell::new(v0_1);
        let v1_1 = MutCell::new(v1_1.clone());
        let v2_1: MutCell<i32> = MutCell::new(v2_1);
        '_method6: loop {
            break '_method6 ({
                let v6: Common::US5 = try_catch(
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
                    Common::US5::US5_0(v6_0_0) => match &v6 {
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
    pub fn method12(v0_1: Func0<()>) -> Func0<()> {
        v0_1
    }
    pub fn closure13(v0_1: LrcPtr<Lazy_1<()>>, unitVar: ()) {
        v0_1.get_Value();
        ()
    }
    pub fn closure12(unitVar: (), v0_1: Func0<()>) -> Func0<()> {
        let v1_1 = Common::method12(v0_1);
        let v2_1: LrcPtr<Lazy_1<()>> = LazyExtensions::Create(Func0::new({
            let v1_1 = v1_1.clone();
            move || v1_1()
        }));
        Func0::new({
            let v2_1 = v2_1.clone();
            move || Common::closure13(v2_1.clone(), ())
        })
    }
    pub fn v0() -> Func1<
        Common::US0,
        (
            LrcPtr<Common::Mut0>,
            LrcPtr<Common::Mut1>,
            LrcPtr<Common::Mut2>,
            Option<i64>,
            LrcPtr<Common::Mut3>,
        ),
    > {
        static v0: OnceInit<
            Func1<
                Common::US0,
                (
                    LrcPtr<Common::Mut0>,
                    LrcPtr<Common::Mut1>,
                    LrcPtr<Common::Mut2>,
                    Option<i64>,
                    LrcPtr<Common::Mut3>,
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
        v4.get_or_init(|| Func1::new(move |v: Func0<()>| Common::closure12((), v)))
            .clone()
    }
    pub fn memoize(x: Func0<()>) -> Func0<()> {
        (Common::v4())(x)
    }
    on_startup!(());
}
