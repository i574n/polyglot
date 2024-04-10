// ignore_for_file: camel_case_types, constant_identifier_names, non_constant_identifier_names, unnecessary_this
import '../../fable_modules/fable_library/Date.dart' as date;
import '../../fable_modules/fable_library/Guid.dart' as guid;
import '../../fable_modules/fable_library/String.dart' as string;
import '../../fable_modules/fable_library/Types.dart' as types;
import '../../fable_modules/fable_library/Util.dart' as util;

Guid closure1(Guid v0_1, DateTime v1_1) {
    final v3_1 = v0_1.toString();
    final v4_1 = date.toString(v1_1, 'yyyyMMdd-HHmm-ssff-ffff-f');
    return guid.parse('$v4_1${v3_1.substring(v4_1.length)}');
}

Guid Function(DateTime) closure0(void unitVar, Guid v0_1) => (DateTime v) => closure1(v0_1, v);

String closure5(String v0_1, String v1_1, String v2_1) => v2_1.replaceAll(v0_1, v1_1);

String Function(String) closure4(String v0_1, String v1_1) => (String v) => closure5(v0_1, v1_1, v);

String Function(String) Function(String) closure3(void unitVar, String v0_1) => (String v) => closure4(v0_1, v);

String Function(String) Function(String) Function(String) method0() => (String v) => closure3(util.ignore(), v);

DateTime closure2(void unitVar, Guid v0_1) {
    final v2_1 = v0_1.toString();
    final v3_1 = method0();
    types.Some<DateTime>? _v4;
    final x = date.minValue();
    _v4 = types.Some(x);
    return types.value(_v4);
}

Guid closure7(Guid v0_1, int v1_1) {
    final v3_1 = v0_1.toString();
    final v6_1 = string.padLeft(v1_1.toString(), 18, 48);
    return guid.parse('${v6_1.substring(0, 8)}-${v6_1.substring(8, 12)}-${v6_1.substring(12, 16)}-${v6_1.substring(16, 18)}${v3_1.substring(21)}');
}

Guid Function(int) closure6(void unitVar, Guid v0_1) => (int v) => closure7(v0_1, v);

int closure8(void unitVar, Guid v0_1) {
    final v2_1 = v0_1.toString();
    return int.parse('${v2_1.substring(0, 8)}${v2_1.substring(9, 13)}${v2_1.substring(14, 18)}${v2_1.substring(19, 21)}');
}

Guid closure9(void unitVar, DateTime v0_1) {
    final _arg = guid.newGuid();
    final v3_1 = _arg.toString();
    final v4_1 = date.toString(v0_1, 'yyyyMMdd-HHmm-ssff-ffff-f');
    return guid.parse('$v4_1${v3_1.substring(v4_1.length)}');
}

Guid closure10(void unitVar, int v0_1) {
    final _arg = guid.newGuid();
    final v3_1 = _arg.toString();
    final v6_1 = string.padLeft(v0_1.toString(), 18, 48);
    return guid.parse('${v6_1.substring(0, 8)}-${v6_1.substring(8, 12)}-${v6_1.substring(12, 16)}-${v6_1.substring(16, 18)}${v3_1.substring(21)}');
}

String closure12(String v0_1, DateTime v1_1) => date.toString(v1_1, v0_1);

String Function(DateTime) closure11(void unitVar, String v0_1) => (DateTime v) => closure12(v0_1, v);

String closure13(void unitVar, DateTime v0_1) => date.toString(v0_1, 'yyyy-MM-ddTHH-mm-ss.fff');

Guid Function(DateTime) v0(Guid v) => closure0(util.ignore(), v);

Guid Function(DateTime) date_time_guid_from_date_time(Guid x) => v0(x);

DateTime v1(Guid v) => closure2(util.ignore(), v);

DateTime date_time_from_guid(Guid x) => v1(x);

Guid Function(int) v2(Guid v) => closure6(util.ignore(), v);

Guid Function(int) timestamp_guid_from_timestamp(Guid x) => v2(x);

int v3(Guid v) => closure8(util.ignore(), v);

int timestamp_from_guid(Guid x) => v3(x);

Guid v4(DateTime v) => closure9(util.ignore(), v);

Guid new_guid_from_date_time(DateTime x) => v4(x);

Guid v5(int v) => closure10(util.ignore(), v);

Guid new_guid_from_timestamp(int x) => v5(x);

String Function(DateTime) v6(String v) => closure11(util.ignore(), v);

String Function(DateTime) format(String x) => v6(x);

String v7(DateTime v) => closure13(util.ignore(), v);

String format_iso8601(DateTime x) => v7(x);

