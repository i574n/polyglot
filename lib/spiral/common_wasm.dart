// ignore_for_file: camel_case_types, constant_identifier_names, non_constant_identifier_names, unnecessary_this
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
    final US0 f0_0;
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

types.IDisposable closure0(void unitVar, void Function() v0_1) {
    types.Some<types.IDisposable>? _v1;
    _v1 = const types.Some(null);
    return types.value(_v1);
}

US0 closure3(int v0_1, void Function() v1_1, int v2, void unitVar) {
    if (v2 < v0_1) {
        v1_1();
        return const US0(/* US0_0 */ 0);
    } else {
        return const US0(/* US0_1 */ 1);
    }
}

US1 closure4(void unitVar, US0 v0_1) => US1_US1_0(v0_1);

US1 closure5(int v0_1, dynamic v1_1) {
    types.Some<void>? _v2;
    null;
    _v2 = types.Some(util.ignore());
    types.value(_v2);
    return const US1(/* US1_1 */ 1);
}

US0 method0(int v0_1_mut, void Function() v1_1_mut, int v2_mut) {
    method0:
    while (true) {
        final v0_1 = v0_1_mut;
        final v1_1 = v1_1_mut;
        final v2 = v2_mut;
        late final US1 v6;
        try {
            v6 = closure4(util.ignore(), closure3(v0_1, v1_1, v2, util.ignore()));
        } catch (ex) {
            v6 = closure5(v2, ex);
        }
        if (v6.tag == /* US1_0 */ 0) {
            final v6_1 = v6 as US1_US1_0;
            return v6_1.f0_0;
        } else {
            v0_1_mut = v0_1;
            v1_1_mut = v1_1;
            v2_mut = v2 + 1;
            continue method0;
        }
    }
}

types.Some<void>? closure2(int v0_1, void Function() v1_1) {
    final US0 v3 = method0(v0_1, v1_1, 0);
    if (v3.tag == /* US0_0 */ 0) {
        return types.Some(util.ignore());
    } else {
        return null;
    }
}

types.Some<void>? Function(void Function()) closure1(void unitVar, int v0_1) => (void Function() v) => closure2(v0_1, v);

types.IDisposable v0(void Function() v) => closure0(util.ignore(), v);

types.IDisposable new_disposable(void Function() x) => v0(x);

types.Some<void>? Function(void Function()) v1(int v) => closure1(util.ignore(), v);

types.Some<void>? Function(void Function()) retry_fn(int x) => v1(x);

