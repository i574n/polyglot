import { Lazy, compare, IComparable, IEquatable, IDisposable, createAtom } from "../../../deps/Fable/src/fable-library-ts/Util.js";
import { some, defaultArg, value as value_1, Option } from "../../../deps/Fable/src/fable-library-ts/Option.js";
import { op_Subtraction, op_Addition, toInt64, int64 } from "../../../deps/Fable/src/fable-library-ts/BigInt.js";
import { bool_type, lambda_type, unit_type, string_type, record_type, int64_type, union_type, class_type, TypeInfo } from "../../../deps/Fable/src/fable-library-ts/Reflection.js";
import { FSharpRef, Record, Union } from "../../../deps/Fable/src/fable-library-ts/Types.js";
import { create, toString, now, getTicks } from "../../../deps/Fable/src/fable-library-ts/Date.js";
import { int32 } from "../../../deps/Fable/src/fable-library-ts/Int32.js";
import { ofSeq, find } from "../../../deps/Fable/src/fable-library-ts/Map.js";
import { milliseconds, seconds, minutes, hours, fromTicks } from "../../../deps/Fable/src/fable-library-ts/TimeSpan.js";
import { trimStart, trimEnd, interpolate, toText, padLeft } from "../../../deps/Fable/src/fable-library-ts/String.js";

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

export function closure1(v0_1: FSharpRef<Option<US1_$union>>, v1_1: Option<US1_$union>): FSharpRef<Option<US1_$union>> {
    v0_1.contents = v1_1;
    return v0_1;
}

export function closure2(v0_1: Option<string>, v1_1: ((arg0: Option<US1_$union>) => FSharpRef<Option<US1_$union>>), unitVar: void): void {
    let x: string;
    v1_1((v0_1 == null) ? undefined : ((x = value_1(v0_1), ((): US1_$union => US1_US1_0(x))())));
}

export function method2(v0_1: string): string {
    return process.env[v0_1] ?? "";
}

export function method4(): string {
    return "AUTOMATION";
}

export function closure3(unitVar: void, v0_1: string): void {
}

export function method0(v0_1: US0_$union): [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] {
    let v124: US2_$union, v131: US2_$union, v138: US2_$union, v145: US2_$union;
    const v112: string = method2(method1());
    const v117: US2_$union = ("Verbose" === v112) ? US2_US2_0(US0_US0_0()) : US2_US2_1();
    const _v1 = [(v117.tag === /* US2_0 */ 0) ? US2_US2_0(v117.fields[0]) : ((v124 = (("Debug" === v112) ? US2_US2_0(US0_US0_1()) : US2_US2_1()), (v124.tag === /* US2_0 */ 0) ? US2_US2_0(v124.fields[0]) : ((v131 = (("Info" === v112) ? US2_US2_0(US0_US0_2()) : US2_US2_1()), (v131.tag === /* US2_0 */ 0) ? US2_US2_0(v131.fields[0]) : ((v138 = (("Warning" === v112) ? US2_US2_0(US0_US0_3()) : US2_US2_1()), (v138.tag === /* US2_0 */ 0) ? US2_US2_0(v138.fields[0]) : ((v145 = (("Critical" === v112) ? US2_US2_0(US0_US0_4()) : US2_US2_1()), (v145.tag === /* US2_0 */ 0) ? US2_US2_0(v145.fields[0]) : US2_US2_1())))))))), (method2(method4()) === "True") ? US3_US3_0(getTicks(now())) : US3_US3_1()] as [US2_$union, US3_$union];
    const v295: US3_$union = _v1[1];
    const v294: US2_$union = _v1[0];
    return [new Mut0(0n), new Mut1((v: string): void => {
        closure3(undefined, v);
    }), new Mut2(true), new Mut3(""), new Mut4((v294.tag === /* US2_0 */ 0) ? v294.fields[0] : v0_1), (v295.tag === /* US3_0 */ 0) ? v295.fields[0] : undefined] as [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>];
}

export function closure0(unitVar: void, unitVar_1: void): void {
    if (TraceState_trace_state() == null) {
        const patternInput: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = method0(US0_US0_0());
        TraceState_trace_state([patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5]] as [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>]);
    }
}

export function method5(v0_1: (() => void)): (() => void) {
    return v0_1;
}

export function method6(v0_1: (() => void)): (() => void) {
    return v0_1;
}

export function closure4(unitVar: void, v0_1: (() => void)): IDisposable {
    const v8: (() => void) = method6(v0_1);
    return {
        Dispose(): void {
            v8();
        },
    };
}

export function closure7(unitVar: void, v0_1: US4_$union): US5_$union {
    return US5_US5_0(v0_1);
}

export function closure8(v0_1: int32, v1_1: (() => void), v2_1: int32, unitVar: void): US4_$union {
    if (v2_1 < v0_1) {
        v1_1();
        return US4_US4_0();
    }
    else {
        return US4_US4_1();
    }
}

export function closure11(v0_1: Mut0, unitVar: void): void {
    const v2_1: int64 = toInt64(op_Addition(v0_1.l0, 1n));
    v0_1.l0 = v2_1;
}

export function closure12(v0_1: FSharpRef<Option<US3_$union>>, v1_1: Option<US3_$union>): FSharpRef<Option<US3_$union>> {
    v0_1.contents = v1_1;
    return v0_1;
}

export function closure13(v0_1: Option<int64>, v1_1: ((arg0: Option<US3_$union>) => FSharpRef<Option<US3_$union>>), unitVar: void): void {
    let x: int64;
    v1_1((v0_1 == null) ? undefined : ((x = value_1(v0_1), ((): US3_$union => US3_US3_0(x))())));
}

export function method8(): string {
    return "hh:mm:ss";
}

export function method9(): string {
    return "HH:mm:ss";
}

export function method10(): string {
    return "\u001b[0m";
}

export function method11(): string {
    return "";
}

export function closure14(v0_1: Mut3, v1_1: string, unitVar: void): void {
    const v3: string = v0_1.l0 + v1_1;
    v0_1.l0 = v3;
}

export function closure16(v0_1: string, unitVar: void): void {
    console.log(v0_1);
}

export function closure15(unitVar: void, v0_1: string): void {
    let v3: any;
    closure16(v0_1, undefined);
    v3 = undefined;
}

export function closure10(v0_1: int32, v1_1: Error, unitVar: void): void {
    let v316: int64, v326: number;
    const v3 = (): void => {
        closure0(undefined, undefined);
    };
    let v4: any;
    v3();
    v4 = undefined;
    const patternInput: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_1(TraceState_trace_state());
    let v37: any;
    v3();
    v37 = undefined;
    const patternInput_1: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_1(TraceState_trace_state());
    const v69: US0_$union = patternInput_1[4].l0;
    if ((patternInput_1[2].l0 === false) ? false : (3 >= find<US0_$union, int32>(v69, ofSeq([[US0_US0_0(), 0] as [US0_$union, int32], [US0_US0_1(), 1] as [US0_$union, int32], [US0_US0_2(), 2] as [US0_$union, int32], [US0_US0_3(), 3] as [US0_$union, int32], [US0_US0_4(), 4] as [US0_$union, int32]], {
        Compare: compare,
    })))) {
        let v77: any;
        closure11(patternInput[0], undefined);
        v77 = undefined;
        let v81: any;
        v3();
        v81 = undefined;
        const patternInput_2: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_1(TraceState_trace_state());
        const _v292: FSharpRef<Option<US3_$union>> = new FSharpRef<Option<US3_$union>>(undefined);
        let v297: any;
        closure13(patternInput_2[5], (v: Option<US3_$union>): FSharpRef<Option<US3_$union>> => closure12(_v292, v), undefined);
        v297 = undefined;
        const v312: US3_$union = defaultArg(_v292.contents, US3_US3_1());
        const v357: string = toString((v312.tag === /* US3_0 */ 0) ? ((v316 = v312.fields[0], (v326 = fromTicks(toInt64(op_Subtraction(getTicks(now()), v316))), create(1, 1, 1, hours(v326), minutes(v326), seconds(v326), milliseconds(v326))))) : now(), method9());
        const v622: string = ("\u001b[93m" + padLeft("Warning".toLocaleLowerCase(), 7, " ")) + method10();
        const v637: int64 = patternInput_2[0].l0;
        const v639: Mut3 = new Mut3(method11());
        let v646: any;
        closure14(v639, `${"{ "}`, undefined);
        v646 = undefined;
        let v655: any;
        closure14(v639, `${"retry"}`, undefined);
        v655 = undefined;
        let v664: any;
        closure14(v639, `${" = "}`, undefined);
        v664 = undefined;
        let v672: any;
        closure14(v639, `${v0_1}`, undefined);
        v672 = undefined;
        let v681: any;
        closure14(v639, `${"; "}`, undefined);
        v681 = undefined;
        let v690: any;
        closure14(v639, `${"ex"}`, undefined);
        v690 = undefined;
        let v698: any;
        closure14(v639, `${" = "}`, undefined);
        v698 = undefined;
        let v733: any;
        closure14(v639, `${toText(interpolate("%A%P()", [v1_1]))}`, undefined);
        v733 = undefined;
        let v742: any;
        closure14(v639, `${" }"}`, undefined);
        v742 = undefined;
        const v784: string = trimEnd(trimStart(`${v357} ${v622} #${v637} ${"common.retry_fn"} / ${v639.l0}`, ...[]), ...[" ", "/"]);
        closure15(undefined, v784);
        patternInput[1].l0(v784);
    }
}

export function closure9(v0_1: int32, v1_1: Error): US5_$union {
    let v4: any;
    closure10(v0_1, v1_1, undefined);
    v4 = undefined;
    return US5_US5_1();
}

export function method7(v0_1_mut: int32, v1_1_mut: (() => void), v2_1_mut: int32): US4_$union {
    method7:
    while (true) {
        const v0_1: int32 = v0_1_mut, v1_1: (() => void) = v1_1_mut, v2_1: int32 = v2_1_mut;
        const result: FSharpRef<US5_$union> = new FSharpRef<US5_$union>(US5_US5_1());
        try {
            result.contents = closure7(undefined, closure8(v0_1, v1_1, v2_1, undefined));
        }
        catch (ex: any) {
            result.contents = closure9(v2_1, ex);
        }
        const v7: US5_$union = result.contents;
        if (v7.tag === /* US5_0 */ 0) {
            return v7.fields[0];
        }
        else {
            v0_1_mut = v0_1;
            v1_1_mut = v1_1;
            v2_1_mut = (v2_1 + 1);
            continue method7;
        }
        break;
    }
}

export function closure6(v0_1: int32, v1_1: (() => void)): Option<void> {
    const v3: US4_$union = method7(v0_1, v1_1, 0);
    if (v3.tag === /* US4_0 */ 0) {
        return some(undefined);
    }
    else {
        return undefined;
    }
}

export function closure5(unitVar: void, v0_1: int32): ((arg0: (() => void)) => Option<void>) {
    return (v: (() => void)): Option<void> => closure6(v0_1, v);
}

export function method12(v0_1: (() => void)): (() => void) {
    return v0_1;
}

export function closure18(v0_1: any, unitVar: void): void {
    v0_1.Value;
}

export function closure17(unitVar: void, v0_1: (() => void)): (() => void) {
    const v1_1: (() => void) = method12(v0_1);
    const v2_1: any = new Lazy<void>((): void => {
        v1_1();
    });
    return (): void => {
        closure18(v2_1, undefined);
    };
}

export const v0: any = undefined;

export const v1 = (): void => {
    closure0(undefined, undefined);
};

export const v2: any = (v1(), v0);

export const v16 = (v: (() => void)): IDisposable => closure4(undefined, v);

export function new_disposable(x: (() => void)): IDisposable {
    return v16(x);
}

export const v17 = (v: int32): ((arg0: (() => void)) => Option<void>) => closure5(undefined, v);

export function retry_fn(x: int32): ((arg0: (() => void)) => Option<void>) {
    return v17(x);
}

export const v18 = (v: (() => void)): (() => void) => closure17(undefined, v);

export function memoize(x: (() => void)): (() => void) {
    return v18(x);
}


