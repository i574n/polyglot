pub mod Trace {
    use super::*;
    use fable_library_rust::DateTime_::DateTime;
    use fable_library_rust::Interfaces_::System::Collections::Generic::IEnumerable_1;
    use fable_library_rust::List_::ofArray;
    use fable_library_rust::Map_::find;
    use fable_library_rust::Map_::ofSeq;
    use fable_library_rust::NativeArray_::new_array;
    use fable_library_rust::NativeArray_::new_empty;
    use fable_library_rust::Native_::on_startup;
    use fable_library_rust::Native_::refCell;
    use fable_library_rust::Native_::Func0;
    use fable_library_rust::Native_::Func1;
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
    use fable_library_rust::TimeSpan_::TimeSpan;
    pub mod State {
        use super::*;
        pub fn trace_state() -> LrcPtr<
            MutCell<
                Option<(
                    LrcPtr<Trace::Mut0>,
                    LrcPtr<Trace::Mut1>,
                    LrcPtr<Trace::Mut2>,
                    Option<i64>,
                    LrcPtr<Trace::Mut3>,
                )>,
            >,
        > {
            static trace_state: OnceInit<
                LrcPtr<
                    MutCell<
                        Option<(
                            LrcPtr<Trace::Mut0>,
                            LrcPtr<Trace::Mut1>,
                            LrcPtr<Trace::Mut2>,
                            Option<i64>,
                            LrcPtr<Trace::Mut3>,
                        )>,
                    >,
                >,
            > = OnceInit::new();
            trace_state
                .get_or_init(|| {
                    LrcPtr::new(MutCell::new(
                        None::<(
                            LrcPtr<Trace::Mut0>,
                            LrcPtr<Trace::Mut1>,
                            LrcPtr<Trace::Mut2>,
                            Option<i64>,
                            LrcPtr<Trace::Mut3>,
                        )>,
                    ))
                })
                .clone()
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
    impl Trace::US0 {
        pub fn get_IsUS0_0(this_: &MutCell<Trace::US0>, unitArg: ()) -> bool {
            if unreachable!() {
                true
            } else {
                false
            }
        }
        pub fn get_IsUS0_1(this_: &MutCell<Trace::US0>, unitArg: ()) -> bool {
            if unreachable!() {
                true
            } else {
                false
            }
        }
        pub fn get_IsUS0_2(this_: &MutCell<Trace::US0>, unitArg: ()) -> bool {
            if unreachable!() {
                true
            } else {
                false
            }
        }
        pub fn get_IsUS0_3(this_: &MutCell<Trace::US0>, unitArg: ()) -> bool {
            if unreachable!() {
                true
            } else {
                false
            }
        }
        pub fn get_IsUS0_4(this_: &MutCell<Trace::US0>, unitArg: ()) -> bool {
            if unreachable!() {
                true
            } else {
                false
            }
        }
    }
    impl core::fmt::Display for Trace::US0 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Debug, Default, PartialEq, PartialOrd, Hash, Eq)]
    pub struct Mut0 {
        pub l0: MutCell<i64>,
    }
    impl core::fmt::Display for Trace::Mut0 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Debug, Default, PartialEq, PartialOrd, Hash, Eq)]
    pub struct Mut1 {
        pub l0: MutCell<bool>,
    }
    impl core::fmt::Display for Trace::Mut1 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Debug, PartialEq, PartialOrd, Hash, Eq)]
    pub struct Mut2 {
        pub l0: MutCell<Trace::US0>,
    }
    impl core::fmt::Display for Trace::Mut2 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Debug)]
    pub struct Mut3 {
        pub l0: MutCell<Func1<string, ()>>,
    }
    impl core::fmt::Display for Trace::Mut3 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Copy, Debug, PartialEq, PartialOrd, Hash, Eq)]
    pub enum US1 {
        US1_0(i64),
        US1_1,
    }
    impl Trace::US1 {
        pub fn get_IsUS1_0(this_: &MutCell<Trace::US1>, unitArg: ()) -> bool {
            if unreachable!() {
                true
            } else {
                false
            }
        }
        pub fn get_IsUS1_1(this_: &MutCell<Trace::US1>, unitArg: ()) -> bool {
            if unreachable!() {
                true
            } else {
                false
            }
        }
    }
    impl core::fmt::Display for Trace::US1 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    pub fn closure1(unitVar: (), v0_1: string) {
        ();
    }
    pub fn method0() -> string {
        string("")
    }
    pub fn method1() -> string {
        string("AUTOMATION")
    }
    pub fn closure0(
        unitVar: (),
        v0_1: Trace::US0,
    ) -> (
        LrcPtr<Trace::Mut0>,
        LrcPtr<Trace::Mut1>,
        LrcPtr<Trace::Mut2>,
        Option<i64>,
        LrcPtr<Trace::Mut3>,
    ) {
        let v1_1: LrcPtr<Trace::Mut1> = LrcPtr::new(Trace::Mut1 {
            l0: MutCell::new(true),
        });
        let v2_1: LrcPtr<Trace::Mut0> = LrcPtr::new(Trace::Mut0 {
            l0: MutCell::new(0_i64),
        });
        let v3: LrcPtr<Trace::Mut2> = LrcPtr::new(Trace::Mut2 {
            l0: MutCell::new(v0_1),
        });
        let v5: LrcPtr<Trace::Mut3> = LrcPtr::new(Trace::Mut3 {
            l0: MutCell::new(Func1::new(move |v: string| Trace::closure1((), v))),
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
        let v21: string = Trace::method0();
        {
            let x: string = v20.unwrap_or(v21);
            _v7.set(Some(x))
        }
        {
            let v39: Trace::US1 = if getValue(_v7.get().clone()) == string("True") {
                Trace::US1::US1_0({
                    let _arg: DateTime = DateTime::now();
                    _arg.ticks()
                })
            } else {
                Trace::US1::US1_1
            };
            {
                let x_1: Option<i64> = match &v39 {
                    Trace::US1::US1_0(v39_0_0) => Some(match &v39 {
                        Trace::US1::US1_0(x) => x.clone(),
                        _ => unreachable!(),
                    }),
                    _ => None::<i64>,
                };
                _v6.set(Some(x_1))
            }
            (v2_1, v1_1, v3, getValue(_v6.get().clone()), v5)
        }
    }
    pub fn method3() -> string {
        string("")
    }
    pub fn closure5(
        v0_1: Trace::US0,
        v1_1: Func0<string>,
        v2_1: Func0<string>,
        unitVar: (),
    ) -> string {
        if Trace::State::trace_state().get().clone().is_none() {
            Trace::State::trace_state().set(Some(Trace::closure0((), Trace::US0::US0_0)));
        }
        {
            let patternInput: (
                LrcPtr<Trace::Mut0>,
                LrcPtr<Trace::Mut1>,
                LrcPtr<Trace::Mut2>,
                Option<i64>,
                LrcPtr<Trace::Mut3>,
            ) = getValue(Trace::State::trace_state().get().clone());
            let v8: Option<i64> = patternInput.3.clone();
            let _v10: MutCell<Option<string>> = MutCell::new(None::<string>);
            let _v11: LrcPtr<MutCell<Option<Trace::US1>>> = refCell(None::<Trace::US1>);
            {
                let x_2: Option<Trace::US1> = match &v8 {
                    None => None::<Trace::US1>,
                    Some(v8_0_0) => {
                        let x: i64 = v8_0_0.clone();
                        Some((Func0::new({
                            let x = x.clone();
                            move || Trace::US1::US1_0(x)
                        }))())
                    }
                };
                _v11.set(x_2)
            }
            {
                let v16: Trace::US1 = defaultValue(Trace::US1::US1_1, _v11.get().clone());
                let v34: DateTime = match &v16 {
                    Trace::US1::US1_0(v16_0_0) => {
                        let v22: TimeSpan = TimeSpan::new_ticks(
                            {
                                let _arg: DateTime = DateTime::now();
                                _arg.ticks()
                            } - match &v16 {
                                Trace::US1::US1_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                        );
                        DateTime::new_ymdhms_milli(
                            1_i32,
                            1_i32,
                            1_i32,
                            v22.hours(),
                            v22.minutes(),
                            v22.seconds(),
                            v22.milliseconds(),
                        )
                    }
                    _ => DateTime::now(),
                };
                {
                    let x_3: string = v34.toString(string("hh:mm:ss"));
                    _v10.set(Some(x_3))
                }
                {
                    let v67: string = getValue(_v10.get().clone());
                    let v68: i64 = (patternInput.0.clone()).l0.get().clone();
                    let v80: string = padLeft(
                        toLower(match &v0_1 {
                            Trace::US0::US0_1 => string("Debug"),
                            Trace::US0::US0_2 => string("Info"),
                            Trace::US0::US0_0 => string("Verbose"),
                            Trace::US0::US0_3 => string("Warning"),
                            _ => string("Critical"),
                        }),
                        7_i32,
                        ' ',
                    );
                    let _v81: MutCell<Option<string>> = MutCell::new(None::<string>);
                    let v96: &str = match &v0_1 {
                        Trace::US0::US0_1 => inline_colorization::color_bright_blue,
                        Trace::US0::US0_2 => inline_colorization::color_bright_green,
                        Trace::US0::US0_0 => inline_colorization::color_bright_black,
                        Trace::US0::US0_3 => inline_colorization::color_yellow,
                        _ => inline_colorization::color_bright_red,
                    };
                    let v98: &str = &*v80;
                    let v100: &str = inline_colorization::color_reset;
                    let v102: string = string("format!(\"{v96}{v98}{v100}\")");
                    let v103: std::string::String = format!("{v96}{v98}{v100}");
                    {
                        let x_4: string = fable_library_rust::String_::fromString(v103);
                        _v81.set(Some(x_4))
                    }
                    trimEndChars(
                        trimStartChars(
                            sprintf!(
                                "{} {} #{} {} / {}",
                                v67,
                                getValue(_v81.get().clone()),
                                v68,
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
    pub fn method4(v0_1: Trace::US0, v1_1: Func0<string>) {
        fn v2_1(
            v: Trace::US0,
        ) -> (
            LrcPtr<Trace::Mut0>,
            LrcPtr<Trace::Mut1>,
            LrcPtr<Trace::Mut2>,
            Option<i64>,
            LrcPtr<Trace::Mut3>,
        ) {
            Trace::closure0((), v)
        }
        if Trace::State::trace_state().get().clone().is_none() {
            Trace::State::trace_state().set(Some(v2_1(Trace::US0::US0_0)));
        }
        {
            let patternInput: (
                LrcPtr<Trace::Mut0>,
                LrcPtr<Trace::Mut1>,
                LrcPtr<Trace::Mut2>,
                Option<i64>,
                LrcPtr<Trace::Mut3>,
            ) = getValue(Trace::State::trace_state().get().clone());
            let v4: LrcPtr<Trace::Mut0> = patternInput.0.clone();
            if Trace::State::trace_state().get().clone().is_none() {
                Trace::State::trace_state().set(Some(v2_1(Trace::US0::US0_0)));
            }
            {
                let patternInput_1: (
                    LrcPtr<Trace::Mut0>,
                    LrcPtr<Trace::Mut1>,
                    LrcPtr<Trace::Mut2>,
                    Option<i64>,
                    LrcPtr<Trace::Mut3>,
                ) = getValue(Trace::State::trace_state().get().clone());
                let v15: Trace::US0 = (patternInput_1.2.clone()).l0.get().clone();
                if if (patternInput_1.1.clone()).l0.get().clone() == false {
                    false
                } else {
                    find(
                        v0_1,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Trace::US0::US0_0, 0_i32)),
                            LrcPtr::new((Trace::US0::US0_1, 1_i32)),
                            LrcPtr::new((Trace::US0::US0_2, 2_i32)),
                            LrcPtr::new((Trace::US0::US0_3, 3_i32)),
                            LrcPtr::new((Trace::US0::US0_4, 4_i32)),
                        ])))),
                    ) >= find(
                        v15,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Trace::US0::US0_0, 0_i32)),
                            LrcPtr::new((Trace::US0::US0_1, 1_i32)),
                            LrcPtr::new((Trace::US0::US0_2, 2_i32)),
                            LrcPtr::new((Trace::US0::US0_3, 3_i32)),
                            LrcPtr::new((Trace::US0::US0_4, 4_i32)),
                        ])))),
                    )
                } {
                    let v23: i64 = v4.l0.get().clone() + 1_i64;
                    v4.l0.set(v23);
                    {
                        let v24: string = sprintf!("{}", v1_1());
                        let _v25: MutCell<Option<()>> = MutCell::new(None::<()>);
                        println!("{}", v24.clone());
                        _v25.set(Some(()));
                        getValue(_v25.get().clone());
                        ((patternInput.4.clone()).l0.get().clone())(v24)
                    }
                }
            }
        }
    }
    pub fn method2(v0_1: Trace::US0, v1_1: Func0<string>, v2_1: Func0<string>) {
        Trace::method4(
            v0_1.clone(),
            Func0::new({
                let v0_1 = v0_1.clone();
                let v1_1 = v1_1.clone();
                let v2_1 = v2_1.clone();
                move || Trace::closure5(v0_1.clone(), v1_1.clone(), v2_1.clone(), ())
            }),
        );
    }
    pub fn closure4(v0_1: Trace::US0, v1_1: Func0<string>, v2_1: Func0<string>) {
        Trace::method2(v0_1, v1_1, v2_1);
    }
    pub fn closure3(v0_1: Trace::US0, v1_1: Func0<string>) -> Func1<Func0<string>, ()> {
        Func1::new({
            let v0_1 = v0_1.clone();
            let v1_1 = v1_1.clone();
            move |v: Func0<string>| Trace::closure4(v0_1.clone(), v1_1.clone(), v)
        })
    }
    pub fn closure2(
        unitVar: (),
        v0_1: Trace::US0,
    ) -> Func1<Func0<string>, Func1<Func0<string>, ()>> {
        Func1::new({
            let v0_1 = v0_1.clone();
            move |v: Func0<string>| Trace::closure3(v0_1.clone(), v)
        })
    }
    pub fn v0() -> Func1<
        Trace::US0,
        (
            LrcPtr<Trace::Mut0>,
            LrcPtr<Trace::Mut1>,
            LrcPtr<Trace::Mut2>,
            Option<i64>,
            LrcPtr<Trace::Mut3>,
        ),
    > {
        static v0: OnceInit<
            Func1<
                Trace::US0,
                (
                    LrcPtr<Trace::Mut0>,
                    LrcPtr<Trace::Mut1>,
                    LrcPtr<Trace::Mut2>,
                    Option<i64>,
                    LrcPtr<Trace::Mut3>,
                ),
            >,
        > = OnceInit::new();
        v0.get_or_init(|| Func1::new(move |v: Trace::US0| Trace::closure0((), v)))
            .clone()
    }
    pub fn v1() -> Trace::US0 {
        static v1: OnceInit<Trace::US0> = OnceInit::new();
        v1.get_or_init(|| Trace::US0::US0_0).clone()
    }
    on_startup!(if Trace::State::trace_state().get().clone().is_none() {
        Trace::State::trace_state().set(Some((Trace::v0())(Trace::v1())));
    });
    pub fn v2() -> Func1<Trace::US0, Func1<Func0<string>, Func1<Func0<string>, ()>>> {
        static v2: OnceInit<Func1<Trace::US0, Func1<Func0<string>, Func1<Func0<string>, ()>>>> =
            OnceInit::new();
        v2.get_or_init(|| Func1::new(move |v: Trace::US0| Trace::closure2((), v)))
            .clone()
    }
    pub fn trace(x: Trace::US0) -> Func1<Func0<string>, Func1<Func0<string>, ()>> {
        (Trace::v2())(x)
    }
    on_startup!(());
}
