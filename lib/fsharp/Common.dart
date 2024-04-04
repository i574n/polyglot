// ignore_for_file: camel_case_types, constant_identifier_names, non_constant_identifier_names, unnecessary_this
import '../../fable_modules/fable_library/Date.dart' as date;
import '../../fable_modules/fable_library/String.dart' as string;
import '../../fable_modules/fable_library/TimeSpan.dart' as time_span;
import '../../fable_modules/fable_library/Types.dart' as types;
import '../../../../../../../../lib/spiral/lib.fsx' as lib;

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

bool TraceLevel__get_IsVerbose(TraceLevel this$, void unitArg) {
    if (this$.tag == /* Verbose */ 0) {
        return true;
    } else {
        return false;
    }
}

bool TraceLevel__get_IsDebug(TraceLevel this$, void unitArg) {
    if (this$.tag == /* Debug */ 1) {
        return true;
    } else {
        return false;
    }
}

bool TraceLevel__get_IsInfo(TraceLevel this$, void unitArg) {
    if (this$.tag == /* Info */ 2) {
        return true;
    } else {
        return false;
    }
}

bool TraceLevel__get_IsWarning(TraceLevel this$, void unitArg) {
    if (this$.tag == /* Warning */ 3) {
        return true;
    } else {
        return false;
    }
}

bool TraceLevel__get_IsCritical(TraceLevel this$, void unitArg) {
    if (this$.tag == /* Critical */ 4) {
        return true;
    } else {
        return false;
    }
}

var traceEnabled = true;

var traceCount = 0;

TraceLevel traceLevel = const TraceLevel(/* Verbose */ 0);

var traceDump = false;

bool testTraceLevel(TraceLevel level) {
    if (traceEnabled) {
        return level.compareTo(traceLevel) >= 0;
    } else {
        return false;
    }
}

void traceRaw(TraceLevel level, String Function() fn) {
    if (testTraceLevel(level)) {
        traceCount = traceCount + 1;
        final text = '${fn()}';
        console.log(text);
    }
}

types.Some<int>? replStart() => null;

void trace(TraceLevel level, String Function() fn, String Function() getLocals) {
    traceRaw(level, () {
        final types.Some<int>? matchValue = replStart();
        late final DateTime tmp_capture;
        if (matchValue == null) {
            tmp_capture = date.now();
        } else {
            final t = time_span.fromTicks(date.getTicks(date.now()) - types.value(matchValue));
            tmp_capture = date.create(1, 1, 1, time_span.hours(t), time_span.minutes(t), time_span.seconds(t), time_span.milliseconds(t));
        }
        final time = date.toString(tmp_capture, 'HH:mm:ss');
        return (lib.SpiralSm_trim_end([32, 47]))((lib.SpiralSm_trim_start(<int>[]))(string.toText(string.interpolate('%P() #%P() [%A%P()] %s%P() / %s%P()', [time, traceCount, level, fn(), getLocals()]))));
    });
}

