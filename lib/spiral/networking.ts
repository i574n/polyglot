import { defaultOf, compare, equals, IComparable, IEquatable, createAtom } from "../../deps/Fable/src/fable-library-ts/Util.js";
import { value as value_1, some, Option } from "../../deps/Fable/src/fable-library-ts/Option.js";
import { op_Addition, toInt64, int64 } from "../../deps/Fable/src/fable-library-ts/BigInt.js";
import { FSharpRef, Union, Record } from "../../deps/Fable/src/fable-library-ts/Types.js";
import { int32_type, class_type, union_type, bool_type, record_type, int64_type, TypeInfo } from "../../deps/Fable/src/fable-library-ts/Reflection.js";
import { int32 } from "../../deps/Fable/src/fable-library-ts/Int32.js";
import { trimStart, trimEnd } from "../../deps/Fable/src/fable-library-ts/String.js";

export let State_trace_state = createAtom<Option<[Mut0, Mut1, Mut1, Mut2, Option<int64>]>>(void 0);

export class Mut0 extends Record implements IEquatable<Mut0>, IComparable<Mut0> {
    l0: int64;
    constructor(l0: int64) {
        super();
        this.l0 = l0;
    }
}

export function Mut0_$reflection(): TypeInfo {
    return record_type("Networking.Mut0", [], Mut0, () => [["l0", int64_type]]);
}

export class Mut1 extends Record implements IEquatable<Mut1>, IComparable<Mut1> {
    l0: boolean;
    constructor(l0: boolean) {
        super();
        this.l0 = l0;
    }
}

export function Mut1_$reflection(): TypeInfo {
    return record_type("Networking.Mut1", [], Mut1, () => [["l0", bool_type]]);
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
    return union_type("Networking.US0", [], US0, () => [[], [], [], [], []]);
}

export class Mut2 extends Record implements IEquatable<Mut2>, IComparable<Mut2> {
    l0: US0_$union;
    constructor(l0: US0_$union) {
        super();
        this.l0 = l0;
    }
}

export function Mut2_$reflection(): TypeInfo {
    return record_type("Networking.Mut2", [], Mut2, () => [["l0", US0_$reflection()]]);
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
    return union_type("Networking.US1", [], US1, () => [[["f0_0", int64_type]], []]);
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
    return union_type("Networking.US2", [], US2, () => [[["f0_0", int64_type]], []]);
}

export type US3_$union = 
    | US3<0>
    | US3<1>

export type US3_$cases = {
    0: ["US3_0", [boolean]],
    1: ["US3_1", []]
}

export function US3_US3_0(f0_0: boolean) {
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
    return union_type("Networking.US3", [], US3, () => [[["f0_0", bool_type]], []]);
}

export type US4_$union = 
    | US4<0>
    | US4<1>

export type US4_$cases = {
    0: ["US4_0", [boolean]],
    1: ["US4_1", [Error]]
}

export function US4_US4_0(f0_0: boolean) {
    return new US4<0>(0, [f0_0]);
}

export function US4_US4_1(f1_0: Error) {
    return new US4<1>(1, [f1_0]);
}

export class US4<Tag extends keyof US4_$cases> extends Union<Tag, US4_$cases[Tag][0]> {
    constructor(readonly tag: Tag, readonly fields: US4_$cases[Tag][1]) {
        super();
    }
    cases() {
        return ["US4_0", "US4_1"];
    }
}

export function US4_$reflection(): TypeInfo {
    return union_type("Networking.US4", [], US4, () => [[["f0_0", bool_type]], [["f1_0", class_type("System.Exception")]]]);
}

export type US5_$union = 
    | US5<0>
    | US5<1>

export type US5_$cases = {
    0: ["US5_0", [boolean]],
    1: ["US5_1", [Error]]
}

export function US5_US5_0(f0_0: boolean) {
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
    return union_type("Networking.US5", [], US5, () => [[["f0_0", bool_type]], [["f1_0", class_type("System.Exception")]]]);
}

export type US6_$union = 
    | US6<0>
    | US6<1>

export type US6_$cases = {
    0: ["US6_0", [int32]],
    1: ["US6_1", []]
}

export function US6_US6_0(f0_0: int32) {
    return new US6<0>(0, [f0_0]);
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
    return union_type("Networking.US6", [], US6, () => [[["f0_0", int32_type]], []]);
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
    return [v1_1, v4_1, v0_1, v3_1, value_1(_v5)] as [Mut0, Mut1, Mut1, Mut2, Option<int64>];
}

export function closure2(v0_1: string, unitVar: void): string {
    return `test_port_open / ex: ${v0_1}`;
}

export function closure3(unitVar: void, unitVar_1: void): string {
    return "";
}

export function closure5(unitVar: void, v0_1: int64): US2_$union {
    return US2_US2_0(v0_1);
}

export function method3(): ((arg0: int64) => US2_$union) {
    return (v: int64): US2_$union => closure5(void 0, v);
}

export function method4(): string {
    return "";
}

export function closure4(v0_1: US0_$union, v1_1: (() => string), v2_1: (() => string), unitVar: void): string {
    if (equals(State_trace_state(), void 0)) {
        State_trace_state(closure0(void 0, void 0));
    }
    const patternInput: [Mut0, Mut1, Mut1, Mut2, Option<int64>] = value_1(State_trace_state());
    let _v9: Option<string> = void 0;
    const x: string = method4();
    _v9 = x;
    const v61: string = value_1(_v9);
    const v62: int64 = patternInput[0].l0;
    const v72: string = (v0_1.tag === /* US0_1 */ 1) ? "Debug" : ((v0_1.tag === /* US0_2 */ 2) ? "Info" : ((v0_1.tag === /* US0_0 */ 0) ? "Verbose" : ((v0_1.tag === /* US0_3 */ 3) ? "Warning" : "Critical")));
    let _v74: Option<string> = void 0;
    const x_1: string = v72.toLocaleLowerCase();
    _v74 = x_1;
    return trimEnd(trimStart(`${v61} ${value_1(_v74)} #${v62} ${v1_1()} / ${v2_1()}`), " ", "/");
}

export function method2(v0_1: US0_$union, v1_1: (() => string), v2_1: (() => string)): void {
    const v3_1 = (): [Mut0, Mut1, Mut1, Mut2, Option<int64>] => closure0(void 0, void 0);
    if (equals(State_trace_state(), void 0)) {
        State_trace_state(v3_1());
    }
    const v4_1: Mut0 = value_1(State_trace_state())[0];
    if (equals(State_trace_state(), void 0)) {
        State_trace_state(v3_1());
    }
    const patternInput_1: [Mut0, Mut1, Mut1, Mut2, Option<int64>] = value_1(State_trace_state());
    const v14: US0_$union = patternInput_1[3].l0;
    if (patternInput_1[2].l0 && (compare(v0_1, v14) >= 0)) {
        const v19: int64 = toInt64(op_Addition(v4_1.l0, 1n));
        v4_1.l0 = v19;
        const v21 = `${closure4(v0_1, v1_1, v2_1, void 0)}`;
        let _v22: Option<void> = void 0;
        console.log(v21);
        _v22 = some(void 0);
        value_1(_v22);
    }
}

export function closure1(unitVar: void, v0_1: int32): any {
    let _v1: Option<any> = void 0;
    const x: any = defaultOf();
    _v1 = x;
    return value_1(_v1);
}

export function closure8(unitVar: void, v0_1: boolean): US4_$union {
    return US4_US4_0(v0_1);
}

export function closure9(unitVar: void, v0_1: Error): US4_$union {
    return US4_US4_1(v0_1);
}

export function closure10(unitVar: void, unitVar_1: void): string {
    return "run_with_timeout_async";
}

export function closure11(v0_1: int32, unitVar: void): string {
    return `timeout: ${v0_1} / ${closure3(void 0, void 0)}`;
}

export function closure12(v0_1: string, unitVar: void): string {
    return `run_with_timeout_async** / ex: ${v0_1}`;
}

export function closure7(v0_1: int32, v1_1: int32): any {
    let _v2: Option<any> = void 0;
    const x: any = defaultOf();
    _v2 = x;
    return value_1(_v2);
}

export function closure6(unitVar: void, v0_1: int32): ((arg0: int32) => any) {
    return (v: int32): any => closure7(v0_1, v);
}

export function closure16(unitVar: void, v0_1: int32): US6_$union {
    return US6_US6_0(v0_1);
}

export function method6(): ((arg0: int32) => US6_$union) {
    return (v: int32): US6_$union => closure16(void 0, v);
}

export function closure17(unitVar: void, unitVar_1: void): string {
    return "wait_for_port_access";
}

export function closure18(v0_1: int32, v1_1: int64, unitVar: void): string {
    return `port: ${v0_1} / retry: ${v1_1} / ${closure3(void 0, void 0)}`;
}

export function method5(v0_1: Option<int32>, v1_1: boolean, v2_1: int32, v3_1: int64): any {
    let _v4: Option<any> = void 0;
    const x: any = defaultOf();
    _v4 = x;
    return value_1(_v4);
}

export function closure15(v0_1: Option<int32>, v1_1: boolean, v2_1: int32): any {
    return method5(v0_1, v1_1, v2_1, 0n);
}

export function closure14(v0_1: Option<int32>, v1_1: boolean): ((arg0: int32) => any) {
    return (v: int32): any => closure15(v0_1, v1_1, v);
}

export function closure13(unitVar: void, v0_1: Option<int32>): ((arg0: boolean) => ((arg0: int32) => any)) {
    return (v: boolean): ((arg0: int32) => any) => closure14(v0_1, v);
}

export function method7(v0_1: Option<int32>, v1_1: int32): any {
    let _v2: Option<any> = void 0;
    const x: any = defaultOf();
    _v2 = x;
    return value_1(_v2);
}

export function closure20(v0_1: Option<int32>, v1_1: int32): any {
    return method7(v0_1, v1_1);
}

export function closure19(unitVar: void, v0_1: Option<int32>): ((arg0: int32) => any) {
    return (v: int32): any => closure20(v0_1, v);
}

export const v0 = (): [Mut0, Mut1, Mut1, Mut2, Option<int64>] => closure0(void 0, void 0);

if (equals(State_trace_state(), void 0)) {
    State_trace_state(v0());
}

export const v1 = (v: int32): any => closure1(void 0, v);

export function test_port_open(x: int32): any {
    return v1(x);
}

export const v2 = (v: int32): ((arg0: int32) => any) => closure6(void 0, v);

export function test_port_open_timeout(x: int32): ((arg0: int32) => any) {
    return v2(x);
}

export const v3 = (v: Option<int32>): ((arg0: boolean) => ((arg0: int32) => any)) => closure13(void 0, v);

export function wait_for_port_access(x: Option<int32>): ((arg0: boolean) => ((arg0: int32) => any)) {
    return v3(x);
}

export const v4 = (v: Option<int32>): ((arg0: int32) => any) => closure19(void 0, v);

export function get_available_port(x: Option<int32>): ((arg0: int32) => any) {
    return v4(x);
}


