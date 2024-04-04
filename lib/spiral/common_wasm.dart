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

abstract class US1 implements types.Union, Comparable<US1> {
    final int tag;
    const US1(this.tag);
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

class US1_US1_1 extends US1 {
    final US0 f1_0;
    const US1_US1_1(this.f1_0): super(1);
    @override
    bool operator ==(Object other) => (other is US1_US1_1) && (other.f1_0 == f1_0);
    @override
    int get hashCode => util.combineHashCodes([tag.hashCode, f1_0.hashCode]);
    @override
    int compareTo(US1 other) {
        if (other is US1_US1_1) {
            return f1_0.compareTo(other.f1_0);
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
    final US2 f0_0;
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

types.IDisposable closure0(void unitVar, void Function() v0_1) {
    types.Some<types.IDisposable>? _v1;
    const x = null;
    _v1 = const types.Some(x);
    return types.value(_v1);
}

US2 closure3(int v0_1, void Function() v1_1, int v2, void unitVar) {
    if (v2 < v0_1) {
        v1_1();
        return const US2(/* US2_0 */ 0);
    } else {
        return const US2(/* US2_1 */ 1);
    }
}

US3 closure4(void unitVar, US2 v0_1) => US3_US3_0(v0_1);

void closure5(void unitVar, dynamic v0_1) {
    types.Some<void>? _v1;
    _v1 = types.Some(util.ignore());
    types.value(_v1);
}

US2 method0(int v0_1_mut, void Function() v1_1_mut, int v2_mut) {
    method0:
    while (true) {
        final v0_1 = v0_1_mut;
        final v1_1 = v1_1_mut;
        final v2 = v2_mut;
        late final US3 v7;
        try {
            v7 = closure4(util.ignore(), closure3(v0_1, v1_1, v2, util.ignore()));
        } catch (ex) {
            closure5(util.ignore(), ex);
            v7 = const US3(/* US3_1 */ 1);
        }
        if (v7.tag == /* US3_0 */ 0) {
            final v7_1 = v7 as US3_US3_0;
            return v7_1.f0_0;
        } else {
            v0_1_mut = v0_1;
            v1_1_mut = v1_1;
            v2_mut = v2 + 1;
            continue method0;
        }
    }
}

types.Some<void>? closure2(int v0_1, void Function() v1_1) {
    final US2 v3 = method0(v0_1, v1_1, 0);
    if (v3.tag == /* US2_0 */ 0) {
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

