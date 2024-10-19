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
        let v117: string = string("env!(\"AUTOMATION\")");
        let v118: &str = env!("AUTOMATION");
        let v125: std::string::String = String::from(v118);
        let _v1: (File_system::US2, File_system::US3) = (
            File_system::US2::US2_1,
            if fable_library_rust::String_::fromString(v125) != string("True") {
                File_system::US3::US3_1
            } else {
                File_system::US3::US3_0(near_sdk::env::block_timestamp() as i64)
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
        let v130: u64 = near_sdk::env::block_timestamp();
        let v144: File_system::US3 =
            defaultValue(File_system::US3::US3_1, map(File_system::method12(), v5));
        let v154: u64 = match &v144 {
            File_system::US3::US3_0(v144_0_0) => {
                v130 - match &v144 {
                    File_system::US3::US3_0(x) => x.clone(),
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
        let v67: &str = inline_colorization::color_bright_blue;
        let v74: &str = &*v6;
        let v90: &str = inline_colorization::color_reset;
        let v92: std::string::String = format!("{}{}{}", v67, v74, v90);
        fable_library_rust::String_::fromString(v92)
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
        let v76 = v60.chars();
        let v78 = v76;
        let v80: Vec<char> = v78.collect::<Vec<_>>();
        let v82: Vec<Vec<char>> = v80
            .chunks(15000)
            .map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>())
            .collect::<Vec<_>>();
        let v84: bool = true;
        let _vec_map: Vec<_> = v82
            .into_iter()
            .map(|x| {
                //;
                let v86: Vec<char> = x;
                let v88: std::string::String = String::from_iter(v86);
                let v90: bool = true;
                v88
            })
            .collect::<Vec<_>>();
        let v92: Vec<std::string::String> = _vec_map;
        if if v0_1.clone() != string("") {
            v92.clone().len() as i32 <= 1_i32
        } else {
            false
        } {
            v20_1.l0.set(v53);
            ()
        } else {
            v20_1.l0.set(string(""));
            {
                let v104: bool = true;
                v92.into_iter().for_each(|x| {
                    //;
                    let v106: std::string::String = x;
                    let v108: bool = true;
                    near_sdk::log!("{}", v106);
                    let v110: bool = true;
                    let v112: bool = true;
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
        let v67: &str = inline_colorization::color_yellow;
        let v74: &str = &*v6;
        let v90: &str = inline_colorization::color_reset;
        let v92: std::string::String = format!("{}{}{}", v67, v74, v90);
        fable_library_rust::String_::fromString(v92)
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
        let v131: () = {
            File_system::closure6(
                v4.clone(),
                sprintf!("{}", fable_library_rust::String_::fromString(v109)),
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
        let v67: &str = inline_colorization::color_bright_black;
        let v74: &str = &*v6;
        let v90: &str = inline_colorization::color_reset;
        let v92: std::string::String = format!("{}{}{}", v67, v74, v90);
        fable_library_rust::String_::fromString(v92)
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
        let v67: &str = inline_colorization::color_bright_red;
        let v74: &str = &*v6;
        let v90: &str = inline_colorization::color_reset;
        let v92: std::string::String = format!("{}{}{}", v67, v74, v90);
        fable_library_rust::String_::fromString(v92)
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
    pub fn closure33(unitVar: (), v0_1: Option<()>) -> File_system::US11 {
        File_system::US11::US11_0(v0_1)
    }
    pub fn method49() -> Func1<Option<()>, File_system::US11> {
        Func1::new(move |v: Option<()>| File_system::closure33((), v))
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
        unbox::<Guid>(&defaultOf())
    }
    pub fn method54() -> string {
        unbox::<string>(&defaultOf())
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
        unbox::<string>(&defaultOf())
    }
    pub fn method60() -> string {
        string("CARGO_PKG_NAME")
    }
    pub fn method59() -> string {
        File_system::method2(File_system::method60())
    }
    pub fn method53(v0_1: Guid) -> string {
        unbox::<string>(&defaultOf())
    }
    pub fn method47() -> string {
        unbox::<string>(&defaultOf())
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
        let v75: std::string::String = format!("{:#?}", v1_1);
        let v97: () = {
            File_system::closure6(
                v3.clone(),
                sprintf!("{}", fable_library_rust::String_::fromString(v75)),
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
        let v8: Arc<Async<i64>> = defaultOf();
        let v31_1: Arc<Async<()>> = defaultOf();
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
            defaultOf::<std::rc::Rc<dyn IDisposable>>(),
            Lrc<dyn IDisposable>,
        )
    }
    pub fn closure34(unitVar: (), unitVar_1: ()) -> (string, LrcPtr<dyn IDisposable>) {
        let v0_1: string = File_system::method47();
        (v0_1.clone(), File_system::method61(v0_1))
    }
    pub fn method74(v0_1: string) -> Guid {
        unbox::<Guid>(&defaultOf())
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
        let v13: std::string::String = format!("{:#?}", v0_1);
        let v35_1: () = {
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
            let v8844: Result<std::path::PathBuf, std::io::Error> = if File_system::method9(
                v0_1.clone(),
            ) {
                std::fs::read_link(&*v0_1.clone())
            } else {
                let v5902: Result<std::path::PathBuf, std::io::Error> =
                    std::fs::read_link(&*v0_1.clone());
                let v5903 = File_system::method76();
                let v5914: Result<std::path::PathBuf, string> = v5902.map_err(|x| v5903(x));
                fn v5917(v: std::path::PathBuf) -> File_system::US13 {
                    File_system::closure47((), v)
                }
                fn v5918(v_1: string) -> File_system::US13 {
                    File_system::closure48((), v_1)
                }
                let v5919: File_system::US13 = match &v5914 {
                    Err(v5914_1_0) => v5918(v5914_1_0.clone()),
                    Ok(v5914_0_0) => v5917(v5914_0_0.clone()),
                };
                match &v5919 {
                    File_system::US13::US13_0(v5919_0_0) => Ok(v5919_0_0.clone()),
                    File_system::US13::US13_1(v5919_1_0) => {
                        let v5934: string = v5919_1_0.clone();
                        let v5935: string = File_system::method19(v0_1.clone());
                        let v5936: Option<string> = File_system::method78(v0_1.clone());
                        let v5950: File_system::US1 = defaultValue(
                            File_system::US1::US1_1,
                            map(File_system::method4(), v5936),
                        );
                        if let File_system::US1::US1_0(v5950_0_0) = &v5950 {
                            let v5954: string = match &v5950 {
                                File_system::US1::US1_0(x) => x.clone(),
                                _ => unreachable!(),
                            };
                            if v0_1.clone() != string("") {
                                let v5960: Result<std::path::PathBuf, std::io::Error> =
                                    std::fs::read_link(&*v5954.clone());
                                let v5961 = File_system::method76();
                                let v5972: Result<std::path::PathBuf, string> =
                                    v5960.map_err(|x| v5961(x));
                                let v5975: File_system::US13 = match &v5972 {
                                    Err(v5972_1_0) => v5918(v5972_1_0.clone()),
                                    Ok(v5972_0_0) => v5917(v5972_0_0.clone()),
                                };
                                let v8638: Result<std::path::PathBuf, std::io::Error> = match &v5975
                                {
                                    File_system::US13::US13_0(v5975_0_0) => Ok(v5975_0_0.clone()),
                                    File_system::US13::US13_1(v5975_1_0) => {
                                        let v5990: string = v5975_1_0.clone();
                                        let v5991: string = File_system::method19(v5954.clone());
                                        let v5992: Option<string> =
                                            File_system::method78(v5954.clone());
                                        let v6006: File_system::US1 = defaultValue(
                                            File_system::US1::US1_1,
                                            map(File_system::method4(), v5992),
                                        );
                                        if let File_system::US1::US1_0(v6006_0_0) = &v6006 {
                                            let v6010: string = match &v6006 {
                                                File_system::US1::US1_0(x) => x.clone(),
                                                _ => unreachable!(),
                                            };
                                            if v5954.clone() != string("") {
                                                let v6015: Result<
                                                    std::path::PathBuf,
                                                    std::io::Error,
                                                > = std::fs::read_link(&*v6010.clone());
                                                let v6016 = File_system::method76();
                                                let v6027: Result<std::path::PathBuf, string> =
                                                    v6015.map_err(|x| v6016(x));
                                                let v6030: File_system::US13 = match &v6027 {
                                                    Err(v6027_1_0) => v5918(v6027_1_0.clone()),
                                                    Ok(v6027_0_0) => v5917(v6027_0_0.clone()),
                                                };
                                                let v8433: Result<
                                                    std::path::PathBuf,
                                                    std::io::Error,
                                                > = match &v6030 {
                                                    File_system::US13::US13_0(v6030_0_0) => {
                                                        Ok(v6030_0_0.clone())
                                                    }
                                                    File_system::US13::US13_1(v6030_1_0) => {
                                                        let v6045: string = v6030_1_0.clone();
                                                        let v6046: string =
                                                            File_system::method19(v6010.clone());
                                                        let v6047: Option<string> =
                                                            File_system::method78(v6010.clone());
                                                        let v6061: File_system::US1 = defaultValue(
                                                            File_system::US1::US1_1,
                                                            map(File_system::method4(), v6047),
                                                        );
                                                        if let File_system::US1::US1_0(v6061_0_0) =
                                                            &v6061
                                                        {
                                                            let v6065: string = match &v6061 {
                                                                File_system::US1::US1_0(x) => {
                                                                    x.clone()
                                                                }
                                                                _ => unreachable!(),
                                                            };
                                                            if v6010.clone() != string("") {
                                                                let v6070: Result<
                                                                    std::path::PathBuf,
                                                                    std::io::Error,
                                                                > = std::fs::read_link(
                                                                    &*v6065.clone(),
                                                                );
                                                                let v6071 = File_system::method76();
                                                                let v6082: Result<
                                                                    std::path::PathBuf,
                                                                    string,
                                                                > = v6070.map_err(|x| v6071(x));
                                                                let v6085: File_system::US13 =
                                                                    match &v6082 {
                                                                        Err(v6082_1_0) => {
                                                                            v5918(v6082_1_0.clone())
                                                                        }
                                                                        Ok(v6082_0_0) => {
                                                                            v5917(v6082_0_0.clone())
                                                                        }
                                                                    };
                                                                let v8228: Result<
                                                                    std::path::PathBuf,
                                                                    std::io::Error,
                                                                > = match &v6085 {
                                                                    File_system::US13::US13_0(
                                                                        v6085_0_0,
                                                                    ) => Ok(v6085_0_0.clone()),
                                                                    File_system::US13::US13_1(
                                                                        v6085_1_0,
                                                                    ) => {
                                                                        let v6100: string =
                                                                            v6085_1_0.clone();
                                                                        let v6101: string =
                                                                            File_system::method19(
                                                                                v6065.clone(),
                                                                            );
                                                                        let v6102: Option<string> =
                                                                            File_system::method78(
                                                                                v6065.clone(),
                                                                            );
                                                                        let v6116:
                                                                                                File_system::US1 =
                                                                                            defaultValue(File_system::US1::US1_1,
                                                                                                         map(File_system::method4(),
                                                                                                             v6102));
                                                                        if let File_system::US1::US1_0(v6116_0_0)
                                                                                               =
                                                                                               &v6116
                                                                                           {
                                                                                            let v6120:
                                                                                                    string =
                                                                                                match &v6116
                                                                                                    {
                                                                                                    File_system::US1::US1_0(x)
                                                                                                    =>
                                                                                                    x.clone(),
                                                                                                    _
                                                                                                    =>
                                                                                                    unreachable!(),
                                                                                                };
                                                                                            if v6065.clone()
                                                                                                   !=
                                                                                                   string("")
                                                                                               {
                                                                                                let v6125:
                                                                                                        Result<std::path::PathBuf,
                                                                                                               std::io::Error> =
                                                                                                    std::fs::read_link(&*v6120.clone());
                                                                                                let v6126 =
                                                                                                    File_system::method76();
                                                                                                let v6137:
                                                                                                        Result<std::path::PathBuf,
                                                                                                               string> =
                                                                                                    v6125.map_err(|x| v6126(x));
                                                                                                let v6140:
                                                                                                        File_system::US13 =
                                                                                                    match &v6137
                                                                                                        {
                                                                                                        Err(v6137_1_0)
                                                                                                        =>
                                                                                                        v5918(v6137_1_0.clone()),
                                                                                                        Ok(v6137_0_0)
                                                                                                        =>
                                                                                                        v5917(v6137_0_0.clone()),
                                                                                                    };
                                                                                                let v8023:
                                                                                                        Result<std::path::PathBuf,
                                                                                                               std::io::Error> =
                                                                                                    match &v6140
                                                                                                        {
                                                                                                        File_system::US13::US13_0(v6140_0_0)
                                                                                                        =>
                                                                                                        Ok(v6140_0_0.clone()),
                                                                                                        File_system::US13::US13_1(v6140_1_0)
                                                                                                        =>
                                                                                                        {
                                                                                                            let v6155:
                                                                                                                    string =
                                                                                                                v6140_1_0.clone();
                                                                                                            let v6156:
                                                                                                                    string =
                                                                                                                File_system::method19(v6120.clone());
                                                                                                            let v6157:
                                                                                                                    Option<string> =
                                                                                                                File_system::method78(v6120.clone());
                                                                                                            let v6171:
                                                                                                                    File_system::US1 =
                                                                                                                defaultValue(File_system::US1::US1_1,
                                                                                                                             map(File_system::method4(),
                                                                                                                                 v6157));
                                                                                                            if let File_system::US1::US1_0(v6171_0_0)
                                                                                                                   =
                                                                                                                   &v6171
                                                                                                               {
                                                                                                                let v6175:
                                                                                                                        string =
                                                                                                                    match &v6171
                                                                                                                        {
                                                                                                                        File_system::US1::US1_0(x)
                                                                                                                        =>
                                                                                                                        x.clone(),
                                                                                                                        _
                                                                                                                        =>
                                                                                                                        unreachable!(),
                                                                                                                    };
                                                                                                                if v6120.clone()
                                                                                                                       !=
                                                                                                                       string("")
                                                                                                                   {
                                                                                                                    let v6180:
                                                                                                                            Result<std::path::PathBuf,
                                                                                                                                   std::io::Error> =
                                                                                                                        std::fs::read_link(&*v6175.clone());
                                                                                                                    let v6181 =
                                                                                                                        File_system::method76();
                                                                                                                    let v6192:
                                                                                                                            Result<std::path::PathBuf,
                                                                                                                                   string> =
                                                                                                                        v6180.map_err(|x| v6181(x));
                                                                                                                    let v6195:
                                                                                                                            File_system::US13 =
                                                                                                                        match &v6192
                                                                                                                            {
                                                                                                                            Err(v6192_1_0)
                                                                                                                            =>
                                                                                                                            v5918(v6192_1_0.clone()),
                                                                                                                            Ok(v6192_0_0)
                                                                                                                            =>
                                                                                                                            v5917(v6192_0_0.clone()),
                                                                                                                        };
                                                                                                                    let v7818:
                                                                                                                            Result<std::path::PathBuf,
                                                                                                                                   std::io::Error> =
                                                                                                                        match &v6195
                                                                                                                            {
                                                                                                                            File_system::US13::US13_0(v6195_0_0)
                                                                                                                            =>
                                                                                                                            Ok(v6195_0_0.clone()),
                                                                                                                            File_system::US13::US13_1(v6195_1_0)
                                                                                                                            =>
                                                                                                                            {
                                                                                                                                let v6210:
                                                                                                                                        string =
                                                                                                                                    v6195_1_0.clone();
                                                                                                                                let v6211:
                                                                                                                                        string =
                                                                                                                                    File_system::method19(v6175.clone());
                                                                                                                                let v6212:
                                                                                                                                        Option<string> =
                                                                                                                                    File_system::method78(v6175.clone());
                                                                                                                                let v6226:
                                                                                                                                        File_system::US1 =
                                                                                                                                    defaultValue(File_system::US1::US1_1,
                                                                                                                                                 map(File_system::method4(),
                                                                                                                                                     v6212));
                                                                                                                                if let File_system::US1::US1_0(v6226_0_0)
                                                                                                                                       =
                                                                                                                                       &v6226
                                                                                                                                   {
                                                                                                                                    let v6230:
                                                                                                                                            string =
                                                                                                                                        match &v6226
                                                                                                                                            {
                                                                                                                                            File_system::US1::US1_0(x)
                                                                                                                                            =>
                                                                                                                                            x.clone(),
                                                                                                                                            _
                                                                                                                                            =>
                                                                                                                                            unreachable!(),
                                                                                                                                        };
                                                                                                                                    if v6175.clone()
                                                                                                                                           !=
                                                                                                                                           string("")
                                                                                                                                       {
                                                                                                                                        let v6235:
                                                                                                                                                Result<std::path::PathBuf,
                                                                                                                                                       std::io::Error> =
                                                                                                                                            std::fs::read_link(&*v6230.clone());
                                                                                                                                        let v6236 =
                                                                                                                                            File_system::method76();
                                                                                                                                        let v6247:
                                                                                                                                                Result<std::path::PathBuf,
                                                                                                                                                       string> =
                                                                                                                                            v6235.map_err(|x| v6236(x));
                                                                                                                                        let v6250:
                                                                                                                                                File_system::US13 =
                                                                                                                                            match &v6247
                                                                                                                                                {
                                                                                                                                                Err(v6247_1_0)
                                                                                                                                                =>
                                                                                                                                                v5918(v6247_1_0.clone()),
                                                                                                                                                Ok(v6247_0_0)
                                                                                                                                                =>
                                                                                                                                                v5917(v6247_0_0.clone()),
                                                                                                                                            };
                                                                                                                                        let v7613:
                                                                                                                                                Result<std::path::PathBuf,
                                                                                                                                                       std::io::Error> =
                                                                                                                                            match &v6250
                                                                                                                                                {
                                                                                                                                                File_system::US13::US13_0(v6250_0_0)
                                                                                                                                                =>
                                                                                                                                                Ok(v6250_0_0.clone()),
                                                                                                                                                File_system::US13::US13_1(v6250_1_0)
                                                                                                                                                =>
                                                                                                                                                {
                                                                                                                                                    let v6265:
                                                                                                                                                            string =
                                                                                                                                                        v6250_1_0.clone();
                                                                                                                                                    let v6266:
                                                                                                                                                            string =
                                                                                                                                                        File_system::method19(v6230.clone());
                                                                                                                                                    let v6267:
                                                                                                                                                            Option<string> =
                                                                                                                                                        File_system::method78(v6230.clone());
                                                                                                                                                    let v6281:
                                                                                                                                                            File_system::US1 =
                                                                                                                                                        defaultValue(File_system::US1::US1_1,
                                                                                                                                                                     map(File_system::method4(),
                                                                                                                                                                         v6267));
                                                                                                                                                    if let File_system::US1::US1_0(v6281_0_0)
                                                                                                                                                           =
                                                                                                                                                           &v6281
                                                                                                                                                       {
                                                                                                                                                        let v6285:
                                                                                                                                                                string =
                                                                                                                                                            match &v6281
                                                                                                                                                                {
                                                                                                                                                                File_system::US1::US1_0(x)
                                                                                                                                                                =>
                                                                                                                                                                x.clone(),
                                                                                                                                                                _
                                                                                                                                                                =>
                                                                                                                                                                unreachable!(),
                                                                                                                                                            };
                                                                                                                                                        if v6230.clone()
                                                                                                                                                               !=
                                                                                                                                                               string("")
                                                                                                                                                           {
                                                                                                                                                            let v6290:
                                                                                                                                                                    Result<std::path::PathBuf,
                                                                                                                                                                           std::io::Error> =
                                                                                                                                                                std::fs::read_link(&*v6285.clone());
                                                                                                                                                            let v6291 =
                                                                                                                                                                File_system::method76();
                                                                                                                                                            let v6302:
                                                                                                                                                                    Result<std::path::PathBuf,
                                                                                                                                                                           string> =
                                                                                                                                                                v6290.map_err(|x| v6291(x));
                                                                                                                                                            let v6305:
                                                                                                                                                                    File_system::US13 =
                                                                                                                                                                match &v6302
                                                                                                                                                                    {
                                                                                                                                                                    Err(v6302_1_0)
                                                                                                                                                                    =>
                                                                                                                                                                    v5918(v6302_1_0.clone()),
                                                                                                                                                                    Ok(v6302_0_0)
                                                                                                                                                                    =>
                                                                                                                                                                    v5917(v6302_0_0.clone()),
                                                                                                                                                                };
                                                                                                                                                            let v7408:
                                                                                                                                                                    Result<std::path::PathBuf,
                                                                                                                                                                           std::io::Error> =
                                                                                                                                                                match &v6305
                                                                                                                                                                    {
                                                                                                                                                                    File_system::US13::US13_0(v6305_0_0)
                                                                                                                                                                    =>
                                                                                                                                                                    Ok(v6305_0_0.clone()),
                                                                                                                                                                    File_system::US13::US13_1(v6305_1_0)
                                                                                                                                                                    =>
                                                                                                                                                                    {
                                                                                                                                                                        let v6320:
                                                                                                                                                                                string =
                                                                                                                                                                            v6305_1_0.clone();
                                                                                                                                                                        let v6321:
                                                                                                                                                                                string =
                                                                                                                                                                            File_system::method19(v6285.clone());
                                                                                                                                                                        let v6322:
                                                                                                                                                                                Option<string> =
                                                                                                                                                                            File_system::method78(v6285.clone());
                                                                                                                                                                        let v6336:
                                                                                                                                                                                File_system::US1 =
                                                                                                                                                                            defaultValue(File_system::US1::US1_1,
                                                                                                                                                                                         map(File_system::method4(),
                                                                                                                                                                                             v6322));
                                                                                                                                                                        if let File_system::US1::US1_0(v6336_0_0)
                                                                                                                                                                               =
                                                                                                                                                                               &v6336
                                                                                                                                                                           {
                                                                                                                                                                            let v6340:
                                                                                                                                                                                    string =
                                                                                                                                                                                match &v6336
                                                                                                                                                                                    {
                                                                                                                                                                                    File_system::US1::US1_0(x)
                                                                                                                                                                                    =>
                                                                                                                                                                                    x.clone(),
                                                                                                                                                                                    _
                                                                                                                                                                                    =>
                                                                                                                                                                                    unreachable!(),
                                                                                                                                                                                };
                                                                                                                                                                            if v6285.clone()
                                                                                                                                                                                   !=
                                                                                                                                                                                   string("")
                                                                                                                                                                               {
                                                                                                                                                                                let v6345:
                                                                                                                                                                                        Result<std::path::PathBuf,
                                                                                                                                                                                               std::io::Error> =
                                                                                                                                                                                    std::fs::read_link(&*v6340.clone());
                                                                                                                                                                                let v6346 =
                                                                                                                                                                                    File_system::method76();
                                                                                                                                                                                let v6357:
                                                                                                                                                                                        Result<std::path::PathBuf,
                                                                                                                                                                                               string> =
                                                                                                                                                                                    v6345.map_err(|x| v6346(x));
                                                                                                                                                                                let v6360:
                                                                                                                                                                                        File_system::US13 =
                                                                                                                                                                                    match &v6357
                                                                                                                                                                                        {
                                                                                                                                                                                        Err(v6357_1_0)
                                                                                                                                                                                        =>
                                                                                                                                                                                        v5918(v6357_1_0.clone()),
                                                                                                                                                                                        Ok(v6357_0_0)
                                                                                                                                                                                        =>
                                                                                                                                                                                        v5917(v6357_0_0.clone()),
                                                                                                                                                                                    };
                                                                                                                                                                                let v7203:
                                                                                                                                                                                        Result<std::path::PathBuf,
                                                                                                                                                                                               std::io::Error> =
                                                                                                                                                                                    match &v6360
                                                                                                                                                                                        {
                                                                                                                                                                                        File_system::US13::US13_0(v6360_0_0)
                                                                                                                                                                                        =>
                                                                                                                                                                                        Ok(v6360_0_0.clone()),
                                                                                                                                                                                        File_system::US13::US13_1(v6360_1_0)
                                                                                                                                                                                        =>
                                                                                                                                                                                        {
                                                                                                                                                                                            let v6375:
                                                                                                                                                                                                    string =
                                                                                                                                                                                                v6360_1_0.clone();
                                                                                                                                                                                            let v6376:
                                                                                                                                                                                                    string =
                                                                                                                                                                                                File_system::method19(v6340.clone());
                                                                                                                                                                                            let v6377:
                                                                                                                                                                                                    Option<string> =
                                                                                                                                                                                                File_system::method78(v6340.clone());
                                                                                                                                                                                            let v6391:
                                                                                                                                                                                                    File_system::US1 =
                                                                                                                                                                                                defaultValue(File_system::US1::US1_1,
                                                                                                                                                                                                             map(File_system::method4(),
                                                                                                                                                                                                                 v6377));
                                                                                                                                                                                            if let File_system::US1::US1_0(v6391_0_0)
                                                                                                                                                                                                   =
                                                                                                                                                                                                   &v6391
                                                                                                                                                                                               {
                                                                                                                                                                                                let v6395:
                                                                                                                                                                                                        string =
                                                                                                                                                                                                    match &v6391
                                                                                                                                                                                                        {
                                                                                                                                                                                                        File_system::US1::US1_0(x)
                                                                                                                                                                                                        =>
                                                                                                                                                                                                        x.clone(),
                                                                                                                                                                                                        _
                                                                                                                                                                                                        =>
                                                                                                                                                                                                        unreachable!(),
                                                                                                                                                                                                    };
                                                                                                                                                                                                if v6340.clone()
                                                                                                                                                                                                       !=
                                                                                                                                                                                                       string("")
                                                                                                                                                                                                   {
                                                                                                                                                                                                    let v6400:
                                                                                                                                                                                                            Result<std::path::PathBuf,
                                                                                                                                                                                                                   std::io::Error> =
                                                                                                                                                                                                        std::fs::read_link(&*v6395.clone());
                                                                                                                                                                                                    let v6401 =
                                                                                                                                                                                                        File_system::method76();
                                                                                                                                                                                                    let v6412:
                                                                                                                                                                                                            Result<std::path::PathBuf,
                                                                                                                                                                                                                   string> =
                                                                                                                                                                                                        v6400.map_err(|x| v6401(x));
                                                                                                                                                                                                    let v6415:
                                                                                                                                                                                                            File_system::US13 =
                                                                                                                                                                                                        match &v6412
                                                                                                                                                                                                            {
                                                                                                                                                                                                            Err(v6412_1_0)
                                                                                                                                                                                                            =>
                                                                                                                                                                                                            v5918(v6412_1_0.clone()),
                                                                                                                                                                                                            Ok(v6412_0_0)
                                                                                                                                                                                                            =>
                                                                                                                                                                                                            v5917(v6412_0_0.clone()),
                                                                                                                                                                                                        };
                                                                                                                                                                                                    let v6998:
                                                                                                                                                                                                            Result<std::path::PathBuf,
                                                                                                                                                                                                                   std::io::Error> =
                                                                                                                                                                                                        match &v6415
                                                                                                                                                                                                            {
                                                                                                                                                                                                            File_system::US13::US13_0(v6415_0_0)
                                                                                                                                                                                                            =>
                                                                                                                                                                                                            Ok(v6415_0_0.clone()),
                                                                                                                                                                                                            File_system::US13::US13_1(v6415_1_0)
                                                                                                                                                                                                            =>
                                                                                                                                                                                                            {
                                                                                                                                                                                                                let v6430:
                                                                                                                                                                                                                        string =
                                                                                                                                                                                                                    v6415_1_0.clone();
                                                                                                                                                                                                                let v6431:
                                                                                                                                                                                                                        string =
                                                                                                                                                                                                                    File_system::method19(v6395.clone());
                                                                                                                                                                                                                let v6432:
                                                                                                                                                                                                                        Option<string> =
                                                                                                                                                                                                                    File_system::method78(v6395.clone());
                                                                                                                                                                                                                let v6446:
                                                                                                                                                                                                                        File_system::US1 =
                                                                                                                                                                                                                    defaultValue(File_system::US1::US1_1,
                                                                                                                                                                                                                                 map(File_system::method4(),
                                                                                                                                                                                                                                     v6432));
                                                                                                                                                                                                                if let File_system::US1::US1_0(v6446_0_0)
                                                                                                                                                                                                                       =
                                                                                                                                                                                                                       &v6446
                                                                                                                                                                                                                   {
                                                                                                                                                                                                                    let v6450:
                                                                                                                                                                                                                            string =
                                                                                                                                                                                                                        match &v6446
                                                                                                                                                                                                                            {
                                                                                                                                                                                                                            File_system::US1::US1_0(x)
                                                                                                                                                                                                                            =>
                                                                                                                                                                                                                            x.clone(),
                                                                                                                                                                                                                            _
                                                                                                                                                                                                                            =>
                                                                                                                                                                                                                            unreachable!(),
                                                                                                                                                                                                                        };
                                                                                                                                                                                                                    if v6395.clone()
                                                                                                                                                                                                                           !=
                                                                                                                                                                                                                           string("")
                                                                                                                                                                                                                       {
                                                                                                                                                                                                                        let v6455:
                                                                                                                                                                                                                                Result<std::path::PathBuf,
                                                                                                                                                                                                                                       std::io::Error> =
                                                                                                                                                                                                                            std::fs::read_link(&*v6450.clone());
                                                                                                                                                                                                                        let v6456 =
                                                                                                                                                                                                                            File_system::method76();
                                                                                                                                                                                                                        let v6467:
                                                                                                                                                                                                                                Result<std::path::PathBuf,
                                                                                                                                                                                                                                       string> =
                                                                                                                                                                                                                            v6455.map_err(|x| v6456(x));
                                                                                                                                                                                                                        let v6470:
                                                                                                                                                                                                                                File_system::US13 =
                                                                                                                                                                                                                            match &v6467
                                                                                                                                                                                                                                {
                                                                                                                                                                                                                                Err(v6467_1_0)
                                                                                                                                                                                                                                =>
                                                                                                                                                                                                                                v5918(v6467_1_0.clone()),
                                                                                                                                                                                                                                Ok(v6467_0_0)
                                                                                                                                                                                                                                =>
                                                                                                                                                                                                                                v5917(v6467_0_0.clone()),
                                                                                                                                                                                                                            };
                                                                                                                                                                                                                        let v6793:
                                                                                                                                                                                                                                Result<std::path::PathBuf,
                                                                                                                                                                                                                                       std::io::Error> =
                                                                                                                                                                                                                            match &v6470
                                                                                                                                                                                                                                {
                                                                                                                                                                                                                                File_system::US13::US13_0(v6470_0_0)
                                                                                                                                                                                                                                =>
                                                                                                                                                                                                                                Ok(v6470_0_0.clone()),
                                                                                                                                                                                                                                File_system::US13::US13_1(v6470_1_0)
                                                                                                                                                                                                                                =>
                                                                                                                                                                                                                                {
                                                                                                                                                                                                                                    let v6485:
                                                                                                                                                                                                                                            string =
                                                                                                                                                                                                                                        v6470_1_0.clone();
                                                                                                                                                                                                                                    let v6486:
                                                                                                                                                                                                                                            string =
                                                                                                                                                                                                                                        File_system::method19(v6450.clone());
                                                                                                                                                                                                                                    let v6487:
                                                                                                                                                                                                                                            Option<string> =
                                                                                                                                                                                                                                        File_system::method78(v6450.clone());
                                                                                                                                                                                                                                    let v6501:
                                                                                                                                                                                                                                            File_system::US1 =
                                                                                                                                                                                                                                        defaultValue(File_system::US1::US1_1,
                                                                                                                                                                                                                                                     map(File_system::method4(),
                                                                                                                                                                                                                                                         v6487));
                                                                                                                                                                                                                                    if let File_system::US1::US1_0(v6501_0_0)
                                                                                                                                                                                                                                           =
                                                                                                                                                                                                                                           &v6501
                                                                                                                                                                                                                                       {
                                                                                                                                                                                                                                        let v6505:
                                                                                                                                                                                                                                                string =
                                                                                                                                                                                                                                            match &v6501
                                                                                                                                                                                                                                                {
                                                                                                                                                                                                                                                File_system::US1::US1_0(x)
                                                                                                                                                                                                                                                =>
                                                                                                                                                                                                                                                x.clone(),
                                                                                                                                                                                                                                                _
                                                                                                                                                                                                                                                =>
                                                                                                                                                                                                                                                unreachable!(),
                                                                                                                                                                                                                                            };
                                                                                                                                                                                                                                        if v6450.clone()
                                                                                                                                                                                                                                               !=
                                                                                                                                                                                                                                               string("")
                                                                                                                                                                                                                                           {
                                                                                                                                                                                                                                            let v6510:
                                                                                                                                                                                                                                                    Result<std::path::PathBuf,
                                                                                                                                                                                                                                                           std::io::Error> =
                                                                                                                                                                                                                                                std::fs::read_link(&*v6505.clone());
                                                                                                                                                                                                                                            let v6511 =
                                                                                                                                                                                                                                                File_system::method76();
                                                                                                                                                                                                                                            let v6522:
                                                                                                                                                                                                                                                    Result<std::path::PathBuf,
                                                                                                                                                                                                                                                           string> =
                                                                                                                                                                                                                                                v6510.map_err(|x| v6511(x));
                                                                                                                                                                                                                                            let v6525:
                                                                                                                                                                                                                                                    File_system::US13 =
                                                                                                                                                                                                                                                match &v6522
                                                                                                                                                                                                                                                    {
                                                                                                                                                                                                                                                    Err(v6522_1_0)
                                                                                                                                                                                                                                                    =>
                                                                                                                                                                                                                                                    v5918(v6522_1_0.clone()),
                                                                                                                                                                                                                                                    Ok(v6522_0_0)
                                                                                                                                                                                                                                                    =>
                                                                                                                                                                                                                                                    v5917(v6522_0_0.clone()),
                                                                                                                                                                                                                                                };
                                                                                                                                                                                                                                            let v6588:
                                                                                                                                                                                                                                                    Result<std::path::PathBuf,
                                                                                                                                                                                                                                                           std::io::Error> =
                                                                                                                                                                                                                                                match &v6525
                                                                                                                                                                                                                                                    {
                                                                                                                                                                                                                                                    File_system::US13::US13_0(v6525_0_0)
                                                                                                                                                                                                                                                    =>
                                                                                                                                                                                                                                                    Ok(v6525_0_0.clone()),
                                                                                                                                                                                                                                                    _
                                                                                                                                                                                                                                                    =>
                                                                                                                                                                                                                                                    {
                                                                                                                                                                                                                                                        let v6541:
                                                                                                                                                                                                                                                                string =
                                                                                                                                                                                                                                                            File_system::method19(v6505.clone());
                                                                                                                                                                                                                                                        let v6542:
                                                                                                                                                                                                                                                                Option<string> =
                                                                                                                                                                                                                                                            File_system::method78(v6505.clone());
                                                                                                                                                                                                                                                        let v6556:
                                                                                                                                                                                                                                                                File_system::US1 =
                                                                                                                                                                                                                                                            defaultValue(File_system::US1::US1_1,
                                                                                                                                                                                                                                                                         map(File_system::method4(),
                                                                                                                                                                                                                                                                             v6542));
                                                                                                                                                                                                                                                        let v6560:
                                                                                                                                                                                                                                                                string =
                                                                                                                                                                                                                                                            sprintf!("file_system.read_link / path: {} / n: {} / path\': {} / name: {}",
                                                                                                                                                                                                                                                                     v0_1.clone(),
                                                                                                                                                                                                                                                                     11_u8,
                                                                                                                                                                                                                                                                     v6505.clone(),
                                                                                                                                                                                                                                                                     v6541);
                                                                                                                                                                                                                                                        let v6567:
                                                                                                                                                                                                                                                                std::io::Error =
                                                                                                                                                                                                                                                            std::io::Error::new(std::io::ErrorKind::Other, &*v6560);
                                                                                                                                                                                                                                                        Err(v6567)
                                                                                                                                                                                                                                                    }
                                                                                                                                                                                                                                                };
                                                                                                                                                                                                                                            let v6589 =
                                                                                                                                                                                                                                                File_system::method76();
                                                                                                                                                                                                                                            let v6600:
                                                                                                                                                                                                                                                    Result<std::path::PathBuf,
                                                                                                                                                                                                                                                           string> =
                                                                                                                                                                                                                                                v6588.map_err(|x| v6589(x));
                                                                                                                                                                                                                                            let v6603:
                                                                                                                                                                                                                                                    File_system::US13 =
                                                                                                                                                                                                                                                match &v6600
                                                                                                                                                                                                                                                    {
                                                                                                                                                                                                                                                    Err(v6600_1_0)
                                                                                                                                                                                                                                                    =>
                                                                                                                                                                                                                                                    v5918(v6600_1_0.clone()),
                                                                                                                                                                                                                                                    Ok(v6600_0_0)
                                                                                                                                                                                                                                                    =>
                                                                                                                                                                                                                                                    v5917(v6600_0_0.clone()),
                                                                                                                                                                                                                                                };
                                                                                                                                                                                                                                            match &v6603
                                                                                                                                                                                                                                                {
                                                                                                                                                                                                                                                File_system::US13::US13_0(v6603_0_0)
                                                                                                                                                                                                                                                =>
                                                                                                                                                                                                                                                {
                                                                                                                                                                                                                                                    let v6629:
                                                                                                                                                                                                                                                            string =
                                                                                                                                                                                                                                                        File_system::method56(toString(v6603_0_0.clone().display()),
                                                                                                                                                                                                                                                                              v6486.clone());
                                                                                                                                                                                                                                                    let v6636:
                                                                                                                                                                                                                                                            &str =
                                                                                                                                                                                                                                                        &*v6629;
                                                                                                                                                                                                                                                    let v6657:
                                                                                                                                                                                                                                                            std::string::String =
                                                                                                                                                                                                                                                        String::from(v6636);
                                                                                                                                                                                                                                                    let v6678:
                                                                                                                                                                                                                                                            std::path::PathBuf =
                                                                                                                                                                                                                                                        std::path::PathBuf::from(v6657);
                                                                                                                                                                                                                                                    Ok(v6678)
                                                                                                                                                                                                                                                }
                                                                                                                                                                                                                                                File_system::US13::US13_1(v6603_1_0)
                                                                                                                                                                                                                                                =>
                                                                                                                                                                                                                                                {
                                                                                                                                                                                                                                                    let v6707:
                                                                                                                                                                                                                                                            string =
                                                                                                                                                                                                                                                        sprintf!("file_system.read_link / error\': {} / error: {} / name: {}",
                                                                                                                                                                                                                                                                 v6603_1_0.clone(),
                                                                                                                                                                                                                                                                 v6485.clone(),
                                                                                                                                                                                                                                                                 v6486.clone());
                                                                                                                                                                                                                                                    let v6714:
                                                                                                                                                                                                                                                            std::io::Error =
                                                                                                                                                                                                                                                        std::io::Error::new(std::io::ErrorKind::Other, &*v6707);
                                                                                                                                                                                                                                                    Err(v6714)
                                                                                                                                                                                                                                                }
                                                                                                                                                                                                                                            }
                                                                                                                                                                                                                                        } else {
                                                                                                                                                                                                                                            let v6736:
                                                                                                                                                                                                                                                    string =
                                                                                                                                                                                                                                                sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                                                                                                                                                                                                                         v0_1.clone(),
                                                                                                                                                                                                                                                         v6485.clone(),
                                                                                                                                                                                                                                                         v6450.clone(),
                                                                                                                                                                                                                                                         v6486.clone());
                                                                                                                                                                                                                                            let v6743:
                                                                                                                                                                                                                                                    std::io::Error =
                                                                                                                                                                                                                                                std::io::Error::new(std::io::ErrorKind::Other, &*v6736);
                                                                                                                                                                                                                                            Err(v6743)
                                                                                                                                                                                                                                        }
                                                                                                                                                                                                                                    } else {
                                                                                                                                                                                                                                        let v6764:
                                                                                                                                                                                                                                                string =
                                                                                                                                                                                                                                            sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                                                                                                                                                                                                                     v0_1.clone(),
                                                                                                                                                                                                                                                     v6485,
                                                                                                                                                                                                                                                     v6450.clone(),
                                                                                                                                                                                                                                                     v6486.clone());
                                                                                                                                                                                                                                        let v6771:
                                                                                                                                                                                                                                                std::io::Error =
                                                                                                                                                                                                                                            std::io::Error::new(std::io::ErrorKind::Other, &*v6764);
                                                                                                                                                                                                                                        Err(v6771)
                                                                                                                                                                                                                                    }
                                                                                                                                                                                                                                }
                                                                                                                                                                                                                            };
                                                                                                                                                                                                                        let v6794 =
                                                                                                                                                                                                                            File_system::method76();
                                                                                                                                                                                                                        let v6805:
                                                                                                                                                                                                                                Result<std::path::PathBuf,
                                                                                                                                                                                                                                       string> =
                                                                                                                                                                                                                            v6793.map_err(|x| v6794(x));
                                                                                                                                                                                                                        let v6808:
                                                                                                                                                                                                                                File_system::US13 =
                                                                                                                                                                                                                            match &v6805
                                                                                                                                                                                                                                {
                                                                                                                                                                                                                                Err(v6805_1_0)
                                                                                                                                                                                                                                =>
                                                                                                                                                                                                                                v5918(v6805_1_0.clone()),
                                                                                                                                                                                                                                Ok(v6805_0_0)
                                                                                                                                                                                                                                =>
                                                                                                                                                                                                                                v5917(v6805_0_0.clone()),
                                                                                                                                                                                                                            };
                                                                                                                                                                                                                        match &v6808
                                                                                                                                                                                                                            {
                                                                                                                                                                                                                            File_system::US13::US13_0(v6808_0_0)
                                                                                                                                                                                                                            =>
                                                                                                                                                                                                                            {
                                                                                                                                                                                                                                let v6834:
                                                                                                                                                                                                                                        string =
                                                                                                                                                                                                                                    File_system::method56(toString(v6808_0_0.clone().display()),
                                                                                                                                                                                                                                                          v6431.clone());
                                                                                                                                                                                                                                let v6841:
                                                                                                                                                                                                                                        &str =
                                                                                                                                                                                                                                    &*v6834;
                                                                                                                                                                                                                                let v6862:
                                                                                                                                                                                                                                        std::string::String =
                                                                                                                                                                                                                                    String::from(v6841);
                                                                                                                                                                                                                                let v6883:
                                                                                                                                                                                                                                        std::path::PathBuf =
                                                                                                                                                                                                                                    std::path::PathBuf::from(v6862);
                                                                                                                                                                                                                                Ok(v6883)
                                                                                                                                                                                                                            }
                                                                                                                                                                                                                            File_system::US13::US13_1(v6808_1_0)
                                                                                                                                                                                                                            =>
                                                                                                                                                                                                                            {
                                                                                                                                                                                                                                let v6912:
                                                                                                                                                                                                                                        string =
                                                                                                                                                                                                                                    sprintf!("file_system.read_link / error\': {} / error: {} / name: {}",
                                                                                                                                                                                                                                             v6808_1_0.clone(),
                                                                                                                                                                                                                                             v6430.clone(),
                                                                                                                                                                                                                                             v6431.clone());
                                                                                                                                                                                                                                let v6919:
                                                                                                                                                                                                                                        std::io::Error =
                                                                                                                                                                                                                                    std::io::Error::new(std::io::ErrorKind::Other, &*v6912);
                                                                                                                                                                                                                                Err(v6919)
                                                                                                                                                                                                                            }
                                                                                                                                                                                                                        }
                                                                                                                                                                                                                    } else {
                                                                                                                                                                                                                        let v6941:
                                                                                                                                                                                                                                string =
                                                                                                                                                                                                                            sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                                                                                                                                                                                                     v0_1.clone(),
                                                                                                                                                                                                                                     v6430.clone(),
                                                                                                                                                                                                                                     v6395.clone(),
                                                                                                                                                                                                                                     v6431.clone());
                                                                                                                                                                                                                        let v6948:
                                                                                                                                                                                                                                std::io::Error =
                                                                                                                                                                                                                            std::io::Error::new(std::io::ErrorKind::Other, &*v6941);
                                                                                                                                                                                                                        Err(v6948)
                                                                                                                                                                                                                    }
                                                                                                                                                                                                                } else {
                                                                                                                                                                                                                    let v6969:
                                                                                                                                                                                                                            string =
                                                                                                                                                                                                                        sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                                                                                                                                                                                                 v0_1.clone(),
                                                                                                                                                                                                                                 v6430,
                                                                                                                                                                                                                                 v6395.clone(),
                                                                                                                                                                                                                                 v6431.clone());
                                                                                                                                                                                                                    let v6976:
                                                                                                                                                                                                                            std::io::Error =
                                                                                                                                                                                                                        std::io::Error::new(std::io::ErrorKind::Other, &*v6969);
                                                                                                                                                                                                                    Err(v6976)
                                                                                                                                                                                                                }
                                                                                                                                                                                                            }
                                                                                                                                                                                                        };
                                                                                                                                                                                                    let v6999 =
                                                                                                                                                                                                        File_system::method76();
                                                                                                                                                                                                    let v7010:
                                                                                                                                                                                                            Result<std::path::PathBuf,
                                                                                                                                                                                                                   string> =
                                                                                                                                                                                                        v6998.map_err(|x| v6999(x));
                                                                                                                                                                                                    let v7013:
                                                                                                                                                                                                            File_system::US13 =
                                                                                                                                                                                                        match &v7010
                                                                                                                                                                                                            {
                                                                                                                                                                                                            Err(v7010_1_0)
                                                                                                                                                                                                            =>
                                                                                                                                                                                                            v5918(v7010_1_0.clone()),
                                                                                                                                                                                                            Ok(v7010_0_0)
                                                                                                                                                                                                            =>
                                                                                                                                                                                                            v5917(v7010_0_0.clone()),
                                                                                                                                                                                                        };
                                                                                                                                                                                                    match &v7013
                                                                                                                                                                                                        {
                                                                                                                                                                                                        File_system::US13::US13_0(v7013_0_0)
                                                                                                                                                                                                        =>
                                                                                                                                                                                                        {
                                                                                                                                                                                                            let v7039:
                                                                                                                                                                                                                    string =
                                                                                                                                                                                                                File_system::method56(toString(v7013_0_0.clone().display()),
                                                                                                                                                                                                                                      v6376.clone());
                                                                                                                                                                                                            let v7046:
                                                                                                                                                                                                                    &str =
                                                                                                                                                                                                                &*v7039;
                                                                                                                                                                                                            let v7067:
                                                                                                                                                                                                                    std::string::String =
                                                                                                                                                                                                                String::from(v7046);
                                                                                                                                                                                                            let v7088:
                                                                                                                                                                                                                    std::path::PathBuf =
                                                                                                                                                                                                                std::path::PathBuf::from(v7067);
                                                                                                                                                                                                            Ok(v7088)
                                                                                                                                                                                                        }
                                                                                                                                                                                                        File_system::US13::US13_1(v7013_1_0)
                                                                                                                                                                                                        =>
                                                                                                                                                                                                        {
                                                                                                                                                                                                            let v7117:
                                                                                                                                                                                                                    string =
                                                                                                                                                                                                                sprintf!("file_system.read_link / error\': {} / error: {} / name: {}",
                                                                                                                                                                                                                         v7013_1_0.clone(),
                                                                                                                                                                                                                         v6375.clone(),
                                                                                                                                                                                                                         v6376.clone());
                                                                                                                                                                                                            let v7124:
                                                                                                                                                                                                                    std::io::Error =
                                                                                                                                                                                                                std::io::Error::new(std::io::ErrorKind::Other, &*v7117);
                                                                                                                                                                                                            Err(v7124)
                                                                                                                                                                                                        }
                                                                                                                                                                                                    }
                                                                                                                                                                                                } else {
                                                                                                                                                                                                    let v7146:
                                                                                                                                                                                                            string =
                                                                                                                                                                                                        sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                                                                                                                                                                                 v0_1.clone(),
                                                                                                                                                                                                                 v6375.clone(),
                                                                                                                                                                                                                 v6340.clone(),
                                                                                                                                                                                                                 v6376.clone());
                                                                                                                                                                                                    let v7153:
                                                                                                                                                                                                            std::io::Error =
                                                                                                                                                                                                        std::io::Error::new(std::io::ErrorKind::Other, &*v7146);
                                                                                                                                                                                                    Err(v7153)
                                                                                                                                                                                                }
                                                                                                                                                                                            } else {
                                                                                                                                                                                                let v7174:
                                                                                                                                                                                                        string =
                                                                                                                                                                                                    sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                                                                                                                                                                             v0_1.clone(),
                                                                                                                                                                                                             v6375,
                                                                                                                                                                                                             v6340.clone(),
                                                                                                                                                                                                             v6376.clone());
                                                                                                                                                                                                let v7181:
                                                                                                                                                                                                        std::io::Error =
                                                                                                                                                                                                    std::io::Error::new(std::io::ErrorKind::Other, &*v7174);
                                                                                                                                                                                                Err(v7181)
                                                                                                                                                                                            }
                                                                                                                                                                                        }
                                                                                                                                                                                    };
                                                                                                                                                                                let v7204 =
                                                                                                                                                                                    File_system::method76();
                                                                                                                                                                                let v7215:
                                                                                                                                                                                        Result<std::path::PathBuf,
                                                                                                                                                                                               string> =
                                                                                                                                                                                    v7203.map_err(|x| v7204(x));
                                                                                                                                                                                let v7218:
                                                                                                                                                                                        File_system::US13 =
                                                                                                                                                                                    match &v7215
                                                                                                                                                                                        {
                                                                                                                                                                                        Err(v7215_1_0)
                                                                                                                                                                                        =>
                                                                                                                                                                                        v5918(v7215_1_0.clone()),
                                                                                                                                                                                        Ok(v7215_0_0)
                                                                                                                                                                                        =>
                                                                                                                                                                                        v5917(v7215_0_0.clone()),
                                                                                                                                                                                    };
                                                                                                                                                                                match &v7218
                                                                                                                                                                                    {
                                                                                                                                                                                    File_system::US13::US13_0(v7218_0_0)
                                                                                                                                                                                    =>
                                                                                                                                                                                    {
                                                                                                                                                                                        let v7244:
                                                                                                                                                                                                string =
                                                                                                                                                                                            File_system::method56(toString(v7218_0_0.clone().display()),
                                                                                                                                                                                                                  v6321.clone());
                                                                                                                                                                                        let v7251:
                                                                                                                                                                                                &str =
                                                                                                                                                                                            &*v7244;
                                                                                                                                                                                        let v7272:
                                                                                                                                                                                                std::string::String =
                                                                                                                                                                                            String::from(v7251);
                                                                                                                                                                                        let v7293:
                                                                                                                                                                                                std::path::PathBuf =
                                                                                                                                                                                            std::path::PathBuf::from(v7272);
                                                                                                                                                                                        Ok(v7293)
                                                                                                                                                                                    }
                                                                                                                                                                                    File_system::US13::US13_1(v7218_1_0)
                                                                                                                                                                                    =>
                                                                                                                                                                                    {
                                                                                                                                                                                        let v7322:
                                                                                                                                                                                                string =
                                                                                                                                                                                            sprintf!("file_system.read_link / error\': {} / error: {} / name: {}",
                                                                                                                                                                                                     v7218_1_0.clone(),
                                                                                                                                                                                                     v6320.clone(),
                                                                                                                                                                                                     v6321.clone());
                                                                                                                                                                                        let v7329:
                                                                                                                                                                                                std::io::Error =
                                                                                                                                                                                            std::io::Error::new(std::io::ErrorKind::Other, &*v7322);
                                                                                                                                                                                        Err(v7329)
                                                                                                                                                                                    }
                                                                                                                                                                                }
                                                                                                                                                                            } else {
                                                                                                                                                                                let v7351:
                                                                                                                                                                                        string =
                                                                                                                                                                                    sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                                                                                                                                                             v0_1.clone(),
                                                                                                                                                                                             v6320.clone(),
                                                                                                                                                                                             v6285.clone(),
                                                                                                                                                                                             v6321.clone());
                                                                                                                                                                                let v7358:
                                                                                                                                                                                        std::io::Error =
                                                                                                                                                                                    std::io::Error::new(std::io::ErrorKind::Other, &*v7351);
                                                                                                                                                                                Err(v7358)
                                                                                                                                                                            }
                                                                                                                                                                        } else {
                                                                                                                                                                            let v7379:
                                                                                                                                                                                    string =
                                                                                                                                                                                sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                                                                                                                                                         v0_1.clone(),
                                                                                                                                                                                         v6320,
                                                                                                                                                                                         v6285.clone(),
                                                                                                                                                                                         v6321.clone());
                                                                                                                                                                            let v7386:
                                                                                                                                                                                    std::io::Error =
                                                                                                                                                                                std::io::Error::new(std::io::ErrorKind::Other, &*v7379);
                                                                                                                                                                            Err(v7386)
                                                                                                                                                                        }
                                                                                                                                                                    }
                                                                                                                                                                };
                                                                                                                                                            let v7409 =
                                                                                                                                                                File_system::method76();
                                                                                                                                                            let v7420:
                                                                                                                                                                    Result<std::path::PathBuf,
                                                                                                                                                                           string> =
                                                                                                                                                                v7408.map_err(|x| v7409(x));
                                                                                                                                                            let v7423:
                                                                                                                                                                    File_system::US13 =
                                                                                                                                                                match &v7420
                                                                                                                                                                    {
                                                                                                                                                                    Err(v7420_1_0)
                                                                                                                                                                    =>
                                                                                                                                                                    v5918(v7420_1_0.clone()),
                                                                                                                                                                    Ok(v7420_0_0)
                                                                                                                                                                    =>
                                                                                                                                                                    v5917(v7420_0_0.clone()),
                                                                                                                                                                };
                                                                                                                                                            match &v7423
                                                                                                                                                                {
                                                                                                                                                                File_system::US13::US13_0(v7423_0_0)
                                                                                                                                                                =>
                                                                                                                                                                {
                                                                                                                                                                    let v7449:
                                                                                                                                                                            string =
                                                                                                                                                                        File_system::method56(toString(v7423_0_0.clone().display()),
                                                                                                                                                                                              v6266.clone());
                                                                                                                                                                    let v7456:
                                                                                                                                                                            &str =
                                                                                                                                                                        &*v7449;
                                                                                                                                                                    let v7477:
                                                                                                                                                                            std::string::String =
                                                                                                                                                                        String::from(v7456);
                                                                                                                                                                    let v7498:
                                                                                                                                                                            std::path::PathBuf =
                                                                                                                                                                        std::path::PathBuf::from(v7477);
                                                                                                                                                                    Ok(v7498)
                                                                                                                                                                }
                                                                                                                                                                File_system::US13::US13_1(v7423_1_0)
                                                                                                                                                                =>
                                                                                                                                                                {
                                                                                                                                                                    let v7527:
                                                                                                                                                                            string =
                                                                                                                                                                        sprintf!("file_system.read_link / error\': {} / error: {} / name: {}",
                                                                                                                                                                                 v7423_1_0.clone(),
                                                                                                                                                                                 v6265.clone(),
                                                                                                                                                                                 v6266.clone());
                                                                                                                                                                    let v7534:
                                                                                                                                                                            std::io::Error =
                                                                                                                                                                        std::io::Error::new(std::io::ErrorKind::Other, &*v7527);
                                                                                                                                                                    Err(v7534)
                                                                                                                                                                }
                                                                                                                                                            }
                                                                                                                                                        } else {
                                                                                                                                                            let v7556:
                                                                                                                                                                    string =
                                                                                                                                                                sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                                                                                                                                         v0_1.clone(),
                                                                                                                                                                         v6265.clone(),
                                                                                                                                                                         v6230.clone(),
                                                                                                                                                                         v6266.clone());
                                                                                                                                                            let v7563:
                                                                                                                                                                    std::io::Error =
                                                                                                                                                                std::io::Error::new(std::io::ErrorKind::Other, &*v7556);
                                                                                                                                                            Err(v7563)
                                                                                                                                                        }
                                                                                                                                                    } else {
                                                                                                                                                        let v7584:
                                                                                                                                                                string =
                                                                                                                                                            sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                                                                                                                                     v0_1.clone(),
                                                                                                                                                                     v6265,
                                                                                                                                                                     v6230.clone(),
                                                                                                                                                                     v6266.clone());
                                                                                                                                                        let v7591:
                                                                                                                                                                std::io::Error =
                                                                                                                                                            std::io::Error::new(std::io::ErrorKind::Other, &*v7584);
                                                                                                                                                        Err(v7591)
                                                                                                                                                    }
                                                                                                                                                }
                                                                                                                                            };
                                                                                                                                        let v7614 =
                                                                                                                                            File_system::method76();
                                                                                                                                        let v7625:
                                                                                                                                                Result<std::path::PathBuf,
                                                                                                                                                       string> =
                                                                                                                                            v7613.map_err(|x| v7614(x));
                                                                                                                                        let v7628:
                                                                                                                                                File_system::US13 =
                                                                                                                                            match &v7625
                                                                                                                                                {
                                                                                                                                                Err(v7625_1_0)
                                                                                                                                                =>
                                                                                                                                                v5918(v7625_1_0.clone()),
                                                                                                                                                Ok(v7625_0_0)
                                                                                                                                                =>
                                                                                                                                                v5917(v7625_0_0.clone()),
                                                                                                                                            };
                                                                                                                                        match &v7628
                                                                                                                                            {
                                                                                                                                            File_system::US13::US13_0(v7628_0_0)
                                                                                                                                            =>
                                                                                                                                            {
                                                                                                                                                let v7654:
                                                                                                                                                        string =
                                                                                                                                                    File_system::method56(toString(v7628_0_0.clone().display()),
                                                                                                                                                                          v6211.clone());
                                                                                                                                                let v7661:
                                                                                                                                                        &str =
                                                                                                                                                    &*v7654;
                                                                                                                                                let v7682:
                                                                                                                                                        std::string::String =
                                                                                                                                                    String::from(v7661);
                                                                                                                                                let v7703:
                                                                                                                                                        std::path::PathBuf =
                                                                                                                                                    std::path::PathBuf::from(v7682);
                                                                                                                                                Ok(v7703)
                                                                                                                                            }
                                                                                                                                            File_system::US13::US13_1(v7628_1_0)
                                                                                                                                            =>
                                                                                                                                            {
                                                                                                                                                let v7732:
                                                                                                                                                        string =
                                                                                                                                                    sprintf!("file_system.read_link / error\': {} / error: {} / name: {}",
                                                                                                                                                             v7628_1_0.clone(),
                                                                                                                                                             v6210.clone(),
                                                                                                                                                             v6211.clone());
                                                                                                                                                let v7739:
                                                                                                                                                        std::io::Error =
                                                                                                                                                    std::io::Error::new(std::io::ErrorKind::Other, &*v7732);
                                                                                                                                                Err(v7739)
                                                                                                                                            }
                                                                                                                                        }
                                                                                                                                    } else {
                                                                                                                                        let v7761:
                                                                                                                                                string =
                                                                                                                                            sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                                                                                                                     v0_1.clone(),
                                                                                                                                                     v6210.clone(),
                                                                                                                                                     v6175.clone(),
                                                                                                                                                     v6211.clone());
                                                                                                                                        let v7768:
                                                                                                                                                std::io::Error =
                                                                                                                                            std::io::Error::new(std::io::ErrorKind::Other, &*v7761);
                                                                                                                                        Err(v7768)
                                                                                                                                    }
                                                                                                                                } else {
                                                                                                                                    let v7789:
                                                                                                                                            string =
                                                                                                                                        sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                                                                                                                 v0_1.clone(),
                                                                                                                                                 v6210,
                                                                                                                                                 v6175.clone(),
                                                                                                                                                 v6211.clone());
                                                                                                                                    let v7796:
                                                                                                                                            std::io::Error =
                                                                                                                                        std::io::Error::new(std::io::ErrorKind::Other, &*v7789);
                                                                                                                                    Err(v7796)
                                                                                                                                }
                                                                                                                            }
                                                                                                                        };
                                                                                                                    let v7819 =
                                                                                                                        File_system::method76();
                                                                                                                    let v7830:
                                                                                                                            Result<std::path::PathBuf,
                                                                                                                                   string> =
                                                                                                                        v7818.map_err(|x| v7819(x));
                                                                                                                    let v7833:
                                                                                                                            File_system::US13 =
                                                                                                                        match &v7830
                                                                                                                            {
                                                                                                                            Err(v7830_1_0)
                                                                                                                            =>
                                                                                                                            v5918(v7830_1_0.clone()),
                                                                                                                            Ok(v7830_0_0)
                                                                                                                            =>
                                                                                                                            v5917(v7830_0_0.clone()),
                                                                                                                        };
                                                                                                                    match &v7833
                                                                                                                        {
                                                                                                                        File_system::US13::US13_0(v7833_0_0)
                                                                                                                        =>
                                                                                                                        {
                                                                                                                            let v7859:
                                                                                                                                    string =
                                                                                                                                File_system::method56(toString(v7833_0_0.clone().display()),
                                                                                                                                                      v6156.clone());
                                                                                                                            let v7866:
                                                                                                                                    &str =
                                                                                                                                &*v7859;
                                                                                                                            let v7887:
                                                                                                                                    std::string::String =
                                                                                                                                String::from(v7866);
                                                                                                                            let v7908:
                                                                                                                                    std::path::PathBuf =
                                                                                                                                std::path::PathBuf::from(v7887);
                                                                                                                            Ok(v7908)
                                                                                                                        }
                                                                                                                        File_system::US13::US13_1(v7833_1_0)
                                                                                                                        =>
                                                                                                                        {
                                                                                                                            let v7937:
                                                                                                                                    string =
                                                                                                                                sprintf!("file_system.read_link / error\': {} / error: {} / name: {}",
                                                                                                                                         v7833_1_0.clone(),
                                                                                                                                         v6155.clone(),
                                                                                                                                         v6156.clone());
                                                                                                                            let v7944:
                                                                                                                                    std::io::Error =
                                                                                                                                std::io::Error::new(std::io::ErrorKind::Other, &*v7937);
                                                                                                                            Err(v7944)
                                                                                                                        }
                                                                                                                    }
                                                                                                                } else {
                                                                                                                    let v7966:
                                                                                                                            string =
                                                                                                                        sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                                                                                                 v0_1.clone(),
                                                                                                                                 v6155.clone(),
                                                                                                                                 v6120.clone(),
                                                                                                                                 v6156.clone());
                                                                                                                    let v7973:
                                                                                                                            std::io::Error =
                                                                                                                        std::io::Error::new(std::io::ErrorKind::Other, &*v7966);
                                                                                                                    Err(v7973)
                                                                                                                }
                                                                                                            } else {
                                                                                                                let v7994:
                                                                                                                        string =
                                                                                                                    sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                                                                                             v0_1.clone(),
                                                                                                                             v6155,
                                                                                                                             v6120.clone(),
                                                                                                                             v6156.clone());
                                                                                                                let v8001:
                                                                                                                        std::io::Error =
                                                                                                                    std::io::Error::new(std::io::ErrorKind::Other, &*v7994);
                                                                                                                Err(v8001)
                                                                                                            }
                                                                                                        }
                                                                                                    };
                                                                                                let v8024 =
                                                                                                    File_system::method76();
                                                                                                let v8035:
                                                                                                        Result<std::path::PathBuf,
                                                                                                               string> =
                                                                                                    v8023.map_err(|x| v8024(x));
                                                                                                let v8038:
                                                                                                        File_system::US13 =
                                                                                                    match &v8035
                                                                                                        {
                                                                                                        Err(v8035_1_0)
                                                                                                        =>
                                                                                                        v5918(v8035_1_0.clone()),
                                                                                                        Ok(v8035_0_0)
                                                                                                        =>
                                                                                                        v5917(v8035_0_0.clone()),
                                                                                                    };
                                                                                                match &v8038
                                                                                                    {
                                                                                                    File_system::US13::US13_0(v8038_0_0)
                                                                                                    =>
                                                                                                    {
                                                                                                        let v8064:
                                                                                                                string =
                                                                                                            File_system::method56(toString(v8038_0_0.clone().display()),
                                                                                                                                  v6101.clone());
                                                                                                        let v8071:
                                                                                                                &str =
                                                                                                            &*v8064;
                                                                                                        let v8092:
                                                                                                                std::string::String =
                                                                                                            String::from(v8071);
                                                                                                        let v8113:
                                                                                                                std::path::PathBuf =
                                                                                                            std::path::PathBuf::from(v8092);
                                                                                                        Ok(v8113)
                                                                                                    }
                                                                                                    File_system::US13::US13_1(v8038_1_0)
                                                                                                    =>
                                                                                                    {
                                                                                                        let v8142:
                                                                                                                string =
                                                                                                            sprintf!("file_system.read_link / error\': {} / error: {} / name: {}",
                                                                                                                     v8038_1_0.clone(),
                                                                                                                     v6100.clone(),
                                                                                                                     v6101.clone());
                                                                                                        let v8149:
                                                                                                                std::io::Error =
                                                                                                            std::io::Error::new(std::io::ErrorKind::Other, &*v8142);
                                                                                                        Err(v8149)
                                                                                                    }
                                                                                                }
                                                                                            } else {
                                                                                                let v8171:
                                                                                                        string =
                                                                                                    sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                                                                             v0_1.clone(),
                                                                                                             v6100.clone(),
                                                                                                             v6065.clone(),
                                                                                                             v6101.clone());
                                                                                                let v8178:
                                                                                                        std::io::Error =
                                                                                                    std::io::Error::new(std::io::ErrorKind::Other, &*v8171);
                                                                                                Err(v8178)
                                                                                            }
                                                                                        } else {
                                                                                            let v8199:
                                                                                                    string =
                                                                                                sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                                                                         v0_1.clone(),
                                                                                                         v6100,
                                                                                                         v6065.clone(),
                                                                                                         v6101.clone());
                                                                                            let v8206:
                                                                                                    std::io::Error =
                                                                                                std::io::Error::new(std::io::ErrorKind::Other, &*v8199);
                                                                                            Err(v8206)
                                                                                        }
                                                                    }
                                                                };
                                                                let v8229 = File_system::method76();
                                                                let v8240: Result<
                                                                    std::path::PathBuf,
                                                                    string,
                                                                > = v8228.map_err(|x| v8229(x));
                                                                let v8243: File_system::US13 =
                                                                    match &v8240 {
                                                                        Err(v8240_1_0) => {
                                                                            v5918(v8240_1_0.clone())
                                                                        }
                                                                        Ok(v8240_0_0) => {
                                                                            v5917(v8240_0_0.clone())
                                                                        }
                                                                    };
                                                                match &v8243 {
                                                                    File_system::US13::US13_0(
                                                                        v8243_0_0,
                                                                    ) => {
                                                                        let v8269: string =
                                                                            File_system::method56(
                                                                                toString(
                                                                                    v8243_0_0
                                                                                        .clone()
                                                                                        .display(),
                                                                                ),
                                                                                v6046.clone(),
                                                                            );
                                                                        let v8276: &str = &*v8269;
                                                                        let v8297:
                                                                                            std::string::String =
                                                                                        String::from(v8276);
                                                                        let v8318:
                                                                                            std::path::PathBuf =
                                                                                        std::path::PathBuf::from(v8297);
                                                                        Ok(v8318)
                                                                    }
                                                                    File_system::US13::US13_1(
                                                                        v8243_1_0,
                                                                    ) => {
                                                                        let v8347:
                                                                                            string =
                                                                                        sprintf!("file_system.read_link / error\': {} / error: {} / name: {}",
                                                                                                 v8243_1_0.clone(),
                                                                                                 v6045.clone(),
                                                                                                 v6046.clone());
                                                                        let v8354:
                                                                                            std::io::Error =
                                                                                        std::io::Error::new(std::io::ErrorKind::Other, &*v8347);
                                                                        Err(v8354)
                                                                    }
                                                                }
                                                            } else {
                                                                let v8376:
                                                                                    string =
                                                                                sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                                                         v0_1.clone(),
                                                                                         v6045.clone(),
                                                                                         v6010.clone(),
                                                                                         v6046.clone());
                                                                let v8383: std::io::Error =
                                                                    std::io::Error::new(
                                                                        std::io::ErrorKind::Other,
                                                                        &*v8376,
                                                                    );
                                                                Err(v8383)
                                                            }
                                                        } else {
                                                            let v8404:
                                                                                string =
                                                                            sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                                                     v0_1.clone(),
                                                                                     v6045,
                                                                                     v6010.clone(),
                                                                                     v6046.clone());
                                                            let v8411: std::io::Error =
                                                                std::io::Error::new(
                                                                    std::io::ErrorKind::Other,
                                                                    &*v8404,
                                                                );
                                                            Err(v8411)
                                                        }
                                                    }
                                                };
                                                let v8434 = File_system::method76();
                                                let v8445: Result<std::path::PathBuf, string> =
                                                    v8433.map_err(|x| v8434(x));
                                                let v8448: File_system::US13 = match &v8445 {
                                                    Err(v8445_1_0) => v5918(v8445_1_0.clone()),
                                                    Ok(v8445_0_0) => v5917(v8445_0_0.clone()),
                                                };
                                                match &v8448 {
                                                    File_system::US13::US13_0(v8448_0_0) => {
                                                        let v8474: string = File_system::method56(
                                                            toString(v8448_0_0.clone().display()),
                                                            v5991.clone(),
                                                        );
                                                        let v8481: &str = &*v8474;
                                                        let v8502: std::string::String =
                                                            String::from(v8481);
                                                        let v8523: std::path::PathBuf =
                                                            std::path::PathBuf::from(v8502);
                                                        Ok(v8523)
                                                    }
                                                    File_system::US13::US13_1(v8448_1_0) => {
                                                        let v8552:
                                                                        string =
                                                                    sprintf!("file_system.read_link / error\': {} / error: {} / name: {}",
                                                                             v8448_1_0.clone(),
                                                                             v5990.clone(),
                                                                             v5991.clone());
                                                        let v8559: std::io::Error =
                                                            std::io::Error::new(
                                                                std::io::ErrorKind::Other,
                                                                &*v8552,
                                                            );
                                                        Err(v8559)
                                                    }
                                                }
                                            } else {
                                                let v8581: string =
                                                            sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                                     v0_1.clone(),
                                                                     v5990.clone(),
                                                                     v5954.clone(),
                                                                     v5991.clone());
                                                let v8588: std::io::Error = std::io::Error::new(
                                                    std::io::ErrorKind::Other,
                                                    &*v8581,
                                                );
                                                Err(v8588)
                                            }
                                        } else {
                                            let v8609: string =
                                                        sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                                 v0_1.clone(),
                                                                 v5990,
                                                                 v5954.clone(),
                                                                 v5991.clone());
                                            let v8616: std::io::Error = std::io::Error::new(
                                                std::io::ErrorKind::Other,
                                                &*v8609,
                                            );
                                            Err(v8616)
                                        }
                                    }
                                };
                                let v8639 = File_system::method76();
                                let v8650: Result<std::path::PathBuf, string> =
                                    v8638.map_err(|x| v8639(x));
                                let v8653: File_system::US13 = match &v8650 {
                                    Err(v8650_1_0) => v5918(v8650_1_0.clone()),
                                    Ok(v8650_0_0) => v5917(v8650_0_0.clone()),
                                };
                                match &v8653 {
                                    File_system::US13::US13_0(v8653_0_0) => {
                                        let v8679: string = File_system::method56(
                                            toString(v8653_0_0.clone().display()),
                                            v5935.clone(),
                                        );
                                        let v8686: &str = &*v8679;
                                        let v8707: std::string::String = String::from(v8686);
                                        let v8728: std::path::PathBuf =
                                            std::path::PathBuf::from(v8707);
                                        Ok(v8728)
                                    }
                                    File_system::US13::US13_1(v8653_1_0) => {
                                        let v8757: string =
                                                sprintf!("file_system.read_link / error\': {} / error: {} / name: {}",
                                                         v8653_1_0.clone(),
                                                         v5934.clone(),
                                                         v5935.clone());
                                        let v8764: std::io::Error =
                                            std::io::Error::new(std::io::ErrorKind::Other, &*v8757);
                                        Err(v8764)
                                    }
                                }
                            } else {
                                let v8786: string =
                                        sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                 v0_1.clone(), v5934.clone(),
                                                 v0_1.clone(), v5935.clone());
                                let v8793: std::io::Error =
                                    std::io::Error::new(std::io::ErrorKind::Other, &*v8786);
                                Err(v8793)
                            }
                        } else {
                            let v8814: string =
                                    sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                             v0_1.clone(), v5934,
                                             v0_1.clone(), v5935.clone());
                            let v8821: std::io::Error =
                                std::io::Error::new(std::io::ErrorKind::Other, &*v8814);
                            Err(v8821)
                        }
                    }
                }
            };
            let v13141: Option<std::path::PathBuf> = v8844.ok();
            let v13161: File_system::US14 = defaultValue(
                File_system::US14::US14_1,
                map(File_system::method80(), v13141),
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
                let v8851: Result<std::path::PathBuf, std::io::Error> = if File_system::method9(
                    v1_1.clone(),
                ) {
                    std::fs::read_link(&*v1_1.clone())
                } else {
                    let v5909: Result<std::path::PathBuf, std::io::Error> =
                        std::fs::read_link(&*v1_1.clone());
                    let v5910 = File_system::method76();
                    let v5921: Result<std::path::PathBuf, string> = v5909.map_err(|x| v5910(x));
                    fn v5924(v: std::path::PathBuf) -> File_system::US13 {
                        File_system::closure47((), v)
                    }
                    fn v5925(v_1: string) -> File_system::US13 {
                        File_system::closure48((), v_1)
                    }
                    let v5926: File_system::US13 = match &v5921 {
                        Err(v5921_1_0) => v5925(v5921_1_0.clone()),
                        Ok(v5921_0_0) => v5924(v5921_0_0.clone()),
                    };
                    match &v5926 {
                        File_system::US13::US13_0(v5926_0_0) => Ok(v5926_0_0.clone()),
                        File_system::US13::US13_1(v5926_1_0) => {
                            let v5941: string = v5926_1_0.clone();
                            let v5942: string = File_system::method19(v1_1.clone());
                            let v5943: Option<string> = File_system::method78(v1_1.clone());
                            let v5957: File_system::US1 = defaultValue(
                                File_system::US1::US1_1,
                                map(File_system::method4(), v5943),
                            );
                            if let File_system::US1::US1_0(v5957_0_0) = &v5957 {
                                let v5961: string = match &v5957 {
                                    File_system::US1::US1_0(x) => x.clone(),
                                    _ => unreachable!(),
                                };
                                if v1_1.clone() != string("") {
                                    let v5967: Result<std::path::PathBuf, std::io::Error> =
                                        std::fs::read_link(&*v5961.clone());
                                    let v5968 = File_system::method76();
                                    let v5979: Result<std::path::PathBuf, string> =
                                        v5967.map_err(|x| v5968(x));
                                    let v5982: File_system::US13 = match &v5979 {
                                        Err(v5979_1_0) => v5925(v5979_1_0.clone()),
                                        Ok(v5979_0_0) => v5924(v5979_0_0.clone()),
                                    };
                                    let v8645: Result<std::path::PathBuf, std::io::Error> =
                                        match &v5982 {
                                            File_system::US13::US13_0(v5982_0_0) => {
                                                Ok(v5982_0_0.clone())
                                            }
                                            File_system::US13::US13_1(v5982_1_0) => {
                                                let v5997: string = v5982_1_0.clone();
                                                let v5998: string =
                                                    File_system::method19(v5961.clone());
                                                let v5999: Option<string> =
                                                    File_system::method78(v5961.clone());
                                                let v6013: File_system::US1 = defaultValue(
                                                    File_system::US1::US1_1,
                                                    map(File_system::method4(), v5999),
                                                );
                                                if let File_system::US1::US1_0(v6013_0_0) = &v6013 {
                                                    let v6017: string = match &v6013 {
                                                        File_system::US1::US1_0(x) => x.clone(),
                                                        _ => unreachable!(),
                                                    };
                                                    if v5961.clone() != string("") {
                                                        let v6022: Result<
                                                            std::path::PathBuf,
                                                            std::io::Error,
                                                        > = std::fs::read_link(&*v6017.clone());
                                                        let v6023 = File_system::method76();
                                                        let v6034: Result<
                                                            std::path::PathBuf,
                                                            string,
                                                        > = v6022.map_err(|x| v6023(x));
                                                        let v6037: File_system::US13 = match &v6034
                                                        {
                                                            Err(v6034_1_0) => {
                                                                v5925(v6034_1_0.clone())
                                                            }
                                                            Ok(v6034_0_0) => {
                                                                v5924(v6034_0_0.clone())
                                                            }
                                                        };
                                                        let v8440: Result<
                                                            std::path::PathBuf,
                                                            std::io::Error,
                                                        > = match &v6037 {
                                                            File_system::US13::US13_0(
                                                                v6037_0_0,
                                                            ) => Ok(v6037_0_0.clone()),
                                                            File_system::US13::US13_1(
                                                                v6037_1_0,
                                                            ) => {
                                                                let v6052: string =
                                                                    v6037_1_0.clone();
                                                                let v6053: string =
                                                                    File_system::method19(
                                                                        v6017.clone(),
                                                                    );
                                                                let v6054: Option<string> =
                                                                    File_system::method78(
                                                                        v6017.clone(),
                                                                    );
                                                                let v6068: File_system::US1 =
                                                                    defaultValue(
                                                                        File_system::US1::US1_1,
                                                                        map(
                                                                            File_system::method4(),
                                                                            v6054,
                                                                        ),
                                                                    );
                                                                if let File_system::US1::US1_0(
                                                                    v6068_0_0,
                                                                ) = &v6068
                                                                {
                                                                    let v6072: string = match &v6068
                                                                    {
                                                                        File_system::US1::US1_0(
                                                                            x,
                                                                        ) => x.clone(),
                                                                        _ => unreachable!(),
                                                                    };
                                                                    if v6017.clone() != string("") {
                                                                        let v6077: Result<
                                                                            std::path::PathBuf,
                                                                            std::io::Error,
                                                                        > = std::fs::read_link(
                                                                            &*v6072.clone(),
                                                                        );
                                                                        let v6078 =
                                                                            File_system::method76();
                                                                        let v6089: Result<
                                                                            std::path::PathBuf,
                                                                            string,
                                                                        > = v6077
                                                                            .map_err(|x| v6078(x));
                                                                        let v6092:
                                                                                           File_system::US13 =
                                                                                       match &v6089
                                                                                           {
                                                                                           Err(v6089_1_0)
                                                                                           =>
                                                                                           v5925(v6089_1_0.clone()),
                                                                                           Ok(v6089_0_0)
                                                                                           =>
                                                                                           v5924(v6089_0_0.clone()),
                                                                                       };
                                                                        let v8235:
                                                                                           Result<std::path::PathBuf,
                                                                                                  std::io::Error> =
                                                                                       match &v6092
                                                                                           {
                                                                                           File_system::US13::US13_0(v6092_0_0)
                                                                                           =>
                                                                                           Ok(v6092_0_0.clone()),
                                                                                           File_system::US13::US13_1(v6092_1_0)
                                                                                           =>
                                                                                           {
                                                                                               let v6107:
                                                                                                       string =
                                                                                                   v6092_1_0.clone();
                                                                                               let v6108:
                                                                                                       string =
                                                                                                   File_system::method19(v6072.clone());
                                                                                               let v6109:
                                                                                                       Option<string> =
                                                                                                   File_system::method78(v6072.clone());
                                                                                               let v6123:
                                                                                                       File_system::US1 =
                                                                                                   defaultValue(File_system::US1::US1_1,
                                                                                                                map(File_system::method4(),
                                                                                                                    v6109));
                                                                                               if let File_system::US1::US1_0(v6123_0_0)
                                                                                                      =
                                                                                                      &v6123
                                                                                                  {
                                                                                                   let v6127:
                                                                                                           string =
                                                                                                       match &v6123
                                                                                                           {
                                                                                                           File_system::US1::US1_0(x)
                                                                                                           =>
                                                                                                           x.clone(),
                                                                                                           _
                                                                                                           =>
                                                                                                           unreachable!(),
                                                                                                       };
                                                                                                   if v6072.clone()
                                                                                                          !=
                                                                                                          string("")
                                                                                                      {
                                                                                                       let v6132:
                                                                                                               Result<std::path::PathBuf,
                                                                                                                      std::io::Error> =
                                                                                                           std::fs::read_link(&*v6127.clone());
                                                                                                       let v6133 =
                                                                                                           File_system::method76();
                                                                                                       let v6144:
                                                                                                               Result<std::path::PathBuf,
                                                                                                                      string> =
                                                                                                           v6132.map_err(|x| v6133(x));
                                                                                                       let v6147:
                                                                                                               File_system::US13 =
                                                                                                           match &v6144
                                                                                                               {
                                                                                                               Err(v6144_1_0)
                                                                                                               =>
                                                                                                               v5925(v6144_1_0.clone()),
                                                                                                               Ok(v6144_0_0)
                                                                                                               =>
                                                                                                               v5924(v6144_0_0.clone()),
                                                                                                           };
                                                                                                       let v8030:
                                                                                                               Result<std::path::PathBuf,
                                                                                                                      std::io::Error> =
                                                                                                           match &v6147
                                                                                                               {
                                                                                                               File_system::US13::US13_0(v6147_0_0)
                                                                                                               =>
                                                                                                               Ok(v6147_0_0.clone()),
                                                                                                               File_system::US13::US13_1(v6147_1_0)
                                                                                                               =>
                                                                                                               {
                                                                                                                   let v6162:
                                                                                                                           string =
                                                                                                                       v6147_1_0.clone();
                                                                                                                   let v6163:
                                                                                                                           string =
                                                                                                                       File_system::method19(v6127.clone());
                                                                                                                   let v6164:
                                                                                                                           Option<string> =
                                                                                                                       File_system::method78(v6127.clone());
                                                                                                                   let v6178:
                                                                                                                           File_system::US1 =
                                                                                                                       defaultValue(File_system::US1::US1_1,
                                                                                                                                    map(File_system::method4(),
                                                                                                                                        v6164));
                                                                                                                   if let File_system::US1::US1_0(v6178_0_0)
                                                                                                                          =
                                                                                                                          &v6178
                                                                                                                      {
                                                                                                                       let v6182:
                                                                                                                               string =
                                                                                                                           match &v6178
                                                                                                                               {
                                                                                                                               File_system::US1::US1_0(x)
                                                                                                                               =>
                                                                                                                               x.clone(),
                                                                                                                               _
                                                                                                                               =>
                                                                                                                               unreachable!(),
                                                                                                                           };
                                                                                                                       if v6127.clone()
                                                                                                                              !=
                                                                                                                              string("")
                                                                                                                          {
                                                                                                                           let v6187:
                                                                                                                                   Result<std::path::PathBuf,
                                                                                                                                          std::io::Error> =
                                                                                                                               std::fs::read_link(&*v6182.clone());
                                                                                                                           let v6188 =
                                                                                                                               File_system::method76();
                                                                                                                           let v6199:
                                                                                                                                   Result<std::path::PathBuf,
                                                                                                                                          string> =
                                                                                                                               v6187.map_err(|x| v6188(x));
                                                                                                                           let v6202:
                                                                                                                                   File_system::US13 =
                                                                                                                               match &v6199
                                                                                                                                   {
                                                                                                                                   Err(v6199_1_0)
                                                                                                                                   =>
                                                                                                                                   v5925(v6199_1_0.clone()),
                                                                                                                                   Ok(v6199_0_0)
                                                                                                                                   =>
                                                                                                                                   v5924(v6199_0_0.clone()),
                                                                                                                               };
                                                                                                                           let v7825:
                                                                                                                                   Result<std::path::PathBuf,
                                                                                                                                          std::io::Error> =
                                                                                                                               match &v6202
                                                                                                                                   {
                                                                                                                                   File_system::US13::US13_0(v6202_0_0)
                                                                                                                                   =>
                                                                                                                                   Ok(v6202_0_0.clone()),
                                                                                                                                   File_system::US13::US13_1(v6202_1_0)
                                                                                                                                   =>
                                                                                                                                   {
                                                                                                                                       let v6217:
                                                                                                                                               string =
                                                                                                                                           v6202_1_0.clone();
                                                                                                                                       let v6218:
                                                                                                                                               string =
                                                                                                                                           File_system::method19(v6182.clone());
                                                                                                                                       let v6219:
                                                                                                                                               Option<string> =
                                                                                                                                           File_system::method78(v6182.clone());
                                                                                                                                       let v6233:
                                                                                                                                               File_system::US1 =
                                                                                                                                           defaultValue(File_system::US1::US1_1,
                                                                                                                                                        map(File_system::method4(),
                                                                                                                                                            v6219));
                                                                                                                                       if let File_system::US1::US1_0(v6233_0_0)
                                                                                                                                              =
                                                                                                                                              &v6233
                                                                                                                                          {
                                                                                                                                           let v6237:
                                                                                                                                                   string =
                                                                                                                                               match &v6233
                                                                                                                                                   {
                                                                                                                                                   File_system::US1::US1_0(x)
                                                                                                                                                   =>
                                                                                                                                                   x.clone(),
                                                                                                                                                   _
                                                                                                                                                   =>
                                                                                                                                                   unreachable!(),
                                                                                                                                               };
                                                                                                                                           if v6182.clone()
                                                                                                                                                  !=
                                                                                                                                                  string("")
                                                                                                                                              {
                                                                                                                                               let v6242:
                                                                                                                                                       Result<std::path::PathBuf,
                                                                                                                                                              std::io::Error> =
                                                                                                                                                   std::fs::read_link(&*v6237.clone());
                                                                                                                                               let v6243 =
                                                                                                                                                   File_system::method76();
                                                                                                                                               let v6254:
                                                                                                                                                       Result<std::path::PathBuf,
                                                                                                                                                              string> =
                                                                                                                                                   v6242.map_err(|x| v6243(x));
                                                                                                                                               let v6257:
                                                                                                                                                       File_system::US13 =
                                                                                                                                                   match &v6254
                                                                                                                                                       {
                                                                                                                                                       Err(v6254_1_0)
                                                                                                                                                       =>
                                                                                                                                                       v5925(v6254_1_0.clone()),
                                                                                                                                                       Ok(v6254_0_0)
                                                                                                                                                       =>
                                                                                                                                                       v5924(v6254_0_0.clone()),
                                                                                                                                                   };
                                                                                                                                               let v7620:
                                                                                                                                                       Result<std::path::PathBuf,
                                                                                                                                                              std::io::Error> =
                                                                                                                                                   match &v6257
                                                                                                                                                       {
                                                                                                                                                       File_system::US13::US13_0(v6257_0_0)
                                                                                                                                                       =>
                                                                                                                                                       Ok(v6257_0_0.clone()),
                                                                                                                                                       File_system::US13::US13_1(v6257_1_0)
                                                                                                                                                       =>
                                                                                                                                                       {
                                                                                                                                                           let v6272:
                                                                                                                                                                   string =
                                                                                                                                                               v6257_1_0.clone();
                                                                                                                                                           let v6273:
                                                                                                                                                                   string =
                                                                                                                                                               File_system::method19(v6237.clone());
                                                                                                                                                           let v6274:
                                                                                                                                                                   Option<string> =
                                                                                                                                                               File_system::method78(v6237.clone());
                                                                                                                                                           let v6288:
                                                                                                                                                                   File_system::US1 =
                                                                                                                                                               defaultValue(File_system::US1::US1_1,
                                                                                                                                                                            map(File_system::method4(),
                                                                                                                                                                                v6274));
                                                                                                                                                           if let File_system::US1::US1_0(v6288_0_0)
                                                                                                                                                                  =
                                                                                                                                                                  &v6288
                                                                                                                                                              {
                                                                                                                                                               let v6292:
                                                                                                                                                                       string =
                                                                                                                                                                   match &v6288
                                                                                                                                                                       {
                                                                                                                                                                       File_system::US1::US1_0(x)
                                                                                                                                                                       =>
                                                                                                                                                                       x.clone(),
                                                                                                                                                                       _
                                                                                                                                                                       =>
                                                                                                                                                                       unreachable!(),
                                                                                                                                                                   };
                                                                                                                                                               if v6237.clone()
                                                                                                                                                                      !=
                                                                                                                                                                      string("")
                                                                                                                                                                  {
                                                                                                                                                                   let v6297:
                                                                                                                                                                           Result<std::path::PathBuf,
                                                                                                                                                                                  std::io::Error> =
                                                                                                                                                                       std::fs::read_link(&*v6292.clone());
                                                                                                                                                                   let v6298 =
                                                                                                                                                                       File_system::method76();
                                                                                                                                                                   let v6309:
                                                                                                                                                                           Result<std::path::PathBuf,
                                                                                                                                                                                  string> =
                                                                                                                                                                       v6297.map_err(|x| v6298(x));
                                                                                                                                                                   let v6312:
                                                                                                                                                                           File_system::US13 =
                                                                                                                                                                       match &v6309
                                                                                                                                                                           {
                                                                                                                                                                           Err(v6309_1_0)
                                                                                                                                                                           =>
                                                                                                                                                                           v5925(v6309_1_0.clone()),
                                                                                                                                                                           Ok(v6309_0_0)
                                                                                                                                                                           =>
                                                                                                                                                                           v5924(v6309_0_0.clone()),
                                                                                                                                                                       };
                                                                                                                                                                   let v7415:
                                                                                                                                                                           Result<std::path::PathBuf,
                                                                                                                                                                                  std::io::Error> =
                                                                                                                                                                       match &v6312
                                                                                                                                                                           {
                                                                                                                                                                           File_system::US13::US13_0(v6312_0_0)
                                                                                                                                                                           =>
                                                                                                                                                                           Ok(v6312_0_0.clone()),
                                                                                                                                                                           File_system::US13::US13_1(v6312_1_0)
                                                                                                                                                                           =>
                                                                                                                                                                           {
                                                                                                                                                                               let v6327:
                                                                                                                                                                                       string =
                                                                                                                                                                                   v6312_1_0.clone();
                                                                                                                                                                               let v6328:
                                                                                                                                                                                       string =
                                                                                                                                                                                   File_system::method19(v6292.clone());
                                                                                                                                                                               let v6329:
                                                                                                                                                                                       Option<string> =
                                                                                                                                                                                   File_system::method78(v6292.clone());
                                                                                                                                                                               let v6343:
                                                                                                                                                                                       File_system::US1 =
                                                                                                                                                                                   defaultValue(File_system::US1::US1_1,
                                                                                                                                                                                                map(File_system::method4(),
                                                                                                                                                                                                    v6329));
                                                                                                                                                                               if let File_system::US1::US1_0(v6343_0_0)
                                                                                                                                                                                      =
                                                                                                                                                                                      &v6343
                                                                                                                                                                                  {
                                                                                                                                                                                   let v6347:
                                                                                                                                                                                           string =
                                                                                                                                                                                       match &v6343
                                                                                                                                                                                           {
                                                                                                                                                                                           File_system::US1::US1_0(x)
                                                                                                                                                                                           =>
                                                                                                                                                                                           x.clone(),
                                                                                                                                                                                           _
                                                                                                                                                                                           =>
                                                                                                                                                                                           unreachable!(),
                                                                                                                                                                                       };
                                                                                                                                                                                   if v6292.clone()
                                                                                                                                                                                          !=
                                                                                                                                                                                          string("")
                                                                                                                                                                                      {
                                                                                                                                                                                       let v6352:
                                                                                                                                                                                               Result<std::path::PathBuf,
                                                                                                                                                                                                      std::io::Error> =
                                                                                                                                                                                           std::fs::read_link(&*v6347.clone());
                                                                                                                                                                                       let v6353 =
                                                                                                                                                                                           File_system::method76();
                                                                                                                                                                                       let v6364:
                                                                                                                                                                                               Result<std::path::PathBuf,
                                                                                                                                                                                                      string> =
                                                                                                                                                                                           v6352.map_err(|x| v6353(x));
                                                                                                                                                                                       let v6367:
                                                                                                                                                                                               File_system::US13 =
                                                                                                                                                                                           match &v6364
                                                                                                                                                                                               {
                                                                                                                                                                                               Err(v6364_1_0)
                                                                                                                                                                                               =>
                                                                                                                                                                                               v5925(v6364_1_0.clone()),
                                                                                                                                                                                               Ok(v6364_0_0)
                                                                                                                                                                                               =>
                                                                                                                                                                                               v5924(v6364_0_0.clone()),
                                                                                                                                                                                           };
                                                                                                                                                                                       let v7210:
                                                                                                                                                                                               Result<std::path::PathBuf,
                                                                                                                                                                                                      std::io::Error> =
                                                                                                                                                                                           match &v6367
                                                                                                                                                                                               {
                                                                                                                                                                                               File_system::US13::US13_0(v6367_0_0)
                                                                                                                                                                                               =>
                                                                                                                                                                                               Ok(v6367_0_0.clone()),
                                                                                                                                                                                               File_system::US13::US13_1(v6367_1_0)
                                                                                                                                                                                               =>
                                                                                                                                                                                               {
                                                                                                                                                                                                   let v6382:
                                                                                                                                                                                                           string =
                                                                                                                                                                                                       v6367_1_0.clone();
                                                                                                                                                                                                   let v6383:
                                                                                                                                                                                                           string =
                                                                                                                                                                                                       File_system::method19(v6347.clone());
                                                                                                                                                                                                   let v6384:
                                                                                                                                                                                                           Option<string> =
                                                                                                                                                                                                       File_system::method78(v6347.clone());
                                                                                                                                                                                                   let v6398:
                                                                                                                                                                                                           File_system::US1 =
                                                                                                                                                                                                       defaultValue(File_system::US1::US1_1,
                                                                                                                                                                                                                    map(File_system::method4(),
                                                                                                                                                                                                                        v6384));
                                                                                                                                                                                                   if let File_system::US1::US1_0(v6398_0_0)
                                                                                                                                                                                                          =
                                                                                                                                                                                                          &v6398
                                                                                                                                                                                                      {
                                                                                                                                                                                                       let v6402:
                                                                                                                                                                                                               string =
                                                                                                                                                                                                           match &v6398
                                                                                                                                                                                                               {
                                                                                                                                                                                                               File_system::US1::US1_0(x)
                                                                                                                                                                                                               =>
                                                                                                                                                                                                               x.clone(),
                                                                                                                                                                                                               _
                                                                                                                                                                                                               =>
                                                                                                                                                                                                               unreachable!(),
                                                                                                                                                                                                           };
                                                                                                                                                                                                       if v6347.clone()
                                                                                                                                                                                                              !=
                                                                                                                                                                                                              string("")
                                                                                                                                                                                                          {
                                                                                                                                                                                                           let v6407:
                                                                                                                                                                                                                   Result<std::path::PathBuf,
                                                                                                                                                                                                                          std::io::Error> =
                                                                                                                                                                                                               std::fs::read_link(&*v6402.clone());
                                                                                                                                                                                                           let v6408 =
                                                                                                                                                                                                               File_system::method76();
                                                                                                                                                                                                           let v6419:
                                                                                                                                                                                                                   Result<std::path::PathBuf,
                                                                                                                                                                                                                          string> =
                                                                                                                                                                                                               v6407.map_err(|x| v6408(x));
                                                                                                                                                                                                           let v6422:
                                                                                                                                                                                                                   File_system::US13 =
                                                                                                                                                                                                               match &v6419
                                                                                                                                                                                                                   {
                                                                                                                                                                                                                   Err(v6419_1_0)
                                                                                                                                                                                                                   =>
                                                                                                                                                                                                                   v5925(v6419_1_0.clone()),
                                                                                                                                                                                                                   Ok(v6419_0_0)
                                                                                                                                                                                                                   =>
                                                                                                                                                                                                                   v5924(v6419_0_0.clone()),
                                                                                                                                                                                                               };
                                                                                                                                                                                                           let v7005:
                                                                                                                                                                                                                   Result<std::path::PathBuf,
                                                                                                                                                                                                                          std::io::Error> =
                                                                                                                                                                                                               match &v6422
                                                                                                                                                                                                                   {
                                                                                                                                                                                                                   File_system::US13::US13_0(v6422_0_0)
                                                                                                                                                                                                                   =>
                                                                                                                                                                                                                   Ok(v6422_0_0.clone()),
                                                                                                                                                                                                                   File_system::US13::US13_1(v6422_1_0)
                                                                                                                                                                                                                   =>
                                                                                                                                                                                                                   {
                                                                                                                                                                                                                       let v6437:
                                                                                                                                                                                                                               string =
                                                                                                                                                                                                                           v6422_1_0.clone();
                                                                                                                                                                                                                       let v6438:
                                                                                                                                                                                                                               string =
                                                                                                                                                                                                                           File_system::method19(v6402.clone());
                                                                                                                                                                                                                       let v6439:
                                                                                                                                                                                                                               Option<string> =
                                                                                                                                                                                                                           File_system::method78(v6402.clone());
                                                                                                                                                                                                                       let v6453:
                                                                                                                                                                                                                               File_system::US1 =
                                                                                                                                                                                                                           defaultValue(File_system::US1::US1_1,
                                                                                                                                                                                                                                        map(File_system::method4(),
                                                                                                                                                                                                                                            v6439));
                                                                                                                                                                                                                       if let File_system::US1::US1_0(v6453_0_0)
                                                                                                                                                                                                                              =
                                                                                                                                                                                                                              &v6453
                                                                                                                                                                                                                          {
                                                                                                                                                                                                                           let v6457:
                                                                                                                                                                                                                                   string =
                                                                                                                                                                                                                               match &v6453
                                                                                                                                                                                                                                   {
                                                                                                                                                                                                                                   File_system::US1::US1_0(x)
                                                                                                                                                                                                                                   =>
                                                                                                                                                                                                                                   x.clone(),
                                                                                                                                                                                                                                   _
                                                                                                                                                                                                                                   =>
                                                                                                                                                                                                                                   unreachable!(),
                                                                                                                                                                                                                               };
                                                                                                                                                                                                                           if v6402.clone()
                                                                                                                                                                                                                                  !=
                                                                                                                                                                                                                                  string("")
                                                                                                                                                                                                                              {
                                                                                                                                                                                                                               let v6462:
                                                                                                                                                                                                                                       Result<std::path::PathBuf,
                                                                                                                                                                                                                                              std::io::Error> =
                                                                                                                                                                                                                                   std::fs::read_link(&*v6457.clone());
                                                                                                                                                                                                                               let v6463 =
                                                                                                                                                                                                                                   File_system::method76();
                                                                                                                                                                                                                               let v6474:
                                                                                                                                                                                                                                       Result<std::path::PathBuf,
                                                                                                                                                                                                                                              string> =
                                                                                                                                                                                                                                   v6462.map_err(|x| v6463(x));
                                                                                                                                                                                                                               let v6477:
                                                                                                                                                                                                                                       File_system::US13 =
                                                                                                                                                                                                                                   match &v6474
                                                                                                                                                                                                                                       {
                                                                                                                                                                                                                                       Err(v6474_1_0)
                                                                                                                                                                                                                                       =>
                                                                                                                                                                                                                                       v5925(v6474_1_0.clone()),
                                                                                                                                                                                                                                       Ok(v6474_0_0)
                                                                                                                                                                                                                                       =>
                                                                                                                                                                                                                                       v5924(v6474_0_0.clone()),
                                                                                                                                                                                                                                   };
                                                                                                                                                                                                                               let v6800:
                                                                                                                                                                                                                                       Result<std::path::PathBuf,
                                                                                                                                                                                                                                              std::io::Error> =
                                                                                                                                                                                                                                   match &v6477
                                                                                                                                                                                                                                       {
                                                                                                                                                                                                                                       File_system::US13::US13_0(v6477_0_0)
                                                                                                                                                                                                                                       =>
                                                                                                                                                                                                                                       Ok(v6477_0_0.clone()),
                                                                                                                                                                                                                                       File_system::US13::US13_1(v6477_1_0)
                                                                                                                                                                                                                                       =>
                                                                                                                                                                                                                                       {
                                                                                                                                                                                                                                           let v6492:
                                                                                                                                                                                                                                                   string =
                                                                                                                                                                                                                                               v6477_1_0.clone();
                                                                                                                                                                                                                                           let v6493:
                                                                                                                                                                                                                                                   string =
                                                                                                                                                                                                                                               File_system::method19(v6457.clone());
                                                                                                                                                                                                                                           let v6494:
                                                                                                                                                                                                                                                   Option<string> =
                                                                                                                                                                                                                                               File_system::method78(v6457.clone());
                                                                                                                                                                                                                                           let v6508:
                                                                                                                                                                                                                                                   File_system::US1 =
                                                                                                                                                                                                                                               defaultValue(File_system::US1::US1_1,
                                                                                                                                                                                                                                                            map(File_system::method4(),
                                                                                                                                                                                                                                                                v6494));
                                                                                                                                                                                                                                           if let File_system::US1::US1_0(v6508_0_0)
                                                                                                                                                                                                                                                  =
                                                                                                                                                                                                                                                  &v6508
                                                                                                                                                                                                                                              {
                                                                                                                                                                                                                                               let v6512:
                                                                                                                                                                                                                                                       string =
                                                                                                                                                                                                                                                   match &v6508
                                                                                                                                                                                                                                                       {
                                                                                                                                                                                                                                                       File_system::US1::US1_0(x)
                                                                                                                                                                                                                                                       =>
                                                                                                                                                                                                                                                       x.clone(),
                                                                                                                                                                                                                                                       _
                                                                                                                                                                                                                                                       =>
                                                                                                                                                                                                                                                       unreachable!(),
                                                                                                                                                                                                                                                   };
                                                                                                                                                                                                                                               if v6457.clone()
                                                                                                                                                                                                                                                      !=
                                                                                                                                                                                                                                                      string("")
                                                                                                                                                                                                                                                  {
                                                                                                                                                                                                                                                   let v6517:
                                                                                                                                                                                                                                                           Result<std::path::PathBuf,
                                                                                                                                                                                                                                                                  std::io::Error> =
                                                                                                                                                                                                                                                       std::fs::read_link(&*v6512.clone());
                                                                                                                                                                                                                                                   let v6518 =
                                                                                                                                                                                                                                                       File_system::method76();
                                                                                                                                                                                                                                                   let v6529:
                                                                                                                                                                                                                                                           Result<std::path::PathBuf,
                                                                                                                                                                                                                                                                  string> =
                                                                                                                                                                                                                                                       v6517.map_err(|x| v6518(x));
                                                                                                                                                                                                                                                   let v6532:
                                                                                                                                                                                                                                                           File_system::US13 =
                                                                                                                                                                                                                                                       match &v6529
                                                                                                                                                                                                                                                           {
                                                                                                                                                                                                                                                           Err(v6529_1_0)
                                                                                                                                                                                                                                                           =>
                                                                                                                                                                                                                                                           v5925(v6529_1_0.clone()),
                                                                                                                                                                                                                                                           Ok(v6529_0_0)
                                                                                                                                                                                                                                                           =>
                                                                                                                                                                                                                                                           v5924(v6529_0_0.clone()),
                                                                                                                                                                                                                                                       };
                                                                                                                                                                                                                                                   let v6595:
                                                                                                                                                                                                                                                           Result<std::path::PathBuf,
                                                                                                                                                                                                                                                                  std::io::Error> =
                                                                                                                                                                                                                                                       match &v6532
                                                                                                                                                                                                                                                           {
                                                                                                                                                                                                                                                           File_system::US13::US13_0(v6532_0_0)
                                                                                                                                                                                                                                                           =>
                                                                                                                                                                                                                                                           Ok(v6532_0_0.clone()),
                                                                                                                                                                                                                                                           _
                                                                                                                                                                                                                                                           =>
                                                                                                                                                                                                                                                           {
                                                                                                                                                                                                                                                               let v6548:
                                                                                                                                                                                                                                                                       string =
                                                                                                                                                                                                                                                                   File_system::method19(v6512.clone());
                                                                                                                                                                                                                                                               let v6549:
                                                                                                                                                                                                                                                                       Option<string> =
                                                                                                                                                                                                                                                                   File_system::method78(v6512.clone());
                                                                                                                                                                                                                                                               let v6563:
                                                                                                                                                                                                                                                                       File_system::US1 =
                                                                                                                                                                                                                                                                   defaultValue(File_system::US1::US1_1,
                                                                                                                                                                                                                                                                                map(File_system::method4(),
                                                                                                                                                                                                                                                                                    v6549));
                                                                                                                                                                                                                                                               let v6567:
                                                                                                                                                                                                                                                                       string =
                                                                                                                                                                                                                                                                   sprintf!("file_system.read_link / path: {} / n: {} / path\': {} / name: {}",
                                                                                                                                                                                                                                                                            v1_1.clone(),
                                                                                                                                                                                                                                                                            11_u8,
                                                                                                                                                                                                                                                                            v6512.clone(),
                                                                                                                                                                                                                                                                            v6548);
                                                                                                                                                                                                                                                               let v6574:
                                                                                                                                                                                                                                                                       std::io::Error =
                                                                                                                                                                                                                                                                   std::io::Error::new(std::io::ErrorKind::Other, &*v6567);
                                                                                                                                                                                                                                                               Err(v6574)
                                                                                                                                                                                                                                                           }
                                                                                                                                                                                                                                                       };
                                                                                                                                                                                                                                                   let v6596 =
                                                                                                                                                                                                                                                       File_system::method76();
                                                                                                                                                                                                                                                   let v6607:
                                                                                                                                                                                                                                                           Result<std::path::PathBuf,
                                                                                                                                                                                                                                                                  string> =
                                                                                                                                                                                                                                                       v6595.map_err(|x| v6596(x));
                                                                                                                                                                                                                                                   let v6610:
                                                                                                                                                                                                                                                           File_system::US13 =
                                                                                                                                                                                                                                                       match &v6607
                                                                                                                                                                                                                                                           {
                                                                                                                                                                                                                                                           Err(v6607_1_0)
                                                                                                                                                                                                                                                           =>
                                                                                                                                                                                                                                                           v5925(v6607_1_0.clone()),
                                                                                                                                                                                                                                                           Ok(v6607_0_0)
                                                                                                                                                                                                                                                           =>
                                                                                                                                                                                                                                                           v5924(v6607_0_0.clone()),
                                                                                                                                                                                                                                                       };
                                                                                                                                                                                                                                                   match &v6610
                                                                                                                                                                                                                                                       {
                                                                                                                                                                                                                                                       File_system::US13::US13_0(v6610_0_0)
                                                                                                                                                                                                                                                       =>
                                                                                                                                                                                                                                                       {
                                                                                                                                                                                                                                                           let v6636:
                                                                                                                                                                                                                                                                   string =
                                                                                                                                                                                                                                                               File_system::method56(toString(v6610_0_0.clone().display()),
                                                                                                                                                                                                                                                                                     v6493.clone());
                                                                                                                                                                                                                                                           let v6643:
                                                                                                                                                                                                                                                                   &str =
                                                                                                                                                                                                                                                               &*v6636;
                                                                                                                                                                                                                                                           let v6664:
                                                                                                                                                                                                                                                                   std::string::String =
                                                                                                                                                                                                                                                               String::from(v6643);
                                                                                                                                                                                                                                                           let v6685:
                                                                                                                                                                                                                                                                   std::path::PathBuf =
                                                                                                                                                                                                                                                               std::path::PathBuf::from(v6664);
                                                                                                                                                                                                                                                           Ok(v6685)
                                                                                                                                                                                                                                                       }
                                                                                                                                                                                                                                                       File_system::US13::US13_1(v6610_1_0)
                                                                                                                                                                                                                                                       =>
                                                                                                                                                                                                                                                       {
                                                                                                                                                                                                                                                           let v6714:
                                                                                                                                                                                                                                                                   string =
                                                                                                                                                                                                                                                               sprintf!("file_system.read_link / error\': {} / error: {} / name: {}",
                                                                                                                                                                                                                                                                        v6610_1_0.clone(),
                                                                                                                                                                                                                                                                        v6492.clone(),
                                                                                                                                                                                                                                                                        v6493.clone());
                                                                                                                                                                                                                                                           let v6721:
                                                                                                                                                                                                                                                                   std::io::Error =
                                                                                                                                                                                                                                                               std::io::Error::new(std::io::ErrorKind::Other, &*v6714);
                                                                                                                                                                                                                                                           Err(v6721)
                                                                                                                                                                                                                                                       }
                                                                                                                                                                                                                                                   }
                                                                                                                                                                                                                                               } else {
                                                                                                                                                                                                                                                   let v6743:
                                                                                                                                                                                                                                                           string =
                                                                                                                                                                                                                                                       sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                                                                                                                                                                                                                                v1_1.clone(),
                                                                                                                                                                                                                                                                v6492.clone(),
                                                                                                                                                                                                                                                                v6457.clone(),
                                                                                                                                                                                                                                                                v6493.clone());
                                                                                                                                                                                                                                                   let v6750:
                                                                                                                                                                                                                                                           std::io::Error =
                                                                                                                                                                                                                                                       std::io::Error::new(std::io::ErrorKind::Other, &*v6743);
                                                                                                                                                                                                                                                   Err(v6750)
                                                                                                                                                                                                                                               }
                                                                                                                                                                                                                                           } else {
                                                                                                                                                                                                                                               let v6771:
                                                                                                                                                                                                                                                       string =
                                                                                                                                                                                                                                                   sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                                                                                                                                                                                                                            v1_1.clone(),
                                                                                                                                                                                                                                                            v6492,
                                                                                                                                                                                                                                                            v6457.clone(),
                                                                                                                                                                                                                                                            v6493.clone());
                                                                                                                                                                                                                                               let v6778:
                                                                                                                                                                                                                                                       std::io::Error =
                                                                                                                                                                                                                                                   std::io::Error::new(std::io::ErrorKind::Other, &*v6771);
                                                                                                                                                                                                                                               Err(v6778)
                                                                                                                                                                                                                                           }
                                                                                                                                                                                                                                       }
                                                                                                                                                                                                                                   };
                                                                                                                                                                                                                               let v6801 =
                                                                                                                                                                                                                                   File_system::method76();
                                                                                                                                                                                                                               let v6812:
                                                                                                                                                                                                                                       Result<std::path::PathBuf,
                                                                                                                                                                                                                                              string> =
                                                                                                                                                                                                                                   v6800.map_err(|x| v6801(x));
                                                                                                                                                                                                                               let v6815:
                                                                                                                                                                                                                                       File_system::US13 =
                                                                                                                                                                                                                                   match &v6812
                                                                                                                                                                                                                                       {
                                                                                                                                                                                                                                       Err(v6812_1_0)
                                                                                                                                                                                                                                       =>
                                                                                                                                                                                                                                       v5925(v6812_1_0.clone()),
                                                                                                                                                                                                                                       Ok(v6812_0_0)
                                                                                                                                                                                                                                       =>
                                                                                                                                                                                                                                       v5924(v6812_0_0.clone()),
                                                                                                                                                                                                                                   };
                                                                                                                                                                                                                               match &v6815
                                                                                                                                                                                                                                   {
                                                                                                                                                                                                                                   File_system::US13::US13_0(v6815_0_0)
                                                                                                                                                                                                                                   =>
                                                                                                                                                                                                                                   {
                                                                                                                                                                                                                                       let v6841:
                                                                                                                                                                                                                                               string =
                                                                                                                                                                                                                                           File_system::method56(toString(v6815_0_0.clone().display()),
                                                                                                                                                                                                                                                                 v6438.clone());
                                                                                                                                                                                                                                       let v6848:
                                                                                                                                                                                                                                               &str =
                                                                                                                                                                                                                                           &*v6841;
                                                                                                                                                                                                                                       let v6869:
                                                                                                                                                                                                                                               std::string::String =
                                                                                                                                                                                                                                           String::from(v6848);
                                                                                                                                                                                                                                       let v6890:
                                                                                                                                                                                                                                               std::path::PathBuf =
                                                                                                                                                                                                                                           std::path::PathBuf::from(v6869);
                                                                                                                                                                                                                                       Ok(v6890)
                                                                                                                                                                                                                                   }
                                                                                                                                                                                                                                   File_system::US13::US13_1(v6815_1_0)
                                                                                                                                                                                                                                   =>
                                                                                                                                                                                                                                   {
                                                                                                                                                                                                                                       let v6919:
                                                                                                                                                                                                                                               string =
                                                                                                                                                                                                                                           sprintf!("file_system.read_link / error\': {} / error: {} / name: {}",
                                                                                                                                                                                                                                                    v6815_1_0.clone(),
                                                                                                                                                                                                                                                    v6437.clone(),
                                                                                                                                                                                                                                                    v6438.clone());
                                                                                                                                                                                                                                       let v6926:
                                                                                                                                                                                                                                               std::io::Error =
                                                                                                                                                                                                                                           std::io::Error::new(std::io::ErrorKind::Other, &*v6919);
                                                                                                                                                                                                                                       Err(v6926)
                                                                                                                                                                                                                                   }
                                                                                                                                                                                                                               }
                                                                                                                                                                                                                           } else {
                                                                                                                                                                                                                               let v6948:
                                                                                                                                                                                                                                       string =
                                                                                                                                                                                                                                   sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                                                                                                                                                                                                            v1_1.clone(),
                                                                                                                                                                                                                                            v6437.clone(),
                                                                                                                                                                                                                                            v6402.clone(),
                                                                                                                                                                                                                                            v6438.clone());
                                                                                                                                                                                                                               let v6955:
                                                                                                                                                                                                                                       std::io::Error =
                                                                                                                                                                                                                                   std::io::Error::new(std::io::ErrorKind::Other, &*v6948);
                                                                                                                                                                                                                               Err(v6955)
                                                                                                                                                                                                                           }
                                                                                                                                                                                                                       } else {
                                                                                                                                                                                                                           let v6976:
                                                                                                                                                                                                                                   string =
                                                                                                                                                                                                                               sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                                                                                                                                                                                                        v1_1.clone(),
                                                                                                                                                                                                                                        v6437,
                                                                                                                                                                                                                                        v6402.clone(),
                                                                                                                                                                                                                                        v6438.clone());
                                                                                                                                                                                                                           let v6983:
                                                                                                                                                                                                                                   std::io::Error =
                                                                                                                                                                                                                               std::io::Error::new(std::io::ErrorKind::Other, &*v6976);
                                                                                                                                                                                                                           Err(v6983)
                                                                                                                                                                                                                       }
                                                                                                                                                                                                                   }
                                                                                                                                                                                                               };
                                                                                                                                                                                                           let v7006 =
                                                                                                                                                                                                               File_system::method76();
                                                                                                                                                                                                           let v7017:
                                                                                                                                                                                                                   Result<std::path::PathBuf,
                                                                                                                                                                                                                          string> =
                                                                                                                                                                                                               v7005.map_err(|x| v7006(x));
                                                                                                                                                                                                           let v7020:
                                                                                                                                                                                                                   File_system::US13 =
                                                                                                                                                                                                               match &v7017
                                                                                                                                                                                                                   {
                                                                                                                                                                                                                   Err(v7017_1_0)
                                                                                                                                                                                                                   =>
                                                                                                                                                                                                                   v5925(v7017_1_0.clone()),
                                                                                                                                                                                                                   Ok(v7017_0_0)
                                                                                                                                                                                                                   =>
                                                                                                                                                                                                                   v5924(v7017_0_0.clone()),
                                                                                                                                                                                                               };
                                                                                                                                                                                                           match &v7020
                                                                                                                                                                                                               {
                                                                                                                                                                                                               File_system::US13::US13_0(v7020_0_0)
                                                                                                                                                                                                               =>
                                                                                                                                                                                                               {
                                                                                                                                                                                                                   let v7046:
                                                                                                                                                                                                                           string =
                                                                                                                                                                                                                       File_system::method56(toString(v7020_0_0.clone().display()),
                                                                                                                                                                                                                                             v6383.clone());
                                                                                                                                                                                                                   let v7053:
                                                                                                                                                                                                                           &str =
                                                                                                                                                                                                                       &*v7046;
                                                                                                                                                                                                                   let v7074:
                                                                                                                                                                                                                           std::string::String =
                                                                                                                                                                                                                       String::from(v7053);
                                                                                                                                                                                                                   let v7095:
                                                                                                                                                                                                                           std::path::PathBuf =
                                                                                                                                                                                                                       std::path::PathBuf::from(v7074);
                                                                                                                                                                                                                   Ok(v7095)
                                                                                                                                                                                                               }
                                                                                                                                                                                                               File_system::US13::US13_1(v7020_1_0)
                                                                                                                                                                                                               =>
                                                                                                                                                                                                               {
                                                                                                                                                                                                                   let v7124:
                                                                                                                                                                                                                           string =
                                                                                                                                                                                                                       sprintf!("file_system.read_link / error\': {} / error: {} / name: {}",
                                                                                                                                                                                                                                v7020_1_0.clone(),
                                                                                                                                                                                                                                v6382.clone(),
                                                                                                                                                                                                                                v6383.clone());
                                                                                                                                                                                                                   let v7131:
                                                                                                                                                                                                                           std::io::Error =
                                                                                                                                                                                                                       std::io::Error::new(std::io::ErrorKind::Other, &*v7124);
                                                                                                                                                                                                                   Err(v7131)
                                                                                                                                                                                                               }
                                                                                                                                                                                                           }
                                                                                                                                                                                                       } else {
                                                                                                                                                                                                           let v7153:
                                                                                                                                                                                                                   string =
                                                                                                                                                                                                               sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                                                                                                                                                                                        v1_1.clone(),
                                                                                                                                                                                                                        v6382.clone(),
                                                                                                                                                                                                                        v6347.clone(),
                                                                                                                                                                                                                        v6383.clone());
                                                                                                                                                                                                           let v7160:
                                                                                                                                                                                                                   std::io::Error =
                                                                                                                                                                                                               std::io::Error::new(std::io::ErrorKind::Other, &*v7153);
                                                                                                                                                                                                           Err(v7160)
                                                                                                                                                                                                       }
                                                                                                                                                                                                   } else {
                                                                                                                                                                                                       let v7181:
                                                                                                                                                                                                               string =
                                                                                                                                                                                                           sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                                                                                                                                                                                    v1_1.clone(),
                                                                                                                                                                                                                    v6382,
                                                                                                                                                                                                                    v6347.clone(),
                                                                                                                                                                                                                    v6383.clone());
                                                                                                                                                                                                       let v7188:
                                                                                                                                                                                                               std::io::Error =
                                                                                                                                                                                                           std::io::Error::new(std::io::ErrorKind::Other, &*v7181);
                                                                                                                                                                                                       Err(v7188)
                                                                                                                                                                                                   }
                                                                                                                                                                                               }
                                                                                                                                                                                           };
                                                                                                                                                                                       let v7211 =
                                                                                                                                                                                           File_system::method76();
                                                                                                                                                                                       let v7222:
                                                                                                                                                                                               Result<std::path::PathBuf,
                                                                                                                                                                                                      string> =
                                                                                                                                                                                           v7210.map_err(|x| v7211(x));
                                                                                                                                                                                       let v7225:
                                                                                                                                                                                               File_system::US13 =
                                                                                                                                                                                           match &v7222
                                                                                                                                                                                               {
                                                                                                                                                                                               Err(v7222_1_0)
                                                                                                                                                                                               =>
                                                                                                                                                                                               v5925(v7222_1_0.clone()),
                                                                                                                                                                                               Ok(v7222_0_0)
                                                                                                                                                                                               =>
                                                                                                                                                                                               v5924(v7222_0_0.clone()),
                                                                                                                                                                                           };
                                                                                                                                                                                       match &v7225
                                                                                                                                                                                           {
                                                                                                                                                                                           File_system::US13::US13_0(v7225_0_0)
                                                                                                                                                                                           =>
                                                                                                                                                                                           {
                                                                                                                                                                                               let v7251:
                                                                                                                                                                                                       string =
                                                                                                                                                                                                   File_system::method56(toString(v7225_0_0.clone().display()),
                                                                                                                                                                                                                         v6328.clone());
                                                                                                                                                                                               let v7258:
                                                                                                                                                                                                       &str =
                                                                                                                                                                                                   &*v7251;
                                                                                                                                                                                               let v7279:
                                                                                                                                                                                                       std::string::String =
                                                                                                                                                                                                   String::from(v7258);
                                                                                                                                                                                               let v7300:
                                                                                                                                                                                                       std::path::PathBuf =
                                                                                                                                                                                                   std::path::PathBuf::from(v7279);
                                                                                                                                                                                               Ok(v7300)
                                                                                                                                                                                           }
                                                                                                                                                                                           File_system::US13::US13_1(v7225_1_0)
                                                                                                                                                                                           =>
                                                                                                                                                                                           {
                                                                                                                                                                                               let v7329:
                                                                                                                                                                                                       string =
                                                                                                                                                                                                   sprintf!("file_system.read_link / error\': {} / error: {} / name: {}",
                                                                                                                                                                                                            v7225_1_0.clone(),
                                                                                                                                                                                                            v6327.clone(),
                                                                                                                                                                                                            v6328.clone());
                                                                                                                                                                                               let v7336:
                                                                                                                                                                                                       std::io::Error =
                                                                                                                                                                                                   std::io::Error::new(std::io::ErrorKind::Other, &*v7329);
                                                                                                                                                                                               Err(v7336)
                                                                                                                                                                                           }
                                                                                                                                                                                       }
                                                                                                                                                                                   } else {
                                                                                                                                                                                       let v7358:
                                                                                                                                                                                               string =
                                                                                                                                                                                           sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                                                                                                                                                                    v1_1.clone(),
                                                                                                                                                                                                    v6327.clone(),
                                                                                                                                                                                                    v6292.clone(),
                                                                                                                                                                                                    v6328.clone());
                                                                                                                                                                                       let v7365:
                                                                                                                                                                                               std::io::Error =
                                                                                                                                                                                           std::io::Error::new(std::io::ErrorKind::Other, &*v7358);
                                                                                                                                                                                       Err(v7365)
                                                                                                                                                                                   }
                                                                                                                                                                               } else {
                                                                                                                                                                                   let v7386:
                                                                                                                                                                                           string =
                                                                                                                                                                                       sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                                                                                                                                                                v1_1.clone(),
                                                                                                                                                                                                v6327,
                                                                                                                                                                                                v6292.clone(),
                                                                                                                                                                                                v6328.clone());
                                                                                                                                                                                   let v7393:
                                                                                                                                                                                           std::io::Error =
                                                                                                                                                                                       std::io::Error::new(std::io::ErrorKind::Other, &*v7386);
                                                                                                                                                                                   Err(v7393)
                                                                                                                                                                               }
                                                                                                                                                                           }
                                                                                                                                                                       };
                                                                                                                                                                   let v7416 =
                                                                                                                                                                       File_system::method76();
                                                                                                                                                                   let v7427:
                                                                                                                                                                           Result<std::path::PathBuf,
                                                                                                                                                                                  string> =
                                                                                                                                                                       v7415.map_err(|x| v7416(x));
                                                                                                                                                                   let v7430:
                                                                                                                                                                           File_system::US13 =
                                                                                                                                                                       match &v7427
                                                                                                                                                                           {
                                                                                                                                                                           Err(v7427_1_0)
                                                                                                                                                                           =>
                                                                                                                                                                           v5925(v7427_1_0.clone()),
                                                                                                                                                                           Ok(v7427_0_0)
                                                                                                                                                                           =>
                                                                                                                                                                           v5924(v7427_0_0.clone()),
                                                                                                                                                                       };
                                                                                                                                                                   match &v7430
                                                                                                                                                                       {
                                                                                                                                                                       File_system::US13::US13_0(v7430_0_0)
                                                                                                                                                                       =>
                                                                                                                                                                       {
                                                                                                                                                                           let v7456:
                                                                                                                                                                                   string =
                                                                                                                                                                               File_system::method56(toString(v7430_0_0.clone().display()),
                                                                                                                                                                                                     v6273.clone());
                                                                                                                                                                           let v7463:
                                                                                                                                                                                   &str =
                                                                                                                                                                               &*v7456;
                                                                                                                                                                           let v7484:
                                                                                                                                                                                   std::string::String =
                                                                                                                                                                               String::from(v7463);
                                                                                                                                                                           let v7505:
                                                                                                                                                                                   std::path::PathBuf =
                                                                                                                                                                               std::path::PathBuf::from(v7484);
                                                                                                                                                                           Ok(v7505)
                                                                                                                                                                       }
                                                                                                                                                                       File_system::US13::US13_1(v7430_1_0)
                                                                                                                                                                       =>
                                                                                                                                                                       {
                                                                                                                                                                           let v7534:
                                                                                                                                                                                   string =
                                                                                                                                                                               sprintf!("file_system.read_link / error\': {} / error: {} / name: {}",
                                                                                                                                                                                        v7430_1_0.clone(),
                                                                                                                                                                                        v6272.clone(),
                                                                                                                                                                                        v6273.clone());
                                                                                                                                                                           let v7541:
                                                                                                                                                                                   std::io::Error =
                                                                                                                                                                               std::io::Error::new(std::io::ErrorKind::Other, &*v7534);
                                                                                                                                                                           Err(v7541)
                                                                                                                                                                       }
                                                                                                                                                                   }
                                                                                                                                                               } else {
                                                                                                                                                                   let v7563:
                                                                                                                                                                           string =
                                                                                                                                                                       sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                                                                                                                                                v1_1.clone(),
                                                                                                                                                                                v6272.clone(),
                                                                                                                                                                                v6237.clone(),
                                                                                                                                                                                v6273.clone());
                                                                                                                                                                   let v7570:
                                                                                                                                                                           std::io::Error =
                                                                                                                                                                       std::io::Error::new(std::io::ErrorKind::Other, &*v7563);
                                                                                                                                                                   Err(v7570)
                                                                                                                                                               }
                                                                                                                                                           } else {
                                                                                                                                                               let v7591:
                                                                                                                                                                       string =
                                                                                                                                                                   sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                                                                                                                                            v1_1.clone(),
                                                                                                                                                                            v6272,
                                                                                                                                                                            v6237.clone(),
                                                                                                                                                                            v6273.clone());
                                                                                                                                                               let v7598:
                                                                                                                                                                       std::io::Error =
                                                                                                                                                                   std::io::Error::new(std::io::ErrorKind::Other, &*v7591);
                                                                                                                                                               Err(v7598)
                                                                                                                                                           }
                                                                                                                                                       }
                                                                                                                                                   };
                                                                                                                                               let v7621 =
                                                                                                                                                   File_system::method76();
                                                                                                                                               let v7632:
                                                                                                                                                       Result<std::path::PathBuf,
                                                                                                                                                              string> =
                                                                                                                                                   v7620.map_err(|x| v7621(x));
                                                                                                                                               let v7635:
                                                                                                                                                       File_system::US13 =
                                                                                                                                                   match &v7632
                                                                                                                                                       {
                                                                                                                                                       Err(v7632_1_0)
                                                                                                                                                       =>
                                                                                                                                                       v5925(v7632_1_0.clone()),
                                                                                                                                                       Ok(v7632_0_0)
                                                                                                                                                       =>
                                                                                                                                                       v5924(v7632_0_0.clone()),
                                                                                                                                                   };
                                                                                                                                               match &v7635
                                                                                                                                                   {
                                                                                                                                                   File_system::US13::US13_0(v7635_0_0)
                                                                                                                                                   =>
                                                                                                                                                   {
                                                                                                                                                       let v7661:
                                                                                                                                                               string =
                                                                                                                                                           File_system::method56(toString(v7635_0_0.clone().display()),
                                                                                                                                                                                 v6218.clone());
                                                                                                                                                       let v7668:
                                                                                                                                                               &str =
                                                                                                                                                           &*v7661;
                                                                                                                                                       let v7689:
                                                                                                                                                               std::string::String =
                                                                                                                                                           String::from(v7668);
                                                                                                                                                       let v7710:
                                                                                                                                                               std::path::PathBuf =
                                                                                                                                                           std::path::PathBuf::from(v7689);
                                                                                                                                                       Ok(v7710)
                                                                                                                                                   }
                                                                                                                                                   File_system::US13::US13_1(v7635_1_0)
                                                                                                                                                   =>
                                                                                                                                                   {
                                                                                                                                                       let v7739:
                                                                                                                                                               string =
                                                                                                                                                           sprintf!("file_system.read_link / error\': {} / error: {} / name: {}",
                                                                                                                                                                    v7635_1_0.clone(),
                                                                                                                                                                    v6217.clone(),
                                                                                                                                                                    v6218.clone());
                                                                                                                                                       let v7746:
                                                                                                                                                               std::io::Error =
                                                                                                                                                           std::io::Error::new(std::io::ErrorKind::Other, &*v7739);
                                                                                                                                                       Err(v7746)
                                                                                                                                                   }
                                                                                                                                               }
                                                                                                                                           } else {
                                                                                                                                               let v7768:
                                                                                                                                                       string =
                                                                                                                                                   sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                                                                                                                            v1_1.clone(),
                                                                                                                                                            v6217.clone(),
                                                                                                                                                            v6182.clone(),
                                                                                                                                                            v6218.clone());
                                                                                                                                               let v7775:
                                                                                                                                                       std::io::Error =
                                                                                                                                                   std::io::Error::new(std::io::ErrorKind::Other, &*v7768);
                                                                                                                                               Err(v7775)
                                                                                                                                           }
                                                                                                                                       } else {
                                                                                                                                           let v7796:
                                                                                                                                                   string =
                                                                                                                                               sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                                                                                                                        v1_1.clone(),
                                                                                                                                                        v6217,
                                                                                                                                                        v6182.clone(),
                                                                                                                                                        v6218.clone());
                                                                                                                                           let v7803:
                                                                                                                                                   std::io::Error =
                                                                                                                                               std::io::Error::new(std::io::ErrorKind::Other, &*v7796);
                                                                                                                                           Err(v7803)
                                                                                                                                       }
                                                                                                                                   }
                                                                                                                               };
                                                                                                                           let v7826 =
                                                                                                                               File_system::method76();
                                                                                                                           let v7837:
                                                                                                                                   Result<std::path::PathBuf,
                                                                                                                                          string> =
                                                                                                                               v7825.map_err(|x| v7826(x));
                                                                                                                           let v7840:
                                                                                                                                   File_system::US13 =
                                                                                                                               match &v7837
                                                                                                                                   {
                                                                                                                                   Err(v7837_1_0)
                                                                                                                                   =>
                                                                                                                                   v5925(v7837_1_0.clone()),
                                                                                                                                   Ok(v7837_0_0)
                                                                                                                                   =>
                                                                                                                                   v5924(v7837_0_0.clone()),
                                                                                                                               };
                                                                                                                           match &v7840
                                                                                                                               {
                                                                                                                               File_system::US13::US13_0(v7840_0_0)
                                                                                                                               =>
                                                                                                                               {
                                                                                                                                   let v7866:
                                                                                                                                           string =
                                                                                                                                       File_system::method56(toString(v7840_0_0.clone().display()),
                                                                                                                                                             v6163.clone());
                                                                                                                                   let v7873:
                                                                                                                                           &str =
                                                                                                                                       &*v7866;
                                                                                                                                   let v7894:
                                                                                                                                           std::string::String =
                                                                                                                                       String::from(v7873);
                                                                                                                                   let v7915:
                                                                                                                                           std::path::PathBuf =
                                                                                                                                       std::path::PathBuf::from(v7894);
                                                                                                                                   Ok(v7915)
                                                                                                                               }
                                                                                                                               File_system::US13::US13_1(v7840_1_0)
                                                                                                                               =>
                                                                                                                               {
                                                                                                                                   let v7944:
                                                                                                                                           string =
                                                                                                                                       sprintf!("file_system.read_link / error\': {} / error: {} / name: {}",
                                                                                                                                                v7840_1_0.clone(),
                                                                                                                                                v6162.clone(),
                                                                                                                                                v6163.clone());
                                                                                                                                   let v7951:
                                                                                                                                           std::io::Error =
                                                                                                                                       std::io::Error::new(std::io::ErrorKind::Other, &*v7944);
                                                                                                                                   Err(v7951)
                                                                                                                               }
                                                                                                                           }
                                                                                                                       } else {
                                                                                                                           let v7973:
                                                                                                                                   string =
                                                                                                                               sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                                                                                                        v1_1.clone(),
                                                                                                                                        v6162.clone(),
                                                                                                                                        v6127.clone(),
                                                                                                                                        v6163.clone());
                                                                                                                           let v7980:
                                                                                                                                   std::io::Error =
                                                                                                                               std::io::Error::new(std::io::ErrorKind::Other, &*v7973);
                                                                                                                           Err(v7980)
                                                                                                                       }
                                                                                                                   } else {
                                                                                                                       let v8001:
                                                                                                                               string =
                                                                                                                           sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                                                                                                    v1_1.clone(),
                                                                                                                                    v6162,
                                                                                                                                    v6127.clone(),
                                                                                                                                    v6163.clone());
                                                                                                                       let v8008:
                                                                                                                               std::io::Error =
                                                                                                                           std::io::Error::new(std::io::ErrorKind::Other, &*v8001);
                                                                                                                       Err(v8008)
                                                                                                                   }
                                                                                                               }
                                                                                                           };
                                                                                                       let v8031 =
                                                                                                           File_system::method76();
                                                                                                       let v8042:
                                                                                                               Result<std::path::PathBuf,
                                                                                                                      string> =
                                                                                                           v8030.map_err(|x| v8031(x));
                                                                                                       let v8045:
                                                                                                               File_system::US13 =
                                                                                                           match &v8042
                                                                                                               {
                                                                                                               Err(v8042_1_0)
                                                                                                               =>
                                                                                                               v5925(v8042_1_0.clone()),
                                                                                                               Ok(v8042_0_0)
                                                                                                               =>
                                                                                                               v5924(v8042_0_0.clone()),
                                                                                                           };
                                                                                                       match &v8045
                                                                                                           {
                                                                                                           File_system::US13::US13_0(v8045_0_0)
                                                                                                           =>
                                                                                                           {
                                                                                                               let v8071:
                                                                                                                       string =
                                                                                                                   File_system::method56(toString(v8045_0_0.clone().display()),
                                                                                                                                         v6108.clone());
                                                                                                               let v8078:
                                                                                                                       &str =
                                                                                                                   &*v8071;
                                                                                                               let v8099:
                                                                                                                       std::string::String =
                                                                                                                   String::from(v8078);
                                                                                                               let v8120:
                                                                                                                       std::path::PathBuf =
                                                                                                                   std::path::PathBuf::from(v8099);
                                                                                                               Ok(v8120)
                                                                                                           }
                                                                                                           File_system::US13::US13_1(v8045_1_0)
                                                                                                           =>
                                                                                                           {
                                                                                                               let v8149:
                                                                                                                       string =
                                                                                                                   sprintf!("file_system.read_link / error\': {} / error: {} / name: {}",
                                                                                                                            v8045_1_0.clone(),
                                                                                                                            v6107.clone(),
                                                                                                                            v6108.clone());
                                                                                                               let v8156:
                                                                                                                       std::io::Error =
                                                                                                                   std::io::Error::new(std::io::ErrorKind::Other, &*v8149);
                                                                                                               Err(v8156)
                                                                                                           }
                                                                                                       }
                                                                                                   } else {
                                                                                                       let v8178:
                                                                                                               string =
                                                                                                           sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                                                                                    v1_1.clone(),
                                                                                                                    v6107.clone(),
                                                                                                                    v6072.clone(),
                                                                                                                    v6108.clone());
                                                                                                       let v8185:
                                                                                                               std::io::Error =
                                                                                                           std::io::Error::new(std::io::ErrorKind::Other, &*v8178);
                                                                                                       Err(v8185)
                                                                                                   }
                                                                                               } else {
                                                                                                   let v8206:
                                                                                                           string =
                                                                                                       sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                                                                                v1_1.clone(),
                                                                                                                v6107,
                                                                                                                v6072.clone(),
                                                                                                                v6108.clone());
                                                                                                   let v8213:
                                                                                                           std::io::Error =
                                                                                                       std::io::Error::new(std::io::ErrorKind::Other, &*v8206);
                                                                                                   Err(v8213)
                                                                                               }
                                                                                           }
                                                                                       };
                                                                        let v8236 =
                                                                            File_system::method76();
                                                                        let v8247: Result<
                                                                            std::path::PathBuf,
                                                                            string,
                                                                        > = v8235
                                                                            .map_err(|x| v8236(x));
                                                                        let v8250:
                                                                                           File_system::US13 =
                                                                                       match &v8247
                                                                                           {
                                                                                           Err(v8247_1_0)
                                                                                           =>
                                                                                           v5925(v8247_1_0.clone()),
                                                                                           Ok(v8247_0_0)
                                                                                           =>
                                                                                           v5924(v8247_0_0.clone()),
                                                                                       };
                                                                        match &v8250
                                                                                       {
                                                                                       File_system::US13::US13_0(v8250_0_0)
                                                                                       =>
                                                                                       {
                                                                                           let v8276:
                                                                                                   string =
                                                                                               File_system::method56(toString(v8250_0_0.clone().display()),
                                                                                                                     v6053.clone());
                                                                                           let v8283:
                                                                                                   &str =
                                                                                               &*v8276;
                                                                                           let v8304:
                                                                                                   std::string::String =
                                                                                               String::from(v8283);
                                                                                           let v8325:
                                                                                                   std::path::PathBuf =
                                                                                               std::path::PathBuf::from(v8304);
                                                                                           Ok(v8325)
                                                                                       }
                                                                                       File_system::US13::US13_1(v8250_1_0)
                                                                                       =>
                                                                                       {
                                                                                           let v8354:
                                                                                                   string =
                                                                                               sprintf!("file_system.read_link / error\': {} / error: {} / name: {}",
                                                                                                        v8250_1_0.clone(),
                                                                                                        v6052.clone(),
                                                                                                        v6053.clone());
                                                                                           let v8361:
                                                                                                   std::io::Error =
                                                                                               std::io::Error::new(std::io::ErrorKind::Other, &*v8354);
                                                                                           Err(v8361)
                                                                                       }
                                                                                   }
                                                                    } else {
                                                                        let v8383:
                                                                                           string =
                                                                                       sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                                                                v1_1.clone(),
                                                                                                v6052.clone(),
                                                                                                v6017.clone(),
                                                                                                v6053.clone());
                                                                        let v8390:
                                                                                           std::io::Error =
                                                                                       std::io::Error::new(std::io::ErrorKind::Other, &*v8383);
                                                                        Err(v8390)
                                                                    }
                                                                } else {
                                                                    let v8411:
                                                                                       string =
                                                                                   sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                                                            v1_1.clone(),
                                                                                            v6052,
                                                                                            v6017.clone(),
                                                                                            v6053.clone());
                                                                    let v8418:
                                                                                       std::io::Error =
                                                                                   std::io::Error::new(std::io::ErrorKind::Other, &*v8411);
                                                                    Err(v8418)
                                                                }
                                                            }
                                                        };
                                                        let v8441 = File_system::method76();
                                                        let v8452: Result<
                                                            std::path::PathBuf,
                                                            string,
                                                        > = v8440.map_err(|x| v8441(x));
                                                        let v8455: File_system::US13 = match &v8452
                                                        {
                                                            Err(v8452_1_0) => {
                                                                v5925(v8452_1_0.clone())
                                                            }
                                                            Ok(v8452_0_0) => {
                                                                v5924(v8452_0_0.clone())
                                                            }
                                                        };
                                                        match &v8455 {
                                                            File_system::US13::US13_0(
                                                                v8455_0_0,
                                                            ) => {
                                                                let v8481: string =
                                                                    File_system::method56(
                                                                        toString(
                                                                            v8455_0_0
                                                                                .clone()
                                                                                .display(),
                                                                        ),
                                                                        v5998.clone(),
                                                                    );
                                                                let v8488: &str = &*v8481;
                                                                let v8509: std::string::String =
                                                                    String::from(v8488);
                                                                let v8530: std::path::PathBuf =
                                                                    std::path::PathBuf::from(v8509);
                                                                Ok(v8530)
                                                            }
                                                            File_system::US13::US13_1(
                                                                v8455_1_0,
                                                            ) => {
                                                                let v8559:
                                                                               string =
                                                                           sprintf!("file_system.read_link / error\': {} / error: {} / name: {}",
                                                                                    v8455_1_0.clone(),
                                                                                    v5997.clone(),
                                                                                    v5998.clone());
                                                                let v8566: std::io::Error =
                                                                    std::io::Error::new(
                                                                        std::io::ErrorKind::Other,
                                                                        &*v8559,
                                                                    );
                                                                Err(v8566)
                                                            }
                                                        }
                                                    } else {
                                                        let v8588:
                                                                       string =
                                                                   sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                                            v1_1.clone(),
                                                                            v5997.clone(),
                                                                            v5961.clone(),
                                                                            v5998.clone());
                                                        let v8595: std::io::Error =
                                                            std::io::Error::new(
                                                                std::io::ErrorKind::Other,
                                                                &*v8588,
                                                            );
                                                        Err(v8595)
                                                    }
                                                } else {
                                                    let v8616: string =
                                                               sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                                        v1_1.clone(),
                                                                        v5997,
                                                                        v5961.clone(),
                                                                        v5998.clone());
                                                    let v8623: std::io::Error = std::io::Error::new(
                                                        std::io::ErrorKind::Other,
                                                        &*v8616,
                                                    );
                                                    Err(v8623)
                                                }
                                            }
                                        };
                                    let v8646 = File_system::method76();
                                    let v8657: Result<std::path::PathBuf, string> =
                                        v8645.map_err(|x| v8646(x));
                                    let v8660: File_system::US13 = match &v8657 {
                                        Err(v8657_1_0) => v5925(v8657_1_0.clone()),
                                        Ok(v8657_0_0) => v5924(v8657_0_0.clone()),
                                    };
                                    match &v8660 {
                                        File_system::US13::US13_0(v8660_0_0) => {
                                            let v8686: string = File_system::method56(
                                                toString(v8660_0_0.clone().display()),
                                                v5942.clone(),
                                            );
                                            let v8693: &str = &*v8686;
                                            let v8714: std::string::String = String::from(v8693);
                                            let v8735: std::path::PathBuf =
                                                std::path::PathBuf::from(v8714);
                                            Ok(v8735)
                                        }
                                        File_system::US13::US13_1(v8660_1_0) => {
                                            let v8764: string =
                                                       sprintf!("file_system.read_link / error\': {} / error: {} / name: {}",
                                                                v8660_1_0.clone(),
                                                                v5941.clone(),
                                                                v5942.clone());
                                            let v8771: std::io::Error = std::io::Error::new(
                                                std::io::ErrorKind::Other,
                                                &*v8764,
                                            );
                                            Err(v8771)
                                        }
                                    }
                                } else {
                                    let v8793: string =
                                               sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                        v1_1.clone(),
                                                        v5941.clone(),
                                                        v1_1.clone(),
                                                        v5942.clone());
                                    let v8800: std::io::Error =
                                        std::io::Error::new(std::io::ErrorKind::Other, &*v8793);
                                    Err(v8800)
                                }
                            } else {
                                let v8821: string =
                                           sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                                    v1_1.clone(), v5941,
                                                    v1_1.clone(),
                                                    v5942.clone());
                                let v8828: std::io::Error =
                                    std::io::Error::new(std::io::ErrorKind::Other, &*v8821);
                                Err(v8828)
                            }
                        }
                    }
                };
                v8851.is_err()
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
