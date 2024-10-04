import { compare, IComparable, IEquatable, createAtom } from "../../deps/Fable/src/fable-library-ts/Util.js";
import { map, defaultArg, value as value_1, Option } from "../../deps/Fable/src/fable-library-ts/Option.js";
import { op_Addition, op_Subtraction, toInt64, int64 } from "../../deps/Fable/src/fable-library-ts/BigInt.js";
import { Record, Union } from "../../deps/Fable/src/fable-library-ts/Types.js";
import { bool_type, lambda_type, unit_type, string_type, record_type, int64_type, union_type, TypeInfo } from "../../deps/Fable/src/fable-library-ts/Reflection.js";
import { create, toString, now, getTicks } from "../../deps/Fable/src/fable-library-ts/Date.js";
import { ofSeq, find } from "../../deps/Fable/src/fable-library-ts/Map.js";
import { int32 } from "../../deps/Fable/src/fable-library-ts/Int32.js";
import { milliseconds, seconds, minutes, hours, fromTicks } from "../../deps/Fable/src/fable-library-ts/TimeSpan.js";
import { trimStart, trimEnd } from "../../deps/Fable/src/fable-library-ts/String.js";

export let TraceState_trace_state = createAtom<Option<[Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>]>>(undefined);

export interface IOsEnviron {
    environ(): any
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
    return union_type("Trace.US0", [], US0, () => [[], [], [], [], []]);
}

export class Mut0 extends Record implements IEquatable<Mut0>, IComparable<Mut0> {
    l0: int64;
    constructor(l0: int64) {
        super();
        this.l0 = l0;
    }
}

export function Mut0_$reflection(): TypeInfo {
    return record_type("Trace.Mut0", [], Mut0, () => [["l0", int64_type]]);
}

export class Mut1 extends Record {
    l0: ((arg0: string) => void);
    constructor(l0: ((arg0: string) => void)) {
        super();
        this.l0 = l0;
    }
}

export function Mut1_$reflection(): TypeInfo {
    return record_type("Trace.Mut1", [], Mut1, () => [["l0", lambda_type(string_type, unit_type)]]);
}

export class Mut2 extends Record implements IEquatable<Mut2>, IComparable<Mut2> {
    l0: boolean;
    constructor(l0: boolean) {
        super();
        this.l0 = l0;
    }
}

export function Mut2_$reflection(): TypeInfo {
    return record_type("Trace.Mut2", [], Mut2, () => [["l0", bool_type]]);
}

export class Mut3 extends Record implements IEquatable<Mut3>, IComparable<Mut3> {
    l0: string;
    constructor(l0: string) {
        super();
        this.l0 = l0;
    }
}

export function Mut3_$reflection(): TypeInfo {
    return record_type("Trace.Mut3", [], Mut3, () => [["l0", string_type]]);
}

export class Mut4 extends Record implements IEquatable<Mut4>, IComparable<Mut4> {
    l0: US0_$union;
    constructor(l0: US0_$union) {
        super();
        this.l0 = l0;
    }
}

export function Mut4_$reflection(): TypeInfo {
    return record_type("Trace.Mut4", [], Mut4, () => [["l0", US0_$reflection()]]);
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
    return union_type("Trace.US1", [], US1, () => [[["f0_0", string_type]], []]);
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
    return union_type("Trace.US2", [], US2, () => [[["f0_0", US0_$reflection()]], []]);
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
    return union_type("Trace.US3", [], US3, () => [[["f0_0", int64_type]], []]);
}

export function method1(): string {
    return "TRACE_LEVEL";
}

export function method3(): string {
    return "";
}

export function closure1(unitVar: void, v0_1: string): US1_$union {
    return US1_US1_0(v0_1);
}

export function method4(): ((arg0: string) => US1_$union) {
    return (v: string): US1_$union => closure1(undefined, v);
}

export function method2(v0_1: string): string {
    return process.env[v0_1] ?? "";
}

export function method5(): string {
    return "AUTOMATION";
}

export function closure2(unitVar: void, v0_1: string): void {
}

export function method0(v0_1: US0_$union): [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] {
    let v181: US2_$union, v188: US2_$union, v195: US2_$union, v202: US2_$union;
    const v169: string = method2(method1());
    const v174: US2_$union = ("Verbose" === v169) ? US2_US2_0(US0_US0_0()) : US2_US2_1();
    const _v1 = [(v174.tag === /* US2_0 */ 0) ? US2_US2_0(v174.fields[0]) : ((v181 = (("Debug" === v169) ? US2_US2_0(US0_US0_1()) : US2_US2_1()), (v181.tag === /* US2_0 */ 0) ? US2_US2_0(v181.fields[0]) : ((v188 = (("Info" === v169) ? US2_US2_0(US0_US0_2()) : US2_US2_1()), (v188.tag === /* US2_0 */ 0) ? US2_US2_0(v188.fields[0]) : ((v195 = (("Warning" === v169) ? US2_US2_0(US0_US0_3()) : US2_US2_1()), (v195.tag === /* US2_0 */ 0) ? US2_US2_0(v195.fields[0]) : ((v202 = (("Critical" === v169) ? US2_US2_0(US0_US0_4()) : US2_US2_1()), (v202.tag === /* US2_0 */ 0) ? US2_US2_0(v202.fields[0]) : US2_US2_1())))))))), (method2(method5()) === "True") ? US3_US3_0(getTicks(now())) : US3_US3_1()] as [US2_$union, US3_$union];
    const v352: US3_$union = _v1[1];
    const v351: US2_$union = _v1[0];
    return [new Mut0(1n), new Mut1((v: string): void => {
        closure2(undefined, v);
    }), new Mut2(true), new Mut3(""), new Mut4((v351.tag === /* US2_0 */ 0) ? v351.fields[0] : v0_1), (v352.tag === /* US3_0 */ 0) ? v352.fields[0] : undefined] as [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>];
}

export function closure0(unitVar: void, unitVar_1: void): void {
    if (TraceState_trace_state() == null) {
        const patternInput: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = method0(US0_US0_0());
        TraceState_trace_state([patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5]] as [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>]);
    }
}

export function method6(v0_1: US0_$union): boolean {
    let v3: any;
    closure0(undefined, undefined);
    v3 = undefined;
    const patternInput: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_1(TraceState_trace_state());
    const v35: US0_$union = patternInput[4].l0;
    if (patternInput[2].l0 === false) {
        return false;
    }
    else {
        return find<US0_$union, int32>(v0_1, ofSeq([[US0_US0_0(), 0] as [US0_$union, int32], [US0_US0_1(), 1] as [US0_$union, int32], [US0_US0_2(), 2] as [US0_$union, int32], [US0_US0_3(), 3] as [US0_$union, int32], [US0_US0_4(), 4] as [US0_$union, int32]], {
            Compare: compare,
        })) >= find<US0_$union, int32>(v35, ofSeq([[US0_US0_0(), 0] as [US0_$union, int32], [US0_US0_1(), 1] as [US0_$union, int32], [US0_US0_2(), 2] as [US0_$union, int32], [US0_US0_3(), 3] as [US0_$union, int32], [US0_US0_4(), 4] as [US0_$union, int32]], {
            Compare: compare,
        }));
    }
}

export function closure7(unitVar: void, v0_1: int64): US3_$union {
    return US3_US3_0(v0_1);
}

export function method8(): ((arg0: int64) => US3_$union) {
    return (v: int64): US3_$union => closure7(undefined, v);
}

export function method9(): string {
    return "hh:mm:ss";
}

export function method10(): string {
    return "HH:mm:ss";
}

export function method7(v0_1: Mut0, v1_1: Mut1, v2_1: Mut2, v3: Mut3, v4: Mut4, v5: Option<int64>): string {
    let v181: int64, v191: number;
    const v177: US3_$union = defaultArg(map<int64, US3_$union>(method8(), v5), US3_US3_1());
    return toString((v177.tag === /* US3_0 */ 0) ? ((v181 = v177.fields[0], (v191 = fromTicks(toInt64(op_Subtraction(getTicks(now()), v181))), create(1, 1, 1, hours(v191), minutes(v191), seconds(v191), milliseconds(v191))))) : now(), method10());
}

export function method13(): string {
    return "";
}

export function closure8(v0_1: Mut3, v1_1: string, unitVar: void): void {
    const v3: string = v0_1.l0 + v1_1;
    v0_1.l0 = v3;
}

export function method12(v0_1: string): string {
    const v2_1: Mut3 = new Mut3(method13());
    let v8: any;
    closure8(v2_1, `${v0_1}`, undefined);
    v8 = undefined;
    return v2_1.l0;
}

export function method14(): string {
    return "\u001b[0m";
}

export function method11(v0_1: US0_$union): string {
    const v5: US1_$union = (v0_1.tag === /* US0_0 */ 0) ? US1_US1_0("Verbose") : US1_US1_1();
    let v46: US1_$union;
    if (v5.tag === /* US1_0 */ 0) {
        v46 = US1_US1_0(v5.fields[0]);
    }
    else {
        const v12: US1_$union = (v0_1.tag === /* US0_1 */ 1) ? US1_US1_0("Debug") : US1_US1_1();
        if (v12.tag === /* US1_0 */ 0) {
            v46 = US1_US1_0(v12.fields[0]);
        }
        else {
            const v19: US1_$union = (v0_1.tag === /* US0_2 */ 2) ? US1_US1_0("Info") : US1_US1_1();
            if (v19.tag === /* US1_0 */ 0) {
                v46 = US1_US1_0(v19.fields[0]);
            }
            else {
                const v26: US1_$union = (v0_1.tag === /* US0_3 */ 3) ? US1_US1_0("Warning") : US1_US1_1();
                if (v26.tag === /* US1_0 */ 0) {
                    v46 = US1_US1_0(v26.fields[0]);
                }
                else {
                    const v33: US1_$union = (v0_1.tag === /* US0_4 */ 4) ? US1_US1_0("Critical") : US1_US1_1();
                    v46 = ((v33.tag === /* US1_0 */ 0) ? US1_US1_0(v33.fields[0]) : US1_US1_1());
                }
            }
        }
    }
    let v50: string;
    if (v46.tag === /* US1_0 */ 0) {
        v50 = v46.fields[0];
    }
    else {
        throw new Error("Option does not have a value.");
    }
    const v52: string = v50.toLocaleLowerCase();
    const v56: string = method12(v52[0]);
    return (((v0_1.tag === /* US0_1 */ 1) ? "\u001b[94m" : ((v0_1.tag === /* US0_2 */ 2) ? "\u001b[92m" : ((v0_1.tag === /* US0_0 */ 0) ? "\u001b[90m" : ((v0_1.tag === /* US0_3 */ 3) ? "\u001b[93m" : "\u001b[91m")))) + v56) + method14();
}

export function method16(v0_1: string): string {
    const v2_1: Mut3 = new Mut3(method13());
    let v8: any;
    closure8(v2_1, `${v0_1}`, undefined);
    v8 = undefined;
    return v2_1.l0;
}

export function method17(v0_1: string): string {
    return trimEnd(trimStart(v0_1, ...[]), ...[" ", "/"]);
}

export function method15(v0_1: Mut0, v1_1: Mut1, v2_1: Mut2, v3: Mut3, v4: Mut4, v5: Option<int64>, v6: string, v7: string, v8: string, v9: string): string {
    const v10: string = method16(v9);
    return method17(`${v6} ${v7} #${v0_1.l0} ${v8} / ${v10}`);
}

export function closure9(v0_1: Mut0, unitVar: void): void {
    const v2_1: int64 = toInt64(op_Addition(v0_1.l0, 1n));
    v0_1.l0 = v2_1;
}

export function closure11(v0_1: string, unitVar: void): void {
    console.log(v0_1);
}

export function closure10(unitVar: void, v0_1: string): void {
    let v3: any;
    closure11(v0_1, undefined);
    v3 = undefined;
}

export function method18(v0_1: string): void {
    let v3: any;
    closure0(undefined, undefined);
    v3 = undefined;
    const patternInput: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_1(TraceState_trace_state());
    let v37: any;
    closure9(patternInput[0], undefined);
    v37 = undefined;
    closure10(undefined, v0_1);
    patternInput[1].l0(v0_1);
}

export function closure6(v0_1: US0_$union, v1_1: (() => string), v2_1: (() => string), unitVar: void): void {
    if (method6(v0_1)) {
        let v6: any;
        closure0(undefined, undefined);
        v6 = undefined;
        const patternInput: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_1(TraceState_trace_state());
        const v25: Option<int64> = patternInput[5];
        const v24: Mut4 = patternInput[4];
        const v23: Mut3 = patternInput[3];
        const v22: Mut2 = patternInput[2];
        const v21: Mut1 = patternInput[1];
        const v20: Mut0 = patternInput[0];
        const v38: string = method7(v20, v21, v22, v23, v24, v25);
        const v39: string = method11(v0_1);
        const v40: string = v1_1();
        method18((v40 === "") ? "" : method15(v20, v21, v22, v23, v24, v25, v38, v39, v40, v2_1()));
    }
}

export function closure5(v0_1: US0_$union, v1_1: (() => string), v2_1: (() => string)): void {
    let v5: any;
    closure6(v0_1, v1_1, v2_1, undefined);
    v5 = undefined;
}

export function closure4(v0_1: US0_$union, v1_1: (() => string)): ((arg0: (() => string)) => void) {
    return (v: (() => string)): void => {
        closure5(v0_1, v1_1, v);
    };
}

export function closure3(unitVar: void, v0_1: US0_$union): ((arg0: (() => string)) => ((arg0: (() => string)) => void)) {
    return (v: (() => string)): ((arg0: (() => string)) => void) => closure4(v0_1, v);
}

export const v0: any = undefined;

export const v1 = (): void => {
    closure0(undefined, undefined);
};

export const v2: any = (v1(), v0);

export const v16 = (v: US0_$union): ((arg0: (() => string)) => ((arg0: (() => string)) => void)) => closure3(undefined, v);

export function trace(x: US0_$union): ((arg0: (() => string)) => ((arg0: (() => string)) => void)) {
    return v16(x);
}


