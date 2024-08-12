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
    #[derive(Clone, Debug, PartialEq, PartialOrd, Hash, Eq)]
    pub enum US1 {
        US1_0(string),
        US1_1,
    }
    impl core::fmt::Display for File_system::US1 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Copy, Debug, PartialEq, PartialOrd, Hash, Eq)]
    pub enum US2 {
        US2_0(File_system::US0),
        US2_1,
    }
    impl core::fmt::Display for File_system::US2 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Copy, Debug, PartialEq, PartialOrd, Hash, Eq)]
    pub enum US3 {
        US3_0(i64),
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
    pub fn method1() -> string {
        string("TRACE_LEVEL")
    }
    pub fn method3() -> string {
        string("")
    }
    pub fn closure1(
        v0_1: LrcPtr<MutCell<Option<File_system::US1>>>,
        v1_1: Option<File_system::US1>,
    ) -> LrcPtr<MutCell<Option<File_system::US1>>> {
        v0_1.set(v1_1);
        v0_1
    }
    pub fn closure2(
        v0_1: Option<string>,
        v1_1: Func1<Option<File_system::US1>, LrcPtr<MutCell<Option<File_system::US1>>>>,
        unitVar: (),
    ) {
        {
            let value: LrcPtr<MutCell<Option<File_system::US1>>> = v1_1(match &v0_1 {
                None => None::<File_system::US1>,
                Some(v0_1_0_0) => {
                    let x: string = v0_1_0_0.clone();
                    Some((Func0::new({
                        let x = x.clone();
                        move || File_system::US1::US1_0(x.clone())
                    }))())
                }
            });
            ()
        }
        ()
    }
    pub fn method2(v0_1: string) -> string {
        let v3: Result<std::string::String, std::env::VarError> = std::env::var(&*v0_1);
        let v5_1: bool = true;
        let _result = v3.map(|x| {
            //;
            let v7_1: std::string::String = x;
            let v9_1: string = fable_library_rust::String_::fromString(v7_1);
            let v11_1: bool = true;
            v9_1
        });
        let v13_1: Result<string, std::env::VarError> = _result;
        let v14_1: string = File_system::method3();
        v13_1.unwrap_or(v14_1)
    }
    pub fn method4() -> string {
        string("AUTOMATION")
    }
    pub fn closure3(unitVar: (), v0_1: string) {
        ();
    }
    pub fn method0(
        v0_1: File_system::US0,
    ) -> (
        LrcPtr<File_system::Mut0>,
        LrcPtr<File_system::Mut1>,
        LrcPtr<File_system::Mut2>,
        LrcPtr<File_system::Mut3>,
        Option<i64>,
    ) {
        let v3: string = File_system::method2(File_system::method1());
        let v8_1: File_system::US2 = if string("Verbose") == v3.clone() {
            File_system::US2::US2_0(File_system::US0::US0_0)
        } else {
            File_system::US2::US2_1
        };
        let _v1: (File_system::US2, File_system::US3) = (
            match &v8_1 {
                File_system::US2::US2_0(v8_1_0_0) => File_system::US2::US2_0(match &v8_1 {
                    File_system::US2::US2_0(x) => x.clone(),
                    _ => unreachable!(),
                }),
                _ => {
                    let v15_1: File_system::US2 = if string("Debug") == v3.clone() {
                        File_system::US2::US2_0(File_system::US0::US0_1)
                    } else {
                        File_system::US2::US2_1
                    };
                    match &v15_1 {
                        File_system::US2::US2_0(v15_1_0_0) => {
                            File_system::US2::US2_0(match &v15_1 {
                                File_system::US2::US2_0(x) => x.clone(),
                                _ => unreachable!(),
                            })
                        }
                        _ => {
                            let v22_1: File_system::US2 = if string("Info") == v3.clone() {
                                File_system::US2::US2_0(File_system::US0::US0_2)
                            } else {
                                File_system::US2::US2_1
                            };
                            match &v22_1 {
                                File_system::US2::US2_0(v22_1_0_0) => {
                                    File_system::US2::US2_0(match &v22_1 {
                                        File_system::US2::US2_0(x) => x.clone(),
                                        _ => unreachable!(),
                                    })
                                }
                                _ => {
                                    let v29: File_system::US2 = if string("Warning") == v3.clone() {
                                        File_system::US2::US2_0(File_system::US0::US0_3)
                                    } else {
                                        File_system::US2::US2_1
                                    };
                                    match &v29 {
                                        File_system::US2::US2_0(v29_0_0) => {
                                            File_system::US2::US2_0(match &v29 {
                                                File_system::US2::US2_0(x) => x.clone(),
                                                _ => unreachable!(),
                                            })
                                        }
                                        _ => {
                                            let v36: File_system::US2 =
                                                if string("Critical") == v3.clone() {
                                                    File_system::US2::US2_0(File_system::US0::US0_4)
                                                } else {
                                                    File_system::US2::US2_1
                                                };
                                            match &v36 {
                                                File_system::US2::US2_0(v36_0_0) => {
                                                    File_system::US2::US2_0(match &v36 {
                                                        File_system::US2::US2_0(x) => x.clone(),
                                                        _ => unreachable!(),
                                                    })
                                                }
                                                _ => File_system::US2::US2_1,
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            },
            if File_system::method2(File_system::method4()) == string("True") {
                File_system::US3::US3_0({
                    let _arg: DateTime = DateTime::now();
                    _arg.ticks()
                })
            } else {
                File_system::US3::US3_1
            },
        );
        let v295: File_system::US3 = _v1.1.clone();
        let v294: File_system::US2 = _v1.0.clone();
        (
            LrcPtr::new(File_system::Mut0 {
                l0: MutCell::new(0_i64),
            }),
            LrcPtr::new(File_system::Mut1 {
                l0: MutCell::new(Func1::new(move |v: string| File_system::closure3((), v))),
            }),
            LrcPtr::new(File_system::Mut2 {
                l0: MutCell::new(true),
            }),
            LrcPtr::new(File_system::Mut3 {
                l0: MutCell::new(match &v294 {
                    File_system::US2::US2_0(v294_0_0) => match &v294 {
                        File_system::US2::US2_0(x) => x.clone(),
                        _ => unreachable!(),
                    },
                    _ => v0_1,
                }),
            }),
            match &v295 {
                File_system::US3::US3_0(v295_0_0) => Some(match &v295 {
                    File_system::US3::US3_0(x) => x.clone(),
                    _ => unreachable!(),
                }),
                _ => None::<i64>,
            },
        )
    }
    pub fn closure0(unitVar: (), unitVar_1: ()) {
        if File_system::State::trace_state().get().clone().is_none() {
            let patternInput: (
                LrcPtr<File_system::Mut0>,
                LrcPtr<File_system::Mut1>,
                LrcPtr<File_system::Mut2>,
                LrcPtr<File_system::Mut3>,
                Option<i64>,
            ) = File_system::method0(File_system::US0::US0_0);
            File_system::State::trace_state().set(Some((
                patternInput.0.clone(),
                patternInput.1.clone(),
                patternInput.2.clone(),
                patternInput.3.clone(),
                patternInput.4.clone(),
            )));
            ()
        };
    }
    pub fn method7(v0_1: string) -> string {
        v0_1
    }
    pub fn method8(v0_1: string) -> bool {
        let v3: &str = &*v0_1;
        let v5_1: std::string::String = String::from(v3);
        let v7_1: std::path::PathBuf = std::path::PathBuf::from(v5_1);
        if v7_1.clone().exists() {
            true
        } else {
            if v7_1.clone().is_dir() {
                true
            } else {
                v7_1.is_symlink()
            }
        }
    }
    pub fn method6(v0_1: bool, v1_1: string) {
        let v3: string = File_system::method7(v1_1);
        if File_system::method8(v3.clone()) {
            if v0_1 {
                std::fs::remove_dir_all(&*v3.clone()).unwrap();
                ()
            } else {
                std::fs::remove_dir(&*v3).unwrap();
                ()
            };
        }
        ();
        ()
    }
    pub fn closure6(v0_1: LrcPtr<File_system::Mut0>, unitVar: ()) {
        let v2_1: i64 = v0_1.l0.get().clone() + 1_i64;
        v0_1.l0.set(v2_1);
        ()
    }
    pub fn closure7(
        v0_1: LrcPtr<MutCell<Option<File_system::US3>>>,
        v1_1: Option<File_system::US3>,
    ) -> LrcPtr<MutCell<Option<File_system::US3>>> {
        v0_1.set(v1_1);
        v0_1
    }
    pub fn closure8(
        v0_1: Option<i64>,
        v1_1: Func1<Option<File_system::US3>, LrcPtr<MutCell<Option<File_system::US3>>>>,
        unitVar: (),
    ) {
        {
            let value: LrcPtr<MutCell<Option<File_system::US3>>> = v1_1(match &v0_1 {
                None => None::<File_system::US3>,
                Some(v0_1_0_0) => {
                    let x: i64 = v0_1_0_0.clone();
                    Some((Func0::new({
                        let x = x.clone();
                        move || File_system::US3::US3_0(x)
                    }))())
                }
            });
            ()
        }
        ()
    }
    pub fn method9() -> string {
        string("hh:mm:ss")
    }
    pub fn method10() -> string {
        string("HH:mm:ss")
    }
    pub fn method11() -> string {
        string("\u{001b}[0m")
    }
    pub fn method12(v0_1: string) -> string {
        let v3: &str = &*v0_1;
        let v5_1: std::string::String = String::from(v3);
        let v7_1: std::path::PathBuf = std::path::PathBuf::from(v5_1);
        let v9_1: Option<&std::ffi::OsStr> = v7_1.file_name();
        let v11_1: &std::ffi::OsStr = v9_1.unwrap();
        let v13_1: std::ffi::OsString = v11_1.to_os_string();
        let v15_1: Option<&str> = v13_1.to_str();
        let v17_1: &str = v15_1.unwrap();
        let v19_1: std::string::String = String::from(v17_1);
        fable_library_rust::String_::fromString(v19_1)
    }
    pub fn method13() -> string {
        string("")
    }
    pub fn closure9(v0_1: LrcPtr<File_system::Mut4>, v1_1: string, unitVar: ()) {
        let v3: string = append(v0_1.l0.get().clone(), v1_1);
        v0_1.l0.set(v3);
        ()
    }
    pub fn closure10(unitVar: (), unitVar_1: ()) -> string {
        string("file_system.delete_directory_async")
    }
    pub fn closure5(v0_1: string, v1_1: string, unitVar: ()) {
        fn v3() {
            File_system::closure0((), ());
        }
        let v4: () = {
            v3();
            ()
        };
        let patternInput: (
            LrcPtr<File_system::Mut0>,
            LrcPtr<File_system::Mut1>,
            LrcPtr<File_system::Mut2>,
            LrcPtr<File_system::Mut3>,
            Option<i64>,
        ) = getValue(File_system::State::trace_state().get().clone());
        let v23_1: () = {
            v3();
            ()
        };
        let patternInput_1: (
            LrcPtr<File_system::Mut0>,
            LrcPtr<File_system::Mut1>,
            LrcPtr<File_system::Mut2>,
            LrcPtr<File_system::Mut3>,
            Option<i64>,
        ) = getValue(File_system::State::trace_state().get().clone());
        let v41: File_system::US0 = (patternInput_1.3.clone()).l0.get().clone();
        if if (patternInput_1.2.clone()).l0.get().clone() == false {
            false
        } else {
            1_i32
                >= find(
                    v41,
                    ofSeq(ofList(ofArray(new_array(&[
                        LrcPtr::new((File_system::US0::US0_0, 0_i32)),
                        LrcPtr::new((File_system::US0::US0_1, 1_i32)),
                        LrcPtr::new((File_system::US0::US0_2, 2_i32)),
                        LrcPtr::new((File_system::US0::US0_3, 3_i32)),
                        LrcPtr::new((File_system::US0::US0_4, 4_i32)),
                    ])))),
                )
        } {
            let v49: () = {
                File_system::closure6(patternInput.0.clone(), ());
                ()
            };
            let v51: () = {
                v3();
                ()
            };
            let patternInput_2: (
                LrcPtr<File_system::Mut0>,
                LrcPtr<File_system::Mut1>,
                LrcPtr<File_system::Mut2>,
                LrcPtr<File_system::Mut3>,
                Option<i64>,
            ) = getValue(File_system::State::trace_state().get().clone());
            let _v70: LrcPtr<MutCell<Option<File_system::US3>>> = refCell(None::<File_system::US3>);
            let v75: () = {
                File_system::closure8(
                    patternInput_2.4.clone(),
                    Func1::new({
                        let _v70 = _v70.clone();
                        move |v: Option<File_system::US3>| File_system::closure7(_v70.clone(), v)
                    }),
                    (),
                );
                ()
            };
            let v88: File_system::US3 = defaultValue(File_system::US3::US3_1, _v70.get().clone());
            let v128: DateTime = match &v88 {
                File_system::US3::US3_0(v88_0_0) => {
                    let v102: TimeSpan = TimeSpan::new_ticks(
                        {
                            let _arg: DateTime = DateTime::now();
                            _arg.ticks()
                        } - match &v88 {
                            File_system::US3::US3_0(x) => x.clone(),
                            _ => unreachable!(),
                        },
                    );
                    DateTime::new_ymdhms_milli(
                        1_i32,
                        1_i32,
                        1_i32,
                        v102.hours(),
                        v102.minutes(),
                        v102.seconds(),
                        v102.milliseconds(),
                    )
                }
                _ => DateTime::now(),
            };
            let v133: string = {
                let provider: string = File_system::method9();
                v128.toString(provider)
            };
            let v513: string = padLeft(toLower(string("Debug")), 7_i32, ' ');
            let v529: &str = inline_colorization::color_bright_blue;
            let v531: &str = &*v513;
            let v533: &str = inline_colorization::color_reset;
            let v535: string = string("format!(\"{v529}{v531}{v533}\")");
            let v536: std::string::String = format!("{v529}{v531}{v533}");
            let v538: string = fable_library_rust::String_::fromString(v536);
            let v579: i64 = (patternInput_2.0.clone()).l0.get().clone();
            let v580: string = File_system::method12(v0_1);
            let v582: LrcPtr<File_system::Mut4> = LrcPtr::new(File_system::Mut4 {
                l0: MutCell::new(File_system::method13()),
            });
            let v589: () = {
                File_system::closure9(v582.clone(), sprintf!("{}", string("{ ")), ());
                ()
            };
            let v596: () = {
                File_system::closure9(v582.clone(), sprintf!("{}", string("ex")), ());
                ()
            };
            let v603: () = {
                File_system::closure9(v582.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v609: () = {
                File_system::closure9(v582.clone(), sprintf!("{}", v1_1), ());
                ()
            };
            let v616: () = {
                File_system::closure9(v582.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v623: () = {
                File_system::closure9(v582.clone(), sprintf!("{}", string("path")), ());
                ()
            };
            let v629: () = {
                File_system::closure9(v582.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v635: () = {
                File_system::closure9(v582.clone(), sprintf!("{}", v580), ());
                ()
            };
            let v642: () = {
                File_system::closure9(v582.clone(), sprintf!("{}", string(" }")), ());
                ()
            };
            let v643: string = v582.l0.get().clone();
            let v682: string = trimEndChars(
                trimStartChars(
                    sprintf!(
                        "{} {} #{} {} / {}",
                        v133,
                        v538,
                        v579,
                        File_system::closure10((), ()),
                        v643
                    ),
                    toArray(empty::<char>()),
                ),
                toArray(ofArray(new_array(&[' ', '/']))),
            );
            println!("{}", v682.clone());
            ();
            ((patternInput.1.clone()).l0.get().clone())(v682)
        }
    }
    pub fn method5(v0_1: string, v1_1: i64) -> Arc<Async<i64>> {
        defaultOf()
    }
    pub fn closure4(unitVar: (), v0_1: string) -> Arc<Async<i64>> {
        defaultOf()
    }
    pub fn closure14(unitVar: (), unitVar_1: ()) -> string {
        string("file_system.wait_for_file_access")
    }
    pub fn closure13(v0_1: string, v1_1: i64, v2_1: string, unitVar: ()) {
        fn v4() {
            File_system::closure0((), ());
        }
        let v5_1: () = {
            v4();
            ()
        };
        let patternInput: (
            LrcPtr<File_system::Mut0>,
            LrcPtr<File_system::Mut1>,
            LrcPtr<File_system::Mut2>,
            LrcPtr<File_system::Mut3>,
            Option<i64>,
        ) = getValue(File_system::State::trace_state().get().clone());
        let v24: () = {
            v4();
            ()
        };
        let patternInput_1: (
            LrcPtr<File_system::Mut0>,
            LrcPtr<File_system::Mut1>,
            LrcPtr<File_system::Mut2>,
            LrcPtr<File_system::Mut3>,
            Option<i64>,
        ) = getValue(File_system::State::trace_state().get().clone());
        let v42: File_system::US0 = (patternInput_1.3.clone()).l0.get().clone();
        if if (patternInput_1.2.clone()).l0.get().clone() == false {
            false
        } else {
            1_i32
                >= find(
                    v42,
                    ofSeq(ofList(ofArray(new_array(&[
                        LrcPtr::new((File_system::US0::US0_0, 0_i32)),
                        LrcPtr::new((File_system::US0::US0_1, 1_i32)),
                        LrcPtr::new((File_system::US0::US0_2, 2_i32)),
                        LrcPtr::new((File_system::US0::US0_3, 3_i32)),
                        LrcPtr::new((File_system::US0::US0_4, 4_i32)),
                    ])))),
                )
        } {
            let v50: () = {
                File_system::closure6(patternInput.0.clone(), ());
                ()
            };
            let v52: () = {
                v4();
                ()
            };
            let patternInput_2: (
                LrcPtr<File_system::Mut0>,
                LrcPtr<File_system::Mut1>,
                LrcPtr<File_system::Mut2>,
                LrcPtr<File_system::Mut3>,
                Option<i64>,
            ) = getValue(File_system::State::trace_state().get().clone());
            let _v71: LrcPtr<MutCell<Option<File_system::US3>>> = refCell(None::<File_system::US3>);
            let v76: () = {
                File_system::closure8(
                    patternInput_2.4.clone(),
                    Func1::new({
                        let _v71 = _v71.clone();
                        move |v: Option<File_system::US3>| File_system::closure7(_v71.clone(), v)
                    }),
                    (),
                );
                ()
            };
            let v89: File_system::US3 = defaultValue(File_system::US3::US3_1, _v71.get().clone());
            let v129: DateTime = match &v89 {
                File_system::US3::US3_0(v89_0_0) => {
                    let v103: TimeSpan = TimeSpan::new_ticks(
                        {
                            let _arg: DateTime = DateTime::now();
                            _arg.ticks()
                        } - match &v89 {
                            File_system::US3::US3_0(x) => x.clone(),
                            _ => unreachable!(),
                        },
                    );
                    DateTime::new_ymdhms_milli(
                        1_i32,
                        1_i32,
                        1_i32,
                        v103.hours(),
                        v103.minutes(),
                        v103.seconds(),
                        v103.milliseconds(),
                    )
                }
                _ => DateTime::now(),
            };
            let v134: string = {
                let provider: string = File_system::method9();
                v129.toString(provider)
            };
            let v514: string = padLeft(toLower(string("Debug")), 7_i32, ' ');
            let v530: &str = inline_colorization::color_bright_blue;
            let v532: &str = &*v514;
            let v534: &str = inline_colorization::color_reset;
            let v536: string = string("format!(\"{v530}{v532}{v534}\")");
            let v537: std::string::String = format!("{v530}{v532}{v534}");
            let v539: string = fable_library_rust::String_::fromString(v537);
            let v580: i64 = (patternInput_2.0.clone()).l0.get().clone();
            let v581: string = File_system::method12(v0_1);
            let v583: LrcPtr<File_system::Mut4> = LrcPtr::new(File_system::Mut4 {
                l0: MutCell::new(File_system::method13()),
            });
            let v590: () = {
                File_system::closure9(v583.clone(), sprintf!("{}", string("{ ")), ());
                ()
            };
            let v597: () = {
                File_system::closure9(v583.clone(), sprintf!("{}", string("path")), ());
                ()
            };
            let v604: () = {
                File_system::closure9(v583.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v610: () = {
                File_system::closure9(v583.clone(), sprintf!("{}", v581), ());
                ()
            };
            let v617: () = {
                File_system::closure9(v583.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v624: () = {
                File_system::closure9(v583.clone(), sprintf!("{}", string("retry")), ());
                ()
            };
            let v630: () = {
                File_system::closure9(v583.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v636: () = {
                File_system::closure9(v583.clone(), sprintf!("{}", v1_1), ());
                ()
            };
            let v642: () = {
                File_system::closure9(v583.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v649: () = {
                File_system::closure9(v583.clone(), sprintf!("{}", string("ex")), ());
                ()
            };
            let v655: () = {
                File_system::closure9(v583.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v661: () = {
                File_system::closure9(v583.clone(), sprintf!("{}", v2_1), ());
                ()
            };
            let v668: () = {
                File_system::closure9(v583.clone(), sprintf!("{}", string(" }")), ());
                ()
            };
            let v669: string = v583.l0.get().clone();
            let v708: string = trimEndChars(
                trimStartChars(
                    sprintf!(
                        "{} {} #{} {} / {}",
                        v134,
                        v539,
                        v580,
                        File_system::closure14((), ()),
                        v669
                    ),
                    toArray(empty::<char>()),
                ),
                toArray(ofArray(new_array(&[' ', '/']))),
            );
            println!("{}", v708.clone());
            ();
            ((patternInput.1.clone()).l0.get().clone())(v708)
        }
    }
    pub fn method14(
        v0_1: string,
        v1_1: File_system::US8,
        v2_1: File_system::US7,
        v3: i64,
    ) -> Arc<Async<i64>> {
        defaultOf()
    }
    pub fn closure12(v0_1: File_system::US6, v1_1: string) -> Arc<Async<i64>> {
        defaultOf()
    }
    pub fn closure11(unitVar: (), v0_1: File_system::US6) -> Func1<string, Arc<Async<i64>>> {
        Func1::new({
            let v0_1 = v0_1.clone();
            move |v: string| File_system::closure12(v0_1.clone(), v)
        })
    }
    pub fn method15(v0_1: string, v1_1: i64) -> Arc<Async<i64>> {
        defaultOf()
    }
    pub fn closure15(unitVar: (), v0_1: string) -> Arc<Async<i64>> {
        defaultOf()
    }
    pub fn closure16(unitVar: (), v0_1: string) -> Arc<Async<string>> {
        defaultOf()
    }
    pub fn method17(v0_1: string) -> bool {
        let v3: &str = &*v0_1;
        let v5_1: std::string::String = String::from(v3);
        let v7_1: std::path::PathBuf = std::path::PathBuf::from(v5_1);
        if v7_1.clone().exists() {
            v7_1.is_file()
        } else {
            false
        }
    }
    pub fn method18(v0_1: Vec<u8>) -> Vec<u8> {
        v0_1
    }
    pub fn method16(v0_1: string, v1_1: string) -> bool {
        if File_system::method17(v0_1.clone()) == false {
            false
        } else {
            let v8_1: Result<Vec<u8>, std::io::Error> = std::fs::read(&*v0_1);
            let v31: Vec<u8> = File_system::method18(v8_1.unwrap());
            let v33: Result<std::string::String, std::string::FromUtf8Error> =
                std::string::String::from_utf8(v31);
            let v35: std::string::String = v33.unwrap();
            v1_1 == fable_library_rust::String_::fromString(v35)
        }
    }
    pub fn closure18(v0_1: string, v1_1: string) -> bool {
        File_system::method16(v0_1, v1_1)
    }
    pub fn closure17(unitVar: (), v0_1: string) -> Func1<string, bool> {
        Func1::new({
            let v0_1 = v0_1.clone();
            move |v: string| File_system::closure18(v0_1.clone(), v)
        })
    }
    pub fn closure20(v0_1: string, v1_1: string) -> Arc<Async<()>> {
        defaultOf()
    }
    pub fn closure19(unitVar: (), v0_1: string) -> Func1<string, Arc<Async<()>>> {
        Func1::new({
            let v0_1 = v0_1.clone();
            move |v: string| File_system::closure20(v0_1.clone(), v)
        })
    }
    pub fn closure22(v0_1: string, v1_1: string) -> Arc<Async<()>> {
        defaultOf()
    }
    pub fn closure21(unitVar: (), v0_1: string) -> Func1<string, Arc<Async<()>>> {
        Func1::new({
            let v0_1 = v0_1.clone();
            move |v: string| File_system::closure22(v0_1.clone(), v)
        })
    }
    pub fn closure25(unitVar: (), unitVar_1: ()) -> string {
        string("delete_file_async")
    }
    pub fn closure24(v0_1: string, v1_1: LrcPtr<Exception>, unitVar: ()) {
        fn v3() {
            File_system::closure0((), ());
        }
        let v4: () = {
            v3();
            ()
        };
        let patternInput: (
            LrcPtr<File_system::Mut0>,
            LrcPtr<File_system::Mut1>,
            LrcPtr<File_system::Mut2>,
            LrcPtr<File_system::Mut3>,
            Option<i64>,
        ) = getValue(File_system::State::trace_state().get().clone());
        let v23_1: () = {
            v3();
            ()
        };
        let patternInput_1: (
            LrcPtr<File_system::Mut0>,
            LrcPtr<File_system::Mut1>,
            LrcPtr<File_system::Mut2>,
            LrcPtr<File_system::Mut3>,
            Option<i64>,
        ) = getValue(File_system::State::trace_state().get().clone());
        let v41: File_system::US0 = (patternInput_1.3.clone()).l0.get().clone();
        if if (patternInput_1.2.clone()).l0.get().clone() == false {
            false
        } else {
            3_i32
                >= find(
                    v41,
                    ofSeq(ofList(ofArray(new_array(&[
                        LrcPtr::new((File_system::US0::US0_0, 0_i32)),
                        LrcPtr::new((File_system::US0::US0_1, 1_i32)),
                        LrcPtr::new((File_system::US0::US0_2, 2_i32)),
                        LrcPtr::new((File_system::US0::US0_3, 3_i32)),
                        LrcPtr::new((File_system::US0::US0_4, 4_i32)),
                    ])))),
                )
        } {
            let v49: () = {
                File_system::closure6(patternInput.0.clone(), ());
                ()
            };
            let v51: () = {
                v3();
                ()
            };
            let patternInput_2: (
                LrcPtr<File_system::Mut0>,
                LrcPtr<File_system::Mut1>,
                LrcPtr<File_system::Mut2>,
                LrcPtr<File_system::Mut3>,
                Option<i64>,
            ) = getValue(File_system::State::trace_state().get().clone());
            let _v70: LrcPtr<MutCell<Option<File_system::US3>>> = refCell(None::<File_system::US3>);
            let v75: () = {
                File_system::closure8(
                    patternInput_2.4.clone(),
                    Func1::new({
                        let _v70 = _v70.clone();
                        move |v: Option<File_system::US3>| File_system::closure7(_v70.clone(), v)
                    }),
                    (),
                );
                ()
            };
            let v88: File_system::US3 = defaultValue(File_system::US3::US3_1, _v70.get().clone());
            let v128: DateTime = match &v88 {
                File_system::US3::US3_0(v88_0_0) => {
                    let v102: TimeSpan = TimeSpan::new_ticks(
                        {
                            let _arg: DateTime = DateTime::now();
                            _arg.ticks()
                        } - match &v88 {
                            File_system::US3::US3_0(x) => x.clone(),
                            _ => unreachable!(),
                        },
                    );
                    DateTime::new_ymdhms_milli(
                        1_i32,
                        1_i32,
                        1_i32,
                        v102.hours(),
                        v102.minutes(),
                        v102.seconds(),
                        v102.milliseconds(),
                    )
                }
                _ => DateTime::now(),
            };
            let v133: string = {
                let provider: string = File_system::method9();
                v128.toString(provider)
            };
            let v513: string = padLeft(toLower(string("Warning")), 7_i32, ' ');
            let v529: &str = inline_colorization::color_yellow;
            let v531: &str = &*v513;
            let v533: &str = inline_colorization::color_reset;
            let v535: string = string("format!(\"{v529}{v531}{v533}\")");
            let v536: std::string::String = format!("{v529}{v531}{v533}");
            let v538: string = fable_library_rust::String_::fromString(v536);
            let v579: i64 = (patternInput_2.0.clone()).l0.get().clone();
            let v580: string = File_system::method12(v0_1);
            let v582: string = sprintf!("{:?}", v1_1);
            let v604: LrcPtr<File_system::Mut4> = LrcPtr::new(File_system::Mut4 {
                l0: MutCell::new(File_system::method13()),
            });
            let v611: () = {
                File_system::closure9(v604.clone(), sprintf!("{}", string("{ ")), ());
                ()
            };
            let v618: () = {
                File_system::closure9(v604.clone(), sprintf!("{}", string("path")), ());
                ()
            };
            let v625: () = {
                File_system::closure9(v604.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v631: () = {
                File_system::closure9(v604.clone(), sprintf!("{}", v580), ());
                ()
            };
            let v638: () = {
                File_system::closure9(v604.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v645: () = {
                File_system::closure9(v604.clone(), sprintf!("{}", string("ex")), ());
                ()
            };
            let v651: () = {
                File_system::closure9(v604.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v657: () = {
                File_system::closure9(v604.clone(), sprintf!("{}", v582), ());
                ()
            };
            let v664: () = {
                File_system::closure9(v604.clone(), sprintf!("{}", string(" }")), ());
                ()
            };
            let v665: string = v604.l0.get().clone();
            let v704: string = trimEndChars(
                trimStartChars(
                    sprintf!(
                        "{} {} #{} {} / {}",
                        v133,
                        v538,
                        v579,
                        File_system::closure25((), ()),
                        v665
                    ),
                    toArray(empty::<char>()),
                ),
                toArray(ofArray(new_array(&[' ', '/']))),
            );
            println!("{}", v704.clone());
            ();
            ((patternInput.1.clone()).l0.get().clone())(v704)
        }
    }
    pub fn method19(v0_1: string, v1_1: i64) -> Arc<Async<i64>> {
        defaultOf()
    }
    pub fn closure23(unitVar: (), v0_1: string) -> Arc<Async<i64>> {
        defaultOf()
    }
    pub fn closure29(unitVar: (), unitVar_1: ()) -> string {
        string("move_file_async")
    }
    pub fn closure28(v0_1: string, v1_1: string, v2_1: LrcPtr<Exception>, unitVar: ()) {
        fn v4() {
            File_system::closure0((), ());
        }
        let v5_1: () = {
            v4();
            ()
        };
        let patternInput: (
            LrcPtr<File_system::Mut0>,
            LrcPtr<File_system::Mut1>,
            LrcPtr<File_system::Mut2>,
            LrcPtr<File_system::Mut3>,
            Option<i64>,
        ) = getValue(File_system::State::trace_state().get().clone());
        let v24: () = {
            v4();
            ()
        };
        let patternInput_1: (
            LrcPtr<File_system::Mut0>,
            LrcPtr<File_system::Mut1>,
            LrcPtr<File_system::Mut2>,
            LrcPtr<File_system::Mut3>,
            Option<i64>,
        ) = getValue(File_system::State::trace_state().get().clone());
        let v42: File_system::US0 = (patternInput_1.3.clone()).l0.get().clone();
        if if (patternInput_1.2.clone()).l0.get().clone() == false {
            false
        } else {
            3_i32
                >= find(
                    v42,
                    ofSeq(ofList(ofArray(new_array(&[
                        LrcPtr::new((File_system::US0::US0_0, 0_i32)),
                        LrcPtr::new((File_system::US0::US0_1, 1_i32)),
                        LrcPtr::new((File_system::US0::US0_2, 2_i32)),
                        LrcPtr::new((File_system::US0::US0_3, 3_i32)),
                        LrcPtr::new((File_system::US0::US0_4, 4_i32)),
                    ])))),
                )
        } {
            let v50: () = {
                File_system::closure6(patternInput.0.clone(), ());
                ()
            };
            let v52: () = {
                v4();
                ()
            };
            let patternInput_2: (
                LrcPtr<File_system::Mut0>,
                LrcPtr<File_system::Mut1>,
                LrcPtr<File_system::Mut2>,
                LrcPtr<File_system::Mut3>,
                Option<i64>,
            ) = getValue(File_system::State::trace_state().get().clone());
            let _v71: LrcPtr<MutCell<Option<File_system::US3>>> = refCell(None::<File_system::US3>);
            let v76: () = {
                File_system::closure8(
                    patternInput_2.4.clone(),
                    Func1::new({
                        let _v71 = _v71.clone();
                        move |v: Option<File_system::US3>| File_system::closure7(_v71.clone(), v)
                    }),
                    (),
                );
                ()
            };
            let v89: File_system::US3 = defaultValue(File_system::US3::US3_1, _v71.get().clone());
            let v129: DateTime = match &v89 {
                File_system::US3::US3_0(v89_0_0) => {
                    let v103: TimeSpan = TimeSpan::new_ticks(
                        {
                            let _arg: DateTime = DateTime::now();
                            _arg.ticks()
                        } - match &v89 {
                            File_system::US3::US3_0(x) => x.clone(),
                            _ => unreachable!(),
                        },
                    );
                    DateTime::new_ymdhms_milli(
                        1_i32,
                        1_i32,
                        1_i32,
                        v103.hours(),
                        v103.minutes(),
                        v103.seconds(),
                        v103.milliseconds(),
                    )
                }
                _ => DateTime::now(),
            };
            let v134: string = {
                let provider: string = File_system::method9();
                v129.toString(provider)
            };
            let v514: string = padLeft(toLower(string("Warning")), 7_i32, ' ');
            let v530: &str = inline_colorization::color_yellow;
            let v532: &str = &*v514;
            let v534: &str = inline_colorization::color_reset;
            let v536: string = string("format!(\"{v530}{v532}{v534}\")");
            let v537: std::string::String = format!("{v530}{v532}{v534}");
            let v539: string = fable_library_rust::String_::fromString(v537);
            let v580: i64 = (patternInput_2.0.clone()).l0.get().clone();
            let v581: string = File_system::method12(v1_1);
            let v582: string = File_system::method12(v0_1);
            let v584: LrcPtr<File_system::Mut4> = LrcPtr::new(File_system::Mut4 {
                l0: MutCell::new(File_system::method13()),
            });
            let v591: () = {
                File_system::closure9(v584.clone(), sprintf!("{}", string("{ ")), ());
                ()
            };
            let v598: () = {
                File_system::closure9(v584.clone(), sprintf!("{}", string("old_path")), ());
                ()
            };
            let v605: () = {
                File_system::closure9(v584.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v611: () = {
                File_system::closure9(v584.clone(), sprintf!("{}", v581), ());
                ()
            };
            let v618: () = {
                File_system::closure9(v584.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v625: () = {
                File_system::closure9(v584.clone(), sprintf!("{}", string("new_path")), ());
                ()
            };
            let v631: () = {
                File_system::closure9(v584.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v637: () = {
                File_system::closure9(v584.clone(), sprintf!("{}", v582), ());
                ()
            };
            let v643: () = {
                File_system::closure9(v584.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v650: () = {
                File_system::closure9(v584.clone(), sprintf!("{}", string("ex")), ());
                ()
            };
            let v656: () = {
                File_system::closure9(v584.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v659: std::string::String = format!("{:#?}", v2_1);
            let v689: () = {
                File_system::closure9(
                    v584.clone(),
                    sprintf!("{}", fable_library_rust::String_::fromString(v659)),
                    (),
                );
                ()
            };
            let v696: () = {
                File_system::closure9(v584.clone(), sprintf!("{}", string(" }")), ());
                ()
            };
            let v697: string = v584.l0.get().clone();
            let v736: string = trimEndChars(
                trimStartChars(
                    sprintf!(
                        "{} {} #{} {} / {}",
                        v134,
                        v539,
                        v580,
                        File_system::closure29((), ()),
                        v697
                    ),
                    toArray(empty::<char>()),
                ),
                toArray(ofArray(new_array(&[' ', '/']))),
            );
            println!("{}", v736.clone());
            ();
            ((patternInput.1.clone()).l0.get().clone())(v736)
        }
    }
    pub fn method20(v0_1: string, v1_1: string, v2_1: i64) -> Arc<Async<i64>> {
        defaultOf()
    }
    pub fn closure27(v0_1: string, v1_1: string) -> Arc<Async<i64>> {
        defaultOf()
    }
    pub fn closure26(unitVar: (), v0_1: string) -> Func1<string, Arc<Async<i64>>> {
        Func1::new({
            let v0_1 = v0_1.clone();
            move |v: string| File_system::closure27(v0_1.clone(), v)
        })
    }
    pub fn closure31(unitVar: (), v0_1: i64) -> File_system::US9 {
        File_system::US9::US9_0(v0_1)
    }
    pub fn closure32(unitVar: (), v0_1: LrcPtr<Exception>) -> File_system::US9 {
        File_system::US9::US9_1(v0_1)
    }
    pub fn closure34(unitVar: (), unitVar_1: ()) -> string {
        string("async.run_with_timeout_async")
    }
    pub fn closure33(unitVar: (), unitVar_1: ()) {
        fn v1_1() {
            File_system::closure0((), ());
        }
        let v2_1: () = {
            v1_1();
            ()
        };
        let patternInput: (
            LrcPtr<File_system::Mut0>,
            LrcPtr<File_system::Mut1>,
            LrcPtr<File_system::Mut2>,
            LrcPtr<File_system::Mut3>,
            Option<i64>,
        ) = getValue(File_system::State::trace_state().get().clone());
        let v21_1: () = {
            v1_1();
            ()
        };
        let patternInput_1: (
            LrcPtr<File_system::Mut0>,
            LrcPtr<File_system::Mut1>,
            LrcPtr<File_system::Mut2>,
            LrcPtr<File_system::Mut3>,
            Option<i64>,
        ) = getValue(File_system::State::trace_state().get().clone());
        let v39: File_system::US0 = (patternInput_1.3.clone()).l0.get().clone();
        if if (patternInput_1.2.clone()).l0.get().clone() == false {
            false
        } else {
            0_i32
                >= find(
                    v39,
                    ofSeq(ofList(ofArray(new_array(&[
                        LrcPtr::new((File_system::US0::US0_0, 0_i32)),
                        LrcPtr::new((File_system::US0::US0_1, 1_i32)),
                        LrcPtr::new((File_system::US0::US0_2, 2_i32)),
                        LrcPtr::new((File_system::US0::US0_3, 3_i32)),
                        LrcPtr::new((File_system::US0::US0_4, 4_i32)),
                    ])))),
                )
        } {
            let v47: () = {
                File_system::closure6(patternInput.0.clone(), ());
                ()
            };
            let v49: () = {
                v1_1();
                ()
            };
            let patternInput_2: (
                LrcPtr<File_system::Mut0>,
                LrcPtr<File_system::Mut1>,
                LrcPtr<File_system::Mut2>,
                LrcPtr<File_system::Mut3>,
                Option<i64>,
            ) = getValue(File_system::State::trace_state().get().clone());
            let _v68: LrcPtr<MutCell<Option<File_system::US3>>> = refCell(None::<File_system::US3>);
            let v73: () = {
                File_system::closure8(
                    patternInput_2.4.clone(),
                    Func1::new({
                        let _v68 = _v68.clone();
                        move |v: Option<File_system::US3>| File_system::closure7(_v68.clone(), v)
                    }),
                    (),
                );
                ()
            };
            let v86: File_system::US3 = defaultValue(File_system::US3::US3_1, _v68.get().clone());
            let v126: DateTime = match &v86 {
                File_system::US3::US3_0(v86_0_0) => {
                    let v100: TimeSpan = TimeSpan::new_ticks(
                        {
                            let _arg: DateTime = DateTime::now();
                            _arg.ticks()
                        } - match &v86 {
                            File_system::US3::US3_0(x) => x.clone(),
                            _ => unreachable!(),
                        },
                    );
                    DateTime::new_ymdhms_milli(
                        1_i32,
                        1_i32,
                        1_i32,
                        v100.hours(),
                        v100.minutes(),
                        v100.seconds(),
                        v100.milliseconds(),
                    )
                }
                _ => DateTime::now(),
            };
            let v131: string = {
                let provider: string = File_system::method9();
                v126.toString(provider)
            };
            let v511: string = padLeft(toLower(string("Verbose")), 7_i32, ' ');
            let v527: &str = inline_colorization::color_bright_black;
            let v529: &str = &*v511;
            let v531: &str = inline_colorization::color_reset;
            let v533: string = string("format!(\"{v527}{v529}{v531}\")");
            let v534: std::string::String = format!("{v527}{v529}{v531}");
            let v536: string = fable_library_rust::String_::fromString(v534);
            let v577: i64 = (patternInput_2.0.clone()).l0.get().clone();
            let v579: LrcPtr<File_system::Mut4> = LrcPtr::new(File_system::Mut4 {
                l0: MutCell::new(File_system::method13()),
            });
            let v586: () = {
                File_system::closure9(v579.clone(), sprintf!("{}", string("{ ")), ());
                ()
            };
            let v593: () = {
                File_system::closure9(v579.clone(), sprintf!("{}", string("timeout")), ());
                ()
            };
            let v600: () = {
                File_system::closure9(v579.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v606: () = {
                File_system::closure9(v579.clone(), sprintf!("{}", 1000_i32), ());
                ()
            };
            let v613: () = {
                File_system::closure9(v579.clone(), sprintf!("{}", string(" }")), ());
                ()
            };
            let v614: string = v579.l0.get().clone();
            let v653: string = trimEndChars(
                trimStartChars(
                    sprintf!(
                        "{} {} #{} {} / {}",
                        v131,
                        v536,
                        v577,
                        File_system::closure34((), ()),
                        v614
                    ),
                    toArray(empty::<char>()),
                ),
                toArray(ofArray(new_array(&[' ', '/']))),
            );
            println!("{}", v653.clone());
            ();
            ((patternInput.1.clone()).l0.get().clone())(v653)
        }
    }
    pub fn closure36(unitVar: (), unitVar_1: ()) -> string {
        string("async.run_with_timeout_async**")
    }
    pub fn closure35(v0_1: LrcPtr<Exception>, unitVar: ()) {
        fn v2_1() {
            File_system::closure0((), ());
        }
        let v3: () = {
            v2_1();
            ()
        };
        let patternInput: (
            LrcPtr<File_system::Mut0>,
            LrcPtr<File_system::Mut1>,
            LrcPtr<File_system::Mut2>,
            LrcPtr<File_system::Mut3>,
            Option<i64>,
        ) = getValue(File_system::State::trace_state().get().clone());
        let v22_1: () = {
            v2_1();
            ()
        };
        let patternInput_1: (
            LrcPtr<File_system::Mut0>,
            LrcPtr<File_system::Mut1>,
            LrcPtr<File_system::Mut2>,
            LrcPtr<File_system::Mut3>,
            Option<i64>,
        ) = getValue(File_system::State::trace_state().get().clone());
        let v40: File_system::US0 = (patternInput_1.3.clone()).l0.get().clone();
        if if (patternInput_1.2.clone()).l0.get().clone() == false {
            false
        } else {
            4_i32
                >= find(
                    v40,
                    ofSeq(ofList(ofArray(new_array(&[
                        LrcPtr::new((File_system::US0::US0_0, 0_i32)),
                        LrcPtr::new((File_system::US0::US0_1, 1_i32)),
                        LrcPtr::new((File_system::US0::US0_2, 2_i32)),
                        LrcPtr::new((File_system::US0::US0_3, 3_i32)),
                        LrcPtr::new((File_system::US0::US0_4, 4_i32)),
                    ])))),
                )
        } {
            let v48: () = {
                File_system::closure6(patternInput.0.clone(), ());
                ()
            };
            let v50: () = {
                v2_1();
                ()
            };
            let patternInput_2: (
                LrcPtr<File_system::Mut0>,
                LrcPtr<File_system::Mut1>,
                LrcPtr<File_system::Mut2>,
                LrcPtr<File_system::Mut3>,
                Option<i64>,
            ) = getValue(File_system::State::trace_state().get().clone());
            let _v69: LrcPtr<MutCell<Option<File_system::US3>>> = refCell(None::<File_system::US3>);
            let v74: () = {
                File_system::closure8(
                    patternInput_2.4.clone(),
                    Func1::new({
                        let _v69 = _v69.clone();
                        move |v: Option<File_system::US3>| File_system::closure7(_v69.clone(), v)
                    }),
                    (),
                );
                ()
            };
            let v87: File_system::US3 = defaultValue(File_system::US3::US3_1, _v69.get().clone());
            let v127: DateTime = match &v87 {
                File_system::US3::US3_0(v87_0_0) => {
                    let v101: TimeSpan = TimeSpan::new_ticks(
                        {
                            let _arg: DateTime = DateTime::now();
                            _arg.ticks()
                        } - match &v87 {
                            File_system::US3::US3_0(x) => x.clone(),
                            _ => unreachable!(),
                        },
                    );
                    DateTime::new_ymdhms_milli(
                        1_i32,
                        1_i32,
                        1_i32,
                        v101.hours(),
                        v101.minutes(),
                        v101.seconds(),
                        v101.milliseconds(),
                    )
                }
                _ => DateTime::now(),
            };
            let v132: string = {
                let provider: string = File_system::method9();
                v127.toString(provider)
            };
            let v512: string = padLeft(toLower(string("Critical")), 7_i32, ' ');
            let v528: &str = inline_colorization::color_bright_red;
            let v530: &str = &*v512;
            let v532: &str = inline_colorization::color_reset;
            let v534: string = string("format!(\"{v528}{v530}{v532}\")");
            let v535: std::string::String = format!("{v528}{v530}{v532}");
            let v537: string = fable_library_rust::String_::fromString(v535);
            let v578: i64 = (patternInput_2.0.clone()).l0.get().clone();
            let v580: string = sprintf!("{:?}", v0_1);
            let v602: LrcPtr<File_system::Mut4> = LrcPtr::new(File_system::Mut4 {
                l0: MutCell::new(File_system::method13()),
            });
            let v609: () = {
                File_system::closure9(v602.clone(), sprintf!("{}", string("{ ")), ());
                ()
            };
            let v616: () = {
                File_system::closure9(v602.clone(), sprintf!("{}", string("timeout")), ());
                ()
            };
            let v623: () = {
                File_system::closure9(v602.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v629: () = {
                File_system::closure9(v602.clone(), sprintf!("{}", 1000_i32), ());
                ()
            };
            let v636: () = {
                File_system::closure9(v602.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v643: () = {
                File_system::closure9(v602.clone(), sprintf!("{}", string("ex")), ());
                ()
            };
            let v649: () = {
                File_system::closure9(v602.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v655: () = {
                File_system::closure9(v602.clone(), sprintf!("{}", v580), ());
                ()
            };
            let v662: () = {
                File_system::closure9(v602.clone(), sprintf!("{}", string(" }")), ());
                ()
            };
            let v663: string = v602.l0.get().clone();
            let v702: string = trimEndChars(
                trimStartChars(
                    sprintf!(
                        "{} {} #{} {} / {}",
                        v132,
                        v537,
                        v578,
                        File_system::closure36((), ()),
                        v663
                    ),
                    toArray(empty::<char>()),
                ),
                toArray(ofArray(new_array(&[' ', '/']))),
            );
            println!("{}", v702.clone());
            ();
            ((patternInput.1.clone()).l0.get().clone())(v702)
        }
    }
    pub fn closure38(unitVar: (), unitVar_1: ()) -> string {
        string("read_all_text_retry_async")
    }
    pub fn closure37(v0_1: i64, v1_1: string, unitVar: ()) {
        fn v3() {
            File_system::closure0((), ());
        }
        let v4: () = {
            v3();
            ()
        };
        let patternInput: (
            LrcPtr<File_system::Mut0>,
            LrcPtr<File_system::Mut1>,
            LrcPtr<File_system::Mut2>,
            LrcPtr<File_system::Mut3>,
            Option<i64>,
        ) = getValue(File_system::State::trace_state().get().clone());
        let v23_1: () = {
            v3();
            ()
        };
        let patternInput_1: (
            LrcPtr<File_system::Mut0>,
            LrcPtr<File_system::Mut1>,
            LrcPtr<File_system::Mut2>,
            LrcPtr<File_system::Mut3>,
            Option<i64>,
        ) = getValue(File_system::State::trace_state().get().clone());
        let v41: File_system::US0 = (patternInput_1.3.clone()).l0.get().clone();
        if if (patternInput_1.2.clone()).l0.get().clone() == false {
            false
        } else {
            1_i32
                >= find(
                    v41,
                    ofSeq(ofList(ofArray(new_array(&[
                        LrcPtr::new((File_system::US0::US0_0, 0_i32)),
                        LrcPtr::new((File_system::US0::US0_1, 1_i32)),
                        LrcPtr::new((File_system::US0::US0_2, 2_i32)),
                        LrcPtr::new((File_system::US0::US0_3, 3_i32)),
                        LrcPtr::new((File_system::US0::US0_4, 4_i32)),
                    ])))),
                )
        } {
            let v49: () = {
                File_system::closure6(patternInput.0.clone(), ());
                ()
            };
            let v51: () = {
                v3();
                ()
            };
            let patternInput_2: (
                LrcPtr<File_system::Mut0>,
                LrcPtr<File_system::Mut1>,
                LrcPtr<File_system::Mut2>,
                LrcPtr<File_system::Mut3>,
                Option<i64>,
            ) = getValue(File_system::State::trace_state().get().clone());
            let _v70: LrcPtr<MutCell<Option<File_system::US3>>> = refCell(None::<File_system::US3>);
            let v75: () = {
                File_system::closure8(
                    patternInput_2.4.clone(),
                    Func1::new({
                        let _v70 = _v70.clone();
                        move |v: Option<File_system::US3>| File_system::closure7(_v70.clone(), v)
                    }),
                    (),
                );
                ()
            };
            let v88: File_system::US3 = defaultValue(File_system::US3::US3_1, _v70.get().clone());
            let v128: DateTime = match &v88 {
                File_system::US3::US3_0(v88_0_0) => {
                    let v102: TimeSpan = TimeSpan::new_ticks(
                        {
                            let _arg: DateTime = DateTime::now();
                            _arg.ticks()
                        } - match &v88 {
                            File_system::US3::US3_0(x) => x.clone(),
                            _ => unreachable!(),
                        },
                    );
                    DateTime::new_ymdhms_milli(
                        1_i32,
                        1_i32,
                        1_i32,
                        v102.hours(),
                        v102.minutes(),
                        v102.seconds(),
                        v102.milliseconds(),
                    )
                }
                _ => DateTime::now(),
            };
            let v133: string = {
                let provider: string = File_system::method9();
                v128.toString(provider)
            };
            let v513: string = padLeft(toLower(string("Debug")), 7_i32, ' ');
            let v529: &str = inline_colorization::color_bright_blue;
            let v531: &str = &*v513;
            let v533: &str = inline_colorization::color_reset;
            let v535: string = string("format!(\"{v529}{v531}{v533}\")");
            let v536: std::string::String = format!("{v529}{v531}{v533}");
            let v538: string = fable_library_rust::String_::fromString(v536);
            let v579: i64 = (patternInput_2.0.clone()).l0.get().clone();
            let v581: LrcPtr<File_system::Mut4> = LrcPtr::new(File_system::Mut4 {
                l0: MutCell::new(File_system::method13()),
            });
            let v588: () = {
                File_system::closure9(v581.clone(), sprintf!("{}", string("{ ")), ());
                ()
            };
            let v595: () = {
                File_system::closure9(v581.clone(), sprintf!("{}", string("retry")), ());
                ()
            };
            let v602: () = {
                File_system::closure9(v581.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v608: () = {
                File_system::closure9(v581.clone(), sprintf!("{}", v0_1), ());
                ()
            };
            let v615: () = {
                File_system::closure9(v581.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v622: () = {
                File_system::closure9(v581.clone(), sprintf!("{}", string("ex")), ());
                ()
            };
            let v628: () = {
                File_system::closure9(v581.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v634: () = {
                File_system::closure9(v581.clone(), sprintf!("{}", v1_1), ());
                ()
            };
            let v641: () = {
                File_system::closure9(v581.clone(), sprintf!("{}", string(" }")), ());
                ()
            };
            let v642: string = v581.l0.get().clone();
            let v681: string = trimEndChars(
                trimStartChars(
                    sprintf!(
                        "{} {} #{} {} / {}",
                        v133,
                        v538,
                        v579,
                        File_system::closure38((), ()),
                        v642
                    ),
                    toArray(empty::<char>()),
                ),
                toArray(ofArray(new_array(&[' ', '/']))),
            );
            println!("{}", v681.clone());
            ();
            ((patternInput.1.clone()).l0.get().clone())(v681)
        }
    }
    pub fn method21(v0_1: string, v1_1: i64) -> Arc<Async<Option<string>>> {
        defaultOf()
    }
    pub fn closure30(unitVar: (), v0_1: string) -> Arc<Async<Option<string>>> {
        defaultOf()
    }
    pub fn closure40(
        v0_1: LrcPtr<MutCell<Option<File_system::US11>>>,
        v1_1: Option<File_system::US11>,
    ) -> LrcPtr<MutCell<Option<File_system::US11>>> {
        v0_1.set(v1_1);
        v0_1
    }
    pub fn closure41(
        v0_1: Option<chrono::DateTime<chrono::Utc>>,
        v1_1: Func1<Option<File_system::US11>, LrcPtr<MutCell<Option<File_system::US11>>>>,
        unitVar: (),
    ) {
        {
            let value: LrcPtr<MutCell<Option<File_system::US11>>> = v1_1(match &v0_1 {
                None => None::<File_system::US11>,
                Some(v0_1_0_0) => {
                    let x: chrono::DateTime<chrono::Utc> = v0_1_0_0.clone();
                    Some((Func0::new({
                        let x = x.clone();
                        move || File_system::US11::US11_0(x.clone())
                    }))())
                }
            });
            ()
        }
        ()
    }
    pub fn method24() -> string {
        string("hh:mm")
    }
    pub fn method25() -> string {
        string("yyyyMMdd-HHmm-ssff-ffff-f")
    }
    pub fn method26() -> string {
        string("hhmm")
    }
    pub fn method23(v0_1: Guid, v1_1: DateTime) -> Guid {
        let v7_1: DateTime = {
            let _arg: DateTime =
                DateTime::new_ymdhms_kind(1970_i32, 1_i32, 1_i32, 0_i32, 0_i32, 0_i32, 1_i32);
            _arg.toUniversalTime()
        };
        let v25: i64 = ({
            let _arg_2: DateTime = {
                let _arg_1: DateTime = DateTime::specifyKind(v1_1, 2_i32);
                _arg_1.toUniversalTime()
            };
            _arg_2.ticks()
        } - v7_1.ticks())
            / 10_i64;
        let v27: Option<chrono::DateTime<chrono::Utc>> =
            chrono::DateTime::from_timestamp_micros(v25);
        let _v28: LrcPtr<MutCell<Option<File_system::US11>>> = refCell(None::<File_system::US11>);
        let v33: () = {
            File_system::closure41(
                v27,
                Func1::new({
                    let _v28 = _v28.clone();
                    move |v: Option<File_system::US11>| File_system::closure40(_v28.clone(), v)
                }),
                (),
            );
            ()
        };
        let v46: File_system::US11 = defaultValue(File_system::US11::US11_1, _v28.get().clone());
        let v66: File_system::US1 = match &v46 {
            File_system::US11::US11_0(v46_0_0) => {
                let v52: chrono::NaiveDateTime = match &v46 {
                    File_system::US11::US11_0(x) => x.clone(),
                    _ => unreachable!(),
                }
                .naive_utc();
                let v54: chrono::DateTime<chrono::Local> =
                    chrono::offset::TimeZone::from_utc_datetime(&chrono::Local, &v52);
                let v56: string = string("r#\"%Y%m%d-%H%M-%S%f\"#");
                let v57: &str = r#"%Y%m%d-%H%M-%S%f"#;
                let v59: std::string::String = v54.format(v57).to_string();
                let v61: string = fable_library_rust::String_::fromString(v59);
                File_system::US1::US1_0(sprintf!(
                    "{}-{}-{}",
                    getSlice(v61.clone(), Some(0_i32), Some(17_i32)),
                    getSlice(v61.clone(), Some(18_i32), Some(21_i32)),
                    getCharAt(v61, 22_i32)
                ))
            }
            _ => File_system::US1::US1_1,
        };
        let v70: string = match &v66 {
            File_system::US1::US1_0(v66_0_0) => match &v66 {
                File_system::US1::US1_0(x) => x.clone(),
                _ => unreachable!(),
            },
            _ => string(""),
        };
        let v73: LrcPtr<TimeZoneInfo> = 0i64.into();
        let v148: u8 = if zero.hours() > 0_i32 { 1_u8 } else { 0_u8 };
        let v149: string = File_system::method24();
        let v157: string = zero.to_string(v149);
        let v160: string = sprintf!(
            "{}{}{}",
            v148,
            getSlice(v157.clone(), Some(0_i32), Some(1_i32)),
            getSlice(v157, Some(3_i32), Some(4_i32))
        );
        parse(sprintf!(
            "{}{}{}",
            v70.clone(),
            v160.clone(),
            getSlice(
                toString(v0_1),
                Some(length(v70) + length(v160)),
                None::<i32>
            )
        ))
    }
    pub fn method28() -> string {
        let v2_1: std::path::PathBuf = std::env::temp_dir();
        let v4: std::path::Display = v2_1.display();
        let v7_1: std::string::String = format!("{}", v4);
        fable_library_rust::String_::fromString(v7_1)
    }
    pub fn method29() -> string {
        string("!create_temp_path_")
    }
    pub fn method32(v0_1: string) -> string {
        v0_1
    }
    pub fn method31(v0_1: string, v1_1: string) -> (string, string) {
        (v1_1, File_system::method32(v0_1))
    }
    pub fn method30(v0_1: string, v1_1: string) -> string {
        let v4: &str = &*v0_1;
        let v6_1: std::string::String = String::from(v4);
        let v8_1: std::path::PathBuf = std::path::PathBuf::from(v6_1);
        let v10_1: &str = &*v1_1;
        let v12_1: std::string::String = String::from(v10_1);
        let v14_1: std::path::PathBuf = v8_1.join(v12_1);
        let v16_1: std::path::Display = v14_1.display();
        let v19_1: std::string::String = format!("{}", v16_1);
        fable_library_rust::String_::fromString(v19_1)
    }
    pub fn method34() -> string {
        string("CARGO_PKG_NAME")
    }
    pub fn method33() -> string {
        File_system::method2(File_system::method34())
    }
    pub fn method27(v0_1: Guid) -> string {
        File_system::method30(
            File_system::method30(
                File_system::method30(File_system::method28(), File_system::method29()),
                File_system::method33(),
            ),
            toString(v0_1),
        )
    }
    pub fn method22() -> string {
        let v1_1: DateTime = DateTime::now();
        File_system::method27(File_system::method23(new_guid(), v1_1))
    }
    pub fn closure39(unitVar: (), unitVar_1: ()) -> string {
        File_system::method22()
    }
    pub fn method36(v0_1: string) -> string {
        v0_1
    }
    pub fn closure43(unitVar: (), v0_1: std::io::Error) -> std::string::String {
        format!("{}", v0_1)
    }
    pub fn method37() -> Func1<std::io::Error, std::string::String> {
        Func1::new(move |v: std::io::Error| File_system::closure43((), v))
    }
    pub fn closure44(unitVar: (), unitVar_1: ()) -> File_system::US12 {
        File_system::US12::US12_0
    }
    pub fn closure45(unitVar: (), v0_1: std::string::String) -> File_system::US12 {
        File_system::US12::US12_1(v0_1)
    }
    pub fn closure47(unitVar: (), unitVar_1: ()) -> string {
        string("file_system.create_dir")
    }
    pub fn closure46(v0_1: string, v1_1: std::string::String, unitVar: ()) {
        fn v3() {
            File_system::closure0((), ());
        }
        let v4: () = {
            v3();
            ()
        };
        let patternInput: (
            LrcPtr<File_system::Mut0>,
            LrcPtr<File_system::Mut1>,
            LrcPtr<File_system::Mut2>,
            LrcPtr<File_system::Mut3>,
            Option<i64>,
        ) = getValue(File_system::State::trace_state().get().clone());
        let v23_1: () = {
            v3();
            ()
        };
        let patternInput_1: (
            LrcPtr<File_system::Mut0>,
            LrcPtr<File_system::Mut1>,
            LrcPtr<File_system::Mut2>,
            LrcPtr<File_system::Mut3>,
            Option<i64>,
        ) = getValue(File_system::State::trace_state().get().clone());
        let v41: File_system::US0 = (patternInput_1.3.clone()).l0.get().clone();
        if if (patternInput_1.2.clone()).l0.get().clone() == false {
            false
        } else {
            4_i32
                >= find(
                    v41,
                    ofSeq(ofList(ofArray(new_array(&[
                        LrcPtr::new((File_system::US0::US0_0, 0_i32)),
                        LrcPtr::new((File_system::US0::US0_1, 1_i32)),
                        LrcPtr::new((File_system::US0::US0_2, 2_i32)),
                        LrcPtr::new((File_system::US0::US0_3, 3_i32)),
                        LrcPtr::new((File_system::US0::US0_4, 4_i32)),
                    ])))),
                )
        } {
            let v49: () = {
                File_system::closure6(patternInput.0.clone(), ());
                ()
            };
            let v51: () = {
                v3();
                ()
            };
            let patternInput_2: (
                LrcPtr<File_system::Mut0>,
                LrcPtr<File_system::Mut1>,
                LrcPtr<File_system::Mut2>,
                LrcPtr<File_system::Mut3>,
                Option<i64>,
            ) = getValue(File_system::State::trace_state().get().clone());
            let _v70: LrcPtr<MutCell<Option<File_system::US3>>> = refCell(None::<File_system::US3>);
            let v75: () = {
                File_system::closure8(
                    patternInput_2.4.clone(),
                    Func1::new({
                        let _v70 = _v70.clone();
                        move |v: Option<File_system::US3>| File_system::closure7(_v70.clone(), v)
                    }),
                    (),
                );
                ()
            };
            let v88: File_system::US3 = defaultValue(File_system::US3::US3_1, _v70.get().clone());
            let v128: DateTime = match &v88 {
                File_system::US3::US3_0(v88_0_0) => {
                    let v102: TimeSpan = TimeSpan::new_ticks(
                        {
                            let _arg: DateTime = DateTime::now();
                            _arg.ticks()
                        } - match &v88 {
                            File_system::US3::US3_0(x) => x.clone(),
                            _ => unreachable!(),
                        },
                    );
                    DateTime::new_ymdhms_milli(
                        1_i32,
                        1_i32,
                        1_i32,
                        v102.hours(),
                        v102.minutes(),
                        v102.seconds(),
                        v102.milliseconds(),
                    )
                }
                _ => DateTime::now(),
            };
            let v133: string = {
                let provider: string = File_system::method9();
                v128.toString(provider)
            };
            let v513: string = padLeft(toLower(string("Critical")), 7_i32, ' ');
            let v529: &str = inline_colorization::color_bright_red;
            let v531: &str = &*v513;
            let v533: &str = inline_colorization::color_reset;
            let v535: string = string("format!(\"{v529}{v531}{v533}\")");
            let v536: std::string::String = format!("{v529}{v531}{v533}");
            let v538: string = fable_library_rust::String_::fromString(v536);
            let v579: i64 = (patternInput_2.0.clone()).l0.get().clone();
            let v581: LrcPtr<File_system::Mut4> = LrcPtr::new(File_system::Mut4 {
                l0: MutCell::new(File_system::method13()),
            });
            let v588: () = {
                File_system::closure9(v581.clone(), sprintf!("{}", string("{ ")), ());
                ()
            };
            let v595: () = {
                File_system::closure9(v581.clone(), sprintf!("{}", string("dir")), ());
                ()
            };
            let v602: () = {
                File_system::closure9(v581.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v608: () = {
                File_system::closure9(v581.clone(), sprintf!("{}", v0_1), ());
                ()
            };
            let v615: () = {
                File_system::closure9(v581.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v622: () = {
                File_system::closure9(v581.clone(), sprintf!("{}", string("error")), ());
                ()
            };
            let v628: () = {
                File_system::closure9(v581.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v631: std::string::String = format!("{:#?}", v1_1);
            let v661: () = {
                File_system::closure9(
                    v581.clone(),
                    sprintf!("{}", fable_library_rust::String_::fromString(v631)),
                    (),
                );
                ()
            };
            let v668: () = {
                File_system::closure9(v581.clone(), sprintf!("{}", string(" }")), ());
                ()
            };
            let v669: string = v581.l0.get().clone();
            let v708: string = trimEndChars(
                trimStartChars(
                    sprintf!(
                        "{} {} #{} {} / {}",
                        v133,
                        v538,
                        v579,
                        File_system::closure47((), ()),
                        v669
                    ),
                    toArray(empty::<char>()),
                ),
                toArray(ofArray(new_array(&[' ', '/']))),
            );
            println!("{}", v708.clone());
            ();
            ((patternInput.1.clone()).l0.get().clone())(v708)
        }
    }
    pub fn closure49(unitVar: (), unitVar_1: ()) -> string {
        string("file_system.create_dir")
    }
    pub fn closure48(v0_1: string, unitVar: ()) {
        fn v2_1() {
            File_system::closure0((), ());
        }
        let v3: () = {
            v2_1();
            ()
        };
        let patternInput: (
            LrcPtr<File_system::Mut0>,
            LrcPtr<File_system::Mut1>,
            LrcPtr<File_system::Mut2>,
            LrcPtr<File_system::Mut3>,
            Option<i64>,
        ) = getValue(File_system::State::trace_state().get().clone());
        let v22_1: () = {
            v2_1();
            ()
        };
        let patternInput_1: (
            LrcPtr<File_system::Mut0>,
            LrcPtr<File_system::Mut1>,
            LrcPtr<File_system::Mut2>,
            LrcPtr<File_system::Mut3>,
            Option<i64>,
        ) = getValue(File_system::State::trace_state().get().clone());
        let v40: File_system::US0 = (patternInput_1.3.clone()).l0.get().clone();
        if if (patternInput_1.2.clone()).l0.get().clone() == false {
            false
        } else {
            0_i32
                >= find(
                    v40,
                    ofSeq(ofList(ofArray(new_array(&[
                        LrcPtr::new((File_system::US0::US0_0, 0_i32)),
                        LrcPtr::new((File_system::US0::US0_1, 1_i32)),
                        LrcPtr::new((File_system::US0::US0_2, 2_i32)),
                        LrcPtr::new((File_system::US0::US0_3, 3_i32)),
                        LrcPtr::new((File_system::US0::US0_4, 4_i32)),
                    ])))),
                )
        } {
            let v48: () = {
                File_system::closure6(patternInput.0.clone(), ());
                ()
            };
            let v50: () = {
                v2_1();
                ()
            };
            let patternInput_2: (
                LrcPtr<File_system::Mut0>,
                LrcPtr<File_system::Mut1>,
                LrcPtr<File_system::Mut2>,
                LrcPtr<File_system::Mut3>,
                Option<i64>,
            ) = getValue(File_system::State::trace_state().get().clone());
            let _v69: LrcPtr<MutCell<Option<File_system::US3>>> = refCell(None::<File_system::US3>);
            let v74: () = {
                File_system::closure8(
                    patternInput_2.4.clone(),
                    Func1::new({
                        let _v69 = _v69.clone();
                        move |v: Option<File_system::US3>| File_system::closure7(_v69.clone(), v)
                    }),
                    (),
                );
                ()
            };
            let v87: File_system::US3 = defaultValue(File_system::US3::US3_1, _v69.get().clone());
            let v127: DateTime = match &v87 {
                File_system::US3::US3_0(v87_0_0) => {
                    let v101: TimeSpan = TimeSpan::new_ticks(
                        {
                            let _arg: DateTime = DateTime::now();
                            _arg.ticks()
                        } - match &v87 {
                            File_system::US3::US3_0(x) => x.clone(),
                            _ => unreachable!(),
                        },
                    );
                    DateTime::new_ymdhms_milli(
                        1_i32,
                        1_i32,
                        1_i32,
                        v101.hours(),
                        v101.minutes(),
                        v101.seconds(),
                        v101.milliseconds(),
                    )
                }
                _ => DateTime::now(),
            };
            let v132: string = {
                let provider: string = File_system::method9();
                v127.toString(provider)
            };
            let v512: string = padLeft(toLower(string("Verbose")), 7_i32, ' ');
            let v528: &str = inline_colorization::color_bright_black;
            let v530: &str = &*v512;
            let v532: &str = inline_colorization::color_reset;
            let v534: string = string("format!(\"{v528}{v530}{v532}\")");
            let v535: std::string::String = format!("{v528}{v530}{v532}");
            let v537: string = fable_library_rust::String_::fromString(v535);
            let v578: i64 = (patternInput_2.0.clone()).l0.get().clone();
            let v580: LrcPtr<File_system::Mut4> = LrcPtr::new(File_system::Mut4 {
                l0: MutCell::new(File_system::method13()),
            });
            let v587: () = {
                File_system::closure9(v580.clone(), sprintf!("{}", string("{ ")), ());
                ()
            };
            let v594: () = {
                File_system::closure9(v580.clone(), sprintf!("{}", string("dir")), ());
                ()
            };
            let v601: () = {
                File_system::closure9(v580.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v607: () = {
                File_system::closure9(v580.clone(), sprintf!("{}", v0_1), ());
                ()
            };
            let v614: () = {
                File_system::closure9(v580.clone(), sprintf!("{}", string(" }")), ());
                ()
            };
            let v615: string = v580.l0.get().clone();
            let v654: string = trimEndChars(
                trimStartChars(
                    sprintf!(
                        "{} {} #{} {} / {}",
                        v132,
                        v537,
                        v578,
                        File_system::closure49((), ()),
                        v615
                    ),
                    toArray(empty::<char>()),
                ),
                toArray(ofArray(new_array(&[' ', '/']))),
            );
            println!("{}", v654.clone());
            ();
            ((patternInput.1.clone()).l0.get().clone())(v654)
        }
    }
    pub fn closure50(v0_1: string, unitVar: ()) {
        File_system::method6(true, v0_1);
    }
    pub fn method38(v0_1: string) -> Func0<()> {
        Func0::new({
            let v0_1 = v0_1.clone();
            move || File_system::closure50(v0_1.clone(), ())
        })
    }
    pub fn method39(v0_1: string) -> Func0<()> {
        Func0::new({
            let v0_1 = v0_1.clone();
            move || File_system::closure50(v0_1.clone(), ())
        })
    }
    pub fn closure52(unitVar: (), unitVar_1: ()) -> string {
        string("file_system.create_dir")
    }
    pub fn closure51(v0_1: string, v1_1: string, unitVar: ()) {
        fn v3() {
            File_system::closure0((), ());
        }
        let v4: () = {
            v3();
            ()
        };
        let patternInput: (
            LrcPtr<File_system::Mut0>,
            LrcPtr<File_system::Mut1>,
            LrcPtr<File_system::Mut2>,
            LrcPtr<File_system::Mut3>,
            Option<i64>,
        ) = getValue(File_system::State::trace_state().get().clone());
        let v23_1: () = {
            v3();
            ()
        };
        let patternInput_1: (
            LrcPtr<File_system::Mut0>,
            LrcPtr<File_system::Mut1>,
            LrcPtr<File_system::Mut2>,
            LrcPtr<File_system::Mut3>,
            Option<i64>,
        ) = getValue(File_system::State::trace_state().get().clone());
        let v41: File_system::US0 = (patternInput_1.3.clone()).l0.get().clone();
        if if (patternInput_1.2.clone()).l0.get().clone() == false {
            false
        } else {
            1_i32
                >= find(
                    v41,
                    ofSeq(ofList(ofArray(new_array(&[
                        LrcPtr::new((File_system::US0::US0_0, 0_i32)),
                        LrcPtr::new((File_system::US0::US0_1, 1_i32)),
                        LrcPtr::new((File_system::US0::US0_2, 2_i32)),
                        LrcPtr::new((File_system::US0::US0_3, 3_i32)),
                        LrcPtr::new((File_system::US0::US0_4, 4_i32)),
                    ])))),
                )
        } {
            let v49: () = {
                File_system::closure6(patternInput.0.clone(), ());
                ()
            };
            let v51: () = {
                v3();
                ()
            };
            let patternInput_2: (
                LrcPtr<File_system::Mut0>,
                LrcPtr<File_system::Mut1>,
                LrcPtr<File_system::Mut2>,
                LrcPtr<File_system::Mut3>,
                Option<i64>,
            ) = getValue(File_system::State::trace_state().get().clone());
            let _v70: LrcPtr<MutCell<Option<File_system::US3>>> = refCell(None::<File_system::US3>);
            let v75: () = {
                File_system::closure8(
                    patternInput_2.4.clone(),
                    Func1::new({
                        let _v70 = _v70.clone();
                        move |v: Option<File_system::US3>| File_system::closure7(_v70.clone(), v)
                    }),
                    (),
                );
                ()
            };
            let v88: File_system::US3 = defaultValue(File_system::US3::US3_1, _v70.get().clone());
            let v128: DateTime = match &v88 {
                File_system::US3::US3_0(v88_0_0) => {
                    let v102: TimeSpan = TimeSpan::new_ticks(
                        {
                            let _arg: DateTime = DateTime::now();
                            _arg.ticks()
                        } - match &v88 {
                            File_system::US3::US3_0(x) => x.clone(),
                            _ => unreachable!(),
                        },
                    );
                    DateTime::new_ymdhms_milli(
                        1_i32,
                        1_i32,
                        1_i32,
                        v102.hours(),
                        v102.minutes(),
                        v102.seconds(),
                        v102.milliseconds(),
                    )
                }
                _ => DateTime::now(),
            };
            let v133: string = {
                let provider: string = File_system::method9();
                v128.toString(provider)
            };
            let v513: string = padLeft(toLower(string("Debug")), 7_i32, ' ');
            let v529: &str = inline_colorization::color_bright_blue;
            let v531: &str = &*v513;
            let v533: &str = inline_colorization::color_reset;
            let v535: string = string("format!(\"{v529}{v531}{v533}\")");
            let v536: std::string::String = format!("{v529}{v531}{v533}");
            let v538: string = fable_library_rust::String_::fromString(v536);
            let v579: i64 = (patternInput_2.0.clone()).l0.get().clone();
            let v581: LrcPtr<File_system::Mut4> = LrcPtr::new(File_system::Mut4 {
                l0: MutCell::new(File_system::method13()),
            });
            let v588: () = {
                File_system::closure9(v581.clone(), sprintf!("{}", string("{ ")), ());
                ()
            };
            let v595: () = {
                File_system::closure9(v581.clone(), sprintf!("{}", string("dir")), ());
                ()
            };
            let v602: () = {
                File_system::closure9(v581.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v608: () = {
                File_system::closure9(v581.clone(), sprintf!("{}", v0_1), ());
                ()
            };
            let v615: () = {
                File_system::closure9(v581.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v622: () = {
                File_system::closure9(v581.clone(), sprintf!("{}", string("result")), ());
                ()
            };
            let v628: () = {
                File_system::closure9(v581.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v634: () = {
                File_system::closure9(v581.clone(), sprintf!("{}", v1_1), ());
                ()
            };
            let v641: () = {
                File_system::closure9(v581.clone(), sprintf!("{}", string(" }")), ());
                ()
            };
            let v642: string = v581.l0.get().clone();
            let v681: string = trimEndChars(
                trimStartChars(
                    sprintf!(
                        "{} {} #{} {} / {}",
                        v133,
                        v538,
                        v579,
                        File_system::closure52((), ()),
                        v642
                    ),
                    toArray(empty::<char>()),
                ),
                toArray(ofArray(new_array(&[' ', '/']))),
            );
            println!("{}", v681.clone());
            ();
            ((patternInput.1.clone()).l0.get().clone())(v681)
        }
    }
    pub fn closure53(v0_1: string, unitVar: ()) {
        let v2_1: Arc<Async<i64>> = defaultOf();
        let v25: Arc<Async<()>> = defaultOf();
        defaultOf::<()>();
        ();
        ()
    }
    pub fn method40(v0_1: string) -> Func0<()> {
        Func0::new({
            let v0_1 = v0_1.clone();
            move || File_system::closure53(v0_1.clone(), ())
        })
    }
    pub fn method41(v0_1: string) -> Func0<()> {
        Func0::new({
            let v0_1 = v0_1.clone();
            move || File_system::closure53(v0_1.clone(), ())
        })
    }
    pub fn method35(v0_1: string) -> LrcPtr<dyn IDisposable> {
        let v2_1: string = File_system::method36(v0_1);
        let v4: Result<(), std::io::Error> = std::fs::create_dir_all(&*v2_1.clone());
        let v5_1 = File_system::method37();
        let v7_1: Result<(), std::string::String> = v4.map_err(|x| v5_1(x));
        let v10_1: File_system::US12 = match &v7_1 {
            Err(v7_1_1_0) => File_system::closure45((), v7_1_1_0.clone()),
            _ => File_system::closure44((), ()),
        };
        match &v10_1 {
            File_system::US12::US12_0 => {
                let v13_1: () = {
                    File_system::closure48(v2_1.clone(), ());
                    ()
                };
                ()
            }
            File_system::US12::US12_1(v10_1_1_0) => {
                let v17_1: () = {
                    File_system::closure46(
                        v2_1.clone(),
                        match &v10_1 {
                            File_system::US12::US12_1(x) => x.clone(),
                            _ => unreachable!(),
                        },
                        (),
                    );
                    ()
                };
                ()
            }
        }
        {
            let v19_1 = File_system::method38(v2_1.clone());
            interface_cast!(
                File_system::Disposable::_ctor__3A5B6456(Func0::new({
                    let v19_1 = v19_1.clone();
                    move || v19_1.clone()()
                })),
                Lrc<dyn IDisposable>,
            )
        }
    }
    pub fn closure42(unitVar: (), unitVar_1: ()) -> (string, LrcPtr<dyn IDisposable>) {
        let v0_1: string = File_system::method22();
        (v0_1.clone(), File_system::method35(v0_1))
    }
    pub fn method42(v0_1: string) -> Guid {
        let v2_1: string = padLeft(v0_1, 32_i32, '0');
        parse(sprintf!(
            "{}-{}-{}-{}-{}",
            getSlice(v2_1.clone(), Some(0_i32), Some(7_i32)),
            getSlice(v2_1.clone(), Some(8_i32), Some(11_i32)),
            getSlice(v2_1.clone(), Some(12_i32), Some(15_i32)),
            getSlice(v2_1.clone(), Some(16_i32), Some(19_i32)),
            getSlice(v2_1, Some(20_i32), Some(31_i32))
        ))
    }
    pub fn closure54(unitVar: (), v0_1: string) -> (string, LrcPtr<dyn IDisposable>) {
        let v2_1: string = File_system::method27(File_system::method42(v0_1));
        (v2_1.clone(), File_system::method35(v2_1))
    }
    pub fn closure55(unitVar: (), unitVar_1: ()) -> string {
        string("C:\\home\\git\\polyglot\\lib\\spiral")
    }
    pub fn method44(v0_1: string) -> string {
        v0_1
    }
    pub fn method43(v0_1: string) -> string {
        if v0_1.clone() == string("") {
            string("")
        } else {
            let v7_1: Result<regex::Regex, regex::Error> =
                regex::Regex::new(&string("^\\\\\\\\\\?\\\\"));
            let v9_1: regex::Regex = v7_1.unwrap();
            let v10_1: string = File_system::method44(v0_1);
            let v12_1: std::borrow::Cow<str> = v9_1.replace_all(&*v10_1, &*string(""));
            let v14_1: std::string::String = String::from(v12_1);
            let v30: string = fable_library_rust::String_::fromString(v14_1);
            replace(
                sprintf!(
                    "{}{}",
                    toLower(ofChar(getCharAt(v30.clone(), 0_i32))),
                    getSlice(v30, Some(1_i32), None::<i32>)
                ),
                string("\\"),
                string("/"),
            )
        }
    }
    pub fn closure56(unitVar: (), v0_1: string) -> string {
        File_system::method43(v0_1)
    }
    pub fn closure57(unitVar: (), v0_1: string) -> string {
        sprintf!("file:///{}", trimStartChars(v0_1, toArray(singleton('/'))))
    }
    pub fn method47(v0_1: string) -> Option<string> {
        let v3: &str = &*v0_1;
        let v5_1: std::string::String = String::from(v3);
        let v7_1: std::path::PathBuf = std::path::PathBuf::from(v5_1);
        let v9_1: Option<std::path::PathBuf> = v7_1.parent().map(std::path::PathBuf::from);
        let v11_1: std::path::PathBuf = v9_1?;
        let v13_1: std::path::Display = v11_1.display();
        let v16_1: std::string::String = format!("{}", v13_1);
        let v85: File_system::US1 =
            File_system::US1::US1_0(fable_library_rust::String_::fromString(v16_1));
        match &v85 {
            File_system::US1::US1_0(v85_0_0) => Some(match &v85 {
                File_system::US1::US1_0(x) => x.clone(),
                _ => unreachable!(),
            }),
            _ => None::<string>,
        }
    }
    pub fn closure59(unitVar: (), v0_1: string) -> Option<string> {
        File_system::method47(v0_1)
    }
    pub fn method46() -> Func1<string, Option<string>> {
        Func1::new(move |v: string| File_system::closure59((), v))
    }
    pub fn method48(v0_1: string, v1_1: string, v2_1: string) -> File_system::US13 {
        let v0_1: MutCell<string> = MutCell::new(v0_1.clone());
        let v1_1: MutCell<string> = MutCell::new(v1_1.clone());
        let v2_1: MutCell<string> = MutCell::new(v2_1.clone());
        '_method48: loop {
            break '_method48 (if File_system::method8(File_system::method30(
                v2_1.get().clone(),
                v0_1.get().clone(),
            )) {
                File_system::US13::US13_0(v2_1.get().clone())
            } else {
                let v7_1: Option<string> = (File_system::method46())(v2_1.get().clone());
                let _v8: LrcPtr<MutCell<Option<File_system::US1>>> =
                    refCell(None::<File_system::US1>);
                let v13_1: () = {
                    File_system::closure2(
                        v7_1,
                        Func1::new({
                            let _v8 = _v8.clone();
                            move |v: Option<File_system::US1>| File_system::closure1(_v8.clone(), v)
                        }),
                        (),
                    );
                    ()
                };
                let v26: File_system::US1 =
                    defaultValue(File_system::US1::US1_1, _v8.get().clone());
                match &v26 {
                    File_system::US1::US1_0(v26_0_0) => {
                        let v0_1_temp: string = v0_1.get().clone();
                        let v1_1_temp: string = v1_1.get().clone();
                        let v2_1_temp: string = match &v26 {
                            File_system::US1::US1_0(x) => x.clone(),
                            _ => unreachable!(),
                        };
                        v0_1.set(v0_1_temp);
                        v1_1.set(v1_1_temp);
                        v2_1.set(v2_1_temp);
                        continue '_method48;
                    }
                    _ => File_system::US13::US13_1(sprintf!(
                        "No parent for {} \'{}\' at \'{}\' (until \'{}\')",
                        string("dir"),
                        v0_1.get().clone(),
                        v1_1.get().clone(),
                        v2_1.get().clone()
                    )),
                }
            });
        }
    }
    pub fn method45(v0_1: string, v1_1: string) -> File_system::US13 {
        if File_system::method8(File_system::method30(v1_1.clone(), v0_1.clone())) {
            File_system::US13::US13_0(v1_1.clone())
        } else {
            let v6_1: Option<string> = (File_system::method46())(v1_1.clone());
            let _v7: LrcPtr<MutCell<Option<File_system::US1>>> = refCell(None::<File_system::US1>);
            let v12_1: () = {
                File_system::closure2(
                    v6_1,
                    Func1::new({
                        let _v7 = _v7.clone();
                        move |v: Option<File_system::US1>| File_system::closure1(_v7.clone(), v)
                    }),
                    (),
                );
                ()
            };
            let v25: File_system::US1 = defaultValue(File_system::US1::US1_1, _v7.get().clone());
            match &v25 {
                File_system::US1::US1_0(v25_0_0) => File_system::method48(
                    v0_1.clone(),
                    v1_1.clone(),
                    match &v25 {
                        File_system::US1::US1_0(x) => x.clone(),
                        _ => unreachable!(),
                    },
                ),
                _ => File_system::US13::US13_1(sprintf!(
                    "No parent for {} \'{}\' at \'{}\' (until \'{}\')",
                    string("dir"),
                    v0_1.clone(),
                    v1_1.clone(),
                    v1_1.clone()
                )),
            }
        }
    }
    pub fn closure61(unitVar: (), unitVar_1: ()) -> string {
        string("file_system.get_workspace_root")
    }
    pub fn closure60(v0_1: string, unitVar: ()) {
        fn v2_1() {
            File_system::closure0((), ());
        }
        let v3: () = {
            v2_1();
            ()
        };
        let patternInput: (
            LrcPtr<File_system::Mut0>,
            LrcPtr<File_system::Mut1>,
            LrcPtr<File_system::Mut2>,
            LrcPtr<File_system::Mut3>,
            Option<i64>,
        ) = getValue(File_system::State::trace_state().get().clone());
        let v22_1: () = {
            v2_1();
            ()
        };
        let patternInput_1: (
            LrcPtr<File_system::Mut0>,
            LrcPtr<File_system::Mut1>,
            LrcPtr<File_system::Mut2>,
            LrcPtr<File_system::Mut3>,
            Option<i64>,
        ) = getValue(File_system::State::trace_state().get().clone());
        let v40: File_system::US0 = (patternInput_1.3.clone()).l0.get().clone();
        if if (patternInput_1.2.clone()).l0.get().clone() == false {
            false
        } else {
            3_i32
                >= find(
                    v40,
                    ofSeq(ofList(ofArray(new_array(&[
                        LrcPtr::new((File_system::US0::US0_0, 0_i32)),
                        LrcPtr::new((File_system::US0::US0_1, 1_i32)),
                        LrcPtr::new((File_system::US0::US0_2, 2_i32)),
                        LrcPtr::new((File_system::US0::US0_3, 3_i32)),
                        LrcPtr::new((File_system::US0::US0_4, 4_i32)),
                    ])))),
                )
        } {
            let v48: () = {
                File_system::closure6(patternInput.0.clone(), ());
                ()
            };
            let v50: () = {
                v2_1();
                ()
            };
            let patternInput_2: (
                LrcPtr<File_system::Mut0>,
                LrcPtr<File_system::Mut1>,
                LrcPtr<File_system::Mut2>,
                LrcPtr<File_system::Mut3>,
                Option<i64>,
            ) = getValue(File_system::State::trace_state().get().clone());
            let _v69: LrcPtr<MutCell<Option<File_system::US3>>> = refCell(None::<File_system::US3>);
            let v74: () = {
                File_system::closure8(
                    patternInput_2.4.clone(),
                    Func1::new({
                        let _v69 = _v69.clone();
                        move |v: Option<File_system::US3>| File_system::closure7(_v69.clone(), v)
                    }),
                    (),
                );
                ()
            };
            let v87: File_system::US3 = defaultValue(File_system::US3::US3_1, _v69.get().clone());
            let v127: DateTime = match &v87 {
                File_system::US3::US3_0(v87_0_0) => {
                    let v101: TimeSpan = TimeSpan::new_ticks(
                        {
                            let _arg: DateTime = DateTime::now();
                            _arg.ticks()
                        } - match &v87 {
                            File_system::US3::US3_0(x) => x.clone(),
                            _ => unreachable!(),
                        },
                    );
                    DateTime::new_ymdhms_milli(
                        1_i32,
                        1_i32,
                        1_i32,
                        v101.hours(),
                        v101.minutes(),
                        v101.seconds(),
                        v101.milliseconds(),
                    )
                }
                _ => DateTime::now(),
            };
            let v132: string = {
                let provider: string = File_system::method9();
                v127.toString(provider)
            };
            let v512: string = padLeft(toLower(string("Warning")), 7_i32, ' ');
            let v528: &str = inline_colorization::color_yellow;
            let v530: &str = &*v512;
            let v532: &str = inline_colorization::color_reset;
            let v534: string = string("format!(\"{v528}{v530}{v532}\")");
            let v535: std::string::String = format!("{v528}{v530}{v532}");
            let v537: string = fable_library_rust::String_::fromString(v535);
            let v578: i64 = (patternInput_2.0.clone()).l0.get().clone();
            let v580: LrcPtr<File_system::Mut4> = LrcPtr::new(File_system::Mut4 {
                l0: MutCell::new(File_system::method13()),
            });
            let v587: () = {
                File_system::closure9(v580.clone(), sprintf!("{}", string("{ ")), ());
                ()
            };
            let v594: () = {
                File_system::closure9(v580.clone(), sprintf!("{}", string("error")), ());
                ()
            };
            let v601: () = {
                File_system::closure9(v580.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v607: () = {
                File_system::closure9(v580.clone(), sprintf!("{}", v0_1), ());
                ()
            };
            let v614: () = {
                File_system::closure9(v580.clone(), sprintf!("{}", string(" }")), ());
                ()
            };
            let v615: string = v580.l0.get().clone();
            let v654: string = trimEndChars(
                trimStartChars(
                    sprintf!(
                        "{} {} #{} {} / {}",
                        v132,
                        v537,
                        v578,
                        File_system::closure61((), ()),
                        v615
                    ),
                    toArray(empty::<char>()),
                ),
                toArray(ofArray(new_array(&[' ', '/']))),
            );
            println!("{}", v654.clone());
            ();
            ((patternInput.1.clone()).l0.get().clone())(v654)
        }
    }
    pub fn method49() -> string {
        let v2_1: Result<std::path::PathBuf, std::io::Error> = std::env::current_dir();
        let v4: std::path::PathBuf = v2_1.unwrap();
        let v6_1: std::path::Display = v4.display();
        let v9_1: std::string::String = format!("{}", v6_1);
        fable_library_rust::String_::fromString(v9_1)
    }
    pub fn closure58(unitVar: (), unitVar_1: ()) -> string {
        let v4: File_system::US13 = File_system::method45(
            File_system::method30(string("polyglot"), string(".devcontainer")),
            string("C:\\home\\git\\polyglot\\lib\\spiral"),
        );
        let v13_1: File_system::US1 = match &v4 {
            File_system::US13::US13_0(v4_0_0) => File_system::US1::US1_0(v4_0_0.clone()),
            File_system::US13::US13_1(v4_1_0) => {
                let v10_1: () = {
                    File_system::closure60(v4_1_0.clone(), ());
                    ()
                };
                File_system::US1::US1_1
            }
        };
        let v29: File_system::US1 = match &v13_1 {
            File_system::US1::US1_0(v13_1_0_0) => File_system::US1::US1_0(match &v13_1 {
                File_system::US1::US1_0(x) => x.clone(),
                _ => unreachable!(),
            }),
            _ => {
                let v16_1: string = File_system::method49();
                let v18_1: File_system::US13 = File_system::method45(
                    File_system::method30(string("polyglot"), string(".devcontainer")),
                    v16_1,
                );
                match &v18_1 {
                    File_system::US13::US13_0(v18_1_0_0) => {
                        File_system::US1::US1_0(v18_1_0_0.clone())
                    }
                    File_system::US13::US13_1(v18_1_1_0) => {
                        let v24: () = {
                            File_system::closure60(v18_1_1_0.clone(), ());
                            ()
                        };
                        File_system::US1::US1_1
                    }
                }
            }
        };
        File_system::method30(
            match &v29 {
                File_system::US1::US1_0(v29_0_0) => match &v29 {
                    File_system::US1::US1_0(x) => x.clone(),
                    _ => unreachable!(),
                },
                _ => panic!("{}", string("Option does not have a value."),),
            },
            string("polyglot"),
        )
    }
    pub fn method50(v0_1: string) {
        ();
        ()
    }
    pub fn closure63(unitVar: (), v0_1: string) {
        File_system::method50(v0_1);
    }
    pub fn closure62(unitVar: (), v0_1: bool) {
        let v3: () = {
            File_system::closure0((), ());
            ()
        };
        let patternInput: (
            LrcPtr<File_system::Mut0>,
            LrcPtr<File_system::Mut1>,
            LrcPtr<File_system::Mut2>,
            LrcPtr<File_system::Mut3>,
            Option<i64>,
        ) = getValue(File_system::State::trace_state().get().clone());
        let v23_1 = if v0_1 {
            Func1::new(move |v: string| File_system::closure63((), v))
        } else {
            Func1::new(move |v_1: string| File_system::closure3((), v_1))
        };
        (patternInput.1.clone()).l0.set(v23_1);
        ()
    }
    pub fn closure65(v0_1: string, v1_1: string) -> string {
        File_system::method30(v0_1, v1_1)
    }
    pub fn closure64(unitVar: (), v0_1: string) -> Func1<string, string> {
        Func1::new({
            let v0_1 = v0_1.clone();
            move |v: string| File_system::closure65(v0_1.clone(), v)
        })
    }
    pub fn v0() -> () {
        static v0: OnceInit<()> = OnceInit::new();
        v0.get_or_init(|| ()).clone()
    }
    pub fn v1() -> Func0<()> {
        static v1: OnceInit<Func0<()>> = OnceInit::new();
        v1.get_or_init(|| Func0::new(move || File_system::closure0((), ())))
            .clone()
    }
    pub fn v2() -> () {
        static v2: OnceInit<()> = OnceInit::new();
        v2.get_or_init(|| {
            (File_system::v1())();
            File_system::v0()
        })
        .clone()
    }
    pub fn v5() -> Func1<string, Arc<Async<i64>>> {
        static v5: OnceInit<Func1<string, Arc<Async<i64>>>> = OnceInit::new();
        v5.get_or_init(|| Func1::new(move |v: string| File_system::closure4((), v)))
            .clone()
    }
    pub fn delete_directory_async(x: string) -> Arc<Async<i64>> {
        (File_system::v5())(x)
    }
    pub fn v6() -> Func1<File_system::US6, Func1<string, Arc<Async<i64>>>> {
        static v6: OnceInit<Func1<File_system::US6, Func1<string, Arc<Async<i64>>>>> =
            OnceInit::new();
        v6.get_or_init(|| Func1::new(move |v: File_system::US6| File_system::closure11((), v)))
            .clone()
    }
    pub fn wait_for_file_access(x: File_system::US6) -> Func1<string, Arc<Async<i64>>> {
        (File_system::v6())(x)
    }
    pub fn v7() -> Func1<string, Arc<Async<i64>>> {
        static v7: OnceInit<Func1<string, Arc<Async<i64>>>> = OnceInit::new();
        v7.get_or_init(|| Func1::new(move |v: string| File_system::closure15((), v)))
            .clone()
    }
    pub fn wait_for_file_access_read(x: string) -> Arc<Async<i64>> {
        (File_system::v7())(x)
    }
    pub fn v8() -> Func1<string, Arc<Async<string>>> {
        static v8: OnceInit<Func1<string, Arc<Async<string>>>> = OnceInit::new();
        v8.get_or_init(|| Func1::new(move |v: string| File_system::closure16((), v)))
            .clone()
    }
    pub fn read_all_text_async(x: string) -> Arc<Async<string>> {
        (File_system::v8())(x)
    }
    pub fn v9() -> Func1<string, Func1<string, bool>> {
        static v9: OnceInit<Func1<string, Func1<string, bool>>> = OnceInit::new();
        v9.get_or_init(|| Func1::new(move |v: string| File_system::closure17((), v)))
            .clone()
    }
    pub fn file_exists_content(x: string) -> Func1<string, bool> {
        (File_system::v9())(x)
    }
    pub fn v10() -> Func1<string, Func1<string, Arc<Async<()>>>> {
        static v10: OnceInit<Func1<string, Func1<string, Arc<Async<()>>>>> = OnceInit::new();
        v10.get_or_init(|| Func1::new(move |v: string| File_system::closure19((), v)))
            .clone()
    }
    pub fn write_all_text_async(x: string) -> Func1<string, Arc<Async<()>>> {
        (File_system::v10())(x)
    }
    pub fn v11() -> Func1<string, Func1<string, Arc<Async<()>>>> {
        static v11: OnceInit<Func1<string, Func1<string, Arc<Async<()>>>>> = OnceInit::new();
        v11.get_or_init(|| Func1::new(move |v: string| File_system::closure21((), v)))
            .clone()
    }
    pub fn write_all_text_exists(x: string) -> Func1<string, Arc<Async<()>>> {
        (File_system::v11())(x)
    }
    pub fn v12() -> Func1<string, Arc<Async<i64>>> {
        static v12: OnceInit<Func1<string, Arc<Async<i64>>>> = OnceInit::new();
        v12.get_or_init(|| Func1::new(move |v: string| File_system::closure23((), v)))
            .clone()
    }
    pub fn delete_file_async(x: string) -> Arc<Async<i64>> {
        (File_system::v12())(x)
    }
    pub fn v13() -> Func1<string, Func1<string, Arc<Async<i64>>>> {
        static v13: OnceInit<Func1<string, Func1<string, Arc<Async<i64>>>>> = OnceInit::new();
        v13.get_or_init(|| Func1::new(move |v: string| File_system::closure26((), v)))
            .clone()
    }
    pub fn move_file_async(x: string) -> Func1<string, Arc<Async<i64>>> {
        (File_system::v13())(x)
    }
    pub fn v14() -> Func1<string, Arc<Async<Option<string>>>> {
        static v14: OnceInit<Func1<string, Arc<Async<Option<string>>>>> = OnceInit::new();
        v14.get_or_init(|| Func1::new(move |v: string| File_system::closure30((), v)))
            .clone()
    }
    pub fn read_all_text_retry_async(x: string) -> Arc<Async<Option<string>>> {
        (File_system::v14())(x)
    }
    pub fn v15() -> Func0<string> {
        static v15: OnceInit<Func0<string>> = OnceInit::new();
        v15.get_or_init(|| Func0::new(move || File_system::closure39((), ())))
            .clone()
    }
    pub fn create_temp_path() -> string {
        (File_system::v15())()
    }
    pub fn v16() -> Func0<(string, LrcPtr<dyn IDisposable>)> {
        static v16: OnceInit<Func0<(string, LrcPtr<dyn IDisposable>)>> = OnceInit::new();
        v16.get_or_init(|| Func0::new(move || File_system::closure42((), ())))
            .clone()
    }
    pub fn create_temp_dir() -> (string, LrcPtr<dyn IDisposable>) {
        (File_system::v16())()
    }
    pub fn v17() -> Func1<string, (string, LrcPtr<dyn IDisposable>)> {
        static v17: OnceInit<Func1<string, (string, LrcPtr<dyn IDisposable>)>> = OnceInit::new();
        v17.get_or_init(|| Func1::new(move |v: string| File_system::closure54((), v)))
            .clone()
    }
    pub fn create_temp_dir_(x: string) -> (string, LrcPtr<dyn IDisposable>) {
        (File_system::v17())(x)
    }
    pub fn v18() -> Func0<string> {
        static v18: OnceInit<Func0<string>> = OnceInit::new();
        v18.get_or_init(|| Func0::new(move || File_system::closure55((), ())))
            .clone()
    }
    pub fn get_source_directory() -> string {
        (File_system::v18())()
    }
    pub fn v19() -> Func1<string, string> {
        static v19: OnceInit<Func1<string, string>> = OnceInit::new();
        v19.get_or_init(|| Func1::new(move |v: string| File_system::closure56((), v)))
            .clone()
    }
    pub fn normalize_path(x: string) -> string {
        (File_system::v19())(x)
    }
    pub fn v20() -> Func1<string, string> {
        static v20: OnceInit<Func1<string, string>> = OnceInit::new();
        v20.get_or_init(|| Func1::new(move |v: string| File_system::closure57((), v)))
            .clone()
    }
    pub fn new_file_uri(x: string) -> string {
        (File_system::v20())(x)
    }
    pub fn v21() -> Func0<string> {
        static v21: OnceInit<Func0<string>> = OnceInit::new();
        v21.get_or_init(|| Func0::new(move || File_system::closure58((), ())))
            .clone()
    }
    pub fn get_workspace_root() -> string {
        (File_system::v21())()
    }
    pub fn v22() -> Func1<bool, ()> {
        static v22: OnceInit<Func1<bool, ()>> = OnceInit::new();
        v22.get_or_init(|| Func1::new(move |v: bool| File_system::closure62((), v)))
            .clone()
    }
    pub fn init_trace_file(x: bool) {
        (File_system::v22())(x);
    }
    pub fn v23() -> Func1<string, Func1<string, string>> {
        static v23: OnceInit<Func1<string, Func1<string, string>>> = OnceInit::new();
        v23.get_or_init(|| Func1::new(move |v: string| File_system::closure64((), v)))
            .clone()
    }
    pub fn op_LessDivideGreater(x: string) -> Func1<string, string> {
        (File_system::v23())(x)
    }
    on_startup!(());
}
