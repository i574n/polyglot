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
mod module_dc8717e1 {
    pub mod Polyglot {
        use super::*;
        pub mod dice_fsharp {
            use super::*;
            use crate::Polyglot::Common;
            use crate::Polyglot::Common::TraceLevel;
            use fable_library_rust::Interfaces_::System::Collections::Generic::IEnumerable_1;
            use fable_library_rust::List_::cons;
            use fable_library_rust::List_::empty;
            use fable_library_rust::List_::head;
            use fable_library_rust::List_::initialize;
            use fable_library_rust::List_::isEmpty;
            use fable_library_rust::List_::length;
            use fable_library_rust::List_::tail;
            use fable_library_rust::List_::tryItem;
            use fable_library_rust::List_::List;
            use fable_library_rust::NativeArray_::Array;
            use fable_library_rust::Native_::Any;
            use fable_library_rust::Native_::Func0;
            use fable_library_rust::Native_::Func1;
            use fable_library_rust::Native_::Func2;
            use fable_library_rust::Native_::LrcPtr;
            use fable_library_rust::Native_::MutCell;
            use fable_library_rust::Option_::getValue;
            use fable_library_rust::Option_::iterate;
            use fable_library_rust::Seq_::cache;
            use fable_library_rust::Seq_::item as item_1;
            use fable_library_rust::Seq_::map;
            use fable_library_rust::Seq_::unfold;
            use fable_library_rust::String_::sprintf;
            use fable_library_rust::String_::string;
            pub fn sixthPowerSequence() -> LrcPtr<dyn IEnumerable_1<i32>> {
                static sixthPowerSequence: MutCell<Option<LrcPtr<dyn IEnumerable_1<i32>>>> =
                    MutCell::new(None);
                sixthPowerSequence.get_or_init(|| {
                    cache(unfold(
                        Func1::new(move |state: i32| Some(LrcPtr::new((state, state * 6_i32)))),
                        1_i32,
                    ))
                })
            }
            pub fn accumulateDiceRolls(
                log: Option<Func1<string, ()>>,
                rolls: List<i32>,
                power: i32,
                acc: i32,
            ) -> Option<LrcPtr<(i32, List<i32>)>> {
                let log = MutCell::new(log.clone());
                let rolls: MutCell<List<i32>> = MutCell::new(rolls.clone());
                let power: MutCell<i32> = MutCell::new(power);
                let acc: MutCell<i32> = MutCell::new(acc);
                '_accumulateDiceRolls: loop {
                    break '_accumulateDiceRolls (if power.get() < 0_i32 {
                        iterate(
                            {
                                let arg: string = sprintf!(
                                    "accumulateDiceRolls / power: {} / acc: {}",
                                    &power.get(),
                                    &acc.get()
                                );
                                Func1::new({
                                    let arg = arg.clone();
                                    move |func: Func1<string, ()>| func(arg.clone())
                                })
                            },
                            log.get(),
                        );
                        Some(LrcPtr::new((acc.get() + 1_i32, rolls.get())))
                    } else {
                        if !isEmpty(rolls.get()) {
                            if head(rolls.get()) > 1_i32 {
                                let rest_1: List<i32> = tail(rolls.get());
                                let roll_1: i32 = head(rolls.get());
                                let value: i32 = (roll_1 - 1_i32)
                                    * item_1(
                                        power.get(),
                                        Polyglot::dice_fsharp::sixthPowerSequence(),
                                    );
                                iterate(
                                    {
                                        let arg_1: string =
                                                         sprintf!("accumulateDiceRolls / power: {} / acc: {} / roll: {} / value: {}",
                                                                  &power.get(),
                                                                  &acc.get(),
                                                                  &roll_1,
                                                                  &value);
                                        Func1::new({
                                            let arg_1 = arg_1.clone();
                                            move |func_1: Func1<string, ()>| func_1(arg_1.clone())
                                        })
                                    },
                                    log.get(),
                                );
                                {
                                    let log_temp = log.get();
                                    let rolls_temp: List<i32> = rest_1.clone();
                                    let power_temp: i32 = power.get() - 1_i32;
                                    let acc_temp: i32 = acc.get() + value;
                                    log.set(log_temp);
                                    rolls.set(rolls_temp);
                                    power.set(power_temp);
                                    acc.set(acc_temp);
                                    continue '_accumulateDiceRolls;
                                }
                            } else {
                                let rest_2: List<i32> = tail(rolls.get());
                                let roll_2: i32 = head(rolls.get());
                                iterate(
                                    {
                                        let arg_2: string = sprintf!(
                                            "accumulateDiceRolls / power: {} / acc: {} / roll: {}",
                                            &power.get(),
                                            &acc.get(),
                                            &roll_2
                                        );
                                        Func1::new({
                                            let arg_2 = arg_2.clone();
                                            move |func_2: Func1<string, ()>| func_2(arg_2.clone())
                                        })
                                    },
                                    log.get(),
                                );
                                {
                                    let log_temp = log.get();
                                    let rolls_temp: List<i32> = rest_2.clone();
                                    let power_temp: i32 = power.get() - 1_i32;
                                    let acc_temp: i32 = acc.get();
                                    log.set(log_temp);
                                    rolls.set(rolls_temp);
                                    power.set(power_temp);
                                    acc.set(acc_temp);
                                    continue '_accumulateDiceRolls;
                                }
                            }
                        } else {
                            None::<LrcPtr<(i32, List<i32>)>>
                        }
                    });
                }
            }
            pub fn rollWithinBounds(
                log: Option<Func1<string, ()>>,
                max: i32,
                rolls: List<i32>,
            ) -> Option<i32> {
                let matchValue: Option<LrcPtr<(i32, List<i32>)>> =
                    Polyglot::dice_fsharp::accumulateDiceRolls(
                        log,
                        rolls.clone(),
                        length(rolls) - 1_i32,
                        0_i32,
                    );
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
            pub fn rollDice() -> i32 {
                1_i32
            }
            pub fn rotateNumber(max: i32, n: i32) -> i32 {
                (n - 1_i32 + max) % max + 1_i32
            }
            pub fn rotateNumbers(
                max: i32,
                items: LrcPtr<dyn IEnumerable_1<i32>>,
            ) -> LrcPtr<dyn IEnumerable_1<i32>> {
                map(
                    Func1::new({
                        let max = max.clone();
                        move |n: i32| Polyglot::dice_fsharp::rotateNumber(max, n)
                    }),
                    items,
                )
            }
            pub fn createSequentialRoller<a: Clone + 'static>(list: List<a>) -> Func0<a> {
                let currentIndex: LrcPtr<MutCell<i32>> = LrcPtr::new(MutCell::new(0_i32));
                Func0::new({
                    let currentIndex = currentIndex.clone();
                    let list = list.clone();
                    move || {
                        let matchValue: Option<a> = tryItem(currentIndex.get(), list.clone());
                        match &matchValue {
                            None => panic!("{}", string("createSequentialRoller / End of list"),),
                            Some(matchValue_0_0) => {
                                let item: a = matchValue_0_0.clone();
                                currentIndex.set(currentIndex.get() + 1_i32);
                                item
                            }
                        }
                    }
                })
            }
            pub fn rollProgressively(
                log: Option<Func1<string, ()>>,
                roll: Func0<i32>,
                reroll: bool,
                max: i32,
            ) -> i32 {
                let power: i32 = {
                    let max_1: i32 = max;
                    let r#loop = Func2::new({
                        let log = log.clone();
                        let max_1 = max_1.clone();
                        move |n: i32, p: i32| {
                            let n: MutCell<i32> = MutCell::new(n);
                            let p: MutCell<i32> = MutCell::new(p);
                            '_loop: loop {
                                break '_loop (if p.get() < max_1 {
                                    let n_temp: i32 = n.get() + 1_i32;
                                    let p_temp: i32 = p.get() * 6_i32;
                                    n.set(n_temp);
                                    p.set(p_temp);
                                    continue '_loop;
                                } else {
                                    iterate(
                                        {
                                            let arg: string = sprintf!(
                                                "calculateDiceCount / max: {} / n: {} / p: {}",
                                                &max_1,
                                                &n.get(),
                                                &p.get()
                                            );
                                            Func1::new({
                                                let arg = arg.clone();
                                                move |func: Func1<string, ()>| func(arg.clone())
                                            })
                                        },
                                        log.clone(),
                                    );
                                    n.get()
                                });
                            }
                        }
                    });
                    if max_1 == 1_i32 {
                        1_i32
                    } else {
                        r#loop(0_i32, 1_i32)
                    }
                } - 1_i32;
                let loop_1 = Func2::new({
                    let log = log.clone();
                    let max = max.clone();
                    let power = power.clone();
                    let reroll = reroll.clone();
                    let roll = roll.clone();
                    move |rolls: List<i32>, size: i32| {
                        let rolls: MutCell<List<i32>> = MutCell::new(rolls.clone());
                        let size: MutCell<i32> = MutCell::new(size);
                        '_loop_1: loop {
                            break '_loop_1 (if size.get() < power + 1_i32 {
                                let rolls_temp: List<i32> = cons(roll(), rolls.get());
                                let size_temp: i32 = size.get() + 1_i32;
                                rolls.set(rolls_temp);
                                size.set(size_temp);
                                continue '_loop_1;
                            } else {
                                let matchValue: Option<LrcPtr<(i32, List<i32>)>> =
                                    Polyglot::dice_fsharp::accumulateDiceRolls(
                                        log.clone(),
                                        rolls.get(),
                                        power,
                                        0_i32,
                                    );
                                if matchValue.is_some() {
                                    if (getValue(matchValue.clone())).0.clone() <= max {
                                        let result_1: i32 =
                                            (getValue(matchValue.clone())).0.clone();
                                        result_1
                                    } else {
                                        if reroll {
                                            let rolls_temp: List<i32> = initialize(
                                                power,
                                                Func1::new({
                                                    let roll = roll.clone();
                                                    move |_arg: i32| roll()
                                                }),
                                            );
                                            let size_temp: i32 = power;
                                            rolls.set(rolls_temp);
                                            size.set(size_temp);
                                            continue '_loop_1;
                                        } else {
                                            let rolls_temp: List<i32> = cons(roll(), rolls.get());
                                            let size_temp: i32 = size.get() + 1_i32;
                                            rolls.set(rolls_temp);
                                            size.set(size_temp);
                                            continue '_loop_1;
                                        }
                                    }
                                } else {
                                    if reroll {
                                        let rolls_temp: List<i32> = initialize(
                                            power,
                                            Func1::new({
                                                let roll = roll.clone();
                                                move |_arg: i32| roll()
                                            }),
                                        );
                                        let size_temp: i32 = power;
                                        rolls.set(rolls_temp);
                                        size.set(size_temp);
                                        continue '_loop_1;
                                    } else {
                                        let rolls_temp: List<i32> = cons(roll(), rolls.get());
                                        let size_temp: i32 = size.get() + 1_i32;
                                        rolls.set(rolls_temp);
                                        size.set(size_temp);
                                        continue '_loop_1;
                                    }
                                }
                            });
                        }
                    }
                });
                loop_1(empty::<i32>(), 0_i32)
            }
            pub fn main(args: Array<string>) -> i32 {
                let result: i32 = Polyglot::dice_fsharp::rollProgressively(
                    Some({
                        fn clo(a0: string) {
                            println!("{}", a0);
                        }
                        Func1::new({
                            let clo = clo.clone();
                            move |arg: string| clo(arg)
                        })
                    }),
                    Func0::new(move || Polyglot::dice_fsharp::rollDice()),
                    true,
                    i32::MAX / 10_i32,
                );
                Common::trace(
                    LrcPtr::new(TraceLevel::Debug),
                    Func0::new({
                        let result = result.clone();
                        move || sprintf!("main / result: {}", &result)
                    }),
                    Func0::new(move || string("")),
                );
                0_i32
            }
        }
    }
}
pub use module_dc8717e1::*;
#[path = "../../../lib/fsharp/CommonWasm.rs"]
mod module_8cb3e09e;
pub use module_8cb3e09e::*;
pub mod Polyglot {
    pub use crate::module_8cb3e09e::Polyglot::*;
    pub use crate::module_dc8717e1::Polyglot::*;
}
pub fn main() {
    let args = std::env::args().skip(1).map(fromString).collect();
    Polyglot::dice_fsharp::main(array_from(args));
}
