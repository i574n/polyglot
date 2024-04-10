// ignore_for_file: camel_case_types, constant_identifier_names, non_constant_identifier_names, unnecessary_this
import '../../fable_modules/fable_library/Option.dart' as option_3;
import '../../fable_modules/fable_library/Types.dart' as types;
import '../../fable_modules/fable_library/Util.dart' as util;

abstract class IFsExistsSync {
    bool existsSync(String path);
}

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

class US3_US3_0 extends US3 {
    final int f0_0;
    const US3_US3_0(this.f0_0): super(0);
    @override
    bool operator ==(Object other) => (other is US3_US3_0) && (other.f0_0 == f0_0);
    @override
    int get hashCode => util.combineHashCodes([tag.hashCode, f0_0.hashCode]);
    @override
    int compareTo(US3 other) {
        if (other is US3_US3_0) {
            return f0_0.compareTo(other.f0_0);
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
    final int f0_0;
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
    final int f0_0;
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
    final String f0_0;
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

String method3(String v0_1, String v1) => 'path: ${closure2(util.ignore(), v0_1)} / ex: $v1 / ${closure3(util.ignore(), util.ignore())}';

String closure6(String v0_1, String v1, void unitVar) => method3(v0_1, v1);

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

String method8(String v0_1, String v1, dynamic v2) {
    types.Some<String>? _v3;
    _v3 = const types.Some('');
    final v9 = types.value(_v3);
    String v10(String v) => closure2(util.ignore(), v);
    return 'old_path: ${v10(v1)} / new_path: ${v10(v0_1)} / ex: $v9 / ${closure3(util.ignore(), util.ignore())}';
}

String closure18(String v0_1, String v1, dynamic v2, void unitVar) => method8(v0_1, v1, v2);

Async<int> method7(String v0_1, String v1, int v2) {
    types.Some<Async<int>>? _v3;
    _v3 = const types.Some(null);
    return types.value(_v3);
}

Async<int> closure17(String v0_1, String v1) {
    types.Some<Async<int>>? _v2;
    _v2 = const types.Some(null);
    return types.value(_v2);
}

Async<int> Function(String) closure16(void unitVar, String v0_1) => (String v) => closure17(v0_1, v);

US4 closure20(void unitVar, int v0_1) => US4_US4_0(v0_1);

US4 closure21(void unitVar, dynamic v0_1) => US4_US4_1(v0_1);

String closure22(void unitVar, void unitVar_1) => 'timeout: ${1000} / ${closure3(util.ignore(), util.ignore())}';

String method10(int v0_1, String v1) => 'retry: $v0_1 / ex: $v1 / ${closure3(util.ignore(), util.ignore())}';

String closure23(int v0_1, String v1, void unitVar) => method10(v0_1, v1);

Async<types.Some<String>?> method9(String v0_1, int v1) {
    types.Some<Async<types.Some<String>?>>? _v2;
    _v2 = const types.Some(null);
    return types.value(_v2);
}

Async<types.Some<String>?> closure19(void unitVar, String v0_1) {
    types.Some<Async<types.Some<String>?>>? _v1;
    _v1 = const types.Some(null);
    return types.value(_v1);
}

String closure25(void unitVar, void unitVar_1) {
    types.Some<String>? _v0_1;
    _v0_1 = const types.Some('');
    return types.value(_v0_1);
}

String closure24(void unitVar, void unitVar_1) {
    types.Some<String>? _v0_1;
    _v0_1 = const types.Some('');
    return types.value(_v0_1);
}

String closure27(String v0_1, String v1, void unitVar) => 'temp_folder: $v0_1 / result: $v1 ${closure3(util.ignore(), util.ignore())}';

void closure28(String v0_1, void unitVar) {
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

types.Tuple2<String, types.IDisposable> closure26(void unitVar, void unitVar_1) {
    types.Some<types.Tuple2<String, types.IDisposable>>? _v0_1;
    _v0_1 = const types.Some(types.Tuple2('', null));
    final patternInput = types.value(_v0_1);
    return types.Tuple2(patternInput.item1, patternInput.item2);
}

String closure29(void unitVar, void unitVar_1) => 'C:\\home\\git\\polyglot\\lib\\spiral';

bool closure33(void unitVar, String v0_1) {
    types.Some<bool>? _v1;
    _v1 = const types.Some(false);
    return types.value(_v1);
}

bool closure34(void unitVar, String v0_1) {
    types.Some<bool>? _v1;
    _v1 = const types.Some(false);
    return types.value(_v1);
}

types.Some<String>? closure35(void unitVar, String v0_1) {
    types.Some<US6>? _v1;
    _v1 = const types.Some(null);
    final US6 v39 = types.value(_v1);
    if (v39.tag == /* US6_0 */ 0) {
        final v39_1 = v39 as US6_US6_0;
        return types.Some(v39_1.f0_0);
    } else {
        return null;
    }
}

types.Some<String>? Function(String) method12() => (String v) => closure35(util.ignore(), v);

US6 closure36(void unitVar, String v0_1) => US6_US6_0(v0_1);

US6 Function(String) method13() => (String v) => closure36(util.ignore(), v);

String method14(String v0_1_mut, bool v1_mut, String v2_mut, String v3_mut) {
    method14:
    while (true) {
        final v0_1 = v0_1_mut;
        final v1 = v1_mut;
        final v2 = v2_mut;
        final v3 = v3_mut;
        types.Some<String>? _v4;
        _v4 = const types.Some('');
        if ((v1 ? ((String v) => closure33(util.ignore(), v)) : ((String v_1) => closure34(util.ignore(), v_1)))(types.value(_v4))) {
            return v3;
        } else {
            final types.Some<String>? v36 = (method12())(v3);
            final US6 v39 = option_3.defaultValue(const US6(/* US6_1 */ 1), option_3.map<String, US6>(method13(), v36));
            if (v39.tag == /* US6_0 */ 0) {
                v0_1_mut = v0_1;
                v1_mut = v1;
                v2_mut = v2;
                final v39_1 = v39 as US6_US6_0;
                v3_mut = v39_1.f0_0;
                continue method14;
            } else {
                return throw Exception('No parent for ${v1 ? 'file' : 'dir'} \'$v0_1\' at \'$v2\'');
            }
        }
    }
}

String method11(String v0_1, bool v1, String v2) {
    types.Some<String>? _v3;
    _v3 = const types.Some('');
    if ((v1 ? ((String v) => closure33(util.ignore(), v)) : ((String v_1) => closure34(util.ignore(), v_1)))(types.value(_v3))) {
        return v2;
    } else {
        final types.Some<String>? v35 = (method12())(v2);
        final US6 v38 = option_3.defaultValue(const US6(/* US6_1 */ 1), option_3.map<String, US6>(method13(), v35));
        if (v38.tag == /* US6_0 */ 0) {
            final v38_1 = v38 as US6_US6_0;
            return method14(v0_1, v1, v2, v38_1.f0_0);
        } else {
            return throw Exception('No parent for ${v1 ? 'file' : 'dir'} \'$v0_1\' at \'$v2\'');
        }
    }
}

String closure32(String v0_1, bool v1, String v2) => method11(v0_1, v1, v2);

String Function(String) closure31(String v0_1, bool v1) => (String v) => closure32(v0_1, v1, v);

String Function(String) Function(bool) closure30(void unitVar, String v0_1) => (bool v) => closure31(v0_1, v);

String closure38(String v0_1, String v1) {
    types.Some<String>? _v2;
    _v2 = const types.Some('');
    return types.value(_v2);
}

String Function(String) closure37(void unitVar, String v0_1) => (String v) => closure38(v0_1, v);

const types.Some<void>? v0 = null;

types.Some<void>? _v0 = v0;

String v11() => closure24(util.ignore(), util.ignore());

String create_temp_directory_name() => v11();

types.Tuple2<String, types.IDisposable> v12() => closure26(util.ignore(), util.ignore());

types.Tuple2<String, types.IDisposable> create_temp_directory() => v12();

String v13() => closure29(util.ignore(), util.ignore());

String get_source_directory() => v13();

String Function(String) Function(bool) v14(String v) => closure30(util.ignore(), v);

String Function(String) Function(bool) find_parent(String x) => v14(x);

String Function(String) v15(String v) => closure37(util.ignore(), v);

String Function(String) op_LessDivideGreater(String x) => v15(x);

