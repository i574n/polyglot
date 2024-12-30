import { compare, IComparable, IEquatable, createAtom } from "../../deps/Fable/src/fable-library-ts/Util.js";
import { map, defaultArg, value as value_1, Option } from "../../deps/Fable/src/fable-library-ts/Option.js";
import { op_Addition, op_Subtraction, fromInt64, toInt64, int64 } from "../../deps/Fable/src/fable-library-ts/BigInt.js";
import { Record, Union } from "../../deps/Fable/src/fable-library-ts/Types.js";
import { bool_type, lambda_type, unit_type, string_type, record_type, int64_type, union_type, TypeInfo } from "../../deps/Fable/src/fable-library-ts/Reflection.js";
import { toString, create, now, getTicks } from "../../deps/Fable/src/fable-library-ts/Date.js";
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
    0: ["US1_0", [US0_$union]],
    1: ["US1_1", []]
}

export function US1_US1_0(f0_0: US0_$union) {
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
    return union_type("Trace.US1", [], US1, () => [[["f0_0", US0_$reflection()]], []]);
}

export type US2_$union = 
    | US2<0>
    | US2<1>

export type US2_$cases = {
    0: ["US2_0", [int64]],
    1: ["US2_1", []]
}

export function US2_US2_0(f0_0: int64) {
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
    return union_type("Trace.US2", [], US2, () => [[["f0_0", int64_type]], []]);
}

export type US3_$union = 
    | US3<0>
    | US3<1>
    | US3<2>

export type US3_$cases = {
    0: ["US3_0", []],
    1: ["US3_1", []],
    2: ["US3_2", []]
}

export function US3_US3_0() {
    return new US3<0>(0, []);
}

export function US3_US3_1() {
    return new US3<1>(1, []);
}

export function US3_US3_2() {
    return new US3<2>(2, []);
}

export class US3<Tag extends keyof US3_$cases> extends Union<Tag, US3_$cases[Tag][0]> {
    constructor(readonly tag: Tag, readonly fields: US3_$cases[Tag][1]) {
        super();
    }
    cases() {
        return ["US3_0", "US3_1", "US3_2"];
    }
}

export function US3_$reflection(): TypeInfo {
    return union_type("Trace.US3", [], US3, () => [[], [], []]);
}

export type US4_$union = 
    | US4<0>
    | US4<1>
    | US4<2>
    | US4<3>
    | US4<4>

export type US4_$cases = {
    0: ["US4_0", [US3_$union]],
    1: ["US4_1", [US3_$union]],
    2: ["US4_2", [US3_$union]],
    3: ["US4_3", [US3_$union]],
    4: ["US4_4", [US3_$union]]
}

export function US4_US4_0(f0_0: US3_$union) {
    return new US4<0>(0, [f0_0]);
}

export function US4_US4_1(f1_0: US3_$union) {
    return new US4<1>(1, [f1_0]);
}

export function US4_US4_2(f2_0: US3_$union) {
    return new US4<2>(2, [f2_0]);
}

export function US4_US4_3(f3_0: US3_$union) {
    return new US4<3>(3, [f3_0]);
}

export function US4_US4_4(f4_0: US3_$union) {
    return new US4<4>(4, [f4_0]);
}

export class US4<Tag extends keyof US4_$cases> extends Union<Tag, US4_$cases[Tag][0]> {
    constructor(readonly tag: Tag, readonly fields: US4_$cases[Tag][1]) {
        super();
    }
    cases() {
        return ["US4_0", "US4_1", "US4_2", "US4_3", "US4_4"];
    }
}

export function US4_$reflection(): TypeInfo {
    return union_type("Trace.US4", [], US4, () => [[["f0_0", US3_$reflection()]], [["f1_0", US3_$reflection()]], [["f2_0", US3_$reflection()]], [["f3_0", US3_$reflection()]], [["f4_0", US3_$reflection()]]]);
}

export type US5_$union = 
    | US5<0>
    | US5<1>

export type US5_$cases = {
    0: ["US5_0", [string]],
    1: ["US5_1", []]
}

export function US5_US5_0(f0_0: string) {
    return new US5<0>(0, [f0_0]);
}

export function US5_US5_1() {
    return new US5<1>(1, []);
}

export class US5<Tag extends keyof US5_$cases> extends Union<Tag, US5_$cases[Tag][0]> {
    constructor(readonly tag: Tag, readonly fields: US5_$cases[Tag][1]) {
        super();
    }
    cases() {
        return ["US5_0", "US5_1"];
    }
}

export function US5_$reflection(): TypeInfo {
    return union_type("Trace.US5", [], US5, () => [[["f0_0", string_type]], []]);
}

export function method3(v0_1: string): string {
    return v0_1;
}

export function method4(): string {
    return "";
}

export function closure1(unitVar: void, v0_1: string): US5_$union {
    return US5_US5_0(v0_1);
}

export function method5(): ((arg0: string) => US5_$union) {
    return (v: string): US5_$union => closure1(undefined, v);
}

export function method2(v0_1: string): string {
    return process.env[v0_1] ?? "";
}

export function method1(): [US1_$union, US2_$union] {
    let v13: US1_$union, v20: US1_$union, v27: US1_$union, v34: US1_$union;
    const v1_1: string = method2("TRACE_LEVEL");
    const v6: US1_$union = ("Verbose" === v1_1) ? US1_US1_0(US0_US0_0()) : US1_US1_1();
    return [(v6.tag === /* US1_0 */ 0) ? US1_US1_0(v6.fields[0]) : ((v13 = (("Debug" === v1_1) ? US1_US1_0(US0_US0_1()) : US1_US1_1()), (v13.tag === /* US1_0 */ 0) ? US1_US1_0(v13.fields[0]) : ((v20 = (("Info" === v1_1) ? US1_US1_0(US0_US0_2()) : US1_US1_1()), (v20.tag === /* US1_0 */ 0) ? US1_US1_0(v20.fields[0]) : ((v27 = (("Warning" === v1_1) ? US1_US1_0(US0_US0_3()) : US1_US1_1()), (v27.tag === /* US1_0 */ 0) ? US1_US1_0(v27.fields[0]) : ((v34 = (("Critical" === v1_1) ? US1_US1_0(US0_US0_4()) : US1_US1_1()), (v34.tag === /* US1_0 */ 0) ? US1_US1_0(v34.fields[0]) : US1_US1_1())))))))), (method2("AUTOMATION") !== "True") ? US2_US2_1() : US2_US2_0(toInt64(fromInt64(getTicks(now()))))] as [US1_$union, US2_$union];
}

export function closure2(unitVar: void, v0_1: string): void {
}

export function method0(v0_1: US0_$union): [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] {
    const patternInput: [US1_$union, US2_$union] = method1();
    const _run_target_args$0027_v1 = [patternInput[0], patternInput[1]] as [US1_$union, US2_$union];
    const v132: US2_$union = _run_target_args$0027_v1[1];
    const v131: US1_$union = _run_target_args$0027_v1[0];
    return [new Mut0(1n), new Mut1((v: string): void => {
        closure2(undefined, v);
    }), new Mut2(true), new Mut3(""), new Mut4((v131.tag === /* US1_0 */ 0) ? v131.fields[0] : v0_1), (v132.tag === /* US2_0 */ 0) ? v132.fields[0] : undefined] as [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>];
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

export function closure7(unitVar: void, v0_1: int64): US2_$union {
    return US2_US2_0(v0_1);
}

export function method8(): ((arg0: int64) => US2_$union) {
    return (v: int64): US2_$union => closure7(undefined, v);
}

export function method9(): string {
    return "hh:mm:ss";
}

export function method10(): string {
    return "HH:mm:ss";
}

export function method7(v0_1: Mut0, v1_1: Mut1, v2_1: Mut2, v3: Mut3, v4: Mut4, v5: Option<int64>): string {
    const v321: US2_$union = defaultArg(map<int64, US2_$union>(method8(), v5), US2_US2_1());
    let v418: Date;
    if (v321.tag === /* US2_0 */ 0) {
        const v325: int64 = v321.fields[0];
        const v378: number = fromTicks(toInt64(op_Subtraction(toInt64(fromInt64(getTicks(now()))), v325)));
        v418 = create(1, 1, 1, hours(v378), minutes(v378), seconds(v378), milliseconds(v378));
    }
    else {
        v418 = now();
    }
    const v419: string = method10();
    return toString(v418, (v419 === "") ? "M-d-y hh:mm:ss tt" : v419);
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
    const v5: US5_$union = (v0_1.tag === /* US0_0 */ 0) ? US5_US5_0("Verbose") : US5_US5_1();
    let v46: US5_$union;
    if (v5.tag === /* US5_0 */ 0) {
        v46 = US5_US5_0(v5.fields[0]);
    }
    else {
        const v12: US5_$union = (v0_1.tag === /* US0_1 */ 1) ? US5_US5_0("Debug") : US5_US5_1();
        if (v12.tag === /* US5_0 */ 0) {
            v46 = US5_US5_0(v12.fields[0]);
        }
        else {
            const v19: US5_$union = (v0_1.tag === /* US0_2 */ 2) ? US5_US5_0("Info") : US5_US5_1();
            if (v19.tag === /* US5_0 */ 0) {
                v46 = US5_US5_0(v19.fields[0]);
            }
            else {
                const v26: US5_$union = (v0_1.tag === /* US0_3 */ 3) ? US5_US5_0("Warning") : US5_US5_1();
                if (v26.tag === /* US5_0 */ 0) {
                    v46 = US5_US5_0(v26.fields[0]);
                }
                else {
                    const v33: US5_$union = (v0_1.tag === /* US0_4 */ 4) ? US5_US5_0("Critical") : US5_US5_1();
                    v46 = ((v33.tag === /* US5_0 */ 0) ? US5_US5_0(v33.fields[0]) : US5_US5_1());
                }
            }
        }
    }
    let v50: string;
    if (v46.tag === /* US5_0 */ 0) {
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
    closure8(v2_1, v0_1, undefined);
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


