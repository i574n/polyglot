import { Record } from "../../../polyglot/deps/Fable/src/fable-library-ts/Types.js";
import { float64, int32 } from "../../../polyglot/deps/Fable/src/fable-library-ts/Int32.js";
import { defaultOf, IComparable, IEquatable } from "../../../polyglot/deps/Fable/src/fable-library-ts/Util.js";
import { record_type, string_type, int32_type, TypeInfo } from "../../../polyglot/deps/Fable/src/fable-library-ts/Reflection.js";
import { interpolate, toText, trimStart, trimEnd, substring as substring_1, join, split as split_1, replace as replace_1, padRight, padLeft, endsWith } from "../../../polyglot/deps/Fable/src/fable-library-ts/String.js";
import { value as value_2, Option } from "../../../polyglot/deps/Fable/src/fable-library-ts/Option.js";
import { ofArray } from "../../../polyglot/deps/Fable/src/fable-library-ts/Seq.js";
import { toInt32, op_Subtraction, fromFloat64, toFloat64, compare, int64, fromInt32, toInt64 } from "../../../polyglot/deps/Fable/src/fable-library-ts/BigInt.js";
import { setItem, fill, item } from "../../../polyglot/deps/Fable/src/fable-library-ts/Array.js";

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

export function closure1(v0_1: string, v1_1: string): boolean {
    return v1_1.indexOf(v0_1) >= 0;
}

export function closure0(unitVar: void, v0_1: string): ((arg0: string) => boolean) {
    return (v: string): boolean => closure1(v0_1, v);
}

export function closure3(v0_1: string, v1_1: string): boolean {
    return endsWith(v1_1, v0_1);
}

export function closure2(unitVar: void, v0_1: string): ((arg0: string) => boolean) {
    return (v: string): boolean => closure3(v0_1, v);
}

export function closure6(v0_1: int32, v1_1: string, v2_1: string): string {
    return padLeft(v2_1, v0_1, v1_1);
}

export function closure5(v0_1: int32, v1_1: string): ((arg0: string) => string) {
    return (v: string): string => closure6(v0_1, v1_1, v);
}

export function closure4(unitVar: void, v0_1: int32): ((arg0: string) => ((arg0: string) => string)) {
    return (v: string): ((arg0: string) => string) => closure5(v0_1, v);
}

export function closure9(v0_1: int32, v1_1: string, v2_1: string): string {
    return padRight(v2_1, v0_1, v1_1);
}

export function closure8(v0_1: int32, v1_1: string): ((arg0: string) => string) {
    return (v: string): string => closure9(v0_1, v1_1, v);
}

export function closure7(unitVar: void, v0_1: int32): ((arg0: string) => ((arg0: string) => string)) {
    return (v: string): ((arg0: string) => string) => closure8(v0_1, v);
}

export function closure12(v0_1: string, v1_1: string, v2_1: string): string {
    return replace_1(v2_1, v0_1, v1_1);
}

export function closure11(v0_1: string, v1_1: string): ((arg0: string) => string) {
    return (v: string): string => closure12(v0_1, v1_1, v);
}

export function closure10(unitVar: void, v0_1: string): ((arg0: string) => ((arg0: string) => string)) {
    return (v: string): ((arg0: string) => string) => closure11(v0_1, v);
}

export function method0(v0_1: string): string {
    return v0_1;
}

export function method1(v0_1: string): string {
    return v0_1;
}

export function method2(v0_1: string): string {
    return v0_1;
}

export function closure15(v0_1: string, v1_1: string, v2_1: string): string {
    let _v3: Option<string> = undefined;
    const x: string = defaultOf();
    _v3 = x;
    return value_2(_v3);
}

export function closure14(v0_1: string, v1_1: string): ((arg0: string) => string) {
    return (v: string): string => closure15(v0_1, v1_1, v);
}

export function closure13(unitVar: void, v0_1: string): ((arg0: string) => ((arg0: string) => string)) {
    return (v: string): ((arg0: string) => string) => closure14(v0_1, v);
}

export function closure18(v0_1: int32, v1_1: int32, v2_1: string): string {
    return v2_1.slice(v0_1, v1_1 + 1);
}

export function closure17(v0_1: int32, v1_1: int32): ((arg0: string) => string) {
    return (v: string): string => closure18(v0_1, v1_1, v);
}

export function closure16(unitVar: void, v0_1: int32): ((arg0: int32) => ((arg0: string) => string)) {
    return (v: int32): ((arg0: string) => string) => closure17(v0_1, v);
}

export function closure20(v0_1: string, v1_1: string): string[] {
    return split_1(v1_1, [v0_1], undefined, 0);
}

export function closure19(unitVar: void, v0_1: string): ((arg0: string) => string[]) {
    return (v: string): string[] => closure20(v0_1, v);
}

export function method3(): string {
    return "";
}

export function closure22(v0_1: string[], v1_1: string): string[] {
    let _v2: Option<string[]> = undefined;
    const v27: Iterable<string> = ofArray<string>(v0_1);
    const x: string[] = split_1(v1_1, [join(method3(), v27)], undefined, 0);
    _v2 = x;
    return value_2(_v2);
}

export function closure21(unitVar: void, v0_1: string[]): ((arg0: string) => string[]) {
    return (v: string): string[] => closure22(v0_1, v);
}

export function closure24(v0_1: string, v1_1: string): boolean {
    return v1_1.indexOf(v0_1) === 0;
}

export function closure23(unitVar: void, v0_1: string): ((arg0: string) => boolean) {
    return (v: string): boolean => closure24(v0_1, v);
}

export function closure27(v0_1: int32, v1_1: int32, v2_1: string): string {
    return substring_1(v2_1, v0_1, v1_1);
}

export function closure26(v0_1: int32, v1_1: int32): ((arg0: string) => string) {
    return (v: string): string => closure27(v0_1, v1_1, v);
}

export function closure25(unitVar: void, v0_1: int32): ((arg0: int32) => ((arg0: string) => string)) {
    return (v: int32): ((arg0: string) => string) => closure26(v0_1, v);
}

export function closure28(unitVar: void, v0_1: string): string {
    return v0_1.toLocaleLowerCase();
}

export function closure29(unitVar: void, v0_1: string): string {
    return v0_1.toLocaleUpperCase();
}

export function closure30(unitVar: void, v0_1: string): string {
    return v0_1.trim();
}

export function closure32(v0_1: string[], v1_1: string): string {
    return trimEnd(v1_1, ...v0_1);
}

export function closure31(unitVar: void, v0_1: string[]): ((arg0: string) => string) {
    return (v: string): string => closure32(v0_1, v);
}

export function closure34(v0_1: string[], v1_1: string): string {
    return trimStart(v1_1, ...v0_1);
}

export function closure33(unitVar: void, v0_1: string[]): ((arg0: string) => string) {
    return (v: string): string => closure34(v0_1, v);
}

export function closure36(v0_1: int32, v1_1: string): string {
    if (v1_1.length <= v0_1) {
        return v1_1;
    }
    else {
        const v4_1: int32 = (v0_1 - 1) | 0;
        return v1_1.slice(0, v4_1 + 1) + "...";
    }
}

export function closure35(unitVar: void, v0_1: int32): ((arg0: string) => string) {
    return (v: string): string => closure36(v0_1, v);
}

export function closure38(v0_1: int64, v1_1: string): string {
    const v2_1: int64 = toInt64(fromInt32(v1_1.length));
    if (compare(v2_1, v0_1) <= 0) {
        return v1_1;
    }
    else {
        const v5_1: float64 = toFloat64(v0_1) / 2;
        const v8_1: int64 = toInt64(fromFloat64(Math.ceil(v5_1)));
        const v11_1: int64 = toInt64(fromFloat64(Math.floor(v5_1)));
        const v12_1: int64 = toInt64(op_Subtraction(v8_1, 1n));
        const v13_1: string = v1_1.slice(~~toInt32(0n), ~~toInt32(v12_1) + 1);
        const v14_1: int64 = toInt64(op_Subtraction(v2_1, v11_1));
        const v15_1: int64 = toInt64(op_Subtraction(v2_1, 1n));
        const v20_1: Iterable<string> = ofArray<string>([v13_1, "...", v1_1.slice(~~toInt32(v14_1), ~~toInt32(v15_1) + 1)]);
        return join(method3(), v20_1);
    }
}

export function closure37(unitVar: void, v0_1: int64): ((arg0: string) => string) {
    return (v: string): string => closure38(v0_1, v);
}

export function closure39(unitVar: void, v0_1: Error): string {
    let _v1: Option<string> = undefined;
    const x: string = toText(interpolate("%A%P()", [v0_1]));
    _v1 = x;
    return value_2(_v1);
}

export function method4(v0_1: int32, v1_1: Mut0): boolean {
    return v1_1.l0 < v0_1;
}

export function closure41(v0_1: string, v1_1: string[]): string {
    const v2_1: int32 = v1_1.length | 0;
    const v4_1: Mut0 = new Mut0(0, "");
    while (method4(v2_1, v4_1)) {
        const v6_1: int32 = v4_1.l0 | 0;
        const v9_1: string = ((v4_1.l1 + item(v6_1, v1_1)) + v0_1) + "";
        const v10_1: int32 = (v6_1 + 1) | 0;
        v4_1.l0 = (v10_1 | 0);
        v4_1.l1 = v9_1;
    }
    return v4_1.l1;
}

export function closure40(unitVar: void, v0_1: string): ((arg0: string[]) => string) {
    return (v: string[]): string => closure41(v0_1, v);
}

export function method5(v0_1: string): string {
    return v0_1;
}

export function closure43(v0_1: string, v1_1: Iterable<string>): string {
    return join(method5(v0_1), v1_1);
}

export function closure42(unitVar: void, v0_1: string): ((arg0: Iterable<string>) => string) {
    return (v: Iterable<string>): string => closure43(v0_1, v);
}

export function closure45(v0_1: string, v1_1: string[]): string {
    return join(v0_1, v1_1);
}

export function closure44(unitVar: void, v0_1: string): ((arg0: string[]) => string) {
    return (v: string[]): string => closure45(v0_1, v);
}

export function method6(v0_1: int32, v1_1: Mut1): boolean {
    return v1_1.l0 < v0_1;
}

export function closure46(unitVar: void, v0_1: string): string[] {
    const v1_1: int32 = v0_1.length | 0;
    const v2_1: string[] = fill(new Array(v1_1), 0, v1_1, "");
    const v3_1: Mut1 = new Mut1(0);
    while (method6(v1_1, v3_1)) {
        const v5_1: int32 = v3_1.l0 | 0;
        const v6_1: string = v0_1[v5_1];
        setItem(v2_1, v5_1, v6_1);
        const v7_1: int32 = (v5_1 + 1) | 0;
        v3_1.l0 = (v7_1 | 0);
    }
    return v2_1;
}

export const v0 = (v: string): ((arg0: string) => boolean) => closure0(undefined, v);

export function contains(x: string): ((arg0: string) => boolean) {
    return v0(x);
}

export const v1 = (v: string): ((arg0: string) => boolean) => closure2(undefined, v);

export function ends_with(x: string): ((arg0: string) => boolean) {
    return v1(x);
}

export const v2 = (v: int32): ((arg0: string) => ((arg0: string) => string)) => closure4(undefined, v);

export function pad_left(x: int32): ((arg0: string) => ((arg0: string) => string)) {
    return v2(x);
}

export const v3 = (v: int32): ((arg0: string) => ((arg0: string) => string)) => closure7(undefined, v);

export function pad_right(x: int32): ((arg0: string) => ((arg0: string) => string)) {
    return v3(x);
}

export const v4 = (v: string): ((arg0: string) => ((arg0: string) => string)) => closure10(undefined, v);

export function replace(x: string): ((arg0: string) => ((arg0: string) => string)) {
    return v4(x);
}

export const v5 = (v: string): ((arg0: string) => ((arg0: string) => string)) => closure13(undefined, v);

export function replace_regex(x: string): ((arg0: string) => ((arg0: string) => string)) {
    return v5(x);
}

export const v6 = (v: int32): ((arg0: int32) => ((arg0: string) => string)) => closure16(undefined, v);

export function slice(x: int32): ((arg0: int32) => ((arg0: string) => string)) {
    return v6(x);
}

export const v7 = (v: string): ((arg0: string) => string[]) => closure19(undefined, v);

export function split(x: string): ((arg0: string) => string[]) {
    return v7(x);
}

export const v8 = (v: string[]): ((arg0: string) => string[]) => closure21(undefined, v);

export function split_string(x: string[]): ((arg0: string) => string[]) {
    return v8(x);
}

export const v9 = (v: string): ((arg0: string) => boolean) => closure23(undefined, v);

export function starts_with(x: string): ((arg0: string) => boolean) {
    return v9(x);
}

export const v10 = (v: int32): ((arg0: int32) => ((arg0: string) => string)) => closure25(undefined, v);

export function substring(x: int32): ((arg0: int32) => ((arg0: string) => string)) {
    return v10(x);
}

export const v11 = (v: string): string => closure28(undefined, v);

export function to_lower(x: string): string {
    return v11(x);
}

export const v12 = (v: string): string => closure29(undefined, v);

export function to_upper(x: string): string {
    return v12(x);
}

export const v13 = (v: string): string => closure30(undefined, v);

export function trim(x: string): string {
    return v13(x);
}

export const v14 = (v: string[]): ((arg0: string) => string) => closure31(undefined, v);

export function trim_end(x: string[]): ((arg0: string) => string) {
    return v14(x);
}

export const v15 = (v: string[]): ((arg0: string) => string) => closure33(undefined, v);

export function trim_start(x: string[]): ((arg0: string) => string) {
    return v15(x);
}

export const v16 = (v: int32): ((arg0: string) => string) => closure35(undefined, v);

export function ellipsis(x: int32): ((arg0: string) => string) {
    return v16(x);
}

export const v17 = (v: int64): ((arg0: string) => string) => closure37(undefined, v);

export function ellipsis_end(x: int64): ((arg0: string) => string) {
    return v17(x);
}

export const v18 = (v: Error): string => closure39(undefined, v);

export function format_exception(x: Error): string {
    return v18(x);
}

export const v19 = (v: string): ((arg0: string[]) => string) => closure40(undefined, v);

export function concat_array_trailing(x: string): ((arg0: string[]) => string) {
    return v19(x);
}

export const v20 = (v: string): ((arg0: Iterable<string>) => string) => closure42(undefined, v);

export function concat(x: string): ((arg0: Iterable<string>) => string) {
    return v20(x);
}

export const v21 = (v: string): ((arg0: string[]) => string) => closure44(undefined, v);

export function join$0027(x: string): ((arg0: string[]) => string) {
    return v21(x);
}

export const v22 = (v: string): string[] => closure46(undefined, v);

export function to_char_array(x: string): string[] {
    return v22(x);
}


