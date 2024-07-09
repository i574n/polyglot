import { Union } from "../../deps/Fable/src/fable-library-ts/Types.js";
import { union_type, string_type, TypeInfo } from "../../deps/Fable/src/fable-library-ts/Reflection.js";
import { value as value_1, Option } from "../../deps/Fable/src/fable-library-ts/Option.js";
import { parse as parse_1, toString } from "../../deps/Fable/src/fable-library-ts/Date.js";
import { int64ToString, defaultOf } from "../../deps/Fable/src/fable-library-ts/Util.js";
import { toString as toString_1, hours } from "../../deps/Fable/src/fable-library-ts/TimeSpan.js";
import { uint8 } from "../../deps/Fable/src/fable-library-ts/Int32.js";
import { newGuid, parse } from "../../deps/Fable/src/fable-library-ts/Guid.js";
import { padLeft, replace } from "../../deps/Fable/src/fable-library-ts/String.js";
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

export function method1(): string {
    return "hh:mm";
}

export function method2(): string {
    return "yyyyMMdd-HHmm-ssff-ffff-f";
}

export function method3(): string {
    return "hhmm";
}

export function method0(v0: string, v1: Date): string {
    let _v4: Option<string> = undefined;
    const v662: string = toString(v1, method2());
    let _v671: Option<any> = undefined;
    const x: any = defaultOf();
    _v671 = x;
    let v711: any;
    if (_v671 == null) {
        throw new Error("base.run_target / _v671=None");
    }
    else {
        v711 = value_1(_v671);
    }
    let _v728: Option<number> = undefined;
    let x_2: number;
    throw new Error(`date_time.get_utc_offset / target: ${US3_US3_3(US2_US2_0())}`);
    _v728 = x_2;
    let v827: number;
    if (_v728 == null) {
        throw new Error("base.run_target / _v728=None");
    }
    else {
        v827 = value_1(_v728);
    }
    const v848: uint8 = (hours(v827) > 0) ? 1 : 0;
    const v849: string = method3();
    let _v852: Option<string> = undefined;
    const x_4: string = toString_1(v827, "c", {});
    _v852 = x_4;
    const v866 = `${v848}${(_v852 == null) ? (() => {
        throw new Error("base.run_target / _v852=None");
    })() : value_1(_v852)}`;
    const v870: string = v0;
    const x_6: string = parse(`${v662}${v866}${v870.slice(v662.length + v866.length, v870.length)}`);
    _v4 = x_6;
    if (_v4 == null) {
        throw new Error("base.run_target / _v4=None");
    }
    else {
        return value_1(_v4);
    }
}

export function closure1(v0: string, v1: Date): string {
    return method0(v0, v1);
}

export function closure0(unitVar: void, v0: string): ((arg0: Date) => string) {
    return (v: Date): string => closure1(v0, v);
}

export function closure5(v0: string, v1: string, v2: string): string {
    return replace(v2, v0, v1);
}

export function closure4(v0: string, v1: string): ((arg0: string) => string) {
    return (v: string): string => closure5(v0, v1, v);
}

export function closure3(unitVar: void, v0: string): ((arg0: string) => ((arg0: string) => string)) {
    return (v: string): ((arg0: string) => string) => closure4(v0, v);
}

export function method4(): ((arg0: string) => ((arg0: string) => ((arg0: string) => string))) {
    return (v: string): ((arg0: string) => ((arg0: string) => string)) => closure3(undefined, v);
}

export function closure2(unitVar: void, v0: string): Date {
    let _v14: Option<Date> = undefined;
    const x: Date = parse_1(method4()("-")("")(v0.slice(undefined, 24 + 1)));
    _v14 = x;
    if (_v14 == null) {
        throw new Error("base.run_target / _v14=None");
    }
    else {
        return value_1(_v14);
    }
}

export function closure7(v0: string, v1: int64): string {
    const v5: string = v0;
    const v24: string = padLeft(int64ToString(v1), 18, "0");
    return parse(`${v24.slice(0, 7 + 1)}-${v24.slice(8, 11 + 1)}-${v24.slice(12, 15 + 1)}-${v24.slice(16, 17 + 1)}${v5.slice(21, v5.length)}`);
}

export function closure6(unitVar: void, v0: string): ((arg0: int64) => string) {
    return (v: int64): string => closure7(v0, v);
}

export function closure8(unitVar: void, v0: string): int64 {
    const v4: string = v0;
    return toInt64(parse_2(`${v4.slice(0, 7 + 1)}${v4.slice(9, 12 + 1)}${v4.slice(14, 17 + 1)}${v4.slice(19, 20 + 1)}`, 511, false, 64));
}

export function closure9(unitVar: void, v0: Date): string {
    return method0(newGuid(), v0);
}

export function closure10(unitVar: void, v0: int64): string {
    const v14: string = newGuid();
    const v33_1: string = padLeft(int64ToString(v0), 18, "0");
    return parse(`${v33_1.slice(0, 7 + 1)}-${v33_1.slice(8, 11 + 1)}-${v33_1.slice(12, 15 + 1)}-${v33_1.slice(16, 17 + 1)}${v14.slice(21, v14.length)}`);
}

export function closure12(v0: string, v1: Date): string {
    return toString(v1, v0);
}

export function closure11(unitVar: void, v0: string): ((arg0: Date) => string) {
    return (v: Date): string => closure12(v0, v);
}

export function closure13(unitVar: void, v0: Date): string {
    return toString(v0, "yyyy-MM-ddTHH-mm-ss.fff");
}

export const v30 = (v: string): ((arg0: Date) => string) => closure0(undefined, v);

export function date_time_guid_from_date_time(x: string): ((arg0: Date) => string) {
    return v30(x);
}

export const v31 = (v: string): Date => closure2(undefined, v);

export function date_time_from_guid(x: string): Date {
    return v31(x);
}

export const v32 = (v: string): ((arg0: int64) => string) => closure6(undefined, v);

export function timestamp_guid_from_timestamp(x: string): ((arg0: int64) => string) {
    return v32(x);
}

export const v33 = (v: string): int64 => closure8(undefined, v);

export function timestamp_from_guid(x: string): int64 {
    return v33(x);
}

export const v34 = (v: Date): string => closure9(undefined, v);

export function new_guid_from_date_time(x: Date): string {
    return v34(x);
}

export const v35 = (v: int64): string => closure10(undefined, v);

export function new_guid_from_timestamp(x: int64): string {
    return v35(x);
}

export const v36 = (v: string): ((arg0: Date) => string) => closure11(undefined, v);

export function format(x: string): ((arg0: Date) => string) {
    return v36(x);
}

export const v37 = (v: Date): string => closure13(undefined, v);

export function format_iso8601(x: Date): string {
    return v37(x);
}


