// ignore_for_file: camel_case_types, constant_identifier_names, non_constant_identifier_names, unnecessary_this
import '../../fable_modules/fable_library/Types.dart' as types;
import '../../fable_modules/fable_library/Util.dart' as util;

abstract class ICryptoCreateHash {
    dynamic createHash(String x);
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

bool method0(int v0_1, Mut0 v1) => v1.l0 < v0_1;

String method1() => '';

String closure0(void unitVar, String v0_1) {
    types.Some<String>? _v1;
    _v1 = const types.Some('');
    return types.value(_v1);
}

String v0(String v) => closure0(util.ignore(), v);

String hash_text(String x) => v0(x);

