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
    use fable_library_rust::Seq_::ofList;
    use fable_library_rust::String_::append;
    use fable_library_rust::String_::getCharAt;
    use fable_library_rust::String_::getSlice;
    use fable_library_rust::String_::length;
    use fable_library_rust::String_::ofChar;
    use fable_library_rust::String_::padLeft;
    use fable_library_rust::String_::printfn;
    use fable_library_rust::String_::replace;
    use fable_library_rust::String_::split;
    use fable_library_rust::String_::sprintf;
    use fable_library_rust::String_::startsWith;
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
        let _v1: (File_system::US2, File_system::US3) =
            (File_system::US2::US2_1, File_system::US3::US3_1);
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
        unbox::<bool>(&defaultOf())
    }
    pub fn method6(v0_1: bool, v1_1: string) {
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
        string("(")
    }
    pub fn method12() -> string {
        string(" ")
    }
    pub fn method13() -> string {
        string("")
    }
    pub fn closure9(v0_1: LrcPtr<File_system::Mut4>, v1_1: string, unitVar: ()) {
        let v3: string = append(v0_1.l0.get().clone(), v1_1);
        v0_1.l0.set(v3);
        ()
    }
    pub fn method14() -> string {
        string("\u{001b}[0m")
    }
    pub fn method15(v0_1: string) -> string {
        panic!(
            "{}",
            sprintf!(
                "file_system.get_file_name / target: {} / path: {}",
                File_system::US5::US5_2(File_system::US4::US4_1),
                v0_1
            ),
        )
    }
    pub fn closure10(unitVar: (), unitVar_1: ()) -> string {
        string("file_system.delete_directory_async")
    }
    pub fn closure12(v0_1: string, unitVar: ()) {
        printfn!("{0}", v0_1);
    }
    pub fn closure11(unitVar: (), v0_1: string) {
        let v3: () = {
            File_system::closure12(v0_1, ());
            ()
        };
        ()
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
            let _v170: LrcPtr<MutCell<Option<File_system::US3>>> =
                refCell(None::<File_system::US3>);
            let v175: () = {
                File_system::closure8(
                    patternInput_2.4.clone(),
                    Func1::new({
                        let _v170 = _v170.clone();
                        move |v: Option<File_system::US3>| File_system::closure7(_v170.clone(), v)
                    }),
                    (),
                );
                ()
            };
            let v190: File_system::US3 = defaultValue(File_system::US3::US3_1, _v170.get().clone());
            let v230: DateTime = match &v190 {
                File_system::US3::US3_0(v190_0_0) => {
                    let v204: TimeSpan = TimeSpan::new_ticks(
                        {
                            let _arg: DateTime = DateTime::now();
                            _arg.ticks()
                        } - match &v190 {
                            File_system::US3::US3_0(x) => x.clone(),
                            _ => unreachable!(),
                        },
                    );
                    DateTime::new_ymdhms_milli(
                        1_i32,
                        1_i32,
                        1_i32,
                        v204.hours(),
                        v204.minutes(),
                        v204.seconds(),
                        v204.milliseconds(),
                    )
                }
                _ => DateTime::now(),
            };
            let v235: string = {
                let provider: string = File_system::method9();
                v230.toString(provider)
            };
            let v556: string = File_system::method11();
            let v567: LrcPtr<File_system::Mut4> = LrcPtr::new(File_system::Mut4 {
                l0: MutCell::new(File_system::method13()),
            });
            let v578: () = {
                File_system::closure9(
                    v567.clone(),
                    sprintf!("{}", sprintf!("{:?}", File_system::US0::US0_0)),
                    (),
                );
                ()
            };
            let v582: Array<string> = split(v567.l0.get().clone(), v556, -1_i32, 0_i32);
            let v585: string = v582[0_i32].clone();
            let v589: LrcPtr<File_system::Mut4> = LrcPtr::new(File_system::Mut4 {
                l0: MutCell::new(File_system::method13()),
            });
            let v600: () = {
                File_system::closure9(
                    v589.clone(),
                    sprintf!("{}", sprintf!("{:?}", File_system::US0::US0_1)),
                    (),
                );
                ()
            };
            let v610: File_system::US1 = if startsWith(v589.l0.get().clone(), v585, false) {
                File_system::US1::US1_0(string("Verbose"))
            } else {
                File_system::US1::US1_1
            };
            let v616: File_system::US1 = match &v610 {
                File_system::US1::US1_0(v610_0_0) => File_system::US1::US1_0(match &v610 {
                    File_system::US1::US1_0(x) => x.clone(),
                    _ => unreachable!(),
                }),
                _ => File_system::US1::US1_0(string("Debug")),
            };
            let v625: string = padLeft(
                toLower(match &v616 {
                    File_system::US1::US1_0(v616_0_0) => match &v616 {
                        File_system::US1::US1_0(x) => x.clone(),
                        _ => unreachable!(),
                    },
                    _ => panic!("{}", string("Option does not have a value."),),
                }),
                7_i32,
                ' ',
            );
            let v652: &str = inline_colorization::color_bright_blue;
            let v654: &str = &*v625;
            let v656: &str = inline_colorization::color_reset;
            let v658: string = string("format!(\"{v652}{v654}{v656}\")");
            let v659: std::string::String = format!("{v652}{v654}{v656}");
            let v661: string = fable_library_rust::String_::fromString(v659);
            let v691: i64 = (patternInput_2.0.clone()).l0.get().clone();
            let v692: string = File_system::method15(v0_1);
            let v694: LrcPtr<File_system::Mut4> = LrcPtr::new(File_system::Mut4 {
                l0: MutCell::new(File_system::method13()),
            });
            let v701: () = {
                File_system::closure9(v694.clone(), sprintf!("{}", string("{ ")), ());
                ()
            };
            let v710: () = {
                File_system::closure9(v694.clone(), sprintf!("{}", string("ex")), ());
                ()
            };
            let v719: () = {
                File_system::closure9(v694.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v727: () = {
                File_system::closure9(v694.clone(), sprintf!("{}", v1_1), ());
                ()
            };
            let v736: () = {
                File_system::closure9(v694.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v745: () = {
                File_system::closure9(v694.clone(), sprintf!("{}", string("path")), ());
                ()
            };
            let v753: () = {
                File_system::closure9(v694.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v761: () = {
                File_system::closure9(v694.clone(), sprintf!("{}", v692), ());
                ()
            };
            let v770: () = {
                File_system::closure9(v694.clone(), sprintf!("{}", string(" }")), ());
                ()
            };
            let v773: string = v694.l0.get().clone();
            let v812: string = trimEndChars(
                trimStartChars(
                    sprintf!(
                        "{} {} #{} {} / {}",
                        v235,
                        v661,
                        v691,
                        File_system::closure10((), ()),
                        v773
                    ),
                    toArray(empty::<char>()),
                ),
                toArray(ofArray(new_array(&[' ', '/']))),
            );
            println!("{}", v812.clone());
            ();
            ((patternInput.1.clone()).l0.get().clone())(v812)
        }
    }
    pub fn method5(v0_1: string, v1_1: i64) -> Arc<Async<i64>> {
        defaultOf()
    }
    pub fn closure4(unitVar: (), v0_1: string) -> Arc<Async<i64>> {
        defaultOf()
    }
    pub fn closure16(unitVar: (), unitVar_1: ()) -> string {
        string("file_system.wait_for_file_access")
    }
    pub fn closure15(v0_1: string, v1_1: i64, v2_1: string, unitVar: ()) {
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
            let _v171: LrcPtr<MutCell<Option<File_system::US3>>> =
                refCell(None::<File_system::US3>);
            let v176: () = {
                File_system::closure8(
                    patternInput_2.4.clone(),
                    Func1::new({
                        let _v171 = _v171.clone();
                        move |v: Option<File_system::US3>| File_system::closure7(_v171.clone(), v)
                    }),
                    (),
                );
                ()
            };
            let v191: File_system::US3 = defaultValue(File_system::US3::US3_1, _v171.get().clone());
            let v231: DateTime = match &v191 {
                File_system::US3::US3_0(v191_0_0) => {
                    let v205: TimeSpan = TimeSpan::new_ticks(
                        {
                            let _arg: DateTime = DateTime::now();
                            _arg.ticks()
                        } - match &v191 {
                            File_system::US3::US3_0(x) => x.clone(),
                            _ => unreachable!(),
                        },
                    );
                    DateTime::new_ymdhms_milli(
                        1_i32,
                        1_i32,
                        1_i32,
                        v205.hours(),
                        v205.minutes(),
                        v205.seconds(),
                        v205.milliseconds(),
                    )
                }
                _ => DateTime::now(),
            };
            let v236: string = {
                let provider: string = File_system::method9();
                v231.toString(provider)
            };
            let v557: string = File_system::method11();
            let v568: LrcPtr<File_system::Mut4> = LrcPtr::new(File_system::Mut4 {
                l0: MutCell::new(File_system::method13()),
            });
            let v579: () = {
                File_system::closure9(
                    v568.clone(),
                    sprintf!("{}", sprintf!("{:?}", File_system::US0::US0_0)),
                    (),
                );
                ()
            };
            let v583: Array<string> = split(v568.l0.get().clone(), v557, -1_i32, 0_i32);
            let v586: string = v583[0_i32].clone();
            let v590: LrcPtr<File_system::Mut4> = LrcPtr::new(File_system::Mut4 {
                l0: MutCell::new(File_system::method13()),
            });
            let v601: () = {
                File_system::closure9(
                    v590.clone(),
                    sprintf!("{}", sprintf!("{:?}", File_system::US0::US0_1)),
                    (),
                );
                ()
            };
            let v611: File_system::US1 = if startsWith(v590.l0.get().clone(), v586, false) {
                File_system::US1::US1_0(string("Verbose"))
            } else {
                File_system::US1::US1_1
            };
            let v617: File_system::US1 = match &v611 {
                File_system::US1::US1_0(v611_0_0) => File_system::US1::US1_0(match &v611 {
                    File_system::US1::US1_0(x) => x.clone(),
                    _ => unreachable!(),
                }),
                _ => File_system::US1::US1_0(string("Debug")),
            };
            let v626: string = padLeft(
                toLower(match &v617 {
                    File_system::US1::US1_0(v617_0_0) => match &v617 {
                        File_system::US1::US1_0(x) => x.clone(),
                        _ => unreachable!(),
                    },
                    _ => panic!("{}", string("Option does not have a value."),),
                }),
                7_i32,
                ' ',
            );
            let v653: &str = inline_colorization::color_bright_blue;
            let v655: &str = &*v626;
            let v657: &str = inline_colorization::color_reset;
            let v659: string = string("format!(\"{v653}{v655}{v657}\")");
            let v660: std::string::String = format!("{v653}{v655}{v657}");
            let v662: string = fable_library_rust::String_::fromString(v660);
            let v692: i64 = (patternInput_2.0.clone()).l0.get().clone();
            let v693: string = File_system::method15(v0_1);
            let v695: LrcPtr<File_system::Mut4> = LrcPtr::new(File_system::Mut4 {
                l0: MutCell::new(File_system::method13()),
            });
            let v702: () = {
                File_system::closure9(v695.clone(), sprintf!("{}", string("{ ")), ());
                ()
            };
            let v711: () = {
                File_system::closure9(v695.clone(), sprintf!("{}", string("path")), ());
                ()
            };
            let v720: () = {
                File_system::closure9(v695.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v728: () = {
                File_system::closure9(v695.clone(), sprintf!("{}", v693), ());
                ()
            };
            let v737: () = {
                File_system::closure9(v695.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v746: () = {
                File_system::closure9(v695.clone(), sprintf!("{}", string("retry")), ());
                ()
            };
            let v754: () = {
                File_system::closure9(v695.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v762: () = {
                File_system::closure9(v695.clone(), sprintf!("{}", v1_1), ());
                ()
            };
            let v770: () = {
                File_system::closure9(v695.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v779: () = {
                File_system::closure9(v695.clone(), sprintf!("{}", string("ex")), ());
                ()
            };
            let v787: () = {
                File_system::closure9(v695.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v795: () = {
                File_system::closure9(v695.clone(), sprintf!("{}", v2_1), ());
                ()
            };
            let v804: () = {
                File_system::closure9(v695.clone(), sprintf!("{}", string(" }")), ());
                ()
            };
            let v807: string = v695.l0.get().clone();
            let v846: string = trimEndChars(
                trimStartChars(
                    sprintf!(
                        "{} {} #{} {} / {}",
                        v236,
                        v662,
                        v692,
                        File_system::closure16((), ()),
                        v807
                    ),
                    toArray(empty::<char>()),
                ),
                toArray(ofArray(new_array(&[' ', '/']))),
            );
            println!("{}", v846.clone());
            ();
            ((patternInput.1.clone()).l0.get().clone())(v846)
        }
    }
    pub fn method16(
        v0_1: string,
        v1_1: File_system::US8,
        v2_1: File_system::US7,
        v3: i64,
    ) -> Arc<Async<i64>> {
        defaultOf()
    }
    pub fn closure14(v0_1: File_system::US6, v1_1: string) -> Arc<Async<i64>> {
        defaultOf()
    }
    pub fn closure13(unitVar: (), v0_1: File_system::US6) -> Func1<string, Arc<Async<i64>>> {
        Func1::new({
            let v0_1 = v0_1.clone();
            move |v: string| File_system::closure14(v0_1.clone(), v)
        })
    }
    pub fn method17(v0_1: string, v1_1: i64) -> Arc<Async<i64>> {
        defaultOf()
    }
    pub fn closure17(unitVar: (), v0_1: string) -> Arc<Async<i64>> {
        defaultOf()
    }
    pub fn closure18(unitVar: (), v0_1: string) -> Arc<Async<string>> {
        defaultOf()
    }
    pub fn method19(v0_1: string) -> bool {
        unbox::<bool>(&defaultOf())
    }
    pub fn method20(v0_1: Vec<u8>) -> Vec<u8> {
        v0_1
    }
    pub fn method18(v0_1: string, v1_1: string) -> bool {
        unbox::<bool>(&defaultOf())
    }
    pub fn closure20(v0_1: string, v1_1: string) -> bool {
        File_system::method18(v0_1, v1_1)
    }
    pub fn closure19(unitVar: (), v0_1: string) -> Func1<string, bool> {
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
    pub fn closure24(v0_1: string, v1_1: string) -> Arc<Async<()>> {
        defaultOf()
    }
    pub fn closure23(unitVar: (), v0_1: string) -> Func1<string, Arc<Async<()>>> {
        Func1::new({
            let v0_1 = v0_1.clone();
            move |v: string| File_system::closure24(v0_1.clone(), v)
        })
    }
    pub fn closure27(unitVar: (), unitVar_1: ()) -> string {
        string("delete_file_async")
    }
    pub fn closure26(v0_1: string, v1_1: LrcPtr<Exception>, unitVar: ()) {
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
            let _v170: LrcPtr<MutCell<Option<File_system::US3>>> =
                refCell(None::<File_system::US3>);
            let v175: () = {
                File_system::closure8(
                    patternInput_2.4.clone(),
                    Func1::new({
                        let _v170 = _v170.clone();
                        move |v: Option<File_system::US3>| File_system::closure7(_v170.clone(), v)
                    }),
                    (),
                );
                ()
            };
            let v190: File_system::US3 = defaultValue(File_system::US3::US3_1, _v170.get().clone());
            let v230: DateTime = match &v190 {
                File_system::US3::US3_0(v190_0_0) => {
                    let v204: TimeSpan = TimeSpan::new_ticks(
                        {
                            let _arg: DateTime = DateTime::now();
                            _arg.ticks()
                        } - match &v190 {
                            File_system::US3::US3_0(x) => x.clone(),
                            _ => unreachable!(),
                        },
                    );
                    DateTime::new_ymdhms_milli(
                        1_i32,
                        1_i32,
                        1_i32,
                        v204.hours(),
                        v204.minutes(),
                        v204.seconds(),
                        v204.milliseconds(),
                    )
                }
                _ => DateTime::now(),
            };
            let v235: string = {
                let provider: string = File_system::method9();
                v230.toString(provider)
            };
            let v556: string = File_system::method11();
            let v567: LrcPtr<File_system::Mut4> = LrcPtr::new(File_system::Mut4 {
                l0: MutCell::new(File_system::method13()),
            });
            let v578: () = {
                File_system::closure9(
                    v567.clone(),
                    sprintf!("{}", sprintf!("{:?}", File_system::US0::US0_0)),
                    (),
                );
                ()
            };
            let v582: Array<string> = split(v567.l0.get().clone(), v556, -1_i32, 0_i32);
            let v585: string = v582[0_i32].clone();
            let v589: LrcPtr<File_system::Mut4> = LrcPtr::new(File_system::Mut4 {
                l0: MutCell::new(File_system::method13()),
            });
            let v600: () = {
                File_system::closure9(
                    v589.clone(),
                    sprintf!("{}", sprintf!("{:?}", File_system::US0::US0_3)),
                    (),
                );
                ()
            };
            let v610: File_system::US1 = if startsWith(v589.l0.get().clone(), v585, false) {
                File_system::US1::US1_0(string("Verbose"))
            } else {
                File_system::US1::US1_1
            };
            let v738: File_system::US1 = match &v610 {
                File_system::US1::US1_0(v610_0_0) => File_system::US1::US1_0(match &v610 {
                    File_system::US1::US1_0(x) => x.clone(),
                    _ => unreachable!(),
                }),
                _ => {
                    let v615: string = File_system::method11();
                    let v626: LrcPtr<File_system::Mut4> = LrcPtr::new(File_system::Mut4 {
                        l0: MutCell::new(File_system::method13()),
                    });
                    let v637: () = {
                        File_system::closure9(
                            v626.clone(),
                            sprintf!("{}", sprintf!("{:?}", File_system::US0::US0_1)),
                            (),
                        );
                        ()
                    };
                    let v641: Array<string> = split(v626.l0.get().clone(), v615, -1_i32, 0_i32);
                    let v644: string = v641[0_i32].clone();
                    let v648: LrcPtr<File_system::Mut4> = LrcPtr::new(File_system::Mut4 {
                        l0: MutCell::new(File_system::method13()),
                    });
                    let v659: () = {
                        File_system::closure9(
                            v648.clone(),
                            sprintf!("{}", sprintf!("{:?}", File_system::US0::US0_3)),
                            (),
                        );
                        ()
                    };
                    let v669: File_system::US1 = if startsWith(v648.l0.get().clone(), v644, false) {
                        File_system::US1::US1_0(string("Debug"))
                    } else {
                        File_system::US1::US1_1
                    };
                    match &v669 {
                        File_system::US1::US1_0(v669_0_0) => File_system::US1::US1_0(match &v669 {
                            File_system::US1::US1_0(x) => x.clone(),
                            _ => unreachable!(),
                        }),
                        _ => {
                            let v674: string = File_system::method11();
                            let v685: LrcPtr<File_system::Mut4> = LrcPtr::new(File_system::Mut4 {
                                l0: MutCell::new(File_system::method13()),
                            });
                            let v696: () = {
                                File_system::closure9(
                                    v685.clone(),
                                    sprintf!("{}", sprintf!("{:?}", File_system::US0::US0_2)),
                                    (),
                                );
                                ()
                            };
                            let v700: Array<string> =
                                split(v685.l0.get().clone(), v674, -1_i32, 0_i32);
                            let v703: string = v700[0_i32].clone();
                            let v707: LrcPtr<File_system::Mut4> = LrcPtr::new(File_system::Mut4 {
                                l0: MutCell::new(File_system::method13()),
                            });
                            let v718: () = {
                                File_system::closure9(
                                    v707.clone(),
                                    sprintf!("{}", sprintf!("{:?}", File_system::US0::US0_3)),
                                    (),
                                );
                                ()
                            };
                            let v728: File_system::US1 =
                                if startsWith(v707.l0.get().clone(), v703, false) {
                                    File_system::US1::US1_0(string("Info"))
                                } else {
                                    File_system::US1::US1_1
                                };
                            match &v728 {
                                File_system::US1::US1_0(v728_0_0) => {
                                    File_system::US1::US1_0(match &v728 {
                                        File_system::US1::US1_0(x) => x.clone(),
                                        _ => unreachable!(),
                                    })
                                }
                                _ => File_system::US1::US1_0(string("Warning")),
                            }
                        }
                    }
                }
            };
            let v747: string = padLeft(
                toLower(match &v738 {
                    File_system::US1::US1_0(v738_0_0) => match &v738 {
                        File_system::US1::US1_0(x) => x.clone(),
                        _ => unreachable!(),
                    },
                    _ => panic!("{}", string("Option does not have a value."),),
                }),
                7_i32,
                ' ',
            );
            let v774: &str = inline_colorization::color_yellow;
            let v776: &str = &*v747;
            let v778: &str = inline_colorization::color_reset;
            let v780: string = string("format!(\"{v774}{v776}{v778}\")");
            let v781: std::string::String = format!("{v774}{v776}{v778}");
            let v783: string = fable_library_rust::String_::fromString(v781);
            let v813: i64 = (patternInput_2.0.clone()).l0.get().clone();
            let v814: string = File_system::method15(v0_1);
            let v819: string = sprintf!("{:?}", v1_1);
            let v838: LrcPtr<File_system::Mut4> = LrcPtr::new(File_system::Mut4 {
                l0: MutCell::new(File_system::method13()),
            });
            let v845: () = {
                File_system::closure9(v838.clone(), sprintf!("{}", string("{ ")), ());
                ()
            };
            let v854: () = {
                File_system::closure9(v838.clone(), sprintf!("{}", string("path")), ());
                ()
            };
            let v863: () = {
                File_system::closure9(v838.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v871: () = {
                File_system::closure9(v838.clone(), sprintf!("{}", v814), ());
                ()
            };
            let v880: () = {
                File_system::closure9(v838.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v889: () = {
                File_system::closure9(v838.clone(), sprintf!("{}", string("ex")), ());
                ()
            };
            let v897: () = {
                File_system::closure9(v838.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v905: () = {
                File_system::closure9(v838.clone(), sprintf!("{}", v819), ());
                ()
            };
            let v914: () = {
                File_system::closure9(v838.clone(), sprintf!("{}", string(" }")), ());
                ()
            };
            let v917: string = v838.l0.get().clone();
            let v956: string = trimEndChars(
                trimStartChars(
                    sprintf!(
                        "{} {} #{} {} / {}",
                        v235,
                        v783,
                        v813,
                        File_system::closure27((), ()),
                        v917
                    ),
                    toArray(empty::<char>()),
                ),
                toArray(ofArray(new_array(&[' ', '/']))),
            );
            println!("{}", v956.clone());
            ();
            ((patternInput.1.clone()).l0.get().clone())(v956)
        }
    }
    pub fn method21(v0_1: string, v1_1: i64) -> Arc<Async<i64>> {
        defaultOf()
    }
    pub fn closure25(unitVar: (), v0_1: string) -> Arc<Async<i64>> {
        defaultOf()
    }
    pub fn closure31(unitVar: (), unitVar_1: ()) -> string {
        string("move_file_async")
    }
    pub fn closure30(v0_1: string, v1_1: string, v2_1: LrcPtr<Exception>, unitVar: ()) {
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
            let _v171: LrcPtr<MutCell<Option<File_system::US3>>> =
                refCell(None::<File_system::US3>);
            let v176: () = {
                File_system::closure8(
                    patternInput_2.4.clone(),
                    Func1::new({
                        let _v171 = _v171.clone();
                        move |v: Option<File_system::US3>| File_system::closure7(_v171.clone(), v)
                    }),
                    (),
                );
                ()
            };
            let v191: File_system::US3 = defaultValue(File_system::US3::US3_1, _v171.get().clone());
            let v231: DateTime = match &v191 {
                File_system::US3::US3_0(v191_0_0) => {
                    let v205: TimeSpan = TimeSpan::new_ticks(
                        {
                            let _arg: DateTime = DateTime::now();
                            _arg.ticks()
                        } - match &v191 {
                            File_system::US3::US3_0(x) => x.clone(),
                            _ => unreachable!(),
                        },
                    );
                    DateTime::new_ymdhms_milli(
                        1_i32,
                        1_i32,
                        1_i32,
                        v205.hours(),
                        v205.minutes(),
                        v205.seconds(),
                        v205.milliseconds(),
                    )
                }
                _ => DateTime::now(),
            };
            let v236: string = {
                let provider: string = File_system::method9();
                v231.toString(provider)
            };
            let v557: string = File_system::method11();
            let v568: LrcPtr<File_system::Mut4> = LrcPtr::new(File_system::Mut4 {
                l0: MutCell::new(File_system::method13()),
            });
            let v579: () = {
                File_system::closure9(
                    v568.clone(),
                    sprintf!("{}", sprintf!("{:?}", File_system::US0::US0_0)),
                    (),
                );
                ()
            };
            let v583: Array<string> = split(v568.l0.get().clone(), v557, -1_i32, 0_i32);
            let v586: string = v583[0_i32].clone();
            let v590: LrcPtr<File_system::Mut4> = LrcPtr::new(File_system::Mut4 {
                l0: MutCell::new(File_system::method13()),
            });
            let v601: () = {
                File_system::closure9(
                    v590.clone(),
                    sprintf!("{}", sprintf!("{:?}", File_system::US0::US0_3)),
                    (),
                );
                ()
            };
            let v611: File_system::US1 = if startsWith(v590.l0.get().clone(), v586, false) {
                File_system::US1::US1_0(string("Verbose"))
            } else {
                File_system::US1::US1_1
            };
            let v739: File_system::US1 = match &v611 {
                File_system::US1::US1_0(v611_0_0) => File_system::US1::US1_0(match &v611 {
                    File_system::US1::US1_0(x) => x.clone(),
                    _ => unreachable!(),
                }),
                _ => {
                    let v616: string = File_system::method11();
                    let v627: LrcPtr<File_system::Mut4> = LrcPtr::new(File_system::Mut4 {
                        l0: MutCell::new(File_system::method13()),
                    });
                    let v638: () = {
                        File_system::closure9(
                            v627.clone(),
                            sprintf!("{}", sprintf!("{:?}", File_system::US0::US0_1)),
                            (),
                        );
                        ()
                    };
                    let v642: Array<string> = split(v627.l0.get().clone(), v616, -1_i32, 0_i32);
                    let v645: string = v642[0_i32].clone();
                    let v649: LrcPtr<File_system::Mut4> = LrcPtr::new(File_system::Mut4 {
                        l0: MutCell::new(File_system::method13()),
                    });
                    let v660: () = {
                        File_system::closure9(
                            v649.clone(),
                            sprintf!("{}", sprintf!("{:?}", File_system::US0::US0_3)),
                            (),
                        );
                        ()
                    };
                    let v670: File_system::US1 = if startsWith(v649.l0.get().clone(), v645, false) {
                        File_system::US1::US1_0(string("Debug"))
                    } else {
                        File_system::US1::US1_1
                    };
                    match &v670 {
                        File_system::US1::US1_0(v670_0_0) => File_system::US1::US1_0(match &v670 {
                            File_system::US1::US1_0(x) => x.clone(),
                            _ => unreachable!(),
                        }),
                        _ => {
                            let v675: string = File_system::method11();
                            let v686: LrcPtr<File_system::Mut4> = LrcPtr::new(File_system::Mut4 {
                                l0: MutCell::new(File_system::method13()),
                            });
                            let v697: () = {
                                File_system::closure9(
                                    v686.clone(),
                                    sprintf!("{}", sprintf!("{:?}", File_system::US0::US0_2)),
                                    (),
                                );
                                ()
                            };
                            let v701: Array<string> =
                                split(v686.l0.get().clone(), v675, -1_i32, 0_i32);
                            let v704: string = v701[0_i32].clone();
                            let v708: LrcPtr<File_system::Mut4> = LrcPtr::new(File_system::Mut4 {
                                l0: MutCell::new(File_system::method13()),
                            });
                            let v719: () = {
                                File_system::closure9(
                                    v708.clone(),
                                    sprintf!("{}", sprintf!("{:?}", File_system::US0::US0_3)),
                                    (),
                                );
                                ()
                            };
                            let v729: File_system::US1 =
                                if startsWith(v708.l0.get().clone(), v704, false) {
                                    File_system::US1::US1_0(string("Info"))
                                } else {
                                    File_system::US1::US1_1
                                };
                            match &v729 {
                                File_system::US1::US1_0(v729_0_0) => {
                                    File_system::US1::US1_0(match &v729 {
                                        File_system::US1::US1_0(x) => x.clone(),
                                        _ => unreachable!(),
                                    })
                                }
                                _ => File_system::US1::US1_0(string("Warning")),
                            }
                        }
                    }
                }
            };
            let v748: string = padLeft(
                toLower(match &v739 {
                    File_system::US1::US1_0(v739_0_0) => match &v739 {
                        File_system::US1::US1_0(x) => x.clone(),
                        _ => unreachable!(),
                    },
                    _ => panic!("{}", string("Option does not have a value."),),
                }),
                7_i32,
                ' ',
            );
            let v775: &str = inline_colorization::color_yellow;
            let v777: &str = &*v748;
            let v779: &str = inline_colorization::color_reset;
            let v781: string = string("format!(\"{v775}{v777}{v779}\")");
            let v782: std::string::String = format!("{v775}{v777}{v779}");
            let v784: string = fable_library_rust::String_::fromString(v782);
            let v814: i64 = (patternInput_2.0.clone()).l0.get().clone();
            let v815: string = File_system::method15(v1_1);
            let v816: string = File_system::method15(v0_1);
            let v818: LrcPtr<File_system::Mut4> = LrcPtr::new(File_system::Mut4 {
                l0: MutCell::new(File_system::method13()),
            });
            let v825: () = {
                File_system::closure9(v818.clone(), sprintf!("{}", string("{ ")), ());
                ()
            };
            let v834: () = {
                File_system::closure9(v818.clone(), sprintf!("{}", string("old_path")), ());
                ()
            };
            let v843: () = {
                File_system::closure9(v818.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v851: () = {
                File_system::closure9(v818.clone(), sprintf!("{}", v815), ());
                ()
            };
            let v860: () = {
                File_system::closure9(v818.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v869: () = {
                File_system::closure9(v818.clone(), sprintf!("{}", string("new_path")), ());
                ()
            };
            let v877: () = {
                File_system::closure9(v818.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v885: () = {
                File_system::closure9(v818.clone(), sprintf!("{}", v816), ());
                ()
            };
            let v893: () = {
                File_system::closure9(v818.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v902: () = {
                File_system::closure9(v818.clone(), sprintf!("{}", string("ex")), ());
                ()
            };
            let v910: () = {
                File_system::closure9(v818.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v919: std::string::String = format!("{:#?}", v2_1);
            let v945: () = {
                File_system::closure9(
                    v818.clone(),
                    sprintf!("{}", fable_library_rust::String_::fromString(v919)),
                    (),
                );
                ()
            };
            let v954: () = {
                File_system::closure9(v818.clone(), sprintf!("{}", string(" }")), ());
                ()
            };
            let v957: string = v818.l0.get().clone();
            let v996: string = trimEndChars(
                trimStartChars(
                    sprintf!(
                        "{} {} #{} {} / {}",
                        v236,
                        v784,
                        v814,
                        File_system::closure31((), ()),
                        v957
                    ),
                    toArray(empty::<char>()),
                ),
                toArray(ofArray(new_array(&[' ', '/']))),
            );
            println!("{}", v996.clone());
            ();
            ((patternInput.1.clone()).l0.get().clone())(v996)
        }
    }
    pub fn method22(v0_1: string, v1_1: string, v2_1: i64) -> Arc<Async<i64>> {
        defaultOf()
    }
    pub fn closure29(v0_1: string, v1_1: string) -> Arc<Async<i64>> {
        defaultOf()
    }
    pub fn closure28(unitVar: (), v0_1: string) -> Func1<string, Arc<Async<i64>>> {
        Func1::new({
            let v0_1 = v0_1.clone();
            move |v: string| File_system::closure29(v0_1.clone(), v)
        })
    }
    pub fn closure33(unitVar: (), v0_1: i64) -> File_system::US9 {
        File_system::US9::US9_0(v0_1)
    }
    pub fn closure34(unitVar: (), v0_1: LrcPtr<Exception>) -> File_system::US9 {
        File_system::US9::US9_1(v0_1)
    }
    pub fn closure36(unitVar: (), unitVar_1: ()) -> string {
        string("async.run_with_timeout_async")
    }
    pub fn closure35(unitVar: (), unitVar_1: ()) {
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
            let _v168: LrcPtr<MutCell<Option<File_system::US3>>> =
                refCell(None::<File_system::US3>);
            let v173: () = {
                File_system::closure8(
                    patternInput_2.4.clone(),
                    Func1::new({
                        let _v168 = _v168.clone();
                        move |v: Option<File_system::US3>| File_system::closure7(_v168.clone(), v)
                    }),
                    (),
                );
                ()
            };
            let v188: File_system::US3 = defaultValue(File_system::US3::US3_1, _v168.get().clone());
            let v228: DateTime = match &v188 {
                File_system::US3::US3_0(v188_0_0) => {
                    let v202: TimeSpan = TimeSpan::new_ticks(
                        {
                            let _arg: DateTime = DateTime::now();
                            _arg.ticks()
                        } - match &v188 {
                            File_system::US3::US3_0(x) => x.clone(),
                            _ => unreachable!(),
                        },
                    );
                    DateTime::new_ymdhms_milli(
                        1_i32,
                        1_i32,
                        1_i32,
                        v202.hours(),
                        v202.minutes(),
                        v202.seconds(),
                        v202.milliseconds(),
                    )
                }
                _ => DateTime::now(),
            };
            let v233: string = {
                let provider: string = File_system::method9();
                v228.toString(provider)
            };
            let v557: string = padLeft(toLower(string("Verbose")), 7_i32, ' ');
            let v584: &str = inline_colorization::color_bright_black;
            let v586: &str = &*v557;
            let v588: &str = inline_colorization::color_reset;
            let v590: string = string("format!(\"{v584}{v586}{v588}\")");
            let v591: std::string::String = format!("{v584}{v586}{v588}");
            let v593: string = fable_library_rust::String_::fromString(v591);
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
                        v233,
                        v593,
                        v623,
                        File_system::closure36((), ()),
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
    pub fn closure38(unitVar: (), unitVar_1: ()) -> string {
        string("async.run_with_timeout_async**")
    }
    pub fn closure37(v0_1: LrcPtr<Exception>, unitVar: ()) {
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
            let _v169: LrcPtr<MutCell<Option<File_system::US3>>> =
                refCell(None::<File_system::US3>);
            let v174: () = {
                File_system::closure8(
                    patternInput_2.4.clone(),
                    Func1::new({
                        let _v169 = _v169.clone();
                        move |v: Option<File_system::US3>| File_system::closure7(_v169.clone(), v)
                    }),
                    (),
                );
                ()
            };
            let v189: File_system::US3 = defaultValue(File_system::US3::US3_1, _v169.get().clone());
            let v229: DateTime = match &v189 {
                File_system::US3::US3_0(v189_0_0) => {
                    let v203: TimeSpan = TimeSpan::new_ticks(
                        {
                            let _arg: DateTime = DateTime::now();
                            _arg.ticks()
                        } - match &v189 {
                            File_system::US3::US3_0(x) => x.clone(),
                            _ => unreachable!(),
                        },
                    );
                    DateTime::new_ymdhms_milli(
                        1_i32,
                        1_i32,
                        1_i32,
                        v203.hours(),
                        v203.minutes(),
                        v203.seconds(),
                        v203.milliseconds(),
                    )
                }
                _ => DateTime::now(),
            };
            let v234: string = {
                let provider: string = File_system::method9();
                v229.toString(provider)
            };
            let v555: string = File_system::method11();
            let v566: LrcPtr<File_system::Mut4> = LrcPtr::new(File_system::Mut4 {
                l0: MutCell::new(File_system::method13()),
            });
            let v577: () = {
                File_system::closure9(
                    v566.clone(),
                    sprintf!("{}", sprintf!("{:?}", File_system::US0::US0_0)),
                    (),
                );
                ()
            };
            let v581: Array<string> = split(v566.l0.get().clone(), v555, -1_i32, 0_i32);
            let v584: string = v581[0_i32].clone();
            let v588: LrcPtr<File_system::Mut4> = LrcPtr::new(File_system::Mut4 {
                l0: MutCell::new(File_system::method13()),
            });
            let v599: () = {
                File_system::closure9(
                    v588.clone(),
                    sprintf!("{}", sprintf!("{:?}", File_system::US0::US0_4)),
                    (),
                );
                ()
            };
            let v609: File_system::US1 = if startsWith(v588.l0.get().clone(), v584, false) {
                File_system::US1::US1_0(string("Verbose"))
            } else {
                File_system::US1::US1_1
            };
            let v798: File_system::US1 = match &v609 {
                File_system::US1::US1_0(v609_0_0) => File_system::US1::US1_0(match &v609 {
                    File_system::US1::US1_0(x) => x.clone(),
                    _ => unreachable!(),
                }),
                _ => {
                    let v614: string = File_system::method11();
                    let v625: LrcPtr<File_system::Mut4> = LrcPtr::new(File_system::Mut4 {
                        l0: MutCell::new(File_system::method13()),
                    });
                    let v636: () = {
                        File_system::closure9(
                            v625.clone(),
                            sprintf!("{}", sprintf!("{:?}", File_system::US0::US0_1)),
                            (),
                        );
                        ()
                    };
                    let v640: Array<string> = split(v625.l0.get().clone(), v614, -1_i32, 0_i32);
                    let v643: string = v640[0_i32].clone();
                    let v647: LrcPtr<File_system::Mut4> = LrcPtr::new(File_system::Mut4 {
                        l0: MutCell::new(File_system::method13()),
                    });
                    let v658: () = {
                        File_system::closure9(
                            v647.clone(),
                            sprintf!("{}", sprintf!("{:?}", File_system::US0::US0_4)),
                            (),
                        );
                        ()
                    };
                    let v668: File_system::US1 = if startsWith(v647.l0.get().clone(), v643, false) {
                        File_system::US1::US1_0(string("Debug"))
                    } else {
                        File_system::US1::US1_1
                    };
                    match &v668 {
                        File_system::US1::US1_0(v668_0_0) => File_system::US1::US1_0(match &v668 {
                            File_system::US1::US1_0(x) => x.clone(),
                            _ => unreachable!(),
                        }),
                        _ => {
                            let v673: string = File_system::method11();
                            let v684: LrcPtr<File_system::Mut4> = LrcPtr::new(File_system::Mut4 {
                                l0: MutCell::new(File_system::method13()),
                            });
                            let v695: () = {
                                File_system::closure9(
                                    v684.clone(),
                                    sprintf!("{}", sprintf!("{:?}", File_system::US0::US0_2)),
                                    (),
                                );
                                ()
                            };
                            let v699: Array<string> =
                                split(v684.l0.get().clone(), v673, -1_i32, 0_i32);
                            let v702: string = v699[0_i32].clone();
                            let v706: LrcPtr<File_system::Mut4> = LrcPtr::new(File_system::Mut4 {
                                l0: MutCell::new(File_system::method13()),
                            });
                            let v717: () = {
                                File_system::closure9(
                                    v706.clone(),
                                    sprintf!("{}", sprintf!("{:?}", File_system::US0::US0_4)),
                                    (),
                                );
                                ()
                            };
                            let v727: File_system::US1 =
                                if startsWith(v706.l0.get().clone(), v702, false) {
                                    File_system::US1::US1_0(string("Info"))
                                } else {
                                    File_system::US1::US1_1
                                };
                            match &v727 {
                                File_system::US1::US1_0(v727_0_0) => {
                                    File_system::US1::US1_0(match &v727 {
                                        File_system::US1::US1_0(x) => x.clone(),
                                        _ => unreachable!(),
                                    })
                                }
                                _ => {
                                    let v732: string = File_system::method11();
                                    let v743: LrcPtr<File_system::Mut4> =
                                        LrcPtr::new(File_system::Mut4 {
                                            l0: MutCell::new(File_system::method13()),
                                        });
                                    let v754: () = {
                                        File_system::closure9(
                                            v743.clone(),
                                            sprintf!(
                                                "{}",
                                                sprintf!("{:?}", File_system::US0::US0_3)
                                            ),
                                            (),
                                        );
                                        ()
                                    };
                                    let v758: Array<string> =
                                        split(v743.l0.get().clone(), v732, -1_i32, 0_i32);
                                    let v761: string = v758[0_i32].clone();
                                    let v765: LrcPtr<File_system::Mut4> =
                                        LrcPtr::new(File_system::Mut4 {
                                            l0: MutCell::new(File_system::method13()),
                                        });
                                    let v776: () = {
                                        File_system::closure9(
                                            v765.clone(),
                                            sprintf!(
                                                "{}",
                                                sprintf!("{:?}", File_system::US0::US0_4)
                                            ),
                                            (),
                                        );
                                        ()
                                    };
                                    let v786: File_system::US1 =
                                        if startsWith(v765.l0.get().clone(), v761, false) {
                                            File_system::US1::US1_0(string("Warning"))
                                        } else {
                                            File_system::US1::US1_1
                                        };
                                    match &v786 {
                                        File_system::US1::US1_0(v786_0_0) => {
                                            File_system::US1::US1_0(match &v786 {
                                                File_system::US1::US1_0(x) => x.clone(),
                                                _ => unreachable!(),
                                            })
                                        }
                                        _ => File_system::US1::US1_0(string("Critical")),
                                    }
                                }
                            }
                        }
                    }
                }
            };
            let v807: string = padLeft(
                toLower(match &v798 {
                    File_system::US1::US1_0(v798_0_0) => match &v798 {
                        File_system::US1::US1_0(x) => x.clone(),
                        _ => unreachable!(),
                    },
                    _ => panic!("{}", string("Option does not have a value."),),
                }),
                7_i32,
                ' ',
            );
            let v834: &str = inline_colorization::color_bright_red;
            let v836: &str = &*v807;
            let v838: &str = inline_colorization::color_reset;
            let v840: string = string("format!(\"{v834}{v836}{v838}\")");
            let v841: std::string::String = format!("{v834}{v836}{v838}");
            let v843: string = fable_library_rust::String_::fromString(v841);
            let v873: i64 = (patternInput_2.0.clone()).l0.get().clone();
            let v878: string = sprintf!("{:?}", v0_1);
            let v897: LrcPtr<File_system::Mut4> = LrcPtr::new(File_system::Mut4 {
                l0: MutCell::new(File_system::method13()),
            });
            let v904: () = {
                File_system::closure9(v897.clone(), sprintf!("{}", string("{ ")), ());
                ()
            };
            let v913: () = {
                File_system::closure9(v897.clone(), sprintf!("{}", string("timeout")), ());
                ()
            };
            let v922: () = {
                File_system::closure9(v897.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v930: () = {
                File_system::closure9(v897.clone(), sprintf!("{}", 1000_i32), ());
                ()
            };
            let v939: () = {
                File_system::closure9(v897.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v948: () = {
                File_system::closure9(v897.clone(), sprintf!("{}", string("ex")), ());
                ()
            };
            let v956: () = {
                File_system::closure9(v897.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v964: () = {
                File_system::closure9(v897.clone(), sprintf!("{}", v878), ());
                ()
            };
            let v973: () = {
                File_system::closure9(v897.clone(), sprintf!("{}", string(" }")), ());
                ()
            };
            let v976: string = v897.l0.get().clone();
            let v1015: string = trimEndChars(
                trimStartChars(
                    sprintf!(
                        "{} {} #{} {} / {}",
                        v234,
                        v843,
                        v873,
                        File_system::closure38((), ()),
                        v976
                    ),
                    toArray(empty::<char>()),
                ),
                toArray(ofArray(new_array(&[' ', '/']))),
            );
            println!("{}", v1015.clone());
            ();
            ((patternInput.1.clone()).l0.get().clone())(v1015)
        }
    }
    pub fn closure40(unitVar: (), unitVar_1: ()) -> string {
        string("read_all_text_retry_async")
    }
    pub fn closure39(v0_1: i64, v1_1: string, unitVar: ()) {
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
            let _v170: LrcPtr<MutCell<Option<File_system::US3>>> =
                refCell(None::<File_system::US3>);
            let v175: () = {
                File_system::closure8(
                    patternInput_2.4.clone(),
                    Func1::new({
                        let _v170 = _v170.clone();
                        move |v: Option<File_system::US3>| File_system::closure7(_v170.clone(), v)
                    }),
                    (),
                );
                ()
            };
            let v190: File_system::US3 = defaultValue(File_system::US3::US3_1, _v170.get().clone());
            let v230: DateTime = match &v190 {
                File_system::US3::US3_0(v190_0_0) => {
                    let v204: TimeSpan = TimeSpan::new_ticks(
                        {
                            let _arg: DateTime = DateTime::now();
                            _arg.ticks()
                        } - match &v190 {
                            File_system::US3::US3_0(x) => x.clone(),
                            _ => unreachable!(),
                        },
                    );
                    DateTime::new_ymdhms_milli(
                        1_i32,
                        1_i32,
                        1_i32,
                        v204.hours(),
                        v204.minutes(),
                        v204.seconds(),
                        v204.milliseconds(),
                    )
                }
                _ => DateTime::now(),
            };
            let v235: string = {
                let provider: string = File_system::method9();
                v230.toString(provider)
            };
            let v556: string = File_system::method11();
            let v567: LrcPtr<File_system::Mut4> = LrcPtr::new(File_system::Mut4 {
                l0: MutCell::new(File_system::method13()),
            });
            let v578: () = {
                File_system::closure9(
                    v567.clone(),
                    sprintf!("{}", sprintf!("{:?}", File_system::US0::US0_0)),
                    (),
                );
                ()
            };
            let v582: Array<string> = split(v567.l0.get().clone(), v556, -1_i32, 0_i32);
            let v585: string = v582[0_i32].clone();
            let v589: LrcPtr<File_system::Mut4> = LrcPtr::new(File_system::Mut4 {
                l0: MutCell::new(File_system::method13()),
            });
            let v600: () = {
                File_system::closure9(
                    v589.clone(),
                    sprintf!("{}", sprintf!("{:?}", File_system::US0::US0_1)),
                    (),
                );
                ()
            };
            let v610: File_system::US1 = if startsWith(v589.l0.get().clone(), v585, false) {
                File_system::US1::US1_0(string("Verbose"))
            } else {
                File_system::US1::US1_1
            };
            let v616: File_system::US1 = match &v610 {
                File_system::US1::US1_0(v610_0_0) => File_system::US1::US1_0(match &v610 {
                    File_system::US1::US1_0(x) => x.clone(),
                    _ => unreachable!(),
                }),
                _ => File_system::US1::US1_0(string("Debug")),
            };
            let v625: string = padLeft(
                toLower(match &v616 {
                    File_system::US1::US1_0(v616_0_0) => match &v616 {
                        File_system::US1::US1_0(x) => x.clone(),
                        _ => unreachable!(),
                    },
                    _ => panic!("{}", string("Option does not have a value."),),
                }),
                7_i32,
                ' ',
            );
            let v652: &str = inline_colorization::color_bright_blue;
            let v654: &str = &*v625;
            let v656: &str = inline_colorization::color_reset;
            let v658: string = string("format!(\"{v652}{v654}{v656}\")");
            let v659: std::string::String = format!("{v652}{v654}{v656}");
            let v661: string = fable_library_rust::String_::fromString(v659);
            let v691: i64 = (patternInput_2.0.clone()).l0.get().clone();
            let v693: LrcPtr<File_system::Mut4> = LrcPtr::new(File_system::Mut4 {
                l0: MutCell::new(File_system::method13()),
            });
            let v700: () = {
                File_system::closure9(v693.clone(), sprintf!("{}", string("{ ")), ());
                ()
            };
            let v709: () = {
                File_system::closure9(v693.clone(), sprintf!("{}", string("retry")), ());
                ()
            };
            let v718: () = {
                File_system::closure9(v693.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v726: () = {
                File_system::closure9(v693.clone(), sprintf!("{}", v0_1), ());
                ()
            };
            let v735: () = {
                File_system::closure9(v693.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v744: () = {
                File_system::closure9(v693.clone(), sprintf!("{}", string("ex")), ());
                ()
            };
            let v752: () = {
                File_system::closure9(v693.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v760: () = {
                File_system::closure9(v693.clone(), sprintf!("{}", v1_1), ());
                ()
            };
            let v769: () = {
                File_system::closure9(v693.clone(), sprintf!("{}", string(" }")), ());
                ()
            };
            let v772: string = v693.l0.get().clone();
            let v811: string = trimEndChars(
                trimStartChars(
                    sprintf!(
                        "{} {} #{} {} / {}",
                        v235,
                        v661,
                        v691,
                        File_system::closure40((), ()),
                        v772
                    ),
                    toArray(empty::<char>()),
                ),
                toArray(ofArray(new_array(&[' ', '/']))),
            );
            println!("{}", v811.clone());
            ();
            ((patternInput.1.clone()).l0.get().clone())(v811)
        }
    }
    pub fn method23(v0_1: string, v1_1: i64) -> Arc<Async<Option<string>>> {
        defaultOf()
    }
    pub fn closure32(unitVar: (), v0_1: string) -> Arc<Async<Option<string>>> {
        defaultOf()
    }
    pub fn closure42(
        v0_1: LrcPtr<MutCell<Option<File_system::US11>>>,
        v1_1: Option<File_system::US11>,
    ) -> LrcPtr<MutCell<Option<File_system::US11>>> {
        v0_1.set(v1_1);
        v0_1
    }
    pub fn closure43(
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
    pub fn method26() -> string {
        string("hh:mm")
    }
    pub fn method27() -> string {
        string("yyyyMMdd-HHmm-ssff-ffff-f")
    }
    pub fn method28() -> string {
        string("hhmm")
    }
    pub fn method25(v0_1: Guid, v1_1: DateTime) -> Guid {
        let v172: DateTime = {
            let _arg: DateTime =
                DateTime::new_ymdhms_kind(1970_i32, 1_i32, 1_i32, 0_i32, 0_i32, 0_i32, 1_i32);
            _arg.toUniversalTime()
        };
        let v190: i64 = ({
            let _arg_2: DateTime = {
                let _arg_1: DateTime = DateTime::specifyKind(v1_1, 2_i32);
                _arg_1.toUniversalTime()
            };
            _arg_2.ticks()
        } - v172.ticks())
            / 10_i64;
        let v192: Option<chrono::DateTime<chrono::Utc>> =
            chrono::DateTime::from_timestamp_micros(v190);
        let _v193: LrcPtr<MutCell<Option<File_system::US11>>> = refCell(None::<File_system::US11>);
        let v198: () = {
            File_system::closure43(
                v192,
                Func1::new({
                    let _v193 = _v193.clone();
                    move |v: Option<File_system::US11>| File_system::closure42(_v193.clone(), v)
                }),
                (),
            );
            ()
        };
        let v213: File_system::US11 = defaultValue(File_system::US11::US11_1, _v193.get().clone());
        let v233: File_system::US1 = match &v213 {
            File_system::US11::US11_0(v213_0_0) => {
                let v219: chrono::NaiveDateTime = match &v213 {
                    File_system::US11::US11_0(x) => x.clone(),
                    _ => unreachable!(),
                }
                .naive_utc();
                let v221: chrono::DateTime<chrono::Local> =
                    chrono::offset::TimeZone::from_utc_datetime(&chrono::Local, &v219);
                let v223: string = string("r#\"%Y%m%d-%H%M-%S%f\"#");
                let v224: &str = r#"%Y%m%d-%H%M-%S%f"#;
                let v226: std::string::String = v221.format(v224).to_string();
                let v228: string = fable_library_rust::String_::fromString(v226);
                File_system::US1::US1_0(sprintf!(
                    "{}-{}-{}",
                    getSlice(v228.clone(), Some(0_i32), Some(17_i32)),
                    getSlice(v228.clone(), Some(18_i32), Some(21_i32)),
                    getCharAt(v228, 22_i32)
                ))
            }
            _ => File_system::US1::US1_1,
        };
        let v237: string = match &v233 {
            File_system::US1::US1_0(v233_0_0) => match &v233 {
                File_system::US1::US1_0(x) => x.clone(),
                _ => unreachable!(),
            },
            _ => string(""),
        };
        let v241: LrcPtr<TimeZoneInfo> = defaultOf();
        let v315: u8 = if zero.hours() > 0_i32 { 1_u8 } else { 0_u8 };
        let v316: string = File_system::method26();
        let v324: string = zero.to_string(v316);
        let v327: string = sprintf!(
            "{}{}{}",
            v315,
            getSlice(v324.clone(), Some(0_i32), Some(1_i32)),
            getSlice(v324, Some(3_i32), Some(4_i32))
        );
        parse(sprintf!(
            "{}{}{}",
            v237.clone(),
            v327.clone(),
            getSlice(
                toString(v0_1),
                Some(length(v237) + length(v327)),
                None::<i32>
            )
        ))
    }
    pub fn method30() -> string {
        panic!(
            "{}",
            sprintf!(
                "file_system.get_temp_path / target: {}",
                File_system::US5::US5_2(File_system::US4::US4_1)
            ),
        )
    }
    pub fn method31() -> string {
        string("!create_temp_path_")
    }
    pub fn method34(v0_1: string) -> string {
        v0_1
    }
    pub fn method33(v0_1: string, v1_1: string) -> (string, string) {
        (v1_1, File_system::method34(v0_1))
    }
    pub fn method32(v0_1: string, v1_1: string) -> string {
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
    pub fn method36() -> string {
        string("CARGO_PKG_NAME")
    }
    pub fn method35() -> string {
        File_system::method2(File_system::method36())
    }
    pub fn method29(v0_1: Guid) -> string {
        File_system::method32(
            File_system::method32(
                File_system::method32(File_system::method30(), File_system::method31()),
                File_system::method35(),
            ),
            toString(v0_1),
        )
    }
    pub fn method24() -> string {
        let v10: DateTime = DateTime::now();
        File_system::method29(File_system::method25(new_guid(), v10))
    }
    pub fn closure41(unitVar: (), unitVar_1: ()) -> string {
        File_system::method24()
    }
    pub fn method38(v0_1: string) -> string {
        v0_1
    }
    pub fn closure45(unitVar: (), v0_1: std::io::Error) -> std::string::String {
        format!("{}", v0_1)
    }
    pub fn method39() -> Func1<std::io::Error, std::string::String> {
        Func1::new(move |v: std::io::Error| File_system::closure45((), v))
    }
    pub fn closure46(unitVar: (), unitVar_1: ()) -> File_system::US12 {
        File_system::US12::US12_0
    }
    pub fn closure47(unitVar: (), v0_1: std::string::String) -> File_system::US12 {
        File_system::US12::US12_1(v0_1)
    }
    pub fn closure49(unitVar: (), unitVar_1: ()) -> string {
        string("file_system.create_dir")
    }
    pub fn closure48(v0_1: string, v1_1: std::string::String, unitVar: ()) {
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
            let _v170: LrcPtr<MutCell<Option<File_system::US3>>> =
                refCell(None::<File_system::US3>);
            let v175: () = {
                File_system::closure8(
                    patternInput_2.4.clone(),
                    Func1::new({
                        let _v170 = _v170.clone();
                        move |v: Option<File_system::US3>| File_system::closure7(_v170.clone(), v)
                    }),
                    (),
                );
                ()
            };
            let v190: File_system::US3 = defaultValue(File_system::US3::US3_1, _v170.get().clone());
            let v230: DateTime = match &v190 {
                File_system::US3::US3_0(v190_0_0) => {
                    let v204: TimeSpan = TimeSpan::new_ticks(
                        {
                            let _arg: DateTime = DateTime::now();
                            _arg.ticks()
                        } - match &v190 {
                            File_system::US3::US3_0(x) => x.clone(),
                            _ => unreachable!(),
                        },
                    );
                    DateTime::new_ymdhms_milli(
                        1_i32,
                        1_i32,
                        1_i32,
                        v204.hours(),
                        v204.minutes(),
                        v204.seconds(),
                        v204.milliseconds(),
                    )
                }
                _ => DateTime::now(),
            };
            let v235: string = {
                let provider: string = File_system::method9();
                v230.toString(provider)
            };
            let v556: string = File_system::method11();
            let v567: LrcPtr<File_system::Mut4> = LrcPtr::new(File_system::Mut4 {
                l0: MutCell::new(File_system::method13()),
            });
            let v578: () = {
                File_system::closure9(
                    v567.clone(),
                    sprintf!("{}", sprintf!("{:?}", File_system::US0::US0_0)),
                    (),
                );
                ()
            };
            let v582: Array<string> = split(v567.l0.get().clone(), v556, -1_i32, 0_i32);
            let v585: string = v582[0_i32].clone();
            let v589: LrcPtr<File_system::Mut4> = LrcPtr::new(File_system::Mut4 {
                l0: MutCell::new(File_system::method13()),
            });
            let v600: () = {
                File_system::closure9(
                    v589.clone(),
                    sprintf!("{}", sprintf!("{:?}", File_system::US0::US0_4)),
                    (),
                );
                ()
            };
            let v610: File_system::US1 = if startsWith(v589.l0.get().clone(), v585, false) {
                File_system::US1::US1_0(string("Verbose"))
            } else {
                File_system::US1::US1_1
            };
            let v799: File_system::US1 = match &v610 {
                File_system::US1::US1_0(v610_0_0) => File_system::US1::US1_0(match &v610 {
                    File_system::US1::US1_0(x) => x.clone(),
                    _ => unreachable!(),
                }),
                _ => {
                    let v615: string = File_system::method11();
                    let v626: LrcPtr<File_system::Mut4> = LrcPtr::new(File_system::Mut4 {
                        l0: MutCell::new(File_system::method13()),
                    });
                    let v637: () = {
                        File_system::closure9(
                            v626.clone(),
                            sprintf!("{}", sprintf!("{:?}", File_system::US0::US0_1)),
                            (),
                        );
                        ()
                    };
                    let v641: Array<string> = split(v626.l0.get().clone(), v615, -1_i32, 0_i32);
                    let v644: string = v641[0_i32].clone();
                    let v648: LrcPtr<File_system::Mut4> = LrcPtr::new(File_system::Mut4 {
                        l0: MutCell::new(File_system::method13()),
                    });
                    let v659: () = {
                        File_system::closure9(
                            v648.clone(),
                            sprintf!("{}", sprintf!("{:?}", File_system::US0::US0_4)),
                            (),
                        );
                        ()
                    };
                    let v669: File_system::US1 = if startsWith(v648.l0.get().clone(), v644, false) {
                        File_system::US1::US1_0(string("Debug"))
                    } else {
                        File_system::US1::US1_1
                    };
                    match &v669 {
                        File_system::US1::US1_0(v669_0_0) => File_system::US1::US1_0(match &v669 {
                            File_system::US1::US1_0(x) => x.clone(),
                            _ => unreachable!(),
                        }),
                        _ => {
                            let v674: string = File_system::method11();
                            let v685: LrcPtr<File_system::Mut4> = LrcPtr::new(File_system::Mut4 {
                                l0: MutCell::new(File_system::method13()),
                            });
                            let v696: () = {
                                File_system::closure9(
                                    v685.clone(),
                                    sprintf!("{}", sprintf!("{:?}", File_system::US0::US0_2)),
                                    (),
                                );
                                ()
                            };
                            let v700: Array<string> =
                                split(v685.l0.get().clone(), v674, -1_i32, 0_i32);
                            let v703: string = v700[0_i32].clone();
                            let v707: LrcPtr<File_system::Mut4> = LrcPtr::new(File_system::Mut4 {
                                l0: MutCell::new(File_system::method13()),
                            });
                            let v718: () = {
                                File_system::closure9(
                                    v707.clone(),
                                    sprintf!("{}", sprintf!("{:?}", File_system::US0::US0_4)),
                                    (),
                                );
                                ()
                            };
                            let v728: File_system::US1 =
                                if startsWith(v707.l0.get().clone(), v703, false) {
                                    File_system::US1::US1_0(string("Info"))
                                } else {
                                    File_system::US1::US1_1
                                };
                            match &v728 {
                                File_system::US1::US1_0(v728_0_0) => {
                                    File_system::US1::US1_0(match &v728 {
                                        File_system::US1::US1_0(x) => x.clone(),
                                        _ => unreachable!(),
                                    })
                                }
                                _ => {
                                    let v733: string = File_system::method11();
                                    let v744: LrcPtr<File_system::Mut4> =
                                        LrcPtr::new(File_system::Mut4 {
                                            l0: MutCell::new(File_system::method13()),
                                        });
                                    let v755: () = {
                                        File_system::closure9(
                                            v744.clone(),
                                            sprintf!(
                                                "{}",
                                                sprintf!("{:?}", File_system::US0::US0_3)
                                            ),
                                            (),
                                        );
                                        ()
                                    };
                                    let v759: Array<string> =
                                        split(v744.l0.get().clone(), v733, -1_i32, 0_i32);
                                    let v762: string = v759[0_i32].clone();
                                    let v766: LrcPtr<File_system::Mut4> =
                                        LrcPtr::new(File_system::Mut4 {
                                            l0: MutCell::new(File_system::method13()),
                                        });
                                    let v777: () = {
                                        File_system::closure9(
                                            v766.clone(),
                                            sprintf!(
                                                "{}",
                                                sprintf!("{:?}", File_system::US0::US0_4)
                                            ),
                                            (),
                                        );
                                        ()
                                    };
                                    let v787: File_system::US1 =
                                        if startsWith(v766.l0.get().clone(), v762, false) {
                                            File_system::US1::US1_0(string("Warning"))
                                        } else {
                                            File_system::US1::US1_1
                                        };
                                    match &v787 {
                                        File_system::US1::US1_0(v787_0_0) => {
                                            File_system::US1::US1_0(match &v787 {
                                                File_system::US1::US1_0(x) => x.clone(),
                                                _ => unreachable!(),
                                            })
                                        }
                                        _ => File_system::US1::US1_0(string("Critical")),
                                    }
                                }
                            }
                        }
                    }
                }
            };
            let v808: string = padLeft(
                toLower(match &v799 {
                    File_system::US1::US1_0(v799_0_0) => match &v799 {
                        File_system::US1::US1_0(x) => x.clone(),
                        _ => unreachable!(),
                    },
                    _ => panic!("{}", string("Option does not have a value."),),
                }),
                7_i32,
                ' ',
            );
            let v835: &str = inline_colorization::color_bright_red;
            let v837: &str = &*v808;
            let v839: &str = inline_colorization::color_reset;
            let v841: string = string("format!(\"{v835}{v837}{v839}\")");
            let v842: std::string::String = format!("{v835}{v837}{v839}");
            let v844: string = fable_library_rust::String_::fromString(v842);
            let v874: i64 = (patternInput_2.0.clone()).l0.get().clone();
            let v876: LrcPtr<File_system::Mut4> = LrcPtr::new(File_system::Mut4 {
                l0: MutCell::new(File_system::method13()),
            });
            let v883: () = {
                File_system::closure9(v876.clone(), sprintf!("{}", string("{ ")), ());
                ()
            };
            let v892: () = {
                File_system::closure9(v876.clone(), sprintf!("{}", string("dir")), ());
                ()
            };
            let v901: () = {
                File_system::closure9(v876.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v909: () = {
                File_system::closure9(v876.clone(), sprintf!("{}", v0_1), ());
                ()
            };
            let v918: () = {
                File_system::closure9(v876.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v927: () = {
                File_system::closure9(v876.clone(), sprintf!("{}", string("error")), ());
                ()
            };
            let v935: () = {
                File_system::closure9(v876.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v944: std::string::String = format!("{:#?}", v1_1);
            let v970: () = {
                File_system::closure9(
                    v876.clone(),
                    sprintf!("{}", fable_library_rust::String_::fromString(v944)),
                    (),
                );
                ()
            };
            let v979: () = {
                File_system::closure9(v876.clone(), sprintf!("{}", string(" }")), ());
                ()
            };
            let v982: string = v876.l0.get().clone();
            let v1021: string = trimEndChars(
                trimStartChars(
                    sprintf!(
                        "{} {} #{} {} / {}",
                        v235,
                        v844,
                        v874,
                        File_system::closure49((), ()),
                        v982
                    ),
                    toArray(empty::<char>()),
                ),
                toArray(ofArray(new_array(&[' ', '/']))),
            );
            println!("{}", v1021.clone());
            ();
            ((patternInput.1.clone()).l0.get().clone())(v1021)
        }
    }
    pub fn closure51(unitVar: (), unitVar_1: ()) -> string {
        string("file_system.create_dir")
    }
    pub fn closure50(v0_1: string, unitVar: ()) {
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
            let _v169: LrcPtr<MutCell<Option<File_system::US3>>> =
                refCell(None::<File_system::US3>);
            let v174: () = {
                File_system::closure8(
                    patternInput_2.4.clone(),
                    Func1::new({
                        let _v169 = _v169.clone();
                        move |v: Option<File_system::US3>| File_system::closure7(_v169.clone(), v)
                    }),
                    (),
                );
                ()
            };
            let v189: File_system::US3 = defaultValue(File_system::US3::US3_1, _v169.get().clone());
            let v229: DateTime = match &v189 {
                File_system::US3::US3_0(v189_0_0) => {
                    let v203: TimeSpan = TimeSpan::new_ticks(
                        {
                            let _arg: DateTime = DateTime::now();
                            _arg.ticks()
                        } - match &v189 {
                            File_system::US3::US3_0(x) => x.clone(),
                            _ => unreachable!(),
                        },
                    );
                    DateTime::new_ymdhms_milli(
                        1_i32,
                        1_i32,
                        1_i32,
                        v203.hours(),
                        v203.minutes(),
                        v203.seconds(),
                        v203.milliseconds(),
                    )
                }
                _ => DateTime::now(),
            };
            let v234: string = {
                let provider: string = File_system::method9();
                v229.toString(provider)
            };
            let v558: string = padLeft(toLower(string("Verbose")), 7_i32, ' ');
            let v585: &str = inline_colorization::color_bright_black;
            let v587: &str = &*v558;
            let v589: &str = inline_colorization::color_reset;
            let v591: string = string("format!(\"{v585}{v587}{v589}\")");
            let v592: std::string::String = format!("{v585}{v587}{v589}");
            let v594: string = fable_library_rust::String_::fromString(v592);
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
                        v234,
                        v594,
                        v624,
                        File_system::closure51((), ()),
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
    pub fn closure52(v0_1: string, unitVar: ()) {
        File_system::method6(true, v0_1);
    }
    pub fn method40(v0_1: string) -> Func0<()> {
        Func0::new({
            let v0_1 = v0_1.clone();
            move || File_system::closure52(v0_1.clone(), ())
        })
    }
    pub fn method41(v0_1: string) -> Func0<()> {
        Func0::new({
            let v0_1 = v0_1.clone();
            move || File_system::closure52(v0_1.clone(), ())
        })
    }
    pub fn closure54(unitVar: (), unitVar_1: ()) -> string {
        string("file_system.create_dir")
    }
    pub fn closure53(v0_1: string, v1_1: string, unitVar: ()) {
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
            let _v170: LrcPtr<MutCell<Option<File_system::US3>>> =
                refCell(None::<File_system::US3>);
            let v175: () = {
                File_system::closure8(
                    patternInput_2.4.clone(),
                    Func1::new({
                        let _v170 = _v170.clone();
                        move |v: Option<File_system::US3>| File_system::closure7(_v170.clone(), v)
                    }),
                    (),
                );
                ()
            };
            let v190: File_system::US3 = defaultValue(File_system::US3::US3_1, _v170.get().clone());
            let v230: DateTime = match &v190 {
                File_system::US3::US3_0(v190_0_0) => {
                    let v204: TimeSpan = TimeSpan::new_ticks(
                        {
                            let _arg: DateTime = DateTime::now();
                            _arg.ticks()
                        } - match &v190 {
                            File_system::US3::US3_0(x) => x.clone(),
                            _ => unreachable!(),
                        },
                    );
                    DateTime::new_ymdhms_milli(
                        1_i32,
                        1_i32,
                        1_i32,
                        v204.hours(),
                        v204.minutes(),
                        v204.seconds(),
                        v204.milliseconds(),
                    )
                }
                _ => DateTime::now(),
            };
            let v235: string = {
                let provider: string = File_system::method9();
                v230.toString(provider)
            };
            let v556: string = File_system::method11();
            let v567: LrcPtr<File_system::Mut4> = LrcPtr::new(File_system::Mut4 {
                l0: MutCell::new(File_system::method13()),
            });
            let v578: () = {
                File_system::closure9(
                    v567.clone(),
                    sprintf!("{}", sprintf!("{:?}", File_system::US0::US0_0)),
                    (),
                );
                ()
            };
            let v582: Array<string> = split(v567.l0.get().clone(), v556, -1_i32, 0_i32);
            let v585: string = v582[0_i32].clone();
            let v589: LrcPtr<File_system::Mut4> = LrcPtr::new(File_system::Mut4 {
                l0: MutCell::new(File_system::method13()),
            });
            let v600: () = {
                File_system::closure9(
                    v589.clone(),
                    sprintf!("{}", sprintf!("{:?}", File_system::US0::US0_1)),
                    (),
                );
                ()
            };
            let v610: File_system::US1 = if startsWith(v589.l0.get().clone(), v585, false) {
                File_system::US1::US1_0(string("Verbose"))
            } else {
                File_system::US1::US1_1
            };
            let v616: File_system::US1 = match &v610 {
                File_system::US1::US1_0(v610_0_0) => File_system::US1::US1_0(match &v610 {
                    File_system::US1::US1_0(x) => x.clone(),
                    _ => unreachable!(),
                }),
                _ => File_system::US1::US1_0(string("Debug")),
            };
            let v625: string = padLeft(
                toLower(match &v616 {
                    File_system::US1::US1_0(v616_0_0) => match &v616 {
                        File_system::US1::US1_0(x) => x.clone(),
                        _ => unreachable!(),
                    },
                    _ => panic!("{}", string("Option does not have a value."),),
                }),
                7_i32,
                ' ',
            );
            let v652: &str = inline_colorization::color_bright_blue;
            let v654: &str = &*v625;
            let v656: &str = inline_colorization::color_reset;
            let v658: string = string("format!(\"{v652}{v654}{v656}\")");
            let v659: std::string::String = format!("{v652}{v654}{v656}");
            let v661: string = fable_library_rust::String_::fromString(v659);
            let v691: i64 = (patternInput_2.0.clone()).l0.get().clone();
            let v693: LrcPtr<File_system::Mut4> = LrcPtr::new(File_system::Mut4 {
                l0: MutCell::new(File_system::method13()),
            });
            let v700: () = {
                File_system::closure9(v693.clone(), sprintf!("{}", string("{ ")), ());
                ()
            };
            let v709: () = {
                File_system::closure9(v693.clone(), sprintf!("{}", string("dir")), ());
                ()
            };
            let v718: () = {
                File_system::closure9(v693.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v726: () = {
                File_system::closure9(v693.clone(), sprintf!("{}", v0_1), ());
                ()
            };
            let v735: () = {
                File_system::closure9(v693.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v744: () = {
                File_system::closure9(v693.clone(), sprintf!("{}", string("result")), ());
                ()
            };
            let v752: () = {
                File_system::closure9(v693.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v760: () = {
                File_system::closure9(v693.clone(), sprintf!("{}", v1_1), ());
                ()
            };
            let v769: () = {
                File_system::closure9(v693.clone(), sprintf!("{}", string(" }")), ());
                ()
            };
            let v772: string = v693.l0.get().clone();
            let v811: string = trimEndChars(
                trimStartChars(
                    sprintf!(
                        "{} {} #{} {} / {}",
                        v235,
                        v661,
                        v691,
                        File_system::closure54((), ()),
                        v772
                    ),
                    toArray(empty::<char>()),
                ),
                toArray(ofArray(new_array(&[' ', '/']))),
            );
            println!("{}", v811.clone());
            ();
            ((patternInput.1.clone()).l0.get().clone())(v811)
        }
    }
    pub fn closure55(v0_1: string, unitVar: ()) {
        let v5: Arc<Async<i64>> = defaultOf();
        let v28_1: Arc<Async<()>> = defaultOf();
        defaultOf::<()>();
        ();
        ()
    }
    pub fn method42(v0_1: string) -> Func0<()> {
        Func0::new({
            let v0_1 = v0_1.clone();
            move || File_system::closure55(v0_1.clone(), ())
        })
    }
    pub fn method43(v0_1: string) -> Func0<()> {
        Func0::new({
            let v0_1 = v0_1.clone();
            move || File_system::closure55(v0_1.clone(), ())
        })
    }
    pub fn method37(v0_1: string) -> LrcPtr<dyn IDisposable> {
        interface_cast!(
            defaultOf::<std::sync::Arc<dyn IDisposable>>(),
            Lrc<dyn IDisposable>,
        )
    }
    pub fn closure44(unitVar: (), unitVar_1: ()) -> (string, LrcPtr<dyn IDisposable>) {
        let v0_1: string = File_system::method24();
        (v0_1.clone(), File_system::method37(v0_1))
    }
    pub fn method44(v0_1: string) -> Guid {
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
    pub fn closure56(unitVar: (), v0_1: string) -> (string, LrcPtr<dyn IDisposable>) {
        let v2_1: string = File_system::method29(File_system::method44(v0_1));
        (v2_1.clone(), File_system::method37(v2_1))
    }
    pub fn closure57(unitVar: (), unitVar_1: ()) -> string {
        string("C:\\home\\git\\polyglot\\lib\\spiral")
    }
    pub fn method46(v0_1: string) -> string {
        v0_1
    }
    pub fn method45(v0_1: string) -> string {
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
    pub fn closure58(unitVar: (), v0_1: string) -> string {
        File_system::method45(v0_1)
    }
    pub fn closure59(unitVar: (), v0_1: string) -> string {
        sprintf!("file:///{}", trimStartChars(v0_1, toArray(singleton('/'))))
    }
    pub fn method49(v0_1: string) -> Option<string> {
        let v85: File_system::US1 = unbox::<File_system::US1>(&defaultOf());
        match &v85 {
            File_system::US1::US1_0(v85_0_0) => Some(match &v85 {
                File_system::US1::US1_0(x) => x.clone(),
                _ => unreachable!(),
            }),
            _ => None::<string>,
        }
    }
    pub fn closure61(unitVar: (), v0_1: string) -> Option<string> {
        File_system::method49(v0_1)
    }
    pub fn method48() -> Func1<string, Option<string>> {
        Func1::new(move |v: string| File_system::closure61((), v))
    }
    pub fn method50(v0_1: string, v1_1: string, v2_1: string) -> File_system::US13 {
        let v0_1: MutCell<string> = MutCell::new(v0_1.clone());
        let v1_1: MutCell<string> = MutCell::new(v1_1.clone());
        let v2_1: MutCell<string> = MutCell::new(v2_1.clone());
        '_method50: loop {
            break '_method50 (if File_system::method8(File_system::method32(
                v2_1.get().clone(),
                v0_1.get().clone(),
            )) {
                File_system::US13::US13_0(v2_1.get().clone())
            } else {
                let v7: Option<string> = (File_system::method48())(v2_1.get().clone());
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
                        continue '_method50;
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
    pub fn method47(v0_1: string, v1_1: string) -> File_system::US13 {
        if File_system::method8(File_system::method32(v1_1.clone(), v0_1.clone())) {
            File_system::US13::US13_0(v1_1.clone())
        } else {
            let v6: Option<string> = (File_system::method48())(v1_1.clone());
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
                File_system::US1::US1_0(v27_1_0_0) => File_system::method50(
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
    pub fn closure63(unitVar: (), unitVar_1: ()) -> string {
        string("file_system.get_workspace_root")
    }
    pub fn closure62(v0_1: string, unitVar: ()) {
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
            let _v169: LrcPtr<MutCell<Option<File_system::US3>>> =
                refCell(None::<File_system::US3>);
            let v174: () = {
                File_system::closure8(
                    patternInput_2.4.clone(),
                    Func1::new({
                        let _v169 = _v169.clone();
                        move |v: Option<File_system::US3>| File_system::closure7(_v169.clone(), v)
                    }),
                    (),
                );
                ()
            };
            let v189: File_system::US3 = defaultValue(File_system::US3::US3_1, _v169.get().clone());
            let v229: DateTime = match &v189 {
                File_system::US3::US3_0(v189_0_0) => {
                    let v203: TimeSpan = TimeSpan::new_ticks(
                        {
                            let _arg: DateTime = DateTime::now();
                            _arg.ticks()
                        } - match &v189 {
                            File_system::US3::US3_0(x) => x.clone(),
                            _ => unreachable!(),
                        },
                    );
                    DateTime::new_ymdhms_milli(
                        1_i32,
                        1_i32,
                        1_i32,
                        v203.hours(),
                        v203.minutes(),
                        v203.seconds(),
                        v203.milliseconds(),
                    )
                }
                _ => DateTime::now(),
            };
            let v234: string = {
                let provider: string = File_system::method9();
                v229.toString(provider)
            };
            let v555: string = File_system::method11();
            let v566: LrcPtr<File_system::Mut4> = LrcPtr::new(File_system::Mut4 {
                l0: MutCell::new(File_system::method13()),
            });
            let v577: () = {
                File_system::closure9(
                    v566.clone(),
                    sprintf!("{}", sprintf!("{:?}", File_system::US0::US0_0)),
                    (),
                );
                ()
            };
            let v581: Array<string> = split(v566.l0.get().clone(), v555, -1_i32, 0_i32);
            let v584: string = v581[0_i32].clone();
            let v588: LrcPtr<File_system::Mut4> = LrcPtr::new(File_system::Mut4 {
                l0: MutCell::new(File_system::method13()),
            });
            let v599: () = {
                File_system::closure9(
                    v588.clone(),
                    sprintf!("{}", sprintf!("{:?}", File_system::US0::US0_3)),
                    (),
                );
                ()
            };
            let v609: File_system::US1 = if startsWith(v588.l0.get().clone(), v584, false) {
                File_system::US1::US1_0(string("Verbose"))
            } else {
                File_system::US1::US1_1
            };
            let v737: File_system::US1 = match &v609 {
                File_system::US1::US1_0(v609_0_0) => File_system::US1::US1_0(match &v609 {
                    File_system::US1::US1_0(x) => x.clone(),
                    _ => unreachable!(),
                }),
                _ => {
                    let v614: string = File_system::method11();
                    let v625: LrcPtr<File_system::Mut4> = LrcPtr::new(File_system::Mut4 {
                        l0: MutCell::new(File_system::method13()),
                    });
                    let v636: () = {
                        File_system::closure9(
                            v625.clone(),
                            sprintf!("{}", sprintf!("{:?}", File_system::US0::US0_1)),
                            (),
                        );
                        ()
                    };
                    let v640: Array<string> = split(v625.l0.get().clone(), v614, -1_i32, 0_i32);
                    let v643: string = v640[0_i32].clone();
                    let v647: LrcPtr<File_system::Mut4> = LrcPtr::new(File_system::Mut4 {
                        l0: MutCell::new(File_system::method13()),
                    });
                    let v658: () = {
                        File_system::closure9(
                            v647.clone(),
                            sprintf!("{}", sprintf!("{:?}", File_system::US0::US0_3)),
                            (),
                        );
                        ()
                    };
                    let v668: File_system::US1 = if startsWith(v647.l0.get().clone(), v643, false) {
                        File_system::US1::US1_0(string("Debug"))
                    } else {
                        File_system::US1::US1_1
                    };
                    match &v668 {
                        File_system::US1::US1_0(v668_0_0) => File_system::US1::US1_0(match &v668 {
                            File_system::US1::US1_0(x) => x.clone(),
                            _ => unreachable!(),
                        }),
                        _ => {
                            let v673: string = File_system::method11();
                            let v684: LrcPtr<File_system::Mut4> = LrcPtr::new(File_system::Mut4 {
                                l0: MutCell::new(File_system::method13()),
                            });
                            let v695: () = {
                                File_system::closure9(
                                    v684.clone(),
                                    sprintf!("{}", sprintf!("{:?}", File_system::US0::US0_2)),
                                    (),
                                );
                                ()
                            };
                            let v699: Array<string> =
                                split(v684.l0.get().clone(), v673, -1_i32, 0_i32);
                            let v702: string = v699[0_i32].clone();
                            let v706: LrcPtr<File_system::Mut4> = LrcPtr::new(File_system::Mut4 {
                                l0: MutCell::new(File_system::method13()),
                            });
                            let v717: () = {
                                File_system::closure9(
                                    v706.clone(),
                                    sprintf!("{}", sprintf!("{:?}", File_system::US0::US0_3)),
                                    (),
                                );
                                ()
                            };
                            let v727: File_system::US1 =
                                if startsWith(v706.l0.get().clone(), v702, false) {
                                    File_system::US1::US1_0(string("Info"))
                                } else {
                                    File_system::US1::US1_1
                                };
                            match &v727 {
                                File_system::US1::US1_0(v727_0_0) => {
                                    File_system::US1::US1_0(match &v727 {
                                        File_system::US1::US1_0(x) => x.clone(),
                                        _ => unreachable!(),
                                    })
                                }
                                _ => File_system::US1::US1_0(string("Warning")),
                            }
                        }
                    }
                }
            };
            let v746: string = padLeft(
                toLower(match &v737 {
                    File_system::US1::US1_0(v737_0_0) => match &v737 {
                        File_system::US1::US1_0(x) => x.clone(),
                        _ => unreachable!(),
                    },
                    _ => panic!("{}", string("Option does not have a value."),),
                }),
                7_i32,
                ' ',
            );
            let v773: &str = inline_colorization::color_yellow;
            let v775: &str = &*v746;
            let v777: &str = inline_colorization::color_reset;
            let v779: string = string("format!(\"{v773}{v775}{v777}\")");
            let v780: std::string::String = format!("{v773}{v775}{v777}");
            let v782: string = fable_library_rust::String_::fromString(v780);
            let v812: i64 = (patternInput_2.0.clone()).l0.get().clone();
            let v814: LrcPtr<File_system::Mut4> = LrcPtr::new(File_system::Mut4 {
                l0: MutCell::new(File_system::method13()),
            });
            let v821: () = {
                File_system::closure9(v814.clone(), sprintf!("{}", string("{ ")), ());
                ()
            };
            let v830: () = {
                File_system::closure9(v814.clone(), sprintf!("{}", string("error")), ());
                ()
            };
            let v839: () = {
                File_system::closure9(v814.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v847: () = {
                File_system::closure9(v814.clone(), sprintf!("{}", v0_1), ());
                ()
            };
            let v856: () = {
                File_system::closure9(v814.clone(), sprintf!("{}", string(" }")), ());
                ()
            };
            let v859: string = v814.l0.get().clone();
            let v898: string = trimEndChars(
                trimStartChars(
                    sprintf!(
                        "{} {} #{} {} / {}",
                        v234,
                        v782,
                        v812,
                        File_system::closure63((), ()),
                        v859
                    ),
                    toArray(empty::<char>()),
                ),
                toArray(ofArray(new_array(&[' ', '/']))),
            );
            println!("{}", v898.clone());
            ();
            ((patternInput.1.clone()).l0.get().clone())(v898)
        }
    }
    pub fn method51() -> string {
        unbox::<string>(&defaultOf())
    }
    pub fn closure60(unitVar: (), unitVar_1: ()) -> string {
        let v4: File_system::US13 = File_system::method47(
            File_system::method32(string("polyglot"), string(".devcontainer")),
            string("C:\\home\\git\\polyglot\\lib\\spiral"),
        );
        let v934: File_system::US1 = match &v4 {
            File_system::US13::US13_0(v4_0_0) => File_system::US1::US1_0(v4_0_0.clone()),
            File_system::US13::US13_1(v4_1_0) => {
                let v10: () = {
                    File_system::closure62(v4_1_0.clone(), ());
                    ()
                };
                File_system::US1::US1_1
            }
        };
        let v1871: File_system::US1 = match &v934 {
            File_system::US1::US1_0(v934_0_0) => File_system::US1::US1_0(match &v934 {
                File_system::US1::US1_0(x) => x.clone(),
                _ => unreachable!(),
            }),
            _ => {
                let v937: string = File_system::method51();
                let v939: File_system::US13 = File_system::method47(
                    File_system::method32(string("polyglot"), string(".devcontainer")),
                    v937,
                );
                match &v939 {
                    File_system::US13::US13_0(v939_0_0) => {
                        File_system::US1::US1_0(v939_0_0.clone())
                    }
                    File_system::US13::US13_1(v939_1_0) => {
                        let v945: () = {
                            File_system::closure62(v939_1_0.clone(), ());
                            ()
                        };
                        File_system::US1::US1_1
                    }
                }
            }
        };
        File_system::method32(
            match &v1871 {
                File_system::US1::US1_0(v1871_0_0) => match &v1871 {
                    File_system::US1::US1_0(x) => x.clone(),
                    _ => unreachable!(),
                },
                _ => panic!("{}", string("Option does not have a value."),),
            },
            string("polyglot"),
        )
    }
    pub fn method52(v0_1: string) {
        ();
        ()
    }
    pub fn closure65(unitVar: (), v0_1: string) {
        File_system::method52(v0_1);
    }
    pub fn closure64(unitVar: (), v0_1: bool) {
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
            Func1::new(move |v: string| File_system::closure65((), v))
        } else {
            Func1::new(move |v_1: string| File_system::closure3((), v_1))
        };
        (patternInput.1.clone()).l0.set(v33_1);
        ()
    }
    pub fn closure67(v0_1: string, v1_1: string) -> string {
        File_system::method32(v0_1, v1_1)
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
        v16.get_or_init(|| Func1::new(move |v: File_system::US6| File_system::closure13((), v)))
            .clone()
    }
    pub fn wait_for_file_access(x: File_system::US6) -> Func1<string, Arc<Async<i64>>> {
        (File_system::v16())(x)
    }
    pub fn v17() -> Func1<string, Arc<Async<i64>>> {
        static v17: OnceInit<Func1<string, Arc<Async<i64>>>> = OnceInit::new();
        v17.get_or_init(|| Func1::new(move |v: string| File_system::closure17((), v)))
            .clone()
    }
    pub fn wait_for_file_access_read(x: string) -> Arc<Async<i64>> {
        (File_system::v17())(x)
    }
    pub fn v18() -> Func1<string, Arc<Async<string>>> {
        static v18: OnceInit<Func1<string, Arc<Async<string>>>> = OnceInit::new();
        v18.get_or_init(|| Func1::new(move |v: string| File_system::closure18((), v)))
            .clone()
    }
    pub fn read_all_text_async(x: string) -> Arc<Async<string>> {
        (File_system::v18())(x)
    }
    pub fn v19() -> Func1<string, Func1<string, bool>> {
        static v19: OnceInit<Func1<string, Func1<string, bool>>> = OnceInit::new();
        v19.get_or_init(|| Func1::new(move |v: string| File_system::closure19((), v)))
            .clone()
    }
    pub fn file_exists_content(x: string) -> Func1<string, bool> {
        (File_system::v19())(x)
    }
    pub fn v20() -> Func1<string, Func1<string, Arc<Async<()>>>> {
        static v20: OnceInit<Func1<string, Func1<string, Arc<Async<()>>>>> = OnceInit::new();
        v20.get_or_init(|| Func1::new(move |v: string| File_system::closure21((), v)))
            .clone()
    }
    pub fn write_all_text_async(x: string) -> Func1<string, Arc<Async<()>>> {
        (File_system::v20())(x)
    }
    pub fn v21() -> Func1<string, Func1<string, Arc<Async<()>>>> {
        static v21: OnceInit<Func1<string, Func1<string, Arc<Async<()>>>>> = OnceInit::new();
        v21.get_or_init(|| Func1::new(move |v: string| File_system::closure23((), v)))
            .clone()
    }
    pub fn write_all_text_exists(x: string) -> Func1<string, Arc<Async<()>>> {
        (File_system::v21())(x)
    }
    pub fn v22() -> Func1<string, Arc<Async<i64>>> {
        static v22: OnceInit<Func1<string, Arc<Async<i64>>>> = OnceInit::new();
        v22.get_or_init(|| Func1::new(move |v: string| File_system::closure25((), v)))
            .clone()
    }
    pub fn delete_file_async(x: string) -> Arc<Async<i64>> {
        (File_system::v22())(x)
    }
    pub fn v23() -> Func1<string, Func1<string, Arc<Async<i64>>>> {
        static v23: OnceInit<Func1<string, Func1<string, Arc<Async<i64>>>>> = OnceInit::new();
        v23.get_or_init(|| Func1::new(move |v: string| File_system::closure28((), v)))
            .clone()
    }
    pub fn move_file_async(x: string) -> Func1<string, Arc<Async<i64>>> {
        (File_system::v23())(x)
    }
    pub fn v24() -> Func1<string, Arc<Async<Option<string>>>> {
        static v24: OnceInit<Func1<string, Arc<Async<Option<string>>>>> = OnceInit::new();
        v24.get_or_init(|| Func1::new(move |v: string| File_system::closure32((), v)))
            .clone()
    }
    pub fn read_all_text_retry_async(x: string) -> Arc<Async<Option<string>>> {
        (File_system::v24())(x)
    }
    pub fn v25() -> Func0<string> {
        static v25: OnceInit<Func0<string>> = OnceInit::new();
        v25.get_or_init(|| Func0::new(move || File_system::closure41((), ())))
            .clone()
    }
    pub fn create_temp_path() -> string {
        (File_system::v25())()
    }
    pub fn v26() -> Func0<(string, LrcPtr<dyn IDisposable>)> {
        static v26: OnceInit<Func0<(string, LrcPtr<dyn IDisposable>)>> = OnceInit::new();
        v26.get_or_init(|| Func0::new(move || File_system::closure44((), ())))
            .clone()
    }
    pub fn create_temp_dir() -> (string, LrcPtr<dyn IDisposable>) {
        (File_system::v26())()
    }
    pub fn v27() -> Func1<string, (string, LrcPtr<dyn IDisposable>)> {
        static v27: OnceInit<Func1<string, (string, LrcPtr<dyn IDisposable>)>> = OnceInit::new();
        v27.get_or_init(|| Func1::new(move |v: string| File_system::closure56((), v)))
            .clone()
    }
    pub fn create_temp_dir_(x: string) -> (string, LrcPtr<dyn IDisposable>) {
        (File_system::v27())(x)
    }
    pub fn v28() -> Func0<string> {
        static v28: OnceInit<Func0<string>> = OnceInit::new();
        v28.get_or_init(|| Func0::new(move || File_system::closure57((), ())))
            .clone()
    }
    pub fn get_source_directory() -> string {
        (File_system::v28())()
    }
    pub fn v29() -> Func1<string, string> {
        static v29: OnceInit<Func1<string, string>> = OnceInit::new();
        v29.get_or_init(|| Func1::new(move |v: string| File_system::closure58((), v)))
            .clone()
    }
    pub fn normalize_path(x: string) -> string {
        (File_system::v29())(x)
    }
    pub fn v30() -> Func1<string, string> {
        static v30: OnceInit<Func1<string, string>> = OnceInit::new();
        v30.get_or_init(|| Func1::new(move |v: string| File_system::closure59((), v)))
            .clone()
    }
    pub fn new_file_uri(x: string) -> string {
        (File_system::v30())(x)
    }
    pub fn v31() -> Func0<string> {
        static v31: OnceInit<Func0<string>> = OnceInit::new();
        v31.get_or_init(|| Func0::new(move || File_system::closure60((), ())))
            .clone()
    }
    pub fn get_workspace_root() -> string {
        (File_system::v31())()
    }
    pub fn v32() -> Func1<bool, ()> {
        static v32: OnceInit<Func1<bool, ()>> = OnceInit::new();
        v32.get_or_init(|| Func1::new(move |v: bool| File_system::closure64((), v)))
            .clone()
    }
    pub fn init_trace_file(x: bool) {
        (File_system::v32())(x);
    }
    pub fn v33() -> Func1<string, Func1<string, string>> {
        static v33: OnceInit<Func1<string, Func1<string, string>>> = OnceInit::new();
        v33.get_or_init(|| Func1::new(move |v: string| File_system::closure66((), v)))
            .clone()
    }
    pub fn op_LessDivideGreater(x: string) -> Func1<string, string> {
        (File_system::v33())(x)
    }
    on_startup!(());
}
