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
    use fable_library_rust::Option_::map;
    use fable_library_rust::Seq_::ofList;
    use fable_library_rust::String_::append;
    use fable_library_rust::String_::getCharAt;
    use fable_library_rust::String_::getSlice;
    use fable_library_rust::String_::length;
    use fable_library_rust::String_::ofChar;
    use fable_library_rust::String_::padLeft;
    use fable_library_rust::String_::printfn;
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
    pub mod TraceState {
        use super::*;
        pub fn trace_state() -> LrcPtr<
            MutCell<
                Option<(
                    LrcPtr<File_system::Mut0>,
                    LrcPtr<File_system::Mut1>,
                    LrcPtr<File_system::Mut2>,
                    LrcPtr<File_system::Mut3>,
                    LrcPtr<File_system::Mut4>,
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
                            LrcPtr<File_system::Mut4>,
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
                            LrcPtr<File_system::Mut4>,
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
    #[derive(Clone, Debug, Default, PartialEq, PartialOrd, Hash, Eq)]
    pub struct Mut3 {
        pub l0: MutCell<string>,
    }
    impl core::fmt::Display for File_system::Mut3 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Debug, PartialEq, PartialOrd, Hash, Eq)]
    pub struct Mut4 {
        pub l0: MutCell<File_system::US0>,
    }
    impl core::fmt::Display for File_system::Mut4 {
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
    #[derive(Clone, Debug)]
    pub enum US13 {
        US13_0(std::path::PathBuf),
        US13_1(string),
    }
    impl core::fmt::Display for File_system::US13 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Debug)]
    pub enum US14 {
        US14_0(std::path::PathBuf),
        US14_1,
    }
    impl core::fmt::Display for File_system::US14 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Debug, PartialEq, PartialOrd, Hash, Eq)]
    pub enum US15 {
        US15_0(string),
        US15_1(string),
    }
    impl core::fmt::Display for File_system::US15 {
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
    pub fn closure1(unitVar: (), v0_1: string) -> File_system::US1 {
        File_system::US1::US1_0(v0_1)
    }
    pub fn method4() -> Func1<string, File_system::US1> {
        Func1::new(move |v: string| File_system::closure1((), v))
    }
    pub fn method2(v0_1: string) -> string {
        let v3: Result<std::string::String, std::env::VarError> = std::env::var(&*v0_1);
        let v5: bool = true;
        let _result_map_ = v3.map(|x| {
            //;
            let v7: std::string::String = x;
            let v9: string = fable_library_rust::String_::fromString(v7);
            let v11: bool = true;
            v9
        });
        let v13: Result<string, std::env::VarError> = _result_map_;
        let v14: string = File_system::method3();
        v13.unwrap_or(v14)
    }
    pub fn method5() -> string {
        string("AUTOMATION")
    }
    pub fn closure2(unitVar: (), v0_1: string) {
        ();
    }
    pub fn method0(
        v0_1: File_system::US0,
    ) -> (
        LrcPtr<File_system::Mut0>,
        LrcPtr<File_system::Mut1>,
        LrcPtr<File_system::Mut2>,
        LrcPtr<File_system::Mut3>,
        LrcPtr<File_system::Mut4>,
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
                    let v15: File_system::US2 = if string("Debug") == v3.clone() {
                        File_system::US2::US2_0(File_system::US0::US0_1)
                    } else {
                        File_system::US2::US2_1
                    };
                    match &v15 {
                        File_system::US2::US2_0(v15_0_0) => File_system::US2::US2_0(match &v15 {
                            File_system::US2::US2_0(x) => x.clone(),
                            _ => unreachable!(),
                        }),
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
            if File_system::method2(File_system::method5()) == string("True") {
                File_system::US3::US3_0({
                    let _arg: DateTime = DateTime::now();
                    _arg.ticks()
                })
            } else {
                File_system::US3::US3_1
            },
        );
        let v352: File_system::US3 = _v1.1.clone();
        let v351: File_system::US2 = _v1.0.clone();
        (
            LrcPtr::new(File_system::Mut0 {
                l0: MutCell::new(1_i64),
            }),
            LrcPtr::new(File_system::Mut1 {
                l0: MutCell::new(Func1::new(move |v: string| File_system::closure2((), v))),
            }),
            LrcPtr::new(File_system::Mut2 {
                l0: MutCell::new(true),
            }),
            LrcPtr::new(File_system::Mut3 {
                l0: MutCell::new(string("")),
            }),
            LrcPtr::new(File_system::Mut4 {
                l0: MutCell::new(match &v351 {
                    File_system::US2::US2_0(v351_0_0) => match &v351 {
                        File_system::US2::US2_0(x) => x.clone(),
                        _ => unreachable!(),
                    },
                    _ => v0_1,
                }),
            }),
            match &v352 {
                File_system::US3::US3_0(v352_0_0) => Some(match &v352 {
                    File_system::US3::US3_0(x) => x.clone(),
                    _ => unreachable!(),
                }),
                _ => None::<i64>,
            },
        )
    }
    pub fn closure0(unitVar: (), unitVar_1: ()) {
        if File_system::TraceState::trace_state()
            .get()
            .clone()
            .is_none()
        {
            let patternInput: (
                LrcPtr<File_system::Mut0>,
                LrcPtr<File_system::Mut1>,
                LrcPtr<File_system::Mut2>,
                LrcPtr<File_system::Mut3>,
                LrcPtr<File_system::Mut4>,
                Option<i64>,
            ) = File_system::method0(File_system::US0::US0_0);
            File_system::TraceState::trace_state().set(Some((
                patternInput.0.clone(),
                patternInput.1.clone(),
                patternInput.2.clone(),
                patternInput.3.clone(),
                patternInput.4.clone(),
                patternInput.5.clone(),
            )));
            ()
        };
    }
    pub fn method8(v0_1: string) -> string {
        v0_1
    }
    pub fn method9(v0_1: string) -> bool {
        let v4: &str = &*v0_1;
        let v25_1: std::string::String = String::from(v4);
        let v60: std::path::PathBuf = std::path::PathBuf::from(v25_1);
        if v60.clone().exists() {
            v60.is_dir()
        } else {
            false
        }
    }
    pub fn method7(v0_1: bool, v1_1: string) {
        let v3: string = File_system::method8(v1_1);
        if File_system::method9(v3.clone()) {
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
    pub fn method10(v0_1: File_system::US0) -> bool {
        let v3: () = {
            File_system::closure0((), ());
            ()
        };
        let patternInput: (
            LrcPtr<File_system::Mut0>,
            LrcPtr<File_system::Mut1>,
            LrcPtr<File_system::Mut2>,
            LrcPtr<File_system::Mut3>,
            LrcPtr<File_system::Mut4>,
            Option<i64>,
        ) = getValue(File_system::TraceState::trace_state().get().clone());
        let v35_1: File_system::US0 = (patternInput.4.clone()).l0.get().clone();
        if (patternInput.2.clone()).l0.get().clone() == false {
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
                v35_1,
                ofSeq(ofList(ofArray(new_array(&[
                    LrcPtr::new((File_system::US0::US0_0, 0_i32)),
                    LrcPtr::new((File_system::US0::US0_1, 1_i32)),
                    LrcPtr::new((File_system::US0::US0_2, 2_i32)),
                    LrcPtr::new((File_system::US0::US0_3, 3_i32)),
                    LrcPtr::new((File_system::US0::US0_4, 4_i32)),
                ])))),
            )
        }
    }
    pub fn closure5(unitVar: (), v0_1: i64) -> File_system::US3 {
        File_system::US3::US3_0(v0_1)
    }
    pub fn method12() -> Func1<i64, File_system::US3> {
        Func1::new(move |v: i64| File_system::closure5((), v))
    }
    pub fn method13() -> string {
        string("hh:mm:ss")
    }
    pub fn method14() -> string {
        string("HH:mm:ss")
    }
    pub fn method11(
        v0_1: LrcPtr<File_system::Mut0>,
        v1_1: LrcPtr<File_system::Mut1>,
        v2_1: LrcPtr<File_system::Mut2>,
        v3: LrcPtr<File_system::Mut3>,
        v4: LrcPtr<File_system::Mut4>,
        v5: Option<i64>,
    ) -> string {
        let v20_1: File_system::US3 =
            defaultValue(File_system::US3::US3_1, map(File_system::method12(), v5));
        let v60: DateTime = match &v20_1 {
            File_system::US3::US3_0(v20_1_0_0) => {
                let v34_1: TimeSpan = TimeSpan::new_ticks(
                    {
                        let _arg: DateTime = DateTime::now();
                        _arg.ticks()
                    } - match &v20_1 {
                        File_system::US3::US3_0(x) => x.clone(),
                        _ => unreachable!(),
                    },
                );
                DateTime::new_ymdhms_milli(
                    1_i32,
                    1_i32,
                    1_i32,
                    v34_1.hours(),
                    v34_1.minutes(),
                    v34_1.seconds(),
                    v34_1.milliseconds(),
                )
            }
            _ => DateTime::now(),
        };
        let provider: string = File_system::method13();
        v60.toString(provider)
    }
    pub fn method17() -> string {
        string("")
    }
    pub fn closure6(v0_1: LrcPtr<File_system::Mut3>, v1_1: string, unitVar: ()) {
        let v3: string = append(v0_1.l0.get().clone(), v1_1);
        v0_1.l0.set(v3);
        ()
    }
    pub fn method16(v0_1: char) -> string {
        let v2_1: LrcPtr<File_system::Mut3> = LrcPtr::new(File_system::Mut3 {
            l0: MutCell::new(File_system::method17()),
        });
        let v8: () = {
            File_system::closure6(v2_1.clone(), sprintf!("{}", v0_1), ());
            ()
        };
        v2_1.l0.get().clone()
    }
    pub fn method18() -> string {
        string("\u{001b}[0m")
    }
    pub fn method15() -> string {
        let v6: string = File_system::method16(getCharAt(toLower(string("Debug")), 0_i32));
        let v9: &str = inline_colorization::color_bright_blue;
        let v12: &str = &*v6;
        let v32_1: &str = inline_colorization::color_reset;
        let v34_1: std::string::String = format!("{}{}{}", v9, v12, v32_1);
        fable_library_rust::String_::fromString(v34_1)
    }
    pub fn method19(v0_1: string) -> string {
        let v4: &str = &*v0_1;
        let v25_1: std::string::String = String::from(v4);
        let v46: std::path::PathBuf = std::path::PathBuf::from(v25_1);
        let v66: Option<&std::ffi::OsStr> = v46.file_name();
        let v68: bool = true;
        let _optionm_map_ = v66.map(|x| {
            //;
            let v70: &std::ffi::OsStr = x;
            let v72: std::ffi::OsString = v70.to_os_string();
            let v74: Option<&str> = v72.to_str();
            let v76: &str = v74.unwrap();
            let v79: std::string::String = String::from(v76);
            let v99: string = fable_library_rust::String_::fromString(v79);
            let v101: bool = true;
            v99
        });
        let v103: Option<string> = _optionm_map_;
        let v117: File_system::US1 =
            defaultValue(File_system::US1::US1_1, map(File_system::method4(), v103));
        match &v117 {
            File_system::US1::US1_0(v117_0_0) => match &v117 {
                File_system::US1::US1_0(x) => x.clone(),
                _ => unreachable!(),
            },
            _ => string(""),
        }
    }
    pub fn method21(v0_1: string, v1_1: string) -> string {
        let v3: LrcPtr<File_system::Mut3> = LrcPtr::new(File_system::Mut3 {
            l0: MutCell::new(File_system::method17()),
        });
        let v10: () = {
            File_system::closure6(v3.clone(), sprintf!("{}", string("{ ")), ());
            ()
        };
        let v19_1: () = {
            File_system::closure6(v3.clone(), sprintf!("{}", string("ex")), ());
            ()
        };
        let v28_1: () = {
            File_system::closure6(v3.clone(), sprintf!("{}", string(" = ")), ());
            ()
        };
        let v36: () = {
            File_system::closure6(v3.clone(), sprintf!("{}", v0_1), ());
            ()
        };
        let v45: () = {
            File_system::closure6(v3.clone(), sprintf!("{}", string("; ")), ());
            ()
        };
        let v54: () = {
            File_system::closure6(v3.clone(), sprintf!("{}", string("path")), ());
            ()
        };
        let v62: () = {
            File_system::closure6(v3.clone(), sprintf!("{}", string(" = ")), ());
            ()
        };
        let v70: () = {
            File_system::closure6(v3.clone(), sprintf!("{}", v1_1), ());
            ()
        };
        let v79: () = {
            File_system::closure6(v3.clone(), sprintf!("{}", string(" }")), ());
            ()
        };
        v3.l0.get().clone()
    }
    pub fn method22(v0_1: string) -> string {
        trimEndChars(
            trimStartChars(v0_1, toArray(empty::<char>())),
            toArray(ofArray(new_array(&[' ', '/']))),
        )
    }
    pub fn method20(
        v0_1: LrcPtr<File_system::Mut0>,
        v1_1: LrcPtr<File_system::Mut1>,
        v2_1: LrcPtr<File_system::Mut2>,
        v3: LrcPtr<File_system::Mut3>,
        v4: LrcPtr<File_system::Mut4>,
        v5: Option<i64>,
        v6: string,
        v7: string,
        v8: string,
        v9: string,
    ) -> string {
        let v10: string = File_system::method21(v8, v9);
        File_system::method22(sprintf!(
            "{} {} #{} {} / {}",
            v6,
            v7,
            v0_1.l0.get().clone(),
            string("file_system.delete_directory_async"),
            v10
        ))
    }
    pub fn closure7(v0_1: LrcPtr<File_system::Mut0>, unitVar: ()) {
        let v2_1: i64 = v0_1.l0.get().clone() + 1_i64;
        v0_1.l0.set(v2_1);
        ()
    }
    pub fn closure9(v0_1: string, unitVar: ()) {
        printfn!("{0}", v0_1);
    }
    pub fn closure8(unitVar: (), v0_1: string) {
        let v3: () = {
            File_system::closure9(v0_1, ());
            ()
        };
        ()
    }
    pub fn method23(v0_1: string) {
        let v3: () = {
            File_system::closure0((), ());
            ()
        };
        let patternInput: (
            LrcPtr<File_system::Mut0>,
            LrcPtr<File_system::Mut1>,
            LrcPtr<File_system::Mut2>,
            LrcPtr<File_system::Mut3>,
            LrcPtr<File_system::Mut4>,
            Option<i64>,
        ) = getValue(File_system::TraceState::trace_state().get().clone());
        let v37: () = {
            File_system::closure7(patternInput.0.clone(), ());
            ()
        };
        println!("{}", v0_1.clone());
        ();
        ((patternInput.1.clone()).l0.get().clone())(v0_1)
    }
    pub fn closure4(v0_1: string, v1_1: string, unitVar: ()) {
        if File_system::method10(File_system::US0::US0_1) {
            let v6: () = {
                File_system::closure0((), ());
                ()
            };
            let patternInput: (
                LrcPtr<File_system::Mut0>,
                LrcPtr<File_system::Mut1>,
                LrcPtr<File_system::Mut2>,
                LrcPtr<File_system::Mut3>,
                LrcPtr<File_system::Mut4>,
                Option<i64>,
            ) = getValue(File_system::TraceState::trace_state().get().clone());
            let v25_1: Option<i64> = patternInput.5.clone();
            let v24_1: LrcPtr<File_system::Mut4> = patternInput.4.clone();
            let v23_1: LrcPtr<File_system::Mut3> = patternInput.3.clone();
            let v22_1: LrcPtr<File_system::Mut2> = patternInput.2.clone();
            let v21_1: LrcPtr<File_system::Mut1> = patternInput.1.clone();
            let v20_1: LrcPtr<File_system::Mut0> = patternInput.0.clone();
            File_system::method23(File_system::method20(
                v20_1.clone(),
                v21_1.clone(),
                v22_1.clone(),
                v23_1.clone(),
                v24_1.clone(),
                v25_1.clone(),
                File_system::method11(v20_1, v21_1, v22_1, v23_1, v24_1, v25_1),
                File_system::method15(),
                v1_1,
                File_system::method19(v0_1),
            ))
        };
    }
    pub fn method6(v0_1: string, v1_1: i64) -> Arc<Async<i64>> {
        defaultOf()
    }
    pub fn closure3(unitVar: (), v0_1: string) -> Arc<Async<i64>> {
        defaultOf()
    }
    pub fn method26(v0_1: string, v1_1: i64, v2_1: string) -> string {
        let v4: LrcPtr<File_system::Mut3> = LrcPtr::new(File_system::Mut3 {
            l0: MutCell::new(File_system::method17()),
        });
        let v11: () = {
            File_system::closure6(v4.clone(), sprintf!("{}", string("{ ")), ());
            ()
        };
        let v20_1: () = {
            File_system::closure6(v4.clone(), sprintf!("{}", string("path")), ());
            ()
        };
        let v29_1: () = {
            File_system::closure6(v4.clone(), sprintf!("{}", string(" = ")), ());
            ()
        };
        let v37: () = {
            File_system::closure6(v4.clone(), sprintf!("{}", v0_1), ());
            ()
        };
        let v46: () = {
            File_system::closure6(v4.clone(), sprintf!("{}", string("; ")), ());
            ()
        };
        let v55: () = {
            File_system::closure6(v4.clone(), sprintf!("{}", string("retry")), ());
            ()
        };
        let v63: () = {
            File_system::closure6(v4.clone(), sprintf!("{}", string(" = ")), ());
            ()
        };
        let v71: () = {
            File_system::closure6(v4.clone(), sprintf!("{}", v1_1), ());
            ()
        };
        let v79: () = {
            File_system::closure6(v4.clone(), sprintf!("{}", string("; ")), ());
            ()
        };
        let v88: () = {
            File_system::closure6(v4.clone(), sprintf!("{}", string("ex")), ());
            ()
        };
        let v96: () = {
            File_system::closure6(v4.clone(), sprintf!("{}", string(" = ")), ());
            ()
        };
        let v104: () = {
            File_system::closure6(v4.clone(), sprintf!("{}", v2_1), ());
            ()
        };
        let v113: () = {
            File_system::closure6(v4.clone(), sprintf!("{}", string(" }")), ());
            ()
        };
        v4.l0.get().clone()
    }
    pub fn method25(
        v0_1: LrcPtr<File_system::Mut0>,
        v1_1: LrcPtr<File_system::Mut1>,
        v2_1: LrcPtr<File_system::Mut2>,
        v3: LrcPtr<File_system::Mut3>,
        v4: LrcPtr<File_system::Mut4>,
        v5: Option<i64>,
        v6: string,
        v7: string,
        v8: string,
        v9: i64,
        v10: string,
    ) -> string {
        let v11: string = File_system::method26(v8, v9, v10);
        File_system::method22(sprintf!(
            "{} {} #{} {} / {}",
            v6,
            v7,
            v0_1.l0.get().clone(),
            string("file_system.wait_for_file_access"),
            v11
        ))
    }
    pub fn closure12(v0_1: string, v1_1: i64, v2_1: string, unitVar: ()) {
        if File_system::method10(File_system::US0::US0_1) {
            let v7: () = {
                File_system::closure0((), ());
                ()
            };
            let patternInput: (
                LrcPtr<File_system::Mut0>,
                LrcPtr<File_system::Mut1>,
                LrcPtr<File_system::Mut2>,
                LrcPtr<File_system::Mut3>,
                LrcPtr<File_system::Mut4>,
                Option<i64>,
            ) = getValue(File_system::TraceState::trace_state().get().clone());
            let v26_1: Option<i64> = patternInput.5.clone();
            let v25_1: LrcPtr<File_system::Mut4> = patternInput.4.clone();
            let v24_1: LrcPtr<File_system::Mut3> = patternInput.3.clone();
            let v23_1: LrcPtr<File_system::Mut2> = patternInput.2.clone();
            let v22_1: LrcPtr<File_system::Mut1> = patternInput.1.clone();
            let v21_1: LrcPtr<File_system::Mut0> = patternInput.0.clone();
            File_system::method23(File_system::method25(
                v21_1.clone(),
                v22_1.clone(),
                v23_1.clone(),
                v24_1.clone(),
                v25_1.clone(),
                v26_1.clone(),
                File_system::method11(v21_1, v22_1, v23_1, v24_1, v25_1, v26_1),
                File_system::method15(),
                File_system::method19(v0_1),
                v1_1,
                v2_1,
            ))
        };
    }
    pub fn method24(
        v0_1: string,
        v1_1: File_system::US8,
        v2_1: File_system::US7,
        v3: i64,
    ) -> Arc<Async<i64>> {
        defaultOf()
    }
    pub fn closure11(v0_1: File_system::US6, v1_1: string) -> Arc<Async<i64>> {
        defaultOf()
    }
    pub fn closure10(unitVar: (), v0_1: File_system::US6) -> Func1<string, Arc<Async<i64>>> {
        Func1::new({
            let v0_1 = v0_1.clone();
            move |v: string| File_system::closure11(v0_1.clone(), v)
        })
    }
    pub fn method27(v0_1: string, v1_1: i64) -> Arc<Async<i64>> {
        defaultOf()
    }
    pub fn closure13(unitVar: (), v0_1: string) -> Arc<Async<i64>> {
        defaultOf()
    }
    pub fn closure14(unitVar: (), v0_1: string) -> Arc<Async<string>> {
        defaultOf()
    }
    pub fn method29(v0_1: string) -> bool {
        let v4: &str = &*v0_1;
        let v25_1: std::string::String = String::from(v4);
        let v60: std::path::PathBuf = std::path::PathBuf::from(v25_1);
        if v60.clone().exists() {
            v60.is_file()
        } else {
            false
        }
    }
    pub fn method30(v0_1: Vec<u8>) -> Vec<u8> {
        v0_1
    }
    pub fn method28(v0_1: string, v1_1: string) -> bool {
        if File_system::method29(v0_1.clone()) == false {
            false
        } else {
            let v8: Result<Vec<u8>, std::io::Error> = std::fs::read(&*v0_1);
            let v42: Vec<u8> = File_system::method30(v8.unwrap());
            let v44: Result<std::string::String, std::string::FromUtf8Error> =
                std::string::String::from_utf8(v42);
            let v47: std::string::String = v44.unwrap();
            v1_1 == fable_library_rust::String_::fromString(v47)
        }
    }
    pub fn closure16(v0_1: string, v1_1: string) -> bool {
        File_system::method28(v0_1, v1_1)
    }
    pub fn closure15(unitVar: (), v0_1: string) -> Func1<string, bool> {
        Func1::new({
            let v0_1 = v0_1.clone();
            move |v: string| File_system::closure16(v0_1.clone(), v)
        })
    }
    pub fn closure18(v0_1: string, v1_1: string) -> Arc<Async<()>> {
        defaultOf()
    }
    pub fn closure17(unitVar: (), v0_1: string) -> Func1<string, Arc<Async<()>>> {
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
    pub fn method32() -> string {
        let v6: string = File_system::method16(getCharAt(toLower(string("Warning")), 0_i32));
        let v9: &str = inline_colorization::color_yellow;
        let v12: &str = &*v6;
        let v32_1: &str = inline_colorization::color_reset;
        let v34_1: std::string::String = format!("{}{}{}", v9, v12, v32_1);
        fable_library_rust::String_::fromString(v34_1)
    }
    pub fn method34(v0_1: string, v1_1: string) -> string {
        let v3: LrcPtr<File_system::Mut3> = LrcPtr::new(File_system::Mut3 {
            l0: MutCell::new(File_system::method17()),
        });
        let v10: () = {
            File_system::closure6(v3.clone(), sprintf!("{}", string("{ ")), ());
            ()
        };
        let v19_1: () = {
            File_system::closure6(v3.clone(), sprintf!("{}", string("path")), ());
            ()
        };
        let v28_1: () = {
            File_system::closure6(v3.clone(), sprintf!("{}", string(" = ")), ());
            ()
        };
        let v36: () = {
            File_system::closure6(v3.clone(), sprintf!("{}", v0_1), ());
            ()
        };
        let v45: () = {
            File_system::closure6(v3.clone(), sprintf!("{}", string("; ")), ());
            ()
        };
        let v54: () = {
            File_system::closure6(v3.clone(), sprintf!("{}", string("ex")), ());
            ()
        };
        let v62: () = {
            File_system::closure6(v3.clone(), sprintf!("{}", string(" = ")), ());
            ()
        };
        let v70: () = {
            File_system::closure6(v3.clone(), sprintf!("{}", v1_1), ());
            ()
        };
        let v79: () = {
            File_system::closure6(v3.clone(), sprintf!("{}", string(" }")), ());
            ()
        };
        v3.l0.get().clone()
    }
    pub fn method33(
        v0_1: LrcPtr<File_system::Mut0>,
        v1_1: LrcPtr<File_system::Mut1>,
        v2_1: LrcPtr<File_system::Mut2>,
        v3: LrcPtr<File_system::Mut3>,
        v4: LrcPtr<File_system::Mut4>,
        v5: Option<i64>,
        v6: string,
        v7: string,
        v8: string,
        v9: string,
    ) -> string {
        let v10: string = File_system::method34(v8, v9);
        File_system::method22(sprintf!(
            "{} {} #{} {} / {}",
            v6,
            v7,
            v0_1.l0.get().clone(),
            string("delete_file_async"),
            v10
        ))
    }
    pub fn closure22(v0_1: string, v1_1: LrcPtr<Exception>, unitVar: ()) {
        if File_system::method10(File_system::US0::US0_3) {
            let v6: () = {
                File_system::closure0((), ());
                ()
            };
            let patternInput: (
                LrcPtr<File_system::Mut0>,
                LrcPtr<File_system::Mut1>,
                LrcPtr<File_system::Mut2>,
                LrcPtr<File_system::Mut3>,
                LrcPtr<File_system::Mut4>,
                Option<i64>,
            ) = getValue(File_system::TraceState::trace_state().get().clone());
            let v25_1: Option<i64> = patternInput.5.clone();
            let v24_1: LrcPtr<File_system::Mut4> = patternInput.4.clone();
            let v23_1: LrcPtr<File_system::Mut3> = patternInput.3.clone();
            let v22_1: LrcPtr<File_system::Mut2> = patternInput.2.clone();
            let v21_1: LrcPtr<File_system::Mut1> = patternInput.1.clone();
            let v20_1: LrcPtr<File_system::Mut0> = patternInput.0.clone();
            File_system::method23(File_system::method33(
                v20_1.clone(),
                v21_1.clone(),
                v22_1.clone(),
                v23_1.clone(),
                v24_1.clone(),
                v25_1.clone(),
                File_system::method11(v20_1, v21_1, v22_1, v23_1, v24_1, v25_1),
                File_system::method32(),
                File_system::method19(v0_1),
                sprintf!("{:?}", v1_1),
            ))
        };
    }
    pub fn method31(v0_1: string, v1_1: i64) -> Arc<Async<i64>> {
        defaultOf()
    }
    pub fn closure21(unitVar: (), v0_1: string) -> Arc<Async<i64>> {
        defaultOf()
    }
    pub fn method37(v0_1: string, v1_1: string, v2_1: LrcPtr<Exception>) -> string {
        let v4: LrcPtr<File_system::Mut3> = LrcPtr::new(File_system::Mut3 {
            l0: MutCell::new(File_system::method17()),
        });
        let v11: () = {
            File_system::closure6(v4.clone(), sprintf!("{}", string("{ ")), ());
            ()
        };
        let v20_1: () = {
            File_system::closure6(v4.clone(), sprintf!("{}", string("old_path")), ());
            ()
        };
        let v29_1: () = {
            File_system::closure6(v4.clone(), sprintf!("{}", string(" = ")), ());
            ()
        };
        let v37: () = {
            File_system::closure6(v4.clone(), sprintf!("{}", v0_1), ());
            ()
        };
        let v46: () = {
            File_system::closure6(v4.clone(), sprintf!("{}", string("; ")), ());
            ()
        };
        let v55: () = {
            File_system::closure6(v4.clone(), sprintf!("{}", string("new_path")), ());
            ()
        };
        let v63: () = {
            File_system::closure6(v4.clone(), sprintf!("{}", string(" = ")), ());
            ()
        };
        let v71: () = {
            File_system::closure6(v4.clone(), sprintf!("{}", v1_1), ());
            ()
        };
        let v79: () = {
            File_system::closure6(v4.clone(), sprintf!("{}", string("; ")), ());
            ()
        };
        let v88: () = {
            File_system::closure6(v4.clone(), sprintf!("{}", string("ex")), ());
            ()
        };
        let v96: () = {
            File_system::closure6(v4.clone(), sprintf!("{}", string(" = ")), ());
            ()
        };
        let v101: std::string::String = format!("{:#?}", v2_1);
        let v131: () = {
            File_system::closure6(
                v4.clone(),
                sprintf!("{}", fable_library_rust::String_::fromString(v101)),
                (),
            );
            ()
        };
        let v140: () = {
            File_system::closure6(v4.clone(), sprintf!("{}", string(" }")), ());
            ()
        };
        v4.l0.get().clone()
    }
    pub fn method36(
        v0_1: LrcPtr<File_system::Mut0>,
        v1_1: LrcPtr<File_system::Mut1>,
        v2_1: LrcPtr<File_system::Mut2>,
        v3: LrcPtr<File_system::Mut3>,
        v4: LrcPtr<File_system::Mut4>,
        v5: Option<i64>,
        v6: string,
        v7: string,
        v8: string,
        v9: string,
        v10: LrcPtr<Exception>,
    ) -> string {
        let v11: string = File_system::method37(v8, v9, v10);
        File_system::method22(sprintf!(
            "{} {} #{} {} / {}",
            v6,
            v7,
            v0_1.l0.get().clone(),
            string("move_file_async"),
            v11
        ))
    }
    pub fn closure25(v0_1: string, v1_1: string, v2_1: LrcPtr<Exception>, unitVar: ()) {
        if File_system::method10(File_system::US0::US0_3) {
            let v7: () = {
                File_system::closure0((), ());
                ()
            };
            let patternInput: (
                LrcPtr<File_system::Mut0>,
                LrcPtr<File_system::Mut1>,
                LrcPtr<File_system::Mut2>,
                LrcPtr<File_system::Mut3>,
                LrcPtr<File_system::Mut4>,
                Option<i64>,
            ) = getValue(File_system::TraceState::trace_state().get().clone());
            let v26_1: Option<i64> = patternInput.5.clone();
            let v25_1: LrcPtr<File_system::Mut4> = patternInput.4.clone();
            let v24_1: LrcPtr<File_system::Mut3> = patternInput.3.clone();
            let v23_1: LrcPtr<File_system::Mut2> = patternInput.2.clone();
            let v22_1: LrcPtr<File_system::Mut1> = patternInput.1.clone();
            let v21_1: LrcPtr<File_system::Mut0> = patternInput.0.clone();
            File_system::method23(File_system::method36(
                v21_1.clone(),
                v22_1.clone(),
                v23_1.clone(),
                v24_1.clone(),
                v25_1.clone(),
                v26_1.clone(),
                File_system::method11(v21_1, v22_1, v23_1, v24_1, v25_1, v26_1),
                File_system::method32(),
                File_system::method19(v1_1),
                File_system::method19(v0_1),
                v2_1,
            ))
        };
    }
    pub fn method35(v0_1: string, v1_1: string, v2_1: i64) -> Arc<Async<i64>> {
        defaultOf()
    }
    pub fn closure24(v0_1: string, v1_1: string) -> Arc<Async<i64>> {
        defaultOf()
    }
    pub fn closure23(unitVar: (), v0_1: string) -> Func1<string, Arc<Async<i64>>> {
        Func1::new({
            let v0_1 = v0_1.clone();
            move |v: string| File_system::closure24(v0_1.clone(), v)
        })
    }
    pub fn closure27(unitVar: (), v0_1: i64) -> File_system::US9 {
        File_system::US9::US9_0(v0_1)
    }
    pub fn closure28(unitVar: (), v0_1: LrcPtr<Exception>) -> File_system::US9 {
        File_system::US9::US9_1(v0_1)
    }
    pub fn method39() -> string {
        let v6: string = File_system::method16(getCharAt(toLower(string("Verbose")), 0_i32));
        let v9: &str = inline_colorization::color_bright_black;
        let v12: &str = &*v6;
        let v32_1: &str = inline_colorization::color_reset;
        let v34_1: std::string::String = format!("{}{}{}", v9, v12, v32_1);
        fable_library_rust::String_::fromString(v34_1)
    }
    pub fn method41(v0_1: i32) -> string {
        let v2_1: LrcPtr<File_system::Mut3> = LrcPtr::new(File_system::Mut3 {
            l0: MutCell::new(File_system::method17()),
        });
        let v9: () = {
            File_system::closure6(v2_1.clone(), sprintf!("{}", string("{ ")), ());
            ()
        };
        let v18_1: () = {
            File_system::closure6(v2_1.clone(), sprintf!("{}", string("timeout")), ());
            ()
        };
        let v27_1: () = {
            File_system::closure6(v2_1.clone(), sprintf!("{}", string(" = ")), ());
            ()
        };
        let v35_1: () = {
            File_system::closure6(v2_1.clone(), sprintf!("{}", v0_1), ());
            ()
        };
        let v44: () = {
            File_system::closure6(v2_1.clone(), sprintf!("{}", string(" }")), ());
            ()
        };
        v2_1.l0.get().clone()
    }
    pub fn method40(
        v0_1: LrcPtr<File_system::Mut0>,
        v1_1: LrcPtr<File_system::Mut1>,
        v2_1: LrcPtr<File_system::Mut2>,
        v3: LrcPtr<File_system::Mut3>,
        v4: LrcPtr<File_system::Mut4>,
        v5: Option<i64>,
        v6: string,
        v7: string,
        v8: string,
    ) -> string {
        let v10: string = File_system::method41(1000_i32);
        File_system::method22(sprintf!(
            "{} {} #{} {} / {}",
            v6,
            v7,
            v0_1.l0.get().clone(),
            v8,
            v10
        ))
    }
    pub fn closure29(unitVar: (), unitVar_1: ()) {
        if File_system::method10(File_system::US0::US0_0) {
            let v4: () = {
                File_system::closure0((), ());
                ()
            };
            let patternInput: (
                LrcPtr<File_system::Mut0>,
                LrcPtr<File_system::Mut1>,
                LrcPtr<File_system::Mut2>,
                LrcPtr<File_system::Mut3>,
                LrcPtr<File_system::Mut4>,
                Option<i64>,
            ) = getValue(File_system::TraceState::trace_state().get().clone());
            let v23_1: Option<i64> = patternInput.5.clone();
            let v22_1: LrcPtr<File_system::Mut4> = patternInput.4.clone();
            let v21_1: LrcPtr<File_system::Mut3> = patternInput.3.clone();
            let v20_1: LrcPtr<File_system::Mut2> = patternInput.2.clone();
            let v19_1: LrcPtr<File_system::Mut1> = patternInput.1.clone();
            let v18_1: LrcPtr<File_system::Mut0> = patternInput.0.clone();
            File_system::method23(File_system::method40(
                v18_1.clone(),
                v19_1.clone(),
                v20_1.clone(),
                v21_1.clone(),
                v22_1.clone(),
                v23_1.clone(),
                File_system::method11(v18_1, v19_1, v20_1, v21_1, v22_1, v23_1),
                File_system::method39(),
                string("async.run_with_timeout_async"),
            ))
        };
    }
    pub fn method42() -> string {
        let v6: string = File_system::method16(getCharAt(toLower(string("Critical")), 0_i32));
        let v9: &str = inline_colorization::color_bright_red;
        let v12: &str = &*v6;
        let v32_1: &str = inline_colorization::color_reset;
        let v34_1: std::string::String = format!("{}{}{}", v9, v12, v32_1);
        fable_library_rust::String_::fromString(v34_1)
    }
    pub fn method44(v0_1: i32, v1_1: string) -> string {
        let v3: LrcPtr<File_system::Mut3> = LrcPtr::new(File_system::Mut3 {
            l0: MutCell::new(File_system::method17()),
        });
        let v10: () = {
            File_system::closure6(v3.clone(), sprintf!("{}", string("{ ")), ());
            ()
        };
        let v19_1: () = {
            File_system::closure6(v3.clone(), sprintf!("{}", string("timeout")), ());
            ()
        };
        let v28_1: () = {
            File_system::closure6(v3.clone(), sprintf!("{}", string(" = ")), ());
            ()
        };
        let v36: () = {
            File_system::closure6(v3.clone(), sprintf!("{}", v0_1), ());
            ()
        };
        let v45: () = {
            File_system::closure6(v3.clone(), sprintf!("{}", string("; ")), ());
            ()
        };
        let v54: () = {
            File_system::closure6(v3.clone(), sprintf!("{}", string("ex")), ());
            ()
        };
        let v62: () = {
            File_system::closure6(v3.clone(), sprintf!("{}", string(" = ")), ());
            ()
        };
        let v70: () = {
            File_system::closure6(v3.clone(), sprintf!("{}", v1_1), ());
            ()
        };
        let v79: () = {
            File_system::closure6(v3.clone(), sprintf!("{}", string(" }")), ());
            ()
        };
        v3.l0.get().clone()
    }
    pub fn method43(
        v0_1: LrcPtr<File_system::Mut0>,
        v1_1: LrcPtr<File_system::Mut1>,
        v2_1: LrcPtr<File_system::Mut2>,
        v3: LrcPtr<File_system::Mut3>,
        v4: LrcPtr<File_system::Mut4>,
        v5: Option<i64>,
        v6: string,
        v7: string,
        v8: string,
        v9: string,
    ) -> string {
        let v11: string = File_system::method44(1000_i32, v9);
        File_system::method22(sprintf!(
            "{} {} #{} {} / {}",
            v6,
            v7,
            v0_1.l0.get().clone(),
            v8,
            v11
        ))
    }
    pub fn closure30(v0_1: LrcPtr<Exception>, unitVar: ()) {
        if File_system::method10(File_system::US0::US0_4) {
            let v5: () = {
                File_system::closure0((), ());
                ()
            };
            let patternInput: (
                LrcPtr<File_system::Mut0>,
                LrcPtr<File_system::Mut1>,
                LrcPtr<File_system::Mut2>,
                LrcPtr<File_system::Mut3>,
                LrcPtr<File_system::Mut4>,
                Option<i64>,
            ) = getValue(File_system::TraceState::trace_state().get().clone());
            let v24_1: Option<i64> = patternInput.5.clone();
            let v23_1: LrcPtr<File_system::Mut4> = patternInput.4.clone();
            let v22_1: LrcPtr<File_system::Mut3> = patternInput.3.clone();
            let v21_1: LrcPtr<File_system::Mut2> = patternInput.2.clone();
            let v20_1: LrcPtr<File_system::Mut1> = patternInput.1.clone();
            let v19_1: LrcPtr<File_system::Mut0> = patternInput.0.clone();
            File_system::method23(File_system::method43(
                v19_1.clone(),
                v20_1.clone(),
                v21_1.clone(),
                v22_1.clone(),
                v23_1.clone(),
                v24_1.clone(),
                File_system::method11(v19_1, v20_1, v21_1, v22_1, v23_1, v24_1),
                File_system::method42(),
                string("async.run_with_timeout_async**"),
                sprintf!("{:?}", v0_1),
            ))
        };
    }
    pub fn method46(v0_1: i64, v1_1: string) -> string {
        let v3: LrcPtr<File_system::Mut3> = LrcPtr::new(File_system::Mut3 {
            l0: MutCell::new(File_system::method17()),
        });
        let v10: () = {
            File_system::closure6(v3.clone(), sprintf!("{}", string("{ ")), ());
            ()
        };
        let v19_1: () = {
            File_system::closure6(v3.clone(), sprintf!("{}", string("retry")), ());
            ()
        };
        let v28_1: () = {
            File_system::closure6(v3.clone(), sprintf!("{}", string(" = ")), ());
            ()
        };
        let v36: () = {
            File_system::closure6(v3.clone(), sprintf!("{}", v0_1), ());
            ()
        };
        let v45: () = {
            File_system::closure6(v3.clone(), sprintf!("{}", string("; ")), ());
            ()
        };
        let v54: () = {
            File_system::closure6(v3.clone(), sprintf!("{}", string("ex")), ());
            ()
        };
        let v62: () = {
            File_system::closure6(v3.clone(), sprintf!("{}", string(" = ")), ());
            ()
        };
        let v70: () = {
            File_system::closure6(v3.clone(), sprintf!("{}", v1_1), ());
            ()
        };
        let v79: () = {
            File_system::closure6(v3.clone(), sprintf!("{}", string(" }")), ());
            ()
        };
        v3.l0.get().clone()
    }
    pub fn method45(
        v0_1: LrcPtr<File_system::Mut0>,
        v1_1: LrcPtr<File_system::Mut1>,
        v2_1: LrcPtr<File_system::Mut2>,
        v3: LrcPtr<File_system::Mut3>,
        v4: LrcPtr<File_system::Mut4>,
        v5: Option<i64>,
        v6: string,
        v7: string,
        v8: string,
        v9: i64,
        v10: string,
    ) -> string {
        let v11: string = File_system::method46(v9, v10);
        File_system::method22(sprintf!(
            "{} {} #{} {} / {}",
            v6,
            v7,
            v0_1.l0.get().clone(),
            v8,
            v11
        ))
    }
    pub fn closure31(v0_1: i64, v1_1: string, unitVar: ()) {
        if File_system::method10(File_system::US0::US0_1) {
            let v6: () = {
                File_system::closure0((), ());
                ()
            };
            let patternInput: (
                LrcPtr<File_system::Mut0>,
                LrcPtr<File_system::Mut1>,
                LrcPtr<File_system::Mut2>,
                LrcPtr<File_system::Mut3>,
                LrcPtr<File_system::Mut4>,
                Option<i64>,
            ) = getValue(File_system::TraceState::trace_state().get().clone());
            let v25_1: Option<i64> = patternInput.5.clone();
            let v24_1: LrcPtr<File_system::Mut4> = patternInput.4.clone();
            let v23_1: LrcPtr<File_system::Mut3> = patternInput.3.clone();
            let v22_1: LrcPtr<File_system::Mut2> = patternInput.2.clone();
            let v21_1: LrcPtr<File_system::Mut1> = patternInput.1.clone();
            let v20_1: LrcPtr<File_system::Mut0> = patternInput.0.clone();
            File_system::method23(File_system::method45(
                v20_1.clone(),
                v21_1.clone(),
                v22_1.clone(),
                v23_1.clone(),
                v24_1.clone(),
                v25_1.clone(),
                File_system::method11(v20_1, v21_1, v22_1, v23_1, v24_1, v25_1),
                File_system::method15(),
                string("read_all_text_retry_async"),
                v0_1,
                v1_1,
            ))
        };
    }
    pub fn method38(v0_1: string, v1_1: i64) -> Arc<Async<Option<string>>> {
        defaultOf()
    }
    pub fn closure26(unitVar: (), v0_1: string) -> Arc<Async<Option<string>>> {
        defaultOf()
    }
    pub fn closure33(unitVar: (), v0_1: chrono::DateTime<chrono::Utc>) -> File_system::US11 {
        File_system::US11::US11_0(v0_1)
    }
    pub fn method49() -> Func1<chrono::DateTime<chrono::Utc>, File_system::US11> {
        Func1::new(move |v: chrono::DateTime<chrono::Utc>| File_system::closure33((), v))
    }
    pub fn method50() -> string {
        string("hh:mm")
    }
    pub fn method51() -> string {
        string("yyyyMMdd-HHmm-ssff-ffff-f")
    }
    pub fn method52() -> string {
        string("hhmm")
    }
    pub fn method48(v0_1: Guid, v1_1: DateTime) -> Guid {
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
        let v41: File_system::US11 = defaultValue(
            File_system::US11::US11_1,
            map(File_system::method49(), v27_1),
        );
        let v61: File_system::US1 = match &v41 {
            File_system::US11::US11_0(v41_0_0) => {
                let v47: chrono::NaiveDateTime = match &v41 {
                    File_system::US11::US11_0(x) => x.clone(),
                    _ => unreachable!(),
                }
                .naive_utc();
                let v49: chrono::DateTime<chrono::Local> =
                    chrono::offset::TimeZone::from_utc_datetime(&chrono::Local, &v47);
                let v51: string = string("r#\"%Y%m%d-%H%M-%S%f\"#");
                let v52: &str = r#"%Y%m%d-%H%M-%S%f"#;
                let v54: std::string::String = v49.format(v52).to_string();
                let v56: string = fable_library_rust::String_::fromString(v54);
                File_system::US1::US1_0(sprintf!(
                    "{}-{}-{}",
                    getSlice(v56.clone(), Some(0_i32), Some(17_i32)),
                    getSlice(v56.clone(), Some(18_i32), Some(21_i32)),
                    getCharAt(v56, 22_i32)
                ))
            }
            _ => File_system::US1::US1_1,
        };
        let v65: string = match &v61 {
            File_system::US1::US1_0(v61_0_0) => match &v61 {
                File_system::US1::US1_0(x) => x.clone(),
                _ => unreachable!(),
            },
            _ => string(""),
        };
        let v68: LrcPtr<TimeZoneInfo> = 0i64.into();
        let v143: u8 = if zero.hours() > 0_i32 { 1_u8 } else { 0_u8 };
        let v144: string = File_system::method50();
        let v152: string = zero.to_string(v144);
        let v155: string = sprintf!(
            "{}{}{}",
            v143,
            getSlice(v152.clone(), Some(0_i32), Some(1_i32)),
            getSlice(v152, Some(3_i32), Some(4_i32))
        );
        parse(sprintf!(
            "{}{}{}",
            v65.clone(),
            v155.clone(),
            getSlice(
                toString(v0_1),
                Some(length(v65) + length(v155)),
                None::<i32>
            )
        ))
    }
    pub fn method54() -> string {
        let v2_1: std::path::PathBuf = std::env::temp_dir();
        let v5: std::path::Display = v2_1.display();
        let v26_1: std::string::String = format!("{}", v5);
        fable_library_rust::String_::fromString(v26_1)
    }
    pub fn method55() -> string {
        string("!create_temp_path_")
    }
    pub fn method58(v0_1: string) -> string {
        v0_1
    }
    pub fn method57(v0_1: string, v1_1: string) -> (string, string) {
        (v1_1, File_system::method58(v0_1))
    }
    pub fn method56(v0_1: string, v1_1: string) -> string {
        let v5: &str = &*v0_1;
        let v26_1: std::string::String = String::from(v5);
        let v47: std::path::PathBuf = std::path::PathBuf::from(v26_1);
        let v68: &str = &*v1_1;
        let v89: std::string::String = String::from(v68);
        let v109: std::path::PathBuf = v47.join(v89);
        let v112: std::path::Display = v109.display();
        let v133: std::string::String = format!("{}", v112);
        fable_library_rust::String_::fromString(v133)
    }
    pub fn method60() -> string {
        string("CARGO_PKG_NAME")
    }
    pub fn method59() -> string {
        File_system::method2(File_system::method60())
    }
    pub fn method53(v0_1: Guid) -> string {
        File_system::method56(
            File_system::method56(
                File_system::method56(File_system::method54(), File_system::method55()),
                File_system::method59(),
            ),
            toString(v0_1),
        )
    }
    pub fn method47() -> string {
        let v1_1: DateTime = DateTime::now();
        File_system::method53(File_system::method48(new_guid(), v1_1))
    }
    pub fn closure32(unitVar: (), unitVar_1: ()) -> string {
        File_system::method47()
    }
    pub fn method62(v0_1: string) -> string {
        v0_1
    }
    pub fn closure35(unitVar: (), v0_1: std::io::Error) -> std::string::String {
        format!("{}", v0_1)
    }
    pub fn method63() -> Func1<std::io::Error, std::string::String> {
        Func1::new(move |v: std::io::Error| File_system::closure35((), v))
    }
    pub fn closure36(unitVar: (), unitVar_1: ()) -> File_system::US12 {
        File_system::US12::US12_0
    }
    pub fn closure37(unitVar: (), v0_1: std::string::String) -> File_system::US12 {
        File_system::US12::US12_1(v0_1)
    }
    pub fn method65(v0_1: string, v1_1: std::string::String) -> string {
        let v3: LrcPtr<File_system::Mut3> = LrcPtr::new(File_system::Mut3 {
            l0: MutCell::new(File_system::method17()),
        });
        let v10: () = {
            File_system::closure6(v3.clone(), sprintf!("{}", string("{ ")), ());
            ()
        };
        let v19_1: () = {
            File_system::closure6(v3.clone(), sprintf!("{}", string("dir")), ());
            ()
        };
        let v28_1: () = {
            File_system::closure6(v3.clone(), sprintf!("{}", string(" = ")), ());
            ()
        };
        let v36: () = {
            File_system::closure6(v3.clone(), sprintf!("{}", v0_1), ());
            ()
        };
        let v45: () = {
            File_system::closure6(v3.clone(), sprintf!("{}", string("; ")), ());
            ()
        };
        let v54: () = {
            File_system::closure6(v3.clone(), sprintf!("{}", string("error")), ());
            ()
        };
        let v62: () = {
            File_system::closure6(v3.clone(), sprintf!("{}", string(" = ")), ());
            ()
        };
        let v67: std::string::String = format!("{:#?}", v1_1);
        let v97: () = {
            File_system::closure6(
                v3.clone(),
                sprintf!("{}", fable_library_rust::String_::fromString(v67)),
                (),
            );
            ()
        };
        let v106: () = {
            File_system::closure6(v3.clone(), sprintf!("{}", string(" }")), ());
            ()
        };
        v3.l0.get().clone()
    }
    pub fn method64(
        v0_1: LrcPtr<File_system::Mut0>,
        v1_1: LrcPtr<File_system::Mut1>,
        v2_1: LrcPtr<File_system::Mut2>,
        v3: LrcPtr<File_system::Mut3>,
        v4: LrcPtr<File_system::Mut4>,
        v5: Option<i64>,
        v6: string,
        v7: string,
        v8: string,
        v9: std::string::String,
    ) -> string {
        let v10: string = File_system::method65(v8, v9);
        File_system::method22(sprintf!(
            "{} {} #{} {} / {}",
            v6,
            v7,
            v0_1.l0.get().clone(),
            string("file_system.create_dir"),
            v10
        ))
    }
    pub fn closure38(v0_1: string, v1_1: std::string::String, unitVar: ()) {
        if File_system::method10(File_system::US0::US0_4) {
            let v6: () = {
                File_system::closure0((), ());
                ()
            };
            let patternInput: (
                LrcPtr<File_system::Mut0>,
                LrcPtr<File_system::Mut1>,
                LrcPtr<File_system::Mut2>,
                LrcPtr<File_system::Mut3>,
                LrcPtr<File_system::Mut4>,
                Option<i64>,
            ) = getValue(File_system::TraceState::trace_state().get().clone());
            let v25_1: Option<i64> = patternInput.5.clone();
            let v24_1: LrcPtr<File_system::Mut4> = patternInput.4.clone();
            let v23_1: LrcPtr<File_system::Mut3> = patternInput.3.clone();
            let v22_1: LrcPtr<File_system::Mut2> = patternInput.2.clone();
            let v21_1: LrcPtr<File_system::Mut1> = patternInput.1.clone();
            let v20_1: LrcPtr<File_system::Mut0> = patternInput.0.clone();
            File_system::method23(File_system::method64(
                v20_1.clone(),
                v21_1.clone(),
                v22_1.clone(),
                v23_1.clone(),
                v24_1.clone(),
                v25_1.clone(),
                File_system::method11(v20_1, v21_1, v22_1, v23_1, v24_1, v25_1),
                File_system::method42(),
                v0_1,
                v1_1,
            ))
        };
    }
    pub fn method67(v0_1: string) -> string {
        let v2_1: LrcPtr<File_system::Mut3> = LrcPtr::new(File_system::Mut3 {
            l0: MutCell::new(File_system::method17()),
        });
        let v9: () = {
            File_system::closure6(v2_1.clone(), sprintf!("{}", string("{ ")), ());
            ()
        };
        let v18_1: () = {
            File_system::closure6(v2_1.clone(), sprintf!("{}", string("dir")), ());
            ()
        };
        let v27_1: () = {
            File_system::closure6(v2_1.clone(), sprintf!("{}", string(" = ")), ());
            ()
        };
        let v35_1: () = {
            File_system::closure6(v2_1.clone(), sprintf!("{}", v0_1), ());
            ()
        };
        let v44: () = {
            File_system::closure6(v2_1.clone(), sprintf!("{}", string(" }")), ());
            ()
        };
        v2_1.l0.get().clone()
    }
    pub fn method66(
        v0_1: LrcPtr<File_system::Mut0>,
        v1_1: LrcPtr<File_system::Mut1>,
        v2_1: LrcPtr<File_system::Mut2>,
        v3: LrcPtr<File_system::Mut3>,
        v4: LrcPtr<File_system::Mut4>,
        v5: Option<i64>,
        v6: string,
        v7: string,
        v8: string,
    ) -> string {
        let v9: string = File_system::method67(v8);
        File_system::method22(sprintf!(
            "{} {} #{} {} / {}",
            v6,
            v7,
            v0_1.l0.get().clone(),
            string("file_system.create_dir"),
            v9
        ))
    }
    pub fn closure39(v0_1: string, unitVar: ()) {
        if File_system::method10(File_system::US0::US0_0) {
            let v5: () = {
                File_system::closure0((), ());
                ()
            };
            let patternInput: (
                LrcPtr<File_system::Mut0>,
                LrcPtr<File_system::Mut1>,
                LrcPtr<File_system::Mut2>,
                LrcPtr<File_system::Mut3>,
                LrcPtr<File_system::Mut4>,
                Option<i64>,
            ) = getValue(File_system::TraceState::trace_state().get().clone());
            let v24_1: Option<i64> = patternInput.5.clone();
            let v23_1: LrcPtr<File_system::Mut4> = patternInput.4.clone();
            let v22_1: LrcPtr<File_system::Mut3> = patternInput.3.clone();
            let v21_1: LrcPtr<File_system::Mut2> = patternInput.2.clone();
            let v20_1: LrcPtr<File_system::Mut1> = patternInput.1.clone();
            let v19_1: LrcPtr<File_system::Mut0> = patternInput.0.clone();
            File_system::method23(File_system::method66(
                v19_1.clone(),
                v20_1.clone(),
                v21_1.clone(),
                v22_1.clone(),
                v23_1.clone(),
                v24_1.clone(),
                File_system::method11(v19_1, v20_1, v21_1, v22_1, v23_1, v24_1),
                File_system::method39(),
                v0_1,
            ))
        };
    }
    pub fn closure40(v0_1: string, unitVar: ()) {
        File_system::method7(true, v0_1);
    }
    pub fn method68(v0_1: string) -> Func0<()> {
        Func0::new({
            let v0_1 = v0_1.clone();
            move || File_system::closure40(v0_1.clone(), ())
        })
    }
    pub fn method69(v0_1: string) -> Func0<()> {
        Func0::new({
            let v0_1 = v0_1.clone();
            move || File_system::closure40(v0_1.clone(), ())
        })
    }
    pub fn method71(v0_1: string, v1_1: string) -> string {
        let v3: LrcPtr<File_system::Mut3> = LrcPtr::new(File_system::Mut3 {
            l0: MutCell::new(File_system::method17()),
        });
        let v10: () = {
            File_system::closure6(v3.clone(), sprintf!("{}", string("{ ")), ());
            ()
        };
        let v19_1: () = {
            File_system::closure6(v3.clone(), sprintf!("{}", string("dir")), ());
            ()
        };
        let v28_1: () = {
            File_system::closure6(v3.clone(), sprintf!("{}", string(" = ")), ());
            ()
        };
        let v36: () = {
            File_system::closure6(v3.clone(), sprintf!("{}", v0_1), ());
            ()
        };
        let v45: () = {
            File_system::closure6(v3.clone(), sprintf!("{}", string("; ")), ());
            ()
        };
        let v54: () = {
            File_system::closure6(v3.clone(), sprintf!("{}", string("result")), ());
            ()
        };
        let v62: () = {
            File_system::closure6(v3.clone(), sprintf!("{}", string(" = ")), ());
            ()
        };
        let v70: () = {
            File_system::closure6(v3.clone(), sprintf!("{}", v1_1), ());
            ()
        };
        let v79: () = {
            File_system::closure6(v3.clone(), sprintf!("{}", string(" }")), ());
            ()
        };
        v3.l0.get().clone()
    }
    pub fn method70(
        v0_1: LrcPtr<File_system::Mut0>,
        v1_1: LrcPtr<File_system::Mut1>,
        v2_1: LrcPtr<File_system::Mut2>,
        v3: LrcPtr<File_system::Mut3>,
        v4: LrcPtr<File_system::Mut4>,
        v5: Option<i64>,
        v6: string,
        v7: string,
        v8: string,
        v9: string,
    ) -> string {
        let v10: string = File_system::method71(v8, v9);
        File_system::method22(sprintf!(
            "{} {} #{} {} / {}",
            v6,
            v7,
            v0_1.l0.get().clone(),
            string("file_system.create_dir"),
            v10
        ))
    }
    pub fn closure41(v0_1: string, v1_1: string, unitVar: ()) {
        if File_system::method10(File_system::US0::US0_1) {
            let v6: () = {
                File_system::closure0((), ());
                ()
            };
            let patternInput: (
                LrcPtr<File_system::Mut0>,
                LrcPtr<File_system::Mut1>,
                LrcPtr<File_system::Mut2>,
                LrcPtr<File_system::Mut3>,
                LrcPtr<File_system::Mut4>,
                Option<i64>,
            ) = getValue(File_system::TraceState::trace_state().get().clone());
            let v25_1: Option<i64> = patternInput.5.clone();
            let v24_1: LrcPtr<File_system::Mut4> = patternInput.4.clone();
            let v23_1: LrcPtr<File_system::Mut3> = patternInput.3.clone();
            let v22_1: LrcPtr<File_system::Mut2> = patternInput.2.clone();
            let v21_1: LrcPtr<File_system::Mut1> = patternInput.1.clone();
            let v20_1: LrcPtr<File_system::Mut0> = patternInput.0.clone();
            File_system::method23(File_system::method70(
                v20_1.clone(),
                v21_1.clone(),
                v22_1.clone(),
                v23_1.clone(),
                v24_1.clone(),
                v25_1.clone(),
                File_system::method11(v20_1, v21_1, v22_1, v23_1, v24_1, v25_1),
                File_system::method15(),
                v0_1,
                v1_1,
            ))
        };
    }
    pub fn closure42(v0_1: string, unitVar: ()) {
        let v2_1: Arc<Async<i64>> = defaultOf();
        let v25_1: Arc<Async<()>> = defaultOf();
        defaultOf::<()>();
        ();
        ()
    }
    pub fn method72(v0_1: string) -> Func0<()> {
        Func0::new({
            let v0_1 = v0_1.clone();
            move || File_system::closure42(v0_1.clone(), ())
        })
    }
    pub fn method73(v0_1: string) -> Func0<()> {
        Func0::new({
            let v0_1 = v0_1.clone();
            move || File_system::closure42(v0_1.clone(), ())
        })
    }
    pub fn method61(v0_1: string) -> LrcPtr<dyn IDisposable> {
        let v2_1: string = File_system::method62(v0_1);
        let v4: Result<(), std::io::Error> = std::fs::create_dir_all(&*v2_1.clone());
        let v5 = File_system::method63();
        let v16_1: Result<(), std::string::String> = v4.map_err(|x| v5(x));
        let v21_1: File_system::US12 = match &v16_1 {
            Err(v16_1_1_0) => File_system::closure37((), v16_1_1_0.clone()),
            _ => File_system::closure36((), ()),
        };
        match &v21_1 {
            File_system::US12::US12_0 => {
                let v24_1: () = {
                    File_system::closure39(v2_1.clone(), ());
                    ()
                };
                ()
            }
            File_system::US12::US12_1(v21_1_1_0) => {
                let v67: () = {
                    File_system::closure38(
                        v2_1.clone(),
                        match &v21_1 {
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
            let v108 = File_system::method68(v2_1.clone());
            interface_cast!(
                File_system::Disposable::_ctor__3A5B6456(Func0::new({
                    let v108 = v108.clone();
                    move || v108.clone()()
                })),
                Lrc<dyn IDisposable>,
            )
        }
    }
    pub fn closure34(unitVar: (), unitVar_1: ()) -> (string, LrcPtr<dyn IDisposable>) {
        let v0_1: string = File_system::method47();
        (v0_1.clone(), File_system::method61(v0_1))
    }
    pub fn method74(v0_1: string) -> Guid {
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
    pub fn closure43(unitVar: (), v0_1: string) -> (string, LrcPtr<dyn IDisposable>) {
        let v2_1: string = File_system::method53(File_system::method74(v0_1));
        (v2_1.clone(), File_system::method61(v2_1))
    }
    pub fn closure44(unitVar: (), unitVar_1: ()) -> string {
        string("/home/runner/work/polyglot/polyglot/lib/spiral")
    }
    pub fn method77(v0_1: std::io::Error) -> string {
        let v2_1: LrcPtr<File_system::Mut3> = LrcPtr::new(File_system::Mut3 {
            l0: MutCell::new(File_system::method17()),
        });
        let v5: std::string::String = format!("{:#?}", v0_1);
        let v35_1: () = {
            File_system::closure6(
                v2_1.clone(),
                sprintf!("{}", fable_library_rust::String_::fromString(v5)),
                (),
            );
            ()
        };
        v2_1.l0.get().clone()
    }
    pub fn closure46(unitVar: (), v0_1: std::io::Error) -> string {
        File_system::method77(v0_1)
    }
    pub fn method76() -> Func1<std::io::Error, string> {
        Func1::new(move |v: std::io::Error| File_system::closure46((), v))
    }
    pub fn closure47(unitVar: (), v0_1: std::path::PathBuf) -> File_system::US13 {
        File_system::US13::US13_0(v0_1)
    }
    pub fn closure48(unitVar: (), v0_1: string) -> File_system::US13 {
        File_system::US13::US13_1(v0_1)
    }
    pub fn method79(v0_1: string) -> string {
        let v4: &str = &*v0_1;
        let v25_1: std::string::String = String::from(v4);
        let v46: std::path::PathBuf = std::path::PathBuf::from(v25_1);
        let v66: Option<std::path::PathBuf> = v46.parent().map(std::path::PathBuf::from);
        let v68: bool = true;
        let _optionm_map_ = v66.map(|x| {
            //;
            let v70: std::path::PathBuf = x;
            let v73: std::path::Display = v70.display();
            let v94: std::string::String = format!("{}", v73);
            let v114: string = fable_library_rust::String_::fromString(v94);
            let v116: bool = true;
            v114
        });
        defaultValue(string(""), _optionm_map_)
    }
    pub fn method78(v0_1: string) -> Option<string> {
        let v51: File_system::US1 = File_system::US1::US1_0(File_system::method79(v0_1));
        match &v51 {
            File_system::US1::US1_0(v51_0_0) => Some(match &v51 {
                File_system::US1::US1_0(x) => x.clone(),
                _ => unreachable!(),
            }),
            _ => None::<string>,
        }
    }
    pub fn closure49(unitVar: (), v0_1: std::path::PathBuf) -> File_system::US14 {
        File_system::US14::US14_0(v0_1)
    }
    pub fn method80() -> Func1<std::path::PathBuf, File_system::US14> {
        Func1::new(move |v: std::path::PathBuf| File_system::closure49((), v))
    }
    pub fn method81(v0_1: string) -> string {
        v0_1
    }
    pub fn method75(v0_1: string) -> string {
        if v0_1.clone() == string("") {
            string("")
        } else {
            let v2950: Result<std::path::PathBuf, std::io::Error> = if File_system::method9(
                v0_1.clone(),
            ) {
                std::fs::read_link(&*v0_1.clone())
            } else {
                let v8: Result<std::path::PathBuf, std::io::Error> =
                    std::fs::read_link(&*v0_1.clone());
                let v9 = File_system::method76();
                let v20_1: Result<std::path::PathBuf, string> = v8.map_err(|x| v9(x));
                fn v23_1(v: std::path::PathBuf) -> File_system::US13 {
                    File_system::closure47((), v)
                }
                fn v24_1(v_1: string) -> File_system::US13 {
                    File_system::closure48((), v_1)
                }
                let v25_1: File_system::US13 = match &v20_1 {
                    Err(v20_1_1_0) => v24_1(v20_1_1_0.clone()),
                    Ok(v20_1_0_0) => v23_1(v20_1_0_0.clone()),
                };
                match &v25_1 {
                    File_system::US13::US13_0(v25_1_0_0) => Ok(v25_1_0_0.clone()),
                    File_system::US13::US13_1(v25_1_1_0) => {
                        let v40: string = v25_1_1_0.clone();
                        let v41: string = File_system::method19(v0_1.clone());
                        let v42: Option<string> = File_system::method78(v0_1.clone());
                        let v56: File_system::US1 =
                            defaultValue(File_system::US1::US1_1, map(File_system::method4(), v42));
                        if let File_system::US1::US1_0(v56_0_0) = &v56 {
                            let v60: string = match &v56 {
                                File_system::US1::US1_0(x) => x.clone(),
                                _ => unreachable!(),
                            };
                            if v0_1.clone() != string("") {
                                let v66: Result<std::path::PathBuf, std::io::Error> =
                                    std::fs::read_link(&*v60.clone());
                                let v67 = File_system::method76();
                                let v78: Result<std::path::PathBuf, string> =
                                    v66.map_err(|x| v67(x));
                                let v81: File_system::US13 = match &v78 {
                                    Err(v78_1_0) => v24_1(v78_1_0.clone()),
                                    Ok(v78_0_0) => v23_1(v78_0_0.clone()),
                                };
                                let v2744: Result<std::path::PathBuf, std::io::Error> = match &v81 {
                                    File_system::US13::US13_0(v81_0_0) => Ok(v81_0_0.clone()),
                                    File_system::US13::US13_1(v81_1_0) => {
                                        let v96: string = v81_1_0.clone();
                                        let v97: string = File_system::method19(v60.clone());
                                        let v98: Option<string> =
                                            File_system::method78(v60.clone());
                                        let v112: File_system::US1 = defaultValue(
                                            File_system::US1::US1_1,
                                            map(File_system::method4(), v98),
                                        );
                                        if let File_system::US1::US1_0(v112_0_0) = &v112 {
                                            let v116: string = match &v112 {
                                                File_system::US1::US1_0(x) => x.clone(),
                                                _ => unreachable!(),
                                            };
                                            if v60.clone() != string("") {
                                                let v121: Result<
                                                    std::path::PathBuf,
                                                    std::io::Error,
                                                > = std::fs::read_link(&*v116.clone());
                                                let v122 = File_system::method76();
                                                let v133: Result<std::path::PathBuf, string> =
                                                    v121.map_err(|x| v122(x));
                                                let v136: File_system::US13 = match &v133 {
                                                    Err(v133_1_0) => v24_1(v133_1_0.clone()),
                                                    Ok(v133_0_0) => v23_1(v133_0_0.clone()),
                                                };
                                                let v2539: Result<
                                                    std::path::PathBuf,
                                                    std::io::Error,
                                                > = match &v136 {
                                                    File_system::US13::US13_0(v136_0_0) => {
                                                        Ok(v136_0_0.clone())
                                                    }
                                                    File_system::US13::US13_1(v136_1_0) => {
                                                        let v151: string = v136_1_0.clone();
                                                        let v152: string =
                                                            File_system::method19(v116.clone());
                                                        let v153: Option<string> =
                                                            File_system::method78(v116.clone());
                                                        let v167: File_system::US1 = defaultValue(
                                                            File_system::US1::US1_1,
                                                            map(File_system::method4(), v153),
                                                        );
                                                        if let File_system::US1::US1_0(v167_0_0) =
                                                            &v167
                                                        {
                                                            let v171: string = match &v167 {
                                                                File_system::US1::US1_0(x) => {
                                                                    x.clone()
                                                                }
                                                                _ => unreachable!(),
                                                            };
                                                            if v116.clone() != string("") {
                                                                let v176: Result<
                                                                    std::path::PathBuf,
                                                                    std::io::Error,
                                                                > = std::fs::read_link(
                                                                    &*v171.clone(),
                                                                );
                                                                let v177 = File_system::method76();
                                                                let v188: Result<
                                                                    std::path::PathBuf,
                                                                    string,
                                                                > = v176.map_err(|x| v177(x));
                                                                let v191: File_system::US13 =
                                                                    match &v188 {
                                                                        Err(v188_1_0) => {
                                                                            v24_1(v188_1_0.clone())
                                                                        }
                                                                        Ok(v188_0_0) => {
                                                                            v23_1(v188_0_0.clone())
                                                                        }
                                                                    };
                                                                let v2334: Result<
                                                                    std::path::PathBuf,
                                                                    std::io::Error,
                                                                > = match &v191 {
                                                                    File_system::US13::US13_0(
                                                                        v191_0_0,
                                                                    ) => Ok(v191_0_0.clone()),
                                                                    File_system::US13::US13_1(
                                                                        v191_1_0,
                                                                    ) => {
                                                                        let v206: string =
                                                                            v191_1_0.clone();
                                                                        let v207: string =
                                                                            File_system::method19(
                                                                                v171.clone(),
                                                                            );
                                                                        let v208: Option<string> =
                                                                            File_system::method78(
                                                                                v171.clone(),
                                                                            );
                                                                        let v222:
                                                                                                File_system::US1 =
                                                                                            defaultValue(File_system::US1::US1_1,
                                                                                                         map(File_system::method4(),
                                                                                                             v208));
                                                                        if let File_system::US1::US1_0(v222_0_0)
                                                                                               =
                                                                                               &v222
                                                                                           {
                                                                                            let v226:
                                                                                                    string =
                                                                                                match &v222
                                                                                                    {
                                                                                                    File_system::US1::US1_0(x)
                                                                                                    =>
                                                                                                    x.clone(),
                                                                                                    _
                                                                                                    =>
                                                                                                    unreachable!(),
                                                                                                };
                                                                                            if v171.clone()
                                                                                                   !=
                                                                                                   string("")
                                                                                               {
                                                                                                let v231:
                                                                                                        Result<std::path::PathBuf,
                                                                                                               std::io::Error> =
                                                                                                    std::fs::read_link(&*v226.clone());
                                                                                                let v232 =
                                                                                                    File_system::method76();
                                                                                                let v243:
                                                                                                        Result<std::path::PathBuf,
                                                                                                               string> =
                                                                                                    v231.map_err(|x| v232(x));
                                                                                                let v246:
                                                                                                        File_system::US13 =
                                                                                                    match &v243
                                                                                                        {
                                                                                                        Err(v243_1_0)
                                                                                                        =>
                                                                                                        v24_1(v243_1_0.clone()),
                                                                                                        Ok(v243_0_0)
                                                                                                        =>
                                                                                                        v23_1(v243_0_0.clone()),
                                                                                                    };
                                                                                                let v2129:
                                                                                                        Result<std::path::PathBuf,
                                                                                                               std::io::Error> =
                                                                                                    match &v246
                                                                                                        {
                                                                                                        File_system::US13::US13_0(v246_0_0)
                                                                                                        =>
                                                                                                        Ok(v246_0_0.clone()),
                                                                                                        File_system::US13::US13_1(v246_1_0)
                                                                                                        =>
                                                                                                        {
                                                                                                            let v261:
                                                                                                                    string =
                                                                                                                v246_1_0.clone();
                                                                                                            let v262:
                                                                                                                    string =
                                                                                                                File_system::method19(v226.clone());
                                                                                                            let v263:
                                                                                                                    Option<string> =
                                                                                                                File_system::method78(v226.clone());
                                                                                                            let v277:
                                                                                                                    File_system::US1 =
                                                                                                                defaultValue(File_system::US1::US1_1,
                                                                                                                             map(File_system::method4(),
                                                                                                                                 v263));
                                                                                                            if let File_system::US1::US1_0(v277_0_0)
                                                                                                                   =
                                                                                                                   &v277
                                                                                                               {
                                                                                                                let v281:
                                                                                                                        string =
                                                                                                                    match &v277
                                                                                                                        {
                                                                                                                        File_system::US1::US1_0(x)
                                                                                                                        =>
                                                                                                                        x.clone(),
                                                                                                                        _
                                                                                                                        =>
                                                                                                                        unreachable!(),
                                                                                                                    };
                                                                                                                if v226.clone()
                                                                                                                       !=
                                                                                                                       string("")
                                                                                                                   {
                                                                                                                    let v286:
                                                                                                                            Result<std::path::PathBuf,
                                                                                                                                   std::io::Error> =
                                                                                                                        std::fs::read_link(&*v281.clone());
                                                                                                                    let v287 =
                                                                                                                        File_system::method76();
                                                                                                                    let v298:
                                                                                                                            Result<std::path::PathBuf,
                                                                                                                                   string> =
                                                                                                                        v286.map_err(|x| v287(x));
                                                                                                                    let v301:
                                                                                                                            File_system::US13 =
                                                                                                                        match &v298
                                                                                                                            {
                                                                                                                            Err(v298_1_0)
                                                                                                                            =>
                                                                                                                            v24_1(v298_1_0.clone()),
                                                                                                                            Ok(v298_0_0)
                                                                                                                            =>
                                                                                                                            v23_1(v298_0_0.clone()),
                                                                                                                        };
                                                                                                                    let v1924:
                                                                                                                            Result<std::path::PathBuf,
                                                                                                                                   std::io::Error> =
                                                                                                                        match &v301
                                                                                                                            {
                                                                                                                            File_system::US13::US13_0(v301_0_0)
                                                                                                                            =>
                                                                                                                            Ok(v301_0_0.clone()),
                                                                                                                            File_system::US13::US13_1(v301_1_0)
                                                                                                                            =>
                                                                                                                            {
                                                                                                                                let v316:
                                                                                                                                        string =
                                                                                                                                    v301_1_0.clone();
                                                                                                                                let v317:
                                                                                                                                        string =
                                                                                                                                    File_system::method19(v281.clone());
                                                                                                                                let v318:
                                                                                                                                        Option<string> =
                                                                                                                                    File_system::method78(v281.clone());
                                                                                                                                let v332:
                                                                                                                                        File_system::US1 =
                                                                                                                                    defaultValue(File_system::US1::US1_1,
                                                                                                                                                 map(File_system::method4(),
                                                                                                                                                     v318));
                                                                                                                                if let File_system::US1::US1_0(v332_0_0)
                                                                                                                                       =
                                                                                                                                       &v332
                                                                                                                                   {
                                                                                                                                    let v336:
                                                                                                                                            string =
                                                                                                                                        match &v332
                                                                                                                                            {
                                                                                                                                            File_system::US1::US1_0(x)
                                                                                                                                            =>
                                                                                                                                            x.clone(),
                                                                                                                                            _
                                                                                                                                            =>
                                                                                                                                            unreachable!(),
                                                                                                                                        };
                                                                                                                                    if v281.clone()
                                                                                                                                           !=
                                                                                                                                           string("")
                                                                                                                                       {
                                                                                                                                        let v341:
                                                                                                                                                Result<std::path::PathBuf,
                                                                                                                                                       std::io::Error> =
                                                                                                                                            std::fs::read_link(&*v336.clone());
                                                                                                                                        let v342 =
                                                                                                                                            File_system::method76();
                                                                                                                                        let v353:
                                                                                                                                                Result<std::path::PathBuf,
                                                                                                                                                       string> =
                                                                                                                                            v341.map_err(|x| v342(x));
                                                                                                                                        let v356:
                                                                                                                                                File_system::US13 =
                                                                                                                                            match &v353
                                                                                                                                                {
                                                                                                                                                Err(v353_1_0)
                                                                                                                                                =>
                                                                                                                                                v24_1(v353_1_0.clone()),
                                                                                                                                                Ok(v353_0_0)
                                                                                                                                                =>
                                                                                                                                                v23_1(v353_0_0.clone()),
                                                                                                                                            };
                                                                                                                                        let v1719:
                                                                                                                                                Result<std::path::PathBuf,
                                                                                                                                                       std::io::Error> =
                                                                                                                                            match &v356
                                                                                                                                                {
                                                                                                                                                File_system::US13::US13_0(v356_0_0)
                                                                                                                                                =>
                                                                                                                                                Ok(v356_0_0.clone()),
                                                                                                                                                File_system::US13::US13_1(v356_1_0)
                                                                                                                                                =>
                                                                                                                                                {
                                                                                                                                                    let v371:
                                                                                                                                                            string =
                                                                                                                                                        v356_1_0.clone();
                                                                                                                                                    let v372:
                                                                                                                                                            string =
                                                                                                                                                        File_system::method19(v336.clone());
                                                                                                                                                    let v373:
                                                                                                                                                            Option<string> =
                                                                                                                                                        File_system::method78(v336.clone());
                                                                                                                                                    let v387:
                                                                                                                                                            File_system::US1 =
                                                                                                                                                        defaultValue(File_system::US1::US1_1,
                                                                                                                                                                     map(File_system::method4(),
                                                                                                                                                                         v373));
                                                                                                                                                    if let File_system::US1::US1_0(v387_0_0)
                                                                                                                                                           =
                                                                                                                                                           &v387
                                                                                                                                                       {
                                                                                                                                                        let v391:
                                                                                                                                                                string =
                                                                                                                                                            match &v387
                                                                                                                                                                {
                                                                                                                                                                File_system::US1::US1_0(x)
                                                                                                                                                                =>
                                                                                                                                                                x.clone(),
                                                                                                                                                                _
                                                                                                                                                                =>
                                                                                                                                                                unreachable!(),
                                                                                                                                                            };
                                                                                                                                                        if v336.clone()
                                                                                                                                                               !=
                                                                                                                                                               string("")
                                                                                                                                                           {
                                                                                                                                                            let v396:
                                                                                                                                                                    Result<std::path::PathBuf,
                                                                                                                                                                           std::io::Error> =
                                                                                                                                                                std::fs::read_link(&*v391.clone());
                                                                                                                                                            let v397 =
                                                                                                                                                                File_system::method76();
                                                                                                                                                            let v408:
                                                                                                                                                                    Result<std::path::PathBuf,
                                                                                                                                                                           string> =
                                                                                                                                                                v396.map_err(|x| v397(x));
                                                                                                                                                            let v411:
                                                                                                                                                                    File_system::US13 =
                                                                                                                                                                match &v408
                                                                                                                                                                    {
                                                                                                                                                                    Err(v408_1_0)
                                                                                                                                                                    =>
                                                                                                                                                                    v24_1(v408_1_0.clone()),
                                                                                                                                                                    Ok(v408_0_0)
                                                                                                                                                                    =>
                                                                                                                                                                    v23_1(v408_0_0.clone()),
                                                                                                                                                                };
                                                                                                                                                            let v1514:
                                                                                                                                                                    Result<std::path::PathBuf,
                                                                                                                                                                           std::io::Error> =
                                                                                                                                                                match &v411
                                                                                                                                                                    {
                                                                                                                                                                    File_system::US13::US13_0(v411_0_0)
                                                                                                                                                                    =>
                                                                                                                                                                    Ok(v411_0_0.clone()),
                                                                                                                                                                    File_system::US13::US13_1(v411_1_0)
                                                                                                                                                                    =>
                                                                                                                                                                    {
                                                                                                                                                                        let v426:
                                                                                                                                                                                string =
                                                                                                                                                                            v411_1_0.clone();
                                                                                                                                                                        let v427:
                                                                                                                                                                                string =
                                                                                                                                                                            File_system::method19(v391.clone());
                                                                                                                                                                        let v428:
                                                                                                                                                                                Option<string> =
                                                                                                                                                                            File_system::method78(v391.clone());
                                                                                                                                                                        let v442:
                                                                                                                                                                                File_system::US1 =
                                                                                                                                                                            defaultValue(File_system::US1::US1_1,
                                                                                                                                                                                         map(File_system::method4(),
                                                                                                                                                                                             v428));
                                                                                                                                                                        if let File_system::US1::US1_0(v442_0_0)
                                                                                                                                                                               =
                                                                                                                                                                               &v442
                                                                                                                                                                           {
                                                                                                                                                                            let v446:
                                                                                                                                                                                    string =
                                                                                                                                                                                match &v442
                                                                                                                                                                                    {
                                                                                                                                                                                    File_system::US1::US1_0(x)
                                                                                                                                                                                    =>
                                                                                                                                                                                    x.clone(),
                                                                                                                                                                                    _
                                                                                                                                                                                    =>
                                                                                                                                                                                    unreachable!(),
                                                                                                                                                                                };
                                                                                                                                                                            if v391.clone()
                                                                                                                                                                                   !=
                                                                                                                                                                                   string("")
                                                                                                                                                                               {
                                                                                                                                                                                let v451:
                                                                                                                                                                                        Result<std::path::PathBuf,
                                                                                                                                                                                               std::io::Error> =
                                                                                                                                                                                    std::fs::read_link(&*v446.clone());
                                                                                                                                                                                let v452 =
                                                                                                                                                                                    File_system::method76();
                                                                                                                                                                                let v463:
                                                                                                                                                                                        Result<std::path::PathBuf,
                                                                                                                                                                                               string> =
                                                                                                                                                                                    v451.map_err(|x| v452(x));
                                                                                                                                                                                let v466:
                                                                                                                                                                                        File_system::US13 =
                                                                                                                                                                                    match &v463
                                                                                                                                                                                        {
                                                                                                                                                                                        Err(v463_1_0)
                                                                                                                                                                                        =>
                                                                                                                                                                                        v24_1(v463_1_0.clone()),
                                                                                                                                                                                        Ok(v463_0_0)
                                                                                                                                                                                        =>
                                                                                                                                                                                        v23_1(v463_0_0.clone()),
                                                                                                                                                                                    };
                                                                                                                                                                                let v1309:
                                                                                                                                                                                        Result<std::path::PathBuf,
                                                                                                                                                                                               std::io::Error> =
                                                                                                                                                                                    match &v466
                                                                                                                                                                                        {
                                                                                                                                                                                        File_system::US13::US13_0(v466_0_0)
                                                                                                                                                                                        =>
                                                                                                                                                                                        Ok(v466_0_0.clone()),
                                                                                                                                                                                        File_system::US13::US13_1(v466_1_0)
                                                                                                                                                                                        =>
                                                                                                                                                                                        {
                                                                                                                                                                                            let v481:
                                                                                                                                                                                                    string =
                                                                                                                                                                                                v466_1_0.clone();
                                                                                                                                                                                            let v482:
                                                                                                                                                                                                    string =
                                                                                                                                                                                                File_system::method19(v446.clone());
                                                                                                                                                                                            let v483:
                                                                                                                                                                                                    Option<string> =
                                                                                                                                                                                                File_system::method78(v446.clone());
                                                                                                                                                                                            let v497:
                                                                                                                                                                                                    File_system::US1 =
                                                                                                                                                                                                defaultValue(File_system::US1::US1_1,
                                                                                                                                                                                                             map(File_system::method4(),
                                                                                                                                                                                                                 v483));
                                                                                                                                                                                            if let File_system::US1::US1_0(v497_0_0)
                                                                                                                                                                                                   =
                                                                                                                                                                                                   &v497
                                                                                                                                                                                               {
                                                                                                                                                                                                let v501:
                                                                                                                                                                                                        string =
                                                                                                                                                                                                    match &v497
                                                                                                                                                                                                        {
                                                                                                                                                                                                        File_system::US1::US1_0(x)
                                                                                                                                                                                                        =>
                                                                                                                                                                                                        x.clone(),
                                                                                                                                                                                                        _
                                                                                                                                                                                                        =>
                                                                                                                                                                                                        unreachable!(),
                                                                                                                                                                                                    };
                                                                                                                                                                                                if v446.clone()
                                                                                                                                                                                                       !=
                                                                                                                                                                                                       string("")
                                                                                                                                                                                                   {
                                                                                                                                                                                                    let v506:
                                                                                                                                                                                                            Result<std::path::PathBuf,
                                                                                                                                                                                                                   std::io::Error> =
                                                                                                                                                                                                        std::fs::read_link(&*v501.clone());
                                                                                                                                                                                                    let v507 =
                                                                                                                                                                                                        File_system::method76();
                                                                                                                                                                                                    let v518:
                                                                                                                                                                                                            Result<std::path::PathBuf,
                                                                                                                                                                                                                   string> =
                                                                                                                                                                                                        v506.map_err(|x| v507(x));
                                                                                                                                                                                                    let v521:
                                                                                                                                                                                                            File_system::US13 =
                                                                                                                                                                                                        match &v518
                                                                                                                                                                                                            {
                                                                                                                                                                                                            Err(v518_1_0)
                                                                                                                                                                                                            =>
                                                                                                                                                                                                            v24_1(v518_1_0.clone()),
                                                                                                                                                                                                            Ok(v518_0_0)
                                                                                                                                                                                                            =>
                                                                                                                                                                                                            v23_1(v518_0_0.clone()),
                                                                                                                                                                                                        };
                                                                                                                                                                                                    let v1104:
                                                                                                                                                                                                            Result<std::path::PathBuf,
                                                                                                                                                                                                                   std::io::Error> =
                                                                                                                                                                                                        match &v521
                                                                                                                                                                                                            {
                                                                                                                                                                                                            File_system::US13::US13_0(v521_0_0)
                                                                                                                                                                                                            =>
                                                                                                                                                                                                            Ok(v521_0_0.clone()),
                                                                                                                                                                                                            File_system::US13::US13_1(v521_1_0)
                                                                                                                                                                                                            =>
                                                                                                                                                                                                            {
                                                                                                                                                                                                                let v536:
                                                                                                                                                                                                                        string =
                                                                                                                                                                                                                    v521_1_0.clone();
                                                                                                                                                                                                                let v537:
                                                                                                                                                                                                                        string =
                                                                                                                                                                                                                    File_system::method19(v501.clone());
                                                                                                                                                                                                                let v538:
                                                                                                                                                                                                                        Option<string> =
                                                                                                                                                                                                                    File_system::method78(v501.clone());
                                                                                                                                                                                                                let v552:
                                                                                                                                                                                                                        File_system::US1 =
                                                                                                                                                                                                                    defaultValue(File_system::US1::US1_1,
                                                                                                                                                                                                                                 map(File_system::method4(),
                                                                                                                                                                                                                                     v538));
                                                                                                                                                                                                                if let File_system::US1::US1_0(v552_0_0)
                                                                                                                                                                                                                       =
                                                                                                                                                                                                                       &v552
                                                                                                                                                                                                                   {
                                                                                                                                                                                                                    let v556:
                                                                                                                                                                                                                            string =
                                                                                                                                                                                                                        match &v552
                                                                                                                                                                                                                            {
                                                                                                                                                                                                                            File_system::US1::US1_0(x)
                                                                                                                                                                                                                            =>
                                                                                                                                                                                                                            x.clone(),
                                                                                                                                                                                                                            _
                                                                                                                                                                                                                            =>
                                                                                                                                                                                                                            unreachable!(),
                                                                                                                                                                                                                        };
                                                                                                                                                                                                                    if v501.clone()
                                                                                                                                                                                                                           !=
                                                                                                                                                                                                                           string("")
                                                                                                                                                                                                                       {
                                                                                                                                                                                                                        let v561:
                                                                                                                                                                                                                                Result<std::path::PathBuf,
                                                                                                                                                                                                                                       std::io::Error> =
                                                                                                                                                                                                                            std::fs::read_link(&*v556.clone());
                                                                                                                                                                                                                        let v562 =
                                                                                                                                                                                                                            File_system::method76();
                                                                                                                                                                                                                        let v573:
                                                                                                                                                                                                                                Result<std::path::PathBuf,
                                                                                                                                                                                                                                       string> =
                                                                                                                                                                                                                            v561.map_err(|x| v562(x));
                                                                                                                                                                                                                        let v576:
                                                                                                                                                                                                                                File_system::US13 =
                                                                                                                                                                                                                            match &v573
                                                                                                                                                                                                                                {
                                                                                                                                                                                                                                Err(v573_1_0)
                                                                                                                                                                                                                                =>
                                                                                                                                                                                                                                v24_1(v573_1_0.clone()),
                                                                                                                                                                                                                                Ok(v573_0_0)
                                                                                                                                                                                                                                =>
                                                                                                                                                                                                                                v23_1(v573_0_0.clone()),
                                                                                                                                                                                                                            };
                                                                                                                                                                                                                        let v899:
                                                                                                                                                                                                                                Result<std::path::PathBuf,
                                                                                                                                                                                                                                       std::io::Error> =
                                                                                                                                                                                                                            match &v576
                                                                                                                                                                                                                                {
                                                                                                                                                                                                                                File_system::US13::US13_0(v576_0_0)
                                                                                                                                                                                                                                =>
                                                                                                                                                                                                                                Ok(v576_0_0.clone()),
                                                                                                                                                                                                                                File_system::US13::US13_1(v576_1_0)
                                                                                                                                                                                                                                =>
                                                                                                                                                                                                                                {
                                                                                                                                                                                                                                    let v591:
                                                                                                                                                                                                                                            string =
                                                                                                                                                                                                                                        v576_1_0.clone();
                                                                                                                                                                                                                                    let v592:
                                                                                                                                                                                                                                            string =
                                                                                                                                                                                                                                        File_system::method19(v556.clone());
                                                                                                                                                                                                                                    let v593:
                                                                                                                                                                                                                                            Option<string> =
                                                                                                                                                                                                                                        File_system::method78(v556.clone());
                                                                                                                                                                                                                                    let v607:
                                                                                                                                                                                                                                            File_system::US1 =
                                                                                                                                                                                                                                        defaultValue(File_system::US1::US1_1,
                                                                                                                                                                                                                                                     map(File_system::method4(),
                                                                                                                                                                                                                                                         v593));
                                                                                                                                                                                                                                    if let File_system::US1::US1_0(v607_0_0)
                                                                                                                                                                                                                                           =
                                                                                                                                                                                                                                           &v607
                                                                                                                                                                                                                                       {
                                                                                                                                                                                                                                        let v611:
                                                                                                                                                                                                                                                string =
                                                                                                                                                                                                                                            match &v607
                                                                                                                                                                                                                                                {
                                                                                                                                                                                                                                                File_system::US1::US1_0(x)
                                                                                                                                                                                                                                                =>
                                                                                                                                                                                                                                                x.clone(),
                                                                                                                                                                                                                                                _
                                                                                                                                                                                                                                                =>
                                                                                                                                                                                                                                                unreachable!(),
                                                                                                                                                                                                                                            };
                                                                                                                                                                                                                                        if v556.clone()
                                                                                                                                                                                                                                               !=
                                                                                                                                                                                                                                               string("")
                                                                                                                                                                                                                                           {
                                                                                                                                                                                                                                            let v616:
                                                                                                                                                                                                                                                    Result<std::path::PathBuf,
                                                                                                                                                                                                                                                           std::io::Error> =
                                                                                                                                                                                                                                                std::fs::read_link(&*v611.clone());
                                                                                                                                                                                                                                            let v617 =
                                                                                                                                                                                                                                                File_system::method76();
                                                                                                                                                                                                                                            let v628:
                                                                                                                                                                                                                                                    Result<std::path::PathBuf,
                                                                                                                                                                                                                                                           string> =
                                                                                                                                                                                                                                                v616.map_err(|x| v617(x));
                                                                                                                                                                                                                                            let v631:
                                                                                                                                                                                                                                                    File_system::US13 =
                                                                                                                                                                                                                                                match &v628
                                                                                                                                                                                                                                                    {
                                                                                                                                                                                                                                                    Err(v628_1_0)
                                                                                                                                                                                                                                                    =>
                                                                                                                                                                                                                                                    v24_1(v628_1_0.clone()),
                                                                                                                                                                                                                                                    Ok(v628_0_0)
                                                                                                                                                                                                                                                    =>
                                                                                                                                                                                                                                                    v23_1(v628_0_0.clone()),
                                                                                                                                                                                                                                                };
                                                                                                                                                                                                                                            let v694:
                                                                                                                                                                                                                                                    Result<std::path::PathBuf,
                                                                                                                                                                                                                                                           std::io::Error> =
                                                                                                                                                                                                                                                match &v631
                                                                                                                                                                                                                                                    {
                                                                                                                                                                                                                                                    File_system::US13::US13_0(v631_0_0)
                                                                                                                                                                                                                                                    =>
                                                                                                                                                                                                                                                    Ok(v631_0_0.clone()),
                                                                                                                                                                                                                                                    _
                                                                                                                                                                                                                                                    =>
                                                                                                                                                                                                                                                    {
                                                                                                                                                                                                                                                        let v647:
                                                                                                                                                                                                                                                                string =
                                                                                                                                                                                                                                                            File_system::method19(v611.clone());
                                                                                                                                                                                                                                                        let v648:
                                                                                                                                                                                                                                                                Option<string> =
                                                                                                                                                                                                                                                            File_system::method78(v611.clone());
                                                                                                                                                                                                                                                        let v662:
                                                                                                                                                                                                                                                                File_system::US1 =
                                                                                                                                                                                                                                                            defaultValue(File_system::US1::US1_1,
                                                                                                                                                                                                                                                                         map(File_system::method4(),
                                                                                                                                                                                                                                                                             v648));
                                                                                                                                                                                                                                                        let v666:
                                                                                                                                                                                                                                                                string =
                                                                                                                                                                                                                                                            sprintf!("file_system.read_link / path: {} / n: {} / path\': {} / name: {}",
                                                                                                                                                                                                                                                                     v0_1.clone(),
                                                                                                                                                                                                                                                                     11_u8,
                                                                                                                                                                                                                                                                     v611.clone(),
                                                                                                                                                                                                                                                                     v647);
                                                                                                                                                                                                                                                        let v669:
                                                                                                                                                                                                                                                                std::io::Error =
                                                                                                                                                                                                                                                            std::io::Error::new(std::io::ErrorKind::Other, &*v666);
                                                                                                                                                                                                                                                        Err(v669)
                                                                                                                                                                                                                                                    }
                                                                                                                                                                                                                                                };
                                                                                                                                                                                                                                            let v695 =
                                                                                                                                                                                                                                                File_system::method76();
                                                                                                                                                                                                                                            let v706:
                                                                                                                                                                                                                                                    Result<std::path::PathBuf,
                                                                                                                                                                                                                                                           string> =
                                                                                                                                                                                                                                                v694.map_err(|x| v695(x));
                                                                                                                                                                                                                                            let v709:
                                                                                                                                                                                                                                                    File_system::US13 =
                                                                                                                                                                                                                                                match &v706
                                                                                                                                                                                                                                                    {
                                                                                                                                                                                                                                                    Err(v706_1_0)
                                                                                                                                                                                                                                                    =>
                                                                                                                                                                                                                                                    v24_1(v706_1_0.clone()),
                                                                                                                                                                                                                                                    Ok(v706_0_0)
                                                                                                                                                                                                                                                    =>
                                                                                                                                                                                                                                                    v23_1(v706_0_0.clone()),
                                                                                                                                                                                                                                                };
                                                                                                                                                                                                                                            match &v709
                                                                                                                                                                                                                                                {
                                                                                                                                                                                                                                                File_system::US13::US13_0(v709_0_0)
                                                                                                                                                                                                                                                =>
                                                                                                                                                                                                                                                {
                                                                                                                                                                                                                                                    let v735:
                                                                                                                                                                                                                                                            string =
                                                                                                                                                                                                                                                        File_system::method56(toString(v709_0_0.clone().display()),
                                                                                                                                                                                                                                                                              v592.clone());
                                                                                                                                                                                                                                                    let v738:
                                                                                                                                                                                                                                                            &str =
                                                                                                                                                                                                                                                        &*v735;
                                                                                                                                                                                                                                                    let v759:
                                                                                                                                                                                                                                                            std::string::String =
                                                                                                                                                                                                                                                        String::from(v738);
                                                                                                                                                                                                                                                    let v780:
                                                                                                                                                                                                                                                            std::path::PathBuf =
                                                                                                                                                                                                                                                        std::path::PathBuf::from(v759);
                                                                                                                                                                                                                                                    Ok(v780)
                                                                                                                                                                                                                                                }
                                                                                                                                                                                                                                                File_system::US13::US13_1(v709_1_0)
                                                                                                                                                                                                                                                =>
                                                                                                                                                                                                                                                {
                                                                                                                                                                                                                                                    let v813:
                                                                                                                                                                                                                                                            string =
                                                                                                                                                                                                                                                        sprintf!("file_system.read_link / error\': {} / error: {} / name: {}",
                                                                                                                                                                                                                                                                 v709_1_0.clone(),
                                                                                                                                                                                                                                                                 v591.clone(),
                                                                                                                                                                                                                                                                 v592.clone());
                                                                                                                                                                                                                                                    let v816:
                                                                                                                                                                                                                                                            std::io::Error =
                                                                                                                                                                                                                                                        std::io::Error::new(std::io::ErrorKind::Other, &*v813);
                                                                                                                                                                                                                                                    Err(v816)
                                                                                                                                                                                                                                                }
                                                                                                                                                                                                                                            }
                                                                                                                                                                                                                                        } else {
                                                                                                                                                                                                                                            let v842:
                                                                                                                                                                                                                                                    string =
                                                                                                                                                                                                                                                sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                                                                                                                                                                                                                         v0_1.clone(),
                                                                                                                                                                                                                                                         v591.clone(),
                                                                                                                                                                                                                                                         v556.clone(),
                                                                                                                                                                                                                                                         v592.clone());
                                                                                                                                                                                                                                            let v845:
                                                                                                                                                                                                                                                    std::io::Error =
                                                                                                                                                                                                                                                std::io::Error::new(std::io::ErrorKind::Other, &*v842);
                                                                                                                                                                                                                                            Err(v845)
                                                                                                                                                                                                                                        }
                                                                                                                                                                                                                                    } else {
                                                                                                                                                                                                                                        let v870:
                                                                                                                                                                                                                                                string =
                                                                                                                                                                                                                                            sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                                                                                                                                                                                                                     v0_1.clone(),
                                                                                                                                                                                                                                                     v591,
                                                                                                                                                                                                                                                     v556.clone(),
                                                                                                                                                                                                                                                     v592.clone());
                                                                                                                                                                                                                                        let v873:
                                                                                                                                                                                                                                                std::io::Error =
                                                                                                                                                                                                                                            std::io::Error::new(std::io::ErrorKind::Other, &*v870);
                                                                                                                                                                                                                                        Err(v873)
                                                                                                                                                                                                                                    }
                                                                                                                                                                                                                                }
                                                                                                                                                                                                                            };
                                                                                                                                                                                                                        let v900 =
                                                                                                                                                                                                                            File_system::method76();
                                                                                                                                                                                                                        let v911:
                                                                                                                                                                                                                                Result<std::path::PathBuf,
                                                                                                                                                                                                                                       string> =
                                                                                                                                                                                                                            v899.map_err(|x| v900(x));
                                                                                                                                                                                                                        let v914:
                                                                                                                                                                                                                                File_system::US13 =
                                                                                                                                                                                                                            match &v911
                                                                                                                                                                                                                                {
                                                                                                                                                                                                                                Err(v911_1_0)
                                                                                                                                                                                                                                =>
                                                                                                                                                                                                                                v24_1(v911_1_0.clone()),
                                                                                                                                                                                                                                Ok(v911_0_0)
                                                                                                                                                                                                                                =>
                                                                                                                                                                                                                                v23_1(v911_0_0.clone()),
                                                                                                                                                                                                                            };
                                                                                                                                                                                                                        match &v914
                                                                                                                                                                                                                            {
                                                                                                                                                                                                                            File_system::US13::US13_0(v914_0_0)
                                                                                                                                                                                                                            =>
                                                                                                                                                                                                                            {
                                                                                                                                                                                                                                let v940:
                                                                                                                                                                                                                                        string =
                                                                                                                                                                                                                                    File_system::method56(toString(v914_0_0.clone().display()),
                                                                                                                                                                                                                                                          v537.clone());
                                                                                                                                                                                                                                let v943:
                                                                                                                                                                                                                                        &str =
                                                                                                                                                                                                                                    &*v940;
                                                                                                                                                                                                                                let v964:
                                                                                                                                                                                                                                        std::string::String =
                                                                                                                                                                                                                                    String::from(v943);
                                                                                                                                                                                                                                let v985:
                                                                                                                                                                                                                                        std::path::PathBuf =
                                                                                                                                                                                                                                    std::path::PathBuf::from(v964);
                                                                                                                                                                                                                                Ok(v985)
                                                                                                                                                                                                                            }
                                                                                                                                                                                                                            File_system::US13::US13_1(v914_1_0)
                                                                                                                                                                                                                            =>
                                                                                                                                                                                                                            {
                                                                                                                                                                                                                                let v1018:
                                                                                                                                                                                                                                        string =
                                                                                                                                                                                                                                    sprintf!("file_system.read_link / error\': {} / error: {} / name: {}",
                                                                                                                                                                                                                                             v914_1_0.clone(),
                                                                                                                                                                                                                                             v536.clone(),
                                                                                                                                                                                                                                             v537.clone());
                                                                                                                                                                                                                                let v1021:
                                                                                                                                                                                                                                        std::io::Error =
                                                                                                                                                                                                                                    std::io::Error::new(std::io::ErrorKind::Other, &*v1018);
                                                                                                                                                                                                                                Err(v1021)
                                                                                                                                                                                                                            }
                                                                                                                                                                                                                        }
                                                                                                                                                                                                                    } else {
                                                                                                                                                                                                                        let v1047:
                                                                                                                                                                                                                                string =
                                                                                                                                                                                                                            sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                                                                                                                                                                                                     v0_1.clone(),
                                                                                                                                                                                                                                     v536.clone(),
                                                                                                                                                                                                                                     v501.clone(),
                                                                                                                                                                                                                                     v537.clone());
                                                                                                                                                                                                                        let v1050:
                                                                                                                                                                                                                                std::io::Error =
                                                                                                                                                                                                                            std::io::Error::new(std::io::ErrorKind::Other, &*v1047);
                                                                                                                                                                                                                        Err(v1050)
                                                                                                                                                                                                                    }
                                                                                                                                                                                                                } else {
                                                                                                                                                                                                                    let v1075:
                                                                                                                                                                                                                            string =
                                                                                                                                                                                                                        sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                                                                                                                                                                                                 v0_1.clone(),
                                                                                                                                                                                                                                 v536,
                                                                                                                                                                                                                                 v501.clone(),
                                                                                                                                                                                                                                 v537.clone());
                                                                                                                                                                                                                    let v1078:
                                                                                                                                                                                                                            std::io::Error =
                                                                                                                                                                                                                        std::io::Error::new(std::io::ErrorKind::Other, &*v1075);
                                                                                                                                                                                                                    Err(v1078)
                                                                                                                                                                                                                }
                                                                                                                                                                                                            }
                                                                                                                                                                                                        };
                                                                                                                                                                                                    let v1105 =
                                                                                                                                                                                                        File_system::method76();
                                                                                                                                                                                                    let v1116:
                                                                                                                                                                                                            Result<std::path::PathBuf,
                                                                                                                                                                                                                   string> =
                                                                                                                                                                                                        v1104.map_err(|x| v1105(x));
                                                                                                                                                                                                    let v1119:
                                                                                                                                                                                                            File_system::US13 =
                                                                                                                                                                                                        match &v1116
                                                                                                                                                                                                            {
                                                                                                                                                                                                            Err(v1116_1_0)
                                                                                                                                                                                                            =>
                                                                                                                                                                                                            v24_1(v1116_1_0.clone()),
                                                                                                                                                                                                            Ok(v1116_0_0)
                                                                                                                                                                                                            =>
                                                                                                                                                                                                            v23_1(v1116_0_0.clone()),
                                                                                                                                                                                                        };
                                                                                                                                                                                                    match &v1119
                                                                                                                                                                                                        {
                                                                                                                                                                                                        File_system::US13::US13_0(v1119_0_0)
                                                                                                                                                                                                        =>
                                                                                                                                                                                                        {
                                                                                                                                                                                                            let v1145:
                                                                                                                                                                                                                    string =
                                                                                                                                                                                                                File_system::method56(toString(v1119_0_0.clone().display()),
                                                                                                                                                                                                                                      v482.clone());
                                                                                                                                                                                                            let v1148:
                                                                                                                                                                                                                    &str =
                                                                                                                                                                                                                &*v1145;
                                                                                                                                                                                                            let v1169:
                                                                                                                                                                                                                    std::string::String =
                                                                                                                                                                                                                String::from(v1148);
                                                                                                                                                                                                            let v1190:
                                                                                                                                                                                                                    std::path::PathBuf =
                                                                                                                                                                                                                std::path::PathBuf::from(v1169);
                                                                                                                                                                                                            Ok(v1190)
                                                                                                                                                                                                        }
                                                                                                                                                                                                        File_system::US13::US13_1(v1119_1_0)
                                                                                                                                                                                                        =>
                                                                                                                                                                                                        {
                                                                                                                                                                                                            let v1223:
                                                                                                                                                                                                                    string =
                                                                                                                                                                                                                sprintf!("file_system.read_link / error\': {} / error: {} / name: {}",
                                                                                                                                                                                                                         v1119_1_0.clone(),
                                                                                                                                                                                                                         v481.clone(),
                                                                                                                                                                                                                         v482.clone());
                                                                                                                                                                                                            let v1226:
                                                                                                                                                                                                                    std::io::Error =
                                                                                                                                                                                                                std::io::Error::new(std::io::ErrorKind::Other, &*v1223);
                                                                                                                                                                                                            Err(v1226)
                                                                                                                                                                                                        }
                                                                                                                                                                                                    }
                                                                                                                                                                                                } else {
                                                                                                                                                                                                    let v1252:
                                                                                                                                                                                                            string =
                                                                                                                                                                                                        sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                                                                                                                                                                                 v0_1.clone(),
                                                                                                                                                                                                                 v481.clone(),
                                                                                                                                                                                                                 v446.clone(),
                                                                                                                                                                                                                 v482.clone());
                                                                                                                                                                                                    let v1255:
                                                                                                                                                                                                            std::io::Error =
                                                                                                                                                                                                        std::io::Error::new(std::io::ErrorKind::Other, &*v1252);
                                                                                                                                                                                                    Err(v1255)
                                                                                                                                                                                                }
                                                                                                                                                                                            } else {
                                                                                                                                                                                                let v1280:
                                                                                                                                                                                                        string =
                                                                                                                                                                                                    sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                                                                                                                                                                             v0_1.clone(),
                                                                                                                                                                                                             v481,
                                                                                                                                                                                                             v446.clone(),
                                                                                                                                                                                                             v482.clone());
                                                                                                                                                                                                let v1283:
                                                                                                                                                                                                        std::io::Error =
                                                                                                                                                                                                    std::io::Error::new(std::io::ErrorKind::Other, &*v1280);
                                                                                                                                                                                                Err(v1283)
                                                                                                                                                                                            }
                                                                                                                                                                                        }
                                                                                                                                                                                    };
                                                                                                                                                                                let v1310 =
                                                                                                                                                                                    File_system::method76();
                                                                                                                                                                                let v1321:
                                                                                                                                                                                        Result<std::path::PathBuf,
                                                                                                                                                                                               string> =
                                                                                                                                                                                    v1309.map_err(|x| v1310(x));
                                                                                                                                                                                let v1324:
                                                                                                                                                                                        File_system::US13 =
                                                                                                                                                                                    match &v1321
                                                                                                                                                                                        {
                                                                                                                                                                                        Err(v1321_1_0)
                                                                                                                                                                                        =>
                                                                                                                                                                                        v24_1(v1321_1_0.clone()),
                                                                                                                                                                                        Ok(v1321_0_0)
                                                                                                                                                                                        =>
                                                                                                                                                                                        v23_1(v1321_0_0.clone()),
                                                                                                                                                                                    };
                                                                                                                                                                                match &v1324
                                                                                                                                                                                    {
                                                                                                                                                                                    File_system::US13::US13_0(v1324_0_0)
                                                                                                                                                                                    =>
                                                                                                                                                                                    {
                                                                                                                                                                                        let v1350:
                                                                                                                                                                                                string =
                                                                                                                                                                                            File_system::method56(toString(v1324_0_0.clone().display()),
                                                                                                                                                                                                                  v427.clone());
                                                                                                                                                                                        let v1353:
                                                                                                                                                                                                &str =
                                                                                                                                                                                            &*v1350;
                                                                                                                                                                                        let v1374:
                                                                                                                                                                                                std::string::String =
                                                                                                                                                                                            String::from(v1353);
                                                                                                                                                                                        let v1395:
                                                                                                                                                                                                std::path::PathBuf =
                                                                                                                                                                                            std::path::PathBuf::from(v1374);
                                                                                                                                                                                        Ok(v1395)
                                                                                                                                                                                    }
                                                                                                                                                                                    File_system::US13::US13_1(v1324_1_0)
                                                                                                                                                                                    =>
                                                                                                                                                                                    {
                                                                                                                                                                                        let v1428:
                                                                                                                                                                                                string =
                                                                                                                                                                                            sprintf!("file_system.read_link / error\': {} / error: {} / name: {}",
                                                                                                                                                                                                     v1324_1_0.clone(),
                                                                                                                                                                                                     v426.clone(),
                                                                                                                                                                                                     v427.clone());
                                                                                                                                                                                        let v1431:
                                                                                                                                                                                                std::io::Error =
                                                                                                                                                                                            std::io::Error::new(std::io::ErrorKind::Other, &*v1428);
                                                                                                                                                                                        Err(v1431)
                                                                                                                                                                                    }
                                                                                                                                                                                }
                                                                                                                                                                            } else {
                                                                                                                                                                                let v1457:
                                                                                                                                                                                        string =
                                                                                                                                                                                    sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                                                                                                                                                             v0_1.clone(),
                                                                                                                                                                                             v426.clone(),
                                                                                                                                                                                             v391.clone(),
                                                                                                                                                                                             v427.clone());
                                                                                                                                                                                let v1460:
                                                                                                                                                                                        std::io::Error =
                                                                                                                                                                                    std::io::Error::new(std::io::ErrorKind::Other, &*v1457);
                                                                                                                                                                                Err(v1460)
                                                                                                                                                                            }
                                                                                                                                                                        } else {
                                                                                                                                                                            let v1485:
                                                                                                                                                                                    string =
                                                                                                                                                                                sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                                                                                                                                                         v0_1.clone(),
                                                                                                                                                                                         v426,
                                                                                                                                                                                         v391.clone(),
                                                                                                                                                                                         v427.clone());
                                                                                                                                                                            let v1488:
                                                                                                                                                                                    std::io::Error =
                                                                                                                                                                                std::io::Error::new(std::io::ErrorKind::Other, &*v1485);
                                                                                                                                                                            Err(v1488)
                                                                                                                                                                        }
                                                                                                                                                                    }
                                                                                                                                                                };
                                                                                                                                                            let v1515 =
                                                                                                                                                                File_system::method76();
                                                                                                                                                            let v1526:
                                                                                                                                                                    Result<std::path::PathBuf,
                                                                                                                                                                           string> =
                                                                                                                                                                v1514.map_err(|x| v1515(x));
                                                                                                                                                            let v1529:
                                                                                                                                                                    File_system::US13 =
                                                                                                                                                                match &v1526
                                                                                                                                                                    {
                                                                                                                                                                    Err(v1526_1_0)
                                                                                                                                                                    =>
                                                                                                                                                                    v24_1(v1526_1_0.clone()),
                                                                                                                                                                    Ok(v1526_0_0)
                                                                                                                                                                    =>
                                                                                                                                                                    v23_1(v1526_0_0.clone()),
                                                                                                                                                                };
                                                                                                                                                            match &v1529
                                                                                                                                                                {
                                                                                                                                                                File_system::US13::US13_0(v1529_0_0)
                                                                                                                                                                =>
                                                                                                                                                                {
                                                                                                                                                                    let v1555:
                                                                                                                                                                            string =
                                                                                                                                                                        File_system::method56(toString(v1529_0_0.clone().display()),
                                                                                                                                                                                              v372.clone());
                                                                                                                                                                    let v1558:
                                                                                                                                                                            &str =
                                                                                                                                                                        &*v1555;
                                                                                                                                                                    let v1579:
                                                                                                                                                                            std::string::String =
                                                                                                                                                                        String::from(v1558);
                                                                                                                                                                    let v1600:
                                                                                                                                                                            std::path::PathBuf =
                                                                                                                                                                        std::path::PathBuf::from(v1579);
                                                                                                                                                                    Ok(v1600)
                                                                                                                                                                }
                                                                                                                                                                File_system::US13::US13_1(v1529_1_0)
                                                                                                                                                                =>
                                                                                                                                                                {
                                                                                                                                                                    let v1633:
                                                                                                                                                                            string =
                                                                                                                                                                        sprintf!("file_system.read_link / error\': {} / error: {} / name: {}",
                                                                                                                                                                                 v1529_1_0.clone(),
                                                                                                                                                                                 v371.clone(),
                                                                                                                                                                                 v372.clone());
                                                                                                                                                                    let v1636:
                                                                                                                                                                            std::io::Error =
                                                                                                                                                                        std::io::Error::new(std::io::ErrorKind::Other, &*v1633);
                                                                                                                                                                    Err(v1636)
                                                                                                                                                                }
                                                                                                                                                            }
                                                                                                                                                        } else {
                                                                                                                                                            let v1662:
                                                                                                                                                                    string =
                                                                                                                                                                sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                                                                                                                                         v0_1.clone(),
                                                                                                                                                                         v371.clone(),
                                                                                                                                                                         v336.clone(),
                                                                                                                                                                         v372.clone());
                                                                                                                                                            let v1665:
                                                                                                                                                                    std::io::Error =
                                                                                                                                                                std::io::Error::new(std::io::ErrorKind::Other, &*v1662);
                                                                                                                                                            Err(v1665)
                                                                                                                                                        }
                                                                                                                                                    } else {
                                                                                                                                                        let v1690:
                                                                                                                                                                string =
                                                                                                                                                            sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                                                                                                                                     v0_1.clone(),
                                                                                                                                                                     v371,
                                                                                                                                                                     v336.clone(),
                                                                                                                                                                     v372.clone());
                                                                                                                                                        let v1693:
                                                                                                                                                                std::io::Error =
                                                                                                                                                            std::io::Error::new(std::io::ErrorKind::Other, &*v1690);
                                                                                                                                                        Err(v1693)
                                                                                                                                                    }
                                                                                                                                                }
                                                                                                                                            };
                                                                                                                                        let v1720 =
                                                                                                                                            File_system::method76();
                                                                                                                                        let v1731:
                                                                                                                                                Result<std::path::PathBuf,
                                                                                                                                                       string> =
                                                                                                                                            v1719.map_err(|x| v1720(x));
                                                                                                                                        let v1734:
                                                                                                                                                File_system::US13 =
                                                                                                                                            match &v1731
                                                                                                                                                {
                                                                                                                                                Err(v1731_1_0)
                                                                                                                                                =>
                                                                                                                                                v24_1(v1731_1_0.clone()),
                                                                                                                                                Ok(v1731_0_0)
                                                                                                                                                =>
                                                                                                                                                v23_1(v1731_0_0.clone()),
                                                                                                                                            };
                                                                                                                                        match &v1734
                                                                                                                                            {
                                                                                                                                            File_system::US13::US13_0(v1734_0_0)
                                                                                                                                            =>
                                                                                                                                            {
                                                                                                                                                let v1760:
                                                                                                                                                        string =
                                                                                                                                                    File_system::method56(toString(v1734_0_0.clone().display()),
                                                                                                                                                                          v317.clone());
                                                                                                                                                let v1763:
                                                                                                                                                        &str =
                                                                                                                                                    &*v1760;
                                                                                                                                                let v1784:
                                                                                                                                                        std::string::String =
                                                                                                                                                    String::from(v1763);
                                                                                                                                                let v1805:
                                                                                                                                                        std::path::PathBuf =
                                                                                                                                                    std::path::PathBuf::from(v1784);
                                                                                                                                                Ok(v1805)
                                                                                                                                            }
                                                                                                                                            File_system::US13::US13_1(v1734_1_0)
                                                                                                                                            =>
                                                                                                                                            {
                                                                                                                                                let v1838:
                                                                                                                                                        string =
                                                                                                                                                    sprintf!("file_system.read_link / error\': {} / error: {} / name: {}",
                                                                                                                                                             v1734_1_0.clone(),
                                                                                                                                                             v316.clone(),
                                                                                                                                                             v317.clone());
                                                                                                                                                let v1841:
                                                                                                                                                        std::io::Error =
                                                                                                                                                    std::io::Error::new(std::io::ErrorKind::Other, &*v1838);
                                                                                                                                                Err(v1841)
                                                                                                                                            }
                                                                                                                                        }
                                                                                                                                    } else {
                                                                                                                                        let v1867:
                                                                                                                                                string =
                                                                                                                                            sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                                                                                                                     v0_1.clone(),
                                                                                                                                                     v316.clone(),
                                                                                                                                                     v281.clone(),
                                                                                                                                                     v317.clone());
                                                                                                                                        let v1870:
                                                                                                                                                std::io::Error =
                                                                                                                                            std::io::Error::new(std::io::ErrorKind::Other, &*v1867);
                                                                                                                                        Err(v1870)
                                                                                                                                    }
                                                                                                                                } else {
                                                                                                                                    let v1895:
                                                                                                                                            string =
                                                                                                                                        sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                                                                                                                 v0_1.clone(),
                                                                                                                                                 v316,
                                                                                                                                                 v281.clone(),
                                                                                                                                                 v317.clone());
                                                                                                                                    let v1898:
                                                                                                                                            std::io::Error =
                                                                                                                                        std::io::Error::new(std::io::ErrorKind::Other, &*v1895);
                                                                                                                                    Err(v1898)
                                                                                                                                }
                                                                                                                            }
                                                                                                                        };
                                                                                                                    let v1925 =
                                                                                                                        File_system::method76();
                                                                                                                    let v1936:
                                                                                                                            Result<std::path::PathBuf,
                                                                                                                                   string> =
                                                                                                                        v1924.map_err(|x| v1925(x));
                                                                                                                    let v1939:
                                                                                                                            File_system::US13 =
                                                                                                                        match &v1936
                                                                                                                            {
                                                                                                                            Err(v1936_1_0)
                                                                                                                            =>
                                                                                                                            v24_1(v1936_1_0.clone()),
                                                                                                                            Ok(v1936_0_0)
                                                                                                                            =>
                                                                                                                            v23_1(v1936_0_0.clone()),
                                                                                                                        };
                                                                                                                    match &v1939
                                                                                                                        {
                                                                                                                        File_system::US13::US13_0(v1939_0_0)
                                                                                                                        =>
                                                                                                                        {
                                                                                                                            let v1965:
                                                                                                                                    string =
                                                                                                                                File_system::method56(toString(v1939_0_0.clone().display()),
                                                                                                                                                      v262.clone());
                                                                                                                            let v1968:
                                                                                                                                    &str =
                                                                                                                                &*v1965;
                                                                                                                            let v1989:
                                                                                                                                    std::string::String =
                                                                                                                                String::from(v1968);
                                                                                                                            let v2010:
                                                                                                                                    std::path::PathBuf =
                                                                                                                                std::path::PathBuf::from(v1989);
                                                                                                                            Ok(v2010)
                                                                                                                        }
                                                                                                                        File_system::US13::US13_1(v1939_1_0)
                                                                                                                        =>
                                                                                                                        {
                                                                                                                            let v2043:
                                                                                                                                    string =
                                                                                                                                sprintf!("file_system.read_link / error\': {} / error: {} / name: {}",
                                                                                                                                         v1939_1_0.clone(),
                                                                                                                                         v261.clone(),
                                                                                                                                         v262.clone());
                                                                                                                            let v2046:
                                                                                                                                    std::io::Error =
                                                                                                                                std::io::Error::new(std::io::ErrorKind::Other, &*v2043);
                                                                                                                            Err(v2046)
                                                                                                                        }
                                                                                                                    }
                                                                                                                } else {
                                                                                                                    let v2072:
                                                                                                                            string =
                                                                                                                        sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                                                                                                 v0_1.clone(),
                                                                                                                                 v261.clone(),
                                                                                                                                 v226.clone(),
                                                                                                                                 v262.clone());
                                                                                                                    let v2075:
                                                                                                                            std::io::Error =
                                                                                                                        std::io::Error::new(std::io::ErrorKind::Other, &*v2072);
                                                                                                                    Err(v2075)
                                                                                                                }
                                                                                                            } else {
                                                                                                                let v2100:
                                                                                                                        string =
                                                                                                                    sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                                                                                             v0_1.clone(),
                                                                                                                             v261,
                                                                                                                             v226.clone(),
                                                                                                                             v262.clone());
                                                                                                                let v2103:
                                                                                                                        std::io::Error =
                                                                                                                    std::io::Error::new(std::io::ErrorKind::Other, &*v2100);
                                                                                                                Err(v2103)
                                                                                                            }
                                                                                                        }
                                                                                                    };
                                                                                                let v2130 =
                                                                                                    File_system::method76();
                                                                                                let v2141:
                                                                                                        Result<std::path::PathBuf,
                                                                                                               string> =
                                                                                                    v2129.map_err(|x| v2130(x));
                                                                                                let v2144:
                                                                                                        File_system::US13 =
                                                                                                    match &v2141
                                                                                                        {
                                                                                                        Err(v2141_1_0)
                                                                                                        =>
                                                                                                        v24_1(v2141_1_0.clone()),
                                                                                                        Ok(v2141_0_0)
                                                                                                        =>
                                                                                                        v23_1(v2141_0_0.clone()),
                                                                                                    };
                                                                                                match &v2144
                                                                                                    {
                                                                                                    File_system::US13::US13_0(v2144_0_0)
                                                                                                    =>
                                                                                                    {
                                                                                                        let v2170:
                                                                                                                string =
                                                                                                            File_system::method56(toString(v2144_0_0.clone().display()),
                                                                                                                                  v207.clone());
                                                                                                        let v2173:
                                                                                                                &str =
                                                                                                            &*v2170;
                                                                                                        let v2194:
                                                                                                                std::string::String =
                                                                                                            String::from(v2173);
                                                                                                        let v2215:
                                                                                                                std::path::PathBuf =
                                                                                                            std::path::PathBuf::from(v2194);
                                                                                                        Ok(v2215)
                                                                                                    }
                                                                                                    File_system::US13::US13_1(v2144_1_0)
                                                                                                    =>
                                                                                                    {
                                                                                                        let v2248:
                                                                                                                string =
                                                                                                            sprintf!("file_system.read_link / error\': {} / error: {} / name: {}",
                                                                                                                     v2144_1_0.clone(),
                                                                                                                     v206.clone(),
                                                                                                                     v207.clone());
                                                                                                        let v2251:
                                                                                                                std::io::Error =
                                                                                                            std::io::Error::new(std::io::ErrorKind::Other, &*v2248);
                                                                                                        Err(v2251)
                                                                                                    }
                                                                                                }
                                                                                            } else {
                                                                                                let v2277:
                                                                                                        string =
                                                                                                    sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                                                                             v0_1.clone(),
                                                                                                             v206.clone(),
                                                                                                             v171.clone(),
                                                                                                             v207.clone());
                                                                                                let v2280:
                                                                                                        std::io::Error =
                                                                                                    std::io::Error::new(std::io::ErrorKind::Other, &*v2277);
                                                                                                Err(v2280)
                                                                                            }
                                                                                        } else {
                                                                                            let v2305:
                                                                                                    string =
                                                                                                sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                                                                         v0_1.clone(),
                                                                                                         v206,
                                                                                                         v171.clone(),
                                                                                                         v207.clone());
                                                                                            let v2308:
                                                                                                    std::io::Error =
                                                                                                std::io::Error::new(std::io::ErrorKind::Other, &*v2305);
                                                                                            Err(v2308)
                                                                                        }
                                                                    }
                                                                };
                                                                let v2335 = File_system::method76();
                                                                let v2346: Result<
                                                                    std::path::PathBuf,
                                                                    string,
                                                                > = v2334.map_err(|x| v2335(x));
                                                                let v2349: File_system::US13 =
                                                                    match &v2346 {
                                                                        Err(v2346_1_0) => {
                                                                            v24_1(v2346_1_0.clone())
                                                                        }
                                                                        Ok(v2346_0_0) => {
                                                                            v23_1(v2346_0_0.clone())
                                                                        }
                                                                    };
                                                                match &v2349 {
                                                                    File_system::US13::US13_0(
                                                                        v2349_0_0,
                                                                    ) => {
                                                                        let v2375: string =
                                                                            File_system::method56(
                                                                                toString(
                                                                                    v2349_0_0
                                                                                        .clone()
                                                                                        .display(),
                                                                                ),
                                                                                v152.clone(),
                                                                            );
                                                                        let v2378: &str = &*v2375;
                                                                        let v2399:
                                                                                            std::string::String =
                                                                                        String::from(v2378);
                                                                        let v2420:
                                                                                            std::path::PathBuf =
                                                                                        std::path::PathBuf::from(v2399);
                                                                        Ok(v2420)
                                                                    }
                                                                    File_system::US13::US13_1(
                                                                        v2349_1_0,
                                                                    ) => {
                                                                        let v2453:
                                                                                            string =
                                                                                        sprintf!("file_system.read_link / error\': {} / error: {} / name: {}",
                                                                                                 v2349_1_0.clone(),
                                                                                                 v151.clone(),
                                                                                                 v152.clone());
                                                                        let v2456:
                                                                                            std::io::Error =
                                                                                        std::io::Error::new(std::io::ErrorKind::Other, &*v2453);
                                                                        Err(v2456)
                                                                    }
                                                                }
                                                            } else {
                                                                let v2482:
                                                                                    string =
                                                                                sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                                                         v0_1.clone(),
                                                                                         v151.clone(),
                                                                                         v116.clone(),
                                                                                         v152.clone());
                                                                let v2485: std::io::Error =
                                                                    std::io::Error::new(
                                                                        std::io::ErrorKind::Other,
                                                                        &*v2482,
                                                                    );
                                                                Err(v2485)
                                                            }
                                                        } else {
                                                            let v2510:
                                                                                string =
                                                                            sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                                                     v0_1.clone(),
                                                                                     v151,
                                                                                     v116.clone(),
                                                                                     v152.clone());
                                                            let v2513: std::io::Error =
                                                                std::io::Error::new(
                                                                    std::io::ErrorKind::Other,
                                                                    &*v2510,
                                                                );
                                                            Err(v2513)
                                                        }
                                                    }
                                                };
                                                let v2540 = File_system::method76();
                                                let v2551: Result<std::path::PathBuf, string> =
                                                    v2539.map_err(|x| v2540(x));
                                                let v2554: File_system::US13 = match &v2551 {
                                                    Err(v2551_1_0) => v24_1(v2551_1_0.clone()),
                                                    Ok(v2551_0_0) => v23_1(v2551_0_0.clone()),
                                                };
                                                match &v2554 {
                                                    File_system::US13::US13_0(v2554_0_0) => {
                                                        let v2580: string = File_system::method56(
                                                            toString(v2554_0_0.clone().display()),
                                                            v97.clone(),
                                                        );
                                                        let v2583: &str = &*v2580;
                                                        let v2604: std::string::String =
                                                            String::from(v2583);
                                                        let v2625: std::path::PathBuf =
                                                            std::path::PathBuf::from(v2604);
                                                        Ok(v2625)
                                                    }
                                                    File_system::US13::US13_1(v2554_1_0) => {
                                                        let v2658:
                                                                        string =
                                                                    sprintf!("file_system.read_link / error\': {} / error: {} / name: {}",
                                                                             v2554_1_0.clone(),
                                                                             v96.clone(),
                                                                             v97.clone());
                                                        let v2661: std::io::Error =
                                                            std::io::Error::new(
                                                                std::io::ErrorKind::Other,
                                                                &*v2658,
                                                            );
                                                        Err(v2661)
                                                    }
                                                }
                                            } else {
                                                let v2687: string =
                                                            sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                                     v0_1.clone(),
                                                                     v96.clone(),
                                                                     v60.clone(),
                                                                     v97.clone());
                                                let v2690: std::io::Error = std::io::Error::new(
                                                    std::io::ErrorKind::Other,
                                                    &*v2687,
                                                );
                                                Err(v2690)
                                            }
                                        } else {
                                            let v2715: string =
                                                        sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                                 v0_1.clone(),
                                                                 v96,
                                                                 v60.clone(),
                                                                 v97.clone());
                                            let v2718: std::io::Error = std::io::Error::new(
                                                std::io::ErrorKind::Other,
                                                &*v2715,
                                            );
                                            Err(v2718)
                                        }
                                    }
                                };
                                let v2745 = File_system::method76();
                                let v2756: Result<std::path::PathBuf, string> =
                                    v2744.map_err(|x| v2745(x));
                                let v2759: File_system::US13 = match &v2756 {
                                    Err(v2756_1_0) => v24_1(v2756_1_0.clone()),
                                    Ok(v2756_0_0) => v23_1(v2756_0_0.clone()),
                                };
                                match &v2759 {
                                    File_system::US13::US13_0(v2759_0_0) => {
                                        let v2785: string = File_system::method56(
                                            toString(v2759_0_0.clone().display()),
                                            v41.clone(),
                                        );
                                        let v2788: &str = &*v2785;
                                        let v2809: std::string::String = String::from(v2788);
                                        let v2830: std::path::PathBuf =
                                            std::path::PathBuf::from(v2809);
                                        Ok(v2830)
                                    }
                                    File_system::US13::US13_1(v2759_1_0) => {
                                        let v2863: string =
                                                sprintf!("file_system.read_link / error\': {} / error: {} / name: {}",
                                                         v2759_1_0.clone(),
                                                         v40.clone(),
                                                         v41.clone());
                                        let v2866: std::io::Error =
                                            std::io::Error::new(std::io::ErrorKind::Other, &*v2863);
                                        Err(v2866)
                                    }
                                }
                            } else {
                                let v2892: string =
                                        sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                 v0_1.clone(), v40.clone(),
                                                 v0_1.clone(), v41.clone());
                                let v2895: std::io::Error =
                                    std::io::Error::new(std::io::ErrorKind::Other, &*v2892);
                                Err(v2895)
                            }
                        } else {
                            let v2920: string =
                                    sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                             v0_1.clone(), v40, v0_1.clone(),
                                             v41.clone());
                            let v2923: std::io::Error =
                                std::io::Error::new(std::io::ErrorKind::Other, &*v2920);
                            Err(v2923)
                        }
                    }
                }
            };
            let v13137: Option<std::path::PathBuf> = v2950.ok();
            let v13161: File_system::US14 = defaultValue(
                File_system::US14::US14_1,
                map(File_system::method80(), v13137),
            );
            let v13193: string = match &v13161 {
                File_system::US14::US14_0(v13161_0_0) => {
                    let v13187: string = toString(
                        match &v13161 {
                            File_system::US14::US14_0(x) => x.clone(),
                            _ => unreachable!(),
                        }
                        .display(),
                    );
                    if v13187.clone() == string("") {
                        v0_1.clone()
                    } else {
                        v13187
                    }
                }
                _ => v0_1.clone(),
            };
            if v13193.clone() == string("") {
                string("")
            } else {
                let v13200: Result<regex::Regex, regex::Error> =
                    regex::Regex::new(&string("^\\\\\\\\\\?\\\\"));
                let v13203: regex::Regex = v13200.unwrap();
                let v13214: string = File_system::method81(v13193);
                let v13216: std::borrow::Cow<str> = v13203.replace_all(&*v13214, &*string(""));
                let v13218: std::string::String = String::from(v13216);
                let v13234: string = fable_library_rust::String_::fromString(v13218);
                replace(
                    sprintf!(
                        "{}{}",
                        toLower(ofChar(getCharAt(v13234.clone(), 0_i32))),
                        getSlice(v13234, Some(1_i32), None::<i32>)
                    ),
                    string("\\"),
                    string("/"),
                )
            }
        }
    }
    pub fn closure45(unitVar: (), v0_1: string) -> string {
        File_system::method75(v0_1)
    }
    pub fn closure50(unitVar: (), v0_1: string) -> string {
        sprintf!("file:///{}", trimStartChars(v0_1, toArray(singleton('/'))))
    }
    pub fn closure52(unitVar: (), v0_1: string) -> Option<string> {
        File_system::method78(v0_1)
    }
    pub fn method83() -> Func1<string, Option<string>> {
        Func1::new(move |v: string| File_system::closure52((), v))
    }
    pub fn method84(v0_1: string, v1_1: string, v2_1: string) -> File_system::US15 {
        let v0_1: MutCell<string> = MutCell::new(v0_1.clone());
        let v1_1: MutCell<string> = MutCell::new(v1_1.clone());
        let v2_1: MutCell<string> = MutCell::new(v2_1.clone());
        '_method84: loop {
            break '_method84 (if File_system::method9(File_system::method56(
                v2_1.get().clone(),
                v0_1.get().clone(),
            )) {
                File_system::US15::US15_0(v2_1.get().clone())
            } else {
                let v7: Option<string> = (File_system::method83())(v2_1.get().clone());
                let v21_1: File_system::US1 =
                    defaultValue(File_system::US1::US1_1, map(File_system::method4(), v7));
                match &v21_1 {
                    File_system::US1::US1_0(v21_1_0_0) => {
                        let v0_1_temp: string = v0_1.get().clone();
                        let v1_1_temp: string = v1_1.get().clone();
                        let v2_1_temp: string = match &v21_1 {
                            File_system::US1::US1_0(x) => x.clone(),
                            _ => unreachable!(),
                        };
                        v0_1.set(v0_1_temp);
                        v1_1.set(v1_1_temp);
                        v2_1.set(v2_1_temp);
                        continue '_method84;
                    }
                    _ => File_system::US15::US15_1(sprintf!(
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
    pub fn method82(v0_1: string, v1_1: string) -> File_system::US15 {
        if File_system::method9(File_system::method56(v1_1.clone(), v0_1.clone())) {
            File_system::US15::US15_0(v1_1.clone())
        } else {
            let v6: Option<string> = (File_system::method83())(v1_1.clone());
            let v20_1: File_system::US1 =
                defaultValue(File_system::US1::US1_1, map(File_system::method4(), v6));
            match &v20_1 {
                File_system::US1::US1_0(v20_1_0_0) => File_system::method84(
                    v0_1.clone(),
                    v1_1.clone(),
                    match &v20_1 {
                        File_system::US1::US1_0(x) => x.clone(),
                        _ => unreachable!(),
                    },
                ),
                _ => File_system::US15::US15_1(sprintf!(
                    "No parent for {} \'{}\' at \'{}\' (until \'{}\')",
                    string("dir"),
                    v0_1.clone(),
                    v1_1.clone(),
                    v1_1.clone()
                )),
            }
        }
    }
    pub fn method86(v0_1: string) -> string {
        let v2_1: LrcPtr<File_system::Mut3> = LrcPtr::new(File_system::Mut3 {
            l0: MutCell::new(File_system::method17()),
        });
        let v9: () = {
            File_system::closure6(v2_1.clone(), sprintf!("{}", string("{ ")), ());
            ()
        };
        let v18_1: () = {
            File_system::closure6(v2_1.clone(), sprintf!("{}", string("error")), ());
            ()
        };
        let v27_1: () = {
            File_system::closure6(v2_1.clone(), sprintf!("{}", string(" = ")), ());
            ()
        };
        let v35_1: () = {
            File_system::closure6(v2_1.clone(), sprintf!("{}", v0_1), ());
            ()
        };
        let v44: () = {
            File_system::closure6(v2_1.clone(), sprintf!("{}", string(" }")), ());
            ()
        };
        v2_1.l0.get().clone()
    }
    pub fn method85(
        v0_1: LrcPtr<File_system::Mut0>,
        v1_1: LrcPtr<File_system::Mut1>,
        v2_1: LrcPtr<File_system::Mut2>,
        v3: LrcPtr<File_system::Mut3>,
        v4: LrcPtr<File_system::Mut4>,
        v5: Option<i64>,
        v6: string,
        v7: string,
        v8: string,
    ) -> string {
        let v9: string = File_system::method86(v8);
        File_system::method22(sprintf!(
            "{} {} #{} {} / {}",
            v6,
            v7,
            v0_1.l0.get().clone(),
            string("file_system.get_workspace_root"),
            v9
        ))
    }
    pub fn closure53(v0_1: string, unitVar: ()) {
        if File_system::method10(File_system::US0::US0_3) {
            let v5: () = {
                File_system::closure0((), ());
                ()
            };
            let patternInput: (
                LrcPtr<File_system::Mut0>,
                LrcPtr<File_system::Mut1>,
                LrcPtr<File_system::Mut2>,
                LrcPtr<File_system::Mut3>,
                LrcPtr<File_system::Mut4>,
                Option<i64>,
            ) = getValue(File_system::TraceState::trace_state().get().clone());
            let v24_1: Option<i64> = patternInput.5.clone();
            let v23_1: LrcPtr<File_system::Mut4> = patternInput.4.clone();
            let v22_1: LrcPtr<File_system::Mut3> = patternInput.3.clone();
            let v21_1: LrcPtr<File_system::Mut2> = patternInput.2.clone();
            let v20_1: LrcPtr<File_system::Mut1> = patternInput.1.clone();
            let v19_1: LrcPtr<File_system::Mut0> = patternInput.0.clone();
            File_system::method23(File_system::method85(
                v19_1.clone(),
                v20_1.clone(),
                v21_1.clone(),
                v22_1.clone(),
                v23_1.clone(),
                v24_1.clone(),
                File_system::method11(v19_1, v20_1, v21_1, v22_1, v23_1, v24_1),
                File_system::method32(),
                v0_1,
            ))
        };
    }
    pub fn method87() -> string {
        let v2_1: Result<std::path::PathBuf, std::io::Error> = std::env::current_dir();
        let v5: std::path::PathBuf = v2_1.unwrap();
        let v18_1: std::path::Display = v5.display();
        let v39: std::string::String = format!("{}", v18_1);
        fable_library_rust::String_::fromString(v39)
    }
    pub fn closure51(unitVar: (), unitVar_1: ()) -> string {
        let v4: File_system::US15 = File_system::method82(
            File_system::method56(string("polyglot"), string(".devcontainer")),
            string("/home/runner/work/polyglot/polyglot/lib/spiral"),
        );
        let v52: File_system::US1 = match &v4 {
            File_system::US15::US15_0(v4_0_0) => File_system::US1::US1_0(v4_0_0.clone()),
            File_system::US15::US15_1(v4_1_0) => {
                let v10: () = {
                    File_system::closure53(v4_1_0.clone(), ());
                    ()
                };
                File_system::US1::US1_1
            }
        };
        let v107: File_system::US1 = match &v52 {
            File_system::US1::US1_0(v52_0_0) => File_system::US1::US1_0(match &v52 {
                File_system::US1::US1_0(x) => x.clone(),
                _ => unreachable!(),
            }),
            _ => {
                let v55: string = File_system::method87();
                let v57: File_system::US15 = File_system::method82(
                    File_system::method56(string("polyglot"), string(".devcontainer")),
                    v55,
                );
                match &v57 {
                    File_system::US15::US15_0(v57_0_0) => File_system::US1::US1_0(v57_0_0.clone()),
                    File_system::US15::US15_1(v57_1_0) => {
                        let v63: () = {
                            File_system::closure53(v57_1_0.clone(), ());
                            ()
                        };
                        File_system::US1::US1_1
                    }
                }
            }
        };
        File_system::method56(
            match &v107 {
                File_system::US1::US1_0(v107_0_0) => match &v107 {
                    File_system::US1::US1_0(x) => x.clone(),
                    _ => unreachable!(),
                },
                _ => panic!("{}", string("Option does not have a value."),),
            },
            string("polyglot"),
        )
    }
    pub fn method88(v0_1: string) {
        ();
        ()
    }
    pub fn closure55(unitVar: (), v0_1: string) {
        File_system::method88(v0_1);
    }
    pub fn closure54(unitVar: (), v0_1: bool) {
        let v3: () = {
            File_system::closure0((), ());
            ()
        };
        let patternInput: (
            LrcPtr<File_system::Mut0>,
            LrcPtr<File_system::Mut1>,
            LrcPtr<File_system::Mut2>,
            LrcPtr<File_system::Mut3>,
            LrcPtr<File_system::Mut4>,
            Option<i64>,
        ) = getValue(File_system::TraceState::trace_state().get().clone());
        let v37 = if v0_1 {
            Func1::new(move |v: string| File_system::closure55((), v))
        } else {
            Func1::new(move |v_1: string| File_system::closure2((), v_1))
        };
        (patternInput.1.clone()).l0.set(v37);
        ()
    }
    pub fn method89(v0_1: string, v1_1: string) {
        if File_system::method9(v0_1.clone()) == false {
            let v4: LrcPtr<dyn IDisposable> = File_system::method61(v0_1.clone());
            ()
        }
        {
            let v5: string = File_system::method79(v1_1.clone());
            if File_system::method9(v5.clone()) == false {
                let v8: LrcPtr<dyn IDisposable> = File_system::method61(v5);
                ()
            }
            if if File_system::method9(v1_1.clone()) {
                let v2957: Result<std::path::PathBuf, std::io::Error> = if File_system::method9(
                    v1_1.clone(),
                ) {
                    std::fs::read_link(&*v1_1.clone())
                } else {
                    let v15: Result<std::path::PathBuf, std::io::Error> =
                        std::fs::read_link(&*v1_1.clone());
                    let v16_1 = File_system::method76();
                    let v27_1: Result<std::path::PathBuf, string> = v15.map_err(|x| v16_1(x));
                    fn v30_1(v: std::path::PathBuf) -> File_system::US13 {
                        File_system::closure47((), v)
                    }
                    fn v31_1(v_1: string) -> File_system::US13 {
                        File_system::closure48((), v_1)
                    }
                    let v32_1: File_system::US13 = match &v27_1 {
                        Err(v27_1_1_0) => v31_1(v27_1_1_0.clone()),
                        Ok(v27_1_0_0) => v30_1(v27_1_0_0.clone()),
                    };
                    match &v32_1 {
                        File_system::US13::US13_0(v32_1_0_0) => Ok(v32_1_0_0.clone()),
                        File_system::US13::US13_1(v32_1_1_0) => {
                            let v47: string = v32_1_1_0.clone();
                            let v48: string = File_system::method19(v1_1.clone());
                            let v49: Option<string> = File_system::method78(v1_1.clone());
                            let v63: File_system::US1 = defaultValue(
                                File_system::US1::US1_1,
                                map(File_system::method4(), v49),
                            );
                            if let File_system::US1::US1_0(v63_0_0) = &v63 {
                                let v67: string = match &v63 {
                                    File_system::US1::US1_0(x) => x.clone(),
                                    _ => unreachable!(),
                                };
                                if v1_1.clone() != string("") {
                                    let v73: Result<std::path::PathBuf, std::io::Error> =
                                        std::fs::read_link(&*v67.clone());
                                    let v74 = File_system::method76();
                                    let v85: Result<std::path::PathBuf, string> =
                                        v73.map_err(|x| v74(x));
                                    let v88: File_system::US13 = match &v85 {
                                        Err(v85_1_0) => v31_1(v85_1_0.clone()),
                                        Ok(v85_0_0) => v30_1(v85_0_0.clone()),
                                    };
                                    let v2751: Result<std::path::PathBuf, std::io::Error> =
                                        match &v88 {
                                            File_system::US13::US13_0(v88_0_0) => {
                                                Ok(v88_0_0.clone())
                                            }
                                            File_system::US13::US13_1(v88_1_0) => {
                                                let v103: string = v88_1_0.clone();
                                                let v104: string =
                                                    File_system::method19(v67.clone());
                                                let v105: Option<string> =
                                                    File_system::method78(v67.clone());
                                                let v119: File_system::US1 = defaultValue(
                                                    File_system::US1::US1_1,
                                                    map(File_system::method4(), v105),
                                                );
                                                if let File_system::US1::US1_0(v119_0_0) = &v119 {
                                                    let v123: string = match &v119 {
                                                        File_system::US1::US1_0(x) => x.clone(),
                                                        _ => unreachable!(),
                                                    };
                                                    if v67.clone() != string("") {
                                                        let v128: Result<
                                                            std::path::PathBuf,
                                                            std::io::Error,
                                                        > = std::fs::read_link(&*v123.clone());
                                                        let v129 = File_system::method76();
                                                        let v140: Result<
                                                            std::path::PathBuf,
                                                            string,
                                                        > = v128.map_err(|x| v129(x));
                                                        let v143: File_system::US13 = match &v140 {
                                                            Err(v140_1_0) => {
                                                                v31_1(v140_1_0.clone())
                                                            }
                                                            Ok(v140_0_0) => v30_1(v140_0_0.clone()),
                                                        };
                                                        let v2546: Result<
                                                            std::path::PathBuf,
                                                            std::io::Error,
                                                        > = match &v143 {
                                                            File_system::US13::US13_0(v143_0_0) => {
                                                                Ok(v143_0_0.clone())
                                                            }
                                                            File_system::US13::US13_1(v143_1_0) => {
                                                                let v158: string = v143_1_0.clone();
                                                                let v159: string =
                                                                    File_system::method19(
                                                                        v123.clone(),
                                                                    );
                                                                let v160: Option<string> =
                                                                    File_system::method78(
                                                                        v123.clone(),
                                                                    );
                                                                let v174: File_system::US1 =
                                                                    defaultValue(
                                                                        File_system::US1::US1_1,
                                                                        map(
                                                                            File_system::method4(),
                                                                            v160,
                                                                        ),
                                                                    );
                                                                if let File_system::US1::US1_0(
                                                                    v174_0_0,
                                                                ) = &v174
                                                                {
                                                                    let v178: string = match &v174 {
                                                                        File_system::US1::US1_0(
                                                                            x,
                                                                        ) => x.clone(),
                                                                        _ => unreachable!(),
                                                                    };
                                                                    if v123.clone() != string("") {
                                                                        let v183: Result<
                                                                            std::path::PathBuf,
                                                                            std::io::Error,
                                                                        > = std::fs::read_link(
                                                                            &*v178.clone(),
                                                                        );
                                                                        let v184 =
                                                                            File_system::method76();
                                                                        let v195: Result<
                                                                            std::path::PathBuf,
                                                                            string,
                                                                        > = v183
                                                                            .map_err(|x| v184(x));
                                                                        let v198:
                                                                                           File_system::US13 =
                                                                                       match &v195
                                                                                           {
                                                                                           Err(v195_1_0)
                                                                                           =>
                                                                                           v31_1(v195_1_0.clone()),
                                                                                           Ok(v195_0_0)
                                                                                           =>
                                                                                           v30_1(v195_0_0.clone()),
                                                                                       };
                                                                        let v2341:
                                                                                           Result<std::path::PathBuf,
                                                                                                  std::io::Error> =
                                                                                       match &v198
                                                                                           {
                                                                                           File_system::US13::US13_0(v198_0_0)
                                                                                           =>
                                                                                           Ok(v198_0_0.clone()),
                                                                                           File_system::US13::US13_1(v198_1_0)
                                                                                           =>
                                                                                           {
                                                                                               let v213:
                                                                                                       string =
                                                                                                   v198_1_0.clone();
                                                                                               let v214:
                                                                                                       string =
                                                                                                   File_system::method19(v178.clone());
                                                                                               let v215:
                                                                                                       Option<string> =
                                                                                                   File_system::method78(v178.clone());
                                                                                               let v229:
                                                                                                       File_system::US1 =
                                                                                                   defaultValue(File_system::US1::US1_1,
                                                                                                                map(File_system::method4(),
                                                                                                                    v215));
                                                                                               if let File_system::US1::US1_0(v229_0_0)
                                                                                                      =
                                                                                                      &v229
                                                                                                  {
                                                                                                   let v233:
                                                                                                           string =
                                                                                                       match &v229
                                                                                                           {
                                                                                                           File_system::US1::US1_0(x)
                                                                                                           =>
                                                                                                           x.clone(),
                                                                                                           _
                                                                                                           =>
                                                                                                           unreachable!(),
                                                                                                       };
                                                                                                   if v178.clone()
                                                                                                          !=
                                                                                                          string("")
                                                                                                      {
                                                                                                       let v238:
                                                                                                               Result<std::path::PathBuf,
                                                                                                                      std::io::Error> =
                                                                                                           std::fs::read_link(&*v233.clone());
                                                                                                       let v239 =
                                                                                                           File_system::method76();
                                                                                                       let v250:
                                                                                                               Result<std::path::PathBuf,
                                                                                                                      string> =
                                                                                                           v238.map_err(|x| v239(x));
                                                                                                       let v253:
                                                                                                               File_system::US13 =
                                                                                                           match &v250
                                                                                                               {
                                                                                                               Err(v250_1_0)
                                                                                                               =>
                                                                                                               v31_1(v250_1_0.clone()),
                                                                                                               Ok(v250_0_0)
                                                                                                               =>
                                                                                                               v30_1(v250_0_0.clone()),
                                                                                                           };
                                                                                                       let v2136:
                                                                                                               Result<std::path::PathBuf,
                                                                                                                      std::io::Error> =
                                                                                                           match &v253
                                                                                                               {
                                                                                                               File_system::US13::US13_0(v253_0_0)
                                                                                                               =>
                                                                                                               Ok(v253_0_0.clone()),
                                                                                                               File_system::US13::US13_1(v253_1_0)
                                                                                                               =>
                                                                                                               {
                                                                                                                   let v268:
                                                                                                                           string =
                                                                                                                       v253_1_0.clone();
                                                                                                                   let v269:
                                                                                                                           string =
                                                                                                                       File_system::method19(v233.clone());
                                                                                                                   let v270:
                                                                                                                           Option<string> =
                                                                                                                       File_system::method78(v233.clone());
                                                                                                                   let v284:
                                                                                                                           File_system::US1 =
                                                                                                                       defaultValue(File_system::US1::US1_1,
                                                                                                                                    map(File_system::method4(),
                                                                                                                                        v270));
                                                                                                                   if let File_system::US1::US1_0(v284_0_0)
                                                                                                                          =
                                                                                                                          &v284
                                                                                                                      {
                                                                                                                       let v288:
                                                                                                                               string =
                                                                                                                           match &v284
                                                                                                                               {
                                                                                                                               File_system::US1::US1_0(x)
                                                                                                                               =>
                                                                                                                               x.clone(),
                                                                                                                               _
                                                                                                                               =>
                                                                                                                               unreachable!(),
                                                                                                                           };
                                                                                                                       if v233.clone()
                                                                                                                              !=
                                                                                                                              string("")
                                                                                                                          {
                                                                                                                           let v293:
                                                                                                                                   Result<std::path::PathBuf,
                                                                                                                                          std::io::Error> =
                                                                                                                               std::fs::read_link(&*v288.clone());
                                                                                                                           let v294 =
                                                                                                                               File_system::method76();
                                                                                                                           let v305:
                                                                                                                                   Result<std::path::PathBuf,
                                                                                                                                          string> =
                                                                                                                               v293.map_err(|x| v294(x));
                                                                                                                           let v308:
                                                                                                                                   File_system::US13 =
                                                                                                                               match &v305
                                                                                                                                   {
                                                                                                                                   Err(v305_1_0)
                                                                                                                                   =>
                                                                                                                                   v31_1(v305_1_0.clone()),
                                                                                                                                   Ok(v305_0_0)
                                                                                                                                   =>
                                                                                                                                   v30_1(v305_0_0.clone()),
                                                                                                                               };
                                                                                                                           let v1931:
                                                                                                                                   Result<std::path::PathBuf,
                                                                                                                                          std::io::Error> =
                                                                                                                               match &v308
                                                                                                                                   {
                                                                                                                                   File_system::US13::US13_0(v308_0_0)
                                                                                                                                   =>
                                                                                                                                   Ok(v308_0_0.clone()),
                                                                                                                                   File_system::US13::US13_1(v308_1_0)
                                                                                                                                   =>
                                                                                                                                   {
                                                                                                                                       let v323:
                                                                                                                                               string =
                                                                                                                                           v308_1_0.clone();
                                                                                                                                       let v324:
                                                                                                                                               string =
                                                                                                                                           File_system::method19(v288.clone());
                                                                                                                                       let v325:
                                                                                                                                               Option<string> =
                                                                                                                                           File_system::method78(v288.clone());
                                                                                                                                       let v339:
                                                                                                                                               File_system::US1 =
                                                                                                                                           defaultValue(File_system::US1::US1_1,
                                                                                                                                                        map(File_system::method4(),
                                                                                                                                                            v325));
                                                                                                                                       if let File_system::US1::US1_0(v339_0_0)
                                                                                                                                              =
                                                                                                                                              &v339
                                                                                                                                          {
                                                                                                                                           let v343:
                                                                                                                                                   string =
                                                                                                                                               match &v339
                                                                                                                                                   {
                                                                                                                                                   File_system::US1::US1_0(x)
                                                                                                                                                   =>
                                                                                                                                                   x.clone(),
                                                                                                                                                   _
                                                                                                                                                   =>
                                                                                                                                                   unreachable!(),
                                                                                                                                               };
                                                                                                                                           if v288.clone()
                                                                                                                                                  !=
                                                                                                                                                  string("")
                                                                                                                                              {
                                                                                                                                               let v348:
                                                                                                                                                       Result<std::path::PathBuf,
                                                                                                                                                              std::io::Error> =
                                                                                                                                                   std::fs::read_link(&*v343.clone());
                                                                                                                                               let v349 =
                                                                                                                                                   File_system::method76();
                                                                                                                                               let v360:
                                                                                                                                                       Result<std::path::PathBuf,
                                                                                                                                                              string> =
                                                                                                                                                   v348.map_err(|x| v349(x));
                                                                                                                                               let v363:
                                                                                                                                                       File_system::US13 =
                                                                                                                                                   match &v360
                                                                                                                                                       {
                                                                                                                                                       Err(v360_1_0)
                                                                                                                                                       =>
                                                                                                                                                       v31_1(v360_1_0.clone()),
                                                                                                                                                       Ok(v360_0_0)
                                                                                                                                                       =>
                                                                                                                                                       v30_1(v360_0_0.clone()),
                                                                                                                                                   };
                                                                                                                                               let v1726:
                                                                                                                                                       Result<std::path::PathBuf,
                                                                                                                                                              std::io::Error> =
                                                                                                                                                   match &v363
                                                                                                                                                       {
                                                                                                                                                       File_system::US13::US13_0(v363_0_0)
                                                                                                                                                       =>
                                                                                                                                                       Ok(v363_0_0.clone()),
                                                                                                                                                       File_system::US13::US13_1(v363_1_0)
                                                                                                                                                       =>
                                                                                                                                                       {
                                                                                                                                                           let v378:
                                                                                                                                                                   string =
                                                                                                                                                               v363_1_0.clone();
                                                                                                                                                           let v379:
                                                                                                                                                                   string =
                                                                                                                                                               File_system::method19(v343.clone());
                                                                                                                                                           let v380:
                                                                                                                                                                   Option<string> =
                                                                                                                                                               File_system::method78(v343.clone());
                                                                                                                                                           let v394:
                                                                                                                                                                   File_system::US1 =
                                                                                                                                                               defaultValue(File_system::US1::US1_1,
                                                                                                                                                                            map(File_system::method4(),
                                                                                                                                                                                v380));
                                                                                                                                                           if let File_system::US1::US1_0(v394_0_0)
                                                                                                                                                                  =
                                                                                                                                                                  &v394
                                                                                                                                                              {
                                                                                                                                                               let v398:
                                                                                                                                                                       string =
                                                                                                                                                                   match &v394
                                                                                                                                                                       {
                                                                                                                                                                       File_system::US1::US1_0(x)
                                                                                                                                                                       =>
                                                                                                                                                                       x.clone(),
                                                                                                                                                                       _
                                                                                                                                                                       =>
                                                                                                                                                                       unreachable!(),
                                                                                                                                                                   };
                                                                                                                                                               if v343.clone()
                                                                                                                                                                      !=
                                                                                                                                                                      string("")
                                                                                                                                                                  {
                                                                                                                                                                   let v403:
                                                                                                                                                                           Result<std::path::PathBuf,
                                                                                                                                                                                  std::io::Error> =
                                                                                                                                                                       std::fs::read_link(&*v398.clone());
                                                                                                                                                                   let v404 =
                                                                                                                                                                       File_system::method76();
                                                                                                                                                                   let v415:
                                                                                                                                                                           Result<std::path::PathBuf,
                                                                                                                                                                                  string> =
                                                                                                                                                                       v403.map_err(|x| v404(x));
                                                                                                                                                                   let v418:
                                                                                                                                                                           File_system::US13 =
                                                                                                                                                                       match &v415
                                                                                                                                                                           {
                                                                                                                                                                           Err(v415_1_0)
                                                                                                                                                                           =>
                                                                                                                                                                           v31_1(v415_1_0.clone()),
                                                                                                                                                                           Ok(v415_0_0)
                                                                                                                                                                           =>
                                                                                                                                                                           v30_1(v415_0_0.clone()),
                                                                                                                                                                       };
                                                                                                                                                                   let v1521:
                                                                                                                                                                           Result<std::path::PathBuf,
                                                                                                                                                                                  std::io::Error> =
                                                                                                                                                                       match &v418
                                                                                                                                                                           {
                                                                                                                                                                           File_system::US13::US13_0(v418_0_0)
                                                                                                                                                                           =>
                                                                                                                                                                           Ok(v418_0_0.clone()),
                                                                                                                                                                           File_system::US13::US13_1(v418_1_0)
                                                                                                                                                                           =>
                                                                                                                                                                           {
                                                                                                                                                                               let v433:
                                                                                                                                                                                       string =
                                                                                                                                                                                   v418_1_0.clone();
                                                                                                                                                                               let v434:
                                                                                                                                                                                       string =
                                                                                                                                                                                   File_system::method19(v398.clone());
                                                                                                                                                                               let v435:
                                                                                                                                                                                       Option<string> =
                                                                                                                                                                                   File_system::method78(v398.clone());
                                                                                                                                                                               let v449:
                                                                                                                                                                                       File_system::US1 =
                                                                                                                                                                                   defaultValue(File_system::US1::US1_1,
                                                                                                                                                                                                map(File_system::method4(),
                                                                                                                                                                                                    v435));
                                                                                                                                                                               if let File_system::US1::US1_0(v449_0_0)
                                                                                                                                                                                      =
                                                                                                                                                                                      &v449
                                                                                                                                                                                  {
                                                                                                                                                                                   let v453:
                                                                                                                                                                                           string =
                                                                                                                                                                                       match &v449
                                                                                                                                                                                           {
                                                                                                                                                                                           File_system::US1::US1_0(x)
                                                                                                                                                                                           =>
                                                                                                                                                                                           x.clone(),
                                                                                                                                                                                           _
                                                                                                                                                                                           =>
                                                                                                                                                                                           unreachable!(),
                                                                                                                                                                                       };
                                                                                                                                                                                   if v398.clone()
                                                                                                                                                                                          !=
                                                                                                                                                                                          string("")
                                                                                                                                                                                      {
                                                                                                                                                                                       let v458:
                                                                                                                                                                                               Result<std::path::PathBuf,
                                                                                                                                                                                                      std::io::Error> =
                                                                                                                                                                                           std::fs::read_link(&*v453.clone());
                                                                                                                                                                                       let v459 =
                                                                                                                                                                                           File_system::method76();
                                                                                                                                                                                       let v470:
                                                                                                                                                                                               Result<std::path::PathBuf,
                                                                                                                                                                                                      string> =
                                                                                                                                                                                           v458.map_err(|x| v459(x));
                                                                                                                                                                                       let v473:
                                                                                                                                                                                               File_system::US13 =
                                                                                                                                                                                           match &v470
                                                                                                                                                                                               {
                                                                                                                                                                                               Err(v470_1_0)
                                                                                                                                                                                               =>
                                                                                                                                                                                               v31_1(v470_1_0.clone()),
                                                                                                                                                                                               Ok(v470_0_0)
                                                                                                                                                                                               =>
                                                                                                                                                                                               v30_1(v470_0_0.clone()),
                                                                                                                                                                                           };
                                                                                                                                                                                       let v1316:
                                                                                                                                                                                               Result<std::path::PathBuf,
                                                                                                                                                                                                      std::io::Error> =
                                                                                                                                                                                           match &v473
                                                                                                                                                                                               {
                                                                                                                                                                                               File_system::US13::US13_0(v473_0_0)
                                                                                                                                                                                               =>
                                                                                                                                                                                               Ok(v473_0_0.clone()),
                                                                                                                                                                                               File_system::US13::US13_1(v473_1_0)
                                                                                                                                                                                               =>
                                                                                                                                                                                               {
                                                                                                                                                                                                   let v488:
                                                                                                                                                                                                           string =
                                                                                                                                                                                                       v473_1_0.clone();
                                                                                                                                                                                                   let v489:
                                                                                                                                                                                                           string =
                                                                                                                                                                                                       File_system::method19(v453.clone());
                                                                                                                                                                                                   let v490:
                                                                                                                                                                                                           Option<string> =
                                                                                                                                                                                                       File_system::method78(v453.clone());
                                                                                                                                                                                                   let v504:
                                                                                                                                                                                                           File_system::US1 =
                                                                                                                                                                                                       defaultValue(File_system::US1::US1_1,
                                                                                                                                                                                                                    map(File_system::method4(),
                                                                                                                                                                                                                        v490));
                                                                                                                                                                                                   if let File_system::US1::US1_0(v504_0_0)
                                                                                                                                                                                                          =
                                                                                                                                                                                                          &v504
                                                                                                                                                                                                      {
                                                                                                                                                                                                       let v508:
                                                                                                                                                                                                               string =
                                                                                                                                                                                                           match &v504
                                                                                                                                                                                                               {
                                                                                                                                                                                                               File_system::US1::US1_0(x)
                                                                                                                                                                                                               =>
                                                                                                                                                                                                               x.clone(),
                                                                                                                                                                                                               _
                                                                                                                                                                                                               =>
                                                                                                                                                                                                               unreachable!(),
                                                                                                                                                                                                           };
                                                                                                                                                                                                       if v453.clone()
                                                                                                                                                                                                              !=
                                                                                                                                                                                                              string("")
                                                                                                                                                                                                          {
                                                                                                                                                                                                           let v513:
                                                                                                                                                                                                                   Result<std::path::PathBuf,
                                                                                                                                                                                                                          std::io::Error> =
                                                                                                                                                                                                               std::fs::read_link(&*v508.clone());
                                                                                                                                                                                                           let v514 =
                                                                                                                                                                                                               File_system::method76();
                                                                                                                                                                                                           let v525:
                                                                                                                                                                                                                   Result<std::path::PathBuf,
                                                                                                                                                                                                                          string> =
                                                                                                                                                                                                               v513.map_err(|x| v514(x));
                                                                                                                                                                                                           let v528:
                                                                                                                                                                                                                   File_system::US13 =
                                                                                                                                                                                                               match &v525
                                                                                                                                                                                                                   {
                                                                                                                                                                                                                   Err(v525_1_0)
                                                                                                                                                                                                                   =>
                                                                                                                                                                                                                   v31_1(v525_1_0.clone()),
                                                                                                                                                                                                                   Ok(v525_0_0)
                                                                                                                                                                                                                   =>
                                                                                                                                                                                                                   v30_1(v525_0_0.clone()),
                                                                                                                                                                                                               };
                                                                                                                                                                                                           let v1111:
                                                                                                                                                                                                                   Result<std::path::PathBuf,
                                                                                                                                                                                                                          std::io::Error> =
                                                                                                                                                                                                               match &v528
                                                                                                                                                                                                                   {
                                                                                                                                                                                                                   File_system::US13::US13_0(v528_0_0)
                                                                                                                                                                                                                   =>
                                                                                                                                                                                                                   Ok(v528_0_0.clone()),
                                                                                                                                                                                                                   File_system::US13::US13_1(v528_1_0)
                                                                                                                                                                                                                   =>
                                                                                                                                                                                                                   {
                                                                                                                                                                                                                       let v543:
                                                                                                                                                                                                                               string =
                                                                                                                                                                                                                           v528_1_0.clone();
                                                                                                                                                                                                                       let v544:
                                                                                                                                                                                                                               string =
                                                                                                                                                                                                                           File_system::method19(v508.clone());
                                                                                                                                                                                                                       let v545:
                                                                                                                                                                                                                               Option<string> =
                                                                                                                                                                                                                           File_system::method78(v508.clone());
                                                                                                                                                                                                                       let v559:
                                                                                                                                                                                                                               File_system::US1 =
                                                                                                                                                                                                                           defaultValue(File_system::US1::US1_1,
                                                                                                                                                                                                                                        map(File_system::method4(),
                                                                                                                                                                                                                                            v545));
                                                                                                                                                                                                                       if let File_system::US1::US1_0(v559_0_0)
                                                                                                                                                                                                                              =
                                                                                                                                                                                                                              &v559
                                                                                                                                                                                                                          {
                                                                                                                                                                                                                           let v563:
                                                                                                                                                                                                                                   string =
                                                                                                                                                                                                                               match &v559
                                                                                                                                                                                                                                   {
                                                                                                                                                                                                                                   File_system::US1::US1_0(x)
                                                                                                                                                                                                                                   =>
                                                                                                                                                                                                                                   x.clone(),
                                                                                                                                                                                                                                   _
                                                                                                                                                                                                                                   =>
                                                                                                                                                                                                                                   unreachable!(),
                                                                                                                                                                                                                               };
                                                                                                                                                                                                                           if v508.clone()
                                                                                                                                                                                                                                  !=
                                                                                                                                                                                                                                  string("")
                                                                                                                                                                                                                              {
                                                                                                                                                                                                                               let v568:
                                                                                                                                                                                                                                       Result<std::path::PathBuf,
                                                                                                                                                                                                                                              std::io::Error> =
                                                                                                                                                                                                                                   std::fs::read_link(&*v563.clone());
                                                                                                                                                                                                                               let v569 =
                                                                                                                                                                                                                                   File_system::method76();
                                                                                                                                                                                                                               let v580:
                                                                                                                                                                                                                                       Result<std::path::PathBuf,
                                                                                                                                                                                                                                              string> =
                                                                                                                                                                                                                                   v568.map_err(|x| v569(x));
                                                                                                                                                                                                                               let v583:
                                                                                                                                                                                                                                       File_system::US13 =
                                                                                                                                                                                                                                   match &v580
                                                                                                                                                                                                                                       {
                                                                                                                                                                                                                                       Err(v580_1_0)
                                                                                                                                                                                                                                       =>
                                                                                                                                                                                                                                       v31_1(v580_1_0.clone()),
                                                                                                                                                                                                                                       Ok(v580_0_0)
                                                                                                                                                                                                                                       =>
                                                                                                                                                                                                                                       v30_1(v580_0_0.clone()),
                                                                                                                                                                                                                                   };
                                                                                                                                                                                                                               let v906:
                                                                                                                                                                                                                                       Result<std::path::PathBuf,
                                                                                                                                                                                                                                              std::io::Error> =
                                                                                                                                                                                                                                   match &v583
                                                                                                                                                                                                                                       {
                                                                                                                                                                                                                                       File_system::US13::US13_0(v583_0_0)
                                                                                                                                                                                                                                       =>
                                                                                                                                                                                                                                       Ok(v583_0_0.clone()),
                                                                                                                                                                                                                                       File_system::US13::US13_1(v583_1_0)
                                                                                                                                                                                                                                       =>
                                                                                                                                                                                                                                       {
                                                                                                                                                                                                                                           let v598:
                                                                                                                                                                                                                                                   string =
                                                                                                                                                                                                                                               v583_1_0.clone();
                                                                                                                                                                                                                                           let v599:
                                                                                                                                                                                                                                                   string =
                                                                                                                                                                                                                                               File_system::method19(v563.clone());
                                                                                                                                                                                                                                           let v600:
                                                                                                                                                                                                                                                   Option<string> =
                                                                                                                                                                                                                                               File_system::method78(v563.clone());
                                                                                                                                                                                                                                           let v614:
                                                                                                                                                                                                                                                   File_system::US1 =
                                                                                                                                                                                                                                               defaultValue(File_system::US1::US1_1,
                                                                                                                                                                                                                                                            map(File_system::method4(),
                                                                                                                                                                                                                                                                v600));
                                                                                                                                                                                                                                           if let File_system::US1::US1_0(v614_0_0)
                                                                                                                                                                                                                                                  =
                                                                                                                                                                                                                                                  &v614
                                                                                                                                                                                                                                              {
                                                                                                                                                                                                                                               let v618:
                                                                                                                                                                                                                                                       string =
                                                                                                                                                                                                                                                   match &v614
                                                                                                                                                                                                                                                       {
                                                                                                                                                                                                                                                       File_system::US1::US1_0(x)
                                                                                                                                                                                                                                                       =>
                                                                                                                                                                                                                                                       x.clone(),
                                                                                                                                                                                                                                                       _
                                                                                                                                                                                                                                                       =>
                                                                                                                                                                                                                                                       unreachable!(),
                                                                                                                                                                                                                                                   };
                                                                                                                                                                                                                                               if v563.clone()
                                                                                                                                                                                                                                                      !=
                                                                                                                                                                                                                                                      string("")
                                                                                                                                                                                                                                                  {
                                                                                                                                                                                                                                                   let v623:
                                                                                                                                                                                                                                                           Result<std::path::PathBuf,
                                                                                                                                                                                                                                                                  std::io::Error> =
                                                                                                                                                                                                                                                       std::fs::read_link(&*v618.clone());
                                                                                                                                                                                                                                                   let v624 =
                                                                                                                                                                                                                                                       File_system::method76();
                                                                                                                                                                                                                                                   let v635:
                                                                                                                                                                                                                                                           Result<std::path::PathBuf,
                                                                                                                                                                                                                                                                  string> =
                                                                                                                                                                                                                                                       v623.map_err(|x| v624(x));
                                                                                                                                                                                                                                                   let v638:
                                                                                                                                                                                                                                                           File_system::US13 =
                                                                                                                                                                                                                                                       match &v635
                                                                                                                                                                                                                                                           {
                                                                                                                                                                                                                                                           Err(v635_1_0)
                                                                                                                                                                                                                                                           =>
                                                                                                                                                                                                                                                           v31_1(v635_1_0.clone()),
                                                                                                                                                                                                                                                           Ok(v635_0_0)
                                                                                                                                                                                                                                                           =>
                                                                                                                                                                                                                                                           v30_1(v635_0_0.clone()),
                                                                                                                                                                                                                                                       };
                                                                                                                                                                                                                                                   let v701:
                                                                                                                                                                                                                                                           Result<std::path::PathBuf,
                                                                                                                                                                                                                                                                  std::io::Error> =
                                                                                                                                                                                                                                                       match &v638
                                                                                                                                                                                                                                                           {
                                                                                                                                                                                                                                                           File_system::US13::US13_0(v638_0_0)
                                                                                                                                                                                                                                                           =>
                                                                                                                                                                                                                                                           Ok(v638_0_0.clone()),
                                                                                                                                                                                                                                                           _
                                                                                                                                                                                                                                                           =>
                                                                                                                                                                                                                                                           {
                                                                                                                                                                                                                                                               let v654:
                                                                                                                                                                                                                                                                       string =
                                                                                                                                                                                                                                                                   File_system::method19(v618.clone());
                                                                                                                                                                                                                                                               let v655:
                                                                                                                                                                                                                                                                       Option<string> =
                                                                                                                                                                                                                                                                   File_system::method78(v618.clone());
                                                                                                                                                                                                                                                               let v669:
                                                                                                                                                                                                                                                                       File_system::US1 =
                                                                                                                                                                                                                                                                   defaultValue(File_system::US1::US1_1,
                                                                                                                                                                                                                                                                                map(File_system::method4(),
                                                                                                                                                                                                                                                                                    v655));
                                                                                                                                                                                                                                                               let v673:
                                                                                                                                                                                                                                                                       string =
                                                                                                                                                                                                                                                                   sprintf!("file_system.read_link / path: {} / n: {} / path\': {} / name: {}",
                                                                                                                                                                                                                                                                            v1_1.clone(),
                                                                                                                                                                                                                                                                            11_u8,
                                                                                                                                                                                                                                                                            v618.clone(),
                                                                                                                                                                                                                                                                            v654);
                                                                                                                                                                                                                                                               let v676:
                                                                                                                                                                                                                                                                       std::io::Error =
                                                                                                                                                                                                                                                                   std::io::Error::new(std::io::ErrorKind::Other, &*v673);
                                                                                                                                                                                                                                                               Err(v676)
                                                                                                                                                                                                                                                           }
                                                                                                                                                                                                                                                       };
                                                                                                                                                                                                                                                   let v702 =
                                                                                                                                                                                                                                                       File_system::method76();
                                                                                                                                                                                                                                                   let v713:
                                                                                                                                                                                                                                                           Result<std::path::PathBuf,
                                                                                                                                                                                                                                                                  string> =
                                                                                                                                                                                                                                                       v701.map_err(|x| v702(x));
                                                                                                                                                                                                                                                   let v716:
                                                                                                                                                                                                                                                           File_system::US13 =
                                                                                                                                                                                                                                                       match &v713
                                                                                                                                                                                                                                                           {
                                                                                                                                                                                                                                                           Err(v713_1_0)
                                                                                                                                                                                                                                                           =>
                                                                                                                                                                                                                                                           v31_1(v713_1_0.clone()),
                                                                                                                                                                                                                                                           Ok(v713_0_0)
                                                                                                                                                                                                                                                           =>
                                                                                                                                                                                                                                                           v30_1(v713_0_0.clone()),
                                                                                                                                                                                                                                                       };
                                                                                                                                                                                                                                                   match &v716
                                                                                                                                                                                                                                                       {
                                                                                                                                                                                                                                                       File_system::US13::US13_0(v716_0_0)
                                                                                                                                                                                                                                                       =>
                                                                                                                                                                                                                                                       {
                                                                                                                                                                                                                                                           let v742:
                                                                                                                                                                                                                                                                   string =
                                                                                                                                                                                                                                                               File_system::method56(toString(v716_0_0.clone().display()),
                                                                                                                                                                                                                                                                                     v599.clone());
                                                                                                                                                                                                                                                           let v745:
                                                                                                                                                                                                                                                                   &str =
                                                                                                                                                                                                                                                               &*v742;
                                                                                                                                                                                                                                                           let v766:
                                                                                                                                                                                                                                                                   std::string::String =
                                                                                                                                                                                                                                                               String::from(v745);
                                                                                                                                                                                                                                                           let v787:
                                                                                                                                                                                                                                                                   std::path::PathBuf =
                                                                                                                                                                                                                                                               std::path::PathBuf::from(v766);
                                                                                                                                                                                                                                                           Ok(v787)
                                                                                                                                                                                                                                                       }
                                                                                                                                                                                                                                                       File_system::US13::US13_1(v716_1_0)
                                                                                                                                                                                                                                                       =>
                                                                                                                                                                                                                                                       {
                                                                                                                                                                                                                                                           let v820:
                                                                                                                                                                                                                                                                   string =
                                                                                                                                                                                                                                                               sprintf!("file_system.read_link / error\': {} / error: {} / name: {}",
                                                                                                                                                                                                                                                                        v716_1_0.clone(),
                                                                                                                                                                                                                                                                        v598.clone(),
                                                                                                                                                                                                                                                                        v599.clone());
                                                                                                                                                                                                                                                           let v823:
                                                                                                                                                                                                                                                                   std::io::Error =
                                                                                                                                                                                                                                                               std::io::Error::new(std::io::ErrorKind::Other, &*v820);
                                                                                                                                                                                                                                                           Err(v823)
                                                                                                                                                                                                                                                       }
                                                                                                                                                                                                                                                   }
                                                                                                                                                                                                                                               } else {
                                                                                                                                                                                                                                                   let v849:
                                                                                                                                                                                                                                                           string =
                                                                                                                                                                                                                                                       sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                                                                                                                                                                                                                                v1_1.clone(),
                                                                                                                                                                                                                                                                v598.clone(),
                                                                                                                                                                                                                                                                v563.clone(),
                                                                                                                                                                                                                                                                v599.clone());
                                                                                                                                                                                                                                                   let v852:
                                                                                                                                                                                                                                                           std::io::Error =
                                                                                                                                                                                                                                                       std::io::Error::new(std::io::ErrorKind::Other, &*v849);
                                                                                                                                                                                                                                                   Err(v852)
                                                                                                                                                                                                                                               }
                                                                                                                                                                                                                                           } else {
                                                                                                                                                                                                                                               let v877:
                                                                                                                                                                                                                                                       string =
                                                                                                                                                                                                                                                   sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                                                                                                                                                                                                                            v1_1.clone(),
                                                                                                                                                                                                                                                            v598,
                                                                                                                                                                                                                                                            v563.clone(),
                                                                                                                                                                                                                                                            v599.clone());
                                                                                                                                                                                                                                               let v880:
                                                                                                                                                                                                                                                       std::io::Error =
                                                                                                                                                                                                                                                   std::io::Error::new(std::io::ErrorKind::Other, &*v877);
                                                                                                                                                                                                                                               Err(v880)
                                                                                                                                                                                                                                           }
                                                                                                                                                                                                                                       }
                                                                                                                                                                                                                                   };
                                                                                                                                                                                                                               let v907 =
                                                                                                                                                                                                                                   File_system::method76();
                                                                                                                                                                                                                               let v918:
                                                                                                                                                                                                                                       Result<std::path::PathBuf,
                                                                                                                                                                                                                                              string> =
                                                                                                                                                                                                                                   v906.map_err(|x| v907(x));
                                                                                                                                                                                                                               let v921:
                                                                                                                                                                                                                                       File_system::US13 =
                                                                                                                                                                                                                                   match &v918
                                                                                                                                                                                                                                       {
                                                                                                                                                                                                                                       Err(v918_1_0)
                                                                                                                                                                                                                                       =>
                                                                                                                                                                                                                                       v31_1(v918_1_0.clone()),
                                                                                                                                                                                                                                       Ok(v918_0_0)
                                                                                                                                                                                                                                       =>
                                                                                                                                                                                                                                       v30_1(v918_0_0.clone()),
                                                                                                                                                                                                                                   };
                                                                                                                                                                                                                               match &v921
                                                                                                                                                                                                                                   {
                                                                                                                                                                                                                                   File_system::US13::US13_0(v921_0_0)
                                                                                                                                                                                                                                   =>
                                                                                                                                                                                                                                   {
                                                                                                                                                                                                                                       let v947:
                                                                                                                                                                                                                                               string =
                                                                                                                                                                                                                                           File_system::method56(toString(v921_0_0.clone().display()),
                                                                                                                                                                                                                                                                 v544.clone());
                                                                                                                                                                                                                                       let v950:
                                                                                                                                                                                                                                               &str =
                                                                                                                                                                                                                                           &*v947;
                                                                                                                                                                                                                                       let v971:
                                                                                                                                                                                                                                               std::string::String =
                                                                                                                                                                                                                                           String::from(v950);
                                                                                                                                                                                                                                       let v992:
                                                                                                                                                                                                                                               std::path::PathBuf =
                                                                                                                                                                                                                                           std::path::PathBuf::from(v971);
                                                                                                                                                                                                                                       Ok(v992)
                                                                                                                                                                                                                                   }
                                                                                                                                                                                                                                   File_system::US13::US13_1(v921_1_0)
                                                                                                                                                                                                                                   =>
                                                                                                                                                                                                                                   {
                                                                                                                                                                                                                                       let v1025:
                                                                                                                                                                                                                                               string =
                                                                                                                                                                                                                                           sprintf!("file_system.read_link / error\': {} / error: {} / name: {}",
                                                                                                                                                                                                                                                    v921_1_0.clone(),
                                                                                                                                                                                                                                                    v543.clone(),
                                                                                                                                                                                                                                                    v544.clone());
                                                                                                                                                                                                                                       let v1028:
                                                                                                                                                                                                                                               std::io::Error =
                                                                                                                                                                                                                                           std::io::Error::new(std::io::ErrorKind::Other, &*v1025);
                                                                                                                                                                                                                                       Err(v1028)
                                                                                                                                                                                                                                   }
                                                                                                                                                                                                                               }
                                                                                                                                                                                                                           } else {
                                                                                                                                                                                                                               let v1054:
                                                                                                                                                                                                                                       string =
                                                                                                                                                                                                                                   sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                                                                                                                                                                                                            v1_1.clone(),
                                                                                                                                                                                                                                            v543.clone(),
                                                                                                                                                                                                                                            v508.clone(),
                                                                                                                                                                                                                                            v544.clone());
                                                                                                                                                                                                                               let v1057:
                                                                                                                                                                                                                                       std::io::Error =
                                                                                                                                                                                                                                   std::io::Error::new(std::io::ErrorKind::Other, &*v1054);
                                                                                                                                                                                                                               Err(v1057)
                                                                                                                                                                                                                           }
                                                                                                                                                                                                                       } else {
                                                                                                                                                                                                                           let v1082:
                                                                                                                                                                                                                                   string =
                                                                                                                                                                                                                               sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                                                                                                                                                                                                        v1_1.clone(),
                                                                                                                                                                                                                                        v543,
                                                                                                                                                                                                                                        v508.clone(),
                                                                                                                                                                                                                                        v544.clone());
                                                                                                                                                                                                                           let v1085:
                                                                                                                                                                                                                                   std::io::Error =
                                                                                                                                                                                                                               std::io::Error::new(std::io::ErrorKind::Other, &*v1082);
                                                                                                                                                                                                                           Err(v1085)
                                                                                                                                                                                                                       }
                                                                                                                                                                                                                   }
                                                                                                                                                                                                               };
                                                                                                                                                                                                           let v1112 =
                                                                                                                                                                                                               File_system::method76();
                                                                                                                                                                                                           let v1123:
                                                                                                                                                                                                                   Result<std::path::PathBuf,
                                                                                                                                                                                                                          string> =
                                                                                                                                                                                                               v1111.map_err(|x| v1112(x));
                                                                                                                                                                                                           let v1126:
                                                                                                                                                                                                                   File_system::US13 =
                                                                                                                                                                                                               match &v1123
                                                                                                                                                                                                                   {
                                                                                                                                                                                                                   Err(v1123_1_0)
                                                                                                                                                                                                                   =>
                                                                                                                                                                                                                   v31_1(v1123_1_0.clone()),
                                                                                                                                                                                                                   Ok(v1123_0_0)
                                                                                                                                                                                                                   =>
                                                                                                                                                                                                                   v30_1(v1123_0_0.clone()),
                                                                                                                                                                                                               };
                                                                                                                                                                                                           match &v1126
                                                                                                                                                                                                               {
                                                                                                                                                                                                               File_system::US13::US13_0(v1126_0_0)
                                                                                                                                                                                                               =>
                                                                                                                                                                                                               {
                                                                                                                                                                                                                   let v1152:
                                                                                                                                                                                                                           string =
                                                                                                                                                                                                                       File_system::method56(toString(v1126_0_0.clone().display()),
                                                                                                                                                                                                                                             v489.clone());
                                                                                                                                                                                                                   let v1155:
                                                                                                                                                                                                                           &str =
                                                                                                                                                                                                                       &*v1152;
                                                                                                                                                                                                                   let v1176:
                                                                                                                                                                                                                           std::string::String =
                                                                                                                                                                                                                       String::from(v1155);
                                                                                                                                                                                                                   let v1197:
                                                                                                                                                                                                                           std::path::PathBuf =
                                                                                                                                                                                                                       std::path::PathBuf::from(v1176);
                                                                                                                                                                                                                   Ok(v1197)
                                                                                                                                                                                                               }
                                                                                                                                                                                                               File_system::US13::US13_1(v1126_1_0)
                                                                                                                                                                                                               =>
                                                                                                                                                                                                               {
                                                                                                                                                                                                                   let v1230:
                                                                                                                                                                                                                           string =
                                                                                                                                                                                                                       sprintf!("file_system.read_link / error\': {} / error: {} / name: {}",
                                                                                                                                                                                                                                v1126_1_0.clone(),
                                                                                                                                                                                                                                v488.clone(),
                                                                                                                                                                                                                                v489.clone());
                                                                                                                                                                                                                   let v1233:
                                                                                                                                                                                                                           std::io::Error =
                                                                                                                                                                                                                       std::io::Error::new(std::io::ErrorKind::Other, &*v1230);
                                                                                                                                                                                                                   Err(v1233)
                                                                                                                                                                                                               }
                                                                                                                                                                                                           }
                                                                                                                                                                                                       } else {
                                                                                                                                                                                                           let v1259:
                                                                                                                                                                                                                   string =
                                                                                                                                                                                                               sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                                                                                                                                                                                        v1_1.clone(),
                                                                                                                                                                                                                        v488.clone(),
                                                                                                                                                                                                                        v453.clone(),
                                                                                                                                                                                                                        v489.clone());
                                                                                                                                                                                                           let v1262:
                                                                                                                                                                                                                   std::io::Error =
                                                                                                                                                                                                               std::io::Error::new(std::io::ErrorKind::Other, &*v1259);
                                                                                                                                                                                                           Err(v1262)
                                                                                                                                                                                                       }
                                                                                                                                                                                                   } else {
                                                                                                                                                                                                       let v1287:
                                                                                                                                                                                                               string =
                                                                                                                                                                                                           sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                                                                                                                                                                                    v1_1.clone(),
                                                                                                                                                                                                                    v488,
                                                                                                                                                                                                                    v453.clone(),
                                                                                                                                                                                                                    v489.clone());
                                                                                                                                                                                                       let v1290:
                                                                                                                                                                                                               std::io::Error =
                                                                                                                                                                                                           std::io::Error::new(std::io::ErrorKind::Other, &*v1287);
                                                                                                                                                                                                       Err(v1290)
                                                                                                                                                                                                   }
                                                                                                                                                                                               }
                                                                                                                                                                                           };
                                                                                                                                                                                       let v1317 =
                                                                                                                                                                                           File_system::method76();
                                                                                                                                                                                       let v1328:
                                                                                                                                                                                               Result<std::path::PathBuf,
                                                                                                                                                                                                      string> =
                                                                                                                                                                                           v1316.map_err(|x| v1317(x));
                                                                                                                                                                                       let v1331:
                                                                                                                                                                                               File_system::US13 =
                                                                                                                                                                                           match &v1328
                                                                                                                                                                                               {
                                                                                                                                                                                               Err(v1328_1_0)
                                                                                                                                                                                               =>
                                                                                                                                                                                               v31_1(v1328_1_0.clone()),
                                                                                                                                                                                               Ok(v1328_0_0)
                                                                                                                                                                                               =>
                                                                                                                                                                                               v30_1(v1328_0_0.clone()),
                                                                                                                                                                                           };
                                                                                                                                                                                       match &v1331
                                                                                                                                                                                           {
                                                                                                                                                                                           File_system::US13::US13_0(v1331_0_0)
                                                                                                                                                                                           =>
                                                                                                                                                                                           {
                                                                                                                                                                                               let v1357:
                                                                                                                                                                                                       string =
                                                                                                                                                                                                   File_system::method56(toString(v1331_0_0.clone().display()),
                                                                                                                                                                                                                         v434.clone());
                                                                                                                                                                                               let v1360:
                                                                                                                                                                                                       &str =
                                                                                                                                                                                                   &*v1357;
                                                                                                                                                                                               let v1381:
                                                                                                                                                                                                       std::string::String =
                                                                                                                                                                                                   String::from(v1360);
                                                                                                                                                                                               let v1402:
                                                                                                                                                                                                       std::path::PathBuf =
                                                                                                                                                                                                   std::path::PathBuf::from(v1381);
                                                                                                                                                                                               Ok(v1402)
                                                                                                                                                                                           }
                                                                                                                                                                                           File_system::US13::US13_1(v1331_1_0)
                                                                                                                                                                                           =>
                                                                                                                                                                                           {
                                                                                                                                                                                               let v1435:
                                                                                                                                                                                                       string =
                                                                                                                                                                                                   sprintf!("file_system.read_link / error\': {} / error: {} / name: {}",
                                                                                                                                                                                                            v1331_1_0.clone(),
                                                                                                                                                                                                            v433.clone(),
                                                                                                                                                                                                            v434.clone());
                                                                                                                                                                                               let v1438:
                                                                                                                                                                                                       std::io::Error =
                                                                                                                                                                                                   std::io::Error::new(std::io::ErrorKind::Other, &*v1435);
                                                                                                                                                                                               Err(v1438)
                                                                                                                                                                                           }
                                                                                                                                                                                       }
                                                                                                                                                                                   } else {
                                                                                                                                                                                       let v1464:
                                                                                                                                                                                               string =
                                                                                                                                                                                           sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                                                                                                                                                                    v1_1.clone(),
                                                                                                                                                                                                    v433.clone(),
                                                                                                                                                                                                    v398.clone(),
                                                                                                                                                                                                    v434.clone());
                                                                                                                                                                                       let v1467:
                                                                                                                                                                                               std::io::Error =
                                                                                                                                                                                           std::io::Error::new(std::io::ErrorKind::Other, &*v1464);
                                                                                                                                                                                       Err(v1467)
                                                                                                                                                                                   }
                                                                                                                                                                               } else {
                                                                                                                                                                                   let v1492:
                                                                                                                                                                                           string =
                                                                                                                                                                                       sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                                                                                                                                                                v1_1.clone(),
                                                                                                                                                                                                v433,
                                                                                                                                                                                                v398.clone(),
                                                                                                                                                                                                v434.clone());
                                                                                                                                                                                   let v1495:
                                                                                                                                                                                           std::io::Error =
                                                                                                                                                                                       std::io::Error::new(std::io::ErrorKind::Other, &*v1492);
                                                                                                                                                                                   Err(v1495)
                                                                                                                                                                               }
                                                                                                                                                                           }
                                                                                                                                                                       };
                                                                                                                                                                   let v1522 =
                                                                                                                                                                       File_system::method76();
                                                                                                                                                                   let v1533:
                                                                                                                                                                           Result<std::path::PathBuf,
                                                                                                                                                                                  string> =
                                                                                                                                                                       v1521.map_err(|x| v1522(x));
                                                                                                                                                                   let v1536:
                                                                                                                                                                           File_system::US13 =
                                                                                                                                                                       match &v1533
                                                                                                                                                                           {
                                                                                                                                                                           Err(v1533_1_0)
                                                                                                                                                                           =>
                                                                                                                                                                           v31_1(v1533_1_0.clone()),
                                                                                                                                                                           Ok(v1533_0_0)
                                                                                                                                                                           =>
                                                                                                                                                                           v30_1(v1533_0_0.clone()),
                                                                                                                                                                       };
                                                                                                                                                                   match &v1536
                                                                                                                                                                       {
                                                                                                                                                                       File_system::US13::US13_0(v1536_0_0)
                                                                                                                                                                       =>
                                                                                                                                                                       {
                                                                                                                                                                           let v1562:
                                                                                                                                                                                   string =
                                                                                                                                                                               File_system::method56(toString(v1536_0_0.clone().display()),
                                                                                                                                                                                                     v379.clone());
                                                                                                                                                                           let v1565:
                                                                                                                                                                                   &str =
                                                                                                                                                                               &*v1562;
                                                                                                                                                                           let v1586:
                                                                                                                                                                                   std::string::String =
                                                                                                                                                                               String::from(v1565);
                                                                                                                                                                           let v1607:
                                                                                                                                                                                   std::path::PathBuf =
                                                                                                                                                                               std::path::PathBuf::from(v1586);
                                                                                                                                                                           Ok(v1607)
                                                                                                                                                                       }
                                                                                                                                                                       File_system::US13::US13_1(v1536_1_0)
                                                                                                                                                                       =>
                                                                                                                                                                       {
                                                                                                                                                                           let v1640:
                                                                                                                                                                                   string =
                                                                                                                                                                               sprintf!("file_system.read_link / error\': {} / error: {} / name: {}",
                                                                                                                                                                                        v1536_1_0.clone(),
                                                                                                                                                                                        v378.clone(),
                                                                                                                                                                                        v379.clone());
                                                                                                                                                                           let v1643:
                                                                                                                                                                                   std::io::Error =
                                                                                                                                                                               std::io::Error::new(std::io::ErrorKind::Other, &*v1640);
                                                                                                                                                                           Err(v1643)
                                                                                                                                                                       }
                                                                                                                                                                   }
                                                                                                                                                               } else {
                                                                                                                                                                   let v1669:
                                                                                                                                                                           string =
                                                                                                                                                                       sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                                                                                                                                                v1_1.clone(),
                                                                                                                                                                                v378.clone(),
                                                                                                                                                                                v343.clone(),
                                                                                                                                                                                v379.clone());
                                                                                                                                                                   let v1672:
                                                                                                                                                                           std::io::Error =
                                                                                                                                                                       std::io::Error::new(std::io::ErrorKind::Other, &*v1669);
                                                                                                                                                                   Err(v1672)
                                                                                                                                                               }
                                                                                                                                                           } else {
                                                                                                                                                               let v1697:
                                                                                                                                                                       string =
                                                                                                                                                                   sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                                                                                                                                            v1_1.clone(),
                                                                                                                                                                            v378,
                                                                                                                                                                            v343.clone(),
                                                                                                                                                                            v379.clone());
                                                                                                                                                               let v1700:
                                                                                                                                                                       std::io::Error =
                                                                                                                                                                   std::io::Error::new(std::io::ErrorKind::Other, &*v1697);
                                                                                                                                                               Err(v1700)
                                                                                                                                                           }
                                                                                                                                                       }
                                                                                                                                                   };
                                                                                                                                               let v1727 =
                                                                                                                                                   File_system::method76();
                                                                                                                                               let v1738:
                                                                                                                                                       Result<std::path::PathBuf,
                                                                                                                                                              string> =
                                                                                                                                                   v1726.map_err(|x| v1727(x));
                                                                                                                                               let v1741:
                                                                                                                                                       File_system::US13 =
                                                                                                                                                   match &v1738
                                                                                                                                                       {
                                                                                                                                                       Err(v1738_1_0)
                                                                                                                                                       =>
                                                                                                                                                       v31_1(v1738_1_0.clone()),
                                                                                                                                                       Ok(v1738_0_0)
                                                                                                                                                       =>
                                                                                                                                                       v30_1(v1738_0_0.clone()),
                                                                                                                                                   };
                                                                                                                                               match &v1741
                                                                                                                                                   {
                                                                                                                                                   File_system::US13::US13_0(v1741_0_0)
                                                                                                                                                   =>
                                                                                                                                                   {
                                                                                                                                                       let v1767:
                                                                                                                                                               string =
                                                                                                                                                           File_system::method56(toString(v1741_0_0.clone().display()),
                                                                                                                                                                                 v324.clone());
                                                                                                                                                       let v1770:
                                                                                                                                                               &str =
                                                                                                                                                           &*v1767;
                                                                                                                                                       let v1791:
                                                                                                                                                               std::string::String =
                                                                                                                                                           String::from(v1770);
                                                                                                                                                       let v1812:
                                                                                                                                                               std::path::PathBuf =
                                                                                                                                                           std::path::PathBuf::from(v1791);
                                                                                                                                                       Ok(v1812)
                                                                                                                                                   }
                                                                                                                                                   File_system::US13::US13_1(v1741_1_0)
                                                                                                                                                   =>
                                                                                                                                                   {
                                                                                                                                                       let v1845:
                                                                                                                                                               string =
                                                                                                                                                           sprintf!("file_system.read_link / error\': {} / error: {} / name: {}",
                                                                                                                                                                    v1741_1_0.clone(),
                                                                                                                                                                    v323.clone(),
                                                                                                                                                                    v324.clone());
                                                                                                                                                       let v1848:
                                                                                                                                                               std::io::Error =
                                                                                                                                                           std::io::Error::new(std::io::ErrorKind::Other, &*v1845);
                                                                                                                                                       Err(v1848)
                                                                                                                                                   }
                                                                                                                                               }
                                                                                                                                           } else {
                                                                                                                                               let v1874:
                                                                                                                                                       string =
                                                                                                                                                   sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                                                                                                                            v1_1.clone(),
                                                                                                                                                            v323.clone(),
                                                                                                                                                            v288.clone(),
                                                                                                                                                            v324.clone());
                                                                                                                                               let v1877:
                                                                                                                                                       std::io::Error =
                                                                                                                                                   std::io::Error::new(std::io::ErrorKind::Other, &*v1874);
                                                                                                                                               Err(v1877)
                                                                                                                                           }
                                                                                                                                       } else {
                                                                                                                                           let v1902:
                                                                                                                                                   string =
                                                                                                                                               sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                                                                                                                        v1_1.clone(),
                                                                                                                                                        v323,
                                                                                                                                                        v288.clone(),
                                                                                                                                                        v324.clone());
                                                                                                                                           let v1905:
                                                                                                                                                   std::io::Error =
                                                                                                                                               std::io::Error::new(std::io::ErrorKind::Other, &*v1902);
                                                                                                                                           Err(v1905)
                                                                                                                                       }
                                                                                                                                   }
                                                                                                                               };
                                                                                                                           let v1932 =
                                                                                                                               File_system::method76();
                                                                                                                           let v1943:
                                                                                                                                   Result<std::path::PathBuf,
                                                                                                                                          string> =
                                                                                                                               v1931.map_err(|x| v1932(x));
                                                                                                                           let v1946:
                                                                                                                                   File_system::US13 =
                                                                                                                               match &v1943
                                                                                                                                   {
                                                                                                                                   Err(v1943_1_0)
                                                                                                                                   =>
                                                                                                                                   v31_1(v1943_1_0.clone()),
                                                                                                                                   Ok(v1943_0_0)
                                                                                                                                   =>
                                                                                                                                   v30_1(v1943_0_0.clone()),
                                                                                                                               };
                                                                                                                           match &v1946
                                                                                                                               {
                                                                                                                               File_system::US13::US13_0(v1946_0_0)
                                                                                                                               =>
                                                                                                                               {
                                                                                                                                   let v1972:
                                                                                                                                           string =
                                                                                                                                       File_system::method56(toString(v1946_0_0.clone().display()),
                                                                                                                                                             v269.clone());
                                                                                                                                   let v1975:
                                                                                                                                           &str =
                                                                                                                                       &*v1972;
                                                                                                                                   let v1996:
                                                                                                                                           std::string::String =
                                                                                                                                       String::from(v1975);
                                                                                                                                   let v2017:
                                                                                                                                           std::path::PathBuf =
                                                                                                                                       std::path::PathBuf::from(v1996);
                                                                                                                                   Ok(v2017)
                                                                                                                               }
                                                                                                                               File_system::US13::US13_1(v1946_1_0)
                                                                                                                               =>
                                                                                                                               {
                                                                                                                                   let v2050:
                                                                                                                                           string =
                                                                                                                                       sprintf!("file_system.read_link / error\': {} / error: {} / name: {}",
                                                                                                                                                v1946_1_0.clone(),
                                                                                                                                                v268.clone(),
                                                                                                                                                v269.clone());
                                                                                                                                   let v2053:
                                                                                                                                           std::io::Error =
                                                                                                                                       std::io::Error::new(std::io::ErrorKind::Other, &*v2050);
                                                                                                                                   Err(v2053)
                                                                                                                               }
                                                                                                                           }
                                                                                                                       } else {
                                                                                                                           let v2079:
                                                                                                                                   string =
                                                                                                                               sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                                                                                                        v1_1.clone(),
                                                                                                                                        v268.clone(),
                                                                                                                                        v233.clone(),
                                                                                                                                        v269.clone());
                                                                                                                           let v2082:
                                                                                                                                   std::io::Error =
                                                                                                                               std::io::Error::new(std::io::ErrorKind::Other, &*v2079);
                                                                                                                           Err(v2082)
                                                                                                                       }
                                                                                                                   } else {
                                                                                                                       let v2107:
                                                                                                                               string =
                                                                                                                           sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                                                                                                    v1_1.clone(),
                                                                                                                                    v268,
                                                                                                                                    v233.clone(),
                                                                                                                                    v269.clone());
                                                                                                                       let v2110:
                                                                                                                               std::io::Error =
                                                                                                                           std::io::Error::new(std::io::ErrorKind::Other, &*v2107);
                                                                                                                       Err(v2110)
                                                                                                                   }
                                                                                                               }
                                                                                                           };
                                                                                                       let v2137 =
                                                                                                           File_system::method76();
                                                                                                       let v2148:
                                                                                                               Result<std::path::PathBuf,
                                                                                                                      string> =
                                                                                                           v2136.map_err(|x| v2137(x));
                                                                                                       let v2151:
                                                                                                               File_system::US13 =
                                                                                                           match &v2148
                                                                                                               {
                                                                                                               Err(v2148_1_0)
                                                                                                               =>
                                                                                                               v31_1(v2148_1_0.clone()),
                                                                                                               Ok(v2148_0_0)
                                                                                                               =>
                                                                                                               v30_1(v2148_0_0.clone()),
                                                                                                           };
                                                                                                       match &v2151
                                                                                                           {
                                                                                                           File_system::US13::US13_0(v2151_0_0)
                                                                                                           =>
                                                                                                           {
                                                                                                               let v2177:
                                                                                                                       string =
                                                                                                                   File_system::method56(toString(v2151_0_0.clone().display()),
                                                                                                                                         v214.clone());
                                                                                                               let v2180:
                                                                                                                       &str =
                                                                                                                   &*v2177;
                                                                                                               let v2201:
                                                                                                                       std::string::String =
                                                                                                                   String::from(v2180);
                                                                                                               let v2222:
                                                                                                                       std::path::PathBuf =
                                                                                                                   std::path::PathBuf::from(v2201);
                                                                                                               Ok(v2222)
                                                                                                           }
                                                                                                           File_system::US13::US13_1(v2151_1_0)
                                                                                                           =>
                                                                                                           {
                                                                                                               let v2255:
                                                                                                                       string =
                                                                                                                   sprintf!("file_system.read_link / error\': {} / error: {} / name: {}",
                                                                                                                            v2151_1_0.clone(),
                                                                                                                            v213.clone(),
                                                                                                                            v214.clone());
                                                                                                               let v2258:
                                                                                                                       std::io::Error =
                                                                                                                   std::io::Error::new(std::io::ErrorKind::Other, &*v2255);
                                                                                                               Err(v2258)
                                                                                                           }
                                                                                                       }
                                                                                                   } else {
                                                                                                       let v2284:
                                                                                                               string =
                                                                                                           sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                                                                                    v1_1.clone(),
                                                                                                                    v213.clone(),
                                                                                                                    v178.clone(),
                                                                                                                    v214.clone());
                                                                                                       let v2287:
                                                                                                               std::io::Error =
                                                                                                           std::io::Error::new(std::io::ErrorKind::Other, &*v2284);
                                                                                                       Err(v2287)
                                                                                                   }
                                                                                               } else {
                                                                                                   let v2312:
                                                                                                           string =
                                                                                                       sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                                                                                v1_1.clone(),
                                                                                                                v213,
                                                                                                                v178.clone(),
                                                                                                                v214.clone());
                                                                                                   let v2315:
                                                                                                           std::io::Error =
                                                                                                       std::io::Error::new(std::io::ErrorKind::Other, &*v2312);
                                                                                                   Err(v2315)
                                                                                               }
                                                                                           }
                                                                                       };
                                                                        let v2342 =
                                                                            File_system::method76();
                                                                        let v2353: Result<
                                                                            std::path::PathBuf,
                                                                            string,
                                                                        > = v2341
                                                                            .map_err(|x| v2342(x));
                                                                        let v2356:
                                                                                           File_system::US13 =
                                                                                       match &v2353
                                                                                           {
                                                                                           Err(v2353_1_0)
                                                                                           =>
                                                                                           v31_1(v2353_1_0.clone()),
                                                                                           Ok(v2353_0_0)
                                                                                           =>
                                                                                           v30_1(v2353_0_0.clone()),
                                                                                       };
                                                                        match &v2356
                                                                                       {
                                                                                       File_system::US13::US13_0(v2356_0_0)
                                                                                       =>
                                                                                       {
                                                                                           let v2382:
                                                                                                   string =
                                                                                               File_system::method56(toString(v2356_0_0.clone().display()),
                                                                                                                     v159.clone());
                                                                                           let v2385:
                                                                                                   &str =
                                                                                               &*v2382;
                                                                                           let v2406:
                                                                                                   std::string::String =
                                                                                               String::from(v2385);
                                                                                           let v2427:
                                                                                                   std::path::PathBuf =
                                                                                               std::path::PathBuf::from(v2406);
                                                                                           Ok(v2427)
                                                                                       }
                                                                                       File_system::US13::US13_1(v2356_1_0)
                                                                                       =>
                                                                                       {
                                                                                           let v2460:
                                                                                                   string =
                                                                                               sprintf!("file_system.read_link / error\': {} / error: {} / name: {}",
                                                                                                        v2356_1_0.clone(),
                                                                                                        v158.clone(),
                                                                                                        v159.clone());
                                                                                           let v2463:
                                                                                                   std::io::Error =
                                                                                               std::io::Error::new(std::io::ErrorKind::Other, &*v2460);
                                                                                           Err(v2463)
                                                                                       }
                                                                                   }
                                                                    } else {
                                                                        let v2489:
                                                                                           string =
                                                                                       sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                                                                v1_1.clone(),
                                                                                                v158.clone(),
                                                                                                v123.clone(),
                                                                                                v159.clone());
                                                                        let v2492:
                                                                                           std::io::Error =
                                                                                       std::io::Error::new(std::io::ErrorKind::Other, &*v2489);
                                                                        Err(v2492)
                                                                    }
                                                                } else {
                                                                    let v2517:
                                                                                       string =
                                                                                   sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                                                            v1_1.clone(),
                                                                                            v158,
                                                                                            v123.clone(),
                                                                                            v159.clone());
                                                                    let v2520:
                                                                                       std::io::Error =
                                                                                   std::io::Error::new(std::io::ErrorKind::Other, &*v2517);
                                                                    Err(v2520)
                                                                }
                                                            }
                                                        };
                                                        let v2547 = File_system::method76();
                                                        let v2558: Result<
                                                            std::path::PathBuf,
                                                            string,
                                                        > = v2546.map_err(|x| v2547(x));
                                                        let v2561: File_system::US13 = match &v2558
                                                        {
                                                            Err(v2558_1_0) => {
                                                                v31_1(v2558_1_0.clone())
                                                            }
                                                            Ok(v2558_0_0) => {
                                                                v30_1(v2558_0_0.clone())
                                                            }
                                                        };
                                                        match &v2561 {
                                                            File_system::US13::US13_0(
                                                                v2561_0_0,
                                                            ) => {
                                                                let v2587: string =
                                                                    File_system::method56(
                                                                        toString(
                                                                            v2561_0_0
                                                                                .clone()
                                                                                .display(),
                                                                        ),
                                                                        v104.clone(),
                                                                    );
                                                                let v2590: &str = &*v2587;
                                                                let v2611: std::string::String =
                                                                    String::from(v2590);
                                                                let v2632: std::path::PathBuf =
                                                                    std::path::PathBuf::from(v2611);
                                                                Ok(v2632)
                                                            }
                                                            File_system::US13::US13_1(
                                                                v2561_1_0,
                                                            ) => {
                                                                let v2665:
                                                                               string =
                                                                           sprintf!("file_system.read_link / error\': {} / error: {} / name: {}",
                                                                                    v2561_1_0.clone(),
                                                                                    v103.clone(),
                                                                                    v104.clone());
                                                                let v2668: std::io::Error =
                                                                    std::io::Error::new(
                                                                        std::io::ErrorKind::Other,
                                                                        &*v2665,
                                                                    );
                                                                Err(v2668)
                                                            }
                                                        }
                                                    } else {
                                                        let v2694:
                                                                       string =
                                                                   sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                                            v1_1.clone(),
                                                                            v103.clone(),
                                                                            v67.clone(),
                                                                            v104.clone());
                                                        let v2697: std::io::Error =
                                                            std::io::Error::new(
                                                                std::io::ErrorKind::Other,
                                                                &*v2694,
                                                            );
                                                        Err(v2697)
                                                    }
                                                } else {
                                                    let v2722: string =
                                                               sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                                        v1_1.clone(),
                                                                        v103,
                                                                        v67.clone(),
                                                                        v104.clone());
                                                    let v2725: std::io::Error = std::io::Error::new(
                                                        std::io::ErrorKind::Other,
                                                        &*v2722,
                                                    );
                                                    Err(v2725)
                                                }
                                            }
                                        };
                                    let v2752 = File_system::method76();
                                    let v2763: Result<std::path::PathBuf, string> =
                                        v2751.map_err(|x| v2752(x));
                                    let v2766: File_system::US13 = match &v2763 {
                                        Err(v2763_1_0) => v31_1(v2763_1_0.clone()),
                                        Ok(v2763_0_0) => v30_1(v2763_0_0.clone()),
                                    };
                                    match &v2766 {
                                        File_system::US13::US13_0(v2766_0_0) => {
                                            let v2792: string = File_system::method56(
                                                toString(v2766_0_0.clone().display()),
                                                v48.clone(),
                                            );
                                            let v2795: &str = &*v2792;
                                            let v2816: std::string::String = String::from(v2795);
                                            let v2837: std::path::PathBuf =
                                                std::path::PathBuf::from(v2816);
                                            Ok(v2837)
                                        }
                                        File_system::US13::US13_1(v2766_1_0) => {
                                            let v2870: string =
                                                       sprintf!("file_system.read_link / error\': {} / error: {} / name: {}",
                                                                v2766_1_0.clone(),
                                                                v47.clone(),
                                                                v48.clone());
                                            let v2873: std::io::Error = std::io::Error::new(
                                                std::io::ErrorKind::Other,
                                                &*v2870,
                                            );
                                            Err(v2873)
                                        }
                                    }
                                } else {
                                    let v2899: string =
                                               sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                        v1_1.clone(),
                                                        v47.clone(),
                                                        v1_1.clone(),
                                                        v48.clone());
                                    let v2902: std::io::Error =
                                        std::io::Error::new(std::io::ErrorKind::Other, &*v2899);
                                    Err(v2902)
                                }
                            } else {
                                let v2927: string =
                                           sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                    v1_1.clone(), v47,
                                                    v1_1.clone(),
                                                    v48.clone());
                                let v2930: std::io::Error =
                                    std::io::Error::new(std::io::ErrorKind::Other, &*v2927);
                                Err(v2930)
                            }
                        }
                    }
                };
                v2957.is_err()
            } else {
                false
            } {
                File_system::method7(true, v1_1.clone());
            }
            if File_system::method9(v1_1.clone()) == false {
                let v13157: bool = true;
                #[cfg(windows)]
                std::os::windows::fs::symlink_dir(&*v0_1.clone(), &*v1_1.clone()).unwrap();
                let v13159: bool = true;
                #[cfg(unix)]
                std::os::unix::fs::symlink(&*v0_1, &*v1_1.clone()).unwrap();
                ();
                ()
            }
        }
    }
    pub fn closure57(v0_1: string, v1_1: string) {
        File_system::method89(v0_1, v1_1);
    }
    pub fn closure56(unitVar: (), v0_1: string) -> Func1<string, ()> {
        Func1::new({
            let v0_1 = v0_1.clone();
            move |v: string| File_system::closure57(v0_1.clone(), v)
        })
    }
    pub fn closure59(v0_1: string, v1_1: string) -> string {
        File_system::method56(v0_1, v1_1)
    }
    pub fn closure58(unitVar: (), v0_1: string) -> Func1<string, string> {
        Func1::new({
            let v0_1 = v0_1.clone();
            move |v: string| File_system::closure59(v0_1.clone(), v)
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
    pub fn v16() -> Func1<string, Arc<Async<i64>>> {
        static v16: OnceInit<Func1<string, Arc<Async<i64>>>> = OnceInit::new();
        v16.get_or_init(|| Func1::new(move |v: string| File_system::closure3((), v)))
            .clone()
    }
    pub fn delete_directory_async(x: string) -> Arc<Async<i64>> {
        (File_system::v16())(x)
    }
    pub fn v17() -> Func1<File_system::US6, Func1<string, Arc<Async<i64>>>> {
        static v17: OnceInit<Func1<File_system::US6, Func1<string, Arc<Async<i64>>>>> =
            OnceInit::new();
        v17.get_or_init(|| Func1::new(move |v: File_system::US6| File_system::closure10((), v)))
            .clone()
    }
    pub fn wait_for_file_access(x: File_system::US6) -> Func1<string, Arc<Async<i64>>> {
        (File_system::v17())(x)
    }
    pub fn v18() -> Func1<string, Arc<Async<i64>>> {
        static v18: OnceInit<Func1<string, Arc<Async<i64>>>> = OnceInit::new();
        v18.get_or_init(|| Func1::new(move |v: string| File_system::closure13((), v)))
            .clone()
    }
    pub fn wait_for_file_access_read(x: string) -> Arc<Async<i64>> {
        (File_system::v18())(x)
    }
    pub fn v19() -> Func1<string, Arc<Async<string>>> {
        static v19: OnceInit<Func1<string, Arc<Async<string>>>> = OnceInit::new();
        v19.get_or_init(|| Func1::new(move |v: string| File_system::closure14((), v)))
            .clone()
    }
    pub fn read_all_text_async(x: string) -> Arc<Async<string>> {
        (File_system::v19())(x)
    }
    pub fn v20() -> Func1<string, Func1<string, bool>> {
        static v20: OnceInit<Func1<string, Func1<string, bool>>> = OnceInit::new();
        v20.get_or_init(|| Func1::new(move |v: string| File_system::closure15((), v)))
            .clone()
    }
    pub fn file_exists_content(x: string) -> Func1<string, bool> {
        (File_system::v20())(x)
    }
    pub fn v21() -> Func1<string, Func1<string, Arc<Async<()>>>> {
        static v21: OnceInit<Func1<string, Func1<string, Arc<Async<()>>>>> = OnceInit::new();
        v21.get_or_init(|| Func1::new(move |v: string| File_system::closure17((), v)))
            .clone()
    }
    pub fn write_all_text_async(x: string) -> Func1<string, Arc<Async<()>>> {
        (File_system::v21())(x)
    }
    pub fn v22() -> Func1<string, Func1<string, Arc<Async<()>>>> {
        static v22: OnceInit<Func1<string, Func1<string, Arc<Async<()>>>>> = OnceInit::new();
        v22.get_or_init(|| Func1::new(move |v: string| File_system::closure19((), v)))
            .clone()
    }
    pub fn write_all_text_exists(x: string) -> Func1<string, Arc<Async<()>>> {
        (File_system::v22())(x)
    }
    pub fn v23() -> Func1<string, Arc<Async<i64>>> {
        static v23: OnceInit<Func1<string, Arc<Async<i64>>>> = OnceInit::new();
        v23.get_or_init(|| Func1::new(move |v: string| File_system::closure21((), v)))
            .clone()
    }
    pub fn delete_file_async(x: string) -> Arc<Async<i64>> {
        (File_system::v23())(x)
    }
    pub fn v24() -> Func1<string, Func1<string, Arc<Async<i64>>>> {
        static v24: OnceInit<Func1<string, Func1<string, Arc<Async<i64>>>>> = OnceInit::new();
        v24.get_or_init(|| Func1::new(move |v: string| File_system::closure23((), v)))
            .clone()
    }
    pub fn move_file_async(x: string) -> Func1<string, Arc<Async<i64>>> {
        (File_system::v24())(x)
    }
    pub fn v25() -> Func1<string, Arc<Async<Option<string>>>> {
        static v25: OnceInit<Func1<string, Arc<Async<Option<string>>>>> = OnceInit::new();
        v25.get_or_init(|| Func1::new(move |v: string| File_system::closure26((), v)))
            .clone()
    }
    pub fn read_all_text_retry_async(x: string) -> Arc<Async<Option<string>>> {
        (File_system::v25())(x)
    }
    pub fn v26() -> Func0<string> {
        static v26: OnceInit<Func0<string>> = OnceInit::new();
        v26.get_or_init(|| Func0::new(move || File_system::closure32((), ())))
            .clone()
    }
    pub fn create_temp_path() -> string {
        (File_system::v26())()
    }
    pub fn v27() -> Func0<(string, LrcPtr<dyn IDisposable>)> {
        static v27: OnceInit<Func0<(string, LrcPtr<dyn IDisposable>)>> = OnceInit::new();
        v27.get_or_init(|| Func0::new(move || File_system::closure34((), ())))
            .clone()
    }
    pub fn create_temp_dir() -> (string, LrcPtr<dyn IDisposable>) {
        (File_system::v27())()
    }
    pub fn v28() -> Func1<string, (string, LrcPtr<dyn IDisposable>)> {
        static v28: OnceInit<Func1<string, (string, LrcPtr<dyn IDisposable>)>> = OnceInit::new();
        v28.get_or_init(|| Func1::new(move |v: string| File_system::closure43((), v)))
            .clone()
    }
    pub fn create_temp_dir_(x: string) -> (string, LrcPtr<dyn IDisposable>) {
        (File_system::v28())(x)
    }
    pub fn v29() -> Func0<string> {
        static v29: OnceInit<Func0<string>> = OnceInit::new();
        v29.get_or_init(|| Func0::new(move || File_system::closure44((), ())))
            .clone()
    }
    pub fn get_source_directory() -> string {
        (File_system::v29())()
    }
    pub fn v30() -> Func1<string, string> {
        static v30: OnceInit<Func1<string, string>> = OnceInit::new();
        v30.get_or_init(|| Func1::new(move |v: string| File_system::closure45((), v)))
            .clone()
    }
    pub fn normalize_path(x: string) -> string {
        (File_system::v30())(x)
    }
    pub fn v31() -> Func1<string, string> {
        static v31: OnceInit<Func1<string, string>> = OnceInit::new();
        v31.get_or_init(|| Func1::new(move |v: string| File_system::closure50((), v)))
            .clone()
    }
    pub fn new_file_uri(x: string) -> string {
        (File_system::v31())(x)
    }
    pub fn v32() -> Func0<string> {
        static v32: OnceInit<Func0<string>> = OnceInit::new();
        v32.get_or_init(|| Func0::new(move || File_system::closure51((), ())))
            .clone()
    }
    pub fn get_workspace_root() -> string {
        (File_system::v32())()
    }
    pub fn v33() -> Func1<bool, ()> {
        static v33: OnceInit<Func1<bool, ()>> = OnceInit::new();
        v33.get_or_init(|| Func1::new(move |v: bool| File_system::closure54((), v)))
            .clone()
    }
    pub fn init_trace_file(x: bool) {
        (File_system::v33())(x);
    }
    pub fn v34() -> Func1<string, Func1<string, ()>> {
        static v34: OnceInit<Func1<string, Func1<string, ()>>> = OnceInit::new();
        v34.get_or_init(|| Func1::new(move |v: string| File_system::closure56((), v)))
            .clone()
    }
    pub fn link_directory(x: string) -> Func1<string, ()> {
        (File_system::v34())(x)
    }
    pub fn v35() -> Func1<string, Func1<string, string>> {
        static v35: OnceInit<Func1<string, Func1<string, string>>> = OnceInit::new();
        v35.get_or_init(|| Func1::new(move |v: string| File_system::closure58((), v)))
            .clone()
    }
    pub fn op_LessDivideGreater(x: string) -> Func1<string, string> {
        (File_system::v35())(x)
    }
    on_startup!(());
}
