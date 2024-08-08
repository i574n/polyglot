import { Lazy, compare, IComparable, IEquatable, IDisposable, createAtom } from "../../deps/Fable/src/fable-library-ts/Util.js";
import { some, defaultArg, value, Option } from "../../deps/Fable/src/fable-library-ts/Option.js";
import { op_Subtraction, op_Addition, toInt64, int64 } from "../../deps/Fable/src/fable-library-ts/BigInt.js";
import { bool_type, lambda_type, unit_type, string_type, record_type, int64_type, union_type, class_type, TypeInfo } from "../../deps/Fable/src/fable-library-ts/Reflection.js";
import { FSharpRef, Record, Union } from "../../deps/Fable/src/fable-library-ts/Types.js";
import { create, toString, now, getTicks } from "../../deps/Fable/src/fable-library-ts/Date.js";
import { int32 } from "../../deps/Fable/src/fable-library-ts/Int32.js";
import { ofSeq, find } from "../../deps/Fable/src/fable-library-ts/Map.js";
import { milliseconds, seconds, minutes, hours, fromTicks } from "../../deps/Fable/src/fable-library-ts/TimeSpan.js";
import { trimStart, trimEnd, interpolate, toText, padLeft } from "../../deps/Fable/src/fable-library-ts/String.js";

export let State_trace_state = createAtom<Option<[Mut0, Mut1, Mut2, Mut3, Option<int64>]>>(undefined);

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
    l0: US0_$union;
    constructor(l0: US0_$union) {
        super();
        this.l0 = l0;
    }
}

export function Mut3_$reflection(): TypeInfo {
    return record_type("Common.Mut3", [], Mut3, () => [["l0", US0_$reflection()]]);
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

export class Mut4 extends Record implements IEquatable<Mut4>, IComparable<Mut4> {
    l0: string;
    constructor(l0: string) {
        super();
        this.l0 = l0;
    }
}

export function Mut4_$reflection(): TypeInfo {
    return record_type("Common.Mut4", [], Mut4, () => [["l0", string_type]]);
}

export function method1(): string {
    return "TRACE_LEVEL";
}

export function method3(): string {
    return "";
}

export function method2(v0_1: string): string {
    return process.env[v0_1] ?? "";
}

export function method4(): string {
    return "AUTOMATION";
}

export function closure0(unitVar: void, v0_1: string): void {
}

export function method0(v0_1: US0_$union): [Mut0, Mut1, Mut2, Mut3, Option<int64>] {
    let v124: US2_$union, v131: US2_$union, v138: US2_$union, v145: US2_$union;
    const v112: string = method2(method1());
    const v117: US2_$union = ("Verbose" === v112) ? US2_US2_0(US0_US0_0()) : US2_US2_1();
    const _v1 = [(v117.tag === /* US2_0 */ 0) ? US2_US2_0(v117.fields[0]) : ((v124 = (("Debug" === v112) ? US2_US2_0(US0_US0_1()) : US2_US2_1()), (v124.tag === /* US2_0 */ 0) ? US2_US2_0(v124.fields[0]) : ((v131 = (("Info" === v112) ? US2_US2_0(US0_US0_2()) : US2_US2_1()), (v131.tag === /* US2_0 */ 0) ? US2_US2_0(v131.fields[0]) : ((v138 = (("Warning" === v112) ? US2_US2_0(US0_US0_3()) : US2_US2_1()), (v138.tag === /* US2_0 */ 0) ? US2_US2_0(v138.fields[0]) : ((v145 = (("Critical" === v112) ? US2_US2_0(US0_US0_4()) : US2_US2_1()), (v145.tag === /* US2_0 */ 0) ? US2_US2_0(v145.fields[0]) : US2_US2_1())))))))), (method2(method4()) === "True") ? US3_US3_0(getTicks(now())) : US3_US3_1()] as [US2_$union, US3_$union];
    const v295: US3_$union = _v1[1];
    const v294: US2_$union = _v1[0];
    return [new Mut0(0n), new Mut1((v: string): void => {
        closure0(undefined, v);
    }), new Mut2(true), new Mut3((v294.tag === /* US2_0 */ 0) ? v294.fields[0] : v0_1), (v295.tag === /* US3_0 */ 0) ? v295.fields[0] : undefined] as [Mut0, Mut1, Mut2, Mut3, Option<int64>];
}

export function method5(v0_1: (() => void)): (() => void) {
    return v0_1;
}

export function method6(v0_1: (() => void)): (() => void) {
    return v0_1;
}

export function closure1(unitVar: void, v0_1: (() => void)): IDisposable {
    const v8: (() => void) = method6(v0_1);
    return {
        Dispose(): void {
            v8();
        },
    };
}

export function closure4(unitVar: void, v0_1: US4_$union): US5_$union {
    return US5_US5_0(v0_1);
}

export function closure5(v0_1: int32, v1: (() => void), v2: int32, unitVar: void): US4_$union {
    if (v2 < v0_1) {
        v1();
        return US4_US4_0();
    }
    else {
        return US4_US4_1();
    }
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

export function closure7(unitVar: void, unitVar_1: void): string {
    return "common.retry_fn";
}

export function closure6(v0_1: int32, v1: Error): US5_$union {
    let v274: int64, v284: number;
    if (State_trace_state() == null) {
        const patternInput: [Mut0, Mut1, Mut2, Mut3, Option<int64>] = method0(US0_US0_0());
        State_trace_state([patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4]] as [Mut0, Mut1, Mut2, Mut3, Option<int64>]);
    }
    const patternInput_1: [Mut0, Mut1, Mut2, Mut3, Option<int64>] = value(State_trace_state());
    const v14_1: Mut0 = patternInput_1[0];
    if (State_trace_state() == null) {
        const patternInput_2: [Mut0, Mut1, Mut2, Mut3, Option<int64>] = method0(US0_US0_0());
        State_trace_state([patternInput_2[0], patternInput_2[1], patternInput_2[2], patternInput_2[3], patternInput_2[4]] as [Mut0, Mut1, Mut2, Mut3, Option<int64>]);
    }
    const patternInput_3: [Mut0, Mut1, Mut2, Mut3, Option<int64>] = value(State_trace_state());
    const v56: US0_$union = patternInput_3[3].l0;
    if ((patternInput_3[2].l0 === false) ? false : (3 >= find<US0_$union, int32>(v56, ofSeq([[US0_US0_0(), 0] as [US0_$union, int32], [US0_US0_1(), 1] as [US0_$union, int32], [US0_US0_2(), 2] as [US0_$union, int32], [US0_US0_3(), 3] as [US0_$union, int32], [US0_US0_4(), 4] as [US0_$union, int32]], {
        Compare: compare,
    })))) {
        const v63: int64 = toInt64(op_Addition(v14_1.l0, 1n));
        v14_1.l0 = v63;
        if (State_trace_state() == null) {
            const patternInput_4: [Mut0, Mut1, Mut2, Mut3, Option<int64>] = method0(US0_US0_0());
            State_trace_state([patternInput_4[0], patternInput_4[1], patternInput_4[2], patternInput_4[3], patternInput_4[4]] as [Mut0, Mut1, Mut2, Mut3, Option<int64>]);
        }
        const patternInput_5: [Mut0, Mut1, Mut2, Mut3, Option<int64>] = value(State_trace_state());
        const v80: Option<int64> = patternInput_5[4];
        const _v255: FSharpRef<Option<US3_$union>> = new FSharpRef<Option<US3_$union>>(undefined);
        let x_3: Option<US3_$union>;
        if (v80 == null) {
            x_3 = undefined;
        }
        else {
            const x_1: int64 = value(v80);
            x_3 = ((): US3_$union => US3_US3_0(x_1))();
        }
        _v255.contents = x_3;
        const v270: US3_$union = defaultArg(_v255.contents, US3_US3_1());
        const v315: string = toString((v270.tag === /* US3_0 */ 0) ? ((v274 = v270.fields[0], (v284 = fromTicks(toInt64(op_Subtraction(getTicks(now()), v274))), create(1, 1, 1, hours(v284), minutes(v284), seconds(v284), milliseconds(v284))))) : now(), method9());
        const v565: string = ("\u001b[93m" + padLeft("Warning".toLocaleLowerCase(), 7, " ")) + method10();
        const v580: int64 = patternInput_5[0].l0;
        const v582: Mut4 = new Mut4(method11());
        const v584 = `${"{ "}`;
        const v588: string = v582.l0 + v584;
        v582.l0 = v588;
        const v590 = `${"retry"}`;
        const v594: string = v582.l0 + v590;
        v582.l0 = v594;
        const v596 = `${" = "}`;
        const v600: string = v582.l0 + v596;
        v582.l0 = v600;
        const v601 = `${v0_1}`;
        const v605: string = v582.l0 + v601;
        v582.l0 = v605;
        const v607 = `${"; "}`;
        const v611: string = v582.l0 + v607;
        v582.l0 = v611;
        const v613 = `${"ex"}`;
        const v617: string = v582.l0 + v613;
        v582.l0 = v617;
        const v618 = `${" = "}`;
        const v622: string = v582.l0 + v618;
        v582.l0 = v622;
        const v650 = `${toText(interpolate("%A%P()", [v1]))}`;
        const v654: string = v582.l0 + v650;
        v582.l0 = v654;
        const v656 = `${" }"}`;
        const v660: string = v582.l0 + v656;
        v582.l0 = v660;
        const v661: string = v582.l0;
        const v700: string = trimEnd(trimStart(`${v315} ${v565} #${v580} ${closure7(undefined, undefined)} / ${v661}`, ...[]), ...[" ", "/"]);
        console.log(v700);
        patternInput_1[1].l0(v700);
    }
    return US5_US5_1();
}

export function method7(v0_1_mut: int32, v1_mut: (() => void), v2_mut: int32): US4_$union {
    method7:
    while (true) {
        const v0_1: int32 = v0_1_mut, v1: (() => void) = v1_mut, v2: int32 = v2_mut;
        const result: FSharpRef<US5_$union> = new FSharpRef<US5_$union>(US5_US5_1());
        try {
            result.contents = closure4(undefined, closure5(v0_1, v1, v2, undefined));
        }
        catch (ex: any) {
            result.contents = closure6(v2, ex);
        }
        const v7: US5_$union = result.contents;
        if (v7.tag === /* US5_0 */ 0) {
            return v7.fields[0];
        }
        else {
            v0_1_mut = v0_1;
            v1_mut = v1;
            v2_mut = (v2 + 1);
            continue method7;
        }
        break;
    }
}

export function closure3(v0_1: int32, v1: (() => void)): Option<void> {
    const v3: US4_$union = method7(v0_1, v1, 0);
    if (v3.tag === /* US4_0 */ 0) {
        return some(undefined);
    }
    else {
        return undefined;
    }
}

export function closure2(unitVar: void, v0_1: int32): ((arg0: (() => void)) => Option<void>) {
    return (v: (() => void)): Option<void> => closure3(v0_1, v);
}

export function method12(v0_1: (() => void)): (() => void) {
    return v0_1;
}

export function closure9(v0_1: any, unitVar: void): void {
    v0_1.Value;
}

export function closure8(unitVar: void, v0_1: (() => void)): (() => void) {
    const v1: (() => void) = method12(v0_1);
    const v2: any = new Lazy<void>((): void => {
        v1();
    });
    return (): void => {
        closure9(v2, undefined);
    };
}

export const v0: boolean = State_trace_state() == null;

if (v0) {
    const patternInput: [Mut0, Mut1, Mut2, Mut3, Option<int64>] = method0(US0_US0_0());
    State_trace_state([patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4]] as [Mut0, Mut1, Mut2, Mut3, Option<int64>]);
}

export const v12 = (v: (() => void)): IDisposable => closure1(undefined, v);

export function new_disposable(x: (() => void)): IDisposable {
    return v12(x);
}

export const v13 = (v: int32): ((arg0: (() => void)) => Option<void>) => closure2(undefined, v);

export function retry_fn(x: int32): ((arg0: (() => void)) => Option<void>) {
    return v13(x);
}

export const v14 = (v: (() => void)): (() => void) => closure8(undefined, v);

export function memoize(x: (() => void)): (() => void) {
    return v14(x);
}


