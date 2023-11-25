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
mod module_a51efde0 {
    pub mod Dice {
        use super::*;
        use fable_library_rust::NativeArray_::Array;
        use fable_library_rust::Native_::Any;
        use fable_library_rust::Native_::Func0;
        use fable_library_rust::Native_::Func1;
        use fable_library_rust::Native_::LrcPtr;
        use fable_library_rust::Native_::MutCell;
        use fable_library_rust::Option_::defaultValue;
        use fable_library_rust::Option_::getValue;
        use fable_library_rust::Option_::map;
        use fable_library_rust::String_::sprintf;
        use fable_library_rust::String_::string;
        #[derive(Clone, Debug)]
        pub enum UH0 {
            UH0_0(u8, Func0<LrcPtr<Dice::UH0>>),
            UH0_1,
        }
        impl core::fmt::Display for Dice::UH0 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, PartialEq, PartialOrd, Hash, Eq, Ord)]
        pub enum UH1 {
            UH1_0(u8, LrcPtr<Dice::UH1>),
            UH1_1,
        }
        impl core::fmt::Display for Dice::UH1 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US0 {
            US0_0,
            US0_1(Func1<string, ()>),
        }
        impl core::fmt::Display for Dice::US0 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US1 {
            US1_0(LrcPtr<Dice::UH0>),
            US1_1(Func0<LrcPtr<Dice::UH0>>),
        }
        impl core::fmt::Display for Dice::US1 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub struct Mut0 {
            pub l0: MutCell<Dice::US1>,
        }
        impl core::fmt::Display for Dice::Mut0 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Default, PartialEq, PartialOrd, Hash, Eq, Ord)]
        pub struct Mut1 {
            pub l0: MutCell<i64>,
        }
        impl core::fmt::Display for Dice::Mut1 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Copy, Debug, PartialEq, PartialOrd, Hash, Eq, Ord)]
        pub enum US2 {
            US2_0,
            US2_1(u8),
        }
        impl core::fmt::Display for Dice::US2 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, PartialEq, PartialOrd, Hash, Eq, Ord)]
        pub struct Mut2 {
            pub l0: MutCell<Dice::US2>,
        }
        impl core::fmt::Display for Dice::Mut2 {
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
        #[derive(Clone, Debug)]
        pub enum UH2 {
            UH2_0(u64, Func0<LrcPtr<Dice::UH2>>),
            UH2_1,
        }
        impl core::fmt::Display for Dice::UH2 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Copy, Debug, PartialEq, PartialOrd, Hash, Eq, Ord)]
        pub enum US4 {
            US4_0,
            US4_1(u64),
        }
        impl core::fmt::Display for Dice::US4 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, PartialEq, PartialOrd, Hash, Eq, Ord)]
        pub enum US5 {
            US5_0,
            US5_1(i64, LrcPtr<Dice::UH1>),
        }
        impl core::fmt::Display for Dice::US5 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        pub fn closure2(v0_1: LrcPtr<Dice::UH0>, unitVar: ()) -> LrcPtr<Dice::UH0> {
            v0_1
        }
        pub fn method0(
            v0_1: i64,
            v1_1: LrcPtr<Dice::UH0>,
            v2_1: LrcPtr<Dice::UH0>,
        ) -> LrcPtr<Dice::UH0> {
            match v1_1.as_ref() {
                Dice::UH0::UH0_1 => v2_1.clone(),
                Dice::UH0::UH0_0(v1_1_0_0, v1_1_0_1) => {
                    let v6: LrcPtr<Dice::UH0> = Dice::method0(v0_1, (v1_1_0_1)(), v2_1.clone());
                    LrcPtr::new(Dice::UH0::UH0_0(
                        ((v1_1_0_0.clone() as i64 - 1_i64 + v0_1) % v0_1 + 1_i64) as u8,
                        Func0::new({
                            let v6 = v6.clone();
                            move || Dice::closure2(v6.clone(), ())
                        }),
                    ))
                }
            }
        }
        pub fn closure1(v0_1: i64, v1_1: LrcPtr<Dice::UH0>) -> LrcPtr<Dice::UH0> {
            Dice::method0(v0_1, v1_1, LrcPtr::new(Dice::UH0::UH0_1))
        }
        pub fn closure0(unitVar: (), v0_1: i64) -> Func1<LrcPtr<Dice::UH0>, LrcPtr<Dice::UH0>> {
            Func1::new({
                let v0_1 = v0_1.clone();
                move |v: LrcPtr<Dice::UH0>| Dice::closure1(v0_1, v)
            })
        }
        pub fn closure4(unitVar: (), v0_1: Func1<string, ()>) -> Dice::US0 {
            Dice::US0::US0_1(v0_1)
        }
        pub fn method1(v0_1: LrcPtr<Dice::UH1>, v1_1: LrcPtr<Dice::UH1>) -> LrcPtr<Dice::UH1> {
            let v0_1: MutCell<LrcPtr<Dice::UH1>> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<LrcPtr<Dice::UH1>> = MutCell::new(v1_1.clone());
            '_method1: loop {
                break '_method1 (match v0_1.get().as_ref() {
                    Dice::UH1::UH1_1 => v1_1.get(),
                    Dice::UH1::UH1_0(v0_1_0_0, v0_1_0_1) => {
                        let v0_1_temp: LrcPtr<Dice::UH1> = v0_1_0_1.clone();
                        let v1_1_temp: LrcPtr<Dice::UH1> =
                            LrcPtr::new(Dice::UH1::UH1_0(v0_1_0_0.clone(), v1_1.get()));
                        v0_1.set(v0_1_temp);
                        v1_1.set(v1_1_temp);
                        continue '_method1;
                    }
                });
            }
        }
        pub fn method2(v0_1: LrcPtr<Dice::UH1>, v1_1: LrcPtr<Dice::UH1>) -> LrcPtr<Dice::UH1> {
            match v0_1.as_ref() {
                Dice::UH1::UH1_1 => v1_1.clone(),
                Dice::UH1::UH1_0(v0_1_0_0, v0_1_0_1) => LrcPtr::new(Dice::UH1::UH1_0(
                    v0_1_0_0.clone(),
                    Dice::method2(v0_1_0_1.clone(), v1_1.clone()),
                )),
            }
        }
        pub fn closure6(v0_1: LrcPtr<Dice::UH0>, unitVar: ()) -> LrcPtr<Dice::UH0> {
            v0_1
        }
        pub fn method3(v0_1: LrcPtr<Dice::UH1>, v1_1: LrcPtr<Dice::UH0>) -> LrcPtr<Dice::UH0> {
            match v0_1.as_ref() {
                Dice::UH1::UH1_1 => v1_1.clone(),
                Dice::UH1::UH1_0(v0_1_0_0, v0_1_0_1) => {
                    let v4_1: LrcPtr<Dice::UH0> = Dice::method3(v0_1_0_1.clone(), v1_1.clone());
                    LrcPtr::new(Dice::UH0::UH0_0(
                        v0_1_0_0.clone(),
                        Func0::new({
                            let v4_1 = v4_1.clone();
                            move || Dice::closure6(v4_1.clone(), ())
                        }),
                    ))
                }
            }
        }
        pub fn closure7(v0_1: LrcPtr<Dice::UH0>, unitVar: ()) -> LrcPtr<Dice::UH0> {
            v0_1
        }
        pub fn closure8(
            v0_1: LrcPtr<Dice::UH0>,
            v1_1: LrcPtr<Dice::Mut0>,
            unitVar: (),
        ) -> LrcPtr<Dice::UH0> {
            let v2_1: Dice::US1 = v1_1.l0.get().clone();
            match &v2_1 {
                Dice::US1::US1_1(v2_1_1_0) => {
                    let v5: LrcPtr<Dice::UH0> = (v2_1_1_0)();
                    let v12: LrcPtr<Dice::UH0> = match v5.as_ref() {
                        Dice::UH0::UH0_1 => LrcPtr::new(Dice::UH0::UH0_1),
                        Dice::UH0::UH0_0(v5_0_0, v5_0_1) => LrcPtr::new(Dice::UH0::UH0_0(
                            v5_0_0.clone(),
                            Dice::method4(v0_1, v5_0_1.clone()),
                        )),
                    };
                    v1_1.l0.set(Dice::US1::US1_0(v12.clone()));
                    v12
                }
                Dice::US1::US1_0(v2_1_0_0) => v2_1_0_0.clone(),
            }
        }
        pub fn method4(
            v0_1: LrcPtr<Dice::UH0>,
            v1_1: Func0<LrcPtr<Dice::UH0>>,
        ) -> Func0<LrcPtr<Dice::UH0>> {
            let v3_1: LrcPtr<Dice::Mut0> = LrcPtr::new(Dice::Mut0 {
                l0: MutCell::new(Dice::US1::US1_1(v1_1)),
            });
            Func0::new({
                let v0_1 = v0_1.clone();
                let v3_1 = v3_1.clone();
                move || Dice::closure8(v0_1.clone(), v3_1.clone(), ())
            })
        }
        pub fn method6(v0_1: i64, v1_1: LrcPtr<Dice::UH0>) -> Dice::US2 {
            let v0_1: MutCell<i64> = MutCell::new(v0_1);
            let v1_1: MutCell<LrcPtr<Dice::UH0>> = MutCell::new(v1_1.clone());
            '_method6: loop {
                break '_method6 (match v1_1.get().as_ref() {
                    Dice::UH0::UH0_1 => Dice::US2::US2_0,
                    Dice::UH0::UH0_0(v1_1_0_0, v1_1_0_1) => {
                        if v0_1.get() <= 0_i64 {
                            Dice::US2::US2_1(v1_1_0_0.clone())
                        } else {
                            let v0_1_temp: i64 = v0_1.get() - 1_i64;
                            let v1_1_temp: LrcPtr<Dice::UH0> = (v1_1_0_1)();
                            v0_1.set(v0_1_temp);
                            v1_1.set(v1_1_temp);
                            continue '_method6;
                        }
                    }
                });
            }
        }
        pub fn method5(
            v0_1: Dice::US0,
            v1_1: Func0<LrcPtr<Dice::UH0>>,
            v2_1: LrcPtr<Dice::Mut1>,
            v3_1: LrcPtr<Dice::Mut1>,
            v4_1: LrcPtr<Dice::Mut1>,
            v5: LrcPtr<Dice::Mut2>,
        ) -> u8 {
            let v0_1: MutCell<Dice::US0> = MutCell::new(v0_1.clone());
            let v1_1 = MutCell::new(v1_1.clone());
            let v2_1: MutCell<LrcPtr<Dice::Mut1>> = MutCell::new(v2_1.clone());
            let v3_1: MutCell<LrcPtr<Dice::Mut1>> = MutCell::new(v3_1.clone());
            let v4_1: MutCell<LrcPtr<Dice::Mut1>> = MutCell::new(v4_1.clone());
            let v5: MutCell<LrcPtr<Dice::Mut2>> = MutCell::new(v5.clone());
            '_method5: loop {
                break '_method5 ({
                    let v10: string =
                                 sprintf!("create_sequential_roller / roll / current_index: {} / acc: {} / len: {} / last_item: {:?}",
                                          &v2_1.l0.get(), &v3_1.l0.get(),
                                          &v4_1.l0.get(), &v5.l0.get());
                    match &v0_1.get() {
                        Dice::US0::US0_1(v0_1_1_0) => (v0_1_1_0)(v10),
                        _ => (),
                    }
                    {
                        let v12: LrcPtr<Dice::UH0> = v1_1();
                        let v14: Dice::US2 = Dice::method6(v2_1.l0.get(), v12);
                        match &v14 {
                            Dice::US2::US2_1(v14_1_0) => {
                                let v15: u8 = v14_1_0.clone();
                                let v17: i64 = v2_1.l0.get() + 1_i64;
                                v2_1.l0.set(v17);
                                v5.l0.set(Dice::US2::US2_1(v15));
                                v15
                            }
                            _ => {
                                match &v0_1.get() {
                                    Dice::US0::US0_1(v0_1_1_0) => {
                                        (v0_1_1_0)(string("create_sequential_roller / roll / None"))
                                    }
                                    _ => (),
                                }
                                if v4_1.l0.get() == -1_i64 {
                                    let v23: i64 = v2_1.l0.get();
                                    v4_1.l0.set(v23);
                                    ()
                                }
                                {
                                    let v29: i64 = if v3_1.l0.get() >= v4_1.l0.get() {
                                        1_i64
                                    } else {
                                        v3_1.l0.get() + 1_i64
                                    };
                                    v3_1.l0.set(v29);
                                    {
                                        let v31: i64 = v3_1.l0.get() - 1_i64;
                                        v2_1.l0.set(v31);
                                        v5.l0.set(Dice::US2::US2_0);
                                        {
                                            let v0_1_temp: Dice::US0 = v0_1.get();
                                            let v1_1_temp = v1_1.get();
                                            let v2_1_temp: LrcPtr<Dice::Mut1> = v2_1.get();
                                            let v3_1_temp: LrcPtr<Dice::Mut1> = v3_1.get();
                                            let v4_1_temp: LrcPtr<Dice::Mut1> = v4_1.get();
                                            let v5_temp: LrcPtr<Dice::Mut2> = v5.get();
                                            v0_1.set(v0_1_temp);
                                            v1_1.set(v1_1_temp);
                                            v2_1.set(v2_1_temp);
                                            v3_1.set(v3_1_temp);
                                            v4_1.set(v4_1_temp);
                                            v5.set(v5_temp);
                                            continue '_method5;
                                        }
                                    }
                                }
                            }
                        }
                    }
                });
            }
        }
        pub fn closure9(
            v0_1: Dice::US0,
            v1_1: Func0<LrcPtr<Dice::UH0>>,
            v2_1: LrcPtr<Dice::Mut1>,
            v3_1: LrcPtr<Dice::Mut1>,
            v4_1: LrcPtr<Dice::Mut1>,
            v5: LrcPtr<Dice::Mut2>,
            unitVar: (),
        ) -> u8 {
            Dice::method5(v0_1, v1_1, v2_1, v3_1, v4_1, v5)
        }
        pub fn closure5(v0_1: Dice::US0, v1_1: LrcPtr<Dice::UH1>) -> Func0<u8> {
            match &v0_1 {
                Dice::US0::US0_1(v0_1_1_0) => (v0_1_1_0)(string("create_sequential_roller ()")),
                _ => (),
            }
            {
                let v8: LrcPtr<Dice::UH0> = Dice::method3(
                    Dice::method2(
                        v1_1.clone(),
                        Dice::method1(v1_1, LrcPtr::new(Dice::UH1::UH1_1)),
                    ),
                    LrcPtr::new(Dice::UH0::UH0_1),
                );
                let v10 = Dice::method4(
                    v8.clone(),
                    Func0::new({
                        let v8 = v8.clone();
                        move || Dice::closure7(v8.clone(), ())
                    }),
                );
                let v11: LrcPtr<Dice::Mut1> = LrcPtr::new(Dice::Mut1 {
                    l0: MutCell::new(0_i64),
                });
                let v12: LrcPtr<Dice::Mut1> = LrcPtr::new(Dice::Mut1 {
                    l0: MutCell::new(1_i64),
                });
                let v13: LrcPtr<Dice::Mut1> = LrcPtr::new(Dice::Mut1 {
                    l0: MutCell::new(-1_i64),
                });
                let v15: LrcPtr<Dice::Mut2> = LrcPtr::new(Dice::Mut2 {
                    l0: MutCell::new(Dice::US2::US2_0),
                });
                Func0::new({
                    let v0_1 = v0_1.clone();
                    let v10 = v10.clone();
                    let v11 = v11.clone();
                    let v12 = v12.clone();
                    let v13 = v13.clone();
                    let v15 = v15.clone();
                    move || {
                        Dice::closure9(
                            v0_1.clone(),
                            v10.clone(),
                            v11.clone(),
                            v12.clone(),
                            v13.clone(),
                            v15.clone(),
                            (),
                        )
                    }
                })
            }
        }
        pub fn closure3(
            unitVar: (),
            v0_1: Option<Func1<string, ()>>,
        ) -> Func1<LrcPtr<Dice::UH1>, Func0<u8>> {
            let v3_1: Dice::US0 = defaultValue(
                Dice::US0::US0_0,
                map(
                    Func1::new(move |v: Func1<string, ()>| Dice::closure4((), v)),
                    v0_1,
                ),
            );
            Func1::new({
                let v3_1 = v3_1.clone();
                move |v_1: LrcPtr<Dice::UH1>| Dice::closure5(v3_1.clone(), v_1)
            })
        }
        pub fn method7(v0_1: Dice::US0, v1_1: u64, v2_1: i8, v3_1: u64) -> i8 {
            let v0_1: MutCell<Dice::US0> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<u64> = MutCell::new(v1_1);
            let v2_1: MutCell<i8> = MutCell::new(v2_1);
            let v3_1: MutCell<u64> = MutCell::new(v3_1);
            '_method7: loop {
                break '_method7 (if v3_1.get() < v1_1.get() {
                    let v5: u64 = v3_1.get() * 6_u64;
                    if v5 > v3_1.get() {
                        let v0_1_temp: Dice::US0 = v0_1.get();
                        let v1_1_temp: u64 = v1_1.get();
                        let v2_1_temp: i8 = v2_1.get() + 1_i8;
                        let v3_1_temp: u64 = v5;
                        v0_1.set(v0_1_temp);
                        v1_1.set(v1_1_temp);
                        v2_1.set(v2_1_temp);
                        v3_1.set(v3_1_temp);
                        continue '_method7;
                    } else {
                        let v9: string = sprintf!(
                            "calculate_dice_count / max: {} / n: {} / p: {}",
                            &v1_1.get(),
                            &v2_1.get(),
                            &v3_1.get()
                        );
                        match &v0_1.get() {
                            Dice::US0::US0_1(v0_1_1_0) => (v0_1_1_0)(v9),
                            _ => (),
                        }
                        v2_1.get()
                    }
                } else {
                    let v12: string = sprintf!(
                        "calculate_dice_count / max: {} / n: {} / p: {}",
                        &v1_1.get(),
                        &v2_1.get(),
                        &v3_1.get()
                    );
                    match &v0_1.get() {
                        Dice::US0::US0_1(v0_1_1_0) => (v0_1_1_0)(v12),
                        _ => (),
                    }
                    v2_1.get()
                });
            }
        }
        pub fn closure77(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                0_u64,
                Func0::new(move || Dice::closure77((), ())),
            ))
        }
        pub fn closure76(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                9223372036854775808_u64,
                Func0::new(move || Dice::closure77((), ())),
            ))
        }
        pub fn closure75(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                4611686018427387904_u64,
                Func0::new(move || Dice::closure76((), ())),
            ))
        }
        pub fn closure74(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                6917529027641081856_u64,
                Func0::new(move || Dice::closure75((), ())),
            ))
        }
        pub fn closure73(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                1152921504606846976_u64,
                Func0::new(move || Dice::closure74((), ())),
            ))
        }
        pub fn closure72(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                15564440312192434176_u64,
                Func0::new(move || Dice::closure73((), ())),
            ))
        }
        pub fn closure71(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                11817445422220181504_u64,
                Func0::new(move || Dice::closure72((), ())),
            ))
        }
        pub fn closure70(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                5044031582654955520_u64,
                Func0::new(move || Dice::closure71((), ())),
            ))
        }
        pub fn closure69(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                6989586621679009792_u64,
                Func0::new(move || Dice::closure70((), ())),
            ))
        }
        pub fn closure68(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                16537217831704461312_u64,
                Func0::new(move || Dice::closure69((), ())),
            ))
        }
        pub fn closure67(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                11979575008805519360_u64,
                Func0::new(move || Dice::closure68((), ())),
            ))
        }
        pub fn closure66(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                14294425217273954304_u64,
                Func0::new(move || Dice::closure67((), ())),
            ))
        }
        pub fn closure65(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                2382404202878992384_u64,
                Func0::new(move || Dice::closure66((), ())),
            ))
        }
        pub fn closure64(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                6545982058383015936_u64,
                Func0::new(move || Dice::closure65((), ())),
            ))
        }
        pub fn closure63(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                10314369046585278464_u64,
                Func0::new(move || Dice::closure64((), ())),
            ))
        }
        pub fn closure62(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                4793518853382471680_u64,
                Func0::new(move || Dice::closure63((), ())),
            ))
        }
        pub fn closure61(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                3873377154515337216_u64,
                Func0::new(move || Dice::closure62((), ())),
            ))
        }
        pub fn closure60(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                645562859085889536_u64,
                Func0::new(move || Dice::closure61((), ())),
            ))
        }
        pub fn closure59(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                107593809847648256_u64,
                Func0::new(move || Dice::closure60((), ())),
            ))
        }
        pub fn closure58(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                3092389647259533312_u64,
                Func0::new(move || Dice::closure59((), ())),
            ))
        }
        pub fn closure57(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                9738770311398031360_u64,
                Func0::new(move || Dice::closure58((), ())),
            ))
        }
        pub fn closure56(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                16995415113324298240_u64,
                Func0::new(move || Dice::closure57((), ())),
            ))
        }
        pub fn closure55(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                8981483876790566912_u64,
                Func0::new(move || Dice::closure56((), ())),
            ))
        }
        pub fn closure54(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                13794743361938128896_u64,
                Func0::new(move || Dice::closure55((), ())),
            ))
        }
        pub fn closure53(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                2299123893656354816_u64,
                Func0::new(move || Dice::closure54((), ())),
            ))
        }
        pub fn closure52(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                3457644661227651072_u64,
                Func0::new(move || Dice::closure53((), ())),
            ))
        }
        pub fn closure51(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                576274110204608512_u64,
                Func0::new(move || Dice::closure52((), ())),
            ))
        }
        pub fn closure50(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                6244960376270618624_u64,
                Func0::new(move || Dice::closure51((), ())),
            ))
        }
        pub fn closure49(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                13338656111851470848_u64,
                Func0::new(move || Dice::closure50((), ())),
            ))
        }
        pub fn closure48(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                14520938734448279552_u64,
                Func0::new(move || Dice::closure49((), ())),
            ))
        }
        pub fn closure47(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                14717985838214414336_u64,
                Func0::new(move || Dice::closure48((), ())),
            ))
        }
        pub fn closure46(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                5527454985320660992_u64,
                Func0::new(move || Dice::closure47((), ())),
            ))
        }
        pub fn closure45(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                16293529225644736512_u64,
                Func0::new(move || Dice::closure46((), ())),
            ))
        }
        pub fn closure44(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                11938960241128898560_u64,
                Func0::new(move || Dice::closure45((), ())),
            ))
        }
        pub fn closure43(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                8138741398091333632_u64,
                Func0::new(move || Dice::closure44((), ())),
            ))
        }
        pub fn closure42(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                7505371590918406144_u64,
                Func0::new(move || Dice::closure43((), ())),
            ))
        }
        pub fn closure41(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                16623181993244360704_u64,
                Func0::new(move || Dice::closure42((), ())),
            ))
        }
        pub fn closure40(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                8919445023443910656_u64,
                Func0::new(move || Dice::closure41((), ())),
            ))
        }
        pub fn closure39(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                4561031516192243712_u64,
                Func0::new(move || Dice::closure40((), ())),
            ))
        }
        pub fn closure38(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                9983543956220149760_u64,
                Func0::new(move || Dice::closure39((), ())),
            ))
        }
        pub fn closure37(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                4738381338321616896_u64,
                Func0::new(move || Dice::closure38((), ())),
            ))
        }
        pub fn closure36(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                789730223053602816_u64,
                Func0::new(move || Dice::closure37((), ())),
            ))
        }
        pub fn closure35(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                131621703842267136_u64,
                Func0::new(move || Dice::closure36((), ())),
            ))
        }
        pub fn closure34(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                21936950640377856_u64,
                Func0::new(move || Dice::closure35((), ())),
            ))
        }
        pub fn closure33(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                3656158440062976_u64,
                Func0::new(move || Dice::closure34((), ())),
            ))
        }
        pub fn closure32(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                609359740010496_u64,
                Func0::new(move || Dice::closure33((), ())),
            ))
        }
        pub fn closure31(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                101559956668416_u64,
                Func0::new(move || Dice::closure32((), ())),
            ))
        }
        pub fn closure30(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                16926659444736_u64,
                Func0::new(move || Dice::closure31((), ())),
            ))
        }
        pub fn closure29(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                2821109907456_u64,
                Func0::new(move || Dice::closure30((), ())),
            ))
        }
        pub fn closure28(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                470184984576_u64,
                Func0::new(move || Dice::closure29((), ())),
            ))
        }
        pub fn closure27(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                78364164096_u64,
                Func0::new(move || Dice::closure28((), ())),
            ))
        }
        pub fn closure26(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                13060694016_u64,
                Func0::new(move || Dice::closure27((), ())),
            ))
        }
        pub fn closure25(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                2176782336_u64,
                Func0::new(move || Dice::closure26((), ())),
            ))
        }
        pub fn closure24(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                362797056_u64,
                Func0::new(move || Dice::closure25((), ())),
            ))
        }
        pub fn closure23(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                60466176_u64,
                Func0::new(move || Dice::closure24((), ())),
            ))
        }
        pub fn closure22(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                10077696_u64,
                Func0::new(move || Dice::closure23((), ())),
            ))
        }
        pub fn closure21(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                1679616_u64,
                Func0::new(move || Dice::closure22((), ())),
            ))
        }
        pub fn closure20(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                279936_u64,
                Func0::new(move || Dice::closure21((), ())),
            ))
        }
        pub fn closure19(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                46656_u64,
                Func0::new(move || Dice::closure20((), ())),
            ))
        }
        pub fn closure18(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                7776_u64,
                Func0::new(move || Dice::closure19((), ())),
            ))
        }
        pub fn closure17(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                1296_u64,
                Func0::new(move || Dice::closure18((), ())),
            ))
        }
        pub fn closure16(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                216_u64,
                Func0::new(move || Dice::closure17((), ())),
            ))
        }
        pub fn closure15(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                36_u64,
                Func0::new(move || Dice::closure16((), ())),
            ))
        }
        pub fn closure14(unitVar: (), unitVar_1: ()) -> LrcPtr<Dice::UH2> {
            LrcPtr::new(Dice::UH2::UH2_0(
                6_u64,
                Func0::new(move || Dice::closure15((), ())),
            ))
        }
        pub fn method10(v0_1: i8, v1_1: LrcPtr<Dice::UH2>) -> Dice::US4 {
            let v0_1: MutCell<i8> = MutCell::new(v0_1);
            let v1_1: MutCell<LrcPtr<Dice::UH2>> = MutCell::new(v1_1.clone());
            '_method10: loop {
                break '_method10 (match v1_1.get().as_ref() {
                    Dice::UH2::UH2_1 => Dice::US4::US4_0,
                    Dice::UH2::UH2_0(v1_1_0_0, v1_1_0_1) => {
                        if v0_1.get() <= 0_i8 {
                            Dice::US4::US4_1(v1_1_0_0.clone())
                        } else {
                            let v0_1_temp: i8 = v0_1.get() - 1_i8;
                            let v1_1_temp: LrcPtr<Dice::UH2> = (v1_1_0_1)();
                            v0_1.set(v0_1_temp);
                            v1_1.set(v1_1_temp);
                            continue '_method10;
                        }
                    }
                });
            }
        }
        pub fn method9(v0_1: Dice::US0, v1_1: i8, v2_1: LrcPtr<Dice::UH1>, v3_1: u64) -> Dice::US3 {
            let v0_1: MutCell<Dice::US0> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<i8> = MutCell::new(v1_1);
            let v2_1: MutCell<LrcPtr<Dice::UH1>> = MutCell::new(v2_1.clone());
            let v3_1: MutCell<u64> = MutCell::new(v3_1);
            '_method9: loop {
                break '_method9 (if v1_1.get() < 0_i8 {
                    let v5: string = sprintf!(
                        "accumulate_dice_rolls / power: {} / acc: {}",
                        &v1_1.get(),
                        &v3_1.get()
                    );
                    match &v0_1.get() {
                        Dice::US0::US0_1(v0_1_1_0) => (v0_1_1_0)(v5),
                        _ => (),
                    }
                    Dice::US3::US3_1(v3_1.get() + 1_u64, v2_1.get())
                } else {
                    match v2_1.get().as_ref() {
                        Dice::UH1::UH1_1 => Dice::US3::US3_0,
                        Dice::UH1::UH1_0(v2_1_0_0, v2_1_0_1) => {
                            let v11: LrcPtr<Dice::UH1> = v2_1_0_1.clone();
                            let v10: u8 = v2_1_0_0.clone();
                            if v10 > 1_u8 {
                                let v16: Dice::US4 = Dice::method10(
                                    v1_1.get(),
                                    LrcPtr::new(Dice::UH2::UH2_0(
                                        1_u64,
                                        Func0::new(move || Dice::closure14((), ())),
                                    )),
                                );
                                let v23: u64 = (v10 - 1_u8) as u64
                                    * match &v16 {
                                        Dice::US4::US4_1(v16_1_0) => v16_1_0.clone(),
                                        _ => panic!("{}", string("Option does not have a value."),),
                                    };
                                let v24: string =
                                             sprintf!("accumulate_dice_rolls / power: {} / acc: {} / roll: {} / value: {}",
                                                      &v1_1.get(),
                                                      &v3_1.get(), &v10,
                                                      &v23);
                                match &v0_1.get() {
                                    Dice::US0::US0_1(v0_1_1_0) => (v0_1_1_0)(v24),
                                    _ => (),
                                }
                                {
                                    let v0_1_temp: Dice::US0 = v0_1.get();
                                    let v1_1_temp: i8 = v1_1.get() - 1_i8;
                                    let v2_1_temp: LrcPtr<Dice::UH1> = v11;
                                    let v3_1_temp: u64 = v3_1.get() + v23;
                                    v0_1.set(v0_1_temp);
                                    v1_1.set(v1_1_temp);
                                    v2_1.set(v2_1_temp);
                                    v3_1.set(v3_1_temp);
                                    continue '_method9;
                                }
                            } else {
                                let v29: string = sprintf!(
                                    "accumulate_dice_rolls / power: {} / acc: {} / roll: {}",
                                    &v1_1.get(),
                                    &v3_1.get(),
                                    &v10
                                );
                                match &v0_1.get() {
                                    Dice::US0::US0_1(v0_1_1_0) => (v0_1_1_0)(v29),
                                    _ => (),
                                }
                                {
                                    let v0_1_temp: Dice::US0 = v0_1.get();
                                    let v1_1_temp: i8 = v1_1.get() - 1_i8;
                                    let v2_1_temp: LrcPtr<Dice::UH1> = v11.clone();
                                    let v3_1_temp: u64 = v3_1.get();
                                    v0_1.set(v0_1_temp);
                                    v1_1.set(v1_1_temp);
                                    v2_1.set(v2_1_temp);
                                    v3_1.set(v3_1_temp);
                                    continue '_method9;
                                }
                            }
                        }
                    }
                });
            }
        }
        pub fn method11(v0_1: i8, v1_1: Func0<u8>, v2_1: i8) -> LrcPtr<Dice::UH1> {
            if v2_1 < v0_1 {
                LrcPtr::new(Dice::UH1::UH1_0(
                    v1_1(),
                    Dice::method11(v0_1, v1_1, v2_1 + 1_i8),
                ))
            } else {
                LrcPtr::new(Dice::UH1::UH1_1)
            }
        }
        pub fn method12(
            v0_1: Dice::US0,
            v1_1: Func0<u8>,
            v2_1: bool,
            v3_1: u64,
            v4_1: i8,
            v5: LrcPtr<Dice::UH1>,
        ) -> u64 {
            let v0_1: MutCell<Dice::US0> = MutCell::new(v0_1.clone());
            let v1_1 = MutCell::new(v1_1.clone());
            let v2_1: MutCell<bool> = MutCell::new(v2_1);
            let v3_1: MutCell<u64> = MutCell::new(v3_1);
            let v4_1: MutCell<i8> = MutCell::new(v4_1);
            let v5: MutCell<LrcPtr<Dice::UH1>> = MutCell::new(v5.clone());
            '_method12: loop {
                break '_method12 ({
                    let v6: i8 = v4_1.get() + 1_i8;
                    if v4_1.get() < v6 {
                        Dice::method8(
                            v0_1.get(),
                            v1_1.get(),
                            v2_1.get(),
                            v3_1.get(),
                            v4_1.get(),
                            LrcPtr::new(Dice::UH1::UH1_0(v1_1(), v5.get())),
                            v6,
                        )
                    } else {
                        let v12: Dice::US3 = Dice::method9(v0_1.get(), v4_1.get(), v5.get(), 0_u64);
                        if let Dice::US3::US3_1(v12_1_0, v12_1_1) = &v12 {
                            let v13: u64 = match &v12 {
                                Dice::US3::US3_1(x, _) => x.clone(),
                                _ => unreachable!(),
                            };
                            if v13 <= v3_1.get() {
                                v13
                            } else {
                                if v2_1.get() {
                                    let v0_1_temp: Dice::US0 = v0_1.get();
                                    let v1_1_temp = v1_1.get();
                                    let v2_1_temp: bool = v2_1.get();
                                    let v3_1_temp: u64 = v3_1.get();
                                    let v4_1_temp: i8 = v4_1.get();
                                    let v5_temp: LrcPtr<Dice::UH1> =
                                        Dice::method11(v4_1.get(), v1_1.get(), 0_i8);
                                    v0_1.set(v0_1_temp);
                                    v1_1.set(v1_1_temp);
                                    v2_1.set(v2_1_temp);
                                    v3_1.set(v3_1_temp);
                                    v4_1.set(v4_1_temp);
                                    v5.set(v5_temp);
                                    continue '_method12;
                                } else {
                                    Dice::method8(
                                        v0_1.get(),
                                        v1_1.get(),
                                        v2_1.get(),
                                        v3_1.get(),
                                        v4_1.get(),
                                        LrcPtr::new(Dice::UH1::UH1_0(v1_1(), v5.get())),
                                        v6,
                                    )
                                }
                            }
                        } else {
                            if v2_1.get() {
                                let v0_1_temp: Dice::US0 = v0_1.get();
                                let v1_1_temp = v1_1.get();
                                let v2_1_temp: bool = v2_1.get();
                                let v3_1_temp: u64 = v3_1.get();
                                let v4_1_temp: i8 = v4_1.get();
                                let v5_temp: LrcPtr<Dice::UH1> =
                                    Dice::method11(v4_1.get(), v1_1.get(), 0_i8);
                                v0_1.set(v0_1_temp);
                                v1_1.set(v1_1_temp);
                                v2_1.set(v2_1_temp);
                                v3_1.set(v3_1_temp);
                                v4_1.set(v4_1_temp);
                                v5.set(v5_temp);
                                continue '_method12;
                            } else {
                                Dice::method8(
                                    v0_1.get(),
                                    v1_1.get(),
                                    v2_1.get(),
                                    v3_1.get(),
                                    v4_1.get(),
                                    LrcPtr::new(Dice::UH1::UH1_0(v1_1(), v5.get())),
                                    v6,
                                )
                            }
                        }
                    }
                });
            }
        }
        pub fn method8(
            v0_1: Dice::US0,
            v1_1: Func0<u8>,
            v2_1: bool,
            v3_1: u64,
            v4_1: i8,
            v5: LrcPtr<Dice::UH1>,
            v6: i8,
        ) -> u64 {
            let v0_1: MutCell<Dice::US0> = MutCell::new(v0_1.clone());
            let v1_1 = MutCell::new(v1_1.clone());
            let v2_1: MutCell<bool> = MutCell::new(v2_1);
            let v3_1: MutCell<u64> = MutCell::new(v3_1);
            let v4_1: MutCell<i8> = MutCell::new(v4_1);
            let v5: MutCell<LrcPtr<Dice::UH1>> = MutCell::new(v5.clone());
            let v6: MutCell<i8> = MutCell::new(v6);
            '_method8: loop {
                break '_method8 (if v6.get() < v4_1.get() + 1_i8 {
                    let v0_1_temp: Dice::US0 = v0_1.get();
                    let v1_1_temp = v1_1.get();
                    let v2_1_temp: bool = v2_1.get();
                    let v3_1_temp: u64 = v3_1.get();
                    let v4_1_temp: i8 = v4_1.get();
                    let v5_temp: LrcPtr<Dice::UH1> =
                        LrcPtr::new(Dice::UH1::UH1_0(v1_1(), v5.get()));
                    let v6_temp: i8 = v6.get() + 1_i8;
                    v0_1.set(v0_1_temp);
                    v1_1.set(v1_1_temp);
                    v2_1.set(v2_1_temp);
                    v3_1.set(v3_1_temp);
                    v4_1.set(v4_1_temp);
                    v5.set(v5_temp);
                    v6.set(v6_temp);
                    continue '_method8;
                } else {
                    let v14: Dice::US3 = Dice::method9(v0_1.get(), v4_1.get(), v5.get(), 0_u64);
                    if let Dice::US3::US3_1(v14_1_0, v14_1_1) = &v14 {
                        let v15: u64 = match &v14 {
                            Dice::US3::US3_1(x, _) => x.clone(),
                            _ => unreachable!(),
                        };
                        if v15 <= v3_1.get() {
                            v15
                        } else {
                            if v2_1.get() {
                                Dice::method12(
                                    v0_1.get(),
                                    v1_1.get(),
                                    v2_1.get(),
                                    v3_1.get(),
                                    v4_1.get(),
                                    Dice::method11(v4_1.get(), v1_1.get(), 0_i8),
                                )
                            } else {
                                let v0_1_temp: Dice::US0 = v0_1.get();
                                let v1_1_temp = v1_1.get();
                                let v2_1_temp: bool = v2_1.get();
                                let v3_1_temp: u64 = v3_1.get();
                                let v4_1_temp: i8 = v4_1.get();
                                let v5_temp: LrcPtr<Dice::UH1> =
                                    LrcPtr::new(Dice::UH1::UH1_0(v1_1(), v5.get()));
                                let v6_temp: i8 = v6.get() + 1_i8;
                                v0_1.set(v0_1_temp);
                                v1_1.set(v1_1_temp);
                                v2_1.set(v2_1_temp);
                                v3_1.set(v3_1_temp);
                                v4_1.set(v4_1_temp);
                                v5.set(v5_temp);
                                v6.set(v6_temp);
                                continue '_method8;
                            }
                        }
                    } else {
                        if v2_1.get() {
                            Dice::method12(
                                v0_1.get(),
                                v1_1.get(),
                                v2_1.get(),
                                v3_1.get(),
                                v4_1.get(),
                                Dice::method11(v4_1.get(), v1_1.get(), 0_i8),
                            )
                        } else {
                            let v0_1_temp: Dice::US0 = v0_1.get();
                            let v1_1_temp = v1_1.get();
                            let v2_1_temp: bool = v2_1.get();
                            let v3_1_temp: u64 = v3_1.get();
                            let v4_1_temp: i8 = v4_1.get();
                            let v5_temp: LrcPtr<Dice::UH1> =
                                LrcPtr::new(Dice::UH1::UH1_0(v1_1(), v5.get()));
                            let v6_temp: i8 = v6.get() + 1_i8;
                            v0_1.set(v0_1_temp);
                            v1_1.set(v1_1_temp);
                            v2_1.set(v2_1_temp);
                            v3_1.set(v3_1_temp);
                            v4_1.set(v4_1_temp);
                            v5.set(v5_temp);
                            v6.set(v6_temp);
                            continue '_method8;
                        }
                    }
                });
            }
        }
        pub fn closure13(v0_1: Dice::US0, v1_1: Func0<u8>, v2_1: bool, v3_1: u64) -> u64 {
            Dice::method8(
                v0_1.clone(),
                v1_1,
                v2_1,
                v3_1,
                (if v3_1 == 1_u64 {
                    1_i8
                } else {
                    Dice::method7(v0_1, v3_1, 0_i8, 1_u64)
                }) - 1_i8,
                LrcPtr::new(Dice::UH1::UH1_1),
                0_i8,
            )
        }
        pub fn closure12(v0_1: Dice::US0, v1_1: Func0<u8>, v2_1: bool) -> Func1<u64, u64> {
            Func1::new({
                let v0_1 = v0_1.clone();
                let v1_1 = v1_1.clone();
                let v2_1 = v2_1.clone();
                move |v: u64| Dice::closure13(v0_1.clone(), v1_1.clone(), v2_1, v)
            })
        }
        pub fn closure11(v0_1: Dice::US0, v1_1: Func0<u8>) -> Func1<bool, Func1<u64, u64>> {
            Func1::new({
                let v0_1 = v0_1.clone();
                let v1_1 = v1_1.clone();
                move |v: bool| Dice::closure12(v0_1.clone(), v1_1.clone(), v)
            })
        }
        pub fn closure10(
            unitVar: (),
            v0_1: Option<Func1<string, ()>>,
        ) -> Func1<Func0<u8>, Func1<bool, Func1<u64, u64>>> {
            let v3_1: Dice::US0 = defaultValue(
                Dice::US0::US0_0,
                map(
                    Func1::new(move |v: Func1<string, ()>| Dice::closure4((), v)),
                    v0_1,
                ),
            );
            Func1::new({
                let v3_1 = v3_1.clone();
                move |v_1: Func0<u8>| Dice::closure11(v3_1.clone(), v_1)
            })
        }
        pub fn method13(v0_1: LrcPtr<Dice::UH1>, v1_1: i8) -> i8 {
            let v0_1: MutCell<LrcPtr<Dice::UH1>> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<i8> = MutCell::new(v1_1);
            '_method13: loop {
                break '_method13 (match v0_1.get().as_ref() {
                    Dice::UH1::UH1_1 => v1_1.get(),
                    Dice::UH1::UH1_0(v0_1_0_0, v0_1_0_1) => {
                        let v0_1_temp: LrcPtr<Dice::UH1> = v0_1_0_1.clone();
                        let v1_1_temp: i8 = v1_1.get() + 1_i8;
                        v0_1.set(v0_1_temp);
                        v1_1.set(v1_1_temp);
                        continue '_method13;
                    }
                });
            }
        }
        pub fn closure80(
            v0_1: Option<Func1<string, ()>>,
            v1_1: u64,
            v2_1: LrcPtr<Dice::UH1>,
        ) -> Option<u64> {
            let v10: Dice::US3 = Dice::method9(
                defaultValue(
                    Dice::US0::US0_0,
                    map(
                        Func1::new(move |v: Func1<string, ()>| Dice::closure4((), v)),
                        v0_1,
                    ),
                ),
                Dice::method13(v2_1.clone(), 0_i8) - 1_i8,
                v2_1,
                0_u64,
            );
            let v20: Dice::US4 = if let Dice::US3::US3_1(v10_1_0, v10_1_1) = &v10 {
                let v11: u64 = match &v10 {
                    Dice::US3::US3_1(x, _) => x.clone(),
                    _ => unreachable!(),
                };
                if if v11 >= 1_u64 { v11 <= v1_1 } else { false } {
                    Dice::US4::US4_1(v11)
                } else {
                    Dice::US4::US4_0
                }
            } else {
                Dice::US4::US4_0
            };
            match &v20 {
                Dice::US4::US4_1(v20_1_0) => Some(v20_1_0.clone()),
                _ => None::<u64>,
            }
        }
        pub fn closure79(
            v0_1: Option<Func1<string, ()>>,
            v1_1: u64,
        ) -> Func1<LrcPtr<Dice::UH1>, Option<u64>> {
            Func1::new({
                let v0_1 = v0_1.clone();
                let v1_1 = v1_1.clone();
                move |v: LrcPtr<Dice::UH1>| Dice::closure80(v0_1.clone(), v1_1, v)
            })
        }
        pub fn closure78(
            unitVar: (),
            v0_1: Option<Func1<string, ()>>,
        ) -> Func1<u64, Func1<LrcPtr<Dice::UH1>, Option<u64>>> {
            Func1::new({
                let v0_1 = v0_1.clone();
                move |v: u64| Dice::closure79(v0_1.clone(), v)
            })
        }
        pub fn method39(v0_1: LrcPtr<Dice::UH1>, v1_1: i64) -> Dice::US5 {
            let v2_1: string =
                sprintf!("accumulate_dice_rolls / power: {} / acc: {}", &-1_i8, &v1_1);
            println!("{0}", v2_1,);
            Dice::US5::US5_1(v1_1 + 1_i64, v0_1)
        }
        pub fn method38(v0_1: LrcPtr<Dice::UH1>, v1_1: i64) -> Dice::US5 {
            match v0_1.as_ref() {
                Dice::UH1::UH1_1 => Dice::US5::US5_0,
                Dice::UH1::UH1_0(v0_1_0_0, v0_1_0_1) => {
                    let v4_1: LrcPtr<Dice::UH1> = v0_1_0_1.clone();
                    let v3_1: u8 = v0_1_0_0.clone();
                    if v3_1 > 1_u8 {
                        let v7: i64 = (v3_1 - 1_u8) as i64;
                        let v8: string = sprintf!(
                            "accumulate_dice_rolls / power: {} / acc: {} / roll: {} / value: {}",
                            &0_i8,
                            &v1_1,
                            &v3_1,
                            &v7
                        );
                        println!("{0}", v8,);
                        Dice::method39(v4_1.clone(), v1_1 + v7)
                    } else {
                        let v11: string = sprintf!(
                            "accumulate_dice_rolls / power: {} / acc: {} / roll: {}",
                            &0_i8,
                            &v1_1,
                            &v3_1
                        );
                        println!("{0}", v11,);
                        Dice::method39(v4_1, v1_1)
                    }
                }
            }
        }
        pub fn method37(v0_1: LrcPtr<Dice::UH1>, v1_1: i64) -> Dice::US5 {
            match v0_1.as_ref() {
                Dice::UH1::UH1_1 => Dice::US5::US5_0,
                Dice::UH1::UH1_0(v0_1_0_0, v0_1_0_1) => {
                    let v4_1: LrcPtr<Dice::UH1> = v0_1_0_1.clone();
                    let v3_1: u8 = v0_1_0_0.clone();
                    if v3_1 > 1_u8 {
                        let v8: i64 = (v3_1 - 1_u8) as i64 * 6_i64;
                        let v9: string = sprintf!(
                            "accumulate_dice_rolls / power: {} / acc: {} / roll: {} / value: {}",
                            &1_i8,
                            &v1_1,
                            &v3_1,
                            &v8
                        );
                        println!("{0}", v9,);
                        Dice::method38(v4_1.clone(), v1_1 + v8)
                    } else {
                        let v12: string = sprintf!(
                            "accumulate_dice_rolls / power: {} / acc: {} / roll: {}",
                            &1_i8,
                            &v1_1,
                            &v3_1
                        );
                        println!("{0}", v12,);
                        Dice::method38(v4_1, v1_1)
                    }
                }
            }
        }
        pub fn method36(v0_1: LrcPtr<Dice::UH1>, v1_1: i64) -> Dice::US5 {
            match v0_1.as_ref() {
                Dice::UH1::UH1_1 => Dice::US5::US5_0,
                Dice::UH1::UH1_0(v0_1_0_0, v0_1_0_1) => {
                    let v4_1: LrcPtr<Dice::UH1> = v0_1_0_1.clone();
                    let v3_1: u8 = v0_1_0_0.clone();
                    if v3_1 > 1_u8 {
                        let v8: i64 = (v3_1 - 1_u8) as i64 * 36_i64;
                        let v9: string = sprintf!(
                            "accumulate_dice_rolls / power: {} / acc: {} / roll: {} / value: {}",
                            &2_i8,
                            &v1_1,
                            &v3_1,
                            &v8
                        );
                        println!("{0}", v9,);
                        Dice::method37(v4_1.clone(), v1_1 + v8)
                    } else {
                        let v12: string = sprintf!(
                            "accumulate_dice_rolls / power: {} / acc: {} / roll: {}",
                            &2_i8,
                            &v1_1,
                            &v3_1
                        );
                        println!("{0}", v12,);
                        Dice::method37(v4_1, v1_1)
                    }
                }
            }
        }
        pub fn method35(v0_1: LrcPtr<Dice::UH1>, v1_1: i64) -> Dice::US5 {
            match v0_1.as_ref() {
                Dice::UH1::UH1_1 => Dice::US5::US5_0,
                Dice::UH1::UH1_0(v0_1_0_0, v0_1_0_1) => {
                    let v4_1: LrcPtr<Dice::UH1> = v0_1_0_1.clone();
                    let v3_1: u8 = v0_1_0_0.clone();
                    if v3_1 > 1_u8 {
                        let v8: i64 = (v3_1 - 1_u8) as i64 * 216_i64;
                        let v9: string = sprintf!(
                            "accumulate_dice_rolls / power: {} / acc: {} / roll: {} / value: {}",
                            &3_i8,
                            &v1_1,
                            &v3_1,
                            &v8
                        );
                        println!("{0}", v9,);
                        Dice::method36(v4_1.clone(), v1_1 + v8)
                    } else {
                        let v12: string = sprintf!(
                            "accumulate_dice_rolls / power: {} / acc: {} / roll: {}",
                            &3_i8,
                            &v1_1,
                            &v3_1
                        );
                        println!("{0}", v12,);
                        Dice::method36(v4_1, v1_1)
                    }
                }
            }
        }
        pub fn method34(v0_1: LrcPtr<Dice::UH1>, v1_1: i64) -> Dice::US5 {
            match v0_1.as_ref() {
                Dice::UH1::UH1_1 => Dice::US5::US5_0,
                Dice::UH1::UH1_0(v0_1_0_0, v0_1_0_1) => {
                    let v4_1: LrcPtr<Dice::UH1> = v0_1_0_1.clone();
                    let v3_1: u8 = v0_1_0_0.clone();
                    if v3_1 > 1_u8 {
                        let v8: i64 = (v3_1 - 1_u8) as i64 * 1296_i64;
                        let v9: string = sprintf!(
                            "accumulate_dice_rolls / power: {} / acc: {} / roll: {} / value: {}",
                            &4_i8,
                            &v1_1,
                            &v3_1,
                            &v8
                        );
                        println!("{0}", v9,);
                        Dice::method35(v4_1.clone(), v1_1 + v8)
                    } else {
                        let v12: string = sprintf!(
                            "accumulate_dice_rolls / power: {} / acc: {} / roll: {}",
                            &4_i8,
                            &v1_1,
                            &v3_1
                        );
                        println!("{0}", v12,);
                        Dice::method35(v4_1, v1_1)
                    }
                }
            }
        }
        pub fn method33(v0_1: LrcPtr<Dice::UH1>, v1_1: i64) -> Dice::US5 {
            match v0_1.as_ref() {
                Dice::UH1::UH1_1 => Dice::US5::US5_0,
                Dice::UH1::UH1_0(v0_1_0_0, v0_1_0_1) => {
                    let v4_1: LrcPtr<Dice::UH1> = v0_1_0_1.clone();
                    let v3_1: u8 = v0_1_0_0.clone();
                    if v3_1 > 1_u8 {
                        let v8: i64 = (v3_1 - 1_u8) as i64 * 7776_i64;
                        let v9: string = sprintf!(
                            "accumulate_dice_rolls / power: {} / acc: {} / roll: {} / value: {}",
                            &5_i8,
                            &v1_1,
                            &v3_1,
                            &v8
                        );
                        println!("{0}", v9,);
                        Dice::method34(v4_1.clone(), v1_1 + v8)
                    } else {
                        let v12: string = sprintf!(
                            "accumulate_dice_rolls / power: {} / acc: {} / roll: {}",
                            &5_i8,
                            &v1_1,
                            &v3_1
                        );
                        println!("{0}", v12,);
                        Dice::method34(v4_1, v1_1)
                    }
                }
            }
        }
        pub fn method32(v0_1: LrcPtr<Dice::UH1>, v1_1: i64) -> Dice::US5 {
            match v0_1.as_ref() {
                Dice::UH1::UH1_1 => Dice::US5::US5_0,
                Dice::UH1::UH1_0(v0_1_0_0, v0_1_0_1) => {
                    let v4_1: LrcPtr<Dice::UH1> = v0_1_0_1.clone();
                    let v3_1: u8 = v0_1_0_0.clone();
                    if v3_1 > 1_u8 {
                        let v8: i64 = (v3_1 - 1_u8) as i64 * 46656_i64;
                        let v9: string = sprintf!(
                            "accumulate_dice_rolls / power: {} / acc: {} / roll: {} / value: {}",
                            &6_i8,
                            &v1_1,
                            &v3_1,
                            &v8
                        );
                        println!("{0}", v9,);
                        Dice::method33(v4_1.clone(), v1_1 + v8)
                    } else {
                        let v12: string = sprintf!(
                            "accumulate_dice_rolls / power: {} / acc: {} / roll: {}",
                            &6_i8,
                            &v1_1,
                            &v3_1
                        );
                        println!("{0}", v12,);
                        Dice::method33(v4_1, v1_1)
                    }
                }
            }
        }
        pub fn method31(v0_1: LrcPtr<Dice::UH1>, v1_1: i64) -> Dice::US5 {
            match v0_1.as_ref() {
                Dice::UH1::UH1_1 => Dice::US5::US5_0,
                Dice::UH1::UH1_0(v0_1_0_0, v0_1_0_1) => {
                    let v4_1: LrcPtr<Dice::UH1> = v0_1_0_1.clone();
                    let v3_1: u8 = v0_1_0_0.clone();
                    if v3_1 > 1_u8 {
                        let v8: i64 = (v3_1 - 1_u8) as i64 * 279936_i64;
                        let v9: string = sprintf!(
                            "accumulate_dice_rolls / power: {} / acc: {} / roll: {} / value: {}",
                            &7_i8,
                            &v1_1,
                            &v3_1,
                            &v8
                        );
                        println!("{0}", v9,);
                        Dice::method32(v4_1.clone(), v1_1 + v8)
                    } else {
                        let v12: string = sprintf!(
                            "accumulate_dice_rolls / power: {} / acc: {} / roll: {}",
                            &7_i8,
                            &v1_1,
                            &v3_1
                        );
                        println!("{0}", v12,);
                        Dice::method32(v4_1, v1_1)
                    }
                }
            }
        }
        pub fn method30(v0_1: LrcPtr<Dice::UH1>, v1_1: i64) -> Dice::US5 {
            match v0_1.as_ref() {
                Dice::UH1::UH1_1 => Dice::US5::US5_0,
                Dice::UH1::UH1_0(v0_1_0_0, v0_1_0_1) => {
                    let v4_1: LrcPtr<Dice::UH1> = v0_1_0_1.clone();
                    let v3_1: u8 = v0_1_0_0.clone();
                    if v3_1 > 1_u8 {
                        let v8: i64 = (v3_1 - 1_u8) as i64 * 1679616_i64;
                        let v9: string = sprintf!(
                            "accumulate_dice_rolls / power: {} / acc: {} / roll: {} / value: {}",
                            &8_i8,
                            &v1_1,
                            &v3_1,
                            &v8
                        );
                        println!("{0}", v9,);
                        Dice::method31(v4_1.clone(), v1_1 + v8)
                    } else {
                        let v12: string = sprintf!(
                            "accumulate_dice_rolls / power: {} / acc: {} / roll: {}",
                            &8_i8,
                            &v1_1,
                            &v3_1
                        );
                        println!("{0}", v12,);
                        Dice::method31(v4_1, v1_1)
                    }
                }
            }
        }
        pub fn method29(v0_1: LrcPtr<Dice::UH1>, v1_1: i64) -> Dice::US5 {
            match v0_1.as_ref() {
                Dice::UH1::UH1_1 => Dice::US5::US5_0,
                Dice::UH1::UH1_0(v0_1_0_0, v0_1_0_1) => {
                    let v4_1: LrcPtr<Dice::UH1> = v0_1_0_1.clone();
                    let v3_1: u8 = v0_1_0_0.clone();
                    if v3_1 > 1_u8 {
                        let v8: i64 = (v3_1 - 1_u8) as i64 * 10077696_i64;
                        let v9: string = sprintf!(
                            "accumulate_dice_rolls / power: {} / acc: {} / roll: {} / value: {}",
                            &9_i8,
                            &v1_1,
                            &v3_1,
                            &v8
                        );
                        println!("{0}", v9,);
                        Dice::method30(v4_1.clone(), v1_1 + v8)
                    } else {
                        let v12: string = sprintf!(
                            "accumulate_dice_rolls / power: {} / acc: {} / roll: {}",
                            &9_i8,
                            &v1_1,
                            &v3_1
                        );
                        println!("{0}", v12,);
                        Dice::method30(v4_1, v1_1)
                    }
                }
            }
        }
        pub fn method28(v0_1: LrcPtr<Dice::UH1>, v1_1: i64) -> Dice::US5 {
            match v0_1.as_ref() {
                Dice::UH1::UH1_1 => Dice::US5::US5_0,
                Dice::UH1::UH1_0(v0_1_0_0, v0_1_0_1) => {
                    let v4_1: LrcPtr<Dice::UH1> = v0_1_0_1.clone();
                    let v3_1: u8 = v0_1_0_0.clone();
                    if v3_1 > 1_u8 {
                        let v8: i64 = (v3_1 - 1_u8) as i64 * 60466176_i64;
                        let v9: string = sprintf!(
                            "accumulate_dice_rolls / power: {} / acc: {} / roll: {} / value: {}",
                            &10_i8,
                            &v1_1,
                            &v3_1,
                            &v8
                        );
                        println!("{0}", v9,);
                        Dice::method29(v4_1.clone(), v1_1 + v8)
                    } else {
                        let v12: string = sprintf!(
                            "accumulate_dice_rolls / power: {} / acc: {} / roll: {}",
                            &10_i8,
                            &v1_1,
                            &v3_1
                        );
                        println!("{0}", v12,);
                        Dice::method29(v4_1, v1_1)
                    }
                }
            }
        }
        pub fn method27(v0_1: LrcPtr<Dice::UH1>, v1_1: i64) -> Dice::US5 {
            match v0_1.as_ref() {
                Dice::UH1::UH1_1 => Dice::US5::US5_0,
                Dice::UH1::UH1_0(v0_1_0_0, v0_1_0_1) => {
                    let v4_1: LrcPtr<Dice::UH1> = v0_1_0_1.clone();
                    let v3_1: u8 = v0_1_0_0.clone();
                    if v3_1 > 1_u8 {
                        let v8: i64 = (v3_1 - 1_u8) as i64 * 362797056_i64;
                        let v9: string = sprintf!(
                            "accumulate_dice_rolls / power: {} / acc: {} / roll: {} / value: {}",
                            &11_i8,
                            &v1_1,
                            &v3_1,
                            &v8
                        );
                        println!("{0}", v9,);
                        Dice::method28(v4_1.clone(), v1_1 + v8)
                    } else {
                        let v12: string = sprintf!(
                            "accumulate_dice_rolls / power: {} / acc: {} / roll: {}",
                            &11_i8,
                            &v1_1,
                            &v3_1
                        );
                        println!("{0}", v12,);
                        Dice::method28(v4_1, v1_1)
                    }
                }
            }
        }
        pub fn method26(v0_1: LrcPtr<Dice::UH1>, v1_1: i64) -> Dice::US5 {
            match v0_1.as_ref() {
                Dice::UH1::UH1_1 => Dice::US5::US5_0,
                Dice::UH1::UH1_0(v0_1_0_0, v0_1_0_1) => {
                    let v4_1: LrcPtr<Dice::UH1> = v0_1_0_1.clone();
                    let v3_1: u8 = v0_1_0_0.clone();
                    if v3_1 > 1_u8 {
                        let v8: i64 = (v3_1 - 1_u8) as i64 * 2176782336_i64;
                        let v9: string = sprintf!(
                            "accumulate_dice_rolls / power: {} / acc: {} / roll: {} / value: {}",
                            &12_i8,
                            &v1_1,
                            &v3_1,
                            &v8
                        );
                        println!("{0}", v9,);
                        Dice::method27(v4_1.clone(), v1_1 + v8)
                    } else {
                        let v12: string = sprintf!(
                            "accumulate_dice_rolls / power: {} / acc: {} / roll: {}",
                            &12_i8,
                            &v1_1,
                            &v3_1
                        );
                        println!("{0}", v12,);
                        Dice::method27(v4_1, v1_1)
                    }
                }
            }
        }
        pub fn method25(v0_1: LrcPtr<Dice::UH1>, v1_1: i64) -> Dice::US5 {
            match v0_1.as_ref() {
                Dice::UH1::UH1_1 => Dice::US5::US5_0,
                Dice::UH1::UH1_0(v0_1_0_0, v0_1_0_1) => {
                    let v4_1: LrcPtr<Dice::UH1> = v0_1_0_1.clone();
                    let v3_1: u8 = v0_1_0_0.clone();
                    if v3_1 > 1_u8 {
                        let v8: i64 = (v3_1 - 1_u8) as i64 * 13060694016_i64;
                        let v9: string = sprintf!(
                            "accumulate_dice_rolls / power: {} / acc: {} / roll: {} / value: {}",
                            &13_i8,
                            &v1_1,
                            &v3_1,
                            &v8
                        );
                        println!("{0}", v9,);
                        Dice::method26(v4_1.clone(), v1_1 + v8)
                    } else {
                        let v12: string = sprintf!(
                            "accumulate_dice_rolls / power: {} / acc: {} / roll: {}",
                            &13_i8,
                            &v1_1,
                            &v3_1
                        );
                        println!("{0}", v12,);
                        Dice::method26(v4_1, v1_1)
                    }
                }
            }
        }
        pub fn method24(v0_1: LrcPtr<Dice::UH1>, v1_1: i64) -> Dice::US5 {
            match v0_1.as_ref() {
                Dice::UH1::UH1_1 => Dice::US5::US5_0,
                Dice::UH1::UH1_0(v0_1_0_0, v0_1_0_1) => {
                    let v4_1: LrcPtr<Dice::UH1> = v0_1_0_1.clone();
                    let v3_1: u8 = v0_1_0_0.clone();
                    if v3_1 > 1_u8 {
                        let v8: i64 = (v3_1 - 1_u8) as i64 * 78364164096_i64;
                        let v9: string = sprintf!(
                            "accumulate_dice_rolls / power: {} / acc: {} / roll: {} / value: {}",
                            &14_i8,
                            &v1_1,
                            &v3_1,
                            &v8
                        );
                        println!("{0}", v9,);
                        Dice::method25(v4_1.clone(), v1_1 + v8)
                    } else {
                        let v12: string = sprintf!(
                            "accumulate_dice_rolls / power: {} / acc: {} / roll: {}",
                            &14_i8,
                            &v1_1,
                            &v3_1
                        );
                        println!("{0}", v12,);
                        Dice::method25(v4_1, v1_1)
                    }
                }
            }
        }
        pub fn method23(v0_1: LrcPtr<Dice::UH1>, v1_1: i64) -> Dice::US5 {
            match v0_1.as_ref() {
                Dice::UH1::UH1_1 => Dice::US5::US5_0,
                Dice::UH1::UH1_0(v0_1_0_0, v0_1_0_1) => {
                    let v4_1: LrcPtr<Dice::UH1> = v0_1_0_1.clone();
                    let v3_1: u8 = v0_1_0_0.clone();
                    if v3_1 > 1_u8 {
                        let v8: i64 = (v3_1 - 1_u8) as i64 * 470184984576_i64;
                        let v9: string = sprintf!(
                            "accumulate_dice_rolls / power: {} / acc: {} / roll: {} / value: {}",
                            &15_i8,
                            &v1_1,
                            &v3_1,
                            &v8
                        );
                        println!("{0}", v9,);
                        Dice::method24(v4_1.clone(), v1_1 + v8)
                    } else {
                        let v12: string = sprintf!(
                            "accumulate_dice_rolls / power: {} / acc: {} / roll: {}",
                            &15_i8,
                            &v1_1,
                            &v3_1
                        );
                        println!("{0}", v12,);
                        Dice::method24(v4_1, v1_1)
                    }
                }
            }
        }
        pub fn method22(v0_1: LrcPtr<Dice::UH1>, v1_1: i64) -> Dice::US5 {
            match v0_1.as_ref() {
                Dice::UH1::UH1_1 => Dice::US5::US5_0,
                Dice::UH1::UH1_0(v0_1_0_0, v0_1_0_1) => {
                    let v4_1: LrcPtr<Dice::UH1> = v0_1_0_1.clone();
                    let v3_1: u8 = v0_1_0_0.clone();
                    if v3_1 > 1_u8 {
                        let v8: i64 = (v3_1 - 1_u8) as i64 * 2821109907456_i64;
                        let v9: string = sprintf!(
                            "accumulate_dice_rolls / power: {} / acc: {} / roll: {} / value: {}",
                            &16_i8,
                            &v1_1,
                            &v3_1,
                            &v8
                        );
                        println!("{0}", v9,);
                        Dice::method23(v4_1.clone(), v1_1 + v8)
                    } else {
                        let v12: string = sprintf!(
                            "accumulate_dice_rolls / power: {} / acc: {} / roll: {}",
                            &16_i8,
                            &v1_1,
                            &v3_1
                        );
                        println!("{0}", v12,);
                        Dice::method23(v4_1, v1_1)
                    }
                }
            }
        }
        pub fn method21(v0_1: LrcPtr<Dice::UH1>, v1_1: i64) -> Dice::US5 {
            match v0_1.as_ref() {
                Dice::UH1::UH1_1 => Dice::US5::US5_0,
                Dice::UH1::UH1_0(v0_1_0_0, v0_1_0_1) => {
                    let v4_1: LrcPtr<Dice::UH1> = v0_1_0_1.clone();
                    let v3_1: u8 = v0_1_0_0.clone();
                    if v3_1 > 1_u8 {
                        let v8: i64 = (v3_1 - 1_u8) as i64 * 16926659444736_i64;
                        let v9: string = sprintf!(
                            "accumulate_dice_rolls / power: {} / acc: {} / roll: {} / value: {}",
                            &17_i8,
                            &v1_1,
                            &v3_1,
                            &v8
                        );
                        println!("{0}", v9,);
                        Dice::method22(v4_1.clone(), v1_1 + v8)
                    } else {
                        let v12: string = sprintf!(
                            "accumulate_dice_rolls / power: {} / acc: {} / roll: {}",
                            &17_i8,
                            &v1_1,
                            &v3_1
                        );
                        println!("{0}", v12,);
                        Dice::method22(v4_1, v1_1)
                    }
                }
            }
        }
        pub fn method20(v0_1: LrcPtr<Dice::UH1>, v1_1: i64) -> Dice::US5 {
            match v0_1.as_ref() {
                Dice::UH1::UH1_1 => Dice::US5::US5_0,
                Dice::UH1::UH1_0(v0_1_0_0, v0_1_0_1) => {
                    let v4_1: LrcPtr<Dice::UH1> = v0_1_0_1.clone();
                    let v3_1: u8 = v0_1_0_0.clone();
                    if v3_1 > 1_u8 {
                        let v8: i64 = (v3_1 - 1_u8) as i64 * 101559956668416_i64;
                        let v9: string = sprintf!(
                            "accumulate_dice_rolls / power: {} / acc: {} / roll: {} / value: {}",
                            &18_i8,
                            &v1_1,
                            &v3_1,
                            &v8
                        );
                        println!("{0}", v9,);
                        Dice::method21(v4_1.clone(), v1_1 + v8)
                    } else {
                        let v12: string = sprintf!(
                            "accumulate_dice_rolls / power: {} / acc: {} / roll: {}",
                            &18_i8,
                            &v1_1,
                            &v3_1
                        );
                        println!("{0}", v12,);
                        Dice::method21(v4_1, v1_1)
                    }
                }
            }
        }
        pub fn method19(v0_1: LrcPtr<Dice::UH1>, v1_1: i64) -> Dice::US5 {
            match v0_1.as_ref() {
                Dice::UH1::UH1_1 => Dice::US5::US5_0,
                Dice::UH1::UH1_0(v0_1_0_0, v0_1_0_1) => {
                    let v4_1: LrcPtr<Dice::UH1> = v0_1_0_1.clone();
                    let v3_1: u8 = v0_1_0_0.clone();
                    if v3_1 > 1_u8 {
                        let v8: i64 = (v3_1 - 1_u8) as i64 * 609359740010496_i64;
                        let v9: string = sprintf!(
                            "accumulate_dice_rolls / power: {} / acc: {} / roll: {} / value: {}",
                            &19_i8,
                            &v1_1,
                            &v3_1,
                            &v8
                        );
                        println!("{0}", v9,);
                        Dice::method20(v4_1.clone(), v1_1 + v8)
                    } else {
                        let v12: string = sprintf!(
                            "accumulate_dice_rolls / power: {} / acc: {} / roll: {}",
                            &19_i8,
                            &v1_1,
                            &v3_1
                        );
                        println!("{0}", v12,);
                        Dice::method20(v4_1, v1_1)
                    }
                }
            }
        }
        pub fn method18(v0_1: LrcPtr<Dice::UH1>, v1_1: i64) -> Dice::US5 {
            match v0_1.as_ref() {
                Dice::UH1::UH1_1 => Dice::US5::US5_0,
                Dice::UH1::UH1_0(v0_1_0_0, v0_1_0_1) => {
                    let v4_1: LrcPtr<Dice::UH1> = v0_1_0_1.clone();
                    let v3_1: u8 = v0_1_0_0.clone();
                    if v3_1 > 1_u8 {
                        let v8: i64 = (v3_1 - 1_u8) as i64 * 3656158440062976_i64;
                        let v9: string = sprintf!(
                            "accumulate_dice_rolls / power: {} / acc: {} / roll: {} / value: {}",
                            &20_i8,
                            &v1_1,
                            &v3_1,
                            &v8
                        );
                        println!("{0}", v9,);
                        Dice::method19(v4_1.clone(), v1_1 + v8)
                    } else {
                        let v12: string = sprintf!(
                            "accumulate_dice_rolls / power: {} / acc: {} / roll: {}",
                            &20_i8,
                            &v1_1,
                            &v3_1
                        );
                        println!("{0}", v12,);
                        Dice::method19(v4_1, v1_1)
                    }
                }
            }
        }
        pub fn method17(v0_1: LrcPtr<Dice::UH1>, v1_1: i64) -> Dice::US5 {
            match v0_1.as_ref() {
                Dice::UH1::UH1_1 => Dice::US5::US5_0,
                Dice::UH1::UH1_0(v0_1_0_0, v0_1_0_1) => {
                    let v4_1: LrcPtr<Dice::UH1> = v0_1_0_1.clone();
                    let v3_1: u8 = v0_1_0_0.clone();
                    if v3_1 > 1_u8 {
                        let v8: i64 = (v3_1 - 1_u8) as i64 * 21936950640377856_i64;
                        let v9: string = sprintf!(
                            "accumulate_dice_rolls / power: {} / acc: {} / roll: {} / value: {}",
                            &21_i8,
                            &v1_1,
                            &v3_1,
                            &v8
                        );
                        println!("{0}", v9,);
                        Dice::method18(v4_1.clone(), v1_1 + v8)
                    } else {
                        let v12: string = sprintf!(
                            "accumulate_dice_rolls / power: {} / acc: {} / roll: {}",
                            &21_i8,
                            &v1_1,
                            &v3_1
                        );
                        println!("{0}", v12,);
                        Dice::method18(v4_1, v1_1)
                    }
                }
            }
        }
        pub fn method16(v0_1: LrcPtr<Dice::UH1>, v1_1: i64) -> Dice::US5 {
            match v0_1.as_ref() {
                Dice::UH1::UH1_1 => Dice::US5::US5_0,
                Dice::UH1::UH1_0(v0_1_0_0, v0_1_0_1) => {
                    let v4_1: LrcPtr<Dice::UH1> = v0_1_0_1.clone();
                    let v3_1: u8 = v0_1_0_0.clone();
                    if v3_1 > 1_u8 {
                        let v8: i64 = (v3_1 - 1_u8) as i64 * 131621703842267136_i64;
                        let v9: string = sprintf!(
                            "accumulate_dice_rolls / power: {} / acc: {} / roll: {} / value: {}",
                            &22_i8,
                            &v1_1,
                            &v3_1,
                            &v8
                        );
                        println!("{0}", v9,);
                        Dice::method17(v4_1.clone(), v1_1 + v8)
                    } else {
                        let v12: string = sprintf!(
                            "accumulate_dice_rolls / power: {} / acc: {} / roll: {}",
                            &22_i8,
                            &v1_1,
                            &v3_1
                        );
                        println!("{0}", v12,);
                        Dice::method17(v4_1, v1_1)
                    }
                }
            }
        }
        pub fn method15(v0_1: LrcPtr<Dice::UH1>, v1_1: i64) -> Dice::US5 {
            match v0_1.as_ref() {
                Dice::UH1::UH1_1 => Dice::US5::US5_0,
                Dice::UH1::UH1_0(v0_1_0_0, v0_1_0_1) => {
                    let v4_1: LrcPtr<Dice::UH1> = v0_1_0_1.clone();
                    let v3_1: u8 = v0_1_0_0.clone();
                    if v3_1 > 1_u8 {
                        let v8: i64 = (v3_1 - 1_u8) as i64 * 789730223053602816_i64;
                        let v9: string = sprintf!(
                            "accumulate_dice_rolls / power: {} / acc: {} / roll: {} / value: {}",
                            &23_i8,
                            &v1_1,
                            &v3_1,
                            &v8
                        );
                        println!("{0}", v9,);
                        Dice::method16(v4_1.clone(), v1_1 + v8)
                    } else {
                        let v12: string = sprintf!(
                            "accumulate_dice_rolls / power: {} / acc: {} / roll: {}",
                            &23_i8,
                            &v1_1,
                            &v3_1
                        );
                        println!("{0}", v12,);
                        Dice::method16(v4_1, v1_1)
                    }
                }
            }
        }
        pub fn method14(v0_1: LrcPtr<Dice::UH1>, v1_1: i8) -> i64 {
            let v0_1: MutCell<LrcPtr<Dice::UH1>> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<i8> = MutCell::new(v1_1);
            '_method14: loop {
                break '_method14 (if v1_1.get() < 24_i8 {
                    let result: MutCell<Option<u8>> = MutCell::new(None::<u8>);
                    {
                        let x: u8 = 1;
                        result.set(Some(x))
                    }
                    {
                        let v0_1_temp: LrcPtr<Dice::UH1> =
                            LrcPtr::new(Dice::UH1::UH1_0(getValue(result.get()), v0_1.get()));
                        let v1_1_temp: i8 = v1_1.get() + 1_i8;
                        v0_1.set(v0_1_temp);
                        v1_1.set(v1_1_temp);
                        continue '_method14;
                    }
                } else {
                    let v13: Dice::US5 = Dice::method15(v0_1.get(), 0_i64);
                    if let Dice::US5::US5_1(v13_1_0, v13_1_1) = &v13 {
                        let v14: i64 = match &v13 {
                            Dice::US5::US5_1(x, _) => x.clone(),
                            _ => unreachable!(),
                        };
                        if v14 <= i64::MAX {
                            v14
                        } else {
                            let result_1: MutCell<Option<u8>> = MutCell::new(None::<u8>);
                            {
                                let x_1: u8 = 1;
                                result_1.set(Some(x_1))
                            }
                            {
                                let v22: u8 = getValue(result_1.get());
                                let result_2: MutCell<Option<u8>> = MutCell::new(None::<u8>);
                                {
                                    let x_2: u8 = 1;
                                    result_2.set(Some(x_2))
                                }
                                {
                                    let v26: u8 = getValue(result_2.get());
                                    let result_3: MutCell<Option<u8>> = MutCell::new(None::<u8>);
                                    {
                                        let x_3: u8 = 1;
                                        result_3.set(Some(x_3))
                                    }
                                    {
                                        let v30: u8 = getValue(result_3.get());
                                        let result_4: MutCell<Option<u8>> =
                                            MutCell::new(None::<u8>);
                                        {
                                            let x_4: u8 = 1;
                                            result_4.set(Some(x_4))
                                        }
                                        {
                                            let v34: u8 = getValue(result_4.get());
                                            let result_5: MutCell<Option<u8>> =
                                                MutCell::new(None::<u8>);
                                            {
                                                let x_5: u8 = 1;
                                                result_5.set(Some(x_5))
                                            }
                                            {
                                                let v38: u8 = getValue(result_5.get());
                                                let result_6: MutCell<Option<u8>> =
                                                    MutCell::new(None::<u8>);
                                                {
                                                    let x_6: u8 = 1;
                                                    result_6.set(Some(x_6))
                                                }
                                                {
                                                    let v42: u8 = getValue(result_6.get());
                                                    let result_7: MutCell<Option<u8>> =
                                                        MutCell::new(None::<u8>);
                                                    {
                                                        let x_7: u8 = 1;
                                                        result_7.set(Some(x_7))
                                                    }
                                                    {
                                                        let v46: u8 = getValue(result_7.get());
                                                        let result_8: MutCell<Option<u8>> =
                                                            MutCell::new(None::<u8>);
                                                        {
                                                            let x_8: u8 = 1;
                                                            result_8.set(Some(x_8))
                                                        }
                                                        {
                                                            let v50: u8 = getValue(result_8.get());
                                                            let result_9: MutCell<Option<u8>> =
                                                                MutCell::new(None::<u8>);
                                                            {
                                                                let x_9: u8 = 1;
                                                                result_9.set(Some(x_9))
                                                            }
                                                            {
                                                                let v54: u8 =
                                                                    getValue(result_9.get());
                                                                let result_10: MutCell<Option<u8>> =
                                                                    MutCell::new(None::<u8>);
                                                                {
                                                                    let x_10: u8 = 1;
                                                                    result_10.set(Some(x_10))
                                                                }
                                                                {
                                                                    let v58: u8 =
                                                                        getValue(result_10.get());
                                                                    let result_11: MutCell<
                                                                        Option<u8>,
                                                                    > = MutCell::new(None::<u8>);
                                                                    {
                                                                        let x_11: u8 = 1;
                                                                        result_11.set(Some(x_11))
                                                                    }
                                                                    {
                                                                        let v62: u8 = getValue(
                                                                            result_11.get(),
                                                                        );
                                                                        let result_12: MutCell<
                                                                            Option<u8>,
                                                                        > = MutCell::new(
                                                                            None::<u8>,
                                                                        );
                                                                        {
                                                                            let x_12: u8 = 1;
                                                                            result_12
                                                                                .set(Some(x_12))
                                                                        }
                                                                        {
                                                                            let v66: u8 = getValue(
                                                                                result_12.get(),
                                                                            );
                                                                            let result_13: MutCell<
                                                                                Option<u8>,
                                                                            > = MutCell::new(
                                                                                None::<u8>,
                                                                            );
                                                                            {
                                                                                let x_13: u8 = 1;
                                                                                result_13
                                                                                    .set(Some(x_13))
                                                                            }
                                                                            {
                                                                                let v70: u8 =
                                                                                    getValue(
                                                                                        result_13
                                                                                            .get(),
                                                                                    );
                                                                                let result_14:
                                                                                                 MutCell<Option<u8>> =
                                                                                             MutCell::new(None::<u8>);
                                                                                {
                                                                                    let x_14: u8 =
                                                                                        1;
                                                                                    result_14.set(
                                                                                        Some(x_14),
                                                                                    )
                                                                                }
                                                                                {
                                                                                    let v74:
                                                                                                     u8 =
                                                                                                 getValue(result_14.get());
                                                                                    let result_15:
                                                                                                     MutCell<Option<u8>> =
                                                                                                 MutCell::new(None::<u8>);
                                                                                    {
                                                                                        let x_15:
                                                                                                         u8 =
                                                                                                     1;
                                                                                        result_15.set(Some(x_15))
                                                                                    }
                                                                                    {
                                                                                        let v78:
                                                                                                         u8 =
                                                                                                     getValue(result_15.get());
                                                                                        let result_16:
                                                                                                         MutCell<Option<u8>> =
                                                                                                     MutCell::new(None::<u8>);
                                                                                        {
                                                                                            let x_16:
                                                                                                             u8 =
                                                                                                         1;
                                                                                            result_16.set(Some(x_16))
                                                                                        }
                                                                                        {
                                                                                            let v82:
                                                                                                             u8 =
                                                                                                         getValue(result_16.get());
                                                                                            let result_17:
                                                                                                             MutCell<Option<u8>> =
                                                                                                         MutCell::new(None::<u8>);
                                                                                            {
                                                                                                let x_17:
                                                                                                                 u8 =
                                                                                                             1;
                                                                                                result_17.set(Some(x_17))
                                                                                            }
                                                                                            {
                                                                                                let v86:
                                                                                                                 u8 =
                                                                                                             getValue(result_17.get());
                                                                                                let result_18:
                                                                                                                 MutCell<Option<u8>> =
                                                                                                             MutCell::new(None::<u8>);
                                                                                                {
                                                                                                    let x_18:
                                                                                                                     u8 =
                                                                                                                 1;
                                                                                                    result_18.set(Some(x_18))
                                                                                                }
                                                                                                {
                                                                                                    let v90:
                                                                                                                     u8 =
                                                                                                                 getValue(result_18.get());
                                                                                                    let result_19:
                                                                                                                     MutCell<Option<u8>> =
                                                                                                                 MutCell::new(None::<u8>);
                                                                                                    {
                                                                                                        let x_19:
                                                                                                                         u8 =
                                                                                                                     1;
                                                                                                        result_19.set(Some(x_19))
                                                                                                    }
                                                                                                    {
                                                                                                        let v94:
                                                                                                                         u8 =
                                                                                                                     getValue(result_19.get());
                                                                                                        let result_20:
                                                                                                                         MutCell<Option<u8>> =
                                                                                                                     MutCell::new(None::<u8>);
                                                                                                        {
                                                                                                            let x_20:
                                                                                                                             u8 =
                                                                                                                         1;
                                                                                                            result_20.set(Some(x_20))
                                                                                                        }
                                                                                                        {
                                                                                                            let v98:
                                                                                                                             u8 =
                                                                                                                         getValue(result_20.get());
                                                                                                            let result_21:
                                                                                                                             MutCell<Option<u8>> =
                                                                                                                         MutCell::new(None::<u8>);
                                                                                                            {
                                                                                                                let x_21:
                                                                                                                                 u8 =
                                                                                                                             1;
                                                                                                                result_21.set(Some(x_21))
                                                                                                            }
                                                                                                            {
                                                                                                                let v102:
                                                                                                                                 u8 =
                                                                                                                             getValue(result_21.get());
                                                                                                                let result_22:
                                                                                                                                 MutCell<Option<u8>> =
                                                                                                                             MutCell::new(None::<u8>);
                                                                                                                {
                                                                                                                    let x_22:
                                                                                                                                     u8 =
                                                                                                                                 1;
                                                                                                                    result_22.set(Some(x_22))
                                                                                                                }
                                                                                                                {
                                                                                                                    let v106:
                                                                                                                                     u8 =
                                                                                                                                 getValue(result_22.get());
                                                                                                                    let result_23:
                                                                                                                                     MutCell<Option<u8>> =
                                                                                                                                 MutCell::new(None::<u8>);
                                                                                                                    {
                                                                                                                        let x_23:
                                                                                                                                         u8 =
                                                                                                                                     1;
                                                                                                                        result_23.set(Some(x_23))
                                                                                                                    }
                                                                                                                    {
                                                                                                                        let v0_1_temp:
                                                                                                                                         LrcPtr<Dice::UH1> =
                                                                                                                                     LrcPtr::new(Dice::UH1::UH1_0(v22,
                                                                                                                                                                  LrcPtr::new(Dice::UH1::UH1_0(v26,
                                                                                                                                                                                               LrcPtr::new(Dice::UH1::UH1_0(v30,
                                                                                                                                                                                                                            LrcPtr::new(Dice::UH1::UH1_0(v34,
                                                                                                                                                                                                                                                         LrcPtr::new(Dice::UH1::UH1_0(v38,
                                                                                                                                                                                                                                                                                      LrcPtr::new(Dice::UH1::UH1_0(v42,
                                                                                                                                                                                                                                                                                                                   LrcPtr::new(Dice::UH1::UH1_0(v46,
                                                                                                                                                                                                                                                                                                                                                LrcPtr::new(Dice::UH1::UH1_0(v50,
                                                                                                                                                                                                                                                                                                                                                                             LrcPtr::new(Dice::UH1::UH1_0(v54,
                                                                                                                                                                                                                                                                                                                                                                                                          LrcPtr::new(Dice::UH1::UH1_0(v58,
                                                                                                                                                                                                                                                                                                                                                                                                                                       LrcPtr::new(Dice::UH1::UH1_0(v62,
                                                                                                                                                                                                                                                                                                                                                                                                                                                                    LrcPtr::new(Dice::UH1::UH1_0(v66,
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                 LrcPtr::new(Dice::UH1::UH1_0(v70,
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                              LrcPtr::new(Dice::UH1::UH1_0(v74,
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                           LrcPtr::new(Dice::UH1::UH1_0(v78,
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        LrcPtr::new(Dice::UH1::UH1_0(v82,
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                     LrcPtr::new(Dice::UH1::UH1_0(v86,
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                  LrcPtr::new(Dice::UH1::UH1_0(v90,
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                               LrcPtr::new(Dice::UH1::UH1_0(v94,
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            LrcPtr::new(Dice::UH1::UH1_0(v98,
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                         LrcPtr::new(Dice::UH1::UH1_0(v102,
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                      LrcPtr::new(Dice::UH1::UH1_0(v106,
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                   LrcPtr::new(Dice::UH1::UH1_0(getValue(result_23.get()),
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                LrcPtr::new(Dice::UH1::UH1_1)))))))))))))))))))))))))))))))))))))))))))))));
                                                                                                                        let v1_1_temp:
                                                                                                                                         i8 =
                                                                                                                                     23_i8;
                                                                                                                        v0_1.set(v0_1_temp);
                                                                                                                        v1_1.set(v1_1_temp);
                                                                                                                        continue
                                                                                                                                     '_method14;
                                                                                                                    }
                                                                                                                }
                                                                                                            }
                                                                                                        }
                                                                                                    }
                                                                                                }
                                                                                            }
                                                                                        }
                                                                                    }
                                                                                }
                                                                            }
                                                                        }
                                                                    }
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    } else {
                        let result_24: MutCell<Option<u8>> = MutCell::new(None::<u8>);
                        {
                            let x_24: u8 = 1;
                            result_24.set(Some(x_24))
                        }
                        {
                            let v143: u8 = getValue(result_24.get());
                            let result_25: MutCell<Option<u8>> = MutCell::new(None::<u8>);
                            {
                                let x_25: u8 = 1;
                                result_25.set(Some(x_25))
                            }
                            {
                                let v147: u8 = getValue(result_25.get());
                                let result_26: MutCell<Option<u8>> = MutCell::new(None::<u8>);
                                {
                                    let x_26: u8 = 1;
                                    result_26.set(Some(x_26))
                                }
                                {
                                    let v151: u8 = getValue(result_26.get());
                                    let result_27: MutCell<Option<u8>> = MutCell::new(None::<u8>);
                                    {
                                        let x_27: u8 = 1;
                                        result_27.set(Some(x_27))
                                    }
                                    {
                                        let v155: u8 = getValue(result_27.get());
                                        let result_28: MutCell<Option<u8>> =
                                            MutCell::new(None::<u8>);
                                        {
                                            let x_28: u8 = 1;
                                            result_28.set(Some(x_28))
                                        }
                                        {
                                            let v159: u8 = getValue(result_28.get());
                                            let result_29: MutCell<Option<u8>> =
                                                MutCell::new(None::<u8>);
                                            {
                                                let x_29: u8 = 1;
                                                result_29.set(Some(x_29))
                                            }
                                            {
                                                let v163: u8 = getValue(result_29.get());
                                                let result_30: MutCell<Option<u8>> =
                                                    MutCell::new(None::<u8>);
                                                {
                                                    let x_30: u8 = 1;
                                                    result_30.set(Some(x_30))
                                                }
                                                {
                                                    let v167: u8 = getValue(result_30.get());
                                                    let result_31: MutCell<Option<u8>> =
                                                        MutCell::new(None::<u8>);
                                                    {
                                                        let x_31: u8 = 1;
                                                        result_31.set(Some(x_31))
                                                    }
                                                    {
                                                        let v171: u8 = getValue(result_31.get());
                                                        let result_32: MutCell<Option<u8>> =
                                                            MutCell::new(None::<u8>);
                                                        {
                                                            let x_32: u8 = 1;
                                                            result_32.set(Some(x_32))
                                                        }
                                                        {
                                                            let v175: u8 =
                                                                getValue(result_32.get());
                                                            let result_33: MutCell<Option<u8>> =
                                                                MutCell::new(None::<u8>);
                                                            {
                                                                let x_33: u8 = 1;
                                                                result_33.set(Some(x_33))
                                                            }
                                                            {
                                                                let v179: u8 =
                                                                    getValue(result_33.get());
                                                                let result_34: MutCell<Option<u8>> =
                                                                    MutCell::new(None::<u8>);
                                                                {
                                                                    let x_34: u8 = 1;
                                                                    result_34.set(Some(x_34))
                                                                }
                                                                {
                                                                    let v183: u8 =
                                                                        getValue(result_34.get());
                                                                    let result_35: MutCell<
                                                                        Option<u8>,
                                                                    > = MutCell::new(None::<u8>);
                                                                    {
                                                                        let x_35: u8 = 1;
                                                                        result_35.set(Some(x_35))
                                                                    }
                                                                    {
                                                                        let v187: u8 = getValue(
                                                                            result_35.get(),
                                                                        );
                                                                        let result_36: MutCell<
                                                                            Option<u8>,
                                                                        > = MutCell::new(
                                                                            None::<u8>,
                                                                        );
                                                                        {
                                                                            let x_36: u8 = 1;
                                                                            result_36
                                                                                .set(Some(x_36))
                                                                        }
                                                                        {
                                                                            let v191: u8 = getValue(
                                                                                result_36.get(),
                                                                            );
                                                                            let result_37: MutCell<
                                                                                Option<u8>,
                                                                            > = MutCell::new(
                                                                                None::<u8>,
                                                                            );
                                                                            {
                                                                                let x_37: u8 = 1;
                                                                                result_37
                                                                                    .set(Some(x_37))
                                                                            }
                                                                            {
                                                                                let v195: u8 =
                                                                                    getValue(
                                                                                        result_37
                                                                                            .get(),
                                                                                    );
                                                                                let result_38:
                                                                                                 MutCell<Option<u8>> =
                                                                                             MutCell::new(None::<u8>);
                                                                                {
                                                                                    let x_38: u8 =
                                                                                        1;
                                                                                    result_38.set(
                                                                                        Some(x_38),
                                                                                    )
                                                                                }
                                                                                {
                                                                                    let v199:
                                                                                                     u8 =
                                                                                                 getValue(result_38.get());
                                                                                    let result_39:
                                                                                                     MutCell<Option<u8>> =
                                                                                                 MutCell::new(None::<u8>);
                                                                                    {
                                                                                        let x_39:
                                                                                                         u8 =
                                                                                                     1;
                                                                                        result_39.set(Some(x_39))
                                                                                    }
                                                                                    {
                                                                                        let v203:
                                                                                                         u8 =
                                                                                                     getValue(result_39.get());
                                                                                        let result_40:
                                                                                                         MutCell<Option<u8>> =
                                                                                                     MutCell::new(None::<u8>);
                                                                                        {
                                                                                            let x_40:
                                                                                                             u8 =
                                                                                                         1;
                                                                                            result_40.set(Some(x_40))
                                                                                        }
                                                                                        {
                                                                                            let v207:
                                                                                                             u8 =
                                                                                                         getValue(result_40.get());
                                                                                            let result_41:
                                                                                                             MutCell<Option<u8>> =
                                                                                                         MutCell::new(None::<u8>);
                                                                                            {
                                                                                                let x_41:
                                                                                                                 u8 =
                                                                                                             1;
                                                                                                result_41.set(Some(x_41))
                                                                                            }
                                                                                            {
                                                                                                let v211:
                                                                                                                 u8 =
                                                                                                             getValue(result_41.get());
                                                                                                let result_42:
                                                                                                                 MutCell<Option<u8>> =
                                                                                                             MutCell::new(None::<u8>);
                                                                                                {
                                                                                                    let x_42:
                                                                                                                     u8 =
                                                                                                                 1;
                                                                                                    result_42.set(Some(x_42))
                                                                                                }
                                                                                                {
                                                                                                    let v215:
                                                                                                                     u8 =
                                                                                                                 getValue(result_42.get());
                                                                                                    let result_43:
                                                                                                                     MutCell<Option<u8>> =
                                                                                                                 MutCell::new(None::<u8>);
                                                                                                    {
                                                                                                        let x_43:
                                                                                                                         u8 =
                                                                                                                     1;
                                                                                                        result_43.set(Some(x_43))
                                                                                                    }
                                                                                                    {
                                                                                                        let v219:
                                                                                                                         u8 =
                                                                                                                     getValue(result_43.get());
                                                                                                        let result_44:
                                                                                                                         MutCell<Option<u8>> =
                                                                                                                     MutCell::new(None::<u8>);
                                                                                                        {
                                                                                                            let x_44:
                                                                                                                             u8 =
                                                                                                                         1;
                                                                                                            result_44.set(Some(x_44))
                                                                                                        }
                                                                                                        {
                                                                                                            let v223:
                                                                                                                             u8 =
                                                                                                                         getValue(result_44.get());
                                                                                                            let result_45:
                                                                                                                             MutCell<Option<u8>> =
                                                                                                                         MutCell::new(None::<u8>);
                                                                                                            {
                                                                                                                let x_45:
                                                                                                                                 u8 =
                                                                                                                             1;
                                                                                                                result_45.set(Some(x_45))
                                                                                                            }
                                                                                                            {
                                                                                                                let v227:
                                                                                                                                 u8 =
                                                                                                                             getValue(result_45.get());
                                                                                                                let result_46:
                                                                                                                                 MutCell<Option<u8>> =
                                                                                                                             MutCell::new(None::<u8>);
                                                                                                                {
                                                                                                                    let x_46:
                                                                                                                                     u8 =
                                                                                                                                 1;
                                                                                                                    result_46.set(Some(x_46))
                                                                                                                }
                                                                                                                {
                                                                                                                    let v0_1_temp:
                                                                                                                                     LrcPtr<Dice::UH1> =
                                                                                                                                 LrcPtr::new(Dice::UH1::UH1_0(v143,
                                                                                                                                                              LrcPtr::new(Dice::UH1::UH1_0(v147,
                                                                                                                                                                                           LrcPtr::new(Dice::UH1::UH1_0(v151,
                                                                                                                                                                                                                        LrcPtr::new(Dice::UH1::UH1_0(v155,
                                                                                                                                                                                                                                                     LrcPtr::new(Dice::UH1::UH1_0(v159,
                                                                                                                                                                                                                                                                                  LrcPtr::new(Dice::UH1::UH1_0(v163,
                                                                                                                                                                                                                                                                                                               LrcPtr::new(Dice::UH1::UH1_0(v167,
                                                                                                                                                                                                                                                                                                                                            LrcPtr::new(Dice::UH1::UH1_0(v171,
                                                                                                                                                                                                                                                                                                                                                                         LrcPtr::new(Dice::UH1::UH1_0(v175,
                                                                                                                                                                                                                                                                                                                                                                                                      LrcPtr::new(Dice::UH1::UH1_0(v179,
                                                                                                                                                                                                                                                                                                                                                                                                                                   LrcPtr::new(Dice::UH1::UH1_0(v183,
                                                                                                                                                                                                                                                                                                                                                                                                                                                                LrcPtr::new(Dice::UH1::UH1_0(v187,
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                             LrcPtr::new(Dice::UH1::UH1_0(v191,
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                          LrcPtr::new(Dice::UH1::UH1_0(v195,
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                       LrcPtr::new(Dice::UH1::UH1_0(v199,
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    LrcPtr::new(Dice::UH1::UH1_0(v203,
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                 LrcPtr::new(Dice::UH1::UH1_0(v207,
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                              LrcPtr::new(Dice::UH1::UH1_0(v211,
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                           LrcPtr::new(Dice::UH1::UH1_0(v215,
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        LrcPtr::new(Dice::UH1::UH1_0(v219,
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                     LrcPtr::new(Dice::UH1::UH1_0(v223,
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                  LrcPtr::new(Dice::UH1::UH1_0(v227,
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                               LrcPtr::new(Dice::UH1::UH1_0(getValue(result_46.get()),
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            LrcPtr::new(Dice::UH1::UH1_1)))))))))))))))))))))))))))))))))))))))))))))));
                                                                                                                    let v1_1_temp:
                                                                                                                                     i8 =
                                                                                                                                 23_i8;
                                                                                                                    v0_1.set(v0_1_temp);
                                                                                                                    v1_1.set(v1_1_temp);
                                                                                                                    continue
                                                                                                                                 '_method14;
                                                                                                                }
                                                                                                            }
                                                                                                        }
                                                                                                    }
                                                                                                }
                                                                                            }
                                                                                        }
                                                                                    }
                                                                                }
                                                                            }
                                                                        }
                                                                    }
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                });
            }
        }
        pub fn closure81(unitVar: (), v0_1: Array<string>) -> i32 {
            let v1_1: string = sprintf!(
                "calculate_dice_count / max: {} / n: {} / p: {}",
                &i64::MAX,
                &24_i8,
                &4738381338321616896_i64
            );
            println!("{0}", v1_1,);
            {
                let v5: string = sprintf!(
                    "result: {}",
                    &Dice::method14(LrcPtr::new(Dice::UH1::UH1_1), 0_i8)
                );
                println!("{0}", v5,);
                0_i32
            }
        }
        pub fn v0() -> Func1<i64, Func1<LrcPtr<Dice::UH0>, LrcPtr<Dice::UH0>>> {
            static v0: MutCell<Option<Func1<i64, Func1<LrcPtr<Dice::UH0>, LrcPtr<Dice::UH0>>>>> =
                MutCell::new(None);
            v0.get_or_init(|| Func1::new(move |v: i64| Dice::closure0((), v)))
        }
        pub fn rotate_numbers(x: i64) -> Func1<LrcPtr<Dice::UH0>, LrcPtr<Dice::UH0>> {
            (Dice::v0())(x)
        }
        pub fn v1() -> Func1<Option<Func1<string, ()>>, Func1<LrcPtr<Dice::UH1>, Func0<u8>>> {
            static v1: MutCell<
                Option<Func1<Option<Func1<string, ()>>, Func1<LrcPtr<Dice::UH1>, Func0<u8>>>>,
            > = MutCell::new(None);
            v1.get_or_init(|| Func1::new(move |v: Option<Func1<string, ()>>| Dice::closure3((), v)))
        }
        pub fn create_sequential_roller(
            x: Option<Func1<string, ()>>,
        ) -> Func1<LrcPtr<Dice::UH1>, Func0<u8>> {
            (Dice::v1())(x)
        }
        pub fn v2(
        ) -> Func1<Option<Func1<string, ()>>, Func1<Func0<u8>, Func1<bool, Func1<u64, u64>>>>
        {
            static v2: MutCell<
                Option<
                    Func1<
                        Option<Func1<string, ()>>,
                        Func1<Func0<u8>, Func1<bool, Func1<u64, u64>>>,
                    >,
                >,
            > = MutCell::new(None);
            v2.get_or_init(|| {
                Func1::new(move |v: Option<Func1<string, ()>>| Dice::closure10((), v))
            })
        }
        pub fn roll_progressively(
            x: Option<Func1<string, ()>>,
        ) -> Func1<Func0<u8>, Func1<bool, Func1<u64, u64>>> {
            (Dice::v2())(x)
        }
        pub fn v3(
        ) -> Func1<Option<Func1<string, ()>>, Func1<u64, Func1<LrcPtr<Dice::UH1>, Option<u64>>>>
        {
            static v3: MutCell<
                Option<
                    Func1<
                        Option<Func1<string, ()>>,
                        Func1<u64, Func1<LrcPtr<Dice::UH1>, Option<u64>>>,
                    >,
                >,
            > = MutCell::new(None);
            v3.get_or_init(|| {
                Func1::new(move |v: Option<Func1<string, ()>>| Dice::closure78((), v))
            })
        }
        pub fn roll_within_bounds(
            x: Option<Func1<string, ()>>,
        ) -> Func1<u64, Func1<LrcPtr<Dice::UH1>, Option<u64>>> {
            (Dice::v3())(x)
        }
        pub fn v4() -> Func1<Array<string>, i32> {
            static v4: MutCell<Option<Func1<Array<string>, i32>>> = MutCell::new(None);
            v4.get_or_init(|| Func1::new(move |v: Array<string>| Dice::closure81((), v)))
        }
        pub fn main(args: Array<string>) -> i32 {
            (Dice::v4())(args)
        }
    }
}
pub use module_a51efde0::*;
#[path = "../../lib/fsharp/CommonWasm.rs"]
mod module_ad43931;
pub use module_ad43931::*;
pub mod Polyglot {
    pub use crate::module_ad43931::Polyglot::*;
}
pub fn main() {
    let args = std::env::args().skip(1).map(fromString).collect();
    Dice::main(array_from(args));
}
