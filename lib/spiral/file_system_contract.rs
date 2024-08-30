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
    use fable_library_rust::String_::ofChar;
    use fable_library_rust::String_::padLeft;
    use fable_library_rust::String_::printfn;
    use fable_library_rust::String_::replace;
    use fable_library_rust::String_::split;
    use fable_library_rust::String_::sprintf;
    use fable_library_rust::String_::startsWith;
    use fable_library_rust::String_::string;
    use fable_library_rust::String_::toLower;
    use fable_library_rust::String_::trimEndChars;
    use fable_library_rust::String_::trimStartChars;
    use fable_library_rust::System::Exception;
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
        let v33_1: Result<std::string::String, std::env::VarError> = std::env::var(&*v0_1);
        let v35: bool = true;
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
        let v79: string = string("env!(\"AUTOMATION\")");
        let v80: &str = env!("AUTOMATION");
        let v82: std::string::String = String::from(v80);
        let _v1: (File_system::US2, File_system::US3) = (
            File_system::US2::US2_1,
            if fable_library_rust::String_::fromString(v82) != string("True") {
                File_system::US3::US3_1
            } else {
                File_system::US3::US3_0(near_sdk::env::block_timestamp() as i64)
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
        unbox::<string>(&defaultOf())
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
            let v239: u64 = near_sdk::env::block_timestamp();
            let _v240: LrcPtr<MutCell<Option<File_system::US3>>> =
                refCell(None::<File_system::US3>);
            let v245: () = {
                File_system::closure8(
                    patternInput_2.4.clone(),
                    Func1::new({
                        let _v240 = _v240.clone();
                        move |v: Option<File_system::US3>| File_system::closure7(_v240.clone(), v)
                    }),
                    (),
                );
                ()
            };
            let v260: File_system::US3 = defaultValue(File_system::US3::US3_1, _v240.get().clone());
            let v270: u64 = match &v260 {
                File_system::US3::US3_0(v260_0_0) => {
                    v239 - match &v260 {
                        File_system::US3::US3_0(x) => x.clone(),
                        _ => unreachable!(),
                    } as u64
                }
                _ => v239,
            } / 1000000000_u64;
            let v271: u64 = v270 % 60_u64;
            let v273: u64 = v270 / 60_u64 % 60_u64;
            let v275: u64 = v270 / 3600_u64 % 24_u64;
            let v277: std::string::String = format!("{:02}:{:02}:{:02}", v275, v273, v271);
            let v279: string = fable_library_rust::String_::fromString(v277);
            let v557: string = File_system::method11();
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
            let v582: Array<string> = split(v567.l0.get().clone(), v557, -1_i32, 0_i32);
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
            let v663: &str = inline_colorization::color_bright_blue;
            let v665: &str = &*v625;
            let v667: &str = inline_colorization::color_reset;
            let v669: string = string("format!(\"{v663}{v665}{v667}\")");
            let v670: std::string::String = format!("{v663}{v665}{v667}");
            let v672: string = fable_library_rust::String_::fromString(v670);
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
                        v279,
                        v672,
                        v691,
                        File_system::closure10((), ()),
                        v773
                    ),
                    toArray(empty::<char>()),
                ),
                toArray(ofArray(new_array(&[' ', '/']))),
            );
            near_sdk::log!("{}", v812.clone());
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
            let v240: u64 = near_sdk::env::block_timestamp();
            let _v241: LrcPtr<MutCell<Option<File_system::US3>>> =
                refCell(None::<File_system::US3>);
            let v246: () = {
                File_system::closure8(
                    patternInput_2.4.clone(),
                    Func1::new({
                        let _v241 = _v241.clone();
                        move |v: Option<File_system::US3>| File_system::closure7(_v241.clone(), v)
                    }),
                    (),
                );
                ()
            };
            let v261: File_system::US3 = defaultValue(File_system::US3::US3_1, _v241.get().clone());
            let v271: u64 = match &v261 {
                File_system::US3::US3_0(v261_0_0) => {
                    v240 - match &v261 {
                        File_system::US3::US3_0(x) => x.clone(),
                        _ => unreachable!(),
                    } as u64
                }
                _ => v240,
            } / 1000000000_u64;
            let v272: u64 = v271 % 60_u64;
            let v274: u64 = v271 / 60_u64 % 60_u64;
            let v276: u64 = v271 / 3600_u64 % 24_u64;
            let v278: std::string::String = format!("{:02}:{:02}:{:02}", v276, v274, v272);
            let v280: string = fable_library_rust::String_::fromString(v278);
            let v558: string = File_system::method11();
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
            let v583: Array<string> = split(v568.l0.get().clone(), v558, -1_i32, 0_i32);
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
            let v664: &str = inline_colorization::color_bright_blue;
            let v666: &str = &*v626;
            let v668: &str = inline_colorization::color_reset;
            let v670: string = string("format!(\"{v664}{v666}{v668}\")");
            let v671: std::string::String = format!("{v664}{v666}{v668}");
            let v673: string = fable_library_rust::String_::fromString(v671);
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
                        v280,
                        v673,
                        v692,
                        File_system::closure16((), ()),
                        v807
                    ),
                    toArray(empty::<char>()),
                ),
                toArray(ofArray(new_array(&[' ', '/']))),
            );
            near_sdk::log!("{}", v846.clone());
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
            let v239: u64 = near_sdk::env::block_timestamp();
            let _v240: LrcPtr<MutCell<Option<File_system::US3>>> =
                refCell(None::<File_system::US3>);
            let v245: () = {
                File_system::closure8(
                    patternInput_2.4.clone(),
                    Func1::new({
                        let _v240 = _v240.clone();
                        move |v: Option<File_system::US3>| File_system::closure7(_v240.clone(), v)
                    }),
                    (),
                );
                ()
            };
            let v260: File_system::US3 = defaultValue(File_system::US3::US3_1, _v240.get().clone());
            let v270: u64 = match &v260 {
                File_system::US3::US3_0(v260_0_0) => {
                    v239 - match &v260 {
                        File_system::US3::US3_0(x) => x.clone(),
                        _ => unreachable!(),
                    } as u64
                }
                _ => v239,
            } / 1000000000_u64;
            let v271: u64 = v270 % 60_u64;
            let v273: u64 = v270 / 60_u64 % 60_u64;
            let v275: u64 = v270 / 3600_u64 % 24_u64;
            let v277: std::string::String = format!("{:02}:{:02}:{:02}", v275, v273, v271);
            let v279: string = fable_library_rust::String_::fromString(v277);
            let v557: string = File_system::method11();
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
            let v582: Array<string> = split(v567.l0.get().clone(), v557, -1_i32, 0_i32);
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
                    let v616: string = File_system::method11();
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
                    let v641: Array<string> = split(v626.l0.get().clone(), v616, -1_i32, 0_i32);
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
                            let v675: string = File_system::method11();
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
                                split(v685.l0.get().clone(), v675, -1_i32, 0_i32);
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
            let v785: &str = inline_colorization::color_yellow;
            let v787: &str = &*v747;
            let v789: &str = inline_colorization::color_reset;
            let v791: string = string("format!(\"{v785}{v787}{v789}\")");
            let v792: std::string::String = format!("{v785}{v787}{v789}");
            let v794: string = fable_library_rust::String_::fromString(v792);
            let v813: i64 = (patternInput_2.0.clone()).l0.get().clone();
            let v814: string = File_system::method15(v0_1);
            let v822: string = sprintf!("{:?}", v1_1);
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
                File_system::closure9(v838.clone(), sprintf!("{}", v822), ());
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
                        v279,
                        v794,
                        v813,
                        File_system::closure27((), ()),
                        v917
                    ),
                    toArray(empty::<char>()),
                ),
                toArray(ofArray(new_array(&[' ', '/']))),
            );
            near_sdk::log!("{}", v956.clone());
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
            let v240: u64 = near_sdk::env::block_timestamp();
            let _v241: LrcPtr<MutCell<Option<File_system::US3>>> =
                refCell(None::<File_system::US3>);
            let v246: () = {
                File_system::closure8(
                    patternInput_2.4.clone(),
                    Func1::new({
                        let _v241 = _v241.clone();
                        move |v: Option<File_system::US3>| File_system::closure7(_v241.clone(), v)
                    }),
                    (),
                );
                ()
            };
            let v261: File_system::US3 = defaultValue(File_system::US3::US3_1, _v241.get().clone());
            let v271: u64 = match &v261 {
                File_system::US3::US3_0(v261_0_0) => {
                    v240 - match &v261 {
                        File_system::US3::US3_0(x) => x.clone(),
                        _ => unreachable!(),
                    } as u64
                }
                _ => v240,
            } / 1000000000_u64;
            let v272: u64 = v271 % 60_u64;
            let v274: u64 = v271 / 60_u64 % 60_u64;
            let v276: u64 = v271 / 3600_u64 % 24_u64;
            let v278: std::string::String = format!("{:02}:{:02}:{:02}", v276, v274, v272);
            let v280: string = fable_library_rust::String_::fromString(v278);
            let v558: string = File_system::method11();
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
            let v583: Array<string> = split(v568.l0.get().clone(), v558, -1_i32, 0_i32);
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
                    let v617: string = File_system::method11();
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
                    let v642: Array<string> = split(v627.l0.get().clone(), v617, -1_i32, 0_i32);
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
                            let v676: string = File_system::method11();
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
                                split(v686.l0.get().clone(), v676, -1_i32, 0_i32);
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
            let v786: &str = inline_colorization::color_yellow;
            let v788: &str = &*v748;
            let v790: &str = inline_colorization::color_reset;
            let v792: string = string("format!(\"{v786}{v788}{v790}\")");
            let v793: std::string::String = format!("{v786}{v788}{v790}");
            let v795: string = fable_library_rust::String_::fromString(v793);
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
            let v923: std::string::String = format!("{:#?}", v2_1);
            let v945: () = {
                File_system::closure9(
                    v818.clone(),
                    sprintf!("{}", fable_library_rust::String_::fromString(v923)),
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
                        v280,
                        v795,
                        v814,
                        File_system::closure31((), ()),
                        v957
                    ),
                    toArray(empty::<char>()),
                ),
                toArray(ofArray(new_array(&[' ', '/']))),
            );
            near_sdk::log!("{}", v996.clone());
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
            let v237: u64 = near_sdk::env::block_timestamp();
            let _v238: LrcPtr<MutCell<Option<File_system::US3>>> =
                refCell(None::<File_system::US3>);
            let v243: () = {
                File_system::closure8(
                    patternInput_2.4.clone(),
                    Func1::new({
                        let _v238 = _v238.clone();
                        move |v: Option<File_system::US3>| File_system::closure7(_v238.clone(), v)
                    }),
                    (),
                );
                ()
            };
            let v258: File_system::US3 = defaultValue(File_system::US3::US3_1, _v238.get().clone());
            let v268: u64 = match &v258 {
                File_system::US3::US3_0(v258_0_0) => {
                    v237 - match &v258 {
                        File_system::US3::US3_0(x) => x.clone(),
                        _ => unreachable!(),
                    } as u64
                }
                _ => v237,
            } / 1000000000_u64;
            let v269: u64 = v268 % 60_u64;
            let v271: u64 = v268 / 60_u64 % 60_u64;
            let v273: u64 = v268 / 3600_u64 % 24_u64;
            let v275: std::string::String = format!("{:02}:{:02}:{:02}", v273, v271, v269);
            let v277: string = fable_library_rust::String_::fromString(v275);
            let v557: string = padLeft(toLower(string("Verbose")), 7_i32, ' ');
            let v595: &str = inline_colorization::color_bright_black;
            let v597: &str = &*v557;
            let v599: &str = inline_colorization::color_reset;
            let v601: string = string("format!(\"{v595}{v597}{v599}\")");
            let v602: std::string::String = format!("{v595}{v597}{v599}");
            let v604: string = fable_library_rust::String_::fromString(v602);
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
                        v277,
                        v604,
                        v623,
                        File_system::closure36((), ()),
                        v670
                    ),
                    toArray(empty::<char>()),
                ),
                toArray(ofArray(new_array(&[' ', '/']))),
            );
            near_sdk::log!("{}", v709.clone());
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
            let v238: u64 = near_sdk::env::block_timestamp();
            let _v239: LrcPtr<MutCell<Option<File_system::US3>>> =
                refCell(None::<File_system::US3>);
            let v244: () = {
                File_system::closure8(
                    patternInput_2.4.clone(),
                    Func1::new({
                        let _v239 = _v239.clone();
                        move |v: Option<File_system::US3>| File_system::closure7(_v239.clone(), v)
                    }),
                    (),
                );
                ()
            };
            let v259: File_system::US3 = defaultValue(File_system::US3::US3_1, _v239.get().clone());
            let v269: u64 = match &v259 {
                File_system::US3::US3_0(v259_0_0) => {
                    v238 - match &v259 {
                        File_system::US3::US3_0(x) => x.clone(),
                        _ => unreachable!(),
                    } as u64
                }
                _ => v238,
            } / 1000000000_u64;
            let v270: u64 = v269 % 60_u64;
            let v272: u64 = v269 / 60_u64 % 60_u64;
            let v274: u64 = v269 / 3600_u64 % 24_u64;
            let v276: std::string::String = format!("{:02}:{:02}:{:02}", v274, v272, v270);
            let v278: string = fable_library_rust::String_::fromString(v276);
            let v556: string = File_system::method11();
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
            let v581: Array<string> = split(v566.l0.get().clone(), v556, -1_i32, 0_i32);
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
                    let v615: string = File_system::method11();
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
                    let v640: Array<string> = split(v625.l0.get().clone(), v615, -1_i32, 0_i32);
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
                            let v674: string = File_system::method11();
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
                                split(v684.l0.get().clone(), v674, -1_i32, 0_i32);
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
                                    let v733: string = File_system::method11();
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
                                        split(v743.l0.get().clone(), v733, -1_i32, 0_i32);
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
            let v845: &str = inline_colorization::color_bright_red;
            let v847: &str = &*v807;
            let v849: &str = inline_colorization::color_reset;
            let v851: string = string("format!(\"{v845}{v847}{v849}\")");
            let v852: std::string::String = format!("{v845}{v847}{v849}");
            let v854: string = fable_library_rust::String_::fromString(v852);
            let v873: i64 = (patternInput_2.0.clone()).l0.get().clone();
            let v881: string = sprintf!("{:?}", v0_1);
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
                File_system::closure9(v897.clone(), sprintf!("{}", v881), ());
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
                        v278,
                        v854,
                        v873,
                        File_system::closure38((), ()),
                        v976
                    ),
                    toArray(empty::<char>()),
                ),
                toArray(ofArray(new_array(&[' ', '/']))),
            );
            near_sdk::log!("{}", v1015.clone());
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
            let v239: u64 = near_sdk::env::block_timestamp();
            let _v240: LrcPtr<MutCell<Option<File_system::US3>>> =
                refCell(None::<File_system::US3>);
            let v245: () = {
                File_system::closure8(
                    patternInput_2.4.clone(),
                    Func1::new({
                        let _v240 = _v240.clone();
                        move |v: Option<File_system::US3>| File_system::closure7(_v240.clone(), v)
                    }),
                    (),
                );
                ()
            };
            let v260: File_system::US3 = defaultValue(File_system::US3::US3_1, _v240.get().clone());
            let v270: u64 = match &v260 {
                File_system::US3::US3_0(v260_0_0) => {
                    v239 - match &v260 {
                        File_system::US3::US3_0(x) => x.clone(),
                        _ => unreachable!(),
                    } as u64
                }
                _ => v239,
            } / 1000000000_u64;
            let v271: u64 = v270 % 60_u64;
            let v273: u64 = v270 / 60_u64 % 60_u64;
            let v275: u64 = v270 / 3600_u64 % 24_u64;
            let v277: std::string::String = format!("{:02}:{:02}:{:02}", v275, v273, v271);
            let v279: string = fable_library_rust::String_::fromString(v277);
            let v557: string = File_system::method11();
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
            let v582: Array<string> = split(v567.l0.get().clone(), v557, -1_i32, 0_i32);
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
            let v663: &str = inline_colorization::color_bright_blue;
            let v665: &str = &*v625;
            let v667: &str = inline_colorization::color_reset;
            let v669: string = string("format!(\"{v663}{v665}{v667}\")");
            let v670: std::string::String = format!("{v663}{v665}{v667}");
            let v672: string = fable_library_rust::String_::fromString(v670);
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
                        v279,
                        v672,
                        v691,
                        File_system::closure40((), ()),
                        v772
                    ),
                    toArray(empty::<char>()),
                ),
                toArray(ofArray(new_array(&[' ', '/']))),
            );
            near_sdk::log!("{}", v811.clone());
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
        v0_1: Option<Option<()>>,
        v1_1: Func1<Option<File_system::US11>, LrcPtr<MutCell<Option<File_system::US11>>>>,
        unitVar: (),
    ) {
        {
            let value: LrcPtr<MutCell<Option<File_system::US11>>> = v1_1(match &v0_1 {
                None => None::<File_system::US11>,
                Some(v0_1_0_0) => {
                    let x: Option<()> = v0_1_0_0.clone();
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
        unbox::<Guid>(&defaultOf())
    }
    pub fn method30() -> string {
        unbox::<string>(&defaultOf())
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
        unbox::<string>(&defaultOf())
    }
    pub fn method36() -> string {
        string("CARGO_PKG_NAME")
    }
    pub fn method35() -> string {
        File_system::method2(File_system::method36())
    }
    pub fn method29(v0_1: Guid) -> string {
        unbox::<string>(&defaultOf())
    }
    pub fn method24() -> string {
        unbox::<string>(&defaultOf())
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
            let v239: u64 = near_sdk::env::block_timestamp();
            let _v240: LrcPtr<MutCell<Option<File_system::US3>>> =
                refCell(None::<File_system::US3>);
            let v245: () = {
                File_system::closure8(
                    patternInput_2.4.clone(),
                    Func1::new({
                        let _v240 = _v240.clone();
                        move |v: Option<File_system::US3>| File_system::closure7(_v240.clone(), v)
                    }),
                    (),
                );
                ()
            };
            let v260: File_system::US3 = defaultValue(File_system::US3::US3_1, _v240.get().clone());
            let v270: u64 = match &v260 {
                File_system::US3::US3_0(v260_0_0) => {
                    v239 - match &v260 {
                        File_system::US3::US3_0(x) => x.clone(),
                        _ => unreachable!(),
                    } as u64
                }
                _ => v239,
            } / 1000000000_u64;
            let v271: u64 = v270 % 60_u64;
            let v273: u64 = v270 / 60_u64 % 60_u64;
            let v275: u64 = v270 / 3600_u64 % 24_u64;
            let v277: std::string::String = format!("{:02}:{:02}:{:02}", v275, v273, v271);
            let v279: string = fable_library_rust::String_::fromString(v277);
            let v557: string = File_system::method11();
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
            let v582: Array<string> = split(v567.l0.get().clone(), v557, -1_i32, 0_i32);
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
                    let v616: string = File_system::method11();
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
                    let v641: Array<string> = split(v626.l0.get().clone(), v616, -1_i32, 0_i32);
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
                            let v675: string = File_system::method11();
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
                                split(v685.l0.get().clone(), v675, -1_i32, 0_i32);
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
                                    let v734: string = File_system::method11();
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
                                        split(v744.l0.get().clone(), v734, -1_i32, 0_i32);
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
            let v846: &str = inline_colorization::color_bright_red;
            let v848: &str = &*v808;
            let v850: &str = inline_colorization::color_reset;
            let v852: string = string("format!(\"{v846}{v848}{v850}\")");
            let v853: std::string::String = format!("{v846}{v848}{v850}");
            let v855: string = fable_library_rust::String_::fromString(v853);
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
            let v948: std::string::String = format!("{:#?}", v1_1);
            let v970: () = {
                File_system::closure9(
                    v876.clone(),
                    sprintf!("{}", fable_library_rust::String_::fromString(v948)),
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
                        v279,
                        v855,
                        v874,
                        File_system::closure49((), ()),
                        v982
                    ),
                    toArray(empty::<char>()),
                ),
                toArray(ofArray(new_array(&[' ', '/']))),
            );
            near_sdk::log!("{}", v1021.clone());
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
            let v238: u64 = near_sdk::env::block_timestamp();
            let _v239: LrcPtr<MutCell<Option<File_system::US3>>> =
                refCell(None::<File_system::US3>);
            let v244: () = {
                File_system::closure8(
                    patternInput_2.4.clone(),
                    Func1::new({
                        let _v239 = _v239.clone();
                        move |v: Option<File_system::US3>| File_system::closure7(_v239.clone(), v)
                    }),
                    (),
                );
                ()
            };
            let v259: File_system::US3 = defaultValue(File_system::US3::US3_1, _v239.get().clone());
            let v269: u64 = match &v259 {
                File_system::US3::US3_0(v259_0_0) => {
                    v238 - match &v259 {
                        File_system::US3::US3_0(x) => x.clone(),
                        _ => unreachable!(),
                    } as u64
                }
                _ => v238,
            } / 1000000000_u64;
            let v270: u64 = v269 % 60_u64;
            let v272: u64 = v269 / 60_u64 % 60_u64;
            let v274: u64 = v269 / 3600_u64 % 24_u64;
            let v276: std::string::String = format!("{:02}:{:02}:{:02}", v274, v272, v270);
            let v278: string = fable_library_rust::String_::fromString(v276);
            let v558: string = padLeft(toLower(string("Verbose")), 7_i32, ' ');
            let v596: &str = inline_colorization::color_bright_black;
            let v598: &str = &*v558;
            let v600: &str = inline_colorization::color_reset;
            let v602: string = string("format!(\"{v596}{v598}{v600}\")");
            let v603: std::string::String = format!("{v596}{v598}{v600}");
            let v605: string = fable_library_rust::String_::fromString(v603);
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
                        v278,
                        v605,
                        v624,
                        File_system::closure51((), ()),
                        v671
                    ),
                    toArray(empty::<char>()),
                ),
                toArray(ofArray(new_array(&[' ', '/']))),
            );
            near_sdk::log!("{}", v710.clone());
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
            let v239: u64 = near_sdk::env::block_timestamp();
            let _v240: LrcPtr<MutCell<Option<File_system::US3>>> =
                refCell(None::<File_system::US3>);
            let v245: () = {
                File_system::closure8(
                    patternInput_2.4.clone(),
                    Func1::new({
                        let _v240 = _v240.clone();
                        move |v: Option<File_system::US3>| File_system::closure7(_v240.clone(), v)
                    }),
                    (),
                );
                ()
            };
            let v260: File_system::US3 = defaultValue(File_system::US3::US3_1, _v240.get().clone());
            let v270: u64 = match &v260 {
                File_system::US3::US3_0(v260_0_0) => {
                    v239 - match &v260 {
                        File_system::US3::US3_0(x) => x.clone(),
                        _ => unreachable!(),
                    } as u64
                }
                _ => v239,
            } / 1000000000_u64;
            let v271: u64 = v270 % 60_u64;
            let v273: u64 = v270 / 60_u64 % 60_u64;
            let v275: u64 = v270 / 3600_u64 % 24_u64;
            let v277: std::string::String = format!("{:02}:{:02}:{:02}", v275, v273, v271);
            let v279: string = fable_library_rust::String_::fromString(v277);
            let v557: string = File_system::method11();
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
            let v582: Array<string> = split(v567.l0.get().clone(), v557, -1_i32, 0_i32);
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
            let v663: &str = inline_colorization::color_bright_blue;
            let v665: &str = &*v625;
            let v667: &str = inline_colorization::color_reset;
            let v669: string = string("format!(\"{v663}{v665}{v667}\")");
            let v670: std::string::String = format!("{v663}{v665}{v667}");
            let v672: string = fable_library_rust::String_::fromString(v670);
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
                        v279,
                        v672,
                        v691,
                        File_system::closure54((), ()),
                        v772
                    ),
                    toArray(empty::<char>()),
                ),
                toArray(ofArray(new_array(&[' ', '/']))),
            );
            near_sdk::log!("{}", v811.clone());
            ();
            ((patternInput.1.clone()).l0.get().clone())(v811)
        }
    }
    pub fn closure55(v0_1: string, unitVar: ()) {
        let v8: Arc<Async<i64>> = defaultOf();
        let v31_1: Arc<Async<()>> = defaultOf();
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
            defaultOf::<std::rc::Rc<dyn IDisposable>>(),
            Lrc<dyn IDisposable>,
        )
    }
    pub fn closure44(unitVar: (), unitVar_1: ()) -> (string, LrcPtr<dyn IDisposable>) {
        let v0_1: string = File_system::method24();
        (v0_1.clone(), File_system::method37(v0_1))
    }
    pub fn method44(v0_1: string) -> Guid {
        unbox::<Guid>(&defaultOf())
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
            let v238: u64 = near_sdk::env::block_timestamp();
            let _v239: LrcPtr<MutCell<Option<File_system::US3>>> =
                refCell(None::<File_system::US3>);
            let v244: () = {
                File_system::closure8(
                    patternInput_2.4.clone(),
                    Func1::new({
                        let _v239 = _v239.clone();
                        move |v: Option<File_system::US3>| File_system::closure7(_v239.clone(), v)
                    }),
                    (),
                );
                ()
            };
            let v259: File_system::US3 = defaultValue(File_system::US3::US3_1, _v239.get().clone());
            let v269: u64 = match &v259 {
                File_system::US3::US3_0(v259_0_0) => {
                    v238 - match &v259 {
                        File_system::US3::US3_0(x) => x.clone(),
                        _ => unreachable!(),
                    } as u64
                }
                _ => v238,
            } / 1000000000_u64;
            let v270: u64 = v269 % 60_u64;
            let v272: u64 = v269 / 60_u64 % 60_u64;
            let v274: u64 = v269 / 3600_u64 % 24_u64;
            let v276: std::string::String = format!("{:02}:{:02}:{:02}", v274, v272, v270);
            let v278: string = fable_library_rust::String_::fromString(v276);
            let v556: string = File_system::method11();
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
            let v581: Array<string> = split(v566.l0.get().clone(), v556, -1_i32, 0_i32);
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
                    let v615: string = File_system::method11();
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
                    let v640: Array<string> = split(v625.l0.get().clone(), v615, -1_i32, 0_i32);
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
                            let v674: string = File_system::method11();
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
                                split(v684.l0.get().clone(), v674, -1_i32, 0_i32);
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
            let v784: &str = inline_colorization::color_yellow;
            let v786: &str = &*v746;
            let v788: &str = inline_colorization::color_reset;
            let v790: string = string("format!(\"{v784}{v786}{v788}\")");
            let v791: std::string::String = format!("{v784}{v786}{v788}");
            let v793: string = fable_library_rust::String_::fromString(v791);
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
                        v278,
                        v793,
                        v812,
                        File_system::closure63((), ()),
                        v859
                    ),
                    toArray(empty::<char>()),
                ),
                toArray(ofArray(new_array(&[' ', '/']))),
            );
            near_sdk::log!("{}", v898.clone());
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
