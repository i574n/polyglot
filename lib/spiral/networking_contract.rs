pub mod Networking {
    use super::*;
    type Async<T> = T;
    use fable_library_rust::NativeArray_::new_array;
    use fable_library_rust::NativeArray_::new_empty;
    use fable_library_rust::Native_::compare;
    use fable_library_rust::Native_::defaultOf;
    use fable_library_rust::Native_::on_startup;
    use fable_library_rust::Native_::Arc;
    use fable_library_rust::Native_::Func0;
    use fable_library_rust::Native_::Func1;
    use fable_library_rust::Native_::LrcPtr;
    use fable_library_rust::Native_::MutCell;
    use fable_library_rust::Native_::OnceInit;
    use fable_library_rust::Option_::getValue;
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
                    LrcPtr<Networking::Mut0>,
                    LrcPtr<Networking::Mut1>,
                    LrcPtr<Networking::Mut1>,
                    LrcPtr<Networking::Mut2>,
                    Option<i64>,
                )>,
            >,
        > {
            static trace_state: OnceInit<
                LrcPtr<
                    MutCell<
                        Option<(
                            LrcPtr<Networking::Mut0>,
                            LrcPtr<Networking::Mut1>,
                            LrcPtr<Networking::Mut1>,
                            LrcPtr<Networking::Mut2>,
                            Option<i64>,
                        )>,
                    >,
                >,
            > = OnceInit::new();
            trace_state
                .get_or_init(|| {
                    LrcPtr::new(MutCell::new(
                        None::<(
                            LrcPtr<Networking::Mut0>,
                            LrcPtr<Networking::Mut1>,
                            LrcPtr<Networking::Mut1>,
                            LrcPtr<Networking::Mut2>,
                            Option<i64>,
                        )>,
                    ))
                })
                .clone()
        }
    }
    #[derive(Clone, Debug, Default, PartialEq, PartialOrd, Hash, Eq)]
    pub struct Mut0 {
        pub l0: MutCell<i64>,
    }
    impl core::fmt::Display for Networking::Mut0 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Debug, Default, PartialEq, PartialOrd, Hash, Eq)]
    pub struct Mut1 {
        pub l0: MutCell<bool>,
    }
    impl core::fmt::Display for Networking::Mut1 {
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
    impl Networking::US0 {
        pub fn get_IsUS0_0(this_: &MutCell<Networking::US0>, unitArg: ()) -> bool {
            if unreachable!() {
                true
            } else {
                false
            }
        }
        pub fn get_IsUS0_1(this_: &MutCell<Networking::US0>, unitArg: ()) -> bool {
            if unreachable!() {
                true
            } else {
                false
            }
        }
        pub fn get_IsUS0_2(this_: &MutCell<Networking::US0>, unitArg: ()) -> bool {
            if unreachable!() {
                true
            } else {
                false
            }
        }
        pub fn get_IsUS0_3(this_: &MutCell<Networking::US0>, unitArg: ()) -> bool {
            if unreachable!() {
                true
            } else {
                false
            }
        }
        pub fn get_IsUS0_4(this_: &MutCell<Networking::US0>, unitArg: ()) -> bool {
            if unreachable!() {
                true
            } else {
                false
            }
        }
    }
    impl core::fmt::Display for Networking::US0 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Debug, PartialEq, PartialOrd, Hash, Eq)]
    pub struct Mut2 {
        pub l0: MutCell<Networking::US0>,
    }
    impl core::fmt::Display for Networking::Mut2 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Copy, Debug, PartialEq, PartialOrd, Hash, Eq)]
    pub enum US1 {
        US1_0(i64),
        US1_1,
    }
    impl Networking::US1 {
        pub fn get_IsUS1_0(this_: &MutCell<Networking::US1>, unitArg: ()) -> bool {
            if unreachable!() {
                true
            } else {
                false
            }
        }
        pub fn get_IsUS1_1(this_: &MutCell<Networking::US1>, unitArg: ()) -> bool {
            if unreachable!() {
                true
            } else {
                false
            }
        }
    }
    impl core::fmt::Display for Networking::US1 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Copy, Debug, PartialEq, PartialOrd, Hash, Eq)]
    pub enum US2 {
        US2_0(i64),
        US2_1,
    }
    impl Networking::US2 {
        pub fn get_IsUS2_0(this_: &MutCell<Networking::US2>, unitArg: ()) -> bool {
            if unreachable!() {
                true
            } else {
                false
            }
        }
        pub fn get_IsUS2_1(this_: &MutCell<Networking::US2>, unitArg: ()) -> bool {
            if unreachable!() {
                true
            } else {
                false
            }
        }
    }
    impl core::fmt::Display for Networking::US2 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Copy, Debug, PartialEq, PartialOrd, Hash, Eq)]
    pub enum US3 {
        US3_0(bool),
        US3_1,
    }
    impl Networking::US3 {
        pub fn get_IsUS3_0(this_: &MutCell<Networking::US3>, unitArg: ()) -> bool {
            if unreachable!() {
                true
            } else {
                false
            }
        }
        pub fn get_IsUS3_1(this_: &MutCell<Networking::US3>, unitArg: ()) -> bool {
            if unreachable!() {
                true
            } else {
                false
            }
        }
    }
    impl core::fmt::Display for Networking::US3 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Debug)]
    pub enum US4 {
        US4_0(bool),
        US4_1(LrcPtr<Exception>),
    }
    impl Networking::US4 {
        pub fn get_IsUS4_0(this_: &MutCell<Networking::US4>, unitArg: ()) -> bool {
            if unreachable!() {
                true
            } else {
                false
            }
        }
        pub fn get_IsUS4_1(this_: &MutCell<Networking::US4>, unitArg: ()) -> bool {
            if unreachable!() {
                true
            } else {
                false
            }
        }
    }
    impl core::fmt::Display for Networking::US4 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Debug)]
    pub enum US5 {
        US5_0(bool),
        US5_1(LrcPtr<Exception>),
    }
    impl Networking::US5 {
        pub fn get_IsUS5_0(this_: &MutCell<Networking::US5>, unitArg: ()) -> bool {
            if unreachable!() {
                true
            } else {
                false
            }
        }
        pub fn get_IsUS5_1(this_: &MutCell<Networking::US5>, unitArg: ()) -> bool {
            if unreachable!() {
                true
            } else {
                false
            }
        }
    }
    impl core::fmt::Display for Networking::US5 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Copy, Debug, PartialEq, PartialOrd, Hash, Eq)]
    pub enum US6 {
        US6_0(i32),
        US6_1,
    }
    impl Networking::US6 {
        pub fn get_IsUS6_0(this_: &MutCell<Networking::US6>, unitArg: ()) -> bool {
            if unreachable!() {
                true
            } else {
                false
            }
        }
        pub fn get_IsUS6_1(this_: &MutCell<Networking::US6>, unitArg: ()) -> bool {
            if unreachable!() {
                true
            } else {
                false
            }
        }
    }
    impl core::fmt::Display for Networking::US6 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
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
        LrcPtr<Networking::Mut0>,
        LrcPtr<Networking::Mut1>,
        LrcPtr<Networking::Mut1>,
        LrcPtr<Networking::Mut2>,
        Option<i64>,
    ) {
        let v0_1: LrcPtr<Networking::Mut1> = LrcPtr::new(Networking::Mut1 {
            l0: MutCell::new(true),
        });
        let v1_1: LrcPtr<Networking::Mut0> = LrcPtr::new(Networking::Mut0 {
            l0: MutCell::new(0_i64),
        });
        let v3_1: LrcPtr<Networking::Mut2> = LrcPtr::new(Networking::Mut2 {
            l0: MutCell::new(Networking::US0::US0_0),
        });
        let v4_1: LrcPtr<Networking::Mut1> = LrcPtr::new(Networking::Mut1 {
            l0: MutCell::new(false),
        });
        let _v5: MutCell<Option<Option<i64>>> = MutCell::new(None::<Option<i64>>);
        {
            let x: Option<i64> = Networking::method1(None::<i64>);
            _v5.set(Some(x))
        }
        (v1_1, v4_1, v0_1, v3_1, getValue(_v5.get().clone()))
    }
    pub fn closure2(v0_1: string, unitVar: ()) -> string {
        sprintf!("test_port_open / ex: {}", v0_1)
    }
    pub fn closure3(unitVar: (), unitVar_1: ()) -> string {
        string("")
    }
    pub fn closure5(unitVar: (), v0_1: i64) -> Networking::US2 {
        Networking::US2::US2_0(v0_1)
    }
    pub fn method3() -> Func1<i64, Networking::US2> {
        Func1::new(move |v: i64| Networking::closure5((), v))
    }
    pub fn method4() -> string {
        string("")
    }
    pub fn closure4(
        v0_1: Networking::US0,
        v1_1: Func0<string>,
        v2_1: Func0<string>,
        unitVar: (),
    ) -> string {
        if Networking::State::trace_state().get().clone()
            == None::<(
                LrcPtr<Networking::Mut0>,
                LrcPtr<Networking::Mut1>,
                LrcPtr<Networking::Mut1>,
                LrcPtr<Networking::Mut2>,
                Option<i64>,
            )>
        {
            Networking::State::trace_state().set(Some(Networking::closure0((), ())));
        }
        {
            let patternInput: (
                LrcPtr<Networking::Mut0>,
                LrcPtr<Networking::Mut1>,
                LrcPtr<Networking::Mut1>,
                LrcPtr<Networking::Mut2>,
                Option<i64>,
            ) = getValue(Networking::State::trace_state().get().clone());
            let _v9: MutCell<Option<string>> = MutCell::new(None::<string>);
            {
                let x: string = Networking::method4();
                _v9.set(Some(x))
            }
            {
                let v60: string = getValue(_v9.get().clone());
                let v61: i64 = (patternInput.0.clone()).l0.get().clone();
                let v72: string = toLower(match &v0_1 {
                    Networking::US0::US0_1 => string("Debug"),
                    Networking::US0::US0_2 => string("Info"),
                    Networking::US0::US0_0 => string("Verbose"),
                    Networking::US0::US0_3 => string("Warning"),
                    _ => string("Critical"),
                });
                let _v73: MutCell<Option<string>> = MutCell::new(None::<string>);
                let v136: &str = match &v0_1 {
                    Networking::US0::US0_1 => inline_colorization::color_bright_blue,
                    Networking::US0::US0_2 => inline_colorization::color_bright_green,
                    Networking::US0::US0_0 => inline_colorization::color_bright_black,
                    Networking::US0::US0_3 => inline_colorization::color_bright_yellow,
                    _ => inline_colorization::color_bright_red,
                };
                let v138: &str = fable_library_rust::String_::LrcStr::as_str(&v72);
                let v140: &str = inline_colorization::color_reset;
                let v142: string = string("format!(\"{v136}{v138}{v140}\")");
                let v143: std::string::String = format!("{v136}{v138}{v140}");
                {
                    let x_1: string = fable_library_rust::String_::fromString(v143);
                    _v73.set(Some(x_1))
                }
                trimEndChars(
                    trimStartChars(
                        sprintf!(
                            "{} {} #{} {} / {}",
                            v60,
                            getValue(_v73.get().clone()),
                            v61,
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
    pub fn method2(v0_1: Networking::US0, v1_1: Func0<string>, v2_1: Func0<string>) {
        let v3_1 = Func0::new(move || Networking::closure0((), ()));
        if Networking::State::trace_state().get().clone()
            == None::<(
                LrcPtr<Networking::Mut0>,
                LrcPtr<Networking::Mut1>,
                LrcPtr<Networking::Mut1>,
                LrcPtr<Networking::Mut2>,
                Option<i64>,
            )>
        {
            Networking::State::trace_state().set(Some(v3_1()));
        }
        {
            let v4_1: LrcPtr<Networking::Mut0> =
                (getValue(Networking::State::trace_state().get().clone()))
                    .0
                    .clone();
            if Networking::State::trace_state().get().clone()
                == None::<(
                    LrcPtr<Networking::Mut0>,
                    LrcPtr<Networking::Mut1>,
                    LrcPtr<Networking::Mut1>,
                    LrcPtr<Networking::Mut2>,
                    Option<i64>,
                )>
            {
                Networking::State::trace_state().set(Some(v3_1()));
            }
            {
                let patternInput_1: (
                    LrcPtr<Networking::Mut0>,
                    LrcPtr<Networking::Mut1>,
                    LrcPtr<Networking::Mut1>,
                    LrcPtr<Networking::Mut2>,
                    Option<i64>,
                ) = getValue(Networking::State::trace_state().get().clone());
                let v14: Networking::US0 = (patternInput_1.3.clone()).l0.get().clone();
                if if (patternInput_1.2.clone()).l0.get().clone() {
                    compare(v0_1.clone(), v14) >= 0_i32
                } else {
                    false
                } {
                    let v19: i64 = v4_1.l0.get().clone() + 1_i64;
                    v4_1.l0.set(v19);
                    {
                        let v21: string =
                            sprintf!("{}", Networking::closure4(v0_1, v1_1, v2_1, ()));
                        let _v22: MutCell<Option<()>> = MutCell::new(None::<()>);
                        println!("{}", v21);
                        _v22.set(Some(()));
                        getValue(_v22.get().clone());
                        ()
                    }
                }
            }
        }
    }
    pub fn closure1(unitVar: (), v0_1: i32) -> Arc<Async<bool>> {
        let _v1: MutCell<Option<Arc<Async<bool>>>> = MutCell::new(None::<Arc<Async<bool>>>);
        {
            let x: Arc<Async<bool>> = defaultOf();
            _v1.set(Some(x))
        }
        getValue(_v1.get().clone())
    }
    pub fn closure8(unitVar: (), v0_1: bool) -> Networking::US4 {
        Networking::US4::US4_0(v0_1)
    }
    pub fn closure9(unitVar: (), v0_1: LrcPtr<Exception>) -> Networking::US4 {
        Networking::US4::US4_1(v0_1)
    }
    pub fn closure10(unitVar: (), unitVar_1: ()) -> string {
        string("run_with_timeout_async")
    }
    pub fn closure11(v0_1: i32, unitVar: ()) -> string {
        sprintf!("timeout: {} / {}", v0_1, Networking::closure3((), ()))
    }
    pub fn closure12(v0_1: string, unitVar: ()) -> string {
        sprintf!("run_with_timeout_async** / ex: {}", v0_1)
    }
    pub fn closure7(v0_1: i32, v1_1: i32) -> Arc<Async<bool>> {
        let _v2: MutCell<Option<Arc<Async<bool>>>> = MutCell::new(None::<Arc<Async<bool>>>);
        {
            let x: Arc<Async<bool>> = defaultOf();
            _v2.set(Some(x))
        }
        getValue(_v2.get().clone())
    }
    pub fn closure6(unitVar: (), v0_1: i32) -> Func1<i32, Arc<Async<bool>>> {
        Func1::new({
            let v0_1 = v0_1.clone();
            move |v: i32| Networking::closure7(v0_1, v)
        })
    }
    pub fn closure16(unitVar: (), v0_1: i32) -> Networking::US6 {
        Networking::US6::US6_0(v0_1)
    }
    pub fn method6() -> Func1<i32, Networking::US6> {
        Func1::new(move |v: i32| Networking::closure16((), v))
    }
    pub fn closure17(unitVar: (), unitVar_1: ()) -> string {
        string("wait_for_port_access")
    }
    pub fn closure18(v0_1: i32, v1_1: i64, unitVar: ()) -> string {
        sprintf!(
            "port: {} / retry: {} / {}",
            v0_1,
            v1_1,
            Networking::closure3((), ())
        )
    }
    pub fn method5(v0_1: Option<i32>, v1_1: bool, v2_1: i32, v3_1: i64) -> Arc<Async<i64>> {
        let _v4: MutCell<Option<Arc<Async<i64>>>> = MutCell::new(None::<Arc<Async<i64>>>);
        {
            let x: Arc<Async<i64>> = defaultOf();
            _v4.set(Some(x))
        }
        getValue(_v4.get().clone())
    }
    pub fn closure15(v0_1: Option<i32>, v1_1: bool, v2_1: i32) -> Arc<Async<i64>> {
        Networking::method5(v0_1, v1_1, v2_1, 0_i64)
    }
    pub fn closure14(v0_1: Option<i32>, v1_1: bool) -> Func1<i32, Arc<Async<i64>>> {
        Func1::new({
            let v0_1 = v0_1.clone();
            let v1_1 = v1_1.clone();
            move |v: i32| Networking::closure15(v0_1.clone(), v1_1, v)
        })
    }
    pub fn closure13(unitVar: (), v0_1: Option<i32>) -> Func1<bool, Func1<i32, Arc<Async<i64>>>> {
        Func1::new({
            let v0_1 = v0_1.clone();
            move |v: bool| Networking::closure14(v0_1.clone(), v)
        })
    }
    pub fn method7(v0_1: Option<i32>, v1_1: i32) -> Arc<Async<i32>> {
        let _v2: MutCell<Option<Arc<Async<i32>>>> = MutCell::new(None::<Arc<Async<i32>>>);
        {
            let x: Arc<Async<i32>> = defaultOf();
            _v2.set(Some(x))
        }
        getValue(_v2.get().clone())
    }
    pub fn closure20(v0_1: Option<i32>, v1_1: i32) -> Arc<Async<i32>> {
        Networking::method7(v0_1, v1_1)
    }
    pub fn closure19(unitVar: (), v0_1: Option<i32>) -> Func1<i32, Arc<Async<i32>>> {
        Func1::new({
            let v0_1 = v0_1.clone();
            move |v: i32| Networking::closure20(v0_1.clone(), v)
        })
    }
    pub fn v0() -> Func0<(
        LrcPtr<Networking::Mut0>,
        LrcPtr<Networking::Mut1>,
        LrcPtr<Networking::Mut1>,
        LrcPtr<Networking::Mut2>,
        Option<i64>,
    )> {
        static v0: OnceInit<
            Func0<(
                LrcPtr<Networking::Mut0>,
                LrcPtr<Networking::Mut1>,
                LrcPtr<Networking::Mut1>,
                LrcPtr<Networking::Mut2>,
                Option<i64>,
            )>,
        > = OnceInit::new();
        v0.get_or_init(|| Func0::new(move || Networking::closure0((), ())))
            .clone()
    }
    on_startup!(if Networking::State::trace_state().get().clone()
        == None::<(
            LrcPtr<Networking::Mut0>,
            LrcPtr<Networking::Mut1>,
            LrcPtr<Networking::Mut1>,
            LrcPtr<Networking::Mut2>,
            Option<i64>
        )> {
        Networking::State::trace_state().set(Some((Networking::v0())()));
    });
    pub fn v1() -> Func1<i32, Arc<Async<bool>>> {
        static v1: OnceInit<Func1<i32, Arc<Async<bool>>>> = OnceInit::new();
        v1.get_or_init(|| Func1::new(move |v: i32| Networking::closure1((), v)))
            .clone()
    }
    pub fn test_port_open(x: i32) -> Arc<Async<bool>> {
        (Networking::v1())(x)
    }
    pub fn v2() -> Func1<i32, Func1<i32, Arc<Async<bool>>>> {
        static v2: OnceInit<Func1<i32, Func1<i32, Arc<Async<bool>>>>> = OnceInit::new();
        v2.get_or_init(|| Func1::new(move |v: i32| Networking::closure6((), v)))
            .clone()
    }
    pub fn test_port_open_timeout(x: i32) -> Func1<i32, Arc<Async<bool>>> {
        (Networking::v2())(x)
    }
    pub fn v3() -> Func1<Option<i32>, Func1<bool, Func1<i32, Arc<Async<i64>>>>> {
        static v3: OnceInit<Func1<Option<i32>, Func1<bool, Func1<i32, Arc<Async<i64>>>>>> =
            OnceInit::new();
        v3.get_or_init(|| Func1::new(move |v: Option<i32>| Networking::closure13((), v)))
            .clone()
    }
    pub fn wait_for_port_access(x: Option<i32>) -> Func1<bool, Func1<i32, Arc<Async<i64>>>> {
        (Networking::v3())(x)
    }
    pub fn v4() -> Func1<Option<i32>, Func1<i32, Arc<Async<i32>>>> {
        static v4: OnceInit<Func1<Option<i32>, Func1<i32, Arc<Async<i32>>>>> = OnceInit::new();
        v4.get_or_init(|| Func1::new(move |v: Option<i32>| Networking::closure19((), v)))
            .clone()
    }
    pub fn get_available_port(x: Option<i32>) -> Func1<i32, Arc<Async<i32>>> {
        (Networking::v4())(x)
    }
    on_startup!(());
}
