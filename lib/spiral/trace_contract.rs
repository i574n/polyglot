pub mod Trace {
    use super::*;
    use fable_library_rust::Interfaces_::System::Collections::Generic::IEnumerable_1;
    use fable_library_rust::List_::ofArray;
    use fable_library_rust::Map_::find;
    use fable_library_rust::Map_::ofSeq;
    use fable_library_rust::NativeArray_::new_array;
    use fable_library_rust::NativeArray_::new_empty;
    use fable_library_rust::Native_::on_startup;
    use fable_library_rust::Native_::Func0;
    use fable_library_rust::Native_::Func1;
    use fable_library_rust::Native_::LrcPtr;
    use fable_library_rust::Native_::MutCell;
    use fable_library_rust::Native_::OnceInit;
    use fable_library_rust::Option_::getValue;
    use fable_library_rust::Seq_::ofList;
    use fable_library_rust::String_::padLeft;
    use fable_library_rust::String_::sprintf;
    use fable_library_rust::String_::string;
    use fable_library_rust::String_::toLower;
    use fable_library_rust::String_::trimEndChars;
    use fable_library_rust::String_::trimStartChars;
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
    #[derive(Clone, Copy, Debug, PartialEq, PartialOrd, Hash, Eq)]
    pub enum US2 {
        US2_0(i64),
        US2_1,
    }
    impl Trace::US2 {
        pub fn get_IsUS2_0(this_: &MutCell<Trace::US2>, unitArg: ()) -> bool {
            if unreachable!() {
                true
            } else {
                false
            }
        }
        pub fn get_IsUS2_1(this_: &MutCell<Trace::US2>, unitArg: ()) -> bool {
            if unreachable!() {
                true
            } else {
                false
            }
        }
    }
    impl core::fmt::Display for Trace::US2 {
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
        LrcPtr<Trace::Mut0>,
        LrcPtr<Trace::Mut1>,
        LrcPtr<Trace::Mut2>,
        Option<i64>,
        LrcPtr<Trace::Mut3>,
    ) {
        let v0_1: LrcPtr<Trace::Mut1> = LrcPtr::new(Trace::Mut1 {
            l0: MutCell::new(true),
        });
        let v1_1: LrcPtr<Trace::Mut0> = LrcPtr::new(Trace::Mut0 {
            l0: MutCell::new(0_i64),
        });
        let v3: LrcPtr<Trace::Mut2> = LrcPtr::new(Trace::Mut2 {
            l0: MutCell::new(Trace::US0::US0_0),
        });
        let v5: LrcPtr<Trace::Mut3> = LrcPtr::new(Trace::Mut3 {
            l0: MutCell::new(Func1::new(move |v: string| Trace::closure1((), v))),
        });
        let _v6: MutCell<Option<Option<i64>>> = MutCell::new(None::<Option<i64>>);
        {
            let x: Option<i64> = Trace::method1(None::<i64>);
            _v6.set(Some(x))
        }
        (v1_1, v0_1, v3, getValue(_v6.get().clone()), v5)
    }
    pub fn closure6(unitVar: (), v0_1: i64) -> Trace::US2 {
        Trace::US2::US2_0(v0_1)
    }
    pub fn method3() -> Func1<i64, Trace::US2> {
        Func1::new(move |v: i64| Trace::closure6((), v))
    }
    pub fn method4() -> string {
        string("")
    }
    pub fn closure5(
        v0_1: Trace::US0,
        v1_1: Func0<string>,
        v2: Func0<string>,
        unitVar: (),
    ) -> string {
        if Trace::State::trace_state().get().clone().is_none() {
            Trace::State::trace_state().set(Some(Trace::closure0((), ())));
        }
        {
            let patternInput: (
                LrcPtr<Trace::Mut0>,
                LrcPtr<Trace::Mut1>,
                LrcPtr<Trace::Mut2>,
                Option<i64>,
                LrcPtr<Trace::Mut3>,
            ) = getValue(Trace::State::trace_state().get().clone());
            let _v9: MutCell<Option<string>> = MutCell::new(None::<string>);
            {
                let x: string = Trace::method4();
                _v9.set(Some(x))
            }
            {
                let v61: string = getValue(_v9.get().clone());
                let v62: i64 = (patternInput.0.clone()).l0.get().clone();
                let v74: string = padLeft(
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
                let _v75: MutCell<Option<string>> = MutCell::new(None::<string>);
                let v139: &str = match &v0_1 {
                    Trace::US0::US0_1 => inline_colorization::color_bright_blue,
                    Trace::US0::US0_2 => inline_colorization::color_bright_green,
                    Trace::US0::US0_0 => inline_colorization::color_bright_black,
                    Trace::US0::US0_3 => inline_colorization::color_bright_yellow,
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
                            v2()
                        ),
                        new_empty::<char>(),
                    ),
                    new_array(&[' ', '/']),
                )
            }
        }
    }
    pub fn method5(v0_1: Trace::US0, v1_1: Func0<string>) {
        fn v2() -> (
            LrcPtr<Trace::Mut0>,
            LrcPtr<Trace::Mut1>,
            LrcPtr<Trace::Mut2>,
            Option<i64>,
            LrcPtr<Trace::Mut3>,
        ) {
            Trace::closure0((), ())
        }
        if Trace::State::trace_state().get().clone().is_none() {
            Trace::State::trace_state().set(Some(v2()));
        }
        {
            let patternInput: (
                LrcPtr<Trace::Mut0>,
                LrcPtr<Trace::Mut1>,
                LrcPtr<Trace::Mut2>,
                Option<i64>,
                LrcPtr<Trace::Mut3>,
            ) = getValue(Trace::State::trace_state().get().clone());
            let v3: LrcPtr<Trace::Mut0> = patternInput.0.clone();
            if Trace::State::trace_state().get().clone().is_none() {
                Trace::State::trace_state().set(Some(v2()));
            }
            {
                let patternInput_1: (
                    LrcPtr<Trace::Mut0>,
                    LrcPtr<Trace::Mut1>,
                    LrcPtr<Trace::Mut2>,
                    Option<i64>,
                    LrcPtr<Trace::Mut3>,
                ) = getValue(Trace::State::trace_state().get().clone());
                let v13: Trace::US0 = (patternInput_1.2.clone()).l0.get().clone();
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
                        v13,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Trace::US0::US0_0, 0_i32)),
                            LrcPtr::new((Trace::US0::US0_1, 1_i32)),
                            LrcPtr::new((Trace::US0::US0_2, 2_i32)),
                            LrcPtr::new((Trace::US0::US0_3, 3_i32)),
                            LrcPtr::new((Trace::US0::US0_4, 4_i32)),
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
    pub fn method2(v0_1: Trace::US0, v1_1: Func0<string>, v2: Func0<string>) {
        Trace::method5(
            v0_1.clone(),
            Func0::new({
                let v0_1 = v0_1.clone();
                let v1_1 = v1_1.clone();
                let v2 = v2.clone();
                move || Trace::closure5(v0_1.clone(), v1_1.clone(), v2.clone(), ())
            }),
        );
    }
    pub fn closure4(v0_1: Trace::US0, v1_1: Func0<string>, v2: Func0<string>) {
        Trace::method2(v0_1, v1_1, v2);
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
    pub fn v0() -> Func0<(
        LrcPtr<Trace::Mut0>,
        LrcPtr<Trace::Mut1>,
        LrcPtr<Trace::Mut2>,
        Option<i64>,
        LrcPtr<Trace::Mut3>,
    )> {
        static v0: OnceInit<
            Func0<(
                LrcPtr<Trace::Mut0>,
                LrcPtr<Trace::Mut1>,
                LrcPtr<Trace::Mut2>,
                Option<i64>,
                LrcPtr<Trace::Mut3>,
            )>,
        > = OnceInit::new();
        v0.get_or_init(|| Func0::new(move || Trace::closure0((), ())))
            .clone()
    }
    on_startup!(if Trace::State::trace_state().get().clone().is_none() {
        Trace::State::trace_state().set(Some((Trace::v0())()));
    });
    pub fn v1() -> Func1<Trace::US0, Func1<Func0<string>, Func1<Func0<string>, ()>>> {
        static v1: OnceInit<Func1<Trace::US0, Func1<Func0<string>, Func1<Func0<string>, ()>>>> =
            OnceInit::new();
        v1.get_or_init(|| Func1::new(move |v: Trace::US0| Trace::closure2((), v)))
            .clone()
    }
    pub fn trace(x: Trace::US0) -> Func1<Func0<string>, Func1<Func0<string>, ()>> {
        (Trace::v1())(x)
    }
    on_startup!(());
}
