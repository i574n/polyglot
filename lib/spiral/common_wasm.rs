pub mod Common {
    use super::*;
    use fable_library_rust::Exception_::try_catch;
    use fable_library_rust::Interfaces_::System::IDisposable;
    use fable_library_rust::Native_::on_startup;
    use fable_library_rust::Native_::Func0;
    use fable_library_rust::Native_::Func1;
    use fable_library_rust::Native_::LrcPtr;
    use fable_library_rust::Native_::MutCell;
    use fable_library_rust::Native_::OnceInit;
    use fable_library_rust::Option_::getValue;
    use fable_library_rust::String_::sprintf;
    use fable_library_rust::System::Exception;
    #[derive(Clone, Copy, Debug, PartialEq, PartialOrd, Hash, Eq)]
    pub enum US0 {
        US0_0,
        US0_1,
        US0_2,
    }
    impl Common::US0 {
        pub fn get_IsUS0_0(this_: &MutCell<Common::US0>, unitArg: ()) -> bool {
            if unreachable!() {
                true
            } else {
                false
            }
        }
        pub fn get_IsUS0_1(this_: &MutCell<Common::US0>, unitArg: ()) -> bool {
            if unreachable!() {
                true
            } else {
                false
            }
        }
        pub fn get_IsUS0_2(this_: &MutCell<Common::US0>, unitArg: ()) -> bool {
            if unreachable!() {
                true
            } else {
                false
            }
        }
    }
    impl core::fmt::Display for Common::US0 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Copy, Debug, PartialEq, PartialOrd, Hash, Eq)]
    pub enum US1 {
        US1_0(Common::US0),
        US1_1(Common::US0),
        US1_2(Common::US0),
    }
    impl Common::US1 {
        pub fn get_IsUS1_0(this_: &MutCell<Common::US1>, unitArg: ()) -> bool {
            if unreachable!() {
                true
            } else {
                false
            }
        }
        pub fn get_IsUS1_1(this_: &MutCell<Common::US1>, unitArg: ()) -> bool {
            if unreachable!() {
                true
            } else {
                false
            }
        }
        pub fn get_IsUS1_2(this_: &MutCell<Common::US1>, unitArg: ()) -> bool {
            if unreachable!() {
                true
            } else {
                false
            }
        }
    }
    impl core::fmt::Display for Common::US1 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Copy, Debug, PartialEq, PartialOrd, Hash, Eq)]
    pub enum US2 {
        US2_0,
        US2_1,
    }
    impl Common::US2 {
        pub fn get_IsUS2_0(this_: &MutCell<Common::US2>, unitArg: ()) -> bool {
            if unreachable!() {
                true
            } else {
                false
            }
        }
        pub fn get_IsUS2_1(this_: &MutCell<Common::US2>, unitArg: ()) -> bool {
            if unreachable!() {
                true
            } else {
                false
            }
        }
    }
    impl core::fmt::Display for Common::US2 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Copy, Debug, PartialEq, PartialOrd, Hash, Eq)]
    pub enum US3 {
        US3_0(Common::US2),
        US3_1,
    }
    impl Common::US3 {
        pub fn get_IsUS3_0(this_: &MutCell<Common::US3>, unitArg: ()) -> bool {
            if unreachable!() {
                true
            } else {
                false
            }
        }
        pub fn get_IsUS3_1(this_: &MutCell<Common::US3>, unitArg: ()) -> bool {
            if unreachable!() {
                true
            } else {
                false
            }
        }
    }
    impl core::fmt::Display for Common::US3 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    pub fn closure0(unitVar: (), v0_1: Func0<()>) -> LrcPtr<dyn IDisposable> {
        let _v1: MutCell<Option<LrcPtr<dyn IDisposable>>> =
            MutCell::new(None::<LrcPtr<dyn IDisposable>>);
        {
            let x: LrcPtr<dyn IDisposable> = panic!(
                "{}",
                sprintf!(
                    "new_disposable / target: {}",
                    Common::US1::US1_0(Common::US0::US0_1)
                ),
            );
            _v1.set(Some(x))
        }
        getValue(_v1.get().clone())
    }
    pub fn closure3(v0_1: i32, v1_1: Func0<()>, v2: i32, unitVar: ()) -> Common::US2 {
        if v2 < v0_1 {
            v1_1();
            Common::US2::US2_0
        } else {
            Common::US2::US2_1
        }
    }
    pub fn closure4(unitVar: (), v0_1: Common::US2) -> Common::US3 {
        Common::US3::US3_0(v0_1)
    }
    pub fn closure5(unitVar: (), v0_1: LrcPtr<Exception>) {
        let _v1: MutCell<Option<()>> = MutCell::new(None::<()>);
        _v1.set(Some(()));
        getValue(_v1.get().clone());
        ()
    }
    pub fn method0(v0_1: i32, v1_1: Func0<()>, v2: i32) -> Common::US2 {
        let v0_1: MutCell<i32> = MutCell::new(v0_1);
        let v1_1 = MutCell::new(v1_1.clone());
        let v2: MutCell<i32> = MutCell::new(v2);
        '_method0: loop {
            break '_method0 ({
                let v7: Common::US3 = try_catch(
                    || {
                        Common::closure4(
                            (),
                            Common::closure3(
                                v0_1.get().clone(),
                                v1_1.get().clone(),
                                v2.get().clone(),
                                (),
                            ),
                        )
                    },
                    |ex: LrcPtr<Exception>| {
                        Common::closure5((), ex.clone());
                        Common::US3::US3_1
                    },
                );
                match &v7 {
                    Common::US3::US3_0(v7_0_0) => match &v7 {
                        Common::US3::US3_0(x) => x.clone(),
                        _ => unreachable!(),
                    },
                    _ => {
                        let v0_1_temp: i32 = v0_1.get().clone();
                        let v1_1_temp = v1_1.get().clone();
                        let v2_temp: i32 = v2.get().clone() + 1_i32;
                        v0_1.set(v0_1_temp);
                        v1_1.set(v1_1_temp);
                        v2.set(v2_temp);
                        continue '_method0;
                    }
                }
            });
        }
    }
    pub fn closure2(v0_1: i32, v1_1: Func0<()>) -> Option<()> {
        let v3: Common::US2 = Common::method0(v0_1, v1_1, 0_i32);
        match &v3 {
            Common::US2::US2_0 => Some(()),
            _ => None::<()>,
        }
    }
    pub fn closure1(unitVar: (), v0_1: i32) -> Func1<Func0<()>, Option<()>> {
        Func1::new({
            let v0_1 = v0_1.clone();
            move |v: Func0<()>| Common::closure2(v0_1, v)
        })
    }
    pub fn v0() -> Func1<Func0<()>, LrcPtr<dyn IDisposable>> {
        static v0: OnceInit<Func1<Func0<()>, LrcPtr<dyn IDisposable>>> = OnceInit::new();
        v0.get_or_insert_with(|| Func1::new(move |v: Func0<()>| Common::closure0((), v)))
            .clone()
    }
    pub fn new_disposable(x: Func0<()>) -> LrcPtr<dyn IDisposable> {
        (Common::v0())(x)
    }
    pub fn v1() -> Func1<i32, Func1<Func0<()>, Option<()>>> {
        static v1: OnceInit<Func1<i32, Func1<Func0<()>, Option<()>>>> = OnceInit::new();
        v1.get_or_insert_with(|| Func1::new(move |v: i32| Common::closure1((), v)))
            .clone()
    }
    pub fn retry_fn(x: i32) -> Func1<Func0<()>, Option<()>> {
        (Common::v1())(x)
    }
    on_startup!((),);
}
