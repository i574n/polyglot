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
    use fable_library_rust::String_::replace;
    use fable_library_rust::String_::sprintf;
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
        let v33: Result<std::string::String, std::env::VarError> = std::env::var(&*v0_1);
        let v35: bool = true;
        let _result = v33.map(|x| {
            //;
            let v37: std::string::String = x;
            let v39: string = fable_library_rust::String_::fromString(v37);
            let v41: bool = true;
            v39
        });
        let v43: Result<string, std::env::VarError> = _result;
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
        string("\u{001b}[0m")
    }
    pub fn method12(v0_1: string) -> string {
        unbox::<string>(&defaultOf())
    }
    pub fn method13() -> string {
        string("")
    }
    pub fn closure9(v0_1: LrcPtr<File_system::Mut4>, v1_1: string, unitVar: ()) {
        let v3: string = append(v0_1.l0.get().clone(), v1_1);
        v0_1.l0.set(v3);
        ()
    }
    pub fn closure10(unitVar: (), unitVar_1: ()) -> string {
        string("file_system.delete_directory_async")
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
        let v23_1: () = {
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
        let v41: File_system::US0 = (patternInput_1.3.clone()).l0.get().clone();
        if if (patternInput_1.2.clone()).l0.get().clone() == false {
            false
        } else {
            1_i32
                >= find(
                    v41,
                    ofSeq(ofList(ofArray(new_array(&[
                        LrcPtr::new((File_system::US0::US0_0, 0_i32)),
                        LrcPtr::new((File_system::US0::US0_1, 1_i32)),
                        LrcPtr::new((File_system::US0::US0_2, 2_i32)),
                        LrcPtr::new((File_system::US0::US0_3, 3_i32)),
                        LrcPtr::new((File_system::US0::US0_4, 4_i32)),
                    ])))),
                )
        } {
            let v49: () = {
                File_system::closure6(patternInput.0.clone(), ());
                ()
            };
            let v51: () = {
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
            let v203: u64 = near_sdk::env::block_timestamp();
            let _v204: LrcPtr<MutCell<Option<File_system::US3>>> =
                refCell(None::<File_system::US3>);
            let v209: () = {
                File_system::closure8(
                    patternInput_2.4.clone(),
                    Func1::new({
                        let _v204 = _v204.clone();
                        move |v: Option<File_system::US3>| File_system::closure7(_v204.clone(), v)
                    }),
                    (),
                );
                ()
            };
            let v222: File_system::US3 = defaultValue(File_system::US3::US3_1, _v204.get().clone());
            let v232: u64 = match &v222 {
                File_system::US3::US3_0(v222_0_0) => {
                    v203 - match &v222 {
                        File_system::US3::US3_0(x) => x.clone(),
                        _ => unreachable!(),
                    } as u64
                }
                _ => v203,
            } / 1000000000_u64;
            let v233: u64 = v232 % 60_u64;
            let v235: u64 = v232 / 60_u64 % 60_u64;
            let v237: u64 = v232 / 3600_u64 % 24_u64;
            let v239: std::string::String = format!("{:02}:{:02}:{:02}", v237, v235, v233);
            let v241: string = fable_library_rust::String_::fromString(v239);
            let v513: string = padLeft(toLower(string("Debug")), 7_i32, ' ');
            let v551: &str = inline_colorization::color_bright_blue;
            let v553: &str = &*v513;
            let v555: &str = inline_colorization::color_reset;
            let v557: string = string("format!(\"{v551}{v553}{v555}\")");
            let v558: std::string::String = format!("{v551}{v553}{v555}");
            let v560: string = fable_library_rust::String_::fromString(v558);
            let v579: i64 = (patternInput_2.0.clone()).l0.get().clone();
            let v580: string = File_system::method12(v0_1);
            let v582: LrcPtr<File_system::Mut4> = LrcPtr::new(File_system::Mut4 {
                l0: MutCell::new(File_system::method13()),
            });
            let v589: () = {
                File_system::closure9(v582.clone(), sprintf!("{}", string("{ ")), ());
                ()
            };
            let v596: () = {
                File_system::closure9(v582.clone(), sprintf!("{}", string("ex")), ());
                ()
            };
            let v603: () = {
                File_system::closure9(v582.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v609: () = {
                File_system::closure9(v582.clone(), sprintf!("{}", v1_1), ());
                ()
            };
            let v616: () = {
                File_system::closure9(v582.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v623: () = {
                File_system::closure9(v582.clone(), sprintf!("{}", string("path")), ());
                ()
            };
            let v629: () = {
                File_system::closure9(v582.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v635: () = {
                File_system::closure9(v582.clone(), sprintf!("{}", v580), ());
                ()
            };
            let v642: () = {
                File_system::closure9(v582.clone(), sprintf!("{}", string(" }")), ());
                ()
            };
            let v643: string = v582.l0.get().clone();
            let v682: string = trimEndChars(
                trimStartChars(
                    sprintf!(
                        "{} {} #{} {} / {}",
                        v241,
                        v560,
                        v579,
                        File_system::closure10((), ()),
                        v643
                    ),
                    toArray(empty::<char>()),
                ),
                toArray(ofArray(new_array(&[' ', '/']))),
            );
            near_sdk::log!("{}", v682.clone());
            ();
            ((patternInput.1.clone()).l0.get().clone())(v682)
        }
    }
    pub fn method5(v0_1: string, v1_1: i64) -> Arc<Async<i64>> {
        defaultOf()
    }
    pub fn closure4(unitVar: (), v0_1: string) -> Arc<Async<i64>> {
        defaultOf()
    }
    pub fn closure14(unitVar: (), unitVar_1: ()) -> string {
        string("file_system.wait_for_file_access")
    }
    pub fn closure13(v0_1: string, v1_1: i64, v2_1: string, unitVar: ()) {
        fn v4() {
            File_system::closure0((), ());
        }
        let v5_1: () = {
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
        let v24: () = {
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
        let v42: File_system::US0 = (patternInput_1.3.clone()).l0.get().clone();
        if if (patternInput_1.2.clone()).l0.get().clone() == false {
            false
        } else {
            1_i32
                >= find(
                    v42,
                    ofSeq(ofList(ofArray(new_array(&[
                        LrcPtr::new((File_system::US0::US0_0, 0_i32)),
                        LrcPtr::new((File_system::US0::US0_1, 1_i32)),
                        LrcPtr::new((File_system::US0::US0_2, 2_i32)),
                        LrcPtr::new((File_system::US0::US0_3, 3_i32)),
                        LrcPtr::new((File_system::US0::US0_4, 4_i32)),
                    ])))),
                )
        } {
            let v50: () = {
                File_system::closure6(patternInput.0.clone(), ());
                ()
            };
            let v52: () = {
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
            let v204: u64 = near_sdk::env::block_timestamp();
            let _v205: LrcPtr<MutCell<Option<File_system::US3>>> =
                refCell(None::<File_system::US3>);
            let v210: () = {
                File_system::closure8(
                    patternInput_2.4.clone(),
                    Func1::new({
                        let _v205 = _v205.clone();
                        move |v: Option<File_system::US3>| File_system::closure7(_v205.clone(), v)
                    }),
                    (),
                );
                ()
            };
            let v223: File_system::US3 = defaultValue(File_system::US3::US3_1, _v205.get().clone());
            let v233: u64 = match &v223 {
                File_system::US3::US3_0(v223_0_0) => {
                    v204 - match &v223 {
                        File_system::US3::US3_0(x) => x.clone(),
                        _ => unreachable!(),
                    } as u64
                }
                _ => v204,
            } / 1000000000_u64;
            let v234: u64 = v233 % 60_u64;
            let v236: u64 = v233 / 60_u64 % 60_u64;
            let v238: u64 = v233 / 3600_u64 % 24_u64;
            let v240: std::string::String = format!("{:02}:{:02}:{:02}", v238, v236, v234);
            let v242: string = fable_library_rust::String_::fromString(v240);
            let v514: string = padLeft(toLower(string("Debug")), 7_i32, ' ');
            let v552: &str = inline_colorization::color_bright_blue;
            let v554: &str = &*v514;
            let v556: &str = inline_colorization::color_reset;
            let v558: string = string("format!(\"{v552}{v554}{v556}\")");
            let v559: std::string::String = format!("{v552}{v554}{v556}");
            let v561: string = fable_library_rust::String_::fromString(v559);
            let v580: i64 = (patternInput_2.0.clone()).l0.get().clone();
            let v581: string = File_system::method12(v0_1);
            let v583: LrcPtr<File_system::Mut4> = LrcPtr::new(File_system::Mut4 {
                l0: MutCell::new(File_system::method13()),
            });
            let v590: () = {
                File_system::closure9(v583.clone(), sprintf!("{}", string("{ ")), ());
                ()
            };
            let v597: () = {
                File_system::closure9(v583.clone(), sprintf!("{}", string("path")), ());
                ()
            };
            let v604: () = {
                File_system::closure9(v583.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v610: () = {
                File_system::closure9(v583.clone(), sprintf!("{}", v581), ());
                ()
            };
            let v617: () = {
                File_system::closure9(v583.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v624: () = {
                File_system::closure9(v583.clone(), sprintf!("{}", string("retry")), ());
                ()
            };
            let v630: () = {
                File_system::closure9(v583.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v636: () = {
                File_system::closure9(v583.clone(), sprintf!("{}", v1_1), ());
                ()
            };
            let v642: () = {
                File_system::closure9(v583.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v649: () = {
                File_system::closure9(v583.clone(), sprintf!("{}", string("ex")), ());
                ()
            };
            let v655: () = {
                File_system::closure9(v583.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v661: () = {
                File_system::closure9(v583.clone(), sprintf!("{}", v2_1), ());
                ()
            };
            let v668: () = {
                File_system::closure9(v583.clone(), sprintf!("{}", string(" }")), ());
                ()
            };
            let v669: string = v583.l0.get().clone();
            let v708: string = trimEndChars(
                trimStartChars(
                    sprintf!(
                        "{} {} #{} {} / {}",
                        v242,
                        v561,
                        v580,
                        File_system::closure14((), ()),
                        v669
                    ),
                    toArray(empty::<char>()),
                ),
                toArray(ofArray(new_array(&[' ', '/']))),
            );
            near_sdk::log!("{}", v708.clone());
            ();
            ((patternInput.1.clone()).l0.get().clone())(v708)
        }
    }
    pub fn method14(
        v0_1: string,
        v1_1: File_system::US8,
        v2_1: File_system::US7,
        v3: i64,
    ) -> Arc<Async<i64>> {
        defaultOf()
    }
    pub fn closure12(v0_1: File_system::US6, v1_1: string) -> Arc<Async<i64>> {
        defaultOf()
    }
    pub fn closure11(unitVar: (), v0_1: File_system::US6) -> Func1<string, Arc<Async<i64>>> {
        Func1::new({
            let v0_1 = v0_1.clone();
            move |v: string| File_system::closure12(v0_1.clone(), v)
        })
    }
    pub fn method15(v0_1: string, v1_1: i64) -> Arc<Async<i64>> {
        defaultOf()
    }
    pub fn closure15(unitVar: (), v0_1: string) -> Arc<Async<i64>> {
        defaultOf()
    }
    pub fn closure16(unitVar: (), v0_1: string) -> Arc<Async<string>> {
        defaultOf()
    }
    pub fn method17(v0_1: string) -> bool {
        unbox::<bool>(&defaultOf())
    }
    pub fn method18(v0_1: Vec<u8>) -> Vec<u8> {
        v0_1
    }
    pub fn method16(v0_1: string, v1_1: string) -> bool {
        unbox::<bool>(&defaultOf())
    }
    pub fn closure18(v0_1: string, v1_1: string) -> bool {
        File_system::method16(v0_1, v1_1)
    }
    pub fn closure17(unitVar: (), v0_1: string) -> Func1<string, bool> {
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
    pub fn closure22(v0_1: string, v1_1: string) -> Arc<Async<()>> {
        defaultOf()
    }
    pub fn closure21(unitVar: (), v0_1: string) -> Func1<string, Arc<Async<()>>> {
        Func1::new({
            let v0_1 = v0_1.clone();
            move |v: string| File_system::closure22(v0_1.clone(), v)
        })
    }
    pub fn closure25(unitVar: (), unitVar_1: ()) -> string {
        string("delete_file_async")
    }
    pub fn closure24(v0_1: string, v1_1: LrcPtr<Exception>, unitVar: ()) {
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
        let v23_1: () = {
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
        let v41: File_system::US0 = (patternInput_1.3.clone()).l0.get().clone();
        if if (patternInput_1.2.clone()).l0.get().clone() == false {
            false
        } else {
            3_i32
                >= find(
                    v41,
                    ofSeq(ofList(ofArray(new_array(&[
                        LrcPtr::new((File_system::US0::US0_0, 0_i32)),
                        LrcPtr::new((File_system::US0::US0_1, 1_i32)),
                        LrcPtr::new((File_system::US0::US0_2, 2_i32)),
                        LrcPtr::new((File_system::US0::US0_3, 3_i32)),
                        LrcPtr::new((File_system::US0::US0_4, 4_i32)),
                    ])))),
                )
        } {
            let v49: () = {
                File_system::closure6(patternInput.0.clone(), ());
                ()
            };
            let v51: () = {
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
            let v203: u64 = near_sdk::env::block_timestamp();
            let _v204: LrcPtr<MutCell<Option<File_system::US3>>> =
                refCell(None::<File_system::US3>);
            let v209: () = {
                File_system::closure8(
                    patternInput_2.4.clone(),
                    Func1::new({
                        let _v204 = _v204.clone();
                        move |v: Option<File_system::US3>| File_system::closure7(_v204.clone(), v)
                    }),
                    (),
                );
                ()
            };
            let v222: File_system::US3 = defaultValue(File_system::US3::US3_1, _v204.get().clone());
            let v232: u64 = match &v222 {
                File_system::US3::US3_0(v222_0_0) => {
                    v203 - match &v222 {
                        File_system::US3::US3_0(x) => x.clone(),
                        _ => unreachable!(),
                    } as u64
                }
                _ => v203,
            } / 1000000000_u64;
            let v233: u64 = v232 % 60_u64;
            let v235: u64 = v232 / 60_u64 % 60_u64;
            let v237: u64 = v232 / 3600_u64 % 24_u64;
            let v239: std::string::String = format!("{:02}:{:02}:{:02}", v237, v235, v233);
            let v241: string = fable_library_rust::String_::fromString(v239);
            let v513: string = padLeft(toLower(string("Warning")), 7_i32, ' ');
            let v551: &str = inline_colorization::color_yellow;
            let v553: &str = &*v513;
            let v555: &str = inline_colorization::color_reset;
            let v557: string = string("format!(\"{v551}{v553}{v555}\")");
            let v558: std::string::String = format!("{v551}{v553}{v555}");
            let v560: string = fable_library_rust::String_::fromString(v558);
            let v579: i64 = (patternInput_2.0.clone()).l0.get().clone();
            let v580: string = File_system::method12(v0_1);
            let v588: string = sprintf!("{:?}", v1_1);
            let v604: LrcPtr<File_system::Mut4> = LrcPtr::new(File_system::Mut4 {
                l0: MutCell::new(File_system::method13()),
            });
            let v611: () = {
                File_system::closure9(v604.clone(), sprintf!("{}", string("{ ")), ());
                ()
            };
            let v618: () = {
                File_system::closure9(v604.clone(), sprintf!("{}", string("path")), ());
                ()
            };
            let v625: () = {
                File_system::closure9(v604.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v631: () = {
                File_system::closure9(v604.clone(), sprintf!("{}", v580), ());
                ()
            };
            let v638: () = {
                File_system::closure9(v604.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v645: () = {
                File_system::closure9(v604.clone(), sprintf!("{}", string("ex")), ());
                ()
            };
            let v651: () = {
                File_system::closure9(v604.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v657: () = {
                File_system::closure9(v604.clone(), sprintf!("{}", v588), ());
                ()
            };
            let v664: () = {
                File_system::closure9(v604.clone(), sprintf!("{}", string(" }")), ());
                ()
            };
            let v665: string = v604.l0.get().clone();
            let v704: string = trimEndChars(
                trimStartChars(
                    sprintf!(
                        "{} {} #{} {} / {}",
                        v241,
                        v560,
                        v579,
                        File_system::closure25((), ()),
                        v665
                    ),
                    toArray(empty::<char>()),
                ),
                toArray(ofArray(new_array(&[' ', '/']))),
            );
            near_sdk::log!("{}", v704.clone());
            ();
            ((patternInput.1.clone()).l0.get().clone())(v704)
        }
    }
    pub fn method19(v0_1: string, v1_1: i64) -> Arc<Async<i64>> {
        defaultOf()
    }
    pub fn closure23(unitVar: (), v0_1: string) -> Arc<Async<i64>> {
        defaultOf()
    }
    pub fn closure29(unitVar: (), unitVar_1: ()) -> string {
        string("move_file_async")
    }
    pub fn closure28(v0_1: string, v1_1: string, v2_1: LrcPtr<Exception>, unitVar: ()) {
        fn v4() {
            File_system::closure0((), ());
        }
        let v5_1: () = {
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
        let v24: () = {
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
        let v42: File_system::US0 = (patternInput_1.3.clone()).l0.get().clone();
        if if (patternInput_1.2.clone()).l0.get().clone() == false {
            false
        } else {
            3_i32
                >= find(
                    v42,
                    ofSeq(ofList(ofArray(new_array(&[
                        LrcPtr::new((File_system::US0::US0_0, 0_i32)),
                        LrcPtr::new((File_system::US0::US0_1, 1_i32)),
                        LrcPtr::new((File_system::US0::US0_2, 2_i32)),
                        LrcPtr::new((File_system::US0::US0_3, 3_i32)),
                        LrcPtr::new((File_system::US0::US0_4, 4_i32)),
                    ])))),
                )
        } {
            let v50: () = {
                File_system::closure6(patternInput.0.clone(), ());
                ()
            };
            let v52: () = {
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
            let v204: u64 = near_sdk::env::block_timestamp();
            let _v205: LrcPtr<MutCell<Option<File_system::US3>>> =
                refCell(None::<File_system::US3>);
            let v210: () = {
                File_system::closure8(
                    patternInput_2.4.clone(),
                    Func1::new({
                        let _v205 = _v205.clone();
                        move |v: Option<File_system::US3>| File_system::closure7(_v205.clone(), v)
                    }),
                    (),
                );
                ()
            };
            let v223: File_system::US3 = defaultValue(File_system::US3::US3_1, _v205.get().clone());
            let v233: u64 = match &v223 {
                File_system::US3::US3_0(v223_0_0) => {
                    v204 - match &v223 {
                        File_system::US3::US3_0(x) => x.clone(),
                        _ => unreachable!(),
                    } as u64
                }
                _ => v204,
            } / 1000000000_u64;
            let v234: u64 = v233 % 60_u64;
            let v236: u64 = v233 / 60_u64 % 60_u64;
            let v238: u64 = v233 / 3600_u64 % 24_u64;
            let v240: std::string::String = format!("{:02}:{:02}:{:02}", v238, v236, v234);
            let v242: string = fable_library_rust::String_::fromString(v240);
            let v514: string = padLeft(toLower(string("Warning")), 7_i32, ' ');
            let v552: &str = inline_colorization::color_yellow;
            let v554: &str = &*v514;
            let v556: &str = inline_colorization::color_reset;
            let v558: string = string("format!(\"{v552}{v554}{v556}\")");
            let v559: std::string::String = format!("{v552}{v554}{v556}");
            let v561: string = fable_library_rust::String_::fromString(v559);
            let v580: i64 = (patternInput_2.0.clone()).l0.get().clone();
            let v581: string = File_system::method12(v1_1);
            let v582: string = File_system::method12(v0_1);
            let v584: LrcPtr<File_system::Mut4> = LrcPtr::new(File_system::Mut4 {
                l0: MutCell::new(File_system::method13()),
            });
            let v591: () = {
                File_system::closure9(v584.clone(), sprintf!("{}", string("{ ")), ());
                ()
            };
            let v598: () = {
                File_system::closure9(v584.clone(), sprintf!("{}", string("old_path")), ());
                ()
            };
            let v605: () = {
                File_system::closure9(v584.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v611: () = {
                File_system::closure9(v584.clone(), sprintf!("{}", v581), ());
                ()
            };
            let v618: () = {
                File_system::closure9(v584.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v625: () = {
                File_system::closure9(v584.clone(), sprintf!("{}", string("new_path")), ());
                ()
            };
            let v631: () = {
                File_system::closure9(v584.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v637: () = {
                File_system::closure9(v584.clone(), sprintf!("{}", v582), ());
                ()
            };
            let v643: () = {
                File_system::closure9(v584.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v650: () = {
                File_system::closure9(v584.clone(), sprintf!("{}", string("ex")), ());
                ()
            };
            let v656: () = {
                File_system::closure9(v584.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v667: std::string::String = format!("{:#?}", v2_1);
            let v689: () = {
                File_system::closure9(
                    v584.clone(),
                    sprintf!("{}", fable_library_rust::String_::fromString(v667)),
                    (),
                );
                ()
            };
            let v696: () = {
                File_system::closure9(v584.clone(), sprintf!("{}", string(" }")), ());
                ()
            };
            let v697: string = v584.l0.get().clone();
            let v736: string = trimEndChars(
                trimStartChars(
                    sprintf!(
                        "{} {} #{} {} / {}",
                        v242,
                        v561,
                        v580,
                        File_system::closure29((), ()),
                        v697
                    ),
                    toArray(empty::<char>()),
                ),
                toArray(ofArray(new_array(&[' ', '/']))),
            );
            near_sdk::log!("{}", v736.clone());
            ();
            ((patternInput.1.clone()).l0.get().clone())(v736)
        }
    }
    pub fn method20(v0_1: string, v1_1: string, v2_1: i64) -> Arc<Async<i64>> {
        defaultOf()
    }
    pub fn closure27(v0_1: string, v1_1: string) -> Arc<Async<i64>> {
        defaultOf()
    }
    pub fn closure26(unitVar: (), v0_1: string) -> Func1<string, Arc<Async<i64>>> {
        Func1::new({
            let v0_1 = v0_1.clone();
            move |v: string| File_system::closure27(v0_1.clone(), v)
        })
    }
    pub fn closure31(unitVar: (), v0_1: i64) -> File_system::US9 {
        File_system::US9::US9_0(v0_1)
    }
    pub fn closure32(unitVar: (), v0_1: LrcPtr<Exception>) -> File_system::US9 {
        File_system::US9::US9_1(v0_1)
    }
    pub fn closure34(unitVar: (), unitVar_1: ()) -> string {
        string("async.run_with_timeout_async")
    }
    pub fn closure33(unitVar: (), unitVar_1: ()) {
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
        let v21_1: () = {
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
        let v39: File_system::US0 = (patternInput_1.3.clone()).l0.get().clone();
        if if (patternInput_1.2.clone()).l0.get().clone() == false {
            false
        } else {
            0_i32
                >= find(
                    v39,
                    ofSeq(ofList(ofArray(new_array(&[
                        LrcPtr::new((File_system::US0::US0_0, 0_i32)),
                        LrcPtr::new((File_system::US0::US0_1, 1_i32)),
                        LrcPtr::new((File_system::US0::US0_2, 2_i32)),
                        LrcPtr::new((File_system::US0::US0_3, 3_i32)),
                        LrcPtr::new((File_system::US0::US0_4, 4_i32)),
                    ])))),
                )
        } {
            let v47: () = {
                File_system::closure6(patternInput.0.clone(), ());
                ()
            };
            let v49: () = {
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
            let v201: u64 = near_sdk::env::block_timestamp();
            let _v202: LrcPtr<MutCell<Option<File_system::US3>>> =
                refCell(None::<File_system::US3>);
            let v207: () = {
                File_system::closure8(
                    patternInput_2.4.clone(),
                    Func1::new({
                        let _v202 = _v202.clone();
                        move |v: Option<File_system::US3>| File_system::closure7(_v202.clone(), v)
                    }),
                    (),
                );
                ()
            };
            let v220: File_system::US3 = defaultValue(File_system::US3::US3_1, _v202.get().clone());
            let v230: u64 = match &v220 {
                File_system::US3::US3_0(v220_0_0) => {
                    v201 - match &v220 {
                        File_system::US3::US3_0(x) => x.clone(),
                        _ => unreachable!(),
                    } as u64
                }
                _ => v201,
            } / 1000000000_u64;
            let v231: u64 = v230 % 60_u64;
            let v233: u64 = v230 / 60_u64 % 60_u64;
            let v235: u64 = v230 / 3600_u64 % 24_u64;
            let v237: std::string::String = format!("{:02}:{:02}:{:02}", v235, v233, v231);
            let v239: string = fable_library_rust::String_::fromString(v237);
            let v511: string = padLeft(toLower(string("Verbose")), 7_i32, ' ');
            let v549: &str = inline_colorization::color_bright_black;
            let v551: &str = &*v511;
            let v553: &str = inline_colorization::color_reset;
            let v555: string = string("format!(\"{v549}{v551}{v553}\")");
            let v556: std::string::String = format!("{v549}{v551}{v553}");
            let v558: string = fable_library_rust::String_::fromString(v556);
            let v577: i64 = (patternInput_2.0.clone()).l0.get().clone();
            let v579: LrcPtr<File_system::Mut4> = LrcPtr::new(File_system::Mut4 {
                l0: MutCell::new(File_system::method13()),
            });
            let v586: () = {
                File_system::closure9(v579.clone(), sprintf!("{}", string("{ ")), ());
                ()
            };
            let v593: () = {
                File_system::closure9(v579.clone(), sprintf!("{}", string("timeout")), ());
                ()
            };
            let v600: () = {
                File_system::closure9(v579.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v606: () = {
                File_system::closure9(v579.clone(), sprintf!("{}", 1000_i32), ());
                ()
            };
            let v613: () = {
                File_system::closure9(v579.clone(), sprintf!("{}", string(" }")), ());
                ()
            };
            let v614: string = v579.l0.get().clone();
            let v653: string = trimEndChars(
                trimStartChars(
                    sprintf!(
                        "{} {} #{} {} / {}",
                        v239,
                        v558,
                        v577,
                        File_system::closure34((), ()),
                        v614
                    ),
                    toArray(empty::<char>()),
                ),
                toArray(ofArray(new_array(&[' ', '/']))),
            );
            near_sdk::log!("{}", v653.clone());
            ();
            ((patternInput.1.clone()).l0.get().clone())(v653)
        }
    }
    pub fn closure36(unitVar: (), unitVar_1: ()) -> string {
        string("async.run_with_timeout_async**")
    }
    pub fn closure35(v0_1: LrcPtr<Exception>, unitVar: ()) {
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
        let v22_1: () = {
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
        let v40: File_system::US0 = (patternInput_1.3.clone()).l0.get().clone();
        if if (patternInput_1.2.clone()).l0.get().clone() == false {
            false
        } else {
            4_i32
                >= find(
                    v40,
                    ofSeq(ofList(ofArray(new_array(&[
                        LrcPtr::new((File_system::US0::US0_0, 0_i32)),
                        LrcPtr::new((File_system::US0::US0_1, 1_i32)),
                        LrcPtr::new((File_system::US0::US0_2, 2_i32)),
                        LrcPtr::new((File_system::US0::US0_3, 3_i32)),
                        LrcPtr::new((File_system::US0::US0_4, 4_i32)),
                    ])))),
                )
        } {
            let v48: () = {
                File_system::closure6(patternInput.0.clone(), ());
                ()
            };
            let v50: () = {
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
            let v202: u64 = near_sdk::env::block_timestamp();
            let _v203: LrcPtr<MutCell<Option<File_system::US3>>> =
                refCell(None::<File_system::US3>);
            let v208: () = {
                File_system::closure8(
                    patternInput_2.4.clone(),
                    Func1::new({
                        let _v203 = _v203.clone();
                        move |v: Option<File_system::US3>| File_system::closure7(_v203.clone(), v)
                    }),
                    (),
                );
                ()
            };
            let v221: File_system::US3 = defaultValue(File_system::US3::US3_1, _v203.get().clone());
            let v231: u64 = match &v221 {
                File_system::US3::US3_0(v221_0_0) => {
                    v202 - match &v221 {
                        File_system::US3::US3_0(x) => x.clone(),
                        _ => unreachable!(),
                    } as u64
                }
                _ => v202,
            } / 1000000000_u64;
            let v232: u64 = v231 % 60_u64;
            let v234: u64 = v231 / 60_u64 % 60_u64;
            let v236: u64 = v231 / 3600_u64 % 24_u64;
            let v238: std::string::String = format!("{:02}:{:02}:{:02}", v236, v234, v232);
            let v240: string = fable_library_rust::String_::fromString(v238);
            let v512: string = padLeft(toLower(string("Critical")), 7_i32, ' ');
            let v550: &str = inline_colorization::color_bright_red;
            let v552: &str = &*v512;
            let v554: &str = inline_colorization::color_reset;
            let v556: string = string("format!(\"{v550}{v552}{v554}\")");
            let v557: std::string::String = format!("{v550}{v552}{v554}");
            let v559: string = fable_library_rust::String_::fromString(v557);
            let v578: i64 = (patternInput_2.0.clone()).l0.get().clone();
            let v586: string = sprintf!("{:?}", v0_1);
            let v602: LrcPtr<File_system::Mut4> = LrcPtr::new(File_system::Mut4 {
                l0: MutCell::new(File_system::method13()),
            });
            let v609: () = {
                File_system::closure9(v602.clone(), sprintf!("{}", string("{ ")), ());
                ()
            };
            let v616: () = {
                File_system::closure9(v602.clone(), sprintf!("{}", string("timeout")), ());
                ()
            };
            let v623: () = {
                File_system::closure9(v602.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v629: () = {
                File_system::closure9(v602.clone(), sprintf!("{}", 1000_i32), ());
                ()
            };
            let v636: () = {
                File_system::closure9(v602.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v643: () = {
                File_system::closure9(v602.clone(), sprintf!("{}", string("ex")), ());
                ()
            };
            let v649: () = {
                File_system::closure9(v602.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v655: () = {
                File_system::closure9(v602.clone(), sprintf!("{}", v586), ());
                ()
            };
            let v662: () = {
                File_system::closure9(v602.clone(), sprintf!("{}", string(" }")), ());
                ()
            };
            let v663: string = v602.l0.get().clone();
            let v702: string = trimEndChars(
                trimStartChars(
                    sprintf!(
                        "{} {} #{} {} / {}",
                        v240,
                        v559,
                        v578,
                        File_system::closure36((), ()),
                        v663
                    ),
                    toArray(empty::<char>()),
                ),
                toArray(ofArray(new_array(&[' ', '/']))),
            );
            near_sdk::log!("{}", v702.clone());
            ();
            ((patternInput.1.clone()).l0.get().clone())(v702)
        }
    }
    pub fn closure38(unitVar: (), unitVar_1: ()) -> string {
        string("read_all_text_retry_async")
    }
    pub fn closure37(v0_1: i64, v1_1: string, unitVar: ()) {
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
        let v23_1: () = {
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
        let v41: File_system::US0 = (patternInput_1.3.clone()).l0.get().clone();
        if if (patternInput_1.2.clone()).l0.get().clone() == false {
            false
        } else {
            1_i32
                >= find(
                    v41,
                    ofSeq(ofList(ofArray(new_array(&[
                        LrcPtr::new((File_system::US0::US0_0, 0_i32)),
                        LrcPtr::new((File_system::US0::US0_1, 1_i32)),
                        LrcPtr::new((File_system::US0::US0_2, 2_i32)),
                        LrcPtr::new((File_system::US0::US0_3, 3_i32)),
                        LrcPtr::new((File_system::US0::US0_4, 4_i32)),
                    ])))),
                )
        } {
            let v49: () = {
                File_system::closure6(patternInput.0.clone(), ());
                ()
            };
            let v51: () = {
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
            let v203: u64 = near_sdk::env::block_timestamp();
            let _v204: LrcPtr<MutCell<Option<File_system::US3>>> =
                refCell(None::<File_system::US3>);
            let v209: () = {
                File_system::closure8(
                    patternInput_2.4.clone(),
                    Func1::new({
                        let _v204 = _v204.clone();
                        move |v: Option<File_system::US3>| File_system::closure7(_v204.clone(), v)
                    }),
                    (),
                );
                ()
            };
            let v222: File_system::US3 = defaultValue(File_system::US3::US3_1, _v204.get().clone());
            let v232: u64 = match &v222 {
                File_system::US3::US3_0(v222_0_0) => {
                    v203 - match &v222 {
                        File_system::US3::US3_0(x) => x.clone(),
                        _ => unreachable!(),
                    } as u64
                }
                _ => v203,
            } / 1000000000_u64;
            let v233: u64 = v232 % 60_u64;
            let v235: u64 = v232 / 60_u64 % 60_u64;
            let v237: u64 = v232 / 3600_u64 % 24_u64;
            let v239: std::string::String = format!("{:02}:{:02}:{:02}", v237, v235, v233);
            let v241: string = fable_library_rust::String_::fromString(v239);
            let v513: string = padLeft(toLower(string("Debug")), 7_i32, ' ');
            let v551: &str = inline_colorization::color_bright_blue;
            let v553: &str = &*v513;
            let v555: &str = inline_colorization::color_reset;
            let v557: string = string("format!(\"{v551}{v553}{v555}\")");
            let v558: std::string::String = format!("{v551}{v553}{v555}");
            let v560: string = fable_library_rust::String_::fromString(v558);
            let v579: i64 = (patternInput_2.0.clone()).l0.get().clone();
            let v581: LrcPtr<File_system::Mut4> = LrcPtr::new(File_system::Mut4 {
                l0: MutCell::new(File_system::method13()),
            });
            let v588: () = {
                File_system::closure9(v581.clone(), sprintf!("{}", string("{ ")), ());
                ()
            };
            let v595: () = {
                File_system::closure9(v581.clone(), sprintf!("{}", string("retry")), ());
                ()
            };
            let v602: () = {
                File_system::closure9(v581.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v608: () = {
                File_system::closure9(v581.clone(), sprintf!("{}", v0_1), ());
                ()
            };
            let v615: () = {
                File_system::closure9(v581.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v622: () = {
                File_system::closure9(v581.clone(), sprintf!("{}", string("ex")), ());
                ()
            };
            let v628: () = {
                File_system::closure9(v581.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v634: () = {
                File_system::closure9(v581.clone(), sprintf!("{}", v1_1), ());
                ()
            };
            let v641: () = {
                File_system::closure9(v581.clone(), sprintf!("{}", string(" }")), ());
                ()
            };
            let v642: string = v581.l0.get().clone();
            let v681: string = trimEndChars(
                trimStartChars(
                    sprintf!(
                        "{} {} #{} {} / {}",
                        v241,
                        v560,
                        v579,
                        File_system::closure38((), ()),
                        v642
                    ),
                    toArray(empty::<char>()),
                ),
                toArray(ofArray(new_array(&[' ', '/']))),
            );
            near_sdk::log!("{}", v681.clone());
            ();
            ((patternInput.1.clone()).l0.get().clone())(v681)
        }
    }
    pub fn method21(v0_1: string, v1_1: i64) -> Arc<Async<Option<string>>> {
        defaultOf()
    }
    pub fn closure30(unitVar: (), v0_1: string) -> Arc<Async<Option<string>>> {
        defaultOf()
    }
    pub fn closure40(
        v0_1: LrcPtr<MutCell<Option<File_system::US11>>>,
        v1_1: Option<File_system::US11>,
    ) -> LrcPtr<MutCell<Option<File_system::US11>>> {
        v0_1.set(v1_1);
        v0_1
    }
    pub fn closure41(
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
    pub fn method24() -> string {
        string("hh:mm")
    }
    pub fn method25() -> string {
        string("yyyyMMdd-HHmm-ssff-ffff-f")
    }
    pub fn method26() -> string {
        string("hhmm")
    }
    pub fn method23(v0_1: Guid, v1_1: DateTime) -> Guid {
        unbox::<Guid>(&defaultOf())
    }
    pub fn method28() -> string {
        unbox::<string>(&defaultOf())
    }
    pub fn method29() -> string {
        string("!create_temp_path_")
    }
    pub fn method32(v0_1: string) -> string {
        v0_1
    }
    pub fn method31(v0_1: string, v1_1: string) -> (string, string) {
        (v1_1, File_system::method32(v0_1))
    }
    pub fn method30(v0_1: string, v1_1: string) -> string {
        unbox::<string>(&defaultOf())
    }
    pub fn method34() -> string {
        string("CARGO_PKG_NAME")
    }
    pub fn method33() -> string {
        File_system::method2(File_system::method34())
    }
    pub fn method27(v0_1: Guid) -> string {
        unbox::<string>(&defaultOf())
    }
    pub fn method22() -> string {
        unbox::<string>(&defaultOf())
    }
    pub fn closure39(unitVar: (), unitVar_1: ()) -> string {
        File_system::method22()
    }
    pub fn method36(v0_1: string) -> string {
        v0_1
    }
    pub fn closure43(unitVar: (), v0_1: std::io::Error) -> std::string::String {
        format!("{}", v0_1)
    }
    pub fn method37() -> Func1<std::io::Error, std::string::String> {
        Func1::new(move |v: std::io::Error| File_system::closure43((), v))
    }
    pub fn closure44(unitVar: (), unitVar_1: ()) -> File_system::US12 {
        File_system::US12::US12_0
    }
    pub fn closure45(unitVar: (), v0_1: std::string::String) -> File_system::US12 {
        File_system::US12::US12_1(v0_1)
    }
    pub fn closure47(unitVar: (), unitVar_1: ()) -> string {
        string("file_system.create_dir")
    }
    pub fn closure46(v0_1: string, v1_1: std::string::String, unitVar: ()) {
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
        let v23_1: () = {
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
        let v41: File_system::US0 = (patternInput_1.3.clone()).l0.get().clone();
        if if (patternInput_1.2.clone()).l0.get().clone() == false {
            false
        } else {
            4_i32
                >= find(
                    v41,
                    ofSeq(ofList(ofArray(new_array(&[
                        LrcPtr::new((File_system::US0::US0_0, 0_i32)),
                        LrcPtr::new((File_system::US0::US0_1, 1_i32)),
                        LrcPtr::new((File_system::US0::US0_2, 2_i32)),
                        LrcPtr::new((File_system::US0::US0_3, 3_i32)),
                        LrcPtr::new((File_system::US0::US0_4, 4_i32)),
                    ])))),
                )
        } {
            let v49: () = {
                File_system::closure6(patternInput.0.clone(), ());
                ()
            };
            let v51: () = {
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
            let v203: u64 = near_sdk::env::block_timestamp();
            let _v204: LrcPtr<MutCell<Option<File_system::US3>>> =
                refCell(None::<File_system::US3>);
            let v209: () = {
                File_system::closure8(
                    patternInput_2.4.clone(),
                    Func1::new({
                        let _v204 = _v204.clone();
                        move |v: Option<File_system::US3>| File_system::closure7(_v204.clone(), v)
                    }),
                    (),
                );
                ()
            };
            let v222: File_system::US3 = defaultValue(File_system::US3::US3_1, _v204.get().clone());
            let v232: u64 = match &v222 {
                File_system::US3::US3_0(v222_0_0) => {
                    v203 - match &v222 {
                        File_system::US3::US3_0(x) => x.clone(),
                        _ => unreachable!(),
                    } as u64
                }
                _ => v203,
            } / 1000000000_u64;
            let v233: u64 = v232 % 60_u64;
            let v235: u64 = v232 / 60_u64 % 60_u64;
            let v237: u64 = v232 / 3600_u64 % 24_u64;
            let v239: std::string::String = format!("{:02}:{:02}:{:02}", v237, v235, v233);
            let v241: string = fable_library_rust::String_::fromString(v239);
            let v513: string = padLeft(toLower(string("Critical")), 7_i32, ' ');
            let v551: &str = inline_colorization::color_bright_red;
            let v553: &str = &*v513;
            let v555: &str = inline_colorization::color_reset;
            let v557: string = string("format!(\"{v551}{v553}{v555}\")");
            let v558: std::string::String = format!("{v551}{v553}{v555}");
            let v560: string = fable_library_rust::String_::fromString(v558);
            let v579: i64 = (patternInput_2.0.clone()).l0.get().clone();
            let v581: LrcPtr<File_system::Mut4> = LrcPtr::new(File_system::Mut4 {
                l0: MutCell::new(File_system::method13()),
            });
            let v588: () = {
                File_system::closure9(v581.clone(), sprintf!("{}", string("{ ")), ());
                ()
            };
            let v595: () = {
                File_system::closure9(v581.clone(), sprintf!("{}", string("dir")), ());
                ()
            };
            let v602: () = {
                File_system::closure9(v581.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v608: () = {
                File_system::closure9(v581.clone(), sprintf!("{}", v0_1), ());
                ()
            };
            let v615: () = {
                File_system::closure9(v581.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v622: () = {
                File_system::closure9(v581.clone(), sprintf!("{}", string("error")), ());
                ()
            };
            let v628: () = {
                File_system::closure9(v581.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v639: std::string::String = format!("{:#?}", v1_1);
            let v661: () = {
                File_system::closure9(
                    v581.clone(),
                    sprintf!("{}", fable_library_rust::String_::fromString(v639)),
                    (),
                );
                ()
            };
            let v668: () = {
                File_system::closure9(v581.clone(), sprintf!("{}", string(" }")), ());
                ()
            };
            let v669: string = v581.l0.get().clone();
            let v708: string = trimEndChars(
                trimStartChars(
                    sprintf!(
                        "{} {} #{} {} / {}",
                        v241,
                        v560,
                        v579,
                        File_system::closure47((), ()),
                        v669
                    ),
                    toArray(empty::<char>()),
                ),
                toArray(ofArray(new_array(&[' ', '/']))),
            );
            near_sdk::log!("{}", v708.clone());
            ();
            ((patternInput.1.clone()).l0.get().clone())(v708)
        }
    }
    pub fn closure49(unitVar: (), unitVar_1: ()) -> string {
        string("file_system.create_dir")
    }
    pub fn closure48(v0_1: string, unitVar: ()) {
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
        let v22_1: () = {
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
        let v40: File_system::US0 = (patternInput_1.3.clone()).l0.get().clone();
        if if (patternInput_1.2.clone()).l0.get().clone() == false {
            false
        } else {
            0_i32
                >= find(
                    v40,
                    ofSeq(ofList(ofArray(new_array(&[
                        LrcPtr::new((File_system::US0::US0_0, 0_i32)),
                        LrcPtr::new((File_system::US0::US0_1, 1_i32)),
                        LrcPtr::new((File_system::US0::US0_2, 2_i32)),
                        LrcPtr::new((File_system::US0::US0_3, 3_i32)),
                        LrcPtr::new((File_system::US0::US0_4, 4_i32)),
                    ])))),
                )
        } {
            let v48: () = {
                File_system::closure6(patternInput.0.clone(), ());
                ()
            };
            let v50: () = {
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
            let v202: u64 = near_sdk::env::block_timestamp();
            let _v203: LrcPtr<MutCell<Option<File_system::US3>>> =
                refCell(None::<File_system::US3>);
            let v208: () = {
                File_system::closure8(
                    patternInput_2.4.clone(),
                    Func1::new({
                        let _v203 = _v203.clone();
                        move |v: Option<File_system::US3>| File_system::closure7(_v203.clone(), v)
                    }),
                    (),
                );
                ()
            };
            let v221: File_system::US3 = defaultValue(File_system::US3::US3_1, _v203.get().clone());
            let v231: u64 = match &v221 {
                File_system::US3::US3_0(v221_0_0) => {
                    v202 - match &v221 {
                        File_system::US3::US3_0(x) => x.clone(),
                        _ => unreachable!(),
                    } as u64
                }
                _ => v202,
            } / 1000000000_u64;
            let v232: u64 = v231 % 60_u64;
            let v234: u64 = v231 / 60_u64 % 60_u64;
            let v236: u64 = v231 / 3600_u64 % 24_u64;
            let v238: std::string::String = format!("{:02}:{:02}:{:02}", v236, v234, v232);
            let v240: string = fable_library_rust::String_::fromString(v238);
            let v512: string = padLeft(toLower(string("Verbose")), 7_i32, ' ');
            let v550: &str = inline_colorization::color_bright_black;
            let v552: &str = &*v512;
            let v554: &str = inline_colorization::color_reset;
            let v556: string = string("format!(\"{v550}{v552}{v554}\")");
            let v557: std::string::String = format!("{v550}{v552}{v554}");
            let v559: string = fable_library_rust::String_::fromString(v557);
            let v578: i64 = (patternInput_2.0.clone()).l0.get().clone();
            let v580: LrcPtr<File_system::Mut4> = LrcPtr::new(File_system::Mut4 {
                l0: MutCell::new(File_system::method13()),
            });
            let v587: () = {
                File_system::closure9(v580.clone(), sprintf!("{}", string("{ ")), ());
                ()
            };
            let v594: () = {
                File_system::closure9(v580.clone(), sprintf!("{}", string("dir")), ());
                ()
            };
            let v601: () = {
                File_system::closure9(v580.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v607: () = {
                File_system::closure9(v580.clone(), sprintf!("{}", v0_1), ());
                ()
            };
            let v614: () = {
                File_system::closure9(v580.clone(), sprintf!("{}", string(" }")), ());
                ()
            };
            let v615: string = v580.l0.get().clone();
            let v654: string = trimEndChars(
                trimStartChars(
                    sprintf!(
                        "{} {} #{} {} / {}",
                        v240,
                        v559,
                        v578,
                        File_system::closure49((), ()),
                        v615
                    ),
                    toArray(empty::<char>()),
                ),
                toArray(ofArray(new_array(&[' ', '/']))),
            );
            near_sdk::log!("{}", v654.clone());
            ();
            ((patternInput.1.clone()).l0.get().clone())(v654)
        }
    }
    pub fn closure50(v0_1: string, unitVar: ()) {
        File_system::method6(true, v0_1);
    }
    pub fn method38(v0_1: string) -> Func0<()> {
        Func0::new({
            let v0_1 = v0_1.clone();
            move || File_system::closure50(v0_1.clone(), ())
        })
    }
    pub fn method39(v0_1: string) -> Func0<()> {
        Func0::new({
            let v0_1 = v0_1.clone();
            move || File_system::closure50(v0_1.clone(), ())
        })
    }
    pub fn closure52(unitVar: (), unitVar_1: ()) -> string {
        string("file_system.create_dir")
    }
    pub fn closure51(v0_1: string, v1_1: string, unitVar: ()) {
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
        let v23_1: () = {
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
        let v41: File_system::US0 = (patternInput_1.3.clone()).l0.get().clone();
        if if (patternInput_1.2.clone()).l0.get().clone() == false {
            false
        } else {
            1_i32
                >= find(
                    v41,
                    ofSeq(ofList(ofArray(new_array(&[
                        LrcPtr::new((File_system::US0::US0_0, 0_i32)),
                        LrcPtr::new((File_system::US0::US0_1, 1_i32)),
                        LrcPtr::new((File_system::US0::US0_2, 2_i32)),
                        LrcPtr::new((File_system::US0::US0_3, 3_i32)),
                        LrcPtr::new((File_system::US0::US0_4, 4_i32)),
                    ])))),
                )
        } {
            let v49: () = {
                File_system::closure6(patternInput.0.clone(), ());
                ()
            };
            let v51: () = {
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
            let v203: u64 = near_sdk::env::block_timestamp();
            let _v204: LrcPtr<MutCell<Option<File_system::US3>>> =
                refCell(None::<File_system::US3>);
            let v209: () = {
                File_system::closure8(
                    patternInput_2.4.clone(),
                    Func1::new({
                        let _v204 = _v204.clone();
                        move |v: Option<File_system::US3>| File_system::closure7(_v204.clone(), v)
                    }),
                    (),
                );
                ()
            };
            let v222: File_system::US3 = defaultValue(File_system::US3::US3_1, _v204.get().clone());
            let v232: u64 = match &v222 {
                File_system::US3::US3_0(v222_0_0) => {
                    v203 - match &v222 {
                        File_system::US3::US3_0(x) => x.clone(),
                        _ => unreachable!(),
                    } as u64
                }
                _ => v203,
            } / 1000000000_u64;
            let v233: u64 = v232 % 60_u64;
            let v235: u64 = v232 / 60_u64 % 60_u64;
            let v237: u64 = v232 / 3600_u64 % 24_u64;
            let v239: std::string::String = format!("{:02}:{:02}:{:02}", v237, v235, v233);
            let v241: string = fable_library_rust::String_::fromString(v239);
            let v513: string = padLeft(toLower(string("Debug")), 7_i32, ' ');
            let v551: &str = inline_colorization::color_bright_blue;
            let v553: &str = &*v513;
            let v555: &str = inline_colorization::color_reset;
            let v557: string = string("format!(\"{v551}{v553}{v555}\")");
            let v558: std::string::String = format!("{v551}{v553}{v555}");
            let v560: string = fable_library_rust::String_::fromString(v558);
            let v579: i64 = (patternInput_2.0.clone()).l0.get().clone();
            let v581: LrcPtr<File_system::Mut4> = LrcPtr::new(File_system::Mut4 {
                l0: MutCell::new(File_system::method13()),
            });
            let v588: () = {
                File_system::closure9(v581.clone(), sprintf!("{}", string("{ ")), ());
                ()
            };
            let v595: () = {
                File_system::closure9(v581.clone(), sprintf!("{}", string("dir")), ());
                ()
            };
            let v602: () = {
                File_system::closure9(v581.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v608: () = {
                File_system::closure9(v581.clone(), sprintf!("{}", v0_1), ());
                ()
            };
            let v615: () = {
                File_system::closure9(v581.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v622: () = {
                File_system::closure9(v581.clone(), sprintf!("{}", string("result")), ());
                ()
            };
            let v628: () = {
                File_system::closure9(v581.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v634: () = {
                File_system::closure9(v581.clone(), sprintf!("{}", v1_1), ());
                ()
            };
            let v641: () = {
                File_system::closure9(v581.clone(), sprintf!("{}", string(" }")), ());
                ()
            };
            let v642: string = v581.l0.get().clone();
            let v681: string = trimEndChars(
                trimStartChars(
                    sprintf!(
                        "{} {} #{} {} / {}",
                        v241,
                        v560,
                        v579,
                        File_system::closure52((), ()),
                        v642
                    ),
                    toArray(empty::<char>()),
                ),
                toArray(ofArray(new_array(&[' ', '/']))),
            );
            near_sdk::log!("{}", v681.clone());
            ();
            ((patternInput.1.clone()).l0.get().clone())(v681)
        }
    }
    pub fn closure53(v0_1: string, unitVar: ()) {
        let v8_1: Arc<Async<i64>> = defaultOf();
        let v31: Arc<Async<()>> = defaultOf();
        defaultOf::<()>();
        ();
        ()
    }
    pub fn method40(v0_1: string) -> Func0<()> {
        Func0::new({
            let v0_1 = v0_1.clone();
            move || File_system::closure53(v0_1.clone(), ())
        })
    }
    pub fn method41(v0_1: string) -> Func0<()> {
        Func0::new({
            let v0_1 = v0_1.clone();
            move || File_system::closure53(v0_1.clone(), ())
        })
    }
    pub fn method35(v0_1: string) -> LrcPtr<dyn IDisposable> {
        interface_cast!(
            defaultOf::<std::rc::Rc<dyn IDisposable>>(),
            Lrc<dyn IDisposable>,
        )
    }
    pub fn closure42(unitVar: (), unitVar_1: ()) -> (string, LrcPtr<dyn IDisposable>) {
        let v0_1: string = File_system::method22();
        (v0_1.clone(), File_system::method35(v0_1))
    }
    pub fn method42(v0_1: string) -> Guid {
        unbox::<Guid>(&defaultOf())
    }
    pub fn closure54(unitVar: (), v0_1: string) -> (string, LrcPtr<dyn IDisposable>) {
        let v2_1: string = File_system::method27(File_system::method42(v0_1));
        (v2_1.clone(), File_system::method35(v2_1))
    }
    pub fn closure55(unitVar: (), unitVar_1: ()) -> string {
        string("C:\\home\\git\\polyglot\\lib\\spiral")
    }
    pub fn method44(v0_1: string) -> string {
        v0_1
    }
    pub fn method43(v0_1: string) -> string {
        if v0_1 == string("") {
            string("")
        } else {
            let v30: string = unbox::<string>(&defaultOf());
            replace(
                sprintf!(
                    "{}{}",
                    toLower(ofChar(getCharAt(v30.clone(), 0_i32))),
                    getSlice(v30, Some(1_i32), None::<i32>)
                ),
                string("\\"),
                string("/"),
            )
        }
    }
    pub fn closure56(unitVar: (), v0_1: string) -> string {
        File_system::method43(v0_1)
    }
    pub fn closure57(unitVar: (), v0_1: string) -> string {
        sprintf!("file:///{}", trimStartChars(v0_1, toArray(singleton('/'))))
    }
    pub fn method47(v0_1: string) -> Option<string> {
        let v85: File_system::US1 = unbox::<File_system::US1>(&defaultOf());
        match &v85 {
            File_system::US1::US1_0(v85_0_0) => Some(match &v85 {
                File_system::US1::US1_0(x) => x.clone(),
                _ => unreachable!(),
            }),
            _ => None::<string>,
        }
    }
    pub fn closure59(unitVar: (), v0_1: string) -> Option<string> {
        File_system::method47(v0_1)
    }
    pub fn method46() -> Func1<string, Option<string>> {
        Func1::new(move |v: string| File_system::closure59((), v))
    }
    pub fn method48(v0_1: string, v1_1: string, v2_1: string) -> File_system::US13 {
        let v0_1: MutCell<string> = MutCell::new(v0_1.clone());
        let v1_1: MutCell<string> = MutCell::new(v1_1.clone());
        let v2_1: MutCell<string> = MutCell::new(v2_1.clone());
        '_method48: loop {
            break '_method48 (if File_system::method8(File_system::method30(
                v2_1.get().clone(),
                v0_1.get().clone(),
            )) {
                File_system::US13::US13_0(v2_1.get().clone())
            } else {
                let v7_1: Option<string> = (File_system::method46())(v2_1.get().clone());
                let _v8: LrcPtr<MutCell<Option<File_system::US1>>> =
                    refCell(None::<File_system::US1>);
                let v13_1: () = {
                    File_system::closure2(
                        v7_1,
                        Func1::new({
                            let _v8 = _v8.clone();
                            move |v: Option<File_system::US1>| File_system::closure1(_v8.clone(), v)
                        }),
                        (),
                    );
                    ()
                };
                let v26: File_system::US1 =
                    defaultValue(File_system::US1::US1_1, _v8.get().clone());
                match &v26 {
                    File_system::US1::US1_0(v26_0_0) => {
                        let v0_1_temp: string = v0_1.get().clone();
                        let v1_1_temp: string = v1_1.get().clone();
                        let v2_1_temp: string = match &v26 {
                            File_system::US1::US1_0(x) => x.clone(),
                            _ => unreachable!(),
                        };
                        v0_1.set(v0_1_temp);
                        v1_1.set(v1_1_temp);
                        v2_1.set(v2_1_temp);
                        continue '_method48;
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
    pub fn method45(v0_1: string, v1_1: string) -> File_system::US13 {
        if File_system::method8(File_system::method30(v1_1.clone(), v0_1.clone())) {
            File_system::US13::US13_0(v1_1.clone())
        } else {
            let v6_1: Option<string> = (File_system::method46())(v1_1.clone());
            let _v7: LrcPtr<MutCell<Option<File_system::US1>>> = refCell(None::<File_system::US1>);
            let v12_1: () = {
                File_system::closure2(
                    v6_1,
                    Func1::new({
                        let _v7 = _v7.clone();
                        move |v: Option<File_system::US1>| File_system::closure1(_v7.clone(), v)
                    }),
                    (),
                );
                ()
            };
            let v25: File_system::US1 = defaultValue(File_system::US1::US1_1, _v7.get().clone());
            match &v25 {
                File_system::US1::US1_0(v25_0_0) => File_system::method48(
                    v0_1.clone(),
                    v1_1.clone(),
                    match &v25 {
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
    pub fn closure61(unitVar: (), unitVar_1: ()) -> string {
        string("file_system.get_workspace_root")
    }
    pub fn closure60(v0_1: string, unitVar: ()) {
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
        let v22_1: () = {
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
        let v40: File_system::US0 = (patternInput_1.3.clone()).l0.get().clone();
        if if (patternInput_1.2.clone()).l0.get().clone() == false {
            false
        } else {
            3_i32
                >= find(
                    v40,
                    ofSeq(ofList(ofArray(new_array(&[
                        LrcPtr::new((File_system::US0::US0_0, 0_i32)),
                        LrcPtr::new((File_system::US0::US0_1, 1_i32)),
                        LrcPtr::new((File_system::US0::US0_2, 2_i32)),
                        LrcPtr::new((File_system::US0::US0_3, 3_i32)),
                        LrcPtr::new((File_system::US0::US0_4, 4_i32)),
                    ])))),
                )
        } {
            let v48: () = {
                File_system::closure6(patternInput.0.clone(), ());
                ()
            };
            let v50: () = {
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
            let v202: u64 = near_sdk::env::block_timestamp();
            let _v203: LrcPtr<MutCell<Option<File_system::US3>>> =
                refCell(None::<File_system::US3>);
            let v208: () = {
                File_system::closure8(
                    patternInput_2.4.clone(),
                    Func1::new({
                        let _v203 = _v203.clone();
                        move |v: Option<File_system::US3>| File_system::closure7(_v203.clone(), v)
                    }),
                    (),
                );
                ()
            };
            let v221: File_system::US3 = defaultValue(File_system::US3::US3_1, _v203.get().clone());
            let v231: u64 = match &v221 {
                File_system::US3::US3_0(v221_0_0) => {
                    v202 - match &v221 {
                        File_system::US3::US3_0(x) => x.clone(),
                        _ => unreachable!(),
                    } as u64
                }
                _ => v202,
            } / 1000000000_u64;
            let v232: u64 = v231 % 60_u64;
            let v234: u64 = v231 / 60_u64 % 60_u64;
            let v236: u64 = v231 / 3600_u64 % 24_u64;
            let v238: std::string::String = format!("{:02}:{:02}:{:02}", v236, v234, v232);
            let v240: string = fable_library_rust::String_::fromString(v238);
            let v512: string = padLeft(toLower(string("Warning")), 7_i32, ' ');
            let v550: &str = inline_colorization::color_yellow;
            let v552: &str = &*v512;
            let v554: &str = inline_colorization::color_reset;
            let v556: string = string("format!(\"{v550}{v552}{v554}\")");
            let v557: std::string::String = format!("{v550}{v552}{v554}");
            let v559: string = fable_library_rust::String_::fromString(v557);
            let v578: i64 = (patternInput_2.0.clone()).l0.get().clone();
            let v580: LrcPtr<File_system::Mut4> = LrcPtr::new(File_system::Mut4 {
                l0: MutCell::new(File_system::method13()),
            });
            let v587: () = {
                File_system::closure9(v580.clone(), sprintf!("{}", string("{ ")), ());
                ()
            };
            let v594: () = {
                File_system::closure9(v580.clone(), sprintf!("{}", string("error")), ());
                ()
            };
            let v601: () = {
                File_system::closure9(v580.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v607: () = {
                File_system::closure9(v580.clone(), sprintf!("{}", v0_1), ());
                ()
            };
            let v614: () = {
                File_system::closure9(v580.clone(), sprintf!("{}", string(" }")), ());
                ()
            };
            let v615: string = v580.l0.get().clone();
            let v654: string = trimEndChars(
                trimStartChars(
                    sprintf!(
                        "{} {} #{} {} / {}",
                        v240,
                        v559,
                        v578,
                        File_system::closure61((), ()),
                        v615
                    ),
                    toArray(empty::<char>()),
                ),
                toArray(ofArray(new_array(&[' ', '/']))),
            );
            near_sdk::log!("{}", v654.clone());
            ();
            ((patternInput.1.clone()).l0.get().clone())(v654)
        }
    }
    pub fn method49() -> string {
        unbox::<string>(&defaultOf())
    }
    pub fn closure58(unitVar: (), unitVar_1: ()) -> string {
        let v4: File_system::US13 = File_system::method45(
            File_system::method30(string("polyglot"), string(".devcontainer")),
            string("C:\\home\\git\\polyglot\\lib\\spiral"),
        );
        let v13_1: File_system::US1 = match &v4 {
            File_system::US13::US13_0(v4_0_0) => File_system::US1::US1_0(v4_0_0.clone()),
            File_system::US13::US13_1(v4_1_0) => {
                let v10_1: () = {
                    File_system::closure60(v4_1_0.clone(), ());
                    ()
                };
                File_system::US1::US1_1
            }
        };
        let v29: File_system::US1 = match &v13_1 {
            File_system::US1::US1_0(v13_1_0_0) => File_system::US1::US1_0(match &v13_1 {
                File_system::US1::US1_0(x) => x.clone(),
                _ => unreachable!(),
            }),
            _ => {
                let v16_1: string = File_system::method49();
                let v18_1: File_system::US13 = File_system::method45(
                    File_system::method30(string("polyglot"), string(".devcontainer")),
                    v16_1,
                );
                match &v18_1 {
                    File_system::US13::US13_0(v18_1_0_0) => {
                        File_system::US1::US1_0(v18_1_0_0.clone())
                    }
                    File_system::US13::US13_1(v18_1_1_0) => {
                        let v24: () = {
                            File_system::closure60(v18_1_1_0.clone(), ());
                            ()
                        };
                        File_system::US1::US1_1
                    }
                }
            }
        };
        File_system::method30(
            match &v29 {
                File_system::US1::US1_0(v29_0_0) => match &v29 {
                    File_system::US1::US1_0(x) => x.clone(),
                    _ => unreachable!(),
                },
                _ => panic!("{}", string("Option does not have a value."),),
            },
            string("polyglot"),
        )
    }
    pub fn method50(v0_1: string) {
        ();
        ()
    }
    pub fn closure63(unitVar: (), v0_1: string) {
        File_system::method50(v0_1);
    }
    pub fn closure62(unitVar: (), v0_1: bool) {
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
        let v23_1 = if v0_1 {
            Func1::new(move |v: string| File_system::closure63((), v))
        } else {
            Func1::new(move |v_1: string| File_system::closure3((), v_1))
        };
        (patternInput.1.clone()).l0.set(v23_1);
        ()
    }
    pub fn closure65(v0_1: string, v1_1: string) -> string {
        File_system::method30(v0_1, v1_1)
    }
    pub fn closure64(unitVar: (), v0_1: string) -> Func1<string, string> {
        Func1::new({
            let v0_1 = v0_1.clone();
            move |v: string| File_system::closure65(v0_1.clone(), v)
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
    pub fn v5() -> Func1<string, Arc<Async<i64>>> {
        static v5: OnceInit<Func1<string, Arc<Async<i64>>>> = OnceInit::new();
        v5.get_or_init(|| Func1::new(move |v: string| File_system::closure4((), v)))
            .clone()
    }
    pub fn delete_directory_async(x: string) -> Arc<Async<i64>> {
        (File_system::v5())(x)
    }
    pub fn v6() -> Func1<File_system::US6, Func1<string, Arc<Async<i64>>>> {
        static v6: OnceInit<Func1<File_system::US6, Func1<string, Arc<Async<i64>>>>> =
            OnceInit::new();
        v6.get_or_init(|| Func1::new(move |v: File_system::US6| File_system::closure11((), v)))
            .clone()
    }
    pub fn wait_for_file_access(x: File_system::US6) -> Func1<string, Arc<Async<i64>>> {
        (File_system::v6())(x)
    }
    pub fn v7() -> Func1<string, Arc<Async<i64>>> {
        static v7: OnceInit<Func1<string, Arc<Async<i64>>>> = OnceInit::new();
        v7.get_or_init(|| Func1::new(move |v: string| File_system::closure15((), v)))
            .clone()
    }
    pub fn wait_for_file_access_read(x: string) -> Arc<Async<i64>> {
        (File_system::v7())(x)
    }
    pub fn v8() -> Func1<string, Arc<Async<string>>> {
        static v8: OnceInit<Func1<string, Arc<Async<string>>>> = OnceInit::new();
        v8.get_or_init(|| Func1::new(move |v: string| File_system::closure16((), v)))
            .clone()
    }
    pub fn read_all_text_async(x: string) -> Arc<Async<string>> {
        (File_system::v8())(x)
    }
    pub fn v9() -> Func1<string, Func1<string, bool>> {
        static v9: OnceInit<Func1<string, Func1<string, bool>>> = OnceInit::new();
        v9.get_or_init(|| Func1::new(move |v: string| File_system::closure17((), v)))
            .clone()
    }
    pub fn file_exists_content(x: string) -> Func1<string, bool> {
        (File_system::v9())(x)
    }
    pub fn v10() -> Func1<string, Func1<string, Arc<Async<()>>>> {
        static v10: OnceInit<Func1<string, Func1<string, Arc<Async<()>>>>> = OnceInit::new();
        v10.get_or_init(|| Func1::new(move |v: string| File_system::closure19((), v)))
            .clone()
    }
    pub fn write_all_text_async(x: string) -> Func1<string, Arc<Async<()>>> {
        (File_system::v10())(x)
    }
    pub fn v11() -> Func1<string, Func1<string, Arc<Async<()>>>> {
        static v11: OnceInit<Func1<string, Func1<string, Arc<Async<()>>>>> = OnceInit::new();
        v11.get_or_init(|| Func1::new(move |v: string| File_system::closure21((), v)))
            .clone()
    }
    pub fn write_all_text_exists(x: string) -> Func1<string, Arc<Async<()>>> {
        (File_system::v11())(x)
    }
    pub fn v12() -> Func1<string, Arc<Async<i64>>> {
        static v12: OnceInit<Func1<string, Arc<Async<i64>>>> = OnceInit::new();
        v12.get_or_init(|| Func1::new(move |v: string| File_system::closure23((), v)))
            .clone()
    }
    pub fn delete_file_async(x: string) -> Arc<Async<i64>> {
        (File_system::v12())(x)
    }
    pub fn v13() -> Func1<string, Func1<string, Arc<Async<i64>>>> {
        static v13: OnceInit<Func1<string, Func1<string, Arc<Async<i64>>>>> = OnceInit::new();
        v13.get_or_init(|| Func1::new(move |v: string| File_system::closure26((), v)))
            .clone()
    }
    pub fn move_file_async(x: string) -> Func1<string, Arc<Async<i64>>> {
        (File_system::v13())(x)
    }
    pub fn v14() -> Func1<string, Arc<Async<Option<string>>>> {
        static v14: OnceInit<Func1<string, Arc<Async<Option<string>>>>> = OnceInit::new();
        v14.get_or_init(|| Func1::new(move |v: string| File_system::closure30((), v)))
            .clone()
    }
    pub fn read_all_text_retry_async(x: string) -> Arc<Async<Option<string>>> {
        (File_system::v14())(x)
    }
    pub fn v15() -> Func0<string> {
        static v15: OnceInit<Func0<string>> = OnceInit::new();
        v15.get_or_init(|| Func0::new(move || File_system::closure39((), ())))
            .clone()
    }
    pub fn create_temp_path() -> string {
        (File_system::v15())()
    }
    pub fn v16() -> Func0<(string, LrcPtr<dyn IDisposable>)> {
        static v16: OnceInit<Func0<(string, LrcPtr<dyn IDisposable>)>> = OnceInit::new();
        v16.get_or_init(|| Func0::new(move || File_system::closure42((), ())))
            .clone()
    }
    pub fn create_temp_dir() -> (string, LrcPtr<dyn IDisposable>) {
        (File_system::v16())()
    }
    pub fn v17() -> Func1<string, (string, LrcPtr<dyn IDisposable>)> {
        static v17: OnceInit<Func1<string, (string, LrcPtr<dyn IDisposable>)>> = OnceInit::new();
        v17.get_or_init(|| Func1::new(move |v: string| File_system::closure54((), v)))
            .clone()
    }
    pub fn create_temp_dir_(x: string) -> (string, LrcPtr<dyn IDisposable>) {
        (File_system::v17())(x)
    }
    pub fn v18() -> Func0<string> {
        static v18: OnceInit<Func0<string>> = OnceInit::new();
        v18.get_or_init(|| Func0::new(move || File_system::closure55((), ())))
            .clone()
    }
    pub fn get_source_directory() -> string {
        (File_system::v18())()
    }
    pub fn v19() -> Func1<string, string> {
        static v19: OnceInit<Func1<string, string>> = OnceInit::new();
        v19.get_or_init(|| Func1::new(move |v: string| File_system::closure56((), v)))
            .clone()
    }
    pub fn normalize_path(x: string) -> string {
        (File_system::v19())(x)
    }
    pub fn v20() -> Func1<string, string> {
        static v20: OnceInit<Func1<string, string>> = OnceInit::new();
        v20.get_or_init(|| Func1::new(move |v: string| File_system::closure57((), v)))
            .clone()
    }
    pub fn new_file_uri(x: string) -> string {
        (File_system::v20())(x)
    }
    pub fn v21() -> Func0<string> {
        static v21: OnceInit<Func0<string>> = OnceInit::new();
        v21.get_or_init(|| Func0::new(move || File_system::closure58((), ())))
            .clone()
    }
    pub fn get_workspace_root() -> string {
        (File_system::v21())()
    }
    pub fn v22() -> Func1<bool, ()> {
        static v22: OnceInit<Func1<bool, ()>> = OnceInit::new();
        v22.get_or_init(|| Func1::new(move |v: bool| File_system::closure62((), v)))
            .clone()
    }
    pub fn init_trace_file(x: bool) {
        (File_system::v22())(x);
    }
    pub fn v23() -> Func1<string, Func1<string, string>> {
        static v23: OnceInit<Func1<string, Func1<string, string>>> = OnceInit::new();
        v23.get_or_init(|| Func1::new(move |v: string| File_system::closure64((), v)))
            .clone()
    }
    pub fn op_LessDivideGreater(x: string) -> Func1<string, string> {
        (File_system::v23())(x)
    }
    on_startup!(());
}
