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
    use fable_library_rust::NativeArray_::new_array;
    use fable_library_rust::Option_::defaultValue;
    use fable_library_rust::Option_::getValue;
    use fable_library_rust::Seq_::ofList;
    use fable_library_rust::String_::append;
    use fable_library_rust::String_::padLeft;
    use fable_library_rust::String_::sprintf;
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
    #[derive(Clone, Copy, Debug, PartialEq, PartialOrd, Hash, Eq,)]
    pub enum US1 { US1_0(Trace::US0), US1_1, }
    impl core::fmt::Display for Trace::US1 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Copy, Debug, PartialEq, PartialOrd, Hash, Eq,)]
    pub enum US2 { US2_0(i64), US2_1, }
    impl core::fmt::Display for Trace::US2 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Debug, PartialEq, PartialOrd, Hash, Eq,)]
    pub enum US3 { US3_0(string), US3_1, }
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
    pub fn method0() -> string { string("TRACE_LEVEL") }
    pub fn method2() -> string { string("") }
    pub fn method1(v0: string) -> string {
        let _v3: MutCell<Option<string>> = MutCell::new(None::<string>);
        let v35: Result<std::string::String, std::env::VarError> =
            std::env::var(&*v0);
        let v37: bool = true; let _result = v35.map(|x| { //;
        let v39: std::string::String = x;
        let v41: string = fable_library_rust::String_::fromString(v39);
        let v43: bool = true; v41 });
        let v45: Result<string, std::env::VarError> = _result;
        let v46: string = Trace::method2();
        { let x: string = v45.unwrap_or(v46); _v3.set(Some(x)) }
        match &_v3.get().clone() {
            None => panic!("{}", string("base.run_target / _v3=None"),),
            Some(_v3_0_0) => _v3_0_0.clone(),
        }
    }
    pub fn method3() -> string { string("AUTOMATION") }
    pub fn closure1(unitVar: (), v0: string) { (); }
    pub fn closure0(unitVar: (), v0: Trace::US0)
     ->
         (LrcPtr<Trace::Mut0>, LrcPtr<Trace::Mut1>, LrcPtr<Trace::Mut2>,
          LrcPtr<Trace::Mut3>, Option<i64>) {
        let _v3: MutCell<Option<(Trace::US1, Trace::US2)>> =
            MutCell::new(None::<(Trace::US1, Trace::US2)>);
        let _v88: MutCell<Option<string>> = MutCell::new(None::<string>);
        let v101: string = string("env!(\"AUTOMATION\")");
        let v102: &str = env!("AUTOMATION");
        let v104: std::string::String = String::from(v102);
        {
            let x: string = fable_library_rust::String_::fromString(v104);
            _v88.set(Some(x))
        }
        {
            let x_2: (Trace::US1, Trace::US2) =
                (Trace::US1::US1_1,
                 if match &_v88.get().clone() {
                        None =>
                        panic!("{}", string("base.run_target / _v88=None"),),
                        Some(_v88_0_0) => _v88_0_0.clone(),
                    } != string("True") {
                     Trace::US2::US2_1
                 } else {
                     Trace::US2::US2_0(near_sdk::env::block_timestamp() as
                                           i64)
                 });
            _v3.set(Some(x_2))
        }
        {
            let patternInput: (Trace::US1, Trace::US2) =
                match &_v3.get().clone() {
                    None =>
                    panic!("{}", string("base.run_target / _v3=None"),),
                    Some(_v3_0_0) => _v3_0_0.clone(),
                };
            let v402: Trace::US2 = patternInput.1.clone();
            let v401: Trace::US1 = patternInput.0.clone();
            (LrcPtr::new(Trace::Mut0{l0: MutCell::new(0_i64),}),
             LrcPtr::new(Trace::Mut1{l0:
                                         MutCell::new(Func1::new(move
                                                                     |v:
                                                                          string|
                                                                     Trace::closure1((),
                                                                                     v))),}),
             LrcPtr::new(Trace::Mut2{l0: MutCell::new(true),}),
             LrcPtr::new(Trace::Mut3{l0:
                                         MutCell::new(match &v401 {
                                                          Trace::US1::US1_0(v401_0_0)
                                                          =>
                                                          match &v401 {
                                                              Trace::US1::US1_0(x)
                                                              => x.clone(),
                                                              _ =>
                                                              unreachable!(),
                                                          },
                                                          _ => v0,
                                                      }),}),
             match &v402 {
                 Trace::US2::US2_0(v402_0_0) =>
                 Some(match &v402 {
                          Trace::US2::US2_0(x) => x.clone(),
                          _ => unreachable!(),
                      }),
                 _ => None::<i64>,
             })
        }
    }
    pub fn method5() -> string { string("hh:mm:ss") }
    pub fn method6() -> string { string("HH:mm:ss") }
    pub fn method7() -> string { string("\u{001b}[0m") }
    pub fn method8(v0: LrcPtr<Trace::Mut4>, v1: string) {
        let v4: string = sprintf!("{}", v1);
        let v12: string = append(v0.l0.get().clone(), v4);
        v0.l0.set(v12);
        ()
    }
    pub fn closure5(v0: Trace::US0, v1: Func0<string>, v2_1: Func0<string>,
                    unitVar: ()) -> string {
        if Trace::State::trace_state().get().clone().is_none() {
            Trace::State::trace_state().set(Some(Trace::closure0((),
                                                                 Trace::US0::US0_0)));
        }
        {
            let patternInput:
                    (LrcPtr<Trace::Mut0>, LrcPtr<Trace::Mut1>,
                     LrcPtr<Trace::Mut2>, LrcPtr<Trace::Mut3>, Option<i64>) =
                getValue(Trace::State::trace_state().get().clone());
            let v18: Option<i64> = patternInput.4.clone();
            let _v35: MutCell<Option<string>> = MutCell::new(None::<string>);
            let v331: u64 = near_sdk::env::block_timestamp();
            let _v334: LrcPtr<MutCell<Option<Trace::US2>>> =
                refCell(None::<Trace::US2>);
            {
                let x_2: Option<Trace::US2> =
                    match &v18 {
                        None => None::<Trace::US2>,
                        Some(v18_0_0) => {
                            let x: i64 = v18_0_0.clone();
                            Some((Func0::new({
                                                 let x = x.clone();
                                                 move || Trace::US2::US2_0(x)
                                             }))())
                        }
                    };
                _v334.set(x_2)
            }
            {
                let v361: Trace::US2 =
                    defaultValue(Trace::US2::US2_1, _v334.get().clone());
                let v375: u64 =
                    match &v361 {
                        Trace::US2::US2_0(v361_0_0) =>
                        v331 -
                            match &v361 {
                                Trace::US2::US2_0(x) => x.clone(),
                                _ => unreachable!(),
                            } as u64,
                        _ => v331,
                    } / 1000000000_u64;
                let v376: u64 = v375 % 60_u64;
                let v378: u64 = v375 / 60_u64 % 60_u64;
                let v380: u64 = v375 / 3600_u64 % 24_u64;
                let v382: std::string::String =
                    format!("{:02}:{:02}:{:02}", v380, v378, v376);
                {
                    let x_3: string =
                        fable_library_rust::String_::fromString(v382);
                    _v35.set(Some(x_3))
                }
                {
                    let v826: string =
                        match &_v35.get().clone() {
                            None =>
                            panic!("{}",
                                   string("base.run_target / _v35=None"),),
                            Some(_v35_0_0) => _v35_0_0.clone(),
                        };
                    let v985: Trace::US3 =
                        if if let Trace::US0::US0_0 = &v0 {
                               true
                           } else { false } {
                            Trace::US3::US3_0(string("Verbose"))
                        } else { Trace::US3::US3_1 };
                    let v1034: Trace::US3 =
                        match &v985 {
                            Trace::US3::US3_0(v985_0_0) =>
                            Trace::US3::US3_0(match &v985 {
                                                  Trace::US3::US3_0(x) =>
                                                  x.clone(),
                                                  _ => unreachable!(),
                                              }),
                            _ => {
                                let v994: Trace::US3 =
                                    if if let Trace::US0::US0_1 = &v0 {
                                           true
                                       } else { false } {
                                        Trace::US3::US3_0(string("Debug"))
                                    } else { Trace::US3::US3_1 };
                                match &v994 {
                                    Trace::US3::US3_0(v994_0_0) =>
                                    Trace::US3::US3_0(match &v994 {
                                                          Trace::US3::US3_0(x)
                                                          => x.clone(),
                                                          _ => unreachable!(),
                                                      }),
                                    _ => {
                                        let v1003: Trace::US3 =
                                            if if let Trace::US0::US0_2 = &v0
                                                  {
                                                   true
                                               } else { false } {
                                                Trace::US3::US3_0(string("Info"))
                                            } else { Trace::US3::US3_1 };
                                        match &v1003 {
                                            Trace::US3::US3_0(v1003_0_0) =>
                                            Trace::US3::US3_0(match &v1003 {
                                                                  Trace::US3::US3_0(x)
                                                                  =>
                                                                  x.clone(),
                                                                  _ =>
                                                                  unreachable!(),
                                                              }),
                                            _ => {
                                                let v1012: Trace::US3 =
                                                    if if let Trace::US0::US0_3
                                                              = &v0 {
                                                           true
                                                       } else { false } {
                                                        Trace::US3::US3_0(string("Warning"))
                                                    } else {
                                                        Trace::US3::US3_1
                                                    };
                                                match &v1012 {
                                                    Trace::US3::US3_0(v1012_0_0)
                                                    =>
                                                    Trace::US3::US3_0(match &v1012
                                                                          {
                                                                          Trace::US3::US3_0(x)
                                                                          =>
                                                                          x.clone(),
                                                                          _ =>
                                                                          unreachable!(),
                                                                      }),
                                                    _ => {
                                                        let v1021:
                                                                Trace::US3 =
                                                            if if let Trace::US0::US0_4
                                                                      = &v0 {
                                                                   true
                                                               } else {
                                                                   false
                                                               } {
                                                                Trace::US3::US3_0(string("Critical"))
                                                            } else {
                                                                Trace::US3::US3_1
                                                            };
                                                        match &v1021 {
                                                            Trace::US3::US3_0(v1021_0_0)
                                                            =>
                                                            Trace::US3::US3_0(match &v1021
                                                                                  {
                                                                                  Trace::US3::US3_0(x)
                                                                                  =>
                                                                                  x.clone(),
                                                                                  _
                                                                                  =>
                                                                                  unreachable!(),
                                                                              }),
                                                            _ =>
                                                            Trace::US3::US3_1,
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        };
                    let v1051: string =
                        padLeft(toLower(match &v1034 {
                                            Trace::US3::US3_0(v1034_0_0) =>
                                            match &v1034 {
                                                Trace::US3::US3_0(x) =>
                                                x.clone(),
                                                _ => unreachable!(),
                                            },
                                            _ =>
                                            panic!("{}",
                                                   string("Option does not have a value."),),
                                        }), 7_i32, ' ');
                    let _v1083: MutCell<Option<string>> =
                        MutCell::new(None::<string>);
                    let v1146: &str =
                        match &v0 {
                            Trace::US0::US0_1 =>
                            inline_colorization::color_bright_blue,
                            Trace::US0::US0_2 =>
                            inline_colorization::color_bright_green,
                            Trace::US0::US0_0 =>
                            inline_colorization::color_bright_black,
                            Trace::US0::US0_3 =>
                            inline_colorization::color_yellow,
                            _ => inline_colorization::color_bright_red,
                        };
                    let v1148: &str = &*v1051;
                    let v1150: &str = inline_colorization::color_reset;
                    let v1152: string =
                        string("format!(\"{v1146}{v1148}{v1150}\")");
                    let v1153: std::string::String =
                        format!("{v1146}{v1148}{v1150}");
                    {
                        let x_5: string =
                            fable_library_rust::String_::fromString(v1153);
                        _v1083.set(Some(x_5))
                    }
                    {
                        let v1195: string =
                            match &_v1083.get().clone() {
                                None =>
                                panic!("{}",
                                       string("base.run_target / _v1083=None"),),
                                Some(_v1083_0_0) => _v1083_0_0.clone(),
                            };
                        let v1214: i64 =
                            (patternInput.0.clone()).l0.get().clone();
                        let v1217: LrcPtr<Trace::Mut4> =
                            LrcPtr::new(Trace::Mut4{l0:
                                                        MutCell::new(string("")),});
                        Trace::method8(v1217.clone(), v2_1());
                        {
                            let v1218: string = v1217.l0.get().clone();
                            trimEndChars(trimStartChars(sprintf!("{} {} #{} {} / {}",
                                                                 v826, v1195,
                                                                 v1214, v1(),
                                                                 v1218),
                                                        toArray(empty::<char>())),
                                         toArray(ofArray(new_array(&[' ',
                                                                     '/']))))
                        }
                    }
                }
            }
        }
    }
    pub fn method9(v0: Trace::US0, v1: Func0<string>) {
        fn v4(v: Trace::US0)
         ->
             (LrcPtr<Trace::Mut0>, LrcPtr<Trace::Mut1>, LrcPtr<Trace::Mut2>,
              LrcPtr<Trace::Mut3>, Option<i64>) {
            Trace::closure0((), v)
        }
        if Trace::State::trace_state().get().clone().is_none() {
            Trace::State::trace_state().set(Some(v4(Trace::US0::US0_0)));
        }
        {
            let patternInput:
                    (LrcPtr<Trace::Mut0>, LrcPtr<Trace::Mut1>,
                     LrcPtr<Trace::Mut2>, LrcPtr<Trace::Mut3>, Option<i64>) =
                getValue(Trace::State::trace_state().get().clone());
            let v13: LrcPtr<Trace::Mut0> = patternInput.0.clone();
            if Trace::State::trace_state().get().clone().is_none() {
                Trace::State::trace_state().set(Some(v4(Trace::US0::US0_0)));
            }
            {
                let patternInput_1:
                        (LrcPtr<Trace::Mut0>, LrcPtr<Trace::Mut1>,
                         LrcPtr<Trace::Mut2>, LrcPtr<Trace::Mut3>,
                         Option<i64>) =
                    getValue(Trace::State::trace_state().get().clone());
                let v61: Trace::US0 =
                    (patternInput_1.3.clone()).l0.get().clone();
                if if (patternInput_1.2.clone()).l0.get().clone() == false {
                       false
                   } else {
                       find(v0,
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
                           find(v61,
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
                    let v69: i64 = v13.l0.get().clone() + 1_i64;
                    v13.l0.set(v69);
                    {
                        let v72: string = sprintf!("{}", v1());
                        let _v81: MutCell<Option<()>> =
                            MutCell::new(None::<()>);
                        near_sdk::log!("{}", v72.clone());
                        _v81.set(Some(()));
                        match &_v81.get().clone() {
                            None =>
                            panic!("{}",
                                   string("base.run_target / _v81=None"),),
                            Some(_v81_0_0) => _v81_0_0.clone(),
                        }
                        ((patternInput.1.clone()).l0.get().clone())(v72)
                    }
                }
            }
        }
    }
    pub fn method4(v0: Trace::US0, v1: Func0<string>, v2_1: Func0<string>) {
        Trace::method9(v0.clone(),
                       Func0::new({
                                      let v0 = v0.clone();
                                      let v1 = v1.clone();
                                      let v2_1 = v2_1.clone();
                                      move ||
                                          Trace::closure5(v0.clone(),
                                                          v1.clone(),
                                                          v2_1.clone(), ())
                                  }));
    }
    pub fn closure4(v0: Trace::US0, v1: Func0<string>, v2_1: Func0<string>) {
        Trace::method4(v0, v1, v2_1);
    }
    pub fn closure3(v0: Trace::US0, v1: Func0<string>)
     -> Func1<Func0<string>, ()> {
        Func1::new({
                       let v0 = v0.clone();
                       let v1 = v1.clone();
                       move |v: Func0<string>|
                           Trace::closure4(v0.clone(), v1.clone(), v)
                   })
    }
    pub fn closure2(unitVar: (), v0: Trace::US0)
     -> Func1<Func0<string>, Func1<Func0<string>, ()>> {
        Func1::new({
                       let v0 = v0.clone();
                       move |v: Func0<string>| Trace::closure3(v0.clone(), v)
                   })
    }
    pub fn v2()
     ->
         Func1<Trace::US0,
               (LrcPtr<Trace::Mut0>, LrcPtr<Trace::Mut1>, LrcPtr<Trace::Mut2>,
                LrcPtr<Trace::Mut3>, Option<i64>)> {
        static v2:
         OnceInit<Func1<Trace::US0,
                        (LrcPtr<Trace::Mut0>, LrcPtr<Trace::Mut1>,
                         LrcPtr<Trace::Mut2>, LrcPtr<Trace::Mut3>,
                         Option<i64>)>> =
            OnceInit::new();
        v2.get_or_init(||
                           Func1::new(move |v: Trace::US0|
                                          Trace::closure0((), v))).clone()
    }
    pub fn v3() -> Trace::US0 {
        static v3: OnceInit<Trace::US0> = OnceInit::new();
        v3.get_or_init(|| Trace::US0::US0_0).clone()
    }
    on_startup!(if Trace::State::trace_state().get().clone().is_none() {
    Trace::State::trace_state().set(Some((Trace::v2())(Trace::v3())));
});
    pub fn v9()
     -> Func1<Trace::US0, Func1<Func0<string>, Func1<Func0<string>, ()>>> {
        static v9:
         OnceInit<Func1<Trace::US0,
                        Func1<Func0<string>, Func1<Func0<string>, ()>>>> =
            OnceInit::new();
        v9.get_or_init(||
                           Func1::new(move |v: Trace::US0|
                                          Trace::closure2((), v))).clone()
    }
    pub fn trace(x: Trace::US0)
     -> Func1<Func0<string>, Func1<Func0<string>, ()>> {
        (Trace::v9())(x)
    }
    on_startup!(());
}
