import { Lazy, compare, IComparable, IEquatable, IDisposable, createAtom } from "../../deps/Fable/src/fable-library-ts/Util.js";
import { some, value as value_1, map, defaultArg, Option } from "../../deps/Fable/src/fable-library-ts/Option.js";
import { op_Addition, op_Subtraction, toInt64, int64 } from "../../deps/Fable/src/fable-library-ts/BigInt.js";
import { bool_type, lambda_type, unit_type, string_type, record_type, int64_type, union_type, class_type, TypeInfo } from "../../deps/Fable/src/fable-library-ts/Reflection.js";
import { FSharpRef, Record, Union } from "../../deps/Fable/src/fable-library-ts/Types.js";
import { create, toString, now, getTicks } from "../../deps/Fable/src/fable-library-ts/Date.js";
import { int32 } from "../../deps/Fable/src/fable-library-ts/Int32.js";
import { milliseconds, seconds, minutes, hours, fromTicks } from "../../deps/Fable/src/fable-library-ts/TimeSpan.js";
import { trimStart, trimEnd, interpolate, toText, padLeft } from "../../deps/Fable/src/fable-library-ts/String.js";
import { ofSeq, find } from "../../deps/Fable/src/fable-library-ts/Map.js";

export let TraceState_trace_state = createAtom<Option<[Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>]>>(undefined);

export interface IOsEnviron {
    environ(): any
}

export class Disposable implements IDisposable {
    readonly f: (() => void);
    constructor(f: (() => void)) {
        this.f = f;
    }
    Dispose(): void {
        const _: Disposable = this;
        _.f();
    }
}

export function Disposable_$reflection(): TypeInfo {
    return class_type("Common.Disposable", undefined, Disposable);
}

export function Disposable_$ctor_3A5B6456(f: (() => void)): Disposable {
    return new Disposable(f);
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
    return union_type("Common.US0", [], US0, () => [[], [], [], [], []]);
}

export class Mut0 extends Record implements IEquatable<Mut0>, IComparable<Mut0> {
    l0: int64;
    constructor(l0: int64) {
        super();
        this.l0 = l0;
    }
}

export function Mut0_$reflection(): TypeInfo {
    return record_type("Common.Mut0", [], Mut0, () => [["l0", int64_type]]);
}

export class Mut1 extends Record {
    l0: ((arg0: string) => void);
    constructor(l0: ((arg0: string) => void)) {
        super();
        this.l0 = l0;
    }
}

export function Mut1_$reflection(): TypeInfo {
    return record_type("Common.Mut1", [], Mut1, () => [["l0", lambda_type(string_type, unit_type)]]);
}

export class Mut2 extends Record implements IEquatable<Mut2>, IComparable<Mut2> {
    l0: boolean;
    constructor(l0: boolean) {
        super();
        this.l0 = l0;
    }
}

export function Mut2_$reflection(): TypeInfo {
    return record_type("Common.Mut2", [], Mut2, () => [["l0", bool_type]]);
}

export class Mut3 extends Record implements IEquatable<Mut3>, IComparable<Mut3> {
    l0: string;
    constructor(l0: string) {
        super();
        this.l0 = l0;
    }
}

export function Mut3_$reflection(): TypeInfo {
    return record_type("Common.Mut3", [], Mut3, () => [["l0", string_type]]);
}

export class Mut4 extends Record implements IEquatable<Mut4>, IComparable<Mut4> {
    l0: US0_$union;
    constructor(l0: US0_$union) {
        super();
        this.l0 = l0;
    }
}

export function Mut4_$reflection(): TypeInfo {
    return record_type("Common.Mut4", [], Mut4, () => [["l0", US0_$reflection()]]);
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
    return union_type("Common.US1", [], US1, () => [[["f0_0", string_type]], []]);
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
    return union_type("Common.US2", [], US2, () => [[["f0_0", US0_$reflection()]], []]);
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
    return union_type("Common.US3", [], US3, () => [[["f0_0", int64_type]], []]);
}

export type US4_$union = 
    | US4<0>
    | US4<1>

export type US4_$cases = {
    0: ["US4_0", []],
    1: ["US4_1", []]
}

export function US4_US4_0() {
    return new US4<0>(0, []);
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
    return union_type("Common.US4", [], US4, () => [[], []]);
}

export type US5_$union = 
    | US5<0>
    | US5<1>

export type US5_$cases = {
    0: ["US5_0", [US4_$union]],
    1: ["US5_1", []]
}

export function US5_US5_0(f0_0: US4_$union) {
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
    return union_type("Common.US5", [], US5, () => [[["f0_0", US4_$reflection()]], []]);
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

export function method6(v0_1: (() => void)): (() => void) {
    return v0_1;
}

export function method7(v0_1: (() => void)): (() => void) {
    return v0_1;
}

export function closure3(unitVar: void, v0_1: (() => void)): IDisposable {
    const v8: (() => void) = method7(v0_1);
    return {
        Dispose(): void {
            v8();
        },
    };
}

export function closure6(unitVar: void, v0_1: US4_$union): US5_$union {
    return US5_US5_0(v0_1);
}

export function closure7(v0_1: int32, v1_1: (() => void), v2_1: int32, unitVar: void): US4_$union {
    if (v2_1 < v0_1) {
        v1_1();
        return US4_US4_0();
    }
    else {
        return US4_US4_1();
    }
}

export function closure10(unitVar: void, v0_1: int64): US3_$union {
    return US3_US3_0(v0_1);
}

export function method10(): ((arg0: int64) => US3_$union) {
    return (v: int64): US3_$union => closure10(undefined, v);
}

export function method11(): string {
    return "hh:mm:ss";
}

export function method12(): string {
    return "HH:mm:ss";
}

export function method9(v0_1: Mut0, v1_1: Mut1, v2_1: Mut2, v3: Mut3, v4: Mut4, v5: Option<int64>): string {
    let v181: int64, v191: number;
    const v177: US3_$union = defaultArg(map<int64, US3_$union>(method10(), v5), US3_US3_1());
    return toString((v177.tag === /* US3_0 */ 0) ? ((v181 = v177.fields[0], (v191 = fromTicks(toInt64(op_Subtraction(getTicks(now()), v181))), create(1, 1, 1, hours(v191), minutes(v191), seconds(v191), milliseconds(v191))))) : now(), method12());
}

export function method14(): string {
    return "\u001b[0m";
}

export function method13(): string {
    return ("\u001b[93m" + padLeft("Warning".toLocaleLowerCase(), 7, " ")) + method14();
}

export function method16(): string {
    return "";
}

export function closure11(v0_1: Mut3, v1_1: string, unitVar: void): void {
    const v3: string = v0_1.l0 + v1_1;
    v0_1.l0 = v3;
}

export function method15(v0_1: int32, v1_1: Error): string {
    const v3: Mut3 = new Mut3(method16());
    let v10: any;
    closure11(v3, `${"{ "}`, undefined);
    v10 = undefined;
    let v19: any;
    closure11(v3, `${"retry"}`, undefined);
    v19 = undefined;
    let v28: any;
    closure11(v3, `${" = "}`, undefined);
    v28 = undefined;
    let v36: any;
    closure11(v3, `${v0_1}`, undefined);
    v36 = undefined;
    let v45: any;
    closure11(v3, `${"; "}`, undefined);
    v45 = undefined;
    let v54: any;
    closure11(v3, `${"ex"}`, undefined);
    v54 = undefined;
    let v62: any;
    closure11(v3, `${" = "}`, undefined);
    v62 = undefined;
    let v97: any;
    closure11(v3, `${toText(interpolate("%A%P()", [v1_1]))}`, undefined);
    v97 = undefined;
    let v106: any;
    closure11(v3, `${" }"}`, undefined);
    v106 = undefined;
    return v3.l0;
}

export function method17(v0_1: string, v1_1: string, v2_1: int64, v3: string): string {
    return trimEnd(trimStart(`${v0_1} ${v1_1} #${v2_1} ${"common.retry_fn"} / ${v3}`, ...[]), ...[" ", "/"]);
}

export function closure12(v0_1: Mut0, unitVar: void): void {
    const v2_1: int64 = toInt64(op_Addition(v0_1.l0, 1n));
    v0_1.l0 = v2_1;
}

export function closure14(v0_1: string, unitVar: void): void {
    console.log(v0_1);
}

export function closure13(unitVar: void, v0_1: string): void {
    let v3: any;
    closure14(v0_1, undefined);
    v3 = undefined;
}

export function method18(v0_1: string, v1_1: Mut0, v2_1: Mut1, v3: Mut2, v4: Mut3, v5: Mut4, v6: Option<int64>): void {
    let v9: any;
    closure12(v1_1, undefined);
    v9 = undefined;
    closure13(undefined, v0_1);
    v2_1.l0(v0_1);
}

export function closure9(v0_1: int32, v1_1: Error, unitVar: void): void {
    const v3 = (): void => {
        closure0(undefined, undefined);
    };
    let v4: any;
    v3();
    v4 = undefined;
    const patternInput: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_1(TraceState_trace_state());
    const v36: US0_$union = patternInput[4].l0;
    if ((patternInput[2].l0 === false) ? false : (3 >= find<US0_$union, int32>(v36, ofSeq([[US0_US0_0(), 0] as [US0_$union, int32], [US0_US0_1(), 1] as [US0_$union, int32], [US0_US0_2(), 2] as [US0_$union, int32], [US0_US0_3(), 3] as [US0_$union, int32], [US0_US0_4(), 4] as [US0_$union, int32]], {
        Compare: compare,
    })))) {
        let v43: any;
        v3();
        v43 = undefined;
        const patternInput_1: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_1(TraceState_trace_state());
        const v57: Mut0 = patternInput_1[0];
        const v79: string = method17(method9(v57, patternInput_1[1], patternInput_1[2], patternInput_1[3], patternInput_1[4], patternInput_1[5]), method13(), v57.l0, method15(v0_1, v1_1));
        let v81: any;
        v3();
        v81 = undefined;
        const patternInput_2: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_1(TraceState_trace_state());
        method18(v79, patternInput_2[0], patternInput_2[1], patternInput_2[2], patternInput_2[3], patternInput_2[4], patternInput_2[5]);
    }
}

export function closure8(v0_1: int32, v1_1: Error): US5_$union {
    let v4: any;
    closure9(v0_1, v1_1, undefined);
    v4 = undefined;
    return US5_US5_1();
}

export function method8(v0_1_mut: int32, v1_1_mut: (() => void), v2_1_mut: int32): US4_$union {
    method8:
    while (true) {
        const v0_1: int32 = v0_1_mut, v1_1: (() => void) = v1_1_mut, v2_1: int32 = v2_1_mut;
        const result: FSharpRef<US5_$union> = new FSharpRef<US5_$union>(US5_US5_1());
        try {
            result.contents = closure6(undefined, closure7(v0_1, v1_1, v2_1, undefined));
        }
        catch (ex: any) {
            result.contents = closure8(v2_1, ex);
        }
        const v7: US5_$union = result.contents;
        if (v7.tag === /* US5_0 */ 0) {
            return v7.fields[0];
        }
        else {
            v0_1_mut = v0_1;
            v1_1_mut = v1_1;
            v2_1_mut = (v2_1 + 1);
            continue method8;
        }
        break;
    }
}

export function closure5(v0_1: int32, v1_1: (() => void)): Option<void> {
    const v3: US4_$union = method8(v0_1, v1_1, 0);
    if (v3.tag === /* US4_0 */ 0) {
        return some(undefined);
    }
    else {
        return undefined;
    }
}

export function closure4(unitVar: void, v0_1: int32): ((arg0: (() => void)) => Option<void>) {
    return (v: (() => void)): Option<void> => closure5(v0_1, v);
}

export function method19(v0_1: (() => void)): (() => void) {
    return v0_1;
}

export function closure16(v0_1: any, unitVar: void): void {
    v0_1.Value;
}

export function closure15(unitVar: void, v0_1: (() => void)): (() => void) {
    const v1_1: (() => void) = method19(v0_1);
    const v2_1: any = new Lazy<void>((): void => {
        v1_1();
    });
    return (): void => {
        closure16(v2_1, undefined);
    };
}

export const v0: any = undefined;

export const v1 = (): void => {
    closure0(undefined, undefined);
};

export const v2: any = (v1(), v0);

export const v16 = (v: (() => void)): IDisposable => closure3(undefined, v);

export function new_disposable(x: (() => void)): IDisposable {
    return v16(x);
}

export const v17 = (v: int32): ((arg0: (() => void)) => Option<void>) => closure4(undefined, v);

export function retry_fn(x: int32): ((arg0: (() => void)) => Option<void>) {
    return v17(x);
}

export const v18 = (v: (() => void)): (() => void) => closure15(undefined, v);

export function memoize(x: (() => void)): (() => void) {
    return v18(x);
}


