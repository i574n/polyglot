import { defaultOf, compare, IComparable, IEquatable, createAtom } from "../../deps/Fable/src/fable-library-ts/Util.js";
import { some, defaultArg, value as value_1, Option } from "../../deps/Fable/src/fable-library-ts/Option.js";
import { op_Addition, op_Subtraction, toInt64, int64 } from "../../deps/Fable/src/fable-library-ts/BigInt.js";
import { FSharpRef, Record, Union } from "../../deps/Fable/src/fable-library-ts/Types.js";
import { int32_type, class_type, bool_type, lambda_type, unit_type, string_type, record_type, int64_type, union_type, TypeInfo } from "../../deps/Fable/src/fable-library-ts/Reflection.js";
import { int32 } from "../../deps/Fable/src/fable-library-ts/Int32.js";
import { create, toString, now, getTicks } from "../../deps/Fable/src/fable-library-ts/Date.js";
import { milliseconds, seconds, minutes, hours, fromTicks } from "../../deps/Fable/src/fable-library-ts/TimeSpan.js";
import { interpolate, toText, trimStart, trimEnd, padLeft } from "../../deps/Fable/src/fable-library-ts/String.js";
import { ofSeq, find } from "../../deps/Fable/src/fable-library-ts/Map.js";

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
    return union_type("Networking.US1", [], US1, () => [[["f0_0", US0_$reflection()]], []]);
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
    return union_type("Networking.US3", [], US3, () => [[["f0_0", string_type]], []]);
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
        return value_1(_v3);
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
        patternInput = value_1(_v3);
    }
    const v325: US2_$union = patternInput[1];
    const v324: US1_$union = patternInput[0];
    return [new Mut0(0n), new Mut1((v: string): void => {
        closure1(undefined, v);
    }), new Mut2(true), new Mut3((v324.tag === /* US1_0 */ 0) ? v324.fields[0] : v0), (v325.tag === /* US2_0 */ 0) ? v325.fields[0] : undefined] as [Mut0, Mut1, Mut2, Mut3, Option<int64>];
}

export function closure4(unitVar: void, unitVar_1: void): string {
    return "networking.test_port_open";
}

export function closure5(v0: int32, v1: string, unitVar: void): [int32, string] {
    return [v0, v1] as [int32, string];
}

export function method5(): string {
    return "hh:mm:ss";
}

export function method6(): string {
    return "";
}

export function method7(): string {
    return "HH:mm:ss";
}

export function method8(): string {
    return "\u001b[0m";
}

export function method10(v0: Mut4, v1: string): void {
    const v4 = `${v1}`;
    const v12: string = v0.l0 + v4;
    v0.l0 = v12;
}

export function method11(v0: Mut4): void {
}

export function method12(v0: Mut4, v1: int32): void {
    const v4 = `${v1}`;
    const v12: string = v0.l0 + v4;
    v0.l0 = v12;
}

export function method9(v0: Mut4, v1: int32, v2: string): void {
    method10(v0, "{ ");
    method11(v0);
    method10(v0, "port");
    method10(v0, " = ");
    method12(v0, v1);
    method10(v0, "; ");
    method10(v0, "ex");
    method10(v0, " = ");
    method10(v0, v2);
    method10(v0, " }");
}

export function closure6(v0: US0_$union, v1: (() => string), v2: (() => [int32, string]), unitVar: void): string {
    let v368: int64, v392: number;
    if (State_trace_state() == null) {
        State_trace_state(closure0(undefined, US0_US0_0()));
    }
    const patternInput: [Mut0, Mut1, Mut2, Mut3, Option<int64>] = value_1(State_trace_state());
    const v18: Option<int64> = patternInput[4];
    let _v35: Option<string> = undefined;
    const _v333: FSharpRef<Option<US2_$union>> = new FSharpRef<Option<US2_$union>>(undefined);
    let x_2: Option<US2_$union>;
    if (v18 == null) {
        x_2 = undefined;
    }
    else {
        const x: int64 = value_1(v18);
        x_2 = ((): US2_$union => US2_US2_0(x))();
    }
    _v333.contents = x_2;
    const v360: US2_$union = defaultArg(_v333.contents, US2_US2_1());
    const x_3: string = toString((v360.tag === /* US2_0 */ 0) ? ((v368 = v360.fields[0], (v392 = fromTicks(toInt64(op_Subtraction(getTicks(now()), v368))), create(1, 1, 1, hours(v392), minutes(v392), seconds(v392), milliseconds(v392))))) : now(), method7());
    _v35 = x_3;
    let v772: string;
    if (_v35 == null) {
        throw new Error("base.run_target / _v35=None");
    }
    else {
        v772 = value_1(_v35);
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
    const x_5: string = (((v0.tag === /* US0_1 */ 1) ? "\u001b[94m" : ((v0.tag === /* US0_2 */ 2) ? "\u001b[92m" : ((v0.tag === /* US0_0 */ 0) ? "\u001b[90m" : ((v0.tag === /* US0_3 */ 3) ? "\u001b[93m" : "\u001b[91m")))) + v997) + method8();
    _v1029 = x_5;
    let v1141: string;
    if (_v1029 == null) {
        throw new Error("base.run_target / _v1029=None");
    }
    else {
        v1141 = value_1(_v1029);
    }
    const v1160: int64 = patternInput[0].l0;
    const patternInput_1: [int32, string] = v2();
    const v1164: Mut4 = new Mut4("");
    method9(v1164, patternInput_1[0], patternInput_1[1]);
    const v1165: string = v1164.l0;
    return trimEnd(trimStart(`${v772} ${v1141} #${v1160} ${v1()} / ${v1165}`, ...[]), ...[" ", "/"]);
}

export function method13(v0: US0_$union, v1: (() => string)): void {
    const v4 = (v: US0_$union): [Mut0, Mut1, Mut2, Mut3, Option<int64>] => closure0(undefined, v);
    if (State_trace_state() == null) {
        State_trace_state(v4(US0_US0_0()));
    }
    const patternInput: [Mut0, Mut1, Mut2, Mut3, Option<int64>] = value_1(State_trace_state());
    const v13: Mut0 = patternInput[0];
    if (State_trace_state() == null) {
        State_trace_state(v4(US0_US0_0()));
    }
    const patternInput_1: [Mut0, Mut1, Mut2, Mut3, Option<int64>] = value_1(State_trace_state());
    const v61: US0_$union = patternInput_1[3].l0;
    if ((patternInput_1[2].l0 === false) ? false : (find<US0_$union, int32>(v0, ofSeq([[US0_US0_0(), 0] as [US0_$union, int32], [US0_US0_1(), 1] as [US0_$union, int32], [US0_US0_2(), 2] as [US0_$union, int32], [US0_US0_3(), 3] as [US0_$union, int32], [US0_US0_4(), 4] as [US0_$union, int32]], {
        Compare: compare,
    })) >= find<US0_$union, int32>(v61, ofSeq([[US0_US0_0(), 0] as [US0_$union, int32], [US0_US0_1(), 1] as [US0_$union, int32], [US0_US0_2(), 2] as [US0_$union, int32], [US0_US0_3(), 3] as [US0_$union, int32], [US0_US0_4(), 4] as [US0_$union, int32]], {
        Compare: compare,
    })))) {
        const v69: int64 = toInt64(op_Addition(v13.l0, 1n));
        v13.l0 = v69;
        const v72 = `${v1()}`;
        let _v81: Option<void> = undefined;
        console.log(v72);
        _v81 = some(undefined);
        if (_v81 == null) {
            throw new Error("base.run_target / _v81=None");
        }
        else {
            value_1(_v81);
        }
        patternInput[1].l0(v72);
    }
}

export function method4(v0: US0_$union, v1: (() => string), v2: (() => [int32, string])): void {
    method13(v0, (): string => closure6(v0, v1, v2, undefined));
}

export function closure3(v0: string, v1: int32): any {
    let _v4: Option<any> = undefined;
    const x: any = defaultOf();
    _v4 = x;
    if (_v4 == null) {
        throw new Error("base.run_target / _v4=None");
    }
    else {
        return value_1(_v4);
    }
}

export function closure2(unitVar: void, v0: string): ((arg0: int32) => any) {
    return (v: int32): any => closure3(v0, v);
}

export function closure10(unitVar: void, v0: boolean): US5_$union {
    return US5_US5_0(v0);
}

export function closure11(unitVar: void, v0: Error): US5_$union {
    return US5_US5_1(v0);
}

export function closure12(unitVar: void, unitVar_1: void): string {
    return "async.run_with_timeout_async";
}

export function closure13(v0: int32, unitVar: void): int32 {
    return v0;
}

export function method15(v0: Mut4, v1: int32): void {
    method10(v0, "{ ");
    method11(v0);
    method10(v0, "timeout");
    method10(v0, " = ");
    method12(v0, v1);
    method10(v0, " }");
}

export function closure14(v0: US0_$union, v1: (() => string), v2: (() => int32), unitVar: void): string {
    let v368: int64, v392: number;
    if (State_trace_state() == null) {
        State_trace_state(closure0(undefined, US0_US0_0()));
    }
    const patternInput: [Mut0, Mut1, Mut2, Mut3, Option<int64>] = value_1(State_trace_state());
    const v18: Option<int64> = patternInput[4];
    let _v35: Option<string> = undefined;
    const _v333: FSharpRef<Option<US2_$union>> = new FSharpRef<Option<US2_$union>>(undefined);
    let x_2: Option<US2_$union>;
    if (v18 == null) {
        x_2 = undefined;
    }
    else {
        const x: int64 = value_1(v18);
        x_2 = ((): US2_$union => US2_US2_0(x))();
    }
    _v333.contents = x_2;
    const v360: US2_$union = defaultArg(_v333.contents, US2_US2_1());
    const x_3: string = toString((v360.tag === /* US2_0 */ 0) ? ((v368 = v360.fields[0], (v392 = fromTicks(toInt64(op_Subtraction(getTicks(now()), v368))), create(1, 1, 1, hours(v392), minutes(v392), seconds(v392), milliseconds(v392))))) : now(), method7());
    _v35 = x_3;
    let v772: string;
    if (_v35 == null) {
        throw new Error("base.run_target / _v35=None");
    }
    else {
        v772 = value_1(_v35);
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
    const x_5: string = (((v0.tag === /* US0_1 */ 1) ? "\u001b[94m" : ((v0.tag === /* US0_2 */ 2) ? "\u001b[92m" : ((v0.tag === /* US0_0 */ 0) ? "\u001b[90m" : ((v0.tag === /* US0_3 */ 3) ? "\u001b[93m" : "\u001b[91m")))) + v997) + method8();
    _v1029 = x_5;
    let v1141: string;
    if (_v1029 == null) {
        throw new Error("base.run_target / _v1029=None");
    }
    else {
        v1141 = value_1(_v1029);
    }
    const v1160: int64 = patternInput[0].l0;
    const v1163: Mut4 = new Mut4("");
    method15(v1163, v2());
    const v1164: string = v1163.l0;
    return trimEnd(trimStart(`${v772} ${v1141} #${v1160} ${v1()} / ${v1164}`, ...[]), ...[" ", "/"]);
}

export function method14(v0: US0_$union, v1: (() => string), v2: (() => int32)): void {
    method13(v0, (): string => closure14(v0, v1, v2, undefined));
}

export function closure15(unitVar: void, unitVar_1: void): string {
    return "async.run_with_timeout_async**";
}

export function closure16(v0: int32, v1: Error, unitVar: void): [int32, string] {
    let _v4: Option<string> = undefined;
    const x: string = toText(interpolate("%A%P()", [v1]));
    _v4 = x;
    return [v0, (_v4 == null) ? (() => {
        throw new Error("base.run_target / _v4=None");
    })() : value_1(_v4)] as [int32, string];
}

export function method17(v0: Mut4, v1: int32, v2: string): void {
    method10(v0, "{ ");
    method11(v0);
    method10(v0, "timeout");
    method10(v0, " = ");
    method12(v0, v1);
    method10(v0, "; ");
    method10(v0, "ex");
    method10(v0, " = ");
    method10(v0, v2);
    method10(v0, " }");
}

export function closure17(v0: US0_$union, v1: (() => string), v2: (() => [int32, string]), unitVar: void): string {
    let v368: int64, v392: number;
    if (State_trace_state() == null) {
        State_trace_state(closure0(undefined, US0_US0_0()));
    }
    const patternInput: [Mut0, Mut1, Mut2, Mut3, Option<int64>] = value_1(State_trace_state());
    const v18: Option<int64> = patternInput[4];
    let _v35: Option<string> = undefined;
    const _v333: FSharpRef<Option<US2_$union>> = new FSharpRef<Option<US2_$union>>(undefined);
    let x_2: Option<US2_$union>;
    if (v18 == null) {
        x_2 = undefined;
    }
    else {
        const x: int64 = value_1(v18);
        x_2 = ((): US2_$union => US2_US2_0(x))();
    }
    _v333.contents = x_2;
    const v360: US2_$union = defaultArg(_v333.contents, US2_US2_1());
    const x_3: string = toString((v360.tag === /* US2_0 */ 0) ? ((v368 = v360.fields[0], (v392 = fromTicks(toInt64(op_Subtraction(getTicks(now()), v368))), create(1, 1, 1, hours(v392), minutes(v392), seconds(v392), milliseconds(v392))))) : now(), method7());
    _v35 = x_3;
    let v772: string;
    if (_v35 == null) {
        throw new Error("base.run_target / _v35=None");
    }
    else {
        v772 = value_1(_v35);
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
    const x_5: string = (((v0.tag === /* US0_1 */ 1) ? "\u001b[94m" : ((v0.tag === /* US0_2 */ 2) ? "\u001b[92m" : ((v0.tag === /* US0_0 */ 0) ? "\u001b[90m" : ((v0.tag === /* US0_3 */ 3) ? "\u001b[93m" : "\u001b[91m")))) + v997) + method8();
    _v1029 = x_5;
    let v1141: string;
    if (_v1029 == null) {
        throw new Error("base.run_target / _v1029=None");
    }
    else {
        v1141 = value_1(_v1029);
    }
    const v1160: int64 = patternInput[0].l0;
    const patternInput_1: [int32, string] = v2();
    const v1164: Mut4 = new Mut4("");
    method17(v1164, patternInput_1[0], patternInput_1[1]);
    const v1165: string = v1164.l0;
    return trimEnd(trimStart(`${v772} ${v1141} #${v1160} ${v1()} / ${v1165}`, ...[]), ...[" ", "/"]);
}

export function method16(v0: US0_$union, v1: (() => string), v2: (() => [int32, string])): void {
    method13(v0, (): string => closure17(v0, v1, v2, undefined));
}

export function closure9(v0: int32, v1: string, v2: int32): any {
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

export function closure8(v0: int32, v1: string): ((arg0: int32) => any) {
    return (v: int32): any => closure9(v0, v1, v);
}

export function closure7(unitVar: void, v0: int32): ((arg0: string) => ((arg0: int32) => any)) {
    return (v: string): ((arg0: int32) => any) => closure8(v0, v);
}

export function closure22(unitVar: void, unitVar_1: void): string {
    return "networking.wait_for_port_access";
}

export function closure23(v0: Option<int32>, v1: boolean, v2: int32, v3: int64, unitVar: void): [int32, int64, Option<int32>, boolean] {
    return [v2, v3, v0, v1] as [int32, int64, Option<int32>, boolean];
}

export function method21(v0: Mut4, v1: int64): void {
    const v4 = `${v1}`;
    const v12: string = v0.l0 + v4;
    v0.l0 = v12;
}

export function method22(v0: Mut4, v1: Option<int32>): void {
    method10(v0, toText(interpolate("%A%P()", [v1])));
}

export function method23(v0: Mut4, v1: boolean): void {
    const v7 = `${v1 ? "true" : "false"}`;
    const v15: string = v0.l0 + v7;
    v0.l0 = v15;
}

export function method20(v0: Mut4, v1: int32, v2: int64, v3: Option<int32>, v4: boolean): void {
    method10(v0, "{ ");
    method11(v0);
    method10(v0, "port");
    method10(v0, " = ");
    method12(v0, v1);
    method10(v0, "; ");
    method10(v0, "retry");
    method10(v0, " = ");
    method21(v0, v2);
    method10(v0, "; ");
    method10(v0, "timeout");
    method10(v0, " = ");
    method22(v0, v3);
    method10(v0, "; ");
    method10(v0, "status");
    method10(v0, " = ");
    method23(v0, v4);
    method10(v0, " }");
}

export function closure24(v0: US0_$union, v1: (() => string), v2: (() => [int32, int64, Option<int32>, boolean]), unitVar: void): string {
    let v368: int64, v392: number;
    if (State_trace_state() == null) {
        State_trace_state(closure0(undefined, US0_US0_0()));
    }
    const patternInput: [Mut0, Mut1, Mut2, Mut3, Option<int64>] = value_1(State_trace_state());
    const v18: Option<int64> = patternInput[4];
    let _v35: Option<string> = undefined;
    const _v333: FSharpRef<Option<US2_$union>> = new FSharpRef<Option<US2_$union>>(undefined);
    let x_2: Option<US2_$union>;
    if (v18 == null) {
        x_2 = undefined;
    }
    else {
        const x: int64 = value_1(v18);
        x_2 = ((): US2_$union => US2_US2_0(x))();
    }
    _v333.contents = x_2;
    const v360: US2_$union = defaultArg(_v333.contents, US2_US2_1());
    const x_3: string = toString((v360.tag === /* US2_0 */ 0) ? ((v368 = v360.fields[0], (v392 = fromTicks(toInt64(op_Subtraction(getTicks(now()), v368))), create(1, 1, 1, hours(v392), minutes(v392), seconds(v392), milliseconds(v392))))) : now(), method7());
    _v35 = x_3;
    let v772: string;
    if (_v35 == null) {
        throw new Error("base.run_target / _v35=None");
    }
    else {
        v772 = value_1(_v35);
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
    const x_5: string = (((v0.tag === /* US0_1 */ 1) ? "\u001b[94m" : ((v0.tag === /* US0_2 */ 2) ? "\u001b[92m" : ((v0.tag === /* US0_0 */ 0) ? "\u001b[90m" : ((v0.tag === /* US0_3 */ 3) ? "\u001b[93m" : "\u001b[91m")))) + v997) + method8();
    _v1029 = x_5;
    let v1141: string;
    if (_v1029 == null) {
        throw new Error("base.run_target / _v1029=None");
    }
    else {
        v1141 = value_1(_v1029);
    }
    const v1160: int64 = patternInput[0].l0;
    const patternInput_1: [int32, int64, Option<int32>, boolean] = v2();
    const v1166: Mut4 = new Mut4("");
    method20(v1166, patternInput_1[0], patternInput_1[1], patternInput_1[2], patternInput_1[3]);
    const v1167: string = v1166.l0;
    return trimEnd(trimStart(`${v772} ${v1141} #${v1160} ${v1()} / ${v1167}`, ...[]), ...[" ", "/"]);
}

export function method19(v0: US0_$union, v1: (() => string), v2: (() => [int32, int64, Option<int32>, boolean])): void {
    method13(v0, (): string => closure24(v0, v1, v2, undefined));
}

export function method18(v0: Option<int32>, v1: boolean, v2: string, v3: int32, v4: int64): any {
    let _v7: Option<any> = undefined;
    const x: any = defaultOf();
    _v7 = x;
    if (_v7 == null) {
        throw new Error("base.run_target / _v7=None");
    }
    else {
        return value_1(_v7);
    }
}

export function closure21(v0: Option<int32>, v1: boolean, v2: string, v3: int32): any {
    return method18(v0, v1, v2, v3, 0n);
}

export function closure20(v0: Option<int32>, v1: boolean, v2: string): ((arg0: int32) => any) {
    return (v: int32): any => closure21(v0, v1, v2, v);
}

export function closure19(v0: Option<int32>, v1: boolean): ((arg0: string) => ((arg0: int32) => any)) {
    return (v: string): ((arg0: int32) => any) => closure20(v0, v1, v);
}

export function closure18(unitVar: void, v0: Option<int32>): ((arg0: boolean) => ((arg0: string) => ((arg0: int32) => any))) {
    return (v: boolean): ((arg0: string) => ((arg0: int32) => any)) => closure19(v0, v);
}

export function method24(v0: Option<int32>, v1: string, v2: int32): any {
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

export function closure27(v0: Option<int32>, v1: string, v2: int32): any {
    return method24(v0, v1, v2);
}

export function closure26(v0: Option<int32>, v1: string): ((arg0: int32) => any) {
    return (v: int32): any => closure27(v0, v1, v);
}

export function closure25(unitVar: void, v0: Option<int32>): ((arg0: string) => ((arg0: int32) => any)) {
    return (v: string): ((arg0: int32) => any) => closure26(v0, v);
}

export const v44 = (v: US0_$union): [Mut0, Mut1, Mut2, Mut3, Option<int64>] => closure0(undefined, v);

export const v45: US0_$union = US0_US0_0();

if (State_trace_state() == null) {
    State_trace_state(v44(v45));
}

export const v51 = (v: string): ((arg0: int32) => any) => closure2(undefined, v);

export function test_port_open(x: string): ((arg0: int32) => any) {
    return v51(x);
}

export const v52 = (v: int32): ((arg0: string) => ((arg0: int32) => any)) => closure7(undefined, v);

export function test_port_open_timeout(x: int32): ((arg0: string) => ((arg0: int32) => any)) {
    return v52(x);
}

export const v53 = (v: Option<int32>): ((arg0: boolean) => ((arg0: string) => ((arg0: int32) => any))) => closure18(undefined, v);

export function wait_for_port_access(x: Option<int32>): ((arg0: boolean) => ((arg0: string) => ((arg0: int32) => any))) {
    return v53(x);
}

export const v54 = (v: Option<int32>): ((arg0: string) => ((arg0: int32) => any)) => closure25(undefined, v);

export function get_available_port(x: Option<int32>): ((arg0: string) => ((arg0: int32) => any)) {
    return v54(x);
}


