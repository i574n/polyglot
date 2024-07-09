import { Record, Union } from "../../deps/Fable/src/fable-library-ts/Types.js";
import { record_type, string_type, int32_type, union_type, char_type, TypeInfo } from "../../deps/Fable/src/fable-library-ts/Reflection.js";
import { float64, int32 } from "../../deps/Fable/src/fable-library-ts/Int32.js";
import { uncurry2, defaultOf, IComparable, IEquatable } from "../../deps/Fable/src/fable-library-ts/Util.js";
import { interpolate, toText, trimStart, trimEnd, substring as substring_1, join, split as split_1, replace as replace_1, padRight, padLeft, endsWith } from "../../deps/Fable/src/fable-library-ts/String.js";
import { value as value_5, Option } from "../../deps/Fable/src/fable-library-ts/Option.js";
import { ofArray } from "../../deps/Fable/src/fable-library-ts/Seq.js";
import { foldBack, ofArray as ofArray_1, empty, toArray, FSharpList, cons } from "../../deps/Fable/src/fable-library-ts/List.js";
import { toInt32, op_Subtraction, fromFloat64, toFloat64, compare, int64, fromInt32, toInt64 } from "../../deps/Fable/src/fable-library-ts/BigInt.js";
import { setItem, fill, item } from "../../deps/Fable/src/fable-library-ts/Array.js";

export type UH0_$union = 
    | UH0<0>
    | UH0<1>

export type UH0_$cases = {
    0: ["UH0_0", []],
    1: ["UH0_1", [string, UH0_$union]]
}

export function UH0_UH0_0() {
    return new UH0<0>(0, []);
}

export function UH0_UH0_1(Item1: string, Item2: UH0_$union) {
    return new UH0<1>(1, [Item1, Item2]);
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
    return union_type("Sm.UH0", [], UH0, () => [[], [["Item1", char_type], ["Item2", UH0_$reflection()]]]);
}

export class Mut0 extends Record implements IEquatable<Mut0>, IComparable<Mut0> {
    l0: int32;
    l1: string;
    constructor(l0: int32, l1: string) {
        super();
        this.l0 = (l0 | 0);
        this.l1 = l1;
    }
}

export function Mut0_$reflection(): TypeInfo {
    return record_type("Sm.Mut0", [], Mut0, () => [["l0", int32_type], ["l1", string_type]]);
}

export class Mut1 extends Record implements IEquatable<Mut1>, IComparable<Mut1> {
    l0: int32;
    constructor(l0: int32) {
        super();
        this.l0 = (l0 | 0);
    }
}

export function Mut1_$reflection(): TypeInfo {
    return record_type("Sm.Mut1", [], Mut1, () => [["l0", int32_type]]);
}

export function closure1(v0: string, v1: string): boolean {
    return v1.indexOf(v0) >= 0;
}

export function closure0(unitVar: void, v0: string): ((arg0: string) => boolean) {
    return (v: string): boolean => closure1(v0, v);
}

export function closure3(v0: string, v1: string): boolean {
    return endsWith(v1, v0);
}

export function closure2(unitVar: void, v0: string): ((arg0: string) => boolean) {
    return (v: string): boolean => closure3(v0, v);
}

export function closure6(v0: int32, v1: string, v2: string): string {
    return padLeft(v2, v0, v1);
}

export function closure5(v0: int32, v1: string): ((arg0: string) => string) {
    return (v: string): string => closure6(v0, v1, v);
}

export function closure4(unitVar: void, v0: int32): ((arg0: string) => ((arg0: string) => string)) {
    return (v: string): ((arg0: string) => string) => closure5(v0, v);
}

export function closure9(v0: int32, v1: string, v2: string): string {
    return padRight(v2, v0, v1);
}

export function closure8(v0: int32, v1: string): ((arg0: string) => string) {
    return (v: string): string => closure9(v0, v1, v);
}

export function closure7(unitVar: void, v0: int32): ((arg0: string) => ((arg0: string) => string)) {
    return (v: string): ((arg0: string) => string) => closure8(v0, v);
}

export function closure12(v0: string, v1: string, v2: string): string {
    return replace_1(v2, v0, v1);
}

export function closure11(v0: string, v1: string): ((arg0: string) => string) {
    return (v: string): string => closure12(v0, v1, v);
}

export function closure10(unitVar: void, v0: string): ((arg0: string) => ((arg0: string) => string)) {
    return (v: string): ((arg0: string) => string) => closure11(v0, v);
}

export function method0(v0: string): string {
    return v0;
}

export function method1(v0: string): string {
    return v0;
}

export function method2(v0: string): string {
    return v0;
}

export function closure15(v0: string, v1: string, v2: string): string {
    const v3: string = method0(v1);
    let _v6: Option<string> = undefined;
    const x: string = defaultOf();
    _v6 = x;
    if (_v6 == null) {
        throw new Error("base.run_target / _v6=None");
    }
    else {
        return value_5(_v6);
    }
}

export function closure14(v0: string, v1: string): ((arg0: string) => string) {
    return (v: string): string => closure15(v0, v1, v);
}

export function closure13(unitVar: void, v0: string): ((arg0: string) => ((arg0: string) => string)) {
    return (v: string): ((arg0: string) => string) => closure14(v0, v);
}

export function closure18(v0: int32, v1: int32, v2: string): string {
    return v2.slice(v0, v1 + 1);
}

export function closure17(v0: int32, v1: int32): ((arg0: string) => string) {
    return (v: string): string => closure18(v0, v1, v);
}

export function closure16(unitVar: void, v0: int32): ((arg0: int32) => ((arg0: string) => string)) {
    return (v: int32): ((arg0: string) => string) => closure17(v0, v);
}

export function closure20(v0: string, v1: string): string[] {
    return split_1(v1, [v0], undefined, 0);
}

export function closure19(unitVar: void, v0: string): ((arg0: string) => string[]) {
    return (v: string): string[] => closure20(v0, v);
}

export function method3(): string {
    return "";
}

export function closure22(v0: string[], v1: string): string[] {
    let _v4: Option<string[]> = undefined;
    const v73: Iterable<string> = ofArray<string>(v0);
    const x: string[] = split_1(v1, [join(method3(), v73)], undefined, 0);
    _v4 = x;
    if (_v4 == null) {
        throw new Error("base.run_target / _v4=None");
    }
    else {
        return value_5(_v4);
    }
}

export function closure21(unitVar: void, v0: string[]): ((arg0: string) => string[]) {
    return (v: string): string[] => closure22(v0, v);
}

export function closure24(v0: string, v1: string): boolean {
    return v1.indexOf(v0) === 0;
}

export function closure23(unitVar: void, v0: string): ((arg0: string) => boolean) {
    return (v: string): boolean => closure24(v0, v);
}

export function closure27(v0: int32, v1: int32, v2: string): string {
    return substring_1(v2, v0, v1);
}

export function closure26(v0: int32, v1: int32): ((arg0: string) => string) {
    return (v: string): string => closure27(v0, v1, v);
}

export function closure25(unitVar: void, v0: int32): ((arg0: int32) => ((arg0: string) => string)) {
    return (v: int32): ((arg0: string) => string) => closure26(v0, v);
}

export function closure28(unitVar: void, v0: string): string {
    return v0.toLocaleLowerCase();
}

export function closure29(unitVar: void, v0: string): string {
    return v0.toLocaleUpperCase();
}

export function closure30(unitVar: void, v0: string): string {
    return v0.trim();
}

export function closure33(v0: string, v1: UH0_$union): UH0_$union {
    return UH0_UH0_1(v0, v1);
}

export function closure32(unitVar: void, v0: string): ((arg0: UH0_$union) => UH0_$union) {
    return (v: UH0_$union): UH0_$union => closure33(v0, v);
}

export function method4(): ((arg0: string) => ((arg0: UH0_$union) => UH0_$union)) {
    return (v: string): ((arg0: UH0_$union) => UH0_$union) => closure32(undefined, v);
}

export function method5(v0: UH0_$union, v1: FSharpList<string>): FSharpList<string> {
    if (v0.tag === /* UH0_0 */ 0) {
        return v1;
    }
    else {
        return cons(v0.fields[0], method5(v0.fields[1], v1));
    }
}

export function closure34(v0: UH0_$union, v1: string): string {
    return trimEnd(v1, ...toArray<string>(method5(v0, empty<string>())));
}

export function closure31(unitVar: void, v0: string[]): ((arg0: string) => string) {
    const v1: FSharpList<string> = ofArray_1<string>(v0);
    const v9: UH0_$union = foldBack<string, UH0_$union>(uncurry2(method4()), v1, UH0_UH0_0());
    return (v: string): string => closure34(v9, v);
}

export function closure36(v0: UH0_$union, v1: string): string {
    return trimStart(v1, ...toArray<string>(method5(v0, empty<string>())));
}

export function closure35(unitVar: void, v0: string[]): ((arg0: string) => string) {
    const v1: FSharpList<string> = ofArray_1<string>(v0);
    const v9: UH0_$union = foldBack<string, UH0_$union>(uncurry2(method4()), v1, UH0_UH0_0());
    return (v: string): string => closure36(v9, v);
}

export function closure38(v0: int32, v1: string): string {
    if (v1.length <= v0) {
        return v1;
    }
    else {
        const v4: int32 = (v0 - 1) | 0;
        return v1.slice(0, v4 + 1) + "...";
    }
}

export function closure37(unitVar: void, v0: int32): ((arg0: string) => string) {
    return (v: string): string => closure38(v0, v);
}

export function method6(v0: int64, v1: string): string {
    const v2: int64 = toInt64(fromInt32(v1.length));
    if (compare(v2, v0) <= 0) {
        return v1;
    }
    else {
        const v6: float64 = toFloat64(v0) / 2;
        const v10: int64 = toInt64(fromFloat64(Math.ceil(v6)));
        const v14: int64 = toInt64(fromFloat64(Math.floor(v6)));
        const v15: int64 = toInt64(op_Subtraction(v10, 1n));
        const v16: string = v1.slice(~~toInt32(0n), ~~toInt32(v15) + 1);
        const v17: int64 = toInt64(op_Subtraction(v2, v14));
        const v18: int64 = toInt64(op_Subtraction(v2, 1n));
        return join("", ofArray<string>([v16, "...", v1.slice(~~toInt32(v17), ~~toInt32(v18) + 1)]));
    }
}

export function closure40(v0: int64, v1: string): string {
    return method6(v0, v1);
}

export function closure39(unitVar: void, v0: int64): ((arg0: string) => string) {
    return (v: string): string => closure40(v0, v);
}

export function closure41(unitVar: void, v0: Error): string {
    let _v3: Option<string> = undefined;
    const x: string = toText(interpolate("%A%P()", [v0]));
    _v3 = x;
    if (_v3 == null) {
        throw new Error("base.run_target / _v3=None");
    }
    else {
        return value_5(_v3);
    }
}

export function method7(v0: int32, v1: Mut0): boolean {
    return v1.l0 < v0;
}

export function closure43(v0: string, v1: string[]): string {
    const v2: int32 = v1.length | 0;
    const v4: Mut0 = new Mut0(0, "");
    while (method7(v2, v4)) {
        const v6: int32 = v4.l0 | 0;
        const v9: string = ((v4.l1 + item(v6, v1)) + v0) + "";
        const v10: int32 = (v6 + 1) | 0;
        v4.l0 = (v10 | 0);
        v4.l1 = v9;
    }
    return v4.l1;
}

export function closure42(unitVar: void, v0: string): ((arg0: string[]) => string) {
    return (v: string[]): string => closure43(v0, v);
}

export function closure45(v0: string, v1: Iterable<string>): string {
    return join(v0, v1);
}

export function closure44(unitVar: void, v0: string): ((arg0: Iterable<string>) => string) {
    return (v: Iterable<string>): string => closure45(v0, v);
}

export function closure47(v0: string, v1: string[]): string {
    return join(v0, v1);
}

export function closure46(unitVar: void, v0: string): ((arg0: string[]) => string) {
    return (v: string[]): string => closure47(v0, v);
}

export function method8(v0: int32, v1: Mut1): boolean {
    return v1.l0 < v0;
}

export function closure48(unitVar: void, v0: string): string[] {
    const v1: int32 = v0.length | 0;
    const v2: string[] = fill(new Array(v1), 0, v1, "");
    const v3: Mut1 = new Mut1(0);
    while (method8(v1, v3)) {
        const v5: int32 = v3.l0 | 0;
        const v6: string = v0[v5];
        setItem(v2, v5, v6);
        const v7: int32 = (v5 + 1) | 0;
        v3.l0 = (v7 | 0);
    }
    return v2;
}

export const v24 = (v: string): ((arg0: string) => boolean) => closure0(undefined, v);

export function contains(x: string): ((arg0: string) => boolean) {
    return v24(x);
}

export const v25 = (v: string): ((arg0: string) => boolean) => closure2(undefined, v);

export function ends_with(x: string): ((arg0: string) => boolean) {
    return v25(x);
}

export const v26 = (v: int32): ((arg0: string) => ((arg0: string) => string)) => closure4(undefined, v);

export function pad_left(x: int32): ((arg0: string) => ((arg0: string) => string)) {
    return v26(x);
}

export const v27 = (v: int32): ((arg0: string) => ((arg0: string) => string)) => closure7(undefined, v);

export function pad_right(x: int32): ((arg0: string) => ((arg0: string) => string)) {
    return v27(x);
}

export const v28 = (v: string): ((arg0: string) => ((arg0: string) => string)) => closure10(undefined, v);

export function replace(x: string): ((arg0: string) => ((arg0: string) => string)) {
    return v28(x);
}

export const v29 = (v: string): ((arg0: string) => ((arg0: string) => string)) => closure13(undefined, v);

export function replace_regex(x: string): ((arg0: string) => ((arg0: string) => string)) {
    return v29(x);
}

export const v30 = (v: int32): ((arg0: int32) => ((arg0: string) => string)) => closure16(undefined, v);

export function slice(x: int32): ((arg0: int32) => ((arg0: string) => string)) {
    return v30(x);
}

export const v31 = (v: string): ((arg0: string) => string[]) => closure19(undefined, v);

export function split(x: string): ((arg0: string) => string[]) {
    return v31(x);
}

export const v32 = (v: string[]): ((arg0: string) => string[]) => closure21(undefined, v);

export function split_string(x: string[]): ((arg0: string) => string[]) {
    return v32(x);
}

export const v33 = (v: string): ((arg0: string) => boolean) => closure23(undefined, v);

export function starts_with(x: string): ((arg0: string) => boolean) {
    return v33(x);
}

export const v34 = (v: int32): ((arg0: int32) => ((arg0: string) => string)) => closure25(undefined, v);

export function substring(x: int32): ((arg0: int32) => ((arg0: string) => string)) {
    return v34(x);
}

export const v35 = (v: string): string => closure28(undefined, v);

export function to_lower(x: string): string {
    return v35(x);
}

export const v36 = (v: string): string => closure29(undefined, v);

export function to_upper(x: string): string {
    return v36(x);
}

export const v37 = (v: string): string => closure30(undefined, v);

export function trim(x: string): string {
    return v37(x);
}

export const v38 = (v: string[]): ((arg0: string) => string) => closure31(undefined, v);

export function trim_end(x: string[]): ((arg0: string) => string) {
    return v38(x);
}

export const v39 = (v: string[]): ((arg0: string) => string) => closure35(undefined, v);

export function trim_start(x: string[]): ((arg0: string) => string) {
    return v39(x);
}

export const v40 = (v: int32): ((arg0: string) => string) => closure37(undefined, v);

export function ellipsis(x: int32): ((arg0: string) => string) {
    return v40(x);
}

export const v41 = (v: int64): ((arg0: string) => string) => closure39(undefined, v);

export function ellipsis_end(x: int64): ((arg0: string) => string) {
    return v41(x);
}

export const v42 = (v: Error): string => closure41(undefined, v);

export function format_exception(x: Error): string {
    return v42(x);
}

export const v43 = (v: string): ((arg0: string[]) => string) => closure42(undefined, v);

export function concat_array_trailing(x: string): ((arg0: string[]) => string) {
    return v43(x);
}

export const v44 = (v: string): ((arg0: Iterable<string>) => string) => closure44(undefined, v);

export function concat(x: string): ((arg0: Iterable<string>) => string) {
    return v44(x);
}

export const v45 = (v: string): ((arg0: string[]) => string) => closure46(undefined, v);

export function join$0027(x: string): ((arg0: string[]) => string) {
    return v45(x);
}

export const v46 = (v: string): string[] => closure48(undefined, v);

export function to_char_array(x: string): string[] {
    return v46(x);
}


