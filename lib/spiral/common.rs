pub mod Common {
    use super::*;
    use fable_library_rust::Exception_::try_catch;
    use fable_library_rust::Interfaces_::System::IDisposable;
    use fable_library_rust::Native_::interface_cast;
    use fable_library_rust::Native_::on_startup;
    use fable_library_rust::Native_::Func0;
    use fable_library_rust::Native_::Func1;
    use fable_library_rust::Native_::Lrc;
    use fable_library_rust::Native_::LrcPtr;
    use fable_library_rust::Native_::MutCell;
    use fable_library_rust::Native_::OnceInit;
    use fable_library_rust::Option_::getValue;
    use fable_library_rust::System::Exception;
    #[derive(Clone, Copy, Debug, PartialEq, PartialOrd, Hash, Eq)]
    pub enum US0 {
        US0_0,
        US0_1,
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
    }
    impl core::fmt::Display for Common::US0 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Copy, Debug, PartialEq, PartialOrd, Hash, Eq)]
    pub enum US1 {
        US1_0,
        US1_1(Common::US0),
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
    }
    impl core::fmt::Display for Common::US1 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    pub fn method0(v0_1: Func0<()>) -> Func0<()> {
        v0_1
    }
    pub fn closure0(unitVar: (), v0_1: Func0<()>) -> LrcPtr<dyn IDisposable> {
        let result: MutCell<Option<LrcPtr<dyn IDisposable>>> =
            MutCell::new(None::<LrcPtr<dyn IDisposable>>);
        let v1_1 = Common::method0(v0_1);
        {
            let x: LrcPtr<dyn IDisposable> = {
                struct ObjectExpr {}
                impl IDisposable for ObjectExpr {
                    fn Dispose(&self) {
                        v1();
                    }
                }
                interface_cast!(LrcPtr::new(ObjectExpr {}), Lrc<dyn IDisposable>,)
            };
            result.set(Some(x))
        }
        getValue(result.get().clone())
    }
    pub fn closure3(v0_1: i32, v1_1: Func0<()>, v2: i32, unitVar: ()) -> Common::US0 {
        if v2 < v0_1 {
            v1_1();
            Common::US0::US0_1
        } else {
            Common::US0::US0_0
        }
    }
    pub fn closure4(unitVar: (), v0_1: Common::US0) -> Common::US1 {
        Common::US1::US1_1(v0_1)
    }
    pub fn closure5(unitVar: (), v0_1: LrcPtr<Exception>) {
        let result: MutCell<Option<()>> = MutCell::new(None::<()>);
        result.set(Some(()));
        getValue(result.get().clone());
        ()
    }
    pub fn method1(v0_1: i32, v1_1: Func0<()>, v2: i32) -> Common::US0 {
        let v0_1: MutCell<i32> = MutCell::new(v0_1);
        let v1_1 = MutCell::new(v1_1.clone());
        let v2: MutCell<i32> = MutCell::new(v2);
        '_method1: loop {
            break '_method1 ({
                let v7: Common::US1 = try_catch(
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
                        Common::US1::US1_0
                    },
                );
                match &v7 {
                    Common::US1::US1_1(v7_1_0) => v7_1_0.clone(),
                    _ => {
                        let v0_1_temp: i32 = v0_1.get().clone();
                        let v1_1_temp = v1_1.get().clone();
                        let v2_temp: i32 = v2.get().clone() + 1_i32;
                        v0_1.set(v0_1_temp);
                        v1_1.set(v1_1_temp);
                        v2.set(v2_temp);
                        continue '_method1;
                    }
                }
            });
        }
    }
    pub fn closure2(v0_1: i32, v1_1: Func0<()>) -> Option<()> {
        let v3: Common::US0 = Common::method1(v0_1, v1_1, 0_i32);
        match &v3 {
            Common::US0::US0_1 => Some(()),
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
