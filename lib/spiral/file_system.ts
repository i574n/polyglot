import { uncurry2, defaultOf, compare, IComparable, IEquatable, IDisposable, createAtom } from "../../deps/Fable/src/fable-library-ts/Util.js";
import { map, defaultArg, value as value_9, Option } from "../../deps/Fable/src/fable-library-ts/Option.js";
import { compare as compare_1, op_Modulus, equals, op_Addition, op_Subtraction, fromInt64, toInt64, int64 } from "../../deps/Fable/src/fable-library-ts/BigInt.js";
import { bool_type, lambda_type, unit_type, string_type, record_type, int64_type, union_type, class_type, TypeInfo } from "../../deps/Fable/src/fable-library-ts/Reflection.js";
import { toString as toString_2, Record, Union } from "../../deps/Fable/src/fable-library-ts/Types.js";
import { create, toString, now, getTicks } from "../../deps/Fable/src/fable-library-ts/Date.js";
import * as fs from "fs";
import { ofSeq, find } from "../../deps/Fable/src/fable-library-ts/Map.js";
import { uint8, int32 } from "../../deps/Fable/src/fable-library-ts/Int32.js";
import { toString as toString_1, milliseconds, seconds, minutes, hours, fromTicks } from "../../deps/Fable/src/fable-library-ts/TimeSpan.js";
import { replace, padLeft, interpolate, toText, trimStart, trimEnd } from "../../deps/Fable/src/fable-library-ts/String.js";
import { singleton } from "../../deps/Fable/src/fable-library-ts/AsyncBuilder.js";
import { ignore, catchAsync, startChild, sleep } from "../../deps/Fable/src/fable-library-ts/Async.js";
import { FSharpChoice$2_$union } from "../../deps/Fable/src/fable-library-ts/Choice.js";
import { newGuid, parse } from "../../deps/Fable/src/fable-library-ts/Guid.js";
import * as path from "path";
import { FSharpResult$2_Ok, FSharpResult$2_$union, FSharpResult$2_Error } from "../../deps/Fable/src/fable-library-ts/Result.js";

export let TraceState_trace_state = createAtom<Option<[Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>]>>(undefined);

export interface IOsEnviron {
    environ(): any
}

export interface IFsExistsSync {
    existsSync(path: string): boolean
}

export interface IPathJoin {
    join(...paths: string[]): string
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
    return class_type("File_system.Disposable", undefined, Disposable);
}

export function Disposable_$ctor_3A5B6456(f: (() => void)): Disposable {
    return new Disposable(f);
}

export interface IPathDirname {
    dirname(path: string): string
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
    return union_type("File_system.US0", [], US0, () => [[], [], [], [], []]);
}

export class Mut0 extends Record implements IEquatable<Mut0>, IComparable<Mut0> {
    l0: int64;
    constructor(l0: int64) {
        super();
        this.l0 = l0;
    }
}

export function Mut0_$reflection(): TypeInfo {
    return record_type("File_system.Mut0", [], Mut0, () => [["l0", int64_type]]);
}

export class Mut1 extends Record {
    l0: ((arg0: string) => void);
    constructor(l0: ((arg0: string) => void)) {
        super();
        this.l0 = l0;
    }
}

export function Mut1_$reflection(): TypeInfo {
    return record_type("File_system.Mut1", [], Mut1, () => [["l0", lambda_type(string_type, unit_type)]]);
}

export class Mut2 extends Record implements IEquatable<Mut2>, IComparable<Mut2> {
    l0: boolean;
    constructor(l0: boolean) {
        super();
        this.l0 = l0;
    }
}

export function Mut2_$reflection(): TypeInfo {
    return record_type("File_system.Mut2", [], Mut2, () => [["l0", bool_type]]);
}

export class Mut3 extends Record implements IEquatable<Mut3>, IComparable<Mut3> {
    l0: string;
    constructor(l0: string) {
        super();
        this.l0 = l0;
    }
}

export function Mut3_$reflection(): TypeInfo {
    return record_type("File_system.Mut3", [], Mut3, () => [["l0", string_type]]);
}

export class Mut4 extends Record implements IEquatable<Mut4>, IComparable<Mut4> {
    l0: US0_$union;
    constructor(l0: US0_$union) {
        super();
        this.l0 = l0;
    }
}

export function Mut4_$reflection(): TypeInfo {
    return record_type("File_system.Mut4", [], Mut4, () => [["l0", US0_$reflection()]]);
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
    return union_type("File_system.US1", [], US1, () => [[["f0_0", US0_$reflection()]], []]);
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
    return union_type("File_system.US2", [], US2, () => [[["f0_0", int64_type]], []]);
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
    return union_type("File_system.US3", [], US3, () => [[], [], []]);
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
    return union_type("File_system.US4", [], US4, () => [[["f0_0", US3_$reflection()]], [["f1_0", US3_$reflection()]], [["f2_0", US3_$reflection()]], [["f3_0", US3_$reflection()]], [["f4_0", US3_$reflection()]]]);
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
    return union_type("File_system.US5", [], US5, () => [[["f0_0", string_type]], []]);
}

export type US7_$union = 
    | US7<0>
    | US7<1>
    | US7<2>

export type US7_$cases = {
    0: ["US7_0", []],
    1: ["US7_1", []],
    2: ["US7_2", []]
}

export function US7_US7_0() {
    return new US7<0>(0, []);
}

export function US7_US7_1() {
    return new US7<1>(1, []);
}

export function US7_US7_2() {
    return new US7<2>(2, []);
}

export class US7<Tag extends keyof US7_$cases> extends Union<Tag, US7_$cases[Tag][0]> {
    constructor(readonly tag: Tag, readonly fields: US7_$cases[Tag][1]) {
        super();
    }
    cases() {
        return ["US7_0", "US7_1", "US7_2"];
    }
}

export function US7_$reflection(): TypeInfo {
    return union_type("File_system.US7", [], US7, () => [[], [], []]);
}

export type US8_$union = 
    | US8<0>
    | US8<1>
    | US8<2>
    | US8<3>
    | US8<4>

export type US8_$cases = {
    0: ["US8_0", []],
    1: ["US8_1", []],
    2: ["US8_2", []],
    3: ["US8_3", []],
    4: ["US8_4", []]
}

export function US8_US8_0() {
    return new US8<0>(0, []);
}

export function US8_US8_1() {
    return new US8<1>(1, []);
}

export function US8_US8_2() {
    return new US8<2>(2, []);
}

export function US8_US8_3() {
    return new US8<3>(3, []);
}

export function US8_US8_4() {
    return new US8<4>(4, []);
}

export class US8<Tag extends keyof US8_$cases> extends Union<Tag, US8_$cases[Tag][0]> {
    constructor(readonly tag: Tag, readonly fields: US8_$cases[Tag][1]) {
        super();
    }
    cases() {
        return ["US8_0", "US8_1", "US8_2", "US8_3", "US8_4"];
    }
}

export function US8_$reflection(): TypeInfo {
    return union_type("File_system.US8", [], US8, () => [[], [], [], [], []]);
}

export type US6_$union = 
    | US6<0>
    | US6<1>

export type US6_$cases = {
    0: ["US6_0", [US7_$union, US8_$union]],
    1: ["US6_1", []]
}

export function US6_US6_0(f0_0: US7_$union, f0_1: US8_$union) {
    return new US6<0>(0, [f0_0, f0_1]);
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
    return union_type("File_system.US6", [], US6, () => [[["f0_0", US7_$reflection()], ["f0_1", US8_$reflection()]], []]);
}

export type US9_$union = 
    | US9<0>
    | US9<1>

export type US9_$cases = {
    0: ["US9_0", [int64]],
    1: ["US9_1", [Error]]
}

export function US9_US9_0(f0_0: int64) {
    return new US9<0>(0, [f0_0]);
}

export function US9_US9_1(f1_0: Error) {
    return new US9<1>(1, [f1_0]);
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
    return union_type("File_system.US9", [], US9, () => [[["f0_0", int64_type]], [["f1_0", class_type("System.Exception")]]]);
}

export type US10_$union = 
    | US10<0>
    | US10<1>

export type US10_$cases = {
    0: ["US10_0", [int64]],
    1: ["US10_1", [Error]]
}

export function US10_US10_0(f0_0: int64) {
    return new US10<0>(0, [f0_0]);
}

export function US10_US10_1(f1_0: Error) {
    return new US10<1>(1, [f1_0]);
}

export class US10<Tag extends keyof US10_$cases> extends Union<Tag, US10_$cases[Tag][0]> {
    constructor(readonly tag: Tag, readonly fields: US10_$cases[Tag][1]) {
        super();
    }
    cases() {
        return ["US10_0", "US10_1"];
    }
}

export function US10_$reflection(): TypeInfo {
    return union_type("File_system.US10", [], US10, () => [[["f0_0", int64_type]], [["f1_0", class_type("System.Exception")]]]);
}

export type US11_$union = 
    | US11<0>
    | US11<1>

export type US11_$cases = {
    0: ["US11_0", [any]],
    1: ["US11_1", []]
}

export function US11_US11_0(f0_0: any) {
    return new US11<0>(0, [f0_0]);
}

export function US11_US11_1() {
    return new US11<1>(1, []);
}

export class US11<Tag extends keyof US11_$cases> extends Union<Tag, US11_$cases[Tag][0]> {
    constructor(readonly tag: Tag, readonly fields: US11_$cases[Tag][1]) {
        super();
    }
    cases() {
        return ["US11_0", "US11_1"];
    }
}

export function US11_$reflection(): TypeInfo {
    return union_type("File_system.US11", [], US11, () => [[["f0_0", string_type]], []]);
}

export type US12_$union = 
    | US12<0>
    | US12<1>

export type US12_$cases = {
    0: ["US12_0", []],
    1: ["US12_1", [any]]
}

export function US12_US12_0() {
    return new US12<0>(0, []);
}

export function US12_US12_1(f1_0: any) {
    return new US12<1>(1, [f1_0]);
}

export class US12<Tag extends keyof US12_$cases> extends Union<Tag, US12_$cases[Tag][0]> {
    constructor(readonly tag: Tag, readonly fields: US12_$cases[Tag][1]) {
        super();
    }
    cases() {
        return ["US12_0", "US12_1"];
    }
}

export function US12_$reflection(): TypeInfo {
    return union_type("File_system.US12", [], US12, () => [[], [["f1_0", string_type]]]);
}

export type US13_$union = 
    | US13<0>
    | US13<1>

export type US13_$cases = {
    0: ["US13_0", [any]],
    1: ["US13_1", [string]]
}

export function US13_US13_0(f0_0: any) {
    return new US13<0>(0, [f0_0]);
}

export function US13_US13_1(f1_0: string) {
    return new US13<1>(1, [f1_0]);
}

export class US13<Tag extends keyof US13_$cases> extends Union<Tag, US13_$cases[Tag][0]> {
    constructor(readonly tag: Tag, readonly fields: US13_$cases[Tag][1]) {
        super();
    }
    cases() {
        return ["US13_0", "US13_1"];
    }
}

export function US13_$reflection(): TypeInfo {
    return union_type("File_system.US13", [], US13, () => [[["f0_0", string_type]], [["f1_0", string_type]]]);
}

export type US14_$union = 
    | US14<0>
    | US14<1>

export type US14_$cases = {
    0: ["US14_0", [any]],
    1: ["US14_1", []]
}

export function US14_US14_0(f0_0: any) {
    return new US14<0>(0, [f0_0]);
}

export function US14_US14_1() {
    return new US14<1>(1, []);
}

export class US14<Tag extends keyof US14_$cases> extends Union<Tag, US14_$cases[Tag][0]> {
    constructor(readonly tag: Tag, readonly fields: US14_$cases[Tag][1]) {
        super();
    }
    cases() {
        return ["US14_0", "US14_1"];
    }
}

export function US14_$reflection(): TypeInfo {
    return union_type("File_system.US14", [], US14, () => [[["f0_0", string_type]], []]);
}

export type US15_$union = 
    | US15<0>
    | US15<1>

export type US15_$cases = {
    0: ["US15_0", [string]],
    1: ["US15_1", [string]]
}

export function US15_US15_0(f0_0: string) {
    return new US15<0>(0, [f0_0]);
}

export function US15_US15_1(f1_0: string) {
    return new US15<1>(1, [f1_0]);
}

export class US15<Tag extends keyof US15_$cases> extends Union<Tag, US15_$cases[Tag][0]> {
    constructor(readonly tag: Tag, readonly fields: US15_$cases[Tag][1]) {
        super();
    }
    cases() {
        return ["US15_0", "US15_1"];
    }
}

export function US15_$reflection(): TypeInfo {
    return union_type("File_system.US15", [], US15, () => [[["f0_0", string_type]], [["f1_0", string_type]]]);
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
    let v13: US1_$union, v20_1: US1_$union, v27_1: US1_$union, v34_1: US1_$union;
    const v1_1: string = method2("TRACE_LEVEL");
    const v6: US1_$union = ("Verbose" === v1_1) ? US1_US1_0(US0_US0_0()) : US1_US1_1();
    return [(v6.tag === /* US1_0 */ 0) ? US1_US1_0(v6.fields[0]) : ((v13 = (("Debug" === v1_1) ? US1_US1_0(US0_US0_1()) : US1_US1_1()), (v13.tag === /* US1_0 */ 0) ? US1_US1_0(v13.fields[0]) : ((v20_1 = (("Info" === v1_1) ? US1_US1_0(US0_US0_2()) : US1_US1_1()), (v20_1.tag === /* US1_0 */ 0) ? US1_US1_0(v20_1.fields[0]) : ((v27_1 = (("Warning" === v1_1) ? US1_US1_0(US0_US0_3()) : US1_US1_1()), (v27_1.tag === /* US1_0 */ 0) ? US1_US1_0(v27_1.fields[0]) : ((v34_1 = (("Critical" === v1_1) ? US1_US1_0(US0_US0_4()) : US1_US1_1()), (v34_1.tag === /* US1_0 */ 0) ? US1_US1_0(v34_1.fields[0]) : US1_US1_1())))))))), (method2("AUTOMATION") !== "True") ? US2_US2_1() : US2_US2_0(toInt64(fromInt64(getTicks(now()))))] as [US1_$union, US2_$union];
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

export function method7(v0_1: string): string {
    return v0_1;
}

export function method8(v0_1: string): boolean {
    const v86: IFsExistsSync = fs;
    return v86.existsSync(v0_1);
}

export function method6(v0_1: boolean, v1_1: string): void {
}

export function method9(v0_1: US0_$union): boolean {
    let v3: any;
    closure0(undefined, undefined);
    v3 = undefined;
    const patternInput: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_9(TraceState_trace_state());
    const v35_1: US0_$union = patternInput[4].l0;
    if (patternInput[2].l0 === false) {
        return false;
    }
    else {
        return find<US0_$union, int32>(v0_1, ofSeq([[US0_US0_0(), 0] as [US0_$union, int32], [US0_US0_1(), 1] as [US0_$union, int32], [US0_US0_2(), 2] as [US0_$union, int32], [US0_US0_3(), 3] as [US0_$union, int32], [US0_US0_4(), 4] as [US0_$union, int32]], {
            Compare: compare,
        })) >= find<US0_$union, int32>(v35_1, ofSeq([[US0_US0_0(), 0] as [US0_$union, int32], [US0_US0_1(), 1] as [US0_$union, int32], [US0_US0_2(), 2] as [US0_$union, int32], [US0_US0_3(), 3] as [US0_$union, int32], [US0_US0_4(), 4] as [US0_$union, int32]], {
            Compare: compare,
        }));
    }
}

export function closure5(unitVar: void, v0_1: int64): US2_$union {
    return US2_US2_0(v0_1);
}

export function method11(): ((arg0: int64) => US2_$union) {
    return (v: int64): US2_$union => closure5(undefined, v);
}

export function method12(): string {
    return "hh:mm:ss";
}

export function method13(): string {
    return "HH:mm:ss";
}

export function method10(v0_1: Mut0, v1_1: Mut1, v2_1: Mut2, v3: Mut3, v4: Mut4, v5: Option<int64>): string {
    let v301: int64, v355: number;
    const v297: US2_$union = defaultArg(map<int64, US2_$union>(method11(), v5), US2_US2_1());
    return toString((v297.tag === /* US2_0 */ 0) ? ((v301 = v297.fields[0], (v355 = fromTicks(toInt64(op_Subtraction(toInt64(fromInt64(getTicks(now()))), v301))), create(1, 1, 1, hours(v355), minutes(v355), seconds(v355), milliseconds(v355))))) : now(), method13());
}

export function method16(): string {
    return "";
}

export function closure6(v0_1: Mut3, v1_1: string, unitVar: void): void {
    const v3: string = v0_1.l0 + v1_1;
    v0_1.l0 = v3;
}

export function method15(v0_1: string): string {
    const v2_1: Mut3 = new Mut3(method16());
    let v8: any;
    closure6(v2_1, `${v0_1}`, undefined);
    v8 = undefined;
    return v2_1.l0;
}

export function method17(): string {
    return "\u001b[0m";
}

export function method14(): string {
    const v2_1: string = "Debug".toLocaleLowerCase();
    return ("\u001b[94m" + method15(v2_1[0])) + method17();
}

export function method18(v0_1: string): string {
    throw new Error(`file_system.get_file_name / target: ${US4_US4_3(US3_US3_0())} / path: ${v0_1}`);
}

export function method20(v0_1: string, v1_1: string): string {
    const v3: Mut3 = new Mut3(method16());
    let v10: any;
    closure6(v3, `${"{ "}`, undefined);
    v10 = undefined;
    let v19_1: any;
    closure6(v3, `${"ex"}`, undefined);
    v19_1 = undefined;
    let v28_1: any;
    closure6(v3, `${" = "}`, undefined);
    v28_1 = undefined;
    let v36: any;
    closure6(v3, `${v0_1}`, undefined);
    v36 = undefined;
    let v45: any;
    closure6(v3, `${"; "}`, undefined);
    v45 = undefined;
    let v54: any;
    closure6(v3, `${"path"}`, undefined);
    v54 = undefined;
    let v62: any;
    closure6(v3, `${" = "}`, undefined);
    v62 = undefined;
    let v70: any;
    closure6(v3, `${v1_1}`, undefined);
    v70 = undefined;
    let v79: any;
    closure6(v3, `${" }"}`, undefined);
    v79 = undefined;
    return v3.l0;
}

export function method21(v0_1: string): string {
    return trimEnd(trimStart(v0_1, ...[]), ...[" ", "/"]);
}

export function method19(v0_1: Mut0, v1_1: Mut1, v2_1: Mut2, v3: Mut3, v4: Mut4, v5: Option<int64>, v6: string, v7: string, v8: string, v9: string): string {
    const v10: string = method20(v8, v9);
    return method21(`${v6} ${v7} #${v0_1.l0} ${"file_system.delete_directory_async"} / ${v10}`);
}

export function closure7(v0_1: Mut0, unitVar: void): void {
    const v2_1: int64 = toInt64(op_Addition(v0_1.l0, 1n));
    v0_1.l0 = v2_1;
}

export function closure9(v0_1: string, unitVar: void): void {
    console.log(v0_1);
}

export function closure8(unitVar: void, v0_1: string): void {
    let v3: any;
    closure9(v0_1, undefined);
    v3 = undefined;
}

export function method22(v0_1: string): void {
    let v3: any;
    closure0(undefined, undefined);
    v3 = undefined;
    const patternInput: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_9(TraceState_trace_state());
    let v37: any;
    closure7(patternInput[0], undefined);
    v37 = undefined;
    closure8(undefined, v0_1);
    patternInput[1].l0(v0_1);
}

export function closure4(v0_1: string, v1_1: string, unitVar: void): void {
    if (method9(US0_US0_1())) {
        let v6: any;
        closure0(undefined, undefined);
        v6 = undefined;
        const patternInput: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_9(TraceState_trace_state());
        const v25_1: Option<int64> = patternInput[5];
        const v24_1: Mut4 = patternInput[4];
        const v23_1: Mut3 = patternInput[3];
        const v22_1: Mut2 = patternInput[2];
        const v21_1: Mut1 = patternInput[1];
        const v20_1: Mut0 = patternInput[0];
        method22(method19(v20_1, v21_1, v22_1, v23_1, v24_1, v25_1, method10(v20_1, v21_1, v22_1, v23_1, v24_1, v25_1), method14(), v1_1, method18(v0_1)));
    }
}

export function method5(v0_1: string, v1_1: int64): any {
    return singleton.Delay<int64>((): any => singleton.TryWith<int64>(singleton.Delay<int64>((): any => {
        method6(true, v0_1);
        return singleton.Return<int64>(v1_1);
    }), (_arg: Error): any => {
        let v44: any;
        const v16_1: boolean = equals(toInt64(op_Modulus(v1_1, 100n)), 0n);
        return singleton.Combine<int64>(v16_1 ? ((v44 = ((closure4(v0_1, toText(interpolate("%A%P()", [_arg])), undefined), undefined)), singleton.Zero())) : singleton.Zero(), singleton.Delay<int64>((): any => {
            const v93: any = sleep(10);
            return singleton.Bind<void, int64>(v93, (): any => {
                const v106: any = method5(v0_1, toInt64(op_Addition(v1_1, 1n)));
                return singleton.ReturnFrom<int64>(v106);
            });
        }));
    }));
}

export function closure3(unitVar: void, v0_1: string): any {
    return defaultOf();
}

export function method25(v0_1: string, v1_1: int64, v2_1: string): string {
    const v4: Mut3 = new Mut3(method16());
    let v11: any;
    closure6(v4, `${"{ "}`, undefined);
    v11 = undefined;
    let v20_1: any;
    closure6(v4, `${"path"}`, undefined);
    v20_1 = undefined;
    let v29_1: any;
    closure6(v4, `${" = "}`, undefined);
    v29_1 = undefined;
    let v37: any;
    closure6(v4, `${v0_1}`, undefined);
    v37 = undefined;
    let v46: any;
    closure6(v4, `${"; "}`, undefined);
    v46 = undefined;
    let v55: any;
    closure6(v4, `${"retry"}`, undefined);
    v55 = undefined;
    let v63: any;
    closure6(v4, `${" = "}`, undefined);
    v63 = undefined;
    let v71: any;
    closure6(v4, `${v1_1}`, undefined);
    v71 = undefined;
    let v79: any;
    closure6(v4, `${"; "}`, undefined);
    v79 = undefined;
    let v88: any;
    closure6(v4, `${"ex"}`, undefined);
    v88 = undefined;
    let v96: any;
    closure6(v4, `${" = "}`, undefined);
    v96 = undefined;
    let v104: any;
    closure6(v4, `${v2_1}`, undefined);
    v104 = undefined;
    let v113: any;
    closure6(v4, `${" }"}`, undefined);
    v113 = undefined;
    return v4.l0;
}

export function method24(v0_1: Mut0, v1_1: Mut1, v2_1: Mut2, v3: Mut3, v4: Mut4, v5: Option<int64>, v6: string, v7: string, v8: string, v9: int64, v10: string): string {
    const v11: string = method25(v8, v9, v10);
    return method21(`${v6} ${v7} #${v0_1.l0} ${"file_system.wait_for_file_access"} / ${v11}`);
}

export function closure12(v0_1: string, v1_1: int64, v2_1: string, unitVar: void): void {
    if (method9(US0_US0_1())) {
        let v7: any;
        closure0(undefined, undefined);
        v7 = undefined;
        const patternInput: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_9(TraceState_trace_state());
        const v26_1: Option<int64> = patternInput[5];
        const v25_1: Mut4 = patternInput[4];
        const v24_1: Mut3 = patternInput[3];
        const v23_1: Mut2 = patternInput[2];
        const v22_1: Mut1 = patternInput[1];
        const v21_1: Mut0 = patternInput[0];
        method22(method24(v21_1, v22_1, v23_1, v24_1, v25_1, v26_1, method10(v21_1, v22_1, v23_1, v24_1, v25_1, v26_1), method14(), method18(v0_1), v1_1, v2_1));
    }
}

export function method23(v0_1: string, v1_1: US8_$union, v2_1: US7_$union, v3: int64): any {
    return singleton.Delay<int64>((): any => singleton.TryWith<int64>(singleton.Delay<int64>((): any => {
        const v25_1: any = defaultOf();
        return singleton.Using<any, int64>(v25_1, (_arg: any): any => singleton.Return<int64>(v3));
    }), (_arg_1: Error): any => {
        let v90: any;
        const v62: boolean = (compare_1(v3, 0n) > 0) && equals(toInt64(op_Modulus(v3, 100n)), 0n);
        return singleton.Combine<int64>(v62 ? ((v90 = ((closure12(v0_1, v3, toText(interpolate("%A%P()", [_arg_1])), undefined), undefined)), singleton.Zero())) : singleton.Zero(), singleton.Delay<int64>((): any => {
            const v139: any = sleep(10);
            return singleton.Bind<void, int64>(v139, (): any => {
                const v152: any = method23(v0_1, v1_1, v2_1, toInt64(op_Addition(v3, 1n)));
                return singleton.ReturnFrom<int64>(v152);
            });
        }));
    }));
}

export function closure11(v0_1: US6_$union, v1_1: string): any {
    return defaultOf();
}

export function closure10(unitVar: void, v0_1: US6_$union): ((arg0: string) => any) {
    return (v: string): any => closure11(v0_1, v);
}

export function method26(v0_1: string, v1_1: int64): any {
    return singleton.Delay<int64>((): any => singleton.TryWith<int64>(singleton.Delay<int64>((): any => {
        const v23_1: any = defaultOf();
        return singleton.Using<any, int64>(v23_1, (_arg: any): any => singleton.Return<int64>(v1_1));
    }), (_arg_1: Error): any => {
        let v74: any;
        const v46: boolean = (compare_1(v1_1, 0n) > 0) && equals(toInt64(op_Modulus(v1_1, 100n)), 0n);
        return singleton.Combine<int64>(v46 ? ((v74 = ((closure12(v0_1, v1_1, toText(interpolate("%A%P()", [_arg_1])), undefined), undefined)), singleton.Zero())) : singleton.Zero(), singleton.Delay<int64>((): any => {
            const v123: any = sleep(10);
            return singleton.Bind<void, int64>(v123, (): any => {
                const v136: any = method26(v0_1, toInt64(op_Addition(v1_1, 1n)));
                return singleton.ReturnFrom<int64>(v136);
            });
        }));
    }));
}

export function closure13(unitVar: void, v0_1: string): any {
    return defaultOf();
}

export function closure14(unitVar: void, v0_1: string): any {
    return defaultOf();
}

export function method28(v0_1: string): boolean {
    const v86: IFsExistsSync = fs;
    return v86.existsSync(v0_1);
}

export function method29(v0_1: any): any {
    return v0_1;
}

export function method27(v0_1: string, v1_1: string): boolean {
    return defaultOf();
}

export function closure16(v0_1: string, v1_1: string): boolean {
    return method27(v0_1, v1_1);
}

export function closure15(unitVar: void, v0_1: string): ((arg0: string) => boolean) {
    return (v: string): boolean => closure16(v0_1, v);
}

export function closure18(v0_1: string, v1_1: string): any {
    return defaultOf();
}

export function closure17(unitVar: void, v0_1: string): ((arg0: string) => any) {
    return (v: string): any => closure18(v0_1, v);
}

export function closure20(v0_1: string, v1_1: string): any {
    return singleton.Delay<void>((): any => {
        const v23_1: any = defaultOf();
        return singleton.Bind<boolean, void>(v23_1, (_arg: boolean): any => {
            let v272: any;
            const v261: boolean = _arg === false;
            return singleton.Combine<void>(v261 ? ((v272 = defaultOf(), singleton.Bind<void, void>(v272, (): any => {
                return singleton.Zero();
            }))) : singleton.Zero(), singleton.Delay<void>((): any => {
                return singleton.Zero();
            }));
        });
    });
}

export function closure19(unitVar: void, v0_1: string): ((arg0: string) => any) {
    return (v: string): any => closure20(v0_1, v);
}

export function method31(): string {
    const v2_1: string = "Warning".toLocaleLowerCase();
    return ("\u001b[93m" + method15(v2_1[0])) + method17();
}

export function method33(v0_1: string, v1_1: string): string {
    const v3: Mut3 = new Mut3(method16());
    let v10: any;
    closure6(v3, `${"{ "}`, undefined);
    v10 = undefined;
    let v19_1: any;
    closure6(v3, `${"path"}`, undefined);
    v19_1 = undefined;
    let v28_1: any;
    closure6(v3, `${" = "}`, undefined);
    v28_1 = undefined;
    let v36: any;
    closure6(v3, `${v0_1}`, undefined);
    v36 = undefined;
    let v45: any;
    closure6(v3, `${"; "}`, undefined);
    v45 = undefined;
    let v54: any;
    closure6(v3, `${"ex"}`, undefined);
    v54 = undefined;
    let v62: any;
    closure6(v3, `${" = "}`, undefined);
    v62 = undefined;
    let v70: any;
    closure6(v3, `${v1_1}`, undefined);
    v70 = undefined;
    let v79: any;
    closure6(v3, `${" }"}`, undefined);
    v79 = undefined;
    return v3.l0;
}

export function method32(v0_1: Mut0, v1_1: Mut1, v2_1: Mut2, v3: Mut3, v4: Mut4, v5: Option<int64>, v6: string, v7: string, v8: string, v9: string): string {
    const v10: string = method33(v8, v9);
    return method21(`${v6} ${v7} #${v0_1.l0} ${"delete_file_async"} / ${v10}`);
}

export function closure22(v0_1: string, v1_1: Error, unitVar: void): void {
    if (method9(US0_US0_3())) {
        let v6: any;
        closure0(undefined, undefined);
        v6 = undefined;
        const patternInput: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_9(TraceState_trace_state());
        const v25_1: Option<int64> = patternInput[5];
        const v24_1: Mut4 = patternInput[4];
        const v23_1: Mut3 = patternInput[3];
        const v22_1: Mut2 = patternInput[2];
        const v21_1: Mut1 = patternInput[1];
        const v20_1: Mut0 = patternInput[0];
        method22(method32(v20_1, v21_1, v22_1, v23_1, v24_1, v25_1, method10(v20_1, v21_1, v22_1, v23_1, v24_1, v25_1), method31(), method18(v0_1), toText(interpolate("%A%P()", [v1_1]))));
    }
}

export function method30(v0_1: string, v1_1: int64): any {
    return singleton.Delay<int64>((): any => singleton.TryWith<int64>(singleton.Delay<int64>((): any => {
        return singleton.Return<int64>(v1_1);
    }), (_arg: Error): any => {
        let v21_1: any;
        const v18_1: boolean = equals(toInt64(op_Modulus(v1_1, 100n)), 0n);
        return singleton.Combine<int64>(v18_1 ? ((v21_1 = ((closure22(v0_1, _arg, undefined), undefined)), singleton.Zero())) : singleton.Zero(), singleton.Delay<int64>((): any => {
            const v95: any = sleep(10);
            return singleton.Bind<void, int64>(v95, (): any => {
                const v108: any = method30(v0_1, toInt64(op_Addition(v1_1, 1n)));
                return singleton.ReturnFrom<int64>(v108);
            });
        }));
    }));
}

export function closure21(unitVar: void, v0_1: string): any {
    return defaultOf();
}

export function method36(v0_1: string, v1_1: string, v2_1: Error): string {
    const v4: Mut3 = new Mut3(method16());
    let v11: any;
    closure6(v4, `${"{ "}`, undefined);
    v11 = undefined;
    let v20_1: any;
    closure6(v4, `${"old_path"}`, undefined);
    v20_1 = undefined;
    let v29_1: any;
    closure6(v4, `${" = "}`, undefined);
    v29_1 = undefined;
    let v37: any;
    closure6(v4, `${v0_1}`, undefined);
    v37 = undefined;
    let v46: any;
    closure6(v4, `${"; "}`, undefined);
    v46 = undefined;
    let v55: any;
    closure6(v4, `${"new_path"}`, undefined);
    v55 = undefined;
    let v63: any;
    closure6(v4, `${" = "}`, undefined);
    v63 = undefined;
    let v71: any;
    closure6(v4, `${v1_1}`, undefined);
    v71 = undefined;
    let v79: any;
    closure6(v4, `${"; "}`, undefined);
    v79 = undefined;
    let v88: any;
    closure6(v4, `${"ex"}`, undefined);
    v88 = undefined;
    let v96: any;
    closure6(v4, `${" = "}`, undefined);
    v96 = undefined;
    let v134: any;
    closure6(v4, `${toText(interpolate("%A%P()", [v2_1]))}`, undefined);
    v134 = undefined;
    let v143: any;
    closure6(v4, `${" }"}`, undefined);
    v143 = undefined;
    return v4.l0;
}

export function method35(v0_1: Mut0, v1_1: Mut1, v2_1: Mut2, v3: Mut3, v4: Mut4, v5: Option<int64>, v6: string, v7: string, v8: string, v9: string, v10: Error): string {
    const v11: string = method36(v8, v9, v10);
    return method21(`${v6} ${v7} #${v0_1.l0} ${"move_file_async"} / ${v11}`);
}

export function closure25(v0_1: string, v1_1: string, v2_1: Error, unitVar: void): void {
    if (method9(US0_US0_3())) {
        let v7: any;
        closure0(undefined, undefined);
        v7 = undefined;
        const patternInput: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_9(TraceState_trace_state());
        const v26_1: Option<int64> = patternInput[5];
        const v25_1: Mut4 = patternInput[4];
        const v24_1: Mut3 = patternInput[3];
        const v23_1: Mut2 = patternInput[2];
        const v22_1: Mut1 = patternInput[1];
        const v21_1: Mut0 = patternInput[0];
        method22(method35(v21_1, v22_1, v23_1, v24_1, v25_1, v26_1, method10(v21_1, v22_1, v23_1, v24_1, v25_1, v26_1), method31(), method18(v1_1), method18(v0_1), v2_1));
    }
}

export function method34(v0_1: string, v1_1: string, v2_1: int64): any {
    return singleton.Delay<int64>((): any => singleton.TryWith<int64>(singleton.Delay<int64>((): any => {
        return singleton.Return<int64>(v2_1);
    }), (_arg: Error): any => {
        let v20_1: any;
        const v17_1: boolean = equals(toInt64(op_Modulus(v2_1, 100n)), 0n);
        return singleton.Combine<int64>(v17_1 ? ((v20_1 = ((closure25(v0_1, v1_1, _arg, undefined), undefined)), singleton.Zero())) : singleton.Zero(), singleton.Delay<int64>((): any => {
            const v70: any = sleep(10);
            return singleton.Bind<void, int64>(v70, (): any => {
                const v83: any = method34(v0_1, v1_1, toInt64(op_Addition(v2_1, 1n)));
                return singleton.ReturnFrom<int64>(v83);
            });
        }));
    }));
}

export function closure24(v0_1: string, v1_1: string): any {
    return defaultOf();
}

export function closure23(unitVar: void, v0_1: string): ((arg0: string) => any) {
    return (v: string): any => closure24(v0_1, v);
}

export function method38(v0_1: int64): int64 {
    return v0_1;
}

export function closure27(unitVar: void, v0_1: int64): US9_$union {
    return US9_US9_0(v0_1);
}

export function method40(): ((arg0: int64) => US9_$union) {
    return (v: int64): US9_$union => closure27(undefined, v);
}

export function closure28(unitVar: void, v0_1: Error): US9_$union {
    return US9_US9_1(v0_1);
}

export function method41(): ((arg0: Error) => US9_$union) {
    return (v: Error): US9_$union => closure28(undefined, v);
}

export function method42(): string {
    const v2_1: string = "Verbose".toLocaleLowerCase();
    return ("\u001b[90m" + method15(v2_1[0])) + method17();
}

export function method44(v0_1: int32): string {
    const v2_1: Mut3 = new Mut3(method16());
    let v9: any;
    closure6(v2_1, `${"{ "}`, undefined);
    v9 = undefined;
    let v18_1: any;
    closure6(v2_1, `${"timeout"}`, undefined);
    v18_1 = undefined;
    let v27_1: any;
    closure6(v2_1, `${" = "}`, undefined);
    v27_1 = undefined;
    let v35_1: any;
    closure6(v2_1, `${v0_1}`, undefined);
    v35_1 = undefined;
    let v44: any;
    closure6(v2_1, `${" }"}`, undefined);
    v44 = undefined;
    return v2_1.l0;
}

export function method43(v0_1: Mut0, v1_1: Mut1, v2_1: Mut2, v3: Mut3, v4: Mut4, v5: Option<int64>, v6: string, v7: string, v8: int32): string {
    const v9: string = method44(v8);
    return method21(`${v6} ${v7} #${v0_1.l0} ${"async.run_with_timeout_async"} / ${v9}`);
}

export function closure29(v0_1: int32, unitVar: void): void {
    if (method9(US0_US0_0())) {
        let v5: any;
        closure0(undefined, undefined);
        v5 = undefined;
        const patternInput: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_9(TraceState_trace_state());
        const v24_1: Option<int64> = patternInput[5];
        const v23_1: Mut4 = patternInput[4];
        const v22_1: Mut3 = patternInput[3];
        const v21_1: Mut2 = patternInput[2];
        const v20_1: Mut1 = patternInput[1];
        const v19_1: Mut0 = patternInput[0];
        method22(method43(v19_1, v20_1, v21_1, v22_1, v23_1, v24_1, method10(v19_1, v20_1, v21_1, v22_1, v23_1, v24_1), method42(), v0_1));
    }
}

export function method45(): string {
    const v2_1: string = "Critical".toLocaleLowerCase();
    return ("\u001b[91m" + method15(v2_1[0])) + method17();
}

export function method47(v0_1: int32, v1_1: string): string {
    const v3: Mut3 = new Mut3(method16());
    let v10: any;
    closure6(v3, `${"{ "}`, undefined);
    v10 = undefined;
    let v19_1: any;
    closure6(v3, `${"timeout"}`, undefined);
    v19_1 = undefined;
    let v28_1: any;
    closure6(v3, `${" = "}`, undefined);
    v28_1 = undefined;
    let v36: any;
    closure6(v3, `${v0_1}`, undefined);
    v36 = undefined;
    let v45: any;
    closure6(v3, `${"; "}`, undefined);
    v45 = undefined;
    let v54: any;
    closure6(v3, `${"ex"}`, undefined);
    v54 = undefined;
    let v62: any;
    closure6(v3, `${" = "}`, undefined);
    v62 = undefined;
    let v70: any;
    closure6(v3, `${v1_1}`, undefined);
    v70 = undefined;
    let v79: any;
    closure6(v3, `${" }"}`, undefined);
    v79 = undefined;
    return v3.l0;
}

export function method46(v0_1: Mut0, v1_1: Mut1, v2_1: Mut2, v3: Mut3, v4: Mut4, v5: Option<int64>, v6: string, v7: string, v8: int32, v9: string): string {
    const v10: string = method47(v8, v9);
    return method21(`${v6} ${v7} #${v0_1.l0} ${"async.run_with_timeout_async**"} / ${v10}`);
}

export function closure30(v0_1: int32, v1_1: Error, unitVar: void): void {
    if (method9(US0_US0_4())) {
        let v6: any;
        closure0(undefined, undefined);
        v6 = undefined;
        const patternInput: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_9(TraceState_trace_state());
        const v25_1: Option<int64> = patternInput[5];
        const v24_1: Mut4 = patternInput[4];
        const v23_1: Mut3 = patternInput[3];
        const v22_1: Mut2 = patternInput[2];
        const v21_1: Mut1 = patternInput[1];
        const v20_1: Mut0 = patternInput[0];
        method22(method46(v20_1, v21_1, v22_1, v23_1, v24_1, v25_1, method10(v20_1, v21_1, v22_1, v23_1, v24_1, v25_1), method45(), v0_1, toText(interpolate("%A%P()", [v1_1]))));
    }
}

export function method39(v0_1: int32, v1_1: any): any {
    return singleton.Delay<US2_$union>((): any => {
        const v9081: any = startChild<int64>(v1_1, v0_1);
        return singleton.Bind<any, US2_$union>(v9081, (_arg: any): any => {
            const v9099: any = catchAsync<int64>(_arg);
            const _v9121: any = singleton.Delay<US9_$union>((): any => singleton.Bind<FSharpChoice$2_$union<int64, Error>, US9_$union>(v9099, (_arg_1: FSharpChoice$2_$union<int64, Error>): any => {
                const v9133: US9_$union = defaultOf();
                return singleton.Return<US9_$union>(v9133);
            }));
            const _v9256: any = singleton.Delay<US10_$union>((): any => singleton.Bind<US9_$union, US10_$union>(_v9121, (_arg_2: US9_$union): any => {
                const v9257: US9_$union = _arg_2;
                const v9263: US10_$union = (v9257.tag === /* US9_1 */ 1) ? US10_US10_1(v9257.fields[0]) : US10_US10_0(v9257.fields[0]);
                return singleton.Return<US10_$union>(v9263);
            }));
            const _v9307: any = singleton.Delay<US2_$union>((): any => singleton.Bind<US10_$union, US2_$union>(_v9256, (_arg_3: US10_$union): any => {
                const v9308: US10_$union = _arg_3;
                let v9432: US2_$union;
                if (v9308.tag === /* US10_0 */ 0) {
                    v9432 = US2_US2_0(v9308.fields[0]);
                }
                else {
                    const v9311: Error = v9308.fields[0];
                    const v9312: string = toText(interpolate("%A%P()", [v9311]));
                    if (v9312.indexOf("System.TimeoutException") >= 0) {
                        let v9321: any;
                        closure29(v0_1, undefined);
                        v9321 = undefined;
                        v9432 = US2_US2_1();
                    }
                    else {
                        let v9364: any;
                        closure30(v0_1, v9311, undefined);
                        v9364 = undefined;
                        v9432 = US2_US2_1();
                    }
                }
                return singleton.Return<US2_$union>(v9432);
            }));
            return singleton.ReturnFrom<US2_$union>(_v9307);
        });
    });
}

export function method49(v0_1: int64, v1_1: string): string {
    const v3: Mut3 = new Mut3(method16());
    let v10: any;
    closure6(v3, `${"{ "}`, undefined);
    v10 = undefined;
    let v19_1: any;
    closure6(v3, `${"retry"}`, undefined);
    v19_1 = undefined;
    let v28_1: any;
    closure6(v3, `${" = "}`, undefined);
    v28_1 = undefined;
    let v36: any;
    closure6(v3, `${v0_1}`, undefined);
    v36 = undefined;
    let v45: any;
    closure6(v3, `${"; "}`, undefined);
    v45 = undefined;
    let v54: any;
    closure6(v3, `${"ex"}`, undefined);
    v54 = undefined;
    let v62: any;
    closure6(v3, `${" = "}`, undefined);
    v62 = undefined;
    let v70: any;
    closure6(v3, `${v1_1}`, undefined);
    v70 = undefined;
    let v79: any;
    closure6(v3, `${" }"}`, undefined);
    v79 = undefined;
    return v3.l0;
}

export function method48(v0_1: Mut0, v1_1: Mut1, v2_1: Mut2, v3: Mut3, v4: Mut4, v5: Option<int64>, v6: string, v7: string, v8: int64, v9: string): string {
    const v10: string = method49(v8, v9);
    return method21(`${v6} ${v7} #${v0_1.l0} ${"file_system.read_all_text_retry_async"} / ${v10}`);
}

export function closure31(v0_1: int64, v1_1: string, unitVar: void): void {
    if (method9(US0_US0_1())) {
        let v6: any;
        closure0(undefined, undefined);
        v6 = undefined;
        const patternInput: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_9(TraceState_trace_state());
        const v25_1: Option<int64> = patternInput[5];
        const v24_1: Mut4 = patternInput[4];
        const v23_1: Mut3 = patternInput[3];
        const v22_1: Mut2 = patternInput[2];
        const v21_1: Mut1 = patternInput[1];
        const v20_1: Mut0 = patternInput[0];
        method22(method48(v20_1, v21_1, v22_1, v23_1, v24_1, v25_1, method10(v20_1, v21_1, v22_1, v23_1, v24_1, v25_1), method14(), v0_1, v1_1));
    }
}

export function method37(v0_1: string, v1_1: int64): any {
    return singleton.Delay<Option<string>>((): any => {
        const v13: int64 = method38(v1_1);
        return singleton.TryWith<Option<string>>(singleton.Delay<Option<string>>((): any => {
            let v54: any;
            const v14: boolean = compare_1(v13, 0n) > 0;
            return singleton.Combine<Option<string>>(v14 ? ((v54 = ignore<US2_$union>(method39(1000, defaultOf())), singleton.Bind<void, void>(v54, (): any => {
                return singleton.Zero();
            }))) : singleton.Zero(), singleton.Delay<Option<string>>((): any => {
                const v76: any = defaultOf();
                const _v122: any = singleton.Delay<Option<string>>((): any => singleton.Bind<string, Option<string>>(v76, (_arg_1: string): any => singleton.Return<Option<string>>(_arg_1)));
                return singleton.ReturnFrom<Option<string>>(_v122);
            }));
        }), (_arg_2: Error): any => {
            if (equals(v13, 0n) !== true) {
                let v181: any;
                closure31(v13, toText(interpolate("%A%P()", [_arg_2])), undefined);
                v181 = undefined;
                return singleton.Return<Option<string>>(undefined);
            }
            else {
                const v223: any = method37(v0_1, toInt64(op_Addition(v13, 1n)));
                return singleton.ReturnFrom<Option<string>>(v223);
            }
        });
    });
}

export function closure26(unitVar: void, v0_1: string): any {
    return defaultOf();
}

export function closure33(unitVar: void, v0_1: any): US11_$union {
    return US11_US11_0(v0_1);
}

export function method52(): ((arg0: any) => US11_$union) {
    return (v: any): US11_$union => closure33(undefined, v);
}

export function method53(): string {
    return "hh:mm";
}

export function method54(): string {
    return "yyyyMMdd-HHmm-ssff-ffff-f";
}

export function method55(): string {
    return "hhmm";
}

export function method51(v0_1: string, v1_1: Date): string {
    const v508: string = toString(v1_1, method54());
    const v523: any = defaultOf();
    let v607: number;
    throw new Error(`date_time.get_utc_offset / target: ${US4_US4_3(US3_US3_0())}`);
    const v618: uint8 = (hours(v607) > 0) ? 1 : 0;
    const v619: string = method55();
    const v631 = `${v618}${toString_1(v607, "c", {})}`;
    const v633: string = v0_1;
    return parse(`${v508}${v631}${v633.slice(v508.length + v631.length, v633.length)}`);
}

export function method57(): string {
    throw new Error(`file_system.get_temp_path / target: ${US4_US4_3(US3_US3_0())}`);
}

export function method58(): string {
    return "!create_temp_path_";
}

export function method61(v0_1: string): string {
    return v0_1;
}

export function method60(v0_1: string, v1_1: string): [string, string] {
    return [v1_1, method61(v0_1)] as [string, string];
}

export function method59(v0_1: string, v1_1: string): string {
    const v183: IPathJoin = path;
    const patternInput: [string, string] = method60(v1_1, v0_1);
    return v183.join(patternInput[0], patternInput[1]);
}

export function method63(): string {
    return "CARGO_PKG_NAME";
}

export function method62(): string {
    throw new Error(`env.get_entry_assembly_name / target: ${US4_US4_3(US3_US3_0())}`);
}

export function method56(v0_1: string): string {
    return method59(method59(method59(method57(), method58()), method62()), v0_1);
}

export function method50(): string {
    const v52: Date = now();
    return method56(method51(newGuid(), v52));
}

export function closure32(unitVar: void, unitVar_1: void): string {
    return method50();
}

export function method65(v0_1: string): string {
    return v0_1;
}

export function closure35(unitVar: void, v0_1: any): any {
    return defaultOf();
}

export function method66(): ((arg0: any) => any) {
    return (v: any): any => closure35(undefined, v);
}

export function closure36(unitVar: void, unitVar_1: void): US12_$union {
    return US12_US12_0();
}

export function method67(): (() => US12_$union) {
    return (): US12_$union => closure36(undefined, undefined);
}

export function closure37(unitVar: void, v0_1: any): US12_$union {
    return US12_US12_1(v0_1);
}

export function method68(): ((arg0: any) => US12_$union) {
    return (v: any): US12_$union => closure37(undefined, v);
}

export function method70(v0_1: string, v1_1: any): string {
    const v3: Mut3 = new Mut3(method16());
    let v10: any;
    closure6(v3, `${"{ "}`, undefined);
    v10 = undefined;
    let v19_1: any;
    closure6(v3, `${"dir"}`, undefined);
    v19_1 = undefined;
    let v28_1: any;
    closure6(v3, `${" = "}`, undefined);
    v28_1 = undefined;
    let v36: any;
    closure6(v3, `${v0_1}`, undefined);
    v36 = undefined;
    let v45: any;
    closure6(v3, `${"; "}`, undefined);
    v45 = undefined;
    let v54: any;
    closure6(v3, `${"error"}`, undefined);
    v54 = undefined;
    let v62: any;
    closure6(v3, `${" = "}`, undefined);
    v62 = undefined;
    let v100: any;
    closure6(v3, `${toText(interpolate("%A%P()", [v1_1]))}`, undefined);
    v100 = undefined;
    let v109: any;
    closure6(v3, `${" }"}`, undefined);
    v109 = undefined;
    return v3.l0;
}

export function method69(v0_1: Mut0, v1_1: Mut1, v2_1: Mut2, v3: Mut3, v4: Mut4, v5: Option<int64>, v6: string, v7: string, v8: string, v9: any): string {
    const v10: string = method70(v8, v9);
    return method21(`${v6} ${v7} #${v0_1.l0} ${"file_system.create_dir"} / ${v10}`);
}

export function closure38(v0_1: string, v1_1: any, unitVar: void): void {
    if (method9(US0_US0_4())) {
        let v6: any;
        closure0(undefined, undefined);
        v6 = undefined;
        const patternInput: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_9(TraceState_trace_state());
        const v25_1: Option<int64> = patternInput[5];
        const v24_1: Mut4 = patternInput[4];
        const v23_1: Mut3 = patternInput[3];
        const v22_1: Mut2 = patternInput[2];
        const v21_1: Mut1 = patternInput[1];
        const v20_1: Mut0 = patternInput[0];
        method22(method69(v20_1, v21_1, v22_1, v23_1, v24_1, v25_1, method10(v20_1, v21_1, v22_1, v23_1, v24_1, v25_1), method45(), v0_1, v1_1));
    }
}

export function method72(v0_1: string): string {
    const v2_1: Mut3 = new Mut3(method16());
    let v9: any;
    closure6(v2_1, `${"{ "}`, undefined);
    v9 = undefined;
    let v18_1: any;
    closure6(v2_1, `${"dir"}`, undefined);
    v18_1 = undefined;
    let v27_1: any;
    closure6(v2_1, `${" = "}`, undefined);
    v27_1 = undefined;
    let v35_1: any;
    closure6(v2_1, `${v0_1}`, undefined);
    v35_1 = undefined;
    let v44: any;
    closure6(v2_1, `${" }"}`, undefined);
    v44 = undefined;
    return v2_1.l0;
}

export function method71(v0_1: Mut0, v1_1: Mut1, v2_1: Mut2, v3: Mut3, v4: Mut4, v5: Option<int64>, v6: string, v7: string, v8: string): string {
    const v9: string = method72(v8);
    return method21(`${v6} ${v7} #${v0_1.l0} ${"file_system.create_dir"} / ${v9}`);
}

export function closure39(v0_1: string, unitVar: void): void {
    if (method9(US0_US0_0())) {
        let v5: any;
        closure0(undefined, undefined);
        v5 = undefined;
        const patternInput: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_9(TraceState_trace_state());
        const v24_1: Option<int64> = patternInput[5];
        const v23_1: Mut4 = patternInput[4];
        const v22_1: Mut3 = patternInput[3];
        const v21_1: Mut2 = patternInput[2];
        const v20_1: Mut1 = patternInput[1];
        const v19_1: Mut0 = patternInput[0];
        method22(method71(v19_1, v20_1, v21_1, v22_1, v23_1, v24_1, method10(v19_1, v20_1, v21_1, v22_1, v23_1, v24_1), method42(), v0_1));
    }
}

export function closure40(v0_1: string, unitVar: void): void {
    method6(true, v0_1);
}

export function method73(v0_1: string): (() => void) {
    return (): void => {
        closure40(v0_1, undefined);
    };
}

export function method74(v0_1: string): (() => void) {
    return (): void => {
        closure40(v0_1, undefined);
    };
}

export function method76(v0_1: string, v1_1: string): string {
    const v3: Mut3 = new Mut3(method16());
    let v10: any;
    closure6(v3, `${"{ "}`, undefined);
    v10 = undefined;
    let v19_1: any;
    closure6(v3, `${"dir"}`, undefined);
    v19_1 = undefined;
    let v28_1: any;
    closure6(v3, `${" = "}`, undefined);
    v28_1 = undefined;
    let v36: any;
    closure6(v3, `${v0_1}`, undefined);
    v36 = undefined;
    let v45: any;
    closure6(v3, `${"; "}`, undefined);
    v45 = undefined;
    let v54: any;
    closure6(v3, `${"result"}`, undefined);
    v54 = undefined;
    let v62: any;
    closure6(v3, `${" = "}`, undefined);
    v62 = undefined;
    let v70: any;
    closure6(v3, `${v1_1}`, undefined);
    v70 = undefined;
    let v79: any;
    closure6(v3, `${" }"}`, undefined);
    v79 = undefined;
    return v3.l0;
}

export function method75(v0_1: Mut0, v1_1: Mut1, v2_1: Mut2, v3: Mut3, v4: Mut4, v5: Option<int64>, v6: string, v7: string, v8: string, v9: string): string {
    const v10: string = method76(v8, v9);
    return method21(`${v6} ${v7} #${v0_1.l0} ${"file_system.create_dir"} / ${v10}`);
}

export function closure41(v0_1: string, v1_1: string, unitVar: void): void {
    if (method9(US0_US0_1())) {
        let v6: any;
        closure0(undefined, undefined);
        v6 = undefined;
        const patternInput: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_9(TraceState_trace_state());
        const v25_1: Option<int64> = patternInput[5];
        const v24_1: Mut4 = patternInput[4];
        const v23_1: Mut3 = patternInput[3];
        const v22_1: Mut2 = patternInput[2];
        const v21_1: Mut1 = patternInput[1];
        const v20_1: Mut0 = patternInput[0];
        method22(method75(v20_1, v21_1, v22_1, v23_1, v24_1, v25_1, method10(v20_1, v21_1, v22_1, v23_1, v24_1, v25_1), method14(), v0_1, v1_1));
    }
}

export function closure42(v0_1: string, unitVar: void): void {
    const v38: any = ignore<int64>(defaultOf());
    defaultOf();
}

export function method77(v0_1: string): (() => void) {
    return (): void => {
        closure42(v0_1, undefined);
    };
}

export function method78(v0_1: string): (() => void) {
    return (): void => {
        closure42(v0_1, undefined);
    };
}

export function method64(v0_1: string): IDisposable {
    const v143: any = void defaultOf();
    const v179: boolean = defaultOf();
    if (v179 === false) {
        let v216: any;
        closure41(v0_1, toText(interpolate("%A%P()", [{
            CreationTime: defaultOf(),
            Exists: v179,
        }])), undefined);
        v216 = undefined;
    }
    const v263: (() => void) = method78(v0_1);
    return {
        Dispose(): void {
            v263();
        },
    };
}

export function closure34(unitVar: void, unitVar_1: void): [string, IDisposable] {
    const v0_1: string = method50();
    return [v0_1, method64(v0_1)] as [string, IDisposable];
}

export function method79(v0_1: string): string {
    const v45: string = padLeft(v0_1, 32, "0");
    return parse(`${v45.slice(0, 7 + 1)}-${v45.slice(8, 11 + 1)}-${v45.slice(12, 15 + 1)}-${v45.slice(16, 19 + 1)}-${v45.slice(20, 31 + 1)}`);
}

export function closure43(unitVar: void, v0_1: string): [string, IDisposable] {
    const v2_1: string = method56(method79(v0_1));
    return [v2_1, method64(v2_1)] as [string, IDisposable];
}

export function closure44(unitVar: void, unitVar_1: void): string {
    return "C:\\home\\git\\polyglot\\lib\\spiral";
}

export function method84(v0_1: any): string {
    const v2_1: Mut3 = new Mut3(method16());
    let v38: any;
    closure6(v2_1, `${toText(interpolate("%A%P()", [v0_1]))}`, undefined);
    v38 = undefined;
    return v2_1.l0;
}

export function closure46(unitVar: void, v0_1: any): string {
    return method84(v0_1);
}

export function method83(): ((arg0: any) => string) {
    return (v: any): string => closure46(undefined, v);
}

export function closure47(unitVar: void, v0_1: any): US13_$union {
    return US13_US13_0(v0_1);
}

export function method85(): ((arg0: any) => US13_$union) {
    return (v: any): US13_$union => closure47(undefined, v);
}

export function closure48(unitVar: void, v0_1: string): US13_$union {
    return US13_US13_1(v0_1);
}

export function method86(): ((arg0: string) => US13_$union) {
    return (v: string): US13_$union => closure48(undefined, v);
}

export function method89(v0_1: string): Option<string> {
    const v141: IPathDirname = path;
    return v141.dirname(v0_1);
}

export function method90(v0_1: string): string {
    const v2_1: Mut3 = new Mut3(method16());
    let v8: any;
    closure6(v2_1, `${v0_1}`, undefined);
    v8 = undefined;
    return v2_1.l0;
}

export function method88(v0_1: string, v1_1: ((arg0: uint8, arg1: string) => FSharpResult$2_$union<any, any>), v2_1: uint8, v3: string, v4: string): FSharpResult$2_$union<any, any> {
    const v5: string = method18(v4);
    const v6: Option<string> = method89(v4);
    const v20_1: US5_$union = defaultArg(map<string, US5_$union>(method4(), v6), US5_US5_1());
    const v24_1: string = method90(v3);
    if (v2_1 >= 11) {
        return FSharpResult$2_Error<any, any>(`file_system.read_link / path: ${v0_1} / n: ${v2_1} / path': ${v4} / name: ${v5}`);
    }
    else if (v20_1.tag === /* US5_0 */ 0) {
        const v65: string = v20_1.fields[0];
        if (v4 !== "") {
            const v72: FSharpResult$2_$union<any, any> = v1_1(v2_1 + 1, v65);
            const v73: ((arg0: any) => string) = method83();
            const v85: FSharpResult$2_$union<any, string> = (v72.tag === /* Error */ 1) ? FSharpResult$2_Error<any, string>(v73(v72.fields[0])) : FSharpResult$2_Ok<any, string>(v72.fields[0]);
            const v88: ((arg0: any) => US13_$union) = method85();
            const v89: ((arg0: string) => US13_$union) = method86();
            const v90: US13_$union = (v85.tag === /* Error */ 1) ? v89(v85.fields[0]) : v88(v85.fields[0]);
            if (v90.tag === /* US13_0 */ 0) {
                return FSharpResult$2_Ok<any, any>(method59(toString_2(v90.fields[0]), v5));
            }
            else {
                return FSharpResult$2_Error<any, any>(`file_system.read_link / error': ${v90.fields[0]} / error: ${v24_1} / name: ${v5}`);
            }
        }
        else {
            return FSharpResult$2_Error<any, any>(`file_system.read_link / run / The file or directory is not a reparse point. / path: ${v0_1} / error: ${v24_1} / path': ${v4} / name: ${v5}`);
        }
    }
    else {
        return FSharpResult$2_Error<any, any>(`file_system.read_link / run / The file or directory is not a reparse point. / path: ${v0_1} / error: ${v24_1} / path': ${v4} / name: ${v5}`);
    }
}

export function method87(v0_1: string, v1_1: uint8, v2_1: string): FSharpResult$2_$union<any, any> {
    return defaultOf();
}

export function closure50(v0_1: string, v1_1: uint8, v2_1: string): FSharpResult$2_$union<any, any> {
    return method87(v0_1, v1_1, v2_1);
}

export function closure49(v0_1: string, v1_1: uint8): ((arg0: string) => FSharpResult$2_$union<any, any>) {
    return (v: string): FSharpResult$2_$union<any, any> => closure50(v0_1, v1_1, v);
}

export function method91(v0_1: string, v1_1: ((arg0: uint8, arg1: string) => FSharpResult$2_$union<any, any>), v2_1: uint8, v3: string): FSharpResult$2_$union<any, any> {
    const v4: string = method18(v0_1);
    const v5: Option<string> = method89(v0_1);
    const v19_1: US5_$union = defaultArg(map<string, US5_$union>(method4(), v5), US5_US5_1());
    const v23_1: string = method90(v3);
    if (v2_1 >= 11) {
        return FSharpResult$2_Error<any, any>(`file_system.read_link / path: ${v0_1} / n: ${v2_1} / path': ${v0_1} / name: ${v4}`);
    }
    else if (v19_1.tag === /* US5_0 */ 0) {
        const v64: string = v19_1.fields[0];
        if (v0_1 !== "") {
            const v71: FSharpResult$2_$union<any, any> = v1_1(v2_1 + 1, v64);
            const v72: ((arg0: any) => string) = method83();
            const v84: FSharpResult$2_$union<any, string> = (v71.tag === /* Error */ 1) ? FSharpResult$2_Error<any, string>(v72(v71.fields[0])) : FSharpResult$2_Ok<any, string>(v71.fields[0]);
            const v87: ((arg0: any) => US13_$union) = method85();
            const v88: ((arg0: string) => US13_$union) = method86();
            const v89: US13_$union = (v84.tag === /* Error */ 1) ? v88(v84.fields[0]) : v87(v84.fields[0]);
            if (v89.tag === /* US13_0 */ 0) {
                return FSharpResult$2_Ok<any, any>(method59(toString_2(v89.fields[0]), v4));
            }
            else {
                return FSharpResult$2_Error<any, any>(`file_system.read_link / error': ${v89.fields[0]} / error: ${v23_1} / name: ${v4}`);
            }
        }
        else {
            return FSharpResult$2_Error<any, any>(`file_system.read_link / run / The file or directory is not a reparse point. / path: ${v0_1} / error: ${v23_1} / path': ${v0_1} / name: ${v4}`);
        }
    }
    else {
        return FSharpResult$2_Error<any, any>(`file_system.read_link / run / The file or directory is not a reparse point. / path: ${v0_1} / error: ${v23_1} / path': ${v0_1} / name: ${v4}`);
    }
}

export function method82(v0_1: string, v1_1: uint8): FSharpResult$2_$union<any, any> {
    return defaultOf();
}

export function method94(v0_1: string, v1_1: ((arg0: uint8, arg1: string) => FSharpResult$2_$union<any, any>), v2_1: uint8, v3: any, v4: string): FSharpResult$2_$union<any, any> {
    const v5: string = method18(v4);
    const v6: Option<string> = method89(v4);
    const v20_1: US5_$union = defaultArg(map<string, US5_$union>(method4(), v6), US5_US5_1());
    const v24_1: string = method84(v3);
    if (v2_1 >= 11) {
        return FSharpResult$2_Error<any, any>(`file_system.read_link / path: ${v0_1} / n: ${v2_1} / path': ${v4} / name: ${v5}`);
    }
    else if (v20_1.tag === /* US5_0 */ 0) {
        const v65: string = v20_1.fields[0];
        if (v4 !== "") {
            const v72: FSharpResult$2_$union<any, any> = v1_1(v2_1 + 1, v65);
            const v73: ((arg0: any) => string) = method83();
            const v85: FSharpResult$2_$union<any, string> = (v72.tag === /* Error */ 1) ? FSharpResult$2_Error<any, string>(v73(v72.fields[0])) : FSharpResult$2_Ok<any, string>(v72.fields[0]);
            const v88: ((arg0: any) => US13_$union) = method85();
            const v89: ((arg0: string) => US13_$union) = method86();
            const v90: US13_$union = (v85.tag === /* Error */ 1) ? v89(v85.fields[0]) : v88(v85.fields[0]);
            if (v90.tag === /* US13_0 */ 0) {
                return FSharpResult$2_Ok<any, any>(method59(toString_2(v90.fields[0]), v5));
            }
            else {
                return FSharpResult$2_Error<any, any>(`file_system.read_link / error': ${v90.fields[0]} / error: ${v24_1} / name: ${v5}`);
            }
        }
        else {
            return FSharpResult$2_Error<any, any>(`file_system.read_link / run / The file or directory is not a reparse point. / path: ${v0_1} / error: ${v24_1} / path': ${v4} / name: ${v5}`);
        }
    }
    else {
        return FSharpResult$2_Error<any, any>(`file_system.read_link / run / The file or directory is not a reparse point. / path: ${v0_1} / error: ${v24_1} / path': ${v4} / name: ${v5}`);
    }
}

export function method93(v0_1: string, v1_1: uint8, v2_1: string): FSharpResult$2_$union<any, any> {
    const v13: any = void defaultOf();
    const v39: int32 = defaultOf() | 0;
    const v64: int32 = defaultOf() | 0;
    const v99: boolean = defaultOf();
    if (v99) {
        const v114: any = void defaultOf();
        return FSharpResult$2_Ok<any, any>(defaultOf());
    }
    else {
        return method94(v0_1, uncurry2((v: uint8): ((arg0: string) => FSharpResult$2_$union<any, any>) => closure51(v0_1, v)), v1_1, `file_system.read_link / Fsharp / The file or directory is not a reparse point. / path: ${v0_1} / result: ${v99} / path': ${v2_1} / n: ${v1_1}`, v2_1);
    }
}

export function closure52(v0_1: string, v1_1: uint8, v2_1: string): FSharpResult$2_$union<any, any> {
    return method93(v0_1, v1_1, v2_1);
}

export function closure51(v0_1: string, v1_1: uint8): ((arg0: string) => FSharpResult$2_$union<any, any>) {
    return (v: string): FSharpResult$2_$union<any, any> => closure52(v0_1, v1_1, v);
}

export function method95(v0_1: string, v1_1: ((arg0: uint8, arg1: string) => FSharpResult$2_$union<any, any>), v2_1: uint8, v3: any): FSharpResult$2_$union<any, any> {
    const v4: string = method18(v0_1);
    const v5: Option<string> = method89(v0_1);
    const v19_1: US5_$union = defaultArg(map<string, US5_$union>(method4(), v5), US5_US5_1());
    const v23_1: string = method84(v3);
    if (v2_1 >= 11) {
        return FSharpResult$2_Error<any, any>(`file_system.read_link / path: ${v0_1} / n: ${v2_1} / path': ${v0_1} / name: ${v4}`);
    }
    else if (v19_1.tag === /* US5_0 */ 0) {
        const v64: string = v19_1.fields[0];
        if (v0_1 !== "") {
            const v71: FSharpResult$2_$union<any, any> = v1_1(v2_1 + 1, v64);
            const v72: ((arg0: any) => string) = method83();
            const v84: FSharpResult$2_$union<any, string> = (v71.tag === /* Error */ 1) ? FSharpResult$2_Error<any, string>(v72(v71.fields[0])) : FSharpResult$2_Ok<any, string>(v71.fields[0]);
            const v87: ((arg0: any) => US13_$union) = method85();
            const v88: ((arg0: string) => US13_$union) = method86();
            const v89: US13_$union = (v84.tag === /* Error */ 1) ? v88(v84.fields[0]) : v87(v84.fields[0]);
            if (v89.tag === /* US13_0 */ 0) {
                return FSharpResult$2_Ok<any, any>(method59(toString_2(v89.fields[0]), v4));
            }
            else {
                return FSharpResult$2_Error<any, any>(`file_system.read_link / error': ${v89.fields[0]} / error: ${v23_1} / name: ${v4}`);
            }
        }
        else {
            return FSharpResult$2_Error<any, any>(`file_system.read_link / run / The file or directory is not a reparse point. / path: ${v0_1} / error: ${v23_1} / path': ${v0_1} / name: ${v4}`);
        }
    }
    else {
        return FSharpResult$2_Error<any, any>(`file_system.read_link / run / The file or directory is not a reparse point. / path: ${v0_1} / error: ${v23_1} / path': ${v0_1} / name: ${v4}`);
    }
}

export function method92(v0_1: string, v1_1: uint8): FSharpResult$2_$union<any, any> {
    const v12: any = void defaultOf();
    const v38: int32 = defaultOf() | 0;
    const v63: int32 = defaultOf() | 0;
    const v98: boolean = defaultOf();
    if (v98) {
        const v113: any = void defaultOf();
        return FSharpResult$2_Ok<any, any>(defaultOf());
    }
    else {
        return method95(v0_1, uncurry2((v: uint8): ((arg0: string) => FSharpResult$2_$union<any, any>) => closure51(v0_1, v)), v1_1, `file_system.read_link / Fsharp / The file or directory is not a reparse point. / path: ${v0_1} / result: ${v98} / path': ${v0_1} / n: ${v1_1}`);
    }
}

export function method81(v0_1: string): FSharpResult$2_$union<any, any> {
    return defaultOf();
}

export function closure53(unitVar: void, v0_1: any): US14_$union {
    return US14_US14_0(v0_1);
}

export function method96(): ((arg0: any) => US14_$union) {
    return (v: any): US14_$union => closure53(undefined, v);
}

export function method98(v0_1: string): string {
    return v0_1;
}

export function method97(v0_1: string, v1_1: string, v2_1: string): string {
    return defaultOf();
}

export function method80(v0_1: string): string {
    let _arg: string;
    if (v0_1 === "") {
        return "";
    }
    else {
        const v3: FSharpResult$2_$union<any, any> = method81(v0_1);
        const v11: Option<any> = (v3.tag === /* Error */ 1) ? undefined : v3.fields[0];
        const v31_1: US14_$union = defaultArg(map<any, US14_$union>(method96(), v11), US14_US14_1());
        let v66: string;
        if (v31_1.tag === /* US14_0 */ 0) {
            const v60: string = toString_2(v31_1.fields[0]);
            v66 = ((v60 === "") ? v0_1 : v60);
        }
        else {
            v66 = v0_1;
        }
        if (v66 === "") {
            return "";
        }
        else {
            const v71: string = method97("^\\\\\\\\\\?\\\\", "", v66);
            return replace(`${(_arg = v71[0], _arg.toLocaleLowerCase())}${v71.slice(1, v71.length)}`, "\\", "/");
        }
    }
}

export function closure45(unitVar: void, v0_1: string): string {
    return method80(v0_1);
}

export function closure54(unitVar: void, v0_1: string): string {
    return `file:///${trimStart(v0_1, ...["/"])}`;
}

export function closure56(unitVar: void, v0_1: string): Option<string> {
    return method89(v0_1);
}

export function method100(): ((arg0: string) => Option<string>) {
    return (v: string): Option<string> => closure56(undefined, v);
}

export function method101(v0_1_mut: string, v1_1_mut: string, v2_1_mut: string): US15_$union {
    method101:
    while (true) {
        const v0_1: string = v0_1_mut, v1_1: string = v1_1_mut, v2_1: string = v2_1_mut;
        if (method8(method59(v2_1, v0_1))) {
            return US15_US15_0(v2_1);
        }
        else {
            const v7: Option<string> = method100()(v2_1);
            const v21_1: US5_$union = defaultArg(map<string, US5_$union>(method4(), v7), US5_US5_1());
            if (v21_1.tag === /* US5_0 */ 0) {
                v0_1_mut = v0_1;
                v1_1_mut = v1_1;
                v2_1_mut = v21_1.fields[0];
                continue method101;
            }
            else {
                return US15_US15_1(`No parent for ${"dir"} '${v0_1}' at '${v1_1}' (until '${v2_1}')`);
            }
        }
        break;
    }
}

export function method99(v0_1: string, v1_1: string): US15_$union {
    if (method8(method59(v1_1, v0_1))) {
        return US15_US15_0(v1_1);
    }
    else {
        const v6: Option<string> = method100()(v1_1);
        const v20_1: US5_$union = defaultArg(map<string, US5_$union>(method4(), v6), US5_US5_1());
        if (v20_1.tag === /* US5_0 */ 0) {
            return method101(v0_1, v1_1, v20_1.fields[0]);
        }
        else {
            return US15_US15_1(`No parent for ${"dir"} '${v0_1}' at '${v1_1}' (until '${v1_1}')`);
        }
    }
}

export function method103(v0_1: string): string {
    const v2_1: Mut3 = new Mut3(method16());
    let v9: any;
    closure6(v2_1, `${"{ "}`, undefined);
    v9 = undefined;
    let v18_1: any;
    closure6(v2_1, `${"error"}`, undefined);
    v18_1 = undefined;
    let v27_1: any;
    closure6(v2_1, `${" = "}`, undefined);
    v27_1 = undefined;
    let v35_1: any;
    closure6(v2_1, `${v0_1}`, undefined);
    v35_1 = undefined;
    let v44: any;
    closure6(v2_1, `${" }"}`, undefined);
    v44 = undefined;
    return v2_1.l0;
}

export function method102(v0_1: Mut0, v1_1: Mut1, v2_1: Mut2, v3: Mut3, v4: Mut4, v5: Option<int64>, v6: string, v7: string, v8: string): string {
    const v9: string = method103(v8);
    return method21(`${v6} ${v7} #${v0_1.l0} ${"file_system.get_workspace_root"} / ${v9}`);
}

export function closure57(v0_1: string, unitVar: void): void {
    if (method9(US0_US0_3())) {
        let v5: any;
        closure0(undefined, undefined);
        v5 = undefined;
        const patternInput: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_9(TraceState_trace_state());
        const v24_1: Option<int64> = patternInput[5];
        const v23_1: Mut4 = patternInput[4];
        const v22_1: Mut3 = patternInput[3];
        const v21_1: Mut2 = patternInput[2];
        const v20_1: Mut1 = patternInput[1];
        const v19_1: Mut0 = patternInput[0];
        method22(method102(v19_1, v20_1, v21_1, v22_1, v23_1, v24_1, method10(v19_1, v20_1, v21_1, v22_1, v23_1, v24_1), method31(), v0_1));
    }
}

export function method104(): string {
    return defaultOf();
}

export function closure55(unitVar: void, unitVar_1: void): string {
    const v4: US15_$union = method99(method59("polyglot", ".devcontainer"), "C:\\home\\git\\polyglot\\lib\\spiral");
    let v52: US5_$union;
    if (v4.tag === /* US15_0 */ 0) {
        v52 = US5_US5_0(v4.fields[0]);
    }
    else {
        let v10: any;
        closure57(v4.fields[0], undefined);
        v10 = undefined;
        v52 = US5_US5_1();
    }
    let v107: US5_$union;
    if (v52.tag === /* US5_0 */ 0) {
        v107 = US5_US5_0(v52.fields[0]);
    }
    else {
        const v55: string = method104();
        const v57: US15_$union = method99(method59("polyglot", ".devcontainer"), v55);
        if (v57.tag === /* US15_0 */ 0) {
            v107 = US5_US5_0(v57.fields[0]);
        }
        else {
            let v63: any;
            closure57(v57.fields[0], undefined);
            v63 = undefined;
            v107 = US5_US5_1();
        }
    }
    return method59((v107.tag === /* US5_0 */ 0) ? v107.fields[0] : (() => {
        throw new Error("Option does not have a value.");
    })(), "polyglot");
}

export function method105(v0_1: string): void {
}

export function closure59(unitVar: void, v0_1: string): void {
    method105(v0_1);
}

export function closure58(unitVar: void, v0_1: boolean): void {
    let v3: any;
    closure0(undefined, undefined);
    v3 = undefined;
    const patternInput: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_9(TraceState_trace_state());
    const v37: ((arg0: string) => void) = v0_1 ? ((v: string): void => {
        closure59(undefined, v);
    }) : ((v_1: string): void => {
        closure2(undefined, v_1);
    });
    patternInput[1].l0 = v37;
}

export function method106(v0_1: string, v1_1: string): void {
    let v14: FSharpResult$2_$union<any, any>;
    if (method8(v0_1) === false) {
        const v4: IDisposable = method64(v0_1);
    }
    const v7: string = defaultArg(method89(v1_1), "");
    if (method8(v7) === false) {
        const v12: IDisposable = method64(v7);
    }
    if (method8(v1_1) && ((v14 = method81(v1_1), true))) {
        method6(true, v1_1);
    }
    if (method8(v1_1) === false) {
    }
}

export function closure61(v0_1: string, v1_1: string): void {
    method106(v0_1, v1_1);
}

export function closure60(unitVar: void, v0_1: string): ((arg0: string) => void) {
    return (v: string): void => {
        closure61(v0_1, v);
    };
}

export function closure63(v0_1: string, v1_1: string): string {
    return method59(v0_1, v1_1);
}

export function closure62(unitVar: void, v0_1: string): ((arg0: string) => string) {
    return (v: string): string => closure63(v0_1, v);
}

export const v0: any = undefined;

export const v1 = (): void => {
    closure0(undefined, undefined);
};

export const v2: any = (v1(), v0);

export const v16 = (v: string): any => closure3(undefined, v);

export function delete_directory_async(x: string): any {
    return v16(x);
}

export const v17 = (v: US6_$union): ((arg0: string) => any) => closure10(undefined, v);

export function wait_for_file_access(x: US6_$union): ((arg0: string) => any) {
    return v17(x);
}

export const v18 = (v: string): any => closure13(undefined, v);

export function wait_for_file_access_read(x: string): any {
    return v18(x);
}

export const v19 = (v: string): any => closure14(undefined, v);

export function read_all_text_async(x: string): any {
    return v19(x);
}

export const v20 = (v: string): ((arg0: string) => boolean) => closure15(undefined, v);

export function file_exists_content(x: string): ((arg0: string) => boolean) {
    return v20(x);
}

export const v21 = (v: string): ((arg0: string) => any) => closure17(undefined, v);

export function write_all_text_async(x: string): ((arg0: string) => any) {
    return v21(x);
}

export const v22 = (v: string): ((arg0: string) => any) => closure19(undefined, v);

export function write_all_text_exists(x: string): ((arg0: string) => any) {
    return v22(x);
}

export const v23 = (v: string): any => closure21(undefined, v);

export function delete_file_async(x: string): any {
    return v23(x);
}

export const v24 = (v: string): ((arg0: string) => any) => closure23(undefined, v);

export function move_file_async(x: string): ((arg0: string) => any) {
    return v24(x);
}

export const v25 = (v: string): any => closure26(undefined, v);

export function read_all_text_retry_async(x: string): any {
    return v25(x);
}

export const v26 = (): string => closure32(undefined, undefined);

export function create_temp_path(): string {
    return v26();
}

export const v27 = (): [string, IDisposable] => closure34(undefined, undefined);

export function create_temp_dir(): [string, IDisposable] {
    return v27();
}

export const v28 = (v: string): [string, IDisposable] => closure43(undefined, v);

export function create_temp_dir$0027(x: string): [string, IDisposable] {
    return v28(x);
}

export const v29 = (): string => closure44(undefined, undefined);

export function get_source_directory(): string {
    return v29();
}

export const v30 = (v: string): string => closure45(undefined, v);

export function normalize_path(x: string): string {
    return v30(x);
}

export const v31 = (v: string): string => closure54(undefined, v);

export function new_file_uri(x: string): string {
    return v31(x);
}

export const v32 = (): string => closure55(undefined, undefined);

export function get_workspace_root(): string {
    return v32();
}

export const v33 = (v: boolean): void => {
    closure58(undefined, v);
};

export function init_trace_file(x: boolean): void {
    v33(x);
}

export const v34 = (v: string): ((arg0: string) => void) => closure60(undefined, v);

export function link_directory(x: string): ((arg0: string) => void) {
    return v34(x);
}

export const v35 = (v: string): ((arg0: string) => string) => closure62(undefined, v);

export function op_LessDivideGreater(x: string): ((arg0: string) => string) {
    return v35(x);
}


