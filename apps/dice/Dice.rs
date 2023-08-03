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
pub mod Polyglot {
    use super::*;
    pub mod Dice {
        use super::*;
        use fable_library_rust::Interfaces_::System::Collections::Generic::IEnumerable_1;
        use fable_library_rust::List_::cons;
        use fable_library_rust::List_::empty;
        use fable_library_rust::List_::head;
        use fable_library_rust::List_::initialize;
        use fable_library_rust::List_::isEmpty;
        use fable_library_rust::List_::length;
        use fable_library_rust::List_::tail;
        use fable_library_rust::List_::List;
        use fable_library_rust::Native_::Any;
        use fable_library_rust::Native_::Func1;
        use fable_library_rust::Native_::Func2;
        use fable_library_rust::Native_::LrcPtr;
        use fable_library_rust::Native_::MutCell;
        use fable_library_rust::Option_::getValue;
        use fable_library_rust::Seq_::cache;
        use fable_library_rust::Seq_::item;
        use fable_library_rust::Seq_::unfold;
        use fable_library_rust::String_::string;

        pub fn pow6() -> LrcPtr<dyn IEnumerable_1<i32>> {
            static pow6: MutCell<Option<LrcPtr<dyn IEnumerable_1<i32>>>> = MutCell::new(None);
            pow6.get_or_init(|| {
                cache(unfold(
                    Func1::new(move |state: i32| Some(LrcPtr::new((state, state * 6_i32)))),
                    1_i32,
                ))
            })
        }
        pub fn rollAcc(
            log: bool,
            rolls: List<i32>,
            power: i32,
            acc: i32,
        ) -> Option<LrcPtr<(i32, List<i32>)>> {
            let log: MutCell<bool> = MutCell::new(log);
            let rolls: MutCell<List<i32>> = MutCell::new(rolls.clone());
            let power: MutCell<i32> = MutCell::new(power);
            let acc: MutCell<i32> = MutCell::new(acc);
            '_rollAcc: loop {
                break '_rollAcc (if power.get() < 0_i32 {
                    if log.get() {
                        println!("rollAcc / power: {} / acc: {}", &power.get(), &acc.get(),);
                    }
                    Some(LrcPtr::new((acc.get() + 1_i32, rolls.get())))
                } else {
                    if !isEmpty(rolls.get()) {
                        if head(rolls.get()) > 1_i32 {
                            let rest_1: List<i32> = tail(rolls.get());
                            let roll_1: i32 = head(rolls.get());
                            let value: i32 =
                                (roll_1 - 1_i32) * item(power.get(), Polyglot::Dice::pow6());
                            if log.get() {
                                println!(
                                    "rollAcc / power: {} / acc: {} / roll: {} / value: {}",
                                    &power.get(),
                                    &acc.get(),
                                    &roll_1,
                                    &value,
                                );
                            }
                            {
                                let log_temp: bool = log.get();
                                let rolls_temp: List<i32> = rest_1.clone();
                                let power_temp: i32 = power.get() - 1_i32;
                                let acc_temp: i32 = acc.get() + value;
                                log.set(log_temp);
                                rolls.set(rolls_temp);
                                power.set(power_temp);
                                acc.set(acc_temp);
                                continue '_rollAcc;
                            }
                        } else {
                            let rest_2: List<i32> = tail(rolls.get());
                            let roll_2: i32 = head(rolls.get());
                            if log.get() {
                                println!(
                                    "rollAcc / power: {} / acc: {} / roll: {}",
                                    &power.get(),
                                    &acc.get(),
                                    &roll_2,
                                );
                            }
                            {
                                let log_temp: bool = log.get();
                                let rolls_temp: List<i32> = rest_2.clone();
                                let power_temp: i32 = power.get() - 1_i32;
                                let acc_temp: i32 = acc.get();
                                log.set(log_temp);
                                rolls.set(rolls_temp);
                                power.set(power_temp);
                                acc.set(acc_temp);
                                continue '_rollAcc;
                            }
                        }
                    } else {
                        None::<LrcPtr<(i32, List<i32>)>>
                    }
                });
            }
        }
        pub fn fixedRoll(log: bool, max: i32, rolls: List<i32>) -> Option<i32> {
            let matchValue: Option<LrcPtr<(i32, List<i32>)>> =
                Polyglot::Dice::rollAcc(log, rolls.clone(), length(rolls) - 1_i32, 0_i32);
            if matchValue.is_some() {
                if {
                    let result: i32 = (getValue(matchValue.clone())).0.clone();
                    if result >= 1_i32 {
                        result <= max
                    } else {
                        false
                    }
                } {
                    let result_1: i32 = (getValue(matchValue.clone())).0.clone();
                    Some(result_1)
                } else {
                    None::<i32>
                }
            } else {
                None::<i32>
            }
        }
        pub fn numDices(log: bool, max: i32) -> i32 {
            let numDices_ = Func2::new({
                let log = log.clone();
                let max = max.clone();
                move |n: i32, p: i32| {
                    let n: MutCell<i32> = MutCell::new(n);
                    let p: MutCell<i32> = MutCell::new(p);
                    '_numDices_: loop {
                        break '_numDices_ ({
                            if log {
                                println!(
                                    "numDices / max: {} / n: {} / p: {}",
                                    &max,
                                    &n.get(),
                                    &p.get(),
                                );
                            }
                            if p.get() >= max {
                                n.get()
                            } else {
                                let n_temp: i32 = n.get() + 1_i32;
                                let p_temp: i32 = p.get() * 6_i32;
                                n.set(n_temp);
                                p.set(p_temp);
                                continue '_numDices_;
                            }
                        });
                    }
                }
            });
            if max == 1_i32 {
                1_i32
            } else {
                numDices_(0_i32, 1_i32)
            }
        }
        fn random() -> LrcPtr<i32> {
            static random: MutCell<Option<LrcPtr<i32>>> = MutCell::new(None);
            random.get_or_init(|| ())
        }
        pub fn rollD6() -> i32 {
            randomNext(1_i32, 7_i32)
        }
        pub fn progressiveRoll(log: bool, reroll: bool, max: i32) -> i32 {
            let power: i32 = Polyglot::Dice::numDices(log, max) - 1_i32;
            let r#loop = Func2::new({
                let log = log.clone();
                let max = max.clone();
                let power = power.clone();
                let reroll = reroll.clone();
                move |rolls: List<i32>, size: i32| {
                    let rolls: MutCell<List<i32>> = MutCell::new(rolls.clone());
                    let size: MutCell<i32> = MutCell::new(size);
                    '_loop: loop {
                        break '_loop (if size.get() < power + 1_i32 {
                            let rolls_temp: List<i32> = cons(Polyglot::Dice::rollD6(), rolls.get());
                            let size_temp: i32 = size.get() + 1_i32;
                            rolls.set(rolls_temp);
                            size.set(size_temp);
                            continue '_loop;
                        } else {
                            let matchValue: Option<LrcPtr<(i32, List<i32>)>> =
                                Polyglot::Dice::rollAcc(log, rolls.get(), power, 0_i32);
                            if matchValue.is_some() {
                                if (getValue(matchValue.clone())).0.clone() <= max {
                                    let result_1: i32 = (getValue(matchValue.clone())).0.clone();
                                    result_1
                                } else {
                                    if reroll {
                                        let rolls_temp: List<i32> = initialize(
                                            power,
                                            Func1::new(move |_arg: i32| Polyglot::Dice::rollD6()),
                                        );
                                        let size_temp: i32 = power;
                                        rolls.set(rolls_temp);
                                        size.set(size_temp);
                                        continue '_loop;
                                    } else {
                                        let rolls_temp: List<i32> =
                                            cons(Polyglot::Dice::rollD6(), rolls.get());
                                        let size_temp: i32 = size.get() + 1_i32;
                                        rolls.set(rolls_temp);
                                        size.set(size_temp);
                                        continue '_loop;
                                    }
                                }
                            } else {
                                if reroll {
                                    let rolls_temp: List<i32> = initialize(
                                        power,
                                        Func1::new(move |_arg: i32| Polyglot::Dice::rollD6()),
                                    );
                                    let size_temp: i32 = power;
                                    rolls.set(rolls_temp);
                                    size.set(size_temp);
                                    continue '_loop;
                                } else {
                                    let rolls_temp: List<i32> =
                                        cons(Polyglot::Dice::rollD6(), rolls.get());
                                    let size_temp: i32 = size.get() + 1_i32;
                                    rolls.set(rolls_temp);
                                    size.set(size_temp);
                                    continue '_loop;
                                }
                            }
                        });
                    }
                }
            });
            r#loop(empty::<i32>(), 0_i32)
        }
    }
}
#[path = "../../nbs/Common.rs"]
mod module_394e13d8;
pub use module_394e13d8::*;
