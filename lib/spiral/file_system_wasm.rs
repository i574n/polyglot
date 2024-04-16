pub mod File_system {
    use super::*;
    type Async<T> = T;
    use fable_library_rust::Interfaces_::System::IDisposable;
    use fable_library_rust::NativeArray_::new_array;
    use fable_library_rust::NativeArray_::new_empty;
    use fable_library_rust::NativeArray_::Array;
    use fable_library_rust::Native_::compare;
    use fable_library_rust::Native_::defaultOf;
    use fable_library_rust::Native_::on_startup;
    use fable_library_rust::Native_::unbox;
    use fable_library_rust::Native_::Arc;
    use fable_library_rust::Native_::Func0;
    use fable_library_rust::Native_::Func1;
    use fable_library_rust::Native_::LrcPtr;
    use fable_library_rust::Native_::MutCell;
    use fable_library_rust::Native_::OnceInit;
    use fable_library_rust::Option_::defaultValue;
    use fable_library_rust::Option_::getValue;
    use fable_library_rust::Option_::map;
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
                    LrcPtr<File_system::Mut0>,
                    LrcPtr<File_system::Mut1>,
                    LrcPtr<File_system::Mut1>,
                    LrcPtr<File_system::Mut2>,
                    Option<i64>,
                )>,
            >,
        > {
            static trace_state: OnceInit<
                LrcPtr<
                    MutCell<
                        Option<(
                            LrcPtr<File_system::Mut0>,
                            LrcPtr<File_system::Mut1>,
                            LrcPtr<File_system::Mut1>,
                            LrcPtr<File_system::Mut2>,
                            Option<i64>,
                        )>,
                    >,
                >,
            > = OnceInit::new();
            trace_state
                .get_or_init(|| {
                    LrcPtr::new(MutCell::new(
                        None::<(
                            LrcPtr<File_system::Mut0>,
                            LrcPtr<File_system::Mut1>,
                            LrcPtr<File_system::Mut1>,
                            LrcPtr<File_system::Mut2>,
                            Option<i64>,
                        )>,
                    ))
                })
                .clone()
        }
    }
    pub trait IFsExistsSync {
        fn existsSync(&self, path: string) -> bool;
    }
    impl<V: IFsExistsSync + Clone + 'static> IFsExistsSync for LrcPtr<V> {
        #[inline]
        fn existsSync(&self, path: string) -> bool {
            (**self).existsSync(path)
        }
    }
    pub trait IPathJoin {
        fn join(&self, paths: Array<string>) -> string;
    }
    impl<V: IPathJoin + Clone + 'static> IPathJoin for LrcPtr<V> {
        #[inline]
        fn join(&self, paths: Array<string>) -> string {
            (**self).join(paths)
        }
    }
    pub trait IPathDirname {
        fn dirname(&self, path: string) -> string;
    }
    impl<V: IPathDirname + Clone + 'static> IPathDirname for LrcPtr<V> {
        #[inline]
        fn dirname(&self, path: string) -> string {
            (**self).dirname(path)
        }
    }
    #[derive(Clone, Debug, Default, PartialEq, PartialOrd, Hash, Eq)]
    pub struct Mut0 {
        pub l0: MutCell<i64>,
    }
    impl core::fmt::Display for File_system::Mut0 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Debug, Default, PartialEq, PartialOrd, Hash, Eq)]
    pub struct Mut1 {
        pub l0: MutCell<bool>,
    }
    impl core::fmt::Display for File_system::Mut1 {
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
    impl File_system::US0 {
        pub fn get_IsUS0_0(this_: &MutCell<File_system::US0>, unitArg: ()) -> bool {
            if unreachable!() {
                true
            } else {
                false
            }
        }
        pub fn get_IsUS0_1(this_: &MutCell<File_system::US0>, unitArg: ()) -> bool {
            if unreachable!() {
                true
            } else {
                false
            }
        }
        pub fn get_IsUS0_2(this_: &MutCell<File_system::US0>, unitArg: ()) -> bool {
            if unreachable!() {
                true
            } else {
                false
            }
        }
        pub fn get_IsUS0_3(this_: &MutCell<File_system::US0>, unitArg: ()) -> bool {
            if unreachable!() {
                true
            } else {
                false
            }
        }
        pub fn get_IsUS0_4(this_: &MutCell<File_system::US0>, unitArg: ()) -> bool {
            if unreachable!() {
                true
            } else {
                false
            }
        }
    }
    impl core::fmt::Display for File_system::US0 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Debug, PartialEq, PartialOrd, Hash, Eq)]
    pub struct Mut2 {
        pub l0: MutCell<File_system::US0>,
    }
    impl core::fmt::Display for File_system::Mut2 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Copy, Debug, PartialEq, PartialOrd, Hash, Eq)]
    pub enum US1 {
        US1_0(i64),
        US1_1,
    }
    impl File_system::US1 {
        pub fn get_IsUS1_0(this_: &MutCell<File_system::US1>, unitArg: ()) -> bool {
            if unreachable!() {
                true
            } else {
                false
            }
        }
        pub fn get_IsUS1_1(this_: &MutCell<File_system::US1>, unitArg: ()) -> bool {
            if unreachable!() {
                true
            } else {
                false
            }
        }
    }
    impl core::fmt::Display for File_system::US1 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Copy, Debug, PartialEq, PartialOrd, Hash, Eq)]
    pub enum US3 {
        US3_0,
        US3_1,
        US3_2,
    }
    impl File_system::US3 {
        pub fn get_IsUS3_0(this_: &MutCell<File_system::US3>, unitArg: ()) -> bool {
            if unreachable!() {
                true
            } else {
                false
            }
        }
        pub fn get_IsUS3_1(this_: &MutCell<File_system::US3>, unitArg: ()) -> bool {
            if unreachable!() {
                true
            } else {
                false
            }
        }
        pub fn get_IsUS3_2(this_: &MutCell<File_system::US3>, unitArg: ()) -> bool {
            if unreachable!() {
                true
            } else {
                false
            }
        }
    }
    impl core::fmt::Display for File_system::US3 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Copy, Debug, PartialEq, PartialOrd, Hash, Eq)]
    pub enum US4 {
        US4_0,
        US4_1,
        US4_2,
        US4_3,
        US4_4,
    }
    impl File_system::US4 {
        pub fn get_IsUS4_0(this_: &MutCell<File_system::US4>, unitArg: ()) -> bool {
            if unreachable!() {
                true
            } else {
                false
            }
        }
        pub fn get_IsUS4_1(this_: &MutCell<File_system::US4>, unitArg: ()) -> bool {
            if unreachable!() {
                true
            } else {
                false
            }
        }
        pub fn get_IsUS4_2(this_: &MutCell<File_system::US4>, unitArg: ()) -> bool {
            if unreachable!() {
                true
            } else {
                false
            }
        }
        pub fn get_IsUS4_3(this_: &MutCell<File_system::US4>, unitArg: ()) -> bool {
            if unreachable!() {
                true
            } else {
                false
            }
        }
        pub fn get_IsUS4_4(this_: &MutCell<File_system::US4>, unitArg: ()) -> bool {
            if unreachable!() {
                true
            } else {
                false
            }
        }
    }
    impl core::fmt::Display for File_system::US4 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Copy, Debug, PartialEq, PartialOrd, Hash, Eq)]
    pub enum US2 {
        US2_0(File_system::US3, File_system::US4),
        US2_1,
    }
    impl File_system::US2 {
        pub fn get_IsUS2_0(this_: &MutCell<File_system::US2>, unitArg: ()) -> bool {
            if unreachable!() {
                true
            } else {
                false
            }
        }
        pub fn get_IsUS2_1(this_: &MutCell<File_system::US2>, unitArg: ()) -> bool {
            if unreachable!() {
                true
            } else {
                false
            }
        }
    }
    impl core::fmt::Display for File_system::US2 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Copy, Debug, PartialEq, PartialOrd, Hash, Eq)]
    pub enum US5 {
        US5_0(i64),
        US5_1,
    }
    impl File_system::US5 {
        pub fn get_IsUS5_0(this_: &MutCell<File_system::US5>, unitArg: ()) -> bool {
            if unreachable!() {
                true
            } else {
                false
            }
        }
        pub fn get_IsUS5_1(this_: &MutCell<File_system::US5>, unitArg: ()) -> bool {
            if unreachable!() {
                true
            } else {
                false
            }
        }
    }
    impl core::fmt::Display for File_system::US5 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Debug)]
    pub enum US6 {
        US6_0(i64),
        US6_1(LrcPtr<Exception>),
    }
    impl File_system::US6 {
        pub fn get_IsUS6_0(this_: &MutCell<File_system::US6>, unitArg: ()) -> bool {
            if unreachable!() {
                true
            } else {
                false
            }
        }
        pub fn get_IsUS6_1(this_: &MutCell<File_system::US6>, unitArg: ()) -> bool {
            if unreachable!() {
                true
            } else {
                false
            }
        }
    }
    impl core::fmt::Display for File_system::US6 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Debug)]
    pub enum US7 {
        US7_0(i64),
        US7_1(LrcPtr<Exception>),
    }
    impl File_system::US7 {
        pub fn get_IsUS7_0(this_: &MutCell<File_system::US7>, unitArg: ()) -> bool {
            if unreachable!() {
                true
            } else {
                false
            }
        }
        pub fn get_IsUS7_1(this_: &MutCell<File_system::US7>, unitArg: ()) -> bool {
            if unreachable!() {
                true
            } else {
                false
            }
        }
    }
    impl core::fmt::Display for File_system::US7 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Debug, PartialEq, PartialOrd, Hash, Eq)]
    pub enum US8 {
        US8_0(string),
        US8_1,
    }
    impl File_system::US8 {
        pub fn get_IsUS8_0(this_: &MutCell<File_system::US8>, unitArg: ()) -> bool {
            if unreachable!() {
                true
            } else {
                false
            }
        }
        pub fn get_IsUS8_1(this_: &MutCell<File_system::US8>, unitArg: ()) -> bool {
            if unreachable!() {
                true
            } else {
                false
            }
        }
    }
    impl core::fmt::Display for File_system::US8 {
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
        LrcPtr<File_system::Mut0>,
        LrcPtr<File_system::Mut1>,
        LrcPtr<File_system::Mut1>,
        LrcPtr<File_system::Mut2>,
        Option<i64>,
    ) {
        let v0_1: LrcPtr<File_system::Mut1> = LrcPtr::new(File_system::Mut1 {
            l0: MutCell::new(true),
        });
        let v1_1: LrcPtr<File_system::Mut0> = LrcPtr::new(File_system::Mut0 {
            l0: MutCell::new(0_i64),
        });
        let v3_1: LrcPtr<File_system::Mut2> = LrcPtr::new(File_system::Mut2 {
            l0: MutCell::new(File_system::US0::US0_0),
        });
        let v4_1: LrcPtr<File_system::Mut1> = LrcPtr::new(File_system::Mut1 {
            l0: MutCell::new(false),
        });
        let _v5: MutCell<Option<Option<i64>>> = MutCell::new(None::<Option<i64>>);
        {
            let x: Option<i64> = File_system::method1(None::<i64>);
            _v5.set(Some(x))
        }
        (v1_1, v4_1, v0_1, v3_1, getValue(_v5.get().clone()))
    }
    pub fn closure3(unitVar: (), v0_1: string) -> string {
        let _v1: MutCell<Option<string>> = MutCell::new(None::<string>);
        {
            let x: string = unbox::<string>(&defaultOf());
            _v1.set(Some(x))
        }
        getValue(_v1.get().clone())
    }
    pub fn closure4(unitVar: (), unitVar_1: ()) -> string {
        string("")
    }
    pub fn method3(v0_1: string, v1_1: string) -> string {
        sprintf!(
            "path: {} / ex: {} / {}",
            File_system::closure3((), v0_1),
            v1_1,
            File_system::closure4((), ())
        )
    }
    pub fn closure2(v0_1: string, v1_1: string, unitVar: ()) -> string {
        File_system::method3(v0_1, v1_1)
    }
    pub fn method2(v0_1: string, v1_1: i64) -> Arc<Async<i64>> {
        let _v2: MutCell<Option<Arc<Async<i64>>>> = MutCell::new(None::<Arc<Async<i64>>>);
        {
            let x: Arc<Async<i64>> = defaultOf();
            _v2.set(Some(x))
        }
        getValue(_v2.get().clone())
    }
    pub fn closure1(unitVar: (), v0_1: string) -> Arc<Async<i64>> {
        let _v1: MutCell<Option<Arc<Async<i64>>>> = MutCell::new(None::<Arc<Async<i64>>>);
        {
            let x: Arc<Async<i64>> = defaultOf();
            _v1.set(Some(x))
        }
        getValue(_v1.get().clone())
    }
    pub fn method5(v0_1: string, v1_1: i64, v2_1: string) -> string {
        sprintf!(
            "path: {} / retry: {} / ex: {} / {}",
            File_system::closure3((), v0_1),
            v1_1,
            v2_1,
            File_system::closure4((), ())
        )
    }
    pub fn closure7(v0_1: string, v1_1: i64, v2_1: string, unitVar: ()) -> string {
        File_system::method5(v0_1, v1_1, v2_1)
    }
    pub fn method4(
        v0_1: string,
        v1_1: File_system::US4,
        v2_1: File_system::US3,
        v3_1: i64,
    ) -> Arc<Async<i64>> {
        let _v4: MutCell<Option<Arc<Async<i64>>>> = MutCell::new(None::<Arc<Async<i64>>>);
        {
            let x: Arc<Async<i64>> = defaultOf();
            _v4.set(Some(x))
        }
        getValue(_v4.get().clone())
    }
    pub fn closure6(v0_1: File_system::US2, v1_1: string) -> Arc<Async<i64>> {
        let _v2: MutCell<Option<Arc<Async<i64>>>> = MutCell::new(None::<Arc<Async<i64>>>);
        {
            let x: Arc<Async<i64>> = defaultOf();
            _v2.set(Some(x))
        }
        getValue(_v2.get().clone())
    }
    pub fn closure5(unitVar: (), v0_1: File_system::US2) -> Func1<string, Arc<Async<i64>>> {
        Func1::new({
            let v0_1 = v0_1.clone();
            move |v: string| File_system::closure6(v0_1.clone(), v)
        })
    }
    pub fn method6(v0_1: string, v1_1: i64) -> Arc<Async<i64>> {
        let _v2: MutCell<Option<Arc<Async<i64>>>> = MutCell::new(None::<Arc<Async<i64>>>);
        {
            let x: Arc<Async<i64>> = defaultOf();
            _v2.set(Some(x))
        }
        getValue(_v2.get().clone())
    }
    pub fn closure8(unitVar: (), v0_1: string) -> Arc<Async<i64>> {
        let _v1: MutCell<Option<Arc<Async<i64>>>> = MutCell::new(None::<Arc<Async<i64>>>);
        {
            let x: Arc<Async<i64>> = defaultOf();
            _v1.set(Some(x))
        }
        getValue(_v1.get().clone())
    }
    pub fn closure9(unitVar: (), v0_1: string) -> Arc<Async<string>> {
        let _v1: MutCell<Option<Arc<Async<string>>>> = MutCell::new(None::<Arc<Async<string>>>);
        {
            let x: Arc<Async<string>> = defaultOf();
            _v1.set(Some(x))
        }
        getValue(_v1.get().clone())
    }
    pub fn method7(v0_1: string) -> string {
        v0_1
    }
    pub fn closure11(v0_1: string, v1_1: string) -> Arc<Async<bool>> {
        let _v2: MutCell<Option<Arc<Async<bool>>>> = MutCell::new(None::<Arc<Async<bool>>>);
        {
            let x: Arc<Async<bool>> = defaultOf();
            _v2.set(Some(x))
        }
        getValue(_v2.get().clone())
    }
    pub fn closure10(unitVar: (), v0_1: string) -> Func1<string, Arc<Async<bool>>> {
        Func1::new({
            let v0_1 = v0_1.clone();
            move |v: string| File_system::closure11(v0_1.clone(), v)
        })
    }
    pub fn closure13(v0_1: string, v1_1: string) -> Arc<Async<()>> {
        let _v2: MutCell<Option<Arc<Async<()>>>> = MutCell::new(None::<Arc<Async<()>>>);
        {
            let x: Arc<Async<()>> = defaultOf();
            _v2.set(Some(x))
        }
        getValue(_v2.get().clone())
    }
    pub fn closure12(unitVar: (), v0_1: string) -> Func1<string, Arc<Async<()>>> {
        Func1::new({
            let v0_1 = v0_1.clone();
            move |v: string| File_system::closure13(v0_1.clone(), v)
        })
    }
    pub fn closure15(v0_1: string, v1_1: string) -> Arc<Async<()>> {
        let _v2: MutCell<Option<Arc<Async<()>>>> = MutCell::new(None::<Arc<Async<()>>>);
        {
            let x: Arc<Async<()>> = defaultOf();
            _v2.set(Some(x))
        }
        getValue(_v2.get().clone())
    }
    pub fn closure14(unitVar: (), v0_1: string) -> Func1<string, Arc<Async<()>>> {
        Func1::new({
            let v0_1 = v0_1.clone();
            move |v: string| File_system::closure15(v0_1.clone(), v)
        })
    }
    pub fn closure17(unitVar: (), unitVar_1: ()) -> string {
        string("delete_file_async")
    }
    pub fn closure19(unitVar: (), v0_1: i64) -> File_system::US5 {
        File_system::US5::US5_0(v0_1)
    }
    pub fn method10() -> Func1<i64, File_system::US5> {
        Func1::new(move |v: i64| File_system::closure19((), v))
    }
    pub fn method11() -> string {
        string("")
    }
    pub fn closure18(
        v0_1: File_system::US0,
        v1_1: Func0<string>,
        v2_1: Func0<string>,
        unitVar: (),
    ) -> string {
        if File_system::State::trace_state().get().clone()
            == None::<(
                LrcPtr<File_system::Mut0>,
                LrcPtr<File_system::Mut1>,
                LrcPtr<File_system::Mut1>,
                LrcPtr<File_system::Mut2>,
                Option<i64>,
            )>
        {
            File_system::State::trace_state().set(Some(File_system::closure0((), ())));
        }
        {
            let patternInput: (
                LrcPtr<File_system::Mut0>,
                LrcPtr<File_system::Mut1>,
                LrcPtr<File_system::Mut1>,
                LrcPtr<File_system::Mut2>,
                Option<i64>,
            ) = getValue(File_system::State::trace_state().get().clone());
            let _v9: MutCell<Option<string>> = MutCell::new(None::<string>);
            {
                let x: string = File_system::method11();
                _v9.set(Some(x))
            }
            {
                let v60: string = getValue(_v9.get().clone());
                let v61: i64 = (patternInput.0.clone()).l0.get().clone();
                let v72: string = toLower(match &v0_1 {
                    File_system::US0::US0_1 => string("Debug"),
                    File_system::US0::US0_2 => string("Info"),
                    File_system::US0::US0_0 => string("Verbose"),
                    File_system::US0::US0_3 => string("Warning"),
                    _ => string("Critical"),
                });
                let _v73: MutCell<Option<string>> = MutCell::new(None::<string>);
                let v112: &str = match &v0_1 {
                    File_system::US0::US0_1 => inline_colorization::color_bright_blue,
                    File_system::US0::US0_2 => inline_colorization::color_bright_green,
                    File_system::US0::US0_0 => inline_colorization::color_bright_black,
                    File_system::US0::US0_3 => inline_colorization::color_bright_yellow,
                    _ => inline_colorization::color_bright_red,
                };
                let v114: &str = fable_library_rust::String_::LrcStr::as_str(&v72);
                let v116: &str = inline_colorization::color_reset;
                let v118: string = string("format!(\"{v112}{v114}{v116}\")");
                let v119: std::string::String = format!("{v112}{v114}{v116}");
                {
                    let x_1: string = fable_library_rust::String_::fromString(v119);
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
    pub fn method9(v0_1: File_system::US0, v1_1: Func0<string>, v2_1: Func0<string>) {
        let v3_1 = Func0::new(move || File_system::closure0((), ()));
        if File_system::State::trace_state().get().clone()
            == None::<(
                LrcPtr<File_system::Mut0>,
                LrcPtr<File_system::Mut1>,
                LrcPtr<File_system::Mut1>,
                LrcPtr<File_system::Mut2>,
                Option<i64>,
            )>
        {
            File_system::State::trace_state().set(Some(v3_1()));
        }
        {
            let v4_1: LrcPtr<File_system::Mut0> =
                (getValue(File_system::State::trace_state().get().clone()))
                    .0
                    .clone();
            if File_system::State::trace_state().get().clone()
                == None::<(
                    LrcPtr<File_system::Mut0>,
                    LrcPtr<File_system::Mut1>,
                    LrcPtr<File_system::Mut1>,
                    LrcPtr<File_system::Mut2>,
                    Option<i64>,
                )>
            {
                File_system::State::trace_state().set(Some(v3_1()));
            }
            {
                let patternInput_1: (
                    LrcPtr<File_system::Mut0>,
                    LrcPtr<File_system::Mut1>,
                    LrcPtr<File_system::Mut1>,
                    LrcPtr<File_system::Mut2>,
                    Option<i64>,
                ) = getValue(File_system::State::trace_state().get().clone());
                let v14_1: File_system::US0 = (patternInput_1.3.clone()).l0.get().clone();
                if if (patternInput_1.2.clone()).l0.get().clone() {
                    compare(v0_1.clone(), v14_1) >= 0_i32
                } else {
                    false
                } {
                    let v19: i64 = v4_1.l0.get().clone() + 1_i64;
                    v4_1.l0.set(v19);
                    {
                        let v21: string =
                            sprintf!("{}", File_system::closure18(v0_1, v1_1, v2_1, ()));
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
    pub fn method8(v0_1: string, v1_1: i64) -> Arc<Async<i64>> {
        let _v2: MutCell<Option<Arc<Async<i64>>>> = MutCell::new(None::<Arc<Async<i64>>>);
        {
            let x: Arc<Async<i64>> = defaultOf();
            _v2.set(Some(x))
        }
        getValue(_v2.get().clone())
    }
    pub fn closure16(unitVar: (), v0_1: string) -> Arc<Async<i64>> {
        let _v1: MutCell<Option<Arc<Async<i64>>>> = MutCell::new(None::<Arc<Async<i64>>>);
        {
            let x: Arc<Async<i64>> = defaultOf();
            _v1.set(Some(x))
        }
        getValue(_v1.get().clone())
    }
    pub fn closure22(unitVar: (), unitVar_1: ()) -> string {
        string("move_file_async")
    }
    pub fn method13(v0_1: string, v1_1: string, v2_1: LrcPtr<Exception>) -> string {
        let _v3: MutCell<Option<string>> = MutCell::new(None::<string>);
        {
            let x: string = sprintf!("{:?}", v2_1);
            _v3.set(Some(x))
        }
        {
            let v10_1: string = getValue(_v3.get().clone());
            let v11_1 = Func1::new(move |v: string| File_system::closure3((), v));
            sprintf!(
                "old_path: {} / new_path: {} / ex: {} / {}",
                v11_1(v1_1),
                v11_1(v0_1),
                v10_1,
                File_system::closure4((), ())
            )
        }
    }
    pub fn closure23(v0_1: string, v1_1: string, v2_1: LrcPtr<Exception>, unitVar: ()) -> string {
        File_system::method13(v0_1, v1_1, v2_1)
    }
    pub fn method12(v0_1: string, v1_1: string, v2_1: i64) -> Arc<Async<i64>> {
        let _v3: MutCell<Option<Arc<Async<i64>>>> = MutCell::new(None::<Arc<Async<i64>>>);
        {
            let x: Arc<Async<i64>> = defaultOf();
            _v3.set(Some(x))
        }
        getValue(_v3.get().clone())
    }
    pub fn closure21(v0_1: string, v1_1: string) -> Arc<Async<i64>> {
        let _v2: MutCell<Option<Arc<Async<i64>>>> = MutCell::new(None::<Arc<Async<i64>>>);
        {
            let x: Arc<Async<i64>> = defaultOf();
            _v2.set(Some(x))
        }
        getValue(_v2.get().clone())
    }
    pub fn closure20(unitVar: (), v0_1: string) -> Func1<string, Arc<Async<i64>>> {
        Func1::new({
            let v0_1 = v0_1.clone();
            move |v: string| File_system::closure21(v0_1.clone(), v)
        })
    }
    pub fn closure25(unitVar: (), v0_1: i64) -> File_system::US6 {
        File_system::US6::US6_0(v0_1)
    }
    pub fn closure26(unitVar: (), v0_1: LrcPtr<Exception>) -> File_system::US6 {
        File_system::US6::US6_1(v0_1)
    }
    pub fn closure27(unitVar: (), unitVar_1: ()) -> string {
        string("run_with_timeout_async")
    }
    pub fn closure28(unitVar: (), unitVar_1: ()) -> string {
        sprintf!("timeout: {} / {}", 1000_i32, File_system::closure4((), ()))
    }
    pub fn closure29(v0_1: string, unitVar: ()) -> string {
        sprintf!("run_with_timeout_async** / ex: {}", v0_1)
    }
    pub fn closure30(unitVar: (), unitVar_1: ()) -> string {
        string("read_all_text_retry_async")
    }
    pub fn method15(v0_1: i64, v1_1: string) -> string {
        sprintf!(
            "retry: {} / ex: {} / {}",
            v0_1,
            v1_1,
            File_system::closure4((), ())
        )
    }
    pub fn closure31(v0_1: i64, v1_1: string, unitVar: ()) -> string {
        File_system::method15(v0_1, v1_1)
    }
    pub fn method14(v0_1: string, v1_1: i64) -> Arc<Async<Option<string>>> {
        let _v2: MutCell<Option<Arc<Async<Option<string>>>>> =
            MutCell::new(None::<Arc<Async<Option<string>>>>);
        {
            let x: Arc<Async<Option<string>>> = defaultOf();
            _v2.set(Some(x))
        }
        getValue(_v2.get().clone())
    }
    pub fn closure24(unitVar: (), v0_1: string) -> Arc<Async<Option<string>>> {
        let _v1: MutCell<Option<Arc<Async<Option<string>>>>> =
            MutCell::new(None::<Arc<Async<Option<string>>>>);
        {
            let x: Arc<Async<Option<string>>> = defaultOf();
            _v1.set(Some(x))
        }
        getValue(_v1.get().clone())
    }
    pub fn closure33(unitVar: (), unitVar_1: ()) -> string {
        let _v0: MutCell<Option<string>> = MutCell::new(None::<string>);
        {
            let x: string = unbox::<string>(&defaultOf());
            _v0.set(Some(x))
        }
        getValue(_v0.get().clone())
    }
    pub fn method16(v0_1: string) -> string {
        v0_1
    }
    pub fn method17(v0_1: string) -> string {
        v0_1
    }
    pub fn closure32(unitVar: (), unitVar_1: ()) -> string {
        let _v0: MutCell<Option<string>> = MutCell::new(None::<string>);
        {
            let x: string = unbox::<string>(&defaultOf());
            _v0.set(Some(x))
        }
        getValue(_v0.get().clone())
    }
    pub fn closure35(v0_1: string, v1_1: string, unitVar: ()) -> string {
        sprintf!(
            "temp_folder: {} / result: {} {}",
            v0_1,
            v1_1,
            File_system::closure4((), ())
        )
    }
    pub fn closure36(v0_1: string, unitVar: ()) {
        let _v1: MutCell<Option<Arc<Async<i64>>>> = MutCell::new(None::<Arc<Async<i64>>>);
        {
            let x: Arc<Async<i64>> = defaultOf();
            _v1.set(Some(x))
        }
        {
            let v9_1: Arc<Async<i64>> = getValue(_v1.get().clone());
            let _v10: MutCell<Option<Arc<Async<()>>>> = MutCell::new(None::<Arc<Async<()>>>);
            {
                let x_1: Arc<Async<()>> = defaultOf();
                _v10.set(Some(x_1))
            }
            {
                let v18: Arc<Async<()>> = getValue(_v10.get().clone());
                let _v19: MutCell<Option<()>> = MutCell::new(None::<()>);
                defaultOf::<()>();
                _v19.set(Some(()));
                getValue(_v19.get().clone());
                ()
            }
        }
    }
    pub fn closure34(unitVar: (), unitVar_1: ()) -> (string, LrcPtr<dyn IDisposable>) {
        let _v0: MutCell<Option<(string, LrcPtr<dyn IDisposable>)>> =
            MutCell::new(None::<(string, LrcPtr<dyn IDisposable>)>);
        let patternInput: (string, LrcPtr<dyn IDisposable>) =
            unbox::<(string, LrcPtr<dyn IDisposable>)>(&defaultOf());
        _v0.set(Some((patternInput.0.clone(), patternInput.1.clone())));
        {
            let patternInput_1: (string, LrcPtr<dyn IDisposable>) = getValue(_v0.get().clone());
            (patternInput_1.0.clone(), patternInput_1.1.clone())
        }
    }
    pub fn closure37(unitVar: (), unitVar_1: ()) -> string {
        string("C:\\home\\git\\polyglot\\lib\\spiral")
    }
    pub fn closure41(unitVar: (), v0_1: string) -> bool {
        let _v1: MutCell<Option<bool>> = MutCell::new(None::<bool>);
        {
            let x: bool = unbox::<bool>(&defaultOf());
            _v1.set(Some(x))
        }
        getValue(_v1.get().clone())
    }
    pub fn closure42(unitVar: (), v0_1: string) -> bool {
        let _v1: MutCell<Option<bool>> = MutCell::new(None::<bool>);
        {
            let x: bool = unbox::<bool>(&defaultOf());
            _v1.set(Some(x))
        }
        getValue(_v1.get().clone())
    }
    pub fn closure43(unitVar: (), v0_1: string) -> Option<string> {
        let _v1: MutCell<Option<File_system::US8>> = MutCell::new(None::<File_system::US8>);
        {
            let x: File_system::US8 = unbox::<File_system::US8>(&defaultOf());
            _v1.set(Some(x))
        }
        {
            let v41: File_system::US8 = getValue(_v1.get().clone());
            match &v41 {
                File_system::US8::US8_0(v41_0_0) => Some(match &v41 {
                    File_system::US8::US8_0(x) => x.clone(),
                    _ => unreachable!(),
                }),
                _ => None::<string>,
            }
        }
    }
    pub fn method19() -> Func1<string, Option<string>> {
        Func1::new(move |v: string| File_system::closure43((), v))
    }
    pub fn closure44(unitVar: (), v0_1: string) -> File_system::US8 {
        File_system::US8::US8_0(v0_1)
    }
    pub fn method20() -> Func1<string, File_system::US8> {
        Func1::new(move |v: string| File_system::closure44((), v))
    }
    pub fn method21(v0_1: string, v1_1: bool, v2_1: string, v3_1: string) -> string {
        let v0_1: MutCell<string> = MutCell::new(v0_1.clone());
        let v1_1: MutCell<bool> = MutCell::new(v1_1);
        let v2_1: MutCell<string> = MutCell::new(v2_1.clone());
        let v3_1: MutCell<string> = MutCell::new(v3_1.clone());
        '_method21: loop {
            break '_method21 ({
                let _v4: MutCell<Option<string>> = MutCell::new(None::<string>);
                {
                    let x: string = unbox::<string>(&defaultOf());
                    _v4.set(Some(x))
                }
                if (if v1_1.get().clone() {
                    Func1::new(move |v: string| File_system::closure41((), v))
                } else {
                    Func1::new(move |v_1: string| File_system::closure42((), v_1))
                })(getValue(_v4.get().clone()))
                {
                    v3_1.get().clone()
                } else {
                    let v39: Option<string> = (File_system::method19())(v3_1.get().clone());
                    let v42: File_system::US8 =
                        defaultValue(File_system::US8::US8_1, map(File_system::method20(), v39));
                    match &v42 {
                        File_system::US8::US8_0(v42_0_0) => {
                            let v0_1_temp: string = v0_1.get().clone();
                            let v1_1_temp: bool = v1_1.get().clone();
                            let v2_1_temp: string = v2_1.get().clone();
                            let v3_1_temp: string = match &v42 {
                                File_system::US8::US8_0(x) => x.clone(),
                                _ => unreachable!(),
                            };
                            v0_1.set(v0_1_temp);
                            v1_1.set(v1_1_temp);
                            v2_1.set(v2_1_temp);
                            v3_1.set(v3_1_temp);
                            continue '_method21;
                        }
                        _ => panic!(
                            "{}",
                            sprintf!(
                                "No parent for {} \'{}\' at \'{}\' (until \'{}\')",
                                if v1_1.get().clone() {
                                    string("file")
                                } else {
                                    string("dir")
                                },
                                v0_1.get().clone(),
                                v2_1.get().clone(),
                                v3_1.get().clone()
                            ),
                        ),
                    }
                }
            });
        }
    }
    pub fn method18(v0_1: string, v1_1: bool, v2_1: string) -> string {
        let _v3: MutCell<Option<string>> = MutCell::new(None::<string>);
        {
            let x: string = unbox::<string>(&defaultOf());
            _v3.set(Some(x))
        }
        if (if v1_1 {
            Func1::new(move |v: string| File_system::closure41((), v))
        } else {
            Func1::new(move |v_1: string| File_system::closure42((), v_1))
        })(getValue(_v3.get().clone()))
        {
            v2_1.clone()
        } else {
            let v38: Option<string> = (File_system::method19())(v2_1.clone());
            let v41: File_system::US8 =
                defaultValue(File_system::US8::US8_1, map(File_system::method20(), v38));
            match &v41 {
                File_system::US8::US8_0(v41_0_0) => File_system::method21(
                    v0_1.clone(),
                    v1_1,
                    v2_1.clone(),
                    match &v41 {
                        File_system::US8::US8_0(x) => x.clone(),
                        _ => unreachable!(),
                    },
                ),
                _ => panic!(
                    "{}",
                    sprintf!(
                        "No parent for {} \'{}\' at \'{}\' (until \'{}\')",
                        if v1_1 { string("file") } else { string("dir") },
                        v0_1.clone(),
                        v2_1.clone(),
                        v2_1.clone()
                    ),
                ),
            }
        }
    }
    pub fn closure40(v0_1: string, v1_1: bool, v2_1: string) -> string {
        File_system::method18(v0_1, v1_1, v2_1)
    }
    pub fn closure39(v0_1: string, v1_1: bool) -> Func1<string, string> {
        Func1::new({
            let v0_1 = v0_1.clone();
            let v1_1 = v1_1.clone();
            move |v: string| File_system::closure40(v0_1.clone(), v1_1, v)
        })
    }
    pub fn closure38(unitVar: (), v0_1: string) -> Func1<bool, Func1<string, string>> {
        Func1::new({
            let v0_1 = v0_1.clone();
            move |v: bool| File_system::closure39(v0_1.clone(), v)
        })
    }
    pub fn method22() -> string {
        string("polyglot")
    }
    pub fn method23() -> string {
        string(".paket")
    }
    pub fn method24() -> string {
        string("polyglot")
    }
    pub fn method25() -> string {
        string(".paket")
    }
    pub fn method27(v0_1: string, v1_1: string, v2_1: string) -> string {
        let v0_1: MutCell<string> = MutCell::new(v0_1.clone());
        let v1_1: MutCell<string> = MutCell::new(v1_1.clone());
        let v2_1: MutCell<string> = MutCell::new(v2_1.clone());
        '_method27: loop {
            break '_method27 ({
                let _v3: MutCell<Option<string>> = MutCell::new(None::<string>);
                {
                    let x: string = unbox::<string>(&defaultOf());
                    _v3.set(Some(x))
                }
                {
                    let v32: string = getValue(_v3.get().clone());
                    let _v33: MutCell<Option<bool>> = MutCell::new(None::<bool>);
                    {
                        let x_1: bool = unbox::<bool>(&defaultOf());
                        _v33.set(Some(x_1))
                    }
                    if getValue(_v33.get().clone()) {
                        v2_1.get().clone()
                    } else {
                        let v57: Option<string> = (File_system::method19())(v2_1.get().clone());
                        let v60: File_system::US8 = defaultValue(
                            File_system::US8::US8_1,
                            map(File_system::method20(), v57),
                        );
                        match &v60 {
                            File_system::US8::US8_0(v60_0_0) => {
                                let v0_1_temp: string = v0_1.get().clone();
                                let v1_1_temp: string = v1_1.get().clone();
                                let v2_1_temp: string = match &v60 {
                                    File_system::US8::US8_0(x) => x.clone(),
                                    _ => unreachable!(),
                                };
                                v0_1.set(v0_1_temp);
                                v1_1.set(v1_1_temp);
                                v2_1.set(v2_1_temp);
                                continue '_method27;
                            }
                            _ => panic!(
                                "{}",
                                sprintf!(
                                    "No parent for {} \'{}\' at \'{}\' (until \'{}\')",
                                    string("dir"),
                                    v0_1.get().clone(),
                                    v1_1.get().clone(),
                                    v2_1.get().clone()
                                ),
                            ),
                        }
                    }
                }
            });
        }
    }
    pub fn method26(v0_1: string, v1_1: string) -> string {
        let _v2: MutCell<Option<string>> = MutCell::new(None::<string>);
        {
            let x: string = unbox::<string>(&defaultOf());
            _v2.set(Some(x))
        }
        {
            let v31: string = getValue(_v2.get().clone());
            let _v32: MutCell<Option<bool>> = MutCell::new(None::<bool>);
            {
                let x_1: bool = unbox::<bool>(&defaultOf());
                _v32.set(Some(x_1))
            }
            if getValue(_v32.get().clone()) {
                v1_1.clone()
            } else {
                let v56: Option<string> = (File_system::method19())(v1_1.clone());
                let v59: File_system::US8 =
                    defaultValue(File_system::US8::US8_1, map(File_system::method20(), v56));
                match &v59 {
                    File_system::US8::US8_0(v59_0_0) => File_system::method27(
                        v0_1.clone(),
                        v1_1.clone(),
                        match &v59 {
                            File_system::US8::US8_0(x) => x.clone(),
                            _ => unreachable!(),
                        },
                    ),
                    _ => panic!(
                        "{}",
                        sprintf!(
                            "No parent for {} \'{}\' at \'{}\' (until \'{}\')",
                            string("dir"),
                            v0_1.clone(),
                            v1_1.clone(),
                            v1_1.clone()
                        ),
                    ),
                }
            }
        }
    }
    pub fn method28() -> string {
        string("polyglot")
    }
    pub fn closure45(unitVar: (), unitVar_1: ()) -> string {
        let _v1: MutCell<Option<string>> = MutCell::new(None::<string>);
        {
            let x: string = unbox::<string>(&defaultOf());
            _v1.set(Some(x))
        }
        {
            let v33: string = File_system::method26(
                getValue(_v1.get().clone()),
                string("C:\\home\\git\\polyglot\\lib\\spiral"),
            );
            let _v34: MutCell<Option<string>> = MutCell::new(None::<string>);
            {
                let x_1: string = unbox::<string>(&defaultOf());
                _v34.set(Some(x_1))
            }
            getValue(_v34.get().clone())
        }
    }
    pub fn closure47(v0_1: string, v1_1: string) -> string {
        let _v2: MutCell<Option<string>> = MutCell::new(None::<string>);
        {
            let x: string = unbox::<string>(&defaultOf());
            _v2.set(Some(x))
        }
        getValue(_v2.get().clone())
    }
    pub fn closure46(unitVar: (), v0_1: string) -> Func1<string, string> {
        Func1::new({
            let v0_1 = v0_1.clone();
            move |v: string| File_system::closure47(v0_1.clone(), v)
        })
    }
    pub fn v0() -> Func0<(
        LrcPtr<File_system::Mut0>,
        LrcPtr<File_system::Mut1>,
        LrcPtr<File_system::Mut1>,
        LrcPtr<File_system::Mut2>,
        Option<i64>,
    )> {
        static v0: OnceInit<
            Func0<(
                LrcPtr<File_system::Mut0>,
                LrcPtr<File_system::Mut1>,
                LrcPtr<File_system::Mut1>,
                LrcPtr<File_system::Mut2>,
                Option<i64>,
            )>,
        > = OnceInit::new();
        v0.get_or_init(|| Func0::new(move || File_system::closure0((), ())))
            .clone()
    }
    on_startup!(if File_system::State::trace_state().get().clone()
        == None::<(
            LrcPtr<File_system::Mut0>,
            LrcPtr<File_system::Mut1>,
            LrcPtr<File_system::Mut1>,
            LrcPtr<File_system::Mut2>,
            Option<i64>
        )> {
        File_system::State::trace_state().set(Some((File_system::v0())()));
    });
    pub fn v1() -> Func1<string, Arc<Async<i64>>> {
        static v1: OnceInit<Func1<string, Arc<Async<i64>>>> = OnceInit::new();
        v1.get_or_init(|| Func1::new(move |v: string| File_system::closure1((), v)))
            .clone()
    }
    pub fn delete_directory_async(x: string) -> Arc<Async<i64>> {
        (File_system::v1())(x)
    }
    pub fn v2() -> Func1<File_system::US2, Func1<string, Arc<Async<i64>>>> {
        static v2: OnceInit<Func1<File_system::US2, Func1<string, Arc<Async<i64>>>>> =
            OnceInit::new();
        v2.get_or_init(|| Func1::new(move |v: File_system::US2| File_system::closure5((), v)))
            .clone()
    }
    pub fn wait_for_file_access(x: File_system::US2) -> Func1<string, Arc<Async<i64>>> {
        (File_system::v2())(x)
    }
    pub fn v3() -> Func1<string, Arc<Async<i64>>> {
        static v3: OnceInit<Func1<string, Arc<Async<i64>>>> = OnceInit::new();
        v3.get_or_init(|| Func1::new(move |v: string| File_system::closure8((), v)))
            .clone()
    }
    pub fn wait_for_file_access_read(x: string) -> Arc<Async<i64>> {
        (File_system::v3())(x)
    }
    pub fn v4() -> Func1<string, Arc<Async<string>>> {
        static v4: OnceInit<Func1<string, Arc<Async<string>>>> = OnceInit::new();
        v4.get_or_init(|| Func1::new(move |v: string| File_system::closure9((), v)))
            .clone()
    }
    pub fn read_all_text_async(x: string) -> Arc<Async<string>> {
        (File_system::v4())(x)
    }
    pub fn v5() -> Func1<string, Func1<string, Arc<Async<bool>>>> {
        static v5: OnceInit<Func1<string, Func1<string, Arc<Async<bool>>>>> = OnceInit::new();
        v5.get_or_init(|| Func1::new(move |v: string| File_system::closure10((), v)))
            .clone()
    }
    pub fn file_exists_content(x: string) -> Func1<string, Arc<Async<bool>>> {
        (File_system::v5())(x)
    }
    pub fn v6() -> Func1<string, Func1<string, Arc<Async<()>>>> {
        static v6: OnceInit<Func1<string, Func1<string, Arc<Async<()>>>>> = OnceInit::new();
        v6.get_or_init(|| Func1::new(move |v: string| File_system::closure12((), v)))
            .clone()
    }
    pub fn write_all_text_async(x: string) -> Func1<string, Arc<Async<()>>> {
        (File_system::v6())(x)
    }
    pub fn v7() -> Func1<string, Func1<string, Arc<Async<()>>>> {
        static v7: OnceInit<Func1<string, Func1<string, Arc<Async<()>>>>> = OnceInit::new();
        v7.get_or_init(|| Func1::new(move |v: string| File_system::closure14((), v)))
            .clone()
    }
    pub fn write_all_text_exists(x: string) -> Func1<string, Arc<Async<()>>> {
        (File_system::v7())(x)
    }
    pub fn v8() -> Func1<string, Arc<Async<i64>>> {
        static v8: OnceInit<Func1<string, Arc<Async<i64>>>> = OnceInit::new();
        v8.get_or_init(|| Func1::new(move |v: string| File_system::closure16((), v)))
            .clone()
    }
    pub fn delete_file_async(x: string) -> Arc<Async<i64>> {
        (File_system::v8())(x)
    }
    pub fn v9() -> Func1<string, Func1<string, Arc<Async<i64>>>> {
        static v9: OnceInit<Func1<string, Func1<string, Arc<Async<i64>>>>> = OnceInit::new();
        v9.get_or_init(|| Func1::new(move |v: string| File_system::closure20((), v)))
            .clone()
    }
    pub fn move_file_async(x: string) -> Func1<string, Arc<Async<i64>>> {
        (File_system::v9())(x)
    }
    pub fn v10() -> Func1<string, Arc<Async<Option<string>>>> {
        static v10: OnceInit<Func1<string, Arc<Async<Option<string>>>>> = OnceInit::new();
        v10.get_or_init(|| Func1::new(move |v: string| File_system::closure24((), v)))
            .clone()
    }
    pub fn read_all_text_retry_async(x: string) -> Arc<Async<Option<string>>> {
        (File_system::v10())(x)
    }
    pub fn v11() -> Func0<string> {
        static v11: OnceInit<Func0<string>> = OnceInit::new();
        v11.get_or_init(|| Func0::new(move || File_system::closure32((), ())))
            .clone()
    }
    pub fn create_temp_directory_name() -> string {
        (File_system::v11())()
    }
    pub fn v12() -> Func0<(string, LrcPtr<dyn IDisposable>)> {
        static v12: OnceInit<Func0<(string, LrcPtr<dyn IDisposable>)>> = OnceInit::new();
        v12.get_or_init(|| Func0::new(move || File_system::closure34((), ())))
            .clone()
    }
    pub fn create_temp_directory() -> (string, LrcPtr<dyn IDisposable>) {
        (File_system::v12())()
    }
    pub fn v13() -> Func0<string> {
        static v13: OnceInit<Func0<string>> = OnceInit::new();
        v13.get_or_init(|| Func0::new(move || File_system::closure37((), ())))
            .clone()
    }
    pub fn get_source_directory() -> string {
        (File_system::v13())()
    }
    pub fn v14() -> Func1<string, Func1<bool, Func1<string, string>>> {
        static v14: OnceInit<Func1<string, Func1<bool, Func1<string, string>>>> = OnceInit::new();
        v14.get_or_init(|| Func1::new(move |v: string| File_system::closure38((), v)))
            .clone()
    }
    pub fn find_parent(x: string) -> Func1<bool, Func1<string, string>> {
        (File_system::v14())(x)
    }
    pub fn v15() -> Func0<string> {
        static v15: OnceInit<Func0<string>> = OnceInit::new();
        v15.get_or_init(|| Func0::new(move || File_system::closure45((), ())))
            .clone()
    }
    pub fn get_repository_root() -> string {
        (File_system::v15())()
    }
    pub fn v16() -> Func1<string, Func1<string, string>> {
        static v16: OnceInit<Func1<string, Func1<string, string>>> = OnceInit::new();
        v16.get_or_init(|| Func1::new(move |v: string| File_system::closure46((), v)))
            .clone()
    }
    pub fn op_LessDivideGreater(x: string) -> Func1<string, string> {
        (File_system::v16())(x)
    }
    on_startup!(());
}
