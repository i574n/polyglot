pub mod File_system {
    use super::*;
    type Async<T> = T;
    type DateTime = ();
    type Guid = ();
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
    use fable_library_rust::String_::ofChar;
    use fable_library_rust::String_::printfn;
    use fable_library_rust::String_::replace;
    use fable_library_rust::String_::sprintf;
    use fable_library_rust::String_::string;
    use fable_library_rust::String_::toLower;
    use fable_library_rust::String_::toString;
    use fable_library_rust::String_::trimEndChars;
    use fable_library_rust::String_::trimStartChars;
    use fable_library_rust::System::Exception;
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
        US11_0(Option<()>),
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
        let v33_1: Result<std::string::String, std::env::VarError> = std::env::var(&*v0_1);
        let v35_1: bool = true;
        let _result_map_ = v33_1.map(|x| {
            //;
            let v37: std::string::String = x;
            let v39: string = fable_library_rust::String_::fromString(v37);
            let v41: bool = true;
            v39
        });
        let v43: Result<string, std::env::VarError> = _result_map_;
        let v44: string = File_system::method3();
        v43.unwrap_or(v44)
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
        let v123: string = string("env!(\"AUTOMATION\")");
        let v124: &str = env!("AUTOMATION");
        let v131: std::string::String = String::from(v124);
        let _v1: (File_system::US4, File_system::US5) = (
            File_system::US4::US4_1,
            if fable_library_rust::String_::fromString(v131) != string("True") {
                File_system::US5::US5_1
            } else {
                File_system::US5::US5_0(near_sdk::env::block_timestamp() as i64)
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
        let v130: u64 = near_sdk::env::block_timestamp();
        let v144: File_system::US5 =
            defaultValue(File_system::US5::US5_1, map(File_system::method12(), v5));
        let v154: u64 = match &v144 {
            File_system::US5::US5_0(v144_0_0) => {
                v130 - match &v144 {
                    File_system::US5::US5_0(x) => x.clone(),
                    _ => unreachable!(),
                } as u64
            }
            _ => v130,
        } / 1000000000_u64;
        let v155: u64 = v154 % 60_u64;
        let v157: u64 = v154 / 60_u64 % 60_u64;
        let v159: u64 = v154 / 3600_u64 % 24_u64;
        let v161: std::string::String = format!("{:02}:{:02}:{:02}", v159, v157, v155);
        fable_library_rust::String_::fromString(v161)
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
        let v73: &str = inline_colorization::color_bright_blue;
        let v80: &str = &*v6;
        let v99: &str = inline_colorization::color_reset;
        let v101: std::string::String = format!("{}{}{}", v73, v80, v99);
        fable_library_rust::String_::fromString(v101)
    }
    pub fn method19(v0_1: string) -> string {
        unbox::<string>(&defaultOf())
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
        let v20_1: LrcPtr<File_system::Mut3> = patternInput.3.clone();
        let v37: () = {
            File_system::closure7(patternInput.0.clone(), ());
            ()
        };
        let v53: string = if v20_1.l0.get().clone() == string("") {
            v0_1.clone()
        } else {
            if v0_1.clone() == string("") {
                v20_1.l0.get().clone()
            } else {
                append(append(v20_1.l0.get().clone(), string("\n")), v0_1.clone())
            }
        };
        let v60: &str = &*v53.clone();
        let v79 = v60.chars();
        let v81 = v79;
        let v83: Vec<char> = v81.collect::<Vec<_>>();
        let v85: Vec<Vec<char>> = v83
            .chunks(15000)
            .map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>())
            .collect::<Vec<_>>();
        let v87: bool = true;
        let _vec_map: Vec<_> = v85
            .into_iter()
            .map(|x| {
                //;
                let v89: Vec<char> = x;
                let v91: std::string::String = String::from_iter(v89);
                let v93: bool = true;
                v91
            })
            .collect::<Vec<_>>();
        let v95: Vec<std::string::String> = _vec_map;
        if if v0_1.clone() != string("") {
            v95.clone().len() as i32 <= 1_i32
        } else {
            false
        } {
            v20_1.l0.set(v53);
            ()
        } else {
            v20_1.l0.set(string(""));
            {
                let v107: bool = true;
                v95.into_iter().for_each(|x| {
                    //;
                    let v109: std::string::String = x;
                    let v111: bool = true;
                    near_sdk::log!("{}", v109);
                    let v113: bool = true;
                    let v115: bool = true;
                }); //;
                ()
            }
        }
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
        let v73: &str = inline_colorization::color_yellow;
        let v80: &str = &*v6;
        let v99: &str = inline_colorization::color_reset;
        let v101: std::string::String = format!("{}{}{}", v73, v80, v99);
        fable_library_rust::String_::fromString(v101)
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
        let v109: std::string::String = format!("{:#?}", v2_1);
        let v134: () = {
            File_system::closure6(
                v4.clone(),
                sprintf!("{}", fable_library_rust::String_::fromString(v109)),
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
        let v73: &str = inline_colorization::color_bright_black;
        let v80: &str = &*v6;
        let v99: &str = inline_colorization::color_reset;
        let v101: std::string::String = format!("{}{}{}", v73, v80, v99);
        fable_library_rust::String_::fromString(v101)
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
        let v73: &str = inline_colorization::color_bright_red;
        let v80: &str = &*v6;
        let v99: &str = inline_colorization::color_reset;
        let v101: std::string::String = format!("{}{}{}", v73, v80, v99);
        fable_library_rust::String_::fromString(v101)
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
    pub fn closure33(unitVar: (), v0_1: Option<()>) -> File_system::US11 {
        File_system::US11::US11_0(v0_1)
    }
    pub fn method52() -> Func1<Option<()>, File_system::US11> {
        Func1::new(move |v: Option<()>| File_system::closure33((), v))
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
        unbox::<Guid>(&defaultOf())
    }
    pub fn method57() -> string {
        unbox::<string>(&defaultOf())
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
        unbox::<string>(&defaultOf())
    }
    pub fn method63() -> string {
        string("CARGO_PKG_NAME")
    }
    pub fn method62() -> string {
        File_system::method2(File_system::method63())
    }
    pub fn method56(v0_1: Guid) -> string {
        unbox::<string>(&defaultOf())
    }
    pub fn method50() -> string {
        unbox::<string>(&defaultOf())
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
        let v75: std::string::String = format!("{:#?}", v1_1);
        let v100: () = {
            File_system::closure6(
                v3.clone(),
                sprintf!("{}", fable_library_rust::String_::fromString(v75)),
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
        let v8: Arc<Async<i64>> = defaultOf();
        let v34_1: Arc<Async<()>> = defaultOf();
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
            defaultOf::<std::rc::Rc<dyn IDisposable>>(),
            Lrc<dyn IDisposable>,
        )
    }
    pub fn closure34(unitVar: (), unitVar_1: ()) -> (string, LrcPtr<dyn IDisposable>) {
        let v0_1: string = File_system::method50();
        (v0_1.clone(), File_system::method64(v0_1))
    }
    pub fn method77(v0_1: string) -> Guid {
        unbox::<Guid>(&defaultOf())
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
        let v13: std::string::String = format!("{:#?}", v0_1);
        let v38: () = {
            File_system::closure6(
                v2_1.clone(),
                sprintf!("{}", fable_library_rust::String_::fromString(v13)),
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
            let v9582: Result<std::path::PathBuf, std::io::Error> = if File_system::method9(
                v0_1.clone(),
            ) {
                std::fs::read_link(&*v0_1.clone())
            } else {
                let v6394: Result<std::path::PathBuf, std::io::Error> =
                    std::fs::read_link(&*v0_1.clone());
                let v6395 = File_system::method79();
                let v6407: Result<std::path::PathBuf, string> = v6394.map_err(|x| v6395(x));
                fn v6410(v: std::path::PathBuf) -> File_system::US13 {
                    File_system::closure47((), v)
                }
                fn v6411(v_1: string) -> File_system::US13 {
                    File_system::closure48((), v_1)
                }
                let v6412: File_system::US13 = match &v6407 {
                    Err(v6407_1_0) => v6411(v6407_1_0.clone()),
                    Ok(v6407_0_0) => v6410(v6407_0_0.clone()),
                };
                match &v6412 {
                    File_system::US13::US13_0(v6412_0_0) => Ok(v6412_0_0.clone()),
                    File_system::US13::US13_1(v6412_1_0) => {
                        let v6428: string = v6412_1_0.clone();
                        let v6429: string = File_system::method19(v0_1.clone());
                        let v6430: Option<string> = File_system::method81(v0_1.clone());
                        let v6444: File_system::US1 = defaultValue(
                            File_system::US1::US1_1,
                            map(File_system::method4(), v6430),
                        );
                        if let File_system::US1::US1_0(v6444_0_0) = &v6444 {
                            let v6448: string = match &v6444 {
                                File_system::US1::US1_0(x) => x.clone(),
                                _ => unreachable!(),
                            };
                            if v0_1.clone() != string("") {
                                let v6454: Result<std::path::PathBuf, std::io::Error> =
                                    std::fs::read_link(&*v6448.clone());
                                let v6455 = File_system::method79();
                                let v6467: Result<std::path::PathBuf, string> =
                                    v6454.map_err(|x| v6455(x));
                                let v6470: File_system::US13 = match &v6467 {
                                    Err(v6467_1_0) => v6411(v6467_1_0.clone()),
                                    Ok(v6467_0_0) => v6410(v6467_0_0.clone()),
                                };
                                let v9356: Result<std::path::PathBuf, std::io::Error> = match &v6470
                                {
                                    File_system::US13::US13_0(v6470_0_0) => Ok(v6470_0_0.clone()),
                                    File_system::US13::US13_1(v6470_1_0) => {
                                        let v6486: string = v6470_1_0.clone();
                                        let v6487: string = File_system::method19(v6448.clone());
                                        let v6488: Option<string> =
                                            File_system::method81(v6448.clone());
                                        let v6502: File_system::US1 = defaultValue(
                                            File_system::US1::US1_1,
                                            map(File_system::method4(), v6488),
                                        );
                                        if let File_system::US1::US1_0(v6502_0_0) = &v6502 {
                                            let v6506: string = match &v6502 {
                                                File_system::US1::US1_0(x) => x.clone(),
                                                _ => unreachable!(),
                                            };
                                            if v6448.clone() != string("") {
                                                let v6511: Result<
                                                    std::path::PathBuf,
                                                    std::io::Error,
                                                > = std::fs::read_link(&*v6506.clone());
                                                let v6512 = File_system::method79();
                                                let v6524: Result<std::path::PathBuf, string> =
                                                    v6511.map_err(|x| v6512(x));
                                                let v6527: File_system::US13 = match &v6524 {
                                                    Err(v6524_1_0) => v6411(v6524_1_0.clone()),
                                                    Ok(v6524_0_0) => v6410(v6524_0_0.clone()),
                                                };
                                                let v9131: Result<
                                                    std::path::PathBuf,
                                                    std::io::Error,
                                                > = match &v6527 {
                                                    File_system::US13::US13_0(v6527_0_0) => {
                                                        Ok(v6527_0_0.clone())
                                                    }
                                                    File_system::US13::US13_1(v6527_1_0) => {
                                                        let v6543: string = v6527_1_0.clone();
                                                        let v6544: string =
                                                            File_system::method19(v6506.clone());
                                                        let v6545: Option<string> =
                                                            File_system::method81(v6506.clone());
                                                        let v6559: File_system::US1 = defaultValue(
                                                            File_system::US1::US1_1,
                                                            map(File_system::method4(), v6545),
                                                        );
                                                        if let File_system::US1::US1_0(v6559_0_0) =
                                                            &v6559
                                                        {
                                                            let v6563: string = match &v6559 {
                                                                File_system::US1::US1_0(x) => {
                                                                    x.clone()
                                                                }
                                                                _ => unreachable!(),
                                                            };
                                                            if v6506.clone() != string("") {
                                                                let v6568: Result<
                                                                    std::path::PathBuf,
                                                                    std::io::Error,
                                                                > = std::fs::read_link(
                                                                    &*v6563.clone(),
                                                                );
                                                                let v6569 = File_system::method79();
                                                                let v6581: Result<
                                                                    std::path::PathBuf,
                                                                    string,
                                                                > = v6568.map_err(|x| v6569(x));
                                                                let v6584: File_system::US13 =
                                                                    match &v6581 {
                                                                        Err(v6581_1_0) => {
                                                                            v6411(v6581_1_0.clone())
                                                                        }
                                                                        Ok(v6581_0_0) => {
                                                                            v6410(v6581_0_0.clone())
                                                                        }
                                                                    };
                                                                let v8906: Result<
                                                                    std::path::PathBuf,
                                                                    std::io::Error,
                                                                > = match &v6584 {
                                                                    File_system::US13::US13_0(
                                                                        v6584_0_0,
                                                                    ) => Ok(v6584_0_0.clone()),
                                                                    File_system::US13::US13_1(
                                                                        v6584_1_0,
                                                                    ) => {
                                                                        let v6600: string =
                                                                            v6584_1_0.clone();
                                                                        let v6601: string =
                                                                            File_system::method19(
                                                                                v6563.clone(),
                                                                            );
                                                                        let v6602: Option<string> =
                                                                            File_system::method81(
                                                                                v6563.clone(),
                                                                            );
                                                                        let v6616:
                                                                                                File_system::US1 =
                                                                                            defaultValue(File_system::US1::US1_1,
                                                                                                         map(File_system::method4(),
                                                                                                             v6602));
                                                                        if let File_system::US1::US1_0(v6616_0_0)
                                                                                               =
                                                                                               &v6616
                                                                                           {
                                                                                            let v6620:
                                                                                                    string =
                                                                                                match &v6616
                                                                                                    {
                                                                                                    File_system::US1::US1_0(x)
                                                                                                    =>
                                                                                                    x.clone(),
                                                                                                    _
                                                                                                    =>
                                                                                                    unreachable!(),
                                                                                                };
                                                                                            if v6563.clone()
                                                                                                   !=
                                                                                                   string("")
                                                                                               {
                                                                                                let v6625:
                                                                                                        Result<std::path::PathBuf,
                                                                                                               std::io::Error> =
                                                                                                    std::fs::read_link(&*v6620.clone());
                                                                                                let v6626 =
                                                                                                    File_system::method79();
                                                                                                let v6638:
                                                                                                        Result<std::path::PathBuf,
                                                                                                               string> =
                                                                                                    v6625.map_err(|x| v6626(x));
                                                                                                let v6641:
                                                                                                        File_system::US13 =
                                                                                                    match &v6638
                                                                                                        {
                                                                                                        Err(v6638_1_0)
                                                                                                        =>
                                                                                                        v6411(v6638_1_0.clone()),
                                                                                                        Ok(v6638_0_0)
                                                                                                        =>
                                                                                                        v6410(v6638_0_0.clone()),
                                                                                                    };
                                                                                                let v8681:
                                                                                                        Result<std::path::PathBuf,
                                                                                                               std::io::Error> =
                                                                                                    match &v6641
                                                                                                        {
                                                                                                        File_system::US13::US13_0(v6641_0_0)
                                                                                                        =>
                                                                                                        Ok(v6641_0_0.clone()),
                                                                                                        File_system::US13::US13_1(v6641_1_0)
                                                                                                        =>
                                                                                                        {
                                                                                                            let v6657:
                                                                                                                    string =
                                                                                                                v6641_1_0.clone();
                                                                                                            let v6658:
                                                                                                                    string =
                                                                                                                File_system::method19(v6620.clone());
                                                                                                            let v6659:
                                                                                                                    Option<string> =
                                                                                                                File_system::method81(v6620.clone());
                                                                                                            let v6673:
                                                                                                                    File_system::US1 =
                                                                                                                defaultValue(File_system::US1::US1_1,
                                                                                                                             map(File_system::method4(),
                                                                                                                                 v6659));
                                                                                                            if let File_system::US1::US1_0(v6673_0_0)
                                                                                                                   =
                                                                                                                   &v6673
                                                                                                               {
                                                                                                                let v6677:
                                                                                                                        string =
                                                                                                                    match &v6673
                                                                                                                        {
                                                                                                                        File_system::US1::US1_0(x)
                                                                                                                        =>
                                                                                                                        x.clone(),
                                                                                                                        _
                                                                                                                        =>
                                                                                                                        unreachable!(),
                                                                                                                    };
                                                                                                                if v6620.clone()
                                                                                                                       !=
                                                                                                                       string("")
                                                                                                                   {
                                                                                                                    let v6682:
                                                                                                                            Result<std::path::PathBuf,
                                                                                                                                   std::io::Error> =
                                                                                                                        std::fs::read_link(&*v6677.clone());
                                                                                                                    let v6683 =
                                                                                                                        File_system::method79();
                                                                                                                    let v6695:
                                                                                                                            Result<std::path::PathBuf,
                                                                                                                                   string> =
                                                                                                                        v6682.map_err(|x| v6683(x));
                                                                                                                    let v6698:
                                                                                                                            File_system::US13 =
                                                                                                                        match &v6695
                                                                                                                            {
                                                                                                                            Err(v6695_1_0)
                                                                                                                            =>
                                                                                                                            v6411(v6695_1_0.clone()),
                                                                                                                            Ok(v6695_0_0)
                                                                                                                            =>
                                                                                                                            v6410(v6695_0_0.clone()),
                                                                                                                        };
                                                                                                                    let v8456:
                                                                                                                            Result<std::path::PathBuf,
                                                                                                                                   std::io::Error> =
                                                                                                                        match &v6698
                                                                                                                            {
                                                                                                                            File_system::US13::US13_0(v6698_0_0)
                                                                                                                            =>
                                                                                                                            Ok(v6698_0_0.clone()),
                                                                                                                            File_system::US13::US13_1(v6698_1_0)
                                                                                                                            =>
                                                                                                                            {
                                                                                                                                let v6714:
                                                                                                                                        string =
                                                                                                                                    v6698_1_0.clone();
                                                                                                                                let v6715:
                                                                                                                                        string =
                                                                                                                                    File_system::method19(v6677.clone());
                                                                                                                                let v6716:
                                                                                                                                        Option<string> =
                                                                                                                                    File_system::method81(v6677.clone());
                                                                                                                                let v6730:
                                                                                                                                        File_system::US1 =
                                                                                                                                    defaultValue(File_system::US1::US1_1,
                                                                                                                                                 map(File_system::method4(),
                                                                                                                                                     v6716));
                                                                                                                                if let File_system::US1::US1_0(v6730_0_0)
                                                                                                                                       =
                                                                                                                                       &v6730
                                                                                                                                   {
                                                                                                                                    let v6734:
                                                                                                                                            string =
                                                                                                                                        match &v6730
                                                                                                                                            {
                                                                                                                                            File_system::US1::US1_0(x)
                                                                                                                                            =>
                                                                                                                                            x.clone(),
                                                                                                                                            _
                                                                                                                                            =>
                                                                                                                                            unreachable!(),
                                                                                                                                        };
                                                                                                                                    if v6677.clone()
                                                                                                                                           !=
                                                                                                                                           string("")
                                                                                                                                       {
                                                                                                                                        let v6739:
                                                                                                                                                Result<std::path::PathBuf,
                                                                                                                                                       std::io::Error> =
                                                                                                                                            std::fs::read_link(&*v6734.clone());
                                                                                                                                        let v6740 =
                                                                                                                                            File_system::method79();
                                                                                                                                        let v6752:
                                                                                                                                                Result<std::path::PathBuf,
                                                                                                                                                       string> =
                                                                                                                                            v6739.map_err(|x| v6740(x));
                                                                                                                                        let v6755:
                                                                                                                                                File_system::US13 =
                                                                                                                                            match &v6752
                                                                                                                                                {
                                                                                                                                                Err(v6752_1_0)
                                                                                                                                                =>
                                                                                                                                                v6411(v6752_1_0.clone()),
                                                                                                                                                Ok(v6752_0_0)
                                                                                                                                                =>
                                                                                                                                                v6410(v6752_0_0.clone()),
                                                                                                                                            };
                                                                                                                                        let v8231:
                                                                                                                                                Result<std::path::PathBuf,
                                                                                                                                                       std::io::Error> =
                                                                                                                                            match &v6755
                                                                                                                                                {
                                                                                                                                                File_system::US13::US13_0(v6755_0_0)
                                                                                                                                                =>
                                                                                                                                                Ok(v6755_0_0.clone()),
                                                                                                                                                File_system::US13::US13_1(v6755_1_0)
                                                                                                                                                =>
                                                                                                                                                {
                                                                                                                                                    let v6771:
                                                                                                                                                            string =
                                                                                                                                                        v6755_1_0.clone();
                                                                                                                                                    let v6772:
                                                                                                                                                            string =
                                                                                                                                                        File_system::method19(v6734.clone());
                                                                                                                                                    let v6773:
                                                                                                                                                            Option<string> =
                                                                                                                                                        File_system::method81(v6734.clone());
                                                                                                                                                    let v6787:
                                                                                                                                                            File_system::US1 =
                                                                                                                                                        defaultValue(File_system::US1::US1_1,
                                                                                                                                                                     map(File_system::method4(),
                                                                                                                                                                         v6773));
                                                                                                                                                    if let File_system::US1::US1_0(v6787_0_0)
                                                                                                                                                           =
                                                                                                                                                           &v6787
                                                                                                                                                       {
                                                                                                                                                        let v6791:
                                                                                                                                                                string =
                                                                                                                                                            match &v6787
                                                                                                                                                                {
                                                                                                                                                                File_system::US1::US1_0(x)
                                                                                                                                                                =>
                                                                                                                                                                x.clone(),
                                                                                                                                                                _
                                                                                                                                                                =>
                                                                                                                                                                unreachable!(),
                                                                                                                                                            };
                                                                                                                                                        if v6734.clone()
                                                                                                                                                               !=
                                                                                                                                                               string("")
                                                                                                                                                           {
                                                                                                                                                            let v6796:
                                                                                                                                                                    Result<std::path::PathBuf,
                                                                                                                                                                           std::io::Error> =
                                                                                                                                                                std::fs::read_link(&*v6791.clone());
                                                                                                                                                            let v6797 =
                                                                                                                                                                File_system::method79();
                                                                                                                                                            let v6809:
                                                                                                                                                                    Result<std::path::PathBuf,
                                                                                                                                                                           string> =
                                                                                                                                                                v6796.map_err(|x| v6797(x));
                                                                                                                                                            let v6812:
                                                                                                                                                                    File_system::US13 =
                                                                                                                                                                match &v6809
                                                                                                                                                                    {
                                                                                                                                                                    Err(v6809_1_0)
                                                                                                                                                                    =>
                                                                                                                                                                    v6411(v6809_1_0.clone()),
                                                                                                                                                                    Ok(v6809_0_0)
                                                                                                                                                                    =>
                                                                                                                                                                    v6410(v6809_0_0.clone()),
                                                                                                                                                                };
                                                                                                                                                            let v8006:
                                                                                                                                                                    Result<std::path::PathBuf,
                                                                                                                                                                           std::io::Error> =
                                                                                                                                                                match &v6812
                                                                                                                                                                    {
                                                                                                                                                                    File_system::US13::US13_0(v6812_0_0)
                                                                                                                                                                    =>
                                                                                                                                                                    Ok(v6812_0_0.clone()),
                                                                                                                                                                    File_system::US13::US13_1(v6812_1_0)
                                                                                                                                                                    =>
                                                                                                                                                                    {
                                                                                                                                                                        let v6828:
                                                                                                                                                                                string =
                                                                                                                                                                            v6812_1_0.clone();
                                                                                                                                                                        let v6829:
                                                                                                                                                                                string =
                                                                                                                                                                            File_system::method19(v6791.clone());
                                                                                                                                                                        let v6830:
                                                                                                                                                                                Option<string> =
                                                                                                                                                                            File_system::method81(v6791.clone());
                                                                                                                                                                        let v6844:
                                                                                                                                                                                File_system::US1 =
                                                                                                                                                                            defaultValue(File_system::US1::US1_1,
                                                                                                                                                                                         map(File_system::method4(),
                                                                                                                                                                                             v6830));
                                                                                                                                                                        if let File_system::US1::US1_0(v6844_0_0)
                                                                                                                                                                               =
                                                                                                                                                                               &v6844
                                                                                                                                                                           {
                                                                                                                                                                            let v6848:
                                                                                                                                                                                    string =
                                                                                                                                                                                match &v6844
                                                                                                                                                                                    {
                                                                                                                                                                                    File_system::US1::US1_0(x)
                                                                                                                                                                                    =>
                                                                                                                                                                                    x.clone(),
                                                                                                                                                                                    _
                                                                                                                                                                                    =>
                                                                                                                                                                                    unreachable!(),
                                                                                                                                                                                };
                                                                                                                                                                            if v6791.clone()
                                                                                                                                                                                   !=
                                                                                                                                                                                   string("")
                                                                                                                                                                               {
                                                                                                                                                                                let v6853:
                                                                                                                                                                                        Result<std::path::PathBuf,
                                                                                                                                                                                               std::io::Error> =
                                                                                                                                                                                    std::fs::read_link(&*v6848.clone());
                                                                                                                                                                                let v6854 =
                                                                                                                                                                                    File_system::method79();
                                                                                                                                                                                let v6866:
                                                                                                                                                                                        Result<std::path::PathBuf,
                                                                                                                                                                                               string> =
                                                                                                                                                                                    v6853.map_err(|x| v6854(x));
                                                                                                                                                                                let v6869:
                                                                                                                                                                                        File_system::US13 =
                                                                                                                                                                                    match &v6866
                                                                                                                                                                                        {
                                                                                                                                                                                        Err(v6866_1_0)
                                                                                                                                                                                        =>
                                                                                                                                                                                        v6411(v6866_1_0.clone()),
                                                                                                                                                                                        Ok(v6866_0_0)
                                                                                                                                                                                        =>
                                                                                                                                                                                        v6410(v6866_0_0.clone()),
                                                                                                                                                                                    };
                                                                                                                                                                                let v7781:
                                                                                                                                                                                        Result<std::path::PathBuf,
                                                                                                                                                                                               std::io::Error> =
                                                                                                                                                                                    match &v6869
                                                                                                                                                                                        {
                                                                                                                                                                                        File_system::US13::US13_0(v6869_0_0)
                                                                                                                                                                                        =>
                                                                                                                                                                                        Ok(v6869_0_0.clone()),
                                                                                                                                                                                        File_system::US13::US13_1(v6869_1_0)
                                                                                                                                                                                        =>
                                                                                                                                                                                        {
                                                                                                                                                                                            let v6885:
                                                                                                                                                                                                    string =
                                                                                                                                                                                                v6869_1_0.clone();
                                                                                                                                                                                            let v6886:
                                                                                                                                                                                                    string =
                                                                                                                                                                                                File_system::method19(v6848.clone());
                                                                                                                                                                                            let v6887:
                                                                                                                                                                                                    Option<string> =
                                                                                                                                                                                                File_system::method81(v6848.clone());
                                                                                                                                                                                            let v6901:
                                                                                                                                                                                                    File_system::US1 =
                                                                                                                                                                                                defaultValue(File_system::US1::US1_1,
                                                                                                                                                                                                             map(File_system::method4(),
                                                                                                                                                                                                                 v6887));
                                                                                                                                                                                            if let File_system::US1::US1_0(v6901_0_0)
                                                                                                                                                                                                   =
                                                                                                                                                                                                   &v6901
                                                                                                                                                                                               {
                                                                                                                                                                                                let v6905:
                                                                                                                                                                                                        string =
                                                                                                                                                                                                    match &v6901
                                                                                                                                                                                                        {
                                                                                                                                                                                                        File_system::US1::US1_0(x)
                                                                                                                                                                                                        =>
                                                                                                                                                                                                        x.clone(),
                                                                                                                                                                                                        _
                                                                                                                                                                                                        =>
                                                                                                                                                                                                        unreachable!(),
                                                                                                                                                                                                    };
                                                                                                                                                                                                if v6848.clone()
                                                                                                                                                                                                       !=
                                                                                                                                                                                                       string("")
                                                                                                                                                                                                   {
                                                                                                                                                                                                    let v6910:
                                                                                                                                                                                                            Result<std::path::PathBuf,
                                                                                                                                                                                                                   std::io::Error> =
                                                                                                                                                                                                        std::fs::read_link(&*v6905.clone());
                                                                                                                                                                                                    let v6911 =
                                                                                                                                                                                                        File_system::method79();
                                                                                                                                                                                                    let v6923:
                                                                                                                                                                                                            Result<std::path::PathBuf,
                                                                                                                                                                                                                   string> =
                                                                                                                                                                                                        v6910.map_err(|x| v6911(x));
                                                                                                                                                                                                    let v6926:
                                                                                                                                                                                                            File_system::US13 =
                                                                                                                                                                                                        match &v6923
                                                                                                                                                                                                            {
                                                                                                                                                                                                            Err(v6923_1_0)
                                                                                                                                                                                                            =>
                                                                                                                                                                                                            v6411(v6923_1_0.clone()),
                                                                                                                                                                                                            Ok(v6923_0_0)
                                                                                                                                                                                                            =>
                                                                                                                                                                                                            v6410(v6923_0_0.clone()),
                                                                                                                                                                                                        };
                                                                                                                                                                                                    let v7556:
                                                                                                                                                                                                            Result<std::path::PathBuf,
                                                                                                                                                                                                                   std::io::Error> =
                                                                                                                                                                                                        match &v6926
                                                                                                                                                                                                            {
                                                                                                                                                                                                            File_system::US13::US13_0(v6926_0_0)
                                                                                                                                                                                                            =>
                                                                                                                                                                                                            Ok(v6926_0_0.clone()),
                                                                                                                                                                                                            File_system::US13::US13_1(v6926_1_0)
                                                                                                                                                                                                            =>
                                                                                                                                                                                                            {
                                                                                                                                                                                                                let v6942:
                                                                                                                                                                                                                        string =
                                                                                                                                                                                                                    v6926_1_0.clone();
                                                                                                                                                                                                                let v6943:
                                                                                                                                                                                                                        string =
                                                                                                                                                                                                                    File_system::method19(v6905.clone());
                                                                                                                                                                                                                let v6944:
                                                                                                                                                                                                                        Option<string> =
                                                                                                                                                                                                                    File_system::method81(v6905.clone());
                                                                                                                                                                                                                let v6958:
                                                                                                                                                                                                                        File_system::US1 =
                                                                                                                                                                                                                    defaultValue(File_system::US1::US1_1,
                                                                                                                                                                                                                                 map(File_system::method4(),
                                                                                                                                                                                                                                     v6944));
                                                                                                                                                                                                                if let File_system::US1::US1_0(v6958_0_0)
                                                                                                                                                                                                                       =
                                                                                                                                                                                                                       &v6958
                                                                                                                                                                                                                   {
                                                                                                                                                                                                                    let v6962:
                                                                                                                                                                                                                            string =
                                                                                                                                                                                                                        match &v6958
                                                                                                                                                                                                                            {
                                                                                                                                                                                                                            File_system::US1::US1_0(x)
                                                                                                                                                                                                                            =>
                                                                                                                                                                                                                            x.clone(),
                                                                                                                                                                                                                            _
                                                                                                                                                                                                                            =>
                                                                                                                                                                                                                            unreachable!(),
                                                                                                                                                                                                                        };
                                                                                                                                                                                                                    if v6905.clone()
                                                                                                                                                                                                                           !=
                                                                                                                                                                                                                           string("")
                                                                                                                                                                                                                       {
                                                                                                                                                                                                                        let v6967:
                                                                                                                                                                                                                                Result<std::path::PathBuf,
                                                                                                                                                                                                                                       std::io::Error> =
                                                                                                                                                                                                                            std::fs::read_link(&*v6962.clone());
                                                                                                                                                                                                                        let v6968 =
                                                                                                                                                                                                                            File_system::method79();
                                                                                                                                                                                                                        let v6980:
                                                                                                                                                                                                                                Result<std::path::PathBuf,
                                                                                                                                                                                                                                       string> =
                                                                                                                                                                                                                            v6967.map_err(|x| v6968(x));
                                                                                                                                                                                                                        let v6983:
                                                                                                                                                                                                                                File_system::US13 =
                                                                                                                                                                                                                            match &v6980
                                                                                                                                                                                                                                {
                                                                                                                                                                                                                                Err(v6980_1_0)
                                                                                                                                                                                                                                =>
                                                                                                                                                                                                                                v6411(v6980_1_0.clone()),
                                                                                                                                                                                                                                Ok(v6980_0_0)
                                                                                                                                                                                                                                =>
                                                                                                                                                                                                                                v6410(v6980_0_0.clone()),
                                                                                                                                                                                                                            };
                                                                                                                                                                                                                        let v7331:
                                                                                                                                                                                                                                Result<std::path::PathBuf,
                                                                                                                                                                                                                                       std::io::Error> =
                                                                                                                                                                                                                            match &v6983
                                                                                                                                                                                                                                {
                                                                                                                                                                                                                                File_system::US13::US13_0(v6983_0_0)
                                                                                                                                                                                                                                =>
                                                                                                                                                                                                                                Ok(v6983_0_0.clone()),
                                                                                                                                                                                                                                File_system::US13::US13_1(v6983_1_0)
                                                                                                                                                                                                                                =>
                                                                                                                                                                                                                                {
                                                                                                                                                                                                                                    let v6999:
                                                                                                                                                                                                                                            string =
                                                                                                                                                                                                                                        v6983_1_0.clone();
                                                                                                                                                                                                                                    let v7000:
                                                                                                                                                                                                                                            string =
                                                                                                                                                                                                                                        File_system::method19(v6962.clone());
                                                                                                                                                                                                                                    let v7001:
                                                                                                                                                                                                                                            Option<string> =
                                                                                                                                                                                                                                        File_system::method81(v6962.clone());
                                                                                                                                                                                                                                    let v7015:
                                                                                                                                                                                                                                            File_system::US1 =
                                                                                                                                                                                                                                        defaultValue(File_system::US1::US1_1,
                                                                                                                                                                                                                                                     map(File_system::method4(),
                                                                                                                                                                                                                                                         v7001));
                                                                                                                                                                                                                                    if let File_system::US1::US1_0(v7015_0_0)
                                                                                                                                                                                                                                           =
                                                                                                                                                                                                                                           &v7015
                                                                                                                                                                                                                                       {
                                                                                                                                                                                                                                        let v7019:
                                                                                                                                                                                                                                                string =
                                                                                                                                                                                                                                            match &v7015
                                                                                                                                                                                                                                                {
                                                                                                                                                                                                                                                File_system::US1::US1_0(x)
                                                                                                                                                                                                                                                =>
                                                                                                                                                                                                                                                x.clone(),
                                                                                                                                                                                                                                                _
                                                                                                                                                                                                                                                =>
                                                                                                                                                                                                                                                unreachable!(),
                                                                                                                                                                                                                                            };
                                                                                                                                                                                                                                        if v6962.clone()
                                                                                                                                                                                                                                               !=
                                                                                                                                                                                                                                               string("")
                                                                                                                                                                                                                                           {
                                                                                                                                                                                                                                            let v7024:
                                                                                                                                                                                                                                                    Result<std::path::PathBuf,
                                                                                                                                                                                                                                                           std::io::Error> =
                                                                                                                                                                                                                                                std::fs::read_link(&*v7019.clone());
                                                                                                                                                                                                                                            let v7025 =
                                                                                                                                                                                                                                                File_system::method79();
                                                                                                                                                                                                                                            let v7037:
                                                                                                                                                                                                                                                    Result<std::path::PathBuf,
                                                                                                                                                                                                                                                           string> =
                                                                                                                                                                                                                                                v7024.map_err(|x| v7025(x));
                                                                                                                                                                                                                                            let v7040:
                                                                                                                                                                                                                                                    File_system::US13 =
                                                                                                                                                                                                                                                match &v7037
                                                                                                                                                                                                                                                    {
                                                                                                                                                                                                                                                    Err(v7037_1_0)
                                                                                                                                                                                                                                                    =>
                                                                                                                                                                                                                                                    v6411(v7037_1_0.clone()),
                                                                                                                                                                                                                                                    Ok(v7037_0_0)
                                                                                                                                                                                                                                                    =>
                                                                                                                                                                                                                                                    v6410(v7037_0_0.clone()),
                                                                                                                                                                                                                                                };
                                                                                                                                                                                                                                            let v7106:
                                                                                                                                                                                                                                                    Result<std::path::PathBuf,
                                                                                                                                                                                                                                                           std::io::Error> =
                                                                                                                                                                                                                                                match &v7040
                                                                                                                                                                                                                                                    {
                                                                                                                                                                                                                                                    File_system::US13::US13_0(v7040_0_0)
                                                                                                                                                                                                                                                    =>
                                                                                                                                                                                                                                                    Ok(v7040_0_0.clone()),
                                                                                                                                                                                                                                                    _
                                                                                                                                                                                                                                                    =>
                                                                                                                                                                                                                                                    {
                                                                                                                                                                                                                                                        let v7057:
                                                                                                                                                                                                                                                                string =
                                                                                                                                                                                                                                                            File_system::method19(v7019.clone());
                                                                                                                                                                                                                                                        let v7058:
                                                                                                                                                                                                                                                                Option<string> =
                                                                                                                                                                                                                                                            File_system::method81(v7019.clone());
                                                                                                                                                                                                                                                        let v7072:
                                                                                                                                                                                                                                                                File_system::US1 =
                                                                                                                                                                                                                                                            defaultValue(File_system::US1::US1_1,
                                                                                                                                                                                                                                                                         map(File_system::method4(),
                                                                                                                                                                                                                                                                             v7058));
                                                                                                                                                                                                                                                        let v7076:
                                                                                                                                                                                                                                                                string =
                                                                                                                                                                                                                                                            sprintf!("file_system.read_link / path: {} / n: {} / path\': {} / name: {}",
                                                                                                                                                                                                                                                                     v0_1.clone(),
                                                                                                                                                                                                                                                                     11_u8,
                                                                                                                                                                                                                                                                     v7019.clone(),
                                                                                                                                                                                                                                                                     v7057);
                                                                                                                                                                                                                                                        let v7083:
                                                                                                                                                                                                                                                                std::io::Error =
                                                                                                                                                                                                                                                            std::io::Error::new(std::io::ErrorKind::Other, &*v7076);
                                                                                                                                                                                                                                                        Err(v7083)
                                                                                                                                                                                                                                                    }
                                                                                                                                                                                                                                                };
                                                                                                                                                                                                                                            let v7107 =
                                                                                                                                                                                                                                                File_system::method79();
                                                                                                                                                                                                                                            let v7119:
                                                                                                                                                                                                                                                    Result<std::path::PathBuf,
                                                                                                                                                                                                                                                           string> =
                                                                                                                                                                                                                                                v7106.map_err(|x| v7107(x));
                                                                                                                                                                                                                                            let v7122:
                                                                                                                                                                                                                                                    File_system::US13 =
                                                                                                                                                                                                                                                match &v7119
                                                                                                                                                                                                                                                    {
                                                                                                                                                                                                                                                    Err(v7119_1_0)
                                                                                                                                                                                                                                                    =>
                                                                                                                                                                                                                                                    v6411(v7119_1_0.clone()),
                                                                                                                                                                                                                                                    Ok(v7119_0_0)
                                                                                                                                                                                                                                                    =>
                                                                                                                                                                                                                                                    v6410(v7119_0_0.clone()),
                                                                                                                                                                                                                                                };
                                                                                                                                                                                                                                            match &v7122
                                                                                                                                                                                                                                                {
                                                                                                                                                                                                                                                File_system::US13::US13_0(v7122_0_0)
                                                                                                                                                                                                                                                =>
                                                                                                                                                                                                                                                {
                                                                                                                                                                                                                                                    let v7151:
                                                                                                                                                                                                                                                            string =
                                                                                                                                                                                                                                                        File_system::method59(toString(v7122_0_0.clone().display()),
                                                                                                                                                                                                                                                                              v7000.clone());
                                                                                                                                                                                                                                                    let v7158:
                                                                                                                                                                                                                                                            &str =
                                                                                                                                                                                                                                                        &*v7151;
                                                                                                                                                                                                                                                    let v7182:
                                                                                                                                                                                                                                                            std::string::String =
                                                                                                                                                                                                                                                        String::from(v7158);
                                                                                                                                                                                                                                                    let v7206:
                                                                                                                                                                                                                                                            std::path::PathBuf =
                                                                                                                                                                                                                                                        std::path::PathBuf::from(v7182);
                                                                                                                                                                                                                                                    Ok(v7206)
                                                                                                                                                                                                                                                }
                                                                                                                                                                                                                                                File_system::US13::US13_1(v7122_1_0)
                                                                                                                                                                                                                                                =>
                                                                                                                                                                                                                                                {
                                                                                                                                                                                                                                                    let v7239:
                                                                                                                                                                                                                                                            string =
                                                                                                                                                                                                                                                        sprintf!("file_system.read_link / error\': {} / error: {} / name: {}",
                                                                                                                                                                                                                                                                 v7122_1_0.clone(),
                                                                                                                                                                                                                                                                 v6999.clone(),
                                                                                                                                                                                                                                                                 v7000.clone());
                                                                                                                                                                                                                                                    let v7246:
                                                                                                                                                                                                                                                            std::io::Error =
                                                                                                                                                                                                                                                        std::io::Error::new(std::io::ErrorKind::Other, &*v7239);
                                                                                                                                                                                                                                                    Err(v7246)
                                                                                                                                                                                                                                                }
                                                                                                                                                                                                                                            }
                                                                                                                                                                                                                                        } else {
                                                                                                                                                                                                                                            let v7270:
                                                                                                                                                                                                                                                    string =
                                                                                                                                                                                                                                                sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                                                                                                                                                                                                                         v0_1.clone(),
                                                                                                                                                                                                                                                         v6999.clone(),
                                                                                                                                                                                                                                                         v6962.clone(),
                                                                                                                                                                                                                                                         v7000.clone());
                                                                                                                                                                                                                                            let v7277:
                                                                                                                                                                                                                                                    std::io::Error =
                                                                                                                                                                                                                                                std::io::Error::new(std::io::ErrorKind::Other, &*v7270);
                                                                                                                                                                                                                                            Err(v7277)
                                                                                                                                                                                                                                        }
                                                                                                                                                                                                                                    } else {
                                                                                                                                                                                                                                        let v7300:
                                                                                                                                                                                                                                                string =
                                                                                                                                                                                                                                            sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                                                                                                                                                                                                                     v0_1.clone(),
                                                                                                                                                                                                                                                     v6999,
                                                                                                                                                                                                                                                     v6962.clone(),
                                                                                                                                                                                                                                                     v7000.clone());
                                                                                                                                                                                                                                        let v7307:
                                                                                                                                                                                                                                                std::io::Error =
                                                                                                                                                                                                                                            std::io::Error::new(std::io::ErrorKind::Other, &*v7300);
                                                                                                                                                                                                                                        Err(v7307)
                                                                                                                                                                                                                                    }
                                                                                                                                                                                                                                }
                                                                                                                                                                                                                            };
                                                                                                                                                                                                                        let v7332 =
                                                                                                                                                                                                                            File_system::method79();
                                                                                                                                                                                                                        let v7344:
                                                                                                                                                                                                                                Result<std::path::PathBuf,
                                                                                                                                                                                                                                       string> =
                                                                                                                                                                                                                            v7331.map_err(|x| v7332(x));
                                                                                                                                                                                                                        let v7347:
                                                                                                                                                                                                                                File_system::US13 =
                                                                                                                                                                                                                            match &v7344
                                                                                                                                                                                                                                {
                                                                                                                                                                                                                                Err(v7344_1_0)
                                                                                                                                                                                                                                =>
                                                                                                                                                                                                                                v6411(v7344_1_0.clone()),
                                                                                                                                                                                                                                Ok(v7344_0_0)
                                                                                                                                                                                                                                =>
                                                                                                                                                                                                                                v6410(v7344_0_0.clone()),
                                                                                                                                                                                                                            };
                                                                                                                                                                                                                        match &v7347
                                                                                                                                                                                                                            {
                                                                                                                                                                                                                            File_system::US13::US13_0(v7347_0_0)
                                                                                                                                                                                                                            =>
                                                                                                                                                                                                                            {
                                                                                                                                                                                                                                let v7376:
                                                                                                                                                                                                                                        string =
                                                                                                                                                                                                                                    File_system::method59(toString(v7347_0_0.clone().display()),
                                                                                                                                                                                                                                                          v6943.clone());
                                                                                                                                                                                                                                let v7383:
                                                                                                                                                                                                                                        &str =
                                                                                                                                                                                                                                    &*v7376;
                                                                                                                                                                                                                                let v7407:
                                                                                                                                                                                                                                        std::string::String =
                                                                                                                                                                                                                                    String::from(v7383);
                                                                                                                                                                                                                                let v7431:
                                                                                                                                                                                                                                        std::path::PathBuf =
                                                                                                                                                                                                                                    std::path::PathBuf::from(v7407);
                                                                                                                                                                                                                                Ok(v7431)
                                                                                                                                                                                                                            }
                                                                                                                                                                                                                            File_system::US13::US13_1(v7347_1_0)
                                                                                                                                                                                                                            =>
                                                                                                                                                                                                                            {
                                                                                                                                                                                                                                let v7464:
                                                                                                                                                                                                                                        string =
                                                                                                                                                                                                                                    sprintf!("file_system.read_link / error\': {} / error: {} / name: {}",
                                                                                                                                                                                                                                             v7347_1_0.clone(),
                                                                                                                                                                                                                                             v6942.clone(),
                                                                                                                                                                                                                                             v6943.clone());
                                                                                                                                                                                                                                let v7471:
                                                                                                                                                                                                                                        std::io::Error =
                                                                                                                                                                                                                                    std::io::Error::new(std::io::ErrorKind::Other, &*v7464);
                                                                                                                                                                                                                                Err(v7471)
                                                                                                                                                                                                                            }
                                                                                                                                                                                                                        }
                                                                                                                                                                                                                    } else {
                                                                                                                                                                                                                        let v7495:
                                                                                                                                                                                                                                string =
                                                                                                                                                                                                                            sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                                                                                                                                                                                                     v0_1.clone(),
                                                                                                                                                                                                                                     v6942.clone(),
                                                                                                                                                                                                                                     v6905.clone(),
                                                                                                                                                                                                                                     v6943.clone());
                                                                                                                                                                                                                        let v7502:
                                                                                                                                                                                                                                std::io::Error =
                                                                                                                                                                                                                            std::io::Error::new(std::io::ErrorKind::Other, &*v7495);
                                                                                                                                                                                                                        Err(v7502)
                                                                                                                                                                                                                    }
                                                                                                                                                                                                                } else {
                                                                                                                                                                                                                    let v7525:
                                                                                                                                                                                                                            string =
                                                                                                                                                                                                                        sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                                                                                                                                                                                                 v0_1.clone(),
                                                                                                                                                                                                                                 v6942,
                                                                                                                                                                                                                                 v6905.clone(),
                                                                                                                                                                                                                                 v6943.clone());
                                                                                                                                                                                                                    let v7532:
                                                                                                                                                                                                                            std::io::Error =
                                                                                                                                                                                                                        std::io::Error::new(std::io::ErrorKind::Other, &*v7525);
                                                                                                                                                                                                                    Err(v7532)
                                                                                                                                                                                                                }
                                                                                                                                                                                                            }
                                                                                                                                                                                                        };
                                                                                                                                                                                                    let v7557 =
                                                                                                                                                                                                        File_system::method79();
                                                                                                                                                                                                    let v7569:
                                                                                                                                                                                                            Result<std::path::PathBuf,
                                                                                                                                                                                                                   string> =
                                                                                                                                                                                                        v7556.map_err(|x| v7557(x));
                                                                                                                                                                                                    let v7572:
                                                                                                                                                                                                            File_system::US13 =
                                                                                                                                                                                                        match &v7569
                                                                                                                                                                                                            {
                                                                                                                                                                                                            Err(v7569_1_0)
                                                                                                                                                                                                            =>
                                                                                                                                                                                                            v6411(v7569_1_0.clone()),
                                                                                                                                                                                                            Ok(v7569_0_0)
                                                                                                                                                                                                            =>
                                                                                                                                                                                                            v6410(v7569_0_0.clone()),
                                                                                                                                                                                                        };
                                                                                                                                                                                                    match &v7572
                                                                                                                                                                                                        {
                                                                                                                                                                                                        File_system::US13::US13_0(v7572_0_0)
                                                                                                                                                                                                        =>
                                                                                                                                                                                                        {
                                                                                                                                                                                                            let v7601:
                                                                                                                                                                                                                    string =
                                                                                                                                                                                                                File_system::method59(toString(v7572_0_0.clone().display()),
                                                                                                                                                                                                                                      v6886.clone());
                                                                                                                                                                                                            let v7608:
                                                                                                                                                                                                                    &str =
                                                                                                                                                                                                                &*v7601;
                                                                                                                                                                                                            let v7632:
                                                                                                                                                                                                                    std::string::String =
                                                                                                                                                                                                                String::from(v7608);
                                                                                                                                                                                                            let v7656:
                                                                                                                                                                                                                    std::path::PathBuf =
                                                                                                                                                                                                                std::path::PathBuf::from(v7632);
                                                                                                                                                                                                            Ok(v7656)
                                                                                                                                                                                                        }
                                                                                                                                                                                                        File_system::US13::US13_1(v7572_1_0)
                                                                                                                                                                                                        =>
                                                                                                                                                                                                        {
                                                                                                                                                                                                            let v7689:
                                                                                                                                                                                                                    string =
                                                                                                                                                                                                                sprintf!("file_system.read_link / error\': {} / error: {} / name: {}",
                                                                                                                                                                                                                         v7572_1_0.clone(),
                                                                                                                                                                                                                         v6885.clone(),
                                                                                                                                                                                                                         v6886.clone());
                                                                                                                                                                                                            let v7696:
                                                                                                                                                                                                                    std::io::Error =
                                                                                                                                                                                                                std::io::Error::new(std::io::ErrorKind::Other, &*v7689);
                                                                                                                                                                                                            Err(v7696)
                                                                                                                                                                                                        }
                                                                                                                                                                                                    }
                                                                                                                                                                                                } else {
                                                                                                                                                                                                    let v7720:
                                                                                                                                                                                                            string =
                                                                                                                                                                                                        sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                                                                                                                                                                                 v0_1.clone(),
                                                                                                                                                                                                                 v6885.clone(),
                                                                                                                                                                                                                 v6848.clone(),
                                                                                                                                                                                                                 v6886.clone());
                                                                                                                                                                                                    let v7727:
                                                                                                                                                                                                            std::io::Error =
                                                                                                                                                                                                        std::io::Error::new(std::io::ErrorKind::Other, &*v7720);
                                                                                                                                                                                                    Err(v7727)
                                                                                                                                                                                                }
                                                                                                                                                                                            } else {
                                                                                                                                                                                                let v7750:
                                                                                                                                                                                                        string =
                                                                                                                                                                                                    sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                                                                                                                                                                             v0_1.clone(),
                                                                                                                                                                                                             v6885,
                                                                                                                                                                                                             v6848.clone(),
                                                                                                                                                                                                             v6886.clone());
                                                                                                                                                                                                let v7757:
                                                                                                                                                                                                        std::io::Error =
                                                                                                                                                                                                    std::io::Error::new(std::io::ErrorKind::Other, &*v7750);
                                                                                                                                                                                                Err(v7757)
                                                                                                                                                                                            }
                                                                                                                                                                                        }
                                                                                                                                                                                    };
                                                                                                                                                                                let v7782 =
                                                                                                                                                                                    File_system::method79();
                                                                                                                                                                                let v7794:
                                                                                                                                                                                        Result<std::path::PathBuf,
                                                                                                                                                                                               string> =
                                                                                                                                                                                    v7781.map_err(|x| v7782(x));
                                                                                                                                                                                let v7797:
                                                                                                                                                                                        File_system::US13 =
                                                                                                                                                                                    match &v7794
                                                                                                                                                                                        {
                                                                                                                                                                                        Err(v7794_1_0)
                                                                                                                                                                                        =>
                                                                                                                                                                                        v6411(v7794_1_0.clone()),
                                                                                                                                                                                        Ok(v7794_0_0)
                                                                                                                                                                                        =>
                                                                                                                                                                                        v6410(v7794_0_0.clone()),
                                                                                                                                                                                    };
                                                                                                                                                                                match &v7797
                                                                                                                                                                                    {
                                                                                                                                                                                    File_system::US13::US13_0(v7797_0_0)
                                                                                                                                                                                    =>
                                                                                                                                                                                    {
                                                                                                                                                                                        let v7826:
                                                                                                                                                                                                string =
                                                                                                                                                                                            File_system::method59(toString(v7797_0_0.clone().display()),
                                                                                                                                                                                                                  v6829.clone());
                                                                                                                                                                                        let v7833:
                                                                                                                                                                                                &str =
                                                                                                                                                                                            &*v7826;
                                                                                                                                                                                        let v7857:
                                                                                                                                                                                                std::string::String =
                                                                                                                                                                                            String::from(v7833);
                                                                                                                                                                                        let v7881:
                                                                                                                                                                                                std::path::PathBuf =
                                                                                                                                                                                            std::path::PathBuf::from(v7857);
                                                                                                                                                                                        Ok(v7881)
                                                                                                                                                                                    }
                                                                                                                                                                                    File_system::US13::US13_1(v7797_1_0)
                                                                                                                                                                                    =>
                                                                                                                                                                                    {
                                                                                                                                                                                        let v7914:
                                                                                                                                                                                                string =
                                                                                                                                                                                            sprintf!("file_system.read_link / error\': {} / error: {} / name: {}",
                                                                                                                                                                                                     v7797_1_0.clone(),
                                                                                                                                                                                                     v6828.clone(),
                                                                                                                                                                                                     v6829.clone());
                                                                                                                                                                                        let v7921:
                                                                                                                                                                                                std::io::Error =
                                                                                                                                                                                            std::io::Error::new(std::io::ErrorKind::Other, &*v7914);
                                                                                                                                                                                        Err(v7921)
                                                                                                                                                                                    }
                                                                                                                                                                                }
                                                                                                                                                                            } else {
                                                                                                                                                                                let v7945:
                                                                                                                                                                                        string =
                                                                                                                                                                                    sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                                                                                                                                                             v0_1.clone(),
                                                                                                                                                                                             v6828.clone(),
                                                                                                                                                                                             v6791.clone(),
                                                                                                                                                                                             v6829.clone());
                                                                                                                                                                                let v7952:
                                                                                                                                                                                        std::io::Error =
                                                                                                                                                                                    std::io::Error::new(std::io::ErrorKind::Other, &*v7945);
                                                                                                                                                                                Err(v7952)
                                                                                                                                                                            }
                                                                                                                                                                        } else {
                                                                                                                                                                            let v7975:
                                                                                                                                                                                    string =
                                                                                                                                                                                sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                                                                                                                                                         v0_1.clone(),
                                                                                                                                                                                         v6828,
                                                                                                                                                                                         v6791.clone(),
                                                                                                                                                                                         v6829.clone());
                                                                                                                                                                            let v7982:
                                                                                                                                                                                    std::io::Error =
                                                                                                                                                                                std::io::Error::new(std::io::ErrorKind::Other, &*v7975);
                                                                                                                                                                            Err(v7982)
                                                                                                                                                                        }
                                                                                                                                                                    }
                                                                                                                                                                };
                                                                                                                                                            let v8007 =
                                                                                                                                                                File_system::method79();
                                                                                                                                                            let v8019:
                                                                                                                                                                    Result<std::path::PathBuf,
                                                                                                                                                                           string> =
                                                                                                                                                                v8006.map_err(|x| v8007(x));
                                                                                                                                                            let v8022:
                                                                                                                                                                    File_system::US13 =
                                                                                                                                                                match &v8019
                                                                                                                                                                    {
                                                                                                                                                                    Err(v8019_1_0)
                                                                                                                                                                    =>
                                                                                                                                                                    v6411(v8019_1_0.clone()),
                                                                                                                                                                    Ok(v8019_0_0)
                                                                                                                                                                    =>
                                                                                                                                                                    v6410(v8019_0_0.clone()),
                                                                                                                                                                };
                                                                                                                                                            match &v8022
                                                                                                                                                                {
                                                                                                                                                                File_system::US13::US13_0(v8022_0_0)
                                                                                                                                                                =>
                                                                                                                                                                {
                                                                                                                                                                    let v8051:
                                                                                                                                                                            string =
                                                                                                                                                                        File_system::method59(toString(v8022_0_0.clone().display()),
                                                                                                                                                                                              v6772.clone());
                                                                                                                                                                    let v8058:
                                                                                                                                                                            &str =
                                                                                                                                                                        &*v8051;
                                                                                                                                                                    let v8082:
                                                                                                                                                                            std::string::String =
                                                                                                                                                                        String::from(v8058);
                                                                                                                                                                    let v8106:
                                                                                                                                                                            std::path::PathBuf =
                                                                                                                                                                        std::path::PathBuf::from(v8082);
                                                                                                                                                                    Ok(v8106)
                                                                                                                                                                }
                                                                                                                                                                File_system::US13::US13_1(v8022_1_0)
                                                                                                                                                                =>
                                                                                                                                                                {
                                                                                                                                                                    let v8139:
                                                                                                                                                                            string =
                                                                                                                                                                        sprintf!("file_system.read_link / error\': {} / error: {} / name: {}",
                                                                                                                                                                                 v8022_1_0.clone(),
                                                                                                                                                                                 v6771.clone(),
                                                                                                                                                                                 v6772.clone());
                                                                                                                                                                    let v8146:
                                                                                                                                                                            std::io::Error =
                                                                                                                                                                        std::io::Error::new(std::io::ErrorKind::Other, &*v8139);
                                                                                                                                                                    Err(v8146)
                                                                                                                                                                }
                                                                                                                                                            }
                                                                                                                                                        } else {
                                                                                                                                                            let v8170:
                                                                                                                                                                    string =
                                                                                                                                                                sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                                                                                                                                         v0_1.clone(),
                                                                                                                                                                         v6771.clone(),
                                                                                                                                                                         v6734.clone(),
                                                                                                                                                                         v6772.clone());
                                                                                                                                                            let v8177:
                                                                                                                                                                    std::io::Error =
                                                                                                                                                                std::io::Error::new(std::io::ErrorKind::Other, &*v8170);
                                                                                                                                                            Err(v8177)
                                                                                                                                                        }
                                                                                                                                                    } else {
                                                                                                                                                        let v8200:
                                                                                                                                                                string =
                                                                                                                                                            sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                                                                                                                                     v0_1.clone(),
                                                                                                                                                                     v6771,
                                                                                                                                                                     v6734.clone(),
                                                                                                                                                                     v6772.clone());
                                                                                                                                                        let v8207:
                                                                                                                                                                std::io::Error =
                                                                                                                                                            std::io::Error::new(std::io::ErrorKind::Other, &*v8200);
                                                                                                                                                        Err(v8207)
                                                                                                                                                    }
                                                                                                                                                }
                                                                                                                                            };
                                                                                                                                        let v8232 =
                                                                                                                                            File_system::method79();
                                                                                                                                        let v8244:
                                                                                                                                                Result<std::path::PathBuf,
                                                                                                                                                       string> =
                                                                                                                                            v8231.map_err(|x| v8232(x));
                                                                                                                                        let v8247:
                                                                                                                                                File_system::US13 =
                                                                                                                                            match &v8244
                                                                                                                                                {
                                                                                                                                                Err(v8244_1_0)
                                                                                                                                                =>
                                                                                                                                                v6411(v8244_1_0.clone()),
                                                                                                                                                Ok(v8244_0_0)
                                                                                                                                                =>
                                                                                                                                                v6410(v8244_0_0.clone()),
                                                                                                                                            };
                                                                                                                                        match &v8247
                                                                                                                                            {
                                                                                                                                            File_system::US13::US13_0(v8247_0_0)
                                                                                                                                            =>
                                                                                                                                            {
                                                                                                                                                let v8276:
                                                                                                                                                        string =
                                                                                                                                                    File_system::method59(toString(v8247_0_0.clone().display()),
                                                                                                                                                                          v6715.clone());
                                                                                                                                                let v8283:
                                                                                                                                                        &str =
                                                                                                                                                    &*v8276;
                                                                                                                                                let v8307:
                                                                                                                                                        std::string::String =
                                                                                                                                                    String::from(v8283);
                                                                                                                                                let v8331:
                                                                                                                                                        std::path::PathBuf =
                                                                                                                                                    std::path::PathBuf::from(v8307);
                                                                                                                                                Ok(v8331)
                                                                                                                                            }
                                                                                                                                            File_system::US13::US13_1(v8247_1_0)
                                                                                                                                            =>
                                                                                                                                            {
                                                                                                                                                let v8364:
                                                                                                                                                        string =
                                                                                                                                                    sprintf!("file_system.read_link / error\': {} / error: {} / name: {}",
                                                                                                                                                             v8247_1_0.clone(),
                                                                                                                                                             v6714.clone(),
                                                                                                                                                             v6715.clone());
                                                                                                                                                let v8371:
                                                                                                                                                        std::io::Error =
                                                                                                                                                    std::io::Error::new(std::io::ErrorKind::Other, &*v8364);
                                                                                                                                                Err(v8371)
                                                                                                                                            }
                                                                                                                                        }
                                                                                                                                    } else {
                                                                                                                                        let v8395:
                                                                                                                                                string =
                                                                                                                                            sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                                                                                                                     v0_1.clone(),
                                                                                                                                                     v6714.clone(),
                                                                                                                                                     v6677.clone(),
                                                                                                                                                     v6715.clone());
                                                                                                                                        let v8402:
                                                                                                                                                std::io::Error =
                                                                                                                                            std::io::Error::new(std::io::ErrorKind::Other, &*v8395);
                                                                                                                                        Err(v8402)
                                                                                                                                    }
                                                                                                                                } else {
                                                                                                                                    let v8425:
                                                                                                                                            string =
                                                                                                                                        sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                                                                                                                 v0_1.clone(),
                                                                                                                                                 v6714,
                                                                                                                                                 v6677.clone(),
                                                                                                                                                 v6715.clone());
                                                                                                                                    let v8432:
                                                                                                                                            std::io::Error =
                                                                                                                                        std::io::Error::new(std::io::ErrorKind::Other, &*v8425);
                                                                                                                                    Err(v8432)
                                                                                                                                }
                                                                                                                            }
                                                                                                                        };
                                                                                                                    let v8457 =
                                                                                                                        File_system::method79();
                                                                                                                    let v8469:
                                                                                                                            Result<std::path::PathBuf,
                                                                                                                                   string> =
                                                                                                                        v8456.map_err(|x| v8457(x));
                                                                                                                    let v8472:
                                                                                                                            File_system::US13 =
                                                                                                                        match &v8469
                                                                                                                            {
                                                                                                                            Err(v8469_1_0)
                                                                                                                            =>
                                                                                                                            v6411(v8469_1_0.clone()),
                                                                                                                            Ok(v8469_0_0)
                                                                                                                            =>
                                                                                                                            v6410(v8469_0_0.clone()),
                                                                                                                        };
                                                                                                                    match &v8472
                                                                                                                        {
                                                                                                                        File_system::US13::US13_0(v8472_0_0)
                                                                                                                        =>
                                                                                                                        {
                                                                                                                            let v8501:
                                                                                                                                    string =
                                                                                                                                File_system::method59(toString(v8472_0_0.clone().display()),
                                                                                                                                                      v6658.clone());
                                                                                                                            let v8508:
                                                                                                                                    &str =
                                                                                                                                &*v8501;
                                                                                                                            let v8532:
                                                                                                                                    std::string::String =
                                                                                                                                String::from(v8508);
                                                                                                                            let v8556:
                                                                                                                                    std::path::PathBuf =
                                                                                                                                std::path::PathBuf::from(v8532);
                                                                                                                            Ok(v8556)
                                                                                                                        }
                                                                                                                        File_system::US13::US13_1(v8472_1_0)
                                                                                                                        =>
                                                                                                                        {
                                                                                                                            let v8589:
                                                                                                                                    string =
                                                                                                                                sprintf!("file_system.read_link / error\': {} / error: {} / name: {}",
                                                                                                                                         v8472_1_0.clone(),
                                                                                                                                         v6657.clone(),
                                                                                                                                         v6658.clone());
                                                                                                                            let v8596:
                                                                                                                                    std::io::Error =
                                                                                                                                std::io::Error::new(std::io::ErrorKind::Other, &*v8589);
                                                                                                                            Err(v8596)
                                                                                                                        }
                                                                                                                    }
                                                                                                                } else {
                                                                                                                    let v8620:
                                                                                                                            string =
                                                                                                                        sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                                                                                                 v0_1.clone(),
                                                                                                                                 v6657.clone(),
                                                                                                                                 v6620.clone(),
                                                                                                                                 v6658.clone());
                                                                                                                    let v8627:
                                                                                                                            std::io::Error =
                                                                                                                        std::io::Error::new(std::io::ErrorKind::Other, &*v8620);
                                                                                                                    Err(v8627)
                                                                                                                }
                                                                                                            } else {
                                                                                                                let v8650:
                                                                                                                        string =
                                                                                                                    sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                                                                                             v0_1.clone(),
                                                                                                                             v6657,
                                                                                                                             v6620.clone(),
                                                                                                                             v6658.clone());
                                                                                                                let v8657:
                                                                                                                        std::io::Error =
                                                                                                                    std::io::Error::new(std::io::ErrorKind::Other, &*v8650);
                                                                                                                Err(v8657)
                                                                                                            }
                                                                                                        }
                                                                                                    };
                                                                                                let v8682 =
                                                                                                    File_system::method79();
                                                                                                let v8694:
                                                                                                        Result<std::path::PathBuf,
                                                                                                               string> =
                                                                                                    v8681.map_err(|x| v8682(x));
                                                                                                let v8697:
                                                                                                        File_system::US13 =
                                                                                                    match &v8694
                                                                                                        {
                                                                                                        Err(v8694_1_0)
                                                                                                        =>
                                                                                                        v6411(v8694_1_0.clone()),
                                                                                                        Ok(v8694_0_0)
                                                                                                        =>
                                                                                                        v6410(v8694_0_0.clone()),
                                                                                                    };
                                                                                                match &v8697
                                                                                                    {
                                                                                                    File_system::US13::US13_0(v8697_0_0)
                                                                                                    =>
                                                                                                    {
                                                                                                        let v8726:
                                                                                                                string =
                                                                                                            File_system::method59(toString(v8697_0_0.clone().display()),
                                                                                                                                  v6601.clone());
                                                                                                        let v8733:
                                                                                                                &str =
                                                                                                            &*v8726;
                                                                                                        let v8757:
                                                                                                                std::string::String =
                                                                                                            String::from(v8733);
                                                                                                        let v8781:
                                                                                                                std::path::PathBuf =
                                                                                                            std::path::PathBuf::from(v8757);
                                                                                                        Ok(v8781)
                                                                                                    }
                                                                                                    File_system::US13::US13_1(v8697_1_0)
                                                                                                    =>
                                                                                                    {
                                                                                                        let v8814:
                                                                                                                string =
                                                                                                            sprintf!("file_system.read_link / error\': {} / error: {} / name: {}",
                                                                                                                     v8697_1_0.clone(),
                                                                                                                     v6600.clone(),
                                                                                                                     v6601.clone());
                                                                                                        let v8821:
                                                                                                                std::io::Error =
                                                                                                            std::io::Error::new(std::io::ErrorKind::Other, &*v8814);
                                                                                                        Err(v8821)
                                                                                                    }
                                                                                                }
                                                                                            } else {
                                                                                                let v8845:
                                                                                                        string =
                                                                                                    sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                                                                             v0_1.clone(),
                                                                                                             v6600.clone(),
                                                                                                             v6563.clone(),
                                                                                                             v6601.clone());
                                                                                                let v8852:
                                                                                                        std::io::Error =
                                                                                                    std::io::Error::new(std::io::ErrorKind::Other, &*v8845);
                                                                                                Err(v8852)
                                                                                            }
                                                                                        } else {
                                                                                            let v8875:
                                                                                                    string =
                                                                                                sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                                                                         v0_1.clone(),
                                                                                                         v6600,
                                                                                                         v6563.clone(),
                                                                                                         v6601.clone());
                                                                                            let v8882:
                                                                                                    std::io::Error =
                                                                                                std::io::Error::new(std::io::ErrorKind::Other, &*v8875);
                                                                                            Err(v8882)
                                                                                        }
                                                                    }
                                                                };
                                                                let v8907 = File_system::method79();
                                                                let v8919: Result<
                                                                    std::path::PathBuf,
                                                                    string,
                                                                > = v8906.map_err(|x| v8907(x));
                                                                let v8922: File_system::US13 =
                                                                    match &v8919 {
                                                                        Err(v8919_1_0) => {
                                                                            v6411(v8919_1_0.clone())
                                                                        }
                                                                        Ok(v8919_0_0) => {
                                                                            v6410(v8919_0_0.clone())
                                                                        }
                                                                    };
                                                                match &v8922 {
                                                                    File_system::US13::US13_0(
                                                                        v8922_0_0,
                                                                    ) => {
                                                                        let v8951: string =
                                                                            File_system::method59(
                                                                                toString(
                                                                                    v8922_0_0
                                                                                        .clone()
                                                                                        .display(),
                                                                                ),
                                                                                v6544.clone(),
                                                                            );
                                                                        let v8958: &str = &*v8951;
                                                                        let v8982:
                                                                                            std::string::String =
                                                                                        String::from(v8958);
                                                                        let v9006:
                                                                                            std::path::PathBuf =
                                                                                        std::path::PathBuf::from(v8982);
                                                                        Ok(v9006)
                                                                    }
                                                                    File_system::US13::US13_1(
                                                                        v8922_1_0,
                                                                    ) => {
                                                                        let v9039:
                                                                                            string =
                                                                                        sprintf!("file_system.read_link / error\': {} / error: {} / name: {}",
                                                                                                 v8922_1_0.clone(),
                                                                                                 v6543.clone(),
                                                                                                 v6544.clone());
                                                                        let v9046:
                                                                                            std::io::Error =
                                                                                        std::io::Error::new(std::io::ErrorKind::Other, &*v9039);
                                                                        Err(v9046)
                                                                    }
                                                                }
                                                            } else {
                                                                let v9070:
                                                                                    string =
                                                                                sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                                                         v0_1.clone(),
                                                                                         v6543.clone(),
                                                                                         v6506.clone(),
                                                                                         v6544.clone());
                                                                let v9077: std::io::Error =
                                                                    std::io::Error::new(
                                                                        std::io::ErrorKind::Other,
                                                                        &*v9070,
                                                                    );
                                                                Err(v9077)
                                                            }
                                                        } else {
                                                            let v9100:
                                                                                string =
                                                                            sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                                                     v0_1.clone(),
                                                                                     v6543,
                                                                                     v6506.clone(),
                                                                                     v6544.clone());
                                                            let v9107: std::io::Error =
                                                                std::io::Error::new(
                                                                    std::io::ErrorKind::Other,
                                                                    &*v9100,
                                                                );
                                                            Err(v9107)
                                                        }
                                                    }
                                                };
                                                let v9132 = File_system::method79();
                                                let v9144: Result<std::path::PathBuf, string> =
                                                    v9131.map_err(|x| v9132(x));
                                                let v9147: File_system::US13 = match &v9144 {
                                                    Err(v9144_1_0) => v6411(v9144_1_0.clone()),
                                                    Ok(v9144_0_0) => v6410(v9144_0_0.clone()),
                                                };
                                                match &v9147 {
                                                    File_system::US13::US13_0(v9147_0_0) => {
                                                        let v9176: string = File_system::method59(
                                                            toString(v9147_0_0.clone().display()),
                                                            v6487.clone(),
                                                        );
                                                        let v9183: &str = &*v9176;
                                                        let v9207: std::string::String =
                                                            String::from(v9183);
                                                        let v9231: std::path::PathBuf =
                                                            std::path::PathBuf::from(v9207);
                                                        Ok(v9231)
                                                    }
                                                    File_system::US13::US13_1(v9147_1_0) => {
                                                        let v9264:
                                                                        string =
                                                                    sprintf!("file_system.read_link / error\': {} / error: {} / name: {}",
                                                                             v9147_1_0.clone(),
                                                                             v6486.clone(),
                                                                             v6487.clone());
                                                        let v9271: std::io::Error =
                                                            std::io::Error::new(
                                                                std::io::ErrorKind::Other,
                                                                &*v9264,
                                                            );
                                                        Err(v9271)
                                                    }
                                                }
                                            } else {
                                                let v9295: string =
                                                            sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                                     v0_1.clone(),
                                                                     v6486.clone(),
                                                                     v6448.clone(),
                                                                     v6487.clone());
                                                let v9302: std::io::Error = std::io::Error::new(
                                                    std::io::ErrorKind::Other,
                                                    &*v9295,
                                                );
                                                Err(v9302)
                                            }
                                        } else {
                                            let v9325: string =
                                                        sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                                 v0_1.clone(),
                                                                 v6486,
                                                                 v6448.clone(),
                                                                 v6487.clone());
                                            let v9332: std::io::Error = std::io::Error::new(
                                                std::io::ErrorKind::Other,
                                                &*v9325,
                                            );
                                            Err(v9332)
                                        }
                                    }
                                };
                                let v9357 = File_system::method79();
                                let v9369: Result<std::path::PathBuf, string> =
                                    v9356.map_err(|x| v9357(x));
                                let v9372: File_system::US13 = match &v9369 {
                                    Err(v9369_1_0) => v6411(v9369_1_0.clone()),
                                    Ok(v9369_0_0) => v6410(v9369_0_0.clone()),
                                };
                                match &v9372 {
                                    File_system::US13::US13_0(v9372_0_0) => {
                                        let v9401: string = File_system::method59(
                                            toString(v9372_0_0.clone().display()),
                                            v6429.clone(),
                                        );
                                        let v9408: &str = &*v9401;
                                        let v9432: std::string::String = String::from(v9408);
                                        let v9456: std::path::PathBuf =
                                            std::path::PathBuf::from(v9432);
                                        Ok(v9456)
                                    }
                                    File_system::US13::US13_1(v9372_1_0) => {
                                        let v9489: string =
                                                sprintf!("file_system.read_link / error\': {} / error: {} / name: {}",
                                                         v9372_1_0.clone(),
                                                         v6428.clone(),
                                                         v6429.clone());
                                        let v9496: std::io::Error =
                                            std::io::Error::new(std::io::ErrorKind::Other, &*v9489);
                                        Err(v9496)
                                    }
                                }
                            } else {
                                let v9520: string =
                                        sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                 v0_1.clone(), v6428.clone(),
                                                 v0_1.clone(), v6429.clone());
                                let v9527: std::io::Error =
                                    std::io::Error::new(std::io::ErrorKind::Other, &*v9520);
                                Err(v9527)
                            }
                        } else {
                            let v9550: string =
                                    sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                             v0_1.clone(), v6428,
                                             v0_1.clone(), v6429.clone());
                            let v9557: std::io::Error =
                                std::io::Error::new(std::io::ErrorKind::Other, &*v9550);
                            Err(v9557)
                        }
                    }
                }
            };
            let v19014: Option<std::path::PathBuf> = v9582.ok();
            let v19035: File_system::US14 = defaultValue(
                File_system::US14::US14_1,
                map(File_system::method83(), v19014),
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
                let v9589: Result<std::path::PathBuf, std::io::Error> = if File_system::method9(
                    v1_1.clone(),
                ) {
                    std::fs::read_link(&*v1_1.clone())
                } else {
                    let v6401: Result<std::path::PathBuf, std::io::Error> =
                        std::fs::read_link(&*v1_1.clone());
                    let v6402 = File_system::method79();
                    let v6414: Result<std::path::PathBuf, string> = v6401.map_err(|x| v6402(x));
                    fn v6417(v: std::path::PathBuf) -> File_system::US13 {
                        File_system::closure47((), v)
                    }
                    fn v6418(v_1: string) -> File_system::US13 {
                        File_system::closure48((), v_1)
                    }
                    let v6419: File_system::US13 = match &v6414 {
                        Err(v6414_1_0) => v6418(v6414_1_0.clone()),
                        Ok(v6414_0_0) => v6417(v6414_0_0.clone()),
                    };
                    match &v6419 {
                        File_system::US13::US13_0(v6419_0_0) => Ok(v6419_0_0.clone()),
                        File_system::US13::US13_1(v6419_1_0) => {
                            let v6435: string = v6419_1_0.clone();
                            let v6436: string = File_system::method19(v1_1.clone());
                            let v6437: Option<string> = File_system::method81(v1_1.clone());
                            let v6451: File_system::US1 = defaultValue(
                                File_system::US1::US1_1,
                                map(File_system::method4(), v6437),
                            );
                            if let File_system::US1::US1_0(v6451_0_0) = &v6451 {
                                let v6455: string = match &v6451 {
                                    File_system::US1::US1_0(x) => x.clone(),
                                    _ => unreachable!(),
                                };
                                if v1_1.clone() != string("") {
                                    let v6461: Result<std::path::PathBuf, std::io::Error> =
                                        std::fs::read_link(&*v6455.clone());
                                    let v6462 = File_system::method79();
                                    let v6474: Result<std::path::PathBuf, string> =
                                        v6461.map_err(|x| v6462(x));
                                    let v6477: File_system::US13 = match &v6474 {
                                        Err(v6474_1_0) => v6418(v6474_1_0.clone()),
                                        Ok(v6474_0_0) => v6417(v6474_0_0.clone()),
                                    };
                                    let v9363: Result<std::path::PathBuf, std::io::Error> =
                                        match &v6477 {
                                            File_system::US13::US13_0(v6477_0_0) => {
                                                Ok(v6477_0_0.clone())
                                            }
                                            File_system::US13::US13_1(v6477_1_0) => {
                                                let v6493: string = v6477_1_0.clone();
                                                let v6494: string =
                                                    File_system::method19(v6455.clone());
                                                let v6495: Option<string> =
                                                    File_system::method81(v6455.clone());
                                                let v6509: File_system::US1 = defaultValue(
                                                    File_system::US1::US1_1,
                                                    map(File_system::method4(), v6495),
                                                );
                                                if let File_system::US1::US1_0(v6509_0_0) = &v6509 {
                                                    let v6513: string = match &v6509 {
                                                        File_system::US1::US1_0(x) => x.clone(),
                                                        _ => unreachable!(),
                                                    };
                                                    if v6455.clone() != string("") {
                                                        let v6518: Result<
                                                            std::path::PathBuf,
                                                            std::io::Error,
                                                        > = std::fs::read_link(&*v6513.clone());
                                                        let v6519 = File_system::method79();
                                                        let v6531: Result<
                                                            std::path::PathBuf,
                                                            string,
                                                        > = v6518.map_err(|x| v6519(x));
                                                        let v6534: File_system::US13 = match &v6531
                                                        {
                                                            Err(v6531_1_0) => {
                                                                v6418(v6531_1_0.clone())
                                                            }
                                                            Ok(v6531_0_0) => {
                                                                v6417(v6531_0_0.clone())
                                                            }
                                                        };
                                                        let v9138: Result<
                                                            std::path::PathBuf,
                                                            std::io::Error,
                                                        > = match &v6534 {
                                                            File_system::US13::US13_0(
                                                                v6534_0_0,
                                                            ) => Ok(v6534_0_0.clone()),
                                                            File_system::US13::US13_1(
                                                                v6534_1_0,
                                                            ) => {
                                                                let v6550: string =
                                                                    v6534_1_0.clone();
                                                                let v6551: string =
                                                                    File_system::method19(
                                                                        v6513.clone(),
                                                                    );
                                                                let v6552: Option<string> =
                                                                    File_system::method81(
                                                                        v6513.clone(),
                                                                    );
                                                                let v6566: File_system::US1 =
                                                                    defaultValue(
                                                                        File_system::US1::US1_1,
                                                                        map(
                                                                            File_system::method4(),
                                                                            v6552,
                                                                        ),
                                                                    );
                                                                if let File_system::US1::US1_0(
                                                                    v6566_0_0,
                                                                ) = &v6566
                                                                {
                                                                    let v6570: string = match &v6566
                                                                    {
                                                                        File_system::US1::US1_0(
                                                                            x,
                                                                        ) => x.clone(),
                                                                        _ => unreachable!(),
                                                                    };
                                                                    if v6513.clone() != string("") {
                                                                        let v6575: Result<
                                                                            std::path::PathBuf,
                                                                            std::io::Error,
                                                                        > = std::fs::read_link(
                                                                            &*v6570.clone(),
                                                                        );
                                                                        let v6576 =
                                                                            File_system::method79();
                                                                        let v6588: Result<
                                                                            std::path::PathBuf,
                                                                            string,
                                                                        > = v6575
                                                                            .map_err(|x| v6576(x));
                                                                        let v6591:
                                                                                           File_system::US13 =
                                                                                       match &v6588
                                                                                           {
                                                                                           Err(v6588_1_0)
                                                                                           =>
                                                                                           v6418(v6588_1_0.clone()),
                                                                                           Ok(v6588_0_0)
                                                                                           =>
                                                                                           v6417(v6588_0_0.clone()),
                                                                                       };
                                                                        let v8913:
                                                                                           Result<std::path::PathBuf,
                                                                                                  std::io::Error> =
                                                                                       match &v6591
                                                                                           {
                                                                                           File_system::US13::US13_0(v6591_0_0)
                                                                                           =>
                                                                                           Ok(v6591_0_0.clone()),
                                                                                           File_system::US13::US13_1(v6591_1_0)
                                                                                           =>
                                                                                           {
                                                                                               let v6607:
                                                                                                       string =
                                                                                                   v6591_1_0.clone();
                                                                                               let v6608:
                                                                                                       string =
                                                                                                   File_system::method19(v6570.clone());
                                                                                               let v6609:
                                                                                                       Option<string> =
                                                                                                   File_system::method81(v6570.clone());
                                                                                               let v6623:
                                                                                                       File_system::US1 =
                                                                                                   defaultValue(File_system::US1::US1_1,
                                                                                                                map(File_system::method4(),
                                                                                                                    v6609));
                                                                                               if let File_system::US1::US1_0(v6623_0_0)
                                                                                                      =
                                                                                                      &v6623
                                                                                                  {
                                                                                                   let v6627:
                                                                                                           string =
                                                                                                       match &v6623
                                                                                                           {
                                                                                                           File_system::US1::US1_0(x)
                                                                                                           =>
                                                                                                           x.clone(),
                                                                                                           _
                                                                                                           =>
                                                                                                           unreachable!(),
                                                                                                       };
                                                                                                   if v6570.clone()
                                                                                                          !=
                                                                                                          string("")
                                                                                                      {
                                                                                                       let v6632:
                                                                                                               Result<std::path::PathBuf,
                                                                                                                      std::io::Error> =
                                                                                                           std::fs::read_link(&*v6627.clone());
                                                                                                       let v6633 =
                                                                                                           File_system::method79();
                                                                                                       let v6645:
                                                                                                               Result<std::path::PathBuf,
                                                                                                                      string> =
                                                                                                           v6632.map_err(|x| v6633(x));
                                                                                                       let v6648:
                                                                                                               File_system::US13 =
                                                                                                           match &v6645
                                                                                                               {
                                                                                                               Err(v6645_1_0)
                                                                                                               =>
                                                                                                               v6418(v6645_1_0.clone()),
                                                                                                               Ok(v6645_0_0)
                                                                                                               =>
                                                                                                               v6417(v6645_0_0.clone()),
                                                                                                           };
                                                                                                       let v8688:
                                                                                                               Result<std::path::PathBuf,
                                                                                                                      std::io::Error> =
                                                                                                           match &v6648
                                                                                                               {
                                                                                                               File_system::US13::US13_0(v6648_0_0)
                                                                                                               =>
                                                                                                               Ok(v6648_0_0.clone()),
                                                                                                               File_system::US13::US13_1(v6648_1_0)
                                                                                                               =>
                                                                                                               {
                                                                                                                   let v6664:
                                                                                                                           string =
                                                                                                                       v6648_1_0.clone();
                                                                                                                   let v6665:
                                                                                                                           string =
                                                                                                                       File_system::method19(v6627.clone());
                                                                                                                   let v6666:
                                                                                                                           Option<string> =
                                                                                                                       File_system::method81(v6627.clone());
                                                                                                                   let v6680:
                                                                                                                           File_system::US1 =
                                                                                                                       defaultValue(File_system::US1::US1_1,
                                                                                                                                    map(File_system::method4(),
                                                                                                                                        v6666));
                                                                                                                   if let File_system::US1::US1_0(v6680_0_0)
                                                                                                                          =
                                                                                                                          &v6680
                                                                                                                      {
                                                                                                                       let v6684:
                                                                                                                               string =
                                                                                                                           match &v6680
                                                                                                                               {
                                                                                                                               File_system::US1::US1_0(x)
                                                                                                                               =>
                                                                                                                               x.clone(),
                                                                                                                               _
                                                                                                                               =>
                                                                                                                               unreachable!(),
                                                                                                                           };
                                                                                                                       if v6627.clone()
                                                                                                                              !=
                                                                                                                              string("")
                                                                                                                          {
                                                                                                                           let v6689:
                                                                                                                                   Result<std::path::PathBuf,
                                                                                                                                          std::io::Error> =
                                                                                                                               std::fs::read_link(&*v6684.clone());
                                                                                                                           let v6690 =
                                                                                                                               File_system::method79();
                                                                                                                           let v6702:
                                                                                                                                   Result<std::path::PathBuf,
                                                                                                                                          string> =
                                                                                                                               v6689.map_err(|x| v6690(x));
                                                                                                                           let v6705:
                                                                                                                                   File_system::US13 =
                                                                                                                               match &v6702
                                                                                                                                   {
                                                                                                                                   Err(v6702_1_0)
                                                                                                                                   =>
                                                                                                                                   v6418(v6702_1_0.clone()),
                                                                                                                                   Ok(v6702_0_0)
                                                                                                                                   =>
                                                                                                                                   v6417(v6702_0_0.clone()),
                                                                                                                               };
                                                                                                                           let v8463:
                                                                                                                                   Result<std::path::PathBuf,
                                                                                                                                          std::io::Error> =
                                                                                                                               match &v6705
                                                                                                                                   {
                                                                                                                                   File_system::US13::US13_0(v6705_0_0)
                                                                                                                                   =>
                                                                                                                                   Ok(v6705_0_0.clone()),
                                                                                                                                   File_system::US13::US13_1(v6705_1_0)
                                                                                                                                   =>
                                                                                                                                   {
                                                                                                                                       let v6721:
                                                                                                                                               string =
                                                                                                                                           v6705_1_0.clone();
                                                                                                                                       let v6722:
                                                                                                                                               string =
                                                                                                                                           File_system::method19(v6684.clone());
                                                                                                                                       let v6723:
                                                                                                                                               Option<string> =
                                                                                                                                           File_system::method81(v6684.clone());
                                                                                                                                       let v6737:
                                                                                                                                               File_system::US1 =
                                                                                                                                           defaultValue(File_system::US1::US1_1,
                                                                                                                                                        map(File_system::method4(),
                                                                                                                                                            v6723));
                                                                                                                                       if let File_system::US1::US1_0(v6737_0_0)
                                                                                                                                              =
                                                                                                                                              &v6737
                                                                                                                                          {
                                                                                                                                           let v6741:
                                                                                                                                                   string =
                                                                                                                                               match &v6737
                                                                                                                                                   {
                                                                                                                                                   File_system::US1::US1_0(x)
                                                                                                                                                   =>
                                                                                                                                                   x.clone(),
                                                                                                                                                   _
                                                                                                                                                   =>
                                                                                                                                                   unreachable!(),
                                                                                                                                               };
                                                                                                                                           if v6684.clone()
                                                                                                                                                  !=
                                                                                                                                                  string("")
                                                                                                                                              {
                                                                                                                                               let v6746:
                                                                                                                                                       Result<std::path::PathBuf,
                                                                                                                                                              std::io::Error> =
                                                                                                                                                   std::fs::read_link(&*v6741.clone());
                                                                                                                                               let v6747 =
                                                                                                                                                   File_system::method79();
                                                                                                                                               let v6759:
                                                                                                                                                       Result<std::path::PathBuf,
                                                                                                                                                              string> =
                                                                                                                                                   v6746.map_err(|x| v6747(x));
                                                                                                                                               let v6762:
                                                                                                                                                       File_system::US13 =
                                                                                                                                                   match &v6759
                                                                                                                                                       {
                                                                                                                                                       Err(v6759_1_0)
                                                                                                                                                       =>
                                                                                                                                                       v6418(v6759_1_0.clone()),
                                                                                                                                                       Ok(v6759_0_0)
                                                                                                                                                       =>
                                                                                                                                                       v6417(v6759_0_0.clone()),
                                                                                                                                                   };
                                                                                                                                               let v8238:
                                                                                                                                                       Result<std::path::PathBuf,
                                                                                                                                                              std::io::Error> =
                                                                                                                                                   match &v6762
                                                                                                                                                       {
                                                                                                                                                       File_system::US13::US13_0(v6762_0_0)
                                                                                                                                                       =>
                                                                                                                                                       Ok(v6762_0_0.clone()),
                                                                                                                                                       File_system::US13::US13_1(v6762_1_0)
                                                                                                                                                       =>
                                                                                                                                                       {
                                                                                                                                                           let v6778:
                                                                                                                                                                   string =
                                                                                                                                                               v6762_1_0.clone();
                                                                                                                                                           let v6779:
                                                                                                                                                                   string =
                                                                                                                                                               File_system::method19(v6741.clone());
                                                                                                                                                           let v6780:
                                                                                                                                                                   Option<string> =
                                                                                                                                                               File_system::method81(v6741.clone());
                                                                                                                                                           let v6794:
                                                                                                                                                                   File_system::US1 =
                                                                                                                                                               defaultValue(File_system::US1::US1_1,
                                                                                                                                                                            map(File_system::method4(),
                                                                                                                                                                                v6780));
                                                                                                                                                           if let File_system::US1::US1_0(v6794_0_0)
                                                                                                                                                                  =
                                                                                                                                                                  &v6794
                                                                                                                                                              {
                                                                                                                                                               let v6798:
                                                                                                                                                                       string =
                                                                                                                                                                   match &v6794
                                                                                                                                                                       {
                                                                                                                                                                       File_system::US1::US1_0(x)
                                                                                                                                                                       =>
                                                                                                                                                                       x.clone(),
                                                                                                                                                                       _
                                                                                                                                                                       =>
                                                                                                                                                                       unreachable!(),
                                                                                                                                                                   };
                                                                                                                                                               if v6741.clone()
                                                                                                                                                                      !=
                                                                                                                                                                      string("")
                                                                                                                                                                  {
                                                                                                                                                                   let v6803:
                                                                                                                                                                           Result<std::path::PathBuf,
                                                                                                                                                                                  std::io::Error> =
                                                                                                                                                                       std::fs::read_link(&*v6798.clone());
                                                                                                                                                                   let v6804 =
                                                                                                                                                                       File_system::method79();
                                                                                                                                                                   let v6816:
                                                                                                                                                                           Result<std::path::PathBuf,
                                                                                                                                                                                  string> =
                                                                                                                                                                       v6803.map_err(|x| v6804(x));
                                                                                                                                                                   let v6819:
                                                                                                                                                                           File_system::US13 =
                                                                                                                                                                       match &v6816
                                                                                                                                                                           {
                                                                                                                                                                           Err(v6816_1_0)
                                                                                                                                                                           =>
                                                                                                                                                                           v6418(v6816_1_0.clone()),
                                                                                                                                                                           Ok(v6816_0_0)
                                                                                                                                                                           =>
                                                                                                                                                                           v6417(v6816_0_0.clone()),
                                                                                                                                                                       };
                                                                                                                                                                   let v8013:
                                                                                                                                                                           Result<std::path::PathBuf,
                                                                                                                                                                                  std::io::Error> =
                                                                                                                                                                       match &v6819
                                                                                                                                                                           {
                                                                                                                                                                           File_system::US13::US13_0(v6819_0_0)
                                                                                                                                                                           =>
                                                                                                                                                                           Ok(v6819_0_0.clone()),
                                                                                                                                                                           File_system::US13::US13_1(v6819_1_0)
                                                                                                                                                                           =>
                                                                                                                                                                           {
                                                                                                                                                                               let v6835:
                                                                                                                                                                                       string =
                                                                                                                                                                                   v6819_1_0.clone();
                                                                                                                                                                               let v6836:
                                                                                                                                                                                       string =
                                                                                                                                                                                   File_system::method19(v6798.clone());
                                                                                                                                                                               let v6837:
                                                                                                                                                                                       Option<string> =
                                                                                                                                                                                   File_system::method81(v6798.clone());
                                                                                                                                                                               let v6851:
                                                                                                                                                                                       File_system::US1 =
                                                                                                                                                                                   defaultValue(File_system::US1::US1_1,
                                                                                                                                                                                                map(File_system::method4(),
                                                                                                                                                                                                    v6837));
                                                                                                                                                                               if let File_system::US1::US1_0(v6851_0_0)
                                                                                                                                                                                      =
                                                                                                                                                                                      &v6851
                                                                                                                                                                                  {
                                                                                                                                                                                   let v6855:
                                                                                                                                                                                           string =
                                                                                                                                                                                       match &v6851
                                                                                                                                                                                           {
                                                                                                                                                                                           File_system::US1::US1_0(x)
                                                                                                                                                                                           =>
                                                                                                                                                                                           x.clone(),
                                                                                                                                                                                           _
                                                                                                                                                                                           =>
                                                                                                                                                                                           unreachable!(),
                                                                                                                                                                                       };
                                                                                                                                                                                   if v6798.clone()
                                                                                                                                                                                          !=
                                                                                                                                                                                          string("")
                                                                                                                                                                                      {
                                                                                                                                                                                       let v6860:
                                                                                                                                                                                               Result<std::path::PathBuf,
                                                                                                                                                                                                      std::io::Error> =
                                                                                                                                                                                           std::fs::read_link(&*v6855.clone());
                                                                                                                                                                                       let v6861 =
                                                                                                                                                                                           File_system::method79();
                                                                                                                                                                                       let v6873:
                                                                                                                                                                                               Result<std::path::PathBuf,
                                                                                                                                                                                                      string> =
                                                                                                                                                                                           v6860.map_err(|x| v6861(x));
                                                                                                                                                                                       let v6876:
                                                                                                                                                                                               File_system::US13 =
                                                                                                                                                                                           match &v6873
                                                                                                                                                                                               {
                                                                                                                                                                                               Err(v6873_1_0)
                                                                                                                                                                                               =>
                                                                                                                                                                                               v6418(v6873_1_0.clone()),
                                                                                                                                                                                               Ok(v6873_0_0)
                                                                                                                                                                                               =>
                                                                                                                                                                                               v6417(v6873_0_0.clone()),
                                                                                                                                                                                           };
                                                                                                                                                                                       let v7788:
                                                                                                                                                                                               Result<std::path::PathBuf,
                                                                                                                                                                                                      std::io::Error> =
                                                                                                                                                                                           match &v6876
                                                                                                                                                                                               {
                                                                                                                                                                                               File_system::US13::US13_0(v6876_0_0)
                                                                                                                                                                                               =>
                                                                                                                                                                                               Ok(v6876_0_0.clone()),
                                                                                                                                                                                               File_system::US13::US13_1(v6876_1_0)
                                                                                                                                                                                               =>
                                                                                                                                                                                               {
                                                                                                                                                                                                   let v6892:
                                                                                                                                                                                                           string =
                                                                                                                                                                                                       v6876_1_0.clone();
                                                                                                                                                                                                   let v6893:
                                                                                                                                                                                                           string =
                                                                                                                                                                                                       File_system::method19(v6855.clone());
                                                                                                                                                                                                   let v6894:
                                                                                                                                                                                                           Option<string> =
                                                                                                                                                                                                       File_system::method81(v6855.clone());
                                                                                                                                                                                                   let v6908:
                                                                                                                                                                                                           File_system::US1 =
                                                                                                                                                                                                       defaultValue(File_system::US1::US1_1,
                                                                                                                                                                                                                    map(File_system::method4(),
                                                                                                                                                                                                                        v6894));
                                                                                                                                                                                                   if let File_system::US1::US1_0(v6908_0_0)
                                                                                                                                                                                                          =
                                                                                                                                                                                                          &v6908
                                                                                                                                                                                                      {
                                                                                                                                                                                                       let v6912:
                                                                                                                                                                                                               string =
                                                                                                                                                                                                           match &v6908
                                                                                                                                                                                                               {
                                                                                                                                                                                                               File_system::US1::US1_0(x)
                                                                                                                                                                                                               =>
                                                                                                                                                                                                               x.clone(),
                                                                                                                                                                                                               _
                                                                                                                                                                                                               =>
                                                                                                                                                                                                               unreachable!(),
                                                                                                                                                                                                           };
                                                                                                                                                                                                       if v6855.clone()
                                                                                                                                                                                                              !=
                                                                                                                                                                                                              string("")
                                                                                                                                                                                                          {
                                                                                                                                                                                                           let v6917:
                                                                                                                                                                                                                   Result<std::path::PathBuf,
                                                                                                                                                                                                                          std::io::Error> =
                                                                                                                                                                                                               std::fs::read_link(&*v6912.clone());
                                                                                                                                                                                                           let v6918 =
                                                                                                                                                                                                               File_system::method79();
                                                                                                                                                                                                           let v6930:
                                                                                                                                                                                                                   Result<std::path::PathBuf,
                                                                                                                                                                                                                          string> =
                                                                                                                                                                                                               v6917.map_err(|x| v6918(x));
                                                                                                                                                                                                           let v6933:
                                                                                                                                                                                                                   File_system::US13 =
                                                                                                                                                                                                               match &v6930
                                                                                                                                                                                                                   {
                                                                                                                                                                                                                   Err(v6930_1_0)
                                                                                                                                                                                                                   =>
                                                                                                                                                                                                                   v6418(v6930_1_0.clone()),
                                                                                                                                                                                                                   Ok(v6930_0_0)
                                                                                                                                                                                                                   =>
                                                                                                                                                                                                                   v6417(v6930_0_0.clone()),
                                                                                                                                                                                                               };
                                                                                                                                                                                                           let v7563:
                                                                                                                                                                                                                   Result<std::path::PathBuf,
                                                                                                                                                                                                                          std::io::Error> =
                                                                                                                                                                                                               match &v6933
                                                                                                                                                                                                                   {
                                                                                                                                                                                                                   File_system::US13::US13_0(v6933_0_0)
                                                                                                                                                                                                                   =>
                                                                                                                                                                                                                   Ok(v6933_0_0.clone()),
                                                                                                                                                                                                                   File_system::US13::US13_1(v6933_1_0)
                                                                                                                                                                                                                   =>
                                                                                                                                                                                                                   {
                                                                                                                                                                                                                       let v6949:
                                                                                                                                                                                                                               string =
                                                                                                                                                                                                                           v6933_1_0.clone();
                                                                                                                                                                                                                       let v6950:
                                                                                                                                                                                                                               string =
                                                                                                                                                                                                                           File_system::method19(v6912.clone());
                                                                                                                                                                                                                       let v6951:
                                                                                                                                                                                                                               Option<string> =
                                                                                                                                                                                                                           File_system::method81(v6912.clone());
                                                                                                                                                                                                                       let v6965:
                                                                                                                                                                                                                               File_system::US1 =
                                                                                                                                                                                                                           defaultValue(File_system::US1::US1_1,
                                                                                                                                                                                                                                        map(File_system::method4(),
                                                                                                                                                                                                                                            v6951));
                                                                                                                                                                                                                       if let File_system::US1::US1_0(v6965_0_0)
                                                                                                                                                                                                                              =
                                                                                                                                                                                                                              &v6965
                                                                                                                                                                                                                          {
                                                                                                                                                                                                                           let v6969:
                                                                                                                                                                                                                                   string =
                                                                                                                                                                                                                               match &v6965
                                                                                                                                                                                                                                   {
                                                                                                                                                                                                                                   File_system::US1::US1_0(x)
                                                                                                                                                                                                                                   =>
                                                                                                                                                                                                                                   x.clone(),
                                                                                                                                                                                                                                   _
                                                                                                                                                                                                                                   =>
                                                                                                                                                                                                                                   unreachable!(),
                                                                                                                                                                                                                               };
                                                                                                                                                                                                                           if v6912.clone()
                                                                                                                                                                                                                                  !=
                                                                                                                                                                                                                                  string("")
                                                                                                                                                                                                                              {
                                                                                                                                                                                                                               let v6974:
                                                                                                                                                                                                                                       Result<std::path::PathBuf,
                                                                                                                                                                                                                                              std::io::Error> =
                                                                                                                                                                                                                                   std::fs::read_link(&*v6969.clone());
                                                                                                                                                                                                                               let v6975 =
                                                                                                                                                                                                                                   File_system::method79();
                                                                                                                                                                                                                               let v6987:
                                                                                                                                                                                                                                       Result<std::path::PathBuf,
                                                                                                                                                                                                                                              string> =
                                                                                                                                                                                                                                   v6974.map_err(|x| v6975(x));
                                                                                                                                                                                                                               let v6990:
                                                                                                                                                                                                                                       File_system::US13 =
                                                                                                                                                                                                                                   match &v6987
                                                                                                                                                                                                                                       {
                                                                                                                                                                                                                                       Err(v6987_1_0)
                                                                                                                                                                                                                                       =>
                                                                                                                                                                                                                                       v6418(v6987_1_0.clone()),
                                                                                                                                                                                                                                       Ok(v6987_0_0)
                                                                                                                                                                                                                                       =>
                                                                                                                                                                                                                                       v6417(v6987_0_0.clone()),
                                                                                                                                                                                                                                   };
                                                                                                                                                                                                                               let v7338:
                                                                                                                                                                                                                                       Result<std::path::PathBuf,
                                                                                                                                                                                                                                              std::io::Error> =
                                                                                                                                                                                                                                   match &v6990
                                                                                                                                                                                                                                       {
                                                                                                                                                                                                                                       File_system::US13::US13_0(v6990_0_0)
                                                                                                                                                                                                                                       =>
                                                                                                                                                                                                                                       Ok(v6990_0_0.clone()),
                                                                                                                                                                                                                                       File_system::US13::US13_1(v6990_1_0)
                                                                                                                                                                                                                                       =>
                                                                                                                                                                                                                                       {
                                                                                                                                                                                                                                           let v7006:
                                                                                                                                                                                                                                                   string =
                                                                                                                                                                                                                                               v6990_1_0.clone();
                                                                                                                                                                                                                                           let v7007:
                                                                                                                                                                                                                                                   string =
                                                                                                                                                                                                                                               File_system::method19(v6969.clone());
                                                                                                                                                                                                                                           let v7008:
                                                                                                                                                                                                                                                   Option<string> =
                                                                                                                                                                                                                                               File_system::method81(v6969.clone());
                                                                                                                                                                                                                                           let v7022:
                                                                                                                                                                                                                                                   File_system::US1 =
                                                                                                                                                                                                                                               defaultValue(File_system::US1::US1_1,
                                                                                                                                                                                                                                                            map(File_system::method4(),
                                                                                                                                                                                                                                                                v7008));
                                                                                                                                                                                                                                           if let File_system::US1::US1_0(v7022_0_0)
                                                                                                                                                                                                                                                  =
                                                                                                                                                                                                                                                  &v7022
                                                                                                                                                                                                                                              {
                                                                                                                                                                                                                                               let v7026:
                                                                                                                                                                                                                                                       string =
                                                                                                                                                                                                                                                   match &v7022
                                                                                                                                                                                                                                                       {
                                                                                                                                                                                                                                                       File_system::US1::US1_0(x)
                                                                                                                                                                                                                                                       =>
                                                                                                                                                                                                                                                       x.clone(),
                                                                                                                                                                                                                                                       _
                                                                                                                                                                                                                                                       =>
                                                                                                                                                                                                                                                       unreachable!(),
                                                                                                                                                                                                                                                   };
                                                                                                                                                                                                                                               if v6969.clone()
                                                                                                                                                                                                                                                      !=
                                                                                                                                                                                                                                                      string("")
                                                                                                                                                                                                                                                  {
                                                                                                                                                                                                                                                   let v7031:
                                                                                                                                                                                                                                                           Result<std::path::PathBuf,
                                                                                                                                                                                                                                                                  std::io::Error> =
                                                                                                                                                                                                                                                       std::fs::read_link(&*v7026.clone());
                                                                                                                                                                                                                                                   let v7032 =
                                                                                                                                                                                                                                                       File_system::method79();
                                                                                                                                                                                                                                                   let v7044:
                                                                                                                                                                                                                                                           Result<std::path::PathBuf,
                                                                                                                                                                                                                                                                  string> =
                                                                                                                                                                                                                                                       v7031.map_err(|x| v7032(x));
                                                                                                                                                                                                                                                   let v7047:
                                                                                                                                                                                                                                                           File_system::US13 =
                                                                                                                                                                                                                                                       match &v7044
                                                                                                                                                                                                                                                           {
                                                                                                                                                                                                                                                           Err(v7044_1_0)
                                                                                                                                                                                                                                                           =>
                                                                                                                                                                                                                                                           v6418(v7044_1_0.clone()),
                                                                                                                                                                                                                                                           Ok(v7044_0_0)
                                                                                                                                                                                                                                                           =>
                                                                                                                                                                                                                                                           v6417(v7044_0_0.clone()),
                                                                                                                                                                                                                                                       };
                                                                                                                                                                                                                                                   let v7113:
                                                                                                                                                                                                                                                           Result<std::path::PathBuf,
                                                                                                                                                                                                                                                                  std::io::Error> =
                                                                                                                                                                                                                                                       match &v7047
                                                                                                                                                                                                                                                           {
                                                                                                                                                                                                                                                           File_system::US13::US13_0(v7047_0_0)
                                                                                                                                                                                                                                                           =>
                                                                                                                                                                                                                                                           Ok(v7047_0_0.clone()),
                                                                                                                                                                                                                                                           _
                                                                                                                                                                                                                                                           =>
                                                                                                                                                                                                                                                           {
                                                                                                                                                                                                                                                               let v7064:
                                                                                                                                                                                                                                                                       string =
                                                                                                                                                                                                                                                                   File_system::method19(v7026.clone());
                                                                                                                                                                                                                                                               let v7065:
                                                                                                                                                                                                                                                                       Option<string> =
                                                                                                                                                                                                                                                                   File_system::method81(v7026.clone());
                                                                                                                                                                                                                                                               let v7079:
                                                                                                                                                                                                                                                                       File_system::US1 =
                                                                                                                                                                                                                                                                   defaultValue(File_system::US1::US1_1,
                                                                                                                                                                                                                                                                                map(File_system::method4(),
                                                                                                                                                                                                                                                                                    v7065));
                                                                                                                                                                                                                                                               let v7083:
                                                                                                                                                                                                                                                                       string =
                                                                                                                                                                                                                                                                   sprintf!("file_system.read_link / path: {} / n: {} / path\': {} / name: {}",
                                                                                                                                                                                                                                                                            v1_1.clone(),
                                                                                                                                                                                                                                                                            11_u8,
                                                                                                                                                                                                                                                                            v7026.clone(),
                                                                                                                                                                                                                                                                            v7064);
                                                                                                                                                                                                                                                               let v7090:
                                                                                                                                                                                                                                                                       std::io::Error =
                                                                                                                                                                                                                                                                   std::io::Error::new(std::io::ErrorKind::Other, &*v7083);
                                                                                                                                                                                                                                                               Err(v7090)
                                                                                                                                                                                                                                                           }
                                                                                                                                                                                                                                                       };
                                                                                                                                                                                                                                                   let v7114 =
                                                                                                                                                                                                                                                       File_system::method79();
                                                                                                                                                                                                                                                   let v7126:
                                                                                                                                                                                                                                                           Result<std::path::PathBuf,
                                                                                                                                                                                                                                                                  string> =
                                                                                                                                                                                                                                                       v7113.map_err(|x| v7114(x));
                                                                                                                                                                                                                                                   let v7129:
                                                                                                                                                                                                                                                           File_system::US13 =
                                                                                                                                                                                                                                                       match &v7126
                                                                                                                                                                                                                                                           {
                                                                                                                                                                                                                                                           Err(v7126_1_0)
                                                                                                                                                                                                                                                           =>
                                                                                                                                                                                                                                                           v6418(v7126_1_0.clone()),
                                                                                                                                                                                                                                                           Ok(v7126_0_0)
                                                                                                                                                                                                                                                           =>
                                                                                                                                                                                                                                                           v6417(v7126_0_0.clone()),
                                                                                                                                                                                                                                                       };
                                                                                                                                                                                                                                                   match &v7129
                                                                                                                                                                                                                                                       {
                                                                                                                                                                                                                                                       File_system::US13::US13_0(v7129_0_0)
                                                                                                                                                                                                                                                       =>
                                                                                                                                                                                                                                                       {
                                                                                                                                                                                                                                                           let v7158:
                                                                                                                                                                                                                                                                   string =
                                                                                                                                                                                                                                                               File_system::method59(toString(v7129_0_0.clone().display()),
                                                                                                                                                                                                                                                                                     v7007.clone());
                                                                                                                                                                                                                                                           let v7165:
                                                                                                                                                                                                                                                                   &str =
                                                                                                                                                                                                                                                               &*v7158;
                                                                                                                                                                                                                                                           let v7189:
                                                                                                                                                                                                                                                                   std::string::String =
                                                                                                                                                                                                                                                               String::from(v7165);
                                                                                                                                                                                                                                                           let v7213:
                                                                                                                                                                                                                                                                   std::path::PathBuf =
                                                                                                                                                                                                                                                               std::path::PathBuf::from(v7189);
                                                                                                                                                                                                                                                           Ok(v7213)
                                                                                                                                                                                                                                                       }
                                                                                                                                                                                                                                                       File_system::US13::US13_1(v7129_1_0)
                                                                                                                                                                                                                                                       =>
                                                                                                                                                                                                                                                       {
                                                                                                                                                                                                                                                           let v7246:
                                                                                                                                                                                                                                                                   string =
                                                                                                                                                                                                                                                               sprintf!("file_system.read_link / error\': {} / error: {} / name: {}",
                                                                                                                                                                                                                                                                        v7129_1_0.clone(),
                                                                                                                                                                                                                                                                        v7006.clone(),
                                                                                                                                                                                                                                                                        v7007.clone());
                                                                                                                                                                                                                                                           let v7253:
                                                                                                                                                                                                                                                                   std::io::Error =
                                                                                                                                                                                                                                                               std::io::Error::new(std::io::ErrorKind::Other, &*v7246);
                                                                                                                                                                                                                                                           Err(v7253)
                                                                                                                                                                                                                                                       }
                                                                                                                                                                                                                                                   }
                                                                                                                                                                                                                                               } else {
                                                                                                                                                                                                                                                   let v7277:
                                                                                                                                                                                                                                                           string =
                                                                                                                                                                                                                                                       sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                                                                                                                                                                                                                                v1_1.clone(),
                                                                                                                                                                                                                                                                v7006.clone(),
                                                                                                                                                                                                                                                                v6969.clone(),
                                                                                                                                                                                                                                                                v7007.clone());
                                                                                                                                                                                                                                                   let v7284:
                                                                                                                                                                                                                                                           std::io::Error =
                                                                                                                                                                                                                                                       std::io::Error::new(std::io::ErrorKind::Other, &*v7277);
                                                                                                                                                                                                                                                   Err(v7284)
                                                                                                                                                                                                                                               }
                                                                                                                                                                                                                                           } else {
                                                                                                                                                                                                                                               let v7307:
                                                                                                                                                                                                                                                       string =
                                                                                                                                                                                                                                                   sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                                                                                                                                                                                                                            v1_1.clone(),
                                                                                                                                                                                                                                                            v7006,
                                                                                                                                                                                                                                                            v6969.clone(),
                                                                                                                                                                                                                                                            v7007.clone());
                                                                                                                                                                                                                                               let v7314:
                                                                                                                                                                                                                                                       std::io::Error =
                                                                                                                                                                                                                                                   std::io::Error::new(std::io::ErrorKind::Other, &*v7307);
                                                                                                                                                                                                                                               Err(v7314)
                                                                                                                                                                                                                                           }
                                                                                                                                                                                                                                       }
                                                                                                                                                                                                                                   };
                                                                                                                                                                                                                               let v7339 =
                                                                                                                                                                                                                                   File_system::method79();
                                                                                                                                                                                                                               let v7351:
                                                                                                                                                                                                                                       Result<std::path::PathBuf,
                                                                                                                                                                                                                                              string> =
                                                                                                                                                                                                                                   v7338.map_err(|x| v7339(x));
                                                                                                                                                                                                                               let v7354:
                                                                                                                                                                                                                                       File_system::US13 =
                                                                                                                                                                                                                                   match &v7351
                                                                                                                                                                                                                                       {
                                                                                                                                                                                                                                       Err(v7351_1_0)
                                                                                                                                                                                                                                       =>
                                                                                                                                                                                                                                       v6418(v7351_1_0.clone()),
                                                                                                                                                                                                                                       Ok(v7351_0_0)
                                                                                                                                                                                                                                       =>
                                                                                                                                                                                                                                       v6417(v7351_0_0.clone()),
                                                                                                                                                                                                                                   };
                                                                                                                                                                                                                               match &v7354
                                                                                                                                                                                                                                   {
                                                                                                                                                                                                                                   File_system::US13::US13_0(v7354_0_0)
                                                                                                                                                                                                                                   =>
                                                                                                                                                                                                                                   {
                                                                                                                                                                                                                                       let v7383:
                                                                                                                                                                                                                                               string =
                                                                                                                                                                                                                                           File_system::method59(toString(v7354_0_0.clone().display()),
                                                                                                                                                                                                                                                                 v6950.clone());
                                                                                                                                                                                                                                       let v7390:
                                                                                                                                                                                                                                               &str =
                                                                                                                                                                                                                                           &*v7383;
                                                                                                                                                                                                                                       let v7414:
                                                                                                                                                                                                                                               std::string::String =
                                                                                                                                                                                                                                           String::from(v7390);
                                                                                                                                                                                                                                       let v7438:
                                                                                                                                                                                                                                               std::path::PathBuf =
                                                                                                                                                                                                                                           std::path::PathBuf::from(v7414);
                                                                                                                                                                                                                                       Ok(v7438)
                                                                                                                                                                                                                                   }
                                                                                                                                                                                                                                   File_system::US13::US13_1(v7354_1_0)
                                                                                                                                                                                                                                   =>
                                                                                                                                                                                                                                   {
                                                                                                                                                                                                                                       let v7471:
                                                                                                                                                                                                                                               string =
                                                                                                                                                                                                                                           sprintf!("file_system.read_link / error\': {} / error: {} / name: {}",
                                                                                                                                                                                                                                                    v7354_1_0.clone(),
                                                                                                                                                                                                                                                    v6949.clone(),
                                                                                                                                                                                                                                                    v6950.clone());
                                                                                                                                                                                                                                       let v7478:
                                                                                                                                                                                                                                               std::io::Error =
                                                                                                                                                                                                                                           std::io::Error::new(std::io::ErrorKind::Other, &*v7471);
                                                                                                                                                                                                                                       Err(v7478)
                                                                                                                                                                                                                                   }
                                                                                                                                                                                                                               }
                                                                                                                                                                                                                           } else {
                                                                                                                                                                                                                               let v7502:
                                                                                                                                                                                                                                       string =
                                                                                                                                                                                                                                   sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                                                                                                                                                                                                            v1_1.clone(),
                                                                                                                                                                                                                                            v6949.clone(),
                                                                                                                                                                                                                                            v6912.clone(),
                                                                                                                                                                                                                                            v6950.clone());
                                                                                                                                                                                                                               let v7509:
                                                                                                                                                                                                                                       std::io::Error =
                                                                                                                                                                                                                                   std::io::Error::new(std::io::ErrorKind::Other, &*v7502);
                                                                                                                                                                                                                               Err(v7509)
                                                                                                                                                                                                                           }
                                                                                                                                                                                                                       } else {
                                                                                                                                                                                                                           let v7532:
                                                                                                                                                                                                                                   string =
                                                                                                                                                                                                                               sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                                                                                                                                                                                                        v1_1.clone(),
                                                                                                                                                                                                                                        v6949,
                                                                                                                                                                                                                                        v6912.clone(),
                                                                                                                                                                                                                                        v6950.clone());
                                                                                                                                                                                                                           let v7539:
                                                                                                                                                                                                                                   std::io::Error =
                                                                                                                                                                                                                               std::io::Error::new(std::io::ErrorKind::Other, &*v7532);
                                                                                                                                                                                                                           Err(v7539)
                                                                                                                                                                                                                       }
                                                                                                                                                                                                                   }
                                                                                                                                                                                                               };
                                                                                                                                                                                                           let v7564 =
                                                                                                                                                                                                               File_system::method79();
                                                                                                                                                                                                           let v7576:
                                                                                                                                                                                                                   Result<std::path::PathBuf,
                                                                                                                                                                                                                          string> =
                                                                                                                                                                                                               v7563.map_err(|x| v7564(x));
                                                                                                                                                                                                           let v7579:
                                                                                                                                                                                                                   File_system::US13 =
                                                                                                                                                                                                               match &v7576
                                                                                                                                                                                                                   {
                                                                                                                                                                                                                   Err(v7576_1_0)
                                                                                                                                                                                                                   =>
                                                                                                                                                                                                                   v6418(v7576_1_0.clone()),
                                                                                                                                                                                                                   Ok(v7576_0_0)
                                                                                                                                                                                                                   =>
                                                                                                                                                                                                                   v6417(v7576_0_0.clone()),
                                                                                                                                                                                                               };
                                                                                                                                                                                                           match &v7579
                                                                                                                                                                                                               {
                                                                                                                                                                                                               File_system::US13::US13_0(v7579_0_0)
                                                                                                                                                                                                               =>
                                                                                                                                                                                                               {
                                                                                                                                                                                                                   let v7608:
                                                                                                                                                                                                                           string =
                                                                                                                                                                                                                       File_system::method59(toString(v7579_0_0.clone().display()),
                                                                                                                                                                                                                                             v6893.clone());
                                                                                                                                                                                                                   let v7615:
                                                                                                                                                                                                                           &str =
                                                                                                                                                                                                                       &*v7608;
                                                                                                                                                                                                                   let v7639:
                                                                                                                                                                                                                           std::string::String =
                                                                                                                                                                                                                       String::from(v7615);
                                                                                                                                                                                                                   let v7663:
                                                                                                                                                                                                                           std::path::PathBuf =
                                                                                                                                                                                                                       std::path::PathBuf::from(v7639);
                                                                                                                                                                                                                   Ok(v7663)
                                                                                                                                                                                                               }
                                                                                                                                                                                                               File_system::US13::US13_1(v7579_1_0)
                                                                                                                                                                                                               =>
                                                                                                                                                                                                               {
                                                                                                                                                                                                                   let v7696:
                                                                                                                                                                                                                           string =
                                                                                                                                                                                                                       sprintf!("file_system.read_link / error\': {} / error: {} / name: {}",
                                                                                                                                                                                                                                v7579_1_0.clone(),
                                                                                                                                                                                                                                v6892.clone(),
                                                                                                                                                                                                                                v6893.clone());
                                                                                                                                                                                                                   let v7703:
                                                                                                                                                                                                                           std::io::Error =
                                                                                                                                                                                                                       std::io::Error::new(std::io::ErrorKind::Other, &*v7696);
                                                                                                                                                                                                                   Err(v7703)
                                                                                                                                                                                                               }
                                                                                                                                                                                                           }
                                                                                                                                                                                                       } else {
                                                                                                                                                                                                           let v7727:
                                                                                                                                                                                                                   string =
                                                                                                                                                                                                               sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                                                                                                                                                                                        v1_1.clone(),
                                                                                                                                                                                                                        v6892.clone(),
                                                                                                                                                                                                                        v6855.clone(),
                                                                                                                                                                                                                        v6893.clone());
                                                                                                                                                                                                           let v7734:
                                                                                                                                                                                                                   std::io::Error =
                                                                                                                                                                                                               std::io::Error::new(std::io::ErrorKind::Other, &*v7727);
                                                                                                                                                                                                           Err(v7734)
                                                                                                                                                                                                       }
                                                                                                                                                                                                   } else {
                                                                                                                                                                                                       let v7757:
                                                                                                                                                                                                               string =
                                                                                                                                                                                                           sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                                                                                                                                                                                    v1_1.clone(),
                                                                                                                                                                                                                    v6892,
                                                                                                                                                                                                                    v6855.clone(),
                                                                                                                                                                                                                    v6893.clone());
                                                                                                                                                                                                       let v7764:
                                                                                                                                                                                                               std::io::Error =
                                                                                                                                                                                                           std::io::Error::new(std::io::ErrorKind::Other, &*v7757);
                                                                                                                                                                                                       Err(v7764)
                                                                                                                                                                                                   }
                                                                                                                                                                                               }
                                                                                                                                                                                           };
                                                                                                                                                                                       let v7789 =
                                                                                                                                                                                           File_system::method79();
                                                                                                                                                                                       let v7801:
                                                                                                                                                                                               Result<std::path::PathBuf,
                                                                                                                                                                                                      string> =
                                                                                                                                                                                           v7788.map_err(|x| v7789(x));
                                                                                                                                                                                       let v7804:
                                                                                                                                                                                               File_system::US13 =
                                                                                                                                                                                           match &v7801
                                                                                                                                                                                               {
                                                                                                                                                                                               Err(v7801_1_0)
                                                                                                                                                                                               =>
                                                                                                                                                                                               v6418(v7801_1_0.clone()),
                                                                                                                                                                                               Ok(v7801_0_0)
                                                                                                                                                                                               =>
                                                                                                                                                                                               v6417(v7801_0_0.clone()),
                                                                                                                                                                                           };
                                                                                                                                                                                       match &v7804
                                                                                                                                                                                           {
                                                                                                                                                                                           File_system::US13::US13_0(v7804_0_0)
                                                                                                                                                                                           =>
                                                                                                                                                                                           {
                                                                                                                                                                                               let v7833:
                                                                                                                                                                                                       string =
                                                                                                                                                                                                   File_system::method59(toString(v7804_0_0.clone().display()),
                                                                                                                                                                                                                         v6836.clone());
                                                                                                                                                                                               let v7840:
                                                                                                                                                                                                       &str =
                                                                                                                                                                                                   &*v7833;
                                                                                                                                                                                               let v7864:
                                                                                                                                                                                                       std::string::String =
                                                                                                                                                                                                   String::from(v7840);
                                                                                                                                                                                               let v7888:
                                                                                                                                                                                                       std::path::PathBuf =
                                                                                                                                                                                                   std::path::PathBuf::from(v7864);
                                                                                                                                                                                               Ok(v7888)
                                                                                                                                                                                           }
                                                                                                                                                                                           File_system::US13::US13_1(v7804_1_0)
                                                                                                                                                                                           =>
                                                                                                                                                                                           {
                                                                                                                                                                                               let v7921:
                                                                                                                                                                                                       string =
                                                                                                                                                                                                   sprintf!("file_system.read_link / error\': {} / error: {} / name: {}",
                                                                                                                                                                                                            v7804_1_0.clone(),
                                                                                                                                                                                                            v6835.clone(),
                                                                                                                                                                                                            v6836.clone());
                                                                                                                                                                                               let v7928:
                                                                                                                                                                                                       std::io::Error =
                                                                                                                                                                                                   std::io::Error::new(std::io::ErrorKind::Other, &*v7921);
                                                                                                                                                                                               Err(v7928)
                                                                                                                                                                                           }
                                                                                                                                                                                       }
                                                                                                                                                                                   } else {
                                                                                                                                                                                       let v7952:
                                                                                                                                                                                               string =
                                                                                                                                                                                           sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                                                                                                                                                                    v1_1.clone(),
                                                                                                                                                                                                    v6835.clone(),
                                                                                                                                                                                                    v6798.clone(),
                                                                                                                                                                                                    v6836.clone());
                                                                                                                                                                                       let v7959:
                                                                                                                                                                                               std::io::Error =
                                                                                                                                                                                           std::io::Error::new(std::io::ErrorKind::Other, &*v7952);
                                                                                                                                                                                       Err(v7959)
                                                                                                                                                                                   }
                                                                                                                                                                               } else {
                                                                                                                                                                                   let v7982:
                                                                                                                                                                                           string =
                                                                                                                                                                                       sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                                                                                                                                                                v1_1.clone(),
                                                                                                                                                                                                v6835,
                                                                                                                                                                                                v6798.clone(),
                                                                                                                                                                                                v6836.clone());
                                                                                                                                                                                   let v7989:
                                                                                                                                                                                           std::io::Error =
                                                                                                                                                                                       std::io::Error::new(std::io::ErrorKind::Other, &*v7982);
                                                                                                                                                                                   Err(v7989)
                                                                                                                                                                               }
                                                                                                                                                                           }
                                                                                                                                                                       };
                                                                                                                                                                   let v8014 =
                                                                                                                                                                       File_system::method79();
                                                                                                                                                                   let v8026:
                                                                                                                                                                           Result<std::path::PathBuf,
                                                                                                                                                                                  string> =
                                                                                                                                                                       v8013.map_err(|x| v8014(x));
                                                                                                                                                                   let v8029:
                                                                                                                                                                           File_system::US13 =
                                                                                                                                                                       match &v8026
                                                                                                                                                                           {
                                                                                                                                                                           Err(v8026_1_0)
                                                                                                                                                                           =>
                                                                                                                                                                           v6418(v8026_1_0.clone()),
                                                                                                                                                                           Ok(v8026_0_0)
                                                                                                                                                                           =>
                                                                                                                                                                           v6417(v8026_0_0.clone()),
                                                                                                                                                                       };
                                                                                                                                                                   match &v8029
                                                                                                                                                                       {
                                                                                                                                                                       File_system::US13::US13_0(v8029_0_0)
                                                                                                                                                                       =>
                                                                                                                                                                       {
                                                                                                                                                                           let v8058:
                                                                                                                                                                                   string =
                                                                                                                                                                               File_system::method59(toString(v8029_0_0.clone().display()),
                                                                                                                                                                                                     v6779.clone());
                                                                                                                                                                           let v8065:
                                                                                                                                                                                   &str =
                                                                                                                                                                               &*v8058;
                                                                                                                                                                           let v8089:
                                                                                                                                                                                   std::string::String =
                                                                                                                                                                               String::from(v8065);
                                                                                                                                                                           let v8113:
                                                                                                                                                                                   std::path::PathBuf =
                                                                                                                                                                               std::path::PathBuf::from(v8089);
                                                                                                                                                                           Ok(v8113)
                                                                                                                                                                       }
                                                                                                                                                                       File_system::US13::US13_1(v8029_1_0)
                                                                                                                                                                       =>
                                                                                                                                                                       {
                                                                                                                                                                           let v8146:
                                                                                                                                                                                   string =
                                                                                                                                                                               sprintf!("file_system.read_link / error\': {} / error: {} / name: {}",
                                                                                                                                                                                        v8029_1_0.clone(),
                                                                                                                                                                                        v6778.clone(),
                                                                                                                                                                                        v6779.clone());
                                                                                                                                                                           let v8153:
                                                                                                                                                                                   std::io::Error =
                                                                                                                                                                               std::io::Error::new(std::io::ErrorKind::Other, &*v8146);
                                                                                                                                                                           Err(v8153)
                                                                                                                                                                       }
                                                                                                                                                                   }
                                                                                                                                                               } else {
                                                                                                                                                                   let v8177:
                                                                                                                                                                           string =
                                                                                                                                                                       sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                                                                                                                                                v1_1.clone(),
                                                                                                                                                                                v6778.clone(),
                                                                                                                                                                                v6741.clone(),
                                                                                                                                                                                v6779.clone());
                                                                                                                                                                   let v8184:
                                                                                                                                                                           std::io::Error =
                                                                                                                                                                       std::io::Error::new(std::io::ErrorKind::Other, &*v8177);
                                                                                                                                                                   Err(v8184)
                                                                                                                                                               }
                                                                                                                                                           } else {
                                                                                                                                                               let v8207:
                                                                                                                                                                       string =
                                                                                                                                                                   sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                                                                                                                                            v1_1.clone(),
                                                                                                                                                                            v6778,
                                                                                                                                                                            v6741.clone(),
                                                                                                                                                                            v6779.clone());
                                                                                                                                                               let v8214:
                                                                                                                                                                       std::io::Error =
                                                                                                                                                                   std::io::Error::new(std::io::ErrorKind::Other, &*v8207);
                                                                                                                                                               Err(v8214)
                                                                                                                                                           }
                                                                                                                                                       }
                                                                                                                                                   };
                                                                                                                                               let v8239 =
                                                                                                                                                   File_system::method79();
                                                                                                                                               let v8251:
                                                                                                                                                       Result<std::path::PathBuf,
                                                                                                                                                              string> =
                                                                                                                                                   v8238.map_err(|x| v8239(x));
                                                                                                                                               let v8254:
                                                                                                                                                       File_system::US13 =
                                                                                                                                                   match &v8251
                                                                                                                                                       {
                                                                                                                                                       Err(v8251_1_0)
                                                                                                                                                       =>
                                                                                                                                                       v6418(v8251_1_0.clone()),
                                                                                                                                                       Ok(v8251_0_0)
                                                                                                                                                       =>
                                                                                                                                                       v6417(v8251_0_0.clone()),
                                                                                                                                                   };
                                                                                                                                               match &v8254
                                                                                                                                                   {
                                                                                                                                                   File_system::US13::US13_0(v8254_0_0)
                                                                                                                                                   =>
                                                                                                                                                   {
                                                                                                                                                       let v8283:
                                                                                                                                                               string =
                                                                                                                                                           File_system::method59(toString(v8254_0_0.clone().display()),
                                                                                                                                                                                 v6722.clone());
                                                                                                                                                       let v8290:
                                                                                                                                                               &str =
                                                                                                                                                           &*v8283;
                                                                                                                                                       let v8314:
                                                                                                                                                               std::string::String =
                                                                                                                                                           String::from(v8290);
                                                                                                                                                       let v8338:
                                                                                                                                                               std::path::PathBuf =
                                                                                                                                                           std::path::PathBuf::from(v8314);
                                                                                                                                                       Ok(v8338)
                                                                                                                                                   }
                                                                                                                                                   File_system::US13::US13_1(v8254_1_0)
                                                                                                                                                   =>
                                                                                                                                                   {
                                                                                                                                                       let v8371:
                                                                                                                                                               string =
                                                                                                                                                           sprintf!("file_system.read_link / error\': {} / error: {} / name: {}",
                                                                                                                                                                    v8254_1_0.clone(),
                                                                                                                                                                    v6721.clone(),
                                                                                                                                                                    v6722.clone());
                                                                                                                                                       let v8378:
                                                                                                                                                               std::io::Error =
                                                                                                                                                           std::io::Error::new(std::io::ErrorKind::Other, &*v8371);
                                                                                                                                                       Err(v8378)
                                                                                                                                                   }
                                                                                                                                               }
                                                                                                                                           } else {
                                                                                                                                               let v8402:
                                                                                                                                                       string =
                                                                                                                                                   sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                                                                                                                            v1_1.clone(),
                                                                                                                                                            v6721.clone(),
                                                                                                                                                            v6684.clone(),
                                                                                                                                                            v6722.clone());
                                                                                                                                               let v8409:
                                                                                                                                                       std::io::Error =
                                                                                                                                                   std::io::Error::new(std::io::ErrorKind::Other, &*v8402);
                                                                                                                                               Err(v8409)
                                                                                                                                           }
                                                                                                                                       } else {
                                                                                                                                           let v8432:
                                                                                                                                                   string =
                                                                                                                                               sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                                                                                                                        v1_1.clone(),
                                                                                                                                                        v6721,
                                                                                                                                                        v6684.clone(),
                                                                                                                                                        v6722.clone());
                                                                                                                                           let v8439:
                                                                                                                                                   std::io::Error =
                                                                                                                                               std::io::Error::new(std::io::ErrorKind::Other, &*v8432);
                                                                                                                                           Err(v8439)
                                                                                                                                       }
                                                                                                                                   }
                                                                                                                               };
                                                                                                                           let v8464 =
                                                                                                                               File_system::method79();
                                                                                                                           let v8476:
                                                                                                                                   Result<std::path::PathBuf,
                                                                                                                                          string> =
                                                                                                                               v8463.map_err(|x| v8464(x));
                                                                                                                           let v8479:
                                                                                                                                   File_system::US13 =
                                                                                                                               match &v8476
                                                                                                                                   {
                                                                                                                                   Err(v8476_1_0)
                                                                                                                                   =>
                                                                                                                                   v6418(v8476_1_0.clone()),
                                                                                                                                   Ok(v8476_0_0)
                                                                                                                                   =>
                                                                                                                                   v6417(v8476_0_0.clone()),
                                                                                                                               };
                                                                                                                           match &v8479
                                                                                                                               {
                                                                                                                               File_system::US13::US13_0(v8479_0_0)
                                                                                                                               =>
                                                                                                                               {
                                                                                                                                   let v8508:
                                                                                                                                           string =
                                                                                                                                       File_system::method59(toString(v8479_0_0.clone().display()),
                                                                                                                                                             v6665.clone());
                                                                                                                                   let v8515:
                                                                                                                                           &str =
                                                                                                                                       &*v8508;
                                                                                                                                   let v8539:
                                                                                                                                           std::string::String =
                                                                                                                                       String::from(v8515);
                                                                                                                                   let v8563:
                                                                                                                                           std::path::PathBuf =
                                                                                                                                       std::path::PathBuf::from(v8539);
                                                                                                                                   Ok(v8563)
                                                                                                                               }
                                                                                                                               File_system::US13::US13_1(v8479_1_0)
                                                                                                                               =>
                                                                                                                               {
                                                                                                                                   let v8596:
                                                                                                                                           string =
                                                                                                                                       sprintf!("file_system.read_link / error\': {} / error: {} / name: {}",
                                                                                                                                                v8479_1_0.clone(),
                                                                                                                                                v6664.clone(),
                                                                                                                                                v6665.clone());
                                                                                                                                   let v8603:
                                                                                                                                           std::io::Error =
                                                                                                                                       std::io::Error::new(std::io::ErrorKind::Other, &*v8596);
                                                                                                                                   Err(v8603)
                                                                                                                               }
                                                                                                                           }
                                                                                                                       } else {
                                                                                                                           let v8627:
                                                                                                                                   string =
                                                                                                                               sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                                                                                                        v1_1.clone(),
                                                                                                                                        v6664.clone(),
                                                                                                                                        v6627.clone(),
                                                                                                                                        v6665.clone());
                                                                                                                           let v8634:
                                                                                                                                   std::io::Error =
                                                                                                                               std::io::Error::new(std::io::ErrorKind::Other, &*v8627);
                                                                                                                           Err(v8634)
                                                                                                                       }
                                                                                                                   } else {
                                                                                                                       let v8657:
                                                                                                                               string =
                                                                                                                           sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                                                                                                    v1_1.clone(),
                                                                                                                                    v6664,
                                                                                                                                    v6627.clone(),
                                                                                                                                    v6665.clone());
                                                                                                                       let v8664:
                                                                                                                               std::io::Error =
                                                                                                                           std::io::Error::new(std::io::ErrorKind::Other, &*v8657);
                                                                                                                       Err(v8664)
                                                                                                                   }
                                                                                                               }
                                                                                                           };
                                                                                                       let v8689 =
                                                                                                           File_system::method79();
                                                                                                       let v8701:
                                                                                                               Result<std::path::PathBuf,
                                                                                                                      string> =
                                                                                                           v8688.map_err(|x| v8689(x));
                                                                                                       let v8704:
                                                                                                               File_system::US13 =
                                                                                                           match &v8701
                                                                                                               {
                                                                                                               Err(v8701_1_0)
                                                                                                               =>
                                                                                                               v6418(v8701_1_0.clone()),
                                                                                                               Ok(v8701_0_0)
                                                                                                               =>
                                                                                                               v6417(v8701_0_0.clone()),
                                                                                                           };
                                                                                                       match &v8704
                                                                                                           {
                                                                                                           File_system::US13::US13_0(v8704_0_0)
                                                                                                           =>
                                                                                                           {
                                                                                                               let v8733:
                                                                                                                       string =
                                                                                                                   File_system::method59(toString(v8704_0_0.clone().display()),
                                                                                                                                         v6608.clone());
                                                                                                               let v8740:
                                                                                                                       &str =
                                                                                                                   &*v8733;
                                                                                                               let v8764:
                                                                                                                       std::string::String =
                                                                                                                   String::from(v8740);
                                                                                                               let v8788:
                                                                                                                       std::path::PathBuf =
                                                                                                                   std::path::PathBuf::from(v8764);
                                                                                                               Ok(v8788)
                                                                                                           }
                                                                                                           File_system::US13::US13_1(v8704_1_0)
                                                                                                           =>
                                                                                                           {
                                                                                                               let v8821:
                                                                                                                       string =
                                                                                                                   sprintf!("file_system.read_link / error\': {} / error: {} / name: {}",
                                                                                                                            v8704_1_0.clone(),
                                                                                                                            v6607.clone(),
                                                                                                                            v6608.clone());
                                                                                                               let v8828:
                                                                                                                       std::io::Error =
                                                                                                                   std::io::Error::new(std::io::ErrorKind::Other, &*v8821);
                                                                                                               Err(v8828)
                                                                                                           }
                                                                                                       }
                                                                                                   } else {
                                                                                                       let v8852:
                                                                                                               string =
                                                                                                           sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                                                                                    v1_1.clone(),
                                                                                                                    v6607.clone(),
                                                                                                                    v6570.clone(),
                                                                                                                    v6608.clone());
                                                                                                       let v8859:
                                                                                                               std::io::Error =
                                                                                                           std::io::Error::new(std::io::ErrorKind::Other, &*v8852);
                                                                                                       Err(v8859)
                                                                                                   }
                                                                                               } else {
                                                                                                   let v8882:
                                                                                                           string =
                                                                                                       sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                                                                                v1_1.clone(),
                                                                                                                v6607,
                                                                                                                v6570.clone(),
                                                                                                                v6608.clone());
                                                                                                   let v8889:
                                                                                                           std::io::Error =
                                                                                                       std::io::Error::new(std::io::ErrorKind::Other, &*v8882);
                                                                                                   Err(v8889)
                                                                                               }
                                                                                           }
                                                                                       };
                                                                        let v8914 =
                                                                            File_system::method79();
                                                                        let v8926: Result<
                                                                            std::path::PathBuf,
                                                                            string,
                                                                        > = v8913
                                                                            .map_err(|x| v8914(x));
                                                                        let v8929:
                                                                                           File_system::US13 =
                                                                                       match &v8926
                                                                                           {
                                                                                           Err(v8926_1_0)
                                                                                           =>
                                                                                           v6418(v8926_1_0.clone()),
                                                                                           Ok(v8926_0_0)
                                                                                           =>
                                                                                           v6417(v8926_0_0.clone()),
                                                                                       };
                                                                        match &v8929
                                                                                       {
                                                                                       File_system::US13::US13_0(v8929_0_0)
                                                                                       =>
                                                                                       {
                                                                                           let v8958:
                                                                                                   string =
                                                                                               File_system::method59(toString(v8929_0_0.clone().display()),
                                                                                                                     v6551.clone());
                                                                                           let v8965:
                                                                                                   &str =
                                                                                               &*v8958;
                                                                                           let v8989:
                                                                                                   std::string::String =
                                                                                               String::from(v8965);
                                                                                           let v9013:
                                                                                                   std::path::PathBuf =
                                                                                               std::path::PathBuf::from(v8989);
                                                                                           Ok(v9013)
                                                                                       }
                                                                                       File_system::US13::US13_1(v8929_1_0)
                                                                                       =>
                                                                                       {
                                                                                           let v9046:
                                                                                                   string =
                                                                                               sprintf!("file_system.read_link / error\': {} / error: {} / name: {}",
                                                                                                        v8929_1_0.clone(),
                                                                                                        v6550.clone(),
                                                                                                        v6551.clone());
                                                                                           let v9053:
                                                                                                   std::io::Error =
                                                                                               std::io::Error::new(std::io::ErrorKind::Other, &*v9046);
                                                                                           Err(v9053)
                                                                                       }
                                                                                   }
                                                                    } else {
                                                                        let v9077:
                                                                                           string =
                                                                                       sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                                                                v1_1.clone(),
                                                                                                v6550.clone(),
                                                                                                v6513.clone(),
                                                                                                v6551.clone());
                                                                        let v9084:
                                                                                           std::io::Error =
                                                                                       std::io::Error::new(std::io::ErrorKind::Other, &*v9077);
                                                                        Err(v9084)
                                                                    }
                                                                } else {
                                                                    let v9107:
                                                                                       string =
                                                                                   sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                                                            v1_1.clone(),
                                                                                            v6550,
                                                                                            v6513.clone(),
                                                                                            v6551.clone());
                                                                    let v9114:
                                                                                       std::io::Error =
                                                                                   std::io::Error::new(std::io::ErrorKind::Other, &*v9107);
                                                                    Err(v9114)
                                                                }
                                                            }
                                                        };
                                                        let v9139 = File_system::method79();
                                                        let v9151: Result<
                                                            std::path::PathBuf,
                                                            string,
                                                        > = v9138.map_err(|x| v9139(x));
                                                        let v9154: File_system::US13 = match &v9151
                                                        {
                                                            Err(v9151_1_0) => {
                                                                v6418(v9151_1_0.clone())
                                                            }
                                                            Ok(v9151_0_0) => {
                                                                v6417(v9151_0_0.clone())
                                                            }
                                                        };
                                                        match &v9154 {
                                                            File_system::US13::US13_0(
                                                                v9154_0_0,
                                                            ) => {
                                                                let v9183: string =
                                                                    File_system::method59(
                                                                        toString(
                                                                            v9154_0_0
                                                                                .clone()
                                                                                .display(),
                                                                        ),
                                                                        v6494.clone(),
                                                                    );
                                                                let v9190: &str = &*v9183;
                                                                let v9214: std::string::String =
                                                                    String::from(v9190);
                                                                let v9238: std::path::PathBuf =
                                                                    std::path::PathBuf::from(v9214);
                                                                Ok(v9238)
                                                            }
                                                            File_system::US13::US13_1(
                                                                v9154_1_0,
                                                            ) => {
                                                                let v9271:
                                                                               string =
                                                                           sprintf!("file_system.read_link / error\': {} / error: {} / name: {}",
                                                                                    v9154_1_0.clone(),
                                                                                    v6493.clone(),
                                                                                    v6494.clone());
                                                                let v9278: std::io::Error =
                                                                    std::io::Error::new(
                                                                        std::io::ErrorKind::Other,
                                                                        &*v9271,
                                                                    );
                                                                Err(v9278)
                                                            }
                                                        }
                                                    } else {
                                                        let v9302:
                                                                       string =
                                                                   sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                                            v1_1.clone(),
                                                                            v6493.clone(),
                                                                            v6455.clone(),
                                                                            v6494.clone());
                                                        let v9309: std::io::Error =
                                                            std::io::Error::new(
                                                                std::io::ErrorKind::Other,
                                                                &*v9302,
                                                            );
                                                        Err(v9309)
                                                    }
                                                } else {
                                                    let v9332: string =
                                                               sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                                        v1_1.clone(),
                                                                        v6493,
                                                                        v6455.clone(),
                                                                        v6494.clone());
                                                    let v9339: std::io::Error = std::io::Error::new(
                                                        std::io::ErrorKind::Other,
                                                        &*v9332,
                                                    );
                                                    Err(v9339)
                                                }
                                            }
                                        };
                                    let v9364 = File_system::method79();
                                    let v9376: Result<std::path::PathBuf, string> =
                                        v9363.map_err(|x| v9364(x));
                                    let v9379: File_system::US13 = match &v9376 {
                                        Err(v9376_1_0) => v6418(v9376_1_0.clone()),
                                        Ok(v9376_0_0) => v6417(v9376_0_0.clone()),
                                    };
                                    match &v9379 {
                                        File_system::US13::US13_0(v9379_0_0) => {
                                            let v9408: string = File_system::method59(
                                                toString(v9379_0_0.clone().display()),
                                                v6436.clone(),
                                            );
                                            let v9415: &str = &*v9408;
                                            let v9439: std::string::String = String::from(v9415);
                                            let v9463: std::path::PathBuf =
                                                std::path::PathBuf::from(v9439);
                                            Ok(v9463)
                                        }
                                        File_system::US13::US13_1(v9379_1_0) => {
                                            let v9496: string =
                                                       sprintf!("file_system.read_link / error\': {} / error: {} / name: {}",
                                                                v9379_1_0.clone(),
                                                                v6435.clone(),
                                                                v6436.clone());
                                            let v9503: std::io::Error = std::io::Error::new(
                                                std::io::ErrorKind::Other,
                                                &*v9496,
                                            );
                                            Err(v9503)
                                        }
                                    }
                                } else {
                                    let v9527: string =
                                               sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                        v1_1.clone(),
                                                        v6435.clone(),
                                                        v1_1.clone(),
                                                        v6436.clone());
                                    let v9534: std::io::Error =
                                        std::io::Error::new(std::io::ErrorKind::Other, &*v9527);
                                    Err(v9534)
                                }
                            } else {
                                let v9557: string =
                                           sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                    v1_1.clone(), v6435,
                                                    v1_1.clone(),
                                                    v6436.clone());
                                let v9564: std::io::Error =
                                    std::io::Error::new(std::io::ErrorKind::Other, &*v9557);
                                Err(v9564)
                            }
                        }
                    }
                };
                v9589.is_err()
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
