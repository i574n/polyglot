import { defaultOf, compare, IComparable, IEquatable, createAtom } from "../../deps/Fable/src/fable-library-ts/Util.js";
import { value as value_1, some, Option } from "../../deps/Fable/src/fable-library-ts/Option.js";
import { op_Addition, toInt64, int64 } from "../../deps/Fable/src/fable-library-ts/BigInt.js";
import { FSharpRef, Record, Union } from "../../deps/Fable/src/fable-library-ts/Types.js";
import { int32_type, class_type, lambda_type, unit_type, string_type, bool_type, record_type, int64_type, union_type, TypeInfo } from "../../deps/Fable/src/fable-library-ts/Reflection.js";
import { int32 } from "../../deps/Fable/src/fable-library-ts/Int32.js";
import { interpolate, toText, trimStart, trimEnd, padLeft } from "../../deps/Fable/src/fable-library-ts/String.js";
import { ofSeq, find } from "../../deps/Fable/src/fable-library-ts/Map.js";

export let State_trace_state = createAtom<Option<[Mut0, Mut1, Mut2, Option<int64>, Mut3]>>(undefined);

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

export class Mut3 extends Record {
    l0: ((arg0: string) => void);
    constructor(l0: ((arg0: string) => void)) {
        super();
        this.l0 = l0;
    }
}

export function Mut3_$reflection(): TypeInfo {
    return record_type("Networking.Mut3", [], Mut3, () => [["l0", lambda_type(string_type, unit_type)]]);
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
    0: ["US2_0", [boolean]],
    1: ["US2_1", []]
}

export function US2_US2_0(f0_0: boolean) {
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
    return union_type("Networking.US2", [], US2, () => [[["f0_0", bool_type]], []]);
}

export type US3_$union = 
    | US3<0>
    | US3<1>

export type US3_$cases = {
    0: ["US3_0", [boolean]],
    1: ["US3_1", [Error]]
}

export function US3_US3_0(f0_0: boolean) {
    return new US3<0>(0, [f0_0]);
}

export function US3_US3_1(f1_0: Error) {
    return new US3<1>(1, [f1_0]);
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
    return union_type("Networking.US3", [], US3, () => [[["f0_0", bool_type]], [["f1_0", class_type("System.Exception")]]]);
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
    0: ["US5_0", [int32]],
    1: ["US5_1", []]
}

export function US5_US5_0(f0_0: int32) {
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
    return union_type("Networking.US5", [], US5, () => [[["f0_0", int32_type]], []]);
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
    })() : value_1(_v6), v5_1] as [Mut0, Mut1, Mut2, Option<int64>, Mut3];
}

export function closure4(v0_1: int32, v1_1: string, unitVar: void): string {
    return `networking.test_port_open / port: ${v0_1} / ex: ${v1_1}`;
}

export function closure5(unitVar: void, unitVar_1: void): string {
    return "";
}

export function method3(): string {
    return "";
}

export function closure6(v0_1: US0_$union, v1_1: (() => string), v2_1: (() => string), unitVar: void): string {
    if (State_trace_state() == null) {
        State_trace_state(closure0(undefined, US0_US0_0()));
    }
    const patternInput: [Mut0, Mut1, Mut2, Option<int64>, Mut3] = value_1(State_trace_state());
    let _v10: Option<string> = undefined;
    const x: string = method3();
    _v10 = x;
    let v67: string;
    if (_v10 == null) {
        throw new Error("base.run_target / _v10=None");
    }
    else {
        v67 = value_1(_v10);
    }
    const v68: int64 = patternInput[0].l0;
    const v78: string = (v0_1.tag === /* US0_1 */ 1) ? "Debug" : ((v0_1.tag === /* US0_2 */ 2) ? "Info" : ((v0_1.tag === /* US0_0 */ 0) ? "Verbose" : ((v0_1.tag === /* US0_3 */ 3) ? "Warning" : "Critical")));
    let _v82: Option<string> = undefined;
    const x_2: string = padLeft(v78.toLocaleLowerCase(), 7, " ");
    _v82 = x_2;
    return trimEnd(trimStart(`${v67} ${(_v82 == null) ? (() => {
        throw new Error("base.run_target / _v82=None");
    })() : value_1(_v82)} #${v68} ${v1_1()} / ${v2_1()}`), " ", "/");
}

export function method4(v0_1: US0_$union, v1_1: (() => string)): void {
    const v2_1 = (v: US0_$union): [Mut0, Mut1, Mut2, Option<int64>, Mut3] => closure0(undefined, v);
    if (State_trace_state() == null) {
        State_trace_state(v2_1(US0_US0_0()));
    }
    const patternInput: [Mut0, Mut1, Mut2, Option<int64>, Mut3] = value_1(State_trace_state());
    const v4_1: Mut0 = patternInput[0];
    if (State_trace_state() == null) {
        State_trace_state(v2_1(US0_US0_0()));
    }
    const patternInput_1: [Mut0, Mut1, Mut2, Option<int64>, Mut3] = value_1(State_trace_state());
    const v15: US0_$union = patternInput_1[2].l0;
    if ((patternInput_1[1].l0 === false) ? false : (find<US0_$union, int32>(v0_1, ofSeq([[US0_US0_0(), 0] as [US0_$union, int32], [US0_US0_1(), 1] as [US0_$union, int32], [US0_US0_2(), 2] as [US0_$union, int32], [US0_US0_3(), 3] as [US0_$union, int32], [US0_US0_4(), 4] as [US0_$union, int32]], {
        Compare: compare,
    })) >= find<US0_$union, int32>(v15, ofSeq([[US0_US0_0(), 0] as [US0_$union, int32], [US0_US0_1(), 1] as [US0_$union, int32], [US0_US0_2(), 2] as [US0_$union, int32], [US0_US0_3(), 3] as [US0_$union, int32], [US0_US0_4(), 4] as [US0_$union, int32]], {
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
            value_1(_v25);
        }
        patternInput[4].l0(v24);
    }
}

export function method2(v0_1: US0_$union, v1_1: (() => string), v2_1: (() => string)): void {
    method4(v0_1, (): string => closure6(v0_1, v1_1, v2_1, undefined));
}

export function closure3(v0_1: string, v1_1: int32): any {
    let _v2: Option<any> = undefined;
    const x: any = defaultOf();
    _v2 = x;
    if (_v2 == null) {
        throw new Error("base.run_target / _v2=None");
    }
    else {
        return value_1(_v2);
    }
}

export function closure2(unitVar: void, v0_1: string): ((arg0: int32) => any) {
    return (v: int32): any => closure3(v0_1, v);
}

export function closure10(unitVar: void, v0_1: boolean): US3_$union {
    return US3_US3_0(v0_1);
}

export function closure11(unitVar: void, v0_1: Error): US3_$union {
    return US3_US3_1(v0_1);
}

export function closure12(unitVar: void, unitVar_1: void): string {
    return "run_with_timeout_async";
}

export function closure13(v0_1: int32, unitVar: void): string {
    return `timeout: ${v0_1} / ${closure5(undefined, undefined)}`;
}

export function closure14(v0_1: string, unitVar: void): string {
    return `run_with_timeout_async** / ex: ${v0_1}`;
}

export function closure9(v0_1: int32, v1_1: string, v2_1: int32): any {
    let _v3: Option<any> = undefined;
    const x: any = defaultOf();
    _v3 = x;
    if (_v3 == null) {
        throw new Error("base.run_target / _v3=None");
    }
    else {
        return value_1(_v3);
    }
}

export function closure8(v0_1: int32, v1_1: string): ((arg0: int32) => any) {
    return (v: int32): any => closure9(v0_1, v1_1, v);
}

export function closure7(unitVar: void, v0_1: int32): ((arg0: string) => ((arg0: int32) => any)) {
    return (v: string): ((arg0: int32) => any) => closure8(v0_1, v);
}

export function closure19(unitVar: void, unitVar_1: void): string {
    return "networking.wait_for_port_access";
}

export function closure20(v0_1: Option<int32>, v1_1: boolean, v2_1: int32, v3_1: int64, unitVar: void): string {
    return toText(interpolate("port: %P() / retry: %P() / timeout: %A%P() / status: %P() / %P()", [v2_1, v3_1, v0_1, v1_1, closure5(undefined, undefined)]));
}

export function method5(v0_1: Option<int32>, v1_1: boolean, v2_1: string, v3_1: int32, v4_1: int64): any {
    let _v5: Option<any> = undefined;
    const x: any = defaultOf();
    _v5 = x;
    if (_v5 == null) {
        throw new Error("base.run_target / _v5=None");
    }
    else {
        return value_1(_v5);
    }
}

export function closure18(v0_1: Option<int32>, v1_1: boolean, v2_1: string, v3_1: int32): any {
    return method5(v0_1, v1_1, v2_1, v3_1, 0n);
}

export function closure17(v0_1: Option<int32>, v1_1: boolean, v2_1: string): ((arg0: int32) => any) {
    return (v: int32): any => closure18(v0_1, v1_1, v2_1, v);
}

export function closure16(v0_1: Option<int32>, v1_1: boolean): ((arg0: string) => ((arg0: int32) => any)) {
    return (v: string): ((arg0: int32) => any) => closure17(v0_1, v1_1, v);
}

export function closure15(unitVar: void, v0_1: Option<int32>): ((arg0: boolean) => ((arg0: string) => ((arg0: int32) => any))) {
    return (v: boolean): ((arg0: string) => ((arg0: int32) => any)) => closure16(v0_1, v);
}

export function method6(v0_1: Option<int32>, v1_1: string, v2_1: int32): any {
    let _v3: Option<any> = undefined;
    const x: any = defaultOf();
    _v3 = x;
    if (_v3 == null) {
        throw new Error("base.run_target / _v3=None");
    }
    else {
        return value_1(_v3);
    }
}

export function closure23(v0_1: Option<int32>, v1_1: string, v2_1: int32): any {
    return method6(v0_1, v1_1, v2_1);
}

export function closure22(v0_1: Option<int32>, v1_1: string): ((arg0: int32) => any) {
    return (v: int32): any => closure23(v0_1, v1_1, v);
}

export function closure21(unitVar: void, v0_1: Option<int32>): ((arg0: string) => ((arg0: int32) => any)) {
    return (v: string): ((arg0: int32) => any) => closure22(v0_1, v);
}

export const v0 = (v: US0_$union): [Mut0, Mut1, Mut2, Option<int64>, Mut3] => closure0(undefined, v);

export const v1: US0_$union = US0_US0_0();

if (State_trace_state() == null) {
    State_trace_state(v0(v1));
}

export const v2 = (v: string): ((arg0: int32) => any) => closure2(undefined, v);

export function test_port_open(x: string): ((arg0: int32) => any) {
    return v2(x);
}

export const v3 = (v: int32): ((arg0: string) => ((arg0: int32) => any)) => closure7(undefined, v);

export function test_port_open_timeout(x: int32): ((arg0: string) => ((arg0: int32) => any)) {
    return v3(x);
}

export const v4 = (v: Option<int32>): ((arg0: boolean) => ((arg0: string) => ((arg0: int32) => any))) => closure15(undefined, v);

export function wait_for_port_access(x: Option<int32>): ((arg0: boolean) => ((arg0: string) => ((arg0: int32) => any))) {
    return v4(x);
}

export const v5 = (v: Option<int32>): ((arg0: string) => ((arg0: int32) => any)) => closure21(undefined, v);

export function get_available_port(x: Option<int32>): ((arg0: string) => ((arg0: int32) => any)) {
    return v5(x);
}


