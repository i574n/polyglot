#![allow(dead_code)]
#![allow(non_camel_case_types)]
#![allow(non_snake_case)]
#![allow(non_upper_case_globals)]
#![allow(unreachable_code)]
#![allow(unused_attributes)]
#![allow(unused_imports)]
#![allow(unused_macros)]
#![allow(unused_parens)]
#![allow(unused_variables)]
use fable_library_rust::NativeArray_::array_from;
use fable_library_rust::String_::fromString;
pub mod Dice {
    use super::*;
    use fable_library_rust::NativeArray_::Array;
    use fable_library_rust::Native_::on_startup;
    use fable_library_rust::Native_::Any;
    use fable_library_rust::Native_::Func0;
    use fable_library_rust::Native_::Func1;
    use fable_library_rust::Native_::LrcPtr;
    use fable_library_rust::Native_::MutCell;
    use fable_library_rust::String_::sprintf;
    use fable_library_rust::String_::string;
    #[derive(Clone, Debug)]
    pub enum UH0 {
        UH0_0(u64, Func0<LrcPtr<Dice::UH0>>),
        UH0_1,
    }
    impl core::fmt::Display for Dice::UH0 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Debug, PartialEq, PartialOrd, Hash, Eq, Ord)]
    pub enum UH1 {
        UH1_0(u64, LrcPtr<Dice::UH1>),
        UH1_1,
    }
    impl core::fmt::Display for Dice::UH1 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Debug)]
    pub enum US0 {
        US0_0(LrcPtr<Dice::UH0>),
        US0_1(Func0<LrcPtr<Dice::UH0>>),
    }
    impl core::fmt::Display for Dice::US0 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Debug)]
    pub struct Mut0 {
        pub l0: MutCell<Dice::US0>,
    }
    impl core::fmt::Display for Dice::Mut0 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Debug, Default, PartialEq, PartialOrd, Hash, Eq, Ord)]
    pub struct Mut1 {
        pub l0: MutCell<i32>,
    }
    impl core::fmt::Display for Dice::Mut1 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Copy, Debug, PartialEq, PartialOrd, Hash, Eq, Ord)]
    pub enum US1 {
        US1_0,
        US1_1(u64),
    }
    impl core::fmt::Display for Dice::US1 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Debug)]
    pub enum US2 {
        US2_0,
        US2_1(Func1<string, ()>),
    }
    impl core::fmt::Display for Dice::US2 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Debug, PartialEq, PartialOrd, Hash, Eq, Ord)]
    pub enum US3 {
        US3_0,
        US3_1(u64, LrcPtr<Dice::UH1>),
    }
    impl core::fmt::Display for Dice::US3 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    pub fn closure2(v0: LrcPtr<Dice::UH0>, unitVar: ()) -> LrcPtr<Dice::UH0> {
        v0
    }
    pub fn method1(v0: u64, v1: LrcPtr<Dice::UH0>, v2: LrcPtr<Dice::UH0>) -> LrcPtr<Dice::UH0> {
        match v1.as_ref() {
            Dice::UH0::UH0_1 => v2.clone(),
            Dice::UH0::UH0_0(v1_0_0, v1_0_1) => {
                let v6: LrcPtr<Dice::UH0> = Dice::method1(v0, (v1_0_1)(), v2.clone());
                LrcPtr::new(Dice::UH0::UH0_0(
                    (v1_0_0.clone() - 1_u64 + v0) % v0 + 1_u64,
                    Func0::new({
                        let v6 = v6.clone();
                        move || Dice::closure2(v6.clone(), ())
                    }),
                ))
            }
        }
    }
    pub fn closure1(v0: u64, v1: LrcPtr<Dice::UH0>) -> LrcPtr<Dice::UH0> {
        Dice::method1(v0, v1, LrcPtr::new(Dice::UH0::UH0_1))
    }
    pub fn closure0(unitVar: (), v0: u64) -> Func1<LrcPtr<Dice::UH0>, LrcPtr<Dice::UH0>> {
        Func1::new({
            let v0 = v0.clone();
            move |v: LrcPtr<Dice::UH0>| Dice::closure1(v0, v)
        })
    }
    pub fn method2(v0: LrcPtr<Dice::UH1>, v1: LrcPtr<Dice::UH1>) -> LrcPtr<Dice::UH1> {
        let v0: MutCell<LrcPtr<Dice::UH1>> = MutCell::new(v0.clone());
        let v1: MutCell<LrcPtr<Dice::UH1>> = MutCell::new(v1.clone());
        '_method2: loop {
            break '_method2 (match v0.get().as_ref() {
                Dice::UH1::UH1_1 => v1.get(),
                Dice::UH1::UH1_0(v0_0_0, v0_0_1) => {
                    let v0_temp: LrcPtr<Dice::UH1> = v0_0_1.clone();
                    let v1_temp: LrcPtr<Dice::UH1> =
                        LrcPtr::new(Dice::UH1::UH1_0(v0_0_0.clone(), v1.get()));
                    v0.set(v0_temp);
                    v1.set(v1_temp);
                    continue '_method2;
                }
            });
        }
    }
    pub fn method3(v0: LrcPtr<Dice::UH1>, v1: LrcPtr<Dice::UH1>) -> LrcPtr<Dice::UH1> {
        match v0.as_ref() {
            Dice::UH1::UH1_1 => v1.clone(),
            Dice::UH1::UH1_0(v0_0_0, v0_0_1) => LrcPtr::new(Dice::UH1::UH1_0(
                v0_0_0.clone(),
                Dice::method3(v0_0_1.clone(), v1.clone()),
            )),
        }
    }
    pub fn closure4(v0: LrcPtr<Dice::UH0>, unitVar: ()) -> LrcPtr<Dice::UH0> {
        v0
    }
    pub fn method4(v0: LrcPtr<Dice::UH1>, v1: LrcPtr<Dice::UH0>) -> LrcPtr<Dice::UH0> {
        match v0.as_ref() {
            Dice::UH1::UH1_1 => v1.clone(),
            Dice::UH1::UH1_0(v0_0_0, v0_0_1) => {
                let v4: LrcPtr<Dice::UH0> = Dice::method4(v0_0_1.clone(), v1.clone());
                LrcPtr::new(Dice::UH0::UH0_0(
                    v0_0_0.clone(),
                    Func0::new({
                        let v4 = v4.clone();
                        move || Dice::closure4(v4.clone(), ())
                    }),
                ))
            }
        }
    }
    pub fn closure5(v0: LrcPtr<Dice::UH0>, unitVar: ()) -> LrcPtr<Dice::UH0> {
        v0
    }
    pub fn closure6(
        v0: LrcPtr<Dice::UH0>,
        v1: LrcPtr<Dice::Mut0>,
        unitVar: (),
    ) -> LrcPtr<Dice::UH0> {
        let v2: Dice::US0 = v1.l0.get().clone();
        match &v2 {
            Dice::US0::US0_1(v2_1_0) => {
                let v5: LrcPtr<Dice::UH0> = (v2_1_0)();
                let v12: LrcPtr<Dice::UH0> = match v5.as_ref() {
                    Dice::UH0::UH0_1 => LrcPtr::new(Dice::UH0::UH0_1),
                    Dice::UH0::UH0_0(v5_0_0, v5_0_1) => LrcPtr::new(Dice::UH0::UH0_0(
                        v5_0_0.clone(),
                        Dice::method5(v0, v5_0_1.clone()),
                    )),
                };
                v1.l0.set(Dice::US0::US0_0(v12.clone()));
                v12
            }
            Dice::US0::US0_0(v2_0_0) => v2_0_0.clone(),
        }
    }
    pub fn method5(
        v0: LrcPtr<Dice::UH0>,
        v1: Func0<LrcPtr<Dice::UH0>>,
    ) -> Func0<LrcPtr<Dice::UH0>> {
        let v3: LrcPtr<Dice::Mut0> = LrcPtr::new(Dice::Mut0 {
            l0: MutCell::new(Dice::US0::US0_1(v1)),
        });
        Func0::new({
            let v0 = v0.clone();
            let v3 = v3.clone();
            move || Dice::closure6(v0.clone(), v3.clone(), ())
        })
    }
    pub fn method7(v0: i32, v1: LrcPtr<Dice::UH0>) -> Dice::US1 {
        let v0: MutCell<i32> = MutCell::new(v0);
        let v1: MutCell<LrcPtr<Dice::UH0>> = MutCell::new(v1.clone());
        '_method7: loop {
            break '_method7 (match v1.get().as_ref() {
                Dice::UH0::UH0_1 => Dice::US1::US1_0,
                Dice::UH0::UH0_0(v1_0_0, v1_0_1) => {
                    if v0.get() <= 0_i32 {
                        Dice::US1::US1_1(v1_0_0.clone())
                    } else {
                        let v0_temp: i32 = v0.get() - 1_i32;
                        let v1_temp: LrcPtr<Dice::UH0> = (v1_0_1)();
                        v0.set(v0_temp);
                        v1.set(v1_temp);
                        continue '_method7;
                    }
                }
            });
        }
    }
    pub fn method6(
        v0: Func0<LrcPtr<Dice::UH0>>,
        v1: LrcPtr<Dice::Mut1>,
        v2: LrcPtr<Dice::Mut1>,
        v3: LrcPtr<Dice::Mut1>,
    ) -> u64 {
        let v0 = MutCell::new(v0.clone());
        let v1: MutCell<LrcPtr<Dice::Mut1>> = MutCell::new(v1.clone());
        let v2: MutCell<LrcPtr<Dice::Mut1>> = MutCell::new(v2.clone());
        let v3: MutCell<LrcPtr<Dice::Mut1>> = MutCell::new(v3.clone());
        '_method6: loop {
            break '_method6 ({
                let v4: LrcPtr<Dice::UH0> = v0();
                let v6: Dice::US1 = Dice::method7(v1.l0.get(), v4);
                match &v6 {
                    Dice::US1::US1_1(v6_1_0) => {
                        let v9: i32 = v1.l0.get() + 1_i32;
                        v1.l0.set(v9);
                        v6_1_0.clone()
                    }
                    _ => {
                        if v3.l0.get() == -1_i32 {
                            let v12: i32 = v1.l0.get();
                            v3.l0.set(v12);
                            ()
                        }
                        {
                            let v18: i32 = if v2.l0.get() >= v3.l0.get() {
                                1_i32
                            } else {
                                v2.l0.get() + 1_i32
                            };
                            v2.l0.set(v18);
                            {
                                let v20: i32 = v2.l0.get() - 1_i32;
                                v1.l0.set(v20);
                                {
                                    let v0_temp = v0.get();
                                    let v1_temp: LrcPtr<Dice::Mut1> = v1.get();
                                    let v2_temp: LrcPtr<Dice::Mut1> = v2.get();
                                    let v3_temp: LrcPtr<Dice::Mut1> = v3.get();
                                    v0.set(v0_temp);
                                    v1.set(v1_temp);
                                    v2.set(v2_temp);
                                    v3.set(v3_temp);
                                    continue '_method6;
                                }
                            }
                        }
                    }
                }
            });
        }
    }
    pub fn closure7(
        v0: Func0<LrcPtr<Dice::UH0>>,
        v1: LrcPtr<Dice::Mut1>,
        v2: LrcPtr<Dice::Mut1>,
        v3: LrcPtr<Dice::Mut1>,
        unitVar: (),
    ) -> u64 {
        Dice::method6(v0, v1, v2, v3)
    }
    pub fn closure3(unitVar: (), v0: LrcPtr<Dice::UH1>) -> Func0<u64> {
        let v5: LrcPtr<Dice::UH0> = Dice::method4(
            Dice::method3(v0.clone(), Dice::method2(v0, LrcPtr::new(Dice::UH1::UH1_1))),
            LrcPtr::new(Dice::UH0::UH0_1),
        );
        let v7 = Dice::method5(
            v5.clone(),
            Func0::new({
                let v5 = v5.clone();
                move || Dice::closure5(v5.clone(), ())
            }),
        );
        let v8: LrcPtr<Dice::Mut1> = LrcPtr::new(Dice::Mut1 {
            l0: MutCell::new(0_i32),
        });
        let v9: LrcPtr<Dice::Mut1> = LrcPtr::new(Dice::Mut1 {
            l0: MutCell::new(1_i32),
        });
        let v10: LrcPtr<Dice::Mut1> = LrcPtr::new(Dice::Mut1 {
            l0: MutCell::new(-1_i32),
        });
        Func0::new({
            let v10 = v10.clone();
            let v7 = v7.clone();
            let v8 = v8.clone();
            let v9 = v9.clone();
            move || Dice::closure7(v7.clone(), v8.clone(), v9.clone(), v10.clone(), ())
        })
    }
    pub fn method8(v0: Dice::US2, v1: u64, v2: i64, v3: u64) -> i64 {
        let v0: MutCell<Dice::US2> = MutCell::new(v0.clone());
        let v1: MutCell<u64> = MutCell::new(v1);
        let v2: MutCell<i64> = MutCell::new(v2);
        let v3: MutCell<u64> = MutCell::new(v3);
        '_method8: loop {
            break '_method8 (if if v3.get() > 0_u64 {
                v3.get() < v1.get()
            } else {
                false
            } {
                let v0_temp: Dice::US2 = v0.get();
                let v1_temp: u64 = v1.get();
                let v2_temp: i64 = v2.get() + 1_i64;
                let v3_temp: u64 = v3.get() * 6_u64;
                v0.set(v0_temp);
                v1.set(v1_temp);
                v2.set(v2_temp);
                v3.set(v3_temp);
                continue '_method8;
            } else {
                let v10: string = sprintf!(
                    "calculate_dice_count / max: {} / n: {} / p: {}",
                    &v1.get(),
                    &v2.get(),
                    &v3.get()
                );
                match &v0.get() {
                    Dice::US2::US2_1(v0_1_0) => (v0_1_0)(v10),
                    _ => (),
                }
                v2.get()
            });
        }
    }
    pub fn closure75(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH0> {
        LrcPtr::new(Dice::UH0::UH0_0(
            0_u64,
            Func0::new(move || Dice::closure75((), ())),
        ))
    }
    pub fn closure74(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH0> {
        LrcPtr::new(Dice::UH0::UH0_0(
            9223372036854775808_u64,
            Func0::new(move || Dice::closure75((), ())),
        ))
    }
    pub fn closure73(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH0> {
        LrcPtr::new(Dice::UH0::UH0_0(
            4611686018427387904_u64,
            Func0::new(move || Dice::closure74((), ())),
        ))
    }
    pub fn closure72(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH0> {
        LrcPtr::new(Dice::UH0::UH0_0(
            6917529027641081856_u64,
            Func0::new(move || Dice::closure73((), ())),
        ))
    }
    pub fn closure71(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH0> {
        LrcPtr::new(Dice::UH0::UH0_0(
            1152921504606846976_u64,
            Func0::new(move || Dice::closure72((), ())),
        ))
    }
    pub fn closure70(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH0> {
        LrcPtr::new(Dice::UH0::UH0_0(
            15564440312192434176_u64,
            Func0::new(move || Dice::closure71((), ())),
        ))
    }
    pub fn closure69(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH0> {
        LrcPtr::new(Dice::UH0::UH0_0(
            11817445422220181504_u64,
            Func0::new(move || Dice::closure70((), ())),
        ))
    }
    pub fn closure68(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH0> {
        LrcPtr::new(Dice::UH0::UH0_0(
            5044031582654955520_u64,
            Func0::new(move || Dice::closure69((), ())),
        ))
    }
    pub fn closure67(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH0> {
        LrcPtr::new(Dice::UH0::UH0_0(
            6989586621679009792_u64,
            Func0::new(move || Dice::closure68((), ())),
        ))
    }
    pub fn closure66(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH0> {
        LrcPtr::new(Dice::UH0::UH0_0(
            16537217831704461312_u64,
            Func0::new(move || Dice::closure67((), ())),
        ))
    }
    pub fn closure65(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH0> {
        LrcPtr::new(Dice::UH0::UH0_0(
            11979575008805519360_u64,
            Func0::new(move || Dice::closure66((), ())),
        ))
    }
    pub fn closure64(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH0> {
        LrcPtr::new(Dice::UH0::UH0_0(
            14294425217273954304_u64,
            Func0::new(move || Dice::closure65((), ())),
        ))
    }
    pub fn closure63(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH0> {
        LrcPtr::new(Dice::UH0::UH0_0(
            2382404202878992384_u64,
            Func0::new(move || Dice::closure64((), ())),
        ))
    }
    pub fn closure62(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH0> {
        LrcPtr::new(Dice::UH0::UH0_0(
            6545982058383015936_u64,
            Func0::new(move || Dice::closure63((), ())),
        ))
    }
    pub fn closure61(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH0> {
        LrcPtr::new(Dice::UH0::UH0_0(
            10314369046585278464_u64,
            Func0::new(move || Dice::closure62((), ())),
        ))
    }
    pub fn closure60(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH0> {
        LrcPtr::new(Dice::UH0::UH0_0(
            4793518853382471680_u64,
            Func0::new(move || Dice::closure61((), ())),
        ))
    }
    pub fn closure59(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH0> {
        LrcPtr::new(Dice::UH0::UH0_0(
            3873377154515337216_u64,
            Func0::new(move || Dice::closure60((), ())),
        ))
    }
    pub fn closure58(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH0> {
        LrcPtr::new(Dice::UH0::UH0_0(
            645562859085889536_u64,
            Func0::new(move || Dice::closure59((), ())),
        ))
    }
    pub fn closure57(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH0> {
        LrcPtr::new(Dice::UH0::UH0_0(
            107593809847648256_u64,
            Func0::new(move || Dice::closure58((), ())),
        ))
    }
    pub fn closure56(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH0> {
        LrcPtr::new(Dice::UH0::UH0_0(
            3092389647259533312_u64,
            Func0::new(move || Dice::closure57((), ())),
        ))
    }
    pub fn closure55(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH0> {
        LrcPtr::new(Dice::UH0::UH0_0(
            9738770311398031360_u64,
            Func0::new(move || Dice::closure56((), ())),
        ))
    }
    pub fn closure54(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH0> {
        LrcPtr::new(Dice::UH0::UH0_0(
            16995415113324298240_u64,
            Func0::new(move || Dice::closure55((), ())),
        ))
    }
    pub fn closure53(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH0> {
        LrcPtr::new(Dice::UH0::UH0_0(
            8981483876790566912_u64,
            Func0::new(move || Dice::closure54((), ())),
        ))
    }
    pub fn closure52(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH0> {
        LrcPtr::new(Dice::UH0::UH0_0(
            13794743361938128896_u64,
            Func0::new(move || Dice::closure53((), ())),
        ))
    }
    pub fn closure51(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH0> {
        LrcPtr::new(Dice::UH0::UH0_0(
            2299123893656354816_u64,
            Func0::new(move || Dice::closure52((), ())),
        ))
    }
    pub fn closure50(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH0> {
        LrcPtr::new(Dice::UH0::UH0_0(
            3457644661227651072_u64,
            Func0::new(move || Dice::closure51((), ())),
        ))
    }
    pub fn closure49(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH0> {
        LrcPtr::new(Dice::UH0::UH0_0(
            576274110204608512_u64,
            Func0::new(move || Dice::closure50((), ())),
        ))
    }
    pub fn closure48(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH0> {
        LrcPtr::new(Dice::UH0::UH0_0(
            6244960376270618624_u64,
            Func0::new(move || Dice::closure49((), ())),
        ))
    }
    pub fn closure47(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH0> {
        LrcPtr::new(Dice::UH0::UH0_0(
            13338656111851470848_u64,
            Func0::new(move || Dice::closure48((), ())),
        ))
    }
    pub fn closure46(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH0> {
        LrcPtr::new(Dice::UH0::UH0_0(
            14520938734448279552_u64,
            Func0::new(move || Dice::closure47((), ())),
        ))
    }
    pub fn closure45(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH0> {
        LrcPtr::new(Dice::UH0::UH0_0(
            14717985838214414336_u64,
            Func0::new(move || Dice::closure46((), ())),
        ))
    }
    pub fn closure44(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH0> {
        LrcPtr::new(Dice::UH0::UH0_0(
            5527454985320660992_u64,
            Func0::new(move || Dice::closure45((), ())),
        ))
    }
    pub fn closure43(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH0> {
        LrcPtr::new(Dice::UH0::UH0_0(
            16293529225644736512_u64,
            Func0::new(move || Dice::closure44((), ())),
        ))
    }
    pub fn closure42(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH0> {
        LrcPtr::new(Dice::UH0::UH0_0(
            11938960241128898560_u64,
            Func0::new(move || Dice::closure43((), ())),
        ))
    }
    pub fn closure41(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH0> {
        LrcPtr::new(Dice::UH0::UH0_0(
            8138741398091333632_u64,
            Func0::new(move || Dice::closure42((), ())),
        ))
    }
    pub fn closure40(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH0> {
        LrcPtr::new(Dice::UH0::UH0_0(
            7505371590918406144_u64,
            Func0::new(move || Dice::closure41((), ())),
        ))
    }
    pub fn closure39(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH0> {
        LrcPtr::new(Dice::UH0::UH0_0(
            16623181993244360704_u64,
            Func0::new(move || Dice::closure40((), ())),
        ))
    }
    pub fn closure38(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH0> {
        LrcPtr::new(Dice::UH0::UH0_0(
            8919445023443910656_u64,
            Func0::new(move || Dice::closure39((), ())),
        ))
    }
    pub fn closure37(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH0> {
        LrcPtr::new(Dice::UH0::UH0_0(
            4561031516192243712_u64,
            Func0::new(move || Dice::closure38((), ())),
        ))
    }
    pub fn closure36(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH0> {
        LrcPtr::new(Dice::UH0::UH0_0(
            9983543956220149760_u64,
            Func0::new(move || Dice::closure37((), ())),
        ))
    }
    pub fn closure35(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH0> {
        LrcPtr::new(Dice::UH0::UH0_0(
            4738381338321616896_u64,
            Func0::new(move || Dice::closure36((), ())),
        ))
    }
    pub fn closure34(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH0> {
        LrcPtr::new(Dice::UH0::UH0_0(
            789730223053602816_u64,
            Func0::new(move || Dice::closure35((), ())),
        ))
    }
    pub fn closure33(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH0> {
        LrcPtr::new(Dice::UH0::UH0_0(
            131621703842267136_u64,
            Func0::new(move || Dice::closure34((), ())),
        ))
    }
    pub fn closure32(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH0> {
        LrcPtr::new(Dice::UH0::UH0_0(
            21936950640377856_u64,
            Func0::new(move || Dice::closure33((), ())),
        ))
    }
    pub fn closure31(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH0> {
        LrcPtr::new(Dice::UH0::UH0_0(
            3656158440062976_u64,
            Func0::new(move || Dice::closure32((), ())),
        ))
    }
    pub fn closure30(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH0> {
        LrcPtr::new(Dice::UH0::UH0_0(
            609359740010496_u64,
            Func0::new(move || Dice::closure31((), ())),
        ))
    }
    pub fn closure29(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH0> {
        LrcPtr::new(Dice::UH0::UH0_0(
            101559956668416_u64,
            Func0::new(move || Dice::closure30((), ())),
        ))
    }
    pub fn closure28(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH0> {
        LrcPtr::new(Dice::UH0::UH0_0(
            16926659444736_u64,
            Func0::new(move || Dice::closure29((), ())),
        ))
    }
    pub fn closure27(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH0> {
        LrcPtr::new(Dice::UH0::UH0_0(
            2821109907456_u64,
            Func0::new(move || Dice::closure28((), ())),
        ))
    }
    pub fn closure26(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH0> {
        LrcPtr::new(Dice::UH0::UH0_0(
            470184984576_u64,
            Func0::new(move || Dice::closure27((), ())),
        ))
    }
    pub fn closure25(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH0> {
        LrcPtr::new(Dice::UH0::UH0_0(
            78364164096_u64,
            Func0::new(move || Dice::closure26((), ())),
        ))
    }
    pub fn closure24(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH0> {
        LrcPtr::new(Dice::UH0::UH0_0(
            13060694016_u64,
            Func0::new(move || Dice::closure25((), ())),
        ))
    }
    pub fn closure23(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH0> {
        LrcPtr::new(Dice::UH0::UH0_0(
            2176782336_u64,
            Func0::new(move || Dice::closure24((), ())),
        ))
    }
    pub fn closure22(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH0> {
        LrcPtr::new(Dice::UH0::UH0_0(
            362797056_u64,
            Func0::new(move || Dice::closure23((), ())),
        ))
    }
    pub fn closure21(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH0> {
        LrcPtr::new(Dice::UH0::UH0_0(
            60466176_u64,
            Func0::new(move || Dice::closure22((), ())),
        ))
    }
    pub fn closure20(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH0> {
        LrcPtr::new(Dice::UH0::UH0_0(
            10077696_u64,
            Func0::new(move || Dice::closure21((), ())),
        ))
    }
    pub fn closure19(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH0> {
        LrcPtr::new(Dice::UH0::UH0_0(
            1679616_u64,
            Func0::new(move || Dice::closure20((), ())),
        ))
    }
    pub fn closure18(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH0> {
        LrcPtr::new(Dice::UH0::UH0_0(
            279936_u64,
            Func0::new(move || Dice::closure19((), ())),
        ))
    }
    pub fn closure17(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH0> {
        LrcPtr::new(Dice::UH0::UH0_0(
            46656_u64,
            Func0::new(move || Dice::closure18((), ())),
        ))
    }
    pub fn closure16(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH0> {
        LrcPtr::new(Dice::UH0::UH0_0(
            7776_u64,
            Func0::new(move || Dice::closure17((), ())),
        ))
    }
    pub fn closure15(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH0> {
        LrcPtr::new(Dice::UH0::UH0_0(
            1296_u64,
            Func0::new(move || Dice::closure16((), ())),
        ))
    }
    pub fn closure14(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH0> {
        LrcPtr::new(Dice::UH0::UH0_0(
            216_u64,
            Func0::new(move || Dice::closure15((), ())),
        ))
    }
    pub fn closure13(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH0> {
        LrcPtr::new(Dice::UH0::UH0_0(
            36_u64,
            Func0::new(move || Dice::closure14((), ())),
        ))
    }
    pub fn closure12(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH0> {
        LrcPtr::new(Dice::UH0::UH0_0(
            6_u64,
            Func0::new(move || Dice::closure13((), ())),
        ))
    }
    pub fn method11(v0: i64, v1: LrcPtr<Dice::UH0>) -> Dice::US1 {
        let v0: MutCell<i64> = MutCell::new(v0);
        let v1: MutCell<LrcPtr<Dice::UH0>> = MutCell::new(v1.clone());
        '_method11: loop {
            break '_method11 (match v1.get().as_ref() {
                Dice::UH0::UH0_1 => Dice::US1::US1_0,
                Dice::UH0::UH0_0(v1_0_0, v1_0_1) => {
                    if v0.get() <= 0_i64 {
                        Dice::US1::US1_1(v1_0_0.clone())
                    } else {
                        let v0_temp: i64 = v0.get() - 1_i64;
                        let v1_temp: LrcPtr<Dice::UH0> = (v1_0_1)();
                        v0.set(v0_temp);
                        v1.set(v1_temp);
                        continue '_method11;
                    }
                }
            });
        }
    }
    pub fn method10(v0: Dice::US2, v1: i64, v2: LrcPtr<Dice::UH1>, v3: u64) -> Dice::US3 {
        let v0: MutCell<Dice::US2> = MutCell::new(v0.clone());
        let v1: MutCell<i64> = MutCell::new(v1);
        let v2: MutCell<LrcPtr<Dice::UH1>> = MutCell::new(v2.clone());
        let v3: MutCell<u64> = MutCell::new(v3);
        '_method10: loop {
            break '_method10 (if v1.get() < 0_i64 {
                let v5: string = sprintf!(
                    "accumulate_dice_rolls / power: {} / acc: {}",
                    &v1.get(),
                    &v3.get()
                );
                match &v0.get() {
                    Dice::US2::US2_1(v0_1_0) => (v0_1_0)(v5),
                    _ => (),
                }
                Dice::US3::US3_1(v3.get() + 1_u64, v2.get())
            } else {
                match v2.get().as_ref() {
                    Dice::UH1::UH1_1 => Dice::US3::US3_0,
                    Dice::UH1::UH1_0(v2_0_0, v2_0_1) => {
                        let v11: LrcPtr<Dice::UH1> = v2_0_1.clone();
                        let v10: u64 = v2_0_0.clone();
                        if v10 > 1_u64 {
                            let v16: Dice::US1 = Dice::method11(
                                v1.get(),
                                LrcPtr::new(Dice::UH0::UH0_0(
                                    1_u64,
                                    Func0::new(move || Dice::closure12((), ())),
                                )),
                            );
                            let v22: u64 = (v10 - 1_u64)
                                * match &v16 {
                                    Dice::US1::US1_1(v16_1_0) => v16_1_0.clone(),
                                    _ => panic!("{}", string("Option does not have a value."),),
                                };
                            let v23: string =
                                         sprintf!("accumulate_dice_rolls / power: {} / acc: {} / roll: {} / value: {}",
                                                  &v1.get(), &v3.get(), &v10,
                                                  &v22);
                            match &v0.get() {
                                Dice::US2::US2_1(v0_1_0) => (v0_1_0)(v23),
                                _ => (),
                            }
                            {
                                let v0_temp: Dice::US2 = v0.get();
                                let v1_temp: i64 = v1.get() - 1_i64;
                                let v2_temp: LrcPtr<Dice::UH1> = v11;
                                let v3_temp: u64 = v3.get() + v22;
                                v0.set(v0_temp);
                                v1.set(v1_temp);
                                v2.set(v2_temp);
                                v3.set(v3_temp);
                                continue '_method10;
                            }
                        } else {
                            let v28: string = sprintf!(
                                "accumulate_dice_rolls / power: {} / acc: {} / roll: {}",
                                &v1.get(),
                                &v3.get(),
                                &v10
                            );
                            match &v0.get() {
                                Dice::US2::US2_1(v0_1_0) => (v0_1_0)(v28),
                                _ => (),
                            }
                            {
                                let v0_temp: Dice::US2 = v0.get();
                                let v1_temp: i64 = v1.get() - 1_i64;
                                let v2_temp: LrcPtr<Dice::UH1> = v11.clone();
                                let v3_temp: u64 = v3.get();
                                v0.set(v0_temp);
                                v1.set(v1_temp);
                                v2.set(v2_temp);
                                v3.set(v3_temp);
                                continue '_method10;
                            }
                        }
                    }
                }
            });
        }
    }
    pub fn method12(v0: i64, v1: Func0<u64>, v2: i64) -> LrcPtr<Dice::UH1> {
        if v2 < v0 {
            LrcPtr::new(Dice::UH1::UH1_0(v1(), Dice::method12(v0, v1, v2 + 1_i64)))
        } else {
            LrcPtr::new(Dice::UH1::UH1_1)
        }
    }
    pub fn method13(
        v0: Dice::US2,
        v1: Func0<u64>,
        v2: bool,
        v3: u64,
        v4: i64,
        v5: LrcPtr<Dice::UH1>,
    ) -> u64 {
        let v0: MutCell<Dice::US2> = MutCell::new(v0.clone());
        let v1 = MutCell::new(v1.clone());
        let v2: MutCell<bool> = MutCell::new(v2);
        let v3: MutCell<u64> = MutCell::new(v3);
        let v4: MutCell<i64> = MutCell::new(v4);
        let v5: MutCell<LrcPtr<Dice::UH1>> = MutCell::new(v5.clone());
        '_method13: loop {
            break '_method13 ({
                let v6: i64 = v4.get() + 1_i64;
                if v4.get() < v6 {
                    Dice::method9(
                        v0.get(),
                        v1.get(),
                        v2.get(),
                        v3.get(),
                        v4.get(),
                        LrcPtr::new(Dice::UH1::UH1_0(v1(), v5.get())),
                        v6,
                    )
                } else {
                    let v12: Dice::US3 = Dice::method10(v0.get(), v4.get(), v5.get(), 0_u64);
                    if let Dice::US3::US3_1(v12_1_0, v12_1_1) = &v12 {
                        let v13: u64 = match &v12 {
                            Dice::US3::US3_1(x, _) => x.clone(),
                            _ => unreachable!(),
                        };
                        if v13 <= v3.get() {
                            v13
                        } else {
                            if v2.get() {
                                let v0_temp: Dice::US2 = v0.get();
                                let v1_temp = v1.get();
                                let v2_temp: bool = v2.get();
                                let v3_temp: u64 = v3.get();
                                let v4_temp: i64 = v4.get();
                                let v5_temp: LrcPtr<Dice::UH1> =
                                    Dice::method12(v4.get(), v1.get(), 0_i64);
                                v0.set(v0_temp);
                                v1.set(v1_temp);
                                v2.set(v2_temp);
                                v3.set(v3_temp);
                                v4.set(v4_temp);
                                v5.set(v5_temp);
                                continue '_method13;
                            } else {
                                Dice::method9(
                                    v0.get(),
                                    v1.get(),
                                    v2.get(),
                                    v3.get(),
                                    v4.get(),
                                    LrcPtr::new(Dice::UH1::UH1_0(v1(), v5.get())),
                                    v6,
                                )
                            }
                        }
                    } else {
                        if v2.get() {
                            let v0_temp: Dice::US2 = v0.get();
                            let v1_temp = v1.get();
                            let v2_temp: bool = v2.get();
                            let v3_temp: u64 = v3.get();
                            let v4_temp: i64 = v4.get();
                            let v5_temp: LrcPtr<Dice::UH1> =
                                Dice::method12(v4.get(), v1.get(), 0_i64);
                            v0.set(v0_temp);
                            v1.set(v1_temp);
                            v2.set(v2_temp);
                            v3.set(v3_temp);
                            v4.set(v4_temp);
                            v5.set(v5_temp);
                            continue '_method13;
                        } else {
                            Dice::method9(
                                v0.get(),
                                v1.get(),
                                v2.get(),
                                v3.get(),
                                v4.get(),
                                LrcPtr::new(Dice::UH1::UH1_0(v1(), v5.get())),
                                v6,
                            )
                        }
                    }
                }
            });
        }
    }
    pub fn method9(
        v0: Dice::US2,
        v1: Func0<u64>,
        v2: bool,
        v3: u64,
        v4: i64,
        v5: LrcPtr<Dice::UH1>,
        v6: i64,
    ) -> u64 {
        let v0: MutCell<Dice::US2> = MutCell::new(v0.clone());
        let v1 = MutCell::new(v1.clone());
        let v2: MutCell<bool> = MutCell::new(v2);
        let v3: MutCell<u64> = MutCell::new(v3);
        let v4: MutCell<i64> = MutCell::new(v4);
        let v5: MutCell<LrcPtr<Dice::UH1>> = MutCell::new(v5.clone());
        let v6: MutCell<i64> = MutCell::new(v6);
        '_method9: loop {
            break '_method9 (if v6.get() < v4.get() + 1_i64 {
                let v0_temp: Dice::US2 = v0.get();
                let v1_temp = v1.get();
                let v2_temp: bool = v2.get();
                let v3_temp: u64 = v3.get();
                let v4_temp: i64 = v4.get();
                let v5_temp: LrcPtr<Dice::UH1> = LrcPtr::new(Dice::UH1::UH1_0(v1(), v5.get()));
                let v6_temp: i64 = v6.get() + 1_i64;
                v0.set(v0_temp);
                v1.set(v1_temp);
                v2.set(v2_temp);
                v3.set(v3_temp);
                v4.set(v4_temp);
                v5.set(v5_temp);
                v6.set(v6_temp);
                continue '_method9;
            } else {
                let v14: Dice::US3 = Dice::method10(v0.get(), v4.get(), v5.get(), 0_u64);
                if let Dice::US3::US3_1(v14_1_0, v14_1_1) = &v14 {
                    let v15: u64 = match &v14 {
                        Dice::US3::US3_1(x, _) => x.clone(),
                        _ => unreachable!(),
                    };
                    if v15 <= v3.get() {
                        v15
                    } else {
                        if v2.get() {
                            Dice::method13(
                                v0.get(),
                                v1.get(),
                                v2.get(),
                                v3.get(),
                                v4.get(),
                                Dice::method12(v4.get(), v1.get(), 0_i64),
                            )
                        } else {
                            let v0_temp: Dice::US2 = v0.get();
                            let v1_temp = v1.get();
                            let v2_temp: bool = v2.get();
                            let v3_temp: u64 = v3.get();
                            let v4_temp: i64 = v4.get();
                            let v5_temp: LrcPtr<Dice::UH1> =
                                LrcPtr::new(Dice::UH1::UH1_0(v1(), v5.get()));
                            let v6_temp: i64 = v6.get() + 1_i64;
                            v0.set(v0_temp);
                            v1.set(v1_temp);
                            v2.set(v2_temp);
                            v3.set(v3_temp);
                            v4.set(v4_temp);
                            v5.set(v5_temp);
                            v6.set(v6_temp);
                            continue '_method9;
                        }
                    }
                } else {
                    if v2.get() {
                        Dice::method13(
                            v0.get(),
                            v1.get(),
                            v2.get(),
                            v3.get(),
                            v4.get(),
                            Dice::method12(v4.get(), v1.get(), 0_i64),
                        )
                    } else {
                        let v0_temp: Dice::US2 = v0.get();
                        let v1_temp = v1.get();
                        let v2_temp: bool = v2.get();
                        let v3_temp: u64 = v3.get();
                        let v4_temp: i64 = v4.get();
                        let v5_temp: LrcPtr<Dice::UH1> =
                            LrcPtr::new(Dice::UH1::UH1_0(v1(), v5.get()));
                        let v6_temp: i64 = v6.get() + 1_i64;
                        v0.set(v0_temp);
                        v1.set(v1_temp);
                        v2.set(v2_temp);
                        v3.set(v3_temp);
                        v4.set(v4_temp);
                        v5.set(v5_temp);
                        v6.set(v6_temp);
                        continue '_method9;
                    }
                }
            });
        }
    }
    pub fn closure11(v0: Dice::US2, v1: Func0<u64>, v2: bool, v3: u64) -> u64 {
        Dice::method9(
            v0.clone(),
            v1,
            v2,
            v3,
            (if v3 == 1_u64 {
                1_i64
            } else {
                Dice::method8(v0, v3, 0_i64, 1_u64)
            }) - 1_i64,
            LrcPtr::new(Dice::UH1::UH1_1),
            0_i64,
        )
    }
    pub fn closure10(v0: Dice::US2, v1: Func0<u64>, v2: bool) -> Func1<u64, u64> {
        Func1::new({
            let v0 = v0.clone();
            let v1 = v1.clone();
            let v2 = v2.clone();
            move |v: u64| Dice::closure11(v0.clone(), v1.clone(), v2, v)
        })
    }
    pub fn closure9(v0: Dice::US2, v1: Func0<u64>) -> Func1<bool, Func1<u64, u64>> {
        Func1::new({
            let v0 = v0.clone();
            let v1 = v1.clone();
            move |v: bool| Dice::closure10(v0.clone(), v1.clone(), v)
        })
    }
    pub fn closure8(unitVar: (), v0: Dice::US2) -> Func1<Func0<u64>, Func1<bool, Func1<u64, u64>>> {
        Func1::new({
            let v0 = v0.clone();
            move |v: Func0<u64>| Dice::closure9(v0.clone(), v)
        })
    }
    pub fn method14(v0: LrcPtr<Dice::UH1>, v1: i64) -> i64 {
        let v0: MutCell<LrcPtr<Dice::UH1>> = MutCell::new(v0.clone());
        let v1: MutCell<i64> = MutCell::new(v1);
        '_method14: loop {
            break '_method14 (match v0.get().as_ref() {
                Dice::UH1::UH1_1 => v1.get(),
                Dice::UH1::UH1_0(v0_0_0, v0_0_1) => {
                    let v0_temp: LrcPtr<Dice::UH1> = v0_0_1.clone();
                    let v1_temp: i64 = v1.get() + 1_i64;
                    v0.set(v0_temp);
                    v1.set(v1_temp);
                    continue '_method14;
                }
            });
        }
    }
    pub fn closure78(v0: Dice::US2, v1: u64, v2: LrcPtr<Dice::UH1>) -> Dice::US1 {
        let v7: Dice::US3 =
            Dice::method10(v0, Dice::method14(v2.clone(), 0_i64) - 1_i64, v2, 0_u64);
        if let Dice::US3::US3_1(v7_1_0, v7_1_1) = &v7 {
            let v8: u64 = match &v7 {
                Dice::US3::US3_1(x, _) => x.clone(),
                _ => unreachable!(),
            };
            if if v8 >= 1_u64 { v8 <= v1 } else { false } {
                Dice::US1::US1_1(v8)
            } else {
                Dice::US1::US1_0
            }
        } else {
            Dice::US1::US1_0
        }
    }
    pub fn closure77(v0: Dice::US2, v1: u64) -> Func1<LrcPtr<Dice::UH1>, Dice::US1> {
        Func1::new({
            let v0 = v0.clone();
            let v1 = v1.clone();
            move |v: LrcPtr<Dice::UH1>| Dice::closure78(v0.clone(), v1, v)
        })
    }
    pub fn closure76(
        unitVar: (),
        v0: Dice::US2,
    ) -> Func1<u64, Func1<LrcPtr<Dice::UH1>, Dice::US1>> {
        Func1::new({
            let v0 = v0.clone();
            move |v: u64| Dice::closure77(v0.clone(), v)
        })
    }
    pub fn method0() {
        ();
    }
    on_startup!(Dice::method0(),);
    pub fn main(_args: Array<string>) -> i32 {
        0_i32
    }
}
#[path = "../../lib/fsharp/CommonChain.rs"]
mod module_ad43931;
pub use module_ad43931::*;
pub fn main() {
    let args = std::env::args().skip(1).map(fromString).collect();
    Dice::main(array_from(args));
}
