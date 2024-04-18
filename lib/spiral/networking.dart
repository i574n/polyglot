// ignore_for_file: camel_case_types, constant_identifier_names, non_constant_identifier_names, unnecessary_this
import '../../fable_modules/fable_library/String.dart' as string;
import '../../fable_modules/fable_library/Types.dart' as types;
import '../../fable_modules/fable_library/Util.dart' as util;

types.Some<types.Tuple5<Mut0, Mut1, Mut1, Mut2, types.Some<int>?>>? State_trace_state;

class Mut0 implements types.Record, Comparable<Mut0> {
    int l0;
    Mut0(this.l0);
    @override
    bool operator ==(Object other) => (other is Mut0) && (other.l0 == l0);
    @override
    int get hashCode => l0.hashCode;
    @override
    int compareTo(Mut0 other) => l0.compareTo(other.l0);
}

class Mut1 implements types.Record, Comparable<Mut1> {
    bool l0;
    Mut1(this.l0);
    @override
    bool operator ==(Object other) => (other is Mut1) && (other.l0 == l0);
    @override
    int get hashCode => l0.hashCode;
    @override
    int compareTo(Mut1 other) => util.compareBool(l0, other.l0);
}

class US0 implements types.Union, Comparable<US0> {
    final int tag;
    const US0(this.tag);
    @override
    bool operator ==(Object other) => (other is US0) && (other.tag == tag);
    @override
    int get hashCode => tag.hashCode;
    @override
    int compareTo(US0 other) => tag.compareTo(other.tag);
}

class Mut2 implements types.Record, Comparable<Mut2> {
    US0 l0;
    Mut2(this.l0);
    @override
    bool operator ==(Object other) => (other is Mut2) && (other.l0 == l0);
    @override
    int get hashCode => l0.hashCode;
    @override
    int compareTo(Mut2 other) => l0.compareTo(other.l0);
}

class US1 implements types.Union, Comparable<US1> {
    final int tag;
    const US1(this.tag);
    @override
    bool operator ==(Object other) => (other is US1) && (other.tag == tag);
    @override
    int get hashCode => tag.hashCode;
    @override
    int compareTo(US1 other) => tag.compareTo(other.tag);
}

class US1_US1_0 extends US1 {
    final int f0_0;
    const US1_US1_0(this.f0_0): super(0);
    @override
    bool operator ==(Object other) => (other is US1_US1_0) && (other.f0_0 == f0_0);
    @override
    int get hashCode => util.combineHashCodes([tag.hashCode, f0_0.hashCode]);
    @override
    int compareTo(US1 other) {
        if (other is US1_US1_0) {
            return f0_0.compareTo(other.f0_0);
        } else {
            return tag.compareTo(other.tag);
        }
    }
}

class US2 implements types.Union, Comparable<US2> {
    final int tag;
    const US2(this.tag);
    @override
    bool operator ==(Object other) => (other is US2) && (other.tag == tag);
    @override
    int get hashCode => tag.hashCode;
    @override
    int compareTo(US2 other) => tag.compareTo(other.tag);
}

class US2_US2_0 extends US2 {
    final int f0_0;
    const US2_US2_0(this.f0_0): super(0);
    @override
    bool operator ==(Object other) => (other is US2_US2_0) && (other.f0_0 == f0_0);
    @override
    int get hashCode => util.combineHashCodes([tag.hashCode, f0_0.hashCode]);
    @override
    int compareTo(US2 other) {
        if (other is US2_US2_0) {
            return f0_0.compareTo(other.f0_0);
        } else {
            return tag.compareTo(other.tag);
        }
    }
}

class US3 implements types.Union, Comparable<US3> {
    final int tag;
    const US3(this.tag);
    @override
    bool operator ==(Object other) => (other is US3) && (other.tag == tag);
    @override
    int get hashCode => tag.hashCode;
    @override
    int compareTo(US3 other) => tag.compareTo(other.tag);
}

class US3_US3_0 extends US3 {
    final bool f0_0;
    const US3_US3_0(this.f0_0): super(0);
    @override
    bool operator ==(Object other) => (other is US3_US3_0) && (other.f0_0 == f0_0);
    @override
    int get hashCode => util.combineHashCodes([tag.hashCode, f0_0.hashCode]);
    @override
    int compareTo(US3 other) {
        if (other is US3_US3_0) {
            return util.compareBool(f0_0, other.f0_0);
        } else {
            return tag.compareTo(other.tag);
        }
    }
}

abstract class US4 implements types.Union {
    final int tag;
    const US4(this.tag);
}

class US4_US4_0 extends US4 {
    final bool f0_0;
    const US4_US4_0(this.f0_0): super(0);
    @override
    bool operator ==(Object other) => (other is US4_US4_0) && (other.f0_0 == f0_0);
    @override
    int get hashCode => util.combineHashCodes([tag.hashCode, f0_0.hashCode]);
}

class US4_US4_1 extends US4 {
    final dynamic f1_0;
    const US4_US4_1(this.f1_0): super(1);
    @override
    bool operator ==(Object other) => (other is US4_US4_1) && util.equalsDynamic(other.f1_0, f1_0);
    @override
    int get hashCode => util.combineHashCodes([tag.hashCode, f1_0.hashCode]);
}

abstract class US5 implements types.Union {
    final int tag;
    const US5(this.tag);
}

class US5_US5_0 extends US5 {
    final bool f0_0;
    const US5_US5_0(this.f0_0): super(0);
    @override
    bool operator ==(Object other) => (other is US5_US5_0) && (other.f0_0 == f0_0);
    @override
    int get hashCode => util.combineHashCodes([tag.hashCode, f0_0.hashCode]);
}

class US5_US5_1 extends US5 {
    final dynamic f1_0;
    const US5_US5_1(this.f1_0): super(1);
    @override
    bool operator ==(Object other) => (other is US5_US5_1) && util.equalsDynamic(other.f1_0, f1_0);
    @override
    int get hashCode => util.combineHashCodes([tag.hashCode, f1_0.hashCode]);
}

class US6 implements types.Union, Comparable<US6> {
    final int tag;
    const US6(this.tag);
    @override
    bool operator ==(Object other) => (other is US6) && (other.tag == tag);
    @override
    int get hashCode => tag.hashCode;
    @override
    int compareTo(US6 other) => tag.compareTo(other.tag);
}

class US6_US6_0 extends US6 {
    final int f0_0;
    const US6_US6_0(this.f0_0): super(0);
    @override
    bool operator ==(Object other) => (other is US6_US6_0) && (other.f0_0 == f0_0);
    @override
    int get hashCode => util.combineHashCodes([tag.hashCode, f0_0.hashCode]);
    @override
    int compareTo(US6 other) {
        if (other is US6_US6_0) {
            return f0_0.compareTo(other.f0_0);
        } else {
            return tag.compareTo(other.tag);
        }
    }
}

bool US0__get_IsUS0_0(types.FSharpRef<US0, InOut> this$, void unitArg) {
    if (this$.tag == 0) {
        return true;
    } else {
        return false;
    }
}

bool US0__get_IsUS0_1(types.FSharpRef<US0, InOut> this$, void unitArg) {
    if (this$.tag == 1) {
        return true;
    } else {
        return false;
    }
}

bool US0__get_IsUS0_2(types.FSharpRef<US0, InOut> this$, void unitArg) {
    if (this$.tag == 2) {
        return true;
    } else {
        return false;
    }
}

bool US0__get_IsUS0_3(types.FSharpRef<US0, InOut> this$, void unitArg) {
    if (this$.tag == 3) {
        return true;
    } else {
        return false;
    }
}

bool US0__get_IsUS0_4(types.FSharpRef<US0, InOut> this$, void unitArg) {
    if (this$.tag == 4) {
        return true;
    } else {
        return false;
    }
}

bool US1__get_IsUS1_0(types.FSharpRef<US1, InOut> this$, void unitArg) {
    if (this$.tag == 0) {
        return true;
    } else {
        return false;
    }
}

bool US1__get_IsUS1_1(types.FSharpRef<US1, InOut> this$, void unitArg) {
    if (this$.tag == 1) {
        return true;
    } else {
        return false;
    }
}

bool US2__get_IsUS2_0(types.FSharpRef<US2, InOut> this$, void unitArg) {
    if (this$.tag == 0) {
        return true;
    } else {
        return false;
    }
}

bool US2__get_IsUS2_1(types.FSharpRef<US2, InOut> this$, void unitArg) {
    if (this$.tag == 1) {
        return true;
    } else {
        return false;
    }
}

bool US3__get_IsUS3_0(types.FSharpRef<US3, InOut> this$, void unitArg) {
    if (this$.tag == 0) {
        return true;
    } else {
        return false;
    }
}

bool US3__get_IsUS3_1(types.FSharpRef<US3, InOut> this$, void unitArg) {
    if (this$.tag == 1) {
        return true;
    } else {
        return false;
    }
}

bool US4__get_IsUS4_0(types.FSharpRef<US4, InOut> this$, void unitArg) {
    if (this$.tag == 0) {
        return true;
    } else {
        return false;
    }
}

bool US4__get_IsUS4_1(types.FSharpRef<US4, InOut> this$, void unitArg) {
    if (this$.tag == 1) {
        return true;
    } else {
        return false;
    }
}

bool US5__get_IsUS5_0(types.FSharpRef<US5, InOut> this$, void unitArg) {
    if (this$.tag == 0) {
        return true;
    } else {
        return false;
    }
}

bool US5__get_IsUS5_1(types.FSharpRef<US5, InOut> this$, void unitArg) {
    if (this$.tag == 1) {
        return true;
    } else {
        return false;
    }
}

bool US6__get_IsUS6_0(types.FSharpRef<US6, InOut> this$, void unitArg) {
    if (this$.tag == 0) {
        return true;
    } else {
        return false;
    }
}

bool US6__get_IsUS6_1(types.FSharpRef<US6, InOut> this$, void unitArg) {
    if (this$.tag == 1) {
        return true;
    } else {
        return false;
    }
}

types.Some<int>? method0(types.Some<int>? v0_1) => v0_1;

types.Some<int>? method1(types.Some<int>? v0_1) => v0_1;

types.Tuple5<Mut0, Mut1, Mut1, Mut2, types.Some<int>?> closure0(void unitVar, void unitVar_1) {
    final v0_1 = Mut1(true);
    final v1_1 = Mut0(0);
    final v3_1 = Mut2(const US0(/* US0_0 */ 0));
    final v4_1 = Mut1(false);
    types.Some<types.Some<int>?>? _v5;
    final types.Some<int>? x = method1(null);
    _v5 = types.Some(x);
    return types.Tuple5(v1_1, v4_1, v0_1, v3_1, types.value(_v5));
}

String closure2(String v0_1, void unitVar) => 'test_port_open / ex: $v0_1';

String closure3(void unitVar, void unitVar_1) => '';

US2 closure5(void unitVar, int v0_1) => US2_US2_0(v0_1);

US2 Function(int) method3() => (int v) => closure5(util.ignore(), v);

String method4() => '';

String closure4(US0 v0_1, String Function() v1_1, String Function() v2_1, void unitVar) {
    if (State_trace_state == null) {
        State_trace_state = types.Some(closure0(util.ignore(), util.ignore()));
    }
    final patternInput = types.value(State_trace_state);
    types.Some<String>? _v9;
    _v9 = const types.Some('');
    final v61 = types.value(_v9);
    final v62 = patternInput.item1.l0;
    late final String v72;
    switch (v0_1.tag) {
        case 1:
            v72 = 'Debug';
            break;
        case 2:
            v72 = 'Info';
            break;
        case 0:
            v72 = 'Verbose';
            break;
        case 3:
            v72 = 'Warning';
            break;
        default:
            v72 = 'Critical';
    }
    final v73 = v72.toLowerCase();
    types.Some<String>? _v74;
    _v74 = const types.Some('');
    return string.trimEnd(string.trimStart('$v61 ${types.value(_v74)} #$v62 ${v1_1()} / ${v2_1()}', <int>[]), [32, 47]);
}

void method2(US0 v0_1, String Function() v1_1, String Function() v2_1) {
    types.Tuple5<Mut0, Mut1, Mut1, Mut2, types.Some<int>?> v3_1() => closure0(util.ignore(), util.ignore());
    if (State_trace_state == null) {
        State_trace_state = types.Some(v3_1());
    }
    final v4_1 = types.value(State_trace_state).item1;
    if (State_trace_state == null) {
        State_trace_state = types.Some(v3_1());
    }
    final patternInput_1 = types.value(State_trace_state);
    final US0 v14 = patternInput_1.item4.l0;
    if (patternInput_1.item3.l0 && (v0_1.compareTo(v14) >= 0)) {
        final v19 = v4_1.l0 + 1;
        v4_1.l0 = v19;
        final v21 = '${closure4(v0_1, v1_1, v2_1, util.ignore())}';
        types.Some<void>? _v22;
        null;
        _v22 = types.Some(util.ignore());
        types.value(_v22);
    }
}

Async<bool> closure1(void unitVar, int v0_1) {
    types.Some<Async<bool>>? _v1;
    _v1 = const types.Some(null);
    return types.value(_v1);
}

US4 closure8(void unitVar, bool v0_1) => US4_US4_0(v0_1);

US4 closure9(void unitVar, dynamic v0_1) => US4_US4_1(v0_1);

String closure10(void unitVar, void unitVar_1) => 'run_with_timeout_async';

String closure11(int v0_1, void unitVar) => 'timeout: $v0_1 / ${closure3(util.ignore(), util.ignore())}';

String closure12(String v0_1, void unitVar) => 'run_with_timeout_async** / ex: $v0_1';

Async<bool> closure7(int v0_1, int v1_1) {
    types.Some<Async<bool>>? _v2;
    _v2 = const types.Some(null);
    return types.value(_v2);
}

Async<bool> Function(int) closure6(void unitVar, int v0_1) => (int v) => closure7(v0_1, v);

US6 closure16(void unitVar, int v0_1) => US6_US6_0(v0_1);

US6 Function(int) method6() => (int v) => closure16(util.ignore(), v);

String closure17(void unitVar, void unitVar_1) => 'wait_for_port_access';

String closure18(int v0_1, int v1_1, void unitVar) => 'port: $v0_1 / retry: $v1_1 / ${closure3(util.ignore(), util.ignore())}';

Async<int> method5(types.Some<int>? v0_1, bool v1_1, int v2_1, int v3_1) {
    types.Some<Async<int>>? _v4;
    _v4 = const types.Some(null);
    return types.value(_v4);
}

Async<int> closure15(types.Some<int>? v0_1, bool v1_1, int v2_1) => method5(v0_1, v1_1, v2_1, 0);

Async<int> Function(int) closure14(types.Some<int>? v0_1, bool v1_1) => (int v) => closure15(v0_1, v1_1, v);

Async<int> Function(int) Function(bool) closure13(void unitVar, types.Some<int>? v0_1) => (bool v) => closure14(v0_1, v);

Async<int> method7(types.Some<int>? v0_1, int v1_1) {
    types.Some<Async<int>>? _v2;
    _v2 = const types.Some(null);
    return types.value(_v2);
}

Async<int> closure20(types.Some<int>? v0_1, int v1_1) => method7(v0_1, v1_1);

Async<int> Function(int) closure19(void unitVar, types.Some<int>? v0_1) => (int v) => closure20(v0_1, v);

types.Tuple5<Mut0, Mut1, Mut1, Mut2, types.Some<int>?> v0() => closure0(util.ignore(), util.ignore());

Async<bool> v1(int v) => closure1(util.ignore(), v);

Async<bool> test_port_open(int x) => v1(x);

Async<bool> Function(int) v2(int v) => closure6(util.ignore(), v);

Async<bool> Function(int) test_port_open_timeout(int x) => v2(x);

Async<int> Function(int) Function(bool) v3(types.Some<int>? v) => closure13(util.ignore(), v);

Async<int> Function(int) Function(bool) wait_for_port_access(types.Some<int>? x) => v3(x);

Async<int> Function(int) v4(types.Some<int>? v) => closure19(util.ignore(), v);

Async<int> Function(int) get_available_port(types.Some<int>? x) => v4(x);

