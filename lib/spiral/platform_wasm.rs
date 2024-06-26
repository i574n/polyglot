pub mod Platform {
    use super::*;
    use fable_library_rust::Native_::on_startup;
    use fable_library_rust::Native_::Func0;
    use fable_library_rust::Native_::MutCell;
    use fable_library_rust::Native_::OnceInit;
    use fable_library_rust::String_::string;
    #[derive(Clone, Copy, Debug, PartialEq, PartialOrd, Hash, Eq)]
    pub enum US0 {
        US0_0,
        US0_1,
        US0_2,
    }
    impl Platform::US0 {
        pub fn get_IsUS0_0(this_: &MutCell<Platform::US0>, unitArg: ()) -> bool {
            if unreachable!() {
                true
            } else {
                false
            }
        }
        pub fn get_IsUS0_1(this_: &MutCell<Platform::US0>, unitArg: ()) -> bool {
            if unreachable!() {
                true
            } else {
                false
            }
        }
        pub fn get_IsUS0_2(this_: &MutCell<Platform::US0>, unitArg: ()) -> bool {
            if unreachable!() {
                true
            } else {
                false
            }
        }
    }
    impl core::fmt::Display for Platform::US0 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Copy, Debug, PartialEq, PartialOrd, Hash, Eq)]
    pub enum US1 {
        US1_0(Platform::US0),
        US1_1(Platform::US0),
        US1_2(Platform::US0),
        US1_3(Platform::US0),
        US1_4(Platform::US0),
    }
    impl Platform::US1 {
        pub fn get_IsUS1_0(this_: &MutCell<Platform::US1>, unitArg: ()) -> bool {
            if unreachable!() {
                true
            } else {
                false
            }
        }
        pub fn get_IsUS1_1(this_: &MutCell<Platform::US1>, unitArg: ()) -> bool {
            if unreachable!() {
                true
            } else {
                false
            }
        }
        pub fn get_IsUS1_2(this_: &MutCell<Platform::US1>, unitArg: ()) -> bool {
            if unreachable!() {
                true
            } else {
                false
            }
        }
        pub fn get_IsUS1_3(this_: &MutCell<Platform::US1>, unitArg: ()) -> bool {
            if unreachable!() {
                true
            } else {
                false
            }
        }
        pub fn get_IsUS1_4(this_: &MutCell<Platform::US1>, unitArg: ()) -> bool {
            if unreachable!() {
                true
            } else {
                false
            }
        }
    }
    impl core::fmt::Display for Platform::US1 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    pub fn closure0(unitVar: (), unitVar_1: ()) -> bool {
        let _v0: MutCell<Option<bool>> = MutCell::new(None::<bool>);
        {
            let x: bool = cfg!(windows);
            _v0.set(Some(x))
        }
        match &_v0.get().clone() {
            None => panic!("{}", string("base.run_target / _v0=None"),),
            Some(_v0_0_0) => _v0_0_0.clone(),
        }
    }
    pub fn closure1(unitVar: (), unitVar_1: ()) -> string {
        let _v0: MutCell<Option<bool>> = MutCell::new(None::<bool>);
        {
            let x: bool = cfg!(windows);
            _v0.set(Some(x))
        }
        if match &_v0.get().clone() {
            None => panic!("{}", string("base.run_target / _v0=None"),),
            Some(_v0_0_0) => _v0_0_0.clone(),
        } {
            string(".exe")
        } else {
            string("")
        }
    }
    pub fn v0() -> Func0<bool> {
        static v0: OnceInit<Func0<bool>> = OnceInit::new();
        v0.get_or_init(|| Func0::new(move || Platform::closure0((), ())))
            .clone()
    }
    pub fn is_windows() -> bool {
        (Platform::v0())()
    }
    pub fn v1() -> Func0<string> {
        static v1: OnceInit<Func0<string>> = OnceInit::new();
        v1.get_or_init(|| Func0::new(move || Platform::closure1((), ())))
            .clone()
    }
    pub fn get_executable_suffix() -> string {
        (Platform::v1())()
    }
    on_startup!(());
}
