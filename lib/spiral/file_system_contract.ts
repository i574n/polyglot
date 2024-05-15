import { compare, defaultOf, IComparable, IEquatable, IDisposable, createAtom } from "../../../polyglot/deps/Fable/src/fable-library-ts/Util.js";
import { map, defaultArg, value as value_3, some, Option } from "../../../polyglot/deps/Fable/src/fable-library-ts/Option.js";
import { op_Addition, toInt64, int64 } from "../../../polyglot/deps/Fable/src/fable-library-ts/BigInt.js";
import { lambda_type, unit_type, string_type, union_type, bool_type, record_type, int64_type, class_type, TypeInfo } from "../../../polyglot/deps/Fable/src/fable-library-ts/Reflection.js";
import { FSharpRef, Union, Record } from "../../../polyglot/deps/Fable/src/fable-library-ts/Types.js";
import { replace, interpolate, toText, trimStart, trimEnd, padRight } from "../../../polyglot/deps/Fable/src/fable-library-ts/String.js";
import { ofSeq, find } from "../../../polyglot/deps/Fable/src/fable-library-ts/Map.js";
import { int32 } from "../../../polyglot/deps/Fable/src/fable-library-ts/Int32.js";
import * as fs from "fs";
import * as path from "path";

export let State_trace_state = createAtom<Option<[Mut0, Mut1, Mut2, Option<int64>, Mut3]>>(undefined);

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

export class Mut1 extends Record implements IEquatable<Mut1>, IComparable<Mut1> {
    l0: boolean;
    constructor(l0: boolean) {
        super();
        this.l0 = l0;
    }
}

export function Mut1_$reflection(): TypeInfo {
    return record_type("File_system.Mut1", [], Mut1, () => [["l0", bool_type]]);
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

export class Mut2 extends Record implements IEquatable<Mut2>, IComparable<Mut2> {
    l0: US0_$union;
    constructor(l0: US0_$union) {
        super();
        this.l0 = l0;
    }
}

export function Mut2_$reflection(): TypeInfo {
    return record_type("File_system.Mut2", [], Mut2, () => [["l0", US0_$reflection()]]);
}

export class Mut3 extends Record {
    l0: ((arg0: string) => void);
    constructor(l0: ((arg0: string) => void)) {
        super();
        this.l0 = l0;
    }
}

export function Mut3_$reflection(): TypeInfo {
    return record_type("File_system.Mut3", [], Mut3, () => [["l0", lambda_type(string_type, unit_type)]]);
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
    return union_type("File_system.US1", [], US1, () => [[["f0_0", int64_type]], []]);
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
    0: ["US5_0", []],
    1: ["US5_1", []],
    2: ["US5_2", []],
    3: ["US5_3", []],
    4: ["US5_4", []]
}

export function US5_US5_0() {
    return new US5<0>(0, []);
}

export function US5_US5_1() {
    return new US5<1>(1, []);
}

export function US5_US5_2() {
    return new US5<2>(2, []);
}

export function US5_US5_3() {
    return new US5<3>(3, []);
}

export function US5_US5_4() {
    return new US5<4>(4, []);
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
    return union_type("File_system.US5", [], US5, () => [[], [], [], [], []]);
}

export type US3_$union =
    | US3<0>
    | US3<1>

export type US3_$cases = {
    0: ["US3_0", [US4_$union, US5_$union]],
    1: ["US3_1", []]
}

export function US3_US3_0(f0_0: US4_$union, f0_1: US5_$union) {
    return new US3<0>(0, [f0_0, f0_1]);
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
    return union_type("File_system.US3", [], US3, () => [[["f0_0", US4_$reflection()], ["f0_1", US5_$reflection()]], []]);
}

export type US6_$union =
    | US6<0>
    | US6<1>

export type US6_$cases = {
    0: ["US6_0", [int64]],
    1: ["US6_1", [Error]]
}

export function US6_US6_0(f0_0: int64) {
    return new US6<0>(0, [f0_0]);
}

export function US6_US6_1(f1_0: Error) {
    return new US6<1>(1, [f1_0]);
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
    return union_type("File_system.US6", [], US6, () => [[["f0_0", int64_type]], [["f1_0", class_type("System.Exception")]]]);
}

export type US7_$union =
    | US7<0>
    | US7<1>

export type US7_$cases = {
    0: ["US7_0", [int64]],
    1: ["US7_1", [Error]]
}

export function US7_US7_0(f0_0: int64) {
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
    return union_type("File_system.US7", [], US7, () => [[["f0_0", int64_type]], [["f1_0", class_type("System.Exception")]]]);
}

export type US8_$union =
    | US8<0>
    | US8<1>

export type US8_$cases = {
    0: ["US8_0", [any]],
    1: ["US8_1", []]
}

export function US8_US8_0(f0_0: any) {
    return new US8<0>(0, [f0_0]);
}

export function US8_US8_1() {
    return new US8<1>(1, []);
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
    return union_type("File_system.US8", [], US8, () => [[["f0_0", string_type]], []]);
}

export type US9_$union =
    | US9<0>
    | US9<1>

export type US9_$cases = {
    0: ["US9_0", [string]],
    1: ["US9_1", []]
}

export function US9_US9_0(f0_0: string) {
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
    return union_type("File_system.US9", [], US9, () => [[["f0_0", string_type]], []]);
}

export type US10_$union =
    | US10<0>
    | US10<1>

export type US10_$cases = {
    0: ["US10_0", []],
    1: ["US10_1", [any]]
}

export function US10_US10_0() {
    return new US10<0>(0, []);
}

export function US10_US10_1(f1_0: any) {
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
    return union_type("File_system.US10", [], US10, () => [[], [["f1_0", string_type]]]);
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

export function US4__get_IsUS4_2(this$: FSharpRef<US4_$union>, unitArg: void): boolean {
    if ((this$ as any)['tag'] === 2) {
        return true;
    }
    else {
        return false;
    }
}

export function US5__get_IsUS5_0(this$: FSharpRef<US5_$union>, unitArg: void): boolean {
    if ((this$ as any)['tag'] === 0) {
        return true;
    }
    else {
        return false;
    }
}

export function US5__get_IsUS5_1(this$: FSharpRef<US5_$union>, unitArg: void): boolean {
    if ((this$ as any)['tag'] === 1) {
        return true;
    }
    else {
        return false;
    }
}

export function US5__get_IsUS5_2(this$: FSharpRef<US5_$union>, unitArg: void): boolean {
    if ((this$ as any)['tag'] === 2) {
        return true;
    }
    else {
        return false;
    }
}

export function US5__get_IsUS5_3(this$: FSharpRef<US5_$union>, unitArg: void): boolean {
    if ((this$ as any)['tag'] === 3) {
        return true;
    }
    else {
        return false;
    }
}

export function US5__get_IsUS5_4(this$: FSharpRef<US5_$union>, unitArg: void): boolean {
    if ((this$ as any)['tag'] === 4) {
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

export function US6__get_IsUS6_0(this$: FSharpRef<US6_$union>, unitArg: void): boolean {
    if ((this$ as any)['tag'] === 0) {
        return true;
    }
    else {
        return false;
    }
}

export function US6__get_IsUS6_1(this$: FSharpRef<US6_$union>, unitArg: void): boolean {
    if ((this$ as any)['tag'] === 1) {
        return true;
    }
    else {
        return false;
    }
}

export function US7__get_IsUS7_0(this$: FSharpRef<US7_$union>, unitArg: void): boolean {
    if ((this$ as any)['tag'] === 0) {
        return true;
    }
    else {
        return false;
    }
}

export function US7__get_IsUS7_1(this$: FSharpRef<US7_$union>, unitArg: void): boolean {
    if ((this$ as any)['tag'] === 1) {
        return true;
    }
    else {
        return false;
    }
}

export function US8__get_IsUS8_0(this$: FSharpRef<US8_$union>, unitArg: void): boolean {
    if ((this$ as any)['tag'] === 0) {
        return true;
    }
    else {
        return false;
    }
}

export function US8__get_IsUS8_1(this$: FSharpRef<US8_$union>, unitArg: void): boolean {
    if ((this$ as any)['tag'] === 1) {
        return true;
    }
    else {
        return false;
    }
}

export function US9__get_IsUS9_0(this$: FSharpRef<US9_$union>, unitArg: void): boolean {
    if ((this$ as any)['tag'] === 0) {
        return true;
    }
    else {
        return false;
    }
}

export function US9__get_IsUS9_1(this$: FSharpRef<US9_$union>, unitArg: void): boolean {
    if ((this$ as any)['tag'] === 1) {
        return true;
    }
    else {
        return false;
    }
}

export function US10__get_IsUS10_0(this$: FSharpRef<US10_$union>, unitArg: void): boolean {
    if ((this$ as any)['tag'] === 0) {
        return true;
    }
    else {
        return false;
    }
}

export function US10__get_IsUS10_1(this$: FSharpRef<US10_$union>, unitArg: void): boolean {
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
    const v3_1: Mut2 = new Mut2(US0_US0_0());
    const v5_1: Mut3 = new Mut3((v: string): void => {
        closure1(undefined, v);
    });
    let _v6: Option<Option<int64>> = undefined;
    const x: Option<int64> = method1(undefined);
    _v6 = some(x);
    return [v1_1, v0_1, v3_1, value_3(_v6), v5_1] as [Mut0, Mut1, Mut2, Option<int64>, Mut3];
}

export function closure3(unitVar: void, unitVar_1: void): string {
    return "file_system.delete_directory_async";
}

export function closure5(unitVar: void, v0_1: string): string {
    let _v1: Option<string> = undefined;
    const x: string = defaultOf();
    _v1 = x;
    return value_3(_v1);
}

export function closure6(unitVar: void, unitVar_1: void): string {
    return "";
}

export function closure4(v0_1: string, v1_1: string, unitVar: void): string {
    return `path: ${closure5(undefined, v0_1)} / ex: ${v1_1} / ${closure6(undefined, undefined)}`;
}

export function closure8(unitVar: void, v0_1: int64): US2_$union {
    return US2_US2_0(v0_1);
}

export function method4(): ((arg0: int64) => US2_$union) {
    return (v: int64): US2_$union => closure8(undefined, v);
}

export function method5(): string {
    return "";
}

export function closure7(v0_1: US0_$union, v1_1: (() => string), v2_1: (() => string), unitVar: void): string {
    if (State_trace_state() == null) {
        State_trace_state(closure0(undefined, undefined));
    }
    const patternInput: [Mut0, Mut1, Mut2, Option<int64>, Mut3] = value_3(State_trace_state());
    let _v9: Option<string> = undefined;
    const x: string = method5();
    _v9 = x;
    const v61: string = value_3(_v9);
    const v62: int64 = patternInput[0].l0;
    const v72: string = (v0_1.tag === /* US0_1 */ 1) ? "Debug" : ((v0_1.tag === /* US0_2 */ 2) ? "Info" : ((v0_1.tag === /* US0_0 */ 0) ? "Verbose" : ((v0_1.tag === /* US0_3 */ 3) ? "Warning" : "Critical")));
    let _v75: Option<string> = undefined;
    const x_1: string = padRight(v72.toLocaleLowerCase(), 7, " ");
    _v75 = x_1;
    return trimEnd(trimStart(`${v61} ${value_3(_v75)} #${v62} ${v1_1()} / ${v2_1()}`), " ", "/");
}

export function method6(v0_1: US0_$union, v1_1: (() => string)): void {
    const v2_1 = (): [Mut0, Mut1, Mut2, Option<int64>, Mut3] => closure0(undefined, undefined);
    if (State_trace_state() == null) {
        State_trace_state(v2_1());
    }
    const patternInput: [Mut0, Mut1, Mut2, Option<int64>, Mut3] = value_3(State_trace_state());
    const v3_1: Mut0 = patternInput[0];
    if (State_trace_state() == null) {
        State_trace_state(v2_1());
    }
    const patternInput_1: [Mut0, Mut1, Mut2, Option<int64>, Mut3] = value_3(State_trace_state());
    const v13_1: US0_$union = patternInput_1[2].l0;
    if ((patternInput_1[1].l0 === false) ? false : (find<US0_$union, int32>(v0_1, ofSeq([[US0_US0_0(), 0] as [US0_$union, int32], [US0_US0_1(), 1] as [US0_$union, int32], [US0_US0_2(), 2] as [US0_$union, int32], [US0_US0_3(), 3] as [US0_$union, int32], [US0_US0_4(), 4] as [US0_$union, int32]], {
        Compare: compare,
    })) >= find<US0_$union, int32>(v13_1, ofSeq([[US0_US0_0(), 0] as [US0_$union, int32], [US0_US0_1(), 1] as [US0_$union, int32], [US0_US0_2(), 2] as [US0_$union, int32], [US0_US0_3(), 3] as [US0_$union, int32], [US0_US0_4(), 4] as [US0_$union, int32]], {
        Compare: compare,
    })))) {
        const v21: int64 = toInt64(op_Addition(v3_1.l0, 1n));
        v3_1.l0 = v21;
        const v22 = `${v1_1()}`;
        let _v23: Option<void> = undefined;
        console.log(v22);
        _v23 = some(undefined);
        value_3(_v23);
        patternInput[4].l0(v22);
    }
}

export function method3(v0_1: US0_$union, v1_1: (() => string), v2_1: (() => string)): void {
    method6(v0_1, (): string => closure7(v0_1, v1_1, v2_1, undefined));
}

export function method2(v0_1: string, v1_1: int64): any {
    let _v2: Option<any> = undefined;
    const x: any = defaultOf();
    _v2 = x;
    return value_3(_v2);
}

export function closure2(unitVar: void, v0_1: string): any {
    let _v1: Option<any> = undefined;
    const x: any = defaultOf();
    _v1 = x;
    return value_3(_v1);
}

export function closure11(unitVar: void, unitVar_1: void): string {
    return "file_system.wait_for_file_access";
}

export function closure12(v0_1: string, v1_1: int64, v2_1: string, unitVar: void): string {
    return `path: ${closure5(undefined, v0_1)} / retry: ${v1_1} / ex: ${v2_1} / ${closure6(undefined, undefined)}`;
}

export function method7(v0_1: string, v1_1: US5_$union, v2_1: US4_$union, v3_1: int64): any {
    let _v4: Option<any> = undefined;
    const x: any = defaultOf();
    _v4 = x;
    return value_3(_v4);
}

export function closure10(v0_1: US3_$union, v1_1: string): any {
    let _v2: Option<any> = undefined;
    const x: any = defaultOf();
    _v2 = x;
    return value_3(_v2);
}

export function closure9(unitVar: void, v0_1: US3_$union): ((arg0: string) => any) {
    return (v: string): any => closure10(v0_1, v);
}

export function method8(v0_1: string, v1_1: int64): any {
    let _v2: Option<any> = undefined;
    const x: any = defaultOf();
    _v2 = x;
    return value_3(_v2);
}

export function closure13(unitVar: void, v0_1: string): any {
    let _v1: Option<any> = undefined;
    const x: any = defaultOf();
    _v1 = x;
    return value_3(_v1);
}

export function closure14(unitVar: void, v0_1: string): any {
    let _v1: Option<any> = undefined;
    const x: any = defaultOf();
    _v1 = x;
    return value_3(_v1);
}

export function method9(v0_1: string): string {
    return v0_1;
}

export function closure16(v0_1: string, v1_1: string): any {
    let _v2: Option<any> = undefined;
    const x: any = defaultOf();
    _v2 = x;
    return value_3(_v2);
}

export function closure15(unitVar: void, v0_1: string): ((arg0: string) => any) {
    return (v: string): any => closure16(v0_1, v);
}

export function closure18(v0_1: string, v1_1: string): any {
    let _v2: Option<any> = undefined;
    const x: any = defaultOf();
    _v2 = x;
    return value_3(_v2);
}

export function closure17(unitVar: void, v0_1: string): ((arg0: string) => any) {
    return (v: string): any => closure18(v0_1, v);
}

export function closure20(v0_1: string, v1_1: string): any {
    let _v2: Option<any> = undefined;
    const x: any = defaultOf();
    _v2 = x;
    return value_3(_v2);
}

export function closure19(unitVar: void, v0_1: string): ((arg0: string) => any) {
    return (v: string): any => closure20(v0_1, v);
}

export function closure22(unitVar: void, unitVar_1: void): string {
    return "delete_file_async";
}

export function closure23(v0_1: string, v1_1: Error, unitVar: void): string {
    let _v2: Option<string> = undefined;
    const x: string = toText(interpolate("%A%P()", [v1_1]));
    _v2 = x;
    const v10_1: string = value_3(_v2);
    return `path: ${closure5(undefined, v0_1)} / ex: ${v10_1} / ${closure6(undefined, undefined)}`;
}

export function method10(v0_1: string, v1_1: int64): any {
    let _v2: Option<any> = undefined;
    const x: any = defaultOf();
    _v2 = x;
    return value_3(_v2);
}

export function closure21(unitVar: void, v0_1: string): any {
    let _v1: Option<any> = undefined;
    const x: any = defaultOf();
    _v1 = x;
    return value_3(_v1);
}

export function closure26(unitVar: void, unitVar_1: void): string {
    return "move_file_async";
}

export function closure27(v0_1: string, v1_1: string, v2_1: Error, unitVar: void): string {
    let _v3: Option<string> = undefined;
    const x: string = toText(interpolate("%A%P()", [v2_1]));
    _v3 = x;
    const v11_1: string = value_3(_v3);
    const v12_1 = (v: string): string => closure5(undefined, v);
    return `old_path: ${v12_1(v1_1)} / new_path: ${v12_1(v0_1)} / ex: ${v11_1} / ${closure6(undefined, undefined)}`;
}

export function method11(v0_1: string, v1_1: string, v2_1: int64): any {
    let _v3: Option<any> = undefined;
    const x: any = defaultOf();
    _v3 = x;
    return value_3(_v3);
}

export function closure25(v0_1: string, v1_1: string): any {
    let _v2: Option<any> = undefined;
    const x: any = defaultOf();
    _v2 = x;
    return value_3(_v2);
}

export function closure24(unitVar: void, v0_1: string): ((arg0: string) => any) {
    return (v: string): any => closure25(v0_1, v);
}

export function closure29(unitVar: void, v0_1: int64): US6_$union {
    return US6_US6_0(v0_1);
}

export function closure30(unitVar: void, v0_1: Error): US6_$union {
    return US6_US6_1(v0_1);
}

export function closure31(unitVar: void, unitVar_1: void): string {
    return "run_with_timeout_async";
}

export function closure32(unitVar: void, unitVar_1: void): string {
    return `timeout: ${1000} / ${closure6(undefined, undefined)}`;
}

export function closure33(v0_1: string, unitVar: void): string {
    return `run_with_timeout_async** / ex: ${v0_1}`;
}

export function closure34(unitVar: void, unitVar_1: void): string {
    return "read_all_text_retry_async";
}

export function method13(v0_1: int64, v1_1: string): string {
    return `retry: ${v0_1} / ex: ${v1_1} / ${closure6(undefined, undefined)}`;
}

export function closure35(v0_1: int64, v1_1: string, unitVar: void): string {
    return method13(v0_1, v1_1);
}

export function method12(v0_1: string, v1_1: int64): any {
    let _v2: Option<any> = undefined;
    const x: any = defaultOf();
    _v2 = x;
    return value_3(_v2);
}

export function closure28(unitVar: void, v0_1: string): any {
    let _v1: Option<any> = undefined;
    const x: any = defaultOf();
    _v1 = x;
    return value_3(_v1);
}

export function method14(v0_1: string): string {
    return v0_1;
}

export function method15(v0_1: string): string {
    return v0_1;
}

export function closure37(unitVar: void, v0_1: any): US8_$union {
    return US8_US8_0(v0_1);
}

export function method16(): ((arg0: any) => US8_$union) {
    return (v: any): US8_$union => closure37(undefined, v);
}

export function method17(v0_1: any): any {
    return v0_1;
}

export function method18(v0_1: any): any {
    return v0_1;
}

export function method19(): string {
    return "yyyyMMdd-HHmm-ssff-ffff-f";
}

export function method20(): string {
    return "hhmm";
}

export function closure36(unitVar: void, unitVar_1: void): string {
    let _v0: Option<string> = undefined;
    const x: string = defaultOf();
    _v0 = x;
    return value_3(_v0);
}

export function method21(v0_1: string): string {
    return v0_1;
}

export function closure39(unitVar: void, v0_1: any): any {
    let _v1: Option<any> = undefined;
    const x: any = defaultOf();
    _v1 = x;
    return value_3(_v1);
}

export function method22(): ((arg0: any) => any) {
    return (v: any): any => closure39(undefined, v);
}

export function closure40(unitVar: void, unitVar_1: void): US10_$union {
    return US10_US10_0();
}

export function closure41(unitVar: void, v0_1: any): US10_$union {
    return US10_US10_1(v0_1);
}

export function closure42(unitVar: void, unitVar_1: void): string {
    return "file_system.create_directory";
}

export function closure43(v0_1: string, v1_1: any, unitVar: void): string {
    return `dir: ${v0_1} / error: ${v1_1} / ${closure6(undefined, undefined)}`;
}

export function closure44(unitVar: void, unitVar_1: void): string {
    return "file_system.create_directory";
}

export function closure45(v0_1: string, unitVar: void): string {
    return `dir: ${v0_1} / ${closure6(undefined, undefined)}`;
}

export function closure46(v0_1: string, unitVar: void): void {
    let _v1: Option<void> = undefined;
    defaultOf();
    _v1 = some(undefined);
    value_3(_v1);
}

export function method23(v0_1: string): (() => void) {
    return (): void => {
        closure46(v0_1, undefined);
    };
}

export function closure47(unitVar: void, unitVar_1: void): string {
    return "file_system.create_directory";
}

export function closure48(v0_1: string, v1_1: string, unitVar: void): string {
    return `dir: ${v0_1} / result: ${v1_1} ${closure6(undefined, undefined)}`;
}

export function closure49(v0_1: string, unitVar: void): void {
    let _v1: Option<any> = undefined;
    const x: any = defaultOf();
    _v1 = x;
    const v10_1: any = value_3(_v1);
    let _v11: Option<any> = undefined;
    const x_1: any = defaultOf();
    _v11 = x_1;
    const v20: any = value_3(_v11);
    let _v21: Option<void> = undefined;
    defaultOf();
    _v21 = some(undefined);
    value_3(_v21);
}

export function method24(v0_1: string): (() => void) {
    return (): void => {
        closure49(v0_1, undefined);
    };
}

export function closure38(unitVar: void, unitVar_1: void): [string, IDisposable] {
    let _v0: Option<string> = undefined;
    const x: string = defaultOf();
    _v0 = x;
    const v534: string = value_3(_v0);
    let _v535: Option<IDisposable> = undefined;
    const x_1: IDisposable = defaultOf();
    _v535 = x_1;
    return [v534, value_3(_v535)] as [string, IDisposable];
}

export function closure50(unitVar: void, unitVar_1: void): string {
    return "C:\\home\\git\\polyglot\\lib\\spiral";
}

export function closure54(unitVar: void, v0_1: string): boolean {
    let _v1: Option<boolean> = undefined;
    const v20: IFsExistsSync = fs;
    const x: boolean = v20.existsSync(v0_1);
    _v1 = x;
    return value_3(_v1);
}

export function closure55(unitVar: void, v0_1: string): boolean {
    let _v1: Option<boolean> = undefined;
    const v20: IFsExistsSync = fs;
    const x: boolean = v20.existsSync(v0_1);
    _v1 = x;
    return value_3(_v1);
}

export function closure56(unitVar: void, v0_1: string): Option<string> {
    let _v1: Option<US9_$union> = undefined;
    const v50: IPathDirname = path;
    const x: US9_$union = US9_US9_0(v50.dirname(v0_1));
    _v1 = x;
    const v55: US9_$union = value_3(_v1);
    if (v55.tag === /* US9_0 */ 0) {
        return v55.fields[0];
    }
    else {
        return undefined;
    }
}

export function method26(): ((arg0: string) => Option<string>) {
    return (v: string): Option<string> => closure56(undefined, v);
}

export function closure57(unitVar: void, v0_1: string): US9_$union {
    return US9_US9_0(v0_1);
}

export function method27(): ((arg0: string) => US9_$union) {
    return (v: string): US9_$union => closure57(undefined, v);
}

export function method28(v0_1_mut: string, v1_1_mut: boolean, v2_1_mut: string, v3_1_mut: string): string {
    method28:
    while (true) {
        const v0_1: string = v0_1_mut, v1_1: boolean = v1_1_mut, v2_1: string = v2_1_mut, v3_1: string = v3_1_mut;
        let _v4: Option<string> = undefined;
        const v40: IPathJoin = path;
        const v41: string = method14(v3_1);
        const v42: string = method15(v0_1);
        const x: string = v40.join(v41, v42);
        _v4 = x;
        if ((v1_1 ? ((v: string): boolean => closure54(undefined, v)) : ((v_1: string): boolean => closure55(undefined, v_1)))(value_3(_v4))) {
            return v3_1;
        }
        else {
            const v52: Option<string> = method26()(v3_1);
            const v55: US9_$union = defaultArg(map<string, US9_$union>(method27(), v52), US9_US9_1());
            if (v55.tag === /* US9_0 */ 0) {
                v0_1_mut = v0_1;
                v1_1_mut = v1_1;
                v2_1_mut = v2_1;
                v3_1_mut = v55.fields[0];
                continue method28;
            }
            else {
                throw new Error(`No parent for ${v1_1 ? "file" : "dir"} '${v0_1}' at '${v2_1}' (until '${v3_1}')`);
            }
        }
        break;
    }
}

export function method25(v0_1: string, v1_1: boolean, v2_1: string): string {
    let _v3: Option<string> = undefined;
    const v39: IPathJoin = path;
    const v40: string = method14(v2_1);
    const v41: string = method15(v0_1);
    const x: string = v39.join(v40, v41);
    _v3 = x;
    if ((v1_1 ? ((v: string): boolean => closure54(undefined, v)) : ((v_1: string): boolean => closure55(undefined, v_1)))(value_3(_v3))) {
        return v2_1;
    }
    else {
        const v51: Option<string> = method26()(v2_1);
        const v54: US9_$union = defaultArg(map<string, US9_$union>(method27(), v51), US9_US9_1());
        if (v54.tag === /* US9_0 */ 0) {
            return method28(v0_1, v1_1, v2_1, v54.fields[0]);
        }
        else {
            throw new Error(`No parent for ${v1_1 ? "file" : "dir"} '${v0_1}' at '${v2_1}' (until '${v2_1}')`);
        }
    }
}

export function closure53(v0_1: string, v1_1: boolean, v2_1: string): string {
    return method25(v0_1, v1_1, v2_1);
}

export function closure52(v0_1: string, v1_1: boolean): ((arg0: string) => string) {
    return (v: string): string => closure53(v0_1, v1_1, v);
}

export function closure51(unitVar: void, v0_1: string): ((arg0: boolean) => ((arg0: string) => string)) {
    return (v: boolean): ((arg0: string) => string) => closure52(v0_1, v);
}

export function method29(): string {
    return "^\\\\\\\\\\?\\\\";
}

export function method30(v0_1: string): string {
    return v0_1;
}

export function method31(): string {
    return "";
}

export function closure58(unitVar: void, v0_1: string): string {
    let _arg: string;
    let _v1: Option<boolean> = undefined;
    const x: boolean = defaultOf();
    _v1 = x;
    if (value_3(_v1) === false) {
        return v0_1;
    }
    else {
        let _v14: Option<string> = undefined;
        const x_1: string = defaultOf();
        _v14 = x_1;
        const v32: string = value_3(_v14);
        return replace(`${(_arg = v32[0], _arg.toLocaleLowerCase())}${v32.slice(1, v32.length)}`, "\\", "/");
    }
}

export function closure59(unitVar: void, v0_1: string): string {
    return `file:///${trimStart(v0_1, "/")}`;
}

export function method32(): string {
    return "polyglot";
}

export function method33(): string {
    return ".paket";
}

export function method34(): string {
    return "polyglot";
}

export function method35(): string {
    return ".paket";
}

export function method37(v0_1_mut: string, v1_1_mut: string, v2_1_mut: string): string {
    method37:
    while (true) {
        const v0_1: string = v0_1_mut, v1_1: string = v1_1_mut, v2_1: string = v2_1_mut;
        let _v3: Option<string> = undefined;
        const v39: IPathJoin = path;
        const v40: string = method14(v2_1);
        const v41: string = method15(v0_1);
        const x: string = v39.join(v40, v41);
        _v3 = x;
        const v45: string = value_3(_v3);
        let _v46: Option<boolean> = undefined;
        const v65: IFsExistsSync = fs;
        const x_1: boolean = v65.existsSync(v45);
        _v46 = x_1;
        if (value_3(_v46)) {
            return v2_1;
        }
        else {
            const v71: Option<string> = method26()(v2_1);
            const v74: US9_$union = defaultArg(map<string, US9_$union>(method27(), v71), US9_US9_1());
            if (v74.tag === /* US9_0 */ 0) {
                v0_1_mut = v0_1;
                v1_1_mut = v1_1;
                v2_1_mut = v74.fields[0];
                continue method37;
            }
            else {
                throw new Error(`No parent for ${"dir"} '${v0_1}' at '${v1_1}' (until '${v2_1}')`);
            }
        }
        break;
    }
}

export function method36(v0_1: string, v1_1: string): string {
    let _v2: Option<string> = undefined;
    const v38: IPathJoin = path;
    const v39: string = method14(v1_1);
    const v40: string = method15(v0_1);
    const x: string = v38.join(v39, v40);
    _v2 = x;
    const v44: string = value_3(_v2);
    let _v45: Option<boolean> = undefined;
    const v64: IFsExistsSync = fs;
    const x_1: boolean = v64.existsSync(v44);
    _v45 = x_1;
    if (value_3(_v45)) {
        return v1_1;
    }
    else {
        const v70: Option<string> = method26()(v1_1);
        const v73: US9_$union = defaultArg(map<string, US9_$union>(method27(), v70), US9_US9_1());
        if (v73.tag === /* US9_0 */ 0) {
            return method37(v0_1, v1_1, v73.fields[0]);
        }
        else {
            throw new Error(`No parent for ${"dir"} '${v0_1}' at '${v1_1}' (until '${v1_1}')`);
        }
    }
}

export function method38(): string {
    return "polyglot";
}

export function closure60(unitVar: void, unitVar_1: void): string {
    let _v1: Option<string> = undefined;
    const v39: IPathJoin = path;
    const v40: string = method34();
    const v41: string = method35();
    const x: string = v39.join(v40, v41);
    _v1 = x;
    let _v47: Option<string> = undefined;
    const v82: IPathJoin = path;
    const v83: string = method14(method36(value_3(_v1), "C:\\home\\git\\polyglot\\lib\\spiral"));
    const v84: string = method38();
    const x_1: string = v82.join(v83, v84);
    _v47 = x_1;
    return value_3(_v47);
}

export function method40(): string {
    return "target/polyglot/trace";
}

export function method41(): string {
    return "target/polyglot/trace";
}

export function method39(v0_1: string): void {
    let _v1: Option<void> = undefined;
    _v1 = some(undefined);
    value_3(_v1);
}

export function closure62(unitVar: void, v0_1: string): void {
    method39(v0_1);
}

export function closure61(unitVar: void, v0_1: boolean): void {
    if (State_trace_state() == null) {
        State_trace_state(closure0(undefined, undefined));
    }
    const patternInput: [Mut0, Mut1, Mut2, Option<int64>, Mut3] = value_3(State_trace_state());
    const v9_1: ((arg0: string) => void) = v0_1 ? ((v: string): void => {
        closure62(undefined, v);
    }) : ((v_1: string): void => {
        closure1(undefined, v_1);
    });
    patternInput[4].l0 = v9_1;
}

export function closure64(v0_1: string, v1_1: string): string {
    let _v2: Option<string> = undefined;
    const v38: IPathJoin = path;
    const v39: string = method14(v0_1);
    const v40: string = method15(v1_1);
    const x: string = v38.join(v39, v40);
    _v2 = x;
    return value_3(_v2);
}

export function closure63(unitVar: void, v0_1: string): ((arg0: string) => string) {
    return (v: string): string => closure64(v0_1, v);
}

export const v0 = (): [Mut0, Mut1, Mut2, Option<int64>, Mut3] => closure0(undefined, undefined);

if (State_trace_state() == null) {
    State_trace_state(v0());
}

export const v1 = (v: string): any => closure2(undefined, v);

export function delete_directory_async(x: string): any {
    return v1(x);
}

export const v2 = (v: US3_$union): ((arg0: string) => any) => closure9(undefined, v);

export function wait_for_file_access(x: US3_$union): ((arg0: string) => any) {
    return v2(x);
}

export const v3 = (v: string): any => closure13(undefined, v);

export function wait_for_file_access_read(x: string): any {
    return v3(x);
}

export const v4 = (v: string): any => closure14(undefined, v);

export function read_all_text_async(x: string): any {
    return v4(x);
}

export const v5 = (v: string): ((arg0: string) => any) => closure15(undefined, v);

export function file_exists_content(x: string): ((arg0: string) => any) {
    return v5(x);
}

export const v6 = (v: string): ((arg0: string) => any) => closure17(undefined, v);

export function write_all_text_async(x: string): ((arg0: string) => any) {
    return v6(x);
}

export const v7 = (v: string): ((arg0: string) => any) => closure19(undefined, v);

export function write_all_text_exists(x: string): ((arg0: string) => any) {
    return v7(x);
}

export const v8 = (v: string): any => closure21(undefined, v);

export function delete_file_async(x: string): any {
    return v8(x);
}

export const v9 = (v: string): ((arg0: string) => any) => closure24(undefined, v);

export function move_file_async(x: string): ((arg0: string) => any) {
    return v9(x);
}

export const v10 = (v: string): any => closure28(undefined, v);

export function read_all_text_retry_async(x: string): any {
    return v10(x);
}

export const v11 = (): string => closure36(undefined, undefined);

export function create_temp_directory_name(): string {
    return v11();
}

export const v12 = (): [string, IDisposable] => closure38(undefined, undefined);

export function create_temp_directory(): [string, IDisposable] {
    return v12();
}

export const v13 = (): string => closure50(undefined, undefined);

export function get_source_directory(): string {
    return v13();
}

export const v14 = (v: string): ((arg0: boolean) => ((arg0: string) => string)) => closure51(undefined, v);

export function find_parent(x: string): ((arg0: boolean) => ((arg0: string) => string)) {
    return v14(x);
}

export const v15 = (v: string): string => closure58(undefined, v);

export function normalize_path(x: string): string {
    return v15(x);
}

export const v16 = (v: string): string => closure59(undefined, v);

export function new_file_uri(x: string): string {
    return v16(x);
}

export const v17 = (): string => closure60(undefined, undefined);

export function get_workspace_root(): string {
    return v17();
}

export const v18 = (v: boolean): void => {
    closure61(undefined, v);
};

export function init_trace_file(x: boolean): void {
    v18(x);
}

export const v19 = (v: string): ((arg0: string) => string) => closure63(undefined, v);

export function op_LessDivideGreater(x: string): ((arg0: string) => string) {
    return v19(x);
}
