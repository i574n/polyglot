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
                    Option<i64>,
                    LrcPtr<File_system::Mut3>,
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
                            Option<i64>,
                            LrcPtr<File_system::Mut3>,
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
                            Option<i64>,
                            LrcPtr<File_system::Mut3>,
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
    impl File_system::US0 {
        pub fn get_IsUS0_0(this_: &MutCell<File_system::US0>, unitArg: ()) -> bool {
            if unreachable!() {
                true
            } else {
                false
            }
        }
        pub fn get_IsUS0_1(this_: &MutCell<File_system::US0>, unitArg: ()) -> bool {
            if unreachable!() {
                true
            } else {
                false
            }
        }
        pub fn get_IsUS0_2(this_: &MutCell<File_system::US0>, unitArg: ()) -> bool {
            if unreachable!() {
                true
            } else {
                false
            }
        }
        pub fn get_IsUS0_3(this_: &MutCell<File_system::US0>, unitArg: ()) -> bool {
            if unreachable!() {
                true
            } else {
                false
            }
        }
        pub fn get_IsUS0_4(this_: &MutCell<File_system::US0>, unitArg: ()) -> bool {
            if unreachable!() {
                true
            } else {
                false
            }
        }
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
    #[derive(Clone, Debug, Default, PartialEq, PartialOrd, Hash, Eq)]
    pub struct Mut1 {
        pub l0: MutCell<bool>,
    }
    impl core::fmt::Display for File_system::Mut1 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Debug, PartialEq, PartialOrd, Hash, Eq)]
    pub struct Mut2 {
        pub l0: MutCell<File_system::US0>,
    }
    impl core::fmt::Display for File_system::Mut2 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Debug)]
    pub struct Mut3 {
        pub l0: MutCell<Func1<string, ()>>,
    }
    impl core::fmt::Display for File_system::Mut3 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Copy, Debug, PartialEq, PartialOrd, Hash, Eq)]
    pub enum US1 {
        US1_0(i64),
        US1_1,
    }
    impl File_system::US1 {
        pub fn get_IsUS1_0(this_: &MutCell<File_system::US1>, unitArg: ()) -> bool {
            if unreachable!() {
                true
            } else {
                false
            }
        }
        pub fn get_IsUS1_1(this_: &MutCell<File_system::US1>, unitArg: ()) -> bool {
            if unreachable!() {
                true
            } else {
                false
            }
        }
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
    impl File_system::US2 {
        pub fn get_IsUS2_0(this_: &MutCell<File_system::US2>, unitArg: ()) -> bool {
            if unreachable!() {
                true
            } else {
                false
            }
        }
        pub fn get_IsUS2_1(this_: &MutCell<File_system::US2>, unitArg: ()) -> bool {
            if unreachable!() {
                true
            } else {
                false
            }
        }
    }
    impl core::fmt::Display for File_system::US2 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Debug, PartialEq, PartialOrd, Hash, Eq)]
    pub enum US3 {
        US3_0(string),
        US3_1,
    }
    impl File_system::US3 {
        pub fn get_IsUS3_0(this_: &MutCell<File_system::US3>, unitArg: ()) -> bool {
            if unreachable!() {
                true
            } else {
                false
            }
        }
        pub fn get_IsUS3_1(this_: &MutCell<File_system::US3>, unitArg: ()) -> bool {
            if unreachable!() {
                true
            } else {
                false
            }
        }
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
    impl File_system::US4 {
        pub fn get_IsUS4_0(this_: &MutCell<File_system::US4>, unitArg: ()) -> bool {
            if unreachable!() {
                true
            } else {
                false
            }
        }
        pub fn get_IsUS4_1(this_: &MutCell<File_system::US4>, unitArg: ()) -> bool {
            if unreachable!() {
                true
            } else {
                false
            }
        }
        pub fn get_IsUS4_2(this_: &MutCell<File_system::US4>, unitArg: ()) -> bool {
            if unreachable!() {
                true
            } else {
                false
            }
        }
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
    impl File_system::US5 {
        pub fn get_IsUS5_0(this_: &MutCell<File_system::US5>, unitArg: ()) -> bool {
            if unreachable!() {
                true
            } else {
                false
            }
        }
        pub fn get_IsUS5_1(this_: &MutCell<File_system::US5>, unitArg: ()) -> bool {
            if unreachable!() {
                true
            } else {
                false
            }
        }
        pub fn get_IsUS5_2(this_: &MutCell<File_system::US5>, unitArg: ()) -> bool {
            if unreachable!() {
                true
            } else {
                false
            }
        }
        pub fn get_IsUS5_3(this_: &MutCell<File_system::US5>, unitArg: ()) -> bool {
            if unreachable!() {
                true
            } else {
                false
            }
        }
        pub fn get_IsUS5_4(this_: &MutCell<File_system::US5>, unitArg: ()) -> bool {
            if unreachable!() {
                true
            } else {
                false
            }
        }
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
    impl File_system::US7 {
        pub fn get_IsUS7_0(this_: &MutCell<File_system::US7>, unitArg: ()) -> bool {
            if unreachable!() {
                true
            } else {
                false
            }
        }
        pub fn get_IsUS7_1(this_: &MutCell<File_system::US7>, unitArg: ()) -> bool {
            if unreachable!() {
                true
            } else {
                false
            }
        }
        pub fn get_IsUS7_2(this_: &MutCell<File_system::US7>, unitArg: ()) -> bool {
            if unreachable!() {
                true
            } else {
                false
            }
        }
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
    impl File_system::US8 {
        pub fn get_IsUS8_0(this_: &MutCell<File_system::US8>, unitArg: ()) -> bool {
            if unreachable!() {
                true
            } else {
                false
            }
        }
        pub fn get_IsUS8_1(this_: &MutCell<File_system::US8>, unitArg: ()) -> bool {
            if unreachable!() {
                true
            } else {
                false
            }
        }
        pub fn get_IsUS8_2(this_: &MutCell<File_system::US8>, unitArg: ()) -> bool {
            if unreachable!() {
                true
            } else {
                false
            }
        }
        pub fn get_IsUS8_3(this_: &MutCell<File_system::US8>, unitArg: ()) -> bool {
            if unreachable!() {
                true
            } else {
                false
            }
        }
        pub fn get_IsUS8_4(this_: &MutCell<File_system::US8>, unitArg: ()) -> bool {
            if unreachable!() {
                true
            } else {
                false
            }
        }
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
    impl File_system::US6 {
        pub fn get_IsUS6_0(this_: &MutCell<File_system::US6>, unitArg: ()) -> bool {
            if unreachable!() {
                true
            } else {
                false
            }
        }
        pub fn get_IsUS6_1(this_: &MutCell<File_system::US6>, unitArg: ()) -> bool {
            if unreachable!() {
                true
            } else {
                false
            }
        }
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
    impl File_system::US9 {
        pub fn get_IsUS9_0(this_: &MutCell<File_system::US9>, unitArg: ()) -> bool {
            if unreachable!() {
                true
            } else {
                false
            }
        }
        pub fn get_IsUS9_1(this_: &MutCell<File_system::US9>, unitArg: ()) -> bool {
            if unreachable!() {
                true
            } else {
                false
            }
        }
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
    impl File_system::US10 {
        pub fn get_IsUS10_0(this_: &MutCell<File_system::US10>, unitArg: ()) -> bool {
            if unreachable!() {
                true
            } else {
                false
            }
        }
        pub fn get_IsUS10_1(this_: &MutCell<File_system::US10>, unitArg: ()) -> bool {
            if unreachable!() {
                true
            } else {
                false
            }
        }
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
    impl File_system::US11 {
        pub fn get_IsUS11_0(this_: &MutCell<File_system::US11>, unitArg: ()) -> bool {
            if unreachable!() {
                true
            } else {
                false
            }
        }
        pub fn get_IsUS11_1(this_: &MutCell<File_system::US11>, unitArg: ()) -> bool {
            if unreachable!() {
                true
            } else {
                false
            }
        }
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
    impl File_system::US12 {
        pub fn get_IsUS12_0(this_: &MutCell<File_system::US12>, unitArg: ()) -> bool {
            if unreachable!() {
                true
            } else {
                false
            }
        }
        pub fn get_IsUS12_1(this_: &MutCell<File_system::US12>, unitArg: ()) -> bool {
            if unreachable!() {
                true
            } else {
                false
            }
        }
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
    impl File_system::US13 {
        pub fn get_IsUS13_0(this_: &MutCell<File_system::US13>, unitArg: ()) -> bool {
            if unreachable!() {
                true
            } else {
                false
            }
        }
        pub fn get_IsUS13_1(this_: &MutCell<File_system::US13>, unitArg: ()) -> bool {
            if unreachable!() {
                true
            } else {
                false
            }
        }
    }
    impl core::fmt::Display for File_system::US13 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    pub fn method0() -> string {
        string("TRACE_LEVEL")
    }
    pub fn method2() -> string {
        string("")
    }
    pub fn method1(v0_1: string) -> string {
        let _v1: MutCell<Option<string>> = MutCell::new(None::<string>);
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
        let v44: string = File_system::method2();
        {
            let x: string = v43.unwrap_or(v44);
            _v1.set(Some(x))
        }
        match &_v1.get().clone() {
            None => panic!("{}", string("base.run_target / _v1=None"),),
            Some(_v1_0_0) => _v1_0_0.clone(),
        }
    }
    pub fn method3() -> string {
        string("AUTOMATION")
    }
    pub fn closure1(unitVar: (), v0_1: string) {
        ();
    }
    pub fn closure0(
        unitVar: (),
        v0_1: File_system::US0,
    ) -> (
        LrcPtr<File_system::Mut0>,
        LrcPtr<File_system::Mut1>,
        LrcPtr<File_system::Mut2>,
        Option<i64>,
        LrcPtr<File_system::Mut3>,
    ) {
        let _v1: MutCell<Option<(File_system::US1, File_system::US2)>> =
            MutCell::new(None::<(File_system::US1, File_system::US2)>);
        _v1.set(Some((File_system::US1::US1_1, File_system::US2::US2_1)));
        {
            let patternInput: (File_system::US1, File_system::US2) = match &_v1.get().clone() {
                None => panic!("{}", string("base.run_target / _v1=None"),),
                Some(_v1_0_0) => _v1_0_0.clone(),
            };
            let v259: File_system::US2 = patternInput.1.clone();
            let v258: File_system::US1 = patternInput.0.clone();
            let v267: LrcPtr<File_system::Mut3> = LrcPtr::new(File_system::Mut3 {
                l0: MutCell::new(Func1::new(move |v: string| File_system::closure1((), v))),
            });
            (
                LrcPtr::new(File_system::Mut0 {
                    l0: MutCell::new(0_i64),
                }),
                LrcPtr::new(File_system::Mut1 {
                    l0: MutCell::new(true),
                }),
                LrcPtr::new(File_system::Mut2 {
                    l0: MutCell::new(match &v259 {
                        File_system::US2::US2_0(v259_0_0) => match &v259 {
                            File_system::US2::US2_0(x) => x.clone(),
                            _ => unreachable!(),
                        },
                        _ => v0_1,
                    }),
                }),
                match &v258 {
                    File_system::US1::US1_0(v258_0_0) => Some(match &v258 {
                        File_system::US1::US1_0(x) => x.clone(),
                        _ => unreachable!(),
                    }),
                    _ => None::<i64>,
                },
                v267,
            )
        }
    }
    pub fn method6(v0_1: string) -> string {
        v0_1
    }
    pub fn method7(v0_1: string) -> bool {
        let _v1: MutCell<Option<bool>> = MutCell::new(None::<bool>);
        {
            let x: bool = unbox::<bool>(&defaultOf());
            _v1.set(Some(x))
        }
        match &_v1.get().clone() {
            None => panic!("{}", string("base.run_target / _v1=None"),),
            Some(_v1_0_0) => _v1_0_0.clone(),
        }
    }
    pub fn method5(v0_1: bool, v1_1: string) {
        let _v2: MutCell<Option<()>> = MutCell::new(None::<()>);
        defaultOf::<()>();
        _v2.set(Some(()));
        match &_v2.get().clone() {
            None => panic!("{}", string("base.run_target / _v2=None"),),
            Some(_v2_0_0) => _v2_0_0.clone(),
        }
        ()
    }
    pub fn closure3(unitVar: (), unitVar_1: ()) -> string {
        string("file_system.delete_directory_async")
    }
    pub fn method8(v0_1: string) -> string {
        let _v1: MutCell<Option<string>> = MutCell::new(None::<string>);
        {
            let x: string = unbox::<string>(&defaultOf());
            _v1.set(Some(x))
        }
        match &_v1.get().clone() {
            None => panic!("{}", string("base.run_target / _v1=None"),),
            Some(_v1_0_0) => _v1_0_0.clone(),
        }
    }
    pub fn closure5(unitVar: (), v0_1: string) -> string {
        File_system::method8(v0_1)
    }
    pub fn closure6(unitVar: (), unitVar_1: ()) -> string {
        string("")
    }
    pub fn closure4(v0_1: string, v1_1: string, unitVar: ()) -> string {
        sprintf!(
            "path: {} / ex: {} / {}",
            File_system::closure5((), v0_1),
            v1_1,
            File_system::closure6((), ())
        )
    }
    pub fn method10() -> string {
        string("hh:mm:ss")
    }
    pub fn method11() -> string {
        string("")
    }
    pub fn method12() -> string {
        string("HH:mm:ss")
    }
    pub fn method13() -> string {
        string("\u{001b}[0m")
    }
    pub fn closure7(
        v0_1: File_system::US0,
        v1_1: Func0<string>,
        v2_1: Func0<string>,
        unitVar: (),
    ) -> string {
        if File_system::State::trace_state().get().clone().is_none() {
            File_system::State::trace_state()
                .set(Some(File_system::closure0((), File_system::US0::US0_0)));
        }
        {
            let patternInput: (
                LrcPtr<File_system::Mut0>,
                LrcPtr<File_system::Mut1>,
                LrcPtr<File_system::Mut2>,
                Option<i64>,
                LrcPtr<File_system::Mut3>,
            ) = getValue(File_system::State::trace_state().get().clone());
            let _v10: MutCell<Option<string>> = MutCell::new(None::<string>);
            {
                let x: string = File_system::method11();
                _v10.set(Some(x))
            }
            {
                let v152: string = match &_v10.get().clone() {
                    None => panic!("{}", string("base.run_target / _v10=None"),),
                    Some(_v10_0_0) => _v10_0_0.clone(),
                };
                let v159: File_system::US3 = if if let File_system::US0::US0_0 = &v0_1 {
                    true
                } else {
                    false
                } {
                    File_system::US3::US3_0(string("Verbose"))
                } else {
                    File_system::US3::US3_1
                };
                let v208: File_system::US3 = match &v159 {
                    File_system::US3::US3_0(v159_0_0) => File_system::US3::US3_0(match &v159 {
                        File_system::US3::US3_0(x) => x.clone(),
                        _ => unreachable!(),
                    }),
                    _ => {
                        let v168: File_system::US3 = if if let File_system::US0::US0_1 = &v0_1 {
                            true
                        } else {
                            false
                        } {
                            File_system::US3::US3_0(string("Debug"))
                        } else {
                            File_system::US3::US3_1
                        };
                        match &v168 {
                            File_system::US3::US3_0(v168_0_0) => {
                                File_system::US3::US3_0(match &v168 {
                                    File_system::US3::US3_0(x) => x.clone(),
                                    _ => unreachable!(),
                                })
                            }
                            _ => {
                                let v177: File_system::US3 =
                                    if if let File_system::US0::US0_2 = &v0_1 {
                                        true
                                    } else {
                                        false
                                    } {
                                        File_system::US3::US3_0(string("Info"))
                                    } else {
                                        File_system::US3::US3_1
                                    };
                                match &v177 {
                                    File_system::US3::US3_0(v177_0_0) => {
                                        File_system::US3::US3_0(match &v177 {
                                            File_system::US3::US3_0(x) => x.clone(),
                                            _ => unreachable!(),
                                        })
                                    }
                                    _ => {
                                        let v186: File_system::US3 =
                                            if if let File_system::US0::US0_3 = &v0_1 {
                                                true
                                            } else {
                                                false
                                            } {
                                                File_system::US3::US3_0(string("Warning"))
                                            } else {
                                                File_system::US3::US3_1
                                            };
                                        match &v186 {
                                            File_system::US3::US3_0(v186_0_0) => {
                                                File_system::US3::US3_0(match &v186 {
                                                    File_system::US3::US3_0(x) => x.clone(),
                                                    _ => unreachable!(),
                                                })
                                            }
                                            _ => {
                                                let v195: File_system::US3 =
                                                    if if let File_system::US0::US0_4 = &v0_1 {
                                                        true
                                                    } else {
                                                        false
                                                    } {
                                                        File_system::US3::US3_0(string("Critical"))
                                                    } else {
                                                        File_system::US3::US3_1
                                                    };
                                                match &v195 {
                                                    File_system::US3::US3_0(v195_0_0) => {
                                                        File_system::US3::US3_0(match &v195 {
                                                            File_system::US3::US3_0(x) => x.clone(),
                                                            _ => unreachable!(),
                                                        })
                                                    }
                                                    _ => File_system::US3::US3_1,
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                };
                let v215: string = padLeft(
                    toLower(match &v208 {
                        File_system::US3::US3_0(v208_0_0) => match &v208 {
                            File_system::US3::US3_0(x) => x.clone(),
                            _ => unreachable!(),
                        },
                        _ => panic!("{}", string("Option does not have a value."),),
                    }),
                    7_i32,
                    ' ',
                );
                let _v216: MutCell<Option<string>> = MutCell::new(None::<string>);
                let v279: &str = match &v0_1 {
                    File_system::US0::US0_1 => inline_colorization::color_bright_blue,
                    File_system::US0::US0_2 => inline_colorization::color_bright_green,
                    File_system::US0::US0_0 => inline_colorization::color_bright_black,
                    File_system::US0::US0_3 => inline_colorization::color_yellow,
                    _ => inline_colorization::color_bright_red,
                };
                let v281: &str = &*v215;
                let v283: &str = inline_colorization::color_reset;
                let v285: string = string("format!(\"{v279}{v281}{v283}\")");
                let v286: std::string::String = format!("{v279}{v281}{v283}");
                {
                    let x_2: string = fable_library_rust::String_::fromString(v286);
                    _v216.set(Some(x_2))
                }
                trimEndChars(
                    trimStartChars(
                        sprintf!(
                            "{} {} #{} {} / {}",
                            v152,
                            match &_v216.get().clone() {
                                None => panic!("{}", string("base.run_target / _v216=None"),),
                                Some(_v216_0_0) => _v216_0_0.clone(),
                            },
                            (patternInput.0.clone()).l0.get().clone(),
                            v1_1(),
                            v2_1()
                        ),
                        toArray(empty::<char>()),
                    ),
                    toArray(ofArray(new_array(&[' ', '/']))),
                )
            }
        }
    }
    pub fn method14(v0_1: File_system::US0, v1_1: Func0<string>) {
        fn v2_1(
            v: File_system::US0,
        ) -> (
            LrcPtr<File_system::Mut0>,
            LrcPtr<File_system::Mut1>,
            LrcPtr<File_system::Mut2>,
            Option<i64>,
            LrcPtr<File_system::Mut3>,
        ) {
            File_system::closure0((), v)
        }
        if File_system::State::trace_state().get().clone().is_none() {
            File_system::State::trace_state().set(Some(v2_1(File_system::US0::US0_0)));
        }
        {
            let patternInput: (
                LrcPtr<File_system::Mut0>,
                LrcPtr<File_system::Mut1>,
                LrcPtr<File_system::Mut2>,
                Option<i64>,
                LrcPtr<File_system::Mut3>,
            ) = getValue(File_system::State::trace_state().get().clone());
            let v4_1: LrcPtr<File_system::Mut0> = patternInput.0.clone();
            if File_system::State::trace_state().get().clone().is_none() {
                File_system::State::trace_state().set(Some(v2_1(File_system::US0::US0_0)));
            }
            {
                let patternInput_1: (
                    LrcPtr<File_system::Mut0>,
                    LrcPtr<File_system::Mut1>,
                    LrcPtr<File_system::Mut2>,
                    Option<i64>,
                    LrcPtr<File_system::Mut3>,
                ) = getValue(File_system::State::trace_state().get().clone());
                let v15_1: File_system::US0 = (patternInput_1.2.clone()).l0.get().clone();
                if if (patternInput_1.1.clone()).l0.get().clone() == false {
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
                        v15_1,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((File_system::US0::US0_0, 0_i32)),
                            LrcPtr::new((File_system::US0::US0_1, 1_i32)),
                            LrcPtr::new((File_system::US0::US0_2, 2_i32)),
                            LrcPtr::new((File_system::US0::US0_3, 3_i32)),
                            LrcPtr::new((File_system::US0::US0_4, 4_i32)),
                        ])))),
                    )
                } {
                    let v23: i64 = v4_1.l0.get().clone() + 1_i64;
                    v4_1.l0.set(v23);
                    {
                        let v24: string = sprintf!("{}", v1_1());
                        let _v25: MutCell<Option<()>> = MutCell::new(None::<()>);
                        println!("{}", v24.clone());
                        _v25.set(Some(()));
                        match &_v25.get().clone() {
                            None => panic!("{}", string("base.run_target / _v25=None"),),
                            Some(_v25_0_0) => _v25_0_0.clone(),
                        }
                        ((patternInput.4.clone()).l0.get().clone())(v24)
                    }
                }
            }
        }
    }
    pub fn method9(v0_1: File_system::US0, v1_1: Func0<string>, v2_1: Func0<string>) {
        File_system::method14(
            v0_1.clone(),
            Func0::new({
                let v0_1 = v0_1.clone();
                let v1_1 = v1_1.clone();
                let v2_1 = v2_1.clone();
                move || File_system::closure7(v0_1.clone(), v1_1.clone(), v2_1.clone(), ())
            }),
        );
    }
    pub fn method4(v0_1: string, v1_1: i64) -> Arc<Async<i64>> {
        let _v2: MutCell<Option<Arc<Async<i64>>>> = MutCell::new(None::<Arc<Async<i64>>>);
        {
            let x: Arc<Async<i64>> = defaultOf();
            _v2.set(Some(x))
        }
        match &_v2.get().clone() {
            None => panic!("{}", string("base.run_target / _v2=None"),),
            Some(_v2_0_0) => _v2_0_0.clone(),
        }
    }
    pub fn closure2(unitVar: (), v0_1: string) -> Arc<Async<i64>> {
        let _v1: MutCell<Option<Arc<Async<i64>>>> = MutCell::new(None::<Arc<Async<i64>>>);
        {
            let x: Arc<Async<i64>> = defaultOf();
            _v1.set(Some(x))
        }
        match &_v1.get().clone() {
            None => panic!("{}", string("base.run_target / _v1=None"),),
            Some(_v1_0_0) => _v1_0_0.clone(),
        }
    }
    pub fn closure10(unitVar: (), unitVar_1: ()) -> string {
        string("file_system.wait_for_file_access")
    }
    pub fn closure11(v0_1: string, v1_1: i64, v2_1: string, unitVar: ()) -> string {
        sprintf!(
            "path: {} / retry: {} / ex: {} / {}",
            File_system::closure5((), v0_1),
            v1_1,
            v2_1,
            File_system::closure6((), ())
        )
    }
    pub fn method15(
        v0_1: string,
        v1_1: File_system::US8,
        v2_1: File_system::US7,
        v3_1: i64,
    ) -> Arc<Async<i64>> {
        let _v4: MutCell<Option<Arc<Async<i64>>>> = MutCell::new(None::<Arc<Async<i64>>>);
        {
            let x: Arc<Async<i64>> = defaultOf();
            _v4.set(Some(x))
        }
        match &_v4.get().clone() {
            None => panic!("{}", string("base.run_target / _v4=None"),),
            Some(_v4_0_0) => _v4_0_0.clone(),
        }
    }
    pub fn closure9(v0_1: File_system::US6, v1_1: string) -> Arc<Async<i64>> {
        let _v2: MutCell<Option<Arc<Async<i64>>>> = MutCell::new(None::<Arc<Async<i64>>>);
        {
            let x: Arc<Async<i64>> = defaultOf();
            _v2.set(Some(x))
        }
        match &_v2.get().clone() {
            None => panic!("{}", string("base.run_target / _v2=None"),),
            Some(_v2_0_0) => _v2_0_0.clone(),
        }
    }
    pub fn closure8(unitVar: (), v0_1: File_system::US6) -> Func1<string, Arc<Async<i64>>> {
        Func1::new({
            let v0_1 = v0_1.clone();
            move |v: string| File_system::closure9(v0_1.clone(), v)
        })
    }
    pub fn method16(v0_1: string, v1_1: i64) -> Arc<Async<i64>> {
        let _v2: MutCell<Option<Arc<Async<i64>>>> = MutCell::new(None::<Arc<Async<i64>>>);
        {
            let x: Arc<Async<i64>> = defaultOf();
            _v2.set(Some(x))
        }
        match &_v2.get().clone() {
            None => panic!("{}", string("base.run_target / _v2=None"),),
            Some(_v2_0_0) => _v2_0_0.clone(),
        }
    }
    pub fn closure12(unitVar: (), v0_1: string) -> Arc<Async<i64>> {
        let _v1: MutCell<Option<Arc<Async<i64>>>> = MutCell::new(None::<Arc<Async<i64>>>);
        {
            let x: Arc<Async<i64>> = defaultOf();
            _v1.set(Some(x))
        }
        match &_v1.get().clone() {
            None => panic!("{}", string("base.run_target / _v1=None"),),
            Some(_v1_0_0) => _v1_0_0.clone(),
        }
    }
    pub fn closure13(unitVar: (), v0_1: string) -> Arc<Async<string>> {
        let _v1: MutCell<Option<Arc<Async<string>>>> = MutCell::new(None::<Arc<Async<string>>>);
        {
            let x: Arc<Async<string>> = defaultOf();
            _v1.set(Some(x))
        }
        match &_v1.get().clone() {
            None => panic!("{}", string("base.run_target / _v1=None"),),
            Some(_v1_0_0) => _v1_0_0.clone(),
        }
    }
    pub fn method18(v0_1: string) -> bool {
        let _v1: MutCell<Option<bool>> = MutCell::new(None::<bool>);
        {
            let x: bool = unbox::<bool>(&defaultOf());
            _v1.set(Some(x))
        }
        match &_v1.get().clone() {
            None => panic!("{}", string("base.run_target / _v1=None"),),
            Some(_v1_0_0) => _v1_0_0.clone(),
        }
    }
    pub fn method19(v0_1: Vec<u8>) -> Vec<u8> {
        v0_1
    }
    pub fn method17(v0_1: string, v1_1: string) -> bool {
        let _v2: MutCell<Option<bool>> = MutCell::new(None::<bool>);
        {
            let x: bool = unbox::<bool>(&defaultOf());
            _v2.set(Some(x))
        }
        match &_v2.get().clone() {
            None => panic!("{}", string("base.run_target / _v2=None"),),
            Some(_v2_0_0) => _v2_0_0.clone(),
        }
    }
    pub fn closure15(v0_1: string, v1_1: string) -> bool {
        File_system::method17(v0_1, v1_1)
    }
    pub fn closure14(unitVar: (), v0_1: string) -> Func1<string, bool> {
        Func1::new({
            let v0_1 = v0_1.clone();
            move |v: string| File_system::closure15(v0_1.clone(), v)
        })
    }
    pub fn closure17(v0_1: string, v1_1: string) -> Arc<Async<()>> {
        let _v2: MutCell<Option<Arc<Async<()>>>> = MutCell::new(None::<Arc<Async<()>>>);
        {
            let x: Arc<Async<()>> = defaultOf();
            _v2.set(Some(x))
        }
        match &_v2.get().clone() {
            None => panic!("{}", string("base.run_target / _v2=None"),),
            Some(_v2_0_0) => _v2_0_0.clone(),
        }
    }
    pub fn closure16(unitVar: (), v0_1: string) -> Func1<string, Arc<Async<()>>> {
        Func1::new({
            let v0_1 = v0_1.clone();
            move |v: string| File_system::closure17(v0_1.clone(), v)
        })
    }
    pub fn closure19(v0_1: string, v1_1: string) -> Arc<Async<()>> {
        let _v2: MutCell<Option<Arc<Async<()>>>> = MutCell::new(None::<Arc<Async<()>>>);
        {
            let x: Arc<Async<()>> = defaultOf();
            _v2.set(Some(x))
        }
        match &_v2.get().clone() {
            None => panic!("{}", string("base.run_target / _v2=None"),),
            Some(_v2_0_0) => _v2_0_0.clone(),
        }
    }
    pub fn closure18(unitVar: (), v0_1: string) -> Func1<string, Arc<Async<()>>> {
        Func1::new({
            let v0_1 = v0_1.clone();
            move |v: string| File_system::closure19(v0_1.clone(), v)
        })
    }
    pub fn closure21(unitVar: (), unitVar_1: ()) -> string {
        string("delete_file_async")
    }
    pub fn closure22(v0_1: string, v1_1: LrcPtr<Exception>, unitVar: ()) -> string {
        let _v2: MutCell<Option<string>> = MutCell::new(None::<string>);
        {
            let x: string = sprintf!("{:?}", v1_1);
            _v2.set(Some(x))
        }
        {
            let v9_1: string = match &_v2.get().clone() {
                None => panic!("{}", string("base.run_target / _v2=None"),),
                Some(_v2_0_0) => _v2_0_0.clone(),
            };
            sprintf!(
                "path: {} / ex: {} / {}",
                File_system::closure5((), v0_1),
                v9_1,
                File_system::closure6((), ())
            )
        }
    }
    pub fn method20(v0_1: string, v1_1: i64) -> Arc<Async<i64>> {
        let _v2: MutCell<Option<Arc<Async<i64>>>> = MutCell::new(None::<Arc<Async<i64>>>);
        {
            let x: Arc<Async<i64>> = defaultOf();
            _v2.set(Some(x))
        }
        match &_v2.get().clone() {
            None => panic!("{}", string("base.run_target / _v2=None"),),
            Some(_v2_0_0) => _v2_0_0.clone(),
        }
    }
    pub fn closure20(unitVar: (), v0_1: string) -> Arc<Async<i64>> {
        let _v1: MutCell<Option<Arc<Async<i64>>>> = MutCell::new(None::<Arc<Async<i64>>>);
        {
            let x: Arc<Async<i64>> = defaultOf();
            _v1.set(Some(x))
        }
        match &_v1.get().clone() {
            None => panic!("{}", string("base.run_target / _v1=None"),),
            Some(_v1_0_0) => _v1_0_0.clone(),
        }
    }
    pub fn closure25(unitVar: (), unitVar_1: ()) -> string {
        string("move_file_async")
    }
    pub fn closure26(v0_1: string, v1_1: string, v2_1: LrcPtr<Exception>, unitVar: ()) -> string {
        let _v3: MutCell<Option<string>> = MutCell::new(None::<string>);
        {
            let x: string = sprintf!("{:?}", v2_1);
            _v3.set(Some(x))
        }
        {
            let v10_1: string = match &_v3.get().clone() {
                None => panic!("{}", string("base.run_target / _v3=None"),),
                Some(_v3_0_0) => _v3_0_0.clone(),
            };
            fn v11_1(v: string) -> string {
                File_system::closure5((), v)
            }
            sprintf!(
                "old_path: {} / new_path: {} / ex: {} / {}",
                v11_1(v1_1),
                v11_1(v0_1),
                v10_1,
                File_system::closure6((), ())
            )
        }
    }
    pub fn method21(v0_1: string, v1_1: string, v2_1: i64) -> Arc<Async<i64>> {
        let _v3: MutCell<Option<Arc<Async<i64>>>> = MutCell::new(None::<Arc<Async<i64>>>);
        {
            let x: Arc<Async<i64>> = defaultOf();
            _v3.set(Some(x))
        }
        match &_v3.get().clone() {
            None => panic!("{}", string("base.run_target / _v3=None"),),
            Some(_v3_0_0) => _v3_0_0.clone(),
        }
    }
    pub fn closure24(v0_1: string, v1_1: string) -> Arc<Async<i64>> {
        let _v2: MutCell<Option<Arc<Async<i64>>>> = MutCell::new(None::<Arc<Async<i64>>>);
        {
            let x: Arc<Async<i64>> = defaultOf();
            _v2.set(Some(x))
        }
        match &_v2.get().clone() {
            None => panic!("{}", string("base.run_target / _v2=None"),),
            Some(_v2_0_0) => _v2_0_0.clone(),
        }
    }
    pub fn closure23(unitVar: (), v0_1: string) -> Func1<string, Arc<Async<i64>>> {
        Func1::new({
            let v0_1 = v0_1.clone();
            move |v: string| File_system::closure24(v0_1.clone(), v)
        })
    }
    pub fn closure28(unitVar: (), v0_1: i64) -> File_system::US9 {
        File_system::US9::US9_0(v0_1)
    }
    pub fn closure29(unitVar: (), v0_1: LrcPtr<Exception>) -> File_system::US9 {
        File_system::US9::US9_1(v0_1)
    }
    pub fn closure30(unitVar: (), unitVar_1: ()) -> string {
        string("async.run_with_timeout_async")
    }
    pub fn closure31(unitVar: (), unitVar_1: ()) -> string {
        sprintf!("timeout: {} / {}", 1000_i32, File_system::closure6((), ()))
    }
    pub fn closure32(v0_1: string, unitVar: ()) -> string {
        sprintf!("async.run_with_timeout_async** / ex: {}", v0_1)
    }
    pub fn closure33(unitVar: (), unitVar_1: ()) -> string {
        string("read_all_text_retry_async")
    }
    pub fn method23(v0_1: i64, v1_1: string) -> string {
        sprintf!(
            "retry: {} / ex: {} / {}",
            v0_1,
            v1_1,
            File_system::closure6((), ())
        )
    }
    pub fn closure34(v0_1: i64, v1_1: string, unitVar: ()) -> string {
        File_system::method23(v0_1, v1_1)
    }
    pub fn method22(v0_1: string, v1_1: i64) -> Arc<Async<Option<string>>> {
        let _v2: MutCell<Option<Arc<Async<Option<string>>>>> =
            MutCell::new(None::<Arc<Async<Option<string>>>>);
        {
            let x: Arc<Async<Option<string>>> = defaultOf();
            _v2.set(Some(x))
        }
        match &_v2.get().clone() {
            None => panic!("{}", string("base.run_target / _v2=None"),),
            Some(_v2_0_0) => _v2_0_0.clone(),
        }
    }
    pub fn closure27(unitVar: (), v0_1: string) -> Arc<Async<Option<string>>> {
        let _v1: MutCell<Option<Arc<Async<Option<string>>>>> =
            MutCell::new(None::<Arc<Async<Option<string>>>>);
        {
            let x: Arc<Async<Option<string>>> = defaultOf();
            _v1.set(Some(x))
        }
        match &_v1.get().clone() {
            None => panic!("{}", string("base.run_target / _v1=None"),),
            Some(_v1_0_0) => _v1_0_0.clone(),
        }
    }
    pub fn method26(v0_1: Option<()>) -> Option<()> {
        v0_1
    }
    pub fn method27(v0_1: Option<()>) -> Option<()> {
        v0_1
    }
    pub fn method28() -> string {
        string("hh:mm")
    }
    pub fn method29() -> string {
        string("yyyyMMdd-HHmm-ssff-ffff-f")
    }
    pub fn method30() -> string {
        string("hhmm")
    }
    pub fn method25(v0_1: Guid, v1_1: DateTime) -> Guid {
        let _v2: MutCell<Option<Guid>> = MutCell::new(None::<Guid>);
        {
            let x: Guid = unbox::<Guid>(&defaultOf());
            _v2.set(Some(x))
        }
        match &_v2.get().clone() {
            None => panic!("{}", string("base.run_target / _v2=None"),),
            Some(_v2_0_0) => _v2_0_0.clone(),
        }
    }
    pub fn method32() -> string {
        let _v0: MutCell<Option<string>> = MutCell::new(None::<string>);
        {
            let x: string = unbox::<string>(&defaultOf());
            _v0.set(Some(x))
        }
        match &_v0.get().clone() {
            None => panic!("{}", string("base.run_target / _v0=None"),),
            Some(_v0_0_0) => _v0_0_0.clone(),
        }
    }
    pub fn method33() -> string {
        string("!create_temp_path_")
    }
    pub fn method36(v0_1: string) -> string {
        v0_1
    }
    pub fn method35(v0_1: string, v1_1: string) -> (string, string) {
        (v1_1, File_system::method36(v0_1))
    }
    pub fn method34(v0_1: string, v1_1: string) -> string {
        let _v2: MutCell<Option<string>> = MutCell::new(None::<string>);
        {
            let x: string = unbox::<string>(&defaultOf());
            _v2.set(Some(x))
        }
        match &_v2.get().clone() {
            None => panic!("{}", string("base.run_target / _v2=None"),),
            Some(_v2_0_0) => _v2_0_0.clone(),
        }
    }
    pub fn method38() -> string {
        string("CARGO_PKG_NAME")
    }
    pub fn method37() -> string {
        let _v0: MutCell<Option<string>> = MutCell::new(None::<string>);
        {
            let x: string = File_system::method1(File_system::method38());
            _v0.set(Some(x))
        }
        match &_v0.get().clone() {
            None => panic!("{}", string("base.run_target / _v0=None"),),
            Some(_v0_0_0) => _v0_0_0.clone(),
        }
    }
    pub fn method31(v0_1: Guid) -> string {
        let _v1: MutCell<Option<string>> = MutCell::new(None::<string>);
        {
            let x: string = unbox::<string>(&defaultOf());
            _v1.set(Some(x))
        }
        match &_v1.get().clone() {
            None => panic!("{}", string("base.run_target / _v1=None"),),
            Some(_v1_0_0) => _v1_0_0.clone(),
        }
    }
    pub fn method24() -> string {
        let _v0: MutCell<Option<string>> = MutCell::new(None::<string>);
        {
            let x: string = unbox::<string>(&defaultOf());
            _v0.set(Some(x))
        }
        match &_v0.get().clone() {
            None => panic!("{}", string("base.run_target / _v0=None"),),
            Some(_v0_0_0) => _v0_0_0.clone(),
        }
    }
    pub fn closure35(unitVar: (), unitVar_1: ()) -> string {
        File_system::method24()
    }
    pub fn method40(v0_1: string) -> string {
        v0_1
    }
    pub fn closure37(unitVar: (), v0_1: std::io::Error) -> std::string::String {
        let _v1: MutCell<Option<std::string::String>> = MutCell::new(None::<std::string::String>);
        {
            let x: std::string::String = format!("{}", v0_1);
            _v1.set(Some(x))
        }
        match &_v1.get().clone() {
            None => panic!("{}", string("base.run_target / _v1=None"),),
            Some(_v1_0_0) => _v1_0_0.clone(),
        }
    }
    pub fn method41() -> Func1<std::io::Error, std::string::String> {
        Func1::new(move |v: std::io::Error| File_system::closure37((), v))
    }
    pub fn closure38(unitVar: (), unitVar_1: ()) -> File_system::US12 {
        File_system::US12::US12_0
    }
    pub fn closure39(unitVar: (), v0_1: std::string::String) -> File_system::US12 {
        File_system::US12::US12_1(v0_1)
    }
    pub fn closure40(unitVar: (), unitVar_1: ()) -> string {
        string("file_system.create_dir")
    }
    pub fn closure41(v0_1: string, v1_1: std::string::String, unitVar: ()) -> string {
        sprintf!(
            "dir: {} / error: {} / {}",
            v0_1,
            v1_1,
            File_system::closure6((), ())
        )
    }
    pub fn closure42(unitVar: (), unitVar_1: ()) -> string {
        string("file_system.create_dir")
    }
    pub fn closure43(v0_1: string, unitVar: ()) -> string {
        sprintf!("dir: {} / {}", v0_1, File_system::closure6((), ()))
    }
    pub fn closure44(v0_1: string, unitVar: ()) {
        File_system::method5(true, v0_1);
    }
    pub fn method42(v0_1: string) -> Func0<()> {
        Func0::new({
            let v0_1 = v0_1.clone();
            move || File_system::closure44(v0_1.clone(), ())
        })
    }
    pub fn method43(v0_1: string) -> Func0<()> {
        Func0::new({
            let v0_1 = v0_1.clone();
            move || File_system::closure44(v0_1.clone(), ())
        })
    }
    pub fn closure45(unitVar: (), unitVar_1: ()) -> string {
        string("file_system.create_dir")
    }
    pub fn closure46(v0_1: string, v1_1: string, unitVar: ()) -> string {
        sprintf!(
            "dir: {} / result: {} {}",
            v0_1,
            v1_1,
            File_system::closure6((), ())
        )
    }
    pub fn closure47(v0_1: string, unitVar: ()) {
        let _v1: MutCell<Option<Arc<Async<i64>>>> = MutCell::new(None::<Arc<Async<i64>>>);
        {
            let x: Arc<Async<i64>> = defaultOf();
            _v1.set(Some(x))
        }
        {
            let v9_1: Arc<Async<i64>> = match &_v1.get().clone() {
                None => panic!("{}", string("base.run_target / _v1=None"),),
                Some(_v1_0_0) => _v1_0_0.clone(),
            };
            let _v10: MutCell<Option<Arc<Async<()>>>> = MutCell::new(None::<Arc<Async<()>>>);
            {
                let x_2: Arc<Async<()>> = defaultOf();
                _v10.set(Some(x_2))
            }
            {
                let v18_1: Arc<Async<()>> = match &_v10.get().clone() {
                    None => panic!("{}", string("base.run_target / _v10=None"),),
                    Some(_v10_0_0) => _v10_0_0.clone(),
                };
                let _v19: MutCell<Option<()>> = MutCell::new(None::<()>);
                defaultOf::<()>();
                _v19.set(Some(()));
                match &_v19.get().clone() {
                    None => panic!("{}", string("base.run_target / _v19=None"),),
                    Some(_v19_0_0) => _v19_0_0.clone(),
                }
                ()
            }
        }
    }
    pub fn method44(v0_1: string) -> Func0<()> {
        Func0::new({
            let v0_1 = v0_1.clone();
            move || File_system::closure47(v0_1.clone(), ())
        })
    }
    pub fn method45(v0_1: string) -> Func0<()> {
        Func0::new({
            let v0_1 = v0_1.clone();
            move || File_system::closure47(v0_1.clone(), ())
        })
    }
    pub fn method39(v0_1: string) -> LrcPtr<dyn IDisposable> {
        let _v1: MutCell<Option<LrcPtr<dyn IDisposable>>> =
            MutCell::new(None::<LrcPtr<dyn IDisposable>>);
        {
            let x: LrcPtr<dyn IDisposable> = interface_cast!(
                defaultOf::<std::rc::Rc<dyn IDisposable>>(),
                Lrc<dyn IDisposable>,
            );
            _v1.set(Some(x))
        }
        match &_v1.get().clone() {
            None => panic!("{}", string("base.run_target / _v1=None"),),
            Some(_v1_0_0) => _v1_0_0.clone(),
        }
    }
    pub fn closure36(unitVar: (), unitVar_1: ()) -> (string, LrcPtr<dyn IDisposable>) {
        let v0_1: string = File_system::method24();
        (v0_1.clone(), File_system::method39(v0_1))
    }
    pub fn method46(v0_1: string) -> Guid {
        let _v1: MutCell<Option<Guid>> = MutCell::new(None::<Guid>);
        {
            let x: Guid = unbox::<Guid>(&defaultOf());
            _v1.set(Some(x))
        }
        match &_v1.get().clone() {
            None => panic!("{}", string("base.run_target / _v1=None"),),
            Some(_v1_0_0) => _v1_0_0.clone(),
        }
    }
    pub fn closure48(unitVar: (), v0_1: string) -> (string, LrcPtr<dyn IDisposable>) {
        let v2_1: string = File_system::method31(File_system::method46(v0_1));
        (v2_1.clone(), File_system::method39(v2_1))
    }
    pub fn closure49(unitVar: (), unitVar_1: ()) -> string {
        string("C:\\home\\git\\polyglot\\lib\\spiral")
    }
    pub fn method48() -> string {
        string("")
    }
    pub fn method49(v0_1: string) -> string {
        v0_1
    }
    pub fn method50() -> string {
        string("^\\\\\\\\\\?\\\\")
    }
    pub fn method47(v0_1: string) -> string {
        let v1_1: string = File_system::method48();
        let _v2: MutCell<Option<string>> = MutCell::new(None::<string>);
        {
            let x: string = unbox::<string>(&defaultOf());
            _v2.set(Some(x))
        }
        {
            let v21: string = match &_v2.get().clone() {
                None => panic!("{}", string("base.run_target / _v2=None"),),
                Some(_v2_0_0) => _v2_0_0.clone(),
            };
            replace(
                sprintf!(
                    "{}{}",
                    toLower(ofChar(getCharAt(v21.clone(), 0_i32))),
                    getSlice(v21, Some(1_i32), None::<i32>)
                ),
                string("\\"),
                string("/"),
            )
        }
    }
    pub fn closure50(unitVar: (), v0_1: string) -> string {
        File_system::method47(v0_1)
    }
    pub fn closure51(unitVar: (), v0_1: string) -> string {
        sprintf!("file:///{}", trimStartChars(v0_1, toArray(singleton('/'))))
    }
    pub fn method53(v0_1: string) -> Option<string> {
        let _v1: MutCell<Option<File_system::US3>> = MutCell::new(None::<File_system::US3>);
        {
            let x: File_system::US3 = unbox::<File_system::US3>(&defaultOf());
            _v1.set(Some(x))
        }
        {
            let v51: File_system::US3 = match &_v1.get().clone() {
                None => panic!("{}", string("base.run_target / _v1=None"),),
                Some(_v1_0_0) => _v1_0_0.clone(),
            };
            match &v51 {
                File_system::US3::US3_0(v51_0_0) => Some(match &v51 {
                    File_system::US3::US3_0(x) => x.clone(),
                    _ => unreachable!(),
                }),
                _ => None::<string>,
            }
        }
    }
    pub fn closure53(unitVar: (), v0_1: string) -> Option<string> {
        File_system::method53(v0_1)
    }
    pub fn method52() -> Func1<string, Option<string>> {
        Func1::new(move |v: string| File_system::closure53((), v))
    }
    pub fn method54(v0_1: string, v1_1: string, v2_1: string) -> File_system::US13 {
        let v0_1: MutCell<string> = MutCell::new(v0_1.clone());
        let v1_1: MutCell<string> = MutCell::new(v1_1.clone());
        let v2_1: MutCell<string> = MutCell::new(v2_1.clone());
        '_method54: loop {
            break '_method54 (if File_system::method7(File_system::method34(
                v2_1.get().clone(),
                v0_1.get().clone(),
            )) {
                File_system::US13::US13_0(v2_1.get().clone())
            } else {
                let v7_1: Option<string> = (File_system::method52())(v2_1.get().clone());
                let _v8: LrcPtr<MutCell<Option<File_system::US3>>> =
                    refCell(None::<File_system::US3>);
                {
                    let x_2: Option<File_system::US3> = match &v7_1 {
                        None => None::<File_system::US3>,
                        Some(v7_1_0_0) => {
                            let x: string = v7_1_0_0.clone();
                            Some((Func0::new({
                                let x = x.clone();
                                move || File_system::US3::US3_0(x.clone())
                            }))())
                        }
                    };
                    _v8.set(x_2)
                }
                {
                    let v13_1: File_system::US3 =
                        defaultValue(File_system::US3::US3_1, _v8.get().clone());
                    match &v13_1 {
                        File_system::US3::US3_0(v13_1_0_0) => {
                            let v0_1_temp: string = v0_1.get().clone();
                            let v1_1_temp: string = v1_1.get().clone();
                            let v2_1_temp: string = match &v13_1 {
                                File_system::US3::US3_0(x) => x.clone(),
                                _ => unreachable!(),
                            };
                            v0_1.set(v0_1_temp);
                            v1_1.set(v1_1_temp);
                            v2_1.set(v2_1_temp);
                            continue '_method54;
                        }
                        _ => File_system::US13::US13_1(sprintf!(
                            "No parent for {} \'{}\' at \'{}\' (until \'{}\')",
                            string("dir"),
                            v0_1.get().clone(),
                            v1_1.get().clone(),
                            v2_1.get().clone()
                        )),
                    }
                }
            });
        }
    }
    pub fn method51(v0_1: string, v1_1: string) -> File_system::US13 {
        if File_system::method7(File_system::method34(v1_1.clone(), v0_1.clone())) {
            File_system::US13::US13_0(v1_1.clone())
        } else {
            let v6_1: Option<string> = (File_system::method52())(v1_1.clone());
            let _v7: LrcPtr<MutCell<Option<File_system::US3>>> = refCell(None::<File_system::US3>);
            {
                let x_2: Option<File_system::US3> = match &v6_1 {
                    None => None::<File_system::US3>,
                    Some(v6_1_0_0) => {
                        let x: string = v6_1_0_0.clone();
                        Some((Func0::new({
                            let x = x.clone();
                            move || File_system::US3::US3_0(x.clone())
                        }))())
                    }
                };
                _v7.set(x_2)
            }
            {
                let v12_1: File_system::US3 =
                    defaultValue(File_system::US3::US3_1, _v7.get().clone());
                match &v12_1 {
                    File_system::US3::US3_0(v12_1_0_0) => File_system::method54(
                        v0_1.clone(),
                        v1_1.clone(),
                        match &v12_1 {
                            File_system::US3::US3_0(x) => x.clone(),
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
    }
    pub fn closure54(unitVar: (), unitVar_1: ()) -> string {
        string("file_system.get_workspace_root")
    }
    pub fn closure55(v0_1: string, unitVar: ()) -> string {
        sprintf!("error: {} / {}", v0_1, File_system::closure6((), ()))
    }
    pub fn method55() -> string {
        let _v0: MutCell<Option<string>> = MutCell::new(None::<string>);
        {
            let x: string = unbox::<string>(&defaultOf());
            _v0.set(Some(x))
        }
        match &_v0.get().clone() {
            None => panic!("{}", string("base.run_target / _v0=None"),),
            Some(_v0_0_0) => _v0_0_0.clone(),
        }
    }
    pub fn closure52(unitVar: (), unitVar_1: ()) -> string {
        let v4_1: File_system::US13 = File_system::method51(
            File_system::method34(string("polyglot"), string(".paket")),
            string("C:\\home\\git\\polyglot\\lib\\spiral"),
        );
        let v13_1: File_system::US3 = match &v4_1 {
            File_system::US13::US13_0(v4_1_0_0) => File_system::US3::US3_0(v4_1_0_0.clone()),
            File_system::US13::US13_1(v4_1_1_0) => {
                File_system::method9(
                    File_system::US0::US0_3,
                    Func0::new(move || File_system::closure54((), ())),
                    Func0::new({
                        let v4_1 = v4_1.clone();
                        move || {
                            File_system::closure55(
                                match &v4_1 {
                                    File_system::US13::US13_1(x) => x.clone(),
                                    _ => unreachable!(),
                                },
                                (),
                            )
                        }
                    }),
                );
                File_system::US3::US3_1
            }
        };
        let v29: File_system::US3 = match &v13_1 {
            File_system::US3::US3_0(v13_1_0_0) => File_system::US3::US3_0(match &v13_1 {
                File_system::US3::US3_0(x) => x.clone(),
                _ => unreachable!(),
            }),
            _ => {
                let v16_1: string = File_system::method55();
                let v18_1: File_system::US13 = File_system::method51(
                    File_system::method34(string("polyglot"), string(".paket")),
                    v16_1,
                );
                match &v18_1 {
                    File_system::US13::US13_0(v18_1_0_0) => {
                        File_system::US3::US3_0(v18_1_0_0.clone())
                    }
                    File_system::US13::US13_1(v18_1_1_0) => {
                        File_system::method9(
                            File_system::US0::US0_3,
                            Func0::new(move || File_system::closure54((), ())),
                            Func0::new({
                                let v18_1 = v18_1.clone();
                                move || {
                                    File_system::closure55(
                                        match &v18_1 {
                                            File_system::US13::US13_1(x) => x.clone(),
                                            _ => unreachable!(),
                                        },
                                        (),
                                    )
                                }
                            }),
                        );
                        File_system::US3::US3_1
                    }
                }
            }
        };
        File_system::method34(
            match &v29 {
                File_system::US3::US3_0(v29_0_0) => match &v29 {
                    File_system::US3::US3_0(x) => x.clone(),
                    _ => unreachable!(),
                },
                _ => panic!("{}", string("Option does not have a value."),),
            },
            string("polyglot"),
        )
    }
    pub fn method56(v0_1: string) {
        let _v1: MutCell<Option<()>> = MutCell::new(None::<()>);
        _v1.set(Some(()));
        match &_v1.get().clone() {
            None => panic!("{}", string("base.run_target / _v1=None"),),
            Some(_v1_0_0) => _v1_0_0.clone(),
        }
        ()
    }
    pub fn closure57(unitVar: (), v0_1: string) {
        File_system::method56(v0_1);
    }
    pub fn closure56(unitVar: (), v0_1: bool) {
        if File_system::State::trace_state().get().clone().is_none() {
            File_system::State::trace_state()
                .set(Some(File_system::closure0((), File_system::US0::US0_0)));
        }
        {
            let patternInput: (
                LrcPtr<File_system::Mut0>,
                LrcPtr<File_system::Mut1>,
                LrcPtr<File_system::Mut2>,
                Option<i64>,
                LrcPtr<File_system::Mut3>,
            ) = getValue(File_system::State::trace_state().get().clone());
            let v10_1 = if v0_1 {
                Func1::new(move |v_1: string| File_system::closure57((), v_1))
            } else {
                Func1::new(move |v_2: string| File_system::closure1((), v_2))
            };
            (patternInput.4.clone()).l0.set(v10_1);
            ()
        }
    }
    pub fn closure59(v0_1: string, v1_1: string) -> string {
        File_system::method34(v0_1, v1_1)
    }
    pub fn closure58(unitVar: (), v0_1: string) -> Func1<string, string> {
        Func1::new({
            let v0_1 = v0_1.clone();
            move |v: string| File_system::closure59(v0_1.clone(), v)
        })
    }
    pub fn v0() -> Func1<
        File_system::US0,
        (
            LrcPtr<File_system::Mut0>,
            LrcPtr<File_system::Mut1>,
            LrcPtr<File_system::Mut2>,
            Option<i64>,
            LrcPtr<File_system::Mut3>,
        ),
    > {
        static v0: OnceInit<
            Func1<
                File_system::US0,
                (
                    LrcPtr<File_system::Mut0>,
                    LrcPtr<File_system::Mut1>,
                    LrcPtr<File_system::Mut2>,
                    Option<i64>,
                    LrcPtr<File_system::Mut3>,
                ),
            >,
        > = OnceInit::new();
        v0.get_or_init(|| Func1::new(move |v: File_system::US0| File_system::closure0((), v)))
            .clone()
    }
    pub fn v1() -> File_system::US0 {
        static v1: OnceInit<File_system::US0> = OnceInit::new();
        v1.get_or_init(|| File_system::US0::US0_0).clone()
    }
    on_startup!(
        if File_system::State::trace_state().get().clone().is_none() {
            File_system::State::trace_state().set(Some((File_system::v0())(File_system::v1())));
        }
    );
    pub fn v2() -> Func1<string, Arc<Async<i64>>> {
        static v2: OnceInit<Func1<string, Arc<Async<i64>>>> = OnceInit::new();
        v2.get_or_init(|| Func1::new(move |v: string| File_system::closure2((), v)))
            .clone()
    }
    pub fn delete_directory_async(x: string) -> Arc<Async<i64>> {
        (File_system::v2())(x)
    }
    pub fn v3() -> Func1<File_system::US6, Func1<string, Arc<Async<i64>>>> {
        static v3: OnceInit<Func1<File_system::US6, Func1<string, Arc<Async<i64>>>>> =
            OnceInit::new();
        v3.get_or_init(|| Func1::new(move |v: File_system::US6| File_system::closure8((), v)))
            .clone()
    }
    pub fn wait_for_file_access(x: File_system::US6) -> Func1<string, Arc<Async<i64>>> {
        (File_system::v3())(x)
    }
    pub fn v4() -> Func1<string, Arc<Async<i64>>> {
        static v4: OnceInit<Func1<string, Arc<Async<i64>>>> = OnceInit::new();
        v4.get_or_init(|| Func1::new(move |v: string| File_system::closure12((), v)))
            .clone()
    }
    pub fn wait_for_file_access_read(x: string) -> Arc<Async<i64>> {
        (File_system::v4())(x)
    }
    pub fn v5() -> Func1<string, Arc<Async<string>>> {
        static v5: OnceInit<Func1<string, Arc<Async<string>>>> = OnceInit::new();
        v5.get_or_init(|| Func1::new(move |v: string| File_system::closure13((), v)))
            .clone()
    }
    pub fn read_all_text_async(x: string) -> Arc<Async<string>> {
        (File_system::v5())(x)
    }
    pub fn v6() -> Func1<string, Func1<string, bool>> {
        static v6: OnceInit<Func1<string, Func1<string, bool>>> = OnceInit::new();
        v6.get_or_init(|| Func1::new(move |v: string| File_system::closure14((), v)))
            .clone()
    }
    pub fn file_exists_content(x: string) -> Func1<string, bool> {
        (File_system::v6())(x)
    }
    pub fn v7() -> Func1<string, Func1<string, Arc<Async<()>>>> {
        static v7: OnceInit<Func1<string, Func1<string, Arc<Async<()>>>>> = OnceInit::new();
        v7.get_or_init(|| Func1::new(move |v: string| File_system::closure16((), v)))
            .clone()
    }
    pub fn write_all_text_async(x: string) -> Func1<string, Arc<Async<()>>> {
        (File_system::v7())(x)
    }
    pub fn v8() -> Func1<string, Func1<string, Arc<Async<()>>>> {
        static v8: OnceInit<Func1<string, Func1<string, Arc<Async<()>>>>> = OnceInit::new();
        v8.get_or_init(|| Func1::new(move |v: string| File_system::closure18((), v)))
            .clone()
    }
    pub fn write_all_text_exists(x: string) -> Func1<string, Arc<Async<()>>> {
        (File_system::v8())(x)
    }
    pub fn v9() -> Func1<string, Arc<Async<i64>>> {
        static v9: OnceInit<Func1<string, Arc<Async<i64>>>> = OnceInit::new();
        v9.get_or_init(|| Func1::new(move |v: string| File_system::closure20((), v)))
            .clone()
    }
    pub fn delete_file_async(x: string) -> Arc<Async<i64>> {
        (File_system::v9())(x)
    }
    pub fn v10() -> Func1<string, Func1<string, Arc<Async<i64>>>> {
        static v10: OnceInit<Func1<string, Func1<string, Arc<Async<i64>>>>> = OnceInit::new();
        v10.get_or_init(|| Func1::new(move |v: string| File_system::closure23((), v)))
            .clone()
    }
    pub fn move_file_async(x: string) -> Func1<string, Arc<Async<i64>>> {
        (File_system::v10())(x)
    }
    pub fn v11() -> Func1<string, Arc<Async<Option<string>>>> {
        static v11: OnceInit<Func1<string, Arc<Async<Option<string>>>>> = OnceInit::new();
        v11.get_or_init(|| Func1::new(move |v: string| File_system::closure27((), v)))
            .clone()
    }
    pub fn read_all_text_retry_async(x: string) -> Arc<Async<Option<string>>> {
        (File_system::v11())(x)
    }
    pub fn v12() -> Func0<string> {
        static v12: OnceInit<Func0<string>> = OnceInit::new();
        v12.get_or_init(|| Func0::new(move || File_system::closure35((), ())))
            .clone()
    }
    pub fn create_temp_path() -> string {
        (File_system::v12())()
    }
    pub fn v13() -> Func0<(string, LrcPtr<dyn IDisposable>)> {
        static v13: OnceInit<Func0<(string, LrcPtr<dyn IDisposable>)>> = OnceInit::new();
        v13.get_or_init(|| Func0::new(move || File_system::closure36((), ())))
            .clone()
    }
    pub fn create_temp_dir() -> (string, LrcPtr<dyn IDisposable>) {
        (File_system::v13())()
    }
    pub fn v14() -> Func1<string, (string, LrcPtr<dyn IDisposable>)> {
        static v14: OnceInit<Func1<string, (string, LrcPtr<dyn IDisposable>)>> = OnceInit::new();
        v14.get_or_init(|| Func1::new(move |v: string| File_system::closure48((), v)))
            .clone()
    }
    pub fn create_temp_dir_(x: string) -> (string, LrcPtr<dyn IDisposable>) {
        (File_system::v14())(x)
    }
    pub fn v15() -> Func0<string> {
        static v15: OnceInit<Func0<string>> = OnceInit::new();
        v15.get_or_init(|| Func0::new(move || File_system::closure49((), ())))
            .clone()
    }
    pub fn get_source_directory() -> string {
        (File_system::v15())()
    }
    pub fn v16() -> Func1<string, string> {
        static v16: OnceInit<Func1<string, string>> = OnceInit::new();
        v16.get_or_init(|| Func1::new(move |v: string| File_system::closure50((), v)))
            .clone()
    }
    pub fn normalize_path(x: string) -> string {
        (File_system::v16())(x)
    }
    pub fn v17() -> Func1<string, string> {
        static v17: OnceInit<Func1<string, string>> = OnceInit::new();
        v17.get_or_init(|| Func1::new(move |v: string| File_system::closure51((), v)))
            .clone()
    }
    pub fn new_file_uri(x: string) -> string {
        (File_system::v17())(x)
    }
    pub fn v18() -> Func0<string> {
        static v18: OnceInit<Func0<string>> = OnceInit::new();
        v18.get_or_init(|| Func0::new(move || File_system::closure52((), ())))
            .clone()
    }
    pub fn get_workspace_root() -> string {
        (File_system::v18())()
    }
    pub fn v19() -> Func1<bool, ()> {
        static v19: OnceInit<Func1<bool, ()>> = OnceInit::new();
        v19.get_or_init(|| Func1::new(move |v: bool| File_system::closure56((), v)))
            .clone()
    }
    pub fn init_trace_file(x: bool) {
        (File_system::v19())(x);
    }
    pub fn v20() -> Func1<string, Func1<string, string>> {
        static v20: OnceInit<Func1<string, Func1<string, string>>> = OnceInit::new();
        v20.get_or_init(|| Func1::new(move |v: string| File_system::closure58((), v)))
            .clone()
    }
    pub fn op_LessDivideGreater(x: string) -> Func1<string, string> {
        (File_system::v20())(x)
    }
    on_startup!(());
}
