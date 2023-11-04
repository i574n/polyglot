import { map, item as item_1, iterate, unfold, cache } from "./fable_modules/fable-library-ts/Seq.js";
import { int32 } from "./fable_modules/fable-library-ts/Int32.js";
import { value as value_1, toArray, Option } from "./fable_modules/fable-library-ts/Option.js";
import { empty, initialize, cons, tryItem, length, tail, head, isEmpty, FSharpList } from "./fable_modules/fable-library-ts/List.js";
import { nonSeeded } from "./fable_modules/fable-library-ts/Random.js";
import { printf, toConsole } from "./fable_modules/fable-library-ts/String.js";
import { TraceLevel_Debug, trace } from "./lib/fsharp/Common.js";

export const sixthPowerSequence: Iterable<int32> = cache<int32>(unfold<int32, int32>((state: int32): Option<[int32, int32]> => ([state, state * 6] as [int32, int32]), 1));

/**
 * ## accumulateDiceRolls
 */
export function accumulateDiceRolls(log_mut: Option<((arg0: string) => void)>, rolls_mut: FSharpList<int32>, power_mut: int32, acc_mut: int32): Option<[int32, FSharpList<int32>]> {
    let arg: string, arg_1: string, arg_2: string;
    accumulateDiceRolls:
    while (true) {
        const log: Option<((arg0: string) => void)> = log_mut, rolls: FSharpList<int32> = rolls_mut, power: int32 = power_mut, acc: int32 = acc_mut;
        if (power < 0) {
            iterate<((arg0: string) => void)>((arg = (`accumulateDiceRolls / power: ${power} / acc: ${acc}`), (func: ((arg0: string) => void)): void => {
                func(arg);
            }), toArray<((arg0: string) => void)>(log));
            return [acc + 1, rolls] as [int32, FSharpList<int32>];
        }
        else if (!isEmpty(rolls)) {
            if (head(rolls) > 1) {
                const value: int32 = ((head(rolls) - 1) * item_1<int32>(power, sixthPowerSequence)) | 0;
                iterate<((arg0: string) => void)>((arg_1 = (`accumulateDiceRolls / power: ${power} / acc: ${acc} / roll: ${head(rolls)} / value: ${value}`), (func_1: ((arg0: string) => void)): void => {
                    func_1(arg_1);
                }), toArray<((arg0: string) => void)>(log));
                log_mut = log;
                rolls_mut = tail(rolls);
                power_mut = (power - 1);
                acc_mut = (acc + value);
                continue accumulateDiceRolls;
            }
            else {
                iterate<((arg0: string) => void)>((arg_2 = (`accumulateDiceRolls / power: ${power} / acc: ${acc} / roll: ${head(rolls)}`), (func_2: ((arg0: string) => void)): void => {
                    func_2(arg_2);
                }), toArray<((arg0: string) => void)>(log));
                log_mut = log;
                rolls_mut = tail(rolls);
                power_mut = (power - 1);
                acc_mut = acc;
                continue accumulateDiceRolls;
            }
        }
        else {
            return void 0;
        }
        break;
    }
}

/**
 * ## rollWithinBounds
 */
export function rollWithinBounds(log: Option<((arg0: string) => void)>, max: int32, rolls: FSharpList<int32>): Option<int32> {
    let result: int32;
    const matchValue: Option<[int32, FSharpList<int32>]> = accumulateDiceRolls(log, rolls, length<int32>(rolls) - 1, 0);
    let matchResult: int32, result_1: int32;
    if (matchValue != null) {
        if ((result = (value_1(matchValue)[0] | 0), (result >= 1) && (result <= max))) {
            matchResult = 0;
            result_1 = value_1(matchValue)[0];
        }
        else {
            matchResult = 1;
        }
    }
    else {
        matchResult = 1;
    }
    switch (matchResult) {
        case 0:
            return result_1!;
        default:
            return void 0;
    }
}

const random: any = nonSeeded();

export function rollDice(): int32 {
    return random.Next2(1, 7);
}

/**
 * ## rotateNumber
 */
export function rotateNumber(max: int32, n: int32): int32 {
    return (((n - 1) + max) % max) + 1;
}

/**
 * ## rotateNumbers
 */
export function rotateNumbers(max: int32, items: Iterable<int32>): Iterable<int32> {
    return map<int32, int32>((n: int32): int32 => rotateNumber(max, n), items);
}

/**
 * ## createSequentialRoller
 */
export function createSequentialRoller<$a>(list: FSharpList<$a>): (() => $a) {
    let currentIndex = 0;
    return (): $a => {
        const matchValue: Option<$a> = tryItem<$a>(currentIndex, list);
        if (matchValue == null) {
            throw new Error("createSequentialRoller / End of list");
        }
        else {
            const item: $a = value_1(matchValue);
            currentIndex = ((currentIndex + 1) | 0);
            return item;
        }
    };
}

/**
 * ## rollProgressively
 */
export function rollProgressively(log: Option<((arg0: string) => void)>, roll: (() => int32), reroll: boolean, max: int32): int32 {
    let max_1: int32, loop: ((arg0: int32, arg1: int32) => int32);
    const power: int32 = (((max_1 = (max | 0), (loop = ((n_mut: int32, p_mut: int32): int32 => {
        let arg: string;
        loop:
        while (true) {
            const n: int32 = n_mut, p: int32 = p_mut;
            if (p < max_1) {
                n_mut = (n + 1);
                p_mut = (p * 6);
                continue loop;
            }
            else {
                iterate<((arg0: string) => void)>((arg = (`calculateDiceCount / max: ${max_1} / n: ${n} / p: ${p}`), (func: ((arg0: string) => void)): void => {
                    func(arg);
                }), toArray<((arg0: string) => void)>(log));
                return n | 0;
            }
            break;
        }
    }), (max_1 === 1) ? 1 : loop(0, 1)))) - 1) | 0;
    const loop_1 = (rolls_mut: FSharpList<int32>, size_mut: int32): int32 => {
        loop_1:
        while (true) {
            const rolls: FSharpList<int32> = rolls_mut, size: int32 = size_mut;
            if (size < (power + 1)) {
                rolls_mut = cons(roll(), rolls);
                size_mut = (size + 1);
                continue loop_1;
            }
            else {
                const matchValue: Option<[int32, FSharpList<int32>]> = accumulateDiceRolls(log, rolls, power, 0);
                let matchResult: int32, result_1: int32;
                if (matchValue != null) {
                    if (value_1(matchValue)[0] <= max) {
                        matchResult = 0;
                        result_1 = value_1(matchValue)[0];
                    }
                    else if (reroll) {
                        matchResult = 1;
                    }
                    else {
                        matchResult = 2;
                    }
                }
                else if (reroll) {
                    matchResult = 1;
                }
                else {
                    matchResult = 2;
                }
                switch (matchResult) {
                    case 0:
                        return result_1! | 0;
                    case 1: {
                        rolls_mut = initialize<int32>(power, (_arg: int32): int32 => roll());
                        size_mut = power;
                        continue loop_1;
                    }
                    default: {
                        rolls_mut = cons(roll(), rolls);
                        size_mut = (size + 1);
                        continue loop_1;
                    }
                }
            }
            break;
        }
    };
    return loop_1(empty<int32>(), 0) | 0;
}

(function (args: string[]): int32 {
    let clo: ((arg0: string) => void);
    const result: int32 = rollProgressively((clo = toConsole(printf("%s")), (arg: string): void => {
        clo(arg);
    }), rollDice, true, ~~(2147483647 / 10)) | 0;
    trace(TraceLevel_Debug(), (): string => (`main / result: ${result}`), (): string => "");
    return 0;
})(typeof process === 'object' ? process.argv.slice(2) : []);

