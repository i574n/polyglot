import { compare, defaultOf, IComparable, IEquatable, IDisposable, createAtom } from "../../../polyglot/deps/Fable/src/fable-library-ts/Util.js";
import { value as value_1, some, Option } from "../../../polyglot/deps/Fable/src/fable-library-ts/Option.js";
import { op_Addition, toInt64, int64 } from "../../../polyglot/deps/Fable/src/fable-library-ts/BigInt.js";
import { lambda_type, unit_type, string_type, union_type, bool_type, record_type, int64_type, class_type, TypeInfo } from "../../../polyglot/deps/Fable/src/fable-library-ts/Reflection.js";
import { FSharpRef, Union, Record } from "../../../polyglot/deps/Fable/src/fable-library-ts/Types.js";
import { int32 } from "../../../polyglot/deps/Fable/src/fable-library-ts/Int32.js";
import { trimStart, trimEnd, padRight, interpolate, toText } from "../../../polyglot/deps/Fable/src/fable-library-ts/String.js";
import { ofSeq, find } from "../../../polyglot/deps/Fable/src/fable-library-ts/Map.js";

export let State_trace_state = createAtom<Option<[Mut0, Mut1, Mut2, Option<int64>, Mut3]>>(undefined);

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

export class Mut1 extends Record implements IEquatable<Mut1>, IComparable<Mut1> {
    l0: boolean;
    constructor(l0: boolean) {
        super();
        this.l0 = l0;
    }
}

export function Mut1_$reflection(): TypeInfo {
    return record_type("Common.Mut1", [], Mut1, () => [["l0", bool_type]]);
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

export class Mut2 extends Record implements IEquatable<Mut2>, IComparable<Mut2> {
    l0: US0_$union;
    constructor(l0: US0_$union) {
        super();
        this.l0 = l0;
    }
}

export function Mut2_$reflection(): TypeInfo {
    return record_type("Common.Mut2", [], Mut2, () => [["l0", US0_$reflection()]]);
}

export class Mut3 extends Record {
    l0: ((arg0: string) => void);
    constructor(l0: ((arg0: string) => void)) {
        super();
        this.l0 = l0;
    }
}

export function Mut3_$reflection(): TypeInfo {
    return record_type("Common.Mut3", [], Mut3, () => [["l0", lambda_type(string_type, unit_type)]]);
}

export type US1_$union = 
    | US1<0>
    | US1<1>

export type US1_$cases = {
    0: ["US1_0", [int64]],
    1: ["US1_1", []]
}

export function US1_US1_0(f0_0: int64) {
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
    return union_type("Common.US1", [], US1, () => [[["f0_0", int64_type]], []]);
}

export type US2_$union = 
    | US2<0>
    | US2<1>

export type US2_$cases = {
    0: ["US2_0", []],
    1: ["US2_1", []]
}

export function US2_US2_0() {
    return new US2<0>(0, []);
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
    return union_type("Common.US2", [], US2, () => [[], []]);
}

export type US3_$union = 
    | US3<0>
    | US3<1>

export type US3_$cases = {
    0: ["US3_0", [US2_$union]],
    1: ["US3_1", []]
}

export function US3_US3_0(f0_0: US2_$union) {
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
    return union_type("Common.US3", [], US3, () => [[["f0_0", US2_$reflection()]], []]);
}

export type US4_$union = 
    | US4<0>
    | US4<1>

export type US4_$cases = {
    0: ["US4_0", [int64]],
    1: ["US4_1", []]
}

export function US4_US4_0(f0_0: int64) {
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
    return union_type("Common.US4", [], US4, () => [[["f0_0", int64_type]], []]);
}

export function US0__get_IsUS0_0(this$: FSharpRef<US0_$union>, unitArg: void): boolean {
    if ((this$ as any)['tag'] === 0) {
        return true;
    }
    else {
        return false;
    }
}

export function US0__get_IsUS0_1(this$: FSharpRef<US0_$union>, unitArg: void): boolean {
    if ((this$ as any)['tag'] === 1) {
        return true;
    }
    else {
        return false;
    }
}

export function US0__get_IsUS0_2(this$: FSharpRef<US0_$union>, unitArg: void): boolean {
    if ((this$ as any)['tag'] === 2) {
        return true;
    }
    else {
        return false;
    }
}

export function US0__get_IsUS0_3(this$: FSharpRef<US0_$union>, unitArg: void): boolean {
    if ((this$ as any)['tag'] === 3) {
        return true;
    }
    else {
        return false;
    }
}

export function US0__get_IsUS0_4(this$: FSharpRef<US0_$union>, unitArg: void): boolean {
    if ((this$ as any)['tag'] === 4) {
        return true;
    }
    else {
        return false;
    }
}

export function US1__get_IsUS1_0(this$: FSharpRef<US1_$union>, unitArg: void): boolean {
    if ((this$ as any)['tag'] === 0) {
        return true;
    }
    else {
        return false;
    }
}

export function US1__get_IsUS1_1(this$: FSharpRef<US1_$union>, unitArg: void): boolean {
    if ((this$ as any)['tag'] === 1) {
        return true;
    }
    else {
        return false;
    }
}

export function US2__get_IsUS2_0(this$: FSharpRef<US2_$union>, unitArg: void): boolean {
    if ((this$ as any)['tag'] === 0) {
        return true;
    }
    else {
        return false;
    }
}

export function US2__get_IsUS2_1(this$: FSharpRef<US2_$union>, unitArg: void): boolean {
    if ((this$ as any)['tag'] === 1) {
        return true;
    }
    else {
        return false;
    }
}

export function US3__get_IsUS3_0(this$: FSharpRef<US3_$union>, unitArg: void): boolean {
    if ((this$ as any)['tag'] === 0) {
        return true;
    }
    else {
        return false;
    }
}

export function US3__get_IsUS3_1(this$: FSharpRef<US3_$union>, unitArg: void): boolean {
    if ((this$ as any)['tag'] === 1) {
        return true;
    }
    else {
        return false;
    }
}

export function US4__get_IsUS4_0(this$: FSharpRef<US4_$union>, unitArg: void): boolean {
    if ((this$ as any)['tag'] === 0) {
        return true;
    }
    else {
        return false;
    }
}

export function US4__get_IsUS4_1(this$: FSharpRef<US4_$union>, unitArg: void): boolean {
    if ((this$ as any)['tag'] === 1) {
        return true;
    }
    else {
        return false;
    }
}

export function closure1(unitVar: void, v0_1: string): void {
}

export function method0(v0_1: Option<int64>): Option<int64> {
    return v0_1;
}

export function method1(v0_1: Option<int64>): Option<int64> {
    return v0_1;
}

export function closure0(unitVar: void, unitVar_1: void): [Mut0, Mut1, Mut2, Option<int64>, Mut3] {
    const v0_1: Mut1 = new Mut1(true);
    const v1_1: Mut0 = new Mut0(0n);
    const v3: Mut2 = new Mut2(US0_US0_0());
    const v5: Mut3 = new Mut3((v: string): void => {
        closure1(undefined, v);
    });
    let _v6: Option<Option<int64>> = undefined;
    const x: Option<int64> = method1(undefined);
    _v6 = some(x);
    return [v1_1, v0_1, v3, value_1(_v6), v5] as [Mut0, Mut1, Mut2, Option<int64>, Mut3];
}

export function method2(v0_1: (() => void)): (() => void) {
    return v0_1;
}

export function closure2(unitVar: void, v0_1: (() => void)): IDisposable {
    let _v1: Option<IDisposable> = undefined;
    const x: IDisposable = defaultOf();
    _v1 = x;
    return value_1(_v1);
}

export function closure5(v0_1: int32, v1_1: (() => void), v2_1: int32, unitVar: void): US2_$union {
    if (v2_1 < v0_1) {
        v1_1();
        return US2_US2_0();
    }
    else {
        return US2_US2_1();
    }
}

export function closure6(unitVar: void, v0_1: US2_$union): US3_$union {
    return US3_US3_0(v0_1);
}

export function closure8(unitVar: void, unitVar_1: void): string {
    return "retry_fn";
}

export function closure10(unitVar: void, unitVar_1: void): string {
    return "";
}

export function closure9(v0_1: int32, v1_1: Error, unitVar: void): string {
    return toText(interpolate("retry: %P() / ex: %A%P() / %P()", [v0_1, v1_1, closure10(undefined, undefined)]));
}

export function closure12(unitVar: void, v0_1: int64): US4_$union {
    return US4_US4_0(v0_1);
}

export function method5(): ((arg0: int64) => US4_$union) {
    return (v: int64): US4_$union => closure12(undefined, v);
}

export function method6(): string {
    return "";
}

export function closure11(v0_1: US0_$union, v1_1: (() => string), v2_1: (() => string), unitVar: void): string {
    if (State_trace_state() == null) {
        State_trace_state(closure0(undefined, undefined));
    }
    const patternInput: [Mut0, Mut1, Mut2, Option<int64>, Mut3] = value_1(State_trace_state());
    let _v9: Option<string> = undefined;
    const x: string = method6();
    _v9 = x;
    const v61: string = value_1(_v9);
    const v62: int64 = patternInput[0].l0;
    const v72: string = (v0_1.tag === /* US0_1 */ 1) ? "Debug" : ((v0_1.tag === /* US0_2 */ 2) ? "Info" : ((v0_1.tag === /* US0_0 */ 0) ? "Verbose" : ((v0_1.tag === /* US0_3 */ 3) ? "Warning" : "Critical")));
    let _v75: Option<string> = undefined;
    const x_1: string = padRight(v72.toLocaleLowerCase(), 7, " ");
    _v75 = x_1;
    return trimEnd(trimStart(`${v61} ${value_1(_v75)} #${v62} ${v1_1()} / ${v2_1()}`), " ", "/");
}

export function method7(v0_1: US0_$union, v1_1: (() => string)): void {
    const v2_1 = (): [Mut0, Mut1, Mut2, Option<int64>, Mut3] => closure0(undefined, undefined);
    if (State_trace_state() == null) {
        State_trace_state(v2_1());
    }
    const patternInput: [Mut0, Mut1, Mut2, Option<int64>, Mut3] = value_1(State_trace_state());
    const v3: Mut0 = patternInput[0];
    if (State_trace_state() == null) {
        State_trace_state(v2_1());
    }
    const patternInput_1: [Mut0, Mut1, Mut2, Option<int64>, Mut3] = value_1(State_trace_state());
    const v13: US0_$union = patternInput_1[2].l0;
    if ((patternInput_1[1].l0 === false) ? false : (find<US0_$union, int32>(v0_1, ofSeq([[US0_US0_0(), 0] as [US0_$union, int32], [US0_US0_1(), 1] as [US0_$union, int32], [US0_US0_2(), 2] as [US0_$union, int32], [US0_US0_3(), 3] as [US0_$union, int32], [US0_US0_4(), 4] as [US0_$union, int32]], {
        Compare: compare,
    })) >= find<US0_$union, int32>(v13, ofSeq([[US0_US0_0(), 0] as [US0_$union, int32], [US0_US0_1(), 1] as [US0_$union, int32], [US0_US0_2(), 2] as [US0_$union, int32], [US0_US0_3(), 3] as [US0_$union, int32], [US0_US0_4(), 4] as [US0_$union, int32]], {
        Compare: compare,
    })))) {
        const v21: int64 = toInt64(op_Addition(v3.l0, 1n));
        v3.l0 = v21;
        const v22 = `${v1_1()}`;
        let _v23: Option<void> = undefined;
        console.log(v22);
        _v23 = some(undefined);
        value_1(_v23);
        patternInput[4].l0(v22);
    }
}

export function method4(v0_1: US0_$union, v1_1: (() => string), v2_1: (() => string)): void {
    method7(v0_1, (): string => closure11(v0_1, v1_1, v2_1, undefined));
}

export function closure7(v0_1: int32, v1_1: Error): US3_$union {
    method4(US0_US0_3(), (): string => closure8(undefined, undefined), (): string => closure9(v0_1, v1_1, undefined));
    let _v5: Option<void> = undefined;
    _v5 = some(undefined);
    value_1(_v5);
    return US3_US3_1();
}

export function method3(v0_1_mut: int32, v1_1_mut: (() => void), v2_1_mut: int32): US2_$union {
    method3:
    while (true) {
        const v0_1: int32 = v0_1_mut, v1_1: (() => void) = v1_1_mut, v2_1: int32 = v2_1_mut;
        let v6: US3_$union;
        try {
            v6 = closure6(undefined, closure5(v0_1, v1_1, v2_1, undefined));
        }
        catch (ex: any) {
            v6 = closure7(v2_1, ex);
        }
        if (v6.tag === /* US3_0 */ 0) {
            return v6.fields[0];
        }
        else {
            v0_1_mut = v0_1;
            v1_1_mut = v1_1;
            v2_1_mut = (v2_1 + 1);
            continue method3;
        }
        break;
    }
}

export function closure4(v0_1: int32, v1_1: (() => void)): Option<void> {
    const v3: US2_$union = method3(v0_1, v1_1, 0);
    if (v3.tag === /* US2_0 */ 0) {
        return some(undefined);
    }
    else {
        return undefined;
    }
}

export function closure3(unitVar: void, v0_1: int32): ((arg0: (() => void)) => Option<void>) {
    return (v: (() => void)): Option<void> => closure4(v0_1, v);
}

export const v0 = (): [Mut0, Mut1, Mut2, Option<int64>, Mut3] => closure0(undefined, undefined);

if (State_trace_state() == null) {
    State_trace_state(v0());
}

export const v1 = (v: (() => void)): IDisposable => closure2(undefined, v);

export function new_disposable(x: (() => void)): IDisposable {
    return v1(x);
}

export const v2 = (v: int32): ((arg0: (() => void)) => Option<void>) => closure3(undefined, v);

export function retry_fn(x: int32): ((arg0: (() => void)) => Option<void>) {
    return v2(x);
}


