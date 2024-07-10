import { compare, IComparable, IEquatable, createAtom } from "../../deps/Fable/src/fable-library-ts/Util.js";
import { some, defaultArg, value, Option } from "../../deps/Fable/src/fable-library-ts/Option.js";
import { op_Addition, op_Subtraction, toInt64, int64 } from "../../deps/Fable/src/fable-library-ts/BigInt.js";
import { FSharpRef, Record, Union } from "../../deps/Fable/src/fable-library-ts/Types.js";
import { bool_type, lambda_type, unit_type, string_type, record_type, int64_type, union_type, TypeInfo } from "../../deps/Fable/src/fable-library-ts/Reflection.js";
import { create, toString, now, getTicks } from "../../deps/Fable/src/fable-library-ts/Date.js";
import { milliseconds, seconds, minutes, hours, fromTicks } from "../../deps/Fable/src/fable-library-ts/TimeSpan.js";
import { trimStart, trimEnd, padLeft } from "../../deps/Fable/src/fable-library-ts/String.js";
import { ofSeq, find } from "../../deps/Fable/src/fable-library-ts/Map.js";
import { int32 } from "../../deps/Fable/src/fable-library-ts/Int32.js";

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
    return union_type("Trace.US0", [], US0, () => [[], [], [], [], []]);
}

export class Mut0 extends Record implements IEquatable<Mut0>, IComparable<Mut0> {
    l0: int64;
    constructor(l0: int64) {
        super();
        this.l0 = l0;
    }
}

export function Mut0_$reflection(): TypeInfo {
    return record_type("Trace.Mut0", [], Mut0, () => [["l0", int64_type]]);
}

export class Mut1 extends Record {
    l0: ((arg0: string) => void);
    constructor(l0: ((arg0: string) => void)) {
        super();
        this.l0 = l0;
    }
}

export function Mut1_$reflection(): TypeInfo {
    return record_type("Trace.Mut1", [], Mut1, () => [["l0", lambda_type(string_type, unit_type)]]);
}

export class Mut2 extends Record implements IEquatable<Mut2>, IComparable<Mut2> {
    l0: boolean;
    constructor(l0: boolean) {
        super();
        this.l0 = l0;
    }
}

export function Mut2_$reflection(): TypeInfo {
    return record_type("Trace.Mut2", [], Mut2, () => [["l0", bool_type]]);
}

export class Mut3 extends Record implements IEquatable<Mut3>, IComparable<Mut3> {
    l0: US0_$union;
    constructor(l0: US0_$union) {
        super();
        this.l0 = l0;
    }
}

export function Mut3_$reflection(): TypeInfo {
    return record_type("Trace.Mut3", [], Mut3, () => [["l0", US0_$reflection()]]);
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
    return union_type("Trace.US1", [], US1, () => [[["f0_0", US0_$reflection()]], []]);
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
    return union_type("Trace.US2", [], US2, () => [[["f0_0", int64_type]], []]);
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
    return union_type("Trace.US3", [], US3, () => [[["f0_0", string_type]], []]);
}

export class Mut4 extends Record implements IEquatable<Mut4>, IComparable<Mut4> {
    l0: string;
    constructor(l0: string) {
        super();
        this.l0 = l0;
    }
}

export function Mut4_$reflection(): TypeInfo {
    return record_type("Trace.Mut4", [], Mut4, () => [["l0", string_type]]);
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
        return value(_v3);
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
        patternInput = value(_v3);
    }
    const v325: US2_$union = patternInput[1];
    const v324: US1_$union = patternInput[0];
    return [new Mut0(0n), new Mut1((v: string): void => {
        closure1(undefined, v);
    }), new Mut2(true), new Mut3((v324.tag === /* US1_0 */ 0) ? v324.fields[0] : v0), (v325.tag === /* US2_0 */ 0) ? v325.fields[0] : undefined] as [Mut0, Mut1, Mut2, Mut3, Option<int64>];
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

export function method9(v0: Mut4, v1: string): void {
    const v4 = `${v1}`;
    const v12: string = v0.l0 + v4;
    v0.l0 = v12;
}

export function closure5(v0: US0_$union, v1: (() => string), v2_1: (() => string), unitVar: void): string {
    let v368: int64, v392: number;
    if (State_trace_state() == null) {
        State_trace_state(closure0(undefined, US0_US0_0()));
    }
    const patternInput: [Mut0, Mut1, Mut2, Mut3, Option<int64>] = value(State_trace_state());
    const v18: Option<int64> = patternInput[4];
    let _v35: Option<string> = undefined;
    const _v333: FSharpRef<Option<US2_$union>> = new FSharpRef<Option<US2_$union>>(undefined);
    let x_2: Option<US2_$union>;
    if (v18 == null) {
        x_2 = undefined;
    }
    else {
        const x: int64 = value(v18);
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
        v772 = value(_v35);
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
        v1141 = value(_v1029);
    }
    const v1160: int64 = patternInput[0].l0;
    const v1163: Mut4 = new Mut4("");
    method9(v1163, v2_1());
    const v1164: string = v1163.l0;
    return trimEnd(trimStart(`${v772} ${v1141} #${v1160} ${v1()} / ${v1164}`, ...[]), ...[" ", "/"]);
}

export function method10(v0: US0_$union, v1: (() => string)): void {
    const v4 = (v: US0_$union): [Mut0, Mut1, Mut2, Mut3, Option<int64>] => closure0(undefined, v);
    if (State_trace_state() == null) {
        State_trace_state(v4(US0_US0_0()));
    }
    const patternInput: [Mut0, Mut1, Mut2, Mut3, Option<int64>] = value(State_trace_state());
    const v13: Mut0 = patternInput[0];
    if (State_trace_state() == null) {
        State_trace_state(v4(US0_US0_0()));
    }
    const patternInput_1: [Mut0, Mut1, Mut2, Mut3, Option<int64>] = value(State_trace_state());
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
            value(_v81);
        }
        patternInput[1].l0(v72);
    }
}

export function method4(v0: US0_$union, v1: (() => string), v2_1: (() => string)): void {
    method10(v0, (): string => closure5(v0, v1, v2_1, undefined));
}

export function closure4(v0: US0_$union, v1: (() => string), v2_1: (() => string)): void {
    method4(v0, v1, v2_1);
}

export function closure3(v0: US0_$union, v1: (() => string)): ((arg0: (() => string)) => void) {
    return (v: (() => string)): void => {
        closure4(v0, v1, v);
    };
}

export function closure2(unitVar: void, v0: US0_$union): ((arg0: (() => string)) => ((arg0: (() => string)) => void)) {
    return (v: (() => string)): ((arg0: (() => string)) => void) => closure3(v0, v);
}

export const v2 = (v: US0_$union): [Mut0, Mut1, Mut2, Mut3, Option<int64>] => closure0(undefined, v);

export const v3: US0_$union = US0_US0_0();

if (State_trace_state() == null) {
    State_trace_state(v2(v3));
}

export const v9 = (v: US0_$union): ((arg0: (() => string)) => ((arg0: (() => string)) => void)) => closure2(undefined, v);

export function trace(x: US0_$union): ((arg0: (() => string)) => ((arg0: (() => string)) => void)) {
    return v9(x);
}


