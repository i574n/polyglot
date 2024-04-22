pub mod Runtime {
    use super::*;
    type Async<T> = T;
    use fable_library_rust::Interfaces_::System::Collections::Generic::IEnumerable_1;
    use fable_library_rust::List_::ofArray;
    use fable_library_rust::Map_::find;
    use fable_library_rust::Map_::ofSeq;
    use fable_library_rust::NativeArray_::new_array;
    use fable_library_rust::NativeArray_::new_empty;
    use fable_library_rust::Native_::defaultOf;
    use fable_library_rust::Native_::on_startup;
    use fable_library_rust::Native_::unbox;
    use fable_library_rust::Native_::Arc;
    use fable_library_rust::Native_::Func0;
    use fable_library_rust::Native_::Func1;
    use fable_library_rust::Native_::LrcPtr;
    use fable_library_rust::Native_::MutCell;
    use fable_library_rust::Native_::OnceInit;
    use fable_library_rust::Option_::getValue;
    use fable_library_rust::Seq_::ofList;
    use fable_library_rust::String_::length;
    use fable_library_rust::String_::replace;
    use fable_library_rust::String_::sprintf;
    use fable_library_rust::String_::string;
    use fable_library_rust::String_::toLower;
    use fable_library_rust::String_::trimEndChars;
    use fable_library_rust::String_::trimStartChars;
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
        let v5: LrcPtr<Runtime::Mut3> = LrcPtr::new(Runtime::Mut3 {
            l0: MutCell::new(Func1::new(move |v: string| Runtime::closure1((), v))),
        });
        let _v6: MutCell<Option<Option<i64>>> = MutCell::new(None::<Option<i64>>);
        {
            let x: Option<i64> = Runtime::method1(None::<i64>);
            _v6.set(Some(x))
        }
        (v1_1, v0_1, v3_1, getValue(_v6.get().clone()), v5)
    }
    pub fn closure2(unitVar: (), unitVar_1: ()) -> bool {
        let _v0: MutCell<Option<bool>> = MutCell::new(None::<bool>);
        {
            let x: bool = unbox::<bool>(&defaultOf());
            _v0.set(Some(x))
        }
        getValue(_v0.get().clone())
    }
    pub fn closure3(unitVar: (), unitVar_1: ()) -> string {
        let _v0: MutCell<Option<bool>> = MutCell::new(None::<bool>);
        {
            let x: bool = unbox::<bool>(&defaultOf());
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
    pub fn closure6(v0_1: char, v1_1: LrcPtr<Runtime::UH0>) -> LrcPtr<Runtime::UH0> {
        LrcPtr::new(Runtime::UH0::UH0_1(v0_1, v1_1))
    }
    pub fn closure5(unitVar: (), v0_1: char) -> Func1<LrcPtr<Runtime::UH0>, LrcPtr<Runtime::UH0>> {
        Func1::new({
            let v0_1 = v0_1.clone();
            move |v: LrcPtr<Runtime::UH0>| Runtime::closure6(v0_1, v)
        })
    }
    pub fn method3() -> Func1<char, Func1<LrcPtr<Runtime::UH0>, LrcPtr<Runtime::UH0>>> {
        Func1::new(move |v: char| Runtime::closure5((), v))
    }
    pub fn method4(
        v0_1: string,
        v1_1: string,
        v2_1: LrcPtr<Runtime::UH0>,
        v3_1: Runtime::US2,
    ) -> (string, string) {
        let v0_1: MutCell<string> = MutCell::new(v0_1.clone());
        let v1_1: MutCell<string> = MutCell::new(v1_1.clone());
        let v2_1: MutCell<LrcPtr<Runtime::UH0>> = MutCell::new(v2_1.clone());
        let v3_1: MutCell<Runtime::US2> = MutCell::new(v3_1.clone());
        '_method4: loop {
            break '_method4 (if let Runtime::UH0::UH0_1(v2_1_1_0, v2_1_1_1) =
                v2_1.get().clone().as_ref()
            {
                let v5: LrcPtr<Runtime::UH0> = match v2_1.get().clone().as_ref() {
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
                        let v2_1_temp: LrcPtr<Runtime::UH0> = v5.clone();
                        let v3_1_temp: Runtime::US2 = Runtime::US2::US2_1(Runtime::US3::US3_0);
                        v0_1.set(v0_1_temp);
                        v1_1.set(v1_1_temp);
                        v2_1.set(v2_1_temp);
                        v3_1.set(v3_1_temp);
                        continue '_method4;
                    } else {
                        match &v3_1.get().clone() {
                            Runtime::US2::US2_1(v3_1_1_0) => {
                                if let Runtime::US3::US3_0 = v3_1_1_0 {
                                    let v0_1_temp: string = v0_1.get().clone();
                                    let v1_1_temp: string = v1_1.get().clone();
                                    let v2_1_temp: LrcPtr<Runtime::UH0> = v5.clone();
                                    let v3_1_temp: Runtime::US2 =
                                        Runtime::US2::US2_1(Runtime::US3::US3_1);
                                    v0_1.set(v0_1_temp);
                                    v1_1.set(v1_1_temp);
                                    v2_1.set(v2_1_temp);
                                    v3_1.set(v3_1_temp);
                                    continue '_method4;
                                } else {
                                    if ' ' == v4_1 {
                                        let v0_1_temp: string = v0_1.get().clone();
                                        let v1_1_temp: string = v1_1.get().clone();
                                        let v2_1_temp: LrcPtr<Runtime::UH0> = v5.clone();
                                        let v3_1_temp: Runtime::US2 = Runtime::US2::US2_2;
                                        v0_1.set(v0_1_temp);
                                        v1_1.set(v1_1_temp);
                                        v2_1.set(v2_1_temp);
                                        v3_1.set(v3_1_temp);
                                        continue '_method4;
                                    } else {
                                        let v0_1_temp: string = v0_1.get().clone();
                                        let v1_1_temp: string =
                                            sprintf!("{}{}", v1_1.get().clone(), v4_1);
                                        let v2_1_temp: LrcPtr<Runtime::UH0> = v5.clone();
                                        let v3_1_temp: Runtime::US2 = v3_1.get().clone();
                                        v0_1.set(v0_1_temp);
                                        v1_1.set(v1_1_temp);
                                        v2_1.set(v2_1_temp);
                                        v3_1.set(v3_1_temp);
                                        continue '_method4;
                                    }
                                }
                            }
                            Runtime::US2::US2_0 => {
                                if ' ' == v4_1 {
                                    let v0_1_temp: string = v0_1.get().clone();
                                    let v1_1_temp: string = v1_1.get().clone();
                                    let v2_1_temp: LrcPtr<Runtime::UH0> = v5.clone();
                                    let v3_1_temp: Runtime::US2 = Runtime::US2::US2_2;
                                    v0_1.set(v0_1_temp);
                                    v1_1.set(v1_1_temp);
                                    v2_1.set(v2_1_temp);
                                    v3_1.set(v3_1_temp);
                                    continue '_method4;
                                } else {
                                    let v0_1_temp: string = v0_1.get().clone();
                                    let v1_1_temp: string =
                                        sprintf!("{}{}", v1_1.get().clone(), v4_1);
                                    let v2_1_temp: LrcPtr<Runtime::UH0> = v5.clone();
                                    let v3_1_temp: Runtime::US2 = v3_1.get().clone();
                                    v0_1.set(v0_1_temp);
                                    v1_1.set(v1_1_temp);
                                    v2_1.set(v2_1_temp);
                                    v3_1.set(v3_1_temp);
                                    continue '_method4;
                                }
                            }
                            _ => {
                                let v0_1_temp: string = sprintf!("{}{}", v0_1.get().clone(), v4_1);
                                let v1_1_temp: string = v1_1.get().clone();
                                let v2_1_temp: LrcPtr<Runtime::UH0> = v5.clone();
                                let v3_1_temp: Runtime::US2 = Runtime::US2::US2_2;
                                v0_1.set(v0_1_temp);
                                v1_1.set(v1_1_temp);
                                v2_1.set(v2_1_temp);
                                v3_1.set(v3_1_temp);
                                continue '_method4;
                            }
                        }
                    }
                } else {
                    if '\'' == v4_1 {
                        if v1_1.get().clone() == string("") {
                            let v0_1_temp: string = v0_1.get().clone();
                            let v1_1_temp: string = v1_1.get().clone();
                            let v2_1_temp: LrcPtr<Runtime::UH0> = v5.clone();
                            let v3_1_temp: Runtime::US2 = Runtime::US2::US2_1(Runtime::US3::US3_0);
                            v0_1.set(v0_1_temp);
                            v1_1.set(v1_1_temp);
                            v2_1.set(v2_1_temp);
                            v3_1.set(v3_1_temp);
                            continue '_method4;
                        } else {
                            match &v3_1.get().clone() {
                                Runtime::US2::US2_1(v3_1_1_0) => {
                                    if let Runtime::US3::US3_0 = v3_1_1_0 {
                                        let v0_1_temp: string = v0_1.get().clone();
                                        let v1_1_temp: string = v1_1.get().clone();
                                        let v2_1_temp: LrcPtr<Runtime::UH0> = v5.clone();
                                        let v3_1_temp: Runtime::US2 =
                                            Runtime::US2::US2_1(Runtime::US3::US3_1);
                                        v0_1.set(v0_1_temp);
                                        v1_1.set(v1_1_temp);
                                        v2_1.set(v2_1_temp);
                                        v3_1.set(v3_1_temp);
                                        continue '_method4;
                                    } else {
                                        if ' ' == v4_1 {
                                            let v0_1_temp: string = v0_1.get().clone();
                                            let v1_1_temp: string = v1_1.get().clone();
                                            let v2_1_temp: LrcPtr<Runtime::UH0> = v5.clone();
                                            let v3_1_temp: Runtime::US2 = Runtime::US2::US2_2;
                                            v0_1.set(v0_1_temp);
                                            v1_1.set(v1_1_temp);
                                            v2_1.set(v2_1_temp);
                                            v3_1.set(v3_1_temp);
                                            continue '_method4;
                                        } else {
                                            let v0_1_temp: string = v0_1.get().clone();
                                            let v1_1_temp: string =
                                                sprintf!("{}{}", v1_1.get().clone(), v4_1);
                                            let v2_1_temp: LrcPtr<Runtime::UH0> = v5.clone();
                                            let v3_1_temp: Runtime::US2 = v3_1.get().clone();
                                            v0_1.set(v0_1_temp);
                                            v1_1.set(v1_1_temp);
                                            v2_1.set(v2_1_temp);
                                            v3_1.set(v3_1_temp);
                                            continue '_method4;
                                        }
                                    }
                                }
                                Runtime::US2::US2_0 => {
                                    if ' ' == v4_1 {
                                        let v0_1_temp: string = v0_1.get().clone();
                                        let v1_1_temp: string = v1_1.get().clone();
                                        let v2_1_temp: LrcPtr<Runtime::UH0> = v5.clone();
                                        let v3_1_temp: Runtime::US2 = Runtime::US2::US2_2;
                                        v0_1.set(v0_1_temp);
                                        v1_1.set(v1_1_temp);
                                        v2_1.set(v2_1_temp);
                                        v3_1.set(v3_1_temp);
                                        continue '_method4;
                                    } else {
                                        let v0_1_temp: string = v0_1.get().clone();
                                        let v1_1_temp: string =
                                            sprintf!("{}{}", v1_1.get().clone(), v4_1);
                                        let v2_1_temp: LrcPtr<Runtime::UH0> = v5.clone();
                                        let v3_1_temp: Runtime::US2 = v3_1.get().clone();
                                        v0_1.set(v0_1_temp);
                                        v1_1.set(v1_1_temp);
                                        v2_1.set(v2_1_temp);
                                        v3_1.set(v3_1_temp);
                                        continue '_method4;
                                    }
                                }
                                _ => {
                                    let v0_1_temp: string =
                                        sprintf!("{}{}", v0_1.get().clone(), v4_1);
                                    let v1_1_temp: string = v1_1.get().clone();
                                    let v2_1_temp: LrcPtr<Runtime::UH0> = v5.clone();
                                    let v3_1_temp: Runtime::US2 = Runtime::US2::US2_2;
                                    v0_1.set(v0_1_temp);
                                    v1_1.set(v1_1_temp);
                                    v2_1.set(v2_1_temp);
                                    v3_1.set(v3_1_temp);
                                    continue '_method4;
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
                                        let v2_1_temp: LrcPtr<Runtime::UH0> = v5.clone();
                                        let v3_1_temp: Runtime::US2 =
                                            Runtime::US2::US2_1(Runtime::US3::US3_0);
                                        v0_1.set(v0_1_temp);
                                        v1_1.set(v1_1_temp);
                                        v2_1.set(v2_1_temp);
                                        v3_1.set(v3_1_temp);
                                        continue '_method4;
                                    } else {
                                        let v0_1_temp: string = v0_1.get().clone();
                                        let v1_1_temp: string =
                                            sprintf!("{}{}", v1_1.get().clone(), v4_1);
                                        let v2_1_temp: LrcPtr<Runtime::UH0> = v5.clone();
                                        let v3_1_temp: Runtime::US2 = v3_1.get().clone();
                                        v0_1.set(v0_1_temp);
                                        v1_1.set(v1_1_temp);
                                        v2_1.set(v2_1_temp);
                                        v3_1.set(v3_1_temp);
                                        continue '_method4;
                                    }
                                } else {
                                    if ' ' == v4_1 {
                                        let v0_1_temp: string = v0_1.get().clone();
                                        let v1_1_temp: string = v1_1.get().clone();
                                        let v2_1_temp: LrcPtr<Runtime::UH0> = v5.clone();
                                        let v3_1_temp: Runtime::US2 = Runtime::US2::US2_2;
                                        v0_1.set(v0_1_temp);
                                        v1_1.set(v1_1_temp);
                                        v2_1.set(v2_1_temp);
                                        v3_1.set(v3_1_temp);
                                        continue '_method4;
                                    } else {
                                        let v0_1_temp: string = v0_1.get().clone();
                                        let v1_1_temp: string =
                                            sprintf!("{}{}", v1_1.get().clone(), v4_1);
                                        let v2_1_temp: LrcPtr<Runtime::UH0> = v5.clone();
                                        let v3_1_temp: Runtime::US2 = v3_1.get().clone();
                                        v0_1.set(v0_1_temp);
                                        v1_1.set(v1_1_temp);
                                        v2_1.set(v2_1_temp);
                                        v3_1.set(v3_1_temp);
                                        continue '_method4;
                                    }
                                }
                            }
                            Runtime::US2::US2_0 => {
                                if ' ' == v4_1 {
                                    let v0_1_temp: string = v0_1.get().clone();
                                    let v1_1_temp: string = v1_1.get().clone();
                                    let v2_1_temp: LrcPtr<Runtime::UH0> = v5.clone();
                                    let v3_1_temp: Runtime::US2 = Runtime::US2::US2_2;
                                    v0_1.set(v0_1_temp);
                                    v1_1.set(v1_1_temp);
                                    v2_1.set(v2_1_temp);
                                    v3_1.set(v3_1_temp);
                                    continue '_method4;
                                } else {
                                    let v0_1_temp: string = v0_1.get().clone();
                                    let v1_1_temp: string =
                                        sprintf!("{}{}", v1_1.get().clone(), v4_1);
                                    let v2_1_temp: LrcPtr<Runtime::UH0> = v5;
                                    let v3_1_temp: Runtime::US2 = v3_1.get().clone();
                                    v0_1.set(v0_1_temp);
                                    v1_1.set(v1_1_temp);
                                    v2_1.set(v2_1_temp);
                                    v3_1.set(v3_1_temp);
                                    continue '_method4;
                                }
                            }
                            _ => {
                                let v0_1_temp: string = sprintf!("{}{}", v0_1.get().clone(), v4_1);
                                let v1_1_temp: string = v1_1.get().clone();
                                let v2_1_temp: LrcPtr<Runtime::UH0> = v5.clone();
                                let v3_1_temp: Runtime::US2 = Runtime::US2::US2_2;
                                v0_1.set(v0_1_temp);
                                v1_1.set(v1_1_temp);
                                v2_1.set(v2_1_temp);
                                v3_1.set(v3_1_temp);
                                continue '_method4;
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
    pub fn method5() -> Func1<string, Runtime::US4> {
        Func1::new(move |v: string| Runtime::closure7((), v))
    }
    pub fn closure8(
        v0_1: Option<CancellationToken>,
        v1_1: string,
        v2_1: Option<Func1<(bool, string, i32), Arc<Async<()>>>>,
        v3_1: Option<string>,
        unitVar: (),
    ) -> string {
        sprintf!(
            "execute_with_options_async / options: {:?}",
            (v0_1, v1_1, v2_1, v3_1)
        )
    }
    pub fn closure9(unitVar: (), unitVar_1: ()) -> string {
        string("")
    }
    pub fn method6() -> Func0<string> {
        Func0::new(move || Runtime::closure9((), ()))
    }
    pub fn closure11(unitVar: (), v0_1: i64) -> Runtime::US5 {
        Runtime::US5::US5_0(v0_1)
    }
    pub fn method8() -> Func1<i64, Runtime::US5> {
        Func1::new(move |v: i64| Runtime::closure11((), v))
    }
    pub fn method9() -> string {
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
            {
                let x: string = Runtime::method9();
                _v9.set(Some(x))
            }
            {
                let v61: string = getValue(_v9.get().clone());
                let v62: i64 = (patternInput.0.clone()).l0.get().clone();
                let v73: string = toLower(match &v0_1 {
                    Runtime::US0::US0_1 => string("Debug"),
                    Runtime::US0::US0_2 => string("Info"),
                    Runtime::US0::US0_0 => string("Verbose"),
                    Runtime::US0::US0_3 => string("Warning"),
                    _ => string("Critical"),
                });
                let _v74: MutCell<Option<string>> = MutCell::new(None::<string>);
                let v138: &str = match &v0_1 {
                    Runtime::US0::US0_1 => inline_colorization::color_bright_blue,
                    Runtime::US0::US0_2 => inline_colorization::color_bright_green,
                    Runtime::US0::US0_0 => inline_colorization::color_bright_black,
                    Runtime::US0::US0_3 => inline_colorization::color_bright_yellow,
                    _ => inline_colorization::color_bright_red,
                };
                let v140: &str = fable_library_rust::String_::LrcStr::as_str(&v73);
                let v142: &str = inline_colorization::color_reset;
                let v144: string = string("format!(\"{v138}{v140}{v142}\")");
                let v145: std::string::String = format!("{v138}{v140}{v142}");
                {
                    let x_1: string = fable_library_rust::String_::fromString(v145);
                    _v74.set(Some(x_1))
                }
                trimEndChars(
                    trimStartChars(
                        sprintf!(
                            "{} {} #{} {} / {}",
                            v61,
                            getValue(_v74.get().clone()),
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
    pub fn method10(v0_1: Runtime::US0, v1_1: Func0<string>) {
        let v2_1 = Func0::new(move || Runtime::closure0((), ()));
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
    pub fn method7(v0_1: Runtime::US0, v1_1: Func0<string>, v2_1: Func0<string>) {
        Runtime::method10(
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
    pub fn method11() -> Func1<Func1<(bool, string, i32), Arc<Async<()>>>, Runtime::US6> {
        Func1::new(move |v: Func1<(bool, string, i32), Arc<Async<()>>>| Runtime::closure13((), v))
    }
    pub fn closure14(v0_1: string, unitVar: ()) -> string {
        sprintf!("> {}", v0_1)
    }
    pub fn closure12(
        v0_1: Option<CancellationToken>,
        v1_1: string,
        v2_1: Option<Func1<(bool, string, i32), Arc<Async<()>>>>,
        v3_1: Option<string>,
        v4_1: (),
        v5: LrcPtr<ConcurrentStack_1<string>>,
        v6: (),
    ) {
        let _v7: MutCell<Option<Arc<Async<()>>>> = MutCell::new(None::<Arc<Async<()>>>);
        {
            let x: Arc<Async<()>> = defaultOf();
            _v7.set(Some(x))
        }
        {
            let v32: Arc<Async<()>> = getValue(_v7.get().clone());
            let _v33: MutCell<Option<()>> = MutCell::new(None::<()>);
            defaultOf::<()>();
            _v33.set(Some(()));
            getValue(_v33.get().clone());
            ()
        }
    }
    pub fn closure15(
        v0_1: Option<CancellationToken>,
        v1_1: string,
        v2_1: Option<Func1<(bool, string, i32), Arc<Async<()>>>>,
        v3_1: Option<string>,
        v4_1: (),
        v5: LrcPtr<ConcurrentStack_1<string>>,
        v6: (),
    ) {
        let _v7: MutCell<Option<Arc<Async<()>>>> = MutCell::new(None::<Arc<Async<()>>>);
        {
            let x: Arc<Async<()>> = defaultOf();
            _v7.set(Some(x))
        }
        {
            let v33: Arc<Async<()>> = getValue(_v7.get().clone());
            let _v34: MutCell<Option<()>> = MutCell::new(None::<()>);
            defaultOf::<()>();
            _v34.set(Some(()));
            getValue(_v34.get().clone());
            ()
        }
    }
    pub fn closure16(unitVar: (), v0_1: CancellationToken) -> Runtime::US7 {
        Runtime::US7::US7_0(v0_1)
    }
    pub fn method12() -> Func1<CancellationToken, Runtime::US7> {
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
    pub fn method13() -> string {
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
        let _v4: MutCell<Option<Arc<Async<(i32, string)>>>> =
            MutCell::new(None::<Arc<Async<(i32, string)>>>);
        {
            let x: Arc<Async<(i32, string)>> = defaultOf();
            _v4.set(Some(x))
        }
        getValue(_v4.get().clone())
    }
    pub fn closure20(
        unitVar: (),
        _arg: (
            Option<CancellationToken>,
            string,
            Option<Func1<(bool, string, i32), Arc<Async<()>>>>,
            Option<string>,
        ),
    ) -> Arc<Async<(i32, string)>> {
        let _v4: MutCell<Option<Arc<Async<(i32, string)>>>> =
            MutCell::new(None::<Arc<Async<(i32, string)>>>);
        {
            let x: Arc<Async<(i32, string)>> = defaultOf();
            _v4.set(Some(x))
        }
        getValue(_v4.get().clone())
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
            Option<Func1<(bool, string, i32), Arc<Async<()>>>>,
            Option<string>,
        ),
    ) -> Arc<Async<(i32, string)>> {
        (Runtime::v4())(x)
    }
    on_startup!(());
}
