import { compare, IComparable, IEquatable, createAtom } from "../../deps/Fable/src/fable-library-ts/Util.js";
import { defaultArg, value as value_2, Option } from "../../deps/Fable/src/fable-library-ts/Option.js";
import { op_Subtraction, op_Addition, toInt64, int64 } from "../../deps/Fable/src/fable-library-ts/BigInt.js";
import { FSharpRef, Union, Record } from "../../deps/Fable/src/fable-library-ts/Types.js";
import { parse, uint16, int32 } from "../../deps/Fable/src/fable-library-ts/Int32.js";
import { bool_type, lambda_type, unit_type, string_type, int64_type, union_type, record_type, int32_type, TypeInfo } from "../../deps/Fable/src/fable-library-ts/Reflection.js";
import * as crypto from "crypto";
import { create, toString, now, getTicks } from "../../deps/Fable/src/fable-library-ts/Date.js";
import { ofSeq, find } from "../../deps/Fable/src/fable-library-ts/Map.js";
import { milliseconds, seconds, minutes, hours, fromTicks } from "../../deps/Fable/src/fable-library-ts/TimeSpan.js";
import { trimStart, trimEnd, padLeft } from "../../deps/Fable/src/fable-library-ts/String.js";

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
    const v104: ICryptoCreateHash = crypto;
    const v107: any = v104.createHash("sha256");
    const v109: any = v107.update(v0_1, 'utf8');
    return v109.digest("hex");
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

export function closure4(v0_1: FSharpRef<Option<US1_$union>>, v1_1: Option<US1_$union>): FSharpRef<Option<US1_$union>> {
    v0_1.contents = v1_1;
    return v0_1;
}

export function closure5(v0_1: Option<string>, v1_1: ((arg0: Option<US1_$union>) => FSharpRef<Option<US1_$union>>), unitVar: void): void {
    let x: string;
    v1_1((v0_1 == null) ? undefined : ((x = value_2(v0_1), ((): US1_$union => US1_US1_0(x))())));
}

export function method6(v0_1: string): string {
    return process.env[v0_1] ?? "";
}

export function method8(): string {
    return "AUTOMATION";
}

export function closure6(unitVar: void, v0_1: string): void {
}

export function method4(v0_1: US0_$union): [Mut1, Mut2, Mut3, Mut4, Mut5, Option<int64>] {
    let v124: US2_$union, v131: US2_$union, v138: US2_$union, v145: US2_$union;
    const v112: string = method6(method5());
    const v117: US2_$union = ("Verbose" === v112) ? US2_US2_0(US0_US0_0()) : US2_US2_1();
    const _v1 = [(v117.tag === /* US2_0 */ 0) ? US2_US2_0(v117.fields[0]) : ((v124 = (("Debug" === v112) ? US2_US2_0(US0_US0_1()) : US2_US2_1()), (v124.tag === /* US2_0 */ 0) ? US2_US2_0(v124.fields[0]) : ((v131 = (("Info" === v112) ? US2_US2_0(US0_US0_2()) : US2_US2_1()), (v131.tag === /* US2_0 */ 0) ? US2_US2_0(v131.fields[0]) : ((v138 = (("Warning" === v112) ? US2_US2_0(US0_US0_3()) : US2_US2_1()), (v138.tag === /* US2_0 */ 0) ? US2_US2_0(v138.fields[0]) : ((v145 = (("Critical" === v112) ? US2_US2_0(US0_US0_4()) : US2_US2_1()), (v145.tag === /* US2_0 */ 0) ? US2_US2_0(v145.fields[0]) : US2_US2_1())))))))), (method6(method8()) === "True") ? US3_US3_0(getTicks(now())) : US3_US3_1()] as [US2_$union, US3_$union];
    const v295: US3_$union = _v1[1];
    const v294: US2_$union = _v1[0];
    return [new Mut1(0n), new Mut2((v: string): void => {
        closure6(undefined, v);
    }), new Mut3(true), new Mut4(""), new Mut5((v294.tag === /* US2_0 */ 0) ? v294.fields[0] : v0_1), (v295.tag === /* US3_0 */ 0) ? v295.fields[0] : undefined] as [Mut1, Mut2, Mut3, Mut4, Mut5, Option<int64>];
}

export function closure3(unitVar: void, unitVar_1: void): void {
    if (TraceState_trace_state() == null) {
        const patternInput: [Mut1, Mut2, Mut3, Mut4, Mut5, Option<int64>] = method4(US0_US0_0());
        TraceState_trace_state([patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5]] as [Mut1, Mut2, Mut3, Mut4, Mut5, Option<int64>]);
    }
}

export function closure7(v0_1: Mut1, unitVar: void): void {
    const v2: int64 = toInt64(op_Addition(v0_1.l0, 1n));
    v0_1.l0 = v2;
}

export function closure8(v0_1: FSharpRef<Option<US3_$union>>, v1_1: Option<US3_$union>): FSharpRef<Option<US3_$union>> {
    v0_1.contents = v1_1;
    return v0_1;
}

export function closure9(v0_1: Option<int64>, v1_1: ((arg0: Option<US3_$union>) => FSharpRef<Option<US3_$union>>), unitVar: void): void {
    let x: int64;
    v1_1((v0_1 == null) ? undefined : ((x = value_2(v0_1), ((): US3_$union => US3_US3_0(x))())));
}

export function method9(): string {
    return "hh:mm:ss";
}

export function method10(): string {
    return "HH:mm:ss";
}

export function method11(): string {
    return "\u001b[0m";
}

export function method12(): string {
    return "";
}

export function closure10(v0_1: Mut4, v1_1: string, unitVar: void): void {
    const v3: string = v0_1.l0 + v1_1;
    v0_1.l0 = v3;
}

export function closure12(v0_1: string, unitVar: void): void {
    console.log(v0_1);
}

export function closure11(unitVar: void, v0_1: string): void {
    let v3: any;
    closure12(v0_1, undefined);
    v3 = undefined;
}

export function closure2(v0_1: int32, v1_1: string, v2: uint16, unitVar: void): void {
    let v317: int64, v327: number;
    const v4 = (): void => {
        closure3(undefined, undefined);
    };
    let v5: any;
    v4();
    v5 = undefined;
    const patternInput: [Mut1, Mut2, Mut3, Mut4, Mut5, Option<int64>] = value_2(TraceState_trace_state());
    let v38: any;
    v4();
    v38 = undefined;
    const patternInput_1: [Mut1, Mut2, Mut3, Mut4, Mut5, Option<int64>] = value_2(TraceState_trace_state());
    const v70: US0_$union = patternInput_1[4].l0;
    if ((patternInput_1[2].l0 === false) ? false : (0 >= find<US0_$union, int32>(v70, ofSeq([[US0_US0_0(), 0] as [US0_$union, int32], [US0_US0_1(), 1] as [US0_$union, int32], [US0_US0_2(), 2] as [US0_$union, int32], [US0_US0_3(), 3] as [US0_$union, int32], [US0_US0_4(), 4] as [US0_$union, int32]], {
        Compare: compare,
    })))) {
        let v78: any;
        closure7(patternInput[0], undefined);
        v78 = undefined;
        let v82: any;
        v4();
        v82 = undefined;
        const patternInput_2: [Mut1, Mut2, Mut3, Mut4, Mut5, Option<int64>] = value_2(TraceState_trace_state());
        const _v293: FSharpRef<Option<US3_$union>> = new FSharpRef<Option<US3_$union>>(undefined);
        let v298: any;
        closure9(patternInput_2[5], (v: Option<US3_$union>): FSharpRef<Option<US3_$union>> => closure8(_v293, v), undefined);
        v298 = undefined;
        const v313: US3_$union = defaultArg(_v293.contents, US3_US3_1());
        const v358: string = toString((v313.tag === /* US3_0 */ 0) ? ((v317 = v313.fields[0], (v327 = fromTicks(toInt64(op_Subtraction(getTicks(now()), v317))), create(1, 1, 1, hours(v327), minutes(v327), seconds(v327), milliseconds(v327))))) : now(), method10());
        const v623: string = ("\u001b[90m" + padLeft("Verbose".toLocaleLowerCase(), 7, " ")) + method11();
        const v638: int64 = patternInput_2[0].l0;
        const v640: Mut4 = new Mut4(method12());
        let v647: any;
        closure10(v640, `${"{ "}`, undefined);
        v647 = undefined;
        let v656: any;
        closure10(v640, `${"first_letter_code"}`, undefined);
        v656 = undefined;
        let v665: any;
        closure10(v640, `${" = "}`, undefined);
        v665 = undefined;
        let v673: any;
        closure10(v640, `${v0_1}`, undefined);
        v673 = undefined;
        let v682: any;
        closure10(v640, `${"; "}`, undefined);
        v682 = undefined;
        let v691: any;
        closure10(v640, `${"hash_part"}`, undefined);
        v691 = undefined;
        let v699: any;
        closure10(v640, `${" = "}`, undefined);
        v699 = undefined;
        let v707: any;
        closure10(v640, `${v1_1}`, undefined);
        v707 = undefined;
        let v715: any;
        closure10(v640, `${"; "}`, undefined);
        v715 = undefined;
        let v724: any;
        closure10(v640, `${"combined_value"}`, undefined);
        v724 = undefined;
        let v732: any;
        closure10(v640, `${" = "}`, undefined);
        v732 = undefined;
        let v740: any;
        closure10(v640, `${v2}`, undefined);
        v740 = undefined;
        let v749: any;
        closure10(v640, `${" }"}`, undefined);
        v749 = undefined;
        const v791: string = trimEnd(trimStart(`${v358} ${v623} #${v638} ${"crypto.hash_to_port"} / ${v640.l0}`, ...[]), ...[" ", "/"]);
        closure11(undefined, v791);
        patternInput[1].l0(v791);
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


