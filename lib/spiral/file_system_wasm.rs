pub mod File_system {
    use super::*;
    use fable_library_rust::Native_::defaultOf;
    use fable_library_rust::Native_::on_startup;
    use fable_library_rust::Native_::unbox;
    use fable_library_rust::Native_::Func0;
    use fable_library_rust::Native_::Func1;
    use fable_library_rust::Native_::MutCell;
    use fable_library_rust::Native_::OnceInit;
    use fable_library_rust::Option_::defaultValue;
    use fable_library_rust::Option_::getValue;
    use fable_library_rust::Option_::map;
    use fable_library_rust::String_::sprintf;
    use fable_library_rust::String_::string;
    #[derive(Clone, Debug, PartialEq, PartialOrd, Hash, Eq)]
    pub enum US0 {
        US0_0(string),
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
    pub fn closure1(unitVar: (), unitVar_1: ()) -> string {
        let _v0: MutCell<Option<string>> = MutCell::new(None::<string>);
        {
            let x: string = unbox::<string>(&defaultOf());
            _v0.set(Some(x))
        }
        getValue(_v0.get().clone())
    }
    pub fn method0(v0_1: string) -> string {
        v0_1
    }
    pub fn closure0(unitVar: (), unitVar_1: ()) -> string {
        let _v0: MutCell<Option<string>> = MutCell::new(None::<string>);
        {
            let x: string = unbox::<string>(&defaultOf());
            _v0.set(Some(x))
        }
        getValue(_v0.get().clone())
    }
    pub fn closure4(unitVar: (), unitVar_1: ()) -> string {
        string("")
    }
    pub fn closure3(v0_1: string, v1_1: string, unitVar: ()) -> string {
        sprintf!(
            "temp_folder: {} / result: {} {}",
            v0_1,
            v1_1,
            File_system::closure4((), ())
        )
    }
    pub fn closure2(unitVar: (), unitVar_1: ()) -> string {
        let _v0: MutCell<Option<string>> = MutCell::new(None::<string>);
        {
            let x: string = unbox::<string>(&defaultOf());
            _v0.set(Some(x))
        }
        getValue(_v0.get().clone())
    }
    pub fn closure5(unitVar: (), unitVar_1: ()) -> string {
        string("C:\\home\\git\\polyglot\\lib\\spiral")
    }
    pub fn closure9(unitVar: (), v0_1: string) -> bool {
        let _v1: MutCell<Option<bool>> = MutCell::new(None::<bool>);
        {
            let x: bool = unbox::<bool>(&defaultOf());
            _v1.set(Some(x))
        }
        getValue(_v1.get().clone())
    }
    pub fn closure10(unitVar: (), v0_1: string) -> bool {
        let _v1: MutCell<Option<bool>> = MutCell::new(None::<bool>);
        {
            let x: bool = unbox::<bool>(&defaultOf());
            _v1.set(Some(x))
        }
        getValue(_v1.get().clone())
    }
    pub fn closure11(unitVar: (), v0_1: string) -> Option<string> {
        let _v1: MutCell<Option<File_system::US0>> = MutCell::new(None::<File_system::US0>);
        {
            let x: File_system::US0 = unbox::<File_system::US0>(&defaultOf());
            _v1.set(Some(x))
        }
        {
            let v35: File_system::US0 = getValue(_v1.get().clone());
            match &v35 {
                File_system::US0::US0_0(v35_0_0) => Some(match &v35 {
                    File_system::US0::US0_0(x) => x.clone(),
                    _ => unreachable!(),
                }),
                _ => None::<string>,
            }
        }
    }
    pub fn method2() -> Func1<string, Option<string>> {
        Func1::new(move |v: string| File_system::closure11((), v))
    }
    pub fn closure12(unitVar: (), v0_1: string) -> File_system::US0 {
        File_system::US0::US0_0(v0_1)
    }
    pub fn method3() -> Func1<string, File_system::US0> {
        Func1::new(move |v: string| File_system::closure12((), v))
    }
    pub fn method4(v0_1: string, v1_1: bool, v2_1: string, v3_1: string) -> string {
        let v0_1: MutCell<string> = MutCell::new(v0_1.clone());
        let v1_1: MutCell<bool> = MutCell::new(v1_1);
        let v2_1: MutCell<string> = MutCell::new(v2_1.clone());
        let v3_1: MutCell<string> = MutCell::new(v3_1.clone());
        '_method4: loop {
            break '_method4 ({
                let _v4: MutCell<Option<string>> = MutCell::new(None::<string>);
                {
                    let x: string = unbox::<string>(&defaultOf());
                    _v4.set(Some(x))
                }
                if (if v1_1.get().clone() {
                    Func1::new(move |v: string| File_system::closure9((), v))
                } else {
                    Func1::new(move |v_1: string| File_system::closure10((), v_1))
                })(getValue(_v4.get().clone()))
                {
                    v3_1.get().clone()
                } else {
                    let v33: Option<string> = (File_system::method2())(v3_1.get().clone());
                    let v36: File_system::US0 =
                        defaultValue(File_system::US0::US0_1, map(File_system::method3(), v33));
                    match &v36 {
                        File_system::US0::US0_0(v36_0_0) => {
                            let v0_1_temp: string = v0_1.get().clone();
                            let v1_1_temp: bool = v1_1.get().clone();
                            let v2_1_temp: string = v2_1.get().clone();
                            let v3_1_temp: string = match &v36 {
                                File_system::US0::US0_0(x) => x.clone(),
                                _ => unreachable!(),
                            };
                            v0_1.set(v0_1_temp);
                            v1_1.set(v1_1_temp);
                            v2_1.set(v2_1_temp);
                            v3_1.set(v3_1_temp);
                            continue '_method4;
                        }
                        _ => panic!(
                            "{}",
                            sprintf!(
                                "No parent for {} \'{}\' at \'{}\'",
                                if v1_1.get().clone() {
                                    string("file")
                                } else {
                                    string("dir")
                                },
                                v0_1.get().clone(),
                                v2_1.get().clone()
                            ),
                        ),
                    }
                }
            });
        }
    }
    pub fn method1(v0_1: string, v1_1: bool, v2_1: string) -> string {
        let _v3: MutCell<Option<string>> = MutCell::new(None::<string>);
        {
            let x: string = unbox::<string>(&defaultOf());
            _v3.set(Some(x))
        }
        if (if v1_1 {
            Func1::new(move |v: string| File_system::closure9((), v))
        } else {
            Func1::new(move |v_1: string| File_system::closure10((), v_1))
        })(getValue(_v3.get().clone()))
        {
            v2_1.clone()
        } else {
            let v32: Option<string> = (File_system::method2())(v2_1.clone());
            let v35: File_system::US0 =
                defaultValue(File_system::US0::US0_1, map(File_system::method3(), v32));
            match &v35 {
                File_system::US0::US0_0(v35_0_0) => File_system::method4(
                    v0_1.clone(),
                    v1_1,
                    v2_1.clone(),
                    match &v35 {
                        File_system::US0::US0_0(x) => x.clone(),
                        _ => unreachable!(),
                    },
                ),
                _ => panic!(
                    "{}",
                    sprintf!(
                        "No parent for {} \'{}\' at \'{}\'",
                        if v1_1 { string("file") } else { string("dir") },
                        v0_1.clone(),
                        v2_1.clone()
                    ),
                ),
            }
        }
    }
    pub fn closure8(v0_1: string, v1_1: bool, v2_1: string) -> string {
        File_system::method1(v0_1, v1_1, v2_1)
    }
    pub fn closure7(v0_1: string, v1_1: bool) -> Func1<string, string> {
        Func1::new({
            let v0_1 = v0_1.clone();
            let v1_1 = v1_1.clone();
            move |v: string| File_system::closure8(v0_1.clone(), v1_1, v)
        })
    }
    pub fn closure6(unitVar: (), v0_1: string) -> Func1<bool, Func1<string, string>> {
        Func1::new({
            let v0_1 = v0_1.clone();
            move |v: bool| File_system::closure7(v0_1.clone(), v)
        })
    }
    pub fn closure14(v0_1: string, v1_1: string) -> string {
        let _v2: MutCell<Option<string>> = MutCell::new(None::<string>);
        {
            let x: string = unbox::<string>(&defaultOf());
            _v2.set(Some(x))
        }
        getValue(_v2.get().clone())
    }
    pub fn closure13(unitVar: (), v0_1: string) -> Func1<string, string> {
        Func1::new({
            let v0_1 = v0_1.clone();
            move |v: string| File_system::closure14(v0_1.clone(), v)
        })
    }
    pub fn v0() -> Func0<string> {
        static v0: OnceInit<Func0<string>> = OnceInit::new();
        v0.get_or_insert_with(|| Func0::new(move || File_system::closure0((), ())))
            .clone()
    }
    pub fn create_temp_directory_name() -> string {
        (File_system::v0())()
    }
    pub fn v1() -> Func0<string> {
        static v1: OnceInit<Func0<string>> = OnceInit::new();
        v1.get_or_insert_with(|| Func0::new(move || File_system::closure2((), ())))
            .clone()
    }
    pub fn create_temp_directory() -> string {
        (File_system::v1())()
    }
    pub fn v2() -> Func0<string> {
        static v2: OnceInit<Func0<string>> = OnceInit::new();
        v2.get_or_insert_with(|| Func0::new(move || File_system::closure5((), ())))
            .clone()
    }
    pub fn get_source_directory() -> string {
        (File_system::v2())()
    }
    pub fn v3() -> Func1<string, Func1<bool, Func1<string, string>>> {
        static v3: OnceInit<Func1<string, Func1<bool, Func1<string, string>>>> = OnceInit::new();
        v3.get_or_insert_with(|| Func1::new(move |v: string| File_system::closure6((), v)))
            .clone()
    }
    pub fn find_parent(x: string) -> Func1<bool, Func1<string, string>> {
        (File_system::v3())(x)
    }
    pub fn v4() -> Func1<string, Func1<string, string>> {
        static v4: OnceInit<Func1<string, Func1<string, string>>> = OnceInit::new();
        v4.get_or_insert_with(|| Func1::new(move |v: string| File_system::closure13((), v)))
            .clone()
    }
    pub fn op_LessDivideGreater(x: string) -> Func1<string, string> {
        (File_system::v4())(x)
    }
    on_startup!((),);
}
