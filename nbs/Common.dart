// ignore_for_file: camel_case_types, constant_identifier_names, non_constant_identifier_names, unnecessary_this
import '../fable_modules/fable_library/Date.dart' as date;
import '../fable_modules/fable_library/String.dart' as string;
import '../fable_modules/fable_library/TimeSpan.dart' as time_span;
import '../fable_modules/fable_library/Types.dart' as types;

const nl = '\n';

const q = '\"';

class TraceLevel implements types.Union, Comparable<TraceLevel> {
    final int tag;
    const TraceLevel(this.tag);
    @override
    bool operator ==(Object other) => (other is TraceLevel) && (other.tag == tag);
    @override
    int get hashCode => tag.hashCode;
    @override
    int compareTo(TraceLevel other) => tag.compareTo(other.tag);
}

var traceEnabled = true;

var traceCount = 0;

TraceLevel traceLevel = const TraceLevel(/* Verbose */ 0);

var traceDump = false;

types.Some<int>? replStart() => null;

void trace(TraceLevel level, String Function() fn, String Function() getLocals) {
    if (traceEnabled && (level.compareTo(traceLevel) >= 0)) {
        traceCount = traceCount + 1;
        final trimChars_2 = [32, 47];
        final types.Some<int>? matchValue = replStart();
        late final DateTime tmp_capture_1;
        if (matchValue == null) {
            tmp_capture_1 = date.now();
        } else {
            final t = time_span.fromTicks(date.getTicks(date.now()) - types.value(matchValue));
            tmp_capture_1 = date.create(1, 1, 1, time_span.hours(t), time_span.minutes(t), time_span.seconds(t), time_span.milliseconds(t), time_span.microseconds(t));
        }
        final text = string.trimEnd(string.trimStart(string.toText(string.interpolate('%P() #%P() [%A%P()] %s%P() / %s%P()', [date.toString(tmp_capture_1, 'HH:mm:ss'), traceCount, level, fn(), getLocals()])), <int>[]), trimChars_2);
        console.log(text);
    }
}

