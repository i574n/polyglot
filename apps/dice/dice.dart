// ignore_for_file: camel_case_types, constant_identifier_names, non_constant_identifier_names, unnecessary_this
import './fable_modules/fable_library/Types.dart' as types;
import './fable_modules/fable_library/Util.dart' as util;

class UH0 implements types.Union {
    final int tag;
    const UH0(this.tag);
}

class UH0_UH0_0 extends UH0 {
    final int Item1;
    final UH0 Function() Item2;
    const UH0_UH0_0(this.Item1, this.Item2): super(0);
}

class UH1 implements types.Union, Comparable<UH1> {
    final int tag;
    const UH1(this.tag);
    @override
    bool operator ==(Object other) => (other is UH1) && (other.tag == tag);
    @override
    int get hashCode => tag.hashCode;
    @override
    int compareTo(UH1 other) => tag.compareTo(other.tag);
}

class UH1_UH1_0 extends UH1 {
    final int Item1;
    final UH1 Item2;
    const UH1_UH1_0(this.Item1, this.Item2): super(0);
    @override
    bool operator ==(Object other) => (other is UH1_UH1_0) && ((other.Item1 == Item1) && (other.Item2 == Item2));
    @override
    int get hashCode => util.combineHashCodes([tag.hashCode, Item1.hashCode, Item2.hashCode]);
    @override
    int compareTo(UH1 other) {
        if (other is UH1_UH1_0) {
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

abstract class US0 implements types.Union {
    final int tag;
    const US0(this.tag);
}

class US0_US0_0 extends US0 {
    final UH0 f0_0;
    const US0_US0_0(this.f0_0): super(0);
}

class US0_US0_1 extends US0 {
    final UH0 Function() f1_0;
    const US0_US0_1(this.f1_0): super(1);
}

class Mut0 implements types.Record {
    US0 l0;
    Mut0(this.l0);
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
    final int f1_0;
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

class US2 implements types.Union {
    final int tag;
    const US2(this.tag);
}

class US2_US2_1 extends US2 {
    final void Function(String) f1_0;
    const US2_US2_1(this.f1_0): super(1);
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

class US3_US3_1 extends US3 {
    final int f1_0;
    final UH1 f1_1;
    const US3_US3_1(this.f1_0, this.f1_1): super(1);
    @override
    bool operator ==(Object other) => (other is US3_US3_1) && ((other.f1_0 == f1_0) && (other.f1_1 == f1_1));
    @override
    int get hashCode => util.combineHashCodes([tag.hashCode, f1_0.hashCode, f1_1.hashCode]);
    @override
    int compareTo(US3 other) {
        if (other is US3_US3_1) {
            late int $r;
            if (($r = f1_0.compareTo(other.f1_0)) == 0) {
                $r = f1_1.compareTo(other.f1_1);
            }
            return $r;
        } else {
            return tag.compareTo(other.tag);
        }
    }
}

UH0 closure2(UH0 v0, void unitVar) => v0;

UH0 method1(int v0, UH0 v1, UH0 v2) {
    if (v1.tag == /* UH0_1 */ 1) {
        return v2;
    } else {
        final v1_1 = v1 as UH0_UH0_0;
        final UH0 v6 = method1(v0, v1_1.Item2(), v2);
        final v8 = (v1_1.Item1 - 1) + v0;
        return UH0_UH0_0(v8.remainder(v0) + 1, () => closure2(v6, util.ignore()));
    }
}

UH0 closure1(int v0, UH0 v1) => method1(v0, v1, const UH0(/* UH0_1 */ 1));

UH0 Function(UH0) closure0(void unitVar, int v0) => (UH0 v) => closure1(v0, v);

UH1 method2(UH1 v0_mut, UH1 v1_mut) {
    method2:
    while (true) {
        final UH1 v0 = v0_mut;
        final UH1 v1 = v1_mut;
        if (v0.tag == /* UH1_1 */ 1) {
            return v1;
        } else {
            final v0_1 = v0 as UH1_UH1_0;
            v0_mut = v0_1.Item2;
            v1_mut = UH1_UH1_0(v0_1.Item1, v1);
            continue method2;
        }
    }
}

UH1 method3(UH1 v0, UH1 v1) {
    if (v0.tag == /* UH1_1 */ 1) {
        return v1;
    } else {
        final v0_1 = v0 as UH1_UH1_0;
        return UH1_UH1_0(v0_1.Item1, method3(v0_1.Item2, v1));
    }
}

UH0 closure4(UH0 v0, void unitVar) => v0;

UH0 method4(UH1 v0, UH0 v1) {
    if (v0.tag == /* UH1_1 */ 1) {
        return v1;
    } else {
        final v0_1 = v0 as UH1_UH1_0;
        final UH0 v4 = method4(v0_1.Item2, v1);
        return UH0_UH0_0(v0_1.Item1, () => closure4(v4, util.ignore()));
    }
}

UH0 closure5(UH0 v0, void unitVar) => v0;

UH0 closure6(UH0 v0, Mut0 v1, void unitVar) {
    final US0 v2 = v1.l0;
    if (v2.tag == /* US0_1 */ 1) {
        final v2_1 = v2 as US0_US0_1;
        final UH0 v5 = v2_1.f1_0();
        late final UH0 v12;
        if (v5.tag == /* UH0_1 */ 1) {
            v12 = const UH0(/* UH0_1 */ 1);
        } else {
            final v5_1 = v5 as UH0_UH0_0;
            v12 = UH0_UH0_0(v5_1.Item1, method5(v0, v5_1.Item2));
        }
        v1.l0 = US0_US0_0(v12);
        return v12;
    } else {
        final v2_2 = v2 as US0_US0_0;
        return v2_2.f0_0;
    }
}

UH0 Function() method5(UH0 v0, UH0 Function() v1) {
    final v3 = Mut0(US0_US0_1(v1));
    return () => closure6(v0, v3, util.ignore());
}

US1 method7(int v0_mut, UH0 v1_mut) {
    method7:
    while (true) {
        final v0 = v0_mut;
        final UH0 v1 = v1_mut;
        if (v1.tag == /* UH0_1 */ 1) {
            return const US1(/* US1_0 */ 0);
        } else if (v0 <= 0) {
            final v1_1 = v1 as UH0_UH0_0;
            return US1_US1_1(v1_1.Item1);
        } else {
            v0_mut = v0 - 1;
            final v1_2 = v1 as UH0_UH0_0;
            v1_mut = v1_2.Item2();
            continue method7;
        }
    }
}

int method6(UH0 Function() v0_mut, Mut1 v1_mut, Mut1 v2_mut, Mut1 v3_mut) {
    method6:
    while (true) {
        final v0 = v0_mut;
        final v1 = v1_mut;
        final v2 = v2_mut;
        final v3 = v3_mut;
        final UH0 v4 = v0();
        final US1 v6 = method7(v1.l0, v4);
        if (v6.tag == /* US1_1 */ 1) {
            final v9 = v1.l0 + 1;
            v1.l0 = v9;
            final v6_1 = v6 as US1_US1_1;
            return v6_1.f1_0;
        } else {
            if (v3.l0 == (-1)) {
                final v12 = v1.l0;
                v3.l0 = v12;
            }
            final v18 = (v2.l0 >= v3.l0) ? 1 : (v2.l0 + 1);
            v2.l0 = v18;
            final v20 = v2.l0 - 1;
            v1.l0 = v20;
            v0_mut = v0;
            v1_mut = v1;
            v2_mut = v2;
            v3_mut = v3;
            continue method6;
        }
    }
}

int closure7(UH0 Function() v0, Mut1 v1, Mut1 v2, Mut1 v3, void unitVar) => method6(v0, v1, v2, v3);

int Function() closure3(void unitVar, UH1 v0) {
    final UH0 v5 = method4(method3(v0, method2(v0, const UH1(/* UH1_1 */ 1))), const UH0(/* UH0_1 */ 1));
    final v7 = method5(v5, () => closure5(v5, util.ignore()));
    final v8 = Mut1(0);
    final v9 = Mut1(1);
    final v10 = Mut1(-1);
    return () => closure7(v7, v8, v9, v10, util.ignore());
}

int method8(US2 v0_mut, int v1_mut, int v2_mut, int v3_mut) {
    method8:
    while (true) {
        final US2 v0 = v0_mut;
        final v1 = v1_mut;
        final v2 = v2_mut;
        final v3 = v3_mut;
        if ((v3 > 0) && (v3 < v1)) {
            v0_mut = v0;
            v1_mut = v1;
            v2_mut = v2 + 1;
            v3_mut = v3 * 6;
            continue method8;
        } else {
            final v10 = 'calculate_dice_count / max: $v1 / n: $v2 / p: $v3';
            if (v0.tag == /* US2_1 */ 1) {
                final v0_1 = v0 as US2_US2_1;
                v0_1.f1_0(v10);
            }
            return v2;
        }
    }
}

UH0 closure75(void unitVar, void unitVar_1) => UH0_UH0_0(0, () => closure75(util.ignore(), util.ignore()));

UH0 closure74(void unitVar, void unitVar_1) => UH0_UH0_0(-9223372036854775808, () => closure75(util.ignore(), util.ignore()));

UH0 closure73(void unitVar, void unitVar_1) => UH0_UH0_0(4611686018427387904, () => closure74(util.ignore(), util.ignore()));

UH0 closure72(void unitVar, void unitVar_1) => UH0_UH0_0(6917529027641081856, () => closure73(util.ignore(), util.ignore()));

UH0 closure71(void unitVar, void unitVar_1) => UH0_UH0_0(1152921504606846976, () => closure72(util.ignore(), util.ignore()));

UH0 closure70(void unitVar, void unitVar_1) => UH0_UH0_0(-2882303761517117440, () => closure71(util.ignore(), util.ignore()));

UH0 closure69(void unitVar, void unitVar_1) => UH0_UH0_0(-6629298651489370112, () => closure70(util.ignore(), util.ignore()));

UH0 closure68(void unitVar, void unitVar_1) => UH0_UH0_0(5044031582654955520, () => closure69(util.ignore(), util.ignore()));

UH0 closure67(void unitVar, void unitVar_1) => UH0_UH0_0(6989586621679009792, () => closure68(util.ignore(), util.ignore()));

UH0 closure66(void unitVar, void unitVar_1) => UH0_UH0_0(-1909526242005090304, () => closure67(util.ignore(), util.ignore()));

UH0 closure65(void unitVar, void unitVar_1) => UH0_UH0_0(-6467169064904032256, () => closure66(util.ignore(), util.ignore()));

UH0 closure64(void unitVar, void unitVar_1) => UH0_UH0_0(-4152318856435597312, () => closure65(util.ignore(), util.ignore()));

UH0 closure63(void unitVar, void unitVar_1) => UH0_UH0_0(2382404202878992384, () => closure64(util.ignore(), util.ignore()));

UH0 closure62(void unitVar, void unitVar_1) => UH0_UH0_0(6545982058383015936, () => closure63(util.ignore(), util.ignore()));

UH0 closure61(void unitVar, void unitVar_1) => UH0_UH0_0(-8132375027124273152, () => closure62(util.ignore(), util.ignore()));

UH0 closure60(void unitVar, void unitVar_1) => UH0_UH0_0(4793518853382471680, () => closure61(util.ignore(), util.ignore()));

UH0 closure59(void unitVar, void unitVar_1) => UH0_UH0_0(3873377154515337216, () => closure60(util.ignore(), util.ignore()));

UH0 closure58(void unitVar, void unitVar_1) => UH0_UH0_0(645562859085889536, () => closure59(util.ignore(), util.ignore()));

UH0 closure57(void unitVar, void unitVar_1) => UH0_UH0_0(107593809847648256, () => closure58(util.ignore(), util.ignore()));

UH0 closure56(void unitVar, void unitVar_1) => UH0_UH0_0(3092389647259533312, () => closure57(util.ignore(), util.ignore()));

UH0 closure55(void unitVar, void unitVar_1) => UH0_UH0_0(-8707973762311520256, () => closure56(util.ignore(), util.ignore()));

UH0 closure54(void unitVar, void unitVar_1) => UH0_UH0_0(-1451328960385253376, () => closure55(util.ignore(), util.ignore()));

UH0 closure53(void unitVar, void unitVar_1) => UH0_UH0_0(8981483876790566912, () => closure54(util.ignore(), util.ignore()));

UH0 closure52(void unitVar, void unitVar_1) => UH0_UH0_0(-4652000711771422720, () => closure53(util.ignore(), util.ignore()));

UH0 closure51(void unitVar, void unitVar_1) => UH0_UH0_0(2299123893656354816, () => closure52(util.ignore(), util.ignore()));

UH0 closure50(void unitVar, void unitVar_1) => UH0_UH0_0(3457644661227651072, () => closure51(util.ignore(), util.ignore()));

UH0 closure49(void unitVar, void unitVar_1) => UH0_UH0_0(576274110204608512, () => closure50(util.ignore(), util.ignore()));

UH0 closure48(void unitVar, void unitVar_1) => UH0_UH0_0(6244960376270618624, () => closure49(util.ignore(), util.ignore()));

UH0 closure47(void unitVar, void unitVar_1) => UH0_UH0_0(-5108087961858080768, () => closure48(util.ignore(), util.ignore()));

UH0 closure46(void unitVar, void unitVar_1) => UH0_UH0_0(-3925805339261272064, () => closure47(util.ignore(), util.ignore()));

UH0 closure45(void unitVar, void unitVar_1) => UH0_UH0_0(-3728758235495137280, () => closure46(util.ignore(), util.ignore()));

UH0 closure44(void unitVar, void unitVar_1) => UH0_UH0_0(5527454985320660992, () => closure45(util.ignore(), util.ignore()));

UH0 closure43(void unitVar, void unitVar_1) => UH0_UH0_0(-2153214848064815104, () => closure44(util.ignore(), util.ignore()));

UH0 closure42(void unitVar, void unitVar_1) => UH0_UH0_0(-6507783832580653056, () => closure43(util.ignore(), util.ignore()));

UH0 closure41(void unitVar, void unitVar_1) => UH0_UH0_0(8138741398091333632, () => closure42(util.ignore(), util.ignore()));

UH0 closure40(void unitVar, void unitVar_1) => UH0_UH0_0(7505371590918406144, () => closure41(util.ignore(), util.ignore()));

UH0 closure39(void unitVar, void unitVar_1) => UH0_UH0_0(-1823562080465190912, () => closure40(util.ignore(), util.ignore()));

UH0 closure38(void unitVar, void unitVar_1) => UH0_UH0_0(8919445023443910656, () => closure39(util.ignore(), util.ignore()));

UH0 closure37(void unitVar, void unitVar_1) => UH0_UH0_0(4561031516192243712, () => closure38(util.ignore(), util.ignore()));

UH0 closure36(void unitVar, void unitVar_1) => UH0_UH0_0(-8463200117489401856, () => closure37(util.ignore(), util.ignore()));

UH0 closure35(void unitVar, void unitVar_1) => UH0_UH0_0(4738381338321616896, () => closure36(util.ignore(), util.ignore()));

UH0 closure34(void unitVar, void unitVar_1) => UH0_UH0_0(789730223053602816, () => closure35(util.ignore(), util.ignore()));

UH0 closure33(void unitVar, void unitVar_1) => UH0_UH0_0(131621703842267136, () => closure34(util.ignore(), util.ignore()));

UH0 closure32(void unitVar, void unitVar_1) => UH0_UH0_0(21936950640377856, () => closure33(util.ignore(), util.ignore()));

UH0 closure31(void unitVar, void unitVar_1) => UH0_UH0_0(3656158440062976, () => closure32(util.ignore(), util.ignore()));

UH0 closure30(void unitVar, void unitVar_1) => UH0_UH0_0(609359740010496, () => closure31(util.ignore(), util.ignore()));

UH0 closure29(void unitVar, void unitVar_1) => UH0_UH0_0(101559956668416, () => closure30(util.ignore(), util.ignore()));

UH0 closure28(void unitVar, void unitVar_1) => UH0_UH0_0(16926659444736, () => closure29(util.ignore(), util.ignore()));

UH0 closure27(void unitVar, void unitVar_1) => UH0_UH0_0(2821109907456, () => closure28(util.ignore(), util.ignore()));

UH0 closure26(void unitVar, void unitVar_1) => UH0_UH0_0(470184984576, () => closure27(util.ignore(), util.ignore()));

UH0 closure25(void unitVar, void unitVar_1) => UH0_UH0_0(78364164096, () => closure26(util.ignore(), util.ignore()));

UH0 closure24(void unitVar, void unitVar_1) => UH0_UH0_0(13060694016, () => closure25(util.ignore(), util.ignore()));

UH0 closure23(void unitVar, void unitVar_1) => UH0_UH0_0(2176782336, () => closure24(util.ignore(), util.ignore()));

UH0 closure22(void unitVar, void unitVar_1) => UH0_UH0_0(362797056, () => closure23(util.ignore(), util.ignore()));

UH0 closure21(void unitVar, void unitVar_1) => UH0_UH0_0(60466176, () => closure22(util.ignore(), util.ignore()));

UH0 closure20(void unitVar, void unitVar_1) => UH0_UH0_0(10077696, () => closure21(util.ignore(), util.ignore()));

UH0 closure19(void unitVar, void unitVar_1) => UH0_UH0_0(1679616, () => closure20(util.ignore(), util.ignore()));

UH0 closure18(void unitVar, void unitVar_1) => UH0_UH0_0(279936, () => closure19(util.ignore(), util.ignore()));

UH0 closure17(void unitVar, void unitVar_1) => UH0_UH0_0(46656, () => closure18(util.ignore(), util.ignore()));

UH0 closure16(void unitVar, void unitVar_1) => UH0_UH0_0(7776, () => closure17(util.ignore(), util.ignore()));

UH0 closure15(void unitVar, void unitVar_1) => UH0_UH0_0(1296, () => closure16(util.ignore(), util.ignore()));

UH0 closure14(void unitVar, void unitVar_1) => UH0_UH0_0(216, () => closure15(util.ignore(), util.ignore()));

UH0 closure13(void unitVar, void unitVar_1) => UH0_UH0_0(36, () => closure14(util.ignore(), util.ignore()));

UH0 closure12(void unitVar, void unitVar_1) => UH0_UH0_0(6, () => closure13(util.ignore(), util.ignore()));

US1 method11(int v0_mut, UH0 v1_mut) {
    method11:
    while (true) {
        final v0 = v0_mut;
        final UH0 v1 = v1_mut;
        if (v1.tag == /* UH0_1 */ 1) {
            return const US1(/* US1_0 */ 0);
        } else if (v0 <= 0) {
            final v1_1 = v1 as UH0_UH0_0;
            return US1_US1_1(v1_1.Item1);
        } else {
            v0_mut = v0 - 1;
            final v1_2 = v1 as UH0_UH0_0;
            v1_mut = v1_2.Item2();
            continue method11;
        }
    }
}

US3 method10(US2 v0_mut, int v1_mut, UH1 v2_mut, int v3_mut) {
    method10:
    while (true) {
        final US2 v0 = v0_mut;
        final v1 = v1_mut;
        final UH1 v2 = v2_mut;
        final v3 = v3_mut;
        if (v1 < 0) {
            final v5 = 'accumulate_dice_rolls / power: $v1 / acc: $v3';
            if (v0.tag == /* US2_1 */ 1) {
                final v0_1 = v0 as US2_US2_1;
                v0_1.f1_0(v5);
            }
            return US3_US3_1(v3 + 1, v2);
        } else if (v2.tag == /* UH1_1 */ 1) {
            return const US3(/* US3_0 */ 0);
        } else {
            final v2_1 = v2 as UH1_UH1_0;
            final UH1 v11 = v2_1.Item2;
            final v10 = v2_1.Item1;
            if (v10 > 1) {
                final US1 v16 = method11(v1, UH0_UH0_0(1, () => closure12(util.ignore(), util.ignore())));
                final tmp_combine = v10 - 1;
                late final int tmp_capture;
                if (v16.tag == /* US1_1 */ 1) {
                    final v16_1 = v16 as US1_US1_1;
                    tmp_capture = v16_1.f1_0;
                } else {
                    tmp_capture = throw Exception('Option does not have a value.');
                }
                final v22 = tmp_combine * tmp_capture;
                final v23 = 'accumulate_dice_rolls / power: $v1 / acc: $v3 / roll: $v10 / value: $v22';
                if (v0.tag == /* US2_1 */ 1) {
                    final v0_2 = v0 as US2_US2_1;
                    v0_2.f1_0(v23);
                }
                v0_mut = v0;
                v1_mut = v1 - 1;
                v2_mut = v11;
                v3_mut = v3 + v22;
                continue method10;
            } else {
                final v28 = 'accumulate_dice_rolls / power: $v1 / acc: $v3 / roll: $v10';
                if (v0.tag == /* US2_1 */ 1) {
                    final v0_3 = v0 as US2_US2_1;
                    v0_3.f1_0(v28);
                }
                v0_mut = v0;
                v1_mut = v1 - 1;
                v2_mut = v11;
                v3_mut = v3;
                continue method10;
            }
        }
    }
}

UH1 method12(int v0, int Function() v1, int v2) {
    if (v2 < v0) {
        return UH1_UH1_0(v1(), method12(v0, v1, v2 + 1));
    } else {
        return const UH1(/* UH1_1 */ 1);
    }
}

int method13(US2 v0_mut, int Function() v1_mut, bool v2_mut, int v3_mut, int v4_mut, UH1 v5_mut) {
    method13:
    while (true) {
        final US2 v0 = v0_mut;
        final v1 = v1_mut;
        final v2 = v2_mut;
        final v3 = v3_mut;
        final v4 = v4_mut;
        final UH1 v5 = v5_mut;
        final v6 = v4 + 1;
        if (v4 < v6) {
            return method9(v0, v1, v2, v3, v4, UH1_UH1_0(v1(), v5), v6);
        } else {
            final US3 v12 = method10(v0, v4, v5, 0);
            if (v12.tag == /* US3_1 */ 1) {
                final v12_1 = v12 as US3_US3_1;
                final v13 = v12_1.f1_0;
                if (v13 <= v3) {
                    return v13;
                } else if (v2) {
                    v0_mut = v0;
                    v1_mut = v1;
                    v2_mut = v2;
                    v3_mut = v3;
                    v4_mut = v4;
                    v5_mut = method12(v4, v1, 0);
                    continue method13;
                } else {
                    return method9(v0, v1, v2, v3, v4, UH1_UH1_0(v1(), v5), v6);
                }
            } else if (v2) {
                v0_mut = v0;
                v1_mut = v1;
                v2_mut = v2;
                v3_mut = v3;
                v4_mut = v4;
                v5_mut = method12(v4, v1, 0);
                continue method13;
            } else {
                return method9(v0, v1, v2, v3, v4, UH1_UH1_0(v1(), v5), v6);
            }
        }
    }
}

int method9(US2 v0_mut, int Function() v1_mut, bool v2_mut, int v3_mut, int v4_mut, UH1 v5_mut, int v6_mut) {
    method9:
    while (true) {
        final US2 v0 = v0_mut;
        final v1 = v1_mut;
        final v2 = v2_mut;
        final v3 = v3_mut;
        final v4 = v4_mut;
        final UH1 v5 = v5_mut;
        final v6 = v6_mut;
        if (v6 < (v4 + 1)) {
            v0_mut = v0;
            v1_mut = v1;
            v2_mut = v2;
            v3_mut = v3;
            v4_mut = v4;
            v5_mut = UH1_UH1_0(v1(), v5);
            v6_mut = v6 + 1;
            continue method9;
        } else {
            final US3 v14 = method10(v0, v4, v5, 0);
            if (v14.tag == /* US3_1 */ 1) {
                final v14_1 = v14 as US3_US3_1;
                final v15 = v14_1.f1_0;
                if (v15 <= v3) {
                    return v15;
                } else if (v2) {
                    return method13(v0, v1, v2, v3, v4, method12(v4, v1, 0));
                } else {
                    v0_mut = v0;
                    v1_mut = v1;
                    v2_mut = v2;
                    v3_mut = v3;
                    v4_mut = v4;
                    v5_mut = UH1_UH1_0(v1(), v5);
                    v6_mut = v6 + 1;
                    continue method9;
                }
            } else if (v2) {
                return method13(v0, v1, v2, v3, v4, method12(v4, v1, 0));
            } else {
                v0_mut = v0;
                v1_mut = v1;
                v2_mut = v2;
                v3_mut = v3;
                v4_mut = v4;
                v5_mut = UH1_UH1_0(v1(), v5);
                v6_mut = v6 + 1;
                continue method9;
            }
        }
    }
}

int closure11(US2 v0, int Function() v1, bool v2, int v3) => method9(v0, v1, v2, v3, ((v3 == 1) ? 1 : method8(v0, v3, 0, 1)) - 1, const UH1(/* UH1_1 */ 1), 0);

int Function(int) closure10(US2 v0, int Function() v1, bool v2) => (int v) => closure11(v0, v1, v2, v);

int Function(int) Function(bool) closure9(US2 v0, int Function() v1) => (bool v) => closure10(v0, v1, v);

int Function(int) Function(bool) Function(int Function()) closure8(void unitVar, US2 v0) => (int Function() v) => closure9(v0, v);

int method14(UH1 v0_mut, int v1_mut) {
    method14:
    while (true) {
        final UH1 v0 = v0_mut;
        final v1 = v1_mut;
        if (v0.tag == /* UH1_1 */ 1) {
            return v1;
        } else {
            final v0_1 = v0 as UH1_UH1_0;
            v0_mut = v0_1.Item2;
            v1_mut = v1 + 1;
            continue method14;
        }
    }
}

US1 closure78(US2 v0, int v1, UH1 v2) {
    final US3 v7 = method10(v0, method14(v2, 0) - 1, v2, 0);
    if (v7.tag == /* US3_1 */ 1) {
        final v7_1 = v7 as US3_US3_1;
        final v8 = v7_1.f1_0;
        if ((v8 >= 1) && (v8 <= v1)) {
            return US1_US1_1(v8);
        } else {
            return const US1(/* US1_0 */ 0);
        }
    } else {
        return const US1(/* US1_0 */ 0);
    }
}

US1 Function(UH1) closure77(US2 v0, int v1) => (UH1 v) => closure78(v0, v1, v);

US1 Function(UH1) Function(int) closure76(void unitVar, US2 v0) => (int v) => closure77(v0, v);

void method0() {
}

int main(List<String> _args) => 0;

