import { IDisposable, defaultOf, compare, IComparable, IEquatable, createAtom } from "../../deps/Fable/src/fable-library-ts/Util.js";
import { map, defaultArg, value as value_3, Option } from "../../deps/Fable/src/fable-library-ts/Option.js";
import { op_Modulus, equals, op_Addition, op_Subtraction, fromInt64, toInt64, int64 } from "../../deps/Fable/src/fable-library-ts/BigInt.js";
import { Record, Union } from "../../deps/Fable/src/fable-library-ts/Types.js";
import { int32_type, class_type, bool_type, lambda_type, unit_type, string_type, record_type, int64_type, union_type, TypeInfo } from "../../deps/Fable/src/fable-library-ts/Reflection.js";
import { int32 } from "../../deps/Fable/src/fable-library-ts/Int32.js";
import { create, toString, now, getTicks } from "../../deps/Fable/src/fable-library-ts/Date.js";
import { ofSeq, find } from "../../deps/Fable/src/fable-library-ts/Map.js";
import { milliseconds, seconds, minutes, hours, fromTicks } from "../../deps/Fable/src/fable-library-ts/TimeSpan.js";
import { interpolate, toText, trimStart, trimEnd } from "../../deps/Fable/src/fable-library-ts/String.js";
import { singleton } from "../../deps/Fable/src/fable-library-ts/AsyncBuilder.js";
import { sleep, catchAsync, startChild, awaitTask, cancellationToken } from "../../deps/Fable/src/fable-library-ts/Async.js";
import { FSharpChoice$2_$union } from "../../deps/Fable/src/fable-library-ts/Choice.js";

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
    return union_type("Networking.US1", [], US1, () => [[["f0_0", US0_$reflection()]], []]);
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
    return union_type("Networking.US2", [], US2, () => [[["f0_0", int64_type]], []]);
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
    return union_type("Networking.US3", [], US3, () => [[], [], []]);
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
    return union_type("Networking.US4", [], US4, () => [[["f0_0", US3_$reflection()]], [["f1_0", US3_$reflection()]], [["f2_0", US3_$reflection()]], [["f3_0", US3_$reflection()]], [["f4_0", US3_$reflection()]]]);
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
    return union_type("Networking.US5", [], US5, () => [[["f0_0", string_type]], []]);
}

export type US6_$union = 
    | US6<0>
    | US6<1>

export type US6_$cases = {
    0: ["US6_0", [boolean]],
    1: ["US6_1", []]
}

export function US6_US6_0(f0_0: boolean) {
    return new US6<0>(0, [f0_0]);
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
    return union_type("Networking.US6", [], US6, () => [[["f0_0", bool_type]], []]);
}

export type US7_$union = 
    | US7<0>
    | US7<1>

export type US7_$cases = {
    0: ["US7_0", [boolean]],
    1: ["US7_1", [Error]]
}

export function US7_US7_0(f0_0: boolean) {
    return new US7<0>(0, [f0_0]);
}

export function US7_US7_1(f1_0: Error) {
    return new US7<1>(1, [f1_0]);
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
    return union_type("Networking.US7", [], US7, () => [[["f0_0", bool_type]], [["f1_0", class_type("System.Exception")]]]);
}

export type US8_$union = 
    | US8<0>
    | US8<1>

export type US8_$cases = {
    0: ["US8_0", [boolean]],
    1: ["US8_1", [Error]]
}

export function US8_US8_0(f0_0: boolean) {
    return new US8<0>(0, [f0_0]);
}

export function US8_US8_1(f1_0: Error) {
    return new US8<1>(1, [f1_0]);
}

export class US8<Tag extends keyof US8_$cases> extends Union<Tag, US8_$cases[Tag][0]> {
    constructor(readonly tag: Tag, readonly fields: US8_$cases[Tag][1]) {
        super();
    }
    cases() {
        return ["US8_0", "US8_1"];
    }
}

export function US8_$reflection(): TypeInfo {
    return union_type("Networking.US8", [], US8, () => [[["f0_0", bool_type]], [["f1_0", class_type("System.Exception")]]]);
}

export type US9_$union = 
    | US9<0>
    | US9<1>

export type US9_$cases = {
    0: ["US9_0", [int32]],
    1: ["US9_1", []]
}

export function US9_US9_0(f0_0: int32) {
    return new US9<0>(0, [f0_0]);
}

export function US9_US9_1() {
    return new US9<1>(1, []);
}

export class US9<Tag extends keyof US9_$cases> extends Union<Tag, US9_$cases[Tag][0]> {
    constructor(readonly tag: Tag, readonly fields: US9_$cases[Tag][1]) {
        super();
    }
    cases() {
        return ["US9_0", "US9_1"];
    }
}

export function US9_$reflection(): TypeInfo {
    return union_type("Networking.US9", [], US9, () => [[["f0_0", int32_type]], []]);
}

export function method3(): string {
    return "";
}

export function closure1(unitVar: void, v0_1: string): US5_$union {
    return US5_US5_0(v0_1);
}

export function method4(): ((arg0: string) => US5_$union) {
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
    const _v1 = [patternInput[0], patternInput[1]] as [US1_$union, US2_$union];
    const v132: US2_$union = _v1[1];
    const v131: US1_$union = _v1[0];
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
    const patternInput: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
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

export function closure6(unitVar: void, v0_1: int64): US2_$union {
    return US2_US2_0(v0_1);
}

export function method8(): ((arg0: int64) => US2_$union) {
    return (v: int64): US2_$union => closure6(undefined, v);
}

export function method9(): string {
    return "hh:mm:ss";
}

export function method10(): string {
    return "HH:mm:ss";
}

export function method7(v0_1: Mut0, v1_1: Mut1, v2_1: Mut2, v3: Mut3, v4: Mut4, v5: Option<int64>): string {
    let v295: int64, v349: number;
    const v291: US2_$union = defaultArg(map<int64, US2_$union>(method8(), v5), US2_US2_1());
    return toString((v291.tag === /* US2_0 */ 0) ? ((v295 = v291.fields[0], (v349 = fromTicks(toInt64(op_Subtraction(toInt64(fromInt64(getTicks(now()))), v295))), create(1, 1, 1, hours(v349), minutes(v349), seconds(v349), milliseconds(v349))))) : now(), method10());
}

export function method13(): string {
    return "";
}

export function closure7(v0_1: Mut3, v1_1: string, unitVar: void): void {
    const v3: string = v0_1.l0 + v1_1;
    v0_1.l0 = v3;
}

export function method12(v0_1: string): string {
    const v2_1: Mut3 = new Mut3(method13());
    let v8: any;
    closure7(v2_1, `${v0_1}`, undefined);
    v8 = undefined;
    return v2_1.l0;
}

export function method14(): string {
    return "\u001b[0m";
}

export function method11(): string {
    const v2_1: string = "Verbose".toLocaleLowerCase();
    return ("\u001b[90m" + method12(v2_1[0])) + method14();
}

export function method16(v0_1: int32, v1_1: string): string {
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

export function method17(v0_1: string): string {
    return trimEnd(trimStart(v0_1, ...[]), ...[" ", "/"]);
}

export function method15(v0_1: Mut0, v1_1: Mut1, v2_1: Mut2, v3: Mut3, v4: Mut4, v5: Option<int64>, v6: string, v7: string, v8: int32, v9: string): string {
    const v10: string = method16(v8, v9);
    return method17(`${v6} ${v7} #${v0_1.l0} ${"networking.test_port_open"} / ${v10}`);
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

export function method18(v0_1: string): void {
    let v3: any;
    closure0(undefined, undefined);
    v3 = undefined;
    const patternInput: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
    let v37: any;
    closure8(patternInput[0], undefined);
    v37 = undefined;
    closure9(undefined, v0_1);
    patternInput[1].l0(v0_1);
}

export function closure5(v0_1: int32, v1_1: string, unitVar: void): void {
    if (method6(US0_US0_0())) {
        let v6: any;
        closure0(undefined, undefined);
        v6 = undefined;
        const patternInput: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
        const v25: Option<int64> = patternInput[5];
        const v24: Mut4 = patternInput[4];
        const v23: Mut3 = patternInput[3];
        const v22: Mut2 = patternInput[2];
        const v21: Mut1 = patternInput[1];
        const v20: Mut0 = patternInput[0];
        method18(method15(v20, v21, v22, v23, v24, v25, method7(v20, v21, v22, v23, v24, v25), method11(), v0_1, v1_1));
    }
}

export function method5(v0_1: string, v1_1: int32): any {
    return singleton.Delay<boolean>((): any => {
        const v13: any = cancellationToken();
        return singleton.Bind<any, boolean>(v13, (_arg: any): any => {
            const v25: IDisposable = defaultOf();
            return singleton.Using<IDisposable, boolean>(v25, (_arg_1: IDisposable): any => singleton.TryWith<boolean>(singleton.Delay<boolean>((): any => {
                const v51: any = defaultOf();
                const v100: any = awaitTask(defaultOf());
                return singleton.Bind<void, boolean>(v100, (): any => singleton.Return<boolean>(true));
            }), (_arg_3: Error): any => {
                let v140: any;
                closure5(v1_1, toText(interpolate("%A%P()", [_arg_3])), undefined);
                v140 = undefined;
                return singleton.Return<boolean>(false);
            }));
        });
    });
}

export function closure4(v0_1: string, v1_1: int32): any {
    return method5(v0_1, v1_1);
}

export function closure3(unitVar: void, v0_1: string): ((arg0: int32) => any) {
    return (v: int32): any => closure4(v0_1, v);
}

export function closure14(unitVar: void, v0_1: boolean): US7_$union {
    return US7_US7_0(v0_1);
}

export function method21(): ((arg0: boolean) => US7_$union) {
    return (v: boolean): US7_$union => closure14(undefined, v);
}

export function closure15(unitVar: void, v0_1: Error): US7_$union {
    return US7_US7_1(v0_1);
}

export function method22(): ((arg0: Error) => US7_$union) {
    return (v: Error): US7_$union => closure15(undefined, v);
}

export function method24(v0_1: int32): string {
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

export function method23(v0_1: Mut0, v1_1: Mut1, v2_1: Mut2, v3: Mut3, v4: Mut4, v5: Option<int64>, v6: string, v7: string, v8: int32): string {
    const v9: string = method24(v8);
    return method17(`${v6} ${v7} #${v0_1.l0} ${"async.run_with_timeout_async"} / ${v9}`);
}

export function closure16(v0_1: int32, unitVar: void): void {
    if (method6(US0_US0_0())) {
        let v5: any;
        closure0(undefined, undefined);
        v5 = undefined;
        const patternInput: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
        const v24: Option<int64> = patternInput[5];
        const v23: Mut4 = patternInput[4];
        const v22: Mut3 = patternInput[3];
        const v21: Mut2 = patternInput[2];
        const v20: Mut1 = patternInput[1];
        const v19_1: Mut0 = patternInput[0];
        method18(method23(v19_1, v20, v21, v22, v23, v24, method7(v19_1, v20, v21, v22, v23, v24), method11(), v0_1));
    }
}

export function method25(): string {
    const v2_1: string = "Critical".toLocaleLowerCase();
    return ("\u001b[91m" + method12(v2_1[0])) + method14();
}

export function method27(v0_1: int32, v1_1: string): string {
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

export function method26(v0_1: Mut0, v1_1: Mut1, v2_1: Mut2, v3: Mut3, v4: Mut4, v5: Option<int64>, v6: string, v7: string, v8: int32, v9: string): string {
    const v10: string = method27(v8, v9);
    return method17(`${v6} ${v7} #${v0_1.l0} ${"async.run_with_timeout_async**"} / ${v10}`);
}

export function closure17(v0_1: int32, v1_1: Error, unitVar: void): void {
    if (method6(US0_US0_4())) {
        let v6: any;
        closure0(undefined, undefined);
        v6 = undefined;
        const patternInput: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
        const v25: Option<int64> = patternInput[5];
        const v24: Mut4 = patternInput[4];
        const v23: Mut3 = patternInput[3];
        const v22: Mut2 = patternInput[2];
        const v21: Mut1 = patternInput[1];
        const v20: Mut0 = patternInput[0];
        method18(method26(v20, v21, v22, v23, v24, v25, method7(v20, v21, v22, v23, v24, v25), method25(), v0_1, toText(interpolate("%A%P()", [v1_1]))));
    }
}

export function method20(v0_1: int32, v1_1: any): any {
    return singleton.Delay<US6_$union>((): any => {
        const v9003: any = startChild<boolean>(v1_1, v0_1);
        return singleton.Bind<any, US6_$union>(v9003, (_arg: any): any => {
            const v9021: any = catchAsync<boolean>(_arg);
            const _v9043: any = singleton.Delay<US7_$union>((): any => singleton.Bind<FSharpChoice$2_$union<boolean, Error>, US7_$union>(v9021, (_arg_1: FSharpChoice$2_$union<boolean, Error>): any => {
                const v9055: US7_$union = defaultOf();
                return singleton.Return<US7_$union>(v9055);
            }));
            const _v9178: any = singleton.Delay<US8_$union>((): any => singleton.Bind<US7_$union, US8_$union>(_v9043, (_arg_2: US7_$union): any => {
                const v9179: US7_$union = _arg_2;
                const v9185: US8_$union = (v9179.tag === /* US7_1 */ 1) ? US8_US8_1(v9179.fields[0]) : US8_US8_0(v9179.fields[0]);
                return singleton.Return<US8_$union>(v9185);
            }));
            const _v9229: any = singleton.Delay<US6_$union>((): any => singleton.Bind<US8_$union, US6_$union>(_v9178, (_arg_3: US8_$union): any => {
                const v9230: US8_$union = _arg_3;
                let v9354: US6_$union;
                if (v9230.tag === /* US8_0 */ 0) {
                    v9354 = US6_US6_0(v9230.fields[0]);
                }
                else {
                    const v9233: Error = v9230.fields[0];
                    const v9234: string = toText(interpolate("%A%P()", [v9233]));
                    if (v9234.indexOf("System.TimeoutException") >= 0) {
                        let v9243: any;
                        closure16(v0_1, undefined);
                        v9243 = undefined;
                        v9354 = US6_US6_1();
                    }
                    else {
                        let v9286: any;
                        closure17(v0_1, v9233, undefined);
                        v9286 = undefined;
                        v9354 = US6_US6_1();
                    }
                }
                return singleton.Return<US6_$union>(v9354);
            }));
            return singleton.ReturnFrom<US6_$union>(_v9229);
        });
    });
}

export function method19(v0_1: int32, v1_1: string, v2_1: int32): any {
    return singleton.Delay<boolean>((): any => {
        const v15: any = method20(v0_1, method5(v1_1, v2_1));
        return singleton.Bind<US6_$union, boolean>(v15, (_arg: US6_$union): any => {
            const v16_1: US6_$union = _arg;
            const v19_1: boolean = (v16_1.tag === /* US6_0 */ 0) && v16_1.fields[0];
            return singleton.Return<boolean>(v19_1);
        });
    });
}

export function closure13(v0_1: int32, v1_1: string, v2_1: int32): any {
    return method19(v0_1, v1_1, v2_1);
}

export function closure12(v0_1: int32, v1_1: string): ((arg0: int32) => any) {
    return (v: int32): any => closure13(v0_1, v1_1, v);
}

export function closure11(unitVar: void, v0_1: int32): ((arg0: string) => ((arg0: int32) => any)) {
    return (v: string): ((arg0: int32) => any) => closure12(v0_1, v);
}

export function closure22(unitVar: void, v0_1: int32): US9_$union {
    return US9_US9_0(v0_1);
}

export function method30(): ((arg0: int32) => US9_$union) {
    return (v: int32): US9_$union => closure22(undefined, v);
}

export function method32(v0_1: int32, v1_1: int64, v2_1: Option<int32>, v3: boolean): string {
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
    let v135: any;
    closure7(v5, `${toText(interpolate("%A%P()", [v2_1]))}`, undefined);
    v135 = undefined;
    let v143: any;
    closure7(v5, `${"; "}`, undefined);
    v143 = undefined;
    let v152: any;
    closure7(v5, `${"status"}`, undefined);
    v152 = undefined;
    let v160: any;
    closure7(v5, `${" = "}`, undefined);
    v160 = undefined;
    let v171: any;
    closure7(v5, `${v3 ? "true" : "false"}`, undefined);
    v171 = undefined;
    let v180: any;
    closure7(v5, `${" }"}`, undefined);
    v180 = undefined;
    return v5.l0;
}

export function method31(v0_1: Mut0, v1_1: Mut1, v2_1: Mut2, v3: Mut3, v4: Mut4, v5: Option<int64>, v6: string, v7: string, v8: int32, v9: int64, v10: Option<int32>, v11: boolean): string {
    const v12: string = method32(v8, v9, v10, v11);
    return method17(`${v6} ${v7} #${v0_1.l0} ${"networking.wait_for_port_access"} / ${v12}`);
}

export function closure23(v0_1: Option<int32>, v1_1: boolean, v2_1: int32, v3: int64, unitVar: void): void {
    if (method6(US0_US0_0())) {
        let v8: any;
        closure0(undefined, undefined);
        v8 = undefined;
        const patternInput: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
        const v27: Option<int64> = patternInput[5];
        const v26: Mut4 = patternInput[4];
        const v25: Mut3 = patternInput[3];
        const v24: Mut2 = patternInput[2];
        const v23: Mut1 = patternInput[1];
        const v22: Mut0 = patternInput[0];
        method18(method31(v22, v23, v24, v25, v26, v27, method7(v22, v23, v24, v25, v26, v27), method11(), v2_1, v3, v0_1, v1_1));
    }
}

export function method29(v0_1: Option<int32>, v1_1: boolean, v2_1: string, v3: int32, v4: int64): any {
    return singleton.Delay<int64>((): any => {
        const v29: US9_$union = defaultArg(map<int32, US9_$union>(method30(), v0_1), US9_US9_1());
        const v37: any = (v29.tag === /* US9_0 */ 0) ? method19(v29.fields[0], v2_1, v3) : method5(v2_1, v3);
        return singleton.Bind<boolean, int64>(v37, (_arg: boolean): any => {
            let v44: any;
            if (_arg === v1_1) {
                return singleton.Return<int64>(v4);
            }
            else {
                const v41: boolean = equals(toInt64(op_Modulus(v4, 100n)), 0n);
                return singleton.Combine<int64>(v41 ? ((v44 = ((closure23(v0_1, v1_1, v3, v4, undefined), undefined)), singleton.Zero())) : singleton.Zero(), singleton.Delay<int64>((): any => {
                    const v92: any = sleep(10);
                    return singleton.Bind<void, int64>(v92, (): any => {
                        const v105: any = method29(v0_1, v1_1, v2_1, v3, toInt64(op_Addition(v4, 1n)));
                        return singleton.ReturnFrom<int64>(v105);
                    });
                }));
            }
        });
    });
}

export function method28(v0_1: Option<int32>, v1_1: boolean, v2_1: string, v3: int32): any {
    return method29(v0_1, v1_1, v2_1, v3, 1n);
}

export function closure21(v0_1: Option<int32>, v1_1: boolean, v2_1: string, v3: int32): any {
    return method28(v0_1, v1_1, v2_1, v3);
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

export function method34(v0_1: Option<int32>, v1_1: string, v2_1: int32): any {
    return singleton.Delay<int32>((): any => {
        const v27: US9_$union = defaultArg(map<int32, US9_$union>(method30(), v0_1), US9_US9_1());
        const v35: any = (v27.tag === /* US9_0 */ 0) ? method19(v27.fields[0], v1_1, v2_1) : method5(v1_1, v2_1);
        return singleton.Bind<boolean, int32>(v35, (_arg: boolean): any => {
            if (_arg === false) {
                return singleton.Return<int32>(v2_1);
            }
            else {
                const v39: any = method34(v0_1, v1_1, v2_1 + 1);
                return singleton.ReturnFrom<int32>(v39);
            }
        });
    });
}

export function method33(v0_1: Option<int32>, v1_1: string, v2_1: int32): any {
    return method34(v0_1, v1_1, v2_1);
}

export function closure26(v0_1: Option<int32>, v1_1: string, v2_1: int32): any {
    return method33(v0_1, v1_1, v2_1);
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


