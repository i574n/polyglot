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

export function method1(v0: string): string {
    let _v3: Option<string> = undefined;
    const x: string = process.env[v0] ?? "";
    _v3 = x;
    if (_v3 == null) {
        throw new Error("base.run_target / _v3=None");
    }
    else {
        return value_3(_v3);
    }
}

export function method3(): string {
    return "AUTOMATION";
}

export function closure1(unitVar: void, v0: string): void {
}

export function closure0(unitVar: void, v0: US0_$union): [Mut0, Mut1, Mut2, Mut3, Option<int64>] {
    let v102: US1_$union, v110: US1_$union, v118: US1_$union, v126: US1_$union;
    let _v3: Option<[US1_$union, US2_$union]> = undefined;
    const v88: string = method1(method0());
    const v94: US1_$union = ("Verbose" === v88) ? US1_US1_0(US0_US0_0()) : US1_US1_1();
    const x = [(v94.tag === /* US1_0 */ 0) ? US1_US1_0(v94.fields[0]) : ((v102 = (("Debug" === v88) ? US1_US1_0(US0_US0_1()) : US1_US1_1()), (v102.tag === /* US1_0 */ 0) ? US1_US1_0(v102.fields[0]) : ((v110 = (("Info" === v88) ? US1_US1_0(US0_US0_2()) : US1_US1_1()), (v110.tag === /* US1_0 */ 0) ? US1_US1_0(v110.fields[0]) : ((v118 = (("Warning" === v88) ? US1_US1_0(US0_US0_3()) : US1_US1_1()), (v118.tag === /* US1_0 */ 0) ? US1_US1_0(v118.fields[0]) : ((v126 = (("Critical" === v88) ? US1_US1_0(US0_US0_4()) : US1_US1_1()), (v126.tag === /* US1_0 */ 0) ? US1_US1_0(v126.fields[0]) : US1_US1_1())))))))), (method1(method3()) === "True") ? US2_US2_0(getTicks(now())) : US2_US2_1()] as [US1_$union, US2_$union];
    _v3 = x;
    let patternInput: [US1_$union, US2_$union];
    if (_v3 == null) {
        throw new Error("base.run_target / _v3=None");
    }
    else {
        patternInput = value_3(_v3);
    }
    const v325: US2_$union = patternInput[1];
    const v324: US1_$union = patternInput[0];
    return [new Mut0(0n), new Mut1((v: string): void => {
        closure1(undefined, v);
    }), new Mut2(true), new Mut3((v324.tag === /* US1_0 */ 0) ? v324.fields[0] : v0), (v325.tag === /* US2_0 */ 0) ? v325.fields[0] : undefined] as [Mut0, Mut1, Mut2, Mut3, Option<int64>];
}

export function method6(v0: string): string {
    return v0;
}

export function method7(v0: string): boolean {
    let _v3: Option<boolean> = undefined;
    const v37: IFsExistsSync = fs;
    const x: boolean = v37.existsSync(v0);
    _v3 = x;
    if (_v3 == null) {
        throw new Error("base.run_target / _v3=None");
    }
    else {
        return value_3(_v3);
    }
}

export function method5(v0: boolean, v1: string): void {
    let _v4: Option<void> = undefined;
    defaultOf();
    _v4 = some(undefined);
    if (_v4 == null) {
        throw new Error("base.run_target / _v4=None");
    }
    else {
        value_3(_v4);
    }
}

export function closure3(unitVar: void, unitVar_1: void): string {
    return "file_system.delete_directory_async";
}

export function method8(v0: string): string {
    let _v3: Option<string> = undefined;
    let x: string;
    throw new Error(`file_system.get_file_name / target: ${US5_US5_3(US4_US4_0())} / path: ${v0}`);
    _v3 = x;
    if (_v3 == null) {
        throw new Error("base.run_target / _v3=None");
    }
    else {
        return value_3(_v3);
    }
}

export function closure4(v0: string, v1: string, unitVar: void): [string, string] {
    return [v1, method8(v0)] as [string, string];
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

export function method15(v0: Mut4, v1: string): void {
    const v4 = `${v1}`;
    const v12_1: string = v0.l0 + v4;
    v0.l0 = v12_1;
}

export function method16(v0: Mut4): void {
}

export function method14(v0: Mut4, v1: string, v2_1: string): void {
    method15(v0, "{ ");
    method16(v0);
    method15(v0, "ex");
    method15(v0, " = ");
    method15(v0, v1);
    method15(v0, "; ");
    method15(v0, "path");
    method15(v0, " = ");
    method15(v0, v2_1);
    method15(v0, " }");
}

export function closure5(v0: US0_$union, v1: (() => string), v2_1: (() => [string, string]), unitVar: void): string {
    let v368: int64, v392: number;
    if (State_trace_state() == null) {
        State_trace_state(closure0(undefined, US0_US0_0()));
    }
    const patternInput: [Mut0, Mut1, Mut2, Mut3, Option<int64>] = value_3(State_trace_state());
    const v18_1: Option<int64> = patternInput[4];
    let _v35: Option<string> = undefined;
    const _v333: FSharpRef<Option<US2_$union>> = new FSharpRef<Option<US2_$union>>(undefined);
    let x_2: Option<US2_$union>;
    if (v18_1 == null) {
        x_2 = undefined;
    }
    else {
        const x: int64 = value_3(v18_1);
        x_2 = ((): US2_$union => US2_US2_0(x))();
    }
    _v333.contents = x_2;
    const v360: US2_$union = defaultArg(_v333.contents, US2_US2_1());
    const x_3: string = toString((v360.tag === /* US2_0 */ 0) ? ((v368 = v360.fields[0], (v392 = fromTicks(toInt64(op_Subtraction(getTicks(now()), v368))), create(1, 1, 1, hours(v392), minutes(v392), seconds(v392), milliseconds(v392))))) : now(), method12());
    _v35 = x_3;
    let v772: string;
    if (_v35 == null) {
        throw new Error("base.run_target / _v35=None");
    }
    else {
        v772 = value_3(_v35);
    }
    const v931: US3_$union = (v0.tag === /* US0_0 */ 0) ? US3_US3_0("Verbose") : US3_US3_1();
    let v980: US3_$union;
    if (v931.tag === /* US3_0 */ 0) {
        v980 = US3_US3_0(v931.fields[0]);
    }
    else {
        const v940: US3_$union = (v0.tag === /* US0_1 */ 1) ? US3_US3_0("Debug") : US3_US3_1();
        if (v940.tag === /* US3_0 */ 0) {
            v980 = US3_US3_0(v940.fields[0]);
        }
        else {
            const v949: US3_$union = (v0.tag === /* US0_2 */ 2) ? US3_US3_0("Info") : US3_US3_1();
            if (v949.tag === /* US3_0 */ 0) {
                v980 = US3_US3_0(v949.fields[0]);
            }
            else {
                const v958: US3_$union = (v0.tag === /* US0_3 */ 3) ? US3_US3_0("Warning") : US3_US3_1();
                if (v958.tag === /* US3_0 */ 0) {
                    v980 = US3_US3_0(v958.fields[0]);
                }
                else {
                    const v967: US3_$union = (v0.tag === /* US0_4 */ 4) ? US3_US3_0("Critical") : US3_US3_1();
                    v980 = ((v967.tag === /* US3_0 */ 0) ? US3_US3_0(v967.fields[0]) : US3_US3_1());
                }
            }
        }
    }
    let v984: string;
    if (v980.tag === /* US3_0 */ 0) {
        v984 = v980.fields[0];
    }
    else {
        throw new Error("Option does not have a value.");
    }
    const v997: string = padLeft(v984.toLocaleLowerCase(), 7, " ");
    let _v1029: Option<string> = undefined;
    const x_5: string = (((v0.tag === /* US0_1 */ 1) ? "\u001b[94m" : ((v0.tag === /* US0_2 */ 2) ? "\u001b[92m" : ((v0.tag === /* US0_0 */ 0) ? "\u001b[90m" : ((v0.tag === /* US0_3 */ 3) ? "\u001b[93m" : "\u001b[91m")))) + v997) + method13();
    _v1029 = x_5;
    let v1141: string;
    if (_v1029 == null) {
        throw new Error("base.run_target / _v1029=None");
    }
    else {
        v1141 = value_3(_v1029);
    }
    const v1160: int64 = patternInput[0].l0;
    const patternInput_1: [string, string] = v2_1();
    const v1164: Mut4 = new Mut4("");
    method14(v1164, patternInput_1[0], patternInput_1[1]);
    const v1165: string = v1164.l0;
    return trimEnd(trimStart(`${v772} ${v1141} #${v1160} ${v1()} / ${v1165}`, ...[]), ...[" ", "/"]);
}

export function method17(v0: US0_$union, v1: (() => string)): void {
    const v4 = (v: US0_$union): [Mut0, Mut1, Mut2, Mut3, Option<int64>] => closure0(undefined, v);
    if (State_trace_state() == null) {
        State_trace_state(v4(US0_US0_0()));
    }
    const patternInput: [Mut0, Mut1, Mut2, Mut3, Option<int64>] = value_3(State_trace_state());
    const v13_1: Mut0 = patternInput[0];
    if (State_trace_state() == null) {
        State_trace_state(v4(US0_US0_0()));
    }
    const patternInput_1: [Mut0, Mut1, Mut2, Mut3, Option<int64>] = value_3(State_trace_state());
    const v61: US0_$union = patternInput_1[3].l0;
    if ((patternInput_1[2].l0 === false) ? false : (find<US0_$union, int32>(v0, ofSeq([[US0_US0_0(), 0] as [US0_$union, int32], [US0_US0_1(), 1] as [US0_$union, int32], [US0_US0_2(), 2] as [US0_$union, int32], [US0_US0_3(), 3] as [US0_$union, int32], [US0_US0_4(), 4] as [US0_$union, int32]], {
        Compare: compare,
    })) >= find<US0_$union, int32>(v61, ofSeq([[US0_US0_0(), 0] as [US0_$union, int32], [US0_US0_1(), 1] as [US0_$union, int32], [US0_US0_2(), 2] as [US0_$union, int32], [US0_US0_3(), 3] as [US0_$union, int32], [US0_US0_4(), 4] as [US0_$union, int32]], {
        Compare: compare,
    })))) {
        const v69: int64 = toInt64(op_Addition(v13_1.l0, 1n));
        v13_1.l0 = v69;
        const v72 = `${v1()}`;
        let _v81: Option<void> = undefined;
        console.log(v72);
        _v81 = some(undefined);
        if (_v81 == null) {
            throw new Error("base.run_target / _v81=None");
        }
        else {
            value_3(_v81);
        }
        patternInput[1].l0(v72);
    }
}

export function method9(v0: US0_$union, v1: (() => string), v2_1: (() => [string, string])): void {
    method17(v0, (): string => closure5(v0, v1, v2_1, undefined));
}

export function method4(v0: string, v1: int64): any {
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

export function closure2(unitVar: void, v0: string): any {
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

export function closure8(unitVar: void, unitVar_1: void): string {
    return "file_system.wait_for_file_access";
}

export function closure9(v0: string, v1: int64, v2_1: string, unitVar: void): [string, int64, string] {
    return [method8(v0), v1, v2_1] as [string, int64, string];
}

export function method21(v0: Mut4, v1: int64): void {
    const v4 = `${v1}`;
    const v12_1: string = v0.l0 + v4;
    v0.l0 = v12_1;
}

export function method20(v0: Mut4, v1: string, v2_1: int64, v3_1: string): void {
    method15(v0, "{ ");
    method16(v0);
    method15(v0, "path");
    method15(v0, " = ");
    method15(v0, v1);
    method15(v0, "; ");
    method15(v0, "retry");
    method15(v0, " = ");
    method21(v0, v2_1);
    method15(v0, "; ");
    method15(v0, "ex");
    method15(v0, " = ");
    method15(v0, v3_1);
    method15(v0, " }");
}

export function closure10(v0: US0_$union, v1: (() => string), v2_1: (() => [string, int64, string]), unitVar: void): string {
    let v368: int64, v392: number;
    if (State_trace_state() == null) {
        State_trace_state(closure0(undefined, US0_US0_0()));
    }
    const patternInput: [Mut0, Mut1, Mut2, Mut3, Option<int64>] = value_3(State_trace_state());
    const v18_1: Option<int64> = patternInput[4];
    let _v35: Option<string> = undefined;
    const _v333: FSharpRef<Option<US2_$union>> = new FSharpRef<Option<US2_$union>>(undefined);
    let x_2: Option<US2_$union>;
    if (v18_1 == null) {
        x_2 = undefined;
    }
    else {
        const x: int64 = value_3(v18_1);
        x_2 = ((): US2_$union => US2_US2_0(x))();
    }
    _v333.contents = x_2;
    const v360: US2_$union = defaultArg(_v333.contents, US2_US2_1());
    const x_3: string = toString((v360.tag === /* US2_0 */ 0) ? ((v368 = v360.fields[0], (v392 = fromTicks(toInt64(op_Subtraction(getTicks(now()), v368))), create(1, 1, 1, hours(v392), minutes(v392), seconds(v392), milliseconds(v392))))) : now(), method12());
    _v35 = x_3;
    let v772: string;
    if (_v35 == null) {
        throw new Error("base.run_target / _v35=None");
    }
    else {
        v772 = value_3(_v35);
    }
    const v931: US3_$union = (v0.tag === /* US0_0 */ 0) ? US3_US3_0("Verbose") : US3_US3_1();
    let v980: US3_$union;
    if (v931.tag === /* US3_0 */ 0) {
        v980 = US3_US3_0(v931.fields[0]);
    }
    else {
        const v940: US3_$union = (v0.tag === /* US0_1 */ 1) ? US3_US3_0("Debug") : US3_US3_1();
        if (v940.tag === /* US3_0 */ 0) {
            v980 = US3_US3_0(v940.fields[0]);
        }
        else {
            const v949: US3_$union = (v0.tag === /* US0_2 */ 2) ? US3_US3_0("Info") : US3_US3_1();
            if (v949.tag === /* US3_0 */ 0) {
                v980 = US3_US3_0(v949.fields[0]);
            }
            else {
                const v958: US3_$union = (v0.tag === /* US0_3 */ 3) ? US3_US3_0("Warning") : US3_US3_1();
                if (v958.tag === /* US3_0 */ 0) {
                    v980 = US3_US3_0(v958.fields[0]);
                }
                else {
                    const v967: US3_$union = (v0.tag === /* US0_4 */ 4) ? US3_US3_0("Critical") : US3_US3_1();
                    v980 = ((v967.tag === /* US3_0 */ 0) ? US3_US3_0(v967.fields[0]) : US3_US3_1());
                }
            }
        }
    }
    let v984: string;
    if (v980.tag === /* US3_0 */ 0) {
        v984 = v980.fields[0];
    }
    else {
        throw new Error("Option does not have a value.");
    }
    const v997: string = padLeft(v984.toLocaleLowerCase(), 7, " ");
    let _v1029: Option<string> = undefined;
    const x_5: string = (((v0.tag === /* US0_1 */ 1) ? "\u001b[94m" : ((v0.tag === /* US0_2 */ 2) ? "\u001b[92m" : ((v0.tag === /* US0_0 */ 0) ? "\u001b[90m" : ((v0.tag === /* US0_3 */ 3) ? "\u001b[93m" : "\u001b[91m")))) + v997) + method13();
    _v1029 = x_5;
    let v1141: string;
    if (_v1029 == null) {
        throw new Error("base.run_target / _v1029=None");
    }
    else {
        v1141 = value_3(_v1029);
    }
    const v1160: int64 = patternInput[0].l0;
    const patternInput_1: [string, int64, string] = v2_1();
    const v1165: Mut4 = new Mut4("");
    method20(v1165, patternInput_1[0], patternInput_1[1], patternInput_1[2]);
    const v1166: string = v1165.l0;
    return trimEnd(trimStart(`${v772} ${v1141} #${v1160} ${v1()} / ${v1166}`, ...[]), ...[" ", "/"]);
}

export function method19(v0: US0_$union, v1: (() => string), v2_1: (() => [string, int64, string])): void {
    method17(v0, (): string => closure10(v0, v1, v2_1, undefined));
}

export function method18(v0: string, v1: US8_$union, v2_1: US7_$union, v3_1: int64): any {
    let _v6: Option<any> = undefined;
    const x: any = defaultOf();
    _v6 = x;
    if (_v6 == null) {
        throw new Error("base.run_target / _v6=None");
    }
    else {
        return value_3(_v6);
    }
}

export function closure7(v0: US6_$union, v1: string): any {
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

export function closure6(unitVar: void, v0: US6_$union): ((arg0: string) => any) {
    return (v: string): any => closure7(v0, v);
}

export function method22(v0: string, v1: int64): any {
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

export function closure11(unitVar: void, v0: string): any {
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

export function closure12(unitVar: void, v0: string): any {
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

export function method24(v0: string): boolean {
    let _v3: Option<boolean> = undefined;
    const v34: IFsExistsSync = fs;
    const x: boolean = v34.existsSync(v0);
    _v3 = x;
    if (_v3 == null) {
        throw new Error("base.run_target / _v3=None");
    }
    else {
        return value_3(_v3);
    }
}

export function method25(v0: any): any {
    return v0;
}

export function method23(v0: string, v1: string): boolean {
    let _v4: Option<boolean> = undefined;
    const x: boolean = defaultOf();
    _v4 = x;
    if (_v4 == null) {
        throw new Error("base.run_target / _v4=None");
    }
    else {
        return value_3(_v4);
    }
}

export function closure14(v0: string, v1: string): boolean {
    return method23(v0, v1);
}

export function closure13(unitVar: void, v0: string): ((arg0: string) => boolean) {
    return (v: string): boolean => closure14(v0, v);
}

export function closure16(v0: string, v1: string): any {
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

export function closure15(unitVar: void, v0: string): ((arg0: string) => any) {
    return (v: string): any => closure16(v0, v);
}

export function closure18(v0: string, v1: string): any {
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

export function closure17(unitVar: void, v0: string): ((arg0: string) => any) {
    return (v: string): any => closure18(v0, v);
}

export function closure20(unitVar: void, unitVar_1: void): string {
    return "delete_file_async";
}

export function closure21(v0: string, v1: Error, unitVar: void): [string, string] {
    const v2_1: string = method8(v0);
    let _v5: Option<string> = undefined;
    const x: string = toText(interpolate("%A%P()", [v1]));
    _v5 = x;
    return [v2_1, (_v5 == null) ? (() => {
        throw new Error("base.run_target / _v5=None");
    })() : value_3(_v5)] as [string, string];
}

export function method28(v0: Mut4, v1: string, v2_1: string): void {
    method15(v0, "{ ");
    method16(v0);
    method15(v0, "path");
    method15(v0, " = ");
    method15(v0, v1);
    method15(v0, "; ");
    method15(v0, "ex");
    method15(v0, " = ");
    method15(v0, v2_1);
    method15(v0, " }");
}

export function closure22(v0: US0_$union, v1: (() => string), v2_1: (() => [string, string]), unitVar: void): string {
    let v368: int64, v392: number;
    if (State_trace_state() == null) {
        State_trace_state(closure0(undefined, US0_US0_0()));
    }
    const patternInput: [Mut0, Mut1, Mut2, Mut3, Option<int64>] = value_3(State_trace_state());
    const v18_1: Option<int64> = patternInput[4];
    let _v35: Option<string> = undefined;
    const _v333: FSharpRef<Option<US2_$union>> = new FSharpRef<Option<US2_$union>>(undefined);
    let x_2: Option<US2_$union>;
    if (v18_1 == null) {
        x_2 = undefined;
    }
    else {
        const x: int64 = value_3(v18_1);
        x_2 = ((): US2_$union => US2_US2_0(x))();
    }
    _v333.contents = x_2;
    const v360: US2_$union = defaultArg(_v333.contents, US2_US2_1());
    const x_3: string = toString((v360.tag === /* US2_0 */ 0) ? ((v368 = v360.fields[0], (v392 = fromTicks(toInt64(op_Subtraction(getTicks(now()), v368))), create(1, 1, 1, hours(v392), minutes(v392), seconds(v392), milliseconds(v392))))) : now(), method12());
    _v35 = x_3;
    let v772: string;
    if (_v35 == null) {
        throw new Error("base.run_target / _v35=None");
    }
    else {
        v772 = value_3(_v35);
    }
    const v931: US3_$union = (v0.tag === /* US0_0 */ 0) ? US3_US3_0("Verbose") : US3_US3_1();
    let v980: US3_$union;
    if (v931.tag === /* US3_0 */ 0) {
        v980 = US3_US3_0(v931.fields[0]);
    }
    else {
        const v940: US3_$union = (v0.tag === /* US0_1 */ 1) ? US3_US3_0("Debug") : US3_US3_1();
        if (v940.tag === /* US3_0 */ 0) {
            v980 = US3_US3_0(v940.fields[0]);
        }
        else {
            const v949: US3_$union = (v0.tag === /* US0_2 */ 2) ? US3_US3_0("Info") : US3_US3_1();
            if (v949.tag === /* US3_0 */ 0) {
                v980 = US3_US3_0(v949.fields[0]);
            }
            else {
                const v958: US3_$union = (v0.tag === /* US0_3 */ 3) ? US3_US3_0("Warning") : US3_US3_1();
                if (v958.tag === /* US3_0 */ 0) {
                    v980 = US3_US3_0(v958.fields[0]);
                }
                else {
                    const v967: US3_$union = (v0.tag === /* US0_4 */ 4) ? US3_US3_0("Critical") : US3_US3_1();
                    v980 = ((v967.tag === /* US3_0 */ 0) ? US3_US3_0(v967.fields[0]) : US3_US3_1());
                }
            }
        }
    }
    let v984: string;
    if (v980.tag === /* US3_0 */ 0) {
        v984 = v980.fields[0];
    }
    else {
        throw new Error("Option does not have a value.");
    }
    const v997: string = padLeft(v984.toLocaleLowerCase(), 7, " ");
    let _v1029: Option<string> = undefined;
    const x_5: string = (((v0.tag === /* US0_1 */ 1) ? "\u001b[94m" : ((v0.tag === /* US0_2 */ 2) ? "\u001b[92m" : ((v0.tag === /* US0_0 */ 0) ? "\u001b[90m" : ((v0.tag === /* US0_3 */ 3) ? "\u001b[93m" : "\u001b[91m")))) + v997) + method13();
    _v1029 = x_5;
    let v1141: string;
    if (_v1029 == null) {
        throw new Error("base.run_target / _v1029=None");
    }
    else {
        v1141 = value_3(_v1029);
    }
    const v1160: int64 = patternInput[0].l0;
    const patternInput_1: [string, string] = v2_1();
    const v1164: Mut4 = new Mut4("");
    method28(v1164, patternInput_1[0], patternInput_1[1]);
    const v1165: string = v1164.l0;
    return trimEnd(trimStart(`${v772} ${v1141} #${v1160} ${v1()} / ${v1165}`, ...[]), ...[" ", "/"]);
}

export function method27(v0: US0_$union, v1: (() => string), v2_1: (() => [string, string])): void {
    method17(v0, (): string => closure22(v0, v1, v2_1, undefined));
}

export function method26(v0: string, v1: int64): any {
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

export function closure19(unitVar: void, v0: string): any {
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

export function closure25(unitVar: void, unitVar_1: void): string {
    return "move_file_async";
}

export function closure26(v0: string, v1: string, v2_1: Error, unitVar: void): [string, string, Error] {
    return [method8(v1), method8(v0), v2_1] as [string, string, Error];
}

export function method32(v0: Mut4, v1: Error): void {
    method15(v0, toText(interpolate("%A%P()", [v1])));
}

export function method31(v0: Mut4, v1: string, v2_1: string, v3_1: Error): void {
    method15(v0, "{ ");
    method16(v0);
    method15(v0, "old_path");
    method15(v0, " = ");
    method15(v0, v1);
    method15(v0, "; ");
    method15(v0, "new_path");
    method15(v0, " = ");
    method15(v0, v2_1);
    method15(v0, "; ");
    method15(v0, "ex");
    method15(v0, " = ");
    method32(v0, v3_1);
    method15(v0, " }");
}

export function closure27(v0: US0_$union, v1: (() => string), v2_1: (() => [string, string, Error]), unitVar: void): string {
    let v368: int64, v392: number;
    if (State_trace_state() == null) {
        State_trace_state(closure0(undefined, US0_US0_0()));
    }
    const patternInput: [Mut0, Mut1, Mut2, Mut3, Option<int64>] = value_3(State_trace_state());
    const v18_1: Option<int64> = patternInput[4];
    let _v35: Option<string> = undefined;
    const _v333: FSharpRef<Option<US2_$union>> = new FSharpRef<Option<US2_$union>>(undefined);
    let x_2: Option<US2_$union>;
    if (v18_1 == null) {
        x_2 = undefined;
    }
    else {
        const x: int64 = value_3(v18_1);
        x_2 = ((): US2_$union => US2_US2_0(x))();
    }
    _v333.contents = x_2;
    const v360: US2_$union = defaultArg(_v333.contents, US2_US2_1());
    const x_3: string = toString((v360.tag === /* US2_0 */ 0) ? ((v368 = v360.fields[0], (v392 = fromTicks(toInt64(op_Subtraction(getTicks(now()), v368))), create(1, 1, 1, hours(v392), minutes(v392), seconds(v392), milliseconds(v392))))) : now(), method12());
    _v35 = x_3;
    let v772: string;
    if (_v35 == null) {
        throw new Error("base.run_target / _v35=None");
    }
    else {
        v772 = value_3(_v35);
    }
    const v931: US3_$union = (v0.tag === /* US0_0 */ 0) ? US3_US3_0("Verbose") : US3_US3_1();
    let v980: US3_$union;
    if (v931.tag === /* US3_0 */ 0) {
        v980 = US3_US3_0(v931.fields[0]);
    }
    else {
        const v940: US3_$union = (v0.tag === /* US0_1 */ 1) ? US3_US3_0("Debug") : US3_US3_1();
        if (v940.tag === /* US3_0 */ 0) {
            v980 = US3_US3_0(v940.fields[0]);
        }
        else {
            const v949: US3_$union = (v0.tag === /* US0_2 */ 2) ? US3_US3_0("Info") : US3_US3_1();
            if (v949.tag === /* US3_0 */ 0) {
                v980 = US3_US3_0(v949.fields[0]);
            }
            else {
                const v958: US3_$union = (v0.tag === /* US0_3 */ 3) ? US3_US3_0("Warning") : US3_US3_1();
                if (v958.tag === /* US3_0 */ 0) {
                    v980 = US3_US3_0(v958.fields[0]);
                }
                else {
                    const v967: US3_$union = (v0.tag === /* US0_4 */ 4) ? US3_US3_0("Critical") : US3_US3_1();
                    v980 = ((v967.tag === /* US3_0 */ 0) ? US3_US3_0(v967.fields[0]) : US3_US3_1());
                }
            }
        }
    }
    let v984: string;
    if (v980.tag === /* US3_0 */ 0) {
        v984 = v980.fields[0];
    }
    else {
        throw new Error("Option does not have a value.");
    }
    const v997: string = padLeft(v984.toLocaleLowerCase(), 7, " ");
    let _v1029: Option<string> = undefined;
    const x_5: string = (((v0.tag === /* US0_1 */ 1) ? "\u001b[94m" : ((v0.tag === /* US0_2 */ 2) ? "\u001b[92m" : ((v0.tag === /* US0_0 */ 0) ? "\u001b[90m" : ((v0.tag === /* US0_3 */ 3) ? "\u001b[93m" : "\u001b[91m")))) + v997) + method13();
    _v1029 = x_5;
    let v1141: string;
    if (_v1029 == null) {
        throw new Error("base.run_target / _v1029=None");
    }
    else {
        v1141 = value_3(_v1029);
    }
    const v1160: int64 = patternInput[0].l0;
    const patternInput_1: [string, string, Error] = v2_1();
    const v1165: Mut4 = new Mut4("");
    method31(v1165, patternInput_1[0], patternInput_1[1], patternInput_1[2]);
    const v1166: string = v1165.l0;
    return trimEnd(trimStart(`${v772} ${v1141} #${v1160} ${v1()} / ${v1166}`, ...[]), ...[" ", "/"]);
}

export function method30(v0: US0_$union, v1: (() => string), v2_1: (() => [string, string, Error])): void {
    method17(v0, (): string => closure27(v0, v1, v2_1, undefined));
}

export function method29(v0: string, v1: string, v2_1: int64): any {
    let _v5: Option<any> = undefined;
    const x: any = defaultOf();
    _v5 = x;
    if (_v5 == null) {
        throw new Error("base.run_target / _v5=None");
    }
    else {
        return value_3(_v5);
    }
}

export function closure24(v0: string, v1: string): any {
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

export function closure23(unitVar: void, v0: string): ((arg0: string) => any) {
    return (v: string): any => closure24(v0, v);
}

export function closure29(unitVar: void, v0: int64): US9_$union {
    return US9_US9_0(v0);
}

export function closure30(unitVar: void, v0: Error): US9_$union {
    return US9_US9_1(v0);
}

export function closure31(unitVar: void, unitVar_1: void): string {
    return "async.run_with_timeout_async";
}

export function closure32(unitVar: void, unitVar_1: void): int32 {
    return 1000;
}

export function method36(v0: Mut4, v1: int32): void {
    const v4 = `${v1}`;
    const v12_1: string = v0.l0 + v4;
    v0.l0 = v12_1;
}

export function method35(v0: Mut4, v1: int32): void {
    method15(v0, "{ ");
    method16(v0);
    method15(v0, "timeout");
    method15(v0, " = ");
    method36(v0, v1);
    method15(v0, " }");
}

export function closure33(v0: US0_$union, v1: (() => string), v2_1: (() => int32), unitVar: void): string {
    let v368: int64, v392: number;
    if (State_trace_state() == null) {
        State_trace_state(closure0(undefined, US0_US0_0()));
    }
    const patternInput: [Mut0, Mut1, Mut2, Mut3, Option<int64>] = value_3(State_trace_state());
    const v18_1: Option<int64> = patternInput[4];
    let _v35: Option<string> = undefined;
    const _v333: FSharpRef<Option<US2_$union>> = new FSharpRef<Option<US2_$union>>(undefined);
    let x_2: Option<US2_$union>;
    if (v18_1 == null) {
        x_2 = undefined;
    }
    else {
        const x: int64 = value_3(v18_1);
        x_2 = ((): US2_$union => US2_US2_0(x))();
    }
    _v333.contents = x_2;
    const v360: US2_$union = defaultArg(_v333.contents, US2_US2_1());
    const x_3: string = toString((v360.tag === /* US2_0 */ 0) ? ((v368 = v360.fields[0], (v392 = fromTicks(toInt64(op_Subtraction(getTicks(now()), v368))), create(1, 1, 1, hours(v392), minutes(v392), seconds(v392), milliseconds(v392))))) : now(), method12());
    _v35 = x_3;
    let v772: string;
    if (_v35 == null) {
        throw new Error("base.run_target / _v35=None");
    }
    else {
        v772 = value_3(_v35);
    }
    const v931: US3_$union = (v0.tag === /* US0_0 */ 0) ? US3_US3_0("Verbose") : US3_US3_1();
    let v980: US3_$union;
    if (v931.tag === /* US3_0 */ 0) {
        v980 = US3_US3_0(v931.fields[0]);
    }
    else {
        const v940: US3_$union = (v0.tag === /* US0_1 */ 1) ? US3_US3_0("Debug") : US3_US3_1();
        if (v940.tag === /* US3_0 */ 0) {
            v980 = US3_US3_0(v940.fields[0]);
        }
        else {
            const v949: US3_$union = (v0.tag === /* US0_2 */ 2) ? US3_US3_0("Info") : US3_US3_1();
            if (v949.tag === /* US3_0 */ 0) {
                v980 = US3_US3_0(v949.fields[0]);
            }
            else {
                const v958: US3_$union = (v0.tag === /* US0_3 */ 3) ? US3_US3_0("Warning") : US3_US3_1();
                if (v958.tag === /* US3_0 */ 0) {
                    v980 = US3_US3_0(v958.fields[0]);
                }
                else {
                    const v967: US3_$union = (v0.tag === /* US0_4 */ 4) ? US3_US3_0("Critical") : US3_US3_1();
                    v980 = ((v967.tag === /* US3_0 */ 0) ? US3_US3_0(v967.fields[0]) : US3_US3_1());
                }
            }
        }
    }
    let v984: string;
    if (v980.tag === /* US3_0 */ 0) {
        v984 = v980.fields[0];
    }
    else {
        throw new Error("Option does not have a value.");
    }
    const v997: string = padLeft(v984.toLocaleLowerCase(), 7, " ");
    let _v1029: Option<string> = undefined;
    const x_5: string = (((v0.tag === /* US0_1 */ 1) ? "\u001b[94m" : ((v0.tag === /* US0_2 */ 2) ? "\u001b[92m" : ((v0.tag === /* US0_0 */ 0) ? "\u001b[90m" : ((v0.tag === /* US0_3 */ 3) ? "\u001b[93m" : "\u001b[91m")))) + v997) + method13();
    _v1029 = x_5;
    let v1141: string;
    if (_v1029 == null) {
        throw new Error("base.run_target / _v1029=None");
    }
    else {
        v1141 = value_3(_v1029);
    }
    const v1160: int64 = patternInput[0].l0;
    const v1163: Mut4 = new Mut4("");
    method35(v1163, v2_1());
    const v1164: string = v1163.l0;
    return trimEnd(trimStart(`${v772} ${v1141} #${v1160} ${v1()} / ${v1164}`, ...[]), ...[" ", "/"]);
}

export function method34(v0: US0_$union, v1: (() => string), v2_1: (() => int32)): void {
    method17(v0, (): string => closure33(v0, v1, v2_1, undefined));
}

export function closure34(unitVar: void, unitVar_1: void): string {
    return "async.run_with_timeout_async**";
}

export function closure35(v0: Error, unitVar: void): [int32, string] {
    let _v3: Option<string> = undefined;
    const x: string = toText(interpolate("%A%P()", [v0]));
    _v3 = x;
    return [1000, (_v3 == null) ? (() => {
        throw new Error("base.run_target / _v3=None");
    })() : value_3(_v3)] as [int32, string];
}

export function method38(v0: Mut4, v1: int32, v2_1: string): void {
    method15(v0, "{ ");
    method16(v0);
    method15(v0, "timeout");
    method15(v0, " = ");
    method36(v0, v1);
    method15(v0, "; ");
    method15(v0, "ex");
    method15(v0, " = ");
    method15(v0, v2_1);
    method15(v0, " }");
}

export function closure36(v0: US0_$union, v1: (() => string), v2_1: (() => [int32, string]), unitVar: void): string {
    let v368: int64, v392: number;
    if (State_trace_state() == null) {
        State_trace_state(closure0(undefined, US0_US0_0()));
    }
    const patternInput: [Mut0, Mut1, Mut2, Mut3, Option<int64>] = value_3(State_trace_state());
    const v18_1: Option<int64> = patternInput[4];
    let _v35: Option<string> = undefined;
    const _v333: FSharpRef<Option<US2_$union>> = new FSharpRef<Option<US2_$union>>(undefined);
    let x_2: Option<US2_$union>;
    if (v18_1 == null) {
        x_2 = undefined;
    }
    else {
        const x: int64 = value_3(v18_1);
        x_2 = ((): US2_$union => US2_US2_0(x))();
    }
    _v333.contents = x_2;
    const v360: US2_$union = defaultArg(_v333.contents, US2_US2_1());
    const x_3: string = toString((v360.tag === /* US2_0 */ 0) ? ((v368 = v360.fields[0], (v392 = fromTicks(toInt64(op_Subtraction(getTicks(now()), v368))), create(1, 1, 1, hours(v392), minutes(v392), seconds(v392), milliseconds(v392))))) : now(), method12());
    _v35 = x_3;
    let v772: string;
    if (_v35 == null) {
        throw new Error("base.run_target / _v35=None");
    }
    else {
        v772 = value_3(_v35);
    }
    const v931: US3_$union = (v0.tag === /* US0_0 */ 0) ? US3_US3_0("Verbose") : US3_US3_1();
    let v980: US3_$union;
    if (v931.tag === /* US3_0 */ 0) {
        v980 = US3_US3_0(v931.fields[0]);
    }
    else {
        const v940: US3_$union = (v0.tag === /* US0_1 */ 1) ? US3_US3_0("Debug") : US3_US3_1();
        if (v940.tag === /* US3_0 */ 0) {
            v980 = US3_US3_0(v940.fields[0]);
        }
        else {
            const v949: US3_$union = (v0.tag === /* US0_2 */ 2) ? US3_US3_0("Info") : US3_US3_1();
            if (v949.tag === /* US3_0 */ 0) {
                v980 = US3_US3_0(v949.fields[0]);
            }
            else {
                const v958: US3_$union = (v0.tag === /* US0_3 */ 3) ? US3_US3_0("Warning") : US3_US3_1();
                if (v958.tag === /* US3_0 */ 0) {
                    v980 = US3_US3_0(v958.fields[0]);
                }
                else {
                    const v967: US3_$union = (v0.tag === /* US0_4 */ 4) ? US3_US3_0("Critical") : US3_US3_1();
                    v980 = ((v967.tag === /* US3_0 */ 0) ? US3_US3_0(v967.fields[0]) : US3_US3_1());
                }
            }
        }
    }
    let v984: string;
    if (v980.tag === /* US3_0 */ 0) {
        v984 = v980.fields[0];
    }
    else {
        throw new Error("Option does not have a value.");
    }
    const v997: string = padLeft(v984.toLocaleLowerCase(), 7, " ");
    let _v1029: Option<string> = undefined;
    const x_5: string = (((v0.tag === /* US0_1 */ 1) ? "\u001b[94m" : ((v0.tag === /* US0_2 */ 2) ? "\u001b[92m" : ((v0.tag === /* US0_0 */ 0) ? "\u001b[90m" : ((v0.tag === /* US0_3 */ 3) ? "\u001b[93m" : "\u001b[91m")))) + v997) + method13();
    _v1029 = x_5;
    let v1141: string;
    if (_v1029 == null) {
        throw new Error("base.run_target / _v1029=None");
    }
    else {
        v1141 = value_3(_v1029);
    }
    const v1160: int64 = patternInput[0].l0;
    const patternInput_1: [int32, string] = v2_1();
    const v1164: Mut4 = new Mut4("");
    method38(v1164, patternInput_1[0], patternInput_1[1]);
    const v1165: string = v1164.l0;
    return trimEnd(trimStart(`${v772} ${v1141} #${v1160} ${v1()} / ${v1165}`, ...[]), ...[" ", "/"]);
}

export function method37(v0: US0_$union, v1: (() => string), v2_1: (() => [int32, string])): void {
    method17(v0, (): string => closure36(v0, v1, v2_1, undefined));
}

export function closure37(unitVar: void, unitVar_1: void): string {
    return "read_all_text_retry_async";
}

export function closure38(v0: int64, v1: string, unitVar: void): [int64, string] {
    return [v0, v1] as [int64, string];
}

export function method40(v0: Mut4, v1: int64, v2_1: string): void {
    method15(v0, "{ ");
    method16(v0);
    method15(v0, "retry");
    method15(v0, " = ");
    method21(v0, v1);
    method15(v0, "; ");
    method15(v0, "ex");
    method15(v0, " = ");
    method15(v0, v2_1);
    method15(v0, " }");
}

export function closure39(v0: US0_$union, v1: (() => string), v2_1: (() => [int64, string]), unitVar: void): string {
    let v368: int64, v392: number;
    if (State_trace_state() == null) {
        State_trace_state(closure0(undefined, US0_US0_0()));
    }
    const patternInput: [Mut0, Mut1, Mut2, Mut3, Option<int64>] = value_3(State_trace_state());
    const v18_1: Option<int64> = patternInput[4];
    let _v35: Option<string> = undefined;
    const _v333: FSharpRef<Option<US2_$union>> = new FSharpRef<Option<US2_$union>>(undefined);
    let x_2: Option<US2_$union>;
    if (v18_1 == null) {
        x_2 = undefined;
    }
    else {
        const x: int64 = value_3(v18_1);
        x_2 = ((): US2_$union => US2_US2_0(x))();
    }
    _v333.contents = x_2;
    const v360: US2_$union = defaultArg(_v333.contents, US2_US2_1());
    const x_3: string = toString((v360.tag === /* US2_0 */ 0) ? ((v368 = v360.fields[0], (v392 = fromTicks(toInt64(op_Subtraction(getTicks(now()), v368))), create(1, 1, 1, hours(v392), minutes(v392), seconds(v392), milliseconds(v392))))) : now(), method12());
    _v35 = x_3;
    let v772: string;
    if (_v35 == null) {
        throw new Error("base.run_target / _v35=None");
    }
    else {
        v772 = value_3(_v35);
    }
    const v931: US3_$union = (v0.tag === /* US0_0 */ 0) ? US3_US3_0("Verbose") : US3_US3_1();
    let v980: US3_$union;
    if (v931.tag === /* US3_0 */ 0) {
        v980 = US3_US3_0(v931.fields[0]);
    }
    else {
        const v940: US3_$union = (v0.tag === /* US0_1 */ 1) ? US3_US3_0("Debug") : US3_US3_1();
        if (v940.tag === /* US3_0 */ 0) {
            v980 = US3_US3_0(v940.fields[0]);
        }
        else {
            const v949: US3_$union = (v0.tag === /* US0_2 */ 2) ? US3_US3_0("Info") : US3_US3_1();
            if (v949.tag === /* US3_0 */ 0) {
                v980 = US3_US3_0(v949.fields[0]);
            }
            else {
                const v958: US3_$union = (v0.tag === /* US0_3 */ 3) ? US3_US3_0("Warning") : US3_US3_1();
                if (v958.tag === /* US3_0 */ 0) {
                    v980 = US3_US3_0(v958.fields[0]);
                }
                else {
                    const v967: US3_$union = (v0.tag === /* US0_4 */ 4) ? US3_US3_0("Critical") : US3_US3_1();
                    v980 = ((v967.tag === /* US3_0 */ 0) ? US3_US3_0(v967.fields[0]) : US3_US3_1());
                }
            }
        }
    }
    let v984: string;
    if (v980.tag === /* US3_0 */ 0) {
        v984 = v980.fields[0];
    }
    else {
        throw new Error("Option does not have a value.");
    }
    const v997: string = padLeft(v984.toLocaleLowerCase(), 7, " ");
    let _v1029: Option<string> = undefined;
    const x_5: string = (((v0.tag === /* US0_1 */ 1) ? "\u001b[94m" : ((v0.tag === /* US0_2 */ 2) ? "\u001b[92m" : ((v0.tag === /* US0_0 */ 0) ? "\u001b[90m" : ((v0.tag === /* US0_3 */ 3) ? "\u001b[93m" : "\u001b[91m")))) + v997) + method13();
    _v1029 = x_5;
    let v1141: string;
    if (_v1029 == null) {
        throw new Error("base.run_target / _v1029=None");
    }
    else {
        v1141 = value_3(_v1029);
    }
    const v1160: int64 = patternInput[0].l0;
    const patternInput_1: [int64, string] = v2_1();
    const v1164: Mut4 = new Mut4("");
    method40(v1164, patternInput_1[0], patternInput_1[1]);
    const v1165: string = v1164.l0;
    return trimEnd(trimStart(`${v772} ${v1141} #${v1160} ${v1()} / ${v1165}`, ...[]), ...[" ", "/"]);
}

export function method39(v0: US0_$union, v1: (() => string), v2_1: (() => [int64, string])): void {
    method17(v0, (): string => closure39(v0, v1, v2_1, undefined));
}

export function method33(v0: string, v1: int64): any {
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

export function closure28(unitVar: void, v0: string): any {
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

export function method43(): string {
    return "hh:mm";
}

export function method44(): string {
    return "yyyyMMdd-HHmm-ssff-ffff-f";
}

export function method45(): string {
    return "hhmm";
}

export function method42(v0: string, v1: Date): string {
    let _v4: Option<string> = undefined;
    const v662: string = toString(v1, method44());
    let _v671: Option<any> = undefined;
    const x: any = defaultOf();
    _v671 = x;
    let v711: any;
    if (_v671 == null) {
        throw new Error("base.run_target / _v671=None");
    }
    else {
        v711 = value_3(_v671);
    }
    let _v728: Option<number> = undefined;
    let x_2: number;
    throw new Error(`date_time.get_utc_offset / target: ${US5_US5_3(US4_US4_0())}`);
    _v728 = x_2;
    let v827: number;
    if (_v728 == null) {
        throw new Error("base.run_target / _v728=None");
    }
    else {
        v827 = value_3(_v728);
    }
    const v848: uint8 = (hours(v827) > 0) ? 1 : 0;
    const v849: string = method45();
    let _v852: Option<string> = undefined;
    const x_4: string = toString_1(v827, "c", {});
    _v852 = x_4;
    const v866 = `${v848}${(_v852 == null) ? (() => {
        throw new Error("base.run_target / _v852=None");
    })() : value_3(_v852)}`;
    const v870: string = v0;
    const x_6: string = parse(`${v662}${v866}${v870.slice(v662.length + v866.length, v870.length)}`);
    _v4 = x_6;
    if (_v4 == null) {
        throw new Error("base.run_target / _v4=None");
    }
    else {
        return value_3(_v4);
    }
}

export function method47(): string {
    let _v2: Option<string> = undefined;
    let x: string;
    throw new Error(`file_system.get_temp_path / target: ${US5_US5_3(US4_US4_0())}`);
    _v2 = x;
    if (_v2 == null) {
        throw new Error("base.run_target / _v2=None");
    }
    else {
        return value_3(_v2);
    }
}

export function method48(): string {
    return "!create_temp_path_";
}

export function method51(v0: string): string {
    return v0;
}

export function method50(v0: string, v1: string): [string, string] {
    return [v1, method51(v0)] as [string, string];
}

export function method49(v0: string, v1: string): string {
    let _v4: Option<string> = undefined;
    const v86: IPathJoin = path;
    const patternInput: [string, string] = method50(v1, v0);
    const x: string = v86.join(patternInput[0], patternInput[1]);
    _v4 = x;
    if (_v4 == null) {
        throw new Error("base.run_target / _v4=None");
    }
    else {
        return value_3(_v4);
    }
}

export function method53(): string {
    return "CARGO_PKG_NAME";
}

export function method52(): string {
    let _v2: Option<string> = undefined;
    let x: string;
    throw new Error(`env.get_entry_assembly_name / target: ${US5_US5_3(US4_US4_0())}`);
    _v2 = x;
    if (_v2 == null) {
        throw new Error("base.run_target / _v2=None");
    }
    else {
        return value_3(_v2);
    }
}

export function method46(v0: string): string {
    let _v3: Option<string> = undefined;
    const x: string = method49(method49(method49(method47(), method48()), method52()), v0);
    _v3 = x;
    if (_v3 == null) {
        throw new Error("base.run_target / _v3=None");
    }
    else {
        return value_3(_v3);
    }
}

export function method41(): string {
    let _v2: Option<string> = undefined;
    const v56: Date = now();
    const x: string = method46(method42(newGuid(), v56));
    _v2 = x;
    if (_v2 == null) {
        throw new Error("base.run_target / _v2=None");
    }
    else {
        return value_3(_v2);
    }
}

export function closure40(unitVar: void, unitVar_1: void): string {
    return method41();
}

export function method55(v0: string): string {
    return v0;
}

export function closure42(unitVar: void, v0: any): any {
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

export function method56(): ((arg0: any) => any) {
    return (v: any): any => closure42(undefined, v);
}

export function closure43(unitVar: void, unitVar_1: void): US12_$union {
    return US12_US12_0();
}

export function closure44(unitVar: void, v0: any): US12_$union {
    return US12_US12_1(v0);
}

export function closure45(unitVar: void, unitVar_1: void): string {
    return "file_system.create_dir";
}

export function closure46(v0: string, v1: any, unitVar: void): [string, any] {
    return [v0, v1] as [string, any];
}

export function method59(v0: Mut4, v1: any): void {
    method15(v0, toText(interpolate("%A%P()", [v1])));
}

export function method58(v0: Mut4, v1: string, v2_1: any): void {
    method15(v0, "{ ");
    method16(v0);
    method15(v0, "dir");
    method15(v0, " = ");
    method15(v0, v1);
    method15(v0, "; ");
    method15(v0, "error");
    method15(v0, " = ");
    method59(v0, v2_1);
    method15(v0, " }");
}

export function closure47(v0: US0_$union, v1: (() => string), v2_1: (() => [string, any]), unitVar: void): string {
    let v368: int64, v392: number;
    if (State_trace_state() == null) {
        State_trace_state(closure0(undefined, US0_US0_0()));
    }
    const patternInput: [Mut0, Mut1, Mut2, Mut3, Option<int64>] = value_3(State_trace_state());
    const v18_1: Option<int64> = patternInput[4];
    let _v35: Option<string> = undefined;
    const _v333: FSharpRef<Option<US2_$union>> = new FSharpRef<Option<US2_$union>>(undefined);
    let x_2: Option<US2_$union>;
    if (v18_1 == null) {
        x_2 = undefined;
    }
    else {
        const x: int64 = value_3(v18_1);
        x_2 = ((): US2_$union => US2_US2_0(x))();
    }
    _v333.contents = x_2;
    const v360: US2_$union = defaultArg(_v333.contents, US2_US2_1());
    const x_3: string = toString((v360.tag === /* US2_0 */ 0) ? ((v368 = v360.fields[0], (v392 = fromTicks(toInt64(op_Subtraction(getTicks(now()), v368))), create(1, 1, 1, hours(v392), minutes(v392), seconds(v392), milliseconds(v392))))) : now(), method12());
    _v35 = x_3;
    let v772: string;
    if (_v35 == null) {
        throw new Error("base.run_target / _v35=None");
    }
    else {
        v772 = value_3(_v35);
    }
    const v931: US3_$union = (v0.tag === /* US0_0 */ 0) ? US3_US3_0("Verbose") : US3_US3_1();
    let v980: US3_$union;
    if (v931.tag === /* US3_0 */ 0) {
        v980 = US3_US3_0(v931.fields[0]);
    }
    else {
        const v940: US3_$union = (v0.tag === /* US0_1 */ 1) ? US3_US3_0("Debug") : US3_US3_1();
        if (v940.tag === /* US3_0 */ 0) {
            v980 = US3_US3_0(v940.fields[0]);
        }
        else {
            const v949: US3_$union = (v0.tag === /* US0_2 */ 2) ? US3_US3_0("Info") : US3_US3_1();
            if (v949.tag === /* US3_0 */ 0) {
                v980 = US3_US3_0(v949.fields[0]);
            }
            else {
                const v958: US3_$union = (v0.tag === /* US0_3 */ 3) ? US3_US3_0("Warning") : US3_US3_1();
                if (v958.tag === /* US3_0 */ 0) {
                    v980 = US3_US3_0(v958.fields[0]);
                }
                else {
                    const v967: US3_$union = (v0.tag === /* US0_4 */ 4) ? US3_US3_0("Critical") : US3_US3_1();
                    v980 = ((v967.tag === /* US3_0 */ 0) ? US3_US3_0(v967.fields[0]) : US3_US3_1());
                }
            }
        }
    }
    let v984: string;
    if (v980.tag === /* US3_0 */ 0) {
        v984 = v980.fields[0];
    }
    else {
        throw new Error("Option does not have a value.");
    }
    const v997: string = padLeft(v984.toLocaleLowerCase(), 7, " ");
    let _v1029: Option<string> = undefined;
    const x_5: string = (((v0.tag === /* US0_1 */ 1) ? "\u001b[94m" : ((v0.tag === /* US0_2 */ 2) ? "\u001b[92m" : ((v0.tag === /* US0_0 */ 0) ? "\u001b[90m" : ((v0.tag === /* US0_3 */ 3) ? "\u001b[93m" : "\u001b[91m")))) + v997) + method13();
    _v1029 = x_5;
    let v1141: string;
    if (_v1029 == null) {
        throw new Error("base.run_target / _v1029=None");
    }
    else {
        v1141 = value_3(_v1029);
    }
    const v1160: int64 = patternInput[0].l0;
    const patternInput_1: [string, any] = v2_1();
    const v1164: Mut4 = new Mut4("");
    method58(v1164, patternInput_1[0], patternInput_1[1]);
    const v1165: string = v1164.l0;
    return trimEnd(trimStart(`${v772} ${v1141} #${v1160} ${v1()} / ${v1165}`, ...[]), ...[" ", "/"]);
}

export function method57(v0: US0_$union, v1: (() => string), v2_1: (() => [string, any])): void {
    method17(v0, (): string => closure47(v0, v1, v2_1, undefined));
}

export function closure48(unitVar: void, unitVar_1: void): string {
    return "file_system.create_dir";
}

export function closure49(v0: string, unitVar: void): string {
    return v0;
}

export function method61(v0: Mut4, v1: string): void {
    method15(v0, "{ ");
    method16(v0);
    method15(v0, "dir");
    method15(v0, " = ");
    method15(v0, v1);
    method15(v0, " }");
}

export function closure50(v0: US0_$union, v1: (() => string), v2_1: (() => string), unitVar: void): string {
    let v368: int64, v392: number;
    if (State_trace_state() == null) {
        State_trace_state(closure0(undefined, US0_US0_0()));
    }
    const patternInput: [Mut0, Mut1, Mut2, Mut3, Option<int64>] = value_3(State_trace_state());
    const v18_1: Option<int64> = patternInput[4];
    let _v35: Option<string> = undefined;
    const _v333: FSharpRef<Option<US2_$union>> = new FSharpRef<Option<US2_$union>>(undefined);
    let x_2: Option<US2_$union>;
    if (v18_1 == null) {
        x_2 = undefined;
    }
    else {
        const x: int64 = value_3(v18_1);
        x_2 = ((): US2_$union => US2_US2_0(x))();
    }
    _v333.contents = x_2;
    const v360: US2_$union = defaultArg(_v333.contents, US2_US2_1());
    const x_3: string = toString((v360.tag === /* US2_0 */ 0) ? ((v368 = v360.fields[0], (v392 = fromTicks(toInt64(op_Subtraction(getTicks(now()), v368))), create(1, 1, 1, hours(v392), minutes(v392), seconds(v392), milliseconds(v392))))) : now(), method12());
    _v35 = x_3;
    let v772: string;
    if (_v35 == null) {
        throw new Error("base.run_target / _v35=None");
    }
    else {
        v772 = value_3(_v35);
    }
    const v931: US3_$union = (v0.tag === /* US0_0 */ 0) ? US3_US3_0("Verbose") : US3_US3_1();
    let v980: US3_$union;
    if (v931.tag === /* US3_0 */ 0) {
        v980 = US3_US3_0(v931.fields[0]);
    }
    else {
        const v940: US3_$union = (v0.tag === /* US0_1 */ 1) ? US3_US3_0("Debug") : US3_US3_1();
        if (v940.tag === /* US3_0 */ 0) {
            v980 = US3_US3_0(v940.fields[0]);
        }
        else {
            const v949: US3_$union = (v0.tag === /* US0_2 */ 2) ? US3_US3_0("Info") : US3_US3_1();
            if (v949.tag === /* US3_0 */ 0) {
                v980 = US3_US3_0(v949.fields[0]);
            }
            else {
                const v958: US3_$union = (v0.tag === /* US0_3 */ 3) ? US3_US3_0("Warning") : US3_US3_1();
                if (v958.tag === /* US3_0 */ 0) {
                    v980 = US3_US3_0(v958.fields[0]);
                }
                else {
                    const v967: US3_$union = (v0.tag === /* US0_4 */ 4) ? US3_US3_0("Critical") : US3_US3_1();
                    v980 = ((v967.tag === /* US3_0 */ 0) ? US3_US3_0(v967.fields[0]) : US3_US3_1());
                }
            }
        }
    }
    let v984: string;
    if (v980.tag === /* US3_0 */ 0) {
        v984 = v980.fields[0];
    }
    else {
        throw new Error("Option does not have a value.");
    }
    const v997: string = padLeft(v984.toLocaleLowerCase(), 7, " ");
    let _v1029: Option<string> = undefined;
    const x_5: string = (((v0.tag === /* US0_1 */ 1) ? "\u001b[94m" : ((v0.tag === /* US0_2 */ 2) ? "\u001b[92m" : ((v0.tag === /* US0_0 */ 0) ? "\u001b[90m" : ((v0.tag === /* US0_3 */ 3) ? "\u001b[93m" : "\u001b[91m")))) + v997) + method13();
    _v1029 = x_5;
    let v1141: string;
    if (_v1029 == null) {
        throw new Error("base.run_target / _v1029=None");
    }
    else {
        v1141 = value_3(_v1029);
    }
    const v1160: int64 = patternInput[0].l0;
    const v1163: Mut4 = new Mut4("");
    method61(v1163, v2_1());
    const v1164: string = v1163.l0;
    return trimEnd(trimStart(`${v772} ${v1141} #${v1160} ${v1()} / ${v1164}`, ...[]), ...[" ", "/"]);
}

export function method60(v0: US0_$union, v1: (() => string), v2_1: (() => string)): void {
    method17(v0, (): string => closure50(v0, v1, v2_1, undefined));
}

export function closure51(v0: string, unitVar: void): void {
    method5(true, v0);
}

export function method62(v0: string): (() => void) {
    return (): void => {
        closure51(v0, undefined);
    };
}

export function method63(v0: string): (() => void) {
    return (): void => {
        closure51(v0, undefined);
    };
}

export function closure52(unitVar: void, unitVar_1: void): string {
    return "file_system.create_dir";
}

export function closure53(v0: string, v1: string, unitVar: void): [string, string] {
    return [v0, v1] as [string, string];
}

export function method65(v0: Mut4, v1: string, v2_1: string): void {
    method15(v0, "{ ");
    method16(v0);
    method15(v0, "dir");
    method15(v0, " = ");
    method15(v0, v1);
    method15(v0, "; ");
    method15(v0, "result");
    method15(v0, " = ");
    method15(v0, v2_1);
    method15(v0, " }");
}

export function closure54(v0: US0_$union, v1: (() => string), v2_1: (() => [string, string]), unitVar: void): string {
    let v368: int64, v392: number;
    if (State_trace_state() == null) {
        State_trace_state(closure0(undefined, US0_US0_0()));
    }
    const patternInput: [Mut0, Mut1, Mut2, Mut3, Option<int64>] = value_3(State_trace_state());
    const v18_1: Option<int64> = patternInput[4];
    let _v35: Option<string> = undefined;
    const _v333: FSharpRef<Option<US2_$union>> = new FSharpRef<Option<US2_$union>>(undefined);
    let x_2: Option<US2_$union>;
    if (v18_1 == null) {
        x_2 = undefined;
    }
    else {
        const x: int64 = value_3(v18_1);
        x_2 = ((): US2_$union => US2_US2_0(x))();
    }
    _v333.contents = x_2;
    const v360: US2_$union = defaultArg(_v333.contents, US2_US2_1());
    const x_3: string = toString((v360.tag === /* US2_0 */ 0) ? ((v368 = v360.fields[0], (v392 = fromTicks(toInt64(op_Subtraction(getTicks(now()), v368))), create(1, 1, 1, hours(v392), minutes(v392), seconds(v392), milliseconds(v392))))) : now(), method12());
    _v35 = x_3;
    let v772: string;
    if (_v35 == null) {
        throw new Error("base.run_target / _v35=None");
    }
    else {
        v772 = value_3(_v35);
    }
    const v931: US3_$union = (v0.tag === /* US0_0 */ 0) ? US3_US3_0("Verbose") : US3_US3_1();
    let v980: US3_$union;
    if (v931.tag === /* US3_0 */ 0) {
        v980 = US3_US3_0(v931.fields[0]);
    }
    else {
        const v940: US3_$union = (v0.tag === /* US0_1 */ 1) ? US3_US3_0("Debug") : US3_US3_1();
        if (v940.tag === /* US3_0 */ 0) {
            v980 = US3_US3_0(v940.fields[0]);
        }
        else {
            const v949: US3_$union = (v0.tag === /* US0_2 */ 2) ? US3_US3_0("Info") : US3_US3_1();
            if (v949.tag === /* US3_0 */ 0) {
                v980 = US3_US3_0(v949.fields[0]);
            }
            else {
                const v958: US3_$union = (v0.tag === /* US0_3 */ 3) ? US3_US3_0("Warning") : US3_US3_1();
                if (v958.tag === /* US3_0 */ 0) {
                    v980 = US3_US3_0(v958.fields[0]);
                }
                else {
                    const v967: US3_$union = (v0.tag === /* US0_4 */ 4) ? US3_US3_0("Critical") : US3_US3_1();
                    v980 = ((v967.tag === /* US3_0 */ 0) ? US3_US3_0(v967.fields[0]) : US3_US3_1());
                }
            }
        }
    }
    let v984: string;
    if (v980.tag === /* US3_0 */ 0) {
        v984 = v980.fields[0];
    }
    else {
        throw new Error("Option does not have a value.");
    }
    const v997: string = padLeft(v984.toLocaleLowerCase(), 7, " ");
    let _v1029: Option<string> = undefined;
    const x_5: string = (((v0.tag === /* US0_1 */ 1) ? "\u001b[94m" : ((v0.tag === /* US0_2 */ 2) ? "\u001b[92m" : ((v0.tag === /* US0_0 */ 0) ? "\u001b[90m" : ((v0.tag === /* US0_3 */ 3) ? "\u001b[93m" : "\u001b[91m")))) + v997) + method13();
    _v1029 = x_5;
    let v1141: string;
    if (_v1029 == null) {
        throw new Error("base.run_target / _v1029=None");
    }
    else {
        v1141 = value_3(_v1029);
    }
    const v1160: int64 = patternInput[0].l0;
    const patternInput_1: [string, string] = v2_1();
    const v1164: Mut4 = new Mut4("");
    method65(v1164, patternInput_1[0], patternInput_1[1]);
    const v1165: string = v1164.l0;
    return trimEnd(trimStart(`${v772} ${v1141} #${v1160} ${v1()} / ${v1165}`, ...[]), ...[" ", "/"]);
}

export function method64(v0: US0_$union, v1: (() => string), v2_1: (() => [string, string])): void {
    method17(v0, (): string => closure54(v0, v1, v2_1, undefined));
}

export function closure55(v0: string, unitVar: void): void {
    let _v3: Option<any> = undefined;
    const x: any = defaultOf();
    _v3 = x;
    let v51: any;
    if (_v3 == null) {
        throw new Error("base.run_target / _v3=None");
    }
    else {
        v51 = value_3(_v3);
    }
    let _v68: Option<any> = undefined;
    const x_2: any = defaultOf();
    _v68 = x_2;
    let v116: any;
    if (_v68 == null) {
        throw new Error("base.run_target / _v68=None");
    }
    else {
        v116 = value_3(_v68);
    }
    let _v133: Option<void> = undefined;
    defaultOf();
    _v133 = some(undefined);
    if (_v133 == null) {
        throw new Error("base.run_target / _v133=None");
    }
    else {
        value_3(_v133);
    }
}

export function method66(v0: string): (() => void) {
    return (): void => {
        closure55(v0, undefined);
    };
}

export function method67(v0: string): (() => void) {
    return (): void => {
        closure55(v0, undefined);
    };
}

export function method54(v0: string): IDisposable {
    let _v3: Option<IDisposable> = undefined;
    let _v63: Option<any> = undefined;
    const x: any = defaultOf();
    _v63 = x;
    let v111: any;
    if (_v63 == null) {
        throw new Error("base.run_target / _v63=None");
    }
    else {
        v111 = value_3(_v63);
    }
    let _v128: Option<boolean> = undefined;
    const x_2: boolean = defaultOf();
    _v128 = x_2;
    let v175: boolean;
    if (_v128 == null) {
        throw new Error("base.run_target / _v128=None");
    }
    else {
        v175 = value_3(_v128);
    }
    if (v175 === false) {
        let _v193: Option<Date> = undefined;
        const x_4: Date = defaultOf();
        _v193 = x_4;
        const v258: string = toText(interpolate("%A%P()", [{
            CreationTime: (_v193 == null) ? (() => {
                throw new Error("base.run_target / _v193=None");
            })() : value_3(_v193),
            Exists: v175,
        }]));
        method64(US0_US0_1(), (): string => closure52(undefined, undefined), (): [string, string] => closure53(v0, v258, undefined));
    }
    let _v270: Option<IDisposable> = undefined;
    const v277: (() => void) = method67(v0);
    const x_6: IDisposable = {
        Dispose(): void {
            v277();
        },
    };
    _v270 = x_6;
    let x_8: IDisposable;
    if (_v270 == null) {
        throw new Error("base.run_target / _v270=None");
    }
    else {
        x_8 = value_3(_v270);
    }
    _v3 = x_8;
    if (_v3 == null) {
        throw new Error("base.run_target / _v3=None");
    }
    else {
        return value_3(_v3);
    }
}

export function closure41(unitVar: void, unitVar_1: void): [string, IDisposable] {
    const v0: string = method41();
    return [v0, method54(v0)] as [string, IDisposable];
}

export function method68(v0: string): string {
    let _v3: Option<string> = undefined;
    const v97: string = padLeft(v0, 32, "0");
    const x: string = parse(`${v97.slice(0, 7 + 1)}-${v97.slice(8, 11 + 1)}-${v97.slice(12, 15 + 1)}-${v97.slice(16, 19 + 1)}-${v97.slice(20, 31 + 1)}`);
    _v3 = x;
    if (_v3 == null) {
        throw new Error("base.run_target / _v3=None");
    }
    else {
        return value_3(_v3);
    }
}

export function closure56(unitVar: void, v0: string): [string, IDisposable] {
    const v2_1: string = method46(method68(v0));
    return [v2_1, method54(v2_1)] as [string, IDisposable];
}

export function closure57(unitVar: void, unitVar_1: void): string {
    return "C:\\home\\git\\polyglot\\lib\\spiral";
}

export function method70(): string {
    return "";
}

export function method71(v0: string): string {
    return v0;
}

export function method72(): string {
    return "^\\\\\\\\\\?\\\\";
}

export function method69(v0: string): string {
    let _arg: string;
    if (v0 === "") {
        return "";
    }
    else {
        const v4: string = method70();
        let _v7: Option<string> = undefined;
        const x: string = defaultOf();
        _v7 = x;
        let v58: string;
        if (_v7 == null) {
            throw new Error("base.run_target / _v7=None");
        }
        else {
            v58 = value_3(_v7);
        }
        return replace(`${(_arg = v58[0], _arg.toLocaleLowerCase())}${v58.slice(1, v58.length)}`, "\\", "/");
    }
}

export function closure58(unitVar: void, v0: string): string {
    return method69(v0);
}

export function closure59(unitVar: void, v0: string): string {
    return `file:///${trimStart(v0, ...["/"])}`;
}

export function method75(v0: string): Option<string> {
    let _v3: Option<US3_$union> = undefined;
    const v89: IPathDirname = path;
    const x: US3_$union = US3_US3_0(v89.dirname(v0));
    _v3 = x;
    let v189: US3_$union;
    if (_v3 == null) {
        throw new Error("base.run_target / _v3=None");
    }
    else {
        v189 = value_3(_v3);
    }
    if (v189.tag === /* US3_0 */ 0) {
        return v189.fields[0];
    }
    else {
        return undefined;
    }
}

export function closure61(unitVar: void, v0: string): Option<string> {
    return method75(v0);
}

export function method74(): ((arg0: string) => Option<string>) {
    return (v: string): Option<string> => closure61(undefined, v);
}

export function method76(v0_mut: string, v1_mut: string, v2_1_mut: string): US13_$union {
    method76:
    while (true) {
        const v0: string = v0_mut, v1: string = v1_mut, v2_1: string = v2_1_mut;
        if (method7(method49(v2_1, v0))) {
            return US13_US13_0(v2_1);
        }
        else {
            const v7: Option<string> = method74()(v2_1);
            const _v10: FSharpRef<Option<US3_$union>> = new FSharpRef<Option<US3_$union>>(undefined);
            let x_2: Option<US3_$union>;
            if (v7 == null) {
                x_2 = undefined;
            }
            else {
                const x: string = value_3(v7);
                x_2 = ((): US3_$union => US3_US3_0(x))();
            }
            _v10.contents = x_2;
            const v37: US3_$union = defaultArg(_v10.contents, US3_US3_1());
            if (v37.tag === /* US3_0 */ 0) {
                v0_mut = v0;
                v1_mut = v1;
                v2_1_mut = v37.fields[0];
                continue method76;
            }
            else {
                return US13_US13_1(`No parent for ${"dir"} '${v0}' at '${v1}' (until '${v2_1}')`);
            }
        }
        break;
    }
}

export function method73(v0: string, v1: string): US13_$union {
    if (method7(method49(v1, v0))) {
        return US13_US13_0(v1);
    }
    else {
        const v6: Option<string> = method74()(v1);
        const _v9: FSharpRef<Option<US3_$union>> = new FSharpRef<Option<US3_$union>>(undefined);
        let x_2: Option<US3_$union>;
        if (v6 == null) {
            x_2 = undefined;
        }
        else {
            const x: string = value_3(v6);
            x_2 = ((): US3_$union => US3_US3_0(x))();
        }
        _v9.contents = x_2;
        const v36: US3_$union = defaultArg(_v9.contents, US3_US3_1());
        if (v36.tag === /* US3_0 */ 0) {
            return method76(v0, v1, v36.fields[0]);
        }
        else {
            return US13_US13_1(`No parent for ${"dir"} '${v0}' at '${v1}' (until '${v1}')`);
        }
    }
}

export function closure62(unitVar: void, unitVar_1: void): string {
    return "file_system.get_workspace_root";
}

export function closure63(v0: string, unitVar: void): string {
    return v0;
}

export function method78(v0: Mut4, v1: string): void {
    method15(v0, "{ ");
    method16(v0);
    method15(v0, "error");
    method15(v0, " = ");
    method15(v0, v1);
    method15(v0, " }");
}

export function closure64(v0: US0_$union, v1: (() => string), v2_1: (() => string), unitVar: void): string {
    let v368: int64, v392: number;
    if (State_trace_state() == null) {
        State_trace_state(closure0(undefined, US0_US0_0()));
    }
    const patternInput: [Mut0, Mut1, Mut2, Mut3, Option<int64>] = value_3(State_trace_state());
    const v18_1: Option<int64> = patternInput[4];
    let _v35: Option<string> = undefined;
    const _v333: FSharpRef<Option<US2_$union>> = new FSharpRef<Option<US2_$union>>(undefined);
    let x_2: Option<US2_$union>;
    if (v18_1 == null) {
        x_2 = undefined;
    }
    else {
        const x: int64 = value_3(v18_1);
        x_2 = ((): US2_$union => US2_US2_0(x))();
    }
    _v333.contents = x_2;
    const v360: US2_$union = defaultArg(_v333.contents, US2_US2_1());
    const x_3: string = toString((v360.tag === /* US2_0 */ 0) ? ((v368 = v360.fields[0], (v392 = fromTicks(toInt64(op_Subtraction(getTicks(now()), v368))), create(1, 1, 1, hours(v392), minutes(v392), seconds(v392), milliseconds(v392))))) : now(), method12());
    _v35 = x_3;
    let v772: string;
    if (_v35 == null) {
        throw new Error("base.run_target / _v35=None");
    }
    else {
        v772 = value_3(_v35);
    }
    const v931: US3_$union = (v0.tag === /* US0_0 */ 0) ? US3_US3_0("Verbose") : US3_US3_1();
    let v980: US3_$union;
    if (v931.tag === /* US3_0 */ 0) {
        v980 = US3_US3_0(v931.fields[0]);
    }
    else {
        const v940: US3_$union = (v0.tag === /* US0_1 */ 1) ? US3_US3_0("Debug") : US3_US3_1();
        if (v940.tag === /* US3_0 */ 0) {
            v980 = US3_US3_0(v940.fields[0]);
        }
        else {
            const v949: US3_$union = (v0.tag === /* US0_2 */ 2) ? US3_US3_0("Info") : US3_US3_1();
            if (v949.tag === /* US3_0 */ 0) {
                v980 = US3_US3_0(v949.fields[0]);
            }
            else {
                const v958: US3_$union = (v0.tag === /* US0_3 */ 3) ? US3_US3_0("Warning") : US3_US3_1();
                if (v958.tag === /* US3_0 */ 0) {
                    v980 = US3_US3_0(v958.fields[0]);
                }
                else {
                    const v967: US3_$union = (v0.tag === /* US0_4 */ 4) ? US3_US3_0("Critical") : US3_US3_1();
                    v980 = ((v967.tag === /* US3_0 */ 0) ? US3_US3_0(v967.fields[0]) : US3_US3_1());
                }
            }
        }
    }
    let v984: string;
    if (v980.tag === /* US3_0 */ 0) {
        v984 = v980.fields[0];
    }
    else {
        throw new Error("Option does not have a value.");
    }
    const v997: string = padLeft(v984.toLocaleLowerCase(), 7, " ");
    let _v1029: Option<string> = undefined;
    const x_5: string = (((v0.tag === /* US0_1 */ 1) ? "\u001b[94m" : ((v0.tag === /* US0_2 */ 2) ? "\u001b[92m" : ((v0.tag === /* US0_0 */ 0) ? "\u001b[90m" : ((v0.tag === /* US0_3 */ 3) ? "\u001b[93m" : "\u001b[91m")))) + v997) + method13();
    _v1029 = x_5;
    let v1141: string;
    if (_v1029 == null) {
        throw new Error("base.run_target / _v1029=None");
    }
    else {
        v1141 = value_3(_v1029);
    }
    const v1160: int64 = patternInput[0].l0;
    const v1163: Mut4 = new Mut4("");
    method78(v1163, v2_1());
    const v1164: string = v1163.l0;
    return trimEnd(trimStart(`${v772} ${v1141} #${v1160} ${v1()} / ${v1164}`, ...[]), ...[" ", "/"]);
}

export function method77(v0: US0_$union, v1: (() => string), v2_1: (() => string)): void {
    method17(v0, (): string => closure64(v0, v1, v2_1, undefined));
}

export function method79(): string {
    let _v2: Option<string> = undefined;
    const x: string = defaultOf();
    _v2 = x;
    if (_v2 == null) {
        throw new Error("base.run_target / _v2=None");
    }
    else {
        return value_3(_v2);
    }
}

export function closure60(unitVar: void, unitVar_1: void): string {
    const v4: US13_$union = method73(method49("polyglot", ".devcontainer"), "C:\\home\\git\\polyglot\\lib\\spiral");
    let v13_1: US3_$union;
    if (v4.tag === /* US13_0 */ 0) {
        v13_1 = US3_US3_0(v4.fields[0]);
    }
    else {
        const v7: string = v4.fields[0];
        method77(US0_US0_3(), (): string => closure62(undefined, undefined), (): string => closure63(v7, undefined));
        v13_1 = US3_US3_1();
    }
    let v29: US3_$union;
    if (v13_1.tag === /* US3_0 */ 0) {
        v29 = US3_US3_0(v13_1.fields[0]);
    }
    else {
        const v16_1: string = method79();
        const v18_1: US13_$union = method73(method49("polyglot", ".devcontainer"), v16_1);
        if (v18_1.tag === /* US13_0 */ 0) {
            v29 = US3_US3_0(v18_1.fields[0]);
        }
        else {
            const v21_1: string = v18_1.fields[0];
            method77(US0_US0_3(), (): string => closure62(undefined, undefined), (): string => closure63(v21_1, undefined));
            v29 = US3_US3_1();
        }
    }
    return method49((v29.tag === /* US3_0 */ 0) ? v29.fields[0] : (() => {
        throw new Error("Option does not have a value.");
    })(), "polyglot");
}

export function method80(v0: string): void {
    let _v3: Option<void> = undefined;
    _v3 = some(undefined);
    if (_v3 == null) {
        throw new Error("base.run_target / _v3=None");
    }
    else {
        value_3(_v3);
    }
}

export function closure66(unitVar: void, v0: string): void {
    method80(v0);
}

export function closure65(unitVar: void, v0: boolean): void {
    if (State_trace_state() == null) {
        State_trace_state(closure0(undefined, US0_US0_0()));
    }
    const patternInput: [Mut0, Mut1, Mut2, Mut3, Option<int64>] = value_3(State_trace_state());
    const v33: ((arg0: string) => void) = v0 ? ((v_1: string): void => {
        closure66(undefined, v_1);
    }) : ((v_2: string): void => {
        closure1(undefined, v_2);
    });
    patternInput[1].l0 = v33;
}

export function closure68(v0: string, v1: string): string {
    return method49(v0, v1);
}

export function closure67(unitVar: void, v0: string): ((arg0: string) => string) {
    return (v: string): string => closure68(v0, v);
}

export const v2 = (v: US0_$union): [Mut0, Mut1, Mut2, Mut3, Option<int64>] => closure0(undefined, v);

export const v3: US0_$union = US0_US0_0();

if (State_trace_state() == null) {
    State_trace_state(v2(v3));
}

export const v9 = (v: string): any => closure2(undefined, v);

export function delete_directory_async(x: string): any {
    return v9(x);
}

export const v10 = (v: US6_$union): ((arg0: string) => any) => closure6(undefined, v);

export function wait_for_file_access(x: US6_$union): ((arg0: string) => any) {
    return v10(x);
}

export const v11 = (v: string): any => closure11(undefined, v);

export function wait_for_file_access_read(x: string): any {
    return v11(x);
}

export const v12 = (v: string): any => closure12(undefined, v);

export function read_all_text_async(x: string): any {
    return v12(x);
}

export const v13 = (v: string): ((arg0: string) => boolean) => closure13(undefined, v);

export function file_exists_content(x: string): ((arg0: string) => boolean) {
    return v13(x);
}

export const v14 = (v: string): ((arg0: string) => any) => closure15(undefined, v);

export function write_all_text_async(x: string): ((arg0: string) => any) {
    return v14(x);
}

export const v15 = (v: string): ((arg0: string) => any) => closure17(undefined, v);

export function write_all_text_exists(x: string): ((arg0: string) => any) {
    return v15(x);
}

export const v16 = (v: string): any => closure19(undefined, v);

export function delete_file_async(x: string): any {
    return v16(x);
}

export const v17 = (v: string): ((arg0: string) => any) => closure23(undefined, v);

export function move_file_async(x: string): ((arg0: string) => any) {
    return v17(x);
}

export const v18 = (v: string): any => closure28(undefined, v);

export function read_all_text_retry_async(x: string): any {
    return v18(x);
}

export const v19 = (): string => closure40(undefined, undefined);

export function create_temp_path(): string {
    return v19();
}

export const v20 = (): [string, IDisposable] => closure41(undefined, undefined);

export function create_temp_dir(): [string, IDisposable] {
    return v20();
}

export const v21 = (v: string): [string, IDisposable] => closure56(undefined, v);

export function create_temp_dir$0027(x: string): [string, IDisposable] {
    return v21(x);
}

export const v22 = (): string => closure57(undefined, undefined);

export function get_source_directory(): string {
    return v22();
}

export const v23 = (v: string): string => closure58(undefined, v);

export function normalize_path(x: string): string {
    return v23(x);
}

export const v24 = (v: string): string => closure59(undefined, v);

export function new_file_uri(x: string): string {
    return v24(x);
}

export const v25 = (): string => closure60(undefined, undefined);

export function get_workspace_root(): string {
    return v25();
}

export const v26 = (v: boolean): void => {
    closure65(undefined, v);
};

export function init_trace_file(x: boolean): void {
    v26(x);
}

export const v27 = (v: string): ((arg0: string) => string) => closure67(undefined, v);

export function op_LessDivideGreater(x: string): ((arg0: string) => string) {
    return v27(x);
}


