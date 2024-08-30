import { defaultOf, compare, IComparable, IEquatable, createAtom } from "../../deps/Fable/src/fable-library-ts/Util.js";
import { defaultArg, value as value_1, Option } from "../../deps/Fable/src/fable-library-ts/Option.js";
import { op_Subtraction, op_Addition, toInt64, int64 } from "../../deps/Fable/src/fable-library-ts/BigInt.js";
import { FSharpRef, Record, Union } from "../../deps/Fable/src/fable-library-ts/Types.js";
import { int32_type, class_type, bool_type, lambda_type, unit_type, string_type, record_type, int64_type, union_type, TypeInfo } from "../../deps/Fable/src/fable-library-ts/Reflection.js";
import { int32 } from "../../deps/Fable/src/fable-library-ts/Int32.js";
import { create, toString, now, getTicks } from "../../deps/Fable/src/fable-library-ts/Date.js";
import { ofSeq, find } from "../../deps/Fable/src/fable-library-ts/Map.js";
import { milliseconds, seconds, minutes, hours, fromTicks } from "../../deps/Fable/src/fable-library-ts/TimeSpan.js";
import { split, interpolate, toText, trimStart, trimEnd, padLeft } from "../../deps/Fable/src/fable-library-ts/String.js";
import { item } from "../../deps/Fable/src/fable-library-ts/Array.js";

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

export function closure13(v0_1: string, unitVar: void): void {
    console.log(v0_1);
}

export function closure12(unitVar: void, v0_1: string): void {
    let v3: any;
    closure13(v0_1, undefined);
    v3 = undefined;
}

export function closure6(v0_1: int32, v1_1: string, unitVar: void): void {
    let v304: int64, v314: number;
    const v3 = (): void => {
        closure0(undefined, undefined);
    };
    let v4: any;
    v3();
    v4 = undefined;
    const patternInput: [Mut0, Mut1, Mut2, Mut3, Option<int64>] = value_1(State_trace_state());
    let v33: any;
    v3();
    v33 = undefined;
    const patternInput_1: [Mut0, Mut1, Mut2, Mut3, Option<int64>] = value_1(State_trace_state());
    const v61: US0_$union = patternInput_1[3].l0;
    if ((patternInput_1[2].l0 === false) ? false : (0 >= find<US0_$union, int32>(v61, ofSeq([[US0_US0_0(), 0] as [US0_$union, int32], [US0_US0_1(), 1] as [US0_$union, int32], [US0_US0_2(), 2] as [US0_$union, int32], [US0_US0_3(), 3] as [US0_$union, int32], [US0_US0_4(), 4] as [US0_$union, int32]], {
        Compare: compare,
    })))) {
        let v69: any;
        closure7(patternInput[0], undefined);
        v69 = undefined;
        let v73: any;
        v3();
        v73 = undefined;
        const patternInput_2: [Mut0, Mut1, Mut2, Mut3, Option<int64>] = value_1(State_trace_state());
        const _v280: FSharpRef<Option<US3_$union>> = new FSharpRef<Option<US3_$union>>(undefined);
        let v285: any;
        closure9(patternInput_2[4], (v: Option<US3_$union>): FSharpRef<Option<US3_$union>> => closure8(_v280, v), undefined);
        v285 = undefined;
        const v300: US3_$union = defaultArg(_v280.contents, US3_US3_1());
        const v345: string = toString((v300.tag === /* US3_0 */ 0) ? ((v304 = v300.fields[0], (v314 = fromTicks(toInt64(op_Subtraction(getTicks(now()), v304))), create(1, 1, 1, hours(v314), minutes(v314), seconds(v314), milliseconds(v314))))) : now(), method6());
        const v610: string = ("\u001b[90m" + padLeft("Verbose".toLocaleLowerCase(), 7, " ")) + method7();
        const v625: int64 = patternInput_2[0].l0;
        const v627: Mut4 = new Mut4(method8());
        let v634: any;
        closure10(v627, `${"{ "}`, undefined);
        v634 = undefined;
        let v643: any;
        closure10(v627, `${"port"}`, undefined);
        v643 = undefined;
        let v652: any;
        closure10(v627, `${" = "}`, undefined);
        v652 = undefined;
        let v660: any;
        closure10(v627, `${v0_1}`, undefined);
        v660 = undefined;
        let v669: any;
        closure10(v627, `${"; "}`, undefined);
        v669 = undefined;
        let v678: any;
        closure10(v627, `${"ex"}`, undefined);
        v678 = undefined;
        let v686: any;
        closure10(v627, `${" = "}`, undefined);
        v686 = undefined;
        let v694: any;
        closure10(v627, `${v1_1}`, undefined);
        v694 = undefined;
        let v703: any;
        closure10(v627, `${" }"}`, undefined);
        v703 = undefined;
        const v706: string = v627.l0;
        const v745: string = trimEnd(trimStart(`${v345} ${v610} #${v625} ${closure11(undefined, undefined)} / ${v706}`, ...[]), ...[" ", "/"]);
        closure12(undefined, v745);
        patternInput[1].l0(v745);
    }
}

export function closure5(v0_1: string, v1_1: int32): any {
    return defaultOf();
}

export function closure4(unitVar: void, v0_1: string): ((arg0: int32) => any) {
    return (v: int32): any => closure5(v0_1, v);
}

export function closure17(unitVar: void, v0_1: boolean): US5_$union {
    return US5_US5_0(v0_1);
}

export function closure18(unitVar: void, v0_1: Error): US5_$union {
    return US5_US5_1(v0_1);
}

export function closure20(unitVar: void, unitVar_1: void): string {
    return "async.run_with_timeout_async";
}

export function closure19(v0_1: int32, unitVar: void): void {
    let v303: int64, v313: number;
    const v2_1 = (): void => {
        closure0(undefined, undefined);
    };
    let v3: any;
    v2_1();
    v3 = undefined;
    const patternInput: [Mut0, Mut1, Mut2, Mut3, Option<int64>] = value_1(State_trace_state());
    let v32: any;
    v2_1();
    v32 = undefined;
    const patternInput_1: [Mut0, Mut1, Mut2, Mut3, Option<int64>] = value_1(State_trace_state());
    const v60: US0_$union = patternInput_1[3].l0;
    if ((patternInput_1[2].l0 === false) ? false : (0 >= find<US0_$union, int32>(v60, ofSeq([[US0_US0_0(), 0] as [US0_$union, int32], [US0_US0_1(), 1] as [US0_$union, int32], [US0_US0_2(), 2] as [US0_$union, int32], [US0_US0_3(), 3] as [US0_$union, int32], [US0_US0_4(), 4] as [US0_$union, int32]], {
        Compare: compare,
    })))) {
        let v68: any;
        closure7(patternInput[0], undefined);
        v68 = undefined;
        let v72: any;
        v2_1();
        v72 = undefined;
        const patternInput_2: [Mut0, Mut1, Mut2, Mut3, Option<int64>] = value_1(State_trace_state());
        const _v279: FSharpRef<Option<US3_$union>> = new FSharpRef<Option<US3_$union>>(undefined);
        let v284: any;
        closure9(patternInput_2[4], (v: Option<US3_$union>): FSharpRef<Option<US3_$union>> => closure8(_v279, v), undefined);
        v284 = undefined;
        const v299: US3_$union = defaultArg(_v279.contents, US3_US3_1());
        const v344: string = toString((v299.tag === /* US3_0 */ 0) ? ((v303 = v299.fields[0], (v313 = fromTicks(toInt64(op_Subtraction(getTicks(now()), v303))), create(1, 1, 1, hours(v313), minutes(v313), seconds(v313), milliseconds(v313))))) : now(), method6());
        const v609: string = ("\u001b[90m" + padLeft("Verbose".toLocaleLowerCase(), 7, " ")) + method7();
        const v624: int64 = patternInput_2[0].l0;
        const v626: Mut4 = new Mut4(method8());
        let v633: any;
        closure10(v626, `${"{ "}`, undefined);
        v633 = undefined;
        let v642: any;
        closure10(v626, `${"timeout"}`, undefined);
        v642 = undefined;
        let v651: any;
        closure10(v626, `${" = "}`, undefined);
        v651 = undefined;
        let v659: any;
        closure10(v626, `${v0_1}`, undefined);
        v659 = undefined;
        let v668: any;
        closure10(v626, `${" }"}`, undefined);
        v668 = undefined;
        const v671: string = v626.l0;
        const v710: string = trimEnd(trimStart(`${v344} ${v609} #${v624} ${closure20(undefined, undefined)} / ${v671}`, ...[]), ...[" ", "/"]);
        closure12(undefined, v710);
        patternInput[1].l0(v710);
    }
}

export function method9(): string {
    return "(";
}

export function method10(): string {
    return " ";
}

export function closure22(unitVar: void, unitVar_1: void): string {
    return "async.run_with_timeout_async**";
}

export function closure21(v0_1: int32, v1_1: Error, unitVar: void): void {
    let v304: int64, v314: number;
    const v3 = (): void => {
        closure0(undefined, undefined);
    };
    let v4: any;
    v3();
    v4 = undefined;
    const patternInput: [Mut0, Mut1, Mut2, Mut3, Option<int64>] = value_1(State_trace_state());
    let v33: any;
    v3();
    v33 = undefined;
    const patternInput_1: [Mut0, Mut1, Mut2, Mut3, Option<int64>] = value_1(State_trace_state());
    const v61: US0_$union = patternInput_1[3].l0;
    if ((patternInput_1[2].l0 === false) ? false : (4 >= find<US0_$union, int32>(v61, ofSeq([[US0_US0_0(), 0] as [US0_$union, int32], [US0_US0_1(), 1] as [US0_$union, int32], [US0_US0_2(), 2] as [US0_$union, int32], [US0_US0_3(), 3] as [US0_$union, int32], [US0_US0_4(), 4] as [US0_$union, int32]], {
        Compare: compare,
    })))) {
        let v69: any;
        closure7(patternInput[0], undefined);
        v69 = undefined;
        let v73: any;
        v3();
        v73 = undefined;
        const patternInput_2: [Mut0, Mut1, Mut2, Mut3, Option<int64>] = value_1(State_trace_state());
        const _v280: FSharpRef<Option<US3_$union>> = new FSharpRef<Option<US3_$union>>(undefined);
        let v285: any;
        closure9(patternInput_2[4], (v: Option<US3_$union>): FSharpRef<Option<US3_$union>> => closure8(_v280, v), undefined);
        v285 = undefined;
        const v300: US3_$union = defaultArg(_v280.contents, US3_US3_1());
        const v345: string = toString((v300.tag === /* US3_0 */ 0) ? ((v304 = v300.fields[0], (v314 = fromTicks(toInt64(op_Subtraction(getTicks(now()), v304))), create(1, 1, 1, hours(v314), minutes(v314), seconds(v314), milliseconds(v314))))) : now(), method6());
        const v558: string = method10();
        const v567: Mut4 = new Mut4(method8());
        let v578: any;
        closure10(v567, `${toText(interpolate("%A%P()", [US0_US0_0()]))}`, undefined);
        v578 = undefined;
        const v585: string = item(0, split(v567.l0, [v558], undefined, 0));
        const v589: Mut4 = new Mut4(method8());
        let v600: any;
        closure10(v589, `${toText(interpolate("%A%P()", [US0_US0_4()]))}`, undefined);
        v600 = undefined;
        const v603: string = v589.l0;
        const v610: US1_$union = (v603.indexOf(v585) === 0) ? US1_US1_0("Verbose") : US1_US1_1();
        let v799: US1_$union;
        if (v610.tag === /* US1_0 */ 0) {
            v799 = US1_US1_0(v610.fields[0]);
        }
        else {
            const v617: string = method10();
            const v626: Mut4 = new Mut4(method8());
            let v637: any;
            closure10(v626, `${toText(interpolate("%A%P()", [US0_US0_1()]))}`, undefined);
            v637 = undefined;
            const v644: string = item(0, split(v626.l0, [v617], undefined, 0));
            const v648: Mut4 = new Mut4(method8());
            let v659: any;
            closure10(v648, `${toText(interpolate("%A%P()", [US0_US0_4()]))}`, undefined);
            v659 = undefined;
            const v662: string = v648.l0;
            const v669: US1_$union = (v662.indexOf(v644) === 0) ? US1_US1_0("Debug") : US1_US1_1();
            if (v669.tag === /* US1_0 */ 0) {
                v799 = US1_US1_0(v669.fields[0]);
            }
            else {
                const v676: string = method10();
                const v685: Mut4 = new Mut4(method8());
                let v696: any;
                closure10(v685, `${toText(interpolate("%A%P()", [US0_US0_2()]))}`, undefined);
                v696 = undefined;
                const v703: string = item(0, split(v685.l0, [v676], undefined, 0));
                const v707: Mut4 = new Mut4(method8());
                let v718: any;
                closure10(v707, `${toText(interpolate("%A%P()", [US0_US0_4()]))}`, undefined);
                v718 = undefined;
                const v721: string = v707.l0;
                const v728: US1_$union = (v721.indexOf(v703) === 0) ? US1_US1_0("Info") : US1_US1_1();
                if (v728.tag === /* US1_0 */ 0) {
                    v799 = US1_US1_0(v728.fields[0]);
                }
                else {
                    const v735: string = method10();
                    const v744: Mut4 = new Mut4(method8());
                    let v755: any;
                    closure10(v744, `${toText(interpolate("%A%P()", [US0_US0_3()]))}`, undefined);
                    v755 = undefined;
                    const v762: string = item(0, split(v744.l0, [v735], undefined, 0));
                    const v766: Mut4 = new Mut4(method8());
                    let v777: any;
                    closure10(v766, `${toText(interpolate("%A%P()", [US0_US0_4()]))}`, undefined);
                    v777 = undefined;
                    const v780: string = v766.l0;
                    const v787: US1_$union = (v780.indexOf(v762) === 0) ? US1_US1_0("Warning") : US1_US1_1();
                    v799 = ((v787.tag === /* US1_0 */ 0) ? US1_US1_0(v787.fields[0]) : US1_US1_0("Critical"));
                }
            }
        }
        let v803: string;
        if (v799.tag === /* US1_0 */ 0) {
            v803 = v799.fields[0];
        }
        else {
            throw new Error("Option does not have a value.");
        }
        const v859: string = ("\u001b[91m" + padLeft(v803.toLocaleLowerCase(), 7, " ")) + method7();
        const v874: int64 = patternInput_2[0].l0;
        const v885: string = toText(interpolate("%A%P()", [v1_1]));
        const v898: Mut4 = new Mut4(method8());
        let v905: any;
        closure10(v898, `${"{ "}`, undefined);
        v905 = undefined;
        let v914: any;
        closure10(v898, `${"timeout"}`, undefined);
        v914 = undefined;
        let v923: any;
        closure10(v898, `${" = "}`, undefined);
        v923 = undefined;
        let v931: any;
        closure10(v898, `${v0_1}`, undefined);
        v931 = undefined;
        let v940: any;
        closure10(v898, `${"; "}`, undefined);
        v940 = undefined;
        let v949: any;
        closure10(v898, `${"ex"}`, undefined);
        v949 = undefined;
        let v957: any;
        closure10(v898, `${" = "}`, undefined);
        v957 = undefined;
        let v965: any;
        closure10(v898, `${v885}`, undefined);
        v965 = undefined;
        let v974: any;
        closure10(v898, `${" }"}`, undefined);
        v974 = undefined;
        const v977: string = v898.l0;
        const v1016: string = trimEnd(trimStart(`${v345} ${v859} #${v874} ${closure22(undefined, undefined)} / ${v977}`, ...[]), ...[" ", "/"]);
        closure12(undefined, v1016);
        patternInput[1].l0(v1016);
    }
}

export function closure16(v0_1: int32, v1_1: string, v2_1: int32): any {
    return defaultOf();
}

export function closure15(v0_1: int32, v1_1: string): ((arg0: int32) => any) {
    return (v: int32): any => closure16(v0_1, v1_1, v);
}

export function closure14(unitVar: void, v0_1: int32): ((arg0: string) => ((arg0: int32) => any)) {
    return (v: string): ((arg0: int32) => any) => closure15(v0_1, v);
}

export function closure27(v0_1: FSharpRef<Option<US7_$union>>, v1_1: Option<US7_$union>): FSharpRef<Option<US7_$union>> {
    v0_1.contents = v1_1;
    return v0_1;
}

export function closure28(v0_1: Option<int32>, v1_1: ((arg0: Option<US7_$union>) => FSharpRef<Option<US7_$union>>), unitVar: void): void {
    let x: int32;
    v1_1((v0_1 == null) ? undefined : ((x = (value_1(v0_1) | 0), ((): US7_$union => US7_US7_0(x))())));
}

export function closure30(unitVar: void, unitVar_1: void): string {
    return "networking.wait_for_port_access";
}

export function closure29(v0_1: Option<int32>, v1_1: boolean, v2_1: int32, v3: int64, unitVar: void): void {
    let v306: int64, v316: number;
    const v5 = (): void => {
        closure0(undefined, undefined);
    };
    let v6: any;
    v5();
    v6 = undefined;
    const patternInput: [Mut0, Mut1, Mut2, Mut3, Option<int64>] = value_1(State_trace_state());
    let v35: any;
    v5();
    v35 = undefined;
    const patternInput_1: [Mut0, Mut1, Mut2, Mut3, Option<int64>] = value_1(State_trace_state());
    const v63: US0_$union = patternInput_1[3].l0;
    if ((patternInput_1[2].l0 === false) ? false : (0 >= find<US0_$union, int32>(v63, ofSeq([[US0_US0_0(), 0] as [US0_$union, int32], [US0_US0_1(), 1] as [US0_$union, int32], [US0_US0_2(), 2] as [US0_$union, int32], [US0_US0_3(), 3] as [US0_$union, int32], [US0_US0_4(), 4] as [US0_$union, int32]], {
        Compare: compare,
    })))) {
        let v71: any;
        closure7(patternInput[0], undefined);
        v71 = undefined;
        let v75: any;
        v5();
        v75 = undefined;
        const patternInput_2: [Mut0, Mut1, Mut2, Mut3, Option<int64>] = value_1(State_trace_state());
        const _v282: FSharpRef<Option<US3_$union>> = new FSharpRef<Option<US3_$union>>(undefined);
        let v287: any;
        closure9(patternInput_2[4], (v: Option<US3_$union>): FSharpRef<Option<US3_$union>> => closure8(_v282, v), undefined);
        v287 = undefined;
        const v302: US3_$union = defaultArg(_v282.contents, US3_US3_1());
        const v347: string = toString((v302.tag === /* US3_0 */ 0) ? ((v306 = v302.fields[0], (v316 = fromTicks(toInt64(op_Subtraction(getTicks(now()), v306))), create(1, 1, 1, hours(v316), minutes(v316), seconds(v316), milliseconds(v316))))) : now(), method6());
        const v612: string = ("\u001b[90m" + padLeft("Verbose".toLocaleLowerCase(), 7, " ")) + method7();
        const v627: int64 = patternInput_2[0].l0;
        const v629: Mut4 = new Mut4(method8());
        let v636: any;
        closure10(v629, `${"{ "}`, undefined);
        v636 = undefined;
        let v645: any;
        closure10(v629, `${"port"}`, undefined);
        v645 = undefined;
        let v654: any;
        closure10(v629, `${" = "}`, undefined);
        v654 = undefined;
        let v662: any;
        closure10(v629, `${v2_1}`, undefined);
        v662 = undefined;
        let v671: any;
        closure10(v629, `${"; "}`, undefined);
        v671 = undefined;
        let v680: any;
        closure10(v629, `${"retry"}`, undefined);
        v680 = undefined;
        let v688: any;
        closure10(v629, `${" = "}`, undefined);
        v688 = undefined;
        let v696: any;
        closure10(v629, `${v3}`, undefined);
        v696 = undefined;
        let v704: any;
        closure10(v629, `${"; "}`, undefined);
        v704 = undefined;
        let v713: any;
        closure10(v629, `${"timeout"}`, undefined);
        v713 = undefined;
        let v721: any;
        closure10(v629, `${" = "}`, undefined);
        v721 = undefined;
        let v756: any;
        closure10(v629, `${toText(interpolate("%A%P()", [v0_1]))}`, undefined);
        v756 = undefined;
        let v764: any;
        closure10(v629, `${"; "}`, undefined);
        v764 = undefined;
        let v773: any;
        closure10(v629, `${"status"}`, undefined);
        v773 = undefined;
        let v781: any;
        closure10(v629, `${" = "}`, undefined);
        v781 = undefined;
        let v792: any;
        closure10(v629, `${v1_1 ? "true" : "false"}`, undefined);
        v792 = undefined;
        let v801: any;
        closure10(v629, `${" }"}`, undefined);
        v801 = undefined;
        const v804: string = v629.l0;
        const v843: string = trimEnd(trimStart(`${v347} ${v612} #${v627} ${closure30(undefined, undefined)} / ${v804}`, ...[]), ...[" ", "/"]);
        closure12(undefined, v843);
        patternInput[1].l0(v843);
    }
}

export function method11(v0_1: Option<int32>, v1_1: boolean, v2_1: string, v3: int32, v4: int64): any {
    return defaultOf();
}

export function closure26(v0_1: Option<int32>, v1_1: boolean, v2_1: string, v3: int32): any {
    return method11(v0_1, v1_1, v2_1, v3, 0n);
}

export function closure25(v0_1: Option<int32>, v1_1: boolean, v2_1: string): ((arg0: int32) => any) {
    return (v: int32): any => closure26(v0_1, v1_1, v2_1, v);
}

export function closure24(v0_1: Option<int32>, v1_1: boolean): ((arg0: string) => ((arg0: int32) => any)) {
    return (v: string): ((arg0: int32) => any) => closure25(v0_1, v1_1, v);
}

export function closure23(unitVar: void, v0_1: Option<int32>): ((arg0: boolean) => ((arg0: string) => ((arg0: int32) => any))) {
    return (v: boolean): ((arg0: string) => ((arg0: int32) => any)) => closure24(v0_1, v);
}

export function method12(v0_1: Option<int32>, v1_1: string, v2_1: int32): any {
    return defaultOf();
}

export function closure33(v0_1: Option<int32>, v1_1: string, v2_1: int32): any {
    return method12(v0_1, v1_1, v2_1);
}

export function closure32(v0_1: Option<int32>, v1_1: string): ((arg0: int32) => any) {
    return (v: int32): any => closure33(v0_1, v1_1, v);
}

export function closure31(unitVar: void, v0_1: Option<int32>): ((arg0: string) => ((arg0: int32) => any)) {
    return (v: string): ((arg0: int32) => any) => closure32(v0_1, v);
}

export const v0: any = undefined;

export const v1 = (): void => {
    closure0(undefined, undefined);
};

export const v2: any = (v1(), v0);

export const v15 = (v: string): ((arg0: int32) => any) => closure4(undefined, v);

export function test_port_open(x: string): ((arg0: int32) => any) {
    return v15(x);
}

export const v16 = (v: int32): ((arg0: string) => ((arg0: int32) => any)) => closure14(undefined, v);

export function test_port_open_timeout(x: int32): ((arg0: string) => ((arg0: int32) => any)) {
    return v16(x);
}

export const v17 = (v: Option<int32>): ((arg0: boolean) => ((arg0: string) => ((arg0: int32) => any))) => closure23(undefined, v);

export function wait_for_port_access(x: Option<int32>): ((arg0: boolean) => ((arg0: string) => ((arg0: int32) => any))) {
    return v17(x);
}

export const v18 = (v: Option<int32>): ((arg0: string) => ((arg0: int32) => any)) => closure31(undefined, v);

export function get_available_port(x: Option<int32>): ((arg0: string) => ((arg0: int32) => any)) {
    return v18(x);
}


