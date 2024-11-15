import { defaultOf, uncurry2, compare, IComparable, IEquatable, createAtom } from "../../deps/Fable/src/fable-library-ts/Util.js";
import { some, map, defaultArg, value as value_12, Option } from "../../deps/Fable/src/fable-library-ts/Option.js";
import { equals, compare as compare_1, op_Addition, op_Subtraction, fromInt64, toInt64, int64 } from "../../deps/Fable/src/fable-library-ts/BigInt.js";
import { Record, Union } from "../../deps/Fable/src/fable-library-ts/Types.js";
import { array_type, option_type, tuple_type, int32_type, class_type, char_type, bool_type, lambda_type, unit_type, string_type, record_type, int64_type, union_type, TypeInfo } from "../../deps/Fable/src/fable-library-ts/Reflection.js";
import { int32 } from "../../deps/Fable/src/fable-library-ts/Int32.js";
import { create, toString, now, getTicks } from "../../deps/Fable/src/fable-library-ts/Date.js";
import { ofSeq, find } from "../../deps/Fable/src/fable-library-ts/Map.js";
import { milliseconds, seconds, minutes, hours, fromTicks } from "../../deps/Fable/src/fable-library-ts/TimeSpan.js";
import { join, replicate, interpolate, toText, trimStart, trimEnd } from "../../deps/Fable/src/fable-library-ts/String.js";
import { StringBuilder_$ctor_Z721C83C5, StringBuilder__Append_Z721C83C5, StringBuilder__Clear } from "../../deps/Fable/src/fable-library-ts/System.Text.js";
import { setItem, fill } from "../../deps/Fable/src/fable-library-ts/Array.js";
import { toArray, length, item, empty, cons, foldBack, FSharpList, ofArray } from "../../deps/Fable/src/fable-library-ts/List.js";
import { startImmediate } from "../../deps/Fable/src/fable-library-ts/Async.js";
import { singleton } from "../../deps/Fable/src/fable-library-ts/AsyncBuilder.js";
import { map as map_1, delay } from "../../deps/Fable/src/fable-library-ts/Seq.js";
import { rangeDouble } from "../../deps/Fable/src/fable-library-ts/Range.js";
import { FSharpResult$2_$union, FSharpResult$2_Error, FSharpResult$2_Ok } from "../../deps/Fable/src/fable-library-ts/Result.js";

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
    return union_type("Runtime.US0", [], US0, () => [[], [], [], [], []]);
}

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

export class Mut1 extends Record {
    l0: ((arg0: string) => void);
    constructor(l0: ((arg0: string) => void)) {
        super();
        this.l0 = l0;
    }
}

export function Mut1_$reflection(): TypeInfo {
    return record_type("Runtime.Mut1", [], Mut1, () => [["l0", lambda_type(string_type, unit_type)]]);
}

export class Mut2 extends Record implements IEquatable<Mut2>, IComparable<Mut2> {
    l0: boolean;
    constructor(l0: boolean) {
        super();
        this.l0 = l0;
    }
}

export function Mut2_$reflection(): TypeInfo {
    return record_type("Runtime.Mut2", [], Mut2, () => [["l0", bool_type]]);
}

export class Mut3 extends Record implements IEquatable<Mut3>, IComparable<Mut3> {
    l0: string;
    constructor(l0: string) {
        super();
        this.l0 = l0;
    }
}

export function Mut3_$reflection(): TypeInfo {
    return record_type("Runtime.Mut3", [], Mut3, () => [["l0", string_type]]);
}

export class Mut4 extends Record implements IEquatable<Mut4>, IComparable<Mut4> {
    l0: US0_$union;
    constructor(l0: US0_$union) {
        super();
        this.l0 = l0;
    }
}

export function Mut4_$reflection(): TypeInfo {
    return record_type("Runtime.Mut4", [], Mut4, () => [["l0", US0_$reflection()]]);
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
    return union_type("Runtime.US1", [], US1, () => [[["f0_0", US0_$reflection()]], []]);
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
    return union_type("Runtime.US2", [], US2, () => [[["f0_0", int64_type]], []]);
}

export type US3_$union = 
    | US3<0>
    | US3<1>
    | US3<2>

export type US3_$cases = {
    0: ["US3_0", []],
    1: ["US3_1", []],
    2: ["US3_2", []]
}

export function US3_US3_0() {
    return new US3<0>(0, []);
}

export function US3_US3_1() {
    return new US3<1>(1, []);
}

export function US3_US3_2() {
    return new US3<2>(2, []);
}

export class US3<Tag extends keyof US3_$cases> extends Union<Tag, US3_$cases[Tag][0]> {
    constructor(readonly tag: Tag, readonly fields: US3_$cases[Tag][1]) {
        super();
    }
    cases() {
        return ["US3_0", "US3_1", "US3_2"];
    }
}

export function US3_$reflection(): TypeInfo {
    return union_type("Runtime.US3", [], US3, () => [[], [], []]);
}

export type US4_$union = 
    | US4<0>
    | US4<1>
    | US4<2>
    | US4<3>
    | US4<4>

export type US4_$cases = {
    0: ["US4_0", [US3_$union]],
    1: ["US4_1", [US3_$union]],
    2: ["US4_2", [US3_$union]],
    3: ["US4_3", [US3_$union]],
    4: ["US4_4", [US3_$union]]
}

export function US4_US4_0(f0_0: US3_$union) {
    return new US4<0>(0, [f0_0]);
}

export function US4_US4_1(f1_0: US3_$union) {
    return new US4<1>(1, [f1_0]);
}

export function US4_US4_2(f2_0: US3_$union) {
    return new US4<2>(2, [f2_0]);
}

export function US4_US4_3(f3_0: US3_$union) {
    return new US4<3>(3, [f3_0]);
}

export function US4_US4_4(f4_0: US3_$union) {
    return new US4<4>(4, [f4_0]);
}

export class US4<Tag extends keyof US4_$cases> extends Union<Tag, US4_$cases[Tag][0]> {
    constructor(readonly tag: Tag, readonly fields: US4_$cases[Tag][1]) {
        super();
    }
    cases() {
        return ["US4_0", "US4_1", "US4_2", "US4_3", "US4_4"];
    }
}

export function US4_$reflection(): TypeInfo {
    return union_type("Runtime.US4", [], US4, () => [[["f0_0", US3_$reflection()]], [["f1_0", US3_$reflection()]], [["f2_0", US3_$reflection()]], [["f3_0", US3_$reflection()]], [["f4_0", US3_$reflection()]]]);
}

export type US5_$union = 
    | US5<0>
    | US5<1>

export type US5_$cases = {
    0: ["US5_0", [string]],
    1: ["US5_1", []]
}

export function US5_US5_0(f0_0: string) {
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
    return union_type("Runtime.US5", [], US5, () => [[["f0_0", string_type]], []]);
}

export type US6_$union = 
    | US6<0>
    | US6<1>

export type US6_$cases = {
    0: ["US6_0", [string, US5_$union]],
    1: ["US6_1", [string]]
}

export function US6_US6_0(f0_0: string, f0_1: US5_$union) {
    return new US6<0>(0, [f0_0, f0_1]);
}

export function US6_US6_1(f1_0: string) {
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
    return union_type("Runtime.US6", [], US6, () => [[["f0_0", string_type], ["f0_1", US5_$reflection()]], [["f1_0", string_type]]]);
}

export type US7_$union = 
    | US7<0>
    | US7<1>

export type US7_$cases = {
    0: ["US7_0", [string, string, any, int32, int32]],
    1: ["US7_1", [string]]
}

export function US7_US7_0(f0_0: string, f0_1: string, f0_2: any, f0_3: int32, f0_4: int32) {
    return new US7<0>(0, [f0_0, f0_1, f0_2, f0_3, f0_4]);
}

export function US7_US7_1(f1_0: string) {
    return new US7<1>(1, [f1_0]);
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
    return union_type("Runtime.US7", [], US7, () => [[["f0_0", char_type], ["f0_1", string_type], ["f0_2", class_type("System.Text.StringBuilder")], ["f0_3", int32_type], ["f0_4", int32_type]], [["f1_0", string_type]]]);
}

export class Mut5 extends Record implements IEquatable<Mut5>, IComparable<Mut5> {
    l0: int32;
    constructor(l0: int32) {
        super();
        this.l0 = (l0 | 0);
    }
}

export function Mut5_$reflection(): TypeInfo {
    return record_type("Runtime.Mut5", [], Mut5, () => [["l0", int32_type]]);
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

export type UH1_$union = 
    | UH1<0>
    | UH1<1>

export type UH1_$cases = {
    0: ["UH1_0", []],
    1: ["UH1_1", [((arg0: [string, any, int32, int32]) => US7_$union), UH1_$union]]
}

export function UH1_UH1_0() {
    return new UH1<0>(0, []);
}

export function UH1_UH1_1(Item1: ((arg0: [string, any, int32, int32]) => US7_$union), Item2: UH1_$union) {
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
    return union_type("Runtime.UH1", [], UH1, () => [[], [["Item1", lambda_type(tuple_type(string_type, class_type("System.Text.StringBuilder"), int32_type, int32_type), US7_$reflection())], ["Item2", UH1_$reflection()]]]);
}

export type US8_$union = 
    | US8<0>
    | US8<1>

export type US8_$cases = {
    0: ["US8_0", [string, string, any, int32, int32]],
    1: ["US8_1", [string]]
}

export function US8_US8_0(f0_0: string, f0_1: string, f0_2: any, f0_3: int32, f0_4: int32) {
    return new US8<0>(0, [f0_0, f0_1, f0_2, f0_3, f0_4]);
}

export function US8_US8_1(f1_0: string) {
    return new US8<1>(1, [f1_0]);
}

export class US8<Tag extends keyof US8_$cases> extends Union<Tag, US8_$cases[Tag][0]> {
    constructor(readonly tag: Tag, readonly fields: US8_$cases[Tag][1]) {
        super();
    }
    cases() {
        return ["US8_0", "US8_1"];
    }
}

export function US8_$reflection(): TypeInfo {
    return union_type("Runtime.US8", [], US8, () => [[["f0_0", string_type], ["f0_1", string_type], ["f0_2", class_type("System.Text.StringBuilder")], ["f0_3", int32_type], ["f0_4", int32_type]], [["f1_0", string_type]]]);
}

export type US9_$union = 
    | US9<0>
    | US9<1>

export type US9_$cases = {
    0: ["US9_0", [string]],
    1: ["US9_1", []]
}

export function US9_US9_0(f0_0: string) {
    return new US9<0>(0, [f0_0]);
}

export function US9_US9_1() {
    return new US9<1>(1, []);
}

export class US9<Tag extends keyof US9_$cases> extends Union<Tag, US9_$cases[Tag][0]> {
    constructor(readonly tag: Tag, readonly fields: US9_$cases[Tag][1]) {
        super();
    }
    cases() {
        return ["US9_0", "US9_1"];
    }
}

export function US9_$reflection(): TypeInfo {
    return union_type("Runtime.US9", [], US9, () => [[["f0_0", char_type]], []]);
}

export type US10_$union = 
    | US10<0>
    | US10<1>

export type US10_$cases = {
    0: ["US10_0", [string, any, int32, int32]],
    1: ["US10_1", [string]]
}

export function US10_US10_0(f0_0: string, f0_1: any, f0_2: int32, f0_3: int32) {
    return new US10<0>(0, [f0_0, f0_1, f0_2, f0_3]);
}

export function US10_US10_1(f1_0: string) {
    return new US10<1>(1, [f1_0]);
}

export class US10<Tag extends keyof US10_$cases> extends Union<Tag, US10_$cases[Tag][0]> {
    constructor(readonly tag: Tag, readonly fields: US10_$cases[Tag][1]) {
        super();
    }
    cases() {
        return ["US10_0", "US10_1"];
    }
}

export function US10_$reflection(): TypeInfo {
    return union_type("Runtime.US10", [], US10, () => [[["f0_0", string_type], ["f0_1", class_type("System.Text.StringBuilder")], ["f0_2", int32_type], ["f0_3", int32_type]], [["f1_0", string_type]]]);
}

export type US11_$union = 
    | US11<0>
    | US11<1>

export type US11_$cases = {
    0: ["US11_0", [string, US5_$union, string, any, int32, int32]],
    1: ["US11_1", [string]]
}

export function US11_US11_0(f0_0: string, f0_1: US5_$union, f0_2: string, f0_3: any, f0_4: int32, f0_5: int32) {
    return new US11<0>(0, [f0_0, f0_1, f0_2, f0_3, f0_4, f0_5]);
}

export function US11_US11_1(f1_0: string) {
    return new US11<1>(1, [f1_0]);
}

export class US11<Tag extends keyof US11_$cases> extends Union<Tag, US11_$cases[Tag][0]> {
    constructor(readonly tag: Tag, readonly fields: US11_$cases[Tag][1]) {
        super();
    }
    cases() {
        return ["US11_0", "US11_1"];
    }
}

export function US11_$reflection(): TypeInfo {
    return union_type("Runtime.US11", [], US11, () => [[["f0_0", string_type], ["f0_1", US5_$reflection()], ["f0_2", string_type], ["f0_3", class_type("System.Text.StringBuilder")], ["f0_4", int32_type], ["f0_5", int32_type]], [["f1_0", string_type]]]);
}

export type US12_$union = 
    | US12<0>
    | US12<1>

export type US12_$cases = {
    0: ["US12_0", [US9_$union, string, any, int32, int32]],
    1: ["US12_1", [string]]
}

export function US12_US12_0(f0_0: US9_$union, f0_1: string, f0_2: any, f0_3: int32, f0_4: int32) {
    return new US12<0>(0, [f0_0, f0_1, f0_2, f0_3, f0_4]);
}

export function US12_US12_1(f1_0: string) {
    return new US12<1>(1, [f1_0]);
}

export class US12<Tag extends keyof US12_$cases> extends Union<Tag, US12_$cases[Tag][0]> {
    constructor(readonly tag: Tag, readonly fields: US12_$cases[Tag][1]) {
        super();
    }
    cases() {
        return ["US12_0", "US12_1"];
    }
}

export function US12_$reflection(): TypeInfo {
    return union_type("Runtime.US12", [], US12, () => [[["f0_0", US9_$reflection()], ["f0_1", string_type], ["f0_2", class_type("System.Text.StringBuilder")], ["f0_3", int32_type], ["f0_4", int32_type]], [["f1_0", string_type]]]);
}

export type US13_$union = 
    | US13<0>
    | US13<1>

export type US13_$cases = {
    0: ["US13_0", [US5_$union, string, any, int32, int32]],
    1: ["US13_1", [string]]
}

export function US13_US13_0(f0_0: US5_$union, f0_1: string, f0_2: any, f0_3: int32, f0_4: int32) {
    return new US13<0>(0, [f0_0, f0_1, f0_2, f0_3, f0_4]);
}

export function US13_US13_1(f1_0: string) {
    return new US13<1>(1, [f1_0]);
}

export class US13<Tag extends keyof US13_$cases> extends Union<Tag, US13_$cases[Tag][0]> {
    constructor(readonly tag: Tag, readonly fields: US13_$cases[Tag][1]) {
        super();
    }
    cases() {
        return ["US13_0", "US13_1"];
    }
}

export function US13_$reflection(): TypeInfo {
    return union_type("Runtime.US13", [], US13, () => [[["f0_0", US5_$reflection()], ["f0_1", string_type], ["f0_2", class_type("System.Text.StringBuilder")], ["f0_3", int32_type], ["f0_4", int32_type]], [["f1_0", string_type]]]);
}

export type US14_$union = 
    | US14<0>
    | US14<1>

export type US14_$cases = {
    0: ["US14_0", [((arg0: [int32, string, boolean]) => any)]],
    1: ["US14_1", []]
}

export function US14_US14_0(f0_0: ((arg0: [int32, string, boolean]) => any)) {
    return new US14<0>(0, [f0_0]);
}

export function US14_US14_1() {
    return new US14<1>(1, []);
}

export class US14<Tag extends keyof US14_$cases> extends Union<Tag, US14_$cases[Tag][0]> {
    constructor(readonly tag: Tag, readonly fields: US14_$cases[Tag][1]) {
        super();
    }
    cases() {
        return ["US14_0", "US14_1"];
    }
}

export function US14_$reflection(): TypeInfo {
    return union_type("Runtime.US14", [], US14, () => [[["f0_0", lambda_type(tuple_type(int32_type, string_type, bool_type), class_type("Microsoft.FSharp.Control.FSharpAsync`1", [unit_type]))]], []]);
}

export type US15_$union = 
    | US15<0>
    | US15<1>

export type US15_$cases = {
    0: ["US15_0", [any]],
    1: ["US15_1", []]
}

export function US15_US15_0(f0_0: any) {
    return new US15<0>(0, [f0_0]);
}

export function US15_US15_1() {
    return new US15<1>(1, []);
}

export class US15<Tag extends keyof US15_$cases> extends Union<Tag, US15_$cases[Tag][0]> {
    constructor(readonly tag: Tag, readonly fields: US15_$cases[Tag][1]) {
        super();
    }
    cases() {
        return ["US15_0", "US15_1"];
    }
}

export function US15_$reflection(): TypeInfo {
    return union_type("Runtime.US15", [], US15, () => [[["f0_0", class_type("System.Threading.CancellationToken")]], []]);
}

export class Heap0 extends Record {
    readonly l0: string;
    readonly l1: Option<any>;
    readonly l2: [string, string][];
    readonly l3: Option<((arg0: [int32, string, boolean]) => any)>;
    readonly l4: Option<((arg0: any) => void)>;
    readonly l5: boolean;
    readonly l6: Option<string>;
    constructor(l0: string, l1: Option<any>, l2: [string, string][], l3: Option<((arg0: [int32, string, boolean]) => any)>, l4: Option<((arg0: any) => void)>, l5: boolean, l6: Option<string>) {
        super();
        this.l0 = l0;
        this.l1 = l1;
        this.l2 = l2;
        this.l3 = l3;
        this.l4 = l4;
        this.l5 = l5;
        this.l6 = l6;
    }
}

export function Heap0_$reflection(): TypeInfo {
    return record_type("Runtime.Heap0", [], Heap0, () => [["l0", string_type], ["l1", option_type(class_type("System.Threading.CancellationToken"))], ["l2", array_type(tuple_type(string_type, string_type))], ["l3", option_type(lambda_type(tuple_type(int32_type, string_type, bool_type), class_type("Microsoft.FSharp.Control.FSharpAsync`1", [unit_type])))], ["l4", option_type(lambda_type(string_type, unit_type))], ["l5", bool_type], ["l6", option_type(string_type)]]);
}

export type US16_$union = 
    | US16<0>
    | US16<1>

export type US16_$cases = {
    0: ["US16_0", [string[]]],
    1: ["US16_1", [string]]
}

export function US16_US16_0(f0_0: string[]) {
    return new US16<0>(0, [f0_0]);
}

export function US16_US16_1(f1_0: string) {
    return new US16<1>(1, [f1_0]);
}

export class US16<Tag extends keyof US16_$cases> extends Union<Tag, US16_$cases[Tag][0]> {
    constructor(readonly tag: Tag, readonly fields: US16_$cases[Tag][1]) {
        super();
    }
    cases() {
        return ["US16_0", "US16_1"];
    }
}

export function US16_$reflection(): TypeInfo {
    return union_type("Runtime.US16", [], US16, () => [[["f0_0", array_type(string_type)]], [["f1_0", string_type]]]);
}

export type UH2_$union = 
    | UH2<0>
    | UH2<1>

export type UH2_$cases = {
    0: ["UH2_0", []],
    1: ["UH2_1", [string, UH2_$union]]
}

export function UH2_UH2_0() {
    return new UH2<0>(0, []);
}

export function UH2_UH2_1(Item1: string, Item2: UH2_$union) {
    return new UH2<1>(1, [Item1, Item2]);
}

export class UH2<Tag extends keyof UH2_$cases> extends Union<Tag, UH2_$cases[Tag][0]> {
    constructor(readonly tag: Tag, readonly fields: UH2_$cases[Tag][1]) {
        super();
    }
    cases() {
        return ["UH2_0", "UH2_1"];
    }
}

export function UH2_$reflection(): TypeInfo {
    return union_type("Runtime.UH2", [], UH2, () => [[], [["Item1", string_type], ["Item2", UH2_$reflection()]]]);
}

export type US17_$union = 
    | US17<0>
    | US17<1>

export type US17_$cases = {
    0: ["US17_0", [UH2_$union, string, any, int32, int32]],
    1: ["US17_1", [string]]
}

export function US17_US17_0(f0_0: UH2_$union, f0_1: string, f0_2: any, f0_3: int32, f0_4: int32) {
    return new US17<0>(0, [f0_0, f0_1, f0_2, f0_3, f0_4]);
}

export function US17_US17_1(f1_0: string) {
    return new US17<1>(1, [f1_0]);
}

export class US17<Tag extends keyof US17_$cases> extends Union<Tag, US17_$cases[Tag][0]> {
    constructor(readonly tag: Tag, readonly fields: US17_$cases[Tag][1]) {
        super();
    }
    cases() {
        return ["US17_0", "US17_1"];
    }
}

export function US17_$reflection(): TypeInfo {
    return union_type("Runtime.US17", [], US17, () => [[["f0_0", UH2_$reflection()], ["f0_1", string_type], ["f0_2", class_type("System.Text.StringBuilder")], ["f0_3", int32_type], ["f0_4", int32_type]], [["f1_0", string_type]]]);
}

export type UH3_$union = 
    | UH3<0>
    | UH3<1>

export type UH3_$cases = {
    0: ["UH3_0", []],
    1: ["UH3_1", [((arg0: [string, any, int32, int32]) => US8_$union), UH3_$union]]
}

export function UH3_UH3_0() {
    return new UH3<0>(0, []);
}

export function UH3_UH3_1(Item1: ((arg0: [string, any, int32, int32]) => US8_$union), Item2: UH3_$union) {
    return new UH3<1>(1, [Item1, Item2]);
}

export class UH3<Tag extends keyof UH3_$cases> extends Union<Tag, UH3_$cases[Tag][0]> {
    constructor(readonly tag: Tag, readonly fields: UH3_$cases[Tag][1]) {
        super();
    }
    cases() {
        return ["UH3_0", "UH3_1"];
    }
}

export function UH3_$reflection(): TypeInfo {
    return union_type("Runtime.UH3", [], UH3, () => [[], [["Item1", lambda_type(tuple_type(string_type, class_type("System.Text.StringBuilder"), int32_type, int32_type), US8_$reflection())], ["Item2", UH3_$reflection()]]]);
}

export function method3(): string {
    return "";
}

export function closure1(unitVar: void, v0_1: string): US5_$union {
    return US5_US5_0(v0_1);
}

export function method4(): ((arg0: string) => US5_$union) {
    return (v: string): US5_$union => closure1(undefined, v);
}

export function method2(v0_1: string): string {
    return process.env[v0_1] ?? "";
}

export function method1(): [US1_$union, US2_$union] {
    let v13: US1_$union, v20_1: US1_$union, v27: US1_$union, v34: US1_$union;
    const v1_1: string = method2("TRACE_LEVEL");
    const v6: US1_$union = ("Verbose" === v1_1) ? US1_US1_0(US0_US0_0()) : US1_US1_1();
    return [(v6.tag === /* US1_0 */ 0) ? US1_US1_0(v6.fields[0]) : ((v13 = (("Debug" === v1_1) ? US1_US1_0(US0_US0_1()) : US1_US1_1()), (v13.tag === /* US1_0 */ 0) ? US1_US1_0(v13.fields[0]) : ((v20_1 = (("Info" === v1_1) ? US1_US1_0(US0_US0_2()) : US1_US1_1()), (v20_1.tag === /* US1_0 */ 0) ? US1_US1_0(v20_1.fields[0]) : ((v27 = (("Warning" === v1_1) ? US1_US1_0(US0_US0_3()) : US1_US1_1()), (v27.tag === /* US1_0 */ 0) ? US1_US1_0(v27.fields[0]) : ((v34 = (("Critical" === v1_1) ? US1_US1_0(US0_US0_4()) : US1_US1_1()), (v34.tag === /* US1_0 */ 0) ? US1_US1_0(v34.fields[0]) : US1_US1_1())))))))), (method2("AUTOMATION") !== "True") ? US2_US2_1() : US2_US2_0(toInt64(fromInt64(getTicks(now()))))] as [US1_$union, US2_$union];
}

export function closure2(unitVar: void, v0_1: string): void {
}

export function method0(v0_1: US0_$union): [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] {
    const patternInput: [US1_$union, US2_$union] = method1();
    const _v1 = [patternInput[0], patternInput[1]] as [US1_$union, US2_$union];
    const v132: US2_$union = _v1[1];
    const v131: US1_$union = _v1[0];
    return [new Mut0(1n), new Mut1((v: string): void => {
        closure2(undefined, v);
    }), new Mut2(true), new Mut3(""), new Mut4((v131.tag === /* US1_0 */ 0) ? v131.fields[0] : v0_1), (v132.tag === /* US2_0 */ 0) ? v132.fields[0] : undefined] as [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>];
}

export function closure0(unitVar: void, unitVar_1: void): void {
    if (TraceState_trace_state() == null) {
        const patternInput: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = method0(US0_US0_0());
        TraceState_trace_state([patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5]] as [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>]);
    }
}

export function method5(v0_1: US0_$union): boolean {
    let v3: any;
    closure0(undefined, undefined);
    v3 = undefined;
    const patternInput: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_12(TraceState_trace_state());
    const v35: US0_$union = patternInput[4].l0;
    if (patternInput[2].l0 === false) {
        return false;
    }
    else {
        return find<US0_$union, int32>(v0_1, ofSeq([[US0_US0_0(), 0] as [US0_$union, int32], [US0_US0_1(), 1] as [US0_$union, int32], [US0_US0_2(), 2] as [US0_$union, int32], [US0_US0_3(), 3] as [US0_$union, int32], [US0_US0_4(), 4] as [US0_$union, int32]], {
            Compare: compare,
        })) >= find<US0_$union, int32>(v35, ofSeq([[US0_US0_0(), 0] as [US0_$union, int32], [US0_US0_1(), 1] as [US0_$union, int32], [US0_US0_2(), 2] as [US0_$union, int32], [US0_US0_3(), 3] as [US0_$union, int32], [US0_US0_4(), 4] as [US0_$union, int32]], {
            Compare: compare,
        }));
    }
}

export function closure6(unitVar: void, v0_1: int64): US2_$union {
    return US2_US2_0(v0_1);
}

export function method7(): ((arg0: int64) => US2_$union) {
    return (v: int64): US2_$union => closure6(undefined, v);
}

export function method8(): string {
    return "hh:mm:ss";
}

export function method9(): string {
    return "HH:mm:ss";
}

export function method6(v0_1: Mut0, v1_1: Mut1, v2_1: Mut2, v3: Mut3, v4: Mut4, v5: Option<int64>): string {
    let v295: int64, v349: number;
    const v291: US2_$union = defaultArg(map<int64, US2_$union>(method7(), v5), US2_US2_1());
    return toString((v291.tag === /* US2_0 */ 0) ? ((v295 = v291.fields[0], (v349 = fromTicks(toInt64(op_Subtraction(toInt64(fromInt64(getTicks(now()))), v295))), create(1, 1, 1, hours(v349), minutes(v349), seconds(v349), milliseconds(v349))))) : now(), method9());
}

export function method12(): string {
    return "";
}

export function closure7(v0_1: Mut3, v1_1: string, unitVar: void): void {
    const v3: string = v0_1.l0 + v1_1;
    v0_1.l0 = v3;
}

export function method11(v0_1: string): string {
    const v2_1: Mut3 = new Mut3(method12());
    let v8: any;
    closure7(v2_1, `${v0_1}`, undefined);
    v8 = undefined;
    return v2_1.l0;
}

export function method13(): string {
    return "\u001b[0m";
}

export function method10(): string {
    const v2_1: string = "Warning".toLocaleLowerCase();
    return ("\u001b[93m" + method11(v2_1[0])) + method13();
}

export function method15(): string {
    const v1_1: Mut3 = new Mut3(method12());
    return v1_1.l0;
}

export function method16(v0_1: string): string {
    return trimEnd(trimStart(v0_1, ...[]), ...[" ", "/"]);
}

export function method14(v0_1: Mut0, v1_1: Mut1, v2_1: Mut2, v3: Mut3, v4: Mut4, v5: Option<int64>, v6: string, v7: string): string {
    const v8: string = method15();
    return method16(`${v6} ${v7} #${v0_1.l0} ${"runtime.current_process_kill / exiting... 3"} / ${v8}`);
}

export function closure8(v0_1: Mut0, unitVar: void): void {
    const v2_1: int64 = toInt64(op_Addition(v0_1.l0, 1n));
    v0_1.l0 = v2_1;
}

export function closure10(v0_1: string, unitVar: void): void {
    console.log(v0_1);
}

export function closure9(unitVar: void, v0_1: string): void {
    let v3: any;
    closure10(v0_1, undefined);
    v3 = undefined;
}

export function method17(v0_1: string): void {
    let v3: any;
    closure0(undefined, undefined);
    v3 = undefined;
    const patternInput: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_12(TraceState_trace_state());
    let v37: any;
    closure8(patternInput[0], undefined);
    v37 = undefined;
    closure9(undefined, v0_1);
    patternInput[1].l0(v0_1);
}

export function closure5(unitVar: void, unitVar_1: void): void {
    if (method5(US0_US0_3())) {
        let v4: any;
        closure0(undefined, undefined);
        v4 = undefined;
        const patternInput: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_12(TraceState_trace_state());
        const v23: Option<int64> = patternInput[5];
        const v22: Mut4 = patternInput[4];
        const v21: Mut3 = patternInput[3];
        const v20_1: Mut2 = patternInput[2];
        const v19_1: Mut1 = patternInput[1];
        const v18_1: Mut0 = patternInput[0];
        method17(method14(v18_1, v19_1, v20_1, v21, v22, v23, method6(v18_1, v19_1, v20_1, v21, v22, v23), method10()));
    }
}

export function method18(v0_1: Mut0, v1_1: Mut1, v2_1: Mut2, v3: Mut3, v4: Mut4, v5: Option<int64>, v6: string, v7: string): string {
    const v8: string = method15();
    return method16(`${v6} ${v7} #${v0_1.l0} ${"runtime.current_process_kill / exiting... 2"} / ${v8}`);
}

export function closure11(unitVar: void, unitVar_1: void): void {
    if (method5(US0_US0_3())) {
        let v4: any;
        closure0(undefined, undefined);
        v4 = undefined;
        const patternInput: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_12(TraceState_trace_state());
        const v23: Option<int64> = patternInput[5];
        const v22: Mut4 = patternInput[4];
        const v21: Mut3 = patternInput[3];
        const v20_1: Mut2 = patternInput[2];
        const v19_1: Mut1 = patternInput[1];
        const v18_1: Mut0 = patternInput[0];
        method17(method18(v18_1, v19_1, v20_1, v21, v22, v23, method6(v18_1, v19_1, v20_1, v21, v22, v23), method10()));
    }
}

export function method19(v0_1: Mut0, v1_1: Mut1, v2_1: Mut2, v3: Mut3, v4: Mut4, v5: Option<int64>, v6: string, v7: string): string {
    const v8: string = method15();
    return method16(`${v6} ${v7} #${v0_1.l0} ${"runtime.current_process_kill / exiting... 1"} / ${v8}`);
}

export function closure12(unitVar: void, unitVar_1: void): void {
    if (method5(US0_US0_3())) {
        let v4: any;
        closure0(undefined, undefined);
        v4 = undefined;
        const patternInput: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_12(TraceState_trace_state());
        const v23: Option<int64> = patternInput[5];
        const v22: Mut4 = patternInput[4];
        const v21: Mut3 = patternInput[3];
        const v20_1: Mut2 = patternInput[2];
        const v19_1: Mut1 = patternInput[1];
        const v18_1: Mut0 = patternInput[0];
        method17(method19(v18_1, v19_1, v20_1, v21, v22, v23, method6(v18_1, v19_1, v20_1, v21, v22, v23), method10()));
    }
}

export function closure4(unitVar: void, unitVar_1: void): void {
}

export function closure3(unitVar: void, unitVar_1: void): void {
}

export function method22(): string {
    return "";
}

export function method23(v0_1: int32, v1_1: Mut5): boolean {
    return v1_1.l0 < v0_1;
}

export function closure16(v0_1: string, v1_1: UH0_$union): UH0_$union {
    return UH0_UH0_1(v0_1, v1_1);
}

export function closure15(unitVar: void, v0_1: string): ((arg0: UH0_$union) => UH0_$union) {
    return (v: UH0_$union): UH0_$union => closure16(v0_1, v);
}

export function method24(): ((arg0: string) => ((arg0: UH0_$union) => UH0_$union)) {
    return (v: string): ((arg0: UH0_$union) => UH0_$union) => closure15(undefined, v);
}

export function method25(v0_1_mut: UH0_$union, v1_1_mut: any, v2_1_mut: int32, v3_mut: int32): [any, int32, int32] {
    let v12: any, v21: any;
    method25:
    while (true) {
        const v0_1: UH0_$union = v0_1_mut, v1_1: any = v1_1_mut, v2_1: int32 = v2_1_mut, v3: int32 = v3_mut;
        if (v0_1.tag === /* UH0_0 */ 0) {
            return [v1_1, v2_1, v3] as [any, int32, int32];
        }
        else {
            const v4: string = v0_1.fields[0];
            const v6: boolean = "\n" === v4;
            const patternInput: [int32, int32] = v6 ? ([v2_1 + 1, 1] as [int32, int32]) : ([v2_1, v3 + 1] as [int32, int32]);
            v0_1_mut = v0_1.fields[1];
            v1_1_mut = (v6 ? ((v12 = StringBuilder__Clear(v1_1), v1_1)) : ((v21 = StringBuilder__Append_Z721C83C5(v1_1, v4), v1_1)));
            v2_1_mut = patternInput[0];
            v3_mut = patternInput[1];
            continue method25;
        }
        break;
    }
}

export function closure14(unitVar: void, _arg: [string, any, int32, int32]): US7_$union {
    const v3: int32 = _arg[3] | 0;
    const v2_1: int32 = _arg[2] | 0;
    const v1_1: any = _arg[1];
    const v0_1: string = _arg[0];
    if ("" === v0_1) {
        return US7_US7_1(toText(interpolate("parsing.p_char / unexpected end of input / c: \'%P()\' / s: %A%P()", ["\"", [v1_1, v2_1, v3] as [any, int32, int32]])));
    }
    else {
        const v9: string = v0_1[0];
        if (v9 === "\"") {
            const v15 = 1;
            const v29: int32 = (v0_1.length - 1) | 0;
            const v30: string = v0_1.slice(v15, v29 + 1);
            const v35: string = v9;
            const v38: int32 = v35.length | 0;
            const v39: string[] = fill(new Array(v38), 0, v38, "");
            const v40: Mut5 = new Mut5(0);
            while (method23(v38, v40)) {
                const v42: int32 = v40.l0 | 0;
                const v43: string = v35[v42];
                setItem(v39, v42, v43);
                const v44: int32 = (v42 + 1) | 0;
                v40.l0 = (v44 | 0);
            }
            const v45: FSharpList<string> = ofArray<string>(v39);
            const patternInput: [any, int32, int32] = method25(foldBack<string, UH0_$union>(uncurry2(method24()), v45, UH0_UH0_0()), v1_1, v2_1, v3);
            return US7_US7_0(v9, v30, patternInput[0], patternInput[1], patternInput[2]);
        }
        else {
            const v80: int32 = v0_1.length | 0;
            const v87: int32 = (v0_1.indexOf("\n") - 1) | 0;
            const v92 = 0;
            const v106: int32 = (((-2 === v87) ? (v80 + 1) : (v87 + 1)) - 1) | 0;
            return US7_US7_1(`${`parsing.p_char / expected: '${"\""}' / line: ${v2_1} / col: ${v3}
${v1_1}${v0_1.slice(v92, v106 + 1)}`}
${replicate(v3 - 1, " ") + "^"}
`);
        }
    }
}

export function closure17(unitVar: void, _arg: [string, any, int32, int32]): US7_$union {
    const v3: int32 = _arg[3] | 0;
    const v2_1: int32 = _arg[2] | 0;
    const v1_1: any = _arg[1];
    const v0_1: string = _arg[0];
    if ("" === v0_1) {
        return US7_US7_1(toText(interpolate("parsing.p_char / unexpected end of input / c: \'%P()\' / s: %A%P()", ["\'", [v1_1, v2_1, v3] as [any, int32, int32]])));
    }
    else {
        const v9: string = v0_1[0];
        if (v9 === "\'") {
            const v15 = 1;
            const v29: int32 = (v0_1.length - 1) | 0;
            const v30: string = v0_1.slice(v15, v29 + 1);
            const v35: string = v9;
            const v38: int32 = v35.length | 0;
            const v39: string[] = fill(new Array(v38), 0, v38, "");
            const v40: Mut5 = new Mut5(0);
            while (method23(v38, v40)) {
                const v42: int32 = v40.l0 | 0;
                const v43: string = v35[v42];
                setItem(v39, v42, v43);
                const v44: int32 = (v42 + 1) | 0;
                v40.l0 = (v44 | 0);
            }
            const v45: FSharpList<string> = ofArray<string>(v39);
            const patternInput: [any, int32, int32] = method25(foldBack<string, UH0_$union>(uncurry2(method24()), v45, UH0_UH0_0()), v1_1, v2_1, v3);
            return US7_US7_0(v9, v30, patternInput[0], patternInput[1], patternInput[2]);
        }
        else {
            const v80: int32 = v0_1.length | 0;
            const v87: int32 = (v0_1.indexOf("\n") - 1) | 0;
            const v92 = 0;
            const v106: int32 = (((-2 === v87) ? (v80 + 1) : (v87 + 1)) - 1) | 0;
            return US7_US7_1(`${`parsing.p_char / expected: '${"\'"}' / line: ${v2_1} / col: ${v3}
${v1_1}${v0_1.slice(v92, v106 + 1)}`}
${replicate(v3 - 1, " ") + "^"}
`);
        }
    }
}

export function method26(v0_1_mut: string, v1_1_mut: any, v2_1_mut: UH1_$union): US7_$union {
    method26:
    while (true) {
        const v0_1: string = v0_1_mut, v1_1: any = v1_1_mut, v2_1: UH1_$union = v2_1_mut;
        if (v2_1.tag === /* UH1_0 */ 0) {
            return US7_US7_1("parsing.choice / no parsers succeeded");
        }
        else {
            const v6: UH1_$union = v2_1.fields[1];
            const v7: US7_$union = v2_1.fields[0]([v0_1, v1_1, 1, 1] as [string, any, int32, int32]);
            if (v7.tag === /* US7_0 */ 0) {
                const v9: string = v7.fields[1];
                const v8: string = v7.fields[0];
                const v12: int32 = v7.fields[4] | 0;
                const v11: int32 = v7.fields[3] | 0;
                const v10: any = v7.fields[2];
                return v7;
            }
            else {
                const v13: string = v7.fields[0];
                v0_1_mut = v0_1;
                v1_1_mut = v1_1;
                v2_1_mut = v6;
                continue method26;
            }
        }
        break;
    }
}

export function method27(v0_1_mut: string, v1_1_mut: int64): boolean {
    method27:
    while (true) {
        const v0_1: string = v0_1_mut, v1_1: int64 = v1_1_mut;
        if (compare_1(v1_1, 2n) >= 0) {
            return false;
        }
        else {
            let v11: US9_$union;
            if (equals(v1_1, 0n)) {
                v11 = US9_US9_0("\"");
            }
            else {
                const v5: int64 = toInt64(op_Subtraction(v1_1, 1n));
                if (equals(v5, 0n)) {
                    v11 = US9_US9_0("\'");
                }
                else {
                    const v8: int64 = toInt64(op_Subtraction(v5, 1n));
                    v11 = US9_US9_1();
                }
            }
            if (v0_1 === ((v11.tag === /* US9_0 */ 0) ? v11.fields[0] : (() => {
                throw new Error("Option does not have a value.");
            })())) {
                return true;
            }
            else {
                v0_1_mut = v0_1;
                v1_1_mut = toInt64(op_Addition(v1_1, 1n));
                continue method27;
            }
        }
        break;
    }
}

export function method28(v0_1_mut: string, v1_1_mut: string, v2_1_mut: any, v3_mut: int32, v4_mut: int32): [string, string, any, int32, int32] {
    method28:
    while (true) {
        const v0_1: string = v0_1_mut, v1_1: string = v1_1_mut, v2_1: any = v2_1_mut, v3: int32 = v3_mut, v4: int32 = v4_mut;
        let v109: US7_$union;
        if ("" === v1_1) {
            v109 = US7_US7_1(toText(interpolate("parsing.none_of / unexpected end of input / chars: %A%P() / s: %A%P()", [["\"", "\'"], [v2_1, v3, v4] as [any, int32, int32]])));
        }
        else {
            const v21: string = v1_1[0];
            if (method27(v21, 0n) === false) {
                const v29 = 1;
                const v43: int32 = (v1_1.length - 1) | 0;
                const v44: string = v1_1.slice(v29, v43 + 1);
                const v49: string = v21;
                const v52: int32 = v49.length | 0;
                const v53: string[] = fill(new Array(v52), 0, v52, "");
                const v54: Mut5 = new Mut5(0);
                while (method23(v52, v54)) {
                    const v56: int32 = v54.l0 | 0;
                    const v57: string = v49[v56];
                    setItem(v53, v56, v57);
                    const v58: int32 = (v56 + 1) | 0;
                    v54.l0 = (v58 | 0);
                }
                const v59: FSharpList<string> = ofArray<string>(v53);
                const patternInput: [any, int32, int32] = method25(foldBack<string, UH0_$union>(uncurry2(method24()), v59, UH0_UH0_0()), v2_1, v3, v4);
                v109 = US7_US7_0(v21, v44, patternInput[0], patternInput[1], patternInput[2]);
            }
            else {
                v109 = US7_US7_1(toText(interpolate("parsing.none_of / unexpected char: \'%P()\' / chars: %A%P() / s: %A%P()", [v21, ["\"", "\'"], [v2_1, v3, v4] as [any, int32, int32]])));
            }
        }
        let v121: US7_$union;
        if (v109.tag === /* US7_0 */ 0) {
            const v110: string = v109.fields[0];
            v121 = US7_US7_0(("\\" === v110) ? "/" : v110, v109.fields[1], v109.fields[2], v109.fields[3], v109.fields[4]);
        }
        else {
            v121 = US7_US7_1(v109.fields[0]);
        }
        if (v121.tag === /* US7_0 */ 0) {
            v0_1_mut = (v0_1 + v121.fields[0]);
            v1_1_mut = v121.fields[1];
            v2_1_mut = v121.fields[2];
            v3_mut = v121.fields[3];
            v4_mut = v121.fields[4];
            continue method28;
        }
        else {
            const v137: string = v121.fields[0];
            return [v0_1, v1_1, v2_1, v3, v4] as [string, string, any, int32, int32];
        }
        break;
    }
}

export function method29(v0_1_mut: string, v1_1_mut: any, v2_1_mut: int32, v3_mut: int32, v4_mut: UH1_$union): US7_$union {
    method29:
    while (true) {
        const v0_1: string = v0_1_mut, v1_1: any = v1_1_mut, v2_1: int32 = v2_1_mut, v3: int32 = v3_mut, v4: UH1_$union = v4_mut;
        if (v4.tag === /* UH1_0 */ 0) {
            return US7_US7_1("parsing.choice / no parsers succeeded");
        }
        else {
            const v8: UH1_$union = v4.fields[1];
            const v9: US7_$union = v4.fields[0]([v0_1, v1_1, v2_1, v3] as [string, any, int32, int32]);
            if (v9.tag === /* US7_0 */ 0) {
                const v14: int32 = v9.fields[4] | 0;
                const v13: int32 = v9.fields[3] | 0;
                const v12: any = v9.fields[2];
                const v11: string = v9.fields[1];
                const v10: string = v9.fields[0];
                return v9;
            }
            else {
                const v15: string = v9.fields[0];
                v0_1_mut = v0_1;
                v1_1_mut = v1_1;
                v2_1_mut = v2_1;
                v3_mut = v3;
                v4_mut = v8;
                continue method29;
            }
        }
        break;
    }
}

export function method30(v0_1_mut: string, v1_1_mut: int64): boolean {
    method30:
    while (true) {
        const v0_1: string = v0_1_mut, v1_1: int64 = v1_1_mut;
        if (compare_1(v1_1, 3n) >= 0) {
            return false;
        }
        else {
            let v15: US9_$union;
            if (equals(v1_1, 0n)) {
                v15 = US9_US9_0("\"");
            }
            else {
                const v5: int64 = toInt64(op_Subtraction(v1_1, 1n));
                if (equals(v5, 0n)) {
                    v15 = US9_US9_0("\'");
                }
                else {
                    const v8: int64 = toInt64(op_Subtraction(v5, 1n));
                    if (equals(v8, 0n)) {
                        v15 = US9_US9_0(" ");
                    }
                    else {
                        const v11: int64 = toInt64(op_Subtraction(v8, 1n));
                        v15 = US9_US9_1();
                    }
                }
            }
            if (v0_1 === ((v15.tag === /* US9_0 */ 0) ? v15.fields[0] : (() => {
                throw new Error("Option does not have a value.");
            })())) {
                return true;
            }
            else {
                v0_1_mut = v0_1;
                v1_1_mut = toInt64(op_Addition(v1_1, 1n));
                continue method30;
            }
        }
        break;
    }
}

export function method31(v0_1_mut: string, v1_1_mut: string, v2_1_mut: any, v3_mut: int32, v4_mut: int32): [string, string, any, int32, int32] {
    method31:
    while (true) {
        const v0_1: string = v0_1_mut, v1_1: string = v1_1_mut, v2_1: any = v2_1_mut, v3: int32 = v3_mut, v4: int32 = v4_mut;
        let v115: US7_$union;
        if ("" === v1_1) {
            v115 = US7_US7_1(toText(interpolate("parsing.none_of / unexpected end of input / chars: %A%P() / s: %A%P()", [["\"", "\'", " "], [v2_1, v3, v4] as [any, int32, int32]])));
        }
        else {
            const v24: string = v1_1[0];
            if (method30(v24, 0n) === false) {
                const v32 = 1;
                const v46: int32 = (v1_1.length - 1) | 0;
                const v47: string = v1_1.slice(v32, v46 + 1);
                const v52: string = v24;
                const v55: int32 = v52.length | 0;
                const v56: string[] = fill(new Array(v55), 0, v55, "");
                const v57: Mut5 = new Mut5(0);
                while (method23(v55, v57)) {
                    const v59: int32 = v57.l0 | 0;
                    const v60: string = v52[v59];
                    setItem(v56, v59, v60);
                    const v61: int32 = (v59 + 1) | 0;
                    v57.l0 = (v61 | 0);
                }
                const v62: FSharpList<string> = ofArray<string>(v56);
                const patternInput: [any, int32, int32] = method25(foldBack<string, UH0_$union>(uncurry2(method24()), v62, UH0_UH0_0()), v2_1, v3, v4);
                v115 = US7_US7_0(v24, v47, patternInput[0], patternInput[1], patternInput[2]);
            }
            else {
                v115 = US7_US7_1(toText(interpolate("parsing.none_of / unexpected char: \'%P()\' / chars: %A%P() / s: %A%P()", [v24, ["\"", "\'", " "], [v2_1, v3, v4] as [any, int32, int32]])));
            }
        }
        let v127: US7_$union;
        if (v115.tag === /* US7_0 */ 0) {
            const v116: string = v115.fields[0];
            v127 = US7_US7_0(("\\" === v116) ? "/" : v116, v115.fields[1], v115.fields[2], v115.fields[3], v115.fields[4]);
        }
        else {
            v127 = US7_US7_1(v115.fields[0]);
        }
        if (v127.tag === /* US7_0 */ 0) {
            v0_1_mut = (v0_1 + v127.fields[0]);
            v1_1_mut = v127.fields[1];
            v2_1_mut = v127.fields[2];
            v3_mut = v127.fields[3];
            v4_mut = v127.fields[4];
            continue method31;
        }
        else {
            const v143: string = v127.fields[0];
            return [v0_1, v1_1, v2_1, v3, v4] as [string, string, any, int32, int32];
        }
        break;
    }
}

export function method32(v0_1_mut: string, v1_1_mut: int32): int32 {
    method32:
    while (true) {
        const v0_1: string = v0_1_mut, v1_1: int32 = v1_1_mut;
        if (v1_1 >= v0_1.length) {
            return v1_1 | 0;
        }
        else if (" " === v0_1[v1_1]) {
            v0_1_mut = v0_1;
            v1_1_mut = (v1_1 + 1);
            continue method32;
        }
        else {
            return v1_1 | 0;
        }
        break;
    }
}

export function method33(v0_1_mut: string, v1_1_mut: string, v2_1_mut: any, v3_mut: int32, v4_mut: int32): [string, string, any, int32, int32] {
    method33:
    while (true) {
        const v0_1: string = v0_1_mut, v1_1: string = v1_1_mut, v2_1: any = v2_1_mut, v3: int32 = v3_mut, v4: int32 = v4_mut;
        let v79: US7_$union;
        if ("" === v1_1) {
            v79 = US7_US7_1(toText(interpolate("parsing.any_char / unexpected end of input / s: %A%P()", [[v2_1, v3, v4] as [any, int32, int32]])));
        }
        else {
            const v10: string = v1_1[0];
            const v15 = 1;
            const v29: int32 = (v1_1.length - 1) | 0;
            const v30: string = v1_1.slice(v15, v29 + 1);
            const v35: string = v10;
            const v38: int32 = v35.length | 0;
            const v39: string[] = fill(new Array(v38), 0, v38, "");
            const v40: Mut5 = new Mut5(0);
            while (method23(v38, v40)) {
                const v42: int32 = v40.l0 | 0;
                const v43: string = v35[v42];
                setItem(v39, v42, v43);
                const v44: int32 = (v42 + 1) | 0;
                v40.l0 = (v44 | 0);
            }
            const v45: FSharpList<string> = ofArray<string>(v39);
            const patternInput: [any, int32, int32] = method25(foldBack<string, UH0_$union>(uncurry2(method24()), v45, UH0_UH0_0()), v2_1, v3, v4);
            v79 = US7_US7_0(v10, v30, patternInput[0], patternInput[1], patternInput[2]);
        }
        if (v79.tag === /* US7_0 */ 0) {
            v0_1_mut = (v0_1 + v79.fields[0]);
            v1_1_mut = v79.fields[1];
            v2_1_mut = v79.fields[2];
            v3_mut = v79.fields[3];
            v4_mut = v79.fields[4];
            continue method33;
        }
        else {
            const v95: string = v79.fields[0];
            return [v0_1, v1_1, v2_1, v3, v4] as [string, string, any, int32, int32];
        }
        break;
    }
}

export function method21(v0_1: string): US6_$union {
    let _v0: Option<Option<string>> = undefined;
    _v0 = some(v0_1);
    const v7: string = defaultArg((_v0 == null) ? (() => {
        throw new Error("optionm\'.of_obj / _v0=None");
    })() : value_12(_v0), "");
    const v12: any = StringBuilder_$ctor_Z721C83C5(method22());
    const v15 = (arg10$0040: [string, any, int32, int32]): US7_$union => closure14(undefined, arg10$0040);
    const v16_1 = (arg10$0040_1: [string, any, int32, int32]): US7_$union => closure17(undefined, arg10$0040_1);
    const v20_1: US7_$union = method26(v7, v12, UH1_UH1_1(v15, UH1_UH1_1(v16_1, UH1_UH1_0())));
    let v202: US8_$union;
    if (v20_1.tag === /* US7_0 */ 0) {
        const v25: int32 = v20_1.fields[4] | 0;
        const v24: int32 = v20_1.fields[3] | 0;
        const v23: any = v20_1.fields[2];
        const v22: string = v20_1.fields[1];
        const v21: string = v20_1.fields[0];
        let v130: US7_$union;
        if ("" === v22) {
            v130 = US7_US7_1(toText(interpolate("parsing.none_of / unexpected end of input / chars: %A%P() / s: %A%P()", [["\"", "\'"], [v23, v24, v25] as [any, int32, int32]])));
        }
        else {
            const v42: string = v22[0];
            if (method27(v42, 0n) === false) {
                const v50 = 1;
                const v64: int32 = (v22.length - 1) | 0;
                const v65: string = v22.slice(v50, v64 + 1);
                const v70: string = v42;
                const v73: int32 = v70.length | 0;
                const v74: string[] = fill(new Array(v73), 0, v73, "");
                const v75: Mut5 = new Mut5(0);
                while (method23(v73, v75)) {
                    const v77: int32 = v75.l0 | 0;
                    const v78: string = v70[v77];
                    setItem(v74, v77, v78);
                    const v79: int32 = (v77 + 1) | 0;
                    v75.l0 = (v79 | 0);
                }
                const v80: FSharpList<string> = ofArray<string>(v74);
                const patternInput: [any, int32, int32] = method25(foldBack<string, UH0_$union>(uncurry2(method24()), v80, UH0_UH0_0()), v23, v24, v25);
                v130 = US7_US7_0(v42, v65, patternInput[0], patternInput[1], patternInput[2]);
            }
            else {
                v130 = US7_US7_1(toText(interpolate("parsing.none_of / unexpected char: \'%P()\' / chars: %A%P() / s: %A%P()", [v42, ["\"", "\'"], [v23, v24, v25] as [any, int32, int32]])));
            }
        }
        let v142: US7_$union;
        if (v130.tag === /* US7_0 */ 0) {
            const v131: string = v130.fields[0];
            v142 = US7_US7_0(("\\" === v131) ? "/" : v131, v130.fields[1], v130.fields[2], v130.fields[3], v130.fields[4]);
        }
        else {
            v142 = US7_US7_1(v130.fields[0]);
        }
        let v161: US8_$union;
        if (v142.tag === /* US7_0 */ 0) {
            const patternInput_1: [string, string, any, int32, int32] = method28(v142.fields[0], v142.fields[1], v142.fields[2], v142.fields[3], v142.fields[4]);
            v161 = US8_US8_0(patternInput_1[0], patternInput_1[1], patternInput_1[2], patternInput_1[3], patternInput_1[4]);
        }
        else {
            v161 = US8_US8_1(v142.fields[0]);
        }
        let v171: US8_$union;
        if (v161.tag === /* US8_0 */ 0) {
            v171 = US8_US8_0(v161.fields[0], v161.fields[1], v161.fields[2], v161.fields[3], v161.fields[4]);
        }
        else {
            const v168: string = v161.fields[0];
            v171 = US8_US8_0("", v22, v23, v24, v25);
        }
        if (v171.tag === /* US8_0 */ 0) {
            const v176: int32 = v171.fields[4] | 0;
            const v175: int32 = v171.fields[3] | 0;
            const v174: any = v171.fields[2];
            const v173: string = v171.fields[1];
            const v172: string = v171.fields[0];
            const v180: US7_$union = method29(v173, v174, v175, v176, UH1_UH1_1(v15, UH1_UH1_1(v16_1, UH1_UH1_0())));
            if (v180.tag === /* US7_0 */ 0) {
                const v181: string = v180.fields[0];
                v202 = US8_US8_0(v172, v180.fields[1], v180.fields[2], v180.fields[3], v180.fields[4]);
            }
            else {
                v202 = US8_US8_1(toText(interpolate("parsing.between / expected closing delimiter / e: %A%P() / input: %A%P() / rest1: %A%P() / rest2: %A%P()", [v180.fields[0], [v7, v12, 1, 1] as [string, any, int32, int32], [v22, v23, v24, v25] as [string, any, int32, int32], [v173, v174, v175, v176] as [string, any, int32, int32]])));
            }
        }
        else {
            const v194: string = v171.fields[0];
            v202 = US8_US8_1("parsing.between / expected content");
        }
    }
    else {
        v202 = US8_US8_1(v20_1.fields[0]);
    }
    let v414: US8_$union;
    if (v202.tag === /* US8_0 */ 0) {
        const v207: int32 = v202.fields[4] | 0;
        const v206: int32 = v202.fields[3] | 0;
        const v205: any = v202.fields[2];
        const v204: string = v202.fields[1];
        const v203: string = v202.fields[0];
        v414 = v202;
    }
    else {
        const v208: string = v202.fields[0];
        let v321: US7_$union;
        if ("" === v7) {
            v321 = US7_US7_1(toText(interpolate("parsing.none_of / unexpected end of input / chars: %A%P() / s: %A%P()", [["\"", "\'", " "], [v12, 1, 1] as [any, int32, int32]])));
        }
        else {
            const v228: string = v7[0];
            if (method30(v228, 0n) === false) {
                const v236 = 1;
                const v250: int32 = (v7.length - 1) | 0;
                const v251: string = v7.slice(v236, v250 + 1);
                const v256: string = v228;
                const v259: int32 = v256.length | 0;
                const v260: string[] = fill(new Array(v259), 0, v259, "");
                const v261: Mut5 = new Mut5(0);
                while (method23(v259, v261)) {
                    const v263: int32 = v261.l0 | 0;
                    const v264: string = v256[v263];
                    setItem(v260, v263, v264);
                    const v265: int32 = (v263 + 1) | 0;
                    v261.l0 = (v265 | 0);
                }
                const v266: FSharpList<string> = ofArray<string>(v260);
                const patternInput_2: [any, int32, int32] = method25(foldBack<string, UH0_$union>(uncurry2(method24()), v266, UH0_UH0_0()), v12, 1, 1);
                v321 = US7_US7_0(v228, v251, patternInput_2[0], patternInput_2[1], patternInput_2[2]);
            }
            else {
                v321 = US7_US7_1(toText(interpolate("parsing.none_of / unexpected char: \'%P()\' / chars: %A%P() / s: %A%P()", [v228, ["\"", "\'", " "], [v12, 1, 1] as [any, int32, int32]])));
            }
        }
        let v333: US7_$union;
        if (v321.tag === /* US7_0 */ 0) {
            const v322: string = v321.fields[0];
            v333 = US7_US7_0(("\\" === v322) ? "/" : v322, v321.fields[1], v321.fields[2], v321.fields[3], v321.fields[4]);
        }
        else {
            v333 = US7_US7_1(v321.fields[0]);
        }
        let v352: US8_$union;
        if (v333.tag === /* US7_0 */ 0) {
            const patternInput_3: [string, string, any, int32, int32] = method31(v333.fields[0], v333.fields[1], v333.fields[2], v333.fields[3], v333.fields[4]);
            v352 = US8_US8_0(patternInput_3[0], patternInput_3[1], patternInput_3[2], patternInput_3[3], patternInput_3[4]);
        }
        else {
            v352 = US8_US8_1(v333.fields[0]);
        }
        if (v352.tag === /* US8_0 */ 0) {
            const v357: int32 = v352.fields[4] | 0;
            const v356: int32 = v352.fields[3] | 0;
            const v355: any = v352.fields[2];
            const v354: string = v352.fields[1];
            const v353: string = v352.fields[0];
            v414 = v352;
        }
        else {
            const v358: string = v352.fields[0];
            const v366: US10_$union = (v7.length === 0) ? US10_US10_0(v7, v12, 1, 1) : US10_US10_1(toText(interpolate("parsing.eof / expected end of input / input: %A%P()", [v7])));
            const v375: US8_$union = (v366.tag === /* US10_0 */ 0) ? US8_US8_0("", v366.fields[0], v366.fields[1], v366.fields[2], v366.fields[3]) : US8_US8_1(v366.fields[0]);
            if (v375.tag === /* US8_0 */ 0) {
                const v380: int32 = v375.fields[4] | 0;
                const v379: int32 = v375.fields[3] | 0;
                const v378: any = v375.fields[2];
                const v377: string = v375.fields[1];
                const v376: string = v375.fields[0];
                const v387: int32 = method32(v377, 0) | 0;
                const v401: int32 = (v377.length - 1) | 0;
                v414 = US8_US8_0(v376, v377.slice(v387, v401 + 1), v378, v379, v380);
            }
            else {
                v414 = US8_US8_1(v375.fields[0]);
            }
        }
    }
    let v685: US11_$union;
    if (v414.tag === /* US8_0 */ 0) {
        const v419: int32 = v414.fields[4] | 0;
        const v418: int32 = v414.fields[3] | 0;
        const v417: any = v414.fields[2];
        const v416: string = v414.fields[1];
        const v415: string = v414.fields[0];
        let v544: US7_$union;
        if ("" === v416) {
            v544 = US7_US7_1(toText(interpolate("parsing.p_char / unexpected end of input / c: \'%P()\' / s: %A%P()", [" ", [v417, v418, v419] as [any, int32, int32]])));
        }
        else {
            const v425: string = v416[0];
            if (v425 === " ") {
                const v431 = 1;
                const v445: int32 = (v416.length - 1) | 0;
                const v446: string = v416.slice(v431, v445 + 1);
                const v451: string = v425;
                const v454: int32 = v451.length | 0;
                const v455: string[] = fill(new Array(v454), 0, v454, "");
                const v456: Mut5 = new Mut5(0);
                while (method23(v454, v456)) {
                    const v458: int32 = v456.l0 | 0;
                    const v459: string = v451[v458];
                    setItem(v455, v458, v459);
                    const v460: int32 = (v458 + 1) | 0;
                    v456.l0 = (v460 | 0);
                }
                const v461: FSharpList<string> = ofArray<string>(v455);
                const patternInput_4: [any, int32, int32] = method25(foldBack<string, UH0_$union>(uncurry2(method24()), v461, UH0_UH0_0()), v417, v418, v419);
                v544 = US7_US7_0(v425, v446, patternInput_4[0], patternInput_4[1], patternInput_4[2]);
            }
            else {
                const v496: int32 = v416.length | 0;
                const v503: int32 = (v416.indexOf("\n") - 1) | 0;
                const v508 = 0;
                const v522: int32 = (((-2 === v503) ? (v496 + 1) : (v503 + 1)) - 1) | 0;
                v544 = US7_US7_1(`${`parsing.p_char / expected: '${" "}' / line: ${v418} / col: ${v419}
${v417}${v416.slice(v508, v522 + 1)}`}
${replicate(v419 - 1, " ") + "^"}
`);
            }
        }
        let v556: US12_$union;
        if (v544.tag === /* US7_0 */ 0) {
            v556 = US12_US12_0(US9_US9_0(v544.fields[0]), v544.fields[1], v544.fields[2], v544.fields[3], v544.fields[4]);
        }
        else {
            const v552: string = v544.fields[0];
            v556 = US12_US12_0(US9_US9_1(), v416, v417, v418, v419);
        }
        let v659: US8_$union;
        if (v556.tag === /* US12_0 */ 0) {
            const v561: int32 = v556.fields[4] | 0;
            const v560: int32 = v556.fields[3] | 0;
            const v559: any = v556.fields[2];
            const v558: string = v556.fields[1];
            const v557: US9_$union = v556.fields[0];
            let v636: US7_$union;
            if ("" === v558) {
                v636 = US7_US7_1(toText(interpolate("parsing.any_char / unexpected end of input / s: %A%P()", [[v559, v560, v561] as [any, int32, int32]])));
            }
            else {
                const v567: string = v558[0];
                const v572 = 1;
                const v586: int32 = (v558.length - 1) | 0;
                const v587: string = v558.slice(v572, v586 + 1);
                const v592: string = v567;
                const v595: int32 = v592.length | 0;
                const v596: string[] = fill(new Array(v595), 0, v595, "");
                const v597: Mut5 = new Mut5(0);
                while (method23(v595, v597)) {
                    const v599: int32 = v597.l0 | 0;
                    const v600: string = v592[v599];
                    setItem(v596, v599, v600);
                    const v601: int32 = (v599 + 1) | 0;
                    v597.l0 = (v601 | 0);
                }
                const v602: FSharpList<string> = ofArray<string>(v596);
                const patternInput_5: [any, int32, int32] = method25(foldBack<string, UH0_$union>(uncurry2(method24()), v602, UH0_UH0_0()), v559, v560, v561);
                v636 = US7_US7_0(v567, v587, patternInput_5[0], patternInput_5[1], patternInput_5[2]);
            }
            if (v636.tag === /* US7_0 */ 0) {
                const patternInput_6: [string, string, any, int32, int32] = method33(v636.fields[0], v636.fields[1], v636.fields[2], v636.fields[3], v636.fields[4]);
                v659 = US8_US8_0(patternInput_6[0], patternInput_6[1], patternInput_6[2], patternInput_6[3], patternInput_6[4]);
            }
            else {
                v659 = US8_US8_1(v636.fields[0]);
            }
        }
        else {
            v659 = US8_US8_1(v556.fields[0]);
        }
        let v671: US13_$union;
        if (v659.tag === /* US8_0 */ 0) {
            v671 = US13_US13_0(US5_US5_0(v659.fields[0]), v659.fields[1], v659.fields[2], v659.fields[3], v659.fields[4]);
        }
        else {
            const v667: string = v659.fields[0];
            v671 = US13_US13_0(US5_US5_1(), v416, v417, v418, v419);
        }
        v685 = ((v671.tag === /* US13_0 */ 0) ? US11_US11_0(v415, v671.fields[0], v671.fields[1], v671.fields[2], v671.fields[3], v671.fields[4]) : US11_US11_1(v671.fields[0]));
    }
    else {
        v685 = US11_US11_1(v414.fields[0]);
    }
    if (v685.tag === /* US11_0 */ 0) {
        const v691: int32 = v685.fields[5] | 0;
        const v690: int32 = v685.fields[4] | 0;
        const v689: any = v685.fields[3];
        const v688: string = v685.fields[2];
        return US6_US6_0(v685.fields[0], v685.fields[1]);
    }
    else {
        return US6_US6_1(v685.fields[0]);
    }
}

export function method34(): string {
    const v2_1: string = "Debug".toLocaleLowerCase();
    return ("\u001b[94m" + method11(v2_1[0])) + method13();
}

export function method36(v0_1: string, v1_1: US5_$union, v2_1: string, v3: Option<any>, v4: [string, string][], v5: Option<((arg0: [int32, string, boolean]) => any)>, v6: Option<((arg0: any) => void)>, v7: boolean, v8: Option<string>): string {
    const v10: Mut3 = new Mut3(method12());
    let v17_1: any;
    closure7(v10, `${"{ "}`, undefined);
    v17_1 = undefined;
    let v26: any;
    closure7(v10, `${"file_name"}`, undefined);
    v26 = undefined;
    let v35: any;
    closure7(v10, `${" = "}`, undefined);
    v35 = undefined;
    let v43: any;
    closure7(v10, `${v0_1}`, undefined);
    v43 = undefined;
    let v52: any;
    closure7(v10, `${"; "}`, undefined);
    v52 = undefined;
    let v61: any;
    closure7(v10, `${"arguments"}`, undefined);
    v61 = undefined;
    let v69: any;
    closure7(v10, `${" = "}`, undefined);
    v69 = undefined;
    let v80: any;
    closure7(v10, `${toText(interpolate("%A%P()", [v1_1]))}`, undefined);
    v80 = undefined;
    let v88: any;
    closure7(v10, `${"; "}`, undefined);
    v88 = undefined;
    let v97: any;
    closure7(v10, `${"options"}`, undefined);
    v97 = undefined;
    let v105: any;
    closure7(v10, `${" = "}`, undefined);
    v105 = undefined;
    let v113: any;
    closure7(v10, `${"{ "}`, undefined);
    v113 = undefined;
    let v122: any;
    closure7(v10, `${"command"}`, undefined);
    v122 = undefined;
    let v130: any;
    closure7(v10, `${" = "}`, undefined);
    v130 = undefined;
    let v138: any;
    closure7(v10, `${v2_1}`, undefined);
    v138 = undefined;
    let v146: any;
    closure7(v10, `${"; "}`, undefined);
    v146 = undefined;
    let v155: any;
    closure7(v10, `${"cancellation_token"}`, undefined);
    v155 = undefined;
    let v163: any;
    closure7(v10, `${" = "}`, undefined);
    v163 = undefined;
    let v201: any;
    closure7(v10, `${toText(interpolate("%A%P()", [v3]))}`, undefined);
    v201 = undefined;
    let v209: any;
    closure7(v10, `${"; "}`, undefined);
    v209 = undefined;
    let v218: any;
    closure7(v10, `${"environment_variables"}`, undefined);
    v218 = undefined;
    let v226: any;
    closure7(v10, `${" = "}`, undefined);
    v226 = undefined;
    let v237: any;
    closure7(v10, `${toText(interpolate("%A%P()", [v4]))}`, undefined);
    v237 = undefined;
    let v245: any;
    closure7(v10, `${"; "}`, undefined);
    v245 = undefined;
    let v254: any;
    closure7(v10, `${"on_line"}`, undefined);
    v254 = undefined;
    let v262: any;
    closure7(v10, `${" = "}`, undefined);
    v262 = undefined;
    let v300: any;
    closure7(v10, `${toText(interpolate("%A%P()", [v5]))}`, undefined);
    v300 = undefined;
    let v308: any;
    closure7(v10, `${"; "}`, undefined);
    v308 = undefined;
    let v317: any;
    closure7(v10, `${"stdin"}`, undefined);
    v317 = undefined;
    let v325: any;
    closure7(v10, `${" = "}`, undefined);
    v325 = undefined;
    let v363: any;
    closure7(v10, `${toText(interpolate("%A%P()", [v6]))}`, undefined);
    v363 = undefined;
    let v371: any;
    closure7(v10, `${"; "}`, undefined);
    v371 = undefined;
    let v380: any;
    closure7(v10, `${"trace"}`, undefined);
    v380 = undefined;
    let v388: any;
    closure7(v10, `${" = "}`, undefined);
    v388 = undefined;
    let v399: any;
    closure7(v10, `${v7 ? "true" : "false"}`, undefined);
    v399 = undefined;
    let v407: any;
    closure7(v10, `${"; "}`, undefined);
    v407 = undefined;
    let v416: any;
    closure7(v10, `${"working_directory"}`, undefined);
    v416 = undefined;
    let v424: any;
    closure7(v10, `${" = "}`, undefined);
    v424 = undefined;
    let v462: any;
    closure7(v10, `${toText(interpolate("%A%P()", [v8]))}`, undefined);
    v462 = undefined;
    let v471: any;
    closure7(v10, `${" }"}`, undefined);
    v471 = undefined;
    let v479: any;
    closure7(v10, `${" }"}`, undefined);
    v479 = undefined;
    return v10.l0;
}

export function method35(v0_1: Mut0, v1_1: Mut1, v2_1: Mut2, v3: Mut3, v4: Mut4, v5: Option<int64>, v6: string, v7: string, v8: string, v9: US5_$union, v10: string, v11: Option<any>, v12: [string, string][], v13: Option<((arg0: [int32, string, boolean]) => any)>, v14: Option<((arg0: any) => void)>, v15: boolean, v16_1: Option<string>): string {
    const v17_1: string = method36(v8, v9, v10, v11, v12, v13, v14, v15, v16_1);
    return method16(`${v6} ${v7} #${v0_1.l0} ${"runtime.execute_with_options_async"} / ${v17_1}`);
}

export function closure18(v0_1: string, v1_1: Option<any>, v2_1: [string, string][], v3: Option<((arg0: [int32, string, boolean]) => any)>, v4: Option<((arg0: any) => void)>, v5: boolean, v6: Option<string>, v7: US5_$union, v8: string, unitVar: void): void {
    if (method5(US0_US0_1())) {
        let v13: any;
        closure0(undefined, undefined);
        v13 = undefined;
        const patternInput: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_12(TraceState_trace_state());
        const v32: Option<int64> = patternInput[5];
        const v31: Mut4 = patternInput[4];
        const v30: Mut3 = patternInput[3];
        const v29: Mut2 = patternInput[2];
        const v28: Mut1 = patternInput[1];
        const v27: Mut0 = patternInput[0];
        method17(method35(v27, v28, v29, v30, v31, v32, method6(v27, v28, v29, v30, v31, v32), method34(), v8, v7, v0_1, v1_1, v2_1, v3, v4, v5, v6));
    }
}

export function method37(v0_1: string, v1_1: Option<any>, v2_1: [string, string][], v3: Option<((arg0: [int32, string, boolean]) => any)>, v4: Option<((arg0: any) => void)>, v5: boolean, v6: Option<string>): [string, string][] {
    return v2_1;
}

export function closure20(unitVar: void, v0_1: ((arg0: [int32, string, boolean]) => any)): US14_$union {
    return US14_US14_0(v0_1);
}

export function method38(): ((arg0: ((arg0: [int32, string, boolean]) => any)) => US14_$union) {
    return (v: ((arg0: [int32, string, boolean]) => any)): US14_$union => closure20(undefined, v);
}

export function method39(): string {
    const v2_1: string = "Verbose".toLocaleLowerCase();
    return ("\u001b[90m" + method11(v2_1[0])) + method13();
}

export function method40(v0_1: Mut0, v1_1: Mut1, v2_1: Mut2, v3: Mut3, v4: Mut4, v5: Option<int64>, v6: string, v7: string, v8: string): string {
    const v9: string = method15();
    return method16(`${v6} ${v7} #${v0_1.l0} ${v8} / ${v9}`);
}

export function closure21(v0_1: string, unitVar: void): void {
    if (method5(US0_US0_0())) {
        let v5: any;
        closure0(undefined, undefined);
        v5 = undefined;
        const patternInput: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_12(TraceState_trace_state());
        const v24: Option<int64> = patternInput[5];
        const v23: Mut4 = patternInput[4];
        const v22: Mut3 = patternInput[3];
        const v21: Mut2 = patternInput[2];
        const v20_1: Mut1 = patternInput[1];
        const v19_1: Mut0 = patternInput[0];
        method17((v0_1 === "") ? "" : method40(v19_1, v20_1, v21, v22, v23, v24, method6(v19_1, v20_1, v21, v22, v23, v24), method39(), v0_1));
    }
}

export function closure19(v0_1: string, v1_1: Option<any>, v2_1: [string, string][], v3: Option<((arg0: [int32, string, boolean]) => any)>, v4: Option<((arg0: any) => void)>, v5: boolean, v6: Option<string>, v7: void, v8: any, v9: void): void {
    startImmediate(singleton.Delay<void>((): any => {
        let v64: US14_$union, v94: any;
        const v41: string = defaultOf();
        const v50: boolean = (v41 === defaultOf()) !== true;
        return singleton.Combine<void>(v50 ? ((v64 = defaultArg(map<((arg0: [int32, string, boolean]) => any), US14_$union>(method38(), v3), US14_US14_1()), singleton.Combine<void>((v64.tag === /* US14_0 */ 0) ? ((v94 = v64.fields[0]([defaultOf(), v41, false] as [int32, string, boolean]), singleton.Bind<void, void>(v94, (): any => {
            return singleton.Zero();
        }))) : (singleton.Zero()), singleton.Delay<void>((): any => {
            let v98: any, v143: any;
            const v95 = `> ${v41}`;
            return singleton.Combine<void>(v5 ? ((v98 = ((closure21(v95, undefined), undefined)), singleton.Zero())) : ((v143 = ((closure10(v95, undefined), undefined)), singleton.Zero())), singleton.Delay<void>((): any => {
                const v146 = `${""}${v41}${""}`;
                return singleton.Zero();
            }));
        })))) : singleton.Zero(), singleton.Delay<void>((): any => {
            return singleton.Zero();
        }));
    }));
}

export function closure22(v0_1: string, v1_1: Option<any>, v2_1: [string, string][], v3: Option<((arg0: [int32, string, boolean]) => any)>, v4: Option<((arg0: any) => void)>, v5: boolean, v6: Option<string>, v7: void, v8: any, v9: void): void {
    startImmediate(singleton.Delay<void>((): any => {
        let v64: US14_$union, v94: any;
        const v41: string = defaultOf();
        const v50: boolean = (v41 === defaultOf()) !== true;
        return singleton.Combine<void>(v50 ? ((v64 = defaultArg(map<((arg0: [int32, string, boolean]) => any), US14_$union>(method38(), v3), US14_US14_1()), singleton.Combine<void>((v64.tag === /* US14_0 */ 0) ? ((v94 = v64.fields[0]([defaultOf(), v41, true] as [int32, string, boolean]), singleton.Bind<void, void>(v94, (): any => {
            return singleton.Zero();
        }))) : (singleton.Zero()), singleton.Delay<void>((): any => {
            let v98: any, v143: any;
            const v95 = `! ${v41}`;
            return singleton.Combine<void>(v5 ? ((v98 = ((closure21(v95, undefined), undefined)), singleton.Zero())) : ((v143 = ((closure10(v95, undefined), undefined)), singleton.Zero())), singleton.Delay<void>((): any => {
                const v147 = `${"\u001b[7;4m"}${v41}${"\u001b[0m"}`;
                return singleton.Zero();
            }));
        })))) : singleton.Zero(), singleton.Delay<void>((): any => {
            return singleton.Zero();
        }));
    }));
}

export function closure23(unitVar: void, v0_1: any): US15_$union {
    return US15_US15_0(v0_1);
}

export function method41(): ((arg0: any) => US15_$union) {
    return (v: any): US15_$union => closure23(undefined, v);
}

export function closure24(v0_1: void, unitVar: void): void {
    if (defaultOf() === false) {
    }
}

export function method43(v0_1: any): string {
    const v2_1: Mut3 = new Mut3(method12());
    let v9: any;
    closure7(v2_1, `${"{ "}`, undefined);
    v9 = undefined;
    let v18_1: any;
    closure7(v2_1, `${"ex"}`, undefined);
    v18_1 = undefined;
    let v27: any;
    closure7(v2_1, `${" = "}`, undefined);
    v27 = undefined;
    let v65: any;
    closure7(v2_1, `${toText(interpolate("%A%P()", [v0_1]))}`, undefined);
    v65 = undefined;
    let v74: any;
    closure7(v2_1, `${" }"}`, undefined);
    v74 = undefined;
    return v2_1.l0;
}

export function method42(v0_1: Mut0, v1_1: Mut1, v2_1: Mut2, v3: Mut3, v4: Mut4, v5: Option<int64>, v6: string, v7: string, v8: any): string {
    const v9: string = method43(v8);
    return method16(`${v6} ${v7} #${v0_1.l0} ${"runtime.execute_with_options_async / WaitForExitAsync"} / ${v9}`);
}

export function closure25(v0_1: any, unitVar: void): void {
    if (method5(US0_US0_3())) {
        let v5: any;
        closure0(undefined, undefined);
        v5 = undefined;
        const patternInput: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_12(TraceState_trace_state());
        const v24: Option<int64> = patternInput[5];
        const v23: Mut4 = patternInput[4];
        const v22: Mut3 = patternInput[3];
        const v21: Mut2 = patternInput[2];
        const v20_1: Mut1 = patternInput[1];
        const v19_1: Mut0 = patternInput[0];
        method17(method42(v19_1, v20_1, v21, v22, v23, v24, method6(v19_1, v20_1, v21, v22, v23, v24), method10(), v0_1));
    }
}

export function method44(): string {
    return "\n";
}

export function method46(v0_1: int32, v1_1: int32): string {
    const v3: Mut3 = new Mut3(method12());
    let v10: any;
    closure7(v3, `${"{ "}`, undefined);
    v10 = undefined;
    let v19_1: any;
    closure7(v3, `${"exit_code"}`, undefined);
    v19_1 = undefined;
    let v28: any;
    closure7(v3, `${" = "}`, undefined);
    v28 = undefined;
    let v36: any;
    closure7(v3, `${v0_1}`, undefined);
    v36 = undefined;
    let v45: any;
    closure7(v3, `${"; "}`, undefined);
    v45 = undefined;
    let v54: any;
    closure7(v3, `${"output_length"}`, undefined);
    v54 = undefined;
    let v62: any;
    closure7(v3, `${" = "}`, undefined);
    v62 = undefined;
    let v70: any;
    closure7(v3, `${v1_1}`, undefined);
    v70 = undefined;
    let v79: any;
    closure7(v3, `${" }"}`, undefined);
    v79 = undefined;
    return v3.l0;
}

export function method45(v0_1: Mut0, v1_1: Mut1, v2_1: Mut2, v3: Mut3, v4: Mut4, v5: Option<int64>, v6: string, v7: string, v8: int32, v9: int32): string {
    const v10: string = method46(v8, v9);
    return method16(`${v6} ${v7} #${v0_1.l0} ${"runtime.execute_with_options_async"} / ${v10}`);
}

export function closure26(v0_1: int32, v1_1: string, unitVar: void): void {
    if (method5(US0_US0_1())) {
        let v6: any;
        closure0(undefined, undefined);
        v6 = undefined;
        const patternInput: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = value_12(TraceState_trace_state());
        const v25: Option<int64> = patternInput[5];
        const v24: Mut4 = patternInput[4];
        const v23: Mut3 = patternInput[3];
        const v22: Mut2 = patternInput[2];
        const v21: Mut1 = patternInput[1];
        const v20_1: Mut0 = patternInput[0];
        method17(method45(v20_1, v21, v22, v23, v24, v25, method6(v20_1, v21, v22, v23, v24, v25), method34(), v0_1, v1_1.length));
    }
}

export function method20(v0_1: string, v1_1: Option<any>, v2_1: [string, string][], v3: Option<((arg0: [int32, string, boolean]) => any)>, v4: Option<((arg0: any) => void)>, v5: boolean, v6: Option<string>): any {
    return defaultOf();
}

export function closure13(unitVar: void, v0_1: string): any {
    return method20(v0_1, undefined, [], undefined, undefined, true, undefined);
}

export function closure27(unitVar: void, _arg: [string, Option<any>, [string, string][], Option<((arg0: [int32, string, boolean]) => any)>, Option<((arg0: any) => void)>, boolean, Option<string>]): any {
    return method20(_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6]);
}

export function closure28(unitVar: void, v0_1: ((arg0: Heap0) => Heap0)): [string, Option<any>, [string, string][], Option<((arg0: [int32, string, boolean]) => any)>, Option<((arg0: any) => void)>, boolean, Option<string>] {
    const v8: Heap0 = v0_1(new Heap0("", undefined, [], undefined, undefined, true, undefined));
    return [v8.l0, v8.l1, v8.l2, v8.l3, v8.l4, v8.l5, v8.l6] as [string, Option<any>, [string, string][], Option<((arg0: [int32, string, boolean]) => any)>, Option<((arg0: any) => void)>, boolean, Option<string>];
}

export function method49(v0_1_mut: string, v1_1_mut: int64): boolean {
    method49:
    while (true) {
        const v0_1: string = v0_1_mut, v1_1: int64 = v1_1_mut;
        if (compare_1(v1_1, 4n) >= 0) {
            return false;
        }
        else {
            let v19_1: US9_$union;
            if (equals(v1_1, 0n)) {
                v19_1 = US9_US9_0("\\");
            }
            else {
                const v5: int64 = toInt64(op_Subtraction(v1_1, 1n));
                if (equals(v5, 0n)) {
                    v19_1 = US9_US9_0("`");
                }
                else {
                    const v8: int64 = toInt64(op_Subtraction(v5, 1n));
                    if (equals(v8, 0n)) {
                        v19_1 = US9_US9_0("\"");
                    }
                    else {
                        const v11: int64 = toInt64(op_Subtraction(v8, 1n));
                        if (equals(v11, 0n)) {
                            v19_1 = US9_US9_0(" ");
                        }
                        else {
                            const v14: int64 = toInt64(op_Subtraction(v11, 1n));
                            v19_1 = US9_US9_1();
                        }
                    }
                }
            }
            if (v0_1 === ((v19_1.tag === /* US9_0 */ 0) ? v19_1.fields[0] : (() => {
                throw new Error("Option does not have a value.");
            })())) {
                return true;
            }
            else {
                v0_1_mut = v0_1;
                v1_1_mut = toInt64(op_Addition(v1_1, 1n));
                continue method49;
            }
        }
        break;
    }
}

export function method50(v0_1_mut: string, v1_1_mut: string, v2_1_mut: any, v3_mut: int32, v4_mut: int32): [string, string, any, int32, int32] {
    method50:
    while (true) {
        const v0_1: string = v0_1_mut, v1_1: string = v1_1_mut, v2_1: any = v2_1_mut, v3: int32 = v3_mut, v4: int32 = v4_mut;
        let v121: US7_$union;
        if ("" === v1_1) {
            v121 = US7_US7_1(toText(interpolate("parsing.none_of / unexpected end of input / chars: %A%P() / s: %A%P()", [["\\", "`", "\"", " "], [v2_1, v3, v4] as [any, int32, int32]])));
        }
        else {
            const v27: string = v1_1[0];
            if (method49(v27, 0n) === false) {
                const v35 = 1;
                const v49: int32 = (v1_1.length - 1) | 0;
                const v50: string = v1_1.slice(v35, v49 + 1);
                const v55: string = v27;
                const v58: int32 = v55.length | 0;
                const v59: string[] = fill(new Array(v58), 0, v58, "");
                const v60: Mut5 = new Mut5(0);
                while (method23(v58, v60)) {
                    const v62: int32 = v60.l0 | 0;
                    const v63: string = v55[v62];
                    setItem(v59, v62, v63);
                    const v64: int32 = (v62 + 1) | 0;
                    v60.l0 = (v64 | 0);
                }
                const v65: FSharpList<string> = ofArray<string>(v59);
                const patternInput: [any, int32, int32] = method25(foldBack<string, UH0_$union>(uncurry2(method24()), v65, UH0_UH0_0()), v2_1, v3, v4);
                v121 = US7_US7_0(v27, v50, patternInput[0], patternInput[1], patternInput[2]);
            }
            else {
                v121 = US7_US7_1(toText(interpolate("parsing.none_of / unexpected char: \'%P()\' / chars: %A%P() / s: %A%P()", [v27, ["\\", "`", "\"", " "], [v2_1, v3, v4] as [any, int32, int32]])));
            }
        }
        if (v121.tag === /* US7_0 */ 0) {
            v0_1_mut = (v0_1 + v121.fields[0]);
            v1_1_mut = v121.fields[1];
            v2_1_mut = v121.fields[2];
            v3_mut = v121.fields[3];
            v4_mut = v121.fields[4];
            continue method50;
        }
        else {
            const v137: string = v121.fields[0];
            return [v0_1, v1_1, v2_1, v3, v4] as [string, string, any, int32, int32];
        }
        break;
    }
}

export function method52(v0_1_mut: string, v1_1_mut: int64): boolean {
    method52:
    while (true) {
        const v0_1: string = v0_1_mut, v1_1: int64 = v1_1_mut;
        if (compare_1(v1_1, 3n) >= 0) {
            return false;
        }
        else {
            let v15: US9_$union;
            if (equals(v1_1, 0n)) {
                v15 = US9_US9_0("\\");
            }
            else {
                const v5: int64 = toInt64(op_Subtraction(v1_1, 1n));
                if (equals(v5, 0n)) {
                    v15 = US9_US9_0("`");
                }
                else {
                    const v8: int64 = toInt64(op_Subtraction(v5, 1n));
                    if (equals(v8, 0n)) {
                        v15 = US9_US9_0("\"");
                    }
                    else {
                        const v11: int64 = toInt64(op_Subtraction(v8, 1n));
                        v15 = US9_US9_1();
                    }
                }
            }
            if (v0_1 === ((v15.tag === /* US9_0 */ 0) ? v15.fields[0] : (() => {
                throw new Error("Option does not have a value.");
            })())) {
                return true;
            }
            else {
                v0_1_mut = v0_1;
                v1_1_mut = toInt64(op_Addition(v1_1, 1n));
                continue method52;
            }
        }
        break;
    }
}

export function closure30(unitVar: void, _arg: [string, any, int32, int32]): US8_$union {
    const v3: int32 = _arg[3] | 0;
    const v2_1: int32 = _arg[2] | 0;
    const v1_1: any = _arg[1];
    const v0_1: string = _arg[0];
    let v128: US7_$union;
    if ("" === v0_1) {
        v128 = US7_US7_1(toText(interpolate("parsing.p_char / unexpected end of input / c: \'%P()\' / s: %A%P()", ["\\", [v1_1, v2_1, v3] as [any, int32, int32]])));
    }
    else {
        const v9: string = v0_1[0];
        if (v9 === "\\") {
            const v15 = 1;
            const v29: int32 = (v0_1.length - 1) | 0;
            const v30: string = v0_1.slice(v15, v29 + 1);
            const v35: string = v9;
            const v38: int32 = v35.length | 0;
            const v39: string[] = fill(new Array(v38), 0, v38, "");
            const v40: Mut5 = new Mut5(0);
            while (method23(v38, v40)) {
                const v42: int32 = v40.l0 | 0;
                const v43: string = v35[v42];
                setItem(v39, v42, v43);
                const v44: int32 = (v42 + 1) | 0;
                v40.l0 = (v44 | 0);
            }
            const v45: FSharpList<string> = ofArray<string>(v39);
            const patternInput: [any, int32, int32] = method25(foldBack<string, UH0_$union>(uncurry2(method24()), v45, UH0_UH0_0()), v1_1, v2_1, v3);
            v128 = US7_US7_0(v9, v30, patternInput[0], patternInput[1], patternInput[2]);
        }
        else {
            const v80: int32 = v0_1.length | 0;
            const v87: int32 = (v0_1.indexOf("\n") - 1) | 0;
            const v92 = 0;
            const v106: int32 = (((-2 === v87) ? (v80 + 1) : (v87 + 1)) - 1) | 0;
            v128 = US7_US7_1(`${`parsing.p_char / expected: '${"\\"}' / line: ${v2_1} / col: ${v3}
${v1_1}${v0_1.slice(v92, v106 + 1)}`}
${replicate(v3 - 1, " ") + "^"}
`);
        }
    }
    let v212: US7_$union;
    if (v128.tag === /* US7_0 */ 0) {
        const v133: int32 = v128.fields[4] | 0;
        const v132: int32 = v128.fields[3] | 0;
        const v131: any = v128.fields[2];
        const v130: string = v128.fields[1];
        const v129: string = v128.fields[0];
        if ("" === v130) {
            v212 = US7_US7_1(toText(interpolate("parsing.any_char / unexpected end of input / s: %A%P()", [[v131, v132, v133] as [any, int32, int32]])));
        }
        else {
            const v139: string = v130[0];
            const v144 = 1;
            const v158: int32 = (v130.length - 1) | 0;
            const v159: string = v130.slice(v144, v158 + 1);
            const v164: string = v139;
            const v167: int32 = v164.length | 0;
            const v168: string[] = fill(new Array(v167), 0, v167, "");
            const v169: Mut5 = new Mut5(0);
            while (method23(v167, v169)) {
                const v171: int32 = v169.l0 | 0;
                const v172: string = v164[v171];
                setItem(v168, v171, v172);
                const v173: int32 = (v171 + 1) | 0;
                v169.l0 = (v173 | 0);
            }
            const v174: FSharpList<string> = ofArray<string>(v168);
            const patternInput_1: [any, int32, int32] = method25(foldBack<string, UH0_$union>(uncurry2(method24()), v174, UH0_UH0_0()), v131, v132, v133);
            v212 = US7_US7_0(v139, v159, patternInput_1[0], patternInput_1[1], patternInput_1[2]);
        }
    }
    else {
        v212 = US7_US7_1(v128.fields[0]);
    }
    if (v212.tag === /* US7_0 */ 0) {
        return US8_US8_0("\\" + v212.fields[0], v212.fields[1], v212.fields[2], v212.fields[3], v212.fields[4]);
    }
    else {
        return US8_US8_1(v212.fields[0]);
    }
}

export function closure31(unitVar: void, _arg: [string, any, int32, int32]): US8_$union {
    const v3: int32 = _arg[3] | 0;
    const v2_1: int32 = _arg[2] | 0;
    const v1_1: any = _arg[1];
    const v0_1: string = _arg[0];
    let v128: US7_$union;
    if ("" === v0_1) {
        v128 = US7_US7_1(toText(interpolate("parsing.p_char / unexpected end of input / c: \'%P()\' / s: %A%P()", ["`", [v1_1, v2_1, v3] as [any, int32, int32]])));
    }
    else {
        const v9: string = v0_1[0];
        if (v9 === "`") {
            const v15 = 1;
            const v29: int32 = (v0_1.length - 1) | 0;
            const v30: string = v0_1.slice(v15, v29 + 1);
            const v35: string = v9;
            const v38: int32 = v35.length | 0;
            const v39: string[] = fill(new Array(v38), 0, v38, "");
            const v40: Mut5 = new Mut5(0);
            while (method23(v38, v40)) {
                const v42: int32 = v40.l0 | 0;
                const v43: string = v35[v42];
                setItem(v39, v42, v43);
                const v44: int32 = (v42 + 1) | 0;
                v40.l0 = (v44 | 0);
            }
            const v45: FSharpList<string> = ofArray<string>(v39);
            const patternInput: [any, int32, int32] = method25(foldBack<string, UH0_$union>(uncurry2(method24()), v45, UH0_UH0_0()), v1_1, v2_1, v3);
            v128 = US7_US7_0(v9, v30, patternInput[0], patternInput[1], patternInput[2]);
        }
        else {
            const v80: int32 = v0_1.length | 0;
            const v87: int32 = (v0_1.indexOf("\n") - 1) | 0;
            const v92 = 0;
            const v106: int32 = (((-2 === v87) ? (v80 + 1) : (v87 + 1)) - 1) | 0;
            v128 = US7_US7_1(`${`parsing.p_char / expected: '${"`"}' / line: ${v2_1} / col: ${v3}
${v1_1}${v0_1.slice(v92, v106 + 1)}`}
${replicate(v3 - 1, " ") + "^"}
`);
        }
    }
    let v212: US7_$union;
    if (v128.tag === /* US7_0 */ 0) {
        const v133: int32 = v128.fields[4] | 0;
        const v132: int32 = v128.fields[3] | 0;
        const v131: any = v128.fields[2];
        const v130: string = v128.fields[1];
        const v129: string = v128.fields[0];
        if ("" === v130) {
            v212 = US7_US7_1(toText(interpolate("parsing.any_char / unexpected end of input / s: %A%P()", [[v131, v132, v133] as [any, int32, int32]])));
        }
        else {
            const v139: string = v130[0];
            const v144 = 1;
            const v158: int32 = (v130.length - 1) | 0;
            const v159: string = v130.slice(v144, v158 + 1);
            const v164: string = v139;
            const v167: int32 = v164.length | 0;
            const v168: string[] = fill(new Array(v167), 0, v167, "");
            const v169: Mut5 = new Mut5(0);
            while (method23(v167, v169)) {
                const v171: int32 = v169.l0 | 0;
                const v172: string = v164[v171];
                setItem(v168, v171, v172);
                const v173: int32 = (v171 + 1) | 0;
                v169.l0 = (v173 | 0);
            }
            const v174: FSharpList<string> = ofArray<string>(v168);
            const patternInput_1: [any, int32, int32] = method25(foldBack<string, UH0_$union>(uncurry2(method24()), v174, UH0_UH0_0()), v131, v132, v133);
            v212 = US7_US7_0(v139, v159, patternInput_1[0], patternInput_1[1], patternInput_1[2]);
        }
    }
    else {
        v212 = US7_US7_1(v128.fields[0]);
    }
    if (v212.tag === /* US7_0 */ 0) {
        return US8_US8_0("`" + v212.fields[0], v212.fields[1], v212.fields[2], v212.fields[3], v212.fields[4]);
    }
    else {
        return US8_US8_1(v212.fields[0]);
    }
}

export function method53(v0_1_mut: string, v1_1_mut: any, v2_1_mut: int32, v3_mut: int32, v4_mut: UH3_$union): US8_$union {
    method53:
    while (true) {
        const v0_1: string = v0_1_mut, v1_1: any = v1_1_mut, v2_1: int32 = v2_1_mut, v3: int32 = v3_mut, v4: UH3_$union = v4_mut;
        if (v4.tag === /* UH3_0 */ 0) {
            return US8_US8_1("parsing.choice / no parsers succeeded");
        }
        else {
            const v8: UH3_$union = v4.fields[1];
            const v9: US8_$union = v4.fields[0]([v0_1, v1_1, v2_1, v3] as [string, any, int32, int32]);
            if (v9.tag === /* US8_0 */ 0) {
                const v14: int32 = v9.fields[4] | 0;
                const v13: int32 = v9.fields[3] | 0;
                const v12: any = v9.fields[2];
                const v11: string = v9.fields[1];
                const v10: string = v9.fields[0];
                return v9;
            }
            else {
                const v15: string = v9.fields[0];
                v0_1_mut = v0_1;
                v1_1_mut = v1_1;
                v2_1_mut = v2_1;
                v3_mut = v3;
                v4_mut = v8;
                continue method53;
            }
        }
        break;
    }
}

export function method54(v0_1_mut: UH2_$union, v1_1_mut: UH2_$union): UH2_$union {
    method54:
    while (true) {
        const v0_1: UH2_$union = v0_1_mut, v1_1: UH2_$union = v1_1_mut;
        if (v0_1.tag === /* UH2_0 */ 0) {
            return v1_1;
        }
        else {
            v0_1_mut = v0_1.fields[1];
            v1_1_mut = UH2_UH2_1(v0_1.fields[0], v1_1);
            continue method54;
        }
        break;
    }
}

export function method51(v0_1_mut: UH2_$union, v1_1_mut: string, v2_1_mut: any, v3_mut: int32, v4_mut: int32): US17_$union {
    method51:
    while (true) {
        const v0_1: UH2_$union = v0_1_mut, v1_1: string = v1_1_mut, v2_1: any = v2_1_mut, v3: int32 = v3_mut, v4: int32 = v4_mut;
        let v115: US7_$union;
        if ("" === v1_1) {
            v115 = US7_US7_1(toText(interpolate("parsing.none_of / unexpected end of input / chars: %A%P() / s: %A%P()", [["\\", "`", "\""], [v2_1, v3, v4] as [any, int32, int32]])));
        }
        else {
            const v24: string = v1_1[0];
            if (method52(v24, 0n) === false) {
                const v32 = 1;
                const v46: int32 = (v1_1.length - 1) | 0;
                const v47: string = v1_1.slice(v32, v46 + 1);
                const v52: string = v24;
                const v55: int32 = v52.length | 0;
                const v56: string[] = fill(new Array(v55), 0, v55, "");
                const v57: Mut5 = new Mut5(0);
                while (method23(v55, v57)) {
                    const v59: int32 = v57.l0 | 0;
                    const v60: string = v52[v59];
                    setItem(v56, v59, v60);
                    const v61: int32 = (v59 + 1) | 0;
                    v57.l0 = (v61 | 0);
                }
                const v62: FSharpList<string> = ofArray<string>(v56);
                const patternInput: [any, int32, int32] = method25(foldBack<string, UH0_$union>(uncurry2(method24()), v62, UH0_UH0_0()), v2_1, v3, v4);
                v115 = US7_US7_0(v24, v47, patternInput[0], patternInput[1], patternInput[2]);
            }
            else {
                v115 = US7_US7_1(toText(interpolate("parsing.none_of / unexpected char: \'%P()\' / chars: %A%P() / s: %A%P()", [v24, ["\\", "`", "\""], [v2_1, v3, v4] as [any, int32, int32]])));
            }
        }
        const v129: US8_$union = (v115.tag === /* US7_0 */ 0) ? US8_US8_0(v115.fields[0], v115.fields[1], v115.fields[2], v115.fields[3], v115.fields[4]) : US8_US8_1(v115.fields[0]);
        let v143: US8_$union;
        if (v129.tag === /* US8_0 */ 0) {
            const v134: int32 = v129.fields[4] | 0;
            const v133: int32 = v129.fields[3] | 0;
            const v132: any = v129.fields[2];
            const v131: string = v129.fields[1];
            const v130: string = v129.fields[0];
            v143 = v129;
        }
        else {
            const v135: string = v129.fields[0];
            v143 = method53(v1_1, v2_1, v3, v4, UH3_UH3_1((arg10$0040: [string, any, int32, int32]): US8_$union => closure30(undefined, arg10$0040), UH3_UH3_1((arg10$0040_1: [string, any, int32, int32]): US8_$union => closure31(undefined, arg10$0040_1), UH3_UH3_0())));
        }
        if (v143.tag === /* US8_0 */ 0) {
            v0_1_mut = UH2_UH2_1(v143.fields[0], v0_1);
            v1_1_mut = v143.fields[1];
            v2_1_mut = v143.fields[2];
            v3_mut = v143.fields[3];
            v4_mut = v143.fields[4];
            continue method51;
        }
        else {
            const v151: string = v143.fields[0];
            return US17_US17_0(method54(v0_1, UH2_UH2_0()), v1_1, v2_1, v3, v4);
        }
        break;
    }
}

export function method55(v0_1: UH2_$union, v1_1: FSharpList<string>): FSharpList<string> {
    if (v0_1.tag === /* UH2_0 */ 0) {
        return v1_1;
    }
    else {
        return cons(v0_1.fields[0], method55(v0_1.fields[1], v1_1));
    }
}

export function method56(v0_1_mut: UH2_$union, v1_1_mut: string, v2_1_mut: any, v3_mut: int32, v4_mut: int32): US17_$union {
    method56:
    while (true) {
        const v0_1: UH2_$union = v0_1_mut, v1_1: string = v1_1_mut, v2_1: any = v2_1_mut, v3: int32 = v3_mut, v4: int32 = v4_mut;
        let v115: US7_$union;
        if ("" === v1_1) {
            v115 = US7_US7_1(toText(interpolate("parsing.none_of / unexpected end of input / chars: %A%P() / s: %A%P()", [["\\", "`", "\""], [v2_1, v3, v4] as [any, int32, int32]])));
        }
        else {
            const v24: string = v1_1[0];
            if (method52(v24, 0n) === false) {
                const v32 = 1;
                const v46: int32 = (v1_1.length - 1) | 0;
                const v47: string = v1_1.slice(v32, v46 + 1);
                const v52: string = v24;
                const v55: int32 = v52.length | 0;
                const v56: string[] = fill(new Array(v55), 0, v55, "");
                const v57: Mut5 = new Mut5(0);
                while (method23(v55, v57)) {
                    const v59: int32 = v57.l0 | 0;
                    const v60: string = v52[v59];
                    setItem(v56, v59, v60);
                    const v61: int32 = (v59 + 1) | 0;
                    v57.l0 = (v61 | 0);
                }
                const v62: FSharpList<string> = ofArray<string>(v56);
                const patternInput: [any, int32, int32] = method25(foldBack<string, UH0_$union>(uncurry2(method24()), v62, UH0_UH0_0()), v2_1, v3, v4);
                v115 = US7_US7_0(v24, v47, patternInput[0], patternInput[1], patternInput[2]);
            }
            else {
                v115 = US7_US7_1(toText(interpolate("parsing.none_of / unexpected char: \'%P()\' / chars: %A%P() / s: %A%P()", [v24, ["\\", "`", "\""], [v2_1, v3, v4] as [any, int32, int32]])));
            }
        }
        const v129: US8_$union = (v115.tag === /* US7_0 */ 0) ? US8_US8_0(v115.fields[0], v115.fields[1], v115.fields[2], v115.fields[3], v115.fields[4]) : US8_US8_1(v115.fields[0]);
        if (v129.tag === /* US8_0 */ 0) {
            v0_1_mut = UH2_UH2_1(v129.fields[0], v0_1);
            v1_1_mut = v129.fields[1];
            v2_1_mut = v129.fields[2];
            v3_mut = v129.fields[3];
            v4_mut = v129.fields[4];
            continue method56;
        }
        else {
            const v137: string = v129.fields[0];
            return US17_US17_0(method54(v0_1, UH2_UH2_0()), v1_1, v2_1, v3, v4);
        }
        break;
    }
}

export function method48(v0_1_mut: UH2_$union, v1_1_mut: string, v2_1_mut: any, v3_mut: int32, v4_mut: int32): US17_$union {
    method48:
    while (true) {
        const v0_1: UH2_$union = v0_1_mut, v1_1: string = v1_1_mut, v2_1: any = v2_1_mut, v3: int32 = v3_mut, v4: int32 = v4_mut;
        const v5: boolean = "" === v1_1;
        let v121: US7_$union;
        if (v5) {
            v121 = US7_US7_1(toText(interpolate("parsing.none_of / unexpected end of input / chars: %A%P() / s: %A%P()", [["\\", "`", "\"", " "], [v2_1, v3, v4] as [any, int32, int32]])));
        }
        else {
            const v27: string = v1_1[0];
            if (method49(v27, 0n) === false) {
                const v35 = 1;
                const v49: int32 = (v1_1.length - 1) | 0;
                const v50: string = v1_1.slice(v35, v49 + 1);
                const v55: string = v27;
                const v58: int32 = v55.length | 0;
                const v59: string[] = fill(new Array(v58), 0, v58, "");
                const v60: Mut5 = new Mut5(0);
                while (method23(v58, v60)) {
                    const v62: int32 = v60.l0 | 0;
                    const v63: string = v55[v62];
                    setItem(v59, v62, v63);
                    const v64: int32 = (v62 + 1) | 0;
                    v60.l0 = (v64 | 0);
                }
                const v65: FSharpList<string> = ofArray<string>(v59);
                const patternInput: [any, int32, int32] = method25(foldBack<string, UH0_$union>(uncurry2(method24()), v65, UH0_UH0_0()), v2_1, v3, v4);
                v121 = US7_US7_0(v27, v50, patternInput[0], patternInput[1], patternInput[2]);
            }
            else {
                v121 = US7_US7_1(toText(interpolate("parsing.none_of / unexpected char: \'%P()\' / chars: %A%P() / s: %A%P()", [v27, ["\\", "`", "\"", " "], [v2_1, v3, v4] as [any, int32, int32]])));
            }
        }
        let v140: US8_$union;
        if (v121.tag === /* US7_0 */ 0) {
            const patternInput_1: [string, string, any, int32, int32] = method50(v121.fields[0], v121.fields[1], v121.fields[2], v121.fields[3], v121.fields[4]);
            v140 = US8_US8_0(patternInput_1[0], patternInput_1[1], patternInput_1[2], patternInput_1[3], patternInput_1[4]);
        }
        else {
            v140 = US8_US8_1(v121.fields[0]);
        }
        let v517: US8_$union;
        if (v140.tag === /* US8_0 */ 0) {
            const v145: int32 = v140.fields[4] | 0;
            const v144: int32 = v140.fields[3] | 0;
            const v143: any = v140.fields[2];
            const v142: string = v140.fields[1];
            const v141: string = v140.fields[0];
            v517 = v140;
        }
        else {
            const v146: string = v140.fields[0];
            let v270: US7_$union;
            if (v5) {
                v270 = US7_US7_1(toText(interpolate("parsing.p_char / unexpected end of input / c: \'%P()\' / s: %A%P()", ["\"", [v2_1, v3, v4] as [any, int32, int32]])));
            }
            else {
                const v151: string = v1_1[0];
                if (v151 === "\"") {
                    const v157 = 1;
                    const v171: int32 = (v1_1.length - 1) | 0;
                    const v172: string = v1_1.slice(v157, v171 + 1);
                    const v177: string = v151;
                    const v180: int32 = v177.length | 0;
                    const v181: string[] = fill(new Array(v180), 0, v180, "");
                    const v182: Mut5 = new Mut5(0);
                    while (method23(v180, v182)) {
                        const v184: int32 = v182.l0 | 0;
                        const v185: string = v177[v184];
                        setItem(v181, v184, v185);
                        const v186: int32 = (v184 + 1) | 0;
                        v182.l0 = (v186 | 0);
                    }
                    const v187: FSharpList<string> = ofArray<string>(v181);
                    const patternInput_2: [any, int32, int32] = method25(foldBack<string, UH0_$union>(uncurry2(method24()), v187, UH0_UH0_0()), v2_1, v3, v4);
                    v270 = US7_US7_0(v151, v172, patternInput_2[0], patternInput_2[1], patternInput_2[2]);
                }
                else {
                    const v222: int32 = v1_1.length | 0;
                    const v229: int32 = (v1_1.indexOf("\n") - 1) | 0;
                    const v234 = 0;
                    const v248: int32 = (((-2 === v229) ? (v222 + 1) : (v229 + 1)) - 1) | 0;
                    v270 = US7_US7_1(`${`parsing.p_char / expected: '${"\""}' / line: ${v3} / col: ${v4}
${v2_1}${v1_1.slice(v234, v248 + 1)}`}
${replicate(v4 - 1, " ") + "^"}
`);
                }
            }
            let v454: US8_$union;
            if (v270.tag === /* US7_0 */ 0) {
                const v275: int32 = v270.fields[4] | 0;
                const v274: int32 = v270.fields[3] | 0;
                const v273: any = v270.fields[2];
                const v272: string = v270.fields[1];
                const v271: string = v270.fields[0];
                const v277: US17_$union = method51(UH2_UH2_0(), v272, v273, v274, v275);
                let v302: US8_$union;
                if (v277.tag === /* US17_0 */ 0) {
                    const v282: int32 = v277.fields[4] | 0;
                    const v281: int32 = v277.fields[3] | 0;
                    const v280: any = v277.fields[2];
                    const v279: string = v277.fields[1];
                    const v284: FSharpList<string> = method55(v277.fields[0], empty<string>());
                    v302 = US8_US8_0(join("", delay<string>((): Iterable<string> => map_1<int32, string>((i: int32): string => item(i, v284), rangeDouble(0, 1, length(v284) - 1)))), v279, v280, v281, v282);
                }
                else {
                    v302 = US8_US8_1(v277.fields[0]);
                }
                if (v302.tag === /* US8_0 */ 0) {
                    const v307: int32 = v302.fields[4] | 0;
                    const v306: int32 = v302.fields[3] | 0;
                    const v305: any = v302.fields[2];
                    const v304: string = v302.fields[1];
                    const v303: string = v302.fields[0];
                    let v432: US7_$union;
                    if ("" === v304) {
                        v432 = US7_US7_1(toText(interpolate("parsing.p_char / unexpected end of input / c: \'%P()\' / s: %A%P()", ["\"", [v305, v306, v307] as [any, int32, int32]])));
                    }
                    else {
                        const v313: string = v304[0];
                        if (v313 === "\"") {
                            const v319 = 1;
                            const v333: int32 = (v304.length - 1) | 0;
                            const v334: string = v304.slice(v319, v333 + 1);
                            const v339: string = v313;
                            const v342: int32 = v339.length | 0;
                            const v343: string[] = fill(new Array(v342), 0, v342, "");
                            const v344: Mut5 = new Mut5(0);
                            while (method23(v342, v344)) {
                                const v346: int32 = v344.l0 | 0;
                                const v347: string = v339[v346];
                                setItem(v343, v346, v347);
                                const v348: int32 = (v346 + 1) | 0;
                                v344.l0 = (v348 | 0);
                            }
                            const v349: FSharpList<string> = ofArray<string>(v343);
                            const patternInput_3: [any, int32, int32] = method25(foldBack<string, UH0_$union>(uncurry2(method24()), v349, UH0_UH0_0()), v305, v306, v307);
                            v432 = US7_US7_0(v313, v334, patternInput_3[0], patternInput_3[1], patternInput_3[2]);
                        }
                        else {
                            const v384: int32 = v304.length | 0;
                            const v391: int32 = (v304.indexOf("\n") - 1) | 0;
                            const v396 = 0;
                            const v410: int32 = (((-2 === v391) ? (v384 + 1) : (v391 + 1)) - 1) | 0;
                            v432 = US7_US7_1(`${`parsing.p_char / expected: '${"\""}' / line: ${v306} / col: ${v307}
${v305}${v304.slice(v396, v410 + 1)}`}
${replicate(v307 - 1, " ") + "^"}
`);
                        }
                    }
                    if (v432.tag === /* US7_0 */ 0) {
                        const v433: string = v432.fields[0];
                        v454 = US8_US8_0(v303, v432.fields[1], v432.fields[2], v432.fields[3], v432.fields[4]);
                    }
                    else {
                        v454 = US8_US8_1(toText(interpolate("parsing.between / expected closing delimiter / e: %A%P() / input: %A%P() / rest1: %A%P() / rest2: %A%P()", [v432.fields[0], [v1_1, v2_1, v3, v4] as [string, any, int32, int32], [v272, v273, v274, v275] as [string, any, int32, int32], [v304, v305, v306, v307] as [string, any, int32, int32]])));
                    }
                }
                else {
                    const v446: string = v302.fields[0];
                    v454 = US8_US8_1("parsing.between / expected content");
                }
            }
            else {
                v454 = US8_US8_1(v270.fields[0]);
            }
            if (v454.tag === /* US8_0 */ 0) {
                const v459: int32 = v454.fields[4] | 0;
                const v458: int32 = v454.fields[3] | 0;
                const v457: any = v454.fields[2];
                const v456: string = v454.fields[1];
                const v455: string = v454.fields[0];
                v517 = v454;
            }
            else {
                const v460: string = v454.fields[0];
                const v466: US8_$union = method53(v1_1, v2_1, v3, v4, UH3_UH3_1((arg10$0040: [string, any, int32, int32]): US8_$union => closure30(undefined, arg10$0040), UH3_UH3_1((arg10$0040_1: [string, any, int32, int32]): US8_$union => closure31(undefined, arg10$0040_1), UH3_UH3_0())));
                let v477: US8_$union;
                if (v466.tag === /* US8_0 */ 0) {
                    const v467: string = v466.fields[0];
                    v477 = US8_US8_0("", v466.fields[1], v466.fields[2], v466.fields[3], v466.fields[4]);
                }
                else {
                    v477 = US8_US8_1(v466.fields[0]);
                }
                let v488: US17_$union;
                if (v477.tag === /* US8_0 */ 0) {
                    const v478: string = v477.fields[0];
                    v488 = method56(UH2_UH2_0(), v477.fields[1], v477.fields[2], v477.fields[3], v477.fields[4]);
                }
                else {
                    v488 = US17_US17_1(v477.fields[0]);
                }
                if (v488.tag === /* US17_0 */ 0) {
                    const v493: int32 = v488.fields[4] | 0;
                    const v492: int32 = v488.fields[3] | 0;
                    const v491: any = v488.fields[2];
                    const v490: string = v488.fields[1];
                    const v495: FSharpList<string> = method55(v488.fields[0], empty<string>());
                    v517 = US8_US8_0(join("", delay<string>((): Iterable<string> => map_1<int32, string>((i_1: int32): string => item(i_1, v495), rangeDouble(0, 1, length(v495) - 1)))), v490, v491, v492, v493);
                }
                else {
                    v517 = US8_US8_1(v488.fields[0]);
                }
            }
        }
        if (v517.tag === /* US8_0 */ 0) {
            const v522: int32 = v517.fields[4] | 0;
            const v521: int32 = v517.fields[3] | 0;
            const v520: any = v517.fields[2];
            const v519: string = v517.fields[1];
            const v518: string = v517.fields[0];
            const v524: int32 = method32(v519, 0) | 0;
            let v552: US10_$union;
            if (0 === v524) {
                v552 = US10_US10_1("parsing.spaces1 / expected at least one space");
            }
            else {
                const v532: int32 = v524 | 0;
                const v546: int32 = (v519.length - 1) | 0;
                v552 = US10_US10_0(v519.slice(v532, v546 + 1), v520, v521, v522);
            }
            if (v552.tag === /* US10_0 */ 0) {
                v0_1_mut = UH2_UH2_1(v518, v0_1);
                v1_1_mut = v552.fields[0];
                v2_1_mut = v552.fields[1];
                v3_mut = v552.fields[2];
                v4_mut = v552.fields[3];
                continue method48;
            }
            else {
                const v559: string = v552.fields[0];
                return US17_US17_0(method54(v0_1, UH2_UH2_1(v518, UH2_UH2_0())), v519, v520, v521, v522);
            }
        }
        else {
            const v566: string = v517.fields[0];
            return US17_US17_0(method54(v0_1, UH2_UH2_0()), v1_1, v2_1, v3, v4);
        }
        break;
    }
}

export function method47(v0_1: string): US16_$union {
    let _v0: Option<Option<string>> = undefined;
    _v0 = some(v0_1);
    const v18_1: US17_$union = method48(UH2_UH2_0(), defaultArg((_v0 == null) ? (() => {
        throw new Error("optionm\'.of_obj / _v0=None");
    })() : value_12(_v0), ""), StringBuilder_$ctor_Z721C83C5(method22()), 1, 1);
    if (v18_1.tag === /* US17_0 */ 0) {
        const v23: int32 = v18_1.fields[4] | 0;
        const v22: int32 = v18_1.fields[3] | 0;
        const v21: any = v18_1.fields[2];
        const v20_1: string = v18_1.fields[1];
        return US16_US16_0(toArray<string>(method55(v18_1.fields[0], empty<string>())));
    }
    else {
        return US16_US16_1(v18_1.fields[0]);
    }
}

export function closure29(unitVar: void, v0_1: string): FSharpResult$2_$union<string[], string> {
    const v1_1: US16_$union = method47(v0_1);
    if (v1_1.tag === /* US16_0 */ 0) {
        return FSharpResult$2_Ok<string[], string>(v1_1.fields[0]);
    }
    else {
        return FSharpResult$2_Error<string[], string>(v1_1.fields[0]);
    }
}

export const v0: any = undefined;

export const v1 = (): void => {
    closure0(undefined, undefined);
};

export const v2: any = (v1(), v0);

export const v16 = (): void => {
    closure3(undefined, undefined);
};

export function current_process_kill(): void {
    v16();
}

export const v17 = (v: string): any => closure13(undefined, v);

export function execute_async(x: string): any {
    return v17(x);
}

export const v18 = (arg10$0040: [string, Option<any>, [string, string][], Option<((arg0: [int32, string, boolean]) => any)>, Option<((arg0: any) => void)>, boolean, Option<string>]): any => closure27(undefined, arg10$0040);

export function execute_with_options_async(x: [string, Option<any>, [string, string][], Option<((arg0: [int32, string, boolean]) => any)>, Option<((arg0: any) => void)>, boolean, Option<string>]): any {
    return v18(x);
}

export const v19 = (v: ((arg0: Heap0) => Heap0)): [string, Option<any>, [string, string][], Option<((arg0: [int32, string, boolean]) => any)>, Option<((arg0: any) => void)>, boolean, Option<string>] => closure28(undefined, v);

export function execution_options(x: ((arg0: Heap0) => Heap0)): [string, Option<any>, [string, string][], Option<((arg0: [int32, string, boolean]) => any)>, Option<((arg0: any) => void)>, boolean, Option<string>] {
    return v19(x);
}

export const v20 = (v: string): FSharpResult$2_$union<string[], string> => closure29(undefined, v);

export function split_args(x: string): FSharpResult$2_$union<string[], string> {
    return v20(x);
}


