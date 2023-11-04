// ignore_for_file: camel_case_types, constant_identifier_names, non_constant_identifier_names, unnecessary_this
import './lib/fsharp/Common.dart' as common;
import './fable_modules/fable_library/List.dart' as list_2;
import './fable_modules/fable_library/Option.dart' as option_3;
import './fable_modules/fable_library/Random.dart' as random_1;
import './fable_modules/fable_library/Seq.dart' as seq;
import './fable_modules/fable_library/String.dart' as string;
import './fable_modules/fable_library/Types.dart' as types;

final sixthPowerSequence = seq.cache<int>(seq.unfold<int, int>((int state) => types.Some(types.Tuple2(state, state * 6)), 1));

types.Some<types.Tuple2<int, list_2.FSharpList<int>>>? accumulateDiceRolls(types.Some<void Function(String)>? log_mut, list_2.FSharpList<int> rolls_mut, int power_mut, int acc_mut) {
    accumulateDiceRolls:
    while (true) {
        final types.Some<void Function(String)>? log = log_mut;
        final rolls = rolls_mut;
        final power = power_mut;
        final acc = acc_mut;
        if (power < 0) {
            final arg = 'accumulateDiceRolls / power: $power / acc: $acc';
            option_3.iterate<void Function(String)>((void Function(String) func) {
                func(arg);
            }, log);
            return types.Some(types.Tuple2(acc + 1, rolls));
        } else if (!(list_2.isEmpty(rolls))) {
            if (list_2.head(rolls) > 1) {
                final value = (list_2.head(rolls) - 1) * seq.item<int>(power, sixthPowerSequence);
                final arg_1 = 'accumulateDiceRolls / power: $power / acc: $acc / roll: ${list_2.head(rolls)} / value: $value';
                option_3.iterate<void Function(String)>((void Function(String) func_1) {
                    func_1(arg_1);
                }, log);
                log_mut = log;
                rolls_mut = list_2.tail(rolls);
                power_mut = power - 1;
                acc_mut = acc + value;
                continue accumulateDiceRolls;
            } else {
                final arg_2 = 'accumulateDiceRolls / power: $power / acc: $acc / roll: ${list_2.head(rolls)}';
                option_3.iterate<void Function(String)>((void Function(String) func_2) {
                    func_2(arg_2);
                }, log);
                log_mut = log;
                rolls_mut = list_2.tail(rolls);
                power_mut = power - 1;
                acc_mut = acc;
                continue accumulateDiceRolls;
            }
        } else {
            return null;
        }
    }
}

types.Some<int>? rollWithinBounds(types.Some<void Function(String)>? log, int max, list_2.FSharpList<int> rolls) {
    final types.Some<types.Tuple2<int, list_2.FSharpList<int>>>? matchValue = accumulateDiceRolls(log, rolls, list_2.length<int>(rolls) - 1, 0);
    var tmp_capture_1 = false;
    if (matchValue != null) {
        final result = types.value(matchValue).item1;
        tmp_capture_1 = (result >= 1) && (result <= max);
    }
    if (tmp_capture_1) {
        return types.Some(types.value(matchValue).item1);
    } else {
        return null;
    }
}

final random = random_1.nonSeeded();

int rollDice() => random.Next2(1, 7);

int rotateNumber(int max, int n) => ((n - 1) + max).remainder(max) + 1;

Iterable<int> rotateNumbers(int max, Iterable<int> items) => seq.map<int, int>((int n) => rotateNumber(max, n), items);

$$a Function() createSequentialRoller<$$a>(list_2.FSharpList<$$a> list) {
    var currentIndex = 0;
    return () {
        final types.Some<$$a>? matchValue = list_2.tryItem<$$a>(currentIndex, list);
        if (matchValue == null) {
            return throw Exception('createSequentialRoller / End of list');
        } else {
            currentIndex = currentIndex + 1;
            return types.value(matchValue);
        }
    };
}

int rollProgressively(types.Some<void Function(String)>? log, int Function() roll, bool reroll, int max) {
    final max_1 = max;
    int loop(int n_mut, int p_mut) {
        loop:
        while (true) {
            final n = n_mut;
            final p = p_mut;
            if (p < max_1) {
                n_mut = n + 1;
                p_mut = p * 6;
                continue loop;
            } else {
                final arg = 'calculateDiceCount / max: $max_1 / n: $n / p: $p';
                option_3.iterate<void Function(String)>((void Function(String) func) {
                    func(arg);
                }, log);
                return n;
            }
        }
    }
    final power = ((max_1 == 1) ? 1 : loop(0, 1)) - 1;
    int loop_1(list_2.FSharpList<int> rolls_mut, int size_mut) {
        loop_1:
        while (true) {
            final rolls = rolls_mut;
            final size = size_mut;
            if (size < (power + 1)) {
                rolls_mut = list_2.cons(roll(), rolls);
                size_mut = size + 1;
                continue loop_1;
            } else {
                final types.Some<types.Tuple2<int, list_2.FSharpList<int>>>? matchValue = accumulateDiceRolls(log, rolls, power, 0);
                late final int matchResult;
                late final int result_1;
                if (matchValue != null) {
                    if (types.value(matchValue).item1 <= max) {
                        matchResult = 0;
                        result_1 = types.value(matchValue).item1;
                    } else if (reroll) {
                        matchResult = 1;
                    } else {
                        matchResult = 2;
                    }
                } else if (reroll) {
                    matchResult = 1;
                } else {
                    matchResult = 2;
                }
                switch (matchResult) {
                    case 0:
                        return result_1;
                    case 1:
                        rolls_mut = list_2.initialize<int>(power, (int _arg) => roll());
                        size_mut = power;
                        continue loop_1;
                    default:
                        rolls_mut = list_2.cons(roll(), rolls);
                        size_mut = size + 1;
                        continue loop_1;
                }
            }
        }
    }
    return loop_1(list_2.empty<int>(), 0);
}

int main(List<String> args) {
    final clo = string.toConsole(string.printf('%s'));
    final result = rollProgressively(types.Some((String arg) {
        clo(arg);
    }), () => rollDice(), true, 2147483647 ~/ 10);
    common.trace(const common.TraceLevel(/* Debug */ 1), () => 'main / result: $result', () => '');
    return 0;
}

