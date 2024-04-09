pub mod File_system {
    use super::*;
    type Async<T> = Option<T>;
    use fable_library_rust::Interfaces_::System::IDisposable;
    use fable_library_rust::NativeArray_::Array;
    use fable_library_rust::Native_::defaultOf;
    use fable_library_rust::Native_::on_startup;
    use fable_library_rust::Native_::unbox;
    use fable_library_rust::Native_::Arc;
    use fable_library_rust::Native_::Func0;
    use fable_library_rust::Native_::Func1;
    use fable_library_rust::Native_::LrcPtr;
    use fable_library_rust::Native_::MutCell;
    use fable_library_rust::Native_::OnceInit;
    use fable_library_rust::Option_::defaultValue;
    use fable_library_rust::Option_::getValue;
    use fable_library_rust::Option_::map;
    use fable_library_rust::String_::sprintf;
    use fable_library_rust::String_::string;
    use fable_library_rust::System::Exception;
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
    pub enum US1 {
        US1_0,
        US1_1,
        US1_2,
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
        pub fn get_IsUS1_2(this_: &MutCell<File_system::US1>, unitArg: ()) -> bool {
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
        US2_0,
        US2_1,
        US2_2,
        US2_3,
        US2_4,
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
        pub fn get_IsUS2_2(this_: &MutCell<File_system::US2>, unitArg: ()) -> bool {
            if unreachable!() {
                true
            } else {
                false
            }
        }
        pub fn get_IsUS2_3(this_: &MutCell<File_system::US2>, unitArg: ()) -> bool {
            if unreachable!() {
                true
            } else {
                false
            }
        }
        pub fn get_IsUS2_4(this_: &MutCell<File_system::US2>, unitArg: ()) -> bool {
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
    #[derive(Clone, Copy, Debug, PartialEq, PartialOrd, Hash, Eq)]
    pub enum US0 {
        US0_0(File_system::US1, File_system::US2),
        US0_1,
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
    }
    impl core::fmt::Display for File_system::US0 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Copy, Debug, PartialEq, PartialOrd, Hash, Eq)]
    pub enum US3 {
        US3_0(i64),
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
    #[derive(Clone, Debug)]
    pub enum US4 {
        US4_0(i64),
        US4_1(LrcPtr<Exception>),
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
    }
    impl core::fmt::Display for File_system::US4 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Debug)]
    pub enum US5 {
        US5_0(i64),
        US5_1(LrcPtr<Exception>),
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
    }
    impl core::fmt::Display for File_system::US5 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Debug, PartialEq, PartialOrd, Hash, Eq)]
    pub enum US6 {
        US6_0(string),
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
    pub fn closure2(unitVar: (), v0_1: string) -> string {
        let _v1: MutCell<Option<string>> = MutCell::new(None::<string>);
        {
            let x: string = unbox::<string>(&defaultOf());
            _v1.set(Some(x))
        }
        getValue(_v1.get().clone())
    }
    pub fn closure3(unitVar: (), unitVar_1: ()) -> string {
        string("")
    }
    pub fn method1(v0_1: string, v1: string) -> string {
        sprintf!(
            "path: {} / ex: {} / {}",
            File_system::closure2((), v0_1),
            v1,
            File_system::closure3((), ())
        )
    }
    pub fn closure1(v0_1: string, v1: string, unitVar: ()) -> string {
        File_system::method1(v0_1, v1)
    }
    pub fn method0(v0_1: string, v1: i64) -> Arc<Async<i64>> {
        let _v2: MutCell<Option<Arc<Async<i64>>>> = MutCell::new(None::<Arc<Async<i64>>>);
        {
            let x: Arc<Async<i64>> = defaultOf();
            _v2.set(Some(x))
        }
        getValue(_v2.get().clone())
    }
    pub fn closure0(unitVar: (), v0_1: string) -> Arc<Async<i64>> {
        let _v1: MutCell<Option<Arc<Async<i64>>>> = MutCell::new(None::<Arc<Async<i64>>>);
        {
            let x: Arc<Async<i64>> = defaultOf();
            _v1.set(Some(x))
        }
        getValue(_v1.get().clone())
    }
    pub fn method3(v0_1: string, v1: i64, v2: string) -> string {
        sprintf!(
            "path: {} / retry: {} / ex: {} / {}",
            File_system::closure2((), v0_1),
            v1,
            v2,
            File_system::closure3((), ())
        )
    }
    pub fn closure6(v0_1: string, v1: i64, v2: string, unitVar: ()) -> string {
        File_system::method3(v0_1, v1, v2)
    }
    pub fn method2(
        v0_1: string,
        v1: File_system::US2,
        v2: File_system::US1,
        v3: i64,
    ) -> Arc<Async<i64>> {
        let _v4: MutCell<Option<Arc<Async<i64>>>> = MutCell::new(None::<Arc<Async<i64>>>);
        {
            let x: Arc<Async<i64>> = defaultOf();
            _v4.set(Some(x))
        }
        getValue(_v4.get().clone())
    }
    pub fn closure5(v0_1: File_system::US0, v1: string) -> Arc<Async<i64>> {
        let _v2: MutCell<Option<Arc<Async<i64>>>> = MutCell::new(None::<Arc<Async<i64>>>);
        {
            let x: Arc<Async<i64>> = defaultOf();
            _v2.set(Some(x))
        }
        getValue(_v2.get().clone())
    }
    pub fn closure4(unitVar: (), v0_1: File_system::US0) -> Func1<string, Arc<Async<i64>>> {
        Func1::new({
            let v0_1 = v0_1.clone();
            move |v: string| File_system::closure5(v0_1.clone(), v)
        })
    }
    pub fn method4(v0_1: string, v1: i64) -> Arc<Async<i64>> {
        let _v2: MutCell<Option<Arc<Async<i64>>>> = MutCell::new(None::<Arc<Async<i64>>>);
        {
            let x: Arc<Async<i64>> = defaultOf();
            _v2.set(Some(x))
        }
        getValue(_v2.get().clone())
    }
    pub fn closure7(unitVar: (), v0_1: string) -> Arc<Async<i64>> {
        let _v1: MutCell<Option<Arc<Async<i64>>>> = MutCell::new(None::<Arc<Async<i64>>>);
        {
            let x: Arc<Async<i64>> = defaultOf();
            _v1.set(Some(x))
        }
        getValue(_v1.get().clone())
    }
    pub fn closure8(unitVar: (), v0_1: string) -> Arc<Async<string>> {
        let _v1: MutCell<Option<Arc<Async<string>>>> = MutCell::new(None::<Arc<Async<string>>>);
        {
            let x: Arc<Async<string>> = defaultOf();
            _v1.set(Some(x))
        }
        getValue(_v1.get().clone())
    }
    pub fn method5(v0_1: string) -> string {
        v0_1
    }
    pub fn closure10(v0_1: string, v1: string) -> Arc<Async<bool>> {
        let _v2: MutCell<Option<Arc<Async<bool>>>> = MutCell::new(None::<Arc<Async<bool>>>);
        {
            let x: Arc<Async<bool>> = defaultOf();
            _v2.set(Some(x))
        }
        getValue(_v2.get().clone())
    }
    pub fn closure9(unitVar: (), v0_1: string) -> Func1<string, Arc<Async<bool>>> {
        Func1::new({
            let v0_1 = v0_1.clone();
            move |v: string| File_system::closure10(v0_1.clone(), v)
        })
    }
    pub fn closure12(v0_1: string, v1: string) -> Arc<Async<()>> {
        let _v2: MutCell<Option<Arc<Async<()>>>> = MutCell::new(None::<Arc<Async<()>>>);
        {
            let x: Arc<Async<()>> = defaultOf();
            _v2.set(Some(x))
        }
        getValue(_v2.get().clone())
    }
    pub fn closure11(unitVar: (), v0_1: string) -> Func1<string, Arc<Async<()>>> {
        Func1::new({
            let v0_1 = v0_1.clone();
            move |v: string| File_system::closure12(v0_1.clone(), v)
        })
    }
    pub fn closure14(v0_1: string, v1: string) -> Arc<Async<()>> {
        let _v2: MutCell<Option<Arc<Async<()>>>> = MutCell::new(None::<Arc<Async<()>>>);
        {
            let x: Arc<Async<()>> = defaultOf();
            _v2.set(Some(x))
        }
        getValue(_v2.get().clone())
    }
    pub fn closure13(unitVar: (), v0_1: string) -> Func1<string, Arc<Async<()>>> {
        Func1::new({
            let v0_1 = v0_1.clone();
            move |v: string| File_system::closure14(v0_1.clone(), v)
        })
    }
    pub fn method6(v0_1: string, v1: i64) -> Arc<Async<i64>> {
        let _v2: MutCell<Option<Arc<Async<i64>>>> = MutCell::new(None::<Arc<Async<i64>>>);
        {
            let x: Arc<Async<i64>> = defaultOf();
            _v2.set(Some(x))
        }
        getValue(_v2.get().clone())
    }
    pub fn closure15(unitVar: (), v0_1: string) -> Arc<Async<i64>> {
        let _v1: MutCell<Option<Arc<Async<i64>>>> = MutCell::new(None::<Arc<Async<i64>>>);
        {
            let x: Arc<Async<i64>> = defaultOf();
            _v1.set(Some(x))
        }
        getValue(_v1.get().clone())
    }
    pub fn method8(v0_1: string, v1: string, v2: LrcPtr<Exception>) -> string {
        let _v3: MutCell<Option<string>> = MutCell::new(None::<string>);
        {
            let x: string = sprintf!("{:?}", v2);
            _v3.set(Some(x))
        }
        {
            let v9: string = getValue(_v3.get().clone());
            let v10 = Func1::new(move |v: string| File_system::closure2((), v));
            sprintf!(
                "old_path: {} / new_path: {} / ex: {} / {}",
                v10(v1),
                v10(v0_1),
                v9,
                File_system::closure3((), ())
            )
        }
    }
    pub fn closure18(v0_1: string, v1: string, v2: LrcPtr<Exception>, unitVar: ()) -> string {
        File_system::method8(v0_1, v1, v2)
    }
    pub fn method7(v0_1: string, v1: string, v2: i64) -> Arc<Async<i64>> {
        let _v3: MutCell<Option<Arc<Async<i64>>>> = MutCell::new(None::<Arc<Async<i64>>>);
        {
            let x: Arc<Async<i64>> = defaultOf();
            _v3.set(Some(x))
        }
        getValue(_v3.get().clone())
    }
    pub fn closure17(v0_1: string, v1: string) -> Arc<Async<i64>> {
        let _v2: MutCell<Option<Arc<Async<i64>>>> = MutCell::new(None::<Arc<Async<i64>>>);
        {
            let x: Arc<Async<i64>> = defaultOf();
            _v2.set(Some(x))
        }
        getValue(_v2.get().clone())
    }
    pub fn closure16(unitVar: (), v0_1: string) -> Func1<string, Arc<Async<i64>>> {
        Func1::new({
            let v0_1 = v0_1.clone();
            move |v: string| File_system::closure17(v0_1.clone(), v)
        })
    }
    pub fn closure20(unitVar: (), v0_1: i64) -> File_system::US4 {
        File_system::US4::US4_0(v0_1)
    }
    pub fn closure21(unitVar: (), v0_1: LrcPtr<Exception>) -> File_system::US4 {
        File_system::US4::US4_1(v0_1)
    }
    pub fn closure22(unitVar: (), unitVar_1: ()) -> string {
        sprintf!("timeout: {} / {}", 1000_i32, File_system::closure3((), ()))
    }
    pub fn method10(v0_1: i64, v1: string) -> string {
        sprintf!(
            "retry: {} / ex: {} / {}",
            v0_1,
            v1,
            File_system::closure3((), ())
        )
    }
    pub fn closure23(v0_1: i64, v1: string, unitVar: ()) -> string {
        File_system::method10(v0_1, v1)
    }
    pub fn method9(v0_1: string, v1: i64) -> Arc<Async<Option<string>>> {
        let _v2: MutCell<Option<Arc<Async<Option<string>>>>> =
            MutCell::new(None::<Arc<Async<Option<string>>>>);
        {
            let x: Arc<Async<Option<string>>> = defaultOf();
            _v2.set(Some(x))
        }
        getValue(_v2.get().clone())
    }
    pub fn closure19(unitVar: (), v0_1: string) -> Arc<Async<Option<string>>> {
        let _v1: MutCell<Option<Arc<Async<Option<string>>>>> =
            MutCell::new(None::<Arc<Async<Option<string>>>>);
        {
            let x: Arc<Async<Option<string>>> = defaultOf();
            _v1.set(Some(x))
        }
        getValue(_v1.get().clone())
    }
    pub fn closure25(unitVar: (), unitVar_1: ()) -> string {
        let _v0_1: MutCell<Option<string>> = MutCell::new(None::<string>);
        {
            let x: string = unbox::<string>(&defaultOf());
            _v0_1.set(Some(x))
        }
        getValue(_v0_1.get().clone())
    }
    pub fn closure24(unitVar: (), unitVar_1: ()) -> string {
        let _v0_1: MutCell<Option<string>> = MutCell::new(None::<string>);
        {
            let x: string = unbox::<string>(&defaultOf());
            _v0_1.set(Some(x))
        }
        getValue(_v0_1.get().clone())
    }
    pub fn closure27(v0_1: string, v1: string, unitVar: ()) -> string {
        sprintf!(
            "temp_folder: {} / result: {} {}",
            v0_1,
            v1,
            File_system::closure3((), ())
        )
    }
    pub fn closure28(v0_1: string, unitVar: ()) {
        let _v1: MutCell<Option<Arc<Async<i64>>>> = MutCell::new(None::<Arc<Async<i64>>>);
        {
            let x: Arc<Async<i64>> = defaultOf();
            _v1.set(Some(x))
        }
        {
            let v8: Arc<Async<i64>> = getValue(_v1.get().clone());
            let _v9: MutCell<Option<Arc<Async<()>>>> = MutCell::new(None::<Arc<Async<()>>>);
            {
                let x_1: Arc<Async<()>> = defaultOf();
                _v9.set(Some(x_1))
            }
            {
                let v16: Arc<Async<()>> = getValue(_v9.get().clone());
                let _v17: MutCell<Option<()>> = MutCell::new(None::<()>);
                defaultOf::<()>();
                _v17.set(Some(()));
                getValue(_v17.get().clone());
                ()
            }
        }
    }
    pub fn closure26(unitVar: (), unitVar_1: ()) -> (string, LrcPtr<dyn IDisposable>) {
        let _v0_1: MutCell<Option<(string, LrcPtr<dyn IDisposable>)>> =
            MutCell::new(None::<(string, LrcPtr<dyn IDisposable>)>);
        let patternInput: (string, LrcPtr<dyn IDisposable>) =
            unbox::<(string, LrcPtr<dyn IDisposable>)>(&defaultOf());
        _v0_1.set(Some((patternInput.0.clone(), patternInput.1.clone())));
        {
            let patternInput_1: (string, LrcPtr<dyn IDisposable>) = getValue(_v0_1.get().clone());
            (patternInput_1.0.clone(), patternInput_1.1.clone())
        }
    }
    pub fn closure29(unitVar: (), unitVar_1: ()) -> string {
        string("C:\\home\\git\\polyglot\\lib\\spiral")
    }
    pub fn closure33(unitVar: (), v0_1: string) -> bool {
        let _v1: MutCell<Option<bool>> = MutCell::new(None::<bool>);
        let v2: string = File_system::method5(v0_1);
        let v4: &str = fable_library_rust::String_::LrcStr::as_str(&v2);
        let v6: std::string::String = String::from(v4);
        let v8: std::path::PathBuf = std::path::PathBuf::from(v6);
        {
            let x: bool = if v8.clone().exists() {
                v8.is_file()
            } else {
                false
            };
            _v1.set(Some(x))
        }
        getValue(_v1.get().clone())
    }
    pub fn closure34(unitVar: (), v0_1: string) -> bool {
        let _v1: MutCell<Option<bool>> = MutCell::new(None::<bool>);
        let v2: string = File_system::method5(v0_1);
        let v4: &str = fable_library_rust::String_::LrcStr::as_str(&v2);
        let v6: std::string::String = String::from(v4);
        let v8: std::path::PathBuf = std::path::PathBuf::from(v6);
        {
            let x: bool = if v8.clone().exists() {
                v8.is_dir()
            } else {
                false
            };
            _v1.set(Some(x))
        }
        getValue(_v1.get().clone())
    }
    pub fn closure35(unitVar: (), v0_1: string) -> Option<string> {
        let _v1: MutCell<Option<File_system::US6>> = MutCell::new(None::<File_system::US6>);
        let v2: string = File_system::method5(v0_1);
        let v4: &str = fable_library_rust::String_::LrcStr::as_str(&v2);
        let v6: std::string::String = String::from(v4);
        let v8: std::path::PathBuf = std::path::PathBuf::from(v6);
        let v10: Option<std::path::PathBuf> = v8.parent().map(std::path::PathBuf::from);
        let v12_1: std::path::PathBuf = v10?;
        let v14_1: std::string::String = v12_1.display().to_string();
        {
            let x: File_system::US6 =
                File_system::US6::US6_0(fable_library_rust::String_::fromString(v14_1));
            _v1.set(Some(x))
        }
        {
            let v39: File_system::US6 = getValue(_v1.get().clone());
            match &v39 {
                File_system::US6::US6_0(v39_0_0) => Some(match &v39 {
                    File_system::US6::US6_0(x) => x.clone(),
                    _ => unreachable!(),
                }),
                _ => None::<string>,
            }
        }
    }
    pub fn method12() -> Func1<string, Option<string>> {
        Func1::new(move |v: string| File_system::closure35((), v))
    }
    pub fn closure36(unitVar: (), v0_1: string) -> File_system::US6 {
        File_system::US6::US6_0(v0_1)
    }
    pub fn method13() -> Func1<string, File_system::US6> {
        Func1::new(move |v: string| File_system::closure36((), v))
    }
    pub fn method14(v0_1: string, v1: bool, v2: string, v3: string) -> string {
        let v0_1: MutCell<string> = MutCell::new(v0_1.clone());
        let v1: MutCell<bool> = MutCell::new(v1);
        let v2: MutCell<string> = MutCell::new(v2.clone());
        let v3: MutCell<string> = MutCell::new(v3.clone());
        '_method14: loop {
            break '_method14 ({
                let _v4: MutCell<Option<string>> = MutCell::new(None::<string>);
                let v5: string = File_system::method5(v3.get().clone());
                let v7: &str = fable_library_rust::String_::LrcStr::as_str(&v5);
                let v9: std::string::String = String::from(v7);
                let v11_1: std::path::PathBuf = std::path::PathBuf::from(v9);
                let v12_1: string = File_system::method5(v0_1.get().clone());
                let v14_1: &str = fable_library_rust::String_::LrcStr::as_str(&v12_1);
                let v16: std::string::String = String::from(v14_1);
                let v18: std::path::PathBuf = v11_1.join(v16);
                let v20: std::string::String = v18.display().to_string();
                {
                    let x: string = fable_library_rust::String_::fromString(v20);
                    _v4.set(Some(x))
                }
                if (if v1.get().clone() {
                    Func1::new(move |v: string| File_system::closure33((), v))
                } else {
                    Func1::new(move |v_1: string| File_system::closure34((), v_1))
                })(getValue(_v4.get().clone()))
                {
                    v3.get().clone()
                } else {
                    let v36: Option<string> = (File_system::method12())(v3.get().clone());
                    let v39: File_system::US6 =
                        defaultValue(File_system::US6::US6_1, map(File_system::method13(), v36));
                    match &v39 {
                        File_system::US6::US6_0(v39_0_0) => {
                            let v0_1_temp: string = v0_1.get().clone();
                            let v1_temp: bool = v1.get().clone();
                            let v2_temp: string = v2.get().clone();
                            let v3_temp: string = match &v39 {
                                File_system::US6::US6_0(x) => x.clone(),
                                _ => unreachable!(),
                            };
                            v0_1.set(v0_1_temp);
                            v1.set(v1_temp);
                            v2.set(v2_temp);
                            v3.set(v3_temp);
                            continue '_method14;
                        }
                        _ => panic!(
                            "{}",
                            sprintf!(
                                "No parent for {} \'{}\' at \'{}\'",
                                if v1.get().clone() {
                                    string("file")
                                } else {
                                    string("dir")
                                },
                                v0_1.get().clone(),
                                v2.get().clone()
                            ),
                        ),
                    }
                }
            });
        }
    }
    pub fn method11(v0_1: string, v1: bool, v2: string) -> string {
        let _v3: MutCell<Option<string>> = MutCell::new(None::<string>);
        let v4: string = File_system::method5(v2.clone());
        let v6: &str = fable_library_rust::String_::LrcStr::as_str(&v4);
        let v8: std::string::String = String::from(v6);
        let v10: std::path::PathBuf = std::path::PathBuf::from(v8);
        let v11_1: string = File_system::method5(v0_1.clone());
        let v13_1: &str = fable_library_rust::String_::LrcStr::as_str(&v11_1);
        let v15_1: std::string::String = String::from(v13_1);
        let v17: std::path::PathBuf = v10.join(v15_1);
        let v19: std::string::String = v17.display().to_string();
        {
            let x: string = fable_library_rust::String_::fromString(v19);
            _v3.set(Some(x))
        }
        if (if v1 {
            Func1::new(move |v: string| File_system::closure33((), v))
        } else {
            Func1::new(move |v_1: string| File_system::closure34((), v_1))
        })(getValue(_v3.get().clone()))
        {
            v2.clone()
        } else {
            let v35: Option<string> = (File_system::method12())(v2.clone());
            let v38: File_system::US6 =
                defaultValue(File_system::US6::US6_1, map(File_system::method13(), v35));
            match &v38 {
                File_system::US6::US6_0(v38_0_0) => File_system::method14(
                    v0_1.clone(),
                    v1,
                    v2.clone(),
                    match &v38 {
                        File_system::US6::US6_0(x) => x.clone(),
                        _ => unreachable!(),
                    },
                ),
                _ => panic!(
                    "{}",
                    sprintf!(
                        "No parent for {} \'{}\' at \'{}\'",
                        if v1 { string("file") } else { string("dir") },
                        v0_1.clone(),
                        v2.clone()
                    ),
                ),
            }
        }
    }
    pub fn closure32(v0_1: string, v1: bool, v2: string) -> string {
        File_system::method11(v0_1, v1, v2)
    }
    pub fn closure31(v0_1: string, v1: bool) -> Func1<string, string> {
        Func1::new({
            let v0_1 = v0_1.clone();
            let v1 = v1.clone();
            move |v: string| File_system::closure32(v0_1.clone(), v1, v)
        })
    }
    pub fn closure30(unitVar: (), v0_1: string) -> Func1<bool, Func1<string, string>> {
        Func1::new({
            let v0_1 = v0_1.clone();
            move |v: bool| File_system::closure31(v0_1.clone(), v)
        })
    }
    pub fn closure38(v0_1: string, v1: string) -> string {
        let _v2: MutCell<Option<string>> = MutCell::new(None::<string>);
        let v3: string = File_system::method5(v0_1);
        let v5: &str = fable_library_rust::String_::LrcStr::as_str(&v3);
        let v7: std::string::String = String::from(v5);
        let v9: std::path::PathBuf = std::path::PathBuf::from(v7);
        let v10: string = File_system::method5(v1);
        let v12_1: &str = fable_library_rust::String_::LrcStr::as_str(&v10);
        let v14_1: std::string::String = String::from(v12_1);
        let v16: std::path::PathBuf = v9.join(v14_1);
        let v18: std::string::String = v16.display().to_string();
        {
            let x: string = fable_library_rust::String_::fromString(v18);
            _v2.set(Some(x))
        }
        getValue(_v2.get().clone())
    }
    pub fn closure37(unitVar: (), v0_1: string) -> Func1<string, string> {
        Func1::new({
            let v0_1 = v0_1.clone();
            move |v: string| File_system::closure38(v0_1.clone(), v)
        })
    }
    pub fn v0() -> Option<()> {
        static v0: OnceInit<Option<()>> = OnceInit::new();
        v0.get_or_insert_with(|| None::<()>).clone()
    }
    pub fn _v0() -> LrcPtr<MutCell<Option<()>>> {
        static _v0: OnceInit<LrcPtr<MutCell<Option<()>>>> = OnceInit::new();
        _v0.get_or_insert_with(|| LrcPtr::new(MutCell::new(File_system::v0())))
            .clone()
    }
    on_startup!(File_system::_v0().set(Some(())),);
    on_startup!(getValue(File_system::_v0().get().clone()),);
    pub fn v11() -> Func0<string> {
        static v11: OnceInit<Func0<string>> = OnceInit::new();
        v11.get_or_insert_with(|| Func0::new(move || File_system::closure24((), ())))
            .clone()
    }
    pub fn create_temp_directory_name() -> string {
        (File_system::v11())()
    }
    pub fn v12() -> Func0<(string, LrcPtr<dyn IDisposable>)> {
        static v12: OnceInit<Func0<(string, LrcPtr<dyn IDisposable>)>> = OnceInit::new();
        v12.get_or_insert_with(|| Func0::new(move || File_system::closure26((), ())))
            .clone()
    }
    pub fn create_temp_directory() -> (string, LrcPtr<dyn IDisposable>) {
        (File_system::v12())()
    }
    pub fn v13() -> Func0<string> {
        static v13: OnceInit<Func0<string>> = OnceInit::new();
        v13.get_or_insert_with(|| Func0::new(move || File_system::closure29((), ())))
            .clone()
    }
    pub fn get_source_directory() -> string {
        (File_system::v13())()
    }
    pub fn v14() -> Func1<string, Func1<bool, Func1<string, string>>> {
        static v14: OnceInit<Func1<string, Func1<bool, Func1<string, string>>>> = OnceInit::new();
        v14.get_or_insert_with(|| Func1::new(move |v: string| File_system::closure30((), v)))
            .clone()
    }
    pub fn find_parent(x: string) -> Func1<bool, Func1<string, string>> {
        (File_system::v14())(x)
    }
    pub fn v15() -> Func1<string, Func1<string, string>> {
        static v15: OnceInit<Func1<string, Func1<string, string>>> = OnceInit::new();
        v15.get_or_insert_with(|| Func1::new(move |v: string| File_system::closure37((), v)))
            .clone()
    }
    pub fn op_LessDivideGreater(x: string) -> Func1<string, string> {
        (File_system::v15())(x)
    }
    on_startup!((),);
}
