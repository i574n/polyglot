pub mod File_system {
    use super::*;
    use fable_library_rust::Async_::Async;
    use fable_library_rust::Choice_::Choice_2;
    use fable_library_rust::DateTime_::DateTime;
    use fable_library_rust::Guid_::new_guid;
    use fable_library_rust::Guid_::parse;
    use fable_library_rust::Guid_::Guid;
    use fable_library_rust::List_::empty;
    use fable_library_rust::List_::ofArray;
    use fable_library_rust::List_::singleton;
    use fable_library_rust::List_::toArray;
    use fable_library_rust::Map_::find;
    use fable_library_rust::Map_::ofSeq;
    use fable_library_rust::NativeArray_::new_array;
    use fable_library_rust::NativeArray_::Array;
    use fable_library_rust::Native_::getZero;
    use fable_library_rust::Native_::interface_cast;
    use fable_library_rust::Native_::on_startup;
    use fable_library_rust::Native_::unbox;
    use fable_library_rust::Native_::Any;
    use fable_library_rust::Native_::Arc;
    use fable_library_rust::Native_::Func0;
    use fable_library_rust::Native_::Func1;
    use fable_library_rust::Native_::Func2;
    use fable_library_rust::Native_::Lrc;
    use fable_library_rust::Native_::LrcPtr;
    use fable_library_rust::Native_::MutCell;
    use fable_library_rust::Native_::OnceInit;
    use fable_library_rust::Option_::defaultValue;
    use fable_library_rust::Option_::map;
    use fable_library_rust::Seq_::ofList;
    use fable_library_rust::String_::append;
    use fable_library_rust::String_::concat;
    use fable_library_rust::String_::getCharAt;
    use fable_library_rust::String_::getSlice;
    use fable_library_rust::String_::length;
    use fable_library_rust::String_::ofChar;
    use fable_library_rust::String_::printfn;
    use fable_library_rust::String_::replace;
    use fable_library_rust::String_::sprintf;
    use fable_library_rust::String_::string;
    use fable_library_rust::String_::toLower;
    use fable_library_rust::String_::toString;
    use fable_library_rust::String_::trimEndChars;
    use fable_library_rust::String_::trimStartChars;
    use fable_library_rust::System::Collections::Generic::IEnumerable_1;
    use fable_library_rust::System::Exception;
    use fable_library_rust::System::IDisposable;
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
    pub trait IOsEnviron: core::fmt::Debug + core::fmt::Display {
        fn environ(&self) -> LrcPtr<dyn Any>;
    }
    impl<V: IOsEnviron + core::fmt::Debug + core::fmt::Display> IOsEnviron for LrcPtr<V> {
        #[inline]
        fn environ(&self) -> LrcPtr<dyn Any> {
            (**self).environ()
        }
    }
    pub trait IFsExistsSync: core::fmt::Debug + core::fmt::Display {
        fn existsSync(&self, path: string) -> bool;
    }
    impl<V: IFsExistsSync + core::fmt::Debug + core::fmt::Display> IFsExistsSync for LrcPtr<V> {
        #[inline]
        fn existsSync(&self, path: string) -> bool {
            (**self).existsSync(path)
        }
    }
    pub trait IPathJoin: core::fmt::Debug + core::fmt::Display {
        fn join(&self, paths: Array<string>) -> string;
    }
    impl<V: IPathJoin + core::fmt::Debug + core::fmt::Display> IPathJoin for LrcPtr<V> {
        #[inline]
        fn join(&self, paths: Array<string>) -> string {
            (**self).join(paths)
        }
    }
    #[derive(Clone, Debug)]
    pub struct Disposable {
        f: Func0<()>,
    }
    impl Disposable {
        pub fn _ctor__3A5B6456(f: Func0<()>) -> LrcPtr<File_system::Disposable> {
            let f_1;
            ();
            f_1 = f;
            ();
            LrcPtr::new(File_system::Disposable { f: f_1 })
        }
    }
    impl core::fmt::Display for Disposable {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    impl IDisposable for Disposable {
        fn Dispose(&self) {
            (self.f)();
        }
    }
    pub trait IPathDirname: core::fmt::Debug + core::fmt::Display {
        fn dirname(&self, path: string) -> string;
    }
    impl<V: IPathDirname + core::fmt::Debug + core::fmt::Display> IPathDirname for LrcPtr<V> {
        #[inline]
        fn dirname(&self, path: string) -> string {
            (**self).dirname(path)
        }
    }
    #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
    pub enum US0 {
        US0_0,
        US0_1,
        US0_2,
        US0_3,
        US0_4,
    }
    impl core::fmt::Display for US0 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
    pub struct Mut0 {
        pub l0: MutCell<i64>,
    }
    impl core::fmt::Display for Mut0 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Debug)]
    pub struct Mut1 {
        pub l0: MutCell<Func1<string, ()>>,
    }
    impl core::fmt::Display for Mut1 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
    pub struct Mut2 {
        pub l0: MutCell<bool>,
    }
    impl core::fmt::Display for Mut2 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
    pub struct Mut3 {
        pub l0: MutCell<string>,
    }
    impl core::fmt::Display for Mut3 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
    pub struct Mut4 {
        pub l0: MutCell<File_system::US0>,
    }
    impl core::fmt::Display for Mut4 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
    pub enum US1 {
        US1_0(File_system::US0),
        US1_1,
    }
    impl core::fmt::Display for US1 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
    pub enum US2 {
        US2_0(i64),
        US2_1,
    }
    impl core::fmt::Display for US2 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
    pub enum US3 {
        US3_0,
        US3_1,
        US3_2,
    }
    impl core::fmt::Display for US3 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
    pub enum US4 {
        US4_0(File_system::US3),
        US4_1(File_system::US3),
        US4_2(File_system::US3),
        US4_3(File_system::US3),
        US4_4(File_system::US3),
    }
    impl core::fmt::Display for US4 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
    pub enum US5 {
        US5_0(string),
        US5_1,
    }
    impl core::fmt::Display for US5 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
    pub enum US7 {
        US7_0,
        US7_1,
        US7_2,
    }
    impl core::fmt::Display for US7 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
    pub enum US8 {
        US8_0,
        US8_1,
        US8_2,
        US8_3,
        US8_4,
    }
    impl core::fmt::Display for US8 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
    pub enum US6 {
        US6_0(File_system::US7, File_system::US8),
        US6_1,
    }
    impl core::fmt::Display for US6 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
    pub enum US9 {
        US9_0,
        US9_1(string),
    }
    impl core::fmt::Display for US9 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Debug)]
    pub enum US10 {
        US10_0(i64),
        US10_1(LrcPtr<Exception>),
    }
    impl core::fmt::Display for US10 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Debug)]
    pub enum US11 {
        US11_0(i64),
        US11_1(LrcPtr<Exception>),
    }
    impl core::fmt::Display for US11 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Debug)]
    pub enum US12 {
        US12_0(chrono::DateTime<chrono::Utc>),
        US12_1,
    }
    impl core::fmt::Display for US12 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Debug)]
    pub enum US13 {
        US13_0,
        US13_1(std::string::String),
    }
    impl core::fmt::Display for US13 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Debug)]
    pub enum US14 {
        US14_0(std::path::PathBuf),
        US14_1(string),
    }
    impl core::fmt::Display for US14 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Debug)]
    pub enum US15 {
        US15_0(std::path::PathBuf),
        US15_1,
    }
    impl core::fmt::Display for US15 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
    pub enum US16 {
        US16_0(string),
        US16_1(string),
    }
    impl core::fmt::Display for US16 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    pub fn method3(v0_1: string) -> string {
        v0_1
    }
    pub fn method4() -> string {
        string("")
    }
    pub fn closure1(unitVar: (), v0_1: string) -> File_system::US5 {
        File_system::US5::US5_0(v0_1)
    }
    pub fn method5() -> Func1<string, File_system::US5> {
        Func1::new(move |v: string| File_system::closure1((), v))
    }
    pub fn method2(v0_1: string) -> string {
        let v2_1: string = File_system::method3(v0_1);
        let v4: Result<std::string::String, std::env::VarError> = std::env::var(&*v2_1);
        let v6: bool = true;
        let _result_map_ = v4.map(|x| {
            //;
            let v8: std::string::String = x;
            let v10: string = fable_library_rust::String_::fromString(v8);
            let v12: bool = true;
            v10
        });
        let v14: Result<string, std::env::VarError> = _result_map_;
        let v15: string = File_system::method4();
        v14.unwrap_or(v15)
    }
    pub fn method1() -> (File_system::US1, File_system::US2) {
        let v1_1: string = File_system::method2(string("TRACE_LEVEL"));
        let v6: File_system::US1 = if string("Verbose") == (v1_1.clone()) {
            File_system::US1::US1_0(File_system::US0::US0_0)
        } else {
            File_system::US1::US1_1
        };
        (
            match &v6 {
                File_system::US1::US1_0(v6_0_0) => File_system::US1::US1_0(
                    match &v6 {
                        File_system::US1::US1_0(x) => x.clone(),
                        _ => unreachable!(),
                    }
                    .clone(),
                ),
                _ => {
                    let v13: File_system::US1 = if string("Debug") == (v1_1.clone()) {
                        File_system::US1::US1_0(File_system::US0::US0_1)
                    } else {
                        File_system::US1::US1_1
                    };
                    match &v13 {
                        File_system::US1::US1_0(v13_0_0) => File_system::US1::US1_0(
                            match &v13 {
                                File_system::US1::US1_0(x) => x.clone(),
                                _ => unreachable!(),
                            }
                            .clone(),
                        ),
                        _ => {
                            let v20_1: File_system::US1 = if string("Info") == (v1_1.clone()) {
                                File_system::US1::US1_0(File_system::US0::US0_2)
                            } else {
                                File_system::US1::US1_1
                            };
                            match &v20_1 {
                                File_system::US1::US1_0(v20_1_0_0) => File_system::US1::US1_0(
                                    match &v20_1 {
                                        File_system::US1::US1_0(x) => x.clone(),
                                        _ => unreachable!(),
                                    }
                                    .clone(),
                                ),
                                _ => {
                                    let v27_1: File_system::US1 =
                                        if string("Warning") == (v1_1.clone()) {
                                            File_system::US1::US1_0(File_system::US0::US0_3)
                                        } else {
                                            File_system::US1::US1_1
                                        };
                                    match &v27_1 {
                                        File_system::US1::US1_0(v27_1_0_0) => {
                                            File_system::US1::US1_0(
                                                match &v27_1 {
                                                    File_system::US1::US1_0(x) => x.clone(),
                                                    _ => unreachable!(),
                                                }
                                                .clone(),
                                            )
                                        }
                                        _ => {
                                            let v34_1: File_system::US1 =
                                                if string("Critical") == (v1_1.clone()) {
                                                    File_system::US1::US1_0(File_system::US0::US0_4)
                                                } else {
                                                    File_system::US1::US1_1
                                                };
                                            match &v34_1 {
                                                File_system::US1::US1_0(v34_1_0_0) => {
                                                    File_system::US1::US1_0(
                                                        match &v34_1 {
                                                            File_system::US1::US1_0(x) => x.clone(),
                                                            _ => unreachable!(),
                                                        }
                                                        .clone(),
                                                    )
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
            if (File_system::method2(string("AUTOMATION"))) != string("True") {
                File_system::US2::US2_1
            } else {
                File_system::US2::US2_0({
                    let _arg: DateTime = DateTime::now();
                    _arg.ticks()
                })
            },
        )
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
        let patternInput: (File_system::US1, File_system::US2) = File_system::method1();
        let _run_target_args__v1: (File_system::US1, File_system::US2) =
            (patternInput.0.clone(), patternInput.1.clone());
        let v132: File_system::US2 = _run_target_args__v1.1.clone();
        let v131: File_system::US1 = _run_target_args__v1.0.clone();
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
                l0: MutCell::new(match &v131 {
                    File_system::US1::US1_0(v131_0_0) => match &v131 {
                        File_system::US1::US1_0(x) => x.clone(),
                        _ => unreachable!(),
                    }
                    .clone(),
                    _ => v0_1.clone(),
                }),
            }),
            match &v132 {
                File_system::US2::US2_0(v132_0_0) => Some(match &v132 {
                    File_system::US2::US2_0(x) => x.clone(),
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
    pub fn method10(v0_1: string) -> bool {
        let v4: &str = &*v0_1;
        let v28_1: std::string::String = String::from(v4);
        let v69: std::path::PathBuf = std::path::PathBuf::from(v28_1);
        if v69.clone().exists() {
            v69.is_dir()
        } else {
            false
        }
    }
    pub fn method9(v0_1: bool, v1_1: string) {
        if File_system::method10(v1_1.clone()) {
            if v0_1 {
                std::fs::remove_dir_all(&*v1_1.clone()).unwrap();
                ()
            } else {
                std::fs::remove_dir(&*v1_1).unwrap();
                ()
            };
        }
        ()
    }
    pub fn method11(v0_1: File_system::US0) -> bool {
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
        ) = File_system::TraceState::trace_state()
            .get()
            .clone()
            .unwrap();
        let v35_1: File_system::US0 = (patternInput.4.clone()).l0.get().clone();
        if ((patternInput.2.clone()).l0.get().clone()) == false {
            false
        } else {
            (find(
                v0_1,
                ofSeq(ofList(ofArray(new_array(&[
                    LrcPtr::new((File_system::US0::US0_0, 0_i32)),
                    LrcPtr::new((File_system::US0::US0_1, 1_i32)),
                    LrcPtr::new((File_system::US0::US0_2, 2_i32)),
                    LrcPtr::new((File_system::US0::US0_3, 3_i32)),
                    LrcPtr::new((File_system::US0::US0_4, 4_i32)),
                ])))),
            )) >= (find(
                v35_1,
                ofSeq(ofList(ofArray(new_array(&[
                    LrcPtr::new((File_system::US0::US0_0, 0_i32)),
                    LrcPtr::new((File_system::US0::US0_1, 1_i32)),
                    LrcPtr::new((File_system::US0::US0_2, 2_i32)),
                    LrcPtr::new((File_system::US0::US0_3, 3_i32)),
                    LrcPtr::new((File_system::US0::US0_4, 4_i32)),
                ])))),
            ))
        }
    }
    pub fn closure5(unitVar: (), v0_1: i64) -> File_system::US2 {
        File_system::US2::US2_0(v0_1)
    }
    pub fn method13() -> Func1<i64, File_system::US2> {
        Func1::new(move |v: i64| File_system::closure5((), v))
    }
    pub fn method14() -> string {
        string("hh:mm:ss")
    }
    pub fn method15() -> string {
        string("HH:mm:ss")
    }
    pub fn method12(
        v0_1: LrcPtr<File_system::Mut0>,
        v1_1: LrcPtr<File_system::Mut1>,
        v2_1: LrcPtr<File_system::Mut2>,
        v3: LrcPtr<File_system::Mut3>,
        v4: LrcPtr<File_system::Mut4>,
        v5: Option<i64>,
    ) -> string {
        let v20_1: File_system::US2 =
            defaultValue(File_system::US2::US2_1, map(File_system::method13(), v5));
        let v117: DateTime = match &v20_1 {
            File_system::US2::US2_0(v20_1_0_0) => {
                let v77: TimeSpan = TimeSpan::new_ticks(
                    ({
                        let _arg: DateTime = DateTime::now();
                        _arg.ticks()
                    }) - (match &v20_1 {
                        File_system::US2::US2_0(x) => x.clone(),
                        _ => unreachable!(),
                    }),
                );
                DateTime::new_ymdhms_milli(
                    1_i32,
                    1_i32,
                    1_i32,
                    v77.hours(),
                    v77.minutes(),
                    v77.seconds(),
                    v77.milliseconds(),
                )
            }
            _ => DateTime::now(),
        };
        let v118: string = File_system::method14();
        let provider: string = if (v118.clone()) == string("") {
            string("M-d-y hh:mm:ss tt")
        } else {
            v118
        };
        v117.toString(provider)
    }
    pub fn method18() -> string {
        string("")
    }
    pub fn closure6(v0_1: LrcPtr<File_system::Mut3>, v1_1: string, unitVar: ()) {
        let v3: string = append((v0_1.l0.get().clone()), (v1_1));
        v0_1.l0.set(v3);
        ()
    }
    pub fn method17(v0_1: char) -> string {
        let v2_1: LrcPtr<File_system::Mut3> = LrcPtr::new(File_system::Mut3 {
            l0: MutCell::new(File_system::method18()),
        });
        let v8: () = {
            File_system::closure6(v2_1.clone(), sprintf!("{}", v0_1), ());
            ()
        };
        v2_1.l0.get().clone()
    }
    pub fn method19() -> string {
        string("\u{001b}[0m")
    }
    pub fn method16() -> string {
        let v6: string = File_system::method17(getCharAt(toLower(string("Debug")), 0_i32));
        let v9: &str = inline_colorization::color_bright_blue;
        let v12: &str = &*v6;
        let v35_1: &str = inline_colorization::color_reset;
        let v37: std::string::String = format!("{}{}{}", v9, v12, v35_1);
        fable_library_rust::String_::fromString(v37)
    }
    pub fn method20(v0_1: string) -> string {
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
        let v129: File_system::US5 =
            defaultValue(File_system::US5::US5_1, map(File_system::method5(), v115));
        match &v129 {
            File_system::US5::US5_0(v129_0_0) => match &v129 {
                File_system::US5::US5_0(x) => x.clone(),
                _ => unreachable!(),
            }
            .clone(),
            _ => string(""),
        }
    }
    pub fn method22(v0_1: string, v1_1: string) -> string {
        let v3: LrcPtr<File_system::Mut3> = LrcPtr::new(File_system::Mut3 {
            l0: MutCell::new(File_system::method18()),
        });
        let v10: () = {
            File_system::closure6(v3.clone(), string("{ "), ());
            ()
        };
        let v19_1: () = {
            File_system::closure6(v3.clone(), string("ex"), ());
            ()
        };
        let v28_1: () = {
            File_system::closure6(v3.clone(), string(" = "), ());
            ()
        };
        let v36_1: () = {
            File_system::closure6(v3.clone(), v0_1, ());
            ()
        };
        let v45: () = {
            File_system::closure6(v3.clone(), string("; "), ());
            ()
        };
        let v54: () = {
            File_system::closure6(v3.clone(), string("path"), ());
            ()
        };
        let v62: () = {
            File_system::closure6(v3.clone(), string(" = "), ());
            ()
        };
        let v70: () = {
            File_system::closure6(v3.clone(), v1_1, ());
            ()
        };
        let v79: () = {
            File_system::closure6(v3.clone(), string(" }"), ());
            ()
        };
        v3.l0.get().clone()
    }
    pub fn method23(v0_1: string) -> string {
        trimEndChars(
            trimStartChars(v0_1, toArray(empty::<char>())),
            toArray(ofArray(new_array(&[' ', '/']))),
        )
    }
    pub fn method21(
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
        let v10: string = File_system::method22(v8, v9);
        File_system::method23(sprintf!(
            "{} {} #{} {} / {}",
            v6,
            v7,
            v0_1.l0.get().clone(),
            string("file_system.delete_directory_async"),
            v10
        ))
    }
    pub fn closure7(v0_1: LrcPtr<File_system::Mut0>, unitVar: ()) {
        let v2_1: i64 = (v0_1.l0.get().clone()) + 1_i64;
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
    pub fn method24(v0_1: string) {
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
        ) = File_system::TraceState::trace_state()
            .get()
            .clone()
            .unwrap();
        let v37: () = {
            File_system::closure7(patternInput.0.clone(), ());
            ()
        };
        println!("{}", v0_1.clone());
        ((patternInput.1.clone()).l0.get().clone())(v0_1)
    }
    pub fn closure4(v0_1: string, v1_1: LrcPtr<Exception>, unitVar: ()) {
        if File_system::method11(File_system::US0::US0_1) {
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
            ) = File_system::TraceState::trace_state()
                .get()
                .clone()
                .unwrap();
            let v25_1: Option<i64> = patternInput.5.clone();
            let v24_1: LrcPtr<File_system::Mut4> = patternInput.4.clone();
            let v23_1: LrcPtr<File_system::Mut3> = patternInput.3.clone();
            let v22_1: LrcPtr<File_system::Mut2> = patternInput.2.clone();
            let v21_1: LrcPtr<File_system::Mut1> = patternInput.1.clone();
            let v20_1: LrcPtr<File_system::Mut0> = patternInput.0.clone();
            File_system::method24(File_system::method21(
                v20_1.clone(),
                v21_1.clone(),
                v22_1.clone(),
                v23_1.clone(),
                v24_1.clone(),
                v25_1.clone(),
                File_system::method12(v20_1, v21_1, v22_1, v23_1, v24_1, v25_1),
                File_system::method16(),
                sprintf!("{:?}", v1_1),
                File_system::method20(v0_1),
            ))
        };
    }
    pub fn method8(v0_1: string, v1_1: i64) -> Arc<Async<i64>> {
        getZero()
    }
    pub fn method7(v0_1: string, v1_1: i64) -> Arc<Async<i64>> {
        getZero()
    }
    pub fn method6(v0_1: string) -> Arc<Async<i64>> {
        File_system::method7(v0_1, 0_i64)
    }
    pub fn closure3(unitVar: (), v0_1: string) -> Arc<Async<i64>> {
        File_system::method6(v0_1)
    }
    pub fn method29(v0_1: string, v1_1: i64, v2_1: string) -> string {
        let v4: LrcPtr<File_system::Mut3> = LrcPtr::new(File_system::Mut3 {
            l0: MutCell::new(File_system::method18()),
        });
        let v11: () = {
            File_system::closure6(v4.clone(), string("{ "), ());
            ()
        };
        let v20_1: () = {
            File_system::closure6(v4.clone(), string("path"), ());
            ()
        };
        let v29_1: () = {
            File_system::closure6(v4.clone(), string(" = "), ());
            ()
        };
        let v37: () = {
            File_system::closure6(v4.clone(), v0_1, ());
            ()
        };
        let v46: () = {
            File_system::closure6(v4.clone(), string("; "), ());
            ()
        };
        let v55: () = {
            File_system::closure6(v4.clone(), string("retry"), ());
            ()
        };
        let v63: () = {
            File_system::closure6(v4.clone(), string(" = "), ());
            ()
        };
        let v71: () = {
            File_system::closure6(v4.clone(), sprintf!("{}", v1_1), ());
            ()
        };
        let v79: () = {
            File_system::closure6(v4.clone(), string("; "), ());
            ()
        };
        let v88: () = {
            File_system::closure6(v4.clone(), string("ex"), ());
            ()
        };
        let v96: () = {
            File_system::closure6(v4.clone(), string(" = "), ());
            ()
        };
        let v104: () = {
            File_system::closure6(v4.clone(), v2_1, ());
            ()
        };
        let v113: () = {
            File_system::closure6(v4.clone(), string(" }"), ());
            ()
        };
        v4.l0.get().clone()
    }
    pub fn method28(
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
        let v11: string = File_system::method29(v8, v9, v10);
        File_system::method23(sprintf!(
            "{} {} #{} {} / {}",
            v6,
            v7,
            v0_1.l0.get().clone(),
            string("file_system.wait_for_file_access"),
            v11
        ))
    }
    pub fn closure12(v0_1: string, v1_1: i64, v2_1: LrcPtr<Exception>, unitVar: ()) {
        if File_system::method11(File_system::US0::US0_1) {
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
            ) = File_system::TraceState::trace_state()
                .get()
                .clone()
                .unwrap();
            let v26_1: Option<i64> = patternInput.5.clone();
            let v25_1: LrcPtr<File_system::Mut4> = patternInput.4.clone();
            let v24_1: LrcPtr<File_system::Mut3> = patternInput.3.clone();
            let v23_1: LrcPtr<File_system::Mut2> = patternInput.2.clone();
            let v22_1: LrcPtr<File_system::Mut1> = patternInput.1.clone();
            let v21_1: LrcPtr<File_system::Mut0> = patternInput.0.clone();
            File_system::method24(File_system::method28(
                v21_1.clone(),
                v22_1.clone(),
                v23_1.clone(),
                v24_1.clone(),
                v25_1.clone(),
                v26_1.clone(),
                File_system::method12(v21_1, v22_1, v23_1, v24_1, v25_1, v26_1),
                File_system::method16(),
                File_system::method20(v0_1),
                v1_1,
                sprintf!("{:?}", v2_1),
            ))
        };
    }
    pub fn method27(
        v0_1: File_system::US6,
        v1_1: string,
        v2_1: i64,
        v3: File_system::US8,
        v4: File_system::US7,
    ) -> Arc<Async<i64>> {
        getZero()
    }
    pub fn method26(v0_1: File_system::US6, v1_1: string, v2_1: i64) -> Arc<Async<i64>> {
        getZero()
    }
    pub fn method25(v0_1: File_system::US6, v1_1: string) -> Arc<Async<i64>> {
        File_system::method26(v0_1, v1_1, 0_i64)
    }
    pub fn closure11(v0_1: File_system::US6, v1_1: string) -> Arc<Async<i64>> {
        File_system::method25(v0_1, v1_1)
    }
    pub fn closure10(unitVar: (), v0_1: File_system::US6) -> Func1<string, Arc<Async<i64>>> {
        Func1::new({
            let v0_1 = v0_1.clone();
            move |v: string| File_system::closure11(v0_1.clone(), v)
        })
    }
    pub fn method30(v0_1: string) -> Arc<Async<i64>> {
        File_system::method25(
            File_system::US6::US6_0(File_system::US7::US7_0, File_system::US8::US8_1),
            v0_1,
        )
    }
    pub fn closure13(unitVar: (), v0_1: string) -> Arc<Async<i64>> {
        File_system::method30(v0_1)
    }
    pub fn method31(v0_1: string) -> Arc<Async<string>> {
        getZero()
    }
    pub fn closure14(unitVar: (), v0_1: string) -> Arc<Async<string>> {
        File_system::method31(v0_1)
    }
    pub fn method33(v0_1: string) -> bool {
        let v4: &str = &*v0_1;
        let v28_1: std::string::String = String::from(v4);
        let v69: std::path::PathBuf = std::path::PathBuf::from(v28_1);
        if v69.clone().exists() {
            v69.is_file()
        } else {
            false
        }
    }
    pub fn method34(v0_1: Vec<u8>) -> Vec<u8> {
        v0_1
    }
    pub fn method32(v0_1: string, v1_1: string) -> bool {
        if (File_system::method33(v0_1.clone())) == false {
            false
        } else {
            let v8: Result<Vec<u8>, std::io::Error> = std::fs::read(&*v0_1);
            let v46: Vec<u8> = File_system::method34(v8.unwrap());
            let v48: Result<std::string::String, std::string::FromUtf8Error> =
                std::string::String::from_utf8(v46);
            let v51: std::string::String = v48.unwrap();
            (v1_1) == (fable_library_rust::String_::fromString(v51))
        }
    }
    pub fn closure16(v0_1: string, v1_1: string) -> bool {
        File_system::method32(v0_1, v1_1)
    }
    pub fn closure15(unitVar: (), v0_1: string) -> Func1<string, bool> {
        Func1::new({
            let v0_1 = v0_1.clone();
            move |v: string| File_system::closure16(v0_1.clone(), v)
        })
    }
    pub fn method35(v0_1: string, v1_1: string) -> Arc<Async<()>> {
        getZero()
    }
    pub fn closure18(v0_1: string, v1_1: string) -> Arc<Async<()>> {
        File_system::method35(v0_1, v1_1)
    }
    pub fn closure17(unitVar: (), v0_1: string) -> Func1<string, Arc<Async<()>>> {
        Func1::new({
            let v0_1 = v0_1.clone();
            move |v: string| File_system::closure18(v0_1.clone(), v)
        })
    }
    pub fn method39(v0_1: string, v1_1: string) -> Arc<Async<bool>> {
        getZero()
    }
    pub fn method38(v0_1: string, v1_1: string) -> Arc<Async<bool>> {
        getZero()
    }
    pub fn method37(v0_1: string, v1_1: string) -> Arc<Async<()>> {
        getZero()
    }
    pub fn method36(v0_1: string, v1_1: string) -> Arc<Async<()>> {
        File_system::method37(v0_1, v1_1)
    }
    pub fn closure20(v0_1: string, v1_1: string) -> Arc<Async<()>> {
        File_system::method36(v0_1, v1_1)
    }
    pub fn closure19(unitVar: (), v0_1: string) -> Func1<string, Arc<Async<()>>> {
        Func1::new({
            let v0_1 = v0_1.clone();
            move |v: string| File_system::closure20(v0_1.clone(), v)
        })
    }
    pub fn method44(v0_1: std::io::Error) -> string {
        let v2_1: LrcPtr<File_system::Mut3> = LrcPtr::new(File_system::Mut3 {
            l0: MutCell::new(File_system::method18()),
        });
        let v5: std::string::String = format!("{:#?}", v0_1);
        let v38: () = {
            File_system::closure6(
                v2_1.clone(),
                fable_library_rust::String_::fromString(v5),
                (),
            );
            ()
        };
        v2_1.l0.get().clone()
    }
    pub fn closure22(unitVar: (), v0_1: std::io::Error) -> string {
        File_system::method44(v0_1)
    }
    pub fn method43() -> Func1<std::io::Error, string> {
        Func1::new(move |v: std::io::Error| File_system::closure22((), v))
    }
    pub fn closure23(unitVar: (), unitVar_1: ()) -> File_system::US9 {
        File_system::US9::US9_0
    }
    pub fn method45() -> Func0<File_system::US9> {
        Func0::new(move || File_system::closure23((), ()))
    }
    pub fn closure24(unitVar: (), v0_1: string) -> File_system::US9 {
        File_system::US9::US9_1(v0_1)
    }
    pub fn method46() -> Func1<string, File_system::US9> {
        Func1::new(move |v: string| File_system::closure24((), v))
    }
    pub fn method47() -> string {
        let v6: string = File_system::method17(getCharAt(toLower(string("Critical")), 0_i32));
        let v9: &str = inline_colorization::color_bright_red;
        let v12: &str = &*v6;
        let v35_1: &str = inline_colorization::color_reset;
        let v37: std::string::String = format!("{}{}{}", v9, v12, v35_1);
        fable_library_rust::String_::fromString(v37)
    }
    pub fn method49(v0_1: string) -> string {
        let v2_1: LrcPtr<File_system::Mut3> = LrcPtr::new(File_system::Mut3 {
            l0: MutCell::new(File_system::method18()),
        });
        let v9: () = {
            File_system::closure6(v2_1.clone(), string("{ "), ());
            ()
        };
        let v18_1: () = {
            File_system::closure6(v2_1.clone(), string("error\'"), ());
            ()
        };
        let v27_1: () = {
            File_system::closure6(v2_1.clone(), string(" = "), ());
            ()
        };
        let v35_1: () = {
            File_system::closure6(v2_1.clone(), v0_1, ());
            ()
        };
        let v44: () = {
            File_system::closure6(v2_1.clone(), string(" }"), ());
            ()
        };
        v2_1.l0.get().clone()
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
        v8: string,
    ) -> string {
        let v9: string = File_system::method49(v8);
        File_system::method23(sprintf!(
            "{} {} #{} {} / {}",
            v6,
            v7,
            v0_1.l0.get().clone(),
            string("file_system.file_delete"),
            v9
        ))
    }
    pub fn closure25(v0_1: string, unitVar: ()) {
        if File_system::method11(File_system::US0::US0_4) {
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
            ) = File_system::TraceState::trace_state()
                .get()
                .clone()
                .unwrap();
            let v24_1: Option<i64> = patternInput.5.clone();
            let v23_1: LrcPtr<File_system::Mut4> = patternInput.4.clone();
            let v22_1: LrcPtr<File_system::Mut3> = patternInput.3.clone();
            let v21_1: LrcPtr<File_system::Mut2> = patternInput.2.clone();
            let v20_1: LrcPtr<File_system::Mut1> = patternInput.1.clone();
            let v19_1: LrcPtr<File_system::Mut0> = patternInput.0.clone();
            File_system::method24(File_system::method48(
                v19_1.clone(),
                v20_1.clone(),
                v21_1.clone(),
                v22_1.clone(),
                v23_1.clone(),
                v24_1.clone(),
                File_system::method12(v19_1, v20_1, v21_1, v22_1, v23_1, v24_1),
                File_system::method47(),
                v0_1,
            ))
        };
    }
    pub fn method50() -> string {
        let v6: string = File_system::method17(getCharAt(toLower(string("Warning")), 0_i32));
        let v9: &str = inline_colorization::color_yellow;
        let v12: &str = &*v6;
        let v35_1: &str = inline_colorization::color_reset;
        let v37: std::string::String = format!("{}{}{}", v9, v12, v35_1);
        fable_library_rust::String_::fromString(v37)
    }
    pub fn method52(v0_1: string, v1_1: string) -> string {
        let v3: LrcPtr<File_system::Mut3> = LrcPtr::new(File_system::Mut3 {
            l0: MutCell::new(File_system::method18()),
        });
        let v10: () = {
            File_system::closure6(v3.clone(), string("{ "), ());
            ()
        };
        let v19_1: () = {
            File_system::closure6(v3.clone(), string("path"), ());
            ()
        };
        let v28_1: () = {
            File_system::closure6(v3.clone(), string(" = "), ());
            ()
        };
        let v36_1: () = {
            File_system::closure6(v3.clone(), v0_1, ());
            ()
        };
        let v45: () = {
            File_system::closure6(v3.clone(), string("; "), ());
            ()
        };
        let v54: () = {
            File_system::closure6(v3.clone(), string("ex"), ());
            ()
        };
        let v62: () = {
            File_system::closure6(v3.clone(), string(" = "), ());
            ()
        };
        let v70: () = {
            File_system::closure6(v3.clone(), v1_1, ());
            ()
        };
        let v79: () = {
            File_system::closure6(v3.clone(), string(" }"), ());
            ()
        };
        v3.l0.get().clone()
    }
    pub fn method51(
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
        let v10: string = File_system::method52(v8, v9);
        File_system::method23(sprintf!(
            "{} {} #{} {} / {}",
            v6,
            v7,
            v0_1.l0.get().clone(),
            string("delete_file_async"),
            v10
        ))
    }
    pub fn closure26(v0_1: string, v1_1: LrcPtr<Exception>, unitVar: ()) {
        if File_system::method11(File_system::US0::US0_3) {
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
            ) = File_system::TraceState::trace_state()
                .get()
                .clone()
                .unwrap();
            let v25_1: Option<i64> = patternInput.5.clone();
            let v24_1: LrcPtr<File_system::Mut4> = patternInput.4.clone();
            let v23_1: LrcPtr<File_system::Mut3> = patternInput.3.clone();
            let v22_1: LrcPtr<File_system::Mut2> = patternInput.2.clone();
            let v21_1: LrcPtr<File_system::Mut1> = patternInput.1.clone();
            let v20_1: LrcPtr<File_system::Mut0> = patternInput.0.clone();
            File_system::method24(File_system::method51(
                v20_1.clone(),
                v21_1.clone(),
                v22_1.clone(),
                v23_1.clone(),
                v24_1.clone(),
                v25_1.clone(),
                File_system::method12(v20_1, v21_1, v22_1, v23_1, v24_1, v25_1),
                File_system::method50(),
                File_system::method20(v0_1),
                sprintf!("{:?}", v1_1),
            ))
        };
    }
    pub fn method42(v0_1: string, v1_1: i64) -> Arc<Async<i64>> {
        getZero()
    }
    pub fn method41(v0_1: string, v1_1: i64) -> Arc<Async<i64>> {
        getZero()
    }
    pub fn method40(v0_1: string) -> Arc<Async<i64>> {
        File_system::method41(v0_1, 0_i64)
    }
    pub fn closure21(unitVar: (), v0_1: string) -> Arc<Async<i64>> {
        File_system::method40(v0_1)
    }
    pub fn method56(v0_1: string, v1_1: string) {
        ();
    }
    pub fn method58(v0_1: string, v1_1: string, v2_1: string) -> string {
        let v4: LrcPtr<File_system::Mut3> = LrcPtr::new(File_system::Mut3 {
            l0: MutCell::new(File_system::method18()),
        });
        let v11: () = {
            File_system::closure6(v4.clone(), string("{ "), ());
            ()
        };
        let v20_1: () = {
            File_system::closure6(v4.clone(), string("old_path"), ());
            ()
        };
        let v29_1: () = {
            File_system::closure6(v4.clone(), string(" = "), ());
            ()
        };
        let v37: () = {
            File_system::closure6(v4.clone(), v0_1, ());
            ()
        };
        let v46: () = {
            File_system::closure6(v4.clone(), string("; "), ());
            ()
        };
        let v55: () = {
            File_system::closure6(v4.clone(), string("new_path"), ());
            ()
        };
        let v63: () = {
            File_system::closure6(v4.clone(), string(" = "), ());
            ()
        };
        let v71: () = {
            File_system::closure6(v4.clone(), v1_1, ());
            ()
        };
        let v79: () = {
            File_system::closure6(v4.clone(), string("; "), ());
            ()
        };
        let v88: () = {
            File_system::closure6(v4.clone(), string("ex"), ());
            ()
        };
        let v96: () = {
            File_system::closure6(v4.clone(), string(" = "), ());
            ()
        };
        let v104: () = {
            File_system::closure6(v4.clone(), v2_1, ());
            ()
        };
        let v113: () = {
            File_system::closure6(v4.clone(), string(" }"), ());
            ()
        };
        v4.l0.get().clone()
    }
    pub fn method57(
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
        v10: string,
    ) -> string {
        let v11: string = File_system::method58(v8, v9, v10);
        File_system::method23(sprintf!(
            "{} {} #{} {} / {}",
            v6,
            v7,
            v0_1.l0.get().clone(),
            string("move_file_async"),
            v11
        ))
    }
    pub fn closure29(v0_1: string, v1_1: string, v2_1: LrcPtr<Exception>, unitVar: ()) {
        if File_system::method11(File_system::US0::US0_3) {
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
            ) = File_system::TraceState::trace_state()
                .get()
                .clone()
                .unwrap();
            let v26_1: Option<i64> = patternInput.5.clone();
            let v25_1: LrcPtr<File_system::Mut4> = patternInput.4.clone();
            let v24_1: LrcPtr<File_system::Mut3> = patternInput.3.clone();
            let v23_1: LrcPtr<File_system::Mut2> = patternInput.2.clone();
            let v22_1: LrcPtr<File_system::Mut1> = patternInput.1.clone();
            let v21_1: LrcPtr<File_system::Mut0> = patternInput.0.clone();
            File_system::method24(File_system::method57(
                v21_1.clone(),
                v22_1.clone(),
                v23_1.clone(),
                v24_1.clone(),
                v25_1.clone(),
                v26_1.clone(),
                File_system::method12(v21_1, v22_1, v23_1, v24_1, v25_1, v26_1),
                File_system::method50(),
                File_system::method20(v1_1),
                File_system::method20(v0_1),
                sprintf!("{:?}", v2_1),
            ))
        };
    }
    pub fn method55(v0_1: string, v1_1: string, v2_1: i64) -> Arc<Async<i64>> {
        getZero()
    }
    pub fn method54(v0_1: string, v1_1: string, v2_1: i64) -> Arc<Async<i64>> {
        getZero()
    }
    pub fn method53(v0_1: string, v1_1: string) -> Arc<Async<i64>> {
        File_system::method54(v0_1, v1_1, 0_i64)
    }
    pub fn closure28(v0_1: string, v1_1: string) -> Arc<Async<i64>> {
        File_system::method53(v0_1, v1_1)
    }
    pub fn closure27(unitVar: (), v0_1: string) -> Func1<string, Arc<Async<i64>>> {
        Func1::new({
            let v0_1 = v0_1.clone();
            move |v: string| File_system::closure28(v0_1.clone(), v)
        })
    }
    pub fn closure31(unitVar: (), v0_1: i64) -> File_system::US10 {
        File_system::US10::US10_0(v0_1)
    }
    pub fn method65() -> Func1<i64, File_system::US10> {
        Func1::new(move |v: i64| File_system::closure31((), v))
    }
    pub fn closure32(unitVar: (), v0_1: LrcPtr<Exception>) -> File_system::US10 {
        File_system::US10::US10_1(v0_1)
    }
    pub fn method66() -> Func1<LrcPtr<Exception>, File_system::US10> {
        Func1::new(move |v: LrcPtr<Exception>| File_system::closure32((), v))
    }
    pub fn method64(
        v0_1: Arc<Async<LrcPtr<Choice_2<i64, LrcPtr<Exception>>>>>,
    ) -> Arc<Async<File_system::US10>> {
        getZero()
    }
    pub fn method67(v0_1: Arc<Async<File_system::US10>>) -> Arc<Async<File_system::US11>> {
        getZero()
    }
    pub fn method69() -> string {
        let v6: string = File_system::method17(getCharAt(toLower(string("Verbose")), 0_i32));
        let v9: &str = inline_colorization::color_bright_black;
        let v12: &str = &*v6;
        let v35_1: &str = inline_colorization::color_reset;
        let v37: std::string::String = format!("{}{}{}", v9, v12, v35_1);
        fable_library_rust::String_::fromString(v37)
    }
    pub fn method71(v0_1: i32) -> string {
        let v2_1: LrcPtr<File_system::Mut3> = LrcPtr::new(File_system::Mut3 {
            l0: MutCell::new(File_system::method18()),
        });
        let v9: () = {
            File_system::closure6(v2_1.clone(), string("{ "), ());
            ()
        };
        let v18_1: () = {
            File_system::closure6(v2_1.clone(), string("timeout"), ());
            ()
        };
        let v27_1: () = {
            File_system::closure6(v2_1.clone(), string(" = "), ());
            ()
        };
        let v35_1: () = {
            File_system::closure6(v2_1.clone(), sprintf!("{}", v0_1), ());
            ()
        };
        let v44: () = {
            File_system::closure6(v2_1.clone(), string(" }"), ());
            ()
        };
        v2_1.l0.get().clone()
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
        v8: i32,
    ) -> string {
        let v9: string = File_system::method71(v8);
        File_system::method23(sprintf!(
            "{} {} #{} {} / {}",
            v6,
            v7,
            v0_1.l0.get().clone(),
            string("async.run_with_timeout_async"),
            v9
        ))
    }
    pub fn closure33(v0_1: i32, unitVar: ()) {
        if File_system::method11(File_system::US0::US0_0) {
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
            ) = File_system::TraceState::trace_state()
                .get()
                .clone()
                .unwrap();
            let v24_1: Option<i64> = patternInput.5.clone();
            let v23_1: LrcPtr<File_system::Mut4> = patternInput.4.clone();
            let v22_1: LrcPtr<File_system::Mut3> = patternInput.3.clone();
            let v21_1: LrcPtr<File_system::Mut2> = patternInput.2.clone();
            let v20_1: LrcPtr<File_system::Mut1> = patternInput.1.clone();
            let v19_1: LrcPtr<File_system::Mut0> = patternInput.0.clone();
            File_system::method24(File_system::method70(
                v19_1.clone(),
                v20_1.clone(),
                v21_1.clone(),
                v22_1.clone(),
                v23_1.clone(),
                v24_1.clone(),
                File_system::method12(v19_1, v20_1, v21_1, v22_1, v23_1, v24_1),
                File_system::method69(),
                v0_1,
            ))
        };
    }
    pub fn method73(v0_1: i32, v1_1: string) -> string {
        let v3: LrcPtr<File_system::Mut3> = LrcPtr::new(File_system::Mut3 {
            l0: MutCell::new(File_system::method18()),
        });
        let v10: () = {
            File_system::closure6(v3.clone(), string("{ "), ());
            ()
        };
        let v19_1: () = {
            File_system::closure6(v3.clone(), string("timeout"), ());
            ()
        };
        let v28_1: () = {
            File_system::closure6(v3.clone(), string(" = "), ());
            ()
        };
        let v36_1: () = {
            File_system::closure6(v3.clone(), sprintf!("{}", v0_1), ());
            ()
        };
        let v45: () = {
            File_system::closure6(v3.clone(), string("; "), ());
            ()
        };
        let v54: () = {
            File_system::closure6(v3.clone(), string("ex"), ());
            ()
        };
        let v62: () = {
            File_system::closure6(v3.clone(), string(" = "), ());
            ()
        };
        let v70: () = {
            File_system::closure6(v3.clone(), v1_1, ());
            ()
        };
        let v79: () = {
            File_system::closure6(v3.clone(), string(" }"), ());
            ()
        };
        v3.l0.get().clone()
    }
    pub fn method72(
        v0_1: LrcPtr<File_system::Mut0>,
        v1_1: LrcPtr<File_system::Mut1>,
        v2_1: LrcPtr<File_system::Mut2>,
        v3: LrcPtr<File_system::Mut3>,
        v4: LrcPtr<File_system::Mut4>,
        v5: Option<i64>,
        v6: string,
        v7: string,
        v8: i32,
        v9: string,
    ) -> string {
        let v10: string = File_system::method73(v8, v9);
        File_system::method23(sprintf!(
            "{} {} #{} {} / {}",
            v6,
            v7,
            v0_1.l0.get().clone(),
            string("async.run_with_timeout_async**"),
            v10
        ))
    }
    pub fn closure34(v0_1: i32, v1_1: LrcPtr<Exception>, unitVar: ()) {
        if File_system::method11(File_system::US0::US0_4) {
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
            ) = File_system::TraceState::trace_state()
                .get()
                .clone()
                .unwrap();
            let v25_1: Option<i64> = patternInput.5.clone();
            let v24_1: LrcPtr<File_system::Mut4> = patternInput.4.clone();
            let v23_1: LrcPtr<File_system::Mut3> = patternInput.3.clone();
            let v22_1: LrcPtr<File_system::Mut2> = patternInput.2.clone();
            let v21_1: LrcPtr<File_system::Mut1> = patternInput.1.clone();
            let v20_1: LrcPtr<File_system::Mut0> = patternInput.0.clone();
            File_system::method24(File_system::method72(
                v20_1.clone(),
                v21_1.clone(),
                v22_1.clone(),
                v23_1.clone(),
                v24_1.clone(),
                v25_1.clone(),
                File_system::method12(v20_1, v21_1, v22_1, v23_1, v24_1, v25_1),
                File_system::method47(),
                v0_1,
                sprintf!("{:?}", v1_1),
            ))
        };
    }
    pub fn method68(
        v0_1: i32,
        v1_1: Arc<Async<File_system::US11>>,
    ) -> Arc<Async<File_system::US2>> {
        getZero()
    }
    pub fn method63(v0_1: Arc<Async<i64>>, v1_1: i32) -> Arc<Async<File_system::US2>> {
        getZero()
    }
    pub fn method62(v0_1: i32, v1_1: Arc<Async<i64>>) -> Arc<Async<File_system::US2>> {
        File_system::method63(v1_1, v0_1)
    }
    pub fn method74(v0_1: Arc<Async<string>>) -> Arc<Async<Option<string>>> {
        getZero()
    }
    pub fn method76(v0_1: i64, v1_1: string) -> string {
        let v3: LrcPtr<File_system::Mut3> = LrcPtr::new(File_system::Mut3 {
            l0: MutCell::new(File_system::method18()),
        });
        let v10: () = {
            File_system::closure6(v3.clone(), string("{ "), ());
            ()
        };
        let v19_1: () = {
            File_system::closure6(v3.clone(), string("retry"), ());
            ()
        };
        let v28_1: () = {
            File_system::closure6(v3.clone(), string(" = "), ());
            ()
        };
        let v36_1: () = {
            File_system::closure6(v3.clone(), sprintf!("{}", v0_1), ());
            ()
        };
        let v45: () = {
            File_system::closure6(v3.clone(), string("; "), ());
            ()
        };
        let v54: () = {
            File_system::closure6(v3.clone(), string("ex"), ());
            ()
        };
        let v62: () = {
            File_system::closure6(v3.clone(), string(" = "), ());
            ()
        };
        let v70: () = {
            File_system::closure6(v3.clone(), v1_1, ());
            ()
        };
        let v79: () = {
            File_system::closure6(v3.clone(), string(" }"), ());
            ()
        };
        v3.l0.get().clone()
    }
    pub fn method75(
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
        let v10: string = File_system::method76(v8, v9);
        File_system::method23(sprintf!(
            "{} {} #{} {} / {}",
            v6,
            v7,
            v0_1.l0.get().clone(),
            string("file_system.read_all_text_retry_async"),
            v10
        ))
    }
    pub fn closure35(v0_1: i64, v1_1: LrcPtr<Exception>, unitVar: ()) {
        if File_system::method11(File_system::US0::US0_1) {
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
            ) = File_system::TraceState::trace_state()
                .get()
                .clone()
                .unwrap();
            let v25_1: Option<i64> = patternInput.5.clone();
            let v24_1: LrcPtr<File_system::Mut4> = patternInput.4.clone();
            let v23_1: LrcPtr<File_system::Mut3> = patternInput.3.clone();
            let v22_1: LrcPtr<File_system::Mut2> = patternInput.2.clone();
            let v21_1: LrcPtr<File_system::Mut1> = patternInput.1.clone();
            let v20_1: LrcPtr<File_system::Mut0> = patternInput.0.clone();
            File_system::method24(File_system::method75(
                v20_1.clone(),
                v21_1.clone(),
                v22_1.clone(),
                v23_1.clone(),
                v24_1.clone(),
                v25_1.clone(),
                File_system::method12(v20_1, v21_1, v22_1, v23_1, v24_1, v25_1),
                File_system::method16(),
                v0_1,
                sprintf!("{:?}", v1_1),
            ))
        };
    }
    pub fn method61(v0_1: string, v1_1: i64) -> Arc<Async<Option<string>>> {
        getZero()
    }
    pub fn method60(v0_1: string, v1_1: i64) -> Arc<Async<Option<string>>> {
        File_system::method61(v0_1, v1_1)
    }
    pub fn method59(v0_1: string) -> Arc<Async<Option<string>>> {
        File_system::method60(v0_1, 0_i64)
    }
    pub fn closure30(unitVar: (), v0_1: string) -> Arc<Async<Option<string>>> {
        File_system::method59(v0_1)
    }
    pub fn closure37(unitVar: (), v0_1: chrono::DateTime<chrono::Utc>) -> File_system::US12 {
        File_system::US12::US12_0(v0_1)
    }
    pub fn method79() -> Func1<chrono::DateTime<chrono::Utc>, File_system::US12> {
        Func1::new(move |v: chrono::DateTime<chrono::Utc>| File_system::closure37((), v))
    }
    pub fn method80() -> string {
        string("hh:mm")
    }
    pub fn method81() -> string {
        string("yyyyMMdd-HHmm-ssff-ffff-f")
    }
    pub fn method82() -> string {
        string("hhmm")
    }
    pub fn method78(v0_1: Guid, v1_1: DateTime) -> Guid {
        let v7: DateTime = {
            let _arg: DateTime = DateTime::unixEpoch();
            _arg.toUniversalTime()
        };
        let v15: DateTime = {
            let _arg_1: DateTime = DateTime::specifyKind(v1_1, 2_i32);
            _arg_1.toUniversalTime()
        };
        let v91: i64 = ((v15.ticks()) - (v7.ticks())) / 10_i64;
        let v93: Option<chrono::DateTime<chrono::Utc>> =
            chrono::DateTime::from_timestamp_micros(v91);
        let v107: File_system::US12 =
            defaultValue(File_system::US12::US12_1, map(File_system::method79(), v93));
        let v127: File_system::US5 = match &v107 {
            File_system::US12::US12_0(v107_0_0) => {
                let v113: chrono::NaiveDateTime = match &v107 {
                    File_system::US12::US12_0(x) => x.clone(),
                    _ => unreachable!(),
                }
                .clone()
                .naive_utc();
                let v115: chrono::DateTime<chrono::Local> =
                    chrono::offset::TimeZone::from_utc_datetime(&chrono::Local, &v113);
                let v117: string = string("r#\"%Y%m%d-%H%M-%S%f\"#");
                let v118: &str = r#"%Y%m%d-%H%M-%S%f"#;
                let v120: std::string::String = v115.format(v118).to_string();
                let v122: string = fable_library_rust::String_::fromString(v120);
                File_system::US5::US5_0(sprintf!(
                    "{}-{}-{}",
                    getSlice(v122.clone(), Some(0_i32), Some(17_i32)),
                    getSlice(v122.clone(), Some(18_i32), Some(21_i32)),
                    getCharAt(v122, 22_i32)
                ))
            }
            _ => File_system::US5::US5_1,
        };
        let v131: string = match &v127 {
            File_system::US5::US5_0(v127_0_0) => match &v127 {
                File_system::US5::US5_0(x) => x.clone(),
                _ => unreachable!(),
            }
            .clone(),
            _ => string(""),
        };
        let v134: LrcPtr<TimeZoneInfo> = std::sync::Arc::new(chrono::FixedOffset::local_minus_utc(
            chrono::Local::now().offset(),
        ) as i64);
        let v157: i64 = v15.ticks();
        let v188: string =
            string("chrono::FixedOffset::local_minus_utc(&chrono::DateTime::timezone(&chrono::DateTime::fixed_offset(&chrono::DateTime::from_timestamp_nanos($1))))");
        let v299: TimeSpan = TimeSpan::new_ticks(chrono::FixedOffset::local_minus_utc(
            &chrono::DateTime::timezone(&chrono::DateTime::fixed_offset(
                &chrono::DateTime::from_timestamp_nanos(v157),
            )),
        ) as i64);
        let v312: u8 = if (v299.hours()) > 0_i32 { 1_u8 } else { 0_u8 };
        let v313: string = File_system::method80();
        let v332: string = v299.to_string(v313);
        let v337: string = sprintf!(
            "{}{}{}",
            v312,
            getSlice(v332.clone(), Some(0_i32), Some(1_i32)),
            getSlice(v332, Some(3_i32), Some(4_i32))
        );
        let v339: string = toString(v0_1);
        parse(concat(new_array(&[
            v131.clone(),
            v337.clone(),
            getSlice(
                v339.clone(),
                Some((length(v131)) + (length(v337))),
                Some((length(v339)) - 1_i32),
            ),
        ])))
    }
    pub fn method84() -> string {
        let v2_1: std::path::PathBuf = std::env::temp_dir();
        let v5: std::path::Display = v2_1.display();
        let v29_1: std::string::String = format!("{}", v5);
        fable_library_rust::String_::fromString(v29_1)
    }
    pub fn method85() -> string {
        string("!create_temp_path_")
    }
    pub fn method86(v0_1: string, v1_1: string) -> string {
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
    pub fn method88() -> string {
        string("CARGO_PKG_NAME")
    }
    pub fn method87() -> string {
        File_system::method2(File_system::method88())
    }
    pub fn method83(v0_1: Guid) -> string {
        File_system::method86(
            File_system::method86(
                File_system::method86(File_system::method84(), File_system::method85()),
                File_system::method87(),
            ),
            toString(v0_1),
        )
    }
    pub fn method77() -> string {
        let v2_1: DateTime = DateTime::now();
        File_system::method83(File_system::method78(new_guid(), v2_1))
    }
    pub fn closure36(unitVar: (), unitVar_1: ()) -> string {
        File_system::method77()
    }
    pub fn closure39(unitVar: (), v0_1: std::io::Error) -> std::string::String {
        format!("{}", v0_1)
    }
    pub fn method90() -> Func1<std::io::Error, std::string::String> {
        Func1::new(move |v: std::io::Error| File_system::closure39((), v))
    }
    pub fn closure40(unitVar: (), unitVar_1: ()) -> File_system::US13 {
        File_system::US13::US13_0
    }
    pub fn method91() -> Func0<File_system::US13> {
        Func0::new(move || File_system::closure40((), ()))
    }
    pub fn closure41(unitVar: (), v0_1: std::string::String) -> File_system::US13 {
        File_system::US13::US13_1(v0_1)
    }
    pub fn method92() -> Func1<std::string::String, File_system::US13> {
        Func1::new(move |v: std::string::String| File_system::closure41((), v))
    }
    pub fn method94(v0_1: string, v1_1: std::string::String) -> string {
        let v3: LrcPtr<File_system::Mut3> = LrcPtr::new(File_system::Mut3 {
            l0: MutCell::new(File_system::method18()),
        });
        let v10: () = {
            File_system::closure6(v3.clone(), string("{ "), ());
            ()
        };
        let v19_1: () = {
            File_system::closure6(v3.clone(), string("dir"), ());
            ()
        };
        let v28_1: () = {
            File_system::closure6(v3.clone(), string(" = "), ());
            ()
        };
        let v36_1: () = {
            File_system::closure6(v3.clone(), v0_1, ());
            ()
        };
        let v45: () = {
            File_system::closure6(v3.clone(), string("; "), ());
            ()
        };
        let v54: () = {
            File_system::closure6(v3.clone(), string("error"), ());
            ()
        };
        let v62: () = {
            File_system::closure6(v3.clone(), string(" = "), ());
            ()
        };
        let v67: std::string::String = format!("{:#?}", v1_1);
        let v100: () = {
            File_system::closure6(v3.clone(), fable_library_rust::String_::fromString(v67), ());
            ()
        };
        let v109: () = {
            File_system::closure6(v3.clone(), string(" }"), ());
            ()
        };
        v3.l0.get().clone()
    }
    pub fn method93(
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
        let v10: string = File_system::method94(v8, v9);
        File_system::method23(sprintf!(
            "{} {} #{} {} / {}",
            v6,
            v7,
            v0_1.l0.get().clone(),
            string("file_system.create_dir"),
            v10
        ))
    }
    pub fn closure42(v0_1: string, v1_1: std::string::String, unitVar: ()) {
        if File_system::method11(File_system::US0::US0_4) {
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
            ) = File_system::TraceState::trace_state()
                .get()
                .clone()
                .unwrap();
            let v25_1: Option<i64> = patternInput.5.clone();
            let v24_1: LrcPtr<File_system::Mut4> = patternInput.4.clone();
            let v23_1: LrcPtr<File_system::Mut3> = patternInput.3.clone();
            let v22_1: LrcPtr<File_system::Mut2> = patternInput.2.clone();
            let v21_1: LrcPtr<File_system::Mut1> = patternInput.1.clone();
            let v20_1: LrcPtr<File_system::Mut0> = patternInput.0.clone();
            File_system::method24(File_system::method93(
                v20_1.clone(),
                v21_1.clone(),
                v22_1.clone(),
                v23_1.clone(),
                v24_1.clone(),
                v25_1.clone(),
                File_system::method12(v20_1, v21_1, v22_1, v23_1, v24_1, v25_1),
                File_system::method47(),
                v0_1,
                v1_1,
            ))
        };
    }
    pub fn method96(v0_1: string) -> string {
        let v2_1: LrcPtr<File_system::Mut3> = LrcPtr::new(File_system::Mut3 {
            l0: MutCell::new(File_system::method18()),
        });
        let v9: () = {
            File_system::closure6(v2_1.clone(), string("{ "), ());
            ()
        };
        let v18_1: () = {
            File_system::closure6(v2_1.clone(), string("dir"), ());
            ()
        };
        let v27_1: () = {
            File_system::closure6(v2_1.clone(), string(" = "), ());
            ()
        };
        let v35_1: () = {
            File_system::closure6(v2_1.clone(), v0_1, ());
            ()
        };
        let v44: () = {
            File_system::closure6(v2_1.clone(), string(" }"), ());
            ()
        };
        v2_1.l0.get().clone()
    }
    pub fn method95(
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
        let v9: string = File_system::method96(v8);
        File_system::method23(sprintf!(
            "{} {} #{} {} / {}",
            v6,
            v7,
            v0_1.l0.get().clone(),
            string("file_system.create_dir"),
            v9
        ))
    }
    pub fn closure43(v0_1: string, unitVar: ()) {
        if File_system::method11(File_system::US0::US0_0) {
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
            ) = File_system::TraceState::trace_state()
                .get()
                .clone()
                .unwrap();
            let v24_1: Option<i64> = patternInput.5.clone();
            let v23_1: LrcPtr<File_system::Mut4> = patternInput.4.clone();
            let v22_1: LrcPtr<File_system::Mut3> = patternInput.3.clone();
            let v21_1: LrcPtr<File_system::Mut2> = patternInput.2.clone();
            let v20_1: LrcPtr<File_system::Mut1> = patternInput.1.clone();
            let v19_1: LrcPtr<File_system::Mut0> = patternInput.0.clone();
            File_system::method24(File_system::method95(
                v19_1.clone(),
                v20_1.clone(),
                v21_1.clone(),
                v22_1.clone(),
                v23_1.clone(),
                v24_1.clone(),
                File_system::method12(v19_1, v20_1, v21_1, v22_1, v23_1, v24_1),
                File_system::method69(),
                v0_1,
            ))
        };
    }
    pub fn closure44(v0_1: string, unitVar: ()) {
        File_system::method9(true, v0_1);
    }
    pub fn method97(v0_1: string) -> Func0<()> {
        Func0::new({
            let v0_1 = v0_1.clone();
            move || File_system::closure44(v0_1.clone(), ())
        })
    }
    pub fn method98(v0_1: string) -> Func0<()> {
        Func0::new({
            let v0_1 = v0_1.clone();
            move || File_system::closure44(v0_1.clone(), ())
        })
    }
    pub fn method99(v0_1: string) -> bool {
        unbox::<bool>(&getZero())
    }
    pub fn method101(v0_1: string, v1_1: string) -> string {
        let v3: LrcPtr<File_system::Mut3> = LrcPtr::new(File_system::Mut3 {
            l0: MutCell::new(File_system::method18()),
        });
        let v10: () = {
            File_system::closure6(v3.clone(), string("{ "), ());
            ()
        };
        let v19_1: () = {
            File_system::closure6(v3.clone(), string("dir"), ());
            ()
        };
        let v28_1: () = {
            File_system::closure6(v3.clone(), string(" = "), ());
            ()
        };
        let v36_1: () = {
            File_system::closure6(v3.clone(), v0_1, ());
            ()
        };
        let v45: () = {
            File_system::closure6(v3.clone(), string("; "), ());
            ()
        };
        let v54: () = {
            File_system::closure6(v3.clone(), string("result"), ());
            ()
        };
        let v62: () = {
            File_system::closure6(v3.clone(), string(" = "), ());
            ()
        };
        let v70: () = {
            File_system::closure6(v3.clone(), v1_1, ());
            ()
        };
        let v79: () = {
            File_system::closure6(v3.clone(), string(" }"), ());
            ()
        };
        v3.l0.get().clone()
    }
    pub fn method100(
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
        let v10: string = File_system::method101(v8, v9);
        File_system::method23(sprintf!(
            "{} {} #{} {} / {}",
            v6,
            v7,
            v0_1.l0.get().clone(),
            string("file_system.create_dir"),
            v10
        ))
    }
    pub fn closure45(v0_1: string, v1_1: string, unitVar: ()) {
        if File_system::method11(File_system::US0::US0_1) {
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
            ) = File_system::TraceState::trace_state()
                .get()
                .clone()
                .unwrap();
            let v25_1: Option<i64> = patternInput.5.clone();
            let v24_1: LrcPtr<File_system::Mut4> = patternInput.4.clone();
            let v23_1: LrcPtr<File_system::Mut3> = patternInput.3.clone();
            let v22_1: LrcPtr<File_system::Mut2> = patternInput.2.clone();
            let v21_1: LrcPtr<File_system::Mut1> = patternInput.1.clone();
            let v20_1: LrcPtr<File_system::Mut0> = patternInput.0.clone();
            File_system::method24(File_system::method100(
                v20_1.clone(),
                v21_1.clone(),
                v22_1.clone(),
                v23_1.clone(),
                v24_1.clone(),
                v25_1.clone(),
                File_system::method12(v20_1, v21_1, v22_1, v23_1, v24_1, v25_1),
                File_system::method16(),
                v0_1,
                v1_1,
            ))
        };
    }
    pub fn closure46(v0_1: string, unitVar: ()) {
        let v1_1: Arc<Async<i64>> = File_system::method6(v0_1);
        let v3: Arc<Async<()>> = getZero();
        getZero::<()>();
        ()
    }
    pub fn method102(v0_1: string) -> Func0<()> {
        Func0::new({
            let v0_1 = v0_1.clone();
            move || File_system::closure46(v0_1.clone(), ())
        })
    }
    pub fn method103(v0_1: string) -> Func0<()> {
        Func0::new({
            let v0_1 = v0_1.clone();
            move || File_system::closure46(v0_1.clone(), ())
        })
    }
    pub fn method89(v0_1: string) -> LrcPtr<dyn IDisposable> {
        let v3: Result<(), std::io::Error> = std::fs::create_dir_all(&*v0_1.clone());
        let v4 = File_system::method90();
        let v16_1: Result<(), std::string::String> = v3.map_err(|x| v4(x));
        let v19_1 = File_system::method91();
        let v20_1 = File_system::method92();
        let v21_1: File_system::US13 = match &v16_1 {
            Err(v16_1_1_0) => v20_1(v16_1_1_0.clone()),
            _ => v19_1(),
        };
        match &v21_1 {
            File_system::US13::US13_0 => {
                let v24_1: () = {
                    File_system::closure43(v0_1.clone(), ());
                    ()
                };
                ()
            }
            File_system::US13::US13_1(v21_1_1_0) => {
                let v67: () = {
                    File_system::closure42(
                        v0_1.clone(),
                        match &v21_1 {
                            File_system::US13::US13_1(x) => x.clone(),
                            _ => unreachable!(),
                        }
                        .clone(),
                        (),
                    );
                    ()
                };
                ()
            }
        }
        {
            let v108 = File_system::method97(v0_1.clone());
            interface_cast!(
                File_system::Disposable::_ctor__3A5B6456(Func0::new({
                    let v108 = v108.clone();
                    move || v108.clone()()
                })),
                Lrc<dyn IDisposable>,
            )
        }
    }
    pub fn closure38(unitVar: (), unitVar_1: ()) -> (string, LrcPtr<dyn IDisposable>) {
        let v0_1: string = File_system::method77();
        (v0_1.clone(), File_system::method89(v0_1))
    }
    pub fn closure48(v0_1: i32, v1_1: string, v2_1: i32, v3: string) -> string {
        if (v2_1) >= (v0_1) {
            v3.clone()
        } else {
            (File_system::method105(v0_1, v1_1.clone(), (v2_1) + 1_i32))(append((v3), (v1_1)))
        }
    }
    pub fn method105(v0_1: i32, v1_1: string, v2_1: i32) -> Func1<string, string> {
        Func1::new({
            let v0_1 = v0_1.clone();
            let v1_1 = v1_1.clone();
            let v2_1 = v2_1.clone();
            move |v: string| File_system::closure48(v0_1, v1_1.clone(), v2_1, v)
        })
    }
    pub fn method104(v0_1: string) -> Guid {
        let v2_1: string = ofChar('0');
        let v11: string = append(
            ((File_system::method105(32_i32 - (length(v0_1.clone())), v2_1, 0_i32))(string(""))),
            (v0_1),
        );
        parse(sprintf!(
            "{}-{}-{}-{}-{}",
            getSlice(v11.clone(), Some(0_i32), Some((8_i32) - 1_i32)),
            getSlice(v11.clone(), Some(8_i32), Some((12_i32) - 1_i32)),
            getSlice(v11.clone(), Some(12_i32), Some((16_i32) - 1_i32)),
            getSlice(v11.clone(), Some(16_i32), Some((20_i32) - 1_i32)),
            getSlice(v11, Some(20_i32), Some((32_i32) - 1_i32))
        ))
    }
    pub fn closure47(unitVar: (), v0_1: string) -> (string, LrcPtr<dyn IDisposable>) {
        let v2_1: string = File_system::method83(File_system::method104(v0_1));
        (v2_1.clone(), File_system::method89(v2_1))
    }
    pub fn closure49(unitVar: (), unitVar_1: ()) -> string {
        string("C:\\home\\git\\polyglot\\lib\\spiral")
    }
    pub fn closure51(unitVar: (), v0_1: std::path::PathBuf) -> File_system::US14 {
        File_system::US14::US14_0(v0_1)
    }
    pub fn method109() -> Func1<std::path::PathBuf, File_system::US14> {
        Func1::new(move |v: std::path::PathBuf| File_system::closure51((), v))
    }
    pub fn closure52(unitVar: (), v0_1: string) -> File_system::US14 {
        File_system::US14::US14_1(v0_1)
    }
    pub fn method110() -> Func1<string, File_system::US14> {
        Func1::new(move |v: string| File_system::closure52((), v))
    }
    pub fn method113(v0_1: string) -> Option<string> {
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
        _optionm_map_
    }
    pub fn method114(v0_1: string) -> string {
        let v2_1: LrcPtr<File_system::Mut3> = LrcPtr::new(File_system::Mut3 {
            l0: MutCell::new(File_system::method18()),
        });
        let v8: () = {
            File_system::closure6(v2_1.clone(), v0_1, ());
            ()
        };
        v2_1.l0.get().clone()
    }
    pub fn method112(
        v0_1: string,
        v1_1: Func2<u8, string, Result<std::path::PathBuf, std::io::Error>>,
        v2_1: u8,
        v3: string,
        v4: string,
    ) -> Result<std::path::PathBuf, std::io::Error> {
        let v5: string = File_system::method20(v4.clone());
        let v6: Option<string> = File_system::method113(v4.clone());
        let v20_1: File_system::US5 =
            defaultValue(File_system::US5::US5_1, map(File_system::method5(), v6));
        let v24_1: string = File_system::method114(v3);
        if (v2_1) >= 11_u8 {
            let v28_1: string = append(
                string("file_system.read_link / "),
                sprintf!(
                    "path: {} / n: {} / path\': {} / name: {}",
                    v0_1.clone(),
                    v2_1,
                    v4.clone(),
                    v5.clone()
                ),
            );
            let v31_1: std::io::Error = std::io::Error::new(std::io::ErrorKind::Other, &*v28_1);
            Err(v31_1)
        } else {
            if let File_system::US5::US5_0(v20_1_0_0) = &v20_1 {
                if (v4.clone()) != string("") {
                    let v74: Result<std::path::PathBuf, std::io::Error> =
                        v1_1((v2_1) + 1_u8, v20_1_0_0.clone());
                    let v75 = File_system::method43();
                    let v87: Result<std::path::PathBuf, string> = v74.map_err(|x| v75(x));
                    let v90 = File_system::method109();
                    let v91 = File_system::method110();
                    let v92: File_system::US14 = match &v87 {
                        Err(v87_1_0) => v91(v87_1_0.clone()),
                        Ok(v87_0_0) => v90(v87_0_0.clone()),
                    };
                    match &v92 {
                        File_system::US14::US14_0(v92_0_0) => {
                            let v121: string = File_system::method86(
                                toString(v92_0_0.clone().display()),
                                v5.clone(),
                            );
                            let v124: &str = &*v121;
                            let v148: std::string::String = String::from(v124);
                            let v172: std::path::PathBuf = std::path::PathBuf::from(v148);
                            Ok(v172)
                        }
                        File_system::US14::US14_1(v92_1_0) => {
                            let v211: string = append(
                                string("file_system.read_link / "),
                                sprintf!(
                                    "error\': {} / error: {} / name: {}",
                                    v92_1_0.clone(),
                                    v24_1.clone(),
                                    v5.clone()
                                ),
                            );
                            let v214: std::io::Error =
                                std::io::Error::new(std::io::ErrorKind::Other, &*v211);
                            Err(v214)
                        }
                    }
                } else {
                    let v254: string =
                        append(string("file_system.read_link / run / The file or directory is not a reparse point. / "),
                               sprintf!("path: {} / error: {} / path\': {} / name: {}",
                                        v0_1.clone(), v24_1.clone(),
                                        v4.clone(), v5.clone()));
                    let v257: std::io::Error =
                        std::io::Error::new(std::io::ErrorKind::Other, &*v254);
                    Err(v257)
                }
            } else {
                let v296: string =
                    append(string("file_system.read_link / run / The file or directory is not a reparse point. / "),
                           sprintf!("path: {} / error: {} / path\': {} / name: {}",
                                    v0_1, v24_1.clone(), v4, v5.clone()));
                let v299: std::io::Error = std::io::Error::new(std::io::ErrorKind::Other, &*v296);
                Err(v299)
            }
        }
    }
    pub fn method111(
        v0_1: string,
        v1_1: u8,
        v2_1: string,
    ) -> Result<std::path::PathBuf, std::io::Error> {
        let v5: Result<std::path::PathBuf, std::io::Error> = std::fs::read_link(&*v2_1.clone());
        let v6 = File_system::method43();
        let v18_1: Result<std::path::PathBuf, string> = v5.map_err(|x| v6(x));
        let v21_1 = File_system::method109();
        let v22_1 = File_system::method110();
        let v23_1: File_system::US14 = match &v18_1 {
            Err(v18_1_1_0) => v22_1(v18_1_1_0.clone()),
            Ok(v18_1_0_0) => v21_1(v18_1_0_0.clone()),
        };
        match &v23_1 {
            File_system::US14::US14_0(v23_1_0_0) => Ok(v23_1_0_0.clone()),
            File_system::US14::US14_1(v23_1_1_0) => File_system::method112(
                v0_1.clone(),
                Func2::new({
                    let v0_1 = v0_1.clone();
                    move |b0: u8, b1: string| {
                        (Func1::new({
                            let v0_1 = v0_1.clone();
                            move |v: u8| File_system::closure53(v0_1.clone(), v)
                        }))(b0)(b1)
                    }
                }),
                v1_1,
                v23_1_1_0.clone(),
                v2_1.clone(),
            ),
        }
    }
    pub fn closure54(
        v0_1: string,
        v1_1: u8,
        v2_1: string,
    ) -> Result<std::path::PathBuf, std::io::Error> {
        File_system::method111(v0_1, v1_1, v2_1)
    }
    pub fn closure53(
        v0_1: string,
        v1_1: u8,
    ) -> Func1<string, Result<std::path::PathBuf, std::io::Error>> {
        Func1::new({
            let v0_1 = v0_1.clone();
            let v1_1 = v1_1.clone();
            move |v: string| File_system::closure54(v0_1.clone(), v1_1, v)
        })
    }
    pub fn method115(
        v0_1: string,
        v1_1: Func2<u8, string, Result<std::path::PathBuf, std::io::Error>>,
        v2_1: u8,
        v3: string,
    ) -> Result<std::path::PathBuf, std::io::Error> {
        let v4: string = File_system::method20(v0_1.clone());
        let v5: Option<string> = File_system::method113(v0_1.clone());
        let v19_1: File_system::US5 =
            defaultValue(File_system::US5::US5_1, map(File_system::method5(), v5));
        let v23_1: string = File_system::method114(v3);
        if (v2_1) >= 11_u8 {
            let v27_1: string = append(
                string("file_system.read_link / "),
                sprintf!(
                    "path: {} / n: {} / path\': {} / name: {}",
                    v0_1.clone(),
                    v2_1,
                    v0_1.clone(),
                    v4.clone()
                ),
            );
            let v30_1: std::io::Error = std::io::Error::new(std::io::ErrorKind::Other, &*v27_1);
            Err(v30_1)
        } else {
            if let File_system::US5::US5_0(v19_1_0_0) = &v19_1 {
                if (v0_1.clone()) != string("") {
                    let v73: Result<std::path::PathBuf, std::io::Error> =
                        v1_1((v2_1) + 1_u8, v19_1_0_0.clone());
                    let v74 = File_system::method43();
                    let v86: Result<std::path::PathBuf, string> = v73.map_err(|x| v74(x));
                    let v89 = File_system::method109();
                    let v90 = File_system::method110();
                    let v91: File_system::US14 = match &v86 {
                        Err(v86_1_0) => v90(v86_1_0.clone()),
                        Ok(v86_0_0) => v89(v86_0_0.clone()),
                    };
                    match &v91 {
                        File_system::US14::US14_0(v91_0_0) => {
                            let v120: string = File_system::method86(
                                toString(v91_0_0.clone().display()),
                                v4.clone(),
                            );
                            let v123: &str = &*v120;
                            let v147: std::string::String = String::from(v123);
                            let v171: std::path::PathBuf = std::path::PathBuf::from(v147);
                            Ok(v171)
                        }
                        File_system::US14::US14_1(v91_1_0) => {
                            let v210: string = append(
                                string("file_system.read_link / "),
                                sprintf!(
                                    "error\': {} / error: {} / name: {}",
                                    v91_1_0.clone(),
                                    v23_1.clone(),
                                    v4.clone()
                                ),
                            );
                            let v213: std::io::Error =
                                std::io::Error::new(std::io::ErrorKind::Other, &*v210);
                            Err(v213)
                        }
                    }
                } else {
                    let v253: string =
                        append(string("file_system.read_link / run / The file or directory is not a reparse point. / "),
                               sprintf!("path: {} / error: {} / path\': {} / name: {}",
                                        v0_1.clone(), v23_1.clone(),
                                        v0_1.clone(), v4.clone()));
                    let v256: std::io::Error =
                        std::io::Error::new(std::io::ErrorKind::Other, &*v253);
                    Err(v256)
                }
            } else {
                let v295: string =
                    append(string("file_system.read_link / run / The file or directory is not a reparse point. / "),
                           sprintf!("path: {} / error: {} / path\': {} / name: {}",
                                    v0_1.clone(), v23_1.clone(), v0_1,
                                    v4.clone()));
                let v298: std::io::Error = std::io::Error::new(std::io::ErrorKind::Other, &*v295);
                Err(v298)
            }
        }
    }
    pub fn method108(v0_1: string, v1_1: u8) -> Result<std::path::PathBuf, std::io::Error> {
        let v4: Result<std::path::PathBuf, std::io::Error> = std::fs::read_link(&*v0_1.clone());
        let v5 = File_system::method43();
        let v17_1: Result<std::path::PathBuf, string> = v4.map_err(|x| v5(x));
        let v20_1 = File_system::method109();
        let v21_1 = File_system::method110();
        let v22_1: File_system::US14 = match &v17_1 {
            Err(v17_1_1_0) => v21_1(v17_1_1_0.clone()),
            Ok(v17_1_0_0) => v20_1(v17_1_0_0.clone()),
        };
        match &v22_1 {
            File_system::US14::US14_0(v22_1_0_0) => Ok(v22_1_0_0.clone()),
            File_system::US14::US14_1(v22_1_1_0) => File_system::method115(
                v0_1.clone(),
                Func2::new({
                    let v0_1 = v0_1.clone();
                    move |b0: u8, b1: string| {
                        (Func1::new({
                            let v0_1 = v0_1.clone();
                            move |v: u8| File_system::closure53(v0_1.clone(), v)
                        }))(b0)(b1)
                    }
                }),
                v1_1,
                v22_1_1_0.clone(),
            ),
        }
    }
    pub fn method117(v0_1: bool) -> i32 {
        unbox::<i32>(&getZero())
    }
    pub fn method118() -> i32 {
        unbox::<i32>(&getZero())
    }
    pub fn method119(v0_1: i32, v1_1: i32) -> bool {
        unbox::<bool>(&getZero())
    }
    pub fn method121(
        v0_1: string,
        v1_1: Func2<u8, string, Result<std::path::PathBuf, std::io::Error>>,
        v2_1: u8,
        v3: std::io::Error,
        v4: string,
    ) -> Result<std::path::PathBuf, std::io::Error> {
        let v5: string = File_system::method20(v4.clone());
        let v6: Option<string> = File_system::method113(v4.clone());
        let v20_1: File_system::US5 =
            defaultValue(File_system::US5::US5_1, map(File_system::method5(), v6));
        let v24_1: string = File_system::method44(v3);
        if (v2_1) >= 11_u8 {
            let v28_1: string = append(
                string("file_system.read_link / "),
                sprintf!(
                    "path: {} / n: {} / path\': {} / name: {}",
                    v0_1.clone(),
                    v2_1,
                    v4.clone(),
                    v5.clone()
                ),
            );
            let v31_1: std::io::Error = std::io::Error::new(std::io::ErrorKind::Other, &*v28_1);
            Err(v31_1)
        } else {
            if let File_system::US5::US5_0(v20_1_0_0) = &v20_1 {
                if (v4.clone()) != string("") {
                    let v74: Result<std::path::PathBuf, std::io::Error> =
                        v1_1((v2_1) + 1_u8, v20_1_0_0.clone());
                    let v75 = File_system::method43();
                    let v87: Result<std::path::PathBuf, string> = v74.map_err(|x| v75(x));
                    let v90 = File_system::method109();
                    let v91 = File_system::method110();
                    let v92: File_system::US14 = match &v87 {
                        Err(v87_1_0) => v91(v87_1_0.clone()),
                        Ok(v87_0_0) => v90(v87_0_0.clone()),
                    };
                    match &v92 {
                        File_system::US14::US14_0(v92_0_0) => {
                            let v121: string = File_system::method86(
                                toString(v92_0_0.clone().display()),
                                v5.clone(),
                            );
                            let v124: &str = &*v121;
                            let v148: std::string::String = String::from(v124);
                            let v172: std::path::PathBuf = std::path::PathBuf::from(v148);
                            Ok(v172)
                        }
                        File_system::US14::US14_1(v92_1_0) => {
                            let v211: string = append(
                                string("file_system.read_link / "),
                                sprintf!(
                                    "error\': {} / error: {} / name: {}",
                                    v92_1_0.clone(),
                                    v24_1.clone(),
                                    v5.clone()
                                ),
                            );
                            let v214: std::io::Error =
                                std::io::Error::new(std::io::ErrorKind::Other, &*v211);
                            Err(v214)
                        }
                    }
                } else {
                    let v254: string =
                        append(string("file_system.read_link / run / The file or directory is not a reparse point. / "),
                               sprintf!("path: {} / error: {} / path\': {} / name: {}",
                                        v0_1.clone(), v24_1.clone(),
                                        v4.clone(), v5.clone()));
                    let v257: std::io::Error =
                        std::io::Error::new(std::io::ErrorKind::Other, &*v254);
                    Err(v257)
                }
            } else {
                let v296: string =
                    append(string("file_system.read_link / run / The file or directory is not a reparse point. / "),
                           sprintf!("path: {} / error: {} / path\': {} / name: {}",
                                    v0_1, v24_1.clone(), v4, v5.clone()));
                let v299: std::io::Error = std::io::Error::new(std::io::ErrorKind::Other, &*v296);
                Err(v299)
            }
        }
    }
    pub fn method120(
        v0_1: string,
        v1_1: u8,
        v2_1: string,
    ) -> Result<std::path::PathBuf, std::io::Error> {
        let v30_1: i32 = File_system::method117(unbox::<bool>(&getZero()));
        let v32_1: bool = File_system::method119(File_system::method118(), v30_1);
        if v32_1 {
            let v34_1: bool = unbox::<bool>(&getZero());
            let v86: std::path::PathBuf = getZero();
            Ok(v86)
        } else {
            let v107: string =
                append(string("file_system.read_link / Fsharp / The file or directory is not a reparse point. / "),
                       sprintf!("path: {} / result: {} / path\': {} / n: {}",
                                v0_1.clone(), v32_1, v2_1.clone(), v1_1));
            File_system::method121(
                v0_1.clone(),
                Func2::new({
                    let v0_1 = v0_1.clone();
                    move |b0: u8, b1: string| {
                        (Func1::new({
                            let v0_1 = v0_1.clone();
                            move |v: u8| File_system::closure55(v0_1.clone(), v)
                        }))(b0)(b1)
                    }
                }),
                v1_1,
                std::io::Error::new(std::io::ErrorKind::Other, &*v107),
                v2_1,
            )
        }
    }
    pub fn closure56(
        v0_1: string,
        v1_1: u8,
        v2_1: string,
    ) -> Result<std::path::PathBuf, std::io::Error> {
        File_system::method120(v0_1, v1_1, v2_1)
    }
    pub fn closure55(
        v0_1: string,
        v1_1: u8,
    ) -> Func1<string, Result<std::path::PathBuf, std::io::Error>> {
        Func1::new({
            let v0_1 = v0_1.clone();
            let v1_1 = v1_1.clone();
            move |v: string| File_system::closure56(v0_1.clone(), v1_1, v)
        })
    }
    pub fn method122(
        v0_1: string,
        v1_1: Func2<u8, string, Result<std::path::PathBuf, std::io::Error>>,
        v2_1: u8,
        v3: std::io::Error,
    ) -> Result<std::path::PathBuf, std::io::Error> {
        let v4: string = File_system::method20(v0_1.clone());
        let v5: Option<string> = File_system::method113(v0_1.clone());
        let v19_1: File_system::US5 =
            defaultValue(File_system::US5::US5_1, map(File_system::method5(), v5));
        let v23_1: string = File_system::method44(v3);
        if (v2_1) >= 11_u8 {
            let v27_1: string = append(
                string("file_system.read_link / "),
                sprintf!(
                    "path: {} / n: {} / path\': {} / name: {}",
                    v0_1.clone(),
                    v2_1,
                    v0_1.clone(),
                    v4.clone()
                ),
            );
            let v30_1: std::io::Error = std::io::Error::new(std::io::ErrorKind::Other, &*v27_1);
            Err(v30_1)
        } else {
            if let File_system::US5::US5_0(v19_1_0_0) = &v19_1 {
                if (v0_1.clone()) != string("") {
                    let v73: Result<std::path::PathBuf, std::io::Error> =
                        v1_1((v2_1) + 1_u8, v19_1_0_0.clone());
                    let v74 = File_system::method43();
                    let v86: Result<std::path::PathBuf, string> = v73.map_err(|x| v74(x));
                    let v89 = File_system::method109();
                    let v90 = File_system::method110();
                    let v91: File_system::US14 = match &v86 {
                        Err(v86_1_0) => v90(v86_1_0.clone()),
                        Ok(v86_0_0) => v89(v86_0_0.clone()),
                    };
                    match &v91 {
                        File_system::US14::US14_0(v91_0_0) => {
                            let v120: string = File_system::method86(
                                toString(v91_0_0.clone().display()),
                                v4.clone(),
                            );
                            let v123: &str = &*v120;
                            let v147: std::string::String = String::from(v123);
                            let v171: std::path::PathBuf = std::path::PathBuf::from(v147);
                            Ok(v171)
                        }
                        File_system::US14::US14_1(v91_1_0) => {
                            let v210: string = append(
                                string("file_system.read_link / "),
                                sprintf!(
                                    "error\': {} / error: {} / name: {}",
                                    v91_1_0.clone(),
                                    v23_1.clone(),
                                    v4.clone()
                                ),
                            );
                            let v213: std::io::Error =
                                std::io::Error::new(std::io::ErrorKind::Other, &*v210);
                            Err(v213)
                        }
                    }
                } else {
                    let v253: string =
                        append(string("file_system.read_link / run / The file or directory is not a reparse point. / "),
                               sprintf!("path: {} / error: {} / path\': {} / name: {}",
                                        v0_1.clone(), v23_1.clone(),
                                        v0_1.clone(), v4.clone()));
                    let v256: std::io::Error =
                        std::io::Error::new(std::io::ErrorKind::Other, &*v253);
                    Err(v256)
                }
            } else {
                let v295: string =
                    append(string("file_system.read_link / run / The file or directory is not a reparse point. / "),
                           sprintf!("path: {} / error: {} / path\': {} / name: {}",
                                    v0_1.clone(), v23_1.clone(), v0_1,
                                    v4.clone()));
                let v298: std::io::Error = std::io::Error::new(std::io::ErrorKind::Other, &*v295);
                Err(v298)
            }
        }
    }
    pub fn method116(v0_1: string, v1_1: u8) -> Result<std::path::PathBuf, std::io::Error> {
        let v29_1: i32 = File_system::method117(unbox::<bool>(&getZero()));
        let v31_1: bool = File_system::method119(File_system::method118(), v29_1);
        if v31_1 {
            let v33_1: bool = unbox::<bool>(&getZero());
            let v85: std::path::PathBuf = getZero();
            Ok(v85)
        } else {
            let v106: string =
                append(string("file_system.read_link / Fsharp / The file or directory is not a reparse point. / "),
                       sprintf!("path: {} / result: {} / path\': {} / n: {}",
                                v0_1.clone(), v31_1, v0_1.clone(), v1_1));
            File_system::method122(
                v0_1.clone(),
                Func2::new({
                    let v0_1 = v0_1.clone();
                    move |b0: u8, b1: string| {
                        (Func1::new({
                            let v0_1 = v0_1.clone();
                            move |v: u8| File_system::closure55(v0_1.clone(), v)
                        }))(b0)(b1)
                    }
                }),
                v1_1,
                std::io::Error::new(std::io::ErrorKind::Other, &*v106),
            )
        }
    }
    pub fn method107(v0_1: string) -> Result<std::path::PathBuf, std::io::Error> {
        if File_system::method10(v0_1.clone()) {
            std::fs::read_link(&*v0_1.clone())
        } else {
            File_system::method108(v0_1, 0_u8)
        }
    }
    pub fn closure57(unitVar: (), v0_1: std::path::PathBuf) -> File_system::US15 {
        File_system::US15::US15_0(v0_1)
    }
    pub fn method123() -> Func1<std::path::PathBuf, File_system::US15> {
        Func1::new(move |v: std::path::PathBuf| File_system::closure57((), v))
    }
    pub fn method125(v0_1: string) -> string {
        v0_1
    }
    pub fn method124(v0_1: string, v1_1: string, v2_1: string) -> string {
        let v5: Result<regex::Regex, regex::Error> = regex::Regex::new(&v0_1);
        let v8: regex::Regex = v5.unwrap();
        let v20_1: string = File_system::method125(v2_1);
        let v22_1: std::borrow::Cow<str> = v8.replace_all(&*v20_1, &*v1_1);
        let v24_1: std::string::String = String::from(v22_1);
        fable_library_rust::String_::fromString(v24_1)
    }
    pub fn method106(v0_1: string) -> string {
        if (v0_1.clone()) == string("") {
            string("")
        } else {
            let v3: Result<std::path::PathBuf, std::io::Error> =
                File_system::method107(v0_1.clone());
            let v6: Option<std::path::PathBuf> = v3.ok();
            let v31_1: File_system::US15 =
                defaultValue(File_system::US15::US15_1, map(File_system::method123(), v6));
            let v66: string = match &v31_1 {
                File_system::US15::US15_0(v31_1_0_0) => {
                    let v60: string = toString(
                        match &v31_1 {
                            File_system::US15::US15_0(x) => x.clone(),
                            _ => unreachable!(),
                        }
                        .clone()
                        .display(),
                    );
                    if (v60.clone()) == string("") {
                        v0_1.clone()
                    } else {
                        v60
                    }
                }
                _ => v0_1.clone(),
            };
            if (v66.clone()) == string("") {
                string("")
            } else {
                let v71: string =
                    File_system::method124(string("^\\\\\\\\\\?\\\\"), string(""), v66);
                replace(
                    concat(new_array(&[
                        toLower(ofChar(getCharAt(v71.clone(), 0_i32))),
                        getSlice(v71, Some(1_i32), None::<i32>),
                    ])),
                    string("\\"),
                    string("/"),
                )
            }
        }
    }
    pub fn closure50(unitVar: (), v0_1: string) -> string {
        File_system::method106(v0_1)
    }
    pub fn closure58(unitVar: (), v0_1: string) -> string {
        concat(new_array(&[
            string("file:///"),
            trimStartChars(v0_1, toArray(singleton('/'))),
        ]))
    }
    pub fn method127(v0_1: string, v1_1: string, v2_1: string) -> File_system::US16 {
        let v0_1: MutCell<string> = MutCell::new(v0_1.clone());
        let v1_1: MutCell<string> = MutCell::new(v1_1.clone());
        let v2_1: MutCell<string> = MutCell::new(v2_1.clone());
        '_method127: loop {
            break '_method127 (if File_system::method10(File_system::method86(
                v2_1.get().clone(),
                v0_1.get().clone(),
            )) {
                File_system::US16::US16_0(v2_1.get().clone())
            } else {
                let v6: Option<string> = File_system::method113(v2_1.get().clone());
                let v20_1: File_system::US5 =
                    defaultValue(File_system::US5::US5_1, map(File_system::method5(), v6));
                match &v20_1 {
                    File_system::US5::US5_0(v20_1_0_0) => {
                        let v0_1_temp: string = v0_1.get().clone();
                        let v1_1_temp: string = v1_1.get().clone();
                        let v2_1_temp: string = match &v20_1 {
                            File_system::US5::US5_0(x) => x.clone(),
                            _ => unreachable!(),
                        }
                        .clone();
                        v0_1.set(v0_1_temp);
                        v1_1.set(v1_1_temp);
                        v2_1.set(v2_1_temp);
                        continue '_method127;
                    }
                    _ => File_system::US16::US16_1(sprintf!(
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
    pub fn method126(v0_1: string, v1_1: string) -> File_system::US16 {
        if File_system::method10(File_system::method86(v1_1.clone(), v0_1.clone())) {
            File_system::US16::US16_0(v1_1.clone())
        } else {
            let v5: Option<string> = File_system::method113(v1_1.clone());
            let v19_1: File_system::US5 =
                defaultValue(File_system::US5::US5_1, map(File_system::method5(), v5));
            match &v19_1 {
                File_system::US5::US5_0(v19_1_0_0) => File_system::method127(
                    v0_1.clone(),
                    v1_1.clone(),
                    match &v19_1 {
                        File_system::US5::US5_0(x) => x.clone(),
                        _ => unreachable!(),
                    }
                    .clone(),
                ),
                _ => File_system::US16::US16_1(sprintf!(
                    "No parent for {} \'{}\' at \'{}\' (until \'{}\')",
                    string("dir"),
                    v0_1.clone(),
                    v1_1.clone(),
                    v1_1.clone()
                )),
            }
        }
    }
    pub fn method129(v0_1: string) -> string {
        let v2_1: LrcPtr<File_system::Mut3> = LrcPtr::new(File_system::Mut3 {
            l0: MutCell::new(File_system::method18()),
        });
        let v9: () = {
            File_system::closure6(v2_1.clone(), string("{ "), ());
            ()
        };
        let v18_1: () = {
            File_system::closure6(v2_1.clone(), string("error"), ());
            ()
        };
        let v27_1: () = {
            File_system::closure6(v2_1.clone(), string(" = "), ());
            ()
        };
        let v35_1: () = {
            File_system::closure6(v2_1.clone(), v0_1, ());
            ()
        };
        let v44: () = {
            File_system::closure6(v2_1.clone(), string(" }"), ());
            ()
        };
        v2_1.l0.get().clone()
    }
    pub fn method128(
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
        let v9: string = File_system::method129(v8);
        File_system::method23(sprintf!(
            "{} {} #{} {} / {}",
            v6,
            v7,
            v0_1.l0.get().clone(),
            string("file_system.get_workspace_root"),
            v9
        ))
    }
    pub fn closure60(v0_1: string, unitVar: ()) {
        if File_system::method11(File_system::US0::US0_3) {
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
            ) = File_system::TraceState::trace_state()
                .get()
                .clone()
                .unwrap();
            let v24_1: Option<i64> = patternInput.5.clone();
            let v23_1: LrcPtr<File_system::Mut4> = patternInput.4.clone();
            let v22_1: LrcPtr<File_system::Mut3> = patternInput.3.clone();
            let v21_1: LrcPtr<File_system::Mut2> = patternInput.2.clone();
            let v20_1: LrcPtr<File_system::Mut1> = patternInput.1.clone();
            let v19_1: LrcPtr<File_system::Mut0> = patternInput.0.clone();
            File_system::method24(File_system::method128(
                v19_1.clone(),
                v20_1.clone(),
                v21_1.clone(),
                v22_1.clone(),
                v23_1.clone(),
                v24_1.clone(),
                File_system::method12(v19_1, v20_1, v21_1, v22_1, v23_1, v24_1),
                File_system::method50(),
                v0_1,
            ))
        };
    }
    pub fn method130() -> string {
        let v2_1: Result<std::path::PathBuf, std::io::Error> = std::env::current_dir();
        let v5: std::path::PathBuf = v2_1.unwrap();
        let v19_1: std::path::Display = v5.display();
        let v43: std::string::String = format!("{}", v19_1);
        fable_library_rust::String_::fromString(v43)
    }
    pub fn closure59(unitVar: (), unitVar_1: ()) -> string {
        let v4: File_system::US16 = File_system::method126(
            File_system::method86(string("polyglot"), string("workspace")),
            string("C:\\home\\git\\polyglot\\lib\\spiral"),
        );
        let v52: File_system::US5 = match &v4 {
            File_system::US16::US16_0(v4_0_0) => File_system::US5::US5_0(v4_0_0.clone()),
            File_system::US16::US16_1(v4_1_0) => {
                let v10: () = {
                    File_system::closure60(v4_1_0.clone(), ());
                    ()
                };
                File_system::US5::US5_1
            }
        };
        let v107: File_system::US5 = match &v52 {
            File_system::US5::US5_0(v52_0_0) => File_system::US5::US5_0(
                match &v52 {
                    File_system::US5::US5_0(x) => x.clone(),
                    _ => unreachable!(),
                }
                .clone(),
            ),
            _ => {
                let v55: string = File_system::method130();
                let v57: File_system::US16 = File_system::method126(
                    File_system::method86(string("polyglot"), string("workspace")),
                    v55,
                );
                match &v57 {
                    File_system::US16::US16_0(v57_0_0) => File_system::US5::US5_0(v57_0_0.clone()),
                    File_system::US16::US16_1(v57_1_0) => {
                        let v63: () = {
                            File_system::closure60(v57_1_0.clone(), ());
                            ()
                        };
                        File_system::US5::US5_1
                    }
                }
            }
        };
        File_system::method86(
            match &v107 {
                File_system::US5::US5_0(v107_0_0) => match &v107 {
                    File_system::US5::US5_0(x) => x.clone(),
                    _ => unreachable!(),
                }
                .clone(),
                _ => panic!("{}", string("Option does not have a value."),),
            },
            string("polyglot"),
        )
    }
    pub fn closure62(v0_1: LrcPtr<Exception>, unitVar: ()) -> LrcPtr<Exception> {
        v0_1
    }
    pub fn method131(v0_1: string) {
        ();
    }
    pub fn closure61(unitVar: (), v0_1: string) {
        File_system::method131(v0_1);
    }
    pub fn closure63(unitVar: (), v0_1: bool) {
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
        ) = File_system::TraceState::trace_state()
            .get()
            .clone()
            .unwrap();
        let v37 = if v0_1 {
            Func1::new(move |v: string| File_system::closure61((), v))
        } else {
            Func1::new(move |v_1: string| File_system::closure2((), v_1))
        };
        (patternInput.1.clone()).l0.set(v37);
        ()
    }
    pub fn method132(v0_1: string, v1_1: string) {
        if (File_system::method10(v0_1.clone())) == false {
            let v4: LrcPtr<dyn IDisposable> = File_system::method89(v0_1.clone());
            ()
        }
        {
            let v7: string = defaultValue(string(""), File_system::method113(v1_1.clone()));
            if (File_system::method10(v7.clone())) == false {
                let v12: LrcPtr<dyn IDisposable> = File_system::method89(v7);
                ()
            }
            if if File_system::method10(v1_1.clone()) {
                let v14: Result<std::path::PathBuf, std::io::Error> =
                    File_system::method107(v1_1.clone());
                v14.is_err()
            } else {
                false
            } {
                File_system::method9(true, v1_1.clone());
            }
            if (File_system::method10(v1_1.clone())) == false {
                let v30_1: bool = true;
                #[cfg(windows)]
                std::os::windows::fs::symlink_dir(&*v0_1.clone(), &*v1_1.clone()).unwrap();
                let v32_1: bool = true;
                #[cfg(unix)]
                std::os::unix::fs::symlink(&*v0_1, &*v1_1).unwrap();
                ()
            }
        }
    }
    pub fn closure65(v0_1: string, v1_1: string) {
        File_system::method132(v0_1, v1_1);
    }
    pub fn closure64(unitVar: (), v0_1: string) -> Func1<string, ()> {
        Func1::new({
            let v0_1 = v0_1.clone();
            move |v: string| File_system::closure65(v0_1.clone(), v)
        })
    }
    pub fn closure67(v0_1: string, v1_1: string) -> string {
        File_system::method86(v0_1, v1_1)
    }
    pub fn closure66(unitVar: (), v0_1: string) -> Func1<string, string> {
        Func1::new({
            let v0_1 = v0_1.clone();
            move |v: string| File_system::closure67(v0_1.clone(), v)
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
        v24.get_or_init(|| Func1::new(move |v: string| File_system::closure27((), v)))
            .clone()
    }
    pub fn move_file_async(x: string) -> Func1<string, Arc<Async<i64>>> {
        (File_system::v24())(x)
    }
    pub fn v25() -> Func1<string, Arc<Async<Option<string>>>> {
        static v25: OnceInit<Func1<string, Arc<Async<Option<string>>>>> = OnceInit::new();
        v25.get_or_init(|| Func1::new(move |v: string| File_system::closure30((), v)))
            .clone()
    }
    pub fn read_all_text_retry_async(x: string) -> Arc<Async<Option<string>>> {
        (File_system::v25())(x)
    }
    pub fn v26() -> Func0<string> {
        static v26: OnceInit<Func0<string>> = OnceInit::new();
        v26.get_or_init(|| Func0::new(move || File_system::closure36((), ())))
            .clone()
    }
    pub fn create_temp_path() -> string {
        (File_system::v26())()
    }
    pub fn v27() -> Func0<(string, LrcPtr<dyn IDisposable>)> {
        static v27: OnceInit<Func0<(string, LrcPtr<dyn IDisposable>)>> = OnceInit::new();
        v27.get_or_init(|| Func0::new(move || File_system::closure38((), ())))
            .clone()
    }
    pub fn create_temp_dir() -> (string, LrcPtr<dyn IDisposable>) {
        (File_system::v27())()
    }
    pub fn v28() -> Func1<string, (string, LrcPtr<dyn IDisposable>)> {
        static v28: OnceInit<Func1<string, (string, LrcPtr<dyn IDisposable>)>> = OnceInit::new();
        v28.get_or_init(|| Func1::new(move |v: string| File_system::closure47((), v)))
            .clone()
    }
    pub fn create_temp_dir_(x: string) -> (string, LrcPtr<dyn IDisposable>) {
        (File_system::v28())(x)
    }
    pub fn v29() -> Func0<string> {
        static v29: OnceInit<Func0<string>> = OnceInit::new();
        v29.get_or_init(|| Func0::new(move || File_system::closure49((), ())))
            .clone()
    }
    pub fn get_source_directory() -> string {
        (File_system::v29())()
    }
    pub fn v30() -> Func1<string, string> {
        static v30: OnceInit<Func1<string, string>> = OnceInit::new();
        v30.get_or_init(|| Func1::new(move |v: string| File_system::closure50((), v)))
            .clone()
    }
    pub fn normalize_path(x: string) -> string {
        (File_system::v30())(x)
    }
    pub fn v31() -> Func1<string, string> {
        static v31: OnceInit<Func1<string, string>> = OnceInit::new();
        v31.get_or_init(|| Func1::new(move |v: string| File_system::closure58((), v)))
            .clone()
    }
    pub fn new_file_uri(x: string) -> string {
        (File_system::v31())(x)
    }
    pub fn v32() -> Func0<string> {
        static v32: OnceInit<Func0<string>> = OnceInit::new();
        v32.get_or_init(|| Func0::new(move || File_system::closure59((), ())))
            .clone()
    }
    pub fn get_workspace_root() -> string {
        (File_system::v32())()
    }
    pub fn v33() -> Func1<string, ()> {
        static v33: OnceInit<Func1<string, ()>> = OnceInit::new();
        v33.get_or_init(|| Func1::new(move |v: string| File_system::closure61((), v)))
            .clone()
    }
    pub fn trace_file(x: string) {
        (File_system::v33())(x);
    }
    pub fn v34() -> Func1<bool, ()> {
        static v34: OnceInit<Func1<bool, ()>> = OnceInit::new();
        v34.get_or_init(|| Func1::new(move |v: bool| File_system::closure63((), v)))
            .clone()
    }
    pub fn init_trace_file(x: bool) {
        (File_system::v34())(x);
    }
    pub fn v35() -> Func1<string, Func1<string, ()>> {
        static v35: OnceInit<Func1<string, Func1<string, ()>>> = OnceInit::new();
        v35.get_or_init(|| Func1::new(move |v: string| File_system::closure64((), v)))
            .clone()
    }
    pub fn link_directory(x: string) -> Func1<string, ()> {
        (File_system::v35())(x)
    }
    pub fn v36() -> Func1<string, Func1<string, string>> {
        static v36: OnceInit<Func1<string, Func1<string, string>>> = OnceInit::new();
        v36.get_or_init(|| Func1::new(move |v: string| File_system::closure66((), v)))
            .clone()
    }
    pub fn op_LessDivideGreater(x: string) -> Func1<string, string> {
        (File_system::v36())(x)
    }
    on_startup!(());
}
