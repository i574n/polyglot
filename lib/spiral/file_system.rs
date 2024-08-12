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
        let v5: bool = true;
        let _result = v3.map(|x| {
            //;
            let v7: std::string::String = x;
            let v9: string = fable_library_rust::String_::fromString(v7);
            let v11: bool = true;
            v9
        });
        let v13: Result<string, std::env::VarError> = _result;
        let v14: string = File_system::method3();
        v13.unwrap_or(v14)
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
        let v8: File_system::US2 = if string("Verbose") == v3.clone() {
            File_system::US2::US2_0(File_system::US0::US0_0)
        } else {
            File_system::US2::US2_1
        };
        let _v1: (File_system::US2, File_system::US3) = (
            match &v8 {
                File_system::US2::US2_0(v8_0_0) => File_system::US2::US2_0(match &v8 {
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
                                    let v29_1: File_system::US2 = if string("Warning") == v3.clone()
                                    {
                                        File_system::US2::US2_0(File_system::US0::US0_3)
                                    } else {
                                        File_system::US2::US2_1
                                    };
                                    match &v29_1 {
                                        File_system::US2::US2_0(v29_1_0_0) => {
                                            File_system::US2::US2_0(match &v29_1 {
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
        let v5: std::string::String = String::from(v3);
        let v7: std::path::PathBuf = std::path::PathBuf::from(v5);
        if v7.clone().exists() {
            true
        } else {
            if v7.clone().is_dir() {
                true
            } else {
                v7.is_symlink()
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
        let v5: std::string::String = String::from(v3);
        let v7: std::path::PathBuf = std::path::PathBuf::from(v5);
        let v9: Option<&std::ffi::OsStr> = v7.file_name();
        let v11: &std::ffi::OsStr = v9.unwrap();
        let v13: std::ffi::OsString = v11.to_os_string();
        let v15_1: Option<&str> = v13.to_str();
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
        let v33_1: () = {
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
        let v61: File_system::US0 = (patternInput_1.3.clone()).l0.get().clone();
        if if (patternInput_1.2.clone()).l0.get().clone() == false {
            false
        } else {
            1_i32
                >= find(
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
            let v69: () = {
                File_system::closure6(patternInput.0.clone(), ());
                ()
            };
            let v73: () = {
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
            let _v102: LrcPtr<MutCell<Option<File_system::US3>>> =
                refCell(None::<File_system::US3>);
            let v107: () = {
                File_system::closure8(
                    patternInput_2.4.clone(),
                    Func1::new({
                        let _v102 = _v102.clone();
                        move |v: Option<File_system::US3>| File_system::closure7(_v102.clone(), v)
                    }),
                    (),
                );
                ()
            };
            let v122: File_system::US3 = defaultValue(File_system::US3::US3_1, _v102.get().clone());
            let v162: DateTime = match &v122 {
                File_system::US3::US3_0(v122_0_0) => {
                    let v136: TimeSpan = TimeSpan::new_ticks(
                        {
                            let _arg: DateTime = DateTime::now();
                            _arg.ticks()
                        } - match &v122 {
                            File_system::US3::US3_0(x) => x.clone(),
                            _ => unreachable!(),
                        },
                    );
                    DateTime::new_ymdhms_milli(
                        1_i32,
                        1_i32,
                        1_i32,
                        v136.hours(),
                        v136.minutes(),
                        v136.seconds(),
                        v136.milliseconds(),
                    )
                }
                _ => DateTime::now(),
            };
            let v167: string = {
                let provider: string = File_system::method9();
                v162.toString(provider)
            };
            let v559: string = padLeft(toLower(string("Debug")), 7_i32, ' ');
            let v575: &str = inline_colorization::color_bright_blue;
            let v577: &str = &*v559;
            let v579: &str = inline_colorization::color_reset;
            let v581: string = string("format!(\"{v575}{v577}{v579}\")");
            let v582: std::string::String = format!("{v575}{v577}{v579}");
            let v584: string = fable_library_rust::String_::fromString(v582);
            let v625: i64 = (patternInput_2.0.clone()).l0.get().clone();
            let v626: string = File_system::method12(v0_1);
            let v628: LrcPtr<File_system::Mut4> = LrcPtr::new(File_system::Mut4 {
                l0: MutCell::new(File_system::method13()),
            });
            let v635: () = {
                File_system::closure9(v628.clone(), sprintf!("{}", string("{ ")), ());
                ()
            };
            let v644: () = {
                File_system::closure9(v628.clone(), sprintf!("{}", string("ex")), ());
                ()
            };
            let v653: () = {
                File_system::closure9(v628.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v661: () = {
                File_system::closure9(v628.clone(), sprintf!("{}", v1_1), ());
                ()
            };
            let v670: () = {
                File_system::closure9(v628.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v679: () = {
                File_system::closure9(v628.clone(), sprintf!("{}", string("path")), ());
                ()
            };
            let v687: () = {
                File_system::closure9(v628.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v695: () = {
                File_system::closure9(v628.clone(), sprintf!("{}", v626), ());
                ()
            };
            let v704: () = {
                File_system::closure9(v628.clone(), sprintf!("{}", string(" }")), ());
                ()
            };
            let v707: string = v628.l0.get().clone();
            let v746: string = trimEndChars(
                trimStartChars(
                    sprintf!(
                        "{} {} #{} {} / {}",
                        v167,
                        v584,
                        v625,
                        File_system::closure10((), ()),
                        v707
                    ),
                    toArray(empty::<char>()),
                ),
                toArray(ofArray(new_array(&[' ', '/']))),
            );
            println!("{}", v746.clone());
            ();
            ((patternInput.1.clone()).l0.get().clone())(v746)
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
        let v5: () = {
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
        let v34: () = {
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
        let v62: File_system::US0 = (patternInput_1.3.clone()).l0.get().clone();
        if if (patternInput_1.2.clone()).l0.get().clone() == false {
            false
        } else {
            1_i32
                >= find(
                    v62,
                    ofSeq(ofList(ofArray(new_array(&[
                        LrcPtr::new((File_system::US0::US0_0, 0_i32)),
                        LrcPtr::new((File_system::US0::US0_1, 1_i32)),
                        LrcPtr::new((File_system::US0::US0_2, 2_i32)),
                        LrcPtr::new((File_system::US0::US0_3, 3_i32)),
                        LrcPtr::new((File_system::US0::US0_4, 4_i32)),
                    ])))),
                )
        } {
            let v70: () = {
                File_system::closure6(patternInput.0.clone(), ());
                ()
            };
            let v74: () = {
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
            let _v103: LrcPtr<MutCell<Option<File_system::US3>>> =
                refCell(None::<File_system::US3>);
            let v108: () = {
                File_system::closure8(
                    patternInput_2.4.clone(),
                    Func1::new({
                        let _v103 = _v103.clone();
                        move |v: Option<File_system::US3>| File_system::closure7(_v103.clone(), v)
                    }),
                    (),
                );
                ()
            };
            let v123: File_system::US3 = defaultValue(File_system::US3::US3_1, _v103.get().clone());
            let v163: DateTime = match &v123 {
                File_system::US3::US3_0(v123_0_0) => {
                    let v137: TimeSpan = TimeSpan::new_ticks(
                        {
                            let _arg: DateTime = DateTime::now();
                            _arg.ticks()
                        } - match &v123 {
                            File_system::US3::US3_0(x) => x.clone(),
                            _ => unreachable!(),
                        },
                    );
                    DateTime::new_ymdhms_milli(
                        1_i32,
                        1_i32,
                        1_i32,
                        v137.hours(),
                        v137.minutes(),
                        v137.seconds(),
                        v137.milliseconds(),
                    )
                }
                _ => DateTime::now(),
            };
            let v168: string = {
                let provider: string = File_system::method9();
                v163.toString(provider)
            };
            let v560: string = padLeft(toLower(string("Debug")), 7_i32, ' ');
            let v576: &str = inline_colorization::color_bright_blue;
            let v578: &str = &*v560;
            let v580: &str = inline_colorization::color_reset;
            let v582: string = string("format!(\"{v576}{v578}{v580}\")");
            let v583: std::string::String = format!("{v576}{v578}{v580}");
            let v585: string = fable_library_rust::String_::fromString(v583);
            let v626: i64 = (patternInput_2.0.clone()).l0.get().clone();
            let v627: string = File_system::method12(v0_1);
            let v629: LrcPtr<File_system::Mut4> = LrcPtr::new(File_system::Mut4 {
                l0: MutCell::new(File_system::method13()),
            });
            let v636: () = {
                File_system::closure9(v629.clone(), sprintf!("{}", string("{ ")), ());
                ()
            };
            let v645: () = {
                File_system::closure9(v629.clone(), sprintf!("{}", string("path")), ());
                ()
            };
            let v654: () = {
                File_system::closure9(v629.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v662: () = {
                File_system::closure9(v629.clone(), sprintf!("{}", v627), ());
                ()
            };
            let v671: () = {
                File_system::closure9(v629.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v680: () = {
                File_system::closure9(v629.clone(), sprintf!("{}", string("retry")), ());
                ()
            };
            let v688: () = {
                File_system::closure9(v629.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v696: () = {
                File_system::closure9(v629.clone(), sprintf!("{}", v1_1), ());
                ()
            };
            let v704: () = {
                File_system::closure9(v629.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v713: () = {
                File_system::closure9(v629.clone(), sprintf!("{}", string("ex")), ());
                ()
            };
            let v721: () = {
                File_system::closure9(v629.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v729: () = {
                File_system::closure9(v629.clone(), sprintf!("{}", v2_1), ());
                ()
            };
            let v738: () = {
                File_system::closure9(v629.clone(), sprintf!("{}", string(" }")), ());
                ()
            };
            let v741: string = v629.l0.get().clone();
            let v780: string = trimEndChars(
                trimStartChars(
                    sprintf!(
                        "{} {} #{} {} / {}",
                        v168,
                        v585,
                        v626,
                        File_system::closure14((), ()),
                        v741
                    ),
                    toArray(empty::<char>()),
                ),
                toArray(ofArray(new_array(&[' ', '/']))),
            );
            println!("{}", v780.clone());
            ();
            ((patternInput.1.clone()).l0.get().clone())(v780)
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
        let v5: std::string::String = String::from(v3);
        let v7: std::path::PathBuf = std::path::PathBuf::from(v5);
        if v7.clone().exists() {
            v7.is_file()
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
            let v8: Result<Vec<u8>, std::io::Error> = std::fs::read(&*v0_1);
            let v31_1: Vec<u8> = File_system::method18(v8.unwrap());
            let v33_1: Result<std::string::String, std::string::FromUtf8Error> =
                std::string::String::from_utf8(v31_1);
            let v35: std::string::String = v33_1.unwrap();
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
        let v33_1: () = {
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
        let v61: File_system::US0 = (patternInput_1.3.clone()).l0.get().clone();
        if if (patternInput_1.2.clone()).l0.get().clone() == false {
            false
        } else {
            3_i32
                >= find(
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
            let v69: () = {
                File_system::closure6(patternInput.0.clone(), ());
                ()
            };
            let v73: () = {
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
            let _v102: LrcPtr<MutCell<Option<File_system::US3>>> =
                refCell(None::<File_system::US3>);
            let v107: () = {
                File_system::closure8(
                    patternInput_2.4.clone(),
                    Func1::new({
                        let _v102 = _v102.clone();
                        move |v: Option<File_system::US3>| File_system::closure7(_v102.clone(), v)
                    }),
                    (),
                );
                ()
            };
            let v122: File_system::US3 = defaultValue(File_system::US3::US3_1, _v102.get().clone());
            let v162: DateTime = match &v122 {
                File_system::US3::US3_0(v122_0_0) => {
                    let v136: TimeSpan = TimeSpan::new_ticks(
                        {
                            let _arg: DateTime = DateTime::now();
                            _arg.ticks()
                        } - match &v122 {
                            File_system::US3::US3_0(x) => x.clone(),
                            _ => unreachable!(),
                        },
                    );
                    DateTime::new_ymdhms_milli(
                        1_i32,
                        1_i32,
                        1_i32,
                        v136.hours(),
                        v136.minutes(),
                        v136.seconds(),
                        v136.milliseconds(),
                    )
                }
                _ => DateTime::now(),
            };
            let v167: string = {
                let provider: string = File_system::method9();
                v162.toString(provider)
            };
            let v559: string = padLeft(toLower(string("Warning")), 7_i32, ' ');
            let v575: &str = inline_colorization::color_yellow;
            let v577: &str = &*v559;
            let v579: &str = inline_colorization::color_reset;
            let v581: string = string("format!(\"{v575}{v577}{v579}\")");
            let v582: std::string::String = format!("{v575}{v577}{v579}");
            let v584: string = fable_library_rust::String_::fromString(v582);
            let v625: i64 = (patternInput_2.0.clone()).l0.get().clone();
            let v626: string = File_system::method12(v0_1);
            let v628: string = sprintf!("{:?}", v1_1);
            let v650: LrcPtr<File_system::Mut4> = LrcPtr::new(File_system::Mut4 {
                l0: MutCell::new(File_system::method13()),
            });
            let v657: () = {
                File_system::closure9(v650.clone(), sprintf!("{}", string("{ ")), ());
                ()
            };
            let v666: () = {
                File_system::closure9(v650.clone(), sprintf!("{}", string("path")), ());
                ()
            };
            let v675: () = {
                File_system::closure9(v650.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v683: () = {
                File_system::closure9(v650.clone(), sprintf!("{}", v626), ());
                ()
            };
            let v692: () = {
                File_system::closure9(v650.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v701: () = {
                File_system::closure9(v650.clone(), sprintf!("{}", string("ex")), ());
                ()
            };
            let v709: () = {
                File_system::closure9(v650.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v717: () = {
                File_system::closure9(v650.clone(), sprintf!("{}", v628), ());
                ()
            };
            let v726: () = {
                File_system::closure9(v650.clone(), sprintf!("{}", string(" }")), ());
                ()
            };
            let v729: string = v650.l0.get().clone();
            let v768: string = trimEndChars(
                trimStartChars(
                    sprintf!(
                        "{} {} #{} {} / {}",
                        v167,
                        v584,
                        v625,
                        File_system::closure25((), ()),
                        v729
                    ),
                    toArray(empty::<char>()),
                ),
                toArray(ofArray(new_array(&[' ', '/']))),
            );
            println!("{}", v768.clone());
            ();
            ((patternInput.1.clone()).l0.get().clone())(v768)
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
        let v5: () = {
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
        let v34: () = {
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
        let v62: File_system::US0 = (patternInput_1.3.clone()).l0.get().clone();
        if if (patternInput_1.2.clone()).l0.get().clone() == false {
            false
        } else {
            3_i32
                >= find(
                    v62,
                    ofSeq(ofList(ofArray(new_array(&[
                        LrcPtr::new((File_system::US0::US0_0, 0_i32)),
                        LrcPtr::new((File_system::US0::US0_1, 1_i32)),
                        LrcPtr::new((File_system::US0::US0_2, 2_i32)),
                        LrcPtr::new((File_system::US0::US0_3, 3_i32)),
                        LrcPtr::new((File_system::US0::US0_4, 4_i32)),
                    ])))),
                )
        } {
            let v70: () = {
                File_system::closure6(patternInput.0.clone(), ());
                ()
            };
            let v74: () = {
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
            let _v103: LrcPtr<MutCell<Option<File_system::US3>>> =
                refCell(None::<File_system::US3>);
            let v108: () = {
                File_system::closure8(
                    patternInput_2.4.clone(),
                    Func1::new({
                        let _v103 = _v103.clone();
                        move |v: Option<File_system::US3>| File_system::closure7(_v103.clone(), v)
                    }),
                    (),
                );
                ()
            };
            let v123: File_system::US3 = defaultValue(File_system::US3::US3_1, _v103.get().clone());
            let v163: DateTime = match &v123 {
                File_system::US3::US3_0(v123_0_0) => {
                    let v137: TimeSpan = TimeSpan::new_ticks(
                        {
                            let _arg: DateTime = DateTime::now();
                            _arg.ticks()
                        } - match &v123 {
                            File_system::US3::US3_0(x) => x.clone(),
                            _ => unreachable!(),
                        },
                    );
                    DateTime::new_ymdhms_milli(
                        1_i32,
                        1_i32,
                        1_i32,
                        v137.hours(),
                        v137.minutes(),
                        v137.seconds(),
                        v137.milliseconds(),
                    )
                }
                _ => DateTime::now(),
            };
            let v168: string = {
                let provider: string = File_system::method9();
                v163.toString(provider)
            };
            let v560: string = padLeft(toLower(string("Warning")), 7_i32, ' ');
            let v576: &str = inline_colorization::color_yellow;
            let v578: &str = &*v560;
            let v580: &str = inline_colorization::color_reset;
            let v582: string = string("format!(\"{v576}{v578}{v580}\")");
            let v583: std::string::String = format!("{v576}{v578}{v580}");
            let v585: string = fable_library_rust::String_::fromString(v583);
            let v626: i64 = (patternInput_2.0.clone()).l0.get().clone();
            let v627: string = File_system::method12(v1_1);
            let v628: string = File_system::method12(v0_1);
            let v630: LrcPtr<File_system::Mut4> = LrcPtr::new(File_system::Mut4 {
                l0: MutCell::new(File_system::method13()),
            });
            let v637: () = {
                File_system::closure9(v630.clone(), sprintf!("{}", string("{ ")), ());
                ()
            };
            let v646: () = {
                File_system::closure9(v630.clone(), sprintf!("{}", string("old_path")), ());
                ()
            };
            let v655: () = {
                File_system::closure9(v630.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v663: () = {
                File_system::closure9(v630.clone(), sprintf!("{}", v627), ());
                ()
            };
            let v672: () = {
                File_system::closure9(v630.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v681: () = {
                File_system::closure9(v630.clone(), sprintf!("{}", string("new_path")), ());
                ()
            };
            let v689: () = {
                File_system::closure9(v630.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v697: () = {
                File_system::closure9(v630.clone(), sprintf!("{}", v628), ());
                ()
            };
            let v705: () = {
                File_system::closure9(v630.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v714: () = {
                File_system::closure9(v630.clone(), sprintf!("{}", string("ex")), ());
                ()
            };
            let v722: () = {
                File_system::closure9(v630.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v727: std::string::String = format!("{:#?}", v2_1);
            let v757: () = {
                File_system::closure9(
                    v630.clone(),
                    sprintf!("{}", fable_library_rust::String_::fromString(v727)),
                    (),
                );
                ()
            };
            let v766: () = {
                File_system::closure9(v630.clone(), sprintf!("{}", string(" }")), ());
                ()
            };
            let v769: string = v630.l0.get().clone();
            let v808: string = trimEndChars(
                trimStartChars(
                    sprintf!(
                        "{} {} #{} {} / {}",
                        v168,
                        v585,
                        v626,
                        File_system::closure29((), ()),
                        v769
                    ),
                    toArray(empty::<char>()),
                ),
                toArray(ofArray(new_array(&[' ', '/']))),
            );
            println!("{}", v808.clone());
            ();
            ((patternInput.1.clone()).l0.get().clone())(v808)
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
        let v31_1: () = {
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
        let v59: File_system::US0 = (patternInput_1.3.clone()).l0.get().clone();
        if if (patternInput_1.2.clone()).l0.get().clone() == false {
            false
        } else {
            0_i32
                >= find(
                    v59,
                    ofSeq(ofList(ofArray(new_array(&[
                        LrcPtr::new((File_system::US0::US0_0, 0_i32)),
                        LrcPtr::new((File_system::US0::US0_1, 1_i32)),
                        LrcPtr::new((File_system::US0::US0_2, 2_i32)),
                        LrcPtr::new((File_system::US0::US0_3, 3_i32)),
                        LrcPtr::new((File_system::US0::US0_4, 4_i32)),
                    ])))),
                )
        } {
            let v67: () = {
                File_system::closure6(patternInput.0.clone(), ());
                ()
            };
            let v71: () = {
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
            let _v100: LrcPtr<MutCell<Option<File_system::US3>>> =
                refCell(None::<File_system::US3>);
            let v105: () = {
                File_system::closure8(
                    patternInput_2.4.clone(),
                    Func1::new({
                        let _v100 = _v100.clone();
                        move |v: Option<File_system::US3>| File_system::closure7(_v100.clone(), v)
                    }),
                    (),
                );
                ()
            };
            let v120: File_system::US3 = defaultValue(File_system::US3::US3_1, _v100.get().clone());
            let v160: DateTime = match &v120 {
                File_system::US3::US3_0(v120_0_0) => {
                    let v134: TimeSpan = TimeSpan::new_ticks(
                        {
                            let _arg: DateTime = DateTime::now();
                            _arg.ticks()
                        } - match &v120 {
                            File_system::US3::US3_0(x) => x.clone(),
                            _ => unreachable!(),
                        },
                    );
                    DateTime::new_ymdhms_milli(
                        1_i32,
                        1_i32,
                        1_i32,
                        v134.hours(),
                        v134.minutes(),
                        v134.seconds(),
                        v134.milliseconds(),
                    )
                }
                _ => DateTime::now(),
            };
            let v165: string = {
                let provider: string = File_system::method9();
                v160.toString(provider)
            };
            let v557: string = padLeft(toLower(string("Verbose")), 7_i32, ' ');
            let v573: &str = inline_colorization::color_bright_black;
            let v575: &str = &*v557;
            let v577: &str = inline_colorization::color_reset;
            let v579: string = string("format!(\"{v573}{v575}{v577}\")");
            let v580: std::string::String = format!("{v573}{v575}{v577}");
            let v582: string = fable_library_rust::String_::fromString(v580);
            let v623: i64 = (patternInput_2.0.clone()).l0.get().clone();
            let v625: LrcPtr<File_system::Mut4> = LrcPtr::new(File_system::Mut4 {
                l0: MutCell::new(File_system::method13()),
            });
            let v632: () = {
                File_system::closure9(v625.clone(), sprintf!("{}", string("{ ")), ());
                ()
            };
            let v641: () = {
                File_system::closure9(v625.clone(), sprintf!("{}", string("timeout")), ());
                ()
            };
            let v650: () = {
                File_system::closure9(v625.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v658: () = {
                File_system::closure9(v625.clone(), sprintf!("{}", 1000_i32), ());
                ()
            };
            let v667: () = {
                File_system::closure9(v625.clone(), sprintf!("{}", string(" }")), ());
                ()
            };
            let v670: string = v625.l0.get().clone();
            let v709: string = trimEndChars(
                trimStartChars(
                    sprintf!(
                        "{} {} #{} {} / {}",
                        v165,
                        v582,
                        v623,
                        File_system::closure34((), ()),
                        v670
                    ),
                    toArray(empty::<char>()),
                ),
                toArray(ofArray(new_array(&[' ', '/']))),
            );
            println!("{}", v709.clone());
            ();
            ((patternInput.1.clone()).l0.get().clone())(v709)
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
        let v32_1: () = {
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
        let v60: File_system::US0 = (patternInput_1.3.clone()).l0.get().clone();
        if if (patternInput_1.2.clone()).l0.get().clone() == false {
            false
        } else {
            4_i32
                >= find(
                    v60,
                    ofSeq(ofList(ofArray(new_array(&[
                        LrcPtr::new((File_system::US0::US0_0, 0_i32)),
                        LrcPtr::new((File_system::US0::US0_1, 1_i32)),
                        LrcPtr::new((File_system::US0::US0_2, 2_i32)),
                        LrcPtr::new((File_system::US0::US0_3, 3_i32)),
                        LrcPtr::new((File_system::US0::US0_4, 4_i32)),
                    ])))),
                )
        } {
            let v68: () = {
                File_system::closure6(patternInput.0.clone(), ());
                ()
            };
            let v72: () = {
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
            let _v101: LrcPtr<MutCell<Option<File_system::US3>>> =
                refCell(None::<File_system::US3>);
            let v106: () = {
                File_system::closure8(
                    patternInput_2.4.clone(),
                    Func1::new({
                        let _v101 = _v101.clone();
                        move |v: Option<File_system::US3>| File_system::closure7(_v101.clone(), v)
                    }),
                    (),
                );
                ()
            };
            let v121: File_system::US3 = defaultValue(File_system::US3::US3_1, _v101.get().clone());
            let v161: DateTime = match &v121 {
                File_system::US3::US3_0(v121_0_0) => {
                    let v135: TimeSpan = TimeSpan::new_ticks(
                        {
                            let _arg: DateTime = DateTime::now();
                            _arg.ticks()
                        } - match &v121 {
                            File_system::US3::US3_0(x) => x.clone(),
                            _ => unreachable!(),
                        },
                    );
                    DateTime::new_ymdhms_milli(
                        1_i32,
                        1_i32,
                        1_i32,
                        v135.hours(),
                        v135.minutes(),
                        v135.seconds(),
                        v135.milliseconds(),
                    )
                }
                _ => DateTime::now(),
            };
            let v166: string = {
                let provider: string = File_system::method9();
                v161.toString(provider)
            };
            let v558: string = padLeft(toLower(string("Critical")), 7_i32, ' ');
            let v574: &str = inline_colorization::color_bright_red;
            let v576: &str = &*v558;
            let v578: &str = inline_colorization::color_reset;
            let v580: string = string("format!(\"{v574}{v576}{v578}\")");
            let v581: std::string::String = format!("{v574}{v576}{v578}");
            let v583: string = fable_library_rust::String_::fromString(v581);
            let v624: i64 = (patternInput_2.0.clone()).l0.get().clone();
            let v626: string = sprintf!("{:?}", v0_1);
            let v648: LrcPtr<File_system::Mut4> = LrcPtr::new(File_system::Mut4 {
                l0: MutCell::new(File_system::method13()),
            });
            let v655: () = {
                File_system::closure9(v648.clone(), sprintf!("{}", string("{ ")), ());
                ()
            };
            let v664: () = {
                File_system::closure9(v648.clone(), sprintf!("{}", string("timeout")), ());
                ()
            };
            let v673: () = {
                File_system::closure9(v648.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v681: () = {
                File_system::closure9(v648.clone(), sprintf!("{}", 1000_i32), ());
                ()
            };
            let v690: () = {
                File_system::closure9(v648.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v699: () = {
                File_system::closure9(v648.clone(), sprintf!("{}", string("ex")), ());
                ()
            };
            let v707: () = {
                File_system::closure9(v648.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v715: () = {
                File_system::closure9(v648.clone(), sprintf!("{}", v626), ());
                ()
            };
            let v724: () = {
                File_system::closure9(v648.clone(), sprintf!("{}", string(" }")), ());
                ()
            };
            let v727: string = v648.l0.get().clone();
            let v766: string = trimEndChars(
                trimStartChars(
                    sprintf!(
                        "{} {} #{} {} / {}",
                        v166,
                        v583,
                        v624,
                        File_system::closure36((), ()),
                        v727
                    ),
                    toArray(empty::<char>()),
                ),
                toArray(ofArray(new_array(&[' ', '/']))),
            );
            println!("{}", v766.clone());
            ();
            ((patternInput.1.clone()).l0.get().clone())(v766)
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
        let v33_1: () = {
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
        let v61: File_system::US0 = (patternInput_1.3.clone()).l0.get().clone();
        if if (patternInput_1.2.clone()).l0.get().clone() == false {
            false
        } else {
            1_i32
                >= find(
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
            let v69: () = {
                File_system::closure6(patternInput.0.clone(), ());
                ()
            };
            let v73: () = {
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
            let _v102: LrcPtr<MutCell<Option<File_system::US3>>> =
                refCell(None::<File_system::US3>);
            let v107: () = {
                File_system::closure8(
                    patternInput_2.4.clone(),
                    Func1::new({
                        let _v102 = _v102.clone();
                        move |v: Option<File_system::US3>| File_system::closure7(_v102.clone(), v)
                    }),
                    (),
                );
                ()
            };
            let v122: File_system::US3 = defaultValue(File_system::US3::US3_1, _v102.get().clone());
            let v162: DateTime = match &v122 {
                File_system::US3::US3_0(v122_0_0) => {
                    let v136: TimeSpan = TimeSpan::new_ticks(
                        {
                            let _arg: DateTime = DateTime::now();
                            _arg.ticks()
                        } - match &v122 {
                            File_system::US3::US3_0(x) => x.clone(),
                            _ => unreachable!(),
                        },
                    );
                    DateTime::new_ymdhms_milli(
                        1_i32,
                        1_i32,
                        1_i32,
                        v136.hours(),
                        v136.minutes(),
                        v136.seconds(),
                        v136.milliseconds(),
                    )
                }
                _ => DateTime::now(),
            };
            let v167: string = {
                let provider: string = File_system::method9();
                v162.toString(provider)
            };
            let v559: string = padLeft(toLower(string("Debug")), 7_i32, ' ');
            let v575: &str = inline_colorization::color_bright_blue;
            let v577: &str = &*v559;
            let v579: &str = inline_colorization::color_reset;
            let v581: string = string("format!(\"{v575}{v577}{v579}\")");
            let v582: std::string::String = format!("{v575}{v577}{v579}");
            let v584: string = fable_library_rust::String_::fromString(v582);
            let v625: i64 = (patternInput_2.0.clone()).l0.get().clone();
            let v627: LrcPtr<File_system::Mut4> = LrcPtr::new(File_system::Mut4 {
                l0: MutCell::new(File_system::method13()),
            });
            let v634: () = {
                File_system::closure9(v627.clone(), sprintf!("{}", string("{ ")), ());
                ()
            };
            let v643: () = {
                File_system::closure9(v627.clone(), sprintf!("{}", string("retry")), ());
                ()
            };
            let v652: () = {
                File_system::closure9(v627.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v660: () = {
                File_system::closure9(v627.clone(), sprintf!("{}", v0_1), ());
                ()
            };
            let v669: () = {
                File_system::closure9(v627.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v678: () = {
                File_system::closure9(v627.clone(), sprintf!("{}", string("ex")), ());
                ()
            };
            let v686: () = {
                File_system::closure9(v627.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v694: () = {
                File_system::closure9(v627.clone(), sprintf!("{}", v1_1), ());
                ()
            };
            let v703: () = {
                File_system::closure9(v627.clone(), sprintf!("{}", string(" }")), ());
                ()
            };
            let v706: string = v627.l0.get().clone();
            let v745: string = trimEndChars(
                trimStartChars(
                    sprintf!(
                        "{} {} #{} {} / {}",
                        v167,
                        v584,
                        v625,
                        File_system::closure38((), ()),
                        v706
                    ),
                    toArray(empty::<char>()),
                ),
                toArray(ofArray(new_array(&[' ', '/']))),
            );
            println!("{}", v745.clone());
            ();
            ((patternInput.1.clone()).l0.get().clone())(v745)
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
        let v7: DateTime = {
            let _arg: DateTime =
                DateTime::new_ymdhms_kind(1970_i32, 1_i32, 1_i32, 0_i32, 0_i32, 0_i32, 1_i32);
            _arg.toUniversalTime()
        };
        let v25_1: i64 = ({
            let _arg_2: DateTime = {
                let _arg_1: DateTime = DateTime::specifyKind(v1_1, 2_i32);
                _arg_1.toUniversalTime()
            };
            _arg_2.ticks()
        } - v7.ticks())
            / 10_i64;
        let v27_1: Option<chrono::DateTime<chrono::Utc>> =
            chrono::DateTime::from_timestamp_micros(v25_1);
        let _v28: LrcPtr<MutCell<Option<File_system::US11>>> = refCell(None::<File_system::US11>);
        let v33_1: () = {
            File_system::closure41(
                v27_1,
                Func1::new({
                    let _v28 = _v28.clone();
                    move |v: Option<File_system::US11>| File_system::closure40(_v28.clone(), v)
                }),
                (),
            );
            ()
        };
        let v48: File_system::US11 = defaultValue(File_system::US11::US11_1, _v28.get().clone());
        let v68: File_system::US1 = match &v48 {
            File_system::US11::US11_0(v48_0_0) => {
                let v54: chrono::NaiveDateTime = match &v48 {
                    File_system::US11::US11_0(x) => x.clone(),
                    _ => unreachable!(),
                }
                .naive_utc();
                let v56: chrono::DateTime<chrono::Local> =
                    chrono::offset::TimeZone::from_utc_datetime(&chrono::Local, &v54);
                let v58: string = string("r#\"%Y%m%d-%H%M-%S%f\"#");
                let v59: &str = r#"%Y%m%d-%H%M-%S%f"#;
                let v61: std::string::String = v56.format(v59).to_string();
                let v63: string = fable_library_rust::String_::fromString(v61);
                File_system::US1::US1_0(sprintf!(
                    "{}-{}-{}",
                    getSlice(v63.clone(), Some(0_i32), Some(17_i32)),
                    getSlice(v63.clone(), Some(18_i32), Some(21_i32)),
                    getCharAt(v63, 22_i32)
                ))
            }
            _ => File_system::US1::US1_1,
        };
        let v72: string = match &v68 {
            File_system::US1::US1_0(v68_0_0) => match &v68 {
                File_system::US1::US1_0(x) => x.clone(),
                _ => unreachable!(),
            },
            _ => string(""),
        };
        let v75: LrcPtr<TimeZoneInfo> = 0i64.into();
        let v150: u8 = if zero.hours() > 0_i32 { 1_u8 } else { 0_u8 };
        let v151: string = File_system::method24();
        let v159: string = zero.to_string(v151);
        let v162: string = sprintf!(
            "{}{}{}",
            v150,
            getSlice(v159.clone(), Some(0_i32), Some(1_i32)),
            getSlice(v159, Some(3_i32), Some(4_i32))
        );
        parse(sprintf!(
            "{}{}{}",
            v72.clone(),
            v162.clone(),
            getSlice(
                toString(v0_1),
                Some(length(v72) + length(v162)),
                None::<i32>
            )
        ))
    }
    pub fn method28() -> string {
        let v2_1: std::path::PathBuf = std::env::temp_dir();
        let v4: std::path::Display = v2_1.display();
        let v7: std::string::String = format!("{}", v4);
        fable_library_rust::String_::fromString(v7)
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
        let v6: std::string::String = String::from(v4);
        let v8: std::path::PathBuf = std::path::PathBuf::from(v6);
        let v10: &str = &*v1_1;
        let v12: std::string::String = String::from(v10);
        let v14: std::path::PathBuf = v8.join(v12);
        let v16_1: std::path::Display = v14.display();
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
        let v33_1: () = {
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
        let v61: File_system::US0 = (patternInput_1.3.clone()).l0.get().clone();
        if if (patternInput_1.2.clone()).l0.get().clone() == false {
            false
        } else {
            4_i32
                >= find(
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
            let v69: () = {
                File_system::closure6(patternInput.0.clone(), ());
                ()
            };
            let v73: () = {
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
            let _v102: LrcPtr<MutCell<Option<File_system::US3>>> =
                refCell(None::<File_system::US3>);
            let v107: () = {
                File_system::closure8(
                    patternInput_2.4.clone(),
                    Func1::new({
                        let _v102 = _v102.clone();
                        move |v: Option<File_system::US3>| File_system::closure7(_v102.clone(), v)
                    }),
                    (),
                );
                ()
            };
            let v122: File_system::US3 = defaultValue(File_system::US3::US3_1, _v102.get().clone());
            let v162: DateTime = match &v122 {
                File_system::US3::US3_0(v122_0_0) => {
                    let v136: TimeSpan = TimeSpan::new_ticks(
                        {
                            let _arg: DateTime = DateTime::now();
                            _arg.ticks()
                        } - match &v122 {
                            File_system::US3::US3_0(x) => x.clone(),
                            _ => unreachable!(),
                        },
                    );
                    DateTime::new_ymdhms_milli(
                        1_i32,
                        1_i32,
                        1_i32,
                        v136.hours(),
                        v136.minutes(),
                        v136.seconds(),
                        v136.milliseconds(),
                    )
                }
                _ => DateTime::now(),
            };
            let v167: string = {
                let provider: string = File_system::method9();
                v162.toString(provider)
            };
            let v559: string = padLeft(toLower(string("Critical")), 7_i32, ' ');
            let v575: &str = inline_colorization::color_bright_red;
            let v577: &str = &*v559;
            let v579: &str = inline_colorization::color_reset;
            let v581: string = string("format!(\"{v575}{v577}{v579}\")");
            let v582: std::string::String = format!("{v575}{v577}{v579}");
            let v584: string = fable_library_rust::String_::fromString(v582);
            let v625: i64 = (patternInput_2.0.clone()).l0.get().clone();
            let v627: LrcPtr<File_system::Mut4> = LrcPtr::new(File_system::Mut4 {
                l0: MutCell::new(File_system::method13()),
            });
            let v634: () = {
                File_system::closure9(v627.clone(), sprintf!("{}", string("{ ")), ());
                ()
            };
            let v643: () = {
                File_system::closure9(v627.clone(), sprintf!("{}", string("dir")), ());
                ()
            };
            let v652: () = {
                File_system::closure9(v627.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v660: () = {
                File_system::closure9(v627.clone(), sprintf!("{}", v0_1), ());
                ()
            };
            let v669: () = {
                File_system::closure9(v627.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v678: () = {
                File_system::closure9(v627.clone(), sprintf!("{}", string("error")), ());
                ()
            };
            let v686: () = {
                File_system::closure9(v627.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v691: std::string::String = format!("{:#?}", v1_1);
            let v721: () = {
                File_system::closure9(
                    v627.clone(),
                    sprintf!("{}", fable_library_rust::String_::fromString(v691)),
                    (),
                );
                ()
            };
            let v730: () = {
                File_system::closure9(v627.clone(), sprintf!("{}", string(" }")), ());
                ()
            };
            let v733: string = v627.l0.get().clone();
            let v772: string = trimEndChars(
                trimStartChars(
                    sprintf!(
                        "{} {} #{} {} / {}",
                        v167,
                        v584,
                        v625,
                        File_system::closure47((), ()),
                        v733
                    ),
                    toArray(empty::<char>()),
                ),
                toArray(ofArray(new_array(&[' ', '/']))),
            );
            println!("{}", v772.clone());
            ();
            ((patternInput.1.clone()).l0.get().clone())(v772)
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
        let v32_1: () = {
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
        let v60: File_system::US0 = (patternInput_1.3.clone()).l0.get().clone();
        if if (patternInput_1.2.clone()).l0.get().clone() == false {
            false
        } else {
            0_i32
                >= find(
                    v60,
                    ofSeq(ofList(ofArray(new_array(&[
                        LrcPtr::new((File_system::US0::US0_0, 0_i32)),
                        LrcPtr::new((File_system::US0::US0_1, 1_i32)),
                        LrcPtr::new((File_system::US0::US0_2, 2_i32)),
                        LrcPtr::new((File_system::US0::US0_3, 3_i32)),
                        LrcPtr::new((File_system::US0::US0_4, 4_i32)),
                    ])))),
                )
        } {
            let v68: () = {
                File_system::closure6(patternInput.0.clone(), ());
                ()
            };
            let v72: () = {
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
            let _v101: LrcPtr<MutCell<Option<File_system::US3>>> =
                refCell(None::<File_system::US3>);
            let v106: () = {
                File_system::closure8(
                    patternInput_2.4.clone(),
                    Func1::new({
                        let _v101 = _v101.clone();
                        move |v: Option<File_system::US3>| File_system::closure7(_v101.clone(), v)
                    }),
                    (),
                );
                ()
            };
            let v121: File_system::US3 = defaultValue(File_system::US3::US3_1, _v101.get().clone());
            let v161: DateTime = match &v121 {
                File_system::US3::US3_0(v121_0_0) => {
                    let v135: TimeSpan = TimeSpan::new_ticks(
                        {
                            let _arg: DateTime = DateTime::now();
                            _arg.ticks()
                        } - match &v121 {
                            File_system::US3::US3_0(x) => x.clone(),
                            _ => unreachable!(),
                        },
                    );
                    DateTime::new_ymdhms_milli(
                        1_i32,
                        1_i32,
                        1_i32,
                        v135.hours(),
                        v135.minutes(),
                        v135.seconds(),
                        v135.milliseconds(),
                    )
                }
                _ => DateTime::now(),
            };
            let v166: string = {
                let provider: string = File_system::method9();
                v161.toString(provider)
            };
            let v558: string = padLeft(toLower(string("Verbose")), 7_i32, ' ');
            let v574: &str = inline_colorization::color_bright_black;
            let v576: &str = &*v558;
            let v578: &str = inline_colorization::color_reset;
            let v580: string = string("format!(\"{v574}{v576}{v578}\")");
            let v581: std::string::String = format!("{v574}{v576}{v578}");
            let v583: string = fable_library_rust::String_::fromString(v581);
            let v624: i64 = (patternInput_2.0.clone()).l0.get().clone();
            let v626: LrcPtr<File_system::Mut4> = LrcPtr::new(File_system::Mut4 {
                l0: MutCell::new(File_system::method13()),
            });
            let v633: () = {
                File_system::closure9(v626.clone(), sprintf!("{}", string("{ ")), ());
                ()
            };
            let v642: () = {
                File_system::closure9(v626.clone(), sprintf!("{}", string("dir")), ());
                ()
            };
            let v651: () = {
                File_system::closure9(v626.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v659: () = {
                File_system::closure9(v626.clone(), sprintf!("{}", v0_1), ());
                ()
            };
            let v668: () = {
                File_system::closure9(v626.clone(), sprintf!("{}", string(" }")), ());
                ()
            };
            let v671: string = v626.l0.get().clone();
            let v710: string = trimEndChars(
                trimStartChars(
                    sprintf!(
                        "{} {} #{} {} / {}",
                        v166,
                        v583,
                        v624,
                        File_system::closure49((), ()),
                        v671
                    ),
                    toArray(empty::<char>()),
                ),
                toArray(ofArray(new_array(&[' ', '/']))),
            );
            println!("{}", v710.clone());
            ();
            ((patternInput.1.clone()).l0.get().clone())(v710)
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
        let v33_1: () = {
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
        let v61: File_system::US0 = (patternInput_1.3.clone()).l0.get().clone();
        if if (patternInput_1.2.clone()).l0.get().clone() == false {
            false
        } else {
            1_i32
                >= find(
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
            let v69: () = {
                File_system::closure6(patternInput.0.clone(), ());
                ()
            };
            let v73: () = {
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
            let _v102: LrcPtr<MutCell<Option<File_system::US3>>> =
                refCell(None::<File_system::US3>);
            let v107: () = {
                File_system::closure8(
                    patternInput_2.4.clone(),
                    Func1::new({
                        let _v102 = _v102.clone();
                        move |v: Option<File_system::US3>| File_system::closure7(_v102.clone(), v)
                    }),
                    (),
                );
                ()
            };
            let v122: File_system::US3 = defaultValue(File_system::US3::US3_1, _v102.get().clone());
            let v162: DateTime = match &v122 {
                File_system::US3::US3_0(v122_0_0) => {
                    let v136: TimeSpan = TimeSpan::new_ticks(
                        {
                            let _arg: DateTime = DateTime::now();
                            _arg.ticks()
                        } - match &v122 {
                            File_system::US3::US3_0(x) => x.clone(),
                            _ => unreachable!(),
                        },
                    );
                    DateTime::new_ymdhms_milli(
                        1_i32,
                        1_i32,
                        1_i32,
                        v136.hours(),
                        v136.minutes(),
                        v136.seconds(),
                        v136.milliseconds(),
                    )
                }
                _ => DateTime::now(),
            };
            let v167: string = {
                let provider: string = File_system::method9();
                v162.toString(provider)
            };
            let v559: string = padLeft(toLower(string("Debug")), 7_i32, ' ');
            let v575: &str = inline_colorization::color_bright_blue;
            let v577: &str = &*v559;
            let v579: &str = inline_colorization::color_reset;
            let v581: string = string("format!(\"{v575}{v577}{v579}\")");
            let v582: std::string::String = format!("{v575}{v577}{v579}");
            let v584: string = fable_library_rust::String_::fromString(v582);
            let v625: i64 = (patternInput_2.0.clone()).l0.get().clone();
            let v627: LrcPtr<File_system::Mut4> = LrcPtr::new(File_system::Mut4 {
                l0: MutCell::new(File_system::method13()),
            });
            let v634: () = {
                File_system::closure9(v627.clone(), sprintf!("{}", string("{ ")), ());
                ()
            };
            let v643: () = {
                File_system::closure9(v627.clone(), sprintf!("{}", string("dir")), ());
                ()
            };
            let v652: () = {
                File_system::closure9(v627.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v660: () = {
                File_system::closure9(v627.clone(), sprintf!("{}", v0_1), ());
                ()
            };
            let v669: () = {
                File_system::closure9(v627.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v678: () = {
                File_system::closure9(v627.clone(), sprintf!("{}", string("result")), ());
                ()
            };
            let v686: () = {
                File_system::closure9(v627.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v694: () = {
                File_system::closure9(v627.clone(), sprintf!("{}", v1_1), ());
                ()
            };
            let v703: () = {
                File_system::closure9(v627.clone(), sprintf!("{}", string(" }")), ());
                ()
            };
            let v706: string = v627.l0.get().clone();
            let v745: string = trimEndChars(
                trimStartChars(
                    sprintf!(
                        "{} {} #{} {} / {}",
                        v167,
                        v584,
                        v625,
                        File_system::closure52((), ()),
                        v706
                    ),
                    toArray(empty::<char>()),
                ),
                toArray(ofArray(new_array(&[' ', '/']))),
            );
            println!("{}", v745.clone());
            ();
            ((patternInput.1.clone()).l0.get().clone())(v745)
        }
    }
    pub fn closure53(v0_1: string, unitVar: ()) {
        let v2_1: Arc<Async<i64>> = defaultOf();
        let v25_1: Arc<Async<()>> = defaultOf();
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
        let v5 = File_system::method37();
        let v7: Result<(), std::string::String> = v4.map_err(|x| v5(x));
        let v10: File_system::US12 = match &v7 {
            Err(v7_1_0) => File_system::closure45((), v7_1_0.clone()),
            _ => File_system::closure44((), ()),
        };
        match &v10 {
            File_system::US12::US12_0 => {
                let v13: () = {
                    File_system::closure48(v2_1.clone(), ());
                    ()
                };
                ()
            }
            File_system::US12::US12_1(v10_1_0) => {
                let v749: () = {
                    File_system::closure46(
                        v2_1.clone(),
                        match &v10 {
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
            let v1544 = File_system::method38(v2_1.clone());
            interface_cast!(
                File_system::Disposable::_ctor__3A5B6456(Func0::new({
                    let v1544 = v1544.clone();
                    move || v1544.clone()()
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
        string("/home/runner/work/polyglot/polyglot/lib/spiral")
    }
    pub fn method44(v0_1: string) -> string {
        v0_1
    }
    pub fn method43(v0_1: string) -> string {
        if v0_1.clone() == string("") {
            string("")
        } else {
            let v7: Result<regex::Regex, regex::Error> =
                regex::Regex::new(&string("^\\\\\\\\\\?\\\\"));
            let v9: regex::Regex = v7.unwrap();
            let v10: string = File_system::method44(v0_1);
            let v12: std::borrow::Cow<str> = v9.replace_all(&*v10, &*string(""));
            let v14: std::string::String = String::from(v12);
            let v30_1: string = fable_library_rust::String_::fromString(v14);
            replace(
                sprintf!(
                    "{}{}",
                    toLower(ofChar(getCharAt(v30_1.clone(), 0_i32))),
                    getSlice(v30_1, Some(1_i32), None::<i32>)
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
        let v5: std::string::String = String::from(v3);
        let v7: std::path::PathBuf = std::path::PathBuf::from(v5);
        let v9: Option<std::path::PathBuf> = v7.parent().map(std::path::PathBuf::from);
        let v11: std::path::PathBuf = v9?;
        let v13: std::path::Display = v11.display();
        let v16_1: std::string::String = format!("{}", v13);
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
                let v7: Option<string> = (File_system::method46())(v2_1.get().clone());
                let _v8: LrcPtr<MutCell<Option<File_system::US1>>> =
                    refCell(None::<File_system::US1>);
                let v13: () = {
                    File_system::closure2(
                        v7,
                        Func1::new({
                            let _v8 = _v8.clone();
                            move |v: Option<File_system::US1>| File_system::closure1(_v8.clone(), v)
                        }),
                        (),
                    );
                    ()
                };
                let v28_1: File_system::US1 =
                    defaultValue(File_system::US1::US1_1, _v8.get().clone());
                match &v28_1 {
                    File_system::US1::US1_0(v28_1_0_0) => {
                        let v0_1_temp: string = v0_1.get().clone();
                        let v1_1_temp: string = v1_1.get().clone();
                        let v2_1_temp: string = match &v28_1 {
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
            let v6: Option<string> = (File_system::method46())(v1_1.clone());
            let _v7: LrcPtr<MutCell<Option<File_system::US1>>> = refCell(None::<File_system::US1>);
            let v12: () = {
                File_system::closure2(
                    v6,
                    Func1::new({
                        let _v7 = _v7.clone();
                        move |v: Option<File_system::US1>| File_system::closure1(_v7.clone(), v)
                    }),
                    (),
                );
                ()
            };
            let v27_1: File_system::US1 = defaultValue(File_system::US1::US1_1, _v7.get().clone());
            match &v27_1 {
                File_system::US1::US1_0(v27_1_0_0) => File_system::method48(
                    v0_1.clone(),
                    v1_1.clone(),
                    match &v27_1 {
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
        let v32_1: () = {
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
        let v60: File_system::US0 = (patternInput_1.3.clone()).l0.get().clone();
        if if (patternInput_1.2.clone()).l0.get().clone() == false {
            false
        } else {
            3_i32
                >= find(
                    v60,
                    ofSeq(ofList(ofArray(new_array(&[
                        LrcPtr::new((File_system::US0::US0_0, 0_i32)),
                        LrcPtr::new((File_system::US0::US0_1, 1_i32)),
                        LrcPtr::new((File_system::US0::US0_2, 2_i32)),
                        LrcPtr::new((File_system::US0::US0_3, 3_i32)),
                        LrcPtr::new((File_system::US0::US0_4, 4_i32)),
                    ])))),
                )
        } {
            let v68: () = {
                File_system::closure6(patternInput.0.clone(), ());
                ()
            };
            let v72: () = {
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
            let _v101: LrcPtr<MutCell<Option<File_system::US3>>> =
                refCell(None::<File_system::US3>);
            let v106: () = {
                File_system::closure8(
                    patternInput_2.4.clone(),
                    Func1::new({
                        let _v101 = _v101.clone();
                        move |v: Option<File_system::US3>| File_system::closure7(_v101.clone(), v)
                    }),
                    (),
                );
                ()
            };
            let v121: File_system::US3 = defaultValue(File_system::US3::US3_1, _v101.get().clone());
            let v161: DateTime = match &v121 {
                File_system::US3::US3_0(v121_0_0) => {
                    let v135: TimeSpan = TimeSpan::new_ticks(
                        {
                            let _arg: DateTime = DateTime::now();
                            _arg.ticks()
                        } - match &v121 {
                            File_system::US3::US3_0(x) => x.clone(),
                            _ => unreachable!(),
                        },
                    );
                    DateTime::new_ymdhms_milli(
                        1_i32,
                        1_i32,
                        1_i32,
                        v135.hours(),
                        v135.minutes(),
                        v135.seconds(),
                        v135.milliseconds(),
                    )
                }
                _ => DateTime::now(),
            };
            let v166: string = {
                let provider: string = File_system::method9();
                v161.toString(provider)
            };
            let v558: string = padLeft(toLower(string("Warning")), 7_i32, ' ');
            let v574: &str = inline_colorization::color_yellow;
            let v576: &str = &*v558;
            let v578: &str = inline_colorization::color_reset;
            let v580: string = string("format!(\"{v574}{v576}{v578}\")");
            let v581: std::string::String = format!("{v574}{v576}{v578}");
            let v583: string = fable_library_rust::String_::fromString(v581);
            let v624: i64 = (patternInput_2.0.clone()).l0.get().clone();
            let v626: LrcPtr<File_system::Mut4> = LrcPtr::new(File_system::Mut4 {
                l0: MutCell::new(File_system::method13()),
            });
            let v633: () = {
                File_system::closure9(v626.clone(), sprintf!("{}", string("{ ")), ());
                ()
            };
            let v642: () = {
                File_system::closure9(v626.clone(), sprintf!("{}", string("error")), ());
                ()
            };
            let v651: () = {
                File_system::closure9(v626.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v659: () = {
                File_system::closure9(v626.clone(), sprintf!("{}", v0_1), ());
                ()
            };
            let v668: () = {
                File_system::closure9(v626.clone(), sprintf!("{}", string(" }")), ());
                ()
            };
            let v671: string = v626.l0.get().clone();
            let v710: string = trimEndChars(
                trimStartChars(
                    sprintf!(
                        "{} {} #{} {} / {}",
                        v166,
                        v583,
                        v624,
                        File_system::closure61((), ()),
                        v671
                    ),
                    toArray(empty::<char>()),
                ),
                toArray(ofArray(new_array(&[' ', '/']))),
            );
            println!("{}", v710.clone());
            ();
            ((patternInput.1.clone()).l0.get().clone())(v710)
        }
    }
    pub fn method49() -> string {
        let v2_1: Result<std::path::PathBuf, std::io::Error> = std::env::current_dir();
        let v4: std::path::PathBuf = v2_1.unwrap();
        let v6: std::path::Display = v4.display();
        let v9: std::string::String = format!("{}", v6);
        fable_library_rust::String_::fromString(v9)
    }
    pub fn closure58(unitVar: (), unitVar_1: ()) -> string {
        let v4: File_system::US13 = File_system::method45(
            File_system::method30(string("polyglot"), string(".devcontainer")),
            string("/home/runner/work/polyglot/polyglot/lib/spiral"),
        );
        let v745: File_system::US1 = match &v4 {
            File_system::US13::US13_0(v4_0_0) => File_system::US1::US1_0(v4_0_0.clone()),
            File_system::US13::US13_1(v4_1_0) => {
                let v10: () = {
                    File_system::closure60(v4_1_0.clone(), ());
                    ()
                };
                File_system::US1::US1_1
            }
        };
        let v1493: File_system::US1 = match &v745 {
            File_system::US1::US1_0(v745_0_0) => File_system::US1::US1_0(match &v745 {
                File_system::US1::US1_0(x) => x.clone(),
                _ => unreachable!(),
            }),
            _ => {
                let v748: string = File_system::method49();
                let v750: File_system::US13 = File_system::method45(
                    File_system::method30(string("polyglot"), string(".devcontainer")),
                    v748,
                );
                match &v750 {
                    File_system::US13::US13_0(v750_0_0) => {
                        File_system::US1::US1_0(v750_0_0.clone())
                    }
                    File_system::US13::US13_1(v750_1_0) => {
                        let v756: () = {
                            File_system::closure60(v750_1_0.clone(), ());
                            ()
                        };
                        File_system::US1::US1_1
                    }
                }
            }
        };
        File_system::method30(
            match &v1493 {
                File_system::US1::US1_0(v1493_0_0) => match &v1493 {
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
        let v33_1 = if v0_1 {
            Func1::new(move |v: string| File_system::closure63((), v))
        } else {
            Func1::new(move |v_1: string| File_system::closure3((), v_1))
        };
        (patternInput.1.clone()).l0.set(v33_1);
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
    pub fn v15() -> Func1<string, Arc<Async<i64>>> {
        static v15: OnceInit<Func1<string, Arc<Async<i64>>>> = OnceInit::new();
        v15.get_or_init(|| Func1::new(move |v: string| File_system::closure4((), v)))
            .clone()
    }
    pub fn delete_directory_async(x: string) -> Arc<Async<i64>> {
        (File_system::v15())(x)
    }
    pub fn v16() -> Func1<File_system::US6, Func1<string, Arc<Async<i64>>>> {
        static v16: OnceInit<Func1<File_system::US6, Func1<string, Arc<Async<i64>>>>> =
            OnceInit::new();
        v16.get_or_init(|| Func1::new(move |v: File_system::US6| File_system::closure11((), v)))
            .clone()
    }
    pub fn wait_for_file_access(x: File_system::US6) -> Func1<string, Arc<Async<i64>>> {
        (File_system::v16())(x)
    }
    pub fn v17() -> Func1<string, Arc<Async<i64>>> {
        static v17: OnceInit<Func1<string, Arc<Async<i64>>>> = OnceInit::new();
        v17.get_or_init(|| Func1::new(move |v: string| File_system::closure15((), v)))
            .clone()
    }
    pub fn wait_for_file_access_read(x: string) -> Arc<Async<i64>> {
        (File_system::v17())(x)
    }
    pub fn v18() -> Func1<string, Arc<Async<string>>> {
        static v18: OnceInit<Func1<string, Arc<Async<string>>>> = OnceInit::new();
        v18.get_or_init(|| Func1::new(move |v: string| File_system::closure16((), v)))
            .clone()
    }
    pub fn read_all_text_async(x: string) -> Arc<Async<string>> {
        (File_system::v18())(x)
    }
    pub fn v19() -> Func1<string, Func1<string, bool>> {
        static v19: OnceInit<Func1<string, Func1<string, bool>>> = OnceInit::new();
        v19.get_or_init(|| Func1::new(move |v: string| File_system::closure17((), v)))
            .clone()
    }
    pub fn file_exists_content(x: string) -> Func1<string, bool> {
        (File_system::v19())(x)
    }
    pub fn v20() -> Func1<string, Func1<string, Arc<Async<()>>>> {
        static v20: OnceInit<Func1<string, Func1<string, Arc<Async<()>>>>> = OnceInit::new();
        v20.get_or_init(|| Func1::new(move |v: string| File_system::closure19((), v)))
            .clone()
    }
    pub fn write_all_text_async(x: string) -> Func1<string, Arc<Async<()>>> {
        (File_system::v20())(x)
    }
    pub fn v21() -> Func1<string, Func1<string, Arc<Async<()>>>> {
        static v21: OnceInit<Func1<string, Func1<string, Arc<Async<()>>>>> = OnceInit::new();
        v21.get_or_init(|| Func1::new(move |v: string| File_system::closure21((), v)))
            .clone()
    }
    pub fn write_all_text_exists(x: string) -> Func1<string, Arc<Async<()>>> {
        (File_system::v21())(x)
    }
    pub fn v22() -> Func1<string, Arc<Async<i64>>> {
        static v22: OnceInit<Func1<string, Arc<Async<i64>>>> = OnceInit::new();
        v22.get_or_init(|| Func1::new(move |v: string| File_system::closure23((), v)))
            .clone()
    }
    pub fn delete_file_async(x: string) -> Arc<Async<i64>> {
        (File_system::v22())(x)
    }
    pub fn v23() -> Func1<string, Func1<string, Arc<Async<i64>>>> {
        static v23: OnceInit<Func1<string, Func1<string, Arc<Async<i64>>>>> = OnceInit::new();
        v23.get_or_init(|| Func1::new(move |v: string| File_system::closure26((), v)))
            .clone()
    }
    pub fn move_file_async(x: string) -> Func1<string, Arc<Async<i64>>> {
        (File_system::v23())(x)
    }
    pub fn v24() -> Func1<string, Arc<Async<Option<string>>>> {
        static v24: OnceInit<Func1<string, Arc<Async<Option<string>>>>> = OnceInit::new();
        v24.get_or_init(|| Func1::new(move |v: string| File_system::closure30((), v)))
            .clone()
    }
    pub fn read_all_text_retry_async(x: string) -> Arc<Async<Option<string>>> {
        (File_system::v24())(x)
    }
    pub fn v25() -> Func0<string> {
        static v25: OnceInit<Func0<string>> = OnceInit::new();
        v25.get_or_init(|| Func0::new(move || File_system::closure39((), ())))
            .clone()
    }
    pub fn create_temp_path() -> string {
        (File_system::v25())()
    }
    pub fn v26() -> Func0<(string, LrcPtr<dyn IDisposable>)> {
        static v26: OnceInit<Func0<(string, LrcPtr<dyn IDisposable>)>> = OnceInit::new();
        v26.get_or_init(|| Func0::new(move || File_system::closure42((), ())))
            .clone()
    }
    pub fn create_temp_dir() -> (string, LrcPtr<dyn IDisposable>) {
        (File_system::v26())()
    }
    pub fn v27() -> Func1<string, (string, LrcPtr<dyn IDisposable>)> {
        static v27: OnceInit<Func1<string, (string, LrcPtr<dyn IDisposable>)>> = OnceInit::new();
        v27.get_or_init(|| Func1::new(move |v: string| File_system::closure54((), v)))
            .clone()
    }
    pub fn create_temp_dir_(x: string) -> (string, LrcPtr<dyn IDisposable>) {
        (File_system::v27())(x)
    }
    pub fn v28() -> Func0<string> {
        static v28: OnceInit<Func0<string>> = OnceInit::new();
        v28.get_or_init(|| Func0::new(move || File_system::closure55((), ())))
            .clone()
    }
    pub fn get_source_directory() -> string {
        (File_system::v28())()
    }
    pub fn v29() -> Func1<string, string> {
        static v29: OnceInit<Func1<string, string>> = OnceInit::new();
        v29.get_or_init(|| Func1::new(move |v: string| File_system::closure56((), v)))
            .clone()
    }
    pub fn normalize_path(x: string) -> string {
        (File_system::v29())(x)
    }
    pub fn v30() -> Func1<string, string> {
        static v30: OnceInit<Func1<string, string>> = OnceInit::new();
        v30.get_or_init(|| Func1::new(move |v: string| File_system::closure57((), v)))
            .clone()
    }
    pub fn new_file_uri(x: string) -> string {
        (File_system::v30())(x)
    }
    pub fn v31() -> Func0<string> {
        static v31: OnceInit<Func0<string>> = OnceInit::new();
        v31.get_or_init(|| Func0::new(move || File_system::closure58((), ())))
            .clone()
    }
    pub fn get_workspace_root() -> string {
        (File_system::v31())()
    }
    pub fn v32() -> Func1<bool, ()> {
        static v32: OnceInit<Func1<bool, ()>> = OnceInit::new();
        v32.get_or_init(|| Func1::new(move |v: bool| File_system::closure62((), v)))
            .clone()
    }
    pub fn init_trace_file(x: bool) {
        (File_system::v32())(x);
    }
    pub fn v33() -> Func1<string, Func1<string, string>> {
        static v33: OnceInit<Func1<string, Func1<string, string>>> = OnceInit::new();
        v33.get_or_init(|| Func1::new(move |v: string| File_system::closure64((), v)))
            .clone()
    }
    pub fn op_LessDivideGreater(x: string) -> Func1<string, string> {
        (File_system::v33())(x)
    }
    on_startup!(());
}
