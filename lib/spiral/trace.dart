// ignore_for_file: camel_case_types, constant_identifier_names, non_constant_identifier_names, unnecessary_this
import '../../fable_modules/fable_library/Map.dart' as map;
import '../../fable_modules/fable_library/String.dart' as string;
import '../../fable_modules/fable_library/Types.dart' as types;
import '../../fable_modules/fable_library/Util.dart' as util;

types.Some<types.Tuple5<Mut0, Mut1, Mut2, types.Some<int>?, Mut3>>? State_trace_state;

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

class Mut3 implements types.Record {
    void Function(String) l0;
    Mut3(this.l0);
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

void closure1(void unitVar, String v0_1) {
}

types.Some<int>? method0(types.Some<int>? v0_1) => v0_1;

types.Some<int>? method1(types.Some<int>? v0_1) => v0_1;

types.Tuple5<Mut0, Mut1, Mut2, types.Some<int>?, Mut3> closure0(void unitVar, void unitVar_1) {
    final v0_1 = Mut1(true);
    final v1_1 = Mut0(0);
    final v3 = Mut2(const US0(/* US0_0 */ 0));
    final v5 = Mut3((String v) {
        closure1(util.ignore(), v);
    });
    types.Some<types.Some<int>?>? _v6;
    final types.Some<int>? x = method1(null);
    _v6 = types.Some(x);
    return types.Tuple5(v1_1, v0_1, v3, types.value(_v6), v5);
}

US2 closure6(void unitVar, int v0_1) => US2_US2_0(v0_1);

US2 Function(int) method3() => (int v) => closure6(util.ignore(), v);

String method4() => '';

String closure5(US0 v0_1, String Function() v1_1, String Function() v2, void unitVar) {
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
    return string.trimEnd(string.trimStart('$v61 ${types.value(_v74)} #$v62 ${v1_1()} / ${v2()}', <int>[]), [32, 47]);
}

void method5(US0 v0_1, String Function() v1_1) {
    types.Tuple5<Mut0, Mut1, Mut2, types.Some<int>?, Mut3> v2() => closure0(util.ignore(), util.ignore());
    if (State_trace_state == null) {
        State_trace_state = types.Some(v2());
    }
    final patternInput = types.value(State_trace_state);
    final v3 = patternInput.item1;
    if (State_trace_state == null) {
        State_trace_state = types.Some(v2());
    }
    final patternInput_1 = types.value(State_trace_state);
    final US0 v13 = patternInput_1.item3.l0;
    if ((patternInput_1.item2.l0 == false) ? false : (map.find<US0, int>(v0_1, map.ofSeq<US0, int>(const [types.Tuple2(US0(/* US0_0 */ 0), 0), types.Tuple2(US0(/* US0_1 */ 1), 1), types.Tuple2(US0(/* US0_2 */ 2), 2), types.Tuple2(US0(/* US0_3 */ 3), 3), types.Tuple2(US0(/* US0_4 */ 4), 4)], types.Comparer((US0 x, US0 y) => x.compareTo(y)))) >= map.find<US0, int>(v13, map.ofSeq<US0, int>(const [types.Tuple2(US0(/* US0_0 */ 0), 0), types.Tuple2(US0(/* US0_1 */ 1), 1), types.Tuple2(US0(/* US0_2 */ 2), 2), types.Tuple2(US0(/* US0_3 */ 3), 3), types.Tuple2(US0(/* US0_4 */ 4), 4)], types.Comparer((US0 x, US0 y) => x.compareTo(y)))))) {
        final v21 = v3.l0 + 1;
        v3.l0 = v21;
        final v22 = '${v1_1()}';
        types.Some<void>? _v23;
        null;
        _v23 = types.Some(util.ignore());
        types.value(_v23);
        patternInput.item5.l0(v22);
    }
}

void method2(US0 v0_1, String Function() v1_1, String Function() v2) {
    method5(v0_1, () => closure5(v0_1, v1_1, v2, util.ignore()));
}

void closure4(US0 v0_1, String Function() v1_1, String Function() v2) {
    method2(v0_1, v1_1, v2);
}

void Function(String Function()) closure3(US0 v0_1, String Function() v1_1) => (String Function() v) {
    closure4(v0_1, v1_1, v);
};

void Function(String Function()) Function(String Function()) closure2(void unitVar, US0 v0_1) => (String Function() v) => closure3(v0_1, v);

types.Tuple5<Mut0, Mut1, Mut2, types.Some<int>?, Mut3> v0() => closure0(util.ignore(), util.ignore());

void Function(String Function()) Function(String Function()) v1(US0 v) => closure2(util.ignore(), v);

void Function(String Function()) Function(String Function()) trace(US0 x) => v1(x);

