import { compare, equals, defaultOf, IComparable, IEquatable, createAtom } from "../../deps/Fable/src/fable-library-ts/Util.js";
import { value as value_2, some, Option } from "../../deps/Fable/src/fable-library-ts/Option.js";
import { op_Addition, toInt64, int64 } from "../../deps/Fable/src/fable-library-ts/BigInt.js";
import { FSharpRef, Union, Record } from "../../deps/Fable/src/fable-library-ts/Types.js";
import { lambda_type, class_type, unit_type, tuple_type, int32_type, string_type, char_type, union_type, bool_type, record_type, int64_type, TypeInfo } from "../../deps/Fable/src/fable-library-ts/Reflection.js";
import { int32 } from "../../deps/Fable/src/fable-library-ts/Int32.js";
import { trimStart, trimEnd, interpolate, toText, replace } from "../../deps/Fable/src/fable-library-ts/String.js";

export let State_trace_state = createAtom<Option<[Mut0, Mut1, Mut1, Mut2, Option<int64>]>>(void 0);

export class Mut0 extends Record implements IEquatable<Mut0>, IComparable<Mut0> {
    l0: int64;
    constructor(l0: int64) {
        super();
        this.l0 = l0;
    }
}

export function Mut0_$reflection(): TypeInfo {
    return record_type("Runtime.Mut0", [], Mut0, () => [["l0", int64_type]]);
}

export class Mut1 extends Record implements IEquatable<Mut1>, IComparable<Mut1> {
    l0: boolean;
    constructor(l0: boolean) {
        super();
        this.l0 = l0;
    }
}

export function Mut1_$reflection(): TypeInfo {
    return record_type("Runtime.Mut1", [], Mut1, () => [["l0", bool_type]]);
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
    return union_type("Runtime.US0", [], US0, () => [[], [], [], [], []]);
}

export class Mut2 extends Record implements IEquatable<Mut2>, IComparable<Mut2> {
    l0: US0_$union;
    constructor(l0: US0_$union) {
        super();
        this.l0 = l0;
    }
}

export function Mut2_$reflection(): TypeInfo {
    return record_type("Runtime.Mut2", [], Mut2, () => [["l0", US0_$reflection()]]);
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
    return union_type("Runtime.US1", [], US1, () => [[["f0_0", int64_type]], []]);
}

export type UH0_$union = 
    | UH0<0>
    | UH0<1>

export type UH0_$cases = {
    0: ["UH0_0", []],
    1: ["UH0_1", [string, UH0_$union]]
}

export function UH0_UH0_0() {
    return new UH0<0>(0, []);
}

export function UH0_UH0_1(Item1: string, Item2: UH0_$union) {
    return new UH0<1>(1, [Item1, Item2]);
}

export class UH0<Tag extends keyof UH0_$cases> extends Union<Tag, UH0_$cases[Tag][0]> {
    constructor(readonly tag: Tag, readonly fields: UH0_$cases[Tag][1]) {
        super();
    }
    cases() {
        return ["UH0_0", "UH0_1"];
    }
}

export function UH0_$reflection(): TypeInfo {
    return union_type("Runtime.UH0", [], UH0, () => [[], [["Item1", char_type], ["Item2", UH0_$reflection()]]]);
}

export type US3_$union = 
    | US3<0>
    | US3<1>

export type US3_$cases = {
    0: ["US3_0", []],
    1: ["US3_1", []]
}

export function US3_US3_0() {
    return new US3<0>(0, []);
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
    return union_type("Runtime.US3", [], US3, () => [[], []]);
}

export type US2_$union = 
    | US2<0>
    | US2<1>
    | US2<2>

export type US2_$cases = {
    0: ["US2_0", []],
    1: ["US2_1", [US3_$union]],
    2: ["US2_2", []]
}

export function US2_US2_0() {
    return new US2<0>(0, []);
}

export function US2_US2_1(f1_0: US3_$union) {
    return new US2<1>(1, [f1_0]);
}

export function US2_US2_2() {
    return new US2<2>(2, []);
}

export class US2<Tag extends keyof US2_$cases> extends Union<Tag, US2_$cases[Tag][0]> {
    constructor(readonly tag: Tag, readonly fields: US2_$cases[Tag][1]) {
        super();
    }
    cases() {
        return ["US2_0", "US2_1", "US2_2"];
    }
}

export function US2_$reflection(): TypeInfo {
    return union_type("Runtime.US2", [], US2, () => [[], [["f1_0", US3_$reflection()]], []]);
}

export type US4_$union = 
    | US4<0>
    | US4<1>

export type US4_$cases = {
    0: ["US4_0", [string]],
    1: ["US4_1", []]
}

export function US4_US4_0(f0_0: string) {
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
    return union_type("Runtime.US4", [], US4, () => [[["f0_0", string_type]], []]);
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
    return union_type("Runtime.US5", [], US5, () => [[["f0_0", int64_type]], []]);
}

export type US6_$union = 
    | US6<0>
    | US6<1>

export type US6_$cases = {
    0: ["US6_0", [((arg0: [boolean, string, int32]) => any)]],
    1: ["US6_1", []]
}

export function US6_US6_0(f0_0: ((arg0: [boolean, string, int32]) => any)) {
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
    return union_type("Runtime.US6", [], US6, () => [[["f0_0", lambda_type(tuple_type(bool_type, string_type, int32_type), class_type("Microsoft.FSharp.Control.FSharpAsync`1", [unit_type]))]], []]);
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
    return union_type("Runtime.US7", [], US7, () => [[["f0_0", class_type("System.Threading.CancellationToken")]], []]);
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

export function UH0__get_IsUH0_0(this$: UH0_$union, unitArg: void): boolean {
    if ((this$ as any)['tag'] === /* UH0_0 */ 0) {
        return true;
    }
    else {
        return false;
    }
}

export function UH0__get_IsUH0_1(this$: UH0_$union, unitArg: void): boolean {
    if ((this$ as any)['tag'] === /* UH0_1 */ 1) {
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

export function US2__get_IsUS2_2(this$: FSharpRef<US2_$union>, unitArg: void): boolean {
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
    return [v1_1, v4_1, v0_1, v3_1, value_2(_v5)] as [Mut0, Mut1, Mut1, Mut2, Option<int64>];
}

export function closure1(unitVar: void, unitVar_1: void): boolean {
    let _v0: Option<boolean> = void 0;
    const x: boolean = defaultOf();
    _v0 = x;
    return value_2(_v0);
}

export function closure2(unitVar: void, unitVar_1: void): string {
    let _v0: Option<boolean> = void 0;
    const x: boolean = defaultOf();
    _v0 = x;
    if (value_2(_v0)) {
        return ".exe";
    }
    else {
        return "";
    }
}

export function method2(): [string, string] {
    return ["", ""] as [string, string];
}

export function closure5(v0_1: string, v1_1: UH0_$union): UH0_$union {
    return UH0_UH0_1(v0_1, v1_1);
}

export function closure4(unitVar: void, v0_1: string): ((arg0: UH0_$union) => UH0_$union) {
    return (v: UH0_$union): UH0_$union => closure5(v0_1, v);
}

export function method3(): ((arg0: string) => ((arg0: UH0_$union) => UH0_$union)) {
    return (v: string): ((arg0: UH0_$union) => UH0_$union) => closure4(void 0, v);
}

export function method4(v0_1_mut: string, v1_1_mut: string, v2_1_mut: UH0_$union, v3_1_mut: US2_$union): [string, string] {
    method4:
    while (true) {
        const v0_1: string = v0_1_mut, v1_1: string = v1_1_mut, v2_1: UH0_$union = v2_1_mut, v3_1: US2_$union = v3_1_mut;
        if (v2_1.tag === /* UH0_1 */ 1) {
            const v5: UH0_$union = v2_1.fields[1];
            const v4_1: string = v2_1.fields[0];
            switch (v4_1) {
                case "\"":
                    if (v1_1 === "") {
                        v0_1_mut = v0_1;
                        v1_1_mut = v1_1;
                        v2_1_mut = v5;
                        v3_1_mut = US2_US2_1(US3_US3_0());
                        continue method4;
                    }
                    else {
                        switch (v3_1.tag) {
                            case /* US2_1 */ 1:
                                if (v3_1.fields[0].tag === /* US3_0 */ 0) {
                                    v0_1_mut = v0_1;
                                    v1_1_mut = v1_1;
                                    v2_1_mut = v5;
                                    v3_1_mut = US2_US2_1(US3_US3_1());
                                    continue method4;
                                }
                                else if (" " === v4_1) {
                                    v0_1_mut = v0_1;
                                    v1_1_mut = v1_1;
                                    v2_1_mut = v5;
                                    v3_1_mut = US2_US2_2();
                                    continue method4;
                                }
                                else {
                                    v0_1_mut = v0_1;
                                    v1_1_mut = (`${v1_1}${v4_1}`);
                                    v2_1_mut = v5;
                                    v3_1_mut = v3_1;
                                    continue method4;
                                }
                            case /* US2_0 */ 0:
                                if (" " === v4_1) {
                                    v0_1_mut = v0_1;
                                    v1_1_mut = v1_1;
                                    v2_1_mut = v5;
                                    v3_1_mut = US2_US2_2();
                                    continue method4;
                                }
                                else {
                                    v0_1_mut = v0_1;
                                    v1_1_mut = (`${v1_1}${v4_1}`);
                                    v2_1_mut = v5;
                                    v3_1_mut = v3_1;
                                    continue method4;
                                }
                            default: {
                                v0_1_mut = (`${v0_1}${v4_1}`);
                                v1_1_mut = v1_1;
                                v2_1_mut = v5;
                                v3_1_mut = US2_US2_2();
                                continue method4;
                            }
                        }
                    }
                case "\'":
                    if (v1_1 === "") {
                        v0_1_mut = v0_1;
                        v1_1_mut = v1_1;
                        v2_1_mut = v5;
                        v3_1_mut = US2_US2_1(US3_US3_0());
                        continue method4;
                    }
                    else {
                        switch (v3_1.tag) {
                            case /* US2_1 */ 1:
                                if (v3_1.fields[0].tag === /* US3_0 */ 0) {
                                    v0_1_mut = v0_1;
                                    v1_1_mut = v1_1;
                                    v2_1_mut = v5;
                                    v3_1_mut = US2_US2_1(US3_US3_1());
                                    continue method4;
                                }
                                else if (" " === v4_1) {
                                    v0_1_mut = v0_1;
                                    v1_1_mut = v1_1;
                                    v2_1_mut = v5;
                                    v3_1_mut = US2_US2_2();
                                    continue method4;
                                }
                                else {
                                    v0_1_mut = v0_1;
                                    v1_1_mut = (`${v1_1}${v4_1}`);
                                    v2_1_mut = v5;
                                    v3_1_mut = v3_1;
                                    continue method4;
                                }
                            case /* US2_0 */ 0:
                                if (" " === v4_1) {
                                    v0_1_mut = v0_1;
                                    v1_1_mut = v1_1;
                                    v2_1_mut = v5;
                                    v3_1_mut = US2_US2_2();
                                    continue method4;
                                }
                                else {
                                    v0_1_mut = v0_1;
                                    v1_1_mut = (`${v1_1}${v4_1}`);
                                    v2_1_mut = v5;
                                    v3_1_mut = v3_1;
                                    continue method4;
                                }
                            default: {
                                v0_1_mut = (`${v0_1}${v4_1}`);
                                v1_1_mut = v1_1;
                                v2_1_mut = v5;
                                v3_1_mut = US2_US2_2();
                                continue method4;
                            }
                        }
                    }
                default:
                    switch (v3_1.tag) {
                        case /* US2_1 */ 1:
                            if (v3_1.fields[0].tag === /* US3_0 */ 0) {
                                if (" " === v4_1) {
                                    v0_1_mut = v0_1;
                                    v1_1_mut = (`${v1_1} `);
                                    v2_1_mut = v5;
                                    v3_1_mut = US2_US2_1(US3_US3_0());
                                    continue method4;
                                }
                                else {
                                    v0_1_mut = v0_1;
                                    v1_1_mut = (`${v1_1}${v4_1}`);
                                    v2_1_mut = v5;
                                    v3_1_mut = v3_1;
                                    continue method4;
                                }
                            }
                            else if (" " === v4_1) {
                                v0_1_mut = v0_1;
                                v1_1_mut = v1_1;
                                v2_1_mut = v5;
                                v3_1_mut = US2_US2_2();
                                continue method4;
                            }
                            else {
                                v0_1_mut = v0_1;
                                v1_1_mut = (`${v1_1}${v4_1}`);
                                v2_1_mut = v5;
                                v3_1_mut = v3_1;
                                continue method4;
                            }
                        case /* US2_0 */ 0:
                            if (" " === v4_1) {
                                v0_1_mut = v0_1;
                                v1_1_mut = v1_1;
                                v2_1_mut = v5;
                                v3_1_mut = US2_US2_2();
                                continue method4;
                            }
                            else {
                                v0_1_mut = v0_1;
                                v1_1_mut = (`${v1_1}${v4_1}`);
                                v2_1_mut = v5;
                                v3_1_mut = v3_1;
                                continue method4;
                            }
                        default: {
                            v0_1_mut = (`${v0_1}${v4_1}`);
                            v1_1_mut = v1_1;
                            v2_1_mut = v5;
                            v3_1_mut = US2_US2_2();
                            continue method4;
                        }
                    }
            }
        }
        else {
            switch (v3_1.tag) {
                case /* US2_1 */ 1:
                    if (v3_1.fields[0].tag === /* US3_0 */ 0) {
                        return [replace(v1_1, "\\", "/"), v0_1] as [string, string];
                    }
                    else {
                        return [replace(v1_1, "\\", "/"), v0_1] as [string, string];
                    }
                case /* US2_0 */ 0:
                    return [replace(v1_1, "\\", "/"), v0_1] as [string, string];
                default:
                    return [replace(v1_1, "\\", "/"), v0_1] as [string, string];
            }
        }
        break;
    }
}

export function closure6(unitVar: void, v0_1: string): US4_$union {
    return US4_US4_0(v0_1);
}

export function method5(): ((arg0: string) => US4_$union) {
    return (v: string): US4_$union => closure6(void 0, v);
}

export function closure7(v0_1: Option<any>, v1_1: string, v2_1: Option<((arg0: [boolean, string, int32]) => any)>, v3_1: Option<string>, unitVar: void): string {
    return toText(interpolate("execute_with_options_async / options: %A%P()", [[v0_1, v1_1, v2_1, v3_1] as [Option<any>, string, Option<((arg0: [boolean, string, int32]) => any)>, Option<string>]]));
}

export function closure8(unitVar: void, unitVar_1: void): string {
    return "";
}

export function method6(): (() => string) {
    return (): string => closure8(void 0, void 0);
}

export function closure10(unitVar: void, v0_1: int64): US5_$union {
    return US5_US5_0(v0_1);
}

export function method8(): ((arg0: int64) => US5_$union) {
    return (v: int64): US5_$union => closure10(void 0, v);
}

export function method9(): string {
    return "";
}

export function closure9(v0_1: US0_$union, v1_1: (() => string), v2_1: (() => string), unitVar: void): string {
    if (equals(State_trace_state(), void 0)) {
        State_trace_state(closure0(void 0, void 0));
    }
    const patternInput: [Mut0, Mut1, Mut1, Mut2, Option<int64>] = value_2(State_trace_state());
    let _v9: Option<string> = void 0;
    const x: string = method9();
    _v9 = x;
    const v61: string = value_2(_v9);
    const v62: int64 = patternInput[0].l0;
    const v72: string = (v0_1.tag === /* US0_1 */ 1) ? "Debug" : ((v0_1.tag === /* US0_2 */ 2) ? "Info" : ((v0_1.tag === /* US0_0 */ 0) ? "Verbose" : ((v0_1.tag === /* US0_3 */ 3) ? "Warning" : "Critical")));
    let _v74: Option<string> = void 0;
    const x_1: string = v72.toLocaleLowerCase();
    _v74 = x_1;
    return trimEnd(trimStart(`${v61} ${value_2(_v74)} #${v62} ${v1_1()} / ${v2_1()}`), " ", "/");
}

export function method7(v0_1: US0_$union, v1_1: (() => string), v2_1: (() => string)): void {
    const v3_1 = (): [Mut0, Mut1, Mut1, Mut2, Option<int64>] => closure0(void 0, void 0);
    if (equals(State_trace_state(), void 0)) {
        State_trace_state(v3_1());
    }
    const v4_1: Mut0 = value_2(State_trace_state())[0];
    if (equals(State_trace_state(), void 0)) {
        State_trace_state(v3_1());
    }
    const patternInput_1: [Mut0, Mut1, Mut1, Mut2, Option<int64>] = value_2(State_trace_state());
    const v14: US0_$union = patternInput_1[3].l0;
    if (patternInput_1[2].l0 && (compare(v0_1, v14) >= 0)) {
        const v19: int64 = toInt64(op_Addition(v4_1.l0, 1n));
        v4_1.l0 = v19;
        const v21 = `${closure9(v0_1, v1_1, v2_1, void 0)}`;
        let _v22: Option<void> = void 0;
        console.log(v21);
        _v22 = some(void 0);
        value_2(_v22);
    }
}

export function closure12(unitVar: void, v0_1: ((arg0: [boolean, string, int32]) => any)): US6_$union {
    return US6_US6_0(v0_1);
}

export function method10(): ((arg0: ((arg0: [boolean, string, int32]) => any)) => US6_$union) {
    return (v: ((arg0: [boolean, string, int32]) => any)): US6_$union => closure12(void 0, v);
}

export function closure13(v0_1: string, unitVar: void): string {
    return `> ${v0_1}`;
}

export function closure11(v0_1: Option<any>, v1_1: string, v2_1: Option<((arg0: [boolean, string, int32]) => any)>, v3_1: Option<string>, v4_1: void, v5: any, v6: void): void {
    let _v7: Option<any> = void 0;
    const x: any = defaultOf();
    _v7 = x;
    const v32: any = value_2(_v7);
    let _v33: Option<void> = void 0;
    defaultOf();
    _v33 = some(void 0);
    value_2(_v33);
}

export function closure14(v0_1: Option<any>, v1_1: string, v2_1: Option<((arg0: [boolean, string, int32]) => any)>, v3_1: Option<string>, v4_1: void, v5: any, v6: void): void {
    let _v7: Option<any> = void 0;
    const x: any = defaultOf();
    _v7 = x;
    const v33: any = value_2(_v7);
    let _v34: Option<void> = void 0;
    defaultOf();
    _v34 = some(void 0);
    value_2(_v34);
}

export function closure15(unitVar: void, v0_1: any): US7_$union {
    return US7_US7_0(v0_1);
}

export function method11(): ((arg0: any) => US7_$union) {
    return (v: any): US7_$union => closure15(void 0, v);
}

export function closure16(v0_1: void, unitVar: void): void {
    let _v1: Option<boolean> = void 0;
    const x: boolean = defaultOf();
    _v1 = x;
    if (value_2(_v1) === false) {
        let _v11: Option<void> = void 0;
        defaultOf();
        _v11 = some(void 0);
        value_2(_v11);
    }
}

export function closure17(v0_1: any, unitVar: void): string {
    return toText(interpolate("execute_with_options_async / WaitForExitAsync / ex: %A%P()", [v0_1]));
}

export function method12(): string {
    return "\n";
}

export function closure18(v0_1: int32, v1_1: string, unitVar: void): string {
    return `execute_with_options_async / exit_code: ${v0_1} / output.Length: ${v1_1.length}`;
}

export function closure3(unitVar: void, v0_1: string): any {
    let _v4: Option<any> = void 0;
    const x: any = defaultOf();
    _v4 = x;
    return value_2(_v4);
}

export function closure19(unitVar: void, _arg: [Option<any>, string, Option<((arg0: [boolean, string, int32]) => any)>, Option<string>]): any {
    let _v4: Option<any> = void 0;
    const x: any = defaultOf();
    _v4 = x;
    return value_2(_v4);
}

export const v0 = (): [Mut0, Mut1, Mut1, Mut2, Option<int64>] => closure0(void 0, void 0);

if (equals(State_trace_state(), void 0)) {
    State_trace_state(v0());
}

export const v1 = (): boolean => closure1(void 0, void 0);

export function is_windows(): boolean {
    return v1();
}

export const v2 = (): string => closure2(void 0, void 0);

export function get_executable_suffix(): string {
    return v2();
}

export const v3 = (v: string): any => closure3(void 0, v);

export function execute_async(x: string): any {
    return v3(x);
}

export const v4 = (arg10$0040: [Option<any>, string, Option<((arg0: [boolean, string, int32]) => any)>, Option<string>]): any => closure19(void 0, arg10$0040);

export function execute_with_options_async(x: [Option<any>, string, Option<((arg0: [boolean, string, int32]) => any)>, Option<string>]): any {
    return v4(x);
}


