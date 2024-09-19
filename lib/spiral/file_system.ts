import { defaultOf, compare, IComparable, IEquatable, IDisposable, createAtom } from "../../../deps/Fable/src/fable-library-ts/Util.js";
import { defaultArg, value as value_3, Option } from "../../../deps/Fable/src/fable-library-ts/Option.js";
import { op_Subtraction, op_Addition, toInt64, int64 } from "../../../deps/Fable/src/fable-library-ts/BigInt.js";
import { bool_type, lambda_type, unit_type, string_type, record_type, int64_type, union_type, class_type, TypeInfo } from "../../../deps/Fable/src/fable-library-ts/Reflection.js";
import { FSharpRef, Record, Union } from "../../../deps/Fable/src/fable-library-ts/Types.js";
import { create, toString, now, getTicks } from "../../../deps/Fable/src/fable-library-ts/Date.js";
import * as fs from "fs";
import { ofSeq, find } from "../../../deps/Fable/src/fable-library-ts/Map.js";
import { uint8, int32 } from "../../../deps/Fable/src/fable-library-ts/Int32.js";
import { toString as toString_1, milliseconds, seconds, minutes, hours, fromTicks } from "../../../deps/Fable/src/fable-library-ts/TimeSpan.js";
import { replace, interpolate, toText, trimStart, trimEnd, padLeft } from "../../../deps/Fable/src/fable-library-ts/String.js";
import { newGuid, parse } from "../../../deps/Fable/src/fable-library-ts/Guid.js";
import * as path from "path";
import { FSharpResult$2_$union, FSharpResult$2 } from "../../../deps/Fable/src/fable-library-ts/Result.js";

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

export function closure1(v0_1: FSharpRef<Option<US1_$union>>, v1_1: Option<US1_$union>): FSharpRef<Option<US1_$union>> {
    v0_1.contents = v1_1;
    return v0_1;
}

export function closure2(v0_1: Option<string>, v1_1: ((arg0: Option<US1_$union>) => FSharpRef<Option<US1_$union>>), unitVar: void): void {
    let x: string;
    v1_1((v0_1 == null) ? undefined : ((x = value_3(v0_1), ((): US1_$union => US1_US1_0(x))())));
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

export function method7(v0_1: string): string {
    return v0_1;
}

export function method8(v0_1: string): boolean {
    const v23_1: IFsExistsSync = fs;
    return v23_1.existsSync(v0_1);
}

export function method6(v0_1: boolean, v1_1: string): void {
}

export function closure6(v0_1: Mut0, unitVar: void): void {
    const v2_1: int64 = toInt64(op_Addition(v0_1.l0, 1n));
    v0_1.l0 = v2_1;
}

export function closure7(v0_1: FSharpRef<Option<US3_$union>>, v1_1: Option<US3_$union>): FSharpRef<Option<US3_$union>> {
    v0_1.contents = v1_1;
    return v0_1;
}

export function closure8(v0_1: Option<int64>, v1_1: ((arg0: Option<US3_$union>) => FSharpRef<Option<US3_$union>>), unitVar: void): void {
    let x: int64;
    v1_1((v0_1 == null) ? undefined : ((x = value_3(v0_1), ((): US3_$union => US3_US3_0(x))())));
}

export function method9(): string {
    return "hh:mm:ss";
}

export function method10(): string {
    return "HH:mm:ss";
}

export function method11(): string {
    return "\u001b[0m";
}

export function method12(v0_1: string): string {
    throw new Error(`file_system.get_file_name / target: ${US5_US5_3(US4_US4_0())} / path: ${v0_1}`);
}

export function method13(): string {
    return "";
}

export function closure9(v0_1: Mut3, v1_1: string, unitVar: void): void {
    const v3: string = v0_1.l0 + v1_1;
    v0_1.l0 = v3;
}

export function closure11(v0_1: string, unitVar: void): void {
    console.log(v0_1);
}

export function closure10(unitVar: void, v0_1: string): void {
    let v3: any;
    closure11(v0_1, undefined);
    v3 = undefined;
}

export function closure5(v0_1: string, v1_1: string, unitVar: void): void {
    let v316: int64, v326: number;
    const v3 = (): void => {
        closure0(undefined, undefined);
    };
    let v4: any;
    v3();
    v4 = undefined;
    const patternInput: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
    let v37: any;
    v3();
    v37 = undefined;
    const patternInput_1: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
    const v69: US0_$union = patternInput_1[4].l0;
    if ((patternInput_1[2].l0 === false) ? false : (1 >= find<US0_$union, int32>(v69, ofSeq([[US0_US0_0(), 0] as [US0_$union, int32], [US0_US0_1(), 1] as [US0_$union, int32], [US0_US0_2(), 2] as [US0_$union, int32], [US0_US0_3(), 3] as [US0_$union, int32], [US0_US0_4(), 4] as [US0_$union, int32]], {
        Compare: compare,
    })))) {
        let v77: any;
        closure6(patternInput[0], undefined);
        v77 = undefined;
        let v81: any;
        v3();
        v81 = undefined;
        const patternInput_2: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
        const _v292: FSharpRef<Option<US3_$union>> = new FSharpRef<Option<US3_$union>>(undefined);
        let v297: any;
        closure8(patternInput_2[5], (v: Option<US3_$union>): FSharpRef<Option<US3_$union>> => closure7(_v292, v), undefined);
        v297 = undefined;
        const v312: US3_$union = defaultArg(_v292.contents, US3_US3_1());
        const v357: string = toString((v312.tag === /* US3_0 */ 0) ? ((v316 = v312.fields[0], (v326 = fromTicks(toInt64(op_Subtraction(getTicks(now()), v316))), create(1, 1, 1, hours(v326), minutes(v326), seconds(v326), milliseconds(v326))))) : now(), method10());
        const v622: string = ("\u001b[94m" + padLeft("Debug".toLocaleLowerCase(), 7, " ")) + method11();
        const v637: int64 = patternInput_2[0].l0;
        const v638: string = method12(v0_1);
        const v640: Mut3 = new Mut3(method13());
        let v647: any;
        closure9(v640, `${"{ "}`, undefined);
        v647 = undefined;
        let v656: any;
        closure9(v640, `${"ex"}`, undefined);
        v656 = undefined;
        let v665: any;
        closure9(v640, `${" = "}`, undefined);
        v665 = undefined;
        let v673: any;
        closure9(v640, `${v1_1}`, undefined);
        v673 = undefined;
        let v682: any;
        closure9(v640, `${"; "}`, undefined);
        v682 = undefined;
        let v691: any;
        closure9(v640, `${"path"}`, undefined);
        v691 = undefined;
        let v699: any;
        closure9(v640, `${" = "}`, undefined);
        v699 = undefined;
        let v707: any;
        closure9(v640, `${v638}`, undefined);
        v707 = undefined;
        let v716: any;
        closure9(v640, `${" }"}`, undefined);
        v716 = undefined;
        const v758: string = trimEnd(trimStart(`${v357} ${v622} #${v637} ${"file_system.delete_directory_async"} / ${v640.l0}`, ...[]), ...[" ", "/"]);
        closure10(undefined, v758);
        patternInput[1].l0(v758);
    }
}

export function method5(v0_1: string, v1_1: int64): any {
    return defaultOf();
}

export function closure4(unitVar: void, v0_1: string): any {
    return defaultOf();
}

export function closure14(v0_1: string, v1_1: int64, v2_1: string, unitVar: void): void {
    let v317: int64, v327: number;
    const v4 = (): void => {
        closure0(undefined, undefined);
    };
    let v5: any;
    v4();
    v5 = undefined;
    const patternInput: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
    let v38: any;
    v4();
    v38 = undefined;
    const patternInput_1: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
    const v70: US0_$union = patternInput_1[4].l0;
    if ((patternInput_1[2].l0 === false) ? false : (1 >= find<US0_$union, int32>(v70, ofSeq([[US0_US0_0(), 0] as [US0_$union, int32], [US0_US0_1(), 1] as [US0_$union, int32], [US0_US0_2(), 2] as [US0_$union, int32], [US0_US0_3(), 3] as [US0_$union, int32], [US0_US0_4(), 4] as [US0_$union, int32]], {
        Compare: compare,
    })))) {
        let v78: any;
        closure6(patternInput[0], undefined);
        v78 = undefined;
        let v82: any;
        v4();
        v82 = undefined;
        const patternInput_2: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
        const _v293: FSharpRef<Option<US3_$union>> = new FSharpRef<Option<US3_$union>>(undefined);
        let v298: any;
        closure8(patternInput_2[5], (v: Option<US3_$union>): FSharpRef<Option<US3_$union>> => closure7(_v293, v), undefined);
        v298 = undefined;
        const v313: US3_$union = defaultArg(_v293.contents, US3_US3_1());
        const v358: string = toString((v313.tag === /* US3_0 */ 0) ? ((v317 = v313.fields[0], (v327 = fromTicks(toInt64(op_Subtraction(getTicks(now()), v317))), create(1, 1, 1, hours(v327), minutes(v327), seconds(v327), milliseconds(v327))))) : now(), method10());
        const v623: string = ("\u001b[94m" + padLeft("Debug".toLocaleLowerCase(), 7, " ")) + method11();
        const v638: int64 = patternInput_2[0].l0;
        const v639: string = method12(v0_1);
        const v641: Mut3 = new Mut3(method13());
        let v648: any;
        closure9(v641, `${"{ "}`, undefined);
        v648 = undefined;
        let v657: any;
        closure9(v641, `${"path"}`, undefined);
        v657 = undefined;
        let v666: any;
        closure9(v641, `${" = "}`, undefined);
        v666 = undefined;
        let v674: any;
        closure9(v641, `${v639}`, undefined);
        v674 = undefined;
        let v683: any;
        closure9(v641, `${"; "}`, undefined);
        v683 = undefined;
        let v692: any;
        closure9(v641, `${"retry"}`, undefined);
        v692 = undefined;
        let v700: any;
        closure9(v641, `${" = "}`, undefined);
        v700 = undefined;
        let v708: any;
        closure9(v641, `${v1_1}`, undefined);
        v708 = undefined;
        let v716: any;
        closure9(v641, `${"; "}`, undefined);
        v716 = undefined;
        let v725: any;
        closure9(v641, `${"ex"}`, undefined);
        v725 = undefined;
        let v733: any;
        closure9(v641, `${" = "}`, undefined);
        v733 = undefined;
        let v741: any;
        closure9(v641, `${v2_1}`, undefined);
        v741 = undefined;
        let v750: any;
        closure9(v641, `${" }"}`, undefined);
        v750 = undefined;
        const v792: string = trimEnd(trimStart(`${v358} ${v623} #${v638} ${"file_system.wait_for_file_access"} / ${v641.l0}`, ...[]), ...[" ", "/"]);
        closure10(undefined, v792);
        patternInput[1].l0(v792);
    }
}

export function method14(v0_1: string, v1_1: US8_$union, v2_1: US7_$union, v3: int64): any {
    return defaultOf();
}

export function closure13(v0_1: US6_$union, v1_1: string): any {
    return defaultOf();
}

export function closure12(unitVar: void, v0_1: US6_$union): ((arg0: string) => any) {
    return (v: string): any => closure13(v0_1, v);
}

export function method15(v0_1: string, v1_1: int64): any {
    return defaultOf();
}

export function closure15(unitVar: void, v0_1: string): any {
    return defaultOf();
}

export function closure16(unitVar: void, v0_1: string): any {
    return defaultOf();
}

export function method17(v0_1: string): boolean {
    const v20_1: IFsExistsSync = fs;
    return v20_1.existsSync(v0_1);
}

export function method18(v0_1: any): any {
    return v0_1;
}

export function method16(v0_1: string, v1_1: string): boolean {
    return defaultOf();
}

export function closure18(v0_1: string, v1_1: string): boolean {
    return method16(v0_1, v1_1);
}

export function closure17(unitVar: void, v0_1: string): ((arg0: string) => boolean) {
    return (v: string): boolean => closure18(v0_1, v);
}

export function closure20(v0_1: string, v1_1: string): any {
    return defaultOf();
}

export function closure19(unitVar: void, v0_1: string): ((arg0: string) => any) {
    return (v: string): any => closure20(v0_1, v);
}

export function closure22(v0_1: string, v1_1: string): any {
    return defaultOf();
}

export function closure21(unitVar: void, v0_1: string): ((arg0: string) => any) {
    return (v: string): any => closure22(v0_1, v);
}

export function closure24(v0_1: string, v1_1: Error, unitVar: void): void {
    let v316: int64, v326: number;
    const v3 = (): void => {
        closure0(undefined, undefined);
    };
    let v4: any;
    v3();
    v4 = undefined;
    const patternInput: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
    let v37: any;
    v3();
    v37 = undefined;
    const patternInput_1: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
    const v69: US0_$union = patternInput_1[4].l0;
    if ((patternInput_1[2].l0 === false) ? false : (3 >= find<US0_$union, int32>(v69, ofSeq([[US0_US0_0(), 0] as [US0_$union, int32], [US0_US0_1(), 1] as [US0_$union, int32], [US0_US0_2(), 2] as [US0_$union, int32], [US0_US0_3(), 3] as [US0_$union, int32], [US0_US0_4(), 4] as [US0_$union, int32]], {
        Compare: compare,
    })))) {
        let v77: any;
        closure6(patternInput[0], undefined);
        v77 = undefined;
        let v81: any;
        v3();
        v81 = undefined;
        const patternInput_2: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
        const _v292: FSharpRef<Option<US3_$union>> = new FSharpRef<Option<US3_$union>>(undefined);
        let v297: any;
        closure8(patternInput_2[5], (v: Option<US3_$union>): FSharpRef<Option<US3_$union>> => closure7(_v292, v), undefined);
        v297 = undefined;
        const v312: US3_$union = defaultArg(_v292.contents, US3_US3_1());
        const v357: string = toString((v312.tag === /* US3_0 */ 0) ? ((v316 = v312.fields[0], (v326 = fromTicks(toInt64(op_Subtraction(getTicks(now()), v316))), create(1, 1, 1, hours(v326), minutes(v326), seconds(v326), milliseconds(v326))))) : now(), method10());
        const v622: string = ("\u001b[93m" + padLeft("Warning".toLocaleLowerCase(), 7, " ")) + method11();
        const v637: int64 = patternInput_2[0].l0;
        const v638: string = method12(v0_1);
        const v649: string = toText(interpolate("%A%P()", [v1_1]));
        const v662: Mut3 = new Mut3(method13());
        let v669: any;
        closure9(v662, `${"{ "}`, undefined);
        v669 = undefined;
        let v678: any;
        closure9(v662, `${"path"}`, undefined);
        v678 = undefined;
        let v687: any;
        closure9(v662, `${" = "}`, undefined);
        v687 = undefined;
        let v695: any;
        closure9(v662, `${v638}`, undefined);
        v695 = undefined;
        let v704: any;
        closure9(v662, `${"; "}`, undefined);
        v704 = undefined;
        let v713: any;
        closure9(v662, `${"ex"}`, undefined);
        v713 = undefined;
        let v721: any;
        closure9(v662, `${" = "}`, undefined);
        v721 = undefined;
        let v729: any;
        closure9(v662, `${v649}`, undefined);
        v729 = undefined;
        let v738: any;
        closure9(v662, `${" }"}`, undefined);
        v738 = undefined;
        const v780: string = trimEnd(trimStart(`${v357} ${v622} #${v637} ${"delete_file_async"} / ${v662.l0}`, ...[]), ...[" ", "/"]);
        closure10(undefined, v780);
        patternInput[1].l0(v780);
    }
}

export function method19(v0_1: string, v1_1: int64): any {
    return defaultOf();
}

export function closure23(unitVar: void, v0_1: string): any {
    return defaultOf();
}

export function closure27(v0_1: string, v1_1: string, v2_1: Error, unitVar: void): void {
    let v317: int64, v327: number;
    const v4 = (): void => {
        closure0(undefined, undefined);
    };
    let v5: any;
    v4();
    v5 = undefined;
    const patternInput: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
    let v38: any;
    v4();
    v38 = undefined;
    const patternInput_1: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
    const v70: US0_$union = patternInput_1[4].l0;
    if ((patternInput_1[2].l0 === false) ? false : (3 >= find<US0_$union, int32>(v70, ofSeq([[US0_US0_0(), 0] as [US0_$union, int32], [US0_US0_1(), 1] as [US0_$union, int32], [US0_US0_2(), 2] as [US0_$union, int32], [US0_US0_3(), 3] as [US0_$union, int32], [US0_US0_4(), 4] as [US0_$union, int32]], {
        Compare: compare,
    })))) {
        let v78: any;
        closure6(patternInput[0], undefined);
        v78 = undefined;
        let v82: any;
        v4();
        v82 = undefined;
        const patternInput_2: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
        const _v293: FSharpRef<Option<US3_$union>> = new FSharpRef<Option<US3_$union>>(undefined);
        let v298: any;
        closure8(patternInput_2[5], (v: Option<US3_$union>): FSharpRef<Option<US3_$union>> => closure7(_v293, v), undefined);
        v298 = undefined;
        const v313: US3_$union = defaultArg(_v293.contents, US3_US3_1());
        const v358: string = toString((v313.tag === /* US3_0 */ 0) ? ((v317 = v313.fields[0], (v327 = fromTicks(toInt64(op_Subtraction(getTicks(now()), v317))), create(1, 1, 1, hours(v327), minutes(v327), seconds(v327), milliseconds(v327))))) : now(), method10());
        const v623: string = ("\u001b[93m" + padLeft("Warning".toLocaleLowerCase(), 7, " ")) + method11();
        const v638: int64 = patternInput_2[0].l0;
        const v639: string = method12(v1_1);
        const v640: string = method12(v0_1);
        const v642: Mut3 = new Mut3(method13());
        let v649: any;
        closure9(v642, `${"{ "}`, undefined);
        v649 = undefined;
        let v658: any;
        closure9(v642, `${"old_path"}`, undefined);
        v658 = undefined;
        let v667: any;
        closure9(v642, `${" = "}`, undefined);
        v667 = undefined;
        let v675: any;
        closure9(v642, `${v639}`, undefined);
        v675 = undefined;
        let v684: any;
        closure9(v642, `${"; "}`, undefined);
        v684 = undefined;
        let v693: any;
        closure9(v642, `${"new_path"}`, undefined);
        v693 = undefined;
        let v701: any;
        closure9(v642, `${" = "}`, undefined);
        v701 = undefined;
        let v709: any;
        closure9(v642, `${v640}`, undefined);
        v709 = undefined;
        let v717: any;
        closure9(v642, `${"; "}`, undefined);
        v717 = undefined;
        let v726: any;
        closure9(v642, `${"ex"}`, undefined);
        v726 = undefined;
        let v734: any;
        closure9(v642, `${" = "}`, undefined);
        v734 = undefined;
        let v769: any;
        closure9(v642, `${toText(interpolate("%A%P()", [v2_1]))}`, undefined);
        v769 = undefined;
        let v778: any;
        closure9(v642, `${" }"}`, undefined);
        v778 = undefined;
        const v820: string = trimEnd(trimStart(`${v358} ${v623} #${v638} ${"move_file_async"} / ${v642.l0}`, ...[]), ...[" ", "/"]);
        closure10(undefined, v820);
        patternInput[1].l0(v820);
    }
}

export function method20(v0_1: string, v1_1: string, v2_1: int64): any {
    return defaultOf();
}

export function closure26(v0_1: string, v1_1: string): any {
    return defaultOf();
}

export function closure25(unitVar: void, v0_1: string): ((arg0: string) => any) {
    return (v: string): any => closure26(v0_1, v);
}

export function closure29(unitVar: void, v0_1: int64): US9_$union {
    return US9_US9_0(v0_1);
}

export function closure30(unitVar: void, v0_1: Error): US9_$union {
    return US9_US9_1(v0_1);
}

export function closure31(unitVar: void, unitVar_1: void): void {
    let v314: int64, v324: number;
    const v1_1 = (): void => {
        closure0(undefined, undefined);
    };
    let v2_1: any;
    v1_1();
    v2_1 = undefined;
    const patternInput: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
    let v35_1: any;
    v1_1();
    v35_1 = undefined;
    const patternInput_1: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
    const v67: US0_$union = patternInput_1[4].l0;
    if ((patternInput_1[2].l0 === false) ? false : (0 >= find<US0_$union, int32>(v67, ofSeq([[US0_US0_0(), 0] as [US0_$union, int32], [US0_US0_1(), 1] as [US0_$union, int32], [US0_US0_2(), 2] as [US0_$union, int32], [US0_US0_3(), 3] as [US0_$union, int32], [US0_US0_4(), 4] as [US0_$union, int32]], {
        Compare: compare,
    })))) {
        let v75: any;
        closure6(patternInput[0], undefined);
        v75 = undefined;
        let v79: any;
        v1_1();
        v79 = undefined;
        const patternInput_2: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
        const _v290: FSharpRef<Option<US3_$union>> = new FSharpRef<Option<US3_$union>>(undefined);
        let v295: any;
        closure8(patternInput_2[5], (v: Option<US3_$union>): FSharpRef<Option<US3_$union>> => closure7(_v290, v), undefined);
        v295 = undefined;
        const v310: US3_$union = defaultArg(_v290.contents, US3_US3_1());
        const v355: string = toString((v310.tag === /* US3_0 */ 0) ? ((v314 = v310.fields[0], (v324 = fromTicks(toInt64(op_Subtraction(getTicks(now()), v314))), create(1, 1, 1, hours(v324), minutes(v324), seconds(v324), milliseconds(v324))))) : now(), method10());
        const v620: string = ("\u001b[90m" + padLeft("Verbose".toLocaleLowerCase(), 7, " ")) + method11();
        const v635: int64 = patternInput_2[0].l0;
        const v637: Mut3 = new Mut3(method13());
        let v644: any;
        closure9(v637, `${"{ "}`, undefined);
        v644 = undefined;
        let v653: any;
        closure9(v637, `${"timeout"}`, undefined);
        v653 = undefined;
        let v662: any;
        closure9(v637, `${" = "}`, undefined);
        v662 = undefined;
        let v670: any;
        closure9(v637, `${1000}`, undefined);
        v670 = undefined;
        let v679: any;
        closure9(v637, `${" }"}`, undefined);
        v679 = undefined;
        const v741: string = trimEnd(trimStart(`${v355} ${v620} #${v635} ${"async.run_with_timeout_async"} / ${v637.l0}`, ...[]), ...[" ", "/"]);
        closure10(undefined, v741);
        patternInput[1].l0(v741);
    }
}

export function closure32(v0_1: Error, unitVar: void): void {
    let v315: int64, v325: number;
    const v2_1 = (): void => {
        closure0(undefined, undefined);
    };
    let v3: any;
    v2_1();
    v3 = undefined;
    const patternInput: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
    let v36: any;
    v2_1();
    v36 = undefined;
    const patternInput_1: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
    const v68: US0_$union = patternInput_1[4].l0;
    if ((patternInput_1[2].l0 === false) ? false : (4 >= find<US0_$union, int32>(v68, ofSeq([[US0_US0_0(), 0] as [US0_$union, int32], [US0_US0_1(), 1] as [US0_$union, int32], [US0_US0_2(), 2] as [US0_$union, int32], [US0_US0_3(), 3] as [US0_$union, int32], [US0_US0_4(), 4] as [US0_$union, int32]], {
        Compare: compare,
    })))) {
        let v76: any;
        closure6(patternInput[0], undefined);
        v76 = undefined;
        let v80: any;
        v2_1();
        v80 = undefined;
        const patternInput_2: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
        const _v291: FSharpRef<Option<US3_$union>> = new FSharpRef<Option<US3_$union>>(undefined);
        let v296: any;
        closure8(patternInput_2[5], (v: Option<US3_$union>): FSharpRef<Option<US3_$union>> => closure7(_v291, v), undefined);
        v296 = undefined;
        const v311: US3_$union = defaultArg(_v291.contents, US3_US3_1());
        const v356: string = toString((v311.tag === /* US3_0 */ 0) ? ((v315 = v311.fields[0], (v325 = fromTicks(toInt64(op_Subtraction(getTicks(now()), v315))), create(1, 1, 1, hours(v325), minutes(v325), seconds(v325), milliseconds(v325))))) : now(), method10());
        const v621: string = ("\u001b[91m" + padLeft("Critical".toLocaleLowerCase(), 7, " ")) + method11();
        const v636: int64 = patternInput_2[0].l0;
        const v647: string = toText(interpolate("%A%P()", [v0_1]));
        const v660: Mut3 = new Mut3(method13());
        let v667: any;
        closure9(v660, `${"{ "}`, undefined);
        v667 = undefined;
        let v676: any;
        closure9(v660, `${"timeout"}`, undefined);
        v676 = undefined;
        let v685: any;
        closure9(v660, `${" = "}`, undefined);
        v685 = undefined;
        let v693: any;
        closure9(v660, `${1000}`, undefined);
        v693 = undefined;
        let v702: any;
        closure9(v660, `${"; "}`, undefined);
        v702 = undefined;
        let v711: any;
        closure9(v660, `${"ex"}`, undefined);
        v711 = undefined;
        let v719: any;
        closure9(v660, `${" = "}`, undefined);
        v719 = undefined;
        let v727: any;
        closure9(v660, `${v647}`, undefined);
        v727 = undefined;
        let v736: any;
        closure9(v660, `${" }"}`, undefined);
        v736 = undefined;
        const v798: string = trimEnd(trimStart(`${v356} ${v621} #${v636} ${"async.run_with_timeout_async**"} / ${v660.l0}`, ...[]), ...[" ", "/"]);
        closure10(undefined, v798);
        patternInput[1].l0(v798);
    }
}

export function closure33(v0_1: int64, v1_1: string, unitVar: void): void {
    let v316: int64, v326: number;
    const v3 = (): void => {
        closure0(undefined, undefined);
    };
    let v4: any;
    v3();
    v4 = undefined;
    const patternInput: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
    let v37: any;
    v3();
    v37 = undefined;
    const patternInput_1: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
    const v69: US0_$union = patternInput_1[4].l0;
    if ((patternInput_1[2].l0 === false) ? false : (1 >= find<US0_$union, int32>(v69, ofSeq([[US0_US0_0(), 0] as [US0_$union, int32], [US0_US0_1(), 1] as [US0_$union, int32], [US0_US0_2(), 2] as [US0_$union, int32], [US0_US0_3(), 3] as [US0_$union, int32], [US0_US0_4(), 4] as [US0_$union, int32]], {
        Compare: compare,
    })))) {
        let v77: any;
        closure6(patternInput[0], undefined);
        v77 = undefined;
        let v81: any;
        v3();
        v81 = undefined;
        const patternInput_2: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
        const _v292: FSharpRef<Option<US3_$union>> = new FSharpRef<Option<US3_$union>>(undefined);
        let v297: any;
        closure8(patternInput_2[5], (v: Option<US3_$union>): FSharpRef<Option<US3_$union>> => closure7(_v292, v), undefined);
        v297 = undefined;
        const v312: US3_$union = defaultArg(_v292.contents, US3_US3_1());
        const v357: string = toString((v312.tag === /* US3_0 */ 0) ? ((v316 = v312.fields[0], (v326 = fromTicks(toInt64(op_Subtraction(getTicks(now()), v316))), create(1, 1, 1, hours(v326), minutes(v326), seconds(v326), milliseconds(v326))))) : now(), method10());
        const v622: string = ("\u001b[94m" + padLeft("Debug".toLocaleLowerCase(), 7, " ")) + method11();
        const v637: int64 = patternInput_2[0].l0;
        const v639: Mut3 = new Mut3(method13());
        let v646: any;
        closure9(v639, `${"{ "}`, undefined);
        v646 = undefined;
        let v655: any;
        closure9(v639, `${"retry"}`, undefined);
        v655 = undefined;
        let v664: any;
        closure9(v639, `${" = "}`, undefined);
        v664 = undefined;
        let v672: any;
        closure9(v639, `${v0_1}`, undefined);
        v672 = undefined;
        let v681: any;
        closure9(v639, `${"; "}`, undefined);
        v681 = undefined;
        let v690: any;
        closure9(v639, `${"ex"}`, undefined);
        v690 = undefined;
        let v698: any;
        closure9(v639, `${" = "}`, undefined);
        v698 = undefined;
        let v706: any;
        closure9(v639, `${v1_1}`, undefined);
        v706 = undefined;
        let v715: any;
        closure9(v639, `${" }"}`, undefined);
        v715 = undefined;
        const v777: string = trimEnd(trimStart(`${v357} ${v622} #${v637} ${"read_all_text_retry_async"} / ${v639.l0}`, ...[]), ...[" ", "/"]);
        closure10(undefined, v777);
        patternInput[1].l0(v777);
    }
}

export function method21(v0_1: string, v1_1: int64): any {
    return defaultOf();
}

export function closure28(unitVar: void, v0_1: string): any {
    return defaultOf();
}

export function closure35(v0_1: FSharpRef<Option<US11_$union>>, v1_1: Option<US11_$union>): FSharpRef<Option<US11_$union>> {
    v0_1.contents = v1_1;
    return v0_1;
}

export function closure36(v0_1: Option<any>, v1_1: ((arg0: Option<US11_$union>) => FSharpRef<Option<US11_$union>>), unitVar: void): void {
    let x: any;
    v1_1((v0_1 == null) ? undefined : ((x = value_3(v0_1), ((): US11_$union => US11_US11_0(x))())));
}

export function method24(): string {
    return "hh:mm";
}

export function method25(): string {
    return "yyyyMMdd-HHmm-ssff-ffff-f";
}

export function method26(): string {
    return "hhmm";
}

export function method23(v0_1: string, v1_1: Date): string {
    const v338: string = toString(v1_1, method25());
    const v350: any = defaultOf();
    let v407: number;
    throw new Error(`date_time.get_utc_offset / target: ${US5_US5_3(US4_US4_0())}`);
    const v418: uint8 = (hours(v407) > 0) ? 1 : 0;
    const v419: string = method26();
    const v430 = `${v418}${toString_1(v407, "c", {})}`;
    const v432: string = v0_1;
    return parse(`${v338}${v430}${v432.slice(v338.length + v430.length, v432.length)}`);
}

export function method28(): string {
    throw new Error(`file_system.get_temp_path / target: ${US5_US5_3(US4_US4_0())}`);
}

export function method29(): string {
    return "!create_temp_path_";
}

export function method32(v0_1: string): string {
    return v0_1;
}

export function method31(v0_1: string, v1_1: string): [string, string] {
    return [v1_1, method32(v0_1)] as [string, string];
}

export function method30(v0_1: string, v1_1: string): string {
    const v48: IPathJoin = path;
    const patternInput: [string, string] = method31(v1_1, v0_1);
    return v48.join(patternInput[0], patternInput[1]);
}

export function method34(): string {
    return "CARGO_PKG_NAME";
}

export function method33(): string {
    throw new Error(`env.get_entry_assembly_name / target: ${US5_US5_3(US4_US4_0())}`);
}

export function method27(v0_1: string): string {
    return method30(method30(method30(method28(), method29()), method33()), v0_1);
}

export function method22(): string {
    const v22_1: Date = now();
    return method27(method23(newGuid(), v22_1));
}

export function closure34(unitVar: void, unitVar_1: void): string {
    return method22();
}

export function method36(v0_1: string): string {
    return v0_1;
}

export function closure38(unitVar: void, v0_1: any): any {
    return defaultOf();
}

export function method37(): ((arg0: any) => any) {
    return (v: any): any => closure38(undefined, v);
}

export function closure39(unitVar: void, unitVar_1: void): US12_$union {
    return US12_US12_0();
}

export function closure40(unitVar: void, v0_1: any): US12_$union {
    return US12_US12_1(v0_1);
}

export function closure41(v0_1: string, v1_1: any, unitVar: void): void {
    let v316: int64, v326: number;
    const v3 = (): void => {
        closure0(undefined, undefined);
    };
    let v4: any;
    v3();
    v4 = undefined;
    const patternInput: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
    let v37: any;
    v3();
    v37 = undefined;
    const patternInput_1: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
    const v69: US0_$union = patternInput_1[4].l0;
    if ((patternInput_1[2].l0 === false) ? false : (4 >= find<US0_$union, int32>(v69, ofSeq([[US0_US0_0(), 0] as [US0_$union, int32], [US0_US0_1(), 1] as [US0_$union, int32], [US0_US0_2(), 2] as [US0_$union, int32], [US0_US0_3(), 3] as [US0_$union, int32], [US0_US0_4(), 4] as [US0_$union, int32]], {
        Compare: compare,
    })))) {
        let v77: any;
        closure6(patternInput[0], undefined);
        v77 = undefined;
        let v81: any;
        v3();
        v81 = undefined;
        const patternInput_2: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
        const _v292: FSharpRef<Option<US3_$union>> = new FSharpRef<Option<US3_$union>>(undefined);
        let v297: any;
        closure8(patternInput_2[5], (v: Option<US3_$union>): FSharpRef<Option<US3_$union>> => closure7(_v292, v), undefined);
        v297 = undefined;
        const v312: US3_$union = defaultArg(_v292.contents, US3_US3_1());
        const v357: string = toString((v312.tag === /* US3_0 */ 0) ? ((v316 = v312.fields[0], (v326 = fromTicks(toInt64(op_Subtraction(getTicks(now()), v316))), create(1, 1, 1, hours(v326), minutes(v326), seconds(v326), milliseconds(v326))))) : now(), method10());
        const v622: string = ("\u001b[91m" + padLeft("Critical".toLocaleLowerCase(), 7, " ")) + method11();
        const v637: int64 = patternInput_2[0].l0;
        const v639: Mut3 = new Mut3(method13());
        let v646: any;
        closure9(v639, `${"{ "}`, undefined);
        v646 = undefined;
        let v655: any;
        closure9(v639, `${"dir"}`, undefined);
        v655 = undefined;
        let v664: any;
        closure9(v639, `${" = "}`, undefined);
        v664 = undefined;
        let v672: any;
        closure9(v639, `${v0_1}`, undefined);
        v672 = undefined;
        let v681: any;
        closure9(v639, `${"; "}`, undefined);
        v681 = undefined;
        let v690: any;
        closure9(v639, `${"error"}`, undefined);
        v690 = undefined;
        let v698: any;
        closure9(v639, `${" = "}`, undefined);
        v698 = undefined;
        let v733: any;
        closure9(v639, `${toText(interpolate("%A%P()", [v1_1]))}`, undefined);
        v733 = undefined;
        let v742: any;
        closure9(v639, `${" }"}`, undefined);
        v742 = undefined;
        const v784: string = trimEnd(trimStart(`${v357} ${v622} #${v637} ${"file_system.create_dir"} / ${v639.l0}`, ...[]), ...[" ", "/"]);
        closure10(undefined, v784);
        patternInput[1].l0(v784);
    }
}

export function closure42(v0_1: string, unitVar: void): void {
    let v315: int64, v325: number;
    const v2_1 = (): void => {
        closure0(undefined, undefined);
    };
    let v3: any;
    v2_1();
    v3 = undefined;
    const patternInput: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
    let v36: any;
    v2_1();
    v36 = undefined;
    const patternInput_1: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
    const v68: US0_$union = patternInput_1[4].l0;
    if ((patternInput_1[2].l0 === false) ? false : (0 >= find<US0_$union, int32>(v68, ofSeq([[US0_US0_0(), 0] as [US0_$union, int32], [US0_US0_1(), 1] as [US0_$union, int32], [US0_US0_2(), 2] as [US0_$union, int32], [US0_US0_3(), 3] as [US0_$union, int32], [US0_US0_4(), 4] as [US0_$union, int32]], {
        Compare: compare,
    })))) {
        let v76: any;
        closure6(patternInput[0], undefined);
        v76 = undefined;
        let v80: any;
        v2_1();
        v80 = undefined;
        const patternInput_2: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
        const _v291: FSharpRef<Option<US3_$union>> = new FSharpRef<Option<US3_$union>>(undefined);
        let v296: any;
        closure8(patternInput_2[5], (v: Option<US3_$union>): FSharpRef<Option<US3_$union>> => closure7(_v291, v), undefined);
        v296 = undefined;
        const v311: US3_$union = defaultArg(_v291.contents, US3_US3_1());
        const v356: string = toString((v311.tag === /* US3_0 */ 0) ? ((v315 = v311.fields[0], (v325 = fromTicks(toInt64(op_Subtraction(getTicks(now()), v315))), create(1, 1, 1, hours(v325), minutes(v325), seconds(v325), milliseconds(v325))))) : now(), method10());
        const v621: string = ("\u001b[90m" + padLeft("Verbose".toLocaleLowerCase(), 7, " ")) + method11();
        const v636: int64 = patternInput_2[0].l0;
        const v638: Mut3 = new Mut3(method13());
        let v645: any;
        closure9(v638, `${"{ "}`, undefined);
        v645 = undefined;
        let v654: any;
        closure9(v638, `${"dir"}`, undefined);
        v654 = undefined;
        let v663: any;
        closure9(v638, `${" = "}`, undefined);
        v663 = undefined;
        let v671: any;
        closure9(v638, `${v0_1}`, undefined);
        v671 = undefined;
        let v680: any;
        closure9(v638, `${" }"}`, undefined);
        v680 = undefined;
        const v722: string = trimEnd(trimStart(`${v356} ${v621} #${v636} ${"file_system.create_dir"} / ${v638.l0}`, ...[]), ...[" ", "/"]);
        closure10(undefined, v722);
        patternInput[1].l0(v722);
    }
}

export function closure43(v0_1: string, unitVar: void): void {
    method6(true, v0_1);
}

export function method38(v0_1: string): (() => void) {
    return (): void => {
        closure43(v0_1, undefined);
    };
}

export function method39(v0_1: string): (() => void) {
    return (): void => {
        closure43(v0_1, undefined);
    };
}

export function closure44(v0_1: string, v1_1: string, unitVar: void): void {
    let v316: int64, v326: number;
    const v3 = (): void => {
        closure0(undefined, undefined);
    };
    let v4: any;
    v3();
    v4 = undefined;
    const patternInput: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
    let v37: any;
    v3();
    v37 = undefined;
    const patternInput_1: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
    const v69: US0_$union = patternInput_1[4].l0;
    if ((patternInput_1[2].l0 === false) ? false : (1 >= find<US0_$union, int32>(v69, ofSeq([[US0_US0_0(), 0] as [US0_$union, int32], [US0_US0_1(), 1] as [US0_$union, int32], [US0_US0_2(), 2] as [US0_$union, int32], [US0_US0_3(), 3] as [US0_$union, int32], [US0_US0_4(), 4] as [US0_$union, int32]], {
        Compare: compare,
    })))) {
        let v77: any;
        closure6(patternInput[0], undefined);
        v77 = undefined;
        let v81: any;
        v3();
        v81 = undefined;
        const patternInput_2: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
        const _v292: FSharpRef<Option<US3_$union>> = new FSharpRef<Option<US3_$union>>(undefined);
        let v297: any;
        closure8(patternInput_2[5], (v: Option<US3_$union>): FSharpRef<Option<US3_$union>> => closure7(_v292, v), undefined);
        v297 = undefined;
        const v312: US3_$union = defaultArg(_v292.contents, US3_US3_1());
        const v357: string = toString((v312.tag === /* US3_0 */ 0) ? ((v316 = v312.fields[0], (v326 = fromTicks(toInt64(op_Subtraction(getTicks(now()), v316))), create(1, 1, 1, hours(v326), minutes(v326), seconds(v326), milliseconds(v326))))) : now(), method10());
        const v622: string = ("\u001b[94m" + padLeft("Debug".toLocaleLowerCase(), 7, " ")) + method11();
        const v637: int64 = patternInput_2[0].l0;
        const v639: Mut3 = new Mut3(method13());
        let v646: any;
        closure9(v639, `${"{ "}`, undefined);
        v646 = undefined;
        let v655: any;
        closure9(v639, `${"dir"}`, undefined);
        v655 = undefined;
        let v664: any;
        closure9(v639, `${" = "}`, undefined);
        v664 = undefined;
        let v672: any;
        closure9(v639, `${v0_1}`, undefined);
        v672 = undefined;
        let v681: any;
        closure9(v639, `${"; "}`, undefined);
        v681 = undefined;
        let v690: any;
        closure9(v639, `${"result"}`, undefined);
        v690 = undefined;
        let v698: any;
        closure9(v639, `${" = "}`, undefined);
        v698 = undefined;
        let v706: any;
        closure9(v639, `${v1_1}`, undefined);
        v706 = undefined;
        let v715: any;
        closure9(v639, `${" }"}`, undefined);
        v715 = undefined;
        const v757: string = trimEnd(trimStart(`${v357} ${v622} #${v637} ${"file_system.create_dir"} / ${v639.l0}`, ...[]), ...[" ", "/"]);
        closure10(undefined, v757);
        patternInput[1].l0(v757);
    }
}

export function closure45(v0_1: string, unitVar: void): void {
    const v11: any = defaultOf();
    const v34_1: any = defaultOf();
    defaultOf();
}

export function method40(v0_1: string): (() => void) {
    return (): void => {
        closure45(v0_1, undefined);
    };
}

export function method41(v0_1: string): (() => void) {
    return (): void => {
        closure45(v0_1, undefined);
    };
}

export function method35(v0_1: string): IDisposable {
    const v1698: any = defaultOf();
    const v1728: boolean = defaultOf();
    if (v1728 === false) {
        let v1762: any;
        closure44(v0_1, toText(interpolate("%A%P()", [{
            CreationTime: defaultOf(),
            Exists: v1728,
        }])), undefined);
        v1762 = undefined;
    }
    const v2597: (() => void) = method41(v0_1);
    return {
        Dispose(): void {
            v2597();
        },
    };
}

export function closure37(unitVar: void, unitVar_1: void): [string, IDisposable] {
    const v0_1: string = method22();
    return [v0_1, method35(v0_1)] as [string, IDisposable];
}

export function method42(v0_1: string): string {
    const v39: string = padLeft(v0_1, 32, "0");
    return parse(`${v39.slice(0, 7 + 1)}-${v39.slice(8, 11 + 1)}-${v39.slice(12, 15 + 1)}-${v39.slice(16, 19 + 1)}-${v39.slice(20, 31 + 1)}`);
}

export function closure46(unitVar: void, v0_1: string): [string, IDisposable] {
    const v2_1: string = method27(method42(v0_1));
    return [v2_1, method35(v2_1)] as [string, IDisposable];
}

export function closure47(unitVar: void, unitVar_1: void): string {
    return "C:\\home\\git\\polyglot\\lib\\spiral";
}

export function method44(v0_1: string): string {
    return v0_1;
}

export function method43(v0_1: string): string {
    let _arg: string;
    if (v0_1 === "") {
        return "";
    }
    else {
        const v30_1: string = defaultOf();
        return replace(`${(_arg = v30_1[0], _arg.toLocaleLowerCase())}${v30_1.slice(1, v30_1.length)}`, "\\", "/");
    }
}

export function closure48(unitVar: void, v0_1: string): string {
    return method43(v0_1);
}

export function closure49(unitVar: void, v0_1: string): string {
    return `file:///${trimStart(v0_1, ...["/"])}`;
}

export function method47(v0_1: string): Option<string> {
    const v45: IPathDirname = path;
    const v85: US1_$union = US1_US1_0(v45.dirname(v0_1));
    if (v85.tag === /* US1_0 */ 0) {
        return v85.fields[0];
    }
    else {
        return undefined;
    }
}

export function closure51(unitVar: void, v0_1: string): Option<string> {
    return method47(v0_1);
}

export function method46(): ((arg0: string) => Option<string>) {
    return (v: string): Option<string> => closure51(undefined, v);
}

export function method48(v0_1_mut: string, v1_1_mut: string, v2_1_mut: string): US13_$union {
    method48:
    while (true) {
        const v0_1: string = v0_1_mut, v1_1: string = v1_1_mut, v2_1: string = v2_1_mut;
        if (method8(method30(v2_1, v0_1))) {
            return US13_US13_0(v2_1);
        }
        else {
            const v7: Option<string> = method46()(v2_1);
            const _v8: FSharpRef<Option<US1_$union>> = new FSharpRef<Option<US1_$union>>(undefined);
            let v13: any;
            closure2(v7, (v: Option<US1_$union>): FSharpRef<Option<US1_$union>> => closure1(_v8, v), undefined);
            v13 = undefined;
            const v28_1: US1_$union = defaultArg(_v8.contents, US1_US1_1());
            if (v28_1.tag === /* US1_0 */ 0) {
                v0_1_mut = v0_1;
                v1_1_mut = v1_1;
                v2_1_mut = v28_1.fields[0];
                continue method48;
            }
            else {
                return US13_US13_1(`No parent for ${"dir"} '${v0_1}' at '${v1_1}' (until '${v2_1}')`);
            }
        }
        break;
    }
}

export function method45(v0_1: string, v1_1: string): US13_$union {
    if (method8(method30(v1_1, v0_1))) {
        return US13_US13_0(v1_1);
    }
    else {
        const v6: Option<string> = method46()(v1_1);
        const _v7: FSharpRef<Option<US1_$union>> = new FSharpRef<Option<US1_$union>>(undefined);
        let v12: any;
        closure2(v6, (v: Option<US1_$union>): FSharpRef<Option<US1_$union>> => closure1(_v7, v), undefined);
        v12 = undefined;
        const v27_1: US1_$union = defaultArg(_v7.contents, US1_US1_1());
        if (v27_1.tag === /* US1_0 */ 0) {
            return method48(v0_1, v1_1, v27_1.fields[0]);
        }
        else {
            return US13_US13_1(`No parent for ${"dir"} '${v0_1}' at '${v1_1}' (until '${v1_1}')`);
        }
    }
}

export function closure52(v0_1: string, unitVar: void): void {
    let v315: int64, v325: number;
    const v2_1 = (): void => {
        closure0(undefined, undefined);
    };
    let v3: any;
    v2_1();
    v3 = undefined;
    const patternInput: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
    let v36: any;
    v2_1();
    v36 = undefined;
    const patternInput_1: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
    const v68: US0_$union = patternInput_1[4].l0;
    if ((patternInput_1[2].l0 === false) ? false : (3 >= find<US0_$union, int32>(v68, ofSeq([[US0_US0_0(), 0] as [US0_$union, int32], [US0_US0_1(), 1] as [US0_$union, int32], [US0_US0_2(), 2] as [US0_$union, int32], [US0_US0_3(), 3] as [US0_$union, int32], [US0_US0_4(), 4] as [US0_$union, int32]], {
        Compare: compare,
    })))) {
        let v76: any;
        closure6(patternInput[0], undefined);
        v76 = undefined;
        let v80: any;
        v2_1();
        v80 = undefined;
        const patternInput_2: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
        const _v291: FSharpRef<Option<US3_$union>> = new FSharpRef<Option<US3_$union>>(undefined);
        let v296: any;
        closure8(patternInput_2[5], (v: Option<US3_$union>): FSharpRef<Option<US3_$union>> => closure7(_v291, v), undefined);
        v296 = undefined;
        const v311: US3_$union = defaultArg(_v291.contents, US3_US3_1());
        const v356: string = toString((v311.tag === /* US3_0 */ 0) ? ((v315 = v311.fields[0], (v325 = fromTicks(toInt64(op_Subtraction(getTicks(now()), v315))), create(1, 1, 1, hours(v325), minutes(v325), seconds(v325), milliseconds(v325))))) : now(), method10());
        const v621: string = ("\u001b[93m" + padLeft("Warning".toLocaleLowerCase(), 7, " ")) + method11();
        const v636: int64 = patternInput_2[0].l0;
        const v638: Mut3 = new Mut3(method13());
        let v645: any;
        closure9(v638, `${"{ "}`, undefined);
        v645 = undefined;
        let v654: any;
        closure9(v638, `${"error"}`, undefined);
        v654 = undefined;
        let v663: any;
        closure9(v638, `${" = "}`, undefined);
        v663 = undefined;
        let v671: any;
        closure9(v638, `${v0_1}`, undefined);
        v671 = undefined;
        let v680: any;
        closure9(v638, `${" }"}`, undefined);
        v680 = undefined;
        const v722: string = trimEnd(trimStart(`${v356} ${v621} #${v636} ${"file_system.get_workspace_root"} / ${v638.l0}`, ...[]), ...[" ", "/"]);
        closure10(undefined, v722);
        patternInput[1].l0(v722);
    }
}

export function method49(): string {
    return defaultOf();
}

export function closure50(unitVar: void, unitVar_1: void): string {
    const v4: US13_$union = method45(method30("polyglot", ".devcontainer"), "C:\\home\\git\\polyglot\\lib\\spiral");
    let v806: US1_$union;
    if (v4.tag === /* US13_0 */ 0) {
        v806 = US1_US1_0(v4.fields[0]);
    }
    else {
        let v10: any;
        closure52(v4.fields[0], undefined);
        v10 = undefined;
        v806 = US1_US1_1();
    }
    let v1615: US1_$union;
    if (v806.tag === /* US1_0 */ 0) {
        v1615 = US1_US1_0(v806.fields[0]);
    }
    else {
        const v809: string = method49();
        const v811: US13_$union = method45(method30("polyglot", ".devcontainer"), v809);
        if (v811.tag === /* US13_0 */ 0) {
            v1615 = US1_US1_0(v811.fields[0]);
        }
        else {
            let v817: any;
            closure52(v811.fields[0], undefined);
            v817 = undefined;
            v1615 = US1_US1_1();
        }
    }
    return method30((v1615.tag === /* US1_0 */ 0) ? v1615.fields[0] : (() => {
        throw new Error("Option does not have a value.");
    })(), "polyglot");
}

export function method50(v0_1: string): void {
}

export function closure54(unitVar: void, v0_1: string): void {
    method50(v0_1);
}

export function closure53(unitVar: void, v0_1: boolean): void {
    let v3: any;
    closure0(undefined, undefined);
    v3 = undefined;
    const patternInput: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_3(TraceState_trace_state());
    const v37: ((arg0: string) => void) = v0_1 ? ((v: string): void => {
        closure54(undefined, v);
    }) : ((v_1: string): void => {
        closure3(undefined, v_1);
    });
    patternInput[1].l0 = v37;
}

export function method52(v0_1: string): string {
    return defaultOf();
}

export function method51(v0_1: string, v1_1: string): void {
    let v17_1: FSharpResult$2_$union<any, any>;
    if (method8(v0_1) === false) {
        const v4: IDisposable = method35(v0_1);
    }
    const v5: string = method52(v1_1);
    if (method8(v5) === false) {
        const v8: IDisposable = method35(v5);
    }
    if (method8(v1_1) && ((v17_1 = (new FSharpResult$2<any, any>()), true))) {
        method6(true, v1_1);
    }
    if (method8(v1_1) === false) {
    }
}

export function closure56(v0_1: string, v1_1: string): void {
    method51(v0_1, v1_1);
}

export function closure55(unitVar: void, v0_1: string): ((arg0: string) => void) {
    return (v: string): void => {
        closure56(v0_1, v);
    };
}

export function closure58(v0_1: string, v1_1: string): string {
    return method30(v0_1, v1_1);
}

export function closure57(unitVar: void, v0_1: string): ((arg0: string) => string) {
    return (v: string): string => closure58(v0_1, v);
}

export const v0: any = undefined;

export const v1 = (): void => {
    closure0(undefined, undefined);
};

export const v2: any = (v1(), v0);

export const v16 = (v: string): any => closure4(undefined, v);

export function delete_directory_async(x: string): any {
    return v16(x);
}

export const v17 = (v: US6_$union): ((arg0: string) => any) => closure12(undefined, v);

export function wait_for_file_access(x: US6_$union): ((arg0: string) => any) {
    return v17(x);
}

export const v18 = (v: string): any => closure15(undefined, v);

export function wait_for_file_access_read(x: string): any {
    return v18(x);
}

export const v19 = (v: string): any => closure16(undefined, v);

export function read_all_text_async(x: string): any {
    return v19(x);
}

export const v20 = (v: string): ((arg0: string) => boolean) => closure17(undefined, v);

export function file_exists_content(x: string): ((arg0: string) => boolean) {
    return v20(x);
}

export const v21 = (v: string): ((arg0: string) => any) => closure19(undefined, v);

export function write_all_text_async(x: string): ((arg0: string) => any) {
    return v21(x);
}

export const v22 = (v: string): ((arg0: string) => any) => closure21(undefined, v);

export function write_all_text_exists(x: string): ((arg0: string) => any) {
    return v22(x);
}

export const v23 = (v: string): any => closure23(undefined, v);

export function delete_file_async(x: string): any {
    return v23(x);
}

export const v24 = (v: string): ((arg0: string) => any) => closure25(undefined, v);

export function move_file_async(x: string): ((arg0: string) => any) {
    return v24(x);
}

export const v25 = (v: string): any => closure28(undefined, v);

export function read_all_text_retry_async(x: string): any {
    return v25(x);
}

export const v26 = (): string => closure34(undefined, undefined);

export function create_temp_path(): string {
    return v26();
}

export const v27 = (): [string, IDisposable] => closure37(undefined, undefined);

export function create_temp_dir(): [string, IDisposable] {
    return v27();
}

export const v28 = (v: string): [string, IDisposable] => closure46(undefined, v);

export function create_temp_dir$0027(x: string): [string, IDisposable] {
    return v28(x);
}

export const v29 = (): string => closure47(undefined, undefined);

export function get_source_directory(): string {
    return v29();
}

export const v30 = (v: string): string => closure48(undefined, v);

export function normalize_path(x: string): string {
    return v30(x);
}

export const v31 = (v: string): string => closure49(undefined, v);

export function new_file_uri(x: string): string {
    return v31(x);
}

export const v32 = (): string => closure50(undefined, undefined);

export function get_workspace_root(): string {
    return v32();
}

export const v33 = (v: boolean): void => {
    closure53(undefined, v);
};

export function init_trace_file(x: boolean): void {
    v33(x);
}

export const v34 = (v: string): ((arg0: string) => void) => closure55(undefined, v);

export function link_directory(x: string): ((arg0: string) => void) {
    return v34(x);
}

export const v35 = (v: string): ((arg0: string) => string) => closure57(undefined, v);

export function op_LessDivideGreater(x: string): ((arg0: string) => string) {
    return v35(x);
}


