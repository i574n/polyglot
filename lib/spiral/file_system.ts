import { compare, defaultOf, IComparable, IEquatable, IDisposable, createAtom } from "../../deps/Fable/src/fable-library-ts/Util.js";
import { defaultArg, value as value_3, Option } from "../../deps/Fable/src/fable-library-ts/Option.js";
import { op_Subtraction, op_Addition, toInt64, int64 } from "../../deps/Fable/src/fable-library-ts/BigInt.js";
import { bool_type, lambda_type, unit_type, string_type, record_type, int64_type, union_type, class_type, TypeInfo } from "../../deps/Fable/src/fable-library-ts/Reflection.js";
import { FSharpRef, Record, Union } from "../../deps/Fable/src/fable-library-ts/Types.js";
import { create, toString, now, getTicks } from "../../deps/Fable/src/fable-library-ts/Date.js";
import * as fs from "fs";
import { milliseconds, seconds, minutes, fromTicks, toString as toString_1, hours } from "../../deps/Fable/src/fable-library-ts/TimeSpan.js";
import { int32, uint8 } from "../../deps/Fable/src/fable-library-ts/Int32.js";
import { newGuid, parse } from "../../deps/Fable/src/fable-library-ts/Guid.js";
import * as path from "path";
import { replace, trimStart, trimEnd, padLeft, interpolate, toText } from "../../deps/Fable/src/fable-library-ts/String.js";
import { ofSeq, find } from "../../deps/Fable/src/fable-library-ts/Map.js";

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

export function method7(v0_1: string): string {
    return v0_1;
}

export function method8(v0_1: string): boolean {
    const v23_1: IFsExistsSync = fs;
    return v23_1.existsSync(v0_1);
}

export function method6(v0_1: boolean, v1: string): void {
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

export function closure2(unitVar: void, unitVar_1: void): string {
    return "file_system.delete_directory_async";
}

export function method5(v0_1: string, v1: int64): any {
    return defaultOf();
}

export function closure1(unitVar: void, v0_1: string): any {
    return defaultOf();
}

export function closure5(unitVar: void, unitVar_1: void): string {
    return "file_system.wait_for_file_access";
}

export function method14(v0_1: string, v1: US8_$union, v2: US7_$union, v3: int64): any {
    return defaultOf();
}

export function closure4(v0_1: US6_$union, v1: string): any {
    return defaultOf();
}

export function closure3(unitVar: void, v0_1: US6_$union): ((arg0: string) => any) {
    return (v: string): any => closure4(v0_1, v);
}

export function method15(v0_1: string, v1: int64): any {
    return defaultOf();
}

export function closure6(unitVar: void, v0_1: string): any {
    return defaultOf();
}

export function closure7(unitVar: void, v0_1: string): any {
    return defaultOf();
}

export function method17(v0_1: string): boolean {
    const v20_1: IFsExistsSync = fs;
    return v20_1.existsSync(v0_1);
}

export function method18(v0_1: any): any {
    return v0_1;
}

export function method16(v0_1: string, v1: string): boolean {
    return defaultOf();
}

export function closure9(v0_1: string, v1: string): boolean {
    return method16(v0_1, v1);
}

export function closure8(unitVar: void, v0_1: string): ((arg0: string) => boolean) {
    return (v: string): boolean => closure9(v0_1, v);
}

export function closure11(v0_1: string, v1: string): any {
    return defaultOf();
}

export function closure10(unitVar: void, v0_1: string): ((arg0: string) => any) {
    return (v: string): any => closure11(v0_1, v);
}

export function closure13(v0_1: string, v1: string): any {
    return defaultOf();
}

export function closure12(unitVar: void, v0_1: string): ((arg0: string) => any) {
    return (v: string): any => closure13(v0_1, v);
}

export function closure15(unitVar: void, unitVar_1: void): string {
    return "delete_file_async";
}

export function method19(v0_1: string, v1: int64): any {
    return defaultOf();
}

export function closure14(unitVar: void, v0_1: string): any {
    return defaultOf();
}

export function closure18(unitVar: void, unitVar_1: void): string {
    return "move_file_async";
}

export function method20(v0_1: string, v1: string, v2: int64): any {
    return defaultOf();
}

export function closure17(v0_1: string, v1: string): any {
    return defaultOf();
}

export function closure16(unitVar: void, v0_1: string): ((arg0: string) => any) {
    return (v: string): any => closure17(v0_1, v);
}

export function closure20(unitVar: void, v0_1: int64): US9_$union {
    return US9_US9_0(v0_1);
}

export function closure21(unitVar: void, v0_1: Error): US9_$union {
    return US9_US9_1(v0_1);
}

export function closure22(unitVar: void, unitVar_1: void): string {
    return "async.run_with_timeout_async";
}

export function closure23(unitVar: void, unitVar_1: void): string {
    return "async.run_with_timeout_async**";
}

export function closure24(unitVar: void, unitVar_1: void): string {
    return "read_all_text_retry_async";
}

export function method21(v0_1: string, v1: int64): any {
    return defaultOf();
}

export function closure19(unitVar: void, v0_1: string): any {
    return defaultOf();
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

export function method23(v0_1: string, v1: Date): string {
    const v328: string = toString(v1, method25());
    const v340: any = defaultOf();
    let v397: number;
    throw new Error(`date_time.get_utc_offset / target: ${US5_US5_3(US4_US4_0())}`);
    const v408: uint8 = (hours(v397) > 0) ? 1 : 0;
    const v409: string = method26();
    const v420 = `${v408}${toString_1(v397, "c", {})}`;
    const v422: string = v0_1;
    return parse(`${v328}${v420}${v422.slice(v328.length + v420.length, v422.length)}`);
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

export function method31(v0_1: string, v1: string): [string, string] {
    return [v1, method32(v0_1)] as [string, string];
}

export function method30(v0_1: string, v1: string): string {
    const v48: IPathJoin = path;
    const patternInput: [string, string] = method31(v1, v0_1);
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

export function closure25(unitVar: void, unitVar_1: void): string {
    return method22();
}

export function method36(v0_1: string): string {
    return v0_1;
}

export function closure27(unitVar: void, v0_1: any): any {
    return defaultOf();
}

export function method37(): ((arg0: any) => any) {
    return (v: any): any => closure27(undefined, v);
}

export function closure28(unitVar: void, unitVar_1: void): US12_$union {
    return US12_US12_0();
}

export function closure29(unitVar: void, v0_1: any): US12_$union {
    return US12_US12_1(v0_1);
}

export function closure30(unitVar: void, unitVar_1: void): string {
    return "file_system.create_dir";
}

export function closure31(unitVar: void, unitVar_1: void): string {
    return "file_system.create_dir";
}

export function closure32(v0_1: string, unitVar: void): void {
    method6(true, v0_1);
}

export function method38(v0_1: string): (() => void) {
    return (): void => {
        closure32(v0_1, undefined);
    };
}

export function method39(v0_1: string): (() => void) {
    return (): void => {
        closure32(v0_1, undefined);
    };
}

export function closure33(unitVar: void, unitVar_1: void): string {
    return "file_system.create_dir";
}

export function closure34(v0_1: string, unitVar: void): void {
    const v11: any = defaultOf();
    const v34: any = defaultOf();
    defaultOf();
}

export function method40(v0_1: string): (() => void) {
    return (): void => {
        closure34(v0_1, undefined);
    };
}

export function method41(v0_1: string): (() => void) {
    return (): void => {
        closure34(v0_1, undefined);
    };
}

export function method35(v0_1: string): IDisposable {
    let v1772: int64, v1782: number;
    const v1438: any = defaultOf();
    const v1468: boolean = defaultOf();
    if (v1468 === false) {
        const v1497: string = toText(interpolate("%A%P()", [{
            CreationTime: defaultOf(),
            Exists: v1468,
        }]));
        if (State_trace_state() == null) {
            const patternInput: [Mut0, Mut1, Mut2, Mut3, Option<int64>] = method0(US0_US0_0());
            State_trace_state([patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4]] as [Mut0, Mut1, Mut2, Mut3, Option<int64>]);
        }
        const patternInput_1: [Mut0, Mut1, Mut2, Mut3, Option<int64>] = value_3(State_trace_state());
        const v1512: Mut0 = patternInput_1[0];
        if (State_trace_state() == null) {
            const patternInput_2: [Mut0, Mut1, Mut2, Mut3, Option<int64>] = method0(US0_US0_0());
            State_trace_state([patternInput_2[0], patternInput_2[1], patternInput_2[2], patternInput_2[3], patternInput_2[4]] as [Mut0, Mut1, Mut2, Mut3, Option<int64>]);
        }
        const patternInput_3: [Mut0, Mut1, Mut2, Mut3, Option<int64>] = value_3(State_trace_state());
        const v1554: US0_$union = patternInput_3[3].l0;
        if ((patternInput_3[2].l0 === false) ? false : (1 >= find<US0_$union, int32>(v1554, ofSeq([[US0_US0_0(), 0] as [US0_$union, int32], [US0_US0_1(), 1] as [US0_$union, int32], [US0_US0_2(), 2] as [US0_$union, int32], [US0_US0_3(), 3] as [US0_$union, int32], [US0_US0_4(), 4] as [US0_$union, int32]], {
            Compare: compare,
        })))) {
            const v1561: int64 = toInt64(op_Addition(v1512.l0, 1n));
            v1512.l0 = v1561;
            if (State_trace_state() == null) {
                const patternInput_4: [Mut0, Mut1, Mut2, Mut3, Option<int64>] = method0(US0_US0_0());
                State_trace_state([patternInput_4[0], patternInput_4[1], patternInput_4[2], patternInput_4[3], patternInput_4[4]] as [Mut0, Mut1, Mut2, Mut3, Option<int64>]);
            }
            const patternInput_5: [Mut0, Mut1, Mut2, Mut3, Option<int64>] = value_3(State_trace_state());
            const v1578: Option<int64> = patternInput_5[4];
            const _v1753: FSharpRef<Option<US3_$union>> = new FSharpRef<Option<US3_$union>>(undefined);
            let x_3: Option<US3_$union>;
            if (v1578 == null) {
                x_3 = undefined;
            }
            else {
                const x_1: int64 = value_3(v1578);
                x_3 = ((): US3_$union => US3_US3_0(x_1))();
            }
            _v1753.contents = x_3;
            const v1768: US3_$union = defaultArg(_v1753.contents, US3_US3_1());
            const v1813: string = toString((v1768.tag === /* US3_0 */ 0) ? ((v1772 = v1768.fields[0], (v1782 = fromTicks(toInt64(op_Subtraction(getTicks(now()), v1772))), create(1, 1, 1, hours(v1782), minutes(v1782), seconds(v1782), milliseconds(v1782))))) : now(), method10());
            const v2063: string = ("\u001b[94m" + padLeft("Debug".toLocaleLowerCase(), 7, " ")) + method11();
            const v2078: int64 = patternInput_5[0].l0;
            const v2080: Mut4 = new Mut4(method13());
            const v2082 = `${"{ "}`;
            const v2086: string = v2080.l0 + v2082;
            v2080.l0 = v2086;
            const v2088 = `${"dir"}`;
            const v2092: string = v2080.l0 + v2088;
            v2080.l0 = v2092;
            const v2094 = `${" = "}`;
            const v2098: string = v2080.l0 + v2094;
            v2080.l0 = v2098;
            const v2099 = `${v0_1}`;
            const v2103: string = v2080.l0 + v2099;
            v2080.l0 = v2103;
            const v2105 = `${"; "}`;
            const v2109: string = v2080.l0 + v2105;
            v2080.l0 = v2109;
            const v2111 = `${"result"}`;
            const v2115: string = v2080.l0 + v2111;
            v2080.l0 = v2115;
            const v2116 = `${" = "}`;
            const v2120: string = v2080.l0 + v2116;
            v2080.l0 = v2120;
            const v2121 = `${v1497}`;
            const v2125: string = v2080.l0 + v2121;
            v2080.l0 = v2125;
            const v2127 = `${" }"}`;
            const v2131: string = v2080.l0 + v2127;
            v2080.l0 = v2131;
            const v2132: string = v2080.l0;
            const v2171: string = trimEnd(trimStart(`${v1813} ${v2063} #${v2078} ${closure33(undefined, undefined)} / ${v2132}`, ...[]), ...[" ", "/"]);
            console.log(v2171);
            patternInput_1[1].l0(v2171);
        }
    }
    const v2201: (() => void) = method41(v0_1);
    return {
        Dispose(): void {
            v2201();
        },
    };
}

export function closure26(unitVar: void, unitVar_1: void): [string, IDisposable] {
    const v0_1: string = method22();
    return [v0_1, method35(v0_1)] as [string, IDisposable];
}

export function method42(v0_1: string): string {
    const v39: string = padLeft(v0_1, 32, "0");
    return parse(`${v39.slice(0, 7 + 1)}-${v39.slice(8, 11 + 1)}-${v39.slice(12, 15 + 1)}-${v39.slice(16, 19 + 1)}-${v39.slice(20, 31 + 1)}`);
}

export function closure35(unitVar: void, v0_1: string): [string, IDisposable] {
    const v2: string = method27(method42(v0_1));
    return [v2, method35(v2)] as [string, IDisposable];
}

export function closure36(unitVar: void, unitVar_1: void): string {
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

export function closure37(unitVar: void, v0_1: string): string {
    return method43(v0_1);
}

export function closure38(unitVar: void, v0_1: string): string {
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

export function closure40(unitVar: void, v0_1: string): Option<string> {
    return method47(v0_1);
}

export function method46(): ((arg0: string) => Option<string>) {
    return (v: string): Option<string> => closure40(undefined, v);
}

export function method48(v0_1_mut: string, v1_mut: string, v2_mut: string): US13_$union {
    method48:
    while (true) {
        const v0_1: string = v0_1_mut, v1: string = v1_mut, v2: string = v2_mut;
        if (method8(method30(v2, v0_1))) {
            return US13_US13_0(v2);
        }
        else {
            const v7: Option<string> = method46()(v2);
            const _v8: FSharpRef<Option<US1_$union>> = new FSharpRef<Option<US1_$union>>(undefined);
            let x_2: Option<US1_$union>;
            if (v7 == null) {
                x_2 = undefined;
            }
            else {
                const x: string = value_3(v7);
                x_2 = ((): US1_$union => US1_US1_0(x))();
            }
            _v8.contents = x_2;
            const v23_1: US1_$union = defaultArg(_v8.contents, US1_US1_1());
            if (v23_1.tag === /* US1_0 */ 0) {
                v0_1_mut = v0_1;
                v1_mut = v1;
                v2_mut = v23_1.fields[0];
                continue method48;
            }
            else {
                return US13_US13_1(`No parent for ${"dir"} '${v0_1}' at '${v1}' (until '${v2}')`);
            }
        }
        break;
    }
}

export function method45(v0_1: string, v1: string): US13_$union {
    if (method8(method30(v1, v0_1))) {
        return US13_US13_0(v1);
    }
    else {
        const v6: Option<string> = method46()(v1);
        const _v7: FSharpRef<Option<US1_$union>> = new FSharpRef<Option<US1_$union>>(undefined);
        let x_2: Option<US1_$union>;
        if (v6 == null) {
            x_2 = undefined;
        }
        else {
            const x: string = value_3(v6);
            x_2 = ((): US1_$union => US1_US1_0(x))();
        }
        _v7.contents = x_2;
        const v22_1: US1_$union = defaultArg(_v7.contents, US1_US1_1());
        if (v22_1.tag === /* US1_0 */ 0) {
            return method48(v0_1, v1, v22_1.fields[0]);
        }
        else {
            return US13_US13_1(`No parent for ${"dir"} '${v0_1}' at '${v1}' (until '${v1}')`);
        }
    }
}

export function closure41(unitVar: void, unitVar_1: void): string {
    return "file_system.get_workspace_root";
}

export function method49(): string {
    return defaultOf();
}

export function closure39(unitVar: void, unitVar_1: void): string {
    let v280: int64, v290: number, v963: int64, v973: number;
    const v4: US13_$union = method45(method30("polyglot", ".devcontainer"), "C:\\home\\git\\polyglot\\lib\\spiral");
    let v682: US1_$union;
    if (v4.tag === /* US13_0 */ 0) {
        v682 = US1_US1_0(v4.fields[0]);
    }
    else {
        const v7: string = v4.fields[0];
        if (State_trace_state() == null) {
            const patternInput: [Mut0, Mut1, Mut2, Mut3, Option<int64>] = method0(US0_US0_0());
            State_trace_state([patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4]] as [Mut0, Mut1, Mut2, Mut3, Option<int64>]);
        }
        const patternInput_1: [Mut0, Mut1, Mut2, Mut3, Option<int64>] = value_3(State_trace_state());
        const v20_1: Mut0 = patternInput_1[0];
        if (State_trace_state() == null) {
            const patternInput_2: [Mut0, Mut1, Mut2, Mut3, Option<int64>] = method0(US0_US0_0());
            State_trace_state([patternInput_2[0], patternInput_2[1], patternInput_2[2], patternInput_2[3], patternInput_2[4]] as [Mut0, Mut1, Mut2, Mut3, Option<int64>]);
        }
        const patternInput_3: [Mut0, Mut1, Mut2, Mut3, Option<int64>] = value_3(State_trace_state());
        const v62: US0_$union = patternInput_3[3].l0;
        if ((patternInput_3[2].l0 === false) ? false : (3 >= find<US0_$union, int32>(v62, ofSeq([[US0_US0_0(), 0] as [US0_$union, int32], [US0_US0_1(), 1] as [US0_$union, int32], [US0_US0_2(), 2] as [US0_$union, int32], [US0_US0_3(), 3] as [US0_$union, int32], [US0_US0_4(), 4] as [US0_$union, int32]], {
            Compare: compare,
        })))) {
            const v69: int64 = toInt64(op_Addition(v20_1.l0, 1n));
            v20_1.l0 = v69;
            if (State_trace_state() == null) {
                const patternInput_4: [Mut0, Mut1, Mut2, Mut3, Option<int64>] = method0(US0_US0_0());
                State_trace_state([patternInput_4[0], patternInput_4[1], patternInput_4[2], patternInput_4[3], patternInput_4[4]] as [Mut0, Mut1, Mut2, Mut3, Option<int64>]);
            }
            const patternInput_5: [Mut0, Mut1, Mut2, Mut3, Option<int64>] = value_3(State_trace_state());
            const v86: Option<int64> = patternInput_5[4];
            const _v261: FSharpRef<Option<US3_$union>> = new FSharpRef<Option<US3_$union>>(undefined);
            let x_3: Option<US3_$union>;
            if (v86 == null) {
                x_3 = undefined;
            }
            else {
                const x_1: int64 = value_3(v86);
                x_3 = ((): US3_$union => US3_US3_0(x_1))();
            }
            _v261.contents = x_3;
            const v276: US3_$union = defaultArg(_v261.contents, US3_US3_1());
            const v321: string = toString((v276.tag === /* US3_0 */ 0) ? ((v280 = v276.fields[0], (v290 = fromTicks(toInt64(op_Subtraction(getTicks(now()), v280))), create(1, 1, 1, hours(v290), minutes(v290), seconds(v290), milliseconds(v290))))) : now(), method10());
            const v571: string = ("\u001b[93m" + padLeft("Warning".toLocaleLowerCase(), 7, " ")) + method11();
            const v586: int64 = patternInput_5[0].l0;
            const v588: Mut4 = new Mut4(method13());
            const v590 = `${"{ "}`;
            const v594: string = v588.l0 + v590;
            v588.l0 = v594;
            const v596 = `${"error"}`;
            const v600: string = v588.l0 + v596;
            v588.l0 = v600;
            const v602 = `${" = "}`;
            const v606: string = v588.l0 + v602;
            v588.l0 = v606;
            const v607 = `${v7}`;
            const v611: string = v588.l0 + v607;
            v588.l0 = v611;
            const v613 = `${" }"}`;
            const v617: string = v588.l0 + v613;
            v588.l0 = v617;
            const v618: string = v588.l0;
            const v657: string = trimEnd(trimStart(`${v321} ${v571} #${v586} ${closure41(undefined, undefined)} / ${v618}`, ...[]), ...[" ", "/"]);
            console.log(v657);
            patternInput_1[1].l0(v657);
        }
        v682 = US1_US1_1();
    }
    let v1367: US1_$union;
    if (v682.tag === /* US1_0 */ 0) {
        v1367 = US1_US1_0(v682.fields[0]);
    }
    else {
        const v685: string = method49();
        const v687: US13_$union = method45(method30("polyglot", ".devcontainer"), v685);
        if (v687.tag === /* US13_0 */ 0) {
            v1367 = US1_US1_0(v687.fields[0]);
        }
        else {
            const v690: string = v687.fields[0];
            if (State_trace_state() == null) {
                const patternInput_6: [Mut0, Mut1, Mut2, Mut3, Option<int64>] = method0(US0_US0_0());
                State_trace_state([patternInput_6[0], patternInput_6[1], patternInput_6[2], patternInput_6[3], patternInput_6[4]] as [Mut0, Mut1, Mut2, Mut3, Option<int64>]);
            }
            const patternInput_7: [Mut0, Mut1, Mut2, Mut3, Option<int64>] = value_3(State_trace_state());
            const v703: Mut0 = patternInput_7[0];
            if (State_trace_state() == null) {
                const patternInput_8: [Mut0, Mut1, Mut2, Mut3, Option<int64>] = method0(US0_US0_0());
                State_trace_state([patternInput_8[0], patternInput_8[1], patternInput_8[2], patternInput_8[3], patternInput_8[4]] as [Mut0, Mut1, Mut2, Mut3, Option<int64>]);
            }
            const patternInput_9: [Mut0, Mut1, Mut2, Mut3, Option<int64>] = value_3(State_trace_state());
            const v745: US0_$union = patternInput_9[3].l0;
            if ((patternInput_9[2].l0 === false) ? false : (3 >= find<US0_$union, int32>(v745, ofSeq([[US0_US0_0(), 0] as [US0_$union, int32], [US0_US0_1(), 1] as [US0_$union, int32], [US0_US0_2(), 2] as [US0_$union, int32], [US0_US0_3(), 3] as [US0_$union, int32], [US0_US0_4(), 4] as [US0_$union, int32]], {
                Compare: compare,
            })))) {
                const v752: int64 = toInt64(op_Addition(v703.l0, 1n));
                v703.l0 = v752;
                if (State_trace_state() == null) {
                    const patternInput_10: [Mut0, Mut1, Mut2, Mut3, Option<int64>] = method0(US0_US0_0());
                    State_trace_state([patternInput_10[0], patternInput_10[1], patternInput_10[2], patternInput_10[3], patternInput_10[4]] as [Mut0, Mut1, Mut2, Mut3, Option<int64>]);
                }
                const patternInput_11: [Mut0, Mut1, Mut2, Mut3, Option<int64>] = value_3(State_trace_state());
                const v769: Option<int64> = patternInput_11[4];
                const _v944: FSharpRef<Option<US3_$union>> = new FSharpRef<Option<US3_$union>>(undefined);
                let x_7: Option<US3_$union>;
                if (v769 == null) {
                    x_7 = undefined;
                }
                else {
                    const x_5: int64 = value_3(v769);
                    x_7 = ((): US3_$union => US3_US3_0(x_5))();
                }
                _v944.contents = x_7;
                const v959: US3_$union = defaultArg(_v944.contents, US3_US3_1());
                const v1004: string = toString((v959.tag === /* US3_0 */ 0) ? ((v963 = v959.fields[0], (v973 = fromTicks(toInt64(op_Subtraction(getTicks(now()), v963))), create(1, 1, 1, hours(v973), minutes(v973), seconds(v973), milliseconds(v973))))) : now(), method10());
                const v1254: string = ("\u001b[93m" + padLeft("Warning".toLocaleLowerCase(), 7, " ")) + method11();
                const v1269: int64 = patternInput_11[0].l0;
                const v1271: Mut4 = new Mut4(method13());
                const v1273 = `${"{ "}`;
                const v1277: string = v1271.l0 + v1273;
                v1271.l0 = v1277;
                const v1279 = `${"error"}`;
                const v1283: string = v1271.l0 + v1279;
                v1271.l0 = v1283;
                const v1285 = `${" = "}`;
                const v1289: string = v1271.l0 + v1285;
                v1271.l0 = v1289;
                const v1290 = `${v690}`;
                const v1294: string = v1271.l0 + v1290;
                v1271.l0 = v1294;
                const v1296 = `${" }"}`;
                const v1300: string = v1271.l0 + v1296;
                v1271.l0 = v1300;
                const v1301: string = v1271.l0;
                const v1340: string = trimEnd(trimStart(`${v1004} ${v1254} #${v1269} ${closure41(undefined, undefined)} / ${v1301}`, ...[]), ...[" ", "/"]);
                console.log(v1340);
                patternInput_7[1].l0(v1340);
            }
            v1367 = US1_US1_1();
        }
    }
    return method30((v1367.tag === /* US1_0 */ 0) ? v1367.fields[0] : (() => {
        throw new Error("Option does not have a value.");
    })(), "polyglot");
}

export function method50(v0_1: string): void {
}

export function closure43(unitVar: void, v0_1: string): void {
    method50(v0_1);
}

export function closure42(unitVar: void, v0_1: boolean): void {
    if (State_trace_state() == null) {
        const patternInput: [Mut0, Mut1, Mut2, Mut3, Option<int64>] = method0(US0_US0_0());
        State_trace_state([patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4]] as [Mut0, Mut1, Mut2, Mut3, Option<int64>]);
    }
    const patternInput_1: [Mut0, Mut1, Mut2, Mut3, Option<int64>] = value_3(State_trace_state());
    const v30_1: ((arg0: string) => void) = v0_1 ? ((v: string): void => {
        closure43(undefined, v);
    }) : ((v_1: string): void => {
        closure0(undefined, v_1);
    });
    patternInput_1[1].l0 = v30_1;
}

export function closure45(v0_1: string, v1: string): string {
    return method30(v0_1, v1);
}

export function closure44(unitVar: void, v0_1: string): ((arg0: string) => string) {
    return (v: string): string => closure45(v0_1, v);
}

export const v0: boolean = State_trace_state() == null;

if (v0) {
    const patternInput: [Mut0, Mut1, Mut2, Mut3, Option<int64>] = method0(US0_US0_0());
    State_trace_state([patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4]] as [Mut0, Mut1, Mut2, Mut3, Option<int64>]);
}

export const v12 = (v: string): any => closure1(undefined, v);

export function delete_directory_async(x: string): any {
    return v12(x);
}

export const v13 = (v: US6_$union): ((arg0: string) => any) => closure3(undefined, v);

export function wait_for_file_access(x: US6_$union): ((arg0: string) => any) {
    return v13(x);
}

export const v14 = (v: string): any => closure6(undefined, v);

export function wait_for_file_access_read(x: string): any {
    return v14(x);
}

export const v15 = (v: string): any => closure7(undefined, v);

export function read_all_text_async(x: string): any {
    return v15(x);
}

export const v16 = (v: string): ((arg0: string) => boolean) => closure8(undefined, v);

export function file_exists_content(x: string): ((arg0: string) => boolean) {
    return v16(x);
}

export const v17 = (v: string): ((arg0: string) => any) => closure10(undefined, v);

export function write_all_text_async(x: string): ((arg0: string) => any) {
    return v17(x);
}

export const v18 = (v: string): ((arg0: string) => any) => closure12(undefined, v);

export function write_all_text_exists(x: string): ((arg0: string) => any) {
    return v18(x);
}

export const v19 = (v: string): any => closure14(undefined, v);

export function delete_file_async(x: string): any {
    return v19(x);
}

export const v20 = (v: string): ((arg0: string) => any) => closure16(undefined, v);

export function move_file_async(x: string): ((arg0: string) => any) {
    return v20(x);
}

export const v21 = (v: string): any => closure19(undefined, v);

export function read_all_text_retry_async(x: string): any {
    return v21(x);
}

export const v22 = (): string => closure25(undefined, undefined);

export function create_temp_path(): string {
    return v22();
}

export const v23 = (): [string, IDisposable] => closure26(undefined, undefined);

export function create_temp_dir(): [string, IDisposable] {
    return v23();
}

export const v24 = (v: string): [string, IDisposable] => closure35(undefined, v);

export function create_temp_dir$0027(x: string): [string, IDisposable] {
    return v24(x);
}

export const v25 = (): string => closure36(undefined, undefined);

export function get_source_directory(): string {
    return v25();
}

export const v26 = (v: string): string => closure37(undefined, v);

export function normalize_path(x: string): string {
    return v26(x);
}

export const v27 = (v: string): string => closure38(undefined, v);

export function new_file_uri(x: string): string {
    return v27(x);
}

export const v28 = (): string => closure39(undefined, undefined);

export function get_workspace_root(): string {
    return v28();
}

export const v29 = (v: boolean): void => {
    closure42(undefined, v);
};

export function init_trace_file(x: boolean): void {
    v29(x);
}

export const v30 = (v: string): ((arg0: string) => string) => closure44(undefined, v);

export function op_LessDivideGreater(x: string): ((arg0: string) => string) {
    return v30(x);
}


