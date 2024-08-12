import { defaultOf, compare, IComparable, IEquatable, createAtom } from "../../deps/Fable/src/fable-library-ts/Util.js";
import { defaultArg, value as value_1, Option } from "../../deps/Fable/src/fable-library-ts/Option.js";
import { op_Subtraction, op_Addition, toInt64, int64 } from "../../deps/Fable/src/fable-library-ts/BigInt.js";
import { FSharpRef, Record, Union } from "../../deps/Fable/src/fable-library-ts/Types.js";
import { int32_type, class_type, bool_type, lambda_type, unit_type, string_type, record_type, int64_type, union_type, TypeInfo } from "../../deps/Fable/src/fable-library-ts/Reflection.js";
import { int32 } from "../../deps/Fable/src/fable-library-ts/Int32.js";
import { create, toString, now, getTicks } from "../../deps/Fable/src/fable-library-ts/Date.js";
import { ofSeq, find } from "../../deps/Fable/src/fable-library-ts/Map.js";
import { milliseconds, seconds, minutes, hours, fromTicks } from "../../deps/Fable/src/fable-library-ts/TimeSpan.js";
import { interpolate, toText, trimStart, trimEnd, padLeft } from "../../deps/Fable/src/fable-library-ts/String.js";

export let State_trace_state = createAtom<Option<[Mut0, Mut1, Mut2, Mut3, Option<int64>]>>(undefined);

export interface IOsEnviron {
    environ(): any
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

export class Mut1 extends Record {
    l0: ((arg0: string) => void);
    constructor(l0: ((arg0: string) => void)) {
        super();
        this.l0 = l0;
    }
}

export function Mut1_$reflection(): TypeInfo {
    return record_type("Networking.Mut1", [], Mut1, () => [["l0", lambda_type(string_type, unit_type)]]);
}

export class Mut2 extends Record implements IEquatable<Mut2>, IComparable<Mut2> {
    l0: boolean;
    constructor(l0: boolean) {
        super();
        this.l0 = l0;
    }
}

export function Mut2_$reflection(): TypeInfo {
    return record_type("Networking.Mut2", [], Mut2, () => [["l0", bool_type]]);
}

export class Mut3 extends Record implements IEquatable<Mut3>, IComparable<Mut3> {
    l0: US0_$union;
    constructor(l0: US0_$union) {
        super();
        this.l0 = l0;
    }
}

export function Mut3_$reflection(): TypeInfo {
    return record_type("Networking.Mut3", [], Mut3, () => [["l0", US0_$reflection()]]);
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
    return union_type("Networking.US1", [], US1, () => [[["f0_0", string_type]], []]);
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
    return union_type("Networking.US2", [], US2, () => [[["f0_0", US0_$reflection()]], []]);
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
    return union_type("Networking.US3", [], US3, () => [[["f0_0", int64_type]], []]);
}

export class Mut4 extends Record implements IEquatable<Mut4>, IComparable<Mut4> {
    l0: string;
    constructor(l0: string) {
        super();
        this.l0 = l0;
    }
}

export function Mut4_$reflection(): TypeInfo {
    return record_type("Networking.Mut4", [], Mut4, () => [["l0", string_type]]);
}

export type US4_$union = 
    | US4<0>
    | US4<1>

export type US4_$cases = {
    0: ["US4_0", [boolean]],
    1: ["US4_1", []]
}

export function US4_US4_0(f0_0: boolean) {
    return new US4<0>(0, [f0_0]);
}

export function US4_US4_1() {
    return new US4<1>(1, []);
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
    return union_type("Networking.US4", [], US4, () => [[["f0_0", bool_type]], []]);
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
    0: ["US6_0", [boolean]],
    1: ["US6_1", [Error]]
}

export function US6_US6_0(f0_0: boolean) {
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
    return union_type("Networking.US6", [], US6, () => [[["f0_0", bool_type]], [["f1_0", class_type("System.Exception")]]]);
}

export type US7_$union = 
    | US7<0>
    | US7<1>

export type US7_$cases = {
    0: ["US7_0", [int32]],
    1: ["US7_1", []]
}

export function US7_US7_0(f0_0: int32) {
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
    return union_type("Networking.US7", [], US7, () => [[["f0_0", int32_type]], []]);
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
    v1_1((v0_1 == null) ? undefined : ((x = value_1(v0_1), ((): US1_$union => US1_US1_0(x))())));
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

export function closure7(v0_1: Mut0, unitVar: void): void {
    const v2_1: int64 = toInt64(op_Addition(v0_1.l0, 1n));
    v0_1.l0 = v2_1;
}

export function closure8(v0_1: FSharpRef<Option<US3_$union>>, v1_1: Option<US3_$union>): FSharpRef<Option<US3_$union>> {
    v0_1.contents = v1_1;
    return v0_1;
}

export function closure9(v0_1: Option<int64>, v1_1: ((arg0: Option<US3_$union>) => FSharpRef<Option<US3_$union>>), unitVar: void): void {
    let x: int64;
    v1_1((v0_1 == null) ? undefined : ((x = value_1(v0_1), ((): US3_$union => US3_US3_0(x))())));
}

export function method5(): string {
    return "hh:mm:ss";
}

export function method6(): string {
    return "HH:mm:ss";
}

export function method7(): string {
    return "\u001b[0m";
}

export function method8(): string {
    return "";
}

export function closure10(v0_1: Mut4, v1_1: string, unitVar: void): void {
    const v3: string = v0_1.l0 + v1_1;
    v0_1.l0 = v3;
}

export function closure11(unitVar: void, unitVar_1: void): string {
    return "networking.test_port_open";
}

export function closure6(v0_1: int32, v1_1: string, unitVar: void): void {
    let v264: int64, v274: number;
    const v3 = (): void => {
        closure0(undefined, undefined);
    };
    let v4: any;
    v3();
    v4 = undefined;
    const patternInput: [Mut0, Mut1, Mut2, Mut3, Option<int64>] = value_1(State_trace_state());
    let v23: any;
    v3();
    v23 = undefined;
    const patternInput_1: [Mut0, Mut1, Mut2, Mut3, Option<int64>] = value_1(State_trace_state());
    const v41: US0_$union = patternInput_1[3].l0;
    if ((patternInput_1[2].l0 === false) ? false : (0 >= find<US0_$union, int32>(v41, ofSeq([[US0_US0_0(), 0] as [US0_$union, int32], [US0_US0_1(), 1] as [US0_$union, int32], [US0_US0_2(), 2] as [US0_$union, int32], [US0_US0_3(), 3] as [US0_$union, int32], [US0_US0_4(), 4] as [US0_$union, int32]], {
        Compare: compare,
    })))) {
        let v49: any;
        closure7(patternInput[0], undefined);
        v49 = undefined;
        let v51: any;
        v3();
        v51 = undefined;
        const patternInput_2: [Mut0, Mut1, Mut2, Mut3, Option<int64>] = value_1(State_trace_state());
        const _v242: FSharpRef<Option<US3_$union>> = new FSharpRef<Option<US3_$union>>(undefined);
        let v247: any;
        closure9(patternInput_2[4], (v: Option<US3_$union>): FSharpRef<Option<US3_$union>> => closure8(_v242, v), undefined);
        v247 = undefined;
        const v260: US3_$union = defaultArg(_v242.contents, US3_US3_1());
        const v305: string = toString((v260.tag === /* US3_0 */ 0) ? ((v264 = v260.fields[0], (v274 = fromTicks(toInt64(op_Subtraction(getTicks(now()), v264))), create(1, 1, 1, hours(v274), minutes(v274), seconds(v274), milliseconds(v274))))) : now(), method6());
        const v564: string = ("\u001b[90m" + padLeft("Verbose".toLocaleLowerCase(), 7, " ")) + method7();
        const v579: int64 = patternInput_2[0].l0;
        const v581: Mut4 = new Mut4(method8());
        let v588: any;
        closure10(v581, `${"{ "}`, undefined);
        v588 = undefined;
        let v595: any;
        closure10(v581, `${"port"}`, undefined);
        v595 = undefined;
        let v602: any;
        closure10(v581, `${" = "}`, undefined);
        v602 = undefined;
        let v608: any;
        closure10(v581, `${v0_1}`, undefined);
        v608 = undefined;
        let v615: any;
        closure10(v581, `${"; "}`, undefined);
        v615 = undefined;
        let v622: any;
        closure10(v581, `${"ex"}`, undefined);
        v622 = undefined;
        let v628: any;
        closure10(v581, `${" = "}`, undefined);
        v628 = undefined;
        let v634: any;
        closure10(v581, `${v1_1}`, undefined);
        v634 = undefined;
        let v641: any;
        closure10(v581, `${" }"}`, undefined);
        v641 = undefined;
        const v642: string = v581.l0;
        const v681: string = trimEnd(trimStart(`${v305} ${v564} #${v579} ${closure11(undefined, undefined)} / ${v642}`, ...[]), ...[" ", "/"]);
        console.log(v681);
        patternInput[1].l0(v681);
    }
}

export function closure5(v0_1: string, v1_1: int32): any {
    return defaultOf();
}

export function closure4(unitVar: void, v0_1: string): ((arg0: int32) => any) {
    return (v: int32): any => closure5(v0_1, v);
}

export function closure15(unitVar: void, v0_1: boolean): US5_$union {
    return US5_US5_0(v0_1);
}

export function closure16(unitVar: void, v0_1: Error): US5_$union {
    return US5_US5_1(v0_1);
}

export function closure18(unitVar: void, unitVar_1: void): string {
    return "async.run_with_timeout_async";
}

export function closure17(v0_1: int32, unitVar: void): void {
    let v263: int64, v273: number;
    const v2_1 = (): void => {
        closure0(undefined, undefined);
    };
    let v3: any;
    v2_1();
    v3 = undefined;
    const patternInput: [Mut0, Mut1, Mut2, Mut3, Option<int64>] = value_1(State_trace_state());
    let v22: any;
    v2_1();
    v22 = undefined;
    const patternInput_1: [Mut0, Mut1, Mut2, Mut3, Option<int64>] = value_1(State_trace_state());
    const v40: US0_$union = patternInput_1[3].l0;
    if ((patternInput_1[2].l0 === false) ? false : (0 >= find<US0_$union, int32>(v40, ofSeq([[US0_US0_0(), 0] as [US0_$union, int32], [US0_US0_1(), 1] as [US0_$union, int32], [US0_US0_2(), 2] as [US0_$union, int32], [US0_US0_3(), 3] as [US0_$union, int32], [US0_US0_4(), 4] as [US0_$union, int32]], {
        Compare: compare,
    })))) {
        let v48: any;
        closure7(patternInput[0], undefined);
        v48 = undefined;
        let v50: any;
        v2_1();
        v50 = undefined;
        const patternInput_2: [Mut0, Mut1, Mut2, Mut3, Option<int64>] = value_1(State_trace_state());
        const _v241: FSharpRef<Option<US3_$union>> = new FSharpRef<Option<US3_$union>>(undefined);
        let v246: any;
        closure9(patternInput_2[4], (v: Option<US3_$union>): FSharpRef<Option<US3_$union>> => closure8(_v241, v), undefined);
        v246 = undefined;
        const v259: US3_$union = defaultArg(_v241.contents, US3_US3_1());
        const v304: string = toString((v259.tag === /* US3_0 */ 0) ? ((v263 = v259.fields[0], (v273 = fromTicks(toInt64(op_Subtraction(getTicks(now()), v263))), create(1, 1, 1, hours(v273), minutes(v273), seconds(v273), milliseconds(v273))))) : now(), method6());
        const v563: string = ("\u001b[90m" + padLeft("Verbose".toLocaleLowerCase(), 7, " ")) + method7();
        const v578: int64 = patternInput_2[0].l0;
        const v580: Mut4 = new Mut4(method8());
        let v587: any;
        closure10(v580, `${"{ "}`, undefined);
        v587 = undefined;
        let v594: any;
        closure10(v580, `${"timeout"}`, undefined);
        v594 = undefined;
        let v601: any;
        closure10(v580, `${" = "}`, undefined);
        v601 = undefined;
        let v607: any;
        closure10(v580, `${v0_1}`, undefined);
        v607 = undefined;
        let v614: any;
        closure10(v580, `${" }"}`, undefined);
        v614 = undefined;
        const v615: string = v580.l0;
        const v654: string = trimEnd(trimStart(`${v304} ${v563} #${v578} ${closure18(undefined, undefined)} / ${v615}`, ...[]), ...[" ", "/"]);
        console.log(v654);
        patternInput[1].l0(v654);
    }
}

export function closure20(unitVar: void, unitVar_1: void): string {
    return "async.run_with_timeout_async**";
}

export function closure19(v0_1: int32, v1_1: Error, unitVar: void): void {
    let v264: int64, v274: number;
    const v3 = (): void => {
        closure0(undefined, undefined);
    };
    let v4: any;
    v3();
    v4 = undefined;
    const patternInput: [Mut0, Mut1, Mut2, Mut3, Option<int64>] = value_1(State_trace_state());
    let v23: any;
    v3();
    v23 = undefined;
    const patternInput_1: [Mut0, Mut1, Mut2, Mut3, Option<int64>] = value_1(State_trace_state());
    const v41: US0_$union = patternInput_1[3].l0;
    if ((patternInput_1[2].l0 === false) ? false : (4 >= find<US0_$union, int32>(v41, ofSeq([[US0_US0_0(), 0] as [US0_$union, int32], [US0_US0_1(), 1] as [US0_$union, int32], [US0_US0_2(), 2] as [US0_$union, int32], [US0_US0_3(), 3] as [US0_$union, int32], [US0_US0_4(), 4] as [US0_$union, int32]], {
        Compare: compare,
    })))) {
        let v49: any;
        closure7(patternInput[0], undefined);
        v49 = undefined;
        let v51: any;
        v3();
        v51 = undefined;
        const patternInput_2: [Mut0, Mut1, Mut2, Mut3, Option<int64>] = value_1(State_trace_state());
        const _v242: FSharpRef<Option<US3_$union>> = new FSharpRef<Option<US3_$union>>(undefined);
        let v247: any;
        closure9(patternInput_2[4], (v: Option<US3_$union>): FSharpRef<Option<US3_$union>> => closure8(_v242, v), undefined);
        v247 = undefined;
        const v260: US3_$union = defaultArg(_v242.contents, US3_US3_1());
        const v305: string = toString((v260.tag === /* US3_0 */ 0) ? ((v264 = v260.fields[0], (v274 = fromTicks(toInt64(op_Subtraction(getTicks(now()), v264))), create(1, 1, 1, hours(v274), minutes(v274), seconds(v274), milliseconds(v274))))) : now(), method6());
        const v564: string = ("\u001b[91m" + padLeft("Critical".toLocaleLowerCase(), 7, " ")) + method7();
        const v579: int64 = patternInput_2[0].l0;
        const v590: string = toText(interpolate("%A%P()", [v1_1]));
        const v603: Mut4 = new Mut4(method8());
        let v610: any;
        closure10(v603, `${"{ "}`, undefined);
        v610 = undefined;
        let v617: any;
        closure10(v603, `${"timeout"}`, undefined);
        v617 = undefined;
        let v624: any;
        closure10(v603, `${" = "}`, undefined);
        v624 = undefined;
        let v630: any;
        closure10(v603, `${v0_1}`, undefined);
        v630 = undefined;
        let v637: any;
        closure10(v603, `${"; "}`, undefined);
        v637 = undefined;
        let v644: any;
        closure10(v603, `${"ex"}`, undefined);
        v644 = undefined;
        let v650: any;
        closure10(v603, `${" = "}`, undefined);
        v650 = undefined;
        let v656: any;
        closure10(v603, `${v590}`, undefined);
        v656 = undefined;
        let v663: any;
        closure10(v603, `${" }"}`, undefined);
        v663 = undefined;
        const v664: string = v603.l0;
        const v703: string = trimEnd(trimStart(`${v305} ${v564} #${v579} ${closure20(undefined, undefined)} / ${v664}`, ...[]), ...[" ", "/"]);
        console.log(v703);
        patternInput[1].l0(v703);
    }
}

export function closure14(v0_1: int32, v1_1: string, v2_1: int32): any {
    return defaultOf();
}

export function closure13(v0_1: int32, v1_1: string): ((arg0: int32) => any) {
    return (v: int32): any => closure14(v0_1, v1_1, v);
}

export function closure12(unitVar: void, v0_1: int32): ((arg0: string) => ((arg0: int32) => any)) {
    return (v: string): ((arg0: int32) => any) => closure13(v0_1, v);
}

export function closure25(v0_1: FSharpRef<Option<US7_$union>>, v1_1: Option<US7_$union>): FSharpRef<Option<US7_$union>> {
    v0_1.contents = v1_1;
    return v0_1;
}

export function closure26(v0_1: Option<int32>, v1_1: ((arg0: Option<US7_$union>) => FSharpRef<Option<US7_$union>>), unitVar: void): void {
    let x: int32;
    v1_1((v0_1 == null) ? undefined : ((x = (value_1(v0_1) | 0), ((): US7_$union => US7_US7_0(x))())));
}

export function closure28(unitVar: void, unitVar_1: void): string {
    return "networking.wait_for_port_access";
}

export function closure27(v0_1: Option<int32>, v1_1: boolean, v2_1: int32, v3: int64, unitVar: void): void {
    let v266: int64, v276: number;
    const v5_1 = (): void => {
        closure0(undefined, undefined);
    };
    let v6_1: any;
    v5_1();
    v6_1 = undefined;
    const patternInput: [Mut0, Mut1, Mut2, Mut3, Option<int64>] = value_1(State_trace_state());
    let v25: any;
    v5_1();
    v25 = undefined;
    const patternInput_1: [Mut0, Mut1, Mut2, Mut3, Option<int64>] = value_1(State_trace_state());
    const v43: US0_$union = patternInput_1[3].l0;
    if ((patternInput_1[2].l0 === false) ? false : (0 >= find<US0_$union, int32>(v43, ofSeq([[US0_US0_0(), 0] as [US0_$union, int32], [US0_US0_1(), 1] as [US0_$union, int32], [US0_US0_2(), 2] as [US0_$union, int32], [US0_US0_3(), 3] as [US0_$union, int32], [US0_US0_4(), 4] as [US0_$union, int32]], {
        Compare: compare,
    })))) {
        let v51: any;
        closure7(patternInput[0], undefined);
        v51 = undefined;
        let v53: any;
        v5_1();
        v53 = undefined;
        const patternInput_2: [Mut0, Mut1, Mut2, Mut3, Option<int64>] = value_1(State_trace_state());
        const _v244: FSharpRef<Option<US3_$union>> = new FSharpRef<Option<US3_$union>>(undefined);
        let v249: any;
        closure9(patternInput_2[4], (v: Option<US3_$union>): FSharpRef<Option<US3_$union>> => closure8(_v244, v), undefined);
        v249 = undefined;
        const v262: US3_$union = defaultArg(_v244.contents, US3_US3_1());
        const v307: string = toString((v262.tag === /* US3_0 */ 0) ? ((v266 = v262.fields[0], (v276 = fromTicks(toInt64(op_Subtraction(getTicks(now()), v266))), create(1, 1, 1, hours(v276), minutes(v276), seconds(v276), milliseconds(v276))))) : now(), method6());
        const v566: string = ("\u001b[90m" + padLeft("Verbose".toLocaleLowerCase(), 7, " ")) + method7();
        const v581: int64 = patternInput_2[0].l0;
        const v583: Mut4 = new Mut4(method8());
        let v590: any;
        closure10(v583, `${"{ "}`, undefined);
        v590 = undefined;
        let v597: any;
        closure10(v583, `${"port"}`, undefined);
        v597 = undefined;
        let v604: any;
        closure10(v583, `${" = "}`, undefined);
        v604 = undefined;
        let v610: any;
        closure10(v583, `${v2_1}`, undefined);
        v610 = undefined;
        let v617: any;
        closure10(v583, `${"; "}`, undefined);
        v617 = undefined;
        let v624: any;
        closure10(v583, `${"retry"}`, undefined);
        v624 = undefined;
        let v630: any;
        closure10(v583, `${" = "}`, undefined);
        v630 = undefined;
        let v636: any;
        closure10(v583, `${v3}`, undefined);
        v636 = undefined;
        let v642: any;
        closure10(v583, `${"; "}`, undefined);
        v642 = undefined;
        let v649: any;
        closure10(v583, `${"timeout"}`, undefined);
        v649 = undefined;
        let v655: any;
        closure10(v583, `${" = "}`, undefined);
        v655 = undefined;
        let v688: any;
        closure10(v583, `${toText(interpolate("%A%P()", [v0_1]))}`, undefined);
        v688 = undefined;
        let v694: any;
        closure10(v583, `${"; "}`, undefined);
        v694 = undefined;
        let v701: any;
        closure10(v583, `${"status"}`, undefined);
        v701 = undefined;
        let v707: any;
        closure10(v583, `${" = "}`, undefined);
        v707 = undefined;
        let v716: any;
        closure10(v583, `${v1_1 ? "true" : "false"}`, undefined);
        v716 = undefined;
        let v723: any;
        closure10(v583, `${" }"}`, undefined);
        v723 = undefined;
        const v724: string = v583.l0;
        const v763: string = trimEnd(trimStart(`${v307} ${v566} #${v581} ${closure28(undefined, undefined)} / ${v724}`, ...[]), ...[" ", "/"]);
        console.log(v763);
        patternInput[1].l0(v763);
    }
}

export function method9(v0_1: Option<int32>, v1_1: boolean, v2_1: string, v3: int32, v4: int64): any {
    return defaultOf();
}

export function closure24(v0_1: Option<int32>, v1_1: boolean, v2_1: string, v3: int32): any {
    return method9(v0_1, v1_1, v2_1, v3, 0n);
}

export function closure23(v0_1: Option<int32>, v1_1: boolean, v2_1: string): ((arg0: int32) => any) {
    return (v: int32): any => closure24(v0_1, v1_1, v2_1, v);
}

export function closure22(v0_1: Option<int32>, v1_1: boolean): ((arg0: string) => ((arg0: int32) => any)) {
    return (v: string): ((arg0: int32) => any) => closure23(v0_1, v1_1, v);
}

export function closure21(unitVar: void, v0_1: Option<int32>): ((arg0: boolean) => ((arg0: string) => ((arg0: int32) => any))) {
    return (v: boolean): ((arg0: string) => ((arg0: int32) => any)) => closure22(v0_1, v);
}

export function method10(v0_1: Option<int32>, v1_1: string, v2_1: int32): any {
    return defaultOf();
}

export function closure31(v0_1: Option<int32>, v1_1: string, v2_1: int32): any {
    return method10(v0_1, v1_1, v2_1);
}

export function closure30(v0_1: Option<int32>, v1_1: string): ((arg0: int32) => any) {
    return (v: int32): any => closure31(v0_1, v1_1, v);
}

export function closure29(unitVar: void, v0_1: Option<int32>): ((arg0: string) => ((arg0: int32) => any)) {
    return (v: string): ((arg0: int32) => any) => closure30(v0_1, v);
}

export const v0: any = undefined;

export const v1 = (): void => {
    closure0(undefined, undefined);
};

export const v2: any = (v1(), v0);

export const v5 = (v: string): ((arg0: int32) => any) => closure4(undefined, v);

export function test_port_open(x: string): ((arg0: int32) => any) {
    return v5(x);
}

export const v6 = (v: int32): ((arg0: string) => ((arg0: int32) => any)) => closure12(undefined, v);

export function test_port_open_timeout(x: int32): ((arg0: string) => ((arg0: int32) => any)) {
    return v6(x);
}

export const v7 = (v: Option<int32>): ((arg0: boolean) => ((arg0: string) => ((arg0: int32) => any))) => closure21(undefined, v);

export function wait_for_port_access(x: Option<int32>): ((arg0: boolean) => ((arg0: string) => ((arg0: int32) => any))) {
    return v7(x);
}

export const v8 = (v: Option<int32>): ((arg0: string) => ((arg0: int32) => any)) => closure29(undefined, v);

export function get_available_port(x: Option<int32>): ((arg0: string) => ((arg0: int32) => any)) {
    return v8(x);
}


