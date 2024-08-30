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
import { replace, trimStart, trimEnd, padLeft, split, interpolate, toText } from "../../deps/Fable/src/fable-library-ts/String.js";
import { item } from "../../deps/Fable/src/fable-library-ts/Array.js";
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
    return "(";
}

export function method12(): string {
    return " ";
}

export function method13(): string {
    return "";
}

export function closure9(v0_1: Mut4, v1_1: string, unitVar: void): void {
    const v3: string = v0_1.l0 + v1_1;
    v0_1.l0 = v3;
}

export function method14(): string {
    return "\u001b[0m";
}

export function method15(v0_1: string): string {
    throw new Error(`file_system.get_file_name / target: ${US5_US5_3(US4_US4_0())} / path: ${v0_1}`);
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
        const v558: string = method12();
        const v567: Mut4 = new Mut4(method13());
        let v578: any;
        closure9(v567, `${toText(interpolate("%A%P()", [US0_US0_0()]))}`, undefined);
        v578 = undefined;
        const v585: string = item(0, split(v567.l0, [v558], undefined, 0));
        const v589: Mut4 = new Mut4(method13());
        let v600: any;
        closure9(v589, `${toText(interpolate("%A%P()", [US0_US0_1()]))}`, undefined);
        v600 = undefined;
        const v603: string = v589.l0;
        const v610: US1_$union = (v603.indexOf(v585) === 0) ? US1_US1_0("Verbose") : US1_US1_1();
        const v616: US1_$union = (v610.tag === /* US1_0 */ 0) ? US1_US1_0(v610.fields[0]) : US1_US1_0("Debug");
        let v620: string;
        if (v616.tag === /* US1_0 */ 0) {
            v620 = v616.fields[0];
        }
        else {
            throw new Error("Option does not have a value.");
        }
        const v676: string = ("\u001b[94m" + padLeft(v620.toLocaleLowerCase(), 7, " ")) + method14();
        const v691: int64 = patternInput_2[0].l0;
        const v692: string = method15(v0_1);
        const v694: Mut4 = new Mut4(method13());
        let v701: any;
        closure9(v694, `${"{ "}`, undefined);
        v701 = undefined;
        let v710: any;
        closure9(v694, `${"ex"}`, undefined);
        v710 = undefined;
        let v719: any;
        closure9(v694, `${" = "}`, undefined);
        v719 = undefined;
        let v727: any;
        closure9(v694, `${v1_1}`, undefined);
        v727 = undefined;
        let v736: any;
        closure9(v694, `${"; "}`, undefined);
        v736 = undefined;
        let v745: any;
        closure9(v694, `${"path"}`, undefined);
        v745 = undefined;
        let v753: any;
        closure9(v694, `${" = "}`, undefined);
        v753 = undefined;
        let v761: any;
        closure9(v694, `${v692}`, undefined);
        v761 = undefined;
        let v770: any;
        closure9(v694, `${" }"}`, undefined);
        v770 = undefined;
        const v773: string = v694.l0;
        const v812: string = trimEnd(trimStart(`${v345} ${v676} #${v691} ${closure10(undefined, undefined)} / ${v773}`, ...[]), ...[" ", "/"]);
        closure11(undefined, v812);
        patternInput[1].l0(v812);
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
        const v559: string = method12();
        const v568: Mut4 = new Mut4(method13());
        let v579: any;
        closure9(v568, `${toText(interpolate("%A%P()", [US0_US0_0()]))}`, undefined);
        v579 = undefined;
        const v586: string = item(0, split(v568.l0, [v559], undefined, 0));
        const v590: Mut4 = new Mut4(method13());
        let v601: any;
        closure9(v590, `${toText(interpolate("%A%P()", [US0_US0_1()]))}`, undefined);
        v601 = undefined;
        const v604: string = v590.l0;
        const v611: US1_$union = (v604.indexOf(v586) === 0) ? US1_US1_0("Verbose") : US1_US1_1();
        const v617: US1_$union = (v611.tag === /* US1_0 */ 0) ? US1_US1_0(v611.fields[0]) : US1_US1_0("Debug");
        let v621: string;
        if (v617.tag === /* US1_0 */ 0) {
            v621 = v617.fields[0];
        }
        else {
            throw new Error("Option does not have a value.");
        }
        const v677: string = ("\u001b[94m" + padLeft(v621.toLocaleLowerCase(), 7, " ")) + method14();
        const v692: int64 = patternInput_2[0].l0;
        const v693: string = method15(v0_1);
        const v695: Mut4 = new Mut4(method13());
        let v702: any;
        closure9(v695, `${"{ "}`, undefined);
        v702 = undefined;
        let v711: any;
        closure9(v695, `${"path"}`, undefined);
        v711 = undefined;
        let v720: any;
        closure9(v695, `${" = "}`, undefined);
        v720 = undefined;
        let v728: any;
        closure9(v695, `${v693}`, undefined);
        v728 = undefined;
        let v737: any;
        closure9(v695, `${"; "}`, undefined);
        v737 = undefined;
        let v746: any;
        closure9(v695, `${"retry"}`, undefined);
        v746 = undefined;
        let v754: any;
        closure9(v695, `${" = "}`, undefined);
        v754 = undefined;
        let v762: any;
        closure9(v695, `${v1_1}`, undefined);
        v762 = undefined;
        let v770: any;
        closure9(v695, `${"; "}`, undefined);
        v770 = undefined;
        let v779: any;
        closure9(v695, `${"ex"}`, undefined);
        v779 = undefined;
        let v787: any;
        closure9(v695, `${" = "}`, undefined);
        v787 = undefined;
        let v795: any;
        closure9(v695, `${v2_1}`, undefined);
        v795 = undefined;
        let v804: any;
        closure9(v695, `${" }"}`, undefined);
        v804 = undefined;
        const v807: string = v695.l0;
        const v846: string = trimEnd(trimStart(`${v346} ${v677} #${v692} ${closure16(undefined, undefined)} / ${v807}`, ...[]), ...[" ", "/"]);
        closure11(undefined, v846);
        patternInput[1].l0(v846);
    }
}

export function method16(v0_1: string, v1_1: US8_$union, v2_1: US7_$union, v3: int64): any {
    return defaultOf();
}

export function closure14(v0_1: US6_$union, v1_1: string): any {
    return defaultOf();
}

export function closure13(unitVar: void, v0_1: US6_$union): ((arg0: string) => any) {
    return (v: string): any => closure14(v0_1, v);
}

export function method17(v0_1: string, v1_1: int64): any {
    return defaultOf();
}

export function closure17(unitVar: void, v0_1: string): any {
    return defaultOf();
}

export function closure18(unitVar: void, v0_1: string): any {
    return defaultOf();
}

export function method19(v0_1: string): boolean {
    const v20_1: IFsExistsSync = fs;
    return v20_1.existsSync(v0_1);
}

export function method20(v0_1: any): any {
    return v0_1;
}

export function method18(v0_1: string, v1_1: string): boolean {
    return defaultOf();
}

export function closure20(v0_1: string, v1_1: string): boolean {
    return method18(v0_1, v1_1);
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
        const v558: string = method12();
        const v567: Mut4 = new Mut4(method13());
        let v578: any;
        closure9(v567, `${toText(interpolate("%A%P()", [US0_US0_0()]))}`, undefined);
        v578 = undefined;
        const v585: string = item(0, split(v567.l0, [v558], undefined, 0));
        const v589: Mut4 = new Mut4(method13());
        let v600: any;
        closure9(v589, `${toText(interpolate("%A%P()", [US0_US0_3()]))}`, undefined);
        v600 = undefined;
        const v603: string = v589.l0;
        const v610: US1_$union = (v603.indexOf(v585) === 0) ? US1_US1_0("Verbose") : US1_US1_1();
        let v738: US1_$union;
        if (v610.tag === /* US1_0 */ 0) {
            v738 = US1_US1_0(v610.fields[0]);
        }
        else {
            const v617: string = method12();
            const v626: Mut4 = new Mut4(method13());
            let v637: any;
            closure9(v626, `${toText(interpolate("%A%P()", [US0_US0_1()]))}`, undefined);
            v637 = undefined;
            const v644: string = item(0, split(v626.l0, [v617], undefined, 0));
            const v648: Mut4 = new Mut4(method13());
            let v659: any;
            closure9(v648, `${toText(interpolate("%A%P()", [US0_US0_3()]))}`, undefined);
            v659 = undefined;
            const v662: string = v648.l0;
            const v669: US1_$union = (v662.indexOf(v644) === 0) ? US1_US1_0("Debug") : US1_US1_1();
            if (v669.tag === /* US1_0 */ 0) {
                v738 = US1_US1_0(v669.fields[0]);
            }
            else {
                const v676: string = method12();
                const v685: Mut4 = new Mut4(method13());
                let v696: any;
                closure9(v685, `${toText(interpolate("%A%P()", [US0_US0_2()]))}`, undefined);
                v696 = undefined;
                const v703: string = item(0, split(v685.l0, [v676], undefined, 0));
                const v707: Mut4 = new Mut4(method13());
                let v718: any;
                closure9(v707, `${toText(interpolate("%A%P()", [US0_US0_3()]))}`, undefined);
                v718 = undefined;
                const v721: string = v707.l0;
                const v728: US1_$union = (v721.indexOf(v703) === 0) ? US1_US1_0("Info") : US1_US1_1();
                v738 = ((v728.tag === /* US1_0 */ 0) ? US1_US1_0(v728.fields[0]) : US1_US1_0("Warning"));
            }
        }
        let v742: string;
        if (v738.tag === /* US1_0 */ 0) {
            v742 = v738.fields[0];
        }
        else {
            throw new Error("Option does not have a value.");
        }
        const v798: string = ("\u001b[93m" + padLeft(v742.toLocaleLowerCase(), 7, " ")) + method14();
        const v813: int64 = patternInput_2[0].l0;
        const v814: string = method15(v0_1);
        const v825: string = toText(interpolate("%A%P()", [v1_1]));
        const v838: Mut4 = new Mut4(method13());
        let v845: any;
        closure9(v838, `${"{ "}`, undefined);
        v845 = undefined;
        let v854: any;
        closure9(v838, `${"path"}`, undefined);
        v854 = undefined;
        let v863: any;
        closure9(v838, `${" = "}`, undefined);
        v863 = undefined;
        let v871: any;
        closure9(v838, `${v814}`, undefined);
        v871 = undefined;
        let v880: any;
        closure9(v838, `${"; "}`, undefined);
        v880 = undefined;
        let v889: any;
        closure9(v838, `${"ex"}`, undefined);
        v889 = undefined;
        let v897: any;
        closure9(v838, `${" = "}`, undefined);
        v897 = undefined;
        let v905: any;
        closure9(v838, `${v825}`, undefined);
        v905 = undefined;
        let v914: any;
        closure9(v838, `${" }"}`, undefined);
        v914 = undefined;
        const v917: string = v838.l0;
        const v956: string = trimEnd(trimStart(`${v345} ${v798} #${v813} ${closure27(undefined, undefined)} / ${v917}`, ...[]), ...[" ", "/"]);
        closure11(undefined, v956);
        patternInput[1].l0(v956);
    }
}

export function method21(v0_1: string, v1_1: int64): any {
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
        const v559: string = method12();
        const v568: Mut4 = new Mut4(method13());
        let v579: any;
        closure9(v568, `${toText(interpolate("%A%P()", [US0_US0_0()]))}`, undefined);
        v579 = undefined;
        const v586: string = item(0, split(v568.l0, [v559], undefined, 0));
        const v590: Mut4 = new Mut4(method13());
        let v601: any;
        closure9(v590, `${toText(interpolate("%A%P()", [US0_US0_3()]))}`, undefined);
        v601 = undefined;
        const v604: string = v590.l0;
        const v611: US1_$union = (v604.indexOf(v586) === 0) ? US1_US1_0("Verbose") : US1_US1_1();
        let v739: US1_$union;
        if (v611.tag === /* US1_0 */ 0) {
            v739 = US1_US1_0(v611.fields[0]);
        }
        else {
            const v618: string = method12();
            const v627: Mut4 = new Mut4(method13());
            let v638: any;
            closure9(v627, `${toText(interpolate("%A%P()", [US0_US0_1()]))}`, undefined);
            v638 = undefined;
            const v645: string = item(0, split(v627.l0, [v618], undefined, 0));
            const v649: Mut4 = new Mut4(method13());
            let v660: any;
            closure9(v649, `${toText(interpolate("%A%P()", [US0_US0_3()]))}`, undefined);
            v660 = undefined;
            const v663: string = v649.l0;
            const v670: US1_$union = (v663.indexOf(v645) === 0) ? US1_US1_0("Debug") : US1_US1_1();
            if (v670.tag === /* US1_0 */ 0) {
                v739 = US1_US1_0(v670.fields[0]);
            }
            else {
                const v677: string = method12();
                const v686: Mut4 = new Mut4(method13());
                let v697: any;
                closure9(v686, `${toText(interpolate("%A%P()", [US0_US0_2()]))}`, undefined);
                v697 = undefined;
                const v704: string = item(0, split(v686.l0, [v677], undefined, 0));
                const v708: Mut4 = new Mut4(method13());
                let v719: any;
                closure9(v708, `${toText(interpolate("%A%P()", [US0_US0_3()]))}`, undefined);
                v719 = undefined;
                const v722: string = v708.l0;
                const v729: US1_$union = (v722.indexOf(v704) === 0) ? US1_US1_0("Info") : US1_US1_1();
                v739 = ((v729.tag === /* US1_0 */ 0) ? US1_US1_0(v729.fields[0]) : US1_US1_0("Warning"));
            }
        }
        let v743: string;
        if (v739.tag === /* US1_0 */ 0) {
            v743 = v739.fields[0];
        }
        else {
            throw new Error("Option does not have a value.");
        }
        const v799: string = ("\u001b[93m" + padLeft(v743.toLocaleLowerCase(), 7, " ")) + method14();
        const v814: int64 = patternInput_2[0].l0;
        const v815: string = method15(v1_1);
        const v816: string = method15(v0_1);
        const v818: Mut4 = new Mut4(method13());
        let v825: any;
        closure9(v818, `${"{ "}`, undefined);
        v825 = undefined;
        let v834: any;
        closure9(v818, `${"old_path"}`, undefined);
        v834 = undefined;
        let v843: any;
        closure9(v818, `${" = "}`, undefined);
        v843 = undefined;
        let v851: any;
        closure9(v818, `${v815}`, undefined);
        v851 = undefined;
        let v860: any;
        closure9(v818, `${"; "}`, undefined);
        v860 = undefined;
        let v869: any;
        closure9(v818, `${"new_path"}`, undefined);
        v869 = undefined;
        let v877: any;
        closure9(v818, `${" = "}`, undefined);
        v877 = undefined;
        let v885: any;
        closure9(v818, `${v816}`, undefined);
        v885 = undefined;
        let v893: any;
        closure9(v818, `${"; "}`, undefined);
        v893 = undefined;
        let v902: any;
        closure9(v818, `${"ex"}`, undefined);
        v902 = undefined;
        let v910: any;
        closure9(v818, `${" = "}`, undefined);
        v910 = undefined;
        let v945: any;
        closure9(v818, `${toText(interpolate("%A%P()", [v2_1]))}`, undefined);
        v945 = undefined;
        let v954: any;
        closure9(v818, `${" }"}`, undefined);
        v954 = undefined;
        const v957: string = v818.l0;
        const v996: string = trimEnd(trimStart(`${v346} ${v799} #${v814} ${closure31(undefined, undefined)} / ${v957}`, ...[]), ...[" ", "/"]);
        closure11(undefined, v996);
        patternInput[1].l0(v996);
    }
}

export function method22(v0_1: string, v1_1: string, v2_1: int64): any {
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
        const v608: string = ("\u001b[90m" + padLeft("Verbose".toLocaleLowerCase(), 7, " ")) + method14();
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
        const v557: string = method12();
        const v566: Mut4 = new Mut4(method13());
        let v577: any;
        closure9(v566, `${toText(interpolate("%A%P()", [US0_US0_0()]))}`, undefined);
        v577 = undefined;
        const v584: string = item(0, split(v566.l0, [v557], undefined, 0));
        const v588: Mut4 = new Mut4(method13());
        let v599: any;
        closure9(v588, `${toText(interpolate("%A%P()", [US0_US0_4()]))}`, undefined);
        v599 = undefined;
        const v602: string = v588.l0;
        const v609: US1_$union = (v602.indexOf(v584) === 0) ? US1_US1_0("Verbose") : US1_US1_1();
        let v798: US1_$union;
        if (v609.tag === /* US1_0 */ 0) {
            v798 = US1_US1_0(v609.fields[0]);
        }
        else {
            const v616: string = method12();
            const v625: Mut4 = new Mut4(method13());
            let v636: any;
            closure9(v625, `${toText(interpolate("%A%P()", [US0_US0_1()]))}`, undefined);
            v636 = undefined;
            const v643: string = item(0, split(v625.l0, [v616], undefined, 0));
            const v647: Mut4 = new Mut4(method13());
            let v658: any;
            closure9(v647, `${toText(interpolate("%A%P()", [US0_US0_4()]))}`, undefined);
            v658 = undefined;
            const v661: string = v647.l0;
            const v668: US1_$union = (v661.indexOf(v643) === 0) ? US1_US1_0("Debug") : US1_US1_1();
            if (v668.tag === /* US1_0 */ 0) {
                v798 = US1_US1_0(v668.fields[0]);
            }
            else {
                const v675: string = method12();
                const v684: Mut4 = new Mut4(method13());
                let v695: any;
                closure9(v684, `${toText(interpolate("%A%P()", [US0_US0_2()]))}`, undefined);
                v695 = undefined;
                const v702: string = item(0, split(v684.l0, [v675], undefined, 0));
                const v706: Mut4 = new Mut4(method13());
                let v717: any;
                closure9(v706, `${toText(interpolate("%A%P()", [US0_US0_4()]))}`, undefined);
                v717 = undefined;
                const v720: string = v706.l0;
                const v727: US1_$union = (v720.indexOf(v702) === 0) ? US1_US1_0("Info") : US1_US1_1();
                if (v727.tag === /* US1_0 */ 0) {
                    v798 = US1_US1_0(v727.fields[0]);
                }
                else {
                    const v734: string = method12();
                    const v743: Mut4 = new Mut4(method13());
                    let v754: any;
                    closure9(v743, `${toText(interpolate("%A%P()", [US0_US0_3()]))}`, undefined);
                    v754 = undefined;
                    const v761: string = item(0, split(v743.l0, [v734], undefined, 0));
                    const v765: Mut4 = new Mut4(method13());
                    let v776: any;
                    closure9(v765, `${toText(interpolate("%A%P()", [US0_US0_4()]))}`, undefined);
                    v776 = undefined;
                    const v779: string = v765.l0;
                    const v786: US1_$union = (v779.indexOf(v761) === 0) ? US1_US1_0("Warning") : US1_US1_1();
                    v798 = ((v786.tag === /* US1_0 */ 0) ? US1_US1_0(v786.fields[0]) : US1_US1_0("Critical"));
                }
            }
        }
        let v802: string;
        if (v798.tag === /* US1_0 */ 0) {
            v802 = v798.fields[0];
        }
        else {
            throw new Error("Option does not have a value.");
        }
        const v858: string = ("\u001b[91m" + padLeft(v802.toLocaleLowerCase(), 7, " ")) + method14();
        const v873: int64 = patternInput_2[0].l0;
        const v884: string = toText(interpolate("%A%P()", [v0_1]));
        const v897: Mut4 = new Mut4(method13());
        let v904: any;
        closure9(v897, `${"{ "}`, undefined);
        v904 = undefined;
        let v913: any;
        closure9(v897, `${"timeout"}`, undefined);
        v913 = undefined;
        let v922: any;
        closure9(v897, `${" = "}`, undefined);
        v922 = undefined;
        let v930: any;
        closure9(v897, `${1000}`, undefined);
        v930 = undefined;
        let v939: any;
        closure9(v897, `${"; "}`, undefined);
        v939 = undefined;
        let v948: any;
        closure9(v897, `${"ex"}`, undefined);
        v948 = undefined;
        let v956: any;
        closure9(v897, `${" = "}`, undefined);
        v956 = undefined;
        let v964: any;
        closure9(v897, `${v884}`, undefined);
        v964 = undefined;
        let v973: any;
        closure9(v897, `${" }"}`, undefined);
        v973 = undefined;
        const v976: string = v897.l0;
        const v1015: string = trimEnd(trimStart(`${v344} ${v858} #${v873} ${closure38(undefined, undefined)} / ${v976}`, ...[]), ...[" ", "/"]);
        closure11(undefined, v1015);
        patternInput[1].l0(v1015);
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
        const v558: string = method12();
        const v567: Mut4 = new Mut4(method13());
        let v578: any;
        closure9(v567, `${toText(interpolate("%A%P()", [US0_US0_0()]))}`, undefined);
        v578 = undefined;
        const v585: string = item(0, split(v567.l0, [v558], undefined, 0));
        const v589: Mut4 = new Mut4(method13());
        let v600: any;
        closure9(v589, `${toText(interpolate("%A%P()", [US0_US0_1()]))}`, undefined);
        v600 = undefined;
        const v603: string = v589.l0;
        const v610: US1_$union = (v603.indexOf(v585) === 0) ? US1_US1_0("Verbose") : US1_US1_1();
        const v616: US1_$union = (v610.tag === /* US1_0 */ 0) ? US1_US1_0(v610.fields[0]) : US1_US1_0("Debug");
        let v620: string;
        if (v616.tag === /* US1_0 */ 0) {
            v620 = v616.fields[0];
        }
        else {
            throw new Error("Option does not have a value.");
        }
        const v676: string = ("\u001b[94m" + padLeft(v620.toLocaleLowerCase(), 7, " ")) + method14();
        const v691: int64 = patternInput_2[0].l0;
        const v693: Mut4 = new Mut4(method13());
        let v700: any;
        closure9(v693, `${"{ "}`, undefined);
        v700 = undefined;
        let v709: any;
        closure9(v693, `${"retry"}`, undefined);
        v709 = undefined;
        let v718: any;
        closure9(v693, `${" = "}`, undefined);
        v718 = undefined;
        let v726: any;
        closure9(v693, `${v0_1}`, undefined);
        v726 = undefined;
        let v735: any;
        closure9(v693, `${"; "}`, undefined);
        v735 = undefined;
        let v744: any;
        closure9(v693, `${"ex"}`, undefined);
        v744 = undefined;
        let v752: any;
        closure9(v693, `${" = "}`, undefined);
        v752 = undefined;
        let v760: any;
        closure9(v693, `${v1_1}`, undefined);
        v760 = undefined;
        let v769: any;
        closure9(v693, `${" }"}`, undefined);
        v769 = undefined;
        const v772: string = v693.l0;
        const v811: string = trimEnd(trimStart(`${v345} ${v676} #${v691} ${closure40(undefined, undefined)} / ${v772}`, ...[]), ...[" ", "/"]);
        closure11(undefined, v811);
        patternInput[1].l0(v811);
    }
}

export function method23(v0_1: string, v1_1: int64): any {
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

export function method26(): string {
    return "hh:mm";
}

export function method27(): string {
    return "yyyyMMdd-HHmm-ssff-ffff-f";
}

export function method28(): string {
    return "hhmm";
}

export function method25(v0_1: string, v1_1: Date): string {
    const v338: string = toString(v1_1, method27());
    const v350: any = defaultOf();
    let v407: number;
    throw new Error(`date_time.get_utc_offset / target: ${US5_US5_3(US4_US4_0())}`);
    const v418: uint8 = (hours(v407) > 0) ? 1 : 0;
    const v419: string = method28();
    const v430 = `${v418}${toString_1(v407, "c", {})}`;
    const v432: string = v0_1;
    return parse(`${v338}${v430}${v432.slice(v338.length + v430.length, v432.length)}`);
}

export function method30(): string {
    throw new Error(`file_system.get_temp_path / target: ${US5_US5_3(US4_US4_0())}`);
}

export function method31(): string {
    return "!create_temp_path_";
}

export function method34(v0_1: string): string {
    return v0_1;
}

export function method33(v0_1: string, v1_1: string): [string, string] {
    return [v1_1, method34(v0_1)] as [string, string];
}

export function method32(v0_1: string, v1_1: string): string {
    const v48: IPathJoin = path;
    const patternInput: [string, string] = method33(v1_1, v0_1);
    return v48.join(patternInput[0], patternInput[1]);
}

export function method36(): string {
    return "CARGO_PKG_NAME";
}

export function method35(): string {
    throw new Error(`env.get_entry_assembly_name / target: ${US5_US5_3(US4_US4_0())}`);
}

export function method29(v0_1: string): string {
    return method32(method32(method32(method30(), method31()), method35()), v0_1);
}

export function method24(): string {
    const v22_1: Date = now();
    return method29(method25(newGuid(), v22_1));
}

export function closure41(unitVar: void, unitVar_1: void): string {
    return method24();
}

export function method38(v0_1: string): string {
    return v0_1;
}

export function closure45(unitVar: void, v0_1: any): any {
    return defaultOf();
}

export function method39(): ((arg0: any) => any) {
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
        const v558: string = method12();
        const v567: Mut4 = new Mut4(method13());
        let v578: any;
        closure9(v567, `${toText(interpolate("%A%P()", [US0_US0_0()]))}`, undefined);
        v578 = undefined;
        const v585: string = item(0, split(v567.l0, [v558], undefined, 0));
        const v589: Mut4 = new Mut4(method13());
        let v600: any;
        closure9(v589, `${toText(interpolate("%A%P()", [US0_US0_4()]))}`, undefined);
        v600 = undefined;
        const v603: string = v589.l0;
        const v610: US1_$union = (v603.indexOf(v585) === 0) ? US1_US1_0("Verbose") : US1_US1_1();
        let v799: US1_$union;
        if (v610.tag === /* US1_0 */ 0) {
            v799 = US1_US1_0(v610.fields[0]);
        }
        else {
            const v617: string = method12();
            const v626: Mut4 = new Mut4(method13());
            let v637: any;
            closure9(v626, `${toText(interpolate("%A%P()", [US0_US0_1()]))}`, undefined);
            v637 = undefined;
            const v644: string = item(0, split(v626.l0, [v617], undefined, 0));
            const v648: Mut4 = new Mut4(method13());
            let v659: any;
            closure9(v648, `${toText(interpolate("%A%P()", [US0_US0_4()]))}`, undefined);
            v659 = undefined;
            const v662: string = v648.l0;
            const v669: US1_$union = (v662.indexOf(v644) === 0) ? US1_US1_0("Debug") : US1_US1_1();
            if (v669.tag === /* US1_0 */ 0) {
                v799 = US1_US1_0(v669.fields[0]);
            }
            else {
                const v676: string = method12();
                const v685: Mut4 = new Mut4(method13());
                let v696: any;
                closure9(v685, `${toText(interpolate("%A%P()", [US0_US0_2()]))}`, undefined);
                v696 = undefined;
                const v703: string = item(0, split(v685.l0, [v676], undefined, 0));
                const v707: Mut4 = new Mut4(method13());
                let v718: any;
                closure9(v707, `${toText(interpolate("%A%P()", [US0_US0_4()]))}`, undefined);
                v718 = undefined;
                const v721: string = v707.l0;
                const v728: US1_$union = (v721.indexOf(v703) === 0) ? US1_US1_0("Info") : US1_US1_1();
                if (v728.tag === /* US1_0 */ 0) {
                    v799 = US1_US1_0(v728.fields[0]);
                }
                else {
                    const v735: string = method12();
                    const v744: Mut4 = new Mut4(method13());
                    let v755: any;
                    closure9(v744, `${toText(interpolate("%A%P()", [US0_US0_3()]))}`, undefined);
                    v755 = undefined;
                    const v762: string = item(0, split(v744.l0, [v735], undefined, 0));
                    const v766: Mut4 = new Mut4(method13());
                    let v777: any;
                    closure9(v766, `${toText(interpolate("%A%P()", [US0_US0_4()]))}`, undefined);
                    v777 = undefined;
                    const v780: string = v766.l0;
                    const v787: US1_$union = (v780.indexOf(v762) === 0) ? US1_US1_0("Warning") : US1_US1_1();
                    v799 = ((v787.tag === /* US1_0 */ 0) ? US1_US1_0(v787.fields[0]) : US1_US1_0("Critical"));
                }
            }
        }
        let v803: string;
        if (v799.tag === /* US1_0 */ 0) {
            v803 = v799.fields[0];
        }
        else {
            throw new Error("Option does not have a value.");
        }
        const v859: string = ("\u001b[91m" + padLeft(v803.toLocaleLowerCase(), 7, " ")) + method14();
        const v874: int64 = patternInput_2[0].l0;
        const v876: Mut4 = new Mut4(method13());
        let v883: any;
        closure9(v876, `${"{ "}`, undefined);
        v883 = undefined;
        let v892: any;
        closure9(v876, `${"dir"}`, undefined);
        v892 = undefined;
        let v901: any;
        closure9(v876, `${" = "}`, undefined);
        v901 = undefined;
        let v909: any;
        closure9(v876, `${v0_1}`, undefined);
        v909 = undefined;
        let v918: any;
        closure9(v876, `${"; "}`, undefined);
        v918 = undefined;
        let v927: any;
        closure9(v876, `${"error"}`, undefined);
        v927 = undefined;
        let v935: any;
        closure9(v876, `${" = "}`, undefined);
        v935 = undefined;
        let v970: any;
        closure9(v876, `${toText(interpolate("%A%P()", [v1_1]))}`, undefined);
        v970 = undefined;
        let v979: any;
        closure9(v876, `${" }"}`, undefined);
        v979 = undefined;
        const v982: string = v876.l0;
        const v1021: string = trimEnd(trimStart(`${v345} ${v859} #${v874} ${closure49(undefined, undefined)} / ${v982}`, ...[]), ...[" ", "/"]);
        closure11(undefined, v1021);
        patternInput[1].l0(v1021);
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
        const v609: string = ("\u001b[90m" + padLeft("Verbose".toLocaleLowerCase(), 7, " ")) + method14();
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

export function method40(v0_1: string): (() => void) {
    return (): void => {
        closure52(v0_1, undefined);
    };
}

export function method41(v0_1: string): (() => void) {
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
        const v558: string = method12();
        const v567: Mut4 = new Mut4(method13());
        let v578: any;
        closure9(v567, `${toText(interpolate("%A%P()", [US0_US0_0()]))}`, undefined);
        v578 = undefined;
        const v585: string = item(0, split(v567.l0, [v558], undefined, 0));
        const v589: Mut4 = new Mut4(method13());
        let v600: any;
        closure9(v589, `${toText(interpolate("%A%P()", [US0_US0_1()]))}`, undefined);
        v600 = undefined;
        const v603: string = v589.l0;
        const v610: US1_$union = (v603.indexOf(v585) === 0) ? US1_US1_0("Verbose") : US1_US1_1();
        const v616: US1_$union = (v610.tag === /* US1_0 */ 0) ? US1_US1_0(v610.fields[0]) : US1_US1_0("Debug");
        let v620: string;
        if (v616.tag === /* US1_0 */ 0) {
            v620 = v616.fields[0];
        }
        else {
            throw new Error("Option does not have a value.");
        }
        const v676: string = ("\u001b[94m" + padLeft(v620.toLocaleLowerCase(), 7, " ")) + method14();
        const v691: int64 = patternInput_2[0].l0;
        const v693: Mut4 = new Mut4(method13());
        let v700: any;
        closure9(v693, `${"{ "}`, undefined);
        v700 = undefined;
        let v709: any;
        closure9(v693, `${"dir"}`, undefined);
        v709 = undefined;
        let v718: any;
        closure9(v693, `${" = "}`, undefined);
        v718 = undefined;
        let v726: any;
        closure9(v693, `${v0_1}`, undefined);
        v726 = undefined;
        let v735: any;
        closure9(v693, `${"; "}`, undefined);
        v735 = undefined;
        let v744: any;
        closure9(v693, `${"result"}`, undefined);
        v744 = undefined;
        let v752: any;
        closure9(v693, `${" = "}`, undefined);
        v752 = undefined;
        let v760: any;
        closure9(v693, `${v1_1}`, undefined);
        v760 = undefined;
        let v769: any;
        closure9(v693, `${" }"}`, undefined);
        v769 = undefined;
        const v772: string = v693.l0;
        const v811: string = trimEnd(trimStart(`${v345} ${v676} #${v691} ${closure54(undefined, undefined)} / ${v772}`, ...[]), ...[" ", "/"]);
        closure11(undefined, v811);
        patternInput[1].l0(v811);
    }
}

export function closure55(v0_1: string, unitVar: void): void {
    const v11: any = defaultOf();
    const v34: any = defaultOf();
    defaultOf();
}

export function method42(v0_1: string): (() => void) {
    return (): void => {
        closure55(v0_1, undefined);
    };
}

export function method43(v0_1: string): (() => void) {
    return (): void => {
        closure55(v0_1, undefined);
    };
}

export function method37(v0_1: string): IDisposable {
    const v1827: any = defaultOf();
    const v1857: boolean = defaultOf();
    if (v1857 === false) {
        let v1891: any;
        closure53(v0_1, toText(interpolate("%A%P()", [{
            CreationTime: defaultOf(),
            Exists: v1857,
        }])), undefined);
        v1891 = undefined;
    }
    const v2732: (() => void) = method43(v0_1);
    return {
        Dispose(): void {
            v2732();
        },
    };
}

export function closure44(unitVar: void, unitVar_1: void): [string, IDisposable] {
    const v0_1: string = method24();
    return [v0_1, method37(v0_1)] as [string, IDisposable];
}

export function method44(v0_1: string): string {
    const v39: string = padLeft(v0_1, 32, "0");
    return parse(`${v39.slice(0, 7 + 1)}-${v39.slice(8, 11 + 1)}-${v39.slice(12, 15 + 1)}-${v39.slice(16, 19 + 1)}-${v39.slice(20, 31 + 1)}`);
}

export function closure56(unitVar: void, v0_1: string): [string, IDisposable] {
    const v2_1: string = method29(method44(v0_1));
    return [v2_1, method37(v2_1)] as [string, IDisposable];
}

export function closure57(unitVar: void, unitVar_1: void): string {
    return "C:\\home\\git\\polyglot\\lib\\spiral";
}

export function method46(v0_1: string): string {
    return v0_1;
}

export function method45(v0_1: string): string {
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
    return method45(v0_1);
}

export function closure59(unitVar: void, v0_1: string): string {
    return `file:///${trimStart(v0_1, ...["/"])}`;
}

export function method49(v0_1: string): Option<string> {
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
    return method49(v0_1);
}

export function method48(): ((arg0: string) => Option<string>) {
    return (v: string): Option<string> => closure61(undefined, v);
}

export function method50(v0_1_mut: string, v1_1_mut: string, v2_1_mut: string): US13_$union {
    method50:
    while (true) {
        const v0_1: string = v0_1_mut, v1_1: string = v1_1_mut, v2_1: string = v2_1_mut;
        if (method8(method32(v2_1, v0_1))) {
            return US13_US13_0(v2_1);
        }
        else {
            const v7: Option<string> = method48()(v2_1);
            const _v8: FSharpRef<Option<US1_$union>> = new FSharpRef<Option<US1_$union>>(undefined);
            let v13: any;
            closure2(v7, (v: Option<US1_$union>): FSharpRef<Option<US1_$union>> => closure1(_v8, v), undefined);
            v13 = undefined;
            const v28_1: US1_$union = defaultArg(_v8.contents, US1_US1_1());
            if (v28_1.tag === /* US1_0 */ 0) {
                v0_1_mut = v0_1;
                v1_1_mut = v1_1;
                v2_1_mut = v28_1.fields[0];
                continue method50;
            }
            else {
                return US13_US13_1(`No parent for ${"dir"} '${v0_1}' at '${v1_1}' (until '${v2_1}')`);
            }
        }
        break;
    }
}

export function method47(v0_1: string, v1_1: string): US13_$union {
    if (method8(method32(v1_1, v0_1))) {
        return US13_US13_0(v1_1);
    }
    else {
        const v6: Option<string> = method48()(v1_1);
        const _v7: FSharpRef<Option<US1_$union>> = new FSharpRef<Option<US1_$union>>(undefined);
        let v12: any;
        closure2(v6, (v: Option<US1_$union>): FSharpRef<Option<US1_$union>> => closure1(_v7, v), undefined);
        v12 = undefined;
        const v27_1: US1_$union = defaultArg(_v7.contents, US1_US1_1());
        if (v27_1.tag === /* US1_0 */ 0) {
            return method50(v0_1, v1_1, v27_1.fields[0]);
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
        const v557: string = method12();
        const v566: Mut4 = new Mut4(method13());
        let v577: any;
        closure9(v566, `${toText(interpolate("%A%P()", [US0_US0_0()]))}`, undefined);
        v577 = undefined;
        const v584: string = item(0, split(v566.l0, [v557], undefined, 0));
        const v588: Mut4 = new Mut4(method13());
        let v599: any;
        closure9(v588, `${toText(interpolate("%A%P()", [US0_US0_3()]))}`, undefined);
        v599 = undefined;
        const v602: string = v588.l0;
        const v609: US1_$union = (v602.indexOf(v584) === 0) ? US1_US1_0("Verbose") : US1_US1_1();
        let v737: US1_$union;
        if (v609.tag === /* US1_0 */ 0) {
            v737 = US1_US1_0(v609.fields[0]);
        }
        else {
            const v616: string = method12();
            const v625: Mut4 = new Mut4(method13());
            let v636: any;
            closure9(v625, `${toText(interpolate("%A%P()", [US0_US0_1()]))}`, undefined);
            v636 = undefined;
            const v643: string = item(0, split(v625.l0, [v616], undefined, 0));
            const v647: Mut4 = new Mut4(method13());
            let v658: any;
            closure9(v647, `${toText(interpolate("%A%P()", [US0_US0_3()]))}`, undefined);
            v658 = undefined;
            const v661: string = v647.l0;
            const v668: US1_$union = (v661.indexOf(v643) === 0) ? US1_US1_0("Debug") : US1_US1_1();
            if (v668.tag === /* US1_0 */ 0) {
                v737 = US1_US1_0(v668.fields[0]);
            }
            else {
                const v675: string = method12();
                const v684: Mut4 = new Mut4(method13());
                let v695: any;
                closure9(v684, `${toText(interpolate("%A%P()", [US0_US0_2()]))}`, undefined);
                v695 = undefined;
                const v702: string = item(0, split(v684.l0, [v675], undefined, 0));
                const v706: Mut4 = new Mut4(method13());
                let v717: any;
                closure9(v706, `${toText(interpolate("%A%P()", [US0_US0_3()]))}`, undefined);
                v717 = undefined;
                const v720: string = v706.l0;
                const v727: US1_$union = (v720.indexOf(v702) === 0) ? US1_US1_0("Info") : US1_US1_1();
                v737 = ((v727.tag === /* US1_0 */ 0) ? US1_US1_0(v727.fields[0]) : US1_US1_0("Warning"));
            }
        }
        let v741: string;
        if (v737.tag === /* US1_0 */ 0) {
            v741 = v737.fields[0];
        }
        else {
            throw new Error("Option does not have a value.");
        }
        const v797: string = ("\u001b[93m" + padLeft(v741.toLocaleLowerCase(), 7, " ")) + method14();
        const v812: int64 = patternInput_2[0].l0;
        const v814: Mut4 = new Mut4(method13());
        let v821: any;
        closure9(v814, `${"{ "}`, undefined);
        v821 = undefined;
        let v830: any;
        closure9(v814, `${"error"}`, undefined);
        v830 = undefined;
        let v839: any;
        closure9(v814, `${" = "}`, undefined);
        v839 = undefined;
        let v847: any;
        closure9(v814, `${v0_1}`, undefined);
        v847 = undefined;
        let v856: any;
        closure9(v814, `${" }"}`, undefined);
        v856 = undefined;
        const v859: string = v814.l0;
        const v898: string = trimEnd(trimStart(`${v344} ${v797} #${v812} ${closure63(undefined, undefined)} / ${v859}`, ...[]), ...[" ", "/"]);
        closure11(undefined, v898);
        patternInput[1].l0(v898);
    }
}

export function method51(): string {
    return defaultOf();
}

export function closure60(unitVar: void, unitVar_1: void): string {
    const v4: US13_$union = method47(method32("polyglot", ".devcontainer"), "C:\\home\\git\\polyglot\\lib\\spiral");
    let v934: US1_$union;
    if (v4.tag === /* US13_0 */ 0) {
        v934 = US1_US1_0(v4.fields[0]);
    }
    else {
        let v10: any;
        closure62(v4.fields[0], undefined);
        v10 = undefined;
        v934 = US1_US1_1();
    }
    let v1871: US1_$union;
    if (v934.tag === /* US1_0 */ 0) {
        v1871 = US1_US1_0(v934.fields[0]);
    }
    else {
        const v937: string = method51();
        const v939: US13_$union = method47(method32("polyglot", ".devcontainer"), v937);
        if (v939.tag === /* US13_0 */ 0) {
            v1871 = US1_US1_0(v939.fields[0]);
        }
        else {
            let v945: any;
            closure62(v939.fields[0], undefined);
            v945 = undefined;
            v1871 = US1_US1_1();
        }
    }
    return method32((v1871.tag === /* US1_0 */ 0) ? v1871.fields[0] : (() => {
        throw new Error("Option does not have a value.");
    })(), "polyglot");
}

export function method52(v0_1: string): void {
}

export function closure65(unitVar: void, v0_1: string): void {
    method52(v0_1);
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
    return method32(v0_1, v1_1);
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


