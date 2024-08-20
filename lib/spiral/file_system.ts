import { defaultOf, compare, IComparable, IEquatable, IDisposable, createAtom } from "../../deps/Fable/src/fable-library-ts/Util.js";
import { defaultArg, value as value_3, Option } from "../../deps/Fable/src/fable-library-ts/Option.js";
import { op_Subtraction, op_Addition, toInt64, int64 } from "../../deps/Fable/src/fable-library-ts/BigInt.js";
import { bool_type, lambda_type, unit_type, string_type, record_type, int64_type, union_type, class_type, TypeInfo } from "../../deps/Fable/src/fable-library-ts/Reflection.js";
import { FSharpRef, Record, Union } from "../../deps/Fable/src/fable-library-ts/Types.js";
import { create, toString, now, getTicks } from "../../deps/Fable/src/fable-library-ts/Date.js";
import * as fs from "fs";
import { ofSeq, find } from "../../deps/Fable/src/fable-library-ts/Map.js";
import { uint8, int32 } from "../../deps/Fable/src/fable-library-ts/Int32.js";
import { toString as toString_1, milliseconds, seconds, minutes, hours, fromTicks } from "../../deps/Fable/src/fable-library-ts/TimeSpan.js";
import { replace, interpolate, toText, trimStart, trimEnd, padLeft } from "../../deps/Fable/src/fable-library-ts/String.js";
import { newGuid, parse } from "../../deps/Fable/src/fable-library-ts/Guid.js";
import * as path from "path";

export let State_trace_state = createAtom<Option<[Mut0, Mut1, Mut2, Mut3, Option<int64>]>>(undefined);

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
    l0: US0_$union;
    constructor(l0: US0_$union) {
        super();
        this.l0 = l0;
    }
}

export function Mut3_$reflection(): TypeInfo {
    return record_type("File_system.Mut3", [], Mut3, () => [["l0", US0_$reflection()]]);
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

export class Mut4 extends Record implements IEquatable<Mut4>, IComparable<Mut4> {
    l0: string;
    constructor(l0: string) {
        super();
        this.l0 = l0;
    }
}

export function Mut4_$reflection(): TypeInfo {
    return record_type("File_system.Mut4", [], Mut4, () => [["l0", string_type]]);
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

export function method0(v0_1: US0_$union): [Mut0, Mut1, Mut2, Mut3, Option<int64>] {
    let v124: US2_$union, v131: US2_$union, v138: US2_$union, v145: US2_$union;
    const v112: string = method2(method1());
    const v117: US2_$union = ("Verbose" === v112) ? US2_US2_0(US0_US0_0()) : US2_US2_1();
    const _v1 = [(v117.tag === /* US2_0 */ 0) ? US2_US2_0(v117.fields[0]) : ((v124 = (("Debug" === v112) ? US2_US2_0(US0_US0_1()) : US2_US2_1()), (v124.tag === /* US2_0 */ 0) ? US2_US2_0(v124.fields[0]) : ((v131 = (("Info" === v112) ? US2_US2_0(US0_US0_2()) : US2_US2_1()), (v131.tag === /* US2_0 */ 0) ? US2_US2_0(v131.fields[0]) : ((v138 = (("Warning" === v112) ? US2_US2_0(US0_US0_3()) : US2_US2_1()), (v138.tag === /* US2_0 */ 0) ? US2_US2_0(v138.fields[0]) : ((v145 = (("Critical" === v112) ? US2_US2_0(US0_US0_4()) : US2_US2_1()), (v145.tag === /* US2_0 */ 0) ? US2_US2_0(v145.fields[0]) : US2_US2_1())))))))), (method2(method4()) === "True") ? US3_US3_0(getTicks(now())) : US3_US3_1()] as [US2_$union, US3_$union];
    const v295: US3_$union = _v1[1];
    const v294: US2_$union = _v1[0];
    return [new Mut0(0n), new Mut1((v: string): void => {
        closure3(undefined, v);
    }), new Mut2(true), new Mut3((v294.tag === /* US2_0 */ 0) ? v294.fields[0] : v0_1), (v295.tag === /* US3_0 */ 0) ? v295.fields[0] : undefined] as [Mut0, Mut1, Mut2, Mut3, Option<int64>];
}

export function closure0(unitVar: void, unitVar_1: void): void {
    if (State_trace_state() == null) {
        const patternInput: [Mut0, Mut1, Mut2, Mut3, Option<int64>] = method0(US0_US0_0());
        State_trace_state([patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4]] as [Mut0, Mut1, Mut2, Mut3, Option<int64>]);
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

export function closure9(v0_1: Mut4, v1_1: string, unitVar: void): void {
    const v3: string = v0_1.l0 + v1_1;
    v0_1.l0 = v3;
}

export function closure10(unitVar: void, unitVar_1: void): string {
    return "file_system.delete_directory_async";
}

export function closure12(v0_1: string, unitVar: void): void {
    console.log(v0_1);
}

export function closure11(unitVar: void, v0_1: string): void {
    let v3: any;
    closure12(v0_1, undefined);
    v3 = undefined;
}

export function closure5(v0_1: string, v1_1: string, unitVar: void): void {
    let v304: int64, v314: number;
    const v3 = (): void => {
        closure0(undefined, undefined);
    };
    let v4: any;
    v3();
    v4 = undefined;
    const patternInput: [Mut0, Mut1, Mut2, Mut3, Option<int64>] = value_3(State_trace_state());
    let v33_1: any;
    v3();
    v33_1 = undefined;
    const patternInput_1: [Mut0, Mut1, Mut2, Mut3, Option<int64>] = value_3(State_trace_state());
    const v61: US0_$union = patternInput_1[3].l0;
    if ((patternInput_1[2].l0 === false) ? false : (1 >= find<US0_$union, int32>(v61, ofSeq([[US0_US0_0(), 0] as [US0_$union, int32], [US0_US0_1(), 1] as [US0_$union, int32], [US0_US0_2(), 2] as [US0_$union, int32], [US0_US0_3(), 3] as [US0_$union, int32], [US0_US0_4(), 4] as [US0_$union, int32]], {
        Compare: compare,
    })))) {
        let v69: any;
        closure6(patternInput[0], undefined);
        v69 = undefined;
        let v73: any;
        v3();
        v73 = undefined;
        const patternInput_2: [Mut0, Mut1, Mut2, Mut3, Option<int64>] = value_3(State_trace_state());
        const _v280: FSharpRef<Option<US3_$union>> = new FSharpRef<Option<US3_$union>>(undefined);
        let v285: any;
        closure8(patternInput_2[4], (v: Option<US3_$union>): FSharpRef<Option<US3_$union>> => closure7(_v280, v), undefined);
        v285 = undefined;
        const v300: US3_$union = defaultArg(_v280.contents, US3_US3_1());
        const v345: string = toString((v300.tag === /* US3_0 */ 0) ? ((v304 = v300.fields[0], (v314 = fromTicks(toInt64(op_Subtraction(getTicks(now()), v304))), create(1, 1, 1, hours(v314), minutes(v314), seconds(v314), milliseconds(v314))))) : now(), method10());
        const v610: string = ("\u001b[94m" + padLeft("Debug".toLocaleLowerCase(), 7, " ")) + method11();
        const v625: int64 = patternInput_2[0].l0;
        const v626: string = method12(v0_1);
        const v628: Mut4 = new Mut4(method13());
        let v635: any;
        closure9(v628, `${"{ "}`, undefined);
        v635 = undefined;
        let v644: any;
        closure9(v628, `${"ex"}`, undefined);
        v644 = undefined;
        let v653: any;
        closure9(v628, `${" = "}`, undefined);
        v653 = undefined;
        let v661: any;
        closure9(v628, `${v1_1}`, undefined);
        v661 = undefined;
        let v670: any;
        closure9(v628, `${"; "}`, undefined);
        v670 = undefined;
        let v679: any;
        closure9(v628, `${"path"}`, undefined);
        v679 = undefined;
        let v687: any;
        closure9(v628, `${" = "}`, undefined);
        v687 = undefined;
        let v695: any;
        closure9(v628, `${v626}`, undefined);
        v695 = undefined;
        let v704: any;
        closure9(v628, `${" }"}`, undefined);
        v704 = undefined;
        const v707: string = v628.l0;
        const v746: string = trimEnd(trimStart(`${v345} ${v610} #${v625} ${closure10(undefined, undefined)} / ${v707}`, ...[]), ...[" ", "/"]);
        closure11(undefined, v746);
        patternInput[1].l0(v746);
    }
}

export function method5(v0_1: string, v1_1: int64): any {
    return defaultOf();
}

export function closure4(unitVar: void, v0_1: string): any {
    return defaultOf();
}

export function closure16(unitVar: void, unitVar_1: void): string {
    return "file_system.wait_for_file_access";
}

export function closure15(v0_1: string, v1_1: int64, v2_1: string, unitVar: void): void {
    let v305: int64, v315: number;
    const v4 = (): void => {
        closure0(undefined, undefined);
    };
    let v5: any;
    v4();
    v5 = undefined;
    const patternInput: [Mut0, Mut1, Mut2, Mut3, Option<int64>] = value_3(State_trace_state());
    let v34: any;
    v4();
    v34 = undefined;
    const patternInput_1: [Mut0, Mut1, Mut2, Mut3, Option<int64>] = value_3(State_trace_state());
    const v62: US0_$union = patternInput_1[3].l0;
    if ((patternInput_1[2].l0 === false) ? false : (1 >= find<US0_$union, int32>(v62, ofSeq([[US0_US0_0(), 0] as [US0_$union, int32], [US0_US0_1(), 1] as [US0_$union, int32], [US0_US0_2(), 2] as [US0_$union, int32], [US0_US0_3(), 3] as [US0_$union, int32], [US0_US0_4(), 4] as [US0_$union, int32]], {
        Compare: compare,
    })))) {
        let v70: any;
        closure6(patternInput[0], undefined);
        v70 = undefined;
        let v74: any;
        v4();
        v74 = undefined;
        const patternInput_2: [Mut0, Mut1, Mut2, Mut3, Option<int64>] = value_3(State_trace_state());
        const _v281: FSharpRef<Option<US3_$union>> = new FSharpRef<Option<US3_$union>>(undefined);
        let v286: any;
        closure8(patternInput_2[4], (v: Option<US3_$union>): FSharpRef<Option<US3_$union>> => closure7(_v281, v), undefined);
        v286 = undefined;
        const v301: US3_$union = defaultArg(_v281.contents, US3_US3_1());
        const v346: string = toString((v301.tag === /* US3_0 */ 0) ? ((v305 = v301.fields[0], (v315 = fromTicks(toInt64(op_Subtraction(getTicks(now()), v305))), create(1, 1, 1, hours(v315), minutes(v315), seconds(v315), milliseconds(v315))))) : now(), method10());
        const v611: string = ("\u001b[94m" + padLeft("Debug".toLocaleLowerCase(), 7, " ")) + method11();
        const v626: int64 = patternInput_2[0].l0;
        const v627: string = method12(v0_1);
        const v629: Mut4 = new Mut4(method13());
        let v636: any;
        closure9(v629, `${"{ "}`, undefined);
        v636 = undefined;
        let v645: any;
        closure9(v629, `${"path"}`, undefined);
        v645 = undefined;
        let v654: any;
        closure9(v629, `${" = "}`, undefined);
        v654 = undefined;
        let v662: any;
        closure9(v629, `${v627}`, undefined);
        v662 = undefined;
        let v671: any;
        closure9(v629, `${"; "}`, undefined);
        v671 = undefined;
        let v680: any;
        closure9(v629, `${"retry"}`, undefined);
        v680 = undefined;
        let v688: any;
        closure9(v629, `${" = "}`, undefined);
        v688 = undefined;
        let v696: any;
        closure9(v629, `${v1_1}`, undefined);
        v696 = undefined;
        let v704: any;
        closure9(v629, `${"; "}`, undefined);
        v704 = undefined;
        let v713: any;
        closure9(v629, `${"ex"}`, undefined);
        v713 = undefined;
        let v721: any;
        closure9(v629, `${" = "}`, undefined);
        v721 = undefined;
        let v729: any;
        closure9(v629, `${v2_1}`, undefined);
        v729 = undefined;
        let v738: any;
        closure9(v629, `${" }"}`, undefined);
        v738 = undefined;
        const v741: string = v629.l0;
        const v780: string = trimEnd(trimStart(`${v346} ${v611} #${v626} ${closure16(undefined, undefined)} / ${v741}`, ...[]), ...[" ", "/"]);
        closure11(undefined, v780);
        patternInput[1].l0(v780);
    }
}

export function method14(v0_1: string, v1_1: US8_$union, v2_1: US7_$union, v3: int64): any {
    return defaultOf();
}

export function closure14(v0_1: US6_$union, v1_1: string): any {
    return defaultOf();
}

export function closure13(unitVar: void, v0_1: US6_$union): ((arg0: string) => any) {
    return (v: string): any => closure14(v0_1, v);
}

export function method15(v0_1: string, v1_1: int64): any {
    return defaultOf();
}

export function closure17(unitVar: void, v0_1: string): any {
    return defaultOf();
}

export function closure18(unitVar: void, v0_1: string): any {
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

export function closure20(v0_1: string, v1_1: string): boolean {
    return method16(v0_1, v1_1);
}

export function closure19(unitVar: void, v0_1: string): ((arg0: string) => boolean) {
    return (v: string): boolean => closure20(v0_1, v);
}

export function closure22(v0_1: string, v1_1: string): any {
    return defaultOf();
}

export function closure21(unitVar: void, v0_1: string): ((arg0: string) => any) {
    return (v: string): any => closure22(v0_1, v);
}

export function closure24(v0_1: string, v1_1: string): any {
    return defaultOf();
}

export function closure23(unitVar: void, v0_1: string): ((arg0: string) => any) {
    return (v: string): any => closure24(v0_1, v);
}

export function closure27(unitVar: void, unitVar_1: void): string {
    return "delete_file_async";
}

export function closure26(v0_1: string, v1_1: Error, unitVar: void): void {
    let v304: int64, v314: number;
    const v3 = (): void => {
        closure0(undefined, undefined);
    };
    let v4: any;
    v3();
    v4 = undefined;
    const patternInput: [Mut0, Mut1, Mut2, Mut3, Option<int64>] = value_3(State_trace_state());
    let v33_1: any;
    v3();
    v33_1 = undefined;
    const patternInput_1: [Mut0, Mut1, Mut2, Mut3, Option<int64>] = value_3(State_trace_state());
    const v61: US0_$union = patternInput_1[3].l0;
    if ((patternInput_1[2].l0 === false) ? false : (3 >= find<US0_$union, int32>(v61, ofSeq([[US0_US0_0(), 0] as [US0_$union, int32], [US0_US0_1(), 1] as [US0_$union, int32], [US0_US0_2(), 2] as [US0_$union, int32], [US0_US0_3(), 3] as [US0_$union, int32], [US0_US0_4(), 4] as [US0_$union, int32]], {
        Compare: compare,
    })))) {
        let v69: any;
        closure6(patternInput[0], undefined);
        v69 = undefined;
        let v73: any;
        v3();
        v73 = undefined;
        const patternInput_2: [Mut0, Mut1, Mut2, Mut3, Option<int64>] = value_3(State_trace_state());
        const _v280: FSharpRef<Option<US3_$union>> = new FSharpRef<Option<US3_$union>>(undefined);
        let v285: any;
        closure8(patternInput_2[4], (v: Option<US3_$union>): FSharpRef<Option<US3_$union>> => closure7(_v280, v), undefined);
        v285 = undefined;
        const v300: US3_$union = defaultArg(_v280.contents, US3_US3_1());
        const v345: string = toString((v300.tag === /* US3_0 */ 0) ? ((v304 = v300.fields[0], (v314 = fromTicks(toInt64(op_Subtraction(getTicks(now()), v304))), create(1, 1, 1, hours(v314), minutes(v314), seconds(v314), milliseconds(v314))))) : now(), method10());
        const v610: string = ("\u001b[93m" + padLeft("Warning".toLocaleLowerCase(), 7, " ")) + method11();
        const v625: int64 = patternInput_2[0].l0;
        const v626: string = method12(v0_1);
        const v637: string = toText(interpolate("%A%P()", [v1_1]));
        const v650: Mut4 = new Mut4(method13());
        let v657: any;
        closure9(v650, `${"{ "}`, undefined);
        v657 = undefined;
        let v666: any;
        closure9(v650, `${"path"}`, undefined);
        v666 = undefined;
        let v675: any;
        closure9(v650, `${" = "}`, undefined);
        v675 = undefined;
        let v683: any;
        closure9(v650, `${v626}`, undefined);
        v683 = undefined;
        let v692: any;
        closure9(v650, `${"; "}`, undefined);
        v692 = undefined;
        let v701: any;
        closure9(v650, `${"ex"}`, undefined);
        v701 = undefined;
        let v709: any;
        closure9(v650, `${" = "}`, undefined);
        v709 = undefined;
        let v717: any;
        closure9(v650, `${v637}`, undefined);
        v717 = undefined;
        let v726: any;
        closure9(v650, `${" }"}`, undefined);
        v726 = undefined;
        const v729: string = v650.l0;
        const v768: string = trimEnd(trimStart(`${v345} ${v610} #${v625} ${closure27(undefined, undefined)} / ${v729}`, ...[]), ...[" ", "/"]);
        closure11(undefined, v768);
        patternInput[1].l0(v768);
    }
}

export function method19(v0_1: string, v1_1: int64): any {
    return defaultOf();
}

export function closure25(unitVar: void, v0_1: string): any {
    return defaultOf();
}

export function closure31(unitVar: void, unitVar_1: void): string {
    return "move_file_async";
}

export function closure30(v0_1: string, v1_1: string, v2_1: Error, unitVar: void): void {
    let v305: int64, v315: number;
    const v4 = (): void => {
        closure0(undefined, undefined);
    };
    let v5: any;
    v4();
    v5 = undefined;
    const patternInput: [Mut0, Mut1, Mut2, Mut3, Option<int64>] = value_3(State_trace_state());
    let v34: any;
    v4();
    v34 = undefined;
    const patternInput_1: [Mut0, Mut1, Mut2, Mut3, Option<int64>] = value_3(State_trace_state());
    const v62: US0_$union = patternInput_1[3].l0;
    if ((patternInput_1[2].l0 === false) ? false : (3 >= find<US0_$union, int32>(v62, ofSeq([[US0_US0_0(), 0] as [US0_$union, int32], [US0_US0_1(), 1] as [US0_$union, int32], [US0_US0_2(), 2] as [US0_$union, int32], [US0_US0_3(), 3] as [US0_$union, int32], [US0_US0_4(), 4] as [US0_$union, int32]], {
        Compare: compare,
    })))) {
        let v70: any;
        closure6(patternInput[0], undefined);
        v70 = undefined;
        let v74: any;
        v4();
        v74 = undefined;
        const patternInput_2: [Mut0, Mut1, Mut2, Mut3, Option<int64>] = value_3(State_trace_state());
        const _v281: FSharpRef<Option<US3_$union>> = new FSharpRef<Option<US3_$union>>(undefined);
        let v286: any;
        closure8(patternInput_2[4], (v: Option<US3_$union>): FSharpRef<Option<US3_$union>> => closure7(_v281, v), undefined);
        v286 = undefined;
        const v301: US3_$union = defaultArg(_v281.contents, US3_US3_1());
        const v346: string = toString((v301.tag === /* US3_0 */ 0) ? ((v305 = v301.fields[0], (v315 = fromTicks(toInt64(op_Subtraction(getTicks(now()), v305))), create(1, 1, 1, hours(v315), minutes(v315), seconds(v315), milliseconds(v315))))) : now(), method10());
        const v611: string = ("\u001b[93m" + padLeft("Warning".toLocaleLowerCase(), 7, " ")) + method11();
        const v626: int64 = patternInput_2[0].l0;
        const v627: string = method12(v1_1);
        const v628: string = method12(v0_1);
        const v630: Mut4 = new Mut4(method13());
        let v637: any;
        closure9(v630, `${"{ "}`, undefined);
        v637 = undefined;
        let v646: any;
        closure9(v630, `${"old_path"}`, undefined);
        v646 = undefined;
        let v655: any;
        closure9(v630, `${" = "}`, undefined);
        v655 = undefined;
        let v663: any;
        closure9(v630, `${v627}`, undefined);
        v663 = undefined;
        let v672: any;
        closure9(v630, `${"; "}`, undefined);
        v672 = undefined;
        let v681: any;
        closure9(v630, `${"new_path"}`, undefined);
        v681 = undefined;
        let v689: any;
        closure9(v630, `${" = "}`, undefined);
        v689 = undefined;
        let v697: any;
        closure9(v630, `${v628}`, undefined);
        v697 = undefined;
        let v705: any;
        closure9(v630, `${"; "}`, undefined);
        v705 = undefined;
        let v714: any;
        closure9(v630, `${"ex"}`, undefined);
        v714 = undefined;
        let v722: any;
        closure9(v630, `${" = "}`, undefined);
        v722 = undefined;
        let v757: any;
        closure9(v630, `${toText(interpolate("%A%P()", [v2_1]))}`, undefined);
        v757 = undefined;
        let v766: any;
        closure9(v630, `${" }"}`, undefined);
        v766 = undefined;
        const v769: string = v630.l0;
        const v808: string = trimEnd(trimStart(`${v346} ${v611} #${v626} ${closure31(undefined, undefined)} / ${v769}`, ...[]), ...[" ", "/"]);
        closure11(undefined, v808);
        patternInput[1].l0(v808);
    }
}

export function method20(v0_1: string, v1_1: string, v2_1: int64): any {
    return defaultOf();
}

export function closure29(v0_1: string, v1_1: string): any {
    return defaultOf();
}

export function closure28(unitVar: void, v0_1: string): ((arg0: string) => any) {
    return (v: string): any => closure29(v0_1, v);
}

export function closure33(unitVar: void, v0_1: int64): US9_$union {
    return US9_US9_0(v0_1);
}

export function closure34(unitVar: void, v0_1: Error): US9_$union {
    return US9_US9_1(v0_1);
}

export function closure36(unitVar: void, unitVar_1: void): string {
    return "async.run_with_timeout_async";
}

export function closure35(unitVar: void, unitVar_1: void): void {
    let v302: int64, v312: number;
    const v1_1 = (): void => {
        closure0(undefined, undefined);
    };
    let v2_1: any;
    v1_1();
    v2_1 = undefined;
    const patternInput: [Mut0, Mut1, Mut2, Mut3, Option<int64>] = value_3(State_trace_state());
    let v31_1: any;
    v1_1();
    v31_1 = undefined;
    const patternInput_1: [Mut0, Mut1, Mut2, Mut3, Option<int64>] = value_3(State_trace_state());
    const v59: US0_$union = patternInput_1[3].l0;
    if ((patternInput_1[2].l0 === false) ? false : (0 >= find<US0_$union, int32>(v59, ofSeq([[US0_US0_0(), 0] as [US0_$union, int32], [US0_US0_1(), 1] as [US0_$union, int32], [US0_US0_2(), 2] as [US0_$union, int32], [US0_US0_3(), 3] as [US0_$union, int32], [US0_US0_4(), 4] as [US0_$union, int32]], {
        Compare: compare,
    })))) {
        let v67: any;
        closure6(patternInput[0], undefined);
        v67 = undefined;
        let v71: any;
        v1_1();
        v71 = undefined;
        const patternInput_2: [Mut0, Mut1, Mut2, Mut3, Option<int64>] = value_3(State_trace_state());
        const _v278: FSharpRef<Option<US3_$union>> = new FSharpRef<Option<US3_$union>>(undefined);
        let v283: any;
        closure8(patternInput_2[4], (v: Option<US3_$union>): FSharpRef<Option<US3_$union>> => closure7(_v278, v), undefined);
        v283 = undefined;
        const v298: US3_$union = defaultArg(_v278.contents, US3_US3_1());
        const v343: string = toString((v298.tag === /* US3_0 */ 0) ? ((v302 = v298.fields[0], (v312 = fromTicks(toInt64(op_Subtraction(getTicks(now()), v302))), create(1, 1, 1, hours(v312), minutes(v312), seconds(v312), milliseconds(v312))))) : now(), method10());
        const v608: string = ("\u001b[90m" + padLeft("Verbose".toLocaleLowerCase(), 7, " ")) + method11();
        const v623: int64 = patternInput_2[0].l0;
        const v625: Mut4 = new Mut4(method13());
        let v632: any;
        closure9(v625, `${"{ "}`, undefined);
        v632 = undefined;
        let v641: any;
        closure9(v625, `${"timeout"}`, undefined);
        v641 = undefined;
        let v650: any;
        closure9(v625, `${" = "}`, undefined);
        v650 = undefined;
        let v658: any;
        closure9(v625, `${1000}`, undefined);
        v658 = undefined;
        let v667: any;
        closure9(v625, `${" }"}`, undefined);
        v667 = undefined;
        const v670: string = v625.l0;
        const v709: string = trimEnd(trimStart(`${v343} ${v608} #${v623} ${closure36(undefined, undefined)} / ${v670}`, ...[]), ...[" ", "/"]);
        closure11(undefined, v709);
        patternInput[1].l0(v709);
    }
}

export function closure38(unitVar: void, unitVar_1: void): string {
    return "async.run_with_timeout_async**";
}

export function closure37(v0_1: Error, unitVar: void): void {
    let v303: int64, v313: number;
    const v2_1 = (): void => {
        closure0(undefined, undefined);
    };
    let v3: any;
    v2_1();
    v3 = undefined;
    const patternInput: [Mut0, Mut1, Mut2, Mut3, Option<int64>] = value_3(State_trace_state());
    let v32_1: any;
    v2_1();
    v32_1 = undefined;
    const patternInput_1: [Mut0, Mut1, Mut2, Mut3, Option<int64>] = value_3(State_trace_state());
    const v60: US0_$union = patternInput_1[3].l0;
    if ((patternInput_1[2].l0 === false) ? false : (4 >= find<US0_$union, int32>(v60, ofSeq([[US0_US0_0(), 0] as [US0_$union, int32], [US0_US0_1(), 1] as [US0_$union, int32], [US0_US0_2(), 2] as [US0_$union, int32], [US0_US0_3(), 3] as [US0_$union, int32], [US0_US0_4(), 4] as [US0_$union, int32]], {
        Compare: compare,
    })))) {
        let v68: any;
        closure6(patternInput[0], undefined);
        v68 = undefined;
        let v72: any;
        v2_1();
        v72 = undefined;
        const patternInput_2: [Mut0, Mut1, Mut2, Mut3, Option<int64>] = value_3(State_trace_state());
        const _v279: FSharpRef<Option<US3_$union>> = new FSharpRef<Option<US3_$union>>(undefined);
        let v284: any;
        closure8(patternInput_2[4], (v: Option<US3_$union>): FSharpRef<Option<US3_$union>> => closure7(_v279, v), undefined);
        v284 = undefined;
        const v299: US3_$union = defaultArg(_v279.contents, US3_US3_1());
        const v344: string = toString((v299.tag === /* US3_0 */ 0) ? ((v303 = v299.fields[0], (v313 = fromTicks(toInt64(op_Subtraction(getTicks(now()), v303))), create(1, 1, 1, hours(v313), minutes(v313), seconds(v313), milliseconds(v313))))) : now(), method10());
        const v609: string = ("\u001b[91m" + padLeft("Critical".toLocaleLowerCase(), 7, " ")) + method11();
        const v624: int64 = patternInput_2[0].l0;
        const v635: string = toText(interpolate("%A%P()", [v0_1]));
        const v648: Mut4 = new Mut4(method13());
        let v655: any;
        closure9(v648, `${"{ "}`, undefined);
        v655 = undefined;
        let v664: any;
        closure9(v648, `${"timeout"}`, undefined);
        v664 = undefined;
        let v673: any;
        closure9(v648, `${" = "}`, undefined);
        v673 = undefined;
        let v681: any;
        closure9(v648, `${1000}`, undefined);
        v681 = undefined;
        let v690: any;
        closure9(v648, `${"; "}`, undefined);
        v690 = undefined;
        let v699: any;
        closure9(v648, `${"ex"}`, undefined);
        v699 = undefined;
        let v707: any;
        closure9(v648, `${" = "}`, undefined);
        v707 = undefined;
        let v715: any;
        closure9(v648, `${v635}`, undefined);
        v715 = undefined;
        let v724: any;
        closure9(v648, `${" }"}`, undefined);
        v724 = undefined;
        const v727: string = v648.l0;
        const v766: string = trimEnd(trimStart(`${v344} ${v609} #${v624} ${closure38(undefined, undefined)} / ${v727}`, ...[]), ...[" ", "/"]);
        closure11(undefined, v766);
        patternInput[1].l0(v766);
    }
}

export function closure40(unitVar: void, unitVar_1: void): string {
    return "read_all_text_retry_async";
}

export function closure39(v0_1: int64, v1_1: string, unitVar: void): void {
    let v304: int64, v314: number;
    const v3 = (): void => {
        closure0(undefined, undefined);
    };
    let v4: any;
    v3();
    v4 = undefined;
    const patternInput: [Mut0, Mut1, Mut2, Mut3, Option<int64>] = value_3(State_trace_state());
    let v33_1: any;
    v3();
    v33_1 = undefined;
    const patternInput_1: [Mut0, Mut1, Mut2, Mut3, Option<int64>] = value_3(State_trace_state());
    const v61: US0_$union = patternInput_1[3].l0;
    if ((patternInput_1[2].l0 === false) ? false : (1 >= find<US0_$union, int32>(v61, ofSeq([[US0_US0_0(), 0] as [US0_$union, int32], [US0_US0_1(), 1] as [US0_$union, int32], [US0_US0_2(), 2] as [US0_$union, int32], [US0_US0_3(), 3] as [US0_$union, int32], [US0_US0_4(), 4] as [US0_$union, int32]], {
        Compare: compare,
    })))) {
        let v69: any;
        closure6(patternInput[0], undefined);
        v69 = undefined;
        let v73: any;
        v3();
        v73 = undefined;
        const patternInput_2: [Mut0, Mut1, Mut2, Mut3, Option<int64>] = value_3(State_trace_state());
        const _v280: FSharpRef<Option<US3_$union>> = new FSharpRef<Option<US3_$union>>(undefined);
        let v285: any;
        closure8(patternInput_2[4], (v: Option<US3_$union>): FSharpRef<Option<US3_$union>> => closure7(_v280, v), undefined);
        v285 = undefined;
        const v300: US3_$union = defaultArg(_v280.contents, US3_US3_1());
        const v345: string = toString((v300.tag === /* US3_0 */ 0) ? ((v304 = v300.fields[0], (v314 = fromTicks(toInt64(op_Subtraction(getTicks(now()), v304))), create(1, 1, 1, hours(v314), minutes(v314), seconds(v314), milliseconds(v314))))) : now(), method10());
        const v610: string = ("\u001b[94m" + padLeft("Debug".toLocaleLowerCase(), 7, " ")) + method11();
        const v625: int64 = patternInput_2[0].l0;
        const v627: Mut4 = new Mut4(method13());
        let v634: any;
        closure9(v627, `${"{ "}`, undefined);
        v634 = undefined;
        let v643: any;
        closure9(v627, `${"retry"}`, undefined);
        v643 = undefined;
        let v652: any;
        closure9(v627, `${" = "}`, undefined);
        v652 = undefined;
        let v660: any;
        closure9(v627, `${v0_1}`, undefined);
        v660 = undefined;
        let v669: any;
        closure9(v627, `${"; "}`, undefined);
        v669 = undefined;
        let v678: any;
        closure9(v627, `${"ex"}`, undefined);
        v678 = undefined;
        let v686: any;
        closure9(v627, `${" = "}`, undefined);
        v686 = undefined;
        let v694: any;
        closure9(v627, `${v1_1}`, undefined);
        v694 = undefined;
        let v703: any;
        closure9(v627, `${" }"}`, undefined);
        v703 = undefined;
        const v706: string = v627.l0;
        const v745: string = trimEnd(trimStart(`${v345} ${v610} #${v625} ${closure40(undefined, undefined)} / ${v706}`, ...[]), ...[" ", "/"]);
        closure11(undefined, v745);
        patternInput[1].l0(v745);
    }
}

export function method21(v0_1: string, v1_1: int64): any {
    return defaultOf();
}

export function closure32(unitVar: void, v0_1: string): any {
    return defaultOf();
}

export function closure42(v0_1: FSharpRef<Option<US11_$union>>, v1_1: Option<US11_$union>): FSharpRef<Option<US11_$union>> {
    v0_1.contents = v1_1;
    return v0_1;
}

export function closure43(v0_1: Option<any>, v1_1: ((arg0: Option<US11_$union>) => FSharpRef<Option<US11_$union>>), unitVar: void): void {
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

export function closure41(unitVar: void, unitVar_1: void): string {
    return method22();
}

export function method36(v0_1: string): string {
    return v0_1;
}

export function closure45(unitVar: void, v0_1: any): any {
    return defaultOf();
}

export function method37(): ((arg0: any) => any) {
    return (v: any): any => closure45(undefined, v);
}

export function closure46(unitVar: void, unitVar_1: void): US12_$union {
    return US12_US12_0();
}

export function closure47(unitVar: void, v0_1: any): US12_$union {
    return US12_US12_1(v0_1);
}

export function closure49(unitVar: void, unitVar_1: void): string {
    return "file_system.create_dir";
}

export function closure48(v0_1: string, v1_1: any, unitVar: void): void {
    let v304: int64, v314: number;
    const v3 = (): void => {
        closure0(undefined, undefined);
    };
    let v4: any;
    v3();
    v4 = undefined;
    const patternInput: [Mut0, Mut1, Mut2, Mut3, Option<int64>] = value_3(State_trace_state());
    let v33_1: any;
    v3();
    v33_1 = undefined;
    const patternInput_1: [Mut0, Mut1, Mut2, Mut3, Option<int64>] = value_3(State_trace_state());
    const v61: US0_$union = patternInput_1[3].l0;
    if ((patternInput_1[2].l0 === false) ? false : (4 >= find<US0_$union, int32>(v61, ofSeq([[US0_US0_0(), 0] as [US0_$union, int32], [US0_US0_1(), 1] as [US0_$union, int32], [US0_US0_2(), 2] as [US0_$union, int32], [US0_US0_3(), 3] as [US0_$union, int32], [US0_US0_4(), 4] as [US0_$union, int32]], {
        Compare: compare,
    })))) {
        let v69: any;
        closure6(patternInput[0], undefined);
        v69 = undefined;
        let v73: any;
        v3();
        v73 = undefined;
        const patternInput_2: [Mut0, Mut1, Mut2, Mut3, Option<int64>] = value_3(State_trace_state());
        const _v280: FSharpRef<Option<US3_$union>> = new FSharpRef<Option<US3_$union>>(undefined);
        let v285: any;
        closure8(patternInput_2[4], (v: Option<US3_$union>): FSharpRef<Option<US3_$union>> => closure7(_v280, v), undefined);
        v285 = undefined;
        const v300: US3_$union = defaultArg(_v280.contents, US3_US3_1());
        const v345: string = toString((v300.tag === /* US3_0 */ 0) ? ((v304 = v300.fields[0], (v314 = fromTicks(toInt64(op_Subtraction(getTicks(now()), v304))), create(1, 1, 1, hours(v314), minutes(v314), seconds(v314), milliseconds(v314))))) : now(), method10());
        const v610: string = ("\u001b[91m" + padLeft("Critical".toLocaleLowerCase(), 7, " ")) + method11();
        const v625: int64 = patternInput_2[0].l0;
        const v627: Mut4 = new Mut4(method13());
        let v634: any;
        closure9(v627, `${"{ "}`, undefined);
        v634 = undefined;
        let v643: any;
        closure9(v627, `${"dir"}`, undefined);
        v643 = undefined;
        let v652: any;
        closure9(v627, `${" = "}`, undefined);
        v652 = undefined;
        let v660: any;
        closure9(v627, `${v0_1}`, undefined);
        v660 = undefined;
        let v669: any;
        closure9(v627, `${"; "}`, undefined);
        v669 = undefined;
        let v678: any;
        closure9(v627, `${"error"}`, undefined);
        v678 = undefined;
        let v686: any;
        closure9(v627, `${" = "}`, undefined);
        v686 = undefined;
        let v721: any;
        closure9(v627, `${toText(interpolate("%A%P()", [v1_1]))}`, undefined);
        v721 = undefined;
        let v730: any;
        closure9(v627, `${" }"}`, undefined);
        v730 = undefined;
        const v733: string = v627.l0;
        const v772: string = trimEnd(trimStart(`${v345} ${v610} #${v625} ${closure49(undefined, undefined)} / ${v733}`, ...[]), ...[" ", "/"]);
        closure11(undefined, v772);
        patternInput[1].l0(v772);
    }
}

export function closure51(unitVar: void, unitVar_1: void): string {
    return "file_system.create_dir";
}

export function closure50(v0_1: string, unitVar: void): void {
    let v303: int64, v313: number;
    const v2_1 = (): void => {
        closure0(undefined, undefined);
    };
    let v3: any;
    v2_1();
    v3 = undefined;
    const patternInput: [Mut0, Mut1, Mut2, Mut3, Option<int64>] = value_3(State_trace_state());
    let v32_1: any;
    v2_1();
    v32_1 = undefined;
    const patternInput_1: [Mut0, Mut1, Mut2, Mut3, Option<int64>] = value_3(State_trace_state());
    const v60: US0_$union = patternInput_1[3].l0;
    if ((patternInput_1[2].l0 === false) ? false : (0 >= find<US0_$union, int32>(v60, ofSeq([[US0_US0_0(), 0] as [US0_$union, int32], [US0_US0_1(), 1] as [US0_$union, int32], [US0_US0_2(), 2] as [US0_$union, int32], [US0_US0_3(), 3] as [US0_$union, int32], [US0_US0_4(), 4] as [US0_$union, int32]], {
        Compare: compare,
    })))) {
        let v68: any;
        closure6(patternInput[0], undefined);
        v68 = undefined;
        let v72: any;
        v2_1();
        v72 = undefined;
        const patternInput_2: [Mut0, Mut1, Mut2, Mut3, Option<int64>] = value_3(State_trace_state());
        const _v279: FSharpRef<Option<US3_$union>> = new FSharpRef<Option<US3_$union>>(undefined);
        let v284: any;
        closure8(patternInput_2[4], (v: Option<US3_$union>): FSharpRef<Option<US3_$union>> => closure7(_v279, v), undefined);
        v284 = undefined;
        const v299: US3_$union = defaultArg(_v279.contents, US3_US3_1());
        const v344: string = toString((v299.tag === /* US3_0 */ 0) ? ((v303 = v299.fields[0], (v313 = fromTicks(toInt64(op_Subtraction(getTicks(now()), v303))), create(1, 1, 1, hours(v313), minutes(v313), seconds(v313), milliseconds(v313))))) : now(), method10());
        const v609: string = ("\u001b[90m" + padLeft("Verbose".toLocaleLowerCase(), 7, " ")) + method11();
        const v624: int64 = patternInput_2[0].l0;
        const v626: Mut4 = new Mut4(method13());
        let v633: any;
        closure9(v626, `${"{ "}`, undefined);
        v633 = undefined;
        let v642: any;
        closure9(v626, `${"dir"}`, undefined);
        v642 = undefined;
        let v651: any;
        closure9(v626, `${" = "}`, undefined);
        v651 = undefined;
        let v659: any;
        closure9(v626, `${v0_1}`, undefined);
        v659 = undefined;
        let v668: any;
        closure9(v626, `${" }"}`, undefined);
        v668 = undefined;
        const v671: string = v626.l0;
        const v710: string = trimEnd(trimStart(`${v344} ${v609} #${v624} ${closure51(undefined, undefined)} / ${v671}`, ...[]), ...[" ", "/"]);
        closure11(undefined, v710);
        patternInput[1].l0(v710);
    }
}

export function closure52(v0_1: string, unitVar: void): void {
    method6(true, v0_1);
}

export function method38(v0_1: string): (() => void) {
    return (): void => {
        closure52(v0_1, undefined);
    };
}

export function method39(v0_1: string): (() => void) {
    return (): void => {
        closure52(v0_1, undefined);
    };
}

export function closure54(unitVar: void, unitVar_1: void): string {
    return "file_system.create_dir";
}

export function closure53(v0_1: string, v1_1: string, unitVar: void): void {
    let v304: int64, v314: number;
    const v3 = (): void => {
        closure0(undefined, undefined);
    };
    let v4: any;
    v3();
    v4 = undefined;
    const patternInput: [Mut0, Mut1, Mut2, Mut3, Option<int64>] = value_3(State_trace_state());
    let v33_1: any;
    v3();
    v33_1 = undefined;
    const patternInput_1: [Mut0, Mut1, Mut2, Mut3, Option<int64>] = value_3(State_trace_state());
    const v61: US0_$union = patternInput_1[3].l0;
    if ((patternInput_1[2].l0 === false) ? false : (1 >= find<US0_$union, int32>(v61, ofSeq([[US0_US0_0(), 0] as [US0_$union, int32], [US0_US0_1(), 1] as [US0_$union, int32], [US0_US0_2(), 2] as [US0_$union, int32], [US0_US0_3(), 3] as [US0_$union, int32], [US0_US0_4(), 4] as [US0_$union, int32]], {
        Compare: compare,
    })))) {
        let v69: any;
        closure6(patternInput[0], undefined);
        v69 = undefined;
        let v73: any;
        v3();
        v73 = undefined;
        const patternInput_2: [Mut0, Mut1, Mut2, Mut3, Option<int64>] = value_3(State_trace_state());
        const _v280: FSharpRef<Option<US3_$union>> = new FSharpRef<Option<US3_$union>>(undefined);
        let v285: any;
        closure8(patternInput_2[4], (v: Option<US3_$union>): FSharpRef<Option<US3_$union>> => closure7(_v280, v), undefined);
        v285 = undefined;
        const v300: US3_$union = defaultArg(_v280.contents, US3_US3_1());
        const v345: string = toString((v300.tag === /* US3_0 */ 0) ? ((v304 = v300.fields[0], (v314 = fromTicks(toInt64(op_Subtraction(getTicks(now()), v304))), create(1, 1, 1, hours(v314), minutes(v314), seconds(v314), milliseconds(v314))))) : now(), method10());
        const v610: string = ("\u001b[94m" + padLeft("Debug".toLocaleLowerCase(), 7, " ")) + method11();
        const v625: int64 = patternInput_2[0].l0;
        const v627: Mut4 = new Mut4(method13());
        let v634: any;
        closure9(v627, `${"{ "}`, undefined);
        v634 = undefined;
        let v643: any;
        closure9(v627, `${"dir"}`, undefined);
        v643 = undefined;
        let v652: any;
        closure9(v627, `${" = "}`, undefined);
        v652 = undefined;
        let v660: any;
        closure9(v627, `${v0_1}`, undefined);
        v660 = undefined;
        let v669: any;
        closure9(v627, `${"; "}`, undefined);
        v669 = undefined;
        let v678: any;
        closure9(v627, `${"result"}`, undefined);
        v678 = undefined;
        let v686: any;
        closure9(v627, `${" = "}`, undefined);
        v686 = undefined;
        let v694: any;
        closure9(v627, `${v1_1}`, undefined);
        v694 = undefined;
        let v703: any;
        closure9(v627, `${" }"}`, undefined);
        v703 = undefined;
        const v706: string = v627.l0;
        const v745: string = trimEnd(trimStart(`${v345} ${v610} #${v625} ${closure54(undefined, undefined)} / ${v706}`, ...[]), ...[" ", "/"]);
        closure11(undefined, v745);
        patternInput[1].l0(v745);
    }
}

export function closure55(v0_1: string, unitVar: void): void {
    const v11: any = defaultOf();
    const v34: any = defaultOf();
    defaultOf();
}

export function method40(v0_1: string): (() => void) {
    return (): void => {
        closure55(v0_1, undefined);
    };
}

export function method41(v0_1: string): (() => void) {
    return (): void => {
        closure55(v0_1, undefined);
    };
}

export function method35(v0_1: string): IDisposable {
    const v1578: any = defaultOf();
    const v1608: boolean = defaultOf();
    if (v1608 === false) {
        let v1642: any;
        closure53(v0_1, toText(interpolate("%A%P()", [{
            CreationTime: defaultOf(),
            Exists: v1608,
        }])), undefined);
        v1642 = undefined;
    }
    const v2417: (() => void) = method41(v0_1);
    return {
        Dispose(): void {
            v2417();
        },
    };
}

export function closure44(unitVar: void, unitVar_1: void): [string, IDisposable] {
    const v0_1: string = method22();
    return [v0_1, method35(v0_1)] as [string, IDisposable];
}

export function method42(v0_1: string): string {
    const v39: string = padLeft(v0_1, 32, "0");
    return parse(`${v39.slice(0, 7 + 1)}-${v39.slice(8, 11 + 1)}-${v39.slice(12, 15 + 1)}-${v39.slice(16, 19 + 1)}-${v39.slice(20, 31 + 1)}`);
}

export function closure56(unitVar: void, v0_1: string): [string, IDisposable] {
    const v2_1: string = method27(method42(v0_1));
    return [v2_1, method35(v2_1)] as [string, IDisposable];
}

export function closure57(unitVar: void, unitVar_1: void): string {
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

export function closure58(unitVar: void, v0_1: string): string {
    return method43(v0_1);
}

export function closure59(unitVar: void, v0_1: string): string {
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

export function closure61(unitVar: void, v0_1: string): Option<string> {
    return method47(v0_1);
}

export function method46(): ((arg0: string) => Option<string>) {
    return (v: string): Option<string> => closure61(undefined, v);
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

export function closure63(unitVar: void, unitVar_1: void): string {
    return "file_system.get_workspace_root";
}

export function closure62(v0_1: string, unitVar: void): void {
    let v303: int64, v313: number;
    const v2_1 = (): void => {
        closure0(undefined, undefined);
    };
    let v3: any;
    v2_1();
    v3 = undefined;
    const patternInput: [Mut0, Mut1, Mut2, Mut3, Option<int64>] = value_3(State_trace_state());
    let v32_1: any;
    v2_1();
    v32_1 = undefined;
    const patternInput_1: [Mut0, Mut1, Mut2, Mut3, Option<int64>] = value_3(State_trace_state());
    const v60: US0_$union = patternInput_1[3].l0;
    if ((patternInput_1[2].l0 === false) ? false : (3 >= find<US0_$union, int32>(v60, ofSeq([[US0_US0_0(), 0] as [US0_$union, int32], [US0_US0_1(), 1] as [US0_$union, int32], [US0_US0_2(), 2] as [US0_$union, int32], [US0_US0_3(), 3] as [US0_$union, int32], [US0_US0_4(), 4] as [US0_$union, int32]], {
        Compare: compare,
    })))) {
        let v68: any;
        closure6(patternInput[0], undefined);
        v68 = undefined;
        let v72: any;
        v2_1();
        v72 = undefined;
        const patternInput_2: [Mut0, Mut1, Mut2, Mut3, Option<int64>] = value_3(State_trace_state());
        const _v279: FSharpRef<Option<US3_$union>> = new FSharpRef<Option<US3_$union>>(undefined);
        let v284: any;
        closure8(patternInput_2[4], (v: Option<US3_$union>): FSharpRef<Option<US3_$union>> => closure7(_v279, v), undefined);
        v284 = undefined;
        const v299: US3_$union = defaultArg(_v279.contents, US3_US3_1());
        const v344: string = toString((v299.tag === /* US3_0 */ 0) ? ((v303 = v299.fields[0], (v313 = fromTicks(toInt64(op_Subtraction(getTicks(now()), v303))), create(1, 1, 1, hours(v313), minutes(v313), seconds(v313), milliseconds(v313))))) : now(), method10());
        const v609: string = ("\u001b[93m" + padLeft("Warning".toLocaleLowerCase(), 7, " ")) + method11();
        const v624: int64 = patternInput_2[0].l0;
        const v626: Mut4 = new Mut4(method13());
        let v633: any;
        closure9(v626, `${"{ "}`, undefined);
        v633 = undefined;
        let v642: any;
        closure9(v626, `${"error"}`, undefined);
        v642 = undefined;
        let v651: any;
        closure9(v626, `${" = "}`, undefined);
        v651 = undefined;
        let v659: any;
        closure9(v626, `${v0_1}`, undefined);
        v659 = undefined;
        let v668: any;
        closure9(v626, `${" }"}`, undefined);
        v668 = undefined;
        const v671: string = v626.l0;
        const v710: string = trimEnd(trimStart(`${v344} ${v609} #${v624} ${closure63(undefined, undefined)} / ${v671}`, ...[]), ...[" ", "/"]);
        closure11(undefined, v710);
        patternInput[1].l0(v710);
    }
}

export function method49(): string {
    return defaultOf();
}

export function closure60(unitVar: void, unitVar_1: void): string {
    const v4: US13_$union = method45(method30("polyglot", ".devcontainer"), "C:\\home\\git\\polyglot\\lib\\spiral");
    let v746: US1_$union;
    if (v4.tag === /* US13_0 */ 0) {
        v746 = US1_US1_0(v4.fields[0]);
    }
    else {
        let v10: any;
        closure62(v4.fields[0], undefined);
        v10 = undefined;
        v746 = US1_US1_1();
    }
    let v1495: US1_$union;
    if (v746.tag === /* US1_0 */ 0) {
        v1495 = US1_US1_0(v746.fields[0]);
    }
    else {
        const v749: string = method49();
        const v751: US13_$union = method45(method30("polyglot", ".devcontainer"), v749);
        if (v751.tag === /* US13_0 */ 0) {
            v1495 = US1_US1_0(v751.fields[0]);
        }
        else {
            let v757: any;
            closure62(v751.fields[0], undefined);
            v757 = undefined;
            v1495 = US1_US1_1();
        }
    }
    return method30((v1495.tag === /* US1_0 */ 0) ? v1495.fields[0] : (() => {
        throw new Error("Option does not have a value.");
    })(), "polyglot");
}

export function method50(v0_1: string): void {
}

export function closure65(unitVar: void, v0_1: string): void {
    method50(v0_1);
}

export function closure64(unitVar: void, v0_1: boolean): void {
    let v3: any;
    closure0(undefined, undefined);
    v3 = undefined;
    const patternInput: [Mut0, Mut1, Mut2, Mut3, Option<int64>] = value_3(State_trace_state());
    const v33_1: ((arg0: string) => void) = v0_1 ? ((v: string): void => {
        closure65(undefined, v);
    }) : ((v_1: string): void => {
        closure3(undefined, v_1);
    });
    patternInput[1].l0 = v33_1;
}

export function closure67(v0_1: string, v1_1: string): string {
    return method30(v0_1, v1_1);
}

export function closure66(unitVar: void, v0_1: string): ((arg0: string) => string) {
    return (v: string): string => closure67(v0_1, v);
}

export const v0: any = undefined;

export const v1 = (): void => {
    closure0(undefined, undefined);
};

export const v2: any = (v1(), v0);

export const v15 = (v: string): any => closure4(undefined, v);

export function delete_directory_async(x: string): any {
    return v15(x);
}

export const v16 = (v: US6_$union): ((arg0: string) => any) => closure13(undefined, v);

export function wait_for_file_access(x: US6_$union): ((arg0: string) => any) {
    return v16(x);
}

export const v17 = (v: string): any => closure17(undefined, v);

export function wait_for_file_access_read(x: string): any {
    return v17(x);
}

export const v18 = (v: string): any => closure18(undefined, v);

export function read_all_text_async(x: string): any {
    return v18(x);
}

export const v19 = (v: string): ((arg0: string) => boolean) => closure19(undefined, v);

export function file_exists_content(x: string): ((arg0: string) => boolean) {
    return v19(x);
}

export const v20 = (v: string): ((arg0: string) => any) => closure21(undefined, v);

export function write_all_text_async(x: string): ((arg0: string) => any) {
    return v20(x);
}

export const v21 = (v: string): ((arg0: string) => any) => closure23(undefined, v);

export function write_all_text_exists(x: string): ((arg0: string) => any) {
    return v21(x);
}

export const v22 = (v: string): any => closure25(undefined, v);

export function delete_file_async(x: string): any {
    return v22(x);
}

export const v23 = (v: string): ((arg0: string) => any) => closure28(undefined, v);

export function move_file_async(x: string): ((arg0: string) => any) {
    return v23(x);
}

export const v24 = (v: string): any => closure32(undefined, v);

export function read_all_text_retry_async(x: string): any {
    return v24(x);
}

export const v25 = (): string => closure41(undefined, undefined);

export function create_temp_path(): string {
    return v25();
}

export const v26 = (): [string, IDisposable] => closure44(undefined, undefined);

export function create_temp_dir(): [string, IDisposable] {
    return v26();
}

export const v27 = (v: string): [string, IDisposable] => closure56(undefined, v);

export function create_temp_dir$0027(x: string): [string, IDisposable] {
    return v27(x);
}

export const v28 = (): string => closure57(undefined, undefined);

export function get_source_directory(): string {
    return v28();
}

export const v29 = (v: string): string => closure58(undefined, v);

export function normalize_path(x: string): string {
    return v29(x);
}

export const v30 = (v: string): string => closure59(undefined, v);

export function new_file_uri(x: string): string {
    return v30(x);
}

export const v31 = (): string => closure60(undefined, undefined);

export function get_workspace_root(): string {
    return v31();
}

export const v32 = (v: boolean): void => {
    closure64(undefined, v);
};

export function init_trace_file(x: boolean): void {
    v32(x);
}

export const v33 = (v: string): ((arg0: string) => string) => closure66(undefined, v);

export function op_LessDivideGreater(x: string): ((arg0: string) => string) {
    return v33(x);
}


