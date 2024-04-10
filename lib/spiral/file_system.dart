// ignore_for_file: camel_case_types, constant_identifier_names, non_constant_identifier_names, unnecessary_this
import '../../fable_modules/fable_library/Option.dart' as option_2;
import '../../fable_modules/fable_library/String.dart' as string;
import '../../fable_modules/fable_library/Types.dart' as types;
import '../../fable_modules/fable_library/Util.dart' as util;

abstract class IFsExistsSync {
    bool existsSync(String path);
}

types.Some<types.Tuple5<Mut0, Mut1, Mut1, Mut2, types.Some<int>?>>? State_trace_state;

abstract class IPathJoin {
    String join(List<String> paths);
}

abstract class IPathDirname {
    String dirname(String path);
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

class US0_US0_0 extends US0 {
    final US1 f0_0;
    final US2 f0_1;
    const US0_US0_0(this.f0_0, this.f0_1): super(0);
    @override
    bool operator ==(Object other) => (other is US0_US0_0) && ((other.f0_0 == f0_0) && (other.f0_1 == f0_1));
    @override
    int get hashCode => util.combineHashCodes([tag.hashCode, f0_0.hashCode, f0_1.hashCode]);
    @override
    int compareTo(US0 other) {
        if (other is US0_US0_0) {
            late int $r;
            if (($r = f0_0.compareTo(other.f0_0)) == 0) {
                $r = f0_1.compareTo(other.f0_1);
            }
            return $r;
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

class Mut2 implements types.Record, Comparable<Mut2> {
    US3 l0;
    Mut2(this.l0);
    @override
    bool operator ==(Object other) => (other is Mut2) && (other.l0 == l0);
    @override
    int get hashCode => l0.hashCode;
    @override
    int compareTo(Mut2 other) => l0.compareTo(other.l0);
}

class US4 implements types.Union, Comparable<US4> {
    final int tag;
    const US4(this.tag);
    @override
    bool operator ==(Object other) => (other is US4) && (other.tag == tag);
    @override
    int get hashCode => tag.hashCode;
    @override
    int compareTo(US4 other) => tag.compareTo(other.tag);
}

class US4_US4_0 extends US4 {
    final int f0_0;
    const US4_US4_0(this.f0_0): super(0);
    @override
    bool operator ==(Object other) => (other is US4_US4_0) && (other.f0_0 == f0_0);
    @override
    int get hashCode => util.combineHashCodes([tag.hashCode, f0_0.hashCode]);
    @override
    int compareTo(US4 other) {
        if (other is US4_US4_0) {
            return f0_0.compareTo(other.f0_0);
        } else {
            return tag.compareTo(other.tag);
        }
    }
}

class US5 implements types.Union, Comparable<US5> {
    final int tag;
    const US5(this.tag);
    @override
    bool operator ==(Object other) => (other is US5) && (other.tag == tag);
    @override
    int get hashCode => tag.hashCode;
    @override
    int compareTo(US5 other) => tag.compareTo(other.tag);
}

class US5_US5_0 extends US5 {
    final int f0_0;
    const US5_US5_0(this.f0_0): super(0);
    @override
    bool operator ==(Object other) => (other is US5_US5_0) && (other.f0_0 == f0_0);
    @override
    int get hashCode => util.combineHashCodes([tag.hashCode, f0_0.hashCode]);
    @override
    int compareTo(US5 other) {
        if (other is US5_US5_0) {
            return f0_0.compareTo(other.f0_0);
        } else {
            return tag.compareTo(other.tag);
        }
    }
}

abstract class US6 implements types.Union {
    final int tag;
    const US6(this.tag);
}

class US6_US6_0 extends US6 {
    final int f0_0;
    const US6_US6_0(this.f0_0): super(0);
    @override
    bool operator ==(Object other) => (other is US6_US6_0) && (other.f0_0 == f0_0);
    @override
    int get hashCode => util.combineHashCodes([tag.hashCode, f0_0.hashCode]);
}

class US6_US6_1 extends US6 {
    final dynamic f1_0;
    const US6_US6_1(this.f1_0): super(1);
    @override
    bool operator ==(Object other) => (other is US6_US6_1) && util.equalsDynamic(other.f1_0, f1_0);
    @override
    int get hashCode => util.combineHashCodes([tag.hashCode, f1_0.hashCode]);
}

abstract class US7 implements types.Union {
    final int tag;
    const US7(this.tag);
}

class US7_US7_0 extends US7 {
    final int f0_0;
    const US7_US7_0(this.f0_0): super(0);
    @override
    bool operator ==(Object other) => (other is US7_US7_0) && (other.f0_0 == f0_0);
    @override
    int get hashCode => util.combineHashCodes([tag.hashCode, f0_0.hashCode]);
}

class US7_US7_1 extends US7 {
    final dynamic f1_0;
    const US7_US7_1(this.f1_0): super(1);
    @override
    bool operator ==(Object other) => (other is US7_US7_1) && util.equalsDynamic(other.f1_0, f1_0);
    @override
    int get hashCode => util.combineHashCodes([tag.hashCode, f1_0.hashCode]);
}

class US8 implements types.Union, Comparable<US8> {
    final int tag;
    const US8(this.tag);
    @override
    bool operator ==(Object other) => (other is US8) && (other.tag == tag);
    @override
    int get hashCode => tag.hashCode;
    @override
    int compareTo(US8 other) => tag.compareTo(other.tag);
}

class US8_US8_0 extends US8 {
    final String f0_0;
    const US8_US8_0(this.f0_0): super(0);
    @override
    bool operator ==(Object other) => (other is US8_US8_0) && (other.f0_0 == f0_0);
    @override
    int get hashCode => util.combineHashCodes([tag.hashCode, f0_0.hashCode]);
    @override
    int compareTo(US8 other) {
        if (other is US8_US8_0) {
            return f0_0.compareTo(other.f0_0);
        } else {
            return tag.compareTo(other.tag);
        }
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

bool US1__get_IsUS1_2(types.FSharpRef<US1, InOut> this$, void unitArg) {
    if (this$.tag == 2) {
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

bool US2__get_IsUS2_2(types.FSharpRef<US2, InOut> this$, void unitArg) {
    if (this$.tag == 2) {
        return true;
    } else {
        return false;
    }
}

bool US2__get_IsUS2_3(types.FSharpRef<US2, InOut> this$, void unitArg) {
    if (this$.tag == 3) {
        return true;
    } else {
        return false;
    }
}

bool US2__get_IsUS2_4(types.FSharpRef<US2, InOut> this$, void unitArg) {
    if (this$.tag == 4) {
        return true;
    } else {
        return false;
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

bool US3__get_IsUS3_2(types.FSharpRef<US3, InOut> this$, void unitArg) {
    if (this$.tag == 2) {
        return true;
    } else {
        return false;
    }
}

bool US3__get_IsUS3_3(types.FSharpRef<US3, InOut> this$, void unitArg) {
    if (this$.tag == 3) {
        return true;
    } else {
        return false;
    }
}

bool US3__get_IsUS3_4(types.FSharpRef<US3, InOut> this$, void unitArg) {
    if (this$.tag == 4) {
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

bool US7__get_IsUS7_0(types.FSharpRef<US7, InOut> this$, void unitArg) {
    if (this$.tag == 0) {
        return true;
    } else {
        return false;
    }
}

bool US7__get_IsUS7_1(types.FSharpRef<US7, InOut> this$, void unitArg) {
    if (this$.tag == 1) {
        return true;
    } else {
        return false;
    }
}

bool US8__get_IsUS8_0(types.FSharpRef<US8, InOut> this$, void unitArg) {
    if (this$.tag == 0) {
        return true;
    } else {
        return false;
    }
}

bool US8__get_IsUS8_1(types.FSharpRef<US8, InOut> this$, void unitArg) {
    if (this$.tag == 1) {
        return true;
    } else {
        return false;
    }
}

String closure2(void unitVar, String v0_1) {
    types.Some<String>? _v1;
    _v1 = const types.Some('');
    return types.value(_v1);
}

String closure3(void unitVar, void unitVar_1) => '';

String method1(String v0_1, String v1) => 'path: ${closure2(util.ignore(), v0_1)} / ex: $v1 / ${closure3(util.ignore(), util.ignore())}';

String closure1(String v0_1, String v1, void unitVar) => method1(v0_1, v1);

Async<int> method0(String v0_1, int v1) {
    types.Some<Async<int>>? _v2;
    _v2 = const types.Some(null);
    return types.value(_v2);
}

Async<int> closure0(void unitVar, String v0_1) {
    types.Some<Async<int>>? _v1;
    _v1 = const types.Some(null);
    return types.value(_v1);
}

String method3(String v0_1, int v1, String v2) => 'path: ${closure2(util.ignore(), v0_1)} / retry: $v1 / ex: $v2 / ${closure3(util.ignore(), util.ignore())}';

String closure6(String v0_1, int v1, String v2, void unitVar) => method3(v0_1, v1, v2);

Async<int> method2(String v0_1, US2 v1, US1 v2, int v3) {
    types.Some<Async<int>>? _v4;
    _v4 = const types.Some(null);
    return types.value(_v4);
}

Async<int> closure5(US0 v0_1, String v1) {
    types.Some<Async<int>>? _v2;
    _v2 = const types.Some(null);
    return types.value(_v2);
}

Async<int> Function(String) closure4(void unitVar, US0 v0_1) => (String v) => closure5(v0_1, v);

Async<int> method4(String v0_1, int v1) {
    types.Some<Async<int>>? _v2;
    _v2 = const types.Some(null);
    return types.value(_v2);
}

Async<int> closure7(void unitVar, String v0_1) {
    types.Some<Async<int>>? _v1;
    _v1 = const types.Some(null);
    return types.value(_v1);
}

Async<String> closure8(void unitVar, String v0_1) {
    types.Some<Async<String>>? _v1;
    _v1 = const types.Some(null);
    return types.value(_v1);
}

String method5(String v0_1) => v0_1;

Async<bool> closure10(String v0_1, String v1) {
    types.Some<Async<bool>>? _v2;
    _v2 = const types.Some(null);
    return types.value(_v2);
}

Async<bool> Function(String) closure9(void unitVar, String v0_1) => (String v) => closure10(v0_1, v);

Async<void> closure12(String v0_1, String v1) {
    types.Some<Async<void>>? _v2;
    _v2 = const types.Some(null);
    return types.value(_v2);
}

Async<void> Function(String) closure11(void unitVar, String v0_1) => (String v) => closure12(v0_1, v);

Async<void> closure14(String v0_1, String v1) {
    types.Some<Async<void>>? _v2;
    _v2 = const types.Some(null);
    return types.value(_v2);
}

Async<void> Function(String) closure13(void unitVar, String v0_1) => (String v) => closure14(v0_1, v);

String closure16(void unitVar, void unitVar_1) => 'delete_file_async';

types.Some<int>? method8(types.Some<int>? v0_1) => v0_1;

types.Some<int>? method9(types.Some<int>? v0_1) => v0_1;

types.Tuple5<Mut0, Mut1, Mut1, Mut2, types.Some<int>?> closure17(void unitVar, void unitVar_1) {
    final v0_1 = Mut1(true);
    final v1 = Mut0(0);
    final v3 = Mut2(const US3(/* US3_0 */ 0));
    final v4 = Mut1(false);
    types.Some<types.Some<int>?>? _v5;
    final types.Some<int>? x = method9(null);
    _v5 = types.Some(x);
    return types.Tuple5(v1, v4, v0_1, v3, types.value(_v5));
}

US5 closure19(void unitVar, int v0_1) => US5_US5_0(v0_1);

US5 Function(int) method10() => (int v) => closure19(util.ignore(), v);

String method11() => '';

String closure18(US3 v0_1, String Function() v1, String Function() v2, void unitVar) {
    if (State_trace_state == null) {
        State_trace_state = types.Some(closure17(util.ignore(), util.ignore()));
    }
    final patternInput = types.value(State_trace_state);
    types.Some<String>? _v9;
    _v9 = const types.Some('');
    final v59 = types.value(_v9);
    final v60 = patternInput.item1.l0;
    late final String v70;
    switch (v0_1.tag) {
        case 1:
            v70 = 'Debug';
            break;
        case 2:
            v70 = 'Info';
            break;
        case 0:
            v70 = 'Verbose';
            break;
        case 3:
            v70 = 'Warning';
            break;
        default:
            v70 = 'Critical';
    }
    return string.trimEnd(string.trimStart('$v59 #$v60 [${v70.toLowerCase()}] ${v1()} / ${v2()}', <int>[]), [32, 47]);
}

void method7(US3 v0_1, String Function() v1, String Function() v2) {
    types.Tuple5<Mut0, Mut1, Mut1, Mut2, types.Some<int>?> v3() => closure17(util.ignore(), util.ignore());
    if (State_trace_state == null) {
        State_trace_state = types.Some(v3());
    }
    final v4 = types.value(State_trace_state).item1;
    if (State_trace_state == null) {
        State_trace_state = types.Some(v3());
    }
    final patternInput_1 = types.value(State_trace_state);
    final US3 v14_1 = patternInput_1.item4.l0;
    if (patternInput_1.item3.l0 && (v0_1.compareTo(v14_1) >= 0)) {
        final v19 = v4.l0 + 1;
        v4.l0 = v19;
        final v21 = '${closure18(v0_1, v1, v2, util.ignore())}';
        types.Some<void>? _v22;
        _v22 = const types.Some(null);
        types.value(_v22);
    }
}

Async<int> method6(String v0_1, int v1) {
    types.Some<Async<int>>? _v2;
    _v2 = const types.Some(null);
    return types.value(_v2);
}

Async<int> closure15(void unitVar, String v0_1) {
    types.Some<Async<int>>? _v1;
    _v1 = const types.Some(null);
    return types.value(_v1);
}

String closure22(void unitVar, void unitVar_1) => 'move_file_async';

String method13(String v0_1, String v1, dynamic v2) {
    types.Some<String>? _v3;
    _v3 = const types.Some('');
    final v9 = types.value(_v3);
    String v10(String v) => closure2(util.ignore(), v);
    return 'old_path: ${v10(v1)} / new_path: ${v10(v0_1)} / ex: $v9 / ${closure3(util.ignore(), util.ignore())}';
}

String closure23(String v0_1, String v1, dynamic v2, void unitVar) => method13(v0_1, v1, v2);

Async<int> method12(String v0_1, String v1, int v2) {
    types.Some<Async<int>>? _v3;
    _v3 = const types.Some(null);
    return types.value(_v3);
}

Async<int> closure21(String v0_1, String v1) {
    types.Some<Async<int>>? _v2;
    _v2 = const types.Some(null);
    return types.value(_v2);
}

Async<int> Function(String) closure20(void unitVar, String v0_1) => (String v) => closure21(v0_1, v);

US6 closure25(void unitVar, int v0_1) => US6_US6_0(v0_1);

US6 closure26(void unitVar, dynamic v0_1) => US6_US6_1(v0_1);

String closure27(void unitVar, void unitVar_1) => 'run_with_timeout_async';

String closure28(void unitVar, void unitVar_1) => 'timeout: ${1000} / ${closure3(util.ignore(), util.ignore())}';

String closure29(String v0_1, void unitVar) => 'run_with_timeout_async** / ex: $v0_1';

String closure30(void unitVar, void unitVar_1) => 'read_all_text_retry_async';

String method15(int v0_1, String v1) => 'retry: $v0_1 / ex: $v1 / ${closure3(util.ignore(), util.ignore())}';

String closure31(int v0_1, String v1, void unitVar) => method15(v0_1, v1);

Async<types.Some<String>?> method14(String v0_1, int v1) {
    types.Some<Async<types.Some<String>?>>? _v2;
    _v2 = const types.Some(null);
    return types.value(_v2);
}

Async<types.Some<String>?> closure24(void unitVar, String v0_1) {
    types.Some<Async<types.Some<String>?>>? _v1;
    _v1 = const types.Some(null);
    return types.value(_v1);
}

String closure33(void unitVar, void unitVar_1) {
    types.Some<String>? _v0_1;
    _v0_1 = const types.Some('');
    return types.value(_v0_1);
}

String closure32(void unitVar, void unitVar_1) {
    types.Some<String>? _v0_1;
    _v0_1 = const types.Some('');
    return types.value(_v0_1);
}

String closure35(String v0_1, String v1, void unitVar) => 'temp_folder: $v0_1 / result: $v1 ${closure3(util.ignore(), util.ignore())}';

void closure36(String v0_1, void unitVar) {
    types.Some<Async<int>>? _v1;
    _v1 = const types.Some(null);
    final v8 = types.value(_v1);
    types.Some<Async<void>>? _v9;
    _v9 = const types.Some(null);
    final v16 = types.value(_v9);
    types.Some<void>? _v17;
    _v17 = const types.Some(null);
    types.value(_v17);
}

types.Tuple2<String, types.IDisposable> closure34(void unitVar, void unitVar_1) {
    types.Some<types.Tuple2<String, types.IDisposable>>? _v0_1;
    _v0_1 = const types.Some(types.Tuple2('', null));
    final patternInput = types.value(_v0_1);
    return types.Tuple2(patternInput.item1, patternInput.item2);
}

String closure37(void unitVar, void unitVar_1) => 'C:\\home\\git\\polyglot\\lib\\spiral';

bool closure41(void unitVar, String v0_1) {
    types.Some<bool>? _v1;
    _v1 = const types.Some(false);
    return types.value(_v1);
}

bool closure42(void unitVar, String v0_1) {
    types.Some<bool>? _v1;
    _v1 = const types.Some(false);
    return types.value(_v1);
}

types.Some<String>? closure43(void unitVar, String v0_1) {
    types.Some<US8>? _v1;
    _v1 = const types.Some(null);
    final US8 v39 = types.value(_v1);
    if (v39.tag == /* US8_0 */ 0) {
        final v39_1 = v39 as US8_US8_0;
        return types.Some(v39_1.f0_0);
    } else {
        return null;
    }
}

types.Some<String>? Function(String) method17() => (String v) => closure43(util.ignore(), v);

US8 closure44(void unitVar, String v0_1) => US8_US8_0(v0_1);

US8 Function(String) method18() => (String v) => closure44(util.ignore(), v);

String method19(String v0_1_mut, bool v1_mut, String v2_mut, String v3_mut) {
    method19:
    while (true) {
        final v0_1 = v0_1_mut;
        final v1 = v1_mut;
        final v2 = v2_mut;
        final v3 = v3_mut;
        types.Some<String>? _v4;
        _v4 = const types.Some('');
        if ((v1 ? ((String v) => closure41(util.ignore(), v)) : ((String v_1) => closure42(util.ignore(), v_1)))(types.value(_v4))) {
            return v3;
        } else {
            final types.Some<String>? v36 = (method17())(v3);
            final US8 v39 = option_2.defaultValue(const US8(/* US8_1 */ 1), option_2.map<String, US8>(method18(), v36));
            if (v39.tag == /* US8_0 */ 0) {
                v0_1_mut = v0_1;
                v1_mut = v1;
                v2_mut = v2;
                final v39_1 = v39 as US8_US8_0;
                v3_mut = v39_1.f0_0;
                continue method19;
            } else {
                return throw Exception('No parent for ${v1 ? 'file' : 'dir'} \'$v0_1\' at \'$v2\'');
            }
        }
    }
}

String method16(String v0_1, bool v1, String v2) {
    types.Some<String>? _v3;
    _v3 = const types.Some('');
    if ((v1 ? ((String v) => closure41(util.ignore(), v)) : ((String v_1) => closure42(util.ignore(), v_1)))(types.value(_v3))) {
        return v2;
    } else {
        final types.Some<String>? v35 = (method17())(v2);
        final US8 v38 = option_2.defaultValue(const US8(/* US8_1 */ 1), option_2.map<String, US8>(method18(), v35));
        if (v38.tag == /* US8_0 */ 0) {
            final v38_1 = v38 as US8_US8_0;
            return method19(v0_1, v1, v2, v38_1.f0_0);
        } else {
            return throw Exception('No parent for ${v1 ? 'file' : 'dir'} \'$v0_1\' at \'$v2\'');
        }
    }
}

String closure40(String v0_1, bool v1, String v2) => method16(v0_1, v1, v2);

String Function(String) closure39(String v0_1, bool v1) => (String v) => closure40(v0_1, v1, v);

String Function(String) Function(bool) closure38(void unitVar, String v0_1) => (bool v) => closure39(v0_1, v);

String closure46(String v0_1, String v1) {
    types.Some<String>? _v2;
    _v2 = const types.Some('');
    return types.value(_v2);
}

String Function(String) closure45(void unitVar, String v0_1) => (String v) => closure46(v0_1, v);

const types.Some<void>? v0 = null;

types.Some<void>? _v0 = v0;

String v11() => closure32(util.ignore(), util.ignore());

String create_temp_directory_name() => v11();

types.Tuple2<String, types.IDisposable> v12() => closure34(util.ignore(), util.ignore());

types.Tuple2<String, types.IDisposable> create_temp_directory() => v12();

String v13() => closure37(util.ignore(), util.ignore());

String get_source_directory() => v13();

String Function(String) Function(bool) v14(String v) => closure38(util.ignore(), v);

String Function(String) Function(bool) find_parent(String x) => v14(x);

String Function(String) v15(String v) => closure45(util.ignore(), v);

String Function(String) op_LessDivideGreater(String x) => v15(x);

