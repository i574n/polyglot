// ignore_for_file: camel_case_types, constant_identifier_names, non_constant_identifier_names, unnecessary_this
import '../../fable_modules/fable_library/Option.dart' as option_2;
import '../../fable_modules/fable_library/String.dart' as string;
import '../../fable_modules/fable_library/Types.dart' as types;
import '../../fable_modules/fable_library/Util.dart' as util;

types.Some<types.Tuple5<Mut0, Mut1, Mut1, Mut2, types.Some<int>?>>? State_trace_state;

abstract class IFsExistsSync {
    bool existsSync(String path);
}

abstract class IPathJoin {
    String join(List<String> paths);
}

abstract class IPathDirname {
    String dirname(String path);
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
    final US3 f0_0;
    final US4 f0_1;
    const US2_US2_0(this.f0_0, this.f0_1): super(0);
    @override
    bool operator ==(Object other) => (other is US2_US2_0) && ((other.f0_0 == f0_0) && (other.f0_1 == f0_1));
    @override
    int get hashCode => util.combineHashCodes([tag.hashCode, f0_0.hashCode, f0_1.hashCode]);
    @override
    int compareTo(US2 other) {
        if (other is US2_US2_0) {
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

bool US4__get_IsUS4_2(types.FSharpRef<US4, InOut> this$, void unitArg) {
    if (this$.tag == 2) {
        return true;
    } else {
        return false;
    }
}

bool US4__get_IsUS4_3(types.FSharpRef<US4, InOut> this$, void unitArg) {
    if (this$.tag == 3) {
        return true;
    } else {
        return false;
    }
}

bool US4__get_IsUS4_4(types.FSharpRef<US4, InOut> this$, void unitArg) {
    if (this$.tag == 4) {
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

String closure3(void unitVar, String v0_1) {
    types.Some<String>? _v1;
    _v1 = const types.Some('');
    return types.value(_v1);
}

String closure4(void unitVar, void unitVar_1) => '';

String method3(String v0_1, String v1_1) => 'path: ${closure3(util.ignore(), v0_1)} / ex: $v1_1 / ${closure4(util.ignore(), util.ignore())}';

String closure2(String v0_1, String v1_1, void unitVar) => method3(v0_1, v1_1);

Async<int> method2(String v0_1, int v1_1) {
    types.Some<Async<int>>? _v2;
    _v2 = const types.Some(null);
    return types.value(_v2);
}

Async<int> closure1(void unitVar, String v0_1) {
    types.Some<Async<int>>? _v1;
    _v1 = const types.Some(null);
    return types.value(_v1);
}

String method5(String v0_1, int v1_1, String v2_1) => 'path: ${closure3(util.ignore(), v0_1)} / retry: $v1_1 / ex: $v2_1 / ${closure4(util.ignore(), util.ignore())}';

String closure7(String v0_1, int v1_1, String v2_1, void unitVar) => method5(v0_1, v1_1, v2_1);

Async<int> method4(String v0_1, US4 v1_1, US3 v2_1, int v3_1) {
    types.Some<Async<int>>? _v4;
    _v4 = const types.Some(null);
    return types.value(_v4);
}

Async<int> closure6(US2 v0_1, String v1_1) {
    types.Some<Async<int>>? _v2;
    _v2 = const types.Some(null);
    return types.value(_v2);
}

Async<int> Function(String) closure5(void unitVar, US2 v0_1) => (String v) => closure6(v0_1, v);

Async<int> method6(String v0_1, int v1_1) {
    types.Some<Async<int>>? _v2;
    _v2 = const types.Some(null);
    return types.value(_v2);
}

Async<int> closure8(void unitVar, String v0_1) {
    types.Some<Async<int>>? _v1;
    _v1 = const types.Some(null);
    return types.value(_v1);
}

Async<String> closure9(void unitVar, String v0_1) {
    types.Some<Async<String>>? _v1;
    _v1 = const types.Some(null);
    return types.value(_v1);
}

String method7(String v0_1) => v0_1;

Async<bool> closure11(String v0_1, String v1_1) {
    types.Some<Async<bool>>? _v2;
    _v2 = const types.Some(null);
    return types.value(_v2);
}

Async<bool> Function(String) closure10(void unitVar, String v0_1) => (String v) => closure11(v0_1, v);

Async<void> closure13(String v0_1, String v1_1) {
    types.Some<Async<void>>? _v2;
    _v2 = const types.Some(null);
    return types.value(_v2);
}

Async<void> Function(String) closure12(void unitVar, String v0_1) => (String v) => closure13(v0_1, v);

Async<void> closure15(String v0_1, String v1_1) {
    types.Some<Async<void>>? _v2;
    _v2 = const types.Some(null);
    return types.value(_v2);
}

Async<void> Function(String) closure14(void unitVar, String v0_1) => (String v) => closure15(v0_1, v);

String closure17(void unitVar, void unitVar_1) => 'delete_file_async';

US5 closure19(void unitVar, int v0_1) => US5_US5_0(v0_1);

US5 Function(int) method10() => (int v) => closure19(util.ignore(), v);

String method11() => '';

String closure18(US0 v0_1, String Function() v1_1, String Function() v2_1, void unitVar) {
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

void method9(US0 v0_1, String Function() v1_1, String Function() v2_1) {
    types.Tuple5<Mut0, Mut1, Mut1, Mut2, types.Some<int>?> v3_1() => closure0(util.ignore(), util.ignore());
    if (State_trace_state == null) {
        State_trace_state = types.Some(v3_1());
    }
    final v4_1 = types.value(State_trace_state).item1;
    if (State_trace_state == null) {
        State_trace_state = types.Some(v3_1());
    }
    final patternInput_1 = types.value(State_trace_state);
    final US0 v14_1 = patternInput_1.item4.l0;
    if (patternInput_1.item3.l0 && (v0_1.compareTo(v14_1) >= 0)) {
        final v19 = v4_1.l0 + 1;
        v4_1.l0 = v19;
        final v21 = '${closure18(v0_1, v1_1, v2_1, util.ignore())}';
        types.Some<void>? _v22;
        null;
        _v22 = types.Some(util.ignore());
        types.value(_v22);
    }
}

Async<int> method8(String v0_1, int v1_1) {
    types.Some<Async<int>>? _v2;
    _v2 = const types.Some(null);
    return types.value(_v2);
}

Async<int> closure16(void unitVar, String v0_1) {
    types.Some<Async<int>>? _v1;
    _v1 = const types.Some(null);
    return types.value(_v1);
}

String closure22(void unitVar, void unitVar_1) => 'move_file_async';

String method13(String v0_1, String v1_1, dynamic v2_1) {
    types.Some<String>? _v3;
    _v3 = const types.Some('');
    final v11_1 = types.value(_v3);
    String v12_1(String v) => closure3(util.ignore(), v);
    return 'old_path: ${v12_1(v1_1)} / new_path: ${v12_1(v0_1)} / ex: $v11_1 / ${closure4(util.ignore(), util.ignore())}';
}

String closure23(String v0_1, String v1_1, dynamic v2_1, void unitVar) => method13(v0_1, v1_1, v2_1);

Async<int> method12(String v0_1, String v1_1, int v2_1) {
    types.Some<Async<int>>? _v3;
    _v3 = const types.Some(null);
    return types.value(_v3);
}

Async<int> closure21(String v0_1, String v1_1) {
    types.Some<Async<int>>? _v2;
    _v2 = const types.Some(null);
    return types.value(_v2);
}

Async<int> Function(String) closure20(void unitVar, String v0_1) => (String v) => closure21(v0_1, v);

US6 closure25(void unitVar, int v0_1) => US6_US6_0(v0_1);

US6 closure26(void unitVar, dynamic v0_1) => US6_US6_1(v0_1);

String closure27(void unitVar, void unitVar_1) => 'run_with_timeout_async';

String closure28(void unitVar, void unitVar_1) => 'timeout: ${1000} / ${closure4(util.ignore(), util.ignore())}';

String closure29(String v0_1, void unitVar) => 'run_with_timeout_async** / ex: $v0_1';

String closure30(void unitVar, void unitVar_1) => 'read_all_text_retry_async';

String method15(int v0_1, String v1_1) => 'retry: $v0_1 / ex: $v1_1 / ${closure4(util.ignore(), util.ignore())}';

String closure31(int v0_1, String v1_1, void unitVar) => method15(v0_1, v1_1);

Async<types.Some<String>?> method14(String v0_1, int v1_1) {
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
    types.Some<String>? _v0;
    _v0 = const types.Some('');
    return types.value(_v0);
}

String method16(String v0_1) => v0_1;

String method17(String v0_1) => v0_1;

String closure32(void unitVar, void unitVar_1) {
    types.Some<String>? _v0;
    _v0 = const types.Some('');
    return types.value(_v0);
}

String closure35(String v0_1, String v1_1, void unitVar) => 'temp_folder: $v0_1 / result: $v1_1 ${closure4(util.ignore(), util.ignore())}';

void closure36(String v0_1, void unitVar) {
    types.Some<Async<int>>? _v1;
    _v1 = const types.Some(null);
    final v10_1 = types.value(_v1);
    types.Some<Async<void>>? _v11;
    _v11 = const types.Some(null);
    final v20 = types.value(_v11);
    types.Some<void>? _v21;
    null;
    _v21 = types.Some(util.ignore());
    types.value(_v21);
}

types.Tuple2<String, types.IDisposable> closure34(void unitVar, void unitVar_1) {
    types.Some<types.Tuple2<String, types.IDisposable>>? _v0;
    const patternInput = types.Tuple2('', null);
    _v0 = types.Some(types.Tuple2(patternInput.item1, patternInput.item2));
    final patternInput_1 = types.value(_v0);
    return types.Tuple2(patternInput_1.item1, patternInput_1.item2);
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
    final US8 v43 = types.value(_v1);
    if (v43.tag == /* US8_0 */ 0) {
        final v43_1 = v43 as US8_US8_0;
        return types.Some(v43_1.f0_0);
    } else {
        return null;
    }
}

types.Some<String>? Function(String) method19() => (String v) => closure43(util.ignore(), v);

US8 closure44(void unitVar, String v0_1) => US8_US8_0(v0_1);

US8 Function(String) method20() => (String v) => closure44(util.ignore(), v);

String method21(String v0_1_mut, bool v1_1_mut, String v2_1_mut, String v3_1_mut) {
    method21:
    while (true) {
        final v0_1 = v0_1_mut;
        final v1_1 = v1_1_mut;
        final v2_1 = v2_1_mut;
        final v3_1 = v3_1_mut;
        types.Some<String>? _v4;
        _v4 = const types.Some('');
        if ((v1_1 ? ((String v) => closure41(util.ignore(), v)) : ((String v_1) => closure42(util.ignore(), v_1)))(types.value(_v4))) {
            return v3_1;
        } else {
            final types.Some<String>? v40 = (method19())(v3_1);
            final US8 v43 = option_2.defaultValue(const US8(/* US8_1 */ 1), option_2.map<String, US8>(method20(), v40));
            if (v43.tag == /* US8_0 */ 0) {
                v0_1_mut = v0_1;
                v1_1_mut = v1_1;
                v2_1_mut = v2_1;
                final v43_1 = v43 as US8_US8_0;
                v3_1_mut = v43_1.f0_0;
                continue method21;
            } else {
                return throw Exception('No parent for ${v1_1 ? 'file' : 'dir'} \'$v0_1\' at \'$v2_1\' (until \'$v3_1\')');
            }
        }
    }
}

String method18(String v0_1, bool v1_1, String v2_1) {
    types.Some<String>? _v3;
    _v3 = const types.Some('');
    if ((v1_1 ? ((String v) => closure41(util.ignore(), v)) : ((String v_1) => closure42(util.ignore(), v_1)))(types.value(_v3))) {
        return v2_1;
    } else {
        final types.Some<String>? v39 = (method19())(v2_1);
        final US8 v42 = option_2.defaultValue(const US8(/* US8_1 */ 1), option_2.map<String, US8>(method20(), v39));
        if (v42.tag == /* US8_0 */ 0) {
            final v42_1 = v42 as US8_US8_0;
            return method21(v0_1, v1_1, v2_1, v42_1.f0_0);
        } else {
            return throw Exception('No parent for ${v1_1 ? 'file' : 'dir'} \'$v0_1\' at \'$v2_1\' (until \'$v2_1\')');
        }
    }
}

String closure40(String v0_1, bool v1_1, String v2_1) => method18(v0_1, v1_1, v2_1);

String Function(String) closure39(String v0_1, bool v1_1) => (String v) => closure40(v0_1, v1_1, v);

String Function(String) Function(bool) closure38(void unitVar, String v0_1) => (bool v) => closure39(v0_1, v);

String method22() => 'polyglot';

String method23() => '.paket';

String method24() => 'polyglot';

String method25() => '.paket';

String method27(String v0_1_mut, String v1_1_mut, String v2_1_mut) {
    method27:
    while (true) {
        final v0_1 = v0_1_mut;
        final v1_1 = v1_1_mut;
        final v2_1 = v2_1_mut;
        types.Some<String>? _v3;
        _v3 = const types.Some('');
        final v33 = types.value(_v3);
        types.Some<bool>? _v34;
        _v34 = const types.Some(false);
        if (types.value(_v34)) {
            return v2_1;
        } else {
            final types.Some<String>? v59 = (method19())(v2_1);
            final US8 v62 = option_2.defaultValue(const US8(/* US8_1 */ 1), option_2.map<String, US8>(method20(), v59));
            if (v62.tag == /* US8_0 */ 0) {
                v0_1_mut = v0_1;
                v1_1_mut = v1_1;
                final v62_1 = v62 as US8_US8_0;
                v2_1_mut = v62_1.f0_0;
                continue method27;
            } else {
                return throw Exception('No parent for ${'dir'} \'$v0_1\' at \'$v1_1\' (until \'$v2_1\')');
            }
        }
    }
}

String method26(String v0_1, String v1_1) {
    types.Some<String>? _v2;
    _v2 = const types.Some('');
    final v32 = types.value(_v2);
    types.Some<bool>? _v33;
    _v33 = const types.Some(false);
    if (types.value(_v33)) {
        return v1_1;
    } else {
        final types.Some<String>? v58 = (method19())(v1_1);
        final US8 v61 = option_2.defaultValue(const US8(/* US8_1 */ 1), option_2.map<String, US8>(method20(), v58));
        if (v61.tag == /* US8_0 */ 0) {
            final v61_1 = v61 as US8_US8_0;
            return method27(v0_1, v1_1, v61_1.f0_0);
        } else {
            return throw Exception('No parent for ${'dir'} \'$v0_1\' at \'$v1_1\' (until \'$v1_1\')');
        }
    }
}

String method28() => 'polyglot';

String closure45(void unitVar, void unitVar_1) {
    types.Some<String>? _v1;
    _v1 = const types.Some('');
    final v34 = method26(types.value(_v1), 'C:\\home\\git\\polyglot\\lib\\spiral');
    types.Some<String>? _v35;
    _v35 = const types.Some('');
    return types.value(_v35);
}

String closure47(String v0_1, String v1_1) {
    types.Some<String>? _v2;
    _v2 = const types.Some('');
    return types.value(_v2);
}

String Function(String) closure46(void unitVar, String v0_1) => (String v) => closure47(v0_1, v);

types.Tuple5<Mut0, Mut1, Mut1, Mut2, types.Some<int>?> v0() => closure0(util.ignore(), util.ignore());

Async<int> v1(String v) => closure1(util.ignore(), v);

Async<int> delete_directory_async(String x) => v1(x);

Async<int> Function(String) v2(US2 v) => closure5(util.ignore(), v);

Async<int> Function(String) wait_for_file_access(US2 x) => v2(x);

Async<int> v3(String v) => closure8(util.ignore(), v);

Async<int> wait_for_file_access_read(String x) => v3(x);

Async<String> v4(String v) => closure9(util.ignore(), v);

Async<String> read_all_text_async(String x) => v4(x);

Async<bool> Function(String) v5(String v) => closure10(util.ignore(), v);

Async<bool> Function(String) file_exists_content(String x) => v5(x);

Async<void> Function(String) v6(String v) => closure12(util.ignore(), v);

Async<void> Function(String) write_all_text_async(String x) => v6(x);

Async<void> Function(String) v7(String v) => closure14(util.ignore(), v);

Async<void> Function(String) write_all_text_exists(String x) => v7(x);

Async<int> v8(String v) => closure16(util.ignore(), v);

Async<int> delete_file_async(String x) => v8(x);

Async<int> Function(String) v9(String v) => closure20(util.ignore(), v);

Async<int> Function(String) move_file_async(String x) => v9(x);

Async<types.Some<String>?> v10(String v) => closure24(util.ignore(), v);

Async<types.Some<String>?> read_all_text_retry_async(String x) => v10(x);

String v11() => closure32(util.ignore(), util.ignore());

String create_temp_directory_name() => v11();

types.Tuple2<String, types.IDisposable> v12() => closure34(util.ignore(), util.ignore());

types.Tuple2<String, types.IDisposable> create_temp_directory() => v12();

String v13() => closure37(util.ignore(), util.ignore());

String get_source_directory() => v13();

String Function(String) Function(bool) v14(String v) => closure38(util.ignore(), v);

String Function(String) Function(bool) find_parent(String x) => v14(x);

String v15() => closure45(util.ignore(), util.ignore());

String get_repository_root() => v15();

String Function(String) v16(String v) => closure46(util.ignore(), v);

String Function(String) op_LessDivideGreater(String x) => v16(x);

