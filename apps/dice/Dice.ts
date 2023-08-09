import { item, unfold, cache } from "./fable_modules/fable-library-ts/Seq.js";
import { int32 } from "./fable_modules/fable-library-ts/Int32.js";
import { defaultArg, value as value_1, Option } from "./fable_modules/fable-library-ts/Option.js";
import { toConsole } from "./fable_modules/fable-library-ts/String.js";
import { ofArray, empty, initialize, cons, length, tail, head, isEmpty, FSharpList } from "./fable_modules/fable-library-ts/List.js";
import { nonSeeded } from "./fable_modules/fable-library-ts/Random.js";
import { TraceLevel_Debug, trace } from "./nbs/Common.js";

export const pow6: Iterable<int32> = cache<int32>(unfold<int32, int32>((state: int32): Option<[int32, int32]> => ([state, state * 6] as [int32, int32]), 1));

/**
 * ## rollAcc
 */
export function rollAcc(log_mut: boolean, rolls_mut: FSharpList<int32>, power_mut: int32, acc_mut: int32): Option<[int32, FSharpList<int32>]> {
    rollAcc:
    while (true) {
        const log: boolean = log_mut, rolls: FSharpList<int32> = rolls_mut, power: int32 = power_mut, acc: int32 = acc_mut;
        if (power < 0) {
            if (log) {
                toConsole(`rollAcc / power: ${power} / acc: ${acc}`);
            }
            return [acc + 1, rolls] as [int32, FSharpList<int32>];
        }
        else if (!isEmpty(rolls)) {
            if (head(rolls) > 1) {
                const value: int32 = ((head(rolls) - 1) * item<int32>(power, pow6)) | 0;
                if (log) {
                    toConsole(`rollAcc / power: ${power} / acc: ${acc} / roll: ${head(rolls)} / value: ${value}`);
                }
                log_mut = log;
                rolls_mut = tail(rolls);
                power_mut = (power - 1);
                acc_mut = (acc + value);
                continue rollAcc;
            }
            else {
                if (log) {
                    toConsole(`rollAcc / power: ${power} / acc: ${acc} / roll: ${head(rolls)}`);
                }
                log_mut = log;
                rolls_mut = tail(rolls);
                power_mut = (power - 1);
                acc_mut = acc;
                continue rollAcc;
            }
        }
        else {
            return void 0;
        }
        break;
    }
}

/**
 * ## fixedRoll
 */
export function fixedRoll(log: boolean, max: int32, rolls: FSharpList<int32>): Option<int32> {
    let result: int32;
    const matchValue: Option<[int32, FSharpList<int32>]> = rollAcc(log, rolls, length<int32>(rolls) - 1, 0);
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

/**
 * ## numDices
 */
export function numDices(log: boolean, max: int32): int32 {
    const numDices$0027 = (n_mut: int32, p_mut: int32): int32 => {
        numDices$0027:
        while (true) {
            const n: int32 = n_mut, p: int32 = p_mut;
            if (log) {
                toConsole(`numDices / max: ${max} / n: ${n} / p: ${p}`);
            }
            if (p >= max) {
                return n | 0;
            }
            else {
                n_mut = (n + 1);
                p_mut = (p * 6);
                continue numDices$0027;
            }
            break;
        }
    };
    if (max === 1) {
        return 1;
    }
    else {
        return numDices$0027(0, 1) | 0;
    }
}

const random: any = nonSeeded();

export function rollD6(): int32 {
    return random.Next2(1, 7);
}

/**
 * ## progressiveRoll
 */
export function progressiveRoll(log: boolean, reroll: boolean, max: int32): int32 {
    const power: int32 = (numDices(log, max) - 1) | 0;
    const loop = (rolls_mut: FSharpList<int32>, size_mut: int32): int32 => {
        loop:
        while (true) {
            const rolls: FSharpList<int32> = rolls_mut, size: int32 = size_mut;
            if (size < (power + 1)) {
                rolls_mut = cons(rollD6(), rolls);
                size_mut = (size + 1);
                continue loop;
            }
            else {
                const matchValue: Option<[int32, FSharpList<int32>]> = rollAcc(log, rolls, power, 0);
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
                        rolls_mut = initialize<int32>(power, (_arg: int32): int32 => rollD6());
                        size_mut = power;
                        continue loop;
                    }
                    default: {
                        rolls_mut = cons(rollD6(), rolls);
                        size_mut = (size + 1);
                        continue loop;
                    }
                }
            }
            break;
        }
    };
    return loop(empty<int32>(), 0) | 0;
}

(function (args: string[]): int32 {
    const result: Option<int32> = fixedRoll(true, 2000, ofArray([1, 5, 4, 4, 5]));
    trace(TraceLevel_Debug(), (): string => (`main / result: ${defaultArg(result, -1)}`), (): string => "");
    return 0;
})(typeof process === 'object' ? process.argv.slice(2) : []);

