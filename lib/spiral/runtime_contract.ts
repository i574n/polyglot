import { uncurry2, equals, compare, defaultOf, IComparable, IEquatable, createAtom } from "../../../polyglot/deps/Fable/src/fable-library-ts/Util.js";
import { map, defaultArg, value as value_2, some, Option } from "../../../polyglot/deps/Fable/src/fable-library-ts/Option.js";
import { op_Addition, toInt64, int64 } from "../../../polyglot/deps/Fable/src/fable-library-ts/BigInt.js";
import { FSharpRef, Union, Record } from "../../../polyglot/deps/Fable/src/fable-library-ts/Types.js";
import { uint8_type, class_type, tuple_type, char_type, int32_type, lambda_type, unit_type, string_type, union_type, bool_type, record_type, int64_type, TypeInfo } from "../../../polyglot/deps/Fable/src/fable-library-ts/Reflection.js";
import { uint8, int32 } from "../../../polyglot/deps/Fable/src/fable-library-ts/Int32.js";
import { trimStart, trimEnd, padRight, interpolate, toText, replace } from "../../../polyglot/deps/Fable/src/fable-library-ts/String.js";
import { ofSeq, find } from "../../../polyglot/deps/Fable/src/fable-library-ts/Map.js";
import { empty, foldBack, toArray, ofArray, FSharpList, cons } from "../../../polyglot/deps/Fable/src/fable-library-ts/List.js";
import { setItem, fill } from "../../../polyglot/deps/Fable/src/fable-library-ts/Array.js";

export let State_trace_state = createAtom<Option<[Mut0, Mut1, Mut2, Option<int64>, Mut3]>>(undefined);

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

export class Mut3 extends Record {
    l0: ((arg0: string) => void);
    constructor(l0: ((arg0: string) => void)) {
        super();
        this.l0 = l0;
    }
}

export function Mut3_$reflection(): TypeInfo {
    return record_type("Runtime.Mut3", [], Mut3, () => [["l0", lambda_type(string_type, unit_type)]]);
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

export class Mut4 extends Record implements IEquatable<Mut4>, IComparable<Mut4> {
    l0: int32;
    constructor(l0: int32) {
        super();
        this.l0 = (l0 | 0);
    }
}

export function Mut4_$reflection(): TypeInfo {
    return record_type("Runtime.Mut4", [], Mut4, () => [["l0", int32_type]]);
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

export type UH1_$union = 
    | UH1<0>
    | UH1<1>

export type UH1_$cases = {
    0: ["UH1_0", []],
    1: ["UH1_1", [string, UH1_$union]]
}

export function UH1_UH1_0() {
    return new UH1<0>(0, []);
}

export function UH1_UH1_1(Item1: string, Item2: UH1_$union) {
    return new UH1<1>(1, [Item1, Item2]);
}

export class UH1<Tag extends keyof UH1_$cases> extends Union<Tag, UH1_$cases[Tag][0]> {
    constructor(readonly tag: Tag, readonly fields: UH1_$cases[Tag][1]) {
        super();
    }
    cases() {
        return ["UH1_0", "UH1_1"];
    }
}

export function UH1_$reflection(): TypeInfo {
    return union_type("Runtime.UH1", [], UH1, () => [[], [["Item1", string_type], ["Item2", UH1_$reflection()]]]);
}

export type US8_$union = 
    | US8<0>
    | US8<1>
    | US8<2>

export type US8_$cases = {
    0: ["US8_0", []],
    1: ["US8_1", [string]],
    2: ["US8_2", [uint8]]
}

export function US8_US8_0() {
    return new US8<0>(0, []);
}

export function US8_US8_1(f1_0: string) {
    return new US8<1>(1, [f1_0]);
}

export function US8_US8_2(f2_0: uint8) {
    return new US8<2>(2, [f2_0]);
}

export class US8<Tag extends keyof US8_$cases> extends Union<Tag, US8_$cases[Tag][0]> {
    constructor(readonly tag: Tag, readonly fields: US8_$cases[Tag][1]) {
        super();
    }
    cases() {
        return ["US8_0", "US8_1", "US8_2"];
    }
}

export function US8_$reflection(): TypeInfo {
    return union_type("Runtime.US8", [], US8, () => [[], [["f1_0", char_type]], [["f2_0", uint8_type]]]);
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

export function UH1__get_IsUH1_0(this$: UH1_$union, unitArg: void): boolean {
    if ((this$ as any)['tag'] === /* UH1_0 */ 0) {
        return true;
    }
    else {
        return false;
    }
}

export function UH1__get_IsUH1_1(this$: UH1_$union, unitArg: void): boolean {
    if ((this$ as any)['tag'] === /* UH1_1 */ 1) {
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

export function US8__get_IsUS8_2(this$: FSharpRef<US8_$union>, unitArg: void): boolean {
    if ((this$ as any)['tag'] === 2) {
        return true;
    }
    else {
        return false;
    }
}

export function closure1(unitVar: void, v0_1: string): void {
}

export function method0(v0_1: Option<int64>): Option<int64> {
    return v0_1;
}

export function method1(v0_1: Option<int64>): Option<int64> {
    return v0_1;
}

export function closure0(unitVar: void, unitVar_1: void): [Mut0, Mut1, Mut2, Option<int64>, Mut3] {
    const v0_1: Mut1 = new Mut1(true);
    const v1_1: Mut0 = new Mut0(0n);
    const v3_1: Mut2 = new Mut2(US0_US0_0());
    const v5_1: Mut3 = new Mut3((v: string): void => {
        closure1(undefined, v);
    });
    let _v6: Option<Option<int64>> = undefined;
    const x: Option<int64> = method1(undefined);
    _v6 = some(x);
    return [v1_1, v0_1, v3_1, value_2(_v6), v5_1] as [Mut0, Mut1, Mut2, Option<int64>, Mut3];
}

export function closure2(unitVar: void, unitVar_1: void): boolean {
    let _v0: Option<boolean> = undefined;
    const x: boolean = defaultOf();
    _v0 = x;
    return value_2(_v0);
}

export function closure3(unitVar: void, unitVar_1: void): string {
    let _v0: Option<boolean> = undefined;
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

export function method3(v0_1: int32, v1_1: Mut4): boolean {
    return v1_1.l0 < v0_1;
}

export function closure6(v0_1: string, v1_1: UH0_$union): UH0_$union {
    return UH0_UH0_1(v0_1, v1_1);
}

export function closure5(unitVar: void, v0_1: string): ((arg0: UH0_$union) => UH0_$union) {
    return (v: UH0_$union): UH0_$union => closure6(v0_1, v);
}

export function method4(): ((arg0: string) => ((arg0: UH0_$union) => UH0_$union)) {
    return (v: string): ((arg0: UH0_$union) => UH0_$union) => closure5(undefined, v);
}

export function method5(v0_1_mut: string, v1_1_mut: string, v2_1_mut: UH0_$union, v3_1_mut: US2_$union): [string, string] {
    method5:
    while (true) {
        const v0_1: string = v0_1_mut, v1_1: string = v1_1_mut, v2_1: UH0_$union = v2_1_mut, v3_1: US2_$union = v3_1_mut;
        if (v2_1.tag === /* UH0_1 */ 1) {
            const v5_1: UH0_$union = v2_1.fields[1];
            const v4_1: string = v2_1.fields[0];
            switch (v4_1) {
                case "\"":
                    if (v1_1 === "") {
                        v0_1_mut = v0_1;
                        v1_1_mut = v1_1;
                        v2_1_mut = v5_1;
                        v3_1_mut = US2_US2_1(US3_US3_0());
                        continue method5;
                    }
                    else {
                        switch (v3_1.tag) {
                            case /* US2_1 */ 1:
                                if (v3_1.fields[0].tag === /* US3_0 */ 0) {
                                    v0_1_mut = v0_1;
                                    v1_1_mut = v1_1;
                                    v2_1_mut = v5_1;
                                    v3_1_mut = US2_US2_1(US3_US3_1());
                                    continue method5;
                                }
                                else if (" " === v4_1) {
                                    v0_1_mut = v0_1;
                                    v1_1_mut = v1_1;
                                    v2_1_mut = v5_1;
                                    v3_1_mut = US2_US2_2();
                                    continue method5;
                                }
                                else {
                                    v0_1_mut = v0_1;
                                    v1_1_mut = (`${v1_1}${v4_1}`);
                                    v2_1_mut = v5_1;
                                    v3_1_mut = v3_1;
                                    continue method5;
                                }
                            case /* US2_0 */ 0:
                                if (" " === v4_1) {
                                    v0_1_mut = v0_1;
                                    v1_1_mut = v1_1;
                                    v2_1_mut = v5_1;
                                    v3_1_mut = US2_US2_2();
                                    continue method5;
                                }
                                else {
                                    v0_1_mut = v0_1;
                                    v1_1_mut = (`${v1_1}${v4_1}`);
                                    v2_1_mut = v5_1;
                                    v3_1_mut = v3_1;
                                    continue method5;
                                }
                            default: {
                                v0_1_mut = (`${v0_1}${v4_1}`);
                                v1_1_mut = v1_1;
                                v2_1_mut = v5_1;
                                v3_1_mut = US2_US2_2();
                                continue method5;
                            }
                        }
                    }
                case "\'":
                    if (v1_1 === "") {
                        v0_1_mut = v0_1;
                        v1_1_mut = v1_1;
                        v2_1_mut = v5_1;
                        v3_1_mut = US2_US2_1(US3_US3_0());
                        continue method5;
                    }
                    else {
                        switch (v3_1.tag) {
                            case /* US2_1 */ 1:
                                if (v3_1.fields[0].tag === /* US3_0 */ 0) {
                                    v0_1_mut = v0_1;
                                    v1_1_mut = v1_1;
                                    v2_1_mut = v5_1;
                                    v3_1_mut = US2_US2_1(US3_US3_1());
                                    continue method5;
                                }
                                else if (" " === v4_1) {
                                    v0_1_mut = v0_1;
                                    v1_1_mut = v1_1;
                                    v2_1_mut = v5_1;
                                    v3_1_mut = US2_US2_2();
                                    continue method5;
                                }
                                else {
                                    v0_1_mut = v0_1;
                                    v1_1_mut = (`${v1_1}${v4_1}`);
                                    v2_1_mut = v5_1;
                                    v3_1_mut = v3_1;
                                    continue method5;
                                }
                            case /* US2_0 */ 0:
                                if (" " === v4_1) {
                                    v0_1_mut = v0_1;
                                    v1_1_mut = v1_1;
                                    v2_1_mut = v5_1;
                                    v3_1_mut = US2_US2_2();
                                    continue method5;
                                }
                                else {
                                    v0_1_mut = v0_1;
                                    v1_1_mut = (`${v1_1}${v4_1}`);
                                    v2_1_mut = v5_1;
                                    v3_1_mut = v3_1;
                                    continue method5;
                                }
                            default: {
                                v0_1_mut = (`${v0_1}${v4_1}`);
                                v1_1_mut = v1_1;
                                v2_1_mut = v5_1;
                                v3_1_mut = US2_US2_2();
                                continue method5;
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
                                    v2_1_mut = v5_1;
                                    v3_1_mut = US2_US2_1(US3_US3_0());
                                    continue method5;
                                }
                                else {
                                    v0_1_mut = v0_1;
                                    v1_1_mut = (`${v1_1}${v4_1}`);
                                    v2_1_mut = v5_1;
                                    v3_1_mut = v3_1;
                                    continue method5;
                                }
                            }
                            else if (" " === v4_1) {
                                v0_1_mut = v0_1;
                                v1_1_mut = v1_1;
                                v2_1_mut = v5_1;
                                v3_1_mut = US2_US2_2();
                                continue method5;
                            }
                            else {
                                v0_1_mut = v0_1;
                                v1_1_mut = (`${v1_1}${v4_1}`);
                                v2_1_mut = v5_1;
                                v3_1_mut = v3_1;
                                continue method5;
                            }
                        case /* US2_0 */ 0:
                            if (" " === v4_1) {
                                v0_1_mut = v0_1;
                                v1_1_mut = v1_1;
                                v2_1_mut = v5_1;
                                v3_1_mut = US2_US2_2();
                                continue method5;
                            }
                            else {
                                v0_1_mut = v0_1;
                                v1_1_mut = (`${v1_1}${v4_1}`);
                                v2_1_mut = v5_1;
                                v3_1_mut = v3_1;
                                continue method5;
                            }
                        default: {
                            v0_1_mut = (`${v0_1}${v4_1}`);
                            v1_1_mut = v1_1;
                            v2_1_mut = v5_1;
                            v3_1_mut = US2_US2_2();
                            continue method5;
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

export function closure7(unitVar: void, v0_1: string): US4_$union {
    return US4_US4_0(v0_1);
}

export function method6(): ((arg0: string) => US4_$union) {
    return (v: string): US4_$union => closure7(undefined, v);
}

export function closure8(v0_1: Option<any>, v1_1: string, v2_1: Option<((arg0: [boolean, string, int32]) => any)>, v3_1: Option<string>, unitVar: void): string {
    return toText(interpolate("execute_with_options_async / options: %A%P()", [[v0_1, v1_1, v2_1, v3_1] as [Option<any>, string, Option<((arg0: [boolean, string, int32]) => any)>, Option<string>]]));
}

export function closure9(unitVar: void, unitVar_1: void): string {
    return "";
}

export function method7(): (() => string) {
    return (): string => closure9(undefined, undefined);
}

export function closure11(unitVar: void, v0_1: int64): US5_$union {
    return US5_US5_0(v0_1);
}

export function method9(): ((arg0: int64) => US5_$union) {
    return (v: int64): US5_$union => closure11(undefined, v);
}

export function method10(): string {
    return "";
}

export function closure10(v0_1: US0_$union, v1_1: (() => string), v2_1: (() => string), unitVar: void): string {
    if (State_trace_state() == null) {
        State_trace_state(closure0(undefined, undefined));
    }
    const patternInput: [Mut0, Mut1, Mut2, Option<int64>, Mut3] = value_2(State_trace_state());
    let _v9: Option<string> = undefined;
    const x: string = method10();
    _v9 = x;
    const v61: string = value_2(_v9);
    const v62: int64 = patternInput[0].l0;
    const v72: string = (v0_1.tag === /* US0_1 */ 1) ? "Debug" : ((v0_1.tag === /* US0_2 */ 2) ? "Info" : ((v0_1.tag === /* US0_0 */ 0) ? "Verbose" : ((v0_1.tag === /* US0_3 */ 3) ? "Warning" : "Critical")));
    let _v75: Option<string> = undefined;
    const x_1: string = padRight(v72.toLocaleLowerCase(), 7, " ");
    _v75 = x_1;
    return trimEnd(trimStart(`${v61} ${value_2(_v75)} #${v62} ${v1_1()} / ${v2_1()}`), " ", "/");
}

export function method11(v0_1: US0_$union, v1_1: (() => string)): void {
    const v2_1 = (): [Mut0, Mut1, Mut2, Option<int64>, Mut3] => closure0(undefined, undefined);
    if (State_trace_state() == null) {
        State_trace_state(v2_1());
    }
    const patternInput: [Mut0, Mut1, Mut2, Option<int64>, Mut3] = value_2(State_trace_state());
    const v3_1: Mut0 = patternInput[0];
    if (State_trace_state() == null) {
        State_trace_state(v2_1());
    }
    const patternInput_1: [Mut0, Mut1, Mut2, Option<int64>, Mut3] = value_2(State_trace_state());
    const v13: US0_$union = patternInput_1[2].l0;
    if ((patternInput_1[1].l0 === false) ? false : (find<US0_$union, int32>(v0_1, ofSeq([[US0_US0_0(), 0] as [US0_$union, int32], [US0_US0_1(), 1] as [US0_$union, int32], [US0_US0_2(), 2] as [US0_$union, int32], [US0_US0_3(), 3] as [US0_$union, int32], [US0_US0_4(), 4] as [US0_$union, int32]], {
        Compare: compare,
    })) >= find<US0_$union, int32>(v13, ofSeq([[US0_US0_0(), 0] as [US0_$union, int32], [US0_US0_1(), 1] as [US0_$union, int32], [US0_US0_2(), 2] as [US0_$union, int32], [US0_US0_3(), 3] as [US0_$union, int32], [US0_US0_4(), 4] as [US0_$union, int32]], {
        Compare: compare,
    })))) {
        const v21: int64 = toInt64(op_Addition(v3_1.l0, 1n));
        v3_1.l0 = v21;
        const v22 = `${v1_1()}`;
        let _v23: Option<void> = undefined;
        console.log(v22);
        _v23 = some(undefined);
        value_2(_v23);
        patternInput[4].l0(v22);
    }
}

export function method8(v0_1: US0_$union, v1_1: (() => string), v2_1: (() => string)): void {
    method11(v0_1, (): string => closure10(v0_1, v1_1, v2_1, undefined));
}

export function closure13(unitVar: void, v0_1: ((arg0: [boolean, string, int32]) => any)): US6_$union {
    return US6_US6_0(v0_1);
}

export function method12(): ((arg0: ((arg0: [boolean, string, int32]) => any)) => US6_$union) {
    return (v: ((arg0: [boolean, string, int32]) => any)): US6_$union => closure13(undefined, v);
}

export function closure14(v0_1: string, unitVar: void): string {
    return `> ${v0_1}`;
}

export function closure12(v0_1: Option<any>, v1_1: string, v2_1: Option<((arg0: [boolean, string, int32]) => any)>, v3_1: Option<string>, v4_1: void, v5_1: any, v6: void): void {
    let _v7: Option<any> = undefined;
    const x: any = defaultOf();
    _v7 = x;
    const v32: any = value_2(_v7);
    let _v33: Option<void> = undefined;
    defaultOf();
    _v33 = some(undefined);
    value_2(_v33);
}

export function closure15(v0_1: Option<any>, v1_1: string, v2_1: Option<((arg0: [boolean, string, int32]) => any)>, v3_1: Option<string>, v4_1: void, v5_1: any, v6: void): void {
    let _v7: Option<any> = undefined;
    const x: any = defaultOf();
    _v7 = x;
    const v33: any = value_2(_v7);
    let _v34: Option<void> = undefined;
    defaultOf();
    _v34 = some(undefined);
    value_2(_v34);
}

export function closure16(unitVar: void, v0_1: any): US7_$union {
    return US7_US7_0(v0_1);
}

export function method13(): ((arg0: any) => US7_$union) {
    return (v: any): US7_$union => closure16(undefined, v);
}

export function closure17(v0_1: void, unitVar: void): void {
    let _v1: Option<boolean> = undefined;
    const x: boolean = defaultOf();
    _v1 = x;
    if (value_2(_v1) === false) {
        let _v11: Option<void> = undefined;
        defaultOf();
        _v11 = some(undefined);
        value_2(_v11);
    }
}

export function closure18(v0_1: any, unitVar: void): string {
    return toText(interpolate("execute_with_options_async / WaitForExitAsync / ex: %A%P()", [v0_1]));
}

export function method14(): string {
    return "\n";
}

export function closure19(v0_1: int32, v1_1: string, unitVar: void): string {
    return `execute_with_options_async / exit_code: ${v0_1} / output.Length: ${v1_1.length}`;
}

export function closure4(unitVar: void, v0_1: string): any {
    let _v4: Option<any> = undefined;
    const x: any = defaultOf();
    _v4 = x;
    return value_2(_v4);
}

export function closure20(unitVar: void, _arg: [Option<any>, string, Option<((arg0: [boolean, string, int32]) => any)>, Option<string>]): any {
    let _v4: Option<any> = undefined;
    const x: any = defaultOf();
    _v4 = x;
    return value_2(_v4);
}

export function method18(v0_1: UH1_$union, v1_1: UH1_$union): UH1_$union {
    if (v0_1.tag === /* UH1_0 */ 0) {
        return v1_1;
    }
    else {
        return UH1_UH1_1(v0_1.fields[0], method18(v0_1.fields[1], v1_1));
    }
}

export function method17(v0_1_mut: string, v1_1_mut: UH1_$union, v2_1_mut: UH0_$union, v3_1_mut: US8_$union): [UH1_$union, string] {
    method17:
    while (true) {
        const v0_1: string = v0_1_mut, v1_1: UH1_$union = v1_1_mut, v2_1: UH0_$union = v2_1_mut, v3_1: US8_$union = v3_1_mut;
        switch (v3_1.tag) {
            case /* US8_1 */ 1: {
                const v105: string = v3_1.fields[0];
                switch (v105) {
                    case "\"":
                        if (v2_1.tag === /* UH0_1 */ 1) {
                            const v108: UH0_$union = v2_1.fields[1];
                            const v107: string = v2_1.fields[0];
                            if ("\"" === v107) {
                                if (equals(v3_1, US8_US8_1("\\"))) {
                                    return method16(v0_1, v1_1, v108, v3_1, US8_US8_0());
                                }
                                else if ("\\" === v105) {
                                    if (!equals(v3_1, US8_US8_2(0))) {
                                        return method16(`${v0_1}"`, v1_1, v108, v3_1, US8_US8_1("\""));
                                    }
                                    else if (equals(v3_1, US8_US8_1("\\"))) {
                                        return method16(`${v0_1}"`, v1_1, v108, v3_1, US8_US8_1("\""));
                                    }
                                    else {
                                        return method16(v0_1, v1_1, v108, v3_1, US8_US8_0());
                                    }
                                }
                                else if ("\\" === v107) {
                                    return method16(v0_1, v1_1, v108, v3_1, US8_US8_2(1));
                                }
                                else if (equals(v3_1, US8_US8_2(0))) {
                                    return method16(`${v0_1}"`, v1_1, v108, v3_1, US8_US8_1("\""));
                                }
                                else {
                                    return method16("", method18(v1_1, UH1_UH1_1(v0_1, UH1_UH1_0())), v108, v3_1, US8_US8_0());
                                }
                            }
                            else if ("\\" === v105) {
                                switch (v107) {
                                    case "\\":
                                        return method16(v0_1, v1_1, v108, v3_1, US8_US8_2(1));
                                    case " ": {
                                        v0_1_mut = (`${v0_1} `);
                                        v1_1_mut = v1_1;
                                        v2_1_mut = v108;
                                        v3_1_mut = v3_1;
                                        continue method17;
                                    }
                                    default: {
                                        v0_1_mut = (`${v0_1}${v107}`);
                                        v1_1_mut = v1_1;
                                        v2_1_mut = v108;
                                        v3_1_mut = v3_1;
                                        continue method17;
                                    }
                                }
                            }
                            else {
                                switch (v107) {
                                    case "\\":
                                        return method16(v0_1, v1_1, v108, v3_1, US8_US8_2(1));
                                    case " ": {
                                        v0_1_mut = (`${v0_1} `);
                                        v1_1_mut = v1_1;
                                        v2_1_mut = v108;
                                        v3_1_mut = v3_1;
                                        continue method17;
                                    }
                                    default: {
                                        v0_1_mut = (`${v0_1}${v107}`);
                                        v1_1_mut = v1_1;
                                        v2_1_mut = v108;
                                        v3_1_mut = v3_1;
                                        continue method17;
                                    }
                                }
                            }
                        }
                        else if ("\\" === v105) {
                            return [(v0_1 === "") ? v1_1 : method18(v1_1, UH1_UH1_1(v0_1, UH1_UH1_0())), v0_1] as [UH1_$union, string];
                        }
                        else {
                            return [(v0_1 === "") ? v1_1 : method18(v1_1, UH1_UH1_1(v0_1, UH1_UH1_0())), v0_1] as [UH1_$union, string];
                        }
                    case "\\":
                        if (v2_1.tag === /* UH0_1 */ 1) {
                            const v220: UH0_$union = v2_1.fields[1];
                            const v219: string = v2_1.fields[0];
                            switch (v219) {
                                case "\"":
                                    if (!equals(v3_1, US8_US8_2(0))) {
                                        return method16(`${v0_1}"`, v1_1, v220, v3_1, US8_US8_1("\""));
                                    }
                                    else if (equals(v3_1, US8_US8_1("\\"))) {
                                        return method16(`${v0_1}"`, v1_1, v220, v3_1, US8_US8_1("\""));
                                    }
                                    else {
                                        return method16(v0_1, v1_1, v220, v3_1, US8_US8_0());
                                    }
                                case "\\":
                                    return method16(v0_1, v1_1, v220, v3_1, US8_US8_2(1));
                                case " ": {
                                    v0_1_mut = (`${v0_1} `);
                                    v1_1_mut = v1_1;
                                    v2_1_mut = v220;
                                    v3_1_mut = v3_1;
                                    continue method17;
                                }
                                default: {
                                    v0_1_mut = (`${v0_1}${v219}`);
                                    v1_1_mut = v1_1;
                                    v2_1_mut = v220;
                                    v3_1_mut = v3_1;
                                    continue method17;
                                }
                            }
                        }
                        else {
                            return [(v0_1 === "") ? v1_1 : method18(v1_1, UH1_UH1_1(v0_1, UH1_UH1_0())), v0_1] as [UH1_$union, string];
                        }
                    default:
                        if (v2_1.tag === /* UH0_1 */ 1) {
                            const v270: UH0_$union = v2_1.fields[1];
                            const v269: string = v2_1.fields[0];
                            switch (v269) {
                                case "\\":
                                    return method16(v0_1, v1_1, v270, v3_1, US8_US8_2(1));
                                case "\"":
                                    if (equals(v3_1, US8_US8_2(0))) {
                                        return method16(`${v0_1}"`, v1_1, v270, v3_1, US8_US8_1("\""));
                                    }
                                    else {
                                        return method16("", method18(v1_1, UH1_UH1_1(v0_1, UH1_UH1_0())), v270, v3_1, US8_US8_0());
                                    }
                                case " ": {
                                    v0_1_mut = (`${v0_1} `);
                                    v1_1_mut = v1_1;
                                    v2_1_mut = v270;
                                    v3_1_mut = v3_1;
                                    continue method17;
                                }
                                default: {
                                    v0_1_mut = (`${v0_1}${v269}`);
                                    v1_1_mut = v1_1;
                                    v2_1_mut = v270;
                                    v3_1_mut = v3_1;
                                    continue method17;
                                }
                            }
                        }
                        else {
                            return [(v0_1 === "") ? v1_1 : method18(v1_1, UH1_UH1_1(v0_1, UH1_UH1_0())), v0_1] as [UH1_$union, string];
                        }
                }
            }
            case /* US8_0 */ 0:
                if (v2_1.tag === /* UH0_1 */ 1) {
                    const v5_1: UH0_$union = v2_1.fields[1];
                    const v4_1: string = v2_1.fields[0];
                    switch (v4_1) {
                        case "\"":
                            return method16("", v1_1, v5_1, v3_1, US8_US8_1("\""));
                        case "\\":
                            return method16(v0_1, v1_1, v5_1, v3_1, US8_US8_2(0));
                        case " ": {
                            v0_1_mut = "";
                            v1_1_mut = ((v0_1 === "") ? v1_1 : method18(v1_1, UH1_UH1_1(v0_1, UH1_UH1_0())));
                            v2_1_mut = v5_1;
                            v3_1_mut = v3_1;
                            continue method17;
                        }
                        default: {
                            v0_1_mut = (`${v0_1}${v4_1}`);
                            v1_1_mut = v1_1;
                            v2_1_mut = v5_1;
                            v3_1_mut = v3_1;
                            continue method17;
                        }
                    }
                }
                else {
                    return [(v0_1 === "") ? v1_1 : method18(v1_1, UH1_UH1_1(v0_1, UH1_UH1_0())), v0_1] as [UH1_$union, string];
                }
            default: {
                const v44: uint8 = v3_1.fields[0];
                if (v2_1.tag === /* UH0_1 */ 1) {
                    const v46: UH0_$union = v2_1.fields[1];
                    const v45: string = v2_1.fields[0];
                    switch (v45) {
                        case "\\":
                            return method16(v0_1, v1_1, v46, v3_1, US8_US8_1("\\"));
                        case "\"":
                            if (v3_1.tag === /* US8_0 */ 0) {
                                v0_1_mut = v0_1;
                                v1_1_mut = v1_1;
                                v2_1_mut = v46;
                                v3_1_mut = v3_1;
                                continue method17;
                            }
                            else {
                                return method16(`${v0_1}"`, v1_1, v46, v3_1, US8_US8_2(v44));
                            }
                        case " ": {
                            v0_1_mut = (`${v0_1} `);
                            v1_1_mut = v1_1;
                            v2_1_mut = v46;
                            v3_1_mut = v3_1;
                            continue method17;
                        }
                        default:
                            if (1 === v44) {
                                if (!equals(v3_1, v3_1)) {
                                    v0_1_mut = (`${v0_1}\\${v45}`);
                                    v1_1_mut = v1_1;
                                    v2_1_mut = v46;
                                    v3_1_mut = v3_1;
                                    continue method17;
                                }
                                else {
                                    v0_1_mut = (`${v0_1}${v45}`);
                                    v1_1_mut = v1_1;
                                    v2_1_mut = v46;
                                    v3_1_mut = v3_1;
                                    continue method17;
                                }
                            }
                            else {
                                v0_1_mut = (`${v0_1}${v45}`);
                                v1_1_mut = v1_1;
                                v2_1_mut = v46;
                                v3_1_mut = v3_1;
                                continue method17;
                            }
                    }
                }
                else if (1 === v44) {
                    return [(v0_1 === "") ? v1_1 : method18(v1_1, UH1_UH1_1(v0_1, UH1_UH1_0())), v0_1] as [UH1_$union, string];
                }
                else {
                    return [(v0_1 === "") ? v1_1 : method18(v1_1, UH1_UH1_1(v0_1, UH1_UH1_0())), v0_1] as [UH1_$union, string];
                }
            }
        }
        break;
    }
}

export function method16(v0_1_mut: string, v1_1_mut: UH1_$union, v2_1_mut: UH0_$union, v3_1_mut: US8_$union, v4_1_mut: US8_$union): [UH1_$union, string] {
    method16:
    while (true) {
        const v0_1: string = v0_1_mut, v1_1: UH1_$union = v1_1_mut, v2_1: UH0_$union = v2_1_mut, v3_1: US8_$union = v3_1_mut, v4_1: US8_$union = v4_1_mut;
        switch (v4_1.tag) {
            case /* US8_1 */ 1: {
                const v106: string = v4_1.fields[0];
                switch (v106) {
                    case "\"":
                        if (v2_1.tag === /* UH0_1 */ 1) {
                            const v109: UH0_$union = v2_1.fields[1];
                            const v108: string = v2_1.fields[0];
                            if ("\"" === v108) {
                                if (equals(v3_1, US8_US8_1("\\"))) {
                                    v0_1_mut = v0_1;
                                    v1_1_mut = v1_1;
                                    v2_1_mut = v109;
                                    v3_1_mut = v4_1;
                                    v4_1_mut = US8_US8_0();
                                    continue method16;
                                }
                                else if ("\\" === v106) {
                                    if (!equals(v3_1, US8_US8_2(0))) {
                                        v0_1_mut = (`${v0_1}"`);
                                        v1_1_mut = v1_1;
                                        v2_1_mut = v109;
                                        v3_1_mut = v4_1;
                                        v4_1_mut = US8_US8_1("\"");
                                        continue method16;
                                    }
                                    else if (equals(v3_1, US8_US8_1("\\"))) {
                                        v0_1_mut = (`${v0_1}"`);
                                        v1_1_mut = v1_1;
                                        v2_1_mut = v109;
                                        v3_1_mut = v4_1;
                                        v4_1_mut = US8_US8_1("\"");
                                        continue method16;
                                    }
                                    else {
                                        v0_1_mut = v0_1;
                                        v1_1_mut = v1_1;
                                        v2_1_mut = v109;
                                        v3_1_mut = v4_1;
                                        v4_1_mut = US8_US8_0();
                                        continue method16;
                                    }
                                }
                                else if ("\\" === v108) {
                                    v0_1_mut = v0_1;
                                    v1_1_mut = v1_1;
                                    v2_1_mut = v109;
                                    v3_1_mut = v4_1;
                                    v4_1_mut = US8_US8_2(1);
                                    continue method16;
                                }
                                else if (equals(v3_1, US8_US8_2(0))) {
                                    v0_1_mut = (`${v0_1}"`);
                                    v1_1_mut = v1_1;
                                    v2_1_mut = v109;
                                    v3_1_mut = v4_1;
                                    v4_1_mut = US8_US8_1("\"");
                                    continue method16;
                                }
                                else {
                                    v0_1_mut = "";
                                    v1_1_mut = method18(v1_1, UH1_UH1_1(v0_1, UH1_UH1_0()));
                                    v2_1_mut = v109;
                                    v3_1_mut = v4_1;
                                    v4_1_mut = US8_US8_0();
                                    continue method16;
                                }
                            }
                            else if ("\\" === v106) {
                                switch (v108) {
                                    case "\\": {
                                        v0_1_mut = v0_1;
                                        v1_1_mut = v1_1;
                                        v2_1_mut = v109;
                                        v3_1_mut = v4_1;
                                        v4_1_mut = US8_US8_2(1);
                                        continue method16;
                                    }
                                    case " ":
                                        return method17(`${v0_1} `, v1_1, v109, v4_1);
                                    default:
                                        return method17(`${v0_1}${v108}`, v1_1, v109, v4_1);
                                }
                            }
                            else {
                                switch (v108) {
                                    case "\\": {
                                        v0_1_mut = v0_1;
                                        v1_1_mut = v1_1;
                                        v2_1_mut = v109;
                                        v3_1_mut = v4_1;
                                        v4_1_mut = US8_US8_2(1);
                                        continue method16;
                                    }
                                    case " ":
                                        return method17(`${v0_1} `, v1_1, v109, v4_1);
                                    default:
                                        return method17(`${v0_1}${v108}`, v1_1, v109, v4_1);
                                }
                            }
                        }
                        else if ("\\" === v106) {
                            return [(v0_1 === "") ? v1_1 : method18(v1_1, UH1_UH1_1(v0_1, UH1_UH1_0())), v0_1] as [UH1_$union, string];
                        }
                        else {
                            return [(v0_1 === "") ? v1_1 : method18(v1_1, UH1_UH1_1(v0_1, UH1_UH1_0())), v0_1] as [UH1_$union, string];
                        }
                    case "\\":
                        if (v2_1.tag === /* UH0_1 */ 1) {
                            const v221: UH0_$union = v2_1.fields[1];
                            const v220: string = v2_1.fields[0];
                            switch (v220) {
                                case "\"":
                                    if (!equals(v3_1, US8_US8_2(0))) {
                                        v0_1_mut = (`${v0_1}"`);
                                        v1_1_mut = v1_1;
                                        v2_1_mut = v221;
                                        v3_1_mut = v4_1;
                                        v4_1_mut = US8_US8_1("\"");
                                        continue method16;
                                    }
                                    else if (equals(v3_1, US8_US8_1("\\"))) {
                                        v0_1_mut = (`${v0_1}"`);
                                        v1_1_mut = v1_1;
                                        v2_1_mut = v221;
                                        v3_1_mut = v4_1;
                                        v4_1_mut = US8_US8_1("\"");
                                        continue method16;
                                    }
                                    else {
                                        v0_1_mut = v0_1;
                                        v1_1_mut = v1_1;
                                        v2_1_mut = v221;
                                        v3_1_mut = v4_1;
                                        v4_1_mut = US8_US8_0();
                                        continue method16;
                                    }
                                case "\\": {
                                    v0_1_mut = v0_1;
                                    v1_1_mut = v1_1;
                                    v2_1_mut = v221;
                                    v3_1_mut = v4_1;
                                    v4_1_mut = US8_US8_2(1);
                                    continue method16;
                                }
                                case " ":
                                    return method17(`${v0_1} `, v1_1, v221, v4_1);
                                default:
                                    return method17(`${v0_1}${v220}`, v1_1, v221, v4_1);
                            }
                        }
                        else {
                            return [(v0_1 === "") ? v1_1 : method18(v1_1, UH1_UH1_1(v0_1, UH1_UH1_0())), v0_1] as [UH1_$union, string];
                        }
                    default:
                        if (v2_1.tag === /* UH0_1 */ 1) {
                            const v271: UH0_$union = v2_1.fields[1];
                            const v270: string = v2_1.fields[0];
                            switch (v270) {
                                case "\\": {
                                    v0_1_mut = v0_1;
                                    v1_1_mut = v1_1;
                                    v2_1_mut = v271;
                                    v3_1_mut = v4_1;
                                    v4_1_mut = US8_US8_2(1);
                                    continue method16;
                                }
                                case "\"":
                                    if (equals(v3_1, US8_US8_2(0))) {
                                        v0_1_mut = (`${v0_1}"`);
                                        v1_1_mut = v1_1;
                                        v2_1_mut = v271;
                                        v3_1_mut = v4_1;
                                        v4_1_mut = US8_US8_1("\"");
                                        continue method16;
                                    }
                                    else {
                                        v0_1_mut = "";
                                        v1_1_mut = method18(v1_1, UH1_UH1_1(v0_1, UH1_UH1_0()));
                                        v2_1_mut = v271;
                                        v3_1_mut = v4_1;
                                        v4_1_mut = US8_US8_0();
                                        continue method16;
                                    }
                                case " ":
                                    return method17(`${v0_1} `, v1_1, v271, v4_1);
                                default:
                                    return method17(`${v0_1}${v270}`, v1_1, v271, v4_1);
                            }
                        }
                        else {
                            return [(v0_1 === "") ? v1_1 : method18(v1_1, UH1_UH1_1(v0_1, UH1_UH1_0())), v0_1] as [UH1_$union, string];
                        }
                }
            }
            case /* US8_0 */ 0:
                if (v2_1.tag === /* UH0_1 */ 1) {
                    const v6: UH0_$union = v2_1.fields[1];
                    const v5_1: string = v2_1.fields[0];
                    switch (v5_1) {
                        case "\"": {
                            v0_1_mut = "";
                            v1_1_mut = v1_1;
                            v2_1_mut = v6;
                            v3_1_mut = v4_1;
                            v4_1_mut = US8_US8_1("\"");
                            continue method16;
                        }
                        case "\\": {
                            v0_1_mut = v0_1;
                            v1_1_mut = v1_1;
                            v2_1_mut = v6;
                            v3_1_mut = v4_1;
                            v4_1_mut = US8_US8_2(0);
                            continue method16;
                        }
                        case " ":
                            return method17("", (v0_1 === "") ? v1_1 : method18(v1_1, UH1_UH1_1(v0_1, UH1_UH1_0())), v6, v4_1);
                        default:
                            return method17(`${v0_1}${v5_1}`, v1_1, v6, v4_1);
                    }
                }
                else {
                    return [(v0_1 === "") ? v1_1 : method18(v1_1, UH1_UH1_1(v0_1, UH1_UH1_0())), v0_1] as [UH1_$union, string];
                }
            default: {
                const v45: uint8 = v4_1.fields[0];
                if (v2_1.tag === /* UH0_1 */ 1) {
                    const v47: UH0_$union = v2_1.fields[1];
                    const v46: string = v2_1.fields[0];
                    switch (v46) {
                        case "\\": {
                            v0_1_mut = v0_1;
                            v1_1_mut = v1_1;
                            v2_1_mut = v47;
                            v3_1_mut = v4_1;
                            v4_1_mut = US8_US8_1("\\");
                            continue method16;
                        }
                        case "\"":
                            if (v3_1.tag === /* US8_0 */ 0) {
                                return method17(v0_1, v1_1, v47, v4_1);
                            }
                            else {
                                v0_1_mut = (`${v0_1}"`);
                                v1_1_mut = v1_1;
                                v2_1_mut = v47;
                                v3_1_mut = v4_1;
                                v4_1_mut = US8_US8_2(v45);
                                continue method16;
                            }
                        case " ":
                            return method17(`${v0_1} `, v1_1, v47, v4_1);
                        default:
                            if (1 === v45) {
                                if (!equals(v3_1, v4_1)) {
                                    v0_1_mut = (`${v0_1}\\${v46}`);
                                    v1_1_mut = v1_1;
                                    v2_1_mut = v47;
                                    v3_1_mut = v4_1;
                                    v4_1_mut = v3_1;
                                    continue method16;
                                }
                                else {
                                    return method17(`${v0_1}${v46}`, v1_1, v47, v4_1);
                                }
                            }
                            else {
                                return method17(`${v0_1}${v46}`, v1_1, v47, v4_1);
                            }
                    }
                }
                else if (1 === v45) {
                    return [(v0_1 === "") ? v1_1 : method18(v1_1, UH1_UH1_1(v0_1, UH1_UH1_0())), v0_1] as [UH1_$union, string];
                }
                else {
                    return [(v0_1 === "") ? v1_1 : method18(v1_1, UH1_UH1_1(v0_1, UH1_UH1_0())), v0_1] as [UH1_$union, string];
                }
            }
        }
        break;
    }
}

export function method19(v0_1: UH1_$union, v1_1: FSharpList<string>): FSharpList<string> {
    if (v0_1.tag === /* UH1_0 */ 0) {
        return v1_1;
    }
    else {
        return cons(v0_1.fields[0], method19(v0_1.fields[1], v1_1));
    }
}

export function method15(v0_1: string): string[] {
    let _v0: Option<Option<string>> = undefined;
    _v0 = some(v0_1);
    const v6: Option<string> = value_2(_v0);
    const v9: US4_$union = defaultArg(map<string, US4_$union>(method6(), v6), US4_US4_1());
    const v12: string = (v9.tag === /* US4_0 */ 0) ? v9.fields[0] : "";
    const v13: int32 = v12.length | 0;
    const v14: string[] = fill(new Array(v13), 0, v13, "");
    const v15: Mut4 = new Mut4(0);
    while (method3(v13, v15)) {
        const v17: int32 = v15.l0 | 0;
        const v18: string = v12[v17];
        setItem(v14, v17, v18);
        const v19: int32 = (v17 + 1) | 0;
        v15.l0 = (v19 | 0);
    }
    const v21: FSharpList<string> = ofArray<string>(v14);
    return toArray<string>(method19(method16("", UH1_UH1_0(), foldBack<string, UH0_$union>(uncurry2(method4()), v21, UH0_UH0_0()), US8_US8_0(), US8_US8_0())[0], empty<string>()));
}

export function closure21(unitVar: void, v0_1: string): string[] {
    return method15(v0_1);
}

export const v0 = (): [Mut0, Mut1, Mut2, Option<int64>, Mut3] => closure0(undefined, undefined);

if (State_trace_state() == null) {
    State_trace_state(v0());
}

export const v1 = (): boolean => closure2(undefined, undefined);

export function is_windows(): boolean {
    return v1();
}

export const v2 = (): string => closure3(undefined, undefined);

export function get_executable_suffix(): string {
    return v2();
}

export const v3 = (v: string): any => closure4(undefined, v);

export function execute_async(x: string): any {
    return v3(x);
}

export const v4 = (arg10$0040: [Option<any>, string, Option<((arg0: [boolean, string, int32]) => any)>, Option<string>]): any => closure20(undefined, arg10$0040);

export function execute_with_options_async(x: [Option<any>, string, Option<((arg0: [boolean, string, int32]) => any)>, Option<string>]): any {
    return v4(x);
}

export const v5 = (v: string): string[] => closure21(undefined, v);

export function split_args(x: string): string[] {
    return v5(x);
}


