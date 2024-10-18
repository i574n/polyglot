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
        let _v1: (File_system::US2, File_system::US3) =
            (File_system::US2::US2_1, File_system::US3::US3_1);
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
        let v81: File_system::US3 =
            defaultValue(File_system::US3::US3_1, map(File_system::method12(), v5));
        let v121: DateTime = match &v81 {
            File_system::US3::US3_0(v81_0_0) => {
                let v95: TimeSpan = TimeSpan::new_ticks(
                    {
                        let _arg: DateTime = DateTime::now();
                        _arg.ticks()
                    } - match &v81 {
                        File_system::US3::US3_0(x) => x.clone(),
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
        let v38: &str = inline_colorization::color_bright_blue;
        let v43: &str = &*v6;
        let v61: &str = inline_colorization::color_reset;
        let v63: std::string::String = format!("{}{}{}", v38, v43, v61);
        fable_library_rust::String_::fromString(v63)
    }
    pub fn method19(v0_1: string) -> string {
        panic!(
            "{}",
            sprintf!(
                "file_system.get_file_name / target: {} / path: {}",
                File_system::US5::US5_2(File_system::US4::US4_1),
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
        let v38: &str = inline_colorization::color_yellow;
        let v43: &str = &*v6;
        let v61: &str = inline_colorization::color_reset;
        let v63: std::string::String = format!("{}{}{}", v38, v43, v61);
        fable_library_rust::String_::fromString(v63)
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
        let v131: () = {
            File_system::closure6(
                v4.clone(),
                sprintf!("{}", fable_library_rust::String_::fromString(v105)),
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
        let v38: &str = inline_colorization::color_bright_black;
        let v43: &str = &*v6;
        let v61: &str = inline_colorization::color_reset;
        let v63: std::string::String = format!("{}{}{}", v38, v43, v61);
        fable_library_rust::String_::fromString(v63)
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
    ) -> string {
        let v9: string = File_system::method41(1000_i32);
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
            File_system::method23(File_system::method40(
                v18_1.clone(),
                v19_1.clone(),
                v20_1.clone(),
                v21_1.clone(),
                v22_1.clone(),
                v23_1.clone(),
                File_system::method11(v18_1, v19_1, v20_1, v21_1, v22_1, v23_1),
                File_system::method39(),
            ))
        };
    }
    pub fn method42() -> string {
        let v6: string = File_system::method16(getCharAt(toLower(string("Critical")), 0_i32));
        let v38: &str = inline_colorization::color_bright_red;
        let v43: &str = &*v6;
        let v61: &str = inline_colorization::color_reset;
        let v63: std::string::String = format!("{}{}{}", v38, v43, v61);
        fable_library_rust::String_::fromString(v63)
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
    ) -> string {
        let v10: string = File_system::method44(1000_i32, v8);
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
            File_system::method23(File_system::method43(
                v19_1.clone(),
                v20_1.clone(),
                v21_1.clone(),
                v22_1.clone(),
                v23_1.clone(),
                v24_1.clone(),
                File_system::method11(v19_1, v20_1, v21_1, v22_1, v23_1, v24_1),
                File_system::method42(),
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
        v8: i64,
        v9: string,
    ) -> string {
        let v10: string = File_system::method46(v8, v9);
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
            File_system::method23(File_system::method45(
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
        let v165: DateTime = {
            let _arg: DateTime =
                DateTime::new_ymdhms_kind(1970_i32, 1_i32, 1_i32, 0_i32, 0_i32, 0_i32, 1_i32);
            _arg.toUniversalTime()
        };
        let v183: i64 = ({
            let _arg_2: DateTime = {
                let _arg_1: DateTime = DateTime::specifyKind(v1_1, 2_i32);
                _arg_1.toUniversalTime()
            };
            _arg_2.ticks()
        } - v165.ticks())
            / 10_i64;
        let v185: Option<chrono::DateTime<chrono::Utc>> =
            chrono::DateTime::from_timestamp_micros(v183);
        let v199: File_system::US11 = defaultValue(
            File_system::US11::US11_1,
            map(File_system::method49(), v185),
        );
        let v219: File_system::US1 = match &v199 {
            File_system::US11::US11_0(v199_0_0) => {
                let v205: chrono::NaiveDateTime = match &v199 {
                    File_system::US11::US11_0(x) => x.clone(),
                    _ => unreachable!(),
                }
                .naive_utc();
                let v207: chrono::DateTime<chrono::Local> =
                    chrono::offset::TimeZone::from_utc_datetime(&chrono::Local, &v205);
                let v209: string = string("r#\"%Y%m%d-%H%M-%S%f\"#");
                let v210: &str = r#"%Y%m%d-%H%M-%S%f"#;
                let v212: std::string::String = v207.format(v210).to_string();
                let v214: string = fable_library_rust::String_::fromString(v212);
                File_system::US1::US1_0(sprintf!(
                    "{}-{}-{}",
                    getSlice(v214.clone(), Some(0_i32), Some(17_i32)),
                    getSlice(v214.clone(), Some(18_i32), Some(21_i32)),
                    getCharAt(v214, 22_i32)
                ))
            }
            _ => File_system::US1::US1_1,
        };
        let v223: string = match &v219 {
            File_system::US1::US1_0(v219_0_0) => match &v219 {
                File_system::US1::US1_0(x) => x.clone(),
                _ => unreachable!(),
            },
            _ => string(""),
        };
        let v227: LrcPtr<TimeZoneInfo> = defaultOf();
        let v301: u8 = if zero.hours() > 0_i32 { 1_u8 } else { 0_u8 };
        let v302: string = File_system::method50();
        let v310: string = zero.to_string(v302);
        let v313: string = sprintf!(
            "{}{}{}",
            v301,
            getSlice(v310.clone(), Some(0_i32), Some(1_i32)),
            getSlice(v310, Some(3_i32), Some(4_i32))
        );
        parse(sprintf!(
            "{}{}{}",
            v223.clone(),
            v313.clone(),
            getSlice(
                toString(v0_1),
                Some(length(v223) + length(v313)),
                None::<i32>
            )
        ))
    }
    pub fn method54() -> string {
        panic!(
            "{}",
            sprintf!(
                "file_system.get_temp_path / target: {}",
                File_system::US5::US5_2(File_system::US4::US4_1)
            ),
        )
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
        panic!(
            "{}",
            sprintf!(
                "file_system.(</>) / target: {} / a: {} / b: {}",
                File_system::US5::US5_2(File_system::US4::US4_1),
                v0_1,
                v1_1
            ),
        )
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
        let v10: DateTime = DateTime::now();
        File_system::method53(File_system::method48(new_guid(), v10))
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
        let v71: std::string::String = format!("{:#?}", v1_1);
        let v97: () = {
            File_system::closure6(
                v3.clone(),
                sprintf!("{}", fable_library_rust::String_::fromString(v71)),
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
        let v5: Arc<Async<i64>> = defaultOf();
        let v28_1: Arc<Async<()>> = defaultOf();
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
        interface_cast!(
            defaultOf::<std::sync::Arc<dyn IDisposable>>(),
            Lrc<dyn IDisposable>,
        )
    }
    pub fn closure34(unitVar: (), unitVar_1: ()) -> (string, LrcPtr<dyn IDisposable>) {
        let v0_1: string = File_system::method47();
        (v0_1.clone(), File_system::method61(v0_1))
    }
    pub fn method74(v0_1: string) -> Guid {
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
        let v2_1: string = File_system::method53(File_system::method74(v0_1));
        (v2_1.clone(), File_system::method61(v2_1))
    }
    pub fn closure44(unitVar: (), unitVar_1: ()) -> string {
        string("C:\\home\\git\\polyglot\\lib\\spiral")
    }
    pub fn method77(v0_1: std::io::Error) -> string {
        let v2_1: LrcPtr<File_system::Mut3> = LrcPtr::new(File_system::Mut3 {
            l0: MutCell::new(File_system::method17()),
        });
        let v9: std::string::String = format!("{:#?}", v0_1);
        let v35_1: () = {
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
        unbox::<string>(&defaultOf())
    }
    pub fn method78(v0_1: string) -> Option<string> {
        let v51: File_system::US1 = unbox::<File_system::US1>(&defaultOf());
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
    pub fn method82(v0_1: string) -> string {
        v0_1
    }
    pub fn method81(v0_1: string, v1_1: string, v2_1: string) -> string {
        unbox::<string>(&defaultOf())
    }
    pub fn method75(v0_1: string) -> string {
        if v0_1.clone() == string("") {
            string("")
        } else {
            let v5897: Result<std::path::PathBuf, std::io::Error> = if File_system::method9(
                v0_1.clone(),
            ) {
                std::fs::read_link(&*v0_1.clone())
            } else {
                let v2955: Result<std::path::PathBuf, std::io::Error> =
                    std::fs::read_link(&*v0_1.clone());
                let v2956 = File_system::method76();
                let v2967: Result<std::path::PathBuf, string> = v2955.map_err(|x| v2956(x));
                fn v2970(v: std::path::PathBuf) -> File_system::US13 {
                    File_system::closure47((), v)
                }
                fn v2971(v_1: string) -> File_system::US13 {
                    File_system::closure48((), v_1)
                }
                let v2972: File_system::US13 = match &v2967 {
                    Err(v2967_1_0) => v2971(v2967_1_0.clone()),
                    Ok(v2967_0_0) => v2970(v2967_0_0.clone()),
                };
                match &v2972 {
                    File_system::US13::US13_0(v2972_0_0) => Ok(v2972_0_0.clone()),
                    File_system::US13::US13_1(v2972_1_0) => {
                        let v2987: string = v2972_1_0.clone();
                        let v2988: string = File_system::method19(v0_1.clone());
                        let v2989: Option<string> = File_system::method78(v0_1.clone());
                        let v3003: File_system::US1 = defaultValue(
                            File_system::US1::US1_1,
                            map(File_system::method4(), v2989),
                        );
                        if let File_system::US1::US1_0(v3003_0_0) = &v3003 {
                            let v3007: string = match &v3003 {
                                File_system::US1::US1_0(x) => x.clone(),
                                _ => unreachable!(),
                            };
                            if v0_1.clone() != string("") {
                                let v3013: Result<std::path::PathBuf, std::io::Error> =
                                    std::fs::read_link(&*v3007.clone());
                                let v3014 = File_system::method76();
                                let v3025: Result<std::path::PathBuf, string> =
                                    v3013.map_err(|x| v3014(x));
                                let v3028: File_system::US13 = match &v3025 {
                                    Err(v3025_1_0) => v2971(v3025_1_0.clone()),
                                    Ok(v3025_0_0) => v2970(v3025_0_0.clone()),
                                };
                                let v5691: Result<std::path::PathBuf, std::io::Error> = match &v3028
                                {
                                    File_system::US13::US13_0(v3028_0_0) => Ok(v3028_0_0.clone()),
                                    File_system::US13::US13_1(v3028_1_0) => {
                                        let v3043: string = v3028_1_0.clone();
                                        let v3044: string = File_system::method19(v3007.clone());
                                        let v3045: Option<string> =
                                            File_system::method78(v3007.clone());
                                        let v3059: File_system::US1 = defaultValue(
                                            File_system::US1::US1_1,
                                            map(File_system::method4(), v3045),
                                        );
                                        if let File_system::US1::US1_0(v3059_0_0) = &v3059 {
                                            let v3063: string = match &v3059 {
                                                File_system::US1::US1_0(x) => x.clone(),
                                                _ => unreachable!(),
                                            };
                                            if v3007.clone() != string("") {
                                                let v3068: Result<
                                                    std::path::PathBuf,
                                                    std::io::Error,
                                                > = std::fs::read_link(&*v3063.clone());
                                                let v3069 = File_system::method76();
                                                let v3080: Result<std::path::PathBuf, string> =
                                                    v3068.map_err(|x| v3069(x));
                                                let v3083: File_system::US13 = match &v3080 {
                                                    Err(v3080_1_0) => v2971(v3080_1_0.clone()),
                                                    Ok(v3080_0_0) => v2970(v3080_0_0.clone()),
                                                };
                                                let v5486: Result<
                                                    std::path::PathBuf,
                                                    std::io::Error,
                                                > = match &v3083 {
                                                    File_system::US13::US13_0(v3083_0_0) => {
                                                        Ok(v3083_0_0.clone())
                                                    }
                                                    File_system::US13::US13_1(v3083_1_0) => {
                                                        let v3098: string = v3083_1_0.clone();
                                                        let v3099: string =
                                                            File_system::method19(v3063.clone());
                                                        let v3100: Option<string> =
                                                            File_system::method78(v3063.clone());
                                                        let v3114: File_system::US1 = defaultValue(
                                                            File_system::US1::US1_1,
                                                            map(File_system::method4(), v3100),
                                                        );
                                                        if let File_system::US1::US1_0(v3114_0_0) =
                                                            &v3114
                                                        {
                                                            let v3118: string = match &v3114 {
                                                                File_system::US1::US1_0(x) => {
                                                                    x.clone()
                                                                }
                                                                _ => unreachable!(),
                                                            };
                                                            if v3063.clone() != string("") {
                                                                let v3123: Result<
                                                                    std::path::PathBuf,
                                                                    std::io::Error,
                                                                > = std::fs::read_link(
                                                                    &*v3118.clone(),
                                                                );
                                                                let v3124 = File_system::method76();
                                                                let v3135: Result<
                                                                    std::path::PathBuf,
                                                                    string,
                                                                > = v3123.map_err(|x| v3124(x));
                                                                let v3138: File_system::US13 =
                                                                    match &v3135 {
                                                                        Err(v3135_1_0) => {
                                                                            v2971(v3135_1_0.clone())
                                                                        }
                                                                        Ok(v3135_0_0) => {
                                                                            v2970(v3135_0_0.clone())
                                                                        }
                                                                    };
                                                                let v5281: Result<
                                                                    std::path::PathBuf,
                                                                    std::io::Error,
                                                                > = match &v3138 {
                                                                    File_system::US13::US13_0(
                                                                        v3138_0_0,
                                                                    ) => Ok(v3138_0_0.clone()),
                                                                    File_system::US13::US13_1(
                                                                        v3138_1_0,
                                                                    ) => {
                                                                        let v3153: string =
                                                                            v3138_1_0.clone();
                                                                        let v3154: string =
                                                                            File_system::method19(
                                                                                v3118.clone(),
                                                                            );
                                                                        let v3155: Option<string> =
                                                                            File_system::method78(
                                                                                v3118.clone(),
                                                                            );
                                                                        let v3169:
                                                                                                File_system::US1 =
                                                                                            defaultValue(File_system::US1::US1_1,
                                                                                                         map(File_system::method4(),
                                                                                                             v3155));
                                                                        if let File_system::US1::US1_0(v3169_0_0)
                                                                                               =
                                                                                               &v3169
                                                                                           {
                                                                                            let v3173:
                                                                                                    string =
                                                                                                match &v3169
                                                                                                    {
                                                                                                    File_system::US1::US1_0(x)
                                                                                                    =>
                                                                                                    x.clone(),
                                                                                                    _
                                                                                                    =>
                                                                                                    unreachable!(),
                                                                                                };
                                                                                            if v3118.clone()
                                                                                                   !=
                                                                                                   string("")
                                                                                               {
                                                                                                let v3178:
                                                                                                        Result<std::path::PathBuf,
                                                                                                               std::io::Error> =
                                                                                                    std::fs::read_link(&*v3173.clone());
                                                                                                let v3179 =
                                                                                                    File_system::method76();
                                                                                                let v3190:
                                                                                                        Result<std::path::PathBuf,
                                                                                                               string> =
                                                                                                    v3178.map_err(|x| v3179(x));
                                                                                                let v3193:
                                                                                                        File_system::US13 =
                                                                                                    match &v3190
                                                                                                        {
                                                                                                        Err(v3190_1_0)
                                                                                                        =>
                                                                                                        v2971(v3190_1_0.clone()),
                                                                                                        Ok(v3190_0_0)
                                                                                                        =>
                                                                                                        v2970(v3190_0_0.clone()),
                                                                                                    };
                                                                                                let v5076:
                                                                                                        Result<std::path::PathBuf,
                                                                                                               std::io::Error> =
                                                                                                    match &v3193
                                                                                                        {
                                                                                                        File_system::US13::US13_0(v3193_0_0)
                                                                                                        =>
                                                                                                        Ok(v3193_0_0.clone()),
                                                                                                        File_system::US13::US13_1(v3193_1_0)
                                                                                                        =>
                                                                                                        {
                                                                                                            let v3208:
                                                                                                                    string =
                                                                                                                v3193_1_0.clone();
                                                                                                            let v3209:
                                                                                                                    string =
                                                                                                                File_system::method19(v3173.clone());
                                                                                                            let v3210:
                                                                                                                    Option<string> =
                                                                                                                File_system::method78(v3173.clone());
                                                                                                            let v3224:
                                                                                                                    File_system::US1 =
                                                                                                                defaultValue(File_system::US1::US1_1,
                                                                                                                             map(File_system::method4(),
                                                                                                                                 v3210));
                                                                                                            if let File_system::US1::US1_0(v3224_0_0)
                                                                                                                   =
                                                                                                                   &v3224
                                                                                                               {
                                                                                                                let v3228:
                                                                                                                        string =
                                                                                                                    match &v3224
                                                                                                                        {
                                                                                                                        File_system::US1::US1_0(x)
                                                                                                                        =>
                                                                                                                        x.clone(),
                                                                                                                        _
                                                                                                                        =>
                                                                                                                        unreachable!(),
                                                                                                                    };
                                                                                                                if v3173.clone()
                                                                                                                       !=
                                                                                                                       string("")
                                                                                                                   {
                                                                                                                    let v3233:
                                                                                                                            Result<std::path::PathBuf,
                                                                                                                                   std::io::Error> =
                                                                                                                        std::fs::read_link(&*v3228.clone());
                                                                                                                    let v3234 =
                                                                                                                        File_system::method76();
                                                                                                                    let v3245:
                                                                                                                            Result<std::path::PathBuf,
                                                                                                                                   string> =
                                                                                                                        v3233.map_err(|x| v3234(x));
                                                                                                                    let v3248:
                                                                                                                            File_system::US13 =
                                                                                                                        match &v3245
                                                                                                                            {
                                                                                                                            Err(v3245_1_0)
                                                                                                                            =>
                                                                                                                            v2971(v3245_1_0.clone()),
                                                                                                                            Ok(v3245_0_0)
                                                                                                                            =>
                                                                                                                            v2970(v3245_0_0.clone()),
                                                                                                                        };
                                                                                                                    let v4871:
                                                                                                                            Result<std::path::PathBuf,
                                                                                                                                   std::io::Error> =
                                                                                                                        match &v3248
                                                                                                                            {
                                                                                                                            File_system::US13::US13_0(v3248_0_0)
                                                                                                                            =>
                                                                                                                            Ok(v3248_0_0.clone()),
                                                                                                                            File_system::US13::US13_1(v3248_1_0)
                                                                                                                            =>
                                                                                                                            {
                                                                                                                                let v3263:
                                                                                                                                        string =
                                                                                                                                    v3248_1_0.clone();
                                                                                                                                let v3264:
                                                                                                                                        string =
                                                                                                                                    File_system::method19(v3228.clone());
                                                                                                                                let v3265:
                                                                                                                                        Option<string> =
                                                                                                                                    File_system::method78(v3228.clone());
                                                                                                                                let v3279:
                                                                                                                                        File_system::US1 =
                                                                                                                                    defaultValue(File_system::US1::US1_1,
                                                                                                                                                 map(File_system::method4(),
                                                                                                                                                     v3265));
                                                                                                                                if let File_system::US1::US1_0(v3279_0_0)
                                                                                                                                       =
                                                                                                                                       &v3279
                                                                                                                                   {
                                                                                                                                    let v3283:
                                                                                                                                            string =
                                                                                                                                        match &v3279
                                                                                                                                            {
                                                                                                                                            File_system::US1::US1_0(x)
                                                                                                                                            =>
                                                                                                                                            x.clone(),
                                                                                                                                            _
                                                                                                                                            =>
                                                                                                                                            unreachable!(),
                                                                                                                                        };
                                                                                                                                    if v3228.clone()
                                                                                                                                           !=
                                                                                                                                           string("")
                                                                                                                                       {
                                                                                                                                        let v3288:
                                                                                                                                                Result<std::path::PathBuf,
                                                                                                                                                       std::io::Error> =
                                                                                                                                            std::fs::read_link(&*v3283.clone());
                                                                                                                                        let v3289 =
                                                                                                                                            File_system::method76();
                                                                                                                                        let v3300:
                                                                                                                                                Result<std::path::PathBuf,
                                                                                                                                                       string> =
                                                                                                                                            v3288.map_err(|x| v3289(x));
                                                                                                                                        let v3303:
                                                                                                                                                File_system::US13 =
                                                                                                                                            match &v3300
                                                                                                                                                {
                                                                                                                                                Err(v3300_1_0)
                                                                                                                                                =>
                                                                                                                                                v2971(v3300_1_0.clone()),
                                                                                                                                                Ok(v3300_0_0)
                                                                                                                                                =>
                                                                                                                                                v2970(v3300_0_0.clone()),
                                                                                                                                            };
                                                                                                                                        let v4666:
                                                                                                                                                Result<std::path::PathBuf,
                                                                                                                                                       std::io::Error> =
                                                                                                                                            match &v3303
                                                                                                                                                {
                                                                                                                                                File_system::US13::US13_0(v3303_0_0)
                                                                                                                                                =>
                                                                                                                                                Ok(v3303_0_0.clone()),
                                                                                                                                                File_system::US13::US13_1(v3303_1_0)
                                                                                                                                                =>
                                                                                                                                                {
                                                                                                                                                    let v3318:
                                                                                                                                                            string =
                                                                                                                                                        v3303_1_0.clone();
                                                                                                                                                    let v3319:
                                                                                                                                                            string =
                                                                                                                                                        File_system::method19(v3283.clone());
                                                                                                                                                    let v3320:
                                                                                                                                                            Option<string> =
                                                                                                                                                        File_system::method78(v3283.clone());
                                                                                                                                                    let v3334:
                                                                                                                                                            File_system::US1 =
                                                                                                                                                        defaultValue(File_system::US1::US1_1,
                                                                                                                                                                     map(File_system::method4(),
                                                                                                                                                                         v3320));
                                                                                                                                                    if let File_system::US1::US1_0(v3334_0_0)
                                                                                                                                                           =
                                                                                                                                                           &v3334
                                                                                                                                                       {
                                                                                                                                                        let v3338:
                                                                                                                                                                string =
                                                                                                                                                            match &v3334
                                                                                                                                                                {
                                                                                                                                                                File_system::US1::US1_0(x)
                                                                                                                                                                =>
                                                                                                                                                                x.clone(),
                                                                                                                                                                _
                                                                                                                                                                =>
                                                                                                                                                                unreachable!(),
                                                                                                                                                            };
                                                                                                                                                        if v3283.clone()
                                                                                                                                                               !=
                                                                                                                                                               string("")
                                                                                                                                                           {
                                                                                                                                                            let v3343:
                                                                                                                                                                    Result<std::path::PathBuf,
                                                                                                                                                                           std::io::Error> =
                                                                                                                                                                std::fs::read_link(&*v3338.clone());
                                                                                                                                                            let v3344 =
                                                                                                                                                                File_system::method76();
                                                                                                                                                            let v3355:
                                                                                                                                                                    Result<std::path::PathBuf,
                                                                                                                                                                           string> =
                                                                                                                                                                v3343.map_err(|x| v3344(x));
                                                                                                                                                            let v3358:
                                                                                                                                                                    File_system::US13 =
                                                                                                                                                                match &v3355
                                                                                                                                                                    {
                                                                                                                                                                    Err(v3355_1_0)
                                                                                                                                                                    =>
                                                                                                                                                                    v2971(v3355_1_0.clone()),
                                                                                                                                                                    Ok(v3355_0_0)
                                                                                                                                                                    =>
                                                                                                                                                                    v2970(v3355_0_0.clone()),
                                                                                                                                                                };
                                                                                                                                                            let v4461:
                                                                                                                                                                    Result<std::path::PathBuf,
                                                                                                                                                                           std::io::Error> =
                                                                                                                                                                match &v3358
                                                                                                                                                                    {
                                                                                                                                                                    File_system::US13::US13_0(v3358_0_0)
                                                                                                                                                                    =>
                                                                                                                                                                    Ok(v3358_0_0.clone()),
                                                                                                                                                                    File_system::US13::US13_1(v3358_1_0)
                                                                                                                                                                    =>
                                                                                                                                                                    {
                                                                                                                                                                        let v3373:
                                                                                                                                                                                string =
                                                                                                                                                                            v3358_1_0.clone();
                                                                                                                                                                        let v3374:
                                                                                                                                                                                string =
                                                                                                                                                                            File_system::method19(v3338.clone());
                                                                                                                                                                        let v3375:
                                                                                                                                                                                Option<string> =
                                                                                                                                                                            File_system::method78(v3338.clone());
                                                                                                                                                                        let v3389:
                                                                                                                                                                                File_system::US1 =
                                                                                                                                                                            defaultValue(File_system::US1::US1_1,
                                                                                                                                                                                         map(File_system::method4(),
                                                                                                                                                                                             v3375));
                                                                                                                                                                        if let File_system::US1::US1_0(v3389_0_0)
                                                                                                                                                                               =
                                                                                                                                                                               &v3389
                                                                                                                                                                           {
                                                                                                                                                                            let v3393:
                                                                                                                                                                                    string =
                                                                                                                                                                                match &v3389
                                                                                                                                                                                    {
                                                                                                                                                                                    File_system::US1::US1_0(x)
                                                                                                                                                                                    =>
                                                                                                                                                                                    x.clone(),
                                                                                                                                                                                    _
                                                                                                                                                                                    =>
                                                                                                                                                                                    unreachable!(),
                                                                                                                                                                                };
                                                                                                                                                                            if v3338.clone()
                                                                                                                                                                                   !=
                                                                                                                                                                                   string("")
                                                                                                                                                                               {
                                                                                                                                                                                let v3398:
                                                                                                                                                                                        Result<std::path::PathBuf,
                                                                                                                                                                                               std::io::Error> =
                                                                                                                                                                                    std::fs::read_link(&*v3393.clone());
                                                                                                                                                                                let v3399 =
                                                                                                                                                                                    File_system::method76();
                                                                                                                                                                                let v3410:
                                                                                                                                                                                        Result<std::path::PathBuf,
                                                                                                                                                                                               string> =
                                                                                                                                                                                    v3398.map_err(|x| v3399(x));
                                                                                                                                                                                let v3413:
                                                                                                                                                                                        File_system::US13 =
                                                                                                                                                                                    match &v3410
                                                                                                                                                                                        {
                                                                                                                                                                                        Err(v3410_1_0)
                                                                                                                                                                                        =>
                                                                                                                                                                                        v2971(v3410_1_0.clone()),
                                                                                                                                                                                        Ok(v3410_0_0)
                                                                                                                                                                                        =>
                                                                                                                                                                                        v2970(v3410_0_0.clone()),
                                                                                                                                                                                    };
                                                                                                                                                                                let v4256:
                                                                                                                                                                                        Result<std::path::PathBuf,
                                                                                                                                                                                               std::io::Error> =
                                                                                                                                                                                    match &v3413
                                                                                                                                                                                        {
                                                                                                                                                                                        File_system::US13::US13_0(v3413_0_0)
                                                                                                                                                                                        =>
                                                                                                                                                                                        Ok(v3413_0_0.clone()),
                                                                                                                                                                                        File_system::US13::US13_1(v3413_1_0)
                                                                                                                                                                                        =>
                                                                                                                                                                                        {
                                                                                                                                                                                            let v3428:
                                                                                                                                                                                                    string =
                                                                                                                                                                                                v3413_1_0.clone();
                                                                                                                                                                                            let v3429:
                                                                                                                                                                                                    string =
                                                                                                                                                                                                File_system::method19(v3393.clone());
                                                                                                                                                                                            let v3430:
                                                                                                                                                                                                    Option<string> =
                                                                                                                                                                                                File_system::method78(v3393.clone());
                                                                                                                                                                                            let v3444:
                                                                                                                                                                                                    File_system::US1 =
                                                                                                                                                                                                defaultValue(File_system::US1::US1_1,
                                                                                                                                                                                                             map(File_system::method4(),
                                                                                                                                                                                                                 v3430));
                                                                                                                                                                                            if let File_system::US1::US1_0(v3444_0_0)
                                                                                                                                                                                                   =
                                                                                                                                                                                                   &v3444
                                                                                                                                                                                               {
                                                                                                                                                                                                let v3448:
                                                                                                                                                                                                        string =
                                                                                                                                                                                                    match &v3444
                                                                                                                                                                                                        {
                                                                                                                                                                                                        File_system::US1::US1_0(x)
                                                                                                                                                                                                        =>
                                                                                                                                                                                                        x.clone(),
                                                                                                                                                                                                        _
                                                                                                                                                                                                        =>
                                                                                                                                                                                                        unreachable!(),
                                                                                                                                                                                                    };
                                                                                                                                                                                                if v3393.clone()
                                                                                                                                                                                                       !=
                                                                                                                                                                                                       string("")
                                                                                                                                                                                                   {
                                                                                                                                                                                                    let v3453:
                                                                                                                                                                                                            Result<std::path::PathBuf,
                                                                                                                                                                                                                   std::io::Error> =
                                                                                                                                                                                                        std::fs::read_link(&*v3448.clone());
                                                                                                                                                                                                    let v3454 =
                                                                                                                                                                                                        File_system::method76();
                                                                                                                                                                                                    let v3465:
                                                                                                                                                                                                            Result<std::path::PathBuf,
                                                                                                                                                                                                                   string> =
                                                                                                                                                                                                        v3453.map_err(|x| v3454(x));
                                                                                                                                                                                                    let v3468:
                                                                                                                                                                                                            File_system::US13 =
                                                                                                                                                                                                        match &v3465
                                                                                                                                                                                                            {
                                                                                                                                                                                                            Err(v3465_1_0)
                                                                                                                                                                                                            =>
                                                                                                                                                                                                            v2971(v3465_1_0.clone()),
                                                                                                                                                                                                            Ok(v3465_0_0)
                                                                                                                                                                                                            =>
                                                                                                                                                                                                            v2970(v3465_0_0.clone()),
                                                                                                                                                                                                        };
                                                                                                                                                                                                    let v4051:
                                                                                                                                                                                                            Result<std::path::PathBuf,
                                                                                                                                                                                                                   std::io::Error> =
                                                                                                                                                                                                        match &v3468
                                                                                                                                                                                                            {
                                                                                                                                                                                                            File_system::US13::US13_0(v3468_0_0)
                                                                                                                                                                                                            =>
                                                                                                                                                                                                            Ok(v3468_0_0.clone()),
                                                                                                                                                                                                            File_system::US13::US13_1(v3468_1_0)
                                                                                                                                                                                                            =>
                                                                                                                                                                                                            {
                                                                                                                                                                                                                let v3483:
                                                                                                                                                                                                                        string =
                                                                                                                                                                                                                    v3468_1_0.clone();
                                                                                                                                                                                                                let v3484:
                                                                                                                                                                                                                        string =
                                                                                                                                                                                                                    File_system::method19(v3448.clone());
                                                                                                                                                                                                                let v3485:
                                                                                                                                                                                                                        Option<string> =
                                                                                                                                                                                                                    File_system::method78(v3448.clone());
                                                                                                                                                                                                                let v3499:
                                                                                                                                                                                                                        File_system::US1 =
                                                                                                                                                                                                                    defaultValue(File_system::US1::US1_1,
                                                                                                                                                                                                                                 map(File_system::method4(),
                                                                                                                                                                                                                                     v3485));
                                                                                                                                                                                                                if let File_system::US1::US1_0(v3499_0_0)
                                                                                                                                                                                                                       =
                                                                                                                                                                                                                       &v3499
                                                                                                                                                                                                                   {
                                                                                                                                                                                                                    let v3503:
                                                                                                                                                                                                                            string =
                                                                                                                                                                                                                        match &v3499
                                                                                                                                                                                                                            {
                                                                                                                                                                                                                            File_system::US1::US1_0(x)
                                                                                                                                                                                                                            =>
                                                                                                                                                                                                                            x.clone(),
                                                                                                                                                                                                                            _
                                                                                                                                                                                                                            =>
                                                                                                                                                                                                                            unreachable!(),
                                                                                                                                                                                                                        };
                                                                                                                                                                                                                    if v3448.clone()
                                                                                                                                                                                                                           !=
                                                                                                                                                                                                                           string("")
                                                                                                                                                                                                                       {
                                                                                                                                                                                                                        let v3508:
                                                                                                                                                                                                                                Result<std::path::PathBuf,
                                                                                                                                                                                                                                       std::io::Error> =
                                                                                                                                                                                                                            std::fs::read_link(&*v3503.clone());
                                                                                                                                                                                                                        let v3509 =
                                                                                                                                                                                                                            File_system::method76();
                                                                                                                                                                                                                        let v3520:
                                                                                                                                                                                                                                Result<std::path::PathBuf,
                                                                                                                                                                                                                                       string> =
                                                                                                                                                                                                                            v3508.map_err(|x| v3509(x));
                                                                                                                                                                                                                        let v3523:
                                                                                                                                                                                                                                File_system::US13 =
                                                                                                                                                                                                                            match &v3520
                                                                                                                                                                                                                                {
                                                                                                                                                                                                                                Err(v3520_1_0)
                                                                                                                                                                                                                                =>
                                                                                                                                                                                                                                v2971(v3520_1_0.clone()),
                                                                                                                                                                                                                                Ok(v3520_0_0)
                                                                                                                                                                                                                                =>
                                                                                                                                                                                                                                v2970(v3520_0_0.clone()),
                                                                                                                                                                                                                            };
                                                                                                                                                                                                                        let v3846:
                                                                                                                                                                                                                                Result<std::path::PathBuf,
                                                                                                                                                                                                                                       std::io::Error> =
                                                                                                                                                                                                                            match &v3523
                                                                                                                                                                                                                                {
                                                                                                                                                                                                                                File_system::US13::US13_0(v3523_0_0)
                                                                                                                                                                                                                                =>
                                                                                                                                                                                                                                Ok(v3523_0_0.clone()),
                                                                                                                                                                                                                                File_system::US13::US13_1(v3523_1_0)
                                                                                                                                                                                                                                =>
                                                                                                                                                                                                                                {
                                                                                                                                                                                                                                    let v3538:
                                                                                                                                                                                                                                            string =
                                                                                                                                                                                                                                        v3523_1_0.clone();
                                                                                                                                                                                                                                    let v3539:
                                                                                                                                                                                                                                            string =
                                                                                                                                                                                                                                        File_system::method19(v3503.clone());
                                                                                                                                                                                                                                    let v3540:
                                                                                                                                                                                                                                            Option<string> =
                                                                                                                                                                                                                                        File_system::method78(v3503.clone());
                                                                                                                                                                                                                                    let v3554:
                                                                                                                                                                                                                                            File_system::US1 =
                                                                                                                                                                                                                                        defaultValue(File_system::US1::US1_1,
                                                                                                                                                                                                                                                     map(File_system::method4(),
                                                                                                                                                                                                                                                         v3540));
                                                                                                                                                                                                                                    if let File_system::US1::US1_0(v3554_0_0)
                                                                                                                                                                                                                                           =
                                                                                                                                                                                                                                           &v3554
                                                                                                                                                                                                                                       {
                                                                                                                                                                                                                                        let v3558:
                                                                                                                                                                                                                                                string =
                                                                                                                                                                                                                                            match &v3554
                                                                                                                                                                                                                                                {
                                                                                                                                                                                                                                                File_system::US1::US1_0(x)
                                                                                                                                                                                                                                                =>
                                                                                                                                                                                                                                                x.clone(),
                                                                                                                                                                                                                                                _
                                                                                                                                                                                                                                                =>
                                                                                                                                                                                                                                                unreachable!(),
                                                                                                                                                                                                                                            };
                                                                                                                                                                                                                                        if v3503.clone()
                                                                                                                                                                                                                                               !=
                                                                                                                                                                                                                                               string("")
                                                                                                                                                                                                                                           {
                                                                                                                                                                                                                                            let v3563:
                                                                                                                                                                                                                                                    Result<std::path::PathBuf,
                                                                                                                                                                                                                                                           std::io::Error> =
                                                                                                                                                                                                                                                std::fs::read_link(&*v3558.clone());
                                                                                                                                                                                                                                            let v3564 =
                                                                                                                                                                                                                                                File_system::method76();
                                                                                                                                                                                                                                            let v3575:
                                                                                                                                                                                                                                                    Result<std::path::PathBuf,
                                                                                                                                                                                                                                                           string> =
                                                                                                                                                                                                                                                v3563.map_err(|x| v3564(x));
                                                                                                                                                                                                                                            let v3578:
                                                                                                                                                                                                                                                    File_system::US13 =
                                                                                                                                                                                                                                                match &v3575
                                                                                                                                                                                                                                                    {
                                                                                                                                                                                                                                                    Err(v3575_1_0)
                                                                                                                                                                                                                                                    =>
                                                                                                                                                                                                                                                    v2971(v3575_1_0.clone()),
                                                                                                                                                                                                                                                    Ok(v3575_0_0)
                                                                                                                                                                                                                                                    =>
                                                                                                                                                                                                                                                    v2970(v3575_0_0.clone()),
                                                                                                                                                                                                                                                };
                                                                                                                                                                                                                                            let v3641:
                                                                                                                                                                                                                                                    Result<std::path::PathBuf,
                                                                                                                                                                                                                                                           std::io::Error> =
                                                                                                                                                                                                                                                match &v3578
                                                                                                                                                                                                                                                    {
                                                                                                                                                                                                                                                    File_system::US13::US13_0(v3578_0_0)
                                                                                                                                                                                                                                                    =>
                                                                                                                                                                                                                                                    Ok(v3578_0_0.clone()),
                                                                                                                                                                                                                                                    _
                                                                                                                                                                                                                                                    =>
                                                                                                                                                                                                                                                    {
                                                                                                                                                                                                                                                        let v3594:
                                                                                                                                                                                                                                                                string =
                                                                                                                                                                                                                                                            File_system::method19(v3558.clone());
                                                                                                                                                                                                                                                        let v3595:
                                                                                                                                                                                                                                                                Option<string> =
                                                                                                                                                                                                                                                            File_system::method78(v3558.clone());
                                                                                                                                                                                                                                                        let v3609:
                                                                                                                                                                                                                                                                File_system::US1 =
                                                                                                                                                                                                                                                            defaultValue(File_system::US1::US1_1,
                                                                                                                                                                                                                                                                         map(File_system::method4(),
                                                                                                                                                                                                                                                                             v3595));
                                                                                                                                                                                                                                                        let v3613:
                                                                                                                                                                                                                                                                string =
                                                                                                                                                                                                                                                            sprintf!("file_system.read_link / path: {} / n: {} / path\': {} / name: {}",
                                                                                                                                                                                                                                                                     v0_1.clone(),
                                                                                                                                                                                                                                                                     11_u8,
                                                                                                                                                                                                                                                                     v3558.clone(),
                                                                                                                                                                                                                                                                     v3594);
                                                                                                                                                                                                                                                        let v3618:
                                                                                                                                                                                                                                                                std::io::Error =
                                                                                                                                                                                                                                                            std::io::Error::new(std::io::ErrorKind::Other, &*v3613);
                                                                                                                                                                                                                                                        Err(v3618)
                                                                                                                                                                                                                                                    }
                                                                                                                                                                                                                                                };
                                                                                                                                                                                                                                            let v3642 =
                                                                                                                                                                                                                                                File_system::method76();
                                                                                                                                                                                                                                            let v3653:
                                                                                                                                                                                                                                                    Result<std::path::PathBuf,
                                                                                                                                                                                                                                                           string> =
                                                                                                                                                                                                                                                v3641.map_err(|x| v3642(x));
                                                                                                                                                                                                                                            let v3656:
                                                                                                                                                                                                                                                    File_system::US13 =
                                                                                                                                                                                                                                                match &v3653
                                                                                                                                                                                                                                                    {
                                                                                                                                                                                                                                                    Err(v3653_1_0)
                                                                                                                                                                                                                                                    =>
                                                                                                                                                                                                                                                    v2971(v3653_1_0.clone()),
                                                                                                                                                                                                                                                    Ok(v3653_0_0)
                                                                                                                                                                                                                                                    =>
                                                                                                                                                                                                                                                    v2970(v3653_0_0.clone()),
                                                                                                                                                                                                                                                };
                                                                                                                                                                                                                                            match &v3656
                                                                                                                                                                                                                                                {
                                                                                                                                                                                                                                                File_system::US13::US13_0(v3656_0_0)
                                                                                                                                                                                                                                                =>
                                                                                                                                                                                                                                                {
                                                                                                                                                                                                                                                    let v3682:
                                                                                                                                                                                                                                                            string =
                                                                                                                                                                                                                                                        File_system::method56(toString(v3656_0_0.clone().display()),
                                                                                                                                                                                                                                                                              v3539.clone());
                                                                                                                                                                                                                                                    let v3687:
                                                                                                                                                                                                                                                            &str =
                                                                                                                                                                                                                                                        &*v3682;
                                                                                                                                                                                                                                                    let v3708:
                                                                                                                                                                                                                                                            std::string::String =
                                                                                                                                                                                                                                                        String::from(v3687);
                                                                                                                                                                                                                                                    let v3729:
                                                                                                                                                                                                                                                            std::path::PathBuf =
                                                                                                                                                                                                                                                        std::path::PathBuf::from(v3708);
                                                                                                                                                                                                                                                    Ok(v3729)
                                                                                                                                                                                                                                                }
                                                                                                                                                                                                                                                File_system::US13::US13_1(v3656_1_0)
                                                                                                                                                                                                                                                =>
                                                                                                                                                                                                                                                {
                                                                                                                                                                                                                                                    let v3760:
                                                                                                                                                                                                                                                            string =
                                                                                                                                                                                                                                                        sprintf!("file_system.read_link / error\': {} / error: {} / name: {}",
                                                                                                                                                                                                                                                                 v3656_1_0.clone(),
                                                                                                                                                                                                                                                                 v3538.clone(),
                                                                                                                                                                                                                                                                 v3539.clone());
                                                                                                                                                                                                                                                    let v3765:
                                                                                                                                                                                                                                                            std::io::Error =
                                                                                                                                                                                                                                                        std::io::Error::new(std::io::ErrorKind::Other, &*v3760);
                                                                                                                                                                                                                                                    Err(v3765)
                                                                                                                                                                                                                                                }
                                                                                                                                                                                                                                            }
                                                                                                                                                                                                                                        } else {
                                                                                                                                                                                                                                            let v3789:
                                                                                                                                                                                                                                                    string =
                                                                                                                                                                                                                                                sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                                                                                                                                                                                                                         v0_1.clone(),
                                                                                                                                                                                                                                                         v3538.clone(),
                                                                                                                                                                                                                                                         v3503.clone(),
                                                                                                                                                                                                                                                         v3539.clone());
                                                                                                                                                                                                                                            let v3794:
                                                                                                                                                                                                                                                    std::io::Error =
                                                                                                                                                                                                                                                std::io::Error::new(std::io::ErrorKind::Other, &*v3789);
                                                                                                                                                                                                                                            Err(v3794)
                                                                                                                                                                                                                                        }
                                                                                                                                                                                                                                    } else {
                                                                                                                                                                                                                                        let v3817:
                                                                                                                                                                                                                                                string =
                                                                                                                                                                                                                                            sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                                                                                                                                                                                                                     v0_1.clone(),
                                                                                                                                                                                                                                                     v3538,
                                                                                                                                                                                                                                                     v3503.clone(),
                                                                                                                                                                                                                                                     v3539.clone());
                                                                                                                                                                                                                                        let v3822:
                                                                                                                                                                                                                                                std::io::Error =
                                                                                                                                                                                                                                            std::io::Error::new(std::io::ErrorKind::Other, &*v3817);
                                                                                                                                                                                                                                        Err(v3822)
                                                                                                                                                                                                                                    }
                                                                                                                                                                                                                                }
                                                                                                                                                                                                                            };
                                                                                                                                                                                                                        let v3847 =
                                                                                                                                                                                                                            File_system::method76();
                                                                                                                                                                                                                        let v3858:
                                                                                                                                                                                                                                Result<std::path::PathBuf,
                                                                                                                                                                                                                                       string> =
                                                                                                                                                                                                                            v3846.map_err(|x| v3847(x));
                                                                                                                                                                                                                        let v3861:
                                                                                                                                                                                                                                File_system::US13 =
                                                                                                                                                                                                                            match &v3858
                                                                                                                                                                                                                                {
                                                                                                                                                                                                                                Err(v3858_1_0)
                                                                                                                                                                                                                                =>
                                                                                                                                                                                                                                v2971(v3858_1_0.clone()),
                                                                                                                                                                                                                                Ok(v3858_0_0)
                                                                                                                                                                                                                                =>
                                                                                                                                                                                                                                v2970(v3858_0_0.clone()),
                                                                                                                                                                                                                            };
                                                                                                                                                                                                                        match &v3861
                                                                                                                                                                                                                            {
                                                                                                                                                                                                                            File_system::US13::US13_0(v3861_0_0)
                                                                                                                                                                                                                            =>
                                                                                                                                                                                                                            {
                                                                                                                                                                                                                                let v3887:
                                                                                                                                                                                                                                        string =
                                                                                                                                                                                                                                    File_system::method56(toString(v3861_0_0.clone().display()),
                                                                                                                                                                                                                                                          v3484.clone());
                                                                                                                                                                                                                                let v3892:
                                                                                                                                                                                                                                        &str =
                                                                                                                                                                                                                                    &*v3887;
                                                                                                                                                                                                                                let v3913:
                                                                                                                                                                                                                                        std::string::String =
                                                                                                                                                                                                                                    String::from(v3892);
                                                                                                                                                                                                                                let v3934:
                                                                                                                                                                                                                                        std::path::PathBuf =
                                                                                                                                                                                                                                    std::path::PathBuf::from(v3913);
                                                                                                                                                                                                                                Ok(v3934)
                                                                                                                                                                                                                            }
                                                                                                                                                                                                                            File_system::US13::US13_1(v3861_1_0)
                                                                                                                                                                                                                            =>
                                                                                                                                                                                                                            {
                                                                                                                                                                                                                                let v3965:
                                                                                                                                                                                                                                        string =
                                                                                                                                                                                                                                    sprintf!("file_system.read_link / error\': {} / error: {} / name: {}",
                                                                                                                                                                                                                                             v3861_1_0.clone(),
                                                                                                                                                                                                                                             v3483.clone(),
                                                                                                                                                                                                                                             v3484.clone());
                                                                                                                                                                                                                                let v3970:
                                                                                                                                                                                                                                        std::io::Error =
                                                                                                                                                                                                                                    std::io::Error::new(std::io::ErrorKind::Other, &*v3965);
                                                                                                                                                                                                                                Err(v3970)
                                                                                                                                                                                                                            }
                                                                                                                                                                                                                        }
                                                                                                                                                                                                                    } else {
                                                                                                                                                                                                                        let v3994:
                                                                                                                                                                                                                                string =
                                                                                                                                                                                                                            sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                                                                                                                                                                                                     v0_1.clone(),
                                                                                                                                                                                                                                     v3483.clone(),
                                                                                                                                                                                                                                     v3448.clone(),
                                                                                                                                                                                                                                     v3484.clone());
                                                                                                                                                                                                                        let v3999:
                                                                                                                                                                                                                                std::io::Error =
                                                                                                                                                                                                                            std::io::Error::new(std::io::ErrorKind::Other, &*v3994);
                                                                                                                                                                                                                        Err(v3999)
                                                                                                                                                                                                                    }
                                                                                                                                                                                                                } else {
                                                                                                                                                                                                                    let v4022:
                                                                                                                                                                                                                            string =
                                                                                                                                                                                                                        sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                                                                                                                                                                                                 v0_1.clone(),
                                                                                                                                                                                                                                 v3483,
                                                                                                                                                                                                                                 v3448.clone(),
                                                                                                                                                                                                                                 v3484.clone());
                                                                                                                                                                                                                    let v4027:
                                                                                                                                                                                                                            std::io::Error =
                                                                                                                                                                                                                        std::io::Error::new(std::io::ErrorKind::Other, &*v4022);
                                                                                                                                                                                                                    Err(v4027)
                                                                                                                                                                                                                }
                                                                                                                                                                                                            }
                                                                                                                                                                                                        };
                                                                                                                                                                                                    let v4052 =
                                                                                                                                                                                                        File_system::method76();
                                                                                                                                                                                                    let v4063:
                                                                                                                                                                                                            Result<std::path::PathBuf,
                                                                                                                                                                                                                   string> =
                                                                                                                                                                                                        v4051.map_err(|x| v4052(x));
                                                                                                                                                                                                    let v4066:
                                                                                                                                                                                                            File_system::US13 =
                                                                                                                                                                                                        match &v4063
                                                                                                                                                                                                            {
                                                                                                                                                                                                            Err(v4063_1_0)
                                                                                                                                                                                                            =>
                                                                                                                                                                                                            v2971(v4063_1_0.clone()),
                                                                                                                                                                                                            Ok(v4063_0_0)
                                                                                                                                                                                                            =>
                                                                                                                                                                                                            v2970(v4063_0_0.clone()),
                                                                                                                                                                                                        };
                                                                                                                                                                                                    match &v4066
                                                                                                                                                                                                        {
                                                                                                                                                                                                        File_system::US13::US13_0(v4066_0_0)
                                                                                                                                                                                                        =>
                                                                                                                                                                                                        {
                                                                                                                                                                                                            let v4092:
                                                                                                                                                                                                                    string =
                                                                                                                                                                                                                File_system::method56(toString(v4066_0_0.clone().display()),
                                                                                                                                                                                                                                      v3429.clone());
                                                                                                                                                                                                            let v4097:
                                                                                                                                                                                                                    &str =
                                                                                                                                                                                                                &*v4092;
                                                                                                                                                                                                            let v4118:
                                                                                                                                                                                                                    std::string::String =
                                                                                                                                                                                                                String::from(v4097);
                                                                                                                                                                                                            let v4139:
                                                                                                                                                                                                                    std::path::PathBuf =
                                                                                                                                                                                                                std::path::PathBuf::from(v4118);
                                                                                                                                                                                                            Ok(v4139)
                                                                                                                                                                                                        }
                                                                                                                                                                                                        File_system::US13::US13_1(v4066_1_0)
                                                                                                                                                                                                        =>
                                                                                                                                                                                                        {
                                                                                                                                                                                                            let v4170:
                                                                                                                                                                                                                    string =
                                                                                                                                                                                                                sprintf!("file_system.read_link / error\': {} / error: {} / name: {}",
                                                                                                                                                                                                                         v4066_1_0.clone(),
                                                                                                                                                                                                                         v3428.clone(),
                                                                                                                                                                                                                         v3429.clone());
                                                                                                                                                                                                            let v4175:
                                                                                                                                                                                                                    std::io::Error =
                                                                                                                                                                                                                std::io::Error::new(std::io::ErrorKind::Other, &*v4170);
                                                                                                                                                                                                            Err(v4175)
                                                                                                                                                                                                        }
                                                                                                                                                                                                    }
                                                                                                                                                                                                } else {
                                                                                                                                                                                                    let v4199:
                                                                                                                                                                                                            string =
                                                                                                                                                                                                        sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                                                                                                                                                                                 v0_1.clone(),
                                                                                                                                                                                                                 v3428.clone(),
                                                                                                                                                                                                                 v3393.clone(),
                                                                                                                                                                                                                 v3429.clone());
                                                                                                                                                                                                    let v4204:
                                                                                                                                                                                                            std::io::Error =
                                                                                                                                                                                                        std::io::Error::new(std::io::ErrorKind::Other, &*v4199);
                                                                                                                                                                                                    Err(v4204)
                                                                                                                                                                                                }
                                                                                                                                                                                            } else {
                                                                                                                                                                                                let v4227:
                                                                                                                                                                                                        string =
                                                                                                                                                                                                    sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                                                                                                                                                                             v0_1.clone(),
                                                                                                                                                                                                             v3428,
                                                                                                                                                                                                             v3393.clone(),
                                                                                                                                                                                                             v3429.clone());
                                                                                                                                                                                                let v4232:
                                                                                                                                                                                                        std::io::Error =
                                                                                                                                                                                                    std::io::Error::new(std::io::ErrorKind::Other, &*v4227);
                                                                                                                                                                                                Err(v4232)
                                                                                                                                                                                            }
                                                                                                                                                                                        }
                                                                                                                                                                                    };
                                                                                                                                                                                let v4257 =
                                                                                                                                                                                    File_system::method76();
                                                                                                                                                                                let v4268:
                                                                                                                                                                                        Result<std::path::PathBuf,
                                                                                                                                                                                               string> =
                                                                                                                                                                                    v4256.map_err(|x| v4257(x));
                                                                                                                                                                                let v4271:
                                                                                                                                                                                        File_system::US13 =
                                                                                                                                                                                    match &v4268
                                                                                                                                                                                        {
                                                                                                                                                                                        Err(v4268_1_0)
                                                                                                                                                                                        =>
                                                                                                                                                                                        v2971(v4268_1_0.clone()),
                                                                                                                                                                                        Ok(v4268_0_0)
                                                                                                                                                                                        =>
                                                                                                                                                                                        v2970(v4268_0_0.clone()),
                                                                                                                                                                                    };
                                                                                                                                                                                match &v4271
                                                                                                                                                                                    {
                                                                                                                                                                                    File_system::US13::US13_0(v4271_0_0)
                                                                                                                                                                                    =>
                                                                                                                                                                                    {
                                                                                                                                                                                        let v4297:
                                                                                                                                                                                                string =
                                                                                                                                                                                            File_system::method56(toString(v4271_0_0.clone().display()),
                                                                                                                                                                                                                  v3374.clone());
                                                                                                                                                                                        let v4302:
                                                                                                                                                                                                &str =
                                                                                                                                                                                            &*v4297;
                                                                                                                                                                                        let v4323:
                                                                                                                                                                                                std::string::String =
                                                                                                                                                                                            String::from(v4302);
                                                                                                                                                                                        let v4344:
                                                                                                                                                                                                std::path::PathBuf =
                                                                                                                                                                                            std::path::PathBuf::from(v4323);
                                                                                                                                                                                        Ok(v4344)
                                                                                                                                                                                    }
                                                                                                                                                                                    File_system::US13::US13_1(v4271_1_0)
                                                                                                                                                                                    =>
                                                                                                                                                                                    {
                                                                                                                                                                                        let v4375:
                                                                                                                                                                                                string =
                                                                                                                                                                                            sprintf!("file_system.read_link / error\': {} / error: {} / name: {}",
                                                                                                                                                                                                     v4271_1_0.clone(),
                                                                                                                                                                                                     v3373.clone(),
                                                                                                                                                                                                     v3374.clone());
                                                                                                                                                                                        let v4380:
                                                                                                                                                                                                std::io::Error =
                                                                                                                                                                                            std::io::Error::new(std::io::ErrorKind::Other, &*v4375);
                                                                                                                                                                                        Err(v4380)
                                                                                                                                                                                    }
                                                                                                                                                                                }
                                                                                                                                                                            } else {
                                                                                                                                                                                let v4404:
                                                                                                                                                                                        string =
                                                                                                                                                                                    sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                                                                                                                                                             v0_1.clone(),
                                                                                                                                                                                             v3373.clone(),
                                                                                                                                                                                             v3338.clone(),
                                                                                                                                                                                             v3374.clone());
                                                                                                                                                                                let v4409:
                                                                                                                                                                                        std::io::Error =
                                                                                                                                                                                    std::io::Error::new(std::io::ErrorKind::Other, &*v4404);
                                                                                                                                                                                Err(v4409)
                                                                                                                                                                            }
                                                                                                                                                                        } else {
                                                                                                                                                                            let v4432:
                                                                                                                                                                                    string =
                                                                                                                                                                                sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                                                                                                                                                         v0_1.clone(),
                                                                                                                                                                                         v3373,
                                                                                                                                                                                         v3338.clone(),
                                                                                                                                                                                         v3374.clone());
                                                                                                                                                                            let v4437:
                                                                                                                                                                                    std::io::Error =
                                                                                                                                                                                std::io::Error::new(std::io::ErrorKind::Other, &*v4432);
                                                                                                                                                                            Err(v4437)
                                                                                                                                                                        }
                                                                                                                                                                    }
                                                                                                                                                                };
                                                                                                                                                            let v4462 =
                                                                                                                                                                File_system::method76();
                                                                                                                                                            let v4473:
                                                                                                                                                                    Result<std::path::PathBuf,
                                                                                                                                                                           string> =
                                                                                                                                                                v4461.map_err(|x| v4462(x));
                                                                                                                                                            let v4476:
                                                                                                                                                                    File_system::US13 =
                                                                                                                                                                match &v4473
                                                                                                                                                                    {
                                                                                                                                                                    Err(v4473_1_0)
                                                                                                                                                                    =>
                                                                                                                                                                    v2971(v4473_1_0.clone()),
                                                                                                                                                                    Ok(v4473_0_0)
                                                                                                                                                                    =>
                                                                                                                                                                    v2970(v4473_0_0.clone()),
                                                                                                                                                                };
                                                                                                                                                            match &v4476
                                                                                                                                                                {
                                                                                                                                                                File_system::US13::US13_0(v4476_0_0)
                                                                                                                                                                =>
                                                                                                                                                                {
                                                                                                                                                                    let v4502:
                                                                                                                                                                            string =
                                                                                                                                                                        File_system::method56(toString(v4476_0_0.clone().display()),
                                                                                                                                                                                              v3319.clone());
                                                                                                                                                                    let v4507:
                                                                                                                                                                            &str =
                                                                                                                                                                        &*v4502;
                                                                                                                                                                    let v4528:
                                                                                                                                                                            std::string::String =
                                                                                                                                                                        String::from(v4507);
                                                                                                                                                                    let v4549:
                                                                                                                                                                            std::path::PathBuf =
                                                                                                                                                                        std::path::PathBuf::from(v4528);
                                                                                                                                                                    Ok(v4549)
                                                                                                                                                                }
                                                                                                                                                                File_system::US13::US13_1(v4476_1_0)
                                                                                                                                                                =>
                                                                                                                                                                {
                                                                                                                                                                    let v4580:
                                                                                                                                                                            string =
                                                                                                                                                                        sprintf!("file_system.read_link / error\': {} / error: {} / name: {}",
                                                                                                                                                                                 v4476_1_0.clone(),
                                                                                                                                                                                 v3318.clone(),
                                                                                                                                                                                 v3319.clone());
                                                                                                                                                                    let v4585:
                                                                                                                                                                            std::io::Error =
                                                                                                                                                                        std::io::Error::new(std::io::ErrorKind::Other, &*v4580);
                                                                                                                                                                    Err(v4585)
                                                                                                                                                                }
                                                                                                                                                            }
                                                                                                                                                        } else {
                                                                                                                                                            let v4609:
                                                                                                                                                                    string =
                                                                                                                                                                sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                                                                                                                                         v0_1.clone(),
                                                                                                                                                                         v3318.clone(),
                                                                                                                                                                         v3283.clone(),
                                                                                                                                                                         v3319.clone());
                                                                                                                                                            let v4614:
                                                                                                                                                                    std::io::Error =
                                                                                                                                                                std::io::Error::new(std::io::ErrorKind::Other, &*v4609);
                                                                                                                                                            Err(v4614)
                                                                                                                                                        }
                                                                                                                                                    } else {
                                                                                                                                                        let v4637:
                                                                                                                                                                string =
                                                                                                                                                            sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                                                                                                                                     v0_1.clone(),
                                                                                                                                                                     v3318,
                                                                                                                                                                     v3283.clone(),
                                                                                                                                                                     v3319.clone());
                                                                                                                                                        let v4642:
                                                                                                                                                                std::io::Error =
                                                                                                                                                            std::io::Error::new(std::io::ErrorKind::Other, &*v4637);
                                                                                                                                                        Err(v4642)
                                                                                                                                                    }
                                                                                                                                                }
                                                                                                                                            };
                                                                                                                                        let v4667 =
                                                                                                                                            File_system::method76();
                                                                                                                                        let v4678:
                                                                                                                                                Result<std::path::PathBuf,
                                                                                                                                                       string> =
                                                                                                                                            v4666.map_err(|x| v4667(x));
                                                                                                                                        let v4681:
                                                                                                                                                File_system::US13 =
                                                                                                                                            match &v4678
                                                                                                                                                {
                                                                                                                                                Err(v4678_1_0)
                                                                                                                                                =>
                                                                                                                                                v2971(v4678_1_0.clone()),
                                                                                                                                                Ok(v4678_0_0)
                                                                                                                                                =>
                                                                                                                                                v2970(v4678_0_0.clone()),
                                                                                                                                            };
                                                                                                                                        match &v4681
                                                                                                                                            {
                                                                                                                                            File_system::US13::US13_0(v4681_0_0)
                                                                                                                                            =>
                                                                                                                                            {
                                                                                                                                                let v4707:
                                                                                                                                                        string =
                                                                                                                                                    File_system::method56(toString(v4681_0_0.clone().display()),
                                                                                                                                                                          v3264.clone());
                                                                                                                                                let v4712:
                                                                                                                                                        &str =
                                                                                                                                                    &*v4707;
                                                                                                                                                let v4733:
                                                                                                                                                        std::string::String =
                                                                                                                                                    String::from(v4712);
                                                                                                                                                let v4754:
                                                                                                                                                        std::path::PathBuf =
                                                                                                                                                    std::path::PathBuf::from(v4733);
                                                                                                                                                Ok(v4754)
                                                                                                                                            }
                                                                                                                                            File_system::US13::US13_1(v4681_1_0)
                                                                                                                                            =>
                                                                                                                                            {
                                                                                                                                                let v4785:
                                                                                                                                                        string =
                                                                                                                                                    sprintf!("file_system.read_link / error\': {} / error: {} / name: {}",
                                                                                                                                                             v4681_1_0.clone(),
                                                                                                                                                             v3263.clone(),
                                                                                                                                                             v3264.clone());
                                                                                                                                                let v4790:
                                                                                                                                                        std::io::Error =
                                                                                                                                                    std::io::Error::new(std::io::ErrorKind::Other, &*v4785);
                                                                                                                                                Err(v4790)
                                                                                                                                            }
                                                                                                                                        }
                                                                                                                                    } else {
                                                                                                                                        let v4814:
                                                                                                                                                string =
                                                                                                                                            sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                                                                                                                     v0_1.clone(),
                                                                                                                                                     v3263.clone(),
                                                                                                                                                     v3228.clone(),
                                                                                                                                                     v3264.clone());
                                                                                                                                        let v4819:
                                                                                                                                                std::io::Error =
                                                                                                                                            std::io::Error::new(std::io::ErrorKind::Other, &*v4814);
                                                                                                                                        Err(v4819)
                                                                                                                                    }
                                                                                                                                } else {
                                                                                                                                    let v4842:
                                                                                                                                            string =
                                                                                                                                        sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                                                                                                                 v0_1.clone(),
                                                                                                                                                 v3263,
                                                                                                                                                 v3228.clone(),
                                                                                                                                                 v3264.clone());
                                                                                                                                    let v4847:
                                                                                                                                            std::io::Error =
                                                                                                                                        std::io::Error::new(std::io::ErrorKind::Other, &*v4842);
                                                                                                                                    Err(v4847)
                                                                                                                                }
                                                                                                                            }
                                                                                                                        };
                                                                                                                    let v4872 =
                                                                                                                        File_system::method76();
                                                                                                                    let v4883:
                                                                                                                            Result<std::path::PathBuf,
                                                                                                                                   string> =
                                                                                                                        v4871.map_err(|x| v4872(x));
                                                                                                                    let v4886:
                                                                                                                            File_system::US13 =
                                                                                                                        match &v4883
                                                                                                                            {
                                                                                                                            Err(v4883_1_0)
                                                                                                                            =>
                                                                                                                            v2971(v4883_1_0.clone()),
                                                                                                                            Ok(v4883_0_0)
                                                                                                                            =>
                                                                                                                            v2970(v4883_0_0.clone()),
                                                                                                                        };
                                                                                                                    match &v4886
                                                                                                                        {
                                                                                                                        File_system::US13::US13_0(v4886_0_0)
                                                                                                                        =>
                                                                                                                        {
                                                                                                                            let v4912:
                                                                                                                                    string =
                                                                                                                                File_system::method56(toString(v4886_0_0.clone().display()),
                                                                                                                                                      v3209.clone());
                                                                                                                            let v4917:
                                                                                                                                    &str =
                                                                                                                                &*v4912;
                                                                                                                            let v4938:
                                                                                                                                    std::string::String =
                                                                                                                                String::from(v4917);
                                                                                                                            let v4959:
                                                                                                                                    std::path::PathBuf =
                                                                                                                                std::path::PathBuf::from(v4938);
                                                                                                                            Ok(v4959)
                                                                                                                        }
                                                                                                                        File_system::US13::US13_1(v4886_1_0)
                                                                                                                        =>
                                                                                                                        {
                                                                                                                            let v4990:
                                                                                                                                    string =
                                                                                                                                sprintf!("file_system.read_link / error\': {} / error: {} / name: {}",
                                                                                                                                         v4886_1_0.clone(),
                                                                                                                                         v3208.clone(),
                                                                                                                                         v3209.clone());
                                                                                                                            let v4995:
                                                                                                                                    std::io::Error =
                                                                                                                                std::io::Error::new(std::io::ErrorKind::Other, &*v4990);
                                                                                                                            Err(v4995)
                                                                                                                        }
                                                                                                                    }
                                                                                                                } else {
                                                                                                                    let v5019:
                                                                                                                            string =
                                                                                                                        sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                                                                                                 v0_1.clone(),
                                                                                                                                 v3208.clone(),
                                                                                                                                 v3173.clone(),
                                                                                                                                 v3209.clone());
                                                                                                                    let v5024:
                                                                                                                            std::io::Error =
                                                                                                                        std::io::Error::new(std::io::ErrorKind::Other, &*v5019);
                                                                                                                    Err(v5024)
                                                                                                                }
                                                                                                            } else {
                                                                                                                let v5047:
                                                                                                                        string =
                                                                                                                    sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                                                                                             v0_1.clone(),
                                                                                                                             v3208,
                                                                                                                             v3173.clone(),
                                                                                                                             v3209.clone());
                                                                                                                let v5052:
                                                                                                                        std::io::Error =
                                                                                                                    std::io::Error::new(std::io::ErrorKind::Other, &*v5047);
                                                                                                                Err(v5052)
                                                                                                            }
                                                                                                        }
                                                                                                    };
                                                                                                let v5077 =
                                                                                                    File_system::method76();
                                                                                                let v5088:
                                                                                                        Result<std::path::PathBuf,
                                                                                                               string> =
                                                                                                    v5076.map_err(|x| v5077(x));
                                                                                                let v5091:
                                                                                                        File_system::US13 =
                                                                                                    match &v5088
                                                                                                        {
                                                                                                        Err(v5088_1_0)
                                                                                                        =>
                                                                                                        v2971(v5088_1_0.clone()),
                                                                                                        Ok(v5088_0_0)
                                                                                                        =>
                                                                                                        v2970(v5088_0_0.clone()),
                                                                                                    };
                                                                                                match &v5091
                                                                                                    {
                                                                                                    File_system::US13::US13_0(v5091_0_0)
                                                                                                    =>
                                                                                                    {
                                                                                                        let v5117:
                                                                                                                string =
                                                                                                            File_system::method56(toString(v5091_0_0.clone().display()),
                                                                                                                                  v3154.clone());
                                                                                                        let v5122:
                                                                                                                &str =
                                                                                                            &*v5117;
                                                                                                        let v5143:
                                                                                                                std::string::String =
                                                                                                            String::from(v5122);
                                                                                                        let v5164:
                                                                                                                std::path::PathBuf =
                                                                                                            std::path::PathBuf::from(v5143);
                                                                                                        Ok(v5164)
                                                                                                    }
                                                                                                    File_system::US13::US13_1(v5091_1_0)
                                                                                                    =>
                                                                                                    {
                                                                                                        let v5195:
                                                                                                                string =
                                                                                                            sprintf!("file_system.read_link / error\': {} / error: {} / name: {}",
                                                                                                                     v5091_1_0.clone(),
                                                                                                                     v3153.clone(),
                                                                                                                     v3154.clone());
                                                                                                        let v5200:
                                                                                                                std::io::Error =
                                                                                                            std::io::Error::new(std::io::ErrorKind::Other, &*v5195);
                                                                                                        Err(v5200)
                                                                                                    }
                                                                                                }
                                                                                            } else {
                                                                                                let v5224:
                                                                                                        string =
                                                                                                    sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                                                                             v0_1.clone(),
                                                                                                             v3153.clone(),
                                                                                                             v3118.clone(),
                                                                                                             v3154.clone());
                                                                                                let v5229:
                                                                                                        std::io::Error =
                                                                                                    std::io::Error::new(std::io::ErrorKind::Other, &*v5224);
                                                                                                Err(v5229)
                                                                                            }
                                                                                        } else {
                                                                                            let v5252:
                                                                                                    string =
                                                                                                sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                                                                         v0_1.clone(),
                                                                                                         v3153,
                                                                                                         v3118.clone(),
                                                                                                         v3154.clone());
                                                                                            let v5257:
                                                                                                    std::io::Error =
                                                                                                std::io::Error::new(std::io::ErrorKind::Other, &*v5252);
                                                                                            Err(v5257)
                                                                                        }
                                                                    }
                                                                };
                                                                let v5282 = File_system::method76();
                                                                let v5293: Result<
                                                                    std::path::PathBuf,
                                                                    string,
                                                                > = v5281.map_err(|x| v5282(x));
                                                                let v5296: File_system::US13 =
                                                                    match &v5293 {
                                                                        Err(v5293_1_0) => {
                                                                            v2971(v5293_1_0.clone())
                                                                        }
                                                                        Ok(v5293_0_0) => {
                                                                            v2970(v5293_0_0.clone())
                                                                        }
                                                                    };
                                                                match &v5296 {
                                                                    File_system::US13::US13_0(
                                                                        v5296_0_0,
                                                                    ) => {
                                                                        let v5322: string =
                                                                            File_system::method56(
                                                                                toString(
                                                                                    v5296_0_0
                                                                                        .clone()
                                                                                        .display(),
                                                                                ),
                                                                                v3099.clone(),
                                                                            );
                                                                        let v5327: &str = &*v5322;
                                                                        let v5348:
                                                                                            std::string::String =
                                                                                        String::from(v5327);
                                                                        let v5369:
                                                                                            std::path::PathBuf =
                                                                                        std::path::PathBuf::from(v5348);
                                                                        Ok(v5369)
                                                                    }
                                                                    File_system::US13::US13_1(
                                                                        v5296_1_0,
                                                                    ) => {
                                                                        let v5400:
                                                                                            string =
                                                                                        sprintf!("file_system.read_link / error\': {} / error: {} / name: {}",
                                                                                                 v5296_1_0.clone(),
                                                                                                 v3098.clone(),
                                                                                                 v3099.clone());
                                                                        let v5405:
                                                                                            std::io::Error =
                                                                                        std::io::Error::new(std::io::ErrorKind::Other, &*v5400);
                                                                        Err(v5405)
                                                                    }
                                                                }
                                                            } else {
                                                                let v5429:
                                                                                    string =
                                                                                sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                                                         v0_1.clone(),
                                                                                         v3098.clone(),
                                                                                         v3063.clone(),
                                                                                         v3099.clone());
                                                                let v5434: std::io::Error =
                                                                    std::io::Error::new(
                                                                        std::io::ErrorKind::Other,
                                                                        &*v5429,
                                                                    );
                                                                Err(v5434)
                                                            }
                                                        } else {
                                                            let v5457:
                                                                                string =
                                                                            sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                                                     v0_1.clone(),
                                                                                     v3098,
                                                                                     v3063.clone(),
                                                                                     v3099.clone());
                                                            let v5462: std::io::Error =
                                                                std::io::Error::new(
                                                                    std::io::ErrorKind::Other,
                                                                    &*v5457,
                                                                );
                                                            Err(v5462)
                                                        }
                                                    }
                                                };
                                                let v5487 = File_system::method76();
                                                let v5498: Result<std::path::PathBuf, string> =
                                                    v5486.map_err(|x| v5487(x));
                                                let v5501: File_system::US13 = match &v5498 {
                                                    Err(v5498_1_0) => v2971(v5498_1_0.clone()),
                                                    Ok(v5498_0_0) => v2970(v5498_0_0.clone()),
                                                };
                                                match &v5501 {
                                                    File_system::US13::US13_0(v5501_0_0) => {
                                                        let v5527: string = File_system::method56(
                                                            toString(v5501_0_0.clone().display()),
                                                            v3044.clone(),
                                                        );
                                                        let v5532: &str = &*v5527;
                                                        let v5553: std::string::String =
                                                            String::from(v5532);
                                                        let v5574: std::path::PathBuf =
                                                            std::path::PathBuf::from(v5553);
                                                        Ok(v5574)
                                                    }
                                                    File_system::US13::US13_1(v5501_1_0) => {
                                                        let v5605:
                                                                        string =
                                                                    sprintf!("file_system.read_link / error\': {} / error: {} / name: {}",
                                                                             v5501_1_0.clone(),
                                                                             v3043.clone(),
                                                                             v3044.clone());
                                                        let v5610: std::io::Error =
                                                            std::io::Error::new(
                                                                std::io::ErrorKind::Other,
                                                                &*v5605,
                                                            );
                                                        Err(v5610)
                                                    }
                                                }
                                            } else {
                                                let v5634: string =
                                                            sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                                     v0_1.clone(),
                                                                     v3043.clone(),
                                                                     v3007.clone(),
                                                                     v3044.clone());
                                                let v5639: std::io::Error = std::io::Error::new(
                                                    std::io::ErrorKind::Other,
                                                    &*v5634,
                                                );
                                                Err(v5639)
                                            }
                                        } else {
                                            let v5662: string =
                                                        sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                                 v0_1.clone(),
                                                                 v3043,
                                                                 v3007.clone(),
                                                                 v3044.clone());
                                            let v5667: std::io::Error = std::io::Error::new(
                                                std::io::ErrorKind::Other,
                                                &*v5662,
                                            );
                                            Err(v5667)
                                        }
                                    }
                                };
                                let v5692 = File_system::method76();
                                let v5703: Result<std::path::PathBuf, string> =
                                    v5691.map_err(|x| v5692(x));
                                let v5706: File_system::US13 = match &v5703 {
                                    Err(v5703_1_0) => v2971(v5703_1_0.clone()),
                                    Ok(v5703_0_0) => v2970(v5703_0_0.clone()),
                                };
                                match &v5706 {
                                    File_system::US13::US13_0(v5706_0_0) => {
                                        let v5732: string = File_system::method56(
                                            toString(v5706_0_0.clone().display()),
                                            v2988.clone(),
                                        );
                                        let v5737: &str = &*v5732;
                                        let v5758: std::string::String = String::from(v5737);
                                        let v5779: std::path::PathBuf =
                                            std::path::PathBuf::from(v5758);
                                        Ok(v5779)
                                    }
                                    File_system::US13::US13_1(v5706_1_0) => {
                                        let v5810: string =
                                                sprintf!("file_system.read_link / error\': {} / error: {} / name: {}",
                                                         v5706_1_0.clone(),
                                                         v2987.clone(),
                                                         v2988.clone());
                                        let v5815: std::io::Error =
                                            std::io::Error::new(std::io::ErrorKind::Other, &*v5810);
                                        Err(v5815)
                                    }
                                }
                            } else {
                                let v5839: string =
                                        sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                 v0_1.clone(), v2987.clone(),
                                                 v0_1.clone(), v2988.clone());
                                let v5844: std::io::Error =
                                    std::io::Error::new(std::io::ErrorKind::Other, &*v5839);
                                Err(v5844)
                            }
                        } else {
                            let v5867: string =
                                    sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                             v0_1.clone(), v2987,
                                             v0_1.clone(), v2988.clone());
                            let v5872: std::io::Error =
                                std::io::Error::new(std::io::ErrorKind::Other, &*v5867);
                            Err(v5872)
                        }
                    }
                }
            };
            let v13139: Option<std::path::PathBuf> = v5897.ok();
            let v13161: File_system::US14 = defaultValue(
                File_system::US14::US14_1,
                map(File_system::method80(), v13139),
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
                let v13198: string =
                    File_system::method81(string("^\\\\\\\\\\?\\\\"), string(""), v13193);
                replace(
                    sprintf!(
                        "{}{}",
                        toLower(ofChar(getCharAt(v13198.clone(), 0_i32))),
                        getSlice(v13198, Some(1_i32), None::<i32>)
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
    pub fn method84() -> Func1<string, Option<string>> {
        Func1::new(move |v: string| File_system::closure52((), v))
    }
    pub fn method85(v0_1: string, v1_1: string, v2_1: string) -> File_system::US15 {
        let v0_1: MutCell<string> = MutCell::new(v0_1.clone());
        let v1_1: MutCell<string> = MutCell::new(v1_1.clone());
        let v2_1: MutCell<string> = MutCell::new(v2_1.clone());
        '_method85: loop {
            break '_method85 (if File_system::method9(File_system::method56(
                v2_1.get().clone(),
                v0_1.get().clone(),
            )) {
                File_system::US15::US15_0(v2_1.get().clone())
            } else {
                let v7: Option<string> = (File_system::method84())(v2_1.get().clone());
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
                        continue '_method85;
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
    pub fn method83(v0_1: string, v1_1: string) -> File_system::US15 {
        if File_system::method9(File_system::method56(v1_1.clone(), v0_1.clone())) {
            File_system::US15::US15_0(v1_1.clone())
        } else {
            let v6: Option<string> = (File_system::method84())(v1_1.clone());
            let v20_1: File_system::US1 =
                defaultValue(File_system::US1::US1_1, map(File_system::method4(), v6));
            match &v20_1 {
                File_system::US1::US1_0(v20_1_0_0) => File_system::method85(
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
    pub fn method87(v0_1: string) -> string {
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
    pub fn method86(
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
        let v9: string = File_system::method87(v8);
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
            File_system::method23(File_system::method86(
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
    pub fn method88() -> string {
        unbox::<string>(&defaultOf())
    }
    pub fn closure51(unitVar: (), unitVar_1: ()) -> string {
        let v4: File_system::US15 = File_system::method83(
            File_system::method56(string("polyglot"), string(".devcontainer")),
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
                let v55: string = File_system::method88();
                let v57: File_system::US15 = File_system::method83(
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
    pub fn method89(v0_1: string) {
        ();
        ()
    }
    pub fn closure55(unitVar: (), v0_1: string) {
        File_system::method89(v0_1);
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
    pub fn method90(v0_1: string, v1_1: string) {
        if File_system::method9(v0_1.clone()) == false {
            let v4: LrcPtr<dyn IDisposable> = File_system::method61(v0_1);
            ()
        }
        {
            let v5: string = File_system::method79(v1_1.clone());
            if File_system::method9(v5.clone()) == false {
                let v8: LrcPtr<dyn IDisposable> = File_system::method61(v5);
                ()
            }
            if if File_system::method9(v1_1.clone()) {
                let v5904: Result<std::path::PathBuf, std::io::Error> = if File_system::method9(
                    v1_1.clone(),
                ) {
                    std::fs::read_link(&*v1_1.clone())
                } else {
                    let v2962: Result<std::path::PathBuf, std::io::Error> =
                        std::fs::read_link(&*v1_1.clone());
                    let v2963 = File_system::method76();
                    let v2974: Result<std::path::PathBuf, string> = v2962.map_err(|x| v2963(x));
                    fn v2977(v: std::path::PathBuf) -> File_system::US13 {
                        File_system::closure47((), v)
                    }
                    fn v2978(v_1: string) -> File_system::US13 {
                        File_system::closure48((), v_1)
                    }
                    let v2979: File_system::US13 = match &v2974 {
                        Err(v2974_1_0) => v2978(v2974_1_0.clone()),
                        Ok(v2974_0_0) => v2977(v2974_0_0.clone()),
                    };
                    match &v2979 {
                        File_system::US13::US13_0(v2979_0_0) => Ok(v2979_0_0.clone()),
                        File_system::US13::US13_1(v2979_1_0) => {
                            let v2994: string = v2979_1_0.clone();
                            let v2995: string = File_system::method19(v1_1.clone());
                            let v2996: Option<string> = File_system::method78(v1_1.clone());
                            let v3010: File_system::US1 = defaultValue(
                                File_system::US1::US1_1,
                                map(File_system::method4(), v2996),
                            );
                            if let File_system::US1::US1_0(v3010_0_0) = &v3010 {
                                let v3014: string = match &v3010 {
                                    File_system::US1::US1_0(x) => x.clone(),
                                    _ => unreachable!(),
                                };
                                if v1_1.clone() != string("") {
                                    let v3020: Result<std::path::PathBuf, std::io::Error> =
                                        std::fs::read_link(&*v3014.clone());
                                    let v3021 = File_system::method76();
                                    let v3032: Result<std::path::PathBuf, string> =
                                        v3020.map_err(|x| v3021(x));
                                    let v3035: File_system::US13 = match &v3032 {
                                        Err(v3032_1_0) => v2978(v3032_1_0.clone()),
                                        Ok(v3032_0_0) => v2977(v3032_0_0.clone()),
                                    };
                                    let v5698: Result<std::path::PathBuf, std::io::Error> =
                                        match &v3035 {
                                            File_system::US13::US13_0(v3035_0_0) => {
                                                Ok(v3035_0_0.clone())
                                            }
                                            File_system::US13::US13_1(v3035_1_0) => {
                                                let v3050: string = v3035_1_0.clone();
                                                let v3051: string =
                                                    File_system::method19(v3014.clone());
                                                let v3052: Option<string> =
                                                    File_system::method78(v3014.clone());
                                                let v3066: File_system::US1 = defaultValue(
                                                    File_system::US1::US1_1,
                                                    map(File_system::method4(), v3052),
                                                );
                                                if let File_system::US1::US1_0(v3066_0_0) = &v3066 {
                                                    let v3070: string = match &v3066 {
                                                        File_system::US1::US1_0(x) => x.clone(),
                                                        _ => unreachable!(),
                                                    };
                                                    if v3014.clone() != string("") {
                                                        let v3075: Result<
                                                            std::path::PathBuf,
                                                            std::io::Error,
                                                        > = std::fs::read_link(&*v3070.clone());
                                                        let v3076 = File_system::method76();
                                                        let v3087: Result<
                                                            std::path::PathBuf,
                                                            string,
                                                        > = v3075.map_err(|x| v3076(x));
                                                        let v3090: File_system::US13 = match &v3087
                                                        {
                                                            Err(v3087_1_0) => {
                                                                v2978(v3087_1_0.clone())
                                                            }
                                                            Ok(v3087_0_0) => {
                                                                v2977(v3087_0_0.clone())
                                                            }
                                                        };
                                                        let v5493: Result<
                                                            std::path::PathBuf,
                                                            std::io::Error,
                                                        > = match &v3090 {
                                                            File_system::US13::US13_0(
                                                                v3090_0_0,
                                                            ) => Ok(v3090_0_0.clone()),
                                                            File_system::US13::US13_1(
                                                                v3090_1_0,
                                                            ) => {
                                                                let v3105: string =
                                                                    v3090_1_0.clone();
                                                                let v3106: string =
                                                                    File_system::method19(
                                                                        v3070.clone(),
                                                                    );
                                                                let v3107: Option<string> =
                                                                    File_system::method78(
                                                                        v3070.clone(),
                                                                    );
                                                                let v3121: File_system::US1 =
                                                                    defaultValue(
                                                                        File_system::US1::US1_1,
                                                                        map(
                                                                            File_system::method4(),
                                                                            v3107,
                                                                        ),
                                                                    );
                                                                if let File_system::US1::US1_0(
                                                                    v3121_0_0,
                                                                ) = &v3121
                                                                {
                                                                    let v3125: string = match &v3121
                                                                    {
                                                                        File_system::US1::US1_0(
                                                                            x,
                                                                        ) => x.clone(),
                                                                        _ => unreachable!(),
                                                                    };
                                                                    if v3070.clone() != string("") {
                                                                        let v3130: Result<
                                                                            std::path::PathBuf,
                                                                            std::io::Error,
                                                                        > = std::fs::read_link(
                                                                            &*v3125.clone(),
                                                                        );
                                                                        let v3131 =
                                                                            File_system::method76();
                                                                        let v3142: Result<
                                                                            std::path::PathBuf,
                                                                            string,
                                                                        > = v3130
                                                                            .map_err(|x| v3131(x));
                                                                        let v3145:
                                                                                           File_system::US13 =
                                                                                       match &v3142
                                                                                           {
                                                                                           Err(v3142_1_0)
                                                                                           =>
                                                                                           v2978(v3142_1_0.clone()),
                                                                                           Ok(v3142_0_0)
                                                                                           =>
                                                                                           v2977(v3142_0_0.clone()),
                                                                                       };
                                                                        let v5288:
                                                                                           Result<std::path::PathBuf,
                                                                                                  std::io::Error> =
                                                                                       match &v3145
                                                                                           {
                                                                                           File_system::US13::US13_0(v3145_0_0)
                                                                                           =>
                                                                                           Ok(v3145_0_0.clone()),
                                                                                           File_system::US13::US13_1(v3145_1_0)
                                                                                           =>
                                                                                           {
                                                                                               let v3160:
                                                                                                       string =
                                                                                                   v3145_1_0.clone();
                                                                                               let v3161:
                                                                                                       string =
                                                                                                   File_system::method19(v3125.clone());
                                                                                               let v3162:
                                                                                                       Option<string> =
                                                                                                   File_system::method78(v3125.clone());
                                                                                               let v3176:
                                                                                                       File_system::US1 =
                                                                                                   defaultValue(File_system::US1::US1_1,
                                                                                                                map(File_system::method4(),
                                                                                                                    v3162));
                                                                                               if let File_system::US1::US1_0(v3176_0_0)
                                                                                                      =
                                                                                                      &v3176
                                                                                                  {
                                                                                                   let v3180:
                                                                                                           string =
                                                                                                       match &v3176
                                                                                                           {
                                                                                                           File_system::US1::US1_0(x)
                                                                                                           =>
                                                                                                           x.clone(),
                                                                                                           _
                                                                                                           =>
                                                                                                           unreachable!(),
                                                                                                       };
                                                                                                   if v3125.clone()
                                                                                                          !=
                                                                                                          string("")
                                                                                                      {
                                                                                                       let v3185:
                                                                                                               Result<std::path::PathBuf,
                                                                                                                      std::io::Error> =
                                                                                                           std::fs::read_link(&*v3180.clone());
                                                                                                       let v3186 =
                                                                                                           File_system::method76();
                                                                                                       let v3197:
                                                                                                               Result<std::path::PathBuf,
                                                                                                                      string> =
                                                                                                           v3185.map_err(|x| v3186(x));
                                                                                                       let v3200:
                                                                                                               File_system::US13 =
                                                                                                           match &v3197
                                                                                                               {
                                                                                                               Err(v3197_1_0)
                                                                                                               =>
                                                                                                               v2978(v3197_1_0.clone()),
                                                                                                               Ok(v3197_0_0)
                                                                                                               =>
                                                                                                               v2977(v3197_0_0.clone()),
                                                                                                           };
                                                                                                       let v5083:
                                                                                                               Result<std::path::PathBuf,
                                                                                                                      std::io::Error> =
                                                                                                           match &v3200
                                                                                                               {
                                                                                                               File_system::US13::US13_0(v3200_0_0)
                                                                                                               =>
                                                                                                               Ok(v3200_0_0.clone()),
                                                                                                               File_system::US13::US13_1(v3200_1_0)
                                                                                                               =>
                                                                                                               {
                                                                                                                   let v3215:
                                                                                                                           string =
                                                                                                                       v3200_1_0.clone();
                                                                                                                   let v3216:
                                                                                                                           string =
                                                                                                                       File_system::method19(v3180.clone());
                                                                                                                   let v3217:
                                                                                                                           Option<string> =
                                                                                                                       File_system::method78(v3180.clone());
                                                                                                                   let v3231:
                                                                                                                           File_system::US1 =
                                                                                                                       defaultValue(File_system::US1::US1_1,
                                                                                                                                    map(File_system::method4(),
                                                                                                                                        v3217));
                                                                                                                   if let File_system::US1::US1_0(v3231_0_0)
                                                                                                                          =
                                                                                                                          &v3231
                                                                                                                      {
                                                                                                                       let v3235:
                                                                                                                               string =
                                                                                                                           match &v3231
                                                                                                                               {
                                                                                                                               File_system::US1::US1_0(x)
                                                                                                                               =>
                                                                                                                               x.clone(),
                                                                                                                               _
                                                                                                                               =>
                                                                                                                               unreachable!(),
                                                                                                                           };
                                                                                                                       if v3180.clone()
                                                                                                                              !=
                                                                                                                              string("")
                                                                                                                          {
                                                                                                                           let v3240:
                                                                                                                                   Result<std::path::PathBuf,
                                                                                                                                          std::io::Error> =
                                                                                                                               std::fs::read_link(&*v3235.clone());
                                                                                                                           let v3241 =
                                                                                                                               File_system::method76();
                                                                                                                           let v3252:
                                                                                                                                   Result<std::path::PathBuf,
                                                                                                                                          string> =
                                                                                                                               v3240.map_err(|x| v3241(x));
                                                                                                                           let v3255:
                                                                                                                                   File_system::US13 =
                                                                                                                               match &v3252
                                                                                                                                   {
                                                                                                                                   Err(v3252_1_0)
                                                                                                                                   =>
                                                                                                                                   v2978(v3252_1_0.clone()),
                                                                                                                                   Ok(v3252_0_0)
                                                                                                                                   =>
                                                                                                                                   v2977(v3252_0_0.clone()),
                                                                                                                               };
                                                                                                                           let v4878:
                                                                                                                                   Result<std::path::PathBuf,
                                                                                                                                          std::io::Error> =
                                                                                                                               match &v3255
                                                                                                                                   {
                                                                                                                                   File_system::US13::US13_0(v3255_0_0)
                                                                                                                                   =>
                                                                                                                                   Ok(v3255_0_0.clone()),
                                                                                                                                   File_system::US13::US13_1(v3255_1_0)
                                                                                                                                   =>
                                                                                                                                   {
                                                                                                                                       let v3270:
                                                                                                                                               string =
                                                                                                                                           v3255_1_0.clone();
                                                                                                                                       let v3271:
                                                                                                                                               string =
                                                                                                                                           File_system::method19(v3235.clone());
                                                                                                                                       let v3272:
                                                                                                                                               Option<string> =
                                                                                                                                           File_system::method78(v3235.clone());
                                                                                                                                       let v3286:
                                                                                                                                               File_system::US1 =
                                                                                                                                           defaultValue(File_system::US1::US1_1,
                                                                                                                                                        map(File_system::method4(),
                                                                                                                                                            v3272));
                                                                                                                                       if let File_system::US1::US1_0(v3286_0_0)
                                                                                                                                              =
                                                                                                                                              &v3286
                                                                                                                                          {
                                                                                                                                           let v3290:
                                                                                                                                                   string =
                                                                                                                                               match &v3286
                                                                                                                                                   {
                                                                                                                                                   File_system::US1::US1_0(x)
                                                                                                                                                   =>
                                                                                                                                                   x.clone(),
                                                                                                                                                   _
                                                                                                                                                   =>
                                                                                                                                                   unreachable!(),
                                                                                                                                               };
                                                                                                                                           if v3235.clone()
                                                                                                                                                  !=
                                                                                                                                                  string("")
                                                                                                                                              {
                                                                                                                                               let v3295:
                                                                                                                                                       Result<std::path::PathBuf,
                                                                                                                                                              std::io::Error> =
                                                                                                                                                   std::fs::read_link(&*v3290.clone());
                                                                                                                                               let v3296 =
                                                                                                                                                   File_system::method76();
                                                                                                                                               let v3307:
                                                                                                                                                       Result<std::path::PathBuf,
                                                                                                                                                              string> =
                                                                                                                                                   v3295.map_err(|x| v3296(x));
                                                                                                                                               let v3310:
                                                                                                                                                       File_system::US13 =
                                                                                                                                                   match &v3307
                                                                                                                                                       {
                                                                                                                                                       Err(v3307_1_0)
                                                                                                                                                       =>
                                                                                                                                                       v2978(v3307_1_0.clone()),
                                                                                                                                                       Ok(v3307_0_0)
                                                                                                                                                       =>
                                                                                                                                                       v2977(v3307_0_0.clone()),
                                                                                                                                                   };
                                                                                                                                               let v4673:
                                                                                                                                                       Result<std::path::PathBuf,
                                                                                                                                                              std::io::Error> =
                                                                                                                                                   match &v3310
                                                                                                                                                       {
                                                                                                                                                       File_system::US13::US13_0(v3310_0_0)
                                                                                                                                                       =>
                                                                                                                                                       Ok(v3310_0_0.clone()),
                                                                                                                                                       File_system::US13::US13_1(v3310_1_0)
                                                                                                                                                       =>
                                                                                                                                                       {
                                                                                                                                                           let v3325:
                                                                                                                                                                   string =
                                                                                                                                                               v3310_1_0.clone();
                                                                                                                                                           let v3326:
                                                                                                                                                                   string =
                                                                                                                                                               File_system::method19(v3290.clone());
                                                                                                                                                           let v3327:
                                                                                                                                                                   Option<string> =
                                                                                                                                                               File_system::method78(v3290.clone());
                                                                                                                                                           let v3341:
                                                                                                                                                                   File_system::US1 =
                                                                                                                                                               defaultValue(File_system::US1::US1_1,
                                                                                                                                                                            map(File_system::method4(),
                                                                                                                                                                                v3327));
                                                                                                                                                           if let File_system::US1::US1_0(v3341_0_0)
                                                                                                                                                                  =
                                                                                                                                                                  &v3341
                                                                                                                                                              {
                                                                                                                                                               let v3345:
                                                                                                                                                                       string =
                                                                                                                                                                   match &v3341
                                                                                                                                                                       {
                                                                                                                                                                       File_system::US1::US1_0(x)
                                                                                                                                                                       =>
                                                                                                                                                                       x.clone(),
                                                                                                                                                                       _
                                                                                                                                                                       =>
                                                                                                                                                                       unreachable!(),
                                                                                                                                                                   };
                                                                                                                                                               if v3290.clone()
                                                                                                                                                                      !=
                                                                                                                                                                      string("")
                                                                                                                                                                  {
                                                                                                                                                                   let v3350:
                                                                                                                                                                           Result<std::path::PathBuf,
                                                                                                                                                                                  std::io::Error> =
                                                                                                                                                                       std::fs::read_link(&*v3345.clone());
                                                                                                                                                                   let v3351 =
                                                                                                                                                                       File_system::method76();
                                                                                                                                                                   let v3362:
                                                                                                                                                                           Result<std::path::PathBuf,
                                                                                                                                                                                  string> =
                                                                                                                                                                       v3350.map_err(|x| v3351(x));
                                                                                                                                                                   let v3365:
                                                                                                                                                                           File_system::US13 =
                                                                                                                                                                       match &v3362
                                                                                                                                                                           {
                                                                                                                                                                           Err(v3362_1_0)
                                                                                                                                                                           =>
                                                                                                                                                                           v2978(v3362_1_0.clone()),
                                                                                                                                                                           Ok(v3362_0_0)
                                                                                                                                                                           =>
                                                                                                                                                                           v2977(v3362_0_0.clone()),
                                                                                                                                                                       };
                                                                                                                                                                   let v4468:
                                                                                                                                                                           Result<std::path::PathBuf,
                                                                                                                                                                                  std::io::Error> =
                                                                                                                                                                       match &v3365
                                                                                                                                                                           {
                                                                                                                                                                           File_system::US13::US13_0(v3365_0_0)
                                                                                                                                                                           =>
                                                                                                                                                                           Ok(v3365_0_0.clone()),
                                                                                                                                                                           File_system::US13::US13_1(v3365_1_0)
                                                                                                                                                                           =>
                                                                                                                                                                           {
                                                                                                                                                                               let v3380:
                                                                                                                                                                                       string =
                                                                                                                                                                                   v3365_1_0.clone();
                                                                                                                                                                               let v3381:
                                                                                                                                                                                       string =
                                                                                                                                                                                   File_system::method19(v3345.clone());
                                                                                                                                                                               let v3382:
                                                                                                                                                                                       Option<string> =
                                                                                                                                                                                   File_system::method78(v3345.clone());
                                                                                                                                                                               let v3396:
                                                                                                                                                                                       File_system::US1 =
                                                                                                                                                                                   defaultValue(File_system::US1::US1_1,
                                                                                                                                                                                                map(File_system::method4(),
                                                                                                                                                                                                    v3382));
                                                                                                                                                                               if let File_system::US1::US1_0(v3396_0_0)
                                                                                                                                                                                      =
                                                                                                                                                                                      &v3396
                                                                                                                                                                                  {
                                                                                                                                                                                   let v3400:
                                                                                                                                                                                           string =
                                                                                                                                                                                       match &v3396
                                                                                                                                                                                           {
                                                                                                                                                                                           File_system::US1::US1_0(x)
                                                                                                                                                                                           =>
                                                                                                                                                                                           x.clone(),
                                                                                                                                                                                           _
                                                                                                                                                                                           =>
                                                                                                                                                                                           unreachable!(),
                                                                                                                                                                                       };
                                                                                                                                                                                   if v3345.clone()
                                                                                                                                                                                          !=
                                                                                                                                                                                          string("")
                                                                                                                                                                                      {
                                                                                                                                                                                       let v3405:
                                                                                                                                                                                               Result<std::path::PathBuf,
                                                                                                                                                                                                      std::io::Error> =
                                                                                                                                                                                           std::fs::read_link(&*v3400.clone());
                                                                                                                                                                                       let v3406 =
                                                                                                                                                                                           File_system::method76();
                                                                                                                                                                                       let v3417:
                                                                                                                                                                                               Result<std::path::PathBuf,
                                                                                                                                                                                                      string> =
                                                                                                                                                                                           v3405.map_err(|x| v3406(x));
                                                                                                                                                                                       let v3420:
                                                                                                                                                                                               File_system::US13 =
                                                                                                                                                                                           match &v3417
                                                                                                                                                                                               {
                                                                                                                                                                                               Err(v3417_1_0)
                                                                                                                                                                                               =>
                                                                                                                                                                                               v2978(v3417_1_0.clone()),
                                                                                                                                                                                               Ok(v3417_0_0)
                                                                                                                                                                                               =>
                                                                                                                                                                                               v2977(v3417_0_0.clone()),
                                                                                                                                                                                           };
                                                                                                                                                                                       let v4263:
                                                                                                                                                                                               Result<std::path::PathBuf,
                                                                                                                                                                                                      std::io::Error> =
                                                                                                                                                                                           match &v3420
                                                                                                                                                                                               {
                                                                                                                                                                                               File_system::US13::US13_0(v3420_0_0)
                                                                                                                                                                                               =>
                                                                                                                                                                                               Ok(v3420_0_0.clone()),
                                                                                                                                                                                               File_system::US13::US13_1(v3420_1_0)
                                                                                                                                                                                               =>
                                                                                                                                                                                               {
                                                                                                                                                                                                   let v3435:
                                                                                                                                                                                                           string =
                                                                                                                                                                                                       v3420_1_0.clone();
                                                                                                                                                                                                   let v3436:
                                                                                                                                                                                                           string =
                                                                                                                                                                                                       File_system::method19(v3400.clone());
                                                                                                                                                                                                   let v3437:
                                                                                                                                                                                                           Option<string> =
                                                                                                                                                                                                       File_system::method78(v3400.clone());
                                                                                                                                                                                                   let v3451:
                                                                                                                                                                                                           File_system::US1 =
                                                                                                                                                                                                       defaultValue(File_system::US1::US1_1,
                                                                                                                                                                                                                    map(File_system::method4(),
                                                                                                                                                                                                                        v3437));
                                                                                                                                                                                                   if let File_system::US1::US1_0(v3451_0_0)
                                                                                                                                                                                                          =
                                                                                                                                                                                                          &v3451
                                                                                                                                                                                                      {
                                                                                                                                                                                                       let v3455:
                                                                                                                                                                                                               string =
                                                                                                                                                                                                           match &v3451
                                                                                                                                                                                                               {
                                                                                                                                                                                                               File_system::US1::US1_0(x)
                                                                                                                                                                                                               =>
                                                                                                                                                                                                               x.clone(),
                                                                                                                                                                                                               _
                                                                                                                                                                                                               =>
                                                                                                                                                                                                               unreachable!(),
                                                                                                                                                                                                           };
                                                                                                                                                                                                       if v3400.clone()
                                                                                                                                                                                                              !=
                                                                                                                                                                                                              string("")
                                                                                                                                                                                                          {
                                                                                                                                                                                                           let v3460:
                                                                                                                                                                                                                   Result<std::path::PathBuf,
                                                                                                                                                                                                                          std::io::Error> =
                                                                                                                                                                                                               std::fs::read_link(&*v3455.clone());
                                                                                                                                                                                                           let v3461 =
                                                                                                                                                                                                               File_system::method76();
                                                                                                                                                                                                           let v3472:
                                                                                                                                                                                                                   Result<std::path::PathBuf,
                                                                                                                                                                                                                          string> =
                                                                                                                                                                                                               v3460.map_err(|x| v3461(x));
                                                                                                                                                                                                           let v3475:
                                                                                                                                                                                                                   File_system::US13 =
                                                                                                                                                                                                               match &v3472
                                                                                                                                                                                                                   {
                                                                                                                                                                                                                   Err(v3472_1_0)
                                                                                                                                                                                                                   =>
                                                                                                                                                                                                                   v2978(v3472_1_0.clone()),
                                                                                                                                                                                                                   Ok(v3472_0_0)
                                                                                                                                                                                                                   =>
                                                                                                                                                                                                                   v2977(v3472_0_0.clone()),
                                                                                                                                                                                                               };
                                                                                                                                                                                                           let v4058:
                                                                                                                                                                                                                   Result<std::path::PathBuf,
                                                                                                                                                                                                                          std::io::Error> =
                                                                                                                                                                                                               match &v3475
                                                                                                                                                                                                                   {
                                                                                                                                                                                                                   File_system::US13::US13_0(v3475_0_0)
                                                                                                                                                                                                                   =>
                                                                                                                                                                                                                   Ok(v3475_0_0.clone()),
                                                                                                                                                                                                                   File_system::US13::US13_1(v3475_1_0)
                                                                                                                                                                                                                   =>
                                                                                                                                                                                                                   {
                                                                                                                                                                                                                       let v3490:
                                                                                                                                                                                                                               string =
                                                                                                                                                                                                                           v3475_1_0.clone();
                                                                                                                                                                                                                       let v3491:
                                                                                                                                                                                                                               string =
                                                                                                                                                                                                                           File_system::method19(v3455.clone());
                                                                                                                                                                                                                       let v3492:
                                                                                                                                                                                                                               Option<string> =
                                                                                                                                                                                                                           File_system::method78(v3455.clone());
                                                                                                                                                                                                                       let v3506:
                                                                                                                                                                                                                               File_system::US1 =
                                                                                                                                                                                                                           defaultValue(File_system::US1::US1_1,
                                                                                                                                                                                                                                        map(File_system::method4(),
                                                                                                                                                                                                                                            v3492));
                                                                                                                                                                                                                       if let File_system::US1::US1_0(v3506_0_0)
                                                                                                                                                                                                                              =
                                                                                                                                                                                                                              &v3506
                                                                                                                                                                                                                          {
                                                                                                                                                                                                                           let v3510:
                                                                                                                                                                                                                                   string =
                                                                                                                                                                                                                               match &v3506
                                                                                                                                                                                                                                   {
                                                                                                                                                                                                                                   File_system::US1::US1_0(x)
                                                                                                                                                                                                                                   =>
                                                                                                                                                                                                                                   x.clone(),
                                                                                                                                                                                                                                   _
                                                                                                                                                                                                                                   =>
                                                                                                                                                                                                                                   unreachable!(),
                                                                                                                                                                                                                               };
                                                                                                                                                                                                                           if v3455.clone()
                                                                                                                                                                                                                                  !=
                                                                                                                                                                                                                                  string("")
                                                                                                                                                                                                                              {
                                                                                                                                                                                                                               let v3515:
                                                                                                                                                                                                                                       Result<std::path::PathBuf,
                                                                                                                                                                                                                                              std::io::Error> =
                                                                                                                                                                                                                                   std::fs::read_link(&*v3510.clone());
                                                                                                                                                                                                                               let v3516 =
                                                                                                                                                                                                                                   File_system::method76();
                                                                                                                                                                                                                               let v3527:
                                                                                                                                                                                                                                       Result<std::path::PathBuf,
                                                                                                                                                                                                                                              string> =
                                                                                                                                                                                                                                   v3515.map_err(|x| v3516(x));
                                                                                                                                                                                                                               let v3530:
                                                                                                                                                                                                                                       File_system::US13 =
                                                                                                                                                                                                                                   match &v3527
                                                                                                                                                                                                                                       {
                                                                                                                                                                                                                                       Err(v3527_1_0)
                                                                                                                                                                                                                                       =>
                                                                                                                                                                                                                                       v2978(v3527_1_0.clone()),
                                                                                                                                                                                                                                       Ok(v3527_0_0)
                                                                                                                                                                                                                                       =>
                                                                                                                                                                                                                                       v2977(v3527_0_0.clone()),
                                                                                                                                                                                                                                   };
                                                                                                                                                                                                                               let v3853:
                                                                                                                                                                                                                                       Result<std::path::PathBuf,
                                                                                                                                                                                                                                              std::io::Error> =
                                                                                                                                                                                                                                   match &v3530
                                                                                                                                                                                                                                       {
                                                                                                                                                                                                                                       File_system::US13::US13_0(v3530_0_0)
                                                                                                                                                                                                                                       =>
                                                                                                                                                                                                                                       Ok(v3530_0_0.clone()),
                                                                                                                                                                                                                                       File_system::US13::US13_1(v3530_1_0)
                                                                                                                                                                                                                                       =>
                                                                                                                                                                                                                                       {
                                                                                                                                                                                                                                           let v3545:
                                                                                                                                                                                                                                                   string =
                                                                                                                                                                                                                                               v3530_1_0.clone();
                                                                                                                                                                                                                                           let v3546:
                                                                                                                                                                                                                                                   string =
                                                                                                                                                                                                                                               File_system::method19(v3510.clone());
                                                                                                                                                                                                                                           let v3547:
                                                                                                                                                                                                                                                   Option<string> =
                                                                                                                                                                                                                                               File_system::method78(v3510.clone());
                                                                                                                                                                                                                                           let v3561:
                                                                                                                                                                                                                                                   File_system::US1 =
                                                                                                                                                                                                                                               defaultValue(File_system::US1::US1_1,
                                                                                                                                                                                                                                                            map(File_system::method4(),
                                                                                                                                                                                                                                                                v3547));
                                                                                                                                                                                                                                           if let File_system::US1::US1_0(v3561_0_0)
                                                                                                                                                                                                                                                  =
                                                                                                                                                                                                                                                  &v3561
                                                                                                                                                                                                                                              {
                                                                                                                                                                                                                                               let v3565:
                                                                                                                                                                                                                                                       string =
                                                                                                                                                                                                                                                   match &v3561
                                                                                                                                                                                                                                                       {
                                                                                                                                                                                                                                                       File_system::US1::US1_0(x)
                                                                                                                                                                                                                                                       =>
                                                                                                                                                                                                                                                       x.clone(),
                                                                                                                                                                                                                                                       _
                                                                                                                                                                                                                                                       =>
                                                                                                                                                                                                                                                       unreachable!(),
                                                                                                                                                                                                                                                   };
                                                                                                                                                                                                                                               if v3510.clone()
                                                                                                                                                                                                                                                      !=
                                                                                                                                                                                                                                                      string("")
                                                                                                                                                                                                                                                  {
                                                                                                                                                                                                                                                   let v3570:
                                                                                                                                                                                                                                                           Result<std::path::PathBuf,
                                                                                                                                                                                                                                                                  std::io::Error> =
                                                                                                                                                                                                                                                       std::fs::read_link(&*v3565.clone());
                                                                                                                                                                                                                                                   let v3571 =
                                                                                                                                                                                                                                                       File_system::method76();
                                                                                                                                                                                                                                                   let v3582:
                                                                                                                                                                                                                                                           Result<std::path::PathBuf,
                                                                                                                                                                                                                                                                  string> =
                                                                                                                                                                                                                                                       v3570.map_err(|x| v3571(x));
                                                                                                                                                                                                                                                   let v3585:
                                                                                                                                                                                                                                                           File_system::US13 =
                                                                                                                                                                                                                                                       match &v3582
                                                                                                                                                                                                                                                           {
                                                                                                                                                                                                                                                           Err(v3582_1_0)
                                                                                                                                                                                                                                                           =>
                                                                                                                                                                                                                                                           v2978(v3582_1_0.clone()),
                                                                                                                                                                                                                                                           Ok(v3582_0_0)
                                                                                                                                                                                                                                                           =>
                                                                                                                                                                                                                                                           v2977(v3582_0_0.clone()),
                                                                                                                                                                                                                                                       };
                                                                                                                                                                                                                                                   let v3648:
                                                                                                                                                                                                                                                           Result<std::path::PathBuf,
                                                                                                                                                                                                                                                                  std::io::Error> =
                                                                                                                                                                                                                                                       match &v3585
                                                                                                                                                                                                                                                           {
                                                                                                                                                                                                                                                           File_system::US13::US13_0(v3585_0_0)
                                                                                                                                                                                                                                                           =>
                                                                                                                                                                                                                                                           Ok(v3585_0_0.clone()),
                                                                                                                                                                                                                                                           _
                                                                                                                                                                                                                                                           =>
                                                                                                                                                                                                                                                           {
                                                                                                                                                                                                                                                               let v3601:
                                                                                                                                                                                                                                                                       string =
                                                                                                                                                                                                                                                                   File_system::method19(v3565.clone());
                                                                                                                                                                                                                                                               let v3602:
                                                                                                                                                                                                                                                                       Option<string> =
                                                                                                                                                                                                                                                                   File_system::method78(v3565.clone());
                                                                                                                                                                                                                                                               let v3616:
                                                                                                                                                                                                                                                                       File_system::US1 =
                                                                                                                                                                                                                                                                   defaultValue(File_system::US1::US1_1,
                                                                                                                                                                                                                                                                                map(File_system::method4(),
                                                                                                                                                                                                                                                                                    v3602));
                                                                                                                                                                                                                                                               let v3620:
                                                                                                                                                                                                                                                                       string =
                                                                                                                                                                                                                                                                   sprintf!("file_system.read_link / path: {} / n: {} / path\': {} / name: {}",
                                                                                                                                                                                                                                                                            v1_1.clone(),
                                                                                                                                                                                                                                                                            11_u8,
                                                                                                                                                                                                                                                                            v3565.clone(),
                                                                                                                                                                                                                                                                            v3601);
                                                                                                                                                                                                                                                               let v3625:
                                                                                                                                                                                                                                                                       std::io::Error =
                                                                                                                                                                                                                                                                   std::io::Error::new(std::io::ErrorKind::Other, &*v3620);
                                                                                                                                                                                                                                                               Err(v3625)
                                                                                                                                                                                                                                                           }
                                                                                                                                                                                                                                                       };
                                                                                                                                                                                                                                                   let v3649 =
                                                                                                                                                                                                                                                       File_system::method76();
                                                                                                                                                                                                                                                   let v3660:
                                                                                                                                                                                                                                                           Result<std::path::PathBuf,
                                                                                                                                                                                                                                                                  string> =
                                                                                                                                                                                                                                                       v3648.map_err(|x| v3649(x));
                                                                                                                                                                                                                                                   let v3663:
                                                                                                                                                                                                                                                           File_system::US13 =
                                                                                                                                                                                                                                                       match &v3660
                                                                                                                                                                                                                                                           {
                                                                                                                                                                                                                                                           Err(v3660_1_0)
                                                                                                                                                                                                                                                           =>
                                                                                                                                                                                                                                                           v2978(v3660_1_0.clone()),
                                                                                                                                                                                                                                                           Ok(v3660_0_0)
                                                                                                                                                                                                                                                           =>
                                                                                                                                                                                                                                                           v2977(v3660_0_0.clone()),
                                                                                                                                                                                                                                                       };
                                                                                                                                                                                                                                                   match &v3663
                                                                                                                                                                                                                                                       {
                                                                                                                                                                                                                                                       File_system::US13::US13_0(v3663_0_0)
                                                                                                                                                                                                                                                       =>
                                                                                                                                                                                                                                                       {
                                                                                                                                                                                                                                                           let v3689:
                                                                                                                                                                                                                                                                   string =
                                                                                                                                                                                                                                                               File_system::method56(toString(v3663_0_0.clone().display()),
                                                                                                                                                                                                                                                                                     v3546.clone());
                                                                                                                                                                                                                                                           let v3694:
                                                                                                                                                                                                                                                                   &str =
                                                                                                                                                                                                                                                               &*v3689;
                                                                                                                                                                                                                                                           let v3715:
                                                                                                                                                                                                                                                                   std::string::String =
                                                                                                                                                                                                                                                               String::from(v3694);
                                                                                                                                                                                                                                                           let v3736:
                                                                                                                                                                                                                                                                   std::path::PathBuf =
                                                                                                                                                                                                                                                               std::path::PathBuf::from(v3715);
                                                                                                                                                                                                                                                           Ok(v3736)
                                                                                                                                                                                                                                                       }
                                                                                                                                                                                                                                                       File_system::US13::US13_1(v3663_1_0)
                                                                                                                                                                                                                                                       =>
                                                                                                                                                                                                                                                       {
                                                                                                                                                                                                                                                           let v3767:
                                                                                                                                                                                                                                                                   string =
                                                                                                                                                                                                                                                               sprintf!("file_system.read_link / error\': {} / error: {} / name: {}",
                                                                                                                                                                                                                                                                        v3663_1_0.clone(),
                                                                                                                                                                                                                                                                        v3545.clone(),
                                                                                                                                                                                                                                                                        v3546.clone());
                                                                                                                                                                                                                                                           let v3772:
                                                                                                                                                                                                                                                                   std::io::Error =
                                                                                                                                                                                                                                                               std::io::Error::new(std::io::ErrorKind::Other, &*v3767);
                                                                                                                                                                                                                                                           Err(v3772)
                                                                                                                                                                                                                                                       }
                                                                                                                                                                                                                                                   }
                                                                                                                                                                                                                                               } else {
                                                                                                                                                                                                                                                   let v3796:
                                                                                                                                                                                                                                                           string =
                                                                                                                                                                                                                                                       sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                                                                                                                                                                                                                                v1_1.clone(),
                                                                                                                                                                                                                                                                v3545.clone(),
                                                                                                                                                                                                                                                                v3510.clone(),
                                                                                                                                                                                                                                                                v3546.clone());
                                                                                                                                                                                                                                                   let v3801:
                                                                                                                                                                                                                                                           std::io::Error =
                                                                                                                                                                                                                                                       std::io::Error::new(std::io::ErrorKind::Other, &*v3796);
                                                                                                                                                                                                                                                   Err(v3801)
                                                                                                                                                                                                                                               }
                                                                                                                                                                                                                                           } else {
                                                                                                                                                                                                                                               let v3824:
                                                                                                                                                                                                                                                       string =
                                                                                                                                                                                                                                                   sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                                                                                                                                                                                                                            v1_1.clone(),
                                                                                                                                                                                                                                                            v3545,
                                                                                                                                                                                                                                                            v3510.clone(),
                                                                                                                                                                                                                                                            v3546.clone());
                                                                                                                                                                                                                                               let v3829:
                                                                                                                                                                                                                                                       std::io::Error =
                                                                                                                                                                                                                                                   std::io::Error::new(std::io::ErrorKind::Other, &*v3824);
                                                                                                                                                                                                                                               Err(v3829)
                                                                                                                                                                                                                                           }
                                                                                                                                                                                                                                       }
                                                                                                                                                                                                                                   };
                                                                                                                                                                                                                               let v3854 =
                                                                                                                                                                                                                                   File_system::method76();
                                                                                                                                                                                                                               let v3865:
                                                                                                                                                                                                                                       Result<std::path::PathBuf,
                                                                                                                                                                                                                                              string> =
                                                                                                                                                                                                                                   v3853.map_err(|x| v3854(x));
                                                                                                                                                                                                                               let v3868:
                                                                                                                                                                                                                                       File_system::US13 =
                                                                                                                                                                                                                                   match &v3865
                                                                                                                                                                                                                                       {
                                                                                                                                                                                                                                       Err(v3865_1_0)
                                                                                                                                                                                                                                       =>
                                                                                                                                                                                                                                       v2978(v3865_1_0.clone()),
                                                                                                                                                                                                                                       Ok(v3865_0_0)
                                                                                                                                                                                                                                       =>
                                                                                                                                                                                                                                       v2977(v3865_0_0.clone()),
                                                                                                                                                                                                                                   };
                                                                                                                                                                                                                               match &v3868
                                                                                                                                                                                                                                   {
                                                                                                                                                                                                                                   File_system::US13::US13_0(v3868_0_0)
                                                                                                                                                                                                                                   =>
                                                                                                                                                                                                                                   {
                                                                                                                                                                                                                                       let v3894:
                                                                                                                                                                                                                                               string =
                                                                                                                                                                                                                                           File_system::method56(toString(v3868_0_0.clone().display()),
                                                                                                                                                                                                                                                                 v3491.clone());
                                                                                                                                                                                                                                       let v3899:
                                                                                                                                                                                                                                               &str =
                                                                                                                                                                                                                                           &*v3894;
                                                                                                                                                                                                                                       let v3920:
                                                                                                                                                                                                                                               std::string::String =
                                                                                                                                                                                                                                           String::from(v3899);
                                                                                                                                                                                                                                       let v3941:
                                                                                                                                                                                                                                               std::path::PathBuf =
                                                                                                                                                                                                                                           std::path::PathBuf::from(v3920);
                                                                                                                                                                                                                                       Ok(v3941)
                                                                                                                                                                                                                                   }
                                                                                                                                                                                                                                   File_system::US13::US13_1(v3868_1_0)
                                                                                                                                                                                                                                   =>
                                                                                                                                                                                                                                   {
                                                                                                                                                                                                                                       let v3972:
                                                                                                                                                                                                                                               string =
                                                                                                                                                                                                                                           sprintf!("file_system.read_link / error\': {} / error: {} / name: {}",
                                                                                                                                                                                                                                                    v3868_1_0.clone(),
                                                                                                                                                                                                                                                    v3490.clone(),
                                                                                                                                                                                                                                                    v3491.clone());
                                                                                                                                                                                                                                       let v3977:
                                                                                                                                                                                                                                               std::io::Error =
                                                                                                                                                                                                                                           std::io::Error::new(std::io::ErrorKind::Other, &*v3972);
                                                                                                                                                                                                                                       Err(v3977)
                                                                                                                                                                                                                                   }
                                                                                                                                                                                                                               }
                                                                                                                                                                                                                           } else {
                                                                                                                                                                                                                               let v4001:
                                                                                                                                                                                                                                       string =
                                                                                                                                                                                                                                   sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                                                                                                                                                                                                            v1_1.clone(),
                                                                                                                                                                                                                                            v3490.clone(),
                                                                                                                                                                                                                                            v3455.clone(),
                                                                                                                                                                                                                                            v3491.clone());
                                                                                                                                                                                                                               let v4006:
                                                                                                                                                                                                                                       std::io::Error =
                                                                                                                                                                                                                                   std::io::Error::new(std::io::ErrorKind::Other, &*v4001);
                                                                                                                                                                                                                               Err(v4006)
                                                                                                                                                                                                                           }
                                                                                                                                                                                                                       } else {
                                                                                                                                                                                                                           let v4029:
                                                                                                                                                                                                                                   string =
                                                                                                                                                                                                                               sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                                                                                                                                                                                                        v1_1.clone(),
                                                                                                                                                                                                                                        v3490,
                                                                                                                                                                                                                                        v3455.clone(),
                                                                                                                                                                                                                                        v3491.clone());
                                                                                                                                                                                                                           let v4034:
                                                                                                                                                                                                                                   std::io::Error =
                                                                                                                                                                                                                               std::io::Error::new(std::io::ErrorKind::Other, &*v4029);
                                                                                                                                                                                                                           Err(v4034)
                                                                                                                                                                                                                       }
                                                                                                                                                                                                                   }
                                                                                                                                                                                                               };
                                                                                                                                                                                                           let v4059 =
                                                                                                                                                                                                               File_system::method76();
                                                                                                                                                                                                           let v4070:
                                                                                                                                                                                                                   Result<std::path::PathBuf,
                                                                                                                                                                                                                          string> =
                                                                                                                                                                                                               v4058.map_err(|x| v4059(x));
                                                                                                                                                                                                           let v4073:
                                                                                                                                                                                                                   File_system::US13 =
                                                                                                                                                                                                               match &v4070
                                                                                                                                                                                                                   {
                                                                                                                                                                                                                   Err(v4070_1_0)
                                                                                                                                                                                                                   =>
                                                                                                                                                                                                                   v2978(v4070_1_0.clone()),
                                                                                                                                                                                                                   Ok(v4070_0_0)
                                                                                                                                                                                                                   =>
                                                                                                                                                                                                                   v2977(v4070_0_0.clone()),
                                                                                                                                                                                                               };
                                                                                                                                                                                                           match &v4073
                                                                                                                                                                                                               {
                                                                                                                                                                                                               File_system::US13::US13_0(v4073_0_0)
                                                                                                                                                                                                               =>
                                                                                                                                                                                                               {
                                                                                                                                                                                                                   let v4099:
                                                                                                                                                                                                                           string =
                                                                                                                                                                                                                       File_system::method56(toString(v4073_0_0.clone().display()),
                                                                                                                                                                                                                                             v3436.clone());
                                                                                                                                                                                                                   let v4104:
                                                                                                                                                                                                                           &str =
                                                                                                                                                                                                                       &*v4099;
                                                                                                                                                                                                                   let v4125:
                                                                                                                                                                                                                           std::string::String =
                                                                                                                                                                                                                       String::from(v4104);
                                                                                                                                                                                                                   let v4146:
                                                                                                                                                                                                                           std::path::PathBuf =
                                                                                                                                                                                                                       std::path::PathBuf::from(v4125);
                                                                                                                                                                                                                   Ok(v4146)
                                                                                                                                                                                                               }
                                                                                                                                                                                                               File_system::US13::US13_1(v4073_1_0)
                                                                                                                                                                                                               =>
                                                                                                                                                                                                               {
                                                                                                                                                                                                                   let v4177:
                                                                                                                                                                                                                           string =
                                                                                                                                                                                                                       sprintf!("file_system.read_link / error\': {} / error: {} / name: {}",
                                                                                                                                                                                                                                v4073_1_0.clone(),
                                                                                                                                                                                                                                v3435.clone(),
                                                                                                                                                                                                                                v3436.clone());
                                                                                                                                                                                                                   let v4182:
                                                                                                                                                                                                                           std::io::Error =
                                                                                                                                                                                                                       std::io::Error::new(std::io::ErrorKind::Other, &*v4177);
                                                                                                                                                                                                                   Err(v4182)
                                                                                                                                                                                                               }
                                                                                                                                                                                                           }
                                                                                                                                                                                                       } else {
                                                                                                                                                                                                           let v4206:
                                                                                                                                                                                                                   string =
                                                                                                                                                                                                               sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                                                                                                                                                                                        v1_1.clone(),
                                                                                                                                                                                                                        v3435.clone(),
                                                                                                                                                                                                                        v3400.clone(),
                                                                                                                                                                                                                        v3436.clone());
                                                                                                                                                                                                           let v4211:
                                                                                                                                                                                                                   std::io::Error =
                                                                                                                                                                                                               std::io::Error::new(std::io::ErrorKind::Other, &*v4206);
                                                                                                                                                                                                           Err(v4211)
                                                                                                                                                                                                       }
                                                                                                                                                                                                   } else {
                                                                                                                                                                                                       let v4234:
                                                                                                                                                                                                               string =
                                                                                                                                                                                                           sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                                                                                                                                                                                    v1_1.clone(),
                                                                                                                                                                                                                    v3435,
                                                                                                                                                                                                                    v3400.clone(),
                                                                                                                                                                                                                    v3436.clone());
                                                                                                                                                                                                       let v4239:
                                                                                                                                                                                                               std::io::Error =
                                                                                                                                                                                                           std::io::Error::new(std::io::ErrorKind::Other, &*v4234);
                                                                                                                                                                                                       Err(v4239)
                                                                                                                                                                                                   }
                                                                                                                                                                                               }
                                                                                                                                                                                           };
                                                                                                                                                                                       let v4264 =
                                                                                                                                                                                           File_system::method76();
                                                                                                                                                                                       let v4275:
                                                                                                                                                                                               Result<std::path::PathBuf,
                                                                                                                                                                                                      string> =
                                                                                                                                                                                           v4263.map_err(|x| v4264(x));
                                                                                                                                                                                       let v4278:
                                                                                                                                                                                               File_system::US13 =
                                                                                                                                                                                           match &v4275
                                                                                                                                                                                               {
                                                                                                                                                                                               Err(v4275_1_0)
                                                                                                                                                                                               =>
                                                                                                                                                                                               v2978(v4275_1_0.clone()),
                                                                                                                                                                                               Ok(v4275_0_0)
                                                                                                                                                                                               =>
                                                                                                                                                                                               v2977(v4275_0_0.clone()),
                                                                                                                                                                                           };
                                                                                                                                                                                       match &v4278
                                                                                                                                                                                           {
                                                                                                                                                                                           File_system::US13::US13_0(v4278_0_0)
                                                                                                                                                                                           =>
                                                                                                                                                                                           {
                                                                                                                                                                                               let v4304:
                                                                                                                                                                                                       string =
                                                                                                                                                                                                   File_system::method56(toString(v4278_0_0.clone().display()),
                                                                                                                                                                                                                         v3381.clone());
                                                                                                                                                                                               let v4309:
                                                                                                                                                                                                       &str =
                                                                                                                                                                                                   &*v4304;
                                                                                                                                                                                               let v4330:
                                                                                                                                                                                                       std::string::String =
                                                                                                                                                                                                   String::from(v4309);
                                                                                                                                                                                               let v4351:
                                                                                                                                                                                                       std::path::PathBuf =
                                                                                                                                                                                                   std::path::PathBuf::from(v4330);
                                                                                                                                                                                               Ok(v4351)
                                                                                                                                                                                           }
                                                                                                                                                                                           File_system::US13::US13_1(v4278_1_0)
                                                                                                                                                                                           =>
                                                                                                                                                                                           {
                                                                                                                                                                                               let v4382:
                                                                                                                                                                                                       string =
                                                                                                                                                                                                   sprintf!("file_system.read_link / error\': {} / error: {} / name: {}",
                                                                                                                                                                                                            v4278_1_0.clone(),
                                                                                                                                                                                                            v3380.clone(),
                                                                                                                                                                                                            v3381.clone());
                                                                                                                                                                                               let v4387:
                                                                                                                                                                                                       std::io::Error =
                                                                                                                                                                                                   std::io::Error::new(std::io::ErrorKind::Other, &*v4382);
                                                                                                                                                                                               Err(v4387)
                                                                                                                                                                                           }
                                                                                                                                                                                       }
                                                                                                                                                                                   } else {
                                                                                                                                                                                       let v4411:
                                                                                                                                                                                               string =
                                                                                                                                                                                           sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                                                                                                                                                                    v1_1.clone(),
                                                                                                                                                                                                    v3380.clone(),
                                                                                                                                                                                                    v3345.clone(),
                                                                                                                                                                                                    v3381.clone());
                                                                                                                                                                                       let v4416:
                                                                                                                                                                                               std::io::Error =
                                                                                                                                                                                           std::io::Error::new(std::io::ErrorKind::Other, &*v4411);
                                                                                                                                                                                       Err(v4416)
                                                                                                                                                                                   }
                                                                                                                                                                               } else {
                                                                                                                                                                                   let v4439:
                                                                                                                                                                                           string =
                                                                                                                                                                                       sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                                                                                                                                                                v1_1.clone(),
                                                                                                                                                                                                v3380,
                                                                                                                                                                                                v3345.clone(),
                                                                                                                                                                                                v3381.clone());
                                                                                                                                                                                   let v4444:
                                                                                                                                                                                           std::io::Error =
                                                                                                                                                                                       std::io::Error::new(std::io::ErrorKind::Other, &*v4439);
                                                                                                                                                                                   Err(v4444)
                                                                                                                                                                               }
                                                                                                                                                                           }
                                                                                                                                                                       };
                                                                                                                                                                   let v4469 =
                                                                                                                                                                       File_system::method76();
                                                                                                                                                                   let v4480:
                                                                                                                                                                           Result<std::path::PathBuf,
                                                                                                                                                                                  string> =
                                                                                                                                                                       v4468.map_err(|x| v4469(x));
                                                                                                                                                                   let v4483:
                                                                                                                                                                           File_system::US13 =
                                                                                                                                                                       match &v4480
                                                                                                                                                                           {
                                                                                                                                                                           Err(v4480_1_0)
                                                                                                                                                                           =>
                                                                                                                                                                           v2978(v4480_1_0.clone()),
                                                                                                                                                                           Ok(v4480_0_0)
                                                                                                                                                                           =>
                                                                                                                                                                           v2977(v4480_0_0.clone()),
                                                                                                                                                                       };
                                                                                                                                                                   match &v4483
                                                                                                                                                                       {
                                                                                                                                                                       File_system::US13::US13_0(v4483_0_0)
                                                                                                                                                                       =>
                                                                                                                                                                       {
                                                                                                                                                                           let v4509:
                                                                                                                                                                                   string =
                                                                                                                                                                               File_system::method56(toString(v4483_0_0.clone().display()),
                                                                                                                                                                                                     v3326.clone());
                                                                                                                                                                           let v4514:
                                                                                                                                                                                   &str =
                                                                                                                                                                               &*v4509;
                                                                                                                                                                           let v4535:
                                                                                                                                                                                   std::string::String =
                                                                                                                                                                               String::from(v4514);
                                                                                                                                                                           let v4556:
                                                                                                                                                                                   std::path::PathBuf =
                                                                                                                                                                               std::path::PathBuf::from(v4535);
                                                                                                                                                                           Ok(v4556)
                                                                                                                                                                       }
                                                                                                                                                                       File_system::US13::US13_1(v4483_1_0)
                                                                                                                                                                       =>
                                                                                                                                                                       {
                                                                                                                                                                           let v4587:
                                                                                                                                                                                   string =
                                                                                                                                                                               sprintf!("file_system.read_link / error\': {} / error: {} / name: {}",
                                                                                                                                                                                        v4483_1_0.clone(),
                                                                                                                                                                                        v3325.clone(),
                                                                                                                                                                                        v3326.clone());
                                                                                                                                                                           let v4592:
                                                                                                                                                                                   std::io::Error =
                                                                                                                                                                               std::io::Error::new(std::io::ErrorKind::Other, &*v4587);
                                                                                                                                                                           Err(v4592)
                                                                                                                                                                       }
                                                                                                                                                                   }
                                                                                                                                                               } else {
                                                                                                                                                                   let v4616:
                                                                                                                                                                           string =
                                                                                                                                                                       sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                                                                                                                                                v1_1.clone(),
                                                                                                                                                                                v3325.clone(),
                                                                                                                                                                                v3290.clone(),
                                                                                                                                                                                v3326.clone());
                                                                                                                                                                   let v4621:
                                                                                                                                                                           std::io::Error =
                                                                                                                                                                       std::io::Error::new(std::io::ErrorKind::Other, &*v4616);
                                                                                                                                                                   Err(v4621)
                                                                                                                                                               }
                                                                                                                                                           } else {
                                                                                                                                                               let v4644:
                                                                                                                                                                       string =
                                                                                                                                                                   sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                                                                                                                                            v1_1.clone(),
                                                                                                                                                                            v3325,
                                                                                                                                                                            v3290.clone(),
                                                                                                                                                                            v3326.clone());
                                                                                                                                                               let v4649:
                                                                                                                                                                       std::io::Error =
                                                                                                                                                                   std::io::Error::new(std::io::ErrorKind::Other, &*v4644);
                                                                                                                                                               Err(v4649)
                                                                                                                                                           }
                                                                                                                                                       }
                                                                                                                                                   };
                                                                                                                                               let v4674 =
                                                                                                                                                   File_system::method76();
                                                                                                                                               let v4685:
                                                                                                                                                       Result<std::path::PathBuf,
                                                                                                                                                              string> =
                                                                                                                                                   v4673.map_err(|x| v4674(x));
                                                                                                                                               let v4688:
                                                                                                                                                       File_system::US13 =
                                                                                                                                                   match &v4685
                                                                                                                                                       {
                                                                                                                                                       Err(v4685_1_0)
                                                                                                                                                       =>
                                                                                                                                                       v2978(v4685_1_0.clone()),
                                                                                                                                                       Ok(v4685_0_0)
                                                                                                                                                       =>
                                                                                                                                                       v2977(v4685_0_0.clone()),
                                                                                                                                                   };
                                                                                                                                               match &v4688
                                                                                                                                                   {
                                                                                                                                                   File_system::US13::US13_0(v4688_0_0)
                                                                                                                                                   =>
                                                                                                                                                   {
                                                                                                                                                       let v4714:
                                                                                                                                                               string =
                                                                                                                                                           File_system::method56(toString(v4688_0_0.clone().display()),
                                                                                                                                                                                 v3271.clone());
                                                                                                                                                       let v4719:
                                                                                                                                                               &str =
                                                                                                                                                           &*v4714;
                                                                                                                                                       let v4740:
                                                                                                                                                               std::string::String =
                                                                                                                                                           String::from(v4719);
                                                                                                                                                       let v4761:
                                                                                                                                                               std::path::PathBuf =
                                                                                                                                                           std::path::PathBuf::from(v4740);
                                                                                                                                                       Ok(v4761)
                                                                                                                                                   }
                                                                                                                                                   File_system::US13::US13_1(v4688_1_0)
                                                                                                                                                   =>
                                                                                                                                                   {
                                                                                                                                                       let v4792:
                                                                                                                                                               string =
                                                                                                                                                           sprintf!("file_system.read_link / error\': {} / error: {} / name: {}",
                                                                                                                                                                    v4688_1_0.clone(),
                                                                                                                                                                    v3270.clone(),
                                                                                                                                                                    v3271.clone());
                                                                                                                                                       let v4797:
                                                                                                                                                               std::io::Error =
                                                                                                                                                           std::io::Error::new(std::io::ErrorKind::Other, &*v4792);
                                                                                                                                                       Err(v4797)
                                                                                                                                                   }
                                                                                                                                               }
                                                                                                                                           } else {
                                                                                                                                               let v4821:
                                                                                                                                                       string =
                                                                                                                                                   sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                                                                                                                            v1_1.clone(),
                                                                                                                                                            v3270.clone(),
                                                                                                                                                            v3235.clone(),
                                                                                                                                                            v3271.clone());
                                                                                                                                               let v4826:
                                                                                                                                                       std::io::Error =
                                                                                                                                                   std::io::Error::new(std::io::ErrorKind::Other, &*v4821);
                                                                                                                                               Err(v4826)
                                                                                                                                           }
                                                                                                                                       } else {
                                                                                                                                           let v4849:
                                                                                                                                                   string =
                                                                                                                                               sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                                                                                                                        v1_1.clone(),
                                                                                                                                                        v3270,
                                                                                                                                                        v3235.clone(),
                                                                                                                                                        v3271.clone());
                                                                                                                                           let v4854:
                                                                                                                                                   std::io::Error =
                                                                                                                                               std::io::Error::new(std::io::ErrorKind::Other, &*v4849);
                                                                                                                                           Err(v4854)
                                                                                                                                       }
                                                                                                                                   }
                                                                                                                               };
                                                                                                                           let v4879 =
                                                                                                                               File_system::method76();
                                                                                                                           let v4890:
                                                                                                                                   Result<std::path::PathBuf,
                                                                                                                                          string> =
                                                                                                                               v4878.map_err(|x| v4879(x));
                                                                                                                           let v4893:
                                                                                                                                   File_system::US13 =
                                                                                                                               match &v4890
                                                                                                                                   {
                                                                                                                                   Err(v4890_1_0)
                                                                                                                                   =>
                                                                                                                                   v2978(v4890_1_0.clone()),
                                                                                                                                   Ok(v4890_0_0)
                                                                                                                                   =>
                                                                                                                                   v2977(v4890_0_0.clone()),
                                                                                                                               };
                                                                                                                           match &v4893
                                                                                                                               {
                                                                                                                               File_system::US13::US13_0(v4893_0_0)
                                                                                                                               =>
                                                                                                                               {
                                                                                                                                   let v4919:
                                                                                                                                           string =
                                                                                                                                       File_system::method56(toString(v4893_0_0.clone().display()),
                                                                                                                                                             v3216.clone());
                                                                                                                                   let v4924:
                                                                                                                                           &str =
                                                                                                                                       &*v4919;
                                                                                                                                   let v4945:
                                                                                                                                           std::string::String =
                                                                                                                                       String::from(v4924);
                                                                                                                                   let v4966:
                                                                                                                                           std::path::PathBuf =
                                                                                                                                       std::path::PathBuf::from(v4945);
                                                                                                                                   Ok(v4966)
                                                                                                                               }
                                                                                                                               File_system::US13::US13_1(v4893_1_0)
                                                                                                                               =>
                                                                                                                               {
                                                                                                                                   let v4997:
                                                                                                                                           string =
                                                                                                                                       sprintf!("file_system.read_link / error\': {} / error: {} / name: {}",
                                                                                                                                                v4893_1_0.clone(),
                                                                                                                                                v3215.clone(),
                                                                                                                                                v3216.clone());
                                                                                                                                   let v5002:
                                                                                                                                           std::io::Error =
                                                                                                                                       std::io::Error::new(std::io::ErrorKind::Other, &*v4997);
                                                                                                                                   Err(v5002)
                                                                                                                               }
                                                                                                                           }
                                                                                                                       } else {
                                                                                                                           let v5026:
                                                                                                                                   string =
                                                                                                                               sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                                                                                                        v1_1.clone(),
                                                                                                                                        v3215.clone(),
                                                                                                                                        v3180.clone(),
                                                                                                                                        v3216.clone());
                                                                                                                           let v5031:
                                                                                                                                   std::io::Error =
                                                                                                                               std::io::Error::new(std::io::ErrorKind::Other, &*v5026);
                                                                                                                           Err(v5031)
                                                                                                                       }
                                                                                                                   } else {
                                                                                                                       let v5054:
                                                                                                                               string =
                                                                                                                           sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                                                                                                    v1_1.clone(),
                                                                                                                                    v3215,
                                                                                                                                    v3180.clone(),
                                                                                                                                    v3216.clone());
                                                                                                                       let v5059:
                                                                                                                               std::io::Error =
                                                                                                                           std::io::Error::new(std::io::ErrorKind::Other, &*v5054);
                                                                                                                       Err(v5059)
                                                                                                                   }
                                                                                                               }
                                                                                                           };
                                                                                                       let v5084 =
                                                                                                           File_system::method76();
                                                                                                       let v5095:
                                                                                                               Result<std::path::PathBuf,
                                                                                                                      string> =
                                                                                                           v5083.map_err(|x| v5084(x));
                                                                                                       let v5098:
                                                                                                               File_system::US13 =
                                                                                                           match &v5095
                                                                                                               {
                                                                                                               Err(v5095_1_0)
                                                                                                               =>
                                                                                                               v2978(v5095_1_0.clone()),
                                                                                                               Ok(v5095_0_0)
                                                                                                               =>
                                                                                                               v2977(v5095_0_0.clone()),
                                                                                                           };
                                                                                                       match &v5098
                                                                                                           {
                                                                                                           File_system::US13::US13_0(v5098_0_0)
                                                                                                           =>
                                                                                                           {
                                                                                                               let v5124:
                                                                                                                       string =
                                                                                                                   File_system::method56(toString(v5098_0_0.clone().display()),
                                                                                                                                         v3161.clone());
                                                                                                               let v5129:
                                                                                                                       &str =
                                                                                                                   &*v5124;
                                                                                                               let v5150:
                                                                                                                       std::string::String =
                                                                                                                   String::from(v5129);
                                                                                                               let v5171:
                                                                                                                       std::path::PathBuf =
                                                                                                                   std::path::PathBuf::from(v5150);
                                                                                                               Ok(v5171)
                                                                                                           }
                                                                                                           File_system::US13::US13_1(v5098_1_0)
                                                                                                           =>
                                                                                                           {
                                                                                                               let v5202:
                                                                                                                       string =
                                                                                                                   sprintf!("file_system.read_link / error\': {} / error: {} / name: {}",
                                                                                                                            v5098_1_0.clone(),
                                                                                                                            v3160.clone(),
                                                                                                                            v3161.clone());
                                                                                                               let v5207:
                                                                                                                       std::io::Error =
                                                                                                                   std::io::Error::new(std::io::ErrorKind::Other, &*v5202);
                                                                                                               Err(v5207)
                                                                                                           }
                                                                                                       }
                                                                                                   } else {
                                                                                                       let v5231:
                                                                                                               string =
                                                                                                           sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                                                                                    v1_1.clone(),
                                                                                                                    v3160.clone(),
                                                                                                                    v3125.clone(),
                                                                                                                    v3161.clone());
                                                                                                       let v5236:
                                                                                                               std::io::Error =
                                                                                                           std::io::Error::new(std::io::ErrorKind::Other, &*v5231);
                                                                                                       Err(v5236)
                                                                                                   }
                                                                                               } else {
                                                                                                   let v5259:
                                                                                                           string =
                                                                                                       sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                                                                                v1_1.clone(),
                                                                                                                v3160,
                                                                                                                v3125.clone(),
                                                                                                                v3161.clone());
                                                                                                   let v5264:
                                                                                                           std::io::Error =
                                                                                                       std::io::Error::new(std::io::ErrorKind::Other, &*v5259);
                                                                                                   Err(v5264)
                                                                                               }
                                                                                           }
                                                                                       };
                                                                        let v5289 =
                                                                            File_system::method76();
                                                                        let v5300: Result<
                                                                            std::path::PathBuf,
                                                                            string,
                                                                        > = v5288
                                                                            .map_err(|x| v5289(x));
                                                                        let v5303:
                                                                                           File_system::US13 =
                                                                                       match &v5300
                                                                                           {
                                                                                           Err(v5300_1_0)
                                                                                           =>
                                                                                           v2978(v5300_1_0.clone()),
                                                                                           Ok(v5300_0_0)
                                                                                           =>
                                                                                           v2977(v5300_0_0.clone()),
                                                                                       };
                                                                        match &v5303
                                                                                       {
                                                                                       File_system::US13::US13_0(v5303_0_0)
                                                                                       =>
                                                                                       {
                                                                                           let v5329:
                                                                                                   string =
                                                                                               File_system::method56(toString(v5303_0_0.clone().display()),
                                                                                                                     v3106.clone());
                                                                                           let v5334:
                                                                                                   &str =
                                                                                               &*v5329;
                                                                                           let v5355:
                                                                                                   std::string::String =
                                                                                               String::from(v5334);
                                                                                           let v5376:
                                                                                                   std::path::PathBuf =
                                                                                               std::path::PathBuf::from(v5355);
                                                                                           Ok(v5376)
                                                                                       }
                                                                                       File_system::US13::US13_1(v5303_1_0)
                                                                                       =>
                                                                                       {
                                                                                           let v5407:
                                                                                                   string =
                                                                                               sprintf!("file_system.read_link / error\': {} / error: {} / name: {}",
                                                                                                        v5303_1_0.clone(),
                                                                                                        v3105.clone(),
                                                                                                        v3106.clone());
                                                                                           let v5412:
                                                                                                   std::io::Error =
                                                                                               std::io::Error::new(std::io::ErrorKind::Other, &*v5407);
                                                                                           Err(v5412)
                                                                                       }
                                                                                   }
                                                                    } else {
                                                                        let v5436:
                                                                                           string =
                                                                                       sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                                                                v1_1.clone(),
                                                                                                v3105.clone(),
                                                                                                v3070.clone(),
                                                                                                v3106.clone());
                                                                        let v5441:
                                                                                           std::io::Error =
                                                                                       std::io::Error::new(std::io::ErrorKind::Other, &*v5436);
                                                                        Err(v5441)
                                                                    }
                                                                } else {
                                                                    let v5464:
                                                                                       string =
                                                                                   sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                                                            v1_1.clone(),
                                                                                            v3105,
                                                                                            v3070.clone(),
                                                                                            v3106.clone());
                                                                    let v5469:
                                                                                       std::io::Error =
                                                                                   std::io::Error::new(std::io::ErrorKind::Other, &*v5464);
                                                                    Err(v5469)
                                                                }
                                                            }
                                                        };
                                                        let v5494 = File_system::method76();
                                                        let v5505: Result<
                                                            std::path::PathBuf,
                                                            string,
                                                        > = v5493.map_err(|x| v5494(x));
                                                        let v5508: File_system::US13 = match &v5505
                                                        {
                                                            Err(v5505_1_0) => {
                                                                v2978(v5505_1_0.clone())
                                                            }
                                                            Ok(v5505_0_0) => {
                                                                v2977(v5505_0_0.clone())
                                                            }
                                                        };
                                                        match &v5508 {
                                                            File_system::US13::US13_0(
                                                                v5508_0_0,
                                                            ) => {
                                                                let v5534: string =
                                                                    File_system::method56(
                                                                        toString(
                                                                            v5508_0_0
                                                                                .clone()
                                                                                .display(),
                                                                        ),
                                                                        v3051.clone(),
                                                                    );
                                                                let v5539: &str = &*v5534;
                                                                let v5560: std::string::String =
                                                                    String::from(v5539);
                                                                let v5581: std::path::PathBuf =
                                                                    std::path::PathBuf::from(v5560);
                                                                Ok(v5581)
                                                            }
                                                            File_system::US13::US13_1(
                                                                v5508_1_0,
                                                            ) => {
                                                                let v5612:
                                                                               string =
                                                                           sprintf!("file_system.read_link / error\': {} / error: {} / name: {}",
                                                                                    v5508_1_0.clone(),
                                                                                    v3050.clone(),
                                                                                    v3051.clone());
                                                                let v5617: std::io::Error =
                                                                    std::io::Error::new(
                                                                        std::io::ErrorKind::Other,
                                                                        &*v5612,
                                                                    );
                                                                Err(v5617)
                                                            }
                                                        }
                                                    } else {
                                                        let v5641:
                                                                       string =
                                                                   sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                                            v1_1.clone(),
                                                                            v3050.clone(),
                                                                            v3014.clone(),
                                                                            v3051.clone());
                                                        let v5646: std::io::Error =
                                                            std::io::Error::new(
                                                                std::io::ErrorKind::Other,
                                                                &*v5641,
                                                            );
                                                        Err(v5646)
                                                    }
                                                } else {
                                                    let v5669: string =
                                                               sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                                        v1_1.clone(),
                                                                        v3050,
                                                                        v3014.clone(),
                                                                        v3051.clone());
                                                    let v5674: std::io::Error = std::io::Error::new(
                                                        std::io::ErrorKind::Other,
                                                        &*v5669,
                                                    );
                                                    Err(v5674)
                                                }
                                            }
                                        };
                                    let v5699 = File_system::method76();
                                    let v5710: Result<std::path::PathBuf, string> =
                                        v5698.map_err(|x| v5699(x));
                                    let v5713: File_system::US13 = match &v5710 {
                                        Err(v5710_1_0) => v2978(v5710_1_0.clone()),
                                        Ok(v5710_0_0) => v2977(v5710_0_0.clone()),
                                    };
                                    match &v5713 {
                                        File_system::US13::US13_0(v5713_0_0) => {
                                            let v5739: string = File_system::method56(
                                                toString(v5713_0_0.clone().display()),
                                                v2995.clone(),
                                            );
                                            let v5744: &str = &*v5739;
                                            let v5765: std::string::String = String::from(v5744);
                                            let v5786: std::path::PathBuf =
                                                std::path::PathBuf::from(v5765);
                                            Ok(v5786)
                                        }
                                        File_system::US13::US13_1(v5713_1_0) => {
                                            let v5817: string =
                                                       sprintf!("file_system.read_link / error\': {} / error: {} / name: {}",
                                                                v5713_1_0.clone(),
                                                                v2994.clone(),
                                                                v2995.clone());
                                            let v5822: std::io::Error = std::io::Error::new(
                                                std::io::ErrorKind::Other,
                                                &*v5817,
                                            );
                                            Err(v5822)
                                        }
                                    }
                                } else {
                                    let v5846: string =
                                               sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                        v1_1.clone(),
                                                        v2994.clone(),
                                                        v1_1.clone(),
                                                        v2995.clone());
                                    let v5851: std::io::Error =
                                        std::io::Error::new(std::io::ErrorKind::Other, &*v5846);
                                    Err(v5851)
                                }
                            } else {
                                let v5874: string =
                                           sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                    v1_1.clone(), v2994,
                                                    v1_1.clone(),
                                                    v2995.clone());
                                let v5879: std::io::Error =
                                    std::io::Error::new(std::io::ErrorKind::Other, &*v5874);
                                Err(v5879)
                            }
                        }
                    }
                };
                v5904.is_err()
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
        File_system::method90(v0_1, v1_1);
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
