import { Union } from "../../deps/Fable/src/fable-library-ts/Types.js";
import { union_type, string_type, TypeInfo } from "../../deps/Fable/src/fable-library-ts/Reflection.js";
import { parse as parse_1, toString } from "../../deps/Fable/src/fable-library-ts/Date.js";
import { int64ToString, defaultOf } from "../../deps/Fable/src/fable-library-ts/Util.js";
import { toString as toString_1, hours } from "../../deps/Fable/src/fable-library-ts/TimeSpan.js";
import { int32, uint8 } from "../../deps/Fable/src/fable-library-ts/Int32.js";
import { newGuid, parse } from "../../deps/Fable/src/fable-library-ts/Guid.js";
import { replace, concat } from "../../deps/Fable/src/fable-library-ts/String.js";
import { toInt64, int64 } from "../../deps/Fable/src/fable-library-ts/BigInt.js";
import { parse as parse_2 } from "../../deps/Fable/src/fable-library-ts/Long.js";

export type US0_$union = 
    | US0<0>
    | US0<1>

export type US0_$cases = {
    0: ["US0_0", [any]],
    1: ["US0_1", []]
}

export function US0_US0_0(f0_0: any) {
    return new US0<0>(0, [f0_0]);
}

export function US0_US0_1() {
    return new US0<1>(1, []);
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
    return union_type("Date_time.US0", [], US0, () => [[["f0_0", string_type]], []]);
}

export type US1_$union = 
    | US1<0>
    | US1<1>

export type US1_$cases = {
    0: ["US1_0", [string]],
    1: ["US1_1", []]
}

export function US1_US1_0(f0_0: string) {
    return new US1<0>(0, [f0_0]);
}

export function US1_US1_1() {
    return new US1<1>(1, []);
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
    return union_type("Date_time.US1", [], US1, () => [[["f0_0", string_type]], []]);
}

export type US2_$union = 
    | US2<0>
    | US2<1>
    | US2<2>

export type US2_$cases = {
    0: ["US2_0", []],
    1: ["US2_1", []],
    2: ["US2_2", []]
}

export function US2_US2_0() {
    return new US2<0>(0, []);
}

export function US2_US2_1() {
    return new US2<1>(1, []);
}

export function US2_US2_2() {
    return new US2<2>(2, []);
}

export class US2<Tag extends keyof US2_$cases> extends Union<Tag, US2_$cases[Tag][0]> {
    constructor(readonly tag: Tag, readonly fields: US2_$cases[Tag][1]) {
        super();
    }
    cases() {
        return ["US2_0", "US2_1", "US2_2"];
    }
}

export function US2_$reflection(): TypeInfo {
    return union_type("Date_time.US2", [], US2, () => [[], [], []]);
}

export type US3_$union = 
    | US3<0>
    | US3<1>
    | US3<2>
    | US3<3>
    | US3<4>

export type US3_$cases = {
    0: ["US3_0", [US2_$union]],
    1: ["US3_1", [US2_$union]],
    2: ["US3_2", [US2_$union]],
    3: ["US3_3", [US2_$union]],
    4: ["US3_4", [US2_$union]]
}

export function US3_US3_0(f0_0: US2_$union) {
    return new US3<0>(0, [f0_0]);
}

export function US3_US3_1(f1_0: US2_$union) {
    return new US3<1>(1, [f1_0]);
}

export function US3_US3_2(f2_0: US2_$union) {
    return new US3<2>(2, [f2_0]);
}

export function US3_US3_3(f3_0: US2_$union) {
    return new US3<3>(3, [f3_0]);
}

export function US3_US3_4(f4_0: US2_$union) {
    return new US3<4>(4, [f4_0]);
}

export class US3<Tag extends keyof US3_$cases> extends Union<Tag, US3_$cases[Tag][0]> {
    constructor(readonly tag: Tag, readonly fields: US3_$cases[Tag][1]) {
        super();
    }
    cases() {
        return ["US3_0", "US3_1", "US3_2", "US3_3", "US3_4"];
    }
}

export function US3_$reflection(): TypeInfo {
    return union_type("Date_time.US3", [], US3, () => [[["f0_0", US2_$reflection()]], [["f1_0", US2_$reflection()]], [["f2_0", US2_$reflection()]], [["f3_0", US2_$reflection()]], [["f4_0", US2_$reflection()]]]);
}

export function closure2(unitVar: void, v0_1: any): US0_$union {
    return US0_US0_0(v0_1);
}

export function method1(): ((arg0: any) => US0_$union) {
    return (v: any): US0_$union => closure2(undefined, v);
}

export function method2(): string {
    return "hh:mm";
}

export function method3(): string {
    return "yyyyMMdd-HHmm-ssff-ffff-f";
}

export function method4(): string {
    return "hhmm";
}

export function method0(v0_1: string, v1_1: Date): string {
    const v792: string = method3();
    const v797: string = toString(v1_1, (v792 === "") ? "M-d-y hh:mm:ss tt" : v792);
    const v820: any = defaultOf();
    let v978: number;
    throw new Error(`date_time.get_utc_offset / target: ${US3_US3_3(US2_US2_0())}`);
    const v991: uint8 = (hours(v978) > 0) ? 1 : 0;
    const v992: string = method4();
    const v1016 = `${v991}${toString_1(v978, "c", {})}`;
    const v1018: string = v0_1;
    const v1028: int32 = (v797.length + v1016.length) | 0;
    const v1042: int32 = (v1018.length - 1) | 0;
    return parse(concat(v797, v1016, ...v1018.slice(v1028, v1042 + 1)));
}

export function closure1(v0_1: string, v1_1: Date): string {
    return method0(v0_1, v1_1);
}

export function closure0(unitVar: void, v0_1: string): ((arg0: Date) => string) {
    return (v: Date): string => closure1(v0_1, v);
}

export function closure4(unitVar: void, v0_1: string): string {
    return replace(v0_1, "-", "");
}

export function closure3(unitVar: void, v0_1: string): Date {
    return parse_1(closure4(undefined, v0_1.slice(undefined, 24 + 1)));
}

export function closure7(v0_1: int32, v1_1: string, v2_1: int32, v3_1: string): string {
    if (v2_1 >= v0_1) {
        return v3_1;
    }
    else {
        return method5(v0_1, v1_1, v2_1 + 1)(v3_1 + v1_1);
    }
}

export function method5(v0_1: int32, v1_1: string, v2_1: int32): ((arg0: string) => string) {
    return (v: string): string => closure7(v0_1, v1_1, v2_1, v);
}

export function closure6(v0_1: string, v1_1: int64): string {
    const v3_1: string = v0_1;
    const v7_1: string = int64ToString(v1_1);
    const v11 = "0";
    const v20: string = method5(18 - v7_1.length, v11, 0)("") + v7_1;
    return parse(`${v20.slice(0, 7 + 1)}-${v20.slice(8, 11 + 1)}-${v20.slice(12, 15 + 1)}-${v20.slice(16, 17 + 1)}${v3_1.slice(21, v3_1.length)}`);
}

export function closure5(unitVar: void, v0_1: string): ((arg0: int64) => string) {
    return (v: int64): string => closure6(v0_1, v);
}

export function closure8(unitVar: void, v0_1: string): int64 {
    const v2_1: string = v0_1;
    return toInt64(parse_2(concat(v2_1.slice(0, 7 + 1), v2_1.slice(9, 12 + 1), v2_1.slice(14, 17 + 1), ...v2_1.slice(19, 20 + 1)), 511, false, 64));
}

export function closure9(unitVar: void, v0_1: Date): string {
    return method0(newGuid(), v0_1);
}

export function closure10(unitVar: void, v0_1: int64): string {
    const v6_1: string = newGuid();
    const v10: string = int64ToString(v0_1);
    const v14 = "0";
    const v23: string = method5(18 - v10.length, v14, 0)("") + v10;
    return parse(`${v23.slice(0, 7 + 1)}-${v23.slice(8, 11 + 1)}-${v23.slice(12, 15 + 1)}-${v23.slice(16, 17 + 1)}${v6_1.slice(21, v6_1.length)}`);
}

export function closure12(v0_1: string, v1_1: Date): string {
    return toString(v1_1, (v0_1 === "") ? "M-d-y hh:mm:ss tt" : v0_1);
}

export function closure11(unitVar: void, v0_1: string): ((arg0: Date) => string) {
    return (v: Date): string => closure12(v0_1, v);
}

export function closure13(unitVar: void, v0_1: Date): string {
    return toString(v0_1, "yyyy-MM-ddTHH-mm-ss.fff");
}

export const v0 = (v: string): ((arg0: Date) => string) => closure0(undefined, v);

export function date_time_guid_from_date_time(x: string): ((arg0: Date) => string) {
    return v0(x);
}

export const v1 = (v: string): Date => closure3(undefined, v);

export function date_time_from_guid(x: string): Date {
    return v1(x);
}

export const v2 = (v: string): ((arg0: int64) => string) => closure5(undefined, v);

export function timestamp_guid_from_timestamp(x: string): ((arg0: int64) => string) {
    return v2(x);
}

export const v3 = (v: string): int64 => closure8(undefined, v);

export function timestamp_from_guid(x: string): int64 {
    return v3(x);
}

export const v4 = (v: Date): string => closure9(undefined, v);

export function new_guid_from_date_time(x: Date): string {
    return v4(x);
}

export const v5 = (v: int64): string => closure10(undefined, v);

export function new_guid_from_timestamp(x: int64): string {
    return v5(x);
}

export const v6 = (v: string): ((arg0: Date) => string) => closure11(undefined, v);

export function format(x: string): ((arg0: Date) => string) {
    return v6(x);
}

export const v7 = (v: Date): string => closure13(undefined, v);

export function format_iso8601(x: Date): string {
    return v7(x);
}


