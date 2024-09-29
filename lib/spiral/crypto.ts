import { compare, IComparable, IEquatable, createAtom } from "../../deps/Fable/src/fable-library-ts/Util.js";
import { value as value_2, map, defaultArg, Option } from "../../deps/Fable/src/fable-library-ts/Option.js";
import { op_Addition, op_Subtraction, toInt64, int64 } from "../../deps/Fable/src/fable-library-ts/BigInt.js";
import { Union, Record } from "../../deps/Fable/src/fable-library-ts/Types.js";
import { parse, uint16, int32 } from "../../deps/Fable/src/fable-library-ts/Int32.js";
import { bool_type, lambda_type, unit_type, string_type, int64_type, union_type, record_type, int32_type, TypeInfo } from "../../deps/Fable/src/fable-library-ts/Reflection.js";
import * as crypto from "crypto";
import { create, toString, now, getTicks } from "../../deps/Fable/src/fable-library-ts/Date.js";
import { milliseconds, seconds, minutes, hours, fromTicks } from "../../deps/Fable/src/fable-library-ts/TimeSpan.js";
import { trimStart, trimEnd, padLeft } from "../../deps/Fable/src/fable-library-ts/String.js";
import { ofSeq, find } from "../../deps/Fable/src/fable-library-ts/Map.js";

export interface ICryptoCreateHash {
    createHash(x: string): any
}

export interface IHashlibSha256 {
    sha256(): any
}

export let TraceState_trace_state = createAtom<Option<[Mut1, Mut2, Mut3, Mut4, Mut5, Option<int64>]>>(undefined);

export interface IOsEnviron {
    environ(): any
}

export class Mut0 extends Record implements IEquatable<Mut0>, IComparable<Mut0> {
    l0: int32;
    constructor(l0: int32) {
        super();
        this.l0 = (l0 | 0);
    }
}

export function Mut0_$reflection(): TypeInfo {
    return record_type("Crypto.Mut0", [], Mut0, () => [["l0", int32_type]]);
}

export type US0_$union = 
    | US0<0>
    | US0<1>
    | US0<2>
    | US0<3>
    | US0<4>

export type US0_$cases = {
    0: ["US0_0", []],
    1: ["US0_1", []],
    2: ["US0_2", []],
    3: ["US0_3", []],
    4: ["US0_4", []]
}

export function US0_US0_0() {
    return new US0<0>(0, []);
}

export function US0_US0_1() {
    return new US0<1>(1, []);
}

export function US0_US0_2() {
    return new US0<2>(2, []);
}

export function US0_US0_3() {
    return new US0<3>(3, []);
}

export function US0_US0_4() {
    return new US0<4>(4, []);
}

export class US0<Tag extends keyof US0_$cases> extends Union<Tag, US0_$cases[Tag][0]> {
    constructor(readonly tag: Tag, readonly fields: US0_$cases[Tag][1]) {
        super();
    }
    cases() {
        return ["US0_0", "US0_1", "US0_2", "US0_3", "US0_4"];
    }
}

export function US0_$reflection(): TypeInfo {
    return union_type("Crypto.US0", [], US0, () => [[], [], [], [], []]);
}

export class Mut1 extends Record implements IEquatable<Mut1>, IComparable<Mut1> {
    l0: int64;
    constructor(l0: int64) {
        super();
        this.l0 = l0;
    }
}

export function Mut1_$reflection(): TypeInfo {
    return record_type("Crypto.Mut1", [], Mut1, () => [["l0", int64_type]]);
}

export class Mut2 extends Record {
    l0: ((arg0: string) => void);
    constructor(l0: ((arg0: string) => void)) {
        super();
        this.l0 = l0;
    }
}

export function Mut2_$reflection(): TypeInfo {
    return record_type("Crypto.Mut2", [], Mut2, () => [["l0", lambda_type(string_type, unit_type)]]);
}

export class Mut3 extends Record implements IEquatable<Mut3>, IComparable<Mut3> {
    l0: boolean;
    constructor(l0: boolean) {
        super();
        this.l0 = l0;
    }
}

export function Mut3_$reflection(): TypeInfo {
    return record_type("Crypto.Mut3", [], Mut3, () => [["l0", bool_type]]);
}

export class Mut4 extends Record implements IEquatable<Mut4>, IComparable<Mut4> {
    l0: string;
    constructor(l0: string) {
        super();
        this.l0 = l0;
    }
}

export function Mut4_$reflection(): TypeInfo {
    return record_type("Crypto.Mut4", [], Mut4, () => [["l0", string_type]]);
}

export class Mut5 extends Record implements IEquatable<Mut5>, IComparable<Mut5> {
    l0: US0_$union;
    constructor(l0: US0_$union) {
        super();
        this.l0 = l0;
    }
}

export function Mut5_$reflection(): TypeInfo {
    return record_type("Crypto.Mut5", [], Mut5, () => [["l0", US0_$reflection()]]);
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
    return union_type("Crypto.US1", [], US1, () => [[["f0_0", string_type]], []]);
}

export type US2_$union = 
    | US2<0>
    | US2<1>

export type US2_$cases = {
    0: ["US2_0", [US0_$union]],
    1: ["US2_1", []]
}

export function US2_US2_0(f0_0: US0_$union) {
    return new US2<0>(0, [f0_0]);
}

export function US2_US2_1() {
    return new US2<1>(1, []);
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
    return union_type("Crypto.US2", [], US2, () => [[["f0_0", US0_$reflection()]], []]);
}

export type US3_$union = 
    | US3<0>
    | US3<1>

export type US3_$cases = {
    0: ["US3_0", [int64]],
    1: ["US3_1", []]
}

export function US3_US3_0(f0_0: int64) {
    return new US3<0>(0, [f0_0]);
}

export function US3_US3_1() {
    return new US3<1>(1, []);
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
    return union_type("Crypto.US3", [], US3, () => [[["f0_0", int64_type]], []]);
}

export function method1(): string {
    return "";
}

export function method2(v0_1: int32, v1_1: Mut0): boolean {
    return v1_1.l0 < v0_1;
}

export function method3(): string {
    return "";
}

export function method0(v0_1: string): string {
    const v126: ICryptoCreateHash = crypto;
    const v129: any = v126.createHash("sha256");
    const v131: any = v129.update(v0_1, 'utf8');
    return v131.digest("hex");
}

export function closure0(unitVar: void, v0_1: string): string {
    return method0(v0_1);
}

export function method5(): string {
    return "TRACE_LEVEL";
}

export function method7(): string {
    return "";
}

export function closure4(unitVar: void, v0_1: string): US1_$union {
    return US1_US1_0(v0_1);
}

export function method8(): ((arg0: string) => US1_$union) {
    return (v: string): US1_$union => closure4(undefined, v);
}

export function method6(v0_1: string): string {
    return process.env[v0_1] ?? "";
}

export function method9(): string {
    return "AUTOMATION";
}

export function closure5(unitVar: void, v0_1: string): void {
}

export function method4(v0_1: US0_$union): [Mut1, Mut2, Mut3, Mut4, Mut5, Option<int64>] {
    let v181: US2_$union, v188: US2_$union, v195: US2_$union, v202: US2_$union;
    const v169: string = method6(method5());
    const v174: US2_$union = ("Verbose" === v169) ? US2_US2_0(US0_US0_0()) : US2_US2_1();
    const _v1 = [(v174.tag === /* US2_0 */ 0) ? US2_US2_0(v174.fields[0]) : ((v181 = (("Debug" === v169) ? US2_US2_0(US0_US0_1()) : US2_US2_1()), (v181.tag === /* US2_0 */ 0) ? US2_US2_0(v181.fields[0]) : ((v188 = (("Info" === v169) ? US2_US2_0(US0_US0_2()) : US2_US2_1()), (v188.tag === /* US2_0 */ 0) ? US2_US2_0(v188.fields[0]) : ((v195 = (("Warning" === v169) ? US2_US2_0(US0_US0_3()) : US2_US2_1()), (v195.tag === /* US2_0 */ 0) ? US2_US2_0(v195.fields[0]) : ((v202 = (("Critical" === v169) ? US2_US2_0(US0_US0_4()) : US2_US2_1()), (v202.tag === /* US2_0 */ 0) ? US2_US2_0(v202.fields[0]) : US2_US2_1())))))))), (method6(method9()) === "True") ? US3_US3_0(getTicks(now())) : US3_US3_1()] as [US2_$union, US3_$union];
    const v352: US3_$union = _v1[1];
    const v351: US2_$union = _v1[0];
    return [new Mut1(1n), new Mut2((v: string): void => {
        closure5(undefined, v);
    }), new Mut3(true), new Mut4(""), new Mut5((v351.tag === /* US2_0 */ 0) ? v351.fields[0] : v0_1), (v352.tag === /* US3_0 */ 0) ? v352.fields[0] : undefined] as [Mut1, Mut2, Mut3, Mut4, Mut5, Option<int64>];
}

export function closure3(unitVar: void, unitVar_1: void): void {
    if (TraceState_trace_state() == null) {
        const patternInput: [Mut1, Mut2, Mut3, Mut4, Mut5, Option<int64>] = method4(US0_US0_0());
        TraceState_trace_state([patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5]] as [Mut1, Mut2, Mut3, Mut4, Mut5, Option<int64>]);
    }
}

export function closure6(unitVar: void, v0_1: int64): US3_$union {
    return US3_US3_0(v0_1);
}

export function method11(): ((arg0: int64) => US3_$union) {
    return (v: int64): US3_$union => closure6(undefined, v);
}

export function method12(): string {
    return "hh:mm:ss";
}

export function method13(): string {
    return "HH:mm:ss";
}

export function method10(v0_1: Mut1, v1_1: Mut2, v2: Mut3, v3: Mut4, v4: Mut5, v5: Option<int64>): string {
    let v181: int64, v191: number;
    const v177: US3_$union = defaultArg(map<int64, US3_$union>(method11(), v5), US3_US3_1());
    return toString((v177.tag === /* US3_0 */ 0) ? ((v181 = v177.fields[0], (v191 = fromTicks(toInt64(op_Subtraction(getTicks(now()), v181))), create(1, 1, 1, hours(v191), minutes(v191), seconds(v191), milliseconds(v191))))) : now(), method13());
}

export function method15(): string {
    return "\u001b[0m";
}

export function method14(): string {
    return ("\u001b[90m" + padLeft("Verbose".toLocaleLowerCase(), 7, " ")) + method15();
}

export function method17(): string {
    return "";
}

export function closure7(v0_1: Mut4, v1_1: string, unitVar: void): void {
    const v3: string = v0_1.l0 + v1_1;
    v0_1.l0 = v3;
}

export function method16(v0_1: int32, v1_1: string, v2: uint16): string {
    const v4: Mut4 = new Mut4(method17());
    let v11: any;
    closure7(v4, `${"{ "}`, undefined);
    v11 = undefined;
    let v20: any;
    closure7(v4, `${"first_letter_code"}`, undefined);
    v20 = undefined;
    let v29: any;
    closure7(v4, `${" = "}`, undefined);
    v29 = undefined;
    let v37: any;
    closure7(v4, `${v0_1}`, undefined);
    v37 = undefined;
    let v46: any;
    closure7(v4, `${"; "}`, undefined);
    v46 = undefined;
    let v55: any;
    closure7(v4, `${"hash_part"}`, undefined);
    v55 = undefined;
    let v63: any;
    closure7(v4, `${" = "}`, undefined);
    v63 = undefined;
    let v71: any;
    closure7(v4, `${v1_1}`, undefined);
    v71 = undefined;
    let v79: any;
    closure7(v4, `${"; "}`, undefined);
    v79 = undefined;
    let v88: any;
    closure7(v4, `${"combined_value"}`, undefined);
    v88 = undefined;
    let v96: any;
    closure7(v4, `${" = "}`, undefined);
    v96 = undefined;
    let v104: any;
    closure7(v4, `${v2}`, undefined);
    v104 = undefined;
    let v113: any;
    closure7(v4, `${" }"}`, undefined);
    v113 = undefined;
    return v4.l0;
}

export function method18(v0_1: string, v1_1: string, v2: int64, v3: string): string {
    return trimEnd(trimStart(`${v0_1} ${v1_1} #${v2} ${"crypto.hash_to_port"} / ${v3}`, ...[]), ...[" ", "/"]);
}

export function closure8(v0_1: Mut1, unitVar: void): void {
    const v2: int64 = toInt64(op_Addition(v0_1.l0, 1n));
    v0_1.l0 = v2;
}

export function closure10(v0_1: string, unitVar: void): void {
    console.log(v0_1);
}

export function closure9(unitVar: void, v0_1: string): void {
    let v3: any;
    closure10(v0_1, undefined);
    v3 = undefined;
}

export function method19(v0_1: string, v1_1: Mut1, v2: Mut2, v3: Mut3, v4: Mut4, v5: Mut5, v6: Option<int64>): void {
    let v9: any;
    closure8(v1_1, undefined);
    v9 = undefined;
    closure9(undefined, v0_1);
    v2.l0(v0_1);
}

export function closure2(v0_1: int32, v1_1: string, v2: uint16, unitVar: void): void {
    const v4 = (): void => {
        closure3(undefined, undefined);
    };
    let v5: any;
    v4();
    v5 = undefined;
    const patternInput: [Mut1, Mut2, Mut3, Mut4, Mut5, Option<int64>] = value_2(TraceState_trace_state());
    const v37: US0_$union = patternInput[4].l0;
    if ((patternInput[2].l0 === false) ? false : (0 >= find<US0_$union, int32>(v37, ofSeq([[US0_US0_0(), 0] as [US0_$union, int32], [US0_US0_1(), 1] as [US0_$union, int32], [US0_US0_2(), 2] as [US0_$union, int32], [US0_US0_3(), 3] as [US0_$union, int32], [US0_US0_4(), 4] as [US0_$union, int32]], {
        Compare: compare,
    })))) {
        let v44: any;
        v4();
        v44 = undefined;
        const patternInput_1: [Mut1, Mut2, Mut3, Mut4, Mut5, Option<int64>] = value_2(TraceState_trace_state());
        const v58: Mut1 = patternInput_1[0];
        const v80: string = method18(method10(v58, patternInput_1[1], patternInput_1[2], patternInput_1[3], patternInput_1[4], patternInput_1[5]), method14(), v58.l0, method16(v0_1, v1_1, v2));
        let v82: any;
        v4();
        v82 = undefined;
        const patternInput_2: [Mut1, Mut2, Mut3, Mut4, Mut5, Option<int64>] = value_2(TraceState_trace_state());
        method19(v80, patternInput_2[0], patternInput_2[1], patternInput_2[2], patternInput_2[3], patternInput_2[4], patternInput_2[5]);
    }
}

export function closure1(unitVar: void, v0_1: string): uint16 {
    let v3: int32;
    const value: string = v0_1[0];
    v3 = ~~value.charCodeAt(0);
    const v4: string = v0_1.slice(0, 7 + 1);
    let v8: uint16;
    const value_1: int32 = (parse(v4, 511, false, 32, 16) + v3) | 0;
    v8 = (value_1 & 0xFFFF);
    let v11: any;
    closure2(v3, v4, v8, undefined);
    v11 = undefined;
    return (v8 % 48128) + 1024;
}

export const v0 = (v: string): string => closure0(undefined, v);

export function hash_text(x: string): string {
    return v0(x);
}

export const v1 = (v: string): uint16 => closure1(undefined, v);

export function hash_to_port(x: string): uint16 {
    return v1(x);
}


