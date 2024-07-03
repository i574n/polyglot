import { compare, defaultOf, IComparable, IEquatable, IDisposable, createAtom } from "../../deps/Fable/src/fable-library-ts/Util.js";
import { defaultArg, some, value as value_3, Option } from "../../deps/Fable/src/fable-library-ts/Option.js";
import { op_Addition, op_Subtraction, toInt64, int64 } from "../../deps/Fable/src/fable-library-ts/BigInt.js";
import { bool_type, lambda_type, unit_type, string_type, record_type, int64_type, union_type, class_type, TypeInfo } from "../../deps/Fable/src/fable-library-ts/Reflection.js";
import { FSharpRef, Record, Union } from "../../deps/Fable/src/fable-library-ts/Types.js";
import { create, toString, now, getTicks } from "../../deps/Fable/src/fable-library-ts/Date.js";
import * as fs from "fs";
import { toString as toString_1, milliseconds, seconds, minutes, hours, fromTicks } from "../../deps/Fable/src/fable-library-ts/TimeSpan.js";
import { replace, interpolate, toText, trimStart, trimEnd, padLeft } from "../../deps/Fable/src/fable-library-ts/String.js";
import { ofSeq, find } from "../../deps/Fable/src/fable-library-ts/Map.js";
import { uint8, int32 } from "../../deps/Fable/src/fable-library-ts/Int32.js";
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
    return union_type("File_system.US3", [], US3, () => [[["f0_0", string_type]], []]);
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
        return value_3(_v1);
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
        patternInput = value_3(_v1);
    }
    const v259: US2_$union = patternInput[1];
    const v258: US1_$union = patternInput[0];
    return [new Mut0(0n), new Mut1((v: string): void => {
        closure1(undefined, v);
    }), new Mut2(true), new Mut3((v258.tag === /* US1_0 */ 0) ? v258.fields[0] : v0_1), (v259.tag === /* US2_0 */ 0) ? v259.fields[0] : undefined] as [Mut0, Mut1, Mut2, Mut3, Option<int64>];
}

export function method6(v0_1: string): string {
    return v0_1;
}

export function method7(v0_1: string): boolean {
    let _v1: Option<boolean> = undefined;
    const v19_1: IFsExistsSync = fs;
    const x: boolean = v19_1.existsSync(v0_1);
    _v1 = x;
    if (_v1 == null) {
        throw new Error("base.run_target / _v1=None");
    }
    else {
        return value_3(_v1);
    }
}

export function method5(v0_1: boolean, v1_1: string): void {
    let _v2: Option<void> = undefined;
    defaultOf();
    _v2 = some(undefined);
    if (_v2 == null) {
        throw new Error("base.run_target / _v2=None");
    }
    else {
        value_3(_v2);
    }
}

export function closure3(unitVar: void, unitVar_1: void): string {
    return "file_system.delete_directory_async";
}

export function method8(v0_1: string): string {
    let _v1: Option<string> = undefined;
    let x: string;
    throw new Error(`file_system.get_file_name / target: ${US5_US5_3(US4_US4_0())} / path: ${v0_1}`);
    _v1 = x;
    if (_v1 == null) {
        throw new Error("base.run_target / _v1=None");
    }
    else {
        return value_3(_v1);
    }
}

export function closure4(v0_1: string, v1_1: string, unitVar: void): [string, string] {
    return [v1_1, method8(v0_1)] as [string, string];
}

export function method10(): string {
    return "hh:mm:ss";
}

export function method11(): string {
    return "";
}

export function method12(): string {
    return "HH:mm:ss";
}

export function method13(): string {
    return "\u001b[0m";
}

export function method15(v0_1: Mut4, v1_1: string): void {
    const v2_1 = `${v1_1}`;
    const v4_1: string = v0_1.l0 + v2_1;
    v0_1.l0 = v4_1;
}

export function method16(v0_1: Mut4): void {
}

export function method14(v0_1: Mut4, v1_1: string, v2_1: string): void {
    method15(v0_1, "{ ");
    method16(v0_1);
    method15(v0_1, "ex");
    method15(v0_1, " = ");
    method15(v0_1, v1_1);
    method15(v0_1, "; ");
    method15(v0_1, "path");
    method15(v0_1, " = ");
    method15(v0_1, v2_1);
    method15(v0_1, " }");
}

export function closure5(v0_1: US0_$union, v1_1: (() => string), v2_1: (() => [string, string]), unitVar: void): string {
    let v74: int64, v80: number;
    if (State_trace_state() == null) {
        State_trace_state(closure0(undefined, US0_US0_0()));
    }
    const patternInput: [Mut0, Mut1, Mut2, Mut3, Option<int64>] = value_3(State_trace_state());
    const v9_1: Option<int64> = patternInput[4];
    let _v10: Option<string> = undefined;
    const _v68: FSharpRef<Option<US2_$union>> = new FSharpRef<Option<US2_$union>>(undefined);
    let x_2: Option<US2_$union>;
    if (v9_1 == null) {
        x_2 = undefined;
    }
    else {
        const x: int64 = value_3(v9_1);
        x_2 = ((): US2_$union => US2_US2_0(x))();
    }
    _v68.contents = x_2;
    const v73: US2_$union = defaultArg(_v68.contents, US2_US2_1());
    const x_3: string = toString((v73.tag === /* US2_0 */ 0) ? ((v74 = v73.fields[0], (v80 = fromTicks(toInt64(op_Subtraction(getTicks(now()), v74))), create(1, 1, 1, hours(v80), minutes(v80), seconds(v80), milliseconds(v80))))) : now(), method12());
    _v10 = x_3;
    let v152: string;
    if (_v10 == null) {
        throw new Error("base.run_target / _v10=None");
    }
    else {
        v152 = value_3(_v10);
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
    const x_5: string = (((v0_1.tag === /* US0_1 */ 1) ? "\u001b[94m" : ((v0_1.tag === /* US0_2 */ 2) ? "\u001b[92m" : ((v0_1.tag === /* US0_0 */ 0) ? "\u001b[90m" : ((v0_1.tag === /* US0_3 */ 3) ? "\u001b[93m" : "\u001b[91m")))) + v215) + method13();
    _v216 = x_5;
    let v328: string;
    if (_v216 == null) {
        throw new Error("base.run_target / _v216=None");
    }
    else {
        v328 = value_3(_v216);
    }
    const v329: int64 = patternInput[0].l0;
    const patternInput_1: [string, string] = v2_1();
    const v333: Mut4 = new Mut4("");
    method14(v333, patternInput_1[0], patternInput_1[1]);
    const v334: string = v333.l0;
    return trimEnd(trimStart(`${v152} ${v328} #${v329} ${v1_1()} / ${v334}`, ...[]), ...[" ", "/"]);
}

export function method17(v0_1: US0_$union, v1_1: (() => string)): void {
    const v2_1 = (v: US0_$union): [Mut0, Mut1, Mut2, Mut3, Option<int64>] => closure0(undefined, v);
    if (State_trace_state() == null) {
        State_trace_state(v2_1(US0_US0_0()));
    }
    const patternInput: [Mut0, Mut1, Mut2, Mut3, Option<int64>] = value_3(State_trace_state());
    const v4_1: Mut0 = patternInput[0];
    if (State_trace_state() == null) {
        State_trace_state(v2_1(US0_US0_0()));
    }
    const patternInput_1: [Mut0, Mut1, Mut2, Mut3, Option<int64>] = value_3(State_trace_state());
    const v15_1: US0_$union = patternInput_1[3].l0;
    if ((patternInput_1[2].l0 === false) ? false : (find<US0_$union, int32>(v0_1, ofSeq([[US0_US0_0(), 0] as [US0_$union, int32], [US0_US0_1(), 1] as [US0_$union, int32], [US0_US0_2(), 2] as [US0_$union, int32], [US0_US0_3(), 3] as [US0_$union, int32], [US0_US0_4(), 4] as [US0_$union, int32]], {
        Compare: compare,
    })) >= find<US0_$union, int32>(v15_1, ofSeq([[US0_US0_0(), 0] as [US0_$union, int32], [US0_US0_1(), 1] as [US0_$union, int32], [US0_US0_2(), 2] as [US0_$union, int32], [US0_US0_3(), 3] as [US0_$union, int32], [US0_US0_4(), 4] as [US0_$union, int32]], {
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
            value_3(_v25);
        }
        patternInput[1].l0(v24);
    }
}

export function method9(v0_1: US0_$union, v1_1: (() => string), v2_1: (() => [string, string])): void {
    method17(v0_1, (): string => closure5(v0_1, v1_1, v2_1, undefined));
}

export function method4(v0_1: string, v1_1: int64): any {
    let _v2: Option<any> = undefined;
    const x: any = defaultOf();
    _v2 = x;
    if (_v2 == null) {
        throw new Error("base.run_target / _v2=None");
    }
    else {
        return value_3(_v2);
    }
}

export function closure2(unitVar: void, v0_1: string): any {
    let _v1: Option<any> = undefined;
    const x: any = defaultOf();
    _v1 = x;
    if (_v1 == null) {
        throw new Error("base.run_target / _v1=None");
    }
    else {
        return value_3(_v1);
    }
}

export function closure8(unitVar: void, unitVar_1: void): string {
    return "file_system.wait_for_file_access";
}

export function closure9(v0_1: string, v1_1: int64, v2_1: string, unitVar: void): [string, int64, string] {
    return [method8(v0_1), v1_1, v2_1] as [string, int64, string];
}

export function method21(v0_1: Mut4, v1_1: int64): void {
    const v2_1 = `${v1_1}`;
    const v4_1: string = v0_1.l0 + v2_1;
    v0_1.l0 = v4_1;
}

export function method20(v0_1: Mut4, v1_1: string, v2_1: int64, v3_1: string): void {
    method15(v0_1, "{ ");
    method16(v0_1);
    method15(v0_1, "path");
    method15(v0_1, " = ");
    method15(v0_1, v1_1);
    method15(v0_1, "; ");
    method15(v0_1, "retry");
    method15(v0_1, " = ");
    method21(v0_1, v2_1);
    method15(v0_1, "; ");
    method15(v0_1, "ex");
    method15(v0_1, " = ");
    method15(v0_1, v3_1);
    method15(v0_1, " }");
}

export function closure10(v0_1: US0_$union, v1_1: (() => string), v2_1: (() => [string, int64, string]), unitVar: void): string {
    let v74: int64, v80: number;
    if (State_trace_state() == null) {
        State_trace_state(closure0(undefined, US0_US0_0()));
    }
    const patternInput: [Mut0, Mut1, Mut2, Mut3, Option<int64>] = value_3(State_trace_state());
    const v9_1: Option<int64> = patternInput[4];
    let _v10: Option<string> = undefined;
    const _v68: FSharpRef<Option<US2_$union>> = new FSharpRef<Option<US2_$union>>(undefined);
    let x_2: Option<US2_$union>;
    if (v9_1 == null) {
        x_2 = undefined;
    }
    else {
        const x: int64 = value_3(v9_1);
        x_2 = ((): US2_$union => US2_US2_0(x))();
    }
    _v68.contents = x_2;
    const v73: US2_$union = defaultArg(_v68.contents, US2_US2_1());
    const x_3: string = toString((v73.tag === /* US2_0 */ 0) ? ((v74 = v73.fields[0], (v80 = fromTicks(toInt64(op_Subtraction(getTicks(now()), v74))), create(1, 1, 1, hours(v80), minutes(v80), seconds(v80), milliseconds(v80))))) : now(), method12());
    _v10 = x_3;
    let v152: string;
    if (_v10 == null) {
        throw new Error("base.run_target / _v10=None");
    }
    else {
        v152 = value_3(_v10);
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
    const x_5: string = (((v0_1.tag === /* US0_1 */ 1) ? "\u001b[94m" : ((v0_1.tag === /* US0_2 */ 2) ? "\u001b[92m" : ((v0_1.tag === /* US0_0 */ 0) ? "\u001b[90m" : ((v0_1.tag === /* US0_3 */ 3) ? "\u001b[93m" : "\u001b[91m")))) + v215) + method13();
    _v216 = x_5;
    let v328: string;
    if (_v216 == null) {
        throw new Error("base.run_target / _v216=None");
    }
    else {
        v328 = value_3(_v216);
    }
    const v329: int64 = patternInput[0].l0;
    const patternInput_1: [string, int64, string] = v2_1();
    const v334: Mut4 = new Mut4("");
    method20(v334, patternInput_1[0], patternInput_1[1], patternInput_1[2]);
    const v335: string = v334.l0;
    return trimEnd(trimStart(`${v152} ${v328} #${v329} ${v1_1()} / ${v335}`, ...[]), ...[" ", "/"]);
}

export function method19(v0_1: US0_$union, v1_1: (() => string), v2_1: (() => [string, int64, string])): void {
    method17(v0_1, (): string => closure10(v0_1, v1_1, v2_1, undefined));
}

export function method18(v0_1: string, v1_1: US8_$union, v2_1: US7_$union, v3_1: int64): any {
    let _v4: Option<any> = undefined;
    const x: any = defaultOf();
    _v4 = x;
    if (_v4 == null) {
        throw new Error("base.run_target / _v4=None");
    }
    else {
        return value_3(_v4);
    }
}

export function closure7(v0_1: US6_$union, v1_1: string): any {
    let _v2: Option<any> = undefined;
    const x: any = defaultOf();
    _v2 = x;
    if (_v2 == null) {
        throw new Error("base.run_target / _v2=None");
    }
    else {
        return value_3(_v2);
    }
}

export function closure6(unitVar: void, v0_1: US6_$union): ((arg0: string) => any) {
    return (v: string): any => closure7(v0_1, v);
}

export function method22(v0_1: string, v1_1: int64): any {
    let _v2: Option<any> = undefined;
    const x: any = defaultOf();
    _v2 = x;
    if (_v2 == null) {
        throw new Error("base.run_target / _v2=None");
    }
    else {
        return value_3(_v2);
    }
}

export function closure11(unitVar: void, v0_1: string): any {
    let _v1: Option<any> = undefined;
    const x: any = defaultOf();
    _v1 = x;
    if (_v1 == null) {
        throw new Error("base.run_target / _v1=None");
    }
    else {
        return value_3(_v1);
    }
}

export function closure12(unitVar: void, v0_1: string): any {
    let _v1: Option<any> = undefined;
    const x: any = defaultOf();
    _v1 = x;
    if (_v1 == null) {
        throw new Error("base.run_target / _v1=None");
    }
    else {
        return value_3(_v1);
    }
}

export function method24(v0_1: string): boolean {
    let _v1: Option<boolean> = undefined;
    const v16_1: IFsExistsSync = fs;
    const x: boolean = v16_1.existsSync(v0_1);
    _v1 = x;
    if (_v1 == null) {
        throw new Error("base.run_target / _v1=None");
    }
    else {
        return value_3(_v1);
    }
}

export function method25(v0_1: any): any {
    return v0_1;
}

export function method23(v0_1: string, v1_1: string): boolean {
    let _v2: Option<boolean> = undefined;
    const x: boolean = defaultOf();
    _v2 = x;
    if (_v2 == null) {
        throw new Error("base.run_target / _v2=None");
    }
    else {
        return value_3(_v2);
    }
}

export function closure14(v0_1: string, v1_1: string): boolean {
    return method23(v0_1, v1_1);
}

export function closure13(unitVar: void, v0_1: string): ((arg0: string) => boolean) {
    return (v: string): boolean => closure14(v0_1, v);
}

export function closure16(v0_1: string, v1_1: string): any {
    let _v2: Option<any> = undefined;
    const x: any = defaultOf();
    _v2 = x;
    if (_v2 == null) {
        throw new Error("base.run_target / _v2=None");
    }
    else {
        return value_3(_v2);
    }
}

export function closure15(unitVar: void, v0_1: string): ((arg0: string) => any) {
    return (v: string): any => closure16(v0_1, v);
}

export function closure18(v0_1: string, v1_1: string): any {
    let _v2: Option<any> = undefined;
    const x: any = defaultOf();
    _v2 = x;
    if (_v2 == null) {
        throw new Error("base.run_target / _v2=None");
    }
    else {
        return value_3(_v2);
    }
}

export function closure17(unitVar: void, v0_1: string): ((arg0: string) => any) {
    return (v: string): any => closure18(v0_1, v);
}

export function closure20(unitVar: void, unitVar_1: void): string {
    return "delete_file_async";
}

export function closure21(v0_1: string, v1_1: Error, unitVar: void): [string, string] {
    const v2_1: string = method8(v0_1);
    let _v3: Option<string> = undefined;
    const x: string = toText(interpolate("%A%P()", [v1_1]));
    _v3 = x;
    return [v2_1, (_v3 == null) ? (() => {
        throw new Error("base.run_target / _v3=None");
    })() : value_3(_v3)] as [string, string];
}

export function method28(v0_1: Mut4, v1_1: string, v2_1: string): void {
    method15(v0_1, "{ ");
    method16(v0_1);
    method15(v0_1, "path");
    method15(v0_1, " = ");
    method15(v0_1, v1_1);
    method15(v0_1, "; ");
    method15(v0_1, "ex");
    method15(v0_1, " = ");
    method15(v0_1, v2_1);
    method15(v0_1, " }");
}

export function closure22(v0_1: US0_$union, v1_1: (() => string), v2_1: (() => [string, string]), unitVar: void): string {
    let v74: int64, v80: number;
    if (State_trace_state() == null) {
        State_trace_state(closure0(undefined, US0_US0_0()));
    }
    const patternInput: [Mut0, Mut1, Mut2, Mut3, Option<int64>] = value_3(State_trace_state());
    const v9_1: Option<int64> = patternInput[4];
    let _v10: Option<string> = undefined;
    const _v68: FSharpRef<Option<US2_$union>> = new FSharpRef<Option<US2_$union>>(undefined);
    let x_2: Option<US2_$union>;
    if (v9_1 == null) {
        x_2 = undefined;
    }
    else {
        const x: int64 = value_3(v9_1);
        x_2 = ((): US2_$union => US2_US2_0(x))();
    }
    _v68.contents = x_2;
    const v73: US2_$union = defaultArg(_v68.contents, US2_US2_1());
    const x_3: string = toString((v73.tag === /* US2_0 */ 0) ? ((v74 = v73.fields[0], (v80 = fromTicks(toInt64(op_Subtraction(getTicks(now()), v74))), create(1, 1, 1, hours(v80), minutes(v80), seconds(v80), milliseconds(v80))))) : now(), method12());
    _v10 = x_3;
    let v152: string;
    if (_v10 == null) {
        throw new Error("base.run_target / _v10=None");
    }
    else {
        v152 = value_3(_v10);
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
    const x_5: string = (((v0_1.tag === /* US0_1 */ 1) ? "\u001b[94m" : ((v0_1.tag === /* US0_2 */ 2) ? "\u001b[92m" : ((v0_1.tag === /* US0_0 */ 0) ? "\u001b[90m" : ((v0_1.tag === /* US0_3 */ 3) ? "\u001b[93m" : "\u001b[91m")))) + v215) + method13();
    _v216 = x_5;
    let v328: string;
    if (_v216 == null) {
        throw new Error("base.run_target / _v216=None");
    }
    else {
        v328 = value_3(_v216);
    }
    const v329: int64 = patternInput[0].l0;
    const patternInput_1: [string, string] = v2_1();
    const v333: Mut4 = new Mut4("");
    method28(v333, patternInput_1[0], patternInput_1[1]);
    const v334: string = v333.l0;
    return trimEnd(trimStart(`${v152} ${v328} #${v329} ${v1_1()} / ${v334}`, ...[]), ...[" ", "/"]);
}

export function method27(v0_1: US0_$union, v1_1: (() => string), v2_1: (() => [string, string])): void {
    method17(v0_1, (): string => closure22(v0_1, v1_1, v2_1, undefined));
}

export function method26(v0_1: string, v1_1: int64): any {
    let _v2: Option<any> = undefined;
    const x: any = defaultOf();
    _v2 = x;
    if (_v2 == null) {
        throw new Error("base.run_target / _v2=None");
    }
    else {
        return value_3(_v2);
    }
}

export function closure19(unitVar: void, v0_1: string): any {
    let _v1: Option<any> = undefined;
    const x: any = defaultOf();
    _v1 = x;
    if (_v1 == null) {
        throw new Error("base.run_target / _v1=None");
    }
    else {
        return value_3(_v1);
    }
}

export function closure25(unitVar: void, unitVar_1: void): string {
    return "move_file_async";
}

export function closure26(v0_1: string, v1_1: string, v2_1: Error, unitVar: void): [string, string, Error] {
    return [method8(v1_1), method8(v0_1), v2_1] as [string, string, Error];
}

export function method32(v0_1: Mut4, v1_1: Error): void {
    method15(v0_1, toText(interpolate("%A%P()", [v1_1])));
}

export function method31(v0_1: Mut4, v1_1: string, v2_1: string, v3_1: Error): void {
    method15(v0_1, "{ ");
    method16(v0_1);
    method15(v0_1, "old_path");
    method15(v0_1, " = ");
    method15(v0_1, v1_1);
    method15(v0_1, "; ");
    method15(v0_1, "new_path");
    method15(v0_1, " = ");
    method15(v0_1, v2_1);
    method15(v0_1, "; ");
    method15(v0_1, "ex");
    method15(v0_1, " = ");
    method32(v0_1, v3_1);
    method15(v0_1, " }");
}

export function closure27(v0_1: US0_$union, v1_1: (() => string), v2_1: (() => [string, string, Error]), unitVar: void): string {
    let v74: int64, v80: number;
    if (State_trace_state() == null) {
        State_trace_state(closure0(undefined, US0_US0_0()));
    }
    const patternInput: [Mut0, Mut1, Mut2, Mut3, Option<int64>] = value_3(State_trace_state());
    const v9_1: Option<int64> = patternInput[4];
    let _v10: Option<string> = undefined;
    const _v68: FSharpRef<Option<US2_$union>> = new FSharpRef<Option<US2_$union>>(undefined);
    let x_2: Option<US2_$union>;
    if (v9_1 == null) {
        x_2 = undefined;
    }
    else {
        const x: int64 = value_3(v9_1);
        x_2 = ((): US2_$union => US2_US2_0(x))();
    }
    _v68.contents = x_2;
    const v73: US2_$union = defaultArg(_v68.contents, US2_US2_1());
    const x_3: string = toString((v73.tag === /* US2_0 */ 0) ? ((v74 = v73.fields[0], (v80 = fromTicks(toInt64(op_Subtraction(getTicks(now()), v74))), create(1, 1, 1, hours(v80), minutes(v80), seconds(v80), milliseconds(v80))))) : now(), method12());
    _v10 = x_3;
    let v152: string;
    if (_v10 == null) {
        throw new Error("base.run_target / _v10=None");
    }
    else {
        v152 = value_3(_v10);
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
    const x_5: string = (((v0_1.tag === /* US0_1 */ 1) ? "\u001b[94m" : ((v0_1.tag === /* US0_2 */ 2) ? "\u001b[92m" : ((v0_1.tag === /* US0_0 */ 0) ? "\u001b[90m" : ((v0_1.tag === /* US0_3 */ 3) ? "\u001b[93m" : "\u001b[91m")))) + v215) + method13();
    _v216 = x_5;
    let v328: string;
    if (_v216 == null) {
        throw new Error("base.run_target / _v216=None");
    }
    else {
        v328 = value_3(_v216);
    }
    const v329: int64 = patternInput[0].l0;
    const patternInput_1: [string, string, Error] = v2_1();
    const v334: Mut4 = new Mut4("");
    method31(v334, patternInput_1[0], patternInput_1[1], patternInput_1[2]);
    const v335: string = v334.l0;
    return trimEnd(trimStart(`${v152} ${v328} #${v329} ${v1_1()} / ${v335}`, ...[]), ...[" ", "/"]);
}

export function method30(v0_1: US0_$union, v1_1: (() => string), v2_1: (() => [string, string, Error])): void {
    method17(v0_1, (): string => closure27(v0_1, v1_1, v2_1, undefined));
}

export function method29(v0_1: string, v1_1: string, v2_1: int64): any {
    let _v3: Option<any> = undefined;
    const x: any = defaultOf();
    _v3 = x;
    if (_v3 == null) {
        throw new Error("base.run_target / _v3=None");
    }
    else {
        return value_3(_v3);
    }
}

export function closure24(v0_1: string, v1_1: string): any {
    let _v2: Option<any> = undefined;
    const x: any = defaultOf();
    _v2 = x;
    if (_v2 == null) {
        throw new Error("base.run_target / _v2=None");
    }
    else {
        return value_3(_v2);
    }
}

export function closure23(unitVar: void, v0_1: string): ((arg0: string) => any) {
    return (v: string): any => closure24(v0_1, v);
}

export function closure29(unitVar: void, v0_1: int64): US9_$union {
    return US9_US9_0(v0_1);
}

export function closure30(unitVar: void, v0_1: Error): US9_$union {
    return US9_US9_1(v0_1);
}

export function closure31(unitVar: void, unitVar_1: void): string {
    return "async.run_with_timeout_async";
}

export function closure32(unitVar: void, unitVar_1: void): int32 {
    return 1000;
}

export function method36(v0_1: Mut4, v1_1: int32): void {
    const v2_1 = `${v1_1}`;
    const v4_1: string = v0_1.l0 + v2_1;
    v0_1.l0 = v4_1;
}

export function method35(v0_1: Mut4, v1_1: int32): void {
    method15(v0_1, "{ ");
    method16(v0_1);
    method15(v0_1, "timeout");
    method15(v0_1, " = ");
    method36(v0_1, v1_1);
    method15(v0_1, " }");
}

export function closure33(v0_1: US0_$union, v1_1: (() => string), v2_1: (() => int32), unitVar: void): string {
    let v74: int64, v80: number;
    if (State_trace_state() == null) {
        State_trace_state(closure0(undefined, US0_US0_0()));
    }
    const patternInput: [Mut0, Mut1, Mut2, Mut3, Option<int64>] = value_3(State_trace_state());
    const v9_1: Option<int64> = patternInput[4];
    let _v10: Option<string> = undefined;
    const _v68: FSharpRef<Option<US2_$union>> = new FSharpRef<Option<US2_$union>>(undefined);
    let x_2: Option<US2_$union>;
    if (v9_1 == null) {
        x_2 = undefined;
    }
    else {
        const x: int64 = value_3(v9_1);
        x_2 = ((): US2_$union => US2_US2_0(x))();
    }
    _v68.contents = x_2;
    const v73: US2_$union = defaultArg(_v68.contents, US2_US2_1());
    const x_3: string = toString((v73.tag === /* US2_0 */ 0) ? ((v74 = v73.fields[0], (v80 = fromTicks(toInt64(op_Subtraction(getTicks(now()), v74))), create(1, 1, 1, hours(v80), minutes(v80), seconds(v80), milliseconds(v80))))) : now(), method12());
    _v10 = x_3;
    let v152: string;
    if (_v10 == null) {
        throw new Error("base.run_target / _v10=None");
    }
    else {
        v152 = value_3(_v10);
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
    const x_5: string = (((v0_1.tag === /* US0_1 */ 1) ? "\u001b[94m" : ((v0_1.tag === /* US0_2 */ 2) ? "\u001b[92m" : ((v0_1.tag === /* US0_0 */ 0) ? "\u001b[90m" : ((v0_1.tag === /* US0_3 */ 3) ? "\u001b[93m" : "\u001b[91m")))) + v215) + method13();
    _v216 = x_5;
    let v328: string;
    if (_v216 == null) {
        throw new Error("base.run_target / _v216=None");
    }
    else {
        v328 = value_3(_v216);
    }
    const v329: int64 = patternInput[0].l0;
    const v332: Mut4 = new Mut4("");
    method35(v332, v2_1());
    const v333: string = v332.l0;
    return trimEnd(trimStart(`${v152} ${v328} #${v329} ${v1_1()} / ${v333}`, ...[]), ...[" ", "/"]);
}

export function method34(v0_1: US0_$union, v1_1: (() => string), v2_1: (() => int32)): void {
    method17(v0_1, (): string => closure33(v0_1, v1_1, v2_1, undefined));
}

export function closure34(unitVar: void, unitVar_1: void): string {
    return "async.run_with_timeout_async**";
}

export function closure35(v0_1: Error, unitVar: void): [int32, string] {
    let _v1: Option<string> = undefined;
    const x: string = toText(interpolate("%A%P()", [v0_1]));
    _v1 = x;
    return [1000, (_v1 == null) ? (() => {
        throw new Error("base.run_target / _v1=None");
    })() : value_3(_v1)] as [int32, string];
}

export function method38(v0_1: Mut4, v1_1: int32, v2_1: string): void {
    method15(v0_1, "{ ");
    method16(v0_1);
    method15(v0_1, "timeout");
    method15(v0_1, " = ");
    method36(v0_1, v1_1);
    method15(v0_1, "; ");
    method15(v0_1, "ex");
    method15(v0_1, " = ");
    method15(v0_1, v2_1);
    method15(v0_1, " }");
}

export function closure36(v0_1: US0_$union, v1_1: (() => string), v2_1: (() => [int32, string]), unitVar: void): string {
    let v74: int64, v80: number;
    if (State_trace_state() == null) {
        State_trace_state(closure0(undefined, US0_US0_0()));
    }
    const patternInput: [Mut0, Mut1, Mut2, Mut3, Option<int64>] = value_3(State_trace_state());
    const v9_1: Option<int64> = patternInput[4];
    let _v10: Option<string> = undefined;
    const _v68: FSharpRef<Option<US2_$union>> = new FSharpRef<Option<US2_$union>>(undefined);
    let x_2: Option<US2_$union>;
    if (v9_1 == null) {
        x_2 = undefined;
    }
    else {
        const x: int64 = value_3(v9_1);
        x_2 = ((): US2_$union => US2_US2_0(x))();
    }
    _v68.contents = x_2;
    const v73: US2_$union = defaultArg(_v68.contents, US2_US2_1());
    const x_3: string = toString((v73.tag === /* US2_0 */ 0) ? ((v74 = v73.fields[0], (v80 = fromTicks(toInt64(op_Subtraction(getTicks(now()), v74))), create(1, 1, 1, hours(v80), minutes(v80), seconds(v80), milliseconds(v80))))) : now(), method12());
    _v10 = x_3;
    let v152: string;
    if (_v10 == null) {
        throw new Error("base.run_target / _v10=None");
    }
    else {
        v152 = value_3(_v10);
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
    const x_5: string = (((v0_1.tag === /* US0_1 */ 1) ? "\u001b[94m" : ((v0_1.tag === /* US0_2 */ 2) ? "\u001b[92m" : ((v0_1.tag === /* US0_0 */ 0) ? "\u001b[90m" : ((v0_1.tag === /* US0_3 */ 3) ? "\u001b[93m" : "\u001b[91m")))) + v215) + method13();
    _v216 = x_5;
    let v328: string;
    if (_v216 == null) {
        throw new Error("base.run_target / _v216=None");
    }
    else {
        v328 = value_3(_v216);
    }
    const v329: int64 = patternInput[0].l0;
    const patternInput_1: [int32, string] = v2_1();
    const v333: Mut4 = new Mut4("");
    method38(v333, patternInput_1[0], patternInput_1[1]);
    const v334: string = v333.l0;
    return trimEnd(trimStart(`${v152} ${v328} #${v329} ${v1_1()} / ${v334}`, ...[]), ...[" ", "/"]);
}

export function method37(v0_1: US0_$union, v1_1: (() => string), v2_1: (() => [int32, string])): void {
    method17(v0_1, (): string => closure36(v0_1, v1_1, v2_1, undefined));
}

export function closure37(unitVar: void, unitVar_1: void): string {
    return "read_all_text_retry_async";
}

export function closure38(v0_1: int64, v1_1: string, unitVar: void): [int64, string] {
    return [v0_1, v1_1] as [int64, string];
}

export function method40(v0_1: Mut4, v1_1: int64, v2_1: string): void {
    method15(v0_1, "{ ");
    method16(v0_1);
    method15(v0_1, "retry");
    method15(v0_1, " = ");
    method21(v0_1, v1_1);
    method15(v0_1, "; ");
    method15(v0_1, "ex");
    method15(v0_1, " = ");
    method15(v0_1, v2_1);
    method15(v0_1, " }");
}

export function closure39(v0_1: US0_$union, v1_1: (() => string), v2_1: (() => [int64, string]), unitVar: void): string {
    let v74: int64, v80: number;
    if (State_trace_state() == null) {
        State_trace_state(closure0(undefined, US0_US0_0()));
    }
    const patternInput: [Mut0, Mut1, Mut2, Mut3, Option<int64>] = value_3(State_trace_state());
    const v9_1: Option<int64> = patternInput[4];
    let _v10: Option<string> = undefined;
    const _v68: FSharpRef<Option<US2_$union>> = new FSharpRef<Option<US2_$union>>(undefined);
    let x_2: Option<US2_$union>;
    if (v9_1 == null) {
        x_2 = undefined;
    }
    else {
        const x: int64 = value_3(v9_1);
        x_2 = ((): US2_$union => US2_US2_0(x))();
    }
    _v68.contents = x_2;
    const v73: US2_$union = defaultArg(_v68.contents, US2_US2_1());
    const x_3: string = toString((v73.tag === /* US2_0 */ 0) ? ((v74 = v73.fields[0], (v80 = fromTicks(toInt64(op_Subtraction(getTicks(now()), v74))), create(1, 1, 1, hours(v80), minutes(v80), seconds(v80), milliseconds(v80))))) : now(), method12());
    _v10 = x_3;
    let v152: string;
    if (_v10 == null) {
        throw new Error("base.run_target / _v10=None");
    }
    else {
        v152 = value_3(_v10);
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
    const x_5: string = (((v0_1.tag === /* US0_1 */ 1) ? "\u001b[94m" : ((v0_1.tag === /* US0_2 */ 2) ? "\u001b[92m" : ((v0_1.tag === /* US0_0 */ 0) ? "\u001b[90m" : ((v0_1.tag === /* US0_3 */ 3) ? "\u001b[93m" : "\u001b[91m")))) + v215) + method13();
    _v216 = x_5;
    let v328: string;
    if (_v216 == null) {
        throw new Error("base.run_target / _v216=None");
    }
    else {
        v328 = value_3(_v216);
    }
    const v329: int64 = patternInput[0].l0;
    const patternInput_1: [int64, string] = v2_1();
    const v333: Mut4 = new Mut4("");
    method40(v333, patternInput_1[0], patternInput_1[1]);
    const v334: string = v333.l0;
    return trimEnd(trimStart(`${v152} ${v328} #${v329} ${v1_1()} / ${v334}`, ...[]), ...[" ", "/"]);
}

export function method39(v0_1: US0_$union, v1_1: (() => string), v2_1: (() => [int64, string])): void {
    method17(v0_1, (): string => closure39(v0_1, v1_1, v2_1, undefined));
}

export function method33(v0_1: string, v1_1: int64): any {
    let _v2: Option<any> = undefined;
    const x: any = defaultOf();
    _v2 = x;
    if (_v2 == null) {
        throw new Error("base.run_target / _v2=None");
    }
    else {
        return value_3(_v2);
    }
}

export function closure28(unitVar: void, v0_1: string): any {
    let _v1: Option<any> = undefined;
    const x: any = defaultOf();
    _v1 = x;
    if (_v1 == null) {
        throw new Error("base.run_target / _v1=None");
    }
    else {
        return value_3(_v1);
    }
}

export function method43(v0_1: any): any {
    return v0_1;
}

export function method44(v0_1: any): any {
    return v0_1;
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

export function method42(v0_1: string, v1_1: Date): string {
    let _v2: Option<string> = undefined;
    const v202: string = toString(v1_1, method46());
    let _v203: Option<any> = undefined;
    const x: any = defaultOf();
    _v203 = x;
    let v211: any;
    if (_v203 == null) {
        throw new Error("base.run_target / _v203=None");
    }
    else {
        v211 = value_3(_v203);
    }
    let _v212: Option<number> = undefined;
    let x_2: number;
    throw new Error(`date_time.get_utc_offset / target: ${US5_US5_3(US4_US4_0())}`);
    _v212 = x_2;
    let v239: number;
    if (_v212 == null) {
        throw new Error("base.run_target / _v212=None");
    }
    else {
        v239 = value_3(_v212);
    }
    const v243: uint8 = (hours(v239) > 0) ? 1 : 0;
    const v244: string = method47();
    let _v245: Option<string> = undefined;
    const x_4: string = toString_1(v239, "c", {});
    _v245 = x_4;
    const v253 = `${v243}${(_v245 == null) ? (() => {
        throw new Error("base.run_target / _v245=None");
    })() : value_3(_v245)}`;
    const v255: string = v0_1;
    const x_6: string = parse(`${v202}${v253}${v255.slice(v202.length + v253.length, v255.length)}`);
    _v2 = x_6;
    if (_v2 == null) {
        throw new Error("base.run_target / _v2=None");
    }
    else {
        return value_3(_v2);
    }
}

export function method49(): string {
    let _v0: Option<string> = undefined;
    let x: string;
    throw new Error(`file_system.get_temp_path / target: ${US5_US5_3(US4_US4_0())}`);
    _v0 = x;
    if (_v0 == null) {
        throw new Error("base.run_target / _v0=None");
    }
    else {
        return value_3(_v0);
    }
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
    let _v2: Option<string> = undefined;
    const v36: IPathJoin = path;
    const patternInput: [string, string] = method52(v1_1, v0_1);
    const x: string = v36.join(patternInput[0], patternInput[1]);
    _v2 = x;
    if (_v2 == null) {
        throw new Error("base.run_target / _v2=None");
    }
    else {
        return value_3(_v2);
    }
}

export function method55(): string {
    return "CARGO_PKG_NAME";
}

export function method54(): string {
    let _v0: Option<string> = undefined;
    let x: string;
    throw new Error(`env.get_entry_assembly_name / target: ${US5_US5_3(US4_US4_0())}`);
    _v0 = x;
    if (_v0 == null) {
        throw new Error("base.run_target / _v0=None");
    }
    else {
        return value_3(_v0);
    }
}

export function method48(v0_1: string): string {
    let _v1: Option<string> = undefined;
    const x: string = method51(method51(method51(method49(), method50()), method54()), v0_1);
    _v1 = x;
    if (_v1 == null) {
        throw new Error("base.run_target / _v1=None");
    }
    else {
        return value_3(_v1);
    }
}

export function method41(): string {
    let _v0: Option<string> = undefined;
    const v12_1: Date = now();
    const x: string = method48(method42(newGuid(), v12_1));
    _v0 = x;
    if (_v0 == null) {
        throw new Error("base.run_target / _v0=None");
    }
    else {
        return value_3(_v0);
    }
}

export function closure40(unitVar: void, unitVar_1: void): string {
    return method41();
}

export function method57(v0_1: string): string {
    return v0_1;
}

export function closure42(unitVar: void, v0_1: any): any {
    let _v1: Option<any> = undefined;
    const x: any = defaultOf();
    _v1 = x;
    if (_v1 == null) {
        throw new Error("base.run_target / _v1=None");
    }
    else {
        return value_3(_v1);
    }
}

export function method58(): ((arg0: any) => any) {
    return (v: any): any => closure42(undefined, v);
}

export function closure43(unitVar: void, unitVar_1: void): US12_$union {
    return US12_US12_0();
}

export function closure44(unitVar: void, v0_1: any): US12_$union {
    return US12_US12_1(v0_1);
}

export function closure45(unitVar: void, unitVar_1: void): string {
    return "file_system.create_dir";
}

export function closure46(v0_1: string, v1_1: any, unitVar: void): [string, any] {
    return [v0_1, v1_1] as [string, any];
}

export function method61(v0_1: Mut4, v1_1: any): void {
    method15(v0_1, toText(interpolate("%A%P()", [v1_1])));
}

export function method60(v0_1: Mut4, v1_1: string, v2_1: any): void {
    method15(v0_1, "{ ");
    method16(v0_1);
    method15(v0_1, "dir");
    method15(v0_1, " = ");
    method15(v0_1, v1_1);
    method15(v0_1, "; ");
    method15(v0_1, "error");
    method15(v0_1, " = ");
    method61(v0_1, v2_1);
    method15(v0_1, " }");
}

export function closure47(v0_1: US0_$union, v1_1: (() => string), v2_1: (() => [string, any]), unitVar: void): string {
    let v74: int64, v80: number;
    if (State_trace_state() == null) {
        State_trace_state(closure0(undefined, US0_US0_0()));
    }
    const patternInput: [Mut0, Mut1, Mut2, Mut3, Option<int64>] = value_3(State_trace_state());
    const v9_1: Option<int64> = patternInput[4];
    let _v10: Option<string> = undefined;
    const _v68: FSharpRef<Option<US2_$union>> = new FSharpRef<Option<US2_$union>>(undefined);
    let x_2: Option<US2_$union>;
    if (v9_1 == null) {
        x_2 = undefined;
    }
    else {
        const x: int64 = value_3(v9_1);
        x_2 = ((): US2_$union => US2_US2_0(x))();
    }
    _v68.contents = x_2;
    const v73: US2_$union = defaultArg(_v68.contents, US2_US2_1());
    const x_3: string = toString((v73.tag === /* US2_0 */ 0) ? ((v74 = v73.fields[0], (v80 = fromTicks(toInt64(op_Subtraction(getTicks(now()), v74))), create(1, 1, 1, hours(v80), minutes(v80), seconds(v80), milliseconds(v80))))) : now(), method12());
    _v10 = x_3;
    let v152: string;
    if (_v10 == null) {
        throw new Error("base.run_target / _v10=None");
    }
    else {
        v152 = value_3(_v10);
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
    const x_5: string = (((v0_1.tag === /* US0_1 */ 1) ? "\u001b[94m" : ((v0_1.tag === /* US0_2 */ 2) ? "\u001b[92m" : ((v0_1.tag === /* US0_0 */ 0) ? "\u001b[90m" : ((v0_1.tag === /* US0_3 */ 3) ? "\u001b[93m" : "\u001b[91m")))) + v215) + method13();
    _v216 = x_5;
    let v328: string;
    if (_v216 == null) {
        throw new Error("base.run_target / _v216=None");
    }
    else {
        v328 = value_3(_v216);
    }
    const v329: int64 = patternInput[0].l0;
    const patternInput_1: [string, any] = v2_1();
    const v333: Mut4 = new Mut4("");
    method60(v333, patternInput_1[0], patternInput_1[1]);
    const v334: string = v333.l0;
    return trimEnd(trimStart(`${v152} ${v328} #${v329} ${v1_1()} / ${v334}`, ...[]), ...[" ", "/"]);
}

export function method59(v0_1: US0_$union, v1_1: (() => string), v2_1: (() => [string, any])): void {
    method17(v0_1, (): string => closure47(v0_1, v1_1, v2_1, undefined));
}

export function closure48(unitVar: void, unitVar_1: void): string {
    return "file_system.create_dir";
}

export function closure49(v0_1: string, unitVar: void): string {
    return v0_1;
}

export function method63(v0_1: Mut4, v1_1: string): void {
    method15(v0_1, "{ ");
    method16(v0_1);
    method15(v0_1, "dir");
    method15(v0_1, " = ");
    method15(v0_1, v1_1);
    method15(v0_1, " }");
}

export function closure50(v0_1: US0_$union, v1_1: (() => string), v2_1: (() => string), unitVar: void): string {
    let v74: int64, v80: number;
    if (State_trace_state() == null) {
        State_trace_state(closure0(undefined, US0_US0_0()));
    }
    const patternInput: [Mut0, Mut1, Mut2, Mut3, Option<int64>] = value_3(State_trace_state());
    const v9_1: Option<int64> = patternInput[4];
    let _v10: Option<string> = undefined;
    const _v68: FSharpRef<Option<US2_$union>> = new FSharpRef<Option<US2_$union>>(undefined);
    let x_2: Option<US2_$union>;
    if (v9_1 == null) {
        x_2 = undefined;
    }
    else {
        const x: int64 = value_3(v9_1);
        x_2 = ((): US2_$union => US2_US2_0(x))();
    }
    _v68.contents = x_2;
    const v73: US2_$union = defaultArg(_v68.contents, US2_US2_1());
    const x_3: string = toString((v73.tag === /* US2_0 */ 0) ? ((v74 = v73.fields[0], (v80 = fromTicks(toInt64(op_Subtraction(getTicks(now()), v74))), create(1, 1, 1, hours(v80), minutes(v80), seconds(v80), milliseconds(v80))))) : now(), method12());
    _v10 = x_3;
    let v152: string;
    if (_v10 == null) {
        throw new Error("base.run_target / _v10=None");
    }
    else {
        v152 = value_3(_v10);
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
    const x_5: string = (((v0_1.tag === /* US0_1 */ 1) ? "\u001b[94m" : ((v0_1.tag === /* US0_2 */ 2) ? "\u001b[92m" : ((v0_1.tag === /* US0_0 */ 0) ? "\u001b[90m" : ((v0_1.tag === /* US0_3 */ 3) ? "\u001b[93m" : "\u001b[91m")))) + v215) + method13();
    _v216 = x_5;
    let v328: string;
    if (_v216 == null) {
        throw new Error("base.run_target / _v216=None");
    }
    else {
        v328 = value_3(_v216);
    }
    const v329: int64 = patternInput[0].l0;
    const v332: Mut4 = new Mut4("");
    method63(v332, v2_1());
    const v333: string = v332.l0;
    return trimEnd(trimStart(`${v152} ${v328} #${v329} ${v1_1()} / ${v333}`, ...[]), ...[" ", "/"]);
}

export function method62(v0_1: US0_$union, v1_1: (() => string), v2_1: (() => string)): void {
    method17(v0_1, (): string => closure50(v0_1, v1_1, v2_1, undefined));
}

export function closure51(v0_1: string, unitVar: void): void {
    method5(true, v0_1);
}

export function method64(v0_1: string): (() => void) {
    return (): void => {
        closure51(v0_1, undefined);
    };
}

export function method65(v0_1: string): (() => void) {
    return (): void => {
        closure51(v0_1, undefined);
    };
}

export function closure52(unitVar: void, unitVar_1: void): string {
    return "file_system.create_dir";
}

export function closure53(v0_1: string, v1_1: string, unitVar: void): [string, string] {
    return [v0_1, v1_1] as [string, string];
}

export function method67(v0_1: Mut4, v1_1: string, v2_1: string): void {
    method15(v0_1, "{ ");
    method16(v0_1);
    method15(v0_1, "dir");
    method15(v0_1, " = ");
    method15(v0_1, v1_1);
    method15(v0_1, "; ");
    method15(v0_1, "result");
    method15(v0_1, " = ");
    method15(v0_1, v2_1);
    method15(v0_1, " }");
}

export function closure54(v0_1: US0_$union, v1_1: (() => string), v2_1: (() => [string, string]), unitVar: void): string {
    let v74: int64, v80: number;
    if (State_trace_state() == null) {
        State_trace_state(closure0(undefined, US0_US0_0()));
    }
    const patternInput: [Mut0, Mut1, Mut2, Mut3, Option<int64>] = value_3(State_trace_state());
    const v9_1: Option<int64> = patternInput[4];
    let _v10: Option<string> = undefined;
    const _v68: FSharpRef<Option<US2_$union>> = new FSharpRef<Option<US2_$union>>(undefined);
    let x_2: Option<US2_$union>;
    if (v9_1 == null) {
        x_2 = undefined;
    }
    else {
        const x: int64 = value_3(v9_1);
        x_2 = ((): US2_$union => US2_US2_0(x))();
    }
    _v68.contents = x_2;
    const v73: US2_$union = defaultArg(_v68.contents, US2_US2_1());
    const x_3: string = toString((v73.tag === /* US2_0 */ 0) ? ((v74 = v73.fields[0], (v80 = fromTicks(toInt64(op_Subtraction(getTicks(now()), v74))), create(1, 1, 1, hours(v80), minutes(v80), seconds(v80), milliseconds(v80))))) : now(), method12());
    _v10 = x_3;
    let v152: string;
    if (_v10 == null) {
        throw new Error("base.run_target / _v10=None");
    }
    else {
        v152 = value_3(_v10);
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
    const x_5: string = (((v0_1.tag === /* US0_1 */ 1) ? "\u001b[94m" : ((v0_1.tag === /* US0_2 */ 2) ? "\u001b[92m" : ((v0_1.tag === /* US0_0 */ 0) ? "\u001b[90m" : ((v0_1.tag === /* US0_3 */ 3) ? "\u001b[93m" : "\u001b[91m")))) + v215) + method13();
    _v216 = x_5;
    let v328: string;
    if (_v216 == null) {
        throw new Error("base.run_target / _v216=None");
    }
    else {
        v328 = value_3(_v216);
    }
    const v329: int64 = patternInput[0].l0;
    const patternInput_1: [string, string] = v2_1();
    const v333: Mut4 = new Mut4("");
    method67(v333, patternInput_1[0], patternInput_1[1]);
    const v334: string = v333.l0;
    return trimEnd(trimStart(`${v152} ${v328} #${v329} ${v1_1()} / ${v334}`, ...[]), ...[" ", "/"]);
}

export function method66(v0_1: US0_$union, v1_1: (() => string), v2_1: (() => [string, string])): void {
    method17(v0_1, (): string => closure54(v0_1, v1_1, v2_1, undefined));
}

export function closure55(v0_1: string, unitVar: void): void {
    let _v1: Option<any> = undefined;
    const x: any = defaultOf();
    _v1 = x;
    let v9_1: any;
    if (_v1 == null) {
        throw new Error("base.run_target / _v1=None");
    }
    else {
        v9_1 = value_3(_v1);
    }
    let _v10: Option<any> = undefined;
    const x_2: any = defaultOf();
    _v10 = x_2;
    let v18_1: any;
    if (_v10 == null) {
        throw new Error("base.run_target / _v10=None");
    }
    else {
        v18_1 = value_3(_v10);
    }
    let _v19: Option<void> = undefined;
    defaultOf();
    _v19 = some(undefined);
    if (_v19 == null) {
        throw new Error("base.run_target / _v19=None");
    }
    else {
        value_3(_v19);
    }
}

export function method68(v0_1: string): (() => void) {
    return (): void => {
        closure55(v0_1, undefined);
    };
}

export function method69(v0_1: string): (() => void) {
    return (): void => {
        closure55(v0_1, undefined);
    };
}

export function method56(v0_1: string): IDisposable {
    let _v1: Option<IDisposable> = undefined;
    let _v34: Option<any> = undefined;
    const x: any = defaultOf();
    _v34 = x;
    let v42: any;
    if (_v34 == null) {
        throw new Error("base.run_target / _v34=None");
    }
    else {
        v42 = value_3(_v34);
    }
    let _v43: Option<boolean> = undefined;
    const x_2: boolean = defaultOf();
    _v43 = x_2;
    let v50: boolean;
    if (_v43 == null) {
        throw new Error("base.run_target / _v43=None");
    }
    else {
        v50 = value_3(_v43);
    }
    if (v50 === false) {
        let _v52: Option<Date> = undefined;
        const x_4: Date = defaultOf();
        _v52 = x_4;
        const v61: string = toText(interpolate("%A%P()", [{
            CreationTime: (_v52 == null) ? (() => {
                throw new Error("base.run_target / _v52=None");
            })() : value_3(_v52),
            Exists: v50,
        }]));
        method66(US0_US0_1(), (): string => closure52(undefined, undefined), (): [string, string] => closure53(v0_1, v61, undefined));
    }
    let _v65: Option<IDisposable> = undefined;
    const v72: (() => void) = method69(v0_1);
    const x_6: IDisposable = {
        Dispose(): void {
            v72();
        },
    };
    _v65 = x_6;
    let x_8: IDisposable;
    if (_v65 == null) {
        throw new Error("base.run_target / _v65=None");
    }
    else {
        x_8 = value_3(_v65);
    }
    _v1 = x_8;
    if (_v1 == null) {
        throw new Error("base.run_target / _v1=None");
    }
    else {
        return value_3(_v1);
    }
}

export function closure41(unitVar: void, unitVar_1: void): [string, IDisposable] {
    const v0_1: string = method41();
    return [v0_1, method56(v0_1)] as [string, IDisposable];
}

export function method70(v0_1: string): string {
    let _v1: Option<string> = undefined;
    const v7_1: string = padLeft(v0_1, 32, "0");
    const x: string = parse(`${v7_1.slice(0, 7 + 1)}-${v7_1.slice(8, 11 + 1)}-${v7_1.slice(12, 15 + 1)}-${v7_1.slice(16, 19 + 1)}-${v7_1.slice(20, 31 + 1)}`);
    _v1 = x;
    if (_v1 == null) {
        throw new Error("base.run_target / _v1=None");
    }
    else {
        return value_3(_v1);
    }
}

export function closure56(unitVar: void, v0_1: string): [string, IDisposable] {
    const v2_1: string = method48(method70(v0_1));
    return [v2_1, method56(v2_1)] as [string, IDisposable];
}

export function closure57(unitVar: void, unitVar_1: void): string {
    return "C:\\home\\git\\polyglot\\lib\\spiral";
}

export function method72(): string {
    return "";
}

export function method73(v0_1: string): string {
    return v0_1;
}

export function method74(): string {
    return "^\\\\\\\\\\?\\\\";
}

export function method71(v0_1: string): string {
    let _arg: string;
    if (v0_1 === "") {
        return "";
    }
    else {
        const v4_1: string = method72();
        let _v5: Option<string> = undefined;
        const x: string = defaultOf();
        _v5 = x;
        let v24: string;
        if (_v5 == null) {
            throw new Error("base.run_target / _v5=None");
        }
        else {
            v24 = value_3(_v5);
        }
        return replace(`${(_arg = v24[0], _arg.toLocaleLowerCase())}${v24.slice(1, v24.length)}`, "\\", "/");
    }
}

export function closure58(unitVar: void, v0_1: string): string {
    return method71(v0_1);
}

export function closure59(unitVar: void, v0_1: string): string {
    return `file:///${trimStart(v0_1, ...["/"])}`;
}

export function method77(v0_1: string): Option<string> {
    let _v1: Option<US3_$union> = undefined;
    const v31: IPathDirname = path;
    const x: US3_$union = US3_US3_0(v31.dirname(v0_1));
    _v1 = x;
    let v51: US3_$union;
    if (_v1 == null) {
        throw new Error("base.run_target / _v1=None");
    }
    else {
        v51 = value_3(_v1);
    }
    if (v51.tag === /* US3_0 */ 0) {
        return v51.fields[0];
    }
    else {
        return undefined;
    }
}

export function closure61(unitVar: void, v0_1: string): Option<string> {
    return method77(v0_1);
}

export function method76(): ((arg0: string) => Option<string>) {
    return (v: string): Option<string> => closure61(undefined, v);
}

export function method78(v0_1_mut: string, v1_1_mut: string, v2_1_mut: string): US13_$union {
    method78:
    while (true) {
        const v0_1: string = v0_1_mut, v1_1: string = v1_1_mut, v2_1: string = v2_1_mut;
        if (method7(method51(v2_1, v0_1))) {
            return US13_US13_0(v2_1);
        }
        else {
            const v7_1: Option<string> = method76()(v2_1);
            const _v8: FSharpRef<Option<US3_$union>> = new FSharpRef<Option<US3_$union>>(undefined);
            let x_2: Option<US3_$union>;
            if (v7_1 == null) {
                x_2 = undefined;
            }
            else {
                const x: string = value_3(v7_1);
                x_2 = ((): US3_$union => US3_US3_0(x))();
            }
            _v8.contents = x_2;
            const v13_1: US3_$union = defaultArg(_v8.contents, US3_US3_1());
            if (v13_1.tag === /* US3_0 */ 0) {
                v0_1_mut = v0_1;
                v1_1_mut = v1_1;
                v2_1_mut = v13_1.fields[0];
                continue method78;
            }
            else {
                return US13_US13_1(`No parent for ${"dir"} '${v0_1}' at '${v1_1}' (until '${v2_1}')`);
            }
        }
        break;
    }
}

export function method75(v0_1: string, v1_1: string): US13_$union {
    if (method7(method51(v1_1, v0_1))) {
        return US13_US13_0(v1_1);
    }
    else {
        const v6_1: Option<string> = method76()(v1_1);
        const _v7: FSharpRef<Option<US3_$union>> = new FSharpRef<Option<US3_$union>>(undefined);
        let x_2: Option<US3_$union>;
        if (v6_1 == null) {
            x_2 = undefined;
        }
        else {
            const x: string = value_3(v6_1);
            x_2 = ((): US3_$union => US3_US3_0(x))();
        }
        _v7.contents = x_2;
        const v12_1: US3_$union = defaultArg(_v7.contents, US3_US3_1());
        if (v12_1.tag === /* US3_0 */ 0) {
            return method78(v0_1, v1_1, v12_1.fields[0]);
        }
        else {
            return US13_US13_1(`No parent for ${"dir"} '${v0_1}' at '${v1_1}' (until '${v1_1}')`);
        }
    }
}

export function closure62(unitVar: void, unitVar_1: void): string {
    return "file_system.get_workspace_root";
}

export function closure63(v0_1: string, unitVar: void): string {
    return v0_1;
}

export function method80(v0_1: Mut4, v1_1: string): void {
    method15(v0_1, "{ ");
    method16(v0_1);
    method15(v0_1, "error");
    method15(v0_1, " = ");
    method15(v0_1, v1_1);
    method15(v0_1, " }");
}

export function closure64(v0_1: US0_$union, v1_1: (() => string), v2_1: (() => string), unitVar: void): string {
    let v74: int64, v80: number;
    if (State_trace_state() == null) {
        State_trace_state(closure0(undefined, US0_US0_0()));
    }
    const patternInput: [Mut0, Mut1, Mut2, Mut3, Option<int64>] = value_3(State_trace_state());
    const v9_1: Option<int64> = patternInput[4];
    let _v10: Option<string> = undefined;
    const _v68: FSharpRef<Option<US2_$union>> = new FSharpRef<Option<US2_$union>>(undefined);
    let x_2: Option<US2_$union>;
    if (v9_1 == null) {
        x_2 = undefined;
    }
    else {
        const x: int64 = value_3(v9_1);
        x_2 = ((): US2_$union => US2_US2_0(x))();
    }
    _v68.contents = x_2;
    const v73: US2_$union = defaultArg(_v68.contents, US2_US2_1());
    const x_3: string = toString((v73.tag === /* US2_0 */ 0) ? ((v74 = v73.fields[0], (v80 = fromTicks(toInt64(op_Subtraction(getTicks(now()), v74))), create(1, 1, 1, hours(v80), minutes(v80), seconds(v80), milliseconds(v80))))) : now(), method12());
    _v10 = x_3;
    let v152: string;
    if (_v10 == null) {
        throw new Error("base.run_target / _v10=None");
    }
    else {
        v152 = value_3(_v10);
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
    const x_5: string = (((v0_1.tag === /* US0_1 */ 1) ? "\u001b[94m" : ((v0_1.tag === /* US0_2 */ 2) ? "\u001b[92m" : ((v0_1.tag === /* US0_0 */ 0) ? "\u001b[90m" : ((v0_1.tag === /* US0_3 */ 3) ? "\u001b[93m" : "\u001b[91m")))) + v215) + method13();
    _v216 = x_5;
    let v328: string;
    if (_v216 == null) {
        throw new Error("base.run_target / _v216=None");
    }
    else {
        v328 = value_3(_v216);
    }
    const v329: int64 = patternInput[0].l0;
    const v332: Mut4 = new Mut4("");
    method80(v332, v2_1());
    const v333: string = v332.l0;
    return trimEnd(trimStart(`${v152} ${v328} #${v329} ${v1_1()} / ${v333}`, ...[]), ...[" ", "/"]);
}

export function method79(v0_1: US0_$union, v1_1: (() => string), v2_1: (() => string)): void {
    method17(v0_1, (): string => closure64(v0_1, v1_1, v2_1, undefined));
}

export function method81(): string {
    let _v0: Option<string> = undefined;
    const x: string = defaultOf();
    _v0 = x;
    if (_v0 == null) {
        throw new Error("base.run_target / _v0=None");
    }
    else {
        return value_3(_v0);
    }
}

export function closure60(unitVar: void, unitVar_1: void): string {
    const v4_1: US13_$union = method75(method51("polyglot", ".devcontainer"), "C:\\home\\git\\polyglot\\lib\\spiral");
    let v13_1: US3_$union;
    if (v4_1.tag === /* US13_0 */ 0) {
        v13_1 = US3_US3_0(v4_1.fields[0]);
    }
    else {
        const v7_1: string = v4_1.fields[0];
        method79(US0_US0_3(), (): string => closure62(undefined, undefined), (): string => closure63(v7_1, undefined));
        v13_1 = US3_US3_1();
    }
    let v29: US3_$union;
    if (v13_1.tag === /* US3_0 */ 0) {
        v29 = US3_US3_0(v13_1.fields[0]);
    }
    else {
        const v16_1: string = method81();
        const v18_1: US13_$union = method75(method51("polyglot", ".devcontainer"), v16_1);
        if (v18_1.tag === /* US13_0 */ 0) {
            v29 = US3_US3_0(v18_1.fields[0]);
        }
        else {
            const v21: string = v18_1.fields[0];
            method79(US0_US0_3(), (): string => closure62(undefined, undefined), (): string => closure63(v21, undefined));
            v29 = US3_US3_1();
        }
    }
    return method51((v29.tag === /* US3_0 */ 0) ? v29.fields[0] : (() => {
        throw new Error("Option does not have a value.");
    })(), "polyglot");
}

export function method82(v0_1: string): void {
    let _v1: Option<void> = undefined;
    _v1 = some(undefined);
    if (_v1 == null) {
        throw new Error("base.run_target / _v1=None");
    }
    else {
        value_3(_v1);
    }
}

export function closure66(unitVar: void, v0_1: string): void {
    method82(v0_1);
}

export function closure65(unitVar: void, v0_1: boolean): void {
    if (State_trace_state() == null) {
        State_trace_state(closure0(undefined, US0_US0_0()));
    }
    const patternInput: [Mut0, Mut1, Mut2, Mut3, Option<int64>] = value_3(State_trace_state());
    const v10_1: ((arg0: string) => void) = v0_1 ? ((v_1: string): void => {
        closure66(undefined, v_1);
    }) : ((v_2: string): void => {
        closure1(undefined, v_2);
    });
    patternInput[1].l0 = v10_1;
}

export function closure68(v0_1: string, v1_1: string): string {
    return method51(v0_1, v1_1);
}

export function closure67(unitVar: void, v0_1: string): ((arg0: string) => string) {
    return (v: string): string => closure68(v0_1, v);
}

export const v0 = (v: US0_$union): [Mut0, Mut1, Mut2, Mut3, Option<int64>] => closure0(undefined, v);

export const v1: US0_$union = US0_US0_0();

if (State_trace_state() == null) {
    State_trace_state(v0(v1));
}

export const v2 = (v: string): any => closure2(undefined, v);

export function delete_directory_async(x: string): any {
    return v2(x);
}

export const v3 = (v: US6_$union): ((arg0: string) => any) => closure6(undefined, v);

export function wait_for_file_access(x: US6_$union): ((arg0: string) => any) {
    return v3(x);
}

export const v4 = (v: string): any => closure11(undefined, v);

export function wait_for_file_access_read(x: string): any {
    return v4(x);
}

export const v5 = (v: string): any => closure12(undefined, v);

export function read_all_text_async(x: string): any {
    return v5(x);
}

export const v6 = (v: string): ((arg0: string) => boolean) => closure13(undefined, v);

export function file_exists_content(x: string): ((arg0: string) => boolean) {
    return v6(x);
}

export const v7 = (v: string): ((arg0: string) => any) => closure15(undefined, v);

export function write_all_text_async(x: string): ((arg0: string) => any) {
    return v7(x);
}

export const v8 = (v: string): ((arg0: string) => any) => closure17(undefined, v);

export function write_all_text_exists(x: string): ((arg0: string) => any) {
    return v8(x);
}

export const v9 = (v: string): any => closure19(undefined, v);

export function delete_file_async(x: string): any {
    return v9(x);
}

export const v10 = (v: string): ((arg0: string) => any) => closure23(undefined, v);

export function move_file_async(x: string): ((arg0: string) => any) {
    return v10(x);
}

export const v11 = (v: string): any => closure28(undefined, v);

export function read_all_text_retry_async(x: string): any {
    return v11(x);
}

export const v12 = (): string => closure40(undefined, undefined);

export function create_temp_path(): string {
    return v12();
}

export const v13 = (): [string, IDisposable] => closure41(undefined, undefined);

export function create_temp_dir(): [string, IDisposable] {
    return v13();
}

export const v14 = (v: string): [string, IDisposable] => closure56(undefined, v);

export function create_temp_dir$0027(x: string): [string, IDisposable] {
    return v14(x);
}

export const v15 = (): string => closure57(undefined, undefined);

export function get_source_directory(): string {
    return v15();
}

export const v16 = (v: string): string => closure58(undefined, v);

export function normalize_path(x: string): string {
    return v16(x);
}

export const v17 = (v: string): string => closure59(undefined, v);

export function new_file_uri(x: string): string {
    return v17(x);
}

export const v18 = (): string => closure60(undefined, undefined);

export function get_workspace_root(): string {
    return v18();
}

export const v19 = (v: boolean): void => {
    closure65(undefined, v);
};

export function init_trace_file(x: boolean): void {
    v19(x);
}

export const v20 = (v: string): ((arg0: string) => string) => closure67(undefined, v);

export function op_LessDivideGreater(x: string): ((arg0: string) => string) {
    return v20(x);
}


