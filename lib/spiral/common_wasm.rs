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
    #[derive(Clone, Debug, Default, PartialEq, PartialOrd, Hash, Eq)]
    pub struct Mut4 {
        pub l0: MutCell<string>,
    }
    impl core::fmt::Display for Common::Mut4 {
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
    pub fn method2(v0_1: string) -> string {
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
        let v29: string = Common::method3();
        v28.unwrap_or(v29)
    }
    pub fn method4() -> string {
        string("AUTOMATION")
    }
    pub fn closure0(unitVar: (), v0_1: string) {
        ();
    }
    pub fn method0(
        v0_1: Common::US0,
    ) -> (
        LrcPtr<Common::Mut0>,
        LrcPtr<Common::Mut1>,
        LrcPtr<Common::Mut2>,
        LrcPtr<Common::Mut3>,
        Option<i64>,
    ) {
        let _v1: (Common::US2, Common::US3) = (Common::US2::US2_1, Common::US3::US3_1);
        let v295: Common::US3 = _v1.1.clone();
        let v294: Common::US2 = _v1.0.clone();
        (
            LrcPtr::new(Common::Mut0 {
                l0: MutCell::new(0_i64),
            }),
            LrcPtr::new(Common::Mut1 {
                l0: MutCell::new(Func1::new(move |v: string| Common::closure0((), v))),
            }),
            LrcPtr::new(Common::Mut2 {
                l0: MutCell::new(true),
            }),
            LrcPtr::new(Common::Mut3 {
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
    pub fn method5(v0_1: Func0<()>) -> Func0<()> {
        v0_1
    }
    pub fn method6(v0_1: Func0<()>) -> Func0<()> {
        v0_1
    }
    pub fn closure1(unitVar: (), v0_1: Func0<()>) -> LrcPtr<dyn IDisposable> {
        let v4 = Common::method5(v0_1);
        interface_cast!(
            Common::Disposable::_ctor__3A5B6456(Func0::new({
                let v4 = v4.clone();
                move || v4.clone()()
            })),
            Lrc<dyn IDisposable>,
        )
    }
    pub fn closure4(unitVar: (), v0_1: Common::US4) -> Common::US5 {
        Common::US5::US5_0(v0_1)
    }
    pub fn closure5(v0_1: i32, v1: Func0<()>, v2: i32, unitVar: ()) -> Common::US4 {
        if v2 < v0_1 {
            v1();
            Common::US4::US4_0
        } else {
            Common::US4::US4_1
        }
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
    pub fn closure7(unitVar: (), unitVar_1: ()) -> string {
        string("common.retry_fn")
    }
    pub fn closure6(v0_1: i32, v1: LrcPtr<Exception>) -> Common::US5 {
        if Common::State::trace_state().get().clone().is_none() {
            let patternInput: (
                LrcPtr<Common::Mut0>,
                LrcPtr<Common::Mut1>,
                LrcPtr<Common::Mut2>,
                LrcPtr<Common::Mut3>,
                Option<i64>,
            ) = Common::method0(Common::US0::US0_0);
            Common::State::trace_state().set(Some((
                patternInput.0.clone(),
                patternInput.1.clone(),
                patternInput.2.clone(),
                patternInput.3.clone(),
                patternInput.4.clone(),
            )));
            ()
        }
        {
            let patternInput_1: (
                LrcPtr<Common::Mut0>,
                LrcPtr<Common::Mut1>,
                LrcPtr<Common::Mut2>,
                LrcPtr<Common::Mut3>,
                Option<i64>,
            ) = getValue(Common::State::trace_state().get().clone());
            let v14_1: LrcPtr<Common::Mut0> = patternInput_1.0.clone();
            if Common::State::trace_state().get().clone().is_none() {
                let patternInput_2: (
                    LrcPtr<Common::Mut0>,
                    LrcPtr<Common::Mut1>,
                    LrcPtr<Common::Mut2>,
                    LrcPtr<Common::Mut3>,
                    Option<i64>,
                ) = Common::method0(Common::US0::US0_0);
                Common::State::trace_state().set(Some((
                    patternInput_2.0.clone(),
                    patternInput_2.1.clone(),
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                )));
                ()
            }
            {
                let patternInput_3: (
                    LrcPtr<Common::Mut0>,
                    LrcPtr<Common::Mut1>,
                    LrcPtr<Common::Mut2>,
                    LrcPtr<Common::Mut3>,
                    Option<i64>,
                ) = getValue(Common::State::trace_state().get().clone());
                let v56: Common::US0 = (patternInput_3.3.clone()).l0.get().clone();
                if if (patternInput_3.2.clone()).l0.get().clone() == false {
                    false
                } else {
                    3_i32
                        >= find(
                            v56,
                            ofSeq(ofList(ofArray(new_array(&[
                                LrcPtr::new((Common::US0::US0_0, 0_i32)),
                                LrcPtr::new((Common::US0::US0_1, 1_i32)),
                                LrcPtr::new((Common::US0::US0_2, 2_i32)),
                                LrcPtr::new((Common::US0::US0_3, 3_i32)),
                                LrcPtr::new((Common::US0::US0_4, 4_i32)),
                            ])))),
                        )
                } {
                    let v63: i64 = v14_1.l0.get().clone() + 1_i64;
                    v14_1.l0.set(v63);
                    if Common::State::trace_state().get().clone().is_none() {
                        let patternInput_4: (
                            LrcPtr<Common::Mut0>,
                            LrcPtr<Common::Mut1>,
                            LrcPtr<Common::Mut2>,
                            LrcPtr<Common::Mut3>,
                            Option<i64>,
                        ) = Common::method0(Common::US0::US0_0);
                        Common::State::trace_state().set(Some((
                            patternInput_4.0.clone(),
                            patternInput_4.1.clone(),
                            patternInput_4.2.clone(),
                            patternInput_4.3.clone(),
                            patternInput_4.4.clone(),
                        )));
                        ()
                    }
                    {
                        let patternInput_5: (
                            LrcPtr<Common::Mut0>,
                            LrcPtr<Common::Mut1>,
                            LrcPtr<Common::Mut2>,
                            LrcPtr<Common::Mut3>,
                            Option<i64>,
                        ) = getValue(Common::State::trace_state().get().clone());
                        let v80: Option<i64> = patternInput_5.4.clone();
                        let _v155: LrcPtr<MutCell<Option<Common::US3>>> =
                            refCell(None::<Common::US3>);
                        {
                            let x_2: Option<Common::US3> = match &v80 {
                                None => None::<Common::US3>,
                                Some(v80_0_0) => {
                                    let x: i64 = v80_0_0.clone();
                                    Some((Func0::new({
                                        let x = x.clone();
                                        move || Common::US3::US3_0(x)
                                    }))())
                                }
                            };
                            _v155.set(x_2)
                        }
                        {
                            let v170: Common::US3 =
                                defaultValue(Common::US3::US3_1, _v155.get().clone());
                            let v210: DateTime = match &v170 {
                                Common::US3::US3_0(v170_0_0) => {
                                    let v184: TimeSpan = TimeSpan::new_ticks(
                                        {
                                            let _arg: DateTime = DateTime::now();
                                            _arg.ticks()
                                        } - match &v170 {
                                            Common::US3::US3_0(x) => x.clone(),
                                            _ => unreachable!(),
                                        },
                                    );
                                    DateTime::new_ymdhms_milli(
                                        1_i32,
                                        1_i32,
                                        1_i32,
                                        v184.hours(),
                                        v184.minutes(),
                                        v184.seconds(),
                                        v184.milliseconds(),
                                    )
                                }
                                _ => DateTime::now(),
                            };
                            let v215: string = {
                                let provider: string = Common::method8();
                                v210.toString(provider)
                            };
                            let v514: string = padLeft(toLower(string("Warning")), 7_i32, ' ');
                            let v541: &str = inline_colorization::color_yellow;
                            let v543: &str = &*v514;
                            let v545: &str = inline_colorization::color_reset;
                            let v547: string = string("format!(\"{v541}{v543}{v545}\")");
                            let v548: std::string::String = format!("{v541}{v543}{v545}");
                            let v550: string = fable_library_rust::String_::fromString(v548);
                            let v580: i64 = (patternInput_5.0.clone()).l0.get().clone();
                            let v582: LrcPtr<Common::Mut4> = LrcPtr::new(Common::Mut4 {
                                l0: MutCell::new(Common::method11()),
                            });
                            let v584: string = sprintf!("{}", string("{ "));
                            let v588: string = append(v582.l0.get().clone(), v584);
                            v582.l0.set(v588);
                            {
                                let v590: string = sprintf!("{}", string("retry"));
                                let v594: string = append(v582.l0.get().clone(), v590);
                                v582.l0.set(v594);
                                {
                                    let v596: string = sprintf!("{}", string(" = "));
                                    let v600: string = append(v582.l0.get().clone(), v596);
                                    v582.l0.set(v600);
                                    {
                                        let v601: string = sprintf!("{}", v0_1);
                                        let v605: string = append(v582.l0.get().clone(), v601);
                                        v582.l0.set(v605);
                                        {
                                            let v607: string = sprintf!("{}", string("; "));
                                            let v611: string = append(v582.l0.get().clone(), v607);
                                            v582.l0.set(v611);
                                            {
                                                let v613: string = sprintf!("{}", string("ex"));
                                                let v617: string =
                                                    append(v582.l0.get().clone(), v613);
                                                v582.l0.set(v617);
                                                {
                                                    let v618: string =
                                                        sprintf!("{}", string(" = "));
                                                    let v622: string =
                                                        append(v582.l0.get().clone(), v618);
                                                    v582.l0.set(v622);
                                                    {
                                                        let v629: std::string::String =
                                                            format!("{:#?}", v1);
                                                        let v650: string = sprintf!(
                                                            "{}",
                                                            fable_library_rust::String_::fromString(
                                                                v629
                                                            )
                                                        );
                                                        let v654: string =
                                                            append(v582.l0.get().clone(), v650);
                                                        v582.l0.set(v654);
                                                        {
                                                            let v656: string =
                                                                sprintf!("{}", string(" }"));
                                                            let v660: string =
                                                                append(v582.l0.get().clone(), v656);
                                                            v582.l0.set(v660);
                                                            {
                                                                let v661: string =
                                                                    v582.l0.get().clone();
                                                                let v700: string = trimEndChars(
                                                                    trimStartChars(
                                                                        sprintf!(
                                                                            "{} {} #{} {} / {}",
                                                                            v215,
                                                                            v550,
                                                                            v580,
                                                                            Common::closure7(
                                                                                (),
                                                                                ()
                                                                            ),
                                                                            v661
                                                                        ),
                                                                        toArray(empty::<char>()),
                                                                    ),
                                                                    toArray(ofArray(new_array(&[
                                                                        ' ', '/',
                                                                    ]))),
                                                                );
                                                                println!("{}", v700.clone());
                                                                ();
                                                                ((patternInput_1.1.clone())
                                                                    .l0
                                                                    .get()
                                                                    .clone())(
                                                                    v700
                                                                )
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                Common::US5::US5_1
            }
        }
    }
    pub fn method7(v0_1: i32, v1: Func0<()>, v2: i32) -> Common::US4 {
        let v0_1: MutCell<i32> = MutCell::new(v0_1);
        let v1 = MutCell::new(v1.clone());
        let v2: MutCell<i32> = MutCell::new(v2);
        '_method7: loop {
            break '_method7 ({
                let result: LrcPtr<MutCell<Common::US5>> = refCell(Common::US5::US5_1);
                try_catch(
                    || {
                        result.set(Common::closure4(
                            (),
                            Common::closure5(
                                v0_1.get().clone(),
                                v1.get().clone(),
                                v2.get().clone(),
                                (),
                            ),
                        ))
                    },
                    |ex: LrcPtr<Exception>| {
                        result.set(Common::closure6(v2.get().clone(), ex.clone()))
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
                            let v1_temp = v1.get().clone();
                            let v2_temp: i32 = v2.get().clone() + 1_i32;
                            v0_1.set(v0_1_temp);
                            v1.set(v1_temp);
                            v2.set(v2_temp);
                            continue '_method7;
                        }
                    }
                }
            });
        }
    }
    pub fn closure3(v0_1: i32, v1: Func0<()>) -> Option<()> {
        let v3: Common::US4 = Common::method7(v0_1, v1, 0_i32);
        match &v3 {
            Common::US4::US4_0 => Some(()),
            _ => None::<()>,
        }
    }
    pub fn closure2(unitVar: (), v0_1: i32) -> Func1<Func0<()>, Option<()>> {
        Func1::new({
            let v0_1 = v0_1.clone();
            move |v: Func0<()>| Common::closure3(v0_1, v)
        })
    }
    pub fn method12(v0_1: Func0<()>) -> Func0<()> {
        v0_1
    }
    pub fn closure9(v0_1: LrcPtr<Lazy_1<()>>, unitVar: ()) {
        v0_1.get_Value();
        ()
    }
    pub fn closure8(unitVar: (), v0_1: Func0<()>) -> Func0<()> {
        let v1 = Common::method12(v0_1);
        let v2: LrcPtr<Lazy_1<()>> = LazyExtensions::Create(Func0::new({
            let v1 = v1.clone();
            move || v1()
        }));
        Func0::new({
            let v2 = v2.clone();
            move || Common::closure9(v2.clone(), ())
        })
    }
    pub fn v0() -> bool {
        static v0: OnceInit<bool> = OnceInit::new();
        v0.get_or_init(|| Common::State::trace_state().get().clone().is_none())
            .clone()
    }
    on_startup!(if Common::v0() {
        let patternInput: (
            LrcPtr<Common::Mut0>,
            LrcPtr<Common::Mut1>,
            LrcPtr<Common::Mut2>,
            LrcPtr<Common::Mut3>,
            Option<i64>,
        ) = Common::method0(Common::US0::US0_0);
        Common::State::trace_state().set(Some((
            patternInput.0.clone(),
            patternInput.1.clone(),
            patternInput.2.clone(),
            patternInput.3.clone(),
            patternInput.4.clone(),
        )));
        ()
    });
    pub fn v12() -> Func1<Func0<()>, LrcPtr<dyn IDisposable>> {
        static v12: OnceInit<Func1<Func0<()>, LrcPtr<dyn IDisposable>>> = OnceInit::new();
        v12.get_or_init(|| Func1::new(move |v: Func0<()>| Common::closure1((), v)))
            .clone()
    }
    pub fn new_disposable(x: Func0<()>) -> LrcPtr<dyn IDisposable> {
        (Common::v12())(x)
    }
    pub fn v13() -> Func1<i32, Func1<Func0<()>, Option<()>>> {
        static v13: OnceInit<Func1<i32, Func1<Func0<()>, Option<()>>>> = OnceInit::new();
        v13.get_or_init(|| Func1::new(move |v: i32| Common::closure2((), v)))
            .clone()
    }
    pub fn retry_fn(x: i32) -> Func1<Func0<()>, Option<()>> {
        (Common::v13())(x)
    }
    pub fn v14() -> Func1<Func0<()>, Func0<()>> {
        static v14: OnceInit<Func1<Func0<()>, Func0<()>>> = OnceInit::new();
        v14.get_or_init(|| Func1::new(move |v: Func0<()>| Common::closure8((), v)))
            .clone()
    }
    pub fn memoize(x: Func0<()>) -> Func0<()> {
        (Common::v14())(x)
    }
    on_startup!(());
}
