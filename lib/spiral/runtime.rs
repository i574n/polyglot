pub mod Runtime {
    use super::*;
    type Async<T> = T;
    use fable_library_rust::DateTime_::DateTime;
    use fable_library_rust::Interfaces_::System::Collections::Generic::IEnumerable_1;
    use fable_library_rust::List_::cons;
    use fable_library_rust::List_::empty;
    use fable_library_rust::List_::foldBack;
    use fable_library_rust::List_::ofArray;
    use fable_library_rust::List_::toArray;
    use fable_library_rust::List_::List;
    use fable_library_rust::Map_::find;
    use fable_library_rust::Map_::ofSeq;
    use fable_library_rust::NativeArray_::new_array;
    use fable_library_rust::NativeArray_::new_empty;
    use fable_library_rust::NativeArray_::new_init;
    use fable_library_rust::NativeArray_::Array;
    use fable_library_rust::Native_::defaultOf;
    use fable_library_rust::Native_::on_startup;
    use fable_library_rust::Native_::unbox;
    use fable_library_rust::Native_::Arc;
    use fable_library_rust::Native_::Func0;
    use fable_library_rust::Native_::Func1;
    use fable_library_rust::Native_::Func2;
    use fable_library_rust::Native_::LrcPtr;
    use fable_library_rust::Native_::MutCell;
    use fable_library_rust::Native_::OnceInit;
    use fable_library_rust::Option_::defaultValue;
    use fable_library_rust::Option_::getValue;
    use fable_library_rust::Option_::map;
    use fable_library_rust::Seq_::ofList;
    use fable_library_rust::String_::getCharAt;
    use fable_library_rust::String_::length;
    use fable_library_rust::String_::padRight;
    use fable_library_rust::String_::replace;
    use fable_library_rust::String_::sprintf;
    use fable_library_rust::String_::string;
    use fable_library_rust::String_::toLower;
    use fable_library_rust::String_::trimEndChars;
    use fable_library_rust::String_::trimStartChars;
    use fable_library_rust::TimeSpan_::TimeSpan;
    type ConcurrentStack_1<T> = T;
    type CancellationToken = ();
    type TaskCanceledException = ();
    pub mod State {
        use super::*;
        pub fn trace_state() -> LrcPtr<
            MutCell<
                Option<(
                    LrcPtr<Runtime::Mut0>,
                    LrcPtr<Runtime::Mut1>,
                    LrcPtr<Runtime::Mut2>,
                    Option<i64>,
                    LrcPtr<Runtime::Mut3>,
                )>,
            >,
        > {
            static trace_state: OnceInit<
                LrcPtr<
                    MutCell<
                        Option<(
                            LrcPtr<Runtime::Mut0>,
                            LrcPtr<Runtime::Mut1>,
                            LrcPtr<Runtime::Mut2>,
                            Option<i64>,
                            LrcPtr<Runtime::Mut3>,
                        )>,
                    >,
                >,
            > = OnceInit::new();
            trace_state
                .get_or_init(|| {
                    LrcPtr::new(MutCell::new(
                        None::<(
                            LrcPtr<Runtime::Mut0>,
                            LrcPtr<Runtime::Mut1>,
                            LrcPtr<Runtime::Mut2>,
                            Option<i64>,
                            LrcPtr<Runtime::Mut3>,
                        )>,
                    ))
                })
                .clone()
        }
    }
    #[derive(Clone, Debug, Default, PartialEq, PartialOrd, Hash, Eq)]
    pub struct Mut0 {
        pub l0: MutCell<i64>,
    }
    impl core::fmt::Display for Runtime::Mut0 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Debug, Default, PartialEq, PartialOrd, Hash, Eq)]
    pub struct Mut1 {
        pub l0: MutCell<bool>,
    }
    impl core::fmt::Display for Runtime::Mut1 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Copy, Debug, PartialEq, PartialOrd, Hash, Eq)]
    pub enum US0 {
        US0_0,
        US0_1,
        US0_2,
        US0_3,
        US0_4,
    }
    impl Runtime::US0 {
        pub fn get_IsUS0_0(this_: &MutCell<Runtime::US0>, unitArg: ()) -> bool {
            if unreachable!() {
                true
            } else {
                false
            }
        }
        pub fn get_IsUS0_1(this_: &MutCell<Runtime::US0>, unitArg: ()) -> bool {
            if unreachable!() {
                true
            } else {
                false
            }
        }
        pub fn get_IsUS0_2(this_: &MutCell<Runtime::US0>, unitArg: ()) -> bool {
            if unreachable!() {
                true
            } else {
                false
            }
        }
        pub fn get_IsUS0_3(this_: &MutCell<Runtime::US0>, unitArg: ()) -> bool {
            if unreachable!() {
                true
            } else {
                false
            }
        }
        pub fn get_IsUS0_4(this_: &MutCell<Runtime::US0>, unitArg: ()) -> bool {
            if unreachable!() {
                true
            } else {
                false
            }
        }
    }
    impl core::fmt::Display for Runtime::US0 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Debug, PartialEq, PartialOrd, Hash, Eq)]
    pub struct Mut2 {
        pub l0: MutCell<Runtime::US0>,
    }
    impl core::fmt::Display for Runtime::Mut2 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Debug)]
    pub struct Mut3 {
        pub l0: MutCell<Func1<string, ()>>,
    }
    impl core::fmt::Display for Runtime::Mut3 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Copy, Debug, PartialEq, PartialOrd, Hash, Eq)]
    pub enum US1 {
        US1_0(i64),
        US1_1,
    }
    impl Runtime::US1 {
        pub fn get_IsUS1_0(this_: &MutCell<Runtime::US1>, unitArg: ()) -> bool {
            if unreachable!() {
                true
            } else {
                false
            }
        }
        pub fn get_IsUS1_1(this_: &MutCell<Runtime::US1>, unitArg: ()) -> bool {
            if unreachable!() {
                true
            } else {
                false
            }
        }
    }
    impl core::fmt::Display for Runtime::US1 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Debug, Default, PartialEq, PartialOrd, Hash, Eq)]
    pub struct Mut4 {
        pub l0: MutCell<i32>,
    }
    impl core::fmt::Display for Runtime::Mut4 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Debug, PartialEq, PartialOrd, Hash, Eq)]
    pub enum UH0 {
        UH0_0,
        UH0_1(char, LrcPtr<Runtime::UH0>),
    }
    impl Runtime::UH0 {
        pub fn get_IsUH0_0(this_: LrcPtr<Runtime::UH0>, unitArg: ()) -> bool {
            if let Runtime::UH0::UH0_0 = this_.as_ref() {
                true
            } else {
                false
            }
        }
        pub fn get_IsUH0_1(this_: LrcPtr<Runtime::UH0>, unitArg: ()) -> bool {
            if let Runtime::UH0::UH0_1(this__1_0, this__1_1) = this_.as_ref() {
                true
            } else {
                false
            }
        }
    }
    impl core::fmt::Display for Runtime::UH0 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Copy, Debug, PartialEq, PartialOrd, Hash, Eq)]
    pub enum US3 {
        US3_0,
        US3_1,
    }
    impl Runtime::US3 {
        pub fn get_IsUS3_0(this_: &MutCell<Runtime::US3>, unitArg: ()) -> bool {
            if unreachable!() {
                true
            } else {
                false
            }
        }
        pub fn get_IsUS3_1(this_: &MutCell<Runtime::US3>, unitArg: ()) -> bool {
            if unreachable!() {
                true
            } else {
                false
            }
        }
    }
    impl core::fmt::Display for Runtime::US3 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Copy, Debug, PartialEq, PartialOrd, Hash, Eq)]
    pub enum US2 {
        US2_0,
        US2_1(Runtime::US3),
        US2_2,
    }
    impl Runtime::US2 {
        pub fn get_IsUS2_0(this_: &MutCell<Runtime::US2>, unitArg: ()) -> bool {
            if unreachable!() {
                true
            } else {
                false
            }
        }
        pub fn get_IsUS2_1(this_: &MutCell<Runtime::US2>, unitArg: ()) -> bool {
            if unreachable!() {
                true
            } else {
                false
            }
        }
        pub fn get_IsUS2_2(this_: &MutCell<Runtime::US2>, unitArg: ()) -> bool {
            if unreachable!() {
                true
            } else {
                false
            }
        }
    }
    impl core::fmt::Display for Runtime::US2 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Debug, PartialEq, PartialOrd, Hash, Eq)]
    pub enum US4 {
        US4_0(string),
        US4_1,
    }
    impl Runtime::US4 {
        pub fn get_IsUS4_0(this_: &MutCell<Runtime::US4>, unitArg: ()) -> bool {
            if unreachable!() {
                true
            } else {
                false
            }
        }
        pub fn get_IsUS4_1(this_: &MutCell<Runtime::US4>, unitArg: ()) -> bool {
            if unreachable!() {
                true
            } else {
                false
            }
        }
    }
    impl core::fmt::Display for Runtime::US4 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Copy, Debug, PartialEq, PartialOrd, Hash, Eq)]
    pub enum US5 {
        US5_0(i64),
        US5_1,
    }
    impl Runtime::US5 {
        pub fn get_IsUS5_0(this_: &MutCell<Runtime::US5>, unitArg: ()) -> bool {
            if unreachable!() {
                true
            } else {
                false
            }
        }
        pub fn get_IsUS5_1(this_: &MutCell<Runtime::US5>, unitArg: ()) -> bool {
            if unreachable!() {
                true
            } else {
                false
            }
        }
    }
    impl core::fmt::Display for Runtime::US5 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Debug)]
    pub enum US6 {
        US6_0(Func1<(bool, string, i32), Arc<Async<()>>>),
        US6_1,
    }
    impl Runtime::US6 {
        pub fn get_IsUS6_0(this_: &MutCell<Runtime::US6>, unitArg: ()) -> bool {
            if unreachable!() {
                true
            } else {
                false
            }
        }
        pub fn get_IsUS6_1(this_: &MutCell<Runtime::US6>, unitArg: ()) -> bool {
            if unreachable!() {
                true
            } else {
                false
            }
        }
    }
    impl core::fmt::Display for Runtime::US6 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Copy, Debug, PartialEq, PartialOrd, Hash, Eq)]
    pub enum US7 {
        US7_0(CancellationToken),
        US7_1,
    }
    impl Runtime::US7 {
        pub fn get_IsUS7_0(this_: &MutCell<Runtime::US7>, unitArg: ()) -> bool {
            if unreachable!() {
                true
            } else {
                false
            }
        }
        pub fn get_IsUS7_1(this_: &MutCell<Runtime::US7>, unitArg: ()) -> bool {
            if unreachable!() {
                true
            } else {
                false
            }
        }
    }
    impl core::fmt::Display for Runtime::US7 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Debug)]
    pub struct Heap0 {
        pub l0: Option<CancellationToken>,
        pub l1: string,
        pub l2: Array<(string, string)>,
        pub l3: Option<Func1<(bool, string, i32), Arc<Async<()>>>>,
        pub l4: Option<string>,
    }
    impl core::fmt::Display for Runtime::Heap0 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Debug, PartialEq, PartialOrd, Hash, Eq)]
    pub enum UH1 {
        UH1_0,
        UH1_1(string, LrcPtr<Runtime::UH1>),
    }
    impl Runtime::UH1 {
        pub fn get_IsUH1_0(this_: LrcPtr<Runtime::UH1>, unitArg: ()) -> bool {
            if let Runtime::UH1::UH1_0 = this_.as_ref() {
                true
            } else {
                false
            }
        }
        pub fn get_IsUH1_1(this_: LrcPtr<Runtime::UH1>, unitArg: ()) -> bool {
            if let Runtime::UH1::UH1_1(this__1_0, this__1_1) = this_.as_ref() {
                true
            } else {
                false
            }
        }
    }
    impl core::fmt::Display for Runtime::UH1 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Copy, Debug, PartialEq, PartialOrd, Hash, Eq)]
    pub enum US8 {
        US8_0,
        US8_1(char),
        US8_2(u8),
    }
    impl Runtime::US8 {
        pub fn get_IsUS8_0(this_: &MutCell<Runtime::US8>, unitArg: ()) -> bool {
            if unreachable!() {
                true
            } else {
                false
            }
        }
        pub fn get_IsUS8_1(this_: &MutCell<Runtime::US8>, unitArg: ()) -> bool {
            if unreachable!() {
                true
            } else {
                false
            }
        }
        pub fn get_IsUS8_2(this_: &MutCell<Runtime::US8>, unitArg: ()) -> bool {
            if unreachable!() {
                true
            } else {
                false
            }
        }
    }
    impl core::fmt::Display for Runtime::US8 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    pub fn closure1(unitVar: (), v0_1: string) {
        ();
    }
    pub fn method0(v0_1: Option<i64>) -> Option<i64> {
        v0_1
    }
    pub fn method1(v0_1: Option<i64>) -> Option<i64> {
        v0_1
    }
    pub fn closure0(
        unitVar: (),
        unitVar_1: (),
    ) -> (
        LrcPtr<Runtime::Mut0>,
        LrcPtr<Runtime::Mut1>,
        LrcPtr<Runtime::Mut2>,
        Option<i64>,
        LrcPtr<Runtime::Mut3>,
    ) {
        let v0_1: LrcPtr<Runtime::Mut1> = LrcPtr::new(Runtime::Mut1 {
            l0: MutCell::new(true),
        });
        let v1_1: LrcPtr<Runtime::Mut0> = LrcPtr::new(Runtime::Mut0 {
            l0: MutCell::new(0_i64),
        });
        let v3_1: LrcPtr<Runtime::Mut2> = LrcPtr::new(Runtime::Mut2 {
            l0: MutCell::new(Runtime::US0::US0_0),
        });
        let v5_1: LrcPtr<Runtime::Mut3> = LrcPtr::new(Runtime::Mut3 {
            l0: MutCell::new(Func1::new(move |v: string| Runtime::closure1((), v))),
        });
        let _v6: MutCell<Option<Option<i64>>> = MutCell::new(None::<Option<i64>>);
        {
            let x: Option<i64> = Runtime::method1(None::<i64>);
            _v6.set(Some(x))
        }
        (v1_1, v0_1, v3_1, getValue(_v6.get().clone()), v5_1)
    }
    pub fn closure2(unitVar: (), unitVar_1: ()) -> bool {
        let _v0: MutCell<Option<bool>> = MutCell::new(None::<bool>);
        {
            let x: bool = cfg!(windows);
            _v0.set(Some(x))
        }
        getValue(_v0.get().clone())
    }
    pub fn closure3(unitVar: (), unitVar_1: ()) -> string {
        let _v0: MutCell<Option<bool>> = MutCell::new(None::<bool>);
        {
            let x: bool = cfg!(windows);
            _v0.set(Some(x))
        }
        if getValue(_v0.get().clone()) {
            string(".exe")
        } else {
            string("")
        }
    }
    pub fn method2() -> (string, string) {
        (string(""), string(""))
    }
    pub fn method3(v0_1: i32, v1_1: LrcPtr<Runtime::Mut4>) -> bool {
        v1_1.l0.get().clone() < v0_1
    }
    pub fn closure6(v0_1: char, v1_1: LrcPtr<Runtime::UH0>) -> LrcPtr<Runtime::UH0> {
        LrcPtr::new(Runtime::UH0::UH0_1(v0_1, v1_1))
    }
    pub fn closure5(unitVar: (), v0_1: char) -> Func1<LrcPtr<Runtime::UH0>, LrcPtr<Runtime::UH0>> {
        Func1::new({
            let v0_1 = v0_1.clone();
            move |v: LrcPtr<Runtime::UH0>| Runtime::closure6(v0_1, v)
        })
    }
    pub fn method4() -> Func1<char, Func1<LrcPtr<Runtime::UH0>, LrcPtr<Runtime::UH0>>> {
        Func1::new(move |v: char| Runtime::closure5((), v))
    }
    pub fn method5(
        v0_1: string,
        v1_1: string,
        v2_1: LrcPtr<Runtime::UH0>,
        v3_1: Runtime::US2,
    ) -> (string, string) {
        let v0_1: MutCell<string> = MutCell::new(v0_1.clone());
        let v1_1: MutCell<string> = MutCell::new(v1_1.clone());
        let v2_1: MutCell<LrcPtr<Runtime::UH0>> = MutCell::new(v2_1.clone());
        let v3_1: MutCell<Runtime::US2> = MutCell::new(v3_1.clone());
        '_method5: loop {
            break '_method5 (if let Runtime::UH0::UH0_1(v2_1_1_0, v2_1_1_1) =
                v2_1.get().clone().as_ref()
            {
                let v5_1: LrcPtr<Runtime::UH0> = match v2_1.get().clone().as_ref() {
                    Runtime::UH0::UH0_1(_, x) => x.clone(),
                    _ => unreachable!(),
                };
                let v4_1: char = match v2_1.get().clone().as_ref() {
                    Runtime::UH0::UH0_1(x, _) => x.clone(),
                    _ => unreachable!(),
                };
                if '\"' == v4_1 {
                    if v1_1.get().clone() == string("") {
                        let v0_1_temp: string = v0_1.get().clone();
                        let v1_1_temp: string = v1_1.get().clone();
                        let v2_1_temp: LrcPtr<Runtime::UH0> = v5_1.clone();
                        let v3_1_temp: Runtime::US2 = Runtime::US2::US2_1(Runtime::US3::US3_0);
                        v0_1.set(v0_1_temp);
                        v1_1.set(v1_1_temp);
                        v2_1.set(v2_1_temp);
                        v3_1.set(v3_1_temp);
                        continue '_method5;
                    } else {
                        match &v3_1.get().clone() {
                            Runtime::US2::US2_1(v3_1_1_0) => {
                                if let Runtime::US3::US3_0 = v3_1_1_0 {
                                    let v0_1_temp: string = v0_1.get().clone();
                                    let v1_1_temp: string = v1_1.get().clone();
                                    let v2_1_temp: LrcPtr<Runtime::UH0> = v5_1.clone();
                                    let v3_1_temp: Runtime::US2 =
                                        Runtime::US2::US2_1(Runtime::US3::US3_1);
                                    v0_1.set(v0_1_temp);
                                    v1_1.set(v1_1_temp);
                                    v2_1.set(v2_1_temp);
                                    v3_1.set(v3_1_temp);
                                    continue '_method5;
                                } else {
                                    if ' ' == v4_1 {
                                        let v0_1_temp: string = v0_1.get().clone();
                                        let v1_1_temp: string = v1_1.get().clone();
                                        let v2_1_temp: LrcPtr<Runtime::UH0> = v5_1.clone();
                                        let v3_1_temp: Runtime::US2 = Runtime::US2::US2_2;
                                        v0_1.set(v0_1_temp);
                                        v1_1.set(v1_1_temp);
                                        v2_1.set(v2_1_temp);
                                        v3_1.set(v3_1_temp);
                                        continue '_method5;
                                    } else {
                                        let v0_1_temp: string = v0_1.get().clone();
                                        let v1_1_temp: string =
                                            sprintf!("{}{}", v1_1.get().clone(), v4_1);
                                        let v2_1_temp: LrcPtr<Runtime::UH0> = v5_1.clone();
                                        let v3_1_temp: Runtime::US2 = v3_1.get().clone();
                                        v0_1.set(v0_1_temp);
                                        v1_1.set(v1_1_temp);
                                        v2_1.set(v2_1_temp);
                                        v3_1.set(v3_1_temp);
                                        continue '_method5;
                                    }
                                }
                            }
                            Runtime::US2::US2_0 => {
                                if ' ' == v4_1 {
                                    let v0_1_temp: string = v0_1.get().clone();
                                    let v1_1_temp: string = v1_1.get().clone();
                                    let v2_1_temp: LrcPtr<Runtime::UH0> = v5_1.clone();
                                    let v3_1_temp: Runtime::US2 = Runtime::US2::US2_2;
                                    v0_1.set(v0_1_temp);
                                    v1_1.set(v1_1_temp);
                                    v2_1.set(v2_1_temp);
                                    v3_1.set(v3_1_temp);
                                    continue '_method5;
                                } else {
                                    let v0_1_temp: string = v0_1.get().clone();
                                    let v1_1_temp: string =
                                        sprintf!("{}{}", v1_1.get().clone(), v4_1);
                                    let v2_1_temp: LrcPtr<Runtime::UH0> = v5_1.clone();
                                    let v3_1_temp: Runtime::US2 = v3_1.get().clone();
                                    v0_1.set(v0_1_temp);
                                    v1_1.set(v1_1_temp);
                                    v2_1.set(v2_1_temp);
                                    v3_1.set(v3_1_temp);
                                    continue '_method5;
                                }
                            }
                            _ => {
                                let v0_1_temp: string = sprintf!("{}{}", v0_1.get().clone(), v4_1);
                                let v1_1_temp: string = v1_1.get().clone();
                                let v2_1_temp: LrcPtr<Runtime::UH0> = v5_1.clone();
                                let v3_1_temp: Runtime::US2 = Runtime::US2::US2_2;
                                v0_1.set(v0_1_temp);
                                v1_1.set(v1_1_temp);
                                v2_1.set(v2_1_temp);
                                v3_1.set(v3_1_temp);
                                continue '_method5;
                            }
                        }
                    }
                } else {
                    if '\'' == v4_1 {
                        if v1_1.get().clone() == string("") {
                            let v0_1_temp: string = v0_1.get().clone();
                            let v1_1_temp: string = v1_1.get().clone();
                            let v2_1_temp: LrcPtr<Runtime::UH0> = v5_1.clone();
                            let v3_1_temp: Runtime::US2 = Runtime::US2::US2_1(Runtime::US3::US3_0);
                            v0_1.set(v0_1_temp);
                            v1_1.set(v1_1_temp);
                            v2_1.set(v2_1_temp);
                            v3_1.set(v3_1_temp);
                            continue '_method5;
                        } else {
                            match &v3_1.get().clone() {
                                Runtime::US2::US2_1(v3_1_1_0) => {
                                    if let Runtime::US3::US3_0 = v3_1_1_0 {
                                        let v0_1_temp: string = v0_1.get().clone();
                                        let v1_1_temp: string = v1_1.get().clone();
                                        let v2_1_temp: LrcPtr<Runtime::UH0> = v5_1.clone();
                                        let v3_1_temp: Runtime::US2 =
                                            Runtime::US2::US2_1(Runtime::US3::US3_1);
                                        v0_1.set(v0_1_temp);
                                        v1_1.set(v1_1_temp);
                                        v2_1.set(v2_1_temp);
                                        v3_1.set(v3_1_temp);
                                        continue '_method5;
                                    } else {
                                        if ' ' == v4_1 {
                                            let v0_1_temp: string = v0_1.get().clone();
                                            let v1_1_temp: string = v1_1.get().clone();
                                            let v2_1_temp: LrcPtr<Runtime::UH0> = v5_1.clone();
                                            let v3_1_temp: Runtime::US2 = Runtime::US2::US2_2;
                                            v0_1.set(v0_1_temp);
                                            v1_1.set(v1_1_temp);
                                            v2_1.set(v2_1_temp);
                                            v3_1.set(v3_1_temp);
                                            continue '_method5;
                                        } else {
                                            let v0_1_temp: string = v0_1.get().clone();
                                            let v1_1_temp: string =
                                                sprintf!("{}{}", v1_1.get().clone(), v4_1);
                                            let v2_1_temp: LrcPtr<Runtime::UH0> = v5_1.clone();
                                            let v3_1_temp: Runtime::US2 = v3_1.get().clone();
                                            v0_1.set(v0_1_temp);
                                            v1_1.set(v1_1_temp);
                                            v2_1.set(v2_1_temp);
                                            v3_1.set(v3_1_temp);
                                            continue '_method5;
                                        }
                                    }
                                }
                                Runtime::US2::US2_0 => {
                                    if ' ' == v4_1 {
                                        let v0_1_temp: string = v0_1.get().clone();
                                        let v1_1_temp: string = v1_1.get().clone();
                                        let v2_1_temp: LrcPtr<Runtime::UH0> = v5_1.clone();
                                        let v3_1_temp: Runtime::US2 = Runtime::US2::US2_2;
                                        v0_1.set(v0_1_temp);
                                        v1_1.set(v1_1_temp);
                                        v2_1.set(v2_1_temp);
                                        v3_1.set(v3_1_temp);
                                        continue '_method5;
                                    } else {
                                        let v0_1_temp: string = v0_1.get().clone();
                                        let v1_1_temp: string =
                                            sprintf!("{}{}", v1_1.get().clone(), v4_1);
                                        let v2_1_temp: LrcPtr<Runtime::UH0> = v5_1.clone();
                                        let v3_1_temp: Runtime::US2 = v3_1.get().clone();
                                        v0_1.set(v0_1_temp);
                                        v1_1.set(v1_1_temp);
                                        v2_1.set(v2_1_temp);
                                        v3_1.set(v3_1_temp);
                                        continue '_method5;
                                    }
                                }
                                _ => {
                                    let v0_1_temp: string =
                                        sprintf!("{}{}", v0_1.get().clone(), v4_1);
                                    let v1_1_temp: string = v1_1.get().clone();
                                    let v2_1_temp: LrcPtr<Runtime::UH0> = v5_1.clone();
                                    let v3_1_temp: Runtime::US2 = Runtime::US2::US2_2;
                                    v0_1.set(v0_1_temp);
                                    v1_1.set(v1_1_temp);
                                    v2_1.set(v2_1_temp);
                                    v3_1.set(v3_1_temp);
                                    continue '_method5;
                                }
                            }
                        }
                    } else {
                        match &v3_1.get().clone() {
                            Runtime::US2::US2_1(v3_1_1_0) => {
                                if let Runtime::US3::US3_0 = v3_1_1_0 {
                                    if ' ' == v4_1 {
                                        let v0_1_temp: string = v0_1.get().clone();
                                        let v1_1_temp: string = sprintf!("{} ", v1_1.get().clone());
                                        let v2_1_temp: LrcPtr<Runtime::UH0> = v5_1.clone();
                                        let v3_1_temp: Runtime::US2 =
                                            Runtime::US2::US2_1(Runtime::US3::US3_0);
                                        v0_1.set(v0_1_temp);
                                        v1_1.set(v1_1_temp);
                                        v2_1.set(v2_1_temp);
                                        v3_1.set(v3_1_temp);
                                        continue '_method5;
                                    } else {
                                        let v0_1_temp: string = v0_1.get().clone();
                                        let v1_1_temp: string =
                                            sprintf!("{}{}", v1_1.get().clone(), v4_1);
                                        let v2_1_temp: LrcPtr<Runtime::UH0> = v5_1.clone();
                                        let v3_1_temp: Runtime::US2 = v3_1.get().clone();
                                        v0_1.set(v0_1_temp);
                                        v1_1.set(v1_1_temp);
                                        v2_1.set(v2_1_temp);
                                        v3_1.set(v3_1_temp);
                                        continue '_method5;
                                    }
                                } else {
                                    if ' ' == v4_1 {
                                        let v0_1_temp: string = v0_1.get().clone();
                                        let v1_1_temp: string = v1_1.get().clone();
                                        let v2_1_temp: LrcPtr<Runtime::UH0> = v5_1.clone();
                                        let v3_1_temp: Runtime::US2 = Runtime::US2::US2_2;
                                        v0_1.set(v0_1_temp);
                                        v1_1.set(v1_1_temp);
                                        v2_1.set(v2_1_temp);
                                        v3_1.set(v3_1_temp);
                                        continue '_method5;
                                    } else {
                                        let v0_1_temp: string = v0_1.get().clone();
                                        let v1_1_temp: string =
                                            sprintf!("{}{}", v1_1.get().clone(), v4_1);
                                        let v2_1_temp: LrcPtr<Runtime::UH0> = v5_1.clone();
                                        let v3_1_temp: Runtime::US2 = v3_1.get().clone();
                                        v0_1.set(v0_1_temp);
                                        v1_1.set(v1_1_temp);
                                        v2_1.set(v2_1_temp);
                                        v3_1.set(v3_1_temp);
                                        continue '_method5;
                                    }
                                }
                            }
                            Runtime::US2::US2_0 => {
                                if ' ' == v4_1 {
                                    let v0_1_temp: string = v0_1.get().clone();
                                    let v1_1_temp: string = v1_1.get().clone();
                                    let v2_1_temp: LrcPtr<Runtime::UH0> = v5_1.clone();
                                    let v3_1_temp: Runtime::US2 = Runtime::US2::US2_2;
                                    v0_1.set(v0_1_temp);
                                    v1_1.set(v1_1_temp);
                                    v2_1.set(v2_1_temp);
                                    v3_1.set(v3_1_temp);
                                    continue '_method5;
                                } else {
                                    let v0_1_temp: string = v0_1.get().clone();
                                    let v1_1_temp: string =
                                        sprintf!("{}{}", v1_1.get().clone(), v4_1);
                                    let v2_1_temp: LrcPtr<Runtime::UH0> = v5_1;
                                    let v3_1_temp: Runtime::US2 = v3_1.get().clone();
                                    v0_1.set(v0_1_temp);
                                    v1_1.set(v1_1_temp);
                                    v2_1.set(v2_1_temp);
                                    v3_1.set(v3_1_temp);
                                    continue '_method5;
                                }
                            }
                            _ => {
                                let v0_1_temp: string = sprintf!("{}{}", v0_1.get().clone(), v4_1);
                                let v1_1_temp: string = v1_1.get().clone();
                                let v2_1_temp: LrcPtr<Runtime::UH0> = v5_1.clone();
                                let v3_1_temp: Runtime::US2 = Runtime::US2::US2_2;
                                v0_1.set(v0_1_temp);
                                v1_1.set(v1_1_temp);
                                v2_1.set(v2_1_temp);
                                v3_1.set(v3_1_temp);
                                continue '_method5;
                            }
                        }
                    }
                }
            } else {
                match &v3_1.get().clone() {
                    Runtime::US2::US2_1(v3_1_1_0) => {
                        if let Runtime::US3::US3_0 = v3_1_1_0 {
                            (
                                replace(v1_1.get().clone(), string("\\"), string("/")),
                                v0_1.get().clone(),
                            )
                        } else {
                            (
                                replace(v1_1.get().clone(), string("\\"), string("/")),
                                v0_1.get().clone(),
                            )
                        }
                    }
                    Runtime::US2::US2_0 => (
                        replace(v1_1.get().clone(), string("\\"), string("/")),
                        v0_1.get().clone(),
                    ),
                    _ => (
                        replace(v1_1.get().clone(), string("\\"), string("/")),
                        v0_1.get().clone(),
                    ),
                }
            });
        }
    }
    pub fn closure7(unitVar: (), v0_1: string) -> Runtime::US4 {
        Runtime::US4::US4_0(v0_1)
    }
    pub fn method6() -> Func1<string, Runtime::US4> {
        Func1::new(move |v: string| Runtime::closure7((), v))
    }
    pub fn closure8(
        v0_1: Option<CancellationToken>,
        v1_1: string,
        v2_1: Array<(string, string)>,
        v3_1: Option<Func1<(bool, string, i32), Arc<Async<()>>>>,
        v4_1: Option<string>,
        unitVar: (),
    ) -> string {
        sprintf!(
            "execute_with_options_async / options: {:?}",
            (v0_1, v1_1, v2_1, v3_1, v4_1)
        )
    }
    pub fn closure9(unitVar: (), unitVar_1: ()) -> string {
        string("")
    }
    pub fn method7() -> Func0<string> {
        Func0::new(move || Runtime::closure9((), ()))
    }
    pub fn closure11(unitVar: (), v0_1: i64) -> Runtime::US5 {
        Runtime::US5::US5_0(v0_1)
    }
    pub fn method9() -> Func1<i64, Runtime::US5> {
        Func1::new(move |v: i64| Runtime::closure11((), v))
    }
    pub fn method10() -> string {
        string("")
    }
    pub fn closure10(
        v0_1: Runtime::US0,
        v1_1: Func0<string>,
        v2_1: Func0<string>,
        unitVar: (),
    ) -> string {
        if Runtime::State::trace_state().get().clone().is_none() {
            Runtime::State::trace_state().set(Some(Runtime::closure0((), ())));
        }
        {
            let patternInput: (
                LrcPtr<Runtime::Mut0>,
                LrcPtr<Runtime::Mut1>,
                LrcPtr<Runtime::Mut2>,
                Option<i64>,
                LrcPtr<Runtime::Mut3>,
            ) = getValue(Runtime::State::trace_state().get().clone());
            let _v9: MutCell<Option<string>> = MutCell::new(None::<string>);
            let v13: Runtime::US5 = defaultValue(
                Runtime::US5::US5_1,
                map(Runtime::method9(), patternInput.3.clone()),
            );
            let v31: DateTime = match &v13 {
                Runtime::US5::US5_0(v13_0_0) => {
                    let v19: TimeSpan = TimeSpan::new_ticks(
                        {
                            let _arg: DateTime = DateTime::now();
                            _arg.ticks()
                        } - match &v13 {
                            Runtime::US5::US5_0(x) => x.clone(),
                            _ => unreachable!(),
                        },
                    );
                    DateTime::new_ymdhms_milli(
                        1_i32,
                        1_i32,
                        1_i32,
                        v19.hours(),
                        v19.minutes(),
                        v19.seconds(),
                        v19.milliseconds(),
                    )
                }
                _ => DateTime::now(),
            };
            {
                let x: string = v31.toString(string("hh:mm:ss"));
                _v9.set(Some(x))
            }
            {
                let v61: string = getValue(_v9.get().clone());
                let v62: i64 = (patternInput.0.clone()).l0.get().clone();
                let v74: string = padRight(
                    toLower(match &v0_1 {
                        Runtime::US0::US0_1 => string("Debug"),
                        Runtime::US0::US0_2 => string("Info"),
                        Runtime::US0::US0_0 => string("Verbose"),
                        Runtime::US0::US0_3 => string("Warning"),
                        _ => string("Critical"),
                    }),
                    7_i32,
                    ' ',
                );
                let _v75: MutCell<Option<string>> = MutCell::new(None::<string>);
                let v91: &str = match &v0_1 {
                    Runtime::US0::US0_1 => inline_colorization::color_bright_blue,
                    Runtime::US0::US0_2 => inline_colorization::color_bright_green,
                    Runtime::US0::US0_0 => inline_colorization::color_bright_black,
                    Runtime::US0::US0_3 => inline_colorization::color_bright_yellow,
                    _ => inline_colorization::color_bright_red,
                };
                let v93: &str = fable_library_rust::String_::LrcStr::as_str(&v74);
                let v95: &str = inline_colorization::color_reset;
                let v97: string = string("format!(\"{v91}{v93}{v95}\")");
                let v98: std::string::String = format!("{v91}{v93}{v95}");
                {
                    let x_1: string = fable_library_rust::String_::fromString(v98);
                    _v75.set(Some(x_1))
                }
                trimEndChars(
                    trimStartChars(
                        sprintf!(
                            "{} {} #{} {} / {}",
                            v61,
                            getValue(_v75.get().clone()),
                            v62,
                            v1_1(),
                            v2_1()
                        ),
                        new_empty::<char>(),
                    ),
                    new_array(&[' ', '/']),
                )
            }
        }
    }
    pub fn method11(v0_1: Runtime::US0, v1_1: Func0<string>) {
        fn v2_1() -> (
            LrcPtr<Runtime::Mut0>,
            LrcPtr<Runtime::Mut1>,
            LrcPtr<Runtime::Mut2>,
            Option<i64>,
            LrcPtr<Runtime::Mut3>,
        ) {
            Runtime::closure0((), ())
        }
        if Runtime::State::trace_state().get().clone().is_none() {
            Runtime::State::trace_state().set(Some(v2_1()));
        }
        {
            let patternInput: (
                LrcPtr<Runtime::Mut0>,
                LrcPtr<Runtime::Mut1>,
                LrcPtr<Runtime::Mut2>,
                Option<i64>,
                LrcPtr<Runtime::Mut3>,
            ) = getValue(Runtime::State::trace_state().get().clone());
            let v3_1: LrcPtr<Runtime::Mut0> = patternInput.0.clone();
            if Runtime::State::trace_state().get().clone().is_none() {
                Runtime::State::trace_state().set(Some(v2_1()));
            }
            {
                let patternInput_1: (
                    LrcPtr<Runtime::Mut0>,
                    LrcPtr<Runtime::Mut1>,
                    LrcPtr<Runtime::Mut2>,
                    Option<i64>,
                    LrcPtr<Runtime::Mut3>,
                ) = getValue(Runtime::State::trace_state().get().clone());
                let v13: Runtime::US0 = (patternInput_1.2.clone()).l0.get().clone();
                if if (patternInput_1.1.clone()).l0.get().clone() == false {
                    false
                } else {
                    find(
                        v0_1,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Runtime::US0::US0_0, 0_i32)),
                            LrcPtr::new((Runtime::US0::US0_1, 1_i32)),
                            LrcPtr::new((Runtime::US0::US0_2, 2_i32)),
                            LrcPtr::new((Runtime::US0::US0_3, 3_i32)),
                            LrcPtr::new((Runtime::US0::US0_4, 4_i32)),
                        ])))),
                    ) >= find(
                        v13,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Runtime::US0::US0_0, 0_i32)),
                            LrcPtr::new((Runtime::US0::US0_1, 1_i32)),
                            LrcPtr::new((Runtime::US0::US0_2, 2_i32)),
                            LrcPtr::new((Runtime::US0::US0_3, 3_i32)),
                            LrcPtr::new((Runtime::US0::US0_4, 4_i32)),
                        ])))),
                    )
                } {
                    let v21: i64 = v3_1.l0.get().clone() + 1_i64;
                    v3_1.l0.set(v21);
                    {
                        let v22: string = sprintf!("{}", v1_1());
                        let _v23: MutCell<Option<()>> = MutCell::new(None::<()>);
                        println!("{}", v22.clone());
                        _v23.set(Some(()));
                        getValue(_v23.get().clone());
                        ((patternInput.4.clone()).l0.get().clone())(v22)
                    }
                }
            }
        }
    }
    pub fn method8(v0_1: Runtime::US0, v1_1: Func0<string>, v2_1: Func0<string>) {
        Runtime::method11(
            v0_1.clone(),
            Func0::new({
                let v0_1 = v0_1.clone();
                let v1_1 = v1_1.clone();
                let v2_1 = v2_1.clone();
                move || Runtime::closure10(v0_1.clone(), v1_1.clone(), v2_1.clone(), ())
            }),
        );
    }
    pub fn closure13(
        unitVar: (),
        v0_1: Func1<(bool, string, i32), Arc<Async<()>>>,
    ) -> Runtime::US6 {
        Runtime::US6::US6_0(v0_1)
    }
    pub fn method12() -> Func1<Func1<(bool, string, i32), Arc<Async<()>>>, Runtime::US6> {
        Func1::new(move |v: Func1<(bool, string, i32), Arc<Async<()>>>| Runtime::closure13((), v))
    }
    pub fn closure14(v0_1: string, unitVar: ()) -> string {
        sprintf!("> {}", v0_1)
    }
    pub fn closure12(
        v0_1: Option<CancellationToken>,
        v1_1: string,
        v2_1: Array<(string, string)>,
        v3_1: Option<Func1<(bool, string, i32), Arc<Async<()>>>>,
        v4_1: Option<string>,
        v5_1: (),
        v6_1: LrcPtr<ConcurrentStack_1<string>>,
        v7: (),
    ) {
        let _v8: MutCell<Option<Arc<Async<()>>>> = MutCell::new(None::<Arc<Async<()>>>);
        {
            let x: Arc<Async<()>> = defaultOf();
            _v8.set(Some(x))
        }
        {
            let v33: Arc<Async<()>> = getValue(_v8.get().clone());
            let _v34: MutCell<Option<()>> = MutCell::new(None::<()>);
            defaultOf::<()>();
            _v34.set(Some(()));
            getValue(_v34.get().clone());
            ()
        }
    }
    pub fn closure15(
        v0_1: Option<CancellationToken>,
        v1_1: string,
        v2_1: Array<(string, string)>,
        v3_1: Option<Func1<(bool, string, i32), Arc<Async<()>>>>,
        v4_1: Option<string>,
        v5_1: (),
        v6_1: LrcPtr<ConcurrentStack_1<string>>,
        v7: (),
    ) {
        let _v8: MutCell<Option<Arc<Async<()>>>> = MutCell::new(None::<Arc<Async<()>>>);
        {
            let x: Arc<Async<()>> = defaultOf();
            _v8.set(Some(x))
        }
        {
            let v34: Arc<Async<()>> = getValue(_v8.get().clone());
            let _v35: MutCell<Option<()>> = MutCell::new(None::<()>);
            defaultOf::<()>();
            _v35.set(Some(()));
            getValue(_v35.get().clone());
            ()
        }
    }
    pub fn closure16(unitVar: (), v0_1: CancellationToken) -> Runtime::US7 {
        Runtime::US7::US7_0(v0_1)
    }
    pub fn method13() -> Func1<CancellationToken, Runtime::US7> {
        Func1::new(move |v: CancellationToken| Runtime::closure16((), v))
    }
    pub fn closure17(v0_1: (), unitVar: ()) {
        let _v1: MutCell<Option<bool>> = MutCell::new(None::<bool>);
        {
            let x: bool = unbox::<bool>(&defaultOf());
            _v1.set(Some(x))
        }
        if getValue(_v1.get().clone()) == false {
            let _v11: MutCell<Option<()>> = MutCell::new(None::<()>);
            defaultOf::<()>();
            _v11.set(Some(()));
            getValue(_v11.get().clone());
            ()
        }
    }
    pub fn closure18(v0_1: LrcPtr<TaskCanceledException>, unitVar: ()) -> string {
        sprintf!(
            "execute_with_options_async / WaitForExitAsync / ex: {:?}",
            v0_1
        )
    }
    pub fn method14() -> string {
        string("\n")
    }
    pub fn closure19(v0_1: i32, v1_1: string, unitVar: ()) -> string {
        sprintf!(
            "execute_with_options_async / exit_code: {} / output.Length: {}",
            v0_1,
            length(v1_1)
        )
    }
    pub fn closure4(unitVar: (), v0_1: string) -> Arc<Async<(i32, string)>> {
        let _v5: MutCell<Option<Arc<Async<(i32, string)>>>> =
            MutCell::new(None::<Arc<Async<(i32, string)>>>);
        {
            let x: Arc<Async<(i32, string)>> = defaultOf();
            _v5.set(Some(x))
        }
        getValue(_v5.get().clone())
    }
    pub fn closure20(
        unitVar: (),
        _arg: (
            Option<CancellationToken>,
            string,
            Array<(string, string)>,
            Option<Func1<(bool, string, i32), Arc<Async<()>>>>,
            Option<string>,
        ),
    ) -> Arc<Async<(i32, string)>> {
        let _v5: MutCell<Option<Arc<Async<(i32, string)>>>> =
            MutCell::new(None::<Arc<Async<(i32, string)>>>);
        {
            let x: Arc<Async<(i32, string)>> = defaultOf();
            _v5.set(Some(x))
        }
        getValue(_v5.get().clone())
    }
    pub fn closure21(
        unitVar: (),
        v0_1: Func1<LrcPtr<Runtime::Heap0>, LrcPtr<Runtime::Heap0>>,
    ) -> (
        Option<CancellationToken>,
        string,
        Array<(string, string)>,
        Option<Func1<(bool, string, i32), Arc<Async<()>>>>,
        Option<string>,
    ) {
        let v7: LrcPtr<Runtime::Heap0> = v0_1(LrcPtr::new(Runtime::Heap0 {
            l0: None::<CancellationToken>,
            l1: string(""),
            l2: new_empty::<(string, string)>(),
            l3: None::<Func1<(bool, string, i32), Arc<Async<()>>>>,
            l4: None::<string>,
        }));
        (
            v7.l0.clone(),
            v7.l1.clone(),
            v7.l2.clone(),
            v7.l3.clone(),
            v7.l4.clone(),
        )
    }
    pub fn method18(
        v0_1: LrcPtr<Runtime::UH1>,
        v1_1: LrcPtr<Runtime::UH1>,
    ) -> LrcPtr<Runtime::UH1> {
        match v0_1.as_ref() {
            Runtime::UH1::UH1_0 => v1_1.clone(),
            Runtime::UH1::UH1_1(v0_1_1_0, v0_1_1_1) => LrcPtr::new(Runtime::UH1::UH1_1(
                match v0_1.as_ref() {
                    Runtime::UH1::UH1_1(x, _) => x.clone(),
                    _ => unreachable!(),
                },
                Runtime::method18(
                    match v0_1.as_ref() {
                        Runtime::UH1::UH1_1(_, x) => x.clone(),
                        _ => unreachable!(),
                    },
                    v1_1.clone(),
                ),
            )),
        }
    }
    pub fn method17(
        v0_1: string,
        v1_1: LrcPtr<Runtime::UH1>,
        v2_1: LrcPtr<Runtime::UH0>,
        v3_1: Runtime::US8,
    ) -> (LrcPtr<Runtime::UH1>, string) {
        let v0_1: MutCell<string> = MutCell::new(v0_1.clone());
        let v1_1: MutCell<LrcPtr<Runtime::UH1>> = MutCell::new(v1_1.clone());
        let v2_1: MutCell<LrcPtr<Runtime::UH0>> = MutCell::new(v2_1.clone());
        let v3_1: MutCell<Runtime::US8> = MutCell::new(v3_1.clone());
        '_method17: loop {
            break '_method17 (match &v3_1.get().clone() {
                Runtime::US8::US8_1(v3_1_1_0) => {
                    let v105: char = v3_1_1_0.clone();
                    if '\"' == v105 {
                        if let Runtime::UH0::UH0_1(v2_1_1_0, v2_1_1_1) = v2_1.get().clone().as_ref()
                        {
                            let v108: LrcPtr<Runtime::UH0> = match v2_1.get().clone().as_ref() {
                                Runtime::UH0::UH0_1(_, x) => x.clone(),
                                _ => unreachable!(),
                            };
                            let v107: char = match v2_1.get().clone().as_ref() {
                                Runtime::UH0::UH0_1(x, _) => x.clone(),
                                _ => unreachable!(),
                            };
                            if '\"' == v107 {
                                if v3_1.get().clone() == Runtime::US8::US8_1('\\') {
                                    Runtime::method16(
                                        v0_1.get().clone(),
                                        v1_1.get().clone(),
                                        v108.clone(),
                                        v3_1.get().clone(),
                                        Runtime::US8::US8_0,
                                    )
                                } else {
                                    if '\\' == v105 {
                                        if !(v3_1.get().clone() == Runtime::US8::US8_2(0_u8)) {
                                            Runtime::method16(
                                                sprintf!("{}\"", v0_1.get().clone()),
                                                v1_1.get().clone(),
                                                v108.clone(),
                                                v3_1.get().clone(),
                                                Runtime::US8::US8_1('\"'),
                                            )
                                        } else {
                                            if v3_1.get().clone() == Runtime::US8::US8_1('\\') {
                                                Runtime::method16(
                                                    sprintf!("{}\"", v0_1.get().clone()),
                                                    v1_1.get().clone(),
                                                    v108.clone(),
                                                    v3_1.get().clone(),
                                                    Runtime::US8::US8_1('\"'),
                                                )
                                            } else {
                                                Runtime::method16(
                                                    v0_1.get().clone(),
                                                    v1_1.get().clone(),
                                                    v108.clone(),
                                                    v3_1.get().clone(),
                                                    Runtime::US8::US8_0,
                                                )
                                            }
                                        }
                                    } else {
                                        if '\\' == v107 {
                                            Runtime::method16(
                                                v0_1.get().clone(),
                                                v1_1.get().clone(),
                                                v108.clone(),
                                                v3_1.get().clone(),
                                                Runtime::US8::US8_2(1_u8),
                                            )
                                        } else {
                                            if v3_1.get().clone() == Runtime::US8::US8_2(0_u8) {
                                                Runtime::method16(
                                                    sprintf!("{}\"", v0_1.get().clone()),
                                                    v1_1.get().clone(),
                                                    v108.clone(),
                                                    v3_1.get().clone(),
                                                    Runtime::US8::US8_1('\"'),
                                                )
                                            } else {
                                                Runtime::method16(
                                                    string(""),
                                                    Runtime::method18(
                                                        v1_1.get().clone(),
                                                        LrcPtr::new(Runtime::UH1::UH1_1(
                                                            v0_1.get().clone(),
                                                            LrcPtr::new(Runtime::UH1::UH1_0),
                                                        )),
                                                    ),
                                                    v108.clone(),
                                                    v3_1.get().clone(),
                                                    Runtime::US8::US8_0,
                                                )
                                            }
                                        }
                                    }
                                }
                            } else {
                                if '\\' == v105 {
                                    if '\\' == v107 {
                                        Runtime::method16(
                                            v0_1.get().clone(),
                                            v1_1.get().clone(),
                                            v108.clone(),
                                            v3_1.get().clone(),
                                            Runtime::US8::US8_2(1_u8),
                                        )
                                    } else {
                                        if ' ' == v107 {
                                            let v0_1_temp: string =
                                                sprintf!("{} ", v0_1.get().clone());
                                            let v1_1_temp: LrcPtr<Runtime::UH1> =
                                                v1_1.get().clone();
                                            let v2_1_temp: LrcPtr<Runtime::UH0> = v108.clone();
                                            let v3_1_temp: Runtime::US8 = v3_1.get().clone();
                                            v0_1.set(v0_1_temp);
                                            v1_1.set(v1_1_temp);
                                            v2_1.set(v2_1_temp);
                                            v3_1.set(v3_1_temp);
                                            continue '_method17;
                                        } else {
                                            let v0_1_temp: string =
                                                sprintf!("{}{}", v0_1.get().clone(), v107);
                                            let v1_1_temp: LrcPtr<Runtime::UH1> =
                                                v1_1.get().clone();
                                            let v2_1_temp: LrcPtr<Runtime::UH0> = v108.clone();
                                            let v3_1_temp: Runtime::US8 = v3_1.get().clone();
                                            v0_1.set(v0_1_temp);
                                            v1_1.set(v1_1_temp);
                                            v2_1.set(v2_1_temp);
                                            v3_1.set(v3_1_temp);
                                            continue '_method17;
                                        }
                                    }
                                } else {
                                    if '\\' == v107 {
                                        Runtime::method16(
                                            v0_1.get().clone(),
                                            v1_1.get().clone(),
                                            v108,
                                            v3_1.get().clone(),
                                            Runtime::US8::US8_2(1_u8),
                                        )
                                    } else {
                                        if ' ' == v107 {
                                            let v0_1_temp: string =
                                                sprintf!("{} ", v0_1.get().clone());
                                            let v1_1_temp: LrcPtr<Runtime::UH1> =
                                                v1_1.get().clone();
                                            let v2_1_temp: LrcPtr<Runtime::UH0> = v108.clone();
                                            let v3_1_temp: Runtime::US8 = v3_1.get().clone();
                                            v0_1.set(v0_1_temp);
                                            v1_1.set(v1_1_temp);
                                            v2_1.set(v2_1_temp);
                                            v3_1.set(v3_1_temp);
                                            continue '_method17;
                                        } else {
                                            let v0_1_temp: string =
                                                sprintf!("{}{}", v0_1.get().clone(), v107);
                                            let v1_1_temp: LrcPtr<Runtime::UH1> =
                                                v1_1.get().clone();
                                            let v2_1_temp: LrcPtr<Runtime::UH0> = v108.clone();
                                            let v3_1_temp: Runtime::US8 = v3_1.get().clone();
                                            v0_1.set(v0_1_temp);
                                            v1_1.set(v1_1_temp);
                                            v2_1.set(v2_1_temp);
                                            v3_1.set(v3_1_temp);
                                            continue '_method17;
                                        }
                                    }
                                }
                            }
                        } else {
                            if '\\' == v105 {
                                (
                                    if v0_1.get().clone() == string("") {
                                        v1_1.get().clone()
                                    } else {
                                        Runtime::method18(
                                            v1_1.get().clone(),
                                            LrcPtr::new(Runtime::UH1::UH1_1(
                                                v0_1.get().clone(),
                                                LrcPtr::new(Runtime::UH1::UH1_0),
                                            )),
                                        )
                                    },
                                    v0_1.get().clone(),
                                )
                            } else {
                                (
                                    if v0_1.get().clone() == string("") {
                                        v1_1.get().clone()
                                    } else {
                                        Runtime::method18(
                                            v1_1.get().clone(),
                                            LrcPtr::new(Runtime::UH1::UH1_1(
                                                v0_1.get().clone(),
                                                LrcPtr::new(Runtime::UH1::UH1_0),
                                            )),
                                        )
                                    },
                                    v0_1.get().clone(),
                                )
                            }
                        }
                    } else {
                        if '\\' == v105 {
                            if let Runtime::UH0::UH0_1(v2_1_1_0, v2_1_1_1) =
                                v2_1.get().clone().as_ref()
                            {
                                let v220: LrcPtr<Runtime::UH0> = match v2_1.get().clone().as_ref() {
                                    Runtime::UH0::UH0_1(_, x) => x.clone(),
                                    _ => unreachable!(),
                                };
                                let v219: char = match v2_1.get().clone().as_ref() {
                                    Runtime::UH0::UH0_1(x, _) => x.clone(),
                                    _ => unreachable!(),
                                };
                                if '\"' == v219 {
                                    if !(v3_1.get().clone() == Runtime::US8::US8_2(0_u8)) {
                                        Runtime::method16(
                                            sprintf!("{}\"", v0_1.get().clone()),
                                            v1_1.get().clone(),
                                            v220.clone(),
                                            v3_1.get().clone(),
                                            Runtime::US8::US8_1('\"'),
                                        )
                                    } else {
                                        if v3_1.get().clone() == Runtime::US8::US8_1('\\') {
                                            Runtime::method16(
                                                sprintf!("{}\"", v0_1.get().clone()),
                                                v1_1.get().clone(),
                                                v220.clone(),
                                                v3_1.get().clone(),
                                                Runtime::US8::US8_1('\"'),
                                            )
                                        } else {
                                            Runtime::method16(
                                                v0_1.get().clone(),
                                                v1_1.get().clone(),
                                                v220.clone(),
                                                v3_1.get().clone(),
                                                Runtime::US8::US8_0,
                                            )
                                        }
                                    }
                                } else {
                                    if '\\' == v219 {
                                        Runtime::method16(
                                            v0_1.get().clone(),
                                            v1_1.get().clone(),
                                            v220.clone(),
                                            v3_1.get().clone(),
                                            Runtime::US8::US8_2(1_u8),
                                        )
                                    } else {
                                        if ' ' == v219 {
                                            let v0_1_temp: string =
                                                sprintf!("{} ", v0_1.get().clone());
                                            let v1_1_temp: LrcPtr<Runtime::UH1> =
                                                v1_1.get().clone();
                                            let v2_1_temp: LrcPtr<Runtime::UH0> = v220;
                                            let v3_1_temp: Runtime::US8 = v3_1.get().clone();
                                            v0_1.set(v0_1_temp);
                                            v1_1.set(v1_1_temp);
                                            v2_1.set(v2_1_temp);
                                            v3_1.set(v3_1_temp);
                                            continue '_method17;
                                        } else {
                                            let v0_1_temp: string =
                                                sprintf!("{}{}", v0_1.get().clone(), v219);
                                            let v1_1_temp: LrcPtr<Runtime::UH1> =
                                                v1_1.get().clone();
                                            let v2_1_temp: LrcPtr<Runtime::UH0> = v220.clone();
                                            let v3_1_temp: Runtime::US8 = v3_1.get().clone();
                                            v0_1.set(v0_1_temp);
                                            v1_1.set(v1_1_temp);
                                            v2_1.set(v2_1_temp);
                                            v3_1.set(v3_1_temp);
                                            continue '_method17;
                                        }
                                    }
                                }
                            } else {
                                (
                                    if v0_1.get().clone() == string("") {
                                        v1_1.get().clone()
                                    } else {
                                        Runtime::method18(
                                            v1_1.get().clone(),
                                            LrcPtr::new(Runtime::UH1::UH1_1(
                                                v0_1.get().clone(),
                                                LrcPtr::new(Runtime::UH1::UH1_0),
                                            )),
                                        )
                                    },
                                    v0_1.get().clone(),
                                )
                            }
                        } else {
                            if let Runtime::UH0::UH0_1(v2_1_1_0, v2_1_1_1) =
                                v2_1.get().clone().as_ref()
                            {
                                let v270: LrcPtr<Runtime::UH0> = match v2_1.get().clone().as_ref() {
                                    Runtime::UH0::UH0_1(_, x) => x.clone(),
                                    _ => unreachable!(),
                                };
                                let v269: char = match v2_1.get().clone().as_ref() {
                                    Runtime::UH0::UH0_1(x, _) => x.clone(),
                                    _ => unreachable!(),
                                };
                                if '\\' == v269 {
                                    Runtime::method16(
                                        v0_1.get().clone(),
                                        v1_1.get().clone(),
                                        v270.clone(),
                                        v3_1.get().clone(),
                                        Runtime::US8::US8_2(1_u8),
                                    )
                                } else {
                                    if '\"' == v269 {
                                        if v3_1.get().clone() == Runtime::US8::US8_2(0_u8) {
                                            Runtime::method16(
                                                sprintf!("{}\"", v0_1.get().clone()),
                                                v1_1.get().clone(),
                                                v270.clone(),
                                                v3_1.get().clone(),
                                                Runtime::US8::US8_1('\"'),
                                            )
                                        } else {
                                            Runtime::method16(
                                                string(""),
                                                Runtime::method18(
                                                    v1_1.get().clone(),
                                                    LrcPtr::new(Runtime::UH1::UH1_1(
                                                        v0_1.get().clone(),
                                                        LrcPtr::new(Runtime::UH1::UH1_0),
                                                    )),
                                                ),
                                                v270.clone(),
                                                v3_1.get().clone(),
                                                Runtime::US8::US8_0,
                                            )
                                        }
                                    } else {
                                        if ' ' == v269 {
                                            let v0_1_temp: string =
                                                sprintf!("{} ", v0_1.get().clone());
                                            let v1_1_temp: LrcPtr<Runtime::UH1> =
                                                v1_1.get().clone();
                                            let v2_1_temp: LrcPtr<Runtime::UH0> = v270;
                                            let v3_1_temp: Runtime::US8 = v3_1.get().clone();
                                            v0_1.set(v0_1_temp);
                                            v1_1.set(v1_1_temp);
                                            v2_1.set(v2_1_temp);
                                            v3_1.set(v3_1_temp);
                                            continue '_method17;
                                        } else {
                                            let v0_1_temp: string =
                                                sprintf!("{}{}", v0_1.get().clone(), v269);
                                            let v1_1_temp: LrcPtr<Runtime::UH1> =
                                                v1_1.get().clone();
                                            let v2_1_temp: LrcPtr<Runtime::UH0> = v270.clone();
                                            let v3_1_temp: Runtime::US8 = v3_1.get().clone();
                                            v0_1.set(v0_1_temp);
                                            v1_1.set(v1_1_temp);
                                            v2_1.set(v2_1_temp);
                                            v3_1.set(v3_1_temp);
                                            continue '_method17;
                                        }
                                    }
                                }
                            } else {
                                (
                                    if v0_1.get().clone() == string("") {
                                        v1_1.get().clone()
                                    } else {
                                        Runtime::method18(
                                            v1_1.get().clone(),
                                            LrcPtr::new(Runtime::UH1::UH1_1(
                                                v0_1.get().clone(),
                                                LrcPtr::new(Runtime::UH1::UH1_0),
                                            )),
                                        )
                                    },
                                    v0_1.get().clone(),
                                )
                            }
                        }
                    }
                }
                Runtime::US8::US8_0 => {
                    if let Runtime::UH0::UH0_1(v2_1_1_0, v2_1_1_1) = v2_1.get().clone().as_ref() {
                        let v5_1: LrcPtr<Runtime::UH0> = match v2_1.get().clone().as_ref() {
                            Runtime::UH0::UH0_1(_, x) => x.clone(),
                            _ => unreachable!(),
                        };
                        let v4_1: char = match v2_1.get().clone().as_ref() {
                            Runtime::UH0::UH0_1(x, _) => x.clone(),
                            _ => unreachable!(),
                        };
                        if '\"' == v4_1 {
                            Runtime::method16(
                                string(""),
                                v1_1.get().clone(),
                                v5_1.clone(),
                                v3_1.get().clone(),
                                Runtime::US8::US8_1('\"'),
                            )
                        } else {
                            if '\\' == v4_1 {
                                Runtime::method16(
                                    v0_1.get().clone(),
                                    v1_1.get().clone(),
                                    v5_1.clone(),
                                    v3_1.get().clone(),
                                    Runtime::US8::US8_2(0_u8),
                                )
                            } else {
                                if ' ' == v4_1 {
                                    let v0_1_temp: string = string("");
                                    let v1_1_temp: LrcPtr<Runtime::UH1> =
                                        if v0_1.get().clone() == string("") {
                                            v1_1.get().clone()
                                        } else {
                                            Runtime::method18(
                                                v1_1.get().clone(),
                                                LrcPtr::new(Runtime::UH1::UH1_1(
                                                    v0_1.get().clone(),
                                                    LrcPtr::new(Runtime::UH1::UH1_0),
                                                )),
                                            )
                                        };
                                    let v2_1_temp: LrcPtr<Runtime::UH0> = v5_1;
                                    let v3_1_temp: Runtime::US8 = v3_1.get().clone();
                                    v0_1.set(v0_1_temp);
                                    v1_1.set(v1_1_temp);
                                    v2_1.set(v2_1_temp);
                                    v3_1.set(v3_1_temp);
                                    continue '_method17;
                                } else {
                                    let v0_1_temp: string =
                                        sprintf!("{}{}", v0_1.get().clone(), v4_1);
                                    let v1_1_temp: LrcPtr<Runtime::UH1> = v1_1.get().clone();
                                    let v2_1_temp: LrcPtr<Runtime::UH0> = v5_1.clone();
                                    let v3_1_temp: Runtime::US8 = v3_1.get().clone();
                                    v0_1.set(v0_1_temp);
                                    v1_1.set(v1_1_temp);
                                    v2_1.set(v2_1_temp);
                                    v3_1.set(v3_1_temp);
                                    continue '_method17;
                                }
                            }
                        }
                    } else {
                        (
                            if v0_1.get().clone() == string("") {
                                v1_1.get().clone()
                            } else {
                                Runtime::method18(
                                    v1_1.get().clone(),
                                    LrcPtr::new(Runtime::UH1::UH1_1(
                                        v0_1.get().clone(),
                                        LrcPtr::new(Runtime::UH1::UH1_0),
                                    )),
                                )
                            },
                            v0_1.get().clone(),
                        )
                    }
                }
                Runtime::US8::US8_2(v3_1_2_0) => {
                    let v44: u8 = match &v3_1.get().clone() {
                        Runtime::US8::US8_2(x) => x.clone(),
                        _ => unreachable!(),
                    };
                    if let Runtime::UH0::UH0_1(v2_1_1_0, v2_1_1_1) = v2_1.get().clone().as_ref() {
                        let v46: LrcPtr<Runtime::UH0> = match v2_1.get().clone().as_ref() {
                            Runtime::UH0::UH0_1(_, x) => x.clone(),
                            _ => unreachable!(),
                        };
                        let v45: char = match v2_1.get().clone().as_ref() {
                            Runtime::UH0::UH0_1(x, _) => x.clone(),
                            _ => unreachable!(),
                        };
                        if '\\' == v45 {
                            Runtime::method16(
                                v0_1.get().clone(),
                                v1_1.get().clone(),
                                v46.clone(),
                                v3_1.get().clone(),
                                Runtime::US8::US8_1('\\'),
                            )
                        } else {
                            if '\"' == v45 {
                                if if let Runtime::US8::US8_0 = &v3_1.get().clone() {
                                    true
                                } else {
                                    false
                                } {
                                    let v0_1_temp: string = v0_1.get().clone();
                                    let v1_1_temp: LrcPtr<Runtime::UH1> = v1_1.get().clone();
                                    let v2_1_temp: LrcPtr<Runtime::UH0> = v46.clone();
                                    let v3_1_temp: Runtime::US8 = v3_1.get().clone();
                                    v0_1.set(v0_1_temp);
                                    v1_1.set(v1_1_temp);
                                    v2_1.set(v2_1_temp);
                                    v3_1.set(v3_1_temp);
                                    continue '_method17;
                                } else {
                                    Runtime::method16(
                                        sprintf!("{}\"", v0_1.get().clone()),
                                        v1_1.get().clone(),
                                        v46.clone(),
                                        v3_1.get().clone(),
                                        Runtime::US8::US8_2(v44),
                                    )
                                }
                            } else {
                                if ' ' == v45 {
                                    let v0_1_temp: string = sprintf!("{} ", v0_1.get().clone());
                                    let v1_1_temp: LrcPtr<Runtime::UH1> = v1_1.get().clone();
                                    let v2_1_temp: LrcPtr<Runtime::UH0> = v46.clone();
                                    let v3_1_temp: Runtime::US8 = v3_1.get().clone();
                                    v0_1.set(v0_1_temp);
                                    v1_1.set(v1_1_temp);
                                    v2_1.set(v2_1_temp);
                                    v3_1.set(v3_1_temp);
                                    continue '_method17;
                                } else {
                                    if 1_u8 == v44 {
                                        if !(v3_1.get().clone() == v3_1.get().clone()) {
                                            let v0_1_temp: string =
                                                sprintf!("{}\\{}", v0_1.get().clone(), v45);
                                            let v1_1_temp: LrcPtr<Runtime::UH1> =
                                                v1_1.get().clone();
                                            let v2_1_temp: LrcPtr<Runtime::UH0> = v46.clone();
                                            let v3_1_temp: Runtime::US8 = v3_1.get().clone();
                                            v0_1.set(v0_1_temp);
                                            v1_1.set(v1_1_temp);
                                            v2_1.set(v2_1_temp);
                                            v3_1.set(v3_1_temp);
                                            continue '_method17;
                                        } else {
                                            let v0_1_temp: string =
                                                sprintf!("{}{}", v0_1.get().clone(), v45);
                                            let v1_1_temp: LrcPtr<Runtime::UH1> =
                                                v1_1.get().clone();
                                            let v2_1_temp: LrcPtr<Runtime::UH0> = v46.clone();
                                            let v3_1_temp: Runtime::US8 = v3_1.get().clone();
                                            v0_1.set(v0_1_temp);
                                            v1_1.set(v1_1_temp);
                                            v2_1.set(v2_1_temp);
                                            v3_1.set(v3_1_temp);
                                            continue '_method17;
                                        }
                                    } else {
                                        let v0_1_temp: string =
                                            sprintf!("{}{}", v0_1.get().clone(), v45);
                                        let v1_1_temp: LrcPtr<Runtime::UH1> = v1_1.get().clone();
                                        let v2_1_temp: LrcPtr<Runtime::UH0> = v46.clone();
                                        let v3_1_temp: Runtime::US8 = v3_1.get().clone();
                                        v0_1.set(v0_1_temp);
                                        v1_1.set(v1_1_temp);
                                        v2_1.set(v2_1_temp);
                                        v3_1.set(v3_1_temp);
                                        continue '_method17;
                                    }
                                }
                            }
                        }
                    } else {
                        if 1_u8 == v44 {
                            (
                                if v0_1.get().clone() == string("") {
                                    v1_1.get().clone()
                                } else {
                                    Runtime::method18(
                                        v1_1.get().clone(),
                                        LrcPtr::new(Runtime::UH1::UH1_1(
                                            v0_1.get().clone(),
                                            LrcPtr::new(Runtime::UH1::UH1_0),
                                        )),
                                    )
                                },
                                v0_1.get().clone(),
                            )
                        } else {
                            (
                                if v0_1.get().clone() == string("") {
                                    v1_1.get().clone()
                                } else {
                                    Runtime::method18(
                                        v1_1.get().clone(),
                                        LrcPtr::new(Runtime::UH1::UH1_1(
                                            v0_1.get().clone(),
                                            LrcPtr::new(Runtime::UH1::UH1_0),
                                        )),
                                    )
                                },
                                v0_1.get().clone(),
                            )
                        }
                    }
                }
            });
        }
    }
    pub fn method16(
        v0_1: string,
        v1_1: LrcPtr<Runtime::UH1>,
        v2_1: LrcPtr<Runtime::UH0>,
        v3_1: Runtime::US8,
        v4_1: Runtime::US8,
    ) -> (LrcPtr<Runtime::UH1>, string) {
        let v0_1: MutCell<string> = MutCell::new(v0_1.clone());
        let v1_1: MutCell<LrcPtr<Runtime::UH1>> = MutCell::new(v1_1.clone());
        let v2_1: MutCell<LrcPtr<Runtime::UH0>> = MutCell::new(v2_1.clone());
        let v3_1: MutCell<Runtime::US8> = MutCell::new(v3_1.clone());
        let v4_1: MutCell<Runtime::US8> = MutCell::new(v4_1.clone());
        '_method16: loop {
            break '_method16 (match &v4_1.get().clone() {
                Runtime::US8::US8_1(v4_1_1_0) => {
                    let v106: char = v4_1_1_0.clone();
                    if '\"' == v106 {
                        if let Runtime::UH0::UH0_1(v2_1_1_0, v2_1_1_1) = v2_1.get().clone().as_ref()
                        {
                            let v109: LrcPtr<Runtime::UH0> = match v2_1.get().clone().as_ref() {
                                Runtime::UH0::UH0_1(_, x) => x.clone(),
                                _ => unreachable!(),
                            };
                            let v108: char = match v2_1.get().clone().as_ref() {
                                Runtime::UH0::UH0_1(x, _) => x.clone(),
                                _ => unreachable!(),
                            };
                            if '\"' == v108 {
                                if v3_1.get().clone() == Runtime::US8::US8_1('\\') {
                                    let v0_1_temp: string = v0_1.get().clone();
                                    let v1_1_temp: LrcPtr<Runtime::UH1> = v1_1.get().clone();
                                    let v2_1_temp: LrcPtr<Runtime::UH0> = v109.clone();
                                    let v3_1_temp: Runtime::US8 = v4_1.get().clone();
                                    let v4_1_temp: Runtime::US8 = Runtime::US8::US8_0;
                                    v0_1.set(v0_1_temp);
                                    v1_1.set(v1_1_temp);
                                    v2_1.set(v2_1_temp);
                                    v3_1.set(v3_1_temp);
                                    v4_1.set(v4_1_temp);
                                    continue '_method16;
                                } else {
                                    if '\\' == v106 {
                                        if !(v3_1.get().clone() == Runtime::US8::US8_2(0_u8)) {
                                            let v0_1_temp: string =
                                                sprintf!("{}\"", v0_1.get().clone());
                                            let v1_1_temp: LrcPtr<Runtime::UH1> =
                                                v1_1.get().clone();
                                            let v2_1_temp: LrcPtr<Runtime::UH0> = v109.clone();
                                            let v3_1_temp: Runtime::US8 = v4_1.get().clone();
                                            let v4_1_temp: Runtime::US8 = Runtime::US8::US8_1('\"');
                                            v0_1.set(v0_1_temp);
                                            v1_1.set(v1_1_temp);
                                            v2_1.set(v2_1_temp);
                                            v3_1.set(v3_1_temp);
                                            v4_1.set(v4_1_temp);
                                            continue '_method16;
                                        } else {
                                            if v3_1.get().clone() == Runtime::US8::US8_1('\\') {
                                                let v0_1_temp: string =
                                                    sprintf!("{}\"", v0_1.get().clone());
                                                let v1_1_temp: LrcPtr<Runtime::UH1> =
                                                    v1_1.get().clone();
                                                let v2_1_temp: LrcPtr<Runtime::UH0> = v109.clone();
                                                let v3_1_temp: Runtime::US8 = v4_1.get().clone();
                                                let v4_1_temp: Runtime::US8 =
                                                    Runtime::US8::US8_1('\"');
                                                v0_1.set(v0_1_temp);
                                                v1_1.set(v1_1_temp);
                                                v2_1.set(v2_1_temp);
                                                v3_1.set(v3_1_temp);
                                                v4_1.set(v4_1_temp);
                                                continue '_method16;
                                            } else {
                                                let v0_1_temp: string = v0_1.get().clone();
                                                let v1_1_temp: LrcPtr<Runtime::UH1> =
                                                    v1_1.get().clone();
                                                let v2_1_temp: LrcPtr<Runtime::UH0> = v109.clone();
                                                let v3_1_temp: Runtime::US8 = v4_1.get().clone();
                                                let v4_1_temp: Runtime::US8 = Runtime::US8::US8_0;
                                                v0_1.set(v0_1_temp);
                                                v1_1.set(v1_1_temp);
                                                v2_1.set(v2_1_temp);
                                                v3_1.set(v3_1_temp);
                                                v4_1.set(v4_1_temp);
                                                continue '_method16;
                                            }
                                        }
                                    } else {
                                        if '\\' == v108 {
                                            let v0_1_temp: string = v0_1.get().clone();
                                            let v1_1_temp: LrcPtr<Runtime::UH1> =
                                                v1_1.get().clone();
                                            let v2_1_temp: LrcPtr<Runtime::UH0> = v109.clone();
                                            let v3_1_temp: Runtime::US8 = v4_1.get().clone();
                                            let v4_1_temp: Runtime::US8 = Runtime::US8::US8_2(1_u8);
                                            v0_1.set(v0_1_temp);
                                            v1_1.set(v1_1_temp);
                                            v2_1.set(v2_1_temp);
                                            v3_1.set(v3_1_temp);
                                            v4_1.set(v4_1_temp);
                                            continue '_method16;
                                        } else {
                                            if v3_1.get().clone() == Runtime::US8::US8_2(0_u8) {
                                                let v0_1_temp: string =
                                                    sprintf!("{}\"", v0_1.get().clone());
                                                let v1_1_temp: LrcPtr<Runtime::UH1> =
                                                    v1_1.get().clone();
                                                let v2_1_temp: LrcPtr<Runtime::UH0> = v109.clone();
                                                let v3_1_temp: Runtime::US8 = v4_1.get().clone();
                                                let v4_1_temp: Runtime::US8 =
                                                    Runtime::US8::US8_1('\"');
                                                v0_1.set(v0_1_temp);
                                                v1_1.set(v1_1_temp);
                                                v2_1.set(v2_1_temp);
                                                v3_1.set(v3_1_temp);
                                                v4_1.set(v4_1_temp);
                                                continue '_method16;
                                            } else {
                                                let v0_1_temp: string = string("");
                                                let v1_1_temp: LrcPtr<Runtime::UH1> =
                                                    Runtime::method18(
                                                        v1_1.get().clone(),
                                                        LrcPtr::new(Runtime::UH1::UH1_1(
                                                            v0_1.get().clone(),
                                                            LrcPtr::new(Runtime::UH1::UH1_0),
                                                        )),
                                                    );
                                                let v2_1_temp: LrcPtr<Runtime::UH0> = v109.clone();
                                                let v3_1_temp: Runtime::US8 = v4_1.get().clone();
                                                let v4_1_temp: Runtime::US8 = Runtime::US8::US8_0;
                                                v0_1.set(v0_1_temp);
                                                v1_1.set(v1_1_temp);
                                                v2_1.set(v2_1_temp);
                                                v3_1.set(v3_1_temp);
                                                v4_1.set(v4_1_temp);
                                                continue '_method16;
                                            }
                                        }
                                    }
                                }
                            } else {
                                if '\\' == v106 {
                                    if '\\' == v108 {
                                        let v0_1_temp: string = v0_1.get().clone();
                                        let v1_1_temp: LrcPtr<Runtime::UH1> = v1_1.get().clone();
                                        let v2_1_temp: LrcPtr<Runtime::UH0> = v109.clone();
                                        let v3_1_temp: Runtime::US8 = v4_1.get().clone();
                                        let v4_1_temp: Runtime::US8 = Runtime::US8::US8_2(1_u8);
                                        v0_1.set(v0_1_temp);
                                        v1_1.set(v1_1_temp);
                                        v2_1.set(v2_1_temp);
                                        v3_1.set(v3_1_temp);
                                        v4_1.set(v4_1_temp);
                                        continue '_method16;
                                    } else {
                                        if ' ' == v108 {
                                            Runtime::method17(
                                                sprintf!("{} ", v0_1.get().clone()),
                                                v1_1.get().clone(),
                                                v109.clone(),
                                                v4_1.get().clone(),
                                            )
                                        } else {
                                            Runtime::method17(
                                                sprintf!("{}{}", v0_1.get().clone(), v108),
                                                v1_1.get().clone(),
                                                v109.clone(),
                                                v4_1.get().clone(),
                                            )
                                        }
                                    }
                                } else {
                                    if '\\' == v108 {
                                        let v0_1_temp: string = v0_1.get().clone();
                                        let v1_1_temp: LrcPtr<Runtime::UH1> = v1_1.get().clone();
                                        let v2_1_temp: LrcPtr<Runtime::UH0> = v109.clone();
                                        let v3_1_temp: Runtime::US8 = v4_1.get().clone();
                                        let v4_1_temp: Runtime::US8 = Runtime::US8::US8_2(1_u8);
                                        v0_1.set(v0_1_temp);
                                        v1_1.set(v1_1_temp);
                                        v2_1.set(v2_1_temp);
                                        v3_1.set(v3_1_temp);
                                        v4_1.set(v4_1_temp);
                                        continue '_method16;
                                    } else {
                                        if ' ' == v108 {
                                            Runtime::method17(
                                                sprintf!("{} ", v0_1.get().clone()),
                                                v1_1.get().clone(),
                                                v109.clone(),
                                                v4_1.get().clone(),
                                            )
                                        } else {
                                            Runtime::method17(
                                                sprintf!("{}{}", v0_1.get().clone(), v108),
                                                v1_1.get().clone(),
                                                v109.clone(),
                                                v4_1.get().clone(),
                                            )
                                        }
                                    }
                                }
                            }
                        } else {
                            if '\\' == v106 {
                                (
                                    if v0_1.get().clone() == string("") {
                                        v1_1.get().clone()
                                    } else {
                                        Runtime::method18(
                                            v1_1.get().clone(),
                                            LrcPtr::new(Runtime::UH1::UH1_1(
                                                v0_1.get().clone(),
                                                LrcPtr::new(Runtime::UH1::UH1_0),
                                            )),
                                        )
                                    },
                                    v0_1.get().clone(),
                                )
                            } else {
                                (
                                    if v0_1.get().clone() == string("") {
                                        v1_1.get().clone()
                                    } else {
                                        Runtime::method18(
                                            v1_1.get().clone(),
                                            LrcPtr::new(Runtime::UH1::UH1_1(
                                                v0_1.get().clone(),
                                                LrcPtr::new(Runtime::UH1::UH1_0),
                                            )),
                                        )
                                    },
                                    v0_1.get().clone(),
                                )
                            }
                        }
                    } else {
                        if '\\' == v106 {
                            if let Runtime::UH0::UH0_1(v2_1_1_0, v2_1_1_1) =
                                v2_1.get().clone().as_ref()
                            {
                                let v221: LrcPtr<Runtime::UH0> = match v2_1.get().clone().as_ref() {
                                    Runtime::UH0::UH0_1(_, x) => x.clone(),
                                    _ => unreachable!(),
                                };
                                let v220: char = match v2_1.get().clone().as_ref() {
                                    Runtime::UH0::UH0_1(x, _) => x.clone(),
                                    _ => unreachable!(),
                                };
                                if '\"' == v220 {
                                    if !(v3_1.get().clone() == Runtime::US8::US8_2(0_u8)) {
                                        let v0_1_temp: string =
                                            sprintf!("{}\"", v0_1.get().clone());
                                        let v1_1_temp: LrcPtr<Runtime::UH1> = v1_1.get().clone();
                                        let v2_1_temp: LrcPtr<Runtime::UH0> = v221.clone();
                                        let v3_1_temp: Runtime::US8 = v4_1.get().clone();
                                        let v4_1_temp: Runtime::US8 = Runtime::US8::US8_1('\"');
                                        v0_1.set(v0_1_temp);
                                        v1_1.set(v1_1_temp);
                                        v2_1.set(v2_1_temp);
                                        v3_1.set(v3_1_temp);
                                        v4_1.set(v4_1_temp);
                                        continue '_method16;
                                    } else {
                                        if v3_1.get().clone() == Runtime::US8::US8_1('\\') {
                                            let v0_1_temp: string =
                                                sprintf!("{}\"", v0_1.get().clone());
                                            let v1_1_temp: LrcPtr<Runtime::UH1> =
                                                v1_1.get().clone();
                                            let v2_1_temp: LrcPtr<Runtime::UH0> = v221.clone();
                                            let v3_1_temp: Runtime::US8 = v4_1.get().clone();
                                            let v4_1_temp: Runtime::US8 = Runtime::US8::US8_1('\"');
                                            v0_1.set(v0_1_temp);
                                            v1_1.set(v1_1_temp);
                                            v2_1.set(v2_1_temp);
                                            v3_1.set(v3_1_temp);
                                            v4_1.set(v4_1_temp);
                                            continue '_method16;
                                        } else {
                                            let v0_1_temp: string = v0_1.get().clone();
                                            let v1_1_temp: LrcPtr<Runtime::UH1> =
                                                v1_1.get().clone();
                                            let v2_1_temp: LrcPtr<Runtime::UH0> = v221;
                                            let v3_1_temp: Runtime::US8 = v4_1.get().clone();
                                            let v4_1_temp: Runtime::US8 = Runtime::US8::US8_0;
                                            v0_1.set(v0_1_temp);
                                            v1_1.set(v1_1_temp);
                                            v2_1.set(v2_1_temp);
                                            v3_1.set(v3_1_temp);
                                            v4_1.set(v4_1_temp);
                                            continue '_method16;
                                        }
                                    }
                                } else {
                                    if '\\' == v220 {
                                        let v0_1_temp: string = v0_1.get().clone();
                                        let v1_1_temp: LrcPtr<Runtime::UH1> = v1_1.get().clone();
                                        let v2_1_temp: LrcPtr<Runtime::UH0> = v221.clone();
                                        let v3_1_temp: Runtime::US8 = v4_1.get().clone();
                                        let v4_1_temp: Runtime::US8 = Runtime::US8::US8_2(1_u8);
                                        v0_1.set(v0_1_temp);
                                        v1_1.set(v1_1_temp);
                                        v2_1.set(v2_1_temp);
                                        v3_1.set(v3_1_temp);
                                        v4_1.set(v4_1_temp);
                                        continue '_method16;
                                    } else {
                                        if ' ' == v220 {
                                            Runtime::method17(
                                                sprintf!("{} ", v0_1.get().clone()),
                                                v1_1.get().clone(),
                                                v221.clone(),
                                                v4_1.get().clone(),
                                            )
                                        } else {
                                            Runtime::method17(
                                                sprintf!("{}{}", v0_1.get().clone(), v220),
                                                v1_1.get().clone(),
                                                v221.clone(),
                                                v4_1.get().clone(),
                                            )
                                        }
                                    }
                                }
                            } else {
                                (
                                    if v0_1.get().clone() == string("") {
                                        v1_1.get().clone()
                                    } else {
                                        Runtime::method18(
                                            v1_1.get().clone(),
                                            LrcPtr::new(Runtime::UH1::UH1_1(
                                                v0_1.get().clone(),
                                                LrcPtr::new(Runtime::UH1::UH1_0),
                                            )),
                                        )
                                    },
                                    v0_1.get().clone(),
                                )
                            }
                        } else {
                            if let Runtime::UH0::UH0_1(v2_1_1_0, v2_1_1_1) =
                                v2_1.get().clone().as_ref()
                            {
                                let v271: LrcPtr<Runtime::UH0> = match v2_1.get().clone().as_ref() {
                                    Runtime::UH0::UH0_1(_, x) => x.clone(),
                                    _ => unreachable!(),
                                };
                                let v270: char = match v2_1.get().clone().as_ref() {
                                    Runtime::UH0::UH0_1(x, _) => x.clone(),
                                    _ => unreachable!(),
                                };
                                if '\\' == v270 {
                                    let v0_1_temp: string = v0_1.get().clone();
                                    let v1_1_temp: LrcPtr<Runtime::UH1> = v1_1.get().clone();
                                    let v2_1_temp: LrcPtr<Runtime::UH0> = v271.clone();
                                    let v3_1_temp: Runtime::US8 = v4_1.get().clone();
                                    let v4_1_temp: Runtime::US8 = Runtime::US8::US8_2(1_u8);
                                    v0_1.set(v0_1_temp);
                                    v1_1.set(v1_1_temp);
                                    v2_1.set(v2_1_temp);
                                    v3_1.set(v3_1_temp);
                                    v4_1.set(v4_1_temp);
                                    continue '_method16;
                                } else {
                                    if '\"' == v270 {
                                        if v3_1.get().clone() == Runtime::US8::US8_2(0_u8) {
                                            let v0_1_temp: string =
                                                sprintf!("{}\"", v0_1.get().clone());
                                            let v1_1_temp: LrcPtr<Runtime::UH1> =
                                                v1_1.get().clone();
                                            let v2_1_temp: LrcPtr<Runtime::UH0> = v271.clone();
                                            let v3_1_temp: Runtime::US8 = v4_1.get().clone();
                                            let v4_1_temp: Runtime::US8 = Runtime::US8::US8_1('\"');
                                            v0_1.set(v0_1_temp);
                                            v1_1.set(v1_1_temp);
                                            v2_1.set(v2_1_temp);
                                            v3_1.set(v3_1_temp);
                                            v4_1.set(v4_1_temp);
                                            continue '_method16;
                                        } else {
                                            let v0_1_temp: string = string("");
                                            let v1_1_temp: LrcPtr<Runtime::UH1> = Runtime::method18(
                                                v1_1.get().clone(),
                                                LrcPtr::new(Runtime::UH1::UH1_1(
                                                    v0_1.get().clone(),
                                                    LrcPtr::new(Runtime::UH1::UH1_0),
                                                )),
                                            );
                                            let v2_1_temp: LrcPtr<Runtime::UH0> = v271.clone();
                                            let v3_1_temp: Runtime::US8 = v4_1.get().clone();
                                            let v4_1_temp: Runtime::US8 = Runtime::US8::US8_0;
                                            v0_1.set(v0_1_temp);
                                            v1_1.set(v1_1_temp);
                                            v2_1.set(v2_1_temp);
                                            v3_1.set(v3_1_temp);
                                            v4_1.set(v4_1_temp);
                                            continue '_method16;
                                        }
                                    } else {
                                        if ' ' == v270 {
                                            Runtime::method17(
                                                sprintf!("{} ", v0_1.get().clone()),
                                                v1_1.get().clone(),
                                                v271.clone(),
                                                v4_1.get().clone(),
                                            )
                                        } else {
                                            Runtime::method17(
                                                sprintf!("{}{}", v0_1.get().clone(), v270),
                                                v1_1.get().clone(),
                                                v271.clone(),
                                                v4_1.get().clone(),
                                            )
                                        }
                                    }
                                }
                            } else {
                                (
                                    if v0_1.get().clone() == string("") {
                                        v1_1.get().clone()
                                    } else {
                                        Runtime::method18(
                                            v1_1.get().clone(),
                                            LrcPtr::new(Runtime::UH1::UH1_1(
                                                v0_1.get().clone(),
                                                LrcPtr::new(Runtime::UH1::UH1_0),
                                            )),
                                        )
                                    },
                                    v0_1.get().clone(),
                                )
                            }
                        }
                    }
                }
                Runtime::US8::US8_0 => {
                    if let Runtime::UH0::UH0_1(v2_1_1_0, v2_1_1_1) = v2_1.get().clone().as_ref() {
                        let v6_1: LrcPtr<Runtime::UH0> = match v2_1.get().clone().as_ref() {
                            Runtime::UH0::UH0_1(_, x) => x.clone(),
                            _ => unreachable!(),
                        };
                        let v5_1: char = match v2_1.get().clone().as_ref() {
                            Runtime::UH0::UH0_1(x, _) => x.clone(),
                            _ => unreachable!(),
                        };
                        if '\"' == v5_1 {
                            let v0_1_temp: string = string("");
                            let v1_1_temp: LrcPtr<Runtime::UH1> = v1_1.get().clone();
                            let v2_1_temp: LrcPtr<Runtime::UH0> = v6_1.clone();
                            let v3_1_temp: Runtime::US8 = v4_1.get().clone();
                            let v4_1_temp: Runtime::US8 = Runtime::US8::US8_1('\"');
                            v0_1.set(v0_1_temp);
                            v1_1.set(v1_1_temp);
                            v2_1.set(v2_1_temp);
                            v3_1.set(v3_1_temp);
                            v4_1.set(v4_1_temp);
                            continue '_method16;
                        } else {
                            if '\\' == v5_1 {
                                let v0_1_temp: string = v0_1.get().clone();
                                let v1_1_temp: LrcPtr<Runtime::UH1> = v1_1.get().clone();
                                let v2_1_temp: LrcPtr<Runtime::UH0> = v6_1;
                                let v3_1_temp: Runtime::US8 = v4_1.get().clone();
                                let v4_1_temp: Runtime::US8 = Runtime::US8::US8_2(0_u8);
                                v0_1.set(v0_1_temp);
                                v1_1.set(v1_1_temp);
                                v2_1.set(v2_1_temp);
                                v3_1.set(v3_1_temp);
                                v4_1.set(v4_1_temp);
                                continue '_method16;
                            } else {
                                if ' ' == v5_1 {
                                    Runtime::method17(
                                        string(""),
                                        if v0_1.get().clone() == string("") {
                                            v1_1.get().clone()
                                        } else {
                                            Runtime::method18(
                                                v1_1.get().clone(),
                                                LrcPtr::new(Runtime::UH1::UH1_1(
                                                    v0_1.get().clone(),
                                                    LrcPtr::new(Runtime::UH1::UH1_0),
                                                )),
                                            )
                                        },
                                        v6_1.clone(),
                                        v4_1.get().clone(),
                                    )
                                } else {
                                    Runtime::method17(
                                        sprintf!("{}{}", v0_1.get().clone(), v5_1),
                                        v1_1.get().clone(),
                                        v6_1.clone(),
                                        v4_1.get().clone(),
                                    )
                                }
                            }
                        }
                    } else {
                        (
                            if v0_1.get().clone() == string("") {
                                v1_1.get().clone()
                            } else {
                                Runtime::method18(
                                    v1_1.get().clone(),
                                    LrcPtr::new(Runtime::UH1::UH1_1(
                                        v0_1.get().clone(),
                                        LrcPtr::new(Runtime::UH1::UH1_0),
                                    )),
                                )
                            },
                            v0_1.get().clone(),
                        )
                    }
                }
                Runtime::US8::US8_2(v4_1_2_0) => {
                    let v45: u8 = match &v4_1.get().clone() {
                        Runtime::US8::US8_2(x) => x.clone(),
                        _ => unreachable!(),
                    };
                    if let Runtime::UH0::UH0_1(v2_1_1_0, v2_1_1_1) = v2_1.get().clone().as_ref() {
                        let v47: LrcPtr<Runtime::UH0> = match v2_1.get().clone().as_ref() {
                            Runtime::UH0::UH0_1(_, x) => x.clone(),
                            _ => unreachable!(),
                        };
                        let v46: char = match v2_1.get().clone().as_ref() {
                            Runtime::UH0::UH0_1(x, _) => x.clone(),
                            _ => unreachable!(),
                        };
                        if '\\' == v46 {
                            let v0_1_temp: string = v0_1.get().clone();
                            let v1_1_temp: LrcPtr<Runtime::UH1> = v1_1.get().clone();
                            let v2_1_temp: LrcPtr<Runtime::UH0> = v47.clone();
                            let v3_1_temp: Runtime::US8 = v4_1.get().clone();
                            let v4_1_temp: Runtime::US8 = Runtime::US8::US8_1('\\');
                            v0_1.set(v0_1_temp);
                            v1_1.set(v1_1_temp);
                            v2_1.set(v2_1_temp);
                            v3_1.set(v3_1_temp);
                            v4_1.set(v4_1_temp);
                            continue '_method16;
                        } else {
                            if '\"' == v46 {
                                if if let Runtime::US8::US8_0 = &v3_1.get().clone() {
                                    true
                                } else {
                                    false
                                } {
                                    Runtime::method17(
                                        v0_1.get().clone(),
                                        v1_1.get().clone(),
                                        v47.clone(),
                                        v4_1.get().clone(),
                                    )
                                } else {
                                    let v0_1_temp: string = sprintf!("{}\"", v0_1.get().clone());
                                    let v1_1_temp: LrcPtr<Runtime::UH1> = v1_1.get().clone();
                                    let v2_1_temp: LrcPtr<Runtime::UH0> = v47.clone();
                                    let v3_1_temp: Runtime::US8 = v4_1.get().clone();
                                    let v4_1_temp: Runtime::US8 = Runtime::US8::US8_2(v45);
                                    v0_1.set(v0_1_temp);
                                    v1_1.set(v1_1_temp);
                                    v2_1.set(v2_1_temp);
                                    v3_1.set(v3_1_temp);
                                    v4_1.set(v4_1_temp);
                                    continue '_method16;
                                }
                            } else {
                                if ' ' == v46 {
                                    Runtime::method17(
                                        sprintf!("{} ", v0_1.get().clone()),
                                        v1_1.get().clone(),
                                        v47.clone(),
                                        v4_1.get().clone(),
                                    )
                                } else {
                                    if 1_u8 == v45 {
                                        if !(v3_1.get().clone() == v4_1.get().clone()) {
                                            let v0_1_temp: string =
                                                sprintf!("{}\\{}", v0_1.get().clone(), v46);
                                            let v1_1_temp: LrcPtr<Runtime::UH1> =
                                                v1_1.get().clone();
                                            let v2_1_temp: LrcPtr<Runtime::UH0> = v47.clone();
                                            let v3_1_temp: Runtime::US8 = v4_1.get().clone();
                                            let v4_1_temp: Runtime::US8 = v3_1.get().clone();
                                            v0_1.set(v0_1_temp);
                                            v1_1.set(v1_1_temp);
                                            v2_1.set(v2_1_temp);
                                            v3_1.set(v3_1_temp);
                                            v4_1.set(v4_1_temp);
                                            continue '_method16;
                                        } else {
                                            Runtime::method17(
                                                sprintf!("{}{}", v0_1.get().clone(), v46),
                                                v1_1.get().clone(),
                                                v47.clone(),
                                                v4_1.get().clone(),
                                            )
                                        }
                                    } else {
                                        Runtime::method17(
                                            sprintf!("{}{}", v0_1.get().clone(), v46),
                                            v1_1.get().clone(),
                                            v47.clone(),
                                            v4_1.get().clone(),
                                        )
                                    }
                                }
                            }
                        }
                    } else {
                        if 1_u8 == v45 {
                            (
                                if v0_1.get().clone() == string("") {
                                    v1_1.get().clone()
                                } else {
                                    Runtime::method18(
                                        v1_1.get().clone(),
                                        LrcPtr::new(Runtime::UH1::UH1_1(
                                            v0_1.get().clone(),
                                            LrcPtr::new(Runtime::UH1::UH1_0),
                                        )),
                                    )
                                },
                                v0_1.get().clone(),
                            )
                        } else {
                            (
                                if v0_1.get().clone() == string("") {
                                    v1_1.get().clone()
                                } else {
                                    Runtime::method18(
                                        v1_1.get().clone(),
                                        LrcPtr::new(Runtime::UH1::UH1_1(
                                            v0_1.get().clone(),
                                            LrcPtr::new(Runtime::UH1::UH1_0),
                                        )),
                                    )
                                },
                                v0_1.get().clone(),
                            )
                        }
                    }
                }
            });
        }
    }
    pub fn method19(v0_1: LrcPtr<Runtime::UH1>, v1_1: List<string>) -> List<string> {
        match v0_1.as_ref() {
            Runtime::UH1::UH1_0 => v1_1.clone(),
            Runtime::UH1::UH1_1(v0_1_1_0, v0_1_1_1) => cons(
                match v0_1.as_ref() {
                    Runtime::UH1::UH1_1(x, _) => x.clone(),
                    _ => unreachable!(),
                },
                Runtime::method19(
                    match v0_1.as_ref() {
                        Runtime::UH1::UH1_1(_, x) => x.clone(),
                        _ => unreachable!(),
                    },
                    v1_1.clone(),
                ),
            ),
        }
    }
    pub fn method15(v0_1: string) -> Array<string> {
        let _v0: MutCell<Option<Option<string>>> = MutCell::new(None::<Option<string>>);
        _v0.set(Some(Some(v0_1)));
        {
            let v6_1: Option<string> = getValue(_v0.get().clone());
            let v9: Runtime::US4 = defaultValue(Runtime::US4::US4_1, map(Runtime::method6(), v6_1));
            let v12: string = match &v9 {
                Runtime::US4::US4_0(v9_0_0) => match &v9 {
                    Runtime::US4::US4_0(x) => x.clone(),
                    _ => unreachable!(),
                },
                _ => string(""),
            };
            let v13: i32 = length(v12.clone());
            let v14: Array<char> = new_init(&'\u{0000}', v13);
            let v15: LrcPtr<Runtime::Mut4> = LrcPtr::new(Runtime::Mut4 {
                l0: MutCell::new(0_i32),
            });
            while Runtime::method3(v13, v15.clone()) {
                let v17: i32 = v15.l0.get().clone();
                let v18: char = getCharAt(v12.clone(), v17);
                v14.get_mut()[v17 as usize] = v18;
                {
                    let v19: i32 = v17 + 1_i32;
                    v15.l0.set(v19);
                    ()
                }
            }
            {
                let v21: List<char> = ofArray(v14.clone());
                toArray(Runtime::method19(
                    (Runtime::method16(
                        string(""),
                        LrcPtr::new(Runtime::UH1::UH1_0),
                        foldBack(
                            Func2::new(move |b0: char, b1: LrcPtr<Runtime::UH0>| {
                                (Runtime::method4())(b0)(b1)
                            }),
                            v21,
                            LrcPtr::new(Runtime::UH0::UH0_0),
                        ),
                        Runtime::US8::US8_0,
                        Runtime::US8::US8_0,
                    ))
                    .0
                    .clone(),
                    empty::<string>(),
                ))
            }
        }
    }
    pub fn closure22(unitVar: (), v0_1: string) -> Array<string> {
        Runtime::method15(v0_1)
    }
    pub fn v0() -> Func0<(
        LrcPtr<Runtime::Mut0>,
        LrcPtr<Runtime::Mut1>,
        LrcPtr<Runtime::Mut2>,
        Option<i64>,
        LrcPtr<Runtime::Mut3>,
    )> {
        static v0: OnceInit<
            Func0<(
                LrcPtr<Runtime::Mut0>,
                LrcPtr<Runtime::Mut1>,
                LrcPtr<Runtime::Mut2>,
                Option<i64>,
                LrcPtr<Runtime::Mut3>,
            )>,
        > = OnceInit::new();
        v0.get_or_init(|| Func0::new(move || Runtime::closure0((), ())))
            .clone()
    }
    on_startup!(if Runtime::State::trace_state().get().clone().is_none() {
        Runtime::State::trace_state().set(Some((Runtime::v0())()));
    });
    pub fn v1() -> Func0<bool> {
        static v1: OnceInit<Func0<bool>> = OnceInit::new();
        v1.get_or_init(|| Func0::new(move || Runtime::closure2((), ())))
            .clone()
    }
    pub fn is_windows() -> bool {
        (Runtime::v1())()
    }
    pub fn v2() -> Func0<string> {
        static v2: OnceInit<Func0<string>> = OnceInit::new();
        v2.get_or_init(|| Func0::new(move || Runtime::closure3((), ())))
            .clone()
    }
    pub fn get_executable_suffix() -> string {
        (Runtime::v2())()
    }
    pub fn v3() -> Func1<string, Arc<Async<(i32, string)>>> {
        static v3: OnceInit<Func1<string, Arc<Async<(i32, string)>>>> = OnceInit::new();
        v3.get_or_init(|| Func1::new(move |v: string| Runtime::closure4((), v)))
            .clone()
    }
    pub fn execute_async(x: string) -> Arc<Async<(i32, string)>> {
        (Runtime::v3())(x)
    }
    pub fn v4() -> Func1<
        (
            Option<CancellationToken>,
            string,
            Array<(string, string)>,
            Option<Func1<(bool, string, i32), Arc<Async<()>>>>,
            Option<string>,
        ),
        Arc<Async<(i32, string)>>,
    > {
        static v4: OnceInit<
            Func1<
                (
                    Option<CancellationToken>,
                    string,
                    Array<(string, string)>,
                    Option<Func1<(bool, string, i32), Arc<Async<()>>>>,
                    Option<string>,
                ),
                Arc<Async<(i32, string)>>,
            >,
        > = OnceInit::new();
        v4.get_or_init(|| {
            Func1::new(
                move |arg10_0040: (
                    Option<CancellationToken>,
                    string,
                    Array<(string, string)>,
                    Option<Func1<(bool, string, i32), Arc<Async<()>>>>,
                    Option<string>,
                )| Runtime::closure20((), arg10_0040),
            )
        })
        .clone()
    }
    pub fn execute_with_options_async(
        x: (
            Option<CancellationToken>,
            string,
            Array<(string, string)>,
            Option<Func1<(bool, string, i32), Arc<Async<()>>>>,
            Option<string>,
        ),
    ) -> Arc<Async<(i32, string)>> {
        (Runtime::v4())(x)
    }
    pub fn v5() -> Func1<
        Func1<LrcPtr<Runtime::Heap0>, LrcPtr<Runtime::Heap0>>,
        (
            Option<CancellationToken>,
            string,
            Array<(string, string)>,
            Option<Func1<(bool, string, i32), Arc<Async<()>>>>,
            Option<string>,
        ),
    > {
        static v5: OnceInit<
            Func1<
                Func1<LrcPtr<Runtime::Heap0>, LrcPtr<Runtime::Heap0>>,
                (
                    Option<CancellationToken>,
                    string,
                    Array<(string, string)>,
                    Option<Func1<(bool, string, i32), Arc<Async<()>>>>,
                    Option<string>,
                ),
            >,
        > = OnceInit::new();
        v5.get_or_init(|| {
            Func1::new(
                move |v: Func1<LrcPtr<Runtime::Heap0>, LrcPtr<Runtime::Heap0>>| {
                    Runtime::closure21((), v)
                },
            )
        })
        .clone()
    }
    pub fn execution_options(
        x: Func1<LrcPtr<Runtime::Heap0>, LrcPtr<Runtime::Heap0>>,
    ) -> (
        Option<CancellationToken>,
        string,
        Array<(string, string)>,
        Option<Func1<(bool, string, i32), Arc<Async<()>>>>,
        Option<string>,
    ) {
        (Runtime::v5())(x)
    }
    pub fn v6() -> Func1<string, Array<string>> {
        static v6: OnceInit<Func1<string, Array<string>>> = OnceInit::new();
        v6.get_or_init(|| Func1::new(move |v: string| Runtime::closure22((), v)))
            .clone()
    }
    pub fn split_args(x: string) -> Array<string> {
        (Runtime::v6())(x)
    }
    on_startup!(());
}
