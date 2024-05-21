import { compare, defaultOf, IComparable, IEquatable, IDisposable, createAtom } from "../../deps/Fable/src/fable-library-ts/Util.js";
import { defaultArg, value as value_3, some, Option } from "../../deps/Fable/src/fable-library-ts/Option.js";
import { op_Addition, toInt64, int64 } from "../../deps/Fable/src/fable-library-ts/BigInt.js";
import { lambda_type, unit_type, string_type, bool_type, record_type, int64_type, union_type, class_type, TypeInfo } from "../../deps/Fable/src/fable-library-ts/Reflection.js";
import { FSharpRef, Record, Union } from "../../deps/Fable/src/fable-library-ts/Types.js";
import { replace, interpolate, toText, trimStart, trimEnd, padLeft } from "../../deps/Fable/src/fable-library-ts/String.js";
import { ofSeq, find } from "../../deps/Fable/src/fable-library-ts/Map.js";
import { int32 } from "../../deps/Fable/src/fable-library-ts/Int32.js";
import * as path from "path";
import * as fs from "fs";

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
    0: ["US4_0", []],
    1: ["US4_1", []],
    2: ["US4_2", []],
    3: ["US4_3", []],
    4: ["US4_4", []]
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

export function US4_US4_3() {
    return new US4<3>(3, []);
}

export function US4_US4_4() {
    return new US4<4>(4, []);
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
    return union_type("File_system.US4", [], US4, () => [[], [], [], [], []]);
}

export type US2_$union = 
    | US2<0>
    | US2<1>

export type US2_$cases = {
    0: ["US2_0", [US3_$union, US4_$union]],
    1: ["US2_1", []]
}

export function US2_US2_0(f0_0: US3_$union, f0_1: US4_$union) {
    return new US2<0>(0, [f0_0, f0_1]);
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
    return union_type("File_system.US2", [], US2, () => [[["f0_0", US3_$reflection()], ["f0_1", US4_$reflection()]], []]);
}

export type US5_$union = 
    | US5<0>
    | US5<1>

export type US5_$cases = {
    0: ["US5_0", [int64]],
    1: ["US5_1", [Error]]
}

export function US5_US5_0(f0_0: int64) {
    return new US5<0>(0, [f0_0]);
}

export function US5_US5_1(f1_0: Error) {
    return new US5<1>(1, [f1_0]);
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
    return union_type("File_system.US5", [], US5, () => [[["f0_0", int64_type]], [["f1_0", class_type("System.Exception")]]]);
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
    0: ["US7_0", [any]],
    1: ["US7_1", []]
}

export function US7_US7_0(f0_0: any) {
    return new US7<0>(0, [f0_0]);
}

export function US7_US7_1() {
    return new US7<1>(1, []);
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
    return union_type("File_system.US7", [], US7, () => [[["f0_0", string_type]], []]);
}

export type US8_$union = 
    | US8<0>
    | US8<1>

export type US8_$cases = {
    0: ["US8_0", [string]],
    1: ["US8_1", []]
}

export function US8_US8_0(f0_0: string) {
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
    0: ["US9_0", []],
    1: ["US9_1", [any]]
}

export function US9_US9_0() {
    return new US9<0>(0, []);
}

export function US9_US9_1(f1_0: any) {
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
    return union_type("File_system.US9", [], US9, () => [[], [["f1_0", string_type]]]);
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

export function US3__get_IsUS3_2(this$: FSharpRef<US3_$union>, unitArg: void): boolean {
    if ((this$ as any)['tag'] === 2) {
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

export function US4__get_IsUS4_3(this$: FSharpRef<US4_$union>, unitArg: void): boolean {
    if ((this$ as any)['tag'] === 3) {
        return true;
    }
    else {
        return false;
    }
}

export function US4__get_IsUS4_4(this$: FSharpRef<US4_$union>, unitArg: void): boolean {
    if ((this$ as any)['tag'] === 4) {
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

export function closure1(unitVar: void, v0_1: string): void {
}

export function method0(): string {
    return "";
}

export function method1(): string {
    return "AUTOMATION";
}

export function closure0(unitVar: void, v0_1: US0_$union): [Mut0, Mut1, Mut2, Option<int64>, Mut3] {
    const v1_1: Mut1 = new Mut1(true);
    const v2_1: Mut0 = new Mut0(0n);
    const v3_1: Mut2 = new Mut2(v0_1);
    const v5_1: Mut3 = new Mut3((v: string): void => {
        closure1(undefined, v);
    });
    let _v6: Option<Option<int64>> = undefined;
    _v6 = some(undefined);
    return [v2_1, v1_1, v3_1, (_v6 == null) ? (() => {
        throw new Error("base.run_target / _v6=None");
    })() : value_3(_v6), v5_1] as [Mut0, Mut1, Mut2, Option<int64>, Mut3];
}

export function method3(v0_1: string): string {
    return v0_1;
}

export function closure3(unitVar: void, unitVar_1: void): string {
    return "file_system.delete_directory_async";
}

export function closure5(unitVar: void, v0_1: string): string {
    let _v1: Option<string> = undefined;
    const x: string = defaultOf();
    _v1 = x;
    if (_v1 == null) {
        throw new Error("base.run_target / _v1=None");
    }
    else {
        return value_3(_v1);
    }
}

export function closure6(unitVar: void, unitVar_1: void): string {
    return "";
}

export function closure4(v0_1: string, v1_1: string, unitVar: void): string {
    return `path: ${closure5(undefined, v0_1)} / ex: ${v1_1} / ${closure6(undefined, undefined)}`;
}

export function method5(): string {
    return "";
}

export function closure7(v0_1: US0_$union, v1_1: (() => string), v2_1: (() => string), unitVar: void): string {
    if (State_trace_state() == null) {
        State_trace_state(closure0(undefined, US0_US0_0()));
    }
    const patternInput: [Mut0, Mut1, Mut2, Option<int64>, Mut3] = value_3(State_trace_state());
    let _v10: Option<string> = undefined;
    const x: string = method5();
    _v10 = x;
    let v67: string;
    if (_v10 == null) {
        throw new Error("base.run_target / _v10=None");
    }
    else {
        v67 = value_3(_v10);
    }
    const v68: int64 = patternInput[0].l0;
    const v78: string = (v0_1.tag === /* US0_1 */ 1) ? "Debug" : ((v0_1.tag === /* US0_2 */ 2) ? "Info" : ((v0_1.tag === /* US0_0 */ 0) ? "Verbose" : ((v0_1.tag === /* US0_3 */ 3) ? "Warning" : "Critical")));
    let _v82: Option<string> = undefined;
    const x_2: string = padLeft(v78.toLocaleLowerCase(), 7, " ");
    _v82 = x_2;
    return trimEnd(trimStart(`${v67} ${(_v82 == null) ? (() => {
        throw new Error("base.run_target / _v82=None");
    })() : value_3(_v82)} #${v68} ${v1_1()} / ${v2_1()}`), " ", "/");
}

export function method6(v0_1: US0_$union, v1_1: (() => string)): void {
    const v2_1 = (v: US0_$union): [Mut0, Mut1, Mut2, Option<int64>, Mut3] => closure0(undefined, v);
    if (State_trace_state() == null) {
        State_trace_state(v2_1(US0_US0_0()));
    }
    const patternInput: [Mut0, Mut1, Mut2, Option<int64>, Mut3] = value_3(State_trace_state());
    const v4_1: Mut0 = patternInput[0];
    if (State_trace_state() == null) {
        State_trace_state(v2_1(US0_US0_0()));
    }
    const patternInput_1: [Mut0, Mut1, Mut2, Option<int64>, Mut3] = value_3(State_trace_state());
    const v15_1: US0_$union = patternInput_1[2].l0;
    if ((patternInput_1[1].l0 === false) ? false : (find<US0_$union, int32>(v0_1, ofSeq([[US0_US0_0(), 0] as [US0_$union, int32], [US0_US0_1(), 1] as [US0_$union, int32], [US0_US0_2(), 2] as [US0_$union, int32], [US0_US0_3(), 3] as [US0_$union, int32], [US0_US0_4(), 4] as [US0_$union, int32]], {
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
        patternInput[4].l0(v24);
    }
}

export function method4(v0_1: US0_$union, v1_1: (() => string), v2_1: (() => string)): void {
    method6(v0_1, (): string => closure7(v0_1, v1_1, v2_1, undefined));
}

export function method2(v0_1: string, v1_1: int64): any {
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

export function closure10(unitVar: void, unitVar_1: void): string {
    return "file_system.wait_for_file_access";
}

export function closure11(v0_1: string, v1_1: int64, v2_1: string, unitVar: void): string {
    return `path: ${closure5(undefined, v0_1)} / retry: ${v1_1} / ex: ${v2_1} / ${closure6(undefined, undefined)}`;
}

export function method7(v0_1: string, v1_1: US4_$union, v2_1: US3_$union, v3_1: int64): any {
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

export function closure9(v0_1: US2_$union, v1_1: string): any {
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

export function closure8(unitVar: void, v0_1: US2_$union): ((arg0: string) => any) {
    return (v: string): any => closure9(v0_1, v);
}

export function method8(v0_1: string, v1_1: int64): any {
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

export function closure13(unitVar: void, v0_1: string): any {
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

export function closure15(v0_1: string, v1_1: string): any {
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

export function closure14(unitVar: void, v0_1: string): ((arg0: string) => any) {
    return (v: string): any => closure15(v0_1, v);
}

export function closure17(v0_1: string, v1_1: string): any {
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

export function closure16(unitVar: void, v0_1: string): ((arg0: string) => any) {
    return (v: string): any => closure17(v0_1, v);
}

export function closure19(v0_1: string, v1_1: string): any {
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

export function closure18(unitVar: void, v0_1: string): ((arg0: string) => any) {
    return (v: string): any => closure19(v0_1, v);
}

export function closure21(unitVar: void, unitVar_1: void): string {
    return "delete_file_async";
}

export function closure22(v0_1: string, v1_1: Error, unitVar: void): string {
    let _v2: Option<string> = undefined;
    const x: string = toText(interpolate("%A%P()", [v1_1]));
    _v2 = x;
    let v9_1: string;
    if (_v2 == null) {
        throw new Error("base.run_target / _v2=None");
    }
    else {
        v9_1 = value_3(_v2);
    }
    return `path: ${closure5(undefined, v0_1)} / ex: ${v9_1} / ${closure6(undefined, undefined)}`;
}

export function method9(v0_1: string, v1_1: int64): any {
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

export function closure20(unitVar: void, v0_1: string): any {
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

export function closure26(v0_1: string, v1_1: string, v2_1: Error, unitVar: void): string {
    let _v3: Option<string> = undefined;
    const x: string = toText(interpolate("%A%P()", [v2_1]));
    _v3 = x;
    let v10_1: string;
    if (_v3 == null) {
        throw new Error("base.run_target / _v3=None");
    }
    else {
        v10_1 = value_3(_v3);
    }
    const v11_1 = (v: string): string => closure5(undefined, v);
    return `old_path: ${v11_1(v1_1)} / new_path: ${v11_1(v0_1)} / ex: ${v10_1} / ${closure6(undefined, undefined)}`;
}

export function method10(v0_1: string, v1_1: string, v2_1: int64): any {
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

export function closure28(unitVar: void, v0_1: int64): US5_$union {
    return US5_US5_0(v0_1);
}

export function closure29(unitVar: void, v0_1: Error): US5_$union {
    return US5_US5_1(v0_1);
}

export function closure30(unitVar: void, unitVar_1: void): string {
    return "run_with_timeout_async";
}

export function closure31(unitVar: void, unitVar_1: void): string {
    return `timeout: ${1000} / ${closure6(undefined, undefined)}`;
}

export function closure32(v0_1: string, unitVar: void): string {
    return `run_with_timeout_async** / ex: ${v0_1}`;
}

export function closure33(unitVar: void, unitVar_1: void): string {
    return "read_all_text_retry_async";
}

export function method12(v0_1: int64, v1_1: string): string {
    return `retry: ${v0_1} / ex: ${v1_1} / ${closure6(undefined, undefined)}`;
}

export function closure34(v0_1: int64, v1_1: string, unitVar: void): string {
    return method12(v0_1, v1_1);
}

export function method11(v0_1: string, v1_1: int64): any {
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

export function closure27(unitVar: void, v0_1: string): any {
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

export function method13(): string {
    return "CARGO_PKG_NAME";
}

export function method15(v0_1: string): string {
    return v0_1;
}

export function method16(v0_1: string): string {
    return v0_1;
}

export function method14(v0_1: string, v1_1: string): string {
    let _v2: Option<string> = undefined;
    const v33: IPathJoin = path;
    const v34: string = method15(v0_1);
    const v35: string = method16(v1_1);
    const x: string = v33.join(v34, v35);
    _v2 = x;
    if (_v2 == null) {
        throw new Error("base.run_target / _v2=None");
    }
    else {
        return value_3(_v2);
    }
}

export function method18(v0_1: any): any {
    return v0_1;
}

export function method19(v0_1: any): any {
    return v0_1;
}

export function method20(): string {
    return "yyyyMMdd-HHmm-ssff-ffff-f";
}

export function method21(): string {
    return "hhmm";
}

export function method17(v0_1: string, v1_1: Date): string {
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

export function closure35(unitVar: void, unitVar_1: void): string {
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

export function method22(v0_1: string): string {
    return v0_1;
}

export function closure37(unitVar: void, v0_1: any): any {
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

export function method23(): ((arg0: any) => any) {
    return (v: any): any => closure37(undefined, v);
}

export function closure38(unitVar: void, unitVar_1: void): US9_$union {
    return US9_US9_0();
}

export function closure39(unitVar: void, v0_1: any): US9_$union {
    return US9_US9_1(v0_1);
}

export function closure40(unitVar: void, unitVar_1: void): string {
    return "file_system.create_directory";
}

export function closure41(v0_1: string, v1_1: any, unitVar: void): string {
    return `dir: ${v0_1} / error: ${v1_1} / ${closure6(undefined, undefined)}`;
}

export function closure42(unitVar: void, unitVar_1: void): string {
    return "file_system.create_directory";
}

export function closure43(v0_1: string, unitVar: void): string {
    return `dir: ${v0_1} / ${closure6(undefined, undefined)}`;
}

export function closure44(v0_1: string, unitVar: void): void {
    let _v1: Option<void> = undefined;
    defaultOf();
    _v1 = some(undefined);
    if (_v1 == null) {
        throw new Error("base.run_target / _v1=None");
    }
    else {
        value_3(_v1);
    }
}

export function method24(v0_1: string): (() => void) {
    return (): void => {
        closure44(v0_1, undefined);
    };
}

export function closure45(unitVar: void, unitVar_1: void): string {
    return "file_system.create_directory";
}

export function closure46(v0_1: string, v1_1: string, unitVar: void): string {
    return `dir: ${v0_1} / result: ${v1_1} ${closure6(undefined, undefined)}`;
}

export function closure47(v0_1: string, unitVar: void): void {
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

export function method25(v0_1: string): (() => void) {
    return (): void => {
        closure47(v0_1, undefined);
    };
}

export function closure36(unitVar: void, unitVar_1: void): [string, IDisposable] {
    let _v0: Option<string> = undefined;
    const x: string = defaultOf();
    _v0 = x;
    let v136: string;
    if (_v0 == null) {
        throw new Error("base.run_target / _v0=None");
    }
    else {
        v136 = value_3(_v0);
    }
    let _v137: Option<IDisposable> = undefined;
    const x_2: IDisposable = defaultOf();
    _v137 = x_2;
    return [v136, (_v137 == null) ? (() => {
        throw new Error("base.run_target / _v137=None");
    })() : value_3(_v137)] as [string, IDisposable];
}

export function closure48(unitVar: void, unitVar_1: void): string {
    return "C:\\home\\git\\polyglot\\lib\\spiral";
}

export function closure52(unitVar: void, v0_1: string): boolean {
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

export function closure53(unitVar: void, v0_1: string): boolean {
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

export function closure54(unitVar: void, v0_1: string): Option<string> {
    let _v1: Option<US8_$union> = undefined;
    const v31: IPathDirname = path;
    const x: US8_$union = US8_US8_0(v31.dirname(v0_1));
    _v1 = x;
    let v51: US8_$union;
    if (_v1 == null) {
        throw new Error("base.run_target / _v1=None");
    }
    else {
        v51 = value_3(_v1);
    }
    if (v51.tag === /* US8_0 */ 0) {
        return v51.fields[0];
    }
    else {
        return undefined;
    }
}

export function method27(): ((arg0: string) => Option<string>) {
    return (v: string): Option<string> => closure54(undefined, v);
}

export function method28(v0_1_mut: string, v1_1_mut: boolean, v2_1_mut: string, v3_1_mut: string): string {
    method28:
    while (true) {
        const v0_1: string = v0_1_mut, v1_1: boolean = v1_1_mut, v2_1: string = v2_1_mut, v3_1: string = v3_1_mut;
        if ((v1_1 ? ((v: string): boolean => closure52(undefined, v)) : ((v_1: string): boolean => closure53(undefined, v_1)))(method14(v3_1, v0_1))) {
            return v3_1;
        }
        else {
            const v10_1: Option<string> = method27()(v3_1);
            const _v11: FSharpRef<Option<US8_$union>> = new FSharpRef<Option<US8_$union>>(undefined);
            let x_2: Option<US8_$union>;
            if (v10_1 == null) {
                x_2 = undefined;
            }
            else {
                const x: string = value_3(v10_1);
                x_2 = ((): US8_$union => US8_US8_0(x))();
            }
            _v11.contents = x_2;
            const v16_1: US8_$union = defaultArg(_v11.contents, US8_US8_1());
            if (v16_1.tag === /* US8_0 */ 0) {
                v0_1_mut = v0_1;
                v1_1_mut = v1_1;
                v2_1_mut = v2_1;
                v3_1_mut = v16_1.fields[0];
                continue method28;
            }
            else {
                throw new Error(`No parent for ${v1_1 ? "file" : "dir"} '${v0_1}' at '${v2_1}' (until '${v3_1}')`);
            }
        }
        break;
    }
}

export function method26(v0_1: string, v1_1: boolean, v2_1: string): string {
    if ((v1_1 ? ((v: string): boolean => closure52(undefined, v)) : ((v_1: string): boolean => closure53(undefined, v_1)))(method14(v2_1, v0_1))) {
        return v2_1;
    }
    else {
        const v9_1: Option<string> = method27()(v2_1);
        const _v10: FSharpRef<Option<US8_$union>> = new FSharpRef<Option<US8_$union>>(undefined);
        let x_2: Option<US8_$union>;
        if (v9_1 == null) {
            x_2 = undefined;
        }
        else {
            const x: string = value_3(v9_1);
            x_2 = ((): US8_$union => US8_US8_0(x))();
        }
        _v10.contents = x_2;
        const v15_1: US8_$union = defaultArg(_v10.contents, US8_US8_1());
        if (v15_1.tag === /* US8_0 */ 0) {
            return method28(v0_1, v1_1, v2_1, v15_1.fields[0]);
        }
        else {
            throw new Error(`No parent for ${v1_1 ? "file" : "dir"} '${v0_1}' at '${v2_1}' (until '${v2_1}')`);
        }
    }
}

export function closure51(v0_1: string, v1_1: boolean, v2_1: string): string {
    return method26(v0_1, v1_1, v2_1);
}

export function closure50(v0_1: string, v1_1: boolean): ((arg0: string) => string) {
    return (v: string): string => closure51(v0_1, v1_1, v);
}

export function closure49(unitVar: void, v0_1: string): ((arg0: boolean) => ((arg0: string) => string)) {
    return (v: boolean): ((arg0: string) => string) => closure50(v0_1, v);
}

export function method29(v0_1: string): string {
    return v0_1;
}

export function method30(): string {
    return "";
}

export function method31(): string {
    return "^\\\\\\\\\\?\\\\";
}

export function method32(): string {
    return "";
}

export function closure55(unitVar: void, v0_1: string): string {
    let _arg: string;
    let _v1: Option<string> = undefined;
    const x: string = defaultOf();
    _v1 = x;
    let v29: string;
    if (_v1 == null) {
        throw new Error("base.run_target / _v1=None");
    }
    else {
        v29 = value_3(_v1);
    }
    return replace(`${(_arg = v29[0], _arg.toLocaleLowerCase())}${v29.slice(1, v29.length)}`, "\\", "/");
}

export function closure56(unitVar: void, v0_1: string): string {
    return `file:///${trimStart(v0_1, "/")}`;
}

export function method34(v0_1_mut: string, v1_1_mut: string, v2_1_mut: string): string {
    method34:
    while (true) {
        const v0_1: string = v0_1_mut, v1_1: string = v1_1_mut, v2_1: string = v2_1_mut;
        const v3_1: string = method14(v2_1, v0_1);
        let _v4: Option<boolean> = undefined;
        const v19_1: IFsExistsSync = fs;
        const x: boolean = v19_1.existsSync(v3_1);
        _v4 = x;
        if ((_v4 == null) ? (() => {
            throw new Error("base.run_target / _v4=None");
        })() : value_3(_v4)) {
            return v2_1;
        }
        else {
            const v27: Option<string> = method27()(v2_1);
            const _v28: FSharpRef<Option<US8_$union>> = new FSharpRef<Option<US8_$union>>(undefined);
            let x_4: Option<US8_$union>;
            if (v27 == null) {
                x_4 = undefined;
            }
            else {
                const x_2: string = value_3(v27);
                x_4 = ((): US8_$union => US8_US8_0(x_2))();
            }
            _v28.contents = x_4;
            const v33: US8_$union = defaultArg(_v28.contents, US8_US8_1());
            if (v33.tag === /* US8_0 */ 0) {
                v0_1_mut = v0_1;
                v1_1_mut = v1_1;
                v2_1_mut = v33.fields[0];
                continue method34;
            }
            else {
                throw new Error(`No parent for ${"dir"} '${v0_1}' at '${v1_1}' (until '${v2_1}')`);
            }
        }
        break;
    }
}

export function method33(v0_1: string, v1_1: string): string {
    const v2_1: string = method14(v1_1, v0_1);
    let _v3: Option<boolean> = undefined;
    const v18_1: IFsExistsSync = fs;
    const x: boolean = v18_1.existsSync(v2_1);
    _v3 = x;
    if ((_v3 == null) ? (() => {
        throw new Error("base.run_target / _v3=None");
    })() : value_3(_v3)) {
        return v1_1;
    }
    else {
        const v26: Option<string> = method27()(v1_1);
        const _v27: FSharpRef<Option<US8_$union>> = new FSharpRef<Option<US8_$union>>(undefined);
        let x_4: Option<US8_$union>;
        if (v26 == null) {
            x_4 = undefined;
        }
        else {
            const x_2: string = value_3(v26);
            x_4 = ((): US8_$union => US8_US8_0(x_2))();
        }
        _v27.contents = x_4;
        const v32: US8_$union = defaultArg(_v27.contents, US8_US8_1());
        if (v32.tag === /* US8_0 */ 0) {
            return method34(v0_1, v1_1, v32.fields[0]);
        }
        else {
            throw new Error(`No parent for ${"dir"} '${v0_1}' at '${v1_1}' (until '${v1_1}')`);
        }
    }
}

export function closure57(unitVar: void, unitVar_1: void): string {
    return method14(method33(method14("polyglot", ".paket"), "C:\\home\\git\\polyglot\\lib\\spiral"), "polyglot");
}

export function method35(v0_1: string): void {
    let _v1: Option<void> = undefined;
    _v1 = some(undefined);
    if (_v1 == null) {
        throw new Error("base.run_target / _v1=None");
    }
    else {
        value_3(_v1);
    }
}

export function closure59(unitVar: void, v0_1: string): void {
    method35(v0_1);
}

export function closure58(unitVar: void, v0_1: boolean): void {
    if (State_trace_state() == null) {
        State_trace_state(closure0(undefined, US0_US0_0()));
    }
    const patternInput: [Mut0, Mut1, Mut2, Option<int64>, Mut3] = value_3(State_trace_state());
    const v10_1: ((arg0: string) => void) = v0_1 ? ((v_1: string): void => {
        closure59(undefined, v_1);
    }) : ((v_2: string): void => {
        closure1(undefined, v_2);
    });
    patternInput[4].l0 = v10_1;
}

export function closure61(v0_1: string, v1_1: string): string {
    return method14(v0_1, v1_1);
}

export function closure60(unitVar: void, v0_1: string): ((arg0: string) => string) {
    return (v: string): string => closure61(v0_1, v);
}

export const v0 = (v: US0_$union): [Mut0, Mut1, Mut2, Option<int64>, Mut3] => closure0(undefined, v);

export const v1: US0_$union = US0_US0_0();

if (State_trace_state() == null) {
    State_trace_state(v0(v1));
}

export const v2 = (v: string): any => closure2(undefined, v);

export function delete_directory_async(x: string): any {
    return v2(x);
}

export const v3 = (v: US2_$union): ((arg0: string) => any) => closure8(undefined, v);

export function wait_for_file_access(x: US2_$union): ((arg0: string) => any) {
    return v3(x);
}

export const v4 = (v: string): any => closure12(undefined, v);

export function wait_for_file_access_read(x: string): any {
    return v4(x);
}

export const v5 = (v: string): any => closure13(undefined, v);

export function read_all_text_async(x: string): any {
    return v5(x);
}

export const v6 = (v: string): ((arg0: string) => any) => closure14(undefined, v);

export function file_exists_content(x: string): ((arg0: string) => any) {
    return v6(x);
}

export const v7 = (v: string): ((arg0: string) => any) => closure16(undefined, v);

export function write_all_text_async(x: string): ((arg0: string) => any) {
    return v7(x);
}

export const v8 = (v: string): ((arg0: string) => any) => closure18(undefined, v);

export function write_all_text_exists(x: string): ((arg0: string) => any) {
    return v8(x);
}

export const v9 = (v: string): any => closure20(undefined, v);

export function delete_file_async(x: string): any {
    return v9(x);
}

export const v10 = (v: string): ((arg0: string) => any) => closure23(undefined, v);

export function move_file_async(x: string): ((arg0: string) => any) {
    return v10(x);
}

export const v11 = (v: string): any => closure27(undefined, v);

export function read_all_text_retry_async(x: string): any {
    return v11(x);
}

export const v12 = (): string => closure35(undefined, undefined);

export function create_temp_directory_name(): string {
    return v12();
}

export const v13 = (): [string, IDisposable] => closure36(undefined, undefined);

export function create_temp_directory(): [string, IDisposable] {
    return v13();
}

export const v14 = (): string => closure48(undefined, undefined);

export function get_source_directory(): string {
    return v14();
}

export const v15 = (v: string): ((arg0: boolean) => ((arg0: string) => string)) => closure49(undefined, v);

export function find_parent(x: string): ((arg0: boolean) => ((arg0: string) => string)) {
    return v15(x);
}

export const v16 = (v: string): string => closure55(undefined, v);

export function normalize_path(x: string): string {
    return v16(x);
}

export const v17 = (v: string): string => closure56(undefined, v);

export function new_file_uri(x: string): string {
    return v17(x);
}

export const v18 = (): string => closure57(undefined, undefined);

export function get_workspace_root(): string {
    return v18();
}

export const v19 = (v: boolean): void => {
    closure58(undefined, v);
};

export function init_trace_file(x: boolean): void {
    v19(x);
}

export const v20 = (v: string): ((arg0: string) => string) => closure60(undefined, v);

export function op_LessDivideGreater(x: string): ((arg0: string) => string) {
    return v20(x);
}


