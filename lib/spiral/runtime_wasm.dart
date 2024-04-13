// ignore_for_file: camel_case_types, constant_identifier_names, non_constant_identifier_names, unnecessary_this
import '../../fable_modules/fable_library/String.dart' as string;
import '../../fable_modules/fable_library/Types.dart' as types;
import '../../fable_modules/fable_library/Util.dart' as util;

types.Some<types.Tuple5<Mut0, Mut1, Mut1, Mut2, types.Some<int>?>>? State_trace_state;

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

class UH0 implements types.Union, Comparable<UH0> {
    final int tag;
    const UH0(this.tag);
    @override
    bool operator ==(Object other) => (other is UH0) && (other.tag == tag);
    @override
    int get hashCode => tag.hashCode;
    @override
    int compareTo(UH0 other) => tag.compareTo(other.tag);
}

class UH0_UH0_1 extends UH0 {
    final int Item1;
    final UH0 Item2;
    const UH0_UH0_1(this.Item1, this.Item2): super(1);
    @override
    bool operator ==(Object other) => (other is UH0_UH0_1) && ((other.Item1 == Item1) && (other.Item2 == Item2));
    @override
    int get hashCode => util.combineHashCodes([tag.hashCode, Item1.hashCode, Item2.hashCode]);
    @override
    int compareTo(UH0 other) {
        if (other is UH0_UH0_1) {
            late int $r;
            if (($r = Item1.compareTo(other.Item1)) == 0) {
                $r = Item2.compareTo(other.Item2);
            }
            return $r;
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

class US1_US1_1 extends US1 {
    final US2 f1_0;
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
    final String f0_0;
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
    US0 l0;
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

class US6 implements types.Union {
    final int tag;
    const US6(this.tag);
}

class US6_US6_0 extends US6 {
    final Async<void> Function(types.Tuple3<bool, String, int>) f0_0;
    const US6_US6_0(this.f0_0): super(0);
}

class US7 implements types.Union {
    final int tag;
    const US7(this.tag);
    @override
    bool operator ==(Object other) => (other is US7) && (other.tag == tag);
    @override
    int get hashCode => tag.hashCode;
}

class US7_US7_0 extends US7 {
    final CancellationToken f0_0;
    const US7_US7_0(this.f0_0): super(0);
    @override
    bool operator ==(Object other) => (other is US7_US7_0) && (other.f0_0 == f0_0);
    @override
    int get hashCode => util.combineHashCodes([tag.hashCode, f0_0.hashCode]);
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
    final US0 f0_0;
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

bool UH0__get_IsUH0_0(UH0 this$, void unitArg) {
    if (this$.tag == /* UH0_0 */ 0) {
        return true;
    } else {
        return false;
    }
}

bool UH0__get_IsUH0_1(UH0 this$, void unitArg) {
    if (this$.tag == /* UH0_1 */ 1) {
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

bool closure0(void unitVar, void unitVar_1) {
    types.Some<bool>? _v0;
    _v0 = const types.Some(false);
    return types.value(_v0);
}

String closure1(void unitVar, void unitVar_1) {
    types.Some<bool>? _v0;
    _v0 = const types.Some(false);
    if (types.value(_v0)) {
        return '.exe';
    } else {
        return '';
    }
}

types.Tuple2<String, String> method0() => const types.Tuple2('', '');

UH0 closure4(int v0_1, UH0 v1_1) => UH0_UH0_1(v0_1, v1_1);

UH0 Function(UH0) closure3(void unitVar, int v0_1) => (UH0 v) => closure4(v0_1, v);

UH0 Function(UH0) Function(int) method1() => (int v) => closure3(util.ignore(), v);

types.Tuple2<String, String> method2(String v0_1_mut, String v1_1_mut, UH0 v2_1_mut, US1 v3_1_mut) {
    method2:
    while (true) {
        final v0_1 = v0_1_mut;
        final v1_1 = v1_1_mut;
        final UH0 v2_1 = v2_1_mut;
        final US1 v3_1 = v3_1_mut;
        if (v2_1.tag == /* UH0_1 */ 1) {
            final v2_1_1 = v2_1 as UH0_UH0_1;
            final UH0 v5 = v2_1_1.Item2;
            final v4 = v2_1_1.Item1;
            if (34 == v4) {
                if (v1_1 == '') {
                    v0_1_mut = v0_1;
                    v1_1_mut = v1_1;
                    v2_1_mut = v5;
                    v3_1_mut = const US1_US1_1(US2(/* US2_0 */ 0));
                    continue method2;
                } else {
                    switch (v3_1.tag) {
                        case 1:
                            final v3_1_1 = v3_1 as US1_US1_1;
                            if (v3_1_1.f1_0.tag == /* US2_0 */ 0) {
                                v0_1_mut = v0_1;
                                v1_1_mut = v1_1;
                                v2_1_mut = v5;
                                v3_1_mut = const US1_US1_1(US2(/* US2_1 */ 1));
                                continue method2;
                            } else if (32 == v4) {
                                v0_1_mut = v0_1;
                                v1_1_mut = v1_1;
                                v2_1_mut = v5;
                                v3_1_mut = const US1(/* US1_2 */ 2);
                                continue method2;
                            } else {
                                v0_1_mut = v0_1;
                                v1_1_mut = '$v1_1$v4';
                                v2_1_mut = v5;
                                v3_1_mut = v3_1;
                                continue method2;
                            }
                        case 0:
                            if (32 == v4) {
                                v0_1_mut = v0_1;
                                v1_1_mut = v1_1;
                                v2_1_mut = v5;
                                v3_1_mut = const US1(/* US1_2 */ 2);
                                continue method2;
                            } else {
                                v0_1_mut = v0_1;
                                v1_1_mut = '$v1_1$v4';
                                v2_1_mut = v5;
                                v3_1_mut = v3_1;
                                continue method2;
                            }
                        default:
                            v0_1_mut = '$v0_1$v4';
                            v1_1_mut = v1_1;
                            v2_1_mut = v5;
                            v3_1_mut = const US1(/* US1_2 */ 2);
                            continue method2;
                    }
                }
            } else if (39 == v4) {
                if (v1_1 == '') {
                    v0_1_mut = v0_1;
                    v1_1_mut = v1_1;
                    v2_1_mut = v5;
                    v3_1_mut = const US1_US1_1(US2(/* US2_0 */ 0));
                    continue method2;
                } else {
                    switch (v3_1.tag) {
                        case 1:
                            final v3_1_2 = v3_1 as US1_US1_1;
                            if (v3_1_2.f1_0.tag == /* US2_0 */ 0) {
                                v0_1_mut = v0_1;
                                v1_1_mut = v1_1;
                                v2_1_mut = v5;
                                v3_1_mut = const US1_US1_1(US2(/* US2_1 */ 1));
                                continue method2;
                            } else if (32 == v4) {
                                v0_1_mut = v0_1;
                                v1_1_mut = v1_1;
                                v2_1_mut = v5;
                                v3_1_mut = const US1(/* US1_2 */ 2);
                                continue method2;
                            } else {
                                v0_1_mut = v0_1;
                                v1_1_mut = '$v1_1$v4';
                                v2_1_mut = v5;
                                v3_1_mut = v3_1;
                                continue method2;
                            }
                        case 0:
                            if (32 == v4) {
                                v0_1_mut = v0_1;
                                v1_1_mut = v1_1;
                                v2_1_mut = v5;
                                v3_1_mut = const US1(/* US1_2 */ 2);
                                continue method2;
                            } else {
                                v0_1_mut = v0_1;
                                v1_1_mut = '$v1_1$v4';
                                v2_1_mut = v5;
                                v3_1_mut = v3_1;
                                continue method2;
                            }
                        default:
                            v0_1_mut = '$v0_1$v4';
                            v1_1_mut = v1_1;
                            v2_1_mut = v5;
                            v3_1_mut = const US1(/* US1_2 */ 2);
                            continue method2;
                    }
                }
            } else {
                switch (v3_1.tag) {
                    case 1:
                        final v3_1_3 = v3_1 as US1_US1_1;
                        if (v3_1_3.f1_0.tag == /* US2_0 */ 0) {
                            if (32 == v4) {
                                v0_1_mut = v0_1;
                                v1_1_mut = '$v1_1 ';
                                v2_1_mut = v5;
                                v3_1_mut = const US1_US1_1(US2(/* US2_0 */ 0));
                                continue method2;
                            } else {
                                v0_1_mut = v0_1;
                                v1_1_mut = '$v1_1$v4';
                                v2_1_mut = v5;
                                v3_1_mut = v3_1;
                                continue method2;
                            }
                        } else if (32 == v4) {
                            v0_1_mut = v0_1;
                            v1_1_mut = v1_1;
                            v2_1_mut = v5;
                            v3_1_mut = const US1(/* US1_2 */ 2);
                            continue method2;
                        } else {
                            v0_1_mut = v0_1;
                            v1_1_mut = '$v1_1$v4';
                            v2_1_mut = v5;
                            v3_1_mut = v3_1;
                            continue method2;
                        }
                    case 0:
                        if (32 == v4) {
                            v0_1_mut = v0_1;
                            v1_1_mut = v1_1;
                            v2_1_mut = v5;
                            v3_1_mut = const US1(/* US1_2 */ 2);
                            continue method2;
                        } else {
                            v0_1_mut = v0_1;
                            v1_1_mut = '$v1_1$v4';
                            v2_1_mut = v5;
                            v3_1_mut = v3_1;
                            continue method2;
                        }
                    default:
                        v0_1_mut = '$v0_1$v4';
                        v1_1_mut = v1_1;
                        v2_1_mut = v5;
                        v3_1_mut = const US1(/* US1_2 */ 2);
                        continue method2;
                }
            }
        } else {
            switch (v3_1.tag) {
                case 1:
                    final v3_1_4 = v3_1 as US1_US1_1;
                    if (v3_1_4.f1_0.tag == /* US2_0 */ 0) {
                        return types.Tuple2(v1_1.replaceAll('\\', '/'), v0_1);
                    } else {
                        return types.Tuple2(v1_1.replaceAll('\\', '/'), v0_1);
                    }
                case 0:
                    return types.Tuple2(v1_1.replaceAll('\\', '/'), v0_1);
                default:
                    return types.Tuple2(v1_1.replaceAll('\\', '/'), v0_1);
            }
        }
    }
}

US3 closure5(void unitVar, String v0_1) => US3_US3_0(v0_1);

US3 Function(String) method3() => (String v) => closure5(util.ignore(), v);

String closure6(types.Some<CancellationToken>? v0_1, String v1_1, types.Some<Async<void> Function(types.Tuple3<bool, String, int>)>? v2_1, types.Some<US0>? v3_1, types.Some<String>? v4, void unitVar) => string.toText(string.interpolate('execute_with_options_async / options: %A%P()', [types.Tuple5(v0_1, v1_1, v2_1, v3_1, v4)]));

String closure7(void unitVar, void unitVar_1) => '';

String Function() method4() => () => closure7(util.ignore(), util.ignore());

types.Some<int>? method6(types.Some<int>? v0_1) => v0_1;

types.Some<int>? method7(types.Some<int>? v0_1) => v0_1;

types.Tuple5<Mut0, Mut1, Mut1, Mut2, types.Some<int>?> closure8(void unitVar, void unitVar_1) {
    final v0_1 = Mut1(true);
    final v1_1 = Mut0(0);
    final v3_1 = Mut2(const US0(/* US0_0 */ 0));
    final v4 = Mut1(false);
    types.Some<types.Some<int>?>? _v5;
    final types.Some<int>? x = method7(null);
    _v5 = types.Some(x);
    return types.Tuple5(v1_1, v4, v0_1, v3_1, types.value(_v5));
}

US5 closure10(void unitVar, int v0_1) => US5_US5_0(v0_1);

US5 Function(int) method8() => (int v) => closure10(util.ignore(), v);

String method9() => '';

String closure9(US0 v0_1, String Function() v1_1, String Function() v2_1, void unitVar) {
    if (State_trace_state == null) {
        State_trace_state = types.Some(closure8(util.ignore(), util.ignore()));
    }
    final patternInput = types.value(State_trace_state);
    types.Some<String>? _v9;
    _v9 = const types.Some('');
    final v60 = types.value(_v9);
    final v61 = patternInput.item1.l0;
    late final String v71;
    switch (v0_1.tag) {
        case 1:
            v71 = 'Debug';
            break;
        case 2:
            v71 = 'Info';
            break;
        case 0:
            v71 = 'Verbose';
            break;
        case 3:
            v71 = 'Warning';
            break;
        default:
            v71 = 'Critical';
    }
    return string.trimEnd(string.trimStart('$v60 #$v61 [${v71.toLowerCase()}] ${v1_1()} / ${v2_1()}', <int>[]), [32, 47]);
}

void method5(US0 v0_1, String Function() v1_1, String Function() v2_1) {
    types.Tuple5<Mut0, Mut1, Mut1, Mut2, types.Some<int>?> v3_1() => closure8(util.ignore(), util.ignore());
    if (State_trace_state == null) {
        State_trace_state = types.Some(v3_1());
    }
    final v4 = types.value(State_trace_state).item1;
    if (State_trace_state == null) {
        State_trace_state = types.Some(v3_1());
    }
    final patternInput_1 = types.value(State_trace_state);
    final US0 v14 = patternInput_1.item4.l0;
    if (patternInput_1.item3.l0 && (v0_1.compareTo(v14) >= 0)) {
        final v19 = v4.l0 + 1;
        v4.l0 = v19;
        final v21 = '${closure9(v0_1, v1_1, v2_1, util.ignore())}';
        types.Some<void>? _v22;
        null;
        _v22 = types.Some(util.ignore());
        types.value(_v22);
    }
}

US6 closure12(void unitVar, Async<void> Function(types.Tuple3<bool, String, int>) v0_1) => US6_US6_0(v0_1);

US6 Function(Async<void> Function(types.Tuple3<bool, String, int>)) method10() => (Async<void> Function(types.Tuple3<bool, String, int>) v) => closure12(util.ignore(), v);

String closure13(String v0_1, void unitVar) => '> $v0_1';

void closure11(types.Some<CancellationToken>? v0_1, String v1_1, types.Some<Async<void> Function(types.Tuple3<bool, String, int>)>? v2_1, types.Some<US0>? v3_1, types.Some<String>? v4, void v5, ConcurrentStack<String> v6, void v7) {
    types.Some<Async<void>>? _v8;
    _v8 = const types.Some(null);
    final v32 = types.value(_v8);
    types.Some<void>? _v33;
    null;
    _v33 = types.Some(util.ignore());
    types.value(_v33);
}

void closure14(types.Some<CancellationToken>? v0_1, String v1_1, types.Some<Async<void> Function(types.Tuple3<bool, String, int>)>? v2_1, types.Some<US0>? v3_1, types.Some<String>? v4, void v5, ConcurrentStack<String> v6, void v7) {
    types.Some<Async<void>>? _v8;
    _v8 = const types.Some(null);
    final v33 = types.value(_v8);
    types.Some<void>? _v34;
    null;
    _v34 = types.Some(util.ignore());
    types.value(_v34);
}

US7 closure15(void unitVar, CancellationToken v0_1) => US7_US7_0(v0_1);

US7 Function(CancellationToken) method11() => (CancellationToken v) => closure15(util.ignore(), v);

void closure16(void v0_1, void unitVar) {
    types.Some<bool>? _v1;
    _v1 = const types.Some(false);
    if (types.value(_v1) == false) {
        types.Some<void>? _v10;
        null;
        _v10 = types.Some(util.ignore());
        types.value(_v10);
    }
}

String closure17(dynamic v0_1, void unitVar) => string.toText(string.interpolate('execute_with_options_async / WaitForExitAsync / ex: %A%P()', [v0_1]));

String method12() => '\n';

String closure18(int v0_1, String v1_1, void unitVar) => 'execute_with_options_async / exit_code: $v0_1 / output.Length: ${v1_1.length}';

US8 closure19(void unitVar, US0 v0_1) => US8_US8_0(v0_1);

US8 Function(US0) method13() => (US0 v) => closure19(util.ignore(), v);

Async<types.Tuple2<int, String>> closure2(void unitVar, String v0_1) {
    types.Some<Async<types.Tuple2<int, String>>>? _v5;
    _v5 = const types.Some(null);
    return types.value(_v5);
}

Async<types.Tuple2<int, String>> closure20(void unitVar, types.Tuple5<types.Some<CancellationToken>?, String, types.Some<Async<void> Function(types.Tuple3<bool, String, int>)>?, types.Some<US0>?, types.Some<String>?> _arg) {
    types.Some<Async<types.Tuple2<int, String>>>? _v5;
    _v5 = const types.Some(null);
    return types.value(_v5);
}

bool v0() => closure0(util.ignore(), util.ignore());

bool is_windows() => v0();

String v1() => closure1(util.ignore(), util.ignore());

String get_executable_suffix() => v1();

Async<types.Tuple2<int, String>> v2(String v) => closure2(util.ignore(), v);

Async<types.Tuple2<int, String>> execute_async(String x) => v2(x);

Async<types.Tuple2<int, String>> v3(types.Tuple5<types.Some<CancellationToken>?, String, types.Some<Async<void> Function(types.Tuple3<bool, String, int>)>?, types.Some<US0>?, types.Some<String>?> arg10$0040) => closure20(util.ignore(), arg10$0040);

Async<types.Tuple2<int, String>> execute_with_options_async(types.Tuple5<types.Some<CancellationToken>?, String, types.Some<Async<void> Function(types.Tuple3<bool, String, int>)>?, types.Some<US0>?, types.Some<String>?> x) => v3(x);

