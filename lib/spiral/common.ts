import { Lazy, compare, IComparable, IEquatable, IDisposable, createAtom } from "../../deps/Fable/src/fable-library-ts/Util.js";
import { some, map, defaultArg, value as value_1, Option } from "../../deps/Fable/src/fable-library-ts/Option.js";
import { op_Addition, op_Subtraction, fromInt64, toInt64, int64 } from "../../deps/Fable/src/fable-library-ts/BigInt.js";
import { bool_type, lambda_type, unit_type, string_type, record_type, int64_type, union_type, class_type, TypeInfo } from "../../deps/Fable/src/fable-library-ts/Reflection.js";
import { FSharpRef, Record, Union } from "../../deps/Fable/src/fable-library-ts/Types.js";
import { toString, create, now, getTicks } from "../../deps/Fable/src/fable-library-ts/Date.js";
import { int32 } from "../../deps/Fable/src/fable-library-ts/Int32.js";
import { ofSeq, find } from "../../deps/Fable/src/fable-library-ts/Map.js";
import { milliseconds, seconds, minutes, hours, fromTicks } from "../../deps/Fable/src/fable-library-ts/TimeSpan.js";
import { trimStart, trimEnd, interpolate, toText } from "../../deps/Fable/src/fable-library-ts/String.js";

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
    return union_type("Common.US1", [], US1, () => [[["f0_0", US0_$reflection()]], []]);
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
    return union_type("Common.US2", [], US2, () => [[["f0_0", int64_type]], []]);
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
    return union_type("Common.US3", [], US3, () => [[], [], []]);
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
    return union_type("Common.US4", [], US4, () => [[["f0_0", US3_$reflection()]], [["f1_0", US3_$reflection()]], [["f2_0", US3_$reflection()]], [["f3_0", US3_$reflection()]], [["f4_0", US3_$reflection()]]]);
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
    return union_type("Common.US5", [], US5, () => [[["f0_0", string_type]], []]);
}

export type US6_$union = 
    | US6<0>
    | US6<1>

export type US6_$cases = {
    0: ["US6_0", []],
    1: ["US6_1", []]
}

export function US6_US6_0() {
    return new US6<0>(0, []);
}

export function US6_US6_1() {
    return new US6<1>(1, []);
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
    return union_type("Common.US6", [], US6, () => [[], []]);
}

export type US7_$union = 
    | US7<0>
    | US7<1>

export type US7_$cases = {
    0: ["US7_0", [US6_$union]],
    1: ["US7_1", []]
}

export function US7_US7_0(f0_0: US6_$union) {
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
    return union_type("Common.US7", [], US7, () => [[["f0_0", US6_$reflection()]], []]);
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

export function closure6(unitVar: void, v0_1: US6_$union): US7_$union {
    return US7_US7_0(v0_1);
}

export function closure7(v0_1: int32, v1_1: (() => void), v2_1: int32, unitVar: void): US6_$union {
    if (v2_1 < v0_1) {
        v1_1();
        return US6_US6_0();
    }
    else {
        return US6_US6_1();
    }
}

export function method9(v0_1: US0_$union): boolean {
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

export function closure10(unitVar: void, v0_1: int64): US2_$union {
    return US2_US2_0(v0_1);
}

export function method11(): ((arg0: int64) => US2_$union) {
    return (v: int64): US2_$union => closure10(undefined, v);
}

export function method12(): string {
    return "hh:mm:ss";
}

export function method13(): string {
    return "HH:mm:ss";
}

export function method10(v0_1: Mut0, v1_1: Mut1, v2_1: Mut2, v3: Mut3, v4: Mut4, v5: Option<int64>): string {
    const v321: US2_$union = defaultArg(map<int64, US2_$union>(method11(), v5), US2_US2_1());
    let v418: Date;
    if (v321.tag === /* US2_0 */ 0) {
        const v325: int64 = v321.fields[0];
        const v378: number = fromTicks(toInt64(op_Subtraction(toInt64(fromInt64(getTicks(now()))), v325)));
        v418 = create(1, 1, 1, hours(v378), minutes(v378), seconds(v378), milliseconds(v378));
    }
    else {
        v418 = now();
    }
    const v419: string = method13();
    return toString(v418, (v419 === "") ? "M-d-y hh:mm:ss tt" : v419);
}

export function method16(): string {
    return "";
}

export function closure11(v0_1: Mut3, v1_1: string, unitVar: void): void {
    const v3: string = v0_1.l0 + v1_1;
    v0_1.l0 = v3;
}

export function method15(v0_1: string): string {
    const v2_1: Mut3 = new Mut3(method16());
    let v8: any;
    closure11(v2_1, `${v0_1}`, undefined);
    v8 = undefined;
    return v2_1.l0;
}

export function method17(): string {
    return "\u001b[0m";
}

export function method14(): string {
    const v2_1: string = "Warning".toLocaleLowerCase();
    return ("\u001b[93m" + method15(v2_1[0])) + method17();
}

export function method19(v0_1: int32, v1_1: Error): string {
    const v3: Mut3 = new Mut3(method16());
    let v10: any;
    closure11(v3, "{ ", undefined);
    v10 = undefined;
    let v19: any;
    closure11(v3, "retry", undefined);
    v19 = undefined;
    let v28: any;
    closure11(v3, " = ", undefined);
    v28 = undefined;
    let v36: any;
    closure11(v3, `${v0_1}`, undefined);
    v36 = undefined;
    let v45: any;
    closure11(v3, "; ", undefined);
    v45 = undefined;
    let v54: any;
    closure11(v3, "ex", undefined);
    v54 = undefined;
    let v62: any;
    closure11(v3, " = ", undefined);
    v62 = undefined;
    let v100: any;
    closure11(v3, toText(interpolate("%A%P()", [v1_1])), undefined);
    v100 = undefined;
    let v109: any;
    closure11(v3, " }", undefined);
    v109 = undefined;
    return v3.l0;
}

export function method20(v0_1: string): string {
    return trimEnd(trimStart(v0_1, ...[]), ...[" ", "/"]);
}

export function method18(v0_1: Mut0, v1_1: Mut1, v2_1: Mut2, v3: Mut3, v4: Mut4, v5: Option<int64>, v6: string, v7: string, v8: int32, v9: Error): string {
    const v10: string = method19(v8, v9);
    return method20(`${v6} ${v7} #${v0_1.l0} ${"common.retry_fn"} / ${v10}`);
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

export function method21(v0_1: string): void {
    let v3: any;
    closure0(undefined, undefined);
    v3 = undefined;
    const patternInput: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_1(TraceState_trace_state());
    let v37: any;
    closure12(patternInput[0], undefined);
    v37 = undefined;
    closure13(undefined, v0_1);
    patternInput[1].l0(v0_1);
}

export function closure9(v0_1: int32, v1_1: Error, unitVar: void): void {
    if (method9(US0_US0_3())) {
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
        method21(method18(v20, v21, v22, v23, v24, v25, method10(v20, v21, v22, v23, v24, v25), method14(), v0_1, v1_1));
    }
}

export function closure8(v0_1: int32, v1_1: Error): US7_$union {
    let v4: any;
    closure9(v0_1, v1_1, undefined);
    v4 = undefined;
    return US7_US7_1();
}

export function method8(v0_1_mut: int32, v1_1_mut: (() => void), v2_1_mut: int32): US6_$union {
    method8:
    while (true) {
        const v0_1: int32 = v0_1_mut, v1_1: (() => void) = v1_1_mut, v2_1: int32 = v2_1_mut;
        const result: FSharpRef<US7_$union> = new FSharpRef<US7_$union>(US7_US7_1());
        try {
            result.contents = closure6(undefined, closure7(v0_1, v1_1, v2_1, undefined));
        }
        catch (ex: any) {
            result.contents = closure8(v2_1, ex);
        }
        const v7: US7_$union = result.contents;
        if (v7.tag === /* US7_0 */ 0) {
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
    const v3: US6_$union = method8(v0_1, v1_1, 0);
    if (v3.tag === /* US6_0 */ 0) {
        return some(undefined);
    }
    else {
        return undefined;
    }
}

export function closure4(unitVar: void, v0_1: int32): ((arg0: (() => void)) => Option<void>) {
    return (v: (() => void)): Option<void> => closure5(v0_1, v);
}

export function method22(v0_1: (() => void)): (() => void) {
    return v0_1;
}

export function closure16(v0_1: any, unitVar: void): void {
    v0_1.Value;
}

export function closure15(unitVar: void, v0_1: (() => void)): (() => void) {
    const v1_1: (() => void) = method22(v0_1);
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


