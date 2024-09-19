import { defaultOf, compare, IComparable, IEquatable, createAtom } from "../../../deps/Fable/src/fable-library-ts/Util.js";
import { defaultArg, value as value_1, Option } from "../../../deps/Fable/src/fable-library-ts/Option.js";
import { op_Subtraction, op_Addition, toInt64, int64 } from "../../../deps/Fable/src/fable-library-ts/BigInt.js";
import { FSharpRef, Record, Union } from "../../../deps/Fable/src/fable-library-ts/Types.js";
import { int32_type, class_type, bool_type, lambda_type, unit_type, string_type, record_type, int64_type, union_type, TypeInfo } from "../../../deps/Fable/src/fable-library-ts/Reflection.js";
import { int32 } from "../../../deps/Fable/src/fable-library-ts/Int32.js";
import { create, toString, now, getTicks } from "../../../deps/Fable/src/fable-library-ts/Date.js";
import { ofSeq, find } from "../../../deps/Fable/src/fable-library-ts/Map.js";
import { milliseconds, seconds, minutes, hours, fromTicks } from "../../../deps/Fable/src/fable-library-ts/TimeSpan.js";
import { interpolate, toText, trimStart, trimEnd, padLeft } from "../../../deps/Fable/src/fable-library-ts/String.js";

export let TraceState_trace_state = createAtom<Option<[Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>]>>(undefined);

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
    l0: string;
    constructor(l0: string) {
        super();
        this.l0 = l0;
    }
}

export function Mut3_$reflection(): TypeInfo {
    return record_type("Networking.Mut3", [], Mut3, () => [["l0", string_type]]);
}

export class Mut4 extends Record implements IEquatable<Mut4>, IComparable<Mut4> {
    l0: US0_$union;
    constructor(l0: US0_$union) {
        super();
        this.l0 = l0;
    }
}

export function Mut4_$reflection(): TypeInfo {
    return record_type("Networking.Mut4", [], Mut4, () => [["l0", US0_$reflection()]]);
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

export function method0(v0_1: US0_$union): [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] {
    let v124: US2_$union, v131: US2_$union, v138: US2_$union, v145: US2_$union;
    const v112: string = method2(method1());
    const v117: US2_$union = ("Verbose" === v112) ? US2_US2_0(US0_US0_0()) : US2_US2_1();
    const _v1 = [(v117.tag === /* US2_0 */ 0) ? US2_US2_0(v117.fields[0]) : ((v124 = (("Debug" === v112) ? US2_US2_0(US0_US0_1()) : US2_US2_1()), (v124.tag === /* US2_0 */ 0) ? US2_US2_0(v124.fields[0]) : ((v131 = (("Info" === v112) ? US2_US2_0(US0_US0_2()) : US2_US2_1()), (v131.tag === /* US2_0 */ 0) ? US2_US2_0(v131.fields[0]) : ((v138 = (("Warning" === v112) ? US2_US2_0(US0_US0_3()) : US2_US2_1()), (v138.tag === /* US2_0 */ 0) ? US2_US2_0(v138.fields[0]) : ((v145 = (("Critical" === v112) ? US2_US2_0(US0_US0_4()) : US2_US2_1()), (v145.tag === /* US2_0 */ 0) ? US2_US2_0(v145.fields[0]) : US2_US2_1())))))))), (method2(method4()) === "True") ? US3_US3_0(getTicks(now())) : US3_US3_1()] as [US2_$union, US3_$union];
    const v295: US3_$union = _v1[1];
    const v294: US2_$union = _v1[0];
    return [new Mut0(0n), new Mut1((v: string): void => {
        closure3(undefined, v);
    }), new Mut2(true), new Mut3(""), new Mut4((v294.tag === /* US2_0 */ 0) ? v294.fields[0] : v0_1), (v295.tag === /* US3_0 */ 0) ? v295.fields[0] : undefined] as [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>];
}

export function closure0(unitVar: void, unitVar_1: void): void {
    if (TraceState_trace_state() == null) {
        const patternInput: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = method0(US0_US0_0());
        TraceState_trace_state([patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5]] as [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>]);
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

export function closure10(v0_1: Mut3, v1_1: string, unitVar: void): void {
    const v3: string = v0_1.l0 + v1_1;
    v0_1.l0 = v3;
}

export function closure12(v0_1: string, unitVar: void): void {
    console.log(v0_1);
}

export function closure11(unitVar: void, v0_1: string): void {
    let v3: any;
    closure12(v0_1, undefined);
    v3 = undefined;
}

export function closure6(v0_1: int32, v1_1: string, unitVar: void): void {
    let v316: int64, v326: number;
    const v3 = (): void => {
        closure0(undefined, undefined);
    };
    let v4: any;
    v3();
    v4 = undefined;
    const patternInput: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_1(TraceState_trace_state());
    let v37: any;
    v3();
    v37 = undefined;
    const patternInput_1: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_1(TraceState_trace_state());
    const v69: US0_$union = patternInput_1[4].l0;
    if ((patternInput_1[2].l0 === false) ? false : (0 >= find<US0_$union, int32>(v69, ofSeq([[US0_US0_0(), 0] as [US0_$union, int32], [US0_US0_1(), 1] as [US0_$union, int32], [US0_US0_2(), 2] as [US0_$union, int32], [US0_US0_3(), 3] as [US0_$union, int32], [US0_US0_4(), 4] as [US0_$union, int32]], {
        Compare: compare,
    })))) {
        let v77: any;
        closure7(patternInput[0], undefined);
        v77 = undefined;
        let v81: any;
        v3();
        v81 = undefined;
        const patternInput_2: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_1(TraceState_trace_state());
        const _v292: FSharpRef<Option<US3_$union>> = new FSharpRef<Option<US3_$union>>(undefined);
        let v297: any;
        closure9(patternInput_2[5], (v: Option<US3_$union>): FSharpRef<Option<US3_$union>> => closure8(_v292, v), undefined);
        v297 = undefined;
        const v312: US3_$union = defaultArg(_v292.contents, US3_US3_1());
        const v357: string = toString((v312.tag === /* US3_0 */ 0) ? ((v316 = v312.fields[0], (v326 = fromTicks(toInt64(op_Subtraction(getTicks(now()), v316))), create(1, 1, 1, hours(v326), minutes(v326), seconds(v326), milliseconds(v326))))) : now(), method6());
        const v622: string = ("\u001b[90m" + padLeft("Verbose".toLocaleLowerCase(), 7, " ")) + method7();
        const v637: int64 = patternInput_2[0].l0;
        const v639: Mut3 = new Mut3(method8());
        let v646: any;
        closure10(v639, `${"{ "}`, undefined);
        v646 = undefined;
        let v655: any;
        closure10(v639, `${"port"}`, undefined);
        v655 = undefined;
        let v664: any;
        closure10(v639, `${" = "}`, undefined);
        v664 = undefined;
        let v672: any;
        closure10(v639, `${v0_1}`, undefined);
        v672 = undefined;
        let v681: any;
        closure10(v639, `${"; "}`, undefined);
        v681 = undefined;
        let v690: any;
        closure10(v639, `${"ex"}`, undefined);
        v690 = undefined;
        let v698: any;
        closure10(v639, `${" = "}`, undefined);
        v698 = undefined;
        let v706: any;
        closure10(v639, `${v1_1}`, undefined);
        v706 = undefined;
        let v715: any;
        closure10(v639, `${" }"}`, undefined);
        v715 = undefined;
        const v777: string = trimEnd(trimStart(`${v357} ${v622} #${v637} ${"networking.test_port_open"} / ${v639.l0}`, ...[]), ...[" ", "/"]);
        closure11(undefined, v777);
        patternInput[1].l0(v777);
    }
}

export function closure5(v0_1: string, v1_1: int32): any {
    return defaultOf();
}

export function closure4(unitVar: void, v0_1: string): ((arg0: int32) => any) {
    return (v: int32): any => closure5(v0_1, v);
}

export function closure16(unitVar: void, v0_1: boolean): US5_$union {
    return US5_US5_0(v0_1);
}

export function closure17(unitVar: void, v0_1: Error): US5_$union {
    return US5_US5_1(v0_1);
}

export function closure18(v0_1: int32, unitVar: void): void {
    let v315: int64, v325: number;
    const v2_1 = (): void => {
        closure0(undefined, undefined);
    };
    let v3: any;
    v2_1();
    v3 = undefined;
    const patternInput: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_1(TraceState_trace_state());
    let v36: any;
    v2_1();
    v36 = undefined;
    const patternInput_1: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_1(TraceState_trace_state());
    const v68: US0_$union = patternInput_1[4].l0;
    if ((patternInput_1[2].l0 === false) ? false : (0 >= find<US0_$union, int32>(v68, ofSeq([[US0_US0_0(), 0] as [US0_$union, int32], [US0_US0_1(), 1] as [US0_$union, int32], [US0_US0_2(), 2] as [US0_$union, int32], [US0_US0_3(), 3] as [US0_$union, int32], [US0_US0_4(), 4] as [US0_$union, int32]], {
        Compare: compare,
    })))) {
        let v76: any;
        closure7(patternInput[0], undefined);
        v76 = undefined;
        let v80: any;
        v2_1();
        v80 = undefined;
        const patternInput_2: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_1(TraceState_trace_state());
        const _v291: FSharpRef<Option<US3_$union>> = new FSharpRef<Option<US3_$union>>(undefined);
        let v296: any;
        closure9(patternInput_2[5], (v: Option<US3_$union>): FSharpRef<Option<US3_$union>> => closure8(_v291, v), undefined);
        v296 = undefined;
        const v311: US3_$union = defaultArg(_v291.contents, US3_US3_1());
        const v356: string = toString((v311.tag === /* US3_0 */ 0) ? ((v315 = v311.fields[0], (v325 = fromTicks(toInt64(op_Subtraction(getTicks(now()), v315))), create(1, 1, 1, hours(v325), minutes(v325), seconds(v325), milliseconds(v325))))) : now(), method6());
        const v621: string = ("\u001b[90m" + padLeft("Verbose".toLocaleLowerCase(), 7, " ")) + method7();
        const v636: int64 = patternInput_2[0].l0;
        const v638: Mut3 = new Mut3(method8());
        let v645: any;
        closure10(v638, `${"{ "}`, undefined);
        v645 = undefined;
        let v654: any;
        closure10(v638, `${"timeout"}`, undefined);
        v654 = undefined;
        let v663: any;
        closure10(v638, `${" = "}`, undefined);
        v663 = undefined;
        let v671: any;
        closure10(v638, `${v0_1}`, undefined);
        v671 = undefined;
        let v680: any;
        closure10(v638, `${" }"}`, undefined);
        v680 = undefined;
        const v742: string = trimEnd(trimStart(`${v356} ${v621} #${v636} ${"async.run_with_timeout_async"} / ${v638.l0}`, ...[]), ...[" ", "/"]);
        closure11(undefined, v742);
        patternInput[1].l0(v742);
    }
}

export function closure19(v0_1: int32, v1_1: Error, unitVar: void): void {
    let v316: int64, v326: number;
    const v3 = (): void => {
        closure0(undefined, undefined);
    };
    let v4: any;
    v3();
    v4 = undefined;
    const patternInput: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_1(TraceState_trace_state());
    let v37: any;
    v3();
    v37 = undefined;
    const patternInput_1: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_1(TraceState_trace_state());
    const v69: US0_$union = patternInput_1[4].l0;
    if ((patternInput_1[2].l0 === false) ? false : (4 >= find<US0_$union, int32>(v69, ofSeq([[US0_US0_0(), 0] as [US0_$union, int32], [US0_US0_1(), 1] as [US0_$union, int32], [US0_US0_2(), 2] as [US0_$union, int32], [US0_US0_3(), 3] as [US0_$union, int32], [US0_US0_4(), 4] as [US0_$union, int32]], {
        Compare: compare,
    })))) {
        let v77: any;
        closure7(patternInput[0], undefined);
        v77 = undefined;
        let v81: any;
        v3();
        v81 = undefined;
        const patternInput_2: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_1(TraceState_trace_state());
        const _v292: FSharpRef<Option<US3_$union>> = new FSharpRef<Option<US3_$union>>(undefined);
        let v297: any;
        closure9(patternInput_2[5], (v: Option<US3_$union>): FSharpRef<Option<US3_$union>> => closure8(_v292, v), undefined);
        v297 = undefined;
        const v312: US3_$union = defaultArg(_v292.contents, US3_US3_1());
        const v357: string = toString((v312.tag === /* US3_0 */ 0) ? ((v316 = v312.fields[0], (v326 = fromTicks(toInt64(op_Subtraction(getTicks(now()), v316))), create(1, 1, 1, hours(v326), minutes(v326), seconds(v326), milliseconds(v326))))) : now(), method6());
        const v622: string = ("\u001b[91m" + padLeft("Critical".toLocaleLowerCase(), 7, " ")) + method7();
        const v637: int64 = patternInput_2[0].l0;
        const v648: string = toText(interpolate("%A%P()", [v1_1]));
        const v661: Mut3 = new Mut3(method8());
        let v668: any;
        closure10(v661, `${"{ "}`, undefined);
        v668 = undefined;
        let v677: any;
        closure10(v661, `${"timeout"}`, undefined);
        v677 = undefined;
        let v686: any;
        closure10(v661, `${" = "}`, undefined);
        v686 = undefined;
        let v694: any;
        closure10(v661, `${v0_1}`, undefined);
        v694 = undefined;
        let v703: any;
        closure10(v661, `${"; "}`, undefined);
        v703 = undefined;
        let v712: any;
        closure10(v661, `${"ex"}`, undefined);
        v712 = undefined;
        let v720: any;
        closure10(v661, `${" = "}`, undefined);
        v720 = undefined;
        let v728: any;
        closure10(v661, `${v648}`, undefined);
        v728 = undefined;
        let v737: any;
        closure10(v661, `${" }"}`, undefined);
        v737 = undefined;
        const v799: string = trimEnd(trimStart(`${v357} ${v622} #${v637} ${"async.run_with_timeout_async**"} / ${v661.l0}`, ...[]), ...[" ", "/"]);
        closure11(undefined, v799);
        patternInput[1].l0(v799);
    }
}

export function closure15(v0_1: int32, v1_1: string, v2_1: int32): any {
    return defaultOf();
}

export function closure14(v0_1: int32, v1_1: string): ((arg0: int32) => any) {
    return (v: int32): any => closure15(v0_1, v1_1, v);
}

export function closure13(unitVar: void, v0_1: int32): ((arg0: string) => ((arg0: int32) => any)) {
    return (v: string): ((arg0: int32) => any) => closure14(v0_1, v);
}

export function closure24(v0_1: FSharpRef<Option<US7_$union>>, v1_1: Option<US7_$union>): FSharpRef<Option<US7_$union>> {
    v0_1.contents = v1_1;
    return v0_1;
}

export function closure25(v0_1: Option<int32>, v1_1: ((arg0: Option<US7_$union>) => FSharpRef<Option<US7_$union>>), unitVar: void): void {
    let x: int32;
    v1_1((v0_1 == null) ? undefined : ((x = (value_1(v0_1) | 0), ((): US7_$union => US7_US7_0(x))())));
}

export function closure26(v0_1: Option<int32>, v1_1: boolean, v2_1: int32, v3: int64, unitVar: void): void {
    let v318: int64, v328: number;
    const v5 = (): void => {
        closure0(undefined, undefined);
    };
    let v6: any;
    v5();
    v6 = undefined;
    const patternInput: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_1(TraceState_trace_state());
    let v39: any;
    v5();
    v39 = undefined;
    const patternInput_1: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_1(TraceState_trace_state());
    const v71: US0_$union = patternInput_1[4].l0;
    if ((patternInput_1[2].l0 === false) ? false : (0 >= find<US0_$union, int32>(v71, ofSeq([[US0_US0_0(), 0] as [US0_$union, int32], [US0_US0_1(), 1] as [US0_$union, int32], [US0_US0_2(), 2] as [US0_$union, int32], [US0_US0_3(), 3] as [US0_$union, int32], [US0_US0_4(), 4] as [US0_$union, int32]], {
        Compare: compare,
    })))) {
        let v79: any;
        closure7(patternInput[0], undefined);
        v79 = undefined;
        let v83: any;
        v5();
        v83 = undefined;
        const patternInput_2: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_1(TraceState_trace_state());
        const _v294: FSharpRef<Option<US3_$union>> = new FSharpRef<Option<US3_$union>>(undefined);
        let v299: any;
        closure9(patternInput_2[5], (v: Option<US3_$union>): FSharpRef<Option<US3_$union>> => closure8(_v294, v), undefined);
        v299 = undefined;
        const v314: US3_$union = defaultArg(_v294.contents, US3_US3_1());
        const v359: string = toString((v314.tag === /* US3_0 */ 0) ? ((v318 = v314.fields[0], (v328 = fromTicks(toInt64(op_Subtraction(getTicks(now()), v318))), create(1, 1, 1, hours(v328), minutes(v328), seconds(v328), milliseconds(v328))))) : now(), method6());
        const v624: string = ("\u001b[90m" + padLeft("Verbose".toLocaleLowerCase(), 7, " ")) + method7();
        const v639: int64 = patternInput_2[0].l0;
        const v641: Mut3 = new Mut3(method8());
        let v648: any;
        closure10(v641, `${"{ "}`, undefined);
        v648 = undefined;
        let v657: any;
        closure10(v641, `${"port"}`, undefined);
        v657 = undefined;
        let v666: any;
        closure10(v641, `${" = "}`, undefined);
        v666 = undefined;
        let v674: any;
        closure10(v641, `${v2_1}`, undefined);
        v674 = undefined;
        let v683: any;
        closure10(v641, `${"; "}`, undefined);
        v683 = undefined;
        let v692: any;
        closure10(v641, `${"retry"}`, undefined);
        v692 = undefined;
        let v700: any;
        closure10(v641, `${" = "}`, undefined);
        v700 = undefined;
        let v708: any;
        closure10(v641, `${v3}`, undefined);
        v708 = undefined;
        let v716: any;
        closure10(v641, `${"; "}`, undefined);
        v716 = undefined;
        let v725: any;
        closure10(v641, `${"timeout"}`, undefined);
        v725 = undefined;
        let v733: any;
        closure10(v641, `${" = "}`, undefined);
        v733 = undefined;
        let v768: any;
        closure10(v641, `${toText(interpolate("%A%P()", [v0_1]))}`, undefined);
        v768 = undefined;
        let v776: any;
        closure10(v641, `${"; "}`, undefined);
        v776 = undefined;
        let v785: any;
        closure10(v641, `${"status"}`, undefined);
        v785 = undefined;
        let v793: any;
        closure10(v641, `${" = "}`, undefined);
        v793 = undefined;
        let v804: any;
        closure10(v641, `${v1_1 ? "true" : "false"}`, undefined);
        v804 = undefined;
        let v813: any;
        closure10(v641, `${" }"}`, undefined);
        v813 = undefined;
        const v855: string = trimEnd(trimStart(`${v359} ${v624} #${v639} ${"networking.wait_for_port_access"} / ${v641.l0}`, ...[]), ...[" ", "/"]);
        closure11(undefined, v855);
        patternInput[1].l0(v855);
    }
}

export function method9(v0_1: Option<int32>, v1_1: boolean, v2_1: string, v3: int32, v4: int64): any {
    return defaultOf();
}

export function closure23(v0_1: Option<int32>, v1_1: boolean, v2_1: string, v3: int32): any {
    return method9(v0_1, v1_1, v2_1, v3, 0n);
}

export function closure22(v0_1: Option<int32>, v1_1: boolean, v2_1: string): ((arg0: int32) => any) {
    return (v: int32): any => closure23(v0_1, v1_1, v2_1, v);
}

export function closure21(v0_1: Option<int32>, v1_1: boolean): ((arg0: string) => ((arg0: int32) => any)) {
    return (v: string): ((arg0: int32) => any) => closure22(v0_1, v1_1, v);
}

export function closure20(unitVar: void, v0_1: Option<int32>): ((arg0: boolean) => ((arg0: string) => ((arg0: int32) => any))) {
    return (v: boolean): ((arg0: string) => ((arg0: int32) => any)) => closure21(v0_1, v);
}

export function method10(v0_1: Option<int32>, v1_1: string, v2_1: int32): any {
    return defaultOf();
}

export function closure29(v0_1: Option<int32>, v1_1: string, v2_1: int32): any {
    return method10(v0_1, v1_1, v2_1);
}

export function closure28(v0_1: Option<int32>, v1_1: string): ((arg0: int32) => any) {
    return (v: int32): any => closure29(v0_1, v1_1, v);
}

export function closure27(unitVar: void, v0_1: Option<int32>): ((arg0: string) => ((arg0: int32) => any)) {
    return (v: string): ((arg0: int32) => any) => closure28(v0_1, v);
}

export const v0: any = undefined;

export const v1 = (): void => {
    closure0(undefined, undefined);
};

export const v2: any = (v1(), v0);

export const v16 = (v: string): ((arg0: int32) => any) => closure4(undefined, v);

export function test_port_open(x: string): ((arg0: int32) => any) {
    return v16(x);
}

export const v17 = (v: int32): ((arg0: string) => ((arg0: int32) => any)) => closure13(undefined, v);

export function test_port_open_timeout(x: int32): ((arg0: string) => ((arg0: int32) => any)) {
    return v17(x);
}

export const v18 = (v: Option<int32>): ((arg0: boolean) => ((arg0: string) => ((arg0: int32) => any))) => closure20(undefined, v);

export function wait_for_port_access(x: Option<int32>): ((arg0: boolean) => ((arg0: string) => ((arg0: int32) => any))) {
    return v18(x);
}

export const v19 = (v: Option<int32>): ((arg0: string) => ((arg0: int32) => any)) => closure27(undefined, v);

export function get_available_port(x: Option<int32>): ((arg0: string) => ((arg0: int32) => any)) {
    return v19(x);
}


