import { Record, Union } from "./fable_modules/fable-library-ts/Types.js";
import { equals, int64, op_Multiply, toInt64, compare, op_Subtraction, op_Modulus, op_Addition, toUInt64, uint64 } from "./fable_modules/fable-library-ts/BigInt.js";
import { string_type, int32_type, record_type, union_type, lambda_type, unit_type, uint64_type, TypeInfo } from "./fable_modules/fable-library-ts/Reflection.js";
import { int32 } from "./fable_modules/fable-library-ts/Int32.js";
import { IComparable, IEquatable } from "./fable_modules/fable-library-ts/Util.js";

export type UH0_$union = 
    | UH0<0>
    | UH0<1>

export type UH0_$cases = {
    0: ["UH0_0", [uint64, (() => UH0_$union)]],
    1: ["UH0_1", []]
}

export function UH0_UH0_0(Item1: uint64, Item2: (() => UH0_$union)) {
    return new UH0<0>(0, [Item1, Item2]);
}

export function UH0_UH0_1() {
    return new UH0<1>(1, []);
}

export class UH0<Tag extends keyof UH0_$cases> extends Union<Tag, UH0_$cases[Tag][0]> {
    constructor(readonly tag: Tag, readonly fields: UH0_$cases[Tag][1]) {
        super();
    }
    cases() {
        return ["UH0_0", "UH0_1"];
    }
}

export function UH0_$reflection(): TypeInfo {
    return union_type("Dice.UH0", [], UH0, () => [[["Item1", uint64_type], ["Item2", lambda_type(unit_type, UH0_$reflection())]], []]);
}

export type UH1_$union = 
    | UH1<0>
    | UH1<1>

export type UH1_$cases = {
    0: ["UH1_0", [uint64, UH1_$union]],
    1: ["UH1_1", []]
}

export function UH1_UH1_0(Item1: uint64, Item2: UH1_$union) {
    return new UH1<0>(0, [Item1, Item2]);
}

export function UH1_UH1_1() {
    return new UH1<1>(1, []);
}

export class UH1<Tag extends keyof UH1_$cases> extends Union<Tag, UH1_$cases[Tag][0]> {
    constructor(readonly tag: Tag, readonly fields: UH1_$cases[Tag][1]) {
        super();
    }
    cases() {
        return ["UH1_0", "UH1_1"];
    }
}

export function UH1_$reflection(): TypeInfo {
    return union_type("Dice.UH1", [], UH1, () => [[["Item1", uint64_type], ["Item2", UH1_$reflection()]], []]);
}

export type US0_$union = 
    | US0<0>
    | US0<1>

export type US0_$cases = {
    0: ["US0_0", [UH0_$union]],
    1: ["US0_1", [(() => UH0_$union)]]
}

export function US0_US0_0(f0_0: UH0_$union) {
    return new US0<0>(0, [f0_0]);
}

export function US0_US0_1(f1_0: (() => UH0_$union)) {
    return new US0<1>(1, [f1_0]);
}

export class US0<Tag extends keyof US0_$cases> extends Union<Tag, US0_$cases[Tag][0]> {
    constructor(readonly tag: Tag, readonly fields: US0_$cases[Tag][1]) {
        super();
    }
    cases() {
        return ["US0_0", "US0_1"];
    }
}

export function US0_$reflection(): TypeInfo {
    return union_type("Dice.US0", [], US0, () => [[["f0_0", UH0_$reflection()]], [["f1_0", lambda_type(unit_type, UH0_$reflection())]]]);
}

export class Mut0 extends Record {
    l0: US0_$union;
    constructor(l0: US0_$union) {
        super();
        this.l0 = l0;
    }
}

export function Mut0_$reflection(): TypeInfo {
    return record_type("Dice.Mut0", [], Mut0, () => [["l0", US0_$reflection()]]);
}

export class Mut1 extends Record implements IEquatable<Mut1>, IComparable<Mut1> {
    l0: int32;
    constructor(l0: int32) {
        super();
        this.l0 = (l0 | 0);
    }
}

export function Mut1_$reflection(): TypeInfo {
    return record_type("Dice.Mut1", [], Mut1, () => [["l0", int32_type]]);
}

export type US1_$union = 
    | US1<0>
    | US1<1>

export type US1_$cases = {
    0: ["US1_0", []],
    1: ["US1_1", [uint64]]
}

export function US1_US1_0() {
    return new US1<0>(0, []);
}

export function US1_US1_1(f1_0: uint64) {
    return new US1<1>(1, [f1_0]);
}

export class US1<Tag extends keyof US1_$cases> extends Union<Tag, US1_$cases[Tag][0]> {
    constructor(readonly tag: Tag, readonly fields: US1_$cases[Tag][1]) {
        super();
    }
    cases() {
        return ["US1_0", "US1_1"];
    }
}

export function US1_$reflection(): TypeInfo {
    return union_type("Dice.US1", [], US1, () => [[], [["f1_0", uint64_type]]]);
}

export type US2_$union = 
    | US2<0>
    | US2<1>

export type US2_$cases = {
    0: ["US2_0", []],
    1: ["US2_1", [((arg0: string) => void)]]
}

export function US2_US2_0() {
    return new US2<0>(0, []);
}

export function US2_US2_1(f1_0: ((arg0: string) => void)) {
    return new US2<1>(1, [f1_0]);
}

export class US2<Tag extends keyof US2_$cases> extends Union<Tag, US2_$cases[Tag][0]> {
    constructor(readonly tag: Tag, readonly fields: US2_$cases[Tag][1]) {
        super();
    }
    cases() {
        return ["US2_0", "US2_1"];
    }
}

export function US2_$reflection(): TypeInfo {
    return union_type("Dice.US2", [], US2, () => [[], [["f1_0", lambda_type(string_type, unit_type)]]]);
}

export type US3_$union = 
    | US3<0>
    | US3<1>

export type US3_$cases = {
    0: ["US3_0", []],
    1: ["US3_1", [uint64, UH1_$union]]
}

export function US3_US3_0() {
    return new US3<0>(0, []);
}

export function US3_US3_1(f1_0: uint64, f1_1: UH1_$union) {
    return new US3<1>(1, [f1_0, f1_1]);
}

export class US3<Tag extends keyof US3_$cases> extends Union<Tag, US3_$cases[Tag][0]> {
    constructor(readonly tag: Tag, readonly fields: US3_$cases[Tag][1]) {
        super();
    }
    cases() {
        return ["US3_0", "US3_1"];
    }
}

export function US3_$reflection(): TypeInfo {
    return union_type("Dice.US3", [], US3, () => [[], [["f1_0", uint64_type], ["f1_1", UH1_$reflection()]]]);
}

export function closure2(v0: UH0_$union, unitVar: void): UH0_$union {
    return v0;
}

export function method1(v0: uint64, v1: UH0_$union, v2: UH0_$union): UH0_$union {
    if (v1.tag === /* UH0_1 */ 1) {
        return v2;
    }
    else {
        const v3: uint64 = v1.fields[0];
        const v6: UH0_$union = method1(v0, v1.fields[1](), v2);
        return UH0_UH0_0(toUInt64(op_Addition(toUInt64(op_Modulus(toUInt64(op_Addition(toUInt64(op_Subtraction(v3, 1n)), v0)), v0)), 1n)), (): UH0_$union => closure2(v6, void 0));
    }
}

export function closure1(v0: uint64, v1: UH0_$union): UH0_$union {
    return method1(v0, v1, UH0_UH0_1());
}

export function closure0(unitVar: void, v0: uint64): ((arg0: UH0_$union) => UH0_$union) {
    return (v: UH0_$union): UH0_$union => closure1(v0, v);
}

export function method2(v0_mut: UH1_$union, v1_mut: UH1_$union): UH1_$union {
    method2:
    while (true) {
        const v0: UH1_$union = v0_mut, v1: UH1_$union = v1_mut;
        if (v0.tag === /* UH1_1 */ 1) {
            return v1;
        }
        else {
            v0_mut = v0.fields[1];
            v1_mut = UH1_UH1_0(v0.fields[0], v1);
            continue method2;
        }
        break;
    }
}

export function method3(v0: UH1_$union, v1: UH1_$union): UH1_$union {
    if (v0.tag === /* UH1_1 */ 1) {
        return v1;
    }
    else {
        return UH1_UH1_0(v0.fields[0], method3(v0.fields[1], v1));
    }
}

export function closure4(v0: UH0_$union, unitVar: void): UH0_$union {
    return v0;
}

export function method4(v0: UH1_$union, v1: UH0_$union): UH0_$union {
    if (v0.tag === /* UH1_1 */ 1) {
        return v1;
    }
    else {
        const v2: uint64 = v0.fields[0];
        const v4: UH0_$union = method4(v0.fields[1], v1);
        return UH0_UH0_0(v2, (): UH0_$union => closure4(v4, void 0));
    }
}

export function closure5(v0: UH0_$union, unitVar: void): UH0_$union {
    return v0;
}

export function closure6(v0: UH0_$union, v1: Mut0, unitVar: void): UH0_$union {
    const v2: US0_$union = v1.l0;
    if (v2.tag === /* US0_1 */ 1) {
        const v5: UH0_$union = v2.fields[0]();
        const v12: UH0_$union = (v5.tag === /* UH0_1 */ 1) ? UH0_UH0_1() : UH0_UH0_0(v5.fields[0], method5(v0, v5.fields[1]));
        v1.l0 = US0_US0_0(v12);
        return v12;
    }
    else {
        return v2.fields[0];
    }
}

export function method5(v0: UH0_$union, v1: (() => UH0_$union)): (() => UH0_$union) {
    const v3: Mut0 = new Mut0(US0_US0_1(v1));
    return (): UH0_$union => closure6(v0, v3, void 0);
}

export function method7(v0_mut: int32, v1_mut: UH0_$union): US1_$union {
    method7:
    while (true) {
        const v0: int32 = v0_mut, v1: UH0_$union = v1_mut;
        if (v1.tag === /* UH0_1 */ 1) {
            return US1_US1_0();
        }
        else if (v0 <= 0) {
            return US1_US1_1(v1.fields[0]);
        }
        else {
            v0_mut = (v0 - 1);
            v1_mut = v1.fields[1]();
            continue method7;
        }
        break;
    }
}

export function method6(v0_mut: (() => UH0_$union), v1_mut: Mut1, v2_mut: Mut1, v3_mut: Mut1): uint64 {
    method6:
    while (true) {
        const v0: (() => UH0_$union) = v0_mut, v1: Mut1 = v1_mut, v2: Mut1 = v2_mut, v3: Mut1 = v3_mut;
        const v4: UH0_$union = v0();
        const v6: US1_$union = method7(v1.l0, v4);
        if (v6.tag === /* US1_1 */ 1) {
            const v7: uint64 = v6.fields[0];
            const v9: int32 = (v1.l0 + 1) | 0;
            v1.l0 = (v9 | 0);
            return v7;
        }
        else {
            if (v3.l0 === -1) {
                const v12: int32 = v1.l0 | 0;
                v3.l0 = (v12 | 0);
            }
            const v18: int32 = ((v2.l0 >= v3.l0) ? 1 : (v2.l0 + 1)) | 0;
            v2.l0 = (v18 | 0);
            const v20: int32 = (v2.l0 - 1) | 0;
            v1.l0 = (v20 | 0);
            v0_mut = v0;
            v1_mut = v1;
            v2_mut = v2;
            v3_mut = v3;
            continue method6;
        }
        break;
    }
}

export function closure7(v0: (() => UH0_$union), v1: Mut1, v2: Mut1, v3: Mut1, unitVar: void): uint64 {
    return method6(v0, v1, v2, v3);
}

export function closure3(unitVar: void, v0: UH1_$union): (() => uint64) {
    const v5: UH0_$union = method4(method3(v0, method2(v0, UH1_UH1_1())), UH0_UH0_1());
    const v7: (() => UH0_$union) = method5(v5, (): UH0_$union => closure5(v5, void 0));
    const v8: Mut1 = new Mut1(0);
    const v9: Mut1 = new Mut1(1);
    const v10: Mut1 = new Mut1(-1);
    return (): uint64 => closure7(v7, v8, v9, v10, void 0);
}

export function method8(v0_mut: US2_$union, v1_mut: uint64, v2_mut: int64, v3_mut: uint64): int64 {
    method8:
    while (true) {
        const v0: US2_$union = v0_mut, v1: uint64 = v1_mut, v2: int64 = v2_mut, v3: uint64 = v3_mut;
        if ((compare(v3, 0n) > 0) && (compare(v3, v1) < 0)) {
            v0_mut = v0;
            v1_mut = v1;
            v2_mut = toInt64(op_Addition(v2, 1n));
            v3_mut = toUInt64(op_Multiply(v3, 6n));
            continue method8;
        }
        else {
            const v10 = `calculate_dice_count / max: ${v1} / n: ${v2} / p: ${v3}`;
            if (v0.tag === /* US2_1 */ 1) {
                v0.fields[0](v10);
            }
            return v2;
        }
        break;
    }
}

export function closure75(unitVar: void, unitVar_1: void): UH0_$union {
    return UH0_UH0_0(0n, (): UH0_$union => closure75(void 0, void 0));
}

export function closure74(unitVar: void, unitVar_1: void): UH0_$union {
    return UH0_UH0_0(9223372036854775808n, (): UH0_$union => closure75(void 0, void 0));
}

export function closure73(unitVar: void, unitVar_1: void): UH0_$union {
    return UH0_UH0_0(4611686018427387904n, (): UH0_$union => closure74(void 0, void 0));
}

export function closure72(unitVar: void, unitVar_1: void): UH0_$union {
    return UH0_UH0_0(6917529027641081856n, (): UH0_$union => closure73(void 0, void 0));
}

export function closure71(unitVar: void, unitVar_1: void): UH0_$union {
    return UH0_UH0_0(1152921504606846976n, (): UH0_$union => closure72(void 0, void 0));
}

export function closure70(unitVar: void, unitVar_1: void): UH0_$union {
    return UH0_UH0_0(15564440312192434176n, (): UH0_$union => closure71(void 0, void 0));
}

export function closure69(unitVar: void, unitVar_1: void): UH0_$union {
    return UH0_UH0_0(11817445422220181504n, (): UH0_$union => closure70(void 0, void 0));
}

export function closure68(unitVar: void, unitVar_1: void): UH0_$union {
    return UH0_UH0_0(5044031582654955520n, (): UH0_$union => closure69(void 0, void 0));
}

export function closure67(unitVar: void, unitVar_1: void): UH0_$union {
    return UH0_UH0_0(6989586621679009792n, (): UH0_$union => closure68(void 0, void 0));
}

export function closure66(unitVar: void, unitVar_1: void): UH0_$union {
    return UH0_UH0_0(16537217831704461312n, (): UH0_$union => closure67(void 0, void 0));
}

export function closure65(unitVar: void, unitVar_1: void): UH0_$union {
    return UH0_UH0_0(11979575008805519360n, (): UH0_$union => closure66(void 0, void 0));
}

export function closure64(unitVar: void, unitVar_1: void): UH0_$union {
    return UH0_UH0_0(14294425217273954304n, (): UH0_$union => closure65(void 0, void 0));
}

export function closure63(unitVar: void, unitVar_1: void): UH0_$union {
    return UH0_UH0_0(2382404202878992384n, (): UH0_$union => closure64(void 0, void 0));
}

export function closure62(unitVar: void, unitVar_1: void): UH0_$union {
    return UH0_UH0_0(6545982058383015936n, (): UH0_$union => closure63(void 0, void 0));
}

export function closure61(unitVar: void, unitVar_1: void): UH0_$union {
    return UH0_UH0_0(10314369046585278464n, (): UH0_$union => closure62(void 0, void 0));
}

export function closure60(unitVar: void, unitVar_1: void): UH0_$union {
    return UH0_UH0_0(4793518853382471680n, (): UH0_$union => closure61(void 0, void 0));
}

export function closure59(unitVar: void, unitVar_1: void): UH0_$union {
    return UH0_UH0_0(3873377154515337216n, (): UH0_$union => closure60(void 0, void 0));
}

export function closure58(unitVar: void, unitVar_1: void): UH0_$union {
    return UH0_UH0_0(645562859085889536n, (): UH0_$union => closure59(void 0, void 0));
}

export function closure57(unitVar: void, unitVar_1: void): UH0_$union {
    return UH0_UH0_0(107593809847648256n, (): UH0_$union => closure58(void 0, void 0));
}

export function closure56(unitVar: void, unitVar_1: void): UH0_$union {
    return UH0_UH0_0(3092389647259533312n, (): UH0_$union => closure57(void 0, void 0));
}

export function closure55(unitVar: void, unitVar_1: void): UH0_$union {
    return UH0_UH0_0(9738770311398031360n, (): UH0_$union => closure56(void 0, void 0));
}

export function closure54(unitVar: void, unitVar_1: void): UH0_$union {
    return UH0_UH0_0(16995415113324298240n, (): UH0_$union => closure55(void 0, void 0));
}

export function closure53(unitVar: void, unitVar_1: void): UH0_$union {
    return UH0_UH0_0(8981483876790566912n, (): UH0_$union => closure54(void 0, void 0));
}

export function closure52(unitVar: void, unitVar_1: void): UH0_$union {
    return UH0_UH0_0(13794743361938128896n, (): UH0_$union => closure53(void 0, void 0));
}

export function closure51(unitVar: void, unitVar_1: void): UH0_$union {
    return UH0_UH0_0(2299123893656354816n, (): UH0_$union => closure52(void 0, void 0));
}

export function closure50(unitVar: void, unitVar_1: void): UH0_$union {
    return UH0_UH0_0(3457644661227651072n, (): UH0_$union => closure51(void 0, void 0));
}

export function closure49(unitVar: void, unitVar_1: void): UH0_$union {
    return UH0_UH0_0(576274110204608512n, (): UH0_$union => closure50(void 0, void 0));
}

export function closure48(unitVar: void, unitVar_1: void): UH0_$union {
    return UH0_UH0_0(6244960376270618624n, (): UH0_$union => closure49(void 0, void 0));
}

export function closure47(unitVar: void, unitVar_1: void): UH0_$union {
    return UH0_UH0_0(13338656111851470848n, (): UH0_$union => closure48(void 0, void 0));
}

export function closure46(unitVar: void, unitVar_1: void): UH0_$union {
    return UH0_UH0_0(14520938734448279552n, (): UH0_$union => closure47(void 0, void 0));
}

export function closure45(unitVar: void, unitVar_1: void): UH0_$union {
    return UH0_UH0_0(14717985838214414336n, (): UH0_$union => closure46(void 0, void 0));
}

export function closure44(unitVar: void, unitVar_1: void): UH0_$union {
    return UH0_UH0_0(5527454985320660992n, (): UH0_$union => closure45(void 0, void 0));
}

export function closure43(unitVar: void, unitVar_1: void): UH0_$union {
    return UH0_UH0_0(16293529225644736512n, (): UH0_$union => closure44(void 0, void 0));
}

export function closure42(unitVar: void, unitVar_1: void): UH0_$union {
    return UH0_UH0_0(11938960241128898560n, (): UH0_$union => closure43(void 0, void 0));
}

export function closure41(unitVar: void, unitVar_1: void): UH0_$union {
    return UH0_UH0_0(8138741398091333632n, (): UH0_$union => closure42(void 0, void 0));
}

export function closure40(unitVar: void, unitVar_1: void): UH0_$union {
    return UH0_UH0_0(7505371590918406144n, (): UH0_$union => closure41(void 0, void 0));
}

export function closure39(unitVar: void, unitVar_1: void): UH0_$union {
    return UH0_UH0_0(16623181993244360704n, (): UH0_$union => closure40(void 0, void 0));
}

export function closure38(unitVar: void, unitVar_1: void): UH0_$union {
    return UH0_UH0_0(8919445023443910656n, (): UH0_$union => closure39(void 0, void 0));
}

export function closure37(unitVar: void, unitVar_1: void): UH0_$union {
    return UH0_UH0_0(4561031516192243712n, (): UH0_$union => closure38(void 0, void 0));
}

export function closure36(unitVar: void, unitVar_1: void): UH0_$union {
    return UH0_UH0_0(9983543956220149760n, (): UH0_$union => closure37(void 0, void 0));
}

export function closure35(unitVar: void, unitVar_1: void): UH0_$union {
    return UH0_UH0_0(4738381338321616896n, (): UH0_$union => closure36(void 0, void 0));
}

export function closure34(unitVar: void, unitVar_1: void): UH0_$union {
    return UH0_UH0_0(789730223053602816n, (): UH0_$union => closure35(void 0, void 0));
}

export function closure33(unitVar: void, unitVar_1: void): UH0_$union {
    return UH0_UH0_0(131621703842267136n, (): UH0_$union => closure34(void 0, void 0));
}

export function closure32(unitVar: void, unitVar_1: void): UH0_$union {
    return UH0_UH0_0(21936950640377856n, (): UH0_$union => closure33(void 0, void 0));
}

export function closure31(unitVar: void, unitVar_1: void): UH0_$union {
    return UH0_UH0_0(3656158440062976n, (): UH0_$union => closure32(void 0, void 0));
}

export function closure30(unitVar: void, unitVar_1: void): UH0_$union {
    return UH0_UH0_0(609359740010496n, (): UH0_$union => closure31(void 0, void 0));
}

export function closure29(unitVar: void, unitVar_1: void): UH0_$union {
    return UH0_UH0_0(101559956668416n, (): UH0_$union => closure30(void 0, void 0));
}

export function closure28(unitVar: void, unitVar_1: void): UH0_$union {
    return UH0_UH0_0(16926659444736n, (): UH0_$union => closure29(void 0, void 0));
}

export function closure27(unitVar: void, unitVar_1: void): UH0_$union {
    return UH0_UH0_0(2821109907456n, (): UH0_$union => closure28(void 0, void 0));
}

export function closure26(unitVar: void, unitVar_1: void): UH0_$union {
    return UH0_UH0_0(470184984576n, (): UH0_$union => closure27(void 0, void 0));
}

export function closure25(unitVar: void, unitVar_1: void): UH0_$union {
    return UH0_UH0_0(78364164096n, (): UH0_$union => closure26(void 0, void 0));
}

export function closure24(unitVar: void, unitVar_1: void): UH0_$union {
    return UH0_UH0_0(13060694016n, (): UH0_$union => closure25(void 0, void 0));
}

export function closure23(unitVar: void, unitVar_1: void): UH0_$union {
    return UH0_UH0_0(2176782336n, (): UH0_$union => closure24(void 0, void 0));
}

export function closure22(unitVar: void, unitVar_1: void): UH0_$union {
    return UH0_UH0_0(362797056n, (): UH0_$union => closure23(void 0, void 0));
}

export function closure21(unitVar: void, unitVar_1: void): UH0_$union {
    return UH0_UH0_0(60466176n, (): UH0_$union => closure22(void 0, void 0));
}

export function closure20(unitVar: void, unitVar_1: void): UH0_$union {
    return UH0_UH0_0(10077696n, (): UH0_$union => closure21(void 0, void 0));
}

export function closure19(unitVar: void, unitVar_1: void): UH0_$union {
    return UH0_UH0_0(1679616n, (): UH0_$union => closure20(void 0, void 0));
}

export function closure18(unitVar: void, unitVar_1: void): UH0_$union {
    return UH0_UH0_0(279936n, (): UH0_$union => closure19(void 0, void 0));
}

export function closure17(unitVar: void, unitVar_1: void): UH0_$union {
    return UH0_UH0_0(46656n, (): UH0_$union => closure18(void 0, void 0));
}

export function closure16(unitVar: void, unitVar_1: void): UH0_$union {
    return UH0_UH0_0(7776n, (): UH0_$union => closure17(void 0, void 0));
}

export function closure15(unitVar: void, unitVar_1: void): UH0_$union {
    return UH0_UH0_0(1296n, (): UH0_$union => closure16(void 0, void 0));
}

export function closure14(unitVar: void, unitVar_1: void): UH0_$union {
    return UH0_UH0_0(216n, (): UH0_$union => closure15(void 0, void 0));
}

export function closure13(unitVar: void, unitVar_1: void): UH0_$union {
    return UH0_UH0_0(36n, (): UH0_$union => closure14(void 0, void 0));
}

export function closure12(unitVar: void, unitVar_1: void): UH0_$union {
    return UH0_UH0_0(6n, (): UH0_$union => closure13(void 0, void 0));
}

export function method11(v0_mut: int64, v1_mut: UH0_$union): US1_$union {
    method11:
    while (true) {
        const v0: int64 = v0_mut, v1: UH0_$union = v1_mut;
        if (v1.tag === /* UH0_1 */ 1) {
            return US1_US1_0();
        }
        else {
            const v3: (() => UH0_$union) = v1.fields[1];
            const v2: uint64 = v1.fields[0];
            if (compare(v0, 0n) <= 0) {
                return US1_US1_1(v2);
            }
            else {
                v0_mut = toInt64(op_Subtraction(v0, 1n));
                v1_mut = v3();
                continue method11;
            }
        }
        break;
    }
}

export function method10(v0_mut: US2_$union, v1_mut: int64, v2_mut: UH1_$union, v3_mut: uint64): US3_$union {
    method10:
    while (true) {
        const v0: US2_$union = v0_mut, v1: int64 = v1_mut, v2: UH1_$union = v2_mut, v3: uint64 = v3_mut;
        if (compare(v1, 0n) < 0) {
            const v5 = `accumulate_dice_rolls / power: ${v1} / acc: ${v3}`;
            if (v0.tag === /* US2_1 */ 1) {
                v0.fields[0](v5);
            }
            return US3_US3_1(toUInt64(op_Addition(v3, 1n)), v2);
        }
        else if (v2.tag === /* UH1_1 */ 1) {
            return US3_US3_0();
        }
        else {
            const v11: UH1_$union = v2.fields[1];
            const v10: uint64 = v2.fields[0];
            if (compare(v10, 1n) > 0) {
                const v16: US1_$union = method11(v1, UH0_UH0_0(1n, (): UH0_$union => closure12(void 0, void 0)));
                let v20: uint64;
                if (v16.tag === /* US1_1 */ 1) {
                    v20 = v16.fields[0];
                }
                else {
                    throw new Error("Option does not have a value.");
                }
                const v22: uint64 = toUInt64(op_Multiply(toUInt64(op_Subtraction(v10, 1n)), v20));
                const v23 = `accumulate_dice_rolls / power: ${v1} / acc: ${v3} / roll: ${v10} / value: ${v22}`;
                if (v0.tag === /* US2_1 */ 1) {
                    v0.fields[0](v23);
                }
                const v25: uint64 = toUInt64(op_Addition(v3, v22));
                v0_mut = v0;
                v1_mut = toInt64(op_Subtraction(v1, 1n));
                v2_mut = v11;
                v3_mut = v25;
                continue method10;
            }
            else {
                const v28 = `accumulate_dice_rolls / power: ${v1} / acc: ${v3} / roll: ${v10}`;
                if (v0.tag === /* US2_1 */ 1) {
                    v0.fields[0](v28);
                }
                v0_mut = v0;
                v1_mut = toInt64(op_Subtraction(v1, 1n));
                v2_mut = v11;
                v3_mut = v3;
                continue method10;
            }
        }
        break;
    }
}

export function method12(v0: int64, v1: (() => uint64), v2: int64): UH1_$union {
    if (compare(v2, v0) < 0) {
        return UH1_UH1_0(v1(), method12(v0, v1, toInt64(op_Addition(v2, 1n))));
    }
    else {
        return UH1_UH1_1();
    }
}

export function method13(v0_mut: US2_$union, v1_mut: (() => uint64), v2_mut: boolean, v3_mut: uint64, v4_mut: int64, v5_mut: UH1_$union): uint64 {
    method13:
    while (true) {
        const v0: US2_$union = v0_mut, v1: (() => uint64) = v1_mut, v2: boolean = v2_mut, v3: uint64 = v3_mut, v4: int64 = v4_mut, v5: UH1_$union = v5_mut;
        const v6: int64 = toInt64(op_Addition(v4, 1n));
        if (compare(v4, v6) < 0) {
            return method9(v0, v1, v2, v3, v4, UH1_UH1_0(v1(), v5), v6);
        }
        else {
            const v12: US3_$union = method10(v0, v4, v5, 0n);
            if (v12.tag === /* US3_1 */ 1) {
                const v14: UH1_$union = v12.fields[1];
                const v13: uint64 = v12.fields[0];
                if (compare(v13, v3) <= 0) {
                    return v13;
                }
                else if (v2) {
                    v0_mut = v0;
                    v1_mut = v1;
                    v2_mut = v2;
                    v3_mut = v3;
                    v4_mut = v4;
                    v5_mut = method12(v4, v1, 0n);
                    continue method13;
                }
                else {
                    return method9(v0, v1, v2, v3, v4, UH1_UH1_0(v1(), v5), v6);
                }
            }
            else if (v2) {
                v0_mut = v0;
                v1_mut = v1;
                v2_mut = v2;
                v3_mut = v3;
                v4_mut = v4;
                v5_mut = method12(v4, v1, 0n);
                continue method13;
            }
            else {
                return method9(v0, v1, v2, v3, v4, UH1_UH1_0(v1(), v5), v6);
            }
        }
        break;
    }
}

export function method9(v0_mut: US2_$union, v1_mut: (() => uint64), v2_mut: boolean, v3_mut: uint64, v4_mut: int64, v5_mut: UH1_$union, v6_mut: int64): uint64 {
    method9:
    while (true) {
        const v0: US2_$union = v0_mut, v1: (() => uint64) = v1_mut, v2: boolean = v2_mut, v3: uint64 = v3_mut, v4: int64 = v4_mut, v5: UH1_$union = v5_mut, v6: int64 = v6_mut;
        if (compare(v6, toInt64(op_Addition(v4, 1n))) < 0) {
            v0_mut = v0;
            v1_mut = v1;
            v2_mut = v2;
            v3_mut = v3;
            v4_mut = v4;
            v5_mut = UH1_UH1_0(v1(), v5);
            v6_mut = toInt64(op_Addition(v6, 1n));
            continue method9;
        }
        else {
            const v14: US3_$union = method10(v0, v4, v5, 0n);
            if (v14.tag === /* US3_1 */ 1) {
                const v16: UH1_$union = v14.fields[1];
                const v15: uint64 = v14.fields[0];
                if (compare(v15, v3) <= 0) {
                    return v15;
                }
                else if (v2) {
                    return method13(v0, v1, v2, v3, v4, method12(v4, v1, 0n));
                }
                else {
                    v0_mut = v0;
                    v1_mut = v1;
                    v2_mut = v2;
                    v3_mut = v3;
                    v4_mut = v4;
                    v5_mut = UH1_UH1_0(v1(), v5);
                    v6_mut = toInt64(op_Addition(v6, 1n));
                    continue method9;
                }
            }
            else if (v2) {
                return method13(v0, v1, v2, v3, v4, method12(v4, v1, 0n));
            }
            else {
                v0_mut = v0;
                v1_mut = v1;
                v2_mut = v2;
                v3_mut = v3;
                v4_mut = v4;
                v5_mut = UH1_UH1_0(v1(), v5);
                v6_mut = toInt64(op_Addition(v6, 1n));
                continue method9;
            }
        }
        break;
    }
}

export function closure11(v0: US2_$union, v1: (() => uint64), v2: boolean, v3: uint64): uint64 {
    return method9(v0, v1, v2, v3, toInt64(op_Subtraction(equals(v3, 1n) ? (1n) : method8(v0, v3, 0n, 1n), 1n)), UH1_UH1_1(), 0n);
}

export function closure10(v0: US2_$union, v1: (() => uint64), v2: boolean): ((arg0: uint64) => uint64) {
    return (v: uint64): uint64 => closure11(v0, v1, v2, v);
}

export function closure9(v0: US2_$union, v1: (() => uint64)): ((arg0: boolean) => ((arg0: uint64) => uint64)) {
    return (v: boolean): ((arg0: uint64) => uint64) => closure10(v0, v1, v);
}

export function closure8(unitVar: void, v0: US2_$union): ((arg0: (() => uint64)) => ((arg0: boolean) => ((arg0: uint64) => uint64))) {
    return (v: (() => uint64)): ((arg0: boolean) => ((arg0: uint64) => uint64)) => closure9(v0, v);
}

export function method14(v0_mut: UH1_$union, v1_mut: int64): int64 {
    method14:
    while (true) {
        const v0: UH1_$union = v0_mut, v1: int64 = v1_mut;
        if (v0.tag === /* UH1_1 */ 1) {
            return v1;
        }
        else {
            const v2: uint64 = v0.fields[0];
            v0_mut = v0.fields[1];
            v1_mut = toInt64(op_Addition(v1, 1n));
            continue method14;
        }
        break;
    }
}

export function closure78(v0: US2_$union, v1: uint64, v2: UH1_$union): US1_$union {
    const v7: US3_$union = method10(v0, toInt64(op_Subtraction(method14(v2, 0n), 1n)), v2, 0n);
    if (v7.tag === /* US3_1 */ 1) {
        const v9: UH1_$union = v7.fields[1];
        const v8: uint64 = v7.fields[0];
        if ((compare(v8, 1n) >= 0) && (compare(v8, v1) <= 0)) {
            return US1_US1_1(v8);
        }
        else {
            return US1_US1_0();
        }
    }
    else {
        return US1_US1_0();
    }
}

export function closure77(v0: US2_$union, v1: uint64): ((arg0: UH1_$union) => US1_$union) {
    return (v: UH1_$union): US1_$union => closure78(v0, v1, v);
}

export function closure76(unitVar: void, v0: US2_$union): ((arg0: uint64) => ((arg0: UH1_$union) => US1_$union)) {
    return (v: uint64): ((arg0: UH1_$union) => US1_$union) => closure77(v0, v);
}

export function method0(): void {
}

method0();

(function (_args: string[]): int32 {
    return 0;
})(typeof process === 'object' ? process.argv.slice(2) : []);

