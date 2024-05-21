import { FSharpRef, Union } from "../../deps/Fable/src/fable-library-ts/Types.js";
import { union_type, string_type, TypeInfo } from "../../deps/Fable/src/fable-library-ts/Reflection.js";
import { value as value_1, Option } from "../../deps/Fable/src/fable-library-ts/Option.js";
import { int64ToString, defaultOf } from "../../deps/Fable/src/fable-library-ts/Util.js";
import { padLeft, replace } from "../../deps/Fable/src/fable-library-ts/String.js";
import { toString, parseExact } from "../../deps/Fable/src/fable-library-ts/Date.js";
import { newGuid, parse } from "../../deps/Fable/src/fable-library-ts/Guid.js";
import { toInt64, int64 } from "../../deps/Fable/src/fable-library-ts/BigInt.js";
import { parse as parse_1 } from "../../deps/Fable/src/fable-library-ts/Long.js";

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

export function US0__get_IsUS0_0(this$: FSharpRef<US0_$union>, unitArg: void): boolean {
    if ((this$ as any)['tag'] === 0) {
        return true;
    }
    else {
        return false;
    }
}

export function US0__get_IsUS0_1(this$: FSharpRef<US0_$union>, unitArg: void): boolean {
    if ((this$ as any)['tag'] === 1) {
        return true;
    }
    else {
        return false;
    }
}

export function US1__get_IsUS1_0(this$: FSharpRef<US1_$union>, unitArg: void): boolean {
    if ((this$ as any)['tag'] === 0) {
        return true;
    }
    else {
        return false;
    }
}

export function US1__get_IsUS1_1(this$: FSharpRef<US1_$union>, unitArg: void): boolean {
    if ((this$ as any)['tag'] === 1) {
        return true;
    }
    else {
        return false;
    }
}

export function method1(v0_1: any): any {
    return v0_1;
}

export function method2(v0_1: any): any {
    return v0_1;
}

export function method3(): string {
    return "yyyyMMdd-HHmm-ssff-ffff-f";
}

export function method4(): string {
    return "hhmm";
}

export function method0(v0_1: string, v1_1: Date): string {
    let _v2: Option<string> = undefined;
    const x: string = defaultOf();
    _v2 = x;
    if (_v2 == null) {
        throw new Error("base.run_target / _v2=None");
    }
    else {
        return value_1(_v2);
    }
}

export function closure1(v0_1: string, v1_1: Date): string {
    return method0(v0_1, v1_1);
}

export function closure0(unitVar: void, v0_1: string): ((arg0: Date) => string) {
    return (v: Date): string => closure1(v0_1, v);
}

export function closure5(v0_1: string, v1_1: string, v2_1: string): string {
    return replace(v2_1, v0_1, v1_1);
}

export function closure4(v0_1: string, v1_1: string): ((arg0: string) => string) {
    return (v: string): string => closure5(v0_1, v1_1, v);
}

export function closure3(unitVar: void, v0_1: string): ((arg0: string) => ((arg0: string) => string)) {
    return (v: string): ((arg0: string) => string) => closure4(v0_1, v);
}

export function method5(): ((arg0: string) => ((arg0: string) => ((arg0: string) => string))) {
    return (v: string): ((arg0: string) => ((arg0: string) => string)) => closure3(undefined, v);
}

export function closure2(unitVar: void, v0_1: string): Date {
    let _v4: Option<Date> = undefined;
    const x: Date = parseExact(method5()("-")("")(v0_1.slice(undefined, 24 + 1)), "yyyyMMddHHmmssfffffff", defaultOf());
    _v4 = x;
    if (_v4 == null) {
        throw new Error("base.run_target / _v4=None");
    }
    else {
        return value_1(_v4);
    }
}

export function closure7(v0_1: string, v1_1: int64): string {
    const v3_1: string = v0_1;
    const v6_1: string = padLeft(int64ToString(v1_1), 18, "0");
    return parse(`${v6_1.slice(0, 7 + 1)}-${v6_1.slice(8, 11 + 1)}-${v6_1.slice(12, 15 + 1)}-${v6_1.slice(16, 17 + 1)}${v3_1.slice(21, v3_1.length)}`);
}

export function closure6(unitVar: void, v0_1: string): ((arg0: int64) => string) {
    return (v: int64): string => closure7(v0_1, v);
}

export function closure8(unitVar: void, v0_1: string): int64 {
    const v2_1: string = v0_1;
    return toInt64(parse_1(`${v2_1.slice(0, 7 + 1)}${v2_1.slice(9, 12 + 1)}${v2_1.slice(14, 17 + 1)}${v2_1.slice(19, 20 + 1)}`, 511, false, 64));
}

export function closure9(unitVar: void, v0_1: Date): string {
    return method0(newGuid(), v0_1);
}

export function closure10(unitVar: void, v0_1: int64): string {
    const v4_1: string = newGuid();
    const v7_1: string = padLeft(int64ToString(v0_1), 18, "0");
    return parse(`${v7_1.slice(0, 7 + 1)}-${v7_1.slice(8, 11 + 1)}-${v7_1.slice(12, 15 + 1)}-${v7_1.slice(16, 17 + 1)}${v4_1.slice(21, v4_1.length)}`);
}

export function closure12(v0_1: string, v1_1: Date): string {
    return toString(v1_1, v0_1);
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

export const v1 = (v: string): Date => closure2(undefined, v);

export function date_time_from_guid(x: string): Date {
    return v1(x);
}

export const v2 = (v: string): ((arg0: int64) => string) => closure6(undefined, v);

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


