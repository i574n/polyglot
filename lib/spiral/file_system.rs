pub mod File_system {
    use super::*;
    type Async<T> = T;
    use fable_library_rust::DateTime_::DateTime;
    use fable_library_rust::Guid_::new_guid;
    use fable_library_rust::Guid_::parse;
    use fable_library_rust::Guid_::Guid;
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
    use fable_library_rust::Native_::refCell;
    use fable_library_rust::Native_::Arc;
    use fable_library_rust::Native_::Func0;
    use fable_library_rust::Native_::Func1;
    use fable_library_rust::Native_::Lrc;
    use fable_library_rust::Native_::LrcPtr;
    use fable_library_rust::Native_::MutCell;
    use fable_library_rust::Native_::OnceInit;
    use fable_library_rust::Option_::defaultValue;
    use fable_library_rust::Option_::getValue;
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
    #[derive(Clone, Debug)]
    pub enum US5 {
        US5_0(i64),
        US5_1(LrcPtr<Exception>),
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
        US7_0(chrono::DateTime<chrono::Utc>),
        US7_1,
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
    #[derive(Clone, Debug)]
    pub enum US9 {
        US9_0,
        US9_1(std::string::String),
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
        v0_1: File_system::US0,
    ) -> (
        LrcPtr<File_system::Mut0>,
        LrcPtr<File_system::Mut1>,
        LrcPtr<File_system::Mut2>,
        Option<i64>,
        LrcPtr<File_system::Mut3>,
    ) {
        let v1_1: LrcPtr<File_system::Mut1> = LrcPtr::new(File_system::Mut1 {
            l0: MutCell::new(true),
        });
        let v2_1: LrcPtr<File_system::Mut0> = LrcPtr::new(File_system::Mut0 {
            l0: MutCell::new(0_i64),
        });
        let v3_1: LrcPtr<File_system::Mut2> = LrcPtr::new(File_system::Mut2 {
            l0: MutCell::new(v0_1),
        });
        let v5_1: LrcPtr<File_system::Mut3> = LrcPtr::new(File_system::Mut3 {
            l0: MutCell::new(Func1::new(move |v: string| File_system::closure1((), v))),
        });
        let _v6: MutCell<Option<Option<i64>>> = MutCell::new(None::<Option<i64>>);
        let _v7: MutCell<Option<string>> = MutCell::new(None::<string>);
        let v10_1: Result<std::string::String, std::env::VarError> =
            std::env::var(&*string("AUTOMATION"));
        let v12_1: bool = true;
        let _result = v10_1.map(|x| {
            //;
            let v14_1: std::string::String = x;
            let v16_1: string = fable_library_rust::String_::fromString(v14_1);
            let v18_1: bool = true;
            v16_1
        });
        let v20_1: Result<string, std::env::VarError> = _result;
        let v21: string = File_system::method0();
        {
            let x: string = v20_1.unwrap_or(v21);
            _v7.set(Some(x))
        }
        {
            let v39: File_system::US1 = if match &_v7.get().clone() {
                None => panic!("{}", string("base.run_target / _v7=None"),),
                Some(_v7_0_0) => _v7_0_0.clone(),
            } == string("True")
            {
                File_system::US1::US1_0({
                    let _arg: DateTime = DateTime::now();
                    _arg.ticks()
                })
            } else {
                File_system::US1::US1_1
            };
            {
                let x_2: Option<i64> = match &v39 {
                    File_system::US1::US1_0(v39_0_0) => Some(match &v39 {
                        File_system::US1::US1_0(x) => x.clone(),
                        _ => unreachable!(),
                    }),
                    _ => None::<i64>,
                };
                _v6.set(Some(x_2))
            }
            (
                v2_1,
                v1_1,
                v3_1,
                match &_v6.get().clone() {
                    None => panic!("{}", string("base.run_target / _v6=None"),),
                    Some(_v6_0_0) => _v6_0_0.clone(),
                },
                v5_1,
            )
        }
    }
    pub fn method3(v0_1: string) -> string {
        v0_1
    }
    pub fn closure3(unitVar: (), unitVar_1: ()) -> string {
        string("file_system.delete_directory_async")
    }
    pub fn closure5(unitVar: (), v0_1: string) -> string {
        let _v1: MutCell<Option<string>> = MutCell::new(None::<string>);
        let v3_1: &str = &*v0_1;
        let v5_1: std::string::String = String::from(v3_1);
        let v7_1: std::path::PathBuf = std::path::PathBuf::from(v5_1);
        let v9_1: Option<&std::ffi::OsStr> = v7_1.file_name();
        let v11_1: &std::ffi::OsStr = v9_1.unwrap();
        let v13_1: std::ffi::OsString = v11_1.to_os_string();
        let v15_1: Option<&str> = v13_1.to_str();
        let v17_1: &str = v15_1.unwrap();
        let v19_1: std::string::String = String::from(v17_1);
        {
            let x: string = fable_library_rust::String_::fromString(v19_1);
            _v1.set(Some(x))
        }
        match &_v1.get().clone() {
            None => panic!("{}", string("base.run_target / _v1=None"),),
            Some(_v1_0_0) => _v1_0_0.clone(),
        }
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
            File_system::State::trace_state()
                .set(Some(File_system::closure0((), File_system::US0::US0_0)));
        }
        {
            let patternInput: (
                LrcPtr<File_system::Mut0>,
                LrcPtr<File_system::Mut1>,
                LrcPtr<File_system::Mut2>,
                Option<i64>,
                LrcPtr<File_system::Mut3>,
            ) = getValue(File_system::State::trace_state().get().clone());
            let v8_1: Option<i64> = patternInput.3.clone();
            let _v10: MutCell<Option<string>> = MutCell::new(None::<string>);
            let _v11: LrcPtr<MutCell<Option<File_system::US1>>> = refCell(None::<File_system::US1>);
            {
                let x_2: Option<File_system::US1> = match &v8_1 {
                    None => None::<File_system::US1>,
                    Some(v8_1_0_0) => {
                        let x: i64 = v8_1_0_0.clone();
                        Some((Func0::new({
                            let x = x.clone();
                            move || File_system::US1::US1_0(x)
                        }))())
                    }
                };
                _v11.set(x_2)
            }
            {
                let v16_1: File_system::US1 =
                    defaultValue(File_system::US1::US1_1, _v11.get().clone());
                let v34: DateTime = match &v16_1 {
                    File_system::US1::US1_0(v16_1_0_0) => {
                        let v22: TimeSpan = TimeSpan::new_ticks(
                            {
                                let _arg: DateTime = DateTime::now();
                                _arg.ticks()
                            } - match &v16_1 {
                                File_system::US1::US1_0(x) => x.clone(),
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
                    let v67: string = match &_v10.get().clone() {
                        None => panic!("{}", string("base.run_target / _v10=None"),),
                        Some(_v10_0_0) => _v10_0_0.clone(),
                    };
                    let v68: i64 = (patternInput.0.clone()).l0.get().clone();
                    let v81: string = padLeft(
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
                    let _v82: MutCell<Option<string>> = MutCell::new(None::<string>);
                    let v97: &str = match &v0_1 {
                        File_system::US0::US0_1 => inline_colorization::color_bright_blue,
                        File_system::US0::US0_2 => inline_colorization::color_bright_green,
                        File_system::US0::US0_0 => inline_colorization::color_bright_black,
                        File_system::US0::US0_3 => inline_colorization::color_yellow,
                        _ => inline_colorization::color_bright_red,
                    };
                    let v99: &str = &*v81;
                    let v101: &str = inline_colorization::color_reset;
                    let v103: string = string("format!(\"{v97}{v99}{v101}\")");
                    let v104: std::string::String = format!("{v97}{v99}{v101}");
                    {
                        let x_5: string = fable_library_rust::String_::fromString(v104);
                        _v82.set(Some(x_5))
                    }
                    trimEndChars(
                        trimStartChars(
                            sprintf!(
                                "{} {} #{} {} / {}",
                                v67,
                                match &_v82.get().clone() {
                                    None => panic!("{}", string("base.run_target / _v82=None"),),
                                    Some(_v82_0_0) => _v82_0_0.clone(),
                                },
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
    pub fn method6(v0_1: File_system::US0, v1_1: Func0<string>) {
        fn v2_1(
            v: File_system::US0,
        ) -> (
            LrcPtr<File_system::Mut0>,
            LrcPtr<File_system::Mut1>,
            LrcPtr<File_system::Mut2>,
            Option<i64>,
            LrcPtr<File_system::Mut3>,
        ) {
            File_system::closure0((), v)
        }
        if File_system::State::trace_state().get().clone().is_none() {
            File_system::State::trace_state().set(Some(v2_1(File_system::US0::US0_0)));
        }
        {
            let patternInput: (
                LrcPtr<File_system::Mut0>,
                LrcPtr<File_system::Mut1>,
                LrcPtr<File_system::Mut2>,
                Option<i64>,
                LrcPtr<File_system::Mut3>,
            ) = getValue(File_system::State::trace_state().get().clone());
            let v4_1: LrcPtr<File_system::Mut0> = patternInput.0.clone();
            if File_system::State::trace_state().get().clone().is_none() {
                File_system::State::trace_state().set(Some(v2_1(File_system::US0::US0_0)));
            }
            {
                let patternInput_1: (
                    LrcPtr<File_system::Mut0>,
                    LrcPtr<File_system::Mut1>,
                    LrcPtr<File_system::Mut2>,
                    Option<i64>,
                    LrcPtr<File_system::Mut3>,
                ) = getValue(File_system::State::trace_state().get().clone());
                let v15_1: File_system::US0 = (patternInput_1.2.clone()).l0.get().clone();
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
                        v15_1,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((File_system::US0::US0_0, 0_i32)),
                            LrcPtr::new((File_system::US0::US0_1, 1_i32)),
                            LrcPtr::new((File_system::US0::US0_2, 2_i32)),
                            LrcPtr::new((File_system::US0::US0_3, 3_i32)),
                            LrcPtr::new((File_system::US0::US0_4, 4_i32)),
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
    pub fn method4(v0_1: File_system::US0, v1_1: Func0<string>, v2_1: Func0<string>) {
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
        match &_v2.get().clone() {
            None => panic!("{}", string("base.run_target / _v2=None"),),
            Some(_v2_0_0) => _v2_0_0.clone(),
        }
    }
    pub fn closure2(unitVar: (), v0_1: string) -> Arc<Async<i64>> {
        let _v1: MutCell<Option<Arc<Async<i64>>>> = MutCell::new(None::<Arc<Async<i64>>>);
        {
            let x: Arc<Async<i64>> = defaultOf();
            _v1.set(Some(x))
        }
        match &_v1.get().clone() {
            None => panic!("{}", string("base.run_target / _v1=None"),),
            Some(_v1_0_0) => _v1_0_0.clone(),
        }
    }
    pub fn closure10(unitVar: (), unitVar_1: ()) -> string {
        string("file_system.wait_for_file_access")
    }
    pub fn closure11(v0_1: string, v1_1: i64, v2_1: string, unitVar: ()) -> string {
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
        v1_1: File_system::US4,
        v2_1: File_system::US3,
        v3_1: i64,
    ) -> Arc<Async<i64>> {
        let _v4: MutCell<Option<Arc<Async<i64>>>> = MutCell::new(None::<Arc<Async<i64>>>);
        {
            let x: Arc<Async<i64>> = defaultOf();
            _v4.set(Some(x))
        }
        match &_v4.get().clone() {
            None => panic!("{}", string("base.run_target / _v4=None"),),
            Some(_v4_0_0) => _v4_0_0.clone(),
        }
    }
    pub fn closure9(v0_1: File_system::US2, v1_1: string) -> Arc<Async<i64>> {
        let _v2: MutCell<Option<Arc<Async<i64>>>> = MutCell::new(None::<Arc<Async<i64>>>);
        {
            let x: Arc<Async<i64>> = defaultOf();
            _v2.set(Some(x))
        }
        match &_v2.get().clone() {
            None => panic!("{}", string("base.run_target / _v2=None"),),
            Some(_v2_0_0) => _v2_0_0.clone(),
        }
    }
    pub fn closure8(unitVar: (), v0_1: File_system::US2) -> Func1<string, Arc<Async<i64>>> {
        Func1::new({
            let v0_1 = v0_1.clone();
            move |v: string| File_system::closure9(v0_1.clone(), v)
        })
    }
    pub fn method8(v0_1: string, v1_1: i64) -> Arc<Async<i64>> {
        let _v2: MutCell<Option<Arc<Async<i64>>>> = MutCell::new(None::<Arc<Async<i64>>>);
        {
            let x: Arc<Async<i64>> = defaultOf();
            _v2.set(Some(x))
        }
        match &_v2.get().clone() {
            None => panic!("{}", string("base.run_target / _v2=None"),),
            Some(_v2_0_0) => _v2_0_0.clone(),
        }
    }
    pub fn closure12(unitVar: (), v0_1: string) -> Arc<Async<i64>> {
        let _v1: MutCell<Option<Arc<Async<i64>>>> = MutCell::new(None::<Arc<Async<i64>>>);
        {
            let x: Arc<Async<i64>> = defaultOf();
            _v1.set(Some(x))
        }
        match &_v1.get().clone() {
            None => panic!("{}", string("base.run_target / _v1=None"),),
            Some(_v1_0_0) => _v1_0_0.clone(),
        }
    }
    pub fn closure13(unitVar: (), v0_1: string) -> Arc<Async<string>> {
        let _v1: MutCell<Option<Arc<Async<string>>>> = MutCell::new(None::<Arc<Async<string>>>);
        {
            let x: Arc<Async<string>> = defaultOf();
            _v1.set(Some(x))
        }
        match &_v1.get().clone() {
            None => panic!("{}", string("base.run_target / _v1=None"),),
            Some(_v1_0_0) => _v1_0_0.clone(),
        }
    }
    pub fn closure15(v0_1: string, v1_1: string) -> Arc<Async<bool>> {
        let _v2: MutCell<Option<Arc<Async<bool>>>> = MutCell::new(None::<Arc<Async<bool>>>);
        {
            let x: Arc<Async<bool>> = defaultOf();
            _v2.set(Some(x))
        }
        match &_v2.get().clone() {
            None => panic!("{}", string("base.run_target / _v2=None"),),
            Some(_v2_0_0) => _v2_0_0.clone(),
        }
    }
    pub fn closure14(unitVar: (), v0_1: string) -> Func1<string, Arc<Async<bool>>> {
        Func1::new({
            let v0_1 = v0_1.clone();
            move |v: string| File_system::closure15(v0_1.clone(), v)
        })
    }
    pub fn closure17(v0_1: string, v1_1: string) -> Arc<Async<()>> {
        let _v2: MutCell<Option<Arc<Async<()>>>> = MutCell::new(None::<Arc<Async<()>>>);
        {
            let x: Arc<Async<()>> = defaultOf();
            _v2.set(Some(x))
        }
        match &_v2.get().clone() {
            None => panic!("{}", string("base.run_target / _v2=None"),),
            Some(_v2_0_0) => _v2_0_0.clone(),
        }
    }
    pub fn closure16(unitVar: (), v0_1: string) -> Func1<string, Arc<Async<()>>> {
        Func1::new({
            let v0_1 = v0_1.clone();
            move |v: string| File_system::closure17(v0_1.clone(), v)
        })
    }
    pub fn closure19(v0_1: string, v1_1: string) -> Arc<Async<()>> {
        let _v2: MutCell<Option<Arc<Async<()>>>> = MutCell::new(None::<Arc<Async<()>>>);
        {
            let x: Arc<Async<()>> = defaultOf();
            _v2.set(Some(x))
        }
        match &_v2.get().clone() {
            None => panic!("{}", string("base.run_target / _v2=None"),),
            Some(_v2_0_0) => _v2_0_0.clone(),
        }
    }
    pub fn closure18(unitVar: (), v0_1: string) -> Func1<string, Arc<Async<()>>> {
        Func1::new({
            let v0_1 = v0_1.clone();
            move |v: string| File_system::closure19(v0_1.clone(), v)
        })
    }
    pub fn closure21(unitVar: (), unitVar_1: ()) -> string {
        string("delete_file_async")
    }
    pub fn closure22(v0_1: string, v1_1: LrcPtr<Exception>, unitVar: ()) -> string {
        let _v2: MutCell<Option<string>> = MutCell::new(None::<string>);
        {
            let x: string = sprintf!("{:?}", v1_1);
            _v2.set(Some(x))
        }
        {
            let v9_1: string = match &_v2.get().clone() {
                None => panic!("{}", string("base.run_target / _v2=None"),),
                Some(_v2_0_0) => _v2_0_0.clone(),
            };
            sprintf!(
                "path: {} / ex: {} / {}",
                File_system::closure5((), v0_1),
                v9_1,
                File_system::closure6((), ())
            )
        }
    }
    pub fn method9(v0_1: string, v1_1: i64) -> Arc<Async<i64>> {
        let _v2: MutCell<Option<Arc<Async<i64>>>> = MutCell::new(None::<Arc<Async<i64>>>);
        {
            let x: Arc<Async<i64>> = defaultOf();
            _v2.set(Some(x))
        }
        match &_v2.get().clone() {
            None => panic!("{}", string("base.run_target / _v2=None"),),
            Some(_v2_0_0) => _v2_0_0.clone(),
        }
    }
    pub fn closure20(unitVar: (), v0_1: string) -> Arc<Async<i64>> {
        let _v1: MutCell<Option<Arc<Async<i64>>>> = MutCell::new(None::<Arc<Async<i64>>>);
        {
            let x: Arc<Async<i64>> = defaultOf();
            _v1.set(Some(x))
        }
        match &_v1.get().clone() {
            None => panic!("{}", string("base.run_target / _v1=None"),),
            Some(_v1_0_0) => _v1_0_0.clone(),
        }
    }
    pub fn closure25(unitVar: (), unitVar_1: ()) -> string {
        string("move_file_async")
    }
    pub fn closure26(v0_1: string, v1_1: string, v2_1: LrcPtr<Exception>, unitVar: ()) -> string {
        let _v3: MutCell<Option<string>> = MutCell::new(None::<string>);
        {
            let x: string = sprintf!("{:?}", v2_1);
            _v3.set(Some(x))
        }
        {
            let v10_1: string = match &_v3.get().clone() {
                None => panic!("{}", string("base.run_target / _v3=None"),),
                Some(_v3_0_0) => _v3_0_0.clone(),
            };
            fn v11_1(v: string) -> string {
                File_system::closure5((), v)
            }
            sprintf!(
                "old_path: {} / new_path: {} / ex: {} / {}",
                v11_1(v1_1),
                v11_1(v0_1),
                v10_1,
                File_system::closure6((), ())
            )
        }
    }
    pub fn method10(v0_1: string, v1_1: string, v2_1: i64) -> Arc<Async<i64>> {
        let _v3: MutCell<Option<Arc<Async<i64>>>> = MutCell::new(None::<Arc<Async<i64>>>);
        {
            let x: Arc<Async<i64>> = defaultOf();
            _v3.set(Some(x))
        }
        match &_v3.get().clone() {
            None => panic!("{}", string("base.run_target / _v3=None"),),
            Some(_v3_0_0) => _v3_0_0.clone(),
        }
    }
    pub fn closure24(v0_1: string, v1_1: string) -> Arc<Async<i64>> {
        let _v2: MutCell<Option<Arc<Async<i64>>>> = MutCell::new(None::<Arc<Async<i64>>>);
        {
            let x: Arc<Async<i64>> = defaultOf();
            _v2.set(Some(x))
        }
        match &_v2.get().clone() {
            None => panic!("{}", string("base.run_target / _v2=None"),),
            Some(_v2_0_0) => _v2_0_0.clone(),
        }
    }
    pub fn closure23(unitVar: (), v0_1: string) -> Func1<string, Arc<Async<i64>>> {
        Func1::new({
            let v0_1 = v0_1.clone();
            move |v: string| File_system::closure24(v0_1.clone(), v)
        })
    }
    pub fn closure28(unitVar: (), v0_1: i64) -> File_system::US5 {
        File_system::US5::US5_0(v0_1)
    }
    pub fn closure29(unitVar: (), v0_1: LrcPtr<Exception>) -> File_system::US5 {
        File_system::US5::US5_1(v0_1)
    }
    pub fn closure30(unitVar: (), unitVar_1: ()) -> string {
        string("run_with_timeout_async")
    }
    pub fn closure31(unitVar: (), unitVar_1: ()) -> string {
        sprintf!("timeout: {} / {}", 1000_i32, File_system::closure6((), ()))
    }
    pub fn closure32(v0_1: string, unitVar: ()) -> string {
        sprintf!("run_with_timeout_async** / ex: {}", v0_1)
    }
    pub fn closure33(unitVar: (), unitVar_1: ()) -> string {
        string("read_all_text_retry_async")
    }
    pub fn method12(v0_1: i64, v1_1: string) -> string {
        sprintf!(
            "retry: {} / ex: {} / {}",
            v0_1,
            v1_1,
            File_system::closure6((), ())
        )
    }
    pub fn closure34(v0_1: i64, v1_1: string, unitVar: ()) -> string {
        File_system::method12(v0_1, v1_1)
    }
    pub fn method11(v0_1: string, v1_1: i64) -> Arc<Async<Option<string>>> {
        let _v2: MutCell<Option<Arc<Async<Option<string>>>>> =
            MutCell::new(None::<Arc<Async<Option<string>>>>);
        {
            let x: Arc<Async<Option<string>>> = defaultOf();
            _v2.set(Some(x))
        }
        match &_v2.get().clone() {
            None => panic!("{}", string("base.run_target / _v2=None"),),
            Some(_v2_0_0) => _v2_0_0.clone(),
        }
    }
    pub fn closure27(unitVar: (), v0_1: string) -> Arc<Async<Option<string>>> {
        let _v1: MutCell<Option<Arc<Async<Option<string>>>>> =
            MutCell::new(None::<Arc<Async<Option<string>>>>);
        {
            let x: Arc<Async<Option<string>>> = defaultOf();
            _v1.set(Some(x))
        }
        match &_v1.get().clone() {
            None => panic!("{}", string("base.run_target / _v1=None"),),
            Some(_v1_0_0) => _v1_0_0.clone(),
        }
    }
    pub fn method13() -> string {
        string("CARGO_PKG_NAME")
    }
    pub fn method15(v0_1: string) -> string {
        v0_1
    }
    pub fn method16(v0_1: string) -> string {
        v0_1
    }
    pub fn method14(v0_1: string, v1_1: string) -> string {
        let _v2: MutCell<Option<string>> = MutCell::new(None::<string>);
        let v4_1: &str = &*v0_1;
        let v6_1: std::string::String = String::from(v4_1);
        let v8_1: std::path::PathBuf = std::path::PathBuf::from(v6_1);
        let v10_1: &str = &*v1_1;
        let v12_1: std::string::String = String::from(v10_1);
        let v14_1: std::path::PathBuf = v8_1.join(v12_1);
        let v16_1: std::path::Display = v14_1.display();
        let _v17: MutCell<Option<std::string::String>> = MutCell::new(None::<std::string::String>);
        {
            let x: std::string::String = format!("{}", v16_1);
            _v17.set(Some(x))
        }
        {
            let v27: std::string::String = match &_v17.get().clone() {
                None => panic!("{}", string("base.run_target / _v17=None"),),
                Some(_v17_0_0) => _v17_0_0.clone(),
            };
            {
                let x_2: string = fable_library_rust::String_::fromString(v27);
                _v2.set(Some(x_2))
            }
            match &_v2.get().clone() {
                None => panic!("{}", string("base.run_target / _v2=None"),),
                Some(_v2_0_0) => _v2_0_0.clone(),
            }
        }
    }
    pub fn method18(v0_1: chrono::DateTime<chrono::Utc>) -> chrono::DateTime<chrono::Utc> {
        v0_1
    }
    pub fn method19(v0_1: chrono::DateTime<chrono::Local>) -> chrono::DateTime<chrono::Local> {
        v0_1
    }
    pub fn method20() -> string {
        string("yyyyMMdd-HHmm-ssff-ffff-f")
    }
    pub fn method21() -> string {
        string("hhmm")
    }
    pub fn method17(v0_1: Guid, v1_1: DateTime) -> Guid {
        let _v2: MutCell<Option<Guid>> = MutCell::new(None::<Guid>);
        let v5_1: DateTime = {
            let _arg: DateTime =
                DateTime::new_ymdhms_kind(1970_i32, 1_i32, 1_i32, 0_i32, 0_i32, 0_i32, 1_i32);
            _arg.toUniversalTime()
        };
        let v15_1: i64 = ({
            let _arg_2: DateTime = {
                let _arg_1: DateTime = DateTime::specifyKind(v1_1, 2_i32);
                _arg_1.toUniversalTime()
            };
            _arg_2.ticks()
        } - v5_1.ticks())
            / 10_i64;
        let v17_1: Option<chrono::DateTime<chrono::Utc>> =
            chrono::DateTime::from_timestamp_micros(v15_1);
        let _v18: LrcPtr<MutCell<Option<File_system::US7>>> = refCell(None::<File_system::US7>);
        {
            let x_2: Option<File_system::US7> = match &v17_1 {
                None => None::<File_system::US7>,
                Some(v17_1_0_0) => {
                    let x: chrono::DateTime<chrono::Utc> = v17_1_0_0.clone();
                    Some((Func0::new({
                        let x = x.clone();
                        move || File_system::US7::US7_0(x.clone())
                    }))())
                }
            };
            _v18.set(x_2)
        }
        {
            let v23: File_system::US7 = defaultValue(File_system::US7::US7_1, _v18.get().clone());
            let v42: File_system::US8 = match &v23 {
                File_system::US7::US7_0(v23_0_0) => {
                    let v25: chrono::DateTime<chrono::Utc> = File_system::method18(match &v23 {
                        File_system::US7::US7_0(x) => x.clone(),
                        _ => unreachable!(),
                    });
                    let v27: chrono::NaiveDateTime = v25.naive_utc();
                    let v29: chrono::DateTime<chrono::Local> =
                        chrono::offset::TimeZone::from_utc_datetime(&chrono::Local, &v27);
                    let v31: string = string("r#\"%Y%m%d-%H%M-%S%f\"#");
                    let v32: &str = r#"%Y%m%d-%H%M-%S%f"#;
                    let v33: chrono::DateTime<chrono::Local> = File_system::method19(v29);
                    let v35: std::string::String = v33.format(v32).to_string();
                    let v37: string = fable_library_rust::String_::fromString(v35);
                    File_system::US8::US8_0(sprintf!(
                        "{}-{}-{}",
                        getSlice(v37.clone(), Some(0_i32), Some(17_i32)),
                        getSlice(v37.clone(), Some(18_i32), Some(21_i32)),
                        getCharAt(v37, 22_i32)
                    ))
                }
                _ => File_system::US8::US8_1,
            };
            let v46: string = match &v42 {
                File_system::US8::US8_0(v42_0_0) => match &v42 {
                    File_system::US8::US8_0(x) => x.clone(),
                    _ => unreachable!(),
                },
                _ => string(""),
            };
            let _v47: MutCell<Option<LrcPtr<TimeZoneInfo>>> =
                MutCell::new(None::<LrcPtr<TimeZoneInfo>>);
            {
                let x_3: LrcPtr<TimeZoneInfo> = 0i64.into();
                _v47.set(Some(x_3))
            }
            {
                let v55: LrcPtr<TimeZoneInfo> = match &_v47.get().clone() {
                    None => panic!("{}", string("base.run_target / _v47=None"),),
                    Some(_v47_0_0) => _v47_0_0.clone(),
                };
                let _v56: MutCell<Option<TimeSpan>> = MutCell::new(None::<TimeSpan>);
                _v56.set(Some(zero));
                {
                    let v74: TimeSpan = match &_v56.get().clone() {
                        None => panic!("{}", string("base.run_target / _v56=None"),),
                        Some(_v56_0_0) => _v56_0_0.clone(),
                    };
                    let v78: u8 = if v74.hours() > 0_i32 { 1_u8 } else { 0_u8 };
                    let v81: string = v74.to_string(string("hh:mm"));
                    let v82: string = sprintf!(
                        "{}{}{}",
                        v78,
                        getSlice(v81.clone(), Some(0_i32), Some(1_i32)),
                        getSlice(v81, Some(3_i32), Some(4_i32))
                    );
                    {
                        let x_7: Guid = parse(sprintf!(
                            "{}{}{}",
                            v46.clone(),
                            v82.clone(),
                            getSlice(toString(v0_1), Some(length(v46) + length(v82)), None::<i32>)
                        ));
                        _v2.set(Some(x_7))
                    }
                    match &_v2.get().clone() {
                        None => panic!("{}", string("base.run_target / _v2=None"),),
                        Some(_v2_0_0) => _v2_0_0.clone(),
                    }
                }
            }
        }
    }
    pub fn closure35(unitVar: (), unitVar_1: ()) -> string {
        let _v0: MutCell<Option<string>> = MutCell::new(None::<string>);
        let _v1: MutCell<Option<string>> = MutCell::new(None::<string>);
        let _v2: MutCell<Option<string>> = MutCell::new(None::<string>);
        let v5_1: Result<std::string::String, std::env::VarError> =
            std::env::var(&*string("CARGO_PKG_NAME"));
        let v7_1: bool = true;
        let _result = v5_1.map(|x| {
            //;
            let v9_1: std::string::String = x;
            let v11_1: string = fable_library_rust::String_::fromString(v9_1);
            let v13_1: bool = true;
            v11_1
        });
        let v15_1: Result<string, std::env::VarError> = _result;
        let v16_1: string = File_system::method0();
        {
            let x: string = v15_1.unwrap_or(v16_1);
            _v2.set(Some(x))
        }
        {
            let x_2: string = match &_v2.get().clone() {
                None => panic!("{}", string("base.run_target / _v2=None"),),
                Some(_v2_0_0) => _v2_0_0.clone(),
            };
            _v1.set(Some(x_2))
        }
        {
            let v32: string = match &_v1.get().clone() {
                None => panic!("{}", string("base.run_target / _v1=None"),),
                Some(_v1_0_0) => _v1_0_0.clone(),
            };
            let _v33: MutCell<Option<string>> = MutCell::new(None::<string>);
            let v35: std::path::PathBuf = std::env::temp_dir();
            let v37: std::path::Display = v35.display();
            let _v38: MutCell<Option<std::string::String>> =
                MutCell::new(None::<std::string::String>);
            {
                let x_4: std::string::String = format!("{}", v37);
                _v38.set(Some(x_4))
            }
            {
                let v48: std::string::String = match &_v38.get().clone() {
                    None => panic!("{}", string("base.run_target / _v38=None"),),
                    Some(_v38_0_0) => _v38_0_0.clone(),
                };
                {
                    let x_6: string = fable_library_rust::String_::fromString(v48);
                    _v33.set(Some(x_6))
                }
                {
                    let v59: string = File_system::method14(
                        match &_v33.get().clone() {
                            None => panic!("{}", string("base.run_target / _v33=None"),),
                            Some(_v33_0_0) => _v33_0_0.clone(),
                        },
                        sprintf!("!{}", v32),
                    );
                    let v60: DateTime = DateTime::now();
                    {
                        let x_8: string = File_system::method14(
                            v59,
                            toString(File_system::method17(new_guid(), v60)),
                        );
                        _v0.set(Some(x_8))
                    }
                    match &_v0.get().clone() {
                        None => panic!("{}", string("base.run_target / _v0=None"),),
                        Some(_v0_0_0) => _v0_0_0.clone(),
                    }
                }
            }
        }
    }
    pub fn method22(v0_1: string) -> string {
        v0_1
    }
    pub fn closure37(unitVar: (), v0_1: std::io::Error) -> std::string::String {
        let _v1: MutCell<Option<std::string::String>> = MutCell::new(None::<std::string::String>);
        {
            let x: std::string::String = format!("{}", v0_1);
            _v1.set(Some(x))
        }
        match &_v1.get().clone() {
            None => panic!("{}", string("base.run_target / _v1=None"),),
            Some(_v1_0_0) => _v1_0_0.clone(),
        }
    }
    pub fn method23() -> Func1<std::io::Error, std::string::String> {
        Func1::new(move |v: std::io::Error| File_system::closure37((), v))
    }
    pub fn closure38(unitVar: (), unitVar_1: ()) -> File_system::US9 {
        File_system::US9::US9_0
    }
    pub fn closure39(unitVar: (), v0_1: std::string::String) -> File_system::US9 {
        File_system::US9::US9_1(v0_1)
    }
    pub fn closure40(unitVar: (), unitVar_1: ()) -> string {
        string("file_system.create_directory")
    }
    pub fn closure41(v0_1: string, v1_1: std::string::String, unitVar: ()) -> string {
        sprintf!(
            "dir: {} / error: {} / {}",
            v0_1,
            v1_1,
            File_system::closure6((), ())
        )
    }
    pub fn closure42(unitVar: (), unitVar_1: ()) -> string {
        string("file_system.create_directory")
    }
    pub fn closure43(v0_1: string, unitVar: ()) -> string {
        sprintf!("dir: {} / {}", v0_1, File_system::closure6((), ()))
    }
    pub fn closure44(v0_1: string, unitVar: ()) {
        let _v1: MutCell<Option<()>> = MutCell::new(None::<()>);
        let v2_1: string = File_system::method3(v0_1);
        let _v3: MutCell<Option<bool>> = MutCell::new(None::<bool>);
        let v5_1: &str = &*v2_1.clone();
        let v7_1: std::string::String = String::from(v5_1);
        let v9_1: std::path::PathBuf = std::path::PathBuf::from(v7_1);
        {
            let x: bool = if v9_1.clone().exists() {
                v9_1.is_dir()
            } else {
                false
            };
            _v3.set(Some(x))
        }
        if match &_v3.get().clone() {
            None => panic!("{}", string("base.run_target / _v3=None"),),
            Some(_v3_0_0) => _v3_0_0.clone(),
        } {
            std::fs::remove_dir_all(&*v2_1).unwrap();
            ()
        }
        _v1.set(Some(()));
        match &_v1.get().clone() {
            None => panic!("{}", string("base.run_target / _v1=None"),),
            Some(_v1_0_0) => _v1_0_0.clone(),
        }
        ()
    }
    pub fn method24(v0_1: string) -> Func0<()> {
        Func0::new({
            let v0_1 = v0_1.clone();
            move || File_system::closure44(v0_1.clone(), ())
        })
    }
    pub fn closure45(unitVar: (), unitVar_1: ()) -> string {
        string("file_system.create_directory")
    }
    pub fn closure46(v0_1: string, v1_1: string, unitVar: ()) -> string {
        sprintf!(
            "dir: {} / result: {} {}",
            v0_1,
            v1_1,
            File_system::closure6((), ())
        )
    }
    pub fn closure47(v0_1: string, unitVar: ()) {
        let _v1: MutCell<Option<Arc<Async<i64>>>> = MutCell::new(None::<Arc<Async<i64>>>);
        {
            let x: Arc<Async<i64>> = defaultOf();
            _v1.set(Some(x))
        }
        {
            let v9_1: Arc<Async<i64>> = match &_v1.get().clone() {
                None => panic!("{}", string("base.run_target / _v1=None"),),
                Some(_v1_0_0) => _v1_0_0.clone(),
            };
            let _v10: MutCell<Option<Arc<Async<()>>>> = MutCell::new(None::<Arc<Async<()>>>);
            {
                let x_2: Arc<Async<()>> = defaultOf();
                _v10.set(Some(x_2))
            }
            {
                let v18_1: Arc<Async<()>> = match &_v10.get().clone() {
                    None => panic!("{}", string("base.run_target / _v10=None"),),
                    Some(_v10_0_0) => _v10_0_0.clone(),
                };
                let _v19: MutCell<Option<()>> = MutCell::new(None::<()>);
                defaultOf::<()>();
                _v19.set(Some(()));
                match &_v19.get().clone() {
                    None => panic!("{}", string("base.run_target / _v19=None"),),
                    Some(_v19_0_0) => _v19_0_0.clone(),
                }
                ()
            }
        }
    }
    pub fn method25(v0_1: string) -> Func0<()> {
        Func0::new({
            let v0_1 = v0_1.clone();
            move || File_system::closure47(v0_1.clone(), ())
        })
    }
    pub fn closure36(unitVar: (), unitVar_1: ()) -> (string, LrcPtr<dyn IDisposable>) {
        let _v0: MutCell<Option<string>> = MutCell::new(None::<string>);
        let _v1: MutCell<Option<string>> = MutCell::new(None::<string>);
        let _v2: MutCell<Option<string>> = MutCell::new(None::<string>);
        let v5_1: Result<std::string::String, std::env::VarError> =
            std::env::var(&*string("CARGO_PKG_NAME"));
        let v7_1: bool = true;
        let _result = v5_1.map(|x| {
            //;
            let v9_1: std::string::String = x;
            let v11_1: string = fable_library_rust::String_::fromString(v9_1);
            let v13_1: bool = true;
            v11_1
        });
        let v15_1: Result<string, std::env::VarError> = _result;
        let v16_1: string = File_system::method0();
        {
            let x: string = v15_1.unwrap_or(v16_1);
            _v2.set(Some(x))
        }
        {
            let x_2: string = match &_v2.get().clone() {
                None => panic!("{}", string("base.run_target / _v2=None"),),
                Some(_v2_0_0) => _v2_0_0.clone(),
            };
            _v1.set(Some(x_2))
        }
        {
            let v32: string = match &_v1.get().clone() {
                None => panic!("{}", string("base.run_target / _v1=None"),),
                Some(_v1_0_0) => _v1_0_0.clone(),
            };
            let _v33: MutCell<Option<string>> = MutCell::new(None::<string>);
            let v35: std::path::PathBuf = std::env::temp_dir();
            let v37: std::path::Display = v35.display();
            let _v38: MutCell<Option<std::string::String>> =
                MutCell::new(None::<std::string::String>);
            {
                let x_4: std::string::String = format!("{}", v37);
                _v38.set(Some(x_4))
            }
            {
                let v48: std::string::String = match &_v38.get().clone() {
                    None => panic!("{}", string("base.run_target / _v38=None"),),
                    Some(_v38_0_0) => _v38_0_0.clone(),
                };
                {
                    let x_6: string = fable_library_rust::String_::fromString(v48);
                    _v33.set(Some(x_6))
                }
                {
                    let v59: string = File_system::method14(
                        match &_v33.get().clone() {
                            None => panic!("{}", string("base.run_target / _v33=None"),),
                            Some(_v33_0_0) => _v33_0_0.clone(),
                        },
                        sprintf!("!{}", v32),
                    );
                    let v60: DateTime = DateTime::now();
                    {
                        let x_8: string = File_system::method14(
                            v59,
                            toString(File_system::method17(new_guid(), v60)),
                        );
                        _v0.set(Some(x_8))
                    }
                    {
                        let v136: string = match &_v0.get().clone() {
                            None => panic!("{}", string("base.run_target / _v0=None"),),
                            Some(_v0_0_0) => _v0_0_0.clone(),
                        };
                        let _v137: MutCell<Option<LrcPtr<dyn IDisposable>>> =
                            MutCell::new(None::<LrcPtr<dyn IDisposable>>);
                        let v138: string = File_system::method22(v136.clone());
                        let v140: Result<(), std::io::Error> =
                            std::fs::create_dir_all(&*v138.clone());
                        let v141 = File_system::method23();
                        let v143: Result<(), std::string::String> = v140.map_err(|x| v141(x));
                        let v146: File_system::US9 = match &v143 {
                            Err(v143_1_0) => File_system::closure39((), v143_1_0.clone()),
                            _ => File_system::closure38((), ()),
                        };
                        match &v146 {
                            File_system::US9::US9_0 => File_system::method4(
                                File_system::US0::US0_0,
                                Func0::new(move || File_system::closure42((), ())),
                                Func0::new({
                                    let v138 = v138.clone();
                                    move || File_system::closure43(v138.clone(), ())
                                }),
                            ),
                            File_system::US9::US9_1(v146_1_0) => File_system::method4(
                                File_system::US0::US0_4,
                                Func0::new(move || File_system::closure40((), ())),
                                Func0::new({
                                    let v138 = v138.clone();
                                    let v146 = v146.clone();
                                    move || {
                                        File_system::closure41(
                                            v138.clone(),
                                            match &v146 {
                                                File_system::US9::US9_1(x) => x.clone(),
                                                _ => unreachable!(),
                                            },
                                            (),
                                        )
                                    }
                                }),
                            ),
                        }
                        {
                            let _v154: MutCell<Option<LrcPtr<dyn IDisposable>>> =
                                MutCell::new(None::<LrcPtr<dyn IDisposable>>);
                            {
                                let x_11: LrcPtr<dyn IDisposable> = interface_cast!(
                                    File_system::Disposable::_ctor__3A5B6456(Func0::new({
                                        let v138 = v138.clone();
                                        move || {
                                            Func0::new({
                                                let v138 = v138.clone();
                                                move || File_system::closure44(v138.clone(), ())
                                            })()
                                        }
                                    })),
                                    Lrc<dyn IDisposable>,
                                );
                                _v154.set(Some(x_11))
                            }
                            {
                                let x_13: LrcPtr<dyn IDisposable> = match &_v154.get().clone() {
                                    None => panic!("{}", string("base.run_target / _v154=None"),),
                                    Some(_v154_0_0) => _v154_0_0.clone(),
                                };
                                _v137.set(Some(x_13))
                            }
                            (
                                v136,
                                match &_v137.get().clone() {
                                    None => panic!("{}", string("base.run_target / _v137=None"),),
                                    Some(_v137_0_0) => _v137_0_0.clone(),
                                },
                            )
                        }
                    }
                }
            }
        }
    }
    pub fn closure48(unitVar: (), unitVar_1: ()) -> string {
        string("C:\\home\\git\\polyglot\\lib\\spiral")
    }
    pub fn closure52(unitVar: (), v0_1: string) -> bool {
        let _v1: MutCell<Option<bool>> = MutCell::new(None::<bool>);
        let v3_1: &str = &*v0_1;
        let v5_1: std::string::String = String::from(v3_1);
        let v7_1: std::path::PathBuf = std::path::PathBuf::from(v5_1);
        {
            let x: bool = if v7_1.clone().exists() {
                v7_1.is_file()
            } else {
                false
            };
            _v1.set(Some(x))
        }
        match &_v1.get().clone() {
            None => panic!("{}", string("base.run_target / _v1=None"),),
            Some(_v1_0_0) => _v1_0_0.clone(),
        }
    }
    pub fn closure53(unitVar: (), v0_1: string) -> bool {
        let _v1: MutCell<Option<bool>> = MutCell::new(None::<bool>);
        let v3_1: &str = &*v0_1;
        let v5_1: std::string::String = String::from(v3_1);
        let v7_1: std::path::PathBuf = std::path::PathBuf::from(v5_1);
        {
            let x: bool = if v7_1.clone().exists() {
                v7_1.is_dir()
            } else {
                false
            };
            _v1.set(Some(x))
        }
        match &_v1.get().clone() {
            None => panic!("{}", string("base.run_target / _v1=None"),),
            Some(_v1_0_0) => _v1_0_0.clone(),
        }
    }
    pub fn closure54(unitVar: (), v0_1: string) -> Option<string> {
        let _v1: MutCell<Option<File_system::US8>> = MutCell::new(None::<File_system::US8>);
        let v3_1: &str = &*v0_1;
        let v5_1: std::string::String = String::from(v3_1);
        let v7_1: std::path::PathBuf = std::path::PathBuf::from(v5_1);
        let v9_1: Option<std::path::PathBuf> = v7_1.parent().map(std::path::PathBuf::from);
        let v11_1: std::path::PathBuf = v9_1?;
        let v13_1: std::path::Display = v11_1.display();
        let _v14: MutCell<Option<std::string::String>> = MutCell::new(None::<std::string::String>);
        {
            let x: std::string::String = format!("{}", v13_1);
            _v14.set(Some(x))
        }
        {
            let v24: std::string::String = match &_v14.get().clone() {
                None => panic!("{}", string("base.run_target / _v14=None"),),
                Some(_v14_0_0) => _v14_0_0.clone(),
            };
            {
                let x_2: File_system::US8 =
                    File_system::US8::US8_0(fable_library_rust::String_::fromString(v24));
                _v1.set(Some(x_2))
            }
            {
                let v51: File_system::US8 = match &_v1.get().clone() {
                    None => panic!("{}", string("base.run_target / _v1=None"),),
                    Some(_v1_0_0) => _v1_0_0.clone(),
                };
                match &v51 {
                    File_system::US8::US8_0(v51_0_0) => Some(match &v51 {
                        File_system::US8::US8_0(x) => x.clone(),
                        _ => unreachable!(),
                    }),
                    _ => None::<string>,
                }
            }
        }
    }
    pub fn method27() -> Func1<string, Option<string>> {
        Func1::new(move |v: string| File_system::closure54((), v))
    }
    pub fn method28(v0_1: string, v1_1: bool, v2_1: string, v3_1: string) -> string {
        let v0_1: MutCell<string> = MutCell::new(v0_1.clone());
        let v1_1: MutCell<bool> = MutCell::new(v1_1);
        let v2_1: MutCell<string> = MutCell::new(v2_1.clone());
        let v3_1: MutCell<string> = MutCell::new(v3_1.clone());
        '_method28: loop {
            break '_method28 (if (if v1_1.get().clone() {
                Func1::new(move |v: string| File_system::closure52((), v))
            } else {
                Func1::new(move |v_1: string| File_system::closure53((), v_1))
            })(File_system::method14(
                v3_1.get().clone(),
                v0_1.get().clone(),
            )) {
                v3_1.get().clone()
            } else {
                let v10_1: Option<string> = (File_system::method27())(v3_1.get().clone());
                let _v11: LrcPtr<MutCell<Option<File_system::US8>>> =
                    refCell(None::<File_system::US8>);
                {
                    let x_2: Option<File_system::US8> = match &v10_1 {
                        None => None::<File_system::US8>,
                        Some(v10_1_0_0) => {
                            let x: string = v10_1_0_0.clone();
                            Some((Func0::new({
                                let x = x.clone();
                                move || File_system::US8::US8_0(x.clone())
                            }))())
                        }
                    };
                    _v11.set(x_2)
                }
                {
                    let v16_1: File_system::US8 =
                        defaultValue(File_system::US8::US8_1, _v11.get().clone());
                    match &v16_1 {
                        File_system::US8::US8_0(v16_1_0_0) => {
                            let v0_1_temp: string = v0_1.get().clone();
                            let v1_1_temp: bool = v1_1.get().clone();
                            let v2_1_temp: string = v2_1.get().clone();
                            let v3_1_temp: string = match &v16_1 {
                                File_system::US8::US8_0(x) => x.clone(),
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
    pub fn method26(v0_1: string, v1_1: bool, v2_1: string) -> string {
        if (if v1_1 {
            Func1::new(move |v: string| File_system::closure52((), v))
        } else {
            Func1::new(move |v_1: string| File_system::closure53((), v_1))
        })(File_system::method14(v2_1.clone(), v0_1.clone()))
        {
            v2_1.clone()
        } else {
            let v9_1: Option<string> = (File_system::method27())(v2_1.clone());
            let _v10: LrcPtr<MutCell<Option<File_system::US8>>> = refCell(None::<File_system::US8>);
            {
                let x_2: Option<File_system::US8> = match &v9_1 {
                    None => None::<File_system::US8>,
                    Some(v9_1_0_0) => {
                        let x: string = v9_1_0_0.clone();
                        Some((Func0::new({
                            let x = x.clone();
                            move || File_system::US8::US8_0(x.clone())
                        }))())
                    }
                };
                _v10.set(x_2)
            }
            {
                let v15_1: File_system::US8 =
                    defaultValue(File_system::US8::US8_1, _v10.get().clone());
                match &v15_1 {
                    File_system::US8::US8_0(v15_1_0_0) => File_system::method28(
                        v0_1.clone(),
                        v1_1,
                        v2_1.clone(),
                        match &v15_1 {
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
    }
    pub fn closure51(v0_1: string, v1_1: bool, v2_1: string) -> string {
        File_system::method26(v0_1, v1_1, v2_1)
    }
    pub fn closure50(v0_1: string, v1_1: bool) -> Func1<string, string> {
        Func1::new({
            let v0_1 = v0_1.clone();
            let v1_1 = v1_1.clone();
            move |v: string| File_system::closure51(v0_1.clone(), v1_1, v)
        })
    }
    pub fn closure49(unitVar: (), v0_1: string) -> Func1<bool, Func1<string, string>> {
        Func1::new({
            let v0_1 = v0_1.clone();
            move |v: bool| File_system::closure50(v0_1.clone(), v)
        })
    }
    pub fn method29(v0_1: string) -> string {
        v0_1
    }
    pub fn method30() -> string {
        string("")
    }
    pub fn method31() -> string {
        string("^\\\\\\\\\\?\\\\")
    }
    pub fn method32() -> string {
        string("")
    }
    pub fn closure55(unitVar: (), v0_1: string) -> string {
        let _v1: MutCell<Option<string>> = MutCell::new(None::<string>);
        let v2_1: string = File_system::method29(v0_1);
        let v3_1: string = File_system::method30();
        let _v4: MutCell<Option<Result<regex::Regex, regex::Error>>> =
            MutCell::new(None::<Result<regex::Regex, regex::Error>>);
        let v5_1: string = File_system::method31();
        {
            let x: Result<regex::Regex, regex::Error> = regex::Regex::new(&v5_1);
            _v4.set(Some(x))
        }
        {
            let v13_1: Result<regex::Regex, regex::Error> = match &_v4.get().clone() {
                None => panic!("{}", string("base.run_target / _v4=None"),),
                Some(_v4_0_0) => _v4_0_0.clone(),
            };
            let v15_1: regex::Regex = v13_1.unwrap();
            let v17_1: std::borrow::Cow<str> = v15_1.replace_all(&v2_1, &*v3_1);
            let v19_1: std::string::String = String::from(v17_1);
            {
                let x_2: string = fable_library_rust::String_::fromString(v19_1);
                _v1.set(Some(x_2))
            }
            {
                let v29: string = match &_v1.get().clone() {
                    None => panic!("{}", string("base.run_target / _v1=None"),),
                    Some(_v1_0_0) => _v1_0_0.clone(),
                };
                replace(
                    sprintf!(
                        "{}{}",
                        toLower(ofChar(getCharAt(v29.clone(), 0_i32))),
                        getSlice(v29, Some(1_i32), None::<i32>)
                    ),
                    string("\\"),
                    string("/"),
                )
            }
        }
    }
    pub fn closure56(unitVar: (), v0_1: string) -> string {
        sprintf!("file:///{}", trimStartChars(v0_1, new_array(&['/'])))
    }
    pub fn method34(v0_1: string, v1_1: string, v2_1: string) -> string {
        let v0_1: MutCell<string> = MutCell::new(v0_1.clone());
        let v1_1: MutCell<string> = MutCell::new(v1_1.clone());
        let v2_1: MutCell<string> = MutCell::new(v2_1.clone());
        '_method34: loop {
            break '_method34 ({
                let v3_1: string = File_system::method14(v2_1.get().clone(), v0_1.get().clone());
                let _v4: MutCell<Option<bool>> = MutCell::new(None::<bool>);
                let v6_1: &str = &*v3_1;
                let v8_1: std::string::String = String::from(v6_1);
                let v10_1: std::path::PathBuf = std::path::PathBuf::from(v8_1);
                {
                    let x: bool = if v10_1.clone().exists() {
                        v10_1.is_dir()
                    } else {
                        false
                    };
                    _v4.set(Some(x))
                }
                if match &_v4.get().clone() {
                    None => panic!("{}", string("base.run_target / _v4=None"),),
                    Some(_v4_0_0) => _v4_0_0.clone(),
                } {
                    v2_1.get().clone()
                } else {
                    let v27: Option<string> = (File_system::method27())(v2_1.get().clone());
                    let _v28: LrcPtr<MutCell<Option<File_system::US8>>> =
                        refCell(None::<File_system::US8>);
                    {
                        let x_4: Option<File_system::US8> = match &v27 {
                            None => None::<File_system::US8>,
                            Some(v27_0_0) => {
                                let x_2: string = v27_0_0.clone();
                                Some((Func0::new({
                                    let x_2 = x_2.clone();
                                    move || File_system::US8::US8_0(x_2.clone())
                                }))())
                            }
                        };
                        _v28.set(x_4)
                    }
                    {
                        let v33: File_system::US8 =
                            defaultValue(File_system::US8::US8_1, _v28.get().clone());
                        match &v33 {
                            File_system::US8::US8_0(v33_0_0) => {
                                let v0_1_temp: string = v0_1.get().clone();
                                let v1_1_temp: string = v1_1.get().clone();
                                let v2_1_temp: string = match &v33 {
                                    File_system::US8::US8_0(x) => x.clone(),
                                    _ => unreachable!(),
                                };
                                v0_1.set(v0_1_temp);
                                v1_1.set(v1_1_temp);
                                v2_1.set(v2_1_temp);
                                continue '_method34;
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
    pub fn method33(v0_1: string, v1_1: string) -> string {
        let v2_1: string = File_system::method14(v1_1.clone(), v0_1.clone());
        let _v3: MutCell<Option<bool>> = MutCell::new(None::<bool>);
        let v5_1: &str = &*v2_1;
        let v7_1: std::string::String = String::from(v5_1);
        let v9_1: std::path::PathBuf = std::path::PathBuf::from(v7_1);
        {
            let x: bool = if v9_1.clone().exists() {
                v9_1.is_dir()
            } else {
                false
            };
            _v3.set(Some(x))
        }
        if match &_v3.get().clone() {
            None => panic!("{}", string("base.run_target / _v3=None"),),
            Some(_v3_0_0) => _v3_0_0.clone(),
        } {
            v1_1.clone()
        } else {
            let v26: Option<string> = (File_system::method27())(v1_1.clone());
            let _v27: LrcPtr<MutCell<Option<File_system::US8>>> = refCell(None::<File_system::US8>);
            {
                let x_4: Option<File_system::US8> = match &v26 {
                    None => None::<File_system::US8>,
                    Some(v26_0_0) => {
                        let x_2: string = v26_0_0.clone();
                        Some((Func0::new({
                            let x_2 = x_2.clone();
                            move || File_system::US8::US8_0(x_2.clone())
                        }))())
                    }
                };
                _v27.set(x_4)
            }
            {
                let v32: File_system::US8 =
                    defaultValue(File_system::US8::US8_1, _v27.get().clone());
                match &v32 {
                    File_system::US8::US8_0(v32_0_0) => File_system::method34(
                        v0_1.clone(),
                        v1_1.clone(),
                        match &v32 {
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
    pub fn closure57(unitVar: (), unitVar_1: ()) -> string {
        File_system::method14(
            File_system::method33(
                File_system::method14(string("polyglot"), string(".paket")),
                string("C:\\home\\git\\polyglot\\lib\\spiral"),
            ),
            string("polyglot"),
        )
    }
    pub fn method35(v0_1: string) {
        let _v1: MutCell<Option<()>> = MutCell::new(None::<()>);
        _v1.set(Some(()));
        match &_v1.get().clone() {
            None => panic!("{}", string("base.run_target / _v1=None"),),
            Some(_v1_0_0) => _v1_0_0.clone(),
        }
        ()
    }
    pub fn closure59(unitVar: (), v0_1: string) {
        File_system::method35(v0_1);
    }
    pub fn closure58(unitVar: (), v0_1: bool) {
        if File_system::State::trace_state().get().clone().is_none() {
            File_system::State::trace_state()
                .set(Some(File_system::closure0((), File_system::US0::US0_0)));
        }
        {
            let patternInput: (
                LrcPtr<File_system::Mut0>,
                LrcPtr<File_system::Mut1>,
                LrcPtr<File_system::Mut2>,
                Option<i64>,
                LrcPtr<File_system::Mut3>,
            ) = getValue(File_system::State::trace_state().get().clone());
            let v10_1 = if v0_1 {
                Func1::new(move |v_1: string| File_system::closure59((), v_1))
            } else {
                Func1::new(move |v_2: string| File_system::closure1((), v_2))
            };
            (patternInput.4.clone()).l0.set(v10_1);
            ()
        }
    }
    pub fn closure61(v0_1: string, v1_1: string) -> string {
        File_system::method14(v0_1, v1_1)
    }
    pub fn closure60(unitVar: (), v0_1: string) -> Func1<string, string> {
        Func1::new({
            let v0_1 = v0_1.clone();
            move |v: string| File_system::closure61(v0_1.clone(), v)
        })
    }
    pub fn v0() -> Func1<
        File_system::US0,
        (
            LrcPtr<File_system::Mut0>,
            LrcPtr<File_system::Mut1>,
            LrcPtr<File_system::Mut2>,
            Option<i64>,
            LrcPtr<File_system::Mut3>,
        ),
    > {
        static v0: OnceInit<
            Func1<
                File_system::US0,
                (
                    LrcPtr<File_system::Mut0>,
                    LrcPtr<File_system::Mut1>,
                    LrcPtr<File_system::Mut2>,
                    Option<i64>,
                    LrcPtr<File_system::Mut3>,
                ),
            >,
        > = OnceInit::new();
        v0.get_or_init(|| Func1::new(move |v: File_system::US0| File_system::closure0((), v)))
            .clone()
    }
    pub fn v1() -> File_system::US0 {
        static v1: OnceInit<File_system::US0> = OnceInit::new();
        v1.get_or_init(|| File_system::US0::US0_0).clone()
    }
    on_startup!(
        if File_system::State::trace_state().get().clone().is_none() {
            File_system::State::trace_state().set(Some((File_system::v0())(File_system::v1())));
        }
    );
    pub fn v2() -> Func1<string, Arc<Async<i64>>> {
        static v2: OnceInit<Func1<string, Arc<Async<i64>>>> = OnceInit::new();
        v2.get_or_init(|| Func1::new(move |v: string| File_system::closure2((), v)))
            .clone()
    }
    pub fn delete_directory_async(x: string) -> Arc<Async<i64>> {
        (File_system::v2())(x)
    }
    pub fn v3() -> Func1<File_system::US2, Func1<string, Arc<Async<i64>>>> {
        static v3: OnceInit<Func1<File_system::US2, Func1<string, Arc<Async<i64>>>>> =
            OnceInit::new();
        v3.get_or_init(|| Func1::new(move |v: File_system::US2| File_system::closure8((), v)))
            .clone()
    }
    pub fn wait_for_file_access(x: File_system::US2) -> Func1<string, Arc<Async<i64>>> {
        (File_system::v3())(x)
    }
    pub fn v4() -> Func1<string, Arc<Async<i64>>> {
        static v4: OnceInit<Func1<string, Arc<Async<i64>>>> = OnceInit::new();
        v4.get_or_init(|| Func1::new(move |v: string| File_system::closure12((), v)))
            .clone()
    }
    pub fn wait_for_file_access_read(x: string) -> Arc<Async<i64>> {
        (File_system::v4())(x)
    }
    pub fn v5() -> Func1<string, Arc<Async<string>>> {
        static v5: OnceInit<Func1<string, Arc<Async<string>>>> = OnceInit::new();
        v5.get_or_init(|| Func1::new(move |v: string| File_system::closure13((), v)))
            .clone()
    }
    pub fn read_all_text_async(x: string) -> Arc<Async<string>> {
        (File_system::v5())(x)
    }
    pub fn v6() -> Func1<string, Func1<string, Arc<Async<bool>>>> {
        static v6: OnceInit<Func1<string, Func1<string, Arc<Async<bool>>>>> = OnceInit::new();
        v6.get_or_init(|| Func1::new(move |v: string| File_system::closure14((), v)))
            .clone()
    }
    pub fn file_exists_content(x: string) -> Func1<string, Arc<Async<bool>>> {
        (File_system::v6())(x)
    }
    pub fn v7() -> Func1<string, Func1<string, Arc<Async<()>>>> {
        static v7: OnceInit<Func1<string, Func1<string, Arc<Async<()>>>>> = OnceInit::new();
        v7.get_or_init(|| Func1::new(move |v: string| File_system::closure16((), v)))
            .clone()
    }
    pub fn write_all_text_async(x: string) -> Func1<string, Arc<Async<()>>> {
        (File_system::v7())(x)
    }
    pub fn v8() -> Func1<string, Func1<string, Arc<Async<()>>>> {
        static v8: OnceInit<Func1<string, Func1<string, Arc<Async<()>>>>> = OnceInit::new();
        v8.get_or_init(|| Func1::new(move |v: string| File_system::closure18((), v)))
            .clone()
    }
    pub fn write_all_text_exists(x: string) -> Func1<string, Arc<Async<()>>> {
        (File_system::v8())(x)
    }
    pub fn v9() -> Func1<string, Arc<Async<i64>>> {
        static v9: OnceInit<Func1<string, Arc<Async<i64>>>> = OnceInit::new();
        v9.get_or_init(|| Func1::new(move |v: string| File_system::closure20((), v)))
            .clone()
    }
    pub fn delete_file_async(x: string) -> Arc<Async<i64>> {
        (File_system::v9())(x)
    }
    pub fn v10() -> Func1<string, Func1<string, Arc<Async<i64>>>> {
        static v10: OnceInit<Func1<string, Func1<string, Arc<Async<i64>>>>> = OnceInit::new();
        v10.get_or_init(|| Func1::new(move |v: string| File_system::closure23((), v)))
            .clone()
    }
    pub fn move_file_async(x: string) -> Func1<string, Arc<Async<i64>>> {
        (File_system::v10())(x)
    }
    pub fn v11() -> Func1<string, Arc<Async<Option<string>>>> {
        static v11: OnceInit<Func1<string, Arc<Async<Option<string>>>>> = OnceInit::new();
        v11.get_or_init(|| Func1::new(move |v: string| File_system::closure27((), v)))
            .clone()
    }
    pub fn read_all_text_retry_async(x: string) -> Arc<Async<Option<string>>> {
        (File_system::v11())(x)
    }
    pub fn v12() -> Func0<string> {
        static v12: OnceInit<Func0<string>> = OnceInit::new();
        v12.get_or_init(|| Func0::new(move || File_system::closure35((), ())))
            .clone()
    }
    pub fn create_temp_directory_name() -> string {
        (File_system::v12())()
    }
    pub fn v13() -> Func0<(string, LrcPtr<dyn IDisposable>)> {
        static v13: OnceInit<Func0<(string, LrcPtr<dyn IDisposable>)>> = OnceInit::new();
        v13.get_or_init(|| Func0::new(move || File_system::closure36((), ())))
            .clone()
    }
    pub fn create_temp_directory() -> (string, LrcPtr<dyn IDisposable>) {
        (File_system::v13())()
    }
    pub fn v14() -> Func0<string> {
        static v14: OnceInit<Func0<string>> = OnceInit::new();
        v14.get_or_init(|| Func0::new(move || File_system::closure48((), ())))
            .clone()
    }
    pub fn get_source_directory() -> string {
        (File_system::v14())()
    }
    pub fn v15() -> Func1<string, Func1<bool, Func1<string, string>>> {
        static v15: OnceInit<Func1<string, Func1<bool, Func1<string, string>>>> = OnceInit::new();
        v15.get_or_init(|| Func1::new(move |v: string| File_system::closure49((), v)))
            .clone()
    }
    pub fn find_parent(x: string) -> Func1<bool, Func1<string, string>> {
        (File_system::v15())(x)
    }
    pub fn v16() -> Func1<string, string> {
        static v16: OnceInit<Func1<string, string>> = OnceInit::new();
        v16.get_or_init(|| Func1::new(move |v: string| File_system::closure55((), v)))
            .clone()
    }
    pub fn normalize_path(x: string) -> string {
        (File_system::v16())(x)
    }
    pub fn v17() -> Func1<string, string> {
        static v17: OnceInit<Func1<string, string>> = OnceInit::new();
        v17.get_or_init(|| Func1::new(move |v: string| File_system::closure56((), v)))
            .clone()
    }
    pub fn new_file_uri(x: string) -> string {
        (File_system::v17())(x)
    }
    pub fn v18() -> Func0<string> {
        static v18: OnceInit<Func0<string>> = OnceInit::new();
        v18.get_or_init(|| Func0::new(move || File_system::closure57((), ())))
            .clone()
    }
    pub fn get_workspace_root() -> string {
        (File_system::v18())()
    }
    pub fn v19() -> Func1<bool, ()> {
        static v19: OnceInit<Func1<bool, ()>> = OnceInit::new();
        v19.get_or_init(|| Func1::new(move |v: bool| File_system::closure58((), v)))
            .clone()
    }
    pub fn init_trace_file(x: bool) {
        (File_system::v19())(x);
    }
    pub fn v20() -> Func1<string, Func1<string, string>> {
        static v20: OnceInit<Func1<string, Func1<string, string>>> = OnceInit::new();
        v20.get_or_init(|| Func1::new(move |v: string| File_system::closure60((), v)))
            .clone()
    }
    pub fn op_LessDivideGreater(x: string) -> Func1<string, string> {
        (File_system::v20())(x)
    }
    on_startup!(());
}
