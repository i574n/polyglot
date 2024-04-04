// ignore_for_file: camel_case_types, constant_identifier_names, non_constant_identifier_names, unnecessary_this
import '../../fable_modules/fable_library/Option.dart' as option_3;
import '../../fable_modules/fable_library/Types.dart' as types;
import '../../fable_modules/fable_library/Util.dart' as util;

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
    final String f0_0;
    const US0_US0_0(this.f0_0): super(0);
    @override
    bool operator ==(Object other) => (other is US0_US0_0) && (other.f0_0 == f0_0);
    @override
    int get hashCode => util.combineHashCodes([tag.hashCode, f0_0.hashCode]);
    @override
    int compareTo(US0 other) {
        if (other is US0_US0_0) {
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

String method0(String v0_1) => v0_1;

String closure0(void unitVar, void unitVar_1) {
    types.Some<String>? _v0;
    final x = null as String;
    _v0 = types.Some(x);
    return types.value(_v0);
}

String closure3(void unitVar, void unitVar_1) => '';

String closure2(String v0_1, String v1_1, void unitVar) => 'temp_folder: $v0_1 / result: $v1_1 ${closure3(util.ignore(), util.ignore())}';

String closure1(void unitVar, void unitVar_1) {
    types.Some<String>? _v0;
    final x = null as String;
    _v0 = types.Some(x);
    return types.value(_v0);
}

String closure4(void unitVar, void unitVar_1) => 'C:\\home\\git\\polyglot\\lib\\spiral';

bool closure8(void unitVar, String v0_1) {
    types.Some<bool>? _v1;
    final x = null as bool;
    _v1 = types.Some(x);
    return types.value(_v1);
}

bool closure9(void unitVar, String v0_1) {
    types.Some<bool>? _v1;
    final x = null as bool;
    _v1 = types.Some(x);
    return types.value(_v1);
}

types.Some<String>? closure10(void unitVar, String v0_1) {
    types.Some<US0>? _v1;
    final US0 x = null as US0;
    _v1 = types.Some(x);
    final US0 v37 = types.value(_v1);
    if (v37.tag == /* US0_0 */ 0) {
        final v37_1 = v37 as US0_US0_0;
        return types.Some(v37_1.f0_0);
    } else {
        return null;
    }
}

types.Some<String>? Function(String) method2() => (String v) => closure10(util.ignore(), v);

US0 closure11(void unitVar, String v0_1) => US0_US0_0(v0_1);

US0 Function(String) method3() => (String v) => closure11(util.ignore(), v);

String method4(String v0_1_mut, bool v1_1_mut, String v2_1_mut, String v3_1_mut) {
    method4:
    while (true) {
        final v0_1 = v0_1_mut;
        final v1_1 = v1_1_mut;
        final v2_1 = v2_1_mut;
        final v3_1 = v3_1_mut;
        types.Some<String>? _v4;
        final x = null as String;
        _v4 = types.Some(x);
        if ((v1_1 ? ((String v) => closure8(util.ignore(), v)) : ((String v_1) => closure9(util.ignore(), v_1)))(types.value(_v4))) {
            return v3_1;
        } else {
            final types.Some<String>? v34 = (method2())(v3_1);
            final US0 v37 = option_3.defaultValue(const US0(/* US0_1 */ 1), option_3.map<String, US0>(method3(), v34));
            if (v37.tag == /* US0_0 */ 0) {
                v0_1_mut = v0_1;
                v1_1_mut = v1_1;
                v2_1_mut = v2_1;
                final v37_1 = v37 as US0_US0_0;
                v3_1_mut = v37_1.f0_0;
                continue method4;
            } else {
                return throw Exception('No parent for ${v1_1 ? 'file' : 'dir'} \'$v0_1\' at \'$v2_1\'');
            }
        }
    }
}

String method1(String v0_1, bool v1_1, String v2_1) {
    types.Some<String>? _v3;
    final x = null as String;
    _v3 = types.Some(x);
    if ((v1_1 ? ((String v) => closure8(util.ignore(), v)) : ((String v_1) => closure9(util.ignore(), v_1)))(types.value(_v3))) {
        return v2_1;
    } else {
        final types.Some<String>? v33 = (method2())(v2_1);
        final US0 v36 = option_3.defaultValue(const US0(/* US0_1 */ 1), option_3.map<String, US0>(method3(), v33));
        if (v36.tag == /* US0_0 */ 0) {
            final v36_1 = v36 as US0_US0_0;
            return method4(v0_1, v1_1, v2_1, v36_1.f0_0);
        } else {
            return throw Exception('No parent for ${v1_1 ? 'file' : 'dir'} \'$v0_1\' at \'$v2_1\'');
        }
    }
}

String closure7(String v0_1, bool v1_1, String v2_1) => method1(v0_1, v1_1, v2_1);

String Function(String) closure6(String v0_1, bool v1_1) => (String v) => closure7(v0_1, v1_1, v);

String Function(String) Function(bool) closure5(void unitVar, String v0_1) => (bool v) => closure6(v0_1, v);

String closure13(String v0_1, String v1_1) {
    types.Some<String>? _v2;
    final x = null as String;
    _v2 = types.Some(x);
    return types.value(_v2);
}

String Function(String) closure12(void unitVar, String v0_1) => (String v) => closure13(v0_1, v);

String v0() => closure0(util.ignore(), util.ignore());

String create_temp_directory_name() => v0();

String v1() => closure1(util.ignore(), util.ignore());

String create_temp_directory() => v1();

String v2() => closure4(util.ignore(), util.ignore());

String get_source_directory() => v2();

String Function(String) Function(bool) v3(String v) => closure5(util.ignore(), v);

String Function(String) Function(bool) find_parent(String x) => v3(x);

String Function(String) v4(String v) => closure12(util.ignore(), v);

String Function(String) op_LessDivideGreater(String x) => v4(x);

