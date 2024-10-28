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
        US2_0,
        US2_1,
        US2_2,
    }
    impl core::fmt::Display for File_system::US2 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Copy, Debug, PartialEq, PartialOrd, Hash, Eq)]
    pub enum US3 {
        US3_0(File_system::US2),
        US3_1(File_system::US2),
        US3_2(File_system::US2),
        US3_3(File_system::US2),
        US3_4(File_system::US2),
    }
    impl core::fmt::Display for File_system::US3 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Copy, Debug, PartialEq, PartialOrd, Hash, Eq)]
    pub enum US4 {
        US4_0(File_system::US0),
        US4_1,
    }
    impl core::fmt::Display for File_system::US4 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Copy, Debug, PartialEq, PartialOrd, Hash, Eq)]
    pub enum US5 {
        US5_0(i64),
        US5_1,
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
        let v8: File_system::US4 = if string("Verbose") == v3.clone() {
            File_system::US4::US4_0(File_system::US0::US0_0)
        } else {
            File_system::US4::US4_1
        };
        let _v1: (File_system::US4, File_system::US5) = (
            match &v8 {
                File_system::US4::US4_0(v8_0_0) => File_system::US4::US4_0(match &v8 {
                    File_system::US4::US4_0(x) => x.clone(),
                    _ => unreachable!(),
                }),
                _ => {
                    let v15: File_system::US4 = if string("Debug") == v3.clone() {
                        File_system::US4::US4_0(File_system::US0::US0_1)
                    } else {
                        File_system::US4::US4_1
                    };
                    match &v15 {
                        File_system::US4::US4_0(v15_0_0) => File_system::US4::US4_0(match &v15 {
                            File_system::US4::US4_0(x) => x.clone(),
                            _ => unreachable!(),
                        }),
                        _ => {
                            let v22_1: File_system::US4 = if string("Info") == v3.clone() {
                                File_system::US4::US4_0(File_system::US0::US0_2)
                            } else {
                                File_system::US4::US4_1
                            };
                            match &v22_1 {
                                File_system::US4::US4_0(v22_1_0_0) => {
                                    File_system::US4::US4_0(match &v22_1 {
                                        File_system::US4::US4_0(x) => x.clone(),
                                        _ => unreachable!(),
                                    })
                                }
                                _ => {
                                    let v29_1: File_system::US4 = if string("Warning") == v3.clone()
                                    {
                                        File_system::US4::US4_0(File_system::US0::US0_3)
                                    } else {
                                        File_system::US4::US4_1
                                    };
                                    match &v29_1 {
                                        File_system::US4::US4_0(v29_1_0_0) => {
                                            File_system::US4::US4_0(match &v29_1 {
                                                File_system::US4::US4_0(x) => x.clone(),
                                                _ => unreachable!(),
                                            })
                                        }
                                        _ => {
                                            let v36: File_system::US4 =
                                                if string("Critical") == v3.clone() {
                                                    File_system::US4::US4_0(File_system::US0::US0_4)
                                                } else {
                                                    File_system::US4::US4_1
                                                };
                                            match &v36 {
                                                File_system::US4::US4_0(v36_0_0) => {
                                                    File_system::US4::US4_0(match &v36 {
                                                        File_system::US4::US4_0(x) => x.clone(),
                                                        _ => unreachable!(),
                                                    })
                                                }
                                                _ => File_system::US4::US4_1,
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
                File_system::US5::US5_0({
                    let _arg: DateTime = DateTime::now();
                    _arg.ticks()
                })
            } else {
                File_system::US5::US5_1
            },
        );
        let v425: File_system::US5 = _v1.1.clone();
        let v424: File_system::US4 = _v1.0.clone();
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
                l0: MutCell::new(match &v424 {
                    File_system::US4::US4_0(v424_0_0) => match &v424 {
                        File_system::US4::US4_0(x) => x.clone(),
                        _ => unreachable!(),
                    },
                    _ => v0_1,
                }),
            }),
            match &v425 {
                File_system::US5::US5_0(v425_0_0) => Some(match &v425 {
                    File_system::US5::US5_0(x) => x.clone(),
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
        let v28_1: std::string::String = String::from(v4);
        let v69: std::path::PathBuf = std::path::PathBuf::from(v28_1);
        if v69.clone().exists() {
            v69.is_dir()
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
    pub fn closure5(unitVar: (), v0_1: i64) -> File_system::US5 {
        File_system::US5::US5_0(v0_1)
    }
    pub fn method12() -> Func1<i64, File_system::US5> {
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
        let v20_1: File_system::US5 =
            defaultValue(File_system::US5::US5_1, map(File_system::method12(), v5));
        let v60: DateTime = match &v20_1 {
            File_system::US5::US5_0(v20_1_0_0) => {
                let v34_1: TimeSpan = TimeSpan::new_ticks(
                    {
                        let _arg: DateTime = DateTime::now();
                        _arg.ticks()
                    } - match &v20_1 {
                        File_system::US5::US5_0(x) => x.clone(),
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
        let v35_1: &str = inline_colorization::color_reset;
        let v37: std::string::String = format!("{}{}{}", v9, v12, v35_1);
        fable_library_rust::String_::fromString(v37)
    }
    pub fn method19(v0_1: string) -> string {
        let v4: &str = &*v0_1;
        let v28_1: std::string::String = String::from(v4);
        let v52: std::path::PathBuf = std::path::PathBuf::from(v28_1);
        let v75: Option<&std::ffi::OsStr> = v52.file_name();
        let v77: bool = true;
        let _optionm_map_ = v75.map(|x| {
            //;
            let v79: &std::ffi::OsStr = x;
            let v81: std::ffi::OsString = v79.to_os_string();
            let v83: Option<&str> = v81.to_str();
            let v85: &str = v83.unwrap();
            let v88: std::string::String = String::from(v85);
            let v111: string = fable_library_rust::String_::fromString(v88);
            let v113: bool = true;
            v111
        });
        let v115: Option<string> = _optionm_map_;
        let v129: File_system::US1 =
            defaultValue(File_system::US1::US1_1, map(File_system::method4(), v115));
        match &v129 {
            File_system::US1::US1_0(v129_0_0) => match &v129 {
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
        let v28_1: std::string::String = String::from(v4);
        let v69: std::path::PathBuf = std::path::PathBuf::from(v28_1);
        if v69.clone().exists() {
            v69.is_file()
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
            let v46: Vec<u8> = File_system::method30(v8.unwrap());
            let v48: Result<std::string::String, std::string::FromUtf8Error> =
                std::string::String::from_utf8(v46);
            let v51: std::string::String = v48.unwrap();
            v1_1 == fable_library_rust::String_::fromString(v51)
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
        let v35_1: &str = inline_colorization::color_reset;
        let v37: std::string::String = format!("{}{}{}", v9, v12, v35_1);
        fable_library_rust::String_::fromString(v37)
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
        let v134: () = {
            File_system::closure6(
                v4.clone(),
                sprintf!("{}", fable_library_rust::String_::fromString(v101)),
                (),
            );
            ()
        };
        let v143: () = {
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
    pub fn method39(v0_1: i64) -> i64 {
        v0_1
    }
    pub fn closure27(unitVar: (), v0_1: i64) -> File_system::US9 {
        File_system::US9::US9_0(v0_1)
    }
    pub fn method40() -> Func1<i64, File_system::US9> {
        Func1::new(move |v: i64| File_system::closure27((), v))
    }
    pub fn closure28(unitVar: (), v0_1: LrcPtr<Exception>) -> File_system::US9 {
        File_system::US9::US9_1(v0_1)
    }
    pub fn method41() -> Func1<LrcPtr<Exception>, File_system::US9> {
        Func1::new(move |v: LrcPtr<Exception>| File_system::closure28((), v))
    }
    pub fn method42() -> string {
        let v6: string = File_system::method16(getCharAt(toLower(string("Verbose")), 0_i32));
        let v9: &str = inline_colorization::color_bright_black;
        let v12: &str = &*v6;
        let v35_1: &str = inline_colorization::color_reset;
        let v37: std::string::String = format!("{}{}{}", v9, v12, v35_1);
        fable_library_rust::String_::fromString(v37)
    }
    pub fn method44(v0_1: i32) -> string {
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
    pub fn method43(
        v0_1: LrcPtr<File_system::Mut0>,
        v1_1: LrcPtr<File_system::Mut1>,
        v2_1: LrcPtr<File_system::Mut2>,
        v3: LrcPtr<File_system::Mut3>,
        v4: LrcPtr<File_system::Mut4>,
        v5: Option<i64>,
        v6: string,
        v7: string,
    ) -> string {
        let v9: string = File_system::method44(1000_i32);
        File_system::method22(sprintf!(
            "{} {} #{} {} / {}",
            v6,
            v7,
            v0_1.l0.get().clone(),
            string("async.run_with_timeout_async"),
            v9
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
            File_system::method23(File_system::method43(
                v18_1.clone(),
                v19_1.clone(),
                v20_1.clone(),
                v21_1.clone(),
                v22_1.clone(),
                v23_1.clone(),
                File_system::method11(v18_1, v19_1, v20_1, v21_1, v22_1, v23_1),
                File_system::method42(),
            ))
        };
    }
    pub fn method45() -> string {
        let v6: string = File_system::method16(getCharAt(toLower(string("Critical")), 0_i32));
        let v9: &str = inline_colorization::color_bright_red;
        let v12: &str = &*v6;
        let v35_1: &str = inline_colorization::color_reset;
        let v37: std::string::String = format!("{}{}{}", v9, v12, v35_1);
        fable_library_rust::String_::fromString(v37)
    }
    pub fn method47(v0_1: i32, v1_1: string) -> string {
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
    pub fn method46(
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
        let v10: string = File_system::method47(1000_i32, v8);
        File_system::method22(sprintf!(
            "{} {} #{} {} / {}",
            v6,
            v7,
            v0_1.l0.get().clone(),
            string("async.run_with_timeout_async**"),
            v10
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
            File_system::method23(File_system::method46(
                v19_1.clone(),
                v20_1.clone(),
                v21_1.clone(),
                v22_1.clone(),
                v23_1.clone(),
                v24_1.clone(),
                File_system::method11(v19_1, v20_1, v21_1, v22_1, v23_1, v24_1),
                File_system::method45(),
                sprintf!("{:?}", v0_1),
            ))
        };
    }
    pub fn method49(v0_1: i64, v1_1: string) -> string {
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
    pub fn method48(
        v0_1: LrcPtr<File_system::Mut0>,
        v1_1: LrcPtr<File_system::Mut1>,
        v2_1: LrcPtr<File_system::Mut2>,
        v3: LrcPtr<File_system::Mut3>,
        v4: LrcPtr<File_system::Mut4>,
        v5: Option<i64>,
        v6: string,
        v7: string,
        v8: i64,
        v9: string,
    ) -> string {
        let v10: string = File_system::method49(v8, v9);
        File_system::method22(sprintf!(
            "{} {} #{} {} / {}",
            v6,
            v7,
            v0_1.l0.get().clone(),
            string("file_system.read_all_text_retry_async"),
            v10
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
            File_system::method23(File_system::method48(
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
    pub fn method38(v0_1: string, v1_1: i64) -> Arc<Async<Option<string>>> {
        defaultOf()
    }
    pub fn closure26(unitVar: (), v0_1: string) -> Arc<Async<Option<string>>> {
        defaultOf()
    }
    pub fn closure33(unitVar: (), v0_1: chrono::DateTime<chrono::Utc>) -> File_system::US11 {
        File_system::US11::US11_0(v0_1)
    }
    pub fn method52() -> Func1<chrono::DateTime<chrono::Utc>, File_system::US11> {
        Func1::new(move |v: chrono::DateTime<chrono::Utc>| File_system::closure33((), v))
    }
    pub fn method53() -> string {
        string("hh:mm")
    }
    pub fn method54() -> string {
        string("yyyyMMdd-HHmm-ssff-ffff-f")
    }
    pub fn method55() -> string {
        string("hhmm")
    }
    pub fn method51(v0_1: Guid, v1_1: DateTime) -> Guid {
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
            map(File_system::method52(), v27_1),
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
        let v170: u8 = if zero.hours() > 0_i32 { 1_u8 } else { 0_u8 };
        let v171: string = File_system::method53();
        let v180: string = zero.to_string(v171);
        let v183: string = sprintf!(
            "{}{}{}",
            v170,
            getSlice(v180.clone(), Some(0_i32), Some(1_i32)),
            getSlice(v180, Some(3_i32), Some(4_i32))
        );
        parse(sprintf!(
            "{}{}{}",
            v65.clone(),
            v183.clone(),
            getSlice(
                toString(v0_1),
                Some(length(v65) + length(v183)),
                None::<i32>
            )
        ))
    }
    pub fn method57() -> string {
        let v2_1: std::path::PathBuf = std::env::temp_dir();
        let v5: std::path::Display = v2_1.display();
        let v29_1: std::string::String = format!("{}", v5);
        fable_library_rust::String_::fromString(v29_1)
    }
    pub fn method58() -> string {
        string("!create_temp_path_")
    }
    pub fn method61(v0_1: string) -> string {
        v0_1
    }
    pub fn method60(v0_1: string, v1_1: string) -> (string, string) {
        (v1_1, File_system::method61(v0_1))
    }
    pub fn method59(v0_1: string, v1_1: string) -> string {
        let v5: &str = &*v0_1;
        let v29_1: std::string::String = String::from(v5);
        let v53: std::path::PathBuf = std::path::PathBuf::from(v29_1);
        let v77: &str = &*v1_1;
        let v101: std::string::String = String::from(v77);
        let v124: std::path::PathBuf = v53.join(v101);
        let v127: std::path::Display = v124.display();
        let v151: std::string::String = format!("{}", v127);
        fable_library_rust::String_::fromString(v151)
    }
    pub fn method63() -> string {
        string("CARGO_PKG_NAME")
    }
    pub fn method62() -> string {
        File_system::method2(File_system::method63())
    }
    pub fn method56(v0_1: Guid) -> string {
        File_system::method59(
            File_system::method59(
                File_system::method59(File_system::method57(), File_system::method58()),
                File_system::method62(),
            ),
            toString(v0_1),
        )
    }
    pub fn method50() -> string {
        let v1_1: DateTime = DateTime::now();
        File_system::method56(File_system::method51(new_guid(), v1_1))
    }
    pub fn closure32(unitVar: (), unitVar_1: ()) -> string {
        File_system::method50()
    }
    pub fn method65(v0_1: string) -> string {
        v0_1
    }
    pub fn closure35(unitVar: (), v0_1: std::io::Error) -> std::string::String {
        format!("{}", v0_1)
    }
    pub fn method66() -> Func1<std::io::Error, std::string::String> {
        Func1::new(move |v: std::io::Error| File_system::closure35((), v))
    }
    pub fn closure36(unitVar: (), unitVar_1: ()) -> File_system::US12 {
        File_system::US12::US12_0
    }
    pub fn closure37(unitVar: (), v0_1: std::string::String) -> File_system::US12 {
        File_system::US12::US12_1(v0_1)
    }
    pub fn method68(v0_1: string, v1_1: std::string::String) -> string {
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
        let v100: () = {
            File_system::closure6(
                v3.clone(),
                sprintf!("{}", fable_library_rust::String_::fromString(v67)),
                (),
            );
            ()
        };
        let v109: () = {
            File_system::closure6(v3.clone(), sprintf!("{}", string(" }")), ());
            ()
        };
        v3.l0.get().clone()
    }
    pub fn method67(
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
        let v10: string = File_system::method68(v8, v9);
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
            File_system::method23(File_system::method67(
                v20_1.clone(),
                v21_1.clone(),
                v22_1.clone(),
                v23_1.clone(),
                v24_1.clone(),
                v25_1.clone(),
                File_system::method11(v20_1, v21_1, v22_1, v23_1, v24_1, v25_1),
                File_system::method45(),
                v0_1,
                v1_1,
            ))
        };
    }
    pub fn method70(v0_1: string) -> string {
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
    pub fn method69(
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
        let v9: string = File_system::method70(v8);
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
            File_system::method23(File_system::method69(
                v19_1.clone(),
                v20_1.clone(),
                v21_1.clone(),
                v22_1.clone(),
                v23_1.clone(),
                v24_1.clone(),
                File_system::method11(v19_1, v20_1, v21_1, v22_1, v23_1, v24_1),
                File_system::method42(),
                v0_1,
            ))
        };
    }
    pub fn closure40(v0_1: string, unitVar: ()) {
        File_system::method7(true, v0_1);
    }
    pub fn method71(v0_1: string) -> Func0<()> {
        Func0::new({
            let v0_1 = v0_1.clone();
            move || File_system::closure40(v0_1.clone(), ())
        })
    }
    pub fn method72(v0_1: string) -> Func0<()> {
        Func0::new({
            let v0_1 = v0_1.clone();
            move || File_system::closure40(v0_1.clone(), ())
        })
    }
    pub fn method74(v0_1: string, v1_1: string) -> string {
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
    pub fn method73(
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
        let v10: string = File_system::method74(v8, v9);
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
            File_system::method23(File_system::method73(
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
        let v28_1: Arc<Async<()>> = defaultOf();
        defaultOf::<()>();
        ();
        ()
    }
    pub fn method75(v0_1: string) -> Func0<()> {
        Func0::new({
            let v0_1 = v0_1.clone();
            move || File_system::closure42(v0_1.clone(), ())
        })
    }
    pub fn method76(v0_1: string) -> Func0<()> {
        Func0::new({
            let v0_1 = v0_1.clone();
            move || File_system::closure42(v0_1.clone(), ())
        })
    }
    pub fn method64(v0_1: string) -> LrcPtr<dyn IDisposable> {
        let v2_1: string = File_system::method65(v0_1);
        let v4: Result<(), std::io::Error> = std::fs::create_dir_all(&*v2_1.clone());
        let v5 = File_system::method66();
        let v17_1: Result<(), std::string::String> = v4.map_err(|x| v5(x));
        let v22_1: File_system::US12 = match &v17_1 {
            Err(v17_1_1_0) => File_system::closure37((), v17_1_1_0.clone()),
            _ => File_system::closure36((), ()),
        };
        match &v22_1 {
            File_system::US12::US12_0 => {
                let v25_1: () = {
                    File_system::closure39(v2_1.clone(), ());
                    ()
                };
                ()
            }
            File_system::US12::US12_1(v22_1_1_0) => {
                let v68: () = {
                    File_system::closure38(
                        v2_1.clone(),
                        match &v22_1 {
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
            let v109 = File_system::method71(v2_1.clone());
            interface_cast!(
                File_system::Disposable::_ctor__3A5B6456(Func0::new({
                    let v109 = v109.clone();
                    move || v109.clone()()
                })),
                Lrc<dyn IDisposable>,
            )
        }
    }
    pub fn closure34(unitVar: (), unitVar_1: ()) -> (string, LrcPtr<dyn IDisposable>) {
        let v0_1: string = File_system::method50();
        (v0_1.clone(), File_system::method64(v0_1))
    }
    pub fn method77(v0_1: string) -> Guid {
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
        let v2_1: string = File_system::method56(File_system::method77(v0_1));
        (v2_1.clone(), File_system::method64(v2_1))
    }
    pub fn closure44(unitVar: (), unitVar_1: ()) -> string {
        string("/home/runner/work/polyglot/polyglot/lib/spiral")
    }
    pub fn method80(v0_1: std::io::Error) -> string {
        let v2_1: LrcPtr<File_system::Mut3> = LrcPtr::new(File_system::Mut3 {
            l0: MutCell::new(File_system::method17()),
        });
        let v5: std::string::String = format!("{:#?}", v0_1);
        let v38: () = {
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
        File_system::method80(v0_1)
    }
    pub fn method79() -> Func1<std::io::Error, string> {
        Func1::new(move |v: std::io::Error| File_system::closure46((), v))
    }
    pub fn closure47(unitVar: (), v0_1: std::path::PathBuf) -> File_system::US13 {
        File_system::US13::US13_0(v0_1)
    }
    pub fn closure48(unitVar: (), v0_1: string) -> File_system::US13 {
        File_system::US13::US13_1(v0_1)
    }
    pub fn method82(v0_1: string) -> string {
        let v4: &str = &*v0_1;
        let v28_1: std::string::String = String::from(v4);
        let v52: std::path::PathBuf = std::path::PathBuf::from(v28_1);
        let v75: Option<std::path::PathBuf> = v52.parent().map(std::path::PathBuf::from);
        let v77: bool = true;
        let _optionm_map_ = v75.map(|x| {
            //;
            let v79: std::path::PathBuf = x;
            let v82: std::path::Display = v79.display();
            let v106: std::string::String = format!("{}", v82);
            let v129: string = fable_library_rust::String_::fromString(v106);
            let v131: bool = true;
            v129
        });
        defaultValue(string(""), _optionm_map_)
    }
    pub fn method81(v0_1: string) -> Option<string> {
        let v57: File_system::US1 = File_system::US1::US1_0(File_system::method82(v0_1));
        match &v57 {
            File_system::US1::US1_0(v57_0_0) => Some(match &v57 {
                File_system::US1::US1_0(x) => x.clone(),
                _ => unreachable!(),
            }),
            _ => None::<string>,
        }
    }
    pub fn closure49(unitVar: (), v0_1: std::path::PathBuf) -> File_system::US14 {
        File_system::US14::US14_0(v0_1)
    }
    pub fn method83() -> Func1<std::path::PathBuf, File_system::US14> {
        Func1::new(move |v: std::path::PathBuf| File_system::closure49((), v))
    }
    pub fn method85(v0_1: string) -> string {
        v0_1
    }
    pub fn method84(v0_1: string, v1_1: string, v2_1: string) -> string {
        let v5: Result<regex::Regex, regex::Error> = regex::Regex::new(&v0_1);
        let v8: regex::Regex = v5.unwrap();
        let v20_1: string = File_system::method85(v2_1);
        let v22_1: std::borrow::Cow<str> = v8.replace_all(&*v20_1, &*v1_1);
        let v24_1: std::string::String = String::from(v22_1);
        fable_library_rust::String_::fromString(v24_1)
    }
    pub fn method78(v0_1: string) -> string {
        if v0_1.clone() == string("") {
            string("")
        } else {
            let v3196: Result<std::path::PathBuf, std::io::Error> = if File_system::method9(
                v0_1.clone(),
            ) {
                std::fs::read_link(&*v0_1.clone())
            } else {
                let v8: Result<std::path::PathBuf, std::io::Error> =
                    std::fs::read_link(&*v0_1.clone());
                let v9 = File_system::method79();
                let v21_1: Result<std::path::PathBuf, string> = v8.map_err(|x| v9(x));
                fn v24_1(v: std::path::PathBuf) -> File_system::US13 {
                    File_system::closure47((), v)
                }
                fn v25_1(v_1: string) -> File_system::US13 {
                    File_system::closure48((), v_1)
                }
                let v26_1: File_system::US13 = match &v21_1 {
                    Err(v21_1_1_0) => v25_1(v21_1_1_0.clone()),
                    Ok(v21_1_0_0) => v24_1(v21_1_0_0.clone()),
                };
                match &v26_1 {
                    File_system::US13::US13_0(v26_1_0_0) => Ok(v26_1_0_0.clone()),
                    File_system::US13::US13_1(v26_1_1_0) => {
                        let v42: string = v26_1_1_0.clone();
                        let v43: string = File_system::method19(v0_1.clone());
                        let v44: Option<string> = File_system::method81(v0_1.clone());
                        let v58: File_system::US1 =
                            defaultValue(File_system::US1::US1_1, map(File_system::method4(), v44));
                        if let File_system::US1::US1_0(v58_0_0) = &v58 {
                            let v62: string = match &v58 {
                                File_system::US1::US1_0(x) => x.clone(),
                                _ => unreachable!(),
                            };
                            if v0_1.clone() != string("") {
                                let v68: Result<std::path::PathBuf, std::io::Error> =
                                    std::fs::read_link(&*v62.clone());
                                let v69 = File_system::method79();
                                let v81: Result<std::path::PathBuf, string> =
                                    v68.map_err(|x| v69(x));
                                let v84: File_system::US13 = match &v81 {
                                    Err(v81_1_0) => v25_1(v81_1_0.clone()),
                                    Ok(v81_0_0) => v24_1(v81_0_0.clone()),
                                };
                                let v2970: Result<std::path::PathBuf, std::io::Error> = match &v84 {
                                    File_system::US13::US13_0(v84_0_0) => Ok(v84_0_0.clone()),
                                    File_system::US13::US13_1(v84_1_0) => {
                                        let v100: string = v84_1_0.clone();
                                        let v101: string = File_system::method19(v62.clone());
                                        let v102: Option<string> =
                                            File_system::method81(v62.clone());
                                        let v116: File_system::US1 = defaultValue(
                                            File_system::US1::US1_1,
                                            map(File_system::method4(), v102),
                                        );
                                        if let File_system::US1::US1_0(v116_0_0) = &v116 {
                                            let v120: string = match &v116 {
                                                File_system::US1::US1_0(x) => x.clone(),
                                                _ => unreachable!(),
                                            };
                                            if v62.clone() != string("") {
                                                let v125: Result<
                                                    std::path::PathBuf,
                                                    std::io::Error,
                                                > = std::fs::read_link(&*v120.clone());
                                                let v126 = File_system::method79();
                                                let v138: Result<std::path::PathBuf, string> =
                                                    v125.map_err(|x| v126(x));
                                                let v141: File_system::US13 = match &v138 {
                                                    Err(v138_1_0) => v25_1(v138_1_0.clone()),
                                                    Ok(v138_0_0) => v24_1(v138_0_0.clone()),
                                                };
                                                let v2745: Result<
                                                    std::path::PathBuf,
                                                    std::io::Error,
                                                > = match &v141 {
                                                    File_system::US13::US13_0(v141_0_0) => {
                                                        Ok(v141_0_0.clone())
                                                    }
                                                    File_system::US13::US13_1(v141_1_0) => {
                                                        let v157: string = v141_1_0.clone();
                                                        let v158: string =
                                                            File_system::method19(v120.clone());
                                                        let v159: Option<string> =
                                                            File_system::method81(v120.clone());
                                                        let v173: File_system::US1 = defaultValue(
                                                            File_system::US1::US1_1,
                                                            map(File_system::method4(), v159),
                                                        );
                                                        if let File_system::US1::US1_0(v173_0_0) =
                                                            &v173
                                                        {
                                                            let v177: string = match &v173 {
                                                                File_system::US1::US1_0(x) => {
                                                                    x.clone()
                                                                }
                                                                _ => unreachable!(),
                                                            };
                                                            if v120.clone() != string("") {
                                                                let v182: Result<
                                                                    std::path::PathBuf,
                                                                    std::io::Error,
                                                                > = std::fs::read_link(
                                                                    &*v177.clone(),
                                                                );
                                                                let v183 = File_system::method79();
                                                                let v195: Result<
                                                                    std::path::PathBuf,
                                                                    string,
                                                                > = v182.map_err(|x| v183(x));
                                                                let v198: File_system::US13 =
                                                                    match &v195 {
                                                                        Err(v195_1_0) => {
                                                                            v25_1(v195_1_0.clone())
                                                                        }
                                                                        Ok(v195_0_0) => {
                                                                            v24_1(v195_0_0.clone())
                                                                        }
                                                                    };
                                                                let v2520: Result<
                                                                    std::path::PathBuf,
                                                                    std::io::Error,
                                                                > = match &v198 {
                                                                    File_system::US13::US13_0(
                                                                        v198_0_0,
                                                                    ) => Ok(v198_0_0.clone()),
                                                                    File_system::US13::US13_1(
                                                                        v198_1_0,
                                                                    ) => {
                                                                        let v214: string =
                                                                            v198_1_0.clone();
                                                                        let v215: string =
                                                                            File_system::method19(
                                                                                v177.clone(),
                                                                            );
                                                                        let v216: Option<string> =
                                                                            File_system::method81(
                                                                                v177.clone(),
                                                                            );
                                                                        let v230:
                                                                                                File_system::US1 =
                                                                                            defaultValue(File_system::US1::US1_1,
                                                                                                         map(File_system::method4(),
                                                                                                             v216));
                                                                        if let File_system::US1::US1_0(v230_0_0)
                                                                                               =
                                                                                               &v230
                                                                                           {
                                                                                            let v234:
                                                                                                    string =
                                                                                                match &v230
                                                                                                    {
                                                                                                    File_system::US1::US1_0(x)
                                                                                                    =>
                                                                                                    x.clone(),
                                                                                                    _
                                                                                                    =>
                                                                                                    unreachable!(),
                                                                                                };
                                                                                            if v177.clone()
                                                                                                   !=
                                                                                                   string("")
                                                                                               {
                                                                                                let v239:
                                                                                                        Result<std::path::PathBuf,
                                                                                                               std::io::Error> =
                                                                                                    std::fs::read_link(&*v234.clone());
                                                                                                let v240 =
                                                                                                    File_system::method79();
                                                                                                let v252:
                                                                                                        Result<std::path::PathBuf,
                                                                                                               string> =
                                                                                                    v239.map_err(|x| v240(x));
                                                                                                let v255:
                                                                                                        File_system::US13 =
                                                                                                    match &v252
                                                                                                        {
                                                                                                        Err(v252_1_0)
                                                                                                        =>
                                                                                                        v25_1(v252_1_0.clone()),
                                                                                                        Ok(v252_0_0)
                                                                                                        =>
                                                                                                        v24_1(v252_0_0.clone()),
                                                                                                    };
                                                                                                let v2295:
                                                                                                        Result<std::path::PathBuf,
                                                                                                               std::io::Error> =
                                                                                                    match &v255
                                                                                                        {
                                                                                                        File_system::US13::US13_0(v255_0_0)
                                                                                                        =>
                                                                                                        Ok(v255_0_0.clone()),
                                                                                                        File_system::US13::US13_1(v255_1_0)
                                                                                                        =>
                                                                                                        {
                                                                                                            let v271:
                                                                                                                    string =
                                                                                                                v255_1_0.clone();
                                                                                                            let v272:
                                                                                                                    string =
                                                                                                                File_system::method19(v234.clone());
                                                                                                            let v273:
                                                                                                                    Option<string> =
                                                                                                                File_system::method81(v234.clone());
                                                                                                            let v287:
                                                                                                                    File_system::US1 =
                                                                                                                defaultValue(File_system::US1::US1_1,
                                                                                                                             map(File_system::method4(),
                                                                                                                                 v273));
                                                                                                            if let File_system::US1::US1_0(v287_0_0)
                                                                                                                   =
                                                                                                                   &v287
                                                                                                               {
                                                                                                                let v291:
                                                                                                                        string =
                                                                                                                    match &v287
                                                                                                                        {
                                                                                                                        File_system::US1::US1_0(x)
                                                                                                                        =>
                                                                                                                        x.clone(),
                                                                                                                        _
                                                                                                                        =>
                                                                                                                        unreachable!(),
                                                                                                                    };
                                                                                                                if v234.clone()
                                                                                                                       !=
                                                                                                                       string("")
                                                                                                                   {
                                                                                                                    let v296:
                                                                                                                            Result<std::path::PathBuf,
                                                                                                                                   std::io::Error> =
                                                                                                                        std::fs::read_link(&*v291.clone());
                                                                                                                    let v297 =
                                                                                                                        File_system::method79();
                                                                                                                    let v309:
                                                                                                                            Result<std::path::PathBuf,
                                                                                                                                   string> =
                                                                                                                        v296.map_err(|x| v297(x));
                                                                                                                    let v312:
                                                                                                                            File_system::US13 =
                                                                                                                        match &v309
                                                                                                                            {
                                                                                                                            Err(v309_1_0)
                                                                                                                            =>
                                                                                                                            v25_1(v309_1_0.clone()),
                                                                                                                            Ok(v309_0_0)
                                                                                                                            =>
                                                                                                                            v24_1(v309_0_0.clone()),
                                                                                                                        };
                                                                                                                    let v2070:
                                                                                                                            Result<std::path::PathBuf,
                                                                                                                                   std::io::Error> =
                                                                                                                        match &v312
                                                                                                                            {
                                                                                                                            File_system::US13::US13_0(v312_0_0)
                                                                                                                            =>
                                                                                                                            Ok(v312_0_0.clone()),
                                                                                                                            File_system::US13::US13_1(v312_1_0)
                                                                                                                            =>
                                                                                                                            {
                                                                                                                                let v328:
                                                                                                                                        string =
                                                                                                                                    v312_1_0.clone();
                                                                                                                                let v329:
                                                                                                                                        string =
                                                                                                                                    File_system::method19(v291.clone());
                                                                                                                                let v330:
                                                                                                                                        Option<string> =
                                                                                                                                    File_system::method81(v291.clone());
                                                                                                                                let v344:
                                                                                                                                        File_system::US1 =
                                                                                                                                    defaultValue(File_system::US1::US1_1,
                                                                                                                                                 map(File_system::method4(),
                                                                                                                                                     v330));
                                                                                                                                if let File_system::US1::US1_0(v344_0_0)
                                                                                                                                       =
                                                                                                                                       &v344
                                                                                                                                   {
                                                                                                                                    let v348:
                                                                                                                                            string =
                                                                                                                                        match &v344
                                                                                                                                            {
                                                                                                                                            File_system::US1::US1_0(x)
                                                                                                                                            =>
                                                                                                                                            x.clone(),
                                                                                                                                            _
                                                                                                                                            =>
                                                                                                                                            unreachable!(),
                                                                                                                                        };
                                                                                                                                    if v291.clone()
                                                                                                                                           !=
                                                                                                                                           string("")
                                                                                                                                       {
                                                                                                                                        let v353:
                                                                                                                                                Result<std::path::PathBuf,
                                                                                                                                                       std::io::Error> =
                                                                                                                                            std::fs::read_link(&*v348.clone());
                                                                                                                                        let v354 =
                                                                                                                                            File_system::method79();
                                                                                                                                        let v366:
                                                                                                                                                Result<std::path::PathBuf,
                                                                                                                                                       string> =
                                                                                                                                            v353.map_err(|x| v354(x));
                                                                                                                                        let v369:
                                                                                                                                                File_system::US13 =
                                                                                                                                            match &v366
                                                                                                                                                {
                                                                                                                                                Err(v366_1_0)
                                                                                                                                                =>
                                                                                                                                                v25_1(v366_1_0.clone()),
                                                                                                                                                Ok(v366_0_0)
                                                                                                                                                =>
                                                                                                                                                v24_1(v366_0_0.clone()),
                                                                                                                                            };
                                                                                                                                        let v1845:
                                                                                                                                                Result<std::path::PathBuf,
                                                                                                                                                       std::io::Error> =
                                                                                                                                            match &v369
                                                                                                                                                {
                                                                                                                                                File_system::US13::US13_0(v369_0_0)
                                                                                                                                                =>
                                                                                                                                                Ok(v369_0_0.clone()),
                                                                                                                                                File_system::US13::US13_1(v369_1_0)
                                                                                                                                                =>
                                                                                                                                                {
                                                                                                                                                    let v385:
                                                                                                                                                            string =
                                                                                                                                                        v369_1_0.clone();
                                                                                                                                                    let v386:
                                                                                                                                                            string =
                                                                                                                                                        File_system::method19(v348.clone());
                                                                                                                                                    let v387:
                                                                                                                                                            Option<string> =
                                                                                                                                                        File_system::method81(v348.clone());
                                                                                                                                                    let v401:
                                                                                                                                                            File_system::US1 =
                                                                                                                                                        defaultValue(File_system::US1::US1_1,
                                                                                                                                                                     map(File_system::method4(),
                                                                                                                                                                         v387));
                                                                                                                                                    if let File_system::US1::US1_0(v401_0_0)
                                                                                                                                                           =
                                                                                                                                                           &v401
                                                                                                                                                       {
                                                                                                                                                        let v405:
                                                                                                                                                                string =
                                                                                                                                                            match &v401
                                                                                                                                                                {
                                                                                                                                                                File_system::US1::US1_0(x)
                                                                                                                                                                =>
                                                                                                                                                                x.clone(),
                                                                                                                                                                _
                                                                                                                                                                =>
                                                                                                                                                                unreachable!(),
                                                                                                                                                            };
                                                                                                                                                        if v348.clone()
                                                                                                                                                               !=
                                                                                                                                                               string("")
                                                                                                                                                           {
                                                                                                                                                            let v410:
                                                                                                                                                                    Result<std::path::PathBuf,
                                                                                                                                                                           std::io::Error> =
                                                                                                                                                                std::fs::read_link(&*v405.clone());
                                                                                                                                                            let v411 =
                                                                                                                                                                File_system::method79();
                                                                                                                                                            let v423:
                                                                                                                                                                    Result<std::path::PathBuf,
                                                                                                                                                                           string> =
                                                                                                                                                                v410.map_err(|x| v411(x));
                                                                                                                                                            let v426:
                                                                                                                                                                    File_system::US13 =
                                                                                                                                                                match &v423
                                                                                                                                                                    {
                                                                                                                                                                    Err(v423_1_0)
                                                                                                                                                                    =>
                                                                                                                                                                    v25_1(v423_1_0.clone()),
                                                                                                                                                                    Ok(v423_0_0)
                                                                                                                                                                    =>
                                                                                                                                                                    v24_1(v423_0_0.clone()),
                                                                                                                                                                };
                                                                                                                                                            let v1620:
                                                                                                                                                                    Result<std::path::PathBuf,
                                                                                                                                                                           std::io::Error> =
                                                                                                                                                                match &v426
                                                                                                                                                                    {
                                                                                                                                                                    File_system::US13::US13_0(v426_0_0)
                                                                                                                                                                    =>
                                                                                                                                                                    Ok(v426_0_0.clone()),
                                                                                                                                                                    File_system::US13::US13_1(v426_1_0)
                                                                                                                                                                    =>
                                                                                                                                                                    {
                                                                                                                                                                        let v442:
                                                                                                                                                                                string =
                                                                                                                                                                            v426_1_0.clone();
                                                                                                                                                                        let v443:
                                                                                                                                                                                string =
                                                                                                                                                                            File_system::method19(v405.clone());
                                                                                                                                                                        let v444:
                                                                                                                                                                                Option<string> =
                                                                                                                                                                            File_system::method81(v405.clone());
                                                                                                                                                                        let v458:
                                                                                                                                                                                File_system::US1 =
                                                                                                                                                                            defaultValue(File_system::US1::US1_1,
                                                                                                                                                                                         map(File_system::method4(),
                                                                                                                                                                                             v444));
                                                                                                                                                                        if let File_system::US1::US1_0(v458_0_0)
                                                                                                                                                                               =
                                                                                                                                                                               &v458
                                                                                                                                                                           {
                                                                                                                                                                            let v462:
                                                                                                                                                                                    string =
                                                                                                                                                                                match &v458
                                                                                                                                                                                    {
                                                                                                                                                                                    File_system::US1::US1_0(x)
                                                                                                                                                                                    =>
                                                                                                                                                                                    x.clone(),
                                                                                                                                                                                    _
                                                                                                                                                                                    =>
                                                                                                                                                                                    unreachable!(),
                                                                                                                                                                                };
                                                                                                                                                                            if v405.clone()
                                                                                                                                                                                   !=
                                                                                                                                                                                   string("")
                                                                                                                                                                               {
                                                                                                                                                                                let v467:
                                                                                                                                                                                        Result<std::path::PathBuf,
                                                                                                                                                                                               std::io::Error> =
                                                                                                                                                                                    std::fs::read_link(&*v462.clone());
                                                                                                                                                                                let v468 =
                                                                                                                                                                                    File_system::method79();
                                                                                                                                                                                let v480:
                                                                                                                                                                                        Result<std::path::PathBuf,
                                                                                                                                                                                               string> =
                                                                                                                                                                                    v467.map_err(|x| v468(x));
                                                                                                                                                                                let v483:
                                                                                                                                                                                        File_system::US13 =
                                                                                                                                                                                    match &v480
                                                                                                                                                                                        {
                                                                                                                                                                                        Err(v480_1_0)
                                                                                                                                                                                        =>
                                                                                                                                                                                        v25_1(v480_1_0.clone()),
                                                                                                                                                                                        Ok(v480_0_0)
                                                                                                                                                                                        =>
                                                                                                                                                                                        v24_1(v480_0_0.clone()),
                                                                                                                                                                                    };
                                                                                                                                                                                let v1395:
                                                                                                                                                                                        Result<std::path::PathBuf,
                                                                                                                                                                                               std::io::Error> =
                                                                                                                                                                                    match &v483
                                                                                                                                                                                        {
                                                                                                                                                                                        File_system::US13::US13_0(v483_0_0)
                                                                                                                                                                                        =>
                                                                                                                                                                                        Ok(v483_0_0.clone()),
                                                                                                                                                                                        File_system::US13::US13_1(v483_1_0)
                                                                                                                                                                                        =>
                                                                                                                                                                                        {
                                                                                                                                                                                            let v499:
                                                                                                                                                                                                    string =
                                                                                                                                                                                                v483_1_0.clone();
                                                                                                                                                                                            let v500:
                                                                                                                                                                                                    string =
                                                                                                                                                                                                File_system::method19(v462.clone());
                                                                                                                                                                                            let v501:
                                                                                                                                                                                                    Option<string> =
                                                                                                                                                                                                File_system::method81(v462.clone());
                                                                                                                                                                                            let v515:
                                                                                                                                                                                                    File_system::US1 =
                                                                                                                                                                                                defaultValue(File_system::US1::US1_1,
                                                                                                                                                                                                             map(File_system::method4(),
                                                                                                                                                                                                                 v501));
                                                                                                                                                                                            if let File_system::US1::US1_0(v515_0_0)
                                                                                                                                                                                                   =
                                                                                                                                                                                                   &v515
                                                                                                                                                                                               {
                                                                                                                                                                                                let v519:
                                                                                                                                                                                                        string =
                                                                                                                                                                                                    match &v515
                                                                                                                                                                                                        {
                                                                                                                                                                                                        File_system::US1::US1_0(x)
                                                                                                                                                                                                        =>
                                                                                                                                                                                                        x.clone(),
                                                                                                                                                                                                        _
                                                                                                                                                                                                        =>
                                                                                                                                                                                                        unreachable!(),
                                                                                                                                                                                                    };
                                                                                                                                                                                                if v462.clone()
                                                                                                                                                                                                       !=
                                                                                                                                                                                                       string("")
                                                                                                                                                                                                   {
                                                                                                                                                                                                    let v524:
                                                                                                                                                                                                            Result<std::path::PathBuf,
                                                                                                                                                                                                                   std::io::Error> =
                                                                                                                                                                                                        std::fs::read_link(&*v519.clone());
                                                                                                                                                                                                    let v525 =
                                                                                                                                                                                                        File_system::method79();
                                                                                                                                                                                                    let v537:
                                                                                                                                                                                                            Result<std::path::PathBuf,
                                                                                                                                                                                                                   string> =
                                                                                                                                                                                                        v524.map_err(|x| v525(x));
                                                                                                                                                                                                    let v540:
                                                                                                                                                                                                            File_system::US13 =
                                                                                                                                                                                                        match &v537
                                                                                                                                                                                                            {
                                                                                                                                                                                                            Err(v537_1_0)
                                                                                                                                                                                                            =>
                                                                                                                                                                                                            v25_1(v537_1_0.clone()),
                                                                                                                                                                                                            Ok(v537_0_0)
                                                                                                                                                                                                            =>
                                                                                                                                                                                                            v24_1(v537_0_0.clone()),
                                                                                                                                                                                                        };
                                                                                                                                                                                                    let v1170:
                                                                                                                                                                                                            Result<std::path::PathBuf,
                                                                                                                                                                                                                   std::io::Error> =
                                                                                                                                                                                                        match &v540
                                                                                                                                                                                                            {
                                                                                                                                                                                                            File_system::US13::US13_0(v540_0_0)
                                                                                                                                                                                                            =>
                                                                                                                                                                                                            Ok(v540_0_0.clone()),
                                                                                                                                                                                                            File_system::US13::US13_1(v540_1_0)
                                                                                                                                                                                                            =>
                                                                                                                                                                                                            {
                                                                                                                                                                                                                let v556:
                                                                                                                                                                                                                        string =
                                                                                                                                                                                                                    v540_1_0.clone();
                                                                                                                                                                                                                let v557:
                                                                                                                                                                                                                        string =
                                                                                                                                                                                                                    File_system::method19(v519.clone());
                                                                                                                                                                                                                let v558:
                                                                                                                                                                                                                        Option<string> =
                                                                                                                                                                                                                    File_system::method81(v519.clone());
                                                                                                                                                                                                                let v572:
                                                                                                                                                                                                                        File_system::US1 =
                                                                                                                                                                                                                    defaultValue(File_system::US1::US1_1,
                                                                                                                                                                                                                                 map(File_system::method4(),
                                                                                                                                                                                                                                     v558));
                                                                                                                                                                                                                if let File_system::US1::US1_0(v572_0_0)
                                                                                                                                                                                                                       =
                                                                                                                                                                                                                       &v572
                                                                                                                                                                                                                   {
                                                                                                                                                                                                                    let v576:
                                                                                                                                                                                                                            string =
                                                                                                                                                                                                                        match &v572
                                                                                                                                                                                                                            {
                                                                                                                                                                                                                            File_system::US1::US1_0(x)
                                                                                                                                                                                                                            =>
                                                                                                                                                                                                                            x.clone(),
                                                                                                                                                                                                                            _
                                                                                                                                                                                                                            =>
                                                                                                                                                                                                                            unreachable!(),
                                                                                                                                                                                                                        };
                                                                                                                                                                                                                    if v519.clone()
                                                                                                                                                                                                                           !=
                                                                                                                                                                                                                           string("")
                                                                                                                                                                                                                       {
                                                                                                                                                                                                                        let v581:
                                                                                                                                                                                                                                Result<std::path::PathBuf,
                                                                                                                                                                                                                                       std::io::Error> =
                                                                                                                                                                                                                            std::fs::read_link(&*v576.clone());
                                                                                                                                                                                                                        let v582 =
                                                                                                                                                                                                                            File_system::method79();
                                                                                                                                                                                                                        let v594:
                                                                                                                                                                                                                                Result<std::path::PathBuf,
                                                                                                                                                                                                                                       string> =
                                                                                                                                                                                                                            v581.map_err(|x| v582(x));
                                                                                                                                                                                                                        let v597:
                                                                                                                                                                                                                                File_system::US13 =
                                                                                                                                                                                                                            match &v594
                                                                                                                                                                                                                                {
                                                                                                                                                                                                                                Err(v594_1_0)
                                                                                                                                                                                                                                =>
                                                                                                                                                                                                                                v25_1(v594_1_0.clone()),
                                                                                                                                                                                                                                Ok(v594_0_0)
                                                                                                                                                                                                                                =>
                                                                                                                                                                                                                                v24_1(v594_0_0.clone()),
                                                                                                                                                                                                                            };
                                                                                                                                                                                                                        let v945:
                                                                                                                                                                                                                                Result<std::path::PathBuf,
                                                                                                                                                                                                                                       std::io::Error> =
                                                                                                                                                                                                                            match &v597
                                                                                                                                                                                                                                {
                                                                                                                                                                                                                                File_system::US13::US13_0(v597_0_0)
                                                                                                                                                                                                                                =>
                                                                                                                                                                                                                                Ok(v597_0_0.clone()),
                                                                                                                                                                                                                                File_system::US13::US13_1(v597_1_0)
                                                                                                                                                                                                                                =>
                                                                                                                                                                                                                                {
                                                                                                                                                                                                                                    let v613:
                                                                                                                                                                                                                                            string =
                                                                                                                                                                                                                                        v597_1_0.clone();
                                                                                                                                                                                                                                    let v614:
                                                                                                                                                                                                                                            string =
                                                                                                                                                                                                                                        File_system::method19(v576.clone());
                                                                                                                                                                                                                                    let v615:
                                                                                                                                                                                                                                            Option<string> =
                                                                                                                                                                                                                                        File_system::method81(v576.clone());
                                                                                                                                                                                                                                    let v629:
                                                                                                                                                                                                                                            File_system::US1 =
                                                                                                                                                                                                                                        defaultValue(File_system::US1::US1_1,
                                                                                                                                                                                                                                                     map(File_system::method4(),
                                                                                                                                                                                                                                                         v615));
                                                                                                                                                                                                                                    if let File_system::US1::US1_0(v629_0_0)
                                                                                                                                                                                                                                           =
                                                                                                                                                                                                                                           &v629
                                                                                                                                                                                                                                       {
                                                                                                                                                                                                                                        let v633:
                                                                                                                                                                                                                                                string =
                                                                                                                                                                                                                                            match &v629
                                                                                                                                                                                                                                                {
                                                                                                                                                                                                                                                File_system::US1::US1_0(x)
                                                                                                                                                                                                                                                =>
                                                                                                                                                                                                                                                x.clone(),
                                                                                                                                                                                                                                                _
                                                                                                                                                                                                                                                =>
                                                                                                                                                                                                                                                unreachable!(),
                                                                                                                                                                                                                                            };
                                                                                                                                                                                                                                        if v576.clone()
                                                                                                                                                                                                                                               !=
                                                                                                                                                                                                                                               string("")
                                                                                                                                                                                                                                           {
                                                                                                                                                                                                                                            let v638:
                                                                                                                                                                                                                                                    Result<std::path::PathBuf,
                                                                                                                                                                                                                                                           std::io::Error> =
                                                                                                                                                                                                                                                std::fs::read_link(&*v633.clone());
                                                                                                                                                                                                                                            let v639 =
                                                                                                                                                                                                                                                File_system::method79();
                                                                                                                                                                                                                                            let v651:
                                                                                                                                                                                                                                                    Result<std::path::PathBuf,
                                                                                                                                                                                                                                                           string> =
                                                                                                                                                                                                                                                v638.map_err(|x| v639(x));
                                                                                                                                                                                                                                            let v654:
                                                                                                                                                                                                                                                    File_system::US13 =
                                                                                                                                                                                                                                                match &v651
                                                                                                                                                                                                                                                    {
                                                                                                                                                                                                                                                    Err(v651_1_0)
                                                                                                                                                                                                                                                    =>
                                                                                                                                                                                                                                                    v25_1(v651_1_0.clone()),
                                                                                                                                                                                                                                                    Ok(v651_0_0)
                                                                                                                                                                                                                                                    =>
                                                                                                                                                                                                                                                    v24_1(v651_0_0.clone()),
                                                                                                                                                                                                                                                };
                                                                                                                                                                                                                                            let v720:
                                                                                                                                                                                                                                                    Result<std::path::PathBuf,
                                                                                                                                                                                                                                                           std::io::Error> =
                                                                                                                                                                                                                                                match &v654
                                                                                                                                                                                                                                                    {
                                                                                                                                                                                                                                                    File_system::US13::US13_0(v654_0_0)
                                                                                                                                                                                                                                                    =>
                                                                                                                                                                                                                                                    Ok(v654_0_0.clone()),
                                                                                                                                                                                                                                                    _
                                                                                                                                                                                                                                                    =>
                                                                                                                                                                                                                                                    {
                                                                                                                                                                                                                                                        let v671:
                                                                                                                                                                                                                                                                string =
                                                                                                                                                                                                                                                            File_system::method19(v633.clone());
                                                                                                                                                                                                                                                        let v672:
                                                                                                                                                                                                                                                                Option<string> =
                                                                                                                                                                                                                                                            File_system::method81(v633.clone());
                                                                                                                                                                                                                                                        let v686:
                                                                                                                                                                                                                                                                File_system::US1 =
                                                                                                                                                                                                                                                            defaultValue(File_system::US1::US1_1,
                                                                                                                                                                                                                                                                         map(File_system::method4(),
                                                                                                                                                                                                                                                                             v672));
                                                                                                                                                                                                                                                        let v690:
                                                                                                                                                                                                                                                                string =
                                                                                                                                                                                                                                                            sprintf!("file_system.read_link / path: {} / n: {} / path\': {} / name: {}",
                                                                                                                                                                                                                                                                     v0_1.clone(),
                                                                                                                                                                                                                                                                     11_u8,
                                                                                                                                                                                                                                                                     v633.clone(),
                                                                                                                                                                                                                                                                     v671);
                                                                                                                                                                                                                                                        let v693:
                                                                                                                                                                                                                                                                std::io::Error =
                                                                                                                                                                                                                                                            std::io::Error::new(std::io::ErrorKind::Other, &*v690);
                                                                                                                                                                                                                                                        Err(v693)
                                                                                                                                                                                                                                                    }
                                                                                                                                                                                                                                                };
                                                                                                                                                                                                                                            let v721 =
                                                                                                                                                                                                                                                File_system::method79();
                                                                                                                                                                                                                                            let v733:
                                                                                                                                                                                                                                                    Result<std::path::PathBuf,
                                                                                                                                                                                                                                                           string> =
                                                                                                                                                                                                                                                v720.map_err(|x| v721(x));
                                                                                                                                                                                                                                            let v736:
                                                                                                                                                                                                                                                    File_system::US13 =
                                                                                                                                                                                                                                                match &v733
                                                                                                                                                                                                                                                    {
                                                                                                                                                                                                                                                    Err(v733_1_0)
                                                                                                                                                                                                                                                    =>
                                                                                                                                                                                                                                                    v25_1(v733_1_0.clone()),
                                                                                                                                                                                                                                                    Ok(v733_0_0)
                                                                                                                                                                                                                                                    =>
                                                                                                                                                                                                                                                    v24_1(v733_0_0.clone()),
                                                                                                                                                                                                                                                };
                                                                                                                                                                                                                                            match &v736
                                                                                                                                                                                                                                                {
                                                                                                                                                                                                                                                File_system::US13::US13_0(v736_0_0)
                                                                                                                                                                                                                                                =>
                                                                                                                                                                                                                                                {
                                                                                                                                                                                                                                                    let v765:
                                                                                                                                                                                                                                                            string =
                                                                                                                                                                                                                                                        File_system::method59(toString(v736_0_0.clone().display()),
                                                                                                                                                                                                                                                                              v614.clone());
                                                                                                                                                                                                                                                    let v768:
                                                                                                                                                                                                                                                            &str =
                                                                                                                                                                                                                                                        &*v765;
                                                                                                                                                                                                                                                    let v792:
                                                                                                                                                                                                                                                            std::string::String =
                                                                                                                                                                                                                                                        String::from(v768);
                                                                                                                                                                                                                                                    let v816:
                                                                                                                                                                                                                                                            std::path::PathBuf =
                                                                                                                                                                                                                                                        std::path::PathBuf::from(v792);
                                                                                                                                                                                                                                                    Ok(v816)
                                                                                                                                                                                                                                                }
                                                                                                                                                                                                                                                File_system::US13::US13_1(v736_1_0)
                                                                                                                                                                                                                                                =>
                                                                                                                                                                                                                                                {
                                                                                                                                                                                                                                                    let v853:
                                                                                                                                                                                                                                                            string =
                                                                                                                                                                                                                                                        sprintf!("file_system.read_link / error\': {} / error: {} / name: {}",
                                                                                                                                                                                                                                                                 v736_1_0.clone(),
                                                                                                                                                                                                                                                                 v613.clone(),
                                                                                                                                                                                                                                                                 v614.clone());
                                                                                                                                                                                                                                                    let v856:
                                                                                                                                                                                                                                                            std::io::Error =
                                                                                                                                                                                                                                                        std::io::Error::new(std::io::ErrorKind::Other, &*v853);
                                                                                                                                                                                                                                                    Err(v856)
                                                                                                                                                                                                                                                }
                                                                                                                                                                                                                                            }
                                                                                                                                                                                                                                        } else {
                                                                                                                                                                                                                                            let v884:
                                                                                                                                                                                                                                                    string =
                                                                                                                                                                                                                                                sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                                                                                                                                                                                                                         v0_1.clone(),
                                                                                                                                                                                                                                                         v613.clone(),
                                                                                                                                                                                                                                                         v576.clone(),
                                                                                                                                                                                                                                                         v614.clone());
                                                                                                                                                                                                                                            let v887:
                                                                                                                                                                                                                                                    std::io::Error =
                                                                                                                                                                                                                                                std::io::Error::new(std::io::ErrorKind::Other, &*v884);
                                                                                                                                                                                                                                            Err(v887)
                                                                                                                                                                                                                                        }
                                                                                                                                                                                                                                    } else {
                                                                                                                                                                                                                                        let v914:
                                                                                                                                                                                                                                                string =
                                                                                                                                                                                                                                            sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                                                                                                                                                                                                                     v0_1.clone(),
                                                                                                                                                                                                                                                     v613,
                                                                                                                                                                                                                                                     v576.clone(),
                                                                                                                                                                                                                                                     v614.clone());
                                                                                                                                                                                                                                        let v917:
                                                                                                                                                                                                                                                std::io::Error =
                                                                                                                                                                                                                                            std::io::Error::new(std::io::ErrorKind::Other, &*v914);
                                                                                                                                                                                                                                        Err(v917)
                                                                                                                                                                                                                                    }
                                                                                                                                                                                                                                }
                                                                                                                                                                                                                            };
                                                                                                                                                                                                                        let v946 =
                                                                                                                                                                                                                            File_system::method79();
                                                                                                                                                                                                                        let v958:
                                                                                                                                                                                                                                Result<std::path::PathBuf,
                                                                                                                                                                                                                                       string> =
                                                                                                                                                                                                                            v945.map_err(|x| v946(x));
                                                                                                                                                                                                                        let v961:
                                                                                                                                                                                                                                File_system::US13 =
                                                                                                                                                                                                                            match &v958
                                                                                                                                                                                                                                {
                                                                                                                                                                                                                                Err(v958_1_0)
                                                                                                                                                                                                                                =>
                                                                                                                                                                                                                                v25_1(v958_1_0.clone()),
                                                                                                                                                                                                                                Ok(v958_0_0)
                                                                                                                                                                                                                                =>
                                                                                                                                                                                                                                v24_1(v958_0_0.clone()),
                                                                                                                                                                                                                            };
                                                                                                                                                                                                                        match &v961
                                                                                                                                                                                                                            {
                                                                                                                                                                                                                            File_system::US13::US13_0(v961_0_0)
                                                                                                                                                                                                                            =>
                                                                                                                                                                                                                            {
                                                                                                                                                                                                                                let v990:
                                                                                                                                                                                                                                        string =
                                                                                                                                                                                                                                    File_system::method59(toString(v961_0_0.clone().display()),
                                                                                                                                                                                                                                                          v557.clone());
                                                                                                                                                                                                                                let v993:
                                                                                                                                                                                                                                        &str =
                                                                                                                                                                                                                                    &*v990;
                                                                                                                                                                                                                                let v1017:
                                                                                                                                                                                                                                        std::string::String =
                                                                                                                                                                                                                                    String::from(v993);
                                                                                                                                                                                                                                let v1041:
                                                                                                                                                                                                                                        std::path::PathBuf =
                                                                                                                                                                                                                                    std::path::PathBuf::from(v1017);
                                                                                                                                                                                                                                Ok(v1041)
                                                                                                                                                                                                                            }
                                                                                                                                                                                                                            File_system::US13::US13_1(v961_1_0)
                                                                                                                                                                                                                            =>
                                                                                                                                                                                                                            {
                                                                                                                                                                                                                                let v1078:
                                                                                                                                                                                                                                        string =
                                                                                                                                                                                                                                    sprintf!("file_system.read_link / error\': {} / error: {} / name: {}",
                                                                                                                                                                                                                                             v961_1_0.clone(),
                                                                                                                                                                                                                                             v556.clone(),
                                                                                                                                                                                                                                             v557.clone());
                                                                                                                                                                                                                                let v1081:
                                                                                                                                                                                                                                        std::io::Error =
                                                                                                                                                                                                                                    std::io::Error::new(std::io::ErrorKind::Other, &*v1078);
                                                                                                                                                                                                                                Err(v1081)
                                                                                                                                                                                                                            }
                                                                                                                                                                                                                        }
                                                                                                                                                                                                                    } else {
                                                                                                                                                                                                                        let v1109:
                                                                                                                                                                                                                                string =
                                                                                                                                                                                                                            sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                                                                                                                                                                                                     v0_1.clone(),
                                                                                                                                                                                                                                     v556.clone(),
                                                                                                                                                                                                                                     v519.clone(),
                                                                                                                                                                                                                                     v557.clone());
                                                                                                                                                                                                                        let v1112:
                                                                                                                                                                                                                                std::io::Error =
                                                                                                                                                                                                                            std::io::Error::new(std::io::ErrorKind::Other, &*v1109);
                                                                                                                                                                                                                        Err(v1112)
                                                                                                                                                                                                                    }
                                                                                                                                                                                                                } else {
                                                                                                                                                                                                                    let v1139:
                                                                                                                                                                                                                            string =
                                                                                                                                                                                                                        sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                                                                                                                                                                                                 v0_1.clone(),
                                                                                                                                                                                                                                 v556,
                                                                                                                                                                                                                                 v519.clone(),
                                                                                                                                                                                                                                 v557.clone());
                                                                                                                                                                                                                    let v1142:
                                                                                                                                                                                                                            std::io::Error =
                                                                                                                                                                                                                        std::io::Error::new(std::io::ErrorKind::Other, &*v1139);
                                                                                                                                                                                                                    Err(v1142)
                                                                                                                                                                                                                }
                                                                                                                                                                                                            }
                                                                                                                                                                                                        };
                                                                                                                                                                                                    let v1171 =
                                                                                                                                                                                                        File_system::method79();
                                                                                                                                                                                                    let v1183:
                                                                                                                                                                                                            Result<std::path::PathBuf,
                                                                                                                                                                                                                   string> =
                                                                                                                                                                                                        v1170.map_err(|x| v1171(x));
                                                                                                                                                                                                    let v1186:
                                                                                                                                                                                                            File_system::US13 =
                                                                                                                                                                                                        match &v1183
                                                                                                                                                                                                            {
                                                                                                                                                                                                            Err(v1183_1_0)
                                                                                                                                                                                                            =>
                                                                                                                                                                                                            v25_1(v1183_1_0.clone()),
                                                                                                                                                                                                            Ok(v1183_0_0)
                                                                                                                                                                                                            =>
                                                                                                                                                                                                            v24_1(v1183_0_0.clone()),
                                                                                                                                                                                                        };
                                                                                                                                                                                                    match &v1186
                                                                                                                                                                                                        {
                                                                                                                                                                                                        File_system::US13::US13_0(v1186_0_0)
                                                                                                                                                                                                        =>
                                                                                                                                                                                                        {
                                                                                                                                                                                                            let v1215:
                                                                                                                                                                                                                    string =
                                                                                                                                                                                                                File_system::method59(toString(v1186_0_0.clone().display()),
                                                                                                                                                                                                                                      v500.clone());
                                                                                                                                                                                                            let v1218:
                                                                                                                                                                                                                    &str =
                                                                                                                                                                                                                &*v1215;
                                                                                                                                                                                                            let v1242:
                                                                                                                                                                                                                    std::string::String =
                                                                                                                                                                                                                String::from(v1218);
                                                                                                                                                                                                            let v1266:
                                                                                                                                                                                                                    std::path::PathBuf =
                                                                                                                                                                                                                std::path::PathBuf::from(v1242);
                                                                                                                                                                                                            Ok(v1266)
                                                                                                                                                                                                        }
                                                                                                                                                                                                        File_system::US13::US13_1(v1186_1_0)
                                                                                                                                                                                                        =>
                                                                                                                                                                                                        {
                                                                                                                                                                                                            let v1303:
                                                                                                                                                                                                                    string =
                                                                                                                                                                                                                sprintf!("file_system.read_link / error\': {} / error: {} / name: {}",
                                                                                                                                                                                                                         v1186_1_0.clone(),
                                                                                                                                                                                                                         v499.clone(),
                                                                                                                                                                                                                         v500.clone());
                                                                                                                                                                                                            let v1306:
                                                                                                                                                                                                                    std::io::Error =
                                                                                                                                                                                                                std::io::Error::new(std::io::ErrorKind::Other, &*v1303);
                                                                                                                                                                                                            Err(v1306)
                                                                                                                                                                                                        }
                                                                                                                                                                                                    }
                                                                                                                                                                                                } else {
                                                                                                                                                                                                    let v1334:
                                                                                                                                                                                                            string =
                                                                                                                                                                                                        sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                                                                                                                                                                                 v0_1.clone(),
                                                                                                                                                                                                                 v499.clone(),
                                                                                                                                                                                                                 v462.clone(),
                                                                                                                                                                                                                 v500.clone());
                                                                                                                                                                                                    let v1337:
                                                                                                                                                                                                            std::io::Error =
                                                                                                                                                                                                        std::io::Error::new(std::io::ErrorKind::Other, &*v1334);
                                                                                                                                                                                                    Err(v1337)
                                                                                                                                                                                                }
                                                                                                                                                                                            } else {
                                                                                                                                                                                                let v1364:
                                                                                                                                                                                                        string =
                                                                                                                                                                                                    sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                                                                                                                                                                             v0_1.clone(),
                                                                                                                                                                                                             v499,
                                                                                                                                                                                                             v462.clone(),
                                                                                                                                                                                                             v500.clone());
                                                                                                                                                                                                let v1367:
                                                                                                                                                                                                        std::io::Error =
                                                                                                                                                                                                    std::io::Error::new(std::io::ErrorKind::Other, &*v1364);
                                                                                                                                                                                                Err(v1367)
                                                                                                                                                                                            }
                                                                                                                                                                                        }
                                                                                                                                                                                    };
                                                                                                                                                                                let v1396 =
                                                                                                                                                                                    File_system::method79();
                                                                                                                                                                                let v1408:
                                                                                                                                                                                        Result<std::path::PathBuf,
                                                                                                                                                                                               string> =
                                                                                                                                                                                    v1395.map_err(|x| v1396(x));
                                                                                                                                                                                let v1411:
                                                                                                                                                                                        File_system::US13 =
                                                                                                                                                                                    match &v1408
                                                                                                                                                                                        {
                                                                                                                                                                                        Err(v1408_1_0)
                                                                                                                                                                                        =>
                                                                                                                                                                                        v25_1(v1408_1_0.clone()),
                                                                                                                                                                                        Ok(v1408_0_0)
                                                                                                                                                                                        =>
                                                                                                                                                                                        v24_1(v1408_0_0.clone()),
                                                                                                                                                                                    };
                                                                                                                                                                                match &v1411
                                                                                                                                                                                    {
                                                                                                                                                                                    File_system::US13::US13_0(v1411_0_0)
                                                                                                                                                                                    =>
                                                                                                                                                                                    {
                                                                                                                                                                                        let v1440:
                                                                                                                                                                                                string =
                                                                                                                                                                                            File_system::method59(toString(v1411_0_0.clone().display()),
                                                                                                                                                                                                                  v443.clone());
                                                                                                                                                                                        let v1443:
                                                                                                                                                                                                &str =
                                                                                                                                                                                            &*v1440;
                                                                                                                                                                                        let v1467:
                                                                                                                                                                                                std::string::String =
                                                                                                                                                                                            String::from(v1443);
                                                                                                                                                                                        let v1491:
                                                                                                                                                                                                std::path::PathBuf =
                                                                                                                                                                                            std::path::PathBuf::from(v1467);
                                                                                                                                                                                        Ok(v1491)
                                                                                                                                                                                    }
                                                                                                                                                                                    File_system::US13::US13_1(v1411_1_0)
                                                                                                                                                                                    =>
                                                                                                                                                                                    {
                                                                                                                                                                                        let v1528:
                                                                                                                                                                                                string =
                                                                                                                                                                                            sprintf!("file_system.read_link / error\': {} / error: {} / name: {}",
                                                                                                                                                                                                     v1411_1_0.clone(),
                                                                                                                                                                                                     v442.clone(),
                                                                                                                                                                                                     v443.clone());
                                                                                                                                                                                        let v1531:
                                                                                                                                                                                                std::io::Error =
                                                                                                                                                                                            std::io::Error::new(std::io::ErrorKind::Other, &*v1528);
                                                                                                                                                                                        Err(v1531)
                                                                                                                                                                                    }
                                                                                                                                                                                }
                                                                                                                                                                            } else {
                                                                                                                                                                                let v1559:
                                                                                                                                                                                        string =
                                                                                                                                                                                    sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                                                                                                                                                             v0_1.clone(),
                                                                                                                                                                                             v442.clone(),
                                                                                                                                                                                             v405.clone(),
                                                                                                                                                                                             v443.clone());
                                                                                                                                                                                let v1562:
                                                                                                                                                                                        std::io::Error =
                                                                                                                                                                                    std::io::Error::new(std::io::ErrorKind::Other, &*v1559);
                                                                                                                                                                                Err(v1562)
                                                                                                                                                                            }
                                                                                                                                                                        } else {
                                                                                                                                                                            let v1589:
                                                                                                                                                                                    string =
                                                                                                                                                                                sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                                                                                                                                                         v0_1.clone(),
                                                                                                                                                                                         v442,
                                                                                                                                                                                         v405.clone(),
                                                                                                                                                                                         v443.clone());
                                                                                                                                                                            let v1592:
                                                                                                                                                                                    std::io::Error =
                                                                                                                                                                                std::io::Error::new(std::io::ErrorKind::Other, &*v1589);
                                                                                                                                                                            Err(v1592)
                                                                                                                                                                        }
                                                                                                                                                                    }
                                                                                                                                                                };
                                                                                                                                                            let v1621 =
                                                                                                                                                                File_system::method79();
                                                                                                                                                            let v1633:
                                                                                                                                                                    Result<std::path::PathBuf,
                                                                                                                                                                           string> =
                                                                                                                                                                v1620.map_err(|x| v1621(x));
                                                                                                                                                            let v1636:
                                                                                                                                                                    File_system::US13 =
                                                                                                                                                                match &v1633
                                                                                                                                                                    {
                                                                                                                                                                    Err(v1633_1_0)
                                                                                                                                                                    =>
                                                                                                                                                                    v25_1(v1633_1_0.clone()),
                                                                                                                                                                    Ok(v1633_0_0)
                                                                                                                                                                    =>
                                                                                                                                                                    v24_1(v1633_0_0.clone()),
                                                                                                                                                                };
                                                                                                                                                            match &v1636
                                                                                                                                                                {
                                                                                                                                                                File_system::US13::US13_0(v1636_0_0)
                                                                                                                                                                =>
                                                                                                                                                                {
                                                                                                                                                                    let v1665:
                                                                                                                                                                            string =
                                                                                                                                                                        File_system::method59(toString(v1636_0_0.clone().display()),
                                                                                                                                                                                              v386.clone());
                                                                                                                                                                    let v1668:
                                                                                                                                                                            &str =
                                                                                                                                                                        &*v1665;
                                                                                                                                                                    let v1692:
                                                                                                                                                                            std::string::String =
                                                                                                                                                                        String::from(v1668);
                                                                                                                                                                    let v1716:
                                                                                                                                                                            std::path::PathBuf =
                                                                                                                                                                        std::path::PathBuf::from(v1692);
                                                                                                                                                                    Ok(v1716)
                                                                                                                                                                }
                                                                                                                                                                File_system::US13::US13_1(v1636_1_0)
                                                                                                                                                                =>
                                                                                                                                                                {
                                                                                                                                                                    let v1753:
                                                                                                                                                                            string =
                                                                                                                                                                        sprintf!("file_system.read_link / error\': {} / error: {} / name: {}",
                                                                                                                                                                                 v1636_1_0.clone(),
                                                                                                                                                                                 v385.clone(),
                                                                                                                                                                                 v386.clone());
                                                                                                                                                                    let v1756:
                                                                                                                                                                            std::io::Error =
                                                                                                                                                                        std::io::Error::new(std::io::ErrorKind::Other, &*v1753);
                                                                                                                                                                    Err(v1756)
                                                                                                                                                                }
                                                                                                                                                            }
                                                                                                                                                        } else {
                                                                                                                                                            let v1784:
                                                                                                                                                                    string =
                                                                                                                                                                sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                                                                                                                                         v0_1.clone(),
                                                                                                                                                                         v385.clone(),
                                                                                                                                                                         v348.clone(),
                                                                                                                                                                         v386.clone());
                                                                                                                                                            let v1787:
                                                                                                                                                                    std::io::Error =
                                                                                                                                                                std::io::Error::new(std::io::ErrorKind::Other, &*v1784);
                                                                                                                                                            Err(v1787)
                                                                                                                                                        }
                                                                                                                                                    } else {
                                                                                                                                                        let v1814:
                                                                                                                                                                string =
                                                                                                                                                            sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                                                                                                                                     v0_1.clone(),
                                                                                                                                                                     v385,
                                                                                                                                                                     v348.clone(),
                                                                                                                                                                     v386.clone());
                                                                                                                                                        let v1817:
                                                                                                                                                                std::io::Error =
                                                                                                                                                            std::io::Error::new(std::io::ErrorKind::Other, &*v1814);
                                                                                                                                                        Err(v1817)
                                                                                                                                                    }
                                                                                                                                                }
                                                                                                                                            };
                                                                                                                                        let v1846 =
                                                                                                                                            File_system::method79();
                                                                                                                                        let v1858:
                                                                                                                                                Result<std::path::PathBuf,
                                                                                                                                                       string> =
                                                                                                                                            v1845.map_err(|x| v1846(x));
                                                                                                                                        let v1861:
                                                                                                                                                File_system::US13 =
                                                                                                                                            match &v1858
                                                                                                                                                {
                                                                                                                                                Err(v1858_1_0)
                                                                                                                                                =>
                                                                                                                                                v25_1(v1858_1_0.clone()),
                                                                                                                                                Ok(v1858_0_0)
                                                                                                                                                =>
                                                                                                                                                v24_1(v1858_0_0.clone()),
                                                                                                                                            };
                                                                                                                                        match &v1861
                                                                                                                                            {
                                                                                                                                            File_system::US13::US13_0(v1861_0_0)
                                                                                                                                            =>
                                                                                                                                            {
                                                                                                                                                let v1890:
                                                                                                                                                        string =
                                                                                                                                                    File_system::method59(toString(v1861_0_0.clone().display()),
                                                                                                                                                                          v329.clone());
                                                                                                                                                let v1893:
                                                                                                                                                        &str =
                                                                                                                                                    &*v1890;
                                                                                                                                                let v1917:
                                                                                                                                                        std::string::String =
                                                                                                                                                    String::from(v1893);
                                                                                                                                                let v1941:
                                                                                                                                                        std::path::PathBuf =
                                                                                                                                                    std::path::PathBuf::from(v1917);
                                                                                                                                                Ok(v1941)
                                                                                                                                            }
                                                                                                                                            File_system::US13::US13_1(v1861_1_0)
                                                                                                                                            =>
                                                                                                                                            {
                                                                                                                                                let v1978:
                                                                                                                                                        string =
                                                                                                                                                    sprintf!("file_system.read_link / error\': {} / error: {} / name: {}",
                                                                                                                                                             v1861_1_0.clone(),
                                                                                                                                                             v328.clone(),
                                                                                                                                                             v329.clone());
                                                                                                                                                let v1981:
                                                                                                                                                        std::io::Error =
                                                                                                                                                    std::io::Error::new(std::io::ErrorKind::Other, &*v1978);
                                                                                                                                                Err(v1981)
                                                                                                                                            }
                                                                                                                                        }
                                                                                                                                    } else {
                                                                                                                                        let v2009:
                                                                                                                                                string =
                                                                                                                                            sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                                                                                                                     v0_1.clone(),
                                                                                                                                                     v328.clone(),
                                                                                                                                                     v291.clone(),
                                                                                                                                                     v329.clone());
                                                                                                                                        let v2012:
                                                                                                                                                std::io::Error =
                                                                                                                                            std::io::Error::new(std::io::ErrorKind::Other, &*v2009);
                                                                                                                                        Err(v2012)
                                                                                                                                    }
                                                                                                                                } else {
                                                                                                                                    let v2039:
                                                                                                                                            string =
                                                                                                                                        sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                                                                                                                 v0_1.clone(),
                                                                                                                                                 v328,
                                                                                                                                                 v291.clone(),
                                                                                                                                                 v329.clone());
                                                                                                                                    let v2042:
                                                                                                                                            std::io::Error =
                                                                                                                                        std::io::Error::new(std::io::ErrorKind::Other, &*v2039);
                                                                                                                                    Err(v2042)
                                                                                                                                }
                                                                                                                            }
                                                                                                                        };
                                                                                                                    let v2071 =
                                                                                                                        File_system::method79();
                                                                                                                    let v2083:
                                                                                                                            Result<std::path::PathBuf,
                                                                                                                                   string> =
                                                                                                                        v2070.map_err(|x| v2071(x));
                                                                                                                    let v2086:
                                                                                                                            File_system::US13 =
                                                                                                                        match &v2083
                                                                                                                            {
                                                                                                                            Err(v2083_1_0)
                                                                                                                            =>
                                                                                                                            v25_1(v2083_1_0.clone()),
                                                                                                                            Ok(v2083_0_0)
                                                                                                                            =>
                                                                                                                            v24_1(v2083_0_0.clone()),
                                                                                                                        };
                                                                                                                    match &v2086
                                                                                                                        {
                                                                                                                        File_system::US13::US13_0(v2086_0_0)
                                                                                                                        =>
                                                                                                                        {
                                                                                                                            let v2115:
                                                                                                                                    string =
                                                                                                                                File_system::method59(toString(v2086_0_0.clone().display()),
                                                                                                                                                      v272.clone());
                                                                                                                            let v2118:
                                                                                                                                    &str =
                                                                                                                                &*v2115;
                                                                                                                            let v2142:
                                                                                                                                    std::string::String =
                                                                                                                                String::from(v2118);
                                                                                                                            let v2166:
                                                                                                                                    std::path::PathBuf =
                                                                                                                                std::path::PathBuf::from(v2142);
                                                                                                                            Ok(v2166)
                                                                                                                        }
                                                                                                                        File_system::US13::US13_1(v2086_1_0)
                                                                                                                        =>
                                                                                                                        {
                                                                                                                            let v2203:
                                                                                                                                    string =
                                                                                                                                sprintf!("file_system.read_link / error\': {} / error: {} / name: {}",
                                                                                                                                         v2086_1_0.clone(),
                                                                                                                                         v271.clone(),
                                                                                                                                         v272.clone());
                                                                                                                            let v2206:
                                                                                                                                    std::io::Error =
                                                                                                                                std::io::Error::new(std::io::ErrorKind::Other, &*v2203);
                                                                                                                            Err(v2206)
                                                                                                                        }
                                                                                                                    }
                                                                                                                } else {
                                                                                                                    let v2234:
                                                                                                                            string =
                                                                                                                        sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                                                                                                 v0_1.clone(),
                                                                                                                                 v271.clone(),
                                                                                                                                 v234.clone(),
                                                                                                                                 v272.clone());
                                                                                                                    let v2237:
                                                                                                                            std::io::Error =
                                                                                                                        std::io::Error::new(std::io::ErrorKind::Other, &*v2234);
                                                                                                                    Err(v2237)
                                                                                                                }
                                                                                                            } else {
                                                                                                                let v2264:
                                                                                                                        string =
                                                                                                                    sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                                                                                             v0_1.clone(),
                                                                                                                             v271,
                                                                                                                             v234.clone(),
                                                                                                                             v272.clone());
                                                                                                                let v2267:
                                                                                                                        std::io::Error =
                                                                                                                    std::io::Error::new(std::io::ErrorKind::Other, &*v2264);
                                                                                                                Err(v2267)
                                                                                                            }
                                                                                                        }
                                                                                                    };
                                                                                                let v2296 =
                                                                                                    File_system::method79();
                                                                                                let v2308:
                                                                                                        Result<std::path::PathBuf,
                                                                                                               string> =
                                                                                                    v2295.map_err(|x| v2296(x));
                                                                                                let v2311:
                                                                                                        File_system::US13 =
                                                                                                    match &v2308
                                                                                                        {
                                                                                                        Err(v2308_1_0)
                                                                                                        =>
                                                                                                        v25_1(v2308_1_0.clone()),
                                                                                                        Ok(v2308_0_0)
                                                                                                        =>
                                                                                                        v24_1(v2308_0_0.clone()),
                                                                                                    };
                                                                                                match &v2311
                                                                                                    {
                                                                                                    File_system::US13::US13_0(v2311_0_0)
                                                                                                    =>
                                                                                                    {
                                                                                                        let v2340:
                                                                                                                string =
                                                                                                            File_system::method59(toString(v2311_0_0.clone().display()),
                                                                                                                                  v215.clone());
                                                                                                        let v2343:
                                                                                                                &str =
                                                                                                            &*v2340;
                                                                                                        let v2367:
                                                                                                                std::string::String =
                                                                                                            String::from(v2343);
                                                                                                        let v2391:
                                                                                                                std::path::PathBuf =
                                                                                                            std::path::PathBuf::from(v2367);
                                                                                                        Ok(v2391)
                                                                                                    }
                                                                                                    File_system::US13::US13_1(v2311_1_0)
                                                                                                    =>
                                                                                                    {
                                                                                                        let v2428:
                                                                                                                string =
                                                                                                            sprintf!("file_system.read_link / error\': {} / error: {} / name: {}",
                                                                                                                     v2311_1_0.clone(),
                                                                                                                     v214.clone(),
                                                                                                                     v215.clone());
                                                                                                        let v2431:
                                                                                                                std::io::Error =
                                                                                                            std::io::Error::new(std::io::ErrorKind::Other, &*v2428);
                                                                                                        Err(v2431)
                                                                                                    }
                                                                                                }
                                                                                            } else {
                                                                                                let v2459:
                                                                                                        string =
                                                                                                    sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                                                                             v0_1.clone(),
                                                                                                             v214.clone(),
                                                                                                             v177.clone(),
                                                                                                             v215.clone());
                                                                                                let v2462:
                                                                                                        std::io::Error =
                                                                                                    std::io::Error::new(std::io::ErrorKind::Other, &*v2459);
                                                                                                Err(v2462)
                                                                                            }
                                                                                        } else {
                                                                                            let v2489:
                                                                                                    string =
                                                                                                sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                                                                         v0_1.clone(),
                                                                                                         v214,
                                                                                                         v177.clone(),
                                                                                                         v215.clone());
                                                                                            let v2492:
                                                                                                    std::io::Error =
                                                                                                std::io::Error::new(std::io::ErrorKind::Other, &*v2489);
                                                                                            Err(v2492)
                                                                                        }
                                                                    }
                                                                };
                                                                let v2521 = File_system::method79();
                                                                let v2533: Result<
                                                                    std::path::PathBuf,
                                                                    string,
                                                                > = v2520.map_err(|x| v2521(x));
                                                                let v2536: File_system::US13 =
                                                                    match &v2533 {
                                                                        Err(v2533_1_0) => {
                                                                            v25_1(v2533_1_0.clone())
                                                                        }
                                                                        Ok(v2533_0_0) => {
                                                                            v24_1(v2533_0_0.clone())
                                                                        }
                                                                    };
                                                                match &v2536 {
                                                                    File_system::US13::US13_0(
                                                                        v2536_0_0,
                                                                    ) => {
                                                                        let v2565: string =
                                                                            File_system::method59(
                                                                                toString(
                                                                                    v2536_0_0
                                                                                        .clone()
                                                                                        .display(),
                                                                                ),
                                                                                v158.clone(),
                                                                            );
                                                                        let v2568: &str = &*v2565;
                                                                        let v2592:
                                                                                            std::string::String =
                                                                                        String::from(v2568);
                                                                        let v2616:
                                                                                            std::path::PathBuf =
                                                                                        std::path::PathBuf::from(v2592);
                                                                        Ok(v2616)
                                                                    }
                                                                    File_system::US13::US13_1(
                                                                        v2536_1_0,
                                                                    ) => {
                                                                        let v2653:
                                                                                            string =
                                                                                        sprintf!("file_system.read_link / error\': {} / error: {} / name: {}",
                                                                                                 v2536_1_0.clone(),
                                                                                                 v157.clone(),
                                                                                                 v158.clone());
                                                                        let v2656:
                                                                                            std::io::Error =
                                                                                        std::io::Error::new(std::io::ErrorKind::Other, &*v2653);
                                                                        Err(v2656)
                                                                    }
                                                                }
                                                            } else {
                                                                let v2684:
                                                                                    string =
                                                                                sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                                                         v0_1.clone(),
                                                                                         v157.clone(),
                                                                                         v120.clone(),
                                                                                         v158.clone());
                                                                let v2687: std::io::Error =
                                                                    std::io::Error::new(
                                                                        std::io::ErrorKind::Other,
                                                                        &*v2684,
                                                                    );
                                                                Err(v2687)
                                                            }
                                                        } else {
                                                            let v2714:
                                                                                string =
                                                                            sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                                                     v0_1.clone(),
                                                                                     v157,
                                                                                     v120.clone(),
                                                                                     v158.clone());
                                                            let v2717: std::io::Error =
                                                                std::io::Error::new(
                                                                    std::io::ErrorKind::Other,
                                                                    &*v2714,
                                                                );
                                                            Err(v2717)
                                                        }
                                                    }
                                                };
                                                let v2746 = File_system::method79();
                                                let v2758: Result<std::path::PathBuf, string> =
                                                    v2745.map_err(|x| v2746(x));
                                                let v2761: File_system::US13 = match &v2758 {
                                                    Err(v2758_1_0) => v25_1(v2758_1_0.clone()),
                                                    Ok(v2758_0_0) => v24_1(v2758_0_0.clone()),
                                                };
                                                match &v2761 {
                                                    File_system::US13::US13_0(v2761_0_0) => {
                                                        let v2790: string = File_system::method59(
                                                            toString(v2761_0_0.clone().display()),
                                                            v101.clone(),
                                                        );
                                                        let v2793: &str = &*v2790;
                                                        let v2817: std::string::String =
                                                            String::from(v2793);
                                                        let v2841: std::path::PathBuf =
                                                            std::path::PathBuf::from(v2817);
                                                        Ok(v2841)
                                                    }
                                                    File_system::US13::US13_1(v2761_1_0) => {
                                                        let v2878:
                                                                        string =
                                                                    sprintf!("file_system.read_link / error\': {} / error: {} / name: {}",
                                                                             v2761_1_0.clone(),
                                                                             v100.clone(),
                                                                             v101.clone());
                                                        let v2881: std::io::Error =
                                                            std::io::Error::new(
                                                                std::io::ErrorKind::Other,
                                                                &*v2878,
                                                            );
                                                        Err(v2881)
                                                    }
                                                }
                                            } else {
                                                let v2909: string =
                                                            sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                                     v0_1.clone(),
                                                                     v100.clone(),
                                                                     v62.clone(),
                                                                     v101.clone());
                                                let v2912: std::io::Error = std::io::Error::new(
                                                    std::io::ErrorKind::Other,
                                                    &*v2909,
                                                );
                                                Err(v2912)
                                            }
                                        } else {
                                            let v2939: string =
                                                        sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                                 v0_1.clone(),
                                                                 v100,
                                                                 v62.clone(),
                                                                 v101.clone());
                                            let v2942: std::io::Error = std::io::Error::new(
                                                std::io::ErrorKind::Other,
                                                &*v2939,
                                            );
                                            Err(v2942)
                                        }
                                    }
                                };
                                let v2971 = File_system::method79();
                                let v2983: Result<std::path::PathBuf, string> =
                                    v2970.map_err(|x| v2971(x));
                                let v2986: File_system::US13 = match &v2983 {
                                    Err(v2983_1_0) => v25_1(v2983_1_0.clone()),
                                    Ok(v2983_0_0) => v24_1(v2983_0_0.clone()),
                                };
                                match &v2986 {
                                    File_system::US13::US13_0(v2986_0_0) => {
                                        let v3015: string = File_system::method59(
                                            toString(v2986_0_0.clone().display()),
                                            v43.clone(),
                                        );
                                        let v3018: &str = &*v3015;
                                        let v3042: std::string::String = String::from(v3018);
                                        let v3066: std::path::PathBuf =
                                            std::path::PathBuf::from(v3042);
                                        Ok(v3066)
                                    }
                                    File_system::US13::US13_1(v2986_1_0) => {
                                        let v3103: string =
                                                sprintf!("file_system.read_link / error\': {} / error: {} / name: {}",
                                                         v2986_1_0.clone(),
                                                         v42.clone(),
                                                         v43.clone());
                                        let v3106: std::io::Error =
                                            std::io::Error::new(std::io::ErrorKind::Other, &*v3103);
                                        Err(v3106)
                                    }
                                }
                            } else {
                                let v3134: string =
                                        sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                 v0_1.clone(), v42.clone(),
                                                 v0_1.clone(), v43.clone());
                                let v3137: std::io::Error =
                                    std::io::Error::new(std::io::ErrorKind::Other, &*v3134);
                                Err(v3137)
                            }
                        } else {
                            let v3164: string =
                                    sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                             v0_1.clone(), v42, v0_1.clone(),
                                             v43.clone());
                            let v3167: std::io::Error =
                                std::io::Error::new(std::io::ErrorKind::Other, &*v3164);
                            Err(v3167)
                        }
                    }
                }
            };
            let v19010: Option<std::path::PathBuf> = v3196.ok();
            let v19035: File_system::US14 = defaultValue(
                File_system::US14::US14_1,
                map(File_system::method83(), v19010),
            );
            let v19070: string = match &v19035 {
                File_system::US14::US14_0(v19035_0_0) => {
                    let v19064: string = toString(
                        match &v19035 {
                            File_system::US14::US14_0(x) => x.clone(),
                            _ => unreachable!(),
                        }
                        .display(),
                    );
                    if v19064.clone() == string("") {
                        v0_1.clone()
                    } else {
                        v19064
                    }
                }
                _ => v0_1.clone(),
            };
            if v19070.clone() == string("") {
                string("")
            } else {
                let v19075: string =
                    File_system::method84(string("^\\\\\\\\\\?\\\\"), string(""), v19070);
                replace(
                    sprintf!(
                        "{}{}",
                        toLower(ofChar(getCharAt(v19075.clone(), 0_i32))),
                        getSlice(v19075, Some(1_i32), None::<i32>)
                    ),
                    string("\\"),
                    string("/"),
                )
            }
        }
    }
    pub fn closure45(unitVar: (), v0_1: string) -> string {
        File_system::method78(v0_1)
    }
    pub fn closure50(unitVar: (), v0_1: string) -> string {
        sprintf!("file:///{}", trimStartChars(v0_1, toArray(singleton('/'))))
    }
    pub fn closure52(unitVar: (), v0_1: string) -> Option<string> {
        File_system::method81(v0_1)
    }
    pub fn method87() -> Func1<string, Option<string>> {
        Func1::new(move |v: string| File_system::closure52((), v))
    }
    pub fn method88(v0_1: string, v1_1: string, v2_1: string) -> File_system::US15 {
        let v0_1: MutCell<string> = MutCell::new(v0_1.clone());
        let v1_1: MutCell<string> = MutCell::new(v1_1.clone());
        let v2_1: MutCell<string> = MutCell::new(v2_1.clone());
        '_method88: loop {
            break '_method88 (if File_system::method9(File_system::method59(
                v2_1.get().clone(),
                v0_1.get().clone(),
            )) {
                File_system::US15::US15_0(v2_1.get().clone())
            } else {
                let v7: Option<string> = (File_system::method87())(v2_1.get().clone());
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
                        continue '_method88;
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
    pub fn method86(v0_1: string, v1_1: string) -> File_system::US15 {
        if File_system::method9(File_system::method59(v1_1.clone(), v0_1.clone())) {
            File_system::US15::US15_0(v1_1.clone())
        } else {
            let v6: Option<string> = (File_system::method87())(v1_1.clone());
            let v20_1: File_system::US1 =
                defaultValue(File_system::US1::US1_1, map(File_system::method4(), v6));
            match &v20_1 {
                File_system::US1::US1_0(v20_1_0_0) => File_system::method88(
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
    pub fn method90(v0_1: string) -> string {
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
    pub fn method89(
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
        let v9: string = File_system::method90(v8);
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
            File_system::method23(File_system::method89(
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
    pub fn method91() -> string {
        let v2_1: Result<std::path::PathBuf, std::io::Error> = std::env::current_dir();
        let v5: std::path::PathBuf = v2_1.unwrap();
        let v19_1: std::path::Display = v5.display();
        let v43: std::string::String = format!("{}", v19_1);
        fable_library_rust::String_::fromString(v43)
    }
    pub fn closure51(unitVar: (), unitVar_1: ()) -> string {
        let v4: File_system::US15 = File_system::method86(
            File_system::method59(string("polyglot"), string(".devcontainer")),
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
                let v55: string = File_system::method91();
                let v57: File_system::US15 = File_system::method86(
                    File_system::method59(string("polyglot"), string(".devcontainer")),
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
        File_system::method59(
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
    pub fn method92(v0_1: string) {
        ();
        ()
    }
    pub fn closure55(unitVar: (), v0_1: string) {
        File_system::method92(v0_1);
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
    pub fn method93(v0_1: string, v1_1: string) {
        if File_system::method9(v0_1.clone()) == false {
            let v4: LrcPtr<dyn IDisposable> = File_system::method64(v0_1.clone());
            ()
        }
        {
            let v5: string = File_system::method82(v1_1.clone());
            if File_system::method9(v5.clone()) == false {
                let v8: LrcPtr<dyn IDisposable> = File_system::method64(v5);
                ()
            }
            if if File_system::method9(v1_1.clone()) {
                let v3203: Result<std::path::PathBuf, std::io::Error> = if File_system::method9(
                    v1_1.clone(),
                ) {
                    std::fs::read_link(&*v1_1.clone())
                } else {
                    let v15: Result<std::path::PathBuf, std::io::Error> =
                        std::fs::read_link(&*v1_1.clone());
                    let v16_1 = File_system::method79();
                    let v28_1: Result<std::path::PathBuf, string> = v15.map_err(|x| v16_1(x));
                    fn v31_1(v: std::path::PathBuf) -> File_system::US13 {
                        File_system::closure47((), v)
                    }
                    fn v32_1(v_1: string) -> File_system::US13 {
                        File_system::closure48((), v_1)
                    }
                    let v33_1: File_system::US13 = match &v28_1 {
                        Err(v28_1_1_0) => v32_1(v28_1_1_0.clone()),
                        Ok(v28_1_0_0) => v31_1(v28_1_0_0.clone()),
                    };
                    match &v33_1 {
                        File_system::US13::US13_0(v33_1_0_0) => Ok(v33_1_0_0.clone()),
                        File_system::US13::US13_1(v33_1_1_0) => {
                            let v49: string = v33_1_1_0.clone();
                            let v50: string = File_system::method19(v1_1.clone());
                            let v51: Option<string> = File_system::method81(v1_1.clone());
                            let v65: File_system::US1 = defaultValue(
                                File_system::US1::US1_1,
                                map(File_system::method4(), v51),
                            );
                            if let File_system::US1::US1_0(v65_0_0) = &v65 {
                                let v69: string = match &v65 {
                                    File_system::US1::US1_0(x) => x.clone(),
                                    _ => unreachable!(),
                                };
                                if v1_1.clone() != string("") {
                                    let v75: Result<std::path::PathBuf, std::io::Error> =
                                        std::fs::read_link(&*v69.clone());
                                    let v76 = File_system::method79();
                                    let v88: Result<std::path::PathBuf, string> =
                                        v75.map_err(|x| v76(x));
                                    let v91: File_system::US13 = match &v88 {
                                        Err(v88_1_0) => v32_1(v88_1_0.clone()),
                                        Ok(v88_0_0) => v31_1(v88_0_0.clone()),
                                    };
                                    let v2977: Result<std::path::PathBuf, std::io::Error> =
                                        match &v91 {
                                            File_system::US13::US13_0(v91_0_0) => {
                                                Ok(v91_0_0.clone())
                                            }
                                            File_system::US13::US13_1(v91_1_0) => {
                                                let v107: string = v91_1_0.clone();
                                                let v108: string =
                                                    File_system::method19(v69.clone());
                                                let v109: Option<string> =
                                                    File_system::method81(v69.clone());
                                                let v123: File_system::US1 = defaultValue(
                                                    File_system::US1::US1_1,
                                                    map(File_system::method4(), v109),
                                                );
                                                if let File_system::US1::US1_0(v123_0_0) = &v123 {
                                                    let v127: string = match &v123 {
                                                        File_system::US1::US1_0(x) => x.clone(),
                                                        _ => unreachable!(),
                                                    };
                                                    if v69.clone() != string("") {
                                                        let v132: Result<
                                                            std::path::PathBuf,
                                                            std::io::Error,
                                                        > = std::fs::read_link(&*v127.clone());
                                                        let v133 = File_system::method79();
                                                        let v145: Result<
                                                            std::path::PathBuf,
                                                            string,
                                                        > = v132.map_err(|x| v133(x));
                                                        let v148: File_system::US13 = match &v145 {
                                                            Err(v145_1_0) => {
                                                                v32_1(v145_1_0.clone())
                                                            }
                                                            Ok(v145_0_0) => v31_1(v145_0_0.clone()),
                                                        };
                                                        let v2752: Result<
                                                            std::path::PathBuf,
                                                            std::io::Error,
                                                        > = match &v148 {
                                                            File_system::US13::US13_0(v148_0_0) => {
                                                                Ok(v148_0_0.clone())
                                                            }
                                                            File_system::US13::US13_1(v148_1_0) => {
                                                                let v164: string = v148_1_0.clone();
                                                                let v165: string =
                                                                    File_system::method19(
                                                                        v127.clone(),
                                                                    );
                                                                let v166: Option<string> =
                                                                    File_system::method81(
                                                                        v127.clone(),
                                                                    );
                                                                let v180: File_system::US1 =
                                                                    defaultValue(
                                                                        File_system::US1::US1_1,
                                                                        map(
                                                                            File_system::method4(),
                                                                            v166,
                                                                        ),
                                                                    );
                                                                if let File_system::US1::US1_0(
                                                                    v180_0_0,
                                                                ) = &v180
                                                                {
                                                                    let v184: string = match &v180 {
                                                                        File_system::US1::US1_0(
                                                                            x,
                                                                        ) => x.clone(),
                                                                        _ => unreachable!(),
                                                                    };
                                                                    if v127.clone() != string("") {
                                                                        let v189: Result<
                                                                            std::path::PathBuf,
                                                                            std::io::Error,
                                                                        > = std::fs::read_link(
                                                                            &*v184.clone(),
                                                                        );
                                                                        let v190 =
                                                                            File_system::method79();
                                                                        let v202: Result<
                                                                            std::path::PathBuf,
                                                                            string,
                                                                        > = v189
                                                                            .map_err(|x| v190(x));
                                                                        let v205:
                                                                                           File_system::US13 =
                                                                                       match &v202
                                                                                           {
                                                                                           Err(v202_1_0)
                                                                                           =>
                                                                                           v32_1(v202_1_0.clone()),
                                                                                           Ok(v202_0_0)
                                                                                           =>
                                                                                           v31_1(v202_0_0.clone()),
                                                                                       };
                                                                        let v2527:
                                                                                           Result<std::path::PathBuf,
                                                                                                  std::io::Error> =
                                                                                       match &v205
                                                                                           {
                                                                                           File_system::US13::US13_0(v205_0_0)
                                                                                           =>
                                                                                           Ok(v205_0_0.clone()),
                                                                                           File_system::US13::US13_1(v205_1_0)
                                                                                           =>
                                                                                           {
                                                                                               let v221:
                                                                                                       string =
                                                                                                   v205_1_0.clone();
                                                                                               let v222:
                                                                                                       string =
                                                                                                   File_system::method19(v184.clone());
                                                                                               let v223:
                                                                                                       Option<string> =
                                                                                                   File_system::method81(v184.clone());
                                                                                               let v237:
                                                                                                       File_system::US1 =
                                                                                                   defaultValue(File_system::US1::US1_1,
                                                                                                                map(File_system::method4(),
                                                                                                                    v223));
                                                                                               if let File_system::US1::US1_0(v237_0_0)
                                                                                                      =
                                                                                                      &v237
                                                                                                  {
                                                                                                   let v241:
                                                                                                           string =
                                                                                                       match &v237
                                                                                                           {
                                                                                                           File_system::US1::US1_0(x)
                                                                                                           =>
                                                                                                           x.clone(),
                                                                                                           _
                                                                                                           =>
                                                                                                           unreachable!(),
                                                                                                       };
                                                                                                   if v184.clone()
                                                                                                          !=
                                                                                                          string("")
                                                                                                      {
                                                                                                       let v246:
                                                                                                               Result<std::path::PathBuf,
                                                                                                                      std::io::Error> =
                                                                                                           std::fs::read_link(&*v241.clone());
                                                                                                       let v247 =
                                                                                                           File_system::method79();
                                                                                                       let v259:
                                                                                                               Result<std::path::PathBuf,
                                                                                                                      string> =
                                                                                                           v246.map_err(|x| v247(x));
                                                                                                       let v262:
                                                                                                               File_system::US13 =
                                                                                                           match &v259
                                                                                                               {
                                                                                                               Err(v259_1_0)
                                                                                                               =>
                                                                                                               v32_1(v259_1_0.clone()),
                                                                                                               Ok(v259_0_0)
                                                                                                               =>
                                                                                                               v31_1(v259_0_0.clone()),
                                                                                                           };
                                                                                                       let v2302:
                                                                                                               Result<std::path::PathBuf,
                                                                                                                      std::io::Error> =
                                                                                                           match &v262
                                                                                                               {
                                                                                                               File_system::US13::US13_0(v262_0_0)
                                                                                                               =>
                                                                                                               Ok(v262_0_0.clone()),
                                                                                                               File_system::US13::US13_1(v262_1_0)
                                                                                                               =>
                                                                                                               {
                                                                                                                   let v278:
                                                                                                                           string =
                                                                                                                       v262_1_0.clone();
                                                                                                                   let v279:
                                                                                                                           string =
                                                                                                                       File_system::method19(v241.clone());
                                                                                                                   let v280:
                                                                                                                           Option<string> =
                                                                                                                       File_system::method81(v241.clone());
                                                                                                                   let v294:
                                                                                                                           File_system::US1 =
                                                                                                                       defaultValue(File_system::US1::US1_1,
                                                                                                                                    map(File_system::method4(),
                                                                                                                                        v280));
                                                                                                                   if let File_system::US1::US1_0(v294_0_0)
                                                                                                                          =
                                                                                                                          &v294
                                                                                                                      {
                                                                                                                       let v298:
                                                                                                                               string =
                                                                                                                           match &v294
                                                                                                                               {
                                                                                                                               File_system::US1::US1_0(x)
                                                                                                                               =>
                                                                                                                               x.clone(),
                                                                                                                               _
                                                                                                                               =>
                                                                                                                               unreachable!(),
                                                                                                                           };
                                                                                                                       if v241.clone()
                                                                                                                              !=
                                                                                                                              string("")
                                                                                                                          {
                                                                                                                           let v303:
                                                                                                                                   Result<std::path::PathBuf,
                                                                                                                                          std::io::Error> =
                                                                                                                               std::fs::read_link(&*v298.clone());
                                                                                                                           let v304 =
                                                                                                                               File_system::method79();
                                                                                                                           let v316:
                                                                                                                                   Result<std::path::PathBuf,
                                                                                                                                          string> =
                                                                                                                               v303.map_err(|x| v304(x));
                                                                                                                           let v319:
                                                                                                                                   File_system::US13 =
                                                                                                                               match &v316
                                                                                                                                   {
                                                                                                                                   Err(v316_1_0)
                                                                                                                                   =>
                                                                                                                                   v32_1(v316_1_0.clone()),
                                                                                                                                   Ok(v316_0_0)
                                                                                                                                   =>
                                                                                                                                   v31_1(v316_0_0.clone()),
                                                                                                                               };
                                                                                                                           let v2077:
                                                                                                                                   Result<std::path::PathBuf,
                                                                                                                                          std::io::Error> =
                                                                                                                               match &v319
                                                                                                                                   {
                                                                                                                                   File_system::US13::US13_0(v319_0_0)
                                                                                                                                   =>
                                                                                                                                   Ok(v319_0_0.clone()),
                                                                                                                                   File_system::US13::US13_1(v319_1_0)
                                                                                                                                   =>
                                                                                                                                   {
                                                                                                                                       let v335:
                                                                                                                                               string =
                                                                                                                                           v319_1_0.clone();
                                                                                                                                       let v336:
                                                                                                                                               string =
                                                                                                                                           File_system::method19(v298.clone());
                                                                                                                                       let v337:
                                                                                                                                               Option<string> =
                                                                                                                                           File_system::method81(v298.clone());
                                                                                                                                       let v351:
                                                                                                                                               File_system::US1 =
                                                                                                                                           defaultValue(File_system::US1::US1_1,
                                                                                                                                                        map(File_system::method4(),
                                                                                                                                                            v337));
                                                                                                                                       if let File_system::US1::US1_0(v351_0_0)
                                                                                                                                              =
                                                                                                                                              &v351
                                                                                                                                          {
                                                                                                                                           let v355:
                                                                                                                                                   string =
                                                                                                                                               match &v351
                                                                                                                                                   {
                                                                                                                                                   File_system::US1::US1_0(x)
                                                                                                                                                   =>
                                                                                                                                                   x.clone(),
                                                                                                                                                   _
                                                                                                                                                   =>
                                                                                                                                                   unreachable!(),
                                                                                                                                               };
                                                                                                                                           if v298.clone()
                                                                                                                                                  !=
                                                                                                                                                  string("")
                                                                                                                                              {
                                                                                                                                               let v360:
                                                                                                                                                       Result<std::path::PathBuf,
                                                                                                                                                              std::io::Error> =
                                                                                                                                                   std::fs::read_link(&*v355.clone());
                                                                                                                                               let v361 =
                                                                                                                                                   File_system::method79();
                                                                                                                                               let v373:
                                                                                                                                                       Result<std::path::PathBuf,
                                                                                                                                                              string> =
                                                                                                                                                   v360.map_err(|x| v361(x));
                                                                                                                                               let v376:
                                                                                                                                                       File_system::US13 =
                                                                                                                                                   match &v373
                                                                                                                                                       {
                                                                                                                                                       Err(v373_1_0)
                                                                                                                                                       =>
                                                                                                                                                       v32_1(v373_1_0.clone()),
                                                                                                                                                       Ok(v373_0_0)
                                                                                                                                                       =>
                                                                                                                                                       v31_1(v373_0_0.clone()),
                                                                                                                                                   };
                                                                                                                                               let v1852:
                                                                                                                                                       Result<std::path::PathBuf,
                                                                                                                                                              std::io::Error> =
                                                                                                                                                   match &v376
                                                                                                                                                       {
                                                                                                                                                       File_system::US13::US13_0(v376_0_0)
                                                                                                                                                       =>
                                                                                                                                                       Ok(v376_0_0.clone()),
                                                                                                                                                       File_system::US13::US13_1(v376_1_0)
                                                                                                                                                       =>
                                                                                                                                                       {
                                                                                                                                                           let v392:
                                                                                                                                                                   string =
                                                                                                                                                               v376_1_0.clone();
                                                                                                                                                           let v393:
                                                                                                                                                                   string =
                                                                                                                                                               File_system::method19(v355.clone());
                                                                                                                                                           let v394:
                                                                                                                                                                   Option<string> =
                                                                                                                                                               File_system::method81(v355.clone());
                                                                                                                                                           let v408:
                                                                                                                                                                   File_system::US1 =
                                                                                                                                                               defaultValue(File_system::US1::US1_1,
                                                                                                                                                                            map(File_system::method4(),
                                                                                                                                                                                v394));
                                                                                                                                                           if let File_system::US1::US1_0(v408_0_0)
                                                                                                                                                                  =
                                                                                                                                                                  &v408
                                                                                                                                                              {
                                                                                                                                                               let v412:
                                                                                                                                                                       string =
                                                                                                                                                                   match &v408
                                                                                                                                                                       {
                                                                                                                                                                       File_system::US1::US1_0(x)
                                                                                                                                                                       =>
                                                                                                                                                                       x.clone(),
                                                                                                                                                                       _
                                                                                                                                                                       =>
                                                                                                                                                                       unreachable!(),
                                                                                                                                                                   };
                                                                                                                                                               if v355.clone()
                                                                                                                                                                      !=
                                                                                                                                                                      string("")
                                                                                                                                                                  {
                                                                                                                                                                   let v417:
                                                                                                                                                                           Result<std::path::PathBuf,
                                                                                                                                                                                  std::io::Error> =
                                                                                                                                                                       std::fs::read_link(&*v412.clone());
                                                                                                                                                                   let v418 =
                                                                                                                                                                       File_system::method79();
                                                                                                                                                                   let v430:
                                                                                                                                                                           Result<std::path::PathBuf,
                                                                                                                                                                                  string> =
                                                                                                                                                                       v417.map_err(|x| v418(x));
                                                                                                                                                                   let v433:
                                                                                                                                                                           File_system::US13 =
                                                                                                                                                                       match &v430
                                                                                                                                                                           {
                                                                                                                                                                           Err(v430_1_0)
                                                                                                                                                                           =>
                                                                                                                                                                           v32_1(v430_1_0.clone()),
                                                                                                                                                                           Ok(v430_0_0)
                                                                                                                                                                           =>
                                                                                                                                                                           v31_1(v430_0_0.clone()),
                                                                                                                                                                       };
                                                                                                                                                                   let v1627:
                                                                                                                                                                           Result<std::path::PathBuf,
                                                                                                                                                                                  std::io::Error> =
                                                                                                                                                                       match &v433
                                                                                                                                                                           {
                                                                                                                                                                           File_system::US13::US13_0(v433_0_0)
                                                                                                                                                                           =>
                                                                                                                                                                           Ok(v433_0_0.clone()),
                                                                                                                                                                           File_system::US13::US13_1(v433_1_0)
                                                                                                                                                                           =>
                                                                                                                                                                           {
                                                                                                                                                                               let v449:
                                                                                                                                                                                       string =
                                                                                                                                                                                   v433_1_0.clone();
                                                                                                                                                                               let v450:
                                                                                                                                                                                       string =
                                                                                                                                                                                   File_system::method19(v412.clone());
                                                                                                                                                                               let v451:
                                                                                                                                                                                       Option<string> =
                                                                                                                                                                                   File_system::method81(v412.clone());
                                                                                                                                                                               let v465:
                                                                                                                                                                                       File_system::US1 =
                                                                                                                                                                                   defaultValue(File_system::US1::US1_1,
                                                                                                                                                                                                map(File_system::method4(),
                                                                                                                                                                                                    v451));
                                                                                                                                                                               if let File_system::US1::US1_0(v465_0_0)
                                                                                                                                                                                      =
                                                                                                                                                                                      &v465
                                                                                                                                                                                  {
                                                                                                                                                                                   let v469:
                                                                                                                                                                                           string =
                                                                                                                                                                                       match &v465
                                                                                                                                                                                           {
                                                                                                                                                                                           File_system::US1::US1_0(x)
                                                                                                                                                                                           =>
                                                                                                                                                                                           x.clone(),
                                                                                                                                                                                           _
                                                                                                                                                                                           =>
                                                                                                                                                                                           unreachable!(),
                                                                                                                                                                                       };
                                                                                                                                                                                   if v412.clone()
                                                                                                                                                                                          !=
                                                                                                                                                                                          string("")
                                                                                                                                                                                      {
                                                                                                                                                                                       let v474:
                                                                                                                                                                                               Result<std::path::PathBuf,
                                                                                                                                                                                                      std::io::Error> =
                                                                                                                                                                                           std::fs::read_link(&*v469.clone());
                                                                                                                                                                                       let v475 =
                                                                                                                                                                                           File_system::method79();
                                                                                                                                                                                       let v487:
                                                                                                                                                                                               Result<std::path::PathBuf,
                                                                                                                                                                                                      string> =
                                                                                                                                                                                           v474.map_err(|x| v475(x));
                                                                                                                                                                                       let v490:
                                                                                                                                                                                               File_system::US13 =
                                                                                                                                                                                           match &v487
                                                                                                                                                                                               {
                                                                                                                                                                                               Err(v487_1_0)
                                                                                                                                                                                               =>
                                                                                                                                                                                               v32_1(v487_1_0.clone()),
                                                                                                                                                                                               Ok(v487_0_0)
                                                                                                                                                                                               =>
                                                                                                                                                                                               v31_1(v487_0_0.clone()),
                                                                                                                                                                                           };
                                                                                                                                                                                       let v1402:
                                                                                                                                                                                               Result<std::path::PathBuf,
                                                                                                                                                                                                      std::io::Error> =
                                                                                                                                                                                           match &v490
                                                                                                                                                                                               {
                                                                                                                                                                                               File_system::US13::US13_0(v490_0_0)
                                                                                                                                                                                               =>
                                                                                                                                                                                               Ok(v490_0_0.clone()),
                                                                                                                                                                                               File_system::US13::US13_1(v490_1_0)
                                                                                                                                                                                               =>
                                                                                                                                                                                               {
                                                                                                                                                                                                   let v506:
                                                                                                                                                                                                           string =
                                                                                                                                                                                                       v490_1_0.clone();
                                                                                                                                                                                                   let v507:
                                                                                                                                                                                                           string =
                                                                                                                                                                                                       File_system::method19(v469.clone());
                                                                                                                                                                                                   let v508:
                                                                                                                                                                                                           Option<string> =
                                                                                                                                                                                                       File_system::method81(v469.clone());
                                                                                                                                                                                                   let v522:
                                                                                                                                                                                                           File_system::US1 =
                                                                                                                                                                                                       defaultValue(File_system::US1::US1_1,
                                                                                                                                                                                                                    map(File_system::method4(),
                                                                                                                                                                                                                        v508));
                                                                                                                                                                                                   if let File_system::US1::US1_0(v522_0_0)
                                                                                                                                                                                                          =
                                                                                                                                                                                                          &v522
                                                                                                                                                                                                      {
                                                                                                                                                                                                       let v526:
                                                                                                                                                                                                               string =
                                                                                                                                                                                                           match &v522
                                                                                                                                                                                                               {
                                                                                                                                                                                                               File_system::US1::US1_0(x)
                                                                                                                                                                                                               =>
                                                                                                                                                                                                               x.clone(),
                                                                                                                                                                                                               _
                                                                                                                                                                                                               =>
                                                                                                                                                                                                               unreachable!(),
                                                                                                                                                                                                           };
                                                                                                                                                                                                       if v469.clone()
                                                                                                                                                                                                              !=
                                                                                                                                                                                                              string("")
                                                                                                                                                                                                          {
                                                                                                                                                                                                           let v531:
                                                                                                                                                                                                                   Result<std::path::PathBuf,
                                                                                                                                                                                                                          std::io::Error> =
                                                                                                                                                                                                               std::fs::read_link(&*v526.clone());
                                                                                                                                                                                                           let v532 =
                                                                                                                                                                                                               File_system::method79();
                                                                                                                                                                                                           let v544:
                                                                                                                                                                                                                   Result<std::path::PathBuf,
                                                                                                                                                                                                                          string> =
                                                                                                                                                                                                               v531.map_err(|x| v532(x));
                                                                                                                                                                                                           let v547:
                                                                                                                                                                                                                   File_system::US13 =
                                                                                                                                                                                                               match &v544
                                                                                                                                                                                                                   {
                                                                                                                                                                                                                   Err(v544_1_0)
                                                                                                                                                                                                                   =>
                                                                                                                                                                                                                   v32_1(v544_1_0.clone()),
                                                                                                                                                                                                                   Ok(v544_0_0)
                                                                                                                                                                                                                   =>
                                                                                                                                                                                                                   v31_1(v544_0_0.clone()),
                                                                                                                                                                                                               };
                                                                                                                                                                                                           let v1177:
                                                                                                                                                                                                                   Result<std::path::PathBuf,
                                                                                                                                                                                                                          std::io::Error> =
                                                                                                                                                                                                               match &v547
                                                                                                                                                                                                                   {
                                                                                                                                                                                                                   File_system::US13::US13_0(v547_0_0)
                                                                                                                                                                                                                   =>
                                                                                                                                                                                                                   Ok(v547_0_0.clone()),
                                                                                                                                                                                                                   File_system::US13::US13_1(v547_1_0)
                                                                                                                                                                                                                   =>
                                                                                                                                                                                                                   {
                                                                                                                                                                                                                       let v563:
                                                                                                                                                                                                                               string =
                                                                                                                                                                                                                           v547_1_0.clone();
                                                                                                                                                                                                                       let v564:
                                                                                                                                                                                                                               string =
                                                                                                                                                                                                                           File_system::method19(v526.clone());
                                                                                                                                                                                                                       let v565:
                                                                                                                                                                                                                               Option<string> =
                                                                                                                                                                                                                           File_system::method81(v526.clone());
                                                                                                                                                                                                                       let v579:
                                                                                                                                                                                                                               File_system::US1 =
                                                                                                                                                                                                                           defaultValue(File_system::US1::US1_1,
                                                                                                                                                                                                                                        map(File_system::method4(),
                                                                                                                                                                                                                                            v565));
                                                                                                                                                                                                                       if let File_system::US1::US1_0(v579_0_0)
                                                                                                                                                                                                                              =
                                                                                                                                                                                                                              &v579
                                                                                                                                                                                                                          {
                                                                                                                                                                                                                           let v583:
                                                                                                                                                                                                                                   string =
                                                                                                                                                                                                                               match &v579
                                                                                                                                                                                                                                   {
                                                                                                                                                                                                                                   File_system::US1::US1_0(x)
                                                                                                                                                                                                                                   =>
                                                                                                                                                                                                                                   x.clone(),
                                                                                                                                                                                                                                   _
                                                                                                                                                                                                                                   =>
                                                                                                                                                                                                                                   unreachable!(),
                                                                                                                                                                                                                               };
                                                                                                                                                                                                                           if v526.clone()
                                                                                                                                                                                                                                  !=
                                                                                                                                                                                                                                  string("")
                                                                                                                                                                                                                              {
                                                                                                                                                                                                                               let v588:
                                                                                                                                                                                                                                       Result<std::path::PathBuf,
                                                                                                                                                                                                                                              std::io::Error> =
                                                                                                                                                                                                                                   std::fs::read_link(&*v583.clone());
                                                                                                                                                                                                                               let v589 =
                                                                                                                                                                                                                                   File_system::method79();
                                                                                                                                                                                                                               let v601:
                                                                                                                                                                                                                                       Result<std::path::PathBuf,
                                                                                                                                                                                                                                              string> =
                                                                                                                                                                                                                                   v588.map_err(|x| v589(x));
                                                                                                                                                                                                                               let v604:
                                                                                                                                                                                                                                       File_system::US13 =
                                                                                                                                                                                                                                   match &v601
                                                                                                                                                                                                                                       {
                                                                                                                                                                                                                                       Err(v601_1_0)
                                                                                                                                                                                                                                       =>
                                                                                                                                                                                                                                       v32_1(v601_1_0.clone()),
                                                                                                                                                                                                                                       Ok(v601_0_0)
                                                                                                                                                                                                                                       =>
                                                                                                                                                                                                                                       v31_1(v601_0_0.clone()),
                                                                                                                                                                                                                                   };
                                                                                                                                                                                                                               let v952:
                                                                                                                                                                                                                                       Result<std::path::PathBuf,
                                                                                                                                                                                                                                              std::io::Error> =
                                                                                                                                                                                                                                   match &v604
                                                                                                                                                                                                                                       {
                                                                                                                                                                                                                                       File_system::US13::US13_0(v604_0_0)
                                                                                                                                                                                                                                       =>
                                                                                                                                                                                                                                       Ok(v604_0_0.clone()),
                                                                                                                                                                                                                                       File_system::US13::US13_1(v604_1_0)
                                                                                                                                                                                                                                       =>
                                                                                                                                                                                                                                       {
                                                                                                                                                                                                                                           let v620:
                                                                                                                                                                                                                                                   string =
                                                                                                                                                                                                                                               v604_1_0.clone();
                                                                                                                                                                                                                                           let v621:
                                                                                                                                                                                                                                                   string =
                                                                                                                                                                                                                                               File_system::method19(v583.clone());
                                                                                                                                                                                                                                           let v622:
                                                                                                                                                                                                                                                   Option<string> =
                                                                                                                                                                                                                                               File_system::method81(v583.clone());
                                                                                                                                                                                                                                           let v636:
                                                                                                                                                                                                                                                   File_system::US1 =
                                                                                                                                                                                                                                               defaultValue(File_system::US1::US1_1,
                                                                                                                                                                                                                                                            map(File_system::method4(),
                                                                                                                                                                                                                                                                v622));
                                                                                                                                                                                                                                           if let File_system::US1::US1_0(v636_0_0)
                                                                                                                                                                                                                                                  =
                                                                                                                                                                                                                                                  &v636
                                                                                                                                                                                                                                              {
                                                                                                                                                                                                                                               let v640:
                                                                                                                                                                                                                                                       string =
                                                                                                                                                                                                                                                   match &v636
                                                                                                                                                                                                                                                       {
                                                                                                                                                                                                                                                       File_system::US1::US1_0(x)
                                                                                                                                                                                                                                                       =>
                                                                                                                                                                                                                                                       x.clone(),
                                                                                                                                                                                                                                                       _
                                                                                                                                                                                                                                                       =>
                                                                                                                                                                                                                                                       unreachable!(),
                                                                                                                                                                                                                                                   };
                                                                                                                                                                                                                                               if v583.clone()
                                                                                                                                                                                                                                                      !=
                                                                                                                                                                                                                                                      string("")
                                                                                                                                                                                                                                                  {
                                                                                                                                                                                                                                                   let v645:
                                                                                                                                                                                                                                                           Result<std::path::PathBuf,
                                                                                                                                                                                                                                                                  std::io::Error> =
                                                                                                                                                                                                                                                       std::fs::read_link(&*v640.clone());
                                                                                                                                                                                                                                                   let v646 =
                                                                                                                                                                                                                                                       File_system::method79();
                                                                                                                                                                                                                                                   let v658:
                                                                                                                                                                                                                                                           Result<std::path::PathBuf,
                                                                                                                                                                                                                                                                  string> =
                                                                                                                                                                                                                                                       v645.map_err(|x| v646(x));
                                                                                                                                                                                                                                                   let v661:
                                                                                                                                                                                                                                                           File_system::US13 =
                                                                                                                                                                                                                                                       match &v658
                                                                                                                                                                                                                                                           {
                                                                                                                                                                                                                                                           Err(v658_1_0)
                                                                                                                                                                                                                                                           =>
                                                                                                                                                                                                                                                           v32_1(v658_1_0.clone()),
                                                                                                                                                                                                                                                           Ok(v658_0_0)
                                                                                                                                                                                                                                                           =>
                                                                                                                                                                                                                                                           v31_1(v658_0_0.clone()),
                                                                                                                                                                                                                                                       };
                                                                                                                                                                                                                                                   let v727:
                                                                                                                                                                                                                                                           Result<std::path::PathBuf,
                                                                                                                                                                                                                                                                  std::io::Error> =
                                                                                                                                                                                                                                                       match &v661
                                                                                                                                                                                                                                                           {
                                                                                                                                                                                                                                                           File_system::US13::US13_0(v661_0_0)
                                                                                                                                                                                                                                                           =>
                                                                                                                                                                                                                                                           Ok(v661_0_0.clone()),
                                                                                                                                                                                                                                                           _
                                                                                                                                                                                                                                                           =>
                                                                                                                                                                                                                                                           {
                                                                                                                                                                                                                                                               let v678:
                                                                                                                                                                                                                                                                       string =
                                                                                                                                                                                                                                                                   File_system::method19(v640.clone());
                                                                                                                                                                                                                                                               let v679:
                                                                                                                                                                                                                                                                       Option<string> =
                                                                                                                                                                                                                                                                   File_system::method81(v640.clone());
                                                                                                                                                                                                                                                               let v693:
                                                                                                                                                                                                                                                                       File_system::US1 =
                                                                                                                                                                                                                                                                   defaultValue(File_system::US1::US1_1,
                                                                                                                                                                                                                                                                                map(File_system::method4(),
                                                                                                                                                                                                                                                                                    v679));
                                                                                                                                                                                                                                                               let v697:
                                                                                                                                                                                                                                                                       string =
                                                                                                                                                                                                                                                                   sprintf!("file_system.read_link / path: {} / n: {} / path\': {} / name: {}",
                                                                                                                                                                                                                                                                            v1_1.clone(),
                                                                                                                                                                                                                                                                            11_u8,
                                                                                                                                                                                                                                                                            v640.clone(),
                                                                                                                                                                                                                                                                            v678);
                                                                                                                                                                                                                                                               let v700:
                                                                                                                                                                                                                                                                       std::io::Error =
                                                                                                                                                                                                                                                                   std::io::Error::new(std::io::ErrorKind::Other, &*v697);
                                                                                                                                                                                                                                                               Err(v700)
                                                                                                                                                                                                                                                           }
                                                                                                                                                                                                                                                       };
                                                                                                                                                                                                                                                   let v728 =
                                                                                                                                                                                                                                                       File_system::method79();
                                                                                                                                                                                                                                                   let v740:
                                                                                                                                                                                                                                                           Result<std::path::PathBuf,
                                                                                                                                                                                                                                                                  string> =
                                                                                                                                                                                                                                                       v727.map_err(|x| v728(x));
                                                                                                                                                                                                                                                   let v743:
                                                                                                                                                                                                                                                           File_system::US13 =
                                                                                                                                                                                                                                                       match &v740
                                                                                                                                                                                                                                                           {
                                                                                                                                                                                                                                                           Err(v740_1_0)
                                                                                                                                                                                                                                                           =>
                                                                                                                                                                                                                                                           v32_1(v740_1_0.clone()),
                                                                                                                                                                                                                                                           Ok(v740_0_0)
                                                                                                                                                                                                                                                           =>
                                                                                                                                                                                                                                                           v31_1(v740_0_0.clone()),
                                                                                                                                                                                                                                                       };
                                                                                                                                                                                                                                                   match &v743
                                                                                                                                                                                                                                                       {
                                                                                                                                                                                                                                                       File_system::US13::US13_0(v743_0_0)
                                                                                                                                                                                                                                                       =>
                                                                                                                                                                                                                                                       {
                                                                                                                                                                                                                                                           let v772:
                                                                                                                                                                                                                                                                   string =
                                                                                                                                                                                                                                                               File_system::method59(toString(v743_0_0.clone().display()),
                                                                                                                                                                                                                                                                                     v621.clone());
                                                                                                                                                                                                                                                           let v775:
                                                                                                                                                                                                                                                                   &str =
                                                                                                                                                                                                                                                               &*v772;
                                                                                                                                                                                                                                                           let v799:
                                                                                                                                                                                                                                                                   std::string::String =
                                                                                                                                                                                                                                                               String::from(v775);
                                                                                                                                                                                                                                                           let v823:
                                                                                                                                                                                                                                                                   std::path::PathBuf =
                                                                                                                                                                                                                                                               std::path::PathBuf::from(v799);
                                                                                                                                                                                                                                                           Ok(v823)
                                                                                                                                                                                                                                                       }
                                                                                                                                                                                                                                                       File_system::US13::US13_1(v743_1_0)
                                                                                                                                                                                                                                                       =>
                                                                                                                                                                                                                                                       {
                                                                                                                                                                                                                                                           let v860:
                                                                                                                                                                                                                                                                   string =
                                                                                                                                                                                                                                                               sprintf!("file_system.read_link / error\': {} / error: {} / name: {}",
                                                                                                                                                                                                                                                                        v743_1_0.clone(),
                                                                                                                                                                                                                                                                        v620.clone(),
                                                                                                                                                                                                                                                                        v621.clone());
                                                                                                                                                                                                                                                           let v863:
                                                                                                                                                                                                                                                                   std::io::Error =
                                                                                                                                                                                                                                                               std::io::Error::new(std::io::ErrorKind::Other, &*v860);
                                                                                                                                                                                                                                                           Err(v863)
                                                                                                                                                                                                                                                       }
                                                                                                                                                                                                                                                   }
                                                                                                                                                                                                                                               } else {
                                                                                                                                                                                                                                                   let v891:
                                                                                                                                                                                                                                                           string =
                                                                                                                                                                                                                                                       sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                                                                                                                                                                                                                                v1_1.clone(),
                                                                                                                                                                                                                                                                v620.clone(),
                                                                                                                                                                                                                                                                v583.clone(),
                                                                                                                                                                                                                                                                v621.clone());
                                                                                                                                                                                                                                                   let v894:
                                                                                                                                                                                                                                                           std::io::Error =
                                                                                                                                                                                                                                                       std::io::Error::new(std::io::ErrorKind::Other, &*v891);
                                                                                                                                                                                                                                                   Err(v894)
                                                                                                                                                                                                                                               }
                                                                                                                                                                                                                                           } else {
                                                                                                                                                                                                                                               let v921:
                                                                                                                                                                                                                                                       string =
                                                                                                                                                                                                                                                   sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                                                                                                                                                                                                                            v1_1.clone(),
                                                                                                                                                                                                                                                            v620,
                                                                                                                                                                                                                                                            v583.clone(),
                                                                                                                                                                                                                                                            v621.clone());
                                                                                                                                                                                                                                               let v924:
                                                                                                                                                                                                                                                       std::io::Error =
                                                                                                                                                                                                                                                   std::io::Error::new(std::io::ErrorKind::Other, &*v921);
                                                                                                                                                                                                                                               Err(v924)
                                                                                                                                                                                                                                           }
                                                                                                                                                                                                                                       }
                                                                                                                                                                                                                                   };
                                                                                                                                                                                                                               let v953 =
                                                                                                                                                                                                                                   File_system::method79();
                                                                                                                                                                                                                               let v965:
                                                                                                                                                                                                                                       Result<std::path::PathBuf,
                                                                                                                                                                                                                                              string> =
                                                                                                                                                                                                                                   v952.map_err(|x| v953(x));
                                                                                                                                                                                                                               let v968:
                                                                                                                                                                                                                                       File_system::US13 =
                                                                                                                                                                                                                                   match &v965
                                                                                                                                                                                                                                       {
                                                                                                                                                                                                                                       Err(v965_1_0)
                                                                                                                                                                                                                                       =>
                                                                                                                                                                                                                                       v32_1(v965_1_0.clone()),
                                                                                                                                                                                                                                       Ok(v965_0_0)
                                                                                                                                                                                                                                       =>
                                                                                                                                                                                                                                       v31_1(v965_0_0.clone()),
                                                                                                                                                                                                                                   };
                                                                                                                                                                                                                               match &v968
                                                                                                                                                                                                                                   {
                                                                                                                                                                                                                                   File_system::US13::US13_0(v968_0_0)
                                                                                                                                                                                                                                   =>
                                                                                                                                                                                                                                   {
                                                                                                                                                                                                                                       let v997:
                                                                                                                                                                                                                                               string =
                                                                                                                                                                                                                                           File_system::method59(toString(v968_0_0.clone().display()),
                                                                                                                                                                                                                                                                 v564.clone());
                                                                                                                                                                                                                                       let v1000:
                                                                                                                                                                                                                                               &str =
                                                                                                                                                                                                                                           &*v997;
                                                                                                                                                                                                                                       let v1024:
                                                                                                                                                                                                                                               std::string::String =
                                                                                                                                                                                                                                           String::from(v1000);
                                                                                                                                                                                                                                       let v1048:
                                                                                                                                                                                                                                               std::path::PathBuf =
                                                                                                                                                                                                                                           std::path::PathBuf::from(v1024);
                                                                                                                                                                                                                                       Ok(v1048)
                                                                                                                                                                                                                                   }
                                                                                                                                                                                                                                   File_system::US13::US13_1(v968_1_0)
                                                                                                                                                                                                                                   =>
                                                                                                                                                                                                                                   {
                                                                                                                                                                                                                                       let v1085:
                                                                                                                                                                                                                                               string =
                                                                                                                                                                                                                                           sprintf!("file_system.read_link / error\': {} / error: {} / name: {}",
                                                                                                                                                                                                                                                    v968_1_0.clone(),
                                                                                                                                                                                                                                                    v563.clone(),
                                                                                                                                                                                                                                                    v564.clone());
                                                                                                                                                                                                                                       let v1088:
                                                                                                                                                                                                                                               std::io::Error =
                                                                                                                                                                                                                                           std::io::Error::new(std::io::ErrorKind::Other, &*v1085);
                                                                                                                                                                                                                                       Err(v1088)
                                                                                                                                                                                                                                   }
                                                                                                                                                                                                                               }
                                                                                                                                                                                                                           } else {
                                                                                                                                                                                                                               let v1116:
                                                                                                                                                                                                                                       string =
                                                                                                                                                                                                                                   sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                                                                                                                                                                                                            v1_1.clone(),
                                                                                                                                                                                                                                            v563.clone(),
                                                                                                                                                                                                                                            v526.clone(),
                                                                                                                                                                                                                                            v564.clone());
                                                                                                                                                                                                                               let v1119:
                                                                                                                                                                                                                                       std::io::Error =
                                                                                                                                                                                                                                   std::io::Error::new(std::io::ErrorKind::Other, &*v1116);
                                                                                                                                                                                                                               Err(v1119)
                                                                                                                                                                                                                           }
                                                                                                                                                                                                                       } else {
                                                                                                                                                                                                                           let v1146:
                                                                                                                                                                                                                                   string =
                                                                                                                                                                                                                               sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                                                                                                                                                                                                        v1_1.clone(),
                                                                                                                                                                                                                                        v563,
                                                                                                                                                                                                                                        v526.clone(),
                                                                                                                                                                                                                                        v564.clone());
                                                                                                                                                                                                                           let v1149:
                                                                                                                                                                                                                                   std::io::Error =
                                                                                                                                                                                                                               std::io::Error::new(std::io::ErrorKind::Other, &*v1146);
                                                                                                                                                                                                                           Err(v1149)
                                                                                                                                                                                                                       }
                                                                                                                                                                                                                   }
                                                                                                                                                                                                               };
                                                                                                                                                                                                           let v1178 =
                                                                                                                                                                                                               File_system::method79();
                                                                                                                                                                                                           let v1190:
                                                                                                                                                                                                                   Result<std::path::PathBuf,
                                                                                                                                                                                                                          string> =
                                                                                                                                                                                                               v1177.map_err(|x| v1178(x));
                                                                                                                                                                                                           let v1193:
                                                                                                                                                                                                                   File_system::US13 =
                                                                                                                                                                                                               match &v1190
                                                                                                                                                                                                                   {
                                                                                                                                                                                                                   Err(v1190_1_0)
                                                                                                                                                                                                                   =>
                                                                                                                                                                                                                   v32_1(v1190_1_0.clone()),
                                                                                                                                                                                                                   Ok(v1190_0_0)
                                                                                                                                                                                                                   =>
                                                                                                                                                                                                                   v31_1(v1190_0_0.clone()),
                                                                                                                                                                                                               };
                                                                                                                                                                                                           match &v1193
                                                                                                                                                                                                               {
                                                                                                                                                                                                               File_system::US13::US13_0(v1193_0_0)
                                                                                                                                                                                                               =>
                                                                                                                                                                                                               {
                                                                                                                                                                                                                   let v1222:
                                                                                                                                                                                                                           string =
                                                                                                                                                                                                                       File_system::method59(toString(v1193_0_0.clone().display()),
                                                                                                                                                                                                                                             v507.clone());
                                                                                                                                                                                                                   let v1225:
                                                                                                                                                                                                                           &str =
                                                                                                                                                                                                                       &*v1222;
                                                                                                                                                                                                                   let v1249:
                                                                                                                                                                                                                           std::string::String =
                                                                                                                                                                                                                       String::from(v1225);
                                                                                                                                                                                                                   let v1273:
                                                                                                                                                                                                                           std::path::PathBuf =
                                                                                                                                                                                                                       std::path::PathBuf::from(v1249);
                                                                                                                                                                                                                   Ok(v1273)
                                                                                                                                                                                                               }
                                                                                                                                                                                                               File_system::US13::US13_1(v1193_1_0)
                                                                                                                                                                                                               =>
                                                                                                                                                                                                               {
                                                                                                                                                                                                                   let v1310:
                                                                                                                                                                                                                           string =
                                                                                                                                                                                                                       sprintf!("file_system.read_link / error\': {} / error: {} / name: {}",
                                                                                                                                                                                                                                v1193_1_0.clone(),
                                                                                                                                                                                                                                v506.clone(),
                                                                                                                                                                                                                                v507.clone());
                                                                                                                                                                                                                   let v1313:
                                                                                                                                                                                                                           std::io::Error =
                                                                                                                                                                                                                       std::io::Error::new(std::io::ErrorKind::Other, &*v1310);
                                                                                                                                                                                                                   Err(v1313)
                                                                                                                                                                                                               }
                                                                                                                                                                                                           }
                                                                                                                                                                                                       } else {
                                                                                                                                                                                                           let v1341:
                                                                                                                                                                                                                   string =
                                                                                                                                                                                                               sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                                                                                                                                                                                        v1_1.clone(),
                                                                                                                                                                                                                        v506.clone(),
                                                                                                                                                                                                                        v469.clone(),
                                                                                                                                                                                                                        v507.clone());
                                                                                                                                                                                                           let v1344:
                                                                                                                                                                                                                   std::io::Error =
                                                                                                                                                                                                               std::io::Error::new(std::io::ErrorKind::Other, &*v1341);
                                                                                                                                                                                                           Err(v1344)
                                                                                                                                                                                                       }
                                                                                                                                                                                                   } else {
                                                                                                                                                                                                       let v1371:
                                                                                                                                                                                                               string =
                                                                                                                                                                                                           sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                                                                                                                                                                                    v1_1.clone(),
                                                                                                                                                                                                                    v506,
                                                                                                                                                                                                                    v469.clone(),
                                                                                                                                                                                                                    v507.clone());
                                                                                                                                                                                                       let v1374:
                                                                                                                                                                                                               std::io::Error =
                                                                                                                                                                                                           std::io::Error::new(std::io::ErrorKind::Other, &*v1371);
                                                                                                                                                                                                       Err(v1374)
                                                                                                                                                                                                   }
                                                                                                                                                                                               }
                                                                                                                                                                                           };
                                                                                                                                                                                       let v1403 =
                                                                                                                                                                                           File_system::method79();
                                                                                                                                                                                       let v1415:
                                                                                                                                                                                               Result<std::path::PathBuf,
                                                                                                                                                                                                      string> =
                                                                                                                                                                                           v1402.map_err(|x| v1403(x));
                                                                                                                                                                                       let v1418:
                                                                                                                                                                                               File_system::US13 =
                                                                                                                                                                                           match &v1415
                                                                                                                                                                                               {
                                                                                                                                                                                               Err(v1415_1_0)
                                                                                                                                                                                               =>
                                                                                                                                                                                               v32_1(v1415_1_0.clone()),
                                                                                                                                                                                               Ok(v1415_0_0)
                                                                                                                                                                                               =>
                                                                                                                                                                                               v31_1(v1415_0_0.clone()),
                                                                                                                                                                                           };
                                                                                                                                                                                       match &v1418
                                                                                                                                                                                           {
                                                                                                                                                                                           File_system::US13::US13_0(v1418_0_0)
                                                                                                                                                                                           =>
                                                                                                                                                                                           {
                                                                                                                                                                                               let v1447:
                                                                                                                                                                                                       string =
                                                                                                                                                                                                   File_system::method59(toString(v1418_0_0.clone().display()),
                                                                                                                                                                                                                         v450.clone());
                                                                                                                                                                                               let v1450:
                                                                                                                                                                                                       &str =
                                                                                                                                                                                                   &*v1447;
                                                                                                                                                                                               let v1474:
                                                                                                                                                                                                       std::string::String =
                                                                                                                                                                                                   String::from(v1450);
                                                                                                                                                                                               let v1498:
                                                                                                                                                                                                       std::path::PathBuf =
                                                                                                                                                                                                   std::path::PathBuf::from(v1474);
                                                                                                                                                                                               Ok(v1498)
                                                                                                                                                                                           }
                                                                                                                                                                                           File_system::US13::US13_1(v1418_1_0)
                                                                                                                                                                                           =>
                                                                                                                                                                                           {
                                                                                                                                                                                               let v1535:
                                                                                                                                                                                                       string =
                                                                                                                                                                                                   sprintf!("file_system.read_link / error\': {} / error: {} / name: {}",
                                                                                                                                                                                                            v1418_1_0.clone(),
                                                                                                                                                                                                            v449.clone(),
                                                                                                                                                                                                            v450.clone());
                                                                                                                                                                                               let v1538:
                                                                                                                                                                                                       std::io::Error =
                                                                                                                                                                                                   std::io::Error::new(std::io::ErrorKind::Other, &*v1535);
                                                                                                                                                                                               Err(v1538)
                                                                                                                                                                                           }
                                                                                                                                                                                       }
                                                                                                                                                                                   } else {
                                                                                                                                                                                       let v1566:
                                                                                                                                                                                               string =
                                                                                                                                                                                           sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                                                                                                                                                                    v1_1.clone(),
                                                                                                                                                                                                    v449.clone(),
                                                                                                                                                                                                    v412.clone(),
                                                                                                                                                                                                    v450.clone());
                                                                                                                                                                                       let v1569:
                                                                                                                                                                                               std::io::Error =
                                                                                                                                                                                           std::io::Error::new(std::io::ErrorKind::Other, &*v1566);
                                                                                                                                                                                       Err(v1569)
                                                                                                                                                                                   }
                                                                                                                                                                               } else {
                                                                                                                                                                                   let v1596:
                                                                                                                                                                                           string =
                                                                                                                                                                                       sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                                                                                                                                                                v1_1.clone(),
                                                                                                                                                                                                v449,
                                                                                                                                                                                                v412.clone(),
                                                                                                                                                                                                v450.clone());
                                                                                                                                                                                   let v1599:
                                                                                                                                                                                           std::io::Error =
                                                                                                                                                                                       std::io::Error::new(std::io::ErrorKind::Other, &*v1596);
                                                                                                                                                                                   Err(v1599)
                                                                                                                                                                               }
                                                                                                                                                                           }
                                                                                                                                                                       };
                                                                                                                                                                   let v1628 =
                                                                                                                                                                       File_system::method79();
                                                                                                                                                                   let v1640:
                                                                                                                                                                           Result<std::path::PathBuf,
                                                                                                                                                                                  string> =
                                                                                                                                                                       v1627.map_err(|x| v1628(x));
                                                                                                                                                                   let v1643:
                                                                                                                                                                           File_system::US13 =
                                                                                                                                                                       match &v1640
                                                                                                                                                                           {
                                                                                                                                                                           Err(v1640_1_0)
                                                                                                                                                                           =>
                                                                                                                                                                           v32_1(v1640_1_0.clone()),
                                                                                                                                                                           Ok(v1640_0_0)
                                                                                                                                                                           =>
                                                                                                                                                                           v31_1(v1640_0_0.clone()),
                                                                                                                                                                       };
                                                                                                                                                                   match &v1643
                                                                                                                                                                       {
                                                                                                                                                                       File_system::US13::US13_0(v1643_0_0)
                                                                                                                                                                       =>
                                                                                                                                                                       {
                                                                                                                                                                           let v1672:
                                                                                                                                                                                   string =
                                                                                                                                                                               File_system::method59(toString(v1643_0_0.clone().display()),
                                                                                                                                                                                                     v393.clone());
                                                                                                                                                                           let v1675:
                                                                                                                                                                                   &str =
                                                                                                                                                                               &*v1672;
                                                                                                                                                                           let v1699:
                                                                                                                                                                                   std::string::String =
                                                                                                                                                                               String::from(v1675);
                                                                                                                                                                           let v1723:
                                                                                                                                                                                   std::path::PathBuf =
                                                                                                                                                                               std::path::PathBuf::from(v1699);
                                                                                                                                                                           Ok(v1723)
                                                                                                                                                                       }
                                                                                                                                                                       File_system::US13::US13_1(v1643_1_0)
                                                                                                                                                                       =>
                                                                                                                                                                       {
                                                                                                                                                                           let v1760:
                                                                                                                                                                                   string =
                                                                                                                                                                               sprintf!("file_system.read_link / error\': {} / error: {} / name: {}",
                                                                                                                                                                                        v1643_1_0.clone(),
                                                                                                                                                                                        v392.clone(),
                                                                                                                                                                                        v393.clone());
                                                                                                                                                                           let v1763:
                                                                                                                                                                                   std::io::Error =
                                                                                                                                                                               std::io::Error::new(std::io::ErrorKind::Other, &*v1760);
                                                                                                                                                                           Err(v1763)
                                                                                                                                                                       }
                                                                                                                                                                   }
                                                                                                                                                               } else {
                                                                                                                                                                   let v1791:
                                                                                                                                                                           string =
                                                                                                                                                                       sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                                                                                                                                                v1_1.clone(),
                                                                                                                                                                                v392.clone(),
                                                                                                                                                                                v355.clone(),
                                                                                                                                                                                v393.clone());
                                                                                                                                                                   let v1794:
                                                                                                                                                                           std::io::Error =
                                                                                                                                                                       std::io::Error::new(std::io::ErrorKind::Other, &*v1791);
                                                                                                                                                                   Err(v1794)
                                                                                                                                                               }
                                                                                                                                                           } else {
                                                                                                                                                               let v1821:
                                                                                                                                                                       string =
                                                                                                                                                                   sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                                                                                                                                            v1_1.clone(),
                                                                                                                                                                            v392,
                                                                                                                                                                            v355.clone(),
                                                                                                                                                                            v393.clone());
                                                                                                                                                               let v1824:
                                                                                                                                                                       std::io::Error =
                                                                                                                                                                   std::io::Error::new(std::io::ErrorKind::Other, &*v1821);
                                                                                                                                                               Err(v1824)
                                                                                                                                                           }
                                                                                                                                                       }
                                                                                                                                                   };
                                                                                                                                               let v1853 =
                                                                                                                                                   File_system::method79();
                                                                                                                                               let v1865:
                                                                                                                                                       Result<std::path::PathBuf,
                                                                                                                                                              string> =
                                                                                                                                                   v1852.map_err(|x| v1853(x));
                                                                                                                                               let v1868:
                                                                                                                                                       File_system::US13 =
                                                                                                                                                   match &v1865
                                                                                                                                                       {
                                                                                                                                                       Err(v1865_1_0)
                                                                                                                                                       =>
                                                                                                                                                       v32_1(v1865_1_0.clone()),
                                                                                                                                                       Ok(v1865_0_0)
                                                                                                                                                       =>
                                                                                                                                                       v31_1(v1865_0_0.clone()),
                                                                                                                                                   };
                                                                                                                                               match &v1868
                                                                                                                                                   {
                                                                                                                                                   File_system::US13::US13_0(v1868_0_0)
                                                                                                                                                   =>
                                                                                                                                                   {
                                                                                                                                                       let v1897:
                                                                                                                                                               string =
                                                                                                                                                           File_system::method59(toString(v1868_0_0.clone().display()),
                                                                                                                                                                                 v336.clone());
                                                                                                                                                       let v1900:
                                                                                                                                                               &str =
                                                                                                                                                           &*v1897;
                                                                                                                                                       let v1924:
                                                                                                                                                               std::string::String =
                                                                                                                                                           String::from(v1900);
                                                                                                                                                       let v1948:
                                                                                                                                                               std::path::PathBuf =
                                                                                                                                                           std::path::PathBuf::from(v1924);
                                                                                                                                                       Ok(v1948)
                                                                                                                                                   }
                                                                                                                                                   File_system::US13::US13_1(v1868_1_0)
                                                                                                                                                   =>
                                                                                                                                                   {
                                                                                                                                                       let v1985:
                                                                                                                                                               string =
                                                                                                                                                           sprintf!("file_system.read_link / error\': {} / error: {} / name: {}",
                                                                                                                                                                    v1868_1_0.clone(),
                                                                                                                                                                    v335.clone(),
                                                                                                                                                                    v336.clone());
                                                                                                                                                       let v1988:
                                                                                                                                                               std::io::Error =
                                                                                                                                                           std::io::Error::new(std::io::ErrorKind::Other, &*v1985);
                                                                                                                                                       Err(v1988)
                                                                                                                                                   }
                                                                                                                                               }
                                                                                                                                           } else {
                                                                                                                                               let v2016:
                                                                                                                                                       string =
                                                                                                                                                   sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                                                                                                                            v1_1.clone(),
                                                                                                                                                            v335.clone(),
                                                                                                                                                            v298.clone(),
                                                                                                                                                            v336.clone());
                                                                                                                                               let v2019:
                                                                                                                                                       std::io::Error =
                                                                                                                                                   std::io::Error::new(std::io::ErrorKind::Other, &*v2016);
                                                                                                                                               Err(v2019)
                                                                                                                                           }
                                                                                                                                       } else {
                                                                                                                                           let v2046:
                                                                                                                                                   string =
                                                                                                                                               sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                                                                                                                        v1_1.clone(),
                                                                                                                                                        v335,
                                                                                                                                                        v298.clone(),
                                                                                                                                                        v336.clone());
                                                                                                                                           let v2049:
                                                                                                                                                   std::io::Error =
                                                                                                                                               std::io::Error::new(std::io::ErrorKind::Other, &*v2046);
                                                                                                                                           Err(v2049)
                                                                                                                                       }
                                                                                                                                   }
                                                                                                                               };
                                                                                                                           let v2078 =
                                                                                                                               File_system::method79();
                                                                                                                           let v2090:
                                                                                                                                   Result<std::path::PathBuf,
                                                                                                                                          string> =
                                                                                                                               v2077.map_err(|x| v2078(x));
                                                                                                                           let v2093:
                                                                                                                                   File_system::US13 =
                                                                                                                               match &v2090
                                                                                                                                   {
                                                                                                                                   Err(v2090_1_0)
                                                                                                                                   =>
                                                                                                                                   v32_1(v2090_1_0.clone()),
                                                                                                                                   Ok(v2090_0_0)
                                                                                                                                   =>
                                                                                                                                   v31_1(v2090_0_0.clone()),
                                                                                                                               };
                                                                                                                           match &v2093
                                                                                                                               {
                                                                                                                               File_system::US13::US13_0(v2093_0_0)
                                                                                                                               =>
                                                                                                                               {
                                                                                                                                   let v2122:
                                                                                                                                           string =
                                                                                                                                       File_system::method59(toString(v2093_0_0.clone().display()),
                                                                                                                                                             v279.clone());
                                                                                                                                   let v2125:
                                                                                                                                           &str =
                                                                                                                                       &*v2122;
                                                                                                                                   let v2149:
                                                                                                                                           std::string::String =
                                                                                                                                       String::from(v2125);
                                                                                                                                   let v2173:
                                                                                                                                           std::path::PathBuf =
                                                                                                                                       std::path::PathBuf::from(v2149);
                                                                                                                                   Ok(v2173)
                                                                                                                               }
                                                                                                                               File_system::US13::US13_1(v2093_1_0)
                                                                                                                               =>
                                                                                                                               {
                                                                                                                                   let v2210:
                                                                                                                                           string =
                                                                                                                                       sprintf!("file_system.read_link / error\': {} / error: {} / name: {}",
                                                                                                                                                v2093_1_0.clone(),
                                                                                                                                                v278.clone(),
                                                                                                                                                v279.clone());
                                                                                                                                   let v2213:
                                                                                                                                           std::io::Error =
                                                                                                                                       std::io::Error::new(std::io::ErrorKind::Other, &*v2210);
                                                                                                                                   Err(v2213)
                                                                                                                               }
                                                                                                                           }
                                                                                                                       } else {
                                                                                                                           let v2241:
                                                                                                                                   string =
                                                                                                                               sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                                                                                                        v1_1.clone(),
                                                                                                                                        v278.clone(),
                                                                                                                                        v241.clone(),
                                                                                                                                        v279.clone());
                                                                                                                           let v2244:
                                                                                                                                   std::io::Error =
                                                                                                                               std::io::Error::new(std::io::ErrorKind::Other, &*v2241);
                                                                                                                           Err(v2244)
                                                                                                                       }
                                                                                                                   } else {
                                                                                                                       let v2271:
                                                                                                                               string =
                                                                                                                           sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                                                                                                    v1_1.clone(),
                                                                                                                                    v278,
                                                                                                                                    v241.clone(),
                                                                                                                                    v279.clone());
                                                                                                                       let v2274:
                                                                                                                               std::io::Error =
                                                                                                                           std::io::Error::new(std::io::ErrorKind::Other, &*v2271);
                                                                                                                       Err(v2274)
                                                                                                                   }
                                                                                                               }
                                                                                                           };
                                                                                                       let v2303 =
                                                                                                           File_system::method79();
                                                                                                       let v2315:
                                                                                                               Result<std::path::PathBuf,
                                                                                                                      string> =
                                                                                                           v2302.map_err(|x| v2303(x));
                                                                                                       let v2318:
                                                                                                               File_system::US13 =
                                                                                                           match &v2315
                                                                                                               {
                                                                                                               Err(v2315_1_0)
                                                                                                               =>
                                                                                                               v32_1(v2315_1_0.clone()),
                                                                                                               Ok(v2315_0_0)
                                                                                                               =>
                                                                                                               v31_1(v2315_0_0.clone()),
                                                                                                           };
                                                                                                       match &v2318
                                                                                                           {
                                                                                                           File_system::US13::US13_0(v2318_0_0)
                                                                                                           =>
                                                                                                           {
                                                                                                               let v2347:
                                                                                                                       string =
                                                                                                                   File_system::method59(toString(v2318_0_0.clone().display()),
                                                                                                                                         v222.clone());
                                                                                                               let v2350:
                                                                                                                       &str =
                                                                                                                   &*v2347;
                                                                                                               let v2374:
                                                                                                                       std::string::String =
                                                                                                                   String::from(v2350);
                                                                                                               let v2398:
                                                                                                                       std::path::PathBuf =
                                                                                                                   std::path::PathBuf::from(v2374);
                                                                                                               Ok(v2398)
                                                                                                           }
                                                                                                           File_system::US13::US13_1(v2318_1_0)
                                                                                                           =>
                                                                                                           {
                                                                                                               let v2435:
                                                                                                                       string =
                                                                                                                   sprintf!("file_system.read_link / error\': {} / error: {} / name: {}",
                                                                                                                            v2318_1_0.clone(),
                                                                                                                            v221.clone(),
                                                                                                                            v222.clone());
                                                                                                               let v2438:
                                                                                                                       std::io::Error =
                                                                                                                   std::io::Error::new(std::io::ErrorKind::Other, &*v2435);
                                                                                                               Err(v2438)
                                                                                                           }
                                                                                                       }
                                                                                                   } else {
                                                                                                       let v2466:
                                                                                                               string =
                                                                                                           sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                                                                                    v1_1.clone(),
                                                                                                                    v221.clone(),
                                                                                                                    v184.clone(),
                                                                                                                    v222.clone());
                                                                                                       let v2469:
                                                                                                               std::io::Error =
                                                                                                           std::io::Error::new(std::io::ErrorKind::Other, &*v2466);
                                                                                                       Err(v2469)
                                                                                                   }
                                                                                               } else {
                                                                                                   let v2496:
                                                                                                           string =
                                                                                                       sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                                                                                v1_1.clone(),
                                                                                                                v221,
                                                                                                                v184.clone(),
                                                                                                                v222.clone());
                                                                                                   let v2499:
                                                                                                           std::io::Error =
                                                                                                       std::io::Error::new(std::io::ErrorKind::Other, &*v2496);
                                                                                                   Err(v2499)
                                                                                               }
                                                                                           }
                                                                                       };
                                                                        let v2528 =
                                                                            File_system::method79();
                                                                        let v2540: Result<
                                                                            std::path::PathBuf,
                                                                            string,
                                                                        > = v2527
                                                                            .map_err(|x| v2528(x));
                                                                        let v2543:
                                                                                           File_system::US13 =
                                                                                       match &v2540
                                                                                           {
                                                                                           Err(v2540_1_0)
                                                                                           =>
                                                                                           v32_1(v2540_1_0.clone()),
                                                                                           Ok(v2540_0_0)
                                                                                           =>
                                                                                           v31_1(v2540_0_0.clone()),
                                                                                       };
                                                                        match &v2543
                                                                                       {
                                                                                       File_system::US13::US13_0(v2543_0_0)
                                                                                       =>
                                                                                       {
                                                                                           let v2572:
                                                                                                   string =
                                                                                               File_system::method59(toString(v2543_0_0.clone().display()),
                                                                                                                     v165.clone());
                                                                                           let v2575:
                                                                                                   &str =
                                                                                               &*v2572;
                                                                                           let v2599:
                                                                                                   std::string::String =
                                                                                               String::from(v2575);
                                                                                           let v2623:
                                                                                                   std::path::PathBuf =
                                                                                               std::path::PathBuf::from(v2599);
                                                                                           Ok(v2623)
                                                                                       }
                                                                                       File_system::US13::US13_1(v2543_1_0)
                                                                                       =>
                                                                                       {
                                                                                           let v2660:
                                                                                                   string =
                                                                                               sprintf!("file_system.read_link / error\': {} / error: {} / name: {}",
                                                                                                        v2543_1_0.clone(),
                                                                                                        v164.clone(),
                                                                                                        v165.clone());
                                                                                           let v2663:
                                                                                                   std::io::Error =
                                                                                               std::io::Error::new(std::io::ErrorKind::Other, &*v2660);
                                                                                           Err(v2663)
                                                                                       }
                                                                                   }
                                                                    } else {
                                                                        let v2691:
                                                                                           string =
                                                                                       sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                                                                v1_1.clone(),
                                                                                                v164.clone(),
                                                                                                v127.clone(),
                                                                                                v165.clone());
                                                                        let v2694:
                                                                                           std::io::Error =
                                                                                       std::io::Error::new(std::io::ErrorKind::Other, &*v2691);
                                                                        Err(v2694)
                                                                    }
                                                                } else {
                                                                    let v2721:
                                                                                       string =
                                                                                   sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                                                            v1_1.clone(),
                                                                                            v164,
                                                                                            v127.clone(),
                                                                                            v165.clone());
                                                                    let v2724:
                                                                                       std::io::Error =
                                                                                   std::io::Error::new(std::io::ErrorKind::Other, &*v2721);
                                                                    Err(v2724)
                                                                }
                                                            }
                                                        };
                                                        let v2753 = File_system::method79();
                                                        let v2765: Result<
                                                            std::path::PathBuf,
                                                            string,
                                                        > = v2752.map_err(|x| v2753(x));
                                                        let v2768: File_system::US13 = match &v2765
                                                        {
                                                            Err(v2765_1_0) => {
                                                                v32_1(v2765_1_0.clone())
                                                            }
                                                            Ok(v2765_0_0) => {
                                                                v31_1(v2765_0_0.clone())
                                                            }
                                                        };
                                                        match &v2768 {
                                                            File_system::US13::US13_0(
                                                                v2768_0_0,
                                                            ) => {
                                                                let v2797: string =
                                                                    File_system::method59(
                                                                        toString(
                                                                            v2768_0_0
                                                                                .clone()
                                                                                .display(),
                                                                        ),
                                                                        v108.clone(),
                                                                    );
                                                                let v2800: &str = &*v2797;
                                                                let v2824: std::string::String =
                                                                    String::from(v2800);
                                                                let v2848: std::path::PathBuf =
                                                                    std::path::PathBuf::from(v2824);
                                                                Ok(v2848)
                                                            }
                                                            File_system::US13::US13_1(
                                                                v2768_1_0,
                                                            ) => {
                                                                let v2885:
                                                                               string =
                                                                           sprintf!("file_system.read_link / error\': {} / error: {} / name: {}",
                                                                                    v2768_1_0.clone(),
                                                                                    v107.clone(),
                                                                                    v108.clone());
                                                                let v2888: std::io::Error =
                                                                    std::io::Error::new(
                                                                        std::io::ErrorKind::Other,
                                                                        &*v2885,
                                                                    );
                                                                Err(v2888)
                                                            }
                                                        }
                                                    } else {
                                                        let v2916:
                                                                       string =
                                                                   sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                                            v1_1.clone(),
                                                                            v107.clone(),
                                                                            v69.clone(),
                                                                            v108.clone());
                                                        let v2919: std::io::Error =
                                                            std::io::Error::new(
                                                                std::io::ErrorKind::Other,
                                                                &*v2916,
                                                            );
                                                        Err(v2919)
                                                    }
                                                } else {
                                                    let v2946: string =
                                                               sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                                        v1_1.clone(),
                                                                        v107,
                                                                        v69.clone(),
                                                                        v108.clone());
                                                    let v2949: std::io::Error = std::io::Error::new(
                                                        std::io::ErrorKind::Other,
                                                        &*v2946,
                                                    );
                                                    Err(v2949)
                                                }
                                            }
                                        };
                                    let v2978 = File_system::method79();
                                    let v2990: Result<std::path::PathBuf, string> =
                                        v2977.map_err(|x| v2978(x));
                                    let v2993: File_system::US13 = match &v2990 {
                                        Err(v2990_1_0) => v32_1(v2990_1_0.clone()),
                                        Ok(v2990_0_0) => v31_1(v2990_0_0.clone()),
                                    };
                                    match &v2993 {
                                        File_system::US13::US13_0(v2993_0_0) => {
                                            let v3022: string = File_system::method59(
                                                toString(v2993_0_0.clone().display()),
                                                v50.clone(),
                                            );
                                            let v3025: &str = &*v3022;
                                            let v3049: std::string::String = String::from(v3025);
                                            let v3073: std::path::PathBuf =
                                                std::path::PathBuf::from(v3049);
                                            Ok(v3073)
                                        }
                                        File_system::US13::US13_1(v2993_1_0) => {
                                            let v3110: string =
                                                       sprintf!("file_system.read_link / error\': {} / error: {} / name: {}",
                                                                v2993_1_0.clone(),
                                                                v49.clone(),
                                                                v50.clone());
                                            let v3113: std::io::Error = std::io::Error::new(
                                                std::io::ErrorKind::Other,
                                                &*v3110,
                                            );
                                            Err(v3113)
                                        }
                                    }
                                } else {
                                    let v3141: string =
                                               sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                        v1_1.clone(),
                                                        v49.clone(),
                                                        v1_1.clone(),
                                                        v50.clone());
                                    let v3144: std::io::Error =
                                        std::io::Error::new(std::io::ErrorKind::Other, &*v3141);
                                    Err(v3144)
                                }
                            } else {
                                let v3171: string =
                                           sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                    v1_1.clone(), v49,
                                                    v1_1.clone(),
                                                    v50.clone());
                                let v3174: std::io::Error =
                                    std::io::Error::new(std::io::ErrorKind::Other, &*v3171);
                                Err(v3174)
                            }
                        }
                    }
                };
                v3203.is_err()
            } else {
                false
            } {
                File_system::method7(true, v1_1.clone());
            }
            if File_system::method9(v1_1.clone()) == false {
                let v19030: bool = true;
                #[cfg(windows)]
                std::os::windows::fs::symlink_dir(&*v0_1.clone(), &*v1_1.clone()).unwrap();
                let v19032: bool = true;
                #[cfg(unix)]
                std::os::unix::fs::symlink(&*v0_1, &*v1_1.clone()).unwrap();
                ();
                ()
            }
        }
    }
    pub fn closure57(v0_1: string, v1_1: string) {
        File_system::method93(v0_1, v1_1);
    }
    pub fn closure56(unitVar: (), v0_1: string) -> Func1<string, ()> {
        Func1::new({
            let v0_1 = v0_1.clone();
            move |v: string| File_system::closure57(v0_1.clone(), v)
        })
    }
    pub fn closure59(v0_1: string, v1_1: string) -> string {
        File_system::method59(v0_1, v1_1)
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
