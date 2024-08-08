pub mod Networking {
    use super::*;
    type Async<T> = T;
    use fable_library_rust::Native_::Any;
    use fable_library_rust::Native_::Arc;
    use fable_library_rust::Native_::Func1;
    use fable_library_rust::Native_::LrcPtr;
    use fable_library_rust::Native_::MutCell;
    use fable_library_rust::Native_::OnceInit;
    use fable_library_rust::Native_::defaultOf;
    use fable_library_rust::Native_::on_startup;
    use fable_library_rust::String_::string;
    use fable_library_rust::System::Exception;
    pub mod State {
        use super::*;
        pub fn trace_state()
         ->
             LrcPtr<MutCell<Option<(LrcPtr<Networking::Mut0>,
                                    LrcPtr<Networking::Mut1>,
                                    LrcPtr<Networking::Mut2>,
                                    LrcPtr<Networking::Mut3>,
                                    Option<i64>)>>> {
            static trace_state:
             OnceInit<LrcPtr<MutCell<Option<(LrcPtr<Networking::Mut0>,
                                             LrcPtr<Networking::Mut1>,
                                             LrcPtr<Networking::Mut2>,
                                             LrcPtr<Networking::Mut3>,
                                             Option<i64>)>>>> =
                OnceInit::new();
            trace_state.get_or_init(||
                                        LrcPtr::new(MutCell::new(None::<(LrcPtr<Networking::Mut0>,
                                                                         LrcPtr<Networking::Mut1>,
                                                                         LrcPtr<Networking::Mut2>,
                                                                         LrcPtr<Networking::Mut3>,
                                                                         Option<i64>)>))).clone()
        }
    }
    pub trait IOsEnviron {
        fn environ(&self)
        -> LrcPtr<dyn Any>;
    }
    impl <V: IOsEnviron + Clone + 'static> IOsEnviron for LrcPtr<V> {
        #[inline]
        fn environ(&self) -> LrcPtr<dyn Any> { (**self).environ() }
    }
    #[derive(Clone, Copy, Debug, PartialEq, PartialOrd, Hash, Eq,)]
    pub enum US0 { US0_0, US0_1, US0_2, US0_3, US0_4, }
    impl core::fmt::Display for Networking::US0 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Debug, Default, PartialEq, PartialOrd, Hash, Eq,)]
    pub struct Mut0 {
        pub l0: MutCell<i64>,
    }
    impl core::fmt::Display for Networking::Mut0 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Debug,)]
    pub struct Mut1 {
        pub l0: MutCell<Func1<string, ()>>,
    }
    impl core::fmt::Display for Networking::Mut1 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Debug, Default, PartialEq, PartialOrd, Hash, Eq,)]
    pub struct Mut2 {
        pub l0: MutCell<bool>,
    }
    impl core::fmt::Display for Networking::Mut2 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Debug, PartialEq, PartialOrd, Hash, Eq,)]
    pub struct Mut3 {
        pub l0: MutCell<Networking::US0>,
    }
    impl core::fmt::Display for Networking::Mut3 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Debug, PartialEq, PartialOrd, Hash, Eq,)]
    pub enum US1 { US1_0(string), US1_1, }
    impl core::fmt::Display for Networking::US1 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Copy, Debug, PartialEq, PartialOrd, Hash, Eq,)]
    pub enum US2 { US2_0(Networking::US0), US2_1, }
    impl core::fmt::Display for Networking::US2 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Copy, Debug, PartialEq, PartialOrd, Hash, Eq,)]
    pub enum US3 { US3_0(i64), US3_1, }
    impl core::fmt::Display for Networking::US3 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Debug, Default, PartialEq, PartialOrd, Hash, Eq,)]
    pub struct Mut4 {
        pub l0: MutCell<string>,
    }
    impl core::fmt::Display for Networking::Mut4 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Copy, Debug, PartialEq, PartialOrd, Hash, Eq,)]
    pub enum US4 { US4_0(bool), US4_1, }
    impl core::fmt::Display for Networking::US4 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Debug,)]
    pub enum US5 { US5_0(bool), US5_1(LrcPtr<Exception>), }
    impl core::fmt::Display for Networking::US5 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Debug,)]
    pub enum US6 { US6_0(bool), US6_1(LrcPtr<Exception>), }
    impl core::fmt::Display for Networking::US6 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Copy, Debug, PartialEq, PartialOrd, Hash, Eq,)]
    pub enum US7 { US7_0(i32), US7_1, }
    impl core::fmt::Display for Networking::US7 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    pub fn method1() -> string { string("TRACE_LEVEL") }
    pub fn method3() -> string { string("") }
    pub fn method2(v0_1: string) -> string {
        let v33: Result<std::string::String, std::env::VarError> =
            std::env::var(&*v0_1);
        let v35: bool = true; let _result = v33.map(|x| { //;
        let v37: std::string::String = x;
        let v39: string = fable_library_rust::String_::fromString(v37);
        let v41: bool = true; v39 });
        let v43: Result<string, std::env::VarError> = _result;
        let v44: string = Networking::method3();
        v43.unwrap_or(v44)
    }
    pub fn method4() -> string { string("AUTOMATION") }
    pub fn closure0(unitVar: (), v0_1: string) { (); }
    pub fn method0(v0_1: Networking::US0)
     ->
         (LrcPtr<Networking::Mut0>, LrcPtr<Networking::Mut1>,
          LrcPtr<Networking::Mut2>, LrcPtr<Networking::Mut3>, Option<i64>) {
        let v79: string = string("env!(\"AUTOMATION\")");
        let v80: &str = env!("AUTOMATION");
        let v82: std::string::String = String::from(v80);
        let _v1: (Networking::US2, Networking::US3) =
            (Networking::US2::US2_1,
             if fable_library_rust::String_::fromString(v82) != string("True")
                {
                 Networking::US3::US3_1
             } else {
                 Networking::US3::US3_0(near_sdk::env::block_timestamp() as
                                            i64)
             });
        let v295: Networking::US3 = _v1.1.clone();
        let v294: Networking::US2 = _v1.0.clone();
        (LrcPtr::new(Networking::Mut0{l0: MutCell::new(0_i64),}),
         LrcPtr::new(Networking::Mut1{l0:
                                          MutCell::new(Func1::new(move
                                                                      |v:
                                                                           string|
                                                                      Networking::closure0((),
                                                                                           v))),}),
         LrcPtr::new(Networking::Mut2{l0: MutCell::new(true),}),
         LrcPtr::new(Networking::Mut3{l0:
                                          MutCell::new(match &v294 {
                                                           Networking::US2::US2_0(v294_0_0)
                                                           =>
                                                           match &v294 {
                                                               Networking::US2::US2_0(x)
                                                               => x.clone(),
                                                               _ =>
                                                               unreachable!(),
                                                           },
                                                           _ => v0_1,
                                                       }),}),
         match &v295 {
             Networking::US3::US3_0(v295_0_0) =>
             Some(match &v295 {
                      Networking::US3::US3_0(x) => x.clone(),
                      _ => unreachable!(),
                  }),
             _ => None::<i64>,
         })
    }
    pub fn method5() -> string { string("hh:mm:ss") }
    pub fn method6() -> string { string("HH:mm:ss") }
    pub fn method7() -> string { string("\u{001b}[0m") }
    pub fn method8() -> string { string("") }
    pub fn closure3(unitVar: (), unitVar_1: ()) -> string {
        string("networking.test_port_open")
    }
    pub fn closure2(v0_1: string, v1: i32) -> Arc<Async<bool>> { defaultOf() }
    pub fn closure1(unitVar: (), v0_1: string)
     -> Func1<i32, Arc<Async<bool>>> {
        Func1::new({
                       let v0_1 = v0_1.clone();
                       move |v: i32| Networking::closure2(v0_1.clone(), v)
                   })
    }
    pub fn closure7(unitVar: (), v0_1: bool) -> Networking::US5 {
        Networking::US5::US5_0(v0_1)
    }
    pub fn closure8(unitVar: (), v0_1: LrcPtr<Exception>) -> Networking::US5 {
        Networking::US5::US5_1(v0_1)
    }
    pub fn closure9(unitVar: (), unitVar_1: ()) -> string {
        string("async.run_with_timeout_async")
    }
    pub fn closure10(unitVar: (), unitVar_1: ()) -> string {
        string("async.run_with_timeout_async**")
    }
    pub fn closure6(v0_1: i32, v1: string, v2: i32) -> Arc<Async<bool>> {
        defaultOf()
    }
    pub fn closure5(v0_1: i32, v1: string) -> Func1<i32, Arc<Async<bool>>> {
        Func1::new({
                       let v0_1 = v0_1.clone();
                       let v1 = v1.clone();
                       move |v: i32| Networking::closure6(v0_1, v1.clone(), v)
                   })
    }
    pub fn closure4(unitVar: (), v0_1: i32)
     -> Func1<string, Func1<i32, Arc<Async<bool>>>> {
        Func1::new({
                       let v0_1 = v0_1.clone();
                       move |v: string| Networking::closure5(v0_1, v)
                   })
    }
    pub fn closure15(unitVar: (), unitVar_1: ()) -> string {
        string("networking.wait_for_port_access")
    }
    pub fn method9(v0_1: Option<i32>, v1: bool, v2: string, v3: i32, v4: i64)
     -> Arc<Async<i64>> {
        defaultOf()
    }
    pub fn closure14(v0_1: Option<i32>, v1: bool, v2: string, v3: i32)
     -> Arc<Async<i64>> {
        Networking::method9(v0_1, v1, v2, v3, 0_i64)
    }
    pub fn closure13(v0_1: Option<i32>, v1: bool, v2: string)
     -> Func1<i32, Arc<Async<i64>>> {
        Func1::new({
                       let v0_1 = v0_1.clone();
                       let v1 = v1.clone();
                       let v2 = v2.clone();
                       move |v: i32|
                           Networking::closure14(v0_1.clone(), v1, v2.clone(),
                                                 v)
                   })
    }
    pub fn closure12(v0_1: Option<i32>, v1: bool)
     -> Func1<string, Func1<i32, Arc<Async<i64>>>> {
        Func1::new({
                       let v0_1 = v0_1.clone();
                       let v1 = v1.clone();
                       move |v: string|
                           Networking::closure13(v0_1.clone(), v1, v)
                   })
    }
    pub fn closure11(unitVar: (), v0_1: Option<i32>)
     -> Func1<bool, Func1<string, Func1<i32, Arc<Async<i64>>>>> {
        Func1::new({
                       let v0_1 = v0_1.clone();
                       move |v: bool| Networking::closure12(v0_1.clone(), v)
                   })
    }
    pub fn method10(v0_1: Option<i32>, v1: string, v2: i32)
     -> Arc<Async<i32>> {
        defaultOf()
    }
    pub fn closure18(v0_1: Option<i32>, v1: string, v2: i32)
     -> Arc<Async<i32>> {
        Networking::method10(v0_1, v1, v2)
    }
    pub fn closure17(v0_1: Option<i32>, v1: string)
     -> Func1<i32, Arc<Async<i32>>> {
        Func1::new({
                       let v0_1 = v0_1.clone();
                       let v1 = v1.clone();
                       move |v: i32|
                           Networking::closure18(v0_1.clone(), v1.clone(), v)
                   })
    }
    pub fn closure16(unitVar: (), v0_1: Option<i32>)
     -> Func1<string, Func1<i32, Arc<Async<i32>>>> {
        Func1::new({
                       let v0_1 = v0_1.clone();
                       move |v: string| Networking::closure17(v0_1.clone(), v)
                   })
    }
    pub fn v0() -> bool {
        static v0: OnceInit<bool> = OnceInit::new();
        v0.get_or_init(||
                           Networking::State::trace_state().get().clone().is_none()).clone()
    }
    on_startup!(if Networking::v0() {
    let patternInput:
            (LrcPtr<Networking::Mut0>, LrcPtr<Networking::Mut1>,
             LrcPtr<Networking::Mut2>, LrcPtr<Networking::Mut3>,
             Option<i64>) = Networking::method0(Networking::US0::US0_0);
    Networking::State::trace_state().set(Some((patternInput.0.clone(),
                                               patternInput.1.clone(),
                                               patternInput.2.clone(),
                                               patternInput.3.clone(),
                                               patternInput.4.clone())));
    ()
});
    pub fn v12() -> Func1<string, Func1<i32, Arc<Async<bool>>>> {
        static v12: OnceInit<Func1<string, Func1<i32, Arc<Async<bool>>>>> =
            OnceInit::new();
        v12.get_or_init(||
                            Func1::new(move |v: string|
                                           Networking::closure1((),
                                                                v))).clone()
    }
    pub fn test_port_open(x: string) -> Func1<i32, Arc<Async<bool>>> {
        (Networking::v12())(x)
    }
    pub fn v13() -> Func1<i32, Func1<string, Func1<i32, Arc<Async<bool>>>>> {
        static v13:
         OnceInit<Func1<i32, Func1<string, Func1<i32, Arc<Async<bool>>>>>> =
            OnceInit::new();
        v13.get_or_init(||
                            Func1::new(move |v: i32|
                                           Networking::closure4((),
                                                                v))).clone()
    }
    pub fn test_port_open_timeout(x: i32)
     -> Func1<string, Func1<i32, Arc<Async<bool>>>> {
        (Networking::v13())(x)
    }
    pub fn v14()
     ->
         Func1<Option<i32>,
               Func1<bool, Func1<string, Func1<i32, Arc<Async<i64>>>>>> {
        static v14:
         OnceInit<Func1<Option<i32>,
                        Func1<bool,
                              Func1<string, Func1<i32, Arc<Async<i64>>>>>>> =
            OnceInit::new();
        v14.get_or_init(||
                            Func1::new(move |v: Option<i32>|
                                           Networking::closure11((),
                                                                 v))).clone()
    }
    pub fn wait_for_port_access(x: Option<i32>)
     -> Func1<bool, Func1<string, Func1<i32, Arc<Async<i64>>>>> {
        (Networking::v14())(x)
    }
    pub fn v15()
     -> Func1<Option<i32>, Func1<string, Func1<i32, Arc<Async<i32>>>>> {
        static v15:
         OnceInit<Func1<Option<i32>,
                        Func1<string, Func1<i32, Arc<Async<i32>>>>>> =
            OnceInit::new();
        v15.get_or_init(||
                            Func1::new(move |v: Option<i32>|
                                           Networking::closure16((),
                                                                 v))).clone()
    }
    pub fn get_available_port(x: Option<i32>)
     -> Func1<string, Func1<i32, Arc<Async<i32>>>> {
        (Networking::v15())(x)
    }
    on_startup!(());
}
