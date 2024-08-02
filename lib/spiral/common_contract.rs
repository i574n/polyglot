pub mod Common {
    use super::*;
    use fable_library_rust::Exception_::try_catch;
    use fable_library_rust::FSharp::Control::LazyExtensions;
    use fable_library_rust::Interfaces_::System::Collections::Generic::IEnumerable_1;
    use fable_library_rust::Interfaces_::System::IDisposable;
    use fable_library_rust::List_::empty;
    use fable_library_rust::List_::ofArray;
    use fable_library_rust::List_::toArray;
    use fable_library_rust::Map_::find;
    use fable_library_rust::Map_::ofSeq;
    use fable_library_rust::Native_::Any;
    use fable_library_rust::Native_::Func0;
    use fable_library_rust::Native_::Func1;
    use fable_library_rust::Native_::Lrc;
    use fable_library_rust::Native_::LrcPtr;
    use fable_library_rust::Native_::MutCell;
    use fable_library_rust::Native_::OnceInit;
    use fable_library_rust::Native_::interface_cast;
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
    use fable_library_rust::System::Exception;
    use fable_library_rust::System::Lazy_1;
    pub mod State {
        use super::*;
        pub fn trace_state()
         ->
             LrcPtr<MutCell<Option<(LrcPtr<Common::Mut0>,
                                    LrcPtr<Common::Mut1>,
                                    LrcPtr<Common::Mut2>,
                                    LrcPtr<Common::Mut3>, Option<i64>)>>> {
            static trace_state:
             OnceInit<LrcPtr<MutCell<Option<(LrcPtr<Common::Mut0>,
                                             LrcPtr<Common::Mut1>,
                                             LrcPtr<Common::Mut2>,
                                             LrcPtr<Common::Mut3>,
                                             Option<i64>)>>>> =
                OnceInit::new();
            trace_state.get_or_init(||
                                        LrcPtr::new(MutCell::new(None::<(LrcPtr<Common::Mut0>,
                                                                         LrcPtr<Common::Mut1>,
                                                                         LrcPtr<Common::Mut2>,
                                                                         LrcPtr<Common::Mut3>,
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
    #[derive(Clone, Debug,)]
    pub struct Disposable {
        f: Func0<()>,
    }
    impl Common::Disposable {
        pub fn _ctor__3A5B6456(f: Func0<()>) -> LrcPtr<Common::Disposable> {
            let f_1;
            ();
            f_1 = f;
            ();
            LrcPtr::new(Common::Disposable{f: f_1,})
        }
    }
    impl core::fmt::Display for Common::Disposable {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    impl IDisposable for Disposable {
        fn Dispose(&self) { (self.f)(); }
    }
    #[derive(Clone, Copy, Debug, PartialEq, PartialOrd, Hash, Eq,)]
    pub enum US0 { US0_0, US0_1, US0_2, US0_3, US0_4, }
    impl core::fmt::Display for Common::US0 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Debug, Default, PartialEq, PartialOrd, Hash, Eq,)]
    pub struct Mut0 {
        pub l0: MutCell<i64>,
    }
    impl core::fmt::Display for Common::Mut0 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Debug,)]
    pub struct Mut1 {
        pub l0: MutCell<Func1<string, ()>>,
    }
    impl core::fmt::Display for Common::Mut1 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Debug, Default, PartialEq, PartialOrd, Hash, Eq,)]
    pub struct Mut2 {
        pub l0: MutCell<bool>,
    }
    impl core::fmt::Display for Common::Mut2 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Debug, PartialEq, PartialOrd, Hash, Eq,)]
    pub struct Mut3 {
        pub l0: MutCell<Common::US0>,
    }
    impl core::fmt::Display for Common::Mut3 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Copy, Debug, PartialEq, PartialOrd, Hash, Eq,)]
    pub enum US1 { US1_0(Common::US0), US1_1, }
    impl core::fmt::Display for Common::US1 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Copy, Debug, PartialEq, PartialOrd, Hash, Eq,)]
    pub enum US2 { US2_0(i64), US2_1, }
    impl core::fmt::Display for Common::US2 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Debug, PartialEq, PartialOrd, Hash, Eq,)]
    pub enum US3 { US3_0(string), US3_1, }
    impl core::fmt::Display for Common::US3 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Copy, Debug, PartialEq, PartialOrd, Hash, Eq,)]
    pub enum US4 { US4_0, US4_1, }
    impl core::fmt::Display for Common::US4 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Copy, Debug, PartialEq, PartialOrd, Hash, Eq,)]
    pub enum US5 { US5_0(Common::US4), US5_1, }
    impl core::fmt::Display for Common::US5 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Debug, Default, PartialEq, PartialOrd, Hash, Eq,)]
    pub struct Mut4 {
        pub l0: MutCell<string>,
    }
    impl core::fmt::Display for Common::Mut4 {
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
        let v46: string = Common::method2();
        { let x: string = v45.unwrap_or(v46); _v3.set(Some(x)) }
        match &_v3.get().clone() {
            None => panic!("{}", string("base.run_target / _v3=None"),),
            Some(_v3_0_0) => _v3_0_0.clone(),
        }
    }
    pub fn method3() -> string { string("AUTOMATION") }
    pub fn closure1(unitVar: (), v0: string) { (); }
    pub fn closure0(unitVar: (), v0: Common::US0)
     ->
         (LrcPtr<Common::Mut0>, LrcPtr<Common::Mut1>, LrcPtr<Common::Mut2>,
          LrcPtr<Common::Mut3>, Option<i64>) {
        let _v3: MutCell<Option<(Common::US1, Common::US2)>> =
            MutCell::new(None::<(Common::US1, Common::US2)>);
        let _v88: MutCell<Option<string>> = MutCell::new(None::<string>);
        let v101: string = string("env!(\"AUTOMATION\")");
        let v102: &str = env!("AUTOMATION");
        let v104: std::string::String = String::from(v102);
        {
            let x: string = fable_library_rust::String_::fromString(v104);
            _v88.set(Some(x))
        }
        {
            let x_2: (Common::US1, Common::US2) =
                (Common::US1::US1_1,
                 if match &_v88.get().clone() {
                        None =>
                        panic!("{}", string("base.run_target / _v88=None"),),
                        Some(_v88_0_0) => _v88_0_0.clone(),
                    } != string("True") {
                     Common::US2::US2_1
                 } else {
                     Common::US2::US2_0(near_sdk::env::block_timestamp() as
                                            i64)
                 });
            _v3.set(Some(x_2))
        }
        {
            let patternInput: (Common::US1, Common::US2) =
                match &_v3.get().clone() {
                    None =>
                    panic!("{}", string("base.run_target / _v3=None"),),
                    Some(_v3_0_0) => _v3_0_0.clone(),
                };
            let v402: Common::US2 = patternInput.1.clone();
            let v401: Common::US1 = patternInput.0.clone();
            (LrcPtr::new(Common::Mut0{l0: MutCell::new(0_i64),}),
             LrcPtr::new(Common::Mut1{l0:
                                          MutCell::new(Func1::new(move
                                                                      |v:
                                                                           string|
                                                                      Common::closure1((),
                                                                                       v))),}),
             LrcPtr::new(Common::Mut2{l0: MutCell::new(true),}),
             LrcPtr::new(Common::Mut3{l0:
                                          MutCell::new(match &v401 {
                                                           Common::US1::US1_0(v401_0_0)
                                                           =>
                                                           match &v401 {
                                                               Common::US1::US1_0(x)
                                                               => x.clone(),
                                                               _ =>
                                                               unreachable!(),
                                                           },
                                                           _ => v0,
                                                       }),}),
             match &v402 {
                 Common::US2::US2_0(v402_0_0) =>
                 Some(match &v402 {
                          Common::US2::US2_0(x) => x.clone(),
                          _ => unreachable!(),
                      }),
                 _ => None::<i64>,
             })
        }
    }
    pub fn method4(v0: Func0<()>) -> Func0<()> { v0 }
    pub fn method5(v0: Func0<()>) -> Func0<()> { v0 }
    pub fn closure2(unitVar: (), v0: Func0<()>) -> LrcPtr<dyn IDisposable> {
        let _v3: MutCell<Option<LrcPtr<dyn IDisposable>>> =
            MutCell::new(None::<LrcPtr<dyn IDisposable>>);
        let v8 = Common::method4(v0);
        {
            let x: LrcPtr<dyn IDisposable> =
                interface_cast!(Common::Disposable::_ctor__3A5B6456(Func0::new({
                                                   let v8 = v8.clone();
                                                   move || v8.clone()()
                                               })),
                                Lrc<dyn IDisposable>,);
            _v3.set(Some(x))
        }
        match &_v3.get().clone() {
            None => panic!("{}", string("base.run_target / _v3=None"),),
            Some(_v3_0_0) => _v3_0_0.clone(),
        }
    }
    pub fn closure5(unitVar: (), v0: Common::US4) -> Common::US5 {
        Common::US5::US5_0(v0)
    }
    pub fn closure6(v0: i32, v1: Func0<()>, v2_1: i32, unitVar: ())
     -> Common::US4 {
        if v2_1 < v0 { v1(); Common::US4::US4_0 } else { Common::US4::US4_1 }
    }
    pub fn closure8(unitVar: (), unitVar_1: ()) -> string {
        string("common.retry_fn")
    }
    pub fn closure9(v0: i32, v1: LrcPtr<Exception>, unitVar: ())
     -> (i32, LrcPtr<Exception>) {
        (v0, v1)
    }
    pub fn method8() -> string { string("hh:mm:ss") }
    pub fn method9() -> string { string("HH:mm:ss") }
    pub fn method10() -> string { string("\u{001b}[0m") }
    pub fn method12(v0: LrcPtr<Common::Mut4>, v1: string) {
        let v4: string = sprintf!("{}", v1);
        let v12: string = append(v0.l0.get().clone(), v4);
        v0.l0.set(v12);
        ()
    }
    pub fn method13(v0: LrcPtr<Common::Mut4>) { (); }
    pub fn method14(v0: LrcPtr<Common::Mut4>, v1: i32) {
        let v4: string = sprintf!("{}", v1);
        let v12: string = append(v0.l0.get().clone(), v4);
        v0.l0.set(v12);
        ()
    }
    pub fn method15(v0: LrcPtr<Common::Mut4>, v1: LrcPtr<Exception>) {
        Common::method12(v0, sprintf!("{:?}", v1));
    }
    pub fn method11(v0: LrcPtr<Common::Mut4>, v1: i32,
                    v2_1: LrcPtr<Exception>) {
        Common::method12(v0.clone(), string("{ "));
        Common::method13(v0.clone());
        Common::method12(v0.clone(), string("retry"));
        Common::method12(v0.clone(), string(" = "));
        Common::method14(v0.clone(), v1);
        Common::method12(v0.clone(), string("; "));
        Common::method12(v0.clone(), string("ex"));
        Common::method12(v0.clone(), string(" = "));
        Common::method15(v0.clone(), v2_1);
        Common::method12(v0, string(" }"))
    }
    pub fn closure10(v0: Common::US0, v1: Func0<string>,
                     v2_1: Func0<(i32, LrcPtr<Exception>)>, unitVar: ())
     -> string {
        if Common::State::trace_state().get().clone().is_none() {
            Common::State::trace_state().set(Some(Common::closure0((),
                                                                   Common::US0::US0_0)));
        }
        {
            let patternInput:
                    (LrcPtr<Common::Mut0>, LrcPtr<Common::Mut1>,
                     LrcPtr<Common::Mut2>, LrcPtr<Common::Mut3>,
                     Option<i64>) =
                getValue(Common::State::trace_state().get().clone());
            let v18: Option<i64> = patternInput.4.clone();
            let _v35: MutCell<Option<string>> = MutCell::new(None::<string>);
            let v331: u64 = near_sdk::env::block_timestamp();
            let _v334: LrcPtr<MutCell<Option<Common::US2>>> =
                refCell(None::<Common::US2>);
            {
                let x_2: Option<Common::US2> =
                    match &v18 {
                        None => None::<Common::US2>,
                        Some(v18_0_0) => {
                            let x: i64 = v18_0_0.clone();
                            Some((Func0::new({
                                                 let x = x.clone();
                                                 move || Common::US2::US2_0(x)
                                             }))())
                        }
                    };
                _v334.set(x_2)
            }
            {
                let v361: Common::US2 =
                    defaultValue(Common::US2::US2_1, _v334.get().clone());
                let v375: u64 =
                    match &v361 {
                        Common::US2::US2_0(v361_0_0) =>
                        v331 -
                            match &v361 {
                                Common::US2::US2_0(x) => x.clone(),
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
                    let v985: Common::US3 =
                        if if let Common::US0::US0_0 = &v0 {
                               true
                           } else { false } {
                            Common::US3::US3_0(string("Verbose"))
                        } else { Common::US3::US3_1 };
                    let v1034: Common::US3 =
                        match &v985 {
                            Common::US3::US3_0(v985_0_0) =>
                            Common::US3::US3_0(match &v985 {
                                                   Common::US3::US3_0(x) =>
                                                   x.clone(),
                                                   _ => unreachable!(),
                                               }),
                            _ => {
                                let v994: Common::US3 =
                                    if if let Common::US0::US0_1 = &v0 {
                                           true
                                       } else { false } {
                                        Common::US3::US3_0(string("Debug"))
                                    } else { Common::US3::US3_1 };
                                match &v994 {
                                    Common::US3::US3_0(v994_0_0) =>
                                    Common::US3::US3_0(match &v994 {
                                                           Common::US3::US3_0(x)
                                                           => x.clone(),
                                                           _ =>
                                                           unreachable!(),
                                                       }),
                                    _ => {
                                        let v1003: Common::US3 =
                                            if if let Common::US0::US0_2 = &v0
                                                  {
                                                   true
                                               } else { false } {
                                                Common::US3::US3_0(string("Info"))
                                            } else { Common::US3::US3_1 };
                                        match &v1003 {
                                            Common::US3::US3_0(v1003_0_0) =>
                                            Common::US3::US3_0(match &v1003 {
                                                                   Common::US3::US3_0(x)
                                                                   =>
                                                                   x.clone(),
                                                                   _ =>
                                                                   unreachable!(),
                                                               }),
                                            _ => {
                                                let v1012: Common::US3 =
                                                    if if let Common::US0::US0_3
                                                              = &v0 {
                                                           true
                                                       } else { false } {
                                                        Common::US3::US3_0(string("Warning"))
                                                    } else {
                                                        Common::US3::US3_1
                                                    };
                                                match &v1012 {
                                                    Common::US3::US3_0(v1012_0_0)
                                                    =>
                                                    Common::US3::US3_0(match &v1012
                                                                           {
                                                                           Common::US3::US3_0(x)
                                                                           =>
                                                                           x.clone(),
                                                                           _
                                                                           =>
                                                                           unreachable!(),
                                                                       }),
                                                    _ => {
                                                        let v1021:
                                                                Common::US3 =
                                                            if if let Common::US0::US0_4
                                                                      = &v0 {
                                                                   true
                                                               } else {
                                                                   false
                                                               } {
                                                                Common::US3::US3_0(string("Critical"))
                                                            } else {
                                                                Common::US3::US3_1
                                                            };
                                                        match &v1021 {
                                                            Common::US3::US3_0(v1021_0_0)
                                                            =>
                                                            Common::US3::US3_0(match &v1021
                                                                                   {
                                                                                   Common::US3::US3_0(x)
                                                                                   =>
                                                                                   x.clone(),
                                                                                   _
                                                                                   =>
                                                                                   unreachable!(),
                                                                               }),
                                                            _ =>
                                                            Common::US3::US3_1,
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
                                            Common::US3::US3_0(v1034_0_0) =>
                                            match &v1034 {
                                                Common::US3::US3_0(x) =>
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
                            Common::US0::US0_1 =>
                            inline_colorization::color_bright_blue,
                            Common::US0::US0_2 =>
                            inline_colorization::color_bright_green,
                            Common::US0::US0_0 =>
                            inline_colorization::color_bright_black,
                            Common::US0::US0_3 =>
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
                        let patternInput_1: (i32, LrcPtr<Exception>) = v2_1();
                        let v1218: LrcPtr<Common::Mut4> =
                            LrcPtr::new(Common::Mut4{l0:
                                                         MutCell::new(string("")),});
                        Common::method11(v1218.clone(),
                                         patternInput_1.0.clone(),
                                         patternInput_1.1.clone());
                        {
                            let v1219: string = v1218.l0.get().clone();
                            trimEndChars(trimStartChars(sprintf!("{} {} #{} {} / {}",
                                                                 v826, v1195,
                                                                 v1214, v1(),
                                                                 v1219),
                                                        toArray(empty::<char>())),
                                         toArray(ofArray(new_array(&[' ',
                                                                     '/']))))
                        }
                    }
                }
            }
        }
    }
    pub fn method16(v0: Common::US0, v1: Func0<string>) {
        fn v4(v: Common::US0)
         ->
             (LrcPtr<Common::Mut0>, LrcPtr<Common::Mut1>,
              LrcPtr<Common::Mut2>, LrcPtr<Common::Mut3>, Option<i64>) {
            Common::closure0((), v)
        }
        if Common::State::trace_state().get().clone().is_none() {
            Common::State::trace_state().set(Some(v4(Common::US0::US0_0)));
        }
        {
            let patternInput:
                    (LrcPtr<Common::Mut0>, LrcPtr<Common::Mut1>,
                     LrcPtr<Common::Mut2>, LrcPtr<Common::Mut3>,
                     Option<i64>) =
                getValue(Common::State::trace_state().get().clone());
            let v13: LrcPtr<Common::Mut0> = patternInput.0.clone();
            if Common::State::trace_state().get().clone().is_none() {
                Common::State::trace_state().set(Some(v4(Common::US0::US0_0)));
            }
            {
                let patternInput_1:
                        (LrcPtr<Common::Mut0>, LrcPtr<Common::Mut1>,
                         LrcPtr<Common::Mut2>, LrcPtr<Common::Mut3>,
                         Option<i64>) =
                    getValue(Common::State::trace_state().get().clone());
                let v61: Common::US0 =
                    (patternInput_1.3.clone()).l0.get().clone();
                if if (patternInput_1.2.clone()).l0.get().clone() == false {
                       false
                   } else {
                       find(v0,
                            ofSeq(ofList(ofArray(new_array(&[LrcPtr::new((Common::US0::US0_0,
                                                                          0_i32)),
                                                             LrcPtr::new((Common::US0::US0_1,
                                                                          1_i32)),
                                                             LrcPtr::new((Common::US0::US0_2,
                                                                          2_i32)),
                                                             LrcPtr::new((Common::US0::US0_3,
                                                                          3_i32)),
                                                             LrcPtr::new((Common::US0::US0_4,
                                                                          4_i32))])))))
                           >=
                           find(v61,
                                ofSeq(ofList(ofArray(new_array(&[LrcPtr::new((Common::US0::US0_0,
                                                                              0_i32)),
                                                                 LrcPtr::new((Common::US0::US0_1,
                                                                              1_i32)),
                                                                 LrcPtr::new((Common::US0::US0_2,
                                                                              2_i32)),
                                                                 LrcPtr::new((Common::US0::US0_3,
                                                                              3_i32)),
                                                                 LrcPtr::new((Common::US0::US0_4,
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
    pub fn method7(v0: Common::US0, v1: Func0<string>,
                   v2_1: Func0<(i32, LrcPtr<Exception>)>) {
        Common::method16(v0.clone(),
                         Func0::new({
                                        let v0 = v0.clone();
                                        let v1 = v1.clone();
                                        let v2_1 = v2_1.clone();
                                        move ||
                                            Common::closure10(v0.clone(),
                                                              v1.clone(),
                                                              v2_1.clone(),
                                                              ())
                                    }));
    }
    pub fn closure7(v0: i32, v1: LrcPtr<Exception>) -> Common::US5 {
        Common::method7(Common::US0::US0_3,
                        Func0::new(move || Common::closure8((), ())),
                        Func0::new({
                                       let v0 = v0.clone();
                                       let v1 = v1.clone();
                                       move ||
                                           Common::closure9(v0, v1.clone(),
                                                            ())
                                   }));
        Common::US5::US5_1
    }
    pub fn method6(v0: i32, v1: Func0<()>, v2_1: i32) -> Common::US4 {
        let v0: MutCell<i32> = MutCell::new(v0);
        let v1 = MutCell::new(v1.clone());
        let v2_1: MutCell<i32> = MutCell::new(v2_1);
        '_method6:
            loop  {
                break '_method6
                    ({
                         let result: LrcPtr<MutCell<Common::US5>> =
                             refCell(Common::US5::US5_1);
                         try_catch(||
                                       result.set(Common::closure5((),
                                                                   Common::closure6(v0.get().clone(),
                                                                                    v1.get().clone(),
                                                                                    v2_1.get().clone(),
                                                                                    ()))),
                                   |ex: LrcPtr<Exception>|
                                       result.set(Common::closure7(v2_1.get().clone(),
                                                                   ex.clone())));
                         {
                             let v9_1: Common::US5 = result.get().clone();
                             match &v9_1 {
                                 Common::US5::US5_0(v9_1_0_0) =>
                                 match &v9_1 {
                                     Common::US5::US5_0(x) => x.clone(),
                                     _ => unreachable!(),
                                 },
                                 _ => {
                                     let v0_temp: i32 = v0.get().clone();
                                     let v1_temp = v1.get().clone();
                                     let v2_1_temp: i32 =
                                         v2_1.get().clone() + 1_i32;
                                     v0.set(v0_temp);
                                     v1.set(v1_temp);
                                     v2_1.set(v2_1_temp);
                                     continue '_method6
                                 }
                             }
                         }
                     }) ;
            }
    }
    pub fn closure4(v0: i32, v1: Func0<()>) -> Option<()> {
        let v3_1: Common::US4 = Common::method6(v0, v1, 0_i32);
        match &v3_1 { Common::US4::US4_0 => Some(()), _ => None::<()>, }
    }
    pub fn closure3(unitVar: (), v0: i32) -> Func1<Func0<()>, Option<()>> {
        Func1::new({
                       let v0 = v0.clone();
                       move |v: Func0<()>| Common::closure4(v0, v)
                   })
    }
    pub fn method17(v0: Func0<()>) -> Func0<()> { v0 }
    pub fn closure12(v0: LrcPtr<Lazy_1<()>>, unitVar: ()) {
        v0.get_Value();
        ()
    }
    pub fn closure11(unitVar: (), v0: Func0<()>) -> Func0<()> {
        let v1 = Common::method17(v0);
        let v4: LrcPtr<Lazy_1<()>> =
            LazyExtensions::Create(Func0::new({
                                                  let v1 = v1.clone();
                                                  move || v1()
                                              }));
        Func0::new({
                       let v4 = v4.clone();
                       move || Common::closure12(v4.clone(), ())
                   })
    }
    pub fn v2()
     ->
         Func1<Common::US0,
               (LrcPtr<Common::Mut0>, LrcPtr<Common::Mut1>,
                LrcPtr<Common::Mut2>, LrcPtr<Common::Mut3>, Option<i64>)> {
        static v2:
         OnceInit<Func1<Common::US0,
                        (LrcPtr<Common::Mut0>, LrcPtr<Common::Mut1>,
                         LrcPtr<Common::Mut2>, LrcPtr<Common::Mut3>,
                         Option<i64>)>> =
            OnceInit::new();
        v2.get_or_init(||
                           Func1::new(move |v: Common::US0|
                                          Common::closure0((), v))).clone()
    }
    pub fn v3() -> Common::US0 {
        static v3: OnceInit<Common::US0> = OnceInit::new();
        v3.get_or_init(|| Common::US0::US0_0).clone()
    }
    on_startup!(if Common::State::trace_state().get().clone().is_none() {
    Common::State::trace_state().set(Some((Common::v2())(Common::v3())));
});
    pub fn v9() -> Func1<Func0<()>, LrcPtr<dyn IDisposable>> {
        static v9: OnceInit<Func1<Func0<()>, LrcPtr<dyn IDisposable>>> =
            OnceInit::new();
        v9.get_or_init(||
                           Func1::new(move |v: Func0<()>|
                                          Common::closure2((), v))).clone()
    }
    pub fn new_disposable(x: Func0<()>) -> LrcPtr<dyn IDisposable> {
        (Common::v9())(x)
    }
    pub fn v10() -> Func1<i32, Func1<Func0<()>, Option<()>>> {
        static v10: OnceInit<Func1<i32, Func1<Func0<()>, Option<()>>>> =
            OnceInit::new();
        v10.get_or_init(||
                            Func1::new(move |v: i32|
                                           Common::closure3((), v))).clone()
    }
    pub fn retry_fn(x: i32) -> Func1<Func0<()>, Option<()>> {
        (Common::v10())(x)
    }
    pub fn v11() -> Func1<Func0<()>, Func0<()>> {
        static v11: OnceInit<Func1<Func0<()>, Func0<()>>> = OnceInit::new();
        v11.get_or_init(||
                            Func1::new(move |v: Func0<()>|
                                           Common::closure11((), v))).clone()
    }
    pub fn memoize(x: Func0<()>) -> Func0<()> { (Common::v11())(x) }
    on_startup!(());
}
