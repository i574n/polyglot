import { defaultOf, compare, IComparable, IEquatable, IDisposable, createAtom } from "../../deps/Fable/src/fable-library-ts/Util.js";
import { value as value_3, map, defaultArg, Option } from "../../deps/Fable/src/fable-library-ts/Option.js";
import { op_Addition, op_Subtraction, toInt64, int64 } from "../../deps/Fable/src/fable-library-ts/BigInt.js";
import { bool_type, lambda_type, unit_type, string_type, record_type, int64_type, union_type, class_type, TypeInfo } from "../../deps/Fable/src/fable-library-ts/Reflection.js";
import { Record, Union } from "../../deps/Fable/src/fable-library-ts/Types.js";
import { create, toString, now, getTicks } from "../../deps/Fable/src/fable-library-ts/Date.js";
import * as fs from "fs";
import { toString as toString_1, milliseconds, seconds, minutes, hours, fromTicks } from "../../deps/Fable/src/fable-library-ts/TimeSpan.js";
import { replace, interpolate, toText, trimStart, trimEnd, padLeft } from "../../deps/Fable/src/fable-library-ts/String.js";
import { ofSeq, find } from "../../deps/Fable/src/fable-library-ts/Map.js";
import { uint8, int32 } from "../../deps/Fable/src/fable-library-ts/Int32.js";
import { newGuid, parse } from "../../deps/Fable/src/fable-library-ts/Guid.js";
import * as path from "path";
import { FSharpResult$2_$union } from "../../deps/Fable/src/fable-library-ts/Result.js";

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
    return union_type("File_system.US1", [], US1, () => [[["f0_0", string_type]], []]);
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
    return union_type("File_system.US2", [], US2, () => [[["f0_0", US0_$reflection()]], []]);
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
    return union_type("File_system.US3", [], US3, () => [[["f0_0", int64_type]], []]);
}

export type US4_$union = 
    | US4<0>
    | US4<1>
    | US4<2>

export type US4_$cases = {
    0: ["US4_0", []],
    1: ["US4_1", []],
    2: ["US4_2", []]
}

export function US4_US4_0() {
    return new US4<0>(0, []);
}

export function US4_US4_1() {
    return new US4<1>(1, []);
}

export function US4_US4_2() {
    return new US4<2>(2, []);
}

export class US4<Tag extends keyof US4_$cases> extends Union<Tag, US4_$cases[Tag][0]> {
    constructor(readonly tag: Tag, readonly fields: US4_$cases[Tag][1]) {
        super();
    }
    cases() {
        return ["US4_0", "US4_1", "US4_2"];
    }
}

export function US4_$reflection(): TypeInfo {
    return union_type("File_system.US4", [], US4, () => [[], [], []]);
}

export type US5_$union = 
    | US5<0>
    | US5<1>
    | US5<2>
    | US5<3>
    | US5<4>

export type US5_$cases = {
    0: ["US5_0", [US4_$union]],
    1: ["US5_1", [US4_$union]],
    2: ["US5_2", [US4_$union]],
    3: ["US5_3", [US4_$union]],
    4: ["US5_4", [US4_$union]]
}

export function US5_US5_0(f0_0: US4_$union) {
    return new US5<0>(0, [f0_0]);
}

export function US5_US5_1(f1_0: US4_$union) {
    return new US5<1>(1, [f1_0]);
}

export function US5_US5_2(f2_0: US4_$union) {
    return new US5<2>(2, [f2_0]);
}

export function US5_US5_3(f3_0: US4_$union) {
    return new US5<3>(3, [f3_0]);
}

export function US5_US5_4(f4_0: US4_$union) {
    return new US5<4>(4, [f4_0]);
}

export class US5<Tag extends keyof US5_$cases> extends Union<Tag, US5_$cases[Tag][0]> {
    constructor(readonly tag: Tag, readonly fields: US5_$cases[Tag][1]) {
        super();
    }
    cases() {
        return ["US5_0", "US5_1", "US5_2", "US5_3", "US5_4"];
    }
}

export function US5_$reflection(): TypeInfo {
    return union_type("File_system.US5", [], US5, () => [[["f0_0", US4_$reflection()]], [["f1_0", US4_$reflection()]], [["f2_0", US4_$reflection()]], [["f3_0", US4_$reflection()]], [["f4_0", US4_$reflection()]]]);
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
    0: ["US13_0", [string]],
    1: ["US13_1", [string]]
}

export function US13_US13_0(f0_0: string) {
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

export function method8(v0_1: string): string {
    return v0_1;
}

export function method9(v0_1: string): boolean {
    const v23_1: IFsExistsSync = fs;
    return v23_1.existsSync(v0_1);
}

export function method7(v0_1: boolean, v1_1: string): void {
}

export function closure5(unitVar: void, v0_1: int64): US3_$union {
    return US3_US3_0(v0_1);
}

export function method11(): ((arg0: int64) => US3_$union) {
    return (v: int64): US3_$union => closure5(undefined, v);
}

export function method12(): string {
    return "hh:mm:ss";
}

export function method13(): string {
    return "HH:mm:ss";
}

export function method10(v0_1: Mut0, v1_1: Mut1, v2_1: Mut2, v3: Mut3, v4: Mut4, v5: Option<int64>): string {
    let v181: int64, v191: number;
    const v177: US3_$union = defaultArg(map<int64, US3_$union>(method11(), v5), US3_US3_1());
    return toString((v177.tag === /* US3_0 */ 0) ? ((v181 = v177.fields[0], (v191 = fromTicks(toInt64(op_Subtraction(getTicks(now()), v181))), create(1, 1, 1, hours(v191), minutes(v191), seconds(v191), milliseconds(v191))))) : now(), method13());
}

export function method15(): string {
    return "\u001b[0m";
}

export function method14(): string {
    return ("\u001b[94m" + padLeft("Debug".toLocaleLowerCase(), 7, " ")) + method15();
}

export function method16(v0_1: string): string {
    throw new Error(`file_system.get_file_name / target: ${US5_US5_3(US4_US4_0())} / path: ${v0_1}`);
}

export function method18(): string {
    return "";
}

export function closure6(v0_1: Mut3, v1_1: string, unitVar: void): void {
    const v3: string = v0_1.l0 + v1_1;
    v0_1.l0 = v3;
}

export function method17(v0_1: string, v1_1: string): string {
    const v3: Mut3 = new Mut3(method18());
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

export function method19(v0_1: string, v1_1: string, v2_1: int64, v3: string): string {
    return trimEnd(trimStart(`${v0_1} ${v1_1} #${v2_1} ${"file_system.delete_directory_async"} / ${v3}`, ...[]), ...[" ", "/"]);
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

export function method20(v0_1: string, v1_1: Mut0, v2_1: Mut1, v3: Mut2, v4: Mut3, v5: Mut4, v6: Option<int64>): void {
    let v9: any;
    closure7(v1_1, undefined);
    v9 = undefined;
    closure8(undefined, v0_1);
    v2_1.l0(v0_1);
}

export function closure4(v0_1: string, v1_1: string, unitVar: void): void {
    const v3 = (): void => {
        closure0(undefined, undefined);
    };
    let v4: any;
    v3();
    v4 = undefined;
    const patternInput: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
    const v36: US0_$union = patternInput[4].l0;
    if ((patternInput[2].l0 === false) ? false : (1 >= find<US0_$union, int32>(v36, ofSeq([[US0_US0_0(), 0] as [US0_$union, int32], [US0_US0_1(), 1] as [US0_$union, int32], [US0_US0_2(), 2] as [US0_$union, int32], [US0_US0_3(), 3] as [US0_$union, int32], [US0_US0_4(), 4] as [US0_$union, int32]], {
        Compare: compare,
    })))) {
        let v43: any;
        v3();
        v43 = undefined;
        const patternInput_1: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
        const v57: Mut0 = patternInput_1[0];
        const v80: string = method19(method10(v57, patternInput_1[1], patternInput_1[2], patternInput_1[3], patternInput_1[4], patternInput_1[5]), method14(), v57.l0, method17(v1_1, method16(v0_1)));
        let v82: any;
        v3();
        v82 = undefined;
        const patternInput_2: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
        method20(v80, patternInput_2[0], patternInput_2[1], patternInput_2[2], patternInput_2[3], patternInput_2[4], patternInput_2[5]);
    }
}

export function method6(v0_1: string, v1_1: int64): any {
    return defaultOf();
}

export function closure3(unitVar: void, v0_1: string): any {
    return defaultOf();
}

export function method22(v0_1: string, v1_1: int64, v2_1: string): string {
    const v4: Mut3 = new Mut3(method18());
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

export function method23(v0_1: string, v1_1: string, v2_1: int64, v3: string): string {
    return trimEnd(trimStart(`${v0_1} ${v1_1} #${v2_1} ${"file_system.wait_for_file_access"} / ${v3}`, ...[]), ...[" ", "/"]);
}

export function closure12(v0_1: string, v1_1: int64, v2_1: string, unitVar: void): void {
    const v4 = (): void => {
        closure0(undefined, undefined);
    };
    let v5: any;
    v4();
    v5 = undefined;
    const patternInput: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
    const v37: US0_$union = patternInput[4].l0;
    if ((patternInput[2].l0 === false) ? false : (1 >= find<US0_$union, int32>(v37, ofSeq([[US0_US0_0(), 0] as [US0_$union, int32], [US0_US0_1(), 1] as [US0_$union, int32], [US0_US0_2(), 2] as [US0_$union, int32], [US0_US0_3(), 3] as [US0_$union, int32], [US0_US0_4(), 4] as [US0_$union, int32]], {
        Compare: compare,
    })))) {
        let v44: any;
        v4();
        v44 = undefined;
        const patternInput_1: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
        const v58: Mut0 = patternInput_1[0];
        const v81: string = method23(method10(v58, patternInput_1[1], patternInput_1[2], patternInput_1[3], patternInput_1[4], patternInput_1[5]), method14(), v58.l0, method22(method16(v0_1), v1_1, v2_1));
        let v83: any;
        v4();
        v83 = undefined;
        const patternInput_2: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
        method20(v81, patternInput_2[0], patternInput_2[1], patternInput_2[2], patternInput_2[3], patternInput_2[4], patternInput_2[5]);
    }
}

export function method21(v0_1: string, v1_1: US8_$union, v2_1: US7_$union, v3: int64): any {
    return defaultOf();
}

export function closure11(v0_1: US6_$union, v1_1: string): any {
    return defaultOf();
}

export function closure10(unitVar: void, v0_1: US6_$union): ((arg0: string) => any) {
    return (v: string): any => closure11(v0_1, v);
}

export function method24(v0_1: string, v1_1: int64): any {
    return defaultOf();
}

export function closure13(unitVar: void, v0_1: string): any {
    return defaultOf();
}

export function closure14(unitVar: void, v0_1: string): any {
    return defaultOf();
}

export function method26(v0_1: string): boolean {
    const v20_1: IFsExistsSync = fs;
    return v20_1.existsSync(v0_1);
}

export function method27(v0_1: any): any {
    return v0_1;
}

export function method25(v0_1: string, v1_1: string): boolean {
    return defaultOf();
}

export function closure16(v0_1: string, v1_1: string): boolean {
    return method25(v0_1, v1_1);
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
    return defaultOf();
}

export function closure19(unitVar: void, v0_1: string): ((arg0: string) => any) {
    return (v: string): any => closure20(v0_1, v);
}

export function method29(): string {
    return ("\u001b[93m" + padLeft("Warning".toLocaleLowerCase(), 7, " ")) + method15();
}

export function method30(v0_1: string, v1_1: string): string {
    const v3: Mut3 = new Mut3(method18());
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

export function method31(v0_1: string, v1_1: string, v2_1: int64, v3: string): string {
    return trimEnd(trimStart(`${v0_1} ${v1_1} #${v2_1} ${"delete_file_async"} / ${v3}`, ...[]), ...[" ", "/"]);
}

export function closure22(v0_1: string, v1_1: Error, unitVar: void): void {
    const v3 = (): void => {
        closure0(undefined, undefined);
    };
    let v4: any;
    v3();
    v4 = undefined;
    const patternInput: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
    const v36: US0_$union = patternInput[4].l0;
    if ((patternInput[2].l0 === false) ? false : (3 >= find<US0_$union, int32>(v36, ofSeq([[US0_US0_0(), 0] as [US0_$union, int32], [US0_US0_1(), 1] as [US0_$union, int32], [US0_US0_2(), 2] as [US0_$union, int32], [US0_US0_3(), 3] as [US0_$union, int32], [US0_US0_4(), 4] as [US0_$union, int32]], {
        Compare: compare,
    })))) {
        let v43: any;
        v3();
        v43 = undefined;
        const patternInput_1: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
        const v57: Mut0 = patternInput_1[0];
        const v102: string = method31(method10(v57, patternInput_1[1], patternInput_1[2], patternInput_1[3], patternInput_1[4], patternInput_1[5]), method29(), v57.l0, method30(method16(v0_1), toText(interpolate("%A%P()", [v1_1]))));
        let v104: any;
        v3();
        v104 = undefined;
        const patternInput_2: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
        method20(v102, patternInput_2[0], patternInput_2[1], patternInput_2[2], patternInput_2[3], patternInput_2[4], patternInput_2[5]);
    }
}

export function method28(v0_1: string, v1_1: int64): any {
    return defaultOf();
}

export function closure21(unitVar: void, v0_1: string): any {
    return defaultOf();
}

export function method33(v0_1: string, v1_1: string, v2_1: Error): string {
    const v4: Mut3 = new Mut3(method18());
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
    let v131: any;
    closure6(v4, `${toText(interpolate("%A%P()", [v2_1]))}`, undefined);
    v131 = undefined;
    let v140: any;
    closure6(v4, `${" }"}`, undefined);
    v140 = undefined;
    return v4.l0;
}

export function method34(v0_1: string, v1_1: string, v2_1: int64, v3: string): string {
    return trimEnd(trimStart(`${v0_1} ${v1_1} #${v2_1} ${"move_file_async"} / ${v3}`, ...[]), ...[" ", "/"]);
}

export function closure25(v0_1: string, v1_1: string, v2_1: Error, unitVar: void): void {
    const v4 = (): void => {
        closure0(undefined, undefined);
    };
    let v5: any;
    v4();
    v5 = undefined;
    const patternInput: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
    const v37: US0_$union = patternInput[4].l0;
    if ((patternInput[2].l0 === false) ? false : (3 >= find<US0_$union, int32>(v37, ofSeq([[US0_US0_0(), 0] as [US0_$union, int32], [US0_US0_1(), 1] as [US0_$union, int32], [US0_US0_2(), 2] as [US0_$union, int32], [US0_US0_3(), 3] as [US0_$union, int32], [US0_US0_4(), 4] as [US0_$union, int32]], {
        Compare: compare,
    })))) {
        let v44: any;
        v4();
        v44 = undefined;
        const patternInput_1: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
        const v58: Mut0 = patternInput_1[0];
        const v82: string = method34(method10(v58, patternInput_1[1], patternInput_1[2], patternInput_1[3], patternInput_1[4], patternInput_1[5]), method29(), v58.l0, method33(method16(v1_1), method16(v0_1), v2_1));
        let v84: any;
        v4();
        v84 = undefined;
        const patternInput_2: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
        method20(v82, patternInput_2[0], patternInput_2[1], patternInput_2[2], patternInput_2[3], patternInput_2[4], patternInput_2[5]);
    }
}

export function method32(v0_1: string, v1_1: string, v2_1: int64): any {
    return defaultOf();
}

export function closure24(v0_1: string, v1_1: string): any {
    return defaultOf();
}

export function closure23(unitVar: void, v0_1: string): ((arg0: string) => any) {
    return (v: string): any => closure24(v0_1, v);
}

export function closure27(unitVar: void, v0_1: int64): US9_$union {
    return US9_US9_0(v0_1);
}

export function closure28(unitVar: void, v0_1: Error): US9_$union {
    return US9_US9_1(v0_1);
}

export function method36(): string {
    return ("\u001b[90m" + padLeft("Verbose".toLocaleLowerCase(), 7, " ")) + method15();
}

export function method37(v0_1: int32): string {
    const v2_1: Mut3 = new Mut3(method18());
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

export function method38(v0_1: string, v1_1: string, v2_1: string, v3: int64, v4: string): string {
    return trimEnd(trimStart(`${v0_1} ${v1_1} #${v3} ${v2_1} / ${v4}`, ...[]), ...[" ", "/"]);
}

export function closure29(unitVar: void, unitVar_1: void): void {
    const v1_1 = (): void => {
        closure0(undefined, undefined);
    };
    let v2_1: any;
    v1_1();
    v2_1 = undefined;
    const patternInput: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
    const v34_1: US0_$union = patternInput[4].l0;
    if ((patternInput[2].l0 === false) ? false : (0 >= find<US0_$union, int32>(v34_1, ofSeq([[US0_US0_0(), 0] as [US0_$union, int32], [US0_US0_1(), 1] as [US0_$union, int32], [US0_US0_2(), 2] as [US0_$union, int32], [US0_US0_3(), 3] as [US0_$union, int32], [US0_US0_4(), 4] as [US0_$union, int32]], {
        Compare: compare,
    })))) {
        let v41: any;
        v1_1();
        v41 = undefined;
        const patternInput_1: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
        const v55: Mut0 = patternInput_1[0];
        const v82: string = method38(method10(v55, patternInput_1[1], patternInput_1[2], patternInput_1[3], patternInput_1[4], patternInput_1[5]), method36(), "async.run_with_timeout_async", v55.l0, method37(1000));
        let v84: any;
        v1_1();
        v84 = undefined;
        const patternInput_2: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
        method20(v82, patternInput_2[0], patternInput_2[1], patternInput_2[2], patternInput_2[3], patternInput_2[4], patternInput_2[5]);
    }
}

export function method39(): string {
    return ("\u001b[91m" + padLeft("Critical".toLocaleLowerCase(), 7, " ")) + method15();
}

export function method40(v0_1: int32, v1_1: string): string {
    const v3: Mut3 = new Mut3(method18());
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

export function closure30(v0_1: Error, unitVar: void): void {
    const v2_1 = (): void => {
        closure0(undefined, undefined);
    };
    let v3: any;
    v2_1();
    v3 = undefined;
    const patternInput: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
    const v35_1: US0_$union = patternInput[4].l0;
    if ((patternInput[2].l0 === false) ? false : (4 >= find<US0_$union, int32>(v35_1, ofSeq([[US0_US0_0(), 0] as [US0_$union, int32], [US0_US0_1(), 1] as [US0_$union, int32], [US0_US0_2(), 2] as [US0_$union, int32], [US0_US0_3(), 3] as [US0_$union, int32], [US0_US0_4(), 4] as [US0_$union, int32]], {
        Compare: compare,
    })))) {
        let v42: any;
        v2_1();
        v42 = undefined;
        const patternInput_1: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
        const v56: Mut0 = patternInput_1[0];
        const v105: string = method38(method10(v56, patternInput_1[1], patternInput_1[2], patternInput_1[3], patternInput_1[4], patternInput_1[5]), method39(), "async.run_with_timeout_async**", v56.l0, method40(1000, toText(interpolate("%A%P()", [v0_1]))));
        let v107: any;
        v2_1();
        v107 = undefined;
        const patternInput_2: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
        method20(v105, patternInput_2[0], patternInput_2[1], patternInput_2[2], patternInput_2[3], patternInput_2[4], patternInput_2[5]);
    }
}

export function method41(v0_1: int64, v1_1: string): string {
    const v3: Mut3 = new Mut3(method18());
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

export function closure31(v0_1: int64, v1_1: string, unitVar: void): void {
    const v3 = (): void => {
        closure0(undefined, undefined);
    };
    let v4: any;
    v3();
    v4 = undefined;
    const patternInput: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
    const v36: US0_$union = patternInput[4].l0;
    if ((patternInput[2].l0 === false) ? false : (1 >= find<US0_$union, int32>(v36, ofSeq([[US0_US0_0(), 0] as [US0_$union, int32], [US0_US0_1(), 1] as [US0_$union, int32], [US0_US0_2(), 2] as [US0_$union, int32], [US0_US0_3(), 3] as [US0_$union, int32], [US0_US0_4(), 4] as [US0_$union, int32]], {
        Compare: compare,
    })))) {
        let v43: any;
        v3();
        v43 = undefined;
        const patternInput_1: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
        const v57: Mut0 = patternInput_1[0];
        const v83: string = method38(method10(v57, patternInput_1[1], patternInput_1[2], patternInput_1[3], patternInput_1[4], patternInput_1[5]), method14(), "read_all_text_retry_async", v57.l0, method41(v0_1, v1_1));
        let v85: any;
        v3();
        v85 = undefined;
        const patternInput_2: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
        method20(v83, patternInput_2[0], patternInput_2[1], patternInput_2[2], patternInput_2[3], patternInput_2[4], patternInput_2[5]);
    }
}

export function method35(v0_1: string, v1_1: int64): any {
    return defaultOf();
}

export function closure26(unitVar: void, v0_1: string): any {
    return defaultOf();
}

export function closure33(unitVar: void, v0_1: any): US11_$union {
    return US11_US11_0(v0_1);
}

export function method44(): ((arg0: any) => US11_$union) {
    return (v: any): US11_$union => closure33(undefined, v);
}

export function method45(): string {
    return "hh:mm";
}

export function method46(): string {
    return "yyyyMMdd-HHmm-ssff-ffff-f";
}

export function method47(): string {
    return "hhmm";
}

export function method43(v0_1: string, v1_1: Date): string {
    const v324: string = toString(v1_1, method46());
    const v336: any = defaultOf();
    let v393: number;
    throw new Error(`date_time.get_utc_offset / target: ${US5_US5_3(US4_US4_0())}`);
    const v404: uint8 = (hours(v393) > 0) ? 1 : 0;
    const v405: string = method47();
    const v416 = `${v404}${toString_1(v393, "c", {})}`;
    const v418: string = v0_1;
    return parse(`${v324}${v416}${v418.slice(v324.length + v416.length, v418.length)}`);
}

export function method49(): string {
    throw new Error(`file_system.get_temp_path / target: ${US5_US5_3(US4_US4_0())}`);
}

export function method50(): string {
    return "!create_temp_path_";
}

export function method53(v0_1: string): string {
    return v0_1;
}

export function method52(v0_1: string, v1_1: string): [string, string] {
    return [v1_1, method53(v0_1)] as [string, string];
}

export function method51(v0_1: string, v1_1: string): string {
    const v48: IPathJoin = path;
    const patternInput: [string, string] = method52(v1_1, v0_1);
    return v48.join(patternInput[0], patternInput[1]);
}

export function method55(): string {
    return "CARGO_PKG_NAME";
}

export function method54(): string {
    throw new Error(`env.get_entry_assembly_name / target: ${US5_US5_3(US4_US4_0())}`);
}

export function method48(v0_1: string): string {
    return method51(method51(method51(method49(), method50()), method54()), v0_1);
}

export function method42(): string {
    const v22_1: Date = now();
    return method48(method43(newGuid(), v22_1));
}

export function closure32(unitVar: void, unitVar_1: void): string {
    return method42();
}

export function method57(v0_1: string): string {
    return v0_1;
}

export function closure35(unitVar: void, v0_1: any): any {
    return defaultOf();
}

export function method58(): ((arg0: any) => any) {
    return (v: any): any => closure35(undefined, v);
}

export function closure36(unitVar: void, unitVar_1: void): US12_$union {
    return US12_US12_0();
}

export function closure37(unitVar: void, v0_1: any): US12_$union {
    return US12_US12_1(v0_1);
}

export function method59(v0_1: string, v1_1: any): string {
    const v3: Mut3 = new Mut3(method18());
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
    let v97: any;
    closure6(v3, `${toText(interpolate("%A%P()", [v1_1]))}`, undefined);
    v97 = undefined;
    let v106: any;
    closure6(v3, `${" }"}`, undefined);
    v106 = undefined;
    return v3.l0;
}

export function method60(v0_1: string, v1_1: string, v2_1: int64, v3: string): string {
    return trimEnd(trimStart(`${v0_1} ${v1_1} #${v2_1} ${"file_system.create_dir"} / ${v3}`, ...[]), ...[" ", "/"]);
}

export function closure38(v0_1: string, v1_1: any, unitVar: void): void {
    const v3 = (): void => {
        closure0(undefined, undefined);
    };
    let v4: any;
    v3();
    v4 = undefined;
    const patternInput: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
    const v36: US0_$union = patternInput[4].l0;
    if ((patternInput[2].l0 === false) ? false : (4 >= find<US0_$union, int32>(v36, ofSeq([[US0_US0_0(), 0] as [US0_$union, int32], [US0_US0_1(), 1] as [US0_$union, int32], [US0_US0_2(), 2] as [US0_$union, int32], [US0_US0_3(), 3] as [US0_$union, int32], [US0_US0_4(), 4] as [US0_$union, int32]], {
        Compare: compare,
    })))) {
        let v43: any;
        v3();
        v43 = undefined;
        const patternInput_1: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
        const v57: Mut0 = patternInput_1[0];
        const v79: string = method60(method10(v57, patternInput_1[1], patternInput_1[2], patternInput_1[3], patternInput_1[4], patternInput_1[5]), method39(), v57.l0, method59(v0_1, v1_1));
        let v81: any;
        v3();
        v81 = undefined;
        const patternInput_2: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
        method20(v79, patternInput_2[0], patternInput_2[1], patternInput_2[2], patternInput_2[3], patternInput_2[4], patternInput_2[5]);
    }
}

export function method61(v0_1: string): string {
    const v2_1: Mut3 = new Mut3(method18());
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

export function closure39(v0_1: string, unitVar: void): void {
    const v2_1 = (): void => {
        closure0(undefined, undefined);
    };
    let v3: any;
    v2_1();
    v3 = undefined;
    const patternInput: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
    const v35_1: US0_$union = patternInput[4].l0;
    if ((patternInput[2].l0 === false) ? false : (0 >= find<US0_$union, int32>(v35_1, ofSeq([[US0_US0_0(), 0] as [US0_$union, int32], [US0_US0_1(), 1] as [US0_$union, int32], [US0_US0_2(), 2] as [US0_$union, int32], [US0_US0_3(), 3] as [US0_$union, int32], [US0_US0_4(), 4] as [US0_$union, int32]], {
        Compare: compare,
    })))) {
        let v42: any;
        v2_1();
        v42 = undefined;
        const patternInput_1: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
        const v56: Mut0 = patternInput_1[0];
        const v78: string = method60(method10(v56, patternInput_1[1], patternInput_1[2], patternInput_1[3], patternInput_1[4], patternInput_1[5]), method36(), v56.l0, method61(v0_1));
        let v80: any;
        v2_1();
        v80 = undefined;
        const patternInput_2: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
        method20(v78, patternInput_2[0], patternInput_2[1], patternInput_2[2], patternInput_2[3], patternInput_2[4], patternInput_2[5]);
    }
}

export function closure40(v0_1: string, unitVar: void): void {
    method7(true, v0_1);
}

export function method62(v0_1: string): (() => void) {
    return (): void => {
        closure40(v0_1, undefined);
    };
}

export function method63(v0_1: string): (() => void) {
    return (): void => {
        closure40(v0_1, undefined);
    };
}

export function method64(v0_1: string, v1_1: string): string {
    const v3: Mut3 = new Mut3(method18());
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

export function closure41(v0_1: string, v1_1: string, unitVar: void): void {
    const v3 = (): void => {
        closure0(undefined, undefined);
    };
    let v4: any;
    v3();
    v4 = undefined;
    const patternInput: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
    const v36: US0_$union = patternInput[4].l0;
    if ((patternInput[2].l0 === false) ? false : (1 >= find<US0_$union, int32>(v36, ofSeq([[US0_US0_0(), 0] as [US0_$union, int32], [US0_US0_1(), 1] as [US0_$union, int32], [US0_US0_2(), 2] as [US0_$union, int32], [US0_US0_3(), 3] as [US0_$union, int32], [US0_US0_4(), 4] as [US0_$union, int32]], {
        Compare: compare,
    })))) {
        let v43: any;
        v3();
        v43 = undefined;
        const patternInput_1: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
        const v57: Mut0 = patternInput_1[0];
        const v79: string = method60(method10(v57, patternInput_1[1], patternInput_1[2], patternInput_1[3], patternInput_1[4], patternInput_1[5]), method14(), v57.l0, method64(v0_1, v1_1));
        let v81: any;
        v3();
        v81 = undefined;
        const patternInput_2: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
        method20(v79, patternInput_2[0], patternInput_2[1], patternInput_2[2], patternInput_2[3], patternInput_2[4], patternInput_2[5]);
    }
}

export function closure42(v0_1: string, unitVar: void): void {
    const v11: any = defaultOf();
    const v34_1: any = defaultOf();
    defaultOf();
}

export function method65(v0_1: string): (() => void) {
    return (): void => {
        closure42(v0_1, undefined);
    };
}

export function method66(v0_1: string): (() => void) {
    return (): void => {
        closure42(v0_1, undefined);
    };
}

export function method56(v0_1: string): IDisposable {
    const v273: any = defaultOf();
    const v303: boolean = defaultOf();
    if (v303 === false) {
        let v337: any;
        closure41(v0_1, toText(interpolate("%A%P()", [{
            CreationTime: defaultOf(),
            Exists: v303,
        }])), undefined);
        v337 = undefined;
    }
    const v456: (() => void) = method66(v0_1);
    return {
        Dispose(): void {
            v456();
        },
    };
}

export function closure34(unitVar: void, unitVar_1: void): [string, IDisposable] {
    const v0_1: string = method42();
    return [v0_1, method56(v0_1)] as [string, IDisposable];
}

export function method67(v0_1: string): string {
    const v39: string = padLeft(v0_1, 32, "0");
    return parse(`${v39.slice(0, 7 + 1)}-${v39.slice(8, 11 + 1)}-${v39.slice(12, 15 + 1)}-${v39.slice(16, 19 + 1)}-${v39.slice(20, 31 + 1)}`);
}

export function closure43(unitVar: void, v0_1: string): [string, IDisposable] {
    const v2_1: string = method48(method67(v0_1));
    return [v2_1, method56(v2_1)] as [string, IDisposable];
}

export function closure44(unitVar: void, unitVar_1: void): string {
    return "C:\\home\\git\\polyglot\\lib\\spiral";
}

export function method69(v0_1: string): string {
    return v0_1;
}

export function method68(v0_1: string): string {
    let _arg: string;
    if (v0_1 === "") {
        return "";
    }
    else {
        const v30_1: string = defaultOf();
        return replace(`${(_arg = v30_1[0], _arg.toLocaleLowerCase())}${v30_1.slice(1, v30_1.length)}`, "\\", "/");
    }
}

export function closure45(unitVar: void, v0_1: string): string {
    return method68(v0_1);
}

export function closure46(unitVar: void, v0_1: string): string {
    return `file:///${trimStart(v0_1, ...["/"])}`;
}

export function method72(v0_1: string): Option<string> {
    const v45: IPathDirname = path;
    const v85: US1_$union = US1_US1_0(v45.dirname(v0_1));
    if (v85.tag === /* US1_0 */ 0) {
        return v85.fields[0];
    }
    else {
        return undefined;
    }
}

export function closure48(unitVar: void, v0_1: string): Option<string> {
    return method72(v0_1);
}

export function method71(): ((arg0: string) => Option<string>) {
    return (v: string): Option<string> => closure48(undefined, v);
}

export function method73(v0_1_mut: string, v1_1_mut: string, v2_1_mut: string): US13_$union {
    method73:
    while (true) {
        const v0_1: string = v0_1_mut, v1_1: string = v1_1_mut, v2_1: string = v2_1_mut;
        if (method9(method51(v2_1, v0_1))) {
            return US13_US13_0(v2_1);
        }
        else {
            const v7: Option<string> = method71()(v2_1);
            const v21_1: US1_$union = defaultArg(map<string, US1_$union>(method4(), v7), US1_US1_1());
            if (v21_1.tag === /* US1_0 */ 0) {
                v0_1_mut = v0_1;
                v1_1_mut = v1_1;
                v2_1_mut = v21_1.fields[0];
                continue method73;
            }
            else {
                return US13_US13_1(`No parent for ${"dir"} '${v0_1}' at '${v1_1}' (until '${v2_1}')`);
            }
        }
        break;
    }
}

export function method70(v0_1: string, v1_1: string): US13_$union {
    if (method9(method51(v1_1, v0_1))) {
        return US13_US13_0(v1_1);
    }
    else {
        const v6: Option<string> = method71()(v1_1);
        const v20_1: US1_$union = defaultArg(map<string, US1_$union>(method4(), v6), US1_US1_1());
        if (v20_1.tag === /* US1_0 */ 0) {
            return method73(v0_1, v1_1, v20_1.fields[0]);
        }
        else {
            return US13_US13_1(`No parent for ${"dir"} '${v0_1}' at '${v1_1}' (until '${v1_1}')`);
        }
    }
}

export function method74(v0_1: string): string {
    const v2_1: Mut3 = new Mut3(method18());
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

export function method75(v0_1: string, v1_1: string, v2_1: int64, v3: string): string {
    return trimEnd(trimStart(`${v0_1} ${v1_1} #${v2_1} ${"file_system.get_workspace_root"} / ${v3}`, ...[]), ...[" ", "/"]);
}

export function closure49(v0_1: string, unitVar: void): void {
    const v2_1 = (): void => {
        closure0(undefined, undefined);
    };
    let v3: any;
    v2_1();
    v3 = undefined;
    const patternInput: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
    const v35_1: US0_$union = patternInput[4].l0;
    if ((patternInput[2].l0 === false) ? false : (3 >= find<US0_$union, int32>(v35_1, ofSeq([[US0_US0_0(), 0] as [US0_$union, int32], [US0_US0_1(), 1] as [US0_$union, int32], [US0_US0_2(), 2] as [US0_$union, int32], [US0_US0_3(), 3] as [US0_$union, int32], [US0_US0_4(), 4] as [US0_$union, int32]], {
        Compare: compare,
    })))) {
        let v42: any;
        v2_1();
        v42 = undefined;
        const patternInput_1: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
        const v56: Mut0 = patternInput_1[0];
        const v78: string = method75(method10(v56, patternInput_1[1], patternInput_1[2], patternInput_1[3], patternInput_1[4], patternInput_1[5]), method29(), v56.l0, method74(v0_1));
        let v80: any;
        v2_1();
        v80 = undefined;
        const patternInput_2: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
        method20(v78, patternInput_2[0], patternInput_2[1], patternInput_2[2], patternInput_2[3], patternInput_2[4], patternInput_2[5]);
    }
}

export function method76(): string {
    return defaultOf();
}

export function closure47(unitVar: void, unitVar_1: void): string {
    const v4: US13_$union = method70(method51("polyglot", ".devcontainer"), "C:\\home\\git\\polyglot\\lib\\spiral");
    let v124: US1_$union;
    if (v4.tag === /* US13_0 */ 0) {
        v124 = US1_US1_0(v4.fields[0]);
    }
    else {
        let v10: any;
        closure49(v4.fields[0], undefined);
        v10 = undefined;
        v124 = US1_US1_1();
    }
    let v251: US1_$union;
    if (v124.tag === /* US1_0 */ 0) {
        v251 = US1_US1_0(v124.fields[0]);
    }
    else {
        const v127: string = method76();
        const v129: US13_$union = method70(method51("polyglot", ".devcontainer"), v127);
        if (v129.tag === /* US13_0 */ 0) {
            v251 = US1_US1_0(v129.fields[0]);
        }
        else {
            let v135: any;
            closure49(v129.fields[0], undefined);
            v135 = undefined;
            v251 = US1_US1_1();
        }
    }
    return method51((v251.tag === /* US1_0 */ 0) ? v251.fields[0] : (() => {
        throw new Error("Option does not have a value.");
    })(), "polyglot");
}

export function method77(v0_1: string): void {
}

export function closure51(unitVar: void, v0_1: string): void {
    method77(v0_1);
}

export function closure50(unitVar: void, v0_1: boolean): void {
    let v3: any;
    closure0(undefined, undefined);
    v3 = undefined;
    const patternInput: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
    const v37: ((arg0: string) => void) = v0_1 ? ((v: string): void => {
        closure51(undefined, v);
    }) : ((v_1: string): void => {
        closure2(undefined, v_1);
    });
    patternInput[1].l0 = v37;
}

export function method79(v0_1: string): string {
    return defaultOf();
}

export function method78(v0_1: string, v1_1: string): void {
    let v17_1: FSharpResult$2_$union<any, any>;
    if (method9(v0_1) === false) {
        const v4: IDisposable = method56(v0_1);
    }
    const v5: string = method79(v1_1);
    if (method9(v5) === false) {
        const v8: IDisposable = method56(v5);
    }
    if (method9(v1_1) && ((v17_1 = defaultOf(), true))) {
        method7(true, v1_1);
    }
    if (method9(v1_1) === false) {
    }
}

export function closure53(v0_1: string, v1_1: string): void {
    method78(v0_1, v1_1);
}

export function closure52(unitVar: void, v0_1: string): ((arg0: string) => void) {
    return (v: string): void => {
        closure53(v0_1, v);
    };
}

export function closure55(v0_1: string, v1_1: string): string {
    return method51(v0_1, v1_1);
}

export function closure54(unitVar: void, v0_1: string): ((arg0: string) => string) {
    return (v: string): string => closure55(v0_1, v);
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

export const v31 = (v: string): string => closure46(undefined, v);

export function new_file_uri(x: string): string {
    return v31(x);
}

export const v32 = (): string => closure47(undefined, undefined);

export function get_workspace_root(): string {
    return v32();
}

export const v33 = (v: boolean): void => {
    closure50(undefined, v);
};

export function init_trace_file(x: boolean): void {
    v33(x);
}

export const v34 = (v: string): ((arg0: string) => void) => closure52(undefined, v);

export function link_directory(x: string): ((arg0: string) => void) {
    return v34(x);
}

export const v35 = (v: string): ((arg0: string) => string) => closure54(undefined, v);

export function op_LessDivideGreater(x: string): ((arg0: string) => string) {
    return v35(x);
}


