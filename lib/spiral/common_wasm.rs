pub mod Common {
    use super::*;
    use fable_library_rust::Exception_::try_catch;
    use fable_library_rust::Interfaces_::System::Collections::Generic::IEnumerable_1;
    use fable_library_rust::Interfaces_::System::IDisposable;
    use fable_library_rust::List_::ofArray;
    use fable_library_rust::Map_::find;
    use fable_library_rust::Map_::ofSeq;
    use fable_library_rust::NativeArray_::new_array;
    use fable_library_rust::NativeArray_::new_empty;
    use fable_library_rust::Native_::interface_cast;
    use fable_library_rust::Native_::on_startup;
    use fable_library_rust::Native_::Func0;
    use fable_library_rust::Native_::Func1;
    use fable_library_rust::Native_::Lrc;
    use fable_library_rust::Native_::LrcPtr;
    use fable_library_rust::Native_::MutCell;
    use fable_library_rust::Native_::OnceInit;
    use fable_library_rust::Option_::getValue;
    use fable_library_rust::Seq_::ofList;
    use fable_library_rust::String_::padRight;
    use fable_library_rust::String_::sprintf;
    use fable_library_rust::String_::string;
    use fable_library_rust::String_::toLower;
    use fable_library_rust::String_::trimEndChars;
    use fable_library_rust::String_::trimStartChars;
    use fable_library_rust::System::Exception;
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
    #[derive(Clone, Copy, Debug, PartialEq, PartialOrd, Hash, Eq)]
    pub enum US4 {
        US4_0(i64),
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
    pub fn closure1(unitVar: (), v0_1: string) {
        ();
    }
    pub fn method0(v0_1: Option<i64>) -> Option<i64> {
        v0_1
    }
    pub fn method1(v0_1: Option<i64>) -> Option<i64> {
        v0_1
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
        let v3: LrcPtr<Common::Mut2> = LrcPtr::new(Common::Mut2 {
            l0: MutCell::new(Common::US0::US0_0),
        });
        let v5: LrcPtr<Common::Mut3> = LrcPtr::new(Common::Mut3 {
            l0: MutCell::new(Func1::new(move |v: string| Common::closure1((), v))),
        });
        let _v6: MutCell<Option<Option<i64>>> = MutCell::new(None::<Option<i64>>);
        {
            let x: Option<i64> = Common::method1(None::<i64>);
            _v6.set(Some(x))
        }
        (v1_1, v0_1, v3, getValue(_v6.get().clone()), v5)
    }
    pub fn method2(v0_1: Func0<()>) -> Func0<()> {
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
    pub fn closure12(unitVar: (), v0_1: i64) -> Common::US4 {
        Common::US4::US4_0(v0_1)
    }
    pub fn method5() -> Func1<i64, Common::US4> {
        Func1::new(move |v: i64| Common::closure12((), v))
    }
    pub fn method6() -> string {
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
            let _v9: MutCell<Option<string>> = MutCell::new(None::<string>);
            {
                let x: string = Common::method6();
                _v9.set(Some(x))
            }
            {
                let v61: string = getValue(_v9.get().clone());
                let v62: i64 = (patternInput.0.clone()).l0.get().clone();
                let v74: string = padRight(
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
                let _v75: MutCell<Option<string>> = MutCell::new(None::<string>);
                let v115: &str = match &v0_1 {
                    Common::US0::US0_1 => inline_colorization::color_bright_blue,
                    Common::US0::US0_2 => inline_colorization::color_bright_green,
                    Common::US0::US0_0 => inline_colorization::color_bright_black,
                    Common::US0::US0_3 => inline_colorization::color_bright_yellow,
                    _ => inline_colorization::color_bright_red,
                };
                let v117: &str = fable_library_rust::String_::LrcStr::as_str(&v74);
                let v119: &str = inline_colorization::color_reset;
                let v121: string = string("format!(\"{v115}{v117}{v119}\")");
                let v122: std::string::String = format!("{v115}{v117}{v119}");
                {
                    let x_1: string = fable_library_rust::String_::fromString(v122);
                    _v75.set(Some(x_1))
                }
                trimEndChars(
                    trimStartChars(
                        sprintf!(
                            "{} {} #{} {} / {}",
                            v61,
                            getValue(_v75.get().clone()),
                            v62,
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
    pub fn method7(v0_1: Common::US0, v1_1: Func0<string>) {
        let v2_1 = Func0::new(move || Common::closure0((), ()));
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
            let v3: LrcPtr<Common::Mut0> = patternInput.0.clone();
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
                    let v21: i64 = v3.l0.get().clone() + 1_i64;
                    v3.l0.set(v21);
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
    pub fn method4(v0_1: Common::US0, v1_1: Func0<string>, v2_1: Func0<string>) {
        Common::method7(
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
        Common::method4(
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
    pub fn method3(v0_1: i32, v1_1: Func0<()>, v2_1: i32) -> Common::US2 {
        let v0_1: MutCell<i32> = MutCell::new(v0_1);
        let v1_1 = MutCell::new(v1_1.clone());
        let v2_1: MutCell<i32> = MutCell::new(v2_1);
        '_method3: loop {
            break '_method3 ({
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
                        continue '_method3;
                    }
                }
            });
        }
    }
    pub fn closure4(v0_1: i32, v1_1: Func0<()>) -> Option<()> {
        let v3: Common::US2 = Common::method3(v0_1, v1_1, 0_i32);
        match &v3 {
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
    on_startup!(());
}
