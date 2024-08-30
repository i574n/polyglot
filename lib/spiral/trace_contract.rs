pub mod Trace {
    use super::*;
    use fable_library_rust::Interfaces_::System::Collections::Generic::IEnumerable_1;
    use fable_library_rust::List_::empty;
    use fable_library_rust::List_::ofArray;
    use fable_library_rust::List_::toArray;
    use fable_library_rust::Map_::find;
    use fable_library_rust::Map_::ofSeq;
    use fable_library_rust::Native_::Any;
    use fable_library_rust::Native_::Func0;
    use fable_library_rust::Native_::Func1;
    use fable_library_rust::Native_::LrcPtr;
    use fable_library_rust::Native_::MutCell;
    use fable_library_rust::Native_::OnceInit;
    use fable_library_rust::Native_::on_startup;
    use fable_library_rust::Native_::refCell;
    use fable_library_rust::NativeArray_::Array;
    use fable_library_rust::NativeArray_::new_array;
    use fable_library_rust::Option_::defaultValue;
    use fable_library_rust::Option_::getValue;
    use fable_library_rust::Seq_::ofList;
    use fable_library_rust::String_::append;
    use fable_library_rust::String_::padLeft;
    use fable_library_rust::String_::printfn;
    use fable_library_rust::String_::split;
    use fable_library_rust::String_::sprintf;
    use fable_library_rust::String_::startsWith;
    use fable_library_rust::String_::string;
    use fable_library_rust::String_::toLower;
    use fable_library_rust::String_::trimEndChars;
    use fable_library_rust::String_::trimStartChars;
    pub mod State {
        use super::*;
        pub fn trace_state()
         ->
             LrcPtr<MutCell<Option<(LrcPtr<Trace::Mut0>, LrcPtr<Trace::Mut1>,
                                    LrcPtr<Trace::Mut2>, LrcPtr<Trace::Mut3>,
                                    Option<i64>)>>> {
            static trace_state:
             OnceInit<LrcPtr<MutCell<Option<(LrcPtr<Trace::Mut0>,
                                             LrcPtr<Trace::Mut1>,
                                             LrcPtr<Trace::Mut2>,
                                             LrcPtr<Trace::Mut3>,
                                             Option<i64>)>>>> =
                OnceInit::new();
            trace_state.get_or_init(||
                                        LrcPtr::new(MutCell::new(None::<(LrcPtr<Trace::Mut0>,
                                                                         LrcPtr<Trace::Mut1>,
                                                                         LrcPtr<Trace::Mut2>,
                                                                         LrcPtr<Trace::Mut3>,
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
    impl core::fmt::Display for Trace::US0 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Debug, Default, PartialEq, PartialOrd, Hash, Eq,)]
    pub struct Mut0 {
        pub l0: MutCell<i64>,
    }
    impl core::fmt::Display for Trace::Mut0 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Debug,)]
    pub struct Mut1 {
        pub l0: MutCell<Func1<string, ()>>,
    }
    impl core::fmt::Display for Trace::Mut1 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Debug, Default, PartialEq, PartialOrd, Hash, Eq,)]
    pub struct Mut2 {
        pub l0: MutCell<bool>,
    }
    impl core::fmt::Display for Trace::Mut2 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Debug, PartialEq, PartialOrd, Hash, Eq,)]
    pub struct Mut3 {
        pub l0: MutCell<Trace::US0>,
    }
    impl core::fmt::Display for Trace::Mut3 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Debug, PartialEq, PartialOrd, Hash, Eq,)]
    pub enum US1 { US1_0(string), US1_1, }
    impl core::fmt::Display for Trace::US1 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Copy, Debug, PartialEq, PartialOrd, Hash, Eq,)]
    pub enum US2 { US2_0(Trace::US0), US2_1, }
    impl core::fmt::Display for Trace::US2 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Copy, Debug, PartialEq, PartialOrd, Hash, Eq,)]
    pub enum US3 { US3_0(i64), US3_1, }
    impl core::fmt::Display for Trace::US3 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Debug, Default, PartialEq, PartialOrd, Hash, Eq,)]
    pub struct Mut4 {
        pub l0: MutCell<string>,
    }
    impl core::fmt::Display for Trace::Mut4 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    pub fn method1() -> string { string("TRACE_LEVEL") }
    pub fn method3() -> string { string("") }
    pub fn closure1(v0_1: LrcPtr<MutCell<Option<Trace::US1>>>,
                    v1_1: Option<Trace::US1>)
     -> LrcPtr<MutCell<Option<Trace::US1>>> {
        v0_1.set(v1_1);
        v0_1
    }
    pub fn closure2(v0_1: Option<string>,
                    v1_1:
                        Func1<Option<Trace::US1>,
                              LrcPtr<MutCell<Option<Trace::US1>>>>,
                    unitVar: ()) {
        {
            let value: LrcPtr<MutCell<Option<Trace::US1>>> =
                v1_1(match &v0_1 {
                         None => None::<Trace::US1>,
                         Some(v0_1_0_0) => {
                             let x: string = v0_1_0_0.clone();
                             Some((Func0::new({
                                                  let x = x.clone();
                                                  move ||
                                                      Trace::US1::US1_0(x.clone())
                                              }))())
                         }
                     });
            ()
        }
        ()
    }
    pub fn method2(v0_1: string) -> string {
        let v33: Result<std::string::String, std::env::VarError> =
            std::env::var(&*v0_1);
        let v35: bool = true; let _result_map_ = v33.map(|x| { //;
        let v37: std::string::String = x;
        let v39: string = fable_library_rust::String_::fromString(v37);
        let v41: bool = true; v39 });
        let v43: Result<string, std::env::VarError> = _result_map_;
        let v44: string = Trace::method3();
        v43.unwrap_or(v44)
    }
    pub fn method4() -> string { string("AUTOMATION") }
    pub fn closure3(unitVar: (), v0_1: string) { (); }
    pub fn method0(v0_1: Trace::US0)
     ->
         (LrcPtr<Trace::Mut0>, LrcPtr<Trace::Mut1>, LrcPtr<Trace::Mut2>,
          LrcPtr<Trace::Mut3>, Option<i64>) {
        let v79: string = string("env!(\"AUTOMATION\")");
        let v80: &str = env!("AUTOMATION");
        let v82: std::string::String = String::from(v80);
        let _v1: (Trace::US2, Trace::US3) =
            (Trace::US2::US2_1,
             if fable_library_rust::String_::fromString(v82) != string("True")
                {
                 Trace::US3::US3_1
             } else {
                 Trace::US3::US3_0(near_sdk::env::block_timestamp() as i64)
             });
        let v295: Trace::US3 = _v1.1.clone();
        let v294: Trace::US2 = _v1.0.clone();
        (LrcPtr::new(Trace::Mut0{l0: MutCell::new(0_i64),}),
         LrcPtr::new(Trace::Mut1{l0:
                                     MutCell::new(Func1::new(move |v: string|
                                                                 Trace::closure3((),
                                                                                 v))),}),
         LrcPtr::new(Trace::Mut2{l0: MutCell::new(true),}),
         LrcPtr::new(Trace::Mut3{l0:
                                     MutCell::new(match &v294 {
                                                      Trace::US2::US2_0(v294_0_0)
                                                      =>
                                                      match &v294 {
                                                          Trace::US2::US2_0(x)
                                                          => x.clone(),
                                                          _ => unreachable!(),
                                                      },
                                                      _ => v0_1,
                                                  }),}),
         match &v295 {
             Trace::US3::US3_0(v295_0_0) =>
             Some(match &v295 {
                      Trace::US3::US3_0(x) => x.clone(),
                      _ => unreachable!(),
                  }),
             _ => None::<i64>,
         })
    }
    pub fn closure0(unitVar: (), unitVar_1: ()) {
        if Trace::State::trace_state().get().clone().is_none() {
            let patternInput:
                    (LrcPtr<Trace::Mut0>, LrcPtr<Trace::Mut1>,
                     LrcPtr<Trace::Mut2>, LrcPtr<Trace::Mut3>, Option<i64>) =
                Trace::method0(Trace::US0::US0_0);
            Trace::State::trace_state().set(Some((patternInput.0.clone(),
                                                  patternInput.1.clone(),
                                                  patternInput.2.clone(),
                                                  patternInput.3.clone(),
                                                  patternInput.4.clone())));
            ()
        };
    }
    pub fn closure8(v0_1: LrcPtr<Trace::Mut0>, unitVar: ()) {
        let v2_1: i64 = v0_1.l0.get().clone() + 1_i64;
        v0_1.l0.set(v2_1);
        ()
    }
    pub fn closure9(v0_1: LrcPtr<MutCell<Option<Trace::US3>>>,
                    v1_1: Option<Trace::US3>)
     -> LrcPtr<MutCell<Option<Trace::US3>>> {
        v0_1.set(v1_1);
        v0_1
    }
    pub fn closure10(v0_1: Option<i64>,
                     v1_1:
                         Func1<Option<Trace::US3>,
                               LrcPtr<MutCell<Option<Trace::US3>>>>,
                     unitVar: ()) {
        {
            let value: LrcPtr<MutCell<Option<Trace::US3>>> =
                v1_1(match &v0_1 {
                         None => None::<Trace::US3>,
                         Some(v0_1_0_0) => {
                             let x: i64 = v0_1_0_0.clone();
                             Some((Func0::new({
                                                  let x = x.clone();
                                                  move || Trace::US3::US3_0(x)
                                              }))())
                         }
                     });
            ()
        }
        ()
    }
    pub fn method5() -> string { string("hh:mm:ss") }
    pub fn method6() -> string { string("HH:mm:ss") }
    pub fn method7() -> string { string("(") }
    pub fn method8() -> string { string(" ") }
    pub fn method9() -> string { string("") }
    pub fn closure11(v0_1: LrcPtr<Trace::Mut4>, v1_1: string, unitVar: ()) {
        let v3: string = append(v0_1.l0.get().clone(), v1_1);
        v0_1.l0.set(v3);
        ()
    }
    pub fn method10() -> string { string("\u{001b}[0m") }
    pub fn closure13(v0_1: string, unitVar: ()) { printfn!("{0}", v0_1); }
    pub fn closure12(unitVar: (), v0_1: string) {
        let v3: () = { Trace::closure13(v0_1, ()); () };
        ()
    }
    pub fn closure7(v0_1: Trace::US0, v1_1: Func0<string>,
                    v2_1: Func0<string>, unitVar: ()) {
        fn v4() { Trace::closure0((), ()); }
        let v5: () = { v4(); () };
        let patternInput:
                (LrcPtr<Trace::Mut0>, LrcPtr<Trace::Mut1>,
                 LrcPtr<Trace::Mut2>, LrcPtr<Trace::Mut3>, Option<i64>) =
            getValue(Trace::State::trace_state().get().clone());
        let v34: () = { v4(); () };
        let patternInput_1:
                (LrcPtr<Trace::Mut0>, LrcPtr<Trace::Mut1>,
                 LrcPtr<Trace::Mut2>, LrcPtr<Trace::Mut3>, Option<i64>) =
            getValue(Trace::State::trace_state().get().clone());
        let v62: Trace::US0 = (patternInput_1.3.clone()).l0.get().clone();
        if if (patternInput_1.2.clone()).l0.get().clone() == false {
               false
           } else {
               find(v0_1.clone(),
                    ofSeq(ofList(ofArray(new_array(&[LrcPtr::new((Trace::US0::US0_0,
                                                                  0_i32)),
                                                     LrcPtr::new((Trace::US0::US0_1,
                                                                  1_i32)),
                                                     LrcPtr::new((Trace::US0::US0_2,
                                                                  2_i32)),
                                                     LrcPtr::new((Trace::US0::US0_3,
                                                                  3_i32)),
                                                     LrcPtr::new((Trace::US0::US0_4,
                                                                  4_i32))])))))
                   >=
                   find(v62,
                        ofSeq(ofList(ofArray(new_array(&[LrcPtr::new((Trace::US0::US0_0,
                                                                      0_i32)),
                                                         LrcPtr::new((Trace::US0::US0_1,
                                                                      1_i32)),
                                                         LrcPtr::new((Trace::US0::US0_2,
                                                                      2_i32)),
                                                         LrcPtr::new((Trace::US0::US0_3,
                                                                      3_i32)),
                                                         LrcPtr::new((Trace::US0::US0_4,
                                                                      4_i32))])))))
           } {
            let v71: () = { Trace::closure8(patternInput.0.clone(), ()); () };
            let v75: () = { v4(); () };
            let patternInput_2:
                    (LrcPtr<Trace::Mut0>, LrcPtr<Trace::Mut1>,
                     LrcPtr<Trace::Mut2>, LrcPtr<Trace::Mut3>, Option<i64>) =
                getValue(Trace::State::trace_state().get().clone());
            let v241: u64 = near_sdk::env::block_timestamp();
            let _v242: LrcPtr<MutCell<Option<Trace::US3>>> =
                refCell(None::<Trace::US3>);
            let v247: () =
                {
                    Trace::closure10(patternInput_2.4.clone(),
                                     Func1::new({
                                                    let _v242 = _v242.clone();
                                                    move
                                                        |v:
                                                             Option<Trace::US3>|
                                                        Trace::closure9(_v242.clone(),
                                                                        v)
                                                }), ());
                    ()
                };
            let v262: Trace::US3 =
                defaultValue(Trace::US3::US3_1, _v242.get().clone());
            let v272: u64 =
                match &v262 {
                    Trace::US3::US3_0(v262_0_0) =>
                    v241 -
                        match &v262 {
                            Trace::US3::US3_0(x) => x.clone(),
                            _ => unreachable!(),
                        } as u64,
                    _ => v241,
                } / 1000000000_u64;
            let v273: u64 = v272 % 60_u64;
            let v275: u64 = v272 / 60_u64 % 60_u64;
            let v277: u64 = v272 / 3600_u64 % 24_u64;
            let v279: std::string::String =
                format!("{:02}:{:02}:{:02}", v277, v275, v273);
            let v281: string = fable_library_rust::String_::fromString(v279);
            let v614: Trace::US1 =
                if if let Trace::US0::US0_0 = &v0_1 { true } else { false } {
                    Trace::US1::US1_0(string("Verbose"))
                } else {
                    let v562: string = Trace::method7();
                    let v572: LrcPtr<Trace::Mut4> =
                        LrcPtr::new(Trace::Mut4{l0:
                                                    MutCell::new(Trace::method9()),});
                    let v583: () =
                        {
                            Trace::closure11(v572.clone(),
                                             sprintf!("{}",
                                                      sprintf!("{:?}",
                                                               Trace::US0::US0_0)),
                                             ());
                            ()
                        };
                    let v587: Array<string> =
                        split(v572.l0.get().clone(), v562, -1_i32, 0_i32);
                    let v590: string = v587[0_i32].clone();
                    let v594: LrcPtr<Trace::Mut4> =
                        LrcPtr::new(Trace::Mut4{l0:
                                                    MutCell::new(Trace::method9()),});
                    let v603: () =
                        {
                            Trace::closure11(v594.clone(),
                                             sprintf!("{}",
                                                      sprintf!("{:?}",
                                                               v0_1.clone())),
                                             ());
                            ()
                        };
                    if startsWith(v594.l0.get().clone(), v590, false) {
                        Trace::US1::US1_0(string("Verbose"))
                    } else { Trace::US1::US1_1 }
                };
            let v871: Trace::US1 =
                match &v614 {
                    Trace::US1::US1_0(v614_0_0) =>
                    Trace::US1::US1_0(match &v614 {
                                          Trace::US1::US1_0(x) => x.clone(),
                                          _ => unreachable!(),
                                      }),
                    _ => {
                        let v675: Trace::US1 =
                            if if let Trace::US0::US0_1 = &v0_1 {
                                   true
                               } else { false } {
                                Trace::US1::US1_0(string("Debug"))
                            } else {
                                let v623: string = Trace::method7();
                                let v633: LrcPtr<Trace::Mut4> =
                                    LrcPtr::new(Trace::Mut4{l0:
                                                                MutCell::new(Trace::method9()),});
                                let v644: () =
                                    {
                                        Trace::closure11(v633.clone(),
                                                         sprintf!("{}",
                                                                  sprintf!("{:?}",
                                                                           Trace::US0::US0_1)),
                                                         ());
                                        ()
                                    };
                                let v648: Array<string> =
                                    split(v633.l0.get().clone(), v623, -1_i32,
                                          0_i32);
                                let v651: string = v648[0_i32].clone();
                                let v655: LrcPtr<Trace::Mut4> =
                                    LrcPtr::new(Trace::Mut4{l0:
                                                                MutCell::new(Trace::method9()),});
                                let v664: () =
                                    {
                                        Trace::closure11(v655.clone(),
                                                         sprintf!("{}",
                                                                  sprintf!("{:?}",
                                                                           v0_1.clone())),
                                                         ());
                                        ()
                                    };
                                if startsWith(v655.l0.get().clone(), v651,
                                              false) {
                                    Trace::US1::US1_0(string("Debug"))
                                } else { Trace::US1::US1_1 }
                            };
                        match &v675 {
                            Trace::US1::US1_0(v675_0_0) =>
                            Trace::US1::US1_0(match &v675 {
                                                  Trace::US1::US1_0(x) =>
                                                  x.clone(),
                                                  _ => unreachable!(),
                                              }),
                            _ => {
                                let v736: Trace::US1 =
                                    if if let Trace::US0::US0_2 = &v0_1 {
                                           true
                                       } else { false } {
                                        Trace::US1::US1_0(string("Info"))
                                    } else {
                                        let v684: string = Trace::method7();
                                        let v694: LrcPtr<Trace::Mut4> =
                                            LrcPtr::new(Trace::Mut4{l0:
                                                                        MutCell::new(Trace::method9()),});
                                        let v705: () =
                                            {
                                                Trace::closure11(v694.clone(),
                                                                 sprintf!("{}",
                                                                          sprintf!("{:?}",
                                                                                   Trace::US0::US0_2)),
                                                                 ());
                                                ()
                                            };
                                        let v709: Array<string> =
                                            split(v694.l0.get().clone(), v684,
                                                  -1_i32, 0_i32);
                                        let v712: string =
                                            v709[0_i32].clone();
                                        let v716: LrcPtr<Trace::Mut4> =
                                            LrcPtr::new(Trace::Mut4{l0:
                                                                        MutCell::new(Trace::method9()),});
                                        let v725: () =
                                            {
                                                Trace::closure11(v716.clone(),
                                                                 sprintf!("{}",
                                                                          sprintf!("{:?}",
                                                                                   v0_1.clone())),
                                                                 ());
                                                ()
                                            };
                                        if startsWith(v716.l0.get().clone(),
                                                      v712, false) {
                                            Trace::US1::US1_0(string("Info"))
                                        } else { Trace::US1::US1_1 }
                                    };
                                match &v736 {
                                    Trace::US1::US1_0(v736_0_0) =>
                                    Trace::US1::US1_0(match &v736 {
                                                          Trace::US1::US1_0(x)
                                                          => x.clone(),
                                                          _ => unreachable!(),
                                                      }),
                                    _ => {
                                        let v797: Trace::US1 =
                                            if if let Trace::US0::US0_3 =
                                                      &v0_1 {
                                                   true
                                               } else { false } {
                                                Trace::US1::US1_0(string("Warning"))
                                            } else {
                                                let v745: string =
                                                    Trace::method7();
                                                let v755:
                                                        LrcPtr<Trace::Mut4> =
                                                    LrcPtr::new(Trace::Mut4{l0:
                                                                                MutCell::new(Trace::method9()),});
                                                let v766: () =
                                                    {
                                                        Trace::closure11(v755.clone(),
                                                                         sprintf!("{}",
                                                                                  sprintf!("{:?}",
                                                                                           Trace::US0::US0_3)),
                                                                         ());
                                                        ()
                                                    };
                                                let v770: Array<string> =
                                                    split(v755.l0.get().clone(),
                                                          v745, -1_i32,
                                                          0_i32);
                                                let v773: string =
                                                    v770[0_i32].clone();
                                                let v777:
                                                        LrcPtr<Trace::Mut4> =
                                                    LrcPtr::new(Trace::Mut4{l0:
                                                                                MutCell::new(Trace::method9()),});
                                                let v786: () =
                                                    {
                                                        Trace::closure11(v777.clone(),
                                                                         sprintf!("{}",
                                                                                  sprintf!("{:?}",
                                                                                           v0_1.clone())),
                                                                         ());
                                                        ()
                                                    };
                                                if startsWith(v777.l0.get().clone(),
                                                              v773, false) {
                                                    Trace::US1::US1_0(string("Warning"))
                                                } else { Trace::US1::US1_1 }
                                            };
                                        match &v797 {
                                            Trace::US1::US1_0(v797_0_0) =>
                                            Trace::US1::US1_0(match &v797 {
                                                                  Trace::US1::US1_0(x)
                                                                  =>
                                                                  x.clone(),
                                                                  _ =>
                                                                  unreachable!(),
                                                              }),
                                            _ => {
                                                let v858: Trace::US1 =
                                                    if if let Trace::US0::US0_4
                                                              = &v0_1 {
                                                           true
                                                       } else { false } {
                                                        Trace::US1::US1_0(string("Critical"))
                                                    } else {
                                                        let v806: string =
                                                            Trace::method7();
                                                        let v816:
                                                                LrcPtr<Trace::Mut4> =
                                                            LrcPtr::new(Trace::Mut4{l0:
                                                                                        MutCell::new(Trace::method9()),});
                                                        let v827: () =
                                                            {
                                                                Trace::closure11(v816.clone(),
                                                                                 sprintf!("{}",
                                                                                          sprintf!("{:?}",
                                                                                                   Trace::US0::US0_4)),
                                                                                 ());
                                                                ()
                                                            };
                                                        let v831:
                                                                Array<string> =
                                                            split(v816.l0.get().clone(),
                                                                  v806,
                                                                  -1_i32,
                                                                  0_i32);
                                                        let v834: string =
                                                            v831[0_i32].clone();
                                                        let v838:
                                                                LrcPtr<Trace::Mut4> =
                                                            LrcPtr::new(Trace::Mut4{l0:
                                                                                        MutCell::new(Trace::method9()),});
                                                        let v847: () =
                                                            {
                                                                Trace::closure11(v838.clone(),
                                                                                 sprintf!("{}",
                                                                                          sprintf!("{:?}",
                                                                                                   v0_1.clone())),
                                                                                 ());
                                                                ()
                                                            };
                                                        if startsWith(v838.l0.get().clone(),
                                                                      v834,
                                                                      false) {
                                                            Trace::US1::US1_0(string("Critical"))
                                                        } else {
                                                            Trace::US1::US1_1
                                                        }
                                                    };
                                                match &v858 {
                                                    Trace::US1::US1_0(v858_0_0)
                                                    =>
                                                    Trace::US1::US1_0(match &v858
                                                                          {
                                                                          Trace::US1::US1_0(x)
                                                                          =>
                                                                          x.clone(),
                                                                          _ =>
                                                                          unreachable!(),
                                                                      }),
                                                    _ => Trace::US1::US1_1,
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                };
            let v880: string =
                padLeft(toLower(match &v871 {
                                    Trace::US1::US1_0(v871_0_0) =>
                                    match &v871 {
                                        Trace::US1::US1_0(x) => x.clone(),
                                        _ => unreachable!(),
                                    },
                                    _ =>
                                    panic!("{}",
                                           string("Option does not have a value."),),
                                }), 7_i32, ' ');
            let v957: &str =
                match &v0_1 {
                    Trace::US0::US0_1 =>
                    inline_colorization::color_bright_blue,
                    Trace::US0::US0_2 =>
                    inline_colorization::color_bright_green,
                    Trace::US0::US0_0 =>
                    inline_colorization::color_bright_black,
                    Trace::US0::US0_3 => inline_colorization::color_yellow,
                    _ => inline_colorization::color_bright_red,
                };
            let v959: &str = &*v880;
            let v961: &str = inline_colorization::color_reset;
            let v963: string = string("format!(\"{v957}{v959}{v961}\")");
            let v964: std::string::String = format!("{v957}{v959}{v961}");
            let v966: string = fable_library_rust::String_::fromString(v964);
            let v1021: i64 = (patternInput_2.0.clone()).l0.get().clone();
            let v1022: string = v2_1();
            let v1024: LrcPtr<Trace::Mut4> =
                LrcPtr::new(Trace::Mut4{l0: MutCell::new(Trace::method9()),});
            let v1030: () =
                {
                    Trace::closure11(v1024.clone(), sprintf!("{}", v1022),
                                     ());
                    ()
                };
            let v1033: string = v1024.l0.get().clone();
            let v1071: string =
                trimEndChars(trimStartChars(sprintf!("{} {} #{} {} / {}",
                                                     v281, v966, v1021,
                                                     v1_1(), v1033),
                                            toArray(empty::<char>())),
                             toArray(ofArray(new_array(&[' ', '/']))));
            near_sdk::log!("{}", v1071.clone());
            ();
            ((patternInput.1.clone()).l0.get().clone())(v1071)
        }
    }
    pub fn closure6(v0_1: Trace::US0, v1_1: Func0<string>,
                    v2_1: Func0<string>) {
        let v5: () = { Trace::closure7(v0_1, v1_1, v2_1, ()); () };
        ()
    }
    pub fn closure5(v0_1: Trace::US0, v1_1: Func0<string>)
     -> Func1<Func0<string>, ()> {
        Func1::new({
                       let v0_1 = v0_1.clone();
                       let v1_1 = v1_1.clone();
                       move |v: Func0<string>|
                           Trace::closure6(v0_1.clone(), v1_1.clone(), v)
                   })
    }
    pub fn closure4(unitVar: (), v0_1: Trace::US0)
     -> Func1<Func0<string>, Func1<Func0<string>, ()>> {
        Func1::new({
                       let v0_1 = v0_1.clone();
                       move |v: Func0<string>|
                           Trace::closure5(v0_1.clone(), v)
                   })
    }
    pub fn v0() -> () {
        static v0: OnceInit<()> = OnceInit::new();
        v0.get_or_init(|| ()).clone()
    }
    pub fn v1() -> Func0<()> {
        static v1: OnceInit<Func0<()>> = OnceInit::new();
        v1.get_or_init(|| Func0::new(move || Trace::closure0((), ()))).clone()
    }
    pub fn v2() -> () {
        static v2: OnceInit<()> = OnceInit::new();
        v2.get_or_init(|| { (Trace::v1())(); Trace::v0() }).clone()
    }
    pub fn v15()
     -> Func1<Trace::US0, Func1<Func0<string>, Func1<Func0<string>, ()>>> {
        static v15:
         OnceInit<Func1<Trace::US0,
                        Func1<Func0<string>, Func1<Func0<string>, ()>>>> =
            OnceInit::new();
        v15.get_or_init(||
                            Func1::new(move |v: Trace::US0|
                                           Trace::closure4((), v))).clone()
    }
    pub fn trace(x: Trace::US0)
     -> Func1<Func0<string>, Func1<Func0<string>, ()>> {
        (Trace::v15())(x)
    }
    on_startup!(());
}
