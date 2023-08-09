// ignore_for_file: camel_case_types, constant_identifier_names, non_constant_identifier_names, unnecessary_this
import './nbs/Common.dart' as common;
import './fable_modules/fable_library/List.dart' as list;
import './fable_modules/fable_library/Option.dart' as option_1;
import './fable_modules/fable_library/Random.dart' as random_1;
import './fable_modules/fable_library/Seq.dart' as seq;
import './fable_modules/fable_library/String.dart' as string;
import './fable_modules/fable_library/Types.dart' as types;

final pow6 = seq.cache<int>(seq.unfold<int, int>((int state) => types.Some(types.Tuple2(state, state * 6)), 1));

types.Some<types.Tuple2<int, list.FSharpList<int>>>? rollAcc(bool log_mut, list.FSharpList<int> rolls_mut, int power_mut, int acc_mut) {
    rollAcc:
    while (true) {
        final log = log_mut;
        final rolls = rolls_mut;
        final power = power_mut;
        final acc = acc_mut;
        if (power < 0) {
            if (log) {
                string.toConsole('rollAcc / power: $power / acc: $acc' as PrintfFormat<void, TextWriter, void, void>);
            }
            return types.Some(types.Tuple2(acc + 1, rolls));
        } else if (!(list.isEmpty(rolls))) {
            if (list.head(rolls) > 1) {
                final value = (list.head(rolls) - 1) * seq.item<int>(power, pow6);
                if (log) {
                    string.toConsole('rollAcc / power: $power / acc: $acc / roll: ${list.head(rolls)} / value: $value' as PrintfFormat<void, TextWriter, void, void>);
                }
                log_mut = log;
                rolls_mut = list.tail(rolls);
                power_mut = power - 1;
                acc_mut = acc + value;
                continue rollAcc;
            } else {
                if (log) {
                    string.toConsole('rollAcc / power: $power / acc: $acc / roll: ${list.head(rolls)}' as PrintfFormat<void, TextWriter, void, void>);
                }
                log_mut = log;
                rolls_mut = list.tail(rolls);
                power_mut = power - 1;
                acc_mut = acc;
                continue rollAcc;
            }
        } else {
            return null;
        }
    }
}

types.Some<int>? fixedRoll(bool log, int max, list.FSharpList<int> rolls) {
    final types.Some<types.Tuple2<int, list.FSharpList<int>>>? matchValue = rollAcc(log, rolls, list.length<int>(rolls) - 1, 0);
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

int numDices(bool log, int max) {
    int numDices$0027(int n_mut, int p_mut) {
        numDices$0027:
        while (true) {
            final n = n_mut;
            final p = p_mut;
            if (log) {
                string.toConsole('numDices / max: $max / n: $n / p: $p' as PrintfFormat<void, TextWriter, void, void>);
            }
            if (p >= max) {
                return n;
            } else {
                n_mut = n + 1;
                p_mut = p * 6;
                continue numDices$0027;
            }
        }
    }
    if (max == 1) {
        return 1;
    } else {
        return numDices$0027(0, 1);
    }
}

final random = random_1.nonSeeded();

int rollD6() => random.Next2(1, 7);

int progressiveRoll(bool log, bool reroll, int max) {
    final power = numDices(log, max) - 1;
    int loop(list.FSharpList<int> rolls_mut, int size_mut) {
        loop:
        while (true) {
            final rolls = rolls_mut;
            final size = size_mut;
            if (size < (power + 1)) {
                rolls_mut = list.cons(rollD6(), rolls);
                size_mut = size + 1;
                continue loop;
            } else {
                final types.Some<types.Tuple2<int, list.FSharpList<int>>>? matchValue = rollAcc(log, rolls, power, 0);
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
                        rolls_mut = list.initialize<int>(power, (int _arg) => rollD6());
                        size_mut = power;
                        continue loop;
                    default:
                        rolls_mut = list.cons(rollD6(), rolls);
                        size_mut = size + 1;
                        continue loop;
                }
            }
        }
    }
    return loop(list.empty<int>(), 0);
}

int main(List<String> args) {
    final types.Some<int>? result = fixedRoll(true, 2000, list.ofArray(const [1, 5, 4, 4, 5]));
    common.trace(const common.TraceLevel(/* Debug */ 1), () => 'main / result: ${option_1.defaultValue(-1, result)}', () => '');
    return 0;
}

