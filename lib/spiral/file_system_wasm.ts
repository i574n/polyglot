import { IDisposable, compare, equals, defaultOf, IComparable, IEquatable, createAtom } from "../../deps/Fable/src/fable-library-ts/Util.js";
import { map, defaultArg, value as value_3, some, Option } from "../../deps/Fable/src/fable-library-ts/Option.js";
import { op_Addition, toInt64, int64 } from "../../deps/Fable/src/fable-library-ts/BigInt.js";
import { FSharpRef, Union, Record } from "../../deps/Fable/src/fable-library-ts/Types.js";
import { string_type, class_type, union_type, bool_type, record_type, int64_type, TypeInfo } from "../../deps/Fable/src/fable-library-ts/Reflection.js";
import { interpolate, toText, trimStart, trimEnd } from "../../deps/Fable/src/fable-library-ts/String.js";
import * as fs from "fs";
import * as path from "path";

export let State_trace_state = createAtom<Option<[Mut0, Mut1, Mut1, Mut2, Option<int64>]>>(void 0);

export interface IFsExistsSync {
    existsSync(path: string): boolean
}

export interface IPathJoin {
    join(...paths: string[]): string
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
    1: ["US5_1", []]
}

export function US5_US5_0(f0_0: int64) {
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
    return union_type("File_system.US5", [], US5, () => [[["f0_0", int64_type]], []]);
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

export function method0(v0_1: Option<int64>): Option<int64> {
    return v0_1;
}

export function method1(v0_1: Option<int64>): Option<int64> {
    return v0_1;
}

export function closure0(unitVar: void, unitVar_1: void): [Mut0, Mut1, Mut1, Mut2, Option<int64>] {
    const v0_1: Mut1 = new Mut1(true);
    const v1_1: Mut0 = new Mut0(0n);
    const v3_1: Mut2 = new Mut2(US0_US0_0());
    const v4_1: Mut1 = new Mut1(false);
    let _v5: Option<Option<int64>> = void 0;
    const x: Option<int64> = method1(void 0);
    _v5 = some(x);
    return [v1_1, v4_1, v0_1, v3_1, value_3(_v5)] as [Mut0, Mut1, Mut1, Mut2, Option<int64>];
}

export function closure3(unitVar: void, v0_1: string): string {
    let _v1: Option<string> = void 0;
    const x: string = defaultOf();
    _v1 = x;
    return value_3(_v1);
}

export function closure4(unitVar: void, unitVar_1: void): string {
    return "";
}

export function method3(v0_1: string, v1_1: string): string {
    return `path: ${closure3(void 0, v0_1)} / ex: ${v1_1} / ${closure4(void 0, void 0)}`;
}

export function closure2(v0_1: string, v1_1: string, unitVar: void): string {
    return method3(v0_1, v1_1);
}

export function method2(v0_1: string, v1_1: int64): any {
    let _v2: Option<any> = void 0;
    const x: any = defaultOf();
    _v2 = x;
    return value_3(_v2);
}

export function closure1(unitVar: void, v0_1: string): any {
    let _v1: Option<any> = void 0;
    const x: any = defaultOf();
    _v1 = x;
    return value_3(_v1);
}

export function method5(v0_1: string, v1_1: int64, v2_1: string): string {
    return `path: ${closure3(void 0, v0_1)} / retry: ${v1_1} / ex: ${v2_1} / ${closure4(void 0, void 0)}`;
}

export function closure7(v0_1: string, v1_1: int64, v2_1: string, unitVar: void): string {
    return method5(v0_1, v1_1, v2_1);
}

export function method4(v0_1: string, v1_1: US4_$union, v2_1: US3_$union, v3_1: int64): any {
    let _v4: Option<any> = void 0;
    const x: any = defaultOf();
    _v4 = x;
    return value_3(_v4);
}

export function closure6(v0_1: US2_$union, v1_1: string): any {
    let _v2: Option<any> = void 0;
    const x: any = defaultOf();
    _v2 = x;
    return value_3(_v2);
}

export function closure5(unitVar: void, v0_1: US2_$union): ((arg0: string) => any) {
    return (v: string): any => closure6(v0_1, v);
}

export function method6(v0_1: string, v1_1: int64): any {
    let _v2: Option<any> = void 0;
    const x: any = defaultOf();
    _v2 = x;
    return value_3(_v2);
}

export function closure8(unitVar: void, v0_1: string): any {
    let _v1: Option<any> = void 0;
    const x: any = defaultOf();
    _v1 = x;
    return value_3(_v1);
}

export function closure9(unitVar: void, v0_1: string): any {
    let _v1: Option<any> = void 0;
    const x: any = defaultOf();
    _v1 = x;
    return value_3(_v1);
}

export function method7(v0_1: string): string {
    return v0_1;
}

export function closure11(v0_1: string, v1_1: string): any {
    let _v2: Option<any> = void 0;
    const x: any = defaultOf();
    _v2 = x;
    return value_3(_v2);
}

export function closure10(unitVar: void, v0_1: string): ((arg0: string) => any) {
    return (v: string): any => closure11(v0_1, v);
}

export function closure13(v0_1: string, v1_1: string): any {
    let _v2: Option<any> = void 0;
    const x: any = defaultOf();
    _v2 = x;
    return value_3(_v2);
}

export function closure12(unitVar: void, v0_1: string): ((arg0: string) => any) {
    return (v: string): any => closure13(v0_1, v);
}

export function closure15(v0_1: string, v1_1: string): any {
    let _v2: Option<any> = void 0;
    const x: any = defaultOf();
    _v2 = x;
    return value_3(_v2);
}

export function closure14(unitVar: void, v0_1: string): ((arg0: string) => any) {
    return (v: string): any => closure15(v0_1, v);
}

export function closure17(unitVar: void, unitVar_1: void): string {
    return "delete_file_async";
}

export function closure19(unitVar: void, v0_1: int64): US5_$union {
    return US5_US5_0(v0_1);
}

export function method10(): ((arg0: int64) => US5_$union) {
    return (v: int64): US5_$union => closure19(void 0, v);
}

export function method11(): string {
    return "";
}

export function closure18(v0_1: US0_$union, v1_1: (() => string), v2_1: (() => string), unitVar: void): string {
    if (equals(State_trace_state(), void 0)) {
        State_trace_state(closure0(void 0, void 0));
    }
    const patternInput: [Mut0, Mut1, Mut1, Mut2, Option<int64>] = value_3(State_trace_state());
    let _v9: Option<string> = void 0;
    const x: string = method11();
    _v9 = x;
    const v61: string = value_3(_v9);
    const v62: int64 = patternInput[0].l0;
    const v72: string = (v0_1.tag === /* US0_1 */ 1) ? "Debug" : ((v0_1.tag === /* US0_2 */ 2) ? "Info" : ((v0_1.tag === /* US0_0 */ 0) ? "Verbose" : ((v0_1.tag === /* US0_3 */ 3) ? "Warning" : "Critical")));
    let _v74: Option<string> = void 0;
    const x_1: string = v72.toLocaleLowerCase();
    _v74 = x_1;
    return trimEnd(trimStart(`${v61} ${value_3(_v74)} #${v62} ${v1_1()} / ${v2_1()}`), " ", "/");
}

export function method9(v0_1: US0_$union, v1_1: (() => string), v2_1: (() => string)): void {
    const v3_1 = (): [Mut0, Mut1, Mut1, Mut2, Option<int64>] => closure0(void 0, void 0);
    if (equals(State_trace_state(), void 0)) {
        State_trace_state(v3_1());
    }
    const v4_1: Mut0 = value_3(State_trace_state())[0];
    if (equals(State_trace_state(), void 0)) {
        State_trace_state(v3_1());
    }
    const patternInput_1: [Mut0, Mut1, Mut1, Mut2, Option<int64>] = value_3(State_trace_state());
    const v14_1: US0_$union = patternInput_1[3].l0;
    if (patternInput_1[2].l0 && (compare(v0_1, v14_1) >= 0)) {
        const v19: int64 = toInt64(op_Addition(v4_1.l0, 1n));
        v4_1.l0 = v19;
        const v21 = `${closure18(v0_1, v1_1, v2_1, void 0)}`;
        let _v22: Option<void> = void 0;
        console.log(v21);
        _v22 = some(void 0);
        value_3(_v22);
    }
}

export function method8(v0_1: string, v1_1: int64): any {
    let _v2: Option<any> = void 0;
    const x: any = defaultOf();
    _v2 = x;
    return value_3(_v2);
}

export function closure16(unitVar: void, v0_1: string): any {
    let _v1: Option<any> = void 0;
    const x: any = defaultOf();
    _v1 = x;
    return value_3(_v1);
}

export function closure22(unitVar: void, unitVar_1: void): string {
    return "move_file_async";
}

export function method13(v0_1: string, v1_1: string, v2_1: Error): string {
    let _v3: Option<string> = void 0;
    const x: string = toText(interpolate("%A%P()", [v2_1]));
    _v3 = x;
    const v11_1: string = value_3(_v3);
    const v12_1 = (v: string): string => closure3(void 0, v);
    return `old_path: ${v12_1(v1_1)} / new_path: ${v12_1(v0_1)} / ex: ${v11_1} / ${closure4(void 0, void 0)}`;
}

export function closure23(v0_1: string, v1_1: string, v2_1: Error, unitVar: void): string {
    return method13(v0_1, v1_1, v2_1);
}

export function method12(v0_1: string, v1_1: string, v2_1: int64): any {
    let _v3: Option<any> = void 0;
    const x: any = defaultOf();
    _v3 = x;
    return value_3(_v3);
}

export function closure21(v0_1: string, v1_1: string): any {
    let _v2: Option<any> = void 0;
    const x: any = defaultOf();
    _v2 = x;
    return value_3(_v2);
}

export function closure20(unitVar: void, v0_1: string): ((arg0: string) => any) {
    return (v: string): any => closure21(v0_1, v);
}

export function closure25(unitVar: void, v0_1: int64): US6_$union {
    return US6_US6_0(v0_1);
}

export function closure26(unitVar: void, v0_1: Error): US6_$union {
    return US6_US6_1(v0_1);
}

export function closure27(unitVar: void, unitVar_1: void): string {
    return "run_with_timeout_async";
}

export function closure28(unitVar: void, unitVar_1: void): string {
    return `timeout: ${1000} / ${closure4(void 0, void 0)}`;
}

export function closure29(v0_1: string, unitVar: void): string {
    return `run_with_timeout_async** / ex: ${v0_1}`;
}

export function closure30(unitVar: void, unitVar_1: void): string {
    return "read_all_text_retry_async";
}

export function method15(v0_1: int64, v1_1: string): string {
    return `retry: ${v0_1} / ex: ${v1_1} / ${closure4(void 0, void 0)}`;
}

export function closure31(v0_1: int64, v1_1: string, unitVar: void): string {
    return method15(v0_1, v1_1);
}

export function method14(v0_1: string, v1_1: int64): any {
    let _v2: Option<any> = void 0;
    const x: any = defaultOf();
    _v2 = x;
    return value_3(_v2);
}

export function closure24(unitVar: void, v0_1: string): any {
    let _v1: Option<any> = void 0;
    const x: any = defaultOf();
    _v1 = x;
    return value_3(_v1);
}

export function closure33(unitVar: void, unitVar_1: void): string {
    let _v0: Option<string> = void 0;
    const x: string = defaultOf();
    _v0 = x;
    return value_3(_v0);
}

export function method16(v0_1: string): string {
    return v0_1;
}

export function method17(v0_1: string): string {
    return v0_1;
}

export function closure32(unitVar: void, unitVar_1: void): string {
    let _v0: Option<string> = void 0;
    const x: string = defaultOf();
    _v0 = x;
    return value_3(_v0);
}

export function closure35(v0_1: string, v1_1: string, unitVar: void): string {
    return `temp_folder: ${v0_1} / result: ${v1_1} ${closure4(void 0, void 0)}`;
}

export function closure36(v0_1: string, unitVar: void): void {
    let _v1: Option<any> = void 0;
    const x: any = defaultOf();
    _v1 = x;
    const v10_1: any = value_3(_v1);
    let _v11: Option<any> = void 0;
    const x_1: any = defaultOf();
    _v11 = x_1;
    const v20: any = value_3(_v11);
    let _v21: Option<void> = void 0;
    defaultOf();
    _v21 = some(void 0);
    value_3(_v21);
}

export function closure34(unitVar: void, unitVar_1: void): [string, IDisposable] {
    let _v0: Option<[string, IDisposable]> = void 0;
    const patternInput: [string, IDisposable] = defaultOf();
    _v0 = ([patternInput[0], patternInput[1]] as [string, IDisposable]);
    const patternInput_1: [string, IDisposable] = value_3(_v0);
    return [patternInput_1[0], patternInput_1[1]] as [string, IDisposable];
}

export function closure37(unitVar: void, unitVar_1: void): string {
    return "C:\\home\\git\\polyglot\\lib\\spiral";
}

export function closure41(unitVar: void, v0_1: string): boolean {
    let _v1: Option<boolean> = void 0;
    const v20: IFsExistsSync = fs;
    const x: boolean = v20.existsSync(v0_1);
    _v1 = x;
    return value_3(_v1);
}

export function closure42(unitVar: void, v0_1: string): boolean {
    let _v1: Option<boolean> = void 0;
    const v20: IFsExistsSync = fs;
    const x: boolean = v20.existsSync(v0_1);
    _v1 = x;
    return value_3(_v1);
}

export function closure43(unitVar: void, v0_1: string): Option<string> {
    let _v1: Option<US8_$union> = void 0;
    const v38: IPathDirname = path;
    const x: US8_$union = US8_US8_0(v38.dirname(v0_1));
    _v1 = x;
    const v43: US8_$union = value_3(_v1);
    if (v43.tag === /* US8_0 */ 0) {
        return v43.fields[0];
    }
    else {
        return void 0;
    }
}

export function method19(): ((arg0: string) => Option<string>) {
    return (v: string): Option<string> => closure43(void 0, v);
}

export function closure44(unitVar: void, v0_1: string): US8_$union {
    return US8_US8_0(v0_1);
}

export function method20(): ((arg0: string) => US8_$union) {
    return (v: string): US8_$union => closure44(void 0, v);
}

export function method21(v0_1_mut: string, v1_1_mut: boolean, v2_1_mut: string, v3_1_mut: string): string {
    method21:
    while (true) {
        const v0_1: string = v0_1_mut, v1_1: boolean = v1_1_mut, v2_1: string = v2_1_mut, v3_1: string = v3_1_mut;
        let _v4: Option<string> = void 0;
        const v28: IPathJoin = path;
        const v29: string = method16(v3_1);
        const v30: string = method17(v0_1);
        const x: string = v28.join(v29, v30);
        _v4 = x;
        if ((v1_1 ? ((v: string): boolean => closure41(void 0, v)) : ((v_1: string): boolean => closure42(void 0, v_1)))(value_3(_v4))) {
            return v3_1;
        }
        else {
            const v40: Option<string> = method19()(v3_1);
            const v43: US8_$union = defaultArg(map<string, US8_$union>(method20(), v40), US8_US8_1());
            if (v43.tag === /* US8_0 */ 0) {
                v0_1_mut = v0_1;
                v1_1_mut = v1_1;
                v2_1_mut = v2_1;
                v3_1_mut = v43.fields[0];
                continue method21;
            }
            else {
                throw new Error(`No parent for ${v1_1 ? "file" : "dir"} '${v0_1}' at '${v2_1}' (until '${v3_1}')`);
            }
        }
        break;
    }
}

export function method18(v0_1: string, v1_1: boolean, v2_1: string): string {
    let _v3: Option<string> = void 0;
    const v27: IPathJoin = path;
    const v28: string = method16(v2_1);
    const v29: string = method17(v0_1);
    const x: string = v27.join(v28, v29);
    _v3 = x;
    if ((v1_1 ? ((v: string): boolean => closure41(void 0, v)) : ((v_1: string): boolean => closure42(void 0, v_1)))(value_3(_v3))) {
        return v2_1;
    }
    else {
        const v39: Option<string> = method19()(v2_1);
        const v42: US8_$union = defaultArg(map<string, US8_$union>(method20(), v39), US8_US8_1());
        if (v42.tag === /* US8_0 */ 0) {
            return method21(v0_1, v1_1, v2_1, v42.fields[0]);
        }
        else {
            throw new Error(`No parent for ${v1_1 ? "file" : "dir"} '${v0_1}' at '${v2_1}' (until '${v2_1}')`);
        }
    }
}

export function closure40(v0_1: string, v1_1: boolean, v2_1: string): string {
    return method18(v0_1, v1_1, v2_1);
}

export function closure39(v0_1: string, v1_1: boolean): ((arg0: string) => string) {
    return (v: string): string => closure40(v0_1, v1_1, v);
}

export function closure38(unitVar: void, v0_1: string): ((arg0: boolean) => ((arg0: string) => string)) {
    return (v: boolean): ((arg0: string) => string) => closure39(v0_1, v);
}

export function method22(): string {
    return "polyglot";
}

export function method23(): string {
    return ".paket";
}

export function method24(): string {
    return "polyglot";
}

export function method25(): string {
    return ".paket";
}

export function method27(v0_1_mut: string, v1_1_mut: string, v2_1_mut: string): string {
    method27:
    while (true) {
        const v0_1: string = v0_1_mut, v1_1: string = v1_1_mut, v2_1: string = v2_1_mut;
        let _v3: Option<string> = void 0;
        const v27: IPathJoin = path;
        const v28: string = method16(v2_1);
        const v29: string = method17(v0_1);
        const x: string = v27.join(v28, v29);
        _v3 = x;
        const v33: string = value_3(_v3);
        let _v34: Option<boolean> = void 0;
        const v53: IFsExistsSync = fs;
        const x_1: boolean = v53.existsSync(v33);
        _v34 = x_1;
        if (value_3(_v34)) {
            return v2_1;
        }
        else {
            const v59: Option<string> = method19()(v2_1);
            const v62: US8_$union = defaultArg(map<string, US8_$union>(method20(), v59), US8_US8_1());
            if (v62.tag === /* US8_0 */ 0) {
                v0_1_mut = v0_1;
                v1_1_mut = v1_1;
                v2_1_mut = v62.fields[0];
                continue method27;
            }
            else {
                throw new Error(`No parent for ${"dir"} '${v0_1}' at '${v1_1}' (until '${v2_1}')`);
            }
        }
        break;
    }
}

export function method26(v0_1: string, v1_1: string): string {
    let _v2: Option<string> = void 0;
    const v26: IPathJoin = path;
    const v27: string = method16(v1_1);
    const v28: string = method17(v0_1);
    const x: string = v26.join(v27, v28);
    _v2 = x;
    const v32: string = value_3(_v2);
    let _v33: Option<boolean> = void 0;
    const v52: IFsExistsSync = fs;
    const x_1: boolean = v52.existsSync(v32);
    _v33 = x_1;
    if (value_3(_v33)) {
        return v1_1;
    }
    else {
        const v58: Option<string> = method19()(v1_1);
        const v61: US8_$union = defaultArg(map<string, US8_$union>(method20(), v58), US8_US8_1());
        if (v61.tag === /* US8_0 */ 0) {
            return method27(v0_1, v1_1, v61.fields[0]);
        }
        else {
            throw new Error(`No parent for ${"dir"} '${v0_1}' at '${v1_1}' (until '${v1_1}')`);
        }
    }
}

export function method28(): string {
    return "polyglot";
}

export function closure45(unitVar: void, unitVar_1: void): string {
    let _v1: Option<string> = void 0;
    const v27: IPathJoin = path;
    const v28: string = method24();
    const v29: string = method25();
    const x: string = v27.join(v28, v29);
    _v1 = x;
    let _v35: Option<string> = void 0;
    const v58: IPathJoin = path;
    const v59: string = method16(method26(value_3(_v1), "C:\\home\\git\\polyglot\\lib\\spiral"));
    const v60: string = method28();
    const x_1: string = v58.join(v59, v60);
    _v35 = x_1;
    return value_3(_v35);
}

export function closure47(v0_1: string, v1_1: string): string {
    let _v2: Option<string> = void 0;
    const v26: IPathJoin = path;
    const v27: string = method16(v0_1);
    const v28: string = method17(v1_1);
    const x: string = v26.join(v27, v28);
    _v2 = x;
    return value_3(_v2);
}

export function closure46(unitVar: void, v0_1: string): ((arg0: string) => string) {
    return (v: string): string => closure47(v0_1, v);
}

export const v0 = (): [Mut0, Mut1, Mut1, Mut2, Option<int64>] => closure0(void 0, void 0);

if (equals(State_trace_state(), void 0)) {
    State_trace_state(v0());
}

export const v1 = (v: string): any => closure1(void 0, v);

export function delete_directory_async(x: string): any {
    return v1(x);
}

export const v2 = (v: US2_$union): ((arg0: string) => any) => closure5(void 0, v);

export function wait_for_file_access(x: US2_$union): ((arg0: string) => any) {
    return v2(x);
}

export const v3 = (v: string): any => closure8(void 0, v);

export function wait_for_file_access_read(x: string): any {
    return v3(x);
}

export const v4 = (v: string): any => closure9(void 0, v);

export function read_all_text_async(x: string): any {
    return v4(x);
}

export const v5 = (v: string): ((arg0: string) => any) => closure10(void 0, v);

export function file_exists_content(x: string): ((arg0: string) => any) {
    return v5(x);
}

export const v6 = (v: string): ((arg0: string) => any) => closure12(void 0, v);

export function write_all_text_async(x: string): ((arg0: string) => any) {
    return v6(x);
}

export const v7 = (v: string): ((arg0: string) => any) => closure14(void 0, v);

export function write_all_text_exists(x: string): ((arg0: string) => any) {
    return v7(x);
}

export const v8 = (v: string): any => closure16(void 0, v);

export function delete_file_async(x: string): any {
    return v8(x);
}

export const v9 = (v: string): ((arg0: string) => any) => closure20(void 0, v);

export function move_file_async(x: string): ((arg0: string) => any) {
    return v9(x);
}

export const v10 = (v: string): any => closure24(void 0, v);

export function read_all_text_retry_async(x: string): any {
    return v10(x);
}

export const v11 = (): string => closure32(void 0, void 0);

export function create_temp_directory_name(): string {
    return v11();
}

export const v12 = (): [string, IDisposable] => closure34(void 0, void 0);

export function create_temp_directory(): [string, IDisposable] {
    return v12();
}

export const v13 = (): string => closure37(void 0, void 0);

export function get_source_directory(): string {
    return v13();
}

export const v14 = (v: string): ((arg0: boolean) => ((arg0: string) => string)) => closure38(void 0, v);

export function find_parent(x: string): ((arg0: boolean) => ((arg0: string) => string)) {
    return v14(x);
}

export const v15 = (): string => closure45(void 0, void 0);

export function get_workspace_root(): string {
    return v15();
}

export const v16 = (v: string): ((arg0: string) => string) => closure46(void 0, v);

export function op_LessDivideGreater(x: string): ((arg0: string) => string) {
    return v16(x);
}
