import { uncurry2, defaultOf, compare, IComparable, IEquatable, createAtom } from "../../deps/Fable/src/fable-library-ts/Util.js";
import { some, defaultArg, value as value_12, Option } from "../../deps/Fable/src/fable-library-ts/Option.js";
import { equals, compare as compare_1, op_Addition, op_Subtraction, toInt64, int64 } from "../../deps/Fable/src/fable-library-ts/BigInt.js";
import { FSharpRef, Record, Union } from "../../deps/Fable/src/fable-library-ts/Types.js";
import { array_type, option_type, tuple_type, int32_type, class_type, char_type, bool_type, lambda_type, unit_type, string_type, record_type, int64_type, union_type, TypeInfo } from "../../deps/Fable/src/fable-library-ts/Reflection.js";
import { int32 } from "../../deps/Fable/src/fable-library-ts/Int32.js";
import { create, toString, now, getTicks } from "../../deps/Fable/src/fable-library-ts/Date.js";
import { milliseconds, seconds, minutes, hours, fromTicks } from "../../deps/Fable/src/fable-library-ts/TimeSpan.js";
import { join, replicate, interpolate, toText, trimStart, trimEnd, padLeft } from "../../deps/Fable/src/fable-library-ts/String.js";
import { ofSeq, find } from "../../deps/Fable/src/fable-library-ts/Map.js";
import { StringBuilder_$ctor_Z721C83C5, StringBuilder__Append_Z721C83C5, StringBuilder__Clear } from "../../deps/Fable/src/fable-library-ts/System.Text.js";
import { setItem, fill } from "../../deps/Fable/src/fable-library-ts/Array.js";
import { toArray, length, item, empty, cons, foldBack, FSharpList, ofArray } from "../../deps/Fable/src/fable-library-ts/List.js";
import { map, delay } from "../../deps/Fable/src/fable-library-ts/Seq.js";
import { rangeDouble } from "../../deps/Fable/src/fable-library-ts/Range.js";
import { FSharpResult$2_$union, FSharpResult$2_Error, FSharpResult$2_Ok } from "../../deps/Fable/src/fable-library-ts/Result.js";

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
    l0: US0_$union;
    constructor(l0: US0_$union) {
        super();
        this.l0 = l0;
    }
}

export function Mut3_$reflection(): TypeInfo {
    return record_type("Runtime.Mut3", [], Mut3, () => [["l0", US0_$reflection()]]);
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
    return union_type("Runtime.US3", [], US3, () => [[["f0_0", string_type]], []]);
}

export class Mut4 extends Record implements IEquatable<Mut4>, IComparable<Mut4> {
    l0: string;
    constructor(l0: string) {
        super();
        this.l0 = l0;
    }
}

export function Mut4_$reflection(): TypeInfo {
    return record_type("Runtime.Mut4", [], Mut4, () => [["l0", string_type]]);
}

export type US4_$union = 
    | US4<0>
    | US4<1>

export type US4_$cases = {
    0: ["US4_0", [string, US3_$union]],
    1: ["US4_1", [string]]
}

export function US4_US4_0(f0_0: string, f0_1: US3_$union) {
    return new US4<0>(0, [f0_0, f0_1]);
}

export function US4_US4_1(f1_0: string) {
    return new US4<1>(1, [f1_0]);
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
    return union_type("Runtime.US4", [], US4, () => [[["f0_0", string_type], ["f0_1", US3_$reflection()]], [["f1_0", string_type]]]);
}

export type US5_$union = 
    | US5<0>
    | US5<1>

export type US5_$cases = {
    0: ["US5_0", [string, string, any, int32, int32]],
    1: ["US5_1", [string]]
}

export function US5_US5_0(f0_0: string, f0_1: string, f0_2: any, f0_3: int32, f0_4: int32) {
    return new US5<0>(0, [f0_0, f0_1, f0_2, f0_3, f0_4]);
}

export function US5_US5_1(f1_0: string) {
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
    return union_type("Runtime.US5", [], US5, () => [[["f0_0", char_type], ["f0_1", string_type], ["f0_2", class_type("System.Text.StringBuilder")], ["f0_3", int32_type], ["f0_4", int32_type]], [["f1_0", string_type]]]);
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
    1: ["UH1_1", [((arg0: [string, any, int32, int32]) => US5_$union), UH1_$union]]
}

export function UH1_UH1_0() {
    return new UH1<0>(0, []);
}

export function UH1_UH1_1(Item1: ((arg0: [string, any, int32, int32]) => US5_$union), Item2: UH1_$union) {
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
    return union_type("Runtime.UH1", [], UH1, () => [[], [["Item1", lambda_type(tuple_type(string_type, class_type("System.Text.StringBuilder"), int32_type, int32_type), US5_$reflection())], ["Item2", UH1_$reflection()]]]);
}

export type US6_$union = 
    | US6<0>
    | US6<1>

export type US6_$cases = {
    0: ["US6_0", [string, string, any, int32, int32]],
    1: ["US6_1", [string]]
}

export function US6_US6_0(f0_0: string, f0_1: string, f0_2: any, f0_3: int32, f0_4: int32) {
    return new US6<0>(0, [f0_0, f0_1, f0_2, f0_3, f0_4]);
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
    return union_type("Runtime.US6", [], US6, () => [[["f0_0", string_type], ["f0_1", string_type], ["f0_2", class_type("System.Text.StringBuilder")], ["f0_3", int32_type], ["f0_4", int32_type]], [["f1_0", string_type]]]);
}

export type US7_$union = 
    | US7<0>
    | US7<1>

export type US7_$cases = {
    0: ["US7_0", [string]],
    1: ["US7_1", []]
}

export function US7_US7_0(f0_0: string) {
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
    return union_type("Runtime.US7", [], US7, () => [[["f0_0", char_type]], []]);
}

export type US8_$union = 
    | US8<0>
    | US8<1>

export type US8_$cases = {
    0: ["US8_0", [string, any, int32, int32]],
    1: ["US8_1", [string]]
}

export function US8_US8_0(f0_0: string, f0_1: any, f0_2: int32, f0_3: int32) {
    return new US8<0>(0, [f0_0, f0_1, f0_2, f0_3]);
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
    return union_type("Runtime.US8", [], US8, () => [[["f0_0", string_type], ["f0_1", class_type("System.Text.StringBuilder")], ["f0_2", int32_type], ["f0_3", int32_type]], [["f1_0", string_type]]]);
}

export type US9_$union = 
    | US9<0>
    | US9<1>

export type US9_$cases = {
    0: ["US9_0", [string, US3_$union, string, any, int32, int32]],
    1: ["US9_1", [string]]
}

export function US9_US9_0(f0_0: string, f0_1: US3_$union, f0_2: string, f0_3: any, f0_4: int32, f0_5: int32) {
    return new US9<0>(0, [f0_0, f0_1, f0_2, f0_3, f0_4, f0_5]);
}

export function US9_US9_1(f1_0: string) {
    return new US9<1>(1, [f1_0]);
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
    return union_type("Runtime.US9", [], US9, () => [[["f0_0", string_type], ["f0_1", US3_$reflection()], ["f0_2", string_type], ["f0_3", class_type("System.Text.StringBuilder")], ["f0_4", int32_type], ["f0_5", int32_type]], [["f1_0", string_type]]]);
}

export type US10_$union = 
    | US10<0>
    | US10<1>

export type US10_$cases = {
    0: ["US10_0", [US7_$union, string, any, int32, int32]],
    1: ["US10_1", [string]]
}

export function US10_US10_0(f0_0: US7_$union, f0_1: string, f0_2: any, f0_3: int32, f0_4: int32) {
    return new US10<0>(0, [f0_0, f0_1, f0_2, f0_3, f0_4]);
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
    return union_type("Runtime.US10", [], US10, () => [[["f0_0", US7_$reflection()], ["f0_1", string_type], ["f0_2", class_type("System.Text.StringBuilder")], ["f0_3", int32_type], ["f0_4", int32_type]], [["f1_0", string_type]]]);
}

export type US11_$union = 
    | US11<0>
    | US11<1>

export type US11_$cases = {
    0: ["US11_0", [US3_$union, string, any, int32, int32]],
    1: ["US11_1", [string]]
}

export function US11_US11_0(f0_0: US3_$union, f0_1: string, f0_2: any, f0_3: int32, f0_4: int32) {
    return new US11<0>(0, [f0_0, f0_1, f0_2, f0_3, f0_4]);
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
    return union_type("Runtime.US11", [], US11, () => [[["f0_0", US3_$reflection()], ["f0_1", string_type], ["f0_2", class_type("System.Text.StringBuilder")], ["f0_3", int32_type], ["f0_4", int32_type]], [["f1_0", string_type]]]);
}

export type US12_$union = 
    | US12<0>
    | US12<1>

export type US12_$cases = {
    0: ["US12_0", [((arg0: [int32, string, boolean]) => any)]],
    1: ["US12_1", []]
}

export function US12_US12_0(f0_0: ((arg0: [int32, string, boolean]) => any)) {
    return new US12<0>(0, [f0_0]);
}

export function US12_US12_1() {
    return new US12<1>(1, []);
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
    return union_type("Runtime.US12", [], US12, () => [[["f0_0", lambda_type(tuple_type(int32_type, string_type, bool_type), class_type("Microsoft.FSharp.Control.FSharpAsync`1", [unit_type]))]], []]);
}

export type US13_$union = 
    | US13<0>
    | US13<1>

export type US13_$cases = {
    0: ["US13_0", [any]],
    1: ["US13_1", []]
}

export function US13_US13_0(f0_0: any) {
    return new US13<0>(0, [f0_0]);
}

export function US13_US13_1() {
    return new US13<1>(1, []);
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
    return union_type("Runtime.US13", [], US13, () => [[["f0_0", class_type("System.Threading.CancellationToken")]], []]);
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

export type US14_$union = 
    | US14<0>
    | US14<1>

export type US14_$cases = {
    0: ["US14_0", [string[]]],
    1: ["US14_1", [string]]
}

export function US14_US14_0(f0_0: string[]) {
    return new US14<0>(0, [f0_0]);
}

export function US14_US14_1(f1_0: string) {
    return new US14<1>(1, [f1_0]);
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
    return union_type("Runtime.US14", [], US14, () => [[["f0_0", array_type(string_type)]], [["f1_0", string_type]]]);
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

export type US15_$union = 
    | US15<0>
    | US15<1>

export type US15_$cases = {
    0: ["US15_0", [UH2_$union, string, any, int32, int32]],
    1: ["US15_1", [string]]
}

export function US15_US15_0(f0_0: UH2_$union, f0_1: string, f0_2: any, f0_3: int32, f0_4: int32) {
    return new US15<0>(0, [f0_0, f0_1, f0_2, f0_3, f0_4]);
}

export function US15_US15_1(f1_0: string) {
    return new US15<1>(1, [f1_0]);
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
    return union_type("Runtime.US15", [], US15, () => [[["f0_0", UH2_$reflection()], ["f0_1", string_type], ["f0_2", class_type("System.Text.StringBuilder")], ["f0_3", int32_type], ["f0_4", int32_type]], [["f1_0", string_type]]]);
}

export type UH3_$union = 
    | UH3<0>
    | UH3<1>

export type UH3_$cases = {
    0: ["UH3_0", []],
    1: ["UH3_1", [((arg0: [string, any, int32, int32]) => US6_$union), UH3_$union]]
}

export function UH3_UH3_0() {
    return new UH3<0>(0, []);
}

export function UH3_UH3_1(Item1: ((arg0: [string, any, int32, int32]) => US6_$union), Item2: UH3_$union) {
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
    return union_type("Runtime.UH3", [], UH3, () => [[], [["Item1", lambda_type(tuple_type(string_type, class_type("System.Text.StringBuilder"), int32_type, int32_type), US6_$reflection())], ["Item2", UH3_$reflection()]]]);
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
        return value_12(_v3);
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
        patternInput = value_12(_v3);
    }
    const v325: US2_$union = patternInput[1];
    const v324: US1_$union = patternInput[0];
    return [new Mut0(0n), new Mut1((v: string): void => {
        closure1(undefined, v);
    }), new Mut2(true), new Mut3((v324.tag === /* US1_0 */ 0) ? v324.fields[0] : v0), (v325.tag === /* US2_0 */ 0) ? v325.fields[0] : undefined] as [Mut0, Mut1, Mut2, Mut3, Option<int64>];
}

export function closure4(unitVar: void, unitVar_1: void): string {
    return "runtime.current_process_kill / exiting... 3";
}

export function closure5(unitVar: void, unitVar_1: void): void {
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

export function method9(v0: Mut4): void {
}

export function closure6(v0: US0_$union, v1: (() => string), v2_1: (() => void), unitVar: void): string {
    let v368: int64, v392: number;
    if (State_trace_state() == null) {
        State_trace_state(closure0(undefined, US0_US0_0()));
    }
    const patternInput: [Mut0, Mut1, Mut2, Mut3, Option<int64>] = value_12(State_trace_state());
    const v18: Option<int64> = patternInput[4];
    let _v35: Option<string> = undefined;
    const _v333: FSharpRef<Option<US2_$union>> = new FSharpRef<Option<US2_$union>>(undefined);
    let x_2: Option<US2_$union>;
    if (v18 == null) {
        x_2 = undefined;
    }
    else {
        const x: int64 = value_12(v18);
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
        v772 = value_12(_v35);
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
        v1141 = value_12(_v1029);
    }
    const v1160: int64 = patternInput[0].l0;
    v2_1();
    const v1162: Mut4 = new Mut4("");
    method9(v1162);
    const v1163: string = v1162.l0;
    return trimEnd(trimStart(`${v772} ${v1141} #${v1160} ${v1()} / ${v1163}`, ...[]), ...[" ", "/"]);
}

export function method10(v0: US0_$union, v1: (() => string)): void {
    const v4 = (v: US0_$union): [Mut0, Mut1, Mut2, Mut3, Option<int64>] => closure0(undefined, v);
    if (State_trace_state() == null) {
        State_trace_state(v4(US0_US0_0()));
    }
    const patternInput: [Mut0, Mut1, Mut2, Mut3, Option<int64>] = value_12(State_trace_state());
    const v13_1: Mut0 = patternInput[0];
    if (State_trace_state() == null) {
        State_trace_state(v4(US0_US0_0()));
    }
    const patternInput_1: [Mut0, Mut1, Mut2, Mut3, Option<int64>] = value_12(State_trace_state());
    const v61: US0_$union = patternInput_1[3].l0;
    if ((patternInput_1[2].l0 === false) ? false : (find<US0_$union, int32>(v0, ofSeq([[US0_US0_0(), 0] as [US0_$union, int32], [US0_US0_1(), 1] as [US0_$union, int32], [US0_US0_2(), 2] as [US0_$union, int32], [US0_US0_3(), 3] as [US0_$union, int32], [US0_US0_4(), 4] as [US0_$union, int32]], {
        Compare: compare,
    })) >= find<US0_$union, int32>(v61, ofSeq([[US0_US0_0(), 0] as [US0_$union, int32], [US0_US0_1(), 1] as [US0_$union, int32], [US0_US0_2(), 2] as [US0_$union, int32], [US0_US0_3(), 3] as [US0_$union, int32], [US0_US0_4(), 4] as [US0_$union, int32]], {
        Compare: compare,
    })))) {
        const v69: int64 = toInt64(op_Addition(v13_1.l0, 1n));
        v13_1.l0 = v69;
        const v72 = `${v1()}`;
        let _v81: Option<void> = undefined;
        console.log(v72);
        _v81 = some(undefined);
        if (_v81 == null) {
            throw new Error("base.run_target / _v81=None");
        }
        else {
            value_12(_v81);
        }
        patternInput[1].l0(v72);
    }
}

export function method4(v0: US0_$union, v1: (() => string), v2_1: (() => void)): void {
    method10(v0, (): string => closure6(v0, v1, v2_1, undefined));
}

export function closure7(unitVar: void, unitVar_1: void): string {
    return "runtime.current_process_kill / exiting... 2";
}

export function closure8(unitVar: void, unitVar_1: void): string {
    return "runtime.current_process_kill / exiting... 1";
}

export function closure3(unitVar: void, unitVar_1: void): void {
    let _v2: Option<void> = undefined;
    defaultOf();
    _v2 = some(undefined);
    if (_v2 == null) {
        throw new Error("base.run_target / _v2=None");
    }
    else {
        value_12(_v2);
    }
}

export function closure2(unitVar: void, unitVar_1: void): void {
    let _v2: Option<void> = undefined;
    defaultOf();
    _v2 = some(undefined);
    if (_v2 == null) {
        throw new Error("base.run_target / _v2=None");
    }
    else {
        value_12(_v2);
    }
}

export function method13(v0: int32, v1: Mut5): boolean {
    return v1.l0 < v0;
}

export function closure12(v0: string, v1: UH0_$union): UH0_$union {
    return UH0_UH0_1(v0, v1);
}

export function closure11(unitVar: void, v0: string): ((arg0: UH0_$union) => UH0_$union) {
    return (v: UH0_$union): UH0_$union => closure12(v0, v);
}

export function method14(): ((arg0: string) => ((arg0: UH0_$union) => UH0_$union)) {
    return (v: string): ((arg0: UH0_$union) => UH0_$union) => closure11(undefined, v);
}

export function method15(v0_mut: UH0_$union, v1_mut: any, v2_1_mut: int32, v3_1_mut: int32): [any, int32, int32] {
    let v12_1: any, v24: any;
    method15:
    while (true) {
        const v0: UH0_$union = v0_mut, v1: any = v1_mut, v2_1: int32 = v2_1_mut, v3_1: int32 = v3_1_mut;
        if (v0.tag === /* UH0_0 */ 0) {
            return [v1, v2_1, v3_1] as [any, int32, int32];
        }
        else {
            const v4: string = v0.fields[0];
            const v6: boolean = "\n" === v4;
            const patternInput: [int32, int32] = v6 ? ([v2_1 + 1, 1] as [int32, int32]) : ([v2_1, v3_1 + 1] as [int32, int32]);
            v0_mut = v0.fields[1];
            v1_mut = (v6 ? ((v12_1 = StringBuilder__Clear(v1), v1)) : ((v24 = StringBuilder__Append_Z721C83C5(v1, v4), v1)));
            v2_1_mut = patternInput[0];
            v3_1_mut = patternInput[1];
            continue method15;
        }
        break;
    }
}

export function closure10(unitVar: void, _arg: [string, any, int32, int32]): US5_$union {
    const v3_1: int32 = _arg[3] | 0;
    const v2_1: int32 = _arg[2] | 0;
    const v1: any = _arg[1];
    const v0: string = _arg[0];
    if ("" === v0) {
        return US5_US5_1(toText(interpolate("parsing.p_char / unexpected end of input / s: %A%P()", [[v1, v2_1, v3_1] as [any, int32, int32]])));
    }
    else {
        const v7: string = v0[0];
        if (v7 === "\"") {
            const v12_1 = 1;
            const v14: int32 = v0.length | 0;
            const v15: string = v0.slice(v12_1, v14 + 1);
            const v19: string = v7;
            const v26: int32 = v19.length | 0;
            const v27: string[] = fill(new Array(v26), 0, v26, "");
            const v28: Mut5 = new Mut5(0);
            while (method13(v26, v28)) {
                const v30: int32 = v28.l0 | 0;
                const v31: string = v19[v30];
                setItem(v27, v30, v31);
                const v32: int32 = (v30 + 1) | 0;
                v28.l0 = (v32 | 0);
            }
            const v33: FSharpList<string> = ofArray<string>(v27);
            const patternInput: [any, int32, int32] = method15(foldBack<string, UH0_$union>(uncurry2(method14()), v33, UH0_UH0_0()), v1, v2_1, v3_1);
            return US5_US5_0(v7, v15, patternInput[0], patternInput[1], patternInput[2]);
        }
        else {
            const v55: int32 = v0.length | 0;
            const v58: int32 = (v0.indexOf("\n") - 1) | 0;
            const v62 = 0;
            const v64: int32 = ((-2 === v58) ? v55 : v58) | 0;
            return US5_US5_1(`${`parsing.p_char / expected: '${"\""}' / line: ${v2_1} / col: ${v3_1}
${v1}${v0.slice(v62, v64 + 1)}`}
${replicate(v3_1 - 1, " ") + "^"}
`);
        }
    }
}

export function closure13(unitVar: void, _arg: [string, any, int32, int32]): US5_$union {
    const v3_1: int32 = _arg[3] | 0;
    const v2_1: int32 = _arg[2] | 0;
    const v1: any = _arg[1];
    const v0: string = _arg[0];
    if ("" === v0) {
        return US5_US5_1(toText(interpolate("parsing.p_char / unexpected end of input / s: %A%P()", [[v1, v2_1, v3_1] as [any, int32, int32]])));
    }
    else {
        const v7: string = v0[0];
        if (v7 === "\'") {
            const v12_1 = 1;
            const v14: int32 = v0.length | 0;
            const v15: string = v0.slice(v12_1, v14 + 1);
            const v19: string = v7;
            const v26: int32 = v19.length | 0;
            const v27: string[] = fill(new Array(v26), 0, v26, "");
            const v28: Mut5 = new Mut5(0);
            while (method13(v26, v28)) {
                const v30: int32 = v28.l0 | 0;
                const v31: string = v19[v30];
                setItem(v27, v30, v31);
                const v32: int32 = (v30 + 1) | 0;
                v28.l0 = (v32 | 0);
            }
            const v33: FSharpList<string> = ofArray<string>(v27);
            const patternInput: [any, int32, int32] = method15(foldBack<string, UH0_$union>(uncurry2(method14()), v33, UH0_UH0_0()), v1, v2_1, v3_1);
            return US5_US5_0(v7, v15, patternInput[0], patternInput[1], patternInput[2]);
        }
        else {
            const v55: int32 = v0.length | 0;
            const v58: int32 = (v0.indexOf("\n") - 1) | 0;
            const v62 = 0;
            const v64: int32 = ((-2 === v58) ? v55 : v58) | 0;
            return US5_US5_1(`${`parsing.p_char / expected: '${"\'"}' / line: ${v2_1} / col: ${v3_1}
${v1}${v0.slice(v62, v64 + 1)}`}
${replicate(v3_1 - 1, " ") + "^"}
`);
        }
    }
}

export function method16(v0_mut: string, v1_mut: any, v2_1_mut: UH1_$union): US5_$union {
    method16:
    while (true) {
        const v0: string = v0_mut, v1: any = v1_mut, v2_1: UH1_$union = v2_1_mut;
        if (v2_1.tag === /* UH1_0 */ 0) {
            return US5_US5_1("choice / no parsers succeeded");
        }
        else {
            const v6: UH1_$union = v2_1.fields[1];
            const v7: US5_$union = v2_1.fields[0]([v0, v1, 1, 1] as [string, any, int32, int32]);
            if (v7.tag === /* US5_0 */ 0) {
                const v9_1: string = v7.fields[1];
                const v8: string = v7.fields[0];
                const v12_1: int32 = v7.fields[4] | 0;
                const v11_1: int32 = v7.fields[3] | 0;
                const v10_1: any = v7.fields[2];
                return v7;
            }
            else {
                const v13_1: string = v7.fields[0];
                v0_mut = v0;
                v1_mut = v1;
                v2_1_mut = v6;
                continue method16;
            }
        }
        break;
    }
}

export function method17(v0_mut: string, v1_mut: int64): boolean {
    method17:
    while (true) {
        const v0: string = v0_mut, v1: int64 = v1_mut;
        if (compare_1(v1, 2n) >= 0) {
            return false;
        }
        else {
            let v11_1: US7_$union;
            if (equals(v1, 0n)) {
                v11_1 = US7_US7_0("\"");
            }
            else {
                const v5: int64 = toInt64(op_Subtraction(v1, 1n));
                if (equals(v5, 0n)) {
                    v11_1 = US7_US7_0("\'");
                }
                else {
                    const v8: int64 = toInt64(op_Subtraction(v5, 1n));
                    v11_1 = US7_US7_1();
                }
            }
            if (v0 === ((v11_1.tag === /* US7_0 */ 0) ? v11_1.fields[0] : (() => {
                throw new Error("Option does not have a value.");
            })())) {
                return true;
            }
            else {
                v0_mut = v0;
                v1_mut = toInt64(op_Addition(v1, 1n));
                continue method17;
            }
        }
        break;
    }
}

export function method18(v0_mut: string, v1_mut: string, v2_1_mut: any, v3_1_mut: int32, v4_mut: int32): US6_$union {
    method18:
    while (true) {
        const v0: string = v0_mut, v1: string = v1_mut, v2_1: any = v2_1_mut, v3_1: int32 = v3_1_mut, v4: int32 = v4_mut;
        let v118: US5_$union;
        if ("" === v1) {
            v118 = US5_US5_1(toText(interpolate("parsing.none_of / unexpected end of input / chars: %A%P() / s: %A%P()", [["\"", "\'"], [v2_1, v3_1, v4] as [any, int32, int32]])));
        }
        else {
            const v37: string = v1[0];
            const v41 = 1;
            const v43: int32 = v1.length | 0;
            const v44: string = v1.slice(v41, v43 + 1);
            if (method17(v37, 0n) === false) {
                const v51: string = v37;
                const v58: int32 = v51.length | 0;
                const v59: string[] = fill(new Array(v58), 0, v58, "");
                const v60: Mut5 = new Mut5(0);
                while (method13(v58, v60)) {
                    const v62: int32 = v60.l0 | 0;
                    const v63: string = v51[v62];
                    setItem(v59, v62, v63);
                    const v64: int32 = (v62 + 1) | 0;
                    v60.l0 = (v64 | 0);
                }
                const v65: FSharpList<string> = ofArray<string>(v59);
                const patternInput: [any, int32, int32] = method15(foldBack<string, UH0_$union>(uncurry2(method14()), v65, UH0_UH0_0()), v2_1, v3_1, v4);
                v118 = US5_US5_0(v37, v44, patternInput[0], patternInput[1], patternInput[2]);
            }
            else {
                v118 = US5_US5_1(toText(interpolate("parsing.none_of / unexpected char: \'%P()\' / chars: %A%P() / s: %A%P()", [v37, ["\"", "\'"], [v2_1, v3_1, v4] as [any, int32, int32]])));
            }
        }
        let v130: US5_$union;
        if (v118.tag === /* US5_0 */ 0) {
            const v119: string = v118.fields[0];
            v130 = US5_US5_0(("\\" === v119) ? "/" : v119, v118.fields[1], v118.fields[2], v118.fields[3], v118.fields[4]);
        }
        else {
            v130 = US5_US5_1(v118.fields[0]);
        }
        if (v130.tag === /* US5_0 */ 0) {
            v0_mut = (v0 + v130.fields[0]);
            v1_mut = v130.fields[1];
            v2_1_mut = v130.fields[2];
            v3_1_mut = v130.fields[3];
            v4_mut = v130.fields[4];
            continue method18;
        }
        else {
            const v148: string = v130.fields[0];
            return US6_US6_0(v0, v1, v2_1, v3_1, v4);
        }
        break;
    }
}

export function method19(v0_mut: string, v1_mut: any, v2_1_mut: int32, v3_1_mut: int32, v4_mut: UH1_$union): US5_$union {
    method19:
    while (true) {
        const v0: string = v0_mut, v1: any = v1_mut, v2_1: int32 = v2_1_mut, v3_1: int32 = v3_1_mut, v4: UH1_$union = v4_mut;
        if (v4.tag === /* UH1_0 */ 0) {
            return US5_US5_1("choice / no parsers succeeded");
        }
        else {
            const v8: UH1_$union = v4.fields[1];
            const v9_1: US5_$union = v4.fields[0]([v0, v1, v2_1, v3_1] as [string, any, int32, int32]);
            if (v9_1.tag === /* US5_0 */ 0) {
                const v14: int32 = v9_1.fields[4] | 0;
                const v13_1: int32 = v9_1.fields[3] | 0;
                const v12_1: any = v9_1.fields[2];
                const v11_1: string = v9_1.fields[1];
                const v10_1: string = v9_1.fields[0];
                return v9_1;
            }
            else {
                const v15: string = v9_1.fields[0];
                v0_mut = v0;
                v1_mut = v1;
                v2_1_mut = v2_1;
                v3_1_mut = v3_1;
                v4_mut = v8;
                continue method19;
            }
        }
        break;
    }
}

export function method20(v0_mut: string, v1_mut: int64): boolean {
    method20:
    while (true) {
        const v0: string = v0_mut, v1: int64 = v1_mut;
        if (compare_1(v1, 3n) >= 0) {
            return false;
        }
        else {
            let v15: US7_$union;
            if (equals(v1, 0n)) {
                v15 = US7_US7_0("\"");
            }
            else {
                const v5: int64 = toInt64(op_Subtraction(v1, 1n));
                if (equals(v5, 0n)) {
                    v15 = US7_US7_0("\'");
                }
                else {
                    const v8: int64 = toInt64(op_Subtraction(v5, 1n));
                    if (equals(v8, 0n)) {
                        v15 = US7_US7_0(" ");
                    }
                    else {
                        const v11_1: int64 = toInt64(op_Subtraction(v8, 1n));
                        v15 = US7_US7_1();
                    }
                }
            }
            if (v0 === ((v15.tag === /* US7_0 */ 0) ? v15.fields[0] : (() => {
                throw new Error("Option does not have a value.");
            })())) {
                return true;
            }
            else {
                v0_mut = v0;
                v1_mut = toInt64(op_Addition(v1, 1n));
                continue method20;
            }
        }
        break;
    }
}

export function method21(v0_mut: string, v1_mut: string, v2_1_mut: any, v3_1_mut: int32, v4_mut: int32): US6_$union {
    method21:
    while (true) {
        const v0: string = v0_mut, v1: string = v1_mut, v2_1: any = v2_1_mut, v3_1: int32 = v3_1_mut, v4: int32 = v4_mut;
        let v136: US5_$union;
        if ("" === v1) {
            v136 = US5_US5_1(toText(interpolate("parsing.none_of / unexpected end of input / chars: %A%P() / s: %A%P()", [["\"", "\'", " "], [v2_1, v3_1, v4] as [any, int32, int32]])));
        }
        else {
            const v46: string = v1[0];
            const v50 = 1;
            const v52: int32 = v1.length | 0;
            const v53: string = v1.slice(v50, v52 + 1);
            if (method20(v46, 0n) === false) {
                const v60: string = v46;
                const v67: int32 = v60.length | 0;
                const v68: string[] = fill(new Array(v67), 0, v67, "");
                const v69: Mut5 = new Mut5(0);
                while (method13(v67, v69)) {
                    const v71: int32 = v69.l0 | 0;
                    const v72: string = v60[v71];
                    setItem(v68, v71, v72);
                    const v73: int32 = (v71 + 1) | 0;
                    v69.l0 = (v73 | 0);
                }
                const v74: FSharpList<string> = ofArray<string>(v68);
                const patternInput: [any, int32, int32] = method15(foldBack<string, UH0_$union>(uncurry2(method14()), v74, UH0_UH0_0()), v2_1, v3_1, v4);
                v136 = US5_US5_0(v46, v53, patternInput[0], patternInput[1], patternInput[2]);
            }
            else {
                v136 = US5_US5_1(toText(interpolate("parsing.none_of / unexpected char: \'%P()\' / chars: %A%P() / s: %A%P()", [v46, ["\"", "\'", " "], [v2_1, v3_1, v4] as [any, int32, int32]])));
            }
        }
        let v148: US5_$union;
        if (v136.tag === /* US5_0 */ 0) {
            const v137: string = v136.fields[0];
            v148 = US5_US5_0(("\\" === v137) ? "/" : v137, v136.fields[1], v136.fields[2], v136.fields[3], v136.fields[4]);
        }
        else {
            v148 = US5_US5_1(v136.fields[0]);
        }
        if (v148.tag === /* US5_0 */ 0) {
            v0_mut = (v0 + v148.fields[0]);
            v1_mut = v148.fields[1];
            v2_1_mut = v148.fields[2];
            v3_1_mut = v148.fields[3];
            v4_mut = v148.fields[4];
            continue method21;
        }
        else {
            const v166: string = v148.fields[0];
            return US6_US6_0(v0, v1, v2_1, v3_1, v4);
        }
        break;
    }
}

export function method22(v0_mut: string, v1_mut: int32): int32 {
    method22:
    while (true) {
        const v0: string = v0_mut, v1: int32 = v1_mut;
        if (v1 >= v0.length) {
            return v1 | 0;
        }
        else if (v0[v1] === " ") {
            v0_mut = v0;
            v1_mut = (v1 + 1);
            continue method22;
        }
        else {
            return v1 | 0;
        }
        break;
    }
}

export function method23(v0_mut: string, v1_mut: string, v2_1_mut: any, v3_1_mut: int32, v4_mut: int32): US6_$union {
    method23:
    while (true) {
        const v0: string = v0_mut, v1: string = v1_mut, v2_1: any = v2_1_mut, v3_1: int32 = v3_1_mut, v4: int32 = v4_mut;
        let v54: US5_$union;
        if ("" === v1) {
            v54 = US5_US5_1(toText(interpolate("parsing.any_char / unexpected end of input / s: %A%P()", [[v2_1, v3_1, v4] as [any, int32, int32]])));
        }
        else {
            const v8: string = v1[0];
            const v12_1 = 1;
            const v14: int32 = v1.length | 0;
            const v15: string = v1.slice(v12_1, v14 + 1);
            const v19: string = v8;
            const v26: int32 = v19.length | 0;
            const v27: string[] = fill(new Array(v26), 0, v26, "");
            const v28: Mut5 = new Mut5(0);
            while (method13(v26, v28)) {
                const v30: int32 = v28.l0 | 0;
                const v31: string = v19[v30];
                setItem(v27, v30, v31);
                const v32: int32 = (v30 + 1) | 0;
                v28.l0 = (v32 | 0);
            }
            const v33: FSharpList<string> = ofArray<string>(v27);
            const patternInput: [any, int32, int32] = method15(foldBack<string, UH0_$union>(uncurry2(method14()), v33, UH0_UH0_0()), v2_1, v3_1, v4);
            v54 = US5_US5_0(v8, v15, patternInput[0], patternInput[1], patternInput[2]);
        }
        if (v54.tag === /* US5_0 */ 0) {
            v0_mut = (v0 + v54.fields[0]);
            v1_mut = v54.fields[1];
            v2_1_mut = v54.fields[2];
            v3_1_mut = v54.fields[3];
            v4_mut = v54.fields[4];
            continue method23;
        }
        else {
            const v72: string = v54.fields[0];
            return US6_US6_0(v0, v1, v2_1, v3_1, v4);
        }
        break;
    }
}

export function method12(v0: string): US4_$union {
    let _v0: Option<Option<string>> = undefined;
    _v0 = some(v0);
    const v15: string = defaultArg((_v0 == null) ? (() => {
        throw new Error("optionm\'.of_obj / _v0=None");
    })() : value_12(_v0), "");
    const v23: any = StringBuilder_$ctor_Z721C83C5("");
    const v24 = (arg10$0040: [string, any, int32, int32]): US5_$union => closure10(undefined, arg10$0040);
    const v25 = (arg10$0040_1: [string, any, int32, int32]): US5_$union => closure13(undefined, arg10$0040_1);
    const v29: US5_$union = method16(v15, v23, UH1_UH1_1(v24, UH1_UH1_1(v25, UH1_UH1_0())));
    let v219: US6_$union;
    if (v29.tag === /* US5_0 */ 0) {
        const v34: int32 = v29.fields[4] | 0;
        const v33: int32 = v29.fields[3] | 0;
        const v32: any = v29.fields[2];
        const v31: string = v29.fields[1];
        const v30: string = v29.fields[0];
        let v148: US5_$union;
        if ("" === v31) {
            v148 = US5_US5_1(toText(interpolate("parsing.none_of / unexpected end of input / chars: %A%P() / s: %A%P()", [["\"", "\'"], [v32, v33, v34] as [any, int32, int32]])));
        }
        else {
            const v67: string = v31[0];
            const v71 = 1;
            const v73: int32 = v31.length | 0;
            const v74: string = v31.slice(v71, v73 + 1);
            if (method17(v67, 0n) === false) {
                const v81: string = v67;
                const v88: int32 = v81.length | 0;
                const v89: string[] = fill(new Array(v88), 0, v88, "");
                const v90: Mut5 = new Mut5(0);
                while (method13(v88, v90)) {
                    const v92: int32 = v90.l0 | 0;
                    const v93: string = v81[v92];
                    setItem(v89, v92, v93);
                    const v94: int32 = (v92 + 1) | 0;
                    v90.l0 = (v94 | 0);
                }
                const v95: FSharpList<string> = ofArray<string>(v89);
                const patternInput: [any, int32, int32] = method15(foldBack<string, UH0_$union>(uncurry2(method14()), v95, UH0_UH0_0()), v32, v33, v34);
                v148 = US5_US5_0(v67, v74, patternInput[0], patternInput[1], patternInput[2]);
            }
            else {
                v148 = US5_US5_1(toText(interpolate("parsing.none_of / unexpected char: \'%P()\' / chars: %A%P() / s: %A%P()", [v67, ["\"", "\'"], [v32, v33, v34] as [any, int32, int32]])));
            }
        }
        let v160: US5_$union;
        if (v148.tag === /* US5_0 */ 0) {
            const v149: string = v148.fields[0];
            v160 = US5_US5_0(("\\" === v149) ? "/" : v149, v148.fields[1], v148.fields[2], v148.fields[3], v148.fields[4]);
        }
        else {
            v160 = US5_US5_1(v148.fields[0]);
        }
        const v180: US6_$union = (v160.tag === /* US5_0 */ 0) ? method18(v160.fields[0], v160.fields[1], v160.fields[2], v160.fields[3], v160.fields[4]) : US6_US6_1(v160.fields[0]);
        let v190: US6_$union;
        if (v180.tag === /* US6_0 */ 0) {
            v190 = US6_US6_0(v180.fields[0], v180.fields[1], v180.fields[2], v180.fields[3], v180.fields[4]);
        }
        else {
            const v187: string = v180.fields[0];
            v190 = US6_US6_0("", v31, v32, v33, v34);
        }
        if (v190.tag === /* US6_0 */ 0) {
            const v195: int32 = v190.fields[4] | 0;
            const v194: int32 = v190.fields[3] | 0;
            const v193: any = v190.fields[2];
            const v192: string = v190.fields[1];
            const v191: string = v190.fields[0];
            const v199: US5_$union = method19(v192, v193, v194, v195, UH1_UH1_1(v24, UH1_UH1_1(v25, UH1_UH1_0())));
            if (v199.tag === /* US5_0 */ 0) {
                const v200: string = v199.fields[0];
                v219 = US6_US6_0(v191, v199.fields[1], v199.fields[2], v199.fields[3], v199.fields[4]);
            }
            else {
                v219 = US6_US6_1(toText(interpolate("between / expected closing delimiter / e: %A%P() / input: %A%P() / rest1: %A%P() / rest2: %A%P()", [v199.fields[0], [v15, v23, 1, 1] as [string, any, int32, int32], [v31, v32, v33, v34] as [string, any, int32, int32], [v192, v193, v194, v195] as [string, any, int32, int32]])));
            }
        }
        else {
            const v211: string = v190.fields[0];
            v219 = US6_US6_1("between / expected content");
        }
    }
    else {
        v219 = US6_US6_1(v29.fields[0]);
    }
    let v435: US6_$union;
    if (v219.tag === /* US6_0 */ 0) {
        const v224: int32 = v219.fields[4] | 0;
        const v223: int32 = v219.fields[3] | 0;
        const v222: any = v219.fields[2];
        const v221: string = v219.fields[1];
        const v220: string = v219.fields[0];
        v435 = v219;
    }
    else {
        const v225: string = v219.fields[0];
        let v359: US5_$union;
        if ("" === v15) {
            v359 = US5_US5_1(toText(interpolate("parsing.none_of / unexpected end of input / chars: %A%P() / s: %A%P()", [["\"", "\'", " "], [v23, 1, 1] as [any, int32, int32]])));
        }
        else {
            const v267: string = v15[0];
            const v271 = 1;
            const v273: int32 = v15.length | 0;
            const v274: string = v15.slice(v271, v273 + 1);
            if (method20(v267, 0n) === false) {
                const v281: string = v267;
                const v288: int32 = v281.length | 0;
                const v289: string[] = fill(new Array(v288), 0, v288, "");
                const v290: Mut5 = new Mut5(0);
                while (method13(v288, v290)) {
                    const v292: int32 = v290.l0 | 0;
                    const v293: string = v281[v292];
                    setItem(v289, v292, v293);
                    const v294: int32 = (v292 + 1) | 0;
                    v290.l0 = (v294 | 0);
                }
                const v295: FSharpList<string> = ofArray<string>(v289);
                const patternInput_1: [any, int32, int32] = method15(foldBack<string, UH0_$union>(uncurry2(method14()), v295, UH0_UH0_0()), v23, 1, 1);
                v359 = US5_US5_0(v267, v274, patternInput_1[0], patternInput_1[1], patternInput_1[2]);
            }
            else {
                v359 = US5_US5_1(toText(interpolate("parsing.none_of / unexpected char: \'%P()\' / chars: %A%P() / s: %A%P()", [v267, ["\"", "\'", " "], [v23, 1, 1] as [any, int32, int32]])));
            }
        }
        let v371: US5_$union;
        if (v359.tag === /* US5_0 */ 0) {
            const v360: string = v359.fields[0];
            v371 = US5_US5_0(("\\" === v360) ? "/" : v360, v359.fields[1], v359.fields[2], v359.fields[3], v359.fields[4]);
        }
        else {
            v371 = US5_US5_1(v359.fields[0]);
        }
        const v391: US6_$union = (v371.tag === /* US5_0 */ 0) ? method21(v371.fields[0], v371.fields[1], v371.fields[2], v371.fields[3], v371.fields[4]) : US6_US6_1(v371.fields[0]);
        if (v391.tag === /* US6_0 */ 0) {
            const v396: int32 = v391.fields[4] | 0;
            const v395: int32 = v391.fields[3] | 0;
            const v394: any = v391.fields[2];
            const v393: string = v391.fields[1];
            const v392: string = v391.fields[0];
            v435 = v391;
        }
        else {
            const v397: string = v391.fields[0];
            const v403: US8_$union = (v15.length === 0) ? US8_US8_0(v15, v23, 1, 1) : US8_US8_1(toText(interpolate("parsing.eof / expected end of input / input: %A%P()", [v15])));
            const v412: US6_$union = (v403.tag === /* US8_0 */ 0) ? US6_US6_0("", v403.fields[0], v403.fields[1], v403.fields[2], v403.fields[3]) : US6_US6_1(v403.fields[0]);
            if (v412.tag === /* US6_0 */ 0) {
                const v417: int32 = v412.fields[4] | 0;
                const v416: int32 = v412.fields[3] | 0;
                const v415: any = v412.fields[2];
                const v414: string = v412.fields[1];
                const v413: string = v412.fields[0];
                const v423: int32 = method22(v414, 0) | 0;
                const v425: int32 = v414.length | 0;
                v435 = US6_US6_0(v413, v414.slice(v423, v425 + 1), v415, v416, v417);
            }
            else {
                v435 = US6_US6_1(v412.fields[0]);
            }
        }
    }
    let v639: US9_$union;
    if (v435.tag === /* US6_0 */ 0) {
        const v440: int32 = v435.fields[4] | 0;
        const v439: int32 = v435.fields[3] | 0;
        const v438: any = v435.fields[2];
        const v437: string = v435.fields[1];
        const v436: string = v435.fields[0];
        let v522: US5_$union;
        if ("" === v437) {
            v522 = US5_US5_1(toText(interpolate("parsing.p_char / unexpected end of input / s: %A%P()", [[v438, v439, v440] as [any, int32, int32]])));
        }
        else {
            const v444: string = v437[0];
            if (v444 === " ") {
                const v449 = 1;
                const v451: int32 = v437.length | 0;
                const v452: string = v437.slice(v449, v451 + 1);
                const v456: string = v444;
                const v463: int32 = v456.length | 0;
                const v464: string[] = fill(new Array(v463), 0, v463, "");
                const v465: Mut5 = new Mut5(0);
                while (method13(v463, v465)) {
                    const v467: int32 = v465.l0 | 0;
                    const v468: string = v456[v467];
                    setItem(v464, v467, v468);
                    const v469: int32 = (v467 + 1) | 0;
                    v465.l0 = (v469 | 0);
                }
                const v470: FSharpList<string> = ofArray<string>(v464);
                const patternInput_2: [any, int32, int32] = method15(foldBack<string, UH0_$union>(uncurry2(method14()), v470, UH0_UH0_0()), v438, v439, v440);
                v522 = US5_US5_0(v444, v452, patternInput_2[0], patternInput_2[1], patternInput_2[2]);
            }
            else {
                const v492: int32 = v437.length | 0;
                const v495: int32 = (v437.indexOf("\n") - 1) | 0;
                const v499 = 0;
                const v501: int32 = ((-2 === v495) ? v492 : v495) | 0;
                v522 = US5_US5_1(`${`parsing.p_char / expected: '${" "}' / line: ${v439} / col: ${v440}
${v438}${v437.slice(v499, v501 + 1)}`}
${replicate(v440 - 1, " ") + "^"}
`);
            }
        }
        let v534: US10_$union;
        if (v522.tag === /* US5_0 */ 0) {
            v534 = US10_US10_0(US7_US7_0(v522.fields[0]), v522.fields[1], v522.fields[2], v522.fields[3], v522.fields[4]);
        }
        else {
            const v530: string = v522.fields[0];
            v534 = US10_US10_0(US7_US7_1(), v437, v438, v439, v440);
        }
        let v613: US6_$union;
        if (v534.tag === /* US10_0 */ 0) {
            const v539: int32 = v534.fields[4] | 0;
            const v538: int32 = v534.fields[3] | 0;
            const v537: any = v534.fields[2];
            const v536: string = v534.fields[1];
            const v535: US7_$union = v534.fields[0];
            let v589: US5_$union;
            if ("" === v536) {
                v589 = US5_US5_1(toText(interpolate("parsing.any_char / unexpected end of input / s: %A%P()", [[v537, v538, v539] as [any, int32, int32]])));
            }
            else {
                const v543: string = v536[0];
                const v547 = 1;
                const v549: int32 = v536.length | 0;
                const v550: string = v536.slice(v547, v549 + 1);
                const v554: string = v543;
                const v561: int32 = v554.length | 0;
                const v562: string[] = fill(new Array(v561), 0, v561, "");
                const v563: Mut5 = new Mut5(0);
                while (method13(v561, v563)) {
                    const v565: int32 = v563.l0 | 0;
                    const v566: string = v554[v565];
                    setItem(v562, v565, v566);
                    const v567: int32 = (v565 + 1) | 0;
                    v563.l0 = (v567 | 0);
                }
                const v568: FSharpList<string> = ofArray<string>(v562);
                const patternInput_3: [any, int32, int32] = method15(foldBack<string, UH0_$union>(uncurry2(method14()), v568, UH0_UH0_0()), v537, v538, v539);
                v589 = US5_US5_0(v543, v550, patternInput_3[0], patternInput_3[1], patternInput_3[2]);
            }
            v613 = ((v589.tag === /* US5_0 */ 0) ? method23(v589.fields[0], v589.fields[1], v589.fields[2], v589.fields[3], v589.fields[4]) : US6_US6_1(v589.fields[0]));
        }
        else {
            v613 = US6_US6_1(v534.fields[0]);
        }
        let v625: US11_$union;
        if (v613.tag === /* US6_0 */ 0) {
            v625 = US11_US11_0(US3_US3_0(v613.fields[0]), v613.fields[1], v613.fields[2], v613.fields[3], v613.fields[4]);
        }
        else {
            const v621: string = v613.fields[0];
            v625 = US11_US11_0(US3_US3_1(), v437, v438, v439, v440);
        }
        v639 = ((v625.tag === /* US11_0 */ 0) ? US9_US9_0(v436, v625.fields[0], v625.fields[1], v625.fields[2], v625.fields[3], v625.fields[4]) : US9_US9_1(v625.fields[0]));
    }
    else {
        v639 = US9_US9_1(v435.fields[0]);
    }
    if (v639.tag === /* US9_0 */ 0) {
        const v645: int32 = v639.fields[5] | 0;
        const v644: int32 = v639.fields[4] | 0;
        const v643: any = v639.fields[3];
        const v642: string = v639.fields[2];
        return US4_US4_0(v639.fields[0], v639.fields[1]);
    }
    else {
        return US4_US4_1(v639.fields[0]);
    }
}

export function closure14(unitVar: void, unitVar_1: void): string {
    return "runtime.execute_with_options_async";
}

export function closure15(v0: string, v1: Option<any>, v2_1: [string, string][], v3_1: Option<((arg0: [int32, string, boolean]) => any)>, v4: Option<((arg0: any) => void)>, v5: boolean, v6: Option<string>, unitVar: void): [string, Option<any>, [string, string][], Option<((arg0: [int32, string, boolean]) => any)>, Option<((arg0: any) => void)>, boolean, Option<string>] {
    return [v0, v1, v2_1, v3_1, v4, v5, v6] as [string, Option<any>, [string, string][], Option<((arg0: [int32, string, boolean]) => any)>, Option<((arg0: any) => void)>, boolean, Option<string>];
}

export function method26(v0: Mut4, v1: string): void {
    const v4 = `${v1}`;
    const v12_1: string = v0.l0 + v4;
    v0.l0 = v12_1;
}

export function method28(v0: Mut4, v1: Option<any>): void {
    method26(v0, toText(interpolate("%A%P()", [v1])));
}

export function method29(v0: Mut4, v1: [string, string][]): void {
    method26(v0, toText(interpolate("%A%P()", [v1])));
}

export function method30(v0: Mut4, v1: Option<((arg0: [int32, string, boolean]) => any)>): void {
    method26(v0, toText(interpolate("%A%P()", [v1])));
}

export function method31(v0: Mut4, v1: Option<((arg0: any) => void)>): void {
    method26(v0, toText(interpolate("%A%P()", [v1])));
}

export function method32(v0: Mut4, v1: boolean): void {
    const v7 = `${v1 ? "true" : "false"}`;
    const v15: string = v0.l0 + v7;
    v0.l0 = v15;
}

export function method33(v0: Mut4, v1: Option<string>): void {
    method26(v0, toText(interpolate("%A%P()", [v1])));
}

export function method27(v0: Mut4, v1: string, v2_1: Option<any>, v3_1: [string, string][], v4: Option<((arg0: [int32, string, boolean]) => any)>, v5: Option<((arg0: any) => void)>, v6: boolean, v7: Option<string>): void {
    method26(v0, "{ ");
    method9(v0);
    method26(v0, "command");
    method26(v0, " = ");
    method26(v0, v1);
    method26(v0, "; ");
    method26(v0, "cancellation_token");
    method26(v0, " = ");
    method28(v0, v2_1);
    method26(v0, "; ");
    method26(v0, "environment_variables");
    method26(v0, " = ");
    method29(v0, v3_1);
    method26(v0, "; ");
    method26(v0, "on_line");
    method26(v0, " = ");
    method30(v0, v4);
    method26(v0, "; ");
    method26(v0, "stdin");
    method26(v0, " = ");
    method31(v0, v5);
    method26(v0, "; ");
    method26(v0, "trace");
    method26(v0, " = ");
    method32(v0, v6);
    method26(v0, "; ");
    method26(v0, "working_directory");
    method26(v0, " = ");
    method33(v0, v7);
    method26(v0, " }");
}

export function method25(v0: Mut4, v1: string, v2_1: Option<any>, v3_1: [string, string][], v4: Option<((arg0: [int32, string, boolean]) => any)>, v5: Option<((arg0: any) => void)>, v6: boolean, v7: Option<string>): void {
    method26(v0, "{ ");
    method9(v0);
    method26(v0, "options");
    method26(v0, " = ");
    method27(v0, v1, v2_1, v3_1, v4, v5, v6, v7);
    method26(v0, " }");
}

export function closure16(v0: US0_$union, v1: (() => string), v2_1: (() => [string, Option<any>, [string, string][], Option<((arg0: [int32, string, boolean]) => any)>, Option<((arg0: any) => void)>, boolean, Option<string>]), unitVar: void): string {
    let v368: int64, v392: number;
    if (State_trace_state() == null) {
        State_trace_state(closure0(undefined, US0_US0_0()));
    }
    const patternInput: [Mut0, Mut1, Mut2, Mut3, Option<int64>] = value_12(State_trace_state());
    const v18: Option<int64> = patternInput[4];
    let _v35: Option<string> = undefined;
    const _v333: FSharpRef<Option<US2_$union>> = new FSharpRef<Option<US2_$union>>(undefined);
    let x_2: Option<US2_$union>;
    if (v18 == null) {
        x_2 = undefined;
    }
    else {
        const x: int64 = value_12(v18);
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
        v772 = value_12(_v35);
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
        v1141 = value_12(_v1029);
    }
    const v1160: int64 = patternInput[0].l0;
    const patternInput_1: [string, Option<any>, [string, string][], Option<((arg0: [int32, string, boolean]) => any)>, Option<((arg0: any) => void)>, boolean, Option<string>] = v2_1();
    const v1169: Mut4 = new Mut4("");
    method25(v1169, patternInput_1[0], patternInput_1[1], patternInput_1[2], patternInput_1[3], patternInput_1[4], patternInput_1[5], patternInput_1[6]);
    const v1170: string = v1169.l0;
    return trimEnd(trimStart(`${v772} ${v1141} #${v1160} ${v1()} / ${v1170}`, ...[]), ...[" ", "/"]);
}

export function method24(v0: US0_$union, v1: (() => string), v2_1: (() => [string, Option<any>, [string, string][], Option<((arg0: [int32, string, boolean]) => any)>, Option<((arg0: any) => void)>, boolean, Option<string>])): void {
    method10(v0, (): string => closure16(v0, v1, v2_1, undefined));
}

export function closure18(v0: string, unitVar: void): string {
    return v0;
}

export function closure17(v0: string, v1: Option<any>, v2_1: [string, string][], v3_1: Option<((arg0: [int32, string, boolean]) => any)>, v4: Option<((arg0: any) => void)>, v5: boolean, v6: Option<string>, v7: void, v8: any, v9_1: void): void {
    let _v12: Option<any> = undefined;
    const x: any = defaultOf();
    _v12 = x;
    let v126: any;
    if (_v12 == null) {
        throw new Error("base.run_target / _v12=None");
    }
    else {
        v126 = value_12(_v12);
    }
    let _v143: Option<void> = undefined;
    defaultOf();
    _v143 = some(undefined);
    if (_v143 == null) {
        throw new Error("base.run_target / _v143=None");
    }
    else {
        value_12(_v143);
    }
}

export function closure19(v0: string, v1: Option<any>, v2_1: [string, string][], v3_1: Option<((arg0: [int32, string, boolean]) => any)>, v4: Option<((arg0: any) => void)>, v5: boolean, v6: Option<string>, v7: void, v8: any, v9_1: void): void {
    let _v12: Option<any> = undefined;
    const x: any = defaultOf();
    _v12 = x;
    let v127: any;
    if (_v12 == null) {
        throw new Error("base.run_target / _v12=None");
    }
    else {
        v127 = value_12(_v12);
    }
    let _v144: Option<void> = undefined;
    defaultOf();
    _v144 = some(undefined);
    if (_v144 == null) {
        throw new Error("base.run_target / _v144=None");
    }
    else {
        value_12(_v144);
    }
}

export function closure20(v0: void, unitVar: void): void {
    let _v3: Option<boolean> = undefined;
    const x: boolean = defaultOf();
    _v3 = x;
    if (((_v3 == null) ? (() => {
        throw new Error("base.run_target / _v3=None");
    })() : value_12(_v3)) === false) {
        let _v68: Option<void> = undefined;
        defaultOf();
        _v68 = some(undefined);
        if (_v68 == null) {
            throw new Error("base.run_target / _v68=None");
        }
        else {
            value_12(_v68);
        }
    }
}

export function closure21(unitVar: void, unitVar_1: void): string {
    return "runtime.execute_with_options_async / WaitForExitAsync";
}

export function closure22(v0: any, unitVar: void): any {
    return v0;
}

export function method36(v0: Mut4, v1: any): void {
    method26(v0, toText(interpolate("%A%P()", [v1])));
}

export function method35(v0: Mut4, v1: any): void {
    method26(v0, "{ ");
    method9(v0);
    method26(v0, "ex");
    method26(v0, " = ");
    method36(v0, v1);
    method26(v0, " }");
}

export function closure23(v0: US0_$union, v1: (() => string), v2_1: (() => any), unitVar: void): string {
    let v368: int64, v392: number;
    if (State_trace_state() == null) {
        State_trace_state(closure0(undefined, US0_US0_0()));
    }
    const patternInput: [Mut0, Mut1, Mut2, Mut3, Option<int64>] = value_12(State_trace_state());
    const v18: Option<int64> = patternInput[4];
    let _v35: Option<string> = undefined;
    const _v333: FSharpRef<Option<US2_$union>> = new FSharpRef<Option<US2_$union>>(undefined);
    let x_2: Option<US2_$union>;
    if (v18 == null) {
        x_2 = undefined;
    }
    else {
        const x: int64 = value_12(v18);
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
        v772 = value_12(_v35);
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
        v1141 = value_12(_v1029);
    }
    const v1160: int64 = patternInput[0].l0;
    const v1163: Mut4 = new Mut4("");
    method35(v1163, v2_1());
    const v1164: string = v1163.l0;
    return trimEnd(trimStart(`${v772} ${v1141} #${v1160} ${v1()} / ${v1164}`, ...[]), ...[" ", "/"]);
}

export function method34(v0: US0_$union, v1: (() => string), v2_1: (() => any)): void {
    method10(v0, (): string => closure23(v0, v1, v2_1, undefined));
}

export function closure24(unitVar: void, unitVar_1: void): string {
    return "runtime.execute_with_options_async";
}

export function closure25(v0: int32, v1: string, unitVar: void): [int32, int32] {
    return [v0, v1.length] as [int32, int32];
}

export function method39(v0: Mut4, v1: int32): void {
    const v4 = `${v1}`;
    const v12_1: string = v0.l0 + v4;
    v0.l0 = v12_1;
}

export function method38(v0: Mut4, v1: int32, v2_1: int32): void {
    method26(v0, "{ ");
    method9(v0);
    method26(v0, "exit_code");
    method26(v0, " = ");
    method39(v0, v1);
    method26(v0, "; ");
    method26(v0, "output_length");
    method26(v0, " = ");
    method39(v0, v2_1);
    method26(v0, " }");
}

export function closure26(v0: US0_$union, v1: (() => string), v2_1: (() => [int32, int32]), unitVar: void): string {
    let v368: int64, v392: number;
    if (State_trace_state() == null) {
        State_trace_state(closure0(undefined, US0_US0_0()));
    }
    const patternInput: [Mut0, Mut1, Mut2, Mut3, Option<int64>] = value_12(State_trace_state());
    const v18: Option<int64> = patternInput[4];
    let _v35: Option<string> = undefined;
    const _v333: FSharpRef<Option<US2_$union>> = new FSharpRef<Option<US2_$union>>(undefined);
    let x_2: Option<US2_$union>;
    if (v18 == null) {
        x_2 = undefined;
    }
    else {
        const x: int64 = value_12(v18);
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
        v772 = value_12(_v35);
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
        v1141 = value_12(_v1029);
    }
    const v1160: int64 = patternInput[0].l0;
    const patternInput_1: [int32, int32] = v2_1();
    const v1164: Mut4 = new Mut4("");
    method38(v1164, patternInput_1[0], patternInput_1[1]);
    const v1165: string = v1164.l0;
    return trimEnd(trimStart(`${v772} ${v1141} #${v1160} ${v1()} / ${v1165}`, ...[]), ...[" ", "/"]);
}

export function method37(v0: US0_$union, v1: (() => string), v2_1: (() => [int32, int32])): void {
    method10(v0, (): string => closure26(v0, v1, v2_1, undefined));
}

export function method11(v0: string, v1: Option<any>, v2_1: [string, string][], v3_1: Option<((arg0: [int32, string, boolean]) => any)>, v4: Option<((arg0: any) => void)>, v5: boolean, v6: Option<string>): any {
    let _v9: Option<any> = undefined;
    const x: any = defaultOf();
    _v9 = x;
    if (_v9 == null) {
        throw new Error("base.run_target / _v9=None");
    }
    else {
        return value_12(_v9);
    }
}

export function closure9(unitVar: void, v0: string): any {
    return method11(v0, undefined, [], undefined, undefined, true, undefined);
}

export function closure27(unitVar: void, _arg: [string, Option<any>, [string, string][], Option<((arg0: [int32, string, boolean]) => any)>, Option<((arg0: any) => void)>, boolean, Option<string>]): any {
    return method11(_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6]);
}

export function closure28(unitVar: void, v0: ((arg0: Heap0) => Heap0)): [string, Option<any>, [string, string][], Option<((arg0: [int32, string, boolean]) => any)>, Option<((arg0: any) => void)>, boolean, Option<string>] {
    const v8: Heap0 = v0(new Heap0("", undefined, [], undefined, undefined, true, undefined));
    return [v8.l0, v8.l1, v8.l2, v8.l3, v8.l4, v8.l5, v8.l6] as [string, Option<any>, [string, string][], Option<((arg0: [int32, string, boolean]) => any)>, Option<((arg0: any) => void)>, boolean, Option<string>];
}

export function method42(v0_mut: string, v1_mut: int64): boolean {
    method42:
    while (true) {
        const v0: string = v0_mut, v1: int64 = v1_mut;
        if (compare_1(v1, 4n) >= 0) {
            return false;
        }
        else {
            let v19: US7_$union;
            if (equals(v1, 0n)) {
                v19 = US7_US7_0("\\");
            }
            else {
                const v5: int64 = toInt64(op_Subtraction(v1, 1n));
                if (equals(v5, 0n)) {
                    v19 = US7_US7_0("`");
                }
                else {
                    const v8: int64 = toInt64(op_Subtraction(v5, 1n));
                    if (equals(v8, 0n)) {
                        v19 = US7_US7_0("\"");
                    }
                    else {
                        const v11_1: int64 = toInt64(op_Subtraction(v8, 1n));
                        if (equals(v11_1, 0n)) {
                            v19 = US7_US7_0(" ");
                        }
                        else {
                            const v14: int64 = toInt64(op_Subtraction(v11_1, 1n));
                            v19 = US7_US7_1();
                        }
                    }
                }
            }
            if (v0 === ((v19.tag === /* US7_0 */ 0) ? v19.fields[0] : (() => {
                throw new Error("Option does not have a value.");
            })())) {
                return true;
            }
            else {
                v0_mut = v0;
                v1_mut = toInt64(op_Addition(v1, 1n));
                continue method42;
            }
        }
        break;
    }
}

export function method43(v0_mut: string, v1_mut: string, v2_1_mut: any, v3_1_mut: int32, v4_mut: int32): US6_$union {
    method43:
    while (true) {
        const v0: string = v0_mut, v1: string = v1_mut, v2_1: any = v2_1_mut, v3_1: int32 = v3_1_mut, v4: int32 = v4_mut;
        let v154: US5_$union;
        if ("" === v1) {
            v154 = US5_US5_1(toText(interpolate("parsing.none_of / unexpected end of input / chars: %A%P() / s: %A%P()", [["\\", "`", "\"", " "], [v2_1, v3_1, v4] as [any, int32, int32]])));
        }
        else {
            const v55: string = v1[0];
            const v59 = 1;
            const v61: int32 = v1.length | 0;
            const v62: string = v1.slice(v59, v61 + 1);
            if (method42(v55, 0n) === false) {
                const v69: string = v55;
                const v76: int32 = v69.length | 0;
                const v77: string[] = fill(new Array(v76), 0, v76, "");
                const v78: Mut5 = new Mut5(0);
                while (method13(v76, v78)) {
                    const v80: int32 = v78.l0 | 0;
                    const v81: string = v69[v80];
                    setItem(v77, v80, v81);
                    const v82: int32 = (v80 + 1) | 0;
                    v78.l0 = (v82 | 0);
                }
                const v83: FSharpList<string> = ofArray<string>(v77);
                const patternInput: [any, int32, int32] = method15(foldBack<string, UH0_$union>(uncurry2(method14()), v83, UH0_UH0_0()), v2_1, v3_1, v4);
                v154 = US5_US5_0(v55, v62, patternInput[0], patternInput[1], patternInput[2]);
            }
            else {
                v154 = US5_US5_1(toText(interpolate("parsing.none_of / unexpected char: \'%P()\' / chars: %A%P() / s: %A%P()", [v55, ["\\", "`", "\"", " "], [v2_1, v3_1, v4] as [any, int32, int32]])));
            }
        }
        if (v154.tag === /* US5_0 */ 0) {
            v0_mut = (v0 + v154.fields[0]);
            v1_mut = v154.fields[1];
            v2_1_mut = v154.fields[2];
            v3_1_mut = v154.fields[3];
            v4_mut = v154.fields[4];
            continue method43;
        }
        else {
            const v172: string = v154.fields[0];
            return US6_US6_0(v0, v1, v2_1, v3_1, v4);
        }
        break;
    }
}

export function method45(v0_mut: string, v1_mut: int64): boolean {
    method45:
    while (true) {
        const v0: string = v0_mut, v1: int64 = v1_mut;
        if (compare_1(v1, 3n) >= 0) {
            return false;
        }
        else {
            let v15: US7_$union;
            if (equals(v1, 0n)) {
                v15 = US7_US7_0("\\");
            }
            else {
                const v5: int64 = toInt64(op_Subtraction(v1, 1n));
                if (equals(v5, 0n)) {
                    v15 = US7_US7_0("`");
                }
                else {
                    const v8: int64 = toInt64(op_Subtraction(v5, 1n));
                    if (equals(v8, 0n)) {
                        v15 = US7_US7_0("\"");
                    }
                    else {
                        const v11_1: int64 = toInt64(op_Subtraction(v8, 1n));
                        v15 = US7_US7_1();
                    }
                }
            }
            if (v0 === ((v15.tag === /* US7_0 */ 0) ? v15.fields[0] : (() => {
                throw new Error("Option does not have a value.");
            })())) {
                return true;
            }
            else {
                v0_mut = v0;
                v1_mut = toInt64(op_Addition(v1, 1n));
                continue method45;
            }
        }
        break;
    }
}

export function closure30(unitVar: void, _arg: [string, any, int32, int32]): US6_$union {
    const v3_1: int32 = _arg[3] | 0;
    const v2_1: int32 = _arg[2] | 0;
    const v1: any = _arg[1];
    const v0: string = _arg[0];
    let v85: US5_$union;
    if ("" === v0) {
        v85 = US5_US5_1(toText(interpolate("parsing.p_char / unexpected end of input / s: %A%P()", [[v1, v2_1, v3_1] as [any, int32, int32]])));
    }
    else {
        const v7: string = v0[0];
        if (v7 === "\\") {
            const v12_1 = 1;
            const v14: int32 = v0.length | 0;
            const v15: string = v0.slice(v12_1, v14 + 1);
            const v19: string = v7;
            const v26: int32 = v19.length | 0;
            const v27: string[] = fill(new Array(v26), 0, v26, "");
            const v28: Mut5 = new Mut5(0);
            while (method13(v26, v28)) {
                const v30: int32 = v28.l0 | 0;
                const v31: string = v19[v30];
                setItem(v27, v30, v31);
                const v32: int32 = (v30 + 1) | 0;
                v28.l0 = (v32 | 0);
            }
            const v33: FSharpList<string> = ofArray<string>(v27);
            const patternInput: [any, int32, int32] = method15(foldBack<string, UH0_$union>(uncurry2(method14()), v33, UH0_UH0_0()), v1, v2_1, v3_1);
            v85 = US5_US5_0(v7, v15, patternInput[0], patternInput[1], patternInput[2]);
        }
        else {
            const v55: int32 = v0.length | 0;
            const v58: int32 = (v0.indexOf("\n") - 1) | 0;
            const v62 = 0;
            const v64: int32 = ((-2 === v58) ? v55 : v58) | 0;
            v85 = US5_US5_1(`${`parsing.p_char / expected: '${"\\"}' / line: ${v2_1} / col: ${v3_1}
${v1}${v0.slice(v62, v64 + 1)}`}
${replicate(v3_1 - 1, " ") + "^"}
`);
        }
    }
    let v144: US5_$union;
    if (v85.tag === /* US5_0 */ 0) {
        const v90: int32 = v85.fields[4] | 0;
        const v89: int32 = v85.fields[3] | 0;
        const v88: any = v85.fields[2];
        const v87: string = v85.fields[1];
        const v86: string = v85.fields[0];
        if ("" === v87) {
            v144 = US5_US5_1(toText(interpolate("parsing.any_char / unexpected end of input / s: %A%P()", [[v88, v89, v90] as [any, int32, int32]])));
        }
        else {
            const v94: string = v87[0];
            const v98 = 1;
            const v100: int32 = v87.length | 0;
            const v101: string = v87.slice(v98, v100 + 1);
            const v105: string = v94;
            const v112: int32 = v105.length | 0;
            const v113: string[] = fill(new Array(v112), 0, v112, "");
            const v114: Mut5 = new Mut5(0);
            while (method13(v112, v114)) {
                const v116: int32 = v114.l0 | 0;
                const v117: string = v105[v116];
                setItem(v113, v116, v117);
                const v118: int32 = (v116 + 1) | 0;
                v114.l0 = (v118 | 0);
            }
            const v119: FSharpList<string> = ofArray<string>(v113);
            const patternInput_1: [any, int32, int32] = method15(foldBack<string, UH0_$union>(uncurry2(method14()), v119, UH0_UH0_0()), v88, v89, v90);
            v144 = US5_US5_0(v94, v101, patternInput_1[0], patternInput_1[1], patternInput_1[2]);
        }
    }
    else {
        v144 = US5_US5_1(v85.fields[0]);
    }
    if (v144.tag === /* US5_0 */ 0) {
        return US6_US6_0(`${"\\"}${v144.fields[0]}`, v144.fields[1], v144.fields[2], v144.fields[3], v144.fields[4]);
    }
    else {
        return US6_US6_1(v144.fields[0]);
    }
}

export function closure31(unitVar: void, _arg: [string, any, int32, int32]): US6_$union {
    const v3_1: int32 = _arg[3] | 0;
    const v2_1: int32 = _arg[2] | 0;
    const v1: any = _arg[1];
    const v0: string = _arg[0];
    let v85: US5_$union;
    if ("" === v0) {
        v85 = US5_US5_1(toText(interpolate("parsing.p_char / unexpected end of input / s: %A%P()", [[v1, v2_1, v3_1] as [any, int32, int32]])));
    }
    else {
        const v7: string = v0[0];
        if (v7 === "`") {
            const v12_1 = 1;
            const v14: int32 = v0.length | 0;
            const v15: string = v0.slice(v12_1, v14 + 1);
            const v19: string = v7;
            const v26: int32 = v19.length | 0;
            const v27: string[] = fill(new Array(v26), 0, v26, "");
            const v28: Mut5 = new Mut5(0);
            while (method13(v26, v28)) {
                const v30: int32 = v28.l0 | 0;
                const v31: string = v19[v30];
                setItem(v27, v30, v31);
                const v32: int32 = (v30 + 1) | 0;
                v28.l0 = (v32 | 0);
            }
            const v33: FSharpList<string> = ofArray<string>(v27);
            const patternInput: [any, int32, int32] = method15(foldBack<string, UH0_$union>(uncurry2(method14()), v33, UH0_UH0_0()), v1, v2_1, v3_1);
            v85 = US5_US5_0(v7, v15, patternInput[0], patternInput[1], patternInput[2]);
        }
        else {
            const v55: int32 = v0.length | 0;
            const v58: int32 = (v0.indexOf("\n") - 1) | 0;
            const v62 = 0;
            const v64: int32 = ((-2 === v58) ? v55 : v58) | 0;
            v85 = US5_US5_1(`${`parsing.p_char / expected: '${"`"}' / line: ${v2_1} / col: ${v3_1}
${v1}${v0.slice(v62, v64 + 1)}`}
${replicate(v3_1 - 1, " ") + "^"}
`);
        }
    }
    let v144: US5_$union;
    if (v85.tag === /* US5_0 */ 0) {
        const v90: int32 = v85.fields[4] | 0;
        const v89: int32 = v85.fields[3] | 0;
        const v88: any = v85.fields[2];
        const v87: string = v85.fields[1];
        const v86: string = v85.fields[0];
        if ("" === v87) {
            v144 = US5_US5_1(toText(interpolate("parsing.any_char / unexpected end of input / s: %A%P()", [[v88, v89, v90] as [any, int32, int32]])));
        }
        else {
            const v94: string = v87[0];
            const v98 = 1;
            const v100: int32 = v87.length | 0;
            const v101: string = v87.slice(v98, v100 + 1);
            const v105: string = v94;
            const v112: int32 = v105.length | 0;
            const v113: string[] = fill(new Array(v112), 0, v112, "");
            const v114: Mut5 = new Mut5(0);
            while (method13(v112, v114)) {
                const v116: int32 = v114.l0 | 0;
                const v117: string = v105[v116];
                setItem(v113, v116, v117);
                const v118: int32 = (v116 + 1) | 0;
                v114.l0 = (v118 | 0);
            }
            const v119: FSharpList<string> = ofArray<string>(v113);
            const patternInput_1: [any, int32, int32] = method15(foldBack<string, UH0_$union>(uncurry2(method14()), v119, UH0_UH0_0()), v88, v89, v90);
            v144 = US5_US5_0(v94, v101, patternInput_1[0], patternInput_1[1], patternInput_1[2]);
        }
    }
    else {
        v144 = US5_US5_1(v85.fields[0]);
    }
    if (v144.tag === /* US5_0 */ 0) {
        return US6_US6_0(`${"`"}${v144.fields[0]}`, v144.fields[1], v144.fields[2], v144.fields[3], v144.fields[4]);
    }
    else {
        return US6_US6_1(v144.fields[0]);
    }
}

export function method46(v0_mut: string, v1_mut: any, v2_1_mut: int32, v3_1_mut: int32, v4_mut: UH3_$union): US6_$union {
    method46:
    while (true) {
        const v0: string = v0_mut, v1: any = v1_mut, v2_1: int32 = v2_1_mut, v3_1: int32 = v3_1_mut, v4: UH3_$union = v4_mut;
        if (v4.tag === /* UH3_0 */ 0) {
            return US6_US6_1("choice / no parsers succeeded");
        }
        else {
            const v8: UH3_$union = v4.fields[1];
            const v9_1: US6_$union = v4.fields[0]([v0, v1, v2_1, v3_1] as [string, any, int32, int32]);
            if (v9_1.tag === /* US6_0 */ 0) {
                const v14: int32 = v9_1.fields[4] | 0;
                const v13_1: int32 = v9_1.fields[3] | 0;
                const v12_1: any = v9_1.fields[2];
                const v11_1: string = v9_1.fields[1];
                const v10_1: string = v9_1.fields[0];
                return v9_1;
            }
            else {
                const v15: string = v9_1.fields[0];
                v0_mut = v0;
                v1_mut = v1;
                v2_1_mut = v2_1;
                v3_1_mut = v3_1;
                v4_mut = v8;
                continue method46;
            }
        }
        break;
    }
}

export function method47(v0_mut: UH2_$union, v1_mut: UH2_$union): UH2_$union {
    method47:
    while (true) {
        const v0: UH2_$union = v0_mut, v1: UH2_$union = v1_mut;
        if (v0.tag === /* UH2_0 */ 0) {
            return v1;
        }
        else {
            v0_mut = v0.fields[1];
            v1_mut = UH2_UH2_1(v0.fields[0], v1);
            continue method47;
        }
        break;
    }
}

export function method44(v0_mut: UH2_$union, v1_mut: string, v2_1_mut: any, v3_1_mut: int32, v4_mut: int32): US15_$union {
    method44:
    while (true) {
        const v0: UH2_$union = v0_mut, v1: string = v1_mut, v2_1: any = v2_1_mut, v3_1: int32 = v3_1_mut, v4: int32 = v4_mut;
        let v136: US5_$union;
        if ("" === v1) {
            v136 = US5_US5_1(toText(interpolate("parsing.none_of / unexpected end of input / chars: %A%P() / s: %A%P()", [["\\", "`", "\""], [v2_1, v3_1, v4] as [any, int32, int32]])));
        }
        else {
            const v46: string = v1[0];
            const v50 = 1;
            const v52: int32 = v1.length | 0;
            const v53: string = v1.slice(v50, v52 + 1);
            if (method45(v46, 0n) === false) {
                const v60: string = v46;
                const v67: int32 = v60.length | 0;
                const v68: string[] = fill(new Array(v67), 0, v67, "");
                const v69: Mut5 = new Mut5(0);
                while (method13(v67, v69)) {
                    const v71: int32 = v69.l0 | 0;
                    const v72: string = v60[v71];
                    setItem(v68, v71, v72);
                    const v73: int32 = (v71 + 1) | 0;
                    v69.l0 = (v73 | 0);
                }
                const v74: FSharpList<string> = ofArray<string>(v68);
                const patternInput: [any, int32, int32] = method15(foldBack<string, UH0_$union>(uncurry2(method14()), v74, UH0_UH0_0()), v2_1, v3_1, v4);
                v136 = US5_US5_0(v46, v53, patternInput[0], patternInput[1], patternInput[2]);
            }
            else {
                v136 = US5_US5_1(toText(interpolate("parsing.none_of / unexpected char: \'%P()\' / chars: %A%P() / s: %A%P()", [v46, ["\\", "`", "\""], [v2_1, v3_1, v4] as [any, int32, int32]])));
            }
        }
        const v156: US6_$union = (v136.tag === /* US5_0 */ 0) ? US6_US6_0(v136.fields[0], v136.fields[1], v136.fields[2], v136.fields[3], v136.fields[4]) : US6_US6_1(v136.fields[0]);
        let v170: US6_$union;
        if (v156.tag === /* US6_0 */ 0) {
            const v161: int32 = v156.fields[4] | 0;
            const v160: int32 = v156.fields[3] | 0;
            const v159: any = v156.fields[2];
            const v158: string = v156.fields[1];
            const v157: string = v156.fields[0];
            v170 = v156;
        }
        else {
            const v162: string = v156.fields[0];
            v170 = method46(v1, v2_1, v3_1, v4, UH3_UH3_1((arg10$0040: [string, any, int32, int32]): US6_$union => closure30(undefined, arg10$0040), UH3_UH3_1((arg10$0040_1: [string, any, int32, int32]): US6_$union => closure31(undefined, arg10$0040_1), UH3_UH3_0())));
        }
        if (v170.tag === /* US6_0 */ 0) {
            v0_mut = UH2_UH2_1(v170.fields[0], v0);
            v1_mut = v170.fields[1];
            v2_1_mut = v170.fields[2];
            v3_1_mut = v170.fields[3];
            v4_mut = v170.fields[4];
            continue method44;
        }
        else {
            const v178: string = v170.fields[0];
            return US15_US15_0(method47(v0, UH2_UH2_0()), v1, v2_1, v3_1, v4);
        }
        break;
    }
}

export function method48(v0: UH2_$union, v1: FSharpList<string>): FSharpList<string> {
    if (v0.tag === /* UH2_0 */ 0) {
        return v1;
    }
    else {
        return cons(v0.fields[0], method48(v0.fields[1], v1));
    }
}

export function method49(v0_mut: UH2_$union, v1_mut: string, v2_1_mut: any, v3_1_mut: int32, v4_mut: int32): US15_$union {
    method49:
    while (true) {
        const v0: UH2_$union = v0_mut, v1: string = v1_mut, v2_1: any = v2_1_mut, v3_1: int32 = v3_1_mut, v4: int32 = v4_mut;
        let v136: US5_$union;
        if ("" === v1) {
            v136 = US5_US5_1(toText(interpolate("parsing.none_of / unexpected end of input / chars: %A%P() / s: %A%P()", [["\\", "`", "\""], [v2_1, v3_1, v4] as [any, int32, int32]])));
        }
        else {
            const v46: string = v1[0];
            const v50 = 1;
            const v52: int32 = v1.length | 0;
            const v53: string = v1.slice(v50, v52 + 1);
            if (method45(v46, 0n) === false) {
                const v60: string = v46;
                const v67: int32 = v60.length | 0;
                const v68: string[] = fill(new Array(v67), 0, v67, "");
                const v69: Mut5 = new Mut5(0);
                while (method13(v67, v69)) {
                    const v71: int32 = v69.l0 | 0;
                    const v72: string = v60[v71];
                    setItem(v68, v71, v72);
                    const v73: int32 = (v71 + 1) | 0;
                    v69.l0 = (v73 | 0);
                }
                const v74: FSharpList<string> = ofArray<string>(v68);
                const patternInput: [any, int32, int32] = method15(foldBack<string, UH0_$union>(uncurry2(method14()), v74, UH0_UH0_0()), v2_1, v3_1, v4);
                v136 = US5_US5_0(v46, v53, patternInput[0], patternInput[1], patternInput[2]);
            }
            else {
                v136 = US5_US5_1(toText(interpolate("parsing.none_of / unexpected char: \'%P()\' / chars: %A%P() / s: %A%P()", [v46, ["\\", "`", "\""], [v2_1, v3_1, v4] as [any, int32, int32]])));
            }
        }
        const v156: US6_$union = (v136.tag === /* US5_0 */ 0) ? US6_US6_0(v136.fields[0], v136.fields[1], v136.fields[2], v136.fields[3], v136.fields[4]) : US6_US6_1(v136.fields[0]);
        if (v156.tag === /* US6_0 */ 0) {
            v0_mut = UH2_UH2_1(v156.fields[0], v0);
            v1_mut = v156.fields[1];
            v2_1_mut = v156.fields[2];
            v3_1_mut = v156.fields[3];
            v4_mut = v156.fields[4];
            continue method49;
        }
        else {
            const v164: string = v156.fields[0];
            return US15_US15_0(method47(v0, UH2_UH2_0()), v1, v2_1, v3_1, v4);
        }
        break;
    }
}

export function method50(v0_mut: string, v1_mut: int32): int32 {
    method50:
    while (true) {
        const v0: string = v0_mut, v1: int32 = v1_mut;
        if (v1 >= v0.length) {
            return v1 | 0;
        }
        else if (v0[v1] === " ") {
            v0_mut = v0;
            v1_mut = (v1 + 1);
            continue method50;
        }
        else {
            return v1 | 0;
        }
        break;
    }
}

export function method41(v0_mut: UH2_$union, v1_mut: string, v2_1_mut: any, v3_1_mut: int32, v4_mut: int32): US15_$union {
    method41:
    while (true) {
        const v0: UH2_$union = v0_mut, v1: string = v1_mut, v2_1: any = v2_1_mut, v3_1: int32 = v3_1_mut, v4: int32 = v4_mut;
        const v5: boolean = "" === v1;
        let v154: US5_$union;
        if (v5) {
            v154 = US5_US5_1(toText(interpolate("parsing.none_of / unexpected end of input / chars: %A%P() / s: %A%P()", [["\\", "`", "\"", " "], [v2_1, v3_1, v4] as [any, int32, int32]])));
        }
        else {
            const v55: string = v1[0];
            const v59 = 1;
            const v61: int32 = v1.length | 0;
            const v62: string = v1.slice(v59, v61 + 1);
            if (method42(v55, 0n) === false) {
                const v69: string = v55;
                const v76: int32 = v69.length | 0;
                const v77: string[] = fill(new Array(v76), 0, v76, "");
                const v78: Mut5 = new Mut5(0);
                while (method13(v76, v78)) {
                    const v80: int32 = v78.l0 | 0;
                    const v81: string = v69[v80];
                    setItem(v77, v80, v81);
                    const v82: int32 = (v80 + 1) | 0;
                    v78.l0 = (v82 | 0);
                }
                const v83: FSharpList<string> = ofArray<string>(v77);
                const patternInput: [any, int32, int32] = method15(foldBack<string, UH0_$union>(uncurry2(method14()), v83, UH0_UH0_0()), v2_1, v3_1, v4);
                v154 = US5_US5_0(v55, v62, patternInput[0], patternInput[1], patternInput[2]);
            }
            else {
                v154 = US5_US5_1(toText(interpolate("parsing.none_of / unexpected char: \'%P()\' / chars: %A%P() / s: %A%P()", [v55, ["\\", "`", "\"", " "], [v2_1, v3_1, v4] as [any, int32, int32]])));
            }
        }
        const v174: US6_$union = (v154.tag === /* US5_0 */ 0) ? method43(v154.fields[0], v154.fields[1], v154.fields[2], v154.fields[3], v154.fields[4]) : US6_US6_1(v154.fields[0]);
        let v479: US6_$union;
        if (v174.tag === /* US6_0 */ 0) {
            const v179: int32 = v174.fields[4] | 0;
            const v178: int32 = v174.fields[3] | 0;
            const v177: any = v174.fields[2];
            const v176: string = v174.fields[1];
            const v175: string = v174.fields[0];
            v479 = v174;
        }
        else {
            const v180: string = v174.fields[0];
            let v261: US5_$union;
            if (v5) {
                v261 = US5_US5_1(toText(interpolate("parsing.p_char / unexpected end of input / s: %A%P()", [[v2_1, v3_1, v4] as [any, int32, int32]])));
            }
            else {
                const v183: string = v1[0];
                if (v183 === "\"") {
                    const v188 = 1;
                    const v190: int32 = v1.length | 0;
                    const v191: string = v1.slice(v188, v190 + 1);
                    const v195: string = v183;
                    const v202: int32 = v195.length | 0;
                    const v203: string[] = fill(new Array(v202), 0, v202, "");
                    const v204: Mut5 = new Mut5(0);
                    while (method13(v202, v204)) {
                        const v206: int32 = v204.l0 | 0;
                        const v207: string = v195[v206];
                        setItem(v203, v206, v207);
                        const v208: int32 = (v206 + 1) | 0;
                        v204.l0 = (v208 | 0);
                    }
                    const v209: FSharpList<string> = ofArray<string>(v203);
                    const patternInput_1: [any, int32, int32] = method15(foldBack<string, UH0_$union>(uncurry2(method14()), v209, UH0_UH0_0()), v2_1, v3_1, v4);
                    v261 = US5_US5_0(v183, v191, patternInput_1[0], patternInput_1[1], patternInput_1[2]);
                }
                else {
                    const v231: int32 = v1.length | 0;
                    const v234: int32 = (v1.indexOf("\n") - 1) | 0;
                    const v238 = 0;
                    const v240: int32 = ((-2 === v234) ? v231 : v234) | 0;
                    v261 = US5_US5_1(`${`parsing.p_char / expected: '${"\""}' / line: ${v3_1} / col: ${v4}
${v2_1}${v1.slice(v238, v240 + 1)}`}
${replicate(v4 - 1, " ") + "^"}
`);
                }
            }
            let v408: US6_$union;
            if (v261.tag === /* US5_0 */ 0) {
                const v266: int32 = v261.fields[4] | 0;
                const v265: int32 = v261.fields[3] | 0;
                const v264: any = v261.fields[2];
                const v263: string = v261.fields[1];
                const v262: string = v261.fields[0];
                const v268: US15_$union = method44(UH2_UH2_0(), v263, v264, v265, v266);
                let v301: US6_$union;
                if (v268.tag === /* US15_0 */ 0) {
                    const v273: int32 = v268.fields[4] | 0;
                    const v272: int32 = v268.fields[3] | 0;
                    const v271: any = v268.fields[2];
                    const v270: string = v268.fields[1];
                    const v275: FSharpList<string> = method48(v268.fields[0], empty<string>());
                    v301 = US6_US6_0(join("", delay<string>((): Iterable<string> => map<int32, string>((i: int32): string => item(i, v275), rangeDouble(0, 1, length(v275) - 1)))), v270, v271, v272, v273);
                }
                else {
                    v301 = US6_US6_1(v268.fields[0]);
                }
                if (v301.tag === /* US6_0 */ 0) {
                    const v306: int32 = v301.fields[4] | 0;
                    const v305: int32 = v301.fields[3] | 0;
                    const v304: any = v301.fields[2];
                    const v303: string = v301.fields[1];
                    const v302: string = v301.fields[0];
                    let v388: US5_$union;
                    if ("" === v303) {
                        v388 = US5_US5_1(toText(interpolate("parsing.p_char / unexpected end of input / s: %A%P()", [[v304, v305, v306] as [any, int32, int32]])));
                    }
                    else {
                        const v310: string = v303[0];
                        if (v310 === "\"") {
                            const v315 = 1;
                            const v317: int32 = v303.length | 0;
                            const v318: string = v303.slice(v315, v317 + 1);
                            const v322: string = v310;
                            const v329: int32 = v322.length | 0;
                            const v330: string[] = fill(new Array(v329), 0, v329, "");
                            const v331: Mut5 = new Mut5(0);
                            while (method13(v329, v331)) {
                                const v333: int32 = v331.l0 | 0;
                                const v334: string = v322[v333];
                                setItem(v330, v333, v334);
                                const v335: int32 = (v333 + 1) | 0;
                                v331.l0 = (v335 | 0);
                            }
                            const v336: FSharpList<string> = ofArray<string>(v330);
                            const patternInput_2: [any, int32, int32] = method15(foldBack<string, UH0_$union>(uncurry2(method14()), v336, UH0_UH0_0()), v304, v305, v306);
                            v388 = US5_US5_0(v310, v318, patternInput_2[0], patternInput_2[1], patternInput_2[2]);
                        }
                        else {
                            const v358: int32 = v303.length | 0;
                            const v361: int32 = (v303.indexOf("\n") - 1) | 0;
                            const v365 = 0;
                            const v367: int32 = ((-2 === v361) ? v358 : v361) | 0;
                            v388 = US5_US5_1(`${`parsing.p_char / expected: '${"\""}' / line: ${v305} / col: ${v306}
${v304}${v303.slice(v365, v367 + 1)}`}
${replicate(v306 - 1, " ") + "^"}
`);
                        }
                    }
                    if (v388.tag === /* US5_0 */ 0) {
                        const v389: string = v388.fields[0];
                        v408 = US6_US6_0(v302, v388.fields[1], v388.fields[2], v388.fields[3], v388.fields[4]);
                    }
                    else {
                        v408 = US6_US6_1(toText(interpolate("between / expected closing delimiter / e: %A%P() / input: %A%P() / rest1: %A%P() / rest2: %A%P()", [v388.fields[0], [v1, v2_1, v3_1, v4] as [string, any, int32, int32], [v263, v264, v265, v266] as [string, any, int32, int32], [v303, v304, v305, v306] as [string, any, int32, int32]])));
                    }
                }
                else {
                    const v400: string = v301.fields[0];
                    v408 = US6_US6_1("between / expected content");
                }
            }
            else {
                v408 = US6_US6_1(v261.fields[0]);
            }
            if (v408.tag === /* US6_0 */ 0) {
                const v413: int32 = v408.fields[4] | 0;
                const v412: int32 = v408.fields[3] | 0;
                const v411: any = v408.fields[2];
                const v410: string = v408.fields[1];
                const v409: string = v408.fields[0];
                v479 = v408;
            }
            else {
                const v414: string = v408.fields[0];
                const v420: US6_$union = method46(v1, v2_1, v3_1, v4, UH3_UH3_1((arg10$0040: [string, any, int32, int32]): US6_$union => closure30(undefined, arg10$0040), UH3_UH3_1((arg10$0040_1: [string, any, int32, int32]): US6_$union => closure31(undefined, arg10$0040_1), UH3_UH3_0())));
                let v431: US6_$union;
                if (v420.tag === /* US6_0 */ 0) {
                    const v421: string = v420.fields[0];
                    v431 = US6_US6_0("", v420.fields[1], v420.fields[2], v420.fields[3], v420.fields[4]);
                }
                else {
                    v431 = US6_US6_1(v420.fields[0]);
                }
                let v442: US15_$union;
                if (v431.tag === /* US6_0 */ 0) {
                    const v432: string = v431.fields[0];
                    v442 = method49(UH2_UH2_0(), v431.fields[1], v431.fields[2], v431.fields[3], v431.fields[4]);
                }
                else {
                    v442 = US15_US15_1(v431.fields[0]);
                }
                if (v442.tag === /* US15_0 */ 0) {
                    const v447: int32 = v442.fields[4] | 0;
                    const v446: int32 = v442.fields[3] | 0;
                    const v445: any = v442.fields[2];
                    const v444: string = v442.fields[1];
                    const v449: FSharpList<string> = method48(v442.fields[0], empty<string>());
                    v479 = US6_US6_0(join("", delay<string>((): Iterable<string> => map<int32, string>((i_1: int32): string => item(i_1, v449), rangeDouble(0, 1, length(v449) - 1)))), v444, v445, v446, v447);
                }
                else {
                    v479 = US6_US6_1(v442.fields[0]);
                }
            }
        }
        if (v479.tag === /* US6_0 */ 0) {
            const v488: int32 = v479.fields[4] | 0;
            const v487: int32 = v479.fields[3] | 0;
            const v486: any = v479.fields[2];
            const v485: string = v479.fields[1];
            const v484: string = v479.fields[0];
            const v490: int32 = method50(v485, 0) | 0;
            let v502: US8_$union;
            if (0 === v490) {
                v502 = US8_US8_1("spaces1 / expected at least one space");
            }
            else {
                const v497: int32 = v490 | 0;
                const v499: int32 = v485.length | 0;
                v502 = US8_US8_0(v485.slice(v497, v499 + 1), v486, v487, v488);
            }
            if (v502.tag === /* US8_0 */ 0) {
                v0_mut = UH2_UH2_1(v484, v0);
                v1_mut = v502.fields[0];
                v2_1_mut = v502.fields[1];
                v3_1_mut = v502.fields[2];
                v4_mut = v502.fields[3];
                continue method41;
            }
            else {
                const v503: string = v502.fields[0];
                return US15_US15_0(method47(v0, UH2_UH2_1(v484, UH2_UH2_0())), v485, v486, v487, v488);
            }
        }
        else {
            const v480: string = v479.fields[0];
            return US15_US15_0(method47(v0, UH2_UH2_0()), v1, v2_1, v3_1, v4);
        }
        break;
    }
}

export function method40(v0: string): US14_$union {
    let _v0: Option<Option<string>> = undefined;
    _v0 = some(v0);
    const v27: US15_$union = method41(UH2_UH2_0(), defaultArg((_v0 == null) ? (() => {
        throw new Error("optionm\'.of_obj / _v0=None");
    })() : value_12(_v0), ""), StringBuilder_$ctor_Z721C83C5(""), 1, 1);
    if (v27.tag === /* US15_0 */ 0) {
        const v32: int32 = v27.fields[4] | 0;
        const v31: int32 = v27.fields[3] | 0;
        const v30: any = v27.fields[2];
        const v29: string = v27.fields[1];
        return US14_US14_0(toArray<string>(method48(v27.fields[0], empty<string>())));
    }
    else {
        return US14_US14_1(v27.fields[0]);
    }
}

export function closure29(unitVar: void, v0: string): FSharpResult$2_$union<string[], string> {
    const v1: US14_$union = method40(v0);
    if (v1.tag === /* US14_0 */ 0) {
        return FSharpResult$2_Ok<string[], string>(v1.fields[0]);
    }
    else {
        return FSharpResult$2_Error<string[], string>(v1.fields[0]);
    }
}

export const v2 = (v: US0_$union): [Mut0, Mut1, Mut2, Mut3, Option<int64>] => closure0(undefined, v);

export const v3: US0_$union = US0_US0_0();

if (State_trace_state() == null) {
    State_trace_state(v2(v3));
}

export const v9 = (): void => {
    closure2(undefined, undefined);
};

export function current_process_kill(): void {
    v9();
}

export const v10 = (v: string): any => closure9(undefined, v);

export function execute_async(x: string): any {
    return v10(x);
}

export const v11 = (arg10$0040: [string, Option<any>, [string, string][], Option<((arg0: [int32, string, boolean]) => any)>, Option<((arg0: any) => void)>, boolean, Option<string>]): any => closure27(undefined, arg10$0040);

export function execute_with_options_async(x: [string, Option<any>, [string, string][], Option<((arg0: [int32, string, boolean]) => any)>, Option<((arg0: any) => void)>, boolean, Option<string>]): any {
    return v11(x);
}

export const v12 = (v: ((arg0: Heap0) => Heap0)): [string, Option<any>, [string, string][], Option<((arg0: [int32, string, boolean]) => any)>, Option<((arg0: any) => void)>, boolean, Option<string>] => closure28(undefined, v);

export function execution_options(x: ((arg0: Heap0) => Heap0)): [string, Option<any>, [string, string][], Option<((arg0: [int32, string, boolean]) => any)>, Option<((arg0: any) => void)>, boolean, Option<string>] {
    return v12(x);
}

export const v13 = (v: string): FSharpResult$2_$union<string[], string> => closure29(undefined, v);

export function split_args(x: string): FSharpResult$2_$union<string[], string> {
    return v13(x);
}


