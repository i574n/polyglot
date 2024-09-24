import { defaultOf, compare, IComparable, IEquatable, createAtom } from "../../deps/Fable/src/fable-library-ts/Util.js";
import { value as value_1, map, defaultArg, Option } from "../../deps/Fable/src/fable-library-ts/Option.js";
import { op_Addition, op_Subtraction, toInt64, int64 } from "../../deps/Fable/src/fable-library-ts/BigInt.js";
import { Record, Union } from "../../deps/Fable/src/fable-library-ts/Types.js";
import { int32_type, class_type, bool_type, lambda_type, unit_type, string_type, record_type, int64_type, union_type, TypeInfo } from "../../deps/Fable/src/fable-library-ts/Reflection.js";
import { int32 } from "../../deps/Fable/src/fable-library-ts/Int32.js";
import { create, toString, now, getTicks } from "../../deps/Fable/src/fable-library-ts/Date.js";
import { milliseconds, seconds, minutes, hours, fromTicks } from "../../deps/Fable/src/fable-library-ts/TimeSpan.js";
import { interpolate, toText, trimStart, trimEnd, padLeft } from "../../deps/Fable/src/fable-library-ts/String.js";
import { ofSeq, find } from "../../deps/Fable/src/fable-library-ts/Map.js";

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
    return union_type("Networking.US0", [], US0, () => [[], [], [], [], []]);
}

export class Mut0 extends Record implements IEquatable<Mut0>, IComparable<Mut0> {
    l0: int64;
    constructor(l0: int64) {
        super();
        this.l0 = l0;
    }
}

export function Mut0_$reflection(): TypeInfo {
    return record_type("Networking.Mut0", [], Mut0, () => [["l0", int64_type]]);
}

export class Mut1 extends Record {
    l0: ((arg0: string) => void);
    constructor(l0: ((arg0: string) => void)) {
        super();
        this.l0 = l0;
    }
}

export function Mut1_$reflection(): TypeInfo {
    return record_type("Networking.Mut1", [], Mut1, () => [["l0", lambda_type(string_type, unit_type)]]);
}

export class Mut2 extends Record implements IEquatable<Mut2>, IComparable<Mut2> {
    l0: boolean;
    constructor(l0: boolean) {
        super();
        this.l0 = l0;
    }
}

export function Mut2_$reflection(): TypeInfo {
    return record_type("Networking.Mut2", [], Mut2, () => [["l0", bool_type]]);
}

export class Mut3 extends Record implements IEquatable<Mut3>, IComparable<Mut3> {
    l0: string;
    constructor(l0: string) {
        super();
        this.l0 = l0;
    }
}

export function Mut3_$reflection(): TypeInfo {
    return record_type("Networking.Mut3", [], Mut3, () => [["l0", string_type]]);
}

export class Mut4 extends Record implements IEquatable<Mut4>, IComparable<Mut4> {
    l0: US0_$union;
    constructor(l0: US0_$union) {
        super();
        this.l0 = l0;
    }
}

export function Mut4_$reflection(): TypeInfo {
    return record_type("Networking.Mut4", [], Mut4, () => [["l0", US0_$reflection()]]);
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
    return union_type("Networking.US1", [], US1, () => [[["f0_0", string_type]], []]);
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
    return union_type("Networking.US2", [], US2, () => [[["f0_0", US0_$reflection()]], []]);
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
    return union_type("Networking.US3", [], US3, () => [[["f0_0", int64_type]], []]);
}

export type US4_$union = 
    | US4<0>
    | US4<1>

export type US4_$cases = {
    0: ["US4_0", [boolean]],
    1: ["US4_1", []]
}

export function US4_US4_0(f0_0: boolean) {
    return new US4<0>(0, [f0_0]);
}

export function US4_US4_1() {
    return new US4<1>(1, []);
}

export class US4<Tag extends keyof US4_$cases> extends Union<Tag, US4_$cases[Tag][0]> {
    constructor(readonly tag: Tag, readonly fields: US4_$cases[Tag][1]) {
        super();
    }
    cases() {
        return ["US4_0", "US4_1"];
    }
}

export function US4_$reflection(): TypeInfo {
    return union_type("Networking.US4", [], US4, () => [[["f0_0", bool_type]], []]);
}

export type US5_$union = 
    | US5<0>
    | US5<1>

export type US5_$cases = {
    0: ["US5_0", [boolean]],
    1: ["US5_1", [Error]]
}

export function US5_US5_0(f0_0: boolean) {
    return new US5<0>(0, [f0_0]);
}

export function US5_US5_1(f1_0: Error) {
    return new US5<1>(1, [f1_0]);
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
    return union_type("Networking.US5", [], US5, () => [[["f0_0", bool_type]], [["f1_0", class_type("System.Exception")]]]);
}

export type US6_$union = 
    | US6<0>
    | US6<1>

export type US6_$cases = {
    0: ["US6_0", [boolean]],
    1: ["US6_1", [Error]]
}

export function US6_US6_0(f0_0: boolean) {
    return new US6<0>(0, [f0_0]);
}

export function US6_US6_1(f1_0: Error) {
    return new US6<1>(1, [f1_0]);
}

export class US6<Tag extends keyof US6_$cases> extends Union<Tag, US6_$cases[Tag][0]> {
    constructor(readonly tag: Tag, readonly fields: US6_$cases[Tag][1]) {
        super();
    }
    cases() {
        return ["US6_0", "US6_1"];
    }
}

export function US6_$reflection(): TypeInfo {
    return union_type("Networking.US6", [], US6, () => [[["f0_0", bool_type]], [["f1_0", class_type("System.Exception")]]]);
}

export type US7_$union = 
    | US7<0>
    | US7<1>

export type US7_$cases = {
    0: ["US7_0", [int32]],
    1: ["US7_1", []]
}

export function US7_US7_0(f0_0: int32) {
    return new US7<0>(0, [f0_0]);
}

export function US7_US7_1() {
    return new US7<1>(1, []);
}

export class US7<Tag extends keyof US7_$cases> extends Union<Tag, US7_$cases[Tag][0]> {
    constructor(readonly tag: Tag, readonly fields: US7_$cases[Tag][1]) {
        super();
    }
    cases() {
        return ["US7_0", "US7_1"];
    }
}

export function US7_$reflection(): TypeInfo {
    return union_type("Networking.US7", [], US7, () => [[["f0_0", int32_type]], []]);
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
    let v124: US2_$union, v131: US2_$union, v138: US2_$union, v145: US2_$union;
    const v112: string = method2(method1());
    const v117: US2_$union = ("Verbose" === v112) ? US2_US2_0(US0_US0_0()) : US2_US2_1();
    const _v1 = [(v117.tag === /* US2_0 */ 0) ? US2_US2_0(v117.fields[0]) : ((v124 = (("Debug" === v112) ? US2_US2_0(US0_US0_1()) : US2_US2_1()), (v124.tag === /* US2_0 */ 0) ? US2_US2_0(v124.fields[0]) : ((v131 = (("Info" === v112) ? US2_US2_0(US0_US0_2()) : US2_US2_1()), (v131.tag === /* US2_0 */ 0) ? US2_US2_0(v131.fields[0]) : ((v138 = (("Warning" === v112) ? US2_US2_0(US0_US0_3()) : US2_US2_1()), (v138.tag === /* US2_0 */ 0) ? US2_US2_0(v138.fields[0]) : ((v145 = (("Critical" === v112) ? US2_US2_0(US0_US0_4()) : US2_US2_1()), (v145.tag === /* US2_0 */ 0) ? US2_US2_0(v145.fields[0]) : US2_US2_1())))))))), (method2(method5()) === "True") ? US3_US3_0(getTicks(now())) : US3_US3_1()] as [US2_$union, US3_$union];
    const v295: US3_$union = _v1[1];
    const v294: US2_$union = _v1[0];
    return [new Mut0(1n), new Mut1((v: string): void => {
        closure2(undefined, v);
    }), new Mut2(true), new Mut3(""), new Mut4((v294.tag === /* US2_0 */ 0) ? v294.fields[0] : v0_1), (v295.tag === /* US3_0 */ 0) ? v295.fields[0] : undefined] as [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>];
}

export function closure0(unitVar: void, unitVar_1: void): void {
    if (TraceState_trace_state() == null) {
        const patternInput: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = method0(US0_US0_0());
        TraceState_trace_state([patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5]] as [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>]);
    }
}

export function closure6(unitVar: void, v0_1: int64): US3_$union {
    return US3_US3_0(v0_1);
}

export function method7(): ((arg0: int64) => US3_$union) {
    return (v: int64): US3_$union => closure6(undefined, v);
}

export function method8(): string {
    return "hh:mm:ss";
}

export function method9(): string {
    return "HH:mm:ss";
}

export function method6(v0_1: Mut0, v1_1: Mut1, v2_1: Mut2, v3: Mut3, v4: Mut4, v5: Option<int64>): string {
    let v181: int64, v191: number;
    const v177: US3_$union = defaultArg(map<int64, US3_$union>(method7(), v5), US3_US3_1());
    return toString((v177.tag === /* US3_0 */ 0) ? ((v181 = v177.fields[0], (v191 = fromTicks(toInt64(op_Subtraction(getTicks(now()), v181))), create(1, 1, 1, hours(v191), minutes(v191), seconds(v191), milliseconds(v191))))) : now(), method9());
}

export function method11(): string {
    return "\u001b[0m";
}

export function method10(): string {
    return ("\u001b[90m" + padLeft("Verbose".toLocaleLowerCase(), 7, " ")) + method11();
}

export function method13(): string {
    return "";
}

export function closure7(v0_1: Mut3, v1_1: string, unitVar: void): void {
    const v3: string = v0_1.l0 + v1_1;
    v0_1.l0 = v3;
}

export function method12(v0_1: int32, v1_1: string): string {
    const v3: Mut3 = new Mut3(method13());
    let v10: any;
    closure7(v3, `${"{ "}`, undefined);
    v10 = undefined;
    let v19_1: any;
    closure7(v3, `${"port"}`, undefined);
    v19_1 = undefined;
    let v28: any;
    closure7(v3, `${" = "}`, undefined);
    v28 = undefined;
    let v36: any;
    closure7(v3, `${v0_1}`, undefined);
    v36 = undefined;
    let v45: any;
    closure7(v3, `${"; "}`, undefined);
    v45 = undefined;
    let v54: any;
    closure7(v3, `${"ex"}`, undefined);
    v54 = undefined;
    let v62: any;
    closure7(v3, `${" = "}`, undefined);
    v62 = undefined;
    let v70: any;
    closure7(v3, `${v1_1}`, undefined);
    v70 = undefined;
    let v79: any;
    closure7(v3, `${" }"}`, undefined);
    v79 = undefined;
    return v3.l0;
}

export function method14(v0_1: string, v1_1: string, v2_1: string, v3: int64, v4: string): string {
    return trimEnd(trimStart(`${v0_1} ${v1_1} #${v3} ${v2_1} / ${v4}`, ...[]), ...[" ", "/"]);
}

export function closure8(v0_1: Mut0, unitVar: void): void {
    const v2_1: int64 = toInt64(op_Addition(v0_1.l0, 1n));
    v0_1.l0 = v2_1;
}

export function closure10(v0_1: string, unitVar: void): void {
    console.log(v0_1);
}

export function closure9(unitVar: void, v0_1: string): void {
    let v3: any;
    closure10(v0_1, undefined);
    v3 = undefined;
}

export function method15(v0_1: string, v1_1: Mut0, v2_1: Mut1, v3: Mut2, v4: Mut3, v5: Mut4, v6: Option<int64>): void {
    let v9: any;
    closure8(v1_1, undefined);
    v9 = undefined;
    closure9(undefined, v0_1);
    v2_1.l0(v0_1);
}

export function closure5(v0_1: int32, v1_1: string, unitVar: void): void {
    const v3 = (): void => {
        closure0(undefined, undefined);
    };
    let v4: any;
    v3();
    v4 = undefined;
    const patternInput: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_1(TraceState_trace_state());
    const v36: US0_$union = patternInput[4].l0;
    if ((patternInput[2].l0 === false) ? false : (0 >= find<US0_$union, int32>(v36, ofSeq([[US0_US0_0(), 0] as [US0_$union, int32], [US0_US0_1(), 1] as [US0_$union, int32], [US0_US0_2(), 2] as [US0_$union, int32], [US0_US0_3(), 3] as [US0_$union, int32], [US0_US0_4(), 4] as [US0_$union, int32]], {
        Compare: compare,
    })))) {
        let v43: any;
        v3();
        v43 = undefined;
        const patternInput_1: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_1(TraceState_trace_state());
        const v57: Mut0 = patternInput_1[0];
        const v83: string = method14(method6(v57, patternInput_1[1], patternInput_1[2], patternInput_1[3], patternInput_1[4], patternInput_1[5]), method10(), "networking.test_port_open", v57.l0, method12(v0_1, v1_1));
        let v85: any;
        v3();
        v85 = undefined;
        const patternInput_2: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_1(TraceState_trace_state());
        method15(v83, patternInput_2[0], patternInput_2[1], patternInput_2[2], patternInput_2[3], patternInput_2[4], patternInput_2[5]);
    }
}

export function closure4(v0_1: string, v1_1: int32): any {
    return defaultOf();
}

export function closure3(unitVar: void, v0_1: string): ((arg0: int32) => any) {
    return (v: int32): any => closure4(v0_1, v);
}

export function closure14(unitVar: void, v0_1: boolean): US5_$union {
    return US5_US5_0(v0_1);
}

export function closure15(unitVar: void, v0_1: Error): US5_$union {
    return US5_US5_1(v0_1);
}

export function method16(v0_1: int32): string {
    const v2_1: Mut3 = new Mut3(method13());
    let v9: any;
    closure7(v2_1, `${"{ "}`, undefined);
    v9 = undefined;
    let v18_1: any;
    closure7(v2_1, `${"timeout"}`, undefined);
    v18_1 = undefined;
    let v27: any;
    closure7(v2_1, `${" = "}`, undefined);
    v27 = undefined;
    let v35: any;
    closure7(v2_1, `${v0_1}`, undefined);
    v35 = undefined;
    let v44: any;
    closure7(v2_1, `${" }"}`, undefined);
    v44 = undefined;
    return v2_1.l0;
}

export function closure16(v0_1: int32, unitVar: void): void {
    const v2_1 = (): void => {
        closure0(undefined, undefined);
    };
    let v3: any;
    v2_1();
    v3 = undefined;
    const patternInput: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_1(TraceState_trace_state());
    const v35: US0_$union = patternInput[4].l0;
    if ((patternInput[2].l0 === false) ? false : (0 >= find<US0_$union, int32>(v35, ofSeq([[US0_US0_0(), 0] as [US0_$union, int32], [US0_US0_1(), 1] as [US0_$union, int32], [US0_US0_2(), 2] as [US0_$union, int32], [US0_US0_3(), 3] as [US0_$union, int32], [US0_US0_4(), 4] as [US0_$union, int32]], {
        Compare: compare,
    })))) {
        let v42: any;
        v2_1();
        v42 = undefined;
        const patternInput_1: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_1(TraceState_trace_state());
        const v56: Mut0 = patternInput_1[0];
        const v82: string = method14(method6(v56, patternInput_1[1], patternInput_1[2], patternInput_1[3], patternInput_1[4], patternInput_1[5]), method10(), "async.run_with_timeout_async", v56.l0, method16(v0_1));
        let v84: any;
        v2_1();
        v84 = undefined;
        const patternInput_2: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_1(TraceState_trace_state());
        method15(v82, patternInput_2[0], patternInput_2[1], patternInput_2[2], patternInput_2[3], patternInput_2[4], patternInput_2[5]);
    }
}

export function method17(): string {
    return ("\u001b[91m" + padLeft("Critical".toLocaleLowerCase(), 7, " ")) + method11();
}

export function method18(v0_1: int32, v1_1: string): string {
    const v3: Mut3 = new Mut3(method13());
    let v10: any;
    closure7(v3, `${"{ "}`, undefined);
    v10 = undefined;
    let v19_1: any;
    closure7(v3, `${"timeout"}`, undefined);
    v19_1 = undefined;
    let v28: any;
    closure7(v3, `${" = "}`, undefined);
    v28 = undefined;
    let v36: any;
    closure7(v3, `${v0_1}`, undefined);
    v36 = undefined;
    let v45: any;
    closure7(v3, `${"; "}`, undefined);
    v45 = undefined;
    let v54: any;
    closure7(v3, `${"ex"}`, undefined);
    v54 = undefined;
    let v62: any;
    closure7(v3, `${" = "}`, undefined);
    v62 = undefined;
    let v70: any;
    closure7(v3, `${v1_1}`, undefined);
    v70 = undefined;
    let v79: any;
    closure7(v3, `${" }"}`, undefined);
    v79 = undefined;
    return v3.l0;
}

export function closure17(v0_1: int32, v1_1: Error, unitVar: void): void {
    const v3 = (): void => {
        closure0(undefined, undefined);
    };
    let v4: any;
    v3();
    v4 = undefined;
    const patternInput: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_1(TraceState_trace_state());
    const v36: US0_$union = patternInput[4].l0;
    if ((patternInput[2].l0 === false) ? false : (4 >= find<US0_$union, int32>(v36, ofSeq([[US0_US0_0(), 0] as [US0_$union, int32], [US0_US0_1(), 1] as [US0_$union, int32], [US0_US0_2(), 2] as [US0_$union, int32], [US0_US0_3(), 3] as [US0_$union, int32], [US0_US0_4(), 4] as [US0_$union, int32]], {
        Compare: compare,
    })))) {
        let v43: any;
        v3();
        v43 = undefined;
        const patternInput_1: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_1(TraceState_trace_state());
        const v57: Mut0 = patternInput_1[0];
        const v105: string = method14(method6(v57, patternInput_1[1], patternInput_1[2], patternInput_1[3], patternInput_1[4], patternInput_1[5]), method17(), "async.run_with_timeout_async**", v57.l0, method18(v0_1, toText(interpolate("%A%P()", [v1_1]))));
        let v107: any;
        v3();
        v107 = undefined;
        const patternInput_2: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_1(TraceState_trace_state());
        method15(v105, patternInput_2[0], patternInput_2[1], patternInput_2[2], patternInput_2[3], patternInput_2[4], patternInput_2[5]);
    }
}

export function closure13(v0_1: int32, v1_1: string, v2_1: int32): any {
    return defaultOf();
}

export function closure12(v0_1: int32, v1_1: string): ((arg0: int32) => any) {
    return (v: int32): any => closure13(v0_1, v1_1, v);
}

export function closure11(unitVar: void, v0_1: int32): ((arg0: string) => ((arg0: int32) => any)) {
    return (v: string): ((arg0: int32) => any) => closure12(v0_1, v);
}

export function closure22(unitVar: void, v0_1: int32): US7_$union {
    return US7_US7_0(v0_1);
}

export function method20(): ((arg0: int32) => US7_$union) {
    return (v: int32): US7_$union => closure22(undefined, v);
}

export function method21(v0_1: int32, v1_1: int64, v2_1: Option<int32>, v3: boolean): string {
    const v5: Mut3 = new Mut3(method13());
    let v12: any;
    closure7(v5, `${"{ "}`, undefined);
    v12 = undefined;
    let v21: any;
    closure7(v5, `${"port"}`, undefined);
    v21 = undefined;
    let v30: any;
    closure7(v5, `${" = "}`, undefined);
    v30 = undefined;
    let v38: any;
    closure7(v5, `${v0_1}`, undefined);
    v38 = undefined;
    let v47: any;
    closure7(v5, `${"; "}`, undefined);
    v47 = undefined;
    let v56: any;
    closure7(v5, `${"retry"}`, undefined);
    v56 = undefined;
    let v64: any;
    closure7(v5, `${" = "}`, undefined);
    v64 = undefined;
    let v72: any;
    closure7(v5, `${v1_1}`, undefined);
    v72 = undefined;
    let v80: any;
    closure7(v5, `${"; "}`, undefined);
    v80 = undefined;
    let v89: any;
    closure7(v5, `${"timeout"}`, undefined);
    v89 = undefined;
    let v97: any;
    closure7(v5, `${" = "}`, undefined);
    v97 = undefined;
    let v132: any;
    closure7(v5, `${toText(interpolate("%A%P()", [v2_1]))}`, undefined);
    v132 = undefined;
    let v140: any;
    closure7(v5, `${"; "}`, undefined);
    v140 = undefined;
    let v149: any;
    closure7(v5, `${"status"}`, undefined);
    v149 = undefined;
    let v157: any;
    closure7(v5, `${" = "}`, undefined);
    v157 = undefined;
    let v168: any;
    closure7(v5, `${v3 ? "true" : "false"}`, undefined);
    v168 = undefined;
    let v177: any;
    closure7(v5, `${" }"}`, undefined);
    v177 = undefined;
    return v5.l0;
}

export function method22(v0_1: string, v1_1: string, v2_1: int64, v3: string): string {
    return trimEnd(trimStart(`${v0_1} ${v1_1} #${v2_1} ${"networking.wait_for_port_access"} / ${v3}`, ...[]), ...[" ", "/"]);
}

export function closure23(v0_1: Option<int32>, v1_1: boolean, v2_1: int32, v3: int64, unitVar: void): void {
    const v5 = (): void => {
        closure0(undefined, undefined);
    };
    let v6: any;
    v5();
    v6 = undefined;
    const patternInput: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_1(TraceState_trace_state());
    const v38: US0_$union = patternInput[4].l0;
    if ((patternInput[2].l0 === false) ? false : (0 >= find<US0_$union, int32>(v38, ofSeq([[US0_US0_0(), 0] as [US0_$union, int32], [US0_US0_1(), 1] as [US0_$union, int32], [US0_US0_2(), 2] as [US0_$union, int32], [US0_US0_3(), 3] as [US0_$union, int32], [US0_US0_4(), 4] as [US0_$union, int32]], {
        Compare: compare,
    })))) {
        let v45: any;
        v5();
        v45 = undefined;
        const patternInput_1: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_1(TraceState_trace_state());
        const v59: Mut0 = patternInput_1[0];
        const v81: string = method22(method6(v59, patternInput_1[1], patternInput_1[2], patternInput_1[3], patternInput_1[4], patternInput_1[5]), method10(), v59.l0, method21(v2_1, v3, v0_1, v1_1));
        let v83: any;
        v5();
        v83 = undefined;
        const patternInput_2: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_1(TraceState_trace_state());
        method15(v81, patternInput_2[0], patternInput_2[1], patternInput_2[2], patternInput_2[3], patternInput_2[4], patternInput_2[5]);
    }
}

export function method19(v0_1: Option<int32>, v1_1: boolean, v2_1: string, v3: int32, v4: int64): any {
    return defaultOf();
}

export function closure21(v0_1: Option<int32>, v1_1: boolean, v2_1: string, v3: int32): any {
    return method19(v0_1, v1_1, v2_1, v3, 0n);
}

export function closure20(v0_1: Option<int32>, v1_1: boolean, v2_1: string): ((arg0: int32) => any) {
    return (v: int32): any => closure21(v0_1, v1_1, v2_1, v);
}

export function closure19(v0_1: Option<int32>, v1_1: boolean): ((arg0: string) => ((arg0: int32) => any)) {
    return (v: string): ((arg0: int32) => any) => closure20(v0_1, v1_1, v);
}

export function closure18(unitVar: void, v0_1: Option<int32>): ((arg0: boolean) => ((arg0: string) => ((arg0: int32) => any))) {
    return (v: boolean): ((arg0: string) => ((arg0: int32) => any)) => closure19(v0_1, v);
}

export function method23(v0_1: Option<int32>, v1_1: string, v2_1: int32): any {
    return defaultOf();
}

export function closure26(v0_1: Option<int32>, v1_1: string, v2_1: int32): any {
    return method23(v0_1, v1_1, v2_1);
}

export function closure25(v0_1: Option<int32>, v1_1: string): ((arg0: int32) => any) {
    return (v: int32): any => closure26(v0_1, v1_1, v);
}

export function closure24(unitVar: void, v0_1: Option<int32>): ((arg0: string) => ((arg0: int32) => any)) {
    return (v: string): ((arg0: int32) => any) => closure25(v0_1, v);
}

export const v0: any = undefined;

export const v1 = (): void => {
    closure0(undefined, undefined);
};

export const v2: any = (v1(), v0);

export const v16 = (v: string): ((arg0: int32) => any) => closure3(undefined, v);

export function test_port_open(x: string): ((arg0: int32) => any) {
    return v16(x);
}

export const v17 = (v: int32): ((arg0: string) => ((arg0: int32) => any)) => closure11(undefined, v);

export function test_port_open_timeout(x: int32): ((arg0: string) => ((arg0: int32) => any)) {
    return v17(x);
}

export const v18 = (v: Option<int32>): ((arg0: boolean) => ((arg0: string) => ((arg0: int32) => any))) => closure18(undefined, v);

export function wait_for_port_access(x: Option<int32>): ((arg0: boolean) => ((arg0: string) => ((arg0: int32) => any))) {
    return v18(x);
}

export const v19 = (v: Option<int32>): ((arg0: string) => ((arg0: int32) => any)) => closure24(undefined, v);

export function get_available_port(x: Option<int32>): ((arg0: string) => ((arg0: int32) => any)) {
    return v19(x);
}


