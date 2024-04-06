import { parseExact, toString } from "../../deps/Fable/src/fable-library-ts/Date.js";
import { newGuid, parse } from "../../deps/Fable/src/fable-library-ts/Guid.js";
import { padLeft, replace } from "../../deps/Fable/src/fable-library-ts/String.js";
import { value, Option } from "../../deps/Fable/src/fable-library-ts/Option.js";
import { int64ToString, defaultOf } from "../../deps/Fable/src/fable-library-ts/Util.js";
import { toInt64, int64 } from "../../deps/Fable/src/fable-library-ts/BigInt.js";
import { parse as parse_1 } from "../../deps/Fable/src/fable-library-ts/Long.js";

export function closure1(v0_1: string, v1_1: Date): string {
    const v3_1: string = v0_1;
    const v4_1: string = toString(v1_1, "yyyyMMdd-HHmm-ssff-ffff-f");
    return parse(`${v4_1}${v3_1.slice(v4_1.length, v3_1.length)}`);
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

export function method0(): ((arg0: string) => ((arg0: string) => ((arg0: string) => string))) {
    return (v: string): ((arg0: string) => ((arg0: string) => string)) => closure3(void 0, v);
}

export function closure2(unitVar: void, v0_1: string): Date {
    let _v4: Option<Date> = void 0;
    const x: Date = parseExact(method0()("-")("")(v0_1.slice(void 0, 24 + 1)), "yyyyMMddHHmmssfffffff", defaultOf());
    _v4 = x;
    return value(_v4);
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
    const v3_1: string = newGuid();
    const v4_1: string = toString(v0_1, "yyyyMMdd-HHmm-ssff-ffff-f");
    return parse(`${v4_1}${v3_1.slice(v4_1.length, v3_1.length)}`);
}

export function closure10(unitVar: void, v0_1: int64): string {
    const v3_1: string = newGuid();
    const v6_1: string = padLeft(int64ToString(v0_1), 18, "0");
    return parse(`${v6_1.slice(0, 7 + 1)}-${v6_1.slice(8, 11 + 1)}-${v6_1.slice(12, 15 + 1)}-${v6_1.slice(16, 17 + 1)}${v3_1.slice(21, v3_1.length)}`);
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

export const v0 = (v: string): ((arg0: Date) => string) => closure0(void 0, v);

export function date_time_guid_from_date_time(x: string): ((arg0: Date) => string) {
    return v0(x);
}

export const v1 = (v: string): Date => closure2(void 0, v);

export function date_time_from_guid(x: string): Date {
    return v1(x);
}

export const v2 = (v: string): ((arg0: int64) => string) => closure6(void 0, v);

export function timestamp_guid_from_timestamp(x: string): ((arg0: int64) => string) {
    return v2(x);
}

export const v3 = (v: string): int64 => closure8(void 0, v);

export function timestamp_from_guid(x: string): int64 {
    return v3(x);
}

export const v4 = (v: Date): string => closure9(void 0, v);

export function new_guid_from_date_time(x: Date): string {
    return v4(x);
}

export const v5 = (v: int64): string => closure10(void 0, v);

export function new_guid_from_timestamp(x: int64): string {
    return v5(x);
}

export const v6 = (v: string): ((arg0: Date) => string) => closure11(void 0, v);

export function format(x: string): ((arg0: Date) => string) {
    return v6(x);
}

export const v7 = (v: Date): string => closure13(void 0, v);

export function format_iso8601(x: Date): string {
    return v7(x);
}


