import { Lazy, compare, IComparable, IEquatable, IDisposable, createAtom } from "../../deps/Fable/src/fable-library-ts/Util.js";
import { some, defaultArg, value, Option } from "../../deps/Fable/src/fable-library-ts/Option.js";
import { op_Addition, op_Subtraction, toInt64, int64 } from "../../deps/Fable/src/fable-library-ts/BigInt.js";
import { bool_type, lambda_type, unit_type, string_type, record_type, int64_type, union_type, class_type, TypeInfo } from "../../deps/Fable/src/fable-library-ts/Reflection.js";
import { FSharpRef, Record, Union } from "../../deps/Fable/src/fable-library-ts/Types.js";
import { create, toString, now, getTicks } from "../../deps/Fable/src/fable-library-ts/Date.js";
import { int32 } from "../../deps/Fable/src/fable-library-ts/Int32.js";
import { trimStart, trimEnd, padLeft, interpolate, toText } from "../../deps/Fable/src/fable-library-ts/String.js";
import { milliseconds, seconds, minutes, hours, fromTicks } from "../../deps/Fable/src/fable-library-ts/TimeSpan.js";
import { ofSeq, find } from "../../deps/Fable/src/fable-library-ts/Map.js";

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

export type US3_$cases = {
    0: ["US3_0", [string]],
    1: ["US3_1", []]
}

export function US3_US3_0(f0_0: string) {
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
    return union_type("Common.US3", [], US3, () => [[["f0_0", string_type]], []]);
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

export function method0(): string {
    return "TRACE_LEVEL";
}

export function method2(): string {
    return "";
}

export function method1(v0_1: string): string {
    let _v1: Option<string> = undefined;
    const x: string = process.env[v0_1] ?? "";
    _v1 = x;
    if (_v1 == null) {
        throw new Error("base.run_target / _v1=None");
    }
    else {
        return value(_v1);
    }
}

export function method3(): string {
    return "AUTOMATION";
}

export function closure1(unitVar: void, v0_1: string): void {
}

export function closure0(unitVar: void, v0_1: US0_$union): [Mut0, Mut1, Mut2, Mut3, Option<int64>] {
    let v84: US1_$union, v92: US1_$union, v100: US1_$union, v108: US1_$union;
    let _v1: Option<[US1_$union, US2_$union]> = undefined;
    const v70: string = method1(method0());
    const v76: US1_$union = ("Verbose" === v70) ? US1_US1_0(US0_US0_0()) : US1_US1_1();
    const x = [(v76.tag === /* US1_0 */ 0) ? US1_US1_0(v76.fields[0]) : ((v84 = (("Debug" === v70) ? US1_US1_0(US0_US0_1()) : US1_US1_1()), (v84.tag === /* US1_0 */ 0) ? US1_US1_0(v84.fields[0]) : ((v92 = (("Info" === v70) ? US1_US1_0(US0_US0_2()) : US1_US1_1()), (v92.tag === /* US1_0 */ 0) ? US1_US1_0(v92.fields[0]) : ((v100 = (("Warning" === v70) ? US1_US1_0(US0_US0_3()) : US1_US1_1()), (v100.tag === /* US1_0 */ 0) ? US1_US1_0(v100.fields[0]) : ((v108 = (("Critical" === v70) ? US1_US1_0(US0_US0_4()) : US1_US1_1()), (v108.tag === /* US1_0 */ 0) ? US1_US1_0(v108.fields[0]) : US1_US1_1())))))))), (method1(method3()) === "True") ? US2_US2_0(getTicks(now())) : US2_US2_1()] as [US1_$union, US2_$union];
    _v1 = x;
    let patternInput: [US1_$union, US2_$union];
    if (_v1 == null) {
        throw new Error("base.run_target / _v1=None");
    }
    else {
        patternInput = value(_v1);
    }
    const v259: US2_$union = patternInput[1];
    const v258: US1_$union = patternInput[0];
    return [new Mut0(0n), new Mut1((v: string): void => {
        closure1(undefined, v);
    }), new Mut2(true), new Mut3((v258.tag === /* US1_0 */ 0) ? v258.fields[0] : v0_1), (v259.tag === /* US2_0 */ 0) ? v259.fields[0] : undefined] as [Mut0, Mut1, Mut2, Mut3, Option<int64>];
}

export function method4(v0_1: (() => void)): (() => void) {
    return v0_1;
}

export function method5(v0_1: (() => void)): (() => void) {
    return v0_1;
}

export function closure2(unitVar: void, v0_1: (() => void)): IDisposable {
    let _v1: Option<IDisposable> = undefined;
    const v8: (() => void) = method5(v0_1);
    const x: IDisposable = {
        Dispose(): void {
            v8();
        },
    };
    _v1 = x;
    if (_v1 == null) {
        throw new Error("base.run_target / _v1=None");
    }
    else {
        return value(_v1);
    }
}

export function closure5(unitVar: void, v0_1: US4_$union): US5_$union {
    return US5_US5_0(v0_1);
}

export function closure6(v0_1: int32, v1_1: (() => void), v2_1: int32, unitVar: void): US4_$union {
    if (v2_1 < v0_1) {
        v1_1();
        return US4_US4_0();
    }
    else {
        return US4_US4_1();
    }
}

export function closure8(unitVar: void, unitVar_1: void): string {
    return "common.retry_fn";
}

export function closure9(v0_1: int32, v1_1: Error, unitVar: void): [int32, Error] {
    return [v0_1, v1_1] as [int32, Error];
}

export function method8(): string {
    return "hh:mm:ss";
}

export function method9(): string {
    return "";
}

export function method10(): string {
    return "HH:mm:ss";
}

export function method11(): string {
    return "\u001b[0m";
}

export function method13(v0_1: Mut4, v1_1: string): void {
    const v2_1 = `${v1_1}`;
    const v4_1: string = v0_1.l0 + v2_1;
    v0_1.l0 = v4_1;
}

export function method14(v0_1: Mut4): void {
}

export function method15(v0_1: Mut4, v1_1: int32): void {
    const v2_1 = `${v1_1}`;
    const v4_1: string = v0_1.l0 + v2_1;
    v0_1.l0 = v4_1;
}

export function method16(v0_1: Mut4, v1_1: Error): void {
    method13(v0_1, toText(interpolate("%A%P()", [v1_1])));
}

export function method12(v0_1: Mut4, v1_1: int32, v2_1: Error): void {
    method13(v0_1, "{ ");
    method14(v0_1);
    method13(v0_1, "retry");
    method13(v0_1, " = ");
    method15(v0_1, v1_1);
    method13(v0_1, "; ");
    method13(v0_1, "ex");
    method13(v0_1, " = ");
    method16(v0_1, v2_1);
    method13(v0_1, " }");
}

export function closure10(v0_1: US0_$union, v1_1: (() => string), v2_1: (() => [int32, Error]), unitVar: void): string {
    let v74: int64, v80: number;
    if (State_trace_state() == null) {
        State_trace_state(closure0(undefined, US0_US0_0()));
    }
    const patternInput: [Mut0, Mut1, Mut2, Mut3, Option<int64>] = value(State_trace_state());
    const v9: Option<int64> = patternInput[4];
    let _v10: Option<string> = undefined;
    const _v68: FSharpRef<Option<US2_$union>> = new FSharpRef<Option<US2_$union>>(undefined);
    let x_2: Option<US2_$union>;
    if (v9 == null) {
        x_2 = undefined;
    }
    else {
        const x: int64 = value(v9);
        x_2 = ((): US2_$union => US2_US2_0(x))();
    }
    _v68.contents = x_2;
    const v73: US2_$union = defaultArg(_v68.contents, US2_US2_1());
    const x_3: string = toString((v73.tag === /* US2_0 */ 0) ? ((v74 = v73.fields[0], (v80 = fromTicks(toInt64(op_Subtraction(getTicks(now()), v74))), create(1, 1, 1, hours(v80), minutes(v80), seconds(v80), milliseconds(v80))))) : now(), method10());
    _v10 = x_3;
    let v152: string;
    if (_v10 == null) {
        throw new Error("base.run_target / _v10=None");
    }
    else {
        v152 = value(_v10);
    }
    const v159: US3_$union = (v0_1.tag === /* US0_0 */ 0) ? US3_US3_0("Verbose") : US3_US3_1();
    let v208: US3_$union;
    if (v159.tag === /* US3_0 */ 0) {
        v208 = US3_US3_0(v159.fields[0]);
    }
    else {
        const v168: US3_$union = (v0_1.tag === /* US0_1 */ 1) ? US3_US3_0("Debug") : US3_US3_1();
        if (v168.tag === /* US3_0 */ 0) {
            v208 = US3_US3_0(v168.fields[0]);
        }
        else {
            const v177: US3_$union = (v0_1.tag === /* US0_2 */ 2) ? US3_US3_0("Info") : US3_US3_1();
            if (v177.tag === /* US3_0 */ 0) {
                v208 = US3_US3_0(v177.fields[0]);
            }
            else {
                const v186: US3_$union = (v0_1.tag === /* US0_3 */ 3) ? US3_US3_0("Warning") : US3_US3_1();
                if (v186.tag === /* US3_0 */ 0) {
                    v208 = US3_US3_0(v186.fields[0]);
                }
                else {
                    const v195: US3_$union = (v0_1.tag === /* US0_4 */ 4) ? US3_US3_0("Critical") : US3_US3_1();
                    v208 = ((v195.tag === /* US3_0 */ 0) ? US3_US3_0(v195.fields[0]) : US3_US3_1());
                }
            }
        }
    }
    let v212: string;
    if (v208.tag === /* US3_0 */ 0) {
        v212 = v208.fields[0];
    }
    else {
        throw new Error("Option does not have a value.");
    }
    const v215: string = padLeft(v212.toLocaleLowerCase(), 7, " ");
    let _v216: Option<string> = undefined;
    const x_5: string = (((v0_1.tag === /* US0_1 */ 1) ? "\u001b[94m" : ((v0_1.tag === /* US0_2 */ 2) ? "\u001b[92m" : ((v0_1.tag === /* US0_0 */ 0) ? "\u001b[90m" : ((v0_1.tag === /* US0_3 */ 3) ? "\u001b[93m" : "\u001b[91m")))) + v215) + method11();
    _v216 = x_5;
    let v328: string;
    if (_v216 == null) {
        throw new Error("base.run_target / _v216=None");
    }
    else {
        v328 = value(_v216);
    }
    const v329: int64 = patternInput[0].l0;
    const patternInput_1: [int32, Error] = v2_1();
    const v333: Mut4 = new Mut4("");
    method12(v333, patternInput_1[0], patternInput_1[1]);
    const v334: string = v333.l0;
    return trimEnd(trimStart(`${v152} ${v328} #${v329} ${v1_1()} / ${v334}`, ...[]), ...[" ", "/"]);
}

export function method17(v0_1: US0_$union, v1_1: (() => string)): void {
    const v2_1 = (v: US0_$union): [Mut0, Mut1, Mut2, Mut3, Option<int64>] => closure0(undefined, v);
    if (State_trace_state() == null) {
        State_trace_state(v2_1(US0_US0_0()));
    }
    const patternInput: [Mut0, Mut1, Mut2, Mut3, Option<int64>] = value(State_trace_state());
    const v4_1: Mut0 = patternInput[0];
    if (State_trace_state() == null) {
        State_trace_state(v2_1(US0_US0_0()));
    }
    const patternInput_1: [Mut0, Mut1, Mut2, Mut3, Option<int64>] = value(State_trace_state());
    const v15: US0_$union = patternInput_1[3].l0;
    if ((patternInput_1[2].l0 === false) ? false : (find<US0_$union, int32>(v0_1, ofSeq([[US0_US0_0(), 0] as [US0_$union, int32], [US0_US0_1(), 1] as [US0_$union, int32], [US0_US0_2(), 2] as [US0_$union, int32], [US0_US0_3(), 3] as [US0_$union, int32], [US0_US0_4(), 4] as [US0_$union, int32]], {
        Compare: compare,
    })) >= find<US0_$union, int32>(v15, ofSeq([[US0_US0_0(), 0] as [US0_$union, int32], [US0_US0_1(), 1] as [US0_$union, int32], [US0_US0_2(), 2] as [US0_$union, int32], [US0_US0_3(), 3] as [US0_$union, int32], [US0_US0_4(), 4] as [US0_$union, int32]], {
        Compare: compare,
    })))) {
        const v23: int64 = toInt64(op_Addition(v4_1.l0, 1n));
        v4_1.l0 = v23;
        const v24 = `${v1_1()}`;
        let _v25: Option<void> = undefined;
        console.log(v24);
        _v25 = some(undefined);
        if (_v25 == null) {
            throw new Error("base.run_target / _v25=None");
        }
        else {
            value(_v25);
        }
        patternInput[1].l0(v24);
    }
}

export function method7(v0_1: US0_$union, v1_1: (() => string), v2_1: (() => [int32, Error])): void {
    method17(v0_1, (): string => closure10(v0_1, v1_1, v2_1, undefined));
}

export function closure7(v0_1: int32, v1_1: Error): US5_$union {
    method7(US0_US0_3(), (): string => closure8(undefined, undefined), (): [int32, Error] => closure9(v0_1, v1_1, undefined));
    return US5_US5_1();
}

export function method6(v0_1_mut: int32, v1_1_mut: (() => void), v2_1_mut: int32): US4_$union {
    method6:
    while (true) {
        const v0_1: int32 = v0_1_mut, v1_1: (() => void) = v1_1_mut, v2_1: int32 = v2_1_mut;
        const result: FSharpRef<US5_$union> = new FSharpRef<US5_$union>(US5_US5_1());
        try {
            result.contents = closure5(undefined, closure6(v0_1, v1_1, v2_1, undefined));
        }
        catch (ex: any) {
            result.contents = closure7(v2_1, ex);
        }
        const v7: US5_$union = result.contents;
        if (v7.tag === /* US5_0 */ 0) {
            return v7.fields[0];
        }
        else {
            v0_1_mut = v0_1;
            v1_1_mut = v1_1;
            v2_1_mut = (v2_1 + 1);
            continue method6;
        }
        break;
    }
}

export function closure4(v0_1: int32, v1_1: (() => void)): Option<void> {
    const v3_1: US4_$union = method6(v0_1, v1_1, 0);
    if (v3_1.tag === /* US4_0 */ 0) {
        return some(undefined);
    }
    else {
        return undefined;
    }
}

export function closure3(unitVar: void, v0_1: int32): ((arg0: (() => void)) => Option<void>) {
    return (v: (() => void)): Option<void> => closure4(v0_1, v);
}

export function method18(v0_1: (() => void)): (() => void) {
    return v0_1;
}

export function closure12(v0_1: any, unitVar: void): void {
    v0_1.Value;
}

export function closure11(unitVar: void, v0_1: (() => void)): (() => void) {
    const v1_1: (() => void) = method18(v0_1);
    const v2_1: any = new Lazy<void>((): void => {
        v1_1();
    });
    return (): void => {
        closure12(v2_1, undefined);
    };
}

export const v0 = (v: US0_$union): [Mut0, Mut1, Mut2, Mut3, Option<int64>] => closure0(undefined, v);

export const v1: US0_$union = US0_US0_0();

if (State_trace_state() == null) {
    State_trace_state(v0(v1));
}

export const v2 = (v: (() => void)): IDisposable => closure2(undefined, v);

export function new_disposable(x: (() => void)): IDisposable {
    return v2(x);
}

export const v3 = (v: int32): ((arg0: (() => void)) => Option<void>) => closure3(undefined, v);

export function retry_fn(x: int32): ((arg0: (() => void)) => Option<void>) {
    return v3(x);
}

export const v4 = (v: (() => void)): (() => void) => closure11(undefined, v);

export function memoize(x: (() => void)): (() => void) {
    return v4(x);
}


