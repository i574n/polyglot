pub mod Networking {
    use super::*;
    type Async<T> = T;
    use fable_library_rust::Interfaces_::System::Collections::Generic::IEnumerable_1;
    use fable_library_rust::List_::ofArray;
    use fable_library_rust::Map_::find;
    use fable_library_rust::Map_::ofSeq;
    use fable_library_rust::NativeArray_::new_array;
    use fable_library_rust::NativeArray_::new_empty;
    use fable_library_rust::Native_::defaultOf;
    use fable_library_rust::Native_::on_startup;
    use fable_library_rust::Native_::Arc;
    use fable_library_rust::Native_::Func0;
    use fable_library_rust::Native_::Func1;
    use fable_library_rust::Native_::LrcPtr;
    use fable_library_rust::Native_::MutCell;
    use fable_library_rust::Native_::OnceInit;
    use fable_library_rust::Option_::defaultValue;
    use fable_library_rust::Option_::getValue;
    use fable_library_rust::Option_::map;
    use fable_library_rust::Seq_::ofList;
    use fable_library_rust::String_::padLeft;
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
                    LrcPtr<Networking::Mut2>,
                    Option<i64>,
                    LrcPtr<Networking::Mut3>,
                )>,
            >,
        > {
            static trace_state: OnceInit<
                LrcPtr<
                    MutCell<
                        Option<(
                            LrcPtr<Networking::Mut0>,
                            LrcPtr<Networking::Mut1>,
                            LrcPtr<Networking::Mut2>,
                            Option<i64>,
                            LrcPtr<Networking::Mut3>,
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
                            LrcPtr<Networking::Mut2>,
                            Option<i64>,
                            LrcPtr<Networking::Mut3>,
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
    #[derive(Clone, Debug)]
    pub struct Mut3 {
        pub l0: MutCell<Func1<string, ()>>,
    }
    impl core::fmt::Display for Networking::Mut3 {
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
    #[derive(Clone, Debug)]
    pub enum US7 {
        US7_0(i64),
        US7_1(LrcPtr<Exception>),
    }
    impl Networking::US7 {
        pub fn get_IsUS7_0(this_: &MutCell<Networking::US7>, unitArg: ()) -> bool {
            if unreachable!() {
                true
            } else {
                false
            }
        }
        pub fn get_IsUS7_1(this_: &MutCell<Networking::US7>, unitArg: ()) -> bool {
            if unreachable!() {
                true
            } else {
                false
            }
        }
    }
    impl core::fmt::Display for Networking::US7 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Debug)]
    pub enum US8 {
        US8_0(i64),
        US8_1(LrcPtr<Exception>),
    }
    impl Networking::US8 {
        pub fn get_IsUS8_0(this_: &MutCell<Networking::US8>, unitArg: ()) -> bool {
            if unreachable!() {
                true
            } else {
                false
            }
        }
        pub fn get_IsUS8_1(this_: &MutCell<Networking::US8>, unitArg: ()) -> bool {
            if unreachable!() {
                true
            } else {
                false
            }
        }
    }
    impl core::fmt::Display for Networking::US8 {
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
        LrcPtr<Networking::Mut0>,
        LrcPtr<Networking::Mut1>,
        LrcPtr<Networking::Mut2>,
        Option<i64>,
        LrcPtr<Networking::Mut3>,
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
        let v5: LrcPtr<Networking::Mut3> = LrcPtr::new(Networking::Mut3 {
            l0: MutCell::new(Func1::new(move |v: string| Networking::closure1((), v))),
        });
        let _v6: MutCell<Option<Option<i64>>> = MutCell::new(None::<Option<i64>>);
        {
            let x: Option<i64> = Networking::method1(None::<i64>);
            _v6.set(Some(x))
        }
        (v1_1, v0_1, v3_1, getValue(_v6.get().clone()), v5)
    }
    pub fn closure3(v0_1: string, unitVar: ()) -> string {
        sprintf!("test_port_open / ex: {}", v0_1)
    }
    pub fn closure4(unitVar: (), unitVar_1: ()) -> string {
        string("")
    }
    pub fn closure6(unitVar: (), v0_1: i64) -> Networking::US2 {
        Networking::US2::US2_0(v0_1)
    }
    pub fn method3() -> Func1<i64, Networking::US2> {
        Func1::new(move |v: i64| Networking::closure6((), v))
    }
    pub fn method4() -> string {
        string("")
    }
    pub fn closure5(
        v0_1: Networking::US0,
        v1_1: Func0<string>,
        v2_1: Func0<string>,
        unitVar: (),
    ) -> string {
        if Networking::State::trace_state().get().clone().is_none() {
            Networking::State::trace_state().set(Some(Networking::closure0((), ())));
        }
        {
            let patternInput: (
                LrcPtr<Networking::Mut0>,
                LrcPtr<Networking::Mut1>,
                LrcPtr<Networking::Mut2>,
                Option<i64>,
                LrcPtr<Networking::Mut3>,
            ) = getValue(Networking::State::trace_state().get().clone());
            let _v9: MutCell<Option<string>> = MutCell::new(None::<string>);
            {
                let x: string = Networking::method4();
                _v9.set(Some(x))
            }
            {
                let v61: string = getValue(_v9.get().clone());
                let v62: i64 = (patternInput.0.clone()).l0.get().clone();
                let v74: string = padLeft(
                    toLower(match &v0_1 {
                        Networking::US0::US0_1 => string("Debug"),
                        Networking::US0::US0_2 => string("Info"),
                        Networking::US0::US0_0 => string("Verbose"),
                        Networking::US0::US0_3 => string("Warning"),
                        _ => string("Critical"),
                    }),
                    7_i32,
                    ' ',
                );
                let _v75: MutCell<Option<string>> = MutCell::new(None::<string>);
                let v139: &str = match &v0_1 {
                    Networking::US0::US0_1 => inline_colorization::color_bright_blue,
                    Networking::US0::US0_2 => inline_colorization::color_bright_green,
                    Networking::US0::US0_0 => inline_colorization::color_bright_black,
                    Networking::US0::US0_3 => inline_colorization::color_bright_yellow,
                    _ => inline_colorization::color_bright_red,
                };
                let v141: &str = fable_library_rust::String_::LrcStr::as_str(&v74);
                let v143: &str = inline_colorization::color_reset;
                let v145: string = string("format!(\"{v139}{v141}{v143}\")");
                let v146: std::string::String = format!("{v139}{v141}{v143}");
                {
                    let x_1: string = fable_library_rust::String_::fromString(v146);
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
    pub fn method5(v0_1: Networking::US0, v1_1: Func0<string>) {
        fn v2_1() -> (
            LrcPtr<Networking::Mut0>,
            LrcPtr<Networking::Mut1>,
            LrcPtr<Networking::Mut2>,
            Option<i64>,
            LrcPtr<Networking::Mut3>,
        ) {
            Networking::closure0((), ())
        }
        if Networking::State::trace_state().get().clone().is_none() {
            Networking::State::trace_state().set(Some(v2_1()));
        }
        {
            let patternInput: (
                LrcPtr<Networking::Mut0>,
                LrcPtr<Networking::Mut1>,
                LrcPtr<Networking::Mut2>,
                Option<i64>,
                LrcPtr<Networking::Mut3>,
            ) = getValue(Networking::State::trace_state().get().clone());
            let v3_1: LrcPtr<Networking::Mut0> = patternInput.0.clone();
            if Networking::State::trace_state().get().clone().is_none() {
                Networking::State::trace_state().set(Some(v2_1()));
            }
            {
                let patternInput_1: (
                    LrcPtr<Networking::Mut0>,
                    LrcPtr<Networking::Mut1>,
                    LrcPtr<Networking::Mut2>,
                    Option<i64>,
                    LrcPtr<Networking::Mut3>,
                ) = getValue(Networking::State::trace_state().get().clone());
                let v13: Networking::US0 = (patternInput_1.2.clone()).l0.get().clone();
                if if (patternInput_1.1.clone()).l0.get().clone() == false {
                    false
                } else {
                    find(
                        v0_1,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Networking::US0::US0_0, 0_i32)),
                            LrcPtr::new((Networking::US0::US0_1, 1_i32)),
                            LrcPtr::new((Networking::US0::US0_2, 2_i32)),
                            LrcPtr::new((Networking::US0::US0_3, 3_i32)),
                            LrcPtr::new((Networking::US0::US0_4, 4_i32)),
                        ])))),
                    ) >= find(
                        v13,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Networking::US0::US0_0, 0_i32)),
                            LrcPtr::new((Networking::US0::US0_1, 1_i32)),
                            LrcPtr::new((Networking::US0::US0_2, 2_i32)),
                            LrcPtr::new((Networking::US0::US0_3, 3_i32)),
                            LrcPtr::new((Networking::US0::US0_4, 4_i32)),
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
    pub fn method2(v0_1: Networking::US0, v1_1: Func0<string>, v2_1: Func0<string>) {
        Networking::method5(
            v0_1.clone(),
            Func0::new({
                let v0_1 = v0_1.clone();
                let v1_1 = v1_1.clone();
                let v2_1 = v2_1.clone();
                move || Networking::closure5(v0_1.clone(), v1_1.clone(), v2_1.clone(), ())
            }),
        );
    }
    pub fn closure2(unitVar: (), v0_1: i32) -> Arc<Async<bool>> {
        let _v1: MutCell<Option<Arc<Async<bool>>>> = MutCell::new(None::<Arc<Async<bool>>>);
        {
            let x: Arc<Async<bool>> = defaultOf();
            _v1.set(Some(x))
        }
        getValue(_v1.get().clone())
    }
    pub fn closure9(unitVar: (), v0_1: bool) -> Networking::US4 {
        Networking::US4::US4_0(v0_1)
    }
    pub fn closure10(unitVar: (), v0_1: LrcPtr<Exception>) -> Networking::US4 {
        Networking::US4::US4_1(v0_1)
    }
    pub fn closure11(unitVar: (), unitVar_1: ()) -> string {
        string("run_with_timeout_async")
    }
    pub fn closure12(v0_1: i32, unitVar: ()) -> string {
        sprintf!("timeout: {} / {}", v0_1, Networking::closure4((), ()))
    }
    pub fn closure13(v0_1: string, unitVar: ()) -> string {
        sprintf!("run_with_timeout_async** / ex: {}", v0_1)
    }
    pub fn closure8(v0_1: i32, v1_1: i32) -> Arc<Async<bool>> {
        let _v2: MutCell<Option<Arc<Async<bool>>>> = MutCell::new(None::<Arc<Async<bool>>>);
        {
            let x: Arc<Async<bool>> = defaultOf();
            _v2.set(Some(x))
        }
        getValue(_v2.get().clone())
    }
    pub fn closure7(unitVar: (), v0_1: i32) -> Func1<i32, Arc<Async<bool>>> {
        Func1::new({
            let v0_1 = v0_1.clone();
            move |v: i32| Networking::closure8(v0_1, v)
        })
    }
    pub fn closure17(unitVar: (), v0_1: i32) -> Networking::US6 {
        Networking::US6::US6_0(v0_1)
    }
    pub fn method7() -> Func1<i32, Networking::US6> {
        Func1::new(move |v: i32| Networking::closure17((), v))
    }
    pub fn closure18(unitVar: (), unitVar_1: ()) -> string {
        string("wait_for_port_access")
    }
    pub fn closure19(v0_1: Option<i32>, v1_1: bool, v2_1: i32, v3_1: i64, unitVar: ()) -> string {
        sprintf!(
            "port: {} / retry: {} / timeout: {:?} / status: {} / {}",
            v2_1,
            v3_1,
            v0_1,
            v1_1,
            Networking::closure4((), ())
        )
    }
    pub fn method6(v0_1: Option<i32>, v1_1: bool, v2_1: i32, v3_1: i64) -> Arc<Async<i64>> {
        let _v4: MutCell<Option<Arc<Async<i64>>>> = MutCell::new(None::<Arc<Async<i64>>>);
        {
            let x: Arc<Async<i64>> = defaultOf();
            _v4.set(Some(x))
        }
        getValue(_v4.get().clone())
    }
    pub fn closure20(unitVar: (), v0_1: i64) -> Networking::US7 {
        Networking::US7::US7_0(v0_1)
    }
    pub fn closure21(unitVar: (), v0_1: LrcPtr<Exception>) -> Networking::US7 {
        Networking::US7::US7_1(v0_1)
    }
    pub fn closure16(v0_1: Option<i32>, v1_1: bool, v2_1: i32) -> Arc<Async<i64>> {
        let v4_1: Arc<Async<i64>> = Networking::method6(v0_1.clone(), v1_1, v2_1, 0_i64);
        let v7: Networking::US6 =
            defaultValue(Networking::US6::US6_1, map(Networking::method7(), v0_1));
        match &v7 {
            Networking::US6::US6_0(v7_0_0) => {
                let _v9: MutCell<Option<Arc<Async<Networking::US2>>>> =
                    MutCell::new(None::<Arc<Async<Networking::US2>>>);
                {
                    let x: Arc<Async<Networking::US2>> = defaultOf();
                    _v9.set(Some(x))
                }
                {
                    let v122: Arc<Async<Networking::US2>> = getValue(_v9.get().clone());
                    let _v123: MutCell<Option<Arc<Async<i64>>>> =
                        MutCell::new(None::<Arc<Async<i64>>>);
                    {
                        let x_1: Arc<Async<i64>> = defaultOf();
                        _v123.set(Some(x_1))
                    }
                    getValue(_v123.get().clone())
                }
            }
            _ => v4_1,
        }
    }
    pub fn closure15(v0_1: Option<i32>, v1_1: bool) -> Func1<i32, Arc<Async<i64>>> {
        Func1::new({
            let v0_1 = v0_1.clone();
            let v1_1 = v1_1.clone();
            move |v: i32| Networking::closure16(v0_1.clone(), v1_1, v)
        })
    }
    pub fn closure14(unitVar: (), v0_1: Option<i32>) -> Func1<bool, Func1<i32, Arc<Async<i64>>>> {
        Func1::new({
            let v0_1 = v0_1.clone();
            move |v: bool| Networking::closure15(v0_1.clone(), v)
        })
    }
    pub fn method8(v0_1: Option<i32>, v1_1: i32) -> Arc<Async<i32>> {
        let _v2: MutCell<Option<Arc<Async<i32>>>> = MutCell::new(None::<Arc<Async<i32>>>);
        {
            let x: Arc<Async<i32>> = defaultOf();
            _v2.set(Some(x))
        }
        getValue(_v2.get().clone())
    }
    pub fn closure23(v0_1: Option<i32>, v1_1: i32) -> Arc<Async<i32>> {
        Networking::method8(v0_1, v1_1)
    }
    pub fn closure22(unitVar: (), v0_1: Option<i32>) -> Func1<i32, Arc<Async<i32>>> {
        Func1::new({
            let v0_1 = v0_1.clone();
            move |v: i32| Networking::closure23(v0_1.clone(), v)
        })
    }
    pub fn v0() -> Func0<(
        LrcPtr<Networking::Mut0>,
        LrcPtr<Networking::Mut1>,
        LrcPtr<Networking::Mut2>,
        Option<i64>,
        LrcPtr<Networking::Mut3>,
    )> {
        static v0: OnceInit<
            Func0<(
                LrcPtr<Networking::Mut0>,
                LrcPtr<Networking::Mut1>,
                LrcPtr<Networking::Mut2>,
                Option<i64>,
                LrcPtr<Networking::Mut3>,
            )>,
        > = OnceInit::new();
        v0.get_or_init(|| Func0::new(move || Networking::closure0((), ())))
            .clone()
    }
    on_startup!(
        if Networking::State::trace_state().get().clone().is_none() {
            Networking::State::trace_state().set(Some((Networking::v0())()));
        }
    );
    pub fn v1() -> Func1<i32, Arc<Async<bool>>> {
        static v1: OnceInit<Func1<i32, Arc<Async<bool>>>> = OnceInit::new();
        v1.get_or_init(|| Func1::new(move |v: i32| Networking::closure2((), v)))
            .clone()
    }
    pub fn test_port_open(x: i32) -> Arc<Async<bool>> {
        (Networking::v1())(x)
    }
    pub fn v2() -> Func1<i32, Func1<i32, Arc<Async<bool>>>> {
        static v2: OnceInit<Func1<i32, Func1<i32, Arc<Async<bool>>>>> = OnceInit::new();
        v2.get_or_init(|| Func1::new(move |v: i32| Networking::closure7((), v)))
            .clone()
    }
    pub fn test_port_open_timeout(x: i32) -> Func1<i32, Arc<Async<bool>>> {
        (Networking::v2())(x)
    }
    pub fn v3() -> Func1<Option<i32>, Func1<bool, Func1<i32, Arc<Async<i64>>>>> {
        static v3: OnceInit<Func1<Option<i32>, Func1<bool, Func1<i32, Arc<Async<i64>>>>>> =
            OnceInit::new();
        v3.get_or_init(|| Func1::new(move |v: Option<i32>| Networking::closure14((), v)))
            .clone()
    }
    pub fn wait_for_port_access(x: Option<i32>) -> Func1<bool, Func1<i32, Arc<Async<i64>>>> {
        (Networking::v3())(x)
    }
    pub fn v4() -> Func1<Option<i32>, Func1<i32, Arc<Async<i32>>>> {
        static v4: OnceInit<Func1<Option<i32>, Func1<i32, Arc<Async<i32>>>>> = OnceInit::new();
        v4.get_or_init(|| Func1::new(move |v: Option<i32>| Networking::closure22((), v)))
            .clone()
    }
    pub fn get_available_port(x: Option<i32>) -> Func1<i32, Arc<Async<i32>>> {
        (Networking::v4())(x)
    }
    on_startup!(());
}
