// ignore_for_file: camel_case_types, constant_identifier_names, non_constant_identifier_names, unnecessary_this
import '../../fable_modules/fable_library/Seq.dart' as seq;
import '../../fable_modules/fable_library/String.dart' as string;
import '../../fable_modules/fable_library/Types.dart' as types;
import '../../fable_modules/fable_library/Util.dart' as util;

class Mut0 implements types.Record, Comparable<Mut0> {
    int l0;
    String l1;
    Mut0(this.l0, this.l1);
    @override
    bool operator ==(Object other) => (other is Mut0) && ((other.l0 == l0) && (other.l1 == l1));
    @override
    int get hashCode => util.combineHashCodes([l0.hashCode, l1.hashCode]);
    @override
    int compareTo(Mut0 other) {
        late int $r;
        if (($r = l0.compareTo(other.l0)) == 0) {
            $r = l1.compareTo(other.l1);
        }
        return $r;
    }
}

class Mut1 implements types.Record, Comparable<Mut1> {
    int l0;
    Mut1(this.l0);
    @override
    bool operator ==(Object other) => (other is Mut1) && (other.l0 == l0);
    @override
    int get hashCode => l0.hashCode;
    @override
    int compareTo(Mut1 other) => l0.compareTo(other.l0);
}

bool closure1(String v0_1, String v1_1) => v1_1.contains(v0_1);

bool Function(String) closure0(void unitVar, String v0_1) => (String v) => closure1(v0_1, v);

bool closure3(String v0_1, String v1_1) => v1_1.endsWith(v0_1);

bool Function(String) closure2(void unitVar, String v0_1) => (String v) => closure3(v0_1, v);

String closure6(int v0_1, int v1_1, String v2_1) => string.padLeft(v2_1, v0_1, v1_1);

String Function(String) closure5(int v0_1, int v1_1) => (String v) => closure6(v0_1, v1_1, v);

String Function(String) Function(int) closure4(void unitVar, int v0_1) => (int v) => closure5(v0_1, v);

String closure8(int v0_1, String v1_1) => string.padRight(v1_1, v0_1);

String Function(String) closure7(void unitVar, int v0_1) => (String v) => closure8(v0_1, v);

String closure11(String v0_1, String v1_1, String v2_1) => v2_1.replaceAll(v0_1, v1_1);

String Function(String) closure10(String v0_1, String v1_1) => (String v) => closure11(v0_1, v1_1, v);

String Function(String) Function(String) closure9(void unitVar, String v0_1) => (String v) => closure10(v0_1, v);

String closure14(int v0_1, int v1_1, String v2_1) => v2_1.substring(v0_1, v1_1 + 1);

String Function(String) closure13(int v0_1, int v1_1) => (String v) => closure14(v0_1, v1_1, v);

String Function(String) Function(int) closure12(void unitVar, int v0_1) => (int v) => closure13(v0_1, v);

List<String> closure16(String v0_1, String v1_1) => string.split(v1_1, [v0_1], null, 0);

List<String> Function(String) closure15(void unitVar, String v0_1) => (String v) => closure16(v0_1, v);

String method0() => '';

List<String> closure18(List<String> v0_1, String v1_1) {
    types.Some<List<String>>? _v2;
    _v2 = const types.Some(null);
    return types.value(_v2);
}

List<String> Function(String) closure17(void unitVar, List<String> v0_1) => (String v) => closure18(v0_1, v);

bool closure20(String v0_1, String v1_1) => v1_1.startsWith(v0_1);

bool Function(String) closure19(void unitVar, String v0_1) => (String v) => closure20(v0_1, v);

String closure23(int v0_1, int v1_1, String v2_1) => v2_1.substring(v0_1, v0_1 + v1_1);

String Function(String) closure22(int v0_1, int v1_1) => (String v) => closure23(v0_1, v1_1, v);

String Function(String) Function(int) closure21(void unitVar, int v0_1) => (int v) => closure22(v0_1, v);

String closure24(void unitVar, String v0_1) => v0_1.toLowerCase();

String closure25(void unitVar, String v0_1) => v0_1.toUpperCase();

String closure26(void unitVar, String v0_1) => v0_1.trim();

String closure28(List<int> v0_1, String v1_1) => string.trimEnd(v1_1, v0_1);

String Function(String) closure27(void unitVar, List<int> v0_1) => (String v) => closure28(v0_1, v);

String closure30(List<int> v0_1, String v1_1) => string.trimStart(v1_1, v0_1);

String Function(String) closure29(void unitVar, List<int> v0_1) => (String v) => closure30(v0_1, v);

String closure32(int v0_1, String v1_1) {
    if (v1_1.length <= v0_1) {
        return v1_1;
    } else {
        final v4_1 = v0_1 - 1;
        return v1_1.substring(0, v4_1 + 1) + '...';
    }
}

String Function(String) closure31(void unitVar, int v0_1) => (String v) => closure32(v0_1, v);

String closure34(int v0_1, String v1_1) {
    final v2_1 = v1_1.length;
    if (v2_1 <= v0_1) {
        return v1_1;
    } else {
        final v5_1 = v0_1.toDouble() / 2.0;
        final v7_1 = v5_1.ceilToDouble();
        final v8_1 = v7_1.toInt();
        final v10_1 = v5_1.floorToDouble();
        final v12_1 = v8_1 - 1;
        final v14_1 = v2_1 - v10_1.toInt();
        final v15_1 = v2_1 - 1;
        final v20_1 = seq.ofArray<String>([v1_1.substring(0, v12_1 + 1), '...', v1_1.substring(v14_1, v15_1 + 1)]);
        final sep = method0();
        return v20_1.join(sep);
    }
}

String Function(String) closure33(void unitVar, int v0_1) => (String v) => closure34(v0_1, v);

String closure35(void unitVar, dynamic v0_1) {
    types.Some<String>? _v1;
    _v1 = const types.Some('');
    return types.value(_v1);
}

bool method1(int v0_1, Mut0 v1_1) => v1_1.l0 < v0_1;

String closure37(String v0_1, List<String> v1_1) {
    final v2_1 = v1_1.length;
    final v4_1 = Mut0(0, '');
    while (method1(v2_1, v4_1)) {
        final v6_1 = v4_1.l0;
        final v9_1 = ((v4_1.l1 + v1_1[v6_1]) + v0_1) + '';
        final v10_1 = v6_1 + 1;
        v4_1.l0 = v10_1;
        v4_1.l1 = v9_1;
    }
    return v4_1.l1;
}

String Function(List<String>) closure36(void unitVar, String v0_1) => (List<String> v) => closure37(v0_1, v);

String method2(String v0_1) => v0_1;

String closure39(String v0_1, Iterable<String> v1_1) {
    final sep = method2(v0_1);
    return v1_1.join(sep);
}

String Function(Iterable<String>) closure38(void unitVar, String v0_1) => (Iterable<String> v) => closure39(v0_1, v);

String closure41(String v0_1, List<String> v1_1) => v1_1.join(v0_1);

String Function(List<String>) closure40(void unitVar, String v0_1) => (List<String> v) => closure41(v0_1, v);

bool method3(int v0_1, Mut1 v1_1) => v1_1.l0 < v0_1;

List<int> closure42(void unitVar, String v0_1) {
    final v1_1 = v0_1.length;
    final v2_1 = List.filled(v1_1, 0);
    final v3_1 = Mut1(0);
    while (method3(v1_1, v3_1)) {
        final v5_1 = v3_1.l0;
        final v6_1 = v0_1.codeUnitAt(v5_1);
        v2_1[v5_1] = v6_1;
        final v7_1 = v5_1 + 1;
        v3_1.l0 = v7_1;
    }
    return v2_1;
}

bool Function(String) v0(String v) => closure0(util.ignore(), v);

bool Function(String) contains(String x) => v0(x);

bool Function(String) v1(String v) => closure2(util.ignore(), v);

bool Function(String) ends_with(String x) => v1(x);

String Function(String) Function(int) v2(int v) => closure4(util.ignore(), v);

String Function(String) Function(int) pad_left(int x) => v2(x);

String Function(String) v3(int v) => closure7(util.ignore(), v);

String Function(String) pad_right(int x) => v3(x);

String Function(String) Function(String) v4(String v) => closure9(util.ignore(), v);

String Function(String) Function(String) replace(String x) => v4(x);

String Function(String) Function(int) v5(int v) => closure12(util.ignore(), v);

String Function(String) Function(int) slice(int x) => v5(x);

List<String> Function(String) v6(String v) => closure15(util.ignore(), v);

List<String> Function(String) split(String x) => v6(x);

List<String> Function(String) v7(List<String> v) => closure17(util.ignore(), v);

List<String> Function(String) split_string(List<String> x) => v7(x);

bool Function(String) v8(String v) => closure19(util.ignore(), v);

bool Function(String) starts_with(String x) => v8(x);

String Function(String) Function(int) v9(int v) => closure21(util.ignore(), v);

String Function(String) Function(int) substring(int x) => v9(x);

String v10(String v) => closure24(util.ignore(), v);

String to_lower(String x) => v10(x);

String v11(String v) => closure25(util.ignore(), v);

String to_upper(String x) => v11(x);

String v12(String v) => closure26(util.ignore(), v);

String trim(String x) => v12(x);

String Function(String) v13(List<int> v) => closure27(util.ignore(), v);

String Function(String) trim_end(List<int> x) => v13(x);

String Function(String) v14(List<int> v) => closure29(util.ignore(), v);

String Function(String) trim_start(List<int> x) => v14(x);

String Function(String) v15(int v) => closure31(util.ignore(), v);

String Function(String) ellipsis(int x) => v15(x);

String Function(String) v16(int v) => closure33(util.ignore(), v);

String Function(String) ellipsis_end(int x) => v16(x);

String v17(dynamic v) => closure35(util.ignore(), v);

String format_exception(dynamic x) => v17(x);

String Function(List<String>) v18(String v) => closure36(util.ignore(), v);

String Function(List<String>) concat_array_trailing(String x) => v18(x);

String Function(Iterable<String>) v19(String v) => closure38(util.ignore(), v);

String Function(Iterable<String>) concat(String x) => v19(x);

String Function(List<String>) v20(String v) => closure40(util.ignore(), v);

String Function(List<String>) join$0027(String x) => v20(x);

List<int> v21(String v) => closure42(util.ignore(), v);

List<int> to_char_array(String x) => v21(x);

