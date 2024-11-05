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
    use fable_library_rust::Native_::unbox;
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
        let v18_1: Result<std::string::String, std::env::VarError> = std::env::var(&*v0_1);
        let v20_1: bool = true;
        let _result_map_ = v18_1.map(|x| {
            //;
            let v22_1: std::string::String = x;
            let v24_1: string = fable_library_rust::String_::fromString(v22_1);
            let v26_1: bool = true;
            v24_1
        });
        let v28_1: Result<string, std::env::VarError> = _result_map_;
        let v29_1: string = File_system::method3();
        v28_1.unwrap_or(v29_1)
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
        let _v1: (File_system::US4, File_system::US5) =
            (File_system::US4::US4_1, File_system::US5::US5_1);
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
        unbox::<bool>(&defaultOf())
    }
    pub fn method7(v0_1: bool, v1_1: string) {
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
        let v81: File_system::US5 =
            defaultValue(File_system::US5::US5_1, map(File_system::method12(), v5));
        let v121: DateTime = match &v81 {
            File_system::US5::US5_0(v81_0_0) => {
                let v95: TimeSpan = TimeSpan::new_ticks(
                    {
                        let _arg: DateTime = DateTime::now();
                        _arg.ticks()
                    } - match &v81 {
                        File_system::US5::US5_0(x) => x.clone(),
                        _ => unreachable!(),
                    },
                );
                DateTime::new_ymdhms_milli(
                    1_i32,
                    1_i32,
                    1_i32,
                    v95.hours(),
                    v95.minutes(),
                    v95.seconds(),
                    v95.milliseconds(),
                )
            }
            _ => DateTime::now(),
        };
        let provider: string = File_system::method13();
        v121.toString(provider)
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
        let v41: &str = inline_colorization::color_bright_blue;
        let v46: &str = &*v6;
        let v67: &str = inline_colorization::color_reset;
        let v69: std::string::String = format!("{}{}{}", v41, v46, v67);
        fable_library_rust::String_::fromString(v69)
    }
    pub fn method19(v0_1: string) -> string {
        panic!(
            "{}",
            sprintf!(
                "file_system.get_file_name / target: {} / path: {}",
                File_system::US3::US3_2(File_system::US2::US2_1),
                v0_1
            ),
        )
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
        unbox::<bool>(&defaultOf())
    }
    pub fn method30(v0_1: Vec<u8>) -> Vec<u8> {
        v0_1
    }
    pub fn method28(v0_1: string, v1_1: string) -> bool {
        unbox::<bool>(&defaultOf())
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
        let v41: &str = inline_colorization::color_yellow;
        let v46: &str = &*v6;
        let v67: &str = inline_colorization::color_reset;
        let v69: std::string::String = format!("{}{}{}", v41, v46, v67);
        fable_library_rust::String_::fromString(v69)
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
        let v105: std::string::String = format!("{:#?}", v2_1);
        let v134: () = {
            File_system::closure6(
                v4.clone(),
                sprintf!("{}", fable_library_rust::String_::fromString(v105)),
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
        let v41: &str = inline_colorization::color_bright_black;
        let v46: &str = &*v6;
        let v67: &str = inline_colorization::color_reset;
        let v69: std::string::String = format!("{}{}{}", v41, v46, v67);
        fable_library_rust::String_::fromString(v69)
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
        let v41: &str = inline_colorization::color_bright_red;
        let v46: &str = &*v6;
        let v67: &str = inline_colorization::color_reset;
        let v69: std::string::String = format!("{}{}{}", v41, v46, v67);
        fable_library_rust::String_::fromString(v69)
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
        let v193: DateTime = {
            let _arg: DateTime =
                DateTime::new_ymdhms_kind(1970_i32, 1_i32, 1_i32, 0_i32, 0_i32, 0_i32, 1_i32);
            _arg.toUniversalTime()
        };
        let v211: i64 = ({
            let _arg_2: DateTime = {
                let _arg_1: DateTime = DateTime::specifyKind(v1_1, 2_i32);
                _arg_1.toUniversalTime()
            };
            _arg_2.ticks()
        } - v193.ticks())
            / 10_i64;
        let v213: Option<chrono::DateTime<chrono::Utc>> =
            chrono::DateTime::from_timestamp_micros(v211);
        let v227: File_system::US11 = defaultValue(
            File_system::US11::US11_1,
            map(File_system::method52(), v213),
        );
        let v247: File_system::US1 = match &v227 {
            File_system::US11::US11_0(v227_0_0) => {
                let v233: chrono::NaiveDateTime = match &v227 {
                    File_system::US11::US11_0(x) => x.clone(),
                    _ => unreachable!(),
                }
                .naive_utc();
                let v235: chrono::DateTime<chrono::Local> =
                    chrono::offset::TimeZone::from_utc_datetime(&chrono::Local, &v233);
                let v237: string = string("r#\"%Y%m%d-%H%M-%S%f\"#");
                let v238: &str = r#"%Y%m%d-%H%M-%S%f"#;
                let v240: std::string::String = v235.format(v238).to_string();
                let v242: string = fable_library_rust::String_::fromString(v240);
                File_system::US1::US1_0(sprintf!(
                    "{}-{}-{}",
                    getSlice(v242.clone(), Some(0_i32), Some(17_i32)),
                    getSlice(v242.clone(), Some(18_i32), Some(21_i32)),
                    getCharAt(v242, 22_i32)
                ))
            }
            _ => File_system::US1::US1_1,
        };
        let v251: string = match &v247 {
            File_system::US1::US1_0(v247_0_0) => match &v247 {
                File_system::US1::US1_0(x) => x.clone(),
                _ => unreachable!(),
            },
            _ => string(""),
        };
        let v255: LrcPtr<TimeZoneInfo> = defaultOf();
        let v356: u8 = if zero.hours() > 0_i32 { 1_u8 } else { 0_u8 };
        let v357: string = File_system::method53();
        let v366: string = zero.to_string(v357);
        let v369: string = sprintf!(
            "{}{}{}",
            v356,
            getSlice(v366.clone(), Some(0_i32), Some(1_i32)),
            getSlice(v366, Some(3_i32), Some(4_i32))
        );
        parse(sprintf!(
            "{}{}{}",
            v251.clone(),
            v369.clone(),
            getSlice(
                toString(v0_1),
                Some(length(v251) + length(v369)),
                None::<i32>
            )
        ))
    }
    pub fn method57() -> string {
        panic!(
            "{}",
            sprintf!(
                "file_system.get_temp_path / target: {}",
                File_system::US3::US3_2(File_system::US2::US2_1)
            ),
        )
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
        panic!(
            "{}",
            sprintf!(
                "file_system.(</>) / target: {} / a: {} / b: {}",
                File_system::US3::US3_2(File_system::US2::US2_1),
                v0_1,
                v1_1
            ),
        )
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
        let v10: DateTime = DateTime::now();
        File_system::method56(File_system::method51(new_guid(), v10))
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
        let v71: std::string::String = format!("{:#?}", v1_1);
        let v100: () = {
            File_system::closure6(
                v3.clone(),
                sprintf!("{}", fable_library_rust::String_::fromString(v71)),
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
        let v5: Arc<Async<i64>> = defaultOf();
        let v31_1: Arc<Async<()>> = defaultOf();
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
        interface_cast!(
            defaultOf::<std::sync::Arc<dyn IDisposable>>(),
            Lrc<dyn IDisposable>,
        )
    }
    pub fn closure34(unitVar: (), unitVar_1: ()) -> (string, LrcPtr<dyn IDisposable>) {
        let v0_1: string = File_system::method50();
        (v0_1.clone(), File_system::method64(v0_1))
    }
    pub fn method77(v0_1: string) -> Guid {
        let v19_1: string = padLeft(v0_1, 32_i32, '0');
        parse(sprintf!(
            "{}-{}-{}-{}-{}",
            getSlice(v19_1.clone(), Some(0_i32), Some(7_i32)),
            getSlice(v19_1.clone(), Some(8_i32), Some(11_i32)),
            getSlice(v19_1.clone(), Some(12_i32), Some(15_i32)),
            getSlice(v19_1.clone(), Some(16_i32), Some(19_i32)),
            getSlice(v19_1, Some(20_i32), Some(31_i32))
        ))
    }
    pub fn closure43(unitVar: (), v0_1: string) -> (string, LrcPtr<dyn IDisposable>) {
        let v2_1: string = File_system::method56(File_system::method77(v0_1));
        (v2_1.clone(), File_system::method64(v2_1))
    }
    pub fn closure44(unitVar: (), unitVar_1: ()) -> string {
        string("C:\\home\\git\\polyglot\\lib\\spiral")
    }
    pub fn method80(v0_1: std::io::Error) -> string {
        let v2_1: LrcPtr<File_system::Mut3> = LrcPtr::new(File_system::Mut3 {
            l0: MutCell::new(File_system::method17()),
        });
        let v9: std::string::String = format!("{:#?}", v0_1);
        let v38: () = {
            File_system::closure6(
                v2_1.clone(),
                sprintf!("{}", fable_library_rust::String_::fromString(v9)),
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
        unbox::<string>(&defaultOf())
    }
    pub fn method81(v0_1: string) -> Option<string> {
        let v57: File_system::US1 = unbox::<File_system::US1>(&defaultOf());
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
        unbox::<string>(&defaultOf())
    }
    pub fn method78(v0_1: string) -> string {
        if v0_1.clone() == string("") {
            string("")
        } else {
            let v6389: Result<std::path::PathBuf, std::io::Error> = if File_system::method9(
                v0_1.clone(),
            ) {
                std::fs::read_link(&*v0_1.clone())
            } else {
                let v3201: Result<std::path::PathBuf, std::io::Error> =
                    std::fs::read_link(&*v0_1.clone());
                let v3202 = File_system::method79();
                let v3214: Result<std::path::PathBuf, string> = v3201.map_err(|x| v3202(x));
                fn v3217(v: std::path::PathBuf) -> File_system::US13 {
                    File_system::closure47((), v)
                }
                fn v3218(v_1: string) -> File_system::US13 {
                    File_system::closure48((), v_1)
                }
                let v3219: File_system::US13 = match &v3214 {
                    Err(v3214_1_0) => v3218(v3214_1_0.clone()),
                    Ok(v3214_0_0) => v3217(v3214_0_0.clone()),
                };
                match &v3219 {
                    File_system::US13::US13_0(v3219_0_0) => Ok(v3219_0_0.clone()),
                    File_system::US13::US13_1(v3219_1_0) => {
                        let v3235: string = v3219_1_0.clone();
                        let v3236: string = File_system::method19(v0_1.clone());
                        let v3237: Option<string> = File_system::method81(v0_1.clone());
                        let v3251: File_system::US1 = defaultValue(
                            File_system::US1::US1_1,
                            map(File_system::method4(), v3237),
                        );
                        if let File_system::US1::US1_0(v3251_0_0) = &v3251 {
                            let v3255: string = match &v3251 {
                                File_system::US1::US1_0(x) => x.clone(),
                                _ => unreachable!(),
                            };
                            if v0_1.clone() != string("") {
                                let v3261: Result<std::path::PathBuf, std::io::Error> =
                                    std::fs::read_link(&*v3255.clone());
                                let v3262 = File_system::method79();
                                let v3274: Result<std::path::PathBuf, string> =
                                    v3261.map_err(|x| v3262(x));
                                let v3277: File_system::US13 = match &v3274 {
                                    Err(v3274_1_0) => v3218(v3274_1_0.clone()),
                                    Ok(v3274_0_0) => v3217(v3274_0_0.clone()),
                                };
                                let v6163: Result<std::path::PathBuf, std::io::Error> = match &v3277
                                {
                                    File_system::US13::US13_0(v3277_0_0) => Ok(v3277_0_0.clone()),
                                    File_system::US13::US13_1(v3277_1_0) => {
                                        let v3293: string = v3277_1_0.clone();
                                        let v3294: string = File_system::method19(v3255.clone());
                                        let v3295: Option<string> =
                                            File_system::method81(v3255.clone());
                                        let v3309: File_system::US1 = defaultValue(
                                            File_system::US1::US1_1,
                                            map(File_system::method4(), v3295),
                                        );
                                        if let File_system::US1::US1_0(v3309_0_0) = &v3309 {
                                            let v3313: string = match &v3309 {
                                                File_system::US1::US1_0(x) => x.clone(),
                                                _ => unreachable!(),
                                            };
                                            if v3255.clone() != string("") {
                                                let v3318: Result<
                                                    std::path::PathBuf,
                                                    std::io::Error,
                                                > = std::fs::read_link(&*v3313.clone());
                                                let v3319 = File_system::method79();
                                                let v3331: Result<std::path::PathBuf, string> =
                                                    v3318.map_err(|x| v3319(x));
                                                let v3334: File_system::US13 = match &v3331 {
                                                    Err(v3331_1_0) => v3218(v3331_1_0.clone()),
                                                    Ok(v3331_0_0) => v3217(v3331_0_0.clone()),
                                                };
                                                let v5938: Result<
                                                    std::path::PathBuf,
                                                    std::io::Error,
                                                > = match &v3334 {
                                                    File_system::US13::US13_0(v3334_0_0) => {
                                                        Ok(v3334_0_0.clone())
                                                    }
                                                    File_system::US13::US13_1(v3334_1_0) => {
                                                        let v3350: string = v3334_1_0.clone();
                                                        let v3351: string =
                                                            File_system::method19(v3313.clone());
                                                        let v3352: Option<string> =
                                                            File_system::method81(v3313.clone());
                                                        let v3366: File_system::US1 = defaultValue(
                                                            File_system::US1::US1_1,
                                                            map(File_system::method4(), v3352),
                                                        );
                                                        if let File_system::US1::US1_0(v3366_0_0) =
                                                            &v3366
                                                        {
                                                            let v3370: string = match &v3366 {
                                                                File_system::US1::US1_0(x) => {
                                                                    x.clone()
                                                                }
                                                                _ => unreachable!(),
                                                            };
                                                            if v3313.clone() != string("") {
                                                                let v3375: Result<
                                                                    std::path::PathBuf,
                                                                    std::io::Error,
                                                                > = std::fs::read_link(
                                                                    &*v3370.clone(),
                                                                );
                                                                let v3376 = File_system::method79();
                                                                let v3388: Result<
                                                                    std::path::PathBuf,
                                                                    string,
                                                                > = v3375.map_err(|x| v3376(x));
                                                                let v3391: File_system::US13 =
                                                                    match &v3388 {
                                                                        Err(v3388_1_0) => {
                                                                            v3218(v3388_1_0.clone())
                                                                        }
                                                                        Ok(v3388_0_0) => {
                                                                            v3217(v3388_0_0.clone())
                                                                        }
                                                                    };
                                                                let v5713: Result<
                                                                    std::path::PathBuf,
                                                                    std::io::Error,
                                                                > = match &v3391 {
                                                                    File_system::US13::US13_0(
                                                                        v3391_0_0,
                                                                    ) => Ok(v3391_0_0.clone()),
                                                                    File_system::US13::US13_1(
                                                                        v3391_1_0,
                                                                    ) => {
                                                                        let v3407: string =
                                                                            v3391_1_0.clone();
                                                                        let v3408: string =
                                                                            File_system::method19(
                                                                                v3370.clone(),
                                                                            );
                                                                        let v3409: Option<string> =
                                                                            File_system::method81(
                                                                                v3370.clone(),
                                                                            );
                                                                        let v3423:
                                                                                                File_system::US1 =
                                                                                            defaultValue(File_system::US1::US1_1,
                                                                                                         map(File_system::method4(),
                                                                                                             v3409));
                                                                        if let File_system::US1::US1_0(v3423_0_0)
                                                                                               =
                                                                                               &v3423
                                                                                           {
                                                                                            let v3427:
                                                                                                    string =
                                                                                                match &v3423
                                                                                                    {
                                                                                                    File_system::US1::US1_0(x)
                                                                                                    =>
                                                                                                    x.clone(),
                                                                                                    _
                                                                                                    =>
                                                                                                    unreachable!(),
                                                                                                };
                                                                                            if v3370.clone()
                                                                                                   !=
                                                                                                   string("")
                                                                                               {
                                                                                                let v3432:
                                                                                                        Result<std::path::PathBuf,
                                                                                                               std::io::Error> =
                                                                                                    std::fs::read_link(&*v3427.clone());
                                                                                                let v3433 =
                                                                                                    File_system::method79();
                                                                                                let v3445:
                                                                                                        Result<std::path::PathBuf,
                                                                                                               string> =
                                                                                                    v3432.map_err(|x| v3433(x));
                                                                                                let v3448:
                                                                                                        File_system::US13 =
                                                                                                    match &v3445
                                                                                                        {
                                                                                                        Err(v3445_1_0)
                                                                                                        =>
                                                                                                        v3218(v3445_1_0.clone()),
                                                                                                        Ok(v3445_0_0)
                                                                                                        =>
                                                                                                        v3217(v3445_0_0.clone()),
                                                                                                    };
                                                                                                let v5488:
                                                                                                        Result<std::path::PathBuf,
                                                                                                               std::io::Error> =
                                                                                                    match &v3448
                                                                                                        {
                                                                                                        File_system::US13::US13_0(v3448_0_0)
                                                                                                        =>
                                                                                                        Ok(v3448_0_0.clone()),
                                                                                                        File_system::US13::US13_1(v3448_1_0)
                                                                                                        =>
                                                                                                        {
                                                                                                            let v3464:
                                                                                                                    string =
                                                                                                                v3448_1_0.clone();
                                                                                                            let v3465:
                                                                                                                    string =
                                                                                                                File_system::method19(v3427.clone());
                                                                                                            let v3466:
                                                                                                                    Option<string> =
                                                                                                                File_system::method81(v3427.clone());
                                                                                                            let v3480:
                                                                                                                    File_system::US1 =
                                                                                                                defaultValue(File_system::US1::US1_1,
                                                                                                                             map(File_system::method4(),
                                                                                                                                 v3466));
                                                                                                            if let File_system::US1::US1_0(v3480_0_0)
                                                                                                                   =
                                                                                                                   &v3480
                                                                                                               {
                                                                                                                let v3484:
                                                                                                                        string =
                                                                                                                    match &v3480
                                                                                                                        {
                                                                                                                        File_system::US1::US1_0(x)
                                                                                                                        =>
                                                                                                                        x.clone(),
                                                                                                                        _
                                                                                                                        =>
                                                                                                                        unreachable!(),
                                                                                                                    };
                                                                                                                if v3427.clone()
                                                                                                                       !=
                                                                                                                       string("")
                                                                                                                   {
                                                                                                                    let v3489:
                                                                                                                            Result<std::path::PathBuf,
                                                                                                                                   std::io::Error> =
                                                                                                                        std::fs::read_link(&*v3484.clone());
                                                                                                                    let v3490 =
                                                                                                                        File_system::method79();
                                                                                                                    let v3502:
                                                                                                                            Result<std::path::PathBuf,
                                                                                                                                   string> =
                                                                                                                        v3489.map_err(|x| v3490(x));
                                                                                                                    let v3505:
                                                                                                                            File_system::US13 =
                                                                                                                        match &v3502
                                                                                                                            {
                                                                                                                            Err(v3502_1_0)
                                                                                                                            =>
                                                                                                                            v3218(v3502_1_0.clone()),
                                                                                                                            Ok(v3502_0_0)
                                                                                                                            =>
                                                                                                                            v3217(v3502_0_0.clone()),
                                                                                                                        };
                                                                                                                    let v5263:
                                                                                                                            Result<std::path::PathBuf,
                                                                                                                                   std::io::Error> =
                                                                                                                        match &v3505
                                                                                                                            {
                                                                                                                            File_system::US13::US13_0(v3505_0_0)
                                                                                                                            =>
                                                                                                                            Ok(v3505_0_0.clone()),
                                                                                                                            File_system::US13::US13_1(v3505_1_0)
                                                                                                                            =>
                                                                                                                            {
                                                                                                                                let v3521:
                                                                                                                                        string =
                                                                                                                                    v3505_1_0.clone();
                                                                                                                                let v3522:
                                                                                                                                        string =
                                                                                                                                    File_system::method19(v3484.clone());
                                                                                                                                let v3523:
                                                                                                                                        Option<string> =
                                                                                                                                    File_system::method81(v3484.clone());
                                                                                                                                let v3537:
                                                                                                                                        File_system::US1 =
                                                                                                                                    defaultValue(File_system::US1::US1_1,
                                                                                                                                                 map(File_system::method4(),
                                                                                                                                                     v3523));
                                                                                                                                if let File_system::US1::US1_0(v3537_0_0)
                                                                                                                                       =
                                                                                                                                       &v3537
                                                                                                                                   {
                                                                                                                                    let v3541:
                                                                                                                                            string =
                                                                                                                                        match &v3537
                                                                                                                                            {
                                                                                                                                            File_system::US1::US1_0(x)
                                                                                                                                            =>
                                                                                                                                            x.clone(),
                                                                                                                                            _
                                                                                                                                            =>
                                                                                                                                            unreachable!(),
                                                                                                                                        };
                                                                                                                                    if v3484.clone()
                                                                                                                                           !=
                                                                                                                                           string("")
                                                                                                                                       {
                                                                                                                                        let v3546:
                                                                                                                                                Result<std::path::PathBuf,
                                                                                                                                                       std::io::Error> =
                                                                                                                                            std::fs::read_link(&*v3541.clone());
                                                                                                                                        let v3547 =
                                                                                                                                            File_system::method79();
                                                                                                                                        let v3559:
                                                                                                                                                Result<std::path::PathBuf,
                                                                                                                                                       string> =
                                                                                                                                            v3546.map_err(|x| v3547(x));
                                                                                                                                        let v3562:
                                                                                                                                                File_system::US13 =
                                                                                                                                            match &v3559
                                                                                                                                                {
                                                                                                                                                Err(v3559_1_0)
                                                                                                                                                =>
                                                                                                                                                v3218(v3559_1_0.clone()),
                                                                                                                                                Ok(v3559_0_0)
                                                                                                                                                =>
                                                                                                                                                v3217(v3559_0_0.clone()),
                                                                                                                                            };
                                                                                                                                        let v5038:
                                                                                                                                                Result<std::path::PathBuf,
                                                                                                                                                       std::io::Error> =
                                                                                                                                            match &v3562
                                                                                                                                                {
                                                                                                                                                File_system::US13::US13_0(v3562_0_0)
                                                                                                                                                =>
                                                                                                                                                Ok(v3562_0_0.clone()),
                                                                                                                                                File_system::US13::US13_1(v3562_1_0)
                                                                                                                                                =>
                                                                                                                                                {
                                                                                                                                                    let v3578:
                                                                                                                                                            string =
                                                                                                                                                        v3562_1_0.clone();
                                                                                                                                                    let v3579:
                                                                                                                                                            string =
                                                                                                                                                        File_system::method19(v3541.clone());
                                                                                                                                                    let v3580:
                                                                                                                                                            Option<string> =
                                                                                                                                                        File_system::method81(v3541.clone());
                                                                                                                                                    let v3594:
                                                                                                                                                            File_system::US1 =
                                                                                                                                                        defaultValue(File_system::US1::US1_1,
                                                                                                                                                                     map(File_system::method4(),
                                                                                                                                                                         v3580));
                                                                                                                                                    if let File_system::US1::US1_0(v3594_0_0)
                                                                                                                                                           =
                                                                                                                                                           &v3594
                                                                                                                                                       {
                                                                                                                                                        let v3598:
                                                                                                                                                                string =
                                                                                                                                                            match &v3594
                                                                                                                                                                {
                                                                                                                                                                File_system::US1::US1_0(x)
                                                                                                                                                                =>
                                                                                                                                                                x.clone(),
                                                                                                                                                                _
                                                                                                                                                                =>
                                                                                                                                                                unreachable!(),
                                                                                                                                                            };
                                                                                                                                                        if v3541.clone()
                                                                                                                                                               !=
                                                                                                                                                               string("")
                                                                                                                                                           {
                                                                                                                                                            let v3603:
                                                                                                                                                                    Result<std::path::PathBuf,
                                                                                                                                                                           std::io::Error> =
                                                                                                                                                                std::fs::read_link(&*v3598.clone());
                                                                                                                                                            let v3604 =
                                                                                                                                                                File_system::method79();
                                                                                                                                                            let v3616:
                                                                                                                                                                    Result<std::path::PathBuf,
                                                                                                                                                                           string> =
                                                                                                                                                                v3603.map_err(|x| v3604(x));
                                                                                                                                                            let v3619:
                                                                                                                                                                    File_system::US13 =
                                                                                                                                                                match &v3616
                                                                                                                                                                    {
                                                                                                                                                                    Err(v3616_1_0)
                                                                                                                                                                    =>
                                                                                                                                                                    v3218(v3616_1_0.clone()),
                                                                                                                                                                    Ok(v3616_0_0)
                                                                                                                                                                    =>
                                                                                                                                                                    v3217(v3616_0_0.clone()),
                                                                                                                                                                };
                                                                                                                                                            let v4813:
                                                                                                                                                                    Result<std::path::PathBuf,
                                                                                                                                                                           std::io::Error> =
                                                                                                                                                                match &v3619
                                                                                                                                                                    {
                                                                                                                                                                    File_system::US13::US13_0(v3619_0_0)
                                                                                                                                                                    =>
                                                                                                                                                                    Ok(v3619_0_0.clone()),
                                                                                                                                                                    File_system::US13::US13_1(v3619_1_0)
                                                                                                                                                                    =>
                                                                                                                                                                    {
                                                                                                                                                                        let v3635:
                                                                                                                                                                                string =
                                                                                                                                                                            v3619_1_0.clone();
                                                                                                                                                                        let v3636:
                                                                                                                                                                                string =
                                                                                                                                                                            File_system::method19(v3598.clone());
                                                                                                                                                                        let v3637:
                                                                                                                                                                                Option<string> =
                                                                                                                                                                            File_system::method81(v3598.clone());
                                                                                                                                                                        let v3651:
                                                                                                                                                                                File_system::US1 =
                                                                                                                                                                            defaultValue(File_system::US1::US1_1,
                                                                                                                                                                                         map(File_system::method4(),
                                                                                                                                                                                             v3637));
                                                                                                                                                                        if let File_system::US1::US1_0(v3651_0_0)
                                                                                                                                                                               =
                                                                                                                                                                               &v3651
                                                                                                                                                                           {
                                                                                                                                                                            let v3655:
                                                                                                                                                                                    string =
                                                                                                                                                                                match &v3651
                                                                                                                                                                                    {
                                                                                                                                                                                    File_system::US1::US1_0(x)
                                                                                                                                                                                    =>
                                                                                                                                                                                    x.clone(),
                                                                                                                                                                                    _
                                                                                                                                                                                    =>
                                                                                                                                                                                    unreachable!(),
                                                                                                                                                                                };
                                                                                                                                                                            if v3598.clone()
                                                                                                                                                                                   !=
                                                                                                                                                                                   string("")
                                                                                                                                                                               {
                                                                                                                                                                                let v3660:
                                                                                                                                                                                        Result<std::path::PathBuf,
                                                                                                                                                                                               std::io::Error> =
                                                                                                                                                                                    std::fs::read_link(&*v3655.clone());
                                                                                                                                                                                let v3661 =
                                                                                                                                                                                    File_system::method79();
                                                                                                                                                                                let v3673:
                                                                                                                                                                                        Result<std::path::PathBuf,
                                                                                                                                                                                               string> =
                                                                                                                                                                                    v3660.map_err(|x| v3661(x));
                                                                                                                                                                                let v3676:
                                                                                                                                                                                        File_system::US13 =
                                                                                                                                                                                    match &v3673
                                                                                                                                                                                        {
                                                                                                                                                                                        Err(v3673_1_0)
                                                                                                                                                                                        =>
                                                                                                                                                                                        v3218(v3673_1_0.clone()),
                                                                                                                                                                                        Ok(v3673_0_0)
                                                                                                                                                                                        =>
                                                                                                                                                                                        v3217(v3673_0_0.clone()),
                                                                                                                                                                                    };
                                                                                                                                                                                let v4588:
                                                                                                                                                                                        Result<std::path::PathBuf,
                                                                                                                                                                                               std::io::Error> =
                                                                                                                                                                                    match &v3676
                                                                                                                                                                                        {
                                                                                                                                                                                        File_system::US13::US13_0(v3676_0_0)
                                                                                                                                                                                        =>
                                                                                                                                                                                        Ok(v3676_0_0.clone()),
                                                                                                                                                                                        File_system::US13::US13_1(v3676_1_0)
                                                                                                                                                                                        =>
                                                                                                                                                                                        {
                                                                                                                                                                                            let v3692:
                                                                                                                                                                                                    string =
                                                                                                                                                                                                v3676_1_0.clone();
                                                                                                                                                                                            let v3693:
                                                                                                                                                                                                    string =
                                                                                                                                                                                                File_system::method19(v3655.clone());
                                                                                                                                                                                            let v3694:
                                                                                                                                                                                                    Option<string> =
                                                                                                                                                                                                File_system::method81(v3655.clone());
                                                                                                                                                                                            let v3708:
                                                                                                                                                                                                    File_system::US1 =
                                                                                                                                                                                                defaultValue(File_system::US1::US1_1,
                                                                                                                                                                                                             map(File_system::method4(),
                                                                                                                                                                                                                 v3694));
                                                                                                                                                                                            if let File_system::US1::US1_0(v3708_0_0)
                                                                                                                                                                                                   =
                                                                                                                                                                                                   &v3708
                                                                                                                                                                                               {
                                                                                                                                                                                                let v3712:
                                                                                                                                                                                                        string =
                                                                                                                                                                                                    match &v3708
                                                                                                                                                                                                        {
                                                                                                                                                                                                        File_system::US1::US1_0(x)
                                                                                                                                                                                                        =>
                                                                                                                                                                                                        x.clone(),
                                                                                                                                                                                                        _
                                                                                                                                                                                                        =>
                                                                                                                                                                                                        unreachable!(),
                                                                                                                                                                                                    };
                                                                                                                                                                                                if v3655.clone()
                                                                                                                                                                                                       !=
                                                                                                                                                                                                       string("")
                                                                                                                                                                                                   {
                                                                                                                                                                                                    let v3717:
                                                                                                                                                                                                            Result<std::path::PathBuf,
                                                                                                                                                                                                                   std::io::Error> =
                                                                                                                                                                                                        std::fs::read_link(&*v3712.clone());
                                                                                                                                                                                                    let v3718 =
                                                                                                                                                                                                        File_system::method79();
                                                                                                                                                                                                    let v3730:
                                                                                                                                                                                                            Result<std::path::PathBuf,
                                                                                                                                                                                                                   string> =
                                                                                                                                                                                                        v3717.map_err(|x| v3718(x));
                                                                                                                                                                                                    let v3733:
                                                                                                                                                                                                            File_system::US13 =
                                                                                                                                                                                                        match &v3730
                                                                                                                                                                                                            {
                                                                                                                                                                                                            Err(v3730_1_0)
                                                                                                                                                                                                            =>
                                                                                                                                                                                                            v3218(v3730_1_0.clone()),
                                                                                                                                                                                                            Ok(v3730_0_0)
                                                                                                                                                                                                            =>
                                                                                                                                                                                                            v3217(v3730_0_0.clone()),
                                                                                                                                                                                                        };
                                                                                                                                                                                                    let v4363:
                                                                                                                                                                                                            Result<std::path::PathBuf,
                                                                                                                                                                                                                   std::io::Error> =
                                                                                                                                                                                                        match &v3733
                                                                                                                                                                                                            {
                                                                                                                                                                                                            File_system::US13::US13_0(v3733_0_0)
                                                                                                                                                                                                            =>
                                                                                                                                                                                                            Ok(v3733_0_0.clone()),
                                                                                                                                                                                                            File_system::US13::US13_1(v3733_1_0)
                                                                                                                                                                                                            =>
                                                                                                                                                                                                            {
                                                                                                                                                                                                                let v3749:
                                                                                                                                                                                                                        string =
                                                                                                                                                                                                                    v3733_1_0.clone();
                                                                                                                                                                                                                let v3750:
                                                                                                                                                                                                                        string =
                                                                                                                                                                                                                    File_system::method19(v3712.clone());
                                                                                                                                                                                                                let v3751:
                                                                                                                                                                                                                        Option<string> =
                                                                                                                                                                                                                    File_system::method81(v3712.clone());
                                                                                                                                                                                                                let v3765:
                                                                                                                                                                                                                        File_system::US1 =
                                                                                                                                                                                                                    defaultValue(File_system::US1::US1_1,
                                                                                                                                                                                                                                 map(File_system::method4(),
                                                                                                                                                                                                                                     v3751));
                                                                                                                                                                                                                if let File_system::US1::US1_0(v3765_0_0)
                                                                                                                                                                                                                       =
                                                                                                                                                                                                                       &v3765
                                                                                                                                                                                                                   {
                                                                                                                                                                                                                    let v3769:
                                                                                                                                                                                                                            string =
                                                                                                                                                                                                                        match &v3765
                                                                                                                                                                                                                            {
                                                                                                                                                                                                                            File_system::US1::US1_0(x)
                                                                                                                                                                                                                            =>
                                                                                                                                                                                                                            x.clone(),
                                                                                                                                                                                                                            _
                                                                                                                                                                                                                            =>
                                                                                                                                                                                                                            unreachable!(),
                                                                                                                                                                                                                        };
                                                                                                                                                                                                                    if v3712.clone()
                                                                                                                                                                                                                           !=
                                                                                                                                                                                                                           string("")
                                                                                                                                                                                                                       {
                                                                                                                                                                                                                        let v3774:
                                                                                                                                                                                                                                Result<std::path::PathBuf,
                                                                                                                                                                                                                                       std::io::Error> =
                                                                                                                                                                                                                            std::fs::read_link(&*v3769.clone());
                                                                                                                                                                                                                        let v3775 =
                                                                                                                                                                                                                            File_system::method79();
                                                                                                                                                                                                                        let v3787:
                                                                                                                                                                                                                                Result<std::path::PathBuf,
                                                                                                                                                                                                                                       string> =
                                                                                                                                                                                                                            v3774.map_err(|x| v3775(x));
                                                                                                                                                                                                                        let v3790:
                                                                                                                                                                                                                                File_system::US13 =
                                                                                                                                                                                                                            match &v3787
                                                                                                                                                                                                                                {
                                                                                                                                                                                                                                Err(v3787_1_0)
                                                                                                                                                                                                                                =>
                                                                                                                                                                                                                                v3218(v3787_1_0.clone()),
                                                                                                                                                                                                                                Ok(v3787_0_0)
                                                                                                                                                                                                                                =>
                                                                                                                                                                                                                                v3217(v3787_0_0.clone()),
                                                                                                                                                                                                                            };
                                                                                                                                                                                                                        let v4138:
                                                                                                                                                                                                                                Result<std::path::PathBuf,
                                                                                                                                                                                                                                       std::io::Error> =
                                                                                                                                                                                                                            match &v3790
                                                                                                                                                                                                                                {
                                                                                                                                                                                                                                File_system::US13::US13_0(v3790_0_0)
                                                                                                                                                                                                                                =>
                                                                                                                                                                                                                                Ok(v3790_0_0.clone()),
                                                                                                                                                                                                                                File_system::US13::US13_1(v3790_1_0)
                                                                                                                                                                                                                                =>
                                                                                                                                                                                                                                {
                                                                                                                                                                                                                                    let v3806:
                                                                                                                                                                                                                                            string =
                                                                                                                                                                                                                                        v3790_1_0.clone();
                                                                                                                                                                                                                                    let v3807:
                                                                                                                                                                                                                                            string =
                                                                                                                                                                                                                                        File_system::method19(v3769.clone());
                                                                                                                                                                                                                                    let v3808:
                                                                                                                                                                                                                                            Option<string> =
                                                                                                                                                                                                                                        File_system::method81(v3769.clone());
                                                                                                                                                                                                                                    let v3822:
                                                                                                                                                                                                                                            File_system::US1 =
                                                                                                                                                                                                                                        defaultValue(File_system::US1::US1_1,
                                                                                                                                                                                                                                                     map(File_system::method4(),
                                                                                                                                                                                                                                                         v3808));
                                                                                                                                                                                                                                    if let File_system::US1::US1_0(v3822_0_0)
                                                                                                                                                                                                                                           =
                                                                                                                                                                                                                                           &v3822
                                                                                                                                                                                                                                       {
                                                                                                                                                                                                                                        let v3826:
                                                                                                                                                                                                                                                string =
                                                                                                                                                                                                                                            match &v3822
                                                                                                                                                                                                                                                {
                                                                                                                                                                                                                                                File_system::US1::US1_0(x)
                                                                                                                                                                                                                                                =>
                                                                                                                                                                                                                                                x.clone(),
                                                                                                                                                                                                                                                _
                                                                                                                                                                                                                                                =>
                                                                                                                                                                                                                                                unreachable!(),
                                                                                                                                                                                                                                            };
                                                                                                                                                                                                                                        if v3769.clone()
                                                                                                                                                                                                                                               !=
                                                                                                                                                                                                                                               string("")
                                                                                                                                                                                                                                           {
                                                                                                                                                                                                                                            let v3831:
                                                                                                                                                                                                                                                    Result<std::path::PathBuf,
                                                                                                                                                                                                                                                           std::io::Error> =
                                                                                                                                                                                                                                                std::fs::read_link(&*v3826.clone());
                                                                                                                                                                                                                                            let v3832 =
                                                                                                                                                                                                                                                File_system::method79();
                                                                                                                                                                                                                                            let v3844:
                                                                                                                                                                                                                                                    Result<std::path::PathBuf,
                                                                                                                                                                                                                                                           string> =
                                                                                                                                                                                                                                                v3831.map_err(|x| v3832(x));
                                                                                                                                                                                                                                            let v3847:
                                                                                                                                                                                                                                                    File_system::US13 =
                                                                                                                                                                                                                                                match &v3844
                                                                                                                                                                                                                                                    {
                                                                                                                                                                                                                                                    Err(v3844_1_0)
                                                                                                                                                                                                                                                    =>
                                                                                                                                                                                                                                                    v3218(v3844_1_0.clone()),
                                                                                                                                                                                                                                                    Ok(v3844_0_0)
                                                                                                                                                                                                                                                    =>
                                                                                                                                                                                                                                                    v3217(v3844_0_0.clone()),
                                                                                                                                                                                                                                                };
                                                                                                                                                                                                                                            let v3913:
                                                                                                                                                                                                                                                    Result<std::path::PathBuf,
                                                                                                                                                                                                                                                           std::io::Error> =
                                                                                                                                                                                                                                                match &v3847
                                                                                                                                                                                                                                                    {
                                                                                                                                                                                                                                                    File_system::US13::US13_0(v3847_0_0)
                                                                                                                                                                                                                                                    =>
                                                                                                                                                                                                                                                    Ok(v3847_0_0.clone()),
                                                                                                                                                                                                                                                    _
                                                                                                                                                                                                                                                    =>
                                                                                                                                                                                                                                                    {
                                                                                                                                                                                                                                                        let v3864:
                                                                                                                                                                                                                                                                string =
                                                                                                                                                                                                                                                            File_system::method19(v3826.clone());
                                                                                                                                                                                                                                                        let v3865:
                                                                                                                                                                                                                                                                Option<string> =
                                                                                                                                                                                                                                                            File_system::method81(v3826.clone());
                                                                                                                                                                                                                                                        let v3879:
                                                                                                                                                                                                                                                                File_system::US1 =
                                                                                                                                                                                                                                                            defaultValue(File_system::US1::US1_1,
                                                                                                                                                                                                                                                                         map(File_system::method4(),
                                                                                                                                                                                                                                                                             v3865));
                                                                                                                                                                                                                                                        let v3883:
                                                                                                                                                                                                                                                                string =
                                                                                                                                                                                                                                                            sprintf!("file_system.read_link / path: {} / n: {} / path\': {} / name: {}",
                                                                                                                                                                                                                                                                     v0_1.clone(),
                                                                                                                                                                                                                                                                     11_u8,
                                                                                                                                                                                                                                                                     v3826.clone(),
                                                                                                                                                                                                                                                                     v3864);
                                                                                                                                                                                                                                                        let v3888:
                                                                                                                                                                                                                                                                std::io::Error =
                                                                                                                                                                                                                                                            std::io::Error::new(std::io::ErrorKind::Other, &*v3883);
                                                                                                                                                                                                                                                        Err(v3888)
                                                                                                                                                                                                                                                    }
                                                                                                                                                                                                                                                };
                                                                                                                                                                                                                                            let v3914 =
                                                                                                                                                                                                                                                File_system::method79();
                                                                                                                                                                                                                                            let v3926:
                                                                                                                                                                                                                                                    Result<std::path::PathBuf,
                                                                                                                                                                                                                                                           string> =
                                                                                                                                                                                                                                                v3913.map_err(|x| v3914(x));
                                                                                                                                                                                                                                            let v3929:
                                                                                                                                                                                                                                                    File_system::US13 =
                                                                                                                                                                                                                                                match &v3926
                                                                                                                                                                                                                                                    {
                                                                                                                                                                                                                                                    Err(v3926_1_0)
                                                                                                                                                                                                                                                    =>
                                                                                                                                                                                                                                                    v3218(v3926_1_0.clone()),
                                                                                                                                                                                                                                                    Ok(v3926_0_0)
                                                                                                                                                                                                                                                    =>
                                                                                                                                                                                                                                                    v3217(v3926_0_0.clone()),
                                                                                                                                                                                                                                                };
                                                                                                                                                                                                                                            match &v3929
                                                                                                                                                                                                                                                {
                                                                                                                                                                                                                                                File_system::US13::US13_0(v3929_0_0)
                                                                                                                                                                                                                                                =>
                                                                                                                                                                                                                                                {
                                                                                                                                                                                                                                                    let v3958:
                                                                                                                                                                                                                                                            string =
                                                                                                                                                                                                                                                        File_system::method59(toString(v3929_0_0.clone().display()),
                                                                                                                                                                                                                                                                              v3807.clone());
                                                                                                                                                                                                                                                    let v3963:
                                                                                                                                                                                                                                                            &str =
                                                                                                                                                                                                                                                        &*v3958;
                                                                                                                                                                                                                                                    let v3987:
                                                                                                                                                                                                                                                            std::string::String =
                                                                                                                                                                                                                                                        String::from(v3963);
                                                                                                                                                                                                                                                    let v4011:
                                                                                                                                                                                                                                                            std::path::PathBuf =
                                                                                                                                                                                                                                                        std::path::PathBuf::from(v3987);
                                                                                                                                                                                                                                                    Ok(v4011)
                                                                                                                                                                                                                                                }
                                                                                                                                                                                                                                                File_system::US13::US13_1(v3929_1_0)
                                                                                                                                                                                                                                                =>
                                                                                                                                                                                                                                                {
                                                                                                                                                                                                                                                    let v4046:
                                                                                                                                                                                                                                                            string =
                                                                                                                                                                                                                                                        sprintf!("file_system.read_link / error\': {} / error: {} / name: {}",
                                                                                                                                                                                                                                                                 v3929_1_0.clone(),
                                                                                                                                                                                                                                                                 v3806.clone(),
                                                                                                                                                                                                                                                                 v3807.clone());
                                                                                                                                                                                                                                                    let v4051:
                                                                                                                                                                                                                                                            std::io::Error =
                                                                                                                                                                                                                                                        std::io::Error::new(std::io::ErrorKind::Other, &*v4046);
                                                                                                                                                                                                                                                    Err(v4051)
                                                                                                                                                                                                                                                }
                                                                                                                                                                                                                                            }
                                                                                                                                                                                                                                        } else {
                                                                                                                                                                                                                                            let v4077:
                                                                                                                                                                                                                                                    string =
                                                                                                                                                                                                                                                sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                                                                                                                                                                                                                         v0_1.clone(),
                                                                                                                                                                                                                                                         v3806.clone(),
                                                                                                                                                                                                                                                         v3769.clone(),
                                                                                                                                                                                                                                                         v3807.clone());
                                                                                                                                                                                                                                            let v4082:
                                                                                                                                                                                                                                                    std::io::Error =
                                                                                                                                                                                                                                                std::io::Error::new(std::io::ErrorKind::Other, &*v4077);
                                                                                                                                                                                                                                            Err(v4082)
                                                                                                                                                                                                                                        }
                                                                                                                                                                                                                                    } else {
                                                                                                                                                                                                                                        let v4107:
                                                                                                                                                                                                                                                string =
                                                                                                                                                                                                                                            sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                                                                                                                                                                                                                     v0_1.clone(),
                                                                                                                                                                                                                                                     v3806,
                                                                                                                                                                                                                                                     v3769.clone(),
                                                                                                                                                                                                                                                     v3807.clone());
                                                                                                                                                                                                                                        let v4112:
                                                                                                                                                                                                                                                std::io::Error =
                                                                                                                                                                                                                                            std::io::Error::new(std::io::ErrorKind::Other, &*v4107);
                                                                                                                                                                                                                                        Err(v4112)
                                                                                                                                                                                                                                    }
                                                                                                                                                                                                                                }
                                                                                                                                                                                                                            };
                                                                                                                                                                                                                        let v4139 =
                                                                                                                                                                                                                            File_system::method79();
                                                                                                                                                                                                                        let v4151:
                                                                                                                                                                                                                                Result<std::path::PathBuf,
                                                                                                                                                                                                                                       string> =
                                                                                                                                                                                                                            v4138.map_err(|x| v4139(x));
                                                                                                                                                                                                                        let v4154:
                                                                                                                                                                                                                                File_system::US13 =
                                                                                                                                                                                                                            match &v4151
                                                                                                                                                                                                                                {
                                                                                                                                                                                                                                Err(v4151_1_0)
                                                                                                                                                                                                                                =>
                                                                                                                                                                                                                                v3218(v4151_1_0.clone()),
                                                                                                                                                                                                                                Ok(v4151_0_0)
                                                                                                                                                                                                                                =>
                                                                                                                                                                                                                                v3217(v4151_0_0.clone()),
                                                                                                                                                                                                                            };
                                                                                                                                                                                                                        match &v4154
                                                                                                                                                                                                                            {
                                                                                                                                                                                                                            File_system::US13::US13_0(v4154_0_0)
                                                                                                                                                                                                                            =>
                                                                                                                                                                                                                            {
                                                                                                                                                                                                                                let v4183:
                                                                                                                                                                                                                                        string =
                                                                                                                                                                                                                                    File_system::method59(toString(v4154_0_0.clone().display()),
                                                                                                                                                                                                                                                          v3750.clone());
                                                                                                                                                                                                                                let v4188:
                                                                                                                                                                                                                                        &str =
                                                                                                                                                                                                                                    &*v4183;
                                                                                                                                                                                                                                let v4212:
                                                                                                                                                                                                                                        std::string::String =
                                                                                                                                                                                                                                    String::from(v4188);
                                                                                                                                                                                                                                let v4236:
                                                                                                                                                                                                                                        std::path::PathBuf =
                                                                                                                                                                                                                                    std::path::PathBuf::from(v4212);
                                                                                                                                                                                                                                Ok(v4236)
                                                                                                                                                                                                                            }
                                                                                                                                                                                                                            File_system::US13::US13_1(v4154_1_0)
                                                                                                                                                                                                                            =>
                                                                                                                                                                                                                            {
                                                                                                                                                                                                                                let v4271:
                                                                                                                                                                                                                                        string =
                                                                                                                                                                                                                                    sprintf!("file_system.read_link / error\': {} / error: {} / name: {}",
                                                                                                                                                                                                                                             v4154_1_0.clone(),
                                                                                                                                                                                                                                             v3749.clone(),
                                                                                                                                                                                                                                             v3750.clone());
                                                                                                                                                                                                                                let v4276:
                                                                                                                                                                                                                                        std::io::Error =
                                                                                                                                                                                                                                    std::io::Error::new(std::io::ErrorKind::Other, &*v4271);
                                                                                                                                                                                                                                Err(v4276)
                                                                                                                                                                                                                            }
                                                                                                                                                                                                                        }
                                                                                                                                                                                                                    } else {
                                                                                                                                                                                                                        let v4302:
                                                                                                                                                                                                                                string =
                                                                                                                                                                                                                            sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                                                                                                                                                                                                     v0_1.clone(),
                                                                                                                                                                                                                                     v3749.clone(),
                                                                                                                                                                                                                                     v3712.clone(),
                                                                                                                                                                                                                                     v3750.clone());
                                                                                                                                                                                                                        let v4307:
                                                                                                                                                                                                                                std::io::Error =
                                                                                                                                                                                                                            std::io::Error::new(std::io::ErrorKind::Other, &*v4302);
                                                                                                                                                                                                                        Err(v4307)
                                                                                                                                                                                                                    }
                                                                                                                                                                                                                } else {
                                                                                                                                                                                                                    let v4332:
                                                                                                                                                                                                                            string =
                                                                                                                                                                                                                        sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                                                                                                                                                                                                 v0_1.clone(),
                                                                                                                                                                                                                                 v3749,
                                                                                                                                                                                                                                 v3712.clone(),
                                                                                                                                                                                                                                 v3750.clone());
                                                                                                                                                                                                                    let v4337:
                                                                                                                                                                                                                            std::io::Error =
                                                                                                                                                                                                                        std::io::Error::new(std::io::ErrorKind::Other, &*v4332);
                                                                                                                                                                                                                    Err(v4337)
                                                                                                                                                                                                                }
                                                                                                                                                                                                            }
                                                                                                                                                                                                        };
                                                                                                                                                                                                    let v4364 =
                                                                                                                                                                                                        File_system::method79();
                                                                                                                                                                                                    let v4376:
                                                                                                                                                                                                            Result<std::path::PathBuf,
                                                                                                                                                                                                                   string> =
                                                                                                                                                                                                        v4363.map_err(|x| v4364(x));
                                                                                                                                                                                                    let v4379:
                                                                                                                                                                                                            File_system::US13 =
                                                                                                                                                                                                        match &v4376
                                                                                                                                                                                                            {
                                                                                                                                                                                                            Err(v4376_1_0)
                                                                                                                                                                                                            =>
                                                                                                                                                                                                            v3218(v4376_1_0.clone()),
                                                                                                                                                                                                            Ok(v4376_0_0)
                                                                                                                                                                                                            =>
                                                                                                                                                                                                            v3217(v4376_0_0.clone()),
                                                                                                                                                                                                        };
                                                                                                                                                                                                    match &v4379
                                                                                                                                                                                                        {
                                                                                                                                                                                                        File_system::US13::US13_0(v4379_0_0)
                                                                                                                                                                                                        =>
                                                                                                                                                                                                        {
                                                                                                                                                                                                            let v4408:
                                                                                                                                                                                                                    string =
                                                                                                                                                                                                                File_system::method59(toString(v4379_0_0.clone().display()),
                                                                                                                                                                                                                                      v3693.clone());
                                                                                                                                                                                                            let v4413:
                                                                                                                                                                                                                    &str =
                                                                                                                                                                                                                &*v4408;
                                                                                                                                                                                                            let v4437:
                                                                                                                                                                                                                    std::string::String =
                                                                                                                                                                                                                String::from(v4413);
                                                                                                                                                                                                            let v4461:
                                                                                                                                                                                                                    std::path::PathBuf =
                                                                                                                                                                                                                std::path::PathBuf::from(v4437);
                                                                                                                                                                                                            Ok(v4461)
                                                                                                                                                                                                        }
                                                                                                                                                                                                        File_system::US13::US13_1(v4379_1_0)
                                                                                                                                                                                                        =>
                                                                                                                                                                                                        {
                                                                                                                                                                                                            let v4496:
                                                                                                                                                                                                                    string =
                                                                                                                                                                                                                sprintf!("file_system.read_link / error\': {} / error: {} / name: {}",
                                                                                                                                                                                                                         v4379_1_0.clone(),
                                                                                                                                                                                                                         v3692.clone(),
                                                                                                                                                                                                                         v3693.clone());
                                                                                                                                                                                                            let v4501:
                                                                                                                                                                                                                    std::io::Error =
                                                                                                                                                                                                                std::io::Error::new(std::io::ErrorKind::Other, &*v4496);
                                                                                                                                                                                                            Err(v4501)
                                                                                                                                                                                                        }
                                                                                                                                                                                                    }
                                                                                                                                                                                                } else {
                                                                                                                                                                                                    let v4527:
                                                                                                                                                                                                            string =
                                                                                                                                                                                                        sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                                                                                                                                                                                 v0_1.clone(),
                                                                                                                                                                                                                 v3692.clone(),
                                                                                                                                                                                                                 v3655.clone(),
                                                                                                                                                                                                                 v3693.clone());
                                                                                                                                                                                                    let v4532:
                                                                                                                                                                                                            std::io::Error =
                                                                                                                                                                                                        std::io::Error::new(std::io::ErrorKind::Other, &*v4527);
                                                                                                                                                                                                    Err(v4532)
                                                                                                                                                                                                }
                                                                                                                                                                                            } else {
                                                                                                                                                                                                let v4557:
                                                                                                                                                                                                        string =
                                                                                                                                                                                                    sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                                                                                                                                                                             v0_1.clone(),
                                                                                                                                                                                                             v3692,
                                                                                                                                                                                                             v3655.clone(),
                                                                                                                                                                                                             v3693.clone());
                                                                                                                                                                                                let v4562:
                                                                                                                                                                                                        std::io::Error =
                                                                                                                                                                                                    std::io::Error::new(std::io::ErrorKind::Other, &*v4557);
                                                                                                                                                                                                Err(v4562)
                                                                                                                                                                                            }
                                                                                                                                                                                        }
                                                                                                                                                                                    };
                                                                                                                                                                                let v4589 =
                                                                                                                                                                                    File_system::method79();
                                                                                                                                                                                let v4601:
                                                                                                                                                                                        Result<std::path::PathBuf,
                                                                                                                                                                                               string> =
                                                                                                                                                                                    v4588.map_err(|x| v4589(x));
                                                                                                                                                                                let v4604:
                                                                                                                                                                                        File_system::US13 =
                                                                                                                                                                                    match &v4601
                                                                                                                                                                                        {
                                                                                                                                                                                        Err(v4601_1_0)
                                                                                                                                                                                        =>
                                                                                                                                                                                        v3218(v4601_1_0.clone()),
                                                                                                                                                                                        Ok(v4601_0_0)
                                                                                                                                                                                        =>
                                                                                                                                                                                        v3217(v4601_0_0.clone()),
                                                                                                                                                                                    };
                                                                                                                                                                                match &v4604
                                                                                                                                                                                    {
                                                                                                                                                                                    File_system::US13::US13_0(v4604_0_0)
                                                                                                                                                                                    =>
                                                                                                                                                                                    {
                                                                                                                                                                                        let v4633:
                                                                                                                                                                                                string =
                                                                                                                                                                                            File_system::method59(toString(v4604_0_0.clone().display()),
                                                                                                                                                                                                                  v3636.clone());
                                                                                                                                                                                        let v4638:
                                                                                                                                                                                                &str =
                                                                                                                                                                                            &*v4633;
                                                                                                                                                                                        let v4662:
                                                                                                                                                                                                std::string::String =
                                                                                                                                                                                            String::from(v4638);
                                                                                                                                                                                        let v4686:
                                                                                                                                                                                                std::path::PathBuf =
                                                                                                                                                                                            std::path::PathBuf::from(v4662);
                                                                                                                                                                                        Ok(v4686)
                                                                                                                                                                                    }
                                                                                                                                                                                    File_system::US13::US13_1(v4604_1_0)
                                                                                                                                                                                    =>
                                                                                                                                                                                    {
                                                                                                                                                                                        let v4721:
                                                                                                                                                                                                string =
                                                                                                                                                                                            sprintf!("file_system.read_link / error\': {} / error: {} / name: {}",
                                                                                                                                                                                                     v4604_1_0.clone(),
                                                                                                                                                                                                     v3635.clone(),
                                                                                                                                                                                                     v3636.clone());
                                                                                                                                                                                        let v4726:
                                                                                                                                                                                                std::io::Error =
                                                                                                                                                                                            std::io::Error::new(std::io::ErrorKind::Other, &*v4721);
                                                                                                                                                                                        Err(v4726)
                                                                                                                                                                                    }
                                                                                                                                                                                }
                                                                                                                                                                            } else {
                                                                                                                                                                                let v4752:
                                                                                                                                                                                        string =
                                                                                                                                                                                    sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                                                                                                                                                             v0_1.clone(),
                                                                                                                                                                                             v3635.clone(),
                                                                                                                                                                                             v3598.clone(),
                                                                                                                                                                                             v3636.clone());
                                                                                                                                                                                let v4757:
                                                                                                                                                                                        std::io::Error =
                                                                                                                                                                                    std::io::Error::new(std::io::ErrorKind::Other, &*v4752);
                                                                                                                                                                                Err(v4757)
                                                                                                                                                                            }
                                                                                                                                                                        } else {
                                                                                                                                                                            let v4782:
                                                                                                                                                                                    string =
                                                                                                                                                                                sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                                                                                                                                                         v0_1.clone(),
                                                                                                                                                                                         v3635,
                                                                                                                                                                                         v3598.clone(),
                                                                                                                                                                                         v3636.clone());
                                                                                                                                                                            let v4787:
                                                                                                                                                                                    std::io::Error =
                                                                                                                                                                                std::io::Error::new(std::io::ErrorKind::Other, &*v4782);
                                                                                                                                                                            Err(v4787)
                                                                                                                                                                        }
                                                                                                                                                                    }
                                                                                                                                                                };
                                                                                                                                                            let v4814 =
                                                                                                                                                                File_system::method79();
                                                                                                                                                            let v4826:
                                                                                                                                                                    Result<std::path::PathBuf,
                                                                                                                                                                           string> =
                                                                                                                                                                v4813.map_err(|x| v4814(x));
                                                                                                                                                            let v4829:
                                                                                                                                                                    File_system::US13 =
                                                                                                                                                                match &v4826
                                                                                                                                                                    {
                                                                                                                                                                    Err(v4826_1_0)
                                                                                                                                                                    =>
                                                                                                                                                                    v3218(v4826_1_0.clone()),
                                                                                                                                                                    Ok(v4826_0_0)
                                                                                                                                                                    =>
                                                                                                                                                                    v3217(v4826_0_0.clone()),
                                                                                                                                                                };
                                                                                                                                                            match &v4829
                                                                                                                                                                {
                                                                                                                                                                File_system::US13::US13_0(v4829_0_0)
                                                                                                                                                                =>
                                                                                                                                                                {
                                                                                                                                                                    let v4858:
                                                                                                                                                                            string =
                                                                                                                                                                        File_system::method59(toString(v4829_0_0.clone().display()),
                                                                                                                                                                                              v3579.clone());
                                                                                                                                                                    let v4863:
                                                                                                                                                                            &str =
                                                                                                                                                                        &*v4858;
                                                                                                                                                                    let v4887:
                                                                                                                                                                            std::string::String =
                                                                                                                                                                        String::from(v4863);
                                                                                                                                                                    let v4911:
                                                                                                                                                                            std::path::PathBuf =
                                                                                                                                                                        std::path::PathBuf::from(v4887);
                                                                                                                                                                    Ok(v4911)
                                                                                                                                                                }
                                                                                                                                                                File_system::US13::US13_1(v4829_1_0)
                                                                                                                                                                =>
                                                                                                                                                                {
                                                                                                                                                                    let v4946:
                                                                                                                                                                            string =
                                                                                                                                                                        sprintf!("file_system.read_link / error\': {} / error: {} / name: {}",
                                                                                                                                                                                 v4829_1_0.clone(),
                                                                                                                                                                                 v3578.clone(),
                                                                                                                                                                                 v3579.clone());
                                                                                                                                                                    let v4951:
                                                                                                                                                                            std::io::Error =
                                                                                                                                                                        std::io::Error::new(std::io::ErrorKind::Other, &*v4946);
                                                                                                                                                                    Err(v4951)
                                                                                                                                                                }
                                                                                                                                                            }
                                                                                                                                                        } else {
                                                                                                                                                            let v4977:
                                                                                                                                                                    string =
                                                                                                                                                                sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                                                                                                                                         v0_1.clone(),
                                                                                                                                                                         v3578.clone(),
                                                                                                                                                                         v3541.clone(),
                                                                                                                                                                         v3579.clone());
                                                                                                                                                            let v4982:
                                                                                                                                                                    std::io::Error =
                                                                                                                                                                std::io::Error::new(std::io::ErrorKind::Other, &*v4977);
                                                                                                                                                            Err(v4982)
                                                                                                                                                        }
                                                                                                                                                    } else {
                                                                                                                                                        let v5007:
                                                                                                                                                                string =
                                                                                                                                                            sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                                                                                                                                     v0_1.clone(),
                                                                                                                                                                     v3578,
                                                                                                                                                                     v3541.clone(),
                                                                                                                                                                     v3579.clone());
                                                                                                                                                        let v5012:
                                                                                                                                                                std::io::Error =
                                                                                                                                                            std::io::Error::new(std::io::ErrorKind::Other, &*v5007);
                                                                                                                                                        Err(v5012)
                                                                                                                                                    }
                                                                                                                                                }
                                                                                                                                            };
                                                                                                                                        let v5039 =
                                                                                                                                            File_system::method79();
                                                                                                                                        let v5051:
                                                                                                                                                Result<std::path::PathBuf,
                                                                                                                                                       string> =
                                                                                                                                            v5038.map_err(|x| v5039(x));
                                                                                                                                        let v5054:
                                                                                                                                                File_system::US13 =
                                                                                                                                            match &v5051
                                                                                                                                                {
                                                                                                                                                Err(v5051_1_0)
                                                                                                                                                =>
                                                                                                                                                v3218(v5051_1_0.clone()),
                                                                                                                                                Ok(v5051_0_0)
                                                                                                                                                =>
                                                                                                                                                v3217(v5051_0_0.clone()),
                                                                                                                                            };
                                                                                                                                        match &v5054
                                                                                                                                            {
                                                                                                                                            File_system::US13::US13_0(v5054_0_0)
                                                                                                                                            =>
                                                                                                                                            {
                                                                                                                                                let v5083:
                                                                                                                                                        string =
                                                                                                                                                    File_system::method59(toString(v5054_0_0.clone().display()),
                                                                                                                                                                          v3522.clone());
                                                                                                                                                let v5088:
                                                                                                                                                        &str =
                                                                                                                                                    &*v5083;
                                                                                                                                                let v5112:
                                                                                                                                                        std::string::String =
                                                                                                                                                    String::from(v5088);
                                                                                                                                                let v5136:
                                                                                                                                                        std::path::PathBuf =
                                                                                                                                                    std::path::PathBuf::from(v5112);
                                                                                                                                                Ok(v5136)
                                                                                                                                            }
                                                                                                                                            File_system::US13::US13_1(v5054_1_0)
                                                                                                                                            =>
                                                                                                                                            {
                                                                                                                                                let v5171:
                                                                                                                                                        string =
                                                                                                                                                    sprintf!("file_system.read_link / error\': {} / error: {} / name: {}",
                                                                                                                                                             v5054_1_0.clone(),
                                                                                                                                                             v3521.clone(),
                                                                                                                                                             v3522.clone());
                                                                                                                                                let v5176:
                                                                                                                                                        std::io::Error =
                                                                                                                                                    std::io::Error::new(std::io::ErrorKind::Other, &*v5171);
                                                                                                                                                Err(v5176)
                                                                                                                                            }
                                                                                                                                        }
                                                                                                                                    } else {
                                                                                                                                        let v5202:
                                                                                                                                                string =
                                                                                                                                            sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                                                                                                                     v0_1.clone(),
                                                                                                                                                     v3521.clone(),
                                                                                                                                                     v3484.clone(),
                                                                                                                                                     v3522.clone());
                                                                                                                                        let v5207:
                                                                                                                                                std::io::Error =
                                                                                                                                            std::io::Error::new(std::io::ErrorKind::Other, &*v5202);
                                                                                                                                        Err(v5207)
                                                                                                                                    }
                                                                                                                                } else {
                                                                                                                                    let v5232:
                                                                                                                                            string =
                                                                                                                                        sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                                                                                                                 v0_1.clone(),
                                                                                                                                                 v3521,
                                                                                                                                                 v3484.clone(),
                                                                                                                                                 v3522.clone());
                                                                                                                                    let v5237:
                                                                                                                                            std::io::Error =
                                                                                                                                        std::io::Error::new(std::io::ErrorKind::Other, &*v5232);
                                                                                                                                    Err(v5237)
                                                                                                                                }
                                                                                                                            }
                                                                                                                        };
                                                                                                                    let v5264 =
                                                                                                                        File_system::method79();
                                                                                                                    let v5276:
                                                                                                                            Result<std::path::PathBuf,
                                                                                                                                   string> =
                                                                                                                        v5263.map_err(|x| v5264(x));
                                                                                                                    let v5279:
                                                                                                                            File_system::US13 =
                                                                                                                        match &v5276
                                                                                                                            {
                                                                                                                            Err(v5276_1_0)
                                                                                                                            =>
                                                                                                                            v3218(v5276_1_0.clone()),
                                                                                                                            Ok(v5276_0_0)
                                                                                                                            =>
                                                                                                                            v3217(v5276_0_0.clone()),
                                                                                                                        };
                                                                                                                    match &v5279
                                                                                                                        {
                                                                                                                        File_system::US13::US13_0(v5279_0_0)
                                                                                                                        =>
                                                                                                                        {
                                                                                                                            let v5308:
                                                                                                                                    string =
                                                                                                                                File_system::method59(toString(v5279_0_0.clone().display()),
                                                                                                                                                      v3465.clone());
                                                                                                                            let v5313:
                                                                                                                                    &str =
                                                                                                                                &*v5308;
                                                                                                                            let v5337:
                                                                                                                                    std::string::String =
                                                                                                                                String::from(v5313);
                                                                                                                            let v5361:
                                                                                                                                    std::path::PathBuf =
                                                                                                                                std::path::PathBuf::from(v5337);
                                                                                                                            Ok(v5361)
                                                                                                                        }
                                                                                                                        File_system::US13::US13_1(v5279_1_0)
                                                                                                                        =>
                                                                                                                        {
                                                                                                                            let v5396:
                                                                                                                                    string =
                                                                                                                                sprintf!("file_system.read_link / error\': {} / error: {} / name: {}",
                                                                                                                                         v5279_1_0.clone(),
                                                                                                                                         v3464.clone(),
                                                                                                                                         v3465.clone());
                                                                                                                            let v5401:
                                                                                                                                    std::io::Error =
                                                                                                                                std::io::Error::new(std::io::ErrorKind::Other, &*v5396);
                                                                                                                            Err(v5401)
                                                                                                                        }
                                                                                                                    }
                                                                                                                } else {
                                                                                                                    let v5427:
                                                                                                                            string =
                                                                                                                        sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                                                                                                 v0_1.clone(),
                                                                                                                                 v3464.clone(),
                                                                                                                                 v3427.clone(),
                                                                                                                                 v3465.clone());
                                                                                                                    let v5432:
                                                                                                                            std::io::Error =
                                                                                                                        std::io::Error::new(std::io::ErrorKind::Other, &*v5427);
                                                                                                                    Err(v5432)
                                                                                                                }
                                                                                                            } else {
                                                                                                                let v5457:
                                                                                                                        string =
                                                                                                                    sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                                                                                             v0_1.clone(),
                                                                                                                             v3464,
                                                                                                                             v3427.clone(),
                                                                                                                             v3465.clone());
                                                                                                                let v5462:
                                                                                                                        std::io::Error =
                                                                                                                    std::io::Error::new(std::io::ErrorKind::Other, &*v5457);
                                                                                                                Err(v5462)
                                                                                                            }
                                                                                                        }
                                                                                                    };
                                                                                                let v5489 =
                                                                                                    File_system::method79();
                                                                                                let v5501:
                                                                                                        Result<std::path::PathBuf,
                                                                                                               string> =
                                                                                                    v5488.map_err(|x| v5489(x));
                                                                                                let v5504:
                                                                                                        File_system::US13 =
                                                                                                    match &v5501
                                                                                                        {
                                                                                                        Err(v5501_1_0)
                                                                                                        =>
                                                                                                        v3218(v5501_1_0.clone()),
                                                                                                        Ok(v5501_0_0)
                                                                                                        =>
                                                                                                        v3217(v5501_0_0.clone()),
                                                                                                    };
                                                                                                match &v5504
                                                                                                    {
                                                                                                    File_system::US13::US13_0(v5504_0_0)
                                                                                                    =>
                                                                                                    {
                                                                                                        let v5533:
                                                                                                                string =
                                                                                                            File_system::method59(toString(v5504_0_0.clone().display()),
                                                                                                                                  v3408.clone());
                                                                                                        let v5538:
                                                                                                                &str =
                                                                                                            &*v5533;
                                                                                                        let v5562:
                                                                                                                std::string::String =
                                                                                                            String::from(v5538);
                                                                                                        let v5586:
                                                                                                                std::path::PathBuf =
                                                                                                            std::path::PathBuf::from(v5562);
                                                                                                        Ok(v5586)
                                                                                                    }
                                                                                                    File_system::US13::US13_1(v5504_1_0)
                                                                                                    =>
                                                                                                    {
                                                                                                        let v5621:
                                                                                                                string =
                                                                                                            sprintf!("file_system.read_link / error\': {} / error: {} / name: {}",
                                                                                                                     v5504_1_0.clone(),
                                                                                                                     v3407.clone(),
                                                                                                                     v3408.clone());
                                                                                                        let v5626:
                                                                                                                std::io::Error =
                                                                                                            std::io::Error::new(std::io::ErrorKind::Other, &*v5621);
                                                                                                        Err(v5626)
                                                                                                    }
                                                                                                }
                                                                                            } else {
                                                                                                let v5652:
                                                                                                        string =
                                                                                                    sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                                                                             v0_1.clone(),
                                                                                                             v3407.clone(),
                                                                                                             v3370.clone(),
                                                                                                             v3408.clone());
                                                                                                let v5657:
                                                                                                        std::io::Error =
                                                                                                    std::io::Error::new(std::io::ErrorKind::Other, &*v5652);
                                                                                                Err(v5657)
                                                                                            }
                                                                                        } else {
                                                                                            let v5682:
                                                                                                    string =
                                                                                                sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                                                                         v0_1.clone(),
                                                                                                         v3407,
                                                                                                         v3370.clone(),
                                                                                                         v3408.clone());
                                                                                            let v5687:
                                                                                                    std::io::Error =
                                                                                                std::io::Error::new(std::io::ErrorKind::Other, &*v5682);
                                                                                            Err(v5687)
                                                                                        }
                                                                    }
                                                                };
                                                                let v5714 = File_system::method79();
                                                                let v5726: Result<
                                                                    std::path::PathBuf,
                                                                    string,
                                                                > = v5713.map_err(|x| v5714(x));
                                                                let v5729: File_system::US13 =
                                                                    match &v5726 {
                                                                        Err(v5726_1_0) => {
                                                                            v3218(v5726_1_0.clone())
                                                                        }
                                                                        Ok(v5726_0_0) => {
                                                                            v3217(v5726_0_0.clone())
                                                                        }
                                                                    };
                                                                match &v5729 {
                                                                    File_system::US13::US13_0(
                                                                        v5729_0_0,
                                                                    ) => {
                                                                        let v5758: string =
                                                                            File_system::method59(
                                                                                toString(
                                                                                    v5729_0_0
                                                                                        .clone()
                                                                                        .display(),
                                                                                ),
                                                                                v3351.clone(),
                                                                            );
                                                                        let v5763: &str = &*v5758;
                                                                        let v5787:
                                                                                            std::string::String =
                                                                                        String::from(v5763);
                                                                        let v5811:
                                                                                            std::path::PathBuf =
                                                                                        std::path::PathBuf::from(v5787);
                                                                        Ok(v5811)
                                                                    }
                                                                    File_system::US13::US13_1(
                                                                        v5729_1_0,
                                                                    ) => {
                                                                        let v5846:
                                                                                            string =
                                                                                        sprintf!("file_system.read_link / error\': {} / error: {} / name: {}",
                                                                                                 v5729_1_0.clone(),
                                                                                                 v3350.clone(),
                                                                                                 v3351.clone());
                                                                        let v5851:
                                                                                            std::io::Error =
                                                                                        std::io::Error::new(std::io::ErrorKind::Other, &*v5846);
                                                                        Err(v5851)
                                                                    }
                                                                }
                                                            } else {
                                                                let v5877:
                                                                                    string =
                                                                                sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                                                         v0_1.clone(),
                                                                                         v3350.clone(),
                                                                                         v3313.clone(),
                                                                                         v3351.clone());
                                                                let v5882: std::io::Error =
                                                                    std::io::Error::new(
                                                                        std::io::ErrorKind::Other,
                                                                        &*v5877,
                                                                    );
                                                                Err(v5882)
                                                            }
                                                        } else {
                                                            let v5907:
                                                                                string =
                                                                            sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                                                     v0_1.clone(),
                                                                                     v3350,
                                                                                     v3313.clone(),
                                                                                     v3351.clone());
                                                            let v5912: std::io::Error =
                                                                std::io::Error::new(
                                                                    std::io::ErrorKind::Other,
                                                                    &*v5907,
                                                                );
                                                            Err(v5912)
                                                        }
                                                    }
                                                };
                                                let v5939 = File_system::method79();
                                                let v5951: Result<std::path::PathBuf, string> =
                                                    v5938.map_err(|x| v5939(x));
                                                let v5954: File_system::US13 = match &v5951 {
                                                    Err(v5951_1_0) => v3218(v5951_1_0.clone()),
                                                    Ok(v5951_0_0) => v3217(v5951_0_0.clone()),
                                                };
                                                match &v5954 {
                                                    File_system::US13::US13_0(v5954_0_0) => {
                                                        let v5983: string = File_system::method59(
                                                            toString(v5954_0_0.clone().display()),
                                                            v3294.clone(),
                                                        );
                                                        let v5988: &str = &*v5983;
                                                        let v6012: std::string::String =
                                                            String::from(v5988);
                                                        let v6036: std::path::PathBuf =
                                                            std::path::PathBuf::from(v6012);
                                                        Ok(v6036)
                                                    }
                                                    File_system::US13::US13_1(v5954_1_0) => {
                                                        let v6071:
                                                                        string =
                                                                    sprintf!("file_system.read_link / error\': {} / error: {} / name: {}",
                                                                             v5954_1_0.clone(),
                                                                             v3293.clone(),
                                                                             v3294.clone());
                                                        let v6076: std::io::Error =
                                                            std::io::Error::new(
                                                                std::io::ErrorKind::Other,
                                                                &*v6071,
                                                            );
                                                        Err(v6076)
                                                    }
                                                }
                                            } else {
                                                let v6102: string =
                                                            sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                                     v0_1.clone(),
                                                                     v3293.clone(),
                                                                     v3255.clone(),
                                                                     v3294.clone());
                                                let v6107: std::io::Error = std::io::Error::new(
                                                    std::io::ErrorKind::Other,
                                                    &*v6102,
                                                );
                                                Err(v6107)
                                            }
                                        } else {
                                            let v6132: string =
                                                        sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                                 v0_1.clone(),
                                                                 v3293,
                                                                 v3255.clone(),
                                                                 v3294.clone());
                                            let v6137: std::io::Error = std::io::Error::new(
                                                std::io::ErrorKind::Other,
                                                &*v6132,
                                            );
                                            Err(v6137)
                                        }
                                    }
                                };
                                let v6164 = File_system::method79();
                                let v6176: Result<std::path::PathBuf, string> =
                                    v6163.map_err(|x| v6164(x));
                                let v6179: File_system::US13 = match &v6176 {
                                    Err(v6176_1_0) => v3218(v6176_1_0.clone()),
                                    Ok(v6176_0_0) => v3217(v6176_0_0.clone()),
                                };
                                match &v6179 {
                                    File_system::US13::US13_0(v6179_0_0) => {
                                        let v6208: string = File_system::method59(
                                            toString(v6179_0_0.clone().display()),
                                            v3236.clone(),
                                        );
                                        let v6213: &str = &*v6208;
                                        let v6237: std::string::String = String::from(v6213);
                                        let v6261: std::path::PathBuf =
                                            std::path::PathBuf::from(v6237);
                                        Ok(v6261)
                                    }
                                    File_system::US13::US13_1(v6179_1_0) => {
                                        let v6296: string =
                                                sprintf!("file_system.read_link / error\': {} / error: {} / name: {}",
                                                         v6179_1_0.clone(),
                                                         v3235.clone(),
                                                         v3236.clone());
                                        let v6301: std::io::Error =
                                            std::io::Error::new(std::io::ErrorKind::Other, &*v6296);
                                        Err(v6301)
                                    }
                                }
                            } else {
                                let v6327: string =
                                        sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                 v0_1.clone(), v3235.clone(),
                                                 v0_1.clone(), v3236.clone());
                                let v6332: std::io::Error =
                                    std::io::Error::new(std::io::ErrorKind::Other, &*v6327);
                                Err(v6332)
                            }
                        } else {
                            let v6357: string =
                                    sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                             v0_1.clone(), v3235,
                                             v0_1.clone(), v3236.clone());
                            let v6362: std::io::Error =
                                std::io::Error::new(std::io::ErrorKind::Other, &*v6357);
                            Err(v6362)
                        }
                    }
                }
            };
            let v19012: Option<std::path::PathBuf> = v6389.ok();
            let v19035: File_system::US14 = defaultValue(
                File_system::US14::US14_1,
                map(File_system::method83(), v19012),
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
        unbox::<string>(&defaultOf())
    }
    pub fn closure51(unitVar: (), unitVar_1: ()) -> string {
        let v4: File_system::US15 = File_system::method86(
            File_system::method59(string("polyglot"), string(".devcontainer")),
            string("C:\\home\\git\\polyglot\\lib\\spiral"),
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
            let v4: LrcPtr<dyn IDisposable> = File_system::method64(v0_1);
            ()
        }
        {
            let v5: string = File_system::method82(v1_1.clone());
            if File_system::method9(v5.clone()) == false {
                let v8: LrcPtr<dyn IDisposable> = File_system::method64(v5);
                ()
            }
            if if File_system::method9(v1_1.clone()) {
                let v6396: Result<std::path::PathBuf, std::io::Error> = if File_system::method9(
                    v1_1.clone(),
                ) {
                    std::fs::read_link(&*v1_1.clone())
                } else {
                    let v3208: Result<std::path::PathBuf, std::io::Error> =
                        std::fs::read_link(&*v1_1.clone());
                    let v3209 = File_system::method79();
                    let v3221: Result<std::path::PathBuf, string> = v3208.map_err(|x| v3209(x));
                    fn v3224(v: std::path::PathBuf) -> File_system::US13 {
                        File_system::closure47((), v)
                    }
                    fn v3225(v_1: string) -> File_system::US13 {
                        File_system::closure48((), v_1)
                    }
                    let v3226: File_system::US13 = match &v3221 {
                        Err(v3221_1_0) => v3225(v3221_1_0.clone()),
                        Ok(v3221_0_0) => v3224(v3221_0_0.clone()),
                    };
                    match &v3226 {
                        File_system::US13::US13_0(v3226_0_0) => Ok(v3226_0_0.clone()),
                        File_system::US13::US13_1(v3226_1_0) => {
                            let v3242: string = v3226_1_0.clone();
                            let v3243: string = File_system::method19(v1_1.clone());
                            let v3244: Option<string> = File_system::method81(v1_1.clone());
                            let v3258: File_system::US1 = defaultValue(
                                File_system::US1::US1_1,
                                map(File_system::method4(), v3244),
                            );
                            if let File_system::US1::US1_0(v3258_0_0) = &v3258 {
                                let v3262: string = match &v3258 {
                                    File_system::US1::US1_0(x) => x.clone(),
                                    _ => unreachable!(),
                                };
                                if v1_1.clone() != string("") {
                                    let v3268: Result<std::path::PathBuf, std::io::Error> =
                                        std::fs::read_link(&*v3262.clone());
                                    let v3269 = File_system::method79();
                                    let v3281: Result<std::path::PathBuf, string> =
                                        v3268.map_err(|x| v3269(x));
                                    let v3284: File_system::US13 = match &v3281 {
                                        Err(v3281_1_0) => v3225(v3281_1_0.clone()),
                                        Ok(v3281_0_0) => v3224(v3281_0_0.clone()),
                                    };
                                    let v6170: Result<std::path::PathBuf, std::io::Error> =
                                        match &v3284 {
                                            File_system::US13::US13_0(v3284_0_0) => {
                                                Ok(v3284_0_0.clone())
                                            }
                                            File_system::US13::US13_1(v3284_1_0) => {
                                                let v3300: string = v3284_1_0.clone();
                                                let v3301: string =
                                                    File_system::method19(v3262.clone());
                                                let v3302: Option<string> =
                                                    File_system::method81(v3262.clone());
                                                let v3316: File_system::US1 = defaultValue(
                                                    File_system::US1::US1_1,
                                                    map(File_system::method4(), v3302),
                                                );
                                                if let File_system::US1::US1_0(v3316_0_0) = &v3316 {
                                                    let v3320: string = match &v3316 {
                                                        File_system::US1::US1_0(x) => x.clone(),
                                                        _ => unreachable!(),
                                                    };
                                                    if v3262.clone() != string("") {
                                                        let v3325: Result<
                                                            std::path::PathBuf,
                                                            std::io::Error,
                                                        > = std::fs::read_link(&*v3320.clone());
                                                        let v3326 = File_system::method79();
                                                        let v3338: Result<
                                                            std::path::PathBuf,
                                                            string,
                                                        > = v3325.map_err(|x| v3326(x));
                                                        let v3341: File_system::US13 = match &v3338
                                                        {
                                                            Err(v3338_1_0) => {
                                                                v3225(v3338_1_0.clone())
                                                            }
                                                            Ok(v3338_0_0) => {
                                                                v3224(v3338_0_0.clone())
                                                            }
                                                        };
                                                        let v5945: Result<
                                                            std::path::PathBuf,
                                                            std::io::Error,
                                                        > = match &v3341 {
                                                            File_system::US13::US13_0(
                                                                v3341_0_0,
                                                            ) => Ok(v3341_0_0.clone()),
                                                            File_system::US13::US13_1(
                                                                v3341_1_0,
                                                            ) => {
                                                                let v3357: string =
                                                                    v3341_1_0.clone();
                                                                let v3358: string =
                                                                    File_system::method19(
                                                                        v3320.clone(),
                                                                    );
                                                                let v3359: Option<string> =
                                                                    File_system::method81(
                                                                        v3320.clone(),
                                                                    );
                                                                let v3373: File_system::US1 =
                                                                    defaultValue(
                                                                        File_system::US1::US1_1,
                                                                        map(
                                                                            File_system::method4(),
                                                                            v3359,
                                                                        ),
                                                                    );
                                                                if let File_system::US1::US1_0(
                                                                    v3373_0_0,
                                                                ) = &v3373
                                                                {
                                                                    let v3377: string = match &v3373
                                                                    {
                                                                        File_system::US1::US1_0(
                                                                            x,
                                                                        ) => x.clone(),
                                                                        _ => unreachable!(),
                                                                    };
                                                                    if v3320.clone() != string("") {
                                                                        let v3382: Result<
                                                                            std::path::PathBuf,
                                                                            std::io::Error,
                                                                        > = std::fs::read_link(
                                                                            &*v3377.clone(),
                                                                        );
                                                                        let v3383 =
                                                                            File_system::method79();
                                                                        let v3395: Result<
                                                                            std::path::PathBuf,
                                                                            string,
                                                                        > = v3382
                                                                            .map_err(|x| v3383(x));
                                                                        let v3398:
                                                                                           File_system::US13 =
                                                                                       match &v3395
                                                                                           {
                                                                                           Err(v3395_1_0)
                                                                                           =>
                                                                                           v3225(v3395_1_0.clone()),
                                                                                           Ok(v3395_0_0)
                                                                                           =>
                                                                                           v3224(v3395_0_0.clone()),
                                                                                       };
                                                                        let v5720:
                                                                                           Result<std::path::PathBuf,
                                                                                                  std::io::Error> =
                                                                                       match &v3398
                                                                                           {
                                                                                           File_system::US13::US13_0(v3398_0_0)
                                                                                           =>
                                                                                           Ok(v3398_0_0.clone()),
                                                                                           File_system::US13::US13_1(v3398_1_0)
                                                                                           =>
                                                                                           {
                                                                                               let v3414:
                                                                                                       string =
                                                                                                   v3398_1_0.clone();
                                                                                               let v3415:
                                                                                                       string =
                                                                                                   File_system::method19(v3377.clone());
                                                                                               let v3416:
                                                                                                       Option<string> =
                                                                                                   File_system::method81(v3377.clone());
                                                                                               let v3430:
                                                                                                       File_system::US1 =
                                                                                                   defaultValue(File_system::US1::US1_1,
                                                                                                                map(File_system::method4(),
                                                                                                                    v3416));
                                                                                               if let File_system::US1::US1_0(v3430_0_0)
                                                                                                      =
                                                                                                      &v3430
                                                                                                  {
                                                                                                   let v3434:
                                                                                                           string =
                                                                                                       match &v3430
                                                                                                           {
                                                                                                           File_system::US1::US1_0(x)
                                                                                                           =>
                                                                                                           x.clone(),
                                                                                                           _
                                                                                                           =>
                                                                                                           unreachable!(),
                                                                                                       };
                                                                                                   if v3377.clone()
                                                                                                          !=
                                                                                                          string("")
                                                                                                      {
                                                                                                       let v3439:
                                                                                                               Result<std::path::PathBuf,
                                                                                                                      std::io::Error> =
                                                                                                           std::fs::read_link(&*v3434.clone());
                                                                                                       let v3440 =
                                                                                                           File_system::method79();
                                                                                                       let v3452:
                                                                                                               Result<std::path::PathBuf,
                                                                                                                      string> =
                                                                                                           v3439.map_err(|x| v3440(x));
                                                                                                       let v3455:
                                                                                                               File_system::US13 =
                                                                                                           match &v3452
                                                                                                               {
                                                                                                               Err(v3452_1_0)
                                                                                                               =>
                                                                                                               v3225(v3452_1_0.clone()),
                                                                                                               Ok(v3452_0_0)
                                                                                                               =>
                                                                                                               v3224(v3452_0_0.clone()),
                                                                                                           };
                                                                                                       let v5495:
                                                                                                               Result<std::path::PathBuf,
                                                                                                                      std::io::Error> =
                                                                                                           match &v3455
                                                                                                               {
                                                                                                               File_system::US13::US13_0(v3455_0_0)
                                                                                                               =>
                                                                                                               Ok(v3455_0_0.clone()),
                                                                                                               File_system::US13::US13_1(v3455_1_0)
                                                                                                               =>
                                                                                                               {
                                                                                                                   let v3471:
                                                                                                                           string =
                                                                                                                       v3455_1_0.clone();
                                                                                                                   let v3472:
                                                                                                                           string =
                                                                                                                       File_system::method19(v3434.clone());
                                                                                                                   let v3473:
                                                                                                                           Option<string> =
                                                                                                                       File_system::method81(v3434.clone());
                                                                                                                   let v3487:
                                                                                                                           File_system::US1 =
                                                                                                                       defaultValue(File_system::US1::US1_1,
                                                                                                                                    map(File_system::method4(),
                                                                                                                                        v3473));
                                                                                                                   if let File_system::US1::US1_0(v3487_0_0)
                                                                                                                          =
                                                                                                                          &v3487
                                                                                                                      {
                                                                                                                       let v3491:
                                                                                                                               string =
                                                                                                                           match &v3487
                                                                                                                               {
                                                                                                                               File_system::US1::US1_0(x)
                                                                                                                               =>
                                                                                                                               x.clone(),
                                                                                                                               _
                                                                                                                               =>
                                                                                                                               unreachable!(),
                                                                                                                           };
                                                                                                                       if v3434.clone()
                                                                                                                              !=
                                                                                                                              string("")
                                                                                                                          {
                                                                                                                           let v3496:
                                                                                                                                   Result<std::path::PathBuf,
                                                                                                                                          std::io::Error> =
                                                                                                                               std::fs::read_link(&*v3491.clone());
                                                                                                                           let v3497 =
                                                                                                                               File_system::method79();
                                                                                                                           let v3509:
                                                                                                                                   Result<std::path::PathBuf,
                                                                                                                                          string> =
                                                                                                                               v3496.map_err(|x| v3497(x));
                                                                                                                           let v3512:
                                                                                                                                   File_system::US13 =
                                                                                                                               match &v3509
                                                                                                                                   {
                                                                                                                                   Err(v3509_1_0)
                                                                                                                                   =>
                                                                                                                                   v3225(v3509_1_0.clone()),
                                                                                                                                   Ok(v3509_0_0)
                                                                                                                                   =>
                                                                                                                                   v3224(v3509_0_0.clone()),
                                                                                                                               };
                                                                                                                           let v5270:
                                                                                                                                   Result<std::path::PathBuf,
                                                                                                                                          std::io::Error> =
                                                                                                                               match &v3512
                                                                                                                                   {
                                                                                                                                   File_system::US13::US13_0(v3512_0_0)
                                                                                                                                   =>
                                                                                                                                   Ok(v3512_0_0.clone()),
                                                                                                                                   File_system::US13::US13_1(v3512_1_0)
                                                                                                                                   =>
                                                                                                                                   {
                                                                                                                                       let v3528:
                                                                                                                                               string =
                                                                                                                                           v3512_1_0.clone();
                                                                                                                                       let v3529:
                                                                                                                                               string =
                                                                                                                                           File_system::method19(v3491.clone());
                                                                                                                                       let v3530:
                                                                                                                                               Option<string> =
                                                                                                                                           File_system::method81(v3491.clone());
                                                                                                                                       let v3544:
                                                                                                                                               File_system::US1 =
                                                                                                                                           defaultValue(File_system::US1::US1_1,
                                                                                                                                                        map(File_system::method4(),
                                                                                                                                                            v3530));
                                                                                                                                       if let File_system::US1::US1_0(v3544_0_0)
                                                                                                                                              =
                                                                                                                                              &v3544
                                                                                                                                          {
                                                                                                                                           let v3548:
                                                                                                                                                   string =
                                                                                                                                               match &v3544
                                                                                                                                                   {
                                                                                                                                                   File_system::US1::US1_0(x)
                                                                                                                                                   =>
                                                                                                                                                   x.clone(),
                                                                                                                                                   _
                                                                                                                                                   =>
                                                                                                                                                   unreachable!(),
                                                                                                                                               };
                                                                                                                                           if v3491.clone()
                                                                                                                                                  !=
                                                                                                                                                  string("")
                                                                                                                                              {
                                                                                                                                               let v3553:
                                                                                                                                                       Result<std::path::PathBuf,
                                                                                                                                                              std::io::Error> =
                                                                                                                                                   std::fs::read_link(&*v3548.clone());
                                                                                                                                               let v3554 =
                                                                                                                                                   File_system::method79();
                                                                                                                                               let v3566:
                                                                                                                                                       Result<std::path::PathBuf,
                                                                                                                                                              string> =
                                                                                                                                                   v3553.map_err(|x| v3554(x));
                                                                                                                                               let v3569:
                                                                                                                                                       File_system::US13 =
                                                                                                                                                   match &v3566
                                                                                                                                                       {
                                                                                                                                                       Err(v3566_1_0)
                                                                                                                                                       =>
                                                                                                                                                       v3225(v3566_1_0.clone()),
                                                                                                                                                       Ok(v3566_0_0)
                                                                                                                                                       =>
                                                                                                                                                       v3224(v3566_0_0.clone()),
                                                                                                                                                   };
                                                                                                                                               let v5045:
                                                                                                                                                       Result<std::path::PathBuf,
                                                                                                                                                              std::io::Error> =
                                                                                                                                                   match &v3569
                                                                                                                                                       {
                                                                                                                                                       File_system::US13::US13_0(v3569_0_0)
                                                                                                                                                       =>
                                                                                                                                                       Ok(v3569_0_0.clone()),
                                                                                                                                                       File_system::US13::US13_1(v3569_1_0)
                                                                                                                                                       =>
                                                                                                                                                       {
                                                                                                                                                           let v3585:
                                                                                                                                                                   string =
                                                                                                                                                               v3569_1_0.clone();
                                                                                                                                                           let v3586:
                                                                                                                                                                   string =
                                                                                                                                                               File_system::method19(v3548.clone());
                                                                                                                                                           let v3587:
                                                                                                                                                                   Option<string> =
                                                                                                                                                               File_system::method81(v3548.clone());
                                                                                                                                                           let v3601:
                                                                                                                                                                   File_system::US1 =
                                                                                                                                                               defaultValue(File_system::US1::US1_1,
                                                                                                                                                                            map(File_system::method4(),
                                                                                                                                                                                v3587));
                                                                                                                                                           if let File_system::US1::US1_0(v3601_0_0)
                                                                                                                                                                  =
                                                                                                                                                                  &v3601
                                                                                                                                                              {
                                                                                                                                                               let v3605:
                                                                                                                                                                       string =
                                                                                                                                                                   match &v3601
                                                                                                                                                                       {
                                                                                                                                                                       File_system::US1::US1_0(x)
                                                                                                                                                                       =>
                                                                                                                                                                       x.clone(),
                                                                                                                                                                       _
                                                                                                                                                                       =>
                                                                                                                                                                       unreachable!(),
                                                                                                                                                                   };
                                                                                                                                                               if v3548.clone()
                                                                                                                                                                      !=
                                                                                                                                                                      string("")
                                                                                                                                                                  {
                                                                                                                                                                   let v3610:
                                                                                                                                                                           Result<std::path::PathBuf,
                                                                                                                                                                                  std::io::Error> =
                                                                                                                                                                       std::fs::read_link(&*v3605.clone());
                                                                                                                                                                   let v3611 =
                                                                                                                                                                       File_system::method79();
                                                                                                                                                                   let v3623:
                                                                                                                                                                           Result<std::path::PathBuf,
                                                                                                                                                                                  string> =
                                                                                                                                                                       v3610.map_err(|x| v3611(x));
                                                                                                                                                                   let v3626:
                                                                                                                                                                           File_system::US13 =
                                                                                                                                                                       match &v3623
                                                                                                                                                                           {
                                                                                                                                                                           Err(v3623_1_0)
                                                                                                                                                                           =>
                                                                                                                                                                           v3225(v3623_1_0.clone()),
                                                                                                                                                                           Ok(v3623_0_0)
                                                                                                                                                                           =>
                                                                                                                                                                           v3224(v3623_0_0.clone()),
                                                                                                                                                                       };
                                                                                                                                                                   let v4820:
                                                                                                                                                                           Result<std::path::PathBuf,
                                                                                                                                                                                  std::io::Error> =
                                                                                                                                                                       match &v3626
                                                                                                                                                                           {
                                                                                                                                                                           File_system::US13::US13_0(v3626_0_0)
                                                                                                                                                                           =>
                                                                                                                                                                           Ok(v3626_0_0.clone()),
                                                                                                                                                                           File_system::US13::US13_1(v3626_1_0)
                                                                                                                                                                           =>
                                                                                                                                                                           {
                                                                                                                                                                               let v3642:
                                                                                                                                                                                       string =
                                                                                                                                                                                   v3626_1_0.clone();
                                                                                                                                                                               let v3643:
                                                                                                                                                                                       string =
                                                                                                                                                                                   File_system::method19(v3605.clone());
                                                                                                                                                                               let v3644:
                                                                                                                                                                                       Option<string> =
                                                                                                                                                                                   File_system::method81(v3605.clone());
                                                                                                                                                                               let v3658:
                                                                                                                                                                                       File_system::US1 =
                                                                                                                                                                                   defaultValue(File_system::US1::US1_1,
                                                                                                                                                                                                map(File_system::method4(),
                                                                                                                                                                                                    v3644));
                                                                                                                                                                               if let File_system::US1::US1_0(v3658_0_0)
                                                                                                                                                                                      =
                                                                                                                                                                                      &v3658
                                                                                                                                                                                  {
                                                                                                                                                                                   let v3662:
                                                                                                                                                                                           string =
                                                                                                                                                                                       match &v3658
                                                                                                                                                                                           {
                                                                                                                                                                                           File_system::US1::US1_0(x)
                                                                                                                                                                                           =>
                                                                                                                                                                                           x.clone(),
                                                                                                                                                                                           _
                                                                                                                                                                                           =>
                                                                                                                                                                                           unreachable!(),
                                                                                                                                                                                       };
                                                                                                                                                                                   if v3605.clone()
                                                                                                                                                                                          !=
                                                                                                                                                                                          string("")
                                                                                                                                                                                      {
                                                                                                                                                                                       let v3667:
                                                                                                                                                                                               Result<std::path::PathBuf,
                                                                                                                                                                                                      std::io::Error> =
                                                                                                                                                                                           std::fs::read_link(&*v3662.clone());
                                                                                                                                                                                       let v3668 =
                                                                                                                                                                                           File_system::method79();
                                                                                                                                                                                       let v3680:
                                                                                                                                                                                               Result<std::path::PathBuf,
                                                                                                                                                                                                      string> =
                                                                                                                                                                                           v3667.map_err(|x| v3668(x));
                                                                                                                                                                                       let v3683:
                                                                                                                                                                                               File_system::US13 =
                                                                                                                                                                                           match &v3680
                                                                                                                                                                                               {
                                                                                                                                                                                               Err(v3680_1_0)
                                                                                                                                                                                               =>
                                                                                                                                                                                               v3225(v3680_1_0.clone()),
                                                                                                                                                                                               Ok(v3680_0_0)
                                                                                                                                                                                               =>
                                                                                                                                                                                               v3224(v3680_0_0.clone()),
                                                                                                                                                                                           };
                                                                                                                                                                                       let v4595:
                                                                                                                                                                                               Result<std::path::PathBuf,
                                                                                                                                                                                                      std::io::Error> =
                                                                                                                                                                                           match &v3683
                                                                                                                                                                                               {
                                                                                                                                                                                               File_system::US13::US13_0(v3683_0_0)
                                                                                                                                                                                               =>
                                                                                                                                                                                               Ok(v3683_0_0.clone()),
                                                                                                                                                                                               File_system::US13::US13_1(v3683_1_0)
                                                                                                                                                                                               =>
                                                                                                                                                                                               {
                                                                                                                                                                                                   let v3699:
                                                                                                                                                                                                           string =
                                                                                                                                                                                                       v3683_1_0.clone();
                                                                                                                                                                                                   let v3700:
                                                                                                                                                                                                           string =
                                                                                                                                                                                                       File_system::method19(v3662.clone());
                                                                                                                                                                                                   let v3701:
                                                                                                                                                                                                           Option<string> =
                                                                                                                                                                                                       File_system::method81(v3662.clone());
                                                                                                                                                                                                   let v3715:
                                                                                                                                                                                                           File_system::US1 =
                                                                                                                                                                                                       defaultValue(File_system::US1::US1_1,
                                                                                                                                                                                                                    map(File_system::method4(),
                                                                                                                                                                                                                        v3701));
                                                                                                                                                                                                   if let File_system::US1::US1_0(v3715_0_0)
                                                                                                                                                                                                          =
                                                                                                                                                                                                          &v3715
                                                                                                                                                                                                      {
                                                                                                                                                                                                       let v3719:
                                                                                                                                                                                                               string =
                                                                                                                                                                                                           match &v3715
                                                                                                                                                                                                               {
                                                                                                                                                                                                               File_system::US1::US1_0(x)
                                                                                                                                                                                                               =>
                                                                                                                                                                                                               x.clone(),
                                                                                                                                                                                                               _
                                                                                                                                                                                                               =>
                                                                                                                                                                                                               unreachable!(),
                                                                                                                                                                                                           };
                                                                                                                                                                                                       if v3662.clone()
                                                                                                                                                                                                              !=
                                                                                                                                                                                                              string("")
                                                                                                                                                                                                          {
                                                                                                                                                                                                           let v3724:
                                                                                                                                                                                                                   Result<std::path::PathBuf,
                                                                                                                                                                                                                          std::io::Error> =
                                                                                                                                                                                                               std::fs::read_link(&*v3719.clone());
                                                                                                                                                                                                           let v3725 =
                                                                                                                                                                                                               File_system::method79();
                                                                                                                                                                                                           let v3737:
                                                                                                                                                                                                                   Result<std::path::PathBuf,
                                                                                                                                                                                                                          string> =
                                                                                                                                                                                                               v3724.map_err(|x| v3725(x));
                                                                                                                                                                                                           let v3740:
                                                                                                                                                                                                                   File_system::US13 =
                                                                                                                                                                                                               match &v3737
                                                                                                                                                                                                                   {
                                                                                                                                                                                                                   Err(v3737_1_0)
                                                                                                                                                                                                                   =>
                                                                                                                                                                                                                   v3225(v3737_1_0.clone()),
                                                                                                                                                                                                                   Ok(v3737_0_0)
                                                                                                                                                                                                                   =>
                                                                                                                                                                                                                   v3224(v3737_0_0.clone()),
                                                                                                                                                                                                               };
                                                                                                                                                                                                           let v4370:
                                                                                                                                                                                                                   Result<std::path::PathBuf,
                                                                                                                                                                                                                          std::io::Error> =
                                                                                                                                                                                                               match &v3740
                                                                                                                                                                                                                   {
                                                                                                                                                                                                                   File_system::US13::US13_0(v3740_0_0)
                                                                                                                                                                                                                   =>
                                                                                                                                                                                                                   Ok(v3740_0_0.clone()),
                                                                                                                                                                                                                   File_system::US13::US13_1(v3740_1_0)
                                                                                                                                                                                                                   =>
                                                                                                                                                                                                                   {
                                                                                                                                                                                                                       let v3756:
                                                                                                                                                                                                                               string =
                                                                                                                                                                                                                           v3740_1_0.clone();
                                                                                                                                                                                                                       let v3757:
                                                                                                                                                                                                                               string =
                                                                                                                                                                                                                           File_system::method19(v3719.clone());
                                                                                                                                                                                                                       let v3758:
                                                                                                                                                                                                                               Option<string> =
                                                                                                                                                                                                                           File_system::method81(v3719.clone());
                                                                                                                                                                                                                       let v3772:
                                                                                                                                                                                                                               File_system::US1 =
                                                                                                                                                                                                                           defaultValue(File_system::US1::US1_1,
                                                                                                                                                                                                                                        map(File_system::method4(),
                                                                                                                                                                                                                                            v3758));
                                                                                                                                                                                                                       if let File_system::US1::US1_0(v3772_0_0)
                                                                                                                                                                                                                              =
                                                                                                                                                                                                                              &v3772
                                                                                                                                                                                                                          {
                                                                                                                                                                                                                           let v3776:
                                                                                                                                                                                                                                   string =
                                                                                                                                                                                                                               match &v3772
                                                                                                                                                                                                                                   {
                                                                                                                                                                                                                                   File_system::US1::US1_0(x)
                                                                                                                                                                                                                                   =>
                                                                                                                                                                                                                                   x.clone(),
                                                                                                                                                                                                                                   _
                                                                                                                                                                                                                                   =>
                                                                                                                                                                                                                                   unreachable!(),
                                                                                                                                                                                                                               };
                                                                                                                                                                                                                           if v3719.clone()
                                                                                                                                                                                                                                  !=
                                                                                                                                                                                                                                  string("")
                                                                                                                                                                                                                              {
                                                                                                                                                                                                                               let v3781:
                                                                                                                                                                                                                                       Result<std::path::PathBuf,
                                                                                                                                                                                                                                              std::io::Error> =
                                                                                                                                                                                                                                   std::fs::read_link(&*v3776.clone());
                                                                                                                                                                                                                               let v3782 =
                                                                                                                                                                                                                                   File_system::method79();
                                                                                                                                                                                                                               let v3794:
                                                                                                                                                                                                                                       Result<std::path::PathBuf,
                                                                                                                                                                                                                                              string> =
                                                                                                                                                                                                                                   v3781.map_err(|x| v3782(x));
                                                                                                                                                                                                                               let v3797:
                                                                                                                                                                                                                                       File_system::US13 =
                                                                                                                                                                                                                                   match &v3794
                                                                                                                                                                                                                                       {
                                                                                                                                                                                                                                       Err(v3794_1_0)
                                                                                                                                                                                                                                       =>
                                                                                                                                                                                                                                       v3225(v3794_1_0.clone()),
                                                                                                                                                                                                                                       Ok(v3794_0_0)
                                                                                                                                                                                                                                       =>
                                                                                                                                                                                                                                       v3224(v3794_0_0.clone()),
                                                                                                                                                                                                                                   };
                                                                                                                                                                                                                               let v4145:
                                                                                                                                                                                                                                       Result<std::path::PathBuf,
                                                                                                                                                                                                                                              std::io::Error> =
                                                                                                                                                                                                                                   match &v3797
                                                                                                                                                                                                                                       {
                                                                                                                                                                                                                                       File_system::US13::US13_0(v3797_0_0)
                                                                                                                                                                                                                                       =>
                                                                                                                                                                                                                                       Ok(v3797_0_0.clone()),
                                                                                                                                                                                                                                       File_system::US13::US13_1(v3797_1_0)
                                                                                                                                                                                                                                       =>
                                                                                                                                                                                                                                       {
                                                                                                                                                                                                                                           let v3813:
                                                                                                                                                                                                                                                   string =
                                                                                                                                                                                                                                               v3797_1_0.clone();
                                                                                                                                                                                                                                           let v3814:
                                                                                                                                                                                                                                                   string =
                                                                                                                                                                                                                                               File_system::method19(v3776.clone());
                                                                                                                                                                                                                                           let v3815:
                                                                                                                                                                                                                                                   Option<string> =
                                                                                                                                                                                                                                               File_system::method81(v3776.clone());
                                                                                                                                                                                                                                           let v3829:
                                                                                                                                                                                                                                                   File_system::US1 =
                                                                                                                                                                                                                                               defaultValue(File_system::US1::US1_1,
                                                                                                                                                                                                                                                            map(File_system::method4(),
                                                                                                                                                                                                                                                                v3815));
                                                                                                                                                                                                                                           if let File_system::US1::US1_0(v3829_0_0)
                                                                                                                                                                                                                                                  =
                                                                                                                                                                                                                                                  &v3829
                                                                                                                                                                                                                                              {
                                                                                                                                                                                                                                               let v3833:
                                                                                                                                                                                                                                                       string =
                                                                                                                                                                                                                                                   match &v3829
                                                                                                                                                                                                                                                       {
                                                                                                                                                                                                                                                       File_system::US1::US1_0(x)
                                                                                                                                                                                                                                                       =>
                                                                                                                                                                                                                                                       x.clone(),
                                                                                                                                                                                                                                                       _
                                                                                                                                                                                                                                                       =>
                                                                                                                                                                                                                                                       unreachable!(),
                                                                                                                                                                                                                                                   };
                                                                                                                                                                                                                                               if v3776.clone()
                                                                                                                                                                                                                                                      !=
                                                                                                                                                                                                                                                      string("")
                                                                                                                                                                                                                                                  {
                                                                                                                                                                                                                                                   let v3838:
                                                                                                                                                                                                                                                           Result<std::path::PathBuf,
                                                                                                                                                                                                                                                                  std::io::Error> =
                                                                                                                                                                                                                                                       std::fs::read_link(&*v3833.clone());
                                                                                                                                                                                                                                                   let v3839 =
                                                                                                                                                                                                                                                       File_system::method79();
                                                                                                                                                                                                                                                   let v3851:
                                                                                                                                                                                                                                                           Result<std::path::PathBuf,
                                                                                                                                                                                                                                                                  string> =
                                                                                                                                                                                                                                                       v3838.map_err(|x| v3839(x));
                                                                                                                                                                                                                                                   let v3854:
                                                                                                                                                                                                                                                           File_system::US13 =
                                                                                                                                                                                                                                                       match &v3851
                                                                                                                                                                                                                                                           {
                                                                                                                                                                                                                                                           Err(v3851_1_0)
                                                                                                                                                                                                                                                           =>
                                                                                                                                                                                                                                                           v3225(v3851_1_0.clone()),
                                                                                                                                                                                                                                                           Ok(v3851_0_0)
                                                                                                                                                                                                                                                           =>
                                                                                                                                                                                                                                                           v3224(v3851_0_0.clone()),
                                                                                                                                                                                                                                                       };
                                                                                                                                                                                                                                                   let v3920:
                                                                                                                                                                                                                                                           Result<std::path::PathBuf,
                                                                                                                                                                                                                                                                  std::io::Error> =
                                                                                                                                                                                                                                                       match &v3854
                                                                                                                                                                                                                                                           {
                                                                                                                                                                                                                                                           File_system::US13::US13_0(v3854_0_0)
                                                                                                                                                                                                                                                           =>
                                                                                                                                                                                                                                                           Ok(v3854_0_0.clone()),
                                                                                                                                                                                                                                                           _
                                                                                                                                                                                                                                                           =>
                                                                                                                                                                                                                                                           {
                                                                                                                                                                                                                                                               let v3871:
                                                                                                                                                                                                                                                                       string =
                                                                                                                                                                                                                                                                   File_system::method19(v3833.clone());
                                                                                                                                                                                                                                                               let v3872:
                                                                                                                                                                                                                                                                       Option<string> =
                                                                                                                                                                                                                                                                   File_system::method81(v3833.clone());
                                                                                                                                                                                                                                                               let v3886:
                                                                                                                                                                                                                                                                       File_system::US1 =
                                                                                                                                                                                                                                                                   defaultValue(File_system::US1::US1_1,
                                                                                                                                                                                                                                                                                map(File_system::method4(),
                                                                                                                                                                                                                                                                                    v3872));
                                                                                                                                                                                                                                                               let v3890:
                                                                                                                                                                                                                                                                       string =
                                                                                                                                                                                                                                                                   sprintf!("file_system.read_link / path: {} / n: {} / path\': {} / name: {}",
                                                                                                                                                                                                                                                                            v1_1.clone(),
                                                                                                                                                                                                                                                                            11_u8,
                                                                                                                                                                                                                                                                            v3833.clone(),
                                                                                                                                                                                                                                                                            v3871);
                                                                                                                                                                                                                                                               let v3895:
                                                                                                                                                                                                                                                                       std::io::Error =
                                                                                                                                                                                                                                                                   std::io::Error::new(std::io::ErrorKind::Other, &*v3890);
                                                                                                                                                                                                                                                               Err(v3895)
                                                                                                                                                                                                                                                           }
                                                                                                                                                                                                                                                       };
                                                                                                                                                                                                                                                   let v3921 =
                                                                                                                                                                                                                                                       File_system::method79();
                                                                                                                                                                                                                                                   let v3933:
                                                                                                                                                                                                                                                           Result<std::path::PathBuf,
                                                                                                                                                                                                                                                                  string> =
                                                                                                                                                                                                                                                       v3920.map_err(|x| v3921(x));
                                                                                                                                                                                                                                                   let v3936:
                                                                                                                                                                                                                                                           File_system::US13 =
                                                                                                                                                                                                                                                       match &v3933
                                                                                                                                                                                                                                                           {
                                                                                                                                                                                                                                                           Err(v3933_1_0)
                                                                                                                                                                                                                                                           =>
                                                                                                                                                                                                                                                           v3225(v3933_1_0.clone()),
                                                                                                                                                                                                                                                           Ok(v3933_0_0)
                                                                                                                                                                                                                                                           =>
                                                                                                                                                                                                                                                           v3224(v3933_0_0.clone()),
                                                                                                                                                                                                                                                       };
                                                                                                                                                                                                                                                   match &v3936
                                                                                                                                                                                                                                                       {
                                                                                                                                                                                                                                                       File_system::US13::US13_0(v3936_0_0)
                                                                                                                                                                                                                                                       =>
                                                                                                                                                                                                                                                       {
                                                                                                                                                                                                                                                           let v3965:
                                                                                                                                                                                                                                                                   string =
                                                                                                                                                                                                                                                               File_system::method59(toString(v3936_0_0.clone().display()),
                                                                                                                                                                                                                                                                                     v3814.clone());
                                                                                                                                                                                                                                                           let v3970:
                                                                                                                                                                                                                                                                   &str =
                                                                                                                                                                                                                                                               &*v3965;
                                                                                                                                                                                                                                                           let v3994:
                                                                                                                                                                                                                                                                   std::string::String =
                                                                                                                                                                                                                                                               String::from(v3970);
                                                                                                                                                                                                                                                           let v4018:
                                                                                                                                                                                                                                                                   std::path::PathBuf =
                                                                                                                                                                                                                                                               std::path::PathBuf::from(v3994);
                                                                                                                                                                                                                                                           Ok(v4018)
                                                                                                                                                                                                                                                       }
                                                                                                                                                                                                                                                       File_system::US13::US13_1(v3936_1_0)
                                                                                                                                                                                                                                                       =>
                                                                                                                                                                                                                                                       {
                                                                                                                                                                                                                                                           let v4053:
                                                                                                                                                                                                                                                                   string =
                                                                                                                                                                                                                                                               sprintf!("file_system.read_link / error\': {} / error: {} / name: {}",
                                                                                                                                                                                                                                                                        v3936_1_0.clone(),
                                                                                                                                                                                                                                                                        v3813.clone(),
                                                                                                                                                                                                                                                                        v3814.clone());
                                                                                                                                                                                                                                                           let v4058:
                                                                                                                                                                                                                                                                   std::io::Error =
                                                                                                                                                                                                                                                               std::io::Error::new(std::io::ErrorKind::Other, &*v4053);
                                                                                                                                                                                                                                                           Err(v4058)
                                                                                                                                                                                                                                                       }
                                                                                                                                                                                                                                                   }
                                                                                                                                                                                                                                               } else {
                                                                                                                                                                                                                                                   let v4084:
                                                                                                                                                                                                                                                           string =
                                                                                                                                                                                                                                                       sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                                                                                                                                                                                                                                v1_1.clone(),
                                                                                                                                                                                                                                                                v3813.clone(),
                                                                                                                                                                                                                                                                v3776.clone(),
                                                                                                                                                                                                                                                                v3814.clone());
                                                                                                                                                                                                                                                   let v4089:
                                                                                                                                                                                                                                                           std::io::Error =
                                                                                                                                                                                                                                                       std::io::Error::new(std::io::ErrorKind::Other, &*v4084);
                                                                                                                                                                                                                                                   Err(v4089)
                                                                                                                                                                                                                                               }
                                                                                                                                                                                                                                           } else {
                                                                                                                                                                                                                                               let v4114:
                                                                                                                                                                                                                                                       string =
                                                                                                                                                                                                                                                   sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                                                                                                                                                                                                                            v1_1.clone(),
                                                                                                                                                                                                                                                            v3813,
                                                                                                                                                                                                                                                            v3776.clone(),
                                                                                                                                                                                                                                                            v3814.clone());
                                                                                                                                                                                                                                               let v4119:
                                                                                                                                                                                                                                                       std::io::Error =
                                                                                                                                                                                                                                                   std::io::Error::new(std::io::ErrorKind::Other, &*v4114);
                                                                                                                                                                                                                                               Err(v4119)
                                                                                                                                                                                                                                           }
                                                                                                                                                                                                                                       }
                                                                                                                                                                                                                                   };
                                                                                                                                                                                                                               let v4146 =
                                                                                                                                                                                                                                   File_system::method79();
                                                                                                                                                                                                                               let v4158:
                                                                                                                                                                                                                                       Result<std::path::PathBuf,
                                                                                                                                                                                                                                              string> =
                                                                                                                                                                                                                                   v4145.map_err(|x| v4146(x));
                                                                                                                                                                                                                               let v4161:
                                                                                                                                                                                                                                       File_system::US13 =
                                                                                                                                                                                                                                   match &v4158
                                                                                                                                                                                                                                       {
                                                                                                                                                                                                                                       Err(v4158_1_0)
                                                                                                                                                                                                                                       =>
                                                                                                                                                                                                                                       v3225(v4158_1_0.clone()),
                                                                                                                                                                                                                                       Ok(v4158_0_0)
                                                                                                                                                                                                                                       =>
                                                                                                                                                                                                                                       v3224(v4158_0_0.clone()),
                                                                                                                                                                                                                                   };
                                                                                                                                                                                                                               match &v4161
                                                                                                                                                                                                                                   {
                                                                                                                                                                                                                                   File_system::US13::US13_0(v4161_0_0)
                                                                                                                                                                                                                                   =>
                                                                                                                                                                                                                                   {
                                                                                                                                                                                                                                       let v4190:
                                                                                                                                                                                                                                               string =
                                                                                                                                                                                                                                           File_system::method59(toString(v4161_0_0.clone().display()),
                                                                                                                                                                                                                                                                 v3757.clone());
                                                                                                                                                                                                                                       let v4195:
                                                                                                                                                                                                                                               &str =
                                                                                                                                                                                                                                           &*v4190;
                                                                                                                                                                                                                                       let v4219:
                                                                                                                                                                                                                                               std::string::String =
                                                                                                                                                                                                                                           String::from(v4195);
                                                                                                                                                                                                                                       let v4243:
                                                                                                                                                                                                                                               std::path::PathBuf =
                                                                                                                                                                                                                                           std::path::PathBuf::from(v4219);
                                                                                                                                                                                                                                       Ok(v4243)
                                                                                                                                                                                                                                   }
                                                                                                                                                                                                                                   File_system::US13::US13_1(v4161_1_0)
                                                                                                                                                                                                                                   =>
                                                                                                                                                                                                                                   {
                                                                                                                                                                                                                                       let v4278:
                                                                                                                                                                                                                                               string =
                                                                                                                                                                                                                                           sprintf!("file_system.read_link / error\': {} / error: {} / name: {}",
                                                                                                                                                                                                                                                    v4161_1_0.clone(),
                                                                                                                                                                                                                                                    v3756.clone(),
                                                                                                                                                                                                                                                    v3757.clone());
                                                                                                                                                                                                                                       let v4283:
                                                                                                                                                                                                                                               std::io::Error =
                                                                                                                                                                                                                                           std::io::Error::new(std::io::ErrorKind::Other, &*v4278);
                                                                                                                                                                                                                                       Err(v4283)
                                                                                                                                                                                                                                   }
                                                                                                                                                                                                                               }
                                                                                                                                                                                                                           } else {
                                                                                                                                                                                                                               let v4309:
                                                                                                                                                                                                                                       string =
                                                                                                                                                                                                                                   sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                                                                                                                                                                                                            v1_1.clone(),
                                                                                                                                                                                                                                            v3756.clone(),
                                                                                                                                                                                                                                            v3719.clone(),
                                                                                                                                                                                                                                            v3757.clone());
                                                                                                                                                                                                                               let v4314:
                                                                                                                                                                                                                                       std::io::Error =
                                                                                                                                                                                                                                   std::io::Error::new(std::io::ErrorKind::Other, &*v4309);
                                                                                                                                                                                                                               Err(v4314)
                                                                                                                                                                                                                           }
                                                                                                                                                                                                                       } else {
                                                                                                                                                                                                                           let v4339:
                                                                                                                                                                                                                                   string =
                                                                                                                                                                                                                               sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                                                                                                                                                                                                        v1_1.clone(),
                                                                                                                                                                                                                                        v3756,
                                                                                                                                                                                                                                        v3719.clone(),
                                                                                                                                                                                                                                        v3757.clone());
                                                                                                                                                                                                                           let v4344:
                                                                                                                                                                                                                                   std::io::Error =
                                                                                                                                                                                                                               std::io::Error::new(std::io::ErrorKind::Other, &*v4339);
                                                                                                                                                                                                                           Err(v4344)
                                                                                                                                                                                                                       }
                                                                                                                                                                                                                   }
                                                                                                                                                                                                               };
                                                                                                                                                                                                           let v4371 =
                                                                                                                                                                                                               File_system::method79();
                                                                                                                                                                                                           let v4383:
                                                                                                                                                                                                                   Result<std::path::PathBuf,
                                                                                                                                                                                                                          string> =
                                                                                                                                                                                                               v4370.map_err(|x| v4371(x));
                                                                                                                                                                                                           let v4386:
                                                                                                                                                                                                                   File_system::US13 =
                                                                                                                                                                                                               match &v4383
                                                                                                                                                                                                                   {
                                                                                                                                                                                                                   Err(v4383_1_0)
                                                                                                                                                                                                                   =>
                                                                                                                                                                                                                   v3225(v4383_1_0.clone()),
                                                                                                                                                                                                                   Ok(v4383_0_0)
                                                                                                                                                                                                                   =>
                                                                                                                                                                                                                   v3224(v4383_0_0.clone()),
                                                                                                                                                                                                               };
                                                                                                                                                                                                           match &v4386
                                                                                                                                                                                                               {
                                                                                                                                                                                                               File_system::US13::US13_0(v4386_0_0)
                                                                                                                                                                                                               =>
                                                                                                                                                                                                               {
                                                                                                                                                                                                                   let v4415:
                                                                                                                                                                                                                           string =
                                                                                                                                                                                                                       File_system::method59(toString(v4386_0_0.clone().display()),
                                                                                                                                                                                                                                             v3700.clone());
                                                                                                                                                                                                                   let v4420:
                                                                                                                                                                                                                           &str =
                                                                                                                                                                                                                       &*v4415;
                                                                                                                                                                                                                   let v4444:
                                                                                                                                                                                                                           std::string::String =
                                                                                                                                                                                                                       String::from(v4420);
                                                                                                                                                                                                                   let v4468:
                                                                                                                                                                                                                           std::path::PathBuf =
                                                                                                                                                                                                                       std::path::PathBuf::from(v4444);
                                                                                                                                                                                                                   Ok(v4468)
                                                                                                                                                                                                               }
                                                                                                                                                                                                               File_system::US13::US13_1(v4386_1_0)
                                                                                                                                                                                                               =>
                                                                                                                                                                                                               {
                                                                                                                                                                                                                   let v4503:
                                                                                                                                                                                                                           string =
                                                                                                                                                                                                                       sprintf!("file_system.read_link / error\': {} / error: {} / name: {}",
                                                                                                                                                                                                                                v4386_1_0.clone(),
                                                                                                                                                                                                                                v3699.clone(),
                                                                                                                                                                                                                                v3700.clone());
                                                                                                                                                                                                                   let v4508:
                                                                                                                                                                                                                           std::io::Error =
                                                                                                                                                                                                                       std::io::Error::new(std::io::ErrorKind::Other, &*v4503);
                                                                                                                                                                                                                   Err(v4508)
                                                                                                                                                                                                               }
                                                                                                                                                                                                           }
                                                                                                                                                                                                       } else {
                                                                                                                                                                                                           let v4534:
                                                                                                                                                                                                                   string =
                                                                                                                                                                                                               sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                                                                                                                                                                                        v1_1.clone(),
                                                                                                                                                                                                                        v3699.clone(),
                                                                                                                                                                                                                        v3662.clone(),
                                                                                                                                                                                                                        v3700.clone());
                                                                                                                                                                                                           let v4539:
                                                                                                                                                                                                                   std::io::Error =
                                                                                                                                                                                                               std::io::Error::new(std::io::ErrorKind::Other, &*v4534);
                                                                                                                                                                                                           Err(v4539)
                                                                                                                                                                                                       }
                                                                                                                                                                                                   } else {
                                                                                                                                                                                                       let v4564:
                                                                                                                                                                                                               string =
                                                                                                                                                                                                           sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                                                                                                                                                                                    v1_1.clone(),
                                                                                                                                                                                                                    v3699,
                                                                                                                                                                                                                    v3662.clone(),
                                                                                                                                                                                                                    v3700.clone());
                                                                                                                                                                                                       let v4569:
                                                                                                                                                                                                               std::io::Error =
                                                                                                                                                                                                           std::io::Error::new(std::io::ErrorKind::Other, &*v4564);
                                                                                                                                                                                                       Err(v4569)
                                                                                                                                                                                                   }
                                                                                                                                                                                               }
                                                                                                                                                                                           };
                                                                                                                                                                                       let v4596 =
                                                                                                                                                                                           File_system::method79();
                                                                                                                                                                                       let v4608:
                                                                                                                                                                                               Result<std::path::PathBuf,
                                                                                                                                                                                                      string> =
                                                                                                                                                                                           v4595.map_err(|x| v4596(x));
                                                                                                                                                                                       let v4611:
                                                                                                                                                                                               File_system::US13 =
                                                                                                                                                                                           match &v4608
                                                                                                                                                                                               {
                                                                                                                                                                                               Err(v4608_1_0)
                                                                                                                                                                                               =>
                                                                                                                                                                                               v3225(v4608_1_0.clone()),
                                                                                                                                                                                               Ok(v4608_0_0)
                                                                                                                                                                                               =>
                                                                                                                                                                                               v3224(v4608_0_0.clone()),
                                                                                                                                                                                           };
                                                                                                                                                                                       match &v4611
                                                                                                                                                                                           {
                                                                                                                                                                                           File_system::US13::US13_0(v4611_0_0)
                                                                                                                                                                                           =>
                                                                                                                                                                                           {
                                                                                                                                                                                               let v4640:
                                                                                                                                                                                                       string =
                                                                                                                                                                                                   File_system::method59(toString(v4611_0_0.clone().display()),
                                                                                                                                                                                                                         v3643.clone());
                                                                                                                                                                                               let v4645:
                                                                                                                                                                                                       &str =
                                                                                                                                                                                                   &*v4640;
                                                                                                                                                                                               let v4669:
                                                                                                                                                                                                       std::string::String =
                                                                                                                                                                                                   String::from(v4645);
                                                                                                                                                                                               let v4693:
                                                                                                                                                                                                       std::path::PathBuf =
                                                                                                                                                                                                   std::path::PathBuf::from(v4669);
                                                                                                                                                                                               Ok(v4693)
                                                                                                                                                                                           }
                                                                                                                                                                                           File_system::US13::US13_1(v4611_1_0)
                                                                                                                                                                                           =>
                                                                                                                                                                                           {
                                                                                                                                                                                               let v4728:
                                                                                                                                                                                                       string =
                                                                                                                                                                                                   sprintf!("file_system.read_link / error\': {} / error: {} / name: {}",
                                                                                                                                                                                                            v4611_1_0.clone(),
                                                                                                                                                                                                            v3642.clone(),
                                                                                                                                                                                                            v3643.clone());
                                                                                                                                                                                               let v4733:
                                                                                                                                                                                                       std::io::Error =
                                                                                                                                                                                                   std::io::Error::new(std::io::ErrorKind::Other, &*v4728);
                                                                                                                                                                                               Err(v4733)
                                                                                                                                                                                           }
                                                                                                                                                                                       }
                                                                                                                                                                                   } else {
                                                                                                                                                                                       let v4759:
                                                                                                                                                                                               string =
                                                                                                                                                                                           sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                                                                                                                                                                    v1_1.clone(),
                                                                                                                                                                                                    v3642.clone(),
                                                                                                                                                                                                    v3605.clone(),
                                                                                                                                                                                                    v3643.clone());
                                                                                                                                                                                       let v4764:
                                                                                                                                                                                               std::io::Error =
                                                                                                                                                                                           std::io::Error::new(std::io::ErrorKind::Other, &*v4759);
                                                                                                                                                                                       Err(v4764)
                                                                                                                                                                                   }
                                                                                                                                                                               } else {
                                                                                                                                                                                   let v4789:
                                                                                                                                                                                           string =
                                                                                                                                                                                       sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                                                                                                                                                                v1_1.clone(),
                                                                                                                                                                                                v3642,
                                                                                                                                                                                                v3605.clone(),
                                                                                                                                                                                                v3643.clone());
                                                                                                                                                                                   let v4794:
                                                                                                                                                                                           std::io::Error =
                                                                                                                                                                                       std::io::Error::new(std::io::ErrorKind::Other, &*v4789);
                                                                                                                                                                                   Err(v4794)
                                                                                                                                                                               }
                                                                                                                                                                           }
                                                                                                                                                                       };
                                                                                                                                                                   let v4821 =
                                                                                                                                                                       File_system::method79();
                                                                                                                                                                   let v4833:
                                                                                                                                                                           Result<std::path::PathBuf,
                                                                                                                                                                                  string> =
                                                                                                                                                                       v4820.map_err(|x| v4821(x));
                                                                                                                                                                   let v4836:
                                                                                                                                                                           File_system::US13 =
                                                                                                                                                                       match &v4833
                                                                                                                                                                           {
                                                                                                                                                                           Err(v4833_1_0)
                                                                                                                                                                           =>
                                                                                                                                                                           v3225(v4833_1_0.clone()),
                                                                                                                                                                           Ok(v4833_0_0)
                                                                                                                                                                           =>
                                                                                                                                                                           v3224(v4833_0_0.clone()),
                                                                                                                                                                       };
                                                                                                                                                                   match &v4836
                                                                                                                                                                       {
                                                                                                                                                                       File_system::US13::US13_0(v4836_0_0)
                                                                                                                                                                       =>
                                                                                                                                                                       {
                                                                                                                                                                           let v4865:
                                                                                                                                                                                   string =
                                                                                                                                                                               File_system::method59(toString(v4836_0_0.clone().display()),
                                                                                                                                                                                                     v3586.clone());
                                                                                                                                                                           let v4870:
                                                                                                                                                                                   &str =
                                                                                                                                                                               &*v4865;
                                                                                                                                                                           let v4894:
                                                                                                                                                                                   std::string::String =
                                                                                                                                                                               String::from(v4870);
                                                                                                                                                                           let v4918:
                                                                                                                                                                                   std::path::PathBuf =
                                                                                                                                                                               std::path::PathBuf::from(v4894);
                                                                                                                                                                           Ok(v4918)
                                                                                                                                                                       }
                                                                                                                                                                       File_system::US13::US13_1(v4836_1_0)
                                                                                                                                                                       =>
                                                                                                                                                                       {
                                                                                                                                                                           let v4953:
                                                                                                                                                                                   string =
                                                                                                                                                                               sprintf!("file_system.read_link / error\': {} / error: {} / name: {}",
                                                                                                                                                                                        v4836_1_0.clone(),
                                                                                                                                                                                        v3585.clone(),
                                                                                                                                                                                        v3586.clone());
                                                                                                                                                                           let v4958:
                                                                                                                                                                                   std::io::Error =
                                                                                                                                                                               std::io::Error::new(std::io::ErrorKind::Other, &*v4953);
                                                                                                                                                                           Err(v4958)
                                                                                                                                                                       }
                                                                                                                                                                   }
                                                                                                                                                               } else {
                                                                                                                                                                   let v4984:
                                                                                                                                                                           string =
                                                                                                                                                                       sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                                                                                                                                                v1_1.clone(),
                                                                                                                                                                                v3585.clone(),
                                                                                                                                                                                v3548.clone(),
                                                                                                                                                                                v3586.clone());
                                                                                                                                                                   let v4989:
                                                                                                                                                                           std::io::Error =
                                                                                                                                                                       std::io::Error::new(std::io::ErrorKind::Other, &*v4984);
                                                                                                                                                                   Err(v4989)
                                                                                                                                                               }
                                                                                                                                                           } else {
                                                                                                                                                               let v5014:
                                                                                                                                                                       string =
                                                                                                                                                                   sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                                                                                                                                            v1_1.clone(),
                                                                                                                                                                            v3585,
                                                                                                                                                                            v3548.clone(),
                                                                                                                                                                            v3586.clone());
                                                                                                                                                               let v5019:
                                                                                                                                                                       std::io::Error =
                                                                                                                                                                   std::io::Error::new(std::io::ErrorKind::Other, &*v5014);
                                                                                                                                                               Err(v5019)
                                                                                                                                                           }
                                                                                                                                                       }
                                                                                                                                                   };
                                                                                                                                               let v5046 =
                                                                                                                                                   File_system::method79();
                                                                                                                                               let v5058:
                                                                                                                                                       Result<std::path::PathBuf,
                                                                                                                                                              string> =
                                                                                                                                                   v5045.map_err(|x| v5046(x));
                                                                                                                                               let v5061:
                                                                                                                                                       File_system::US13 =
                                                                                                                                                   match &v5058
                                                                                                                                                       {
                                                                                                                                                       Err(v5058_1_0)
                                                                                                                                                       =>
                                                                                                                                                       v3225(v5058_1_0.clone()),
                                                                                                                                                       Ok(v5058_0_0)
                                                                                                                                                       =>
                                                                                                                                                       v3224(v5058_0_0.clone()),
                                                                                                                                                   };
                                                                                                                                               match &v5061
                                                                                                                                                   {
                                                                                                                                                   File_system::US13::US13_0(v5061_0_0)
                                                                                                                                                   =>
                                                                                                                                                   {
                                                                                                                                                       let v5090:
                                                                                                                                                               string =
                                                                                                                                                           File_system::method59(toString(v5061_0_0.clone().display()),
                                                                                                                                                                                 v3529.clone());
                                                                                                                                                       let v5095:
                                                                                                                                                               &str =
                                                                                                                                                           &*v5090;
                                                                                                                                                       let v5119:
                                                                                                                                                               std::string::String =
                                                                                                                                                           String::from(v5095);
                                                                                                                                                       let v5143:
                                                                                                                                                               std::path::PathBuf =
                                                                                                                                                           std::path::PathBuf::from(v5119);
                                                                                                                                                       Ok(v5143)
                                                                                                                                                   }
                                                                                                                                                   File_system::US13::US13_1(v5061_1_0)
                                                                                                                                                   =>
                                                                                                                                                   {
                                                                                                                                                       let v5178:
                                                                                                                                                               string =
                                                                                                                                                           sprintf!("file_system.read_link / error\': {} / error: {} / name: {}",
                                                                                                                                                                    v5061_1_0.clone(),
                                                                                                                                                                    v3528.clone(),
                                                                                                                                                                    v3529.clone());
                                                                                                                                                       let v5183:
                                                                                                                                                               std::io::Error =
                                                                                                                                                           std::io::Error::new(std::io::ErrorKind::Other, &*v5178);
                                                                                                                                                       Err(v5183)
                                                                                                                                                   }
                                                                                                                                               }
                                                                                                                                           } else {
                                                                                                                                               let v5209:
                                                                                                                                                       string =
                                                                                                                                                   sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                                                                                                                            v1_1.clone(),
                                                                                                                                                            v3528.clone(),
                                                                                                                                                            v3491.clone(),
                                                                                                                                                            v3529.clone());
                                                                                                                                               let v5214:
                                                                                                                                                       std::io::Error =
                                                                                                                                                   std::io::Error::new(std::io::ErrorKind::Other, &*v5209);
                                                                                                                                               Err(v5214)
                                                                                                                                           }
                                                                                                                                       } else {
                                                                                                                                           let v5239:
                                                                                                                                                   string =
                                                                                                                                               sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                                                                                                                        v1_1.clone(),
                                                                                                                                                        v3528,
                                                                                                                                                        v3491.clone(),
                                                                                                                                                        v3529.clone());
                                                                                                                                           let v5244:
                                                                                                                                                   std::io::Error =
                                                                                                                                               std::io::Error::new(std::io::ErrorKind::Other, &*v5239);
                                                                                                                                           Err(v5244)
                                                                                                                                       }
                                                                                                                                   }
                                                                                                                               };
                                                                                                                           let v5271 =
                                                                                                                               File_system::method79();
                                                                                                                           let v5283:
                                                                                                                                   Result<std::path::PathBuf,
                                                                                                                                          string> =
                                                                                                                               v5270.map_err(|x| v5271(x));
                                                                                                                           let v5286:
                                                                                                                                   File_system::US13 =
                                                                                                                               match &v5283
                                                                                                                                   {
                                                                                                                                   Err(v5283_1_0)
                                                                                                                                   =>
                                                                                                                                   v3225(v5283_1_0.clone()),
                                                                                                                                   Ok(v5283_0_0)
                                                                                                                                   =>
                                                                                                                                   v3224(v5283_0_0.clone()),
                                                                                                                               };
                                                                                                                           match &v5286
                                                                                                                               {
                                                                                                                               File_system::US13::US13_0(v5286_0_0)
                                                                                                                               =>
                                                                                                                               {
                                                                                                                                   let v5315:
                                                                                                                                           string =
                                                                                                                                       File_system::method59(toString(v5286_0_0.clone().display()),
                                                                                                                                                             v3472.clone());
                                                                                                                                   let v5320:
                                                                                                                                           &str =
                                                                                                                                       &*v5315;
                                                                                                                                   let v5344:
                                                                                                                                           std::string::String =
                                                                                                                                       String::from(v5320);
                                                                                                                                   let v5368:
                                                                                                                                           std::path::PathBuf =
                                                                                                                                       std::path::PathBuf::from(v5344);
                                                                                                                                   Ok(v5368)
                                                                                                                               }
                                                                                                                               File_system::US13::US13_1(v5286_1_0)
                                                                                                                               =>
                                                                                                                               {
                                                                                                                                   let v5403:
                                                                                                                                           string =
                                                                                                                                       sprintf!("file_system.read_link / error\': {} / error: {} / name: {}",
                                                                                                                                                v5286_1_0.clone(),
                                                                                                                                                v3471.clone(),
                                                                                                                                                v3472.clone());
                                                                                                                                   let v5408:
                                                                                                                                           std::io::Error =
                                                                                                                                       std::io::Error::new(std::io::ErrorKind::Other, &*v5403);
                                                                                                                                   Err(v5408)
                                                                                                                               }
                                                                                                                           }
                                                                                                                       } else {
                                                                                                                           let v5434:
                                                                                                                                   string =
                                                                                                                               sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                                                                                                        v1_1.clone(),
                                                                                                                                        v3471.clone(),
                                                                                                                                        v3434.clone(),
                                                                                                                                        v3472.clone());
                                                                                                                           let v5439:
                                                                                                                                   std::io::Error =
                                                                                                                               std::io::Error::new(std::io::ErrorKind::Other, &*v5434);
                                                                                                                           Err(v5439)
                                                                                                                       }
                                                                                                                   } else {
                                                                                                                       let v5464:
                                                                                                                               string =
                                                                                                                           sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                                                                                                    v1_1.clone(),
                                                                                                                                    v3471,
                                                                                                                                    v3434.clone(),
                                                                                                                                    v3472.clone());
                                                                                                                       let v5469:
                                                                                                                               std::io::Error =
                                                                                                                           std::io::Error::new(std::io::ErrorKind::Other, &*v5464);
                                                                                                                       Err(v5469)
                                                                                                                   }
                                                                                                               }
                                                                                                           };
                                                                                                       let v5496 =
                                                                                                           File_system::method79();
                                                                                                       let v5508:
                                                                                                               Result<std::path::PathBuf,
                                                                                                                      string> =
                                                                                                           v5495.map_err(|x| v5496(x));
                                                                                                       let v5511:
                                                                                                               File_system::US13 =
                                                                                                           match &v5508
                                                                                                               {
                                                                                                               Err(v5508_1_0)
                                                                                                               =>
                                                                                                               v3225(v5508_1_0.clone()),
                                                                                                               Ok(v5508_0_0)
                                                                                                               =>
                                                                                                               v3224(v5508_0_0.clone()),
                                                                                                           };
                                                                                                       match &v5511
                                                                                                           {
                                                                                                           File_system::US13::US13_0(v5511_0_0)
                                                                                                           =>
                                                                                                           {
                                                                                                               let v5540:
                                                                                                                       string =
                                                                                                                   File_system::method59(toString(v5511_0_0.clone().display()),
                                                                                                                                         v3415.clone());
                                                                                                               let v5545:
                                                                                                                       &str =
                                                                                                                   &*v5540;
                                                                                                               let v5569:
                                                                                                                       std::string::String =
                                                                                                                   String::from(v5545);
                                                                                                               let v5593:
                                                                                                                       std::path::PathBuf =
                                                                                                                   std::path::PathBuf::from(v5569);
                                                                                                               Ok(v5593)
                                                                                                           }
                                                                                                           File_system::US13::US13_1(v5511_1_0)
                                                                                                           =>
                                                                                                           {
                                                                                                               let v5628:
                                                                                                                       string =
                                                                                                                   sprintf!("file_system.read_link / error\': {} / error: {} / name: {}",
                                                                                                                            v5511_1_0.clone(),
                                                                                                                            v3414.clone(),
                                                                                                                            v3415.clone());
                                                                                                               let v5633:
                                                                                                                       std::io::Error =
                                                                                                                   std::io::Error::new(std::io::ErrorKind::Other, &*v5628);
                                                                                                               Err(v5633)
                                                                                                           }
                                                                                                       }
                                                                                                   } else {
                                                                                                       let v5659:
                                                                                                               string =
                                                                                                           sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                                                                                    v1_1.clone(),
                                                                                                                    v3414.clone(),
                                                                                                                    v3377.clone(),
                                                                                                                    v3415.clone());
                                                                                                       let v5664:
                                                                                                               std::io::Error =
                                                                                                           std::io::Error::new(std::io::ErrorKind::Other, &*v5659);
                                                                                                       Err(v5664)
                                                                                                   }
                                                                                               } else {
                                                                                                   let v5689:
                                                                                                           string =
                                                                                                       sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                                                                                v1_1.clone(),
                                                                                                                v3414,
                                                                                                                v3377.clone(),
                                                                                                                v3415.clone());
                                                                                                   let v5694:
                                                                                                           std::io::Error =
                                                                                                       std::io::Error::new(std::io::ErrorKind::Other, &*v5689);
                                                                                                   Err(v5694)
                                                                                               }
                                                                                           }
                                                                                       };
                                                                        let v5721 =
                                                                            File_system::method79();
                                                                        let v5733: Result<
                                                                            std::path::PathBuf,
                                                                            string,
                                                                        > = v5720
                                                                            .map_err(|x| v5721(x));
                                                                        let v5736:
                                                                                           File_system::US13 =
                                                                                       match &v5733
                                                                                           {
                                                                                           Err(v5733_1_0)
                                                                                           =>
                                                                                           v3225(v5733_1_0.clone()),
                                                                                           Ok(v5733_0_0)
                                                                                           =>
                                                                                           v3224(v5733_0_0.clone()),
                                                                                       };
                                                                        match &v5736
                                                                                       {
                                                                                       File_system::US13::US13_0(v5736_0_0)
                                                                                       =>
                                                                                       {
                                                                                           let v5765:
                                                                                                   string =
                                                                                               File_system::method59(toString(v5736_0_0.clone().display()),
                                                                                                                     v3358.clone());
                                                                                           let v5770:
                                                                                                   &str =
                                                                                               &*v5765;
                                                                                           let v5794:
                                                                                                   std::string::String =
                                                                                               String::from(v5770);
                                                                                           let v5818:
                                                                                                   std::path::PathBuf =
                                                                                               std::path::PathBuf::from(v5794);
                                                                                           Ok(v5818)
                                                                                       }
                                                                                       File_system::US13::US13_1(v5736_1_0)
                                                                                       =>
                                                                                       {
                                                                                           let v5853:
                                                                                                   string =
                                                                                               sprintf!("file_system.read_link / error\': {} / error: {} / name: {}",
                                                                                                        v5736_1_0.clone(),
                                                                                                        v3357.clone(),
                                                                                                        v3358.clone());
                                                                                           let v5858:
                                                                                                   std::io::Error =
                                                                                               std::io::Error::new(std::io::ErrorKind::Other, &*v5853);
                                                                                           Err(v5858)
                                                                                       }
                                                                                   }
                                                                    } else {
                                                                        let v5884:
                                                                                           string =
                                                                                       sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                                                                v1_1.clone(),
                                                                                                v3357.clone(),
                                                                                                v3320.clone(),
                                                                                                v3358.clone());
                                                                        let v5889:
                                                                                           std::io::Error =
                                                                                       std::io::Error::new(std::io::ErrorKind::Other, &*v5884);
                                                                        Err(v5889)
                                                                    }
                                                                } else {
                                                                    let v5914:
                                                                                       string =
                                                                                   sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                                                            v1_1.clone(),
                                                                                            v3357,
                                                                                            v3320.clone(),
                                                                                            v3358.clone());
                                                                    let v5919:
                                                                                       std::io::Error =
                                                                                   std::io::Error::new(std::io::ErrorKind::Other, &*v5914);
                                                                    Err(v5919)
                                                                }
                                                            }
                                                        };
                                                        let v5946 = File_system::method79();
                                                        let v5958: Result<
                                                            std::path::PathBuf,
                                                            string,
                                                        > = v5945.map_err(|x| v5946(x));
                                                        let v5961: File_system::US13 = match &v5958
                                                        {
                                                            Err(v5958_1_0) => {
                                                                v3225(v5958_1_0.clone())
                                                            }
                                                            Ok(v5958_0_0) => {
                                                                v3224(v5958_0_0.clone())
                                                            }
                                                        };
                                                        match &v5961 {
                                                            File_system::US13::US13_0(
                                                                v5961_0_0,
                                                            ) => {
                                                                let v5990: string =
                                                                    File_system::method59(
                                                                        toString(
                                                                            v5961_0_0
                                                                                .clone()
                                                                                .display(),
                                                                        ),
                                                                        v3301.clone(),
                                                                    );
                                                                let v5995: &str = &*v5990;
                                                                let v6019: std::string::String =
                                                                    String::from(v5995);
                                                                let v6043: std::path::PathBuf =
                                                                    std::path::PathBuf::from(v6019);
                                                                Ok(v6043)
                                                            }
                                                            File_system::US13::US13_1(
                                                                v5961_1_0,
                                                            ) => {
                                                                let v6078:
                                                                               string =
                                                                           sprintf!("file_system.read_link / error\': {} / error: {} / name: {}",
                                                                                    v5961_1_0.clone(),
                                                                                    v3300.clone(),
                                                                                    v3301.clone());
                                                                let v6083: std::io::Error =
                                                                    std::io::Error::new(
                                                                        std::io::ErrorKind::Other,
                                                                        &*v6078,
                                                                    );
                                                                Err(v6083)
                                                            }
                                                        }
                                                    } else {
                                                        let v6109:
                                                                       string =
                                                                   sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                                            v1_1.clone(),
                                                                            v3300.clone(),
                                                                            v3262.clone(),
                                                                            v3301.clone());
                                                        let v6114: std::io::Error =
                                                            std::io::Error::new(
                                                                std::io::ErrorKind::Other,
                                                                &*v6109,
                                                            );
                                                        Err(v6114)
                                                    }
                                                } else {
                                                    let v6139: string =
                                                               sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                                        v1_1.clone(),
                                                                        v3300,
                                                                        v3262.clone(),
                                                                        v3301.clone());
                                                    let v6144: std::io::Error = std::io::Error::new(
                                                        std::io::ErrorKind::Other,
                                                        &*v6139,
                                                    );
                                                    Err(v6144)
                                                }
                                            }
                                        };
                                    let v6171 = File_system::method79();
                                    let v6183: Result<std::path::PathBuf, string> =
                                        v6170.map_err(|x| v6171(x));
                                    let v6186: File_system::US13 = match &v6183 {
                                        Err(v6183_1_0) => v3225(v6183_1_0.clone()),
                                        Ok(v6183_0_0) => v3224(v6183_0_0.clone()),
                                    };
                                    match &v6186 {
                                        File_system::US13::US13_0(v6186_0_0) => {
                                            let v6215: string = File_system::method59(
                                                toString(v6186_0_0.clone().display()),
                                                v3243.clone(),
                                            );
                                            let v6220: &str = &*v6215;
                                            let v6244: std::string::String = String::from(v6220);
                                            let v6268: std::path::PathBuf =
                                                std::path::PathBuf::from(v6244);
                                            Ok(v6268)
                                        }
                                        File_system::US13::US13_1(v6186_1_0) => {
                                            let v6303: string =
                                                       sprintf!("file_system.read_link / error\': {} / error: {} / name: {}",
                                                                v6186_1_0.clone(),
                                                                v3242.clone(),
                                                                v3243.clone());
                                            let v6308: std::io::Error = std::io::Error::new(
                                                std::io::ErrorKind::Other,
                                                &*v6303,
                                            );
                                            Err(v6308)
                                        }
                                    }
                                } else {
                                    let v6334: string =
                                               sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                        v1_1.clone(),
                                                        v3242.clone(),
                                                        v1_1.clone(),
                                                        v3243.clone());
                                    let v6339: std::io::Error =
                                        std::io::Error::new(std::io::ErrorKind::Other, &*v6334);
                                    Err(v6339)
                                }
                            } else {
                                let v6364: string =
                                           sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                    v1_1.clone(), v3242,
                                                    v1_1.clone(),
                                                    v3243.clone());
                                let v6369: std::io::Error =
                                    std::io::Error::new(std::io::ErrorKind::Other, &*v6364);
                                Err(v6369)
                            }
                        }
                    }
                };
                v6396.is_err()
            } else {
                false
            } {
                File_system::method7(true, v1_1.clone());
            }
            if File_system::method9(v1_1.clone()) == false {
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
