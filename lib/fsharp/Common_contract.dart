// ignore_for_file: camel_case_types, constant_identifier_names, non_constant_identifier_names, unnecessary_this
import '../../fable_modules/fable_library/Types.dart' as types;
import '../../../../../../../../lib/spiral/lib.fsx' as lib;
import '../../../../../../../../lib/spiral/trace.fsx' as trace_1;

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

trace_1.US0 to_trace_level(TraceLevel _arg) {
    switch (_arg.tag) {
        case 1:
            return const trace_1.US0(/* US0_1 */ 1);
        case 2:
            return const trace_1.US0(/* US0_2 */ 2);
        case 3:
            return const trace_1.US0(/* US0_3 */ 3);
        case 4:
            return const trace_1.US0(/* US0_4 */ 4);
        default:
            return const trace_1.US0(/* US0_0 */ 0);
    }
}

void trace(TraceLevel level, String Function() fn, String Function() getLocals) {
    ((lib.SpiralTrace_trace(to_trace_level(level)))(fn))(getLocals);
}

