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
    use fable_library_rust::String_::sprintf;
    use fable_library_rust::String_::string;
    use fable_library_rust::String_::toLower;
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
        LrcPtr<File_system::Mut4>,
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
    pub fn closure9(v0_1: LrcPtr<File_system::Mut3>, v1_1: string, unitVar: ()) {
        let v3: string = append(v0_1.l0.get().clone(), v1_1);
        v0_1.l0.set(v3);
        ()
    }
    pub fn closure11(v0_1: string, unitVar: ()) {
        printfn!("{0}", v0_1);
    }
    pub fn closure10(unitVar: (), v0_1: string) {
        let v3: () = {
            File_system::closure11(v0_1, ());
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
            LrcPtr<File_system::Mut4>,
            Option<i64>,
        ) = getValue(File_system::TraceState::trace_state().get().clone());
        let v21_1: LrcPtr<File_system::Mut3> = patternInput.3.clone();
        let v37: () = {
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
        let v69: File_system::US0 = (patternInput_1.4.clone()).l0.get().clone();
        if if (patternInput_1.2.clone()).l0.get().clone() == false {
            false
        } else {
            1_i32
                >= find(
                    v69,
                    ofSeq(ofList(ofArray(new_array(&[
                        LrcPtr::new((File_system::US0::US0_0, 0_i32)),
                        LrcPtr::new((File_system::US0::US0_1, 1_i32)),
                        LrcPtr::new((File_system::US0::US0_2, 2_i32)),
                        LrcPtr::new((File_system::US0::US0_3, 3_i32)),
                        LrcPtr::new((File_system::US0::US0_4, 4_i32)),
                    ])))),
                )
        } {
            let v77: () = {
                File_system::closure6(patternInput.0.clone(), ());
                ()
            };
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
            let v251: u64 = near_sdk::env::block_timestamp();
            let _v252: LrcPtr<MutCell<Option<File_system::US3>>> =
                refCell(None::<File_system::US3>);
            let v257: () = {
                File_system::closure8(
                    patternInput_2.5.clone(),
                    Func1::new({
                        let _v252 = _v252.clone();
                        move |v: Option<File_system::US3>| File_system::closure7(_v252.clone(), v)
                    }),
                    (),
                );
                ()
            };
            let v272: File_system::US3 = defaultValue(File_system::US3::US3_1, _v252.get().clone());
            let v282: u64 = match &v272 {
                File_system::US3::US3_0(v272_0_0) => {
                    v251 - match &v272 {
                        File_system::US3::US3_0(x) => x.clone(),
                        _ => unreachable!(),
                    } as u64
                }
                _ => v251,
            } / 1000000000_u64;
            let v283: u64 = v282 % 60_u64;
            let v285: u64 = v282 / 60_u64 % 60_u64;
            let v287: u64 = v282 / 3600_u64 % 24_u64;
            let v289: std::string::String = format!("{:02}:{:02}:{:02}", v287, v285, v283);
            let v291: string = fable_library_rust::String_::fromString(v289);
            let v571: string = padLeft(toLower(string("Debug")), 7_i32, ' ');
            let v609: &str = inline_colorization::color_bright_blue;
            let v611: &str = &*v571;
            let v613: &str = inline_colorization::color_reset;
            let v615: string = string("format!(\"{v609}{v611}{v613}\")");
            let v616: std::string::String = format!("{v609}{v611}{v613}");
            let v618: string = fable_library_rust::String_::fromString(v616);
            let v637: i64 = (patternInput_2.0.clone()).l0.get().clone();
            let v638: string = File_system::method12(v0_1);
            let v640: LrcPtr<File_system::Mut3> = LrcPtr::new(File_system::Mut3 {
                l0: MutCell::new(File_system::method13()),
            });
            let v647: () = {
                File_system::closure9(v640.clone(), sprintf!("{}", string("{ ")), ());
                ()
            };
            let v656: () = {
                File_system::closure9(v640.clone(), sprintf!("{}", string("ex")), ());
                ()
            };
            let v665: () = {
                File_system::closure9(v640.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v673: () = {
                File_system::closure9(v640.clone(), sprintf!("{}", v1_1), ());
                ()
            };
            let v682: () = {
                File_system::closure9(v640.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v691: () = {
                File_system::closure9(v640.clone(), sprintf!("{}", string("path")), ());
                ()
            };
            let v699: () = {
                File_system::closure9(v640.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v707: () = {
                File_system::closure9(v640.clone(), sprintf!("{}", v638), ());
                ()
            };
            let v716: () = {
                File_system::closure9(v640.clone(), sprintf!("{}", string(" }")), ());
                ()
            };
            let v758: string = trimEndChars(
                trimStartChars(
                    sprintf!(
                        "{} {} #{} {} / {}",
                        v291,
                        v618,
                        v637,
                        string("file_system.delete_directory_async"),
                        v640.l0.get().clone()
                    ),
                    toArray(empty::<char>()),
                ),
                toArray(ofArray(new_array(&[' ', '/']))),
            );
            let v789: string = if v21_1.l0.get().clone() == string("") {
                v758.clone()
            } else {
                if v758.clone() == string("") {
                    v21_1.l0.get().clone()
                } else {
                    append(append(v21_1.l0.get().clone(), string("\n")), v758.clone())
                }
            };
            let v791: &str = &*v789.clone();
            let v793 = v791.chars();
            let v795 = v793;
            let v797: Vec<char> = v795.collect::<Vec<_>>();
            let v799: Vec<Vec<char>> = v797
                .chunks(15000)
                .map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>())
                .collect::<Vec<_>>();
            let v801: bool = true;
            let _vec_map: Vec<_> = v799
                .into_iter()
                .map(|x| {
                    //;
                    let v803: Vec<char> = x;
                    let v805: std::string::String = String::from_iter(v803);
                    let v807: bool = true;
                    v805
                })
                .collect::<Vec<_>>();
            let v809: Vec<std::string::String> = _vec_map;
            if if v758.clone() != string("") {
                v809.clone().len() as i32 <= 1_i32
            } else {
                false
            } {
                v21_1.l0.set(v789);
                ()
            } else {
                v21_1.l0.set(string(""));
                {
                    let v821: bool = true;
                    v809.into_iter().for_each(|x| {
                        //;
                        let v823: std::string::String = x;
                        near_sdk::log!("{}", v823);
                        {
                            let v826: bool = true;
                            let v828: bool = true;
                        }
                    });
                    {
                        //;
                        ()
                    }
                }
            }
            ();
            ((patternInput.1.clone()).l0.get().clone())(v758)
        }
    }
    pub fn method5(v0_1: string, v1_1: i64) -> Arc<Async<i64>> {
        defaultOf()
    }
    pub fn closure4(unitVar: (), v0_1: string) -> Arc<Async<i64>> {
        defaultOf()
    }
    pub fn closure14(v0_1: string, v1_1: i64, v2_1: string, unitVar: ()) {
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
        let v22_1: LrcPtr<File_system::Mut3> = patternInput.3.clone();
        let v38: () = {
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
        let v70: File_system::US0 = (patternInput_1.4.clone()).l0.get().clone();
        if if (patternInput_1.2.clone()).l0.get().clone() == false {
            false
        } else {
            1_i32
                >= find(
                    v70,
                    ofSeq(ofList(ofArray(new_array(&[
                        LrcPtr::new((File_system::US0::US0_0, 0_i32)),
                        LrcPtr::new((File_system::US0::US0_1, 1_i32)),
                        LrcPtr::new((File_system::US0::US0_2, 2_i32)),
                        LrcPtr::new((File_system::US0::US0_3, 3_i32)),
                        LrcPtr::new((File_system::US0::US0_4, 4_i32)),
                    ])))),
                )
        } {
            let v78: () = {
                File_system::closure6(patternInput.0.clone(), ());
                ()
            };
            let v82: () = {
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
            let v252: u64 = near_sdk::env::block_timestamp();
            let _v253: LrcPtr<MutCell<Option<File_system::US3>>> =
                refCell(None::<File_system::US3>);
            let v258: () = {
                File_system::closure8(
                    patternInput_2.5.clone(),
                    Func1::new({
                        let _v253 = _v253.clone();
                        move |v: Option<File_system::US3>| File_system::closure7(_v253.clone(), v)
                    }),
                    (),
                );
                ()
            };
            let v273: File_system::US3 = defaultValue(File_system::US3::US3_1, _v253.get().clone());
            let v283: u64 = match &v273 {
                File_system::US3::US3_0(v273_0_0) => {
                    v252 - match &v273 {
                        File_system::US3::US3_0(x) => x.clone(),
                        _ => unreachable!(),
                    } as u64
                }
                _ => v252,
            } / 1000000000_u64;
            let v284: u64 = v283 % 60_u64;
            let v286: u64 = v283 / 60_u64 % 60_u64;
            let v288: u64 = v283 / 3600_u64 % 24_u64;
            let v290: std::string::String = format!("{:02}:{:02}:{:02}", v288, v286, v284);
            let v292: string = fable_library_rust::String_::fromString(v290);
            let v572: string = padLeft(toLower(string("Debug")), 7_i32, ' ');
            let v610: &str = inline_colorization::color_bright_blue;
            let v612: &str = &*v572;
            let v614: &str = inline_colorization::color_reset;
            let v616: string = string("format!(\"{v610}{v612}{v614}\")");
            let v617: std::string::String = format!("{v610}{v612}{v614}");
            let v619: string = fable_library_rust::String_::fromString(v617);
            let v638: i64 = (patternInput_2.0.clone()).l0.get().clone();
            let v639: string = File_system::method12(v0_1);
            let v641: LrcPtr<File_system::Mut3> = LrcPtr::new(File_system::Mut3 {
                l0: MutCell::new(File_system::method13()),
            });
            let v648: () = {
                File_system::closure9(v641.clone(), sprintf!("{}", string("{ ")), ());
                ()
            };
            let v657: () = {
                File_system::closure9(v641.clone(), sprintf!("{}", string("path")), ());
                ()
            };
            let v666: () = {
                File_system::closure9(v641.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v674: () = {
                File_system::closure9(v641.clone(), sprintf!("{}", v639), ());
                ()
            };
            let v683: () = {
                File_system::closure9(v641.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v692: () = {
                File_system::closure9(v641.clone(), sprintf!("{}", string("retry")), ());
                ()
            };
            let v700: () = {
                File_system::closure9(v641.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v708: () = {
                File_system::closure9(v641.clone(), sprintf!("{}", v1_1), ());
                ()
            };
            let v716: () = {
                File_system::closure9(v641.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v725: () = {
                File_system::closure9(v641.clone(), sprintf!("{}", string("ex")), ());
                ()
            };
            let v733: () = {
                File_system::closure9(v641.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v741: () = {
                File_system::closure9(v641.clone(), sprintf!("{}", v2_1), ());
                ()
            };
            let v750: () = {
                File_system::closure9(v641.clone(), sprintf!("{}", string(" }")), ());
                ()
            };
            let v792: string = trimEndChars(
                trimStartChars(
                    sprintf!(
                        "{} {} #{} {} / {}",
                        v292,
                        v619,
                        v638,
                        string("file_system.wait_for_file_access"),
                        v641.l0.get().clone()
                    ),
                    toArray(empty::<char>()),
                ),
                toArray(ofArray(new_array(&[' ', '/']))),
            );
            let v823: string = if v22_1.l0.get().clone() == string("") {
                v792.clone()
            } else {
                if v792.clone() == string("") {
                    v22_1.l0.get().clone()
                } else {
                    append(append(v22_1.l0.get().clone(), string("\n")), v792.clone())
                }
            };
            let v825: &str = &*v823.clone();
            let v827 = v825.chars();
            let v829 = v827;
            let v831: Vec<char> = v829.collect::<Vec<_>>();
            let v833: Vec<Vec<char>> = v831
                .chunks(15000)
                .map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>())
                .collect::<Vec<_>>();
            let v835: bool = true;
            let _vec_map: Vec<_> = v833
                .into_iter()
                .map(|x| {
                    //;
                    let v837: Vec<char> = x;
                    let v839: std::string::String = String::from_iter(v837);
                    let v841: bool = true;
                    v839
                })
                .collect::<Vec<_>>();
            let v843: Vec<std::string::String> = _vec_map;
            if if v792.clone() != string("") {
                v843.clone().len() as i32 <= 1_i32
            } else {
                false
            } {
                v22_1.l0.set(v823);
                ()
            } else {
                v22_1.l0.set(string(""));
                {
                    let v855: bool = true;
                    v843.into_iter().for_each(|x| {
                        //;
                        let v857: std::string::String = x;
                        near_sdk::log!("{}", v857);
                        {
                            let v860: bool = true;
                            let v862: bool = true;
                        }
                    });
                    {
                        //;
                        ()
                    }
                }
            }
            ();
            ((patternInput.1.clone()).l0.get().clone())(v792)
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
    pub fn closure13(v0_1: File_system::US6, v1_1: string) -> Arc<Async<i64>> {
        defaultOf()
    }
    pub fn closure12(unitVar: (), v0_1: File_system::US6) -> Func1<string, Arc<Async<i64>>> {
        Func1::new({
            let v0_1 = v0_1.clone();
            move |v: string| File_system::closure13(v0_1.clone(), v)
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
            LrcPtr<File_system::Mut4>,
            Option<i64>,
        ) = getValue(File_system::TraceState::trace_state().get().clone());
        let v21_1: LrcPtr<File_system::Mut3> = patternInput.3.clone();
        let v37: () = {
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
        let v69: File_system::US0 = (patternInput_1.4.clone()).l0.get().clone();
        if if (patternInput_1.2.clone()).l0.get().clone() == false {
            false
        } else {
            3_i32
                >= find(
                    v69,
                    ofSeq(ofList(ofArray(new_array(&[
                        LrcPtr::new((File_system::US0::US0_0, 0_i32)),
                        LrcPtr::new((File_system::US0::US0_1, 1_i32)),
                        LrcPtr::new((File_system::US0::US0_2, 2_i32)),
                        LrcPtr::new((File_system::US0::US0_3, 3_i32)),
                        LrcPtr::new((File_system::US0::US0_4, 4_i32)),
                    ])))),
                )
        } {
            let v77: () = {
                File_system::closure6(patternInput.0.clone(), ());
                ()
            };
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
            let v251: u64 = near_sdk::env::block_timestamp();
            let _v252: LrcPtr<MutCell<Option<File_system::US3>>> =
                refCell(None::<File_system::US3>);
            let v257: () = {
                File_system::closure8(
                    patternInput_2.5.clone(),
                    Func1::new({
                        let _v252 = _v252.clone();
                        move |v: Option<File_system::US3>| File_system::closure7(_v252.clone(), v)
                    }),
                    (),
                );
                ()
            };
            let v272: File_system::US3 = defaultValue(File_system::US3::US3_1, _v252.get().clone());
            let v282: u64 = match &v272 {
                File_system::US3::US3_0(v272_0_0) => {
                    v251 - match &v272 {
                        File_system::US3::US3_0(x) => x.clone(),
                        _ => unreachable!(),
                    } as u64
                }
                _ => v251,
            } / 1000000000_u64;
            let v283: u64 = v282 % 60_u64;
            let v285: u64 = v282 / 60_u64 % 60_u64;
            let v287: u64 = v282 / 3600_u64 % 24_u64;
            let v289: std::string::String = format!("{:02}:{:02}:{:02}", v287, v285, v283);
            let v291: string = fable_library_rust::String_::fromString(v289);
            let v571: string = padLeft(toLower(string("Warning")), 7_i32, ' ');
            let v609: &str = inline_colorization::color_yellow;
            let v611: &str = &*v571;
            let v613: &str = inline_colorization::color_reset;
            let v615: string = string("format!(\"{v609}{v611}{v613}\")");
            let v616: std::string::String = format!("{v609}{v611}{v613}");
            let v618: string = fable_library_rust::String_::fromString(v616);
            let v637: i64 = (patternInput_2.0.clone()).l0.get().clone();
            let v638: string = File_system::method12(v0_1);
            let v646: string = sprintf!("{:?}", v1_1);
            let v662: LrcPtr<File_system::Mut3> = LrcPtr::new(File_system::Mut3 {
                l0: MutCell::new(File_system::method13()),
            });
            let v669: () = {
                File_system::closure9(v662.clone(), sprintf!("{}", string("{ ")), ());
                ()
            };
            let v678: () = {
                File_system::closure9(v662.clone(), sprintf!("{}", string("path")), ());
                ()
            };
            let v687: () = {
                File_system::closure9(v662.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v695: () = {
                File_system::closure9(v662.clone(), sprintf!("{}", v638), ());
                ()
            };
            let v704: () = {
                File_system::closure9(v662.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v713: () = {
                File_system::closure9(v662.clone(), sprintf!("{}", string("ex")), ());
                ()
            };
            let v721: () = {
                File_system::closure9(v662.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v729: () = {
                File_system::closure9(v662.clone(), sprintf!("{}", v646), ());
                ()
            };
            let v738: () = {
                File_system::closure9(v662.clone(), sprintf!("{}", string(" }")), ());
                ()
            };
            let v780: string = trimEndChars(
                trimStartChars(
                    sprintf!(
                        "{} {} #{} {} / {}",
                        v291,
                        v618,
                        v637,
                        string("delete_file_async"),
                        v662.l0.get().clone()
                    ),
                    toArray(empty::<char>()),
                ),
                toArray(ofArray(new_array(&[' ', '/']))),
            );
            let v811: string = if v21_1.l0.get().clone() == string("") {
                v780.clone()
            } else {
                if v780.clone() == string("") {
                    v21_1.l0.get().clone()
                } else {
                    append(append(v21_1.l0.get().clone(), string("\n")), v780.clone())
                }
            };
            let v813: &str = &*v811.clone();
            let v815 = v813.chars();
            let v817 = v815;
            let v819: Vec<char> = v817.collect::<Vec<_>>();
            let v821: Vec<Vec<char>> = v819
                .chunks(15000)
                .map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>())
                .collect::<Vec<_>>();
            let v823: bool = true;
            let _vec_map: Vec<_> = v821
                .into_iter()
                .map(|x| {
                    //;
                    let v825: Vec<char> = x;
                    let v827: std::string::String = String::from_iter(v825);
                    let v829: bool = true;
                    v827
                })
                .collect::<Vec<_>>();
            let v831: Vec<std::string::String> = _vec_map;
            if if v780.clone() != string("") {
                v831.clone().len() as i32 <= 1_i32
            } else {
                false
            } {
                v21_1.l0.set(v811);
                ()
            } else {
                v21_1.l0.set(string(""));
                {
                    let v843: bool = true;
                    v831.into_iter().for_each(|x| {
                        //;
                        let v845: std::string::String = x;
                        near_sdk::log!("{}", v845);
                        {
                            let v848: bool = true;
                            let v850: bool = true;
                        }
                    });
                    {
                        //;
                        ()
                    }
                }
            }
            ();
            ((patternInput.1.clone()).l0.get().clone())(v780)
        }
    }
    pub fn method19(v0_1: string, v1_1: i64) -> Arc<Async<i64>> {
        defaultOf()
    }
    pub fn closure23(unitVar: (), v0_1: string) -> Arc<Async<i64>> {
        defaultOf()
    }
    pub fn closure27(v0_1: string, v1_1: string, v2_1: LrcPtr<Exception>, unitVar: ()) {
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
        let v22_1: LrcPtr<File_system::Mut3> = patternInput.3.clone();
        let v38: () = {
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
        let v70: File_system::US0 = (patternInput_1.4.clone()).l0.get().clone();
        if if (patternInput_1.2.clone()).l0.get().clone() == false {
            false
        } else {
            3_i32
                >= find(
                    v70,
                    ofSeq(ofList(ofArray(new_array(&[
                        LrcPtr::new((File_system::US0::US0_0, 0_i32)),
                        LrcPtr::new((File_system::US0::US0_1, 1_i32)),
                        LrcPtr::new((File_system::US0::US0_2, 2_i32)),
                        LrcPtr::new((File_system::US0::US0_3, 3_i32)),
                        LrcPtr::new((File_system::US0::US0_4, 4_i32)),
                    ])))),
                )
        } {
            let v78: () = {
                File_system::closure6(patternInput.0.clone(), ());
                ()
            };
            let v82: () = {
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
            let v252: u64 = near_sdk::env::block_timestamp();
            let _v253: LrcPtr<MutCell<Option<File_system::US3>>> =
                refCell(None::<File_system::US3>);
            let v258: () = {
                File_system::closure8(
                    patternInput_2.5.clone(),
                    Func1::new({
                        let _v253 = _v253.clone();
                        move |v: Option<File_system::US3>| File_system::closure7(_v253.clone(), v)
                    }),
                    (),
                );
                ()
            };
            let v273: File_system::US3 = defaultValue(File_system::US3::US3_1, _v253.get().clone());
            let v283: u64 = match &v273 {
                File_system::US3::US3_0(v273_0_0) => {
                    v252 - match &v273 {
                        File_system::US3::US3_0(x) => x.clone(),
                        _ => unreachable!(),
                    } as u64
                }
                _ => v252,
            } / 1000000000_u64;
            let v284: u64 = v283 % 60_u64;
            let v286: u64 = v283 / 60_u64 % 60_u64;
            let v288: u64 = v283 / 3600_u64 % 24_u64;
            let v290: std::string::String = format!("{:02}:{:02}:{:02}", v288, v286, v284);
            let v292: string = fable_library_rust::String_::fromString(v290);
            let v572: string = padLeft(toLower(string("Warning")), 7_i32, ' ');
            let v610: &str = inline_colorization::color_yellow;
            let v612: &str = &*v572;
            let v614: &str = inline_colorization::color_reset;
            let v616: string = string("format!(\"{v610}{v612}{v614}\")");
            let v617: std::string::String = format!("{v610}{v612}{v614}");
            let v619: string = fable_library_rust::String_::fromString(v617);
            let v638: i64 = (patternInput_2.0.clone()).l0.get().clone();
            let v639: string = File_system::method12(v1_1);
            let v640: string = File_system::method12(v0_1);
            let v642: LrcPtr<File_system::Mut3> = LrcPtr::new(File_system::Mut3 {
                l0: MutCell::new(File_system::method13()),
            });
            let v649: () = {
                File_system::closure9(v642.clone(), sprintf!("{}", string("{ ")), ());
                ()
            };
            let v658: () = {
                File_system::closure9(v642.clone(), sprintf!("{}", string("old_path")), ());
                ()
            };
            let v667: () = {
                File_system::closure9(v642.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v675: () = {
                File_system::closure9(v642.clone(), sprintf!("{}", v639), ());
                ()
            };
            let v684: () = {
                File_system::closure9(v642.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v693: () = {
                File_system::closure9(v642.clone(), sprintf!("{}", string("new_path")), ());
                ()
            };
            let v701: () = {
                File_system::closure9(v642.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v709: () = {
                File_system::closure9(v642.clone(), sprintf!("{}", v640), ());
                ()
            };
            let v717: () = {
                File_system::closure9(v642.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v726: () = {
                File_system::closure9(v642.clone(), sprintf!("{}", string("ex")), ());
                ()
            };
            let v734: () = {
                File_system::closure9(v642.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v747: std::string::String = format!("{:#?}", v2_1);
            let v769: () = {
                File_system::closure9(
                    v642.clone(),
                    sprintf!("{}", fable_library_rust::String_::fromString(v747)),
                    (),
                );
                ()
            };
            let v778: () = {
                File_system::closure9(v642.clone(), sprintf!("{}", string(" }")), ());
                ()
            };
            let v820: string = trimEndChars(
                trimStartChars(
                    sprintf!(
                        "{} {} #{} {} / {}",
                        v292,
                        v619,
                        v638,
                        string("move_file_async"),
                        v642.l0.get().clone()
                    ),
                    toArray(empty::<char>()),
                ),
                toArray(ofArray(new_array(&[' ', '/']))),
            );
            let v851: string = if v22_1.l0.get().clone() == string("") {
                v820.clone()
            } else {
                if v820.clone() == string("") {
                    v22_1.l0.get().clone()
                } else {
                    append(append(v22_1.l0.get().clone(), string("\n")), v820.clone())
                }
            };
            let v853: &str = &*v851.clone();
            let v855 = v853.chars();
            let v857 = v855;
            let v859: Vec<char> = v857.collect::<Vec<_>>();
            let v861: Vec<Vec<char>> = v859
                .chunks(15000)
                .map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>())
                .collect::<Vec<_>>();
            let v863: bool = true;
            let _vec_map: Vec<_> = v861
                .into_iter()
                .map(|x| {
                    //;
                    let v865: Vec<char> = x;
                    let v867: std::string::String = String::from_iter(v865);
                    let v869: bool = true;
                    v867
                })
                .collect::<Vec<_>>();
            let v871: Vec<std::string::String> = _vec_map;
            if if v820.clone() != string("") {
                v871.clone().len() as i32 <= 1_i32
            } else {
                false
            } {
                v22_1.l0.set(v851);
                ()
            } else {
                v22_1.l0.set(string(""));
                {
                    let v883: bool = true;
                    v871.into_iter().for_each(|x| {
                        //;
                        let v885: std::string::String = x;
                        near_sdk::log!("{}", v885);
                        {
                            let v888: bool = true;
                            let v890: bool = true;
                        }
                    });
                    {
                        //;
                        ()
                    }
                }
            }
            ();
            ((patternInput.1.clone()).l0.get().clone())(v820)
        }
    }
    pub fn method20(v0_1: string, v1_1: string, v2_1: i64) -> Arc<Async<i64>> {
        defaultOf()
    }
    pub fn closure26(v0_1: string, v1_1: string) -> Arc<Async<i64>> {
        defaultOf()
    }
    pub fn closure25(unitVar: (), v0_1: string) -> Func1<string, Arc<Async<i64>>> {
        Func1::new({
            let v0_1 = v0_1.clone();
            move |v: string| File_system::closure26(v0_1.clone(), v)
        })
    }
    pub fn closure29(unitVar: (), v0_1: i64) -> File_system::US9 {
        File_system::US9::US9_0(v0_1)
    }
    pub fn closure30(unitVar: (), v0_1: LrcPtr<Exception>) -> File_system::US9 {
        File_system::US9::US9_1(v0_1)
    }
    pub fn closure31(unitVar: (), unitVar_1: ()) {
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
        let v19_1: LrcPtr<File_system::Mut3> = patternInput.3.clone();
        let v35: () = {
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
        let v67: File_system::US0 = (patternInput_1.4.clone()).l0.get().clone();
        if if (patternInput_1.2.clone()).l0.get().clone() == false {
            false
        } else {
            0_i32
                >= find(
                    v67,
                    ofSeq(ofList(ofArray(new_array(&[
                        LrcPtr::new((File_system::US0::US0_0, 0_i32)),
                        LrcPtr::new((File_system::US0::US0_1, 1_i32)),
                        LrcPtr::new((File_system::US0::US0_2, 2_i32)),
                        LrcPtr::new((File_system::US0::US0_3, 3_i32)),
                        LrcPtr::new((File_system::US0::US0_4, 4_i32)),
                    ])))),
                )
        } {
            let v75: () = {
                File_system::closure6(patternInput.0.clone(), ());
                ()
            };
            let v79: () = {
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
            let v249: u64 = near_sdk::env::block_timestamp();
            let _v250: LrcPtr<MutCell<Option<File_system::US3>>> =
                refCell(None::<File_system::US3>);
            let v255: () = {
                File_system::closure8(
                    patternInput_2.5.clone(),
                    Func1::new({
                        let _v250 = _v250.clone();
                        move |v: Option<File_system::US3>| File_system::closure7(_v250.clone(), v)
                    }),
                    (),
                );
                ()
            };
            let v270: File_system::US3 = defaultValue(File_system::US3::US3_1, _v250.get().clone());
            let v280: u64 = match &v270 {
                File_system::US3::US3_0(v270_0_0) => {
                    v249 - match &v270 {
                        File_system::US3::US3_0(x) => x.clone(),
                        _ => unreachable!(),
                    } as u64
                }
                _ => v249,
            } / 1000000000_u64;
            let v281: u64 = v280 % 60_u64;
            let v283: u64 = v280 / 60_u64 % 60_u64;
            let v285: u64 = v280 / 3600_u64 % 24_u64;
            let v287: std::string::String = format!("{:02}:{:02}:{:02}", v285, v283, v281);
            let v289: string = fable_library_rust::String_::fromString(v287);
            let v569: string = padLeft(toLower(string("Verbose")), 7_i32, ' ');
            let v607: &str = inline_colorization::color_bright_black;
            let v609: &str = &*v569;
            let v611: &str = inline_colorization::color_reset;
            let v613: string = string("format!(\"{v607}{v609}{v611}\")");
            let v614: std::string::String = format!("{v607}{v609}{v611}");
            let v616: string = fable_library_rust::String_::fromString(v614);
            let v635: i64 = (patternInput_2.0.clone()).l0.get().clone();
            let v637: LrcPtr<File_system::Mut3> = LrcPtr::new(File_system::Mut3 {
                l0: MutCell::new(File_system::method13()),
            });
            let v644: () = {
                File_system::closure9(v637.clone(), sprintf!("{}", string("{ ")), ());
                ()
            };
            let v653: () = {
                File_system::closure9(v637.clone(), sprintf!("{}", string("timeout")), ());
                ()
            };
            let v662: () = {
                File_system::closure9(v637.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v670: () = {
                File_system::closure9(v637.clone(), sprintf!("{}", 1000_i32), ());
                ()
            };
            let v679: () = {
                File_system::closure9(v637.clone(), sprintf!("{}", string(" }")), ());
                ()
            };
            let v741: string = trimEndChars(
                trimStartChars(
                    sprintf!(
                        "{} {} #{} {} / {}",
                        v289,
                        v616,
                        v635,
                        string("async.run_with_timeout_async"),
                        v637.l0.get().clone()
                    ),
                    toArray(empty::<char>()),
                ),
                toArray(ofArray(new_array(&[' ', '/']))),
            );
            let v755: string = if v19_1.l0.get().clone() == string("") {
                v741.clone()
            } else {
                if v741.clone() == string("") {
                    v19_1.l0.get().clone()
                } else {
                    append(append(v19_1.l0.get().clone(), string("\n")), v741.clone())
                }
            };
            let v757: &str = &*v755.clone();
            let v759 = v757.chars();
            let v761 = v759;
            let v763: Vec<char> = v761.collect::<Vec<_>>();
            let v765: Vec<Vec<char>> = v763
                .chunks(15000)
                .map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>())
                .collect::<Vec<_>>();
            let v767: bool = true;
            let _vec_map: Vec<_> = v765
                .into_iter()
                .map(|x| {
                    //;
                    let v769: Vec<char> = x;
                    let v771: std::string::String = String::from_iter(v769);
                    let v773: bool = true;
                    v771
                })
                .collect::<Vec<_>>();
            let v775: Vec<std::string::String> = _vec_map;
            if if v741.clone() != string("") {
                v775.clone().len() as i32 <= 1_i32
            } else {
                false
            } {
                v19_1.l0.set(v755);
                ()
            } else {
                v19_1.l0.set(string(""));
                {
                    let v787: bool = true;
                    v775.into_iter().for_each(|x| {
                        //;
                        let v789: std::string::String = x;
                        near_sdk::log!("{}", v789);
                        {
                            let v792: bool = true;
                            let v794: bool = true;
                        }
                    });
                    {
                        //;
                        ()
                    }
                }
            }
            ();
            ((patternInput.1.clone()).l0.get().clone())(v741)
        }
    }
    pub fn closure32(v0_1: LrcPtr<Exception>, unitVar: ()) {
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
        let v20_1: LrcPtr<File_system::Mut3> = patternInput.3.clone();
        let v36: () = {
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
        let v68: File_system::US0 = (patternInput_1.4.clone()).l0.get().clone();
        if if (patternInput_1.2.clone()).l0.get().clone() == false {
            false
        } else {
            4_i32
                >= find(
                    v68,
                    ofSeq(ofList(ofArray(new_array(&[
                        LrcPtr::new((File_system::US0::US0_0, 0_i32)),
                        LrcPtr::new((File_system::US0::US0_1, 1_i32)),
                        LrcPtr::new((File_system::US0::US0_2, 2_i32)),
                        LrcPtr::new((File_system::US0::US0_3, 3_i32)),
                        LrcPtr::new((File_system::US0::US0_4, 4_i32)),
                    ])))),
                )
        } {
            let v76: () = {
                File_system::closure6(patternInput.0.clone(), ());
                ()
            };
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
            let v250: u64 = near_sdk::env::block_timestamp();
            let _v251: LrcPtr<MutCell<Option<File_system::US3>>> =
                refCell(None::<File_system::US3>);
            let v256: () = {
                File_system::closure8(
                    patternInput_2.5.clone(),
                    Func1::new({
                        let _v251 = _v251.clone();
                        move |v: Option<File_system::US3>| File_system::closure7(_v251.clone(), v)
                    }),
                    (),
                );
                ()
            };
            let v271: File_system::US3 = defaultValue(File_system::US3::US3_1, _v251.get().clone());
            let v281: u64 = match &v271 {
                File_system::US3::US3_0(v271_0_0) => {
                    v250 - match &v271 {
                        File_system::US3::US3_0(x) => x.clone(),
                        _ => unreachable!(),
                    } as u64
                }
                _ => v250,
            } / 1000000000_u64;
            let v282: u64 = v281 % 60_u64;
            let v284: u64 = v281 / 60_u64 % 60_u64;
            let v286: u64 = v281 / 3600_u64 % 24_u64;
            let v288: std::string::String = format!("{:02}:{:02}:{:02}", v286, v284, v282);
            let v290: string = fable_library_rust::String_::fromString(v288);
            let v570: string = padLeft(toLower(string("Critical")), 7_i32, ' ');
            let v608: &str = inline_colorization::color_bright_red;
            let v610: &str = &*v570;
            let v612: &str = inline_colorization::color_reset;
            let v614: string = string("format!(\"{v608}{v610}{v612}\")");
            let v615: std::string::String = format!("{v608}{v610}{v612}");
            let v617: string = fable_library_rust::String_::fromString(v615);
            let v636: i64 = (patternInput_2.0.clone()).l0.get().clone();
            let v644: string = sprintf!("{:?}", v0_1);
            let v660: LrcPtr<File_system::Mut3> = LrcPtr::new(File_system::Mut3 {
                l0: MutCell::new(File_system::method13()),
            });
            let v667: () = {
                File_system::closure9(v660.clone(), sprintf!("{}", string("{ ")), ());
                ()
            };
            let v676: () = {
                File_system::closure9(v660.clone(), sprintf!("{}", string("timeout")), ());
                ()
            };
            let v685: () = {
                File_system::closure9(v660.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v693: () = {
                File_system::closure9(v660.clone(), sprintf!("{}", 1000_i32), ());
                ()
            };
            let v702: () = {
                File_system::closure9(v660.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v711: () = {
                File_system::closure9(v660.clone(), sprintf!("{}", string("ex")), ());
                ()
            };
            let v719: () = {
                File_system::closure9(v660.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v727: () = {
                File_system::closure9(v660.clone(), sprintf!("{}", v644), ());
                ()
            };
            let v736: () = {
                File_system::closure9(v660.clone(), sprintf!("{}", string(" }")), ());
                ()
            };
            let v798: string = trimEndChars(
                trimStartChars(
                    sprintf!(
                        "{} {} #{} {} / {}",
                        v290,
                        v617,
                        v636,
                        string("async.run_with_timeout_async**"),
                        v660.l0.get().clone()
                    ),
                    toArray(empty::<char>()),
                ),
                toArray(ofArray(new_array(&[' ', '/']))),
            );
            let v812: string = if v20_1.l0.get().clone() == string("") {
                v798.clone()
            } else {
                if v798.clone() == string("") {
                    v20_1.l0.get().clone()
                } else {
                    append(append(v20_1.l0.get().clone(), string("\n")), v798.clone())
                }
            };
            let v814: &str = &*v812.clone();
            let v816 = v814.chars();
            let v818 = v816;
            let v820: Vec<char> = v818.collect::<Vec<_>>();
            let v822: Vec<Vec<char>> = v820
                .chunks(15000)
                .map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>())
                .collect::<Vec<_>>();
            let v824: bool = true;
            let _vec_map: Vec<_> = v822
                .into_iter()
                .map(|x| {
                    //;
                    let v826: Vec<char> = x;
                    let v828: std::string::String = String::from_iter(v826);
                    let v830: bool = true;
                    v828
                })
                .collect::<Vec<_>>();
            let v832: Vec<std::string::String> = _vec_map;
            if if v798.clone() != string("") {
                v832.clone().len() as i32 <= 1_i32
            } else {
                false
            } {
                v20_1.l0.set(v812);
                ()
            } else {
                v20_1.l0.set(string(""));
                {
                    let v844: bool = true;
                    v832.into_iter().for_each(|x| {
                        //;
                        let v846: std::string::String = x;
                        near_sdk::log!("{}", v846);
                        {
                            let v849: bool = true;
                            let v851: bool = true;
                        }
                    });
                    {
                        //;
                        ()
                    }
                }
            }
            ();
            ((patternInput.1.clone()).l0.get().clone())(v798)
        }
    }
    pub fn closure33(v0_1: i64, v1_1: string, unitVar: ()) {
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
        let v21_1: LrcPtr<File_system::Mut3> = patternInput.3.clone();
        let v37: () = {
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
        let v69: File_system::US0 = (patternInput_1.4.clone()).l0.get().clone();
        if if (patternInput_1.2.clone()).l0.get().clone() == false {
            false
        } else {
            1_i32
                >= find(
                    v69,
                    ofSeq(ofList(ofArray(new_array(&[
                        LrcPtr::new((File_system::US0::US0_0, 0_i32)),
                        LrcPtr::new((File_system::US0::US0_1, 1_i32)),
                        LrcPtr::new((File_system::US0::US0_2, 2_i32)),
                        LrcPtr::new((File_system::US0::US0_3, 3_i32)),
                        LrcPtr::new((File_system::US0::US0_4, 4_i32)),
                    ])))),
                )
        } {
            let v77: () = {
                File_system::closure6(patternInput.0.clone(), ());
                ()
            };
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
            let v251: u64 = near_sdk::env::block_timestamp();
            let _v252: LrcPtr<MutCell<Option<File_system::US3>>> =
                refCell(None::<File_system::US3>);
            let v257: () = {
                File_system::closure8(
                    patternInput_2.5.clone(),
                    Func1::new({
                        let _v252 = _v252.clone();
                        move |v: Option<File_system::US3>| File_system::closure7(_v252.clone(), v)
                    }),
                    (),
                );
                ()
            };
            let v272: File_system::US3 = defaultValue(File_system::US3::US3_1, _v252.get().clone());
            let v282: u64 = match &v272 {
                File_system::US3::US3_0(v272_0_0) => {
                    v251 - match &v272 {
                        File_system::US3::US3_0(x) => x.clone(),
                        _ => unreachable!(),
                    } as u64
                }
                _ => v251,
            } / 1000000000_u64;
            let v283: u64 = v282 % 60_u64;
            let v285: u64 = v282 / 60_u64 % 60_u64;
            let v287: u64 = v282 / 3600_u64 % 24_u64;
            let v289: std::string::String = format!("{:02}:{:02}:{:02}", v287, v285, v283);
            let v291: string = fable_library_rust::String_::fromString(v289);
            let v571: string = padLeft(toLower(string("Debug")), 7_i32, ' ');
            let v609: &str = inline_colorization::color_bright_blue;
            let v611: &str = &*v571;
            let v613: &str = inline_colorization::color_reset;
            let v615: string = string("format!(\"{v609}{v611}{v613}\")");
            let v616: std::string::String = format!("{v609}{v611}{v613}");
            let v618: string = fable_library_rust::String_::fromString(v616);
            let v637: i64 = (patternInput_2.0.clone()).l0.get().clone();
            let v639: LrcPtr<File_system::Mut3> = LrcPtr::new(File_system::Mut3 {
                l0: MutCell::new(File_system::method13()),
            });
            let v646: () = {
                File_system::closure9(v639.clone(), sprintf!("{}", string("{ ")), ());
                ()
            };
            let v655: () = {
                File_system::closure9(v639.clone(), sprintf!("{}", string("retry")), ());
                ()
            };
            let v664: () = {
                File_system::closure9(v639.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v672: () = {
                File_system::closure9(v639.clone(), sprintf!("{}", v0_1), ());
                ()
            };
            let v681: () = {
                File_system::closure9(v639.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v690: () = {
                File_system::closure9(v639.clone(), sprintf!("{}", string("ex")), ());
                ()
            };
            let v698: () = {
                File_system::closure9(v639.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v706: () = {
                File_system::closure9(v639.clone(), sprintf!("{}", v1_1), ());
                ()
            };
            let v715: () = {
                File_system::closure9(v639.clone(), sprintf!("{}", string(" }")), ());
                ()
            };
            let v777: string = trimEndChars(
                trimStartChars(
                    sprintf!(
                        "{} {} #{} {} / {}",
                        v291,
                        v618,
                        v637,
                        string("read_all_text_retry_async"),
                        v639.l0.get().clone()
                    ),
                    toArray(empty::<char>()),
                ),
                toArray(ofArray(new_array(&[' ', '/']))),
            );
            let v791: string = if v21_1.l0.get().clone() == string("") {
                v777.clone()
            } else {
                if v777.clone() == string("") {
                    v21_1.l0.get().clone()
                } else {
                    append(append(v21_1.l0.get().clone(), string("\n")), v777.clone())
                }
            };
            let v793: &str = &*v791.clone();
            let v795 = v793.chars();
            let v797 = v795;
            let v799: Vec<char> = v797.collect::<Vec<_>>();
            let v801: Vec<Vec<char>> = v799
                .chunks(15000)
                .map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>())
                .collect::<Vec<_>>();
            let v803: bool = true;
            let _vec_map: Vec<_> = v801
                .into_iter()
                .map(|x| {
                    //;
                    let v805: Vec<char> = x;
                    let v807: std::string::String = String::from_iter(v805);
                    let v809: bool = true;
                    v807
                })
                .collect::<Vec<_>>();
            let v811: Vec<std::string::String> = _vec_map;
            if if v777.clone() != string("") {
                v811.clone().len() as i32 <= 1_i32
            } else {
                false
            } {
                v21_1.l0.set(v791);
                ()
            } else {
                v21_1.l0.set(string(""));
                {
                    let v823: bool = true;
                    v811.into_iter().for_each(|x| {
                        //;
                        let v825: std::string::String = x;
                        near_sdk::log!("{}", v825);
                        {
                            let v828: bool = true;
                            let v830: bool = true;
                        }
                    });
                    {
                        //;
                        ()
                    }
                }
            }
            ();
            ((patternInput.1.clone()).l0.get().clone())(v777)
        }
    }
    pub fn method21(v0_1: string, v1_1: i64) -> Arc<Async<Option<string>>> {
        defaultOf()
    }
    pub fn closure28(unitVar: (), v0_1: string) -> Arc<Async<Option<string>>> {
        defaultOf()
    }
    pub fn closure35(
        v0_1: LrcPtr<MutCell<Option<File_system::US11>>>,
        v1_1: Option<File_system::US11>,
    ) -> LrcPtr<MutCell<Option<File_system::US11>>> {
        v0_1.set(v1_1);
        v0_1
    }
    pub fn closure36(
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
    pub fn closure34(unitVar: (), unitVar_1: ()) -> string {
        File_system::method22()
    }
    pub fn method36(v0_1: string) -> string {
        v0_1
    }
    pub fn closure38(unitVar: (), v0_1: std::io::Error) -> std::string::String {
        format!("{}", v0_1)
    }
    pub fn method37() -> Func1<std::io::Error, std::string::String> {
        Func1::new(move |v: std::io::Error| File_system::closure38((), v))
    }
    pub fn closure39(unitVar: (), unitVar_1: ()) -> File_system::US12 {
        File_system::US12::US12_0
    }
    pub fn closure40(unitVar: (), v0_1: std::string::String) -> File_system::US12 {
        File_system::US12::US12_1(v0_1)
    }
    pub fn closure41(v0_1: string, v1_1: std::string::String, unitVar: ()) {
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
        let v21_1: LrcPtr<File_system::Mut3> = patternInput.3.clone();
        let v37: () = {
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
        let v69: File_system::US0 = (patternInput_1.4.clone()).l0.get().clone();
        if if (patternInput_1.2.clone()).l0.get().clone() == false {
            false
        } else {
            4_i32
                >= find(
                    v69,
                    ofSeq(ofList(ofArray(new_array(&[
                        LrcPtr::new((File_system::US0::US0_0, 0_i32)),
                        LrcPtr::new((File_system::US0::US0_1, 1_i32)),
                        LrcPtr::new((File_system::US0::US0_2, 2_i32)),
                        LrcPtr::new((File_system::US0::US0_3, 3_i32)),
                        LrcPtr::new((File_system::US0::US0_4, 4_i32)),
                    ])))),
                )
        } {
            let v77: () = {
                File_system::closure6(patternInput.0.clone(), ());
                ()
            };
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
            let v251: u64 = near_sdk::env::block_timestamp();
            let _v252: LrcPtr<MutCell<Option<File_system::US3>>> =
                refCell(None::<File_system::US3>);
            let v257: () = {
                File_system::closure8(
                    patternInput_2.5.clone(),
                    Func1::new({
                        let _v252 = _v252.clone();
                        move |v: Option<File_system::US3>| File_system::closure7(_v252.clone(), v)
                    }),
                    (),
                );
                ()
            };
            let v272: File_system::US3 = defaultValue(File_system::US3::US3_1, _v252.get().clone());
            let v282: u64 = match &v272 {
                File_system::US3::US3_0(v272_0_0) => {
                    v251 - match &v272 {
                        File_system::US3::US3_0(x) => x.clone(),
                        _ => unreachable!(),
                    } as u64
                }
                _ => v251,
            } / 1000000000_u64;
            let v283: u64 = v282 % 60_u64;
            let v285: u64 = v282 / 60_u64 % 60_u64;
            let v287: u64 = v282 / 3600_u64 % 24_u64;
            let v289: std::string::String = format!("{:02}:{:02}:{:02}", v287, v285, v283);
            let v291: string = fable_library_rust::String_::fromString(v289);
            let v571: string = padLeft(toLower(string("Critical")), 7_i32, ' ');
            let v609: &str = inline_colorization::color_bright_red;
            let v611: &str = &*v571;
            let v613: &str = inline_colorization::color_reset;
            let v615: string = string("format!(\"{v609}{v611}{v613}\")");
            let v616: std::string::String = format!("{v609}{v611}{v613}");
            let v618: string = fable_library_rust::String_::fromString(v616);
            let v637: i64 = (patternInput_2.0.clone()).l0.get().clone();
            let v639: LrcPtr<File_system::Mut3> = LrcPtr::new(File_system::Mut3 {
                l0: MutCell::new(File_system::method13()),
            });
            let v646: () = {
                File_system::closure9(v639.clone(), sprintf!("{}", string("{ ")), ());
                ()
            };
            let v655: () = {
                File_system::closure9(v639.clone(), sprintf!("{}", string("dir")), ());
                ()
            };
            let v664: () = {
                File_system::closure9(v639.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v672: () = {
                File_system::closure9(v639.clone(), sprintf!("{}", v0_1), ());
                ()
            };
            let v681: () = {
                File_system::closure9(v639.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v690: () = {
                File_system::closure9(v639.clone(), sprintf!("{}", string("error")), ());
                ()
            };
            let v698: () = {
                File_system::closure9(v639.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v711: std::string::String = format!("{:#?}", v1_1);
            let v733: () = {
                File_system::closure9(
                    v639.clone(),
                    sprintf!("{}", fable_library_rust::String_::fromString(v711)),
                    (),
                );
                ()
            };
            let v742: () = {
                File_system::closure9(v639.clone(), sprintf!("{}", string(" }")), ());
                ()
            };
            let v784: string = trimEndChars(
                trimStartChars(
                    sprintf!(
                        "{} {} #{} {} / {}",
                        v291,
                        v618,
                        v637,
                        string("file_system.create_dir"),
                        v639.l0.get().clone()
                    ),
                    toArray(empty::<char>()),
                ),
                toArray(ofArray(new_array(&[' ', '/']))),
            );
            let v815: string = if v21_1.l0.get().clone() == string("") {
                v784.clone()
            } else {
                if v784.clone() == string("") {
                    v21_1.l0.get().clone()
                } else {
                    append(append(v21_1.l0.get().clone(), string("\n")), v784.clone())
                }
            };
            let v817: &str = &*v815.clone();
            let v819 = v817.chars();
            let v821 = v819;
            let v823: Vec<char> = v821.collect::<Vec<_>>();
            let v825: Vec<Vec<char>> = v823
                .chunks(15000)
                .map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>())
                .collect::<Vec<_>>();
            let v827: bool = true;
            let _vec_map: Vec<_> = v825
                .into_iter()
                .map(|x| {
                    //;
                    let v829: Vec<char> = x;
                    let v831: std::string::String = String::from_iter(v829);
                    let v833: bool = true;
                    v831
                })
                .collect::<Vec<_>>();
            let v835: Vec<std::string::String> = _vec_map;
            if if v784.clone() != string("") {
                v835.clone().len() as i32 <= 1_i32
            } else {
                false
            } {
                v21_1.l0.set(v815);
                ()
            } else {
                v21_1.l0.set(string(""));
                {
                    let v847: bool = true;
                    v835.into_iter().for_each(|x| {
                        //;
                        let v849: std::string::String = x;
                        near_sdk::log!("{}", v849);
                        {
                            let v852: bool = true;
                            let v854: bool = true;
                        }
                    });
                    {
                        //;
                        ()
                    }
                }
            }
            ();
            ((patternInput.1.clone()).l0.get().clone())(v784)
        }
    }
    pub fn closure42(v0_1: string, unitVar: ()) {
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
        let v20_1: LrcPtr<File_system::Mut3> = patternInput.3.clone();
        let v36: () = {
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
        let v68: File_system::US0 = (patternInput_1.4.clone()).l0.get().clone();
        if if (patternInput_1.2.clone()).l0.get().clone() == false {
            false
        } else {
            0_i32
                >= find(
                    v68,
                    ofSeq(ofList(ofArray(new_array(&[
                        LrcPtr::new((File_system::US0::US0_0, 0_i32)),
                        LrcPtr::new((File_system::US0::US0_1, 1_i32)),
                        LrcPtr::new((File_system::US0::US0_2, 2_i32)),
                        LrcPtr::new((File_system::US0::US0_3, 3_i32)),
                        LrcPtr::new((File_system::US0::US0_4, 4_i32)),
                    ])))),
                )
        } {
            let v76: () = {
                File_system::closure6(patternInput.0.clone(), ());
                ()
            };
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
            let v250: u64 = near_sdk::env::block_timestamp();
            let _v251: LrcPtr<MutCell<Option<File_system::US3>>> =
                refCell(None::<File_system::US3>);
            let v256: () = {
                File_system::closure8(
                    patternInput_2.5.clone(),
                    Func1::new({
                        let _v251 = _v251.clone();
                        move |v: Option<File_system::US3>| File_system::closure7(_v251.clone(), v)
                    }),
                    (),
                );
                ()
            };
            let v271: File_system::US3 = defaultValue(File_system::US3::US3_1, _v251.get().clone());
            let v281: u64 = match &v271 {
                File_system::US3::US3_0(v271_0_0) => {
                    v250 - match &v271 {
                        File_system::US3::US3_0(x) => x.clone(),
                        _ => unreachable!(),
                    } as u64
                }
                _ => v250,
            } / 1000000000_u64;
            let v282: u64 = v281 % 60_u64;
            let v284: u64 = v281 / 60_u64 % 60_u64;
            let v286: u64 = v281 / 3600_u64 % 24_u64;
            let v288: std::string::String = format!("{:02}:{:02}:{:02}", v286, v284, v282);
            let v290: string = fable_library_rust::String_::fromString(v288);
            let v570: string = padLeft(toLower(string("Verbose")), 7_i32, ' ');
            let v608: &str = inline_colorization::color_bright_black;
            let v610: &str = &*v570;
            let v612: &str = inline_colorization::color_reset;
            let v614: string = string("format!(\"{v608}{v610}{v612}\")");
            let v615: std::string::String = format!("{v608}{v610}{v612}");
            let v617: string = fable_library_rust::String_::fromString(v615);
            let v636: i64 = (patternInput_2.0.clone()).l0.get().clone();
            let v638: LrcPtr<File_system::Mut3> = LrcPtr::new(File_system::Mut3 {
                l0: MutCell::new(File_system::method13()),
            });
            let v645: () = {
                File_system::closure9(v638.clone(), sprintf!("{}", string("{ ")), ());
                ()
            };
            let v654: () = {
                File_system::closure9(v638.clone(), sprintf!("{}", string("dir")), ());
                ()
            };
            let v663: () = {
                File_system::closure9(v638.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v671: () = {
                File_system::closure9(v638.clone(), sprintf!("{}", v0_1), ());
                ()
            };
            let v680: () = {
                File_system::closure9(v638.clone(), sprintf!("{}", string(" }")), ());
                ()
            };
            let v722: string = trimEndChars(
                trimStartChars(
                    sprintf!(
                        "{} {} #{} {} / {}",
                        v290,
                        v617,
                        v636,
                        string("file_system.create_dir"),
                        v638.l0.get().clone()
                    ),
                    toArray(empty::<char>()),
                ),
                toArray(ofArray(new_array(&[' ', '/']))),
            );
            let v753: string = if v20_1.l0.get().clone() == string("") {
                v722.clone()
            } else {
                if v722.clone() == string("") {
                    v20_1.l0.get().clone()
                } else {
                    append(append(v20_1.l0.get().clone(), string("\n")), v722.clone())
                }
            };
            let v755: &str = &*v753.clone();
            let v757 = v755.chars();
            let v759 = v757;
            let v761: Vec<char> = v759.collect::<Vec<_>>();
            let v763: Vec<Vec<char>> = v761
                .chunks(15000)
                .map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>())
                .collect::<Vec<_>>();
            let v765: bool = true;
            let _vec_map: Vec<_> = v763
                .into_iter()
                .map(|x| {
                    //;
                    let v767: Vec<char> = x;
                    let v769: std::string::String = String::from_iter(v767);
                    let v771: bool = true;
                    v769
                })
                .collect::<Vec<_>>();
            let v773: Vec<std::string::String> = _vec_map;
            if if v722.clone() != string("") {
                v773.clone().len() as i32 <= 1_i32
            } else {
                false
            } {
                v20_1.l0.set(v753);
                ()
            } else {
                v20_1.l0.set(string(""));
                {
                    let v785: bool = true;
                    v773.into_iter().for_each(|x| {
                        //;
                        let v787: std::string::String = x;
                        near_sdk::log!("{}", v787);
                        {
                            let v790: bool = true;
                            let v792: bool = true;
                        }
                    });
                    {
                        //;
                        ()
                    }
                }
            }
            ();
            ((patternInput.1.clone()).l0.get().clone())(v722)
        }
    }
    pub fn closure43(v0_1: string, unitVar: ()) {
        File_system::method6(true, v0_1);
    }
    pub fn method38(v0_1: string) -> Func0<()> {
        Func0::new({
            let v0_1 = v0_1.clone();
            move || File_system::closure43(v0_1.clone(), ())
        })
    }
    pub fn method39(v0_1: string) -> Func0<()> {
        Func0::new({
            let v0_1 = v0_1.clone();
            move || File_system::closure43(v0_1.clone(), ())
        })
    }
    pub fn closure44(v0_1: string, v1_1: string, unitVar: ()) {
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
        let v21_1: LrcPtr<File_system::Mut3> = patternInput.3.clone();
        let v37: () = {
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
        let v69: File_system::US0 = (patternInput_1.4.clone()).l0.get().clone();
        if if (patternInput_1.2.clone()).l0.get().clone() == false {
            false
        } else {
            1_i32
                >= find(
                    v69,
                    ofSeq(ofList(ofArray(new_array(&[
                        LrcPtr::new((File_system::US0::US0_0, 0_i32)),
                        LrcPtr::new((File_system::US0::US0_1, 1_i32)),
                        LrcPtr::new((File_system::US0::US0_2, 2_i32)),
                        LrcPtr::new((File_system::US0::US0_3, 3_i32)),
                        LrcPtr::new((File_system::US0::US0_4, 4_i32)),
                    ])))),
                )
        } {
            let v77: () = {
                File_system::closure6(patternInput.0.clone(), ());
                ()
            };
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
            let v251: u64 = near_sdk::env::block_timestamp();
            let _v252: LrcPtr<MutCell<Option<File_system::US3>>> =
                refCell(None::<File_system::US3>);
            let v257: () = {
                File_system::closure8(
                    patternInput_2.5.clone(),
                    Func1::new({
                        let _v252 = _v252.clone();
                        move |v: Option<File_system::US3>| File_system::closure7(_v252.clone(), v)
                    }),
                    (),
                );
                ()
            };
            let v272: File_system::US3 = defaultValue(File_system::US3::US3_1, _v252.get().clone());
            let v282: u64 = match &v272 {
                File_system::US3::US3_0(v272_0_0) => {
                    v251 - match &v272 {
                        File_system::US3::US3_0(x) => x.clone(),
                        _ => unreachable!(),
                    } as u64
                }
                _ => v251,
            } / 1000000000_u64;
            let v283: u64 = v282 % 60_u64;
            let v285: u64 = v282 / 60_u64 % 60_u64;
            let v287: u64 = v282 / 3600_u64 % 24_u64;
            let v289: std::string::String = format!("{:02}:{:02}:{:02}", v287, v285, v283);
            let v291: string = fable_library_rust::String_::fromString(v289);
            let v571: string = padLeft(toLower(string("Debug")), 7_i32, ' ');
            let v609: &str = inline_colorization::color_bright_blue;
            let v611: &str = &*v571;
            let v613: &str = inline_colorization::color_reset;
            let v615: string = string("format!(\"{v609}{v611}{v613}\")");
            let v616: std::string::String = format!("{v609}{v611}{v613}");
            let v618: string = fable_library_rust::String_::fromString(v616);
            let v637: i64 = (patternInput_2.0.clone()).l0.get().clone();
            let v639: LrcPtr<File_system::Mut3> = LrcPtr::new(File_system::Mut3 {
                l0: MutCell::new(File_system::method13()),
            });
            let v646: () = {
                File_system::closure9(v639.clone(), sprintf!("{}", string("{ ")), ());
                ()
            };
            let v655: () = {
                File_system::closure9(v639.clone(), sprintf!("{}", string("dir")), ());
                ()
            };
            let v664: () = {
                File_system::closure9(v639.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v672: () = {
                File_system::closure9(v639.clone(), sprintf!("{}", v0_1), ());
                ()
            };
            let v681: () = {
                File_system::closure9(v639.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v690: () = {
                File_system::closure9(v639.clone(), sprintf!("{}", string("result")), ());
                ()
            };
            let v698: () = {
                File_system::closure9(v639.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v706: () = {
                File_system::closure9(v639.clone(), sprintf!("{}", v1_1), ());
                ()
            };
            let v715: () = {
                File_system::closure9(v639.clone(), sprintf!("{}", string(" }")), ());
                ()
            };
            let v757: string = trimEndChars(
                trimStartChars(
                    sprintf!(
                        "{} {} #{} {} / {}",
                        v291,
                        v618,
                        v637,
                        string("file_system.create_dir"),
                        v639.l0.get().clone()
                    ),
                    toArray(empty::<char>()),
                ),
                toArray(ofArray(new_array(&[' ', '/']))),
            );
            let v788: string = if v21_1.l0.get().clone() == string("") {
                v757.clone()
            } else {
                if v757.clone() == string("") {
                    v21_1.l0.get().clone()
                } else {
                    append(append(v21_1.l0.get().clone(), string("\n")), v757.clone())
                }
            };
            let v790: &str = &*v788.clone();
            let v792 = v790.chars();
            let v794 = v792;
            let v796: Vec<char> = v794.collect::<Vec<_>>();
            let v798: Vec<Vec<char>> = v796
                .chunks(15000)
                .map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>())
                .collect::<Vec<_>>();
            let v800: bool = true;
            let _vec_map: Vec<_> = v798
                .into_iter()
                .map(|x| {
                    //;
                    let v802: Vec<char> = x;
                    let v804: std::string::String = String::from_iter(v802);
                    let v806: bool = true;
                    v804
                })
                .collect::<Vec<_>>();
            let v808: Vec<std::string::String> = _vec_map;
            if if v757.clone() != string("") {
                v808.clone().len() as i32 <= 1_i32
            } else {
                false
            } {
                v21_1.l0.set(v788);
                ()
            } else {
                v21_1.l0.set(string(""));
                {
                    let v820: bool = true;
                    v808.into_iter().for_each(|x| {
                        //;
                        let v822: std::string::String = x;
                        near_sdk::log!("{}", v822);
                        {
                            let v825: bool = true;
                            let v827: bool = true;
                        }
                    });
                    {
                        //;
                        ()
                    }
                }
            }
            ();
            ((patternInput.1.clone()).l0.get().clone())(v757)
        }
    }
    pub fn closure45(v0_1: string, unitVar: ()) {
        let v8: Arc<Async<i64>> = defaultOf();
        let v31_1: Arc<Async<()>> = defaultOf();
        defaultOf::<()>();
        ();
        ()
    }
    pub fn method40(v0_1: string) -> Func0<()> {
        Func0::new({
            let v0_1 = v0_1.clone();
            move || File_system::closure45(v0_1.clone(), ())
        })
    }
    pub fn method41(v0_1: string) -> Func0<()> {
        Func0::new({
            let v0_1 = v0_1.clone();
            move || File_system::closure45(v0_1.clone(), ())
        })
    }
    pub fn method35(v0_1: string) -> LrcPtr<dyn IDisposable> {
        interface_cast!(
            defaultOf::<std::rc::Rc<dyn IDisposable>>(),
            Lrc<dyn IDisposable>,
        )
    }
    pub fn closure37(unitVar: (), unitVar_1: ()) -> (string, LrcPtr<dyn IDisposable>) {
        let v0_1: string = File_system::method22();
        (v0_1.clone(), File_system::method35(v0_1))
    }
    pub fn method42(v0_1: string) -> Guid {
        unbox::<Guid>(&defaultOf())
    }
    pub fn closure46(unitVar: (), v0_1: string) -> (string, LrcPtr<dyn IDisposable>) {
        let v2_1: string = File_system::method27(File_system::method42(v0_1));
        (v2_1.clone(), File_system::method35(v2_1))
    }
    pub fn closure47(unitVar: (), unitVar_1: ()) -> string {
        string("C:\\home\\git\\polyglot\\lib\\spiral")
    }
    pub fn method44(v0_1: string) -> string {
        v0_1
    }
    pub fn method43(v0_1: string) -> string {
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
    pub fn closure48(unitVar: (), v0_1: string) -> string {
        File_system::method43(v0_1)
    }
    pub fn closure49(unitVar: (), v0_1: string) -> string {
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
    pub fn closure51(unitVar: (), v0_1: string) -> Option<string> {
        File_system::method47(v0_1)
    }
    pub fn method46() -> Func1<string, Option<string>> {
        Func1::new(move |v: string| File_system::closure51((), v))
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
                let v7: Option<string> = (File_system::method46())(v2_1.get().clone());
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
            let v6: Option<string> = (File_system::method46())(v1_1.clone());
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
                File_system::US1::US1_0(v27_1_0_0) => File_system::method48(
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
    pub fn closure52(v0_1: string, unitVar: ()) {
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
        let v20_1: LrcPtr<File_system::Mut3> = patternInput.3.clone();
        let v36: () = {
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
        let v68: File_system::US0 = (patternInput_1.4.clone()).l0.get().clone();
        if if (patternInput_1.2.clone()).l0.get().clone() == false {
            false
        } else {
            3_i32
                >= find(
                    v68,
                    ofSeq(ofList(ofArray(new_array(&[
                        LrcPtr::new((File_system::US0::US0_0, 0_i32)),
                        LrcPtr::new((File_system::US0::US0_1, 1_i32)),
                        LrcPtr::new((File_system::US0::US0_2, 2_i32)),
                        LrcPtr::new((File_system::US0::US0_3, 3_i32)),
                        LrcPtr::new((File_system::US0::US0_4, 4_i32)),
                    ])))),
                )
        } {
            let v76: () = {
                File_system::closure6(patternInput.0.clone(), ());
                ()
            };
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
            let v250: u64 = near_sdk::env::block_timestamp();
            let _v251: LrcPtr<MutCell<Option<File_system::US3>>> =
                refCell(None::<File_system::US3>);
            let v256: () = {
                File_system::closure8(
                    patternInput_2.5.clone(),
                    Func1::new({
                        let _v251 = _v251.clone();
                        move |v: Option<File_system::US3>| File_system::closure7(_v251.clone(), v)
                    }),
                    (),
                );
                ()
            };
            let v271: File_system::US3 = defaultValue(File_system::US3::US3_1, _v251.get().clone());
            let v281: u64 = match &v271 {
                File_system::US3::US3_0(v271_0_0) => {
                    v250 - match &v271 {
                        File_system::US3::US3_0(x) => x.clone(),
                        _ => unreachable!(),
                    } as u64
                }
                _ => v250,
            } / 1000000000_u64;
            let v282: u64 = v281 % 60_u64;
            let v284: u64 = v281 / 60_u64 % 60_u64;
            let v286: u64 = v281 / 3600_u64 % 24_u64;
            let v288: std::string::String = format!("{:02}:{:02}:{:02}", v286, v284, v282);
            let v290: string = fable_library_rust::String_::fromString(v288);
            let v570: string = padLeft(toLower(string("Warning")), 7_i32, ' ');
            let v608: &str = inline_colorization::color_yellow;
            let v610: &str = &*v570;
            let v612: &str = inline_colorization::color_reset;
            let v614: string = string("format!(\"{v608}{v610}{v612}\")");
            let v615: std::string::String = format!("{v608}{v610}{v612}");
            let v617: string = fable_library_rust::String_::fromString(v615);
            let v636: i64 = (patternInput_2.0.clone()).l0.get().clone();
            let v638: LrcPtr<File_system::Mut3> = LrcPtr::new(File_system::Mut3 {
                l0: MutCell::new(File_system::method13()),
            });
            let v645: () = {
                File_system::closure9(v638.clone(), sprintf!("{}", string("{ ")), ());
                ()
            };
            let v654: () = {
                File_system::closure9(v638.clone(), sprintf!("{}", string("error")), ());
                ()
            };
            let v663: () = {
                File_system::closure9(v638.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v671: () = {
                File_system::closure9(v638.clone(), sprintf!("{}", v0_1), ());
                ()
            };
            let v680: () = {
                File_system::closure9(v638.clone(), sprintf!("{}", string(" }")), ());
                ()
            };
            let v722: string = trimEndChars(
                trimStartChars(
                    sprintf!(
                        "{} {} #{} {} / {}",
                        v290,
                        v617,
                        v636,
                        string("file_system.get_workspace_root"),
                        v638.l0.get().clone()
                    ),
                    toArray(empty::<char>()),
                ),
                toArray(ofArray(new_array(&[' ', '/']))),
            );
            let v753: string = if v20_1.l0.get().clone() == string("") {
                v722.clone()
            } else {
                if v722.clone() == string("") {
                    v20_1.l0.get().clone()
                } else {
                    append(append(v20_1.l0.get().clone(), string("\n")), v722.clone())
                }
            };
            let v755: &str = &*v753.clone();
            let v757 = v755.chars();
            let v759 = v757;
            let v761: Vec<char> = v759.collect::<Vec<_>>();
            let v763: Vec<Vec<char>> = v761
                .chunks(15000)
                .map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>())
                .collect::<Vec<_>>();
            let v765: bool = true;
            let _vec_map: Vec<_> = v763
                .into_iter()
                .map(|x| {
                    //;
                    let v767: Vec<char> = x;
                    let v769: std::string::String = String::from_iter(v767);
                    let v771: bool = true;
                    v769
                })
                .collect::<Vec<_>>();
            let v773: Vec<std::string::String> = _vec_map;
            if if v722.clone() != string("") {
                v773.clone().len() as i32 <= 1_i32
            } else {
                false
            } {
                v20_1.l0.set(v753);
                ()
            } else {
                v20_1.l0.set(string(""));
                {
                    let v785: bool = true;
                    v773.into_iter().for_each(|x| {
                        //;
                        let v787: std::string::String = x;
                        near_sdk::log!("{}", v787);
                        {
                            let v790: bool = true;
                            let v792: bool = true;
                        }
                    });
                    {
                        //;
                        ()
                    }
                }
            }
            ();
            ((patternInput.1.clone()).l0.get().clone())(v722)
        }
    }
    pub fn method49() -> string {
        unbox::<string>(&defaultOf())
    }
    pub fn closure50(unitVar: (), unitVar_1: ()) -> string {
        let v4: File_system::US13 = File_system::method45(
            File_system::method30(string("polyglot"), string(".devcontainer")),
            string("C:\\home\\git\\polyglot\\lib\\spiral"),
        );
        let v806: File_system::US1 = match &v4 {
            File_system::US13::US13_0(v4_0_0) => File_system::US1::US1_0(v4_0_0.clone()),
            File_system::US13::US13_1(v4_1_0) => {
                let v10: () = {
                    File_system::closure52(v4_1_0.clone(), ());
                    ()
                };
                File_system::US1::US1_1
            }
        };
        let v1615: File_system::US1 = match &v806 {
            File_system::US1::US1_0(v806_0_0) => File_system::US1::US1_0(match &v806 {
                File_system::US1::US1_0(x) => x.clone(),
                _ => unreachable!(),
            }),
            _ => {
                let v809: string = File_system::method49();
                let v811: File_system::US13 = File_system::method45(
                    File_system::method30(string("polyglot"), string(".devcontainer")),
                    v809,
                );
                match &v811 {
                    File_system::US13::US13_0(v811_0_0) => {
                        File_system::US1::US1_0(v811_0_0.clone())
                    }
                    File_system::US13::US13_1(v811_1_0) => {
                        let v817: () = {
                            File_system::closure52(v811_1_0.clone(), ());
                            ()
                        };
                        File_system::US1::US1_1
                    }
                }
            }
        };
        File_system::method30(
            match &v1615 {
                File_system::US1::US1_0(v1615_0_0) => match &v1615 {
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
    pub fn closure54(unitVar: (), v0_1: string) {
        File_system::method50(v0_1);
    }
    pub fn closure53(unitVar: (), v0_1: bool) {
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
            Func1::new(move |v: string| File_system::closure54((), v))
        } else {
            Func1::new(move |v_1: string| File_system::closure3((), v_1))
        };
        (patternInput.1.clone()).l0.set(v37);
        ()
    }
    pub fn closure56(v0_1: string, v1_1: string) -> string {
        File_system::method30(v0_1, v1_1)
    }
    pub fn closure55(unitVar: (), v0_1: string) -> Func1<string, string> {
        Func1::new({
            let v0_1 = v0_1.clone();
            move |v: string| File_system::closure56(v0_1.clone(), v)
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
        v16.get_or_init(|| Func1::new(move |v: string| File_system::closure4((), v)))
            .clone()
    }
    pub fn delete_directory_async(x: string) -> Arc<Async<i64>> {
        (File_system::v16())(x)
    }
    pub fn v17() -> Func1<File_system::US6, Func1<string, Arc<Async<i64>>>> {
        static v17: OnceInit<Func1<File_system::US6, Func1<string, Arc<Async<i64>>>>> =
            OnceInit::new();
        v17.get_or_init(|| Func1::new(move |v: File_system::US6| File_system::closure12((), v)))
            .clone()
    }
    pub fn wait_for_file_access(x: File_system::US6) -> Func1<string, Arc<Async<i64>>> {
        (File_system::v17())(x)
    }
    pub fn v18() -> Func1<string, Arc<Async<i64>>> {
        static v18: OnceInit<Func1<string, Arc<Async<i64>>>> = OnceInit::new();
        v18.get_or_init(|| Func1::new(move |v: string| File_system::closure15((), v)))
            .clone()
    }
    pub fn wait_for_file_access_read(x: string) -> Arc<Async<i64>> {
        (File_system::v18())(x)
    }
    pub fn v19() -> Func1<string, Arc<Async<string>>> {
        static v19: OnceInit<Func1<string, Arc<Async<string>>>> = OnceInit::new();
        v19.get_or_init(|| Func1::new(move |v: string| File_system::closure16((), v)))
            .clone()
    }
    pub fn read_all_text_async(x: string) -> Arc<Async<string>> {
        (File_system::v19())(x)
    }
    pub fn v20() -> Func1<string, Func1<string, bool>> {
        static v20: OnceInit<Func1<string, Func1<string, bool>>> = OnceInit::new();
        v20.get_or_init(|| Func1::new(move |v: string| File_system::closure17((), v)))
            .clone()
    }
    pub fn file_exists_content(x: string) -> Func1<string, bool> {
        (File_system::v20())(x)
    }
    pub fn v21() -> Func1<string, Func1<string, Arc<Async<()>>>> {
        static v21: OnceInit<Func1<string, Func1<string, Arc<Async<()>>>>> = OnceInit::new();
        v21.get_or_init(|| Func1::new(move |v: string| File_system::closure19((), v)))
            .clone()
    }
    pub fn write_all_text_async(x: string) -> Func1<string, Arc<Async<()>>> {
        (File_system::v21())(x)
    }
    pub fn v22() -> Func1<string, Func1<string, Arc<Async<()>>>> {
        static v22: OnceInit<Func1<string, Func1<string, Arc<Async<()>>>>> = OnceInit::new();
        v22.get_or_init(|| Func1::new(move |v: string| File_system::closure21((), v)))
            .clone()
    }
    pub fn write_all_text_exists(x: string) -> Func1<string, Arc<Async<()>>> {
        (File_system::v22())(x)
    }
    pub fn v23() -> Func1<string, Arc<Async<i64>>> {
        static v23: OnceInit<Func1<string, Arc<Async<i64>>>> = OnceInit::new();
        v23.get_or_init(|| Func1::new(move |v: string| File_system::closure23((), v)))
            .clone()
    }
    pub fn delete_file_async(x: string) -> Arc<Async<i64>> {
        (File_system::v23())(x)
    }
    pub fn v24() -> Func1<string, Func1<string, Arc<Async<i64>>>> {
        static v24: OnceInit<Func1<string, Func1<string, Arc<Async<i64>>>>> = OnceInit::new();
        v24.get_or_init(|| Func1::new(move |v: string| File_system::closure25((), v)))
            .clone()
    }
    pub fn move_file_async(x: string) -> Func1<string, Arc<Async<i64>>> {
        (File_system::v24())(x)
    }
    pub fn v25() -> Func1<string, Arc<Async<Option<string>>>> {
        static v25: OnceInit<Func1<string, Arc<Async<Option<string>>>>> = OnceInit::new();
        v25.get_or_init(|| Func1::new(move |v: string| File_system::closure28((), v)))
            .clone()
    }
    pub fn read_all_text_retry_async(x: string) -> Arc<Async<Option<string>>> {
        (File_system::v25())(x)
    }
    pub fn v26() -> Func0<string> {
        static v26: OnceInit<Func0<string>> = OnceInit::new();
        v26.get_or_init(|| Func0::new(move || File_system::closure34((), ())))
            .clone()
    }
    pub fn create_temp_path() -> string {
        (File_system::v26())()
    }
    pub fn v27() -> Func0<(string, LrcPtr<dyn IDisposable>)> {
        static v27: OnceInit<Func0<(string, LrcPtr<dyn IDisposable>)>> = OnceInit::new();
        v27.get_or_init(|| Func0::new(move || File_system::closure37((), ())))
            .clone()
    }
    pub fn create_temp_dir() -> (string, LrcPtr<dyn IDisposable>) {
        (File_system::v27())()
    }
    pub fn v28() -> Func1<string, (string, LrcPtr<dyn IDisposable>)> {
        static v28: OnceInit<Func1<string, (string, LrcPtr<dyn IDisposable>)>> = OnceInit::new();
        v28.get_or_init(|| Func1::new(move |v: string| File_system::closure46((), v)))
            .clone()
    }
    pub fn create_temp_dir_(x: string) -> (string, LrcPtr<dyn IDisposable>) {
        (File_system::v28())(x)
    }
    pub fn v29() -> Func0<string> {
        static v29: OnceInit<Func0<string>> = OnceInit::new();
        v29.get_or_init(|| Func0::new(move || File_system::closure47((), ())))
            .clone()
    }
    pub fn get_source_directory() -> string {
        (File_system::v29())()
    }
    pub fn v30() -> Func1<string, string> {
        static v30: OnceInit<Func1<string, string>> = OnceInit::new();
        v30.get_or_init(|| Func1::new(move |v: string| File_system::closure48((), v)))
            .clone()
    }
    pub fn normalize_path(x: string) -> string {
        (File_system::v30())(x)
    }
    pub fn v31() -> Func1<string, string> {
        static v31: OnceInit<Func1<string, string>> = OnceInit::new();
        v31.get_or_init(|| Func1::new(move |v: string| File_system::closure49((), v)))
            .clone()
    }
    pub fn new_file_uri(x: string) -> string {
        (File_system::v31())(x)
    }
    pub fn v32() -> Func0<string> {
        static v32: OnceInit<Func0<string>> = OnceInit::new();
        v32.get_or_init(|| Func0::new(move || File_system::closure50((), ())))
            .clone()
    }
    pub fn get_workspace_root() -> string {
        (File_system::v32())()
    }
    pub fn v33() -> Func1<bool, ()> {
        static v33: OnceInit<Func1<bool, ()>> = OnceInit::new();
        v33.get_or_init(|| Func1::new(move |v: bool| File_system::closure53((), v)))
            .clone()
    }
    pub fn init_trace_file(x: bool) {
        (File_system::v33())(x);
    }
    pub fn v34() -> Func1<string, Func1<string, string>> {
        static v34: OnceInit<Func1<string, Func1<string, string>>> = OnceInit::new();
        v34.get_or_init(|| Func1::new(move |v: string| File_system::closure55((), v)))
            .clone()
    }
    pub fn op_LessDivideGreater(x: string) -> Func1<string, string> {
        (File_system::v34())(x)
    }
    on_startup!(());
}
