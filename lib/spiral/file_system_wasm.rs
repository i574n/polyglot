pub mod File_system {
    use super::*;
    type Async<T> = T;
    use fable_library_rust::Interfaces_::System::Collections::Generic::IEnumerable_1;
    use fable_library_rust::Interfaces_::System::IDisposable;
    use fable_library_rust::List_::ofArray;
    use fable_library_rust::Map_::find;
    use fable_library_rust::Map_::ofSeq;
    use fable_library_rust::NativeArray_::new_array;
    use fable_library_rust::NativeArray_::new_empty;
    use fable_library_rust::NativeArray_::Array;
    use fable_library_rust::Native_::defaultOf;
    use fable_library_rust::Native_::interface_cast;
    use fable_library_rust::Native_::on_startup;
    use fable_library_rust::Native_::unbox;
    use fable_library_rust::Native_::Arc;
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
    use fable_library_rust::String_::getCharAt;
    use fable_library_rust::String_::getSlice;
    use fable_library_rust::String_::padRight;
    use fable_library_rust::String_::replace;
    use fable_library_rust::String_::sprintf;
    use fable_library_rust::String_::string;
    use fable_library_rust::String_::toLower;
    use fable_library_rust::String_::toLowerChar;
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
                    LrcPtr<File_system::Mut2>,
                    Option<i64>,
                    LrcPtr<File_system::Mut3>,
                )>,
            >,
        > {
            static trace_state: OnceInit<
                LrcPtr<
                    MutCell<
                        Option<(
                            LrcPtr<File_system::Mut0>,
                            LrcPtr<File_system::Mut1>,
                            LrcPtr<File_system::Mut2>,
                            Option<i64>,
                            LrcPtr<File_system::Mut3>,
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
                            LrcPtr<File_system::Mut2>,
                            Option<i64>,
                            LrcPtr<File_system::Mut3>,
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
    #[derive(Clone, Debug)]
    pub struct Disposable {
        f: Func0<()>,
    }
    impl File_system::Disposable {
        pub fn _ctor__3A5B6456(f: Func0<()>) -> LrcPtr<File_system::Disposable> {
            let f_1;
            ();
            f_1 = f;
            ();
            LrcPtr::new(File_system::Disposable { f: f_1 })
        }
    }
    impl core::fmt::Display for File_system::Disposable {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    impl IDisposable for Disposable {
        fn Dispose(&self) {
            (self.f)();
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
    #[derive(Clone, Debug)]
    pub struct Mut3 {
        pub l0: MutCell<Func1<string, ()>>,
    }
    impl core::fmt::Display for File_system::Mut3 {
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
    pub enum US2 {
        US2_0(i64),
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
    pub enum US4 {
        US4_0,
        US4_1,
        US4_2,
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
    }
    impl core::fmt::Display for File_system::US4 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Copy, Debug, PartialEq, PartialOrd, Hash, Eq)]
    pub enum US5 {
        US5_0,
        US5_1,
        US5_2,
        US5_3,
        US5_4,
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
        pub fn get_IsUS5_2(this_: &MutCell<File_system::US5>, unitArg: ()) -> bool {
            if unreachable!() {
                true
            } else {
                false
            }
        }
        pub fn get_IsUS5_3(this_: &MutCell<File_system::US5>, unitArg: ()) -> bool {
            if unreachable!() {
                true
            } else {
                false
            }
        }
        pub fn get_IsUS5_4(this_: &MutCell<File_system::US5>, unitArg: ()) -> bool {
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
    #[derive(Clone, Copy, Debug, PartialEq, PartialOrd, Hash, Eq)]
    pub enum US3 {
        US3_0(File_system::US4, File_system::US5),
        US3_1,
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
    }
    impl core::fmt::Display for File_system::US3 {
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
    #[derive(Clone, Debug)]
    pub enum US8 {
        US8_0(Option<()>),
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
    #[derive(Clone, Debug, PartialEq, PartialOrd, Hash, Eq)]
    pub enum US9 {
        US9_0(string),
        US9_1,
    }
    impl File_system::US9 {
        pub fn get_IsUS9_0(this_: &MutCell<File_system::US9>, unitArg: ()) -> bool {
            if unreachable!() {
                true
            } else {
                false
            }
        }
        pub fn get_IsUS9_1(this_: &MutCell<File_system::US9>, unitArg: ()) -> bool {
            if unreachable!() {
                true
            } else {
                false
            }
        }
    }
    impl core::fmt::Display for File_system::US9 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Debug)]
    pub enum US10 {
        US10_0,
        US10_1(std::string::String),
    }
    impl File_system::US10 {
        pub fn get_IsUS10_0(this_: &MutCell<File_system::US10>, unitArg: ()) -> bool {
            if unreachable!() {
                true
            } else {
                false
            }
        }
        pub fn get_IsUS10_1(this_: &MutCell<File_system::US10>, unitArg: ()) -> bool {
            if unreachable!() {
                true
            } else {
                false
            }
        }
    }
    impl core::fmt::Display for File_system::US10 {
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
        LrcPtr<File_system::Mut0>,
        LrcPtr<File_system::Mut1>,
        LrcPtr<File_system::Mut2>,
        Option<i64>,
        LrcPtr<File_system::Mut3>,
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
        let v5_1: LrcPtr<File_system::Mut3> = LrcPtr::new(File_system::Mut3 {
            l0: MutCell::new(Func1::new(move |v: string| File_system::closure1((), v))),
        });
        let _v6: MutCell<Option<Option<i64>>> = MutCell::new(None::<Option<i64>>);
        {
            let x: Option<i64> = File_system::method1(None::<i64>);
            _v6.set(Some(x))
        }
        (v1_1, v0_1, v3_1, getValue(_v6.get().clone()), v5_1)
    }
    pub fn closure3(unitVar: (), unitVar_1: ()) -> string {
        string("file_system.delete_directory_async")
    }
    pub fn closure5(unitVar: (), v0_1: string) -> string {
        let _v1: MutCell<Option<string>> = MutCell::new(None::<string>);
        {
            let x: string = unbox::<string>(&defaultOf());
            _v1.set(Some(x))
        }
        getValue(_v1.get().clone())
    }
    pub fn closure6(unitVar: (), unitVar_1: ()) -> string {
        string("")
    }
    pub fn closure4(v0_1: string, v1_1: string, unitVar: ()) -> string {
        sprintf!(
            "path: {} / ex: {} / {}",
            File_system::closure5((), v0_1),
            v1_1,
            File_system::closure6((), ())
        )
    }
    pub fn closure8(unitVar: (), v0_1: i64) -> File_system::US2 {
        File_system::US2::US2_0(v0_1)
    }
    pub fn method4() -> Func1<i64, File_system::US2> {
        Func1::new(move |v: i64| File_system::closure8((), v))
    }
    pub fn method5() -> string {
        string("")
    }
    pub fn closure7(
        v0_1: File_system::US0,
        v1_1: Func0<string>,
        v2_1: Func0<string>,
        unitVar: (),
    ) -> string {
        if File_system::State::trace_state().get().clone().is_none() {
            File_system::State::trace_state().set(Some(File_system::closure0((), ())));
        }
        {
            let patternInput: (
                LrcPtr<File_system::Mut0>,
                LrcPtr<File_system::Mut1>,
                LrcPtr<File_system::Mut2>,
                Option<i64>,
                LrcPtr<File_system::Mut3>,
            ) = getValue(File_system::State::trace_state().get().clone());
            let _v9: MutCell<Option<string>> = MutCell::new(None::<string>);
            {
                let x: string = File_system::method5();
                _v9.set(Some(x))
            }
            {
                let v61: string = getValue(_v9.get().clone());
                let v62: i64 = (patternInput.0.clone()).l0.get().clone();
                let v74: string = padRight(
                    toLower(match &v0_1 {
                        File_system::US0::US0_1 => string("Debug"),
                        File_system::US0::US0_2 => string("Info"),
                        File_system::US0::US0_0 => string("Verbose"),
                        File_system::US0::US0_3 => string("Warning"),
                        _ => string("Critical"),
                    }),
                    7_i32,
                    ' ',
                );
                let _v75: MutCell<Option<string>> = MutCell::new(None::<string>);
                let v115: &str = match &v0_1 {
                    File_system::US0::US0_1 => inline_colorization::color_bright_blue,
                    File_system::US0::US0_2 => inline_colorization::color_bright_green,
                    File_system::US0::US0_0 => inline_colorization::color_bright_black,
                    File_system::US0::US0_3 => inline_colorization::color_bright_yellow,
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
    pub fn method6(v0_1: File_system::US0, v1_1: Func0<string>) {
        let v2_1 = Func0::new(move || File_system::closure0((), ()));
        if File_system::State::trace_state().get().clone().is_none() {
            File_system::State::trace_state().set(Some(v2_1()));
        }
        {
            let patternInput: (
                LrcPtr<File_system::Mut0>,
                LrcPtr<File_system::Mut1>,
                LrcPtr<File_system::Mut2>,
                Option<i64>,
                LrcPtr<File_system::Mut3>,
            ) = getValue(File_system::State::trace_state().get().clone());
            let v3_1: LrcPtr<File_system::Mut0> = patternInput.0.clone();
            if File_system::State::trace_state().get().clone().is_none() {
                File_system::State::trace_state().set(Some(v2_1()));
            }
            {
                let patternInput_1: (
                    LrcPtr<File_system::Mut0>,
                    LrcPtr<File_system::Mut1>,
                    LrcPtr<File_system::Mut2>,
                    Option<i64>,
                    LrcPtr<File_system::Mut3>,
                ) = getValue(File_system::State::trace_state().get().clone());
                let v13_1: File_system::US0 = (patternInput_1.2.clone()).l0.get().clone();
                if if (patternInput_1.1.clone()).l0.get().clone() == false {
                    false
                } else {
                    find(
                        v0_1,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((File_system::US0::US0_0, 0_i32)),
                            LrcPtr::new((File_system::US0::US0_1, 1_i32)),
                            LrcPtr::new((File_system::US0::US0_2, 2_i32)),
                            LrcPtr::new((File_system::US0::US0_3, 3_i32)),
                            LrcPtr::new((File_system::US0::US0_4, 4_i32)),
                        ])))),
                    ) >= find(
                        v13_1,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((File_system::US0::US0_0, 0_i32)),
                            LrcPtr::new((File_system::US0::US0_1, 1_i32)),
                            LrcPtr::new((File_system::US0::US0_2, 2_i32)),
                            LrcPtr::new((File_system::US0::US0_3, 3_i32)),
                            LrcPtr::new((File_system::US0::US0_4, 4_i32)),
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
    pub fn method3(v0_1: File_system::US0, v1_1: Func0<string>, v2_1: Func0<string>) {
        File_system::method6(
            v0_1.clone(),
            Func0::new({
                let v0_1 = v0_1.clone();
                let v1_1 = v1_1.clone();
                let v2_1 = v2_1.clone();
                move || File_system::closure7(v0_1.clone(), v1_1.clone(), v2_1.clone(), ())
            }),
        );
    }
    pub fn method2(v0_1: string, v1_1: i64) -> Arc<Async<i64>> {
        let _v2: MutCell<Option<Arc<Async<i64>>>> = MutCell::new(None::<Arc<Async<i64>>>);
        {
            let x: Arc<Async<i64>> = defaultOf();
            _v2.set(Some(x))
        }
        getValue(_v2.get().clone())
    }
    pub fn closure2(unitVar: (), v0_1: string) -> Arc<Async<i64>> {
        let _v1: MutCell<Option<Arc<Async<i64>>>> = MutCell::new(None::<Arc<Async<i64>>>);
        {
            let x: Arc<Async<i64>> = defaultOf();
            _v1.set(Some(x))
        }
        getValue(_v1.get().clone())
    }
    pub fn closure11(unitVar: (), unitVar_1: ()) -> string {
        string("file_system.wait_for_file_access")
    }
    pub fn closure12(v0_1: string, v1_1: i64, v2_1: string, unitVar: ()) -> string {
        sprintf!(
            "path: {} / retry: {} / ex: {} / {}",
            File_system::closure5((), v0_1),
            v1_1,
            v2_1,
            File_system::closure6((), ())
        )
    }
    pub fn method7(
        v0_1: string,
        v1_1: File_system::US5,
        v2_1: File_system::US4,
        v3_1: i64,
    ) -> Arc<Async<i64>> {
        let _v4: MutCell<Option<Arc<Async<i64>>>> = MutCell::new(None::<Arc<Async<i64>>>);
        {
            let x: Arc<Async<i64>> = defaultOf();
            _v4.set(Some(x))
        }
        getValue(_v4.get().clone())
    }
    pub fn closure10(v0_1: File_system::US3, v1_1: string) -> Arc<Async<i64>> {
        let _v2: MutCell<Option<Arc<Async<i64>>>> = MutCell::new(None::<Arc<Async<i64>>>);
        {
            let x: Arc<Async<i64>> = defaultOf();
            _v2.set(Some(x))
        }
        getValue(_v2.get().clone())
    }
    pub fn closure9(unitVar: (), v0_1: File_system::US3) -> Func1<string, Arc<Async<i64>>> {
        Func1::new({
            let v0_1 = v0_1.clone();
            move |v: string| File_system::closure10(v0_1.clone(), v)
        })
    }
    pub fn method8(v0_1: string, v1_1: i64) -> Arc<Async<i64>> {
        let _v2: MutCell<Option<Arc<Async<i64>>>> = MutCell::new(None::<Arc<Async<i64>>>);
        {
            let x: Arc<Async<i64>> = defaultOf();
            _v2.set(Some(x))
        }
        getValue(_v2.get().clone())
    }
    pub fn closure13(unitVar: (), v0_1: string) -> Arc<Async<i64>> {
        let _v1: MutCell<Option<Arc<Async<i64>>>> = MutCell::new(None::<Arc<Async<i64>>>);
        {
            let x: Arc<Async<i64>> = defaultOf();
            _v1.set(Some(x))
        }
        getValue(_v1.get().clone())
    }
    pub fn closure14(unitVar: (), v0_1: string) -> Arc<Async<string>> {
        let _v1: MutCell<Option<Arc<Async<string>>>> = MutCell::new(None::<Arc<Async<string>>>);
        {
            let x: Arc<Async<string>> = defaultOf();
            _v1.set(Some(x))
        }
        getValue(_v1.get().clone())
    }
    pub fn method9(v0_1: string) -> string {
        v0_1
    }
    pub fn closure16(v0_1: string, v1_1: string) -> Arc<Async<bool>> {
        let _v2: MutCell<Option<Arc<Async<bool>>>> = MutCell::new(None::<Arc<Async<bool>>>);
        {
            let x: Arc<Async<bool>> = defaultOf();
            _v2.set(Some(x))
        }
        getValue(_v2.get().clone())
    }
    pub fn closure15(unitVar: (), v0_1: string) -> Func1<string, Arc<Async<bool>>> {
        Func1::new({
            let v0_1 = v0_1.clone();
            move |v: string| File_system::closure16(v0_1.clone(), v)
        })
    }
    pub fn closure18(v0_1: string, v1_1: string) -> Arc<Async<()>> {
        let _v2: MutCell<Option<Arc<Async<()>>>> = MutCell::new(None::<Arc<Async<()>>>);
        {
            let x: Arc<Async<()>> = defaultOf();
            _v2.set(Some(x))
        }
        getValue(_v2.get().clone())
    }
    pub fn closure17(unitVar: (), v0_1: string) -> Func1<string, Arc<Async<()>>> {
        Func1::new({
            let v0_1 = v0_1.clone();
            move |v: string| File_system::closure18(v0_1.clone(), v)
        })
    }
    pub fn closure20(v0_1: string, v1_1: string) -> Arc<Async<()>> {
        let _v2: MutCell<Option<Arc<Async<()>>>> = MutCell::new(None::<Arc<Async<()>>>);
        {
            let x: Arc<Async<()>> = defaultOf();
            _v2.set(Some(x))
        }
        getValue(_v2.get().clone())
    }
    pub fn closure19(unitVar: (), v0_1: string) -> Func1<string, Arc<Async<()>>> {
        Func1::new({
            let v0_1 = v0_1.clone();
            move |v: string| File_system::closure20(v0_1.clone(), v)
        })
    }
    pub fn closure22(unitVar: (), unitVar_1: ()) -> string {
        string("delete_file_async")
    }
    pub fn closure23(v0_1: string, v1_1: LrcPtr<Exception>, unitVar: ()) -> string {
        let _v2: MutCell<Option<string>> = MutCell::new(None::<string>);
        {
            let x: string = sprintf!("{:?}", v1_1);
            _v2.set(Some(x))
        }
        {
            let v10_1: string = getValue(_v2.get().clone());
            sprintf!(
                "path: {} / ex: {} / {}",
                File_system::closure5((), v0_1),
                v10_1,
                File_system::closure6((), ())
            )
        }
    }
    pub fn method10(v0_1: string, v1_1: i64) -> Arc<Async<i64>> {
        let _v2: MutCell<Option<Arc<Async<i64>>>> = MutCell::new(None::<Arc<Async<i64>>>);
        {
            let x: Arc<Async<i64>> = defaultOf();
            _v2.set(Some(x))
        }
        getValue(_v2.get().clone())
    }
    pub fn closure21(unitVar: (), v0_1: string) -> Arc<Async<i64>> {
        let _v1: MutCell<Option<Arc<Async<i64>>>> = MutCell::new(None::<Arc<Async<i64>>>);
        {
            let x: Arc<Async<i64>> = defaultOf();
            _v1.set(Some(x))
        }
        getValue(_v1.get().clone())
    }
    pub fn closure26(unitVar: (), unitVar_1: ()) -> string {
        string("move_file_async")
    }
    pub fn closure27(v0_1: string, v1_1: string, v2_1: LrcPtr<Exception>, unitVar: ()) -> string {
        let _v3: MutCell<Option<string>> = MutCell::new(None::<string>);
        {
            let x: string = sprintf!("{:?}", v2_1);
            _v3.set(Some(x))
        }
        {
            let v11_1: string = getValue(_v3.get().clone());
            let v12_1 = Func1::new(move |v: string| File_system::closure5((), v));
            sprintf!(
                "old_path: {} / new_path: {} / ex: {} / {}",
                v12_1(v1_1),
                v12_1(v0_1),
                v11_1,
                File_system::closure6((), ())
            )
        }
    }
    pub fn method11(v0_1: string, v1_1: string, v2_1: i64) -> Arc<Async<i64>> {
        let _v3: MutCell<Option<Arc<Async<i64>>>> = MutCell::new(None::<Arc<Async<i64>>>);
        {
            let x: Arc<Async<i64>> = defaultOf();
            _v3.set(Some(x))
        }
        getValue(_v3.get().clone())
    }
    pub fn closure25(v0_1: string, v1_1: string) -> Arc<Async<i64>> {
        let _v2: MutCell<Option<Arc<Async<i64>>>> = MutCell::new(None::<Arc<Async<i64>>>);
        {
            let x: Arc<Async<i64>> = defaultOf();
            _v2.set(Some(x))
        }
        getValue(_v2.get().clone())
    }
    pub fn closure24(unitVar: (), v0_1: string) -> Func1<string, Arc<Async<i64>>> {
        Func1::new({
            let v0_1 = v0_1.clone();
            move |v: string| File_system::closure25(v0_1.clone(), v)
        })
    }
    pub fn closure29(unitVar: (), v0_1: i64) -> File_system::US6 {
        File_system::US6::US6_0(v0_1)
    }
    pub fn closure30(unitVar: (), v0_1: LrcPtr<Exception>) -> File_system::US6 {
        File_system::US6::US6_1(v0_1)
    }
    pub fn closure31(unitVar: (), unitVar_1: ()) -> string {
        string("run_with_timeout_async")
    }
    pub fn closure32(unitVar: (), unitVar_1: ()) -> string {
        sprintf!("timeout: {} / {}", 1000_i32, File_system::closure6((), ()))
    }
    pub fn closure33(v0_1: string, unitVar: ()) -> string {
        sprintf!("run_with_timeout_async** / ex: {}", v0_1)
    }
    pub fn closure34(unitVar: (), unitVar_1: ()) -> string {
        string("read_all_text_retry_async")
    }
    pub fn method13(v0_1: i64, v1_1: string) -> string {
        sprintf!(
            "retry: {} / ex: {} / {}",
            v0_1,
            v1_1,
            File_system::closure6((), ())
        )
    }
    pub fn closure35(v0_1: i64, v1_1: string, unitVar: ()) -> string {
        File_system::method13(v0_1, v1_1)
    }
    pub fn method12(v0_1: string, v1_1: i64) -> Arc<Async<Option<string>>> {
        let _v2: MutCell<Option<Arc<Async<Option<string>>>>> =
            MutCell::new(None::<Arc<Async<Option<string>>>>);
        {
            let x: Arc<Async<Option<string>>> = defaultOf();
            _v2.set(Some(x))
        }
        getValue(_v2.get().clone())
    }
    pub fn closure28(unitVar: (), v0_1: string) -> Arc<Async<Option<string>>> {
        let _v1: MutCell<Option<Arc<Async<Option<string>>>>> =
            MutCell::new(None::<Arc<Async<Option<string>>>>);
        {
            let x: Arc<Async<Option<string>>> = defaultOf();
            _v1.set(Some(x))
        }
        getValue(_v1.get().clone())
    }
    pub fn method14(v0_1: string) -> string {
        v0_1
    }
    pub fn method15(v0_1: string) -> string {
        v0_1
    }
    pub fn closure37(unitVar: (), v0_1: Option<()>) -> File_system::US8 {
        File_system::US8::US8_0(v0_1)
    }
    pub fn method16() -> Func1<Option<()>, File_system::US8> {
        Func1::new(move |v: Option<()>| File_system::closure37((), v))
    }
    pub fn method17(v0_1: Option<()>) -> Option<()> {
        v0_1
    }
    pub fn method18(v0_1: Option<()>) -> Option<()> {
        v0_1
    }
    pub fn method19() -> string {
        string("yyyyMMdd-HHmm-ssff-ffff-f")
    }
    pub fn method20() -> string {
        string("hhmm")
    }
    pub fn closure36(unitVar: (), unitVar_1: ()) -> string {
        let _v0: MutCell<Option<string>> = MutCell::new(None::<string>);
        {
            let x: string = unbox::<string>(&defaultOf());
            _v0.set(Some(x))
        }
        getValue(_v0.get().clone())
    }
    pub fn method21(v0_1: string) -> string {
        v0_1
    }
    pub fn closure39(unitVar: (), v0_1: std::io::Error) -> std::string::String {
        let _v1: MutCell<Option<std::string::String>> = MutCell::new(None::<std::string::String>);
        {
            let x: std::string::String = format!("{}", v0_1);
            _v1.set(Some(x))
        }
        getValue(_v1.get().clone())
    }
    pub fn method22() -> Func1<std::io::Error, std::string::String> {
        Func1::new(move |v: std::io::Error| File_system::closure39((), v))
    }
    pub fn closure40(unitVar: (), unitVar_1: ()) -> File_system::US10 {
        File_system::US10::US10_0
    }
    pub fn closure41(unitVar: (), v0_1: std::string::String) -> File_system::US10 {
        File_system::US10::US10_1(v0_1)
    }
    pub fn closure42(unitVar: (), unitVar_1: ()) -> string {
        string("file_system.create_directory")
    }
    pub fn closure43(v0_1: string, v1_1: std::string::String, unitVar: ()) -> string {
        sprintf!(
            "dir: {} / error: {} / {}",
            v0_1,
            v1_1,
            File_system::closure6((), ())
        )
    }
    pub fn closure44(unitVar: (), unitVar_1: ()) -> string {
        string("file_system.create_directory")
    }
    pub fn closure45(v0_1: string, unitVar: ()) -> string {
        sprintf!("dir: {} / {}", v0_1, File_system::closure6((), ()))
    }
    pub fn closure46(v0_1: string, unitVar: ()) {
        let _v1: MutCell<Option<()>> = MutCell::new(None::<()>);
        defaultOf::<()>();
        _v1.set(Some(()));
        getValue(_v1.get().clone());
        ()
    }
    pub fn method23(v0_1: string) -> Func0<()> {
        Func0::new({
            let v0_1 = v0_1.clone();
            move || File_system::closure46(v0_1.clone(), ())
        })
    }
    pub fn closure47(unitVar: (), unitVar_1: ()) -> string {
        string("file_system.create_directory")
    }
    pub fn closure48(v0_1: string, v1_1: string, unitVar: ()) -> string {
        sprintf!(
            "dir: {} / result: {} {}",
            v0_1,
            v1_1,
            File_system::closure6((), ())
        )
    }
    pub fn closure49(v0_1: string, unitVar: ()) {
        let _v1: MutCell<Option<Arc<Async<i64>>>> = MutCell::new(None::<Arc<Async<i64>>>);
        {
            let x: Arc<Async<i64>> = defaultOf();
            _v1.set(Some(x))
        }
        {
            let v10_1: Arc<Async<i64>> = getValue(_v1.get().clone());
            let _v11: MutCell<Option<Arc<Async<()>>>> = MutCell::new(None::<Arc<Async<()>>>);
            {
                let x_1: Arc<Async<()>> = defaultOf();
                _v11.set(Some(x_1))
            }
            {
                let v20: Arc<Async<()>> = getValue(_v11.get().clone());
                let _v21: MutCell<Option<()>> = MutCell::new(None::<()>);
                defaultOf::<()>();
                _v21.set(Some(()));
                getValue(_v21.get().clone());
                ()
            }
        }
    }
    pub fn method24(v0_1: string) -> Func0<()> {
        Func0::new({
            let v0_1 = v0_1.clone();
            move || File_system::closure49(v0_1.clone(), ())
        })
    }
    pub fn closure38(unitVar: (), unitVar_1: ()) -> (string, LrcPtr<dyn IDisposable>) {
        let _v0: MutCell<Option<string>> = MutCell::new(None::<string>);
        {
            let x: string = unbox::<string>(&defaultOf());
            _v0.set(Some(x))
        }
        {
            let v534: string = getValue(_v0.get().clone());
            let _v535: MutCell<Option<LrcPtr<dyn IDisposable>>> =
                MutCell::new(None::<LrcPtr<dyn IDisposable>>);
            {
                let x_1: LrcPtr<dyn IDisposable> = interface_cast!(
                    defaultOf::<std::rc::Rc<dyn IDisposable>>(),
                    Lrc<dyn IDisposable>,
                );
                _v535.set(Some(x_1))
            }
            (v534, getValue(_v535.get().clone()))
        }
    }
    pub fn closure50(unitVar: (), unitVar_1: ()) -> string {
        string("C:\\home\\git\\polyglot\\lib\\spiral")
    }
    pub fn closure54(unitVar: (), v0_1: string) -> bool {
        let _v1: MutCell<Option<bool>> = MutCell::new(None::<bool>);
        {
            let x: bool = unbox::<bool>(&defaultOf());
            _v1.set(Some(x))
        }
        getValue(_v1.get().clone())
    }
    pub fn closure55(unitVar: (), v0_1: string) -> bool {
        let _v1: MutCell<Option<bool>> = MutCell::new(None::<bool>);
        {
            let x: bool = unbox::<bool>(&defaultOf());
            _v1.set(Some(x))
        }
        getValue(_v1.get().clone())
    }
    pub fn closure56(unitVar: (), v0_1: string) -> Option<string> {
        let _v1: MutCell<Option<File_system::US9>> = MutCell::new(None::<File_system::US9>);
        {
            let x: File_system::US9 = unbox::<File_system::US9>(&defaultOf());
            _v1.set(Some(x))
        }
        {
            let v55: File_system::US9 = getValue(_v1.get().clone());
            match &v55 {
                File_system::US9::US9_0(v55_0_0) => Some(match &v55 {
                    File_system::US9::US9_0(x) => x.clone(),
                    _ => unreachable!(),
                }),
                _ => None::<string>,
            }
        }
    }
    pub fn method26() -> Func1<string, Option<string>> {
        Func1::new(move |v: string| File_system::closure56((), v))
    }
    pub fn closure57(unitVar: (), v0_1: string) -> File_system::US9 {
        File_system::US9::US9_0(v0_1)
    }
    pub fn method27() -> Func1<string, File_system::US9> {
        Func1::new(move |v: string| File_system::closure57((), v))
    }
    pub fn method28(v0_1: string, v1_1: bool, v2_1: string, v3_1: string) -> string {
        let v0_1: MutCell<string> = MutCell::new(v0_1.clone());
        let v1_1: MutCell<bool> = MutCell::new(v1_1);
        let v2_1: MutCell<string> = MutCell::new(v2_1.clone());
        let v3_1: MutCell<string> = MutCell::new(v3_1.clone());
        '_method28: loop {
            break '_method28 ({
                let _v4: MutCell<Option<string>> = MutCell::new(None::<string>);
                {
                    let x: string = unbox::<string>(&defaultOf());
                    _v4.set(Some(x))
                }
                if (if v1_1.get().clone() {
                    Func1::new(move |v: string| File_system::closure54((), v))
                } else {
                    Func1::new(move |v_1: string| File_system::closure55((), v_1))
                })(getValue(_v4.get().clone()))
                {
                    v3_1.get().clone()
                } else {
                    let v52: Option<string> = (File_system::method26())(v3_1.get().clone());
                    let v55: File_system::US9 =
                        defaultValue(File_system::US9::US9_1, map(File_system::method27(), v52));
                    match &v55 {
                        File_system::US9::US9_0(v55_0_0) => {
                            let v0_1_temp: string = v0_1.get().clone();
                            let v1_1_temp: bool = v1_1.get().clone();
                            let v2_1_temp: string = v2_1.get().clone();
                            let v3_1_temp: string = match &v55 {
                                File_system::US9::US9_0(x) => x.clone(),
                                _ => unreachable!(),
                            };
                            v0_1.set(v0_1_temp);
                            v1_1.set(v1_1_temp);
                            v2_1.set(v2_1_temp);
                            v3_1.set(v3_1_temp);
                            continue '_method28;
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
    pub fn method25(v0_1: string, v1_1: bool, v2_1: string) -> string {
        let _v3: MutCell<Option<string>> = MutCell::new(None::<string>);
        {
            let x: string = unbox::<string>(&defaultOf());
            _v3.set(Some(x))
        }
        if (if v1_1 {
            Func1::new(move |v: string| File_system::closure54((), v))
        } else {
            Func1::new(move |v_1: string| File_system::closure55((), v_1))
        })(getValue(_v3.get().clone()))
        {
            v2_1.clone()
        } else {
            let v51: Option<string> = (File_system::method26())(v2_1.clone());
            let v54: File_system::US9 =
                defaultValue(File_system::US9::US9_1, map(File_system::method27(), v51));
            match &v54 {
                File_system::US9::US9_0(v54_0_0) => File_system::method28(
                    v0_1.clone(),
                    v1_1,
                    v2_1.clone(),
                    match &v54 {
                        File_system::US9::US9_0(x) => x.clone(),
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
    pub fn closure53(v0_1: string, v1_1: bool, v2_1: string) -> string {
        File_system::method25(v0_1, v1_1, v2_1)
    }
    pub fn closure52(v0_1: string, v1_1: bool) -> Func1<string, string> {
        Func1::new({
            let v0_1 = v0_1.clone();
            let v1_1 = v1_1.clone();
            move |v: string| File_system::closure53(v0_1.clone(), v1_1, v)
        })
    }
    pub fn closure51(unitVar: (), v0_1: string) -> Func1<bool, Func1<string, string>> {
        Func1::new({
            let v0_1 = v0_1.clone();
            move |v: bool| File_system::closure52(v0_1.clone(), v)
        })
    }
    pub fn method29() -> string {
        string("^\\\\\\\\\\?\\\\")
    }
    pub fn method30(v0_1: string) -> string {
        v0_1
    }
    pub fn method31() -> string {
        string("")
    }
    pub fn closure58(unitVar: (), v0_1: string) -> string {
        let _v1: MutCell<Option<bool>> = MutCell::new(None::<bool>);
        {
            let x: bool = unbox::<bool>(&defaultOf());
            _v1.set(Some(x))
        }
        if getValue(_v1.get().clone()) == false {
            v0_1
        } else {
            let _v14: MutCell<Option<string>> = MutCell::new(None::<string>);
            {
                let x_1: string = unbox::<string>(&defaultOf());
                _v14.set(Some(x_1))
            }
            {
                let v32: string = getValue(_v14.get().clone());
                replace(
                    sprintf!(
                        "{}{}",
                        toLowerChar(getCharAt(v32.clone(), 0_i32)),
                        getSlice(v32, Some(1_i32), None::<i32>)
                    ),
                    string("\\"),
                    string("/"),
                )
            }
        }
    }
    pub fn closure59(unitVar: (), v0_1: string) -> string {
        sprintf!("file:///{}", trimStartChars(v0_1, new_array(&['/'])))
    }
    pub fn method32() -> string {
        string("polyglot")
    }
    pub fn method33() -> string {
        string(".paket")
    }
    pub fn method34() -> string {
        string("polyglot")
    }
    pub fn method35() -> string {
        string(".paket")
    }
    pub fn method37(v0_1: string, v1_1: string, v2_1: string) -> string {
        let v0_1: MutCell<string> = MutCell::new(v0_1.clone());
        let v1_1: MutCell<string> = MutCell::new(v1_1.clone());
        let v2_1: MutCell<string> = MutCell::new(v2_1.clone());
        '_method37: loop {
            break '_method37 ({
                let _v3: MutCell<Option<string>> = MutCell::new(None::<string>);
                {
                    let x: string = unbox::<string>(&defaultOf());
                    _v3.set(Some(x))
                }
                {
                    let v45: string = getValue(_v3.get().clone());
                    let _v46: MutCell<Option<bool>> = MutCell::new(None::<bool>);
                    {
                        let x_1: bool = unbox::<bool>(&defaultOf());
                        _v46.set(Some(x_1))
                    }
                    if getValue(_v46.get().clone()) {
                        v2_1.get().clone()
                    } else {
                        let v71: Option<string> = (File_system::method26())(v2_1.get().clone());
                        let v74: File_system::US9 = defaultValue(
                            File_system::US9::US9_1,
                            map(File_system::method27(), v71),
                        );
                        match &v74 {
                            File_system::US9::US9_0(v74_0_0) => {
                                let v0_1_temp: string = v0_1.get().clone();
                                let v1_1_temp: string = v1_1.get().clone();
                                let v2_1_temp: string = match &v74 {
                                    File_system::US9::US9_0(x) => x.clone(),
                                    _ => unreachable!(),
                                };
                                v0_1.set(v0_1_temp);
                                v1_1.set(v1_1_temp);
                                v2_1.set(v2_1_temp);
                                continue '_method37;
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
    pub fn method36(v0_1: string, v1_1: string) -> string {
        let _v2: MutCell<Option<string>> = MutCell::new(None::<string>);
        {
            let x: string = unbox::<string>(&defaultOf());
            _v2.set(Some(x))
        }
        {
            let v44: string = getValue(_v2.get().clone());
            let _v45: MutCell<Option<bool>> = MutCell::new(None::<bool>);
            {
                let x_1: bool = unbox::<bool>(&defaultOf());
                _v45.set(Some(x_1))
            }
            if getValue(_v45.get().clone()) {
                v1_1.clone()
            } else {
                let v70: Option<string> = (File_system::method26())(v1_1.clone());
                let v73: File_system::US9 =
                    defaultValue(File_system::US9::US9_1, map(File_system::method27(), v70));
                match &v73 {
                    File_system::US9::US9_0(v73_0_0) => File_system::method37(
                        v0_1.clone(),
                        v1_1.clone(),
                        match &v73 {
                            File_system::US9::US9_0(x) => x.clone(),
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
    pub fn method38() -> string {
        string("polyglot")
    }
    pub fn closure60(unitVar: (), unitVar_1: ()) -> string {
        let _v1: MutCell<Option<string>> = MutCell::new(None::<string>);
        {
            let x: string = unbox::<string>(&defaultOf());
            _v1.set(Some(x))
        }
        {
            let v46: string = File_system::method36(
                getValue(_v1.get().clone()),
                string("C:\\home\\git\\polyglot\\lib\\spiral"),
            );
            let _v47: MutCell<Option<string>> = MutCell::new(None::<string>);
            {
                let x_1: string = unbox::<string>(&defaultOf());
                _v47.set(Some(x_1))
            }
            getValue(_v47.get().clone())
        }
    }
    pub fn method40() -> string {
        string("target/polyglot/trace")
    }
    pub fn method41() -> string {
        string("target/polyglot/trace")
    }
    pub fn method39(v0_1: string) {
        let _v1: MutCell<Option<()>> = MutCell::new(None::<()>);
        _v1.set(Some(()));
        getValue(_v1.get().clone());
        ()
    }
    pub fn closure62(unitVar: (), v0_1: string) {
        File_system::method39(v0_1);
    }
    pub fn closure61(unitVar: (), v0_1: bool) {
        if File_system::State::trace_state().get().clone().is_none() {
            File_system::State::trace_state().set(Some(File_system::closure0((), ())));
        }
        {
            let patternInput: (
                LrcPtr<File_system::Mut0>,
                LrcPtr<File_system::Mut1>,
                LrcPtr<File_system::Mut2>,
                Option<i64>,
                LrcPtr<File_system::Mut3>,
            ) = getValue(File_system::State::trace_state().get().clone());
            let v9_1 = if v0_1 {
                Func1::new(move |v: string| File_system::closure62((), v))
            } else {
                Func1::new(move |v_1: string| File_system::closure1((), v_1))
            };
            (patternInput.4.clone()).l0.set(v9_1);
            ()
        }
    }
    pub fn closure64(v0_1: string, v1_1: string) -> string {
        let _v2: MutCell<Option<string>> = MutCell::new(None::<string>);
        {
            let x: string = unbox::<string>(&defaultOf());
            _v2.set(Some(x))
        }
        getValue(_v2.get().clone())
    }
    pub fn closure63(unitVar: (), v0_1: string) -> Func1<string, string> {
        Func1::new({
            let v0_1 = v0_1.clone();
            move |v: string| File_system::closure64(v0_1.clone(), v)
        })
    }
    pub fn v0() -> Func0<(
        LrcPtr<File_system::Mut0>,
        LrcPtr<File_system::Mut1>,
        LrcPtr<File_system::Mut2>,
        Option<i64>,
        LrcPtr<File_system::Mut3>,
    )> {
        static v0: OnceInit<
            Func0<(
                LrcPtr<File_system::Mut0>,
                LrcPtr<File_system::Mut1>,
                LrcPtr<File_system::Mut2>,
                Option<i64>,
                LrcPtr<File_system::Mut3>,
            )>,
        > = OnceInit::new();
        v0.get_or_init(|| Func0::new(move || File_system::closure0((), ())))
            .clone()
    }
    on_startup!(
        if File_system::State::trace_state().get().clone().is_none() {
            File_system::State::trace_state().set(Some((File_system::v0())()));
        }
    );
    pub fn v1() -> Func1<string, Arc<Async<i64>>> {
        static v1: OnceInit<Func1<string, Arc<Async<i64>>>> = OnceInit::new();
        v1.get_or_init(|| Func1::new(move |v: string| File_system::closure2((), v)))
            .clone()
    }
    pub fn delete_directory_async(x: string) -> Arc<Async<i64>> {
        (File_system::v1())(x)
    }
    pub fn v2() -> Func1<File_system::US3, Func1<string, Arc<Async<i64>>>> {
        static v2: OnceInit<Func1<File_system::US3, Func1<string, Arc<Async<i64>>>>> =
            OnceInit::new();
        v2.get_or_init(|| Func1::new(move |v: File_system::US3| File_system::closure9((), v)))
            .clone()
    }
    pub fn wait_for_file_access(x: File_system::US3) -> Func1<string, Arc<Async<i64>>> {
        (File_system::v2())(x)
    }
    pub fn v3() -> Func1<string, Arc<Async<i64>>> {
        static v3: OnceInit<Func1<string, Arc<Async<i64>>>> = OnceInit::new();
        v3.get_or_init(|| Func1::new(move |v: string| File_system::closure13((), v)))
            .clone()
    }
    pub fn wait_for_file_access_read(x: string) -> Arc<Async<i64>> {
        (File_system::v3())(x)
    }
    pub fn v4() -> Func1<string, Arc<Async<string>>> {
        static v4: OnceInit<Func1<string, Arc<Async<string>>>> = OnceInit::new();
        v4.get_or_init(|| Func1::new(move |v: string| File_system::closure14((), v)))
            .clone()
    }
    pub fn read_all_text_async(x: string) -> Arc<Async<string>> {
        (File_system::v4())(x)
    }
    pub fn v5() -> Func1<string, Func1<string, Arc<Async<bool>>>> {
        static v5: OnceInit<Func1<string, Func1<string, Arc<Async<bool>>>>> = OnceInit::new();
        v5.get_or_init(|| Func1::new(move |v: string| File_system::closure15((), v)))
            .clone()
    }
    pub fn file_exists_content(x: string) -> Func1<string, Arc<Async<bool>>> {
        (File_system::v5())(x)
    }
    pub fn v6() -> Func1<string, Func1<string, Arc<Async<()>>>> {
        static v6: OnceInit<Func1<string, Func1<string, Arc<Async<()>>>>> = OnceInit::new();
        v6.get_or_init(|| Func1::new(move |v: string| File_system::closure17((), v)))
            .clone()
    }
    pub fn write_all_text_async(x: string) -> Func1<string, Arc<Async<()>>> {
        (File_system::v6())(x)
    }
    pub fn v7() -> Func1<string, Func1<string, Arc<Async<()>>>> {
        static v7: OnceInit<Func1<string, Func1<string, Arc<Async<()>>>>> = OnceInit::new();
        v7.get_or_init(|| Func1::new(move |v: string| File_system::closure19((), v)))
            .clone()
    }
    pub fn write_all_text_exists(x: string) -> Func1<string, Arc<Async<()>>> {
        (File_system::v7())(x)
    }
    pub fn v8() -> Func1<string, Arc<Async<i64>>> {
        static v8: OnceInit<Func1<string, Arc<Async<i64>>>> = OnceInit::new();
        v8.get_or_init(|| Func1::new(move |v: string| File_system::closure21((), v)))
            .clone()
    }
    pub fn delete_file_async(x: string) -> Arc<Async<i64>> {
        (File_system::v8())(x)
    }
    pub fn v9() -> Func1<string, Func1<string, Arc<Async<i64>>>> {
        static v9: OnceInit<Func1<string, Func1<string, Arc<Async<i64>>>>> = OnceInit::new();
        v9.get_or_init(|| Func1::new(move |v: string| File_system::closure24((), v)))
            .clone()
    }
    pub fn move_file_async(x: string) -> Func1<string, Arc<Async<i64>>> {
        (File_system::v9())(x)
    }
    pub fn v10() -> Func1<string, Arc<Async<Option<string>>>> {
        static v10: OnceInit<Func1<string, Arc<Async<Option<string>>>>> = OnceInit::new();
        v10.get_or_init(|| Func1::new(move |v: string| File_system::closure28((), v)))
            .clone()
    }
    pub fn read_all_text_retry_async(x: string) -> Arc<Async<Option<string>>> {
        (File_system::v10())(x)
    }
    pub fn v11() -> Func0<string> {
        static v11: OnceInit<Func0<string>> = OnceInit::new();
        v11.get_or_init(|| Func0::new(move || File_system::closure36((), ())))
            .clone()
    }
    pub fn create_temp_directory_name() -> string {
        (File_system::v11())()
    }
    pub fn v12() -> Func0<(string, LrcPtr<dyn IDisposable>)> {
        static v12: OnceInit<Func0<(string, LrcPtr<dyn IDisposable>)>> = OnceInit::new();
        v12.get_or_init(|| Func0::new(move || File_system::closure38((), ())))
            .clone()
    }
    pub fn create_temp_directory() -> (string, LrcPtr<dyn IDisposable>) {
        (File_system::v12())()
    }
    pub fn v13() -> Func0<string> {
        static v13: OnceInit<Func0<string>> = OnceInit::new();
        v13.get_or_init(|| Func0::new(move || File_system::closure50((), ())))
            .clone()
    }
    pub fn get_source_directory() -> string {
        (File_system::v13())()
    }
    pub fn v14() -> Func1<string, Func1<bool, Func1<string, string>>> {
        static v14: OnceInit<Func1<string, Func1<bool, Func1<string, string>>>> = OnceInit::new();
        v14.get_or_init(|| Func1::new(move |v: string| File_system::closure51((), v)))
            .clone()
    }
    pub fn find_parent(x: string) -> Func1<bool, Func1<string, string>> {
        (File_system::v14())(x)
    }
    pub fn v15() -> Func1<string, string> {
        static v15: OnceInit<Func1<string, string>> = OnceInit::new();
        v15.get_or_init(|| Func1::new(move |v: string| File_system::closure58((), v)))
            .clone()
    }
    pub fn normalize_path(x: string) -> string {
        (File_system::v15())(x)
    }
    pub fn v16() -> Func1<string, string> {
        static v16: OnceInit<Func1<string, string>> = OnceInit::new();
        v16.get_or_init(|| Func1::new(move |v: string| File_system::closure59((), v)))
            .clone()
    }
    pub fn new_file_uri(x: string) -> string {
        (File_system::v16())(x)
    }
    pub fn v17() -> Func0<string> {
        static v17: OnceInit<Func0<string>> = OnceInit::new();
        v17.get_or_init(|| Func0::new(move || File_system::closure60((), ())))
            .clone()
    }
    pub fn get_repository_root() -> string {
        (File_system::v17())()
    }
    pub fn v18() -> Func1<bool, ()> {
        static v18: OnceInit<Func1<bool, ()>> = OnceInit::new();
        v18.get_or_init(|| Func1::new(move |v: bool| File_system::closure61((), v)))
            .clone()
    }
    pub fn init_trace_file(x: bool) {
        (File_system::v18())(x);
    }
    pub fn v19() -> Func1<string, Func1<string, string>> {
        static v19: OnceInit<Func1<string, Func1<string, string>>> = OnceInit::new();
        v19.get_or_init(|| Func1::new(move |v: string| File_system::closure63((), v)))
            .clone()
    }
    pub fn op_LessDivideGreater(x: string) -> Func1<string, string> {
        (File_system::v19())(x)
    }
    on_startup!(());
}
