import sys
from typing import (Tuple, Optional, Any, Callable)
from nbs.common import (trace, TraceLevel)
from fable_modules.fable_library.list import (FSharpList, is_empty, head, tail, length, cons, initialize, empty, of_array)
from fable_modules.fable_library.seq import (cache, unfold, item)
from fable_modules.fable_library.string_ import to_console
from fable_modules.fable_library.types import Array
from fable_modules.fable_library.util import (IEnumerable_1, randint)

def generator(state: int) -> Optional[Tuple[int, int]]:
    return (state, state * 6)


pow6: IEnumerable_1[int] = cache(unfold(generator, 1))

def roll_acc(log_mut: bool, rolls_mut: FSharpList[int], power_mut: int, acc_mut: int) -> Optional[Tuple[int, FSharpList[int]]]:
    while True:
        (log, rolls, power, acc) = (log_mut, rolls_mut, power_mut, acc_mut)
        if power < 0:
            if log:
                to_console(((("rollAcc / power: " + str(power)) + " / acc: ") + str(acc)) + "")

            return (acc + 1, rolls)

        elif not is_empty(rolls):
            if head(rolls) > 1:
                value: int = ((head(rolls) - 1) * item(power, pow6)) or 0
                if log:
                    to_console(((((((("rollAcc / power: " + str(power)) + " / acc: ") + str(acc)) + " / roll: ") + str(head(rolls))) + " / value: ") + str(value)) + "")

                log_mut = log
                rolls_mut = tail(rolls)
                power_mut = power - 1
                acc_mut = acc + value
                continue

            else: 
                if log:
                    to_console(((((("rollAcc / power: " + str(power)) + " / acc: ") + str(acc)) + " / roll: ") + str(head(rolls))) + "")

                log_mut = log
                rolls_mut = tail(rolls)
                power_mut = power - 1
                acc_mut = acc
                continue


        else: 
            return None

        break


def fixed_roll(log: bool, max: int, rolls: FSharpList[int]) -> Optional[int]:
    match_value: Optional[Tuple[int, FSharpList[int]]] = roll_acc(log, rolls, length(rolls) - 1, 0)
    (pattern_matching_result, result_1) = (None, None)
    if match_value is not None:
        def _arrow3(__unit: None=None, log: bool=log, max: int=max, rolls: Any=rolls) -> bool:
            result: int = match_value[0] or 0
            return (result <= max) if (result >= 1) else False

        if _arrow3():
            pattern_matching_result = 0
            result_1 = match_value[0]

        else: 
            pattern_matching_result = 1


    else: 
        pattern_matching_result = 1

    if pattern_matching_result == 0:
        return result_1

    elif pattern_matching_result == 1:
        return None



def num_dices(log: bool, max: int) -> int:
    def num_dices_0027(n_mut: int, p_mut: int, log: bool=log, max: int=max) -> int:
        while True:
            (n, p) = (n_mut, p_mut)
            if log:
                to_console(((((("numDices / max: " + str(max)) + " / n: ") + str(n)) + " / p: ") + str(p)) + "")

            if p >= max:
                return n

            else: 
                n_mut = n + 1
                p_mut = p * 6
                continue

            break

    if max == 1:
        return 1

    else: 
        return num_dices_0027(0, 1)



random: Any = None

def roll_d6(__unit: None=None) -> int:
    return randint(1, 7)


def progressive_roll(log: bool, reroll: bool, max: int) -> int:
    power: int = (num_dices(log, max) - 1) or 0
    def loop(rolls_mut: FSharpList[int], size_mut: int, log: bool=log, reroll: bool=reroll, max: int=max) -> int:
        while True:
            (rolls, size) = (rolls_mut, size_mut)
            if size < (power + 1):
                rolls_mut = cons(roll_d6(), rolls)
                size_mut = size + 1
                continue

            else: 
                match_value: Optional[Tuple[int, FSharpList[int]]] = roll_acc(log, rolls, power, 0)
                (pattern_matching_result, result_1) = (None, None)
                if match_value is not None:
                    if match_value[0] <= max:
                        pattern_matching_result = 0
                        result_1 = match_value[0]

                    elif reroll:
                        pattern_matching_result = 1

                    else: 
                        pattern_matching_result = 2


                elif reroll:
                    pattern_matching_result = 1

                else: 
                    pattern_matching_result = 2

                if pattern_matching_result == 0:
                    return result_1

                elif pattern_matching_result == 1:
                    def _arrow4(_arg: int, rolls: Any=rolls, size: int=size) -> int:
                        return roll_d6()

                    rolls_mut = initialize(power, _arrow4)
                    size_mut = power
                    continue

                elif pattern_matching_result == 2:
                    rolls_mut = cons(roll_d6(), rolls)
                    size_mut = size + 1
                    continue


            break

    return loop(empty(), 0)


def main(args: Array[str]) -> int:
    result: Optional[int] = fixed_roll(True, 2000, of_array([1, 5, 4, 4, 5]))
    def _arrow5(__unit: None=None, args: Any=args) -> str:
        return ("main / result: " + str(result)) + ""

    def _arrow6(__unit: None=None, args: Any=args) -> str:
        return ""

    trace(TraceLevel(1), _arrow5, _arrow6)
    return 0


if __name__ == "__main__":
    main(sys.argv[1:])


