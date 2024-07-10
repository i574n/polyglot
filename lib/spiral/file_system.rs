pub mod File_system {
    use super::*;
    type Async<T> = T;
    use fable_library_rust::DateTime_::DateTime;
    use fable_library_rust::Guid_::new_guid;
    use fable_library_rust::Guid_::parse;
    use fable_library_rust::Guid_::Guid;
    use fable_library_rust::Interfaces_::System::Collections::Generic::IEnumerable_1;
    use fable_library_rust::Interfaces_::System::IDisposable;
    use fable_library_rust::List_::empty;
    use fable_library_rust::List_::ofArray;
    use fable_library_rust::List_::singleton;
    use fable_library_rust::List_::toArray;
    use fable_library_rust::Map_::find;
    use fable_library_rust::Map_::ofSeq;
    use fable_library_rust::NativeArray_::new_array;
    use fable_library_rust::NativeArray_::Array;
    use fable_library_rust::Native_::defaultOf;
    use fable_library_rust::Native_::interface_cast;
    use fable_library_rust::Native_::on_startup;
    use fable_library_rust::Native_::refCell;
    use fable_library_rust::Native_::Any;
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
    use fable_library_rust::String_::append;
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
                    LrcPtr<File_system::Mut3>,
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
                            LrcPtr<File_system::Mut2>,
                            LrcPtr<File_system::Mut3>,
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
                            LrcPtr<File_system::Mut2>,
                            LrcPtr<File_system::Mut3>,
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
    #[derive(Clone, Debug)]
    pub struct Mut1 {
        pub l0: MutCell<Func1<string, ()>>,
    }
    impl core::fmt::Display for File_system::Mut1 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Debug, Default, PartialEq, PartialOrd, Hash, Eq)]
    pub struct Mut2 {
        pub l0: MutCell<bool>,
    }
    impl core::fmt::Display for File_system::Mut2 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Debug, PartialEq, PartialOrd, Hash, Eq)]
    pub struct Mut3 {
        pub l0: MutCell<File_system::US0>,
    }
    impl core::fmt::Display for File_system::Mut3 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Copy, Debug, PartialEq, PartialOrd, Hash, Eq)]
    pub enum US1 {
        US1_0(File_system::US0),
        US1_1,
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
    impl core::fmt::Display for File_system::US2 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Debug, PartialEq, PartialOrd, Hash, Eq)]
    pub enum US3 {
        US3_0(string),
        US3_1,
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
    }
    impl core::fmt::Display for File_system::US4 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Copy, Debug, PartialEq, PartialOrd, Hash, Eq)]
    pub enum US5 {
        US5_0(File_system::US4),
        US5_1(File_system::US4),
        US5_2(File_system::US4),
        US5_3(File_system::US4),
        US5_4(File_system::US4),
    }
    impl core::fmt::Display for File_system::US5 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Debug, Default, PartialEq, PartialOrd, Hash, Eq)]
    pub struct Mut4 {
        pub l0: MutCell<string>,
    }
    impl core::fmt::Display for File_system::Mut4 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Copy, Debug, PartialEq, PartialOrd, Hash, Eq)]
    pub enum US7 {
        US7_0,
        US7_1,
        US7_2,
    }
    impl core::fmt::Display for File_system::US7 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Copy, Debug, PartialEq, PartialOrd, Hash, Eq)]
    pub enum US8 {
        US8_0,
        US8_1,
        US8_2,
        US8_3,
        US8_4,
    }
    impl core::fmt::Display for File_system::US8 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Copy, Debug, PartialEq, PartialOrd, Hash, Eq)]
    pub enum US6 {
        US6_0(File_system::US7, File_system::US8),
        US6_1,
    }
    impl core::fmt::Display for File_system::US6 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Debug)]
    pub enum US9 {
        US9_0(i64),
        US9_1(LrcPtr<Exception>),
    }
    impl core::fmt::Display for File_system::US9 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Debug)]
    pub enum US10 {
        US10_0(i64),
        US10_1(LrcPtr<Exception>),
    }
    impl core::fmt::Display for File_system::US10 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Debug)]
    pub enum US11 {
        US11_0(chrono::DateTime<chrono::Utc>),
        US11_1,
    }
    impl core::fmt::Display for File_system::US11 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Debug)]
    pub enum US12 {
        US12_0,
        US12_1(std::string::String),
    }
    impl core::fmt::Display for File_system::US12 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Debug, PartialEq, PartialOrd, Hash, Eq)]
    pub enum US13 {
        US13_0(string),
        US13_1(string),
    }
    impl core::fmt::Display for File_system::US13 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    pub fn method0() -> string {
        string("TRACE_LEVEL")
    }
    pub fn method2() -> string {
        string("")
    }
    pub fn method1(v0: string) -> string {
        let _v3: MutCell<Option<string>> = MutCell::new(None::<string>);
        let v5: Result<std::string::String, std::env::VarError> = std::env::var(&*v0);
        let v7: bool = true;
        let _result = v5.map(|x| {
            //;
            let v9_1: std::string::String = x;
            let v11_1: string = fable_library_rust::String_::fromString(v9_1);
            let v13_1: bool = true;
            v11_1
        });
        let v15_1: Result<string, std::env::VarError> = _result;
        let v16_1: string = File_system::method2();
        {
            let x: string = v15_1.unwrap_or(v16_1);
            _v3.set(Some(x))
        }
        match &_v3.get().clone() {
            None => panic!("{}", string("base.run_target / _v3=None"),),
            Some(_v3_0_0) => _v3_0_0.clone(),
        }
    }
    pub fn method3() -> string {
        string("AUTOMATION")
    }
    pub fn closure1(unitVar: (), v0: string) {
        ();
    }
    pub fn closure0(
        unitVar: (),
        v0: File_system::US0,
    ) -> (
        LrcPtr<File_system::Mut0>,
        LrcPtr<File_system::Mut1>,
        LrcPtr<File_system::Mut2>,
        LrcPtr<File_system::Mut3>,
        Option<i64>,
    ) {
        let _v3: MutCell<Option<(File_system::US1, File_system::US2)>> =
            MutCell::new(None::<(File_system::US1, File_system::US2)>);
        let v5: string = File_system::method1(File_system::method0());
        let v11_1: File_system::US1 = if string("Verbose") == v5.clone() {
            File_system::US1::US1_0(File_system::US0::US0_0)
        } else {
            File_system::US1::US1_1
        };
        {
            let x: (File_system::US1, File_system::US2) = (
                match &v11_1 {
                    File_system::US1::US1_0(v11_1_0_0) => File_system::US1::US1_0(match &v11_1 {
                        File_system::US1::US1_0(x) => x.clone(),
                        _ => unreachable!(),
                    }),
                    _ => {
                        let v19_1: File_system::US1 = if string("Debug") == v5.clone() {
                            File_system::US1::US1_0(File_system::US0::US0_1)
                        } else {
                            File_system::US1::US1_1
                        };
                        match &v19_1 {
                            File_system::US1::US1_0(v19_1_0_0) => {
                                File_system::US1::US1_0(match &v19_1 {
                                    File_system::US1::US1_0(x) => x.clone(),
                                    _ => unreachable!(),
                                })
                            }
                            _ => {
                                let v27_1: File_system::US1 = if string("Info") == v5.clone() {
                                    File_system::US1::US1_0(File_system::US0::US0_2)
                                } else {
                                    File_system::US1::US1_1
                                };
                                match &v27_1 {
                                    File_system::US1::US1_0(v27_1_0_0) => {
                                        File_system::US1::US1_0(match &v27_1 {
                                            File_system::US1::US1_0(x) => x.clone(),
                                            _ => unreachable!(),
                                        })
                                    }
                                    _ => {
                                        let v35: File_system::US1 =
                                            if string("Warning") == v5.clone() {
                                                File_system::US1::US1_0(File_system::US0::US0_3)
                                            } else {
                                                File_system::US1::US1_1
                                            };
                                        match &v35 {
                                            File_system::US1::US1_0(v35_0_0) => {
                                                File_system::US1::US1_0(match &v35 {
                                                    File_system::US1::US1_0(x) => x.clone(),
                                                    _ => unreachable!(),
                                                })
                                            }
                                            _ => {
                                                let v43: File_system::US1 = if string("Critical")
                                                    == v5.clone()
                                                {
                                                    File_system::US1::US1_0(File_system::US0::US0_4)
                                                } else {
                                                    File_system::US1::US1_1
                                                };
                                                match &v43 {
                                                    File_system::US1::US1_0(v43_0_0) => {
                                                        File_system::US1::US1_0(match &v43 {
                                                            File_system::US1::US1_0(x) => x.clone(),
                                                            _ => unreachable!(),
                                                        })
                                                    }
                                                    _ => File_system::US1::US1_1,
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                },
                if File_system::method1(File_system::method3()) == string("True") {
                    File_system::US2::US2_0({
                        let _arg: DateTime = DateTime::now();
                        _arg.ticks()
                    })
                } else {
                    File_system::US2::US2_1
                },
            );
            _v3.set(Some(x))
        }
        {
            let patternInput: (File_system::US1, File_system::US2) = match &_v3.get().clone() {
                None => panic!("{}", string("base.run_target / _v3=None"),),
                Some(_v3_0_0) => _v3_0_0.clone(),
            };
            let v325: File_system::US2 = patternInput.1.clone();
            let v324: File_system::US1 = patternInput.0.clone();
            (
                LrcPtr::new(File_system::Mut0 {
                    l0: MutCell::new(0_i64),
                }),
                LrcPtr::new(File_system::Mut1 {
                    l0: MutCell::new(Func1::new(move |v: string| File_system::closure1((), v))),
                }),
                LrcPtr::new(File_system::Mut2 {
                    l0: MutCell::new(true),
                }),
                LrcPtr::new(File_system::Mut3 {
                    l0: MutCell::new(match &v324 {
                        File_system::US1::US1_0(v324_0_0) => match &v324 {
                            File_system::US1::US1_0(x) => x.clone(),
                            _ => unreachable!(),
                        },
                        _ => v0,
                    }),
                }),
                match &v325 {
                    File_system::US2::US2_0(v325_0_0) => Some(match &v325 {
                        File_system::US2::US2_0(x) => x.clone(),
                        _ => unreachable!(),
                    }),
                    _ => None::<i64>,
                },
            )
        }
    }
    pub fn method6(v0: string) -> string {
        v0
    }
    pub fn method7(v0: string) -> bool {
        let _v3: MutCell<Option<bool>> = MutCell::new(None::<bool>);
        let v5: &str = &*v0;
        let v7: std::string::String = String::from(v5);
        let v9_1: std::path::PathBuf = std::path::PathBuf::from(v7);
        {
            let x: bool = if v9_1.clone().exists() {
                true
            } else {
                if v9_1.clone().is_dir() {
                    true
                } else {
                    v9_1.is_symlink()
                }
            };
            _v3.set(Some(x))
        }
        match &_v3.get().clone() {
            None => panic!("{}", string("base.run_target / _v3=None"),),
            Some(_v3_0_0) => _v3_0_0.clone(),
        }
    }
    pub fn method5(v0: bool, v1: string) {
        let _v4: MutCell<Option<()>> = MutCell::new(None::<()>);
        let v5: string = File_system::method6(v1);
        if File_system::method7(v5.clone()) {
            if v0 {
                std::fs::remove_dir_all(&*v5.clone()).unwrap();
                ()
            } else {
                std::fs::remove_dir(&*v5).unwrap();
                ()
            };
        }
        _v4.set(Some(()));
        match &_v4.get().clone() {
            None => panic!("{}", string("base.run_target / _v4=None"),),
            Some(_v4_0_0) => _v4_0_0.clone(),
        }
        ()
    }
    pub fn closure3(unitVar: (), unitVar_1: ()) -> string {
        string("file_system.delete_directory_async")
    }
    pub fn method8(v0: string) -> string {
        let _v3: MutCell<Option<string>> = MutCell::new(None::<string>);
        let v5: &str = &*v0;
        let v7: std::string::String = String::from(v5);
        let v9_1: std::path::PathBuf = std::path::PathBuf::from(v7);
        let v11_1: Option<&std::ffi::OsStr> = v9_1.file_name();
        let v13_1: &std::ffi::OsStr = v11_1.unwrap();
        let v15_1: std::ffi::OsString = v13_1.to_os_string();
        let v17_1: Option<&str> = v15_1.to_str();
        let v19_1: &str = v17_1.unwrap();
        let v21_1: std::string::String = String::from(v19_1);
        {
            let x: string = fable_library_rust::String_::fromString(v21_1);
            _v3.set(Some(x))
        }
        match &_v3.get().clone() {
            None => panic!("{}", string("base.run_target / _v3=None"),),
            Some(_v3_0_0) => _v3_0_0.clone(),
        }
    }
    pub fn closure4(v0: string, v1: string, unitVar: ()) -> (string, string) {
        (v1, File_system::method8(v0))
    }
    pub fn method10() -> string {
        string("hh:mm:ss")
    }
    pub fn method11() -> string {
        string("")
    }
    pub fn method12() -> string {
        string("HH:mm:ss")
    }
    pub fn method13() -> string {
        string("\u{001b}[0m")
    }
    pub fn method15(v0: LrcPtr<File_system::Mut4>, v1: string) {
        let v4: string = sprintf!("{}", v1);
        let v12_1: string = append(v0.l0.get().clone(), v4);
        v0.l0.set(v12_1);
        ()
    }
    pub fn method16(v0: LrcPtr<File_system::Mut4>) {
        ();
    }
    pub fn method14(v0: LrcPtr<File_system::Mut4>, v1: string, v2_1: string) {
        File_system::method15(v0.clone(), string("{ "));
        File_system::method16(v0.clone());
        File_system::method15(v0.clone(), string("ex"));
        File_system::method15(v0.clone(), string(" = "));
        File_system::method15(v0.clone(), v1);
        File_system::method15(v0.clone(), string("; "));
        File_system::method15(v0.clone(), string("path"));
        File_system::method15(v0.clone(), string(" = "));
        File_system::method15(v0.clone(), v2_1);
        File_system::method15(v0, string(" }"))
    }
    pub fn closure5(
        v0: File_system::US0,
        v1: Func0<string>,
        v2_1: Func0<(string, string)>,
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
                LrcPtr<File_system::Mut3>,
                Option<i64>,
            ) = getValue(File_system::State::trace_state().get().clone());
            let v18_1: Option<i64> = patternInput.4.clone();
            let _v35: MutCell<Option<string>> = MutCell::new(None::<string>);
            let _v38: LrcPtr<MutCell<Option<File_system::US2>>> = refCell(None::<File_system::US2>);
            {
                let x_2: Option<File_system::US2> = match &v18_1 {
                    None => None::<File_system::US2>,
                    Some(v18_1_0_0) => {
                        let x: i64 = v18_1_0_0.clone();
                        Some((Func0::new({
                            let x = x.clone();
                            move || File_system::US2::US2_0(x)
                        }))())
                    }
                };
                _v38.set(x_2)
            }
            {
                let v65: File_system::US2 =
                    defaultValue(File_system::US2::US2_1, _v38.get().clone());
                let v163: DateTime = match &v65 {
                    File_system::US2::US2_0(v65_0_0) => {
                        let v97: TimeSpan = TimeSpan::new_ticks(
                            {
                                let _arg: DateTime = DateTime::now();
                                _arg.ticks()
                            } - match &v65 {
                                File_system::US2::US2_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                        );
                        DateTime::new_ymdhms_milli(
                            1_i32,
                            1_i32,
                            1_i32,
                            v97.hours(),
                            v97.minutes(),
                            v97.seconds(),
                            v97.milliseconds(),
                        )
                    }
                    _ => DateTime::now(),
                };
                {
                    let x_3: string = {
                        let provider: string = File_system::method10();
                        v163.toString(provider)
                    };
                    _v35.set(Some(x_3))
                }
                {
                    let v772: string = match &_v35.get().clone() {
                        None => panic!("{}", string("base.run_target / _v35=None"),),
                        Some(_v35_0_0) => _v35_0_0.clone(),
                    };
                    let v931: File_system::US3 = if if let File_system::US0::US0_0 = &v0 {
                        true
                    } else {
                        false
                    } {
                        File_system::US3::US3_0(string("Verbose"))
                    } else {
                        File_system::US3::US3_1
                    };
                    let v980: File_system::US3 = match &v931 {
                        File_system::US3::US3_0(v931_0_0) => File_system::US3::US3_0(match &v931 {
                            File_system::US3::US3_0(x) => x.clone(),
                            _ => unreachable!(),
                        }),
                        _ => {
                            let v940: File_system::US3 = if if let File_system::US0::US0_1 = &v0 {
                                true
                            } else {
                                false
                            } {
                                File_system::US3::US3_0(string("Debug"))
                            } else {
                                File_system::US3::US3_1
                            };
                            match &v940 {
                                File_system::US3::US3_0(v940_0_0) => {
                                    File_system::US3::US3_0(match &v940 {
                                        File_system::US3::US3_0(x) => x.clone(),
                                        _ => unreachable!(),
                                    })
                                }
                                _ => {
                                    let v949: File_system::US3 =
                                        if if let File_system::US0::US0_2 = &v0 {
                                            true
                                        } else {
                                            false
                                        } {
                                            File_system::US3::US3_0(string("Info"))
                                        } else {
                                            File_system::US3::US3_1
                                        };
                                    match &v949 {
                                        File_system::US3::US3_0(v949_0_0) => {
                                            File_system::US3::US3_0(match &v949 {
                                                File_system::US3::US3_0(x) => x.clone(),
                                                _ => unreachable!(),
                                            })
                                        }
                                        _ => {
                                            let v958: File_system::US3 =
                                                if if let File_system::US0::US0_3 = &v0 {
                                                    true
                                                } else {
                                                    false
                                                } {
                                                    File_system::US3::US3_0(string("Warning"))
                                                } else {
                                                    File_system::US3::US3_1
                                                };
                                            match &v958 {
                                                File_system::US3::US3_0(v958_0_0) => {
                                                    File_system::US3::US3_0(match &v958 {
                                                        File_system::US3::US3_0(x) => x.clone(),
                                                        _ => unreachable!(),
                                                    })
                                                }
                                                _ => {
                                                    let v967: File_system::US3 =
                                                        if if let File_system::US0::US0_4 = &v0 {
                                                            true
                                                        } else {
                                                            false
                                                        } {
                                                            File_system::US3::US3_0(string(
                                                                "Critical",
                                                            ))
                                                        } else {
                                                            File_system::US3::US3_1
                                                        };
                                                    match &v967 {
                                                        File_system::US3::US3_0(v967_0_0) => {
                                                            File_system::US3::US3_0(match &v967 {
                                                                File_system::US3::US3_0(x) => {
                                                                    x.clone()
                                                                }
                                                                _ => unreachable!(),
                                                            })
                                                        }
                                                        _ => File_system::US3::US3_1,
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    };
                    let v997: string = padLeft(
                        toLower(match &v980 {
                            File_system::US3::US3_0(v980_0_0) => match &v980 {
                                File_system::US3::US3_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                            _ => panic!("{}", string("Option does not have a value."),),
                        }),
                        7_i32,
                        ' ',
                    );
                    let _v1029: MutCell<Option<string>> = MutCell::new(None::<string>);
                    let v1044: &str = match &v0 {
                        File_system::US0::US0_1 => inline_colorization::color_bright_blue,
                        File_system::US0::US0_2 => inline_colorization::color_bright_green,
                        File_system::US0::US0_0 => inline_colorization::color_bright_black,
                        File_system::US0::US0_3 => inline_colorization::color_yellow,
                        _ => inline_colorization::color_bright_red,
                    };
                    let v1046: &str = &*v997;
                    let v1048: &str = inline_colorization::color_reset;
                    let v1050: string = string("format!(\"{v1044}{v1046}{v1048}\")");
                    let v1051: std::string::String = format!("{v1044}{v1046}{v1048}");
                    {
                        let x_5: string = fable_library_rust::String_::fromString(v1051);
                        _v1029.set(Some(x_5))
                    }
                    {
                        let v1141: string = match &_v1029.get().clone() {
                            None => panic!("{}", string("base.run_target / _v1029=None"),),
                            Some(_v1029_0_0) => _v1029_0_0.clone(),
                        };
                        let v1160: i64 = (patternInput.0.clone()).l0.get().clone();
                        let patternInput_1: (string, string) = v2_1();
                        let v1164: LrcPtr<File_system::Mut4> = LrcPtr::new(File_system::Mut4 {
                            l0: MutCell::new(string("")),
                        });
                        File_system::method14(
                            v1164.clone(),
                            patternInput_1.0.clone(),
                            patternInput_1.1.clone(),
                        );
                        {
                            let v1165: string = v1164.l0.get().clone();
                            trimEndChars(
                                trimStartChars(
                                    sprintf!("{} {} #{} {} / {}", v772, v1141, v1160, v1(), v1165),
                                    toArray(empty::<char>()),
                                ),
                                toArray(ofArray(new_array(&[' ', '/']))),
                            )
                        }
                    }
                }
            }
        }
    }
    pub fn method17(v0: File_system::US0, v1: Func0<string>) {
        fn v4(
            v: File_system::US0,
        ) -> (
            LrcPtr<File_system::Mut0>,
            LrcPtr<File_system::Mut1>,
            LrcPtr<File_system::Mut2>,
            LrcPtr<File_system::Mut3>,
            Option<i64>,
        ) {
            File_system::closure0((), v)
        }
        if File_system::State::trace_state().get().clone().is_none() {
            File_system::State::trace_state().set(Some(v4(File_system::US0::US0_0)));
        }
        {
            let patternInput: (
                LrcPtr<File_system::Mut0>,
                LrcPtr<File_system::Mut1>,
                LrcPtr<File_system::Mut2>,
                LrcPtr<File_system::Mut3>,
                Option<i64>,
            ) = getValue(File_system::State::trace_state().get().clone());
            let v13_1: LrcPtr<File_system::Mut0> = patternInput.0.clone();
            if File_system::State::trace_state().get().clone().is_none() {
                File_system::State::trace_state().set(Some(v4(File_system::US0::US0_0)));
            }
            {
                let patternInput_1: (
                    LrcPtr<File_system::Mut0>,
                    LrcPtr<File_system::Mut1>,
                    LrcPtr<File_system::Mut2>,
                    LrcPtr<File_system::Mut3>,
                    Option<i64>,
                ) = getValue(File_system::State::trace_state().get().clone());
                let v61: File_system::US0 = (patternInput_1.3.clone()).l0.get().clone();
                if if (patternInput_1.2.clone()).l0.get().clone() == false {
                    false
                } else {
                    find(
                        v0,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((File_system::US0::US0_0, 0_i32)),
                            LrcPtr::new((File_system::US0::US0_1, 1_i32)),
                            LrcPtr::new((File_system::US0::US0_2, 2_i32)),
                            LrcPtr::new((File_system::US0::US0_3, 3_i32)),
                            LrcPtr::new((File_system::US0::US0_4, 4_i32)),
                        ])))),
                    ) >= find(
                        v61,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((File_system::US0::US0_0, 0_i32)),
                            LrcPtr::new((File_system::US0::US0_1, 1_i32)),
                            LrcPtr::new((File_system::US0::US0_2, 2_i32)),
                            LrcPtr::new((File_system::US0::US0_3, 3_i32)),
                            LrcPtr::new((File_system::US0::US0_4, 4_i32)),
                        ])))),
                    )
                } {
                    let v69: i64 = v13_1.l0.get().clone() + 1_i64;
                    v13_1.l0.set(v69);
                    {
                        let v72: string = sprintf!("{}", v1());
                        let _v81: MutCell<Option<()>> = MutCell::new(None::<()>);
                        println!("{}", v72.clone());
                        _v81.set(Some(()));
                        match &_v81.get().clone() {
                            None => panic!("{}", string("base.run_target / _v81=None"),),
                            Some(_v81_0_0) => _v81_0_0.clone(),
                        }
                        ((patternInput.1.clone()).l0.get().clone())(v72)
                    }
                }
            }
        }
    }
    pub fn method9(v0: File_system::US0, v1: Func0<string>, v2_1: Func0<(string, string)>) {
        File_system::method17(
            v0.clone(),
            Func0::new({
                let v0 = v0.clone();
                let v1 = v1.clone();
                let v2_1 = v2_1.clone();
                move || File_system::closure5(v0.clone(), v1.clone(), v2_1.clone(), ())
            }),
        );
    }
    pub fn method4(v0: string, v1: i64) -> Arc<Async<i64>> {
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
    pub fn closure2(unitVar: (), v0: string) -> Arc<Async<i64>> {
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
    pub fn closure8(unitVar: (), unitVar_1: ()) -> string {
        string("file_system.wait_for_file_access")
    }
    pub fn closure9(v0: string, v1: i64, v2_1: string, unitVar: ()) -> (string, i64, string) {
        (File_system::method8(v0), v1, v2_1)
    }
    pub fn method21(v0: LrcPtr<File_system::Mut4>, v1: i64) {
        let v4: string = sprintf!("{}", v1);
        let v12_1: string = append(v0.l0.get().clone(), v4);
        v0.l0.set(v12_1);
        ()
    }
    pub fn method20(v0: LrcPtr<File_system::Mut4>, v1: string, v2_1: i64, v3_1: string) {
        File_system::method15(v0.clone(), string("{ "));
        File_system::method16(v0.clone());
        File_system::method15(v0.clone(), string("path"));
        File_system::method15(v0.clone(), string(" = "));
        File_system::method15(v0.clone(), v1);
        File_system::method15(v0.clone(), string("; "));
        File_system::method15(v0.clone(), string("retry"));
        File_system::method15(v0.clone(), string(" = "));
        File_system::method21(v0.clone(), v2_1);
        File_system::method15(v0.clone(), string("; "));
        File_system::method15(v0.clone(), string("ex"));
        File_system::method15(v0.clone(), string(" = "));
        File_system::method15(v0.clone(), v3_1);
        File_system::method15(v0, string(" }"))
    }
    pub fn closure10(
        v0: File_system::US0,
        v1: Func0<string>,
        v2_1: Func0<(string, i64, string)>,
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
                LrcPtr<File_system::Mut3>,
                Option<i64>,
            ) = getValue(File_system::State::trace_state().get().clone());
            let v18_1: Option<i64> = patternInput.4.clone();
            let _v35: MutCell<Option<string>> = MutCell::new(None::<string>);
            let _v38: LrcPtr<MutCell<Option<File_system::US2>>> = refCell(None::<File_system::US2>);
            {
                let x_2: Option<File_system::US2> = match &v18_1 {
                    None => None::<File_system::US2>,
                    Some(v18_1_0_0) => {
                        let x: i64 = v18_1_0_0.clone();
                        Some((Func0::new({
                            let x = x.clone();
                            move || File_system::US2::US2_0(x)
                        }))())
                    }
                };
                _v38.set(x_2)
            }
            {
                let v65: File_system::US2 =
                    defaultValue(File_system::US2::US2_1, _v38.get().clone());
                let v163: DateTime = match &v65 {
                    File_system::US2::US2_0(v65_0_0) => {
                        let v97: TimeSpan = TimeSpan::new_ticks(
                            {
                                let _arg: DateTime = DateTime::now();
                                _arg.ticks()
                            } - match &v65 {
                                File_system::US2::US2_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                        );
                        DateTime::new_ymdhms_milli(
                            1_i32,
                            1_i32,
                            1_i32,
                            v97.hours(),
                            v97.minutes(),
                            v97.seconds(),
                            v97.milliseconds(),
                        )
                    }
                    _ => DateTime::now(),
                };
                {
                    let x_3: string = {
                        let provider: string = File_system::method10();
                        v163.toString(provider)
                    };
                    _v35.set(Some(x_3))
                }
                {
                    let v772: string = match &_v35.get().clone() {
                        None => panic!("{}", string("base.run_target / _v35=None"),),
                        Some(_v35_0_0) => _v35_0_0.clone(),
                    };
                    let v931: File_system::US3 = if if let File_system::US0::US0_0 = &v0 {
                        true
                    } else {
                        false
                    } {
                        File_system::US3::US3_0(string("Verbose"))
                    } else {
                        File_system::US3::US3_1
                    };
                    let v980: File_system::US3 = match &v931 {
                        File_system::US3::US3_0(v931_0_0) => File_system::US3::US3_0(match &v931 {
                            File_system::US3::US3_0(x) => x.clone(),
                            _ => unreachable!(),
                        }),
                        _ => {
                            let v940: File_system::US3 = if if let File_system::US0::US0_1 = &v0 {
                                true
                            } else {
                                false
                            } {
                                File_system::US3::US3_0(string("Debug"))
                            } else {
                                File_system::US3::US3_1
                            };
                            match &v940 {
                                File_system::US3::US3_0(v940_0_0) => {
                                    File_system::US3::US3_0(match &v940 {
                                        File_system::US3::US3_0(x) => x.clone(),
                                        _ => unreachable!(),
                                    })
                                }
                                _ => {
                                    let v949: File_system::US3 =
                                        if if let File_system::US0::US0_2 = &v0 {
                                            true
                                        } else {
                                            false
                                        } {
                                            File_system::US3::US3_0(string("Info"))
                                        } else {
                                            File_system::US3::US3_1
                                        };
                                    match &v949 {
                                        File_system::US3::US3_0(v949_0_0) => {
                                            File_system::US3::US3_0(match &v949 {
                                                File_system::US3::US3_0(x) => x.clone(),
                                                _ => unreachable!(),
                                            })
                                        }
                                        _ => {
                                            let v958: File_system::US3 =
                                                if if let File_system::US0::US0_3 = &v0 {
                                                    true
                                                } else {
                                                    false
                                                } {
                                                    File_system::US3::US3_0(string("Warning"))
                                                } else {
                                                    File_system::US3::US3_1
                                                };
                                            match &v958 {
                                                File_system::US3::US3_0(v958_0_0) => {
                                                    File_system::US3::US3_0(match &v958 {
                                                        File_system::US3::US3_0(x) => x.clone(),
                                                        _ => unreachable!(),
                                                    })
                                                }
                                                _ => {
                                                    let v967: File_system::US3 =
                                                        if if let File_system::US0::US0_4 = &v0 {
                                                            true
                                                        } else {
                                                            false
                                                        } {
                                                            File_system::US3::US3_0(string(
                                                                "Critical",
                                                            ))
                                                        } else {
                                                            File_system::US3::US3_1
                                                        };
                                                    match &v967 {
                                                        File_system::US3::US3_0(v967_0_0) => {
                                                            File_system::US3::US3_0(match &v967 {
                                                                File_system::US3::US3_0(x) => {
                                                                    x.clone()
                                                                }
                                                                _ => unreachable!(),
                                                            })
                                                        }
                                                        _ => File_system::US3::US3_1,
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    };
                    let v997: string = padLeft(
                        toLower(match &v980 {
                            File_system::US3::US3_0(v980_0_0) => match &v980 {
                                File_system::US3::US3_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                            _ => panic!("{}", string("Option does not have a value."),),
                        }),
                        7_i32,
                        ' ',
                    );
                    let _v1029: MutCell<Option<string>> = MutCell::new(None::<string>);
                    let v1044: &str = match &v0 {
                        File_system::US0::US0_1 => inline_colorization::color_bright_blue,
                        File_system::US0::US0_2 => inline_colorization::color_bright_green,
                        File_system::US0::US0_0 => inline_colorization::color_bright_black,
                        File_system::US0::US0_3 => inline_colorization::color_yellow,
                        _ => inline_colorization::color_bright_red,
                    };
                    let v1046: &str = &*v997;
                    let v1048: &str = inline_colorization::color_reset;
                    let v1050: string = string("format!(\"{v1044}{v1046}{v1048}\")");
                    let v1051: std::string::String = format!("{v1044}{v1046}{v1048}");
                    {
                        let x_5: string = fable_library_rust::String_::fromString(v1051);
                        _v1029.set(Some(x_5))
                    }
                    {
                        let v1141: string = match &_v1029.get().clone() {
                            None => panic!("{}", string("base.run_target / _v1029=None"),),
                            Some(_v1029_0_0) => _v1029_0_0.clone(),
                        };
                        let v1160: i64 = (patternInput.0.clone()).l0.get().clone();
                        let patternInput_1: (string, i64, string) = v2_1();
                        let v1165: LrcPtr<File_system::Mut4> = LrcPtr::new(File_system::Mut4 {
                            l0: MutCell::new(string("")),
                        });
                        File_system::method20(
                            v1165.clone(),
                            patternInput_1.0.clone(),
                            patternInput_1.1.clone(),
                            patternInput_1.2.clone(),
                        );
                        {
                            let v1166: string = v1165.l0.get().clone();
                            trimEndChars(
                                trimStartChars(
                                    sprintf!("{} {} #{} {} / {}", v772, v1141, v1160, v1(), v1166),
                                    toArray(empty::<char>()),
                                ),
                                toArray(ofArray(new_array(&[' ', '/']))),
                            )
                        }
                    }
                }
            }
        }
    }
    pub fn method19(v0: File_system::US0, v1: Func0<string>, v2_1: Func0<(string, i64, string)>) {
        File_system::method17(
            v0.clone(),
            Func0::new({
                let v0 = v0.clone();
                let v1 = v1.clone();
                let v2_1 = v2_1.clone();
                move || File_system::closure10(v0.clone(), v1.clone(), v2_1.clone(), ())
            }),
        );
    }
    pub fn method18(
        v0: string,
        v1: File_system::US8,
        v2_1: File_system::US7,
        v3_1: i64,
    ) -> Arc<Async<i64>> {
        let _v6: MutCell<Option<Arc<Async<i64>>>> = MutCell::new(None::<Arc<Async<i64>>>);
        {
            let x: Arc<Async<i64>> = defaultOf();
            _v6.set(Some(x))
        }
        match &_v6.get().clone() {
            None => panic!("{}", string("base.run_target / _v6=None"),),
            Some(_v6_0_0) => _v6_0_0.clone(),
        }
    }
    pub fn closure7(v0: File_system::US6, v1: string) -> Arc<Async<i64>> {
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
    pub fn closure6(unitVar: (), v0: File_system::US6) -> Func1<string, Arc<Async<i64>>> {
        Func1::new({
            let v0 = v0.clone();
            move |v: string| File_system::closure7(v0.clone(), v)
        })
    }
    pub fn method22(v0: string, v1: i64) -> Arc<Async<i64>> {
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
    pub fn closure11(unitVar: (), v0: string) -> Arc<Async<i64>> {
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
    pub fn closure12(unitVar: (), v0: string) -> Arc<Async<string>> {
        let _v3: MutCell<Option<Arc<Async<string>>>> = MutCell::new(None::<Arc<Async<string>>>);
        {
            let x: Arc<Async<string>> = defaultOf();
            _v3.set(Some(x))
        }
        match &_v3.get().clone() {
            None => panic!("{}", string("base.run_target / _v3=None"),),
            Some(_v3_0_0) => _v3_0_0.clone(),
        }
    }
    pub fn method24(v0: string) -> bool {
        let _v3: MutCell<Option<bool>> = MutCell::new(None::<bool>);
        let v5: &str = &*v0;
        let v7: std::string::String = String::from(v5);
        let v9_1: std::path::PathBuf = std::path::PathBuf::from(v7);
        {
            let x: bool = if v9_1.clone().exists() {
                v9_1.is_file()
            } else {
                false
            };
            _v3.set(Some(x))
        }
        match &_v3.get().clone() {
            None => panic!("{}", string("base.run_target / _v3=None"),),
            Some(_v3_0_0) => _v3_0_0.clone(),
        }
    }
    pub fn method25(v0: Vec<u8>) -> Vec<u8> {
        v0
    }
    pub fn method23(v0: string, v1: string) -> bool {
        let _v4: MutCell<Option<bool>> = MutCell::new(None::<bool>);
        {
            let x_4: bool = if File_system::method24(v0.clone()) == false {
                false
            } else {
                let _v9: MutCell<Option<string>> = MutCell::new(None::<string>);
                let _v12: MutCell<Option<Vec<u8>>> = MutCell::new(None::<Vec<u8>>);
                {
                    let x: Vec<u8> = std::fs::read(&*v0).unwrap();
                    _v12.set(Some(x))
                }
                {
                    let v69: Vec<u8> = File_system::method25(match &_v12.get().clone() {
                        None => panic!("{}", string("base.run_target / _v12=None"),),
                        Some(_v12_0_0) => _v12_0_0.clone(),
                    });
                    let v71: Result<std::string::String, std::string::FromUtf8Error> =
                        std::string::String::from_utf8(v69);
                    let v73: std::string::String = v71.unwrap();
                    {
                        let x_2: string = fable_library_rust::String_::fromString(v73);
                        _v9.set(Some(x_2))
                    }
                    v1 == match &_v9.get().clone() {
                        None => panic!("{}", string("base.run_target / _v9=None"),),
                        Some(_v9_0_0) => _v9_0_0.clone(),
                    }
                }
            };
            _v4.set(Some(x_4))
        }
        match &_v4.get().clone() {
            None => panic!("{}", string("base.run_target / _v4=None"),),
            Some(_v4_0_0) => _v4_0_0.clone(),
        }
    }
    pub fn closure14(v0: string, v1: string) -> bool {
        File_system::method23(v0, v1)
    }
    pub fn closure13(unitVar: (), v0: string) -> Func1<string, bool> {
        Func1::new({
            let v0 = v0.clone();
            move |v: string| File_system::closure14(v0.clone(), v)
        })
    }
    pub fn closure16(v0: string, v1: string) -> Arc<Async<()>> {
        let _v4: MutCell<Option<Arc<Async<()>>>> = MutCell::new(None::<Arc<Async<()>>>);
        {
            let x: Arc<Async<()>> = defaultOf();
            _v4.set(Some(x))
        }
        match &_v4.get().clone() {
            None => panic!("{}", string("base.run_target / _v4=None"),),
            Some(_v4_0_0) => _v4_0_0.clone(),
        }
    }
    pub fn closure15(unitVar: (), v0: string) -> Func1<string, Arc<Async<()>>> {
        Func1::new({
            let v0 = v0.clone();
            move |v: string| File_system::closure16(v0.clone(), v)
        })
    }
    pub fn closure18(v0: string, v1: string) -> Arc<Async<()>> {
        let _v4: MutCell<Option<Arc<Async<()>>>> = MutCell::new(None::<Arc<Async<()>>>);
        {
            let x: Arc<Async<()>> = defaultOf();
            _v4.set(Some(x))
        }
        match &_v4.get().clone() {
            None => panic!("{}", string("base.run_target / _v4=None"),),
            Some(_v4_0_0) => _v4_0_0.clone(),
        }
    }
    pub fn closure17(unitVar: (), v0: string) -> Func1<string, Arc<Async<()>>> {
        Func1::new({
            let v0 = v0.clone();
            move |v: string| File_system::closure18(v0.clone(), v)
        })
    }
    pub fn closure20(unitVar: (), unitVar_1: ()) -> string {
        string("delete_file_async")
    }
    pub fn closure21(v0: string, v1: LrcPtr<Exception>, unitVar: ()) -> (string, string) {
        let v2_1: string = File_system::method8(v0);
        let _v5: MutCell<Option<string>> = MutCell::new(None::<string>);
        {
            let x: string = sprintf!("{:?}", v1);
            _v5.set(Some(x))
        }
        (
            v2_1,
            match &_v5.get().clone() {
                None => panic!("{}", string("base.run_target / _v5=None"),),
                Some(_v5_0_0) => _v5_0_0.clone(),
            },
        )
    }
    pub fn method28(v0: LrcPtr<File_system::Mut4>, v1: string, v2_1: string) {
        File_system::method15(v0.clone(), string("{ "));
        File_system::method16(v0.clone());
        File_system::method15(v0.clone(), string("path"));
        File_system::method15(v0.clone(), string(" = "));
        File_system::method15(v0.clone(), v1);
        File_system::method15(v0.clone(), string("; "));
        File_system::method15(v0.clone(), string("ex"));
        File_system::method15(v0.clone(), string(" = "));
        File_system::method15(v0.clone(), v2_1);
        File_system::method15(v0, string(" }"))
    }
    pub fn closure22(
        v0: File_system::US0,
        v1: Func0<string>,
        v2_1: Func0<(string, string)>,
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
                LrcPtr<File_system::Mut3>,
                Option<i64>,
            ) = getValue(File_system::State::trace_state().get().clone());
            let v18_1: Option<i64> = patternInput.4.clone();
            let _v35: MutCell<Option<string>> = MutCell::new(None::<string>);
            let _v38: LrcPtr<MutCell<Option<File_system::US2>>> = refCell(None::<File_system::US2>);
            {
                let x_2: Option<File_system::US2> = match &v18_1 {
                    None => None::<File_system::US2>,
                    Some(v18_1_0_0) => {
                        let x: i64 = v18_1_0_0.clone();
                        Some((Func0::new({
                            let x = x.clone();
                            move || File_system::US2::US2_0(x)
                        }))())
                    }
                };
                _v38.set(x_2)
            }
            {
                let v65: File_system::US2 =
                    defaultValue(File_system::US2::US2_1, _v38.get().clone());
                let v163: DateTime = match &v65 {
                    File_system::US2::US2_0(v65_0_0) => {
                        let v97: TimeSpan = TimeSpan::new_ticks(
                            {
                                let _arg: DateTime = DateTime::now();
                                _arg.ticks()
                            } - match &v65 {
                                File_system::US2::US2_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                        );
                        DateTime::new_ymdhms_milli(
                            1_i32,
                            1_i32,
                            1_i32,
                            v97.hours(),
                            v97.minutes(),
                            v97.seconds(),
                            v97.milliseconds(),
                        )
                    }
                    _ => DateTime::now(),
                };
                {
                    let x_3: string = {
                        let provider: string = File_system::method10();
                        v163.toString(provider)
                    };
                    _v35.set(Some(x_3))
                }
                {
                    let v772: string = match &_v35.get().clone() {
                        None => panic!("{}", string("base.run_target / _v35=None"),),
                        Some(_v35_0_0) => _v35_0_0.clone(),
                    };
                    let v931: File_system::US3 = if if let File_system::US0::US0_0 = &v0 {
                        true
                    } else {
                        false
                    } {
                        File_system::US3::US3_0(string("Verbose"))
                    } else {
                        File_system::US3::US3_1
                    };
                    let v980: File_system::US3 = match &v931 {
                        File_system::US3::US3_0(v931_0_0) => File_system::US3::US3_0(match &v931 {
                            File_system::US3::US3_0(x) => x.clone(),
                            _ => unreachable!(),
                        }),
                        _ => {
                            let v940: File_system::US3 = if if let File_system::US0::US0_1 = &v0 {
                                true
                            } else {
                                false
                            } {
                                File_system::US3::US3_0(string("Debug"))
                            } else {
                                File_system::US3::US3_1
                            };
                            match &v940 {
                                File_system::US3::US3_0(v940_0_0) => {
                                    File_system::US3::US3_0(match &v940 {
                                        File_system::US3::US3_0(x) => x.clone(),
                                        _ => unreachable!(),
                                    })
                                }
                                _ => {
                                    let v949: File_system::US3 =
                                        if if let File_system::US0::US0_2 = &v0 {
                                            true
                                        } else {
                                            false
                                        } {
                                            File_system::US3::US3_0(string("Info"))
                                        } else {
                                            File_system::US3::US3_1
                                        };
                                    match &v949 {
                                        File_system::US3::US3_0(v949_0_0) => {
                                            File_system::US3::US3_0(match &v949 {
                                                File_system::US3::US3_0(x) => x.clone(),
                                                _ => unreachable!(),
                                            })
                                        }
                                        _ => {
                                            let v958: File_system::US3 =
                                                if if let File_system::US0::US0_3 = &v0 {
                                                    true
                                                } else {
                                                    false
                                                } {
                                                    File_system::US3::US3_0(string("Warning"))
                                                } else {
                                                    File_system::US3::US3_1
                                                };
                                            match &v958 {
                                                File_system::US3::US3_0(v958_0_0) => {
                                                    File_system::US3::US3_0(match &v958 {
                                                        File_system::US3::US3_0(x) => x.clone(),
                                                        _ => unreachable!(),
                                                    })
                                                }
                                                _ => {
                                                    let v967: File_system::US3 =
                                                        if if let File_system::US0::US0_4 = &v0 {
                                                            true
                                                        } else {
                                                            false
                                                        } {
                                                            File_system::US3::US3_0(string(
                                                                "Critical",
                                                            ))
                                                        } else {
                                                            File_system::US3::US3_1
                                                        };
                                                    match &v967 {
                                                        File_system::US3::US3_0(v967_0_0) => {
                                                            File_system::US3::US3_0(match &v967 {
                                                                File_system::US3::US3_0(x) => {
                                                                    x.clone()
                                                                }
                                                                _ => unreachable!(),
                                                            })
                                                        }
                                                        _ => File_system::US3::US3_1,
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    };
                    let v997: string = padLeft(
                        toLower(match &v980 {
                            File_system::US3::US3_0(v980_0_0) => match &v980 {
                                File_system::US3::US3_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                            _ => panic!("{}", string("Option does not have a value."),),
                        }),
                        7_i32,
                        ' ',
                    );
                    let _v1029: MutCell<Option<string>> = MutCell::new(None::<string>);
                    let v1044: &str = match &v0 {
                        File_system::US0::US0_1 => inline_colorization::color_bright_blue,
                        File_system::US0::US0_2 => inline_colorization::color_bright_green,
                        File_system::US0::US0_0 => inline_colorization::color_bright_black,
                        File_system::US0::US0_3 => inline_colorization::color_yellow,
                        _ => inline_colorization::color_bright_red,
                    };
                    let v1046: &str = &*v997;
                    let v1048: &str = inline_colorization::color_reset;
                    let v1050: string = string("format!(\"{v1044}{v1046}{v1048}\")");
                    let v1051: std::string::String = format!("{v1044}{v1046}{v1048}");
                    {
                        let x_5: string = fable_library_rust::String_::fromString(v1051);
                        _v1029.set(Some(x_5))
                    }
                    {
                        let v1141: string = match &_v1029.get().clone() {
                            None => panic!("{}", string("base.run_target / _v1029=None"),),
                            Some(_v1029_0_0) => _v1029_0_0.clone(),
                        };
                        let v1160: i64 = (patternInput.0.clone()).l0.get().clone();
                        let patternInput_1: (string, string) = v2_1();
                        let v1164: LrcPtr<File_system::Mut4> = LrcPtr::new(File_system::Mut4 {
                            l0: MutCell::new(string("")),
                        });
                        File_system::method28(
                            v1164.clone(),
                            patternInput_1.0.clone(),
                            patternInput_1.1.clone(),
                        );
                        {
                            let v1165: string = v1164.l0.get().clone();
                            trimEndChars(
                                trimStartChars(
                                    sprintf!("{} {} #{} {} / {}", v772, v1141, v1160, v1(), v1165),
                                    toArray(empty::<char>()),
                                ),
                                toArray(ofArray(new_array(&[' ', '/']))),
                            )
                        }
                    }
                }
            }
        }
    }
    pub fn method27(v0: File_system::US0, v1: Func0<string>, v2_1: Func0<(string, string)>) {
        File_system::method17(
            v0.clone(),
            Func0::new({
                let v0 = v0.clone();
                let v1 = v1.clone();
                let v2_1 = v2_1.clone();
                move || File_system::closure22(v0.clone(), v1.clone(), v2_1.clone(), ())
            }),
        );
    }
    pub fn method26(v0: string, v1: i64) -> Arc<Async<i64>> {
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
    pub fn closure19(unitVar: (), v0: string) -> Arc<Async<i64>> {
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
    pub fn closure25(unitVar: (), unitVar_1: ()) -> string {
        string("move_file_async")
    }
    pub fn closure26(
        v0: string,
        v1: string,
        v2_1: LrcPtr<Exception>,
        unitVar: (),
    ) -> (string, string, LrcPtr<Exception>) {
        (File_system::method8(v1), File_system::method8(v0), v2_1)
    }
    pub fn method32(v0: LrcPtr<File_system::Mut4>, v1: LrcPtr<Exception>) {
        File_system::method15(v0, sprintf!("{:?}", v1));
    }
    pub fn method31(
        v0: LrcPtr<File_system::Mut4>,
        v1: string,
        v2_1: string,
        v3_1: LrcPtr<Exception>,
    ) {
        File_system::method15(v0.clone(), string("{ "));
        File_system::method16(v0.clone());
        File_system::method15(v0.clone(), string("old_path"));
        File_system::method15(v0.clone(), string(" = "));
        File_system::method15(v0.clone(), v1);
        File_system::method15(v0.clone(), string("; "));
        File_system::method15(v0.clone(), string("new_path"));
        File_system::method15(v0.clone(), string(" = "));
        File_system::method15(v0.clone(), v2_1);
        File_system::method15(v0.clone(), string("; "));
        File_system::method15(v0.clone(), string("ex"));
        File_system::method15(v0.clone(), string(" = "));
        File_system::method32(v0.clone(), v3_1);
        File_system::method15(v0, string(" }"))
    }
    pub fn closure27(
        v0: File_system::US0,
        v1: Func0<string>,
        v2_1: Func0<(string, string, LrcPtr<Exception>)>,
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
                LrcPtr<File_system::Mut3>,
                Option<i64>,
            ) = getValue(File_system::State::trace_state().get().clone());
            let v18_1: Option<i64> = patternInput.4.clone();
            let _v35: MutCell<Option<string>> = MutCell::new(None::<string>);
            let _v38: LrcPtr<MutCell<Option<File_system::US2>>> = refCell(None::<File_system::US2>);
            {
                let x_2: Option<File_system::US2> = match &v18_1 {
                    None => None::<File_system::US2>,
                    Some(v18_1_0_0) => {
                        let x: i64 = v18_1_0_0.clone();
                        Some((Func0::new({
                            let x = x.clone();
                            move || File_system::US2::US2_0(x)
                        }))())
                    }
                };
                _v38.set(x_2)
            }
            {
                let v65: File_system::US2 =
                    defaultValue(File_system::US2::US2_1, _v38.get().clone());
                let v163: DateTime = match &v65 {
                    File_system::US2::US2_0(v65_0_0) => {
                        let v97: TimeSpan = TimeSpan::new_ticks(
                            {
                                let _arg: DateTime = DateTime::now();
                                _arg.ticks()
                            } - match &v65 {
                                File_system::US2::US2_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                        );
                        DateTime::new_ymdhms_milli(
                            1_i32,
                            1_i32,
                            1_i32,
                            v97.hours(),
                            v97.minutes(),
                            v97.seconds(),
                            v97.milliseconds(),
                        )
                    }
                    _ => DateTime::now(),
                };
                {
                    let x_3: string = {
                        let provider: string = File_system::method10();
                        v163.toString(provider)
                    };
                    _v35.set(Some(x_3))
                }
                {
                    let v772: string = match &_v35.get().clone() {
                        None => panic!("{}", string("base.run_target / _v35=None"),),
                        Some(_v35_0_0) => _v35_0_0.clone(),
                    };
                    let v931: File_system::US3 = if if let File_system::US0::US0_0 = &v0 {
                        true
                    } else {
                        false
                    } {
                        File_system::US3::US3_0(string("Verbose"))
                    } else {
                        File_system::US3::US3_1
                    };
                    let v980: File_system::US3 = match &v931 {
                        File_system::US3::US3_0(v931_0_0) => File_system::US3::US3_0(match &v931 {
                            File_system::US3::US3_0(x) => x.clone(),
                            _ => unreachable!(),
                        }),
                        _ => {
                            let v940: File_system::US3 = if if let File_system::US0::US0_1 = &v0 {
                                true
                            } else {
                                false
                            } {
                                File_system::US3::US3_0(string("Debug"))
                            } else {
                                File_system::US3::US3_1
                            };
                            match &v940 {
                                File_system::US3::US3_0(v940_0_0) => {
                                    File_system::US3::US3_0(match &v940 {
                                        File_system::US3::US3_0(x) => x.clone(),
                                        _ => unreachable!(),
                                    })
                                }
                                _ => {
                                    let v949: File_system::US3 =
                                        if if let File_system::US0::US0_2 = &v0 {
                                            true
                                        } else {
                                            false
                                        } {
                                            File_system::US3::US3_0(string("Info"))
                                        } else {
                                            File_system::US3::US3_1
                                        };
                                    match &v949 {
                                        File_system::US3::US3_0(v949_0_0) => {
                                            File_system::US3::US3_0(match &v949 {
                                                File_system::US3::US3_0(x) => x.clone(),
                                                _ => unreachable!(),
                                            })
                                        }
                                        _ => {
                                            let v958: File_system::US3 =
                                                if if let File_system::US0::US0_3 = &v0 {
                                                    true
                                                } else {
                                                    false
                                                } {
                                                    File_system::US3::US3_0(string("Warning"))
                                                } else {
                                                    File_system::US3::US3_1
                                                };
                                            match &v958 {
                                                File_system::US3::US3_0(v958_0_0) => {
                                                    File_system::US3::US3_0(match &v958 {
                                                        File_system::US3::US3_0(x) => x.clone(),
                                                        _ => unreachable!(),
                                                    })
                                                }
                                                _ => {
                                                    let v967: File_system::US3 =
                                                        if if let File_system::US0::US0_4 = &v0 {
                                                            true
                                                        } else {
                                                            false
                                                        } {
                                                            File_system::US3::US3_0(string(
                                                                "Critical",
                                                            ))
                                                        } else {
                                                            File_system::US3::US3_1
                                                        };
                                                    match &v967 {
                                                        File_system::US3::US3_0(v967_0_0) => {
                                                            File_system::US3::US3_0(match &v967 {
                                                                File_system::US3::US3_0(x) => {
                                                                    x.clone()
                                                                }
                                                                _ => unreachable!(),
                                                            })
                                                        }
                                                        _ => File_system::US3::US3_1,
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    };
                    let v997: string = padLeft(
                        toLower(match &v980 {
                            File_system::US3::US3_0(v980_0_0) => match &v980 {
                                File_system::US3::US3_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                            _ => panic!("{}", string("Option does not have a value."),),
                        }),
                        7_i32,
                        ' ',
                    );
                    let _v1029: MutCell<Option<string>> = MutCell::new(None::<string>);
                    let v1044: &str = match &v0 {
                        File_system::US0::US0_1 => inline_colorization::color_bright_blue,
                        File_system::US0::US0_2 => inline_colorization::color_bright_green,
                        File_system::US0::US0_0 => inline_colorization::color_bright_black,
                        File_system::US0::US0_3 => inline_colorization::color_yellow,
                        _ => inline_colorization::color_bright_red,
                    };
                    let v1046: &str = &*v997;
                    let v1048: &str = inline_colorization::color_reset;
                    let v1050: string = string("format!(\"{v1044}{v1046}{v1048}\")");
                    let v1051: std::string::String = format!("{v1044}{v1046}{v1048}");
                    {
                        let x_5: string = fable_library_rust::String_::fromString(v1051);
                        _v1029.set(Some(x_5))
                    }
                    {
                        let v1141: string = match &_v1029.get().clone() {
                            None => panic!("{}", string("base.run_target / _v1029=None"),),
                            Some(_v1029_0_0) => _v1029_0_0.clone(),
                        };
                        let v1160: i64 = (patternInput.0.clone()).l0.get().clone();
                        let patternInput_1: (string, string, LrcPtr<Exception>) = v2_1();
                        let v1165: LrcPtr<File_system::Mut4> = LrcPtr::new(File_system::Mut4 {
                            l0: MutCell::new(string("")),
                        });
                        File_system::method31(
                            v1165.clone(),
                            patternInput_1.0.clone(),
                            patternInput_1.1.clone(),
                            patternInput_1.2.clone(),
                        );
                        {
                            let v1166: string = v1165.l0.get().clone();
                            trimEndChars(
                                trimStartChars(
                                    sprintf!("{} {} #{} {} / {}", v772, v1141, v1160, v1(), v1166),
                                    toArray(empty::<char>()),
                                ),
                                toArray(ofArray(new_array(&[' ', '/']))),
                            )
                        }
                    }
                }
            }
        }
    }
    pub fn method30(
        v0: File_system::US0,
        v1: Func0<string>,
        v2_1: Func0<(string, string, LrcPtr<Exception>)>,
    ) {
        File_system::method17(
            v0.clone(),
            Func0::new({
                let v0 = v0.clone();
                let v1 = v1.clone();
                let v2_1 = v2_1.clone();
                move || File_system::closure27(v0.clone(), v1.clone(), v2_1.clone(), ())
            }),
        );
    }
    pub fn method29(v0: string, v1: string, v2_1: i64) -> Arc<Async<i64>> {
        let _v5: MutCell<Option<Arc<Async<i64>>>> = MutCell::new(None::<Arc<Async<i64>>>);
        {
            let x: Arc<Async<i64>> = defaultOf();
            _v5.set(Some(x))
        }
        match &_v5.get().clone() {
            None => panic!("{}", string("base.run_target / _v5=None"),),
            Some(_v5_0_0) => _v5_0_0.clone(),
        }
    }
    pub fn closure24(v0: string, v1: string) -> Arc<Async<i64>> {
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
    pub fn closure23(unitVar: (), v0: string) -> Func1<string, Arc<Async<i64>>> {
        Func1::new({
            let v0 = v0.clone();
            move |v: string| File_system::closure24(v0.clone(), v)
        })
    }
    pub fn closure29(unitVar: (), v0: i64) -> File_system::US9 {
        File_system::US9::US9_0(v0)
    }
    pub fn closure30(unitVar: (), v0: LrcPtr<Exception>) -> File_system::US9 {
        File_system::US9::US9_1(v0)
    }
    pub fn closure31(unitVar: (), unitVar_1: ()) -> string {
        string("async.run_with_timeout_async")
    }
    pub fn closure32(unitVar: (), unitVar_1: ()) -> i32 {
        1000_i32
    }
    pub fn method36(v0: LrcPtr<File_system::Mut4>, v1: i32) {
        let v4: string = sprintf!("{}", v1);
        let v12_1: string = append(v0.l0.get().clone(), v4);
        v0.l0.set(v12_1);
        ()
    }
    pub fn method35(v0: LrcPtr<File_system::Mut4>, v1: i32) {
        File_system::method15(v0.clone(), string("{ "));
        File_system::method16(v0.clone());
        File_system::method15(v0.clone(), string("timeout"));
        File_system::method15(v0.clone(), string(" = "));
        File_system::method36(v0.clone(), v1);
        File_system::method15(v0, string(" }"))
    }
    pub fn closure33(
        v0: File_system::US0,
        v1: Func0<string>,
        v2_1: Func0<i32>,
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
                LrcPtr<File_system::Mut3>,
                Option<i64>,
            ) = getValue(File_system::State::trace_state().get().clone());
            let v18_1: Option<i64> = patternInput.4.clone();
            let _v35: MutCell<Option<string>> = MutCell::new(None::<string>);
            let _v38: LrcPtr<MutCell<Option<File_system::US2>>> = refCell(None::<File_system::US2>);
            {
                let x_2: Option<File_system::US2> = match &v18_1 {
                    None => None::<File_system::US2>,
                    Some(v18_1_0_0) => {
                        let x: i64 = v18_1_0_0.clone();
                        Some((Func0::new({
                            let x = x.clone();
                            move || File_system::US2::US2_0(x)
                        }))())
                    }
                };
                _v38.set(x_2)
            }
            {
                let v65: File_system::US2 =
                    defaultValue(File_system::US2::US2_1, _v38.get().clone());
                let v163: DateTime = match &v65 {
                    File_system::US2::US2_0(v65_0_0) => {
                        let v97: TimeSpan = TimeSpan::new_ticks(
                            {
                                let _arg: DateTime = DateTime::now();
                                _arg.ticks()
                            } - match &v65 {
                                File_system::US2::US2_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                        );
                        DateTime::new_ymdhms_milli(
                            1_i32,
                            1_i32,
                            1_i32,
                            v97.hours(),
                            v97.minutes(),
                            v97.seconds(),
                            v97.milliseconds(),
                        )
                    }
                    _ => DateTime::now(),
                };
                {
                    let x_3: string = {
                        let provider: string = File_system::method10();
                        v163.toString(provider)
                    };
                    _v35.set(Some(x_3))
                }
                {
                    let v772: string = match &_v35.get().clone() {
                        None => panic!("{}", string("base.run_target / _v35=None"),),
                        Some(_v35_0_0) => _v35_0_0.clone(),
                    };
                    let v931: File_system::US3 = if if let File_system::US0::US0_0 = &v0 {
                        true
                    } else {
                        false
                    } {
                        File_system::US3::US3_0(string("Verbose"))
                    } else {
                        File_system::US3::US3_1
                    };
                    let v980: File_system::US3 = match &v931 {
                        File_system::US3::US3_0(v931_0_0) => File_system::US3::US3_0(match &v931 {
                            File_system::US3::US3_0(x) => x.clone(),
                            _ => unreachable!(),
                        }),
                        _ => {
                            let v940: File_system::US3 = if if let File_system::US0::US0_1 = &v0 {
                                true
                            } else {
                                false
                            } {
                                File_system::US3::US3_0(string("Debug"))
                            } else {
                                File_system::US3::US3_1
                            };
                            match &v940 {
                                File_system::US3::US3_0(v940_0_0) => {
                                    File_system::US3::US3_0(match &v940 {
                                        File_system::US3::US3_0(x) => x.clone(),
                                        _ => unreachable!(),
                                    })
                                }
                                _ => {
                                    let v949: File_system::US3 =
                                        if if let File_system::US0::US0_2 = &v0 {
                                            true
                                        } else {
                                            false
                                        } {
                                            File_system::US3::US3_0(string("Info"))
                                        } else {
                                            File_system::US3::US3_1
                                        };
                                    match &v949 {
                                        File_system::US3::US3_0(v949_0_0) => {
                                            File_system::US3::US3_0(match &v949 {
                                                File_system::US3::US3_0(x) => x.clone(),
                                                _ => unreachable!(),
                                            })
                                        }
                                        _ => {
                                            let v958: File_system::US3 =
                                                if if let File_system::US0::US0_3 = &v0 {
                                                    true
                                                } else {
                                                    false
                                                } {
                                                    File_system::US3::US3_0(string("Warning"))
                                                } else {
                                                    File_system::US3::US3_1
                                                };
                                            match &v958 {
                                                File_system::US3::US3_0(v958_0_0) => {
                                                    File_system::US3::US3_0(match &v958 {
                                                        File_system::US3::US3_0(x) => x.clone(),
                                                        _ => unreachable!(),
                                                    })
                                                }
                                                _ => {
                                                    let v967: File_system::US3 =
                                                        if if let File_system::US0::US0_4 = &v0 {
                                                            true
                                                        } else {
                                                            false
                                                        } {
                                                            File_system::US3::US3_0(string(
                                                                "Critical",
                                                            ))
                                                        } else {
                                                            File_system::US3::US3_1
                                                        };
                                                    match &v967 {
                                                        File_system::US3::US3_0(v967_0_0) => {
                                                            File_system::US3::US3_0(match &v967 {
                                                                File_system::US3::US3_0(x) => {
                                                                    x.clone()
                                                                }
                                                                _ => unreachable!(),
                                                            })
                                                        }
                                                        _ => File_system::US3::US3_1,
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    };
                    let v997: string = padLeft(
                        toLower(match &v980 {
                            File_system::US3::US3_0(v980_0_0) => match &v980 {
                                File_system::US3::US3_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                            _ => panic!("{}", string("Option does not have a value."),),
                        }),
                        7_i32,
                        ' ',
                    );
                    let _v1029: MutCell<Option<string>> = MutCell::new(None::<string>);
                    let v1044: &str = match &v0 {
                        File_system::US0::US0_1 => inline_colorization::color_bright_blue,
                        File_system::US0::US0_2 => inline_colorization::color_bright_green,
                        File_system::US0::US0_0 => inline_colorization::color_bright_black,
                        File_system::US0::US0_3 => inline_colorization::color_yellow,
                        _ => inline_colorization::color_bright_red,
                    };
                    let v1046: &str = &*v997;
                    let v1048: &str = inline_colorization::color_reset;
                    let v1050: string = string("format!(\"{v1044}{v1046}{v1048}\")");
                    let v1051: std::string::String = format!("{v1044}{v1046}{v1048}");
                    {
                        let x_5: string = fable_library_rust::String_::fromString(v1051);
                        _v1029.set(Some(x_5))
                    }
                    {
                        let v1141: string = match &_v1029.get().clone() {
                            None => panic!("{}", string("base.run_target / _v1029=None"),),
                            Some(_v1029_0_0) => _v1029_0_0.clone(),
                        };
                        let v1160: i64 = (patternInput.0.clone()).l0.get().clone();
                        let v1163: LrcPtr<File_system::Mut4> = LrcPtr::new(File_system::Mut4 {
                            l0: MutCell::new(string("")),
                        });
                        File_system::method35(v1163.clone(), v2_1());
                        {
                            let v1164: string = v1163.l0.get().clone();
                            trimEndChars(
                                trimStartChars(
                                    sprintf!("{} {} #{} {} / {}", v772, v1141, v1160, v1(), v1164),
                                    toArray(empty::<char>()),
                                ),
                                toArray(ofArray(new_array(&[' ', '/']))),
                            )
                        }
                    }
                }
            }
        }
    }
    pub fn method34(v0: File_system::US0, v1: Func0<string>, v2_1: Func0<i32>) {
        File_system::method17(
            v0.clone(),
            Func0::new({
                let v0 = v0.clone();
                let v1 = v1.clone();
                let v2_1 = v2_1.clone();
                move || File_system::closure33(v0.clone(), v1.clone(), v2_1.clone(), ())
            }),
        );
    }
    pub fn closure34(unitVar: (), unitVar_1: ()) -> string {
        string("async.run_with_timeout_async**")
    }
    pub fn closure35(v0: LrcPtr<Exception>, unitVar: ()) -> (i32, string) {
        let _v3: MutCell<Option<string>> = MutCell::new(None::<string>);
        {
            let x: string = sprintf!("{:?}", v0);
            _v3.set(Some(x))
        }
        (
            1000_i32,
            match &_v3.get().clone() {
                None => panic!("{}", string("base.run_target / _v3=None"),),
                Some(_v3_0_0) => _v3_0_0.clone(),
            },
        )
    }
    pub fn method38(v0: LrcPtr<File_system::Mut4>, v1: i32, v2_1: string) {
        File_system::method15(v0.clone(), string("{ "));
        File_system::method16(v0.clone());
        File_system::method15(v0.clone(), string("timeout"));
        File_system::method15(v0.clone(), string(" = "));
        File_system::method36(v0.clone(), v1);
        File_system::method15(v0.clone(), string("; "));
        File_system::method15(v0.clone(), string("ex"));
        File_system::method15(v0.clone(), string(" = "));
        File_system::method15(v0.clone(), v2_1);
        File_system::method15(v0, string(" }"))
    }
    pub fn closure36(
        v0: File_system::US0,
        v1: Func0<string>,
        v2_1: Func0<(i32, string)>,
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
                LrcPtr<File_system::Mut3>,
                Option<i64>,
            ) = getValue(File_system::State::trace_state().get().clone());
            let v18_1: Option<i64> = patternInput.4.clone();
            let _v35: MutCell<Option<string>> = MutCell::new(None::<string>);
            let _v38: LrcPtr<MutCell<Option<File_system::US2>>> = refCell(None::<File_system::US2>);
            {
                let x_2: Option<File_system::US2> = match &v18_1 {
                    None => None::<File_system::US2>,
                    Some(v18_1_0_0) => {
                        let x: i64 = v18_1_0_0.clone();
                        Some((Func0::new({
                            let x = x.clone();
                            move || File_system::US2::US2_0(x)
                        }))())
                    }
                };
                _v38.set(x_2)
            }
            {
                let v65: File_system::US2 =
                    defaultValue(File_system::US2::US2_1, _v38.get().clone());
                let v163: DateTime = match &v65 {
                    File_system::US2::US2_0(v65_0_0) => {
                        let v97: TimeSpan = TimeSpan::new_ticks(
                            {
                                let _arg: DateTime = DateTime::now();
                                _arg.ticks()
                            } - match &v65 {
                                File_system::US2::US2_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                        );
                        DateTime::new_ymdhms_milli(
                            1_i32,
                            1_i32,
                            1_i32,
                            v97.hours(),
                            v97.minutes(),
                            v97.seconds(),
                            v97.milliseconds(),
                        )
                    }
                    _ => DateTime::now(),
                };
                {
                    let x_3: string = {
                        let provider: string = File_system::method10();
                        v163.toString(provider)
                    };
                    _v35.set(Some(x_3))
                }
                {
                    let v772: string = match &_v35.get().clone() {
                        None => panic!("{}", string("base.run_target / _v35=None"),),
                        Some(_v35_0_0) => _v35_0_0.clone(),
                    };
                    let v931: File_system::US3 = if if let File_system::US0::US0_0 = &v0 {
                        true
                    } else {
                        false
                    } {
                        File_system::US3::US3_0(string("Verbose"))
                    } else {
                        File_system::US3::US3_1
                    };
                    let v980: File_system::US3 = match &v931 {
                        File_system::US3::US3_0(v931_0_0) => File_system::US3::US3_0(match &v931 {
                            File_system::US3::US3_0(x) => x.clone(),
                            _ => unreachable!(),
                        }),
                        _ => {
                            let v940: File_system::US3 = if if let File_system::US0::US0_1 = &v0 {
                                true
                            } else {
                                false
                            } {
                                File_system::US3::US3_0(string("Debug"))
                            } else {
                                File_system::US3::US3_1
                            };
                            match &v940 {
                                File_system::US3::US3_0(v940_0_0) => {
                                    File_system::US3::US3_0(match &v940 {
                                        File_system::US3::US3_0(x) => x.clone(),
                                        _ => unreachable!(),
                                    })
                                }
                                _ => {
                                    let v949: File_system::US3 =
                                        if if let File_system::US0::US0_2 = &v0 {
                                            true
                                        } else {
                                            false
                                        } {
                                            File_system::US3::US3_0(string("Info"))
                                        } else {
                                            File_system::US3::US3_1
                                        };
                                    match &v949 {
                                        File_system::US3::US3_0(v949_0_0) => {
                                            File_system::US3::US3_0(match &v949 {
                                                File_system::US3::US3_0(x) => x.clone(),
                                                _ => unreachable!(),
                                            })
                                        }
                                        _ => {
                                            let v958: File_system::US3 =
                                                if if let File_system::US0::US0_3 = &v0 {
                                                    true
                                                } else {
                                                    false
                                                } {
                                                    File_system::US3::US3_0(string("Warning"))
                                                } else {
                                                    File_system::US3::US3_1
                                                };
                                            match &v958 {
                                                File_system::US3::US3_0(v958_0_0) => {
                                                    File_system::US3::US3_0(match &v958 {
                                                        File_system::US3::US3_0(x) => x.clone(),
                                                        _ => unreachable!(),
                                                    })
                                                }
                                                _ => {
                                                    let v967: File_system::US3 =
                                                        if if let File_system::US0::US0_4 = &v0 {
                                                            true
                                                        } else {
                                                            false
                                                        } {
                                                            File_system::US3::US3_0(string(
                                                                "Critical",
                                                            ))
                                                        } else {
                                                            File_system::US3::US3_1
                                                        };
                                                    match &v967 {
                                                        File_system::US3::US3_0(v967_0_0) => {
                                                            File_system::US3::US3_0(match &v967 {
                                                                File_system::US3::US3_0(x) => {
                                                                    x.clone()
                                                                }
                                                                _ => unreachable!(),
                                                            })
                                                        }
                                                        _ => File_system::US3::US3_1,
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    };
                    let v997: string = padLeft(
                        toLower(match &v980 {
                            File_system::US3::US3_0(v980_0_0) => match &v980 {
                                File_system::US3::US3_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                            _ => panic!("{}", string("Option does not have a value."),),
                        }),
                        7_i32,
                        ' ',
                    );
                    let _v1029: MutCell<Option<string>> = MutCell::new(None::<string>);
                    let v1044: &str = match &v0 {
                        File_system::US0::US0_1 => inline_colorization::color_bright_blue,
                        File_system::US0::US0_2 => inline_colorization::color_bright_green,
                        File_system::US0::US0_0 => inline_colorization::color_bright_black,
                        File_system::US0::US0_3 => inline_colorization::color_yellow,
                        _ => inline_colorization::color_bright_red,
                    };
                    let v1046: &str = &*v997;
                    let v1048: &str = inline_colorization::color_reset;
                    let v1050: string = string("format!(\"{v1044}{v1046}{v1048}\")");
                    let v1051: std::string::String = format!("{v1044}{v1046}{v1048}");
                    {
                        let x_5: string = fable_library_rust::String_::fromString(v1051);
                        _v1029.set(Some(x_5))
                    }
                    {
                        let v1141: string = match &_v1029.get().clone() {
                            None => panic!("{}", string("base.run_target / _v1029=None"),),
                            Some(_v1029_0_0) => _v1029_0_0.clone(),
                        };
                        let v1160: i64 = (patternInput.0.clone()).l0.get().clone();
                        let patternInput_1: (i32, string) = v2_1();
                        let v1164: LrcPtr<File_system::Mut4> = LrcPtr::new(File_system::Mut4 {
                            l0: MutCell::new(string("")),
                        });
                        File_system::method38(
                            v1164.clone(),
                            patternInput_1.0.clone(),
                            patternInput_1.1.clone(),
                        );
                        {
                            let v1165: string = v1164.l0.get().clone();
                            trimEndChars(
                                trimStartChars(
                                    sprintf!("{} {} #{} {} / {}", v772, v1141, v1160, v1(), v1165),
                                    toArray(empty::<char>()),
                                ),
                                toArray(ofArray(new_array(&[' ', '/']))),
                            )
                        }
                    }
                }
            }
        }
    }
    pub fn method37(v0: File_system::US0, v1: Func0<string>, v2_1: Func0<(i32, string)>) {
        File_system::method17(
            v0.clone(),
            Func0::new({
                let v0 = v0.clone();
                let v1 = v1.clone();
                let v2_1 = v2_1.clone();
                move || File_system::closure36(v0.clone(), v1.clone(), v2_1.clone(), ())
            }),
        );
    }
    pub fn closure37(unitVar: (), unitVar_1: ()) -> string {
        string("read_all_text_retry_async")
    }
    pub fn closure38(v0: i64, v1: string, unitVar: ()) -> (i64, string) {
        (v0, v1)
    }
    pub fn method40(v0: LrcPtr<File_system::Mut4>, v1: i64, v2_1: string) {
        File_system::method15(v0.clone(), string("{ "));
        File_system::method16(v0.clone());
        File_system::method15(v0.clone(), string("retry"));
        File_system::method15(v0.clone(), string(" = "));
        File_system::method21(v0.clone(), v1);
        File_system::method15(v0.clone(), string("; "));
        File_system::method15(v0.clone(), string("ex"));
        File_system::method15(v0.clone(), string(" = "));
        File_system::method15(v0.clone(), v2_1);
        File_system::method15(v0, string(" }"))
    }
    pub fn closure39(
        v0: File_system::US0,
        v1: Func0<string>,
        v2_1: Func0<(i64, string)>,
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
                LrcPtr<File_system::Mut3>,
                Option<i64>,
            ) = getValue(File_system::State::trace_state().get().clone());
            let v18_1: Option<i64> = patternInput.4.clone();
            let _v35: MutCell<Option<string>> = MutCell::new(None::<string>);
            let _v38: LrcPtr<MutCell<Option<File_system::US2>>> = refCell(None::<File_system::US2>);
            {
                let x_2: Option<File_system::US2> = match &v18_1 {
                    None => None::<File_system::US2>,
                    Some(v18_1_0_0) => {
                        let x: i64 = v18_1_0_0.clone();
                        Some((Func0::new({
                            let x = x.clone();
                            move || File_system::US2::US2_0(x)
                        }))())
                    }
                };
                _v38.set(x_2)
            }
            {
                let v65: File_system::US2 =
                    defaultValue(File_system::US2::US2_1, _v38.get().clone());
                let v163: DateTime = match &v65 {
                    File_system::US2::US2_0(v65_0_0) => {
                        let v97: TimeSpan = TimeSpan::new_ticks(
                            {
                                let _arg: DateTime = DateTime::now();
                                _arg.ticks()
                            } - match &v65 {
                                File_system::US2::US2_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                        );
                        DateTime::new_ymdhms_milli(
                            1_i32,
                            1_i32,
                            1_i32,
                            v97.hours(),
                            v97.minutes(),
                            v97.seconds(),
                            v97.milliseconds(),
                        )
                    }
                    _ => DateTime::now(),
                };
                {
                    let x_3: string = {
                        let provider: string = File_system::method10();
                        v163.toString(provider)
                    };
                    _v35.set(Some(x_3))
                }
                {
                    let v772: string = match &_v35.get().clone() {
                        None => panic!("{}", string("base.run_target / _v35=None"),),
                        Some(_v35_0_0) => _v35_0_0.clone(),
                    };
                    let v931: File_system::US3 = if if let File_system::US0::US0_0 = &v0 {
                        true
                    } else {
                        false
                    } {
                        File_system::US3::US3_0(string("Verbose"))
                    } else {
                        File_system::US3::US3_1
                    };
                    let v980: File_system::US3 = match &v931 {
                        File_system::US3::US3_0(v931_0_0) => File_system::US3::US3_0(match &v931 {
                            File_system::US3::US3_0(x) => x.clone(),
                            _ => unreachable!(),
                        }),
                        _ => {
                            let v940: File_system::US3 = if if let File_system::US0::US0_1 = &v0 {
                                true
                            } else {
                                false
                            } {
                                File_system::US3::US3_0(string("Debug"))
                            } else {
                                File_system::US3::US3_1
                            };
                            match &v940 {
                                File_system::US3::US3_0(v940_0_0) => {
                                    File_system::US3::US3_0(match &v940 {
                                        File_system::US3::US3_0(x) => x.clone(),
                                        _ => unreachable!(),
                                    })
                                }
                                _ => {
                                    let v949: File_system::US3 =
                                        if if let File_system::US0::US0_2 = &v0 {
                                            true
                                        } else {
                                            false
                                        } {
                                            File_system::US3::US3_0(string("Info"))
                                        } else {
                                            File_system::US3::US3_1
                                        };
                                    match &v949 {
                                        File_system::US3::US3_0(v949_0_0) => {
                                            File_system::US3::US3_0(match &v949 {
                                                File_system::US3::US3_0(x) => x.clone(),
                                                _ => unreachable!(),
                                            })
                                        }
                                        _ => {
                                            let v958: File_system::US3 =
                                                if if let File_system::US0::US0_3 = &v0 {
                                                    true
                                                } else {
                                                    false
                                                } {
                                                    File_system::US3::US3_0(string("Warning"))
                                                } else {
                                                    File_system::US3::US3_1
                                                };
                                            match &v958 {
                                                File_system::US3::US3_0(v958_0_0) => {
                                                    File_system::US3::US3_0(match &v958 {
                                                        File_system::US3::US3_0(x) => x.clone(),
                                                        _ => unreachable!(),
                                                    })
                                                }
                                                _ => {
                                                    let v967: File_system::US3 =
                                                        if if let File_system::US0::US0_4 = &v0 {
                                                            true
                                                        } else {
                                                            false
                                                        } {
                                                            File_system::US3::US3_0(string(
                                                                "Critical",
                                                            ))
                                                        } else {
                                                            File_system::US3::US3_1
                                                        };
                                                    match &v967 {
                                                        File_system::US3::US3_0(v967_0_0) => {
                                                            File_system::US3::US3_0(match &v967 {
                                                                File_system::US3::US3_0(x) => {
                                                                    x.clone()
                                                                }
                                                                _ => unreachable!(),
                                                            })
                                                        }
                                                        _ => File_system::US3::US3_1,
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    };
                    let v997: string = padLeft(
                        toLower(match &v980 {
                            File_system::US3::US3_0(v980_0_0) => match &v980 {
                                File_system::US3::US3_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                            _ => panic!("{}", string("Option does not have a value."),),
                        }),
                        7_i32,
                        ' ',
                    );
                    let _v1029: MutCell<Option<string>> = MutCell::new(None::<string>);
                    let v1044: &str = match &v0 {
                        File_system::US0::US0_1 => inline_colorization::color_bright_blue,
                        File_system::US0::US0_2 => inline_colorization::color_bright_green,
                        File_system::US0::US0_0 => inline_colorization::color_bright_black,
                        File_system::US0::US0_3 => inline_colorization::color_yellow,
                        _ => inline_colorization::color_bright_red,
                    };
                    let v1046: &str = &*v997;
                    let v1048: &str = inline_colorization::color_reset;
                    let v1050: string = string("format!(\"{v1044}{v1046}{v1048}\")");
                    let v1051: std::string::String = format!("{v1044}{v1046}{v1048}");
                    {
                        let x_5: string = fable_library_rust::String_::fromString(v1051);
                        _v1029.set(Some(x_5))
                    }
                    {
                        let v1141: string = match &_v1029.get().clone() {
                            None => panic!("{}", string("base.run_target / _v1029=None"),),
                            Some(_v1029_0_0) => _v1029_0_0.clone(),
                        };
                        let v1160: i64 = (patternInput.0.clone()).l0.get().clone();
                        let patternInput_1: (i64, string) = v2_1();
                        let v1164: LrcPtr<File_system::Mut4> = LrcPtr::new(File_system::Mut4 {
                            l0: MutCell::new(string("")),
                        });
                        File_system::method40(
                            v1164.clone(),
                            patternInput_1.0.clone(),
                            patternInput_1.1.clone(),
                        );
                        {
                            let v1165: string = v1164.l0.get().clone();
                            trimEndChars(
                                trimStartChars(
                                    sprintf!("{} {} #{} {} / {}", v772, v1141, v1160, v1(), v1165),
                                    toArray(empty::<char>()),
                                ),
                                toArray(ofArray(new_array(&[' ', '/']))),
                            )
                        }
                    }
                }
            }
        }
    }
    pub fn method39(v0: File_system::US0, v1: Func0<string>, v2_1: Func0<(i64, string)>) {
        File_system::method17(
            v0.clone(),
            Func0::new({
                let v0 = v0.clone();
                let v1 = v1.clone();
                let v2_1 = v2_1.clone();
                move || File_system::closure39(v0.clone(), v1.clone(), v2_1.clone(), ())
            }),
        );
    }
    pub fn method33(v0: string, v1: i64) -> Arc<Async<Option<string>>> {
        let _v4: MutCell<Option<Arc<Async<Option<string>>>>> =
            MutCell::new(None::<Arc<Async<Option<string>>>>);
        {
            let x: Arc<Async<Option<string>>> = defaultOf();
            _v4.set(Some(x))
        }
        match &_v4.get().clone() {
            None => panic!("{}", string("base.run_target / _v4=None"),),
            Some(_v4_0_0) => _v4_0_0.clone(),
        }
    }
    pub fn closure28(unitVar: (), v0: string) -> Arc<Async<Option<string>>> {
        let _v3: MutCell<Option<Arc<Async<Option<string>>>>> =
            MutCell::new(None::<Arc<Async<Option<string>>>>);
        {
            let x: Arc<Async<Option<string>>> = defaultOf();
            _v3.set(Some(x))
        }
        match &_v3.get().clone() {
            None => panic!("{}", string("base.run_target / _v3=None"),),
            Some(_v3_0_0) => _v3_0_0.clone(),
        }
    }
    pub fn method43() -> string {
        string("hh:mm")
    }
    pub fn method44() -> string {
        string("yyyyMMdd-HHmm-ssff-ffff-f")
    }
    pub fn method45() -> string {
        string("hhmm")
    }
    pub fn method42(v0: Guid, v1: DateTime) -> Guid {
        let _v4: MutCell<Option<Guid>> = MutCell::new(None::<Guid>);
        let v17_1: DateTime = {
            let _arg: DateTime =
                DateTime::new_ymdhms_kind(1970_i32, 1_i32, 1_i32, 0_i32, 0_i32, 0_i32, 1_i32);
            _arg.toUniversalTime()
        };
        let v57: i64 = ({
            let _arg_2: DateTime = {
                let _arg_1: DateTime = DateTime::specifyKind(v1, 2_i32);
                _arg_1.toUniversalTime()
            };
            _arg_2.ticks()
        } - v17_1.ticks())
            / 10_i64;
        let v59: Option<chrono::DateTime<chrono::Utc>> =
            chrono::DateTime::from_timestamp_micros(v57);
        let _v62: LrcPtr<MutCell<Option<File_system::US11>>> = refCell(None::<File_system::US11>);
        {
            let x_2: Option<File_system::US11> = match &v59 {
                None => None::<File_system::US11>,
                Some(v59_0_0) => {
                    let x: chrono::DateTime<chrono::Utc> = v59_0_0.clone();
                    Some((Func0::new({
                        let x = x.clone();
                        move || File_system::US11::US11_0(x.clone())
                    }))())
                }
            };
            _v62.set(x_2)
        }
        {
            let v89: File_system::US11 =
                defaultValue(File_system::US11::US11_1, _v62.get().clone());
            let v113: File_system::US3 = match &v89 {
                File_system::US11::US11_0(v89_0_0) => {
                    let v99: chrono::NaiveDateTime = match &v89 {
                        File_system::US11::US11_0(x) => x.clone(),
                        _ => unreachable!(),
                    }
                    .naive_utc();
                    let v101: chrono::DateTime<chrono::Local> =
                        chrono::offset::TimeZone::from_utc_datetime(&chrono::Local, &v99);
                    let v103: string = string("r#\"%Y%m%d-%H%M-%S%f\"#");
                    let v104: &str = r#"%Y%m%d-%H%M-%S%f"#;
                    let v106: std::string::String = v101.format(v104).to_string();
                    let v108: string = fable_library_rust::String_::fromString(v106);
                    File_system::US3::US3_0(sprintf!(
                        "{}-{}-{}",
                        getSlice(v108.clone(), Some(0_i32), Some(17_i32)),
                        getSlice(v108.clone(), Some(18_i32), Some(21_i32)),
                        getCharAt(v108, 22_i32)
                    ))
                }
                _ => File_system::US3::US3_1,
            };
            let v117: string = match &v113 {
                File_system::US3::US3_0(v113_0_0) => match &v113 {
                    File_system::US3::US3_0(x) => x.clone(),
                    _ => unreachable!(),
                },
                _ => string(""),
            };
            let _v120: MutCell<Option<LrcPtr<TimeZoneInfo>>> =
                MutCell::new(None::<LrcPtr<TimeZoneInfo>>);
            {
                let x_3: LrcPtr<TimeZoneInfo> = 0i64.into();
                _v120.set(Some(x_3))
            }
            {
                let v160: LrcPtr<TimeZoneInfo> = match &_v120.get().clone() {
                    None => panic!("{}", string("base.run_target / _v120=None"),),
                    Some(_v120_0_0) => _v120_0_0.clone(),
                };
                let _v177: MutCell<Option<TimeSpan>> = MutCell::new(None::<TimeSpan>);
                _v177.set(Some(zero));
                {
                    let v276: TimeSpan = match &_v177.get().clone() {
                        None => panic!("{}", string("base.run_target / _v177=None"),),
                        Some(_v177_0_0) => _v177_0_0.clone(),
                    };
                    let v297: u8 = if v276.hours() > 0_i32 { 1_u8 } else { 0_u8 };
                    let v298: string = File_system::method43();
                    let _v301: MutCell<Option<string>> = MutCell::new(None::<string>);
                    {
                        let x_7: string = v276.to_string(v298);
                        _v301.set(Some(x_7))
                    }
                    {
                        let v308: string = match &_v301.get().clone() {
                            None => panic!("{}", string("base.run_target / _v301=None"),),
                            Some(_v301_0_0) => _v301_0_0.clone(),
                        };
                        let v315: string = sprintf!(
                            "{}{}{}",
                            v297,
                            getSlice(v308.clone(), Some(0_i32), Some(1_i32)),
                            getSlice(v308, Some(3_i32), Some(4_i32))
                        );
                        {
                            let x_9: Guid = parse(sprintf!(
                                "{}{}{}",
                                v117.clone(),
                                v315.clone(),
                                getSlice(
                                    toString(v0),
                                    Some(length(v117) + length(v315)),
                                    None::<i32>
                                )
                            ));
                            _v4.set(Some(x_9))
                        }
                        match &_v4.get().clone() {
                            None => panic!("{}", string("base.run_target / _v4=None"),),
                            Some(_v4_0_0) => _v4_0_0.clone(),
                        }
                    }
                }
            }
        }
    }
    pub fn method47() -> string {
        let _v2: MutCell<Option<string>> = MutCell::new(None::<string>);
        let v4: std::path::PathBuf = std::env::temp_dir();
        let v6: std::path::Display = v4.display();
        let _v9: MutCell<Option<std::string::String>> = MutCell::new(None::<std::string::String>);
        {
            let x: std::string::String = format!("{}", v6);
            _v9.set(Some(x))
        }
        {
            let v43: std::string::String = match &_v9.get().clone() {
                None => panic!("{}", string("base.run_target / _v9=None"),),
                Some(_v9_0_0) => _v9_0_0.clone(),
            };
            {
                let x_2: string = fable_library_rust::String_::fromString(v43);
                _v2.set(Some(x_2))
            }
            match &_v2.get().clone() {
                None => panic!("{}", string("base.run_target / _v2=None"),),
                Some(_v2_0_0) => _v2_0_0.clone(),
            }
        }
    }
    pub fn method48() -> string {
        string("!create_temp_path_")
    }
    pub fn method51(v0: string) -> string {
        v0
    }
    pub fn method50(v0: string, v1: string) -> (string, string) {
        (v1, File_system::method51(v0))
    }
    pub fn method49(v0: string, v1: string) -> string {
        let _v4: MutCell<Option<string>> = MutCell::new(None::<string>);
        let v6: &str = &*v0;
        let v8: std::string::String = String::from(v6);
        let v10_1: std::path::PathBuf = std::path::PathBuf::from(v8);
        let v12_1: &str = &*v1;
        let v14_1: std::string::String = String::from(v12_1);
        let v16_1: std::path::PathBuf = v10_1.join(v14_1);
        let v18_1: std::path::Display = v16_1.display();
        let _v21: MutCell<Option<std::string::String>> = MutCell::new(None::<std::string::String>);
        {
            let x: std::string::String = format!("{}", v18_1);
            _v21.set(Some(x))
        }
        {
            let v55: std::string::String = match &_v21.get().clone() {
                None => panic!("{}", string("base.run_target / _v21=None"),),
                Some(_v21_0_0) => _v21_0_0.clone(),
            };
            {
                let x_2: string = fable_library_rust::String_::fromString(v55);
                _v4.set(Some(x_2))
            }
            match &_v4.get().clone() {
                None => panic!("{}", string("base.run_target / _v4=None"),),
                Some(_v4_0_0) => _v4_0_0.clone(),
            }
        }
    }
    pub fn method53() -> string {
        string("CARGO_PKG_NAME")
    }
    pub fn method52() -> string {
        let _v2: MutCell<Option<string>> = MutCell::new(None::<string>);
        {
            let x: string = File_system::method1(File_system::method53());
            _v2.set(Some(x))
        }
        match &_v2.get().clone() {
            None => panic!("{}", string("base.run_target / _v2=None"),),
            Some(_v2_0_0) => _v2_0_0.clone(),
        }
    }
    pub fn method46(v0: Guid) -> string {
        let _v3: MutCell<Option<string>> = MutCell::new(None::<string>);
        {
            let x: string = File_system::method49(
                File_system::method49(
                    File_system::method49(File_system::method47(), File_system::method48()),
                    File_system::method52(),
                ),
                toString(v0),
            );
            _v3.set(Some(x))
        }
        match &_v3.get().clone() {
            None => panic!("{}", string("base.run_target / _v3=None"),),
            Some(_v3_0_0) => _v3_0_0.clone(),
        }
    }
    pub fn method41() -> string {
        let _v2: MutCell<Option<string>> = MutCell::new(None::<string>);
        let v5: DateTime = DateTime::now();
        {
            let x: string = File_system::method46(File_system::method42(new_guid(), v5));
            _v2.set(Some(x))
        }
        match &_v2.get().clone() {
            None => panic!("{}", string("base.run_target / _v2=None"),),
            Some(_v2_0_0) => _v2_0_0.clone(),
        }
    }
    pub fn closure40(unitVar: (), unitVar_1: ()) -> string {
        File_system::method41()
    }
    pub fn method55(v0: string) -> string {
        v0
    }
    pub fn closure42(unitVar: (), v0: std::io::Error) -> std::string::String {
        let _v3: MutCell<Option<std::string::String>> = MutCell::new(None::<std::string::String>);
        {
            let x: std::string::String = format!("{}", v0);
            _v3.set(Some(x))
        }
        match &_v3.get().clone() {
            None => panic!("{}", string("base.run_target / _v3=None"),),
            Some(_v3_0_0) => _v3_0_0.clone(),
        }
    }
    pub fn method56() -> Func1<std::io::Error, std::string::String> {
        Func1::new(move |v: std::io::Error| File_system::closure42((), v))
    }
    pub fn closure43(unitVar: (), unitVar_1: ()) -> File_system::US12 {
        File_system::US12::US12_0
    }
    pub fn closure44(unitVar: (), v0: std::string::String) -> File_system::US12 {
        File_system::US12::US12_1(v0)
    }
    pub fn closure45(unitVar: (), unitVar_1: ()) -> string {
        string("file_system.create_dir")
    }
    pub fn closure46(
        v0: string,
        v1: std::string::String,
        unitVar: (),
    ) -> (string, std::string::String) {
        (v0, v1)
    }
    pub fn method59(v0: LrcPtr<File_system::Mut4>, v1: std::string::String) {
        File_system::method15(v0, sprintf!("{:?}", v1));
    }
    pub fn method58(v0: LrcPtr<File_system::Mut4>, v1: string, v2_1: std::string::String) {
        File_system::method15(v0.clone(), string("{ "));
        File_system::method16(v0.clone());
        File_system::method15(v0.clone(), string("dir"));
        File_system::method15(v0.clone(), string(" = "));
        File_system::method15(v0.clone(), v1);
        File_system::method15(v0.clone(), string("; "));
        File_system::method15(v0.clone(), string("error"));
        File_system::method15(v0.clone(), string(" = "));
        File_system::method59(v0.clone(), v2_1);
        File_system::method15(v0, string(" }"))
    }
    pub fn closure47(
        v0: File_system::US0,
        v1: Func0<string>,
        v2_1: Func0<(string, std::string::String)>,
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
                LrcPtr<File_system::Mut3>,
                Option<i64>,
            ) = getValue(File_system::State::trace_state().get().clone());
            let v18_1: Option<i64> = patternInput.4.clone();
            let _v35: MutCell<Option<string>> = MutCell::new(None::<string>);
            let _v38: LrcPtr<MutCell<Option<File_system::US2>>> = refCell(None::<File_system::US2>);
            {
                let x_2: Option<File_system::US2> = match &v18_1 {
                    None => None::<File_system::US2>,
                    Some(v18_1_0_0) => {
                        let x: i64 = v18_1_0_0.clone();
                        Some((Func0::new({
                            let x = x.clone();
                            move || File_system::US2::US2_0(x)
                        }))())
                    }
                };
                _v38.set(x_2)
            }
            {
                let v65: File_system::US2 =
                    defaultValue(File_system::US2::US2_1, _v38.get().clone());
                let v163: DateTime = match &v65 {
                    File_system::US2::US2_0(v65_0_0) => {
                        let v97: TimeSpan = TimeSpan::new_ticks(
                            {
                                let _arg: DateTime = DateTime::now();
                                _arg.ticks()
                            } - match &v65 {
                                File_system::US2::US2_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                        );
                        DateTime::new_ymdhms_milli(
                            1_i32,
                            1_i32,
                            1_i32,
                            v97.hours(),
                            v97.minutes(),
                            v97.seconds(),
                            v97.milliseconds(),
                        )
                    }
                    _ => DateTime::now(),
                };
                {
                    let x_3: string = {
                        let provider: string = File_system::method10();
                        v163.toString(provider)
                    };
                    _v35.set(Some(x_3))
                }
                {
                    let v772: string = match &_v35.get().clone() {
                        None => panic!("{}", string("base.run_target / _v35=None"),),
                        Some(_v35_0_0) => _v35_0_0.clone(),
                    };
                    let v931: File_system::US3 = if if let File_system::US0::US0_0 = &v0 {
                        true
                    } else {
                        false
                    } {
                        File_system::US3::US3_0(string("Verbose"))
                    } else {
                        File_system::US3::US3_1
                    };
                    let v980: File_system::US3 = match &v931 {
                        File_system::US3::US3_0(v931_0_0) => File_system::US3::US3_0(match &v931 {
                            File_system::US3::US3_0(x) => x.clone(),
                            _ => unreachable!(),
                        }),
                        _ => {
                            let v940: File_system::US3 = if if let File_system::US0::US0_1 = &v0 {
                                true
                            } else {
                                false
                            } {
                                File_system::US3::US3_0(string("Debug"))
                            } else {
                                File_system::US3::US3_1
                            };
                            match &v940 {
                                File_system::US3::US3_0(v940_0_0) => {
                                    File_system::US3::US3_0(match &v940 {
                                        File_system::US3::US3_0(x) => x.clone(),
                                        _ => unreachable!(),
                                    })
                                }
                                _ => {
                                    let v949: File_system::US3 =
                                        if if let File_system::US0::US0_2 = &v0 {
                                            true
                                        } else {
                                            false
                                        } {
                                            File_system::US3::US3_0(string("Info"))
                                        } else {
                                            File_system::US3::US3_1
                                        };
                                    match &v949 {
                                        File_system::US3::US3_0(v949_0_0) => {
                                            File_system::US3::US3_0(match &v949 {
                                                File_system::US3::US3_0(x) => x.clone(),
                                                _ => unreachable!(),
                                            })
                                        }
                                        _ => {
                                            let v958: File_system::US3 =
                                                if if let File_system::US0::US0_3 = &v0 {
                                                    true
                                                } else {
                                                    false
                                                } {
                                                    File_system::US3::US3_0(string("Warning"))
                                                } else {
                                                    File_system::US3::US3_1
                                                };
                                            match &v958 {
                                                File_system::US3::US3_0(v958_0_0) => {
                                                    File_system::US3::US3_0(match &v958 {
                                                        File_system::US3::US3_0(x) => x.clone(),
                                                        _ => unreachable!(),
                                                    })
                                                }
                                                _ => {
                                                    let v967: File_system::US3 =
                                                        if if let File_system::US0::US0_4 = &v0 {
                                                            true
                                                        } else {
                                                            false
                                                        } {
                                                            File_system::US3::US3_0(string(
                                                                "Critical",
                                                            ))
                                                        } else {
                                                            File_system::US3::US3_1
                                                        };
                                                    match &v967 {
                                                        File_system::US3::US3_0(v967_0_0) => {
                                                            File_system::US3::US3_0(match &v967 {
                                                                File_system::US3::US3_0(x) => {
                                                                    x.clone()
                                                                }
                                                                _ => unreachable!(),
                                                            })
                                                        }
                                                        _ => File_system::US3::US3_1,
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    };
                    let v997: string = padLeft(
                        toLower(match &v980 {
                            File_system::US3::US3_0(v980_0_0) => match &v980 {
                                File_system::US3::US3_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                            _ => panic!("{}", string("Option does not have a value."),),
                        }),
                        7_i32,
                        ' ',
                    );
                    let _v1029: MutCell<Option<string>> = MutCell::new(None::<string>);
                    let v1044: &str = match &v0 {
                        File_system::US0::US0_1 => inline_colorization::color_bright_blue,
                        File_system::US0::US0_2 => inline_colorization::color_bright_green,
                        File_system::US0::US0_0 => inline_colorization::color_bright_black,
                        File_system::US0::US0_3 => inline_colorization::color_yellow,
                        _ => inline_colorization::color_bright_red,
                    };
                    let v1046: &str = &*v997;
                    let v1048: &str = inline_colorization::color_reset;
                    let v1050: string = string("format!(\"{v1044}{v1046}{v1048}\")");
                    let v1051: std::string::String = format!("{v1044}{v1046}{v1048}");
                    {
                        let x_5: string = fable_library_rust::String_::fromString(v1051);
                        _v1029.set(Some(x_5))
                    }
                    {
                        let v1141: string = match &_v1029.get().clone() {
                            None => panic!("{}", string("base.run_target / _v1029=None"),),
                            Some(_v1029_0_0) => _v1029_0_0.clone(),
                        };
                        let v1160: i64 = (patternInput.0.clone()).l0.get().clone();
                        let patternInput_1: (string, std::string::String) = v2_1();
                        let v1164: LrcPtr<File_system::Mut4> = LrcPtr::new(File_system::Mut4 {
                            l0: MutCell::new(string("")),
                        });
                        File_system::method58(
                            v1164.clone(),
                            patternInput_1.0.clone(),
                            patternInput_1.1.clone(),
                        );
                        {
                            let v1165: string = v1164.l0.get().clone();
                            trimEndChars(
                                trimStartChars(
                                    sprintf!("{} {} #{} {} / {}", v772, v1141, v1160, v1(), v1165),
                                    toArray(empty::<char>()),
                                ),
                                toArray(ofArray(new_array(&[' ', '/']))),
                            )
                        }
                    }
                }
            }
        }
    }
    pub fn method57(
        v0: File_system::US0,
        v1: Func0<string>,
        v2_1: Func0<(string, std::string::String)>,
    ) {
        File_system::method17(
            v0.clone(),
            Func0::new({
                let v0 = v0.clone();
                let v1 = v1.clone();
                let v2_1 = v2_1.clone();
                move || File_system::closure47(v0.clone(), v1.clone(), v2_1.clone(), ())
            }),
        );
    }
    pub fn closure48(unitVar: (), unitVar_1: ()) -> string {
        string("file_system.create_dir")
    }
    pub fn closure49(v0: string, unitVar: ()) -> string {
        v0
    }
    pub fn method61(v0: LrcPtr<File_system::Mut4>, v1: string) {
        File_system::method15(v0.clone(), string("{ "));
        File_system::method16(v0.clone());
        File_system::method15(v0.clone(), string("dir"));
        File_system::method15(v0.clone(), string(" = "));
        File_system::method15(v0.clone(), v1);
        File_system::method15(v0, string(" }"))
    }
    pub fn closure50(
        v0: File_system::US0,
        v1: Func0<string>,
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
                LrcPtr<File_system::Mut3>,
                Option<i64>,
            ) = getValue(File_system::State::trace_state().get().clone());
            let v18_1: Option<i64> = patternInput.4.clone();
            let _v35: MutCell<Option<string>> = MutCell::new(None::<string>);
            let _v38: LrcPtr<MutCell<Option<File_system::US2>>> = refCell(None::<File_system::US2>);
            {
                let x_2: Option<File_system::US2> = match &v18_1 {
                    None => None::<File_system::US2>,
                    Some(v18_1_0_0) => {
                        let x: i64 = v18_1_0_0.clone();
                        Some((Func0::new({
                            let x = x.clone();
                            move || File_system::US2::US2_0(x)
                        }))())
                    }
                };
                _v38.set(x_2)
            }
            {
                let v65: File_system::US2 =
                    defaultValue(File_system::US2::US2_1, _v38.get().clone());
                let v163: DateTime = match &v65 {
                    File_system::US2::US2_0(v65_0_0) => {
                        let v97: TimeSpan = TimeSpan::new_ticks(
                            {
                                let _arg: DateTime = DateTime::now();
                                _arg.ticks()
                            } - match &v65 {
                                File_system::US2::US2_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                        );
                        DateTime::new_ymdhms_milli(
                            1_i32,
                            1_i32,
                            1_i32,
                            v97.hours(),
                            v97.minutes(),
                            v97.seconds(),
                            v97.milliseconds(),
                        )
                    }
                    _ => DateTime::now(),
                };
                {
                    let x_3: string = {
                        let provider: string = File_system::method10();
                        v163.toString(provider)
                    };
                    _v35.set(Some(x_3))
                }
                {
                    let v772: string = match &_v35.get().clone() {
                        None => panic!("{}", string("base.run_target / _v35=None"),),
                        Some(_v35_0_0) => _v35_0_0.clone(),
                    };
                    let v931: File_system::US3 = if if let File_system::US0::US0_0 = &v0 {
                        true
                    } else {
                        false
                    } {
                        File_system::US3::US3_0(string("Verbose"))
                    } else {
                        File_system::US3::US3_1
                    };
                    let v980: File_system::US3 = match &v931 {
                        File_system::US3::US3_0(v931_0_0) => File_system::US3::US3_0(match &v931 {
                            File_system::US3::US3_0(x) => x.clone(),
                            _ => unreachable!(),
                        }),
                        _ => {
                            let v940: File_system::US3 = if if let File_system::US0::US0_1 = &v0 {
                                true
                            } else {
                                false
                            } {
                                File_system::US3::US3_0(string("Debug"))
                            } else {
                                File_system::US3::US3_1
                            };
                            match &v940 {
                                File_system::US3::US3_0(v940_0_0) => {
                                    File_system::US3::US3_0(match &v940 {
                                        File_system::US3::US3_0(x) => x.clone(),
                                        _ => unreachable!(),
                                    })
                                }
                                _ => {
                                    let v949: File_system::US3 =
                                        if if let File_system::US0::US0_2 = &v0 {
                                            true
                                        } else {
                                            false
                                        } {
                                            File_system::US3::US3_0(string("Info"))
                                        } else {
                                            File_system::US3::US3_1
                                        };
                                    match &v949 {
                                        File_system::US3::US3_0(v949_0_0) => {
                                            File_system::US3::US3_0(match &v949 {
                                                File_system::US3::US3_0(x) => x.clone(),
                                                _ => unreachable!(),
                                            })
                                        }
                                        _ => {
                                            let v958: File_system::US3 =
                                                if if let File_system::US0::US0_3 = &v0 {
                                                    true
                                                } else {
                                                    false
                                                } {
                                                    File_system::US3::US3_0(string("Warning"))
                                                } else {
                                                    File_system::US3::US3_1
                                                };
                                            match &v958 {
                                                File_system::US3::US3_0(v958_0_0) => {
                                                    File_system::US3::US3_0(match &v958 {
                                                        File_system::US3::US3_0(x) => x.clone(),
                                                        _ => unreachable!(),
                                                    })
                                                }
                                                _ => {
                                                    let v967: File_system::US3 =
                                                        if if let File_system::US0::US0_4 = &v0 {
                                                            true
                                                        } else {
                                                            false
                                                        } {
                                                            File_system::US3::US3_0(string(
                                                                "Critical",
                                                            ))
                                                        } else {
                                                            File_system::US3::US3_1
                                                        };
                                                    match &v967 {
                                                        File_system::US3::US3_0(v967_0_0) => {
                                                            File_system::US3::US3_0(match &v967 {
                                                                File_system::US3::US3_0(x) => {
                                                                    x.clone()
                                                                }
                                                                _ => unreachable!(),
                                                            })
                                                        }
                                                        _ => File_system::US3::US3_1,
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    };
                    let v997: string = padLeft(
                        toLower(match &v980 {
                            File_system::US3::US3_0(v980_0_0) => match &v980 {
                                File_system::US3::US3_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                            _ => panic!("{}", string("Option does not have a value."),),
                        }),
                        7_i32,
                        ' ',
                    );
                    let _v1029: MutCell<Option<string>> = MutCell::new(None::<string>);
                    let v1044: &str = match &v0 {
                        File_system::US0::US0_1 => inline_colorization::color_bright_blue,
                        File_system::US0::US0_2 => inline_colorization::color_bright_green,
                        File_system::US0::US0_0 => inline_colorization::color_bright_black,
                        File_system::US0::US0_3 => inline_colorization::color_yellow,
                        _ => inline_colorization::color_bright_red,
                    };
                    let v1046: &str = &*v997;
                    let v1048: &str = inline_colorization::color_reset;
                    let v1050: string = string("format!(\"{v1044}{v1046}{v1048}\")");
                    let v1051: std::string::String = format!("{v1044}{v1046}{v1048}");
                    {
                        let x_5: string = fable_library_rust::String_::fromString(v1051);
                        _v1029.set(Some(x_5))
                    }
                    {
                        let v1141: string = match &_v1029.get().clone() {
                            None => panic!("{}", string("base.run_target / _v1029=None"),),
                            Some(_v1029_0_0) => _v1029_0_0.clone(),
                        };
                        let v1160: i64 = (patternInput.0.clone()).l0.get().clone();
                        let v1163: LrcPtr<File_system::Mut4> = LrcPtr::new(File_system::Mut4 {
                            l0: MutCell::new(string("")),
                        });
                        File_system::method61(v1163.clone(), v2_1());
                        {
                            let v1164: string = v1163.l0.get().clone();
                            trimEndChars(
                                trimStartChars(
                                    sprintf!("{} {} #{} {} / {}", v772, v1141, v1160, v1(), v1164),
                                    toArray(empty::<char>()),
                                ),
                                toArray(ofArray(new_array(&[' ', '/']))),
                            )
                        }
                    }
                }
            }
        }
    }
    pub fn method60(v0: File_system::US0, v1: Func0<string>, v2_1: Func0<string>) {
        File_system::method17(
            v0.clone(),
            Func0::new({
                let v0 = v0.clone();
                let v1 = v1.clone();
                let v2_1 = v2_1.clone();
                move || File_system::closure50(v0.clone(), v1.clone(), v2_1.clone(), ())
            }),
        );
    }
    pub fn closure51(v0: string, unitVar: ()) {
        File_system::method5(true, v0);
    }
    pub fn method62(v0: string) -> Func0<()> {
        Func0::new({
            let v0 = v0.clone();
            move || File_system::closure51(v0.clone(), ())
        })
    }
    pub fn method63(v0: string) -> Func0<()> {
        Func0::new({
            let v0 = v0.clone();
            move || File_system::closure51(v0.clone(), ())
        })
    }
    pub fn closure52(unitVar: (), unitVar_1: ()) -> string {
        string("file_system.create_dir")
    }
    pub fn closure53(v0: string, v1: string, unitVar: ()) -> (string, string) {
        (v0, v1)
    }
    pub fn method65(v0: LrcPtr<File_system::Mut4>, v1: string, v2_1: string) {
        File_system::method15(v0.clone(), string("{ "));
        File_system::method16(v0.clone());
        File_system::method15(v0.clone(), string("dir"));
        File_system::method15(v0.clone(), string(" = "));
        File_system::method15(v0.clone(), v1);
        File_system::method15(v0.clone(), string("; "));
        File_system::method15(v0.clone(), string("result"));
        File_system::method15(v0.clone(), string(" = "));
        File_system::method15(v0.clone(), v2_1);
        File_system::method15(v0, string(" }"))
    }
    pub fn closure54(
        v0: File_system::US0,
        v1: Func0<string>,
        v2_1: Func0<(string, string)>,
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
                LrcPtr<File_system::Mut3>,
                Option<i64>,
            ) = getValue(File_system::State::trace_state().get().clone());
            let v18_1: Option<i64> = patternInput.4.clone();
            let _v35: MutCell<Option<string>> = MutCell::new(None::<string>);
            let _v38: LrcPtr<MutCell<Option<File_system::US2>>> = refCell(None::<File_system::US2>);
            {
                let x_2: Option<File_system::US2> = match &v18_1 {
                    None => None::<File_system::US2>,
                    Some(v18_1_0_0) => {
                        let x: i64 = v18_1_0_0.clone();
                        Some((Func0::new({
                            let x = x.clone();
                            move || File_system::US2::US2_0(x)
                        }))())
                    }
                };
                _v38.set(x_2)
            }
            {
                let v65: File_system::US2 =
                    defaultValue(File_system::US2::US2_1, _v38.get().clone());
                let v163: DateTime = match &v65 {
                    File_system::US2::US2_0(v65_0_0) => {
                        let v97: TimeSpan = TimeSpan::new_ticks(
                            {
                                let _arg: DateTime = DateTime::now();
                                _arg.ticks()
                            } - match &v65 {
                                File_system::US2::US2_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                        );
                        DateTime::new_ymdhms_milli(
                            1_i32,
                            1_i32,
                            1_i32,
                            v97.hours(),
                            v97.minutes(),
                            v97.seconds(),
                            v97.milliseconds(),
                        )
                    }
                    _ => DateTime::now(),
                };
                {
                    let x_3: string = {
                        let provider: string = File_system::method10();
                        v163.toString(provider)
                    };
                    _v35.set(Some(x_3))
                }
                {
                    let v772: string = match &_v35.get().clone() {
                        None => panic!("{}", string("base.run_target / _v35=None"),),
                        Some(_v35_0_0) => _v35_0_0.clone(),
                    };
                    let v931: File_system::US3 = if if let File_system::US0::US0_0 = &v0 {
                        true
                    } else {
                        false
                    } {
                        File_system::US3::US3_0(string("Verbose"))
                    } else {
                        File_system::US3::US3_1
                    };
                    let v980: File_system::US3 = match &v931 {
                        File_system::US3::US3_0(v931_0_0) => File_system::US3::US3_0(match &v931 {
                            File_system::US3::US3_0(x) => x.clone(),
                            _ => unreachable!(),
                        }),
                        _ => {
                            let v940: File_system::US3 = if if let File_system::US0::US0_1 = &v0 {
                                true
                            } else {
                                false
                            } {
                                File_system::US3::US3_0(string("Debug"))
                            } else {
                                File_system::US3::US3_1
                            };
                            match &v940 {
                                File_system::US3::US3_0(v940_0_0) => {
                                    File_system::US3::US3_0(match &v940 {
                                        File_system::US3::US3_0(x) => x.clone(),
                                        _ => unreachable!(),
                                    })
                                }
                                _ => {
                                    let v949: File_system::US3 =
                                        if if let File_system::US0::US0_2 = &v0 {
                                            true
                                        } else {
                                            false
                                        } {
                                            File_system::US3::US3_0(string("Info"))
                                        } else {
                                            File_system::US3::US3_1
                                        };
                                    match &v949 {
                                        File_system::US3::US3_0(v949_0_0) => {
                                            File_system::US3::US3_0(match &v949 {
                                                File_system::US3::US3_0(x) => x.clone(),
                                                _ => unreachable!(),
                                            })
                                        }
                                        _ => {
                                            let v958: File_system::US3 =
                                                if if let File_system::US0::US0_3 = &v0 {
                                                    true
                                                } else {
                                                    false
                                                } {
                                                    File_system::US3::US3_0(string("Warning"))
                                                } else {
                                                    File_system::US3::US3_1
                                                };
                                            match &v958 {
                                                File_system::US3::US3_0(v958_0_0) => {
                                                    File_system::US3::US3_0(match &v958 {
                                                        File_system::US3::US3_0(x) => x.clone(),
                                                        _ => unreachable!(),
                                                    })
                                                }
                                                _ => {
                                                    let v967: File_system::US3 =
                                                        if if let File_system::US0::US0_4 = &v0 {
                                                            true
                                                        } else {
                                                            false
                                                        } {
                                                            File_system::US3::US3_0(string(
                                                                "Critical",
                                                            ))
                                                        } else {
                                                            File_system::US3::US3_1
                                                        };
                                                    match &v967 {
                                                        File_system::US3::US3_0(v967_0_0) => {
                                                            File_system::US3::US3_0(match &v967 {
                                                                File_system::US3::US3_0(x) => {
                                                                    x.clone()
                                                                }
                                                                _ => unreachable!(),
                                                            })
                                                        }
                                                        _ => File_system::US3::US3_1,
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    };
                    let v997: string = padLeft(
                        toLower(match &v980 {
                            File_system::US3::US3_0(v980_0_0) => match &v980 {
                                File_system::US3::US3_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                            _ => panic!("{}", string("Option does not have a value."),),
                        }),
                        7_i32,
                        ' ',
                    );
                    let _v1029: MutCell<Option<string>> = MutCell::new(None::<string>);
                    let v1044: &str = match &v0 {
                        File_system::US0::US0_1 => inline_colorization::color_bright_blue,
                        File_system::US0::US0_2 => inline_colorization::color_bright_green,
                        File_system::US0::US0_0 => inline_colorization::color_bright_black,
                        File_system::US0::US0_3 => inline_colorization::color_yellow,
                        _ => inline_colorization::color_bright_red,
                    };
                    let v1046: &str = &*v997;
                    let v1048: &str = inline_colorization::color_reset;
                    let v1050: string = string("format!(\"{v1044}{v1046}{v1048}\")");
                    let v1051: std::string::String = format!("{v1044}{v1046}{v1048}");
                    {
                        let x_5: string = fable_library_rust::String_::fromString(v1051);
                        _v1029.set(Some(x_5))
                    }
                    {
                        let v1141: string = match &_v1029.get().clone() {
                            None => panic!("{}", string("base.run_target / _v1029=None"),),
                            Some(_v1029_0_0) => _v1029_0_0.clone(),
                        };
                        let v1160: i64 = (patternInput.0.clone()).l0.get().clone();
                        let patternInput_1: (string, string) = v2_1();
                        let v1164: LrcPtr<File_system::Mut4> = LrcPtr::new(File_system::Mut4 {
                            l0: MutCell::new(string("")),
                        });
                        File_system::method65(
                            v1164.clone(),
                            patternInput_1.0.clone(),
                            patternInput_1.1.clone(),
                        );
                        {
                            let v1165: string = v1164.l0.get().clone();
                            trimEndChars(
                                trimStartChars(
                                    sprintf!("{} {} #{} {} / {}", v772, v1141, v1160, v1(), v1165),
                                    toArray(empty::<char>()),
                                ),
                                toArray(ofArray(new_array(&[' ', '/']))),
                            )
                        }
                    }
                }
            }
        }
    }
    pub fn method64(v0: File_system::US0, v1: Func0<string>, v2_1: Func0<(string, string)>) {
        File_system::method17(
            v0.clone(),
            Func0::new({
                let v0 = v0.clone();
                let v1 = v1.clone();
                let v2_1 = v2_1.clone();
                move || File_system::closure54(v0.clone(), v1.clone(), v2_1.clone(), ())
            }),
        );
    }
    pub fn closure55(v0: string, unitVar: ()) {
        let _v3: MutCell<Option<Arc<Async<i64>>>> = MutCell::new(None::<Arc<Async<i64>>>);
        {
            let x: Arc<Async<i64>> = defaultOf();
            _v3.set(Some(x))
        }
        {
            let v51: Arc<Async<i64>> = match &_v3.get().clone() {
                None => panic!("{}", string("base.run_target / _v3=None"),),
                Some(_v3_0_0) => _v3_0_0.clone(),
            };
            let _v68: MutCell<Option<Arc<Async<()>>>> = MutCell::new(None::<Arc<Async<()>>>);
            {
                let x_2: Arc<Async<()>> = defaultOf();
                _v68.set(Some(x_2))
            }
            {
                let v116: Arc<Async<()>> = match &_v68.get().clone() {
                    None => panic!("{}", string("base.run_target / _v68=None"),),
                    Some(_v68_0_0) => _v68_0_0.clone(),
                };
                let _v133: MutCell<Option<()>> = MutCell::new(None::<()>);
                defaultOf::<()>();
                _v133.set(Some(()));
                match &_v133.get().clone() {
                    None => panic!("{}", string("base.run_target / _v133=None"),),
                    Some(_v133_0_0) => _v133_0_0.clone(),
                }
                ()
            }
        }
    }
    pub fn method66(v0: string) -> Func0<()> {
        Func0::new({
            let v0 = v0.clone();
            move || File_system::closure55(v0.clone(), ())
        })
    }
    pub fn method67(v0: string) -> Func0<()> {
        Func0::new({
            let v0 = v0.clone();
            move || File_system::closure55(v0.clone(), ())
        })
    }
    pub fn method54(v0: string) -> LrcPtr<dyn IDisposable> {
        let _v3: MutCell<Option<LrcPtr<dyn IDisposable>>> =
            MutCell::new(None::<LrcPtr<dyn IDisposable>>);
        let v4: string = File_system::method55(v0);
        let v6: Result<(), std::io::Error> = std::fs::create_dir_all(&*v4.clone());
        let v7 = File_system::method56();
        let v9_1: Result<(), std::string::String> = v6.map_err(|x| v7(x));
        let v12_1: File_system::US12 = match &v9_1 {
            Err(v9_1_1_0) => File_system::closure44((), v9_1_1_0.clone()),
            _ => File_system::closure43((), ()),
        };
        match &v12_1 {
            File_system::US12::US12_0 => File_system::method60(
                File_system::US0::US0_0,
                Func0::new(move || File_system::closure48((), ())),
                Func0::new({
                    let v4 = v4.clone();
                    move || File_system::closure49(v4.clone(), ())
                }),
            ),
            File_system::US12::US12_1(v12_1_1_0) => File_system::method57(
                File_system::US0::US0_4,
                Func0::new(move || File_system::closure45((), ())),
                Func0::new({
                    let v12_1 = v12_1.clone();
                    let v4 = v4.clone();
                    move || {
                        File_system::closure46(
                            v4.clone(),
                            match &v12_1 {
                                File_system::US12::US12_1(x) => x.clone(),
                                _ => unreachable!(),
                            },
                            (),
                        )
                    }
                }),
            ),
        }
        {
            let _v22: MutCell<Option<LrcPtr<dyn IDisposable>>> =
                MutCell::new(None::<LrcPtr<dyn IDisposable>>);
            let v23_1 = File_system::method62(v4.clone());
            {
                let x_1: LrcPtr<dyn IDisposable> = interface_cast!(
                    File_system::Disposable::_ctor__3A5B6456(Func0::new({
                        let v23_1 = v23_1.clone();
                        move || v23_1.clone()()
                    })),
                    Lrc<dyn IDisposable>,
                );
                _v22.set(Some(x_1))
            }
            {
                let x_3: LrcPtr<dyn IDisposable> = match &_v22.get().clone() {
                    None => panic!("{}", string("base.run_target / _v22=None"),),
                    Some(_v22_0_0) => _v22_0_0.clone(),
                };
                _v3.set(Some(x_3))
            }
            match &_v3.get().clone() {
                None => panic!("{}", string("base.run_target / _v3=None"),),
                Some(_v3_0_0) => _v3_0_0.clone(),
            }
        }
    }
    pub fn closure41(unitVar: (), unitVar_1: ()) -> (string, LrcPtr<dyn IDisposable>) {
        let v0: string = File_system::method41();
        (v0.clone(), File_system::method54(v0))
    }
    pub fn method68(v0: string) -> Guid {
        let _v3: MutCell<Option<Guid>> = MutCell::new(None::<Guid>);
        let v6: string = padLeft(v0, 32_i32, '0');
        {
            let x: Guid = parse(sprintf!(
                "{}-{}-{}-{}-{}",
                getSlice(v6.clone(), Some(0_i32), Some(7_i32)),
                getSlice(v6.clone(), Some(8_i32), Some(11_i32)),
                getSlice(v6.clone(), Some(12_i32), Some(15_i32)),
                getSlice(v6.clone(), Some(16_i32), Some(19_i32)),
                getSlice(v6, Some(20_i32), Some(31_i32))
            ));
            _v3.set(Some(x))
        }
        match &_v3.get().clone() {
            None => panic!("{}", string("base.run_target / _v3=None"),),
            Some(_v3_0_0) => _v3_0_0.clone(),
        }
    }
    pub fn closure56(unitVar: (), v0: string) -> (string, LrcPtr<dyn IDisposable>) {
        let v2_1: string = File_system::method46(File_system::method68(v0));
        (v2_1.clone(), File_system::method54(v2_1))
    }
    pub fn closure57(unitVar: (), unitVar_1: ()) -> string {
        string("C:\\home\\git\\polyglot\\lib\\spiral")
    }
    pub fn method70() -> string {
        string("")
    }
    pub fn method71(v0: string) -> string {
        v0
    }
    pub fn method72() -> string {
        string("^\\\\\\\\\\?\\\\")
    }
    pub fn method69(v0: string) -> string {
        if v0.clone() == string("") {
            string("")
        } else {
            let v4: string = File_system::method70();
            let _v7: MutCell<Option<string>> = MutCell::new(None::<string>);
            let v8: string = File_system::method71(v0);
            let v11_1: Result<regex::Regex, regex::Error> =
                regex::Regex::new(&string("^\\\\\\\\\\?\\\\"));
            let v13_1: regex::Regex = v11_1.unwrap();
            let v15_1: std::borrow::Cow<str> = v13_1.replace_all(&v8, &*v4);
            let v17_1: std::string::String = String::from(v15_1);
            {
                let x: string = fable_library_rust::String_::fromString(v17_1);
                _v7.set(Some(x))
            }
            {
                let v58: string = match &_v7.get().clone() {
                    None => panic!("{}", string("base.run_target / _v7=None"),),
                    Some(_v7_0_0) => _v7_0_0.clone(),
                };
                replace(
                    sprintf!(
                        "{}{}",
                        toLower(ofChar(getCharAt(v58.clone(), 0_i32))),
                        getSlice(v58, Some(1_i32), None::<i32>)
                    ),
                    string("\\"),
                    string("/"),
                )
            }
        }
    }
    pub fn closure58(unitVar: (), v0: string) -> string {
        File_system::method69(v0)
    }
    pub fn closure59(unitVar: (), v0: string) -> string {
        sprintf!("file:///{}", trimStartChars(v0, toArray(singleton('/'))))
    }
    pub fn method75(v0: string) -> Option<string> {
        let _v3: MutCell<Option<File_system::US3>> = MutCell::new(None::<File_system::US3>);
        let v5: &str = &*v0;
        let v7: std::string::String = String::from(v5);
        let v9_1: std::path::PathBuf = std::path::PathBuf::from(v7);
        let v11_1: Option<std::path::PathBuf> = v9_1.parent().map(std::path::PathBuf::from);
        let v13_1: std::path::PathBuf = v11_1?;
        let v15_1: std::path::Display = v13_1.display();
        let _v18: MutCell<Option<std::string::String>> = MutCell::new(None::<std::string::String>);
        {
            let x: std::string::String = format!("{}", v15_1);
            _v18.set(Some(x))
        }
        {
            let v52: std::string::String = match &_v18.get().clone() {
                None => panic!("{}", string("base.run_target / _v18=None"),),
                Some(_v18_0_0) => _v18_0_0.clone(),
            };
            {
                let x_2: File_system::US3 =
                    File_system::US3::US3_0(fable_library_rust::String_::fromString(v52));
                _v3.set(Some(x_2))
            }
            {
                let v189: File_system::US3 = match &_v3.get().clone() {
                    None => panic!("{}", string("base.run_target / _v3=None"),),
                    Some(_v3_0_0) => _v3_0_0.clone(),
                };
                match &v189 {
                    File_system::US3::US3_0(v189_0_0) => Some(match &v189 {
                        File_system::US3::US3_0(x) => x.clone(),
                        _ => unreachable!(),
                    }),
                    _ => None::<string>,
                }
            }
        }
    }
    pub fn closure61(unitVar: (), v0: string) -> Option<string> {
        File_system::method75(v0)
    }
    pub fn method74() -> Func1<string, Option<string>> {
        Func1::new(move |v: string| File_system::closure61((), v))
    }
    pub fn method76(v0: string, v1: string, v2_1: string) -> File_system::US13 {
        let v0: MutCell<string> = MutCell::new(v0.clone());
        let v1: MutCell<string> = MutCell::new(v1.clone());
        let v2_1: MutCell<string> = MutCell::new(v2_1.clone());
        '_method76: loop {
            break '_method76 (if File_system::method7(File_system::method49(
                v2_1.get().clone(),
                v0.get().clone(),
            )) {
                File_system::US13::US13_0(v2_1.get().clone())
            } else {
                let v7: Option<string> = (File_system::method74())(v2_1.get().clone());
                let _v10: LrcPtr<MutCell<Option<File_system::US3>>> =
                    refCell(None::<File_system::US3>);
                {
                    let x_2: Option<File_system::US3> = match &v7 {
                        None => None::<File_system::US3>,
                        Some(v7_0_0) => {
                            let x: string = v7_0_0.clone();
                            Some((Func0::new({
                                let x = x.clone();
                                move || File_system::US3::US3_0(x.clone())
                            }))())
                        }
                    };
                    _v10.set(x_2)
                }
                {
                    let v37: File_system::US3 =
                        defaultValue(File_system::US3::US3_1, _v10.get().clone());
                    match &v37 {
                        File_system::US3::US3_0(v37_0_0) => {
                            let v0_temp: string = v0.get().clone();
                            let v1_temp: string = v1.get().clone();
                            let v2_1_temp: string = match &v37 {
                                File_system::US3::US3_0(x) => x.clone(),
                                _ => unreachable!(),
                            };
                            v0.set(v0_temp);
                            v1.set(v1_temp);
                            v2_1.set(v2_1_temp);
                            continue '_method76;
                        }
                        _ => File_system::US13::US13_1(sprintf!(
                            "No parent for {} \'{}\' at \'{}\' (until \'{}\')",
                            string("dir"),
                            v0.get().clone(),
                            v1.get().clone(),
                            v2_1.get().clone()
                        )),
                    }
                }
            });
        }
    }
    pub fn method73(v0: string, v1: string) -> File_system::US13 {
        if File_system::method7(File_system::method49(v1.clone(), v0.clone())) {
            File_system::US13::US13_0(v1.clone())
        } else {
            let v6: Option<string> = (File_system::method74())(v1.clone());
            let _v9: LrcPtr<MutCell<Option<File_system::US3>>> = refCell(None::<File_system::US3>);
            {
                let x_2: Option<File_system::US3> = match &v6 {
                    None => None::<File_system::US3>,
                    Some(v6_0_0) => {
                        let x: string = v6_0_0.clone();
                        Some((Func0::new({
                            let x = x.clone();
                            move || File_system::US3::US3_0(x.clone())
                        }))())
                    }
                };
                _v9.set(x_2)
            }
            {
                let v36: File_system::US3 =
                    defaultValue(File_system::US3::US3_1, _v9.get().clone());
                match &v36 {
                    File_system::US3::US3_0(v36_0_0) => File_system::method76(
                        v0.clone(),
                        v1.clone(),
                        match &v36 {
                            File_system::US3::US3_0(x) => x.clone(),
                            _ => unreachable!(),
                        },
                    ),
                    _ => File_system::US13::US13_1(sprintf!(
                        "No parent for {} \'{}\' at \'{}\' (until \'{}\')",
                        string("dir"),
                        v0.clone(),
                        v1.clone(),
                        v1.clone()
                    )),
                }
            }
        }
    }
    pub fn closure62(unitVar: (), unitVar_1: ()) -> string {
        string("file_system.get_workspace_root")
    }
    pub fn closure63(v0: string, unitVar: ()) -> string {
        v0
    }
    pub fn method78(v0: LrcPtr<File_system::Mut4>, v1: string) {
        File_system::method15(v0.clone(), string("{ "));
        File_system::method16(v0.clone());
        File_system::method15(v0.clone(), string("error"));
        File_system::method15(v0.clone(), string(" = "));
        File_system::method15(v0.clone(), v1);
        File_system::method15(v0, string(" }"))
    }
    pub fn closure64(
        v0: File_system::US0,
        v1: Func0<string>,
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
                LrcPtr<File_system::Mut3>,
                Option<i64>,
            ) = getValue(File_system::State::trace_state().get().clone());
            let v18_1: Option<i64> = patternInput.4.clone();
            let _v35: MutCell<Option<string>> = MutCell::new(None::<string>);
            let _v38: LrcPtr<MutCell<Option<File_system::US2>>> = refCell(None::<File_system::US2>);
            {
                let x_2: Option<File_system::US2> = match &v18_1 {
                    None => None::<File_system::US2>,
                    Some(v18_1_0_0) => {
                        let x: i64 = v18_1_0_0.clone();
                        Some((Func0::new({
                            let x = x.clone();
                            move || File_system::US2::US2_0(x)
                        }))())
                    }
                };
                _v38.set(x_2)
            }
            {
                let v65: File_system::US2 =
                    defaultValue(File_system::US2::US2_1, _v38.get().clone());
                let v163: DateTime = match &v65 {
                    File_system::US2::US2_0(v65_0_0) => {
                        let v97: TimeSpan = TimeSpan::new_ticks(
                            {
                                let _arg: DateTime = DateTime::now();
                                _arg.ticks()
                            } - match &v65 {
                                File_system::US2::US2_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                        );
                        DateTime::new_ymdhms_milli(
                            1_i32,
                            1_i32,
                            1_i32,
                            v97.hours(),
                            v97.minutes(),
                            v97.seconds(),
                            v97.milliseconds(),
                        )
                    }
                    _ => DateTime::now(),
                };
                {
                    let x_3: string = {
                        let provider: string = File_system::method10();
                        v163.toString(provider)
                    };
                    _v35.set(Some(x_3))
                }
                {
                    let v772: string = match &_v35.get().clone() {
                        None => panic!("{}", string("base.run_target / _v35=None"),),
                        Some(_v35_0_0) => _v35_0_0.clone(),
                    };
                    let v931: File_system::US3 = if if let File_system::US0::US0_0 = &v0 {
                        true
                    } else {
                        false
                    } {
                        File_system::US3::US3_0(string("Verbose"))
                    } else {
                        File_system::US3::US3_1
                    };
                    let v980: File_system::US3 = match &v931 {
                        File_system::US3::US3_0(v931_0_0) => File_system::US3::US3_0(match &v931 {
                            File_system::US3::US3_0(x) => x.clone(),
                            _ => unreachable!(),
                        }),
                        _ => {
                            let v940: File_system::US3 = if if let File_system::US0::US0_1 = &v0 {
                                true
                            } else {
                                false
                            } {
                                File_system::US3::US3_0(string("Debug"))
                            } else {
                                File_system::US3::US3_1
                            };
                            match &v940 {
                                File_system::US3::US3_0(v940_0_0) => {
                                    File_system::US3::US3_0(match &v940 {
                                        File_system::US3::US3_0(x) => x.clone(),
                                        _ => unreachable!(),
                                    })
                                }
                                _ => {
                                    let v949: File_system::US3 =
                                        if if let File_system::US0::US0_2 = &v0 {
                                            true
                                        } else {
                                            false
                                        } {
                                            File_system::US3::US3_0(string("Info"))
                                        } else {
                                            File_system::US3::US3_1
                                        };
                                    match &v949 {
                                        File_system::US3::US3_0(v949_0_0) => {
                                            File_system::US3::US3_0(match &v949 {
                                                File_system::US3::US3_0(x) => x.clone(),
                                                _ => unreachable!(),
                                            })
                                        }
                                        _ => {
                                            let v958: File_system::US3 =
                                                if if let File_system::US0::US0_3 = &v0 {
                                                    true
                                                } else {
                                                    false
                                                } {
                                                    File_system::US3::US3_0(string("Warning"))
                                                } else {
                                                    File_system::US3::US3_1
                                                };
                                            match &v958 {
                                                File_system::US3::US3_0(v958_0_0) => {
                                                    File_system::US3::US3_0(match &v958 {
                                                        File_system::US3::US3_0(x) => x.clone(),
                                                        _ => unreachable!(),
                                                    })
                                                }
                                                _ => {
                                                    let v967: File_system::US3 =
                                                        if if let File_system::US0::US0_4 = &v0 {
                                                            true
                                                        } else {
                                                            false
                                                        } {
                                                            File_system::US3::US3_0(string(
                                                                "Critical",
                                                            ))
                                                        } else {
                                                            File_system::US3::US3_1
                                                        };
                                                    match &v967 {
                                                        File_system::US3::US3_0(v967_0_0) => {
                                                            File_system::US3::US3_0(match &v967 {
                                                                File_system::US3::US3_0(x) => {
                                                                    x.clone()
                                                                }
                                                                _ => unreachable!(),
                                                            })
                                                        }
                                                        _ => File_system::US3::US3_1,
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    };
                    let v997: string = padLeft(
                        toLower(match &v980 {
                            File_system::US3::US3_0(v980_0_0) => match &v980 {
                                File_system::US3::US3_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                            _ => panic!("{}", string("Option does not have a value."),),
                        }),
                        7_i32,
                        ' ',
                    );
                    let _v1029: MutCell<Option<string>> = MutCell::new(None::<string>);
                    let v1044: &str = match &v0 {
                        File_system::US0::US0_1 => inline_colorization::color_bright_blue,
                        File_system::US0::US0_2 => inline_colorization::color_bright_green,
                        File_system::US0::US0_0 => inline_colorization::color_bright_black,
                        File_system::US0::US0_3 => inline_colorization::color_yellow,
                        _ => inline_colorization::color_bright_red,
                    };
                    let v1046: &str = &*v997;
                    let v1048: &str = inline_colorization::color_reset;
                    let v1050: string = string("format!(\"{v1044}{v1046}{v1048}\")");
                    let v1051: std::string::String = format!("{v1044}{v1046}{v1048}");
                    {
                        let x_5: string = fable_library_rust::String_::fromString(v1051);
                        _v1029.set(Some(x_5))
                    }
                    {
                        let v1141: string = match &_v1029.get().clone() {
                            None => panic!("{}", string("base.run_target / _v1029=None"),),
                            Some(_v1029_0_0) => _v1029_0_0.clone(),
                        };
                        let v1160: i64 = (patternInput.0.clone()).l0.get().clone();
                        let v1163: LrcPtr<File_system::Mut4> = LrcPtr::new(File_system::Mut4 {
                            l0: MutCell::new(string("")),
                        });
                        File_system::method78(v1163.clone(), v2_1());
                        {
                            let v1164: string = v1163.l0.get().clone();
                            trimEndChars(
                                trimStartChars(
                                    sprintf!("{} {} #{} {} / {}", v772, v1141, v1160, v1(), v1164),
                                    toArray(empty::<char>()),
                                ),
                                toArray(ofArray(new_array(&[' ', '/']))),
                            )
                        }
                    }
                }
            }
        }
    }
    pub fn method77(v0: File_system::US0, v1: Func0<string>, v2_1: Func0<string>) {
        File_system::method17(
            v0.clone(),
            Func0::new({
                let v0 = v0.clone();
                let v1 = v1.clone();
                let v2_1 = v2_1.clone();
                move || File_system::closure64(v0.clone(), v1.clone(), v2_1.clone(), ())
            }),
        );
    }
    pub fn method79() -> string {
        let _v2: MutCell<Option<string>> = MutCell::new(None::<string>);
        let v4: Result<std::path::PathBuf, std::io::Error> = std::env::current_dir();
        let v6: std::path::PathBuf = v4.unwrap();
        let v8: std::path::Display = v6.display();
        let _v11: MutCell<Option<std::string::String>> = MutCell::new(None::<std::string::String>);
        {
            let x: std::string::String = format!("{}", v8);
            _v11.set(Some(x))
        }
        {
            let v45: std::string::String = match &_v11.get().clone() {
                None => panic!("{}", string("base.run_target / _v11=None"),),
                Some(_v11_0_0) => _v11_0_0.clone(),
            };
            {
                let x_2: string = fable_library_rust::String_::fromString(v45);
                _v2.set(Some(x_2))
            }
            match &_v2.get().clone() {
                None => panic!("{}", string("base.run_target / _v2=None"),),
                Some(_v2_0_0) => _v2_0_0.clone(),
            }
        }
    }
    pub fn closure60(unitVar: (), unitVar_1: ()) -> string {
        let v4: File_system::US13 = File_system::method73(
            File_system::method49(string("polyglot"), string(".devcontainer")),
            string("C:\\home\\git\\polyglot\\lib\\spiral"),
        );
        let v13_1: File_system::US3 = match &v4 {
            File_system::US13::US13_0(v4_0_0) => File_system::US3::US3_0(v4_0_0.clone()),
            File_system::US13::US13_1(v4_1_0) => {
                File_system::method77(
                    File_system::US0::US0_3,
                    Func0::new(move || File_system::closure62((), ())),
                    Func0::new({
                        let v4 = v4.clone();
                        move || {
                            File_system::closure63(
                                match &v4 {
                                    File_system::US13::US13_1(x) => x.clone(),
                                    _ => unreachable!(),
                                },
                                (),
                            )
                        }
                    }),
                );
                File_system::US3::US3_1
            }
        };
        let v29: File_system::US3 = match &v13_1 {
            File_system::US3::US3_0(v13_1_0_0) => File_system::US3::US3_0(match &v13_1 {
                File_system::US3::US3_0(x) => x.clone(),
                _ => unreachable!(),
            }),
            _ => {
                let v16_1: string = File_system::method79();
                let v18_1: File_system::US13 = File_system::method73(
                    File_system::method49(string("polyglot"), string(".devcontainer")),
                    v16_1,
                );
                match &v18_1 {
                    File_system::US13::US13_0(v18_1_0_0) => {
                        File_system::US3::US3_0(v18_1_0_0.clone())
                    }
                    File_system::US13::US13_1(v18_1_1_0) => {
                        File_system::method77(
                            File_system::US0::US0_3,
                            Func0::new(move || File_system::closure62((), ())),
                            Func0::new({
                                let v18_1 = v18_1.clone();
                                move || {
                                    File_system::closure63(
                                        match &v18_1 {
                                            File_system::US13::US13_1(x) => x.clone(),
                                            _ => unreachable!(),
                                        },
                                        (),
                                    )
                                }
                            }),
                        );
                        File_system::US3::US3_1
                    }
                }
            }
        };
        File_system::method49(
            match &v29 {
                File_system::US3::US3_0(v29_0_0) => match &v29 {
                    File_system::US3::US3_0(x) => x.clone(),
                    _ => unreachable!(),
                },
                _ => panic!("{}", string("Option does not have a value."),),
            },
            string("polyglot"),
        )
    }
    pub fn method80(v0: string) {
        let _v3: MutCell<Option<()>> = MutCell::new(None::<()>);
        _v3.set(Some(()));
        match &_v3.get().clone() {
            None => panic!("{}", string("base.run_target / _v3=None"),),
            Some(_v3_0_0) => _v3_0_0.clone(),
        }
        ()
    }
    pub fn closure66(unitVar: (), v0: string) {
        File_system::method80(v0);
    }
    pub fn closure65(unitVar: (), v0: bool) {
        if File_system::State::trace_state().get().clone().is_none() {
            File_system::State::trace_state()
                .set(Some(File_system::closure0((), File_system::US0::US0_0)));
        }
        {
            let patternInput: (
                LrcPtr<File_system::Mut0>,
                LrcPtr<File_system::Mut1>,
                LrcPtr<File_system::Mut2>,
                LrcPtr<File_system::Mut3>,
                Option<i64>,
            ) = getValue(File_system::State::trace_state().get().clone());
            let v33 = if v0 {
                Func1::new(move |v_1: string| File_system::closure66((), v_1))
            } else {
                Func1::new(move |v_2: string| File_system::closure1((), v_2))
            };
            (patternInput.1.clone()).l0.set(v33);
            ()
        }
    }
    pub fn closure68(v0: string, v1: string) -> string {
        File_system::method49(v0, v1)
    }
    pub fn closure67(unitVar: (), v0: string) -> Func1<string, string> {
        Func1::new({
            let v0 = v0.clone();
            move |v: string| File_system::closure68(v0.clone(), v)
        })
    }
    pub fn v2() -> Func1<
        File_system::US0,
        (
            LrcPtr<File_system::Mut0>,
            LrcPtr<File_system::Mut1>,
            LrcPtr<File_system::Mut2>,
            LrcPtr<File_system::Mut3>,
            Option<i64>,
        ),
    > {
        static v2: OnceInit<
            Func1<
                File_system::US0,
                (
                    LrcPtr<File_system::Mut0>,
                    LrcPtr<File_system::Mut1>,
                    LrcPtr<File_system::Mut2>,
                    LrcPtr<File_system::Mut3>,
                    Option<i64>,
                ),
            >,
        > = OnceInit::new();
        v2.get_or_init(|| Func1::new(move |v: File_system::US0| File_system::closure0((), v)))
            .clone()
    }
    pub fn v3() -> File_system::US0 {
        static v3: OnceInit<File_system::US0> = OnceInit::new();
        v3.get_or_init(|| File_system::US0::US0_0).clone()
    }
    on_startup!(
        if File_system::State::trace_state().get().clone().is_none() {
            File_system::State::trace_state().set(Some((File_system::v2())(File_system::v3())));
        }
    );
    pub fn v9() -> Func1<string, Arc<Async<i64>>> {
        static v9: OnceInit<Func1<string, Arc<Async<i64>>>> = OnceInit::new();
        v9.get_or_init(|| Func1::new(move |v: string| File_system::closure2((), v)))
            .clone()
    }
    pub fn delete_directory_async(x: string) -> Arc<Async<i64>> {
        (File_system::v9())(x)
    }
    pub fn v10() -> Func1<File_system::US6, Func1<string, Arc<Async<i64>>>> {
        static v10: OnceInit<Func1<File_system::US6, Func1<string, Arc<Async<i64>>>>> =
            OnceInit::new();
        v10.get_or_init(|| Func1::new(move |v: File_system::US6| File_system::closure6((), v)))
            .clone()
    }
    pub fn wait_for_file_access(x: File_system::US6) -> Func1<string, Arc<Async<i64>>> {
        (File_system::v10())(x)
    }
    pub fn v11() -> Func1<string, Arc<Async<i64>>> {
        static v11: OnceInit<Func1<string, Arc<Async<i64>>>> = OnceInit::new();
        v11.get_or_init(|| Func1::new(move |v: string| File_system::closure11((), v)))
            .clone()
    }
    pub fn wait_for_file_access_read(x: string) -> Arc<Async<i64>> {
        (File_system::v11())(x)
    }
    pub fn v12() -> Func1<string, Arc<Async<string>>> {
        static v12: OnceInit<Func1<string, Arc<Async<string>>>> = OnceInit::new();
        v12.get_or_init(|| Func1::new(move |v: string| File_system::closure12((), v)))
            .clone()
    }
    pub fn read_all_text_async(x: string) -> Arc<Async<string>> {
        (File_system::v12())(x)
    }
    pub fn v13() -> Func1<string, Func1<string, bool>> {
        static v13: OnceInit<Func1<string, Func1<string, bool>>> = OnceInit::new();
        v13.get_or_init(|| Func1::new(move |v: string| File_system::closure13((), v)))
            .clone()
    }
    pub fn file_exists_content(x: string) -> Func1<string, bool> {
        (File_system::v13())(x)
    }
    pub fn v14() -> Func1<string, Func1<string, Arc<Async<()>>>> {
        static v14: OnceInit<Func1<string, Func1<string, Arc<Async<()>>>>> = OnceInit::new();
        v14.get_or_init(|| Func1::new(move |v: string| File_system::closure15((), v)))
            .clone()
    }
    pub fn write_all_text_async(x: string) -> Func1<string, Arc<Async<()>>> {
        (File_system::v14())(x)
    }
    pub fn v15() -> Func1<string, Func1<string, Arc<Async<()>>>> {
        static v15: OnceInit<Func1<string, Func1<string, Arc<Async<()>>>>> = OnceInit::new();
        v15.get_or_init(|| Func1::new(move |v: string| File_system::closure17((), v)))
            .clone()
    }
    pub fn write_all_text_exists(x: string) -> Func1<string, Arc<Async<()>>> {
        (File_system::v15())(x)
    }
    pub fn v16() -> Func1<string, Arc<Async<i64>>> {
        static v16: OnceInit<Func1<string, Arc<Async<i64>>>> = OnceInit::new();
        v16.get_or_init(|| Func1::new(move |v: string| File_system::closure19((), v)))
            .clone()
    }
    pub fn delete_file_async(x: string) -> Arc<Async<i64>> {
        (File_system::v16())(x)
    }
    pub fn v17() -> Func1<string, Func1<string, Arc<Async<i64>>>> {
        static v17: OnceInit<Func1<string, Func1<string, Arc<Async<i64>>>>> = OnceInit::new();
        v17.get_or_init(|| Func1::new(move |v: string| File_system::closure23((), v)))
            .clone()
    }
    pub fn move_file_async(x: string) -> Func1<string, Arc<Async<i64>>> {
        (File_system::v17())(x)
    }
    pub fn v18() -> Func1<string, Arc<Async<Option<string>>>> {
        static v18: OnceInit<Func1<string, Arc<Async<Option<string>>>>> = OnceInit::new();
        v18.get_or_init(|| Func1::new(move |v: string| File_system::closure28((), v)))
            .clone()
    }
    pub fn read_all_text_retry_async(x: string) -> Arc<Async<Option<string>>> {
        (File_system::v18())(x)
    }
    pub fn v19() -> Func0<string> {
        static v19: OnceInit<Func0<string>> = OnceInit::new();
        v19.get_or_init(|| Func0::new(move || File_system::closure40((), ())))
            .clone()
    }
    pub fn create_temp_path() -> string {
        (File_system::v19())()
    }
    pub fn v20() -> Func0<(string, LrcPtr<dyn IDisposable>)> {
        static v20: OnceInit<Func0<(string, LrcPtr<dyn IDisposable>)>> = OnceInit::new();
        v20.get_or_init(|| Func0::new(move || File_system::closure41((), ())))
            .clone()
    }
    pub fn create_temp_dir() -> (string, LrcPtr<dyn IDisposable>) {
        (File_system::v20())()
    }
    pub fn v21() -> Func1<string, (string, LrcPtr<dyn IDisposable>)> {
        static v21: OnceInit<Func1<string, (string, LrcPtr<dyn IDisposable>)>> = OnceInit::new();
        v21.get_or_init(|| Func1::new(move |v: string| File_system::closure56((), v)))
            .clone()
    }
    pub fn create_temp_dir_(x: string) -> (string, LrcPtr<dyn IDisposable>) {
        (File_system::v21())(x)
    }
    pub fn v22() -> Func0<string> {
        static v22: OnceInit<Func0<string>> = OnceInit::new();
        v22.get_or_init(|| Func0::new(move || File_system::closure57((), ())))
            .clone()
    }
    pub fn get_source_directory() -> string {
        (File_system::v22())()
    }
    pub fn v23() -> Func1<string, string> {
        static v23: OnceInit<Func1<string, string>> = OnceInit::new();
        v23.get_or_init(|| Func1::new(move |v: string| File_system::closure58((), v)))
            .clone()
    }
    pub fn normalize_path(x: string) -> string {
        (File_system::v23())(x)
    }
    pub fn v24() -> Func1<string, string> {
        static v24: OnceInit<Func1<string, string>> = OnceInit::new();
        v24.get_or_init(|| Func1::new(move |v: string| File_system::closure59((), v)))
            .clone()
    }
    pub fn new_file_uri(x: string) -> string {
        (File_system::v24())(x)
    }
    pub fn v25() -> Func0<string> {
        static v25: OnceInit<Func0<string>> = OnceInit::new();
        v25.get_or_init(|| Func0::new(move || File_system::closure60((), ())))
            .clone()
    }
    pub fn get_workspace_root() -> string {
        (File_system::v25())()
    }
    pub fn v26() -> Func1<bool, ()> {
        static v26: OnceInit<Func1<bool, ()>> = OnceInit::new();
        v26.get_or_init(|| Func1::new(move |v: bool| File_system::closure65((), v)))
            .clone()
    }
    pub fn init_trace_file(x: bool) {
        (File_system::v26())(x);
    }
    pub fn v27() -> Func1<string, Func1<string, string>> {
        static v27: OnceInit<Func1<string, Func1<string, string>>> = OnceInit::new();
        v27.get_or_init(|| Func1::new(move |v: string| File_system::closure67((), v)))
            .clone()
    }
    pub fn op_LessDivideGreater(x: string) -> Func1<string, string> {
        (File_system::v27())(x)
    }
    on_startup!(());
}
