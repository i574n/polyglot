import { compare, IComparable, IEquatable, createAtom } from "../../deps/Fable/src/fable-library-ts/Util.js";
import { defaultArg, value, Option } from "../../deps/Fable/src/fable-library-ts/Option.js";
import { op_Subtraction, op_Addition, toInt64, int64 } from "../../deps/Fable/src/fable-library-ts/BigInt.js";
import { FSharpRef, Record, Union } from "../../deps/Fable/src/fable-library-ts/Types.js";
import { bool_type, lambda_type, unit_type, string_type, record_type, int64_type, union_type, TypeInfo } from "../../deps/Fable/src/fable-library-ts/Reflection.js";
import { create, toString, now, getTicks } from "../../deps/Fable/src/fable-library-ts/Date.js";
import { ofSeq, find } from "../../deps/Fable/src/fable-library-ts/Map.js";
import { int32 } from "../../deps/Fable/src/fable-library-ts/Int32.js";
import { milliseconds, seconds, minutes, hours, fromTicks } from "../../deps/Fable/src/fable-library-ts/TimeSpan.js";
import { trimStart, trimEnd, padLeft } from "../../deps/Fable/src/fable-library-ts/String.js";

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
    return union_type("Trace.US1", [], US1, () => [[["f0_0", string_type]], []]);
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
    return union_type("Trace.US2", [], US2, () => [[["f0_0", US0_$reflection()]], []]);
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
    return union_type("Trace.US3", [], US3, () => [[["f0_0", int64_type]], []]);
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

export function method1(): string {
    return "TRACE_LEVEL";
}

export function method3(): string {
    return "";
}

export function method2(v0_1: string): string {
    return process.env[v0_1] ?? "";
}

export function method4(): string {
    return "AUTOMATION";
}

export function closure0(unitVar: void, v0_1: string): void {
}

export function method0(v0_1: US0_$union): [Mut0, Mut1, Mut2, Mut3, Option<int64>] {
    let v124: US2_$union, v131: US2_$union, v138: US2_$union, v145: US2_$union;
    const v112: string = method2(method1());
    const v117: US2_$union = ("Verbose" === v112) ? US2_US2_0(US0_US0_0()) : US2_US2_1();
    const _v1 = [(v117.tag === /* US2_0 */ 0) ? US2_US2_0(v117.fields[0]) : ((v124 = (("Debug" === v112) ? US2_US2_0(US0_US0_1()) : US2_US2_1()), (v124.tag === /* US2_0 */ 0) ? US2_US2_0(v124.fields[0]) : ((v131 = (("Info" === v112) ? US2_US2_0(US0_US0_2()) : US2_US2_1()), (v131.tag === /* US2_0 */ 0) ? US2_US2_0(v131.fields[0]) : ((v138 = (("Warning" === v112) ? US2_US2_0(US0_US0_3()) : US2_US2_1()), (v138.tag === /* US2_0 */ 0) ? US2_US2_0(v138.fields[0]) : ((v145 = (("Critical" === v112) ? US2_US2_0(US0_US0_4()) : US2_US2_1()), (v145.tag === /* US2_0 */ 0) ? US2_US2_0(v145.fields[0]) : US2_US2_1())))))))), (method2(method4()) === "True") ? US3_US3_0(getTicks(now())) : US3_US3_1()] as [US2_$union, US3_$union];
    const v295: US3_$union = _v1[1];
    const v294: US2_$union = _v1[0];
    return [new Mut0(0n), new Mut1((v: string): void => {
        closure0(undefined, v);
    }), new Mut2(true), new Mut3((v294.tag === /* US2_0 */ 0) ? v294.fields[0] : v0_1), (v295.tag === /* US3_0 */ 0) ? v295.fields[0] : undefined] as [Mut0, Mut1, Mut2, Mut3, Option<int64>];
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

export function closure3(v0_1: US0_$union, v1: (() => string), v2: (() => string)): void {
    let v276: int64, v286: number;
    if (State_trace_state() == null) {
        const patternInput: [Mut0, Mut1, Mut2, Mut3, Option<int64>] = method0(US0_US0_0());
        State_trace_state([patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4]] as [Mut0, Mut1, Mut2, Mut3, Option<int64>]);
    }
    const patternInput_1: [Mut0, Mut1, Mut2, Mut3, Option<int64>] = value(State_trace_state());
    const v15: Mut0 = patternInput_1[0];
    if (State_trace_state() == null) {
        const patternInput_2: [Mut0, Mut1, Mut2, Mut3, Option<int64>] = method0(US0_US0_0());
        State_trace_state([patternInput_2[0], patternInput_2[1], patternInput_2[2], patternInput_2[3], patternInput_2[4]] as [Mut0, Mut1, Mut2, Mut3, Option<int64>]);
    }
    const patternInput_3: [Mut0, Mut1, Mut2, Mut3, Option<int64>] = value(State_trace_state());
    const v57: US0_$union = patternInput_3[3].l0;
    if ((patternInput_3[2].l0 === false) ? false : (find<US0_$union, int32>(v0_1, ofSeq([[US0_US0_0(), 0] as [US0_$union, int32], [US0_US0_1(), 1] as [US0_$union, int32], [US0_US0_2(), 2] as [US0_$union, int32], [US0_US0_3(), 3] as [US0_$union, int32], [US0_US0_4(), 4] as [US0_$union, int32]], {
        Compare: compare,
    })) >= find<US0_$union, int32>(v57, ofSeq([[US0_US0_0(), 0] as [US0_$union, int32], [US0_US0_1(), 1] as [US0_$union, int32], [US0_US0_2(), 2] as [US0_$union, int32], [US0_US0_3(), 3] as [US0_$union, int32], [US0_US0_4(), 4] as [US0_$union, int32]], {
        Compare: compare,
    })))) {
        const v65: int64 = toInt64(op_Addition(v15.l0, 1n));
        v15.l0 = v65;
        if (State_trace_state() == null) {
            const patternInput_4: [Mut0, Mut1, Mut2, Mut3, Option<int64>] = method0(US0_US0_0());
            State_trace_state([patternInput_4[0], patternInput_4[1], patternInput_4[2], patternInput_4[3], patternInput_4[4]] as [Mut0, Mut1, Mut2, Mut3, Option<int64>]);
        }
        const patternInput_5: [Mut0, Mut1, Mut2, Mut3, Option<int64>] = value(State_trace_state());
        const v82: Option<int64> = patternInput_5[4];
        const _v257: FSharpRef<Option<US3_$union>> = new FSharpRef<Option<US3_$union>>(undefined);
        let x_4: Option<US3_$union>;
        if (v82 == null) {
            x_4 = undefined;
        }
        else {
            const x_2: int64 = value(v82);
            x_4 = ((): US3_$union => US3_US3_0(x_2))();
        }
        _v257.contents = x_4;
        const v272: US3_$union = defaultArg(_v257.contents, US3_US3_1());
        const v317: string = toString((v272.tag === /* US3_0 */ 0) ? ((v276 = v272.fields[0], (v286 = fromTicks(toInt64(op_Subtraction(getTicks(now()), v276))), create(1, 1, 1, hours(v286), minutes(v286), seconds(v286), milliseconds(v286))))) : now(), method6());
        const v515: US1_$union = (v0_1.tag === /* US0_0 */ 0) ? US1_US1_0("Verbose") : US1_US1_1();
        let v556: US1_$union;
        if (v515.tag === /* US1_0 */ 0) {
            v556 = US1_US1_0(v515.fields[0]);
        }
        else {
            const v522: US1_$union = (v0_1.tag === /* US0_1 */ 1) ? US1_US1_0("Debug") : US1_US1_1();
            if (v522.tag === /* US1_0 */ 0) {
                v556 = US1_US1_0(v522.fields[0]);
            }
            else {
                const v529: US1_$union = (v0_1.tag === /* US0_2 */ 2) ? US1_US1_0("Info") : US1_US1_1();
                if (v529.tag === /* US1_0 */ 0) {
                    v556 = US1_US1_0(v529.fields[0]);
                }
                else {
                    const v536: US1_$union = (v0_1.tag === /* US0_3 */ 3) ? US1_US1_0("Warning") : US1_US1_1();
                    if (v536.tag === /* US1_0 */ 0) {
                        v556 = US1_US1_0(v536.fields[0]);
                    }
                    else {
                        const v543: US1_$union = (v0_1.tag === /* US0_4 */ 4) ? US1_US1_0("Critical") : US1_US1_1();
                        v556 = ((v543.tag === /* US1_0 */ 0) ? US1_US1_0(v543.fields[0]) : US1_US1_1());
                    }
                }
            }
        }
        let v560: string;
        if (v556.tag === /* US1_0 */ 0) {
            v560 = v556.fields[0];
        }
        else {
            throw new Error("Option does not have a value.");
        }
        const v565: string = padLeft(v560.toLocaleLowerCase(), 7, " ");
        const v664: string = (((v0_1.tag === /* US0_1 */ 1) ? "\u001b[94m" : ((v0_1.tag === /* US0_2 */ 2) ? "\u001b[92m" : ((v0_1.tag === /* US0_0 */ 0) ? "\u001b[90m" : ((v0_1.tag === /* US0_3 */ 3) ? "\u001b[93m" : "\u001b[91m")))) + v565) + method7();
        const v706: int64 = patternInput_5[0].l0;
        const v707: string = v2();
        const v709: Mut4 = new Mut4(method8());
        const v710 = `${v707}`;
        const v714: string = v709.l0 + v710;
        v709.l0 = v714;
        const v715: string = v709.l0;
        const v753: string = trimEnd(trimStart(`${v317} ${v664} #${v706} ${v1()} / ${v715}`, ...[]), ...[" ", "/"]);
        console.log(v753);
        patternInput_1[1].l0(v753);
    }
}

export function closure2(v0_1: US0_$union, v1: (() => string)): ((arg0: (() => string)) => void) {
    return (v: (() => string)): void => {
        closure3(v0_1, v1, v);
    };
}

export function closure1(unitVar: void, v0_1: US0_$union): ((arg0: (() => string)) => ((arg0: (() => string)) => void)) {
    return (v: (() => string)): ((arg0: (() => string)) => void) => closure2(v0_1, v);
}

export const v0: boolean = State_trace_state() == null;

if (v0) {
    const patternInput: [Mut0, Mut1, Mut2, Mut3, Option<int64>] = method0(US0_US0_0());
    State_trace_state([patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4]] as [Mut0, Mut1, Mut2, Mut3, Option<int64>]);
}

export const v12 = (v: US0_$union): ((arg0: (() => string)) => ((arg0: (() => string)) => void)) => closure1(undefined, v);

export function trace(x: US0_$union): ((arg0: (() => string)) => ((arg0: (() => string)) => void)) {
    return v12(x);
}


