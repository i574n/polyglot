pub mod File_system {
    use super::*;
    type Async<T> = T;
    use fable_library_rust::DateTime_::DateTime;
    use fable_library_rust::Guid_::new_guid;
    use fable_library_rust::Guid_::parse;
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
    use fable_library_rust::String_::length;
    use fable_library_rust::String_::ofChar;
    use fable_library_rust::String_::padLeft;
    use fable_library_rust::String_::replace;
    use fable_library_rust::String_::sprintf;
    use fable_library_rust::String_::string;
    use fable_library_rust::String_::toLower;
    use fable_library_rust::String_::toString;
    use fable_library_rust::String_::trimEndChars;
    use fable_library_rust::String_::trimStartChars;
    use fable_library_rust::System::Exception;
    use fable_library_rust::TimeSpan_::zero;
    use fable_library_rust::TimeSpan_::TimeSpan;
    type TimeZoneInfo = i64;
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
        US8_0(chrono::DateTime<chrono::Utc>),
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
    pub fn method3(v0_1: string) -> string {
        v0_1
    }
    pub fn method4(v0_1: string) -> string {
        v0_1
    }
    pub fn closure3(unitVar: (), unitVar_1: ()) -> string {
        string("file_system.delete_directory_async")
    }
    pub fn closure5(unitVar: (), v0_1: string) -> string {
        let _v1: MutCell<Option<string>> = MutCell::new(None::<string>);
        let v3_1: string = File_system::method4(v0_1);
        let v5_1: &str = fable_library_rust::String_::LrcStr::as_str(&v3_1);
        let v7_1: std::string::String = String::from(v5_1);
        let v9_1: std::path::PathBuf = std::path::PathBuf::from(v7_1);
        let v11_1: Option<&std::ffi::OsStr> = v9_1.file_name();
        let v13_1: &std::ffi::OsStr = v11_1.unwrap();
        let v15_1: std::ffi::OsString = v13_1.to_os_string();
        let v17_1: Option<&str> = v15_1.to_str();
        let v19_1: &str = v17_1.unwrap();
        let v21: std::string::String = String::from(v19_1);
        {
            let x: string = fable_library_rust::String_::fromString(v21);
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
    pub fn method6() -> Func1<i64, File_system::US2> {
        Func1::new(move |v: i64| File_system::closure8((), v))
    }
    pub fn method7() -> string {
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
            let v13_1: File_system::US2 = defaultValue(
                File_system::US2::US2_1,
                map(File_system::method6(), patternInput.3.clone()),
            );
            let v31: DateTime = match &v13_1 {
                File_system::US2::US2_0(v13_1_0_0) => {
                    let v19_1: TimeSpan = TimeSpan::new_ticks(
                        {
                            let _arg: DateTime = DateTime::now();
                            _arg.ticks()
                        } - match &v13_1 {
                            File_system::US2::US2_0(x) => x.clone(),
                            _ => unreachable!(),
                        },
                    );
                    DateTime::new_ymdhms_milli(
                        1_i32,
                        1_i32,
                        1_i32,
                        v19_1.hours(),
                        v19_1.minutes(),
                        v19_1.seconds(),
                        v19_1.milliseconds(),
                    )
                }
                _ => DateTime::now(),
            };
            {
                let x: string = v31.toString(string("hh:mm:ss"));
                _v9.set(Some(x))
            }
            {
                let v61: string = getValue(_v9.get().clone());
                let v62: i64 = (patternInput.0.clone()).l0.get().clone();
                let v74: string = padLeft(
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
                let v91: &str = match &v0_1 {
                    File_system::US0::US0_1 => inline_colorization::color_bright_blue,
                    File_system::US0::US0_2 => inline_colorization::color_bright_green,
                    File_system::US0::US0_0 => inline_colorization::color_bright_black,
                    File_system::US0::US0_3 => inline_colorization::color_bright_yellow,
                    _ => inline_colorization::color_bright_red,
                };
                let v93: &str = fable_library_rust::String_::LrcStr::as_str(&v74);
                let v95: &str = inline_colorization::color_reset;
                let v97: string = string("format!(\"{v91}{v93}{v95}\")");
                let v98: std::string::String = format!("{v91}{v93}{v95}");
                {
                    let x_1: string = fable_library_rust::String_::fromString(v98);
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
    pub fn method8(v0_1: File_system::US0, v1_1: Func0<string>) {
        fn v2_1() -> (
            LrcPtr<File_system::Mut0>,
            LrcPtr<File_system::Mut1>,
            LrcPtr<File_system::Mut2>,
            Option<i64>,
            LrcPtr<File_system::Mut3>,
        ) {
            File_system::closure0((), ())
        }
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
    pub fn method5(v0_1: File_system::US0, v1_1: Func0<string>, v2_1: Func0<string>) {
        File_system::method8(
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
    pub fn method9(
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
    pub fn method10(v0_1: string, v1_1: i64) -> Arc<Async<i64>> {
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
    pub fn method11(v0_1: string, v1_1: i64) -> Arc<Async<i64>> {
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
            fn v12_1(v: string) -> string {
                File_system::closure5((), v)
            }
            sprintf!(
                "old_path: {} / new_path: {} / ex: {} / {}",
                v12_1(v1_1),
                v12_1(v0_1),
                v11_1,
                File_system::closure6((), ())
            )
        }
    }
    pub fn method12(v0_1: string, v1_1: string, v2_1: i64) -> Arc<Async<i64>> {
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
    pub fn method14(v0_1: i64, v1_1: string) -> string {
        sprintf!(
            "retry: {} / ex: {} / {}",
            v0_1,
            v1_1,
            File_system::closure6((), ())
        )
    }
    pub fn closure35(v0_1: i64, v1_1: string, unitVar: ()) -> string {
        File_system::method14(v0_1, v1_1)
    }
    pub fn method13(v0_1: string, v1_1: i64) -> Arc<Async<Option<string>>> {
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
    pub fn method16(v0_1: string) -> string {
        v0_1
    }
    pub fn method17(v0_1: string) -> string {
        v0_1
    }
    pub fn method15(v0_1: string, v1_1: string) -> string {
        let _v2: MutCell<Option<string>> = MutCell::new(None::<string>);
        let v4_1: string = File_system::method4(v0_1);
        let v6_1: &str = fable_library_rust::String_::LrcStr::as_str(&v4_1);
        let v8_1: std::string::String = String::from(v6_1);
        let v10_1: std::path::PathBuf = std::path::PathBuf::from(v8_1);
        let v11_1: string = File_system::method4(v1_1);
        let v13_1: &str = fable_library_rust::String_::LrcStr::as_str(&v11_1);
        let v15_1: std::string::String = String::from(v13_1);
        let v17_1: std::path::PathBuf = v10_1.join(v15_1);
        let v19_1: std::path::Display = v17_1.display();
        let _v20: MutCell<Option<std::string::String>> = MutCell::new(None::<std::string::String>);
        {
            let x: std::string::String = format!("{}", v19_1);
            _v20.set(Some(x))
        }
        {
            let v31: std::string::String = getValue(_v20.get().clone());
            {
                let x_1: string = fable_library_rust::String_::fromString(v31);
                _v2.set(Some(x_1))
            }
            getValue(_v2.get().clone())
        }
    }
    pub fn closure37(unitVar: (), v0_1: chrono::DateTime<chrono::Utc>) -> File_system::US8 {
        File_system::US8::US8_0(v0_1)
    }
    pub fn method18() -> Func1<chrono::DateTime<chrono::Utc>, File_system::US8> {
        Func1::new(move |v: chrono::DateTime<chrono::Utc>| File_system::closure37((), v))
    }
    pub fn method19(v0_1: chrono::DateTime<chrono::Utc>) -> chrono::DateTime<chrono::Utc> {
        v0_1
    }
    pub fn method20(v0_1: chrono::DateTime<chrono::Local>) -> chrono::DateTime<chrono::Local> {
        v0_1
    }
    pub fn method21() -> string {
        string("yyyyMMdd-HHmm-ssff-ffff-f")
    }
    pub fn method22() -> string {
        string("hhmm")
    }
    pub fn closure36(unitVar: (), unitVar_1: ()) -> string {
        let _v0: MutCell<Option<string>> = MutCell::new(None::<string>);
        let _v2: MutCell<Option<string>> = MutCell::new(None::<string>);
        {
            let x: string = env!("CARGO_PKG_NAME").into();
            _v2.set(Some(x))
        }
        {
            let v11_1: string = getValue(_v2.get().clone());
            let _v12: MutCell<Option<string>> = MutCell::new(None::<string>);
            let v15_1: std::path::PathBuf = std::env::temp_dir();
            let v17_1: std::path::Display = v15_1.display();
            let _v18: MutCell<Option<std::string::String>> =
                MutCell::new(None::<std::string::String>);
            {
                let x_1: std::string::String = format!("{}", v17_1);
                _v18.set(Some(x_1))
            }
            {
                let v29: std::string::String = getValue(_v18.get().clone());
                {
                    let x_2: string = fable_library_rust::String_::fromString(v29);
                    _v12.set(Some(x_2))
                }
                {
                    let v40: string =
                        File_system::method15(getValue(_v12.get().clone()), sprintf!("!{}", v11_1));
                    let v41: DateTime = DateTime::now();
                    let v44: string = toString(new_guid());
                    let _v45: MutCell<Option<(string, string)>> =
                        MutCell::new(None::<(string, string)>);
                    let v49: DateTime = {
                        let _arg_1: DateTime = DateTime::new_ymdhms_kind(
                            1970_i32, 1_i32, 1_i32, 0_i32, 0_i32, 0_i32, 1_i32,
                        );
                        _arg_1.toUniversalTime()
                    };
                    let v59: i64 = ({
                        let _arg_3: DateTime = {
                            let _arg_2: DateTime = DateTime::specifyKind(v41, 2_i32);
                            _arg_2.toUniversalTime()
                        };
                        _arg_3.ticks()
                    } - v49.ticks())
                        / 10_i64;
                    let v61: Option<chrono::DateTime<chrono::Utc>> =
                        chrono::DateTime::from_timestamp_micros(v59);
                    let v64: File_system::US8 =
                        defaultValue(File_system::US8::US8_1, map(File_system::method18(), v61));
                    let v83: File_system::US9 = match &v64 {
                        File_system::US8::US8_0(v64_0_0) => {
                            let v66: chrono::DateTime<chrono::Utc> =
                                File_system::method19(match &v64 {
                                    File_system::US8::US8_0(x) => x.clone(),
                                    _ => unreachable!(),
                                });
                            let v68: chrono::NaiveDateTime = v66.naive_utc();
                            let v70: chrono::DateTime<chrono::Local> =
                                chrono::offset::TimeZone::from_utc_datetime(&chrono::Local, &v68);
                            let v72: string = string("r#\"%Y%m%d-%H%M-%S%f\"#");
                            let v73: &str = r#"%Y%m%d-%H%M-%S%f"#;
                            let v74: chrono::DateTime<chrono::Local> = File_system::method20(v70);
                            let v76: std::string::String = v74.format(v73).to_string();
                            let v78: string = fable_library_rust::String_::fromString(v76);
                            File_system::US9::US9_0(sprintf!(
                                "{}-{}-{}",
                                getSlice(v78.clone(), Some(0_i32), Some(17_i32)),
                                getSlice(v78.clone(), Some(18_i32), Some(21_i32)),
                                getCharAt(v78, 22_i32)
                            ))
                        }
                        _ => File_system::US9::US9_1,
                    };
                    let v87: string = match &v83 {
                        File_system::US9::US9_0(v83_0_0) => match &v83 {
                            File_system::US9::US9_0(x) => x.clone(),
                            _ => unreachable!(),
                        },
                        _ => string(""),
                    };
                    let _v88: MutCell<Option<LrcPtr<TimeZoneInfo>>> =
                        MutCell::new(None::<LrcPtr<TimeZoneInfo>>);
                    {
                        let x_3: LrcPtr<TimeZoneInfo> = 0i64.into();
                        _v88.set(Some(x_3))
                    }
                    {
                        let v97: LrcPtr<TimeZoneInfo> = getValue(_v88.get().clone());
                        let _v98: MutCell<Option<TimeSpan>> = MutCell::new(None::<TimeSpan>);
                        _v98.set(Some(zero));
                        {
                            let v118: TimeSpan = getValue(_v98.get().clone());
                            let v122: u8 = if v118.hours() > 0_i32 { 1_u8 } else { 0_u8 };
                            let v125: string = v118.to_string(string("hh:mm"));
                            {
                                let x_5: (string, string) = (
                                    v87,
                                    sprintf!(
                                        "{}{}{}",
                                        v122,
                                        getSlice(v125.clone(), Some(0_i32), Some(1_i32)),
                                        getSlice(v125, Some(3_i32), Some(4_i32))
                                    ),
                                );
                                _v45.set(Some(x_5))
                            }
                            {
                                let patternInput: (string, string) = getValue(_v45.get().clone());
                                let v179: string = patternInput.1.clone();
                                let v178: string = patternInput.0.clone();
                                {
                                    let x_6: string = File_system::method15(
                                        v40,
                                        toString(parse(sprintf!(
                                            "{}{}{}",
                                            v178.clone(),
                                            v179.clone(),
                                            getSlice(
                                                v44,
                                                Some(length(v178) + length(v179)),
                                                None::<i32>
                                            )
                                        ))),
                                    );
                                    _v0.set(Some(x_6))
                                }
                                getValue(_v0.get().clone())
                            }
                        }
                    }
                }
            }
        }
    }
    pub fn method23(v0_1: string) -> string {
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
    pub fn method24() -> Func1<std::io::Error, std::string::String> {
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
        let v3_1: string = File_system::method3(v0_1);
        let _v4: MutCell<Option<bool>> = MutCell::new(None::<bool>);
        let v6_1: string = File_system::method4(v3_1.clone());
        let v8_1: &str = fable_library_rust::String_::LrcStr::as_str(&v6_1);
        let v10_1: std::string::String = String::from(v8_1);
        let v12_1: std::path::PathBuf = std::path::PathBuf::from(v10_1);
        {
            let x: bool = if v12_1.clone().exists() {
                v12_1.is_dir()
            } else {
                false
            };
            _v4.set(Some(x))
        }
        if getValue(_v4.get().clone()) {
            std::fs::remove_dir_all(&*v3_1).unwrap();
            ()
        }
        _v1.set(Some(()));
        getValue(_v1.get().clone());
        ()
    }
    pub fn method25(v0_1: string) -> Func0<()> {
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
    pub fn method26(v0_1: string) -> Func0<()> {
        Func0::new({
            let v0_1 = v0_1.clone();
            move || File_system::closure49(v0_1.clone(), ())
        })
    }
    pub fn closure38(unitVar: (), unitVar_1: ()) -> (string, LrcPtr<dyn IDisposable>) {
        let _v0: MutCell<Option<string>> = MutCell::new(None::<string>);
        let _v2: MutCell<Option<string>> = MutCell::new(None::<string>);
        {
            let x: string = env!("CARGO_PKG_NAME").into();
            _v2.set(Some(x))
        }
        {
            let v11_1: string = getValue(_v2.get().clone());
            let _v12: MutCell<Option<string>> = MutCell::new(None::<string>);
            let v15_1: std::path::PathBuf = std::env::temp_dir();
            let v17_1: std::path::Display = v15_1.display();
            let _v18: MutCell<Option<std::string::String>> =
                MutCell::new(None::<std::string::String>);
            {
                let x_1: std::string::String = format!("{}", v17_1);
                _v18.set(Some(x_1))
            }
            {
                let v29: std::string::String = getValue(_v18.get().clone());
                {
                    let x_2: string = fable_library_rust::String_::fromString(v29);
                    _v12.set(Some(x_2))
                }
                {
                    let v40: string =
                        File_system::method15(getValue(_v12.get().clone()), sprintf!("!{}", v11_1));
                    let v41: DateTime = DateTime::now();
                    let v44: string = toString(new_guid());
                    let _v45: MutCell<Option<(string, string)>> =
                        MutCell::new(None::<(string, string)>);
                    let v49: DateTime = {
                        let _arg_1: DateTime = DateTime::new_ymdhms_kind(
                            1970_i32, 1_i32, 1_i32, 0_i32, 0_i32, 0_i32, 1_i32,
                        );
                        _arg_1.toUniversalTime()
                    };
                    let v59: i64 = ({
                        let _arg_3: DateTime = {
                            let _arg_2: DateTime = DateTime::specifyKind(v41, 2_i32);
                            _arg_2.toUniversalTime()
                        };
                        _arg_3.ticks()
                    } - v49.ticks())
                        / 10_i64;
                    let v61: Option<chrono::DateTime<chrono::Utc>> =
                        chrono::DateTime::from_timestamp_micros(v59);
                    let v64: File_system::US8 =
                        defaultValue(File_system::US8::US8_1, map(File_system::method18(), v61));
                    let v83: File_system::US9 = match &v64 {
                        File_system::US8::US8_0(v64_0_0) => {
                            let v66: chrono::DateTime<chrono::Utc> =
                                File_system::method19(match &v64 {
                                    File_system::US8::US8_0(x) => x.clone(),
                                    _ => unreachable!(),
                                });
                            let v68: chrono::NaiveDateTime = v66.naive_utc();
                            let v70: chrono::DateTime<chrono::Local> =
                                chrono::offset::TimeZone::from_utc_datetime(&chrono::Local, &v68);
                            let v72: string = string("r#\"%Y%m%d-%H%M-%S%f\"#");
                            let v73: &str = r#"%Y%m%d-%H%M-%S%f"#;
                            let v74: chrono::DateTime<chrono::Local> = File_system::method20(v70);
                            let v76: std::string::String = v74.format(v73).to_string();
                            let v78: string = fable_library_rust::String_::fromString(v76);
                            File_system::US9::US9_0(sprintf!(
                                "{}-{}-{}",
                                getSlice(v78.clone(), Some(0_i32), Some(17_i32)),
                                getSlice(v78.clone(), Some(18_i32), Some(21_i32)),
                                getCharAt(v78, 22_i32)
                            ))
                        }
                        _ => File_system::US9::US9_1,
                    };
                    let v87: string = match &v83 {
                        File_system::US9::US9_0(v83_0_0) => match &v83 {
                            File_system::US9::US9_0(x) => x.clone(),
                            _ => unreachable!(),
                        },
                        _ => string(""),
                    };
                    let _v88: MutCell<Option<LrcPtr<TimeZoneInfo>>> =
                        MutCell::new(None::<LrcPtr<TimeZoneInfo>>);
                    {
                        let x_3: LrcPtr<TimeZoneInfo> = 0i64.into();
                        _v88.set(Some(x_3))
                    }
                    {
                        let v97: LrcPtr<TimeZoneInfo> = getValue(_v88.get().clone());
                        let _v98: MutCell<Option<TimeSpan>> = MutCell::new(None::<TimeSpan>);
                        _v98.set(Some(zero));
                        {
                            let v118: TimeSpan = getValue(_v98.get().clone());
                            let v122: u8 = if v118.hours() > 0_i32 { 1_u8 } else { 0_u8 };
                            let v125: string = v118.to_string(string("hh:mm"));
                            {
                                let x_5: (string, string) = (
                                    v87,
                                    sprintf!(
                                        "{}{}{}",
                                        v122,
                                        getSlice(v125.clone(), Some(0_i32), Some(1_i32)),
                                        getSlice(v125, Some(3_i32), Some(4_i32))
                                    ),
                                );
                                _v45.set(Some(x_5))
                            }
                            {
                                let patternInput: (string, string) = getValue(_v45.get().clone());
                                let v179: string = patternInput.1.clone();
                                let v178: string = patternInput.0.clone();
                                {
                                    let x_6: string = File_system::method15(
                                        v40,
                                        toString(parse(sprintf!(
                                            "{}{}{}",
                                            v178.clone(),
                                            v179.clone(),
                                            getSlice(
                                                v44,
                                                Some(length(v178) + length(v179)),
                                                None::<i32>
                                            )
                                        ))),
                                    );
                                    _v0.set(Some(x_6))
                                }
                                {
                                    let v369: string = getValue(_v0.get().clone());
                                    let _v370: MutCell<Option<LrcPtr<dyn IDisposable>>> =
                                        MutCell::new(None::<LrcPtr<dyn IDisposable>>);
                                    let v372: string = File_system::method23(v369.clone());
                                    let v374: Result<(), std::io::Error> =
                                        std::fs::create_dir_all(&*v372.clone());
                                    let v375 = File_system::method24();
                                    let v377: Result<(), std::string::String> =
                                        v374.map_err(|x| v375(x));
                                    let v380: File_system::US10 = match &v377 {
                                        Err(v377_1_0) => {
                                            File_system::closure41((), v377_1_0.clone())
                                        }
                                        _ => File_system::closure40((), ()),
                                    };
                                    match &v380 {
                                        File_system::US10::US10_0 => File_system::method5(
                                            File_system::US0::US0_0,
                                            Func0::new(move || File_system::closure44((), ())),
                                            Func0::new({
                                                let v372 = v372.clone();
                                                move || File_system::closure45(v372.clone(), ())
                                            }),
                                        ),
                                        File_system::US10::US10_1(v380_1_0) => {
                                            File_system::method5(
                                                File_system::US0::US0_4,
                                                Func0::new(move || File_system::closure42((), ())),
                                                Func0::new({
                                                    let v372 = v372.clone();
                                                    let v380 = v380.clone();
                                                    move || {
                                                        File_system::closure43(
                                                            v372.clone(),
                                                            match &v380 {
                                                                File_system::US10::US10_1(x) => {
                                                                    x.clone()
                                                                }
                                                                _ => unreachable!(),
                                                            },
                                                            (),
                                                        )
                                                    }
                                                }),
                                            )
                                        }
                                    }
                                    {
                                        let _v388: MutCell<Option<LrcPtr<dyn IDisposable>>> =
                                            MutCell::new(None::<LrcPtr<dyn IDisposable>>);
                                        {
                                            let x_8: LrcPtr<dyn IDisposable> = interface_cast!(
                                                File_system::Disposable::_ctor__3A5B6456(
                                                    Func0::new({
                                                        let v372 = v372.clone();
                                                        move || {
                                                            Func0::new({
                                                                let v372 = v372.clone();
                                                                move || {
                                                                    File_system::closure46(
                                                                        v372.clone(),
                                                                        (),
                                                                    )
                                                                }
                                                            })(
                                                            )
                                                        }
                                                    })
                                                ),
                                                Lrc<dyn IDisposable>,
                                            );
                                            _v388.set(Some(x_8))
                                        }
                                        {
                                            let x_9: LrcPtr<dyn IDisposable> =
                                                getValue(_v388.get().clone());
                                            _v370.set(Some(x_9))
                                        }
                                        (v369, getValue(_v370.get().clone()))
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
    pub fn closure50(unitVar: (), unitVar_1: ()) -> string {
        string("C:\\home\\git\\polyglot\\lib\\spiral")
    }
    pub fn closure54(unitVar: (), v0_1: string) -> bool {
        let _v1: MutCell<Option<bool>> = MutCell::new(None::<bool>);
        let v3_1: string = File_system::method4(v0_1);
        let v5_1: &str = fable_library_rust::String_::LrcStr::as_str(&v3_1);
        let v7_1: std::string::String = String::from(v5_1);
        let v9_1: std::path::PathBuf = std::path::PathBuf::from(v7_1);
        {
            let x: bool = if v9_1.clone().exists() {
                v9_1.is_file()
            } else {
                false
            };
            _v1.set(Some(x))
        }
        getValue(_v1.get().clone())
    }
    pub fn closure55(unitVar: (), v0_1: string) -> bool {
        let _v1: MutCell<Option<bool>> = MutCell::new(None::<bool>);
        let v3_1: string = File_system::method4(v0_1);
        let v5_1: &str = fable_library_rust::String_::LrcStr::as_str(&v3_1);
        let v7_1: std::string::String = String::from(v5_1);
        let v9_1: std::path::PathBuf = std::path::PathBuf::from(v7_1);
        {
            let x: bool = if v9_1.clone().exists() {
                v9_1.is_dir()
            } else {
                false
            };
            _v1.set(Some(x))
        }
        getValue(_v1.get().clone())
    }
    pub fn closure56(unitVar: (), v0_1: string) -> Option<string> {
        let _v1: MutCell<Option<File_system::US9>> = MutCell::new(None::<File_system::US9>);
        let v3_1: string = File_system::method4(v0_1);
        let v5_1: &str = fable_library_rust::String_::LrcStr::as_str(&v3_1);
        let v7_1: std::string::String = String::from(v5_1);
        let v9_1: std::path::PathBuf = std::path::PathBuf::from(v7_1);
        let v11_1: Option<std::path::PathBuf> = v9_1.parent().map(std::path::PathBuf::from);
        let v13_1: std::path::PathBuf = v11_1?;
        let v15_1: std::path::Display = v13_1.display();
        let _v16: MutCell<Option<std::string::String>> = MutCell::new(None::<std::string::String>);
        {
            let x: std::string::String = format!("{}", v15_1);
            _v16.set(Some(x))
        }
        {
            let v27: std::string::String = getValue(_v16.get().clone());
            {
                let x_1: File_system::US9 =
                    File_system::US9::US9_0(fable_library_rust::String_::fromString(v27));
                _v1.set(Some(x_1))
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
    }
    pub fn method28() -> Func1<string, Option<string>> {
        Func1::new(move |v: string| File_system::closure56((), v))
    }
    pub fn closure57(unitVar: (), v0_1: string) -> File_system::US9 {
        File_system::US9::US9_0(v0_1)
    }
    pub fn method29() -> Func1<string, File_system::US9> {
        Func1::new(move |v: string| File_system::closure57((), v))
    }
    pub fn method30(v0_1: string, v1_1: bool, v2_1: string, v3_1: string) -> string {
        let v0_1: MutCell<string> = MutCell::new(v0_1.clone());
        let v1_1: MutCell<bool> = MutCell::new(v1_1);
        let v2_1: MutCell<string> = MutCell::new(v2_1.clone());
        let v3_1: MutCell<string> = MutCell::new(v3_1.clone());
        '_method30: loop {
            break '_method30 (if (if v1_1.get().clone() {
                Func1::new(move |v: string| File_system::closure54((), v))
            } else {
                Func1::new(move |v_1: string| File_system::closure55((), v_1))
            })(File_system::method15(
                v3_1.get().clone(),
                v0_1.get().clone(),
            )) {
                v3_1.get().clone()
            } else {
                let v10_1: Option<string> = (File_system::method28())(v3_1.get().clone());
                let v13_1: File_system::US9 =
                    defaultValue(File_system::US9::US9_1, map(File_system::method29(), v10_1));
                match &v13_1 {
                    File_system::US9::US9_0(v13_1_0_0) => {
                        let v0_1_temp: string = v0_1.get().clone();
                        let v1_1_temp: bool = v1_1.get().clone();
                        let v2_1_temp: string = v2_1.get().clone();
                        let v3_1_temp: string = match &v13_1 {
                            File_system::US9::US9_0(x) => x.clone(),
                            _ => unreachable!(),
                        };
                        v0_1.set(v0_1_temp);
                        v1_1.set(v1_1_temp);
                        v2_1.set(v2_1_temp);
                        v3_1.set(v3_1_temp);
                        continue '_method30;
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
            });
        }
    }
    pub fn method27(v0_1: string, v1_1: bool, v2_1: string) -> string {
        if (if v1_1 {
            Func1::new(move |v: string| File_system::closure54((), v))
        } else {
            Func1::new(move |v_1: string| File_system::closure55((), v_1))
        })(File_system::method15(v2_1.clone(), v0_1.clone()))
        {
            v2_1.clone()
        } else {
            let v9_1: Option<string> = (File_system::method28())(v2_1.clone());
            let v12_1: File_system::US9 =
                defaultValue(File_system::US9::US9_1, map(File_system::method29(), v9_1));
            match &v12_1 {
                File_system::US9::US9_0(v12_1_0_0) => File_system::method30(
                    v0_1.clone(),
                    v1_1,
                    v2_1.clone(),
                    match &v12_1 {
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
        File_system::method27(v0_1, v1_1, v2_1)
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
    pub fn method31() -> string {
        string("^\\\\\\\\\\?\\\\")
    }
    pub fn method32(v0_1: string) -> string {
        v0_1
    }
    pub fn method33() -> string {
        string("")
    }
    pub fn closure58(unitVar: (), v0_1: string) -> string {
        let _v1: MutCell<Option<string>> = MutCell::new(None::<string>);
        let v3_1: string = File_system::method31();
        let v4_1: string = File_system::method32(v0_1);
        let v5_1: string = File_system::method33();
        let v7_1: std::borrow::Cow<str> =
            regex::Regex::new(&v3_1).unwrap().replace_all(&v4_1, &*v5_1);
        let v9_1: std::string::String = String::from(v7_1);
        {
            let x: string = fable_library_rust::String_::fromString(v9_1);
            _v1.set(Some(x))
        }
        {
            let v19_1: string = getValue(_v1.get().clone());
            replace(
                sprintf!(
                    "{}{}",
                    toLower(ofChar(getCharAt(v19_1.clone(), 0_i32))),
                    getSlice(v19_1, Some(1_i32), None::<i32>)
                ),
                string("\\"),
                string("/"),
            )
        }
    }
    pub fn closure59(unitVar: (), v0_1: string) -> string {
        sprintf!("file:///{}", trimStartChars(v0_1, new_array(&['/'])))
    }
    pub fn method35(v0_1: string, v1_1: string, v2_1: string) -> string {
        let v0_1: MutCell<string> = MutCell::new(v0_1.clone());
        let v1_1: MutCell<string> = MutCell::new(v1_1.clone());
        let v2_1: MutCell<string> = MutCell::new(v2_1.clone());
        '_method35: loop {
            break '_method35 ({
                let _v4: MutCell<Option<bool>> = MutCell::new(None::<bool>);
                let v6_1: string = File_system::method4(File_system::method15(
                    v2_1.get().clone(),
                    v0_1.get().clone(),
                ));
                let v8_1: &str = fable_library_rust::String_::LrcStr::as_str(&v6_1);
                let v10_1: std::string::String = String::from(v8_1);
                let v12_1: std::path::PathBuf = std::path::PathBuf::from(v10_1);
                {
                    let x: bool = if v12_1.clone().exists() {
                        v12_1.is_dir()
                    } else {
                        false
                    };
                    _v4.set(Some(x))
                }
                if getValue(_v4.get().clone()) {
                    v2_1.get().clone()
                } else {
                    let v29: Option<string> = (File_system::method28())(v2_1.get().clone());
                    let v32: File_system::US9 =
                        defaultValue(File_system::US9::US9_1, map(File_system::method29(), v29));
                    match &v32 {
                        File_system::US9::US9_0(v32_0_0) => {
                            let v0_1_temp: string = v0_1.get().clone();
                            let v1_1_temp: string = v1_1.get().clone();
                            let v2_1_temp: string = match &v32 {
                                File_system::US9::US9_0(x) => x.clone(),
                                _ => unreachable!(),
                            };
                            v0_1.set(v0_1_temp);
                            v1_1.set(v1_1_temp);
                            v2_1.set(v2_1_temp);
                            continue '_method35;
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
            });
        }
    }
    pub fn method34(v0_1: string, v1_1: string) -> string {
        let _v3: MutCell<Option<bool>> = MutCell::new(None::<bool>);
        let v5_1: string = File_system::method4(File_system::method15(v1_1.clone(), v0_1.clone()));
        let v7_1: &str = fable_library_rust::String_::LrcStr::as_str(&v5_1);
        let v9_1: std::string::String = String::from(v7_1);
        let v11_1: std::path::PathBuf = std::path::PathBuf::from(v9_1);
        {
            let x: bool = if v11_1.clone().exists() {
                v11_1.is_dir()
            } else {
                false
            };
            _v3.set(Some(x))
        }
        if getValue(_v3.get().clone()) {
            v1_1.clone()
        } else {
            let v28: Option<string> = (File_system::method28())(v1_1.clone());
            let v31: File_system::US9 =
                defaultValue(File_system::US9::US9_1, map(File_system::method29(), v28));
            match &v31 {
                File_system::US9::US9_0(v31_0_0) => File_system::method35(
                    v0_1.clone(),
                    v1_1.clone(),
                    match &v31 {
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
    pub fn closure60(unitVar: (), unitVar_1: ()) -> string {
        File_system::method15(
            File_system::method34(
                File_system::method15(string("polyglot"), string(".paket")),
                string("C:\\home\\git\\polyglot\\lib\\spiral"),
            ),
            string("polyglot"),
        )
    }
    pub fn method36(v0_1: string) {
        let _v1: MutCell<Option<()>> = MutCell::new(None::<()>);
        _v1.set(Some(()));
        getValue(_v1.get().clone());
        ()
    }
    pub fn closure62(unitVar: (), v0_1: string) {
        File_system::method36(v0_1);
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
        File_system::method15(v0_1, v1_1)
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
