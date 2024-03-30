pub mod File_system {
    use super::*;
    use fable_library_rust::Native_::on_startup;
    use fable_library_rust::Native_::Func0;
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
        let result: MutCell<Option<string>> = MutCell::new(None::<string>);
        {
            let x: string = panic!(
                "{}",
                sprintf!(
                    "create_temp_directory_name target: {}",
                    File_system::US1::US1_1(File_system::US0::US0_1)
                ),
            );
            result.set(Some(x))
        }
        getValue(result.get().clone())
    }
    pub fn v0() -> Func0<string> {
        static v0: OnceInit<Func0<string>> = OnceInit::new();
        v0.get_or_insert_with(|| Func0::new(move || File_system::closure0((), ())))
            .clone()
    }
    pub fn create_temp_directory_name() -> string {
        (File_system::v0())()
    }
    on_startup!((),);
}
