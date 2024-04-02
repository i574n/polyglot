pub mod File_system {
    use super::*;
    use fable_library_rust::Native_::on_startup;
    use fable_library_rust::Native_::Func0;
    use fable_library_rust::Native_::Func1;
    use fable_library_rust::Native_::MutCell;
    use fable_library_rust::Native_::OnceInit;
    use fable_library_rust::Option_::getValue;
    use fable_library_rust::String_::sprintf;
    use fable_library_rust::String_::string;
    #[derive(Clone, Copy, Debug, PartialEq, PartialOrd, Hash, Eq)]
    pub enum US0 {
        US0_0,
        US0_1,
        US0_2,
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
    }
    impl core::fmt::Display for File_system::US0 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Copy, Debug, PartialEq, PartialOrd, Hash, Eq)]
    pub enum US1 {
        US1_0(File_system::US0),
        US1_1(File_system::US0),
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
    pub fn closure0(unitVar: (), unitVar_1: ()) -> string {
        let _v0: MutCell<Option<string>> = MutCell::new(None::<string>);
        {
            let x: string = panic!(
                "{}",
                sprintf!(
                    "create_temp_directory_name / target: {}",
                    File_system::US1::US1_0(File_system::US0::US0_0)
                ),
            );
            _v0.set(Some(x))
        }
        getValue(_v0.get().clone())
    }
    pub fn closure3(unitVar: (), unitVar_1: ()) -> string {
        string("")
    }
    pub fn closure2(v0_1: string, v1_1: string, unitVar: ()) -> string {
        sprintf!(
            "temp_folder: {} / result: {} {}",
            v0_1,
            v1_1,
            File_system::closure3((), ())
        )
    }
    pub fn closure1(unitVar: (), unitVar_1: ()) -> string {
        let _v0: MutCell<Option<string>> = MutCell::new(None::<string>);
        {
            let x: string = panic!(
                "{}",
                sprintf!(
                    "create_temp_directory / target: {}",
                    File_system::US1::US1_0(File_system::US0::US0_0)
                ),
            );
            _v0.set(Some(x))
        }
        getValue(_v0.get().clone())
    }
    pub fn closure5(v0_1: string, v1_1: string) -> string {
        let _v2: MutCell<Option<string>> = MutCell::new(None::<string>);
        {
            let x: string = panic!(
                "{}",
                sprintf!(
                    "(</>) / target: {}",
                    File_system::US1::US1_0(File_system::US0::US0_0)
                ),
            );
            _v2.set(Some(x))
        }
        getValue(_v2.get().clone())
    }
    pub fn closure4(unitVar: (), v0_1: string) -> Func1<string, string> {
        Func1::new({
            let v0_1 = v0_1.clone();
            move |v: string| File_system::closure5(v0_1.clone(), v)
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
        v1.get_or_insert_with(|| Func0::new(move || File_system::closure1((), ())))
            .clone()
    }
    pub fn create_temp_directory() -> string {
        (File_system::v1())()
    }
    pub fn v2() -> Func1<string, Func1<string, string>> {
        static v2: OnceInit<Func1<string, Func1<string, string>>> = OnceInit::new();
        v2.get_or_insert_with(|| Func1::new(move |v: string| File_system::closure4((), v)))
            .clone()
    }
    pub fn op_LessDivideGreater(x: string) -> Func1<string, string> {
        (File_system::v2())(x)
    }
    on_startup!((),);
}
