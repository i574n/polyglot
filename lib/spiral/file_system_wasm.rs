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
        let v295: File_system::US3 = _v1.1.clone();
        let v294: File_system::US2 = _v1.0.clone();
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
    pub fn closure5(unitVar: (), v0_1: i64) -> File_system::US3 {
        File_system::US3::US3_0(v0_1)
    }
    pub fn method11() -> Func1<i64, File_system::US3> {
        Func1::new(move |v: i64| File_system::closure5((), v))
    }
    pub fn method12() -> string {
        string("hh:mm:ss")
    }
    pub fn method13() -> string {
        string("HH:mm:ss")
    }
    pub fn method10(
        v0_1: LrcPtr<File_system::Mut0>,
        v1_1: LrcPtr<File_system::Mut1>,
        v2_1: LrcPtr<File_system::Mut2>,
        v3: LrcPtr<File_system::Mut3>,
        v4: LrcPtr<File_system::Mut4>,
        v5: Option<i64>,
    ) -> string {
        let v81: File_system::US3 =
            defaultValue(File_system::US3::US3_1, map(File_system::method11(), v5));
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
        let provider: string = File_system::method12();
        v121.toString(provider)
    }
    pub fn method15() -> string {
        string("\u{001b}[0m")
    }
    pub fn method14() -> string {
        let v5: string = padLeft(toLower(string("Debug")), 7_i32, ' ');
        let v31_1: &str = inline_colorization::color_bright_blue;
        let v33_1: &str = &*v5;
        let v35_1: &str = inline_colorization::color_reset;
        let v37: std::string::String = format!("{}{}{}", v31_1, v33_1, v35_1);
        fable_library_rust::String_::fromString(v37)
    }
    pub fn method16(v0_1: string) -> string {
        panic!(
            "{}",
            sprintf!(
                "file_system.get_file_name / target: {} / path: {}",
                File_system::US5::US5_2(File_system::US4::US4_1),
                v0_1
            ),
        )
    }
    pub fn method18() -> string {
        string("")
    }
    pub fn closure6(v0_1: LrcPtr<File_system::Mut3>, v1_1: string, unitVar: ()) {
        let v3: string = append(v0_1.l0.get().clone(), v1_1);
        v0_1.l0.set(v3);
        ()
    }
    pub fn method17(v0_1: string, v1_1: string) -> string {
        let v3: LrcPtr<File_system::Mut3> = LrcPtr::new(File_system::Mut3 {
            l0: MutCell::new(File_system::method18()),
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
    pub fn method19(v0_1: string, v1_1: string, v2_1: i64, v3: string) -> string {
        trimEndChars(
            trimStartChars(
                sprintf!(
                    "{} {} #{} {} / {}",
                    v0_1,
                    v1_1,
                    v2_1,
                    string("file_system.delete_directory_async"),
                    v3
                ),
                toArray(empty::<char>()),
            ),
            toArray(ofArray(new_array(&[' ', '/']))),
        )
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
    pub fn method20(
        v0_1: string,
        v1_1: LrcPtr<File_system::Mut0>,
        v2_1: LrcPtr<File_system::Mut1>,
        v3: LrcPtr<File_system::Mut2>,
        v4: LrcPtr<File_system::Mut3>,
        v5: LrcPtr<File_system::Mut4>,
        v6: Option<i64>,
    ) {
        let v9: () = {
            File_system::closure7(v1_1, ());
            ()
        };
        println!("{}", v0_1.clone());
        ();
        (v2_1.l0.get().clone())(v0_1)
    }
    pub fn closure4(v0_1: string, v1_1: string, unitVar: ()) {
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
            LrcPtr<File_system::Mut4>,
            Option<i64>,
        ) = getValue(File_system::TraceState::trace_state().get().clone());
        let v36: File_system::US0 = (patternInput.4.clone()).l0.get().clone();
        if if (patternInput.2.clone()).l0.get().clone() == false {
            false
        } else {
            1_i32
                >= find(
                    v36,
                    ofSeq(ofList(ofArray(new_array(&[
                        LrcPtr::new((File_system::US0::US0_0, 0_i32)),
                        LrcPtr::new((File_system::US0::US0_1, 1_i32)),
                        LrcPtr::new((File_system::US0::US0_2, 2_i32)),
                        LrcPtr::new((File_system::US0::US0_3, 3_i32)),
                        LrcPtr::new((File_system::US0::US0_4, 4_i32)),
                    ])))),
                )
        } {
            let v43: () = {
                v3();
                ()
            };
            let patternInput_1: (
                LrcPtr<File_system::Mut0>,
                LrcPtr<File_system::Mut1>,
                LrcPtr<File_system::Mut2>,
                LrcPtr<File_system::Mut3>,
                LrcPtr<File_system::Mut4>,
                Option<i64>,
            ) = getValue(File_system::TraceState::trace_state().get().clone());
            let v57: LrcPtr<File_system::Mut0> = patternInput_1.0.clone();
            let v80: string = File_system::method19(
                File_system::method10(
                    v57.clone(),
                    patternInput_1.1.clone(),
                    patternInput_1.2.clone(),
                    patternInput_1.3.clone(),
                    patternInput_1.4.clone(),
                    patternInput_1.5.clone(),
                ),
                File_system::method14(),
                v57.l0.get().clone(),
                File_system::method17(v1_1, File_system::method16(v0_1)),
            );
            let v82: () = {
                v3();
                ()
            };
            let patternInput_2: (
                LrcPtr<File_system::Mut0>,
                LrcPtr<File_system::Mut1>,
                LrcPtr<File_system::Mut2>,
                LrcPtr<File_system::Mut3>,
                LrcPtr<File_system::Mut4>,
                Option<i64>,
            ) = getValue(File_system::TraceState::trace_state().get().clone());
            File_system::method20(
                v80,
                patternInput_2.0.clone(),
                patternInput_2.1.clone(),
                patternInput_2.2.clone(),
                patternInput_2.3.clone(),
                patternInput_2.4.clone(),
                patternInput_2.5.clone(),
            )
        }
    }
    pub fn method6(v0_1: string, v1_1: i64) -> Arc<Async<i64>> {
        defaultOf()
    }
    pub fn closure3(unitVar: (), v0_1: string) -> Arc<Async<i64>> {
        defaultOf()
    }
    pub fn method22(v0_1: string, v1_1: i64, v2_1: string) -> string {
        let v4: LrcPtr<File_system::Mut3> = LrcPtr::new(File_system::Mut3 {
            l0: MutCell::new(File_system::method18()),
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
    pub fn method23(v0_1: string, v1_1: string, v2_1: i64, v3: string) -> string {
        trimEndChars(
            trimStartChars(
                sprintf!(
                    "{} {} #{} {} / {}",
                    v0_1,
                    v1_1,
                    v2_1,
                    string("file_system.wait_for_file_access"),
                    v3
                ),
                toArray(empty::<char>()),
            ),
            toArray(ofArray(new_array(&[' ', '/']))),
        )
    }
    pub fn closure12(v0_1: string, v1_1: i64, v2_1: string, unitVar: ()) {
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
            LrcPtr<File_system::Mut4>,
            Option<i64>,
        ) = getValue(File_system::TraceState::trace_state().get().clone());
        let v37: File_system::US0 = (patternInput.4.clone()).l0.get().clone();
        if if (patternInput.2.clone()).l0.get().clone() == false {
            false
        } else {
            1_i32
                >= find(
                    v37,
                    ofSeq(ofList(ofArray(new_array(&[
                        LrcPtr::new((File_system::US0::US0_0, 0_i32)),
                        LrcPtr::new((File_system::US0::US0_1, 1_i32)),
                        LrcPtr::new((File_system::US0::US0_2, 2_i32)),
                        LrcPtr::new((File_system::US0::US0_3, 3_i32)),
                        LrcPtr::new((File_system::US0::US0_4, 4_i32)),
                    ])))),
                )
        } {
            let v44: () = {
                v4();
                ()
            };
            let patternInput_1: (
                LrcPtr<File_system::Mut0>,
                LrcPtr<File_system::Mut1>,
                LrcPtr<File_system::Mut2>,
                LrcPtr<File_system::Mut3>,
                LrcPtr<File_system::Mut4>,
                Option<i64>,
            ) = getValue(File_system::TraceState::trace_state().get().clone());
            let v58: LrcPtr<File_system::Mut0> = patternInput_1.0.clone();
            let v81: string = File_system::method23(
                File_system::method10(
                    v58.clone(),
                    patternInput_1.1.clone(),
                    patternInput_1.2.clone(),
                    patternInput_1.3.clone(),
                    patternInput_1.4.clone(),
                    patternInput_1.5.clone(),
                ),
                File_system::method14(),
                v58.l0.get().clone(),
                File_system::method22(File_system::method16(v0_1), v1_1, v2_1),
            );
            let v83: () = {
                v4();
                ()
            };
            let patternInput_2: (
                LrcPtr<File_system::Mut0>,
                LrcPtr<File_system::Mut1>,
                LrcPtr<File_system::Mut2>,
                LrcPtr<File_system::Mut3>,
                LrcPtr<File_system::Mut4>,
                Option<i64>,
            ) = getValue(File_system::TraceState::trace_state().get().clone());
            File_system::method20(
                v81,
                patternInput_2.0.clone(),
                patternInput_2.1.clone(),
                patternInput_2.2.clone(),
                patternInput_2.3.clone(),
                patternInput_2.4.clone(),
                patternInput_2.5.clone(),
            )
        }
    }
    pub fn method21(
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
    pub fn method24(v0_1: string, v1_1: i64) -> Arc<Async<i64>> {
        defaultOf()
    }
    pub fn closure13(unitVar: (), v0_1: string) -> Arc<Async<i64>> {
        defaultOf()
    }
    pub fn closure14(unitVar: (), v0_1: string) -> Arc<Async<string>> {
        defaultOf()
    }
    pub fn method26(v0_1: string) -> bool {
        unbox::<bool>(&defaultOf())
    }
    pub fn method27(v0_1: Vec<u8>) -> Vec<u8> {
        v0_1
    }
    pub fn method25(v0_1: string, v1_1: string) -> bool {
        unbox::<bool>(&defaultOf())
    }
    pub fn closure16(v0_1: string, v1_1: string) -> bool {
        File_system::method25(v0_1, v1_1)
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
    pub fn method29() -> string {
        let v5: string = padLeft(toLower(string("Warning")), 7_i32, ' ');
        let v31_1: &str = inline_colorization::color_yellow;
        let v33_1: &str = &*v5;
        let v35_1: &str = inline_colorization::color_reset;
        let v37: std::string::String = format!("{}{}{}", v31_1, v33_1, v35_1);
        fable_library_rust::String_::fromString(v37)
    }
    pub fn method30(v0_1: string, v1_1: string) -> string {
        let v3: LrcPtr<File_system::Mut3> = LrcPtr::new(File_system::Mut3 {
            l0: MutCell::new(File_system::method18()),
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
    pub fn method31(v0_1: string, v1_1: string, v2_1: i64, v3: string) -> string {
        trimEndChars(
            trimStartChars(
                sprintf!(
                    "{} {} #{} {} / {}",
                    v0_1,
                    v1_1,
                    v2_1,
                    string("delete_file_async"),
                    v3
                ),
                toArray(empty::<char>()),
            ),
            toArray(ofArray(new_array(&[' ', '/']))),
        )
    }
    pub fn closure22(v0_1: string, v1_1: LrcPtr<Exception>, unitVar: ()) {
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
            LrcPtr<File_system::Mut4>,
            Option<i64>,
        ) = getValue(File_system::TraceState::trace_state().get().clone());
        let v36: File_system::US0 = (patternInput.4.clone()).l0.get().clone();
        if if (patternInput.2.clone()).l0.get().clone() == false {
            false
        } else {
            3_i32
                >= find(
                    v36,
                    ofSeq(ofList(ofArray(new_array(&[
                        LrcPtr::new((File_system::US0::US0_0, 0_i32)),
                        LrcPtr::new((File_system::US0::US0_1, 1_i32)),
                        LrcPtr::new((File_system::US0::US0_2, 2_i32)),
                        LrcPtr::new((File_system::US0::US0_3, 3_i32)),
                        LrcPtr::new((File_system::US0::US0_4, 4_i32)),
                    ])))),
                )
        } {
            let v43: () = {
                v3();
                ()
            };
            let patternInput_1: (
                LrcPtr<File_system::Mut0>,
                LrcPtr<File_system::Mut1>,
                LrcPtr<File_system::Mut2>,
                LrcPtr<File_system::Mut3>,
                LrcPtr<File_system::Mut4>,
                Option<i64>,
            ) = getValue(File_system::TraceState::trace_state().get().clone());
            let v57: LrcPtr<File_system::Mut0> = patternInput_1.0.clone();
            let v102: string = File_system::method31(
                File_system::method10(
                    v57.clone(),
                    patternInput_1.1.clone(),
                    patternInput_1.2.clone(),
                    patternInput_1.3.clone(),
                    patternInput_1.4.clone(),
                    patternInput_1.5.clone(),
                ),
                File_system::method29(),
                v57.l0.get().clone(),
                File_system::method30(File_system::method16(v0_1), sprintf!("{:?}", v1_1)),
            );
            let v104: () = {
                v3();
                ()
            };
            let patternInput_2: (
                LrcPtr<File_system::Mut0>,
                LrcPtr<File_system::Mut1>,
                LrcPtr<File_system::Mut2>,
                LrcPtr<File_system::Mut3>,
                LrcPtr<File_system::Mut4>,
                Option<i64>,
            ) = getValue(File_system::TraceState::trace_state().get().clone());
            File_system::method20(
                v102,
                patternInput_2.0.clone(),
                patternInput_2.1.clone(),
                patternInput_2.2.clone(),
                patternInput_2.3.clone(),
                patternInput_2.4.clone(),
                patternInput_2.5.clone(),
            )
        }
    }
    pub fn method28(v0_1: string, v1_1: i64) -> Arc<Async<i64>> {
        defaultOf()
    }
    pub fn closure21(unitVar: (), v0_1: string) -> Arc<Async<i64>> {
        defaultOf()
    }
    pub fn method33(v0_1: string, v1_1: string, v2_1: LrcPtr<Exception>) -> string {
        let v4: LrcPtr<File_system::Mut3> = LrcPtr::new(File_system::Mut3 {
            l0: MutCell::new(File_system::method18()),
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
    pub fn method34(v0_1: string, v1_1: string, v2_1: i64, v3: string) -> string {
        trimEndChars(
            trimStartChars(
                sprintf!(
                    "{} {} #{} {} / {}",
                    v0_1,
                    v1_1,
                    v2_1,
                    string("move_file_async"),
                    v3
                ),
                toArray(empty::<char>()),
            ),
            toArray(ofArray(new_array(&[' ', '/']))),
        )
    }
    pub fn closure25(v0_1: string, v1_1: string, v2_1: LrcPtr<Exception>, unitVar: ()) {
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
            LrcPtr<File_system::Mut4>,
            Option<i64>,
        ) = getValue(File_system::TraceState::trace_state().get().clone());
        let v37: File_system::US0 = (patternInput.4.clone()).l0.get().clone();
        if if (patternInput.2.clone()).l0.get().clone() == false {
            false
        } else {
            3_i32
                >= find(
                    v37,
                    ofSeq(ofList(ofArray(new_array(&[
                        LrcPtr::new((File_system::US0::US0_0, 0_i32)),
                        LrcPtr::new((File_system::US0::US0_1, 1_i32)),
                        LrcPtr::new((File_system::US0::US0_2, 2_i32)),
                        LrcPtr::new((File_system::US0::US0_3, 3_i32)),
                        LrcPtr::new((File_system::US0::US0_4, 4_i32)),
                    ])))),
                )
        } {
            let v44: () = {
                v4();
                ()
            };
            let patternInput_1: (
                LrcPtr<File_system::Mut0>,
                LrcPtr<File_system::Mut1>,
                LrcPtr<File_system::Mut2>,
                LrcPtr<File_system::Mut3>,
                LrcPtr<File_system::Mut4>,
                Option<i64>,
            ) = getValue(File_system::TraceState::trace_state().get().clone());
            let v58: LrcPtr<File_system::Mut0> = patternInput_1.0.clone();
            let v82: string = File_system::method34(
                File_system::method10(
                    v58.clone(),
                    patternInput_1.1.clone(),
                    patternInput_1.2.clone(),
                    patternInput_1.3.clone(),
                    patternInput_1.4.clone(),
                    patternInput_1.5.clone(),
                ),
                File_system::method29(),
                v58.l0.get().clone(),
                File_system::method33(
                    File_system::method16(v1_1),
                    File_system::method16(v0_1),
                    v2_1,
                ),
            );
            let v84: () = {
                v4();
                ()
            };
            let patternInput_2: (
                LrcPtr<File_system::Mut0>,
                LrcPtr<File_system::Mut1>,
                LrcPtr<File_system::Mut2>,
                LrcPtr<File_system::Mut3>,
                LrcPtr<File_system::Mut4>,
                Option<i64>,
            ) = getValue(File_system::TraceState::trace_state().get().clone());
            File_system::method20(
                v82,
                patternInput_2.0.clone(),
                patternInput_2.1.clone(),
                patternInput_2.2.clone(),
                patternInput_2.3.clone(),
                patternInput_2.4.clone(),
                patternInput_2.5.clone(),
            )
        }
    }
    pub fn method32(v0_1: string, v1_1: string, v2_1: i64) -> Arc<Async<i64>> {
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
    pub fn method36() -> string {
        let v5: string = padLeft(toLower(string("Verbose")), 7_i32, ' ');
        let v31_1: &str = inline_colorization::color_bright_black;
        let v33_1: &str = &*v5;
        let v35_1: &str = inline_colorization::color_reset;
        let v37: std::string::String = format!("{}{}{}", v31_1, v33_1, v35_1);
        fable_library_rust::String_::fromString(v37)
    }
    pub fn method37(v0_1: i32) -> string {
        let v2_1: LrcPtr<File_system::Mut3> = LrcPtr::new(File_system::Mut3 {
            l0: MutCell::new(File_system::method18()),
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
    pub fn method38(v0_1: string, v1_1: string, v2_1: string, v3: i64, v4: string) -> string {
        trimEndChars(
            trimStartChars(
                sprintf!("{} {} #{} {} / {}", v0_1, v1_1, v3, v2_1, v4),
                toArray(empty::<char>()),
            ),
            toArray(ofArray(new_array(&[' ', '/']))),
        )
    }
    pub fn closure29(unitVar: (), unitVar_1: ()) {
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
            LrcPtr<File_system::Mut4>,
            Option<i64>,
        ) = getValue(File_system::TraceState::trace_state().get().clone());
        let v34_1: File_system::US0 = (patternInput.4.clone()).l0.get().clone();
        if if (patternInput.2.clone()).l0.get().clone() == false {
            false
        } else {
            0_i32
                >= find(
                    v34_1,
                    ofSeq(ofList(ofArray(new_array(&[
                        LrcPtr::new((File_system::US0::US0_0, 0_i32)),
                        LrcPtr::new((File_system::US0::US0_1, 1_i32)),
                        LrcPtr::new((File_system::US0::US0_2, 2_i32)),
                        LrcPtr::new((File_system::US0::US0_3, 3_i32)),
                        LrcPtr::new((File_system::US0::US0_4, 4_i32)),
                    ])))),
                )
        } {
            let v41: () = {
                v1_1();
                ()
            };
            let patternInput_1: (
                LrcPtr<File_system::Mut0>,
                LrcPtr<File_system::Mut1>,
                LrcPtr<File_system::Mut2>,
                LrcPtr<File_system::Mut3>,
                LrcPtr<File_system::Mut4>,
                Option<i64>,
            ) = getValue(File_system::TraceState::trace_state().get().clone());
            let v55: LrcPtr<File_system::Mut0> = patternInput_1.0.clone();
            let v82: string = File_system::method38(
                File_system::method10(
                    v55.clone(),
                    patternInput_1.1.clone(),
                    patternInput_1.2.clone(),
                    patternInput_1.3.clone(),
                    patternInput_1.4.clone(),
                    patternInput_1.5.clone(),
                ),
                File_system::method36(),
                string("async.run_with_timeout_async"),
                v55.l0.get().clone(),
                File_system::method37(1000_i32),
            );
            let v84: () = {
                v1_1();
                ()
            };
            let patternInput_2: (
                LrcPtr<File_system::Mut0>,
                LrcPtr<File_system::Mut1>,
                LrcPtr<File_system::Mut2>,
                LrcPtr<File_system::Mut3>,
                LrcPtr<File_system::Mut4>,
                Option<i64>,
            ) = getValue(File_system::TraceState::trace_state().get().clone());
            File_system::method20(
                v82,
                patternInput_2.0.clone(),
                patternInput_2.1.clone(),
                patternInput_2.2.clone(),
                patternInput_2.3.clone(),
                patternInput_2.4.clone(),
                patternInput_2.5.clone(),
            )
        }
    }
    pub fn method39() -> string {
        let v5: string = padLeft(toLower(string("Critical")), 7_i32, ' ');
        let v31_1: &str = inline_colorization::color_bright_red;
        let v33_1: &str = &*v5;
        let v35_1: &str = inline_colorization::color_reset;
        let v37: std::string::String = format!("{}{}{}", v31_1, v33_1, v35_1);
        fable_library_rust::String_::fromString(v37)
    }
    pub fn method40(v0_1: i32, v1_1: string) -> string {
        let v3: LrcPtr<File_system::Mut3> = LrcPtr::new(File_system::Mut3 {
            l0: MutCell::new(File_system::method18()),
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
    pub fn closure30(v0_1: LrcPtr<Exception>, unitVar: ()) {
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
            LrcPtr<File_system::Mut4>,
            Option<i64>,
        ) = getValue(File_system::TraceState::trace_state().get().clone());
        let v35_1: File_system::US0 = (patternInput.4.clone()).l0.get().clone();
        if if (patternInput.2.clone()).l0.get().clone() == false {
            false
        } else {
            4_i32
                >= find(
                    v35_1,
                    ofSeq(ofList(ofArray(new_array(&[
                        LrcPtr::new((File_system::US0::US0_0, 0_i32)),
                        LrcPtr::new((File_system::US0::US0_1, 1_i32)),
                        LrcPtr::new((File_system::US0::US0_2, 2_i32)),
                        LrcPtr::new((File_system::US0::US0_3, 3_i32)),
                        LrcPtr::new((File_system::US0::US0_4, 4_i32)),
                    ])))),
                )
        } {
            let v42: () = {
                v2_1();
                ()
            };
            let patternInput_1: (
                LrcPtr<File_system::Mut0>,
                LrcPtr<File_system::Mut1>,
                LrcPtr<File_system::Mut2>,
                LrcPtr<File_system::Mut3>,
                LrcPtr<File_system::Mut4>,
                Option<i64>,
            ) = getValue(File_system::TraceState::trace_state().get().clone());
            let v56: LrcPtr<File_system::Mut0> = patternInput_1.0.clone();
            let v105: string = File_system::method38(
                File_system::method10(
                    v56.clone(),
                    patternInput_1.1.clone(),
                    patternInput_1.2.clone(),
                    patternInput_1.3.clone(),
                    patternInput_1.4.clone(),
                    patternInput_1.5.clone(),
                ),
                File_system::method39(),
                string("async.run_with_timeout_async**"),
                v56.l0.get().clone(),
                File_system::method40(1000_i32, sprintf!("{:?}", v0_1)),
            );
            let v107: () = {
                v2_1();
                ()
            };
            let patternInput_2: (
                LrcPtr<File_system::Mut0>,
                LrcPtr<File_system::Mut1>,
                LrcPtr<File_system::Mut2>,
                LrcPtr<File_system::Mut3>,
                LrcPtr<File_system::Mut4>,
                Option<i64>,
            ) = getValue(File_system::TraceState::trace_state().get().clone());
            File_system::method20(
                v105,
                patternInput_2.0.clone(),
                patternInput_2.1.clone(),
                patternInput_2.2.clone(),
                patternInput_2.3.clone(),
                patternInput_2.4.clone(),
                patternInput_2.5.clone(),
            )
        }
    }
    pub fn method41(v0_1: i64, v1_1: string) -> string {
        let v3: LrcPtr<File_system::Mut3> = LrcPtr::new(File_system::Mut3 {
            l0: MutCell::new(File_system::method18()),
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
    pub fn closure31(v0_1: i64, v1_1: string, unitVar: ()) {
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
            LrcPtr<File_system::Mut4>,
            Option<i64>,
        ) = getValue(File_system::TraceState::trace_state().get().clone());
        let v36: File_system::US0 = (patternInput.4.clone()).l0.get().clone();
        if if (patternInput.2.clone()).l0.get().clone() == false {
            false
        } else {
            1_i32
                >= find(
                    v36,
                    ofSeq(ofList(ofArray(new_array(&[
                        LrcPtr::new((File_system::US0::US0_0, 0_i32)),
                        LrcPtr::new((File_system::US0::US0_1, 1_i32)),
                        LrcPtr::new((File_system::US0::US0_2, 2_i32)),
                        LrcPtr::new((File_system::US0::US0_3, 3_i32)),
                        LrcPtr::new((File_system::US0::US0_4, 4_i32)),
                    ])))),
                )
        } {
            let v43: () = {
                v3();
                ()
            };
            let patternInput_1: (
                LrcPtr<File_system::Mut0>,
                LrcPtr<File_system::Mut1>,
                LrcPtr<File_system::Mut2>,
                LrcPtr<File_system::Mut3>,
                LrcPtr<File_system::Mut4>,
                Option<i64>,
            ) = getValue(File_system::TraceState::trace_state().get().clone());
            let v57: LrcPtr<File_system::Mut0> = patternInput_1.0.clone();
            let v83: string = File_system::method38(
                File_system::method10(
                    v57.clone(),
                    patternInput_1.1.clone(),
                    patternInput_1.2.clone(),
                    patternInput_1.3.clone(),
                    patternInput_1.4.clone(),
                    patternInput_1.5.clone(),
                ),
                File_system::method14(),
                string("read_all_text_retry_async"),
                v57.l0.get().clone(),
                File_system::method41(v0_1, v1_1),
            );
            let v85: () = {
                v3();
                ()
            };
            let patternInput_2: (
                LrcPtr<File_system::Mut0>,
                LrcPtr<File_system::Mut1>,
                LrcPtr<File_system::Mut2>,
                LrcPtr<File_system::Mut3>,
                LrcPtr<File_system::Mut4>,
                Option<i64>,
            ) = getValue(File_system::TraceState::trace_state().get().clone());
            File_system::method20(
                v83,
                patternInput_2.0.clone(),
                patternInput_2.1.clone(),
                patternInput_2.2.clone(),
                patternInput_2.3.clone(),
                patternInput_2.4.clone(),
                patternInput_2.5.clone(),
            )
        }
    }
    pub fn method35(v0_1: string, v1_1: i64) -> Arc<Async<Option<string>>> {
        defaultOf()
    }
    pub fn closure26(unitVar: (), v0_1: string) -> Arc<Async<Option<string>>> {
        defaultOf()
    }
    pub fn closure33(unitVar: (), v0_1: chrono::DateTime<chrono::Utc>) -> File_system::US11 {
        File_system::US11::US11_0(v0_1)
    }
    pub fn method44() -> Func1<chrono::DateTime<chrono::Utc>, File_system::US11> {
        Func1::new(move |v: chrono::DateTime<chrono::Utc>| File_system::closure33((), v))
    }
    pub fn method45() -> string {
        string("hh:mm")
    }
    pub fn method46() -> string {
        string("yyyyMMdd-HHmm-ssff-ffff-f")
    }
    pub fn method47() -> string {
        string("hhmm")
    }
    pub fn method43(v0_1: Guid, v1_1: DateTime) -> Guid {
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
            map(File_system::method44(), v185),
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
        let v302: string = File_system::method45();
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
    pub fn method49() -> string {
        panic!(
            "{}",
            sprintf!(
                "file_system.get_temp_path / target: {}",
                File_system::US5::US5_2(File_system::US4::US4_1)
            ),
        )
    }
    pub fn method50() -> string {
        string("!create_temp_path_")
    }
    pub fn method53(v0_1: string) -> string {
        v0_1
    }
    pub fn method52(v0_1: string, v1_1: string) -> (string, string) {
        (v1_1, File_system::method53(v0_1))
    }
    pub fn method51(v0_1: string, v1_1: string) -> string {
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
    pub fn method55() -> string {
        string("CARGO_PKG_NAME")
    }
    pub fn method54() -> string {
        File_system::method2(File_system::method55())
    }
    pub fn method48(v0_1: Guid) -> string {
        File_system::method51(
            File_system::method51(
                File_system::method51(File_system::method49(), File_system::method50()),
                File_system::method54(),
            ),
            toString(v0_1),
        )
    }
    pub fn method42() -> string {
        let v10: DateTime = DateTime::now();
        File_system::method48(File_system::method43(new_guid(), v10))
    }
    pub fn closure32(unitVar: (), unitVar_1: ()) -> string {
        File_system::method42()
    }
    pub fn method57(v0_1: string) -> string {
        v0_1
    }
    pub fn closure35(unitVar: (), v0_1: std::io::Error) -> std::string::String {
        format!("{}", v0_1)
    }
    pub fn method58() -> Func1<std::io::Error, std::string::String> {
        Func1::new(move |v: std::io::Error| File_system::closure35((), v))
    }
    pub fn closure36(unitVar: (), unitVar_1: ()) -> File_system::US12 {
        File_system::US12::US12_0
    }
    pub fn closure37(unitVar: (), v0_1: std::string::String) -> File_system::US12 {
        File_system::US12::US12_1(v0_1)
    }
    pub fn method59(v0_1: string, v1_1: std::string::String) -> string {
        let v3: LrcPtr<File_system::Mut3> = LrcPtr::new(File_system::Mut3 {
            l0: MutCell::new(File_system::method18()),
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
    pub fn method60(v0_1: string, v1_1: string, v2_1: i64, v3: string) -> string {
        trimEndChars(
            trimStartChars(
                sprintf!(
                    "{} {} #{} {} / {}",
                    v0_1,
                    v1_1,
                    v2_1,
                    string("file_system.create_dir"),
                    v3
                ),
                toArray(empty::<char>()),
            ),
            toArray(ofArray(new_array(&[' ', '/']))),
        )
    }
    pub fn closure38(v0_1: string, v1_1: std::string::String, unitVar: ()) {
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
            LrcPtr<File_system::Mut4>,
            Option<i64>,
        ) = getValue(File_system::TraceState::trace_state().get().clone());
        let v36: File_system::US0 = (patternInput.4.clone()).l0.get().clone();
        if if (patternInput.2.clone()).l0.get().clone() == false {
            false
        } else {
            4_i32
                >= find(
                    v36,
                    ofSeq(ofList(ofArray(new_array(&[
                        LrcPtr::new((File_system::US0::US0_0, 0_i32)),
                        LrcPtr::new((File_system::US0::US0_1, 1_i32)),
                        LrcPtr::new((File_system::US0::US0_2, 2_i32)),
                        LrcPtr::new((File_system::US0::US0_3, 3_i32)),
                        LrcPtr::new((File_system::US0::US0_4, 4_i32)),
                    ])))),
                )
        } {
            let v43: () = {
                v3();
                ()
            };
            let patternInput_1: (
                LrcPtr<File_system::Mut0>,
                LrcPtr<File_system::Mut1>,
                LrcPtr<File_system::Mut2>,
                LrcPtr<File_system::Mut3>,
                LrcPtr<File_system::Mut4>,
                Option<i64>,
            ) = getValue(File_system::TraceState::trace_state().get().clone());
            let v57: LrcPtr<File_system::Mut0> = patternInput_1.0.clone();
            let v79: string = File_system::method60(
                File_system::method10(
                    v57.clone(),
                    patternInput_1.1.clone(),
                    patternInput_1.2.clone(),
                    patternInput_1.3.clone(),
                    patternInput_1.4.clone(),
                    patternInput_1.5.clone(),
                ),
                File_system::method39(),
                v57.l0.get().clone(),
                File_system::method59(v0_1, v1_1),
            );
            let v81: () = {
                v3();
                ()
            };
            let patternInput_2: (
                LrcPtr<File_system::Mut0>,
                LrcPtr<File_system::Mut1>,
                LrcPtr<File_system::Mut2>,
                LrcPtr<File_system::Mut3>,
                LrcPtr<File_system::Mut4>,
                Option<i64>,
            ) = getValue(File_system::TraceState::trace_state().get().clone());
            File_system::method20(
                v79,
                patternInput_2.0.clone(),
                patternInput_2.1.clone(),
                patternInput_2.2.clone(),
                patternInput_2.3.clone(),
                patternInput_2.4.clone(),
                patternInput_2.5.clone(),
            )
        }
    }
    pub fn method61(v0_1: string) -> string {
        let v2_1: LrcPtr<File_system::Mut3> = LrcPtr::new(File_system::Mut3 {
            l0: MutCell::new(File_system::method18()),
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
    pub fn closure39(v0_1: string, unitVar: ()) {
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
            LrcPtr<File_system::Mut4>,
            Option<i64>,
        ) = getValue(File_system::TraceState::trace_state().get().clone());
        let v35_1: File_system::US0 = (patternInput.4.clone()).l0.get().clone();
        if if (patternInput.2.clone()).l0.get().clone() == false {
            false
        } else {
            0_i32
                >= find(
                    v35_1,
                    ofSeq(ofList(ofArray(new_array(&[
                        LrcPtr::new((File_system::US0::US0_0, 0_i32)),
                        LrcPtr::new((File_system::US0::US0_1, 1_i32)),
                        LrcPtr::new((File_system::US0::US0_2, 2_i32)),
                        LrcPtr::new((File_system::US0::US0_3, 3_i32)),
                        LrcPtr::new((File_system::US0::US0_4, 4_i32)),
                    ])))),
                )
        } {
            let v42: () = {
                v2_1();
                ()
            };
            let patternInput_1: (
                LrcPtr<File_system::Mut0>,
                LrcPtr<File_system::Mut1>,
                LrcPtr<File_system::Mut2>,
                LrcPtr<File_system::Mut3>,
                LrcPtr<File_system::Mut4>,
                Option<i64>,
            ) = getValue(File_system::TraceState::trace_state().get().clone());
            let v56: LrcPtr<File_system::Mut0> = patternInput_1.0.clone();
            let v78: string = File_system::method60(
                File_system::method10(
                    v56.clone(),
                    patternInput_1.1.clone(),
                    patternInput_1.2.clone(),
                    patternInput_1.3.clone(),
                    patternInput_1.4.clone(),
                    patternInput_1.5.clone(),
                ),
                File_system::method36(),
                v56.l0.get().clone(),
                File_system::method61(v0_1),
            );
            let v80: () = {
                v2_1();
                ()
            };
            let patternInput_2: (
                LrcPtr<File_system::Mut0>,
                LrcPtr<File_system::Mut1>,
                LrcPtr<File_system::Mut2>,
                LrcPtr<File_system::Mut3>,
                LrcPtr<File_system::Mut4>,
                Option<i64>,
            ) = getValue(File_system::TraceState::trace_state().get().clone());
            File_system::method20(
                v78,
                patternInput_2.0.clone(),
                patternInput_2.1.clone(),
                patternInput_2.2.clone(),
                patternInput_2.3.clone(),
                patternInput_2.4.clone(),
                patternInput_2.5.clone(),
            )
        }
    }
    pub fn closure40(v0_1: string, unitVar: ()) {
        File_system::method7(true, v0_1);
    }
    pub fn method62(v0_1: string) -> Func0<()> {
        Func0::new({
            let v0_1 = v0_1.clone();
            move || File_system::closure40(v0_1.clone(), ())
        })
    }
    pub fn method63(v0_1: string) -> Func0<()> {
        Func0::new({
            let v0_1 = v0_1.clone();
            move || File_system::closure40(v0_1.clone(), ())
        })
    }
    pub fn method64(v0_1: string, v1_1: string) -> string {
        let v3: LrcPtr<File_system::Mut3> = LrcPtr::new(File_system::Mut3 {
            l0: MutCell::new(File_system::method18()),
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
    pub fn closure41(v0_1: string, v1_1: string, unitVar: ()) {
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
            LrcPtr<File_system::Mut4>,
            Option<i64>,
        ) = getValue(File_system::TraceState::trace_state().get().clone());
        let v36: File_system::US0 = (patternInput.4.clone()).l0.get().clone();
        if if (patternInput.2.clone()).l0.get().clone() == false {
            false
        } else {
            1_i32
                >= find(
                    v36,
                    ofSeq(ofList(ofArray(new_array(&[
                        LrcPtr::new((File_system::US0::US0_0, 0_i32)),
                        LrcPtr::new((File_system::US0::US0_1, 1_i32)),
                        LrcPtr::new((File_system::US0::US0_2, 2_i32)),
                        LrcPtr::new((File_system::US0::US0_3, 3_i32)),
                        LrcPtr::new((File_system::US0::US0_4, 4_i32)),
                    ])))),
                )
        } {
            let v43: () = {
                v3();
                ()
            };
            let patternInput_1: (
                LrcPtr<File_system::Mut0>,
                LrcPtr<File_system::Mut1>,
                LrcPtr<File_system::Mut2>,
                LrcPtr<File_system::Mut3>,
                LrcPtr<File_system::Mut4>,
                Option<i64>,
            ) = getValue(File_system::TraceState::trace_state().get().clone());
            let v57: LrcPtr<File_system::Mut0> = patternInput_1.0.clone();
            let v79: string = File_system::method60(
                File_system::method10(
                    v57.clone(),
                    patternInput_1.1.clone(),
                    patternInput_1.2.clone(),
                    patternInput_1.3.clone(),
                    patternInput_1.4.clone(),
                    patternInput_1.5.clone(),
                ),
                File_system::method14(),
                v57.l0.get().clone(),
                File_system::method64(v0_1, v1_1),
            );
            let v81: () = {
                v3();
                ()
            };
            let patternInput_2: (
                LrcPtr<File_system::Mut0>,
                LrcPtr<File_system::Mut1>,
                LrcPtr<File_system::Mut2>,
                LrcPtr<File_system::Mut3>,
                LrcPtr<File_system::Mut4>,
                Option<i64>,
            ) = getValue(File_system::TraceState::trace_state().get().clone());
            File_system::method20(
                v79,
                patternInput_2.0.clone(),
                patternInput_2.1.clone(),
                patternInput_2.2.clone(),
                patternInput_2.3.clone(),
                patternInput_2.4.clone(),
                patternInput_2.5.clone(),
            )
        }
    }
    pub fn closure42(v0_1: string, unitVar: ()) {
        let v5: Arc<Async<i64>> = defaultOf();
        let v28_1: Arc<Async<()>> = defaultOf();
        defaultOf::<()>();
        ();
        ()
    }
    pub fn method65(v0_1: string) -> Func0<()> {
        Func0::new({
            let v0_1 = v0_1.clone();
            move || File_system::closure42(v0_1.clone(), ())
        })
    }
    pub fn method66(v0_1: string) -> Func0<()> {
        Func0::new({
            let v0_1 = v0_1.clone();
            move || File_system::closure42(v0_1.clone(), ())
        })
    }
    pub fn method56(v0_1: string) -> LrcPtr<dyn IDisposable> {
        interface_cast!(
            defaultOf::<std::sync::Arc<dyn IDisposable>>(),
            Lrc<dyn IDisposable>,
        )
    }
    pub fn closure34(unitVar: (), unitVar_1: ()) -> (string, LrcPtr<dyn IDisposable>) {
        let v0_1: string = File_system::method42();
        (v0_1.clone(), File_system::method56(v0_1))
    }
    pub fn method67(v0_1: string) -> Guid {
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
        let v2_1: string = File_system::method48(File_system::method67(v0_1));
        (v2_1.clone(), File_system::method56(v2_1))
    }
    pub fn closure44(unitVar: (), unitVar_1: ()) -> string {
        string("C:\\home\\git\\polyglot\\lib\\spiral")
    }
    pub fn method69(v0_1: string) -> string {
        v0_1
    }
    pub fn method68(v0_1: string) -> string {
        if v0_1 == string("") {
            string("")
        } else {
            let v30_1: string = unbox::<string>(&defaultOf());
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
    pub fn closure45(unitVar: (), v0_1: string) -> string {
        File_system::method68(v0_1)
    }
    pub fn closure46(unitVar: (), v0_1: string) -> string {
        sprintf!("file:///{}", trimStartChars(v0_1, toArray(singleton('/'))))
    }
    pub fn method72(v0_1: string) -> Option<string> {
        let v85: File_system::US1 = unbox::<File_system::US1>(&defaultOf());
        match &v85 {
            File_system::US1::US1_0(v85_0_0) => Some(match &v85 {
                File_system::US1::US1_0(x) => x.clone(),
                _ => unreachable!(),
            }),
            _ => None::<string>,
        }
    }
    pub fn closure48(unitVar: (), v0_1: string) -> Option<string> {
        File_system::method72(v0_1)
    }
    pub fn method71() -> Func1<string, Option<string>> {
        Func1::new(move |v: string| File_system::closure48((), v))
    }
    pub fn method73(v0_1: string, v1_1: string, v2_1: string) -> File_system::US13 {
        let v0_1: MutCell<string> = MutCell::new(v0_1.clone());
        let v1_1: MutCell<string> = MutCell::new(v1_1.clone());
        let v2_1: MutCell<string> = MutCell::new(v2_1.clone());
        '_method73: loop {
            break '_method73 (if File_system::method9(File_system::method51(
                v2_1.get().clone(),
                v0_1.get().clone(),
            )) {
                File_system::US13::US13_0(v2_1.get().clone())
            } else {
                let v7: Option<string> = (File_system::method71())(v2_1.get().clone());
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
                        continue '_method73;
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
    pub fn method70(v0_1: string, v1_1: string) -> File_system::US13 {
        if File_system::method9(File_system::method51(v1_1.clone(), v0_1.clone())) {
            File_system::US13::US13_0(v1_1.clone())
        } else {
            let v6: Option<string> = (File_system::method71())(v1_1.clone());
            let v20_1: File_system::US1 =
                defaultValue(File_system::US1::US1_1, map(File_system::method4(), v6));
            match &v20_1 {
                File_system::US1::US1_0(v20_1_0_0) => File_system::method73(
                    v0_1.clone(),
                    v1_1.clone(),
                    match &v20_1 {
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
    pub fn method74(v0_1: string) -> string {
        let v2_1: LrcPtr<File_system::Mut3> = LrcPtr::new(File_system::Mut3 {
            l0: MutCell::new(File_system::method18()),
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
    pub fn method75(v0_1: string, v1_1: string, v2_1: i64, v3: string) -> string {
        trimEndChars(
            trimStartChars(
                sprintf!(
                    "{} {} #{} {} / {}",
                    v0_1,
                    v1_1,
                    v2_1,
                    string("file_system.get_workspace_root"),
                    v3
                ),
                toArray(empty::<char>()),
            ),
            toArray(ofArray(new_array(&[' ', '/']))),
        )
    }
    pub fn closure49(v0_1: string, unitVar: ()) {
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
            LrcPtr<File_system::Mut4>,
            Option<i64>,
        ) = getValue(File_system::TraceState::trace_state().get().clone());
        let v35_1: File_system::US0 = (patternInput.4.clone()).l0.get().clone();
        if if (patternInput.2.clone()).l0.get().clone() == false {
            false
        } else {
            3_i32
                >= find(
                    v35_1,
                    ofSeq(ofList(ofArray(new_array(&[
                        LrcPtr::new((File_system::US0::US0_0, 0_i32)),
                        LrcPtr::new((File_system::US0::US0_1, 1_i32)),
                        LrcPtr::new((File_system::US0::US0_2, 2_i32)),
                        LrcPtr::new((File_system::US0::US0_3, 3_i32)),
                        LrcPtr::new((File_system::US0::US0_4, 4_i32)),
                    ])))),
                )
        } {
            let v42: () = {
                v2_1();
                ()
            };
            let patternInput_1: (
                LrcPtr<File_system::Mut0>,
                LrcPtr<File_system::Mut1>,
                LrcPtr<File_system::Mut2>,
                LrcPtr<File_system::Mut3>,
                LrcPtr<File_system::Mut4>,
                Option<i64>,
            ) = getValue(File_system::TraceState::trace_state().get().clone());
            let v56: LrcPtr<File_system::Mut0> = patternInput_1.0.clone();
            let v78: string = File_system::method75(
                File_system::method10(
                    v56.clone(),
                    patternInput_1.1.clone(),
                    patternInput_1.2.clone(),
                    patternInput_1.3.clone(),
                    patternInput_1.4.clone(),
                    patternInput_1.5.clone(),
                ),
                File_system::method29(),
                v56.l0.get().clone(),
                File_system::method74(v0_1),
            );
            let v80: () = {
                v2_1();
                ()
            };
            let patternInput_2: (
                LrcPtr<File_system::Mut0>,
                LrcPtr<File_system::Mut1>,
                LrcPtr<File_system::Mut2>,
                LrcPtr<File_system::Mut3>,
                LrcPtr<File_system::Mut4>,
                Option<i64>,
            ) = getValue(File_system::TraceState::trace_state().get().clone());
            File_system::method20(
                v78,
                patternInput_2.0.clone(),
                patternInput_2.1.clone(),
                patternInput_2.2.clone(),
                patternInput_2.3.clone(),
                patternInput_2.4.clone(),
                patternInput_2.5.clone(),
            )
        }
    }
    pub fn method76() -> string {
        unbox::<string>(&defaultOf())
    }
    pub fn closure47(unitVar: (), unitVar_1: ()) -> string {
        let v4: File_system::US13 = File_system::method70(
            File_system::method51(string("polyglot"), string(".devcontainer")),
            string("C:\\home\\git\\polyglot\\lib\\spiral"),
        );
        let v124: File_system::US1 = match &v4 {
            File_system::US13::US13_0(v4_0_0) => File_system::US1::US1_0(v4_0_0.clone()),
            File_system::US13::US13_1(v4_1_0) => {
                let v10: () = {
                    File_system::closure49(v4_1_0.clone(), ());
                    ()
                };
                File_system::US1::US1_1
            }
        };
        let v251: File_system::US1 = match &v124 {
            File_system::US1::US1_0(v124_0_0) => File_system::US1::US1_0(match &v124 {
                File_system::US1::US1_0(x) => x.clone(),
                _ => unreachable!(),
            }),
            _ => {
                let v127: string = File_system::method76();
                let v129: File_system::US13 = File_system::method70(
                    File_system::method51(string("polyglot"), string(".devcontainer")),
                    v127,
                );
                match &v129 {
                    File_system::US13::US13_0(v129_0_0) => {
                        File_system::US1::US1_0(v129_0_0.clone())
                    }
                    File_system::US13::US13_1(v129_1_0) => {
                        let v135: () = {
                            File_system::closure49(v129_1_0.clone(), ());
                            ()
                        };
                        File_system::US1::US1_1
                    }
                }
            }
        };
        File_system::method51(
            match &v251 {
                File_system::US1::US1_0(v251_0_0) => match &v251 {
                    File_system::US1::US1_0(x) => x.clone(),
                    _ => unreachable!(),
                },
                _ => panic!("{}", string("Option does not have a value."),),
            },
            string("polyglot"),
        )
    }
    pub fn method77(v0_1: string) {
        ();
        ()
    }
    pub fn closure51(unitVar: (), v0_1: string) {
        File_system::method77(v0_1);
    }
    pub fn closure50(unitVar: (), v0_1: bool) {
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
            Func1::new(move |v: string| File_system::closure51((), v))
        } else {
            Func1::new(move |v_1: string| File_system::closure2((), v_1))
        };
        (patternInput.1.clone()).l0.set(v37);
        ()
    }
    pub fn method79(v0_1: string) -> string {
        unbox::<string>(&defaultOf())
    }
    pub fn method78(v0_1: string, v1_1: string) {
        if File_system::method9(v0_1.clone()) == false {
            let v4: LrcPtr<dyn IDisposable> = File_system::method56(v0_1);
            ()
        }
        {
            let v5: string = File_system::method79(v1_1.clone());
            if File_system::method9(v5.clone()) == false {
                let v8: LrcPtr<dyn IDisposable> = File_system::method56(v5);
                ()
            }
            if if File_system::method9(v1_1.clone()) {
                let v14: Result<std::path::PathBuf, std::io::Error> =
                    std::fs::read_link(&*v1_1.clone());
                v14.is_err()
            } else {
                false
            } {
                File_system::method7(true, v1_1.clone());
            }
            if File_system::method9(v1_1) == false {
                ();
                ()
            }
        }
    }
    pub fn closure53(v0_1: string, v1_1: string) {
        File_system::method78(v0_1, v1_1);
    }
    pub fn closure52(unitVar: (), v0_1: string) -> Func1<string, ()> {
        Func1::new({
            let v0_1 = v0_1.clone();
            move |v: string| File_system::closure53(v0_1.clone(), v)
        })
    }
    pub fn closure55(v0_1: string, v1_1: string) -> string {
        File_system::method51(v0_1, v1_1)
    }
    pub fn closure54(unitVar: (), v0_1: string) -> Func1<string, string> {
        Func1::new({
            let v0_1 = v0_1.clone();
            move |v: string| File_system::closure55(v0_1.clone(), v)
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
        v31.get_or_init(|| Func1::new(move |v: string| File_system::closure46((), v)))
            .clone()
    }
    pub fn new_file_uri(x: string) -> string {
        (File_system::v31())(x)
    }
    pub fn v32() -> Func0<string> {
        static v32: OnceInit<Func0<string>> = OnceInit::new();
        v32.get_or_init(|| Func0::new(move || File_system::closure47((), ())))
            .clone()
    }
    pub fn get_workspace_root() -> string {
        (File_system::v32())()
    }
    pub fn v33() -> Func1<bool, ()> {
        static v33: OnceInit<Func1<bool, ()>> = OnceInit::new();
        v33.get_or_init(|| Func1::new(move |v: bool| File_system::closure50((), v)))
            .clone()
    }
    pub fn init_trace_file(x: bool) {
        (File_system::v33())(x);
    }
    pub fn v34() -> Func1<string, Func1<string, ()>> {
        static v34: OnceInit<Func1<string, Func1<string, ()>>> = OnceInit::new();
        v34.get_or_init(|| Func1::new(move |v: string| File_system::closure52((), v)))
            .clone()
    }
    pub fn link_directory(x: string) -> Func1<string, ()> {
        (File_system::v34())(x)
    }
    pub fn v35() -> Func1<string, Func1<string, string>> {
        static v35: OnceInit<Func1<string, Func1<string, string>>> = OnceInit::new();
        v35.get_or_init(|| Func1::new(move |v: string| File_system::closure54((), v)))
            .clone()
    }
    pub fn op_LessDivideGreater(x: string) -> Func1<string, string> {
        (File_system::v35())(x)
    }
    on_startup!(());
}
