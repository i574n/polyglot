import { uncurry2, equals, compare, defaultOf, IComparable, IEquatable, createAtom } from "../../deps/Fable/src/fable-library-ts/Util.js";
import { defaultArg, value as value_2, some, Option } from "../../deps/Fable/src/fable-library-ts/Option.js";
import { op_Addition, toInt64, int64 } from "../../deps/Fable/src/fable-library-ts/BigInt.js";
import { FSharpRef, Union, Record } from "../../deps/Fable/src/fable-library-ts/Types.js";
import { uint8_type, array_type, option_type, class_type, tuple_type, char_type, int32_type, lambda_type, unit_type, string_type, union_type, bool_type, record_type, int64_type, TypeInfo } from "../../deps/Fable/src/fable-library-ts/Reflection.js";
import { uint8, int32 } from "../../deps/Fable/src/fable-library-ts/Int32.js";
import { trimStart, trimEnd, padLeft, interpolate, toText, replace } from "../../deps/Fable/src/fable-library-ts/String.js";
import { ofSeq, find } from "../../deps/Fable/src/fable-library-ts/Map.js";
import { empty, foldBack, toArray, ofArray, FSharpList, cons } from "../../deps/Fable/src/fable-library-ts/List.js";
import { setItem, fill } from "../../deps/Fable/src/fable-library-ts/Array.js";

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

export class Heap0 extends Record {
    readonly l0: Option<any>;
    readonly l1: string;
    readonly l2: [string, string][];
    readonly l3: Option<((arg0: [boolean, string, int32]) => any)>;
    readonly l4: Option<((arg0: any) => void)>;
    readonly l5: Option<string>;
    constructor(l0: Option<any>, l1: string, l2: [string, string][], l3: Option<((arg0: [boolean, string, int32]) => any)>, l4: Option<((arg0: any) => void)>, l5: Option<string>) {
        super();
        this.l0 = l0;
        this.l1 = l1;
        this.l2 = l2;
        this.l3 = l3;
        this.l4 = l4;
        this.l5 = l5;
    }
}

export function Heap0_$reflection(): TypeInfo {
    return record_type("Runtime.Heap0", [], Heap0, () => [["l0", option_type(class_type("System.Threading.CancellationToken"))], ["l1", string_type], ["l2", array_type(tuple_type(string_type, string_type))], ["l3", option_type(lambda_type(tuple_type(bool_type, string_type, int32_type), class_type("Microsoft.FSharp.Control.FSharpAsync`1", [unit_type])))], ["l4", option_type(lambda_type(string_type, unit_type))], ["l5", option_type(string_type)]]);
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

export function method3(): [string, string] {
    return ["", ""] as [string, string];
}

export function method4(v0_1: int32, v1_1: Mut4): boolean {
    return v1_1.l0 < v0_1;
}

export function closure6(v0_1: string, v1_1: UH0_$union): UH0_$union {
    return UH0_UH0_1(v0_1, v1_1);
}

export function closure5(unitVar: void, v0_1: string): ((arg0: UH0_$union) => UH0_$union) {
    return (v: UH0_$union): UH0_$union => closure6(v0_1, v);
}

export function method5(): ((arg0: string) => ((arg0: UH0_$union) => UH0_$union)) {
    return (v: string): ((arg0: UH0_$union) => UH0_$union) => closure5(undefined, v);
}

export function method6(v0_1_mut: string, v1_1_mut: string, v2_1_mut: UH0_$union, v3_1_mut: US2_$union): [string, string] {
    method6:
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
                        continue method6;
                    }
                    else {
                        switch (v3_1.tag) {
                            case /* US2_1 */ 1:
                                if (v3_1.fields[0].tag === /* US3_0 */ 0) {
                                    v0_1_mut = v0_1;
                                    v1_1_mut = v1_1;
                                    v2_1_mut = v5_1;
                                    v3_1_mut = US2_US2_1(US3_US3_1());
                                    continue method6;
                                }
                                else if (" " === v4_1) {
                                    v0_1_mut = v0_1;
                                    v1_1_mut = v1_1;
                                    v2_1_mut = v5_1;
                                    v3_1_mut = US2_US2_2();
                                    continue method6;
                                }
                                else {
                                    v0_1_mut = v0_1;
                                    v1_1_mut = (`${v1_1}${v4_1}`);
                                    v2_1_mut = v5_1;
                                    v3_1_mut = v3_1;
                                    continue method6;
                                }
                            case /* US2_0 */ 0:
                                if (" " === v4_1) {
                                    v0_1_mut = v0_1;
                                    v1_1_mut = v1_1;
                                    v2_1_mut = v5_1;
                                    v3_1_mut = US2_US2_2();
                                    continue method6;
                                }
                                else {
                                    v0_1_mut = v0_1;
                                    v1_1_mut = (`${v1_1}${v4_1}`);
                                    v2_1_mut = v5_1;
                                    v3_1_mut = v3_1;
                                    continue method6;
                                }
                            default: {
                                v0_1_mut = (`${v0_1}${v4_1}`);
                                v1_1_mut = v1_1;
                                v2_1_mut = v5_1;
                                v3_1_mut = US2_US2_2();
                                continue method6;
                            }
                        }
                    }
                case "\'":
                    if (v1_1 === "") {
                        v0_1_mut = v0_1;
                        v1_1_mut = v1_1;
                        v2_1_mut = v5_1;
                        v3_1_mut = US2_US2_1(US3_US3_0());
                        continue method6;
                    }
                    else {
                        switch (v3_1.tag) {
                            case /* US2_1 */ 1:
                                if (v3_1.fields[0].tag === /* US3_0 */ 0) {
                                    v0_1_mut = v0_1;
                                    v1_1_mut = v1_1;
                                    v2_1_mut = v5_1;
                                    v3_1_mut = US2_US2_1(US3_US3_1());
                                    continue method6;
                                }
                                else if (" " === v4_1) {
                                    v0_1_mut = v0_1;
                                    v1_1_mut = v1_1;
                                    v2_1_mut = v5_1;
                                    v3_1_mut = US2_US2_2();
                                    continue method6;
                                }
                                else {
                                    v0_1_mut = v0_1;
                                    v1_1_mut = (`${v1_1}${v4_1}`);
                                    v2_1_mut = v5_1;
                                    v3_1_mut = v3_1;
                                    continue method6;
                                }
                            case /* US2_0 */ 0:
                                if (" " === v4_1) {
                                    v0_1_mut = v0_1;
                                    v1_1_mut = v1_1;
                                    v2_1_mut = v5_1;
                                    v3_1_mut = US2_US2_2();
                                    continue method6;
                                }
                                else {
                                    v0_1_mut = v0_1;
                                    v1_1_mut = (`${v1_1}${v4_1}`);
                                    v2_1_mut = v5_1;
                                    v3_1_mut = v3_1;
                                    continue method6;
                                }
                            default: {
                                v0_1_mut = (`${v0_1}${v4_1}`);
                                v1_1_mut = v1_1;
                                v2_1_mut = v5_1;
                                v3_1_mut = US2_US2_2();
                                continue method6;
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
                                    continue method6;
                                }
                                else {
                                    v0_1_mut = v0_1;
                                    v1_1_mut = (`${v1_1}${v4_1}`);
                                    v2_1_mut = v5_1;
                                    v3_1_mut = v3_1;
                                    continue method6;
                                }
                            }
                            else if (" " === v4_1) {
                                v0_1_mut = v0_1;
                                v1_1_mut = v1_1;
                                v2_1_mut = v5_1;
                                v3_1_mut = US2_US2_2();
                                continue method6;
                            }
                            else {
                                v0_1_mut = v0_1;
                                v1_1_mut = (`${v1_1}${v4_1}`);
                                v2_1_mut = v5_1;
                                v3_1_mut = v3_1;
                                continue method6;
                            }
                        case /* US2_0 */ 0:
                            if (" " === v4_1) {
                                v0_1_mut = v0_1;
                                v1_1_mut = v1_1;
                                v2_1_mut = v5_1;
                                v3_1_mut = US2_US2_2();
                                continue method6;
                            }
                            else {
                                v0_1_mut = v0_1;
                                v1_1_mut = (`${v1_1}${v4_1}`);
                                v2_1_mut = v5_1;
                                v3_1_mut = v3_1;
                                continue method6;
                            }
                        default: {
                            v0_1_mut = (`${v0_1}${v4_1}`);
                            v1_1_mut = v1_1;
                            v2_1_mut = v5_1;
                            v3_1_mut = US2_US2_2();
                            continue method6;
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

export function closure7(v0_1: Option<any>, v1_1: string, v2_1: [string, string][], v3_1: Option<((arg0: [boolean, string, int32]) => any)>, v4_1: Option<((arg0: any) => void)>, v5_1: Option<string>, unitVar: void): string {
    return toText(interpolate("execute_with_options_async / options: %A%P()", [[v0_1, v1_1, v2_1, v3_1, v4_1, v5_1] as [Option<any>, string, [string, string][], Option<((arg0: [boolean, string, int32]) => any)>, Option<((arg0: any) => void)>, Option<string>]]));
}

export function closure8(unitVar: void, unitVar_1: void): string {
    return "";
}

export function method7(): (() => string) {
    return (): string => closure8(undefined, undefined);
}

export function method9(): string {
    return "";
}

export function closure9(v0_1: US0_$union, v1_1: (() => string), v2_1: (() => string), unitVar: void): string {
    if (State_trace_state() == null) {
        State_trace_state(closure0(undefined, undefined));
    }
    const patternInput: [Mut0, Mut1, Mut2, Option<int64>, Mut3] = value_2(State_trace_state());
    let _v9: Option<string> = undefined;
    const x: string = method9();
    _v9 = x;
    const v66: string = value_2(_v9);
    const v67: int64 = patternInput[0].l0;
    const v77: string = (v0_1.tag === /* US0_1 */ 1) ? "Debug" : ((v0_1.tag === /* US0_2 */ 2) ? "Info" : ((v0_1.tag === /* US0_0 */ 0) ? "Verbose" : ((v0_1.tag === /* US0_3 */ 3) ? "Warning" : "Critical")));
    let _v80: Option<string> = undefined;
    const x_1: string = padLeft(v77.toLocaleLowerCase(), 7, " ");
    _v80 = x_1;
    return trimEnd(trimStart(`${v66} ${value_2(_v80)} #${v67} ${v1_1()} / ${v2_1()}`), " ", "/");
}

export function method10(v0_1: US0_$union, v1_1: (() => string)): void {
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
    method10(v0_1, (): string => closure9(v0_1, v1_1, v2_1, undefined));
}

export function closure11(v0_1: string, unitVar: void): string {
    return `> ${v0_1}`;
}

export function closure10(v0_1: Option<any>, v1_1: string, v2_1: [string, string][], v3_1: Option<((arg0: [boolean, string, int32]) => any)>, v4_1: Option<((arg0: any) => void)>, v5_1: Option<string>, v6_1: void, v7: any, v8: void): void {
    let _v9: Option<any> = undefined;
    const x: any = defaultOf();
    _v9 = x;
    const v36: any = value_2(_v9);
    let _v37: Option<void> = undefined;
    defaultOf();
    _v37 = some(undefined);
    value_2(_v37);
}

export function closure12(v0_1: Option<any>, v1_1: string, v2_1: [string, string][], v3_1: Option<((arg0: [boolean, string, int32]) => any)>, v4_1: Option<((arg0: any) => void)>, v5_1: Option<string>, v6_1: void, v7: any, v8: void): void {
    let _v9: Option<any> = undefined;
    const x: any = defaultOf();
    _v9 = x;
    const v37: any = value_2(_v9);
    let _v38: Option<void> = undefined;
    defaultOf();
    _v38 = some(undefined);
    value_2(_v38);
}

export function closure13(v0_1: void, unitVar: void): void {
    let _v1: Option<boolean> = undefined;
    const x: boolean = defaultOf();
    _v1 = x;
    if (value_2(_v1) === false) {
        let _v10: Option<void> = undefined;
        defaultOf();
        _v10 = some(undefined);
        value_2(_v10);
    }
}

export function closure14(v0_1: any, unitVar: void): string {
    return toText(interpolate("execute_with_options_async / WaitForExitAsync / ex: %A%P()", [v0_1]));
}

export function method11(): string {
    return "\n";
}

export function closure15(v0_1: int32, v1_1: string, unitVar: void): string {
    return `execute_with_options_async / exit_code: ${v0_1} / output.Length: ${v1_1.length}`;
}

export function method2(v0_1: Option<any>, v1_1: string, v2_1: [string, string][], v3_1: Option<((arg0: [boolean, string, int32]) => any)>, v4_1: Option<((arg0: any) => void)>, v5_1: Option<string>): any {
    let _v6: Option<any> = undefined;
    const x: any = defaultOf();
    _v6 = x;
    return value_2(_v6);
}

export function closure4(unitVar: void, v0_1: string): any {
    return method2(undefined, v0_1, [], undefined, undefined, undefined);
}

export function closure16(unitVar: void, _arg: [Option<any>, string, [string, string][], Option<((arg0: [boolean, string, int32]) => any)>, Option<((arg0: any) => void)>, Option<string>]): any {
    return method2(_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5]);
}

export function closure17(unitVar: void, v0_1: ((arg0: Heap0) => Heap0)): [Option<any>, string, [string, string][], Option<((arg0: [boolean, string, int32]) => any)>, Option<((arg0: any) => void)>, Option<string>] {
    const v8: Heap0 = v0_1(new Heap0(undefined, "", [], undefined, undefined, undefined));
    return [v8.l0, v8.l1, v8.l2, v8.l3, v8.l4, v8.l5] as [Option<any>, string, [string, string][], Option<((arg0: [boolean, string, int32]) => any)>, Option<((arg0: any) => void)>, Option<string>];
}

export function method15(v0_1: UH1_$union, v1_1: UH1_$union): UH1_$union {
    if (v0_1.tag === /* UH1_0 */ 0) {
        return v1_1;
    }
    else {
        return UH1_UH1_1(v0_1.fields[0], method15(v0_1.fields[1], v1_1));
    }
}

export function method14(v0_1_mut: string, v1_1_mut: UH1_$union, v2_1_mut: UH0_$union, v3_1_mut: US8_$union): [UH1_$union, string] {
    method14:
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
                                    return method13(v0_1, v1_1, v108, v3_1, US8_US8_0());
                                }
                                else if ("\\" === v105) {
                                    if (!equals(v3_1, US8_US8_2(0))) {
                                        return method13(`${v0_1}"`, v1_1, v108, v3_1, US8_US8_1("\""));
                                    }
                                    else if (equals(v3_1, US8_US8_1("\\"))) {
                                        return method13(`${v0_1}"`, v1_1, v108, v3_1, US8_US8_1("\""));
                                    }
                                    else {
                                        return method13(v0_1, v1_1, v108, v3_1, US8_US8_0());
                                    }
                                }
                                else if ("\\" === v107) {
                                    return method13(v0_1, v1_1, v108, v3_1, US8_US8_2(1));
                                }
                                else if (equals(v3_1, US8_US8_2(0))) {
                                    return method13(`${v0_1}"`, v1_1, v108, v3_1, US8_US8_1("\""));
                                }
                                else {
                                    return method13("", method15(v1_1, UH1_UH1_1(v0_1, UH1_UH1_0())), v108, v3_1, US8_US8_0());
                                }
                            }
                            else if ("\\" === v105) {
                                switch (v107) {
                                    case "\\":
                                        return method13(v0_1, v1_1, v108, v3_1, US8_US8_2(1));
                                    case " ": {
                                        v0_1_mut = (`${v0_1} `);
                                        v1_1_mut = v1_1;
                                        v2_1_mut = v108;
                                        v3_1_mut = v3_1;
                                        continue method14;
                                    }
                                    default: {
                                        v0_1_mut = (`${v0_1}${v107}`);
                                        v1_1_mut = v1_1;
                                        v2_1_mut = v108;
                                        v3_1_mut = v3_1;
                                        continue method14;
                                    }
                                }
                            }
                            else {
                                switch (v107) {
                                    case "\\":
                                        return method13(v0_1, v1_1, v108, v3_1, US8_US8_2(1));
                                    case " ": {
                                        v0_1_mut = (`${v0_1} `);
                                        v1_1_mut = v1_1;
                                        v2_1_mut = v108;
                                        v3_1_mut = v3_1;
                                        continue method14;
                                    }
                                    default: {
                                        v0_1_mut = (`${v0_1}${v107}`);
                                        v1_1_mut = v1_1;
                                        v2_1_mut = v108;
                                        v3_1_mut = v3_1;
                                        continue method14;
                                    }
                                }
                            }
                        }
                        else if ("\\" === v105) {
                            return [(v0_1 === "") ? v1_1 : method15(v1_1, UH1_UH1_1(v0_1, UH1_UH1_0())), v0_1] as [UH1_$union, string];
                        }
                        else {
                            return [(v0_1 === "") ? v1_1 : method15(v1_1, UH1_UH1_1(v0_1, UH1_UH1_0())), v0_1] as [UH1_$union, string];
                        }
                    case "\\":
                        if (v2_1.tag === /* UH0_1 */ 1) {
                            const v220: UH0_$union = v2_1.fields[1];
                            const v219: string = v2_1.fields[0];
                            switch (v219) {
                                case "\"":
                                    if (!equals(v3_1, US8_US8_2(0))) {
                                        return method13(`${v0_1}"`, v1_1, v220, v3_1, US8_US8_1("\""));
                                    }
                                    else if (equals(v3_1, US8_US8_1("\\"))) {
                                        return method13(`${v0_1}"`, v1_1, v220, v3_1, US8_US8_1("\""));
                                    }
                                    else {
                                        return method13(v0_1, v1_1, v220, v3_1, US8_US8_0());
                                    }
                                case "\\":
                                    return method13(v0_1, v1_1, v220, v3_1, US8_US8_2(1));
                                case " ": {
                                    v0_1_mut = (`${v0_1} `);
                                    v1_1_mut = v1_1;
                                    v2_1_mut = v220;
                                    v3_1_mut = v3_1;
                                    continue method14;
                                }
                                default: {
                                    v0_1_mut = (`${v0_1}${v219}`);
                                    v1_1_mut = v1_1;
                                    v2_1_mut = v220;
                                    v3_1_mut = v3_1;
                                    continue method14;
                                }
                            }
                        }
                        else {
                            return [(v0_1 === "") ? v1_1 : method15(v1_1, UH1_UH1_1(v0_1, UH1_UH1_0())), v0_1] as [UH1_$union, string];
                        }
                    default:
                        if (v2_1.tag === /* UH0_1 */ 1) {
                            const v270: UH0_$union = v2_1.fields[1];
                            const v269: string = v2_1.fields[0];
                            switch (v269) {
                                case "\\":
                                    return method13(v0_1, v1_1, v270, v3_1, US8_US8_2(1));
                                case "\"":
                                    if (equals(v3_1, US8_US8_2(0))) {
                                        return method13(`${v0_1}"`, v1_1, v270, v3_1, US8_US8_1("\""));
                                    }
                                    else {
                                        return method13("", method15(v1_1, UH1_UH1_1(v0_1, UH1_UH1_0())), v270, v3_1, US8_US8_0());
                                    }
                                case " ": {
                                    v0_1_mut = (`${v0_1} `);
                                    v1_1_mut = v1_1;
                                    v2_1_mut = v270;
                                    v3_1_mut = v3_1;
                                    continue method14;
                                }
                                default: {
                                    v0_1_mut = (`${v0_1}${v269}`);
                                    v1_1_mut = v1_1;
                                    v2_1_mut = v270;
                                    v3_1_mut = v3_1;
                                    continue method14;
                                }
                            }
                        }
                        else {
                            return [(v0_1 === "") ? v1_1 : method15(v1_1, UH1_UH1_1(v0_1, UH1_UH1_0())), v0_1] as [UH1_$union, string];
                        }
                }
            }
            case /* US8_0 */ 0:
                if (v2_1.tag === /* UH0_1 */ 1) {
                    const v5_1: UH0_$union = v2_1.fields[1];
                    const v4_1: string = v2_1.fields[0];
                    switch (v4_1) {
                        case "\"":
                            return method13("", v1_1, v5_1, v3_1, US8_US8_1("\""));
                        case "\\":
                            return method13(v0_1, v1_1, v5_1, v3_1, US8_US8_2(0));
                        case " ": {
                            v0_1_mut = "";
                            v1_1_mut = ((v0_1 === "") ? v1_1 : method15(v1_1, UH1_UH1_1(v0_1, UH1_UH1_0())));
                            v2_1_mut = v5_1;
                            v3_1_mut = v3_1;
                            continue method14;
                        }
                        default: {
                            v0_1_mut = (`${v0_1}${v4_1}`);
                            v1_1_mut = v1_1;
                            v2_1_mut = v5_1;
                            v3_1_mut = v3_1;
                            continue method14;
                        }
                    }
                }
                else {
                    return [(v0_1 === "") ? v1_1 : method15(v1_1, UH1_UH1_1(v0_1, UH1_UH1_0())), v0_1] as [UH1_$union, string];
                }
            default: {
                const v44: uint8 = v3_1.fields[0];
                if (v2_1.tag === /* UH0_1 */ 1) {
                    const v46: UH0_$union = v2_1.fields[1];
                    const v45: string = v2_1.fields[0];
                    switch (v45) {
                        case "\\":
                            return method13(v0_1, v1_1, v46, v3_1, US8_US8_1("\\"));
                        case "\"":
                            if (v3_1.tag === /* US8_0 */ 0) {
                                v0_1_mut = v0_1;
                                v1_1_mut = v1_1;
                                v2_1_mut = v46;
                                v3_1_mut = v3_1;
                                continue method14;
                            }
                            else {
                                return method13(`${v0_1}"`, v1_1, v46, v3_1, US8_US8_2(v44));
                            }
                        case " ": {
                            v0_1_mut = (`${v0_1} `);
                            v1_1_mut = v1_1;
                            v2_1_mut = v46;
                            v3_1_mut = v3_1;
                            continue method14;
                        }
                        default:
                            if (1 === v44) {
                                if (!equals(v3_1, v3_1)) {
                                    v0_1_mut = (`${v0_1}\\${v45}`);
                                    v1_1_mut = v1_1;
                                    v2_1_mut = v46;
                                    v3_1_mut = v3_1;
                                    continue method14;
                                }
                                else {
                                    v0_1_mut = (`${v0_1}${v45}`);
                                    v1_1_mut = v1_1;
                                    v2_1_mut = v46;
                                    v3_1_mut = v3_1;
                                    continue method14;
                                }
                            }
                            else {
                                v0_1_mut = (`${v0_1}${v45}`);
                                v1_1_mut = v1_1;
                                v2_1_mut = v46;
                                v3_1_mut = v3_1;
                                continue method14;
                            }
                    }
                }
                else if (1 === v44) {
                    return [(v0_1 === "") ? v1_1 : method15(v1_1, UH1_UH1_1(v0_1, UH1_UH1_0())), v0_1] as [UH1_$union, string];
                }
                else {
                    return [(v0_1 === "") ? v1_1 : method15(v1_1, UH1_UH1_1(v0_1, UH1_UH1_0())), v0_1] as [UH1_$union, string];
                }
            }
        }
        break;
    }
}

export function method13(v0_1_mut: string, v1_1_mut: UH1_$union, v2_1_mut: UH0_$union, v3_1_mut: US8_$union, v4_1_mut: US8_$union): [UH1_$union, string] {
    method13:
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
                                    continue method13;
                                }
                                else if ("\\" === v106) {
                                    if (!equals(v3_1, US8_US8_2(0))) {
                                        v0_1_mut = (`${v0_1}"`);
                                        v1_1_mut = v1_1;
                                        v2_1_mut = v109;
                                        v3_1_mut = v4_1;
                                        v4_1_mut = US8_US8_1("\"");
                                        continue method13;
                                    }
                                    else if (equals(v3_1, US8_US8_1("\\"))) {
                                        v0_1_mut = (`${v0_1}"`);
                                        v1_1_mut = v1_1;
                                        v2_1_mut = v109;
                                        v3_1_mut = v4_1;
                                        v4_1_mut = US8_US8_1("\"");
                                        continue method13;
                                    }
                                    else {
                                        v0_1_mut = v0_1;
                                        v1_1_mut = v1_1;
                                        v2_1_mut = v109;
                                        v3_1_mut = v4_1;
                                        v4_1_mut = US8_US8_0();
                                        continue method13;
                                    }
                                }
                                else if ("\\" === v108) {
                                    v0_1_mut = v0_1;
                                    v1_1_mut = v1_1;
                                    v2_1_mut = v109;
                                    v3_1_mut = v4_1;
                                    v4_1_mut = US8_US8_2(1);
                                    continue method13;
                                }
                                else if (equals(v3_1, US8_US8_2(0))) {
                                    v0_1_mut = (`${v0_1}"`);
                                    v1_1_mut = v1_1;
                                    v2_1_mut = v109;
                                    v3_1_mut = v4_1;
                                    v4_1_mut = US8_US8_1("\"");
                                    continue method13;
                                }
                                else {
                                    v0_1_mut = "";
                                    v1_1_mut = method15(v1_1, UH1_UH1_1(v0_1, UH1_UH1_0()));
                                    v2_1_mut = v109;
                                    v3_1_mut = v4_1;
                                    v4_1_mut = US8_US8_0();
                                    continue method13;
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
                                        continue method13;
                                    }
                                    case " ":
                                        return method14(`${v0_1} `, v1_1, v109, v4_1);
                                    default:
                                        return method14(`${v0_1}${v108}`, v1_1, v109, v4_1);
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
                                        continue method13;
                                    }
                                    case " ":
                                        return method14(`${v0_1} `, v1_1, v109, v4_1);
                                    default:
                                        return method14(`${v0_1}${v108}`, v1_1, v109, v4_1);
                                }
                            }
                        }
                        else if ("\\" === v106) {
                            return [(v0_1 === "") ? v1_1 : method15(v1_1, UH1_UH1_1(v0_1, UH1_UH1_0())), v0_1] as [UH1_$union, string];
                        }
                        else {
                            return [(v0_1 === "") ? v1_1 : method15(v1_1, UH1_UH1_1(v0_1, UH1_UH1_0())), v0_1] as [UH1_$union, string];
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
                                        continue method13;
                                    }
                                    else if (equals(v3_1, US8_US8_1("\\"))) {
                                        v0_1_mut = (`${v0_1}"`);
                                        v1_1_mut = v1_1;
                                        v2_1_mut = v221;
                                        v3_1_mut = v4_1;
                                        v4_1_mut = US8_US8_1("\"");
                                        continue method13;
                                    }
                                    else {
                                        v0_1_mut = v0_1;
                                        v1_1_mut = v1_1;
                                        v2_1_mut = v221;
                                        v3_1_mut = v4_1;
                                        v4_1_mut = US8_US8_0();
                                        continue method13;
                                    }
                                case "\\": {
                                    v0_1_mut = v0_1;
                                    v1_1_mut = v1_1;
                                    v2_1_mut = v221;
                                    v3_1_mut = v4_1;
                                    v4_1_mut = US8_US8_2(1);
                                    continue method13;
                                }
                                case " ":
                                    return method14(`${v0_1} `, v1_1, v221, v4_1);
                                default:
                                    return method14(`${v0_1}${v220}`, v1_1, v221, v4_1);
                            }
                        }
                        else {
                            return [(v0_1 === "") ? v1_1 : method15(v1_1, UH1_UH1_1(v0_1, UH1_UH1_0())), v0_1] as [UH1_$union, string];
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
                                    continue method13;
                                }
                                case "\"":
                                    if (equals(v3_1, US8_US8_2(0))) {
                                        v0_1_mut = (`${v0_1}"`);
                                        v1_1_mut = v1_1;
                                        v2_1_mut = v271;
                                        v3_1_mut = v4_1;
                                        v4_1_mut = US8_US8_1("\"");
                                        continue method13;
                                    }
                                    else {
                                        v0_1_mut = "";
                                        v1_1_mut = method15(v1_1, UH1_UH1_1(v0_1, UH1_UH1_0()));
                                        v2_1_mut = v271;
                                        v3_1_mut = v4_1;
                                        v4_1_mut = US8_US8_0();
                                        continue method13;
                                    }
                                case " ":
                                    return method14(`${v0_1} `, v1_1, v271, v4_1);
                                default:
                                    return method14(`${v0_1}${v270}`, v1_1, v271, v4_1);
                            }
                        }
                        else {
                            return [(v0_1 === "") ? v1_1 : method15(v1_1, UH1_UH1_1(v0_1, UH1_UH1_0())), v0_1] as [UH1_$union, string];
                        }
                }
            }
            case /* US8_0 */ 0:
                if (v2_1.tag === /* UH0_1 */ 1) {
                    const v6_1: UH0_$union = v2_1.fields[1];
                    const v5_1: string = v2_1.fields[0];
                    switch (v5_1) {
                        case "\"": {
                            v0_1_mut = "";
                            v1_1_mut = v1_1;
                            v2_1_mut = v6_1;
                            v3_1_mut = v4_1;
                            v4_1_mut = US8_US8_1("\"");
                            continue method13;
                        }
                        case "\\": {
                            v0_1_mut = v0_1;
                            v1_1_mut = v1_1;
                            v2_1_mut = v6_1;
                            v3_1_mut = v4_1;
                            v4_1_mut = US8_US8_2(0);
                            continue method13;
                        }
                        case " ":
                            return method14("", (v0_1 === "") ? v1_1 : method15(v1_1, UH1_UH1_1(v0_1, UH1_UH1_0())), v6_1, v4_1);
                        default:
                            return method14(`${v0_1}${v5_1}`, v1_1, v6_1, v4_1);
                    }
                }
                else {
                    return [(v0_1 === "") ? v1_1 : method15(v1_1, UH1_UH1_1(v0_1, UH1_UH1_0())), v0_1] as [UH1_$union, string];
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
                            continue method13;
                        }
                        case "\"":
                            if (v3_1.tag === /* US8_0 */ 0) {
                                return method14(v0_1, v1_1, v47, v4_1);
                            }
                            else {
                                v0_1_mut = (`${v0_1}"`);
                                v1_1_mut = v1_1;
                                v2_1_mut = v47;
                                v3_1_mut = v4_1;
                                v4_1_mut = US8_US8_2(v45);
                                continue method13;
                            }
                        case " ":
                            return method14(`${v0_1} `, v1_1, v47, v4_1);
                        default:
                            if (1 === v45) {
                                if (!equals(v3_1, v4_1)) {
                                    v0_1_mut = (`${v0_1}\\${v46}`);
                                    v1_1_mut = v1_1;
                                    v2_1_mut = v47;
                                    v3_1_mut = v4_1;
                                    v4_1_mut = v3_1;
                                    continue method13;
                                }
                                else {
                                    return method14(`${v0_1}${v46}`, v1_1, v47, v4_1);
                                }
                            }
                            else {
                                return method14(`${v0_1}${v46}`, v1_1, v47, v4_1);
                            }
                    }
                }
                else if (1 === v45) {
                    return [(v0_1 === "") ? v1_1 : method15(v1_1, UH1_UH1_1(v0_1, UH1_UH1_0())), v0_1] as [UH1_$union, string];
                }
                else {
                    return [(v0_1 === "") ? v1_1 : method15(v1_1, UH1_UH1_1(v0_1, UH1_UH1_0())), v0_1] as [UH1_$union, string];
                }
            }
        }
        break;
    }
}

export function method16(v0_1: UH1_$union, v1_1: FSharpList<string>): FSharpList<string> {
    if (v0_1.tag === /* UH1_0 */ 0) {
        return v1_1;
    }
    else {
        return cons(v0_1.fields[0], method16(v0_1.fields[1], v1_1));
    }
}

export function method12(v0_1: string): string[] {
    let _v0: Option<Option<string>> = undefined;
    _v0 = some(v0_1);
    const v5_1: Option<string> = value_2(_v0);
    const _v6: FSharpRef<Option<US4_$union>> = new FSharpRef<Option<US4_$union>>(undefined);
    let x_3: Option<US4_$union>;
    if (v5_1 == null) {
        x_3 = undefined;
    }
    else {
        const x_1: string = value_2(v5_1);
        x_3 = ((): US4_$union => US4_US4_0(x_1))();
    }
    _v6.contents = x_3;
    const v11: US4_$union = defaultArg(_v6.contents, US4_US4_1());
    const v14: string = (v11.tag === /* US4_0 */ 0) ? v11.fields[0] : "";
    const v15: int32 = v14.length | 0;
    const v16: string[] = fill(new Array(v15), 0, v15, "");
    const v17: Mut4 = new Mut4(0);
    while (method4(v15, v17)) {
        const v19: int32 = v17.l0 | 0;
        const v20: string = v14[v19];
        setItem(v16, v19, v20);
        const v21: int32 = (v19 + 1) | 0;
        v17.l0 = (v21 | 0);
    }
    const v23: FSharpList<string> = ofArray<string>(v16);
    return toArray<string>(method16(method13("", UH1_UH1_0(), foldBack<string, UH0_$union>(uncurry2(method5()), v23, UH0_UH0_0()), US8_US8_0(), US8_US8_0())[0], empty<string>()));
}

export function closure18(unitVar: void, v0_1: string): string[] {
    return method12(v0_1);
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

export const v4 = (arg10$0040: [Option<any>, string, [string, string][], Option<((arg0: [boolean, string, int32]) => any)>, Option<((arg0: any) => void)>, Option<string>]): any => closure16(undefined, arg10$0040);

export function execute_with_options_async(x: [Option<any>, string, [string, string][], Option<((arg0: [boolean, string, int32]) => any)>, Option<((arg0: any) => void)>, Option<string>]): any {
    return v4(x);
}

export const v5 = (v: ((arg0: Heap0) => Heap0)): [Option<any>, string, [string, string][], Option<((arg0: [boolean, string, int32]) => any)>, Option<((arg0: any) => void)>, Option<string>] => closure17(undefined, v);

export function execution_options(x: ((arg0: Heap0) => Heap0)): [Option<any>, string, [string, string][], Option<((arg0: [boolean, string, int32]) => any)>, Option<((arg0: any) => void)>, Option<string>] {
    return v5(x);
}

export const v6 = (v: string): string[] => closure18(undefined, v);

export function split_args(x: string): string[] {
    return v6(x);
}


